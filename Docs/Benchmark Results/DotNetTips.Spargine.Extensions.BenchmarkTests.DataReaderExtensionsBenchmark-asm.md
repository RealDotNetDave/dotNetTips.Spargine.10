## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataReaderExtensionsBenchmark.ToCsvWithHeader()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+1A8]
       mov       rsi,rbx
       cmp       [rsi],sil
       mov       rcx,offset MT_System.Data.DataTableReader
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
       jae       near ptr M00_L68
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
       call      qword ptr [7FFC62F8CBE8]; System.Data.DataTableReaderListener.UnSubscribeEvents()
M00_L01:
       mov       rcx,offset MT_System.WeakReference
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rdi
       xor       edx,edx
       call      00007FFCC2485950
       test      rax,rax
       je        near ptr M00_L66
M00_L02:
       mov       [rsi+8],rax
       cmp       qword ptr [7FFC627AB020],0
       jne       near ptr M00_L67
M00_L03:
       xor       edx,edx
M00_L04:
       test      rdx,rdx
       je        short M00_L05
       lea       rcx,[rsi+8]
       call      qword ptr [7FFC63017D38]
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
       call      qword ptr [7FFC62F878B8]; System.Data.DataTableReaderListener.SubscribeEvents()
M00_L06:
       lea       rcx,[rdi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-50],rdi
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,1C686C00230
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-58],rbx
       cmp       byte ptr [rdi+38],0
       je        near ptr M00_L56
       cmp       byte ptr [rdi+3E],0
       jne       near ptr M00_L57
       cmp       byte ptr [rdi+3C],0
       jne       near ptr M00_L58
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-2C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Boolean[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-60],rax
       xor       edi,edi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L08
       mov       rbx,[rbp-60]
       mov       ecx,[rbx+8]
M00_L07:
       mov       rcx,[rbp-50]
       mov       edx,edi
       call      qword ptr [7FFC62FC5E88]; System.Data.DataTableReader.GetFieldType(Int32)
       mov       rcx,2071BBD0020
       cmp       rax,rcx
       sete      cl
       movzx     ecx,cl
       mov       [rbx+rdi+10],cl
       add       edi,1
       jo        near ptr M00_L64
       mov       esi,[rbp-2C]
       cmp       edi,esi
       jl        short M00_L07
M00_L08:
       mov       esi,[rbp-2C]
       mov       rbx,[rbp-60]
       mov       rcx,1C686C02260
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rdi,[rbp-78]
       mov       rcx,[rdi+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L59
       lea       rcx,[rdi+20]
       mov       r8,[rbp-38]
       test      rcx,rcx
       je        near ptr M00_L63
       xor       edx,edx
       call      00007FFCC24821C0
       cmp       rax,[rbp-38]
       jne       near ptr M00_L59
M00_L09:
       mov       rdx,[rbp-38]
M00_L10:
       xor       ecx,ecx
       mov       [rbp-38],rcx
       mov       [rbp-70],rdx
       xor       edi,edi
       jmp       near ptr M00_L15
M00_L11:
       mov       r8d,r14d
       add       r8,r8
       mov       rdx,r10
       call      qword ptr [7FFC62865818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L12:
       add       r14d,r15d
       mov       rdx,[rbp-70]
       mov       [rdx+18],r14d
M00_L13:
       mov       rcx,[rbp-50]
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
       mov       rcx,[rbp-70]
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
       mov       rcx,[rbp-50]
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
       mov       rcx,[rbp-50]
       mov       edx,edi
       call      qword ptr [7FFC62FC5E90]; System.Data.DataTableReader.GetName(Int32)
       test      rax,rax
       je        near ptr M00_L13
       mov       rcx,[rbp-50]
       mov       edx,edi
       call      qword ptr [7FFC62FC5E90]; System.Data.DataTableReader.GetName(Int32)
       mov       rdx,[rbp-70]
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
       mov       rcx,[rbp-70]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62A52200]; System.Text.StringBuilder.ToString()
       mov       rcx,[rbp-58]
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
       call      qword ptr [7FFC629DE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L26
M00_L18:
       mov       rdx,[rbp-70]
       mov       rcx,rdx
       mov       rdx,r10
       mov       r8d,r14d
       call      qword ptr [7FFC629DF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L13
M00_L19:
       mov       edx,2C
       call      qword ptr [7FFC629DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L14
M00_L20:
       mov       rax,[rcx+18]
       mov       rcx,[rax+70]
       call      qword ptr [7FFC63016A90]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       mov       rax,[rcx+18]
       mov       rcx,[rax+70]
       call      qword ptr [7FFC63016AA8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       ecx,0C8E0
       mov       rdx,7FFC62C6D1B0
       call      qword ptr [7FFC62A87798]
       mov       rcx,rax
       call      qword ptr [7FFC63016B20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       rax,[rcx+18]
       mov       rcx,[rax+70]
       call      qword ptr [7FFC63016A90]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L24:
       mov       rax,[rcx+18]
       mov       rcx,[rax+70]
       call      qword ptr [7FFC63016AA8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L26:
       call      M00_L69
       jmp       short M00_L28
M00_L27:
       mov       rcx,[rbp-68]
       xor       edx,edx
       call      qword ptr [7FFC62F161C0]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       call      qword ptr [7FFC62F161D8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
M00_L28:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC62FC5F98]; System.Data.DataTableReader.Read()
       test      eax,eax
       je        near ptr M00_L55
       mov       rbx,[rbp-78]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       rcx,[rbx+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L61
       lea       rcx,[rbx+20]
       mov       r8,[rbp-40]
       test      rcx,rcx
       je        near ptr M00_L63
       xor       edx,edx
       call      00007FFCC24821C0
       cmp       rax,[rbp-40]
       jne       near ptr M00_L61
M00_L29:
       mov       rbx,[rbp-40]
M00_L30:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-68],rbx
       xor       ebx,ebx
       mov       esi,[rbp-2C]
       cmp       ebx,esi
       jl        near ptr M00_L42
M00_L31:
       mov       rcx,[rbp-68]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62A52200]; System.Text.StringBuilder.ToString()
       mov       rdx,rax
       mov       rcx,[rbp-58]
       call      qword ptr [7FFC62953598]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       near ptr M00_L27
M00_L32:
       jmp       near ptr M00_L43
M00_L33:
       test      rdi,rdi
       je        near ptr M00_L44
       xor       ecx,ecx
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       short M00_L35
M00_L34:
       movzx     edx,word ptr [rdi+rcx*2+0C]
       cmp       edx,22
       je        near ptr M00_L45
       cmp       edx,2C
       je        near ptr M00_L45
       add       ecx,1
       jo        near ptr M00_L54
       cmp       r14d,ecx
       jg        short M00_L34
M00_L35:
       mov       rcx,[rbp-68]
       cmp       [rcx],cl
       lea       rdx,[rdi+0C]
       test      r14d,r14d
       je        short M00_L40
       mov       rcx,[rbp-68]
       mov       rcx,[rcx+8]
       mov       rax,[rbp-68]
       mov       eax,[rax+18]
       lea       edi,[rax+r14]
       cmp       edi,[rcx+8]
       ja        near ptr M00_L46
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r14d,2
       jle       short M00_L37
       mov       eax,r14d
       lea       r8,[rax+rax]
       call      qword ptr [7FFC62865818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L36:
       mov       rcx,[rbp-68]
       mov       [rcx+18],edi
       jmp       short M00_L40
M00_L37:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r14d,2
       jne       short M00_L36
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M00_L36
M00_L38:
       mov       eax,eax
       lea       r8,[rax+rax]
       call      qword ptr [7FFC62865818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L39:
       mov       rcx,[rbp-68]
       mov       [rcx+18],edi
M00_L40:
       mov       ecx,esi
       sub       ecx,1
       jo        near ptr M00_L54
       cmp       ebx,ecx
       jge       short M00_L41
       mov       rcx,[rbp-68]
       mov       ecx,[rcx+18]
       mov       edx,ecx
       mov       rax,[rbp-68]
       mov       rax,[rax+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M00_L52
       cmp       edx,r8d
       jae       near ptr M00_L53
       mov       word ptr [rax+rdx*2+10],2C
       inc       ecx
       mov       rdx,[rbp-68]
       mov       [rdx+18],ecx
M00_L41:
       add       ebx,1
       jo        near ptr M00_L54
       cmp       ebx,esi
       jge       near ptr M00_L31
M00_L42:
       mov       rcx,[rbp-50]
       mov       edx,ebx
       call      qword ptr [7FFC62FC5F80]; System.Data.DataTableReader.IsDBNull(Int32)
       test      eax,eax
       jne       short M00_L40
       mov       rcx,[rbp-50]
       mov       edx,ebx
       call      qword ptr [7FFC62FC5F60]; System.Data.DataTableReader.GetValue(Int32)
       mov       rdx,[rax]
       mov       rcx,offset MT_System.String
       cmp       rdx,rcx
       je        near ptr M00_L32
       mov       rcx,rax
       mov       rax,[rdx+40]
       call      qword ptr [rax+8]
M00_L43:
       mov       rdi,rax
       mov       r8,[rbp-60]
       cmp       ebx,[r8+8]
       jae       near ptr M00_L53
       cmp       byte ptr [r8+rbx+10],0
       jne       near ptr M00_L33
M00_L44:
       mov       rcx,[rbp-68]
       cmp       [rcx],cl
       test      rax,rax
       je        near ptr M00_L40
       lea       rdx,[rax+0C]
       mov       r14d,[rax+8]
       mov       eax,r14d
       test      eax,eax
       je        near ptr M00_L40
       mov       rcx,[rbp-68]
       mov       rcx,[rcx+8]
       mov       r10,[rbp-68]
       mov       r10d,[r10+18]
       lea       edi,[r10+rax]
       cmp       edi,[rcx+8]
       ja        near ptr M00_L51
       movsxd    r10,r10d
       lea       rcx,[rcx+r10*2+10]
       cmp       eax,2
       jg        near ptr M00_L38
       movzx     r10d,word ptr [rdx]
       mov       [rcx],r10w
       cmp       eax,2
       jne       near ptr M00_L39
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L39
M00_L45:
       mov       rcx,[rbp-68]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFC629DF180]; System.Text.StringBuilder.Append(Char)
       xor       r15d,r15d
       jmp       short M00_L50
M00_L46:
       mov       rcx,[rbp-68]
       mov       r8d,r14d
       call      qword ptr [7FFC629DF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L40
M00_L47:
       cmp       r15d,r14d
       jae       short M00_L53
       movzx     edx,word ptr [rdi+r15*2+0C]
       cmp       edx,22
       jne       short M00_L48
       mov       rcx,[rbp-68]
       mov       rdx,2071BBE1988
       cmp       [rcx],ecx
       call      qword ptr [7FFC629DF228]; System.Text.StringBuilder.Append(System.String)
       jmp       short M00_L49
M00_L48:
       mov       rcx,[rbp-68]
       cmp       [rcx],ecx
       call      qword ptr [7FFC629DF180]; System.Text.StringBuilder.Append(Char)
M00_L49:
       add       r15d,1
       jo        short M00_L54
M00_L50:
       cmp       r14d,r15d
       jg        short M00_L47
       mov       rcx,[rbp-68]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFC629DF180]; System.Text.StringBuilder.Append(Char)
       jmp       near ptr M00_L40
M00_L51:
       mov       rcx,[rbp-68]
       mov       r8d,eax
       call      qword ptr [7FFC629DF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L40
M00_L52:
       mov       rcx,[rbp-68]
       mov       edx,2C
       call      qword ptr [7FFC629DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L41
M00_L53:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L54:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L55:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-48],rsi
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+90]
       lea       r8,[rbp-48]
       mov       rdx,7FFC62FCE760
       cmp       [rcx],ecx
       call      qword ptr [7FFC62F8CCF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       jmp       near ptr M00_L65
M00_L56:
       mov       ecx,0C8E0
       mov       rdx,7FFC62C6D1B0
       call      qword ptr [7FFC62A87798]
       mov       rcx,rax
       call      qword ptr [7FFC63016B20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L57:
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC63016A90]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L58:
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC63016AA8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L59:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62F16070]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L60
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M00_L09
M00_L60:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L61:
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62F16070]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L62
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M00_L29
M00_L62:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M00_L30
M00_L63:
       call      qword ptr [7FFC63016058]
       int       3
M00_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L65:
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC62FC5E50]; System.Data.DataTableReader.Close()
       nop
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L66:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFC63017D08]
       jmp       near ptr M00_L02
M00_L67:
       mov       rax,[7FFC627AB020]
       mov       rcx,rdi
       call      rax
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,rdi
       call      qword ptr [7FFC63017D20]
       mov       rdx,rax
       jmp       near ptr M00_L04
M00_L68:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       mov       rcx,[rbp-68]
       cmp       [rcx],cl
       mov       rcx,[rbp-68]
       xor       edx,edx
       call      qword ptr [7FFC62F161C0]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,1C686C02260
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-68]
       call      qword ptr [7FFC62F161D8]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       nop
       add       rsp,28
       ret
M00_L69:
       sub       rsp,28
       mov       rcx,[rbp-70]
       cmp       dword ptr [rcx+20],0
       jge       short M00_L70
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFC627A4000
       call      qword ptr [7FFC62A87798]
       mov       rsi,rax
       call      qword ptr [7FFC630169D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC62A8E778]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L70:
       cmp       qword ptr [rcx+10],0
       jne       short M00_L71
       xor       edx,edx
       mov       [rcx+18],rdx
       jmp       near ptr M00_L78
M00_L71:
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       mov       r8d,edx
       neg       r8d
       test      r8d,r8d
       jle       short M00_L72
       xor       edx,edx
       call      qword ptr [7FFC63016C70]
       mov       rcx,[rbp-70]
       jmp       near ptr M00_L78
M00_L72:
       xor       edx,edx
       call      qword ptr [7FFC63016C88]
       mov       rbx,rax
       mov       rcx,[rbp-70]
       cmp       rbx,rcx
       je        near ptr M00_L77
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
       jge       short M00_L75
       cmp       r8d,400
       jge       short M00_L73
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L74
M00_L73:
       mov       ecx,r8d
       xor       edx,edx
       call      qword ptr [7FFC62E8FAB0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L74:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFC629D5050]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbp-70]
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L76
M00_L75:
       mov       rdx,[rbx+8]
       mov       rcx,[rbp-70]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L76:
       mov       rdx,[rbx+10]
       mov       rcx,[rbp-70]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+1C]
       mov       rax,[rbp-70]
       mov       [rax+1C],ecx
       mov       rcx,rax
M00_L77:
       mov       r8d,[rbx+1C]
       neg       r8d
       mov       [rcx+18],r8d
M00_L78:
       mov       rdx,1C686C02260
       mov       rdx,[rdx]
       mov       [rbp-78],rdx
       mov       rbx,[rbp-78]
       mov       rax,[rbx+10]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L80
M00_L79:
       add       rsp,28
       ret
M00_L80:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L82
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L81
       call      qword ptr [7FFC63016058]
       int       3
M00_L81:
       mov       rdx,[rbp-70]
       xor       r8d,r8d
       call      00007FFCC24821C0
       test      rax,rax
       je        short M00_L79
M00_L82:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L83
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-70]
       cmp       [rcx],ecx
       call      qword ptr [7FFC63017090]
       test      eax,eax
       jne       short M00_L79
       mov       rcx,rbx
       mov       rdx,[rbp-70]
       call      qword ptr [7FFC630170A8]
       jmp       short M00_L79
M00_L83:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M00_L79
       sub       rsp,28
       mov       rcx,[rbp-50]
       call      qword ptr [7FFC62FC5E50]; System.Data.DataTableReader.Close()
       nop
       add       rsp,28
       ret
; Total bytes of code 3045
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
       mov       rcx,7FFC62F838D0
       mov       [rdi+18],rcx
       mov       rbp,[rsi+40]
M01_L00:
       test      rbp,rbp
       je        near ptr M01_L16
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FFC6289AAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       call      00007FFCC24821C0
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
       mov       rcx,7FFC62F838D0
       mov       [rdi+18],rcx
       mov       rbp,[rsi+30]
M01_L03:
       test      rbp,rbp
       je        near ptr M01_L18
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FFC6289AAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       call      00007FFCC24821C0
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
       mov       rcx,7FFC62F83948
       mov       [rsi+18],rcx
       mov       rcx,1C686C01F28
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
       call      qword ptr [7FFC6289AAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       mov       rcx,7FFC62F83948
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
       call      qword ptr [7FFC6289AAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       mov       rcx,7FFC62F83990
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
       call      qword ptr [7FFC6289AAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       call      qword ptr [7FFC63016058]
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
       mov       rdx,2071BBE2640
       call      qword ptr [7FFC63016BC8]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFC62F8D068]
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
       mov       rdx,2071BBE26A8
       call      qword ptr [7FFC63016BC8]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFC62F8D068]
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
       mov       rdx,2071BBE2710
       call      qword ptr [7FFC63016BC8]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFC62F8D068]
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
       mov       rcx,7FFC62F838D0
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
       call      00007FFCC24821C0
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
       mov       rcx,7FFC62F838D0
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
       call      00007FFCC24821C0
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
       mov       rcx,7FFC62F83948
       mov       [rsi+18],rcx
       mov       rcx,1C686C01F28
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
       mov       rcx,7FFC62F83948
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
       mov       rcx,7FFC62F83990
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
       call      qword ptr [7FFC6289AAE8]
       mov       rdx,rax
       jmp       near ptr M02_L01
M02_L17:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L18:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FFC6289AAE8]
       mov       rdx,rax
       jmp       near ptr M02_L04
M02_L19:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L20:
       call      qword ptr [7FFC63016058]
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
       mov       rdx,2071BBE14D8
       call      qword ptr [7FFC63016BC8]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFC62F8D068]
       jmp       near ptr M02_L06
M02_L22:
       mov       rdx,rsi
       call      qword ptr [7FFC6289AAE8]
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
       mov       rdx,2071BBE1538
       call      qword ptr [7FFC63016BC8]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFC62F8D068]
       jmp       near ptr M02_L09
M02_L25:
       mov       rdx,rsi
       call      qword ptr [7FFC6289AAE8]
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
       mov       rdx,2071BBE1598
       call      qword ptr [7FFC63016BC8]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFC62F8D068]
       jmp       near ptr M02_L12
M02_L28:
       mov       rdx,rsi
       call      qword ptr [7FFC6289AAE8]
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
       call      qword ptr [7FFC62F1C6F0]; System.Data.DataColumnCollection.get_Item(Int32)
       mov       rax,[rax+28]
       add       rsp,20
       pop       rbp
       ret
M03_L00:
       mov       ecx,0CA7E
       mov       rdx,7FFC62C6D1B0
       call      qword ptr [7FFC62A87798]
       mov       rcx,rax
       call      qword ptr [7FFC63016B20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L01:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC63016A90]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L02:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC63016AA8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FFC63016C28]
       mov       ecx,846B
       mov       rdx,7FFC62C6D1B0
       call      qword ptr [7FFC62A87798]
       mov       rcx,rax
       call      qword ptr [7FFC63016C40]
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
       jmp       qword ptr [7FFC628666E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC62F1C6F0]; System.Data.DataColumnCollection.get_Item(Int32)
       mov       rax,[rax+20]
       add       rsp,20
       pop       rbp
       ret
M05_L00:
       mov       ecx,0CAF0
       mov       rdx,7FFC62C6D1B0
       call      qword ptr [7FFC62A87798]
       mov       rcx,rax
       call      qword ptr [7FFC63016B20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M05_L01:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC63016A90]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M05_L02:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC63016AA8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FFC63016C28]
       mov       ecx,846B
       mov       rdx,7FFC62C6D1B0
       call      qword ptr [7FFC62A87798]
       mov       rcx,rax
       call      qword ptr [7FFC63016C40]
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
       call      00007FFCC24D52E0
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
       call      qword ptr [7FFC62865818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2071BBD0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFC627A4000
       call      qword ptr [7FFC62A87798]
       mov       rbx,rax
       call      qword ptr [7FFC63016820]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC62A8E778]
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
       call      qword ptr [7FFC62E875E8]
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
       mov       rdx,[rdx+58]
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
       mov       rdx,7FFC62FBFBC8
       call      qword ptr [7FFC6286C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M07_L03
M07_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+60]
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
       call      qword ptr [7FFC629D5050]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFC62FBFBD8
       call      qword ptr [7FFC6286C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC62865818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC62E8FAB0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
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
       call      qword ptr [7FFC62865818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFC627A4000
       call      qword ptr [7FFC62A87798]
       mov       rsi,rax
       call      qword ptr [7FFC630169B8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC62A8E778]
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
       call      qword ptr [7FFC629D7198]
       int       3
M08_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFC627A4000
       call      qword ptr [7FFC62A87798]
       mov       rsi,rax
       call      qword ptr [7FFC630169D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC62A8E778]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC630169E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M08_L04
M08_L11:
       call      qword ptr [7FFC62D2E088]
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
       call      qword ptr [7FFCC22C37D8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFCC22A8FD8]
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
       mov       rdx,7FFC627A4000
       call      qword ptr [7FFC62A87798]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFC62F8F060]
       int       3
M10_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFC627A4000
       call      qword ptr [7FFC62A87798]
       mov       rsi,rax
       call      qword ptr [7FFC630169D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC62A8E778]
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
       call      qword ptr [7FFC63016C70]
       jmp       near ptr M10_L00
M10_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFC63016C88]
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
       call      qword ptr [7FFC62E8FAB0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M10_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFC629D5050]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      00007FFCC24821C0
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
       mov       rdx,7FFC627A4000
       call      qword ptr [7FFC62A87798]
       mov       rsi,rax
       call      qword ptr [7FFC630169D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC62A8E778]
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
       call      qword ptr [7FFC63016C70]
       jmp       near ptr M11_L00
M11_L04:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC63016C88]
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
       call      qword ptr [7FFC62E8FAB0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M11_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFC629D5050]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFC63016058]
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
       call      qword ptr [7FFC6301C108]
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
       je        near ptr M12_L09
M12_L00:
       cmp       byte ptr [rbx+38],0
       je        near ptr M12_L10
       cmp       byte ptr [rbx+3E],0
       jne       near ptr M12_L11
       cmp       byte ptr [rbx+3C],0
       jne       near ptr M12_L12
       cmp       byte ptr [rbx+3A],0
       jne       near ptr M12_L13
       mov       esi,[rbx+34]
       mov       r8,[rbx+18]
       mov       r8,[r8+28]
       mov       rdi,[r8+10]
       mov       r8d,[rdi+28]
       lea       ecx,[r8-2]
       cmp       esi,ecx
       jge       near ptr M12_L14
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
       jl        near ptr M12_L08
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
       call      qword ptr [7FFC62F1F9F0]; System.Data.DataRow.get_RowState()
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
       mov       eax,r10d
       jmp       near ptr M12_L02
M12_L09:
       mov       byte ptr [rbx+3D],1
       jmp       near ptr M12_L00
M12_L10:
       mov       ecx,0C8B0
       mov       rdx,7FFC62C6D1B0
       call      qword ptr [7FFC62A87798]
       mov       rcx,rax
       call      qword ptr [7FFC63016B20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L11:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC63016A90]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC63016AA8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L13:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M12_L14:
       mov       byte ptr [rbx+3A],1
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M12_L13
       call      qword ptr [7FFC62F8CBE8]; System.Data.DataTableReaderListener.UnSubscribeEvents()
       jmp       short M12_L13
M12_L15:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFC62F87858]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC63016A90]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L16:
       lea       r8,[rsp+28]
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFC63017120]
       jmp       near ptr M12_L05
M12_L17:
       cmp       dword ptr [rdi+30],2
       jne       short M12_L18
       mov       ecx,esi
       call      qword ptr [7FFC63017138]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L18:
       mov       ecx,0D
       call      qword ptr [7FFC63017150]
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
       call      qword ptr [7FFC62F87A50]; System.Data.DataTableReader.ValidateRow(Int32)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       mov       edx,[rbx+34]
       mov       rdi,[rcx+10]
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FFC62F87A68]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].GetNodeByIndex(Int32)
       mov       [rsp+20],rax
       mov       rcx,rdi
       mov       edx,[rsp+20]
       call      qword ptr [7FFC63017F30]
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M12_L06
M12_L20:
       mov       byte ptr [rbx+3A],1
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        near ptr M12_L13
       call      qword ptr [7FFC62F8CBE8]; System.Data.DataTableReaderListener.UnSubscribeEvents()
       jmp       near ptr M12_L13
M12_L21:
       mov       byte ptr [rbx+3B],0
       jmp       near ptr M12_L07
M12_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 790
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
       jmp       qword ptr [7FFC629DE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
; Total bytes of code 59
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
       je        near ptr M14_L06
       cmp       byte ptr [rbx+3F],0
       jne       near ptr M14_L07
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M14_L08
       cmp       qword ptr [rbx+18],0
       je        near ptr M14_L08
       cmp       [rcx],ecx
       call      qword ptr [7FFC62F1F9F0]; System.Data.DataRow.get_RowState()
       cmp       eax,8
       je        near ptr M14_L09
       mov       rcx,[rbx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62F1F9F0]; System.Data.DataRow.get_RowState()
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
       call      qword ptr [7FFC62F1C6F0]; System.Data.DataColumnCollection.get_Item(Int32)
       cmp       dword ptr [rbx+40],0FFFFFFFF
       jne       short M14_L01
       mov       edx,[rbx+3C]
       cmp       edx,0FFFFFFFF
       je        short M14_L02
M14_L00:
       mov       rcx,[rax+60]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M14_L05
M14_L01:
       mov       edx,[rbx+40]
       jmp       short M14_L00
M14_L02:
       cmp       dword ptr [rbx+38],0FFFFFFFF
       je        short M14_L03
       mov       rcx,2071BBE1778
       call      qword ptr [7FFC63016BB0]
       mov       rbx,rax
       mov       rcx,offset MT_System.Data.DeletedRowInaccessibleException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFC63016BF8]
       mov       rcx,1C686C01F28
       mov       rcx,[rcx]
       mov       r9,rsi
       mov       rdx,7FFC62FC8630
       mov       r8,2071BBE18F8
       call      qword ptr [7FFC62F87AE0]
       jmp       short M14_L04
M14_L03:
       mov       rcx,2071BBE1728
       call      qword ptr [7FFC63016BB0]
       mov       rsi,rax
       mov       rcx,offset MT_System.Data.RowNotInTableException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFC63016C10]
       mov       rcx,1C686C01F28
       mov       rcx,[rcx]
       mov       r9,rbx
       mov       rdx,7FFC62FC8630
       mov       r8,2071BBE18F8
       call      qword ptr [7FFC62F87AE0]
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
       mov       ecx,0CB50
       mov       rdx,7FFC62C6D1B0
       call      qword ptr [7FFC62A87798]
       mov       rcx,rax
       call      qword ptr [7FFC63016B20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M14_L07:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC63016B38]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M14_L08:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFC62F87858]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC63016A90]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M14_L09:
       call      qword ptr [7FFC63016B50]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M14_L10:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFC62F87858]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC63016A90]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M14_L11:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC63016A90]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M14_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC63016AA8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FFC63016C28]
       mov       ecx,846B
       mov       rdx,7FFC62C6D1B0
       call      qword ptr [7FFC62A87798]
       mov       rcx,rax
       call      qword ptr [7FFC63016C40]
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
       je        near ptr M15_L06
       cmp       byte ptr [rbx+3F],0
       jne       near ptr M15_L07
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M15_L08
       cmp       qword ptr [rbx+18],0
       je        near ptr M15_L08
       cmp       [rcx],ecx
       call      qword ptr [7FFC62F1F9F0]; System.Data.DataRow.get_RowState()
       cmp       eax,8
       je        near ptr M15_L09
       mov       rcx,[rbx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62F1F9F0]; System.Data.DataRow.get_RowState()
       cmp       eax,1
       je        near ptr M15_L09
       cmp       byte ptr [rbx+3B],0
       jne       near ptr M15_L09
       mov       ecx,[rbx+34]
       test      ecx,ecx
       jl        near ptr M15_L10
       mov       rdx,[rbx+18]
       mov       rdx,[rdx+28]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+28]
       dec       edx
       cmp       edx,ecx
       jle       near ptr M15_L10
       cmp       byte ptr [rbx+3E],0
       jne       near ptr M15_L11
       cmp       byte ptr [rbx+3C],0
       jne       near ptr M15_L12
       mov       rbx,[rbx+20]
       mov       rcx,[rbx+10]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFC62F1C6F0]; System.Data.DataColumnCollection.get_Item(Int32)
       cmp       dword ptr [rbx+40],0FFFFFFFF
       jne       short M15_L01
       mov       edx,[rbx+3C]
       cmp       edx,0FFFFFFFF
       je        short M15_L02
M15_L00:
       mov       rcx,[rax+60]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       jmp       near ptr M15_L05
M15_L01:
       mov       edx,[rbx+40]
       jmp       short M15_L00
M15_L02:
       cmp       dword ptr [rbx+38],0FFFFFFFF
       je        short M15_L03
       mov       rcx,2071BBE1778
       call      qword ptr [7FFC63016BB0]
       mov       rbx,rax
       mov       rcx,offset MT_System.Data.DeletedRowInaccessibleException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFC63016BF8]
       mov       rcx,1C686C01F28
       mov       rcx,[rcx]
       mov       r9,rsi
       mov       rdx,7FFC62FC8630
       mov       r8,2071BBE18F8
       call      qword ptr [7FFC62F87AE0]
       jmp       short M15_L04
M15_L03:
       mov       rcx,2071BBE1728
       call      qword ptr [7FFC63016BB0]
       mov       rsi,rax
       mov       rcx,offset MT_System.Data.RowNotInTableException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFC63016C10]
       mov       rcx,1C686C01F28
       mov       rcx,[rcx]
       mov       r9,rbx
       mov       rdx,7FFC62FC8630
       mov       r8,2071BBE18F8
       call      qword ptr [7FFC62F87AE0]
       mov       rsi,rbx
M15_L04:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M15_L05:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M15_L06:
       mov       ecx,0CB2A
       mov       rdx,7FFC62C6D1B0
       call      qword ptr [7FFC62A87798]
       mov       rcx,rax
       call      qword ptr [7FFC63016B20]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M15_L07:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC63016B38]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M15_L08:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFC62F87858]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC63016A90]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M15_L09:
       call      qword ptr [7FFC63016B50]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M15_L10:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFC62F87858]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC63016A90]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M15_L11:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC63016A90]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M15_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC63016AA8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FFC63016C28]
       mov       ecx,846B
       mov       rdx,7FFC62C6D1B0
       call      qword ptr [7FFC62A87798]
       mov       rcx,rax
       call      qword ptr [7FFC63016C40]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 677
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
       jbe       short M16_L01
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M16_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M16_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFC629DF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M16_L00
; Total bytes of code 60
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rdx,rdx
       je        short M17_L01
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M17_L01
       mov       rcx,[rbx+8]
       mov       edx,[rbx+18]
       lea       esi,[rdx+r8]
       cmp       esi,[rcx+8]
       ja        short M17_L03
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jle       short M17_L02
       mov       r8d,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFC62865818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M17_L00:
       mov       [rbx+18],esi
M17_L01:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M17_L02:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       jne       short M17_L00
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M17_L00
M17_L03:
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFC629DF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M17_L01
; Total bytes of code 121
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
       call      qword ptr [7FFCC22CEA60]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M19_L01
       cmp       qword ptr [rdi+10],0
       je        short M19_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M19_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M19_L01:
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
       je        short M20_L01
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M20_L00
       call      qword ptr [7FFC62F8CBE8]; System.Data.DataTableReaderListener.UnSubscribeEvents()
M20_L00:
       xor       eax,eax
       mov       [rbx+28],rax
       mov       [rbx+10],rax
       mov       byte ptr [rbx+38],0
M20_L01:
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
       call      qword ptr [7FFCC22A9030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFCC22A9038]; CORINFO_HELP_JIT_PINVOKE_END
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
       je        near ptr M22_L06
       test      rbx,rbx
       je        near ptr M22_L07
       mov       rcx,[rsi]
       cmp       rcx,[rbx]
       jne       near ptr M22_L07
       cmp       dword ptr [rcx+4],18
       jne       near ptr M22_L07
       cmp       edi,[rsi+8]
       ja        short M22_L07
       cmp       edi,[rbx+8]
       ja        short M22_L07
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       add       rbx,10
       test      dword ptr [rcx],1000000
       je        short M22_L05
       cmp       r8,4000
       jbe       short M22_L00
       mov       rcx,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFC62E8F648]
M22_L00:
       mov       rcx,rbx
       call      00007FFCC24537A0
       cmp       dword ptr [7FFCC2793A90],0
       jne       short M22_L03
M22_L01:
       cmp       dword ptr [7FFCC2793A90],0
       jne       short M22_L04
M22_L02:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M22_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M22_L01
M22_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M22_L02
M22_L05:
       mov       rcx,rbx
       call      qword ptr [7FFC62865818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M22_L01
M22_L06:
       xor       ebp,ebp
       jmp       short M22_L08
M22_L07:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC62F17180]; System.Array.GetLowerBound(Int32)
       mov       ebp,eax
M22_L08:
       test      rbx,rbx
       jne       short M22_L09
       xor       r9d,r9d
       jmp       short M22_L10
M22_L09:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC62F17180]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
M22_L10:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       call      qword ptr [7FFC62F17198]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M22_L01
; Total bytes of code 246
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataReaderExtensionsBenchmark.ToCsvWithoutHeader()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp+10],rcx
       mov       rbx,[rcx+1A8]
       mov       rsi,rbx
       cmp       [rsi],sil
       mov       rcx,offset MT_System.Data.DataTableReader
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
       jae       near ptr M00_L50
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
       call      qword ptr [7FFC62F57BA0]; System.Data.DataTableReaderListener.UnSubscribeEvents()
M00_L01:
       mov       rcx,offset MT_System.WeakReference
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rdi
       xor       edx,edx
       call      00007FFCC2485950
       test      rax,rax
       je        near ptr M00_L48
M00_L02:
       mov       [rsi+8],rax
       cmp       qword ptr [7FFC6278B020],0
       jne       near ptr M00_L49
M00_L03:
       xor       edx,edx
M00_L04:
       test      rdx,rdx
       je        short M00_L05
       lea       rcx,[rsi+8]
       call      qword ptr [7FFC63014B58]
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
       call      qword ptr [7FFC62F56880]; System.Data.DataTableReaderListener.SubscribeEvents()
M00_L06:
       lea       rcx,[rdi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-40],rdi
       mov       [rbp-48],rdi
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,2998E400230
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-50],rbx
       mov       rbx,[rbp-48]
       cmp       byte ptr [rbx+38],0
       je        near ptr M00_L38
       cmp       byte ptr [rbx+3E],0
       jne       near ptr M00_L39
       cmp       byte ptr [rbx+3C],0
       jne       near ptr M00_L40
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       ecx,eax
       mov       [rbp-24],ecx
       movsxd    rdx,dword ptr [rbp-24]
       mov       rcx,offset MT_System.Boolean[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-58],rax
       xor       edi,edi
       cmp       dword ptr [rbp-24],0
       jle       short M00_L09
       mov       rsi,[rbp-58]
       mov       ecx,[rsi+8]
M00_L07:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFC62F7E4B0]; System.Data.DataTableReader.GetFieldType(Int32)
       mov       rcx,2DA23530020
       cmp       rax,rcx
       sete      cl
       movzx     ecx,cl
       mov       [rsi+rdi+10],cl
       add       edi,1
       jo        near ptr M00_L44
       mov       ecx,[rbp-24]
       cmp       edi,ecx
       jl        short M00_L07
       jmp       short M00_L09
M00_L08:
       call      M00_L51
       nop
M00_L09:
       mov       rcx,[rbp-48]
       call      qword ptr [7FFC62F7E5C0]; System.Data.DataTableReader.Read()
       test      eax,eax
       je        near ptr M00_L37
       mov       rcx,2998E402230
       mov       rbx,[rcx]
       xor       ecx,ecx
       mov       [rbp-30],rcx
       mov       rcx,[rbx+20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L41
       lea       rcx,[rbx+20]
       mov       r8,[rbp-30]
       test      rcx,rcx
       je        near ptr M00_L43
       xor       edx,edx
       call      00007FFCC24821C0
       cmp       rax,[rbp-30]
       jne       near ptr M00_L41
M00_L10:
       mov       rbx,[rbp-30]
M00_L11:
       xor       ecx,ecx
       mov       [rbp-30],rcx
       mov       [rbp-60],rbx
       xor       ebx,ebx
       mov       ecx,[rbp-24]
       cmp       ebx,ecx
       jl        near ptr M00_L23
M00_L12:
       mov       rcx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62A32200]; System.Text.StringBuilder.ToString()
       mov       rcx,[rbp-50]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       r8d,[rcx+10]
       cmp       [rdx+8],r8d
       jbe       near ptr M00_L26
       lea       r10d,[r8+1]
       mov       [rcx+10],r10d
       cmp       r8d,[rdx+8]
       jae       near ptr M00_L35
       mov       r8d,r8d
       lea       rcx,[rdx+r8*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L13:
       jmp       near ptr M00_L24
M00_L14:
       test      rsi,rsi
       je        near ptr M00_L25
       xor       ecx,ecx
       mov       edi,[rsi+8]
       test      edi,edi
       jle       short M00_L16
M00_L15:
       movzx     edx,word ptr [rsi+rcx*2+0C]
       cmp       edx,22
       je        near ptr M00_L27
       cmp       edx,2C
       je        near ptr M00_L27
       add       ecx,1
       jo        near ptr M00_L36
       cmp       edi,ecx
       jg        short M00_L15
M00_L16:
       mov       rcx,[rbp-60]
       cmp       [rcx],cl
       lea       rdx,[rsi+0C]
       test      edi,edi
       je        short M00_L21
       mov       rcx,[rbp-60]
       mov       rcx,[rcx+8]
       mov       rax,[rbp-60]
       mov       eax,[rax+18]
       lea       esi,[rax+rdi]
       cmp       esi,[rcx+8]
       ja        near ptr M00_L28
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       edi,2
       jle       short M00_L18
       mov       eax,edi
       lea       r8,[rax+rax]
       call      qword ptr [7FFC62845818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L17:
       mov       rcx,[rbp-60]
       mov       [rcx+18],esi
       jmp       short M00_L21
M00_L18:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       edi,2
       jne       short M00_L17
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M00_L17
M00_L19:
       mov       eax,eax
       lea       r8,[rax+rax]
       call      qword ptr [7FFC62845818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L20:
       mov       rcx,[rbp-60]
       mov       [rcx+18],esi
M00_L21:
       mov       ecx,[rbp-24]
       mov       edx,ecx
       sub       edx,1
       jo        near ptr M00_L36
       cmp       ebx,edx
       jge       short M00_L22
       mov       rdx,[rbp-60]
       mov       edx,[rdx+18]
       mov       eax,edx
       mov       r8,[rbp-60]
       mov       r8,[r8+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       near ptr M00_L34
       mov       word ptr [r8+rax*2+10],2C
       inc       edx
       mov       rax,[rbp-60]
       mov       [rax+18],edx
M00_L22:
       add       ebx,1
       jo        near ptr M00_L36
       mov       ecx,[rbp-24]
       cmp       ebx,ecx
       jge       near ptr M00_L12
M00_L23:
       mov       rcx,[rbp-48]
       mov       edx,ebx
       call      qword ptr [7FFC62F7E5A8]; System.Data.DataTableReader.IsDBNull(Int32)
       test      eax,eax
       jne       short M00_L21
       mov       rcx,[rbp-48]
       mov       edx,ebx
       call      qword ptr [7FFC62F7E588]; System.Data.DataTableReader.GetValue(Int32)
       mov       rdx,[rax]
       mov       rcx,offset MT_System.String
       cmp       rdx,rcx
       je        near ptr M00_L13
       mov       rcx,rax
       mov       rax,[rdx+40]
       call      qword ptr [rax+8]
M00_L24:
       mov       rsi,rax
       mov       r8,[rbp-58]
       cmp       byte ptr [r8+rbx+10],0
       jne       near ptr M00_L14
M00_L25:
       mov       rcx,[rbp-60]
       cmp       [rcx],cl
       test      rax,rax
       je        near ptr M00_L21
       lea       rdx,[rax+0C]
       mov       edi,[rax+8]
       mov       eax,edi
       test      eax,eax
       je        near ptr M00_L21
       mov       rcx,[rbp-60]
       mov       rcx,[rcx+8]
       mov       r10,[rbp-60]
       mov       r10d,[r10+18]
       lea       esi,[r10+rax]
       cmp       esi,[rcx+8]
       ja        near ptr M00_L33
       movsxd    r10,r10d
       lea       rcx,[rcx+r10*2+10]
       cmp       eax,2
       jg        near ptr M00_L19
       movzx     r10d,word ptr [rdx]
       mov       [rcx],r10w
       cmp       eax,2
       jne       near ptr M00_L20
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L20
M00_L26:
       mov       rdx,rax
       call      qword ptr [7FFC629BE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L08
M00_L27:
       mov       rcx,[rbp-60]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFC629BF180]; System.Text.StringBuilder.Append(Char)
       xor       r14d,r14d
       jmp       short M00_L32
       nop       dword ptr [rax+rax]
M00_L28:
       mov       rcx,[rbp-60]
       mov       r8d,edi
       call      qword ptr [7FFC629BF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L21
M00_L29:
       movzx     edx,word ptr [rsi+r14*2+0C]
       cmp       edx,22
       jne       short M00_L30
       mov       rcx,[rbp-60]
       mov       rdx,2DA23541960
       call      qword ptr [7FFC629BF228]; System.Text.StringBuilder.Append(System.String)
       jmp       short M00_L31
M00_L30:
       mov       rcx,[rbp-60]
       call      qword ptr [7FFC629BF180]; System.Text.StringBuilder.Append(Char)
M00_L31:
       add       r14d,1
       jo        short M00_L36
M00_L32:
       cmp       edi,r14d
       jg        short M00_L29
       mov       rcx,[rbp-60]
       mov       edx,22
       call      qword ptr [7FFC629BF180]; System.Text.StringBuilder.Append(Char)
       jmp       near ptr M00_L21
M00_L33:
       mov       rcx,[rbp-60]
       mov       r8d,eax
       call      qword ptr [7FFC629BF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L21
M00_L34:
       mov       rcx,[rbp-60]
       mov       edx,2C
       call      qword ptr [7FFC629BF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L22
M00_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L37:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-38],rbx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+90]
       mov       rdx,[rbp-38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       jmp       near ptr M00_L45
M00_L38:
       mov       ecx,0C8E0
       mov       rdx,7FFC62C30D50
       call      qword ptr [7FFC62A67798]
       mov       rcx,rax
       call      qword ptr [7FFC62F5F930]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L39:
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC62F5F8E8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L40:
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC62F5F900]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L41:
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62ED50B0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L42
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M00_L10
M00_L42:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M00_L11
M00_L43:
       call      qword ptr [7FFC62F5F510]
       int       3
M00_L44:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L45:
       mov       r8,[rbp-40]
       cmp       byte ptr [r8+38],0
       je        short M00_L47
       mov       rcx,[r8+28]
       test      rcx,rcx
       je        short M00_L46
       call      qword ptr [7FFC62F57BA0]; System.Data.DataTableReaderListener.UnSubscribeEvents()
M00_L46:
       xor       ecx,ecx
       mov       r8,[rbp-40]
       mov       [r8+28],rcx
       mov       [r8+10],rcx
       mov       byte ptr [r8+38],0
M00_L47:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L48:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFC63014B28]
       jmp       near ptr M00_L02
M00_L49:
       mov       rax,[7FFC6278B020]
       mov       rcx,rdi
       call      rax
       test      eax,eax
       je        near ptr M00_L03
       mov       rcx,rdi
       call      qword ptr [7FFC63014B40]
       mov       rdx,rax
       jmp       near ptr M00_L04
M00_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L51:
       sub       rsp,28
       mov       rcx,[rbp-60]
       cmp       dword ptr [rcx+20],0
       jge       short M00_L52
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFC62784000
       call      qword ptr [7FFC62A67798]
       mov       rsi,rax
       call      qword ptr [7FFC62F5F7E0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC62A6DAD0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L52:
       mov       rcx,[rbp-60]
       cmp       qword ptr [rcx+10],0
       jne       short M00_L53
       mov       rcx,[rbp-60]
       xor       edx,edx
       mov       [rcx+18],rdx
       jmp       near ptr M00_L62
M00_L53:
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+1C]
       mov       rdx,[rbp-60]
       add       ecx,[rdx+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M00_L54
       mov       rcx,[rbp-60]
       xor       edx,edx
       call      qword ptr [7FFC62F5F8A0]
       jmp       near ptr M00_L62
M00_L54:
       mov       rcx,[rbp-60]
       xor       edx,edx
       call      qword ptr [7FFC62F5F8B8]
       mov       rbx,rax
       cmp       rbx,[rbp-60]
       je        near ptr M00_L61
       mov       rax,[rbp-60]
       mov       rax,[rax+8]
       mov       ecx,[rax+8]
       mov       rax,[rbp-60]
       add       ecx,[rax+1C]
       mov       rax,[rbp-60]
       mov       eax,[rax+1C]
       mov       rdx,[rbp-60]
       add       eax,[rdx+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rbp-60]
       mov       rax,[rax+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       jge       short M00_L55
       mov       edx,eax
M00_L55:
       cmp       ecx,edx
       jle       short M00_L56
       mov       ecx,edx
M00_L56:
       sub       ecx,[rbx+1C]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jge       short M00_L59
       cmp       ecx,400
       jge       short M00_L57
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L58
M00_L57:
       xor       edx,edx
       call      qword ptr [7FFC62E5ECE8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L58:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFC629B5050]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L60
M00_L59:
       mov       rdx,[rbx+8]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L60:
       mov       rdx,[rbx+10]
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+1C]
       mov       r8,[rbp-60]
       mov       [r8+1C],ecx
M00_L61:
       mov       ecx,[rbx+1C]
       neg       ecx
       mov       r8,[rbp-60]
       mov       [r8+18],ecx
M00_L62:
       mov       rdx,2998E402230
       mov       rbx,[rdx]
       mov       rax,[rbx+10]
       mov       rdx,[rbp-60]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L64
M00_L63:
       add       rsp,28
       ret
M00_L64:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L67
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L66
       call      qword ptr [7FFC62F5F510]
       int       3
M00_L65:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L66:
       mov       rdx,[rbp-60]
       xor       r8d,r8d
       call      00007FFCC24821C0
       test      rax,rax
       je        short M00_L63
M00_L67:
       lea       rax,[rbx+2C]
       mov       ecx,1
       lock xadd [rax],ecx
       inc       ecx
       cmp       ecx,[rbx+28]
       jg        short M00_L72
       mov       rcx,[rbx+18]
       mov       rdx,[rcx+10]
       mov       r8,[rdx+8]
M00_L68:
       mov       ebx,[rdx+0A0]
       mov       eax,ebx
       and       eax,[rdx+18]
       cmp       eax,[r8+8]
       jae       short M00_L65
       shl       rax,4
       lea       rsi,[r8+rax+10]
       mov       r10d,[rsi+8]
       sub       r10d,ebx
       jne       short M00_L69
       lea       r10,[rdx+0A0]
       lea       r9d,[rbx+1]
       mov       eax,ebx
       lock cmpxchg [r10],r9d
       cmp       eax,ebx
       jne       short M00_L68
       jmp       short M00_L70
M00_L69:
       test      r10d,r10d
       jge       short M00_L68
       jmp       short M00_L71
M00_L70:
       mov       rdx,[rbp-60]
       mov       rcx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       ebx
       mov       [rsi+8],ebx
       jmp       near ptr M00_L63
M00_L71:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFC62F5FCD8]
       jmp       near ptr M00_L63
M00_L72:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M00_L63
       sub       rsp,28
       mov       r8,[rbp-40]
       cmp       byte ptr [r8+38],0
       je        short M00_L74
       mov       rcx,[r8+28]
       test      rcx,rcx
       je        short M00_L73
       call      qword ptr [7FFC62F57BA0]; System.Data.DataTableReaderListener.UnSubscribeEvents()
M00_L73:
       xor       eax,eax
       mov       r8,[rbp-40]
       mov       [r8+28],rax
       mov       [r8+10],rax
       mov       byte ptr [r8+38],0
M00_L74:
       add       rsp,28
       ret
; Total bytes of code 2425
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
       mov       rcx,7FFC62F52898
       mov       [rdi+18],rcx
       mov       rbp,[rsi+40]
M01_L00:
       test      rbp,rbp
       je        near ptr M01_L16
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FFC6287AAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       call      00007FFCC24821C0
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
       mov       rcx,7FFC62F52898
       mov       [rdi+18],rcx
       mov       rbp,[rsi+30]
M01_L03:
       test      rbp,rbp
       je        near ptr M01_L18
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FFC6287AAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       call      00007FFCC24821C0
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
       mov       rcx,7FFC62F52910
       mov       [rsi+18],rcx
       mov       rcx,2998E401EF8
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
       call      qword ptr [7FFC6287AAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       mov       rcx,7FFC62F52910
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
       call      qword ptr [7FFC6287AAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       mov       rcx,7FFC62F52958
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
       call      qword ptr [7FFC6287AAF0]; System.MulticastDelegate.RemoveImpl(System.Delegate)
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
       call      qword ptr [7FFC62F5F510]
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
       mov       rdx,2DA23542618
       call      qword ptr [7FFC62F5FA20]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFC62F5C120]
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
       mov       rdx,2DA23542680
       call      qword ptr [7FFC62F5FA20]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFC62F5C120]
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
       mov       rdx,2DA235426E8
       call      qword ptr [7FFC62F5FA20]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFC62F5C120]
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
       mov       rcx,7FFC62F52898
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
       call      00007FFCC24821C0
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
       mov       rcx,7FFC62F52898
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
       call      00007FFCC24821C0
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
       mov       rcx,7FFC62F52910
       mov       [rsi+18],rcx
       mov       rcx,2998E401EF8
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
       mov       rcx,7FFC62F52910
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
       mov       rcx,7FFC62F52958
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
       call      qword ptr [7FFC6287AAE8]
       mov       rdx,rax
       jmp       near ptr M02_L01
M02_L17:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L18:
       mov       rcx,rbp
       mov       rdx,rdi
       call      qword ptr [7FFC6287AAE8]
       mov       rdx,rax
       jmp       near ptr M02_L04
M02_L19:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L20:
       call      qword ptr [7FFC62F5F510]
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
       mov       rdx,2DA235414D8
       call      qword ptr [7FFC62F5FA20]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFC62F5C120]
       jmp       near ptr M02_L06
M02_L22:
       mov       rdx,rsi
       call      qword ptr [7FFC6287AAE8]
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
       mov       rdx,2DA23541538
       call      qword ptr [7FFC62F5FA20]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFC62F5C120]
       jmp       near ptr M02_L09
M02_L25:
       mov       rdx,rsi
       call      qword ptr [7FFC6287AAE8]
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
       mov       rdx,2DA23541598
       call      qword ptr [7FFC62F5FA20]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFC62F5C120]
       jmp       near ptr M02_L12
M02_L28:
       mov       rdx,rsi
       call      qword ptr [7FFC6287AAE8]
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
       call      qword ptr [7FFC62ED7738]; System.Data.DataColumnCollection.get_Item(Int32)
       mov       rax,[rax+28]
       add       rsp,20
       pop       rbp
       ret
M03_L00:
       mov       ecx,0CA7E
       mov       rdx,7FFC62C30D50
       call      qword ptr [7FFC62A67798]
       mov       rcx,rax
       call      qword ptr [7FFC62F5F930]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L01:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC62F5F8E8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L02:
       mov       rcx,[rcx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC62F5F900]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FFC62F5FA68]
       mov       ecx,846B
       mov       rdx,7FFC62C30D50
       call      qword ptr [7FFC62A67798]
       mov       rcx,rax
       call      qword ptr [7FFC62F5FA80]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 188
```
```assembly
; System.Data.DataTableReader.Read()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       cmp       byte ptr [rbx+3D],0
       je        near ptr M04_L09
M04_L00:
       cmp       byte ptr [rbx+38],0
       je        near ptr M04_L10
       cmp       byte ptr [rbx+3E],0
       jne       near ptr M04_L11
       cmp       byte ptr [rbx+3C],0
       jne       near ptr M04_L12
       cmp       byte ptr [rbx+3A],0
       jne       near ptr M04_L13
       mov       esi,[rbx+34]
       mov       r8,[rbx+18]
       mov       r8,[r8+28]
       mov       rdi,[r8+10]
       mov       r8d,[rdi+28]
       lea       ecx,[r8-2]
       cmp       esi,ecx
       jge       near ptr M04_L14
       inc       esi
       mov       [rbx+34],esi
       mov       ecx,esi
       test      ecx,ecx
       jl        near ptr M04_L15
       dec       r8d
       cmp       r8d,ecx
       jle       near ptr M04_L15
       cmp       dword ptr [rdi+2C],0
       jne       near ptr M04_L16
       mov       eax,[rdi+20]
       lea       r8d,[rsi+1]
       test      eax,eax
       jne       short M04_L03
       jmp       near ptr M04_L04
M04_L01:
       mov       eax,[rdx+10]
       sub       r8d,ecx
M04_L02:
       test      eax,eax
       je        near ptr M04_L04
M04_L03:
       mov       rcx,[rdi+8]
       mov       rdx,rcx
       mov       r10d,eax
       sar       r10d,10
       mov       r9d,[rdx+8]
       cmp       r10d,r9d
       jae       near ptr M04_L22
       mov       rdx,[rdx+r10*8+10]
       mov       rdx,[rdx+8]
       movzx     r10d,ax
       cmp       r10d,[rdx+8]
       jae       near ptr M04_L22
       lea       r10,[r10+r10*4]
       lea       rdx,[rdx+r10*8+10]
       mov       r10d,[rdx+0C]
       mov       r11d,r10d
       sar       r11d,10
       cmp       r11d,r9d
       jae       near ptr M04_L22
       mov       r9d,r11d
       mov       rcx,[rcx+r9*8+10]
       mov       rcx,[rcx+8]
       movzx     r9d,r10w
       cmp       r9d,[rcx+8]
       jae       near ptr M04_L22
       lea       r9,[r9+r9*4]
       mov       ecx,[rcx+r9*8+2C]
       inc       ecx
       cmp       r8d,ecx
       jl        near ptr M04_L08
       cmp       ecx,r8d
       jl        near ptr M04_L01
M04_L04:
       xor       r8d,r8d
       mov       [rsp+28],r8d
M04_L05:
       test      eax,eax
       je        near ptr M04_L17
       mov       rcx,[rdi+8]
       mov       edx,eax
       sar       edx,10
       cmp       edx,[rcx+8]
       jae       near ptr M04_L22
       mov       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx+8]
       movzx     edx,ax
       cmp       edx,[rcx+8]
       jae       near ptr M04_L22
       movzx     edx,ax
       lea       rdx,[rdx+rdx*4]
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
M04_L06:
       mov       rcx,[rbx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62EDEA48]; System.Data.DataRow.get_RowState()
       cmp       eax,8
       je        near ptr M04_L19
       cmp       byte ptr [rbx+3B],0
       jne       near ptr M04_L21
M04_L07:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L08:
       mov       eax,r10d
       jmp       near ptr M04_L02
M04_L09:
       mov       byte ptr [rbx+3D],1
       jmp       near ptr M04_L00
M04_L10:
       mov       ecx,0C8B0
       mov       rdx,7FFC62C30D50
       call      qword ptr [7FFC62A67798]
       mov       rcx,rax
       call      qword ptr [7FFC62F5F930]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M04_L11:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC62F5F8E8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M04_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC62F5F900]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M04_L13:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L14:
       mov       byte ptr [rbx+3A],1
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M04_L13
       call      qword ptr [7FFC62F57BA0]; System.Data.DataTableReaderListener.UnSubscribeEvents()
       jmp       short M04_L13
M04_L15:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFC62F56820]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC62F5F8E8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M04_L16:
       lea       r8,[rsp+28]
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFC62F5FDB0]
       jmp       near ptr M04_L05
M04_L17:
       cmp       dword ptr [rdi+30],2
       jne       short M04_L18
       mov       ecx,esi
       call      qword ptr [7FFC62F5FDC8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M04_L18:
       mov       ecx,0D
       call      qword ptr [7FFC62F5FDE0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M04_L19:
       inc       dword ptr [rbx+34]
       mov       edx,[rbx+34]
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+10]
       mov       ecx,[rcx+28]
       dec       ecx
       cmp       edx,ecx
       je        short M04_L20
       mov       edx,[rbx+34]
       mov       rcx,rbx
       call      qword ptr [7FFC62F56A00]; System.Data.DataTableReader.ValidateRow(Int32)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       mov       edx,[rbx+34]
       mov       rdi,[rcx+10]
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FFC62F56A18]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].GetNodeByIndex(Int32)
       mov       [rsp+20],rax
       mov       rcx,rdi
       mov       edx,[rsp+20]
       call      qword ptr [7FFC63014D08]
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L06
M04_L20:
       mov       byte ptr [rbx+3A],1
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        near ptr M04_L13
       call      qword ptr [7FFC62F57BA0]; System.Data.DataTableReaderListener.UnSubscribeEvents()
       jmp       near ptr M04_L13
M04_L21:
       mov       byte ptr [rbx+3B],0
       jmp       near ptr M04_L07
M04_L22:
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
       je        short M05_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFCC24D52E0
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
       call      qword ptr [7FFC62845818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2DA23530008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFC62784000
       call      qword ptr [7FFC62A67798]
       mov       rbx,rax
       call      qword ptr [7FFC62F5F540]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC62A6DAD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M06_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M06_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M06_L01
       test      r8b,18
       jne       short M06_L00
       test      r8b,4
       je        near ptr M06_L09
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M06_L04
M06_L00:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M06_L04
M06_L01:
       cmp       r8,40
       ja        short M06_L05
M06_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M06_L03
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M06_L08
M06_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M06_L04:
       vzeroupper
       ret
M06_L05:
       cmp       r8,800
       ja        near ptr M06_L12
       cmp       r8,100
       jae       short M06_L10
M06_L06:
       mov       r9,r8
       shr       r9,6
M06_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M06_L07
       and       r8,3F
       cmp       r8,10
       ja        short M06_L02
       jmp       short M06_L03
M06_L08:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M06_L03
M06_L09:
       test      r8,r8
       je        short M06_L04
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M06_L04
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M06_L04
M06_L10:
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
       jmp       near ptr M06_L06
M06_L11:
       cmp       rcx,rdx
       jne       short M06_L12
       cmp       [rdx],dl
       jmp       near ptr M06_L04
M06_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFC628466E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 325
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
       je        near ptr M07_L06
       cmp       byte ptr [rbx+3F],0
       jne       near ptr M07_L07
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M07_L08
       cmp       qword ptr [rbx+18],0
       je        near ptr M07_L08
       cmp       [rcx],ecx
       call      qword ptr [7FFC62EDEA48]; System.Data.DataRow.get_RowState()
       cmp       eax,8
       je        near ptr M07_L09
       mov       rcx,[rbx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62EDEA48]; System.Data.DataRow.get_RowState()
       cmp       eax,1
       je        near ptr M07_L09
       cmp       byte ptr [rbx+3B],0
       jne       near ptr M07_L09
       mov       ecx,[rbx+34]
       test      ecx,ecx
       jl        near ptr M07_L10
       mov       rdx,[rbx+18]
       mov       rdx,[rdx+28]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+28]
       dec       edx
       cmp       edx,ecx
       jle       near ptr M07_L10
       cmp       byte ptr [rbx+3E],0
       jne       near ptr M07_L11
       cmp       byte ptr [rbx+3C],0
       jne       near ptr M07_L12
       mov       rbx,[rbx+20]
       mov       rcx,[rbx+10]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFC62ED7738]; System.Data.DataColumnCollection.get_Item(Int32)
       cmp       dword ptr [rbx+40],0FFFFFFFF
       jne       short M07_L01
       mov       edx,[rbx+3C]
       cmp       edx,0FFFFFFFF
       je        short M07_L02
M07_L00:
       mov       rcx,[rax+60]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M07_L05
M07_L01:
       mov       edx,[rbx+40]
       jmp       short M07_L00
M07_L02:
       cmp       dword ptr [rbx+38],0FFFFFFFF
       je        short M07_L03
       mov       rcx,2DA23541750
       call      qword ptr [7FFC62F5FA08]
       mov       rbx,rax
       mov       rcx,offset MT_System.Data.DeletedRowInaccessibleException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFC62F5FA38]
       mov       rcx,2998E401EF8
       mov       rcx,[rcx]
       mov       r9,rsi
       mov       rdx,7FFC62F815B8
       mov       r8,2DA235418D0
       call      qword ptr [7FFC62F56AA8]
       jmp       short M07_L04
M07_L03:
       mov       rcx,2DA23541700
       call      qword ptr [7FFC62F5FA08]
       mov       rsi,rax
       mov       rcx,offset MT_System.Data.RowNotInTableException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFC62F5FA50]
       mov       rcx,2998E401EF8
       mov       rcx,[rcx]
       mov       r9,rbx
       mov       rdx,7FFC62F815B8
       mov       r8,2DA235418D0
       call      qword ptr [7FFC62F56AA8]
       mov       rsi,rbx
M07_L04:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M07_L05:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M07_L06:
       mov       ecx,0CB50
       mov       rdx,7FFC62C30D50
       call      qword ptr [7FFC62A67798]
       mov       rcx,rax
       call      qword ptr [7FFC62F5F930]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M07_L07:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC62F5F948]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M07_L08:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFC62F56820]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC62F5F8E8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M07_L09:
       call      qword ptr [7FFC62F5F960]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M07_L10:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFC62F56820]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC62F5F8E8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M07_L11:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC62F5F8E8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M07_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC62F5F900]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FFC62F5FA68]
       mov       ecx,846B
       mov       rdx,7FFC62C30D50
       call      qword ptr [7FFC62A67798]
       mov       rcx,rax
       call      qword ptr [7FFC62F5FA80]
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
       je        near ptr M08_L06
       cmp       byte ptr [rbx+3F],0
       jne       near ptr M08_L07
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M08_L08
       cmp       qword ptr [rbx+18],0
       je        near ptr M08_L08
       cmp       [rcx],ecx
       call      qword ptr [7FFC62EDEA48]; System.Data.DataRow.get_RowState()
       cmp       eax,8
       je        near ptr M08_L09
       mov       rcx,[rbx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62EDEA48]; System.Data.DataRow.get_RowState()
       cmp       eax,1
       je        near ptr M08_L09
       cmp       byte ptr [rbx+3B],0
       jne       near ptr M08_L09
       mov       ecx,[rbx+34]
       test      ecx,ecx
       jl        near ptr M08_L10
       mov       rdx,[rbx+18]
       mov       rdx,[rdx+28]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+28]
       dec       edx
       cmp       edx,ecx
       jle       near ptr M08_L10
       cmp       byte ptr [rbx+3E],0
       jne       near ptr M08_L11
       cmp       byte ptr [rbx+3C],0
       jne       near ptr M08_L12
       mov       rbx,[rbx+20]
       mov       rcx,[rbx+10]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FFC62ED7738]; System.Data.DataColumnCollection.get_Item(Int32)
       cmp       dword ptr [rbx+40],0FFFFFFFF
       jne       short M08_L01
       mov       edx,[rbx+3C]
       cmp       edx,0FFFFFFFF
       je        short M08_L02
M08_L00:
       mov       rcx,[rax+60]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       jmp       near ptr M08_L05
M08_L01:
       mov       edx,[rbx+40]
       jmp       short M08_L00
M08_L02:
       cmp       dword ptr [rbx+38],0FFFFFFFF
       je        short M08_L03
       mov       rcx,2DA23541750
       call      qword ptr [7FFC62F5FA08]
       mov       rbx,rax
       mov       rcx,offset MT_System.Data.DeletedRowInaccessibleException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFC62F5FA38]
       mov       rcx,2998E401EF8
       mov       rcx,[rcx]
       mov       r9,rsi
       mov       rdx,7FFC62F815B8
       mov       r8,2DA235418D0
       call      qword ptr [7FFC62F56AA8]
       jmp       short M08_L04
M08_L03:
       mov       rcx,2DA23541700
       call      qword ptr [7FFC62F5FA08]
       mov       rsi,rax
       mov       rcx,offset MT_System.Data.RowNotInTableException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFC62F5FA50]
       mov       rcx,2998E401EF8
       mov       rcx,[rcx]
       mov       r9,rbx
       mov       rdx,7FFC62F815B8
       mov       r8,2DA235418D0
       call      qword ptr [7FFC62F56AA8]
       mov       rsi,rbx
M08_L04:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L05:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M08_L06:
       mov       ecx,0CB2A
       mov       rdx,7FFC62C30D50
       call      qword ptr [7FFC62A67798]
       mov       rcx,rax
       call      qword ptr [7FFC62F5F930]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M08_L07:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC62F5F948]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M08_L08:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFC62F56820]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC62F5F8E8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M08_L09:
       call      qword ptr [7FFC62F5F960]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M08_L10:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFC62F56820]; System.Data.DataTableReader.set_ReaderIsInvalid(Boolean)
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC62F5F8E8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M08_L11:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC62F5F8E8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+70]
       call      qword ptr [7FFC62F5F900]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       call      qword ptr [7FFC62F5FA68]
       mov       ecx,846B
       mov       rdx,7FFC62C30D50
       call      qword ptr [7FFC62A67798]
       mov       rcx,rax
       call      qword ptr [7FFC62F5FA80]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 677
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
       jne       short M09_L01
       mov       r14d,4
M09_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M09_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFC62E56940]
       int       3
M09_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M09_L00
M09_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M09_L08
       test      r14d,r14d
       jg        short M09_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M09_L04
M09_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L08
M09_L04:
       mov       rdx,7FFC62FD31F8
       call      qword ptr [7FFC6284C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M09_L03
M09_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+58]
       test      rax,rax
       je        short M09_L09
       mov       rcx,rax
M09_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M09_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FFC629B5050]; System.Array.Copy(System.Array, System.Array, Int32)
M09_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M09_L08:
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
M09_L09:
       mov       rdx,7FFC62F9A1C8
       call      qword ptr [7FFC6284C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M09_L06
; Total bytes of code 303
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
       jbe       short M10_L01
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M10_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M10_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFC629BF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M10_L00
; Total bytes of code 60
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
       jg        near ptr M11_L05
       cmp       eax,esi
       jl        near ptr M11_L05
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M11_L01
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M11_L06
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M11_L07
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M11_L00:
       cmp       ebp,edx
       ja        near ptr M11_L11
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFC62845818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M11_L01:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M11_L08
       cmp       edx,esi
       jl        near ptr M11_L08
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
       jl        near ptr M11_L09
       cmp       eax,400
       jl        short M11_L02
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFC62E5ECE8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
       jmp       short M11_L03
M11_L02:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
M11_L03:
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
       je        near ptr M11_L10
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M11_L04:
       cmp       esi,r8d
       ja        near ptr M11_L11
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFC62845818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M11_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFC62784000
       call      qword ptr [7FFC62A67798]
       mov       rsi,rax
       call      qword ptr [7FFC62F5F7C8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC62A6DAD0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L06:
       test      ecx,ecx
       jne       short M11_L07
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M11_L00
M11_L07:
       call      qword ptr [7FFC629B7198]
       int       3
M11_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFC62784000
       call      qword ptr [7FFC62A67798]
       mov       rsi,rax
       call      qword ptr [7FFC62F5F7E0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC62A6DAD0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC62F5F7F8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M11_L04
M11_L11:
       call      qword ptr [7FFC62CED3E0]
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
       je        short M12_L01
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M12_L01
       mov       rcx,[rbx+8]
       mov       edx,[rbx+18]
       lea       esi,[rdx+r8]
       cmp       esi,[rcx+8]
       ja        short M12_L03
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jle       short M12_L02
       mov       r8d,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FFC62845818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M12_L00:
       mov       [rbx+18],esi
M12_L01:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L02:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       jne       short M12_L00
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M12_L00
M12_L03:
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFC629BF1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M12_L01
; Total bytes of code 121
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
       call      qword ptr [7FFCC22C37D8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M13_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M13_L00:
       call      qword ptr [7FFCC22A8FD8]
       int       3
; Total bytes of code 56
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
       call      qword ptr [7FFCC22CEA60]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M14_L01
       cmp       qword ptr [rdi+10],0
       je        short M14_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M14_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M14_L01:
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
       mov       rcx,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       mov       [rbp-0B0],rcx
       mov       edx,r8d
       mov       [rbp-0A4],edx
       mov       r8d,[rbp-3C]
       mov       [rbp-0A8],r8d
       lea       r9,[rbp-48]
       mov       [rbp-0B8],r9
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFCC22A9030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFCC22A9038]; CORINFO_HELP_JIT_PINVOKE_END
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
       je        near ptr M16_L06
       test      rbx,rbx
       je        near ptr M16_L07
       mov       rcx,[rsi]
       cmp       rcx,[rbx]
       jne       near ptr M16_L07
       cmp       dword ptr [rcx+4],18
       jne       near ptr M16_L07
       cmp       edi,[rsi+8]
       ja        short M16_L07
       cmp       edi,[rbx+8]
       ja        short M16_L07
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       add       rbx,10
       test      dword ptr [rcx],1000000
       je        short M16_L05
       cmp       r8,4000
       jbe       short M16_L00
       mov       rcx,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFC62F5D890]
M16_L00:
       mov       rcx,rbx
       call      00007FFCC24537A0
       cmp       dword ptr [7FFCC2793A90],0
       jne       short M16_L03
M16_L01:
       cmp       dword ptr [7FFCC2793A90],0
       jne       short M16_L04
M16_L02:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M16_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M16_L01
M16_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M16_L02
M16_L05:
       mov       rcx,rbx
       call      qword ptr [7FFC62845818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M16_L01
M16_L06:
       xor       ebp,ebp
       jmp       short M16_L08
M16_L07:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFC62ED61C0]; System.Array.GetLowerBound(Int32)
       mov       ebp,eax
M16_L08:
       test      rbx,rbx
       jne       short M16_L09
       xor       r9d,r9d
       jmp       short M16_L10
M16_L09:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC62ED61C0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
M16_L10:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       call      qword ptr [7FFC62ED61D8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M16_L01
; Total bytes of code 246
```

