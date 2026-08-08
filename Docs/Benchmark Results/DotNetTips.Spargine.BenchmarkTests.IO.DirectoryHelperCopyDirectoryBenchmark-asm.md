## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,0D8
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       rbx,[rcx+1A0]
       mov       rsi,[rcx+198]
       mov       rcx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<>c__DisplayClass9_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+20],rcx
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+18],1
       test      rbx,rbx
       je        near ptr M00_L29
       mov       rcx,[rbx+8]
       call      qword ptr [7FFB3563EB38]; System.IO.Directory.Exists(System.String)
       test      eax,eax
       je        near ptr M00_L30
       mov       rsi,[r14+10]
       mov       rdx,rsi
       test      rdx,rdx
       je        near ptr M00_L32
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       call      qword ptr [7FFB3563EB38]; System.IO.Directory.Exists(System.String)
       test      eax,eax
       je        near ptr M00_L33
M00_L00:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Threading.Tasks.ParallelOptions
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,263194001E8
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r15+10],0FFFFFFFF
       xor       eax,eax
       mov       [r15+18],rax
       lea       rsi,[r14+20]
       lea       rdi,[r15+18]
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       rbx,[rbx+8]
       mov       rcx,offset MT_System.Char[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_VC
       mov       dword ptr [rax+10],2F005C
       cmp       [rbx],bl
       add       rax,10
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       edx,[rbx+8]
       lea       r8d,[rdx-1]
       test      r8d,r8d
       jl        short M00_L04
       cmp       edx,r8d
       jle       near ptr M00_L38
M00_L01:
       mov       eax,r8d
       movzx     eax,word ptr [rbx+rax*2+0C]
       xor       r10d,r10d
M00_L02:
       movsxd    r9,r10d
       movzx     r9d,word ptr [rcx+r9*2]
       cmp       r9d,eax
       je        short M00_L03
       inc       r10d
       cmp       r10d,2
       jl        short M00_L02
M00_L03:
       cmp       r10d,2
       jne       near ptr M00_L37
M00_L04:
       inc       r8d
       cmp       edx,r8d
       jne       near ptr M00_L14
       mov       rdx,rbx
M00_L05:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[r14+8]
       mov       rcx,26319400200
       mov       rsi,[rcx]
       mov       rdi,rbx
       mov       r13,2A398391310
       mov       r12,r13
       test      rdi,rdi
       je        near ptr M00_L41
       mov       eax,[rsi+14]
       mov       [rbp-44],eax
       lea       r10,[r13+0C]
       mov       [rbp-0B0],r10
       mov       rcx,r10
       mov       r8d,1
       xor       edx,edx
       call      qword ptr [7FFB3529F0A8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M00_L42
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       xor       edx,edx
       call      qword ptr [7FFB3529F0A8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M00_L43
       mov       rbx,[rbp-0B0]
       xor       ecx,ecx
M00_L06:
       cmp       word ptr [rbx+rcx*2],20
       je        near ptr M00_L44
       mov       rcx,rbx
       mov       [rbp-98],rcx
       mov       dword ptr [rbp-90],1
       lea       rcx,[rbp-98]
       call      qword ptr [7FFB35636B20]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       mov       ecx,1
       test      eax,eax
       jg        near ptr M00_L46
M00_L07:
       dec       ecx
       cmp       ecx,1
       jae       near ptr M00_L54
       mov       edx,ecx
       movzx     edx,word ptr [rbx+rdx*2]
       cmp       edx,5C
       je        short M00_L08
       cmp       edx,2F
       je        short M00_L08
       cmp       ecx,eax
       jg        short M00_L07
M00_L08:
       cmp       ecx,eax
       jg        near ptr M00_L47
M00_L09:
       mov       eax,ecx
M00_L10:
       test      eax,eax
       jl        near ptr M00_L45
       cmp       eax,1
       ja        near ptr M00_L49
       mov       edx,eax
M00_L11:
       test      edx,edx
       jne       near ptr M00_L50
M00_L12:
       mov       ebx,[rbp-44]
       test      ebx,ebx
       je        near ptr M00_L18
       cmp       ebx,1
       jne       near ptr M00_L51
       cmp       r12,r13
       je        near ptr M00_L18
       test      r12,r12
       je        short M00_L15
       cmp       dword ptr [r12+8],1
       jne       short M00_L15
       cmp       word ptr [r12+0C],2A
       je        near ptr M00_L18
       jmp       short M00_L16
M00_L13:
       movsxd    r9,r10d
       movzx     r9d,word ptr [rcx+r9*2]
       cmp       r9d,eax
       je        near ptr M00_L39
       inc       r10d
       cmp       r10d,2
       jl        short M00_L13
       jmp       near ptr M00_L39
M00_L14:
       test      r8d,r8d
       je        near ptr M00_L40
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB356CEB50]
       mov       rdx,rax
       jmp       near ptr M00_L05
M00_L15:
       test      r12,r12
       je        short M00_L17
M00_L16:
       cmp       dword ptr [r12+8],0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L17
       mov       rcx,r12
       mov       rdx,2A398390C80
       call      qword ptr [7FFB35006E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       short M00_L17
       mov       rcx,r12
       mov       rdx,2A3983A1080
       call      qword ptr [7FFB35006E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M00_L24
M00_L17:
       mov       r12,r13
M00_L18:
       mov       rcx,rdi
       mov       rdx,r12
       mov       r8,rsi
       call      qword ptr [7FFB3563ED00]; System.IO.Enumeration.FileSystemEnumerableFactory.UserFiles(System.String, System.String, System.IO.EnumerationOptions)
       mov       r13,rax
       mov       rcx,offset MT_System.Action<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.IO.DirectoryHelper+<>c__DisplayClass9_0.<CopyDirectory>b__0(System.String)
       mov       [rbx+18],rdx
       test      r13,r13
       je        near ptr M00_L52
       mov       rdx,[r15+18]
       mov       [rbp-68],rdx
       cmp       qword ptr [rbp-68],0
       je        short M00_L19
       mov       rdx,[rbp-68]
       cmp       dword ptr [rdx+20],0
       jne       near ptr M00_L53
M00_L19:
       mov       r14,r13
       test      r14,r14
       je        short M00_L20
       mov       rdx,offset MT_System.String[]
       cmp       [r14],rdx
       je        short M00_L20
       xor       r14d,r14d
M00_L20:
       mov       rsi,r14
       test      rsi,rsi
       je        near ptr M00_L25
       mov       rcx,offset MT_System.Threading.Tasks.Parallel+<>c__DisplayClass31_0<System.String, System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       mov       [rdi+28],rcx
       mov       [rdi+30],rcx
       mov       rcx,r14
       mov       rax,[rcx]
       mov       eax,[rax+4]
       add       eax,0FFFFFFE8
       shr       eax,3
       mov       edx,eax
       test      edx,edx
       jne       near ptr M00_L27
       xor       ebx,ebx
M00_L21:
       cmp       [r14],r14d
       test      eax,eax
       jne       near ptr M00_L28
       mov       eax,[r14+8]
       test      eax,eax
       jl        near ptr M00_L55
       mov       esi,eax
       dec       esi
M00_L22:
       inc       esi
       mov       rcx,offset MT_System.Action<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFB356CB798
       mov       [r14+18],rcx
       mov       [rsp+20],r15
       mov       [rsp+28],r14
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       lea       rcx,[rbp-80]
       mov       r8d,ebx
       mov       r9d,esi
       mov       rdx,7FFB357FCF38
       call      qword ptr [7FFB356CF6F0]
M00_L23:
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
M00_L24:
       mov       rcx,r12
       call      qword ptr [7FFB356CECB8]
       mov       r12,rax
       jmp       near ptr M00_L18
M00_L25:
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.IList<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M00_L26
       mov       rcx,offset MT_System.Collections.Concurrent.Partitioner+DynamicPartitionerForIEnumerable<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       word ptr [rsi+8],1
       mov       byte ptr [rsi+0A],1
       lea       rcx,[rsi+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+0B],0
       mov       [rsp+20],rbx
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       lea       rcx,[rbp-60]
       mov       r8,rsi
       mov       r9,r15
       mov       rdx,7FFB356A4138
       call      qword ptr [7FFB3563F108]; System.Threading.Tasks.Parallel.PartitionerForEachWorker[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.Partitioner`1<System.__Canon>, System.Threading.Tasks.ParallelOptions, System.Action`1<System.__Canon>, System.Action`2<System.__Canon,System.Threading.Tasks.ParallelLoopState>, System.Action`3<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64>, System.Func`4<System.__Canon,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`5<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
       jmp       near ptr M00_L23
M00_L26:
       mov       [rsp+20],rbx
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       [rsp+40],rcx
       mov       [rsp+48],rcx
       mov       [rsp+50],rcx
       lea       rcx,[rbp-60]
       mov       r8,rax
       mov       r9,r15
       mov       rdx,7FFB357FC968
       call      qword ptr [7FFB356CEEE0]
       jmp       near ptr M00_L23
M00_L27:
       movsxd    rdx,edx
       mov       ebx,[rcx+rdx*4+10]
       jmp       near ptr M00_L21
M00_L28:
       add       r14,10
       mov       ecx,[r14]
       cdqe
       mov       eax,[r14+rax*4]
       lea       esi,[rcx+rax-1]
       jmp       near ptr M00_L22
M00_L29:
       call      qword ptr [7FFB3559F078]
       mov       ecx,2047
       mov       rdx,7FFB352D4C98
       call      qword ptr [7FFB3500F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB352D4C98
       call      qword ptr [7FFB3500F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB3500D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFB352D4C98
       call      qword ptr [7FFB3500F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB3500D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB356CEA30]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB356CEA48]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L30:
       call      qword ptr [7FFB3563EB20]
       mov       rcx,rax
       mov       r8,[rbx+8]
       mov       rdx,2A3983A0F50
       call      qword ptr [7FFB351D5470]; System.String.Concat(System.String, System.String, System.String)
       mov       rcx,2A3983A0EF8
       mov       rdx,2A398390390
       call      qword ptr [7FFB3500D9C8]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2A398390008
       call      qword ptr [7FFB3500D9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       test      rsi,rsi
       jne       short M00_L31
       call      qword ptr [7FFB356CF4F8]
       mov       rsi,rax
M00_L31:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.DirectoryNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,rbx
       call      qword ptr [7FFB356CF510]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L32:
       call      qword ptr [7FFB3559F078]
       mov       ecx,7CD
       mov       rdx,7FFB3569E058
       call      qword ptr [7FFB3500F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB352D4C98
       call      qword ptr [7FFB3500F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB3500D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB3569E058
       call      qword ptr [7FFB3500F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB3500D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB356CEA30]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB356CEA48]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L33:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFB3563EB50]
       mov       rcx,[rsi+8]
       call      qword ptr [7FFB3563EB38]; System.IO.Directory.Exists(System.String)
       jmp       near ptr M00_L00
M00_L34:
       call      qword ptr [7FFB3563EA90]
       mov       rbx,rax
       mov       rsi,[r14+10]
       test      rbx,rbx
       jne       short M00_L35
       call      qword ptr [7FFB356CF4F8]
       mov       rbx,rax
M00_L35:
       test      rsi,rsi
       jne       near ptr M00_L36
       call      qword ptr [7FFB3559F078]
       mov       ecx,1408
       mov       rdx,7FFB352D4C98
       call      qword ptr [7FFB3500F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB352D4C98
       call      qword ptr [7FFB3500F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB3500D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFB352D4C98
       call      qword ptr [7FFB3500F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB3500D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB356CEA30]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB356CEA48]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.DirectoryNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFB356CF510]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L37:
       dec       r8d
       jns       near ptr M00_L01
       jmp       near ptr M00_L04
M00_L38:
       cmp       r8d,edx
       jae       near ptr M00_L54
       mov       eax,r8d
       movzx     eax,word ptr [rbx+rax*2+0C]
       xor       r10d,r10d
       jmp       near ptr M00_L13
M00_L39:
       cmp       r10d,2
       je        near ptr M00_L04
       dec       r8d
       jns       short M00_L38
       jmp       near ptr M00_L04
M00_L40:
       mov       rdx,2A398390008
       jmp       near ptr M00_L05
M00_L41:
       mov       ecx,1AC3E
       mov       rdx,7FFB34F44000
       call      qword ptr [7FFB3500F210]
       mov       rcx,rax
       call      qword ptr [7FFB356C78D0]
       int       3
M00_L42:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB356CC138]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,r13
       call      qword ptr [7FFB35386250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L43:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB356CC138]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFB35386250]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L44:
       inc       ecx
       test      ecx,ecx
       jle       near ptr M00_L06
M00_L45:
       xor       ebx,ebx
       xor       edx,edx
       jmp       near ptr M00_L11
M00_L46:
       mov       eax,0FFFFFFFF
       jmp       near ptr M00_L10
M00_L47:
       lea       edx,[rcx-1]
       cmp       edx,1
       jae       near ptr M00_L54
       lea       edx,[rcx-1]
       movzx     edx,word ptr [rbx+rdx*2]
       cmp       edx,5C
       je        short M00_L48
       cmp       edx,2F
       sete      dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M00_L09
M00_L48:
       dec       ecx
       jmp       near ptr M00_L08
M00_L49:
       call      qword ptr [7FFB351DF210]
       int       3
M00_L50:
       lea       rcx,[rdi+0C]
       mov       eax,[rdi+8]
       mov       [rbp-98],rcx
       mov       [rbp-90],eax
       mov       [rbp-0A8],rbx
       mov       [rbp-84],edx
       mov       [rbp-0A0],edx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-0A8]
       call      qword ptr [7FFB356C47B0]; System.IO.Path.Join(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       r12d,[rbp-84]
       lea       edx,[r12+1]
       mov       rcx,2A398391310
       call      qword ptr [7FFB35384378]; System.String.Substring(Int32)
       mov       r12,rax
       jmp       near ptr M00_L12
M00_L51:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1C6C4
       mov       rdx,7FFB34F44000
       call      qword ptr [7FFB3500F210]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB356CD0B0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L52:
       mov       ecx,3C3
       mov       rdx,7FFB3569E910
       call      qword ptr [7FFB3500F210]
       mov       rcx,rax
       call      qword ptr [7FFB356C78D0]
       int       3
M00_L53:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFB356CCE10]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2648
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
       mov       rax,0D5F19C9D7AF8
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
       call      qword ptr [7FFB3529F0A8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M01_L21
       cmp       esi,4
       jl        short M01_L01
       cmp       word ptr [rdi],5C
       je        near ptr M01_L22
M01_L01:
       mov       rcx,rbx
       call      qword ptr [7FFB3529F0F0]; System.IO.PathHelper.Normalize(System.String)
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
       call      00007FFB34FF8C48
       lea       rdx,[rbp-2AC]
       mov       ecx,1
       call      00007FFB34FF8C60
       mov       edi,eax
       call      00007FFB34FF8C78
       mov       ecx,eax
       call      00007FFB94C81F40
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
       call      00007FFB34FF8C48
       lea       r8,[rbp-2A0]
       mov       rcx,rdi
       xor       edx,edx
       call      00007FFB34FF8D20
       mov       edi,eax
       call      00007FFB34FF8C78
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2B8],rax
       call      00007FFB94C81F40
       test      edi,edi
       jne       near ptr M01_L13
       jmp       short M01_L10
M01_L08:
       mov       rcx,rbx
       call      qword ptr [7FFB35636B68]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       jmp       short M01_L06
M01_L09:
       xor       edi,edi
       jmp       short M01_L07
M01_L10:
       call      00007FFB94C81F20
       mov       esi,eax
       mov       ecx,esi
       call      qword ptr [7FFB35636AF0]; System.IO.FileSystem.IsPathUnreachableError(Int32)
       test      eax,eax
       jne       near ptr M01_L13
       lea       rcx,[rbp-278]
       mov       edx,250
       call      qword ptr [7FFB350057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       lea       rdx,[rbp-278]
       mov       rcx,rbx
       call      qword ptr [7FFB356CCA98]
       mov       [rbp-2E0],rax
       mov       rcx,[rbp-2E0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB35177810]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       je        short M01_L11
       call      00007FFB94C81F20
       mov       esi,eax
       jmp       short M01_L12
M01_L11:
       xor       esi,esi
       lea       rcx,[rbp-2A0]
       lea       rdx,[rbp-278]
       call      qword ptr [7FFB356CCAB0]
       nop
M01_L12:
       mov       rcx,[rbp-2E0]
       mov       edx,1
       call      qword ptr [7FFB3500DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2E0]
       call      qword ptr [7FFB351D5578]; System.GC.SuppressFinalize(System.Object)
       nop
M01_L13:
       cmp       byte ptr [rbp-2C4],0
       je        short M01_L14
       xor       ecx,ecx
       mov       [rbp-2C0],ecx
       call      00007FFB34FF8C48
       lea       rdx,[rbp-2C0]
       mov       ecx,[rbp-2C8]
       call      00007FFB34FF8C60
       call      00007FFB34FF8C78
       mov       ecx,eax
       call      00007FFB94C81F40
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
       call      qword ptr [7FFB356CC120]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FFB34F44000
       call      qword ptr [7FFB3500F210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB35386250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L21:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB356CC138]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FFB34F44000
       call      qword ptr [7FFB3500F210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB35386250]
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
       call      qword ptr [7FFB35636B20]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r14d
       je        near ptr M01_L04
       mov       r8d,edi
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB35297438]; System.String.Substring(Int32, Int32)
       mov       rbx,rax
       jmp       near ptr M01_L04
M01_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L26:
       mov       r8,0D5F19C9D7AF8
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
       mov       r8,0D5F19C9D7AF8
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
       call      qword ptr [7FFB3500DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2E0]
       call      qword ptr [7FFB351D5578]; System.GC.SuppressFinalize(System.Object)
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
       call      00007FFB34FF8C48
       lea       rdx,[rbp-2C0]
       mov       ecx,[rbp-2C8]
       call      00007FFB34FF8C60
       call      00007FFB34FF8C78
       mov       ecx,eax
       call      00007FFB94C81F40
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
; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       cmp       r8d,8
       jl        short M02_L03
       cmp       r8d,10
       jl        near ptr M02_L08
       vmovd     xmm0,edx
       vpbroadcastw ymm0,xmm0
       lea       edx,[r8-10]
       mov       eax,edx
       lea       rax,[rcx+rax*2]
       vpcmpeqw  ymm1,ymm0,[rcx]
       vptest    ymm1,ymm1
       jne       near ptr M02_L10
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M02_L00:
       add       rcx,20
       cmp       rcx,rax
       ja        short M02_L01
       vpcmpeqw  ymm1,ymm0,[rcx]
       vptest    ymm1,ymm1
       jne       near ptr M02_L10
       jmp       short M02_L00
M02_L01:
       mov       r8d,r8d
       test      r8b,0F
       je        short M02_L02
       vpcmpeqw  ymm0,ymm0,[rax]
       vptest    ymm0,ymm0
       jne       near ptr M02_L10
M02_L02:
       xor       eax,eax
       vzeroupper
       ret
M02_L03:
       xor       eax,eax
       cmp       r8d,8
       jl        near ptr M02_L05
M02_L04:
       add       r8d,0FFFFFFF8
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M02_L10
       movsx     r10,word ptr [rcx+rax*2+2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M02_L10
       movsx     r10,word ptr [rcx+rax*2+4]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M02_L10
       movsx     r10,word ptr [rcx+rax*2+6]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M02_L10
       movsx     r10,word ptr [rcx+rax*2+8]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M02_L10
       movsx     r10,word ptr [rcx+rax*2+0A]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M02_L10
       movsx     r10,word ptr [rcx+rax*2+0C]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M02_L10
       movsx     r10,word ptr [rcx+rax*2+0E]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M02_L10
       add       rax,8
       cmp       r8d,8
       jge       near ptr M02_L04
M02_L05:
       cmp       r8d,4
       jl        short M02_L07
       add       r8d,0FFFFFFFC
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M02_L10
       movsx     r10,word ptr [rcx+rax*2+2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M02_L10
       movsx     r10,word ptr [rcx+rax*2+4]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M02_L10
       movsx     r10,word ptr [rcx+rax*2+6]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L10
       add       rax,4
       jmp       short M02_L07
M02_L06:
       dec       r8d
       movsx     r10,word ptr [rcx+rax]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L10
       add       rax,2
       test      r8d,r8d
       jg        short M02_L06
       jmp       near ptr M02_L02
M02_L07:
       test      r8d,r8d
       jle       near ptr M02_L02
       add       rax,rax
       jmp       short M02_L06
M02_L08:
       vmovd     xmm0,edx
       vpbroadcastw xmm0,xmm0
       lea       edx,[r8-8]
       mov       eax,edx
       lea       rax,[rcx+rax*2]
M02_L09:
       vpcmpeqw  xmm1,xmm0,[rcx]
       vptest    xmm1,xmm1
       jne       short M02_L10
       add       rcx,10
       cmp       rcx,rax
       jbe       short M02_L09
       mov       r8d,r8d
       test      r8b,7
       je        near ptr M02_L02
       vpcmpeqw  xmm0,xmm0,[rax]
       vptest    xmm0,xmm0
       je        near ptr M02_L02
M02_L10:
       mov       eax,1
       vzeroupper
       ret
; Total bytes of code 509
```
```assembly
; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,[rcx]
       mov       esi,[rcx+8]
       mov       edi,esi
       xor       ebp,ebp
       cmp       edi,4
       jl        short M03_L00
       cmp       word ptr [rbx],5C
       je        near ptr M03_L20
M03_L00:
       cmp       edi,4
       jl        short M03_L04
M03_L01:
       movzx     ecx,word ptr [rbx]
       cmp       ecx,5C
       je        short M03_L02
       cmp       ecx,2F
       jne       short M03_L04
M03_L02:
       movzx     ecx,word ptr [rbx+2]
       cmp       ecx,5C
       je        short M03_L03
       cmp       ecx,2F
       jne       short M03_L04
M03_L03:
       movzx     ecx,word ptr [rbx+4]
       cmp       ecx,2E
       je        near ptr M03_L10
       cmp       ecx,3F
       je        near ptr M03_L10
M03_L04:
       xor       r14d,r14d
M03_L05:
       test      r14d,r14d
       jne       near ptr M03_L24
       xor       r15d,r15d
M03_L06:
       movzx     eax,r15b
       test      r14d,r14d
       sete      cl
       movzx     ecx,cl
       or        ecx,eax
       je        short M03_L07
       test      edi,edi
       jle       short M03_L07
       movzx     ecx,word ptr [rbx]
       cmp       ecx,5C
       je        short M03_L12
       cmp       ecx,2F
       je        short M03_L12
M03_L07:
       test      r14d,r14d
       jne       near ptr M03_L25
       cmp       esi,2
       jl        short M03_L09
       cmp       word ptr [rbx+2],3A
       jne       short M03_L09
       movzx     eax,word ptr [rbx]
       or        eax,20
       add       eax,0FFFFFF9F
       cmp       eax,19
       ja        short M03_L09
       mov       ebp,2
       cmp       esi,2
       jle       short M03_L09
       movzx     eax,word ptr [rbx+4]
       cmp       eax,5C
       je        short M03_L08
       cmp       eax,2F
       jne       short M03_L09
M03_L08:
       inc       ebp
M03_L09:
       mov       eax,ebp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L10:
       movzx     ecx,word ptr [rbx+6]
       cmp       ecx,5C
       je        near ptr M03_L22
       cmp       ecx,2F
       sete      r14b
       movzx     r14d,r14b
M03_L11:
       jmp       near ptr M03_L05
M03_L12:
       test      eax,eax
       jne       short M03_L15
       cmp       edi,1
       jle       short M03_L14
       movzx     eax,word ptr [rbx+2]
       cmp       eax,5C
       je        short M03_L13
       cmp       eax,2F
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L14
M03_L13:
       mov       eax,2
       jmp       short M03_L16
M03_L14:
       mov       ebp,1
       jmp       short M03_L09
M03_L15:
       mov       eax,8
M03_L16:
       mov       ebp,eax
       mov       eax,2
       jmp       short M03_L19
M03_L17:
       dec       eax
       test      eax,eax
       jle       short M03_L09
M03_L18:
       inc       ebp
M03_L19:
       cmp       ebp,esi
       jge       short M03_L09
       mov       ecx,ebp
       movzx     ecx,word ptr [rbx+rcx*2]
       cmp       ecx,5C
       je        short M03_L17
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L18
       jmp       short M03_L17
M03_L20:
       cmp       word ptr [rbx+2],5C
       je        short M03_L21
       cmp       word ptr [rbx+2],3F
       jne       near ptr M03_L00
M03_L21:
       movzx     ecx,word ptr [rbx+4]
       cmp       ecx,3F
       jne       near ptr M03_L00
       cmp       word ptr [rbx+6],5C
       je        short M03_L23
       jmp       near ptr M03_L01
M03_L22:
       mov       r14d,1
       jmp       near ptr M03_L11
M03_L23:
       mov       r14d,1
       jmp       near ptr M03_L05
M03_L24:
       mov       [rsp+28],rbx
       mov       [rsp+30],edi
       lea       rcx,[rsp+28]
       call      qword ptr [7FFB356CCD68]
       mov       r15d,eax
       jmp       near ptr M03_L06
M03_L25:
       mov       ebp,4
       jmp       short M03_L27
M03_L26:
       inc       ebp
M03_L27:
       cmp       ebp,esi
       jge       near ptr M03_L09
       mov       eax,ebp
       movzx     eax,word ptr [rbx+rax*2]
       cmp       eax,5C
       je        short M03_L28
       cmp       eax,2F
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L26
       jmp       short M03_L29
M03_L28:
       cmp       ebp,4
       jle       near ptr M03_L09
       jmp       short M03_L30
M03_L29:
       cmp       ebp,4
       jle       near ptr M03_L09
M03_L30:
       mov       eax,ebp
       movzx     eax,word ptr [rbx+rax*2]
       cmp       eax,5C
       je        near ptr M03_L08
       cmp       eax,2F
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M03_L09
       jmp       near ptr M03_L08
; Total bytes of code 542
```
```assembly
; System.String.Equals(System.String, System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       rbx,rsi
       je        short M04_L02
       test      rbx,rbx
       je        short M04_L00
       test      rsi,rsi
       je        short M04_L03
       mov       ecx,[rbx+8]
       cmp       ecx,[rsi+8]
       je        short M04_L01
       mov       rcx,7FFB35703064
       call      CORINFO_HELP_COUNTPROFILE32
M04_L00:
       mov       rcx,7FFB35703068
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L01:
       mov       rcx,7FFB35703070
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       call      qword ptr [7FFB3500C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rcx,7FFB35703060
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,7FFB3570306C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L00
; Total bytes of code 162
```
```assembly
; System.IO.Enumeration.FileSystemEnumerableFactory.UserFiles(System.String, System.String, System.IO.EnumerationOptions)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass2_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,26319400218
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M05_L10
M05_L00:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+10]
       mov       r15,[rbp+8]
       mov       r13,r15
       test      rbx,rbx
       je        near ptr M05_L11
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,26319400208
       test      rdx,rdx
       cmove     rdx,[rcx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+28]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.String>+DelegateEnumerator
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rsi,[rdi+20]
       mov       r14,[rdi+18]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbx+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+69],1
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       r13,[rsi+0C]
       mov       rcx,r13
       mov       r12d,[rsi+8]
       mov       r8d,r12d
       test      r8d,r8d
       je        near ptr M05_L13
       xor       edx,edx
M05_L01:
       cmp       word ptr [rcx+rdx*2],20
       je        near ptr M05_L12
       mov       rcx,r13
       mov       r8d,r12d
       xor       edx,edx
       call      qword ptr [7FFB3529F0A8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M05_L14
       cmp       r12d,4
       jl        short M05_L02
       cmp       word ptr [r13],5C
       je        near ptr M05_L15
M05_L02:
       mov       rcx,rsi
       call      qword ptr [7FFB3529F0F0]; System.IO.PathHelper.Normalize(System.String)
       mov       rsi,rax
M05_L03:
       test      rsi,rsi
       je        short M05_L05
       cmp       dword ptr [rsi+8],0
       je        short M05_L05
       mov       r13d,[rsi+8]
       dec       r13d
       cmp       r13d,[rsi+8]
       jae       near ptr M05_L22
       mov       ecx,r13d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M05_L09
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M05_L04:
       test      ecx,ecx
       jne       near ptr M05_L17
M05_L05:
       mov       rdx,rsi
M05_L06:
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,26319400208
       test      rdx,rdx
       cmove     rdx,[rcx]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+18]
       mov       ecx,[rcx+8]
       mov       [rbx+60],ecx
       mov       rcx,rbx
       call      qword ptr [7FFB3563F078]; System.IO.Enumeration.FileSystemEnumerator`1[[System.__Canon, System.Private.CoreLib]].Init()
       mov       rcx,[rbx+18]
       cmp       byte ptr [rcx+1C],0
       je        near ptr M05_L18
M05_L07:
       xor       r15d,r15d
M05_L08:
       lea       rcx,[rbx+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.String>+FindPredicate
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.IO.Enumeration.FileSystemEnumerableFactory+<>c__DisplayClass2_0.<UserFiles>b__1(System.IO.Enumeration.FileSystemEntry ByRef)
       mov       [rbx+18],rcx
       lea       rcx,[rdi+30]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
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
M05_L09:
       mov       ecx,1
       jmp       near ptr M05_L04
M05_L10:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.String>+FindTransform
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,26319400210
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset System.IO.Enumeration.FileSystemEnumerableFactory+<>c.<UserFiles>b__2_0(System.IO.Enumeration.FileSystemEntry ByRef)
       call      qword ptr [7FFB35006BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26319400218
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L00
M05_L11:
       mov       ecx,1C67E
       mov       rdx,7FFB34F44000
       call      qword ptr [7FFB3500F210]
       mov       rcx,rax
       call      qword ptr [7FFB356C78D0]
       int       3
M05_L12:
       inc       edx
       cmp       edx,r8d
       jl        near ptr M05_L01
M05_L13:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB356CC120]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FFB34F44000
       call      qword ptr [7FFB3500F210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB35386250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L14:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB356CC138]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FFB34F44000
       call      qword ptr [7FFB3500F210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB35386250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L15:
       cmp       word ptr [r13+2],5C
       je        short M05_L16
       cmp       word ptr [r13+2],3F
       jne       near ptr M05_L02
M05_L16:
       cmp       word ptr [r13+4],3F
       jne       near ptr M05_L02
       cmp       word ptr [r13+6],5C
       jne       near ptr M05_L02
       jmp       near ptr M05_L03
M05_L17:
       lea       rcx,[rsi+0C]
       mov       r12d,[rsi+8]
       mov       [rsp+28],rcx
       mov       [rsp+30],r12d
       lea       rcx,[rsp+28]
       call      qword ptr [7FFB35636B20]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r12d
       je        near ptr M05_L05
       mov       r8d,r13d
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB35297438]; System.String.Substring(Int32, Int32)
       mov       rdx,rax
       jmp       near ptr M05_L06
M05_L18:
       test      r15,r15
       je        near ptr M05_L08
       cmp       dword ptr [r15+8],0FF
       setg      sil
       movzx     esi,sil
       test      esi,esi
       jne       short M05_L21
       mov       rcx,r15
       mov       rdx,2A398391310
       call      qword ptr [7FFB35006E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       short M05_L19
       mov       rcx,r15
       mov       rdx,2A398390C80
       call      qword ptr [7FFB35006E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       short M05_L19
       mov       rcx,r15
       mov       rdx,2A3983A1118
       call      qword ptr [7FFB35006E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        short M05_L20
M05_L19:
       mov       esi,1
       jmp       short M05_L21
M05_L20:
       xor       esi,esi
M05_L21:
       test      esi,esi
       jne       near ptr M05_L07
       mov       rcx,[rbx+18]
       cmp       dword ptr [rcx+14],0
       jne       near ptr M05_L08
       mov       rcx,r15
       call      qword ptr [7FFB356CEE38]
       mov       r15,rax
       jmp       near ptr M05_L08
M05_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1137
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper+<>c__DisplayClass9_0.<CopyDirectory>b__0(System.String)
; 			cancellationToken.ThrowIfCancellationRequested();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var relative = Path.GetRelativePath(sourceRoot, srcPath);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var destFile = Path.Combine(destination.FullName, relative);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var destDir = Path.GetDirectoryName(destFile);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (destDir is not null)
; 			^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = Directory.CreateDirectory(destDir);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			File.Copy(srcPath, destFile, overwrite);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,3C8
       vzeroupper
       lea       rbp,[rsp+400]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-380],xmm4
       mov       rax,0FFFFFFFFFFFFFCD0
M06_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M06_L00
       mov       rax,0D5F19C9D7AF8
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,rdx
       lea       rcx,[rbp-340]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp-328],rcx
       mov       rcx,rbp
       mov       [rbp-318],rcx
       lea       rcx,[rbx+20]
       cmp       qword ptr [rcx],0
       je        short M06_L01
       mov       rdx,[rcx]
       cmp       dword ptr [rdx+20],0
       jne       near ptr M06_L64
M06_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       mov       r8d,5
       call      qword ptr [7FFB356C4888]; System.IO.Path.GetRelativePath(System.String, System.String, System.StringComparison)
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       r15,[rcx+8]
       test      r15,r15
       je        near ptr M06_L65
       test      r14,r14
       je        near ptr M06_L66
       cmp       dword ptr [r15+8],0
       jne       near ptr M06_L19
M06_L02:
       test      r14,r14
       je        near ptr M06_L69
       lea       r15,[r14+0C]
       mov       rcx,r15
       mov       r13d,[r14+8]
       mov       eax,r13d
       test      eax,eax
       je        near ptr M06_L69
       xor       edx,edx
M06_L03:
       cmp       word ptr [rcx+rdx*2],20
       je        near ptr M06_L68
       mov       r12,r15
       mov       eax,r13d
       mov       [rbp-344],eax
       mov       [rbp-360],r12
       mov       [rbp-358],eax
       lea       rcx,[rbp-360]
       call      qword ptr [7FFB35636B20]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       mov       edx,[rbp-344]
       mov       ecx,edx
       cmp       ecx,eax
       jle       near ptr M06_L70
M06_L04:
       dec       ecx
       cmp       ecx,edx
       jae       near ptr M06_L82
       mov       r8d,ecx
       movzx     r8d,word ptr [r12+r8*2]
       cmp       r8d,5C
       je        short M06_L05
       cmp       r8d,2F
       je        short M06_L05
       cmp       ecx,eax
       jg        short M06_L04
M06_L05:
       cmp       ecx,eax
       jg        near ptr M06_L71
M06_L06:
       mov       r8d,ecx
M06_L07:
       test      r8d,r8d
       jl        near ptr M06_L69
       cmp       r13d,r8d
       jb        near ptr M06_L73
       test      r8d,r8d
       je        near ptr M06_L74
       cmp       r13d,r8d
       je        near ptr M06_L75
       mov       r13d,r8d
       mov       edx,r8d
       mov       rcx,offset MT_System.String
       call      00007FFB94C850F0
       mov       r12,rax
       cmp       [r12],r12b
       lea       rcx,[r12+0C]
       mov       rdx,r15
       lea       r8,[r13+r13]
       call      qword ptr [7FFB35005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r12
M06_L08:
       call      qword ptr [7FFB356C4918]; System.IO.PathInternal.NormalizeDirectorySeparators(System.String)
       mov       r15,rax
M06_L09:
       test      r15,r15
       je        short M06_L10
       cmp       dword ptr [r15+8],0
       je        near ptr M06_L76
       mov       rcx,r15
       call      qword ptr [7FFB3529F060]; System.IO.Path.GetFullPath(System.String)
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFB35636AD8]; System.IO.FileSystem.CreateDirectory(System.String, Byte[])
M06_L10:
       movzx     ebx,byte ptr [rbx+18]
       test      rsi,rsi
       je        near ptr M06_L61
       cmp       dword ptr [rsi+8],0
       je        near ptr M06_L61
       test      r14,r14
       je        near ptr M06_L60
       mov       r13d,[r14+8]
       test      r13d,r13d
       je        near ptr M06_L60
       mov       rcx,rsi
       call      qword ptr [7FFB3529F060]; System.IO.Path.GetFullPath(System.String)
       mov       rsi,rax
       mov       [rbp-388],rsi
       mov       rcx,r14
       call      qword ptr [7FFB3529F060]; System.IO.Path.GetFullPath(System.String)
       mov       r14,rax
       mov       [rbp-390],r14
       test      ebx,ebx
       sete      bl
       movzx     ebx,bl
       xor       ecx,ecx
       mov       [rbp-298],ecx
       test      rsi,rsi
       je        short M06_L11
       mov       r15d,[rsi+8]
       cmp       r15d,104
       jge       near ptr M06_L24
       test      r15d,r15d
       je        short M06_L11
       dec       r15d
       mov       ecx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M06_L24
       cmp       ecx,2E
       je        near ptr M06_L24
M06_L11:
       mov       r15,rsi
M06_L12:
       test      r14,r14
       je        short M06_L13
       cmp       dword ptr [r14+8],104
       jge       near ptr M06_L25
       cmp       dword ptr [r14+8],0
       je        short M06_L13
       mov       r13d,[r14+8]
       dec       r13d
       cmp       r13d,[r14+8]
       jae       near ptr M06_L82
       mov       ecx,r13d
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M06_L25
       cmp       ecx,2E
       je        near ptr M06_L25
M06_L13:
       mov       rax,r14
M06_L14:
       test      rax,rax
       je        near ptr M06_L26
       add       rax,0C
       mov       r13,rax
M06_L15:
       mov       [rbp-2A0],r13
       test      r15,r15
       je        near ptr M06_L27
       add       r15,0C
M06_L16:
       mov       [rbp-2A8],r15
       xor       ecx,ecx
       mov       rax,7FFBCD915FF0
       call      rax
       lea       rcx,[rbp-298]
       mov       [rsp+20],rcx
       mov       [rsp+28],ebx
       mov       rcx,r15
       mov       rdx,r13
       xor       r8d,r8d
       xor       r9d,r9d
       mov       rax,7FFB3517E928
       mov       [rbp-330],rax
       lea       rax,[M06_L17]
       mov       [rbp-320],rax
       lea       rax,[rbp-340]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFBCD920A00
       call      rax
M06_L17:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFB94F44A90],0
       je        short M06_L18
       call      qword ptr [7FFB94F32648]; CORINFO_HELP_STOP_FOR_GC
M06_L18:
       mov       rcx,[rbp-338]
       mov       [rdi+8],rcx
       mov       ebx,eax
       mov       rax,7FFBCD915F30
       call      rax
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2A8],rax
       mov       [rbp-2A0],rax
       call      00007FFB94C81F40
       test      ebx,ebx
       jne       near ptr M06_L28
       call      00007FFB94C81F20
       mov       ebx,eax
       jmp       near ptr M06_L29
M06_L19:
       cmp       dword ptr [r14+8],0
       je        near ptr M06_L23
       lea       rcx,[r14+0C]
       mov       eax,[r14+8]
       mov       [rbp-360],rcx
       mov       [rbp-358],eax
       lea       rcx,[rbp-360]
       call      qword ptr [7FFB35636A90]; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       near ptr M06_L02
       lea       r13,[r15+0C]
       mov       r15d,[r15+8]
       lea       r12,[r14+0C]
       mov       r14d,[r14+8]
       lea       ecx,[r15-1]
       movzx     ecx,word ptr [r13+rcx*2]
       cmp       ecx,5C
       je        short M06_L22
       cmp       ecx,2F
       je        short M06_L22
       movzx     ecx,word ptr [r12]
       cmp       ecx,5C
       je        near ptr M06_L67
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M06_L20:
       test      ecx,ecx
       jne       short M06_L22
       mov       rcx,2A3983981EC
       mov       [rbp-360],r13
       mov       [rbp-358],r15d
       mov       [rbp-370],rcx
       mov       dword ptr [rbp-368],1
       mov       [rbp-380],r12
       mov       [rbp-378],r14d
       lea       rcx,[rbp-360]
       lea       rdx,[rbp-370]
       lea       r8,[rbp-380]
       call      qword ptr [7FFB35636C28]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r14,rax
M06_L21:
       jmp       near ptr M06_L02
M06_L22:
       mov       [rbp-360],r13
       mov       [rbp-358],r15d
       mov       [rbp-370],r12
       mov       [rbp-368],r14d
       lea       rcx,[rbp-360]
       lea       rdx,[rbp-370]
       call      qword ptr [7FFB3538D9E0]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r14,rax
       jmp       short M06_L21
M06_L23:
       mov       r14,r15
       jmp       near ptr M06_L02
M06_L24:
       mov       rcx,rsi
       call      qword ptr [7FFB35636B68]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       r15,rax
       jmp       near ptr M06_L12
M06_L25:
       mov       rcx,r14
       call      qword ptr [7FFB35636B68]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       jmp       near ptr M06_L14
M06_L26:
       xor       r13d,r13d
       jmp       near ptr M06_L15
M06_L27:
       xor       r15d,r15d
       jmp       near ptr M06_L16
M06_L28:
       xor       ebx,ebx
M06_L29:
       test      ebx,ebx
       jne       short M06_L31
       mov       r8,0D5F19C9D7AF8
       cmp       [rbp-40],r8
       je        short M06_L30
       call      CORINFO_HELP_FAIL_FAST
M06_L30:
       nop
       add       rsp,3C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L31:
       mov       r14,[rbp-390]
       mov       [rbp-398],r14
       cmp       ebx,50
       je        near ptr M06_L77
       mov       r15,[rbp-388]
       test      r15,r15
       je        short M06_L32
       mov       ecx,[r15+8]
       cmp       ecx,104
       jge       near ptr M06_L62
       test      ecx,ecx
       je        short M06_L32
       dec       ecx
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M06_L62
       cmp       ecx,2E
       je        near ptr M06_L62
M06_L32:
       mov       r13,r15
M06_L33:
       xor       ecx,ecx
       mov       [rbp-2AC],ecx
       mov       byte ptr [rbp-348],0
       mov       rcx,2A3983A0768
       mov       rax,offset MT_Microsoft.Win32.SafeHandles.SafeFileHandle
       mov       eax,[rax]
       and       eax,0C0000
       cmp       eax,40000
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M06_L63
       call      qword ptr [7FFB351D5668]; System.RuntimeType.CreateInstanceOfT()
       mov       r12,rax
M06_L34:
       xor       ecx,ecx
       mov       [rbp-2C0],rcx
       mov       [rbp-3A8],r12
       mov       [rbp-3C0],r12
       test      r13,r13
       je        near ptr M06_L38
       add       r13,0C
M06_L35:
       mov       [rbp-2B8],r13
       xor       ecx,ecx
       mov       rax,7FFBCD915FF0
       call      rax
       mov       dword ptr [rsp+20],3
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,r13
       mov       edx,80000000
       mov       r8d,1
       xor       r9d,r9d
       mov       rax,7FFB3517E9A8
       mov       [rbp-330],rax
       lea       rax,[M06_L36]
       mov       [rbp-320],rax
       lea       rax,[rbp-340]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFBCD924EA0
       call      rax
M06_L36:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFB94F44A90],0
       je        short M06_L37
       call      qword ptr [7FFB94F32648]; CORINFO_HELP_STOP_FOR_GC
M06_L37:
       mov       rcx,[rbp-338]
       mov       [rdi+8],rcx
       mov       rsi,rax
       mov       rax,7FFBCD915F30
       call      rax
       jmp       short M06_L39
M06_L38:
       xor       r13d,r13d
       jmp       near ptr M06_L35
M06_L39:
       xor       ecx,ecx
       mov       [rbp-2B8],rcx
       mov       dword ptr [rbp-2AC],1
       mov       byte ptr [rbp-348],1
       mov       r12,[rbp-3A8]
       mov       [r12+8],rsi
       mov       ecx,eax
       call      00007FFB94C81F40
       mov       [rbp-3A0],r12
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFB35177810]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       mov       rsi,[rbp-388]
       cmove     rsi,[rbp-398]
       mov       [rbp-398],rsi
       mov       rsi,[rbp-398]
       mov       rcx,r12
       mov       edx,1
       call      qword ptr [7FFB3500DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[r12]
       test      dword ptr [rcx],100000
       je        short M06_L40
       mov       rcx,r12
       call      00007FFB94C3D4D0
M06_L40:
       cmp       ebx,5
       jne       near ptr M06_L58
       vxorps    ymm1,ymm1,ymm1
       vmovdqu   ymmword ptr [rbp-2E8],ymm1
       vmovdqu   xmmword ptr [rbp-2D4],xmm1
       xor       r14d,r14d
       mov       r15,[rbp-390]
       test      r15,r15
       je        short M06_L42
       cmp       dword ptr [r15+8],0
       je        short M06_L42
       mov       r13d,[r15+8]
       dec       r13d
       cmp       r13d,[r15+8]
       jae       near ptr M06_L82
       mov       ecx,r13d
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M06_L78
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M06_L41:
       test      ecx,ecx
       jne       near ptr M06_L79
M06_L42:
       mov       r12,r15
       mov       [rbp-3B8],r12
       mov       [rbp-398],rsi
M06_L43:
       xor       ecx,ecx
       mov       [rbp-2F8],rcx
       mov       [rbp-2F4],ecx
       mov       rax,7FFBCD915FF0
       call      rax
       lea       rdx,[rbp-2F4]
       mov       ecx,1
       mov       rax,7FFBCD91BE20
       call      rax
       mov       esi,eax
       mov       rax,7FFBCD915F30
       call      rax
       mov       ecx,eax
       call      00007FFB94C81F40
       test      esi,esi
       setne     al
       movzx     eax,al
       mov       [rbp-2F8],al
       movzx     eax,byte ptr [rbp-2F8]
       mov       [rbp-34C],al
       mov       eax,[rbp-2F4]
       mov       [rbp-350],eax
       cmp       dword ptr [7FFB94F44A90],0
       jne       near ptr M06_L80
M06_L44:
       mov       r12,[rbp-3B8]
       test      r12,r12
       je        short M06_L45
       mov       ecx,[r12+8]
       cmp       ecx,104
       jge       near ptr M06_L50
       test      ecx,ecx
       je        short M06_L45
       lea       eax,[rcx-1]
       cmp       eax,ecx
       jae       near ptr M06_L55
       mov       ecx,eax
       movzx     ecx,word ptr [r12+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M06_L50
       cmp       ecx,2E
       je        near ptr M06_L50
M06_L45:
       mov       [rbp-3B8],r12
       mov       rax,r12
M06_L46:
       test      rax,rax
       je        near ptr M06_L51
       add       rax,0C
       mov       rsi,rax
M06_L47:
       mov       [rbp-300],rsi
       xor       ecx,ecx
       mov       rax,7FFBCD915FF0
       call      rax
       lea       r8,[rbp-2E8]
       mov       rcx,rsi
       xor       edx,edx
       mov       rax,7FFB3517EDE8
       mov       [rbp-330],rax
       lea       rax,[M06_L48]
       mov       [rbp-320],rax
       lea       rax,[rbp-340]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFBCD925090
       call      rax
M06_L48:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFB94F44A90],0
       je        short M06_L49
       call      qword ptr [7FFB94F32648]; CORINFO_HELP_STOP_FOR_GC
M06_L49:
       mov       rcx,[rbp-338]
       mov       [rdi+8],rcx
       mov       esi,eax
       mov       rax,7FFBCD915F30
       call      rax
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-300],rax
       call      00007FFB94C81F40
       test      esi,esi
       jne       near ptr M06_L56
       jmp       short M06_L52
M06_L50:
       mov       rcx,r12
       call      qword ptr [7FFB35636B68]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       [rbp-3B8],r12
       jmp       near ptr M06_L46
M06_L51:
       xor       esi,esi
       jmp       near ptr M06_L47
M06_L52:
       call      00007FFB94C81F20
       mov       r14d,eax
       mov       ecx,r14d
       call      qword ptr [7FFB35636AF0]; System.IO.FileSystem.IsPathUnreachableError(Int32)
       test      eax,eax
       jne       near ptr M06_L56
       lea       rcx,[rbp-290]
       mov       edx,250
       call      qword ptr [7FFB350057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       lea       rdx,[rbp-290]
       mov       rcx,[rbp-3B8]
       call      qword ptr [7FFB356CCA98]
       mov       [rbp-3B0],rax
       mov       rcx,[rbp-3B0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB35177810]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       je        short M06_L53
       call      00007FFB94C81F20
       mov       r14d,eax
       jmp       short M06_L54
M06_L53:
       xor       r14d,r14d
       lea       rcx,[rbp-2E8]
       lea       rdx,[rbp-290]
       call      qword ptr [7FFB356CCAB0]
       nop
M06_L54:
       mov       rcx,[rbp-3B0]
       mov       edx,1
       call      qword ptr [7FFB3500DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-3B0]
       call      qword ptr [7FFB351D5578]; System.GC.SuppressFinalize(System.Object)
       jmp       short M06_L56
M06_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M06_L56:
       cmp       byte ptr [rbp-34C],0
       je        short M06_L57
       xor       ecx,ecx
       mov       [rbp-308],ecx
       call      00007FFB34FF8C48
       lea       rdx,[rbp-308]
       mov       ecx,[rbp-350]
       call      00007FFB34FF8C60
       call      00007FFB34FF8C78
       mov       ecx,eax
       call      00007FFB94C81F40
M06_L57:
       test      r14d,r14d
       je        short M06_L59
       mov       rsi,[rbp-398]
M06_L58:
       mov       ecx,ebx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB356C7F48]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M06_L59:
       cmp       dword ptr [rbp-2E8],0FFFFFFFF
       je        near ptr M06_L81
       test      byte ptr [rbp-2E8],10
       mov       rsi,[rbp-398]
       je        short M06_L58
       mov       rcx,offset MT_System.IO.IOException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB356CCF60]
       mov       rcx,rax
       mov       rdx,[rbp-390]
       call      qword ptr [7FFB356CC630]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,5
       call      qword ptr [7FFB356CCF78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L60:
       mov       ecx,1C3BC
       mov       rdx,7FFB34F44000
       call      qword ptr [7FFB3500F210]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFB356CCEB8]
       int       3
M06_L61:
       mov       ecx,1C39E
       mov       rdx,7FFB34F44000
       call      qword ptr [7FFB3500F210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB356CCEB8]
       int       3
M06_L62:
       mov       rcx,r15
       call      qword ptr [7FFB35636B68]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       r13,rax
       jmp       near ptr M06_L33
M06_L63:
       xor       edx,edx
       mov       [rbp-2C0],rdx
       lea       rdx,[rbp-2C0]
       call      qword ptr [7FFB356CC5D0]
       mov       r12,[rbp-2C0]
       jmp       near ptr M06_L34
M06_L64:
       call      qword ptr [7FFB356CCE10]
       int       3
M06_L65:
       mov       ecx,1C47E
       mov       rdx,7FFB34F44000
       call      qword ptr [7FFB3500F210]
       mov       rcx,rax
       call      qword ptr [7FFB356C78D0]
       int       3
M06_L66:
       mov       ecx,1C48A
       mov       rdx,7FFB34F44000
       call      qword ptr [7FFB3500F210]
       mov       rcx,rax
       call      qword ptr [7FFB356C78D0]
       int       3
M06_L67:
       mov       ecx,1
       jmp       near ptr M06_L20
M06_L68:
       inc       edx
       cmp       edx,eax
       jl        near ptr M06_L03
M06_L69:
       xor       r15d,r15d
       jmp       near ptr M06_L09
M06_L70:
       mov       r8d,0FFFFFFFF
       jmp       near ptr M06_L07
M06_L71:
       lea       r8d,[rcx-1]
       cmp       r8d,edx
       jae       near ptr M06_L82
       lea       r8d,[rcx-1]
       movzx     r8d,word ptr [r12+r8*2]
       cmp       r8d,5C
       je        short M06_L72
       cmp       r8d,2F
       sete      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        near ptr M06_L06
M06_L72:
       dec       ecx
       jmp       near ptr M06_L05
M06_L73:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFB356CCA80]
       int       3
M06_L74:
       mov       rcx,2A398390008
       jmp       near ptr M06_L08
M06_L75:
       mov       rcx,r14
       jmp       near ptr M06_L08
M06_L76:
       mov       ecx,1AC3E
       mov       rdx,7FFB34F44000
       call      qword ptr [7FFB3500F210]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFB356CCEB8]
       int       3
M06_L77:
       mov       rsi,[rbp-398]
       jmp       near ptr M06_L58
M06_L78:
       mov       ecx,1
       jmp       near ptr M06_L41
M06_L79:
       lea       rcx,[r15+0C]
       mov       r12d,[r15+8]
       mov       [rbp-360],rcx
       mov       [rbp-358],r12d
       lea       rcx,[rbp-360]
       call      qword ptr [7FFB35636B20]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r12d
       je        near ptr M06_L42
       mov       r8d,r13d
       mov       rcx,r15
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FFB35297438]; System.String.Substring(Int32, Int32)
       mov       [rbp-3B8],rax
       mov       [rbp-398],rsi
       jmp       near ptr M06_L43
M06_L80:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L44
M06_L81:
       mov       rsi,[rbp-398]
       jmp       near ptr M06_L58
M06_L82:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-3A0],0
       je        short M06_L83
       mov       rcx,[rbp-3A0]
       mov       edx,1
       call      qword ptr [7FFB3500DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-3A0]
       mov       rbx,[rcx]
       test      dword ptr [rbx],100000
       je        short M06_L83
       call      00007FFB94C3D4D0
M06_L83:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       vzeroupper
       xor       ecx,ecx
       mov       [rbp-2B8],rcx
       add       rsp,38
       ret
       sub       rsp,38
       vzeroupper
       cmp       dword ptr [rbp-2AC],0
       je        short M06_L84
       cmp       byte ptr [rbp-348],0
       jne       short M06_L84
       mov       rcx,[rbp-3C0]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,[rbp-3C0]
       call      qword ptr [7FFB351D5578]; System.GC.SuppressFinalize(System.Object)
M06_L84:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-3B0],0
       je        short M06_L85
       mov       rcx,[rbp-3B0]
       mov       edx,1
       call      qword ptr [7FFB3500DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-3B0]
       call      qword ptr [7FFB351D5578]; System.GC.SuppressFinalize(System.Object)
M06_L85:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       vzeroupper
       cmp       byte ptr [rbp-34C],0
       je        short M06_L86
       xor       ecx,ecx
       mov       [rbp-308],ecx
       call      00007FFB34FF8C48
       lea       rdx,[rbp-308]
       mov       ecx,[rbp-350]
       call      00007FFB34FF8C60
       call      00007FFB34FF8C78
       mov       ecx,eax
       call      00007FFB94C81F40
M06_L86:
       nop
       add       rsp,38
       ret
; Total bytes of code 3423
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M07_L02
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M07_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jge       short M07_L04
M07_L00:
       cmp       [r10],rcx
       je        short M07_L02
M07_L01:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M07_L03
       cmp       [r10],rcx
       jne       short M07_L01
M07_L02:
       mov       rax,rdx
       ret
M07_L03:
       test      dword ptr [rax],500C0000
       jne       short M07_L05
       xor       edx,edx
       jmp       short M07_L02
M07_L04:
       cmp       [r10],rcx
       je        short M07_L02
       cmp       [r10+8],rcx
       je        short M07_L02
       cmp       [r10+10],rcx
       je        short M07_L02
       cmp       [r10+18],rcx
       je        short M07_L02
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M07_L04
       test      r8,r8
       je        short M07_L03
       jmp       short M07_L00
M07_L05:
       jmp       qword ptr [7FFB3538D908]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 116
```
```assembly
; System.Threading.Tasks.Parallel.PartitionerForEachWorker[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Concurrent.Partitioner`1<System.__Canon>, System.Threading.Tasks.ParallelOptions, System.Action`1<System.__Canon>, System.Action`2<System.__Canon,System.Threading.Tasks.ParallelLoopState>, System.Action`3<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64>, System.Func`4<System.__Canon,System.Threading.Tasks.ParallelLoopState,System.__Canon,System.__Canon>, System.Func`5<System.__Canon,System.Threading.Tasks.ParallelLoopState,Int64,System.__Canon,System.__Canon>, System.Func`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rdx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       r14,[rbp+30]
       mov       r15,[rbp+38]
       mov       r13,[rbp+40]
       mov       r12,[rbp+48]
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M08_L55
M08_L00:
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-0B8],rdx
       lea       rcx,[rdx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0B8]
       lea       rcx,[rdx+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0B8]
       lea       rcx,[rdx+28]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0B8]
       lea       rcx,[rdx+30]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0B8]
       lea       rcx,[rdx+38]
       mov       rdx,[rbp+50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0B8]
       lea       rcx,[rdx+40]
       mov       rdx,[rbp+58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0B8]
       lea       rcx,[rdx+58]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0B8]
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
       mov       rdx,[rbp-0B8]
       lea       rcx,[rdx+48]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Concurrent.Partitioner+DynamicPartitionerForIEnumerable<System.String>
       cmp       [rsi],rcx
       jne       near ptr M08_L57
M08_L02:
       mov       rdx,[rbp-0B8]
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       cmp       qword ptr [rbp-58],0
       je        short M08_L03
       mov       rcx,[rbp-58]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M08_L58
M08_L03:
       xor       ecx,ecx
       mov       [rdx+70],ecx
       mov       rcx,26319400248
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M08_L59
M08_L04:
       mov       rcx,offset MT_System.Threading.Tasks.ParallelLoopStateFlags<System.Int64>
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,7FFFFFFFFFFFFFFF
       mov       [rax+10],rcx
       mov       rdx,[rbp-0B8]
       lea       rcx,[rdx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp-0A8],ecx
       mov       [rbp-0B0],rcx
       mov       rdx,[rbp-0B8]
       mov       [rdx+8],rcx
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       cmp       qword ptr [rbp-58],0
       jne       near ptr M08_L60
       xor       ebx,ebx
       xor       edi,edi
M08_L05:
       mov       [rbp-50],rbx
       mov       [rbp-48],rdi
       xor       ecx,ecx
       mov       [rdx+60],rcx
       mov       [rdx+50],rcx
       mov       rbx,[rdx+48]
       test      rbx,rbx
       je        near ptr M08_L67
       mov       rcx,offset MT_System.Collections.Concurrent.Partitioner+DynamicPartitionerForIEnumerable<System.String>
       cmp       [rbx],rcx
       jne       near ptr M08_L65
       mov       rsi,[rbx+10]
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.String>
       cmp       [rsi],rcx
       jne       near ptr M08_L64
       lea       rcx,[rsi+8]
       xor       eax,eax
       mov       rdi,rax
       xchg      rdi,[rcx]
       test      rdi,rdi
       je        near ptr M08_L63
M08_L06:
       mov       rcx,offset MT_System.Collections.Concurrent.Partitioner+DynamicPartitionerForIEnumerable<System.String>+InternalPartitionEnumerable
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
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair<System.Int64, System.String>[]
       mov       edx,100
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M08_L07:
       xor       ecx,ecx
       mov       [rsi+38],rcx
M08_L08:
       mov       rdx,[rbp-0B8]
       lea       rcx,[rdx+50]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0B8]
       cmp       qword ptr [rdx+50],0
       je        near ptr M08_L66
M08_L09:
       mov       rcx,offset MT_System.Threading.Tasks.TaskReplicator+ReplicatableUserAction<System.Collections.IEnumerator>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,offset System.Threading.Tasks.Parallel+<>c__DisplayClass43_0`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<PartitionerForEachWorker>b__1(System.Collections.IEnumerator ByRef, Int64, Boolean ByRef)
       mov       [rbx+18],rax
       mov       rdx,[rbp-0B8]
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
       call      qword ptr [7FFB356CDAE8]
       mov       rcx,263194001E8
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
       mov       rcx,26319400268
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
       call      qword ptr [7FFB3529FCC0]; System.Threading.Thread.InitializeCurrentThread()
M08_L19:
       mov       rdi,[rax+8]
       test      rdi,rdi
       jne       near ptr M08_L41
       mov       rcx,26319400278
       mov       rdi,[rcx]
M08_L20:
       test      rdi,rdi
       je        short M08_L22
       mov       rcx,26319400278
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
       call      qword ptr [7FFB3563F7C8]; System.Threading.Tasks.Task.InternalRunSynchronously(System.Threading.Tasks.TaskScheduler, Boolean)
M08_L26:
       mov       rbx,[r14+10]
       mov       rsi,[rbx+18]
       lea       rdx,[rbp-78]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFB356355D8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M08_L30
M08_L27:
       mov       rbx,[rbp-78]
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M08_L26
M08_L28:
       xor       ecx,ecx
       mov       [rbp-80],rcx
       mov       ecx,[rsi+34]
       and       ecx,11000000
       cmp       ecx,1000000
       je        short M08_L29
       mov       rcx,rsi
       mov       r8,[rbp-80]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFB356C4D38]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       mov       [rbp-78],rcx
M08_L31:
       cmp       qword ptr [r14+18],0
       jne       near ptr M08_L47
       xor       ecx,ecx
       mov       [rbp-78],rcx
       jmp       near ptr M08_L49
M08_L32:
       mov       ecx,2F
       call      qword ptr [7FFB3500FD38]
       int       3
M08_L33:
       call      qword ptr [7FFB356CDAE8]
       mov       rcx,263194001E8
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
       call      qword ptr [7FFB3563F5B8]; System.Threading.Tasks.ParallelOptions.get_EffectiveMaxConcurrencyLevel()
       mov       edi,eax
       jmp       near ptr M08_L13
M08_L39:
       mov       rcx,offset MT_System.Action<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,26319400260
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset System.Threading.Tasks.TaskReplicator+Replica+<>c.<.ctor>b__4_0(System.Object)
       call      qword ptr [7FFB35006BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26319400268
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L17
M08_L40:
       mov       ecx,4
       call      qword ptr [7FFB356C7B88]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
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
       call      qword ptr [7FFB356CDBF0]
       jmp       near ptr M08_L25
M08_L43:
       mov       rcx,rsi
       call      qword ptr [7FFB356CE3A0]
       mov       ecx,[rsi+34]
       and       ecx,600000
       cmp       ecx,400000
       jne       short M08_L44
       cmp       qword ptr [rbp-80],0
       je        short M08_L44
       mov       rcx,[rbp-80]
       cmp       dword ptr [rcx+20],0
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M08_L46
M08_L44:
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFB356CE3E8]
       jmp       near ptr M08_L29
M08_L45:
       lea       rdx,[rbp-78]
       mov       rcx,rbx
       call      qword ptr [7FFB356CD8F0]
       test      eax,eax
       jne       near ptr M08_L27
       jmp       near ptr M08_L31
M08_L46:
       lea       rcx,[rbp-80]
       call      qword ptr [7FFB356CCE10]
       int       3
M08_L47:
       mov       rcx,offset MT_System.AggregateException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[r14+18]
       mov       rcx,rbx
       call      qword ptr [7FFB356CF300]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M08_L49:
       mov       rdx,[rbp-0B8]
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       cmp       qword ptr [rbp-58],0
       jne       short M08_L51
M08_L50:
       mov       rdx,[rbp-0B8]
       cmp       qword ptr [rdx+8],0
       je        short M08_L54
       jmp       short M08_L52
M08_L51:
       lea       rcx,[rbp-50]
       call      qword ptr [7FFB356CF1C8]
       jmp       short M08_L50
M08_L52:
       mov       rcx,[rdx+8]
       call      CORINFO_HELP_THROW
       int       3
M08_L53:
       nop
       mov       rdx,[rbp-0B8]
M08_L54:
       call      M08_L71
       nop
       movzx     eax,byte ptr [rbp-0A4]
       mov       rdx,[rbp+10]
       mov       [rdx],al
       movzx     eax,byte ptr [rbp-0A8]
       mov       [rdx+8],al
       mov       rax,[rbp-0B0]
       mov       [rdx+10],rax
       mov       rax,rdx
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
M08_L55:
       mov       rcx,rbx
       mov       rdx,7FFB357EDC80
       call      qword ptr [7FFB3500F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L00
M08_L56:
       mov       rcx,rbx
       mov       rdx,7FFB357EDC98
       call      qword ptr [7FFB3500F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L01
M08_L57:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       near ptr M08_L02
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB356CF180]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB353861A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L58:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFB356CCE10]
       int       3
M08_L59:
       mov       rcx,offset MT_System.Threading.Tasks.Parallel
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,7FFB34F4B210
       mov       ecx,1
       lock xadd [rax],ecx
       inc       ecx
       mov       rdx,[rbp-0B8]
       mov       [rdx+70],ecx
       call      qword ptr [7FFB356CDAE8]
       mov       rcx,rax
       mov       rax,263194001E8
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB3563EC28]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       ebx,eax
       call      qword ptr [7FFB356CDC50]
       mov       [rbp-60],rax
       mov       dword ptr [rsp+20],3
       xor       r9d,r9d
       mov       [rsp+28],r9
       mov       [rsp+30],r9
       mov       rdx,[rbp-0B8]
       mov       r9d,[rdx+70]
       mov       rcx,26319400248
       mov       rcx,[rcx]
       mov       edx,ebx
       mov       r8d,[rbp-5C]
       call      qword ptr [7FFB356CF198]
       jmp       near ptr M08_L04
M08_L60:
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       mov       rcx,offset MT_System.Action<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFB356CB150
       mov       [rbx+18],rdx
       mov       rcx,[rbp-58]
       test      rcx,rcx
       jne       short M08_L61
       xor       ebx,ebx
       xor       edi,edi
       jmp       short M08_L62
M08_L61:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       lea       rdx,[rbp-70]
       mov       r8,rbx
       xor       r9d,r9d
       call      qword ptr [7FFB356CE598]
       mov       rbx,[rbp-70]
       mov       rdi,[rbp-68]
M08_L62:
       mov       rdx,[rbp-0B8]
       jmp       near ptr M08_L05
M08_L63:
       mov       rcx,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.String>+DelegateEnumerator
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB356CF288]
       jmp       near ptr M08_L06
M08_L64:
       mov       rcx,rsi
       mov       r11,7FFB34F50BE0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M08_L06
M08_L65:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rsi,rax
       jmp       near ptr M08_L08
M08_L66:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB356CF1B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB353861A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L67:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,[rbp-0B8]
       lea       rcx,[rdx+60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0B8]
       cmp       qword ptr [rdx+60],0
       jne       near ptr M08_L09
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB356CF1B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB353861A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,38
       vzeroupper
       mov       rdx,[rbp-0B8]
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       cmp       qword ptr [rbp-58],0
       je        short M08_L68
       lea       rcx,[rbp-50]
       call      qword ptr [7FFB356CF1C8]
M08_L68:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       vzeroupper
       mov       rbx,rcx
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFB356CF1E0]
       mov       rsi,rax
       mov       rdx,[rbp-0B8]
       mov       rcx,[rdx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB356CF1F8]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFB356CF210]
       lea       rax,[M08_L53]
       add       rsp,38
       ret
M08_L69:
       sub       rsp,38
       vzeroupper
       cmp       dword ptr [rbp-84],0
       je        short M08_L70
       mov       rcx,[rbp-0C8]
       call      00007FFB94C8DE50
       test      eax,eax
       je        short M08_L70
       mov       ecx,eax
       mov       rdx,[rbp-0C8]
       call      qword ptr [7FFB356C47E0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M08_L70:
       nop
       add       rsp,38
       ret
M08_L71:
       sub       rsp,38
       vzeroupper
       mov       rdx,[rbp-0B8]
       mov       rcx,[rdx+18]
       mov       ecx,[rcx+8]
       test      ecx,ecx
       sete      al
       movzx     eax,al
       mov       [rbp-0A4],eax
       test      cl,2
       je        short M08_L72
       mov       rcx,[rdx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB356C4990]
       mov       dword ptr [rbp-0A8],1
       mov       [rbp-0B0],rax
       mov       rdx,[rbp-0B8]
M08_L72:
       mov       rcx,[rdx+50]
       test      rcx,rcx
       je        short M08_L74
       mov       rax,rcx
       test      rax,rax
       je        short M08_L73
       mov       r8,offset MT_System.Collections.Concurrent.Partitioner+DynamicPartitionerForIEnumerable<System.String>+InternalPartitionEnumerable
       cmp       [rax],r8
       je        short M08_L73
       mov       rdx,rcx
       mov       rcx,offset MT_System.IDisposable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
M08_L73:
       jmp       short M08_L75
M08_L74:
       mov       rdx,[rbp-0B8]
       mov       rdx,[rdx+60]
       mov       rcx,offset MT_System.IDisposable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
M08_L75:
       test      rax,rax
       je        near ptr M08_L84
       mov       rcx,offset MT_System.Collections.Concurrent.Partitioner+DynamicPartitionerForIEnumerable<System.String>+InternalPartitionEnumerable
       cmp       [rax],rcx
       jne       near ptr M08_L85
       cmp       byte ptr [rax+4C],0
       jne       near ptr M08_L84
       mov       byte ptr [rax+4C],1
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.IO.Enumeration.FileSystemEnumerable<System.String>+DelegateEnumerator
       cmp       [rcx],rax
       jne       near ptr M08_L83
       mov       [rbp-0C0],rcx
       mov       rcx,[rbp-0C0]
       cmp       qword ptr [rcx+28],0
       je        near ptr M08_L82
       mov       rax,[rcx+28]
       mov       [rbp-0C8],rax
       xor       eax,eax
       mov       [rbp-84],eax
       mov       rcx,[rbp-0C8]
       call      00007FFB94C8DF30
       test      eax,eax
       jne       short M08_L76
       mov       rcx,[rbp-0C8]
       call      qword ptr [7FFB356C4720]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M08_L76:
       mov       dword ptr [rbp-84],1
       mov       rcx,[rbp-0C0]
       mov       byte ptr [rcx+68],1
       lea       rax,[rcx+58]
       xor       edx,edx
       xchg      rdx,[rax]
       test      rdx,rdx
       je        short M08_L77
       mov       rcx,rdx
       call      qword ptr [7FFB35636EC8]; Interop+Kernel32.CloseHandle(IntPtr)
M08_L77:
       mov       rcx,[rbp-0C0]
       cmp       qword ptr [rcx+40],0
       je        short M08_L80
       mov       rdx,[rcx+40]
       cmp       dword ptr [rdx+18],0
       jle       short M08_L79
M08_L78:
       mov       rcx,[rcx+40]
       lea       rdx,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB356CEC40]
       mov       rcx,[rbp-98]
       call      qword ptr [7FFB35636EC8]; Interop+Kernel32.CloseHandle(IntPtr)
       mov       rcx,[rbp-0C0]
       mov       rax,[rcx+40]
       cmp       dword ptr [rax+18],0
       jg        short M08_L78
M08_L79:
       xor       eax,eax
       mov       [rcx+40],rax
M08_L80:
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M08_L81
       test      rax,0FFFFFFFFFFFF0000
       je        short M08_L81
       mov       rcx,rax
       call      00007FFB34FF2A18
M08_L81:
       xor       eax,eax
       mov       rcx,[rbp-0C0]
       mov       [rcx+50],rax
       call      M08_L69
       nop
M08_L82:
       mov       rcx,[rbp-0C0]
       mov       rax,[rcx]
       test      dword ptr [rax],100000
       je        short M08_L84
       call      00007FFB94C3D4D0
       jmp       short M08_L84
M08_L83:
       mov       r11,7FFB34F50BE8
       call      qword ptr [r11]
M08_L84:
       mov       rax,26319400248
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       je        short M08_L87
       jmp       short M08_L86
M08_L85:
       mov       rcx,rax
       mov       r11,7FFB34F50BD8
       call      qword ptr [r11]
       jmp       short M08_L84
M08_L86:
       call      qword ptr [7FFB356CDAE8]
       mov       rcx,rax
       mov       rax,263194001E8
       test      rcx,rcx
       cmove     rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFB3563EC28]; System.Threading.Tasks.TaskScheduler.get_Id()
       mov       ebx,eax
       call      qword ptr [7FFB356CDC50]
       mov       [rbp-60],rax
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       rdx,[rbp-0B8]
       mov       r9d,[rdx+70]
       mov       rcx,26319400248
       mov       rcx,[rcx]
       mov       edx,ebx
       mov       r8d,[rbp-5C]
       call      qword ptr [7FFB356CF228]
M08_L87:
       nop
       add       rsp,38
       ret
; Total bytes of code 3797
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
       call      00007FFB94C850F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB35005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB35005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2A398390008
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
       call      qword ptr [7FFB356C7CC0]
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
       cmp       dword ptr [rdi+8],0
       je        near ptr M10_L00
       mov       r15d,ebp
       mov       r13d,r14d
       add       r13,r15
       mov       r12d,[rdi+8]
       add       r13,r12
       cmp       r13,7FFFFFFF
       jg        near ptr M10_L03
       mov       rcx,7FFB3570E2A0
       call      CORINFO_HELP_COUNTPROFILE32
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.String
       call      00007FFB94C850F0
       mov       r13,rax
       cmp       [r13],r13b
       lea       r12,[r13+0C]
       mov       rcx,r12
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB35005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r12+r15*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB35005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[r12+rcx*2]
       mov       r8d,[rdi+8]
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFB35005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M10_L00:
       mov       rcx,7FFB3570E298
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
       jmp       qword ptr [7FFB3500D9C8]; System.String.Concat(System.String, System.String)
M10_L01:
       mov       rcx,7FFB3570E294
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
       jmp       qword ptr [7FFB3500D9C8]; System.String.Concat(System.String, System.String)
M10_L02:
       mov       rcx,7FFB3570E290
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
       jmp       qword ptr [7FFB3500D9C8]; System.String.Concat(System.String, System.String)
M10_L03:
       mov       rcx,7FFB3570E29C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB356C7CC0]
       int       3
; Total bytes of code 396
```
```assembly
; System.IO.Path.Join(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      r15
       push      r14
       push      r13
       push      r12
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
       mov       ebx,[rcx+8]
       test      ebx,ebx
       je        near ptr M11_L05
       mov       esi,[rdx+8]
       test      esi,esi
       je        near ptr M11_L06
       mov       rdi,[rcx]
       mov       rbp,[rdx]
       lea       edx,[rbx-1]
       movzx     edx,word ptr [rdi+rdx*2]
       cmp       edx,5C
       je        near ptr M11_L04
       cmp       edx,2F
       je        near ptr M11_L04
       test      esi,esi
       je        near ptr M11_L08
       movzx     edx,word ptr [rbp]
       cmp       edx,5C
       je        near ptr M11_L02
       cmp       edx,2F
       sete      dl
       movzx     edx,dl
M11_L00:
       test      edx,edx
       jne       near ptr M11_L04
       mov       edx,ebx
       add       edx,1
       jo        near ptr M11_L09
       add       edx,esi
       jo        near ptr M11_L09
       test      edx,edx
       je        near ptr M11_L07
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB94C850F0
       mov       r14,rax
       lea       r15,[r14+0C]
       mov       r13d,[r14+8]
       cmp       ebx,r13d
       ja        short M11_L03
       mov       r12d,ebx
       add       r12,r12
       mov       r8,r12
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FFB35005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r15,r12
       sub       r13d,ebx
       je        short M11_L03
       mov       word ptr [r15],5C
       lea       rcx,[r15+2]
       dec       r13d
       cmp       esi,r13d
       ja        short M11_L03
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbp
       call      qword ptr [7FFB35005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r14
M11_L01:
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
M11_L02:
       mov       edx,1
       jmp       near ptr M11_L00
M11_L03:
       call      qword ptr [7FFB3542D0E0]
       int       3
M11_L04:
       mov       [rsp+38],rdi
       mov       [rsp+40],ebx
       mov       [rsp+28],rbp
       mov       [rsp+30],esi
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       call      qword ptr [7FFB3538D9E0]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       jmp       short M11_L01
M11_L05:
       mov       rcx,rdx
       call      qword ptr [7FFB351DF750]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       nop
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
M11_L06:
       call      qword ptr [7FFB351DF750]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       nop
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
M11_L07:
       mov       rax,2A398390008
       jmp       near ptr M11_L01
M11_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M11_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 403
```
```assembly
; System.String.Substring(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       ebx,edx
       test      ebx,ebx
       je        short M12_L00
       mov       ecx,[rsi+8]
       mov       r8d,ecx
       sub       r8d,ebx
       je        short M12_L01
       cmp       ecx,ebx
       jb        short M12_L02
       mov       edi,r8d
       movsxd    rcx,r8d
       call      qword ptr [7FFB59F6B9F0]; Precode of System.String.FastAllocateString(IntPtr)
       mov       rbp,rax
       mov       edx,ebx
       lea       rdx,[rsi+rdx*2+0C]
       cmp       [rbp],bpl
       lea       rcx,[rbp+0C]
       lea       r8,[rdi+rdi]
       call      qword ptr [7FFB59F6D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M12_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M12_L01:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M12_L02:
       mov       rcx,rsi
       mov       edx,ebx
       call      qword ptr [7FFB59F6BD30]
       int       3
; Total bytes of code 127
```

