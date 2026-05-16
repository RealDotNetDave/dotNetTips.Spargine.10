## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataReaderExtensionsBenchmark.ToCsvWithHeader()
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
       xor       eax,eax
       mov       [rbp-0F8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0F0],ymm4
       vmovdqu   ymmword ptr [rbp-0D0],ymm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       rbx,rcx
       lea       rcx,[rbp-0A8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-70],rax
       mov       rcx,rsp
       mov       [rbp-90],rcx
       mov       rcx,rbp
       mov       [rbp-80],rcx
       mov       rsi,[rbx+138]
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
       jae       near ptr M00_L63
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
       call      qword ptr [7FF910BE7BA0]; System.Data.DataTableReaderListener.UnSubscribeEvents()
M00_L01:
       mov       rcx,offset MT_System.WeakReference
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,r14
       xor       edx,edx
       call      00007FF970104E90
       test      rax,rax
       je        near ptr M00_L61
M00_L02:
       mov       [rdi+8],rax
       cmp       qword ptr [7FF91040B020],0
       jne       near ptr M00_L62
M00_L03:
       xor       edx,edx
M00_L04:
       test      rdx,rdx
       je        short M00_L05
       lea       rcx,[rdi+8]
       call      qword ptr [7FF910C678D0]
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
       call      qword ptr [7FF910BE6670]; System.Data.DataTableReaderListener.SubscribeEvents()
M00_L06:
       lea       rcx,[r14+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-0D0],r14
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1CC07000368
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-0D8],rsi
       mov       rcx,1CC07002220
       mov       rcx,[rcx]
       mov       [rbp-0F8],rcx
       mov       rsi,[rbp-0F8]
       mov       rcx,[rsi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L55
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       test      rcx,rcx
       je        near ptr M00_L59
       xor       edx,edx
       call      00007FF970103270
       cmp       rax,[rbp-40]
       jne       near ptr M00_L55
M00_L07:
       mov       rdx,[rbp-40]
M00_L08:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-0F0],rdx
       xor       esi,esi
       jmp       near ptr M00_L13
M00_L09:
       mov       r8d,edi
       add       r8,r8
       mov       rdx,r10
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L10:
       add       edi,r15d
       mov       rdx,[rbp-0F0]
       mov       [rdx+18],edi
M00_L11:
       cmp       byte ptr [r14+38],0
       je        near ptr M00_L20
       cmp       byte ptr [r14+3E],0
       jne       near ptr M00_L18
       cmp       byte ptr [r14+3C],0
       jne       near ptr M00_L19
       mov       rcx,[r14+18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       sub       eax,1
       jo        near ptr M00_L23
       cmp       esi,eax
       jge       short M00_L12
       mov       rcx,[rbp-0F0]
       mov       edx,[rcx+18]
       mov       eax,edx
       mov       r8,[rcx+8]
       cmp       [r8+8],eax
       jbe       near ptr M00_L17
       mov       word ptr [r8+rax*2+10],2C
       inc       edx
       mov       [rcx+18],edx
M00_L12:
       add       esi,1
       jo        near ptr M00_L23
M00_L13:
       mov       r14,[rbp-0D0]
       cmp       byte ptr [r14+38],0
       je        near ptr M00_L20
       cmp       byte ptr [r14+3E],0
       jne       near ptr M00_L21
       cmp       byte ptr [r14+3C],0
       jne       near ptr M00_L22
       mov       rcx,[r14+18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       cmp       esi,eax
       jge       near ptr M00_L14
       mov       rcx,r14
       mov       edx,esi
       call      qword ptr [7FF910BFD398]; System.Data.DataTableReader.GetName(Int32)
       test      rax,rax
       je        near ptr M00_L11
       mov       rcx,r14
       mov       edx,esi
       call      qword ptr [7FF910BFD398]; System.Data.DataTableReader.GetName(Int32)
       mov       rdx,[rbp-0F0]
       cmp       [rdx],dl
       test      rax,rax
       je        near ptr M00_L11
       lea       r10,[rax+0C]
       mov       edi,[rax+8]
       test      edi,edi
       je        near ptr M00_L11
       mov       r8,[rdx+8]
       mov       r15d,[rdx+18]
       lea       ecx,[r15+rdi]
       cmp       ecx,[r8+8]
       ja        near ptr M00_L16
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       edi,2
       jg        near ptr M00_L09
       movzx     r8d,word ptr [r10]
       mov       [rcx],r8w
       cmp       edi,2
       jne       near ptr M00_L10
       movzx     r10d,word ptr [r10+2]
       mov       [rcx+2],r10w
       jmp       near ptr M00_L10
M00_L14:
       mov       rcx,[rbp-0F0]
       cmp       [rcx],ecx
       call      qword ptr [7FF910769CE8]; System.Text.StringBuilder.ToString()
       mov       rsi,[rbp-0D8]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       short M00_L15
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       mov       edx,edx
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L24
M00_L15:
       mov       rcx,rsi
       mov       rdx,rax
       call      qword ptr [7FF9104C71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L24
M00_L16:
       mov       rdx,[rbp-0F0]
       mov       rcx,rdx
       mov       rdx,r10
       mov       r8d,edi
       call      qword ptr [7FF9107577F8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L11
M00_L17:
       mov       edx,2C
       call      qword ptr [7FF910757C78]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L18:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C664F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C66508]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L20:
       mov       ecx,0C8E0
       mov       rdx,7FF9108AC210
       call      qword ptr [7FF9104CF228]
       mov       rcx,rax
       call      qword ptr [7FF910C66520]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C664F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       rcx,[r14+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C66508]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L24:
       call      M00_L64
       jmp       short M00_L26
M00_L25:
       mov       rcx,[rbp-0E0]
       xor       edx,edx
       call      qword ptr [7FF910B65848]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,[rbp-0F8]
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FF910B65860]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
M00_L26:
       mov       rcx,[rbp-0D0]
       call      qword ptr [7FF910BFD4A0]; System.Data.DataTableReader.Read()
       test      eax,eax
       je        near ptr M00_L54
       mov       rbx,[rbp-0F8]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbx+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M00_L57
       lea       rcx,[rbx+20]
       mov       r8,[rbp-48]
       test      rcx,rcx
       je        near ptr M00_L59
       xor       edx,edx
       call      00007FF970103270
       cmp       rax,[rbp-48]
       jne       near ptr M00_L57
M00_L27:
       mov       rbx,[rbp-48]
M00_L28:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-0E0],rbx
       xor       ebx,ebx
       jmp       near ptr M00_L39
M00_L29:
       mov       rcx,rsi
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdi,rax
M00_L30:
       mov       rsi,rdi
       mov       rcx,[rbp-0D0]
       mov       edx,ebx
       call      qword ptr [7FF910BFD390]; System.Data.DataTableReader.GetFieldType(Int32)
       mov       rcx,20C9BF10020
       cmp       rax,rcx
       jne       near ptr M00_L36
       lea       rcx,[rsi+0C]
       mov       r8d,[rsi+8]
       mov       edx,22
       call      qword ptr [7FF91069F828]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       cmp       eax,0FFFFFFFF
       jne       near ptr M00_L41
M00_L31:
       cmp       [rsi],sil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L42
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L42
M00_L32:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M00_L33
       mov       rax,1CC07000190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M00_L33
       mov       rax,1CC07000170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M00_L43
M00_L33:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M00_L47
       mov       rcx,[rdi+8]
       test      rcx,rcx
       je        near ptr M00_L44
M00_L34:
       mov       dword ptr [rbp-4C],2C
       cmp       [rcx],cl
       lea       r9,[rsi+0C]
       mov       [rbp-0E8],rsi
       mov       edi,[rsi+8]
       cmp       byte ptr [rcx+2C],0
       je        near ptr M00_L48
       mov       rsi,[rbp-0E8]
       mov       [rbp-0B8],r9
       mov       [rbp-0B0],edi
       lea       rdx,[rbp-4C]
       mov       [rbp-0C8],rdx
       mov       dword ptr [rbp-0C0],1
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       dword ptr [rsp+28],1
       lea       rdx,[rbp-0B8]
       lea       r8,[rbp-0C8]
       xor       r9d,r9d
       call      qword ptr [7FF910BE69A0]; System.Globalization.CompareInfo.IndexOfOrdinalHelper(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions, Int32*, Boolean)
M00_L35:
       xor       edx,edx
       mov       [rbp-58],rdx
       mov       [rbp-60],rdx
       cmp       eax,0FFFFFFFF
       jne       near ptr M00_L51
M00_L36:
       mov       r8,[rbp-0E0]
       cmp       [r8],r8b
       test      rsi,rsi
       je        short M00_L37
       mov       r8d,[rsi+8]
       lea       rdx,[rsi+0C]
       mov       rcx,[rbp-0E0]
       call      qword ptr [7FF910757768]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L37:
       mov       r14,[rbp-0D0]
       cmp       byte ptr [r14+38],0
       je        near ptr M00_L52
       mov       rcx,r14
       call      qword ptr [7FF910BE6808]; System.Data.DataTableReader.ValidateReader()
       mov       rcx,[r14+18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       sub       eax,1
       jo        near ptr M00_L53
       cmp       ebx,eax
       jge       short M00_L38
       mov       rcx,[rbp-0E0]
       mov       edx,2C
       cmp       [rcx],ecx
       call      qword ptr [7FF910757798]; System.Text.StringBuilder.Append(Char)
M00_L38:
       add       ebx,1
       jo        near ptr M00_L53
M00_L39:
       mov       rcx,[rbp-0D0]
       call      qword ptr [7FF910BFD320]; System.Data.DataTableReader.get_FieldCount()
       cmp       ebx,eax
       jge       short M00_L40
       mov       rcx,[rbp-0D0]
       mov       edx,ebx
       call      qword ptr [7FF910BFD488]; System.Data.DataTableReader.IsDBNull(Int32)
       test      eax,eax
       jne       short M00_L37
       mov       rcx,[rbp-0D0]
       mov       edx,ebx
       call      qword ptr [7FF910BFD468]; System.Data.DataTableReader.GetValue(Int32)
       mov       rsi,rax
       mov       rax,[rsi]
       mov       rcx,offset MT_System.String
       cmp       rax,rcx
       jne       near ptr M00_L29
       mov       rdi,rsi
       jmp       near ptr M00_L30
M00_L40:
       mov       rcx,[rbp-0E0]
       cmp       [rcx],ecx
       call      qword ptr [7FF910769CE8]; System.Text.StringBuilder.ToString()
       mov       rdx,rax
       mov       rcx,[rbp-0D8]
       call      qword ptr [7FF9105B3598]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       near ptr M00_L25
M00_L41:
       mov       rcx,rdi
       mov       rdx,20C9BF211C8
       mov       r8,20C9BF211E0
       mov       r9d,4
       cmp       [rcx],ecx
       call      qword ptr [7FF910BE67C0]
       mov       rsi,rax
       jmp       near ptr M00_L31
M00_L42:
       mov       ecx,2
       call      qword ptr [7FF910C65A58]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L32
M00_L43:
       call      qword ptr [7FF9104CD4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M00_L33
M00_L44:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L45
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF910C65A70]
       jmp       short M00_L46
M00_L45:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF910844EA0]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M00_L46:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       jmp       near ptr M00_L34
M00_L47:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       jmp       near ptr M00_L34
M00_L48:
       mov       [rbp-58],r9
       lea       rdx,[rbp-4C]
       mov       [rbp-60],rdx
       mov       rcx,[rcx+20]
       lea       rdx,[rbp-4C]
       mov       [rsp+20],edi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FF9106551A0
       mov       [rbp-98],rax
       lea       rax,[M00_L49]
       mov       [rbp-88],rax
       mov       rax,[rbp-70]
       lea       r10,[rbp-0A8]
       mov       [rax+8],r10
       mov       rax,[rbp-70]
       mov       byte ptr [rax+4],0
       call      qword ptr [7FF9106551C0]
M00_L49:
       mov       rcx,[rbp-70]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FF9704239A0],0
       je        short M00_L50
       call      qword ptr [7FF970411648]; CORINFO_HELP_STOP_FOR_GC
M00_L50:
       mov       rdx,[rbp-70]
       mov       rcx,[rbp-0A0]
       mov       [rdx+8],rcx
       mov       rsi,[rbp-0E8]
       jmp       near ptr M00_L35
M00_L51:
       mov       rdx,rsi
       mov       rcx,20C9BF211C8
       mov       r8,20C9BF211C8
       call      qword ptr [7FF910695488]; System.String.Concat(System.String, System.String, System.String)
       mov       rsi,rax
       jmp       near ptr M00_L36
M00_L52:
       mov       ecx,0C8E0
       mov       rdx,7FF9108AC210
       call      qword ptr [7FF9104CF228]
       mov       rcx,rax
       call      qword ptr [7FF910C66520]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,[rbp-0D8]
       call      qword ptr [7FF9109774B0]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       mov       [rbp-68],rbx
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       lea       r8,[rbp-68]
       mov       rdx,7FF910C06B48
       cmp       [rcx],ecx
       call      qword ptr [7FF910BE7CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       jmp       short M00_L60
M00_L55:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF910B656F8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L56
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M00_L07
M00_L56:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       jmp       near ptr M00_L08
M00_L57:
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF910B656F8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L58
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M00_L27
M00_L58:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M00_L28
M00_L59:
       call      qword ptr [7FF910C659B0]
       int       3
M00_L60:
       mov       rcx,[rbp-0D0]
       call      qword ptr [7FF910BFD358]; System.Data.DataTableReader.Close()
       nop
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
M00_L61:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF910C678A0]
       jmp       near ptr M00_L02
M00_L62:
       mov       rax,[7FF91040B020]
       mov       rcx,r14
       call      rax
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r14
       call      qword ptr [7FF910C678B8]
       mov       rdx,rax
       jmp       near ptr M00_L04
M00_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       vzeroupper
       mov       rcx,[rbp-0E0]
       cmp       [rcx],cl
       mov       rcx,[rbp-0E0]
       xor       edx,edx
       call      qword ptr [7FF910B65848]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,1CC07002220
       mov       rcx,[rcx]
       mov       [rbp-0F8],rcx
       mov       rcx,[rbp-0F8]
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FF910B65860]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       nop
       add       rsp,38
       ret
M00_L64:
       sub       rsp,38
       vzeroupper
       mov       rcx,[rbp-0F0]
       cmp       dword ptr [rcx+20],0
       jge       short M00_L65
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF910404000
       call      qword ptr [7FF9104CF228]
       mov       rsi,rax
       call      qword ptr [7FF910C663D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF91075E760]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L65:
       cmp       qword ptr [rcx+10],0
       jne       short M00_L66
       xor       edx,edx
       mov       [rcx+18],rdx
       jmp       near ptr M00_L73
M00_L66:
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       mov       r8d,edx
       neg       r8d
       test      r8d,r8d
       jle       short M00_L67
       xor       edx,edx
       call      qword ptr [7FF910C667D8]
       mov       rcx,[rbp-0F0]
       jmp       near ptr M00_L73
M00_L67:
       xor       edx,edx
       call      qword ptr [7FF910C667F0]
       mov       rbx,rax
       mov       rcx,[rbp-0F0]
       cmp       rbx,rcx
       je        near ptr M00_L72
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
       jge       short M00_L70
       cmp       r8d,400
       jge       short M00_L68
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L69
M00_L68:
       mov       ecx,r8d
       xor       edx,edx
       call      qword ptr [7FF910AEF360]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L69:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FF9104CF5A0]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbp-0F0]
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L71
M00_L70:
       mov       rdx,[rbx+8]
       mov       rcx,[rbp-0F0]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L71:
       mov       rdx,[rbx+10]
       mov       rcx,[rbp-0F0]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+1C]
       mov       rax,[rbp-0F0]
       mov       [rax+1C],ecx
       mov       rcx,rax
M00_L72:
       mov       r8d,[rbx+1C]
       neg       r8d
       mov       [rcx+18],r8d
M00_L73:
       mov       rdx,1CC07002220
       mov       rdx,[rdx]
       mov       [rbp-0F8],rdx
       mov       rbx,[rbp-0F8]
       mov       rax,[rbx+10]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L75
M00_L74:
       add       rsp,38
       ret
M00_L75:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L77
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L76
       call      qword ptr [7FF910C659B0]
       int       3
M00_L76:
       mov       rdx,[rbp-0F0]
       xor       r8d,r8d
       call      00007FF970103270
       test      rax,rax
       je        short M00_L74
M00_L77:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L78
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-0F0]
       cmp       [rcx],ecx
       call      qword ptr [7FF910C66B08]
       test      eax,eax
       jne       short M00_L74
       mov       rcx,rbx
       mov       rdx,[rbp-0F0]
       call      qword ptr [7FF910C66B20]
       jmp       short M00_L74
M00_L78:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M00_L74
       sub       rsp,38
       vzeroupper
       mov       rcx,[rbp-0D0]
       call      qword ptr [7FF910BFD358]; System.Data.DataTableReader.Close()
       nop
       add       rsp,38
       ret
; Total bytes of code 3337
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
       mov       rcx,7FF910BE2688
       mov       [rdi+18],rcx
       mov       rbp,[rsi+40]
M01_L00:
       test      rbp,rbp
       je        near ptr M01_L16
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FF9104FAAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       call      00007FF970103270
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
       mov       rcx,7FF910BE2688
       mov       [rdi+18],rcx
       mov       rbp,[rsi+30]
M01_L03:
       test      rbp,rbp
       je        near ptr M01_L18
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FF9104FAAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       call      00007FF970103270
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
       mov       rcx,7FF910BE2700
       mov       [rsi+18],rcx
       mov       rcx,1CC07001EE8
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
       call      qword ptr [7FF9104FAAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       mov       rcx,7FF910BE2700
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
       call      qword ptr [7FF9104FAAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       mov       rcx,7FF910BE2748
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
       call      qword ptr [7FF9104FAAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       call      qword ptr [7FF910C659B0]
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
       mov       rdx,20C9BF222D0
       call      qword ptr [7FF910C665C8]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FF910BEC048]
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
       mov       rdx,20C9BF22338
       call      qword ptr [7FF910C665C8]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FF910BEC048]
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
       mov       rdx,20C9BF223A0
       call      qword ptr [7FF910C665C8]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FF910BEC048]
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
       mov       rcx,7FF910BE2688
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
       call      00007FF970103270
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
       mov       rcx,7FF910BE2688
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
       call      00007FF970103270
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
       mov       rcx,7FF910BE2700
       mov       [rsi+18],rcx
       mov       rcx,1CC07001EE8
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
       mov       rcx,7FF910BE2700
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
       mov       rcx,7FF910BE2748
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
       call      qword ptr [7FF9104FAAE8]
       mov       rdx,rax
       jmp       near ptr M02_L01
M02_L17:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L18:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FF9104FAAE8]
       mov       rdx,rax
       jmp       near ptr M02_L04
M02_L19:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L20:
       call      qword ptr [7FF910C659B0]
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
       mov       rdx,20C9BF21070
       call      qword ptr [7FF910C665C8]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FF910BEC048]
       jmp       near ptr M02_L06
M02_L22:
       mov       rdx,rsi
       call      qword ptr [7FF9104FAAE8]
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
       mov       rdx,20C9BF210D0
       call      qword ptr [7FF910C665C8]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FF910BEC048]
       jmp       near ptr M02_L09
M02_L25:
       mov       rdx,rsi
       call      qword ptr [7FF9104FAAE8]
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
       mov       rdx,20C9BF21130
       call      qword ptr [7FF910C665C8]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FF910BEC048]
       jmp       near ptr M02_L12
M02_L28:
       mov       rdx,rsi
       call      qword ptr [7FF9104FAAE8]
       mov       rdx,rax
       jmp       near ptr M02_L13
M02_L29:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 1120
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
       jne       short M03_L00
       test      r8b,4
       je        near ptr M03_L09
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L04
M03_L00:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M03_L04
M03_L01:
       cmp       r8,40
       ja        short M03_L05
M03_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L03
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L08
M03_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M03_L04:
       vzeroupper
       ret
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
       ja        short M03_L02
       jmp       short M03_L03
M03_L08:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L03
M03_L09:
       test      r8,r8
       je        short M03_L04
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L04
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L04
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
       jmp       near ptr M03_L04
M03_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF9104C66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 325
```
```assembly
; System.Data.DataTableReader.GetName(Int32)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       cmp       byte ptr [rcx+38],0
       je        short M04_L00
       cmp       byte ptr [rcx+3E],0
       jne       short M04_L01
       cmp       byte ptr [rcx+3C],0
       jne       short M04_L02
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF910B67480]; System.Data.DataColumnCollection.get_Item(Int32)
       mov       rax,[rax+20]
       add       rsp,20
       pop       rbp
       ret
M04_L00:
       mov       ecx,0CAF0
       mov       rdx,7FF9108AC210
       call      qword ptr [7FF9104CF228]
       mov       rcx,rax
       call      qword ptr [7FF910C66520]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M04_L01:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C664F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M04_L02:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C66508]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FF910C66688]
       mov       ecx,846B
       mov       rdx,7FF9108AC210
       call      qword ptr [7FF9104CF228]
       mov       rcx,rax
       call      qword ptr [7FF910C666A0]
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
       je        short M05_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF970169D30
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
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20C9BF10008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF910404000
       call      qword ptr [7FF9104CF228]
       mov       rbx,rax
       call      qword ptr [7FF910C66178]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91075E760]
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
       jne       short M06_L01
       mov       r14d,4
M06_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M06_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF910AE7198]
       int       3
M06_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M06_L00
M06_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M06_L08
       test      r14d,r14d
       jg        short M06_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M06_L04
M06_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L08
M06_L04:
       mov       rdx,7FF910C1E4A0
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M06_L03
M06_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+60]
       test      rax,rax
       je        short M06_L09
       mov       rcx,rax
M06_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M06_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FF9104CF5A0]; System.Array.Copy(System.Array, System.Array, Int32)
M06_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M06_L08:
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
M06_L09:
       mov       rdx,7FF910C1E4B0
       call      qword ptr [7FF9104CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L06
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
       jg        near ptr M07_L04
       cmp       eax,esi
       jl        near ptr M07_L04
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M07_L01
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M07_L05
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M07_L06
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M07_L00:
       cmp       ebp,edx
       ja        near ptr M07_L11
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       mov       [rbx+18],edx
M07_L01:
       sub       esi,ebp
       mov       edx,[rbx+1C]
       lea       ecx,[rsi+rdx]
       mov       eax,[rbx+18]
       add       ecx,eax
       cmp       ecx,[rbx+20]
       jg        near ptr M07_L07
       cmp       ecx,esi
       jl        near ptr M07_L07
       add       edx,eax
       mov       ecx,edx
       mov       eax,1F40
       cmp       ecx,1F40
       cmovg     ecx,eax
       cmp       esi,ecx
       cmovge    ecx,esi
       add       edx,ecx
       cmp       edx,ecx
       jl        near ptr M07_L08
       cmp       ecx,400
       jge       near ptr M07_L09
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
M07_L02:
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
       je        near ptr M07_L10
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M07_L03:
       cmp       esi,r8d
       ja        near ptr M07_L11
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FF910404000
       call      qword ptr [7FF9104CF228]
       mov       rsi,rax
       call      qword ptr [7FF910C663B8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF91075E760]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L05:
       test      ecx,ecx
       jne       short M07_L06
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M07_L00
M07_L06:
       call      qword ptr [7FF91069F228]
       int       3
M07_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FF910404000
       call      qword ptr [7FF9104CF228]
       mov       rsi,rax
       call      qword ptr [7FF910C663D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF91075E760]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L08:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF910C663E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L09:
       xor       edx,edx
       call      qword ptr [7FF910AEF360]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
       jmp       near ptr M07_L02
M07_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M07_L03
M07_L11:
       call      qword ptr [7FF91097DCB0]
       int       3
; Total bytes of code 625
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
       call      qword ptr [7FF96FF4E7B0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF96FF33FD8]
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
       jl        short M09_L01
       cmp       esi,[rbx+20]
       jg        short M09_L02
       test      esi,esi
       jne       near ptr M09_L03
       cmp       qword ptr [rbx+10],0
       jne       short M09_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M09_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M09_L01:
       mov       ecx,3AD
       mov       rdx,7FF910404000
       call      qword ptr [7FF9104CF228]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FF910BEE490]
       int       3
M09_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF910404000
       call      qword ptr [7FF9104CF228]
       mov       rsi,rax
       call      qword ptr [7FF910C663D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF91075E760]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,esi
       sub       r8d,ecx
       test      r8d,r8d
       jle       short M09_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF910C667D8]
       jmp       near ptr M09_L00
M09_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF910C667F0]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M09_L09
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
       jge       short M09_L07
       cmp       ecx,400
       jge       short M09_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M09_L06
M09_L05:
       xor       edx,edx
       call      qword ptr [7FF910AEF360]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M09_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FF9104CF5A0]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L08
M09_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M09_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M09_L09:
       sub       esi,[rdi+1C]
       mov       [rbx+18],esi
       jmp       near ptr M09_L00
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
       jne       near ptr M10_L10
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M10_L11
       cmp       dword ptr [rbx+20],0
       jl        short M10_L02
       cmp       qword ptr [rbx+10],0
       jne       near ptr M10_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M10_L00:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M10_L13
       lea       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M10_L12
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FF970103270
       test      rax,rax
       jne       near ptr M10_L13
M10_L01:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF910404000
       call      qword ptr [7FF9104CF228]
       mov       rsi,rax
       call      qword ptr [7FF910C663D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF91075E760]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M10_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M10_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF910C667D8]
       jmp       near ptr M10_L00
M10_L04:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF910C667F0]
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
       call      qword ptr [7FF910AEF360]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M10_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FF9104CF5A0]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       ecx,[rdi+1C]
       neg       ecx
       mov       [rbx+18],ecx
       jmp       near ptr M10_L00
M10_L10:
       mov       rdx,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       jne       near ptr M10_L00
M10_L11:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L12:
       call      qword ptr [7FF910C659B0]
       int       3
M10_L13:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M10_L14
       mov       rcx,[rsi+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF910C67C00]
       jmp       near ptr M10_L01
M10_L14:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M10_L11
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
       je        near ptr M11_L09
M11_L00:
       cmp       byte ptr [rbx+38],0
       je        near ptr M11_L10
       cmp       byte ptr [rbx+3E],0
       jne       near ptr M11_L11
       cmp       byte ptr [rbx+3C],0
       jne       near ptr M11_L12
       cmp       byte ptr [rbx+3A],0
       jne       near ptr M11_L13
       mov       esi,[rbx+34]
       mov       r8,[rbx+18]
       mov       r8,[r8+28]
       mov       rdi,[r8+10]
       mov       r8d,[rdi+28]
       lea       ecx,[r8-2]
       cmp       esi,ecx
       jge       near ptr M11_L14
       inc       esi
       mov       [rbx+34],esi
       mov       ecx,esi
       test      ecx,ecx
       jl        near ptr M11_L15
       dec       r8d
       cmp       r8d,ecx
       jle       near ptr M11_L15
       cmp       dword ptr [rdi+2C],0
       jne       near ptr M11_L16
       mov       eax,[rdi+20]
       lea       r8d,[rsi+1]
       test      eax,eax
       jne       short M11_L03
       jmp       near ptr M11_L04
M11_L01:
       mov       eax,[rdx+10]
       sub       r8d,ecx
M11_L02:
       test      eax,eax
       je        near ptr M11_L04
M11_L03:
       mov       rcx,[rdi+8]
       mov       rdx,rcx
       mov       r10d,eax
       sar       r10d,10
       mov       r9d,[rdx+8]
       cmp       r10d,r9d
       jae       near ptr M11_L22
       mov       rdx,[rdx+r10*8+10]
       mov       rdx,[rdx+8]
       movzx     r10d,ax
       cmp       r10d,[rdx+8]
       jae       near ptr M11_L22
       lea       r10,[r10+r10*4]
       lea       rdx,[rdx+r10*8+10]
       mov       r10d,[rdx+0C]
       mov       r11d,r10d
       sar       r11d,10
       cmp       r11d,r9d
       jae       near ptr M11_L22
       mov       r9d,r11d
       mov       rcx,[rcx+r9*8+10]
       mov       rcx,[rcx+8]
       movzx     r9d,r10w
       cmp       r9d,[rcx+8]
       jae       near ptr M11_L22
       lea       r9,[r9+r9*4]
       mov       ecx,[rcx+r9*8+2C]
       inc       ecx
       cmp       r8d,ecx
       jl        near ptr M11_L08
       cmp       ecx,r8d
       jl        near ptr M11_L01
M11_L04:
       xor       r8d,r8d
       mov       [rsp+28],r8d
M11_L05:
       test      eax,eax
       je        near ptr M11_L17
       mov       rcx,[rdi+8]
       mov       edx,eax
       sar       edx,10
       cmp       edx,[rcx+8]
       jae       near ptr M11_L22
       mov       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx+8]
       movzx     edx,ax
       cmp       edx,[rcx+8]
       jae       near ptr M11_L22
       movzx     edx,ax
       lea       rdx,[rdx+rdx*4]
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
M11_L06:
       mov       rcx,[rbx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF910B6E790]; System.Data.DataRow.get_RowState()
       cmp       eax,8
       je        near ptr M11_L19
       cmp       byte ptr [rbx+3B],0
       jne       near ptr M11_L21
M11_L07:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L08:
       mov       eax,r10d
       jmp       near ptr M11_L02
M11_L09:
       mov       byte ptr [rbx+3D],1
       jmp       near ptr M11_L00
M11_L10:
       mov       ecx,0C8B0
       mov       rdx,7FF9108AC210
       call      qword ptr [7FF9104CF228]
       mov       rcx,rax
       call      qword ptr [7FF910C66520]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M11_L11:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C664F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M11_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C66508]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M11_L13:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L14:
       mov       byte ptr [rbx+3A],1
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M11_L13
       call      qword ptr [7FF910BE7BA0]; System.Data.DataTableReaderListener.UnSubscribeEvents()
       jmp       short M11_L13
M11_L15:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF910BE6610]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C664F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M11_L16:
       lea       r8,[rsp+28]
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF910C67750]
       jmp       near ptr M11_L05
M11_L17:
       cmp       dword ptr [rdi+30],2
       jne       short M11_L18
       mov       ecx,esi
       call      qword ptr [7FF910C67768]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M11_L18:
       mov       ecx,0D
       call      qword ptr [7FF910C67780]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M11_L19:
       inc       dword ptr [rbx+34]
       mov       edx,[rbx+34]
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+10]
       mov       ecx,[rcx+28]
       dec       ecx
       cmp       edx,ecx
       je        short M11_L20
       mov       edx,[rbx+34]
       mov       rcx,rbx
       call      qword ptr [7FF910BE6820]; System.Data.DataTableReader.ValidateRow(Int32)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       mov       edx,[rbx+34]
       mov       rdi,[rcx+10]
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FF910BE6838]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].GetNodeByIndex(Int32)
       mov       [rsp+20],rax
       mov       rcx,rdi
       mov       edx,[rsp+20]
       call      qword ptr [7FF910C67BB8]
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M11_L06
M11_L20:
       mov       byte ptr [rbx+3A],1
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        near ptr M11_L13
       call      qword ptr [7FF910BE7BA0]; System.Data.DataTableReaderListener.UnSubscribeEvents()
       jmp       near ptr M11_L13
M11_L21:
       mov       byte ptr [rbx+3B],0
       jmp       near ptr M11_L07
M11_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 790
```
```assembly
; System.Data.DataTableReader.GetFieldType(Int32)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       cmp       byte ptr [rcx+38],0
       je        short M12_L00
       cmp       byte ptr [rcx+3E],0
       jne       short M12_L01
       cmp       byte ptr [rcx+3C],0
       jne       short M12_L02
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF910B67480]; System.Data.DataColumnCollection.get_Item(Int32)
       mov       rax,[rax+28]
       add       rsp,20
       pop       rbp
       ret
M12_L00:
       mov       ecx,0CA7E
       mov       rdx,7FF9108AC210
       call      qword ptr [7FF9104CF228]
       mov       rcx,rax
       call      qword ptr [7FF910C66520]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L01:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C664F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L02:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C66508]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FF910C66688]
       mov       ecx,846B
       mov       rdx,7FF9108AC210
       call      qword ptr [7FF9104CF228]
       mov       rcx,rax
       call      qword ptr [7FF910C666A0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 188
```
```assembly
; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       cmp       r8d,8
       jl        near ptr M13_L04
       mov       rax,rcx
       cmp       r8d,10
       jle       short M13_L03
       vmovd     xmm0,edx
       vpbroadcastb ymm0,xmm0
       cmp       r8d,20
       jg        near ptr M13_L12
M13_L00:
       add       r8d,0FFFFFFF0
       movsxd    rdx,r8d
       lea       rdx,[rcx+rdx*2]
       cmp       rax,rdx
       cmova     rax,rdx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rdx]
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       jne       near ptr M13_L15
M13_L01:
       mov       eax,0FFFFFFFF
M13_L02:
       vzeroupper
       ret
M13_L03:
       vmovd     xmm0,edx
       vpbroadcastb xmm0,xmm0
       lea       eax,[r8-8]
       movsxd    r8,eax
       lea       rax,[rcx+r8*2]
       cmp       rcx,rax
       mov       rdx,rcx
       cmova     rdx,rax
       vmovups   xmm1,[rdx]
       vpackuswb xmm1,xmm1,[rax]
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        short M13_L01
       jmp       near ptr M13_L17
M13_L04:
       xor       r10d,r10d
       cmp       r8d,4
       jl        short M13_L05
       add       r8d,0FFFFFFFC
       movsx     r10,word ptr [rcx]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M13_L07
       movsx     rax,word ptr [rcx+2]
       cmp       eax,r9d
       je        short M13_L08
       movsx     rax,word ptr [rcx+4]
       cmp       eax,r9d
       je        short M13_L09
       movsx     rax,word ptr [rcx+6]
       cmp       eax,r9d
       je        short M13_L10
       mov       r10d,4
M13_L05:
       test      r8d,r8d
       jle       near ptr M13_L01
       movsx     r9,dx
M13_L06:
       dec       r8d
       movsx     rax,word ptr [rcx+r10*2]
       cmp       eax,r9d
       je        short M13_L11
       inc       r10
       test      r8d,r8d
       jg        short M13_L06
       jmp       near ptr M13_L01
M13_L07:
       xor       eax,eax
       vzeroupper
       ret
M13_L08:
       mov       eax,1
       vzeroupper
       ret
M13_L09:
       mov       eax,2
       vzeroupper
       ret
M13_L10:
       mov       eax,3
       jmp       near ptr M13_L02
M13_L11:
       mov       eax,r10d
       jmp       near ptr M13_L02
M13_L12:
       lea       edx,[r8-20]
       movsxd    rdx,edx
       lea       rdx,[rax+rdx*2]
M13_L13:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpcmpeqb  ymm1,ymm1,ymm0
       vptest    ymm1,ymm1
       jne       short M13_L14
       add       rax,40
       cmp       rax,rdx
       jb        short M13_L13
       jmp       near ptr M13_L00
M13_L14:
       sub       rax,rcx
       shr       rax,1
       vpermq    ymm0,ymm1,0D8
       vpmovmskb ecx,ymm0
       tzcnt     ecx,ecx
       add       eax,ecx
       jmp       near ptr M13_L02
M13_L15:
       vpermq    ymm0,ymm0,0D8
       vpmovmskb r8d,ymm0
       tzcnt     r8d,r8d
       cmp       r8d,10
       jl        short M13_L16
       mov       rax,rdx
       add       r8d,0FFFFFFF0
M13_L16:
       sub       rax,rcx
       shr       rax,1
       add       eax,r8d
       jmp       near ptr M13_L02
M13_L17:
       vpmovmskb r8d,xmm0
       tzcnt     r8d,r8d
       cmp       r8d,8
       jl        short M13_L18
       mov       rdx,rax
       add       r8d,0FFFFFFF8
M13_L18:
       sub       rdx,rcx
       shr       rdx,1
       lea       eax,[rdx+r8]
       jmp       near ptr M13_L02
; Total bytes of code 436
```
```assembly
; System.Globalization.CompareInfo.IndexOfOrdinalHelper(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions, Int32*, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       [rbp+10],rcx
       mov       esi,r9d
       mov       rcx,[r8]
       mov       edi,[r8+8]
       mov       rax,[rdx]
       mov       r14d,[rdx+8]
       mov       [rbp-40],rax
       mov       r15,rax
       mov       [rbp-48],rcx
       mov       r13,rcx
       mov       r8,1CC07002230
       mov       r8,[r8]
       mov       rdx,rcx
       mov       r10d,edi
       add       r8,8
       mov       r9,rdx
       cmp       r10d,8
       jge       near ptr M14_L08
       mov       r10d,edi
       lea       rdx,[r9+r10*2]
       cmp       r9,rdx
       je        short M14_L01
M14_L00:
       movzx     ecx,word ptr [r9]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       ecx,100
       jge       near ptr M14_L07
       cmp       [r10],r10b
       mov       r11d,ecx
       sar       r11d,5
       mov       r10d,[r10+r11*4]
       bt        r10d,ecx
       jae       near ptr M14_L07
       add       r9,2
       cmp       r9,rdx
       jne       short M14_L00
M14_L01:
       cmp       edi,r14d
       jg        near ptr M14_L12
       cmp       byte ptr [rbp+38],0
       je        near ptr M14_L13
       xor       r8d,r8d
       mov       eax,r14d
       sub       eax,edi
       inc       eax
       mov       ecx,1
M14_L02:
       cmp       r8d,eax
       je        short M14_L06
M14_L03:
       xor       edx,edx
       mov       r10d,r8d
       test      edi,edi
       jle       near ptr M14_L15
M14_L04:
       movsxd    r9,r10d
       movzx     r9d,word ptr [r15+r9*2]
       movsxd    r11,edx
       movzx     r11d,word ptr [r13+r11*2]
       cmp       r9d,80
       jge       short M14_L07
       mov       r12d,r9d
       mov       rbx,7FF96F2D9AD0
       cmp       byte ptr [rbx+r12],0
       jne       short M14_L07
       cmp       r9d,r11d
       je        near ptr M14_L14
       lea       edx,[r14-1]
       cmp       r10d,edx
       jge       short M14_L05
       movsxd    r10,r10d
       cmp       word ptr [r15+r10*2+2],80
       jae       short M14_L07
M14_L05:
       add       r8d,ecx
       cmp       r8d,eax
       jne       short M14_L03
M14_L06:
       mov       eax,0FFFFFFFF
       vzeroupper
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M14_L07:
       cmp       byte ptr [rbp+38],0
       je        near ptr M14_L19
       jmp       near ptr M14_L18
M14_L08:
       cmp       r10d,10
       jle       near ptr M14_L11
       vmovups   ymm0,[r8]
       cmp       r10d,20
       jle       short M14_L10
       add       r10d,0FFFFFFE0
       movsxd    r8,r10d
       lea       rcx,[rdx+r8*2]
M14_L09:
       vmovups   ymm1,[r9]
       vpackuswb ymm1,ymm1,[r9+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FF910CA4900]
       vbroadcastsd ymm3,qword ptr [7FF910CA4920]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M14_L07
       add       r9,40
       cmp       r9,rcx
       jb        short M14_L09
M14_L10:
       lea       r8d,[rdi-10]
       movsxd    r8,r8d
       lea       r8,[rdx+r8*2]
       cmp       r9,r8
       mov       rcx,r9
       cmova     rcx,r8
       vmovups   ymm1,[rcx]
       vpackuswb ymm1,ymm1,[r8]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FF910CA4900]
       vbroadcastsd ymm2,qword ptr [7FF910CA4920]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M14_L01
       jmp       near ptr M14_L07
M14_L11:
       vmovups   xmm0,[r8]
       lea       r8d,[rdi-8]
       movsxd    r8,r8d
       lea       r8,[rcx+r8*2]
       cmp       rcx,r8
       cmova     rcx,r8
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[r8]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FF910CA4900]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF910CA4920]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M14_L01
       jmp       near ptr M14_L07
M14_L12:
       mov       r8,1CC07002230
       mov       r8,[r8]
       add       r8,8
       mov       rcx,rax
       mov       edx,r14d
       call      qword ptr [7FF910BE6A18]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M14_L07
       jmp       near ptr M14_L06
M14_L13:
       mov       r8d,r14d
       sub       r8d,edi
       mov       eax,0FFFFFFFF
       mov       ecx,0FFFFFFFF
       jmp       near ptr M14_L02
M14_L14:
       inc       edx
       inc       r10d
       cmp       edx,edi
       jl        near ptr M14_L04
M14_L15:
       cmp       r10d,r14d
       jge       short M14_L16
       movsxd    rcx,r10d
       cmp       word ptr [r15+rcx*2],80
       jae       near ptr M14_L07
M14_L16:
       mov       r15,[rbp+30]
       test      r15,r15
       je        short M14_L17
       mov       [r15],edi
M14_L17:
       mov       eax,r8d
       jmp       short M14_L20
M14_L18:
       mov       [rsp+20],r14d
       mov       [rsp+28],esi
       mov       r12,[rbp+30]
       mov       [rsp+30],r12
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+20]
       mov       rdx,r13
       mov       r8d,edi
       mov       r9,r15
       vzeroupper
       call      00007FF9104B8D50
       jmp       short M14_L20
M14_L19:
       mov       [rsp+20],r14d
       mov       [rsp+28],esi
       mov       r12,[rbp+30]
       mov       [rsp+30],r12
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+20]
       mov       rdx,r13
       mov       r8d,edi
       mov       r9,r15
       vzeroupper
       call      00007FF9104B8D68
M14_L20:
       nop
       vzeroupper
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 857
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      r8d,r8d
       je        short M15_L01
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        short M15_L03
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M15_L02
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M15_L00:
       mov       [rbx+18],esi
M15_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M15_L02:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M15_L00
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M15_L00
M15_L03:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF9107577F8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
; Total bytes of code 102
```
```assembly
; System.Data.DataTableReader.ValidateReader()
       sub       rsp,28
       cmp       byte ptr [rcx+3E],0
       jne       short M16_L00
       cmp       byte ptr [rcx+3C],0
       jne       short M16_L01
       add       rsp,28
       ret
M16_L00:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C664F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M16_L01:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C66508]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 67
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
       jbe       short M17_L01
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M17_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M17_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FF910757C78]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M17_L00
; Total bytes of code 60
```
```assembly
; System.Data.DataTableReader.get_FieldCount()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+38],0
       je        short M18_L00
       mov       rcx,rbx
       call      qword ptr [7FF910BE6808]; System.Data.DataTableReader.ValidateReader()
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax+30]
M18_L00:
       mov       ecx,0C8E0
       mov       rdx,7FF9108AC210
       call      qword ptr [7FF9104CF228]
       mov       rcx,rax
       call      qword ptr [7FF910C66520]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 90
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
       je        near ptr M19_L06
       cmp       byte ptr [rbx+3F],0
       jne       near ptr M19_L07
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M19_L08
       cmp       qword ptr [rbx+18],0
       je        near ptr M19_L08
       cmp       [rcx],ecx
       call      qword ptr [7FF910B6E790]; System.Data.DataRow.get_RowState()
       cmp       eax,8
       je        near ptr M19_L09
       mov       rcx,[rbx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF910B6E790]; System.Data.DataRow.get_RowState()
       cmp       eax,1
       je        near ptr M19_L09
       cmp       byte ptr [rbx+3B],0
       jne       near ptr M19_L09
       mov       ecx,[rbx+34]
       test      ecx,ecx
       jl        near ptr M19_L10
       mov       rdx,[rbx+18]
       mov       rdx,[rdx+28]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+28]
       dec       edx
       cmp       edx,ecx
       jle       near ptr M19_L10
       cmp       byte ptr [rbx+3E],0
       jne       near ptr M19_L11
       cmp       byte ptr [rbx+3C],0
       jne       near ptr M19_L12
       mov       rbx,[rbx+20]
       mov       rcx,[rbx+10]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FF910B67480]; System.Data.DataColumnCollection.get_Item(Int32)
       cmp       dword ptr [rbx+40],0FFFFFFFF
       jne       short M19_L01
       mov       edx,[rbx+3C]
       cmp       edx,0FFFFFFFF
       je        short M19_L02
M19_L00:
       mov       rcx,[rax+60]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M19_L05
M19_L01:
       mov       edx,[rbx+40]
       jmp       short M19_L00
M19_L02:
       cmp       dword ptr [rbx+38],0FFFFFFFF
       je        short M19_L03
       mov       rcx,20C9BF21318
       call      qword ptr [7FF910C665B0]
       mov       rbx,rax
       mov       rcx,offset MT_System.Data.DeletedRowInaccessibleException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF910C66658]
       mov       rcx,1CC07001EE8
       mov       rcx,[rcx]
       mov       r9,rsi
       mov       rdx,7FF910BFFC50
       mov       r8,20C9BF21498
       call      qword ptr [7FF910BE68B0]
       jmp       short M19_L04
M19_L03:
       mov       rcx,20C9BF212C8
       call      qword ptr [7FF910C665B0]
       mov       rsi,rax
       mov       rcx,offset MT_System.Data.RowNotInTableException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF910C66670]
       mov       rcx,1CC07001EE8
       mov       rcx,[rcx]
       mov       r9,rbx
       mov       rdx,7FF910BFFC50
       mov       r8,20C9BF21498
       call      qword ptr [7FF910BE68B0]
       mov       rsi,rbx
M19_L04:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M19_L05:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M19_L06:
       mov       ecx,0CB50
       mov       rdx,7FF9108AC210
       call      qword ptr [7FF9104CF228]
       mov       rcx,rax
       call      qword ptr [7FF910C66520]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M19_L07:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C66610]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M19_L08:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF910BE6610]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C664F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M19_L09:
       call      qword ptr [7FF910C66628]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M19_L10:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF910BE6610]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C664F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M19_L11:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C664F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M19_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C66508]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FF910C66688]
       mov       ecx,846B
       mov       rdx,7FF9108AC210
       call      qword ptr [7FF9104CF228]
       mov       rcx,rax
       call      qword ptr [7FF910C666A0]
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
       je        near ptr M20_L06
       cmp       byte ptr [rbx+3F],0
       jne       near ptr M20_L07
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M20_L08
       cmp       qword ptr [rbx+18],0
       je        near ptr M20_L08
       cmp       [rcx],ecx
       call      qword ptr [7FF910B6E790]; System.Data.DataRow.get_RowState()
       cmp       eax,8
       je        near ptr M20_L09
       mov       rcx,[rbx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF910B6E790]; System.Data.DataRow.get_RowState()
       cmp       eax,1
       je        near ptr M20_L09
       cmp       byte ptr [rbx+3B],0
       jne       near ptr M20_L09
       mov       ecx,[rbx+34]
       test      ecx,ecx
       jl        near ptr M20_L10
       mov       rdx,[rbx+18]
       mov       rdx,[rdx+28]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+28]
       dec       edx
       cmp       edx,ecx
       jle       near ptr M20_L10
       cmp       byte ptr [rbx+3E],0
       jne       near ptr M20_L11
       cmp       byte ptr [rbx+3C],0
       jne       near ptr M20_L12
       mov       rbx,[rbx+20]
       mov       rcx,[rbx+10]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FF910B67480]; System.Data.DataColumnCollection.get_Item(Int32)
       cmp       dword ptr [rbx+40],0FFFFFFFF
       jne       short M20_L01
       mov       edx,[rbx+3C]
       cmp       edx,0FFFFFFFF
       je        short M20_L02
M20_L00:
       mov       rcx,[rax+60]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       jmp       near ptr M20_L05
M20_L01:
       mov       edx,[rbx+40]
       jmp       short M20_L00
M20_L02:
       cmp       dword ptr [rbx+38],0FFFFFFFF
       je        short M20_L03
       mov       rcx,20C9BF21318
       call      qword ptr [7FF910C665B0]
       mov       rbx,rax
       mov       rcx,offset MT_System.Data.DeletedRowInaccessibleException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF910C66658]
       mov       rcx,1CC07001EE8
       mov       rcx,[rcx]
       mov       r9,rsi
       mov       rdx,7FF910BFFC50
       mov       r8,20C9BF21498
       call      qword ptr [7FF910BE68B0]
       jmp       short M20_L04
M20_L03:
       mov       rcx,20C9BF212C8
       call      qword ptr [7FF910C665B0]
       mov       rsi,rax
       mov       rcx,offset MT_System.Data.RowNotInTableException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF910C66670]
       mov       rcx,1CC07001EE8
       mov       rcx,[rcx]
       mov       r9,rbx
       mov       rdx,7FF910BFFC50
       mov       r8,20C9BF21498
       call      qword ptr [7FF910BE68B0]
       mov       rsi,rbx
M20_L04:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M20_L05:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M20_L06:
       mov       ecx,0CB2A
       mov       rdx,7FF9108AC210
       call      qword ptr [7FF9104CF228]
       mov       rcx,rax
       call      qword ptr [7FF910C66520]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M20_L07:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C66610]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M20_L08:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF910BE6610]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C664F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M20_L09:
       call      qword ptr [7FF910C66628]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M20_L10:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF910BE6610]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C664F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M20_L11:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C664F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M20_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C66508]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FF910C66688]
       mov       ecx,846B
       mov       rdx,7FF9108AC210
       call      qword ptr [7FF9104CF228]
       mov       rcx,rax
       call      qword ptr [7FF910C666A0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 677
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       sub       rsp,28
       mov       r8,rdx
       inc       dword ptr [rcx+14]
       mov       rax,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [rax+8],edx
       jbe       short M21_L00
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       mov       edx,edx
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       ret
M21_L00:
       mov       rdx,r8
       add       rsp,28
       jmp       qword ptr [7FF9104C71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
; Total bytes of code 59
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF96FF4CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M22_L01
       cmp       [rax],ecx
       jle       short M22_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M22_L03
M22_L00:
       add       rsp,20
       pop       rbx
       ret
M22_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M22_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M22_L00
M22_L02:
       cmp       [rax+4],edx
       jle       short M22_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M22_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M22_L03
       jmp       short M22_L00
M22_L03:
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
       call      qword ptr [7FF96FF347E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF96FF4B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M23_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF96FF4CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M23_L00:
       call      qword ptr [7FF96FF4A3D0]
       int       3
; Total bytes of code 61
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
       je        near ptr M24_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FF96FF4C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FF96FF4B9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M24_L01
       mov       rcx,rax
       call      qword ptr [7FF96FF4CBB8]
       test      eax,eax
       jne       short M24_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FF96FF4CBC8]
M24_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FF96FF5AB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M24_L04
       mov       rbx,[rbp-18]
       jmp       short M24_L02
M24_L01:
       xor       ecx,ecx
       call      qword ptr [7FF96FF471F0]
       int       3
M24_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FF96FF4CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M24_L03:
       mov       rcx,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       mov       rcx,[rcx]
       call      qword ptr [7FF96FF471F0]
       int       3
M24_L04:
       call      M24_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF96FF4B4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M24_L05
       xor       esi,esi
       jmp       short M24_L06
M24_L05:
       call      qword ptr [7FF96FF3E970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FF96FF4B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M24_L06:
       test      rsi,rsi
       jne       short M24_L07
       call      qword ptr [7FF96FF3E978]
       mov       rbx,rax
       call      qword ptr [7FF96FF4B8B8]
       mov       r9,rax
       mov       rdx,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FF96FF4BA18]
       mov       rcx,rbx
       call      qword ptr [7FF96FF33FC0]; CORINFO_HELP_THROW
       int       3
M24_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF96FF4C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M24_L08
       xor       ecx,ecx
       call      qword ptr [7FF96FF471F0]
       int       3
M24_L08:
       mov       rcx,rax
       call      qword ptr [7FF96FF4CBB8]
       test      eax,eax
       jne       short M24_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FF96FF4CBC8]
M24_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FF96FF5AB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FF96FF4CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M24_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M24_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FF96FF4CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M24_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M24_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FF96FF4CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M24_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
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
       je        near ptr M25_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M25_L02
       test      rsi,rsi
       je        near ptr M25_L01
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M25_L01
       test      rdi,rdi
       je        near ptr M25_L00
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M25_L00
       mov       r13d,ebp
       mov       r12d,r14d
       add       r12,r13
       mov       eax,r15d
       add       r12,rax
       cmp       r12,7FFFFFFF
       jg        near ptr M25_L03
       mov       rcx,7FF910D1C2C8
       call      CORINFO_HELP_COUNTPROFILE32
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.String
       call      00007FF970169D30
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[rbx+rcx*2]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M25_L00:
       mov       rcx,7FF910D1C2C0
       call      CORINFO_HELP_COUNTPROFILE32
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
       jmp       qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
M25_L01:
       mov       rcx,7FF910D1C2BC
       call      CORINFO_HELP_COUNTPROFILE32
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
       jmp       qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
M25_L02:
       mov       rcx,7FF910D1C2B8
       call      CORINFO_HELP_COUNTPROFILE32
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
       jmp       qword ptr [7FF9104CD9C8]; System.String.Concat(System.String, System.String)
M25_L03:
       mov       rcx,7FF910D1C2C4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF910BEE508]
       int       3
; Total bytes of code 408
```
```assembly
; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       sub       rsp,28
       test      rdx,rdx
       je        short M26_L00
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M26_L00:
       mov       ecx,14
       call      qword ptr [7FF9104CFD50]
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
       call      qword ptr [7FF96FF59A58]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M28_L00
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M28_L00:
       cmp       qword ptr [rdi+10],0
       jne       short M28_L01
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M28_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 91
```
```assembly
; System.Data.DataTableReader.Close()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+38],0
       je        short M29_L01
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M29_L00
       call      qword ptr [7FF910BE7BA0]; System.Data.DataTableReaderListener.UnSubscribeEvents()
M29_L00:
       xor       eax,eax
       mov       [rbx+28],rax
       mov       [rbx+10],rax
       mov       byte ptr [rbx+38],0
M29_L01:
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
       call      qword ptr [7FF96FF34030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF96FF34038]; CORINFO_HELP_JIT_PINVOKE_END
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
       je        near ptr M31_L06
       test      rbx,rbx
       je        near ptr M31_L07
       mov       rcx,[rsi]
       cmp       rcx,[rbx]
       jne       near ptr M31_L07
       cmp       dword ptr [rcx+4],18
       jne       near ptr M31_L07
       cmp       edi,[rsi+8]
       ja        short M31_L07
       cmp       edi,[rbx+8]
       ja        short M31_L07
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       add       rbx,10
       test      dword ptr [rcx],1000000
       je        short M31_L05
       cmp       r8,4000
       jbe       short M31_L00
       mov       rcx,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF910AEF048]
M31_L00:
       mov       rcx,rbx
       call      00007FF9700F9170
       cmp       dword ptr [7FF9704239A0],0
       jne       short M31_L03
M31_L01:
       cmp       dword ptr [7FF9704239A0],0
       jne       short M31_L04
M31_L02:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M31_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M31_L01
M31_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M31_L02
M31_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9104C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M31_L01
M31_L06:
       xor       ebp,ebp
       jmp       short M31_L08
M31_L07:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF910BED530]; System.Array.GetLowerBound(Int32)
       mov       ebp,eax
M31_L08:
       test      rbx,rbx
       jne       short M31_L09
       xor       r9d,r9d
       jmp       short M31_L10
M31_L09:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF910BED530]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
M31_L10:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       call      qword ptr [7FF910BED548]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M31_L01
; Total bytes of code 246
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,148
       vzeroupper
       lea       rbp,[rsp+180]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0F0],ymm4
       vmovdqu   ymmword ptr [rbp-0D0],ymm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0D8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-0A0],rax
       mov       rcx,rsp
       mov       [rbp-0C0],rcx
       mov       rcx,rbp
       mov       [rbp-0B0],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+138]
       mov       r14,rdi
       cmp       [r14],r14b
       mov       rcx,offset MT_System.Data.DataTableReader
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       byte ptr [r15+38],1
       mov       qword ptr [r15+30],0FFFFFFFFFFFFFFFF
       mov       byte ptr [r15+39],1
       mov       rcx,offset MT_System.Data.DataTable[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+30],ecx
       mov       byte ptr [r15+3A],0
       mov       byte ptr [r15+3C],0
       mov       rcx,[r15+8]
       mov       edx,[r15+30]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L66
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+28]
       mov       rcx,[rcx+10]
       mov       ecx,[rcx+28]
       dec       ecx
       test      ecx,ecx
       setg      cl
       mov       [r15+39],cl
       cmp       byte ptr [r15+3E],0
       je        short M00_L00
       mov       byte ptr [r15+3E],0
M00_L00:
       mov       rcx,offset MT_System.Data.DataTableReaderListener
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       cmp       qword ptr [rdi+8],0
       je        short M00_L01
       mov       rcx,rdi
       call      qword ptr [7FF910C17210]; System.Data.DataTableReaderListener.UnSubscribeEvents()
M00_L01:
       mov       rcx,offset MT_System.WeakReference
       call      CORINFO_HELP_NEWFAST
       mov       r14,rax
       mov       rcx,r15
       xor       edx,edx
       call      00007FF970104E90
       test      rax,rax
       je        near ptr M00_L64
M00_L02:
       mov       [r14+8],rax
       cmp       qword ptr [7FF91043B020],0
       jne       near ptr M00_L65
M00_L03:
       xor       edx,edx
M00_L04:
       test      rdx,rdx
       je        short M00_L05
       lea       rcx,[r14+8]
       call      qword ptr [7FF910D448A0]
M00_L05:
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[r15+18]
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       je        short M00_L06
       mov       rcx,rdi
       call      qword ptr [7FF910C15CE0]; System.Data.DataTableReaderListener.SubscribeEvents()
M00_L06:
       lea       rcx,[r15+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-0F8],r15
       mov       [rbp-100],r15
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,29EDCC00368
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-108],rdi
       mov       rcx,r15
       call      qword ptr [7FF910C24428]; System.Data.DataTableReader.Read()
       test      eax,eax
       mov       rdi,[rbp-108]
       jne       short M00_L09
M00_L07:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF910996700]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       mov       [rbp-98],rsi
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       lea       r8,[rbp-98]
       mov       rdx,7FF910C2DAB8
       cmp       [rcx],ecx
       call      qword ptr [7FF910C17318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       jmp       near ptr M00_L63
M00_L08:
       mov       rcx,[rbp-110]
       xor       edx,edx
       call      qword ptr [7FF910B94F18]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       rdx,[rbp-110]
       call      qword ptr [7FF910B94F30]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       mov       rcx,r15
       call      qword ptr [7FF910C24428]; System.Data.DataTableReader.Read()
       test      eax,eax
       je        short M00_L07
M00_L09:
       mov       rcx,29EF2C00210
       mov       r14,[rcx]
       mov       [rbp-140],r14
       mov       r13,r14
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       rcx,[r13+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       mov       r14,[rbp-140]
       je        near ptr M00_L60
       lea       rcx,[r13+20]
       mov       r8,[rbp-40]
       test      rcx,rcx
       je        near ptr M00_L62
       xor       edx,edx
       call      00007FF970103270
       cmp       rax,[rbp-40]
       jne       near ptr M00_L60
M00_L10:
       mov       r13,[rbp-40]
M00_L11:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-110],r13
       xor       r13d,r13d
       jmp       near ptr M00_L17
M00_L12:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r12,rax
M00_L13:
       mov       [rbp-118],r12
       mov       rcx,r15
       mov       edx,r13d
       call      qword ptr [7FF910C24318]; System.Data.DataTableReader.GetFieldType(Int32)
       mov       rcx,2DF71C30020
       cmp       rax,rcx
       mov       r15,[rbp-100]
       je        near ptr M00_L18
       mov       r12,[rbp-118]
M00_L14:
       mov       rcx,[rbp-110]
       mov       rdx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF910787AF8]; System.Text.StringBuilder.Append(System.String)
M00_L15:
       mov       rcx,r15
       call      qword ptr [7FF910C242A8]; System.Data.DataTableReader.get_FieldCount()
       sub       eax,1
       jo        near ptr M00_L55
       cmp       r13d,eax
       jge       short M00_L16
       mov       rcx,[rbp-110]
       mov       edx,2C
       cmp       [rcx],ecx
       call      qword ptr [7FF910787A50]; System.Text.StringBuilder.Append(Char)
M00_L16:
       add       r13d,1
       jo        near ptr M00_L55
M00_L17:
       mov       rcx,r15
       call      qword ptr [7FF910C242A8]; System.Data.DataTableReader.get_FieldCount()
       cmp       r13d,eax
       jge       near ptr M00_L33
       mov       rcx,r15
       mov       edx,r13d
       call      qword ptr [7FF910C24410]; System.Data.DataTableReader.IsDBNull(Int32)
       test      eax,eax
       jne       short M00_L15
       mov       rcx,r15
       mov       edx,r13d
       call      qword ptr [7FF910C243F0]; System.Data.DataTableReader.GetValue(Int32)
       mov       r12,rax
       mov       rcx,offset MT_System.String
       cmp       [r12],rcx
       jne       near ptr M00_L12
       jmp       near ptr M00_L13
M00_L18:
       mov       rax,[rbp-118]
       lea       rcx,[rax+0C]
       mov       [rbp-118],rax
       mov       r8d,[rax+8]
       mov       edx,22
       call      qword ptr [7FF9106CF828]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       cmp       eax,0FFFFFFFF
       jne       near ptr M00_L34
M00_L19:
       mov       r12,[rbp-118]
       cmp       [r12],r12b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L35
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L35
M00_L20:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L21
       mov       rax,29EDCC00190
       mov       rax,[rax]
       test      rax,rax
       jne       short M00_L21
       mov       rax,29EDCC00170
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M00_L36
M00_L21:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rax],rcx
       jne       near ptr M00_L40
       mov       rdx,[rax+8]
       test      rdx,rdx
       je        near ptr M00_L37
M00_L22:
       mov       rax,rdx
M00_L23:
       mov       dword ptr [rbp-44],2C
       cmp       [rax],al
       lea       rdx,[r12+0C]
       mov       [rbp-118],r12
       mov       r8d,[r12+8]
       mov       [rbp-120],rax
       cmp       byte ptr [rax+2C],0
       je        near ptr M00_L56
       mov       r12,[rbp-118]
       mov       [rbp-0DC],r8d
       mov       [rbp-60],rdx
       mov       r10,rdx
       lea       rcx,[rbp-44]
       mov       [rbp-68],rcx
       mov       [rbp-70],r10
       lea       r9,[rbp-44]
       mov       [rbp-78],r9
       mov       rcx,29EF2C00220
       mov       rcx,[rcx]
       add       rcx,8
       lea       r11,[rbp-44]
       lea       rsi,[rbp-44]
       add       rsi,2
       lea       rbx,[rbp-44]
       cmp       rbx,rsi
       je        short M00_L25
M00_L24:
       movzx     ebx,word ptr [r11]
       cmp       [rcx],cl
       lea       rdi,[rcx+20]
       cmp       ebx,100
       mov       [rbp-140],r14
       jge       near ptr M00_L45
       cmp       [rdi],dil
       mov       r14d,ebx
       sar       r14d,5
       mov       edi,[rdi+r14*4]
       bt        edi,ebx
       jae       near ptr M00_L41
       add       r11,2
       cmp       r11,rsi
       je        short M00_L26
       mov       r14,[rbp-140]
       jmp       short M00_L24
M00_L25:
       mov       [rbp-140],r14
M00_L26:
       test      r8d,r8d
       jle       near ptr M00_L46
       mov       ebx,r8d
       sub       ebx,1
       inc       ebx
       xor       esi,esi
       test      ebx,ebx
       je        near ptr M00_L30
M00_L27:
       xor       edi,edi
       mov       r14d,esi
M00_L28:
       movsxd    rcx,r14d
       movzx     edx,word ptr [r10+rcx*2]
       mov       [rbp-7C],edx
       movsxd    rcx,edi
       movzx     r11d,word ptr [r9+rcx*2]
       mov       [rbp-80],r11d
       cmp       edx,80
       jge       near ptr M00_L48
       lea       rcx,[rbp-90]
       call      qword ptr [7FF910D44BD0]; System.Globalization.CompareInfo.get_HighCharTable()
       mov       edx,[rbp-7C]
       cmp       edx,[rbp-88]
       jae       near ptr M00_L54
       mov       rcx,[rbp-90]
       mov       eax,edx
       cmp       byte ptr [rcx+rax],0
       jne       near ptr M00_L47
       cmp       edx,[rbp-80]
       je        near ptr M00_L49
       mov       edi,[rbp-0DC]
       lea       edx,[rdi-1]
       cmp       r14d,edx
       jge       short M00_L29
       movsxd    rdx,r14d
       mov       r14,[rbp-70]
       cmp       word ptr [r14+rdx*2+2],80
       jae       near ptr M00_L50
M00_L29:
       inc       esi
       cmp       esi,ebx
       mov       r9,[rbp-78]
       mov       r10,[rbp-70]
       jne       near ptr M00_L27
M00_L30:
       mov       ebx,0FFFFFFFF
M00_L31:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L32:
       xor       edx,edx
       mov       [rbp-50],rdx
       mov       [rbp-58],rdx
       cmp       ebx,0FFFFFFFF
       jne       near ptr M00_L59
       mov       rdi,[rbp-108]
       mov       r14,[rbp-140]
       jmp       near ptr M00_L14
M00_L33:
       mov       rcx,[rbp-110]
       cmp       [rcx],ecx
       call      qword ptr [7FF91079CB80]; System.Text.StringBuilder.ToString()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9105E3598]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       near ptr M00_L08
M00_L34:
       mov       rcx,r12
       mov       rdx,2DF71C411C8
       mov       r8,2DF71C411E0
       mov       r9d,4
       call      qword ptr [7FF910C15E30]
       mov       r12,rax
       mov       [rbp-118],r12
       jmp       near ptr M00_L19
M00_L35:
       mov       ecx,2
       call      qword ptr [7FF910C1E5C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L20
M00_L36:
       call      qword ptr [7FF9104FD4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       near ptr M00_L21
M00_L37:
       mov       [rbp-128],rax
       mov       rcx,[rax+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L38
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-138],rax
       mov       r8,[rbp-128]
       mov       rdx,[r8+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-138]
       mov       rdx,[rbp-128]
       call      qword ptr [7FF9108743D8]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-138]
       mov       rdx,rax
       jmp       short M00_L39
M00_L38:
       mov       rax,[rbp-128]
       mov       rcx,[rax+40]
       call      qword ptr [7FF9108740F0]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
M00_L39:
       mov       rax,[rbp-128]
       lea       rcx,[rax+8]
       mov       [rbp-130],rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-130]
       mov       rax,rdx
       mov       rdx,rax
       jmp       near ptr M00_L22
M00_L40:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M00_L23
M00_L41:
       mov       [rbp-118],r12
M00_L42:
       mov       r8d,[rbp-0DC]
       mov       [rsp+20],r8d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rax,[rbp-120]
       mov       rcx,[rax+20]
       mov       rdx,r9
       mov       r8d,1
       mov       r9,r10
       mov       rax,7FF9106851A0
       mov       [rbp-0C8],rax
       lea       rax,[M00_L43]
       mov       [rbp-0B8],rax
       lea       rax,[rbp-0D8]
       mov       rsi,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9106851C0]
M00_L43:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF9704239A0],0
       je        short M00_L44
       call      qword ptr [7FF970411648]; CORINFO_HELP_STOP_FOR_GC
M00_L44:
       mov       rcx,[rbp-0D0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-118]
       mov       r15,[rbp-100]
       jmp       near ptr M00_L31
M00_L45:
       mov       [rbp-118],r12
       jmp       near ptr M00_L42
M00_L46:
       mov       rcx,29EF2C00220
       mov       rcx,[rcx]
       mov       [rbp-0F0],rdx
       mov       [rbp-0E8],r8d
       lea       rdx,[rbp-0F0]
       call      qword ptr [7FF91073FD18]; Precode of System.Buffers.AsciiCharSearchValues`2[[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]].ContainsAnyExcept(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       mov       r9,[rbp-78]
       mov       r10,[rbp-70]
       je        near ptr M00_L30
       mov       [rbp-118],r12
       jmp       near ptr M00_L42
M00_L47:
       mov       [rbp-118],r12
       mov       r9,[rbp-78]
       mov       r10,[rbp-70]
       jmp       near ptr M00_L42
M00_L48:
       mov       [rbp-118],r12
       mov       r9,[rbp-78]
       mov       r10,[rbp-70]
       jmp       near ptr M00_L42
M00_L49:
       inc       edi
       inc       r14d
       test      edi,edi
       mov       r9,[rbp-78]
       mov       r10,[rbp-70]
       jle       near ptr M00_L28
       jmp       short M00_L51
M00_L50:
       mov       [rbp-118],r12
       mov       r10,r14
       mov       r9,[rbp-78]
       jmp       near ptr M00_L42
M00_L51:
       mov       r8d,[rbp-0DC]
       cmp       r14d,r8d
       jge       short M00_L52
       movsxd    rdx,r14d
       cmp       word ptr [r10+rdx*2],80
       mov       r10,[rbp-70]
       jae       short M00_L53
M00_L52:
       mov       ebx,esi
       jmp       near ptr M00_L31
M00_L53:
       mov       [rbp-118],r12
       jmp       near ptr M00_L42
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L56:
       mov       [rbp-140],r14
       mov       [rbp-50],rdx
       mov       r9,rdx
       lea       rcx,[rbp-44]
       mov       [rbp-58],rcx
       mov       rax,[rbp-120]
       mov       rcx,[rax+20]
       lea       rdx,[rbp-44]
       mov       [rsp+20],r8d
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FF9106851A0
       mov       [rbp-0C8],rax
       lea       rax,[M00_L57]
       mov       [rbp-0B8],rax
       lea       rax,[rbp-0D8]
       mov       rsi,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9106851C0]
M00_L57:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF9704239A0],0
       je        short M00_L58
       call      qword ptr [7FF970411648]; CORINFO_HELP_STOP_FOR_GC
M00_L58:
       mov       rdx,[rbp-0D0]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       r12,[rbp-118]
       mov       r15,[rbp-100]
       jmp       near ptr M00_L32
M00_L59:
       mov       rdx,r12
       mov       rcx,2DF71C411C8
       mov       r8,2DF71C411C8
       call      qword ptr [7FF9106C5488]; System.String.Concat(System.String, System.String, System.String)
       mov       r12,rax
       mov       rdi,[rbp-108]
       mov       r14,[rbp-140]
       jmp       near ptr M00_L14
M00_L60:
       mov       rcx,[r13+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF910B94DC8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L61
       add       r13,2C
       lock dec  dword ptr [r13]
       jmp       near ptr M00_L10
M00_L61:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r13,rax
       jmp       near ptr M00_L11
M00_L62:
       call      qword ptr [7FF910C1EF28]
       int       3
M00_L63:
       mov       rcx,[rbp-0F8]
       call      qword ptr [7FF910C242E0]; System.Data.DataTableReader.Close()
       nop
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L64:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF910C1EA60]
       jmp       near ptr M00_L02
M00_L65:
       mov       rax,[7FF91043B020]
       mov       rcx,r15
       call      rax
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,r15
       call      qword ptr [7FF910D44888]
       mov       rdx,rax
       jmp       near ptr M00_L04
M00_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       vzeroupper
       mov       rcx,[rbp-110]
       cmp       [rcx],cl
       mov       rcx,[rbp-110]
       xor       edx,edx
       call      qword ptr [7FF910B94F18]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,29EF2C00210
       mov       r14,[rcx]
       mov       rcx,r14
       mov       rdx,[rbp-110]
       call      qword ptr [7FF910B94F30]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       nop
       add       rsp,38
       ret
       sub       rsp,38
       vzeroupper
       mov       rcx,[rbp-0F8]
       call      qword ptr [7FF910C242E0]; System.Data.DataTableReader.Close()
       nop
       add       rsp,38
       ret
; Total bytes of code 2748
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
       mov       rcx,7FF910C11CF8
       mov       [rdi+18],rcx
       mov       rbp,[rsi+40]
M01_L00:
       test      rbp,rbp
       je        near ptr M01_L16
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FF91052AAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       call      00007FF970103270
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
       mov       rcx,7FF910C11CF8
       mov       [rdi+18],rcx
       mov       rbp,[rsi+30]
M01_L03:
       test      rbp,rbp
       je        near ptr M01_L18
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FF91052AAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       call      00007FF970103270
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
       mov       rcx,7FF910C11D70
       mov       [rsi+18],rcx
       mov       rcx,29EDCC01ED0
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
       call      qword ptr [7FF91052AAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       mov       rcx,7FF910C11D70
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
       call      qword ptr [7FF91052AAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       mov       rcx,7FF910C11DB8
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
       call      qword ptr [7FF91052AAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       call      qword ptr [7FF910C1EF28]
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
       mov       rdx,2DF71C422A8
       call      qword ptr [7FF910C1F4E0]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FF910C17768]
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
       mov       rdx,2DF71C42310
       call      qword ptr [7FF910C1F4E0]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FF910C17768]
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
       mov       rdx,2DF71C42378
       call      qword ptr [7FF910C1F4E0]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FF910C17768]
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
       mov       rcx,7FF910C11CF8
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
       call      00007FF970103270
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
       mov       rcx,7FF910C11CF8
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
       call      00007FF970103270
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
       mov       rcx,7FF910C11D70
       mov       [rsi+18],rcx
       mov       rcx,29EDCC01ED0
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
       mov       rcx,7FF910C11D70
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
       mov       rcx,7FF910C11DB8
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
       call      qword ptr [7FF91052AAE8]
       mov       rdx,rax
       jmp       near ptr M02_L01
M02_L17:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L18:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FF91052AAE8]
       mov       rdx,rax
       jmp       near ptr M02_L04
M02_L19:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L20:
       call      qword ptr [7FF910C1EF28]
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
       mov       rdx,2DF71C41070
       call      qword ptr [7FF910C1F4E0]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FF910C17768]
       jmp       near ptr M02_L06
M02_L22:
       mov       rdx,rsi
       call      qword ptr [7FF91052AAE8]
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
       mov       rdx,2DF71C410D0
       call      qword ptr [7FF910C1F4E0]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FF910C17768]
       jmp       near ptr M02_L09
M02_L25:
       mov       rdx,rsi
       call      qword ptr [7FF91052AAE8]
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
       mov       rdx,2DF71C41130
       call      qword ptr [7FF910C1F4E0]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FF910C17768]
       jmp       near ptr M02_L12
M02_L28:
       mov       rdx,rsi
       call      qword ptr [7FF91052AAE8]
       mov       rdx,rax
       jmp       near ptr M02_L13
M02_L29:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 1120
```
```assembly
; System.Data.DataTableReader.Read()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       cmp       byte ptr [rbx+3D],0
       je        near ptr M03_L09
M03_L00:
       cmp       byte ptr [rbx+38],0
       je        near ptr M03_L10
       cmp       byte ptr [rbx+3E],0
       jne       near ptr M03_L11
       cmp       byte ptr [rbx+3C],0
       jne       near ptr M03_L12
       cmp       byte ptr [rbx+3A],0
       jne       near ptr M03_L13
       mov       esi,[rbx+34]
       mov       r8,[rbx+18]
       mov       r8,[r8+28]
       mov       rdi,[r8+10]
       mov       r8d,[rdi+28]
       lea       ecx,[r8-2]
       cmp       esi,ecx
       jge       near ptr M03_L14
       inc       esi
       mov       [rbx+34],esi
       mov       ecx,esi
       test      ecx,ecx
       jl        near ptr M03_L15
       dec       r8d
       cmp       r8d,ecx
       jle       near ptr M03_L15
       cmp       dword ptr [rdi+2C],0
       jne       near ptr M03_L16
       mov       eax,[rdi+20]
       lea       r8d,[rsi+1]
       test      eax,eax
       jne       short M03_L03
       jmp       near ptr M03_L04
M03_L01:
       mov       eax,[rdx+10]
       sub       r8d,ecx
M03_L02:
       test      eax,eax
       je        near ptr M03_L04
M03_L03:
       mov       rcx,[rdi+8]
       mov       rdx,rcx
       mov       r10d,eax
       sar       r10d,10
       mov       r9d,[rdx+8]
       cmp       r10d,r9d
       jae       near ptr M03_L22
       mov       rdx,[rdx+r10*8+10]
       mov       rdx,[rdx+8]
       movzx     r10d,ax
       cmp       r10d,[rdx+8]
       jae       near ptr M03_L22
       lea       r10,[r10+r10*4]
       lea       rdx,[rdx+r10*8+10]
       mov       r10d,[rdx+0C]
       mov       r11d,r10d
       sar       r11d,10
       cmp       r11d,r9d
       jae       near ptr M03_L22
       mov       r9d,r11d
       mov       rcx,[rcx+r9*8+10]
       mov       rcx,[rcx+8]
       movzx     r9d,r10w
       cmp       r9d,[rcx+8]
       jae       near ptr M03_L22
       lea       r9,[r9+r9*4]
       mov       ecx,[rcx+r9*8+2C]
       inc       ecx
       cmp       r8d,ecx
       jl        near ptr M03_L08
       cmp       ecx,r8d
       jl        near ptr M03_L01
M03_L04:
       xor       r8d,r8d
       mov       [rsp+28],r8d
M03_L05:
       test      eax,eax
       je        near ptr M03_L17
       mov       rcx,[rdi+8]
       mov       edx,eax
       sar       edx,10
       cmp       edx,[rcx+8]
       jae       near ptr M03_L22
       mov       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx+8]
       movzx     edx,ax
       cmp       edx,[rcx+8]
       jae       near ptr M03_L22
       movzx     edx,ax
       lea       rdx,[rdx+rdx*4]
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rcx,[rbx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF910B9DE30]; System.Data.DataRow.get_RowState()
       cmp       eax,8
       je        near ptr M03_L19
       cmp       byte ptr [rbx+3B],0
       jne       near ptr M03_L21
M03_L07:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L08:
       mov       eax,r10d
       jmp       near ptr M03_L02
M03_L09:
       mov       byte ptr [rbx+3D],1
       jmp       near ptr M03_L00
M03_L10:
       mov       ecx,0C8B0
       mov       rdx,7FF9108CC210
       call      qword ptr [7FF9104FF228]
       mov       rcx,rax
       call      qword ptr [7FF910C1F3D8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C1F360]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C1F378]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L13:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L14:
       mov       byte ptr [rbx+3A],1
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M03_L13
       call      qword ptr [7FF910C17210]; System.Data.DataTableReaderListener.UnSubscribeEvents()
       jmp       short M03_L13
M03_L15:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF910C15C80]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C1F360]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L16:
       lea       r8,[rsp+28]
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF910C1FA68]
       jmp       near ptr M03_L05
M03_L17:
       cmp       dword ptr [rdi+30],2
       jne       short M03_L18
       mov       ecx,esi
       call      qword ptr [7FF910C1FA80]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L18:
       mov       ecx,0D
       call      qword ptr [7FF910C1FA98]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L19:
       inc       dword ptr [rbx+34]
       mov       edx,[rbx+34]
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+10]
       mov       ecx,[rcx+28]
       dec       ecx
       cmp       edx,ecx
       je        short M03_L20
       mov       edx,[rbx+34]
       mov       rcx,rbx
       call      qword ptr [7FF910C15E78]; System.Data.DataTableReader.ValidateRow(Int32)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       mov       edx,[rbx+34]
       mov       rdi,[rcx+10]
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FF910C15E90]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].GetNodeByIndex(Int32)
       mov       [rsp+20],rax
       mov       rcx,rdi
       mov       edx,[rsp+20]
       call      qword ptr [7FF910D449A8]
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L06
M03_L20:
       mov       byte ptr [rbx+3A],1
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        near ptr M03_L13
       call      qword ptr [7FF910C17210]; System.Data.DataTableReaderListener.UnSubscribeEvents()
       jmp       near ptr M03_L13
M03_L21:
       mov       byte ptr [rbx+3B],0
       jmp       near ptr M03_L07
M03_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 790
```
```assembly
; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       sub       rsp,28
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M04_L00:
       mov       ecx,14
       call      qword ptr [7FF9104FFD50]
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
; System.Text.StringBuilder.set_Length(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M06_L01
       cmp       esi,[rbx+20]
       jg        short M06_L02
       test      esi,esi
       jne       near ptr M06_L03
       cmp       qword ptr [rbx+10],0
       jne       short M06_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M06_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L01:
       mov       ecx,3AD
       mov       rdx,7FF910434000
       call      qword ptr [7FF9104FF228]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FF910C1E2E0]
       int       3
M06_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF910434000
       call      qword ptr [7FF9104FF228]
       mov       rsi,rax
       call      qword ptr [7FF910C1F2A0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF91078D9B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,esi
       sub       r8d,ecx
       test      r8d,r8d
       jle       short M06_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF910C1F978]
       jmp       near ptr M06_L00
M06_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF910C1F990]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M06_L09
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
       jge       short M06_L07
       cmp       ecx,400
       jge       short M06_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M06_L06
M06_L05:
       xor       edx,edx
       call      qword ptr [7FF910B0EA60]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M06_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FF9104FF5A0]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L08
M06_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M06_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M06_L09:
       sub       esi,[rdi+1C]
       mov       [rbx+18],esi
       jmp       near ptr M06_L00
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
       jne       near ptr M07_L10
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M07_L11
       cmp       dword ptr [rbx+20],0
       jl        short M07_L02
       cmp       qword ptr [rbx+10],0
       jne       near ptr M07_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M07_L00:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M07_L13
       lea       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M07_L12
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FF970103270
       test      rax,rax
       jne       near ptr M07_L13
M07_L01:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF910434000
       call      qword ptr [7FF9104FF228]
       mov       rsi,rax
       call      qword ptr [7FF910C1F2A0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF91078D9B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M07_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF910C1F978]
       jmp       near ptr M07_L00
M07_L04:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF910C1F990]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M07_L09
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
       jge       short M07_L07
       cmp       ecx,400
       jge       short M07_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M07_L06
M07_L05:
       xor       edx,edx
       call      qword ptr [7FF910B0EA60]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M07_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FF9104FF5A0]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L08
M07_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M07_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M07_L09:
       mov       ecx,[rdi+1C]
       neg       ecx
       mov       [rbx+18],ecx
       jmp       near ptr M07_L00
M07_L10:
       mov       rdx,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       jne       near ptr M07_L00
M07_L11:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L12:
       call      qword ptr [7FF910C1EF28]
       int       3
M07_L13:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M07_L14
       mov       rcx,[rsi+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF910D44C18]
       jmp       near ptr M07_L01
M07_L14:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M07_L11
; Total bytes of code 543
```
```assembly
; System.Data.DataTableReader.GetFieldType(Int32)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       cmp       byte ptr [rcx+38],0
       je        short M08_L00
       cmp       byte ptr [rcx+3E],0
       jne       short M08_L01
       cmp       byte ptr [rcx+3C],0
       jne       short M08_L02
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF910B96B20]; System.Data.DataColumnCollection.get_Item(Int32)
       mov       rax,[rax+28]
       add       rsp,20
       pop       rbp
       ret
M08_L00:
       mov       ecx,0CA7E
       mov       rdx,7FF9108CC210
       call      qword ptr [7FF9104FF228]
       mov       rcx,rax
       call      qword ptr [7FF910C1F3D8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M08_L01:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C1F360]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M08_L02:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C1F378]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FF910C1F540]
       mov       ecx,846B
       mov       rdx,7FF9108CC210
       call      qword ptr [7FF9104FF228]
       mov       rcx,rax
       call      qword ptr [7FF910C1F558]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 188
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
       call      qword ptr [7FF9104F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF910787AB0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M09_L01
; Total bytes of code 121
```
```assembly
; System.Data.DataTableReader.get_FieldCount()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+38],0
       je        short M10_L00
       mov       rcx,rbx
       call      qword ptr [7FF910C15E60]; System.Data.DataTableReader.ValidateReader()
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax+30]
M10_L00:
       mov       ecx,0C8E0
       mov       rdx,7FF9108CC210
       call      qword ptr [7FF9104FF228]
       mov       rcx,rax
       call      qword ptr [7FF910C1F3D8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 90
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
       jbe       short M11_L01
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M11_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M11_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FF910787C78]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M11_L00
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
       je        near ptr M12_L06
       cmp       byte ptr [rbx+3F],0
       jne       near ptr M12_L07
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M12_L08
       cmp       qword ptr [rbx+18],0
       je        near ptr M12_L08
       cmp       [rcx],ecx
       call      qword ptr [7FF910B9DE30]; System.Data.DataRow.get_RowState()
       cmp       eax,8
       je        near ptr M12_L09
       mov       rcx,[rbx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF910B9DE30]; System.Data.DataRow.get_RowState()
       cmp       eax,1
       je        near ptr M12_L09
       cmp       byte ptr [rbx+3B],0
       jne       near ptr M12_L09
       mov       ecx,[rbx+34]
       test      ecx,ecx
       jl        near ptr M12_L10
       mov       rdx,[rbx+18]
       mov       rdx,[rdx+28]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+28]
       dec       edx
       cmp       edx,ecx
       jle       near ptr M12_L10
       cmp       byte ptr [rbx+3E],0
       jne       near ptr M12_L11
       cmp       byte ptr [rbx+3C],0
       jne       near ptr M12_L12
       mov       rbx,[rbx+20]
       mov       rcx,[rbx+10]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FF910B96B20]; System.Data.DataColumnCollection.get_Item(Int32)
       cmp       dword ptr [rbx+40],0FFFFFFFF
       jne       short M12_L01
       mov       edx,[rbx+3C]
       cmp       edx,0FFFFFFFF
       je        short M12_L02
M12_L00:
       mov       rcx,[rax+60]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M12_L05
M12_L01:
       mov       edx,[rbx+40]
       jmp       short M12_L00
M12_L02:
       cmp       dword ptr [rbx+38],0FFFFFFFF
       je        short M12_L03
       mov       rcx,2DF71C412F0
       call      qword ptr [7FF910C1F4C8]
       mov       rbx,rax
       mov       rcx,offset MT_System.Data.DeletedRowInaccessibleException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF910C1F510]
       mov       rcx,29EDCC01ED0
       mov       rcx,[rcx]
       mov       r9,rsi
       mov       rdx,7FF910C26BD8
       mov       r8,2DF71C41470
       call      qword ptr [7FF910C15F20]
       jmp       short M12_L04
M12_L03:
       mov       rcx,2DF71C412A0
       call      qword ptr [7FF910C1F4C8]
       mov       rsi,rax
       mov       rcx,offset MT_System.Data.RowNotInTableException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF910C1F528]
       mov       rcx,29EDCC01ED0
       mov       rcx,[rcx]
       mov       r9,rbx
       mov       rdx,7FF910C26BD8
       mov       r8,2DF71C41470
       call      qword ptr [7FF910C15F20]
       mov       rsi,rbx
M12_L04:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M12_L05:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M12_L06:
       mov       ecx,0CB50
       mov       rdx,7FF9108CC210
       call      qword ptr [7FF9104FF228]
       mov       rcx,rax
       call      qword ptr [7FF910C1F3D8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L07:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C1F450]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L08:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF910C15C80]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C1F360]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L09:
       call      qword ptr [7FF910C1F468]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L10:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF910C15C80]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C1F360]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L11:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C1F360]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C1F378]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FF910C1F540]
       mov       ecx,846B
       mov       rdx,7FF9108CC210
       call      qword ptr [7FF9104FF228]
       mov       rcx,rax
       call      qword ptr [7FF910C1F558]
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
       je        near ptr M13_L06
       cmp       byte ptr [rbx+3F],0
       jne       near ptr M13_L07
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M13_L08
       cmp       qword ptr [rbx+18],0
       je        near ptr M13_L08
       cmp       [rcx],ecx
       call      qword ptr [7FF910B9DE30]; System.Data.DataRow.get_RowState()
       cmp       eax,8
       je        near ptr M13_L09
       mov       rcx,[rbx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF910B9DE30]; System.Data.DataRow.get_RowState()
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
       call      qword ptr [7FF910B96B20]; System.Data.DataColumnCollection.get_Item(Int32)
       cmp       dword ptr [rbx+40],0FFFFFFFF
       jne       short M13_L01
       mov       edx,[rbx+3C]
       cmp       edx,0FFFFFFFF
       je        short M13_L02
M13_L00:
       mov       rcx,[rax+60]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       jmp       near ptr M13_L05
M13_L01:
       mov       edx,[rbx+40]
       jmp       short M13_L00
M13_L02:
       cmp       dword ptr [rbx+38],0FFFFFFFF
       je        short M13_L03
       mov       rcx,2DF71C412F0
       call      qword ptr [7FF910C1F4C8]
       mov       rbx,rax
       mov       rcx,offset MT_System.Data.DeletedRowInaccessibleException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF910C1F510]
       mov       rcx,29EDCC01ED0
       mov       rcx,[rcx]
       mov       r9,rsi
       mov       rdx,7FF910C26BD8
       mov       r8,2DF71C41470
       call      qword ptr [7FF910C15F20]
       jmp       short M13_L04
M13_L03:
       mov       rcx,2DF71C412A0
       call      qword ptr [7FF910C1F4C8]
       mov       rsi,rax
       mov       rcx,offset MT_System.Data.RowNotInTableException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF910C1F528]
       mov       rcx,29EDCC01ED0
       mov       rcx,[rcx]
       mov       r9,rbx
       mov       rdx,7FF910C26BD8
       mov       r8,2DF71C41470
       call      qword ptr [7FF910C15F20]
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
       mov       ecx,0CB2A
       mov       rdx,7FF9108CC210
       call      qword ptr [7FF9104FF228]
       mov       rcx,rax
       call      qword ptr [7FF910C1F3D8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M13_L07:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C1F450]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M13_L08:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF910C15C80]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C1F360]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M13_L09:
       call      qword ptr [7FF910C1F468]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M13_L10:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF910C15C80]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C1F360]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M13_L11:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C1F360]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M13_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FF910C1F378]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FF910C1F540]
       mov       ecx,846B
       mov       rdx,7FF9108CC210
       call      qword ptr [7FF9104FF228]
       mov       rcx,rax
       call      qword ptr [7FF910C1F558]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 677
```
```assembly
; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       cmp       r8d,8
       jl        near ptr M14_L04
       mov       rax,rcx
       cmp       r8d,10
       jle       short M14_L03
       vmovd     xmm0,edx
       vpbroadcastb ymm0,xmm0
       cmp       r8d,20
       jg        near ptr M14_L12
M14_L00:
       add       r8d,0FFFFFFF0
       movsxd    rdx,r8d
       lea       rdx,[rcx+rdx*2]
       cmp       rax,rdx
       cmova     rax,rdx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rdx]
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       jne       near ptr M14_L15
M14_L01:
       mov       eax,0FFFFFFFF
M14_L02:
       vzeroupper
       ret
M14_L03:
       vmovd     xmm0,edx
       vpbroadcastb xmm0,xmm0
       lea       eax,[r8-8]
       movsxd    r8,eax
       lea       rax,[rcx+r8*2]
       cmp       rcx,rax
       mov       rdx,rcx
       cmova     rdx,rax
       vmovups   xmm1,[rdx]
       vpackuswb xmm1,xmm1,[rax]
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        short M14_L01
       jmp       near ptr M14_L17
M14_L04:
       xor       r10d,r10d
       cmp       r8d,4
       jl        short M14_L05
       add       r8d,0FFFFFFFC
       movsx     r10,word ptr [rcx]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M14_L07
       movsx     rax,word ptr [rcx+2]
       cmp       eax,r9d
       je        short M14_L08
       movsx     rax,word ptr [rcx+4]
       cmp       eax,r9d
       je        short M14_L09
       movsx     rax,word ptr [rcx+6]
       cmp       eax,r9d
       je        short M14_L10
       mov       r10d,4
M14_L05:
       test      r8d,r8d
       jle       near ptr M14_L01
       movsx     r9,dx
M14_L06:
       dec       r8d
       movsx     rax,word ptr [rcx+r10*2]
       cmp       eax,r9d
       je        short M14_L11
       inc       r10
       test      r8d,r8d
       jg        short M14_L06
       jmp       near ptr M14_L01
M14_L07:
       xor       eax,eax
       vzeroupper
       ret
M14_L08:
       mov       eax,1
       vzeroupper
       ret
M14_L09:
       mov       eax,2
       vzeroupper
       ret
M14_L10:
       mov       eax,3
       jmp       near ptr M14_L02
M14_L11:
       mov       eax,r10d
       jmp       near ptr M14_L02
M14_L12:
       lea       edx,[r8-20]
       movsxd    rdx,edx
       lea       rdx,[rax+rdx*2]
M14_L13:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpcmpeqb  ymm1,ymm1,ymm0
       vptest    ymm1,ymm1
       jne       short M14_L14
       add       rax,40
       cmp       rax,rdx
       jb        short M14_L13
       jmp       near ptr M14_L00
M14_L14:
       sub       rax,rcx
       shr       rax,1
       vpermq    ymm0,ymm1,0D8
       vpmovmskb ecx,ymm0
       tzcnt     ecx,ecx
       add       eax,ecx
       jmp       near ptr M14_L02
M14_L15:
       vpermq    ymm0,ymm0,0D8
       vpmovmskb r8d,ymm0
       tzcnt     r8d,r8d
       cmp       r8d,10
       jl        short M14_L16
       mov       rax,rdx
       add       r8d,0FFFFFFF0
M14_L16:
       sub       rax,rcx
       shr       rax,1
       add       eax,r8d
       jmp       near ptr M14_L02
M14_L17:
       vpmovmskb r8d,xmm0
       tzcnt     r8d,r8d
       cmp       r8d,8
       jl        short M14_L18
       mov       rdx,rax
       add       r8d,0FFFFFFF8
M14_L18:
       sub       rdx,rcx
       shr       rdx,1
       lea       eax,[rdx+r8]
       jmp       near ptr M14_L02
; Total bytes of code 436
```
```assembly
; System.Globalization.CompareInfo.get_HighCharTable()
       mov       rax,7FF96F2D9AD0
       mov       [rcx],rax
       mov       dword ptr [rcx+8],80
       mov       rax,rcx
       ret
; Total bytes of code 24
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M16_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF970169D30
       mov       rsi,rax
M16_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M16_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M16_L03
       cmp       [rdx+8],r8d
       jb        short M16_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FF9104F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M16_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M16_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M16_L02:
       mov       rax,2DF71C30008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M16_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF910434000
       call      qword ptr [7FF9104FF228]
       mov       rbx,rax
       call      qword ptr [7FF910C1F018]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91078D9B0]
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
       jbe       short M17_L00
       lea       r10d,[rdx+1]
       mov       [rcx+10],r10d
       mov       edx,edx
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       ret
M17_L00:
       mov       rdx,r8
       add       rsp,28
       jmp       qword ptr [7FF9104F71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
; Total bytes of code 59
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF96FF4CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FF96FF347E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF96FF4B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M19_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF96FF4CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M19_L00:
       call      qword ptr [7FF96FF4A3D0]
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
       jne       short M20_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M20_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF96FF34480]
       cmp       byte ptr [rax],0
       jne       short M20_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M20_L01:
       mov       rcx,rsi
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
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
       je        near ptr M21_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FF96FF4C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FF96FF4B9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M21_L01
       mov       rcx,rax
       call      qword ptr [7FF96FF4CBB8]
       test      eax,eax
       jne       short M21_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FF96FF4CBC8]
M21_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FF96FF5AB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M21_L04
       mov       rbx,[rbp-18]
       jmp       short M21_L02
M21_L01:
       xor       ecx,ecx
       call      qword ptr [7FF96FF471F0]
       int       3
M21_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FF96FF4CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M21_L03:
       mov       rcx,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       mov       rcx,[rcx]
       call      qword ptr [7FF96FF471F0]
       int       3
M21_L04:
       call      M21_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF96FF4B4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M21_L05
       xor       esi,esi
       jmp       short M21_L06
M21_L05:
       call      qword ptr [7FF96FF3E970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FF96FF4B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FF96FF33FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M21_L06:
       test      rsi,rsi
       jne       short M21_L07
       call      qword ptr [7FF96FF3E978]
       mov       rbx,rax
       call      qword ptr [7FF96FF4B8B8]
       mov       r9,rax
       mov       rdx,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FF96FF4BA18]
       mov       rcx,rbx
       call      qword ptr [7FF96FF33FC0]; CORINFO_HELP_THROW
       int       3
M21_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF96FF4C400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M21_L08
       xor       ecx,ecx
       call      qword ptr [7FF96FF471F0]
       int       3
M21_L08:
       mov       rcx,rax
       call      qword ptr [7FF96FF4CBB8]
       test      eax,eax
       jne       short M21_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FF96FF4CBC8]
M21_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FF96FF5AB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FF96FF4CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M21_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M21_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FF96FF4CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M21_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M21_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FF96FF4CC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M21_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
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
       je        near ptr M22_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M22_L02
       test      rsi,rsi
       je        near ptr M22_L01
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M22_L01
       test      rdi,rdi
       je        near ptr M22_L00
       cmp       dword ptr [rdi+8],0
       je        near ptr M22_L00
       mov       r15d,ebp
       mov       r13d,r14d
       add       r13,r15
       mov       r12d,[rdi+8]
       add       r13,r12
       cmp       r13,7FFFFFFF
       jg        near ptr M22_L03
       mov       rcx,7FF910C77780
       call      CORINFO_HELP_COUNTPROFILE32
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.String
       call      00007FF970169D30
       mov       r13,rax
       cmp       [r13],r13b
       lea       r12,[r13+0C]
       mov       rcx,r12
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9104F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r12+r15*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9104F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[r12+rcx*2]
       mov       r8d,[rdi+8]
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FF9104F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M22_L00:
       mov       rcx,7FF910C77778
       call      CORINFO_HELP_COUNTPROFILE32
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
       jmp       qword ptr [7FF9104FD9C8]; System.String.Concat(System.String, System.String)
M22_L01:
       mov       rcx,7FF910C77774
       call      CORINFO_HELP_COUNTPROFILE32
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
       jmp       qword ptr [7FF9104FD9C8]; System.String.Concat(System.String, System.String)
M22_L02:
       mov       rcx,7FF910C77770
       call      CORINFO_HELP_COUNTPROFILE32
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
       jmp       qword ptr [7FF9104FD9C8]; System.String.Concat(System.String, System.String)
M22_L03:
       mov       rcx,7FF910C7777C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF910C1ED48]
       int       3
; Total bytes of code 396
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
       call      qword ptr [7FF96FF59A58]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M23_L00
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M23_L00:
       cmp       qword ptr [rdi+10],0
       jne       short M23_L01
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M23_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 91
```
```assembly
; System.Data.DataTableReader.Close()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+38],0
       je        short M24_L01
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M24_L00
       call      qword ptr [7FF910C17210]; System.Data.DataTableReaderListener.UnSubscribeEvents()
M24_L00:
       xor       eax,eax
       mov       [rbx+28],rax
       mov       [rbx+10],rax
       mov       byte ptr [rbx+38],0
M24_L01:
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 49
```

