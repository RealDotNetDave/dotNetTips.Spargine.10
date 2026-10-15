## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark.OrderByWithComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,138
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       vmovdqa   xmmword ptr [rsp+rax+140],xmm4
       vmovdqa   xmmword ptr [rsp+rax+150],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,1B0E5000A78
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L19
M00_L01:
       mov       rbp,[rbx+2E8]
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+8],eax
       lea       rcx,[r14+60]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L20
       xor       ecx,ecx
       mov       [r14+68],rcx
       lea       rcx,[r14+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       mov       rcx,1B0E5000AA0
       test      rdx,rdx
       cmove     rdx,[rcx]
       lea       rcx,[r14+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],0
       mov       rcx,[r14+60]
       call      qword ptr [7FF92310EEF8]; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L21
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r15,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r14+78]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[r14+70]
       movzx     r8d,byte ptr [r14+90]
       mov       [rsp+134],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+134]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r14+68],0
       jne       near ptr M00_L22
M00_L02:
       mov       r14,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r14],rdx
       jne       near ptr M00_L26
       mov       rax,[r14+8]
       mov       [rsp+40],rax
       mov       rdx,1B0E5000A90
       cmp       rax,[rdx]
       je        near ptr M00_L24
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        near ptr M00_L05
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L05
       mov       r10d,10
       mov       [rsp+5C],edi
M00_L03:
       vmovdqu   ymm0,ymmword ptr [rsi+r10]
       vmovdqu   ymmword ptr [rsp+90],ymm0
       vmovdqu   ymm0,ymmword ptr [rsi+r10+20]
       vmovdqu   ymmword ptr [rsp+0B0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsi+r10+40]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+90]
       vmovdqu   ymmword ptr [rsp+0E0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0B0]
       vmovdqu   ymmword ptr [rsp+100],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+120],xmm0
       mov       [rsp+60],r10
       lea       rcx,[rax+r10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0E0]
       mov       r8d,50
       vzeroupper
       call      qword ptr [7FF9229F57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10,[rsp+60]
       add       r10,50
       mov       r9d,[rsp+5C]
       dec       r9d
       mov       [rsp+5C],r9d
       je        near ptr M00_L07
       mov       rax,[rsp+38]
       jmp       near ptr M00_L03
M00_L04:
       mov       rax,[rsp+38]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L31
       mov       [rsp+130],r10d
       mov       r8d,r10d
       imul      r11,r8,50
       mov       [rsp+68],r11
       vmovdqu   ymm0,ymmword ptr [rsi+r11+10]
       vmovdqu   ymmword ptr [rsp+90],ymm0
       vmovdqu   ymm0,ymmword ptr [rsi+r11+30]
       vmovdqu   ymmword ptr [rsp+0B0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsi+r11+50]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],r8
       jne       near ptr M00_L23
       vmovdqu   ymm0,ymmword ptr [rsp+90]
       vmovdqu   ymmword ptr [rsp+0E0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0B0]
       vmovdqu   ymmword ptr [rsp+100],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+120],xmm0
M00_L06:
       mov       r11,[rsp+68]
       lea       rcx,[rax+r11+10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0E0]
       mov       r8d,50
       vzeroupper
       call      qword ptr [7FF9229F57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rsp+130]
       inc       r10d
       cmp       edi,r10d
       mov       r9,[rsp+40]
       jg        near ptr M00_L04
M00_L07:
       lea       rcx,[r14+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[r14+18]
       test      rcx,rcx
       jne       near ptr M00_L25
M00_L09:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       rcx,[rax+10]
       xor       edx,edx
       mov       r8d,r12d
       lea       r8,[rcx+r8*4]
       cmp       r12d,8
       jl        short M00_L11
       vmovups   ymm0,[7FF923193B40]
       vbroadcastss ymm1,dword ptr [7FF923193B60]
       lea       rdx,[r8-20]
M00_L10:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rdx
       jbe       short M00_L10
       vmovd     edx,xmm0
M00_L11:
       cmp       rcx,r8
       jb        near ptr M00_L27
M00_L12:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L30
       cmp       qword ptr [r14+18],0
       jne       short M00_L13
       mov       rcx,[r14+10]
       mov       rdx,1B0E5000AA0
       cmp       rcx,[rdx]
       je        near ptr M00_L28
M00_L13:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       rcx,r14
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF923225610
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+88],rax
       mov       r8,[rsp+30]
       lea       rcx,[r8+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rsp+30]
       mov       rcx,[rsp+88]
       mov       [r14+18],rcx
M00_L14:
       mov       rax,[rsp+48]
       lea       rcx,[rax+10]
       mov       [rsp+70],rcx
       mov       [rsp+78],r12d
       lea       rcx,[rsp+70]
       mov       rdx,r14
       call      qword ptr [7FF922D5EB98]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M00_L15:
       mov       r14,[rsp+48]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L17
       cmp       edi,r13d
       jl        short M00_L18
       xor       r12d,r12d
M00_L16:
       imul      rcx,r12,14
       add       rcx,r15
       cmp       [rcx],cl
       mov       eax,[r14+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L31
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      qword ptr [7FF9229F57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,4
       dec       r13d
       jne       short M00_L16
M00_L17:
       mov       [rsp+80],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+80]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
       add       rsp,138
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L18:
       mov       ecx,r12d
       imul      rcx,50
       add       rcx,r15
       cmp       [rcx],cl
       cmp       r12d,edi
       jae       near ptr M00_L31
       mov       edx,r12d
       mov       eax,[r14+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L31
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      qword ptr [7FF9229F57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L18
       jmp       near ptr M00_L17
M00_L19:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1B0E5000A70
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1B0E5000A78
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L20:
       mov       ecx,11
       call      qword ptr [7FF922C1C6F0]
       int       3
M00_L21:
       mov       rbp,rsi
       jmp       near ptr M00_L17
M00_L22:
       mov       rcx,[r14+68]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r14,rax
       mov       rax,r14
       jmp       near ptr M00_L02
M00_L23:
       lea       r8,[rsp+90]
       lea       rdx,[rsp+0E0]
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       rax,[rsp+38]
       jmp       near ptr M00_L06
M00_L24:
       lea       rcx,[r14+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L25:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L26:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L27:
       lea       r10d,[rdx+1]
       mov       [rcx],edx
       add       rcx,4
       cmp       rcx,r8
       mov       edx,r10d
       jb        short M00_L27
       jmp       near ptr M00_L12
M00_L28:
       cmp       byte ptr [r14+28],0
       jne       short M00_L29
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+20],rdx
       mov       rcx,rdx
       mov       rdx,r14
       mov       r8,7FF9231D8BE8
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r14,[rsp+20]
       jmp       near ptr M00_L14
M00_L29:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,7FF9231D8C00
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r14,[rsp+28]
       jmp       near ptr M00_L14
M00_L30:
       mov       rax,[rsp+48]
       lea       r9d,[r12-1]
       mov       rcx,r14
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r14]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       jmp       near ptr M00_L15
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1787
```
```assembly
; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M01_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,128
       xor       eax,eax
       mov       [rsp+68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       vmovdqu   ymmword ptr [rsp+0B0],ymm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       vmovdqu   ymmword ptr [rsp+0F0],ymm4
       vmovdqa   xmmword ptr [rsp+110],xmm4
       mov       rbx,rcx
       mov       rsi,rbx
       test      rsi,rsi
       je        short M01_L01
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [rsi],rdx
       je        short M01_L01
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
M01_L01:
       test      rsi,rsi
       jne       near ptr M01_L06
       mov       rsi,rbx
       test      rsi,rsi
       je        short M01_L02
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M01_L36
M01_L02:
       test      rsi,rsi
       je        near ptr M01_L43
       mov       rbx,[rsi]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       rbx,rcx
       jne       near ptr M01_L37
       mov       edi,[rsi+8]
M01_L03:
       test      edi,edi
       je        near ptr M01_L42
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       rbx,rcx
       jne       near ptr M01_L41
       mov       ebp,[rsi+8]
       cmp       dword ptr [rbx+4],18
       jne       near ptr M01_L40
       cmp       ebp,[rsi+8]
       ja        near ptr M01_L40
       cmp       ebp,[rdi+8]
       ja        near ptr M01_L40
       mov       r8d,ebp
       movzx     ecx,word ptr [MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]]
       imul      r8,rcx
       lea       rdx,[rsi+10]
       lea       rcx,[rdi+10]
       test      dword ptr [rbx],1000000
       je        near ptr M01_L39
       cmp       r8,4000
       jbe       short M01_L04
       call      qword ptr [7FF922E1ECB8]
       jmp       short M01_L05
       nop       dword ptr [rax+rax]
M01_L04:
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L38
M01_L05:
       mov       rax,rdi
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L06:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M01_L35
       mov       rcx,[rsi+60]
       call      qword ptr [7FF92310EEF8]
       mov       rbx,rax
       mov       edi,[rbx+8]
       cmp       edi,1
       jle       near ptr M01_L25
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,[rsi+78]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,[rsi+70]
       movzx     eax,byte ptr [rsi+90]
       mov       [rsp+124],eax
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rsp+124]
       mov       [r12+28],r13b
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       r13,r12
       cmp       qword ptr [rsi+68],0
       jne       near ptr M01_L26
M01_L07:
       mov       esi,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r13],rdx
       jne       near ptr M01_L30
       mov       rax,r13
       mov       r12,[rax+8]
       mov       rdx,1B0E5000A90
       cmp       r12,[rdx]
       je        near ptr M01_L28
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+50],rax
       xor       r10d,r10d
       test      r12,r12
       je        near ptr M01_L10
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],rcx
       jne       near ptr M01_L10
       mov       r12d,10
       mov       [rsp+5C],edi
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rbx+r12]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rbx+r12+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rbx+r12+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+80]
       vmovdqu   ymmword ptr [rsp+0D0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A0]
       vmovdqu   ymmword ptr [rsp+0F0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+110],xmm0
       lea       rcx,[rax+r12]
       cmp       [rcx],cl
       lea       rdx,[rsp+0D0]
       mov       r8d,50
       vzeroupper
       call      qword ptr [7FF9229F57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,50
       mov       r10d,[rsp+5C]
       dec       r10d
       mov       [rsp+5C],r10d
       je        near ptr M01_L12
       mov       rax,[rsp+50]
       jmp       near ptr M01_L08
M01_L09:
       mov       rax,[rsp+50]
M01_L10:
       cmp       r10d,edi
       jae       near ptr M01_L44
       mov       [rsp+120],r10d
       mov       r8d,r10d
       imul      r9,r8,50
       mov       [rsp+60],r9
       vmovdqu   ymm0,ymmword ptr [rbx+r9+10]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rbx+r9+30]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rbx+r9+50]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],r8
       jne       near ptr M01_L27
       vmovdqu   ymm0,ymmword ptr [rsp+80]
       vmovdqu   ymmword ptr [rsp+0D0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A0]
       vmovdqu   ymmword ptr [rsp+0F0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+110],xmm0
M01_L11:
       mov       r9,[rsp+60]
       lea       rcx,[rax+r9+10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0D0]
       mov       r8d,50
       vzeroupper
       call      qword ptr [7FF9229F57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rsp+120]
       inc       r10d
       cmp       edi,r10d
       jg        near ptr M01_L09
M01_L12:
       lea       rcx,[r13+20]
       mov       rdx,[rsp+50]
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,[r13+18]
       test      rcx,rcx
       jne       near ptr M01_L29
M01_L14:
       mov       edx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rcx,[r12+10]
       xor       eax,eax
       mov       edx,esi
       lea       rdx,[rcx+rdx*4]
       cmp       esi,8
       jl        short M01_L16
       vmovups   ymm0,[7FF9231933E0]
       vbroadcastss ymm1,dword ptr [7FF923193400]
       lea       rax,[rdx-20]
M01_L15:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rax
       jbe       short M01_L15
       vmovd     eax,xmm0
M01_L16:
       cmp       rcx,rdx
       jb        near ptr M01_L31
M01_L17:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L34
       cmp       qword ptr [r13+18],0
       jne       short M01_L18
       mov       rcx,[r13+10]
       mov       rax,1B0E5000AA0
       cmp       rcx,[rax]
       je        near ptr M01_L32
M01_L18:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,r13
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF923225610
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+78],rax
       mov       r8,[rsp+48]
       lea       rcx,[r8+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsp+48]
       mov       rcx,[rsp+78]
       mov       [r13+18],rcx
M01_L19:
       lea       rcx,[r12+10]
       mov       [rsp+68],rcx
       mov       [rsp+70],esi
       lea       rcx,[rsp+68]
       mov       rdx,r13
       call      qword ptr [7FF922D5EB98]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M01_L20:
       xor       esi,esi
       test      r15d,r15d
       jle       short M01_L22
       cmp       edi,r15d
       jl        short M01_L24
       xor       esi,esi
M01_L21:
       imul      rcx,rsi,14
       add       rcx,r14
       cmp       [rcx],cl
       mov       r13d,[r12+rsi+10]
       cmp       r13d,edi
       jae       near ptr M01_L44
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      qword ptr [7FF9229F57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rsi,4
       dec       r15d
       jne       short M01_L21
M01_L22:
       mov       rax,rbp
M01_L23:
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       ecx,esi
       imul      rcx,50
       add       rcx,r14
       cmp       [rcx],cl
       cmp       esi,edi
       jae       near ptr M01_L44
       mov       edx,esi
       mov       r13d,[r12+rdx*4+10]
       cmp       r13d,edi
       jae       near ptr M01_L44
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      qword ptr [7FF9229F57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       esi
       cmp       esi,r15d
       jl        short M01_L24
       jmp       short M01_L22
M01_L25:
       mov       rax,rbx
       jmp       short M01_L23
M01_L26:
       mov       rcx,[rsi+68]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M01_L07
M01_L27:
       lea       r8,[rsp+80]
       lea       rdx,[rsp+0D0]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       rax,[rsp+50]
       jmp       near ptr M01_L11
M01_L28:
       lea       rcx,[rax+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L13
M01_L29:
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L14
M01_L30:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L14
M01_L31:
       lea       r8d,[rax+1]
       mov       [rcx],eax
       add       rcx,4
       cmp       rcx,rdx
       mov       eax,r8d
       jb        short M01_L31
       jmp       near ptr M01_L17
M01_L32:
       cmp       byte ptr [r13+28],0
       jne       short M01_L33
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+38],rdx
       mov       rcx,rdx
       mov       rdx,r13
       mov       r8,7FF9231D8BE8
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r13,[rsp+38]
       jmp       near ptr M01_L19
M01_L33:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rcx,rax
       mov       rdx,r13
       mov       r8,7FF9231D8C00
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r13,[rsp+40]
       jmp       near ptr M01_L19
M01_L34:
       lea       r9d,[rsi-1]
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L20
M01_L35:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L36:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L37:
       mov       rcx,rsi
       mov       r11,7FF922940F28
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M01_L03
M01_L38:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L05
M01_L39:
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L05
M01_L40:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF922E1F1C8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L05
M01_L41:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FF922940F30
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L05
M01_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,1B0E5000B58
       mov       rdi,[rax]
       jmp       near ptr M01_L05
M01_L43:
       mov       rcx,rbx
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF92310F060]
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2016
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       vmovdqu   ymm0,ymmword ptr [r8]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymm0,ymmword ptr [r8+20]
       vmovdqu   ymmword ptr [rdx+20],ymm0
       vmovdqu   xmm0,xmmword ptr [r8+40]
       vmovdqu   xmmword ptr [rdx+40],xmm0
       mov       rax,rdx
       vzeroupper
       ret
; Total bytes of code 38
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M03_L02
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M03_L01
M03_L00:
       add       rsp,28
       ret
M03_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L00
M03_L02:
       add       rsp,28
       jmp       qword ptr [7FF922E1ECB8]
; Total bytes of code 49
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,1B0CF000A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M04_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M04_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M04_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M04_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L01:
       test      edi,edi
       je        short M04_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M04_L00
M04_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922B6FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```
```assembly
; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+18],rdx
       mov       r8,rdx
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       cmp       eax,1
       jle       short M05_L00
       mov       [rbp-10],rdx
       mov       [rbp-8],eax
       lea       rcx,[rbp-10]
       or        eax,1
       xor       edx,edx
       lzcnt     edx,eax
       xor       edx,1F
       lea       edx,[rdx*2+2]
       call      qword ptr [7FF922D5EBC8]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].IntroSort(System.Span`1<Int32>, Int32, System.Comparison`1<Int32>)
       nop
M05_L00:
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       rcx,[rbp+18]
       call      qword ptr [7FF923266C70]
       lea       rax,[M05_L00]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       ecx,40
       call      qword ptr [7FF923266C88]
       lea       rax,[M05_L00]
       add       rsp,28
       ret
; Total bytes of code 133
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
       call      qword ptr [7FF922E1EBF8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark.OrderByWithoutComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0D8
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,275DC400A48
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L24
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rax,275C6400068
       mov       r14,[rax]
       mov       r15,r14
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+8],eax
       lea       rcx,[rbp+60]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L26
       xor       ecx,ecx
       mov       [rbp+68],rcx
       lea       rcx,[rbp+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[rbp+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+90],0
       mov       rcx,275DC400A50
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L25
M00_L01:
       mov       rcx,rbp
       mov       rdx,offset MT_System.Linq.IOrderedEnumerable<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF923209430
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       r8,r14
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r9d,r9d
       call      rax
       mov       rsi,rax
       mov       rdi,rsi
       test      rdi,rdi
       je        short M00_L02
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rdx
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L07
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L36
       mov       rcx,[rdi+60]
       call      qword ptr [7FF9230FD428]; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       rsi,rax
       mov       ebp,[rsi+8]
       cmp       ebp,1
       jle       near ptr M00_L27
       mov       edx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+78]
       mov       rcx,275C6400A08
       cmp       r12,[rcx]
       je        near ptr M00_L28
M00_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+58],rax
       mov       rdx,[rdi+70]
       movzx     r8d,byte ptr [rdi+90]
       mov       [rsp+0D4],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+58]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+58]
       mov       ecx,[rsp+0D4]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+68],0
       je        short M00_L05
       mov       rcx,[rdi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L29
       mov       rdx,r12
       call      qword ptr [7FF923207CB8]; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M00_L04:
       mov       rdi,rax
       mov       rax,rdi
M00_L05:
       mov       rdi,rax
       mov       r12d,ebp
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       mov       rax,[rdi+8]
       mov       [rsp+48],rax
       mov       rdx,275DC400A58
       cmp       rax,[rdx]
       je        near ptr M00_L31
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+40],rax
       xor       r10d,r10d
       mov       r9,[rsp+48]
       test      r9,r9
       je        near ptr M00_L12
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rdx
       jne       near ptr M00_L12
M00_L06:
       mov       edx,r10d
       imul      rdx,50
       lea       r9,[rsi+rdx+10]
       mov       r8,[r9+28]
       vmovdqu   ymm0,ymmword ptr [r9]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [r9+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [r9+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       [rsp+0D0],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+0D0]
       inc       r10d
       cmp       ebp,r10d
       jle       near ptr M00_L14
       mov       rax,[rsp+40]
       jmp       short M00_L06
       nop       dword ptr [rax+rax]
M00_L07:
       mov       rdi,rsi
       test      rdi,rdi
       je        short M00_L08
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rdx
       jne       near ptr M00_L37
M00_L08:
       test      rdi,rdi
       je        near ptr M00_L45
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L38
       mov       esi,[rdi+8]
M00_L09:
       test      esi,esi
       je        near ptr M00_L44
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L43
       mov       ebp,[rdi+8]
       mov       rcx,[rdi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L42
       cmp       ebp,[rdi+8]
       ja        near ptr M00_L42
       cmp       ebp,[rsi+8]
       ja        near ptr M00_L42
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rdi+10]
       lea       rax,[rsi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L41
       cmp       r8,4000
       ja        near ptr M00_L40
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M00_L39
M00_L10:
       mov       [rsp+70],rsi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+70]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L11:
       mov       rax,[rsp+40]
M00_L12:
       cmp       r10d,ebp
       jae       near ptr M00_L46
       mov       [rsp+0D0],r10d
       mov       edx,r10d
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rdx
       jne       near ptr M00_L30
M00_L13:
       mov       edx,[rsp+0D0]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+0D0]
       inc       ecx
       cmp       ebp,ecx
       mov       r10d,ecx
       mov       r9,[rsp+48]
       jg        near ptr M00_L11
M00_L14:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
M00_L15:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M00_L16
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L32
       mov       rdx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF92320A6C8]; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M00_L16:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+50],rax
       lea       rcx,[rax+10]
       xor       edx,edx
       mov       r8d,r12d
       lea       r8,[rcx+r8*4]
       cmp       r12d,8
       jl        short M00_L18
       vmovups   ymm0,[7FF923174240]
       vbroadcastss ymm1,dword ptr [7FF923174260]
       lea       rdx,[r8-20]
M00_L17:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rdx
       jbe       short M00_L17
       vmovd     edx,xmm0
M00_L18:
       cmp       rcx,r8
       jb        near ptr M00_L34
M00_L19:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L35
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       mov       rcx,rdi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF923209FB8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+78],rax
       mov       r8,[rsp+38]
       lea       rcx,[r8+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rsp+38]
       mov       rcx,[rsp+78]
       mov       [rdi+18],rcx
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       [rsp+60],rcx
       mov       [rsp+68],r12d
       lea       rcx,[rsp+60]
       mov       rdx,rdi
       call      qword ptr [7FF922D5E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M00_L20:
       mov       rdi,[rsp+50]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L22
       cmp       ebp,r13d
       jl        short M00_L23
       xor       r12d,r12d
M00_L21:
       imul      rcx,r12,14
       add       rcx,r15
       cmp       [rcx],cl
       mov       eax,[rdi+r12+10]
       cmp       eax,ebp
       jae       near ptr M00_L46
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,4
       dec       r13d
       jne       short M00_L21
M00_L22:
       mov       rsi,r14
       jmp       near ptr M00_L10
M00_L23:
       mov       ecx,r12d
       imul      rcx,50
       add       rcx,r15
       cmp       [rcx],cl
       cmp       r12d,ebp
       jae       near ptr M00_L46
       mov       edx,r12d
       mov       eax,[rdi+rdx*4+10]
       cmp       eax,ebp
       jae       near ptr M00_L46
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L23
       jmp       short M00_L22
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,275DC400A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,275DC400A48
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,275DC400A38
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,275DC400A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L26:
       mov       ecx,11
       call      qword ptr [7FF922C27E58]
       int       3
M00_L27:
       mov       r14,rsi
       jmp       near ptr M00_L22
M00_L28:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FF922C25DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF922D5DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M00_L03
M00_L29:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L04
M00_L30:
       mov       [rsp+0A8],r8
       lea       rdx,[rsp+80]
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+40]
       jmp       near ptr M00_L13
M00_L31:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L15
M00_L32:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L16
M00_L33:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L16
M00_L34:
       lea       r10d,[rdx+1]
       mov       [rcx],edx
       add       rcx,4
       cmp       rcx,r8
       mov       edx,r10d
       jb        short M00_L34
       jmp       near ptr M00_L19
M00_L35:
       mov       rax,[rsp+50]
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       jmp       near ptr M00_L20
M00_L36:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M00_L22
M00_L37:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M00_L08
M00_L38:
       mov       rcx,rdi
       mov       r11,7FF922950C28
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L09
M00_L39:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L10
M00_L40:
       mov       rcx,rax
       call      qword ptr [7FF922FAF3C0]
       jmp       near ptr M00_L10
M00_L41:
       mov       rcx,rax
       call      qword ptr [7FF922A05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L10
M00_L42:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923036AD8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L10
M00_L43:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF922950C30
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L10
M00_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,275DC400AF0
       mov       rsi,[rcx]
       jmp       near ptr M00_L10
M00_L45:
       mov       rcx,rsi
       call      qword ptr [7FF9230FD560]
       mov       rsi,rax
       jmp       near ptr M00_L10
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2246
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,275C6400A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M01_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M01_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L01:
       test      edi,edi
       je        short M01_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M01_L00
M01_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922B7FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
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
```assembly
; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M03_L00:
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
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       mov       rbx,rcx
       mov       rsi,rbx
       test      rsi,rsi
       je        short M03_L01
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rdx
       je        short M03_L01
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
M03_L01:
       test      rsi,rsi
       je        near ptr M03_L04
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M03_L30
       mov       rcx,[rsi+60]
       call      qword ptr [7FF9230FD428]
       mov       rbx,rax
       mov       edi,[rbx+8]
       cmp       edi,1
       jle       near ptr M03_L22
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,[rsi+78]
       mov       rcx,275C6400A08
       cmp       r13,[rcx]
       je        near ptr M03_L23
M03_L02:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,[rsi+70]
       movzx     eax,byte ptr [rsi+90]
       mov       [rsp+0B4],eax
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rsp+0B4]
       mov       [r12+28],r13b
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       r13,r12
       cmp       qword ptr [rsi+68],0
       je        short M03_L03
       mov       rcx,[rsi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M03_L24
       mov       rdx,r12
       call      qword ptr [7FF923207CB8]; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       r13,rax
M03_L03:
       mov       esi,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [r13],rdx
       jne       near ptr M03_L27
       mov       r12,r13
       mov       rax,[r12+8]
       mov       [rsp+38],rax
       mov       rdx,275DC400A58
       cmp       rax,[rdx]
       je        near ptr M03_L25
       mov       edx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       xor       eax,eax
       jmp       near ptr M03_L10
M03_L04:
       mov       rsi,rbx
       test      rsi,rsi
       je        short M03_L05
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M03_L31
M03_L05:
       test      rsi,rsi
       je        near ptr M03_L39
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M03_L32
       mov       ebx,[rsi+8]
M03_L06:
       test      ebx,ebx
       je        near ptr M03_L38
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M03_L37
       mov       edi,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M03_L36
       cmp       edi,[rsi+8]
       ja        near ptr M03_L36
       cmp       edi,[rbx+8]
       ja        near ptr M03_L36
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M03_L35
       cmp       r8,4000
       ja        near ptr M03_L34
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M03_L33
M03_L07:
       mov       rax,rbx
       vzeroupper
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
M03_L08:
       lea       rdx,[rsp+60]
       mov       rcx,[r8+8]
       call      qword ptr [r8+18]
       mov       r10,rax
M03_L09:
       movsxd    rdx,dword ptr [rsp+40]
       mov       rcx,r12
       mov       r8,r10
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rcx,[rsp+40]
       inc       ecx
       cmp       edi,ecx
       mov       rax,rcx
       jle       short M03_L11
M03_L10:
       mov       [rsp+40],rax
       imul      rdx,rax,50
       vmovdqu   ymm0,ymmword ptr [rbx+rdx+10]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [rbx+rdx+30]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   xmm0,xmmword ptr [rbx+rdx+50]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r8,[rsp+38]
       cmp       [r8+18],rdx
       jne       short M03_L08
       mov       rdx,[rsp+88]
       mov       r10,rdx
       jmp       short M03_L09
M03_L11:
       lea       rcx,[r13+20]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M03_L12:
       mov       rcx,[r13+18]
       test      rcx,rcx
       je        short M03_L13
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M03_L26
       mov       rdx,rbx
       mov       r8d,esi
       call      qword ptr [7FF92320A6C8]; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M03_L13:
       mov       edx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rcx,[r12+10]
       xor       eax,eax
       mov       edx,esi
       lea       rdx,[rcx+rdx*4]
       cmp       esi,8
       jl        short M03_L15
       vmovups   ymm0,[7FF9231733E0]
       vbroadcastss ymm1,dword ptr [7FF923173400]
       lea       rax,[rdx-20]
M03_L14:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rax
       jbe       short M03_L14
       vmovd     eax,xmm0
M03_L15:
       cmp       rcx,rdx
       jb        near ptr M03_L28
M03_L16:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [r13],rcx
       jne       near ptr M03_L29
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       rcx,r13
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF923209FB8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+58],rax
       mov       r8,[rsp+30]
       lea       rcx,[r8+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsp+30]
       mov       rcx,[rsp+58]
       mov       [r13+18],rcx
       lea       rcx,[r12+10]
       mov       [rsp+48],rcx
       mov       [rsp+50],esi
       lea       rcx,[rsp+48]
       mov       rdx,r13
       call      qword ptr [7FF922D5E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M03_L17:
       xor       esi,esi
       test      r15d,r15d
       jle       short M03_L19
       cmp       edi,r15d
       jl        short M03_L21
       xor       esi,esi
M03_L18:
       imul      rcx,rsi,14
       add       rcx,r14
       cmp       [rcx],cl
       mov       r13d,[r12+rsi+10]
       cmp       r13d,edi
       jae       near ptr M03_L40
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rsi,4
       dec       r15d
       jne       short M03_L18
M03_L19:
       mov       rax,rbp
M03_L20:
       vzeroupper
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
M03_L21:
       mov       ecx,esi
       imul      rcx,50
       add       rcx,r14
       cmp       [rcx],cl
       cmp       esi,edi
       jae       near ptr M03_L40
       mov       edx,esi
       mov       r13d,[r12+rdx*4+10]
       cmp       r13d,edi
       jae       near ptr M03_L40
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       esi
       cmp       esi,r15d
       jl        short M03_L21
       jmp       short M03_L19
M03_L22:
       mov       rax,rbx
       jmp       short M03_L20
M03_L23:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF922C25DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FF922D5DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M03_L02
M03_L24:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M03_L03
M03_L25:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[r12+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L12
M03_L26:
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M03_L13
M03_L27:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M03_L13
M03_L28:
       lea       r8d,[rax+1]
       mov       [rcx],eax
       add       rcx,4
       cmp       rcx,rdx
       mov       eax,r8d
       jb        short M03_L28
       jmp       near ptr M03_L16
M03_L29:
       lea       r9d,[rsi-1]
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M03_L17
M03_L30:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M03_L31:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M03_L05
M03_L32:
       mov       rcx,rsi
       mov       r11,7FF922950C18
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M03_L06
M03_L33:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L07
M03_L34:
       mov       rcx,rax
       call      qword ptr [7FF922FAF3C0]
       jmp       near ptr M03_L07
M03_L35:
       mov       rcx,rax
       call      qword ptr [7FF922A05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L07
M03_L36:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923036AD8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M03_L07
M03_L37:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922950C20
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M03_L07
M03_L38:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,275DC400AF0
       mov       rbx,[rax]
       jmp       near ptr M03_L07
M03_L39:
       mov       rcx,rbx
       vzeroupper
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9230FD560]
M03_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1683
```
```assembly
; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M04_L00:
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rbx+78]
       mov       rbp,[rbx]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.String
       cmp       [rcx+8],rax
       jne       short M04_L01
       mov       rcx,275C6400A08
       cmp       rdi,[rcx]
       je        near ptr M04_L07
M04_L01:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M04_L06
M04_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+70]
       movzx     r14d,byte ptr [rbx+90]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+28],r14b
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbp
       mov       rsi,[rbx+68]
       test      rsi,rsi
       je        near ptr M04_L05
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M04_L12
       mov       rdi,[rsi+78]
       mov       rcx,275C6400A08
       cmp       rdi,[rcx]
       je        near ptr M04_L10
M04_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,[rsi+70]
       movzx     r15d,byte ptr [rsi+90]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+28],r15b
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
       cmp       qword ptr [rsi+68],0
       je        short M04_L04
       mov       rcx,[rsi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M04_L11
       mov       rdx,r14
       call      qword ptr [7FF923207CB8]
       mov       rbp,rax
M04_L04:
       mov       rax,rbp
M04_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L06:
       mov       rcx,rbp
       mov       rdx,7FF9231E9C38
       call      qword ptr [7FF922A0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L07:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF922C25DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF922D5DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rbp
       mov       rdx,7FF9231E9C50
       call      qword ptr [7FF922A0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M04_L09:
       mov       rdx,rdi
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M04_L01
M04_L10:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF922C25DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF922D5DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M04_L03
M04_L11:
       mov       rdx,r14
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M04_L04
M04_L12:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M04_L04
; Total bytes of code 576
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       rax,[rdx+28]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M06_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M06_L02
       cmp       rdx,[r8]
       jne       short M06_L03
M06_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M06_L01:
       call      qword ptr [7FF9231DD1E8]
       int       3
M06_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M06_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M06_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF922A0D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M07_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,80
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       mov       [rsp+70],rax
       mov       [rsp+78],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rbp,[rsi+8]
       mov       rcx,275DC400A58
       cmp       rbp,[rcx]
       je        near ptr M07_L10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M07_L06
       mov       rcx,rax
M07_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M07_L03
       test      rbx,rbx
       je        near ptr M07_L07
       test      rbp,rbp
       je        near ptr M07_L07
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [rbp+18],rdx
       jne       near ptr M07_L07
       cmp       [rbx+8],r13d
       jl        near ptr M07_L07
M07_L02:
       mov       edx,r15d
       imul      rdx,50
       lea       rbp,[rbx+rdx+10]
       mov       r8,[rbp+28]
       vmovdqu   ymm0,ymmword ptr [rbp]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovdqu   ymm0,ymmword ptr [rbp+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   xmm0,xmmword ptr [rbp+40]
       vmovdqu   xmmword ptr [rsp+68],xmm0
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M07_L02
M07_L03:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L04:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        short M07_L05
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M07_L13
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FF92320A6C8]
M07_L05:
       nop
       vzeroupper
       add       rsp,80
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L06:
       mov       rdx,7FF9231E9F98
       call      qword ptr [7FF922A0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M07_L01
M07_L07:
       cmp       r15d,[rbx+8]
       jae       near ptr M07_L14
       mov       edx,r15d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+68],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [rbp+18],rdx
       jne       short M07_L09
M07_L08:
       mov       edx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M07_L07
       jmp       near ptr M07_L03
M07_L09:
       mov       [rsp+50],r8
       lea       rdx,[rsp+28]
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
       mov       r8,rax
       jmp       short M07_L08
M07_L10:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L11
       jmp       short M07_L12
M07_L11:
       mov       rdx,7FF9231E9F98
       call      qword ptr [7FF922A0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M07_L12:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M07_L04
M07_L13:
       mov       rdx,rbx
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M07_L05
M07_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 563
```
```assembly
; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+18],rdx
       mov       r8,rdx
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       cmp       eax,1
       jle       short M08_L00
       mov       [rbp-10],rdx
       mov       [rbp-8],eax
       lea       rcx,[rbp-10]
       or        eax,1
       xor       edx,edx
       lzcnt     edx,eax
       xor       edx,1F
       lea       edx,[rdx*2+2]
       call      qword ptr [7FF922D5E340]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].IntroSort(System.Span`1<Int32>, Int32, System.Comparison`1<Int32>)
       nop
M08_L00:
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       rcx,[rbp+18]
       call      qword ptr [7FF923294318]
       lea       rax,[M08_L00]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       ecx,40
       call      qword ptr [7FF923294330]
       lea       rax,[M08_L00]
       add       rsp,28
       ret
; Total bytes of code 133
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M09_L02
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M09_L01
M09_L00:
       add       rsp,28
       ret
M09_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L00
M09_L02:
       add       rsp,28
       jmp       qword ptr [7FF922FAF3C0]
; Total bytes of code 49
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       rax,[rdx+20]
       ret
; Total bytes of code 5
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M11_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L00:
       call      qword ptr [7FF9231DE9A0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       push      rbx
       sub       rsp,20
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       short M12_L03
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M12_L03
M12_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       je        short M12_L02
M12_L01:
       mov       rcx,7FF92324B9F8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M12_L02:
       mov       rcx,275C6400110
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M12_L05
       mov       rcx,275C64000F0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M12_L04
       mov       rcx,7FF92324BA00
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M12_L01
M12_L03:
       mov       ecx,2
       call      qword ptr [7FF9231DE598]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M12_L00
M12_L04:
       mov       rcx,7FF92324B9FC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF92324B9F8
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF922C25E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
M12_L05:
       mov       rcx,7FF92324BA04
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L01
; Total bytes of code 204
```
```assembly
; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r8d
       lea       rcx,[rbx+8]
       call      qword ptr [7FF982458FE8]; CORINFO_HELP_ASSIGN_REF
       test      esi,0DFFFFFC0
       jne       short M13_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M13_L00:
       call      qword ptr [7FF982463550]
       mov       rbx,rax
       call      qword ptr [7FF98246E1A8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 87
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M14_L05
       mov       rcx,[rbx]
       cmp       rcx,rsi
       je        near ptr M14_L04
       mov       rax,275C6400038
       mov       rax,[rax]
       add       rax,10
       rorx      rdx,rcx,20
       xor       rdx,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rdx,r8
       mov       r8d,[rax]
       shrx      rdx,rdx,r8
       xor       r8d,r8d
M14_L00:
       lea       r10d,[rdx+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rax+r10*8]
       mov       r9d,[r10]
       and       r9d,0FFFFFFFE
       cmp       [r10+8],rcx
       jne       short M14_L01
       mov       r11,rsi
       xor       r11,[r10+10]
       cmp       r11,1
       jbe       short M14_L03
M14_L01:
       test      r9d,r9d
       je        short M14_L02
       inc       r8d
       add       edx,r8d
       and       edx,[rax+4]
       cmp       r8d,8
       jl        short M14_L00
M14_L02:
       mov       rcx,7FF92324CFEC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF922A06340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M14_L03:
       cmp       r9d,[r10]
       jne       short M14_L02
       cmp       r11d,1
       jne       short M14_L02
       mov       rcx,7FF92324CFE0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M14_L05
M14_L04:
       mov       rcx,7FF92324CFE8
       call      CORINFO_HELP_COUNTPROFILE32
M14_L05:
       mov       rcx,7FF92324CFE4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 246
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M15_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M15_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M15_L01
       cmp       [r10],rcx
       je        short M15_L06
M15_L00:
       cmp       [r10+8],rcx
       je        short M15_L06
       cmp       [r10+10],rcx
       je        short M15_L06
       cmp       [r10+18],rcx
       je        short M15_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M15_L04
       test      r8,r8
       je        short M15_L03
M15_L01:
       cmp       [r10],rcx
       je        short M15_L06
M15_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M15_L03
       cmp       [r10],rcx
       je        short M15_L06
       jmp       short M15_L02
M15_L03:
       test      dword ptr [rax],500C0000
       je        short M15_L05
       jmp       qword ptr [7FF922D5F5B8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M15_L04:
       cmp       [r10],rcx
       je        short M15_L06
       jmp       short M15_L00
M15_L05:
       xor       edx,edx
M15_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M16_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M16_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M16_L02
       test      r8b,18
       je        short M16_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M16_L05
M16_L00:
       test      r8b,4
       je        short M16_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M16_L05
M16_L01:
       test      r8,r8
       je        short M16_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M16_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M16_L05
M16_L02:
       cmp       r8,40
       ja        short M16_L06
M16_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M16_L10
M16_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M16_L05:
       vzeroupper
       ret
M16_L06:
       cmp       r8,800
       ja        near ptr M16_L12
       cmp       r8,100
       jae       short M16_L09
M16_L07:
       mov       r9,r8
       shr       r9,6
M16_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M16_L08
       and       r8,3F
       cmp       r8,10
       ja        short M16_L03
       jmp       short M16_L04
M16_L09:
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
       jmp       short M16_L07
M16_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M16_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M16_L04
M16_L11:
       cmp       rcx,rdx
       jne       short M16_L12
       cmp       [rdx],dl
       jmp       near ptr M16_L05
M16_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF922A066E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 329
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M17_L09
       test      rsi,rsi
       je        near ptr M17_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M17_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M17_L10
M17_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M17_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M17_L07
       sub       edi,eax
       js        near ptr M17_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M17_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M17_L06
       sub       ebp,eax
       js        near ptr M17_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M17_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M17_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98246A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M17_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M17_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M17_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M17_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246D930]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M17_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M17_L15
M17_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M17_L04:
       cmp       r8,4000
       jbe       short M17_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M17_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M17_L02
       jmp       near ptr M17_L14
M17_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M17_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M17_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M17_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M17_L10:
       call      qword ptr [7FF982463788]
       mov       rbx,rax
       call      qword ptr [7FF98246ED60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246D7C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M17_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF982481910]
       int       3
M17_L12:
       call      qword ptr [7FF982463550]
       mov       rdi,rax
       call      qword ptr [7FF98246DC18]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rdi
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M17_L13:
       call      qword ptr [7FF982463550]
       mov       rbp,rax
       call      qword ptr [7FF98246DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rbp
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M17_L14:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M17_L02
M17_L15:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M17_L03
M17_L16:
       call      qword ptr [7FF982463578]
       mov       rbx,rax
       call      qword ptr [7FF98246E6E0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246C240]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M18_L00
       ret
M18_L00:
       jmp       qword ptr [7FF922A05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark.OrderByWithComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,138
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       vmovdqa   xmmword ptr [rsp+rax+140],xmm4
       vmovdqa   xmmword ptr [rsp+rax+150],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,201F5400A40
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L19
M00_L01:
       mov       rbp,[rbx+2E8]
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+8],eax
       lea       rcx,[r14+60]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L20
       xor       ecx,ecx
       mov       [r14+68],rcx
       lea       rcx,[r14+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       mov       rcx,201F5400A68
       test      rdx,rdx
       cmove     rdx,[rcx]
       lea       rcx,[r14+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],0
       mov       rcx,[r14+60]
       call      qword ptr [7FF9230FD458]; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L21
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r15,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r14+78]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[r14+70]
       movzx     r8d,byte ptr [r14+90]
       mov       [rsp+134],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+134]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r14+68],0
       jne       near ptr M00_L22
M00_L02:
       mov       r14,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r14],rdx
       jne       near ptr M00_L26
       mov       rax,[r14+8]
       mov       [rsp+40],rax
       mov       rdx,201F5400A58
       cmp       rax,[rdx]
       je        near ptr M00_L24
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        near ptr M00_L05
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L05
       mov       r10d,10
       mov       [rsp+5C],edi
M00_L03:
       vmovdqu   ymm0,ymmword ptr [rsi+r10]
       vmovdqu   ymmword ptr [rsp+90],ymm0
       vmovdqu   ymm0,ymmword ptr [rsi+r10+20]
       vmovdqu   ymmword ptr [rsp+0B0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsi+r10+40]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+90]
       vmovdqu   ymmword ptr [rsp+0E0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0B0]
       vmovdqu   ymmword ptr [rsp+100],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+120],xmm0
       mov       [rsp+60],r10
       lea       rcx,[rax+r10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0E0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10,[rsp+60]
       add       r10,50
       mov       r9d,[rsp+5C]
       dec       r9d
       mov       [rsp+5C],r9d
       je        near ptr M00_L07
       mov       rax,[rsp+38]
       jmp       near ptr M00_L03
M00_L04:
       mov       rax,[rsp+38]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L31
       mov       [rsp+130],r10d
       mov       r8d,r10d
       imul      r11,r8,50
       mov       [rsp+68],r11
       vmovdqu   ymm0,ymmword ptr [rsi+r11+10]
       vmovdqu   ymmword ptr [rsp+90],ymm0
       vmovdqu   ymm0,ymmword ptr [rsi+r11+30]
       vmovdqu   ymmword ptr [rsp+0B0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsi+r11+50]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],r8
       jne       near ptr M00_L23
       vmovdqu   ymm0,ymmword ptr [rsp+90]
       vmovdqu   ymmword ptr [rsp+0E0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0B0]
       vmovdqu   ymmword ptr [rsp+100],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+120],xmm0
M00_L06:
       mov       r11,[rsp+68]
       lea       rcx,[rax+r11+10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0E0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rsp+130]
       inc       r10d
       cmp       edi,r10d
       mov       r9,[rsp+40]
       jg        near ptr M00_L04
M00_L07:
       lea       rcx,[r14+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[r14+18]
       test      rcx,rcx
       jne       near ptr M00_L25
M00_L09:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       rcx,[rax+10]
       xor       edx,edx
       mov       r8d,r12d
       lea       r8,[rcx+r8*4]
       cmp       r12d,8
       jl        short M00_L11
       vmovups   ymm0,[7FF9231732A0]
       vbroadcastss ymm1,dword ptr [7FF9231732C0]
       lea       rdx,[r8-20]
M00_L10:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rdx
       jbe       short M00_L10
       vmovd     edx,xmm0
M00_L11:
       cmp       rcx,r8
       jb        near ptr M00_L27
M00_L12:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L30
       cmp       qword ptr [r14+18],0
       jne       short M00_L13
       mov       rcx,[r14+10]
       mov       rdx,201F5400A68
       cmp       rcx,[rdx]
       je        near ptr M00_L28
M00_L13:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       rcx,r14
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9232093E8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+88],rax
       mov       r8,[rsp+30]
       lea       rcx,[r8+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rsp+30]
       mov       rcx,[rsp+88]
       mov       [r14+18],rcx
M00_L14:
       mov       rax,[rsp+48]
       lea       rcx,[rax+10]
       mov       [rsp+70],rcx
       mov       [rsp+78],r12d
       lea       rcx,[rsp+70]
       mov       rdx,r14
       call      qword ptr [7FF922D5E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M00_L15:
       mov       r14,[rsp+48]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L17
       cmp       edi,r13d
       jl        short M00_L18
       xor       r12d,r12d
M00_L16:
       imul      rcx,r12,14
       add       rcx,r15
       cmp       [rcx],cl
       mov       eax,[r14+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L31
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,4
       dec       r13d
       jne       short M00_L16
M00_L17:
       mov       [rsp+80],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+80]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
       add       rsp,138
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L18:
       mov       ecx,r12d
       imul      rcx,50
       add       rcx,r15
       cmp       [rcx],cl
       cmp       r12d,edi
       jae       near ptr M00_L31
       mov       edx,r12d
       mov       eax,[r14+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L31
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L18
       jmp       near ptr M00_L17
M00_L19:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,201F5400A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,201F5400A40
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L20:
       mov       ecx,11
       call      qword ptr [7FF922C27E58]
       int       3
M00_L21:
       mov       rbp,rsi
       jmp       near ptr M00_L17
M00_L22:
       mov       rcx,[r14+68]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r14,rax
       mov       rax,r14
       jmp       near ptr M00_L02
M00_L23:
       lea       r8,[rsp+90]
       lea       rdx,[rsp+0E0]
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       rax,[rsp+38]
       jmp       near ptr M00_L06
M00_L24:
       lea       rcx,[r14+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L25:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L26:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L27:
       lea       r10d,[rdx+1]
       mov       [rcx],edx
       add       rcx,4
       cmp       rcx,r8
       mov       edx,r10d
       jb        short M00_L27
       jmp       near ptr M00_L12
M00_L28:
       cmp       byte ptr [r14+28],0
       jne       short M00_L29
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+20],rdx
       mov       rcx,rdx
       mov       rdx,r14
       mov       r8,7FF9231D3270
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r14,[rsp+20]
       jmp       near ptr M00_L14
M00_L29:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,7FF9231D3288
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r14,[rsp+28]
       jmp       near ptr M00_L14
M00_L30:
       mov       rax,[rsp+48]
       lea       r9d,[r12-1]
       mov       rcx,r14
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r14]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       jmp       near ptr M00_L15
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1783
```
```assembly
; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M01_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,128
       xor       eax,eax
       mov       [rsp+68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       vmovdqu   ymmword ptr [rsp+0B0],ymm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       vmovdqu   ymmword ptr [rsp+0F0],ymm4
       vmovdqa   xmmword ptr [rsp+110],xmm4
       mov       rbx,rcx
       mov       rsi,rbx
       test      rsi,rsi
       je        short M01_L01
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M01_L04
       xor       esi,esi
M01_L01:
       test      rsi,rsi
       je        near ptr M01_L05
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M01_L35
       mov       rcx,[rsi+60]
       call      qword ptr [7FF9230FD458]
       mov       rbx,rax
       mov       edi,[rbx+8]
       cmp       edi,1
       jle       near ptr M01_L25
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,[rsi+78]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,[rsi+70]
       movzx     eax,byte ptr [rsi+90]
       mov       [rsp+124],eax
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rsp+124]
       mov       [r12+28],r13b
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       r13,r12
       cmp       qword ptr [rsi+68],0
       jne       near ptr M01_L26
M01_L02:
       mov       esi,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r13],rdx
       jne       near ptr M01_L30
       mov       rax,r13
       mov       r12,[rax+8]
       mov       rdx,201F5400A58
       cmp       r12,[rdx]
       je        near ptr M01_L28
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+50],rax
       xor       r10d,r10d
       test      r12,r12
       je        near ptr M01_L10
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],rcx
       jne       near ptr M01_L10
       mov       r12d,10
       mov       [rsp+5C],edi
M01_L03:
       vmovdqu   ymm0,ymmword ptr [rbx+r12]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rbx+r12+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rbx+r12+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+80]
       vmovdqu   ymmword ptr [rsp+0D0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A0]
       vmovdqu   ymmword ptr [rsp+0F0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+110],xmm0
       lea       rcx,[rax+r12]
       cmp       [rcx],cl
       lea       rdx,[rsp+0D0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,50
       mov       r10d,[rsp+5C]
       dec       r10d
       mov       [rsp+5C],r10d
       je        near ptr M01_L12
       mov       rax,[rsp+50]
       jmp       near ptr M01_L03
M01_L04:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M01_L01
       nop
M01_L05:
       mov       rsi,rbx
       test      rsi,rsi
       je        short M01_L06
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M01_L36
M01_L06:
       test      rsi,rsi
       je        near ptr M01_L44
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L37
       mov       ebx,[rsi+8]
M01_L07:
       test      ebx,ebx
       je        near ptr M01_L43
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L42
       mov       edi,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L41
       cmp       edi,[rsi+8]
       ja        near ptr M01_L41
       cmp       edi,[rbx+8]
       ja        near ptr M01_L41
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L40
       cmp       r8,4000
       ja        near ptr M01_L39
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L38
M01_L08:
       mov       rax,rbx
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rax,[rsp+50]
M01_L10:
       cmp       r10d,edi
       jae       near ptr M01_L45
       mov       [rsp+120],r10d
       mov       r8d,r10d
       imul      r9,r8,50
       mov       [rsp+60],r9
       vmovdqu   ymm0,ymmword ptr [rbx+r9+10]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rbx+r9+30]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rbx+r9+50]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],r8
       jne       near ptr M01_L27
       vmovdqu   ymm0,ymmword ptr [rsp+80]
       vmovdqu   ymmword ptr [rsp+0D0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A0]
       vmovdqu   ymmword ptr [rsp+0F0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+110],xmm0
M01_L11:
       mov       r9,[rsp+60]
       lea       rcx,[rax+r9+10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0D0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rsp+120]
       inc       r10d
       cmp       edi,r10d
       jg        near ptr M01_L09
M01_L12:
       lea       rcx,[r13+20]
       mov       rdx,[rsp+50]
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,[r13+18]
       test      rcx,rcx
       jne       near ptr M01_L29
M01_L14:
       mov       edx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rcx,[r12+10]
       xor       eax,eax
       mov       edx,esi
       lea       rdx,[rcx+rdx*4]
       cmp       esi,8
       jl        short M01_L16
       vmovups   ymm0,[7FF923172B40]
       vbroadcastss ymm1,dword ptr [7FF923172B60]
       lea       rax,[rdx-20]
M01_L15:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rax
       jbe       short M01_L15
       vmovd     eax,xmm0
M01_L16:
       cmp       rcx,rdx
       jb        near ptr M01_L31
M01_L17:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L34
       cmp       qword ptr [r13+18],0
       jne       short M01_L18
       mov       rcx,[r13+10]
       mov       rax,201F5400A68
       cmp       rcx,[rax]
       je        near ptr M01_L32
M01_L18:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,r13
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9232093E8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+78],rax
       mov       r8,[rsp+48]
       lea       rcx,[r8+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsp+48]
       mov       rcx,[rsp+78]
       mov       [r13+18],rcx
M01_L19:
       lea       rcx,[r12+10]
       mov       [rsp+68],rcx
       mov       [rsp+70],esi
       lea       rcx,[rsp+68]
       mov       rdx,r13
       call      qword ptr [7FF922D5E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M01_L20:
       xor       esi,esi
       test      r15d,r15d
       jle       short M01_L22
       cmp       edi,r15d
       jl        short M01_L24
       xor       esi,esi
M01_L21:
       imul      rcx,rsi,14
       add       rcx,r14
       cmp       [rcx],cl
       mov       r13d,[r12+rsi+10]
       cmp       r13d,edi
       jae       near ptr M01_L45
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rsi,4
       dec       r15d
       jne       short M01_L21
M01_L22:
       mov       rax,rbp
M01_L23:
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       ecx,esi
       imul      rcx,50
       add       rcx,r14
       cmp       [rcx],cl
       cmp       esi,edi
       jae       near ptr M01_L45
       mov       edx,esi
       mov       r13d,[r12+rdx*4+10]
       cmp       r13d,edi
       jae       near ptr M01_L45
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       esi
       cmp       esi,r15d
       jl        short M01_L24
       jmp       short M01_L22
M01_L25:
       mov       rax,rbx
       jmp       short M01_L23
M01_L26:
       mov       rcx,[rsi+68]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M01_L02
M01_L27:
       lea       r8,[rsp+80]
       lea       rdx,[rsp+0D0]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       rax,[rsp+50]
       jmp       near ptr M01_L11
M01_L28:
       lea       rcx,[rax+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L13
M01_L29:
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L14
M01_L30:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L14
M01_L31:
       lea       r8d,[rax+1]
       mov       [rcx],eax
       add       rcx,4
       cmp       rcx,rdx
       mov       eax,r8d
       jb        short M01_L31
       jmp       near ptr M01_L17
M01_L32:
       cmp       byte ptr [r13+28],0
       jne       short M01_L33
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+38],rdx
       mov       rcx,rdx
       mov       rdx,r13
       mov       r8,7FF9231D3270
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r13,[rsp+38]
       jmp       near ptr M01_L19
M01_L33:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rcx,rax
       mov       rdx,r13
       mov       r8,7FF9231D3288
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r13,[rsp+40]
       jmp       near ptr M01_L19
M01_L34:
       lea       r9d,[rsi-1]
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L20
M01_L35:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L36:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M01_L06
M01_L37:
       mov       rcx,rsi
       mov       r11,7FF922950C98
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L07
M01_L38:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L08
M01_L39:
       mov       rcx,rax
       call      qword ptr [7FF922FAEF28]
       jmp       near ptr M01_L08
M01_L40:
       mov       rcx,rax
       call      qword ptr [7FF922A05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L08
M01_L41:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923036B08]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L08
M01_L42:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922950CA0
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L08
M01_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,201F5400AE8
       mov       rbx,[rax]
       jmp       near ptr M01_L08
M01_L44:
       mov       rcx,rbx
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9230FD590]
M01_L45:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2031
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       vmovdqu   ymm0,ymmword ptr [r8]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymm0,ymmword ptr [r8+20]
       vmovdqu   ymmword ptr [rdx+20],ymm0
       vmovdqu   xmm0,xmmword ptr [r8+40]
       vmovdqu   xmmword ptr [rdx+40],xmm0
       mov       rax,rdx
       vzeroupper
       ret
; Total bytes of code 38
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M03_L02
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M03_L01
M03_L00:
       add       rsp,28
       ret
M03_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L00
M03_L02:
       add       rsp,28
       jmp       qword ptr [7FF922FAEF28]
; Total bytes of code 49
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,201DF400A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M04_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M04_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M04_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M04_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L01:
       test      edi,edi
       je        short M04_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M04_L00
M04_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922B7FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```
```assembly
; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+18],rdx
       mov       r8,rdx
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       cmp       eax,1
       jle       short M05_L00
       mov       [rbp-10],rdx
       mov       [rbp-8],eax
       lea       rcx,[rbp-10]
       or        eax,1
       xor       edx,edx
       lzcnt     edx,eax
       xor       edx,1F
       lea       edx,[rdx*2+2]
       call      qword ptr [7FF922D5E340]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].IntroSort(System.Span`1<Int32>, Int32, System.Comparison`1<Int32>)
       nop
M05_L00:
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       rcx,[rbp+18]
       call      qword ptr [7FF923294258]
       lea       rax,[M05_L00]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       ecx,40
       call      qword ptr [7FF923294270]
       lea       rax,[M05_L00]
       add       rsp,28
       ret
; Total bytes of code 133
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
       call      qword ptr [7FF9231DE8F8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark.OrderByWithoutComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0D8
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,1BAE0002A40
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L25
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rax,1BAE0000068
       mov       r14,[rax]
       mov       r15,r14
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+8],eax
       lea       rcx,[rbp+60]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L27
       xor       ecx,ecx
       mov       [rbp+68],rcx
       lea       rcx,[rbp+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[rbp+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+90],0
       mov       rcx,1BAE0002A48
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L26
M00_L01:
       mov       rcx,rbp
       mov       rdx,offset MT_System.Linq.IOrderedEnumerable<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231E9420
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       r8,r14
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r9d,r9d
       call      rax
       mov       rsi,rax
       mov       rdi,rsi
       test      rdi,rdi
       je        short M00_L02
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L07
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L08
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L37
       mov       rcx,[rdi+60]
       call      qword ptr [7FF9230DD470]; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       rsi,rax
       mov       ebp,[rsi+8]
       cmp       ebp,1
       jle       near ptr M00_L28
       mov       edx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+78]
       mov       rcx,1BAE0000A08
       cmp       r12,[rcx]
       je        near ptr M00_L29
M00_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+58],rax
       mov       rdx,[rdi+70]
       movzx     r8d,byte ptr [rdi+90]
       mov       [rsp+0D4],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+58]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+58]
       mov       ecx,[rsp+0D4]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+68],0
       je        short M00_L05
       mov       rcx,[rdi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L30
       mov       rdx,r12
       call      qword ptr [7FF9231E7CA8]; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M00_L04:
       mov       rdi,rax
       mov       rax,rdi
M00_L05:
       mov       rdi,rax
       mov       r12d,ebp
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L34
       mov       rax,[rdi+8]
       mov       [rsp+48],rax
       mov       rdx,1BAE0002A50
       cmp       rax,[rdx]
       je        near ptr M00_L32
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+40],rax
       xor       r10d,r10d
       mov       r9,[rsp+48]
       test      r9,r9
       je        near ptr M00_L13
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rdx
       jne       near ptr M00_L13
M00_L06:
       mov       edx,r10d
       imul      rdx,50
       lea       r9,[rsi+rdx+10]
       mov       r8,[r9+28]
       vmovdqu   ymm0,ymmword ptr [r9]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [r9+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [r9+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       [rsp+0D0],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+0D0]
       inc       r10d
       cmp       ebp,r10d
       jle       near ptr M00_L15
       mov       rax,[rsp+40]
       jmp       short M00_L06
M00_L07:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L08:
       mov       rdi,rsi
       test      rdi,rdi
       je        short M00_L09
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rdx
       jne       near ptr M00_L38
M00_L09:
       test      rdi,rdi
       je        near ptr M00_L46
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L39
       mov       esi,[rdi+8]
M00_L10:
       test      esi,esi
       je        near ptr M00_L45
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       ebp,[rdi+8]
       mov       rcx,[rdi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L43
       cmp       ebp,[rdi+8]
       ja        near ptr M00_L43
       cmp       ebp,[rsi+8]
       ja        near ptr M00_L43
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rdi+10]
       lea       rax,[rsi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L42
       cmp       r8,4000
       ja        near ptr M00_L41
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M00_L40
M00_L11:
       mov       [rsp+70],rsi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+70]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L12:
       mov       rax,[rsp+40]
M00_L13:
       cmp       r10d,ebp
       jae       near ptr M00_L47
       mov       [rsp+0D0],r10d
       mov       edx,r10d
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rdx
       jne       near ptr M00_L31
M00_L14:
       mov       edx,[rsp+0D0]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+0D0]
       inc       ecx
       cmp       ebp,ecx
       mov       r10d,ecx
       mov       r9,[rsp+48]
       jg        near ptr M00_L12
M00_L15:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
M00_L16:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M00_L17
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L33
       mov       rdx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF9231EA6B8]; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M00_L17:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+50],rax
       lea       rcx,[rax+10]
       xor       edx,edx
       mov       r8d,r12d
       lea       r8,[rcx+r8*4]
       cmp       r12d,8
       jl        short M00_L19
       vmovups   ymm0,[7FF923153FE0]
       vbroadcastss ymm1,dword ptr [7FF923154000]
       lea       rdx,[r8-20]
M00_L18:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rdx
       jbe       short M00_L18
       vmovd     edx,xmm0
M00_L19:
       cmp       rcx,r8
       jb        near ptr M00_L35
M00_L20:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L36
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       mov       rcx,rdi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231E9FA8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+78],rax
       mov       r8,[rsp+38]
       lea       rcx,[r8+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rsp+38]
       mov       rcx,[rsp+78]
       mov       [rdi+18],rcx
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       [rsp+60],rcx
       mov       [rsp+68],r12d
       lea       rcx,[rsp+60]
       mov       rdx,rdi
       call      qword ptr [7FF922D3E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M00_L21:
       mov       rdi,[rsp+50]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L23
       cmp       ebp,r13d
       jl        short M00_L24
       xor       r12d,r12d
M00_L22:
       imul      rcx,r12,14
       add       rcx,r15
       cmp       [rcx],cl
       mov       eax,[rdi+r12+10]
       cmp       eax,ebp
       jae       near ptr M00_L47
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,4
       dec       r13d
       jne       short M00_L22
M00_L23:
       mov       rsi,r14
       jmp       near ptr M00_L11
M00_L24:
       mov       ecx,r12d
       imul      rcx,50
       add       rcx,r15
       cmp       [rcx],cl
       cmp       r12d,ebp
       jae       near ptr M00_L47
       mov       edx,r12d
       mov       eax,[rdi+rdx*4+10]
       cmp       eax,ebp
       jae       near ptr M00_L47
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L24
       jmp       short M00_L23
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1BAE0002A30
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1BAE0002A40
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1BAE0002A30
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1BAE0002A48
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L27:
       mov       ecx,11
       call      qword ptr [7FF922C07E58]
       int       3
M00_L28:
       mov       r14,rsi
       jmp       near ptr M00_L23
M00_L29:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FF922C05DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF922D3DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M00_L03
M00_L30:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L04
M00_L31:
       mov       [rsp+0A8],r8
       lea       rdx,[rsp+80]
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+40]
       jmp       near ptr M00_L14
M00_L32:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229E58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L16
M00_L33:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L17
M00_L34:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L17
M00_L35:
       lea       r10d,[rdx+1]
       mov       [rcx],edx
       add       rcx,4
       cmp       rcx,r8
       mov       edx,r10d
       jb        short M00_L35
       jmp       near ptr M00_L20
M00_L36:
       mov       rax,[rsp+50]
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       jmp       near ptr M00_L21
M00_L37:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M00_L23
M00_L38:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M00_L09
M00_L39:
       mov       rcx,rdi
       mov       r11,7FF922930C20
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L10
M00_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L11
M00_L41:
       mov       rcx,rax
       call      qword ptr [7FF922F8EF28]
       jmp       near ptr M00_L11
M00_L42:
       mov       rcx,rax
       call      qword ptr [7FF9229E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L11
M00_L43:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923016B20]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L11
M00_L44:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF922930C28
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L45:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1BAE0002AE8
       mov       rsi,[rcx]
       jmp       near ptr M00_L11
M00_L46:
       mov       rcx,rsi
       call      qword ptr [7FF9230DD590]
       mov       rsi,rax
       jmp       near ptr M00_L11
M00_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2250
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,1BAE0000A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M01_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M01_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L01:
       test      edi,edi
       je        short M01_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M01_L00
M01_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922B5FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```
```assembly
; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M02_L00:
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
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       mov       rbx,rcx
       mov       rsi,rbx
       test      rsi,rsi
       je        short M02_L02
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       short M02_L01
       xor       esi,esi
       jmp       short M02_L02
M02_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
M02_L02:
       test      rsi,rsi
       jne       near ptr M02_L06
       mov       rsi,rbx
       test      rsi,rsi
       je        short M02_L03
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M02_L31
M02_L03:
       test      rsi,rsi
       je        near ptr M02_L39
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M02_L32
       mov       ebx,[rsi+8]
M02_L04:
       test      ebx,ebx
       je        near ptr M02_L38
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M02_L37
       mov       edi,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M02_L36
       cmp       edi,[rsi+8]
       ja        near ptr M02_L36
       cmp       edi,[rbx+8]
       ja        near ptr M02_L36
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M02_L35
       cmp       r8,4000
       ja        near ptr M02_L34
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M02_L33
M02_L05:
       mov       rax,rbx
       vzeroupper
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
M02_L06:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M02_L30
       mov       rcx,[rsi+60]
       call      qword ptr [7FF9230DD470]
       mov       rbx,rax
       mov       edi,[rbx+8]
       cmp       edi,1
       jle       near ptr M02_L22
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,[rsi+78]
       mov       rcx,1BAE0000A08
       cmp       r13,[rcx]
       je        near ptr M02_L23
M02_L07:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,[rsi+70]
       movzx     eax,byte ptr [rsi+90]
       mov       [rsp+0B4],eax
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rsp+0B4]
       mov       [r12+28],r13b
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       r13,r12
       cmp       qword ptr [rsi+68],0
       je        short M02_L08
       mov       rcx,[rsi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M02_L24
       mov       rdx,r12
       call      qword ptr [7FF9231E7CA8]; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       r13,rax
M02_L08:
       mov       esi,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [r13],rdx
       jne       near ptr M02_L27
       mov       r12,r13
       mov       rax,[r12+8]
       mov       [rsp+38],rax
       mov       rdx,1BAE0002A50
       cmp       rax,[rdx]
       je        near ptr M02_L25
       mov       edx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       xor       eax,eax
       jmp       short M02_L10
M02_L09:
       movsxd    rdx,dword ptr [rsp+40]
       mov       rcx,r12
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rcx,[rsp+40]
       inc       ecx
       cmp       edi,ecx
       mov       rax,rcx
       jle       near ptr M02_L12
M02_L10:
       mov       [rsp+40],rax
       imul      rdx,rax,50
       lea       rdx,[rbx+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r10,[rsp+38]
       cmp       [r10+18],rdx
       je        short M02_L09
       mov       [rsp+88],r8
       lea       rdx,[rsp+60]
       mov       rcx,[r10+8]
       call      qword ptr [r10+18]
       mov       r8,rax
       jmp       near ptr M02_L09
M02_L11:
       mov       ecx,esi
       imul      rcx,50
       add       rcx,r14
       cmp       [rcx],cl
       cmp       esi,edi
       jae       near ptr M02_L40
       mov       edx,esi
       mov       r13d,[r12+rdx*4+10]
       cmp       r13d,edi
       jae       near ptr M02_L40
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       esi
       cmp       esi,r15d
       jl        short M02_L11
       jmp       near ptr M02_L20
M02_L12:
       lea       rcx,[r13+20]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M02_L13:
       mov       rcx,[r13+18]
       test      rcx,rcx
       je        short M02_L14
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M02_L26
       mov       rdx,rbx
       mov       r8d,esi
       call      qword ptr [7FF9231EA6B8]; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M02_L14:
       mov       edx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rcx,[r12+10]
       xor       eax,eax
       mov       edx,esi
       lea       rdx,[rcx+rdx*4]
       cmp       esi,8
       jl        short M02_L16
       vmovups   ymm0,[7FF923153180]
       vbroadcastss ymm1,dword ptr [7FF9231531A0]
       lea       rax,[rdx-20]
M02_L15:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rax
       jbe       short M02_L15
       vmovd     eax,xmm0
M02_L16:
       cmp       rcx,rdx
       jb        near ptr M02_L28
M02_L17:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [r13],rcx
       jne       near ptr M02_L29
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       rcx,r13
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231E9FA8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+58],rax
       mov       r8,[rsp+30]
       lea       rcx,[r8+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsp+30]
       mov       rcx,[rsp+58]
       mov       [r13+18],rcx
       lea       rcx,[r12+10]
       mov       [rsp+48],rcx
       mov       [rsp+50],esi
       lea       rcx,[rsp+48]
       mov       rdx,r13
       call      qword ptr [7FF922D3E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M02_L18:
       xor       esi,esi
       test      r15d,r15d
       jle       short M02_L20
       cmp       edi,r15d
       jl        near ptr M02_L11
       xor       esi,esi
M02_L19:
       imul      rcx,rsi,14
       add       rcx,r14
       cmp       [rcx],cl
       mov       r13d,[r12+rsi+10]
       cmp       r13d,edi
       jae       near ptr M02_L40
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rsi,4
       dec       r15d
       jne       short M02_L19
M02_L20:
       mov       rax,rbp
M02_L21:
       vzeroupper
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
M02_L22:
       mov       rax,rbx
       jmp       short M02_L21
M02_L23:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF922C05DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FF922D3DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M02_L07
M02_L24:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M02_L08
M02_L25:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229E58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[r12+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L13
M02_L26:
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M02_L14
M02_L27:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M02_L14
M02_L28:
       lea       r8d,[rax+1]
       mov       [rcx],eax
       add       rcx,4
       cmp       rcx,rdx
       mov       eax,r8d
       jb        short M02_L28
       jmp       near ptr M02_L17
M02_L29:
       lea       r9d,[rsi-1]
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M02_L18
M02_L30:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M02_L31:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M02_L03
M02_L32:
       mov       rcx,rsi
       mov       r11,7FF922930C10
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M02_L04
M02_L33:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L05
M02_L34:
       mov       rcx,rax
       call      qword ptr [7FF922F8EF28]
       jmp       near ptr M02_L05
M02_L35:
       mov       rcx,rax
       call      qword ptr [7FF9229E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L05
M02_L36:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923016B20]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M02_L05
M02_L37:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922930C18
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M02_L05
M02_L38:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,1BAE0002AE8
       mov       rbx,[rax]
       jmp       near ptr M02_L05
M02_L39:
       mov       rcx,rbx
       vzeroupper
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9230DD590]
M02_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1697
```
```assembly
; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M03_L00:
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rbx+78]
       mov       rbp,[rbx]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.String
       cmp       [rcx+8],rax
       jne       short M03_L01
       mov       rcx,1BAE0000A08
       cmp       rdi,[rcx]
       je        near ptr M03_L07
M03_L01:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M03_L06
M03_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+70]
       movzx     r14d,byte ptr [rbx+90]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+28],r14b
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbp
       mov       rsi,[rbx+68]
       test      rsi,rsi
       je        near ptr M03_L05
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M03_L12
       mov       rdi,[rsi+78]
       mov       rcx,1BAE0000A08
       cmp       rdi,[rcx]
       je        near ptr M03_L10
M03_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,[rsi+70]
       movzx     r15d,byte ptr [rsi+90]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+28],r15b
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
       cmp       qword ptr [rsi+68],0
       je        short M03_L04
       mov       rcx,[rsi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M03_L11
       mov       rdx,r14
       call      qword ptr [7FF9231E7CA8]
       mov       rbp,rax
M03_L04:
       mov       rax,rbp
M03_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L06:
       mov       rcx,rbp
       mov       rdx,7FF9231C9B40
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L02
M03_L07:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF922C05DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF922D3DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rbp
       mov       rdx,7FF9231C9B58
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L09:
       mov       rdx,rdi
       call      qword ptr [7FF9229E58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M03_L01
M03_L10:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF922C05DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF922D3DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M03_L03
M03_L11:
       mov       rdx,r14
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M03_L04
M03_L12:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M03_L04
; Total bytes of code 576
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       rax,[rdx+28]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M05_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M05_L02
       cmp       rdx,[r8]
       jne       short M05_L03
M05_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M05_L01:
       call      qword ptr [7FF9231BD1A0]
       int       3
M05_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M05_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M05_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229ED8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M06_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M06_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
M06_L00:
       test      rax,rax
       je        short M06_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       test      rax,rax
       je        short M06_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       test      rax,rax
       jne       short M06_L03
M06_L01:
       xor       edx,edx
M06_L02:
       mov       rax,rdx
       ret
M06_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       test      rax,rax
       je        short M06_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       jmp       short M06_L00
; Total bytes of code 86
```
```assembly
; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M07_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,80
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       mov       [rsp+70],rax
       mov       [rsp+78],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rbp,[rsi+8]
       mov       rcx,1BAE0002A50
       cmp       rbp,[rcx]
       je        near ptr M07_L10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M07_L06
       mov       rcx,rax
M07_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M07_L03
       test      rbx,rbx
       je        near ptr M07_L07
       test      rbp,rbp
       je        near ptr M07_L07
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [rbp+18],rdx
       jne       near ptr M07_L07
       cmp       [rbx+8],r13d
       jl        near ptr M07_L07
M07_L02:
       mov       edx,r15d
       imul      rdx,50
       lea       rbp,[rbx+rdx+10]
       mov       r8,[rbp+28]
       vmovdqu   ymm0,ymmword ptr [rbp]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovdqu   ymm0,ymmword ptr [rbp+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   xmm0,xmmword ptr [rbp+40]
       vmovdqu   xmmword ptr [rsp+68],xmm0
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M07_L02
M07_L03:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L04:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        short M07_L05
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M07_L13
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FF9231EA6B8]
M07_L05:
       nop
       vzeroupper
       add       rsp,80
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L06:
       mov       rdx,7FF9231C9EA0
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M07_L01
M07_L07:
       cmp       r15d,[rbx+8]
       jae       near ptr M07_L14
       mov       edx,r15d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+68],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [rbp+18],rdx
       jne       short M07_L09
M07_L08:
       mov       edx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M07_L07
       jmp       near ptr M07_L03
M07_L09:
       mov       [rsp+50],r8
       lea       rdx,[rsp+28]
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
       mov       r8,rax
       jmp       short M07_L08
M07_L10:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L11
       jmp       short M07_L12
M07_L11:
       mov       rdx,7FF9231C9EA0
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M07_L12:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF9229E58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M07_L04
M07_L13:
       mov       rdx,rbx
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M07_L05
M07_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 563
```
```assembly
; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+18],rdx
       mov       r8,rdx
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       cmp       eax,1
       jle       short M08_L00
       mov       [rbp-10],rdx
       mov       [rbp-8],eax
       lea       rcx,[rbp-10]
       or        eax,1
       xor       edx,edx
       lzcnt     edx,eax
       xor       edx,1F
       lea       edx,[rdx*2+2]
       call      qword ptr [7FF922D3E340]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].IntroSort(System.Span`1<Int32>, Int32, System.Comparison`1<Int32>)
       nop
M08_L00:
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       rcx,[rbp+18]
       call      qword ptr [7FF923274318]
       lea       rax,[M08_L00]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       ecx,40
       call      qword ptr [7FF923274330]
       lea       rax,[M08_L00]
       add       rsp,28
       ret
; Total bytes of code 133
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M09_L02
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M09_L01
M09_L00:
       add       rsp,28
       ret
M09_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L00
M09_L02:
       add       rsp,28
       jmp       qword ptr [7FF922F8EF28]
; Total bytes of code 49
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       rax,[rdx+20]
       ret
; Total bytes of code 5
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M11_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L00:
       call      qword ptr [7FF9231BE9A0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       push      rbx
       sub       rsp,20
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       short M12_L03
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M12_L03
M12_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       je        short M12_L02
M12_L01:
       mov       rcx,7FF92322B550
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M12_L02:
       mov       rcx,1BAE0000110
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M12_L05
       mov       rcx,1BAE00000F0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M12_L04
       mov       rcx,7FF92322B558
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M12_L01
M12_L03:
       mov       ecx,2
       call      qword ptr [7FF9231BE598]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M12_L00
M12_L04:
       mov       rcx,7FF92322B554
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF92322B550
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF922C05E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
M12_L05:
       mov       rcx,7FF92322B55C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L01
; Total bytes of code 204
```
```assembly
; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r8d
       lea       rcx,[rbx+8]
       call      qword ptr [7FF982458FE8]; CORINFO_HELP_ASSIGN_REF
       test      esi,0DFFFFFC0
       jne       short M13_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M13_L00:
       call      qword ptr [7FF982463550]
       mov       rbx,rax
       call      qword ptr [7FF98246E1A8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 87
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M14_L05
       mov       rcx,[rbx]
       cmp       rcx,rsi
       je        near ptr M14_L04
       mov       rax,1BAE0000038
       mov       rax,[rax]
       add       rax,10
       rorx      rdx,rcx,20
       xor       rdx,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rdx,r8
       mov       r8d,[rax]
       shrx      rdx,rdx,r8
       xor       r8d,r8d
M14_L00:
       lea       r10d,[rdx+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rax+r10*8]
       mov       r9d,[r10]
       and       r9d,0FFFFFFFE
       cmp       [r10+8],rcx
       jne       short M14_L01
       mov       r11,rsi
       xor       r11,[r10+10]
       cmp       r11,1
       jbe       short M14_L03
M14_L01:
       test      r9d,r9d
       je        short M14_L02
       inc       r8d
       add       edx,r8d
       and       edx,[rax+4]
       cmp       r8d,8
       jl        short M14_L00
M14_L02:
       mov       rcx,7FF92322CC0C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF9229E6340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M14_L03:
       cmp       r9d,[r10]
       jne       short M14_L02
       cmp       r11d,1
       jne       short M14_L02
       mov       rcx,7FF92322CC00
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M14_L05
M14_L04:
       mov       rcx,7FF92322CC08
       call      CORINFO_HELP_COUNTPROFILE32
M14_L05:
       mov       rcx,7FF92322CC04
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 246
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M15_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M15_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M15_L01
       cmp       [r10],rcx
       je        short M15_L06
M15_L00:
       cmp       [r10+8],rcx
       je        short M15_L06
       cmp       [r10+10],rcx
       je        short M15_L06
       cmp       [r10+18],rcx
       je        short M15_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M15_L04
       test      r8,r8
       je        short M15_L03
M15_L01:
       cmp       [r10],rcx
       je        short M15_L06
M15_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M15_L03
       cmp       [r10],rcx
       je        short M15_L06
       jmp       short M15_L02
M15_L03:
       test      dword ptr [rax],500C0000
       je        short M15_L05
       jmp       qword ptr [7FF922D3F5B8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M15_L04:
       cmp       [r10],rcx
       je        short M15_L06
       jmp       short M15_L00
M15_L05:
       xor       edx,edx
M15_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M16_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M16_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M16_L02
       test      r8b,18
       je        short M16_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M16_L05
M16_L00:
       test      r8b,4
       je        short M16_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M16_L05
M16_L01:
       test      r8,r8
       je        short M16_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M16_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M16_L05
M16_L02:
       cmp       r8,40
       ja        short M16_L06
M16_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M16_L10
M16_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M16_L05:
       vzeroupper
       ret
M16_L06:
       cmp       r8,800
       ja        near ptr M16_L12
       cmp       r8,100
       jae       short M16_L09
M16_L07:
       mov       r9,r8
       shr       r9,6
M16_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M16_L08
       and       r8,3F
       cmp       r8,10
       ja        short M16_L03
       jmp       short M16_L04
M16_L09:
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
       jmp       short M16_L07
M16_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M16_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M16_L04
M16_L11:
       cmp       rcx,rdx
       jne       short M16_L12
       cmp       [rdx],dl
       jmp       near ptr M16_L05
M16_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF9229E66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 329
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M17_L09
       test      rsi,rsi
       je        near ptr M17_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M17_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M17_L10
M17_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M17_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M17_L07
       sub       edi,eax
       js        near ptr M17_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M17_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M17_L06
       sub       ebp,eax
       js        near ptr M17_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M17_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M17_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98246A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M17_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M17_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M17_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M17_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246D930]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M17_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M17_L15
M17_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M17_L04:
       cmp       r8,4000
       jbe       short M17_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M17_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M17_L02
       jmp       near ptr M17_L14
M17_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M17_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M17_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M17_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M17_L10:
       call      qword ptr [7FF982463788]
       mov       rbx,rax
       call      qword ptr [7FF98246ED60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246D7C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M17_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF982481910]
       int       3
M17_L12:
       call      qword ptr [7FF982463550]
       mov       rdi,rax
       call      qword ptr [7FF98246DC18]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rdi
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M17_L13:
       call      qword ptr [7FF982463550]
       mov       rbp,rax
       call      qword ptr [7FF98246DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rbp
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M17_L14:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M17_L02
M17_L15:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M17_L03
M17_L16:
       call      qword ptr [7FF982463578]
       mov       rbx,rax
       call      qword ptr [7FF98246E6E0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246C240]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M18_L00
       ret
M18_L00:
       jmp       qword ptr [7FF9229E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark.OrderByWithComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,138
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       vmovdqa   xmmword ptr [rsp+rax+140],xmm4
       vmovdqa   xmmword ptr [rsp+rax+150],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,18892C00A40
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L19
M00_L01:
       mov       rbp,[rbx+2E8]
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+8],eax
       lea       rcx,[r14+60]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L20
       xor       ecx,ecx
       mov       [r14+68],rcx
       lea       rcx,[r14+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       mov       rcx,18892C00A68
       test      rdx,rdx
       cmove     rdx,[rcx]
       lea       rcx,[r14+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],0
       mov       rcx,[r14+60]
       call      qword ptr [7FF9230DD470]; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L21
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r15,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r14+78]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[r14+70]
       movzx     r8d,byte ptr [r14+90]
       mov       [rsp+134],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+134]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r14+68],0
       jne       near ptr M00_L22
M00_L02:
       mov       r14,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r14],rdx
       jne       near ptr M00_L26
       mov       rax,[r14+8]
       mov       [rsp+40],rax
       mov       rdx,18892C00A58
       cmp       rax,[rdx]
       je        near ptr M00_L24
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        near ptr M00_L05
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L05
       mov       r10d,10
       mov       [rsp+5C],edi
M00_L03:
       vmovdqu   ymm0,ymmword ptr [rsi+r10]
       vmovdqu   ymmword ptr [rsp+90],ymm0
       vmovdqu   ymm0,ymmword ptr [rsi+r10+20]
       vmovdqu   ymmword ptr [rsp+0B0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsi+r10+40]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+90]
       vmovdqu   ymmword ptr [rsp+0E0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0B0]
       vmovdqu   ymmword ptr [rsp+100],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+120],xmm0
       mov       [rsp+60],r10
       lea       rcx,[rax+r10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0E0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10,[rsp+60]
       add       r10,50
       mov       r9d,[rsp+5C]
       dec       r9d
       mov       [rsp+5C],r9d
       je        near ptr M00_L07
       mov       rax,[rsp+38]
       jmp       near ptr M00_L03
M00_L04:
       mov       rax,[rsp+38]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L31
       mov       [rsp+130],r10d
       mov       r8d,r10d
       imul      r11,r8,50
       mov       [rsp+68],r11
       vmovdqu   ymm0,ymmword ptr [rsi+r11+10]
       vmovdqu   ymmword ptr [rsp+90],ymm0
       vmovdqu   ymm0,ymmword ptr [rsi+r11+30]
       vmovdqu   ymmword ptr [rsp+0B0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsi+r11+50]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],r8
       jne       near ptr M00_L23
       vmovdqu   ymm0,ymmword ptr [rsp+90]
       vmovdqu   ymmword ptr [rsp+0E0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0B0]
       vmovdqu   ymmword ptr [rsp+100],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+120],xmm0
M00_L06:
       mov       r11,[rsp+68]
       lea       rcx,[rax+r11+10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0E0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rsp+130]
       inc       r10d
       cmp       edi,r10d
       mov       r9,[rsp+40]
       jg        near ptr M00_L04
M00_L07:
       lea       rcx,[r14+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[r14+18]
       test      rcx,rcx
       jne       near ptr M00_L25
M00_L09:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       rcx,[rax+10]
       xor       edx,edx
       mov       r8d,r12d
       lea       r8,[rcx+r8*4]
       cmp       r12d,8
       jl        short M00_L11
       vmovups   ymm0,[7FF9231560A0]
       vbroadcastss ymm1,dword ptr [7FF9231560C0]
       lea       rdx,[r8-20]
M00_L10:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rdx
       jbe       short M00_L10
       vmovd     edx,xmm0
M00_L11:
       cmp       rcx,r8
       jb        near ptr M00_L27
M00_L12:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L30
       cmp       qword ptr [r14+18],0
       jne       short M00_L13
       mov       rcx,[r14+10]
       mov       rdx,18892C00A68
       cmp       rcx,[rdx]
       je        near ptr M00_L28
M00_L13:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       rcx,r14
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231E8DA8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+88],rax
       mov       r8,[rsp+30]
       lea       rcx,[r8+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rsp+30]
       mov       rcx,[rsp+88]
       mov       [r14+18],rcx
M00_L14:
       mov       rax,[rsp+48]
       lea       rcx,[rax+10]
       mov       [rsp+70],rcx
       mov       [rsp+78],r12d
       lea       rcx,[rsp+70]
       mov       rdx,r14
       call      qword ptr [7FF922D3E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M00_L15:
       mov       r14,[rsp+48]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L17
       cmp       edi,r13d
       jl        short M00_L18
       xor       r12d,r12d
M00_L16:
       imul      rcx,r12,14
       add       rcx,r15
       cmp       [rcx],cl
       mov       eax,[r14+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L31
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,4
       dec       r13d
       jne       short M00_L16
M00_L17:
       mov       [rsp+80],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+80]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
       add       rsp,138
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L18:
       mov       ecx,r12d
       imul      rcx,50
       add       rcx,r15
       cmp       [rcx],cl
       cmp       r12d,edi
       jae       near ptr M00_L31
       mov       edx,r12d
       mov       eax,[r14+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L31
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L18
       jmp       near ptr M00_L17
M00_L19:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,18892C00A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,18892C00A40
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L20:
       mov       ecx,11
       call      qword ptr [7FF922C07E58]
       int       3
M00_L21:
       mov       rbp,rsi
       jmp       near ptr M00_L17
M00_L22:
       mov       rcx,[r14+68]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r14,rax
       mov       rax,r14
       jmp       near ptr M00_L02
M00_L23:
       lea       r8,[rsp+90]
       lea       rdx,[rsp+0E0]
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       rax,[rsp+38]
       jmp       near ptr M00_L06
M00_L24:
       lea       rcx,[r14+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L25:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L26:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L27:
       lea       r10d,[rdx+1]
       mov       [rcx],edx
       add       rcx,4
       cmp       rcx,r8
       mov       edx,r10d
       jb        short M00_L27
       jmp       near ptr M00_L12
M00_L28:
       cmp       byte ptr [r14+28],0
       jne       short M00_L29
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+20],rdx
       mov       rcx,rdx
       mov       rdx,r14
       mov       r8,7FF9231B31B0
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r14,[rsp+20]
       jmp       near ptr M00_L14
M00_L29:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,7FF9231B31C8
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r14,[rsp+28]
       jmp       near ptr M00_L14
M00_L30:
       mov       rax,[rsp+48]
       lea       r9d,[r12-1]
       mov       rcx,r14
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r14]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       jmp       near ptr M00_L15
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1783
```
```assembly
; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M01_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,128
       xor       eax,eax
       mov       [rsp+68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       vmovdqu   ymmword ptr [rsp+0B0],ymm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       vmovdqu   ymmword ptr [rsp+0F0],ymm4
       vmovdqa   xmmword ptr [rsp+110],xmm4
       mov       rbx,rcx
       mov       rsi,rbx
       test      rsi,rsi
       je        short M01_L01
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M01_L04
       xor       esi,esi
M01_L01:
       test      rsi,rsi
       je        near ptr M01_L05
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M01_L35
       mov       rcx,[rsi+60]
       call      qword ptr [7FF9230DD470]
       mov       rbx,rax
       mov       edi,[rbx+8]
       cmp       edi,1
       jle       near ptr M01_L25
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,[rsi+78]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,[rsi+70]
       movzx     eax,byte ptr [rsi+90]
       mov       [rsp+124],eax
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rsp+124]
       mov       [r12+28],r13b
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       r13,r12
       cmp       qword ptr [rsi+68],0
       jne       near ptr M01_L26
M01_L02:
       mov       esi,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r13],rdx
       jne       near ptr M01_L30
       mov       rax,r13
       mov       r12,[rax+8]
       mov       rdx,18892C00A58
       cmp       r12,[rdx]
       je        near ptr M01_L28
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+50],rax
       xor       r10d,r10d
       test      r12,r12
       je        near ptr M01_L10
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],rcx
       jne       near ptr M01_L10
       mov       r12d,10
       mov       [rsp+5C],edi
M01_L03:
       vmovdqu   ymm0,ymmword ptr [rbx+r12]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rbx+r12+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rbx+r12+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+80]
       vmovdqu   ymmword ptr [rsp+0D0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A0]
       vmovdqu   ymmword ptr [rsp+0F0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+110],xmm0
       lea       rcx,[rax+r12]
       cmp       [rcx],cl
       lea       rdx,[rsp+0D0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,50
       mov       r10d,[rsp+5C]
       dec       r10d
       mov       [rsp+5C],r10d
       je        near ptr M01_L12
       mov       rax,[rsp+50]
       jmp       near ptr M01_L03
M01_L04:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M01_L01
       nop
M01_L05:
       mov       rsi,rbx
       test      rsi,rsi
       je        short M01_L06
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M01_L36
M01_L06:
       test      rsi,rsi
       je        near ptr M01_L44
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L37
       mov       ebx,[rsi+8]
M01_L07:
       test      ebx,ebx
       je        near ptr M01_L43
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L42
       mov       edi,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L41
       cmp       edi,[rsi+8]
       ja        near ptr M01_L41
       cmp       edi,[rbx+8]
       ja        near ptr M01_L41
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L40
       cmp       r8,4000
       ja        near ptr M01_L39
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L38
M01_L08:
       mov       rax,rbx
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rax,[rsp+50]
M01_L10:
       cmp       r10d,edi
       jae       near ptr M01_L45
       mov       [rsp+120],r10d
       mov       r8d,r10d
       imul      r9,r8,50
       mov       [rsp+60],r9
       vmovdqu   ymm0,ymmword ptr [rbx+r9+10]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rbx+r9+30]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rbx+r9+50]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],r8
       jne       near ptr M01_L27
       vmovdqu   ymm0,ymmword ptr [rsp+80]
       vmovdqu   ymmword ptr [rsp+0D0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A0]
       vmovdqu   ymmword ptr [rsp+0F0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+110],xmm0
M01_L11:
       mov       r9,[rsp+60]
       lea       rcx,[rax+r9+10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0D0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rsp+120]
       inc       r10d
       cmp       edi,r10d
       jg        near ptr M01_L09
M01_L12:
       lea       rcx,[r13+20]
       mov       rdx,[rsp+50]
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,[r13+18]
       test      rcx,rcx
       jne       near ptr M01_L29
M01_L14:
       mov       edx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rcx,[r12+10]
       xor       eax,eax
       mov       edx,esi
       lea       rdx,[rcx+rdx*4]
       cmp       esi,8
       jl        short M01_L16
       vmovups   ymm0,[7FF9231555A0]
       vbroadcastss ymm1,dword ptr [7FF9231555C0]
       lea       rax,[rdx-20]
M01_L15:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rax
       jbe       short M01_L15
       vmovd     eax,xmm0
M01_L16:
       cmp       rcx,rdx
       jb        near ptr M01_L31
M01_L17:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L34
       cmp       qword ptr [r13+18],0
       jne       short M01_L18
       mov       rcx,[r13+10]
       mov       rax,18892C00A68
       cmp       rcx,[rax]
       je        near ptr M01_L32
M01_L18:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,r13
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231E8DA8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+78],rax
       mov       r8,[rsp+48]
       lea       rcx,[r8+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsp+48]
       mov       rcx,[rsp+78]
       mov       [r13+18],rcx
M01_L19:
       lea       rcx,[r12+10]
       mov       [rsp+68],rcx
       mov       [rsp+70],esi
       lea       rcx,[rsp+68]
       mov       rdx,r13
       call      qword ptr [7FF922D3E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M01_L20:
       xor       esi,esi
       test      r15d,r15d
       jle       short M01_L22
       cmp       edi,r15d
       jl        short M01_L24
       xor       esi,esi
M01_L21:
       imul      rcx,rsi,14
       add       rcx,r14
       cmp       [rcx],cl
       mov       r13d,[r12+rsi+10]
       cmp       r13d,edi
       jae       near ptr M01_L45
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rsi,4
       dec       r15d
       jne       short M01_L21
M01_L22:
       mov       rax,rbp
M01_L23:
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       ecx,esi
       imul      rcx,50
       add       rcx,r14
       cmp       [rcx],cl
       cmp       esi,edi
       jae       near ptr M01_L45
       mov       edx,esi
       mov       r13d,[r12+rdx*4+10]
       cmp       r13d,edi
       jae       near ptr M01_L45
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       esi
       cmp       esi,r15d
       jl        short M01_L24
       jmp       short M01_L22
M01_L25:
       mov       rax,rbx
       jmp       short M01_L23
M01_L26:
       mov       rcx,[rsi+68]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M01_L02
M01_L27:
       lea       r8,[rsp+80]
       lea       rdx,[rsp+0D0]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       rax,[rsp+50]
       jmp       near ptr M01_L11
M01_L28:
       lea       rcx,[rax+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L13
M01_L29:
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L14
M01_L30:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L14
M01_L31:
       lea       r8d,[rax+1]
       mov       [rcx],eax
       add       rcx,4
       cmp       rcx,rdx
       mov       eax,r8d
       jb        short M01_L31
       jmp       near ptr M01_L17
M01_L32:
       cmp       byte ptr [r13+28],0
       jne       short M01_L33
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+38],rdx
       mov       rcx,rdx
       mov       rdx,r13
       mov       r8,7FF9231B31B0
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r13,[rsp+38]
       jmp       near ptr M01_L19
M01_L33:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rcx,rax
       mov       rdx,r13
       mov       r8,7FF9231B31C8
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r13,[rsp+40]
       jmp       near ptr M01_L19
M01_L34:
       lea       r9d,[rsi-1]
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L20
M01_L35:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L36:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M01_L06
M01_L37:
       mov       rcx,rsi
       mov       r11,7FF922930E18
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L07
M01_L38:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L08
M01_L39:
       mov       rcx,rax
       call      qword ptr [7FF922F8F3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L08
M01_L40:
       mov       rcx,rax
       call      qword ptr [7FF9229E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L08
M01_L41:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923016B20]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L08
M01_L42:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922930E20
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L08
M01_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,18892C00AE8
       mov       rbx,[rax]
       jmp       near ptr M01_L08
M01_L44:
       mov       rcx,rbx
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9230DD5C0]
M01_L45:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2031
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       vmovdqu   ymm0,ymmword ptr [r8]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymm0,ymmword ptr [r8+20]
       vmovdqu   ymmword ptr [rdx+20],ymm0
       vmovdqu   xmm0,xmmword ptr [r8+40]
       vmovdqu   xmmword ptr [rdx+40],xmm0
       mov       rax,rdx
       vzeroupper
       ret
; Total bytes of code 38
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M03_L02
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M03_L01
M03_L00:
       add       rsp,28
       ret
M03_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L00
M03_L02:
       add       rsp,28
       jmp       qword ptr [7FF922F8F3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 49
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,1887CC00A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M04_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M04_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M04_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M04_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L01:
       test      edi,edi
       je        short M04_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M04_L00
M04_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922B5FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```
```assembly
; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+18],rdx
       mov       r8,rdx
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       cmp       eax,1
       jle       short M05_L00
       mov       [rbp-10],rdx
       mov       [rbp-8],eax
       lea       rcx,[rbp-10]
       or        eax,1
       xor       edx,edx
       lzcnt     edx,eax
       xor       edx,1F
       lea       edx,[rdx*2+2]
       call      qword ptr [7FF922D3E340]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].IntroSort(System.Span`1<Int32>, Int32, System.Comparison`1<Int32>)
       nop
M05_L00:
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9232742B8]
       lea       rax,[M05_L00]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       ecx,40
       call      qword ptr [7FF9232742D0]
       lea       rax,[M05_L00]
       add       rsp,28
       ret
; Total bytes of code 133
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
       call      qword ptr [7FF9231BE928]
       int       3
; Total bytes of code 44
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark.OrderByWithoutComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0D8
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,24AEB800A48
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L24
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rax,24AD5800068
       mov       r14,[rax]
       mov       r15,r14
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+8],eax
       lea       rcx,[rbp+60]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L26
       xor       ecx,ecx
       mov       [rbp+68],rcx
       lea       rcx,[rbp+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[rbp+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+90],0
       mov       rcx,24AEB800A50
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L25
M00_L01:
       mov       rcx,rbp
       mov       rdx,offset MT_System.Linq.IOrderedEnumerable<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231E8D80
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       r8,r14
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r9d,r9d
       call      rax
       mov       rsi,rax
       mov       rdi,rsi
       test      rdi,rdi
       je        short M00_L02
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rdx
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L07
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L36
       mov       rcx,[rdi+60]
       call      qword ptr [7FF9230DD470]; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       rsi,rax
       mov       ebp,[rsi+8]
       cmp       ebp,1
       jle       near ptr M00_L27
       mov       edx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+78]
       mov       rcx,24AD5800A08
       cmp       r12,[rcx]
       je        near ptr M00_L28
M00_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+58],rax
       mov       rdx,[rdi+70]
       movzx     r8d,byte ptr [rdi+90]
       mov       [rsp+0D4],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+58]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+58]
       mov       ecx,[rsp+0D4]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+68],0
       je        short M00_L05
       mov       rcx,[rdi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L29
       mov       rdx,r12
       call      qword ptr [7FF9231E7608]; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M00_L04:
       mov       rdi,rax
       mov       rax,rdi
M00_L05:
       mov       rdi,rax
       mov       r12d,ebp
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       mov       rax,[rdi+8]
       mov       [rsp+48],rax
       mov       rdx,24AEB800A58
       cmp       rax,[rdx]
       je        near ptr M00_L31
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+40],rax
       xor       r10d,r10d
       mov       r9,[rsp+48]
       test      r9,r9
       je        near ptr M00_L12
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rdx
       jne       near ptr M00_L12
M00_L06:
       mov       edx,r10d
       imul      rdx,50
       lea       r9,[rsi+rdx+10]
       mov       r8,[r9+28]
       vmovdqu   ymm0,ymmword ptr [r9]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [r9+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [r9+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       [rsp+0D0],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+0D0]
       inc       r10d
       cmp       ebp,r10d
       jle       near ptr M00_L14
       mov       rax,[rsp+40]
       jmp       short M00_L06
       nop       dword ptr [rax+rax]
M00_L07:
       mov       rdi,rsi
       test      rdi,rdi
       je        short M00_L08
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rdx
       jne       near ptr M00_L37
M00_L08:
       test      rdi,rdi
       je        near ptr M00_L45
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L38
       mov       esi,[rdi+8]
M00_L09:
       test      esi,esi
       je        near ptr M00_L44
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L43
       mov       ebp,[rdi+8]
       mov       rcx,[rdi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L42
       cmp       ebp,[rdi+8]
       ja        near ptr M00_L42
       cmp       ebp,[rsi+8]
       ja        near ptr M00_L42
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rdi+10]
       lea       rax,[rsi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L41
       cmp       r8,4000
       ja        near ptr M00_L40
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M00_L39
M00_L10:
       mov       [rsp+70],rsi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+70]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L11:
       mov       rax,[rsp+40]
M00_L12:
       cmp       r10d,ebp
       jae       near ptr M00_L46
       mov       [rsp+0D0],r10d
       mov       edx,r10d
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rdx
       jne       near ptr M00_L30
M00_L13:
       mov       edx,[rsp+0D0]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+0D0]
       inc       ecx
       cmp       ebp,ecx
       mov       r10d,ecx
       mov       r9,[rsp+48]
       jg        near ptr M00_L11
M00_L14:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
M00_L15:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M00_L16
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L32
       mov       rdx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF9231EA018]; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M00_L16:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+50],rax
       lea       rcx,[rax+10]
       xor       edx,edx
       mov       r8d,r12d
       lea       r8,[rcx+r8*4]
       cmp       r12d,8
       jl        short M00_L18
       vmovups   ymm0,[7FF923156DC0]
       vbroadcastss ymm1,dword ptr [7FF923156DE0]
       lea       rdx,[r8-20]
M00_L17:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rdx
       jbe       short M00_L17
       vmovd     edx,xmm0
M00_L18:
       cmp       rcx,r8
       jb        near ptr M00_L34
M00_L19:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L35
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       mov       rcx,rdi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231E9908
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+78],rax
       mov       r8,[rsp+38]
       lea       rcx,[r8+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rsp+38]
       mov       rcx,[rsp+78]
       mov       [rdi+18],rcx
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       [rsp+60],rcx
       mov       [rsp+68],r12d
       lea       rcx,[rsp+60]
       mov       rdx,rdi
       call      qword ptr [7FF922D3E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M00_L20:
       mov       rdi,[rsp+50]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L22
       cmp       ebp,r13d
       jl        short M00_L23
       xor       r12d,r12d
M00_L21:
       imul      rcx,r12,14
       add       rcx,r15
       cmp       [rcx],cl
       mov       eax,[rdi+r12+10]
       cmp       eax,ebp
       jae       near ptr M00_L46
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,4
       dec       r13d
       jne       short M00_L21
M00_L22:
       mov       rsi,r14
       jmp       near ptr M00_L10
M00_L23:
       mov       ecx,r12d
       imul      rcx,50
       add       rcx,r15
       cmp       [rcx],cl
       cmp       r12d,ebp
       jae       near ptr M00_L46
       mov       edx,r12d
       mov       eax,[rdi+rdx*4+10]
       cmp       eax,ebp
       jae       near ptr M00_L46
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L23
       jmp       short M00_L22
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,24AEB800A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,24AEB800A48
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,24AEB800A38
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,24AEB800A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L26:
       mov       ecx,11
       call      qword ptr [7FF922C07E58]
       int       3
M00_L27:
       mov       r14,rsi
       jmp       near ptr M00_L22
M00_L28:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FF922C05DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF922D3DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M00_L03
M00_L29:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L04
M00_L30:
       mov       [rsp+0A8],r8
       lea       rdx,[rsp+80]
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+40]
       jmp       near ptr M00_L13
M00_L31:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229E58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L15
M00_L32:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L16
M00_L33:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L16
M00_L34:
       lea       r10d,[rdx+1]
       mov       [rcx],edx
       add       rcx,4
       cmp       rcx,r8
       mov       edx,r10d
       jb        short M00_L34
       jmp       near ptr M00_L19
M00_L35:
       mov       rax,[rsp+50]
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       jmp       near ptr M00_L20
M00_L36:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M00_L22
M00_L37:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M00_L08
M00_L38:
       mov       rcx,rdi
       mov       r11,7FF922930D98
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L09
M00_L39:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L10
M00_L40:
       mov       rcx,rax
       call      qword ptr [7FF922F8F3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L10
M00_L41:
       mov       rcx,rax
       call      qword ptr [7FF9229E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L10
M00_L42:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923016B20]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L10
M00_L43:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF922930DA0
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L10
M00_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24AEB800AF0
       mov       rsi,[rcx]
       jmp       near ptr M00_L10
M00_L45:
       mov       rcx,rsi
       call      qword ptr [7FF9230DD590]
       mov       rsi,rax
       jmp       near ptr M00_L10
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2246
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,24AD5800A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M01_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M01_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L01:
       test      edi,edi
       je        short M01_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M01_L00
M01_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922B5FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
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
```assembly
; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M03_L00:
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
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       mov       rbx,rcx
       mov       rsi,rbx
       test      rsi,rsi
       je        short M03_L02
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       short M03_L01
       xor       esi,esi
       jmp       short M03_L02
M03_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
M03_L02:
       test      rsi,rsi
       jne       near ptr M03_L06
       mov       rsi,rbx
       test      rsi,rsi
       je        short M03_L03
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M03_L31
M03_L03:
       test      rsi,rsi
       je        near ptr M03_L39
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M03_L32
       mov       ebx,[rsi+8]
M03_L04:
       test      ebx,ebx
       je        near ptr M03_L38
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M03_L37
       mov       edi,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M03_L36
       cmp       edi,[rsi+8]
       ja        near ptr M03_L36
       cmp       edi,[rbx+8]
       ja        near ptr M03_L36
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M03_L35
       cmp       r8,4000
       ja        near ptr M03_L34
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M03_L33
M03_L05:
       mov       rax,rbx
       vzeroupper
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
M03_L06:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M03_L30
       mov       rcx,[rsi+60]
       call      qword ptr [7FF9230DD470]
       mov       rbx,rax
       mov       edi,[rbx+8]
       cmp       edi,1
       jle       near ptr M03_L22
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,[rsi+78]
       mov       rcx,24AD5800A08
       cmp       r13,[rcx]
       je        near ptr M03_L23
M03_L07:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,[rsi+70]
       movzx     eax,byte ptr [rsi+90]
       mov       [rsp+0B4],eax
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rsp+0B4]
       mov       [r12+28],r13b
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       r13,r12
       cmp       qword ptr [rsi+68],0
       je        short M03_L08
       mov       rcx,[rsi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M03_L24
       mov       rdx,r12
       call      qword ptr [7FF9231E7608]; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       r13,rax
M03_L08:
       mov       esi,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [r13],rdx
       jne       near ptr M03_L27
       mov       r12,r13
       mov       rax,[r12+8]
       mov       [rsp+38],rax
       mov       rdx,24AEB800A58
       cmp       rax,[rdx]
       je        near ptr M03_L25
       mov       edx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       xor       eax,eax
       jmp       short M03_L10
M03_L09:
       movsxd    rdx,dword ptr [rsp+40]
       mov       rcx,r12
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rcx,[rsp+40]
       inc       ecx
       cmp       edi,ecx
       mov       rax,rcx
       jle       near ptr M03_L12
M03_L10:
       mov       [rsp+40],rax
       imul      rdx,rax,50
       lea       rdx,[rbx+rdx+10]
       mov       r8,[rdx+20]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r10,[rsp+38]
       cmp       [r10+18],rdx
       je        short M03_L09
       mov       [rsp+80],r8
       lea       rdx,[rsp+60]
       mov       rcx,[r10+8]
       call      qword ptr [r10+18]
       mov       r8,rax
       jmp       near ptr M03_L09
M03_L11:
       mov       ecx,esi
       imul      rcx,50
       add       rcx,r14
       cmp       [rcx],cl
       cmp       esi,edi
       jae       near ptr M03_L40
       mov       edx,esi
       mov       r13d,[r12+rdx*4+10]
       cmp       r13d,edi
       jae       near ptr M03_L40
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       esi
       cmp       esi,r15d
       jl        short M03_L11
       jmp       near ptr M03_L20
M03_L12:
       lea       rcx,[r13+20]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M03_L13:
       mov       rcx,[r13+18]
       test      rcx,rcx
       je        short M03_L14
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M03_L26
       mov       rdx,rbx
       mov       r8d,esi
       call      qword ptr [7FF9231EA018]; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M03_L14:
       mov       edx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rcx,[r12+10]
       xor       eax,eax
       mov       edx,esi
       lea       rdx,[rcx+rdx*4]
       cmp       esi,8
       jl        short M03_L16
       vmovups   ymm0,[7FF923155BA0]
       vbroadcastss ymm1,dword ptr [7FF923155BC0]
       lea       rax,[rdx-20]
M03_L15:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rax
       jbe       short M03_L15
       vmovd     eax,xmm0
M03_L16:
       cmp       rcx,rdx
       jb        near ptr M03_L28
M03_L17:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [r13],rcx
       jne       near ptr M03_L29
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       rcx,r13
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231E9908
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+58],rax
       mov       r8,[rsp+30]
       lea       rcx,[r8+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsp+30]
       mov       rcx,[rsp+58]
       mov       [r13+18],rcx
       lea       rcx,[r12+10]
       mov       [rsp+48],rcx
       mov       [rsp+50],esi
       lea       rcx,[rsp+48]
       mov       rdx,r13
       call      qword ptr [7FF922D3E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M03_L18:
       xor       esi,esi
       test      r15d,r15d
       jle       short M03_L20
       cmp       edi,r15d
       jl        near ptr M03_L11
       xor       esi,esi
M03_L19:
       imul      rcx,rsi,14
       add       rcx,r14
       cmp       [rcx],cl
       mov       r13d,[r12+rsi+10]
       cmp       r13d,edi
       jae       near ptr M03_L40
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rsi,4
       dec       r15d
       jne       short M03_L19
M03_L20:
       mov       rax,rbp
M03_L21:
       vzeroupper
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
M03_L22:
       mov       rax,rbx
       jmp       short M03_L21
M03_L23:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF922C05DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FF922D3DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M03_L07
M03_L24:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M03_L08
M03_L25:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229E58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[r12+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L13
M03_L26:
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M03_L14
M03_L27:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M03_L14
M03_L28:
       lea       r8d,[rax+1]
       mov       [rcx],eax
       add       rcx,4
       cmp       rcx,rdx
       mov       eax,r8d
       jb        short M03_L28
       jmp       near ptr M03_L17
M03_L29:
       lea       r9d,[rsi-1]
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M03_L18
M03_L30:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M03_L31:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M03_L03
M03_L32:
       mov       rcx,rsi
       mov       r11,7FF922930D88
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M03_L04
M03_L33:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L05
M03_L34:
       mov       rcx,rax
       call      qword ptr [7FF922F8F3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L05
M03_L35:
       mov       rcx,rax
       call      qword ptr [7FF9229E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L05
M03_L36:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923016B20]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M03_L05
M03_L37:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922930D90
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M03_L05
M03_L38:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,24AEB800AF0
       mov       rbx,[rax]
       jmp       near ptr M03_L05
M03_L39:
       mov       rcx,rbx
       vzeroupper
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9230DD590]
M03_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1697
```
```assembly
; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M04_L00:
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rbx+78]
       mov       rbp,[rbx]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.String
       cmp       [rcx+8],rax
       jne       short M04_L01
       mov       rcx,24AD5800A08
       cmp       rdi,[rcx]
       je        near ptr M04_L07
M04_L01:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M04_L06
M04_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+70]
       movzx     r14d,byte ptr [rbx+90]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+28],r14b
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbp
       mov       rsi,[rbx+68]
       test      rsi,rsi
       je        near ptr M04_L05
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M04_L12
       mov       rdi,[rsi+78]
       mov       rcx,24AD5800A08
       cmp       rdi,[rcx]
       je        near ptr M04_L10
M04_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,[rsi+70]
       movzx     r15d,byte ptr [rsi+90]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+28],r15b
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
       cmp       qword ptr [rsi+68],0
       je        short M04_L04
       mov       rcx,[rsi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M04_L11
       mov       rdx,r14
       call      qword ptr [7FF9231E7608]
       mov       rbp,rax
M04_L04:
       mov       rax,rbp
M04_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L06:
       mov       rcx,rbp
       mov       rdx,7FF9231C9A58
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L07:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF922C05DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF922D3DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rbp
       mov       rdx,7FF9231C9A70
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M04_L09:
       mov       rdx,rdi
       call      qword ptr [7FF9229E58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M04_L01
M04_L10:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF922C05DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF922D3DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M04_L03
M04_L11:
       mov       rdx,r14
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M04_L04
M04_L12:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M04_L04
; Total bytes of code 576
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       rax,[rdx+28]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M06_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M06_L02
       cmp       rdx,[r8]
       jne       short M06_L03
M06_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M06_L01:
       call      qword ptr [7FF9231BD218]
       int       3
M06_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M06_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M06_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229ED8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M07_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,80
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       mov       [rsp+70],rax
       mov       [rsp+78],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rbp,[rsi+8]
       mov       rcx,24AEB800A58
       cmp       rbp,[rcx]
       je        near ptr M07_L10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M07_L06
       mov       rcx,rax
M07_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M07_L03
       test      rbx,rbx
       je        near ptr M07_L07
       test      rbp,rbp
       je        near ptr M07_L07
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [rbp+18],rdx
       jne       near ptr M07_L07
       cmp       [rbx+8],r13d
       jl        near ptr M07_L07
M07_L02:
       mov       edx,r15d
       imul      rdx,50
       lea       rbp,[rbx+rdx+10]
       mov       r8,[rbp+28]
       vmovdqu   ymm0,ymmword ptr [rbp]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovdqu   ymm0,ymmword ptr [rbp+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   xmm0,xmmword ptr [rbp+40]
       vmovdqu   xmmword ptr [rsp+68],xmm0
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M07_L02
M07_L03:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L04:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        short M07_L05
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M07_L13
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FF9231EA018]
M07_L05:
       nop
       vzeroupper
       add       rsp,80
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L06:
       mov       rdx,7FF9231C9DB8
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M07_L01
M07_L07:
       cmp       r15d,[rbx+8]
       jae       near ptr M07_L14
       mov       edx,r15d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+68],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [rbp+18],rdx
       jne       short M07_L09
M07_L08:
       mov       edx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M07_L07
       jmp       near ptr M07_L03
M07_L09:
       mov       [rsp+50],r8
       lea       rdx,[rsp+28]
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
       mov       r8,rax
       jmp       short M07_L08
M07_L10:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L11
       jmp       short M07_L12
M07_L11:
       mov       rdx,7FF9231C9DB8
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M07_L12:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF9229E58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M07_L04
M07_L13:
       mov       rdx,rbx
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M07_L05
M07_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 563
```
```assembly
; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+18],rdx
       mov       r8,rdx
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       cmp       eax,1
       jle       short M08_L00
       mov       [rbp-10],rdx
       mov       [rbp-8],eax
       lea       rcx,[rbp-10]
       or        eax,1
       xor       edx,edx
       lzcnt     edx,eax
       xor       edx,1F
       lea       edx,[rdx*2+2]
       call      qword ptr [7FF922D3E340]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].IntroSort(System.Span`1<Int32>, Int32, System.Comparison`1<Int32>)
       nop
M08_L00:
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       rcx,[rbp+18]
       call      qword ptr [7FF923274360]
       lea       rax,[M08_L00]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       ecx,40
       call      qword ptr [7FF923274378]
       lea       rax,[M08_L00]
       add       rsp,28
       ret
; Total bytes of code 133
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M09_L02
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M09_L01
M09_L00:
       add       rsp,28
       ret
M09_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L00
M09_L02:
       add       rsp,28
       jmp       qword ptr [7FF922F8F3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 49
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       rax,[rdx+20]
       ret
; Total bytes of code 5
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M11_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L00:
       call      qword ptr [7FF9231BE9D0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       push      rbx
       sub       rsp,20
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       short M12_L03
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M12_L03
M12_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       je        short M12_L02
M12_L01:
       mov       rcx,7FF92322B578
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M12_L02:
       mov       rcx,24AD5800110
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M12_L05
       mov       rcx,24AD58000F0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M12_L04
       mov       rcx,7FF92322B580
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M12_L01
M12_L03:
       mov       ecx,2
       call      qword ptr [7FF9231BE5C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M12_L00
M12_L04:
       mov       rcx,7FF92322B57C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF92322B578
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF922C05E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
M12_L05:
       mov       rcx,7FF92322B584
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L01
; Total bytes of code 204
```
```assembly
; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r8d
       lea       rcx,[rbx+8]
       call      qword ptr [7FF982458FE8]; CORINFO_HELP_ASSIGN_REF
       test      esi,0DFFFFFC0
       jne       short M13_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M13_L00:
       call      qword ptr [7FF982463550]
       mov       rbx,rax
       call      qword ptr [7FF98246E1A8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 87
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M14_L05
       mov       rcx,[rbx]
       cmp       rcx,rsi
       je        near ptr M14_L04
       mov       rax,24AD5800038
       mov       rax,[rax]
       add       rax,10
       rorx      rdx,rcx,20
       xor       rdx,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rdx,r8
       mov       r8d,[rax]
       shrx      rdx,rdx,r8
       xor       r8d,r8d
M14_L00:
       lea       r10d,[rdx+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rax+r10*8]
       mov       r9d,[r10]
       and       r9d,0FFFFFFFE
       cmp       [r10+8],rcx
       jne       short M14_L01
       mov       r11,rsi
       xor       r11,[r10+10]
       cmp       r11,1
       jbe       short M14_L03
M14_L01:
       test      r9d,r9d
       je        short M14_L02
       inc       r8d
       add       edx,r8d
       and       edx,[rax+4]
       cmp       r8d,8
       jl        short M14_L00
M14_L02:
       mov       rcx,7FF92322CB6C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF9229E6340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M14_L03:
       cmp       r9d,[r10]
       jne       short M14_L02
       cmp       r11d,1
       jne       short M14_L02
       mov       rcx,7FF92322CB60
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M14_L05
M14_L04:
       mov       rcx,7FF92322CB68
       call      CORINFO_HELP_COUNTPROFILE32
M14_L05:
       mov       rcx,7FF92322CB64
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 246
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M15_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M15_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M15_L01
       cmp       [r10],rcx
       je        short M15_L06
M15_L00:
       cmp       [r10+8],rcx
       je        short M15_L06
       cmp       [r10+10],rcx
       je        short M15_L06
       cmp       [r10+18],rcx
       je        short M15_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M15_L04
       test      r8,r8
       je        short M15_L03
M15_L01:
       cmp       [r10],rcx
       je        short M15_L06
M15_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M15_L03
       cmp       [r10],rcx
       je        short M15_L06
       jmp       short M15_L02
M15_L03:
       test      dword ptr [rax],500C0000
       je        short M15_L05
       jmp       qword ptr [7FF922D3F5B8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M15_L04:
       cmp       [r10],rcx
       je        short M15_L06
       jmp       short M15_L00
M15_L05:
       xor       edx,edx
M15_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M16_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M16_L06
M16_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FF9826037E0
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FF982943A90],0
       jne       short M16_L04
M16_L01:
       cmp       rdi,4000
       ja        short M16_L00
M16_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M16_L05
M16_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M16_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M16_L01
M16_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M16_L03
M16_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       je        short M16_L07
       call      CORINFO_HELP_POLL_GC
M16_L07:
       cmp       rdi,4000
       ja        short M16_L06
       jmp       short M16_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M17_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M17_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M17_L02
       test      r8b,18
       je        short M17_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M17_L05
M17_L00:
       test      r8b,4
       je        short M17_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M17_L05
M17_L01:
       test      r8,r8
       je        short M17_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M17_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M17_L05
M17_L02:
       cmp       r8,40
       ja        short M17_L06
M17_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M17_L09
M17_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M17_L05:
       vzeroupper
       ret
M17_L06:
       cmp       r8,800
       ja        near ptr M17_L12
       cmp       r8,100
       jae       short M17_L10
M17_L07:
       mov       r9,r8
       shr       r9,6
M17_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M17_L08
       and       r8,3F
       cmp       r8,10
       ja        short M17_L03
       jmp       short M17_L04
M17_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M17_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M17_L04
M17_L10:
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
       jmp       short M17_L07
M17_L11:
       cmp       rcx,rdx
       jne       short M17_L12
       cmp       [rdx],dl
       jmp       near ptr M17_L05
M17_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF9229E66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 318
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M18_L09
       test      rsi,rsi
       je        near ptr M18_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M18_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M18_L10
M18_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M18_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M18_L07
       sub       edi,eax
       js        near ptr M18_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M18_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M18_L06
       sub       ebp,eax
       js        near ptr M18_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M18_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M18_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98246A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M18_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M18_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M18_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M18_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246D930]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M18_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M18_L15
M18_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M18_L04:
       cmp       r8,4000
       jbe       short M18_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M18_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M18_L02
       jmp       near ptr M18_L14
M18_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M18_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M18_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M18_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M18_L10:
       call      qword ptr [7FF982463788]
       mov       rbx,rax
       call      qword ptr [7FF98246ED60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246D7C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M18_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF982481910]
       int       3
M18_L12:
       call      qword ptr [7FF982463550]
       mov       rdi,rax
       call      qword ptr [7FF98246DC18]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rdi
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M18_L13:
       call      qword ptr [7FF982463550]
       mov       rbp,rax
       call      qword ptr [7FF98246DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rbp
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M18_L14:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M18_L02
M18_L15:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M18_L03
M18_L16:
       call      qword ptr [7FF982463578]
       mov       rbx,rax
       call      qword ptr [7FF98246E6E0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246C240]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M19_L00
       ret
M19_L00:
       jmp       qword ptr [7FF9229E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark.OrderByWithComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,138
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       vmovdqa   xmmword ptr [rsp+rax+140],xmm4
       vmovdqa   xmmword ptr [rsp+rax+150],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,1A4F6002A38
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L20
M00_L01:
       mov       rbp,[rbx+2E8]
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+8],eax
       lea       rcx,[r14+60]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L21
       xor       ecx,ecx
       mov       [r14+68],rcx
       lea       rcx,[r14+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       mov       rcx,1A4F6002A60
       test      rdx,rdx
       cmove     rdx,[rcx]
       lea       rcx,[r14+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],0
       mov       rcx,[r14+60]
       call      qword ptr [7FF9230ED458]; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L22
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r15,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r14+78]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[r14+70]
       movzx     r8d,byte ptr [r14+90]
       mov       [rsp+134],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+134]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r14+68],0
       jne       near ptr M00_L23
M00_L02:
       mov       r14,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r14],rdx
       jne       near ptr M00_L27
       mov       rax,[r14+8]
       mov       [rsp+40],rax
       mov       rdx,1A4F6002A50
       cmp       rax,[rdx]
       je        near ptr M00_L25
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        near ptr M00_L05
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L05
       mov       r10d,10
       mov       [rsp+5C],edi
M00_L03:
       vmovdqu   ymm0,ymmword ptr [rsi+r10]
       vmovdqu   ymmword ptr [rsp+90],ymm0
       vmovdqu   ymm0,ymmword ptr [rsi+r10+20]
       vmovdqu   ymmword ptr [rsp+0B0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsi+r10+40]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+90]
       vmovdqu   ymmword ptr [rsp+0E0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0B0]
       vmovdqu   ymmword ptr [rsp+100],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+120],xmm0
       mov       [rsp+60],r10
       lea       rcx,[rax+r10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0E0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10,[rsp+60]
       add       r10,50
       mov       r9d,[rsp+5C]
       dec       r9d
       mov       [rsp+5C],r9d
       je        near ptr M00_L07
       mov       rax,[rsp+38]
       jmp       near ptr M00_L03
M00_L04:
       mov       rax,[rsp+38]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L31
       mov       [rsp+130],r10d
       mov       r8d,r10d
       imul      r11,r8,50
       mov       [rsp+68],r11
       vmovdqu   ymm0,ymmword ptr [rsi+r11+10]
       vmovdqu   ymmword ptr [rsp+90],ymm0
       vmovdqu   ymm0,ymmword ptr [rsi+r11+30]
       vmovdqu   ymmword ptr [rsp+0B0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsi+r11+50]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],r8
       jne       near ptr M00_L24
       vmovdqu   ymm0,ymmword ptr [rsp+90]
       vmovdqu   ymmword ptr [rsp+0E0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0B0]
       vmovdqu   ymmword ptr [rsp+100],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+120],xmm0
M00_L06:
       mov       r11,[rsp+68]
       lea       rcx,[rax+r11+10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0E0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rsp+130]
       inc       r10d
       cmp       edi,r10d
       mov       r9,[rsp+40]
       jg        near ptr M00_L04
M00_L07:
       lea       rcx,[r14+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[r14+18]
       test      rcx,rcx
       jne       near ptr M00_L26
M00_L09:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       rcx,[rax+10]
       xor       edx,edx
       mov       r8d,r12d
       lea       r8,[rcx+r8*4]
       cmp       r12d,8
       jl        short M00_L11
       vmovups   ymm0,[7FF923163840]
       vbroadcastss ymm1,dword ptr [7FF923163860]
       lea       rdx,[r8-20]
M00_L10:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rdx
       jbe       short M00_L10
       vmovd     edx,xmm0
M00_L11:
       cmp       rcx,r8
       jb        near ptr M00_L18
M00_L12:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L30
       cmp       qword ptr [r14+18],0
       jne       short M00_L13
       mov       rcx,[r14+10]
       mov       rdx,1A4F6002A60
       cmp       rcx,[rdx]
       je        near ptr M00_L28
M00_L13:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       rcx,r14
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231F8DA8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+88],rax
       mov       r8,[rsp+30]
       lea       rcx,[r8+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rsp+30]
       mov       rcx,[rsp+88]
       mov       [r14+18],rcx
M00_L14:
       mov       rax,[rsp+48]
       lea       rcx,[rax+10]
       mov       [rsp+70],rcx
       mov       [rsp+78],r12d
       lea       rcx,[rsp+70]
       mov       rdx,r14
       call      qword ptr [7FF922D4E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M00_L15:
       mov       r14,[rsp+48]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L17
       cmp       edi,r13d
       jl        near ptr M00_L19
       xor       r12d,r12d
M00_L16:
       imul      rcx,r12,14
       add       rcx,r15
       cmp       [rcx],cl
       mov       eax,[r14+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L31
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,4
       dec       r13d
       jne       short M00_L16
M00_L17:
       mov       [rsp+80],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+80]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
       add       rsp,138
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L18:
       lea       r10d,[rdx+1]
       mov       [rcx],edx
       add       rcx,4
       cmp       rcx,r8
       mov       edx,r10d
       jb        short M00_L18
       jmp       near ptr M00_L12
M00_L19:
       mov       ecx,r12d
       imul      rcx,50
       add       rcx,r15
       cmp       [rcx],cl
       cmp       r12d,edi
       jae       near ptr M00_L31
       mov       edx,r12d
       mov       eax,[r14+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L31
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L19
       jmp       near ptr M00_L17
M00_L20:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1A4F6002A30
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A4F6002A38
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L21:
       mov       ecx,11
       call      qword ptr [7FF922C17E58]
       int       3
M00_L22:
       mov       rbp,rsi
       jmp       near ptr M00_L17
M00_L23:
       mov       rcx,[r14+68]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r14,rax
       mov       rax,r14
       jmp       near ptr M00_L02
M00_L24:
       lea       r8,[rsp+90]
       lea       rdx,[rsp+0E0]
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       rax,[rsp+38]
       jmp       near ptr M00_L06
M00_L25:
       lea       rcx,[r14+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L26:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L27:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L28:
       cmp       byte ptr [r14+28],0
       jne       short M00_L29
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+20],rdx
       mov       rcx,rdx
       mov       rdx,r14
       mov       r8,7FF9231C31B0
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r14,[rsp+20]
       jmp       near ptr M00_L14
M00_L29:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,7FF9231C31C8
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r14,[rsp+28]
       jmp       near ptr M00_L14
M00_L30:
       mov       rax,[rsp+48]
       lea       r9d,[r12-1]
       mov       rcx,r14
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r14]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       jmp       near ptr M00_L15
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1787
```
```assembly
; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M01_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,128
       xor       eax,eax
       mov       [rsp+68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       vmovdqu   ymmword ptr [rsp+0B0],ymm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       vmovdqu   ymmword ptr [rsp+0F0],ymm4
       vmovdqa   xmmword ptr [rsp+110],xmm4
       mov       rbx,rcx
       mov       rsi,rbx
       test      rsi,rsi
       je        short M01_L01
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [rsi],rdx
       je        short M01_L01
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
M01_L01:
       test      rsi,rsi
       jne       near ptr M01_L05
       mov       rsi,rbx
       test      rsi,rsi
       je        short M01_L02
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M01_L35
M01_L02:
       test      rsi,rsi
       je        near ptr M01_L43
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L36
       mov       ebx,[rsi+8]
M01_L03:
       test      ebx,ebx
       je        near ptr M01_L42
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L41
       mov       edi,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L40
       cmp       edi,[rsi+8]
       ja        near ptr M01_L40
       cmp       edi,[rbx+8]
       ja        near ptr M01_L40
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L39
       cmp       r8,4000
       ja        near ptr M01_L38
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L37
M01_L04:
       mov       rax,rbx
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M01_L34
       mov       rcx,[rsi+60]
       call      qword ptr [7FF9230ED458]
       mov       rbx,rax
       mov       edi,[rbx+8]
       cmp       edi,1
       jle       near ptr M01_L24
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,[rsi+78]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,[rsi+70]
       movzx     eax,byte ptr [rsi+90]
       mov       [rsp+124],eax
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rsp+124]
       mov       [r12+28],r13b
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       r13,r12
       cmp       qword ptr [rsi+68],0
       jne       near ptr M01_L25
M01_L06:
       mov       esi,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r13],rdx
       jne       near ptr M01_L29
       mov       rax,r13
       mov       r12,[rax+8]
       mov       rdx,1A4F6002A50
       cmp       r12,[rdx]
       je        near ptr M01_L27
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+50],rax
       xor       r10d,r10d
       test      r12,r12
       je        near ptr M01_L09
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],rcx
       jne       near ptr M01_L09
       mov       r12d,10
       mov       [rsp+5C],edi
M01_L07:
       vmovdqu   ymm0,ymmword ptr [rbx+r12]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rbx+r12+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rbx+r12+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+80]
       vmovdqu   ymmword ptr [rsp+0D0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A0]
       vmovdqu   ymmword ptr [rsp+0F0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+110],xmm0
       lea       rcx,[rax+r12]
       cmp       [rcx],cl
       lea       rdx,[rsp+0D0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,50
       mov       r10d,[rsp+5C]
       dec       r10d
       mov       [rsp+5C],r10d
       je        near ptr M01_L11
       mov       rax,[rsp+50]
       jmp       near ptr M01_L07
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M01_L08:
       mov       rax,[rsp+50]
M01_L09:
       cmp       r10d,edi
       jae       near ptr M01_L44
       mov       [rsp+120],r10d
       mov       r8d,r10d
       imul      r9,r8,50
       mov       [rsp+60],r9
       vmovdqu   ymm0,ymmword ptr [rbx+r9+10]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rbx+r9+30]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rbx+r9+50]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],r8
       jne       near ptr M01_L26
       vmovdqu   ymm0,ymmword ptr [rsp+80]
       vmovdqu   ymmword ptr [rsp+0D0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A0]
       vmovdqu   ymmword ptr [rsp+0F0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+110],xmm0
M01_L10:
       mov       r9,[rsp+60]
       lea       rcx,[rax+r9+10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0D0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rsp+120]
       inc       r10d
       cmp       edi,r10d
       jg        near ptr M01_L08
M01_L11:
       lea       rcx,[r13+20]
       mov       rdx,[rsp+50]
       call      CORINFO_HELP_ASSIGN_REF
M01_L12:
       mov       rcx,[r13+18]
       test      rcx,rcx
       jne       near ptr M01_L28
M01_L13:
       mov       edx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rcx,[r12+10]
       xor       eax,eax
       mov       edx,esi
       lea       rdx,[rcx+rdx*4]
       cmp       esi,8
       jl        short M01_L15
       vmovups   ymm0,[7FF923162EE0]
       vbroadcastss ymm1,dword ptr [7FF923162F00]
       lea       rax,[rdx-20]
M01_L14:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rax
       jbe       short M01_L14
       vmovd     eax,xmm0
M01_L15:
       cmp       rcx,rdx
       jb        near ptr M01_L30
M01_L16:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L33
       cmp       qword ptr [r13+18],0
       jne       short M01_L17
       mov       rcx,[r13+10]
       mov       rax,1A4F6002A60
       cmp       rcx,[rax]
       je        near ptr M01_L31
M01_L17:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,r13
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231F8DA8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+78],rax
       mov       r8,[rsp+48]
       lea       rcx,[r8+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsp+48]
       mov       rcx,[rsp+78]
       mov       [r13+18],rcx
M01_L18:
       lea       rcx,[r12+10]
       mov       [rsp+68],rcx
       mov       [rsp+70],esi
       lea       rcx,[rsp+68]
       mov       rdx,r13
       call      qword ptr [7FF922D4E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M01_L19:
       xor       esi,esi
       test      r15d,r15d
       jle       short M01_L21
       cmp       edi,r15d
       jl        short M01_L23
       xor       esi,esi
M01_L20:
       imul      rcx,rsi,14
       add       rcx,r14
       cmp       [rcx],cl
       mov       r13d,[r12+rsi+10]
       cmp       r13d,edi
       jae       near ptr M01_L44
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rsi,4
       dec       r15d
       jne       short M01_L20
M01_L21:
       mov       rax,rbp
M01_L22:
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L23:
       mov       ecx,esi
       imul      rcx,50
       add       rcx,r14
       cmp       [rcx],cl
       cmp       esi,edi
       jae       near ptr M01_L44
       mov       edx,esi
       mov       r13d,[r12+rdx*4+10]
       cmp       r13d,edi
       jae       near ptr M01_L44
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       esi
       cmp       esi,r15d
       jl        short M01_L23
       jmp       short M01_L21
M01_L24:
       mov       rax,rbx
       jmp       short M01_L22
M01_L25:
       mov       rcx,[rsi+68]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M01_L06
M01_L26:
       lea       r8,[rsp+80]
       lea       rdx,[rsp+0D0]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       rax,[rsp+50]
       jmp       near ptr M01_L10
M01_L27:
       lea       rcx,[rax+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L12
M01_L28:
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L13
M01_L29:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L13
M01_L30:
       lea       r8d,[rax+1]
       mov       [rcx],eax
       add       rcx,4
       cmp       rcx,rdx
       mov       eax,r8d
       jb        short M01_L30
       jmp       near ptr M01_L16
M01_L31:
       cmp       byte ptr [r13+28],0
       jne       short M01_L32
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+38],rdx
       mov       rcx,rdx
       mov       rdx,r13
       mov       r8,7FF9231C31B0
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r13,[rsp+38]
       jmp       near ptr M01_L18
M01_L32:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rcx,rax
       mov       rdx,r13
       mov       r8,7FF9231C31C8
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r13,[rsp+40]
       jmp       near ptr M01_L18
M01_L33:
       lea       r9d,[rsi-1]
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L19
M01_L34:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L36:
       mov       rcx,rsi
       mov       r11,7FF922940C98
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L03
M01_L37:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L04
M01_L38:
       mov       rcx,rax
       call      qword ptr [7FF922F9F3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L04
M01_L39:
       mov       rcx,rax
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L04
M01_L40:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923026B08]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L04
M01_L41:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922940CA0
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,1A4F6002AE0
       mov       rbx,[rax]
       jmp       near ptr M01_L04
M01_L43:
       mov       rcx,rbx
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9230ED5C0]
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2031
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       vmovdqu   ymm0,ymmword ptr [r8]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymm0,ymmword ptr [r8+20]
       vmovdqu   ymmword ptr [rdx+20],ymm0
       vmovdqu   xmm0,xmmword ptr [r8+40]
       vmovdqu   xmmword ptr [rdx+40],xmm0
       mov       rax,rdx
       vzeroupper
       ret
; Total bytes of code 38
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M03_L02
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M03_L01
M03_L00:
       add       rsp,28
       ret
M03_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L00
M03_L02:
       add       rsp,28
       jmp       qword ptr [7FF922F9F3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 49
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,1A4F6000A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M04_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M04_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M04_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M04_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L01:
       test      edi,edi
       je        short M04_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M04_L00
M04_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922B6FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```
```assembly
; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+18],rdx
       mov       r8,rdx
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       cmp       eax,1
       jle       short M05_L00
       mov       [rbp-10],rdx
       mov       [rbp-8],eax
       lea       rcx,[rbp-10]
       or        eax,1
       xor       edx,edx
       lzcnt     edx,eax
       xor       edx,1F
       lea       edx,[rdx*2+2]
       call      qword ptr [7FF922D4E340]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].IntroSort(System.Span`1<Int32>, Int32, System.Comparison`1<Int32>)
       nop
M05_L00:
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9232842A0]
       lea       rax,[M05_L00]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       ecx,40
       call      qword ptr [7FF9232842B8]
       lea       rax,[M05_L00]
       add       rsp,28
       ret
; Total bytes of code 133
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
       call      qword ptr [7FF9231CE910]
       int       3
; Total bytes of code 44
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark.OrderByWithoutComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0D8
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,2949D800A48
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L25
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rax,29487800068
       mov       r14,[rax]
       mov       r15,r14
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+8],eax
       lea       rcx,[rbp+60]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L27
       xor       ecx,ecx
       mov       [rbp+68],rcx
       lea       rcx,[rbp+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[rbp+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+90],0
       mov       rcx,2949D800A50
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L26
M00_L01:
       mov       rcx,rbp
       mov       rdx,offset MT_System.Linq.IOrderedEnumerable<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF923209430
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       r8,r14
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r9d,r9d
       call      rax
       mov       rsi,rax
       mov       rdi,rsi
       test      rdi,rdi
       je        short M00_L02
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rdx
       jne       near ptr M00_L07
       xor       edi,edi
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L08
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L37
       mov       rcx,[rdi+60]
       call      qword ptr [7FF9230FD488]; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       rsi,rax
       mov       ebp,[rsi+8]
       cmp       ebp,1
       jle       near ptr M00_L28
       mov       edx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+78]
       mov       rcx,29487800A08
       cmp       r12,[rcx]
       je        near ptr M00_L29
M00_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+58],rax
       mov       rdx,[rdi+70]
       movzx     r8d,byte ptr [rdi+90]
       mov       [rsp+0D4],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+58]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+58]
       mov       ecx,[rsp+0D4]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+68],0
       je        short M00_L05
       mov       rcx,[rdi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L30
       mov       rdx,r12
       call      qword ptr [7FF923207CB8]; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M00_L04:
       mov       rdi,rax
       mov       rax,rdi
M00_L05:
       mov       rdi,rax
       mov       r12d,ebp
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L34
       mov       rax,[rdi+8]
       mov       [rsp+48],rax
       mov       rdx,2949D800A58
       cmp       rax,[rdx]
       je        near ptr M00_L32
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+40],rax
       xor       r10d,r10d
       mov       r9,[rsp+48]
       test      r9,r9
       je        near ptr M00_L13
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rdx
       jne       near ptr M00_L13
M00_L06:
       mov       edx,r10d
       imul      rdx,50
       lea       r9,[rsi+rdx+10]
       mov       r8,[r9+28]
       vmovdqu   ymm0,ymmword ptr [r9]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [r9+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [r9+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       [rsp+0D0],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+0D0]
       inc       r10d
       cmp       ebp,r10d
       jle       near ptr M00_L15
       mov       rax,[rsp+40]
       jmp       short M00_L06
M00_L07:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L08:
       mov       rdi,rsi
       test      rdi,rdi
       je        short M00_L09
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rdx
       jne       near ptr M00_L38
M00_L09:
       test      rdi,rdi
       je        near ptr M00_L46
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L39
       mov       esi,[rdi+8]
M00_L10:
       test      esi,esi
       je        near ptr M00_L45
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       ebp,[rdi+8]
       mov       rcx,[rdi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L43
       cmp       ebp,[rdi+8]
       ja        near ptr M00_L43
       cmp       ebp,[rsi+8]
       ja        near ptr M00_L43
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rdi+10]
       lea       rax,[rsi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L42
       cmp       r8,4000
       ja        near ptr M00_L41
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M00_L40
M00_L11:
       mov       [rsp+70],rsi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+70]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L12:
       mov       rax,[rsp+40]
M00_L13:
       cmp       r10d,ebp
       jae       near ptr M00_L47
       mov       [rsp+0D0],r10d
       mov       edx,r10d
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rdx
       jne       near ptr M00_L31
M00_L14:
       mov       edx,[rsp+0D0]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+0D0]
       inc       ecx
       cmp       ebp,ecx
       mov       r10d,ecx
       mov       r9,[rsp+48]
       jg        near ptr M00_L12
M00_L15:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
M00_L16:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M00_L17
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L33
       mov       rdx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF92320A6C8]; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M00_L17:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+50],rax
       lea       rcx,[rax+10]
       xor       edx,edx
       mov       r8d,r12d
       lea       r8,[rcx+r8*4]
       cmp       r12d,8
       jl        short M00_L19
       vmovups   ymm0,[7FF923174320]
       vbroadcastss ymm1,dword ptr [7FF923174340]
       lea       rdx,[r8-20]
M00_L18:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rdx
       jbe       short M00_L18
       vmovd     edx,xmm0
M00_L19:
       cmp       rcx,r8
       jb        near ptr M00_L35
M00_L20:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L36
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       mov       rcx,rdi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF923209FB8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+78],rax
       mov       r8,[rsp+38]
       lea       rcx,[r8+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rsp+38]
       mov       rcx,[rsp+78]
       mov       [rdi+18],rcx
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       [rsp+60],rcx
       mov       [rsp+68],r12d
       lea       rcx,[rsp+60]
       mov       rdx,rdi
       call      qword ptr [7FF922D5E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M00_L21:
       mov       rdi,[rsp+50]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L23
       cmp       ebp,r13d
       jl        short M00_L24
       xor       r12d,r12d
M00_L22:
       imul      rcx,r12,14
       add       rcx,r15
       cmp       [rcx],cl
       mov       eax,[rdi+r12+10]
       cmp       eax,ebp
       jae       near ptr M00_L47
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,4
       dec       r13d
       jne       short M00_L22
M00_L23:
       mov       rsi,r14
       jmp       near ptr M00_L11
M00_L24:
       mov       ecx,r12d
       imul      rcx,50
       add       rcx,r15
       cmp       [rcx],cl
       cmp       r12d,ebp
       jae       near ptr M00_L47
       mov       edx,r12d
       mov       eax,[rdi+rdx*4+10]
       cmp       eax,ebp
       jae       near ptr M00_L47
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L24
       jmp       short M00_L23
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2949D800A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2949D800A48
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2949D800A38
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2949D800A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L27:
       mov       ecx,11
       call      qword ptr [7FF922C27E58]
       int       3
M00_L28:
       mov       r14,rsi
       jmp       near ptr M00_L23
M00_L29:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FF922C25DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF922D5DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M00_L03
M00_L30:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L04
M00_L31:
       mov       [rsp+0A8],r8
       lea       rdx,[rsp+80]
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+40]
       jmp       near ptr M00_L14
M00_L32:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L16
M00_L33:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L17
M00_L34:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L17
M00_L35:
       lea       r10d,[rdx+1]
       mov       [rcx],edx
       add       rcx,4
       cmp       rcx,r8
       mov       edx,r10d
       jb        short M00_L35
       jmp       near ptr M00_L20
M00_L36:
       mov       rax,[rsp+50]
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       jmp       near ptr M00_L21
M00_L37:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M00_L23
M00_L38:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M00_L09
M00_L39:
       mov       rcx,rdi
       mov       r11,7FF922950C18
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L10
M00_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L11
M00_L41:
       mov       rcx,rax
       call      qword ptr [7FF922FAF3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L11
M00_L42:
       mov       rcx,rax
       call      qword ptr [7FF922A05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L11
M00_L43:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923036B38]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L11
M00_L44:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF922950C20
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L45:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2949D800AF0
       mov       rsi,[rcx]
       jmp       near ptr M00_L11
M00_L46:
       mov       rcx,rsi
       call      qword ptr [7FF9230FD5C0]
       mov       rsi,rax
       jmp       near ptr M00_L11
M00_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2252
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,29487800A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M01_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M01_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L01:
       test      edi,edi
       je        short M01_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M01_L00
M01_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922B7FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```
```assembly
; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M02_L00:
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
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       mov       rbx,rcx
       mov       rsi,rbx
       test      rsi,rsi
       je        short M02_L01
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rdx
       je        short M02_L01
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
M02_L01:
       test      rsi,rsi
       je        near ptr M02_L16
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M02_L31
       mov       rcx,[rsi+60]
       call      qword ptr [7FF9230FD488]
       mov       rbx,rax
       mov       edi,[rbx+8]
       cmp       edi,1
       jle       near ptr M02_L22
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,[rsi+78]
       mov       rcx,29487800A08
       cmp       r13,[rcx]
       je        near ptr M02_L23
M02_L02:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,[rsi+70]
       movzx     eax,byte ptr [rsi+90]
       mov       [rsp+0B4],eax
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rsp+0B4]
       mov       [r12+28],r13b
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       r13,r12
       cmp       qword ptr [rsi+68],0
       je        short M02_L03
       mov       rcx,[rsi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M02_L24
       mov       rdx,r12
       call      qword ptr [7FF923207CB8]; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       r13,rax
M02_L03:
       mov       esi,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [r13],rdx
       jne       near ptr M02_L28
       mov       r12,r13
       mov       rax,[r12+8]
       mov       [rsp+40],rax
       mov       rdx,2949D800A58
       cmp       rax,[rdx]
       je        near ptr M02_L26
       mov       edx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       xor       eax,eax
       mov       r10,[rsp+40]
       test      r10,r10
       je        near ptr M02_L20
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r10+18],rdx
       jne       near ptr M02_L20
M02_L04:
       mov       edx,eax
       imul      rdx,50
       lea       r10,[rbx+rdx+10]
       mov       r8,[r10+28]
       vmovdqu   ymm0,ymmword ptr [r10]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [r10+20]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   xmm0,xmmword ptr [r10+40]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       [rsp+0B0],eax
       movsxd    rdx,eax
       mov       rcx,r12
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       eax,[rsp+0B0]
       inc       eax
       cmp       edi,eax
       jg        short M02_L04
M02_L05:
       lea       rcx,[r13+20]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M02_L06:
       mov       rcx,[r13+18]
       test      rcx,rcx
       je        short M02_L07
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M02_L27
       mov       rdx,rbx
       mov       r8d,esi
       call      qword ptr [7FF92320A6C8]; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M02_L07:
       mov       edx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rcx,[r12+10]
       xor       eax,eax
       mov       edx,esi
       lea       rdx,[rcx+rdx*4]
       cmp       esi,8
       jl        short M02_L09
       vmovups   ymm0,[7FF9231734C0]
       vbroadcastss ymm1,dword ptr [7FF9231734E0]
       lea       rax,[rdx-20]
       nop       word ptr [rax+rax]
M02_L08:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rax
       jbe       short M02_L08
       vmovd     eax,xmm0
M02_L09:
       cmp       rcx,rdx
       jb        near ptr M02_L29
M02_L10:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [r13],rcx
       jne       near ptr M02_L30
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       mov       rcx,r13
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF923209FB8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+58],rax
       mov       r8,[rsp+38]
       lea       rcx,[r8+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsp+38]
       mov       rcx,[rsp+58]
       mov       [r13+18],rcx
       lea       rcx,[r12+10]
       mov       [rsp+48],rcx
       mov       [rsp+50],esi
       lea       rcx,[rsp+48]
       mov       rdx,r13
       call      qword ptr [7FF922D5E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M02_L11:
       xor       esi,esi
       test      r15d,r15d
       jle       short M02_L13
       cmp       edi,r15d
       jl        short M02_L15
       xor       esi,esi
M02_L12:
       imul      rcx,rsi,14
       add       rcx,r14
       cmp       [rcx],cl
       mov       r13d,[r12+rsi+10]
       cmp       r13d,edi
       jae       near ptr M02_L41
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rsi,4
       dec       r15d
       jne       short M02_L12
M02_L13:
       mov       rax,rbp
M02_L14:
       vzeroupper
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
M02_L15:
       mov       ecx,esi
       imul      rcx,50
       add       rcx,r14
       cmp       [rcx],cl
       cmp       esi,edi
       jae       near ptr M02_L41
       mov       edx,esi
       mov       r13d,[r12+rdx*4+10]
       cmp       r13d,edi
       jae       near ptr M02_L41
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       esi
       cmp       esi,r15d
       jl        short M02_L15
       jmp       short M02_L13
M02_L16:
       mov       rsi,rbx
       test      rsi,rsi
       je        short M02_L17
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M02_L32
M02_L17:
       test      rsi,rsi
       je        near ptr M02_L40
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M02_L33
       mov       ebx,[rsi+8]
M02_L18:
       test      ebx,ebx
       je        near ptr M02_L39
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M02_L38
       mov       edi,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M02_L37
       cmp       edi,[rsi+8]
       ja        near ptr M02_L37
       cmp       edi,[rbx+8]
       ja        near ptr M02_L37
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M02_L36
       cmp       r8,4000
       ja        near ptr M02_L35
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M02_L34
M02_L19:
       mov       rax,rbx
       vzeroupper
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
M02_L20:
       cmp       eax,edi
       jae       near ptr M02_L41
       mov       [rsp+0B0],eax
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r10+18],rdx
       jne       near ptr M02_L25
M02_L21:
       mov       edx,[rsp+0B0]
       mov       rcx,r12
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+0B0]
       inc       ecx
       cmp       edi,ecx
       mov       eax,ecx
       mov       r10,[rsp+40]
       jg        short M02_L20
       jmp       near ptr M02_L05
M02_L22:
       mov       rax,rbx
       jmp       near ptr M02_L14
M02_L23:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF922C25DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FF922D5DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M02_L02
M02_L24:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M02_L03
M02_L25:
       mov       [rsp+88],r8
       lea       rdx,[rsp+60]
       mov       rcx,[r10+8]
       call      qword ptr [r10+18]
       mov       r8,rax
       jmp       near ptr M02_L21
M02_L26:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[r12+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L06
M02_L27:
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M02_L07
M02_L28:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M02_L07
M02_L29:
       lea       r8d,[rax+1]
       mov       [rcx],eax
       add       rcx,4
       cmp       rcx,rdx
       mov       eax,r8d
       jb        short M02_L29
       jmp       near ptr M02_L10
M02_L30:
       lea       r9d,[rsi-1]
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M02_L11
M02_L31:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M02_L32:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M02_L17
M02_L33:
       mov       rcx,rsi
       mov       r11,7FF922950C08
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M02_L18
M02_L34:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L19
M02_L35:
       mov       rcx,rax
       call      qword ptr [7FF922FAF3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L19
M02_L36:
       mov       rcx,rax
       call      qword ptr [7FF922A05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L19
M02_L37:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923036B38]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M02_L19
M02_L38:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922950C10
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M02_L19
M02_L39:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,2949D800AF0
       mov       rbx,[rax]
       jmp       near ptr M02_L19
M02_L40:
       mov       rcx,rbx
       vzeroupper
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9230FD5C0]
M02_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1834
```
```assembly
; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M03_L00:
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rbx+78]
       mov       rbp,[rbx]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.String
       cmp       [rcx+8],rax
       jne       short M03_L01
       mov       rcx,29487800A08
       cmp       rdi,[rcx]
       je        near ptr M03_L07
M03_L01:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M03_L06
M03_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+70]
       movzx     r14d,byte ptr [rbx+90]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+28],r14b
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbp
       mov       rsi,[rbx+68]
       test      rsi,rsi
       je        near ptr M03_L05
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M03_L12
       mov       rdi,[rsi+78]
       mov       rcx,29487800A08
       cmp       rdi,[rcx]
       je        near ptr M03_L10
M03_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,[rsi+70]
       movzx     r15d,byte ptr [rsi+90]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+28],r15b
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
       cmp       qword ptr [rsi+68],0
       je        short M03_L04
       mov       rcx,[rsi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M03_L11
       mov       rdx,r14
       call      qword ptr [7FF923207CB8]
       mov       rbp,rax
M03_L04:
       mov       rax,rbp
M03_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L06:
       mov       rcx,rbp
       mov       rdx,7FF9231E9B40
       call      qword ptr [7FF922A0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L02
M03_L07:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF922C25DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF922D5DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rbp
       mov       rdx,7FF9231E9B58
       call      qword ptr [7FF922A0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L09:
       mov       rdx,rdi
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M03_L01
M03_L10:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF922C25DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF922D5DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M03_L03
M03_L11:
       mov       rdx,r14
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M03_L04
M03_L12:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M03_L04
; Total bytes of code 576
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       rax,[rdx+28]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M05_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M05_L02
       cmp       rdx,[r8]
       jne       short M05_L03
M05_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M05_L01:
       call      qword ptr [7FF9231DD218]
       int       3
M05_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M05_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M05_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF922A0D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M06_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M06_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
M06_L00:
       test      rax,rax
       je        short M06_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       test      rax,rax
       je        short M06_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       test      rax,rax
       jne       short M06_L03
M06_L01:
       xor       edx,edx
M06_L02:
       mov       rax,rdx
       ret
M06_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       test      rax,rax
       je        short M06_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       jmp       short M06_L00
; Total bytes of code 86
```
```assembly
; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M07_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,80
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       mov       [rsp+70],rax
       mov       [rsp+78],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rbp,[rsi+8]
       mov       rcx,2949D800A58
       cmp       rbp,[rcx]
       je        near ptr M07_L10
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M07_L06
       mov       rcx,rax
M07_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M07_L03
       test      rbx,rbx
       je        near ptr M07_L07
       test      rbp,rbp
       je        near ptr M07_L07
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [rbp+18],rdx
       jne       near ptr M07_L07
       cmp       [rbx+8],r13d
       jl        near ptr M07_L07
M07_L02:
       mov       edx,r15d
       imul      rdx,50
       lea       rbp,[rbx+rdx+10]
       mov       r8,[rbp+28]
       vmovdqu   ymm0,ymmword ptr [rbp]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovdqu   ymm0,ymmword ptr [rbp+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   xmm0,xmmword ptr [rbp+40]
       vmovdqu   xmmword ptr [rsp+68],xmm0
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M07_L02
M07_L03:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L04:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        short M07_L05
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M07_L13
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FF92320A6C8]
M07_L05:
       nop
       vzeroupper
       add       rsp,80
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L06:
       mov       rdx,7FF9231E9EA0
       call      qword ptr [7FF922A0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M07_L01
M07_L07:
       cmp       r15d,[rbx+8]
       jae       near ptr M07_L14
       mov       edx,r15d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+68],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [rbp+18],rdx
       jne       short M07_L09
M07_L08:
       mov       edx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M07_L07
       jmp       near ptr M07_L03
M07_L09:
       mov       [rsp+50],r8
       lea       rdx,[rsp+28]
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
       mov       r8,rax
       jmp       short M07_L08
M07_L10:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L11
       jmp       short M07_L12
M07_L11:
       mov       rdx,7FF9231E9EA0
       call      qword ptr [7FF922A0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M07_L12:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M07_L04
M07_L13:
       mov       rdx,rbx
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M07_L05
M07_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 563
```
```assembly
; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+18],rdx
       mov       r8,rdx
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       cmp       eax,1
       jle       short M08_L00
       mov       [rbp-10],rdx
       mov       [rbp-8],eax
       lea       rcx,[rbp-10]
       or        eax,1
       xor       edx,edx
       lzcnt     edx,eax
       xor       edx,1F
       lea       edx,[rdx*2+2]
       call      qword ptr [7FF922D5E340]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].IntroSort(System.Span`1<Int32>, Int32, System.Comparison`1<Int32>)
       nop
M08_L00:
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       rcx,[rbp+18]
       call      qword ptr [7FF923294360]
       lea       rax,[M08_L00]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       ecx,40
       call      qword ptr [7FF923294378]
       lea       rax,[M08_L00]
       add       rsp,28
       ret
; Total bytes of code 133
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M09_L02
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M09_L01
M09_L00:
       add       rsp,28
       ret
M09_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L00
M09_L02:
       add       rsp,28
       jmp       qword ptr [7FF922FAF3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 49
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       rax,[rdx+20]
       ret
; Total bytes of code 5
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M11_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L00:
       call      qword ptr [7FF9231DE9D0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       push      rbx
       sub       rsp,20
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       short M12_L03
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M12_L03
M12_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       je        short M12_L02
M12_L01:
       mov       rcx,7FF92324B3B0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M12_L02:
       mov       rcx,29487800110
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M12_L05
       mov       rcx,294878000F0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M12_L04
       mov       rcx,7FF92324B3B8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M12_L01
M12_L03:
       mov       ecx,2
       call      qword ptr [7FF9231DE5C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M12_L00
M12_L04:
       mov       rcx,7FF92324B3B4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF92324B3B0
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF922C25E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
M12_L05:
       mov       rcx,7FF92324B3BC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L01
; Total bytes of code 204
```
```assembly
; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r8d
       lea       rcx,[rbx+8]
       call      qword ptr [7FF982458FE8]; CORINFO_HELP_ASSIGN_REF
       test      esi,0DFFFFFC0
       jne       short M13_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M13_L00:
       call      qword ptr [7FF982463550]
       mov       rbx,rax
       call      qword ptr [7FF98246E1A8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 87
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M14_L05
       mov       rcx,[rbx]
       cmp       rcx,rsi
       je        near ptr M14_L04
       mov       rax,29487800038
       mov       rax,[rax]
       add       rax,10
       rorx      rdx,rcx,20
       xor       rdx,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rdx,r8
       mov       r8d,[rax]
       shrx      rdx,rdx,r8
       xor       r8d,r8d
M14_L00:
       lea       r10d,[rdx+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rax+r10*8]
       mov       r9d,[r10]
       and       r9d,0FFFFFFFE
       cmp       [r10+8],rcx
       jne       short M14_L01
       mov       r11,rsi
       xor       r11,[r10+10]
       cmp       r11,1
       jbe       short M14_L03
M14_L01:
       test      r9d,r9d
       je        short M14_L02
       inc       r8d
       add       edx,r8d
       and       edx,[rax+4]
       cmp       r8d,8
       jl        short M14_L00
M14_L02:
       mov       rcx,7FF92324C9A4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF922A06340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M14_L03:
       cmp       r9d,[r10]
       jne       short M14_L02
       cmp       r11d,1
       jne       short M14_L02
       mov       rcx,7FF92324C998
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M14_L05
M14_L04:
       mov       rcx,7FF92324C9A0
       call      CORINFO_HELP_COUNTPROFILE32
M14_L05:
       mov       rcx,7FF92324C99C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 246
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M15_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M15_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M15_L01
       cmp       [r10],rcx
       je        short M15_L06
M15_L00:
       cmp       [r10+8],rcx
       je        short M15_L06
       cmp       [r10+10],rcx
       je        short M15_L06
       cmp       [r10+18],rcx
       je        short M15_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M15_L04
       test      r8,r8
       je        short M15_L03
M15_L01:
       cmp       [r10],rcx
       je        short M15_L06
M15_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M15_L03
       cmp       [r10],rcx
       je        short M15_L06
       jmp       short M15_L02
M15_L03:
       test      dword ptr [rax],500C0000
       je        short M15_L05
       jmp       qword ptr [7FF922D5F5B8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M15_L04:
       cmp       [r10],rcx
       je        short M15_L06
       jmp       short M15_L00
M15_L05:
       xor       edx,edx
M15_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M16_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M16_L06
M16_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FF9826037E0
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FF982943A90],0
       jne       short M16_L04
M16_L01:
       cmp       rdi,4000
       ja        short M16_L00
M16_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M16_L05
M16_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M16_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M16_L01
M16_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M16_L03
M16_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       je        short M16_L07
       call      CORINFO_HELP_POLL_GC
M16_L07:
       cmp       rdi,4000
       ja        short M16_L06
       jmp       short M16_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M17_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M17_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M17_L02
       test      r8b,18
       jne       short M17_L01
       test      r8b,4
       je        short M17_L00
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M17_L05
M17_L00:
       test      r8,r8
       je        short M17_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M17_L05
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M17_L05
M17_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M17_L05
M17_L02:
       cmp       r8,40
       ja        short M17_L06
M17_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M17_L09
M17_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M17_L05:
       vzeroupper
       ret
M17_L06:
       cmp       r8,800
       ja        near ptr M17_L12
       cmp       r8,100
       jae       short M17_L10
M17_L07:
       mov       r9,r8
       shr       r9,6
M17_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M17_L08
       and       r8,3F
       cmp       r8,10
       ja        short M17_L03
       jmp       short M17_L04
M17_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M17_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M17_L04
M17_L10:
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
       jmp       short M17_L07
M17_L11:
       cmp       rcx,rdx
       jne       short M17_L12
       cmp       [rdx],dl
       jmp       near ptr M17_L05
M17_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF922A066E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 318
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M18_L09
       test      rsi,rsi
       je        near ptr M18_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M18_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M18_L10
M18_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M18_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M18_L07
       sub       edi,eax
       js        near ptr M18_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M18_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M18_L06
       sub       ebp,eax
       js        near ptr M18_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M18_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M18_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98246A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M18_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M18_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M18_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M18_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246D930]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M18_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M18_L15
M18_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M18_L04:
       cmp       r8,4000
       jbe       short M18_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M18_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M18_L02
       jmp       near ptr M18_L14
M18_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M18_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M18_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M18_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M18_L10:
       call      qword ptr [7FF982463788]
       mov       rbx,rax
       call      qword ptr [7FF98246ED60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246D7C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M18_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF982481910]
       int       3
M18_L12:
       call      qword ptr [7FF982463550]
       mov       rdi,rax
       call      qword ptr [7FF98246DC18]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rdi
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M18_L13:
       call      qword ptr [7FF982463550]
       mov       rbp,rax
       call      qword ptr [7FF98246DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rbp
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M18_L14:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M18_L02
M18_L15:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M18_L03
M18_L16:
       call      qword ptr [7FF982463578]
       mov       rbx,rax
       call      qword ptr [7FF98246E6E0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246C240]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M19_L00
       ret
M19_L00:
       jmp       qword ptr [7FF922A05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark.OrderByWithComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,138
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       vmovdqa   xmmword ptr [rsp+rax+140],xmm4
       vmovdqa   xmmword ptr [rsp+rax+150],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,2834E802A38
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L22
M00_L01:
       mov       rbp,[rbx+2E8]
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+8],eax
       lea       rcx,[r14+60]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L23
       xor       ecx,ecx
       mov       [r14+68],rcx
       lea       rcx,[r14+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       mov       rcx,2834E802A60
       test      rdx,rdx
       cmove     rdx,[rcx]
       lea       rcx,[r14+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],0
       mov       rcx,[r14+60]
       call      qword ptr [7FF9230ED428]; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L24
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r15,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r14+78]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[r14+70]
       movzx     r8d,byte ptr [r14+90]
       mov       [rsp+134],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+134]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r14+68],0
       jne       near ptr M00_L25
M00_L02:
       mov       r14,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r14],rdx
       jne       near ptr M00_L27
       mov       rax,[r14+8]
       mov       [rsp+40],rax
       mov       rdx,2834E802A50
       cmp       rax,[rdx]
       je        near ptr M00_L18
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        near ptr M00_L05
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L05
       mov       r10d,10
       mov       [rsp+5C],edi
M00_L03:
       vmovdqu   ymm0,ymmword ptr [rsi+r10]
       vmovdqu   ymmword ptr [rsp+90],ymm0
       vmovdqu   ymm0,ymmword ptr [rsi+r10+20]
       vmovdqu   ymmword ptr [rsp+0B0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsi+r10+40]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+90]
       vmovdqu   ymmword ptr [rsp+0E0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0B0]
       vmovdqu   ymmword ptr [rsp+100],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+120],xmm0
       mov       [rsp+60],r10
       lea       rcx,[rax+r10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0E0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10,[rsp+60]
       add       r10,50
       mov       r9d,[rsp+5C]
       dec       r9d
       mov       [rsp+5C],r9d
       je        near ptr M00_L07
       mov       rax,[rsp+38]
       jmp       near ptr M00_L03
M00_L04:
       mov       rax,[rsp+38]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L31
       mov       [rsp+130],r10d
       mov       r8d,r10d
       imul      r11,r8,50
       mov       [rsp+68],r11
       vmovdqu   ymm0,ymmword ptr [rsi+r11+10]
       vmovdqu   ymmword ptr [rsp+90],ymm0
       vmovdqu   ymm0,ymmword ptr [rsi+r11+30]
       vmovdqu   ymmword ptr [rsp+0B0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsi+r11+50]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],r8
       jne       near ptr M00_L26
       vmovdqu   ymm0,ymmword ptr [rsp+90]
       vmovdqu   ymmword ptr [rsp+0E0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0B0]
       vmovdqu   ymmword ptr [rsp+100],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+120],xmm0
M00_L06:
       mov       r11,[rsp+68]
       lea       rcx,[rax+r11+10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0E0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rsp+130]
       inc       r10d
       cmp       edi,r10d
       mov       r9,[rsp+40]
       jg        near ptr M00_L04
M00_L07:
       lea       rcx,[r14+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[r14+18]
       test      rcx,rcx
       jne       near ptr M00_L19
M00_L09:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       rcx,[rax+10]
       xor       edx,edx
       mov       r8d,r12d
       lea       r8,[rcx+r8*4]
       cmp       r12d,8
       jl        short M00_L11
       vmovups   ymm0,[7FF923161300]
       vbroadcastss ymm1,dword ptr [7FF923161320]
       lea       rdx,[r8-20]
M00_L10:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rdx
       jbe       short M00_L10
       vmovd     edx,xmm0
M00_L11:
       cmp       rcx,r8
       jb        near ptr M00_L20
M00_L12:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L30
       cmp       qword ptr [r14+18],0
       jne       short M00_L13
       mov       rcx,[r14+10]
       mov       rdx,2834E802A60
       cmp       rcx,[rdx]
       je        near ptr M00_L28
M00_L13:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       rcx,r14
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231F9458
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+88],rax
       mov       r8,[rsp+30]
       lea       rcx,[r8+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rsp+30]
       mov       rcx,[rsp+88]
       mov       [r14+18],rcx
M00_L14:
       mov       rax,[rsp+48]
       lea       rcx,[rax+10]
       mov       [rsp+70],rcx
       mov       [rsp+78],r12d
       lea       rcx,[rsp+70]
       mov       rdx,r14
       call      qword ptr [7FF922D4E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M00_L15:
       mov       r14,[rsp+48]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L17
       cmp       edi,r13d
       jl        near ptr M00_L21
       xor       r12d,r12d
M00_L16:
       imul      rcx,r12,14
       add       rcx,r15
       cmp       [rcx],cl
       mov       eax,[r14+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L31
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,4
       dec       r13d
       jne       short M00_L16
M00_L17:
       mov       [rsp+80],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+80]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
       add       rsp,138
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L18:
       lea       rcx,[r14+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L19:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L20:
       lea       r10d,[rdx+1]
       mov       [rcx],edx
       add       rcx,4
       cmp       rcx,r8
       mov       edx,r10d
       jb        short M00_L20
       jmp       near ptr M00_L12
M00_L21:
       mov       ecx,r12d
       imul      rcx,50
       add       rcx,r15
       cmp       [rcx],cl
       cmp       r12d,edi
       jae       near ptr M00_L31
       mov       edx,r12d
       mov       eax,[r14+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L31
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L21
       jmp       near ptr M00_L17
M00_L22:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2834E802A30
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2834E802A38
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L23:
       mov       ecx,11
       call      qword ptr [7FF922C17E58]
       int       3
M00_L24:
       mov       rbp,rsi
       jmp       near ptr M00_L17
M00_L25:
       mov       rcx,[r14+68]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r14,rax
       mov       rax,r14
       jmp       near ptr M00_L02
M00_L26:
       lea       r8,[rsp+90]
       lea       rdx,[rsp+0E0]
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       rax,[rsp+38]
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L28:
       cmp       byte ptr [r14+28],0
       jne       short M00_L29
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+20],rdx
       mov       rcx,rdx
       mov       rdx,r14
       mov       r8,7FF9231C3240
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r14,[rsp+20]
       jmp       near ptr M00_L14
M00_L29:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,7FF9231C3258
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r14,[rsp+28]
       jmp       near ptr M00_L14
M00_L30:
       mov       rax,[rsp+48]
       lea       r9d,[r12-1]
       mov       rcx,r14
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r14]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       jmp       near ptr M00_L15
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1787
```
```assembly
; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M01_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,128
       xor       eax,eax
       mov       [rsp+68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       vmovdqu   ymmword ptr [rsp+0B0],ymm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       vmovdqu   ymmword ptr [rsp+0F0],ymm4
       vmovdqa   xmmword ptr [rsp+110],xmm4
       mov       rbx,rcx
       mov       rsi,rbx
       test      rsi,rsi
       je        short M01_L01
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [rsi],rdx
       je        short M01_L01
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
M01_L01:
       test      rsi,rsi
       je        near ptr M01_L04
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M01_L34
       mov       rcx,[rsi+60]
       call      qword ptr [7FF9230ED428]
       mov       rbx,rax
       mov       edi,[rbx+8]
       cmp       edi,1
       jle       near ptr M01_L27
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,[rsi+78]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,[rsi+70]
       movzx     eax,byte ptr [rsi+90]
       mov       [rsp+124],eax
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rsp+124]
       mov       [r12+28],r13b
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       r13,r12
       cmp       qword ptr [rsi+68],0
       jne       near ptr M01_L28
M01_L02:
       mov       esi,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r13],rdx
       jne       near ptr M01_L30
       mov       rax,r13
       mov       r12,[rax+8]
       mov       rdx,2834E802A50
       cmp       r12,[rdx]
       je        near ptr M01_L23
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+50],rax
       xor       r10d,r10d
       test      r12,r12
       je        near ptr M01_L09
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],rcx
       jne       near ptr M01_L09
       mov       r12d,10
       mov       [rsp+5C],edi
M01_L03:
       vmovdqu   ymm0,ymmword ptr [rbx+r12]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rbx+r12+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rbx+r12+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+80]
       vmovdqu   ymmword ptr [rsp+0D0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A0]
       vmovdqu   ymmword ptr [rsp+0F0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+110],xmm0
       lea       rcx,[rax+r12]
       cmp       [rcx],cl
       lea       rdx,[rsp+0D0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,50
       mov       r10d,[rsp+5C]
       dec       r10d
       mov       [rsp+5C],r10d
       je        near ptr M01_L11
       mov       rax,[rsp+50]
       jmp       near ptr M01_L03
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M01_L04:
       mov       rsi,rbx
       test      rsi,rsi
       je        short M01_L05
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M01_L35
M01_L05:
       test      rsi,rsi
       je        near ptr M01_L43
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L36
       mov       ebx,[rsi+8]
M01_L06:
       test      ebx,ebx
       je        near ptr M01_L42
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L41
       mov       edi,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L40
       cmp       edi,[rsi+8]
       ja        near ptr M01_L40
       cmp       edi,[rbx+8]
       ja        near ptr M01_L40
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L39
       cmp       r8,4000
       ja        near ptr M01_L38
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L37
M01_L07:
       mov       rax,rbx
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L08:
       mov       rax,[rsp+50]
M01_L09:
       cmp       r10d,edi
       jae       near ptr M01_L44
       mov       [rsp+120],r10d
       mov       r8d,r10d
       imul      r9,r8,50
       mov       [rsp+60],r9
       vmovdqu   ymm0,ymmword ptr [rbx+r9+10]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rbx+r9+30]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rbx+r9+50]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],r8
       jne       near ptr M01_L29
       vmovdqu   ymm0,ymmword ptr [rsp+80]
       vmovdqu   ymmword ptr [rsp+0D0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A0]
       vmovdqu   ymmword ptr [rsp+0F0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+110],xmm0
M01_L10:
       mov       r9,[rsp+60]
       lea       rcx,[rax+r9+10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0D0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rsp+120]
       inc       r10d
       cmp       edi,r10d
       jg        near ptr M01_L08
M01_L11:
       lea       rcx,[r13+20]
       mov       rdx,[rsp+50]
       call      CORINFO_HELP_ASSIGN_REF
M01_L12:
       mov       rcx,[r13+18]
       test      rcx,rcx
       jne       near ptr M01_L24
M01_L13:
       mov       edx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rcx,[r12+10]
       xor       eax,eax
       mov       edx,esi
       lea       rdx,[rcx+rdx*4]
       cmp       esi,8
       jl        short M01_L15
       vmovups   ymm0,[7FF923160900]
       vbroadcastss ymm1,dword ptr [7FF923160920]
       lea       rax,[rdx-20]
M01_L14:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rax
       jbe       short M01_L14
       vmovd     eax,xmm0
M01_L15:
       cmp       rcx,rdx
       jb        near ptr M01_L25
M01_L16:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L33
       cmp       qword ptr [r13+18],0
       jne       short M01_L17
       mov       rcx,[r13+10]
       mov       rax,2834E802A60
       cmp       rcx,[rax]
       je        near ptr M01_L31
M01_L17:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,r13
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231F9458
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+78],rax
       mov       r8,[rsp+48]
       lea       rcx,[r8+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsp+48]
       mov       rcx,[rsp+78]
       mov       [r13+18],rcx
M01_L18:
       lea       rcx,[r12+10]
       mov       [rsp+68],rcx
       mov       [rsp+70],esi
       lea       rcx,[rsp+68]
       mov       rdx,r13
       call      qword ptr [7FF922D4E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M01_L19:
       xor       esi,esi
       test      r15d,r15d
       jle       short M01_L21
       cmp       edi,r15d
       jl        near ptr M01_L26
       xor       esi,esi
M01_L20:
       imul      rcx,rsi,14
       add       rcx,r14
       cmp       [rcx],cl
       mov       r13d,[r12+rsi+10]
       cmp       r13d,edi
       jae       near ptr M01_L44
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rsi,4
       dec       r15d
       jne       short M01_L20
M01_L21:
       mov       rax,rbp
M01_L22:
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L23:
       lea       rcx,[rax+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L12
M01_L24:
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L13
M01_L25:
       lea       r8d,[rax+1]
       mov       [rcx],eax
       add       rcx,4
       cmp       rcx,rdx
       mov       eax,r8d
       jb        short M01_L25
       jmp       near ptr M01_L16
M01_L26:
       mov       ecx,esi
       imul      rcx,50
       add       rcx,r14
       cmp       [rcx],cl
       cmp       esi,edi
       jae       near ptr M01_L44
       mov       edx,esi
       mov       r13d,[r12+rdx*4+10]
       cmp       r13d,edi
       jae       near ptr M01_L44
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       esi
       cmp       esi,r15d
       jl        short M01_L26
       jmp       near ptr M01_L21
M01_L27:
       mov       rax,rbx
       jmp       near ptr M01_L22
M01_L28:
       mov       rcx,[rsi+68]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M01_L02
M01_L29:
       lea       r8,[rsp+80]
       lea       rdx,[rsp+0D0]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       rax,[rsp+50]
       jmp       near ptr M01_L10
M01_L30:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L13
M01_L31:
       cmp       byte ptr [r13+28],0
       jne       short M01_L32
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+38],rdx
       mov       rcx,rdx
       mov       rdx,r13
       mov       r8,7FF9231C3240
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r13,[rsp+38]
       jmp       near ptr M01_L18
M01_L32:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rcx,rax
       mov       rdx,r13
       mov       r8,7FF9231C3258
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r13,[rsp+40]
       jmp       near ptr M01_L18
M01_L33:
       lea       r9d,[rsi-1]
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L19
M01_L34:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L36:
       mov       rcx,rsi
       mov       r11,7FF922940CA0
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L06
M01_L37:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L07
M01_L38:
       mov       rcx,rax
       call      qword ptr [7FF922F9EF28]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L07
M01_L39:
       mov       rcx,rax
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L07
M01_L40:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923026AD8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L07
M01_L41:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922940CA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L07
M01_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,2834E802AE0
       mov       rbx,[rax]
       jmp       near ptr M01_L07
M01_L43:
       mov       rcx,rbx
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9230ED560]
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2041
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       vmovdqu   ymm0,ymmword ptr [r8]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymm0,ymmword ptr [r8+20]
       vmovdqu   ymmword ptr [rdx+20],ymm0
       vmovdqu   xmm0,xmmword ptr [r8+40]
       vmovdqu   xmmword ptr [rdx+40],xmm0
       mov       rax,rdx
       vzeroupper
       ret
; Total bytes of code 38
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M03_L02
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M03_L01
M03_L00:
       add       rsp,28
       ret
M03_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L00
M03_L02:
       add       rsp,28
       jmp       qword ptr [7FF922F9EF28]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 49
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,2834E800A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M04_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M04_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M04_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M04_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L01:
       test      edi,edi
       je        short M04_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M04_L00
M04_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922B6FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```
```assembly
; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+18],rdx
       mov       r8,rdx
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       cmp       eax,1
       jle       short M05_L00
       mov       [rbp-10],rdx
       mov       [rbp-8],eax
       lea       rcx,[rbp-10]
       or        eax,1
       xor       edx,edx
       lzcnt     edx,eax
       xor       edx,1F
       lea       edx,[rdx*2+2]
       call      qword ptr [7FF922D4E340]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].IntroSort(System.Span`1<Int32>, Int32, System.Comparison`1<Int32>)
       nop
M05_L00:
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9231CFE10]
       lea       rax,[M05_L00]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       ecx,40
       call      qword ptr [7FF9231CFE28]
       lea       rax,[M05_L00]
       add       rsp,28
       ret
; Total bytes of code 133
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
       call      qword ptr [7FF9231CE490]
       int       3
; Total bytes of code 44
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark.OrderByWithoutComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0D8
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,2C5D6800A48
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L26
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rax,2C5C0800068
       mov       r14,[rax]
       mov       r15,r14
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+8],eax
       lea       rcx,[rbp+60]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L28
       xor       ecx,ecx
       mov       [rbp+68],rcx
       lea       rcx,[rbp+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[rbp+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+90],0
       mov       rcx,2C5D6800A50
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L27
M00_L01:
       mov       rcx,rbp
       mov       rdx,offset MT_System.Linq.IOrderedEnumerable<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231F9420
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       r8,r14
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r9d,r9d
       call      rax
       mov       rsi,rax
       mov       rdi,rsi
       test      rdi,rdi
       je        short M00_L02
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rdx
       jne       near ptr M00_L07
       xor       edi,edi
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L08
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L36
       mov       rcx,[rdi+60]
       call      qword ptr [7FF9230ED470]; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       rsi,rax
       mov       ebp,[rsi+8]
       cmp       ebp,1
       jle       near ptr M00_L29
       mov       edx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+78]
       mov       rcx,2C5C0800A08
       cmp       r12,[rcx]
       je        near ptr M00_L30
M00_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+58],rax
       mov       rdx,[rdi+70]
       movzx     r8d,byte ptr [rdi+90]
       mov       [rsp+0D4],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+58]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+58]
       mov       ecx,[rsp+0D4]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+68],0
       je        short M00_L05
       mov       rcx,[rdi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L31
       mov       rdx,r12
       call      qword ptr [7FF9231F7CA8]; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M00_L04:
       mov       rdi,rax
       mov       rax,rdi
M00_L05:
       mov       rdi,rax
       mov       r12d,ebp
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L34
       mov       rax,[rdi+8]
       mov       [rsp+48],rax
       mov       rdx,2C5D6800A58
       cmp       rax,[rdx]
       je        near ptr M00_L23
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+40],rax
       xor       r10d,r10d
       mov       r9,[rsp+48]
       test      r9,r9
       je        near ptr M00_L13
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rdx
       jne       near ptr M00_L13
M00_L06:
       mov       edx,r10d
       imul      rdx,50
       lea       r9,[rsi+rdx+10]
       mov       r8,[r9+28]
       vmovdqu   ymm0,ymmword ptr [r9]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [r9+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [r9+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       [rsp+0D0],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+0D0]
       inc       r10d
       cmp       ebp,r10d
       jle       near ptr M00_L15
       mov       rax,[rsp+40]
       jmp       short M00_L06
M00_L07:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L08:
       mov       rdi,rsi
       test      rdi,rdi
       je        short M00_L09
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rdx
       jne       near ptr M00_L37
M00_L09:
       test      rdi,rdi
       je        near ptr M00_L45
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L38
       mov       esi,[rdi+8]
M00_L10:
       test      esi,esi
       je        near ptr M00_L44
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L43
       mov       ebp,[rdi+8]
       mov       rcx,[rdi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L42
       cmp       ebp,[rdi+8]
       ja        near ptr M00_L42
       cmp       ebp,[rsi+8]
       ja        near ptr M00_L42
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rdi+10]
       lea       rax,[rsi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L41
       cmp       r8,4000
       ja        near ptr M00_L40
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M00_L39
M00_L11:
       mov       [rsp+70],rsi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+70]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L12:
       mov       rax,[rsp+40]
M00_L13:
       cmp       r10d,ebp
       jae       near ptr M00_L46
       mov       [rsp+0D0],r10d
       mov       edx,r10d
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rdx
       jne       near ptr M00_L32
M00_L14:
       mov       edx,[rsp+0D0]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+0D0]
       inc       ecx
       cmp       ebp,ecx
       mov       r10d,ecx
       mov       r9,[rsp+48]
       jg        near ptr M00_L12
M00_L15:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M00_L16
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L33
       mov       rdx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF9231FA6B8]; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M00_L16:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+50],rax
       lea       rcx,[rax+10]
       xor       edx,edx
       mov       r8d,r12d
       lea       r8,[rcx+r8*4]
       cmp       r12d,8
       jl        short M00_L18
       vmovups   ymm0,[7FF923164420]
       vbroadcastss ymm1,dword ptr [7FF923164440]
       lea       rdx,[r8-20]
M00_L17:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rdx
       jbe       short M00_L17
       vmovd     edx,xmm0
M00_L18:
       cmp       rcx,r8
       jb        near ptr M00_L24
M00_L19:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L35
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       mov       rcx,rdi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231F9FA8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+78],rax
       mov       r8,[rsp+38]
       lea       rcx,[r8+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rsp+38]
       mov       rcx,[rsp+78]
       mov       [rdi+18],rcx
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       [rsp+60],rcx
       mov       [rsp+68],r12d
       lea       rcx,[rsp+60]
       mov       rdx,rdi
       call      qword ptr [7FF922D4E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M00_L20:
       mov       rdi,[rsp+50]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L22
       cmp       ebp,r13d
       jl        short M00_L25
       xor       r12d,r12d
M00_L21:
       imul      rcx,r12,14
       add       rcx,r15
       cmp       [rcx],cl
       mov       eax,[rdi+r12+10]
       cmp       eax,ebp
       jae       near ptr M00_L46
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,4
       dec       r13d
       jne       short M00_L21
M00_L22:
       mov       rsi,r14
       jmp       near ptr M00_L11
M00_L23:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M00_L24:
       lea       r10d,[rdx+1]
       mov       [rcx],edx
       add       rcx,4
       cmp       rcx,r8
       mov       edx,r10d
       jb        short M00_L24
       jmp       near ptr M00_L19
M00_L25:
       mov       ecx,r12d
       imul      rcx,50
       add       rcx,r15
       cmp       [rcx],cl
       cmp       r12d,ebp
       jae       near ptr M00_L46
       mov       edx,r12d
       mov       eax,[rdi+rdx*4+10]
       cmp       eax,ebp
       jae       near ptr M00_L46
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L25
       jmp       short M00_L22
M00_L26:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2C5D6800A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2C5D6800A48
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L27:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2C5D6800A38
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2C5D6800A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L28:
       mov       ecx,11
       call      qword ptr [7FF922C17E58]
       int       3
M00_L29:
       mov       r14,rsi
       jmp       near ptr M00_L22
M00_L30:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FF922C15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF922D4DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M00_L03
M00_L31:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L04
M00_L32:
       mov       [rsp+0A8],r8
       lea       rdx,[rsp+80]
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+40]
       jmp       near ptr M00_L14
M00_L33:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L16
M00_L34:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L16
M00_L35:
       mov       rax,[rsp+50]
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       jmp       near ptr M00_L20
M00_L36:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M00_L22
M00_L37:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M00_L09
M00_L38:
       mov       rcx,rdi
       mov       r11,7FF922940C18
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L10
M00_L39:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L11
M00_L40:
       mov       rcx,rax
       call      qword ptr [7FF922F9F3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L11
M00_L41:
       mov       rcx,rax
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L11
M00_L42:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923026B20]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L11
M00_L43:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF922940C20
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2C5D6800AF0
       mov       rsi,[rcx]
       jmp       near ptr M00_L11
M00_L45:
       mov       rcx,rsi
       call      qword ptr [7FF9230ED5C0]
       mov       rsi,rax
       jmp       near ptr M00_L11
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2236
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,2C5C0800A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M01_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M01_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L01:
       test      edi,edi
       je        short M01_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M01_L00
M01_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922B6FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```
```assembly
; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M02_L00:
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
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       mov       rbx,rcx
       mov       rsi,rbx
       test      rsi,rsi
       je        short M02_L01
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M02_L05
       xor       esi,esi
M02_L01:
       test      rsi,rsi
       je        near ptr M02_L06
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M02_L32
       mov       rcx,[rsi+60]
       call      qword ptr [7FF9230ED470]
       mov       rbx,rax
       mov       edi,[rbx+8]
       cmp       edi,1
       jle       near ptr M02_L25
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,[rsi+78]
       mov       rcx,2C5C0800A08
       cmp       r13,[rcx]
       je        near ptr M02_L26
M02_L02:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,[rsi+70]
       movzx     eax,byte ptr [rsi+90]
       mov       [rsp+0B4],eax
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rsp+0B4]
       mov       [r12+28],r13b
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       r13,r12
       cmp       qword ptr [rsi+68],0
       je        short M02_L03
       mov       rcx,[rsi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M02_L27
       mov       rdx,r12
       call      qword ptr [7FF9231F7CA8]; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       r13,rax
M02_L03:
       mov       esi,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [r13],rdx
       jne       near ptr M02_L30
       mov       rdx,r13
       mov       r12,[rdx+8]
       mov       rdx,2C5D6800A58
       cmp       r12,[rdx]
       je        near ptr M02_L22
       mov       edx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+40],rax
       xor       r10d,r10d
       test      r12,r12
       je        near ptr M02_L11
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],rdx
       jne       near ptr M02_L11
M02_L04:
       mov       edx,r10d
       imul      rdx,50
       lea       r12,[rbx+rdx+10]
       mov       r8,[r12+28]
       vmovdqu   ymm0,ymmword ptr [r12]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [r12+20]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   xmm0,xmmword ptr [r12+40]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       [rsp+0B0],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r12d,[rsp+0B0]
       inc       r12d
       cmp       edi,r12d
       mov       r10d,r12d
       jle       near ptr M02_L13
       mov       rax,[rsp+40]
       jmp       short M02_L04
M02_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M02_L01
       nop       dword ptr [rax]
M02_L06:
       mov       rsi,rbx
       test      rsi,rsi
       je        short M02_L07
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M02_L33
M02_L07:
       test      rsi,rsi
       je        near ptr M02_L41
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M02_L34
       mov       ebx,[rsi+8]
M02_L08:
       test      ebx,ebx
       je        near ptr M02_L40
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M02_L39
       mov       edi,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M02_L38
       cmp       edi,[rsi+8]
       ja        near ptr M02_L38
       cmp       edi,[rbx+8]
       ja        near ptr M02_L38
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M02_L37
       cmp       r8,4000
       ja        near ptr M02_L36
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M02_L35
M02_L09:
       mov       rax,rbx
       vzeroupper
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
M02_L10:
       mov       rax,[rsp+40]
M02_L11:
       cmp       r10d,edi
       jae       near ptr M02_L42
       mov       [rsp+0B0],r10d
       mov       edx,r10d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],rdx
       jne       near ptr M02_L28
M02_L12:
       mov       edx,[rsp+0B0]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+0B0]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       jg        short M02_L10
M02_L13:
       lea       rcx,[r13+20]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r13+18]
       test      rcx,rcx
       je        short M02_L14
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M02_L29
       mov       rdx,rbx
       mov       r8d,esi
       call      qword ptr [7FF9231FA6B8]; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M02_L14:
       mov       edx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rcx,[r12+10]
       xor       eax,eax
       mov       edx,esi
       lea       rdx,[rcx+rdx*4]
       cmp       esi,8
       jl        short M02_L16
       vmovups   ymm0,[7FF923163220]
       vbroadcastss ymm1,dword ptr [7FF923163240]
       lea       rax,[rdx-20]
M02_L15:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rax
       jbe       short M02_L15
       vmovd     eax,xmm0
M02_L16:
       cmp       rcx,rdx
       jb        near ptr M02_L23
M02_L17:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [r13],rcx
       jne       near ptr M02_L31
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       mov       rcx,r13
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231F9FA8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+58],rax
       mov       r8,[rsp+38]
       lea       rcx,[r8+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsp+38]
       mov       rcx,[rsp+58]
       mov       [r13+18],rcx
       lea       rcx,[r12+10]
       mov       [rsp+48],rcx
       mov       [rsp+50],esi
       lea       rcx,[rsp+48]
       mov       rdx,r13
       call      qword ptr [7FF922D4E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M02_L18:
       xor       esi,esi
       test      r15d,r15d
       jle       short M02_L20
       cmp       edi,r15d
       jl        near ptr M02_L24
       xor       esi,esi
M02_L19:
       imul      rcx,rsi,14
       add       rcx,r14
       cmp       [rcx],cl
       mov       r13d,[r12+rsi+10]
       cmp       r13d,edi
       jae       near ptr M02_L42
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rsi,4
       dec       r15d
       jne       short M02_L19
M02_L20:
       mov       rax,rbp
M02_L21:
       vzeroupper
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
M02_L22:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M02_L23:
       lea       r8d,[rax+1]
       mov       [rcx],eax
       add       rcx,4
       cmp       rcx,rdx
       mov       eax,r8d
       jb        short M02_L23
       jmp       near ptr M02_L17
M02_L24:
       mov       ecx,esi
       imul      rcx,50
       add       rcx,r14
       cmp       [rcx],cl
       cmp       esi,edi
       jae       near ptr M02_L42
       mov       edx,esi
       mov       r13d,[r12+rdx*4+10]
       cmp       r13d,edi
       jae       near ptr M02_L42
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       esi
       cmp       esi,r15d
       jl        short M02_L24
       jmp       near ptr M02_L20
M02_L25:
       mov       rax,rbx
       jmp       near ptr M02_L21
M02_L26:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF922C15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FF922D4DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M02_L02
M02_L27:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M02_L03
M02_L28:
       mov       [rsp+88],r8
       lea       rdx,[rsp+60]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       r8,rax
       mov       rax,[rsp+40]
       jmp       near ptr M02_L12
M02_L29:
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M02_L14
M02_L30:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M02_L14
M02_L31:
       lea       r9d,[rsi-1]
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M02_L18
M02_L32:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M02_L33:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M02_L07
M02_L34:
       mov       rcx,rsi
       mov       r11,7FF922940C08
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M02_L08
M02_L35:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L09
M02_L36:
       mov       rcx,rax
       call      qword ptr [7FF922F9F3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L09
M02_L37:
       mov       rcx,rax
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L09
M02_L38:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923026B20]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M02_L09
M02_L39:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922940C10
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M02_L09
M02_L40:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,2C5D6800AF0
       mov       rbx,[rax]
       jmp       near ptr M02_L09
M02_L41:
       mov       rcx,rbx
       vzeroupper
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9230ED5C0]
M02_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1857
```
```assembly
; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M03_L00:
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rbx+78]
       mov       rbp,[rbx]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.String
       cmp       [rcx+8],rax
       jne       short M03_L01
       mov       rcx,2C5C0800A08
       cmp       rdi,[rcx]
       je        near ptr M03_L07
M03_L01:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M03_L06
M03_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+70]
       movzx     r14d,byte ptr [rbx+90]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+28],r14b
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbp
       mov       rsi,[rbx+68]
       test      rsi,rsi
       je        near ptr M03_L05
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M03_L12
       mov       rdi,[rsi+78]
       mov       rcx,2C5C0800A08
       cmp       rdi,[rcx]
       je        near ptr M03_L10
M03_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,[rsi+70]
       movzx     r15d,byte ptr [rsi+90]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+28],r15b
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
       cmp       qword ptr [rsi+68],0
       je        short M03_L04
       mov       rcx,[rsi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M03_L11
       mov       rdx,r14
       call      qword ptr [7FF9231F7CA8]
       mov       rbp,rax
M03_L04:
       mov       rax,rbp
M03_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L06:
       mov       rcx,rbp
       mov       rdx,7FF9231D9C38
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L02
M03_L07:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF922C15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF922D4DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rbp
       mov       rdx,7FF9231D9C50
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L09:
       mov       rdx,rdi
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M03_L01
M03_L10:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF922C15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF922D4DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M03_L03
M03_L11:
       mov       rdx,r14
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M03_L04
M03_L12:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M03_L04
; Total bytes of code 576
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       rax,[rdx+28]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M05_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M05_L02
       cmp       rdx,[r8]
       jne       short M05_L03
M05_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M05_L01:
       call      qword ptr [7FF9231CD2A8]
       int       3
M05_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M05_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M05_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229FD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M06_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M06_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
M06_L00:
       test      rax,rax
       je        short M06_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       test      rax,rax
       je        short M06_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       test      rax,rax
       jne       short M06_L03
M06_L01:
       xor       edx,edx
M06_L02:
       mov       rax,rdx
       ret
M06_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       test      rax,rax
       je        short M06_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       jmp       short M06_L00
; Total bytes of code 86
```
```assembly
; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M07_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,80
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       mov       [rsp+70],rax
       mov       [rsp+78],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rbp,[rsi+8]
       mov       rcx,2C5D6800A58
       cmp       rbp,[rcx]
       je        near ptr M07_L06
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M07_L09
       mov       rcx,rax
M07_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M07_L03
       test      rbx,rbx
       je        near ptr M07_L10
       test      rbp,rbp
       je        near ptr M07_L10
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [rbp+18],rdx
       jne       near ptr M07_L10
       cmp       [rbx+8],r13d
       jl        near ptr M07_L10
M07_L02:
       mov       edx,r15d
       imul      rdx,50
       lea       rbp,[rbx+rdx+10]
       mov       r8,[rbp+28]
       vmovdqu   ymm0,ymmword ptr [rbp]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovdqu   ymm0,ymmword ptr [rbp+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   xmm0,xmmword ptr [rbp+40]
       vmovdqu   xmmword ptr [rsp+68],xmm0
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M07_L02
M07_L03:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L04:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        short M07_L05
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M07_L15
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FF9231FA6B8]
M07_L05:
       nop
       vzeroupper
       add       rsp,80
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L06:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M07_L13
       mov       rcx,rax
M07_L07:
       mov       rdx,rbx
       test      rdx,rdx
       je        short M07_L08
       cmp       [rdx],rcx
       jne       near ptr M07_L14
M07_L08:
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L04
M07_L09:
       mov       rdx,7FF9231D9F98
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M07_L01
M07_L10:
       cmp       r15d,[rbx+8]
       jae       near ptr M07_L16
       mov       edx,r15d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+68],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [rbp+18],rdx
       jne       short M07_L12
M07_L11:
       mov       edx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M07_L10
       jmp       near ptr M07_L03
M07_L12:
       mov       [rsp+50],r8
       lea       rdx,[rsp+28]
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
       mov       r8,rax
       jmp       short M07_L11
M07_L13:
       mov       rdx,7FF9231D9F98
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M07_L07
M07_L14:
       mov       rdx,rbx
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M07_L08
M07_L15:
       mov       rdx,rbx
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M07_L05
M07_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 589
```
```assembly
; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+18],rdx
       mov       r8,rdx
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       cmp       eax,1
       jle       short M08_L00
       mov       [rbp-10],rdx
       mov       [rbp-8],eax
       lea       rcx,[rbp-10]
       or        eax,1
       xor       edx,edx
       lzcnt     edx,eax
       xor       edx,1F
       lea       edx,[rdx*2+2]
       call      qword ptr [7FF922D4E340]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].IntroSort(System.Span`1<Int32>, Int32, System.Comparison`1<Int32>)
       nop
M08_L00:
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       rcx,[rbp+18]
       call      qword ptr [7FF923284318]
       lea       rax,[M08_L00]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       ecx,40
       call      qword ptr [7FF923284330]
       lea       rax,[M08_L00]
       add       rsp,28
       ret
; Total bytes of code 133
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M09_L02
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M09_L01
M09_L00:
       add       rsp,28
       ret
M09_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L00
M09_L02:
       add       rsp,28
       jmp       qword ptr [7FF922F9F3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 49
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M10_L05
       mov       rcx,[rbx]
       cmp       rcx,rsi
       je        near ptr M10_L04
       mov       rax,2C5C0800038
       mov       rax,[rax]
       add       rax,10
       rorx      rdx,rcx,20
       xor       rdx,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rdx,r8
       mov       r8d,[rax]
       shrx      rdx,rdx,r8
       xor       r8d,r8d
M10_L00:
       lea       r10d,[rdx+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rax+r10*8]
       mov       r9d,[r10]
       and       r9d,0FFFFFFFE
       cmp       [r10+8],rcx
       jne       short M10_L01
       mov       r11,rsi
       xor       r11,[r10+10]
       cmp       r11,1
       jbe       short M10_L03
M10_L01:
       test      r9d,r9d
       je        short M10_L02
       inc       r8d
       add       edx,r8d
       and       edx,[rax+4]
       cmp       r8d,8
       jl        short M10_L00
M10_L02:
       mov       rcx,7FF92323C98C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF9229F6340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M10_L03:
       cmp       r9d,[r10]
       jne       short M10_L02
       cmp       r11d,1
       jne       short M10_L02
       mov       rcx,7FF92323C980
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L05
M10_L04:
       mov       rcx,7FF92323C988
       call      CORINFO_HELP_COUNTPROFILE32
M10_L05:
       mov       rcx,7FF92323C984
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 246
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       rax,[rdx+20]
       ret
; Total bytes of code 5
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M12_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
       call      qword ptr [7FF9231CE9A0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       push      rbx
       sub       rsp,20
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       short M13_L03
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M13_L03
M13_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       je        short M13_L02
M13_L01:
       mov       rcx,7FF92323B398
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M13_L02:
       mov       rcx,2C5C0800110
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M13_L05
       mov       rcx,2C5C08000F0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M13_L04
       mov       rcx,7FF92323B3A0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M13_L01
M13_L03:
       mov       ecx,2
       call      qword ptr [7FF9231CE598]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M13_L00
M13_L04:
       mov       rcx,7FF92323B39C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF92323B398
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF922C15E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
M13_L05:
       mov       rcx,7FF92323B3A4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M13_L01
; Total bytes of code 204
```
```assembly
; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r8d
       lea       rcx,[rbx+8]
       call      qword ptr [7FF982458FE8]; CORINFO_HELP_ASSIGN_REF
       test      esi,0DFFFFFC0
       jne       short M14_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M14_L00:
       call      qword ptr [7FF982463550]
       mov       rbx,rax
       call      qword ptr [7FF98246E1A8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 87
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M15_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M15_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M15_L01
       cmp       [r10],rcx
       je        short M15_L06
M15_L00:
       cmp       [r10+8],rcx
       je        short M15_L06
       cmp       [r10+10],rcx
       je        short M15_L06
       cmp       [r10+18],rcx
       je        short M15_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M15_L04
       test      r8,r8
       je        short M15_L03
M15_L01:
       cmp       [r10],rcx
       je        short M15_L06
M15_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M15_L03
       cmp       [r10],rcx
       je        short M15_L06
       jmp       short M15_L02
M15_L03:
       test      dword ptr [rax],500C0000
       je        short M15_L05
       jmp       qword ptr [7FF922D4F5B8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M15_L04:
       cmp       [r10],rcx
       je        short M15_L06
       jmp       short M15_L00
M15_L05:
       xor       edx,edx
M15_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M16_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M16_L06
M16_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FF9826037E0
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FF982943A90],0
       jne       short M16_L04
M16_L01:
       cmp       rdi,4000
       ja        short M16_L00
M16_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M16_L05
M16_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M16_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M16_L01
M16_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M16_L03
M16_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       je        short M16_L07
       call      CORINFO_HELP_POLL_GC
M16_L07:
       cmp       rdi,4000
       ja        short M16_L06
       jmp       short M16_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M17_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M17_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M17_L02
       test      r8b,18
       jne       short M17_L01
       test      r8b,4
       je        short M17_L00
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M17_L05
M17_L00:
       test      r8,r8
       je        short M17_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M17_L05
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M17_L05
M17_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M17_L05
M17_L02:
       cmp       r8,40
       ja        short M17_L06
M17_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M17_L09
M17_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M17_L05:
       vzeroupper
       ret
M17_L06:
       cmp       r8,800
       ja        near ptr M17_L12
       cmp       r8,100
       jae       short M17_L10
M17_L07:
       mov       r9,r8
       shr       r9,6
M17_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M17_L08
       and       r8,3F
       cmp       r8,10
       ja        short M17_L03
       jmp       short M17_L04
M17_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M17_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M17_L04
M17_L10:
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
       jmp       short M17_L07
M17_L11:
       cmp       rcx,rdx
       jne       short M17_L12
       cmp       [rdx],dl
       jmp       near ptr M17_L05
M17_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF9229F66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 318
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M18_L09
       test      rsi,rsi
       je        near ptr M18_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M18_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M18_L10
M18_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M18_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M18_L07
       sub       edi,eax
       js        near ptr M18_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M18_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M18_L06
       sub       ebp,eax
       js        near ptr M18_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M18_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M18_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98246A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M18_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M18_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M18_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M18_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246D930]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M18_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M18_L15
M18_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M18_L04:
       cmp       r8,4000
       jbe       short M18_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M18_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M18_L02
       jmp       near ptr M18_L14
M18_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M18_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M18_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M18_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M18_L10:
       call      qword ptr [7FF982463788]
       mov       rbx,rax
       call      qword ptr [7FF98246ED60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246D7C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M18_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF982481910]
       int       3
M18_L12:
       call      qword ptr [7FF982463550]
       mov       rdi,rax
       call      qword ptr [7FF98246DC18]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rdi
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M18_L13:
       call      qword ptr [7FF982463550]
       mov       rbp,rax
       call      qword ptr [7FF98246DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rbp
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M18_L14:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M18_L02
M18_L15:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M18_L03
M18_L16:
       call      qword ptr [7FF982463578]
       mov       rbx,rax
       call      qword ptr [7FF98246E6E0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246C240]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M19_L00
       ret
M19_L00:
       jmp       qword ptr [7FF9229F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark.OrderByWithComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,138
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       vmovdqa   xmmword ptr [rsp+rax+140],xmm4
       vmovdqa   xmmword ptr [rsp+rax+150],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,29470002A38
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L22
M00_L01:
       mov       rbp,[rbx+2E8]
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+8],eax
       lea       rcx,[r14+60]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L23
       xor       ecx,ecx
       mov       [r14+68],rcx
       lea       rcx,[r14+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       mov       rcx,29470002A60
       test      rdx,rdx
       cmove     rdx,[rcx]
       lea       rcx,[r14+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],0
       mov       rcx,[r14+60]
       call      qword ptr [7FF9230CD3F8]; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L24
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r15,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r14+78]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[r14+70]
       movzx     r8d,byte ptr [r14+90]
       mov       [rsp+134],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+134]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r14+68],0
       jne       near ptr M00_L25
M00_L02:
       mov       r14,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r14],rdx
       jne       near ptr M00_L27
       mov       rax,[r14+8]
       mov       [rsp+40],rax
       mov       rdx,29470002A50
       cmp       rax,[rdx]
       je        near ptr M00_L20
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        near ptr M00_L05
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L05
       mov       r10d,10
       mov       [rsp+5C],edi
M00_L03:
       vmovdqu   ymm0,ymmword ptr [rsi+r10]
       vmovdqu   ymmword ptr [rsp+90],ymm0
       vmovdqu   ymm0,ymmword ptr [rsi+r10+20]
       vmovdqu   ymmword ptr [rsp+0B0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsi+r10+40]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+90]
       vmovdqu   ymmword ptr [rsp+0E0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0B0]
       vmovdqu   ymmword ptr [rsp+100],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+120],xmm0
       mov       [rsp+60],r10
       lea       rcx,[rax+r10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0E0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10,[rsp+60]
       add       r10,50
       mov       r9d,[rsp+5C]
       dec       r9d
       mov       [rsp+5C],r9d
       je        near ptr M00_L07
       mov       rax,[rsp+38]
       jmp       near ptr M00_L03
M00_L04:
       mov       rax,[rsp+38]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L31
       mov       [rsp+130],r10d
       mov       r8d,r10d
       imul      r11,r8,50
       mov       [rsp+68],r11
       vmovdqu   ymm0,ymmword ptr [rsi+r11+10]
       vmovdqu   ymmword ptr [rsp+90],ymm0
       vmovdqu   ymm0,ymmword ptr [rsi+r11+30]
       vmovdqu   ymmword ptr [rsp+0B0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsi+r11+50]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],r8
       jne       near ptr M00_L26
       vmovdqu   ymm0,ymmword ptr [rsp+90]
       vmovdqu   ymmword ptr [rsp+0E0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0B0]
       vmovdqu   ymmword ptr [rsp+100],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+120],xmm0
M00_L06:
       mov       r11,[rsp+68]
       lea       rcx,[rax+r11+10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0E0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rsp+130]
       inc       r10d
       cmp       edi,r10d
       mov       r9,[rsp+40]
       jg        near ptr M00_L04
M00_L07:
       lea       rcx,[r14+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[r14+18]
       test      rcx,rcx
       jne       near ptr M00_L21
M00_L09:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       rcx,[rax+10]
       xor       edx,edx
       mov       r8d,r12d
       lea       r8,[rcx+r8*4]
       cmp       r12d,8
       jl        short M00_L11
       vmovups   ymm0,[7FF923151140]
       vbroadcastss ymm1,dword ptr [7FF923151160]
       lea       rdx,[r8-20]
M00_L10:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rdx
       jbe       short M00_L10
       vmovd     edx,xmm0
M00_L11:
       cmp       rcx,r8
       jb        near ptr M00_L18
M00_L12:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L30
       cmp       qword ptr [r14+18],0
       jne       short M00_L13
       mov       rcx,[r14+10]
       mov       rdx,29470002A60
       cmp       rcx,[rdx]
       je        near ptr M00_L28
M00_L13:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       rcx,r14
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231E8590
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+88],rax
       mov       r8,[rsp+30]
       lea       rcx,[r8+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rsp+30]
       mov       rcx,[rsp+88]
       mov       [r14+18],rcx
M00_L14:
       mov       rax,[rsp+48]
       lea       rcx,[rax+10]
       mov       [rsp+70],rcx
       mov       [rsp+78],r12d
       lea       rcx,[rsp+70]
       mov       rdx,r14
       call      qword ptr [7FF922D3E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M00_L15:
       mov       r14,[rsp+48]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L17
       cmp       edi,r13d
       jl        near ptr M00_L19
       xor       r12d,r12d
M00_L16:
       imul      rcx,r12,14
       add       rcx,r15
       cmp       [rcx],cl
       mov       eax,[r14+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L31
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,4
       dec       r13d
       jne       short M00_L16
M00_L17:
       mov       [rsp+80],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+80]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
       add       rsp,138
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L18:
       lea       r10d,[rdx+1]
       mov       [rcx],edx
       add       rcx,4
       cmp       rcx,r8
       mov       edx,r10d
       jb        short M00_L18
       jmp       near ptr M00_L12
M00_L19:
       mov       ecx,r12d
       imul      rcx,50
       add       rcx,r15
       cmp       [rcx],cl
       cmp       r12d,edi
       jae       near ptr M00_L31
       mov       edx,r12d
       mov       eax,[r14+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L31
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L19
       jmp       near ptr M00_L17
M00_L20:
       lea       rcx,[r14+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L21:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L22:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,29470002A30
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,29470002A38
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L23:
       mov       ecx,11
       call      qword ptr [7FF922C07E58]
       int       3
M00_L24:
       mov       rbp,rsi
       jmp       near ptr M00_L17
M00_L25:
       mov       rcx,[r14+68]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r14,rax
       mov       rax,r14
       jmp       near ptr M00_L02
M00_L26:
       lea       r8,[rsp+90]
       lea       rdx,[rsp+0E0]
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       rax,[rsp+38]
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L28:
       cmp       byte ptr [r14+28],0
       jne       short M00_L29
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+20],rdx
       mov       rcx,rdx
       mov       rdx,r14
       mov       r8,7FF9231B3240
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r14,[rsp+20]
       jmp       near ptr M00_L14
M00_L29:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,7FF9231B3258
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r14,[rsp+28]
       jmp       near ptr M00_L14
M00_L30:
       mov       rax,[rsp+48]
       lea       r9d,[r12-1]
       mov       rcx,r14
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r14]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       jmp       near ptr M00_L15
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1787
```
```assembly
; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M01_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,128
       xor       eax,eax
       mov       [rsp+68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       vmovdqu   ymmword ptr [rsp+0B0],ymm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       vmovdqu   ymmword ptr [rsp+0F0],ymm4
       vmovdqa   xmmword ptr [rsp+110],xmm4
       mov       rbx,rcx
       mov       rsi,rbx
       test      rsi,rsi
       je        short M01_L01
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [rsi],rdx
       je        short M01_L01
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
M01_L01:
       test      rsi,rsi
       jne       near ptr M01_L05
       mov       rsi,rbx
       test      rsi,rsi
       je        short M01_L02
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M01_L35
M01_L02:
       test      rsi,rsi
       je        near ptr M01_L43
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L36
       mov       ebx,[rsi+8]
M01_L03:
       test      ebx,ebx
       je        near ptr M01_L42
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L41
       mov       edi,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L40
       cmp       edi,[rsi+8]
       ja        near ptr M01_L40
       cmp       edi,[rbx+8]
       ja        near ptr M01_L40
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L39
       cmp       r8,4000
       ja        near ptr M01_L38
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L37
M01_L04:
       mov       rax,rbx
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M01_L34
       mov       rcx,[rsi+60]
       call      qword ptr [7FF9230CD3F8]
       mov       rbx,rax
       mov       edi,[rbx+8]
       cmp       edi,1
       jle       near ptr M01_L27
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,[rsi+78]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,[rsi+70]
       movzx     eax,byte ptr [rsi+90]
       mov       [rsp+124],eax
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rsp+124]
       mov       [r12+28],r13b
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       r13,r12
       cmp       qword ptr [rsi+68],0
       jne       near ptr M01_L28
M01_L06:
       mov       esi,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r13],rdx
       jne       near ptr M01_L30
       mov       rax,r13
       mov       r12,[rax+8]
       mov       rdx,29470002A50
       cmp       r12,[rdx]
       je        near ptr M01_L25
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+50],rax
       xor       r10d,r10d
       test      r12,r12
       je        near ptr M01_L09
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],rcx
       jne       near ptr M01_L09
       mov       r12d,10
       mov       [rsp+5C],edi
M01_L07:
       vmovdqu   ymm0,ymmword ptr [rbx+r12]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rbx+r12+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rbx+r12+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+80]
       vmovdqu   ymmword ptr [rsp+0D0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A0]
       vmovdqu   ymmword ptr [rsp+0F0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+110],xmm0
       lea       rcx,[rax+r12]
       cmp       [rcx],cl
       lea       rdx,[rsp+0D0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,50
       mov       r10d,[rsp+5C]
       dec       r10d
       mov       [rsp+5C],r10d
       je        near ptr M01_L11
       mov       rax,[rsp+50]
       jmp       near ptr M01_L07
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M01_L08:
       mov       rax,[rsp+50]
M01_L09:
       cmp       r10d,edi
       jae       near ptr M01_L44
       mov       [rsp+120],r10d
       mov       r8d,r10d
       imul      r9,r8,50
       mov       [rsp+60],r9
       vmovdqu   ymm0,ymmword ptr [rbx+r9+10]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rbx+r9+30]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rbx+r9+50]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],r8
       jne       near ptr M01_L29
       vmovdqu   ymm0,ymmword ptr [rsp+80]
       vmovdqu   ymmword ptr [rsp+0D0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A0]
       vmovdqu   ymmword ptr [rsp+0F0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+110],xmm0
M01_L10:
       mov       r9,[rsp+60]
       lea       rcx,[rax+r9+10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0D0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rsp+120]
       inc       r10d
       cmp       edi,r10d
       jg        near ptr M01_L08
M01_L11:
       lea       rcx,[r13+20]
       mov       rdx,[rsp+50]
       call      CORINFO_HELP_ASSIGN_REF
M01_L12:
       mov       rcx,[r13+18]
       test      rcx,rcx
       jne       near ptr M01_L26
M01_L13:
       mov       edx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rcx,[r12+10]
       xor       eax,eax
       mov       edx,esi
       lea       rdx,[rcx+rdx*4]
       cmp       esi,8
       jl        short M01_L15
       vmovups   ymm0,[7FF923150580]
       vbroadcastss ymm1,dword ptr [7FF9231505A0]
       lea       rax,[rdx-20]
M01_L14:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rax
       jbe       short M01_L14
       vmovd     eax,xmm0
M01_L15:
       cmp       rcx,rdx
       jb        near ptr M01_L23
M01_L16:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L33
       cmp       qword ptr [r13+18],0
       jne       short M01_L17
       mov       rcx,[r13+10]
       mov       rax,29470002A60
       cmp       rcx,[rax]
       je        near ptr M01_L31
M01_L17:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,r13
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231E8590
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+78],rax
       mov       r8,[rsp+48]
       lea       rcx,[r8+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsp+48]
       mov       rcx,[rsp+78]
       mov       [r13+18],rcx
M01_L18:
       lea       rcx,[r12+10]
       mov       [rsp+68],rcx
       mov       [rsp+70],esi
       lea       rcx,[rsp+68]
       mov       rdx,r13
       call      qword ptr [7FF922D3E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M01_L19:
       xor       esi,esi
       test      r15d,r15d
       jle       short M01_L21
       cmp       edi,r15d
       jl        short M01_L24
       xor       esi,esi
M01_L20:
       imul      rcx,rsi,14
       add       rcx,r14
       cmp       [rcx],cl
       mov       r13d,[r12+rsi+10]
       cmp       r13d,edi
       jae       near ptr M01_L44
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rsi,4
       dec       r15d
       jne       short M01_L20
M01_L21:
       mov       rax,rbp
M01_L22:
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L23:
       lea       r8d,[rax+1]
       mov       [rcx],eax
       add       rcx,4
       cmp       rcx,rdx
       mov       eax,r8d
       jb        short M01_L23
       jmp       near ptr M01_L16
M01_L24:
       mov       ecx,esi
       imul      rcx,50
       add       rcx,r14
       cmp       [rcx],cl
       cmp       esi,edi
       jae       near ptr M01_L44
       mov       edx,esi
       mov       r13d,[r12+rdx*4+10]
       cmp       r13d,edi
       jae       near ptr M01_L44
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       esi
       cmp       esi,r15d
       jl        short M01_L24
       jmp       short M01_L21
M01_L25:
       lea       rcx,[rax+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L12
M01_L26:
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L13
M01_L27:
       mov       rax,rbx
       jmp       near ptr M01_L22
M01_L28:
       mov       rcx,[rsi+68]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M01_L06
M01_L29:
       lea       r8,[rsp+80]
       lea       rdx,[rsp+0D0]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       rax,[rsp+50]
       jmp       near ptr M01_L10
M01_L30:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L13
M01_L31:
       cmp       byte ptr [r13+28],0
       jne       short M01_L32
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+38],rdx
       mov       rcx,rdx
       mov       rdx,r13
       mov       r8,7FF9231B3240
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r13,[rsp+38]
       jmp       near ptr M01_L18
M01_L32:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rcx,rax
       mov       rdx,r13
       mov       r8,7FF9231B3258
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r13,[rsp+40]
       jmp       near ptr M01_L18
M01_L33:
       lea       r9d,[rsi-1]
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L19
M01_L34:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L36:
       mov       rcx,rsi
       mov       r11,7FF922930CA0
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L03
M01_L37:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L04
M01_L38:
       mov       rcx,rax
       call      qword ptr [7FF922F8EF28]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L04
M01_L39:
       mov       rcx,rax
       call      qword ptr [7FF9229E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L04
M01_L40:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923016AA8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L04
M01_L41:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922930CA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,29470002AE0
       mov       rbx,[rax]
       jmp       near ptr M01_L04
M01_L43:
       mov       rcx,rbx
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9230CD560]
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2034
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       vmovdqu   ymm0,ymmword ptr [r8]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymm0,ymmword ptr [r8+20]
       vmovdqu   ymmword ptr [rdx+20],ymm0
       vmovdqu   xmm0,xmmword ptr [r8+40]
       vmovdqu   xmmword ptr [rdx+40],xmm0
       mov       rax,rdx
       vzeroupper
       ret
; Total bytes of code 38
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M03_L02
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M03_L01
M03_L00:
       add       rsp,28
       ret
M03_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L00
M03_L02:
       add       rsp,28
       jmp       qword ptr [7FF922F8EF28]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 49
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,29470000A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M04_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M04_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M04_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M04_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L01:
       test      edi,edi
       je        short M04_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M04_L00
M04_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922B5FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```
```assembly
; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+18],rdx
       mov       r8,rdx
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       cmp       eax,1
       jle       short M05_L00
       mov       [rbp-10],rdx
       mov       [rbp-8],eax
       lea       rcx,[rbp-10]
       or        eax,1
       xor       edx,edx
       lzcnt     edx,eax
       xor       edx,1F
       lea       edx,[rdx*2+2]
       call      qword ptr [7FF922D3E340]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].IntroSort(System.Span`1<Int32>, Int32, System.Comparison`1<Int32>)
       nop
M05_L00:
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9231BFE28]
       lea       rax,[M05_L00]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       ecx,40
       call      qword ptr [7FF9231BFE40]
       lea       rax,[M05_L00]
       add       rsp,28
       ret
; Total bytes of code 133
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
       call      qword ptr [7FF9231BE3E8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark.OrderByWithoutComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0D8
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,2116A800A48
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L25
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rax,21154800068
       mov       r14,[rax]
       mov       r15,r14
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+8],eax
       lea       rcx,[rbp+60]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L27
       xor       ecx,ecx
       mov       [rbp+68],rcx
       lea       rcx,[rbp+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[rbp+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+90],0
       mov       rcx,2116A800A50
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L26
M00_L01:
       mov       rcx,rbp
       mov       rdx,offset MT_System.Linq.IOrderedEnumerable<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231E8568
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       r8,r14
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r9d,r9d
       call      rax
       mov       rsi,rax
       mov       rdi,rsi
       test      rdi,rdi
       je        short M00_L02
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rdx
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
M00_L02:
       test      rdi,rdi
       jne       near ptr M00_L06
       mov       rdi,rsi
       test      rdi,rdi
       je        short M00_L03
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rdx
       jne       near ptr M00_L36
M00_L03:
       test      rdi,rdi
       je        near ptr M00_L44
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L37
       mov       esi,[rdi+8]
M00_L04:
       test      esi,esi
       je        near ptr M00_L43
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L42
       mov       ebp,[rdi+8]
       mov       rcx,[rdi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L41
       cmp       ebp,[rdi+8]
       ja        near ptr M00_L41
       cmp       ebp,[rsi+8]
       ja        near ptr M00_L41
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rdi+10]
       lea       rax,[rsi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L40
       cmp       r8,4000
       ja        near ptr M00_L39
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M00_L38
M00_L05:
       mov       [rsp+70],rsi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+70]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L06:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L35
       mov       rcx,[rdi+60]
       call      qword ptr [7FF9230CD410]; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       rsi,rax
       mov       ebp,[rsi+8]
       cmp       ebp,1
       jle       near ptr M00_L28
       mov       edx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+78]
       mov       rcx,21154800A08
       cmp       r12,[rcx]
       je        near ptr M00_L29
M00_L07:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+58],rax
       mov       rdx,[rdi+70]
       movzx     r8d,byte ptr [rdi+90]
       mov       [rsp+0D4],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+58]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+58]
       mov       ecx,[rsp+0D4]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+68],0
       je        short M00_L09
       mov       rcx,[rdi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L30
       mov       rdx,r12
       call      qword ptr [7FF9231E6DF0]; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M00_L08:
       mov       rdi,rax
       mov       rax,rdi
M00_L09:
       mov       rdi,rax
       mov       r12d,ebp
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       mov       rax,[rdi+8]
       mov       [rsp+48],rax
       mov       rdx,2116A800A58
       cmp       rax,[rdx]
       je        near ptr M00_L22
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+40],rax
       xor       r10d,r10d
       mov       r9,[rsp+48]
       test      r9,r9
       je        near ptr M00_L12
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L12
       nop       dword ptr [rax]
M00_L10:
       mov       edx,r10d
       imul      rdx,50
       lea       r9,[rsi+rdx+10]
       mov       r8,[r9+28]
       vmovdqu   ymm0,ymmword ptr [r9]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [r9+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [r9+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       [rsp+0D0],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+0D0]
       inc       r10d
       cmp       ebp,r10d
       jle       near ptr M00_L14
       mov       rax,[rsp+40]
       jmp       short M00_L10
       nop       dword ptr [rax+rax]
M00_L11:
       mov       rax,[rsp+40]
M00_L12:
       cmp       r10d,ebp
       jae       near ptr M00_L45
       mov       [rsp+0D0],r10d
       mov       edx,r10d
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rdx
       jne       near ptr M00_L31
M00_L13:
       mov       edx,[rsp+0D0]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+0D0]
       inc       ecx
       cmp       ebp,ecx
       mov       r10d,ecx
       mov       r9,[rsp+48]
       jg        near ptr M00_L11
M00_L14:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M00_L15
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L32
       mov       rdx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF9231E9800]; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M00_L15:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+50],rax
       lea       rcx,[rax+10]
       xor       edx,edx
       mov       r8d,r12d
       lea       r8,[rcx+r8*4]
       cmp       r12d,8
       jl        short M00_L17
       vmovups   ymm0,[7FF923151F20]
       vbroadcastss ymm1,dword ptr [7FF923151F40]
       lea       rdx,[r8-20]
M00_L16:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rdx
       jbe       short M00_L16
       vmovd     edx,xmm0
M00_L17:
       cmp       rcx,r8
       jb        near ptr M00_L23
M00_L18:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L34
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       mov       rcx,rdi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231E90F0
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+78],rax
       mov       r8,[rsp+38]
       lea       rcx,[r8+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rsp+38]
       mov       rcx,[rsp+78]
       mov       [rdi+18],rcx
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       [rsp+60],rcx
       mov       [rsp+68],r12d
       lea       rcx,[rsp+60]
       mov       rdx,rdi
       call      qword ptr [7FF922D3E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M00_L19:
       mov       rdi,[rsp+50]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L21
       cmp       ebp,r13d
       jl        short M00_L24
       xor       r12d,r12d
M00_L20:
       imul      rcx,r12,14
       add       rcx,r15
       cmp       [rcx],cl
       mov       eax,[rdi+r12+10]
       cmp       eax,ebp
       jae       near ptr M00_L45
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,4
       dec       r13d
       jne       short M00_L20
M00_L21:
       mov       rsi,r14
       jmp       near ptr M00_L05
M00_L22:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229E58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M00_L23:
       lea       r10d,[rdx+1]
       mov       [rcx],edx
       add       rcx,4
       cmp       rcx,r8
       mov       edx,r10d
       jb        short M00_L23
       jmp       near ptr M00_L18
M00_L24:
       mov       ecx,r12d
       imul      rcx,50
       add       rcx,r15
       cmp       [rcx],cl
       cmp       r12d,ebp
       jae       near ptr M00_L45
       mov       edx,r12d
       mov       eax,[rdi+rdx*4+10]
       cmp       eax,ebp
       jae       near ptr M00_L45
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L24
       jmp       short M00_L21
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2116A800A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2116A800A48
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2116A800A38
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2116A800A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L27:
       mov       ecx,11
       call      qword ptr [7FF922C07E58]
       int       3
M00_L28:
       mov       r14,rsi
       jmp       near ptr M00_L21
M00_L29:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FF922C05DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF922D3DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M00_L07
M00_L30:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L08
M00_L31:
       mov       [rsp+0A8],r8
       lea       rdx,[rsp+80]
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+40]
       jmp       near ptr M00_L13
M00_L32:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L15
M00_L33:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L15
M00_L34:
       mov       rax,[rsp+50]
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       jmp       near ptr M00_L19
M00_L35:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M00_L21
M00_L36:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L37:
       mov       rcx,rdi
       mov       r11,7FF922930C18
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L04
M00_L38:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rax
       call      qword ptr [7FF922F8F3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L05
M00_L40:
       mov       rcx,rax
       call      qword ptr [7FF9229E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L05
M00_L41:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923016AC0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L05
M00_L42:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF922930C20
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L05
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2116A800AF0
       mov       rsi,[rcx]
       jmp       near ptr M00_L05
M00_L44:
       mov       rcx,rsi
       call      qword ptr [7FF9230CD560]
       mov       rsi,rax
       jmp       near ptr M00_L05
M00_L45:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2230
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,21154800A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M01_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M01_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L01:
       test      edi,edi
       je        short M01_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M01_L00
M01_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922B5FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
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
```assembly
; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M03_L00:
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
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       mov       rbx,rcx
       mov       rsi,rbx
       test      rsi,rsi
       je        short M03_L01
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M03_L05
       xor       esi,esi
M03_L01:
       test      rsi,rsi
       je        near ptr M03_L06
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M03_L32
       mov       rcx,[rsi+60]
       call      qword ptr [7FF9230CD410]
       mov       rbx,rax
       mov       edi,[rbx+8]
       cmp       edi,1
       jle       near ptr M03_L25
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,[rsi+78]
       mov       rcx,21154800A08
       cmp       r13,[rcx]
       je        near ptr M03_L26
M03_L02:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,[rsi+70]
       movzx     eax,byte ptr [rsi+90]
       mov       [rsp+0B4],eax
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rsp+0B4]
       mov       [r12+28],r13b
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       r13,r12
       cmp       qword ptr [rsi+68],0
       je        short M03_L03
       mov       rcx,[rsi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M03_L27
       mov       rdx,r12
       call      qword ptr [7FF9231E6DF0]; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       r13,rax
M03_L03:
       mov       esi,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [r13],rdx
       jne       near ptr M03_L30
       mov       rdx,r13
       mov       r12,[rdx+8]
       mov       rdx,2116A800A58
       cmp       r12,[rdx]
       je        near ptr M03_L22
       mov       edx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+40],rax
       xor       r10d,r10d
       test      r12,r12
       je        near ptr M03_L11
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],rdx
       jne       near ptr M03_L11
M03_L04:
       mov       edx,r10d
       imul      rdx,50
       lea       r12,[rbx+rdx+10]
       mov       r8,[r12+28]
       vmovdqu   ymm0,ymmword ptr [r12]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [r12+20]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   xmm0,xmmword ptr [r12+40]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       [rsp+0B0],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r12d,[rsp+0B0]
       inc       r12d
       cmp       edi,r12d
       mov       r10d,r12d
       jle       near ptr M03_L13
       mov       rax,[rsp+40]
       jmp       short M03_L04
M03_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M03_L01
       nop       dword ptr [rax]
M03_L06:
       mov       rsi,rbx
       test      rsi,rsi
       je        short M03_L07
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M03_L33
M03_L07:
       test      rsi,rsi
       je        near ptr M03_L41
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M03_L34
       mov       ebx,[rsi+8]
M03_L08:
       test      ebx,ebx
       je        near ptr M03_L40
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M03_L39
       mov       edi,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M03_L38
       cmp       edi,[rsi+8]
       ja        near ptr M03_L38
       cmp       edi,[rbx+8]
       ja        near ptr M03_L38
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M03_L37
       cmp       r8,4000
       ja        near ptr M03_L36
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M03_L35
M03_L09:
       mov       rax,rbx
       vzeroupper
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
M03_L10:
       mov       rax,[rsp+40]
M03_L11:
       cmp       r10d,edi
       jae       near ptr M03_L42
       mov       [rsp+0B0],r10d
       mov       edx,r10d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],rdx
       jne       near ptr M03_L28
M03_L12:
       mov       edx,[rsp+0B0]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+0B0]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       jg        short M03_L10
M03_L13:
       lea       rcx,[r13+20]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r13+18]
       test      rcx,rcx
       je        short M03_L14
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M03_L29
       mov       rdx,rbx
       mov       r8d,esi
       call      qword ptr [7FF9231E9800]; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M03_L14:
       mov       edx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rcx,[r12+10]
       xor       eax,eax
       mov       edx,esi
       lea       rdx,[rcx+rdx*4]
       cmp       esi,8
       jl        short M03_L16
       vmovups   ymm0,[7FF923150D20]
       vbroadcastss ymm1,dword ptr [7FF923150D40]
       lea       rax,[rdx-20]
M03_L15:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rax
       jbe       short M03_L15
       vmovd     eax,xmm0
M03_L16:
       cmp       rcx,rdx
       jb        near ptr M03_L23
M03_L17:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [r13],rcx
       jne       near ptr M03_L31
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       mov       rcx,r13
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231E90F0
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+58],rax
       mov       r8,[rsp+38]
       lea       rcx,[r8+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsp+38]
       mov       rcx,[rsp+58]
       mov       [r13+18],rcx
       lea       rcx,[r12+10]
       mov       [rsp+48],rcx
       mov       [rsp+50],esi
       lea       rcx,[rsp+48]
       mov       rdx,r13
       call      qword ptr [7FF922D3E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M03_L18:
       xor       esi,esi
       test      r15d,r15d
       jle       short M03_L20
       cmp       edi,r15d
       jl        near ptr M03_L24
       xor       esi,esi
M03_L19:
       imul      rcx,rsi,14
       add       rcx,r14
       cmp       [rcx],cl
       mov       r13d,[r12+rsi+10]
       cmp       r13d,edi
       jae       near ptr M03_L42
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rsi,4
       dec       r15d
       jne       short M03_L19
M03_L20:
       mov       rax,rbp
M03_L21:
       vzeroupper
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
M03_L22:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229E58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M03_L23:
       lea       r8d,[rax+1]
       mov       [rcx],eax
       add       rcx,4
       cmp       rcx,rdx
       mov       eax,r8d
       jb        short M03_L23
       jmp       near ptr M03_L17
M03_L24:
       mov       ecx,esi
       imul      rcx,50
       add       rcx,r14
       cmp       [rcx],cl
       cmp       esi,edi
       jae       near ptr M03_L42
       mov       edx,esi
       mov       r13d,[r12+rdx*4+10]
       cmp       r13d,edi
       jae       near ptr M03_L42
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       esi
       cmp       esi,r15d
       jl        short M03_L24
       jmp       near ptr M03_L20
M03_L25:
       mov       rax,rbx
       jmp       near ptr M03_L21
M03_L26:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF922C05DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FF922D3DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M03_L02
M03_L27:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M03_L03
M03_L28:
       mov       [rsp+88],r8
       lea       rdx,[rsp+60]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       r8,rax
       mov       rax,[rsp+40]
       jmp       near ptr M03_L12
M03_L29:
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M03_L14
M03_L30:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M03_L14
M03_L31:
       lea       r9d,[rsi-1]
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M03_L18
M03_L32:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M03_L33:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M03_L07
M03_L34:
       mov       rcx,rsi
       mov       r11,7FF922930C08
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M03_L08
M03_L35:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L09
M03_L36:
       mov       rcx,rax
       call      qword ptr [7FF922F8F3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L09
M03_L37:
       mov       rcx,rax
       call      qword ptr [7FF9229E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L09
M03_L38:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923016AC0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M03_L09
M03_L39:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922930C10
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M03_L09
M03_L40:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,2116A800AF0
       mov       rbx,[rax]
       jmp       near ptr M03_L09
M03_L41:
       mov       rcx,rbx
       vzeroupper
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9230CD560]
M03_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1857
```
```assembly
; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M04_L00:
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rbx+78]
       mov       rbp,[rbx]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.String
       cmp       [rcx+8],rax
       jne       short M04_L01
       mov       rcx,21154800A08
       cmp       rdi,[rcx]
       je        near ptr M04_L07
M04_L01:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M04_L06
M04_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+70]
       movzx     r14d,byte ptr [rbx+90]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+28],r14b
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbp
       mov       rsi,[rbx+68]
       test      rsi,rsi
       je        near ptr M04_L05
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M04_L12
       mov       rdi,[rsi+78]
       mov       rcx,21154800A08
       cmp       rdi,[rcx]
       je        near ptr M04_L10
M04_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,[rsi+70]
       movzx     r15d,byte ptr [rsi+90]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+28],r15b
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
       cmp       qword ptr [rsi+68],0
       je        short M04_L04
       mov       rcx,[rsi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M04_L11
       mov       rdx,r14
       call      qword ptr [7FF9231E6DF0]
       mov       rbp,rax
M04_L04:
       mov       rax,rbp
M04_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L06:
       mov       rcx,rbp
       mov       rdx,7FF9231C9C38
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L07:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF922C05DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF922D3DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rbp
       mov       rdx,7FF9231C9C50
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M04_L09:
       mov       rdx,rdi
       call      qword ptr [7FF9229E58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M04_L01
M04_L10:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF922C05DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF922D3DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M04_L03
M04_L11:
       mov       rdx,r14
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M04_L04
M04_L12:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M04_L04
; Total bytes of code 576
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       rax,[rdx+28]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M06_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M06_L02
       cmp       rdx,[r8]
       jne       short M06_L03
M06_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M06_L01:
       call      qword ptr [7FF9231BD2A8]
       int       3
M06_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M06_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M06_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229ED8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M07_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,80
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       mov       [rsp+70],rax
       mov       [rsp+78],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rbp,[rsi+8]
       mov       rcx,2116A800A58
       cmp       rbp,[rcx]
       je        near ptr M07_L06
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M07_L09
       mov       rcx,rax
M07_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M07_L03
       test      rbx,rbx
       je        near ptr M07_L10
       test      rbp,rbp
       je        near ptr M07_L10
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [rbp+18],rdx
       jne       near ptr M07_L10
       cmp       [rbx+8],r13d
       jl        near ptr M07_L10
M07_L02:
       mov       edx,r15d
       imul      rdx,50
       lea       rbp,[rbx+rdx+10]
       mov       r8,[rbp+28]
       vmovdqu   ymm0,ymmword ptr [rbp]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovdqu   ymm0,ymmword ptr [rbp+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   xmm0,xmmword ptr [rbp+40]
       vmovdqu   xmmword ptr [rsp+68],xmm0
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M07_L02
M07_L03:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L04:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        short M07_L05
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M07_L15
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FF9231E9800]
M07_L05:
       nop
       vzeroupper
       add       rsp,80
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L06:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M07_L13
       mov       rcx,rax
M07_L07:
       mov       rdx,rbx
       test      rdx,rdx
       je        short M07_L08
       cmp       [rdx],rcx
       jne       near ptr M07_L14
M07_L08:
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L04
M07_L09:
       mov       rdx,7FF9231C9F98
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M07_L01
M07_L10:
       cmp       r15d,[rbx+8]
       jae       near ptr M07_L16
       mov       edx,r15d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+68],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [rbp+18],rdx
       jne       short M07_L12
M07_L11:
       mov       edx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M07_L10
       jmp       near ptr M07_L03
M07_L12:
       mov       [rsp+50],r8
       lea       rdx,[rsp+28]
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
       mov       r8,rax
       jmp       short M07_L11
M07_L13:
       mov       rdx,7FF9231C9F98
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M07_L07
M07_L14:
       mov       rdx,rbx
       call      qword ptr [7FF9229E58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M07_L08
M07_L15:
       mov       rdx,rbx
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M07_L05
M07_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 589
```
```assembly
; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+18],rdx
       mov       r8,rdx
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       cmp       eax,1
       jle       short M08_L00
       mov       [rbp-10],rdx
       mov       [rbp-8],eax
       lea       rcx,[rbp-10]
       or        eax,1
       xor       edx,edx
       lzcnt     edx,eax
       xor       edx,1F
       lea       edx,[rdx*2+2]
       call      qword ptr [7FF922D3E340]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].IntroSort(System.Span`1<Int32>, Int32, System.Comparison`1<Int32>)
       nop
M08_L00:
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9231BFF00]
       lea       rax,[M08_L00]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       ecx,40
       call      qword ptr [7FF9231BFF18]
       lea       rax,[M08_L00]
       add       rsp,28
       ret
; Total bytes of code 133
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M09_L02
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M09_L01
M09_L00:
       add       rsp,28
       ret
M09_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L00
M09_L02:
       add       rsp,28
       jmp       qword ptr [7FF922F8F3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 49
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M10_L05
       mov       rcx,[rbx]
       cmp       rcx,rsi
       je        near ptr M10_L04
       mov       rax,21154800038
       mov       rax,[rax]
       add       rax,10
       rorx      rdx,rcx,20
       xor       rdx,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rdx,r8
       mov       r8d,[rax]
       shrx      rdx,rdx,r8
       xor       r8d,r8d
M10_L00:
       lea       r10d,[rdx+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rax+r10*8]
       mov       r9d,[r10]
       and       r9d,0FFFFFFFE
       cmp       [r10+8],rcx
       jne       short M10_L01
       mov       r11,rsi
       xor       r11,[r10+10]
       cmp       r11,1
       jbe       short M10_L03
M10_L01:
       test      r9d,r9d
       je        short M10_L02
       inc       r8d
       add       edx,r8d
       and       edx,[rax+4]
       cmp       r8d,8
       jl        short M10_L00
M10_L02:
       mov       rcx,7FF92322433C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF9229E6340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M10_L03:
       cmp       r9d,[r10]
       jne       short M10_L02
       cmp       r11d,1
       jne       short M10_L02
       mov       rcx,7FF923224330
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L05
M10_L04:
       mov       rcx,7FF923224338
       call      CORINFO_HELP_COUNTPROFILE32
M10_L05:
       mov       rcx,7FF923224334
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 246
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       rax,[rdx+20]
       ret
; Total bytes of code 5
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M12_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
       call      qword ptr [7FF9231BE4C0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       push      rbx
       sub       rsp,20
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       short M13_L03
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M13_L03
M13_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       je        short M13_L02
M13_L01:
       mov       rcx,7FF923222D10
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M13_L02:
       mov       rcx,21154800110
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M13_L05
       mov       rcx,211548000F0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M13_L04
       mov       rcx,7FF923222D18
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M13_L01
M13_L03:
       mov       ecx,2
       call      qword ptr [7FF9231BE0A0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M13_L00
M13_L04:
       mov       rcx,7FF923222D14
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF923222D10
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF922C05E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
M13_L05:
       mov       rcx,7FF923222D1C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M13_L01
; Total bytes of code 204
```
```assembly
; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r8d
       lea       rcx,[rbx+8]
       call      qword ptr [7FF982458FE8]; CORINFO_HELP_ASSIGN_REF
       test      esi,0DFFFFFC0
       jne       short M14_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M14_L00:
       call      qword ptr [7FF982463550]
       mov       rbx,rax
       call      qword ptr [7FF98246E1A8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 87
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M15_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M15_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M15_L01
       cmp       [r10],rcx
       je        short M15_L06
M15_L00:
       cmp       [r10+8],rcx
       je        short M15_L06
       cmp       [r10+10],rcx
       je        short M15_L06
       cmp       [r10+18],rcx
       je        short M15_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M15_L04
       test      r8,r8
       je        short M15_L03
M15_L01:
       cmp       [r10],rcx
       je        short M15_L06
M15_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M15_L03
       cmp       [r10],rcx
       je        short M15_L06
       jmp       short M15_L02
M15_L03:
       test      dword ptr [rax],500C0000
       je        short M15_L05
       jmp       qword ptr [7FF922D3F5B8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M15_L04:
       cmp       [r10],rcx
       je        short M15_L06
       jmp       short M15_L00
M15_L05:
       xor       edx,edx
M15_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M16_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M16_L06
M16_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FF9826037E0
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FF982943A90],0
       jne       short M16_L04
M16_L01:
       cmp       rdi,4000
       ja        short M16_L00
M16_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M16_L05
M16_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M16_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M16_L01
M16_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M16_L03
M16_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       je        short M16_L07
       call      CORINFO_HELP_POLL_GC
M16_L07:
       cmp       rdi,4000
       ja        short M16_L06
       jmp       short M16_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M17_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M17_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M17_L02
       test      r8b,18
       jne       short M17_L01
       test      r8b,4
       je        short M17_L00
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M17_L05
M17_L00:
       test      r8,r8
       je        short M17_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M17_L05
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M17_L05
M17_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M17_L05
M17_L02:
       cmp       r8,40
       ja        short M17_L06
M17_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M17_L09
M17_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M17_L05:
       vzeroupper
       ret
M17_L06:
       cmp       r8,800
       ja        near ptr M17_L12
       cmp       r8,100
       jae       short M17_L10
M17_L07:
       mov       r9,r8
       shr       r9,6
M17_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M17_L08
       and       r8,3F
       cmp       r8,10
       ja        short M17_L03
       jmp       short M17_L04
M17_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M17_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M17_L04
M17_L10:
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
       jmp       short M17_L07
M17_L11:
       cmp       rcx,rdx
       jne       short M17_L12
       cmp       [rdx],dl
       jmp       near ptr M17_L05
M17_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF9229E66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 318
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M18_L09
       test      rsi,rsi
       je        near ptr M18_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M18_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M18_L10
M18_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M18_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M18_L07
       sub       edi,eax
       js        near ptr M18_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M18_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M18_L06
       sub       ebp,eax
       js        near ptr M18_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M18_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M18_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98246A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M18_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M18_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M18_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M18_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246D930]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M18_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M18_L15
M18_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M18_L04:
       cmp       r8,4000
       jbe       short M18_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M18_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M18_L02
       jmp       near ptr M18_L14
M18_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M18_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M18_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M18_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M18_L10:
       call      qword ptr [7FF982463788]
       mov       rbx,rax
       call      qword ptr [7FF98246ED60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246D7C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M18_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF982481910]
       int       3
M18_L12:
       call      qword ptr [7FF982463550]
       mov       rdi,rax
       call      qword ptr [7FF98246DC18]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rdi
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M18_L13:
       call      qword ptr [7FF982463550]
       mov       rbp,rax
       call      qword ptr [7FF98246DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rbp
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M18_L14:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M18_L02
M18_L15:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M18_L03
M18_L16:
       call      qword ptr [7FF982463578]
       mov       rbx,rax
       call      qword ptr [7FF98246E6E0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246C240]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M19_L00
       ret
M19_L00:
       jmp       qword ptr [7FF9229E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark.OrderByWithComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,138
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       vmovdqa   xmmword ptr [rsp+rax+140],xmm4
       vmovdqa   xmmword ptr [rsp+rax+150],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,1C8A3C00A50
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L22
M00_L01:
       mov       rbp,[rbx+2E8]
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+8],eax
       lea       rcx,[r14+60]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L23
       xor       ecx,ecx
       mov       [r14+68],rcx
       lea       rcx,[r14+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       mov       rcx,1C8A3C00A78
       test      rdx,rdx
       cmove     rdx,[rcx]
       lea       rcx,[r14+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],0
       mov       rcx,[r14+60]
       call      qword ptr [7FF9230DF0F0]; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L24
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r15,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r14+78]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[r14+70]
       movzx     r8d,byte ptr [r14+90]
       mov       [rsp+134],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+134]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r14+68],0
       jne       near ptr M00_L25
M00_L02:
       mov       r14,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r14],rdx
       jne       near ptr M00_L27
       mov       rax,[r14+8]
       mov       [rsp+40],rax
       mov       rdx,1C8A3C00A68
       cmp       rax,[rdx]
       je        near ptr M00_L20
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        near ptr M00_L05
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L05
       mov       r10d,10
       mov       [rsp+5C],edi
M00_L03:
       vmovdqu   ymm0,ymmword ptr [rsi+r10]
       vmovdqu   ymmword ptr [rsp+90],ymm0
       vmovdqu   ymm0,ymmword ptr [rsi+r10+20]
       vmovdqu   ymmword ptr [rsp+0B0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsi+r10+40]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+90]
       vmovdqu   ymmword ptr [rsp+0E0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0B0]
       vmovdqu   ymmword ptr [rsp+100],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+120],xmm0
       mov       [rsp+60],r10
       lea       rcx,[rax+r10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0E0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10,[rsp+60]
       add       r10,50
       mov       r9d,[rsp+5C]
       dec       r9d
       mov       [rsp+5C],r9d
       je        near ptr M00_L07
       mov       rax,[rsp+38]
       jmp       near ptr M00_L03
M00_L04:
       mov       rax,[rsp+38]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L31
       mov       [rsp+130],r10d
       mov       r8d,r10d
       imul      r11,r8,50
       mov       [rsp+68],r11
       vmovdqu   ymm0,ymmword ptr [rsi+r11+10]
       vmovdqu   ymmword ptr [rsp+90],ymm0
       vmovdqu   ymm0,ymmword ptr [rsi+r11+30]
       vmovdqu   ymmword ptr [rsp+0B0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsi+r11+50]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],r8
       jne       near ptr M00_L26
       vmovdqu   ymm0,ymmword ptr [rsp+90]
       vmovdqu   ymmword ptr [rsp+0E0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0B0]
       vmovdqu   ymmword ptr [rsp+100],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+120],xmm0
M00_L06:
       mov       r11,[rsp+68]
       lea       rcx,[rax+r11+10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0E0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rsp+130]
       inc       r10d
       cmp       edi,r10d
       mov       r9,[rsp+40]
       jg        near ptr M00_L04
M00_L07:
       lea       rcx,[r14+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[r14+18]
       test      rcx,rcx
       jne       near ptr M00_L21
M00_L09:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       rcx,[rax+10]
       xor       edx,edx
       mov       r8d,r12d
       lea       r8,[rcx+r8*4]
       cmp       r12d,8
       jl        short M00_L11
       vmovups   ymm0,[7FF923188A00]
       vbroadcastss ymm1,dword ptr [7FF923188A20]
       lea       rdx,[r8-20]
M00_L10:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rdx
       jbe       short M00_L10
       vmovd     edx,xmm0
M00_L11:
       cmp       rcx,r8
       jb        near ptr M00_L18
M00_L12:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L30
       cmp       qword ptr [r14+18],0
       jne       short M00_L13
       mov       rcx,[r14+10]
       mov       rdx,1C8A3C00A78
       cmp       rcx,[rdx]
       je        near ptr M00_L28
M00_L13:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       rcx,r14
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231FE188
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+88],rax
       mov       r8,[rsp+30]
       lea       rcx,[r8+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rsp+30]
       mov       rcx,[rsp+88]
       mov       [r14+18],rcx
M00_L14:
       mov       rax,[rsp+48]
       lea       rcx,[rax+10]
       mov       [rsp+70],rcx
       mov       [rsp+78],r12d
       lea       rcx,[rsp+70]
       mov       rdx,r14
       call      qword ptr [7FF922D3E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M00_L15:
       mov       r14,[rsp+48]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L17
       cmp       edi,r13d
       jl        near ptr M00_L19
       xor       r12d,r12d
M00_L16:
       imul      rcx,r12,14
       add       rcx,r15
       cmp       [rcx],cl
       mov       eax,[r14+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L31
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,4
       dec       r13d
       jne       short M00_L16
M00_L17:
       mov       [rsp+80],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+80]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
       add       rsp,138
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L18:
       lea       r10d,[rdx+1]
       mov       [rcx],edx
       add       rcx,4
       cmp       rcx,r8
       mov       edx,r10d
       jb        short M00_L18
       jmp       near ptr M00_L12
M00_L19:
       mov       ecx,r12d
       imul      rcx,50
       add       rcx,r15
       cmp       [rcx],cl
       cmp       r12d,edi
       jae       near ptr M00_L31
       mov       edx,r12d
       mov       eax,[r14+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L31
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L19
       jmp       near ptr M00_L17
M00_L20:
       lea       rcx,[r14+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L21:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L22:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1C8A3C00A48
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1C8A3C00A50
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L23:
       mov       ecx,11
       call      qword ptr [7FF922C07E58]
       int       3
M00_L24:
       mov       rbp,rsi
       jmp       near ptr M00_L17
M00_L25:
       mov       rcx,[r14+68]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r14,rax
       mov       rax,r14
       jmp       near ptr M00_L02
M00_L26:
       lea       r8,[rsp+90]
       lea       rdx,[rsp+0E0]
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       rax,[rsp+38]
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L28:
       cmp       byte ptr [r14+28],0
       jne       short M00_L29
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+20],rdx
       mov       rcx,rdx
       mov       rdx,r14
       mov       r8,7FF9231B8F00
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r14,[rsp+20]
       jmp       near ptr M00_L14
M00_L29:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,7FF9231B8F18
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r14,[rsp+28]
       jmp       near ptr M00_L14
M00_L30:
       mov       rax,[rsp+48]
       lea       r9d,[r12-1]
       mov       rcx,r14
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r14]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       jmp       near ptr M00_L15
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1787
```
```assembly
; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M01_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,128
       xor       eax,eax
       mov       [rsp+68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       vmovdqu   ymmword ptr [rsp+0B0],ymm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       vmovdqu   ymmword ptr [rsp+0F0],ymm4
       vmovdqa   xmmword ptr [rsp+110],xmm4
       mov       rbx,rcx
       mov       rsi,rbx
       test      rsi,rsi
       je        short M01_L01
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [rsi],rdx
       je        short M01_L01
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
M01_L01:
       test      rsi,rsi
       jne       near ptr M01_L05
       mov       rsi,rbx
       test      rsi,rsi
       je        short M01_L02
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M01_L35
M01_L02:
       test      rsi,rsi
       je        near ptr M01_L43
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L36
       mov       ebx,[rsi+8]
M01_L03:
       test      ebx,ebx
       je        near ptr M01_L42
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L41
       mov       edi,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L40
       cmp       edi,[rsi+8]
       ja        near ptr M01_L40
       cmp       edi,[rbx+8]
       ja        near ptr M01_L40
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L39
       cmp       r8,4000
       ja        near ptr M01_L38
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L37
M01_L04:
       mov       rax,rbx
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M01_L34
       mov       rcx,[rsi+60]
       call      qword ptr [7FF9230DF0F0]
       mov       rbx,rax
       mov       edi,[rbx+8]
       cmp       edi,1
       jle       near ptr M01_L27
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,[rsi+78]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,[rsi+70]
       movzx     eax,byte ptr [rsi+90]
       mov       [rsp+124],eax
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rsp+124]
       mov       [r12+28],r13b
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       r13,r12
       cmp       qword ptr [rsi+68],0
       jne       near ptr M01_L28
M01_L06:
       mov       esi,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r13],rdx
       jne       near ptr M01_L30
       mov       rax,r13
       mov       r12,[rax+8]
       mov       rdx,1C8A3C00A68
       cmp       r12,[rdx]
       je        near ptr M01_L25
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+50],rax
       xor       r10d,r10d
       test      r12,r12
       je        near ptr M01_L09
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],rcx
       jne       near ptr M01_L09
       mov       r12d,10
       mov       [rsp+5C],edi
M01_L07:
       vmovdqu   ymm0,ymmword ptr [rbx+r12]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rbx+r12+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rbx+r12+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+80]
       vmovdqu   ymmword ptr [rsp+0D0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A0]
       vmovdqu   ymmword ptr [rsp+0F0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+110],xmm0
       lea       rcx,[rax+r12]
       cmp       [rcx],cl
       lea       rdx,[rsp+0D0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,50
       mov       r10d,[rsp+5C]
       dec       r10d
       mov       [rsp+5C],r10d
       je        near ptr M01_L11
       mov       rax,[rsp+50]
       jmp       near ptr M01_L07
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M01_L08:
       mov       rax,[rsp+50]
M01_L09:
       cmp       r10d,edi
       jae       near ptr M01_L44
       mov       [rsp+120],r10d
       mov       r8d,r10d
       imul      r9,r8,50
       mov       [rsp+60],r9
       vmovdqu   ymm0,ymmword ptr [rbx+r9+10]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rbx+r9+30]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rbx+r9+50]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],r8
       jne       near ptr M01_L29
       vmovdqu   ymm0,ymmword ptr [rsp+80]
       vmovdqu   ymmword ptr [rsp+0D0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A0]
       vmovdqu   ymmword ptr [rsp+0F0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+110],xmm0
M01_L10:
       mov       r9,[rsp+60]
       lea       rcx,[rax+r9+10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0D0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rsp+120]
       inc       r10d
       cmp       edi,r10d
       jg        near ptr M01_L08
M01_L11:
       lea       rcx,[r13+20]
       mov       rdx,[rsp+50]
       call      CORINFO_HELP_ASSIGN_REF
M01_L12:
       mov       rcx,[r13+18]
       test      rcx,rcx
       jne       near ptr M01_L26
M01_L13:
       mov       edx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rcx,[r12+10]
       xor       eax,eax
       mov       edx,esi
       lea       rdx,[rcx+rdx*4]
       cmp       esi,8
       jl        short M01_L15
       vmovups   ymm0,[7FF923187E00]
       vbroadcastss ymm1,dword ptr [7FF923187E20]
       lea       rax,[rdx-20]
M01_L14:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rax
       jbe       short M01_L14
       vmovd     eax,xmm0
M01_L15:
       cmp       rcx,rdx
       jb        near ptr M01_L23
M01_L16:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L33
       cmp       qword ptr [r13+18],0
       jne       short M01_L17
       mov       rcx,[r13+10]
       mov       rax,1C8A3C00A78
       cmp       rcx,[rax]
       je        near ptr M01_L31
M01_L17:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,r13
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF9231FE188
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+78],rax
       mov       r8,[rsp+48]
       lea       rcx,[r8+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsp+48]
       mov       rcx,[rsp+78]
       mov       [r13+18],rcx
M01_L18:
       lea       rcx,[r12+10]
       mov       [rsp+68],rcx
       mov       [rsp+70],esi
       lea       rcx,[rsp+68]
       mov       rdx,r13
       call      qword ptr [7FF922D3E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M01_L19:
       xor       esi,esi
       test      r15d,r15d
       jle       short M01_L21
       cmp       edi,r15d
       jl        short M01_L24
       xor       esi,esi
M01_L20:
       imul      rcx,rsi,14
       add       rcx,r14
       cmp       [rcx],cl
       mov       r13d,[r12+rsi+10]
       cmp       r13d,edi
       jae       near ptr M01_L44
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rsi,4
       dec       r15d
       jne       short M01_L20
M01_L21:
       mov       rax,rbp
M01_L22:
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L23:
       lea       r8d,[rax+1]
       mov       [rcx],eax
       add       rcx,4
       cmp       rcx,rdx
       mov       eax,r8d
       jb        short M01_L23
       jmp       near ptr M01_L16
M01_L24:
       mov       ecx,esi
       imul      rcx,50
       add       rcx,r14
       cmp       [rcx],cl
       cmp       esi,edi
       jae       near ptr M01_L44
       mov       edx,esi
       mov       r13d,[r12+rdx*4+10]
       cmp       r13d,edi
       jae       near ptr M01_L44
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       esi
       cmp       esi,r15d
       jl        short M01_L24
       jmp       short M01_L21
M01_L25:
       lea       rcx,[rax+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L12
M01_L26:
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L13
M01_L27:
       mov       rax,rbx
       jmp       near ptr M01_L22
M01_L28:
       mov       rcx,[rsi+68]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M01_L06
M01_L29:
       lea       r8,[rsp+80]
       lea       rdx,[rsp+0D0]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       rax,[rsp+50]
       jmp       near ptr M01_L10
M01_L30:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L13
M01_L31:
       cmp       byte ptr [r13+28],0
       jne       short M01_L32
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+38],rdx
       mov       rcx,rdx
       mov       rdx,r13
       mov       r8,7FF9231B8F00
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r13,[rsp+38]
       jmp       near ptr M01_L18
M01_L32:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rcx,rax
       mov       rdx,r13
       mov       r8,7FF9231B8F18
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r13,[rsp+40]
       jmp       near ptr M01_L18
M01_L33:
       lea       r9d,[rsi-1]
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L19
M01_L34:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L36:
       mov       rcx,rsi
       mov       r11,7FF922930EA0
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L03
M01_L37:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L04
M01_L38:
       mov       rcx,rax
       call      qword ptr [7FF922F8EF28]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L04
M01_L39:
       mov       rcx,rax
       call      qword ptr [7FF9229E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L04
M01_L40:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923016AF0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L04
M01_L41:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922930EA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,1C8A3C00B48
       mov       rbx,[rax]
       jmp       near ptr M01_L04
M01_L43:
       mov       rcx,rbx
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9230DF210]
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2034
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       vmovdqu   ymm0,ymmword ptr [r8]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymm0,ymmword ptr [r8+20]
       vmovdqu   ymmword ptr [rdx+20],ymm0
       vmovdqu   xmm0,xmmword ptr [r8+40]
       vmovdqu   xmmword ptr [rdx+40],xmm0
       mov       rax,rdx
       vzeroupper
       ret
; Total bytes of code 38
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M03_L02
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M03_L01
M03_L00:
       add       rsp,28
       ret
M03_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L00
M03_L02:
       add       rsp,28
       jmp       qword ptr [7FF922F8EF28]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 49
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,1C88DC00A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M04_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M04_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M04_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M04_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L01:
       test      edi,edi
       je        short M04_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M04_L00
M04_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922B5FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```
```assembly
; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+18],rdx
       mov       r8,rdx
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       cmp       eax,1
       jle       short M05_L00
       mov       [rbp-10],rdx
       mov       [rbp-8],eax
       lea       rcx,[rbp-10]
       or        eax,1
       xor       edx,edx
       lzcnt     edx,eax
       xor       edx,1F
       lea       edx,[rdx*2+2]
       call      qword ptr [7FF922D3E340]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].IntroSort(System.Span`1<Int32>, Int32, System.Comparison`1<Int32>)
       nop
M05_L00:
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       rcx,[rbp+18]
       call      qword ptr [7FF923264F30]
       lea       rax,[M05_L00]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       ecx,40
       call      qword ptr [7FF923264F48]
       lea       rax,[M05_L00]
       add       rsp,28
       ret
; Total bytes of code 133
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
       call      qword ptr [7FF9231BDC80]
       int       3
; Total bytes of code 44
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark.OrderByWithoutComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0D8
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,1DC3C402A40
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L25
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rax,1DC3C400068
       mov       r14,[rax]
       mov       r15,r14
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+8],eax
       lea       rcx,[rbp+60]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L27
       xor       ecx,ecx
       mov       [rbp+68],rcx
       lea       rcx,[rbp+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[rbp+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+90],0
       mov       rcx,1DC3C402A48
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L26
M00_L01:
       mov       rcx,rbp
       mov       rdx,offset MT_System.Linq.IOrderedEnumerable<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF92320BF78
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       r8,r14
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r9d,r9d
       call      rax
       mov       rsi,rax
       mov       rdi,rsi
       test      rdi,rdi
       je        short M00_L02
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rdx
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
M00_L02:
       test      rdi,rdi
       jne       near ptr M00_L06
       mov       rdi,rsi
       test      rdi,rdi
       je        short M00_L03
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rdx
       jne       near ptr M00_L36
M00_L03:
       test      rdi,rdi
       je        near ptr M00_L44
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L37
       mov       esi,[rdi+8]
M00_L04:
       test      esi,esi
       je        near ptr M00_L43
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L42
       mov       ebp,[rdi+8]
       mov       rcx,[rdi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L41
       cmp       ebp,[rdi+8]
       ja        near ptr M00_L41
       cmp       ebp,[rsi+8]
       ja        near ptr M00_L41
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rdi+10]
       lea       rax,[rsi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L40
       cmp       r8,4000
       ja        near ptr M00_L39
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M00_L38
M00_L05:
       mov       [rsp+70],rsi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+70]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L06:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L35
       mov       rcx,[rdi+60]
       call      qword ptr [7FF9230EEF70]; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       rsi,rax
       mov       ebp,[rsi+8]
       cmp       ebp,1
       jle       near ptr M00_L28
       mov       edx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+78]
       mov       rcx,1DC3C400A08
       cmp       r12,[rcx]
       je        near ptr M00_L29
M00_L07:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+58],rax
       mov       rdx,[rdi+70]
       movzx     r8d,byte ptr [rdi+90]
       mov       [rsp+0D4],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+58]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+58]
       mov       ecx,[rsp+0D4]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+68],0
       je        short M00_L09
       mov       rcx,[rdi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L30
       mov       rdx,r12
       call      qword ptr [7FF92320A800]; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M00_L08:
       mov       rdi,rax
       mov       rax,rdi
M00_L09:
       mov       rdi,rax
       mov       r12d,ebp
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       mov       rax,[rdi+8]
       mov       [rsp+48],rax
       mov       rdx,1DC3C402A50
       cmp       rax,[rdx]
       je        near ptr M00_L24
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+40],rax
       xor       r10d,r10d
       mov       r9,[rsp+48]
       test      r9,r9
       je        near ptr M00_L12
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L12
       nop       dword ptr [rax]
M00_L10:
       mov       edx,r10d
       imul      rdx,50
       lea       r9,[rsi+rdx+10]
       mov       r8,[r9+28]
       vmovdqu   ymm0,ymmword ptr [r9]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [r9+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [r9+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       [rsp+0D0],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+0D0]
       inc       r10d
       cmp       ebp,r10d
       jle       near ptr M00_L14
       mov       rax,[rsp+40]
       jmp       short M00_L10
       nop       dword ptr [rax+rax]
M00_L11:
       mov       rax,[rsp+40]
M00_L12:
       cmp       r10d,ebp
       jae       near ptr M00_L45
       mov       [rsp+0D0],r10d
       mov       edx,r10d
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rdx
       jne       near ptr M00_L31
M00_L13:
       mov       edx,[rsp+0D0]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+0D0]
       inc       ecx
       cmp       ebp,ecx
       mov       r10d,ecx
       mov       r9,[rsp+48]
       jg        near ptr M00_L11
M00_L14:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M00_L15
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L32
       mov       rdx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF92320D210]; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M00_L15:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+50],rax
       lea       rcx,[rax+10]
       xor       edx,edx
       mov       r8d,r12d
       lea       r8,[rcx+r8*4]
       cmp       r12d,8
       jl        short M00_L17
       vmovups   ymm0,[7FF92319D660]
       vbroadcastss ymm1,dword ptr [7FF92319D680]
       lea       rdx,[r8-20]
M00_L16:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rdx
       jbe       short M00_L16
       vmovd     edx,xmm0
M00_L17:
       cmp       rcx,r8
       jb        near ptr M00_L22
M00_L18:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L34
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       mov       rcx,rdi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF92320CB00
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+78],rax
       mov       r8,[rsp+38]
       lea       rcx,[r8+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rsp+38]
       mov       rcx,[rsp+78]
       mov       [rdi+18],rcx
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       [rsp+60],rcx
       mov       [rsp+68],r12d
       lea       rcx,[rsp+60]
       mov       rdx,rdi
       call      qword ptr [7FF922D4E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M00_L19:
       mov       rdi,[rsp+50]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L21
       cmp       ebp,r13d
       jl        short M00_L23
       xor       r12d,r12d
M00_L20:
       imul      rcx,r12,14
       add       rcx,r15
       cmp       [rcx],cl
       mov       eax,[rdi+r12+10]
       cmp       eax,ebp
       jae       near ptr M00_L45
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,4
       dec       r13d
       jne       short M00_L20
M00_L21:
       mov       rsi,r14
       jmp       near ptr M00_L05
M00_L22:
       lea       r10d,[rdx+1]
       mov       [rcx],edx
       add       rcx,4
       cmp       rcx,r8
       mov       edx,r10d
       jb        short M00_L22
       jmp       near ptr M00_L18
M00_L23:
       mov       ecx,r12d
       imul      rcx,50
       add       rcx,r15
       cmp       [rcx],cl
       cmp       r12d,ebp
       jae       near ptr M00_L45
       mov       edx,r12d
       mov       eax,[rdi+rdx*4+10]
       cmp       eax,ebp
       jae       near ptr M00_L45
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L23
       jmp       short M00_L21
M00_L24:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1DC3C402A30
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DC3C402A40
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1DC3C402A30
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DC3C402A48
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L27:
       mov       ecx,11
       call      qword ptr [7FF922C17E58]
       int       3
M00_L28:
       mov       r14,rsi
       jmp       near ptr M00_L21
M00_L29:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FF922C15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF922D4DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M00_L07
M00_L30:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L08
M00_L31:
       mov       [rsp+0A8],r8
       lea       rdx,[rsp+80]
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+40]
       jmp       near ptr M00_L13
M00_L32:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L15
M00_L33:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L15
M00_L34:
       mov       rax,[rsp+50]
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       jmp       near ptr M00_L19
M00_L35:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M00_L21
M00_L36:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L37:
       mov       rcx,rdi
       mov       r11,7FF922940F40
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L04
M00_L38:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rax
       call      qword ptr [7FF922F9F3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L05
M00_L40:
       mov       rcx,rax
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L05
M00_L41:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923026B20]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L05
M00_L42:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF922940F48
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L05
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1DC3C402B48
       mov       rsi,[rcx]
       jmp       near ptr M00_L05
M00_L44:
       mov       rcx,rsi
       call      qword ptr [7FF9230EF0C0]
       mov       rsi,rax
       jmp       near ptr M00_L05
M00_L45:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2230
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,1DC3C400A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M01_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M01_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L01:
       test      edi,edi
       je        short M01_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M01_L00
M01_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922B6FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
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
```assembly
; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M03_L00:
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
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       mov       rbx,rcx
       mov       rsi,rbx
       test      rsi,rsi
       je        short M03_L01
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rdx
       je        short M03_L01
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
M03_L01:
       test      rsi,rsi
       jne       near ptr M03_L05
       mov       rsi,rbx
       test      rsi,rsi
       je        short M03_L02
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M03_L32
M03_L02:
       test      rsi,rsi
       je        near ptr M03_L40
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M03_L33
       mov       ebx,[rsi+8]
M03_L03:
       test      ebx,ebx
       je        near ptr M03_L39
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M03_L38
       mov       edi,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M03_L37
       cmp       edi,[rsi+8]
       ja        near ptr M03_L37
       cmp       edi,[rbx+8]
       ja        near ptr M03_L37
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M03_L36
       cmp       r8,4000
       ja        near ptr M03_L35
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M03_L34
M03_L04:
       mov       rax,rbx
       vzeroupper
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
M03_L05:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M03_L31
       mov       rcx,[rsi+60]
       call      qword ptr [7FF9230EEF70]
       mov       rbx,rax
       mov       edi,[rbx+8]
       cmp       edi,1
       jle       near ptr M03_L24
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,[rsi+78]
       mov       rcx,1DC3C400A08
       cmp       r13,[rcx]
       je        near ptr M03_L25
M03_L06:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,[rsi+70]
       movzx     eax,byte ptr [rsi+90]
       mov       [rsp+0B4],eax
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rsp+0B4]
       mov       [r12+28],r13b
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       r13,r12
       cmp       qword ptr [rsi+68],0
       je        short M03_L07
       mov       rcx,[rsi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M03_L26
       mov       rdx,r12
       call      qword ptr [7FF92320A800]; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       r13,rax
M03_L07:
       mov       esi,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [r13],rdx
       jne       near ptr M03_L29
       mov       rdx,r13
       mov       r12,[rdx+8]
       mov       rdx,1DC3C402A50
       cmp       r12,[rdx]
       je        near ptr M03_L23
       mov       edx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+40],rax
       xor       r10d,r10d
       test      r12,r12
       je        near ptr M03_L10
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],rdx
       jne       near ptr M03_L10
M03_L08:
       mov       edx,r10d
       imul      rdx,50
       lea       r12,[rbx+rdx+10]
       mov       r8,[r12+28]
       vmovdqu   ymm0,ymmword ptr [r12]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [r12+20]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   xmm0,xmmword ptr [r12+40]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       [rsp+0B0],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r12d,[rsp+0B0]
       inc       r12d
       cmp       edi,r12d
       mov       r10d,r12d
       jle       near ptr M03_L12
       mov       rax,[rsp+40]
       jmp       short M03_L08
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M03_L09:
       mov       rax,[rsp+40]
M03_L10:
       cmp       r10d,edi
       jae       near ptr M03_L41
       mov       [rsp+0B0],r10d
       mov       edx,r10d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],rdx
       jne       near ptr M03_L27
M03_L11:
       mov       edx,[rsp+0B0]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+0B0]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       jg        short M03_L09
M03_L12:
       lea       rcx,[r13+20]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r13+18]
       test      rcx,rcx
       je        short M03_L13
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M03_L28
       mov       rdx,rbx
       mov       r8d,esi
       call      qword ptr [7FF92320D210]; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M03_L13:
       mov       edx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rcx,[r12+10]
       xor       eax,eax
       mov       edx,esi
       lea       rdx,[rcx+rdx*4]
       cmp       esi,8
       jl        short M03_L15
       vmovups   ymm0,[7FF92319C6A0]
       vbroadcastss ymm1,dword ptr [7FF92319C6C0]
       lea       rax,[rdx-20]
M03_L14:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rax
       jbe       short M03_L14
       vmovd     eax,xmm0
M03_L15:
       cmp       rcx,rdx
       jb        near ptr M03_L21
M03_L16:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [r13],rcx
       jne       near ptr M03_L30
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       mov       rcx,r13
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF92320CB00
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+58],rax
       mov       r8,[rsp+38]
       lea       rcx,[r8+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsp+38]
       mov       rcx,[rsp+58]
       mov       [r13+18],rcx
       lea       rcx,[r12+10]
       mov       [rsp+48],rcx
       mov       [rsp+50],esi
       lea       rcx,[rsp+48]
       mov       rdx,r13
       call      qword ptr [7FF922D4E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M03_L17:
       xor       esi,esi
       test      r15d,r15d
       jle       short M03_L19
       cmp       edi,r15d
       jl        short M03_L22
       xor       esi,esi
M03_L18:
       imul      rcx,rsi,14
       add       rcx,r14
       cmp       [rcx],cl
       mov       r13d,[r12+rsi+10]
       cmp       r13d,edi
       jae       near ptr M03_L41
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rsi,4
       dec       r15d
       jne       short M03_L18
M03_L19:
       mov       rax,rbp
M03_L20:
       vzeroupper
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
M03_L21:
       lea       r8d,[rax+1]
       mov       [rcx],eax
       add       rcx,4
       cmp       rcx,rdx
       mov       eax,r8d
       jb        short M03_L21
       jmp       near ptr M03_L16
M03_L22:
       mov       ecx,esi
       imul      rcx,50
       add       rcx,r14
       cmp       [rcx],cl
       cmp       esi,edi
       jae       near ptr M03_L41
       mov       edx,esi
       mov       r13d,[r12+rdx*4+10]
       cmp       r13d,edi
       jae       near ptr M03_L41
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       esi
       cmp       esi,r15d
       jl        short M03_L22
       jmp       short M03_L19
M03_L23:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M03_L24:
       mov       rax,rbx
       jmp       near ptr M03_L20
M03_L25:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF922C15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FF922D4DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M03_L06
M03_L26:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M03_L07
M03_L27:
       mov       [rsp+88],r8
       lea       rdx,[rsp+60]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       r8,rax
       mov       rax,[rsp+40]
       jmp       near ptr M03_L11
M03_L28:
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M03_L13
M03_L29:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M03_L13
M03_L30:
       lea       r9d,[rsi-1]
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M03_L17
M03_L31:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M03_L32:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M03_L02
M03_L33:
       mov       rcx,rsi
       mov       r11,7FF922940F30
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M03_L03
M03_L34:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L04
M03_L35:
       mov       rcx,rax
       call      qword ptr [7FF922F9F3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L04
M03_L36:
       mov       rcx,rax
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L04
M03_L37:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923026B20]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M03_L04
M03_L38:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922940F38
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M03_L04
M03_L39:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,1DC3C402B48
       mov       rbx,[rax]
       jmp       near ptr M03_L04
M03_L40:
       mov       rcx,rbx
       vzeroupper
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9230EF0C0]
M03_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1850
```
```assembly
; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M04_L00:
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rbx+78]
       mov       rbp,[rbx]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.String
       cmp       [rcx+8],rax
       jne       short M04_L01
       mov       rcx,1DC3C400A08
       cmp       rdi,[rcx]
       je        near ptr M04_L07
M04_L01:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M04_L06
M04_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+70]
       movzx     r14d,byte ptr [rbx+90]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+28],r14b
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbp
       mov       rsi,[rbx+68]
       test      rsi,rsi
       je        near ptr M04_L05
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M04_L12
       mov       rdi,[rsi+78]
       mov       rcx,1DC3C400A08
       cmp       rdi,[rcx]
       je        near ptr M04_L10
M04_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,[rsi+70]
       movzx     r15d,byte ptr [rsi+90]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+28],r15b
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
       cmp       qword ptr [rsi+68],0
       je        short M04_L04
       mov       rcx,[rsi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M04_L11
       mov       rdx,r14
       call      qword ptr [7FF92320A800]
       mov       rbp,rax
M04_L04:
       mov       rax,rbp
M04_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L06:
       mov       rcx,rbp
       mov       rdx,7FF9232105F8
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L07:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF922C15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF922D4DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rbp
       mov       rdx,7FF923210610
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M04_L09:
       mov       rdx,rdi
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M04_L01
M04_L10:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF922C15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF922D4DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M04_L03
M04_L11:
       mov       rdx,r14
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M04_L04
M04_L12:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M04_L04
; Total bytes of code 576
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       rax,[rdx+28]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M06_L03
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M06_L02
       cmp       rdx,[r8]
       jne       short M06_L01
M06_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M06_L01:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M06_L00
       jmp       short M06_L04
M06_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M06_L03:
       call      qword ptr [7FF9230E4C30]
       int       3
M06_L04:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229FD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 96
```
```assembly
; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M07_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,80
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       mov       [rsp+70],rax
       mov       [rsp+78],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rbp,[rsi+8]
       mov       rcx,1DC3C402A50
       cmp       rbp,[rcx]
       je        near ptr M07_L06
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M07_L09
       mov       rcx,rax
M07_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M07_L03
       test      rbx,rbx
       je        near ptr M07_L10
       test      rbp,rbp
       je        near ptr M07_L10
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [rbp+18],rdx
       jne       near ptr M07_L10
       cmp       [rbx+8],r13d
       jl        near ptr M07_L10
M07_L02:
       mov       edx,r15d
       imul      rdx,50
       lea       rbp,[rbx+rdx+10]
       mov       r8,[rbp+28]
       vmovdqu   ymm0,ymmword ptr [rbp]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovdqu   ymm0,ymmword ptr [rbp+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   xmm0,xmmword ptr [rbp+40]
       vmovdqu   xmmword ptr [rsp+68],xmm0
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M07_L02
M07_L03:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L04:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        short M07_L05
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M07_L15
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FF92320D210]
M07_L05:
       nop
       vzeroupper
       add       rsp,80
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L06:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M07_L13
       mov       rcx,rax
M07_L07:
       mov       rdx,rbx
       test      rdx,rdx
       je        short M07_L08
       cmp       [rdx],rcx
       jne       near ptr M07_L14
M07_L08:
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L04
M07_L09:
       mov       rdx,7FF923210958
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M07_L01
M07_L10:
       cmp       r15d,[rbx+8]
       jae       near ptr M07_L16
       mov       edx,r15d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+68],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [rbp+18],rdx
       jne       short M07_L12
M07_L11:
       mov       edx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M07_L10
       jmp       near ptr M07_L03
M07_L12:
       mov       [rsp+50],r8
       lea       rdx,[rsp+28]
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
       mov       r8,rax
       jmp       short M07_L11
M07_L13:
       mov       rdx,7FF923210958
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M07_L07
M07_L14:
       mov       rdx,rbx
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M07_L08
M07_L15:
       mov       rdx,rbx
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M07_L05
M07_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 589
```
```assembly
; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+18],rdx
       mov       r8,rdx
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       cmp       eax,1
       jle       short M08_L00
       mov       [rbp-10],rdx
       mov       [rbp-8],eax
       lea       rcx,[rbp-10]
       or        eax,1
       xor       edx,edx
       lzcnt     edx,eax
       xor       edx,1F
       lea       edx,[rdx*2+2]
       call      qword ptr [7FF922D4E340]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].IntroSort(System.Span`1<Int32>, Int32, System.Comparison`1<Int32>)
       nop
M08_L00:
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       rcx,[rbp+18]
       call      qword ptr [7FF923285080]
       lea       rax,[M08_L00]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       ecx,40
       call      qword ptr [7FF923285098]
       lea       rax,[M08_L00]
       add       rsp,28
       ret
; Total bytes of code 133
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M09_L02
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M09_L01
M09_L00:
       add       rsp,28
       ret
M09_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L00
M09_L02:
       add       rsp,28
       jmp       qword ptr [7FF922F9F3C0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 49
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M10_L05
       mov       rcx,[rbx]
       cmp       rcx,rsi
       je        near ptr M10_L04
       mov       rax,1DC3C400038
       mov       rax,[rax]
       add       rax,10
       rorx      rdx,rcx,20
       xor       rdx,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rdx,r8
       mov       r8d,[rax]
       shrx      rdx,rdx,r8
       xor       r8d,r8d
M10_L00:
       lea       r10d,[rdx+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rax+r10*8]
       mov       r9d,[r10]
       and       r9d,0FFFFFFFE
       cmp       [r10+8],rcx
       jne       short M10_L01
       mov       r11,rsi
       xor       r11,[r10+10]
       cmp       r11,1
       jbe       short M10_L03
M10_L01:
       test      r9d,r9d
       je        short M10_L02
       inc       r8d
       add       edx,r8d
       and       edx,[rax+4]
       cmp       r8d,8
       jl        short M10_L00
M10_L02:
       mov       rcx,7FF92323DC14
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF9229F6340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M10_L03:
       cmp       r9d,[r10]
       jne       short M10_L02
       cmp       r11d,1
       jne       short M10_L02
       mov       rcx,7FF92323DC08
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L05
M10_L04:
       mov       rcx,7FF92323DC10
       call      CORINFO_HELP_COUNTPROFILE32
M10_L05:
       mov       rcx,7FF92323DC0C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 246
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       rax,[rdx+20]
       ret
; Total bytes of code 5
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M12_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
       call      qword ptr [7FF9231CEA30]
       int       3
; Total bytes of code 44
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       push      rbx
       sub       rsp,20
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       short M13_L03
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M13_L03
M13_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       je        short M13_L02
M13_L01:
       mov       rcx,7FF92323C620
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M13_L02:
       mov       rcx,1DC3C400110
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M13_L05
       mov       rcx,1DC3C4000F0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M13_L04
       mov       rcx,7FF92323C628
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M13_L01
M13_L03:
       mov       ecx,2
       call      qword ptr [7FF9231CE628]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M13_L00
M13_L04:
       mov       rcx,7FF92323C624
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF92323C620
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF922C15E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
M13_L05:
       mov       rcx,7FF92323C62C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M13_L01
; Total bytes of code 204
```
```assembly
; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r8d
       lea       rcx,[rbx+8]
       call      qword ptr [7FF982458FE8]; CORINFO_HELP_ASSIGN_REF
       test      esi,0DFFFFFC0
       jne       short M14_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M14_L00:
       call      qword ptr [7FF982463550]
       mov       rbx,rax
       call      qword ptr [7FF98246E1A8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 87
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M15_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M15_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M15_L01
       cmp       [r10],rcx
       je        short M15_L06
M15_L00:
       cmp       [r10+8],rcx
       je        short M15_L06
       cmp       [r10+10],rcx
       je        short M15_L06
       cmp       [r10+18],rcx
       je        short M15_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M15_L04
       test      r8,r8
       je        short M15_L03
M15_L01:
       cmp       [r10],rcx
       je        short M15_L06
M15_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M15_L03
       cmp       [r10],rcx
       je        short M15_L06
       jmp       short M15_L02
M15_L03:
       test      dword ptr [rax],500C0000
       je        short M15_L05
       jmp       qword ptr [7FF922D4F5B8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M15_L04:
       cmp       [r10],rcx
       je        short M15_L06
       jmp       short M15_L00
M15_L05:
       xor       edx,edx
M15_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M16_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M16_L06
M16_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FF9826037E0
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FF982943A90],0
       jne       short M16_L04
M16_L01:
       cmp       rdi,4000
       ja        short M16_L00
M16_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M16_L05
M16_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M16_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M16_L01
M16_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M16_L03
M16_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       je        short M16_L07
       call      CORINFO_HELP_POLL_GC
M16_L07:
       cmp       rdi,4000
       ja        short M16_L06
       jmp       short M16_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M17_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M17_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M17_L03
       test      r8b,18
       jne       short M17_L01
       test      r8b,4
       jne       short M17_L00
       test      r8,r8
       je        short M17_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M17_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M17_L02
M17_L00:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M17_L02
M17_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
M17_L02:
       vzeroupper
       ret
M17_L03:
       cmp       r8,40
       ja        short M17_L07
M17_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M17_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M17_L06
M17_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M17_L02
M17_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M17_L05
M17_L07:
       cmp       r8,800
       ja        short M17_L11
       cmp       r8,100
       jb        short M17_L08
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
M17_L08:
       mov       r9,r8
       shr       r9,6
M17_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M17_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M17_L04
       jmp       near ptr M17_L05
M17_L10:
       cmp       rcx,rdx
       jne       short M17_L11
       cmp       [rdx],dl
       jmp       near ptr M17_L02
M17_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF9229F66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 317
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M18_L09
       test      rsi,rsi
       je        near ptr M18_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M18_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M18_L10
M18_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M18_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M18_L07
       sub       edi,eax
       js        near ptr M18_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M18_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M18_L06
       sub       ebp,eax
       js        near ptr M18_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M18_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M18_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98246A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M18_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M18_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M18_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M18_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246D930]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M18_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M18_L15
M18_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M18_L04:
       cmp       r8,4000
       jbe       short M18_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M18_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M18_L02
       jmp       near ptr M18_L14
M18_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M18_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M18_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M18_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M18_L10:
       call      qword ptr [7FF982463788]
       mov       rbx,rax
       call      qword ptr [7FF98246ED60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246D7C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M18_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF982481910]
       int       3
M18_L12:
       call      qword ptr [7FF982463550]
       mov       rdi,rax
       call      qword ptr [7FF98246DC18]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rdi
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M18_L13:
       call      qword ptr [7FF982463550]
       mov       rbp,rax
       call      qword ptr [7FF98246DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rbp
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M18_L14:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M18_L02
M18_L15:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M18_L03
M18_L16:
       call      qword ptr [7FF982463578]
       mov       rbx,rax
       call      qword ptr [7FF98246E6E0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246C240]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M19_L00
       ret
M19_L00:
       jmp       qword ptr [7FF9229F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark.OrderByWithComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,138
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       vmovdqa   xmmword ptr [rsp+rax+140],xmm4
       vmovdqa   xmmword ptr [rsp+rax+150],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,25A72800AE8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L22
M00_L01:
       mov       rbp,[rbx+2E8]
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+8],eax
       lea       rcx,[r14+60]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L23
       xor       ecx,ecx
       mov       [r14+68],rcx
       lea       rcx,[r14+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       mov       rcx,25A72800B10
       test      rdx,rdx
       cmove     rdx,[rcx]
       lea       rcx,[r14+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],0
       mov       rcx,[r14+60]
       call      qword ptr [7FF923215890]; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L24
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r15,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r14+78]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[r14+70]
       movzx     r8d,byte ptr [r14+90]
       mov       [rsp+134],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+134]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r14+68],0
       jne       near ptr M00_L25
M00_L02:
       mov       r14,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r14],rdx
       jne       near ptr M00_L27
       mov       rax,[r14+8]
       mov       [rsp+40],rax
       mov       rdx,25A72800B00
       cmp       rax,[rdx]
       je        near ptr M00_L20
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        near ptr M00_L05
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L05
       mov       r10d,10
       mov       [rsp+5C],edi
M00_L03:
       vmovdqu   ymm0,ymmword ptr [rsi+r10]
       vmovdqu   ymmword ptr [rsp+90],ymm0
       vmovdqu   ymm0,ymmword ptr [rsi+r10+20]
       vmovdqu   ymmword ptr [rsp+0B0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsi+r10+40]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+90]
       vmovdqu   ymmword ptr [rsp+0E0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0B0]
       vmovdqu   ymmword ptr [rsp+100],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+120],xmm0
       mov       [rsp+60],r10
       lea       rcx,[rax+r10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0E0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10,[rsp+60]
       add       r10,50
       mov       r9d,[rsp+5C]
       dec       r9d
       mov       [rsp+5C],r9d
       je        near ptr M00_L07
       mov       rax,[rsp+38]
       jmp       near ptr M00_L03
M00_L04:
       mov       rax,[rsp+38]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L31
       mov       [rsp+130],r10d
       mov       r8d,r10d
       imul      r11,r8,50
       mov       [rsp+68],r11
       vmovdqu   ymm0,ymmword ptr [rsi+r11+10]
       vmovdqu   ymmword ptr [rsp+90],ymm0
       vmovdqu   ymm0,ymmword ptr [rsi+r11+30]
       vmovdqu   ymmword ptr [rsp+0B0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsi+r11+50]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],r8
       jne       near ptr M00_L26
       vmovdqu   ymm0,ymmword ptr [rsp+90]
       vmovdqu   ymmword ptr [rsp+0E0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0B0]
       vmovdqu   ymmword ptr [rsp+100],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+120],xmm0
M00_L06:
       mov       r11,[rsp+68]
       lea       rcx,[rax+r11+10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0E0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rsp+130]
       inc       r10d
       cmp       edi,r10d
       mov       r9,[rsp+40]
       jg        near ptr M00_L04
M00_L07:
       lea       rcx,[r14+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[r14+18]
       test      rcx,rcx
       jne       near ptr M00_L21
M00_L09:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       rcx,[rax+10]
       xor       edx,edx
       mov       r8d,r12d
       lea       r8,[rcx+r8*4]
       cmp       r12d,8
       jl        short M00_L11
       vmovups   ymm0,[7FF9232D7000]
       vbroadcastss ymm1,dword ptr [7FF9232D7020]
       lea       rdx,[r8-20]
M00_L10:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rdx
       jbe       short M00_L10
       vmovd     edx,xmm0
M00_L11:
       cmp       rcx,r8
       jae       short M00_L13
M00_L12:
       lea       r10d,[rdx+1]
       mov       [rcx],edx
       add       rcx,4
       cmp       rcx,r8
       mov       edx,r10d
       jb        short M00_L12
M00_L13:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M00_L30
       cmp       qword ptr [r14+18],0
       jne       short M00_L14
       mov       rcx,[r14+10]
       mov       rdx,25A72800B10
       cmp       rcx,[rdx]
       je        near ptr M00_L28
M00_L14:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       rcx,r14
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF92328BFD8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+88],rax
       mov       r8,[rsp+30]
       lea       rcx,[r8+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rsp+30]
       mov       rcx,[rsp+88]
       mov       [r14+18],rcx
M00_L15:
       mov       rax,[rsp+48]
       lea       rcx,[rax+10]
       mov       [rsp+70],rcx
       mov       [rsp+78],r12d
       lea       rcx,[rsp+70]
       mov       rdx,r14
       call      qword ptr [7FF922D5E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M00_L16:
       mov       r14,[rsp+48]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L18
       cmp       edi,r13d
       jl        short M00_L19
       xor       r12d,r12d
M00_L17:
       imul      rcx,r12,14
       add       rcx,r15
       cmp       [rcx],cl
       mov       eax,[r14+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L31
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,4
       dec       r13d
       jne       short M00_L17
M00_L18:
       mov       [rsp+80],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+80]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
       add       rsp,138
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L19:
       mov       ecx,r12d
       imul      rcx,50
       add       rcx,r15
       cmp       [rcx],cl
       cmp       r12d,edi
       jae       near ptr M00_L31
       mov       edx,r12d
       mov       eax,[r14+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L31
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L19
       jmp       near ptr M00_L18
M00_L20:
       lea       rcx,[r14+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L21:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L22:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,25A72800AE0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25A72800AE8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L23:
       mov       ecx,11
       call      qword ptr [7FF922C27E58]
       int       3
M00_L24:
       mov       rbp,rsi
       jmp       near ptr M00_L18
M00_L25:
       mov       rcx,[r14+68]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r14,rax
       mov       rax,r14
       jmp       near ptr M00_L02
M00_L26:
       lea       r8,[rsp+90]
       lea       rdx,[rsp+0E0]
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       rax,[rsp+38]
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L28:
       cmp       byte ptr [r14+28],0
       jne       short M00_L29
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+20],rdx
       mov       rcx,rdx
       mov       rdx,r14
       mov       r8,7FF92321B5A0
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r14,[rsp+20]
       jmp       near ptr M00_L15
M00_L29:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,7FF92321B5B8
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r14,[rsp+28]
       jmp       near ptr M00_L15
M00_L30:
       mov       rax,[rsp+48]
       lea       r9d,[r12-1]
       mov       rcx,r14
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r14]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       jmp       near ptr M00_L16
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1774
```
```assembly
; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M01_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,128
       xor       eax,eax
       mov       [rsp+68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       vmovdqu   ymmword ptr [rsp+0B0],ymm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       vmovdqu   ymmword ptr [rsp+0F0],ymm4
       vmovdqa   xmmword ptr [rsp+110],xmm4
       mov       rbx,rcx
       mov       rsi,rbx
       test      rsi,rsi
       je        short M01_L01
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [rsi],rdx
       je        short M01_L01
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
M01_L01:
       test      rsi,rsi
       jne       near ptr M01_L05
       mov       rsi,rbx
       test      rsi,rsi
       je        short M01_L02
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M01_L35
M01_L02:
       test      rsi,rsi
       je        near ptr M01_L43
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L36
       mov       ebx,[rsi+8]
M01_L03:
       test      ebx,ebx
       je        near ptr M01_L42
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L41
       mov       edi,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L40
       cmp       edi,[rsi+8]
       ja        near ptr M01_L40
       cmp       edi,[rbx+8]
       ja        near ptr M01_L40
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L39
       cmp       r8,4000
       ja        near ptr M01_L38
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L37
M01_L04:
       mov       rax,rbx
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M01_L34
       mov       rcx,[rsi+60]
       call      qword ptr [7FF923215890]
       mov       rbx,rax
       mov       edi,[rbx+8]
       cmp       edi,1
       jle       near ptr M01_L27
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,[rsi+78]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,[rsi+70]
       movzx     eax,byte ptr [rsi+90]
       mov       [rsp+124],eax
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rsp+124]
       mov       [r12+28],r13b
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       r13,r12
       cmp       qword ptr [rsi+68],0
       jne       near ptr M01_L28
M01_L06:
       mov       esi,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r13],rdx
       jne       near ptr M01_L30
       mov       rax,r13
       mov       r12,[rax+8]
       mov       rdx,25A72800B00
       cmp       r12,[rdx]
       je        near ptr M01_L25
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+50],rax
       xor       r10d,r10d
       test      r12,r12
       je        near ptr M01_L09
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],rcx
       jne       near ptr M01_L09
       mov       r12d,10
       mov       [rsp+5C],edi
M01_L07:
       vmovdqu   ymm0,ymmword ptr [rbx+r12]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rbx+r12+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rbx+r12+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       vmovdqu   ymm0,ymmword ptr [rsp+80]
       vmovdqu   ymmword ptr [rsp+0D0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A0]
       vmovdqu   ymmword ptr [rsp+0F0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+110],xmm0
       lea       rcx,[rax+r12]
       cmp       [rcx],cl
       lea       rdx,[rsp+0D0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,50
       mov       r10d,[rsp+5C]
       dec       r10d
       mov       [rsp+5C],r10d
       je        near ptr M01_L11
       mov       rax,[rsp+50]
       jmp       near ptr M01_L07
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M01_L08:
       mov       rax,[rsp+50]
M01_L09:
       cmp       r10d,edi
       jae       near ptr M01_L44
       mov       [rsp+120],r10d
       mov       r8d,r10d
       imul      r9,r8,50
       mov       [rsp+60],r9
       vmovdqu   ymm0,ymmword ptr [rbx+r9+10]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rbx+r9+30]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rbx+r9+50]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],r8
       jne       near ptr M01_L29
       vmovdqu   ymm0,ymmword ptr [rsp+80]
       vmovdqu   ymmword ptr [rsp+0D0],ymm0
       vmovdqu   ymm0,ymmword ptr [rsp+0A0]
       vmovdqu   ymmword ptr [rsp+0F0],ymm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+110],xmm0
M01_L10:
       mov       r9,[rsp+60]
       lea       rcx,[rax+r9+10]
       cmp       [rcx],cl
       lea       rdx,[rsp+0D0]
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,[rsp+120]
       inc       r10d
       cmp       edi,r10d
       jg        near ptr M01_L08
M01_L11:
       lea       rcx,[r13+20]
       mov       rdx,[rsp+50]
       call      CORINFO_HELP_ASSIGN_REF
M01_L12:
       mov       rcx,[r13+18]
       test      rcx,rcx
       jne       near ptr M01_L26
M01_L13:
       mov       edx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rcx,[r12+10]
       xor       eax,eax
       mov       edx,esi
       lea       rdx,[rcx+rdx*4]
       cmp       esi,8
       jl        short M01_L15
       vmovups   ymm0,[7FF9232D5A40]
       vbroadcastss ymm1,dword ptr [7FF9232D5A60]
       lea       rax,[rdx-20]
M01_L14:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rax
       jbe       short M01_L14
       vmovd     eax,xmm0
M01_L15:
       cmp       rcx,rdx
       jae       short M01_L17
M01_L16:
       lea       r8d,[rax+1]
       mov       [rcx],eax
       add       rcx,4
       cmp       rcx,rdx
       mov       eax,r8d
       jb        short M01_L16
M01_L17:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M01_L33
       cmp       qword ptr [r13+18],0
       jne       short M01_L18
       mov       rcx,[r13+10]
       mov       rax,25A72800B10
       cmp       rcx,[rax]
       je        near ptr M01_L31
M01_L18:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,r13
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF92328BFD8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+78],rax
       mov       r8,[rsp+48]
       lea       rcx,[r8+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsp+48]
       mov       rcx,[rsp+78]
       mov       [r13+18],rcx
M01_L19:
       lea       rcx,[r12+10]
       mov       [rsp+68],rcx
       mov       [rsp+70],esi
       lea       rcx,[rsp+68]
       mov       rdx,r13
       call      qword ptr [7FF922D5E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M01_L20:
       xor       esi,esi
       test      r15d,r15d
       jle       short M01_L22
       cmp       edi,r15d
       jl        short M01_L24
       xor       esi,esi
M01_L21:
       imul      rcx,rsi,14
       add       rcx,r14
       cmp       [rcx],cl
       mov       r13d,[r12+rsi+10]
       cmp       r13d,edi
       jae       near ptr M01_L44
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rsi,4
       dec       r15d
       jne       short M01_L21
M01_L22:
       mov       rax,rbp
M01_L23:
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       ecx,esi
       imul      rcx,50
       add       rcx,r14
       cmp       [rcx],cl
       cmp       esi,edi
       jae       near ptr M01_L44
       mov       edx,esi
       mov       r13d,[r12+rdx*4+10]
       cmp       r13d,edi
       jae       near ptr M01_L44
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       esi
       cmp       esi,r15d
       jl        short M01_L24
       jmp       short M01_L22
M01_L25:
       lea       rcx,[rax+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L12
M01_L26:
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L13
M01_L27:
       mov       rax,rbx
       jmp       near ptr M01_L23
M01_L28:
       mov       rcx,[rsi+68]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M01_L06
M01_L29:
       lea       r8,[rsp+80]
       lea       rdx,[rsp+0D0]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       rax,[rsp+50]
       jmp       near ptr M01_L10
M01_L30:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L13
M01_L31:
       cmp       byte ptr [r13+28],0
       jne       short M01_L32
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rsp+38],rdx
       mov       rcx,rdx
       mov       rdx,r13
       mov       r8,7FF92321B5A0
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r13,[rsp+38]
       jmp       near ptr M01_L19
M01_L32:
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rcx,rax
       mov       rdx,r13
       mov       r8,7FF92321B5B8
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       r13,[rsp+40]
       jmp       near ptr M01_L19
M01_L33:
       lea       r9d,[rsi-1]
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L20
M01_L34:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M01_L02
M01_L36:
       mov       rcx,rsi
       mov       r11,7FF922951010
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L03
M01_L37:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L04
M01_L38:
       mov       rcx,rax
       call      qword ptr [7FF922FAEF28]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L04
M01_L39:
       mov       rcx,rax
       call      qword ptr [7FF922A05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L04
M01_L40:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923036AF0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L04
M01_L41:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922951018
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,25A72800B50
       mov       rbx,[rax]
       jmp       near ptr M01_L04
M01_L43:
       mov       rcx,rbx
       vzeroupper
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF923215AD0]
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2025
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       vmovdqu   ymm0,ymmword ptr [r8]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymm0,ymmword ptr [r8+20]
       vmovdqu   ymmword ptr [rdx+20],ymm0
       vmovdqu   xmm0,xmmword ptr [r8+40]
       vmovdqu   xmmword ptr [rdx+40],xmm0
       mov       rax,rdx
       vzeroupper
       ret
; Total bytes of code 38
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M03_L02
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M03_L01
M03_L00:
       add       rsp,28
       ret
M03_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L00
M03_L02:
       add       rsp,28
       jmp       qword ptr [7FF922FAEF28]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 49
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,25A5C800A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M04_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M04_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M04_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M04_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L01:
       test      edi,edi
       je        short M04_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M04_L00
M04_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922B7FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
```
```assembly
; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+18],rdx
       mov       r8,rdx
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       cmp       eax,1
       jle       short M05_L00
       mov       [rbp-10],rdx
       mov       [rbp-8],eax
       lea       rcx,[rbp-10]
       or        eax,1
       xor       edx,edx
       lzcnt     edx,eax
       xor       edx,1F
       lea       edx,[rdx*2+2]
       call      qword ptr [7FF922D5E340]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].IntroSort(System.Span`1<Int32>, Int32, System.Comparison`1<Int32>)
       nop
M05_L00:
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9232B5320]
       lea       rax,[M05_L00]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       ecx,40
       call      qword ptr [7FF9232B5338]
       lea       rax,[M05_L00]
       add       rsp,28
       ret
; Total bytes of code 133
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
       call      qword ptr [7FF9230F6370]
       int       3
; Total bytes of code 44
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark.OrderByWithoutComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0D8
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,12AB5400AF0
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L25
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rax,12A9F400068
       mov       r14,[rax]
       mov       r15,r14
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+8],eax
       lea       rcx,[rbp+60]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L27
       xor       ecx,ecx
       mov       [rbp+68],rcx
       lea       rcx,[rbp+70]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[rbp+78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+90],0
       mov       rcx,12AB5400AF8
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L26
M00_L01:
       mov       rcx,rbp
       mov       rdx,offset MT_System.Linq.IOrderedEnumerable<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF923280490
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       r8,r14
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r9d,r9d
       call      rax
       mov       rsi,rax
       mov       rdi,rsi
       test      rdi,rdi
       je        short M00_L02
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rdx
       je        short M00_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
M00_L02:
       test      rdi,rdi
       jne       near ptr M00_L06
       mov       rdi,rsi
       test      rdi,rdi
       je        short M00_L03
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rdx
       jne       near ptr M00_L36
M00_L03:
       test      rdi,rdi
       je        near ptr M00_L44
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L37
       mov       esi,[rdi+8]
M00_L04:
       test      esi,esi
       je        near ptr M00_L43
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L42
       mov       ebp,[rdi+8]
       mov       rcx,[rdi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L41
       cmp       ebp,[rdi+8]
       ja        near ptr M00_L41
       cmp       ebp,[rsi+8]
       ja        near ptr M00_L41
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rdi+10]
       lea       rax,[rsi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L40
       cmp       r8,4000
       ja        near ptr M00_L39
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M00_L38
M00_L05:
       mov       [rsp+70],rsi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+70]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L06:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L35
       mov       rcx,[rdi+60]
       call      qword ptr [7FF9231F5A28]; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       rsi,rax
       mov       ebp,[rsi+8]
       cmp       ebp,1
       jle       near ptr M00_L28
       mov       edx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+78]
       mov       rcx,12A9F400A08
       cmp       r12,[rcx]
       je        near ptr M00_L29
M00_L07:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+58],rax
       mov       rdx,[rdi+70]
       movzx     r8d,byte ptr [rdi+90]
       mov       [rsp+0D4],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+58]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+58]
       mov       ecx,[rsp+0D4]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+68],0
       je        short M00_L09
       mov       rcx,[rdi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L30
       mov       rdx,r12
       call      qword ptr [7FF92326ECA8]; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M00_L08:
       mov       rdi,rax
       mov       rax,rdi
M00_L09:
       mov       rdi,rax
       mov       r12d,ebp
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       mov       rax,[rdi+8]
       mov       [rsp+48],rax
       mov       rdx,12AB5400B00
       cmp       rax,[rdx]
       je        near ptr M00_L24
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+40],rax
       xor       r10d,r10d
       mov       r9,[rsp+48]
       test      r9,r9
       je        near ptr M00_L12
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L12
       nop       dword ptr [rax]
M00_L10:
       mov       edx,r10d
       imul      rdx,50
       lea       r9,[rsi+rdx+10]
       mov       r8,[r9+28]
       vmovdqu   ymm0,ymmword ptr [r9]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [r9+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [r9+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       [rsp+0D0],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+0D0]
       inc       r10d
       cmp       ebp,r10d
       jle       near ptr M00_L14
       mov       rax,[rsp+40]
       jmp       short M00_L10
       nop       dword ptr [rax+rax]
M00_L11:
       mov       rax,[rsp+40]
M00_L12:
       cmp       r10d,ebp
       jae       near ptr M00_L45
       mov       [rsp+0D0],r10d
       mov       edx,r10d
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r9+18],rdx
       jne       near ptr M00_L31
M00_L13:
       mov       edx,[rsp+0D0]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+0D0]
       inc       ecx
       cmp       ebp,ecx
       mov       r10d,ecx
       mov       r9,[rsp+48]
       jg        near ptr M00_L11
M00_L14:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M00_L15
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L32
       mov       rdx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF923281728]; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M00_L15:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+50],rax
       lea       rcx,[rax+10]
       xor       edx,edx
       mov       r8d,r12d
       lea       r8,[rcx+r8*4]
       cmp       r12d,8
       jl        short M00_L17
       vmovups   ymm0,[7FF9232C9000]
       vbroadcastss ymm1,dword ptr [7FF9232C9020]
       lea       rdx,[r8-20]
M00_L16:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rdx
       jbe       short M00_L16
       vmovd     edx,xmm0
M00_L17:
       cmp       rcx,r8
       jae       short M00_L19
M00_L18:
       lea       r10d,[rdx+1]
       mov       [rcx],edx
       add       rcx,4
       cmp       rcx,r8
       mov       edx,r10d
       jb        short M00_L18
M00_L19:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rdi],rcx
       jne       near ptr M00_L34
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       mov       rcx,rdi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF923281018
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+78],rax
       mov       r8,[rsp+38]
       lea       rcx,[r8+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rsp+38]
       mov       rcx,[rsp+78]
       mov       [rdi+18],rcx
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       [rsp+60],rcx
       mov       [rsp+68],r12d
       lea       rcx,[rsp+60]
       mov       rdx,rdi
       call      qword ptr [7FF922D3E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M00_L20:
       mov       rdi,[rsp+50]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L22
       cmp       ebp,r13d
       jl        short M00_L23
       xor       r12d,r12d
M00_L21:
       imul      rcx,r12,14
       add       rcx,r15
       cmp       [rcx],cl
       mov       eax,[rdi+r12+10]
       cmp       eax,ebp
       jae       near ptr M00_L45
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,4
       dec       r13d
       jne       short M00_L21
M00_L22:
       mov       rsi,r14
       jmp       near ptr M00_L05
M00_L23:
       mov       ecx,r12d
       imul      rcx,50
       add       rcx,r15
       cmp       [rcx],cl
       cmp       r12d,ebp
       jae       near ptr M00_L45
       mov       edx,r12d
       mov       eax,[rdi+rdx*4+10]
       cmp       eax,ebp
       jae       near ptr M00_L45
       mov       edx,eax
       imul      rdx,50
       lea       rdx,[rsi+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L23
       jmp       short M00_L22
M00_L24:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,12AB5400AE0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,12AB5400AF0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,12AB5400AE0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,12AB5400AF8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L27:
       mov       ecx,11
       call      qword ptr [7FF922C07E58]
       int       3
M00_L28:
       mov       r14,rsi
       jmp       near ptr M00_L22
M00_L29:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FF922C05DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF922D3DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M00_L07
M00_L30:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L08
M00_L31:
       mov       [rsp+0A8],r8
       lea       rdx,[rsp+80]
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+40]
       jmp       near ptr M00_L13
M00_L32:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L15
M00_L33:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L15
M00_L34:
       mov       rax,[rsp+50]
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       jmp       near ptr M00_L20
M00_L35:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M00_L22
M00_L36:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L37:
       mov       rcx,rdi
       mov       r11,7FF922930F90
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L04
M00_L38:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L05
M00_L39:
       mov       rcx,rax
       call      qword ptr [7FF922F8EF10]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L05
M00_L40:
       mov       rcx,rax
       call      qword ptr [7FF9229E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L05
M00_L41:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923016AC0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L05
M00_L42:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF922930F98
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L05
M00_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,12AB5400B58
       mov       rsi,[rcx]
       jmp       near ptr M00_L05
M00_L44:
       mov       rcx,rsi
       call      qword ptr [7FF9231F5B78]
       mov       rsi,rax
       jmp       near ptr M00_L05
M00_L45:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2220
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       mov       rax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       r10d,eax
       mov       r9d,r8d
       ror       r9d,5
       add       r10d,r9d
       mov       r9,12A9F400A10
       mov       r9,[r9]
       mov       r9,[r9+8]
       movsxd    r11,r10d
       mov       rbx,9E3779B97F4A7C15
       imul      r11,rbx
       movzx     ebx,byte ptr [r9+10]
       shrx      r11,r11,rbx
       xor       ebx,ebx
M01_L00:
       lea       esi,[r11+1]
       movsxd    rsi,esi
       imul      rsi,30
       lea       rsi,[r9+rsi+10]
       mov       edi,[rsi]
       mov       ebp,[rsi+8]
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       mov       r13,[rsi+20]
       cmp       r10d,ebp
       jne       short M01_L01
       mov       rbp,rax
       sub       rbp,r14
       mov       r14,rdx
       sub       r14,r15
       or        rbp,r14
       mov       r14,r8
       sub       r14,r13
       or        rbp,r14
       jne       short M01_L01
       mov       rax,[rsi+28]
       and       edi,0FFFFFFFE
       cmp       edi,[rsi]
       jne       short M01_L02
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L01:
       test      edi,edi
       je        short M01_L02
       inc       ebx
       add       r11d,ebx
       mov       esi,[r9+8]
       add       esi,0FFFFFFFE
       and       r11d,esi
       cmp       ebx,8
       jl        short M01_L00
M01_L02:
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922B5FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 205
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
```assembly
; System.Linq.Enumerable.ToArray[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M03_L00:
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
       mov       [rsp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       mov       rbx,rcx
       mov       rsi,rbx
       test      rsi,rsi
       je        short M03_L01
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rdx
       je        short M03_L01
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
M03_L01:
       test      rsi,rsi
       jne       near ptr M03_L05
       mov       rsi,rbx
       test      rsi,rsi
       je        short M03_L02
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rdx
       jne       near ptr M03_L32
M03_L02:
       test      rsi,rsi
       je        near ptr M03_L40
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M03_L33
       mov       ebx,[rsi+8]
M03_L03:
       test      ebx,ebx
       je        near ptr M03_L39
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M03_L38
       mov       edi,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M03_L37
       cmp       edi,[rsi+8]
       ja        near ptr M03_L37
       cmp       edi,[rbx+8]
       ja        near ptr M03_L37
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M03_L36
       cmp       r8,4000
       ja        near ptr M03_L35
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M03_L34
M03_L04:
       mov       rax,rbx
       vzeroupper
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
M03_L05:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M03_L31
       mov       rcx,[rsi+60]
       call      qword ptr [7FF9231F5A28]
       mov       rbx,rax
       mov       edi,[rbx+8]
       cmp       edi,1
       jle       near ptr M03_L24
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.ValueTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,[rsi+78]
       mov       rcx,12A9F400A08
       cmp       r13,[rcx]
       je        near ptr M03_L25
M03_L06:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,[rsi+70]
       movzx     eax,byte ptr [rsi+90]
       mov       [rsp+0B4],eax
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rsp+0B4]
       mov       [r12+28],r13b
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       r13,r12
       cmp       qword ptr [rsi+68],0
       je        short M03_L07
       mov       rcx,[rsi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M03_L26
       mov       rdx,r12
       call      qword ptr [7FF92326ECA8]; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
       mov       r13,rax
M03_L07:
       mov       esi,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [r13],rdx
       jne       near ptr M03_L29
       mov       rdx,r13
       mov       r12,[rdx+8]
       mov       rdx,12AB5400B00
       cmp       r12,[rdx]
       je        near ptr M03_L23
       mov       edx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+40],rax
       xor       r10d,r10d
       test      r12,r12
       je        near ptr M03_L10
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],rdx
       jne       near ptr M03_L10
M03_L08:
       mov       edx,r10d
       imul      rdx,50
       lea       r12,[rbx+rdx+10]
       mov       r8,[r12+28]
       vmovdqu   ymm0,ymmword ptr [r12]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [r12+20]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   xmm0,xmmword ptr [r12+40]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       [rsp+0B0],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r12d,[rsp+0B0]
       inc       r12d
       cmp       edi,r12d
       mov       r10d,r12d
       jle       near ptr M03_L12
       mov       rax,[rsp+40]
       jmp       short M03_L08
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M03_L09:
       mov       rax,[rsp+40]
M03_L10:
       cmp       r10d,edi
       jae       near ptr M03_L41
       mov       [rsp+0B0],r10d
       mov       edx,r10d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [r12+18],rdx
       jne       near ptr M03_L27
M03_L11:
       mov       edx,[rsp+0B0]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+0B0]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       jg        short M03_L09
M03_L12:
       lea       rcx,[r13+20]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r13+18]
       test      rcx,rcx
       je        short M03_L13
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M03_L28
       mov       rdx,rbx
       mov       r8d,esi
       call      qword ptr [7FF923281728]; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M03_L13:
       mov       edx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rcx,[r12+10]
       xor       eax,eax
       mov       edx,esi
       lea       rdx,[rcx+rdx*4]
       cmp       esi,8
       jl        short M03_L15
       vmovups   ymm0,[7FF9232C7FA0]
       vbroadcastss ymm1,dword ptr [7FF9232C7FC0]
       lea       rax,[rdx-20]
M03_L14:
       vmovups   [rcx],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       rcx,20
       cmp       rcx,rax
       jbe       short M03_L14
       vmovd     eax,xmm0
M03_L15:
       cmp       rcx,rdx
       jae       short M03_L17
M03_L16:
       lea       r8d,[rax+1]
       mov       [rcx],eax
       add       rcx,4
       cmp       rcx,rdx
       mov       eax,r8d
       jb        short M03_L16
M03_L17:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [r13],rcx
       jne       near ptr M03_L30
       mov       rcx,offset MT_System.Comparison<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       mov       rcx,r13
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       mov       r8,7FF923281018
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       [rsp+58],rax
       mov       r8,[rsp+38]
       lea       rcx,[r8+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsp+38]
       mov       rcx,[rsp+58]
       mov       [r13+18],rcx
       lea       rcx,[r12+10]
       mov       [rsp+48],rcx
       mov       [rsp+50],esi
       lea       rcx,[rsp+48]
       mov       rdx,r13
       call      qword ptr [7FF922D3E310]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M03_L18:
       xor       esi,esi
       test      r15d,r15d
       jle       short M03_L20
       cmp       edi,r15d
       jl        short M03_L22
       xor       esi,esi
M03_L19:
       imul      rcx,rsi,14
       add       rcx,r14
       cmp       [rcx],cl
       mov       r13d,[r12+rsi+10]
       cmp       r13d,edi
       jae       near ptr M03_L41
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rsi,4
       dec       r15d
       jne       short M03_L19
M03_L20:
       mov       rax,rbp
M03_L21:
       vzeroupper
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
M03_L22:
       mov       ecx,esi
       imul      rcx,50
       add       rcx,r14
       cmp       [rcx],cl
       cmp       esi,edi
       jae       near ptr M03_L41
       mov       edx,esi
       mov       r13d,[r12+rdx*4+10]
       cmp       r13d,edi
       jae       near ptr M03_L41
       mov       edx,r13d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       cmp       [rdx],dl
       mov       r8d,50
       vzeroupper
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       inc       esi
       cmp       esi,r15d
       jl        short M03_L22
       jmp       short M03_L20
M03_L23:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M03_L24:
       mov       rax,rbx
       jmp       short M03_L21
M03_L25:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF922C05DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FF922D3DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M03_L06
M03_L26:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M03_L07
M03_L27:
       mov       [rsp+88],r8
       lea       rdx,[rsp+60]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       r8,rax
       mov       rax,[rsp+40]
       jmp       near ptr M03_L11
M03_L28:
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M03_L13
M03_L29:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M03_L13
M03_L30:
       lea       r9d,[rsi-1]
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M03_L18
M03_L31:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M03_L32:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M03_L02
M03_L33:
       mov       rcx,rsi
       mov       r11,7FF922930F80
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M03_L03
M03_L34:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L04
M03_L35:
       mov       rcx,rax
       call      qword ptr [7FF922F8EF10]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L04
M03_L36:
       mov       rcx,rax
       call      qword ptr [7FF9229E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L04
M03_L37:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923016AC0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M03_L04
M03_L38:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922930F88
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M03_L04
M03_L39:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,12AB5400B58
       mov       rbx,[rax]
       jmp       near ptr M03_L04
M03_L40:
       mov       rcx,rbx
       vzeroupper
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9231F5B78]
M03_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1837
```
```assembly
; System.Linq.Enumerable+OrderedIterator`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person>)
M04_L00:
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rbx+78]
       mov       rbp,[rbx]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.String
       cmp       [rcx+8],rax
       jne       short M04_L01
       mov       rcx,12A9F400A08
       cmp       rdi,[rcx]
       je        near ptr M04_L07
M04_L01:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M04_L06
M04_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+70]
       movzx     r14d,byte ptr [rbx+90]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+28],r14b
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbp
       mov       rsi,[rbx+68]
       test      rsi,rsi
       je        near ptr M04_L05
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M04_L12
       mov       rdi,[rsi+78]
       mov       rcx,12A9F400A08
       cmp       rdi,[rcx]
       je        near ptr M04_L10
M04_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,[rsi+70]
       movzx     r15d,byte ptr [rsi+90]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+28],r15b
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
       cmp       qword ptr [rsi+68],0
       je        short M04_L04
       mov       rcx,[rsi+68]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M04_L11
       mov       rdx,r14
       call      qword ptr [7FF92326ECA8]
       mov       rbp,rax
M04_L04:
       mov       rax,rbp
M04_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L06:
       mov       rcx,rbp
       mov       rdx,7FF9232733E8
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L02
M04_L07:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF922C05DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF922D3DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rbp
       mov       rdx,7FF923273400
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M04_L09:
       mov       rdx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M04_L01
M04_L10:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF922C05DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF922D3DD10]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M04_L03
M04_L11:
       mov       rdx,r14
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M04_L04
M04_L12:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M04_L04
; Total bytes of code 575
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       rax,[rdx+28]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M06_L02
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M06_L01
       cmp       rdx,[r8]
       je        short M06_L00
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       jne       short M06_L03
M06_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M06_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M06_L02:
       call      qword ptr [7FF9230D4BE8]
       int       3
M06_L03:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229ED8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Linq.Enumerable+EnumerableSorter`2[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.10.Tester],[System.__Canon, System.Private.CoreLib]].ComputeKeys(DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], Int32)
M07_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,80
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       mov       [rsp+70],rax
       mov       [rsp+78],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rbp,[rsi+8]
       mov       rcx,12AB5400B00
       cmp       rbp,[rcx]
       je        near ptr M07_L06
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M07_L09
       mov       rcx,rax
M07_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M07_L03
       test      rbx,rbx
       je        near ptr M07_L10
       test      rbp,rbp
       je        near ptr M07_L10
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [rbp+18],rdx
       jne       near ptr M07_L10
       cmp       [rbx+8],r13d
       jl        near ptr M07_L10
M07_L02:
       mov       edx,r15d
       imul      rdx,50
       lea       rbp,[rbx+rdx+10]
       mov       r8,[rbp+28]
       vmovdqu   ymm0,ymmword ptr [rbp]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovdqu   ymm0,ymmword ptr [rbp+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   xmm0,xmmword ptr [rbp+40]
       vmovdqu   xmmword ptr [rsp+68],xmm0
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M07_L02
M07_L03:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L04:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        short M07_L05
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.ValueTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M07_L15
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FF923281728]
M07_L05:
       nop
       vzeroupper
       add       rsp,80
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L06:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M07_L13
       mov       rcx,rax
M07_L07:
       mov       rdx,rbx
       test      rdx,rdx
       je        short M07_L08
       cmp       [rdx],rcx
       jne       near ptr M07_L14
M07_L08:
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L04
M07_L09:
       mov       rdx,7FF923273748
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M07_L01
M07_L10:
       cmp       r15d,[rbx+8]
       jae       near ptr M07_L16
       mov       edx,r15d
       imul      rdx,50
       lea       rdx,[rbx+rdx+10]
       mov       r8,[rdx+28]
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rsp+28],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   xmm0,xmmword ptr [rdx+40]
       vmovdqu   xmmword ptr [rsp+68],xmm0
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       cmp       [rbp+18],rdx
       jne       short M07_L12
M07_L11:
       mov       edx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M07_L10
       jmp       near ptr M07_L03
M07_L12:
       mov       [rsp+50],r8
       lea       rdx,[rsp+28]
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
       mov       r8,rax
       jmp       short M07_L11
M07_L13:
       mov       rdx,7FF923273748
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M07_L07
M07_L14:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M07_L08
M07_L15:
       mov       rdx,rbx
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M07_L05
M07_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 588
```
```assembly
; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+18],rdx
       mov       r8,rdx
       mov       rdx,[rcx]
       mov       eax,[rcx+8]
       cmp       eax,1
       jle       short M08_L00
       mov       [rbp-10],rdx
       mov       [rbp-8],eax
       lea       rcx,[rbp-10]
       or        eax,1
       xor       edx,edx
       lzcnt     edx,eax
       xor       edx,1F
       lea       edx,[rdx*2+2]
       call      qword ptr [7FF922D3E340]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].IntroSort(System.Span`1<Int32>, Int32, System.Comparison`1<Int32>)
       nop
M08_L00:
       add       rsp,30
       pop       rbp
       ret
       sub       rsp,28
       mov       rcx,[rbp+18]
       call      qword ptr [7FF923295458]
       lea       rax,[M08_L00]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       ecx,40
       call      qword ptr [7FF923295470]
       lea       rax,[M08_L00]
       add       rsp,28
       ret
; Total bytes of code 133
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M09_L02
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M09_L01
M09_L00:
       add       rsp,28
       ret
M09_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M09_L00
M09_L02:
       add       rsp,28
       jmp       qword ptr [7FF922F8EF10]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 49
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M10_L00
       mov       rax,[rdx]
       cmp       rax,rcx
       jne       short M10_L01
M10_L00:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M10_L01:
       mov       r8,12A9F400038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M10_L02:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       and       ebx,0FFFFFFFE
       cmp       [r11+8],rax
       jne       short M10_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       jbe       short M10_L04
M10_L03:
       test      ebx,ebx
       je        short M10_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M10_L02
       jmp       short M10_L05
M10_L04:
       cmp       ebx,[r11]
       jne       short M10_L05
       cmp       esi,1
       je        near ptr M10_L00
M10_L05:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF9229E6340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 156
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonValComparerByIdThenLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       rax,[rdx+20]
       ret
; Total bytes of code 5
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M12_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
       call      qword ptr [7FF9230D6820]
       int       3
; Total bytes of code 44
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       short M13_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M13_L02
M13_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M13_L01
       mov       rax,12A9F400110
       mov       rax,[rax]
       test      rax,rax
       jne       short M13_L01
       mov       rax,12A9F4000F0
       mov       rax,[rax]
       test      rax,rax
       je        short M13_L03
M13_L01:
       add       rsp,28
       ret
M13_L02:
       mov       ecx,2
       call      qword ptr [7FF9230D6418]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M13_L00
M13_L03:
       add       rsp,28
       jmp       qword ptr [7FF922C05E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 115
```
```assembly
; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r8d
       lea       rcx,[rbx+8]
       call      qword ptr [7FF982458FE8]; CORINFO_HELP_ASSIGN_REF
       test      esi,0DFFFFFC0
       jne       short M14_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M14_L00:
       call      qword ptr [7FF982463550]
       mov       rbx,rax
       call      qword ptr [7FF98246E1A8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 87
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M15_L00
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M15_L06
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M15_L04
       cmp       [r10],rcx
       jne       short M15_L01
M15_L00:
       mov       rax,rdx
       ret
M15_L01:
       cmp       [r10+8],rcx
       je        short M15_L00
       jmp       short M15_L03
M15_L02:
       cmp       [r10],rcx
       je        short M15_L00
       jmp       short M15_L01
M15_L03:
       cmp       [r10+10],rcx
       je        short M15_L00
       cmp       [r10+18],rcx
       je        short M15_L00
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M15_L02
       test      r8,r8
       je        short M15_L06
M15_L04:
       cmp       [r10],rcx
       je        short M15_L00
M15_L05:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M15_L06
       cmp       [r10],rcx
       je        short M15_L00
       jmp       short M15_L05
M15_L06:
       test      dword ptr [rax],500C0000
       jne       short M15_L07
       xor       edx,edx
       jmp       short M15_L00
M15_L07:
       jmp       qword ptr [7FF922D3F5B8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 125
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M16_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M16_L06
M16_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FF9826037E0
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FF982943A90],0
       jne       short M16_L04
M16_L01:
       cmp       rdi,4000
       ja        short M16_L00
M16_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M16_L05
M16_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M16_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M16_L01
M16_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M16_L03
M16_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       je        short M16_L07
       call      CORINFO_HELP_POLL_GC
M16_L07:
       cmp       rdi,4000
       ja        short M16_L06
       jmp       short M16_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M17_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M17_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M17_L03
       test      r8b,18
       jne       short M17_L02
       test      r8b,4
       je        short M17_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M17_L00:
       vzeroupper
       ret
M17_L01:
       test      r8,r8
       je        short M17_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M17_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M17_L00
M17_L02:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M17_L00
M17_L03:
       cmp       r8,40
       ja        short M17_L07
M17_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M17_L06
M17_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M17_L00
M17_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M17_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M17_L05
M17_L07:
       cmp       r8,800
       ja        short M17_L11
       cmp       r8,100
       jb        short M17_L08
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
M17_L08:
       mov       r9,r8
       shr       r9,6
M17_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M17_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M17_L04
       jmp       near ptr M17_L05
M17_L10:
       cmp       rcx,rdx
       jne       short M17_L11
       cmp       [rdx],dl
       jmp       near ptr M17_L00
M17_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF9229E66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       ebp,r9d
       test      rbx,rbx
       je        near ptr M18_L09
       test      rsi,rsi
       je        near ptr M18_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M18_L00
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       edx,1
       test      ecx,ecx
       cmove     ecx,edx
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       eax,1
       test      edx,edx
       cmove     edx,eax
       cmp       ecx,edx
       jne       near ptr M18_L10
M18_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M18_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M18_L07
       sub       edi,eax
       js        near ptr M18_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M18_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M18_L06
       sub       ebp,eax
       js        near ptr M18_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M18_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M18_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98246A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M18_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M18_L16
       mov       [rsp+70],r14d
       mov       [rsp+78],eax
       mov       rcx,rbx
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,ebp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M18_L01:
       mov       rcx,[rbx]
       movzx     edx,word ptr [rcx]
       mov       r8d,r14d
       imul      r8,rdx
       lea       rax,[rbx+8]
       mov       r10,[rbx]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,edi
       imul      r10,rdx
       add       r10,rax
       lea       rax,[rsi+8]
       mov       r9,[rsi]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       short M18_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246D930]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M18_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M18_L15
M18_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M18_L04:
       cmp       r8,4000
       jbe       short M18_L05
       mov       rcx,rdx
       mov       rdx,r10
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M18_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M18_L02
       jmp       near ptr M18_L14
M18_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M18_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M18_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M18_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M18_L10:
       call      qword ptr [7FF982463788]
       mov       rbx,rax
       call      qword ptr [7FF98246ED60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246D7C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M18_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF982481910]
       int       3
M18_L12:
       call      qword ptr [7FF982463550]
       mov       rdi,rax
       call      qword ptr [7FF98246DC18]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rdi
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rdi
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M18_L13:
       call      qword ptr [7FF982463550]
       mov       rbp,rax
       call      qword ptr [7FF98246DC10]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbp
       call      qword ptr [7FF98246C1C0]
       mov       rcx,rbp
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M18_L14:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M18_L02
M18_L15:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M18_L03
M18_L16:
       call      qword ptr [7FF982463578]
       mov       rbx,rax
       call      qword ptr [7FF98246E6E0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246C240]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 734
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M19_L00
       ret
M19_L00:
       jmp       qword ptr [7FF9229E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

