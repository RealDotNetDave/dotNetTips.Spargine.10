## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataReaderExtensionsBenchmark.ToCsvWithHeader()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vmovaps   [rsp+70],xmm6
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+1A8]
       mov       rsi,rbx
       cmp       [rsi],sil
       mov       rax,offset MT_System.Data.DataTableReader
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       byte ptr [rdi+38],1
       mov       qword ptr [rdi+30],0FFFFFFFFFFFFFFFF
       mov       byte ptr [rdi+39],1
       mov       rcx,offset MT_System.Data.DataTable[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+30],ecx
       mov       byte ptr [rdi+3A],0
       mov       byte ptr [rdi+3C],0
       mov       rcx,[rdi+8]
       mov       edx,[rdi+30]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L73
       lea       rcx,[rdi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+28]
       mov       rcx,[rcx+10]
       mov       ecx,[rcx+28]
       dec       ecx
       test      ecx,ecx
       setg      cl
       mov       [rdi+39],cl
       cmp       byte ptr [rdi+3E],0
       je        short M00_L00
       mov       byte ptr [rdi+3E],0
M00_L00:
       mov       rcx,offset MT_System.Data.DataTableReaderListener
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       cmp       qword ptr [rbx+8],0
       je        short M00_L01
       mov       rcx,rbx
       call      qword ptr [7FFB0D2BC2E8]; System.Data.DataTableReaderListener.UnSubscribeEvents()
M00_L01:
       mov       rcx,offset MT_System.WeakReference
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rdi
       xor       edx,edx
       call      00007FFB6C7E5950
       test      rax,rax
       je        near ptr M00_L71
M00_L02:
       mov       [rsi+8],rax
       cmp       qword ptr [7FFB0CADB020],0
       jne       near ptr M00_L72
M00_L03:
       xor       edx,edx
M00_L04:
       test      rdx,rdx
       je        short M00_L05
       lea       rcx,[rsi+8]
       call      qword ptr [7FFB0D365158]
M00_L05:
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rdi+18]
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L06
       mov       rcx,rbx
       call      qword ptr [7FFB0D2B6FB8]; System.Data.DataTableReaderListener.SubscribeEvents()
M00_L06:
       lea       rcx,[rdi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-68],rdi
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,2017BC00230
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-70],rbx
       cmp       byte ptr [rdi+38],0
       je        near ptr M00_L61
       cmp       byte ptr [rdi+3E],0
       jne       near ptr M00_L62
       cmp       byte ptr [rdi+3C],0
       jne       near ptr M00_L63
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-44],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Boolean[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-78],rax
       xor       edi,edi
       cmp       dword ptr [rbp-44],0
       jle       short M00_L08
       mov       rbx,[rbp-78]
       mov       ecx,[rbx+8]
M00_L07:
       mov       rcx,[rbp-68]
       mov       edx,edi
       call      qword ptr [7FFB0D2E0168]; System.Data.DataTableReader.GetFieldType(Int32)
       mov       rcx,242109C0020
       cmp       rax,rcx
       sete      cl
       movzx     ecx,cl
       mov       [rbx+rdi+10],cl
       add       edi,1
       jo        near ptr M00_L69
       mov       esi,[rbp-44]
       cmp       edi,esi
       jl        short M00_L07
M00_L08:
       mov       esi,[rbp-44]
       mov       rbx,[rbp-78]
       mov       rcx,2017BC02248
       mov       rcx,[rcx]
       mov       [rbp-90],rcx
       mov       rdi,[rbp-90]
       mov       rcx,[rdi+20]
       mov       [rbp-50],rcx
       cmp       qword ptr [rbp-50],0
       je        near ptr M00_L64
       lea       rcx,[rdi+20]
       mov       r8,[rbp-50]
       test      rcx,rcx
       je        near ptr M00_L68
       xor       edx,edx
       call      00007FFB6C7E21C0
       cmp       rax,[rbp-50]
       jne       near ptr M00_L64
M00_L09:
       mov       rdx,[rbp-50]
M00_L10:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-88],rdx
       xor       edi,edi
       jmp       near ptr M00_L15
M00_L11:
       mov       r8d,r14d
       add       r8,r8
       mov       rdx,r10
       call      qword ptr [7FFB0CB95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L12:
       add       r14d,r15d
       mov       rdx,[rbp-88]
       mov       [rdx+18],r14d
M00_L13:
       mov       rcx,[rbp-68]
       cmp       byte ptr [rcx+38],0
       je        near ptr M00_L22
       cmp       byte ptr [rcx+3E],0
       jne       near ptr M00_L20
       cmp       byte ptr [rcx+3C],0
       jne       near ptr M00_L21
       mov       rax,[rcx+18]
       mov       rax,[rax+30]
       mov       rax,[rax+10]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       sub       eax,1
       jo        near ptr M00_L25
       cmp       edi,eax
       jge       short M00_L14
       mov       rcx,[rbp-88]
       mov       edx,[rcx+18]
       mov       eax,edx
       mov       r8,[rcx+8]
       cmp       [r8+8],eax
       jbe       near ptr M00_L19
       mov       word ptr [r8+rax*2+10],2C
       inc       edx
       mov       [rcx+18],edx
M00_L14:
       add       edi,1
       jo        near ptr M00_L25
M00_L15:
       mov       rcx,[rbp-68]
       cmp       byte ptr [rcx+38],0
       je        near ptr M00_L22
       cmp       byte ptr [rcx+3E],0
       jne       near ptr M00_L23
       cmp       byte ptr [rcx+3C],0
       jne       near ptr M00_L24
       mov       rax,[rcx+18]
       mov       rax,[rax+30]
       mov       rax,[rax+10]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       cmp       edi,eax
       jge       near ptr M00_L16
       mov       rcx,[rbp-68]
       mov       edx,edi
       call      qword ptr [7FFB0D2E0170]; System.Data.DataTableReader.GetName(Int32)
       test      rax,rax
       je        near ptr M00_L13
       mov       rcx,[rbp-68]
       mov       edx,edi
       call      qword ptr [7FFB0D2E0170]; System.Data.DataTableReader.GetName(Int32)
       mov       rdx,[rbp-88]
       cmp       [rdx],dl
       test      rax,rax
       je        near ptr M00_L13
       lea       r10,[rax+0C]
       mov       r14d,[rax+8]
       test      r14d,r14d
       je        near ptr M00_L13
       mov       r8,[rdx+8]
       mov       r15d,[rdx+18]
       lea       ecx,[r15+r14]
       cmp       ecx,[r8+8]
       ja        near ptr M00_L18
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       r14d,2
       jg        near ptr M00_L11
       movzx     r8d,word ptr [r10]
       mov       [rcx],r8w
       cmp       r14d,2
       jne       near ptr M00_L12
       movzx     r10d,word ptr [r10+2]
       mov       [rcx+2],r10w
       jmp       near ptr M00_L12
M00_L16:
       mov       rcx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0CD82200]; System.Text.StringBuilder.ToString()
       mov       rcx,[rbp-70]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       short M00_L17
       lea       r10d,[r8+1]
       mov       [rcx+10],r10d
       mov       r8d,r8d
       lea       rcx,[rdx+r8*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L26
M00_L17:
       mov       rdx,rax
       call      qword ptr [7FFB0CD0E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L26
M00_L18:
       mov       rdx,[rbp-88]
       mov       rcx,rdx
       mov       rdx,r10
       mov       r8d,r14d
       call      qword ptr [7FFB0CD0F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L13
M00_L19:
       mov       edx,2C
       call      qword ptr [7FFB0CD0F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L14
M00_L20:
       mov       rax,[rcx+18]
       mov       rcx,[rax+70]
       call      qword ptr [7FFB0D2BFE58]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       mov       rax,[rcx+18]
       mov       rcx,[rax+70]
       call      qword ptr [7FFB0D2BFE70]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       ecx,0C8E0
       mov       rdx,7FFB0CF80D50
       call      qword ptr [7FFB0CDB7798]
       mov       rcx,rax
       call      qword ptr [7FFB0D2BFEE8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       rax,[rcx+18]
       mov       rcx,[rax+70]
       call      qword ptr [7FFB0D2BFE58]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L24:
       mov       rax,[rcx+18]
       mov       rcx,[rax+70]
       call      qword ptr [7FFB0D2BFE70]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L26:
       call      M00_L74
       jmp       short M00_L28
M00_L27:
       mov       rcx,[rbp-80]
       xor       edx,edx
       call      qword ptr [7FFB0D245E18]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-80]
       call      qword ptr [7FFB0D245E30]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
M00_L28:
       mov       rcx,[rbp-68]
       call      qword ptr [7FFB0D2E0278]; System.Data.DataTableReader.Read()
       test      eax,eax
       je        near ptr M00_L60
       mov       rbx,[rbp-90]
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       rcx,[rbx+20]
       mov       [rbp-58],rcx
       cmp       qword ptr [rbp-58],0
       je        near ptr M00_L66
       lea       rcx,[rbx+20]
       mov       r8,[rbp-58]
       test      rcx,rcx
       je        near ptr M00_L68
       xor       edx,edx
       call      00007FFB6C7E21C0
       cmp       rax,[rbp-58]
       jne       near ptr M00_L66
M00_L29:
       mov       rbx,[rbp-58]
M00_L30:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-80],rbx
       xor       ebx,ebx
       mov       esi,[rbp-44]
       cmp       ebx,esi
       jl        near ptr M00_L45
M00_L31:
       mov       rcx,[rbp-80]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0CD82200]; System.Text.StringBuilder.ToString()
       mov       rdx,rax
       mov       rcx,[rbp-70]
       call      qword ptr [7FFB0CC83598]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       near ptr M00_L27
M00_L32:
       add       rax,8
       vmovsd    xmm6,qword ptr [rax]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L48
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L48
M00_L33:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L34
       mov       rcx,2017BC00110
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L34
       mov       rcx,2017BC000F0
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L49
M00_L34:
       cmp       byte ptr [rcx+61],0
       jne       near ptr M00_L50
       mov       r8,[rcx+18]
       test      r8,r8
       je        near ptr M00_L50
M00_L35:
       vmovaps   xmm0,xmm6
       xor       edx,edx
       call      qword ptr [7FFB0D2B4E10]; System.Number.FormatFloat[[System.Double, System.Private.CoreLib]](Double, System.String, System.Globalization.NumberFormatInfo)
       jmp       near ptr M00_L46
M00_L36:
       test      rdi,rdi
       je        near ptr M00_L47
       xor       ecx,ecx
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       short M00_L38
M00_L37:
       movzx     edx,word ptr [rdi+rcx*2+0C]
       cmp       edx,22
       je        near ptr M00_L51
       cmp       edx,2C
       je        near ptr M00_L51
       add       ecx,1
       jo        near ptr M00_L58
       cmp       r14d,ecx
       jg        short M00_L37
M00_L38:
       mov       rcx,[rbp-80]
       cmp       [rcx],cl
       lea       rdx,[rdi+0C]
       test      r14d,r14d
       je        short M00_L43
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+8]
       mov       rax,[rbp-80]
       mov       eax,[rax+18]
       lea       edi,[rax+r14]
       cmp       edi,[rcx+8]
       ja        near ptr M00_L52
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r14d,2
       jle       short M00_L40
       mov       eax,r14d
       lea       r8,[rax+rax]
       call      qword ptr [7FFB0CB95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L39:
       mov       rcx,[rbp-80]
       mov       [rcx+18],edi
       jmp       short M00_L43
M00_L40:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r14d,2
       jne       short M00_L39
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M00_L39
M00_L41:
       movzx     r10d,word ptr [rdx]
       mov       [rcx],r10w
       cmp       eax,2
       jne       short M00_L42
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
M00_L42:
       mov       rcx,[rbp-80]
       mov       [rcx+18],edi
M00_L43:
       mov       ecx,esi
       sub       ecx,1
       jo        near ptr M00_L58
       cmp       ebx,ecx
       jge       short M00_L44
       mov       rcx,[rbp-80]
       mov       edx,2C
       cmp       [rcx],ecx
       call      qword ptr [7FFB0CD0F180]; System.Text.StringBuilder.Append(Char)
M00_L44:
       add       ebx,1
       jo        near ptr M00_L58
       cmp       ebx,esi
       jge       near ptr M00_L31
M00_L45:
       mov       rcx,[rbp-68]
       mov       edx,ebx
       call      qword ptr [7FFB0D2E0260]; System.Data.DataTableReader.IsDBNull(Int32)
       test      eax,eax
       jne       short M00_L43
       mov       rcx,[rbp-68]
       mov       edx,ebx
       call      qword ptr [7FFB0D2E0240]; System.Data.DataTableReader.GetValue(Int32)
       mov       rdx,[rax]
       mov       rcx,offset MT_System.Double
       cmp       rdx,rcx
       je        near ptr M00_L32
       mov       rcx,rax
       mov       rax,[rdx+40]
       call      qword ptr [rax+8]
M00_L46:
       mov       rdi,rax
       mov       r8,[rbp-78]
       cmp       ebx,[r8+8]
       jae       near ptr M00_L57
       cmp       byte ptr [r8+rbx+10],0
       jne       near ptr M00_L36
M00_L47:
       mov       rcx,[rbp-80]
       cmp       [rcx],cl
       test      rax,rax
       je        near ptr M00_L43
       lea       rdx,[rax+0C]
       mov       r14d,[rax+8]
       mov       eax,r14d
       test      eax,eax
       je        near ptr M00_L43
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+8]
       mov       r10,[rbp-80]
       mov       r10d,[r10+18]
       lea       edi,[r10+rax]
       cmp       edi,[rcx+8]
       ja        near ptr M00_L59
       movsxd    r10,r10d
       lea       rcx,[rcx+r10*2+10]
       cmp       eax,2
       jle       near ptr M00_L41
       mov       r8d,eax
       call      qword ptr [7FFB0D2B4768]; System.Buffer.Memmove[[System.Char, System.Private.CoreLib]](Char ByRef, Char ByRef, UIntPtr)
       jmp       near ptr M00_L42
M00_L48:
       mov       ecx,2
       call      qword ptr [7FFB0D2BF1F8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L33
M00_L49:
       call      qword ptr [7FFB0CDB5E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L34
M00_L50:
       mov       rdx,242109C6A68
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       rdx,rax
       mov       rcx,offset MT_System.Globalization.NumberFormatInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       jmp       near ptr M00_L35
M00_L51:
       mov       rcx,[rbp-80]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFB0CD0F180]; System.Text.StringBuilder.Append(Char)
       xor       r15d,r15d
       jmp       short M00_L56
M00_L52:
       mov       rcx,[rbp-80]
       mov       r8d,r14d
       call      qword ptr [7FFB0CD0F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L43
M00_L53:
       cmp       r15d,r14d
       jae       short M00_L57
       movzx     edx,word ptr [rdi+r15*2+0C]
       cmp       edx,22
       jne       short M00_L54
       mov       rcx,[rbp-80]
       mov       rdx,242109D1988
       cmp       [rcx],ecx
       call      qword ptr [7FFB0CD0F228]; System.Text.StringBuilder.Append(System.String)
       jmp       short M00_L55
M00_L54:
       mov       rcx,[rbp-80]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0CD0F180]; System.Text.StringBuilder.Append(Char)
M00_L55:
       add       r15d,1
       jo        short M00_L58
M00_L56:
       cmp       r14d,r15d
       jg        short M00_L53
       mov       rcx,[rbp-80]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFB0CD0F180]; System.Text.StringBuilder.Append(Char)
       jmp       near ptr M00_L43
M00_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L59:
       mov       rcx,[rbp-80]
       mov       r8d,eax
       call      qword ptr [7FFB0CD0F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L43
M00_L60:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,[rbp-70]
       call      qword ptr [7FFB0D036BE0]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       mov       [rbp-60],rsi
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+90]
       lea       r8,[rbp-60]
       mov       rdx,7FFB0D2E8A40
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D2BC3F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       jmp       near ptr M00_L70
M00_L61:
       mov       ecx,0C8E0
       mov       rdx,7FFB0CF80D50
       call      qword ptr [7FFB0CDB7798]
       mov       rcx,rax
       call      qword ptr [7FFB0D2BFEE8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L62:
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2BFE58]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2BFE70]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L64:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D245CC8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L65
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M00_L09
M00_L65:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L66:
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D245CC8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L67
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M00_L29
M00_L67:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M00_L30
M00_L68:
       call      qword ptr [7FFB0D2BFAE0]
       int       3
M00_L69:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L70:
       mov       rcx,[rbp-68]
       call      qword ptr [7FFB0D2E0130]; System.Data.DataTableReader.Close()
       nop
       vmovaps   xmm6,[rsp+70]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L71:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFB0D365128]
       jmp       near ptr M00_L02
M00_L72:
       mov       rax,[7FFB0CADB020]
       mov       rcx,rdi
       call      rax
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,rdi
       call      qword ptr [7FFB0D365140]
       mov       rdx,rax
       jmp       near ptr M00_L04
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       mov       rcx,[rbp-80]
       cmp       [rcx],cl
       mov       rcx,[rbp-80]
       xor       edx,edx
       call      qword ptr [7FFB0D245E18]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,2017BC02248
       mov       rcx,[rcx]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-90]
       mov       rdx,[rbp-80]
       call      qword ptr [7FFB0D245E30]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       nop
       add       rsp,28
       ret
M00_L74:
       sub       rsp,28
       mov       rcx,[rbp-88]
       cmp       dword ptr [rcx+20],0
       jge       short M00_L75
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFB0CAD4000
       call      qword ptr [7FFB0CDB7798]
       mov       rsi,rax
       call      qword ptr [7FFB0D2BFD98]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0CDBDAD0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L75:
       cmp       qword ptr [rcx+10],0
       jne       short M00_L76
       xor       edx,edx
       mov       [rcx+18],rdx
       jmp       near ptr M00_L83
M00_L76:
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       mov       r8d,edx
       neg       r8d
       test      r8d,r8d
       jle       short M00_L77
       xor       edx,edx
       call      qword ptr [7FFB0D364048]
       mov       rcx,[rbp-88]
       jmp       near ptr M00_L83
M00_L77:
       xor       edx,edx
       call      qword ptr [7FFB0D364060]
       mov       rbx,rax
       mov       rcx,[rbp-88]
       cmp       rbx,rcx
       je        near ptr M00_L82
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
       jge       short M00_L80
       cmp       r8d,400
       jge       short M00_L78
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L79
M00_L78:
       mov       ecx,r8d
       xor       edx,edx
       call      qword ptr [7FFB0D1AF450]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L79:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFB0CD05050]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbp-88]
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L81
M00_L80:
       mov       rdx,[rbx+8]
       mov       rcx,[rbp-88]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L81:
       mov       rdx,[rbx+10]
       mov       rcx,[rbp-88]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+1C]
       mov       rax,[rbp-88]
       mov       [rax+1C],ecx
       mov       rcx,rax
M00_L82:
       mov       r8d,[rbx+1C]
       neg       r8d
       mov       [rcx+18],r8d
M00_L83:
       mov       rdx,2017BC02248
       mov       rdx,[rdx]
       mov       [rbp-90],rdx
       mov       rbx,[rbp-90]
       mov       rax,[rbx+10]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L85
M00_L84:
       add       rsp,28
       ret
M00_L85:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L87
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L86
       call      qword ptr [7FFB0D2BFAE0]
       int       3
M00_L86:
       mov       rdx,[rbp-88]
       xor       r8d,r8d
       call      00007FFB6C7E21C0
       test      rax,rax
       je        short M00_L84
M00_L87:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L88
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D364468]
       test      eax,eax
       jne       short M00_L84
       mov       rcx,rbx
       mov       rdx,[rbp-88]
       call      qword ptr [7FFB0D364480]
       jmp       short M00_L84
M00_L88:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M00_L84
       sub       rsp,28
       mov       rcx,[rbp-68]
       call      qword ptr [7FFB0D2E0130]; System.Data.DataTableReader.Close()
       nop
       add       rsp,28
       ret
; Total bytes of code 3284
```
```assembly
; System.Data.DataTableReaderListener.UnSubscribeEvents()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       cmp       qword ptr [rbx+8],0
       je        near ptr M01_L15
       cmp       byte ptr [rbx+18],0
       je        near ptr M01_L15
       mov       rsi,[rbx+8]
       mov       rcx,offset MT_System.ComponentModel.CollectionChangeEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+30]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D2B2FD0
       mov       [rdi+18],rcx
       mov       rbp,[rsi+40]
M01_L00:
       test      rbp,rbp
       je        near ptr M01_L16
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FFB0CBCAAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
M01_L01:
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       rcx,offset MT_System.ComponentModel.CollectionChangeEventHandler
       cmp       [rdx],rcx
       jne       near ptr M01_L17
M01_L02:
       lea       rcx,[rsi+40]
       test      rcx,rcx
       je        near ptr M01_L20
       mov       r8,rbp
       call      00007FFB6C7E21C0
       cmp       rax,rbp
       mov       rbp,rax
       jne       short M01_L00
       mov       rsi,[rbx+8]
       mov       rcx,offset MT_System.ComponentModel.CollectionChangeEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+30]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D2B2FD0
       mov       [rdi+18],rcx
       mov       rbp,[rsi+30]
M01_L03:
       test      rbp,rbp
       je        near ptr M01_L18
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FFB0CBCAAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
M01_L04:
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       rcx,offset MT_System.ComponentModel.CollectionChangeEventHandler
       cmp       [rdx],rcx
       jne       near ptr M01_L19
M01_L05:
       lea       rcx,[rsi+30]
       test      rcx,rcx
       je        near ptr M01_L20
       mov       r8,rbp
       call      00007FFB6C7E21C0
       cmp       rax,rbp
       mov       rbp,rax
       jne       short M01_L03
       mov       rcx,offset MT_System.Data.DataRowChangeEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+8]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D2B3048
       mov       [rsi+18],rcx
       mov       rcx,2017BC01F10
       mov       rbp,[rcx]
       mov       r14,rbp
       mov       r15d,[rdi+1C0]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M01_L21
M01_L06:
       mov       rcx,[rdi+120]
       test      rcx,rcx
       je        near ptr M01_L22
       mov       rdx,rsi
       call      qword ptr [7FFB0CBCAAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
M01_L07:
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L08
       mov       rcx,offset MT_System.Data.DataRowChangeEventHandler
       cmp       [rdx],rcx
       jne       near ptr M01_L23
M01_L08:
       lea       rcx,[rdi+120]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataRowChangeEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+8]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D2B3048
       mov       [rsi+18],rcx
       mov       r14,rbp
       mov       r15d,[rdi+1C0]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M01_L24
M01_L09:
       mov       rcx,[rdi+138]
       test      rcx,rcx
       je        near ptr M01_L25
       mov       rdx,rsi
       call      qword ptr [7FFB0CBCAAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
M01_L10:
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L11
       mov       rcx,offset MT_System.Data.DataRowChangeEventHandler
       cmp       [rdx],rcx
       jne       near ptr M01_L26
M01_L11:
       lea       rcx,[rdi+138]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataTableClearEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+8]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D2B3090
       mov       [rsi+18],rcx
       mov       r14,rbp
       mov       r15d,[rdi+1C0]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M01_L27
M01_L12:
       mov       rcx,[rdi+158]
       test      rcx,rcx
       je        near ptr M01_L28
       mov       rdx,rsi
       call      qword ptr [7FFB0CBCAAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
M01_L13:
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L14
       mov       rcx,offset MT_System.Data.DataTableClearEventHandler
       cmp       [rdx],rcx
       jne       near ptr M01_L29
M01_L14:
       lea       rcx,[rdi+158]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+18],0
M01_L15:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L16:
       xor       eax,eax
       jmp       near ptr M01_L01
M01_L17:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L18:
       xor       eax,eax
       jmp       near ptr M01_L04
M01_L19:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L20:
       call      qword ptr [7FFB0D2BFAE0]
       int       3
M01_L21:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],r15d
       mov       [rsp+40],rax
       lea       r8,[rsp+40]
       mov       [rsp+20],r8
       mov       dword ptr [rsp+28],1
       lea       r8,[rsp+20]
       xor       ecx,ecx
       mov       rdx,242109D2640
       call      qword ptr [7FFB0D2BFF90]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFB0D2BC858]
       jmp       near ptr M01_L06
M01_L22:
       xor       eax,eax
       jmp       near ptr M01_L07
M01_L23:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L24:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],r15d
       mov       [rsp+38],rax
       lea       r8,[rsp+38]
       mov       [rsp+20],r8
       mov       dword ptr [rsp+28],1
       lea       r8,[rsp+20]
       xor       ecx,ecx
       mov       rdx,242109D26A8
       call      qword ptr [7FFB0D2BFF90]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFB0D2BC858]
       jmp       near ptr M01_L09
M01_L25:
       xor       eax,eax
       jmp       near ptr M01_L10
M01_L26:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L27:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],r15d
       mov       [rsp+30],rax
       lea       r8,[rsp+30]
       mov       [rsp+20],r8
       mov       dword ptr [rsp+28],1
       lea       r8,[rsp+20]
       xor       ecx,ecx
       mov       rdx,242109D2710
       call      qword ptr [7FFB0D2BFF90]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFB0D2BC858]
       jmp       near ptr M01_L12
M01_L28:
       xor       eax,eax
       jmp       near ptr M01_L13
M01_L29:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 1102
```
```assembly
; System.Data.DataTableReaderListener.SubscribeEvents()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M02_L15
       cmp       byte ptr [rbx+18],0
       jne       near ptr M02_L15
       mov       rcx,offset MT_System.ComponentModel.CollectionChangeEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+30]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D2B2FD0
       mov       [rdi+18],rcx
       mov       rbp,[rsi+40]
M02_L00:
       test      rbp,rbp
       jne       near ptr M02_L16
       mov       rdx,rdi
M02_L01:
       mov       r8,rdx
       test      r8,r8
       je        short M02_L02
       mov       rcx,offset MT_System.ComponentModel.CollectionChangeEventHandler
       cmp       [r8],rcx
       jne       near ptr M02_L17
M02_L02:
       mov       rdx,r8
       lea       rcx,[rsi+40]
       test      rcx,rcx
       je        near ptr M02_L20
       mov       r8,rbp
       call      00007FFB6C7E21C0
       cmp       rax,rbp
       mov       rbp,rax
       jne       short M02_L00
       mov       rsi,[rbx+8]
       mov       rcx,offset MT_System.ComponentModel.CollectionChangeEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+30]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D2B2FD0
       mov       [rdi+18],rcx
       mov       rbp,[rsi+30]
M02_L03:
       test      rbp,rbp
       jne       near ptr M02_L18
       mov       rdx,rdi
M02_L04:
       mov       r8,rdx
       test      r8,r8
       je        short M02_L05
       mov       rcx,offset MT_System.ComponentModel.CollectionChangeEventHandler
       cmp       [r8],rcx
       jne       near ptr M02_L19
M02_L05:
       mov       rdx,r8
       lea       rcx,[rsi+30]
       test      rcx,rcx
       je        near ptr M02_L20
       mov       r8,rbp
       call      00007FFB6C7E21C0
       cmp       rax,rbp
       mov       rbp,rax
       jne       short M02_L03
       mov       rcx,offset MT_System.Data.DataRowChangeEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+8]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D2B3048
       mov       [rsi+18],rcx
       mov       rcx,2017BC01F10
       mov       rbp,[rcx]
       mov       r14,rbp
       mov       r15d,[rdi+1C0]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M02_L21
M02_L06:
       mov       rcx,[rdi+120]
       test      rcx,rcx
       jne       near ptr M02_L22
       mov       rdx,rsi
M02_L07:
       mov       rax,rdx
       test      rax,rax
       je        short M02_L08
       mov       rcx,offset MT_System.Data.DataRowChangeEventHandler
       cmp       [rax],rcx
       jne       near ptr M02_L23
M02_L08:
       lea       rcx,[rdi+120]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataRowChangeEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+8]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D2B3048
       mov       [rsi+18],rcx
       mov       r14,rbp
       mov       r15d,[rdi+1C0]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M02_L24
M02_L09:
       mov       rcx,[rdi+138]
       test      rcx,rcx
       jne       near ptr M02_L25
       mov       rdx,rsi
M02_L10:
       mov       rax,rdx
       test      rax,rax
       je        short M02_L11
       mov       rcx,offset MT_System.Data.DataRowChangeEventHandler
       cmp       [rax],rcx
       jne       near ptr M02_L26
M02_L11:
       lea       rcx,[rdi+138]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataTableClearEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+8]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D2B3090
       mov       [rsi+18],rcx
       mov       r14,rbp
       mov       r15d,[rdi+1C0]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M02_L27
M02_L12:
       mov       rcx,[rdi+158]
       test      rcx,rcx
       jne       near ptr M02_L28
       mov       rdx,rsi
M02_L13:
       mov       rax,rdx
       test      rax,rax
       je        short M02_L14
       mov       rcx,offset MT_System.Data.DataTableClearEventHandler
       cmp       [rax],rcx
       jne       near ptr M02_L29
M02_L14:
       lea       rcx,[rdi+158]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+18],1
M02_L15:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L16:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FFB0CBCAAE8]
       mov       rdx,rax
       jmp       near ptr M02_L01
M02_L17:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L18:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FFB0CBCAAE8]
       mov       rdx,rax
       jmp       near ptr M02_L04
M02_L19:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L20:
       call      qword ptr [7FFB0D2BFAE0]
       int       3
M02_L21:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],r15d
       mov       [rsp+40],rax
       lea       r8,[rsp+40]
       mov       [rsp+20],r8
       mov       dword ptr [rsp+28],1
       lea       r8,[rsp+20]
       xor       ecx,ecx
       mov       rdx,242109D14D8
       call      qword ptr [7FFB0D2BFF90]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFB0D2BC858]
       jmp       near ptr M02_L06
M02_L22:
       mov       rdx,rsi
       call      qword ptr [7FFB0CBCAAE8]
       mov       rdx,rax
       jmp       near ptr M02_L07
M02_L23:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L24:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],r15d
       mov       [rsp+38],rax
       lea       r8,[rsp+38]
       mov       [rsp+20],r8
       mov       dword ptr [rsp+28],1
       lea       r8,[rsp+20]
       xor       ecx,ecx
       mov       rdx,242109D1538
       call      qword ptr [7FFB0D2BFF90]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFB0D2BC858]
       jmp       near ptr M02_L09
M02_L25:
       mov       rdx,rsi
       call      qword ptr [7FFB0CBCAAE8]
       mov       rdx,rax
       jmp       near ptr M02_L10
M02_L26:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L27:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],r15d
       mov       [rsp+30],rax
       lea       r8,[rsp+30]
       mov       [rsp+20],r8
       mov       dword ptr [rsp+28],1
       lea       r8,[rsp+20]
       xor       ecx,ecx
       mov       rdx,242109D1598
       call      qword ptr [7FFB0D2BFF90]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFB0D2BC858]
       jmp       near ptr M02_L12
M02_L28:
       mov       rdx,rsi
       call      qword ptr [7FFB0CBCAAE8]
       mov       rdx,rax
       jmp       near ptr M02_L13
M02_L29:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 1120
```
```assembly
; System.Data.DataTableReader.GetFieldType(Int32)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       cmp       byte ptr [rcx+38],0
       je        short M03_L00
       cmp       byte ptr [rcx+3E],0
       jne       short M03_L01
       cmp       byte ptr [rcx+3C],0
       jne       short M03_L02
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D247E70]; System.Data.DataColumnCollection.get_Item(Int32)
       mov       rax,[rax+28]
       add       rsp,20
       pop       rbp
       ret
M03_L00:
       mov       ecx,0CA7E
       mov       rdx,7FFB0CF80D50
       call      qword ptr [7FFB0CDB7798]
       mov       rcx,rax
       call      qword ptr [7FFB0D2BFEE8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L01:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2BFE58]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L02:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2BFE70]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FFB0D364000]
       mov       ecx,846B
       mov       rdx,7FFB0CF80D50
       call      qword ptr [7FFB0CDB7798]
       mov       rcx,rax
       call      qword ptr [7FFB0D364018]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 188
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
       ja        short M04_L01
       test      r8b,18
       jne       short M04_L00
       test      r8b,4
       je        near ptr M04_L09
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M04_L04
M04_L00:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M04_L04
M04_L01:
       cmp       r8,40
       ja        short M04_L05
M04_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M04_L03
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M04_L08
M04_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M04_L04:
       vzeroupper
       ret
M04_L05:
       cmp       r8,800
       ja        near ptr M04_L12
       cmp       r8,100
       jae       short M04_L10
M04_L06:
       mov       r9,r8
       shr       r9,6
M04_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M04_L07
       and       r8,3F
       cmp       r8,10
       ja        short M04_L02
       jmp       short M04_L03
M04_L08:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L03
M04_L09:
       test      r8,r8
       je        short M04_L04
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L04
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M04_L04
M04_L10:
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
       jmp       near ptr M04_L06
M04_L11:
       cmp       rcx,rdx
       jne       short M04_L12
       cmp       [rdx],dl
       jmp       near ptr M04_L04
M04_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFB0CB966E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 325
```
```assembly
; System.Data.DataTableReader.GetName(Int32)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       cmp       byte ptr [rcx+38],0
       je        short M05_L00
       cmp       byte ptr [rcx+3E],0
       jne       short M05_L01
       cmp       byte ptr [rcx+3C],0
       jne       short M05_L02
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D247E70]; System.Data.DataColumnCollection.get_Item(Int32)
       mov       rax,[rax+20]
       add       rsp,20
       pop       rbp
       ret
M05_L00:
       mov       ecx,0CAF0
       mov       rdx,7FFB0CF80D50
       call      qword ptr [7FFB0CDB7798]
       mov       rcx,rax
       call      qword ptr [7FFB0D2BFEE8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M05_L01:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2BFE58]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M05_L02:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2BFE70]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FFB0D364000]
       mov       ecx,846B
       mov       rdx,7FFB0CF80D50
       call      qword ptr [7FFB0CDB7798]
       mov       rcx,rax
       call      qword ptr [7FFB0D364018]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 188
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M06_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB6C8352E0
       mov       rsi,rax
M06_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M06_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M06_L03
       cmp       [rdx+8],r8d
       jb        short M06_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFB0CB95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M06_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rax,242109C0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFB0CAD4000
       call      qword ptr [7FFB0CDB7798]
       mov       rbx,rax
       call      qword ptr [7FFB0D2BFAF8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0CDBDAD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
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
       jne       short M07_L01
       mov       r14d,4
M07_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M07_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB0D1A6940]
       int       3
M07_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M07_L00
M07_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M07_L08
       test      r14d,r14d
       jg        short M07_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M07_L04
M07_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L08
M07_L04:
       mov       rdx,7FFB0D3267D8
       call      qword ptr [7FFB0CB9C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M07_L03
M07_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+58]
       test      rax,rax
       je        short M07_L09
       mov       rcx,rax
M07_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M07_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFB0CD05050]; System.Array.Copy(System.Array, System.Array, Int32)
M07_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L08:
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
M07_L09:
       mov       rdx,7FFB0D2F4338
       call      qword ptr [7FFB0CB9C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M07_L06
; Total bytes of code 303
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
       call      qword ptr [7FFB0CB95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jl        short M08_L02
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFB0D1AF450]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
       jmp       short M08_L03
M08_L02:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
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
       call      qword ptr [7FFB0CB95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFB0CAD4000
       call      qword ptr [7FFB0CDB7798]
       mov       rsi,rax
       call      qword ptr [7FFB0D2BFD80]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0CDBDAD0]
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
       call      qword ptr [7FFB0CD07198]
       int       3
M08_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFB0CAD4000
       call      qword ptr [7FFB0CDB7798]
       mov       rsi,rax
       call      qword ptr [7FFB0D2BFD98]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0CDBDAD0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0D2BFDB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M08_L04
M08_L11:
       call      qword ptr [7FFB0D03D3E0]
       int       3
; Total bytes of code 621
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
       call      qword ptr [7FFB054137D8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M09_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L00:
       call      qword ptr [7FFB053F8FD8]
       int       3
; Total bytes of code 56
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
       jl        short M10_L01
       cmp       esi,[rbx+20]
       jg        short M10_L02
       test      esi,esi
       jne       near ptr M10_L03
       cmp       qword ptr [rbx+10],0
       jne       short M10_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M10_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L01:
       mov       ecx,3AD
       mov       rdx,7FFB0CAD4000
       call      qword ptr [7FFB0CDB7798]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFB0D2BEEF8]
       int       3
M10_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFB0CAD4000
       call      qword ptr [7FFB0CDB7798]
       mov       rsi,rax
       call      qword ptr [7FFB0D2BFD98]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0CDBDAD0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M10_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,esi
       sub       r8d,ecx
       test      r8d,r8d
       jle       short M10_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB0D364048]
       jmp       near ptr M10_L00
M10_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFB0D364060]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M10_L09
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
       jge       short M10_L07
       cmp       ecx,400
       jge       short M10_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M10_L06
M10_L05:
       xor       edx,edx
       call      qword ptr [7FFB0D1AF450]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M10_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFB0CD05050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M10_L08
M10_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M10_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M10_L09:
       sub       esi,[rdi+1C]
       mov       [rbx+18],esi
       jmp       near ptr M10_L00
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
       jne       near ptr M11_L10
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M11_L11
       cmp       dword ptr [rbx+20],0
       jl        short M11_L02
       cmp       qword ptr [rbx+10],0
       jne       near ptr M11_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M11_L00:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M11_L13
       lea       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M11_L12
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FFB6C7E21C0
       test      rax,rax
       jne       near ptr M11_L13
M11_L01:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFB0CAD4000
       call      qword ptr [7FFB0CDB7798]
       mov       rsi,rax
       call      qword ptr [7FFB0D2BFD98]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0CDBDAD0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M11_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB0D364048]
       jmp       near ptr M11_L00
M11_L04:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB0D364060]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M11_L09
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
       jge       short M11_L07
       cmp       ecx,400
       jge       short M11_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M11_L06
M11_L05:
       xor       edx,edx
       call      qword ptr [7FFB0D1AF450]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M11_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFB0CD05050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M11_L08
M11_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M11_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M11_L09:
       mov       ecx,[rdi+1C]
       neg       ecx
       mov       [rbx+18],ecx
       jmp       near ptr M11_L00
M11_L10:
       mov       rdx,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       jne       near ptr M11_L00
M11_L11:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L12:
       call      qword ptr [7FFB0D2BFAE0]
       int       3
M11_L13:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M11_L14
       mov       rcx,[rsi+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D3653F8]
       jmp       near ptr M11_L01
M11_L14:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M11_L11
; Total bytes of code 543
```
```assembly
; System.Data.DataTableReader.Read()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       cmp       byte ptr [rbx+3D],0
       je        near ptr M12_L08
M12_L00:
       cmp       byte ptr [rbx+38],0
       je        near ptr M12_L12
       cmp       byte ptr [rbx+3E],0
       jne       near ptr M12_L13
       cmp       byte ptr [rbx+3C],0
       jne       near ptr M12_L14
       cmp       byte ptr [rbx+3A],0
       jne       near ptr M12_L11
       mov       esi,[rbx+34]
       mov       r8,[rbx+18]
       mov       r8,[r8+28]
       mov       rdi,[r8+10]
       mov       r8d,[rdi+28]
       lea       ecx,[r8-2]
       cmp       esi,ecx
       jge       near ptr M12_L10
       inc       esi
       mov       [rbx+34],esi
       mov       ecx,esi
       test      ecx,ecx
       jl        near ptr M12_L15
       dec       r8d
       cmp       r8d,ecx
       jle       near ptr M12_L15
       cmp       dword ptr [rdi+2C],0
       jne       near ptr M12_L16
       mov       eax,[rdi+20]
       lea       r8d,[rsi+1]
       test      eax,eax
       jne       short M12_L03
       jmp       near ptr M12_L04
M12_L01:
       mov       eax,[rdx+10]
       sub       r8d,ecx
M12_L02:
       test      eax,eax
       je        near ptr M12_L04
M12_L03:
       mov       rcx,[rdi+8]
       mov       rdx,rcx
       mov       r10d,eax
       sar       r10d,10
       mov       r9d,[rdx+8]
       cmp       r10d,r9d
       jae       near ptr M12_L22
       mov       rdx,[rdx+r10*8+10]
       mov       rdx,[rdx+8]
       movzx     r10d,ax
       cmp       r10d,[rdx+8]
       jae       near ptr M12_L22
       lea       r10,[r10+r10*4]
       lea       rdx,[rdx+r10*8+10]
       mov       r10d,[rdx+0C]
       mov       r11d,r10d
       sar       r11d,10
       cmp       r11d,r9d
       jae       near ptr M12_L22
       mov       r9d,r11d
       mov       rcx,[rcx+r9*8+10]
       mov       rcx,[rcx+8]
       movzx     r9d,r10w
       cmp       r9d,[rcx+8]
       jae       near ptr M12_L22
       lea       r9,[r9+r9*4]
       mov       ecx,[rcx+r9*8+2C]
       inc       ecx
       cmp       r8d,ecx
       jl        near ptr M12_L09
       cmp       ecx,r8d
       jl        near ptr M12_L01
M12_L04:
       xor       r8d,r8d
       mov       [rsp+28],r8d
M12_L05:
       test      eax,eax
       je        near ptr M12_L17
       mov       rcx,[rdi+8]
       mov       edx,eax
       sar       edx,10
       cmp       edx,[rcx+8]
       jae       near ptr M12_L22
       mov       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx+8]
       movzx     edx,ax
       cmp       edx,[rcx+8]
       jae       near ptr M12_L22
       movzx     edx,ax
       lea       rdx,[rdx+rdx*4]
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
M12_L06:
       mov       rcx,[rbx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D24F180]; System.Data.DataRow.get_RowState()
       cmp       eax,8
       je        near ptr M12_L19
       cmp       byte ptr [rbx+3B],0
       jne       near ptr M12_L21
M12_L07:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M12_L08:
       mov       byte ptr [rbx+3D],1
       jmp       near ptr M12_L00
M12_L09:
       mov       eax,r10d
       jmp       near ptr M12_L02
M12_L10:
       mov       byte ptr [rbx+3A],1
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M12_L11
       call      qword ptr [7FFB0D2BC2E8]; System.Data.DataTableReaderListener.UnSubscribeEvents()
M12_L11:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M12_L12:
       mov       ecx,0C8B0
       mov       rdx,7FFB0CF80D50
       call      qword ptr [7FFB0CDB7798]
       mov       rcx,rax
       call      qword ptr [7FFB0D2BFEE8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L13:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2BFE58]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L14:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2BFE70]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L15:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFB0D2B6F58]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2BFE58]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L16:
       lea       r8,[rsp+28]
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB0D3644F8]
       jmp       near ptr M12_L05
M12_L17:
       cmp       dword ptr [rdi+30],2
       jne       short M12_L18
       mov       ecx,esi
       call      qword ptr [7FFB0D364510]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L18:
       mov       ecx,0D
       call      qword ptr [7FFB0D364528]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L19:
       inc       dword ptr [rbx+34]
       mov       edx,[rbx+34]
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+10]
       mov       ecx,[rcx+28]
       dec       ecx
       cmp       edx,ecx
       je        short M12_L20
       mov       edx,[rbx+34]
       mov       rcx,rbx
       call      qword ptr [7FFB0D2B7150]; System.Data.DataTableReader.ValidateRow(Int32)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       mov       edx,[rbx+34]
       mov       rdi,[rcx+10]
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FFB0D2B7168]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].GetNodeByIndex(Int32)
       mov       [rsp+20],rax
       mov       rcx,rdi
       mov       edx,[rsp+20]
       call      qword ptr [7FFB0D365218]
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M12_L06
M12_L20:
       mov       byte ptr [rbx+3A],1
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        near ptr M12_L11
       call      qword ptr [7FFB0D2BC2E8]; System.Data.DataTableReaderListener.UnSubscribeEvents()
       jmp       near ptr M12_L11
M12_L21:
       mov       byte ptr [rbx+3B],0
       jmp       near ptr M12_L07
M12_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 788
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       sub       rsp,28
       mov       r8,rdx
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M13_L00
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       mov       edx,edx
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       ret
M13_L00:
       mov       rdx,r8
       add       rsp,28
       jmp       qword ptr [7FFB0CD0E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
; Total bytes of code 59
```
```assembly
; System.Number.FormatFloat[[System.Double, System.Private.CoreLib]](Double, System.String, System.Globalization.NumberFormatInfo)
       push      rbp
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       mov       [rbp+30],rax
       mov       rax,0D0245848036F
       mov       [rbp],rax
       mov       r9,r8
       test      [rsp],esp
       sub       rsp,40
       lea       r8,[rsp+20]
       mov       [rbp+28],r8
       mov       dword ptr [rbp+30],20
       test      rdx,rdx
       jne       near ptr M14_L04
       xor       r8d,r8d
       xor       ecx,ecx
M14_L00:
       mov       [rbp+8],r8
       mov       [rbp+10],ecx
       lea       r8,[rbp+8]
       lea       rcx,[rbp+18]
       vmovaps   xmm1,xmm0
       call      qword ptr [7FFB0D2B4E28]; System.Number.FormatFloat[[System.Double, System.Private.CoreLib],[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, Double, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M14_L01
       mov       ecx,[rbp+20]
       cmp       ecx,[rbp+30]
       ja        short M14_L05
       mov       rax,[rbp+28]
       mov       [rbp+8],rax
       mov       [rbp+10],ecx
       lea       rcx,[rbp+8]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
M14_L01:
       mov       rdx,[rbp+18]
       test      rdx,rdx
       je        short M14_L02
       xor       ecx,ecx
       mov       [rbp+18],rcx
       mov       rcx,2017BC00C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFB0CE4FB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M14_L02:
       mov       rax,rbx
       mov       r8,0D0245848036F
       cmp       [rbp],r8
       je        short M14_L03
       call      CORINFO_HELP_FAIL_FAST
M14_L03:
       nop
       lea       rsp,[rbp+38]
       pop       rbx
       pop       rbp
       ret
M14_L04:
       lea       r8,[rdx+0C]
       mov       ecx,[rdx+8]
       jmp       near ptr M14_L00
M14_L05:
       call      qword ptr [7FFB0CD07198]
       int       3
; Total bytes of code 236
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M15_L01
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M15_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M15_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFB0CD0F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M15_L00
; Total bytes of code 60
```
```assembly
; System.Data.DataTableReader.IsDBNull(Int32)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,20
       lea       rbp,[rsp+30]
       mov       rbx,rcx
       mov       esi,edx
       cmp       byte ptr [rbx+38],0
       je        near ptr M16_L06
       cmp       byte ptr [rbx+3F],0
       jne       near ptr M16_L07
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M16_L08
       cmp       qword ptr [rbx+18],0
       je        near ptr M16_L08
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D24F180]; System.Data.DataRow.get_RowState()
       cmp       eax,8
       je        near ptr M16_L09
       mov       rcx,[rbx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D24F180]; System.Data.DataRow.get_RowState()
       cmp       eax,1
       je        near ptr M16_L09
       cmp       byte ptr [rbx+3B],0
       jne       near ptr M16_L09
       mov       ecx,[rbx+34]
       test      ecx,ecx
       jl        near ptr M16_L10
       mov       rdx,[rbx+18]
       mov       rdx,[rdx+28]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+28]
       dec       edx
       cmp       edx,ecx
       jle       near ptr M16_L10
       cmp       byte ptr [rbx+3E],0
       jne       near ptr M16_L11
       cmp       byte ptr [rbx+3C],0
       jne       near ptr M16_L12
       mov       rbx,[rbx+20]
       mov       rcx,[rbx+10]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D247E70]; System.Data.DataColumnCollection.get_Item(Int32)
       cmp       dword ptr [rbx+40],0FFFFFFFF
       jne       short M16_L01
       mov       edx,[rbx+3C]
       cmp       edx,0FFFFFFFF
       je        short M16_L02
M16_L00:
       mov       rcx,[rax+60]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M16_L05
M16_L01:
       mov       edx,[rbx+40]
       jmp       short M16_L00
M16_L02:
       cmp       dword ptr [rbx+38],0FFFFFFFF
       je        short M16_L03
       mov       rcx,242109D1778
       call      qword ptr [7FFB0D2BFF78]
       mov       rbx,rax
       mov       rcx,offset MT_System.Data.DeletedRowInaccessibleException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFB0D2BFFC0]
       mov       rcx,2017BC01F10
       mov       rcx,[rcx]
       mov       r9,rsi
       mov       rdx,7FFB0D2E2910
       mov       r8,242109D18F8
       call      qword ptr [7FFB0D2B71E0]
       jmp       short M16_L04
M16_L03:
       mov       rcx,242109D1728
       call      qword ptr [7FFB0D2BFF78]
       mov       rsi,rax
       mov       rcx,offset MT_System.Data.RowNotInTableException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB0D2BFFD8]
       mov       rcx,2017BC01F10
       mov       rcx,[rcx]
       mov       r9,rbx
       mov       rdx,7FFB0D2E2910
       mov       r8,242109D18F8
       call      qword ptr [7FFB0D2B71E0]
       mov       rsi,rbx
M16_L04:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M16_L05:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M16_L06:
       mov       ecx,0CB50
       mov       rdx,7FFB0CF80D50
       call      qword ptr [7FFB0CDB7798]
       mov       rcx,rax
       call      qword ptr [7FFB0D2BFEE8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M16_L07:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2BFF00]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M16_L08:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFB0D2B6F58]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2BFE58]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M16_L09:
       call      qword ptr [7FFB0D2BFF18]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M16_L10:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFB0D2B6F58]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2BFE58]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M16_L11:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2BFE58]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M16_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2BFE70]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FFB0D364000]
       mov       ecx,846B
       mov       rdx,7FFB0CF80D50
       call      qword ptr [7FFB0CDB7798]
       mov       rcx,rax
       call      qword ptr [7FFB0D364018]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 677
```
```assembly
; System.Data.DataTableReader.GetValue(Int32)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,20
       lea       rbp,[rsp+30]
       mov       rbx,rcx
       mov       esi,edx
       cmp       byte ptr [rbx+38],0
       je        near ptr M17_L06
       cmp       byte ptr [rbx+3F],0
       jne       near ptr M17_L07
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M17_L08
       cmp       qword ptr [rbx+18],0
       je        near ptr M17_L08
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D24F180]; System.Data.DataRow.get_RowState()
       cmp       eax,8
       je        near ptr M17_L09
       mov       rcx,[rbx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D24F180]; System.Data.DataRow.get_RowState()
       cmp       eax,1
       je        near ptr M17_L09
       cmp       byte ptr [rbx+3B],0
       jne       near ptr M17_L09
       mov       ecx,[rbx+34]
       test      ecx,ecx
       jl        near ptr M17_L10
       mov       rdx,[rbx+18]
       mov       rdx,[rdx+28]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+28]
       dec       edx
       cmp       edx,ecx
       jle       near ptr M17_L10
       cmp       byte ptr [rbx+3E],0
       jne       near ptr M17_L11
       cmp       byte ptr [rbx+3C],0
       jne       near ptr M17_L12
       mov       rbx,[rbx+20]
       mov       rcx,[rbx+10]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D247E70]; System.Data.DataColumnCollection.get_Item(Int32)
       cmp       dword ptr [rbx+40],0FFFFFFFF
       jne       short M17_L01
       mov       edx,[rbx+3C]
       cmp       edx,0FFFFFFFF
       je        short M17_L02
M17_L00:
       mov       rcx,[rax+60]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       jmp       near ptr M17_L05
M17_L01:
       mov       edx,[rbx+40]
       jmp       short M17_L00
M17_L02:
       cmp       dword ptr [rbx+38],0FFFFFFFF
       je        short M17_L03
       mov       rcx,242109D1778
       call      qword ptr [7FFB0D2BFF78]
       mov       rbx,rax
       mov       rcx,offset MT_System.Data.DeletedRowInaccessibleException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFB0D2BFFC0]
       mov       rcx,2017BC01F10
       mov       rcx,[rcx]
       mov       r9,rsi
       mov       rdx,7FFB0D2E2910
       mov       r8,242109D18F8
       call      qword ptr [7FFB0D2B71E0]
       jmp       short M17_L04
M17_L03:
       mov       rcx,242109D1728
       call      qword ptr [7FFB0D2BFF78]
       mov       rsi,rax
       mov       rcx,offset MT_System.Data.RowNotInTableException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB0D2BFFD8]
       mov       rcx,2017BC01F10
       mov       rcx,[rcx]
       mov       r9,rbx
       mov       rdx,7FFB0D2E2910
       mov       r8,242109D18F8
       call      qword ptr [7FFB0D2B71E0]
       mov       rsi,rbx
M17_L04:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M17_L05:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M17_L06:
       mov       ecx,0CB2A
       mov       rdx,7FFB0CF80D50
       call      qword ptr [7FFB0CDB7798]
       mov       rcx,rax
       call      qword ptr [7FFB0D2BFEE8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M17_L07:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2BFF00]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M17_L08:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFB0D2B6F58]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2BFE58]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M17_L09:
       call      qword ptr [7FFB0D2BFF18]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M17_L10:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFB0D2B6F58]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2BFE58]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M17_L11:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2BFE58]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M17_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2BFE70]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FFB0D364000]
       mov       ecx,846B
       mov       rdx,7FFB0CF80D50
       call      qword ptr [7FFB0CDB7798]
       mov       rcx,rax
       call      qword ptr [7FFB0D364018]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 677
```
```assembly
; System.Buffer.Memmove[[System.Char, System.Private.CoreLib]](Char ByRef, Char ByRef, UIntPtr)
       sub       rsp,28
       add       r8,r8
       call      qword ptr [7FFB0CB95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,28
       ret
; Total bytes of code 19
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFB05411D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFB053F97E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFB05410A28]
       mov       rdx,rax
       test      rsi,rsi
       je        short M20_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB05411BC8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M20_L00:
       call      qword ptr [7FFB0540F410]
       int       3
; Total bytes of code 61
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M21_L00
       cmp       [rdx],rcx
       jne       short M21_L01
M21_L00:
       mov       rax,rdx
       ret
M21_L01:
       jmp       qword ptr [7FFB0CB9FD08]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rdx,rdx
       je        short M22_L01
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M22_L01
       mov       rcx,[rbx+8]
       mov       edx,[rbx+18]
       lea       esi,[rdx+r8]
       cmp       esi,[rcx+8]
       ja        short M22_L03
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jle       short M22_L02
       mov       r8d,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFB0CB95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M22_L00:
       mov       [rbx+18],esi
M22_L01:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M22_L02:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       jne       short M22_L00
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M22_L00
M22_L03:
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFB0CD0F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M22_L01
; Total bytes of code 121
```
```assembly
; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       sub       rsp,28
       test      rdx,rdx
       je        short M23_L00
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M23_L00:
       mov       ecx,14
       call      qword ptr [7FFB0CDBC228]
       int       3
; Total bytes of code 36
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
       call      qword ptr [7FFB0541EA60]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M25_L01
       cmp       qword ptr [rdi+10],0
       je        short M25_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M25_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M25_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.Data.DataTableReader.Close()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+38],0
       je        short M26_L01
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M26_L00
       call      qword ptr [7FFB0D2BC2E8]; System.Data.DataTableReaderListener.UnSubscribeEvents()
M26_L00:
       xor       eax,eax
       mov       [rbx+28],rax
       mov       [rbx+10],rax
       mov       byte ptr [rbx+38],0
M26_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 49
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
       mov       rcx,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       mov       [rbp-0B0],rcx
       mov       edx,r8d
       mov       [rbp-0A4],edx
       mov       r8d,[rbp-3C]
       mov       [rbp-0A8],r8d
       lea       r9,[rbp-48]
       mov       [rbp-0B8],r9
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFB053F9030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFB053F9038]; CORINFO_HELP_JIT_PINVOKE_END
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        near ptr M28_L06
       test      rbx,rbx
       je        near ptr M28_L07
       mov       rcx,[rsi]
       cmp       rcx,[rbx]
       jne       near ptr M28_L07
       cmp       dword ptr [rcx+4],18
       jne       near ptr M28_L07
       cmp       edi,[rsi+8]
       ja        short M28_L07
       cmp       edi,[rbx+8]
       ja        short M28_L07
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       add       rbx,10
       test      dword ptr [rcx],1000000
       je        short M28_L05
       cmp       r8,4000
       ja        short M28_L04
       mov       rcx,rbx
       call      00007FFB6C7B37A0
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       short M28_L02
M28_L00:
       cmp       dword ptr [7FFB6CAF3A90],0
       jne       short M28_L03
M28_L01:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M28_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M28_L00
M28_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M28_L01
M28_L04:
       mov       rcx,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFB0D1AF1E0]
M28_L05:
       mov       rcx,rbx
       call      qword ptr [7FFB0CB95818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M28_L00
M28_L06:
       xor       ebp,ebp
       jmp       short M28_L08
M28_L07:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0D246910]; System.Array.GetLowerBound(Int32)
       mov       ebp,eax
M28_L08:
       test      rbx,rbx
       jne       short M28_L09
       xor       r9d,r9d
       jmp       short M28_L10
M28_L09:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB0D246910]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
M28_L10:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       call      qword ptr [7FFB0D246928]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M28_L00
; Total bytes of code 246
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataReaderExtensionsBenchmark.ToCsvWithoutHeader()
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
       mov       [rbp-68],rax
       mov       rbx,rcx
       mov       rsi,[rbx+1A8]
       mov       rdi,rsi
       cmp       [rdi],dil
       mov       rcx,offset MT_System.Data.DataTableReader
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       byte ptr [r14+38],1
       mov       qword ptr [r14+30],0FFFFFFFFFFFFFFFF
       mov       byte ptr [r14+39],1
       mov       rcx,offset MT_System.Data.DataTable[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+30],ecx
       mov       byte ptr [r14+3A],0
       mov       byte ptr [r14+3C],0
       mov       rcx,[r14+8]
       mov       edx,[r14+30]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L72
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+28]
       mov       rcx,[rcx+10]
       mov       ecx,[rcx+28]
       dec       ecx
       test      ecx,ecx
       setg      cl
       mov       [r14+39],cl
       cmp       byte ptr [r14+3E],0
       je        short M00_L00
       mov       byte ptr [r14+3E],0
M00_L00:
       mov       rcx,offset MT_System.Data.DataTableReaderListener
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       cmp       qword ptr [rsi+8],0
       je        short M00_L01
       mov       rcx,rsi
       call      qword ptr [7FFB0D2C4648]; System.Data.DataTableReaderListener.UnSubscribeEvents()
M00_L01:
       mov       rcx,offset MT_System.WeakReference
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,r14
       xor       edx,edx
       call      00007FFB6C7E5950
       test      rax,rax
       je        near ptr M00_L70
M00_L02:
       mov       [rdi+8],rax
       cmp       qword ptr [7FFB0CAFB020],0
       jne       near ptr M00_L71
M00_L03:
       xor       edx,edx
M00_L04:
       test      rdx,rdx
       je        short M00_L05
       lea       rcx,[rdi+8]
       call      qword ptr [7FFB0D2CE8E0]
M00_L05:
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[r14+18]
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L06
       mov       rcx,rsi
       call      qword ptr [7FFB0D25F318]; System.Data.DataTableReaderListener.SubscribeEvents()
M00_L06:
       lea       rcx,[r14+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-80],r14
       mov       rsi,r14
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1D00B000230
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       byte ptr [rsi+38],0
       je        near ptr M00_L62
       cmp       byte ptr [rsi+3E],0
       jne       near ptr M00_L63
       cmp       byte ptr [rsi+3C],0
       jne       near ptr M00_L64
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r14d,eax
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Boolean[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       xor       r13d,r13d
       test      r14d,r14d
       jle       short M00_L09
       mov       ecx,[r15+8]
M00_L07:
       mov       rcx,rsi
       mov       edx,r13d
       call      qword ptr [7FFB0D2AA638]; System.Data.DataTableReader.GetFieldType(Int32)
       mov       rcx,2109FF10020
       cmp       rax,rcx
       sete      cl
       movzx     ecx,cl
       mov       [r15+r13+10],cl
       add       r13d,1
       jo        near ptr M00_L68
       cmp       r13d,r14d
       jl        short M00_L07
       jmp       short M00_L09
M00_L08:
       mov       rcx,[rbp-88]
       xor       edx,edx
       call      qword ptr [7FFB0D1CDC80]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r13
       mov       rdx,[rbp-88]
       call      qword ptr [7FFB0D1CDC98]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
M00_L09:
       mov       rcx,rsi
       call      qword ptr [7FFB0D2AA748]; System.Data.DataTableReader.Read()
       test      eax,eax
       je        near ptr M00_L61
       mov       rcx,1D021000228
       mov       r13,[rcx]
       mov       r12,r13
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       rcx,[r12+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L65
       lea       rcx,[r12+20]
       mov       r8,[rbp-40]
       test      rcx,rcx
       je        near ptr M00_L67
       xor       edx,edx
       call      00007FFB6C7E21C0
       cmp       rax,[rbp-40]
       jne       near ptr M00_L65
M00_L10:
       mov       r12,[rbp-40]
M00_L11:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-88],r12
       xor       r12d,r12d
       cmp       r12d,r14d
       jl        near ptr M00_L29
M00_L12:
       mov       rcx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0CDA2200]; System.Text.StringBuilder.ToString()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB0CCA3598]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       near ptr M00_L08
M00_L13:
       jmp       near ptr M00_L25
       xchg      ax,ax
M00_L14:
       mov       r8d,eax
       add       r8,r8
       mov       rdx,r10
       call      qword ptr [7FFB0CBB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,[rbp-54]
M00_L15:
       mov       r11d,eax
       add       r11d,[rbp-58]
       mov       rcx,[rbp-88]
       mov       [rcx+18],r11d
       jmp       near ptr M00_L27
M00_L16:
       mov       r8d,edx
       jmp       near ptr M00_L40
M00_L17:
       mov       ecx,r8d
       xor       edx,edx
       call      qword ptr [7FFB0D1C7738]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       [rbp-0A8],rax
M00_L18:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-88]
       mov       ecx,[rcx+18]
       mov       [rax+18],ecx
       mov       rcx,[rbp-88]
       mov       ecx,[rcx+1C]
       mov       [rax+1C],ecx
       mov       rcx,[rbp-88]
       mov       rdx,[rcx+8]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-88]
       mov       rdx,[rcx+10]
       mov       rax,[rbp-0A0]
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-88]
       mov       ecx,[rcx+20]
       mov       rax,[rbp-0A0]
       mov       [rax+20],ecx
       mov       rcx,[rbp-88]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-88]
       mov       ecx,[rcx+18]
       mov       rdx,[rbp-88]
       add       [rdx+1C],ecx
       mov       rcx,[rbp-88]
       xor       edx,edx
       mov       [rcx+18],edx
       mov       rcx,[rbp-88]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-0A8]
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,dword ptr [rbp-4C]
       mov       rax,[rbp-98]
       lea       rdx,[rax+r8*2]
       mov       r8,[rbp-88]
       mov       r8,[r8+8]
       test      r8,r8
       je        near ptr M00_L46
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M00_L19:
       mov       eax,[rbp-50]
       cmp       eax,r8d
       ja        near ptr M00_L58
       mov       r8d,eax
       add       r8,r8
       call      qword ptr [7FFB0CBB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8,[rbp-88]
       mov       ecx,[rbp-50]
       mov       [r8+18],ecx
       jmp       near ptr M00_L27
M00_L20:
       movsxd    r8,r11d
       lea       rcx,[r9+r8*2+10]
       cmp       eax,2
       jle       short M00_L22
       mov       r8d,eax
       add       r8,r8
       mov       rdx,r10
       call      qword ptr [7FFB0CBB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,[rbp-44]
M00_L21:
       mov       r11d,eax
       add       r11d,[rbp-48]
       mov       r8,[rbp-88]
       mov       [r8+18],r11d
       jmp       near ptr M00_L27
M00_L22:
       movzx     r8d,word ptr [r10]
       mov       [rcx],r8w
       cmp       eax,2
       jne       short M00_L21
       movzx     r8d,word ptr [r10+2]
       mov       [rcx+2],r8w
       jmp       short M00_L21
M00_L23:
       mov       rdx,[rbp-88]
       mov       r9d,ecx
       add       r9d,[rdx+1C]
       add       r9d,eax
       mov       rdx,[rbp-88]
       cmp       r9d,[rdx+20]
       jg        near ptr M00_L56
       cmp       r9d,eax
       jl        near ptr M00_L56
       mov       r9d,[r8+8]
       sub       r9d,ecx
       mov       [rbp-5C],r9d
       test      r9d,r9d
       jle       near ptr M00_L13
       test      r8,r8
       je        near ptr M00_L51
       cmp       [r8+8],ecx
       jb        near ptr M00_L57
       mov       edx,ecx
       lea       rdx,[r8+rdx*2+10]
       mov       r8d,[r8+8]
       sub       r8d,ecx
M00_L24:
       cmp       r9d,r8d
       ja        near ptr M00_L58
       mov       r8d,r9d
       add       r8,r8
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFB0CBB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       mov       rdx,[rbp-88]
       mov       [rdx+18],ecx
       mov       r9d,[rbp-5C]
M00_L25:
       mov       eax,[rbp-54]
       sub       eax,r9d
       mov       [rbp-60],eax
       mov       rcx,[rbp-88]
       mov       edx,eax
       call      qword ptr [7FFB0CD2F1F8]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,dword ptr [rbp-5C]
       mov       rax,[rbp-0B0]
       lea       rdx,[rax+r8*2]
       mov       r8,[rbp-88]
       mov       r8,[r8+8]
       test      r8,r8
       je        near ptr M00_L52
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M00_L26:
       mov       eax,[rbp-60]
       cmp       eax,r8d
       ja        near ptr M00_L58
       mov       r8d,eax
       call      qword ptr [7FFB0D25CAC8]
       mov       r8,[rbp-88]
       mov       ecx,[rbp-60]
       mov       [r8+18],ecx
M00_L27:
       mov       ecx,r14d
       sub       ecx,1
       jo        near ptr M00_L60
       cmp       r12d,ecx
       jge       short M00_L28
       mov       rcx,[rbp-88]
       mov       edx,2C
       cmp       [rcx],ecx
       call      qword ptr [7FFB0CD2F180]; System.Text.StringBuilder.Append(Char)
M00_L28:
       add       r12d,1
       jo        near ptr M00_L60
       cmp       r12d,r14d
       jge       near ptr M00_L12
M00_L29:
       mov       rcx,rsi
       mov       edx,r12d
       call      qword ptr [7FFB0D2AA730]; System.Data.DataTableReader.IsDBNull(Int32)
       test      eax,eax
       jne       short M00_L27
       mov       rcx,rsi
       mov       edx,r12d
       call      qword ptr [7FFB0D2AA710]; System.Data.DataTableReader.GetValue(Int32)
       mov       rdx,[rax]
       mov       rcx,offset MT_System.String
       cmp       rdx,rcx
       je        near ptr M00_L32
       mov       rcx,rax
       mov       rax,[rdx+40]
       call      qword ptr [rax+8]
M00_L30:
       mov       r8,rax
       mov       [rbp-90],r8
       cmp       r12d,[r15+8]
       jae       near ptr M00_L59
       cmp       byte ptr [r15+r12+10],0
       jne       near ptr M00_L33
M00_L31:
       mov       r8,[rbp-88]
       cmp       [r8],r8b
       test      rax,rax
       je        near ptr M00_L27
       lea       r10,[rax+0C]
       mov       [rbp-0B0],r10
       mov       eax,[rax+8]
       mov       r8d,eax
       mov       eax,r8d
       mov       [rbp-54],eax
       test      eax,eax
       je        near ptr M00_L27
       mov       r8,[rbp-88]
       mov       r8,[r8+8]
       mov       r9,r8
       mov       rcx,[rbp-88]
       mov       ecx,[rcx+18]
       mov       r11d,ecx
       mov       [rbp-58],r11d
       lea       edx,[r11+rax]
       cmp       edx,[r9+8]
       ja        near ptr M00_L23
       movsxd    r8,r11d
       lea       rcx,[r9+r8*2+10]
       cmp       eax,2
       jg        near ptr M00_L14
       movzx     edx,word ptr [r10]
       mov       [rcx],dx
       cmp       eax,2
       jne       near ptr M00_L15
       movzx     edx,word ptr [r10+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L15
M00_L32:
       jmp       near ptr M00_L30
M00_L33:
       test      r8,r8
       je        near ptr M00_L31
       xor       ecx,ecx
       mov       eax,[r8+8]
       test      eax,eax
       jle       short M00_L35
M00_L34:
       movzx     edx,word ptr [r8+rcx*2+0C]
       cmp       edx,22
       je        near ptr M00_L43
       cmp       edx,2C
       je        near ptr M00_L42
       add       ecx,1
       jo        near ptr M00_L60
       mov       [rbp-6C],eax
       cmp       eax,ecx
       jle       short M00_L36
       mov       eax,[rbp-6C]
       mov       r8,[rbp-90]
       jmp       short M00_L34
M00_L35:
       mov       [rbp-6C],eax
M00_L36:
       mov       rcx,[rbp-88]
       cmp       [rcx],cl
       mov       r8,[rbp-90]
       lea       r10,[r8+0C]
       mov       [rbp-98],r10
       mov       eax,[rbp-6C]
       mov       [rbp-44],eax
       test      eax,eax
       je        near ptr M00_L27
       mov       r8,[rbp-88]
       mov       r8,[r8+8]
       mov       r9,r8
       mov       rcx,[rbp-88]
       mov       ecx,[rcx+18]
       mov       r11d,ecx
       mov       [rbp-48],r11d
       lea       edx,[r11+rax]
       cmp       edx,[r9+8]
       jbe       near ptr M00_L20
       mov       rdx,[rbp-88]
       mov       r9d,ecx
       add       r9d,[rdx+1C]
       add       r9d,eax
       mov       rdx,[rbp-88]
       cmp       r9d,[rdx+20]
       jg        near ptr M00_L53
       cmp       r9d,eax
       jl        near ptr M00_L53
       mov       r9d,[r8+8]
       sub       r9d,ecx
       mov       [rbp-4C],r9d
       test      r9d,r9d
       jle       short M00_L38
       test      r8,r8
       je        near ptr M00_L45
       cmp       [r8+8],ecx
       jb        near ptr M00_L57
       mov       edx,ecx
       lea       rdx,[r8+rdx*2+10]
       mov       r8d,[r8+8]
       sub       r8d,ecx
M00_L37:
       cmp       r9d,r8d
       ja        near ptr M00_L58
       mov       r8d,r9d
       add       r8,r8
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFB0CBB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       mov       rdx,[rbp-88]
       mov       [rdx+18],ecx
       mov       r9d,[rbp-4C]
       mov       r10,[rbp-98]
M00_L38:
       mov       eax,[rbp-44]
       sub       eax,r9d
       mov       [rbp-50],eax
       mov       rcx,[rbp-88]
       mov       ecx,[rcx+1C]
       lea       edx,[rax+rcx]
       mov       r8,[rbp-88]
       mov       r8d,[r8+18]
       add       edx,r8d
       mov       r11,[rbp-88]
       cmp       edx,[r11+20]
       jg        near ptr M00_L54
       cmp       edx,eax
       jl        near ptr M00_L54
       add       ecx,r8d
       mov       edx,ecx
       cmp       edx,1F40
       jg        short M00_L41
M00_L39:
       cmp       eax,edx
       jl        near ptr M00_L16
       mov       r8d,eax
M00_L40:
       add       ecx,r8d
       cmp       ecx,r8d
       jl        near ptr M00_L55
       cmp       r8d,400
       jge       near ptr M00_L17
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0A8],rax
       jmp       near ptr M00_L18
M00_L41:
       mov       edx,1F40
       jmp       short M00_L39
M00_L42:
       mov       [rbp-6C],eax
       jmp       short M00_L44
M00_L43:
       mov       [rbp-6C],eax
M00_L44:
       mov       rcx,[rbp-88]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFB0CD2F180]; System.Text.StringBuilder.Append(Char)
       xor       eax,eax
       jmp       short M00_L50
M00_L45:
       test      ecx,ecx
       jne       near ptr M00_L57
       xor       edx,edx
       xor       r8d,r8d
       jmp       near ptr M00_L37
M00_L46:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M00_L19
M00_L47:
       mov       [rbp-6C],r8d
       cmp       eax,r8d
       jae       near ptr M00_L59
       mov       r10,[rbp-90]
       mov       [rbp-78],rax
       movzx     edx,word ptr [r10+rax*2+0C]
       cmp       edx,22
       jne       short M00_L48
       mov       rcx,[rbp-88]
       mov       rdx,2109FF21960
       call      qword ptr [7FFB0CD2F228]; System.Text.StringBuilder.Append(System.String)
       jmp       short M00_L49
M00_L48:
       mov       rcx,[rbp-88]
       call      qword ptr [7FFB0CD2F180]; System.Text.StringBuilder.Append(Char)
M00_L49:
       mov       rcx,[rbp-78]
       add       ecx,1
       jo        near ptr M00_L60
       mov       rax,rcx
M00_L50:
       mov       r8d,[rbp-6C]
       cmp       r8d,eax
       jg        short M00_L47
       mov       rcx,[rbp-88]
       mov       edx,22
       call      qword ptr [7FFB0CD2F180]; System.Text.StringBuilder.Append(Char)
       jmp       near ptr M00_L27
M00_L51:
       test      ecx,ecx
       jne       near ptr M00_L57
       xor       edx,edx
       xor       r8d,r8d
       jmp       near ptr M00_L24
M00_L52:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M00_L26
M00_L53:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFB0CAF4000
       call      qword ptr [7FFB0CDD7798]
       mov       rsi,rax
       call      qword ptr [7FFB0D2CEE38]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0CDDDAD0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L54:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFB0CAF4000
       call      qword ptr [7FFB0CDD7798]
       mov       rsi,rax
       call      qword ptr [7FFB0D2CD800]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0CDDDAD0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L55:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFB0D2CEE50]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L56:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFB0CAF4000
       call      qword ptr [7FFB0CDD7798]
       mov       rsi,rax
       call      qword ptr [7FFB0D2CEE38]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0CDDDAD0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L57:
       call      qword ptr [7FFB0CD27198]
       int       3
M00_L58:
       call      qword ptr [7FFB0D05D3E0]
       int       3
M00_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L60:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L61:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFB0D056BE0]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       mov       [rbp-68],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rbp-68]
       mov       rdx,7FFB0D2B2F20
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D2C4750]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       jmp       near ptr M00_L69
M00_L62:
       mov       ecx,0C8E0
       mov       rdx,7FFB0CFA0D50
       call      qword ptr [7FFB0CDD7798]
       mov       rcx,rax
       call      qword ptr [7FFB0D2CD110]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2CD098]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L64:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2CD0B0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L65:
       mov       rcx,[r12+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D1CDB30]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L66
       add       r12,2C
       lock dec  dword ptr [r12]
       jmp       near ptr M00_L10
M00_L66:
       mov       rax,[r12+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       jmp       near ptr M00_L11
M00_L67:
       call      qword ptr [7FFB0D2CD458]
       int       3
M00_L68:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L69:
       mov       rcx,[rbp-80]
       call      qword ptr [7FFB0D2AA600]; System.Data.DataTableReader.Close()
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
M00_L70:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFB0D2CE8B0]
       jmp       near ptr M00_L02
M00_L71:
       mov       rax,[7FFB0CAFB020]
       mov       rcx,r14
       call      rax
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r14
       call      qword ptr [7FFB0D2CE8C8]
       mov       rdx,rax
       jmp       near ptr M00_L04
M00_L72:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       mov       rcx,[rbp-88]
       cmp       [rcx],cl
       mov       rcx,[rbp-88]
       xor       edx,edx
       call      qword ptr [7FFB0D1CDC80]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,1D021000228
       mov       r13,[rcx]
       mov       rcx,r13
       mov       rdx,[rbp-88]
       call      qword ptr [7FFB0D1CDC98]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,[rbp-80]
       call      qword ptr [7FFB0D2AA600]; System.Data.DataTableReader.Close()
       nop
       add       rsp,28
       ret
; Total bytes of code 3067
```
```assembly
; System.Data.DataTableReaderListener.UnSubscribeEvents()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       cmp       qword ptr [rbx+8],0
       je        near ptr M01_L15
       cmp       byte ptr [rbx+18],0
       je        near ptr M01_L15
       mov       rsi,[rbx+8]
       mov       rcx,offset MT_System.ComponentModel.CollectionChangeEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+30]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D25B330
       mov       [rdi+18],rcx
       mov       rbp,[rsi+40]
M01_L00:
       test      rbp,rbp
       je        near ptr M01_L16
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FFB0CBEAAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
M01_L01:
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L02
       mov       rcx,offset MT_System.ComponentModel.CollectionChangeEventHandler
       cmp       [rdx],rcx
       jne       near ptr M01_L17
M01_L02:
       lea       rcx,[rsi+40]
       test      rcx,rcx
       je        near ptr M01_L20
       mov       r8,rbp
       call      00007FFB6C7E21C0
       cmp       rax,rbp
       mov       rbp,rax
       jne       short M01_L00
       mov       rsi,[rbx+8]
       mov       rcx,offset MT_System.ComponentModel.CollectionChangeEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+30]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D25B330
       mov       [rdi+18],rcx
       mov       rbp,[rsi+30]
M01_L03:
       test      rbp,rbp
       je        near ptr M01_L18
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FFB0CBEAAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
M01_L04:
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L05
       mov       rcx,offset MT_System.ComponentModel.CollectionChangeEventHandler
       cmp       [rdx],rcx
       jne       near ptr M01_L19
M01_L05:
       lea       rcx,[rsi+30]
       test      rcx,rcx
       je        near ptr M01_L20
       mov       r8,rbp
       call      00007FFB6C7E21C0
       cmp       rax,rbp
       mov       rbp,rax
       jne       short M01_L03
       mov       rcx,offset MT_System.Data.DataRowChangeEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+8]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D25B3A8
       mov       [rsi+18],rcx
       mov       rcx,1D00B001EE8
       mov       rbp,[rcx]
       mov       r14,rbp
       mov       r15d,[rdi+1C0]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M01_L21
M01_L06:
       mov       rcx,[rdi+120]
       test      rcx,rcx
       je        near ptr M01_L22
       mov       rdx,rsi
       call      qword ptr [7FFB0CBEAAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
M01_L07:
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L08
       mov       rcx,offset MT_System.Data.DataRowChangeEventHandler
       cmp       [rdx],rcx
       jne       near ptr M01_L23
M01_L08:
       lea       rcx,[rdi+120]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataRowChangeEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+8]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D25B3A8
       mov       [rsi+18],rcx
       mov       r14,rbp
       mov       r15d,[rdi+1C0]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M01_L24
M01_L09:
       mov       rcx,[rdi+138]
       test      rcx,rcx
       je        near ptr M01_L25
       mov       rdx,rsi
       call      qword ptr [7FFB0CBEAAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
M01_L10:
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L11
       mov       rcx,offset MT_System.Data.DataRowChangeEventHandler
       cmp       [rdx],rcx
       jne       near ptr M01_L26
M01_L11:
       lea       rcx,[rdi+138]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataTableClearEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+8]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D25B3F0
       mov       [rsi+18],rcx
       mov       r14,rbp
       mov       r15d,[rdi+1C0]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M01_L27
M01_L12:
       mov       rcx,[rdi+158]
       test      rcx,rcx
       je        near ptr M01_L28
       mov       rdx,rsi
       call      qword ptr [7FFB0CBEAAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
M01_L13:
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L14
       mov       rcx,offset MT_System.Data.DataTableClearEventHandler
       cmp       [rdx],rcx
       jne       near ptr M01_L29
M01_L14:
       lea       rcx,[rdi+158]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+18],0
M01_L15:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L16:
       xor       eax,eax
       jmp       near ptr M01_L01
M01_L17:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L18:
       xor       eax,eax
       jmp       near ptr M01_L04
M01_L19:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L20:
       call      qword ptr [7FFB0D2CD458]
       int       3
M01_L21:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],r15d
       mov       [rsp+40],rax
       lea       r8,[rsp+40]
       mov       [rsp+20],r8
       mov       dword ptr [rsp+28],1
       lea       r8,[rsp+20]
       xor       ecx,ecx
       mov       rdx,2109FF22618
       call      qword ptr [7FFB0D2CD1B8]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFB0D2C4AC8]
       jmp       near ptr M01_L06
M01_L22:
       xor       eax,eax
       jmp       near ptr M01_L07
M01_L23:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L24:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],r15d
       mov       [rsp+38],rax
       lea       r8,[rsp+38]
       mov       [rsp+20],r8
       mov       dword ptr [rsp+28],1
       lea       r8,[rsp+20]
       xor       ecx,ecx
       mov       rdx,2109FF22680
       call      qword ptr [7FFB0D2CD1B8]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFB0D2C4AC8]
       jmp       near ptr M01_L09
M01_L25:
       xor       eax,eax
       jmp       near ptr M01_L10
M01_L26:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L27:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],r15d
       mov       [rsp+30],rax
       lea       r8,[rsp+30]
       mov       [rsp+20],r8
       mov       dword ptr [rsp+28],1
       lea       r8,[rsp+20]
       xor       ecx,ecx
       mov       rdx,2109FF226E8
       call      qword ptr [7FFB0D2CD1B8]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFB0D2C4AC8]
       jmp       near ptr M01_L12
M01_L28:
       xor       eax,eax
       jmp       near ptr M01_L13
M01_L29:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 1102
```
```assembly
; System.Data.DataTableReaderListener.SubscribeEvents()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M02_L15
       cmp       byte ptr [rbx+18],0
       jne       near ptr M02_L15
       mov       rcx,offset MT_System.ComponentModel.CollectionChangeEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+30]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D25B330
       mov       [rdi+18],rcx
       mov       rbp,[rsi+40]
M02_L00:
       test      rbp,rbp
       jne       near ptr M02_L16
       mov       rdx,rdi
M02_L01:
       mov       r8,rdx
       test      r8,r8
       je        short M02_L02
       mov       rcx,offset MT_System.ComponentModel.CollectionChangeEventHandler
       cmp       [r8],rcx
       jne       near ptr M02_L17
M02_L02:
       mov       rdx,r8
       lea       rcx,[rsi+40]
       test      rcx,rcx
       je        near ptr M02_L20
       mov       r8,rbp
       call      00007FFB6C7E21C0
       cmp       rax,rbp
       mov       rbp,rax
       jne       short M02_L00
       mov       rsi,[rbx+8]
       mov       rcx,offset MT_System.ComponentModel.CollectionChangeEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+30]
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D25B330
       mov       [rdi+18],rcx
       mov       rbp,[rsi+30]
M02_L03:
       test      rbp,rbp
       jne       near ptr M02_L18
       mov       rdx,rdi
M02_L04:
       mov       r8,rdx
       test      r8,r8
       je        short M02_L05
       mov       rcx,offset MT_System.ComponentModel.CollectionChangeEventHandler
       cmp       [r8],rcx
       jne       near ptr M02_L19
M02_L05:
       mov       rdx,r8
       lea       rcx,[rsi+30]
       test      rcx,rcx
       je        near ptr M02_L20
       mov       r8,rbp
       call      00007FFB6C7E21C0
       cmp       rax,rbp
       mov       rbp,rax
       jne       short M02_L03
       mov       rcx,offset MT_System.Data.DataRowChangeEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+8]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D25B3A8
       mov       [rsi+18],rcx
       mov       rcx,1D00B001EE8
       mov       rbp,[rcx]
       mov       r14,rbp
       mov       r15d,[rdi+1C0]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M02_L21
M02_L06:
       mov       rcx,[rdi+120]
       test      rcx,rcx
       jne       near ptr M02_L22
       mov       rdx,rsi
M02_L07:
       mov       rax,rdx
       test      rax,rax
       je        short M02_L08
       mov       rcx,offset MT_System.Data.DataRowChangeEventHandler
       cmp       [rax],rcx
       jne       near ptr M02_L23
M02_L08:
       lea       rcx,[rdi+120]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataRowChangeEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+8]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D25B3A8
       mov       [rsi+18],rcx
       mov       r14,rbp
       mov       r15d,[rdi+1C0]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M02_L24
M02_L09:
       mov       rcx,[rdi+138]
       test      rcx,rcx
       jne       near ptr M02_L25
       mov       rdx,rsi
M02_L10:
       mov       rax,rdx
       test      rax,rax
       je        short M02_L11
       mov       rcx,offset MT_System.Data.DataRowChangeEventHandler
       cmp       [rax],rcx
       jne       near ptr M02_L26
M02_L11:
       lea       rcx,[rdi+138]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataTableClearEventHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+8]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB0D25B3F0
       mov       [rsi+18],rcx
       mov       r14,rbp
       mov       r15d,[rdi+1C0]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M02_L27
M02_L12:
       mov       rcx,[rdi+158]
       test      rcx,rcx
       jne       near ptr M02_L28
       mov       rdx,rsi
M02_L13:
       mov       rax,rdx
       test      rax,rax
       je        short M02_L14
       mov       rcx,offset MT_System.Data.DataTableClearEventHandler
       cmp       [rax],rcx
       jne       near ptr M02_L29
M02_L14:
       lea       rcx,[rdi+158]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+18],1
M02_L15:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L16:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FFB0CBEAAE8]
       mov       rdx,rax
       jmp       near ptr M02_L01
M02_L17:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L18:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FFB0CBEAAE8]
       mov       rdx,rax
       jmp       near ptr M02_L04
M02_L19:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L20:
       call      qword ptr [7FFB0D2CD458]
       int       3
M02_L21:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],r15d
       mov       [rsp+40],rax
       lea       r8,[rsp+40]
       mov       [rsp+20],r8
       mov       dword ptr [rsp+28],1
       lea       r8,[rsp+20]
       xor       ecx,ecx
       mov       rdx,2109FF214D8
       call      qword ptr [7FFB0D2CD1B8]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFB0D2C4AC8]
       jmp       near ptr M02_L06
M02_L22:
       mov       rdx,rsi
       call      qword ptr [7FFB0CBEAAE8]
       mov       rdx,rax
       jmp       near ptr M02_L07
M02_L23:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L24:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],r15d
       mov       [rsp+38],rax
       lea       r8,[rsp+38]
       mov       [rsp+20],r8
       mov       dword ptr [rsp+28],1
       lea       r8,[rsp+20]
       xor       ecx,ecx
       mov       rdx,2109FF21538
       call      qword ptr [7FFB0D2CD1B8]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFB0D2C4AC8]
       jmp       near ptr M02_L09
M02_L25:
       mov       rdx,rsi
       call      qword ptr [7FFB0CBEAAE8]
       mov       rdx,rax
       jmp       near ptr M02_L10
M02_L26:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L27:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],r15d
       mov       [rsp+30],rax
       lea       r8,[rsp+30]
       mov       [rsp+20],r8
       mov       dword ptr [rsp+28],1
       lea       r8,[rsp+20]
       xor       ecx,ecx
       mov       rdx,2109FF21598
       call      qword ptr [7FFB0D2CD1B8]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFB0D2C4AC8]
       jmp       near ptr M02_L12
M02_L28:
       mov       rdx,rsi
       call      qword ptr [7FFB0CBEAAE8]
       mov       rdx,rax
       jmp       near ptr M02_L13
M02_L29:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 1120
```
```assembly
; System.Data.DataTableReader.GetFieldType(Int32)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       cmp       byte ptr [rcx+38],0
       je        short M03_L00
       cmp       byte ptr [rcx+3E],0
       jne       short M03_L01
       cmp       byte ptr [rcx+3C],0
       jne       short M03_L02
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D2541E0]; System.Data.DataColumnCollection.get_Item(Int32)
       mov       rax,[rax+28]
       add       rsp,20
       pop       rbp
       ret
M03_L00:
       mov       ecx,0CA7E
       mov       rdx,7FFB0CFA0D50
       call      qword ptr [7FFB0CDD7798]
       mov       rcx,rax
       call      qword ptr [7FFB0D2CD110]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L01:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2CD098]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L02:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2CD0B0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FFB0D2CD230]
       mov       ecx,846B
       mov       rdx,7FFB0CFA0D50
       call      qword ptr [7FFB0CDD7798]
       mov       rcx,rax
       call      qword ptr [7FFB0D2CD248]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 188
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
       jl        short M04_L01
       cmp       esi,[rbx+20]
       jg        short M04_L02
       test      esi,esi
       jne       near ptr M04_L03
       cmp       qword ptr [rbx+10],0
       jne       short M04_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M04_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       ecx,3AD
       mov       rdx,7FFB0CAF4000
       call      qword ptr [7FFB0CDD7798]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFB0D2CD7A0]
       int       3
M04_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFB0CAF4000
       call      qword ptr [7FFB0CDD7798]
       mov       rsi,rax
       call      qword ptr [7FFB0D2CD800]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0CDDDAD0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,esi
       sub       r8d,ecx
       test      r8d,r8d
       jle       short M04_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB0D2CD818]
       jmp       near ptr M04_L00
M04_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFB0D2CD830]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M04_L09
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
       jge       short M04_L07
       cmp       ecx,400
       jge       short M04_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M04_L06
M04_L05:
       xor       edx,edx
       call      qword ptr [7FFB0D1C7738]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M04_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFB0CD25050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M04_L08
M04_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M04_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M04_L09:
       sub       esi,[rdi+1C]
       mov       [rbx+18],esi
       jmp       near ptr M04_L00
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
       jne       near ptr M05_L10
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M05_L11
       cmp       dword ptr [rbx+20],0
       jl        short M05_L02
       cmp       qword ptr [rbx+10],0
       jne       near ptr M05_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M05_L00:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M05_L13
       lea       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M05_L12
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FFB6C7E21C0
       test      rax,rax
       jne       near ptr M05_L13
M05_L01:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFB0CAF4000
       call      qword ptr [7FFB0CDD7798]
       mov       rsi,rax
       call      qword ptr [7FFB0D2CD800]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0CDDDAD0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M05_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB0D2CD818]
       jmp       near ptr M05_L00
M05_L04:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB0D2CD830]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M05_L09
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
       jge       short M05_L07
       cmp       ecx,400
       jge       short M05_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M05_L06
M05_L05:
       xor       edx,edx
       call      qword ptr [7FFB0D1C7738]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M05_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFB0CD25050]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M05_L08
M05_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M05_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M05_L09:
       mov       ecx,[rdi+1C]
       neg       ecx
       mov       [rbx+18],ecx
       jmp       near ptr M05_L00
M05_L10:
       mov       rdx,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       jne       near ptr M05_L00
M05_L11:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L12:
       call      qword ptr [7FFB0D2CD458]
       int       3
M05_L13:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M05_L14
       mov       rcx,[rsi+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D2CEE98]
       jmp       near ptr M05_L01
M05_L14:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M05_L11
; Total bytes of code 543
```
```assembly
; System.Data.DataTableReader.Read()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       cmp       byte ptr [rbx+3D],0
       je        near ptr M06_L09
M06_L00:
       cmp       byte ptr [rbx+38],0
       je        near ptr M06_L10
       cmp       byte ptr [rbx+3E],0
       jne       near ptr M06_L11
       cmp       byte ptr [rbx+3C],0
       jne       near ptr M06_L12
       cmp       byte ptr [rbx+3A],0
       jne       near ptr M06_L13
       mov       esi,[rbx+34]
       mov       r8,[rbx+18]
       mov       r8,[r8+28]
       mov       rdi,[r8+10]
       mov       r8d,[rdi+28]
       lea       ecx,[r8-2]
       cmp       esi,ecx
       jge       near ptr M06_L14
       inc       esi
       mov       [rbx+34],esi
       mov       ecx,esi
       test      ecx,ecx
       jl        near ptr M06_L15
       dec       r8d
       cmp       r8d,ecx
       jle       near ptr M06_L15
       cmp       dword ptr [rdi+2C],0
       jne       near ptr M06_L16
       mov       eax,[rdi+20]
       lea       r8d,[rsi+1]
       test      eax,eax
       jne       short M06_L03
       jmp       near ptr M06_L04
M06_L01:
       mov       eax,[rdx+10]
       sub       r8d,ecx
M06_L02:
       test      eax,eax
       je        near ptr M06_L04
M06_L03:
       mov       rcx,[rdi+8]
       mov       rdx,rcx
       mov       r10d,eax
       sar       r10d,10
       mov       r9d,[rdx+8]
       cmp       r10d,r9d
       jae       near ptr M06_L22
       mov       rdx,[rdx+r10*8+10]
       mov       rdx,[rdx+8]
       movzx     r10d,ax
       cmp       r10d,[rdx+8]
       jae       near ptr M06_L22
       lea       r10,[r10+r10*4]
       lea       rdx,[rdx+r10*8+10]
       mov       r10d,[rdx+0C]
       mov       r11d,r10d
       sar       r11d,10
       cmp       r11d,r9d
       jae       near ptr M06_L22
       mov       r9d,r11d
       mov       rcx,[rcx+r9*8+10]
       mov       rcx,[rcx+8]
       movzx     r9d,r10w
       cmp       r9d,[rcx+8]
       jae       near ptr M06_L22
       lea       r9,[r9+r9*4]
       mov       ecx,[rcx+r9*8+2C]
       inc       ecx
       cmp       r8d,ecx
       jl        near ptr M06_L08
       cmp       ecx,r8d
       jl        near ptr M06_L01
M06_L04:
       xor       r8d,r8d
       mov       [rsp+28],r8d
M06_L05:
       test      eax,eax
       je        near ptr M06_L17
       mov       rcx,[rdi+8]
       mov       edx,eax
       sar       edx,10
       cmp       edx,[rcx+8]
       jae       near ptr M06_L22
       mov       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx+8]
       movzx     edx,ax
       cmp       edx,[rcx+8]
       jae       near ptr M06_L22
       movzx     edx,ax
       lea       rdx,[rdx+rdx*4]
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
M06_L06:
       mov       rcx,[rbx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D2574E0]; System.Data.DataRow.get_RowState()
       cmp       eax,8
       je        near ptr M06_L19
       cmp       byte ptr [rbx+3B],0
       jne       near ptr M06_L21
M06_L07:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L08:
       mov       eax,r10d
       jmp       near ptr M06_L02
M06_L09:
       mov       byte ptr [rbx+3D],1
       jmp       near ptr M06_L00
M06_L10:
       mov       ecx,0C8B0
       mov       rdx,7FFB0CFA0D50
       call      qword ptr [7FFB0CDD7798]
       mov       rcx,rax
       call      qword ptr [7FFB0D2CD110]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M06_L11:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2CD098]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M06_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2CD0B0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M06_L13:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L14:
       mov       byte ptr [rbx+3A],1
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M06_L13
       call      qword ptr [7FFB0D2C4648]; System.Data.DataTableReaderListener.UnSubscribeEvents()
       jmp       short M06_L13
M06_L15:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFB0D25F2B8]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2CD098]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M06_L16:
       lea       r8,[rsp+28]
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB0D2CDAE8]
       jmp       near ptr M06_L05
M06_L17:
       cmp       dword ptr [rdi+30],2
       jne       short M06_L18
       mov       ecx,esi
       call      qword ptr [7FFB0D2CDB00]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M06_L18:
       mov       ecx,0D
       call      qword ptr [7FFB0D2CDB18]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M06_L19:
       inc       dword ptr [rbx+34]
       mov       edx,[rbx+34]
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+10]
       mov       ecx,[rcx+28]
       dec       ecx
       cmp       edx,ecx
       je        short M06_L20
       mov       edx,[rbx+34]
       mov       rcx,rbx
       call      qword ptr [7FFB0D25F498]; System.Data.DataTableReader.ValidateRow(Int32)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       mov       edx,[rbx+34]
       mov       rdi,[rcx+10]
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FFB0D25F4B0]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].GetNodeByIndex(Int32)
       mov       [rsp+20],rax
       mov       rcx,rdi
       mov       edx,[rsp+20]
       call      qword ptr [7FFB0D2CEAA8]
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L06
M06_L20:
       mov       byte ptr [rbx+3A],1
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        near ptr M06_L13
       call      qword ptr [7FFB0D2C4648]; System.Data.DataTableReaderListener.UnSubscribeEvents()
       jmp       near ptr M06_L13
M06_L21:
       mov       byte ptr [rbx+3B],0
       jmp       near ptr M06_L07
M06_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 790
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M07_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB6C8352E0
       mov       rsi,rax
M07_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M07_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M07_L03
       cmp       [rdx+8],r8d
       jb        short M07_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFB0CBB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M07_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M07_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L02:
       mov       rax,2109FF10008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFB0CAF4000
       call      qword ptr [7FFB0CDD7798]
       mov       rbx,rax
       call      qword ptr [7FFB0D2CDA70]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB0CDDDAD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       sub       rsp,28
       mov       r8,rdx
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M08_L00
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       mov       edx,edx
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       ret
M08_L00:
       mov       rdx,r8
       add       rsp,28
       jmp       qword ptr [7FFB0CD2E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
; Total bytes of code 59
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M09_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M09_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M09_L01
       test      r8b,18
       jne       short M09_L00
       test      r8b,4
       je        near ptr M09_L09
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M09_L04
M09_L00:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M09_L04
M09_L01:
       cmp       r8,40
       ja        short M09_L05
M09_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M09_L03
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M09_L08
M09_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M09_L04:
       vzeroupper
       ret
M09_L05:
       cmp       r8,800
       ja        near ptr M09_L12
       cmp       r8,100
       jae       short M09_L10
M09_L06:
       mov       r9,r8
       shr       r9,6
M09_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M09_L07
       and       r8,3F
       cmp       r8,10
       ja        short M09_L02
       jmp       short M09_L03
M09_L08:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M09_L03
M09_L09:
       test      r8,r8
       je        short M09_L04
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M09_L04
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M09_L04
M09_L10:
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
       jmp       near ptr M09_L06
M09_L11:
       cmp       rcx,rdx
       jne       short M09_L12
       cmp       [rdx],dl
       jmp       near ptr M09_L04
M09_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFB0CBB66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 325
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
       mov       rcx,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       mov       [rbp-0B0],rcx
       mov       edx,r8d
       mov       [rbp-0A4],edx
       mov       r8d,[rbp-3C]
       mov       [rbp-0A8],r8d
       lea       r9,[rbp-48]
       mov       [rbp-0B8],r9
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFB053F9030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFB053F9038]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Text.StringBuilder.ExpandByABlock(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       lea       eax,[rdx+rcx]
       mov       r8d,[rbx+18]
       add       eax,r8d
       cmp       eax,[rbx+20]
       jg        near ptr M11_L02
       cmp       eax,edx
       jl        near ptr M11_L02
       add       ecx,r8d
       mov       eax,ecx
       mov       r8d,1F40
       cmp       eax,1F40
       cmovg     eax,r8d
       cmp       edx,eax
       cmovl     edx,eax
       add       ecx,edx
       cmp       ecx,edx
       jl        near ptr M11_L03
       cmp       edx,400
       jl        short M11_L00
       mov       ecx,edx
       xor       edx,edx
       call      qword ptr [7FFB0D1C7738]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
       jmp       short M11_L01
M11_L00:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
M11_L01:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,[rbx+18]
       mov       [rdi+18],ecx
       mov       ecx,[rbx+1C]
       mov       [rdi+1C],ecx
       mov       rdx,[rbx+8]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+10]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+20]
       mov       [rdi+20],ecx
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+18]
       add       [rbx+1C],ecx
       xor       ecx,ecx
       mov       [rbx+18],ecx
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFB0CAF4000
       call      qword ptr [7FFB0CDD7798]
       mov       rsi,rax
       call      qword ptr [7FFB0D2CD800]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB0CDDDAD0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L03:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB0D2CEE50]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 333
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M12_L01
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M12_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M12_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFB0CD2F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M12_L00
; Total bytes of code 60
```
```assembly
; System.Data.DataTableReader.IsDBNull(Int32)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,20
       lea       rbp,[rsp+30]
       mov       rbx,rcx
       mov       esi,edx
       cmp       byte ptr [rbx+38],0
       je        near ptr M13_L06
       cmp       byte ptr [rbx+3F],0
       jne       near ptr M13_L07
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M13_L08
       cmp       qword ptr [rbx+18],0
       je        near ptr M13_L08
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D2574E0]; System.Data.DataRow.get_RowState()
       cmp       eax,8
       je        near ptr M13_L09
       mov       rcx,[rbx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D2574E0]; System.Data.DataRow.get_RowState()
       cmp       eax,1
       je        near ptr M13_L09
       cmp       byte ptr [rbx+3B],0
       jne       near ptr M13_L09
       mov       ecx,[rbx+34]
       test      ecx,ecx
       jl        near ptr M13_L10
       mov       rdx,[rbx+18]
       mov       rdx,[rdx+28]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+28]
       dec       edx
       cmp       edx,ecx
       jle       near ptr M13_L10
       cmp       byte ptr [rbx+3E],0
       jne       near ptr M13_L11
       cmp       byte ptr [rbx+3C],0
       jne       near ptr M13_L12
       mov       rbx,[rbx+20]
       mov       rcx,[rbx+10]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D2541E0]; System.Data.DataColumnCollection.get_Item(Int32)
       cmp       dword ptr [rbx+40],0FFFFFFFF
       jne       short M13_L01
       mov       edx,[rbx+3C]
       cmp       edx,0FFFFFFFF
       je        short M13_L02
M13_L00:
       mov       rcx,[rax+60]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M13_L05
M13_L01:
       mov       edx,[rbx+40]
       jmp       short M13_L00
M13_L02:
       cmp       dword ptr [rbx+38],0FFFFFFFF
       je        short M13_L03
       mov       rcx,2109FF21750
       call      qword ptr [7FFB0D2CD1A0]
       mov       rbx,rax
       mov       rcx,offset MT_System.Data.DeletedRowInaccessibleException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFB0D2CD200]
       mov       rcx,1D00B001EE8
       mov       rcx,[rcx]
       mov       r9,rsi
       mov       rdx,7FFB0D2ACDE0
       mov       r8,2109FF218D0
       call      qword ptr [7FFB0D25F540]
       jmp       short M13_L04
M13_L03:
       mov       rcx,2109FF21700
       call      qword ptr [7FFB0D2CD1A0]
       mov       rsi,rax
       mov       rcx,offset MT_System.Data.RowNotInTableException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB0D2CD218]
       mov       rcx,1D00B001EE8
       mov       rcx,[rcx]
       mov       r9,rbx
       mov       rdx,7FFB0D2ACDE0
       mov       r8,2109FF218D0
       call      qword ptr [7FFB0D25F540]
       mov       rsi,rbx
M13_L04:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M13_L05:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M13_L06:
       mov       ecx,0CB50
       mov       rdx,7FFB0CFA0D50
       call      qword ptr [7FFB0CDD7798]
       mov       rcx,rax
       call      qword ptr [7FFB0D2CD110]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M13_L07:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2CD128]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M13_L08:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFB0D25F2B8]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2CD098]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M13_L09:
       call      qword ptr [7FFB0D2CD140]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M13_L10:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFB0D25F2B8]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2CD098]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M13_L11:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2CD098]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M13_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2CD0B0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FFB0D2CD230]
       mov       ecx,846B
       mov       rdx,7FFB0CFA0D50
       call      qword ptr [7FFB0CDD7798]
       mov       rcx,rax
       call      qword ptr [7FFB0D2CD248]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 677
```
```assembly
; System.Data.DataTableReader.GetValue(Int32)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,20
       lea       rbp,[rsp+30]
       mov       rbx,rcx
       mov       esi,edx
       cmp       byte ptr [rbx+38],0
       je        near ptr M14_L06
       cmp       byte ptr [rbx+3F],0
       jne       near ptr M14_L07
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M14_L08
       cmp       qword ptr [rbx+18],0
       je        near ptr M14_L08
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D2574E0]; System.Data.DataRow.get_RowState()
       cmp       eax,8
       je        near ptr M14_L09
       mov       rcx,[rbx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D2574E0]; System.Data.DataRow.get_RowState()
       cmp       eax,1
       je        near ptr M14_L09
       cmp       byte ptr [rbx+3B],0
       jne       near ptr M14_L09
       mov       ecx,[rbx+34]
       test      ecx,ecx
       jl        near ptr M14_L10
       mov       rdx,[rbx+18]
       mov       rdx,[rdx+28]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+28]
       dec       edx
       cmp       edx,ecx
       jle       near ptr M14_L10
       cmp       byte ptr [rbx+3E],0
       jne       near ptr M14_L11
       cmp       byte ptr [rbx+3C],0
       jne       near ptr M14_L12
       mov       rbx,[rbx+20]
       mov       rcx,[rbx+10]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFB0D2541E0]; System.Data.DataColumnCollection.get_Item(Int32)
       cmp       dword ptr [rbx+40],0FFFFFFFF
       jne       short M14_L01
       mov       edx,[rbx+3C]
       cmp       edx,0FFFFFFFF
       je        short M14_L02
M14_L00:
       mov       rcx,[rax+60]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       jmp       near ptr M14_L05
M14_L01:
       mov       edx,[rbx+40]
       jmp       short M14_L00
M14_L02:
       cmp       dword ptr [rbx+38],0FFFFFFFF
       je        short M14_L03
       mov       rcx,2109FF21750
       call      qword ptr [7FFB0D2CD1A0]
       mov       rbx,rax
       mov       rcx,offset MT_System.Data.DeletedRowInaccessibleException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFB0D2CD200]
       mov       rcx,1D00B001EE8
       mov       rcx,[rcx]
       mov       r9,rsi
       mov       rdx,7FFB0D2ACDE0
       mov       r8,2109FF218D0
       call      qword ptr [7FFB0D25F540]
       jmp       short M14_L04
M14_L03:
       mov       rcx,2109FF21700
       call      qword ptr [7FFB0D2CD1A0]
       mov       rsi,rax
       mov       rcx,offset MT_System.Data.RowNotInTableException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFB0D2CD218]
       mov       rcx,1D00B001EE8
       mov       rcx,[rcx]
       mov       r9,rbx
       mov       rdx,7FFB0D2ACDE0
       mov       r8,2109FF218D0
       call      qword ptr [7FFB0D25F540]
       mov       rsi,rbx
M14_L04:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M14_L05:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M14_L06:
       mov       ecx,0CB2A
       mov       rdx,7FFB0CFA0D50
       call      qword ptr [7FFB0CDD7798]
       mov       rcx,rax
       call      qword ptr [7FFB0D2CD110]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M14_L07:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2CD128]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M14_L08:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFB0D25F2B8]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2CD098]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M14_L09:
       call      qword ptr [7FFB0D2CD140]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M14_L10:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFB0D25F2B8]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2CD098]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M14_L11:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2CD098]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M14_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFB0D2CD0B0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FFB0D2CD230]
       mov       ecx,846B
       mov       rdx,7FFB0CFA0D50
       call      qword ptr [7FFB0CDD7798]
       mov       rcx,rax
       call      qword ptr [7FFB0D2CD248]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 677
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rdx,rdx
       je        short M15_L02
       lea       rax,[rdx+0C]
       mov       esi,[rdx+8]
       test      esi,esi
       je        short M15_L02
       mov       rdi,[rbx+8]
       mov       ebp,[rbx+18]
       lea       ecx,[rsi+rbp]
       cmp       ecx,[rdi+8]
       jbe       short M15_L00
       mov       rcx,rbx
       mov       rdx,rax
       mov       r8d,esi
       call      qword ptr [7FFB0CD2F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M15_L02
M15_L00:
       movsxd    r8,ebp
       lea       rcx,[rdi+r8*2+10]
       cmp       esi,2
       jle       short M15_L03
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFB0CBB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M15_L01:
       add       esi,ebp
       mov       [rbx+18],esi
M15_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M15_L03:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       esi,2
       jne       short M15_L01
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M15_L01
; Total bytes of code 125
```
```assembly
; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       sub       rsp,28
       test      rdx,rdx
       je        short M16_L00
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M16_L00:
       mov       ecx,14
       call      qword ptr [7FFB0CDDC228]
       int       3
; Total bytes of code 36
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
       call      qword ptr [7FFB0541EA60]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M18_L01
       cmp       qword ptr [rdi+10],0
       je        short M18_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M18_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M18_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.Data.DataTableReader.Close()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+38],0
       je        short M19_L01
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M19_L00
       call      qword ptr [7FFB0D2C4648]; System.Data.DataTableReaderListener.UnSubscribeEvents()
M19_L00:
       xor       eax,eax
       mov       [rbx+28],rax
       mov       [rbx+10],rax
       mov       byte ptr [rbx+38],0
M19_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 49
```

