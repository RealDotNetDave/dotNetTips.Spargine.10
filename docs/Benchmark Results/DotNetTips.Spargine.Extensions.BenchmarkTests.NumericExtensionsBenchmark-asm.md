## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.NumericExtensionsBenchmark.ToWords()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1F8
       lea       rbp,[rsp+220]
       xor       eax,eax
       mov       [rbp-1F8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+138]
       mov       [rbp-2C],eax
       cmp       dword ptr [rbp-2C],0
       je        near ptr M00_L82
       cmp       dword ptr [rbp-2C],0
       jl        near ptr M00_L83
       mov       rax,24ACB801DB0
       mov       rax,[rax]
       cmp       qword ptr [rax+8],0
       jne       near ptr M00_L85
       mov       rbx,[rax+18]
M00_L01:
       mov       r8,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rbx],r8
       jne       near ptr M00_L87
       mov       r8,[rbx+20]
       mov       [rbp-0B0],r8
       cmp       qword ptr [rbp-0B0],0
       je        near ptr M00_L78
       lea       r8,[rbx+20]
       mov       rdx,[rbp-0B0]
       test      r8,r8
       je        near ptr M00_L86
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      00007FFA665CCC60
       cmp       rax,[rbp-0B0]
       jne       near ptr M00_L78
M00_L02:
       mov       rbx,[rbp-0B0]
M00_L03:
       xor       ecx,ecx
       mov       [rbp-0B0],rcx
M00_L04:
       mov       [rbp-1D8],rbx
       mov       ecx,[rbp-2C]
       imul      rcx,431BDE83
       shr       rcx,32
       test      ecx,ecx
       jg        near ptr M00_L38
M00_L05:
       mov       edx,10624DD3
       mov       eax,edx
       imul      dword ptr [rbp-2C]
       mov       esi,edx
       shr       esi,1F
       sar       edx,6
       add       esi,edx
       test      esi,esi
       jg        near ptr M00_L24
M00_L06:
       mov       edx,51EB851F
       mov       eax,edx
       imul      dword ptr [rbp-2C]
       mov       esi,edx
       shr       esi,1F
       sar       edx,5
       add       esi,edx
       test      esi,esi
       jg        near ptr M00_L29
M00_L07:
       cmp       dword ptr [rbp-2C],0
       jle       near ptr M00_L23
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       test      eax,eax
       jg        near ptr M00_L34
M00_L08:
       mov       rax,offset MT_System.String[]
       mov       [rbp-170],rax
       lea       rax,[rbp-170]
       mov       dword ptr [rax+8],14
       lea       rax,[rbp-170]
       mov       [rbp-38],rax
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rbx,rax
       mov       rsi,offset MT_System.Resources.ResourceManager
       cmp       [rbx],rsi
       jne       near ptr M00_L64
       mov       rdi,24ACB802100
       mov       rdi,[rdi]
       test      rdi,rdi
       jne       short M00_L10
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L54
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L54
M00_L09:
       mov       rdi,[rax+18]
       test      rdi,rdi
       jne       short M00_L10
       mov       rax,24ACB800108
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M00_L10
       mov       rax,24ACB8000F8
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M00_L10
       call      qword ptr [7FFA06B94150]; System.Globalization.CultureInfo.InitializeUserDefaultUICulture()
       mov       rdi,rax
M00_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFA06D86568]; System.Resources.ResourceManager.GetFirstResourceSet(System.Globalization.CultureInfo)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L57
       movzx     r8d,byte ptr [rbx+54]
       mov       rcx,offset MT_System.Resources.RuntimeResourceSet
       cmp       [rsi],rcx
       jne       near ptr M00_L56
       mov       rcx,rsi
       mov       rdx,28B608B0990
       mov       r9d,1
       call      qword ptr [7FFA06D86F58]; System.Resources.RuntimeResourceSet.GetObject(System.String, Boolean, Boolean)
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L11
       mov       rcx,offset MT_System.String
       cmp       [rdx],rcx
       jne       near ptr M00_L55
M00_L11:
       test      rdx,rdx
       je        near ptr M00_L57
M00_L12:
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rsi,offset MT_System.Resources.ResourceManager
       cmp       [rax],rsi
       jne       near ptr M00_L65
       mov       rdi,24ACB802100
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B09B0
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M00_L13:
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],rsi
       jne       near ptr M00_L66
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B09D0
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M00_L14:
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],rsi
       jne       near ptr M00_L67
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B09F0
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M00_L15:
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],rsi
       jne       near ptr M00_L68
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B0A10
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M00_L16:
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+30]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],rsi
       jne       near ptr M00_L69
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B0A30
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M00_L17:
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+38]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],rsi
       jne       near ptr M00_L70
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B0A50
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M00_L18:
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+40]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],rsi
       jne       near ptr M00_L71
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B0A70
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M00_L19:
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+48]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],rsi
       jne       near ptr M00_L72
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B0A90
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M00_L20:
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+50]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],rsi
       jne       near ptr M00_L73
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B0AB0
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M00_L21:
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+58]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],rsi
       jne       near ptr M00_L74
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B0AD0
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M00_L22:
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+60]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF138]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eleven()
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+68]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF150]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Twelve()
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+70]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF168]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thirteen()
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+78]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF180]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Fourteen()
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+80]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF198]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Fifteen()
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+88]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Sixteen()
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+90]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1C8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Seventeen()
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+98]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1E0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eighteen()
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+0A0]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1F8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Nineteen()
       mov       rcx,[rbp-38]
       lea       rcx,[rcx+0A8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,offset MT_System.String[]
       mov       [rbp-1D0],rax
       lea       rax,[rbp-1D0]
       mov       dword ptr [rax+8],0A
       lea       rbx,[rbp-1D0]
       call      qword ptr [7FFA06FCEF40]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF120]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Ten()
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF210]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Twenty()
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF228]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thirty()
       lea       rcx,[rbx+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF240]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Forty()
       lea       rcx,[rbx+30]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF258]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Fifty()
       lea       rcx,[rbx+38]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF270]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Sixty()
       lea       rcx,[rbx+40]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF288]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Seventy()
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF2A0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eighty()
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF2B8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Ninety()
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       dword ptr [rbp-2C],14
       jl        near ptr M00_L37
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rbp-2C]
       mov       esi,edx
       shr       esi,1F
       sar       edx,2
       add       esi,edx
       cmp       esi,0A
       jae       near ptr M00_L62
       mov       edx,esi
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,[rbp-1D8]
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
       lea       ecx,[rsi+rsi*4]
       add       ecx,ecx
       mov       ebx,[rbp-2C]
       sub       ebx,ecx
       test      ebx,ebx
       jle       short M00_L23
       lea       rcx,[rbp-50]
       mov       r9,[rbp-1D8]
       xor       edx,edx
       mov       r8d,2
       call      qword ptr [7FFA06FCEF88]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-68],xmm0
       mov       rcx,[rbp-40]
       mov       [rbp-58],rcx
       lea       rcx,[rbp-68]
       mov       edx,2D
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       ebx,14
       jae       near ptr M00_L62
       mov       ecx,ebx
       mov       rdx,[rbp-38]
       mov       r8,[rdx+rcx*8+10]
       cmp       byte ptr [rbp-58],0
       jne       near ptr M00_L75
       mov       rcx,[rbp-68]
       mov       rdx,r8
       cmp       [rcx],ecx
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
M00_L23:
       mov       rcx,[rbp-1D8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA06B62100]; System.Text.StringBuilder.ToString()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFA06D842A0]; System.String.Trim()
       mov       rbx,rax
       jmp       near ptr M00_L76
M00_L24:
       mov       [rbp-68],rbx
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       byte ptr [rbp-58],0
       mov       ecx,esi
       call      qword ptr [7FFA06FCEF10]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
       cmp       byte ptr [rbp-58],0
       jne       near ptr M00_L41
       mov       rdi,[rbp-68]
       cmp       [rdi],dil
       test      rax,rax
       je        short M00_L26
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L26
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        near ptr M00_L40
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L39
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFA06975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L25:
       mov       [rdi+18],r14d
M00_L26:
       lea       rcx,[rbp-68]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFA06FCEFE8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       cmp       byte ptr [rbp-58],0
       jne       near ptr M00_L44
       mov       rdi,[rbp-68]
       cmp       [rdi],dil
       test      rax,rax
       je        short M00_L28
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L28
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        near ptr M00_L43
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L42
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFA06975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L27:
       mov       [rdi+18],r14d
M00_L28:
       lea       rcx,[rbp-68]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       [rbx],bl
       imul      eax,esi,3E8
       mov       edx,[rbp-2C]
       sub       edx,eax
       mov       [rbp-2C],edx
       jmp       near ptr M00_L06
M00_L29:
       mov       [rbp-68],rbx
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       byte ptr [rbp-58],0
       mov       ecx,esi
       call      qword ptr [7FFA06FCEF10]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
       cmp       byte ptr [rbp-58],0
       jne       near ptr M00_L47
       mov       rdi,[rbp-68]
       cmp       [rdi],dil
       test      rax,rax
       je        short M00_L31
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L31
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        near ptr M00_L46
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L45
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFA06975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L30:
       mov       [rdi+18],r14d
M00_L31:
       lea       rcx,[rbp-68]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFA06FCF000]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       cmp       byte ptr [rbp-58],0
       jne       near ptr M00_L50
       mov       rdi,[rbp-68]
       cmp       [rdi],dil
       test      rax,rax
       je        short M00_L33
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L33
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        near ptr M00_L49
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L48
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFA06975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L32:
       mov       [rdi+18],r14d
M00_L33:
       lea       rcx,[rbp-68]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       [rbx],bl
       imul      eax,esi,64
       mov       ecx,[rbp-2C]
       sub       ecx,eax
       mov       [rbp-2C],ecx
       jmp       near ptr M00_L07
M00_L34:
       mov       [rbp-68],rbx
       xor       eax,eax
       mov       [rbp-60],rax
       mov       byte ptr [rbp-58],0
       call      qword ptr [7FFA06FCF030]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       cmp       byte ptr [rbp-58],0
       jne       near ptr M00_L53
       mov       rbx,[rbp-68]
       cmp       [rbx],bl
       test      rax,rax
       je        short M00_L36
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M00_L36
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        near ptr M00_L52
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       near ptr M00_L51
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFA06975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L35:
       mov       [rbx+18],esi
M00_L36:
       lea       rcx,[rbp-68]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       jmp       near ptr M00_L08
M00_L37:
       cmp       dword ptr [rbp-2C],14
       jae       near ptr M00_L62
       mov       rdx,[rbp-38]
       mov       ecx,[rbp-2C]
       mov       rdx,[rdx+rcx*8+10]
       mov       rcx,[rbp-1D8]
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M00_L23
M00_L38:
       lea       rcx,[rbp-80]
       mov       r9,rbx
       xor       edx,edx
       mov       r8d,4
       call      qword ptr [7FFA06FCEF88]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-80]
       vmovdqu   xmmword ptr [rbp-68],xmm0
       mov       rcx,[rbp-70]
       mov       [rbp-58],rcx
       mov       ecx,[rbp-2C]
       imul      rcx,431BDE83
       shr       rcx,32
       call      qword ptr [7FFA06FCEF10]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
       mov       rdx,rax
       lea       rcx,[rbp-68]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-68]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFA06FCEFB8]
       mov       rdx,rax
       lea       rcx,[rbp-68]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-68]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       [rbx],bl
       mov       eax,[rbp-2C]
       imul      rax,431BDE83
       shr       rax,32
       imul      eax,0F4240
       mov       edx,[rbp-2C]
       sub       edx,eax
       mov       [rbp-2C],edx
       jmp       near ptr M00_L05
M00_L39:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L25
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L25
M00_L40:
       mov       rcx,rdi
       call      qword ptr [7FFA06AEF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L26
M00_L41:
       lea       rcx,[rbp-68]
       mov       r8,rax
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M00_L26
M00_L42:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L27
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L27
M00_L43:
       mov       rcx,rdi
       call      qword ptr [7FFA06AEF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L28
M00_L44:
       lea       rcx,[rbp-68]
       mov       r8,rax
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M00_L28
M00_L45:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L30
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L30
M00_L46:
       mov       rcx,rdi
       call      qword ptr [7FFA06AEF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L31
M00_L47:
       lea       rcx,[rbp-68]
       mov       r8,rax
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M00_L31
M00_L48:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L32
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L32
M00_L49:
       mov       rcx,rdi
       call      qword ptr [7FFA06AEF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L33
M00_L50:
       lea       rcx,[rbp-68]
       mov       r8,rax
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M00_L33
M00_L51:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M00_L35
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L35
M00_L52:
       mov       rcx,rbx
       call      qword ptr [7FFA06AEF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L36
M00_L53:
       lea       rcx,[rbp-68]
       mov       r8,rax
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M00_L36
M00_L54:
       mov       ecx,2
       call      qword ptr [7FFA070361C0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L09
M00_L55:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L56:
       mov       rcx,rsi
       mov       rdx,28B608B0990
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M00_L11
M00_L57:
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rbx+30]
       mov       rcx,r14
       mov       rdx,rdi
       mov       r9d,1
       call      qword ptr [7FFA07036D00]
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager+<GetEnumerator>d__5
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       ecx,ecx
       mov       [rdi+20],ecx
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-1E0],rdi
M00_L58:
       mov       rcx,[rbp-1E0]
       call      qword ptr [7FFA06DF2410]; Precode of System.Resources.ResourceFallbackManager+<GetEnumerator>d__5.MoveNext()
       test      eax,eax
       je        near ptr M00_L61
       mov       rcx,[rbp-1E0]
       mov       rdi,[rcx+8]
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8d,1
       mov       r9d,1
       cmp       [rcx],ecx
       call      qword ptr [7FFA06AB8720]; Precode of System.Resources.ResourceManager.InternalGetResourceSet(System.Globalization.CultureInfo, Boolean, Boolean)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L61
       cmp       r14,rsi
       je        short M00_L58
       movzx     r8d,byte ptr [rbx+54]
       mov       rcx,r14
       mov       rdx,28B608B0990
       mov       rax,[r14]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r15,rax
       test      r15,r15
       jne       short M00_L59
       mov       rsi,r14
       jmp       short M00_L58
M00_L59:
       cmp       qword ptr [rbx+38],0
       je        short M00_L60
       mov       rdx,[rbx+38]
       mov       [rbp-1F0],rdx
       mov       byte ptr [rbp-0B8],0
       lea       rdx,[rbp-0B8]
       mov       rcx,[rbp-1F0]
       call      qword ptr [7FFA06975998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+38]
       lea       rcx,[rcx+8]
       mov       [rbp-1F8],rcx
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,[rbp-1F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+38]
       lea       rcx,[rcx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       nop
       cmp       byte ptr [rbp-0B8],0
       je        short M00_L60
       mov       rcx,[rbp-1F0]
       call      qword ptr [7FFA06976820]; System.Threading.Monitor.Exit(System.Object)
M00_L60:
       mov       [rbp-1E8],r15
       jmp       short M00_L63
M00_L61:
       xor       edx,edx
       mov       rcx,[rbp-1E0]
       mov       [rcx+18],rdx
       mov       dword ptr [rcx+20],0FFFFFFFE
       jmp       near ptr M00_L12
M00_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L63:
       call      M00_L90
       nop
       mov       rdx,[rbp-1E8]
       jmp       near ptr M00_L12
M00_L64:
       mov       rdi,24ACB802100
       mov       r8,[rdi]
       mov       rcx,rbx
       mov       rdx,28B608B0990
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdx,rax
       jmp       near ptr M00_L12
M00_L65:
       mov       rdi,24ACB802100
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B09B0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M00_L13
M00_L66:
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B09D0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M00_L14
M00_L67:
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B09F0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M00_L15
M00_L68:
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B0A10
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M00_L16
M00_L69:
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B0A30
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M00_L17
M00_L70:
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B0A50
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M00_L18
M00_L71:
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B0A70
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M00_L19
M00_L72:
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B0A90
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M00_L20
M00_L73:
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B0AB0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M00_L21
M00_L74:
       mov       r8,[rdi]
       mov       rcx,rax
       mov       rdx,28B608B0AD0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M00_L22
M00_L75:
       lea       rcx,[rbp-68]
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M00_L23
M00_L76:
       mov       rcx,24ACB801DB0
       mov       rcx,[rcx]
       call      qword ptr [7FFA06B9FDE0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rsi,rax
       mov       rcx,[rbp-1D8]
       xor       edx,edx
       call      qword ptr [7FFA06FC4E10]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rsi],rcx
       jne       near ptr M00_L88
       mov       rcx,rsi
       mov       rdx,[rbp-1D8]
       call      qword ptr [7FFA06FC4E28]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
M00_L77:
       mov       [rbp-0C0],rbx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-0C0]
       mov       rdx,7FFA0702A090
       cmp       [rcx],ecx
       call      qword ptr [7FFA06FCF5A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,1F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L78:
       mov       rsi,[rbx+18]
       mov       rdi,[rsi+18]
       lea       rdx,[rbp-0B0]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFA06FC4DB0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M00_L79
       cmp       qword ptr [rdi+10],0
       je        short M00_L80
       lea       rdx,[rbp-0B0]
       mov       rcx,rsi
       call      qword ptr [7FFA07036D78]
       test      eax,eax
       je        short M00_L81
M00_L79:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M00_L02
M00_L80:
       xor       ecx,ecx
       mov       [rbp-0B0],rcx
M00_L81:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M00_L03
M00_L82:
       call      qword ptr [7FFA06FCEF40]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       mov       rbx,rax
       jmp       near ptr M00_L77
M00_L83:
       lea       rcx,[rbp-0A8]
       xor       edx,edx
       mov       r8d,3
       call      qword ptr [7FFA06B94E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       call      qword ptr [7FFA06FCEF58]
       mov       rdx,rax
       lea       rcx,[rbp-0A8]
       call      qword ptr [7FFA06B9E1A8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-0A8]
       mov       edx,20
       call      qword ptr [7FFA06FCCD68]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       ecx,[rbp-2C]
       neg       ecx
       jns       short M00_L84
       call      qword ptr [7FFA07037210]
       int       3
M00_L84:
       call      qword ptr [7FFA06FCEF10]; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
       mov       rdx,rax
       lea       rcx,[rbp-0A8]
       call      qword ptr [7FFA06B9E1A8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-0A8]
       call      qword ptr [7FFA06B94EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbx,rax
       jmp       near ptr M00_L77
M00_L85:
       mov       rcx,rax
       call      qword ptr [7FFA06B9FE40]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       near ptr M00_L01
M00_L86:
       call      qword ptr [7FFA07035EA8]
       int       3
M00_L87:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rbx,rax
       jmp       near ptr M00_L04
M00_L88:
       mov       rcx,rsi
       mov       rdx,[rbp-1D8]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       near ptr M00_L77
       sub       rsp,28
       cmp       byte ptr [rbp-0B8],0
       je        short M00_L89
       mov       rcx,[rbp-1F0]
       call      qword ptr [7FFA06976820]; System.Threading.Monitor.Exit(System.Object)
M00_L89:
       nop
       add       rsp,28
       ret
M00_L90:
       sub       rsp,28
       xor       r8d,r8d
       mov       rcx,[rbp-1E0]
       mov       [rcx+18],r8
       mov       dword ptr [rcx+20],0FFFFFFFE
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,24ACB801DB0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFA06B9FDE0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rbx,rax
       mov       rcx,[rbp-1D8]
       cmp       [rcx],cl
       xor       edx,edx
       call      qword ptr [7FFA06FC4E10]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rbx],rcx
       jne       short M00_L91
       mov       rcx,rbx
       mov       rdx,[rbp-1D8]
       call      qword ptr [7FFA06FC4E28]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       jmp       short M00_L92
M00_L91:
       mov       rcx,rbx
       mov       rdx,[rbp-1D8]
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M00_L92:
       nop
       add       rsp,28
       ret
; Total bytes of code 4464
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
;                 if (object.ReferenceEquals(resourceMan, null)) {
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotNetTips.Spargine.Extensions.Properties.Resources", typeof(Resources).Assembly);
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     resourceMan = temp;
;                     ^^^^^^^^^^^^^^^^^^^
;                 return resourceMan;
;                 ^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,24ACB8020F8
       cmp       qword ptr [rbx],0
       je        short M01_L01
M01_L00:
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       mov       rcx,offset MT_System.Resources.ResourceManager
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,28B608B08A8
       call      qword ptr [7FFA07037108]
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,28B608B0828
       call      qword ptr [7FFA06D85FE0]; System.Resources.ResourceManager..ctor(System.String, System.Reflection.Assembly)
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L00
; Total bytes of code 101
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultUICulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFA663F47E8]
       mov       rbx,rax
       lea       rsi,[rbx+8]
       call      qword ptr [7FFA6640BA00]
       mov       rdx,rax
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA6640CBA8]
       mov       rax,[rbx+8]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFA6640A3D0]
       int       3
; Total bytes of code 63
```
```assembly
; System.Resources.ResourceManager.GetFirstResourceSet(System.Globalization.CultureInfo)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx+30]
       test      rbx,rbx
       je        short M03_L03
       mov       rdx,[rbp+18]
       mov       rsi,offset MT_System.Globalization.CultureInfo
       cmp       [rdx],rsi
       jne       near ptr M03_L20
       mov       rdx,[rbp+18]
       mov       rdi,[rdx+48]
       test      rdi,rdi
       je        near ptr M03_L19
M03_L00:
       cmp       [rbx],rsi
       jne       near ptr M03_L22
       mov       rdx,[rbx+48]
       test      rdx,rdx
       je        near ptr M03_L21
M03_L01:
       cmp       rdi,rdx
       jne       near ptr M03_L16
M03_L02:
       mov       rax,24ACB800100
       mov       rax,[rax]
       mov       [rbp+18],rax
M03_L03:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+38]
       test      rax,rax
       je        near ptr M03_L25
       mov       [rbp-30],rax
       xor       eax,eax
       mov       [rbp-28],eax
       cmp       byte ptr [rbp-28],0
       je        short M03_L04
       call      qword ptr [7FFA070366D0]
       int       3
M03_L04:
       mov       rcx,[rbp-30]
       call      00007FFA66632D60
       test      eax,eax
       jne       short M03_L05
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA070364D8]
M03_L05:
       mov       dword ptr [rbp-28],1
       mov       rcx,[rbp+18]
       mov       rsi,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rsi
       jne       near ptr M03_L12
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        near ptr M03_L11
M03_L06:
       mov       rax,[rbp+10]
       mov       rdx,[rax+38]
       mov       rdx,[rdx+8]
       cmp       rcx,rdx
       jne       short M03_L08
M03_L07:
       mov       rax,[rbp+10]
       mov       rcx,[rax+38]
       mov       rbx,[rcx+10]
       jmp       near ptr M03_L14
M03_L08:
       test      rcx,rcx
       je        near ptr M03_L13
       test      rdx,rdx
       je        near ptr M03_L13
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M03_L13
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       je        short M03_L09
       call      qword ptr [7FFA0697FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M03_L10
M03_L09:
       mov       r8,[rcx]
       mov       rcx,[rcx+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
M03_L10:
       test      eax,eax
       je        near ptr M03_L23
       jmp       short M03_L07
M03_L11:
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+18]
       mov       rdx,28B608A0008
       test      rcx,rcx
       cmove     rcx,rdx
       mov       rbx,rcx
       mov       rcx,[rbp+18]
       lea       rcx,[rcx+48]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       jmp       near ptr M03_L06
M03_L12:
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M03_L06
M03_L13:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M03_L10
M03_L14:
       cmp       byte ptr [rbp-28],0
       je        short M03_L15
       mov       rcx,[rbp-30]
       call      00007FFA66632C80
       test      eax,eax
       jne       near ptr M03_L24
M03_L15:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L16:
       test      rdi,rdi
       je        near ptr M03_L03
       test      rdx,rdx
       je        near ptr M03_L03
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M03_L03
       lea       rax,[rdi+0C]
       add       rdx,0C
       mov       r8d,[rdi+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M03_L17
       mov       rcx,rax
       call      qword ptr [7FFA0697FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M03_L18
M03_L17:
       mov       r8,[rax]
       mov       rax,[rax+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rax,[rdx+2]
       or        rax,r8
       sete      al
       movzx     eax,al
M03_L18:
       test      eax,eax
       je        near ptr M03_L03
       jmp       near ptr M03_L02
M03_L19:
       mov       rdx,[rbp+18]
       mov       rdx,[rdx+30]
       mov       rdx,[rdx+18]
       mov       rax,28B608A0008
       test      rdx,rdx
       cmove     rdx,rax
       mov       rdi,rdx
       mov       rdx,[rbp+18]
       lea       rcx,[rdx+48]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L20:
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+30]
       jmp       short M03_L22
M03_L21:
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+18]
       mov       rax,28B608A0008
       test      rdx,rdx
       cmove     rdx,rax
       mov       rsi,rdx
       lea       rcx,[rbx+48]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M03_L01
M03_L22:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       jmp       near ptr M03_L01
M03_L23:
       call      M03_L29
       jmp       short M03_L25
M03_L24:
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FFA07036400]
       jmp       near ptr M03_L15
M03_L25:
       mov       rax,[rbp+10]
       mov       rbx,[rax+18]
       xor       edx,edx
       mov       [rbp-20],rdx
       test      rbx,rbx
       je        short M03_L26
       mov       [rbp-38],rbx
       xor       edx,edx
       mov       [rbp-28],edx
       lea       rdx,[rbp-28]
       mov       rcx,rbx
       call      qword ptr [7FFA06975998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       lea       r8,[rbp-20]
       mov       rcx,rbx
       call      qword ptr [7FFA069BAC10]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       nop
       cmp       byte ptr [rbp-28],0
       je        short M03_L26
       mov       rcx,rbx
       call      qword ptr [7FFA06976820]; System.Threading.Monitor.Exit(System.Object)
M03_L26:
       cmp       qword ptr [rbp-20],0
       je        near ptr M03_L28
       mov       rax,[rbp+10]
       cmp       qword ptr [rax+38],0
       je        short M03_L27
       mov       rdx,[rax+38]
       mov       [rbp-30],rdx
       xor       edx,edx
       mov       [rbp-28],edx
       lea       rdx,[rbp-28]
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA06975998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rax,[rbp+10]
       mov       rcx,[rax+38]
       lea       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+18]
       mov       rdx,[rbp+18]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+38]
       mov       rcx,[rbp-40]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp+10]
       mov       rcx,[rax+38]
       lea       rcx,[rcx+10]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       cmp       byte ptr [rbp-28],0
       je        short M03_L27
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA06976820]; System.Threading.Monitor.Exit(System.Object)
M03_L27:
       mov       rax,[rbp-20]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L28:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L29:
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M03_L30
       mov       rcx,[rbp-30]
       call      00007FFA66632C80
       test      eax,eax
       je        short M03_L30
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FFA07036400]
M03_L30:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M03_L31
       mov       rcx,[rbp-38]
       call      qword ptr [7FFA06976820]; System.Threading.Monitor.Exit(System.Object)
M03_L31:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-28],0
       je        short M03_L32
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA06976820]; System.Threading.Monitor.Exit(System.Object)
M03_L32:
       nop
       add       rsp,28
       ret
; Total bytes of code 1110
```
```assembly
; System.Resources.RuntimeResourceSet.GetObject(System.String, Boolean, Boolean)
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       test      rdx,rdx
       je        near ptr M04_L36
       mov       rax,[rcx+28]
       mov       [rbp-70],rax
       mov       rbx,[rcx+20]
       test      rax,rax
       je        near ptr M04_L37
       test      rbx,rbx
       je        near ptr M04_L37
       mov       [rbp-78],rbx
       xor       r8d,r8d
       mov       [rbp-50],r8d
       cmp       byte ptr [rbp-50],0
       je        short M04_L00
       call      qword ptr [7FFA070366D0]
       int       3
M04_L00:
       mov       rcx,rbx
       call      00007FFA66632D60
       test      eax,eax
       jne       short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFA070364D8]
M04_L01:
       mov       dword ptr [rbp-50],1
       cmp       qword ptr [rbx+8],0
       je        near ptr M04_L28
       mov       rsi,[rbx+18]
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.Resources.FastResourceComparer
       cmp       rdi,rcx
       jne       near ptr M04_L15
       mov       ecx,1505
       mov       rdx,[rbp+18]
       mov       r14d,[rdx+8]
       test      r14d,r14d
       jle       short M04_L03
       lea       r11,[rdx+0C]
M04_L02:
       mov       eax,ecx
       shl       eax,5
       add       ecx,eax
       movzx     eax,word ptr [r11]
       xor       ecx,eax
       add       r11,2
       dec       r14d
       jne       short M04_L02
M04_L03:
       mov       r14d,ecx
M04_L04:
       mov       rcx,[rbx+8]
       mov       r8d,r14d
       imul      r8,[rbx+30]
       shr       r8,20
       inc       r8
       mov       eax,[rcx+8]
       mov       r10d,eax
       imul      r8,r10
       shr       r8,20
       cmp       r8d,eax
       jae       near ptr M04_L32
       mov       r8d,r8d
       lea       rcx,[rcx+r8*4+10]
       mov       r15d,[rcx]
       mov       r13,[rbx+10]
       xor       r12d,r12d
       dec       r15d
       mov       eax,[r13+8]
       mov       [rbp-64],eax
       cmp       eax,r15d
       jbe       near ptr M04_L28
       mov       rcx,offset MT_System.Resources.FastResourceComparer
       cmp       rdi,rcx
       jne       near ptr M04_L17
M04_L05:
       mov       ecx,r15d
       shl       rcx,5
       lea       rsi,[r13+rcx+10]
       cmp       [rsi+8],r14d
       jne       near ptr M04_L13
       mov       r10,[rsi]
       cmp       r10,rdx
       jne       short M04_L10
       mov       edi,1
M04_L06:
       test      edi,edi
       je        near ptr M04_L13
M04_L07:
       add       rsi,10
M04_L08:
       test      rsi,rsi
       je        near ptr M04_L14
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        near ptr M04_L29
M04_L09:
       mov       [rbp-80],rdi
       jmp       near ptr M04_L34
M04_L10:
       test      r10,r10
       je        near ptr M04_L16
       mov       ecx,[r10+8]
       mov       r8d,[rdx+8]
       cmp       ecx,r8d
       jne       near ptr M04_L16
       lea       rcx,[r10+0C]
       lea       r9,[rdx+0C]
       mov       r8d,[r10+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M04_L11
       mov       rdx,r9
       call      qword ptr [7FFA0697FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edi,eax
       jmp       short M04_L12
M04_L11:
       mov       r8,[rcx]
       mov       rcx,[rcx+2]
       mov       r10,[r9]
       xor       r8,r10
       xor       rcx,[r9+2]
       or        rcx,r8
       sete      dil
       movzx     edi,dil
M04_L12:
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L06
M04_L13:
       mov       r15d,[rsi+0C]
       inc       r12d
       mov       eax,[rbp-64]
       cmp       eax,r12d
       jb        near ptr M04_L27
       cmp       eax,r15d
       jbe       near ptr M04_L28
       jmp       near ptr M04_L05
M04_L14:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       rcx,[rbp-70]
       call      qword ptr [7FFA06D86FD0]; System.Resources.ResourceReader.FindPosForResource(System.String)
       test      eax,eax
       jl        near ptr M04_L33
       movzx     r8d,byte ptr [rbp+28]
       lea       r9,[rbp-48]
       mov       rcx,[rbp-70]
       mov       edx,eax
       call      qword ptr [7FFA06D87048]; System.Resources.RuntimeResourceSet.ReadValue(System.Resources.ResourceReader, Int32, Boolean, System.Resources.ResourceLocator ByRef)
       mov       rdi,rax
       mov       r8,[rbp-48]
       mov       edx,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-58],edx
       lea       r8,[rbp-60]
       mov       rdx,[rbp+18]
       mov       rcx,rbx
       mov       r9d,1
       call      qword ptr [7FFA06D87108]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L09
M04_L15:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r11,7FFA068C0A58
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L04
M04_L16:
       xor       edi,edi
       jmp       near ptr M04_L06
M04_L17:
       mov       ecx,r15d
       shl       rcx,5
       lea       rcx,[r13+rcx+10]
       mov       r15,rcx
       cmp       [r15+8],r14d
       jne       near ptr M04_L24
       mov       r10,[r15]
       mov       rcx,offset MT_System.Resources.FastResourceComparer
       cmp       rdi,rcx
       je        short M04_L18
       mov       rcx,rsi
       mov       r8,rdx
       mov       rdx,r10
       mov       r11,7FFA068C0A60
       call      qword ptr [r11]
       mov       r9d,eax
       mov       rdx,[rbp+18]
       jmp       short M04_L23
M04_L18:
       cmp       r10,rdx
       je        short M04_L22
       test      r10,r10
       je        short M04_L21
       mov       ecx,[r10+8]
       mov       r8d,[rdx+8]
       cmp       ecx,r8d
       jne       short M04_L21
       add       r10,0C
       lea       r9,[rdx+0C]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M04_L19
       mov       rcx,r10
       mov       rdx,r9
       call      qword ptr [7FFA0697FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r9d,eax
       mov       rdx,[rbp+18]
       jmp       short M04_L20
M04_L19:
       mov       rdx,[rbp+18]
       mov       rcx,r10
       mov       r8,r9
       mov       r11,[rcx]
       mov       rcx,[rcx+2]
       mov       r10,[r8]
       xor       r11,r10
       xor       rcx,[r8+2]
       or        rcx,r11
       sete      r9b
       movzx     r9d,r9b
M04_L20:
       jmp       short M04_L23
M04_L21:
       xor       r9d,r9d
       jmp       short M04_L23
M04_L22:
       mov       r9d,1
M04_L23:
       test      r9d,r9d
       jne       short M04_L25
M04_L24:
       mov       r15d,[r15+0C]
       inc       r12d
       mov       eax,[rbp-64]
       cmp       eax,r12d
       jae       short M04_L26
       jmp       short M04_L27
M04_L25:
       mov       rsi,r15
       jmp       near ptr M04_L07
M04_L26:
       cmp       eax,r15d
       jbe       short M04_L28
       jmp       near ptr M04_L17
M04_L27:
       call      qword ptr [7FFA06B97A20]
       int       3
M04_L28:
       xor       esi,esi
       mov       rdx,[rbp+18]
       jmp       near ptr M04_L08
M04_L29:
       mov       eax,[rbp-40]
       cmp       byte ptr [rbp+28],0
       jne       short M04_L30
       mov       rcx,[rbp-70]
       mov       edx,eax
       call      qword ptr [7FFA07036730]
       jmp       short M04_L31
M04_L30:
       mov       rcx,[rbp-70]
       mov       edx,eax
       call      qword ptr [7FFA06EFE790]; System.Resources.ResourceReader.LoadString(Int32)
M04_L31:
       mov       [rbp-80],rax
       jmp       short M04_L34
M04_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L33:
       call      M04_L50
       jmp       near ptr M04_L39
M04_L34:
       cmp       byte ptr [rbp-50],0
       je        short M04_L35
       mov       rcx,[rbp-78]
       call      00007FFA66632C80
       test      eax,eax
       jne       short M04_L38
M04_L35:
       mov       rax,[rbp-80]
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
M04_L36:
       mov       ecx,13BFC
       mov       rdx,7FFA068B4000
       call      qword ptr [7FFA06B977B0]
       mov       rcx,rax
       call      qword ptr [7FFA07035968]
       int       3
M04_L37:
       mov       rcx,offset MT_System.ObjectDisposedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA07036700]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA07036718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L38:
       mov       ecx,eax
       mov       rdx,[rbp-78]
       call      qword ptr [7FFA07036400]
       jmp       short M04_L35
M04_L39:
       cmp       byte ptr [rbp+20],0
       jne       short M04_L40
       xor       eax,eax
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
M04_L40:
       xor       edi,edi
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+30]
       test      rbx,rbx
       jne       short M04_L41
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, System.Resources.ResourceLocator>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r8,24ACB800070
       mov       r8,[r8]
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA06D86E08]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       edi,1
M04_L41:
       mov       [rbp-78],rbx
       xor       edx,edx
       mov       [rbp-50],edx
       lea       rdx,[rbp-50]
       mov       rcx,rbx
       call      qword ptr [7FFA06975998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       test      edi,edi
       je        near ptr M04_L44
       mov       rcx,offset MT_System.Resources.ResourceReader+ResourceEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp-70]
       call      qword ptr [7FFA07036748]
       jmp       short M04_L43
M04_L42:
       mov       rcx,rsi
       call      qword ptr [7FFA06DF8358]
       mov       rdx,rax
       mov       rcx,offset MT_System.String
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,rax
       mov       r8d,[rsi+14]
       cmp       [rbx],bl
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-58],r8d
       lea       r8,[rbp-60]
       mov       rcx,rbx
       mov       r9d,2
       call      qword ptr [7FFA06D87108]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
M04_L43:
       mov       rcx,rsi
       call      qword ptr [7FFA06DF8350]
       test      eax,eax
       jne       short M04_L42
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+30]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M04_L44:
       lea       r8,[rbp-48]
       mov       rcx,rbx
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFA06DF66E0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryGetValue(System.__Canon, System.Resources.ResourceLocator ByRef)
       test      eax,eax
       jne       short M04_L45
       xor       r8d,r8d
       mov       [rbp-80],r8
       jmp       short M04_L48
M04_L45:
       cmp       qword ptr [rbp-48],0
       je        short M04_L46
       mov       r8,[rbp-48]
       mov       [rbp-80],r8
       jmp       short M04_L48
M04_L46:
       movzx     r8d,byte ptr [rbp+28]
       lea       r9,[rbp-48]
       mov       rcx,[rbp-70]
       mov       edx,[rbp-40]
       call      qword ptr [7FFA06D87048]; System.Resources.RuntimeResourceSet.ReadValue(System.Resources.ResourceReader, Int32, Boolean, System.Resources.ResourceLocator ByRef)
       mov       rdi,rax
       cmp       qword ptr [rbp-48],0
       je        short M04_L47
       mov       r8,[rbp-48]
       mov       edx,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-58],edx
       lea       r8,[rbp-60]
       mov       rdx,[rbp+18]
       mov       rcx,rbx
       mov       r9d,1
       call      qword ptr [7FFA06D87108]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Resources.ResourceLocator, System.Private.CoreLib]].TryInsert(System.__Canon, System.Resources.ResourceLocator, System.Collections.Generic.InsertionBehavior)
       nop
M04_L47:
       cmp       byte ptr [rbp-50],0
       je        short M04_L49
       mov       rcx,[rbp-78]
       call      qword ptr [7FFA06976820]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M04_L49
M04_L48:
       call      M04_L52
       jmp       near ptr M04_L35
M04_L49:
       mov       rax,rdi
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
M04_L50:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M04_L51
       mov       rcx,[rbp-78]
       call      00007FFA66632C80
       test      eax,eax
       je        short M04_L51
       mov       ecx,eax
       mov       rdx,[rbp-78]
       call      qword ptr [7FFA07036400]
M04_L51:
       nop
       add       rsp,28
       ret
M04_L52:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M04_L53
       mov       rcx,[rbp-78]
       call      qword ptr [7FFA06976820]; System.Threading.Monitor.Exit(System.Object)
M04_L53:
       nop
       add       rsp,28
       ret
; Total bytes of code 1599
```
```assembly
; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
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
       mov       [rbp-50],rax
       mov       [rbp-58],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rdi,rdi
       je        near ptr M05_L03
       test      rbx,rbx
       jne       short M05_L01
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M05_L04
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M05_L04
M05_L00:
       mov       rbx,[rax+18]
       test      rbx,rbx
       jne       short M05_L01
       mov       rax,24ACB800108
       mov       rbx,[rax]
       test      rbx,rbx
       jne       short M05_L01
       mov       rax,24ACB8000F8
       mov       rbx,[rax]
       test      rbx,rbx
       jne       short M05_L01
       call      qword ptr [7FFA06B94150]; System.Globalization.CultureInfo.InitializeUserDefaultUICulture()
       mov       rbx,rax
M05_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA06D86568]; System.Resources.ResourceManager.GetFirstResourceSet(System.Globalization.CultureInfo)
       mov       r14,rax
       test      r14,r14
       je        near ptr M05_L07
       movzx     r8d,byte ptr [rsi+54]
       mov       rcx,offset MT_System.Resources.RuntimeResourceSet
       cmp       [r14],rcx
       jne       short M05_L06
       mov       rcx,r14
       mov       rdx,rdi
       mov       r9d,1
       call      qword ptr [7FFA06D86F58]; System.Resources.RuntimeResourceSet.GetObject(System.String, Boolean, Boolean)
       mov       r8,rax
       test      r8,r8
       je        short M05_L02
       mov       rcx,offset MT_System.String
       cmp       [r8],rcx
       jne       short M05_L05
M05_L02:
       test      r8,r8
       je        short M05_L07
       mov       rax,r8
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L03:
       mov       ecx,3E7
       mov       rdx,7FFA068B4000
       call      qword ptr [7FFA06B977B0]
       mov       rcx,rax
       call      qword ptr [7FFA07035968]
       int       3
M05_L04:
       mov       ecx,2
       call      qword ptr [7FFA070361C0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M05_L00
M05_L05:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M05_L06:
       mov       rcx,r14
       mov       rdx,rdi
       mov       rax,[r14]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r8,rax
       jmp       short M05_L02
M05_L07:
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r8,[rsi+30]
       mov       rcx,r15
       mov       rdx,rbx
       mov       r9d,1
       call      qword ptr [7FFA07036D00]
       mov       rcx,offset MT_System.Resources.ResourceFallbackManager+<GetEnumerator>d__5
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       ecx,ecx
       mov       [rbx+20],ecx
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-40],rbx
M05_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [7FFA06DF2410]; Precode of System.Resources.ResourceFallbackManager+<GetEnumerator>d__5.MoveNext()
       test      eax,eax
       je        near ptr M05_L11
       mov       rcx,[rbp-40]
       mov       rbx,[rcx+8]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8d,1
       mov       r9d,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r15,rax
       test      r15,r15
       je        near ptr M05_L11
       cmp       r15,r14
       je        short M05_L08
       movzx     r8d,byte ptr [rsi+54]
       mov       rcx,r15
       mov       rdx,rdi
       mov       rax,[r15]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r13,rax
       test      r13,r13
       jne       short M05_L09
       mov       r14,r15
       jmp       short M05_L08
M05_L09:
       cmp       qword ptr [rsi+38],0
       je        short M05_L10
       mov       rdx,[rsi+38]
       mov       [rbp-48],rdx
       xor       edx,edx
       mov       [rbp-38],edx
       lea       rdx,[rbp-38]
       mov       rcx,[rbp-48]
       call      qword ptr [7FFA06975998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rsi+38]
       lea       rcx,[rcx+8]
       mov       [rbp-58],rcx
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,[rbp-58]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+38]
       lea       rcx,[rcx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       nop
       cmp       byte ptr [rbp-38],0
       je        short M05_L10
       mov       rcx,[rbp-48]
       call      qword ptr [7FFA06976820]; System.Threading.Monitor.Exit(System.Object)
M05_L10:
       mov       [rbp-50],r13
       jmp       short M05_L12
M05_L11:
       xor       eax,eax
       mov       rcx,[rbp-40]
       mov       [rcx+18],rax
       mov       dword ptr [rcx+20],0FFFFFFFE
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L12:
       call      M05_L14
       nop
       mov       rax,[rbp-50]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-38],0
       je        short M05_L13
       mov       rcx,[rbp-48]
       call      qword ptr [7FFA06976820]; System.Threading.Monitor.Exit(System.Object)
M05_L13:
       nop
       add       rsp,28
       ret
M05_L14:
       sub       rsp,28
       xor       eax,eax
       mov       rcx,[rbp-40]
       mov       [rcx+18],rax
       mov       dword ptr [rcx+20],0FFFFFFFE
       add       rsp,28
       ret
; Total bytes of code 743
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eleven()
;                 return ResourceManager.GetString("Eleven", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0AF0
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Twelve()
;                 return ResourceManager.GetString("Twelve", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0B18
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thirteen()
;                 return ResourceManager.GetString("Thirteen", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0B40
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Fourteen()
;                 return ResourceManager.GetString("Fourteen", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0B68
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Fifteen()
;                 return ResourceManager.GetString("Fifteen", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0B90
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Sixteen()
;                 return ResourceManager.GetString("Sixteen", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0BB8
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Seventeen()
;                 return ResourceManager.GetString("Seventeen", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0BE0
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eighteen()
;                 return ResourceManager.GetString("Eighteen", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0C08
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Nineteen()
;                 return ResourceManager.GetString("Nineteen", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0C30
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
;                 return ResourceManager.GetString("Zero", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0990
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Ten()
;                 return ResourceManager.GetString("Ten", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0AD0
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Twenty()
;                 return ResourceManager.GetString("Twenty", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0C58
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thirty()
;                 return ResourceManager.GetString("Thirty", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0C80
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Forty()
;                 return ResourceManager.GetString("Forty", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0CA8
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Fifty()
;                 return ResourceManager.GetString("Fifty", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0CC8
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Sixty()
;                 return ResourceManager.GetString("Sixty", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0CE8
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Seventy()
;                 return ResourceManager.GetString("Seventy", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0D08
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eighty()
;                 return ResourceManager.GetString("Eighty", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0D30
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Ninety()
;                 return ResourceManager.GetString("Ninety", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0D58
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rdx,rdx
       je        short M25_L01
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M25_L01
       mov       rcx,[rbx+8]
       mov       edx,[rbx+18]
       lea       esi,[rdx+r8]
       cmp       esi,[rcx+8]
       ja        short M25_L03
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jle       short M25_L02
       mov       r8d,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFA06975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M25_L00:
       mov       [rbx+18],esi
M25_L01:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M25_L02:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       jne       short M25_L00
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M25_L00
M25_L03:
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFA06AEF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M25_L01
; Total bytes of code 121
```
```assembly
; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       push      rbx
       mov       rbx,rcx
       mov       rcx,rbx
       mov       rdx,r9
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       mov       byte ptr [rbx+10],0
       pop       rbx
       ret
; Total bytes of code 27
```
```assembly
; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       sub       rsp,28
       cmp       byte ptr [rcx+10],0
       jne       short M27_L00
       mov       r8,[rcx]
       mov       r9,[r8+8]
       mov       rax,r9
       mov       r8d,[r8+18]
       mov       r10d,r8d
       mov       r9d,[r9+8]
       sub       r9d,r8d
       mov       r8d,r10d
       mov       r10d,r9d
       add       r10,r8
       mov       r11d,[rax+8]
       cmp       r10,r11
       ja        short M27_L01
       lea       r8,[rax+r8*2+10]
       movzx     eax,dx
       test      r9d,r9d
       je        short M27_L02
       mov       [r8],ax
       mov       rdx,[rcx]
       inc       dword ptr [rdx+18]
       add       rsp,28
       ret
M27_L00:
       movzx     edx,dx
       xor       r8d,r8d
       add       rsp,28
       jmp       qword ptr [7FFA06FCF4E0]
M27_L01:
       call      qword ptr [7FFA06AE7198]
       int       3
M27_L02:
       movzx     edx,dx
       xor       r8d,r8d
       xor       r9d,r9d
       add       rsp,28
       jmp       qword ptr [7FFA06FCF4B0]
; Total bytes of code 122
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M28_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA66629F20
       mov       rsi,rax
M28_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M28_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M28_L03
       cmp       [rdx+8],r8d
       jb        short M28_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFA06975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M28_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M28_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M28_L02:
       mov       rax,28B608A0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M28_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFA068B4000
       call      qword ptr [7FFA06B977B0]
       mov       rbx,rax
       call      qword ptr [7FFA07035EC0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA06B9D890]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M29_L01
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jge       short M29_L02
       mov       rax,7FFA65786090
       test      byte ptr [rax+rcx],80
       jne       short M29_L04
M29_L00:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jge       short M29_L03
       mov       rax,7FFA65786090
       test      byte ptr [rax+rcx],80
       jne       short M29_L04
M29_L01:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M29_L02:
       call      qword ptr [7FFA07035ED8]
       test      eax,eax
       jne       short M29_L04
       jmp       short M29_L00
M29_L03:
       call      qword ptr [7FFA07035ED8]
       test      eax,eax
       je        short M29_L01
M29_L04:
       mov       rcx,rbx
       mov       edx,3
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA07035EF0]
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Extensions.NumericExtensions.ToWords(Int32)
; 		if (value == 0)
; 		^^^^^^^^^^^^^^^
; 			return Resources.Zero;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 		if (value < 0)
; 		^^^^^^^^^^^^^^
; 			return $"{Resources.Minus}{ControlChars.Space}{ToWords(Math.Abs(value))}";
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Value.Get();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if ((value / 1000000) > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append($"{ToWords(value / 1000000)}{ControlChars.Space}{Resources.Million}{ControlChars.Space}");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				value %= 1000000;
; 				^^^^^^^^^^^^^^^^^
; 			if ((value / 1000) > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append($"{ToWords(value / 1000)}{ControlChars.Space}{Resources.Thousand}{ControlChars.Space}");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				value %= 1000;
; 				^^^^^^^^^^^^^^
; 			if ((value / 100) > 0)
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append($"{ToWords(value / 100)}{ControlChars.Space}{Resources.Hundred}{ControlChars.Space}");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				value %= 100;
; 				^^^^^^^^^^^^^
; 			if (value > 0)
; 			^^^^^^^^^^^^^^
; 				if (sb.Length > 0)
; 				^^^^^^^^^^^^^^^^^^
; 					_ = sb.Append($"{Resources.AndLowerCase}{ControlChars.Space}");
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				var units = new[]
; 				^^^^^^^^^^^^^^^^^
; 				{
; 				 
; 				Resources.Zero,
; 				               
; 				Resources.One,
; 				              
; 				Resources.Two,
; 				              
; 				Resources.Three,
; 				                
; 				Resources.Four,
; 				               
; 				Resources.Five,
; 				               
; 				Resources.Six,
; 				              
; 				Resources.Seven,
; 				                
; 				Resources.Eight,
; 				                
; 				Resources.Nine,
; 				               
; 				Resources.Ten,
; 				              
; 				Resources.Eleven,
; 				                 
; 				Resources.Twelve,
; 				                 
; 				Resources.Thirteen,
; 				                   
; 				Resources.Fourteen,
; 				                   
; 				Resources.Fifteen,
; 				                  
; 				Resources.Sixteen,
; 				                  
; 				Resources.Seventeen,
; 				                    
; 				Resources.Eighteen,
; 				                   
; 				Resources.Nineteen
; 				                  
; 			};
; 			  
; 				var tens = new[]
; 				^^^^^^^^^^^^^^^^
; 				{
; 				 
; 				Resources.Zero,
; 				               
; 				Resources.Ten,
; 				              
; 				Resources.Twenty,
; 				                 
; 				Resources.Thirty,
; 				                 
; 				Resources.Forty,
; 				                
; 				Resources.Fifty,
; 				                
; 				Resources.Sixty,
; 				                
; 				Resources.Seventy,
; 				                  
; 				Resources.Eighty,
; 				                 
; 				Resources.Ninety
; 				                
; 			};
; 			  
; 				if (value < 20)
; 				^^^^^^^^^^^^^^^
; 					_ = sb.Append(units[value]);
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 					_ = sb.Append(tens[value / 10]);
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 					if ((value % 10) > 0)
; 					^^^^^^^^^^^^^^^^^^^^^
; 						_ = sb.Append($"{ControlChars.Dash}{units[value % 10]}");
; 						^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString().Trim();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Value.Return(sb.Clear());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
M30_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,7B8
       lea       rbp,[rsp+7F0]
       xor       eax,eax
       mov       [rbp-7A8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-7A0],xmm4
       mov       rax,0FFFFFFFFFFFFF8B0
M30_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M30_L01
       mov       [rbp-40],rax
       mov       ebx,ecx
       test      ebx,ebx
       je        near ptr M30_L179
       test      ebx,ebx
       jl        near ptr M30_L180
       mov       rcx,24ACB801DB0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M30_L193
       mov       rsi,[rcx+18]
M30_L02:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rsi],rcx
       jne       near ptr M30_L195
       mov       rcx,[rsi+20]
       mov       [rbp-150],rcx
       cmp       qword ptr [rbp-150],0
       je        near ptr M30_L175
       lea       rcx,[rsi+20]
       mov       r8,[rbp-150]
       test      rcx,rcx
       je        near ptr M30_L194
       xor       edx,edx
       call      00007FFA665CCC60
       cmp       rax,[rbp-150]
       jne       near ptr M30_L175
M30_L03:
       mov       rsi,[rbp-150]
M30_L04:
       xor       ecx,ecx
       mov       [rbp-150],rcx
M30_L05:
       mov       [rbp-7A0],rsi
       mov       ecx,ebx
       imul      rcx,431BDE83
       shr       rcx,32
       test      ecx,ecx
       jg        near ptr M30_L114
M30_L06:
       mov       edx,10624DD3
       mov       eax,edx
       imul      ebx
       mov       edi,edx
       shr       edi,1F
       sar       edx,6
       add       edi,edx
       test      edi,edi
       jle       near ptr M30_L41
       mov       [rbp-78],rsi
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       byte ptr [rbp-68],0
       mov       r14d,edi
       mov       rcx,24ACB801DB0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M30_L122
       mov       rcx,[rcx+18]
M30_L07:
       mov       rax,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rcx],rax
       jne       near ptr M30_L123
       call      qword ptr [7FFA06DC1258]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       r15,rax
M30_L08:
       mov       [rbp-7C0],r15
       mov       ecx,r14d
       imul      rcx,431BDE83
       shr       rcx,32
       test      ecx,ecx
       jg        near ptr M30_L25
M30_L09:
       mov       edx,10624DD3
       mov       eax,edx
       imul      r14d
       mov       r13d,edx
       shr       r13d,1F
       sar       edx,6
       add       r13d,edx
       test      r13d,r13d
       jle       near ptr M30_L12
       mov       [rbp-1F8],r15
       xor       ecx,ecx
       mov       [rbp-1F0],rcx
       mov       byte ptr [rbp-1E8],0
       mov       ecx,r13d
       call      qword ptr [7FFA06FCEF10]
       mov       r8,rax
       cmp       byte ptr [rbp-1E8],0
       jne       near ptr M30_L26
       mov       rcx,[rbp-1F8]
       mov       rdx,r8
       cmp       [rcx],ecx
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
M30_L10:
       lea       rcx,[rbp-1F8]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFA06FCEFE8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       mov       r8,rax
       cmp       byte ptr [rbp-1E8],0
       jne       near ptr M30_L27
       mov       rcx,[rbp-1F8]
       mov       rdx,r8
       cmp       [rcx],ecx
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
M30_L11:
       lea       rcx,[rbp-1F8]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       [r15],r15b
       imul      eax,r13d,3E8
       sub       r14d,eax
M30_L12:
       mov       edx,51EB851F
       mov       eax,edx
       imul      r14d
       mov       r13d,edx
       shr       r13d,1F
       sar       edx,5
       add       r13d,edx
       test      r13d,r13d
       jg        near ptr M30_L19
M30_L13:
       test      r14d,r14d
       jle       near ptr M30_L16
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       test      eax,eax
       jg        near ptr M30_L22
M30_L14:
       mov       rax,offset MT_System.String[]
       mov       [rbp-510],rax
       lea       rax,[rbp-510]
       mov       dword ptr [rax+8],14
       lea       r13,[rbp-510]
       call      qword ptr [7FFA06FCEF40]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       lea       rcx,[r13+10]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF048]; DotNetTips.Spargine.Extensions.Properties.Resources.get_One()
       lea       rcx,[r13+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF060]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Two()
       lea       rcx,[r13+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF078]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Three()
       lea       rcx,[r13+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF090]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Four()
       lea       rcx,[r13+30]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF0A8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Five()
       lea       rcx,[r13+38]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF0C0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Six()
       lea       rcx,[r13+40]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF0D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Seven()
       lea       rcx,[r13+48]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF0F0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eight()
       lea       rcx,[r13+50]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF108]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Nine()
       lea       rcx,[r13+58]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF120]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Ten()
       lea       rcx,[r13+60]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF138]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eleven()
       lea       rcx,[r13+68]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF150]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Twelve()
       lea       rcx,[r13+70]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF168]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thirteen()
       lea       rcx,[r13+78]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF180]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Fourteen()
       lea       rcx,[r13+80]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF198]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Fifteen()
       lea       rcx,[r13+88]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Sixteen()
       lea       rcx,[r13+90]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1C8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Seventeen()
       lea       rcx,[r13+98]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1E0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eighteen()
       lea       rcx,[r13+0A0]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1F8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Nineteen()
       lea       rcx,[r13+0A8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,offset MT_System.String[]
       mov       [rbp-570],rax
       lea       rax,[rbp-570]
       mov       dword ptr [rax+8],0A
       lea       r12,[rbp-570]
       call      qword ptr [7FFA06FCEF40]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       lea       rcx,[r12+10]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF120]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Ten()
       lea       rcx,[r12+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF210]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Twenty()
       lea       rcx,[r12+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF228]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thirty()
       lea       rcx,[r12+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF240]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Forty()
       lea       rcx,[r12+30]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF258]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Fifty()
       lea       rcx,[r12+38]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF270]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Sixty()
       lea       rcx,[r12+40]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF288]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Seventy()
       lea       rcx,[r12+48]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF2A0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eighty()
       lea       rcx,[r12+50]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF2B8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Ninety()
       lea       rcx,[r12+58]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       r14d,14
       jl        near ptr M30_L24
       mov       eax,0CCCCCCCD
       mov       r10d,r14d
       imul      rax,r10
       shr       rax,23
       mov       [rbp-794],eax
       cmp       eax,0A
       jae       near ptr M30_L34
       mov       r8d,eax
       mov       rdx,[r12+r8*8+10]
       test      rdx,rdx
       je        short M30_L15
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,r15
       call      qword ptr [7FFA06AEF150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M30_L15:
       mov       eax,[rbp-794]
       lea       ecx,[rax+rax*4]
       add       ecx,ecx
       sub       r14d,ecx
       test      r14d,r14d
       jle       short M30_L16
       mov       [rbp-1F8],r15
       xor       ecx,ecx
       mov       [rbp-1F0],rcx
       mov       byte ptr [rbp-1E8],0
       lea       rcx,[rbp-1F8]
       mov       edx,2D
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       r14d,14
       jae       near ptr M30_L34
       mov       r8d,r14d
       mov       rdx,[r13+r8*8+10]
       cmp       byte ptr [rbp-1E8],0
       jne       near ptr M30_L31
       mov       rcx,[rbp-1F8]
       cmp       [rcx],cl
       test      rdx,rdx
       je        short M30_L16
       mov       r8d,[rdx+8]
       add       rdx,0C
       call      qword ptr [7FFA06AEF150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M30_L16:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFA06B62100]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       cmp       dword ptr [r14+8],0
       je        short M30_L18
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jge       near ptr M30_L32
       mov       rax,7FFA65786090
       test      byte ptr [rax+rcx],80
       jne       near ptr M30_L35
M30_L17:
       mov       ecx,[r14+8]
       dec       ecx
       cmp       ecx,[r14+8]
       jae       near ptr M30_L34
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M30_L33
       mov       rax,7FFA65786090
       test      byte ptr [rax+rcx],80
       jne       near ptr M30_L35
M30_L18:
       mov       r13,r14
       jmp       near ptr M30_L36
M30_L19:
       mov       [rbp-1F8],r15
       xor       ecx,ecx
       mov       [rbp-1F0],rcx
       mov       byte ptr [rbp-1E8],0
       mov       ecx,r13d
       call      qword ptr [7FFA06FCEF10]
       mov       r8,rax
       cmp       byte ptr [rbp-1E8],0
       jne       near ptr M30_L28
       mov       rcx,[rbp-1F8]
       mov       rdx,r8
       cmp       [rcx],ecx
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
M30_L20:
       lea       rcx,[rbp-1F8]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFA06FCF000]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       mov       r8,rax
       cmp       byte ptr [rbp-1E8],0
       jne       near ptr M30_L29
       mov       rcx,[rbp-1F8]
       mov       rdx,r8
       cmp       [rcx],ecx
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
M30_L21:
       lea       rcx,[rbp-1F8]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       [r15],r15b
       imul      eax,r13d,64
       sub       r14d,eax
       jmp       near ptr M30_L13
M30_L22:
       mov       [rbp-1F8],r15
       xor       eax,eax
       mov       [rbp-1F0],rax
       mov       byte ptr [rbp-1E8],0
       call      qword ptr [7FFA06FCF030]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       r8,rax
       cmp       byte ptr [rbp-1E8],0
       jne       near ptr M30_L30
       mov       rcx,[rbp-1F8]
       mov       rdx,r8
       cmp       [rcx],ecx
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
M30_L23:
       lea       rcx,[rbp-1F8]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       jmp       near ptr M30_L14
M30_L24:
       mov       edx,r14d
       mov       rdx,[r13+rdx*8+10]
       mov       rcx,r15
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M30_L16
M30_L25:
       lea       rcx,[rbp-210]
       mov       r9,r15
       xor       edx,edx
       mov       r8d,4
       call      qword ptr [7FFA06FCEF88]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-210]
       vmovdqu   xmmword ptr [rbp-1F8],xmm0
       mov       rcx,[rbp-200]
       mov       [rbp-1E8],rcx
       mov       ecx,r14d
       imul      rcx,431BDE83
       shr       rcx,32
       call      qword ptr [7FFA06FCEF10]
       mov       rdx,rax
       lea       rcx,[rbp-1F8]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-1F8]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFA06FCEFB8]
       mov       rdx,rax
       lea       rcx,[rbp-1F8]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-1F8]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       [r15],r15b
       mov       eax,r14d
       imul      rax,431BDE83
       shr       rax,32
       imul      eax,0F4240
       sub       r14d,eax
       jmp       near ptr M30_L09
M30_L26:
       lea       rcx,[rbp-1F8]
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M30_L10
M30_L27:
       lea       rcx,[rbp-1F8]
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M30_L11
M30_L28:
       lea       rcx,[rbp-1F8]
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M30_L20
M30_L29:
       lea       rcx,[rbp-1F8]
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M30_L21
M30_L30:
       lea       rcx,[rbp-1F8]
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M30_L23
M30_L31:
       lea       rcx,[rbp-1F8]
       mov       r8,rdx
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M30_L16
M30_L32:
       call      qword ptr [7FFA07035ED8]
       test      eax,eax
       jne       short M30_L35
       jmp       near ptr M30_L17
M30_L33:
       call      qword ptr [7FFA07035ED8]
       test      eax,eax
       jne       short M30_L35
       jmp       near ptr M30_L18
M30_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M30_L35:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFA07035EF0]
       mov       r13,rax
M30_L36:
       mov       rcx,24ACB801DB0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M30_L124
       mov       rcx,[rcx+18]
       mov       r14,rcx
M30_L37:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFA06FC4E10]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [r14],rcx
       jne       near ptr M30_L125
       mov       rcx,r14
       mov       rdx,r15
       call      qword ptr [7FFA06FC4E28]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
M30_L38:
       mov       rdx,r13
       cmp       byte ptr [rbp-68],0
       jne       near ptr M30_L126
       mov       rcx,[rbp-78]
       cmp       [rcx],cl
       test      rdx,rdx
       je        short M30_L39
       mov       r8d,[rdx+8]
       add       rdx,0C
       call      qword ptr [7FFA06AEF150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M30_L39:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFA06FCEFE8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       mov       rdx,rax
       cmp       byte ptr [rbp-68],0
       jne       near ptr M30_L127
       mov       rcx,[rbp-78]
       cmp       [rcx],cl
       test      rdx,rdx
       je        short M30_L40
       mov       r8d,[rdx+8]
       add       rdx,0C
       call      qword ptr [7FFA06AEF150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M30_L40:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       [rsi],sil
       imul      eax,edi,3E8
       sub       ebx,eax
M30_L41:
       mov       edx,51EB851F
       mov       eax,edx
       imul      ebx
       mov       edi,edx
       shr       edi,1F
       sar       edx,5
       add       edi,edx
       test      edi,edi
       jg        near ptr M30_L81
M30_L42:
       test      ebx,ebx
       jle       near ptr M30_L77
       mov       eax,[rsi+1C]
       add       eax,[rsi+18]
       test      eax,eax
       jg        near ptr M30_L111
M30_L43:
       mov       rax,offset MT_System.String[]
       mov       [rbp-730],rax
       lea       rax,[rbp-730]
       mov       dword ptr [rax+8],14
       lea       rdi,[rbp-730]
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       r14,offset MT_System.Resources.ResourceManager
       cmp       [rax],r14
       jne       near ptr M30_L135
       mov       r15,24ACB802100
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0990
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L44:
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L136
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B09B0
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L45:
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L137
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B09D0
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L46:
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L138
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B09F0
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L47:
       lea       rcx,[rdi+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L139
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0A10
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L48:
       lea       rcx,[rdi+30]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L140
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0A30
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L49:
       lea       rcx,[rdi+38]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L141
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0A50
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L50:
       lea       rcx,[rdi+40]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L142
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0A70
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L51:
       lea       rcx,[rdi+48]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L143
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0A90
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L52:
       lea       rcx,[rdi+50]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L144
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0AB0
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L53:
       lea       rcx,[rdi+58]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L145
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0AD0
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L54:
       lea       rcx,[rdi+60]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L146
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0AF0
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L55:
       lea       rcx,[rdi+68]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L147
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0B18
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L56:
       lea       rcx,[rdi+70]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L148
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0B40
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L57:
       lea       rcx,[rdi+78]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L149
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0B68
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L58:
       lea       rcx,[rdi+80]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L150
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0B90
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L59:
       lea       rcx,[rdi+88]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L151
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0BB8
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L60:
       lea       rcx,[rdi+90]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L152
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0BE0
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L61:
       lea       rcx,[rdi+98]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L153
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0C08
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L62:
       lea       rcx,[rdi+0A0]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L154
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0C30
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L63:
       lea       rcx,[rdi+0A8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,offset MT_System.String[]
       mov       [rbp-790],rax
       lea       rax,[rbp-790]
       mov       dword ptr [rax+8],0A
       lea       r13,[rbp-790]
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L155
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0990
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L64:
       lea       rcx,[r13+10]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L156
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0AD0
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L65:
       lea       rcx,[r13+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L157
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0C58
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L66:
       lea       rcx,[r13+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L158
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0C80
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L67:
       lea       rcx,[r13+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L159
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0CA8
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L68:
       lea       rcx,[r13+30]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L160
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0CC8
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L69:
       lea       rcx,[r13+38]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L161
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0CE8
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L70:
       lea       rcx,[r13+40]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L162
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0D08
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L71:
       lea       rcx,[r13+48]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L163
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0D30
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L72:
       lea       rcx,[r13+50]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       cmp       [rax],r14
       jne       near ptr M30_L164
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0D58
       call      qword ptr [7FFA06AB8730]; System.Resources.ResourceManager.GetString(System.String, System.Globalization.CultureInfo)
M30_L73:
       lea       rcx,[r13+58]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       ebx,14
       jl        near ptr M30_L113
       mov       edx,66666667
       mov       eax,edx
       imul      ebx
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       eax,edx
       cmp       eax,0A
       jae       near ptr M30_L170
       mov       edx,66666667
       mov       eax,edx
       imul      ebx
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       mov       r8,[r13+r8*8+10]
       test      r8,r8
       je        short M30_L75
       lea       rdx,[r8+0C]
       mov       r14d,[r8+8]
       test      r14d,r14d
       je        short M30_L75
       mov       r8,[rsi+8]
       mov       r15d,[rsi+18]
       lea       ecx,[r15+r14]
       cmp       ecx,[r8+8]
       ja        near ptr M30_L166
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       r14d,2
       jle       near ptr M30_L165
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FFA06975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M30_L74:
       add       r14d,r15d
       mov       [rsi+18],r14d
M30_L75:
       mov       edx,66666667
       mov       eax,edx
       imul      ebx
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,2
       add       ecx,edx
       lea       ecx,[rcx+rcx*4]
       add       ecx,ecx
       mov       edx,ebx
       sub       edx,ecx
       test      edx,edx
       jle       near ptr M30_L77
       mov       [rbp-78],rsi
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       byte ptr [rbp-68],0
       lea       rcx,[rbp-78]
       mov       edx,2D
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,66666667
       mov       eax,edx
       imul      ebx
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       eax,edx
       lea       eax,[rax+rax*4]
       add       eax,eax
       mov       edx,ebx
       sub       edx,eax
       cmp       edx,14
       jae       near ptr M30_L170
       mov       edx,66666667
       mov       eax,edx
       imul      ebx
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       lea       r8d,[r8+r8*4]
       add       r8d,r8d
       mov       ecx,ebx
       sub       ecx,r8d
       mov       r8d,ecx
       mov       r8,[rdi+r8*8+10]
       cmp       byte ptr [rbp-68],0
       jne       near ptr M30_L169
       mov       rbx,[rbp-78]
       cmp       [rbx],bl
       test      r8,r8
       je        short M30_L77
       lea       rdx,[r8+0C]
       mov       edi,[r8+8]
       test      edi,edi
       je        short M30_L77
       mov       r8,[rbx+8]
       mov       r14d,[rbx+18]
       lea       ecx,[r14+rdi]
       cmp       ecx,[r8+8]
       ja        near ptr M30_L168
       movsxd    rcx,r14d
       lea       rcx,[r8+rcx*2+10]
       cmp       edi,2
       jle       near ptr M30_L167
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFA06975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M30_L76:
       add       edi,r14d
       mov       [rbx+18],edi
M30_L77:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFA06B62100]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       cmp       dword ptr [rbx+8],0
       je        short M30_L79
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jge       near ptr M30_L171
       cmp       ecx,100
       jae       near ptr M30_L170
       mov       rax,7FFA65786090
       test      byte ptr [rax+rcx],80
       jne       near ptr M30_L173
M30_L78:
       mov       ecx,[rbx+8]
       dec       ecx
       cmp       ecx,[rbx+8]
       jae       near ptr M30_L170
       mov       ecx,[rbx+8]
       dec       ecx
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M30_L172
       cmp       ecx,100
       jae       near ptr M30_L170
       mov       rax,7FFA65786090
       test      byte ptr [rax+rcx],80
       jne       near ptr M30_L173
M30_L79:
       mov       rcx,rbx
M30_L80:
       mov       [rbp-7A8],rcx
       jmp       near ptr M30_L174
M30_L81:
       mov       [rbp-78],rsi
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       byte ptr [rbp-68],0
       mov       r14d,edi
       mov       rcx,24ACB801DB0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M30_L128
       mov       rcx,[rcx+18]
M30_L82:
       mov       rax,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rcx],rax
       jne       near ptr M30_L129
       call      qword ptr [7FFA06DC1258]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       r15,rax
M30_L83:
       mov       [rbp-7C8],r15
       mov       ecx,r14d
       imul      rcx,431BDE83
       shr       rcx,32
       test      ecx,ecx
       jg        near ptr M30_L98
M30_L84:
       mov       edx,10624DD3
       mov       eax,edx
       imul      r14d
       mov       r13d,edx
       shr       r13d,1F
       sar       edx,6
       add       r13d,edx
       test      r13d,r13d
       jle       near ptr M30_L87
       mov       [rbp-228],r15
       xor       ecx,ecx
       mov       [rbp-220],rcx
       mov       byte ptr [rbp-218],0
       mov       ecx,r13d
       call      qword ptr [7FFA06FCEF10]
       mov       r8,rax
       cmp       byte ptr [rbp-218],0
       jne       near ptr M30_L99
       mov       rcx,[rbp-228]
       mov       rdx,r8
       cmp       [rcx],ecx
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
M30_L85:
       lea       rcx,[rbp-228]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFA06FCEFE8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       mov       r8,rax
       cmp       byte ptr [rbp-218],0
       jne       near ptr M30_L100
       mov       rcx,[rbp-228]
       mov       rdx,r8
       cmp       [rcx],ecx
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
M30_L86:
       lea       rcx,[rbp-228]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       [r15],r15b
       imul      eax,r13d,3E8
       sub       r14d,eax
M30_L87:
       mov       edx,51EB851F
       mov       eax,edx
       imul      r14d
       mov       r13d,edx
       shr       r13d,1F
       sar       edx,5
       add       r13d,edx
       test      r13d,r13d
       jg        near ptr M30_L92
M30_L88:
       test      r14d,r14d
       jle       near ptr M30_L91
       mov       eax,[r15+1C]
       add       eax,[r15+18]
       test      eax,eax
       jg        near ptr M30_L95
M30_L89:
       mov       rax,offset MT_System.String[]
       mov       [rbp-620],rax
       lea       rax,[rbp-620]
       mov       dword ptr [rax+8],14
       lea       r13,[rbp-620]
       call      qword ptr [7FFA06FCEF40]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       lea       rcx,[r13+10]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF048]; DotNetTips.Spargine.Extensions.Properties.Resources.get_One()
       lea       rcx,[r13+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF060]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Two()
       lea       rcx,[r13+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF078]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Three()
       lea       rcx,[r13+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF090]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Four()
       lea       rcx,[r13+30]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF0A8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Five()
       lea       rcx,[r13+38]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF0C0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Six()
       lea       rcx,[r13+40]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF0D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Seven()
       lea       rcx,[r13+48]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF0F0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eight()
       lea       rcx,[r13+50]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF108]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Nine()
       lea       rcx,[r13+58]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF120]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Ten()
       lea       rcx,[r13+60]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF138]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eleven()
       lea       rcx,[r13+68]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF150]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Twelve()
       lea       rcx,[r13+70]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF168]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thirteen()
       lea       rcx,[r13+78]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF180]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Fourteen()
       lea       rcx,[r13+80]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF198]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Fifteen()
       lea       rcx,[r13+88]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Sixteen()
       lea       rcx,[r13+90]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1C8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Seventeen()
       lea       rcx,[r13+98]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1E0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eighteen()
       lea       rcx,[r13+0A0]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1F8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Nineteen()
       lea       rcx,[r13+0A8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,offset MT_System.String[]
       mov       [rbp-680],rax
       lea       rax,[rbp-680]
       mov       dword ptr [rax+8],0A
       lea       r12,[rbp-680]
       call      qword ptr [7FFA06FCEF40]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       lea       rcx,[r12+10]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF120]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Ten()
       lea       rcx,[r12+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF210]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Twenty()
       lea       rcx,[r12+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF228]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thirty()
       lea       rcx,[r12+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF240]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Forty()
       lea       rcx,[r12+30]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF258]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Fifty()
       lea       rcx,[r12+38]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF270]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Sixty()
       lea       rcx,[r12+40]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF288]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Seventy()
       lea       rcx,[r12+48]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF2A0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eighty()
       lea       rcx,[r12+50]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF2B8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Ninety()
       lea       rcx,[r12+58]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       r14d,14
       jl        near ptr M30_L97
       mov       edx,66666667
       mov       eax,edx
       imul      r14d
       mov       eax,edx
       shr       eax,1F
       sar       edx,2
       add       eax,edx
       mov       [rbp-798],eax
       cmp       eax,0A
       jae       near ptr M30_L104
       mov       r8d,eax
       mov       rdx,[r12+r8*8+10]
       test      rdx,rdx
       je        short M30_L90
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,r15
       call      qword ptr [7FFA06AEF150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M30_L90:
       mov       eax,[rbp-798]
       lea       ecx,[rax+rax*4]
       add       ecx,ecx
       sub       r14d,ecx
       test      r14d,r14d
       jle       short M30_L91
       mov       [rbp-228],r15
       xor       ecx,ecx
       mov       [rbp-220],rcx
       mov       byte ptr [rbp-218],0
       lea       rcx,[rbp-228]
       mov       edx,2D
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       r14d,14
       jae       near ptr M30_L104
       mov       ecx,r14d
       mov       r8,[r13+rcx*8+10]
       cmp       byte ptr [rbp-218],0
       jne       near ptr M30_L105
       mov       rcx,[rbp-228]
       mov       rdx,r8
       cmp       [rcx],ecx
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
M30_L91:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFA06B62100]; System.Text.StringBuilder.ToString()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFA06D842A0]; System.String.Trim()
       mov       r14,rax
       jmp       near ptr M30_L106
M30_L92:
       mov       [rbp-228],r15
       xor       ecx,ecx
       mov       [rbp-220],rcx
       mov       byte ptr [rbp-218],0
       mov       ecx,r13d
       call      qword ptr [7FFA06FCEF10]
       mov       r8,rax
       cmp       byte ptr [rbp-218],0
       jne       near ptr M30_L101
       mov       rcx,[rbp-228]
       mov       rdx,r8
       cmp       [rcx],ecx
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
M30_L93:
       lea       rcx,[rbp-228]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFA06FCF000]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       mov       r8,rax
       cmp       byte ptr [rbp-218],0
       jne       near ptr M30_L102
       mov       rcx,[rbp-228]
       mov       rdx,r8
       cmp       [rcx],ecx
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
M30_L94:
       lea       rcx,[rbp-228]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       [r15],r15b
       imul      eax,r13d,64
       sub       r14d,eax
       jmp       near ptr M30_L88
M30_L95:
       mov       [rbp-228],r15
       xor       eax,eax
       mov       [rbp-220],rax
       mov       byte ptr [rbp-218],0
       call      qword ptr [7FFA06FCF030]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       r8,rax
       cmp       byte ptr [rbp-218],0
       jne       near ptr M30_L103
       mov       rcx,[rbp-228]
       mov       rdx,r8
       cmp       [rcx],ecx
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
M30_L96:
       lea       rcx,[rbp-228]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       jmp       near ptr M30_L89
M30_L97:
       cmp       r14d,14
       jae       near ptr M30_L104
       mov       edx,r14d
       mov       rdx,[r13+rdx*8+10]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M30_L91
M30_L98:
       lea       rcx,[rbp-240]
       mov       r9,r15
       xor       edx,edx
       mov       r8d,4
       call      qword ptr [7FFA06FCEF88]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-240]
       vmovdqu   xmmword ptr [rbp-228],xmm0
       mov       rcx,[rbp-230]
       mov       [rbp-218],rcx
       mov       ecx,r14d
       imul      rcx,431BDE83
       shr       rcx,32
       call      qword ptr [7FFA06FCEF10]
       mov       rdx,rax
       lea       rcx,[rbp-228]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-228]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFA06FCEFB8]
       mov       rdx,rax
       lea       rcx,[rbp-228]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-228]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       [r15],r15b
       mov       eax,r14d
       imul      rax,431BDE83
       shr       rax,32
       imul      eax,0F4240
       sub       r14d,eax
       jmp       near ptr M30_L84
M30_L99:
       lea       rcx,[rbp-228]
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M30_L85
M30_L100:
       lea       rcx,[rbp-228]
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M30_L86
M30_L101:
       lea       rcx,[rbp-228]
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M30_L93
M30_L102:
       lea       rcx,[rbp-228]
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M30_L94
M30_L103:
       lea       rcx,[rbp-228]
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M30_L96
M30_L104:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M30_L105:
       lea       rcx,[rbp-228]
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M30_L91
M30_L106:
       mov       rcx,24ACB801DB0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M30_L130
       mov       rcx,[rcx+18]
       mov       r13,rcx
M30_L107:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFA06FC4E10]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [r13],rcx
       jne       near ptr M30_L131
       mov       rcx,r13
       mov       rdx,r15
       call      qword ptr [7FFA06FC4E28]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
M30_L108:
       mov       rdx,r14
       cmp       byte ptr [rbp-68],0
       jne       near ptr M30_L132
       mov       rcx,[rbp-78]
       cmp       [rcx],cl
       test      rdx,rdx
       je        short M30_L109
       mov       r8d,[rdx+8]
       add       rdx,0C
       call      qword ptr [7FFA06AEF150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M30_L109:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFA06FCF000]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       mov       rdx,rax
       cmp       byte ptr [rbp-68],0
       jne       near ptr M30_L133
       mov       rcx,[rbp-78]
       cmp       [rcx],cl
       test      rdx,rdx
       je        short M30_L110
       mov       r8d,[rdx+8]
       add       rdx,0C
       call      qword ptr [7FFA06AEF150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M30_L110:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       [rsi],sil
       imul      eax,edi,64
       sub       ebx,eax
       jmp       near ptr M30_L42
M30_L111:
       mov       [rbp-78],rsi
       xor       eax,eax
       mov       [rbp-70],rax
       mov       byte ptr [rbp-68],0
       call      qword ptr [7FFA06FCF030]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       rdx,rax
       cmp       byte ptr [rbp-68],0
       jne       near ptr M30_L134
       mov       rcx,[rbp-78]
       cmp       [rcx],cl
       test      rdx,rdx
       je        short M30_L112
       mov       r8d,[rdx+8]
       add       rdx,0C
       call      qword ptr [7FFA06AEF150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M30_L112:
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       jmp       near ptr M30_L43
M30_L113:
       cmp       ebx,14
       jae       near ptr M30_L170
       mov       r8d,ebx
       mov       rdx,[rdi+r8*8+10]
       test      rdx,rdx
       je        near ptr M30_L77
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,rsi
       call      qword ptr [7FFA06AEF150]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       near ptr M30_L77
M30_L114:
       lea       rcx,[rbp-90]
       mov       r9,rsi
       xor       edx,edx
       mov       r8d,4
       call      qword ptr [7FFA06FCEF88]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-90]
       vmovdqu   xmmword ptr [rbp-78],xmm0
       mov       rcx,[rbp-80]
       mov       [rbp-68],rcx
       mov       ecx,ebx
       imul      rdi,rcx,431BDE83
       shr       rdi,32
       mov       rcx,24ACB801DB0
       mov       rcx,[rcx]
       call      qword ptr [7FFA06B9FDE0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-7B8],rax
       mov       ecx,edi
       imul      rcx,431BDE83
       shr       rcx,32
       test      ecx,ecx
       jle       near ptr M30_L115
       lea       rcx,[rbp-1E0]
       mov       r9,[rbp-7B8]
       xor       edx,edx
       mov       r8d,4
       call      qword ptr [7FFA06FCEF88]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-1E0]
       vmovdqu   xmmword ptr [rbp-180],xmm0
       mov       rcx,[rbp-1D0]
       mov       [rbp-170],rcx
       mov       ecx,edi
       imul      rcx,431BDE83
       shr       rcx,32
       call      qword ptr [7FFA06FCEF10]
       mov       rdx,rax
       lea       rcx,[rbp-180]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-180]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFA06FCEFB8]
       mov       rdx,rax
       lea       rcx,[rbp-180]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-180]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       rcx,[rbp-7B8]
       cmp       [rcx],cl
       mov       eax,edi
       imul      rax,431BDE83
       shr       rax,32
       imul      eax,0F4240
       sub       edi,eax
M30_L115:
       mov       edx,10624DD3
       mov       eax,edx
       imul      edi
       mov       r9d,edx
       shr       r9d,1F
       sar       edx,6
       add       r9d,edx
       test      r9d,r9d
       jle       near ptr M30_L116
       lea       rcx,[rbp-1C8]
       mov       r9,[rbp-7B8]
       xor       edx,edx
       mov       r8d,4
       call      qword ptr [7FFA06FCEF88]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-1C8]
       vmovdqu   xmmword ptr [rbp-180],xmm0
       mov       rax,[rbp-1B8]
       mov       [rbp-170],rax
       mov       edx,10624DD3
       mov       eax,edx
       imul      edi
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,6
       add       ecx,edx
       call      qword ptr [7FFA06FCEF10]
       mov       rdx,rax
       lea       rcx,[rbp-180]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-180]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFA06FCEFE8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       mov       rdx,rax
       lea       rcx,[rbp-180]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-180]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       r9,[rbp-7B8]
       cmp       [r9],r9b
       mov       edx,10624DD3
       mov       eax,edx
       imul      edi
       mov       eax,edx
       shr       eax,1F
       sar       edx,6
       add       eax,edx
       imul      eax,3E8
       sub       edi,eax
M30_L116:
       mov       edx,51EB851F
       mov       eax,edx
       imul      edi
       mov       r9d,edx
       shr       r9d,1F
       sar       edx,5
       add       r9d,edx
       test      r9d,r9d
       jle       near ptr M30_L117
       lea       rcx,[rbp-1B0]
       mov       r9,[rbp-7B8]
       xor       edx,edx
       mov       r8d,4
       call      qword ptr [7FFA06FCEF88]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-1B0]
       vmovdqu   xmmword ptr [rbp-180],xmm0
       mov       rax,[rbp-1A0]
       mov       [rbp-170],rax
       mov       edx,51EB851F
       mov       eax,edx
       imul      edi
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,5
       add       ecx,edx
       call      qword ptr [7FFA06FCEF10]
       mov       rdx,rax
       lea       rcx,[rbp-180]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-180]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFA06FCF000]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       mov       rdx,rax
       lea       rcx,[rbp-180]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-180]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       r9,[rbp-7B8]
       cmp       [r9],r9b
       mov       edx,51EB851F
       mov       eax,edx
       imul      edi
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,5
       add       ecx,edx
       imul      ecx,64
       sub       edi,ecx
M30_L117:
       test      edi,edi
       jle       near ptr M30_L121
       mov       rcx,[rbp-7B8]
       mov       r9d,[rcx+1C]
       add       r9d,[rcx+18]
       test      r9d,r9d
       jle       short M30_L118
       lea       rcx,[rbp-198]
       mov       r9,[rbp-7B8]
       xor       edx,edx
       mov       r8d,2
       call      qword ptr [7FFA06FCEF88]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-198]
       vmovdqu   xmmword ptr [rbp-180],xmm0
       mov       rax,[rbp-188]
       mov       [rbp-170],rax
       call      qword ptr [7FFA06FCF030]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       rdx,rax
       lea       rcx,[rbp-180]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-180]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
M30_L118:
       mov       rax,offset MT_System.String[]
       mov       [rbp-400],rax
       lea       rax,[rbp-400]
       mov       dword ptr [rax+8],14
       lea       r14,[rbp-400]
       call      qword ptr [7FFA06FCEF40]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF048]; DotNetTips.Spargine.Extensions.Properties.Resources.get_One()
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF060]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Two()
       lea       rcx,[r14+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF078]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Three()
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF090]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Four()
       lea       rcx,[r14+30]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF0A8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Five()
       lea       rcx,[r14+38]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF0C0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Six()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF0D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Seven()
       lea       rcx,[r14+48]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF0F0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eight()
       lea       rcx,[r14+50]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF108]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Nine()
       lea       rcx,[r14+58]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF120]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Ten()
       lea       rcx,[r14+60]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF138]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eleven()
       lea       rcx,[r14+68]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF150]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Twelve()
       lea       rcx,[r14+70]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF168]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thirteen()
       lea       rcx,[r14+78]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF180]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Fourteen()
       lea       rcx,[r14+80]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF198]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Fifteen()
       lea       rcx,[r14+88]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Sixteen()
       lea       rcx,[r14+90]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1C8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Seventeen()
       lea       rcx,[r14+98]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1E0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eighteen()
       lea       rcx,[r14+0A0]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1F8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Nineteen()
       lea       rcx,[r14+0A8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,offset MT_System.String[]
       mov       [rbp-460],rax
       lea       rax,[rbp-460]
       mov       dword ptr [rax+8],0A
       lea       r15,[rbp-460]
       call      qword ptr [7FFA06FCEF40]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       lea       rcx,[r15+10]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF120]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Ten()
       lea       rcx,[r15+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF210]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Twenty()
       lea       rcx,[r15+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF228]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thirty()
       lea       rcx,[r15+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF240]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Forty()
       lea       rcx,[r15+30]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF258]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Fifty()
       lea       rcx,[r15+38]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF270]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Sixty()
       lea       rcx,[r15+40]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF288]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Seventy()
       lea       rcx,[r15+48]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF2A0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eighty()
       lea       rcx,[r15+50]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF2B8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Ninety()
       lea       rcx,[r15+58]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       edi,14
       jge       short M30_L120
       mov       edx,edi
       mov       rdx,[r14+rdx*8+10]
       mov       rcx,[rbp-7B8]
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M30_L121
M30_L119:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M30_L120:
       mov       edx,0CCCCCCCD
       mov       ecx,edi
       imul      rdx,rcx
       shr       rdx,23
       cmp       edx,0A
       jae       short M30_L119
       mov       edx,0CCCCCCCD
       mov       ecx,edi
       imul      rdx,rcx
       shr       rdx,23
       mov       edx,edx
       mov       rdx,[r15+rdx*8+10]
       mov       rcx,[rbp-7B8]
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,0CCCCCCCD
       mov       r9d,edi
       imul      rcx,r9
       shr       rcx,23
       lea       ecx,[rcx+rcx*4]
       add       ecx,ecx
       mov       r9d,edi
       sub       r9d,ecx
       test      r9d,r9d
       jle       near ptr M30_L121
       lea       rcx,[rbp-168]
       mov       r9,[rbp-7B8]
       xor       edx,edx
       mov       r8d,2
       call      qword ptr [7FFA06FCEF88]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-168]
       vmovdqu   xmmword ptr [rbp-180],xmm0
       mov       rcx,[rbp-158]
       mov       [rbp-170],rcx
       lea       rcx,[rbp-180]
       mov       edx,2D
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,0CCCCCCCD
       mov       ecx,edi
       imul      rdx,rcx
       shr       rdx,23
       lea       edx,[rdx+rdx*4]
       add       edx,edx
       mov       ecx,edi
       sub       ecx,edx
       cmp       ecx,14
       jae       near ptr M30_L119
       mov       edx,0CCCCCCCD
       mov       ecx,edi
       imul      rdx,rcx
       shr       rdx,23
       lea       edx,[rdx+rdx*4]
       add       edx,edx
       mov       ecx,edi
       sub       ecx,edx
       mov       edx,ecx
       mov       rdx,[r14+rdx*8+10]
       lea       rcx,[rbp-180]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
M30_L121:
       mov       rcx,[rbp-7B8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA06B62100]; System.Text.StringBuilder.ToString()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFA06D842A0]; System.String.Trim()
       mov       rdi,rax
       mov       rcx,24ACB801DB0
       mov       rcx,[rcx]
       call      qword ptr [7FFA06B9FDE0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       r14,rax
       mov       rcx,[rbp-7B8]
       xor       edx,edx
       call      qword ptr [7FFA06FC4E10]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       rdx,[rbp-7B8]
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdx,rdi
       lea       rcx,[rbp-78]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFA06FCEFB8]
       mov       rdx,rax
       lea       rcx,[rbp-78]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       cmp       [rsi],sil
       mov       eax,ebx
       imul      rax,431BDE83
       shr       rax,32
       imul      eax,0F4240
       sub       ebx,eax
       jmp       near ptr M30_L06
M30_L122:
       call      qword ptr [7FFA06B9FE40]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M30_L07
M30_L123:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M30_L08
M30_L124:
       call      qword ptr [7FFA06B9FE40]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M30_L37
M30_L125:
       mov       rcx,r14
       mov       rdx,r15
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L38
M30_L126:
       lea       rcx,[rbp-78]
       mov       r8,rdx
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M30_L39
M30_L127:
       lea       rcx,[rbp-78]
       mov       r8,rdx
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M30_L40
M30_L128:
       call      qword ptr [7FFA06B9FE40]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M30_L82
M30_L129:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M30_L83
M30_L130:
       call      qword ptr [7FFA06B9FE40]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r13,rax
       jmp       near ptr M30_L107
M30_L131:
       mov       rcx,r13
       mov       rdx,r15
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L108
M30_L132:
       lea       rcx,[rbp-78]
       mov       r8,rdx
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M30_L109
M30_L133:
       lea       rcx,[rbp-78]
       mov       r8,rdx
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M30_L110
M30_L134:
       lea       rcx,[rbp-78]
       mov       r8,rdx
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M30_L112
M30_L135:
       mov       r15,24ACB802100
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0990
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L44
M30_L136:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B09B0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L45
M30_L137:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B09D0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L46
M30_L138:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B09F0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L47
M30_L139:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0A10
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L48
M30_L140:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0A30
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L49
M30_L141:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0A50
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L50
M30_L142:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0A70
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L51
M30_L143:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0A90
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L52
M30_L144:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0AB0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L53
M30_L145:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0AD0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L54
M30_L146:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0AF0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L55
M30_L147:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0B18
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L56
M30_L148:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0B40
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L57
M30_L149:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0B68
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L58
M30_L150:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0B90
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L59
M30_L151:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0BB8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L60
M30_L152:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0BE0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L61
M30_L153:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0C08
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L62
M30_L154:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0C30
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L63
M30_L155:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0990
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L64
M30_L156:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0AD0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L65
M30_L157:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0C58
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L66
M30_L158:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0C80
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L67
M30_L159:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0CA8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L68
M30_L160:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0CC8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L69
M30_L161:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0CE8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L70
M30_L162:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0D08
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L71
M30_L163:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0D30
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L72
M30_L164:
       mov       r8,[r15]
       mov       rcx,rax
       mov       rdx,28B608B0D58
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M30_L73
M30_L165:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r14d,2
       jne       near ptr M30_L74
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M30_L74
M30_L166:
       mov       rcx,rsi
       mov       r8d,r14d
       call      qword ptr [7FFA06AEF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M30_L75
M30_L167:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       edi,2
       jne       near ptr M30_L76
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M30_L76
M30_L168:
       mov       rcx,rbx
       mov       r8d,edi
       call      qword ptr [7FFA06AEF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M30_L77
M30_L169:
       lea       rcx,[rbp-78]
       mov       rdx,7FFA07029E78
       call      qword ptr [7FFA06FCF570]
       jmp       near ptr M30_L77
M30_L170:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M30_L171:
       call      qword ptr [7FFA07035ED8]
       test      eax,eax
       jne       short M30_L173
       jmp       near ptr M30_L78
M30_L172:
       call      qword ptr [7FFA07035ED8]
       test      eax,eax
       je        near ptr M30_L79
M30_L173:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFA07035EF0]
       mov       rcx,rax
       jmp       near ptr M30_L80
M30_L174:
       call      M30_L204
       nop
       mov       rax,[rbp-7A8]
       add       rsp,7B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M30_L175:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-150]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA06FC4DB0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M30_L176
       cmp       qword ptr [r14+10],0
       je        short M30_L177
       lea       rdx,[rbp-150]
       mov       rcx,rdi
       call      qword ptr [7FFA07036D78]
       test      eax,eax
       je        short M30_L178
M30_L176:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M30_L03
M30_L177:
       xor       ecx,ecx
       mov       [rbp-150],rcx
M30_L178:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rsi,rax
       jmp       near ptr M30_L04
M30_L179:
       call      qword ptr [7FFA06FCEF40]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       nop
       add       rsp,7B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M30_L180:
       lea       rcx,[rbp-60]
       xor       edx,edx
       mov       r8d,3
       call      qword ptr [7FFA06B94E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       call      qword ptr [7FFA06FCEF58]
       mov       rdx,rax
       lea       rcx,[rbp-60]
       call      qword ptr [7FFA06B9E1A8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-60]
       mov       edx,20
       call      qword ptr [7FFA06FCCD68]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       neg       ebx
       js        short M30_L182
       mov       esi,ebx
       test      esi,esi
       jne       short M30_L181
       call      qword ptr [7FFA06FCEF40]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       mov       rbx,rax
       jmp       near ptr M30_L192
M30_L181:
       test      esi,esi
       jge       short M30_L184
       lea       rcx,[rbp-148]
       xor       edx,edx
       mov       r8d,3
       call      qword ptr [7FFA06B94E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       call      qword ptr [7FFA06FCEF58]
       mov       rdx,rax
       lea       rcx,[rbp-148]
       call      qword ptr [7FFA06B9E1A8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-148]
       mov       edx,20
       call      qword ptr [7FFA06FCCD68]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       ecx,ebx
       neg       ecx
       jns       short M30_L183
M30_L182:
       call      qword ptr [7FFA07037210]
       int       3
M30_L183:
       call      qword ptr [7FFA06FCEF10]
       mov       rdx,rax
       lea       rcx,[rbp-148]
       call      qword ptr [7FFA06B9E1A8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-148]
       call      qword ptr [7FFA06B94EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbx,rax
       jmp       near ptr M30_L192
M30_L184:
       mov       rcx,24ACB801DB0
       mov       rcx,[rcx]
       call      qword ptr [7FFA06B9FDE0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-7B0],rax
       mov       ecx,esi
       imul      rcx,431BDE83
       shr       rcx,32
       test      ecx,ecx
       jle       near ptr M30_L185
       lea       rcx,[rbp-120]
       mov       r9,[rbp-7B0]
       xor       edx,edx
       mov       r8d,4
       call      qword ptr [7FFA06FCEF88]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-120]
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       mov       rcx,[rbp-110]
       mov       [rbp-0B0],rcx
       mov       ecx,ebx
       imul      rcx,431BDE83
       shr       rcx,32
       call      qword ptr [7FFA06FCEF10]
       mov       rdx,rax
       lea       rcx,[rbp-0C0]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-0C0]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFA06FCEFB8]
       mov       rdx,rax
       lea       rcx,[rbp-0C0]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-0C0]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       rcx,[rbp-7B0]
       cmp       [rcx],cl
       mov       eax,ebx
       imul      rax,431BDE83
       shr       rax,32
       imul      eax,0F4240
       mov       esi,ebx
       sub       esi,eax
M30_L185:
       mov       edx,10624DD3
       mov       eax,edx
       imul      esi
       mov       r9d,edx
       shr       r9d,1F
       sar       edx,6
       add       r9d,edx
       test      r9d,r9d
       jle       near ptr M30_L186
       lea       rcx,[rbp-108]
       mov       r9,[rbp-7B0]
       xor       edx,edx
       mov       r8d,4
       call      qword ptr [7FFA06FCEF88]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-108]
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       mov       rax,[rbp-0F8]
       mov       [rbp-0B0],rax
       mov       edx,10624DD3
       mov       eax,edx
       imul      esi
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,6
       add       ecx,edx
       call      qword ptr [7FFA06FCEF10]
       mov       rdx,rax
       lea       rcx,[rbp-0C0]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-0C0]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFA06FCEFE8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
       mov       rdx,rax
       lea       rcx,[rbp-0C0]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-0C0]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       r9,[rbp-7B0]
       cmp       [r9],r9b
       mov       edx,10624DD3
       mov       eax,edx
       imul      esi
       mov       eax,edx
       shr       eax,1F
       sar       edx,6
       add       eax,edx
       imul      eax,3E8
       sub       esi,eax
M30_L186:
       mov       edx,51EB851F
       mov       eax,edx
       imul      esi
       mov       r9d,edx
       shr       r9d,1F
       sar       edx,5
       add       r9d,edx
       test      r9d,r9d
       jle       near ptr M30_L187
       lea       rcx,[rbp-0F0]
       mov       r9,[rbp-7B0]
       xor       edx,edx
       mov       r8d,4
       call      qword ptr [7FFA06FCEF88]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-0F0]
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       mov       rax,[rbp-0E0]
       mov       [rbp-0B0],rax
       mov       edx,51EB851F
       mov       eax,edx
       imul      esi
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,5
       add       ecx,edx
       call      qword ptr [7FFA06FCEF10]
       mov       rdx,rax
       lea       rcx,[rbp-0C0]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-0C0]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       call      qword ptr [7FFA06FCF000]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
       mov       rdx,rax
       lea       rcx,[rbp-0C0]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-0C0]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       r9,[rbp-7B0]
       cmp       [r9],r9b
       mov       edx,51EB851F
       mov       eax,edx
       imul      esi
       mov       ecx,edx
       shr       ecx,1F
       sar       edx,5
       add       ecx,edx
       imul      ecx,64
       sub       esi,ecx
M30_L187:
       test      esi,esi
       jle       near ptr M30_L191
       mov       rcx,[rbp-7B0]
       mov       r9d,[rcx+1C]
       add       r9d,[rcx+18]
       test      r9d,r9d
       jle       short M30_L188
       lea       rcx,[rbp-0D8]
       mov       r9,[rbp-7B0]
       xor       edx,edx
       mov       r8d,2
       call      qword ptr [7FFA06FCEF88]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-0D8]
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       mov       rax,[rbp-0C8]
       mov       [rbp-0B0],rax
       call      qword ptr [7FFA06FCF030]; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
       mov       rdx,rax
       lea       rcx,[rbp-0C0]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-0C0]
       mov       edx,20
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
M30_L188:
       mov       rax,offset MT_System.String[]
       mov       [rbp-2F0],rax
       lea       rax,[rbp-2F0]
       mov       dword ptr [rax+8],14
       lea       rbx,[rbp-2F0]
       call      qword ptr [7FFA06FCEF40]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF048]; DotNetTips.Spargine.Extensions.Properties.Resources.get_One()
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF060]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Two()
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF078]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Three()
       lea       rcx,[rbx+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF090]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Four()
       lea       rcx,[rbx+30]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF0A8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Five()
       lea       rcx,[rbx+38]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF0C0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Six()
       lea       rcx,[rbx+40]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF0D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Seven()
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF0F0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eight()
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF108]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Nine()
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF120]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Ten()
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF138]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eleven()
       lea       rcx,[rbx+68]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF150]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Twelve()
       lea       rcx,[rbx+70]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF168]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thirteen()
       lea       rcx,[rbx+78]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF180]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Fourteen()
       lea       rcx,[rbx+80]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF198]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Fifteen()
       lea       rcx,[rbx+88]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1B0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Sixteen()
       lea       rcx,[rbx+90]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1C8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Seventeen()
       lea       rcx,[rbx+98]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1E0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eighteen()
       lea       rcx,[rbx+0A0]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF1F8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Nineteen()
       lea       rcx,[rbx+0A8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,offset MT_System.String[]
       mov       [rbp-350],rax
       lea       rax,[rbp-350]
       mov       dword ptr [rax+8],0A
       lea       rdi,[rbp-350]
       call      qword ptr [7FFA06FCEF40]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Zero()
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF120]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Ten()
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF210]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Twenty()
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF228]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thirty()
       lea       rcx,[rdi+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF240]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Forty()
       lea       rcx,[rdi+30]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF258]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Fifty()
       lea       rcx,[rdi+38]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF270]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Sixty()
       lea       rcx,[rdi+40]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF288]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Seventy()
       lea       rcx,[rdi+48]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF2A0]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Eighty()
       lea       rcx,[rdi+50]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       call      qword ptr [7FFA06FCF2B8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_Ninety()
       lea       rcx,[rdi+58]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       esi,14
       jge       short M30_L190
       mov       edx,esi
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,[rbp-7B0]
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M30_L191
M30_L189:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M30_L190:
       mov       edx,0CCCCCCCD
       mov       ecx,esi
       imul      rdx,rcx
       shr       rdx,23
       cmp       edx,0A
       jae       short M30_L189
       mov       edx,0CCCCCCCD
       mov       ecx,esi
       imul      rdx,rcx
       shr       rdx,23
       mov       edx,edx
       mov       rdx,[rdi+rdx*8+10]
       mov       rcx,[rbp-7B0]
       call      qword ptr [7FFA06AEF228]; System.Text.StringBuilder.Append(System.String)
       mov       ecx,0CCCCCCCD
       mov       r9d,esi
       imul      rcx,r9
       shr       rcx,23
       lea       ecx,[rcx+rcx*4]
       add       ecx,ecx
       mov       r9d,esi
       sub       r9d,ecx
       test      r9d,r9d
       jle       near ptr M30_L191
       lea       rcx,[rbp-0A8]
       mov       r9,[rbp-7B0]
       xor       edx,edx
       mov       r8d,2
       call      qword ptr [7FFA06FCEF88]; System.Text.StringBuilder+AppendInterpolatedStringHandler..ctor(Int32, Int32, System.Text.StringBuilder)
       vmovdqu   xmm0,xmmword ptr [rbp-0A8]
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       mov       rcx,[rbp-98]
       mov       [rbp-0B0],rcx
       lea       rcx,[rbp-0C0]
       mov       edx,2D
       call      qword ptr [7FFA06FCEF28]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       edx,0CCCCCCCD
       mov       ecx,esi
       imul      rdx,rcx
       shr       rdx,23
       lea       edx,[rdx+rdx*4]
       add       edx,edx
       mov       ecx,esi
       sub       ecx,edx
       cmp       ecx,14
       jae       near ptr M30_L189
       mov       edx,0CCCCCCCD
       mov       ecx,esi
       imul      rdx,rcx
       shr       rdx,23
       lea       edx,[rdx+rdx*4]
       add       edx,edx
       mov       ecx,esi
       sub       ecx,edx
       mov       edx,ecx
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rbp-0C0]
       call      qword ptr [7FFA06FCEFA0]; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
M30_L191:
       mov       rcx,[rbp-7B0]
       cmp       [rcx],ecx
       call      qword ptr [7FFA06B62100]; System.Text.StringBuilder.ToString()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFA06D842A0]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,24ACB801DB0
       mov       rcx,[rcx]
       call      qword ptr [7FFA06B9FDE0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rsi,rax
       mov       rcx,[rbp-7B0]
       xor       edx,edx
       call      qword ptr [7FFA06FC4E10]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rsi
       mov       rdx,[rbp-7B0]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M30_L192:
       lea       rcx,[rbp-60]
       mov       rdx,rbx
       call      qword ptr [7FFA06B9E1A8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFA06B94EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
       add       rsp,7B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M30_L193:
       call      qword ptr [7FFA06B9FE40]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       near ptr M30_L02
M30_L194:
       call      qword ptr [7FFA07035EA8]
       int       3
M30_L195:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M30_L05
       sub       rsp,28
       mov       rcx,24ACB801DB0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFA06B9FDE0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rdi,rax
       mov       rcx,[rbp-7B8]
       cmp       [rcx],cl
       xor       edx,edx
       call      qword ptr [7FFA06FC4E10]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rdi
       mov       rdx,[rbp-7B8]
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,24ACB801DB0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M30_L196
       call      qword ptr [7FFA06B9FE40]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r13,rax
       jmp       short M30_L197
M30_L196:
       mov       r13,[rcx+18]
M30_L197:
       mov       rdx,[rbp-7C0]
       cmp       [rdx],dl
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFA06FC4E10]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [r13],rcx
       jne       short M30_L198
       mov       rcx,r13
       mov       rdx,[rbp-7C0]
       call      qword ptr [7FFA06FC4E28]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       jmp       short M30_L199
M30_L198:
       mov       rcx,r13
       mov       rdx,[rbp-7C0]
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M30_L199:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,24ACB801DB0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M30_L200
       call      qword ptr [7FFA06B9FE40]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       short M30_L201
M30_L200:
       mov       r14,[rcx+18]
M30_L201:
       mov       rdx,[rbp-7C8]
       cmp       [rdx],dl
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFA06FC4E10]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [r14],rcx
       jne       short M30_L202
       mov       rcx,r14
       mov       rdx,[rbp-7C8]
       call      qword ptr [7FFA06FC4E28]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       jmp       short M30_L203
M30_L202:
       mov       rcx,r14
       mov       rdx,[rbp-7C8]
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M30_L203:
       nop
       add       rsp,28
       ret
M30_L204:
       sub       rsp,28
       mov       rcx,24ACB801DB0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M30_L205
       call      qword ptr [7FFA06B9FE40]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M30_L206
M30_L205:
       mov       rbx,[rcx+18]
M30_L206:
       mov       rdx,[rbp-7A0]
       cmp       dword ptr [rdx+20],0
       jge       short M30_L207
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA068B4000
       call      qword ptr [7FFA06B977B0]
       mov       rsi,rax
       call      qword ptr [7FFA07036BB0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA06B9D890]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M30_L207:
       cmp       qword ptr [rdx+10],0
       jne       short M30_L208
       xor       ecx,ecx
       mov       [rdx+18],rcx
       jmp       near ptr M30_L215
M30_L208:
       mov       ecx,[rdx+1C]
       add       ecx,[rdx+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M30_L209
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFA07036D30]
       mov       rdx,[rbp-7A0]
       jmp       near ptr M30_L215
M30_L209:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFA07036D48]
       mov       rsi,rax
       mov       rcx,[rbp-7A0]
       cmp       rsi,rcx
       je        near ptr M30_L214
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
       sub       r8d,[rsi+1C]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],r8d
       jge       short M30_L212
       cmp       r8d,400
       jge       short M30_L210
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       jmp       short M30_L211
M30_L210:
       mov       ecx,r8d
       xor       edx,edx
       call      qword ptr [7FFA06EFE838]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M30_L211:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FFA06AE5050]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbp-7A0]
       lea       rcx,[rcx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M30_L213
M30_L212:
       mov       rdx,[rsi+8]
       mov       rcx,[rbp-7A0]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
M30_L213:
       mov       rdx,[rsi+10]
       mov       rcx,[rbp-7A0]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsi+1C]
       mov       rax,[rbp-7A0]
       mov       [rax+1C],ecx
       mov       rcx,rax
M30_L214:
       mov       r8d,[rsi+1C]
       neg       r8d
       mov       [rcx+18],r8d
       mov       rdx,rcx
M30_L215:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [rbx],rcx
       jne       near ptr M30_L219
       mov       rax,[rbx+10]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        near ptr M30_L220
       cmp       qword ptr [rbx+20],0
       jne       short M30_L217
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M30_L216
       call      qword ptr [7FFA07035EA8]
       int       3
M30_L216:
       mov       rdx,[rbp-7A0]
       xor       r8d,r8d
       call      00007FFA665CCC60
       test      rax,rax
       je        short M30_L220
M30_L217:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M30_L218
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-7A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFA06FC5500]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M30_L220
       mov       rcx,rbx
       mov       rdx,[rbp-7A0]
       call      qword ptr [7FFA07036DF0]
       jmp       short M30_L220
M30_L218:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M30_L220
M30_L219:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M30_L220:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,24ACB801DB0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFA06B9FDE0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rbx,rax
       mov       rcx,[rbp-7B0]
       cmp       [rcx],cl
       xor       edx,edx
       call      qword ptr [7FFA06FC4E10]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rbx
       mov       rdx,[rbp-7B0]
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       ret
; Total bytes of code 13376
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M31_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M31_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M31_L02
       test      r8b,18
       je        short M31_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M31_L00:
       vzeroupper
       ret
M31_L01:
       test      r8b,4
       je        near ptr M31_L08
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M31_L00
M31_L02:
       cmp       r8,40
       jbe       short M31_L05
       cmp       r8,800
       ja        near ptr M31_L11
       cmp       r8,100
       jae       near ptr M31_L09
M31_L03:
       mov       r9,r8
       shr       r9,6
M31_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M31_L04
       and       r8,3F
       cmp       r8,10
       jbe       short M31_L06
M31_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M31_L06
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M31_L07
M31_L06:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       near ptr M31_L00
M31_L07:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M31_L06
M31_L08:
       test      r8,r8
       je        near ptr M31_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M31_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M31_L00
M31_L09:
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
       jmp       near ptr M31_L03
M31_L10:
       cmp       rcx,rdx
       jne       short M31_L11
       cmp       [rdx],dl
       jmp       near ptr M31_L00
M31_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA069766E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 341
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Thousand()
;                 return ResourceManager.GetString("Thousand", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0D80
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_Hundred()
;                 return ResourceManager.GetString("Hundred", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0DA8
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; DotNetTips.Spargine.Extensions.Properties.Resources.get_AndLowerCase()
;                 return ResourceManager.GetString("AndLowerCase", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFA06FCF3D8]; DotNetTips.Spargine.Extensions.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,24ACB802100
       mov       r8,[r8]
       mov       rdx,28B608B0DD0
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; System.Text.StringBuilder+AppendInterpolatedStringHandler.AppendFormatted(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       cmp       byte ptr [rcx+10],0
       jne       short M35_L04
       mov       rbx,[rcx]
       cmp       [rbx],bl
       test      rdx,rdx
       je        short M35_L01
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M35_L01
       mov       rcx,[rbx+8]
       mov       edx,[rbx+18]
       lea       esi,[rdx+r8]
       cmp       esi,[rcx+8]
       ja        short M35_L03
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jle       short M35_L02
       mov       r8d,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFA06975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M35_L00:
       mov       [rbx+18],esi
M35_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M35_L02:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       jne       short M35_L00
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M35_L00
M35_L03:
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFA06AEF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M35_L01
M35_L04:
       mov       r8,rdx
       mov       rdx,7FFA07029E78
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA06FCF570]
; Total bytes of code 151
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
       jg        near ptr M36_L04
       cmp       eax,esi
       jl        near ptr M36_L04
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M36_L01
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M36_L05
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M36_L06
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M36_L00:
       cmp       ebp,edx
       ja        near ptr M36_L11
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFA06975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       mov       [rbx+18],edx
M36_L01:
       sub       esi,ebp
       mov       edx,[rbx+1C]
       lea       ecx,[rsi+rdx]
       mov       eax,[rbx+18]
       add       ecx,eax
       cmp       ecx,[rbx+20]
       jg        near ptr M36_L07
       cmp       ecx,esi
       jl        near ptr M36_L07
       add       edx,eax
       mov       ecx,edx
       mov       eax,1F40
       cmp       ecx,1F40
       cmovg     ecx,eax
       cmp       esi,ecx
       cmovge    ecx,esi
       add       edx,ecx
       cmp       edx,ecx
       jl        near ptr M36_L08
       cmp       ecx,400
       jge       near ptr M36_L09
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
M36_L02:
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
       je        near ptr M36_L10
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M36_L03:
       cmp       esi,r8d
       ja        near ptr M36_L11
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFA06975818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M36_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFA068B4000
       call      qword ptr [7FFA06B977B0]
       mov       rsi,rax
       call      qword ptr [7FFA07036B68]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA06B9D890]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M36_L05:
       test      ecx,ecx
       jne       short M36_L06
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M36_L00
M36_L06:
       call      qword ptr [7FFA06AE7198]
       int       3
M36_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFA068B4000
       call      qword ptr [7FFA06B977B0]
       mov       rsi,rax
       call      qword ptr [7FFA07036BB0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA06B9D890]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M36_L08:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA07036BC8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M36_L09:
       xor       edx,edx
       call      qword ptr [7FFA06EFE838]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
       jmp       near ptr M36_L02
M36_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M36_L03
M36_L11:
       call      qword ptr [7FFA06D8C780]
       int       3
; Total bytes of code 625
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFA6640CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M37_L01
       cmp       [rax],ecx
       jle       short M37_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M37_L03
M37_L00:
       add       rsp,20
       pop       rbx
       ret
M37_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M37_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M37_L00
M37_L02:
       cmp       [rax+4],edx
       jle       short M37_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M37_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M37_L03
       jmp       short M37_L00
M37_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M38_L00
       cmp       [rdx],rcx
       jne       short M38_L01
M38_L00:
       mov       rax,rdx
       ret
M38_L01:
       jmp       qword ptr [7FFA0697FD08]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       cmp       byte ptr [rbx],0
       je        short M39_L00
       call      qword ptr [7FFA6640CBF8]
       int       3
M39_L00:
       test      rsi,rsi
       je        short M39_L02
       mov       rcx,rsi
       call      qword ptr [7FFA6640CBB8]
       test      eax,eax
       jne       short M39_L01
       mov       rcx,rsi
       call      qword ptr [7FFA6640CBC8]
M39_L01:
       mov       byte ptr [rbx],1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M39_L02:
       xor       ecx,ecx
       call      qword ptr [7FFA664071F0]
       int       3
; Total bytes of code 70
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M40_L00
       mov       rcx,rbx
       call      00007FFA66632C80
       test      eax,eax
       jne       short M40_L01
       add       rsp,20
       pop       rbx
       ret
M40_L00:
       xor       ecx,ecx
       call      qword ptr [7FFA07035968]
       int       3
M40_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFA07036400]
; Total bytes of code 56
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       cmp       qword ptr [rcx+8],0
       jne       short M41_L00
       mov       rax,[rcx+18]
       ret
M41_L00:
       jmp       qword ptr [7FFA06B9FE40]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
; Total bytes of code 18
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
       jl        short M42_L01
       cmp       esi,[rbx+20]
       jg        short M42_L02
       test      esi,esi
       jne       near ptr M42_L03
       cmp       qword ptr [rbx+10],0
       jne       short M42_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M42_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M42_L01:
       mov       ecx,3AD
       mov       rdx,7FFA068B4000
       call      qword ptr [7FFA06B977B0]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFA07035938]
       int       3
M42_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA068B4000
       call      qword ptr [7FFA06B977B0]
       mov       rsi,rax
       call      qword ptr [7FFA07036BB0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA06B9D890]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M42_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,esi
       sub       r8d,ecx
       test      r8d,r8d
       jle       short M42_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA07036D30]
       jmp       near ptr M42_L00
M42_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFA07036D48]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M42_L09
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
       jge       short M42_L07
       cmp       ecx,400
       jge       short M42_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M42_L06
M42_L05:
       xor       edx,edx
       call      qword ptr [7FFA06EFE838]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M42_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFA06AE5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M42_L08
M42_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M42_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M42_L09:
       sub       esi,[rdi+1C]
       mov       [rbx+18],esi
       jmp       near ptr M42_L00
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
       jne       near ptr M43_L11
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M43_L12
       cmp       dword ptr [rbx+20],0
       jl        near ptr M43_L03
       cmp       qword ptr [rbx+10],0
       jne       near ptr M43_L04
       xor       ecx,ecx
       mov       [rbx+18],rcx
M43_L00:
       cmp       qword ptr [rsi+20],0
       jne       short M43_L02
       lea       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M43_L13
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FFA665CCC60
       test      rax,rax
       jne       short M43_L02
M43_L01:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M43_L02:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        near ptr M43_L14
       mov       rsi,[rsi+18]
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFA06FC5500]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M43_L01
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA07036DF0]
       jmp       short M43_L01
M43_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA068B4000
       call      qword ptr [7FFA06B977B0]
       mov       rsi,rax
       call      qword ptr [7FFA07036BB0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA06B9D890]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M43_L04:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M43_L05
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA07036D30]
       jmp       near ptr M43_L00
M43_L05:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA07036D48]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M43_L10
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
       jge       short M43_L08
       cmp       ecx,400
       jge       short M43_L06
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M43_L07
M43_L06:
       xor       edx,edx
       call      qword ptr [7FFA06EFE838]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M43_L07:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFA06AE5050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M43_L09
M43_L08:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M43_L09:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M43_L10:
       mov       ecx,[rdi+1C]
       neg       ecx
       mov       [rbx+18],ecx
       jmp       near ptr M43_L00
M43_L11:
       mov       rdx,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       jne       near ptr M43_L00
M43_L12:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M43_L13:
       call      qword ptr [7FFA07035EA8]
       int       3
M43_L14:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M43_L12
; Total bytes of code 560
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
M45_L00:
       mov       ebp,[rbx+60]
       mov       eax,ebp
       and       eax,[rbx+18]
       mov       r14d,[rdi+8]
       cmp       eax,r14d
       jae       near ptr M45_L05
       mov       r15d,eax
       shl       r15,4
       lea       r13,[rdi+r15+10]
       mov       ecx,[r13+8]
       lea       edx,[rbp+1]
       sub       ecx,edx
       jne       short M45_L02
       lea       rcx,[rbx+60]
       mov       eax,ebp
       lock cmpxchg [rcx],edx
       cmp       eax,ebp
       jne       short M45_L00
       mov       rdx,[rdi+r15+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+1C],0
       jne       short M45_L01
       xor       eax,eax
       mov       [rdi+r15+10],rax
       add       ebp,r14d
       mov       [r13+8],ebp
M45_L01:
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
M45_L02:
       test      ecx,ecx
       jge       short M45_L00
       movzx     ecx,byte ptr [rbx+1D]
       mov       edx,[rbx+0A0]
       mov       eax,edx
       sub       eax,ebp
       test      eax,eax
       jle       short M45_L04
       test      ecx,ecx
       je        short M45_L03
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       edx,ecx
       sub       edx,ebp
       test      edx,edx
       jle       short M45_L04
M45_L03:
       lea       rcx,[rsp+28]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFA07036E68]
       jmp       near ptr M45_L00
M45_L04:
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
M45_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 231
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       xor       eax,eax
       mov       [rbx],rax
       call      qword ptr [7FFA663F5098]
       mov       rcx,[rax]
       imul      edx,edi,0B
       add       edx,esi
       mov       eax,100
       cmp       edx,100
       cmovle    edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FFA66414888]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbx+8],rax
       test      rax,rax
       je        short M46_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M46_L00:
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
M46_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M46_L00
; Total bytes of code 102
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       cmp       byte ptr [rbx+14],0
       jne       short M47_L00
       test      rdx,rdx
       je        short M47_L00
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M47_L01
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        short M47_L00
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFA664088E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M47_L00:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M47_L01:
       call      qword ptr [7FFA6640A278]
       int       3
; Total bytes of code 109
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
       jne       short M48_L01
M48_L00:
       movzx     edi,si
       lea       rcx,[rbx+18]
       mov       eax,[rbx+10]
       mov       edx,[rcx+8]
       cmp       eax,edx
       ja        short M48_L03
       mov       rcx,[rcx]
       mov       r8d,eax
       lea       rbp,[rcx+r8*2]
       sub       edx,eax
       je        short M48_L02
       mov       [rbp],di
       inc       dword ptr [rbx+10]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M48_L01:
       movzx     edx,si
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       xor       r8d,r8d
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M48_L02:
       mov       rcx,rbx
       call      qword ptr [7FFA6640FFD8]
       jmp       short M48_L00
M48_L03:
       call      qword ptr [7FFA6640A278]
       int       3
; Total bytes of code 111
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       lea       rsi,[rbx+18]
       mov       rcx,rsi
       mov       eax,[rbx+10]
       cmp       eax,[rcx+8]
       ja        short M49_L01
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       [rsp+30],eax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFA66406B10]; Precode of System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rbp,[rbx+8]
       xor       eax,eax
       mov       [rbx+8],rax
       mov       [rsi],rax
       mov       [rsi+8],rax
       mov       [rbx+10],eax
       test      rbp,rbp
       je        short M49_L00
       call      qword ptr [7FFA663F5098]
       mov       rcx,[rax]
       mov       rdx,rbp
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFA66414890]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M49_L00:
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M49_L01:
       call      qword ptr [7FFA6640A278]
       int       3
; Total bytes of code 126
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M50_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M50_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M50_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA664191B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M50_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M50_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M50_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M50_L03:
       cmp       ecx,8
       ja        short M50_L04
       mov       ecx,ecx
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M50_L00]
       add       rdx,r8
       jmp       rdx
M50_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA6640FC50]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFA664191A0]
       jmp       short M50_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA664191A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M50_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFA663F6838]
       mov       rcx,rax
       call      qword ptr [7FFA663FDE88]
       mov       rcx,rax
       call      qword ptr [7FFA6641EFF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA664191B8]
       jmp       near ptr M50_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M50_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA664191B8]
       jmp       near ptr M50_L01
M50_L05:
       mov       rcx,rbx
       call      qword ptr [7FFA664191C8]
       jmp       near ptr M50_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFA664191B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M50_L01
; Total bytes of code 269
```

