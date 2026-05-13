## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperCopyDirectoryBenchmark.CopyDirectory()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,108
       lea       rbp,[rsp+140]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       rbx,[rcx+140]
       mov       rsi,[rcx+138]
       mov       rcx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<>c__DisplayClass8_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+10],1
       test      rbx,rbx
       je        near ptr M00_L15
       mov       rcx,[rbx+8]
       call      qword ptr [7FFBEC61E7A8]; System.IO.Directory.Exists(System.String)
       test      eax,eax
       je        near ptr M00_L16
       mov       rsi,[rdi+8]
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr M00_L18
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       call      qword ptr [7FFBEC61E7A8]; System.IO.Directory.Exists(System.String)
       test      eax,eax
       je        near ptr M00_L19
M00_L00:
       test      eax,eax
       je        near ptr M00_L20
       mov       r8,[rbx+8]
       mov       [rbp-48],r8
       mov       r8,23049DC1310
       mov       [rbp-40],r8
       mov       r8,1EFB50021B0
       mov       rsi,[r8]
       mov       r14,rsi
       mov       r8,[rbp-40]
       test      r8,r8
       je        near ptr M00_L23
       movzx     r15d,byte ptr [rbx+54]
       mov       r8d,[r14+14]
       lea       rdx,[rbp-40]
       lea       rcx,[rbp-48]
       call      qword ptr [7FFBEC61E820]; System.IO.Enumeration.FileSystemEnumerableFactory.NormalizeInputs(System.String ByRef, System.String ByRef, System.IO.MatchType)
       and       eax,r15d
       mov       [rbx+54],al
       movzx     r9d,byte ptr [rbx+54]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp-40]
       mov       r8,r14
       call      qword ptr [7FFBEC61E868]; System.IO.Enumeration.FileSystemEnumerableFactory.FileInfos(System.String, System.String, System.IO.EnumerationOptions, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.IEnumerable<System.IO.FileInfo>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r14,rax
       mov       r8,[rbx+8]
       mov       [rbp-58],r8
       mov       r8,23049DC1310
       mov       [rbp-50],r8
       mov       r8,[rbp-50]
       test      r8,r8
       je        near ptr M00_L23
       movzx     r15d,byte ptr [rbx+54]
       mov       r8d,[rsi+14]
       lea       rdx,[rbp-50]
       lea       rcx,[rbp-58]
       call      qword ptr [7FFBEC61E820]; System.IO.Enumeration.FileSystemEnumerableFactory.NormalizeInputs(System.String ByRef, System.String ByRef, System.IO.MatchType)
       and       eax,r15d
       mov       [rbx+54],al
       movzx     r9d,byte ptr [rbx+54]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp-50]
       mov       r8,rsi
       call      qword ptr [7FFBEC61EC10]; System.IO.Enumeration.FileSystemEnumerableFactory.DirectoryInfos(System.String, System.String, System.IO.EnumerationOptions, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rbx,rax
       mov       rcx,offset MT_System.Action<System.IO.FileInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.IO.DirectoryHelper+<>c__DisplayClass8_0.<CopyDirectory>b__0(System.IO.FileInfo)
       mov       [rsi+18],rdx
       test      r14,r14
       je        near ptr M00_L25
       mov       rdx,1EFB5002200
       mov       r15,[rdx]
       mov       r13,r15
       mov       rdx,[r13+18]
       mov       [rbp-78],rdx
       cmp       qword ptr [rbp-78],0
       je        short M00_L01
       mov       rdx,[rbp-78]
       cmp       dword ptr [rdx+20],0
       jne       near ptr M00_L24
M00_L01:
       mov       r12,r14
       mov       rdx,offset MT_System.IO.FileInfo[]
       cmp       [r12],rdx
       je        short M00_L02
       xor       r12d,r12d
M00_L02:
       mov       rax,r12
       mov       [rbp-0D0],rax
       test      rax,rax
       je        near ptr M00_L09
       mov       rcx,offset MT_System.Threading.Tasks.Parallel+<>c__DisplayClass31_0<System.IO.FileInfo, System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rbp-0D0]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],rcx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       mov       rcx,r12
       mov       rax,[rcx]
       mov       eax,[rax+4]
       add       eax,0FFFFFFE8
       shr       eax,3
       mov       edx,eax
       test      edx,edx
       jne       near ptr M00_L11
       xor       esi,esi
M00_L03:
       cmp       [r12],r12d
       test      eax,eax
       jne       near ptr M00_L12
       mov       eax,[r12+8]
       test      eax,eax
       jl        near ptr M00_L27
       mov       r12d,eax
       dec       r12d
M00_L04:
       inc       r12d
       mov       rcx,offset MT_System.Action<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0E0],rax
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFBEC7F16F8
       mov       r14,[rbp-0E0]
       mov       [r14+18],rcx
       mov       [rsp+20],r13
       mov       [rsp+28],r14
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-90]
       mov       r8d,esi
       mov       r9d,r12d
       mov       rdx,7FFBEC804C40
       call      qword ptr [7FFBEC7F55D8]
M00_L05:
       mov       rcx,offset MT_System.Action<System.IO.DirectoryInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFBEC61A6D0
       mov       [rsi+18],rdx
       test      rbx,rbx
       je        near ptr M00_L25
       mov       rdx,[r15+18]
       mov       [rbp-0C8],rdx
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L06
       mov       rdx,[rbp-0C8]
       cmp       dword ptr [rdx+20],0
       jne       near ptr M00_L26
M00_L06:
       mov       r8,rbx
       mov       rdx,offset MT_System.IO.DirectoryInfo[]
       cmp       [r8],rdx
       je        short M00_L07
       xor       r8d,r8d
M00_L07:
       test      r8,r8
       je        near ptr M00_L13
       mov       [rsp+20],rsi
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       lea       rcx,[rbp-0C0]
       mov       r9,r15
       mov       rdx,7FFBEC809888
       call      qword ptr [7FFBEC7F4CA8]
M00_L08:
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
M00_L09:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.IList<System.IO.FileInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r12,rax
       mov       rax,r12
       mov       [rbp-0D8],rax
       test      rax,rax
       jne       short M00_L10
       mov       rcx,offset MT_System.Collections.Concurrent.Partitioner+DynamicPartitionerForIEnumerable<System.IO.FileInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       word ptr [r12+8],1
       mov       byte ptr [r12+0A],1
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r12+0B],0
       mov       [rsp+20],rsi
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       lea       rcx,[rbp-70]
       mov       r8,r12
       mov       r9,r13
       mov       rdx,7FFBEC6744D8
       call      qword ptr [7FFBEC61EDC0]; System.Threading.Tasks.Parallel.PartitionerForEachWorker[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.Partitioner`1<System.__Canon>, System.Threading.Tasks.ParallelOptions, System.Action`1<System.__Canon>, System.Action`2<System.__Canon,System.Threading.Tasks.ParallelLoopState>, System.Action`3<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64>, System.Func`4<System.__Canon,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`5<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       jmp       near ptr M00_L05
M00_L10:
       mov       rcx,offset MT_System.Threading.Tasks.Parallel+<>c__DisplayClass32_0<System.IO.FileInfo, System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rbp-0D8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+18],rcx
       mov       [r14+20],rcx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       mov       rcx,offset MT_System.Action<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,r12
       mov       r11,7FFBEBF40CB0
       call      qword ptr [r11]
       mov       r12d,eax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFBEC7F1680
       mov       [rsi+18],rcx
       mov       [rsp+20],r13
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-0A8]
       mov       r9d,r12d
       mov       rdx,7FFBEC804C40
       xor       r8d,r8d
       call      qword ptr [7FFBEC7F55D8]
       jmp       near ptr M00_L05
M00_L11:
       movsxd    rdx,edx
       mov       esi,[rcx+rdx*4+10]
       jmp       near ptr M00_L03
M00_L12:
       add       r12,10
       mov       ecx,[r12]
       cdqe
       mov       eax,[r12+rax*4]
       lea       r12d,[rcx+rax-1]
       jmp       near ptr M00_L04
M00_L13:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.IList<System.IO.DirectoryInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M00_L14
       mov       rcx,offset MT_System.Collections.Concurrent.Partitioner+DynamicPartitionerForIEnumerable<System.IO.DirectoryInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       word ptr [rdi+8],1
       mov       byte ptr [rdi+0A],1
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+0B],0
       mov       [rsp+20],rsi
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       lea       rcx,[rbp-0C0]
       mov       r8,rdi
       mov       r9,r15
       mov       rdx,7FFBEC69BC70
       call      qword ptr [7FFBEC61EDC0]; System.Threading.Tasks.Parallel.PartitionerForEachWorker[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.Partitioner`1<System.__Canon>, System.Threading.Tasks.ParallelOptions, System.Action`1<System.__Canon>, System.Action`2<System.__Canon,System.Threading.Tasks.ParallelLoopState>, System.Action`3<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64>, System.Func`4<System.__Canon,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`5<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       jmp       near ptr M00_L08
M00_L14:
       mov       [rsp+20],rsi
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       lea       rcx,[rbp-0C0]
       mov       r8,rax
       mov       r9,r15
       mov       rdx,7FFBEC809918
       call      qword ptr [7FFBEC7F4CD8]
       jmp       near ptr M00_L08
M00_L15:
       call      qword ptr [7FFBEC58F6A8]
       mov       ecx,2075
       mov       rdx,7FFBEC2C4FD8
       call      qword ptr [7FFBEBFFF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FFBEC2C4FD8
       call      qword ptr [7FFBEBFFF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBEBFFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F60
       mov       rdx,7FFBEC2C4FD8
       call      qword ptr [7FFBEBFFF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBEBFFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBEC7F54B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBEC58F168]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L16:
       call      qword ptr [7FFBEC61E790]
       mov       rcx,rax
       mov       r8,[rbx+8]
       mov       rdx,23049DD0BB8
       call      qword ptr [7FFBEC1C5488]; System.String.Concat(System.String, System.String, System.String)
       mov       rcx,23049DD0B60
       mov       rdx,23049DC0390
       call      qword ptr [7FFBEBFFD9C8]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,23049DC0008
       call      qword ptr [7FFBEBFFD9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       test      rsi,rsi
       jne       short M00_L17
       call      qword ptr [7FFBEC7F55A8]
       mov       rsi,rax
M00_L17:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.DirectoryNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,rbx
       call      qword ptr [7FFBEC7F55C0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L18:
       call      qword ptr [7FFBEC58F6A8]
       mov       ecx,549
       mov       rdx,7FFBEC66D450
       call      qword ptr [7FFBEBFFF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FFBEC2C4FD8
       call      qword ptr [7FFBEBFFF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBEBFFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBEC66D450
       call      qword ptr [7FFBEBFFF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBEBFFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBEC7F54B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBEC58F168]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC61E7C0]
       mov       rcx,[rsi+8]
       call      qword ptr [7FFBEC61E7A8]; System.IO.Directory.Exists(System.String)
       jmp       near ptr M00_L00
M00_L20:
       call      qword ptr [7FFBEC61E730]
       mov       rbx,rax
       mov       rsi,[rdi+8]
       test      rbx,rbx
       jne       short M00_L21
       call      qword ptr [7FFBEC7F55A8]
       mov       rbx,rax
M00_L21:
       test      rsi,rsi
       jne       near ptr M00_L22
       call      qword ptr [7FFBEC58F6A8]
       mov       ecx,1436
       mov       rdx,7FFBEC2C4FD8
       call      qword ptr [7FFBEBFFF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FFBEC2C4FD8
       call      qword ptr [7FFBEBFFF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBEBFFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F60
       mov       rdx,7FFBEC2C4FD8
       call      qword ptr [7FFBEBFFF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBEBFFD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBEC7F54B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBEC58F168]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.DirectoryNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFBEC7F55C0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       ecx,1C2C6
       mov       rdx,7FFBEBF34000
       call      qword ptr [7FFBEBFFF228]
       mov       rcx,rax
       call      qword ptr [7FFBEC58ECD0]
       int       3
M00_L24:
       lea       rcx,[rbp-78]
       call      qword ptr [7FFBEC7F4348]
       int       3
M00_L25:
       mov       ecx,3C3
       mov       rdx,7FFBEC66E370
       call      qword ptr [7FFBEBFFF228]
       mov       rcx,rax
       call      qword ptr [7FFBEC58ECD0]
       int       3
M00_L26:
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FFBEC7F4348]
       int       3
M00_L27:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2384
```
```assembly
; System.IO.Directory.Exists(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,2E0
       vzeroupper
       lea       rbp,[rsp+300]
       xor       eax,eax
       mov       [rbp-2D8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-2D0],ymm4
       mov       rax,2FF7D0A0B895
       mov       [rbp-28],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L19
       mov       esi,[rbx+8]
       test      esi,esi
       je        near ptr M01_L19
       lea       rdi,[rbx+0C]
       mov       rcx,rdi
       mov       r8d,esi
       xor       edx,edx
M01_L00:
       cmp       word ptr [rcx+rdx*2],20
       je        near ptr M01_L20
       mov       rcx,rdi
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FFBEC28FD98]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M01_L21
       cmp       esi,4
       jl        short M01_L01
       cmp       word ptr [rdi],5C
       je        near ptr M01_L22
M01_L01:
       mov       rcx,rbx
       call      qword ptr [7FFBEC28FDE0]; System.IO.PathHelper.Normalize(System.String)
       mov       rbx,rax
M01_L02:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-2A0],ymm0
       vmovdqu   xmmword ptr [rbp-28C],xmm0
       xor       esi,esi
       test      rbx,rbx
       je        short M01_L04
       cmp       dword ptr [rbx+8],0
       je        short M01_L04
       mov       edi,[rbx+8]
       dec       edi
       cmp       edi,[rbx+8]
       jae       near ptr M01_L25
       mov       ecx,edi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M01_L18
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M01_L03:
       test      ecx,ecx
       jne       near ptr M01_L24
M01_L04:
       xor       ecx,ecx
       mov       [rbp-2B0],rcx
       mov       [rbp-2AC],ecx
       call      00007FFBEBFE8D08
       lea       rdx,[rbp-2AC]
       mov       ecx,1
       call      00007FFBEBFE8D20
       mov       edi,eax
       call      00007FFBEBFE8D38
       mov       ecx,eax
       call      00007FFC4BCA6B40
       test      edi,edi
       setne     cl
       movzx     ecx,cl
       mov       [rbp-2B0],cl
       movzx     ecx,byte ptr [rbp-2B0]
       mov       [rbp-2C4],cl
       mov       ecx,[rbp-2AC]
       mov       [rbp-2C8],ecx
       test      rbx,rbx
       je        short M01_L05
       mov       ecx,[rbx+8]
       cmp       ecx,104
       jge       short M01_L08
       test      ecx,ecx
       je        short M01_L05
       dec       ecx
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,20
       je        short M01_L08
       cmp       ecx,2E
       je        short M01_L08
M01_L05:
       mov       rax,rbx
M01_L06:
       test      rax,rax
       je        short M01_L09
       add       rax,0C
       mov       rdi,rax
M01_L07:
       mov       [rbp-2B8],rdi
       xor       ecx,ecx
       call      00007FFBEBFE8D08
       lea       r8,[rbp-2A0]
       mov       rcx,rdi
       xor       edx,edx
       call      00007FFBEBFE8DB0
       mov       edi,eax
       call      00007FFBEBFE8D38
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2B8],rax
       call      00007FFC4BCA6B40
       test      edi,edi
       jne       near ptr M01_L13
       jmp       short M01_L10
M01_L08:
       mov       rcx,rbx
       call      qword ptr [7FFBEC6162E0]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       jmp       short M01_L06
M01_L09:
       xor       edi,edi
       jmp       short M01_L07
M01_L10:
       call      00007FFC4BCA6B20
       mov       esi,eax
       mov       ecx,esi
       call      qword ptr [7FFBEC616268]; System.IO.FileSystem.IsPathUnreachableError(Int32)
       test      eax,eax
       jne       near ptr M01_L13
       lea       rcx,[rbp-278]
       mov       edx,250
       call      qword ptr [7FFBEBFF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       lea       rdx,[rbp-278]
       mov       rcx,rbx
       call      qword ptr [7FFBEC7F4528]
       mov       [rbp-2E0],rax
       mov       rcx,[rbp-2E0]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC167810]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       je        short M01_L11
       call      00007FFC4BCA6B20
       mov       esi,eax
       jmp       short M01_L12
M01_L11:
       xor       esi,esi
       lea       rcx,[rbp-2A0]
       lea       rdx,[rbp-278]
       call      qword ptr [7FFBEC7F4540]
       nop
M01_L12:
       mov       rcx,[rbp-2E0]
       mov       edx,1
       call      qword ptr [7FFBEBFFDE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2E0]
       call      qword ptr [7FFBEC1C5590]; System.GC.SuppressFinalize(System.Object)
       nop
M01_L13:
       cmp       byte ptr [rbp-2C4],0
       je        short M01_L14
       xor       ecx,ecx
       mov       [rbp-2C0],ecx
       call      00007FFBEBFE8D08
       lea       rdx,[rbp-2C0]
       mov       ecx,[rbp-2C8]
       call      00007FFBEBFE8D20
       call      00007FFBEBFE8D38
       mov       ecx,eax
       call      00007FFC4BCA6B40
M01_L14:
       test      esi,esi
       je        short M01_L17
M01_L15:
       xor       eax,eax
M01_L16:
       jmp       near ptr M01_L26
M01_L17:
       cmp       dword ptr [rbp-2A0],0FFFFFFFF
       je        short M01_L15
       test      byte ptr [rbp-2A0],10
       setne     al
       movzx     eax,al
       jmp       short M01_L16
M01_L18:
       mov       ecx,1
       jmp       near ptr M01_L03
M01_L19:
       xor       eax,eax
       jmp       near ptr M01_L26
M01_L20:
       inc       edx
       cmp       edx,r8d
       jl        near ptr M01_L00
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC6AE8F8]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF34000
       call      qword ptr [7FFBEBFFF228]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBEC376F40]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L21:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC6AE910]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF34000
       call      qword ptr [7FFBEBFFF228]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBEC376F40]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L22:
       cmp       word ptr [rdi+2],5C
       je        short M01_L23
       cmp       word ptr [rdi+2],3F
       jne       near ptr M01_L01
M01_L23:
       cmp       word ptr [rdi+4],3F
       jne       near ptr M01_L01
       cmp       word ptr [rdi+6],5C
       jne       near ptr M01_L01
       jmp       near ptr M01_L02
M01_L24:
       lea       rcx,[rbx+0C]
       mov       r14d,[rbx+8]
       mov       [rbp-2D8],rcx
       mov       [rbp-2D0],r14d
       lea       rcx,[rbp-2D8]
       call      qword ptr [7FFBEC616298]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r14d
       je        near ptr M01_L04
       mov       r8d,edi
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFBEC287450]; System.String.Substring(Int32, Int32)
       mov       rbx,rax
       jmp       near ptr M01_L04
M01_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L26:
       mov       r8,2FF7D0A0B895
       cmp       [rbp-28],r8
       je        short M01_L27
       call      CORINFO_HELP_FAIL_FAST
M01_L27:
       nop
       add       rsp,2E0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L28:
       xor       eax,eax
       mov       r8,2FF7D0A0B895
       cmp       [rbp-28],r8
       je        short M01_L29
       call      CORINFO_HELP_FAIL_FAST
M01_L29:
       nop
       add       rsp,2E0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-2E0],0
       je        short M01_L30
       mov       rcx,[rbp-2E0]
       mov       edx,1
       call      qword ptr [7FFBEBFFDE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2E0]
       call      qword ptr [7FFBEC1C5590]; System.GC.SuppressFinalize(System.Object)
M01_L30:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       byte ptr [rbp-2C4],0
       je        short M01_L31
       xor       ecx,ecx
       mov       [rbp-2C0],ecx
       call      00007FFBEBFE8D08
       lea       rdx,[rbp-2C0]
       mov       ecx,[rbp-2C8]
       call      00007FFBEBFE8D20
       call      00007FFBEBFE8D38
       mov       ecx,eax
       call      00007FFC4BCA6B40
M01_L31:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       lea       rax,[M01_L28]
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       lea       rax,[M01_L28]
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       lea       rax,[M01_L28]
       add       rsp,28
       ret
; Total bytes of code 1228
```
```assembly
; System.IO.Enumeration.FileSystemEnumerableFactory.NormalizeInputs(System.String ByRef, System.String ByRef, System.IO.MatchType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rbp,[rbx]
       mov       rcx,rbp
       test      rcx,rcx
       je        short M02_L02
       lea       rax,[rcx+0C]
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jle       short M02_L00
       movzx     edx,word ptr [rax]
       cmp       edx,5C
       je        near ptr M02_L06
       cmp       edx,2F
       je        near ptr M02_L06
M02_L00:
       cmp       ecx,2
       jl        near ptr M02_L07
       movzx     edx,word ptr [rax]
       or        edx,20
       add       edx,0FFFFFF9F
       cmp       edx,19
       ja        near ptr M02_L07
       cmp       word ptr [rax+2],3A
       sete      dl
       movzx     edx,dl
M02_L01:
       test      edx,edx
       jne       near ptr M02_L16
M02_L02:
       lea       rcx,[rbp+0C]
       mov       r8d,[rbp+8]
       xor       edx,edx
       call      qword ptr [7FFBEC28FD98]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M02_L17
       mov       rcx,[rdi]
       lea       r8,[rcx+0C]
       mov       edx,[rcx+8]
       mov       rcx,r8
       mov       r8d,edx
       xor       edx,edx
       call      qword ptr [7FFBEC28FD98]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M02_L18
       mov       rcx,[rbx]
       test      rcx,rcx
       jne       short M02_L08
       xor       ebp,ebp
       xor       r14d,r14d
M02_L03:
       test      r14d,r14d
       je        short M02_L05
       xor       ecx,ecx
M02_L04:
       cmp       word ptr [rbp+rcx*2],20
       je        near ptr M02_L19
       mov       [rsp+38],rbp
       mov       [rsp+40],r14d
       lea       rcx,[rsp+38]
       call      qword ptr [7FFBEC61E850]; System.IO.Path.GetDirectoryNameOffset(System.ReadOnlySpan`1<Char>)
       mov       r15d,eax
       test      r15d,r15d
       jge       short M02_L09
M02_L05:
       xor       ebp,ebp
       xor       r15d,r15d
       jmp       short M02_L10
M02_L06:
       mov       edx,1
       jmp       near ptr M02_L01
M02_L07:
       xor       edx,edx
       jmp       near ptr M02_L01
M02_L08:
       lea       rbp,[rcx+0C]
       mov       r14d,[rcx+8]
       jmp       short M02_L03
M02_L09:
       cmp       r15d,r14d
       ja        near ptr M02_L20
M02_L10:
       mov       r14d,1
       test      r15d,r15d
       jne       near ptr M02_L21
M02_L11:
       test      esi,esi
       je        near ptr M02_L14
       cmp       esi,1
       jne       near ptr M02_L24
       mov       rcx,[rbx]
       mov       rdx,23049DC1310
       cmp       rcx,rdx
       je        short M02_L14
       test      rcx,rcx
       je        short M02_L12
       cmp       dword ptr [rcx+8],1
       jne       short M02_L12
       cmp       word ptr [rcx+0C],2A
       je        short M02_L14
M02_L12:
       mov       rcx,[rbx]
       test      rcx,rcx
       je        short M02_L13
       cmp       dword ptr [rcx+8],0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M02_L13
       mov       rcx,[rbx]
       mov       rdx,23049DC0C80
       call      qword ptr [7FFBEBFF6E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       short M02_L13
       mov       rcx,[rbx]
       mov       rdx,23049DD0D08
       call      qword ptr [7FFBEBFF6E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        short M02_L15
M02_L13:
       mov       rcx,23049DC1310
       mov       [rbx],rcx
M02_L14:
       mov       eax,r14d
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L15:
       mov       rcx,[rbx]
       call      qword ptr [7FFBEC7F4AC8]
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M02_L14
M02_L16:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFBEC7F4AB0]
       mov       rdi,rax
       mov       ecx,1C6A4
       mov       rdx,7FFBEBF34000
       call      qword ptr [7FFBEBFFF228]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbp
       call      qword ptr [7FFBEC376F40]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M02_L17:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBEC6AE910]
       mov       rdx,rax
       mov       r8,[rbx]
       mov       rcx,rsi
       call      qword ptr [7FFBEC376F40]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L18:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC6AE910]
       mov       rdx,rax
       mov       r8,[rdi]
       mov       rcx,rbx
       call      qword ptr [7FFBEC376F40]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L19:
       inc       ecx
       cmp       ecx,r14d
       jl        near ptr M02_L04
       jmp       near ptr M02_L05
M02_L20:
       call      qword ptr [7FFBEC1CF228]
       int       3
M02_L21:
       mov       rcx,[rdi]
       test      rcx,rcx
       jne       short M02_L22
       xor       edx,edx
       xor       eax,eax
       jmp       short M02_L23
M02_L22:
       lea       rdx,[rcx+0C]
       mov       eax,[rcx+8]
M02_L23:
       mov       [rsp+38],rdx
       mov       [rsp+40],eax
       mov       [rsp+28],rbp
       mov       [rsp+30],r15d
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       call      qword ptr [7FFBEC6A4420]; System.IO.Path.Join(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx]
       lea       edx,[r15+1]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC375068]; System.String.Substring(Int32)
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       r14d,r14d
       jmp       near ptr M02_L11
M02_L24:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       ecx,1C6DE
       mov       rdx,7FFBEBF34000
       call      qword ptr [7FFBEBFFF228]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBEC6AF168]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 831
```
```assembly
; System.IO.Enumeration.FileSystemEnumerableFactory.FileInfos(System.String, System.String, System.IO.EnumerationOptions, Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1EFB50021E8
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M03_L07
M03_L00:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r15,[r14+10]
       test      rbx,rbx
       je        near ptr M03_L08
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       mov       rcx,1EFB50021C0
       test      rdx,rdx
       cmove     rdx,[rcx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>+DelegateEnumerator
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rsi,[rdi+20]
       mov       r15,[rdi+18]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      bpl,bpl
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rcx,rsi
       call      qword ptr [7FFBEC28FD50]; System.IO.Path.GetFullPath(System.String)
       mov       rsi,rax
M03_L02:
       test      rsi,rsi
       je        short M03_L04
       cmp       dword ptr [rsi+8],0
       je        short M03_L04
       mov       ebp,[rsi+8]
       dec       ebp
       cmp       ebp,[rsi+8]
       jae       near ptr M03_L10
       mov       ecx,ebp
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M03_L06
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M03_L03:
       test      ecx,ecx
       jne       near ptr M03_L09
M03_L04:
       mov       rdx,rsi
M03_L05:
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       mov       rcx,1EFB50021C0
       test      rdx,rdx
       cmove     rdx,[rcx]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+18]
       mov       ecx,[rcx+8]
       mov       [rbx+58],ecx
       mov       rcx,rbx
       call      qword ptr [7FFBEC61EBC8]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].Init()
       lea       rcx,[rbx+68]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>+FindPredicate
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass5_0.<FileInfos>b__1(System.IO.Enumeration.FileSystemEntry ByRef)
       mov       [rbx+18],rcx
       lea       rcx,[rdi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L06:
       mov       ecx,1
       jmp       near ptr M03_L03
M03_L07:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>+FindTransform
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1EFB50021C8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset System.IO.Enumeration.FileSystemEnumerableFactory+<>c.<FileInfos>b__5_0(System.IO.Enumeration.FileSystemEntry ByRef)
       call      qword ptr [7FFBEBFF6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1EFB50021E8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L08:
       mov       ecx,1C67C
       mov       rdx,7FFBEBF34000
       call      qword ptr [7FFBEBFFF228]
       mov       rcx,rax
       call      qword ptr [7FFBEC58ECD0]
       int       3
M03_L09:
       lea       rcx,[rsi+0C]
       mov       r13d,[rsi+8]
       mov       [rsp+20],rcx
       mov       [rsp+28],r13d
       lea       rcx,[rsp+20]
       call      qword ptr [7FFBEC616298]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r13d
       je        near ptr M03_L04
       mov       r8d,ebp
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBEC287450]; System.String.Substring(Int32, Int32)
       mov       rdx,rax
       jmp       near ptr M03_L05
M03_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 661
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L00
       mov       rax,[rdx]
       cmp       rax,rcx
       jne       short M04_L01
M04_L00:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L01:
       mov       r8,1EFB5000038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M04_L02:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M04_L04
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L04
       cmp       ebx,[r11]
       jne       short M04_L03
       cmp       esi,1
       je        short M04_L00
M04_L03:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBEBFF6340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M04_L04:
       test      ebx,ebx
       je        short M04_L03
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M04_L02
       jmp       short M04_L03
; Total bytes of code 155
```
```assembly
; System.IO.Enumeration.FileSystemEnumerableFactory.DirectoryInfos(System.String, System.String, System.IO.EnumerationOptions, Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass6_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1EFB50021F0
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M05_L07
M05_L00:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.DirectoryInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r15,[r14+10]
       test      rbx,rbx
       je        near ptr M05_L08
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       mov       rcx,1EFB50021C0
       test      rdx,rdx
       cmove     rdx,[rcx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.DirectoryInfo>+DelegateEnumerator
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rsi,[rdi+20]
       mov       r15,[rdi+18]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      bpl,bpl
       je        short M05_L01
       jmp       short M05_L02
M05_L01:
       mov       rcx,rsi
       call      qword ptr [7FFBEC28FD50]; System.IO.Path.GetFullPath(System.String)
       mov       rsi,rax
M05_L02:
       test      rsi,rsi
       je        short M05_L04
       cmp       dword ptr [rsi+8],0
       je        short M05_L04
       mov       ebp,[rsi+8]
       dec       ebp
       cmp       ebp,[rsi+8]
       jae       near ptr M05_L10
       mov       ecx,ebp
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M05_L06
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M05_L03:
       test      ecx,ecx
       jne       near ptr M05_L09
M05_L04:
       mov       rdx,rsi
M05_L05:
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       mov       rcx,1EFB50021C0
       test      rdx,rdx
       cmove     rdx,[rcx]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+18]
       mov       ecx,[rcx+8]
       mov       [rbx+58],ecx
       mov       rcx,rbx
       call      qword ptr [7FFBEC61EBC8]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].Init()
       lea       rcx,[rbx+68]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.DirectoryInfo>+FindPredicate
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass6_0.<DirectoryInfos>b__1(System.IO.Enumeration.FileSystemEntry ByRef)
       mov       [rbx+18],rcx
       lea       rcx,[rdi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L06:
       mov       ecx,1
       jmp       near ptr M05_L03
M05_L07:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.DirectoryInfo>+FindTransform
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1EFB50021C8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFBEC61AC28
       call      qword ptr [7FFBEBFF6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1EFB50021F0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L00
M05_L08:
       mov       ecx,1C67C
       mov       rdx,7FFBEBF34000
       call      qword ptr [7FFBEBFFF228]
       mov       rcx,rax
       call      qword ptr [7FFBEC58ECD0]
       int       3
M05_L09:
       lea       rcx,[rsi+0C]
       mov       r13d,[rsi+8]
       mov       [rsp+20],rcx
       mov       [rsp+28],r13d
       lea       rcx,[rsp+20]
       call      qword ptr [7FFBEC616298]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r13d
       je        near ptr M05_L04
       mov       r8d,ebp
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBEC287450]; System.String.Substring(Int32, Int32)
       mov       rdx,rax
       jmp       near ptr M05_L05
M05_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 661
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper+<>c__DisplayClass8_0.<CopyDirectory>b__0(System.IO.FileInfo)
; 			var destFile = Path.Combine(destination.FullName, file.Name);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = file.CopyTo(destFile, overwrite);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,[rsi+8]
       mov       rdi,[rcx+8]
       mov       rdx,[rbx+18]
       test      rdx,rdx
       je        short M06_L03
M06_L00:
       test      rdi,rdi
       je        short M06_L02
       test      rdx,rdx
       je        short M06_L01
       mov       rcx,rdi
       call      qword ptr [7FFBEC6161F0]; System.IO.Path.CombineInternal(System.String, System.String)
       mov       rdx,rax
       movzx     r8d,byte ptr [rsi+10]
       mov       rcx,rbx
       call      qword ptr [7FFBEC6A44F8]; System.IO.FileInfo.CopyTo(System.String, Boolean)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L01:
       mov       ecx,1C488
       mov       rdx,7FFBEBF34000
       call      qword ptr [7FFBEBFFF228]
       mov       rcx,rax
       call      qword ptr [7FFBEC58ECD0]
       int       3
M06_L02:
       mov       ecx,1C47C
       mov       rdx,7FFBEBF34000
       call      qword ptr [7FFBEBFFF228]
       mov       rcx,rax
       call      qword ptr [7FFBEC58ECD0]
       int       3
M06_L03:
       mov       rcx,[rbx+10]
       call      qword ptr [7FFBEC6AF948]
       mov       rbp,rax
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       jmp       near ptr M06_L00
; Total bytes of code 172
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M07_L04
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M07_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jge       short M07_L02
M07_L00:
       cmp       [r10],rcx
       je        short M07_L04
M07_L01:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M07_L05
       cmp       [r10],rcx
       je        short M07_L04
       jmp       short M07_L01
M07_L02:
       cmp       [r10],rcx
       je        short M07_L04
M07_L03:
       cmp       [r10+8],rcx
       je        short M07_L04
       cmp       [r10+10],rcx
       jne       short M07_L07
M07_L04:
       mov       rax,rdx
       ret
M07_L05:
       test      dword ptr [rax],500C0000
       jne       short M07_L08
       xor       edx,edx
       jmp       short M07_L04
M07_L06:
       cmp       [r10],rcx
       je        short M07_L04
       jmp       short M07_L03
M07_L07:
       cmp       [r10+18],rcx
       je        short M07_L04
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M07_L06
       test      r8,r8
       je        short M07_L05
       jmp       short M07_L00
M07_L08:
       jmp       qword ptr [7FFBEC37E5F8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 125
```
```assembly
; System.Threading.Tasks.Parallel.PartitionerForEachWorker[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.Partitioner`1<System.__Canon>, System.Threading.Tasks.ParallelOptions, System.Action`1<System.__Canon>, System.Action`2<System.__Canon,System.Threading.Tasks.ParallelLoopState>, System.Action`3<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64>, System.Func`4<System.__Canon,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`5<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A0
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-38],rdx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M08_L55
M08_L00:
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-90],rdx
       lea       rcx,[rdx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-90]
       lea       rcx,[rdx+20]
       mov       rdx,[rbp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-90]
       lea       rcx,[rdx+28]
       mov       rdx,[rbp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-90]
       lea       rcx,[rdx+30]
       mov       rdx,[rbp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-90]
       lea       rcx,[rdx+38]
       mov       rdx,[rbp+50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-90]
       lea       rcx,[rdx+40]
       mov       rdx,[rbp+58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-90]
       lea       rcx,[rdx+58]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-90]
       lea       rcx,[rdx+68]
       mov       rdx,[rbp+60]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M08_L56
M08_L01:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdx,[rbp-90]
       lea       rcx,[rdx+48]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.Partitioner+DynamicPartitionerForIEnumerable<System.IO.DirectoryInfo>
       cmp       [rsi],rcx
       je        short M08_L02
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       je        near ptr M08_L59
M08_L02:
       mov       rdx,[rbp-90]
       mov       rax,[rdx+10]
       mov       rax,[rax+18]
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        short M08_L03
       mov       rax,[rbp-50]
       cmp       dword ptr [rax+20],0
       jne       near ptr M08_L60
M08_L03:
       xor       eax,eax
       mov       [rdx+70],eax
       mov       rax,1EFB5002220
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       jne       near ptr M08_L61
M08_L04:
       mov       rcx,offset MT_System.Threading.Tasks.ParallelLoopStateFlags<System.Int64>
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,7FFFFFFFFFFFFFFF
       mov       [rax+10],rcx
       mov       rdx,[rbp-90]
       lea       rcx,[rdx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp-80],ecx
       mov       [rbp-88],rcx
       mov       rdx,[rbp-90]
       mov       [rdx+8],rcx
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-50],rcx
       cmp       qword ptr [rbp-50],0
       jne       near ptr M08_L62
       xor       ebx,ebx
       xor       edi,edi
M08_L05:
       mov       [rbp-48],rbx
       mov       [rbp-40],rdi
       xor       ecx,ecx
       mov       [rdx+60],rcx
       mov       [rdx+50],rcx
       mov       rbx,[rdx+48]
       test      rbx,rbx
       je        near ptr M08_L67
       mov       rcx,offset MT_System.Collections.Concurrent.Partitioner+DynamicPartitionerForIEnumerable<System.IO.DirectoryInfo>
       cmp       [rbx],rcx
       jne       near ptr M08_L57
       mov       rsi,[rbx+10]
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.DirectoryInfo>
       cmp       [rsi],rcx
       jne       near ptr M08_L58
       lea       rcx,[rsi+8]
       xor       eax,eax
       mov       rdi,rax
       xchg      rdi,[rcx]
       test      rdi,rdi
       je        near ptr M08_L65
M08_L06:
       mov       rcx,offset MT_System.Collections.Concurrent.Partitioner+DynamicPartitionerForIEnumerable<System.IO.DirectoryInfo>+InternalPartitionEnumerable
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       movzx     ebx,byte ptr [rbx+0B]
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.Partitioner+SharedLong
       call      CORINFO_HELP_NEWSFAST
       mov       qword ptr [rax+8],0FFFFFFFFFFFFFFFF
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.Partitioner+SharedBool
       call      CORINFO_HELP_NEWSFAST
       mov       byte ptr [rax+8],0
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.Partitioner+SharedBool
       call      CORINFO_HELP_NEWSFAST
       mov       byte ptr [rax+8],0
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+4D],bl
       cmp       byte ptr [rsi+4D],0
       jne       short M08_L07
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.Int64, System.IO.DirectoryInfo>[]
       mov       edx,100
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M08_L07:
       xor       ecx,ecx
       mov       [rsi+38],rcx
       mov       rax,rsi
M08_L08:
       mov       rdx,[rbp-90]
       lea       rcx,[rdx+50]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-90]
       cmp       qword ptr [rdx+50],0
       je        near ptr M08_L66
M08_L09:
       mov       rcx,offset MT_System.Threading.Tasks.TaskReplicator+ReplicatableUserAction<System.Collections.IEnumerator>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,offset System.Threading.Tasks.Parallel+<>c__DisplayClass43_0`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<PartitionerForEachWorker>b__1(System.Collections.IEnumerator ByRef, Int64, Boolean ByRef)
       mov       [rbx+18],rax
       mov       rdx,[rbp-90]
       mov       rsi,[rdx+10]
       mov       edi,[rsi+10]
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M08_L33
M08_L10:
       mov       rax,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rcx],rax
       jne       near ptr M08_L34
       mov       r14d,7FFFFFFF
M08_L11:
       test      r14d,r14d
       jle       short M08_L12
       cmp       r14d,7FFFFFFF
       jne       near ptr M08_L35
M08_L12:
       test      edi,edi
       jg        near ptr M08_L38
       mov       edi,7FFFFFFF
M08_L13:
       mov       rcx,offset MT_System.Threading.Tasks.TaskReplicator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueue<System.Threading.Tasks.TaskReplicator+Replica>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueueSegment<System.Threading.Tasks.TaskReplicator+Replica>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentQueueSegment<System.Threading.Tasks.TaskReplicator+Replica>+Slot[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r13+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r13+18],1F
       xor       ecx,ecx
       mov       rdx,[r13+8]
       cmp       dword ptr [rdx+8],0
       jle       short M08_L15
M08_L14:
       mov       rdx,[r13+8]
       mov       rax,rdx
       cmp       ecx,[rax+8]
       jae       near ptr M08_L48
       mov       r8,rcx
       shl       r8,4
       mov       [rax+r8+18],ecx
       inc       ecx
       cmp       [rdx+8],ecx
       jg        short M08_L14
M08_L15:
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+8]
       test      rdx,rdx
       jne       short M08_L16
       call      qword ptr [7FFBEC6AFC30]
       mov       rcx,1EFB5002210
       test      rax,rax
       cmove     rax,[rcx]
       mov       rdx,rax
M08_L16:
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+20],1
       mov       rcx,offset MT_System.Threading.Tasks.TaskReplicator+Replica<System.Collections.IEnumerator>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFFFFFFFFFFFFFF
       mov       [rsi+18],rcx
       dec       edi
       mov       [rsi+20],edi
       mov       rcx,1EFB5002240
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M08_L39
M08_L17:
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+18],rcx
       mov       [r15+34],ecx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M08_L40
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M08_L40
M08_L18:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M08_L19
       call      qword ptr [7FFBEC3749C0]; System.Threading.Thread.InitializeCurrentThread()
M08_L19:
       mov       rdi,[rax+8]
       test      rdi,rdi
       jne       near ptr M08_L41
       mov       rcx,1EFB5002250
       mov       rdi,[rcx]
M08_L20:
       test      rdi,rdi
       je        short M08_L22
       mov       rcx,1EFB5002250
       cmp       rdi,[rcx]
       je        short M08_L23
       mov       rax,[r15+28]
       test      rax,rax
       jne       short M08_L21
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+3C],1
       lea       rcx,[r15+28]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r13
M08_L21:
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M08_L23
M08_L22:
       or        dword ptr [r15+34],20000000
M08_L23:
       lea       rcx,[rsi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsi+8]
       mov       rcx,[rax+10]
       mov       rdx,[rcx+10]
       mov       r8,[rdx+8]
M08_L24:
       mov       edi,[rdx+0A0]
       mov       eax,edi
       and       eax,[rdx+18]
       cmp       eax,[r8+8]
       jae       near ptr M08_L48
       shl       rax,4
       lea       r15,[r8+rax+10]
       mov       r10d,[r15+8]
       sub       r10d,edi
       jne       near ptr M08_L42
       lea       r10,[rdx+0A0]
       lea       r9d,[rdi+1]
       mov       eax,edi
       lock cmpxchg [r10],r9d
       cmp       eax,edi
       jne       short M08_L24
       mov       rcx,r15
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       edi
       mov       [r15+8],edi
M08_L25:
       lea       rcx,[rsi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+10]
       mov       rdx,[rsi+8]
       mov       rdx,[rdx+8]
       cmp       [rcx],cl
       test      rdx,rdx
       je        near ptr M08_L32
       mov       r8d,1
       call      qword ptr [7FFBEC61F480]; System.Threading.Tasks.Task.InternalRunSynchronously(System.Threading.Tasks.TaskScheduler, Boolean)
M08_L26:
       mov       rbx,[r14+10]
       mov       rsi,[rbx+18]
       lea       rdx,[rbp-70]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC6155D8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M08_L30
M08_L27:
       mov       rbx,[rbp-70]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M08_L26
M08_L28:
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       ecx,[rsi+34]
       and       ecx,11000000
       cmp       ecx,1000000
       je        short M08_L29
       mov       rcx,rsi
       mov       r8,[rbp-78]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFBEC6A4918]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       test      eax,eax
       je        short M08_L29
       mov       ecx,[rsi+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       near ptr M08_L43
M08_L29:
       mov       rsi,[rbx+10]
       test      rsi,rsi
       jne       short M08_L28
       jmp       short M08_L26
M08_L30:
       cmp       qword ptr [rsi+10],0
       jne       near ptr M08_L45
       xor       ecx,ecx
       mov       [rbp-70],rcx
M08_L31:
       cmp       qword ptr [r14+18],0
       jne       near ptr M08_L47
       xor       ecx,ecx
       mov       [rbp-70],rcx
       jmp       near ptr M08_L49
M08_L32:
       mov       ecx,2F
       call      qword ptr [7FFBEBFFFD50]
       int       3
M08_L33:
       call      qword ptr [7FFBEC6AFC30]
       mov       rcx,1EFB5002210
       test      rax,rax
       cmove     rax,[rcx]
       mov       rcx,rax
       jmp       near ptr M08_L10
M08_L34:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r14d,eax
       jmp       near ptr M08_L11
M08_L35:
       cmp       edi,0FFFFFFFF
       je        short M08_L36
       cmp       r14d,edi
       cmovg     r14d,edi
       mov       edi,r14d
       jmp       short M08_L37
M08_L36:
       mov       edi,r14d
M08_L37:
       jmp       near ptr M08_L12
M08_L38:
       mov       rcx,rsi
       call      qword ptr [7FFBEC61F270]; System.Threading.Tasks.ParallelOptions.get_EffectiveMaxConcurrencyLevel()
       mov       edi,eax
       jmp       near ptr M08_L13
M08_L39:
       mov       rcx,offset MT_System.Action<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1EFB5002238
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset System.Threading.Tasks.TaskReplicator+Replica+<>c.<.ctor>b__4_0(System.Object)
       call      qword ptr [7FFBEBFF6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1EFB5002240
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L17
M08_L40:
       mov       ecx,4
       call      qword ptr [7FFBEC6AE4A8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M08_L18
M08_L41:
       xor       ecx,ecx
       cmp       byte ptr [rdi+18],0
       cmovne    rdi,rcx
       jmp       near ptr M08_L20
M08_L42:
       test      r10d,r10d
       jge       near ptr M08_L24
       mov       rdx,rsi
       call      qword ptr [7FFBEC6AFD38]
       jmp       near ptr M08_L25
M08_L43:
       mov       rcx,rsi
       call      qword ptr [7FFBEC7F4318]
       mov       ecx,[rsi+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M08_L44
       cmp       qword ptr [rbp-78],0
       je        short M08_L44
       mov       rcx,[rbp-78]
       cmp       dword ptr [rcx+20],0
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M08_L46
M08_L44:
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFBEC7F4360]
       jmp       near ptr M08_L29
M08_L45:
       lea       rdx,[rbp-70]
       mov       rcx,rbx
       call      qword ptr [7FFBEC6AEF40]
       test      eax,eax
       jne       near ptr M08_L27
       jmp       near ptr M08_L31
M08_L46:
       lea       rcx,[rbp-78]
       call      qword ptr [7FFBEC7F4348]
       int       3
M08_L47:
       mov       rcx,offset MT_System.AggregateException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[r14+18]
       mov       rcx,rbx
       call      qword ptr [7FFBEC7F5110]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M08_L49:
       mov       rdx,[rbp-90]
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-50],rcx
       cmp       qword ptr [rbp-50],0
       jne       short M08_L51
M08_L50:
       mov       rdx,[rbp-90]
       cmp       qword ptr [rdx+8],0
       je        short M08_L54
       jmp       short M08_L52
M08_L51:
       lea       rcx,[rbp-48]
       call      qword ptr [7FFBEC7F4FD8]
       jmp       short M08_L50
M08_L52:
       mov       rcx,[rdx+8]
       call      CORINFO_HELP_THROW
       int       3
M08_L53:
       nop
       mov       rdx,[rbp-90]
M08_L54:
       call      M08_L69
       nop
       movzx     eax,byte ptr [rbp-7C]
       mov       rdx,[rbp+10]
       mov       [rdx],al
       movzx     eax,byte ptr [rbp-80]
       mov       [rdx+8],al
       mov       rax,[rbp-88]
       mov       [rdx+10],rax
       mov       rax,rdx
       add       rsp,0A0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M08_L55:
       mov       rcx,rbx
       mov       rdx,7FFBEC7DD1A8
       call      qword ptr [7FFBEBFFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L00
M08_L56:
       mov       rcx,rbx
       mov       rdx,7FFBEC7DD1C0
       call      qword ptr [7FFBEBFFF648]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L01
M08_L57:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       near ptr M08_L08
M08_L58:
       mov       rcx,rsi
       mov       r11,7FFBEBF40BC0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M08_L06
M08_L59:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC7F4F90]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBEC376E98]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L60:
       lea       rcx,[rbp-50]
       call      qword ptr [7FFBEC7F4348]
       int       3
M08_L61:
       mov       rax,7FFBEBF3B180
       mov       ecx,1
       lock xadd [rax],ecx
       inc       ecx
       mov       [rdx+70],ecx
       call      qword ptr [7FFBEC6AFC30]
       mov       rcx,rax
       mov       rax,1EFB5002210
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC61ED78]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       ebx,eax
       call      qword ptr [7FFBEC6AFD98]
       mov       [rbp-58],rax
       mov       dword ptr [rsp+20],3
       xor       r9d,r9d
       mov       [rsp+28],r9
       mov       [rsp+30],r9
       mov       rdx,[rbp-90]
       mov       r9d,[rdx+70]
       mov       rcx,1EFB5002220
       mov       rcx,[rcx]
       mov       edx,ebx
       mov       r8d,[rbp-54]
       call      qword ptr [7FFBEC7F4FA8]
       jmp       near ptr M08_L04
M08_L62:
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-50],rcx
       mov       rcx,offset MT_System.Action<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFBEC7F0F60
       mov       [rbx+18],rdx
       mov       rcx,[rbp-50]
       test      rcx,rcx
       jne       short M08_L63
       xor       ebx,ebx
       xor       edi,edi
       jmp       short M08_L64
M08_L63:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       lea       rdx,[rbp-68]
       mov       r8,rbx
       xor       r9d,r9d
       call      qword ptr [7FFBEC7F45D0]
       mov       rbx,[rbp-68]
       mov       rdi,[rbp-60]
M08_L64:
       mov       rdx,[rbp-90]
       jmp       near ptr M08_L05
M08_L65:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.DirectoryInfo>+DelegateEnumerator
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBEC7F5098]
       jmp       near ptr M08_L06
M08_L66:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC7F4FC0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBEC376E98]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L67:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,[rbp-90]
       lea       rcx,[rdx+60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-90]
       cmp       qword ptr [rdx+60],0
       jne       near ptr M08_L09
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC7F4FC0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBEC376E98]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,38
       mov       rdx,[rbp-90]
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-50],rcx
       cmp       qword ptr [rbp-50],0
       je        short M08_L68
       lea       rcx,[rbp-48]
       call      qword ptr [7FFBEC7F4FD8]
M08_L68:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC7F4FF0]
       mov       rsi,rax
       mov       rdx,[rbp-90]
       mov       rcx,[rdx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC7F5008]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFBEC7F5020]
       lea       rax,[M08_L53]
       add       rsp,38
       ret
M08_L69:
       sub       rsp,38
       mov       rdx,[rbp-90]
       mov       rcx,[rdx+18]
       mov       ecx,[rcx+8]
       test      ecx,ecx
       sete      al
       movzx     eax,al
       mov       [rbp-7C],eax
       test      cl,2
       je        short M08_L70
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC6A4570]
       mov       dword ptr [rbp-80],1
       mov       [rbp-88],rax
       mov       rdx,[rbp-90]
M08_L70:
       mov       rcx,[rdx+50]
       test      rcx,rcx
       je        short M08_L72
       mov       rax,rcx
       test      rax,rax
       je        short M08_L71
       mov       r8,offset MT_System.Collections.Concurrent.Partitioner+DynamicPartitionerForIEnumerable<System.IO.DirectoryInfo>+InternalPartitionEnumerable
       cmp       [rax],r8
       je        short M08_L71
       mov       rdx,rcx
       mov       rcx,offset MT_System.IDisposable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
M08_L71:
       jmp       short M08_L73
M08_L72:
       mov       rdx,[rbp-90]
       mov       rdx,[rdx+60]
       mov       rcx,offset MT_System.IDisposable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
M08_L73:
       test      rax,rax
       je        short M08_L75
       mov       rcx,offset MT_System.Collections.Concurrent.Partitioner+DynamicPartitionerForIEnumerable<System.IO.DirectoryInfo>+InternalPartitionEnumerable
       cmp       [rax],rcx
       jne       short M08_L76
       cmp       byte ptr [rax+4C],0
       jne       short M08_L75
       mov       byte ptr [rax+4C],1
       mov       rbx,[rax+8]
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.IO.FileInfo>+DelegateEnumerator
       cmp       [rbx],rcx
       jne       short M08_L74
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFBEC6A4BE8]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].InternalDispose(Boolean)
       mov       rcx,[rbx]
       test      dword ptr [rcx],100000
       je        short M08_L75
       mov       rcx,rbx
       call      00007FFC4BC60DD0
       jmp       short M08_L75
M08_L74:
       mov       rcx,rbx
       mov       r11,7FFBEBF40BC8
       call      qword ptr [r11]
M08_L75:
       mov       rax,1EFB5002220
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       je        short M08_L78
       jmp       short M08_L77
M08_L76:
       mov       rcx,rax
       mov       r11,7FFBEBF40BB8
       call      qword ptr [r11]
       jmp       short M08_L75
M08_L77:
       call      qword ptr [7FFBEC6AFC30]
       mov       rcx,rax
       mov       rax,1EFB5002210
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC61ED78]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       ebx,eax
       call      qword ptr [7FFBEC6AFD98]
       mov       [rbp-58],rax
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       rdx,[rbp-90]
       mov       r9d,[rdx+70]
       mov       rcx,1EFB5002220
       mov       rcx,[rcx]
       mov       edx,ebx
       mov       r8d,[rbp-54]
       call      qword ptr [7FFBEC7F5038]
M08_L78:
       nop
       add       rsp,38
       ret
; Total bytes of code 3426
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
       je        near ptr M09_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M09_L01
       test      rsi,rsi
       je        short M09_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M09_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M09_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC4BCA9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFBEBFF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFBEBFF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M09_L01:
       test      rsi,rsi
       je        short M09_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M09_L03
M09_L02:
       mov       rax,23049DC0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M09_L03:
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
M09_L04:
       call      qword ptr [7FFBEC6A6F10]
       int       3
; Total bytes of code 244
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
       je        near ptr M10_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M10_L02
       test      rsi,rsi
       je        near ptr M10_L01
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M10_L01
       test      rdi,rdi
       je        near ptr M10_L00
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M10_L00
       mov       r13d,ebp
       mov       r12d,r14d
       add       r12,r13
       mov       eax,r15d
       add       r12,rax
       cmp       r12,7FFFFFFF
       jg        near ptr M10_L03
       mov       rcx,7FFBEC7B11B8
       call      CORINFO_HELP_COUNTPROFILE32
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.String
       call      00007FFC4BCA9D30
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFBEBFF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFBEBFF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[rbx+rcx*2]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFBEBFF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M10_L00:
       mov       rcx,7FFBEC7B11B0
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
       jmp       qword ptr [7FFBEBFFD9C8]; System.String.Concat(System.String, System.String)
M10_L01:
       mov       rcx,7FFBEC7B11AC
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
       jmp       qword ptr [7FFBEBFFD9C8]; System.String.Concat(System.String, System.String)
M10_L02:
       mov       rcx,7FFBEC7B11A8
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
       jmp       qword ptr [7FFBEBFFD9C8]; System.String.Concat(System.String, System.String)
M10_L03:
       mov       rcx,7FFBEC7B11B4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFBEC6A6F10]
       int       3
; Total bytes of code 408
```

