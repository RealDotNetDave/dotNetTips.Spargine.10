## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark.OrderByWithComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rdi,rsi
       mov       rcx,2A125000A80
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M00_L16
M00_L00:
       mov       r14,[rbx+2E8]
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L17
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       test      rdx,rdx
       je        near ptr M00_L18
M00_L01:
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rdx,rsi
       mov       rcx,7FF9231B2080
       call      qword ptr [7FF922D4D080]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L19
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r15+30]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rdx,[r15+28]
       movzx     r8d,byte ptr [r15+48]
       mov       [rsp+54],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       mov       ecx,[rsp+54]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r15+20],0
       jne       near ptr M00_L20
M00_L02:
       mov       r15,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rdx
       jne       near ptr M00_L24
       mov       rax,[r15+8]
       mov       [rsp+30],rax
       mov       rdx,2A125000A90
       cmp       rax,[rdx]
       je        near ptr M00_L22
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       r9,[rsp+30]
       test      r9,r9
       je        short M00_L05
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L05
M00_L03:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,rdx
       mov       [rsp+50],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+50]
       inc       r10d
       cmp       edi,r10d
       jle       short M00_L07
       mov       rax,[rsp+28]
       jmp       short M00_L03
       nop       word ptr [rax+rax]
M00_L04:
       mov       rax,[rsp+28]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L26
       mov       [rsp+50],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L21
       mov       r8,rdx
M00_L06:
       mov       edx,[rsp+50]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+50]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+30]
       jg        short M00_L04
M00_L07:
       lea       rcx,[r15+20]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       jne       near ptr M00_L23
M00_L09:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L11
       vmovups   ymm0,[7FF9231821C0]
       lea       rcx,[rdx-20]
M00_L10:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,[7FF9231821E0]
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L10
       vmovd     ecx,xmm0
M00_L11:
       cmp       r9,rdx
       jb        near ptr M00_L25
M00_L12:
       lea       r9d,[r12-1]
       mov       rcx,r15
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r15]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       r15,[rsp+38]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L14
       cmp       edi,r13d
       jl        short M00_L15
       xor       r12d,r12d
M00_L13:
       lea       rcx,[r14+r12*2]
       mov       eax,[r15+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L13
M00_L14:
       mov       [rsp+48],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L15:
       mov       ecx,r12d
       lea       rcx,[r14+rcx*8]
       cmp       r12d,edi
       jae       near ptr M00_L26
       mov       edx,r12d
       mov       eax,[r15+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L15
       jmp       short M00_L14
M00_L16:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2A125000A78
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2A125000A80
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L17:
       mov       ecx,11
       call      qword ptr [7FF922C0C6F0]
       int       3
M00_L18:
       mov       rcx,offset MT_System.Collections.Generic.Comparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2A125000B68
       mov       rdx,[rcx]
       jmp       near ptr M00_L01
M00_L19:
       mov       rbp,rsi
       jmp       near ptr M00_L14
M00_L20:
       mov       rcx,[r15+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r15,rax
       mov       rax,r15
       jmp       near ptr M00_L02
M00_L21:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+28]
       jmp       near ptr M00_L06
M00_L22:
       lea       rcx,[r15+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L23:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L24:
       mov       rcx,r15
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L25:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L25
       jmp       near ptr M00_L12
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1132
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rdx
       jne       near ptr M01_L50
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L35
       mov       rcx,rax
       call      qword ptr [7FF922DD3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L19
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF92328A298
       call      qword ptr [7FF922C0C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L04:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L56
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L11
M01_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L12
M01_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L51
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L14
M01_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M01_L09:
       mov       rax,rbx
       vzeroupper
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
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF92328A130
       call      qword ptr [7FF922C0C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF92328A278
       call      qword ptr [7FF922C0C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF92328ACB8
       call      qword ptr [7FF922C0C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF92328AD78
       call      qword ptr [7FF922C0C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF92328AD80
       call      qword ptr [7FF922C0C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L42
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L36
       mov       ebx,[rsi+8]
M01_L16:
       test      ebx,ebx
       je        near ptr M01_L41
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L40
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L39
       cmp       ebp,[rsi+8]
       ja        near ptr M01_L39
       cmp       ebp,[rbx+8]
       ja        near ptr M01_L39
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L38
       cmp       r8,4000
       jbe       short M01_L17
       mov       rcx,rax
       call      qword ptr [7FF922E0EC58]
       jmp       short M01_L18
M01_L17:
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L37
M01_L18:
       mov       rax,rbx
M01_L19:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M01_L43
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+5C],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+5C]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       jne       near ptr M01_L44
M01_L20:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rdx
       jne       near ptr M01_L48
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,2A125000A90
       cmp       rax,[rdx]
       je        near ptr M01_L46
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M01_L23
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M01_L23
M01_L21:
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,rdx
       mov       [rsp+58],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+58]
       inc       r10d
       cmp       esi,r10d
       jle       short M01_L25
       mov       rax,[rsp+38]
       jmp       short M01_L21
M01_L22:
       mov       rax,[rsp+38]
M01_L23:
       cmp       r10d,esi
       jae       near ptr M01_L59
       mov       [rsp+58],r10d
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M01_L45
       mov       r8,rdx
M01_L24:
       mov       edx,[rsp+58]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+58]
       inc       ecx
       cmp       esi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M01_L22
M01_L25:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M01_L26:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       jne       near ptr M01_L47
M01_L27:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M01_L29
       vmovups   ymm0,[7FF92317F200]
       lea       rcx,[rdx-20]
M01_L28:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,[7FF92317F220]
       add       r9,20
       cmp       r9,rcx
       jbe       short M01_L28
       vmovd     ecx,xmm0
M01_L29:
       cmp       r9,rdx
       jb        near ptr M01_L49
M01_L30:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       ebp,ebp
       test      r13d,r13d
       jle       short M01_L32
       cmp       esi,r13d
       jl        short M01_L34
       xor       ebp,ebp
       nop
M01_L31:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M01_L59
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M01_L31
M01_L32:
       mov       rax,r14
M01_L33:
       vzeroupper
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
M01_L34:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M01_L59
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M01_L59
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M01_L34
       jmp       short M01_L32
M01_L35:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L36:
       mov       rcx,rsi
       mov       r11,7FF922930EA8
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L37:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L18
M01_L38:
       mov       rcx,rax
       call      qword ptr [7FF9229E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L18
M01_L39:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF922E0F168]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L18
M01_L40:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922930EB0
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L18
M01_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2A125000B60
       mov       rbx,[rdx]
       jmp       near ptr M01_L18
M01_L42:
       mov       rdx,rbx
       mov       rcx,7FF9232C6BC8
       call      qword ptr [7FF923255BA8]
       jmp       near ptr M01_L19
M01_L43:
       jmp       near ptr M01_L33
M01_L44:
       mov       rcx,[rdi+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rax,rdi
       jmp       near ptr M01_L20
M01_L45:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M01_L24
M01_L46:
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L26
M01_L47:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L27
M01_L48:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L27
M01_L49:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M01_L49
       jmp       near ptr M01_L30
M01_L50:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L51:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L52
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L52
       jmp       short M01_L53
M01_L52:
       mov       rcx,rsi
       mov       rdx,7FF92328AD58
       call      qword ptr [7FF922C0C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L53:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L54
       jmp       short M01_L55
M01_L54:
       mov       rdx,7FF922FDB048
       call      qword ptr [7FF922C0C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L55:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M01_L09
M01_L56:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L57
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L57
       jmp       short M01_L58
M01_L57:
       mov       rcx,rbx
       mov       rdx,7FF92328A240
       call      qword ptr [7FF922C0C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L58:
       mov       rdx,rsi
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF923255BA8]
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1889
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,rdx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L02
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L03
       cmp       rdx,[r8]
       jne       short M03_L01
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M03_L01:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229ED8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M03_L02:
       call      qword ptr [7FF922E0DFE0]
       int       3
M03_L03:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF922E0EB98]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FF9229E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark.OrderByWithoutComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rdi,rsi
       mov       rcx,1BCAE000A50
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M00_L16
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rax,1BC98000068
       mov       r15,[rax]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L17
       xor       ecx,ecx
       mov       [r14+20],rcx
       lea       rcx,[r14+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[r14+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+48],0
       mov       rdx,rsi
       mov       rcx,7FF9231252B8
       call      qword ptr [7FF922D5C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L18
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       r15,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r14+30]
       mov       rcx,1BC98000A08
       cmp       r12,[rcx]
       je        near ptr M00_L19
M00_L01:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rdx,[r14+28]
       movzx     r8d,byte ptr [r14+48]
       mov       [rsp+54],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       mov       ecx,[rsp+54]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r14+20],0
       jne       near ptr M00_L20
M00_L02:
       mov       r14,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [r14],rdx
       jne       near ptr M00_L24
       mov       rax,[r14+8]
       mov       [rsp+30],rax
       mov       rdx,1BCAE000A58
       cmp       rax,[rdx]
       je        near ptr M00_L22
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       r9,[rsp+30]
       test      r9,r9
       je        short M00_L05
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L05
M00_L03:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,[rdx+30]
       mov       [rsp+50],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+50]
       inc       r10d
       cmp       edi,r10d
       jle       short M00_L07
       mov       rax,[rsp+28]
       jmp       short M00_L03
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M00_L04:
       mov       rax,[rsp+28]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L26
       mov       [rsp+50],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L21
       mov       r8,[rdx+30]
M00_L06:
       mov       edx,[rsp+50]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+50]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+30]
       jg        short M00_L04
M00_L07:
       lea       rcx,[r14+20]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[r14+18]
       test      rcx,rcx
       jne       near ptr M00_L23
M00_L09:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L11
       vmovups   ymm0,[7FF9231755E0]
       vbroadcastss ymm1,dword ptr [7FF923175600]
       lea       rcx,[rdx-20]
M00_L10:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L10
       vmovd     ecx,xmm0
M00_L11:
       cmp       r9,rdx
       jb        near ptr M00_L25
M00_L12:
       lea       r9d,[r12-1]
       mov       rcx,r14
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r14]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       r14,[rsp+38]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L14
       cmp       edi,r13d
       jl        short M00_L15
       xor       r12d,r12d
M00_L13:
       lea       rcx,[r15+r12*2]
       mov       eax,[r14+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L13
M00_L14:
       mov       [rsp+48],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L15:
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8]
       cmp       r12d,edi
       jae       near ptr M00_L26
       mov       edx,r12d
       mov       eax,[r14+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L15
       jmp       short M00_L14
M00_L16:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1BCAE000A40
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1BCAE000A50
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L17:
       mov       ecx,11
       call      qword ptr [7FF922C27E58]
       int       3
M00_L18:
       mov       rbp,rsi
       jmp       near ptr M00_L14
M00_L19:
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
       call      qword ptr [7FF922D5DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M00_L01
M00_L20:
       mov       rcx,[r14+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r14,rax
       mov       rax,r14
       jmp       near ptr M00_L02
M00_L21:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+28]
       jmp       near ptr M00_L06
M00_L22:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[r14+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L23:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L24:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L25:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L25
       jmp       near ptr M00_L12
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1203
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M01_L52
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rax],rcx
       jne       near ptr M01_L35
       mov       rcx,rax
       call      qword ptr [7FF922DE3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L18
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF9232741B8
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L04:
       mov       rdx,rsi
       call      qword ptr [7FF922B7F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L58
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L11
M01_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L12
M01_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L53
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L14
M01_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M01_L09:
       mov       rax,rbx
       vzeroupper
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
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF923274050
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF923274198
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9232746B8
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF923274778
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF923274780
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B7F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L43
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L36
       mov       ebx,[rsi+8]
M01_L16:
       test      ebx,ebx
       je        near ptr M01_L42
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L41
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L40
       cmp       ebp,[rsi+8]
       ja        near ptr M01_L40
       cmp       ebp,[rbx+8]
       ja        near ptr M01_L40
       mov       r8d,ebp
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
M01_L17:
       mov       rax,rbx
M01_L18:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M01_L44
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,1BC98000A08
       cmp       r12,[rcx]
       je        near ptr M01_L45
M01_L19:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+5C],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+5C]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       jne       near ptr M01_L46
M01_L20:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M01_L50
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,1BCAE000A58
       cmp       rax,[rdx]
       je        near ptr M01_L48
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M01_L23
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M01_L23
M01_L21:
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,[rdx+30]
       mov       [rsp+58],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+58]
       inc       r10d
       cmp       esi,r10d
       jle       short M01_L25
       mov       rax,[rsp+38]
       jmp       short M01_L21
M01_L22:
       mov       rax,[rsp+38]
M01_L23:
       cmp       r10d,esi
       jae       near ptr M01_L61
       mov       [rsp+58],r10d
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M01_L47
       mov       r8,[rdx+30]
M01_L24:
       mov       edx,[rsp+58]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+58]
       inc       ecx
       cmp       esi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M01_L22
M01_L25:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M01_L26:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       jne       near ptr M01_L49
M01_L27:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M01_L29
       vmovups   ymm0,[7FF923171FE0]
       vbroadcastss ymm1,dword ptr [7FF923172000]
       lea       rcx,[rdx-20]
M01_L28:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M01_L28
       vmovd     ecx,xmm0
M01_L29:
       cmp       r9,rdx
       jb        near ptr M01_L51
M01_L30:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       ebp,ebp
       test      r13d,r13d
       jle       short M01_L32
       cmp       esi,r13d
       jl        short M01_L34
       xor       ebp,ebp
M01_L31:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M01_L61
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M01_L31
M01_L32:
       mov       rax,r14
M01_L33:
       vzeroupper
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
M01_L34:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M01_L61
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M01_L61
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M01_L34
       jmp       short M01_L32
M01_L35:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L36:
       mov       rcx,rsi
       mov       r11,7FF922950DA8
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L37:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L17
M01_L38:
       mov       rcx,rax
       call      qword ptr [7FF922FAF360]
       jmp       near ptr M01_L17
M01_L39:
       mov       rcx,rax
       call      qword ptr [7FF922A05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L40:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923036AC0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L17
M01_L41:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922950DB0
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1BCAE000AF0
       mov       rbx,[rdx]
       jmp       near ptr M01_L17
M01_L43:
       mov       rdx,rbx
       mov       rcx,7FF923297E78
       call      qword ptr [7FF9231DF168]
       jmp       near ptr M01_L18
M01_L44:
       jmp       near ptr M01_L33
M01_L45:
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
       call      qword ptr [7FF922D5DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M01_L19
M01_L46:
       mov       rcx,[rdi+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rax,rdi
       jmp       near ptr M01_L20
M01_L47:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M01_L24
M01_L48:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L26
M01_L49:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L27
M01_L50:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L27
M01_L51:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M01_L51
       jmp       near ptr M01_L30
M01_L52:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L53:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L54
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L54
       jmp       short M01_L55
M01_L54:
       mov       rcx,rsi
       mov       rdx,7FF923274758
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L55:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L56
       jmp       short M01_L57
M01_L56:
       mov       rdx,7FF923274798
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L57:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M01_L09
M01_L58:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L59
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L59
       jmp       short M01_L60
M01_L59:
       mov       rcx,rbx
       mov       rdx,7FF923274160
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L60:
       mov       rdx,rsi
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9231DF168]
M01_L61:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1999
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M03_L01:
       call      qword ptr [7FF9231DC0C0]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF922A0D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF9231DD878]
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
       jle       short M05_L03
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M05_L03
M05_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       je        short M05_L02
M05_L01:
       mov       rcx,7FF923243390
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M05_L02:
       mov       rcx,1BC98000110
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M05_L05
       mov       rcx,1BC980000F0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M05_L04
       mov       rcx,7FF923243398
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M05_L01
M05_L03:
       mov       ecx,2
       call      qword ptr [7FF9231DD470]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L04:
       mov       rcx,7FF923243394
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF923243390
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF922C25E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
M05_L05:
       mov       rcx,7FF92324339C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M05_L01
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
       jne       short M06_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
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
       je        near ptr M07_L05
       mov       rcx,[rbx]
       cmp       rcx,rsi
       je        near ptr M07_L04
       mov       rax,1BC98000038
       mov       rax,[rax]
       add       rax,10
       rorx      rdx,rcx,20
       xor       rdx,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rdx,r8
       mov       r8d,[rax]
       shrx      rdx,rdx,r8
       xor       r8d,r8d
M07_L00:
       lea       r10d,[rdx+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rax+r10*8]
       mov       r9d,[r10]
       and       r9d,0FFFFFFFE
       cmp       [r10+8],rcx
       jne       short M07_L01
       mov       r11,rsi
       xor       r11,[r10+10]
       cmp       r11,1
       jbe       short M07_L03
M07_L01:
       test      r9d,r9d
       je        short M07_L02
       inc       r8d
       add       edx,r8d
       and       edx,[rax+4]
       cmp       r8d,8
       jl        short M07_L00
M07_L02:
       mov       rcx,7FF923244984
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF922A06340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M07_L03:
       cmp       r9d,[r10]
       jne       short M07_L02
       cmp       r11d,1
       jne       short M07_L02
       mov       rcx,7FF923244978
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M07_L05
M07_L04:
       mov       rcx,7FF923244980
       call      CORINFO_HELP_COUNTPROFILE32
M07_L05:
       mov       rcx,7FF92324497C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 246
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark.OrderByWithComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rdi,rsi
       mov       rcx,2895BC00A48
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M00_L16
M00_L00:
       mov       r14,[rbx+2E8]
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L17
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       test      rdx,rdx
       je        near ptr M00_L18
M00_L01:
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rdx,rsi
       mov       rcx,7FF9231352B8
       call      qword ptr [7FF922D6C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L19
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r15+30]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rdx,[r15+28]
       movzx     r8d,byte ptr [r15+48]
       mov       [rsp+54],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       mov       ecx,[rsp+54]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r15+20],0
       jne       near ptr M00_L20
M00_L02:
       mov       r15,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rdx
       jne       near ptr M00_L24
       mov       rax,[r15+8]
       mov       [rsp+30],rax
       mov       rdx,2895BC00A58
       cmp       rax,[rdx]
       je        near ptr M00_L22
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       r9,[rsp+30]
       test      r9,r9
       je        short M00_L05
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L05
M00_L03:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,rdx
       mov       [rsp+50],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+50]
       inc       r10d
       cmp       edi,r10d
       jle       short M00_L07
       mov       rax,[rsp+28]
       jmp       short M00_L03
M00_L04:
       mov       rax,[rsp+28]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L26
       mov       [rsp+50],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L21
       mov       r8,rdx
M00_L06:
       mov       edx,[rsp+50]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+50]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+30]
       jg        short M00_L04
M00_L07:
       lea       rcx,[r15+20]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       jne       near ptr M00_L23
M00_L09:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L11
       vmovups   ymm0,[7FF923181160]
       vbroadcastss ymm1,dword ptr [7FF923181180]
       lea       rcx,[rdx-20]
M00_L10:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L10
       vmovd     ecx,xmm0
M00_L11:
       cmp       r9,rdx
       jb        near ptr M00_L25
M00_L12:
       lea       r9d,[r12-1]
       mov       rcx,r15
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r15]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       r15,[rsp+38]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L14
       cmp       edi,r13d
       jl        short M00_L15
       xor       r12d,r12d
M00_L13:
       lea       rcx,[r14+r12*2]
       mov       eax,[r15+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L13
M00_L14:
       mov       [rsp+48],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L15:
       mov       ecx,r12d
       lea       rcx,[r14+rcx*8]
       cmp       r12d,edi
       jae       near ptr M00_L26
       mov       edx,r12d
       mov       eax,[r15+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L15
       jmp       short M00_L14
M00_L16:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2895BC00A40
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF922A16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2895BC00A48
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L17:
       mov       ecx,11
       call      qword ptr [7FF922C37E58]
       int       3
M00_L18:
       mov       rcx,offset MT_System.Collections.Generic.Comparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2895BC00AF8
       mov       rdx,[rcx]
       jmp       near ptr M00_L01
M00_L19:
       mov       rbp,rsi
       jmp       near ptr M00_L14
M00_L20:
       mov       rcx,[r15+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r15,rax
       mov       rax,r15
       jmp       near ptr M00_L02
M00_L21:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+28]
       jmp       near ptr M00_L06
M00_L22:
       lea       rcx,[r15+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L23:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L24:
       mov       rcx,r15
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L25:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L25
       jmp       near ptr M00_L12
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1128
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rdx
       jne       near ptr M01_L50
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L34
       mov       rcx,rax
       call      qword ptr [7FF922DF3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L18
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF923284248
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L04:
       mov       rdx,rsi
       call      qword ptr [7FF922B8F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L56
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L11
M01_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L12
M01_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L51
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L14
M01_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M01_L09:
       mov       rax,rbx
       vzeroupper
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
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF9232840E0
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF923284228
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF923284820
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF9232848E0
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF9232848E8
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B8F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L42
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L35
       mov       ebx,[rsi+8]
M01_L16:
       test      ebx,ebx
       je        near ptr M01_L41
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L40
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L39
       cmp       ebp,[rsi+8]
       ja        near ptr M01_L39
       cmp       ebp,[rbx+8]
       ja        near ptr M01_L39
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L38
       cmp       r8,4000
       ja        near ptr M01_L37
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L36
M01_L17:
       mov       rax,rbx
M01_L18:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M01_L43
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+5C],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+5C]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       jne       near ptr M01_L44
M01_L19:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rdx
       jne       near ptr M01_L48
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,2895BC00A58
       cmp       rax,[rdx]
       je        near ptr M01_L46
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M01_L22
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M01_L22
M01_L20:
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,rdx
       mov       [rsp+58],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+58]
       inc       r10d
       cmp       esi,r10d
       jle       short M01_L24
       mov       rax,[rsp+38]
       jmp       short M01_L20
M01_L21:
       mov       rax,[rsp+38]
M01_L22:
       cmp       r10d,esi
       jae       near ptr M01_L59
       mov       [rsp+58],r10d
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M01_L45
       mov       r8,rdx
M01_L23:
       mov       edx,[rsp+58]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+58]
       inc       ecx
       cmp       esi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M01_L21
M01_L24:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M01_L25:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       jne       near ptr M01_L47
M01_L26:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M01_L28
       vmovups   ymm0,[7FF92317E140]
       vbroadcastss ymm1,dword ptr [7FF92317E160]
       lea       rcx,[rdx-20]
M01_L27:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M01_L27
       vmovd     ecx,xmm0
M01_L28:
       cmp       r9,rdx
       jb        near ptr M01_L49
M01_L29:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       ebp,ebp
       test      r13d,r13d
       jle       short M01_L31
       cmp       esi,r13d
       jl        short M01_L33
       xor       ebp,ebp
M01_L30:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M01_L59
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M01_L30
M01_L31:
       mov       rax,r14
M01_L32:
       vzeroupper
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
M01_L33:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M01_L59
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M01_L59
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M01_L33
       jmp       short M01_L31
M01_L34:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L35:
       mov       rcx,rsi
       mov       r11,7FF922960C10
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L36:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L17
M01_L37:
       mov       rcx,rax
       call      qword ptr [7FF922FBEEC8]
       jmp       near ptr M01_L17
M01_L38:
       mov       rcx,rax
       call      qword ptr [7FF922A15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L39:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923046AA8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L17
M01_L40:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922960C18
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2895BC00AF0
       mov       rbx,[rdx]
       jmp       near ptr M01_L17
M01_L42:
       mov       rdx,rbx
       mov       rcx,7FF923297420
       call      qword ptr [7FF9231EF1E0]
       jmp       near ptr M01_L18
M01_L43:
       jmp       near ptr M01_L32
M01_L44:
       mov       rcx,[rdi+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rax,rdi
       jmp       near ptr M01_L19
M01_L45:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M01_L23
M01_L46:
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L25
M01_L47:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L26
M01_L48:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L26
M01_L49:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M01_L49
       jmp       near ptr M01_L29
M01_L50:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L51:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L52
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L52
       jmp       short M01_L53
M01_L52:
       mov       rcx,rsi
       mov       rdx,7FF9232848C0
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L53:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L54
       jmp       short M01_L55
M01_L54:
       mov       rdx,7FF923284900
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L55:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M01_L09
M01_L56:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L57
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L57
       jmp       short M01_L58
M01_L57:
       mov       rcx,rbx
       mov       rdx,7FF9232841F0
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L58:
       mov       rdx,rsi
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9231EF1E0]
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1914
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,rdx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M03_L01:
       call      qword ptr [7FF9231EC0F0]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF922A1D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF9231ED8F0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FF922A15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark.OrderByWithoutComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rdi,rsi
       mov       rcx,2DB44800A50
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M00_L16
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rax,2DB2E800068
       mov       r15,[rax]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L17
       xor       ecx,ecx
       mov       [r14+20],rcx
       lea       rcx,[r14+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[r14+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+48],0
       mov       rdx,rsi
       mov       rcx,7FF9231252B8
       call      qword ptr [7FF922D5C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L18
       mov       ebp,edi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       lea       r13,[r15+10]
       mov       r12d,[r15+8]
       mov       rax,[r14+30]
       mov       rcx,2DB2E800A08
       cmp       rax,[rcx]
       mov       [rsp+48],rax
       je        near ptr M00_L19
M00_L01:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rdx,[r14+28]
       movzx     r8d,byte ptr [r14+48]
       mov       [rsp+64],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+10]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       mov       ecx,[rsp+64]
       mov       [rax+28],cl
       xor       ecx,ecx
       mov       [rax+18],rcx
       mov       r8,rax
       cmp       qword ptr [r14+20],0
       jne       near ptr M00_L20
M00_L02:
       mov       r14,r8
       mov       r9d,edi
       mov       [rsp+60],r9d
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [r14],rdx
       jne       near ptr M00_L24
       mov       rax,[r14+8]
       mov       [rsp+28],rax
       mov       rdx,2DB44800A58
       cmp       rax,[rdx]
       je        near ptr M00_L22
       mov       edx,r9d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+20],rax
       xor       r10d,r10d
       mov       r9,[rsp+28]
       test      r9,r9
       je        short M00_L05
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L05
M00_L03:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,[rdx+30]
       mov       [rsp+5C],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+5C]
       inc       r10d
       cmp       edi,r10d
       jle       short M00_L07
       mov       rax,[rsp+20]
       jmp       short M00_L03
       nop
M00_L04:
       mov       rax,[rsp+20]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L26
       mov       [rsp+5C],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L21
       mov       r8,[rdx+30]
M00_L06:
       mov       edx,[rsp+5C]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+5C]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+28]
       jg        short M00_L04
M00_L07:
       lea       rcx,[r14+20]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[r14+18]
       test      rcx,rcx
       jne       near ptr M00_L23
M00_L09:
       mov       edx,[rsp+60]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+30],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       mov       ebp,[rsp+60]
       cmp       ebp,8
       jl        short M00_L11
       vmovups   ymm0,[7FF923171D60]
       vbroadcastss ymm1,dword ptr [7FF923171D80]
       lea       rcx,[rdx-20]
M00_L10:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L10
       vmovd     ecx,xmm0
M00_L11:
       cmp       r9,rdx
       jb        near ptr M00_L25
M00_L12:
       lea       r9d,[rbp-1]
       mov       rcx,r14
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r14]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rbp,[rsp+30]
       xor       r14d,r14d
       test      r12d,r12d
       jle       short M00_L14
       cmp       edi,r12d
       jl        short M00_L15
       xor       r14d,r14d
M00_L13:
       lea       rcx,[r13+r14*2]
       mov       eax,[rbp+r14+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r14,4
       dec       r12d
       jne       short M00_L13
M00_L14:
       mov       [rsp+50],r15
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L15:
       mov       ecx,r14d
       lea       rcx,[r13+rcx*8]
       cmp       r14d,edi
       jae       near ptr M00_L26
       mov       edx,r14d
       mov       eax,[rbp+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r14d
       cmp       r14d,r12d
       jl        short M00_L15
       jmp       short M00_L14
M00_L16:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2DB44800A40
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2DB44800A50
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L17:
       mov       ecx,11
       call      qword ptr [7FF922C27E58]
       int       3
M00_L18:
       mov       r15,rsi
       jmp       near ptr M00_L14
M00_L19:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       call      qword ptr [7FF922C25DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,[rsp+38]
       xor       r8d,r8d
       call      qword ptr [7FF922D5DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       mov       rax,[rsp+38]
       mov       [rsp+48],rax
       jmp       near ptr M00_L01
M00_L20:
       mov       rcx,[r14+20]
       mov       rdx,rax
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r14,rax
       mov       r8,r14
       jmp       near ptr M00_L02
M00_L21:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+20]
       jmp       near ptr M00_L06
M00_L22:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[r14+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L23:
       mov       rdx,rsi
       mov       r8d,[rsp+60]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L24:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8d,r9d
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L25:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L25
       jmp       near ptr M00_L12
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1219
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M01_L52
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rax],rcx
       jne       near ptr M01_L35
       mov       rcx,rax
       call      qword ptr [7FF922DE3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L18
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF9232742D0
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L04:
       mov       rdx,rsi
       call      qword ptr [7FF922B7F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L58
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L11
M01_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L12
M01_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L53
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L14
M01_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M01_L09:
       mov       rax,rbx
       vzeroupper
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
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF923274168
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF9232742B0
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9232748F0
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF9232749B0
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF9232749B8
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B7F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L43
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L36
       mov       ebx,[rsi+8]
M01_L16:
       test      ebx,ebx
       je        near ptr M01_L42
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L41
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L40
       cmp       ebp,[rsi+8]
       ja        near ptr M01_L40
       cmp       ebp,[rbx+8]
       ja        near ptr M01_L40
       mov       r8d,ebp
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
M01_L17:
       mov       rax,rbx
M01_L18:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M01_L44
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,2DB2E800A08
       cmp       r12,[rcx]
       je        near ptr M01_L45
M01_L19:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+5C],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+5C]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       jne       near ptr M01_L46
M01_L20:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M01_L50
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,2DB44800A58
       cmp       rax,[rdx]
       je        near ptr M01_L48
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M01_L23
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M01_L23
M01_L21:
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,[rdx+30]
       mov       [rsp+58],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+58]
       inc       r10d
       cmp       esi,r10d
       jle       short M01_L25
       mov       rax,[rsp+38]
       jmp       short M01_L21
M01_L22:
       mov       rax,[rsp+38]
M01_L23:
       cmp       r10d,esi
       jae       near ptr M01_L61
       mov       [rsp+58],r10d
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M01_L47
       mov       r8,[rdx+30]
M01_L24:
       mov       edx,[rsp+58]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+58]
       inc       ecx
       cmp       esi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M01_L22
M01_L25:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M01_L26:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       jne       near ptr M01_L49
M01_L27:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M01_L29
       vmovups   ymm0,[7FF92316E740]
       vbroadcastss ymm1,dword ptr [7FF92316E760]
       lea       rcx,[rdx-20]
M01_L28:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M01_L28
       vmovd     ecx,xmm0
M01_L29:
       cmp       r9,rdx
       jb        near ptr M01_L51
M01_L30:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       ebp,ebp
       test      r13d,r13d
       jle       short M01_L32
       cmp       esi,r13d
       jl        short M01_L34
       xor       ebp,ebp
M01_L31:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M01_L61
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M01_L31
M01_L32:
       mov       rax,r14
M01_L33:
       vzeroupper
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
M01_L34:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M01_L61
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M01_L61
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M01_L34
       jmp       short M01_L32
M01_L35:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L36:
       mov       rcx,rsi
       mov       r11,7FF922950C20
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L37:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L17
M01_L38:
       mov       rcx,rax
       call      qword ptr [7FF922FAEEC8]
       jmp       near ptr M01_L17
M01_L39:
       mov       rcx,rax
       call      qword ptr [7FF922A05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L40:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923036B08]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L17
M01_L41:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922950C28
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2DB44800AF0
       mov       rbx,[rdx]
       jmp       near ptr M01_L17
M01_L43:
       mov       rdx,rbx
       mov       rcx,7FF923287898
       call      qword ptr [7FF9231DF198]
       jmp       near ptr M01_L18
M01_L44:
       jmp       near ptr M01_L33
M01_L45:
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
       call      qword ptr [7FF922D5DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M01_L19
M01_L46:
       mov       rcx,[rdi+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rax,rdi
       jmp       near ptr M01_L20
M01_L47:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M01_L24
M01_L48:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L26
M01_L49:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L27
M01_L50:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L27
M01_L51:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M01_L51
       jmp       near ptr M01_L30
M01_L52:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L53:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L54
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L54
       jmp       short M01_L55
M01_L54:
       mov       rcx,rsi
       mov       rdx,7FF923274990
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L55:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L56
       jmp       short M01_L57
M01_L56:
       mov       rdx,7FF9232749D0
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L57:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M01_L09
M01_L58:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L59
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L59
       jmp       short M01_L60
M01_L59:
       mov       rcx,rbx
       mov       rdx,7FF923274278
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L60:
       mov       rdx,rsi
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9231DF198]
M01_L61:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1999
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M03_L01:
       call      qword ptr [7FF9231DC0A8]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF922A0D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF9231DD8A8]
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
       jle       short M05_L03
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M05_L03
M05_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       je        short M05_L02
M05_L01:
       mov       rcx,7FF923242B98
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M05_L02:
       mov       rcx,2DB2E800110
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M05_L05
       mov       rcx,2DB2E8000F0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M05_L04
       mov       rcx,7FF923242BA0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M05_L01
M05_L03:
       mov       ecx,2
       call      qword ptr [7FF9231DD4A0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L04:
       mov       rcx,7FF923242B9C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF923242B98
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF922C25E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
M05_L05:
       mov       rcx,7FF923242BA4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M05_L01
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
       jne       short M06_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
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
       je        near ptr M07_L05
       mov       rcx,[rbx]
       cmp       rcx,rsi
       je        near ptr M07_L04
       mov       rax,2DB2E800038
       mov       rax,[rax]
       add       rax,10
       rorx      rdx,rcx,20
       xor       rdx,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rdx,r8
       mov       r8d,[rax]
       shrx      rdx,rdx,r8
       xor       r8d,r8d
M07_L00:
       lea       r10d,[rdx+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rax+r10*8]
       mov       r9d,[r10]
       and       r9d,0FFFFFFFE
       cmp       [r10+8],rcx
       jne       short M07_L01
       mov       r11,rsi
       xor       r11,[r10+10]
       cmp       r11,1
       jbe       short M07_L03
M07_L01:
       test      r9d,r9d
       je        short M07_L02
       inc       r8d
       add       edx,r8d
       and       edx,[rax+4]
       cmp       r8d,8
       jl        short M07_L00
M07_L02:
       mov       rcx,7FF9232441FC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF922A06340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M07_L03:
       cmp       r9d,[r10]
       jne       short M07_L02
       cmp       r11d,1
       jne       short M07_L02
       mov       rcx,7FF9232441F0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M07_L05
M07_L04:
       mov       rcx,7FF9232441F8
       call      CORINFO_HELP_COUNTPROFILE32
M07_L05:
       mov       rcx,7FF9232441F4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 246
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark.OrderByWithComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,253D5000A30
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L19
M00_L00:
       mov       rbp,[rbx+2E8]
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L16
       xor       ecx,ecx
       mov       [r14+20],rcx
       lea       rcx,[r14+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       test      rdx,rdx
       jne       short M00_L02
       test      byte ptr [7FF9231AC058],1
       je        near ptr M00_L20
M00_L01:
       mov       rcx,253D5000A88
       mov       rdx,[rcx]
M00_L02:
       lea       rcx,[r14+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+48],0
       mov       rdx,[r14+18]
       mov       rcx,7FF9230D14C0
       call      qword ptr [7FF922D4C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L21
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       r15,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r14+30]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       mov       rdx,[r14+28]
       movzx     r8d,byte ptr [r14+48]
       mov       [rsp+54],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+38]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+38]
       mov       ecx,[rsp+54]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r14+20],0
       jne       near ptr M00_L22
M00_L03:
       mov       r14,rax
       mov       r12d,edi
       mov       rax,[r14]
       mov       [rsp+40],rax
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rax,rdx
       jne       near ptr M00_L26
       mov       r8,[r14+8]
       mov       [rsp+28],r8
       mov       rdx,253D5000A40
       cmp       r8,[rdx]
       je        near ptr M00_L24
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+20],rax
       xor       r10d,r10d
       mov       r9,[rsp+28]
       test      r9,r9
       je        short M00_L06
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L06
M00_L04:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,rdx
       mov       [rsp+50],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+50]
       inc       r10d
       cmp       edi,r10d
       jle       short M00_L08
       mov       rax,[rsp+20]
       jmp       short M00_L04
       nop       dword ptr [rax]
M00_L05:
       mov       rax,[rsp+20]
M00_L06:
       cmp       r10d,edi
       jae       near ptr M00_L27
       mov       [rsp+50],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L23
       mov       r8,rdx
M00_L07:
       mov       edx,[rsp+50]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+50]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+28]
       jg        short M00_L05
M00_L08:
       lea       rcx,[r14+20]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
M00_L09:
       mov       rcx,[r14+18]
       test      rcx,rcx
       jne       near ptr M00_L25
M00_L10:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+30],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L12
       vmovups   ymm0,[7FF9230F48E0]
       vbroadcastss ymm1,dword ptr [7FF9230F4900]
       lea       rcx,[rdx-20]
M00_L11:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L11
       vmovd     ecx,xmm0
M00_L12:
       cmp       r9,rdx
       jb        near ptr M00_L17
M00_L13:
       lea       r9d,[r12-1]
       mov       rcx,r14
       mov       rdx,rax
       xor       r8d,r8d
       mov       r14,[rsp+40]
       mov       r10,[r14+40]
       call      qword ptr [r10+30]
       mov       r14,[rsp+30]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L15
       cmp       edi,r13d
       jl        near ptr M00_L18
       xor       r12d,r12d
M00_L14:
       lea       rcx,[r15+r12*2]
       mov       eax,[r14+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L27
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L14
M00_L15:
       mov       [rsp+48],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L16:
       mov       ecx,11
       call      qword ptr [7FF922C17E58]
       int       3
M00_L17:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L17
       jmp       near ptr M00_L13
M00_L18:
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8]
       cmp       r12d,edi
       jae       near ptr M00_L27
       mov       edx,r12d
       mov       eax,[r14+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L27
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L18
       jmp       near ptr M00_L15
M00_L19:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,253D5000A28
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,253D5000A30
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L20:
       mov       rcx,offset MT_System.Collections.Generic.Comparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L21:
       mov       rbp,rsi
       jmp       near ptr M00_L15
M00_L22:
       mov       rcx,[r14+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r14,rax
       mov       rax,r14
       jmp       near ptr M00_L03
M00_L23:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+20]
       jmp       near ptr M00_L07
M00_L24:
       lea       rcx,[r14+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L09
M00_L25:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L10
M00_L26:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rsp+40]
       mov       r10,[rax+40]
       call      qword ptr [r10+20]
       jmp       near ptr M00_L10
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1159
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       [rsp+50],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FF9229F6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rdx
       jne       near ptr M01_L61
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9229F6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L45
       mov       rcx,rax
       call      qword ptr [7FF922DD3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L21
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF92319CAD8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L04:
       mov       rdx,rsi
       call      qword ptr [7FF922B6F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L67
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L11
M01_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L12
M01_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L62
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L14
M01_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M01_L09:
       mov       rax,rbx
       vzeroupper
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
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF92319C970
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF92319CAB8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF92319D410
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF92319D4D0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF92319D4D8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B6F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L54
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L46
       mov       ebx,[rsi+8]
M01_L16:
       test      ebx,ebx
       je        near ptr M01_L53
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L52
       mov       ebp,[rsi+8]
       mov       r14,[rsi]
       cmp       dword ptr [r14+4],18
       jne       short M01_L17
       cmp       ebp,[rsi+8]
       ja        short M01_L17
       cmp       ebp,[rbx+8]
       jbe       near ptr M01_L29
M01_L17:
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M01_L24
       xor       r14d,r14d
M01_L18:
       test      r14d,r14d
       jg        near ptr M01_L47
       mov       ecx,r14d
       neg       ecx
       js        near ptr M01_L48
       lea       edx,[rcx+rbp]
       cmp       edx,[rsi+8]
       ja        near ptr M01_L48
       mov       rdx,[rbx]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       jne       near ptr M01_L25
       xor       r14d,r14d
M01_L19:
       test      r14d,r14d
       jg        near ptr M01_L49
       mov       edx,r14d
       neg       edx
       js        near ptr M01_L50
       lea       r8d,[rdx+rbp]
       cmp       r8d,[rbx+8]
       ja        near ptr M01_L50
       mov       r8,[rsi]
       movzx     eax,word ptr [r8]
       mov       r10d,ebp
       imul      r10,rax
       mov       ecx,ecx
       imul      rcx,rax
       lea       r9,[rsi+rcx+10]
       mov       ecx,edx
       imul      rcx,rax
       lea       rcx,[rbx+rcx+10]
       test      dword ptr [r8],1000000
       je        near ptr M01_L26
       cmp       r10,4000
       ja        near ptr M01_L28
       mov       rdx,r9
       mov       r8,r10
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L51
M01_L20:
       mov       rax,rbx
M01_L21:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M01_L55
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+4C],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       mov       ecx,[rsp+4C]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       jne       near ptr M01_L56
M01_L22:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rdx
       jne       near ptr M01_L60
       mov       rax,[rdi+8]
       mov       [rsp+30],rax
       mov       rdx,253D5000A40
       cmp       rax,[rdx]
       je        near ptr M01_L58
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       r9,[rsp+30]
       test      r9,r9
       je        near ptr M01_L32
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       near ptr M01_L32
M01_L23:
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,rdx
       mov       [rsp+48],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+48]
       inc       r10d
       cmp       esi,r10d
       jle       near ptr M01_L34
       mov       rax,[rsp+28]
       jmp       short M01_L23
M01_L24:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       near ptr M01_L18
M01_L25:
       movsxd    rdx,edx
       mov       r14d,[rbx+rdx*4+10]
       jmp       near ptr M01_L19
M01_L26:
       cmp       r10,40
       je        short M01_L27
       mov       rdx,r9
       mov       r8,r10
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L20
M01_L27:
       vmovdqu   ymm0,ymmword ptr [r9]
       vmovdqu   ymm1,ymmword ptr [r9+20]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm1
       jmp       near ptr M01_L20
M01_L28:
       mov       rdx,r9
       mov       r8,r10
       call      qword ptr [7FF9230C4B10]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L20
M01_L29:
       mov       r8d,ebp
       movzx     ecx,word ptr [r14]
       imul      r8,rcx
       lea       rdx,[rsi+10]
       lea       rcx,[rbx+10]
       test      dword ptr [r14],1000000
       jne       short M01_L30
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L20
M01_L30:
       call      qword ptr [7FF9229F57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L20
M01_L31:
       mov       rax,[rsp+28]
M01_L32:
       cmp       r10d,esi
       jae       near ptr M01_L70
       mov       [rsp+48],r10d
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M01_L57
       mov       r8,rdx
M01_L33:
       mov       edx,[rsp+48]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+48]
       inc       ecx
       cmp       esi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+30]
       jg        short M01_L31
M01_L34:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
M01_L35:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       jne       near ptr M01_L59
M01_L36:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M01_L38
       vmovups   ymm0,[7FF9230F4080]
       vbroadcastss ymm1,dword ptr [7FF9230F40A0]
       lea       rcx,[rdx-20]
M01_L37:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M01_L37
       vmovd     ecx,xmm0
M01_L38:
       cmp       r9,rdx
       jb        short M01_L43
M01_L39:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+38]
       xor       ebp,ebp
       test      r13d,r13d
       jle       short M01_L41
       cmp       esi,r13d
       jl        short M01_L44
       xor       ebp,ebp
M01_L40:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M01_L70
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M01_L40
M01_L41:
       mov       rax,r14
M01_L42:
       vzeroupper
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
M01_L43:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M01_L43
       jmp       short M01_L39
M01_L44:
       cmp       ebp,r13d
       jae       near ptr M01_L70
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M01_L70
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M01_L70
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M01_L44
       jmp       short M01_L41
M01_L45:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L46:
       mov       rcx,rsi
       mov       r11,7FF922940B18
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L47:
       mov       ecx,167
       mov       rdx,7FF922934000
       call      qword ptr [7FF922C17798]
       mov       r8,rax
       mov       edx,r14d
       xor       ecx,ecx
       call      qword ptr [7FF9231CC288]
       int       3
M01_L48:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9231CC318]
       mov       rbx,rax
       mov       ecx,12D
       mov       rdx,7FF922934000
       call      qword ptr [7FF922C17798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF922D47FA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L49:
       mov       ecx,17F
       mov       rdx,7FF922934000
       call      qword ptr [7FF922C17798]
       mov       r8,rax
       mov       edx,r14d
       xor       ecx,ecx
       call      qword ptr [7FF9231CC288]
       int       3
M01_L50:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF9231CC330]
       mov       rbp,rax
       mov       ecx,145
       mov       rdx,7FF922934000
       call      qword ptr [7FF922C17798]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,r14
       call      qword ptr [7FF922D47FA8]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M01_L51:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L20
M01_L52:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922940B20
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L20
M01_L53:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9229F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,253D5000A80
       mov       rbx,[rdx]
       jmp       near ptr M01_L20
M01_L54:
       mov       rdx,rbx
       mov       rcx,7FF9231AAA40
       call      qword ptr [7FF9231C7A68]
       jmp       near ptr M01_L21
M01_L55:
       jmp       near ptr M01_L42
M01_L56:
       mov       rcx,[rdi+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rax,rdi
       jmp       near ptr M01_L22
M01_L57:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+28]
       jmp       near ptr M01_L33
M01_L58:
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L35
M01_L59:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L36
M01_L60:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L36
M01_L61:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L62:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L63
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L63
       jmp       short M01_L64
M01_L63:
       mov       rcx,rsi
       mov       rdx,7FF92319D4B0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L64:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L65
       jmp       short M01_L66
M01_L65:
       mov       rdx,7FF92319D4F0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L66:
       mov       rcx,rdx
       call      qword ptr [7FF9229F5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M01_L09
M01_L67:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L68
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L68
       jmp       short M01_L69
M01_L68:
       mov       rcx,rbx
       mov       rdx,7FF92319CA80
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L69:
       mov       rdx,rsi
       vzeroupper
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9231C7A68]
M01_L70:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2340
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,rdx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M03_L01:
       call      qword ptr [7FF9231C78E8]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229FD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF9231CEBE0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FF9229F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark.OrderByWithoutComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rdi,rsi
       mov       rcx,2068D802A48
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M00_L16
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rax,2068D800068
       mov       r15,[rax]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L17
       xor       ecx,ecx
       mov       [r14+20],rcx
       lea       rcx,[r14+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[r14+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+48],0
       mov       rdx,rsi
       mov       rcx,7FF9231152B8
       call      qword ptr [7FF922D4C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L18
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       r15,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r14+30]
       mov       rcx,2068D800A08
       cmp       r12,[rcx]
       je        near ptr M00_L19
M00_L01:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rdx,[r14+28]
       movzx     r8d,byte ptr [r14+48]
       mov       [rsp+54],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       mov       ecx,[rsp+54]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r14+20],0
       jne       near ptr M00_L20
M00_L02:
       mov       r14,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [r14],rdx
       jne       near ptr M00_L24
       mov       rax,[r14+8]
       mov       [rsp+30],rax
       mov       rdx,2068D802A50
       cmp       rax,[rdx]
       je        near ptr M00_L22
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       r9,[rsp+30]
       test      r9,r9
       je        short M00_L05
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L05
M00_L03:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,[rdx+30]
       mov       [rsp+50],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+50]
       inc       r10d
       cmp       edi,r10d
       jle       short M00_L07
       mov       rax,[rsp+28]
       jmp       short M00_L03
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M00_L04:
       mov       rax,[rsp+28]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L26
       mov       [rsp+50],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L21
       mov       r8,[rdx+30]
M00_L06:
       mov       edx,[rsp+50]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+50]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+30]
       jg        short M00_L04
M00_L07:
       lea       rcx,[r14+20]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[r14+18]
       test      rcx,rcx
       jne       near ptr M00_L23
M00_L09:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L11
       vmovups   ymm0,[7FF9231619E0]
       vbroadcastss ymm1,dword ptr [7FF923161A00]
       lea       rcx,[rdx-20]
M00_L10:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L10
       vmovd     ecx,xmm0
M00_L11:
       cmp       r9,rdx
       jb        near ptr M00_L25
M00_L12:
       lea       r9d,[r12-1]
       mov       rcx,r14
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r14]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       r14,[rsp+38]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L14
       cmp       edi,r13d
       jl        short M00_L15
       xor       r12d,r12d
M00_L13:
       lea       rcx,[r15+r12*2]
       mov       eax,[r14+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L13
M00_L14:
       mov       [rsp+48],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L15:
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8]
       cmp       r12d,edi
       jae       near ptr M00_L26
       mov       edx,r12d
       mov       eax,[r14+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L15
       jmp       short M00_L14
M00_L16:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2068D802A38
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2068D802A48
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L17:
       mov       ecx,11
       call      qword ptr [7FF922C17E58]
       int       3
M00_L18:
       mov       rbp,rsi
       jmp       near ptr M00_L14
M00_L19:
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
       call      qword ptr [7FF922D4DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M00_L01
M00_L20:
       mov       rcx,[r14+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r14,rax
       mov       rax,r14
       jmp       near ptr M00_L02
M00_L21:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+28]
       jmp       near ptr M00_L06
M00_L22:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[r14+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L23:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L24:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L25:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L25
       jmp       near ptr M00_L12
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1203
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M01_L52
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rax],rcx
       jne       near ptr M01_L35
       mov       rcx,rax
       call      qword ptr [7FF922DD3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L18
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF923264508
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L04:
       mov       rdx,rsi
       call      qword ptr [7FF922B6F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L58
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L11
M01_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L12
M01_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L53
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L14
M01_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M01_L09:
       mov       rax,rbx
       vzeroupper
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
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF9232643A0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF9232644E8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF923264A08
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF923264AC8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF923264AD0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B6F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L43
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L36
       mov       ebx,[rsi+8]
M01_L16:
       test      ebx,ebx
       je        near ptr M01_L42
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L41
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L40
       cmp       ebp,[rsi+8]
       ja        near ptr M01_L40
       cmp       ebp,[rbx+8]
       ja        near ptr M01_L40
       mov       r8d,ebp
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
M01_L17:
       mov       rax,rbx
M01_L18:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M01_L44
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,2068D800A08
       cmp       r12,[rcx]
       je        near ptr M01_L45
M01_L19:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+5C],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+5C]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       jne       near ptr M01_L46
M01_L20:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M01_L50
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,2068D802A50
       cmp       rax,[rdx]
       je        near ptr M01_L48
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M01_L23
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M01_L23
M01_L21:
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,[rdx+30]
       mov       [rsp+58],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+58]
       inc       r10d
       cmp       esi,r10d
       jle       short M01_L25
       mov       rax,[rsp+38]
       jmp       short M01_L21
M01_L22:
       mov       rax,[rsp+38]
M01_L23:
       cmp       r10d,esi
       jae       near ptr M01_L61
       mov       [rsp+58],r10d
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M01_L47
       mov       r8,[rdx+30]
M01_L24:
       mov       edx,[rsp+58]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+58]
       inc       ecx
       cmp       esi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M01_L22
M01_L25:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M01_L26:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       jne       near ptr M01_L49
M01_L27:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M01_L29
       vmovups   ymm0,[7FF92315E580]
       vbroadcastss ymm1,dword ptr [7FF92315E5A0]
       lea       rcx,[rdx-20]
M01_L28:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M01_L28
       vmovd     ecx,xmm0
M01_L29:
       cmp       r9,rdx
       jb        near ptr M01_L51
M01_L30:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       ebp,ebp
       test      r13d,r13d
       jle       short M01_L32
       cmp       esi,r13d
       jl        short M01_L34
       xor       ebp,ebp
M01_L31:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M01_L61
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M01_L31
M01_L32:
       mov       rax,r14
M01_L33:
       vzeroupper
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
M01_L34:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M01_L61
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M01_L61
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M01_L34
       jmp       short M01_L32
M01_L35:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L36:
       mov       rcx,rsi
       mov       r11,7FF922940C10
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L37:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L17
M01_L38:
       mov       rcx,rax
       call      qword ptr [7FF922F9F360]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L39:
       mov       rcx,rax
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L40:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923026AC0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L17
M01_L41:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922940C18
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2068D802AE8
       mov       rbx,[rdx]
       jmp       near ptr M01_L17
M01_L43:
       mov       rdx,rbx
       mov       rcx,7FF923278198
       call      qword ptr [7FF9231CF168]
       jmp       near ptr M01_L18
M01_L44:
       jmp       near ptr M01_L33
M01_L45:
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
       call      qword ptr [7FF922D4DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M01_L19
M01_L46:
       mov       rcx,[rdi+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rax,rdi
       jmp       near ptr M01_L20
M01_L47:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M01_L24
M01_L48:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L26
M01_L49:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L27
M01_L50:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L27
M01_L51:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M01_L51
       jmp       near ptr M01_L30
M01_L52:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L53:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L54
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L54
       jmp       short M01_L55
M01_L54:
       mov       rcx,rsi
       mov       rdx,7FF923264AA8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L55:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L56
       jmp       short M01_L57
M01_L56:
       mov       rdx,7FF923264AE8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L57:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M01_L09
M01_L58:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L59
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L59
       jmp       short M01_L60
M01_L59:
       mov       rcx,rbx
       mov       rdx,7FF9232644B0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L60:
       mov       rdx,rsi
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9231CF168]
M01_L61:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1999
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M03_L01:
       call      qword ptr [7FF9231CC0C0]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229FD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF9231CD878]
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
       jle       short M05_L03
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M05_L03
M05_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       je        short M05_L02
M05_L01:
       mov       rcx,7FF923233390
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M05_L02:
       mov       rcx,2068D800110
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M05_L05
       mov       rcx,2068D8000F0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M05_L04
       mov       rcx,7FF923233398
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M05_L01
M05_L03:
       mov       ecx,2
       call      qword ptr [7FF9231CD470]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L04:
       mov       rcx,7FF923233394
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF923233390
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF922C15E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
M05_L05:
       mov       rcx,7FF92323339C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M05_L01
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
       jne       short M06_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
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
       je        near ptr M07_L05
       mov       rcx,[rbx]
       cmp       rcx,rsi
       je        near ptr M07_L04
       mov       rax,2068D800038
       mov       rax,[rax]
       add       rax,10
       rorx      rdx,rcx,20
       xor       rdx,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rdx,r8
       mov       r8d,[rax]
       shrx      rdx,rdx,r8
       xor       r8d,r8d
M07_L00:
       lea       r10d,[rdx+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rax+r10*8]
       mov       r9d,[r10]
       and       r9d,0FFFFFFFE
       cmp       [r10+8],rcx
       jne       short M07_L01
       mov       r11,rsi
       xor       r11,[r10+10]
       cmp       r11,1
       jbe       short M07_L03
M07_L01:
       test      r9d,r9d
       je        short M07_L02
       inc       r8d
       add       edx,r8d
       and       edx,[rax+4]
       cmp       r8d,8
       jl        short M07_L00
M07_L02:
       mov       rcx,7FF923234984
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF9229F6340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M07_L03:
       cmp       r9d,[r10]
       jne       short M07_L02
       cmp       r11d,1
       jne       short M07_L02
       mov       rcx,7FF923234978
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M07_L05
M07_L04:
       mov       rcx,7FF923234980
       call      CORINFO_HELP_COUNTPROFILE32
M07_L05:
       mov       rcx,7FF92323497C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 246
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark.OrderByWithComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rdi,rsi
       mov       rcx,2A7F5002A40
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M00_L17
M00_L00:
       mov       r14,[rbx+2E8]
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L18
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       test      rdx,rdx
       je        near ptr M00_L19
M00_L01:
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rdx,rsi
       mov       rcx,7FF9230F52B8
       call      qword ptr [7FF922D2C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L20
       mov       ebp,edi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r13,[r14+10]
       mov       r12d,[r14+8]
       mov       rax,[r15+30]
       mov       [rsp+48],rax
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rdx,[r15+28]
       movzx     r8d,byte ptr [r15+48]
       mov       [rsp+64],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+10]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       mov       ecx,[rsp+64]
       mov       [rax+28],cl
       xor       ecx,ecx
       mov       [rax+18],rcx
       mov       r8,rax
       cmp       qword ptr [r15+20],0
       jne       near ptr M00_L21
M00_L02:
       mov       r15,r8
       mov       r9d,edi
       mov       [rsp+60],r9d
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rdx
       jne       near ptr M00_L25
       mov       rax,[r15+8]
       mov       [rsp+30],rax
       mov       rdx,2A7F5002A50
       cmp       rax,[rdx]
       je        near ptr M00_L23
       mov       edx,r9d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       r9,[rsp+30]
       test      r9,r9
       je        short M00_L05
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L05
M00_L03:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,rdx
       mov       [rsp+5C],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+5C]
       inc       r10d
       cmp       edi,r10d
       jle       short M00_L07
       mov       rax,[rsp+28]
       jmp       short M00_L03
M00_L04:
       mov       rax,[rsp+28]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L26
       mov       [rsp+5C],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L22
       mov       r8,rdx
M00_L06:
       mov       edx,[rsp+5C]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+5C]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+30]
       jg        short M00_L04
M00_L07:
       lea       rcx,[r15+20]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       jne       near ptr M00_L24
M00_L09:
       mov       edx,[rsp+60]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       mov       ebp,[rsp+60]
       cmp       ebp,8
       jl        short M00_L11
       vmovups   ymm0,[7FF9231411C0]
       vbroadcastss ymm1,dword ptr [7FF9231411E0]
       lea       rcx,[rdx-20]
M00_L10:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L10
       vmovd     ecx,xmm0
M00_L11:
       cmp       r9,rdx
       jb        near ptr M00_L15
M00_L12:
       lea       r9d,[rbp-1]
       mov       rcx,r15
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r15]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rbp,[rsp+38]
       xor       r15d,r15d
       test      r12d,r12d
       jle       short M00_L14
       cmp       edi,r12d
       jl        short M00_L16
       nop       dword ptr [rax]
       xor       r15d,r15d
       nop       dword ptr [rax]
M00_L13:
       lea       rcx,[r13+r15*2]
       mov       eax,[rbp+r15+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r15,4
       dec       r12d
       jne       short M00_L13
M00_L14:
       mov       [rsp+50],r14
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L15:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L15
       jmp       near ptr M00_L12
M00_L16:
       mov       ecx,r15d
       lea       rcx,[r13+rcx*8]
       cmp       r15d,edi
       jae       near ptr M00_L26
       mov       edx,r15d
       mov       eax,[rbp+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r15d
       cmp       r15d,r12d
       jl        short M00_L16
       jmp       near ptr M00_L14
M00_L17:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2A7F5002A38
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2A7F5002A40
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L18:
       mov       ecx,11
       call      qword ptr [7FF922BF7E58]
       int       3
M00_L19:
       mov       rcx,offset MT_System.Collections.Generic.Comparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2A7F5002AF0
       mov       rdx,[rcx]
       jmp       near ptr M00_L01
M00_L20:
       mov       r14,rsi
       jmp       near ptr M00_L14
M00_L21:
       mov       rcx,[r15+20]
       mov       rdx,rax
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r15,rax
       mov       r8,r15
       jmp       near ptr M00_L02
M00_L22:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+28]
       jmp       near ptr M00_L06
M00_L23:
       lea       rcx,[r15+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L24:
       mov       rdx,rsi
       mov       r8d,[rsp+60]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,r15
       mov       rdx,rsi
       mov       r8d,r9d
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1153
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rdx
       jne       near ptr M01_L50
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L34
       mov       rcx,rax
       call      qword ptr [7FF922DB3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L18
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF9232445E8
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L04:
       mov       rdx,rsi
       call      qword ptr [7FF922B4F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L56
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L11
M01_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L12
M01_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L51
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L14
M01_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M01_L09:
       mov       rax,rbx
       vzeroupper
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
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF923244480
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF9232445C8
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9232450C8
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF923245188
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF923245190
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B4F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L42
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L35
       mov       ebx,[rsi+8]
M01_L16:
       test      ebx,ebx
       je        near ptr M01_L41
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L40
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L39
       cmp       ebp,[rsi+8]
       ja        near ptr M01_L39
       cmp       ebp,[rbx+8]
       ja        near ptr M01_L39
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L38
       cmp       r8,4000
       ja        near ptr M01_L37
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L36
M01_L17:
       mov       rax,rbx
M01_L18:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M01_L43
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+5C],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+5C]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       jne       near ptr M01_L44
M01_L19:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rdx
       jne       near ptr M01_L48
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,2A7F5002A50
       cmp       rax,[rdx]
       je        near ptr M01_L46
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M01_L22
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M01_L22
M01_L20:
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,rdx
       mov       [rsp+58],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+58]
       inc       r10d
       cmp       esi,r10d
       jle       short M01_L24
       mov       rax,[rsp+38]
       jmp       short M01_L20
M01_L21:
       mov       rax,[rsp+38]
M01_L22:
       cmp       r10d,esi
       jae       near ptr M01_L59
       mov       [rsp+58],r10d
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M01_L45
       mov       r8,rdx
M01_L23:
       mov       edx,[rsp+58]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+58]
       inc       ecx
       cmp       esi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M01_L21
M01_L24:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M01_L25:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       jne       near ptr M01_L47
M01_L26:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M01_L28
       vmovups   ymm0,[7FF92313E840]
       vbroadcastss ymm1,dword ptr [7FF92313E860]
       lea       rcx,[rdx-20]
M01_L27:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M01_L27
       vmovd     ecx,xmm0
M01_L28:
       cmp       r9,rdx
       jb        near ptr M01_L49
M01_L29:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       ebp,ebp
       test      r13d,r13d
       jle       short M01_L31
       cmp       esi,r13d
       jl        short M01_L33
       xor       ebp,ebp
M01_L30:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M01_L59
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M01_L30
M01_L31:
       mov       rax,r14
M01_L32:
       vzeroupper
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
M01_L33:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M01_L59
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M01_L59
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M01_L33
       jmp       short M01_L31
M01_L34:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L35:
       mov       rcx,rsi
       mov       r11,7FF922920C18
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L36:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L17
M01_L37:
       mov       rcx,rax
       call      qword ptr [7FF922F7EEC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L38:
       mov       rcx,rax
       call      qword ptr [7FF9229D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L39:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923016AA8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L17
M01_L40:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922920C20
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2A7F5002AE8
       mov       rbx,[rdx]
       jmp       near ptr M01_L17
M01_L42:
       mov       rdx,rbx
       mov       rcx,7FF923257B18
       call      qword ptr [7FF9231AF1F8]
       jmp       near ptr M01_L18
M01_L43:
       jmp       near ptr M01_L32
M01_L44:
       mov       rcx,[rdi+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rax,rdi
       jmp       near ptr M01_L19
M01_L45:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M01_L23
M01_L46:
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L25
M01_L47:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L26
M01_L48:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L26
M01_L49:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M01_L49
       jmp       near ptr M01_L29
M01_L50:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L51:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L52
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L52
       jmp       short M01_L53
M01_L52:
       mov       rcx,rsi
       mov       rdx,7FF923245168
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L53:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L54
       jmp       short M01_L55
M01_L54:
       mov       rdx,7FF9232451A8
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L55:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M01_L09
M01_L56:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L57
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L57
       jmp       short M01_L58
M01_L57:
       mov       rcx,rbx
       mov       rdx,7FF923244590
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L58:
       mov       rdx,rsi
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9231AF1F8]
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1914
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,rdx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M03_L01:
       call      qword ptr [7FF9231A7960]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229DD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF9231AD908]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FF9229D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark.OrderByWithoutComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,13CC9402A30
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L18
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rax,13CC9400068
       mov       r14,[rax]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L15
       xor       ecx,ecx
       mov       [rbp+20],rcx
       lea       rcx,[rbp+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       lea       rcx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+48],0
       mov       rdx,[rbp+18]
       mov       rcx,7FF9230B14C0
       call      qword ptr [7FF922D2C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L19
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rbp+30]
       mov       rcx,13CC9400A08
       cmp       r12,[rcx]
       je        near ptr M00_L20
M00_L01:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       mov       rdx,[rbp+28]
       movzx     r8d,byte ptr [rbp+48]
       mov       [rsp+54],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+38]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+38]
       mov       ecx,[rsp+54]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rbp+20],0
       jne       near ptr M00_L21
M00_L02:
       mov       rbp,rax
       mov       r12d,edi
       mov       rax,[rbp]
       mov       [rsp+40],rax
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       rax,rdx
       jne       near ptr M00_L25
       mov       r8,[rbp+8]
       mov       [rsp+28],r8
       mov       rdx,13CC9402A38
       cmp       r8,[rdx]
       je        near ptr M00_L23
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+20],rax
       xor       r10d,r10d
       mov       r9,[rsp+28]
       test      r9,r9
       je        short M00_L05
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L05
M00_L03:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,[rdx+30]
       mov       [rsp+50],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+50]
       inc       r10d
       cmp       edi,r10d
       jle       short M00_L07
       mov       rax,[rsp+20]
       jmp       short M00_L03
       nop       word ptr [rax+rax]
M00_L04:
       mov       rax,[rsp+20]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L26
       mov       [rsp+50],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L22
       mov       r8,[rdx+30]
M00_L06:
       mov       edx,[rsp+50]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+50]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+28]
       jg        short M00_L04
M00_L07:
       lea       rcx,[rbp+20]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       jne       near ptr M00_L24
M00_L09:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+30],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L11
       vmovups   ymm0,[7FF9230D5F80]
       vbroadcastss ymm1,dword ptr [7FF9230D5FA0]
       lea       rcx,[rdx-20]
M00_L10:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L10
       vmovd     ecx,xmm0
M00_L11:
       cmp       r9,rdx
       jb        near ptr M00_L16
M00_L12:
       lea       r9d,[r12-1]
       mov       rcx,rbp
       mov       rdx,rax
       xor       r8d,r8d
       mov       rbp,[rsp+40]
       mov       r10,[rbp+40]
       call      qword ptr [r10+30]
       mov       rbp,[rsp+30]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L14
       cmp       edi,r13d
       jl        near ptr M00_L17
       xor       r12d,r12d
M00_L13:
       lea       rcx,[r15+r12*2]
       mov       eax,[rbp+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L13
M00_L14:
       mov       [rsp+48],r14
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L15:
       mov       ecx,11
       call      qword ptr [7FF922BF7E58]
       int       3
M00_L16:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L16
       jmp       near ptr M00_L12
M00_L17:
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8]
       cmp       r12d,edi
       jae       near ptr M00_L26
       mov       edx,r12d
       mov       eax,[rbp+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L17
       jmp       near ptr M00_L14
M00_L18:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,13CC9402A20
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,13CC9402A30
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L19:
       mov       r14,rsi
       jmp       near ptr M00_L14
M00_L20:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FF922BF5DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF922D2DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M00_L01
M00_L21:
       mov       rcx,[rbp+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M00_L02
M00_L22:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+20]
       jmp       near ptr M00_L06
M00_L23:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229D58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rbp+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L24:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L25:
       mov       rcx,rbp
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rsp+40]
       mov       r10,[rax+40]
       call      qword ptr [r10+20]
       jmp       near ptr M00_L09
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1214
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FF9229D6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M01_L52
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9229D6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rax],rcx
       jne       near ptr M01_L37
       mov       rcx,rax
       call      qword ptr [7FF922DB3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L19
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF92317CD00
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L04:
       mov       rdx,rsi
       call      qword ptr [7FF922B4F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L58
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L11
M01_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L12
M01_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L53
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L14
M01_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M01_L09:
       mov       rax,rbx
       vzeroupper
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
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF92317CB98
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF92317CCE0
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF92317E7D8
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF92317E898
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF92317E8A0
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B4F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L44
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L38
       mov       ebx,[rsi+8]
M01_L16:
       test      ebx,ebx
       je        near ptr M01_L43
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L42
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L41
       cmp       ebp,[rsi+8]
       ja        near ptr M01_L41
       cmp       ebp,[rbx+8]
       ja        near ptr M01_L41
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L40
       cmp       r8,4000
       jbe       short M01_L17
       mov       rcx,rax
       call      qword ptr [7FF9230A4AF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L18
M01_L17:
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L39
M01_L18:
       mov       rax,rbx
M01_L19:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M01_L45
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,13CC9400A08
       cmp       r12,[rcx]
       je        near ptr M01_L46
M01_L20:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+5C],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+5C]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       jne       near ptr M01_L47
M01_L21:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M01_L51
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,13CC9402A38
       cmp       rax,[rdx]
       je        near ptr M01_L49
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M01_L24
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M01_L24
M01_L22:
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,[rdx+30]
       mov       [rsp+58],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+58]
       inc       r10d
       cmp       esi,r10d
       jle       short M01_L26
       mov       rax,[rsp+38]
       jmp       short M01_L22
M01_L23:
       mov       rax,[rsp+38]
M01_L24:
       cmp       r10d,esi
       jae       near ptr M01_L61
       mov       [rsp+58],r10d
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M01_L48
       mov       r8,[rdx+30]
M01_L25:
       mov       edx,[rsp+58]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+58]
       inc       ecx
       cmp       esi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M01_L23
M01_L26:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M01_L27:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       jne       near ptr M01_L50
M01_L28:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M01_L30
       vmovups   ymm0,[7FF9230D5800]
       vbroadcastss ymm1,dword ptr [7FF9230D5820]
       lea       rcx,[rdx-20]
M01_L29:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M01_L29
       vmovd     ecx,xmm0
M01_L30:
       cmp       r9,rdx
       jb        short M01_L35
M01_L31:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       ebp,ebp
       test      r13d,r13d
       jle       short M01_L33
       cmp       esi,r13d
       jl        short M01_L36
       xor       ebp,ebp
M01_L32:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M01_L61
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M01_L32
M01_L33:
       mov       rax,r14
M01_L34:
       vzeroupper
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
M01_L35:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M01_L35
       jmp       short M01_L31
M01_L36:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M01_L61
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M01_L61
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M01_L36
       jmp       short M01_L33
M01_L37:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L38:
       mov       rcx,rsi
       mov       r11,7FF922920B18
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L39:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L18
M01_L40:
       mov       rcx,rax
       call      qword ptr [7FF9229D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L18
M01_L41:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF922F7ED60]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L18
M01_L42:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922920B20
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L18
M01_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,13CC9402A70
       mov       rbx,[rdx]
       jmp       near ptr M01_L18
M01_L44:
       mov       rdx,rbx
       mov       rcx,7FF92318CA90
       call      qword ptr [7FF9231B7A50]
       jmp       near ptr M01_L19
M01_L45:
       jmp       near ptr M01_L34
M01_L46:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FF922BF5DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF922D2DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M01_L20
M01_L47:
       mov       rcx,[rdi+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rax,rdi
       jmp       near ptr M01_L21
M01_L48:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M01_L25
M01_L49:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229D58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L27
M01_L50:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L28
M01_L51:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L28
M01_L52:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L53:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L54
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L54
       jmp       short M01_L55
M01_L54:
       mov       rcx,rsi
       mov       rdx,7FF92317E878
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L55:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L56
       jmp       short M01_L57
M01_L56:
       mov       rdx,7FF92317E8B8
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L57:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M01_L09
M01_L58:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L59
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L59
       jmp       short M01_L60
M01_L59:
       mov       rcx,rbx
       mov       rdx,7FF92317CCA8
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L60:
       mov       rdx,rsi
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9231B7A50]
M01_L61:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2001
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M03_L01:
       call      qword ptr [7FF9231B7858]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229DD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF9231BC558]
       int       3
; Total bytes of code 44
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       call      qword ptr [7FF98245AEB0]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M05_L01
M05_L00:
       add       rsp,28
       ret
M05_L01:
       call      qword ptr [7FF9824597E8]
       mov       rcx,[rax+20]
       test      rcx,rcx
       jne       short M05_L02
       mov       rcx,[rax]
       test      rcx,rcx
       mov       rax,rcx
       jne       short M05_L00
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       jmp       qword ptr [rax]
M05_L02:
       mov       rax,rcx
       jmp       short M05_L00
; Total bytes of code 69
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
       jne       short M06_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M07_L04
       mov       rdi,[rbx]
       cmp       rdi,rsi
       je        near ptr M07_L04
       call      qword ptr [7FF982459C18]
       mov       rdx,[rax]
       add       rdx,10
       mov       rax,rdi
       rol       rax,20
       xor       rax,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rax,r8
       mov       ecx,[rdx]
       shr       rax,cl
       xor       ecx,ecx
M07_L00:
       lea       r8d,[rax+1]
       movsxd    r8,r8d
       lea       r8,[r8+r8*2]
       lea       r8,[rdx+r8*8]
       mov       r10d,[r8]
       and       r10d,0FFFFFFFE
       cmp       [r8+8],rdi
       jne       short M07_L01
       mov       r9,rsi
       xor       r9,[r8+10]
       cmp       r9,1
       jbe       short M07_L03
M07_L01:
       test      r10d,r10d
       je        short M07_L02
       inc       ecx
       add       eax,ecx
       and       eax,[rdx+4]
       cmp       ecx,8
       jl        short M07_L00
M07_L02:
       mov       rdx,rbx
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M07_L03:
       cmp       r10d,[r8]
       jne       short M07_L02
       cmp       r9d,1
       jne       short M07_L02
M07_L04:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark.OrderByWithComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rdi,rsi
       mov       rcx,1DFB5C00A48
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M00_L19
M00_L00:
       mov       r14,[rbx+2E8]
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L20
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       test      rdx,rdx
       je        near ptr M00_L21
M00_L01:
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rdx,rsi
       mov       rcx,7FF9231152B8
       call      qword ptr [7FF922D4C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L22
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r15+30]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rdx,[r15+28]
       movzx     r8d,byte ptr [r15+48]
       mov       [rsp+54],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       mov       ecx,[rsp+54]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r15+20],0
       jne       near ptr M00_L23
M00_L02:
       mov       r15,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rdx
       jne       near ptr M00_L25
       mov       rax,[r15+8]
       mov       [rsp+30],rax
       mov       rdx,1DFB5C00A58
       cmp       rax,[rdx]
       je        near ptr M00_L15
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       r9,[rsp+30]
       test      r9,r9
       je        short M00_L05
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L05
M00_L03:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,rdx
       mov       [rsp+50],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+50]
       inc       r10d
       cmp       edi,r10d
       jle       short M00_L07
       mov       rax,[rsp+28]
       jmp       short M00_L03
M00_L04:
       mov       rax,[rsp+28]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L26
       mov       [rsp+50],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L24
       mov       r8,rdx
M00_L06:
       mov       edx,[rsp+50]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+50]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+30]
       jg        short M00_L04
M00_L07:
       lea       rcx,[r15+20]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       jne       near ptr M00_L16
M00_L09:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L11
       vmovups   ymm0,[7FF923160E40]
       vbroadcastss ymm1,dword ptr [7FF923160E60]
       lea       rcx,[rdx-20]
M00_L10:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L10
       vmovd     ecx,xmm0
M00_L11:
       cmp       r9,rdx
       jb        near ptr M00_L17
M00_L12:
       lea       r9d,[r12-1]
       mov       rcx,r15
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r15]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       r15,[rsp+38]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L14
       cmp       edi,r13d
       jl        near ptr M00_L18
       xor       r12d,r12d
M00_L13:
       lea       rcx,[r14+r12*2]
       mov       eax,[r15+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L13
M00_L14:
       mov       [rsp+48],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L15:
       lea       rcx,[r15+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L16:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L17:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L17
       jmp       near ptr M00_L12
M00_L18:
       mov       ecx,r12d
       lea       rcx,[r14+rcx*8]
       cmp       r12d,edi
       jae       near ptr M00_L26
       mov       edx,r12d
       mov       eax,[r15+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L18
       jmp       near ptr M00_L14
M00_L19:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1DFB5C00A40
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DFB5C00A48
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L20:
       mov       ecx,11
       call      qword ptr [7FF922C17E58]
       int       3
M00_L21:
       mov       rcx,offset MT_System.Collections.Generic.Comparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1DFB5C00AF8
       mov       rdx,[rcx]
       jmp       near ptr M00_L01
M00_L22:
       mov       rbp,rsi
       jmp       near ptr M00_L14
M00_L23:
       mov       rcx,[r15+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r15,rax
       mov       rax,r15
       jmp       near ptr M00_L02
M00_L24:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+28]
       jmp       near ptr M00_L06
M00_L25:
       mov       rcx,r15
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1135
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rdx
       jne       near ptr M01_L50
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L37
       mov       rcx,rax
       call      qword ptr [7FF922DD3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L18
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF923264590
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L04:
       mov       rdx,rsi
       call      qword ptr [7FF922B6F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L56
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L11
M01_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L12
M01_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L51
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L14
M01_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M01_L09:
       mov       rax,rbx
       vzeroupper
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
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF923264428
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF923264570
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF923264A48
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF923264B08
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF923264B10
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B6F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L45
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L38
       mov       ebx,[rsi+8]
M01_L16:
       test      ebx,ebx
       je        near ptr M01_L44
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L43
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L42
       cmp       ebp,[rsi+8]
       ja        near ptr M01_L42
       cmp       ebp,[rbx+8]
       ja        near ptr M01_L42
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L41
       cmp       r8,4000
       ja        near ptr M01_L40
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L39
M01_L17:
       mov       rax,rbx
M01_L18:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M01_L46
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+5C],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+5C]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       jne       near ptr M01_L47
M01_L19:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rdx
       jne       near ptr M01_L49
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,1DFB5C00A58
       cmp       rax,[rdx]
       je        near ptr M01_L33
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M01_L22
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M01_L22
M01_L20:
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,rdx
       mov       [rsp+58],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+58]
       inc       r10d
       cmp       esi,r10d
       jle       short M01_L24
       mov       rax,[rsp+38]
       jmp       short M01_L20
M01_L21:
       mov       rax,[rsp+38]
M01_L22:
       cmp       r10d,esi
       jae       near ptr M01_L59
       mov       [rsp+58],r10d
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M01_L48
       mov       r8,rdx
M01_L23:
       mov       edx,[rsp+58]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+58]
       inc       ecx
       cmp       esi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M01_L21
M01_L24:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M01_L25:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       jne       near ptr M01_L34
M01_L26:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M01_L28
       vmovups   ymm0,[7FF92315E200]
       vbroadcastss ymm1,dword ptr [7FF92315E220]
       lea       rcx,[rdx-20]
M01_L27:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M01_L27
       vmovd     ecx,xmm0
M01_L28:
       cmp       r9,rdx
       jb        near ptr M01_L35
M01_L29:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       ebp,ebp
       test      r13d,r13d
       jle       short M01_L31
       cmp       esi,r13d
       jl        near ptr M01_L36
       xor       ebp,ebp
M01_L30:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M01_L59
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M01_L30
M01_L31:
       mov       rax,r14
M01_L32:
       vzeroupper
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
M01_L33:
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L25
M01_L34:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L26
M01_L35:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M01_L35
       jmp       near ptr M01_L29
M01_L36:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M01_L59
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M01_L59
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M01_L36
       jmp       near ptr M01_L31
M01_L37:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L38:
       mov       rcx,rsi
       mov       r11,7FF922940C10
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L39:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L17
M01_L40:
       mov       rcx,rax
       call      qword ptr [7FF922F9EEC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L41:
       mov       rcx,rax
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L42:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923026AC0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L17
M01_L43:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922940C18
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1DFB5C00AF0
       mov       rbx,[rdx]
       jmp       near ptr M01_L17
M01_L45:
       mov       rdx,rbx
       mov       rcx,7FF923277FE8
       call      qword ptr [7FF9231CF1F8]
       jmp       near ptr M01_L18
M01_L46:
       jmp       near ptr M01_L32
M01_L47:
       mov       rcx,[rdi+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rax,rdi
       jmp       near ptr M01_L19
M01_L48:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M01_L23
M01_L49:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L26
M01_L50:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L51:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L52
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L52
       jmp       short M01_L53
M01_L52:
       mov       rcx,rsi
       mov       rdx,7FF923264AE8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L53:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L54
       jmp       short M01_L55
M01_L54:
       mov       rdx,7FF923264B28
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L55:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M01_L09
M01_L56:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L57
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L57
       jmp       short M01_L58
M01_L57:
       mov       rcx,rbx
       mov       rdx,7FF923264538
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L58:
       mov       rdx,rsi
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9231CF1F8]
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1921
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,rdx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M03_L01:
       call      qword ptr [7FF9231CC0F0]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229FD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF9231CD8F0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FF9229F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark.OrderByWithoutComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rdi,rsi
       mov       rcx,2A2BD400A38
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M00_L18
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rax,2A2A7400068
       mov       r15,[rax]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L19
       xor       ecx,ecx
       mov       [r14+20],rcx
       lea       rcx,[r14+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[r14+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+48],0
       mov       rdx,rsi
       mov       rcx,7FF9230F14C0
       call      qword ptr [7FF922D6C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L20
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       r15,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r14+30]
       mov       rcx,2A2A7400A08
       cmp       r12,[rcx]
       je        near ptr M00_L21
M00_L01:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rdx,[r14+28]
       movzx     r8d,byte ptr [r14+48]
       mov       [rsp+54],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       mov       ecx,[rsp+54]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r14+20],0
       jne       near ptr M00_L22
M00_L02:
       mov       r14,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [r14],rdx
       jne       near ptr M00_L24
       mov       rax,[r14+8]
       mov       [rsp+30],rax
       mov       rdx,2A2BD400A40
       cmp       rax,[rdx]
       je        near ptr M00_L15
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       r9,[rsp+30]
       test      r9,r9
       je        short M00_L05
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L05
M00_L03:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,[rdx+30]
       mov       [rsp+50],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+50]
       inc       r10d
       cmp       edi,r10d
       jle       short M00_L07
       mov       rax,[rsp+28]
       jmp       short M00_L03
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M00_L04:
       mov       rax,[rsp+28]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L25
       mov       [rsp+50],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L23
       mov       r8,[rdx+30]
M00_L06:
       mov       edx,[rsp+50]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+50]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+30]
       jg        short M00_L04
M00_L07:
       lea       rcx,[r14+20]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+18]
       test      rcx,rcx
       jne       near ptr M00_L14
M00_L08:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L10
       vmovups   ymm0,[7FF923116460]
       vbroadcastss ymm1,dword ptr [7FF923116480]
       lea       rcx,[rdx-20]
M00_L09:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L09
       vmovd     ecx,xmm0
M00_L10:
       cmp       r9,rdx
       jb        near ptr M00_L16
M00_L11:
       lea       r9d,[r12-1]
       mov       rcx,r14
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r14]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       r14,[rsp+38]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L13
       cmp       edi,r13d
       jl        near ptr M00_L17
       xor       r12d,r12d
M00_L12:
       lea       rcx,[r15+r12*2]
       mov       eax,[r14+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L25
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L12
M00_L13:
       mov       [rsp+48],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L14:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L08
M00_L15:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF922A158D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M00_L16:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L16
       jmp       near ptr M00_L11
M00_L17:
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8]
       cmp       r12d,edi
       jae       near ptr M00_L25
       mov       edx,r12d
       mov       eax,[r14+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L25
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L17
       jmp       near ptr M00_L13
M00_L18:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2A2BD400A28
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF922A16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2A2BD400A38
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L19:
       mov       ecx,11
       call      qword ptr [7FF922C37E58]
       int       3
M00_L20:
       mov       rbp,rsi
       jmp       near ptr M00_L13
M00_L21:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FF922C35DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF922D6DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M00_L01
M00_L22:
       mov       rcx,[r14+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r14,rax
       mov       rax,r14
       jmp       near ptr M00_L02
M00_L23:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+28]
       jmp       near ptr M00_L06
M00_L24:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L08
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1194
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rsi
       call      qword ptr [7FF922A16850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M01_L54
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922A16850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rax],rcx
       jne       near ptr M01_L40
       mov       rcx,rax
       call      qword ptr [7FF922DF3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L21
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF9231BCE18
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L04:
       mov       rdx,rsi
       call      qword ptr [7FF922B8F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L60
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L11
M01_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L12
M01_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L55
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L14
M01_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M01_L09:
       mov       rax,rbx
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
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF9231BCCB0
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
       nop       dword ptr [rax+rax]
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF9231BCDF8
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9231BD990
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF9231BDA50
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF9231BDA58
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B8F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L49
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L41
       mov       ebx,[rsi+8]
M01_L16:
       test      ebx,ebx
       je        near ptr M01_L48
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L47
       mov       ebp,[rsi+8]
       mov       r14,[rsi]
       cmp       dword ptr [r14+4],18
       jne       short M01_L17
       cmp       ebp,[rsi+8]
       ja        short M01_L17
       cmp       ebp,[rbx+8]
       jbe       near ptr M01_L36
M01_L17:
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M01_L31
       xor       r14d,r14d
M01_L18:
       test      r14d,r14d
       jg        near ptr M01_L42
       mov       ecx,r14d
       neg       ecx
       js        near ptr M01_L43
       lea       edx,[rcx+rbp]
       cmp       edx,[rsi+8]
       ja        near ptr M01_L43
       mov       rdx,[rbx]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       jne       near ptr M01_L32
       xor       r14d,r14d
M01_L19:
       test      r14d,r14d
       jg        near ptr M01_L44
       mov       edx,r14d
       neg       edx
       js        near ptr M01_L45
       lea       r8d,[rdx+rbp]
       cmp       r8d,[rbx+8]
       ja        near ptr M01_L45
       mov       r8,[rsi]
       movzx     eax,word ptr [r8]
       mov       r10d,ebp
       imul      r10,rax
       mov       ecx,ecx
       imul      rcx,rax
       lea       r9,[rsi+rcx+10]
       mov       ecx,edx
       imul      rcx,rax
       lea       rcx,[rbx+rcx+10]
       test      dword ptr [r8],1000000
       je        near ptr M01_L33
       cmp       r10,4000
       ja        near ptr M01_L35
       mov       rdx,r9
       mov       r8,r10
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L46
M01_L20:
       mov       rax,rbx
M01_L21:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M01_L50
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,[rdi+30]
       mov       rcx,2A2A7400A08
       cmp       r13,[rcx]
       je        near ptr M01_L51
M01_L22:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,[rdi+28]
       movzx     eax,byte ptr [rdi+48]
       mov       [rsp+2C],eax
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rsp+2C]
       mov       [r12+28],r13b
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       r13,r12
       cmp       qword ptr [rdi+20],0
       jne       near ptr M01_L52
M01_L23:
       mov       edi,esi
       mov       r12,[r13]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       r12,rcx
       jne       near ptr M01_L53
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FF922DF66B8]; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M01_L24:
       mov       edx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+20],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,edi
       lea       rdx,[r9+rdx*4]
       cmp       edi,8
       jl        short M01_L26
       vmovups   ymm0,[7FF923113DC0]
       vbroadcastss ymm1,dword ptr [7FF923113DE0]
       lea       rcx,[rdx-20]
M01_L25:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M01_L25
       vmovd     ecx,xmm0
M01_L26:
       cmp       r9,rdx
       jb        near ptr M01_L38
M01_L27:
       lea       r9d,[rdi-1]
       mov       rcx,r13
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r12+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+20]
       xor       r13d,r13d
       test      r15d,r15d
       jle       short M01_L29
       cmp       esi,r15d
       jl        near ptr M01_L39
       xor       r13d,r13d
M01_L28:
       lea       rcx,[r14+r13*2]
       mov       r12d,[rdi+r13+10]
       cmp       r12d,esi
       jae       near ptr M01_L63
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r13,4
       dec       r15d
       jne       short M01_L28
M01_L29:
       mov       rax,rbp
M01_L30:
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
M01_L31:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       near ptr M01_L18
M01_L32:
       movsxd    rdx,edx
       mov       r14d,[rbx+rdx*4+10]
       jmp       near ptr M01_L19
M01_L33:
       cmp       r10,40
       je        short M01_L34
       mov       rdx,r9
       mov       r8,r10
       call      qword ptr [7FF922A15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L20
M01_L34:
       vmovdqu   ymm0,ymmword ptr [r9]
       vmovdqu   ymm1,ymmword ptr [r9+20]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm1
       jmp       near ptr M01_L20
M01_L35:
       mov       rdx,r9
       mov       r8,r10
       call      qword ptr [7FF9230E4AF8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L20
M01_L36:
       mov       r8d,ebp
       movzx     ecx,word ptr [r14]
       imul      r8,rcx
       lea       rdx,[rsi+10]
       lea       rcx,[rbx+10]
       test      dword ptr [r14],1000000
       jne       short M01_L37
       call      qword ptr [7FF922A15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L20
M01_L37:
       call      qword ptr [7FF922A157A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L20
M01_L38:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M01_L38
       jmp       near ptr M01_L27
M01_L39:
       mov       ecx,r13d
       lea       rcx,[r14+rcx*8]
       cmp       r13d,esi
       jae       near ptr M01_L63
       mov       edx,r13d
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M01_L63
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       cmp       r13d,r15d
       jl        short M01_L39
       jmp       near ptr M01_L29
M01_L40:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L41:
       mov       rcx,rsi
       mov       r11,7FF922960B18
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L42:
       mov       ecx,167
       mov       rdx,7FF922954000
       call      qword ptr [7FF922C37798]
       mov       r8,rax
       mov       edx,r14d
       xor       ecx,ecx
       call      qword ptr [7FF9231EC0A8]
       int       3
M01_L43:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9231EC138]
       mov       rbx,rax
       mov       ecx,12D
       mov       rdx,7FF922954000
       call      qword ptr [7FF922C37798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF922D67FA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L44:
       mov       ecx,17F
       mov       rdx,7FF922954000
       call      qword ptr [7FF922C37798]
       mov       r8,rax
       mov       edx,r14d
       xor       ecx,ecx
       call      qword ptr [7FF9231EC0A8]
       int       3
M01_L45:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF9231EC150]
       mov       rbp,rax
       mov       ecx,145
       mov       rdx,7FF922954000
       call      qword ptr [7FF922C37798]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,r14
       call      qword ptr [7FF922D67FA8]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M01_L46:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L20
M01_L47:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922960B20
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L20
M01_L48:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2A2BD400A70
       mov       rbx,[rdx]
       jmp       near ptr M01_L20
M01_L49:
       mov       rdx,rbx
       mov       rcx,7FF9231C9DF0
       call      qword ptr [7FF9231E7888]
       jmp       near ptr M01_L21
M01_L50:
       jmp       near ptr M01_L30
M01_L51:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF922C35DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FF922D6DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M01_L22
M01_L52:
       mov       rcx,[rdi+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M01_L23
M01_L53:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,edi
       mov       rax,[r12+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L24
M01_L54:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
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
       jmp       qword ptr [rax+30]
M01_L55:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L56
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L56
       jmp       short M01_L57
M01_L56:
       mov       rcx,rsi
       mov       rdx,7FF9231BDA30
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L57:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L58
       jmp       short M01_L59
M01_L58:
       mov       rdx,7FF9231BDA70
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L59:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M01_L09
M01_L60:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L61
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L61
       jmp       short M01_L62
M01_L61:
       mov       rcx,rbx
       mov       rdx,7FF9231BCDC0
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L62:
       mov       rdx,rsi
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
       jmp       qword ptr [7FF9231E7888]
M01_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2118
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M03_L01:
       call      qword ptr [7FF9231E7750]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF922A1D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M04_L04
       mov       rdi,[rbx]
       cmp       rdi,rsi
       je        near ptr M04_L04
       call      qword ptr [7FF982459C18]
       mov       rdx,[rax]
       add       rdx,10
       mov       rax,rdi
       rol       rax,20
       xor       rax,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rax,r8
       mov       ecx,[rdx]
       shr       rax,cl
       xor       ecx,ecx
M04_L00:
       lea       r8d,[rax+1]
       movsxd    r8,r8d
       lea       r8,[r8+r8*2]
       lea       r8,[rdx+r8*8]
       mov       r10d,[r8]
       and       r10d,0FFFFFFFE
       cmp       [r8+8],rdi
       jne       short M04_L01
       mov       r9,rsi
       xor       r9,[r8+10]
       cmp       r9,1
       jbe       short M04_L03
M04_L01:
       test      r10d,r10d
       je        short M04_L02
       inc       ecx
       add       eax,ecx
       and       eax,[rdx+4]
       cmp       ecx,8
       jl        short M04_L00
M04_L02:
       mov       rdx,rbx
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L03:
       cmp       r10d,[r8]
       jne       short M04_L02
       cmp       r9d,1
       jne       short M04_L02
M04_L04:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 181
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FF9231EEB20]
       int       3
; Total bytes of code 44
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       call      qword ptr [7FF98245AEB0]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M06_L01
M06_L00:
       add       rsp,28
       ret
M06_L01:
       call      qword ptr [7FF9824597E8]
       mov       rcx,[rax+20]
       test      rcx,rcx
       jne       short M06_L02
       mov       rcx,[rax]
       test      rcx,rcx
       mov       rax,rcx
       jne       short M06_L00
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       jmp       qword ptr [rax]
M06_L02:
       mov       rax,rcx
       jmp       short M06_L00
; Total bytes of code 69
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
       jne       short M07_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
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

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark.OrderByWithComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rdi,rsi
       mov       rcx,22D65802A40
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M00_L19
M00_L00:
       mov       r14,[rbx+2E8]
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L20
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       test      rdx,rdx
       je        near ptr M00_L21
M00_L01:
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rdx,rsi
       mov       rcx,7FF9231052B8
       call      qword ptr [7FF922D3C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L22
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r15+30]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rdx,[r15+28]
       movzx     r8d,byte ptr [r15+48]
       mov       [rsp+54],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       mov       ecx,[rsp+54]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r15+20],0
       jne       near ptr M00_L23
M00_L02:
       mov       r15,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rdx
       jne       near ptr M00_L25
       mov       rax,[r15+8]
       mov       [rsp+30],rax
       mov       rdx,22D65802A50
       cmp       rax,[rdx]
       je        near ptr M00_L15
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       r9,[rsp+30]
       test      r9,r9
       je        short M00_L05
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L05
M00_L03:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,rdx
       mov       [rsp+50],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+50]
       inc       r10d
       cmp       edi,r10d
       jle       short M00_L07
       mov       rax,[rsp+28]
       jmp       short M00_L03
M00_L04:
       mov       rax,[rsp+28]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L26
       mov       [rsp+50],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L24
       mov       r8,rdx
M00_L06:
       mov       edx,[rsp+50]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+50]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+30]
       jg        short M00_L04
M00_L07:
       lea       rcx,[r15+20]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       jne       near ptr M00_L16
M00_L09:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L11
       vmovups   ymm0,[7FF923151080]
       vbroadcastss ymm1,dword ptr [7FF9231510A0]
       lea       rcx,[rdx-20]
M00_L10:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L10
       vmovd     ecx,xmm0
M00_L11:
       cmp       r9,rdx
       jb        near ptr M00_L17
M00_L12:
       lea       r9d,[r12-1]
       mov       rcx,r15
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r15]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       r15,[rsp+38]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L14
       cmp       edi,r13d
       jl        near ptr M00_L18
       xor       r12d,r12d
M00_L13:
       lea       rcx,[r14+r12*2]
       mov       eax,[r15+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L13
M00_L14:
       mov       [rsp+48],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L15:
       lea       rcx,[r15+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L16:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L17:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L17
       jmp       near ptr M00_L12
M00_L18:
       mov       ecx,r12d
       lea       rcx,[r14+rcx*8]
       cmp       r12d,edi
       jae       near ptr M00_L26
       mov       edx,r12d
       mov       eax,[r15+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L18
       jmp       near ptr M00_L14
M00_L19:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,22D65802A38
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22D65802A40
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L20:
       mov       ecx,11
       call      qword ptr [7FF922C07E58]
       int       3
M00_L21:
       mov       rcx,offset MT_System.Collections.Generic.Comparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,22D65802AF0
       mov       rdx,[rcx]
       jmp       near ptr M00_L01
M00_L22:
       mov       rbp,rsi
       jmp       near ptr M00_L14
M00_L23:
       mov       rcx,[r15+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r15,rax
       mov       rax,r15
       jmp       near ptr M00_L02
M00_L24:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+28]
       jmp       near ptr M00_L06
M00_L25:
       mov       rcx,r15
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1135
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rdx
       jne       near ptr M01_L50
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L37
       mov       rcx,rax
       call      qword ptr [7FF922DC3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L18
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF923254C38
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L04:
       mov       rdx,rsi
       call      qword ptr [7FF922B5F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L56
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L11
M01_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L12
M01_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L51
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L14
M01_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M01_L09:
       mov       rax,rbx
       vzeroupper
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
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF923254AD0
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF923254C18
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9232550F0
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF9232551B0
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF9232551B8
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B5F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L45
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L38
       mov       ebx,[rsi+8]
M01_L16:
       test      ebx,ebx
       je        near ptr M01_L44
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L43
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L42
       cmp       ebp,[rsi+8]
       ja        near ptr M01_L42
       cmp       ebp,[rbx+8]
       ja        near ptr M01_L42
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L41
       cmp       r8,4000
       ja        near ptr M01_L40
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L39
M01_L17:
       mov       rax,rbx
M01_L18:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M01_L46
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+5C],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+5C]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       jne       near ptr M01_L47
M01_L19:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rdx
       jne       near ptr M01_L49
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,22D65802A50
       cmp       rax,[rdx]
       je        near ptr M01_L33
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M01_L22
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M01_L22
M01_L20:
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,rdx
       mov       [rsp+58],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+58]
       inc       r10d
       cmp       esi,r10d
       jle       short M01_L24
       mov       rax,[rsp+38]
       jmp       short M01_L20
M01_L21:
       mov       rax,[rsp+38]
M01_L22:
       cmp       r10d,esi
       jae       near ptr M01_L59
       mov       [rsp+58],r10d
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M01_L48
       mov       r8,rdx
M01_L23:
       mov       edx,[rsp+58]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+58]
       inc       ecx
       cmp       esi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M01_L21
M01_L24:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M01_L25:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       jne       near ptr M01_L34
M01_L26:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M01_L28
       vmovups   ymm0,[7FF92314F400]
       vbroadcastss ymm1,dword ptr [7FF92314F420]
       lea       rcx,[rdx-20]
M01_L27:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M01_L27
       vmovd     ecx,xmm0
M01_L28:
       cmp       r9,rdx
       jb        near ptr M01_L35
M01_L29:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       ebp,ebp
       test      r13d,r13d
       jle       short M01_L31
       cmp       esi,r13d
       jl        near ptr M01_L36
       xor       ebp,ebp
M01_L30:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M01_L59
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M01_L30
M01_L31:
       mov       rax,r14
M01_L32:
       vzeroupper
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
M01_L33:
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L25
M01_L34:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L26
M01_L35:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M01_L35
       jmp       near ptr M01_L29
M01_L36:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M01_L59
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M01_L59
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M01_L36
       jmp       near ptr M01_L31
M01_L37:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L38:
       mov       rcx,rsi
       mov       r11,7FF922930C10
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L39:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L17
M01_L40:
       mov       rcx,rax
       call      qword ptr [7FF922F8EEC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L41:
       mov       rcx,rax
       call      qword ptr [7FF9229E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L42:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923026AC0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L17
M01_L43:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922930C18
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,22D65802AE8
       mov       rbx,[rdx]
       jmp       near ptr M01_L17
M01_L45:
       mov       rdx,rbx
       mov       rcx,7FF923268460
       call      qword ptr [7FF9231BF210]
       jmp       near ptr M01_L18
M01_L46:
       jmp       near ptr M01_L32
M01_L47:
       mov       rcx,[rdi+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rax,rdi
       jmp       near ptr M01_L19
M01_L48:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M01_L23
M01_L49:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L26
M01_L50:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L51:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L52
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L52
       jmp       short M01_L53
M01_L52:
       mov       rcx,rsi
       mov       rdx,7FF923255190
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L53:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L54
       jmp       short M01_L55
M01_L54:
       mov       rdx,7FF9232551D0
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L55:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M01_L09
M01_L56:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L57
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L57
       jmp       short M01_L58
M01_L57:
       mov       rcx,rbx
       mov       rdx,7FF923254BE0
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L58:
       mov       rdx,rsi
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9231BF210]
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1921
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,rdx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M03_L01:
       call      qword ptr [7FF9231B7948]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229ED8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF9231BD8F0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FF9229E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark.OrderByWithoutComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rdi,rsi
       mov       rcx,20151800A50
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M00_L18
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rax,2013B800068
       mov       r15,[rax]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L19
       xor       ecx,ecx
       mov       [r14+20],rcx
       lea       rcx,[r14+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[r14+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+48],0
       mov       rdx,rsi
       mov       rcx,7FF923115648
       call      qword ptr [7FF922D4C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L20
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       r15,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r14+30]
       mov       rcx,2013B800A08
       cmp       r12,[rcx]
       je        near ptr M00_L21
M00_L01:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rdx,[r14+28]
       movzx     r8d,byte ptr [r14+48]
       mov       [rsp+54],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       mov       ecx,[rsp+54]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r14+20],0
       jne       near ptr M00_L22
M00_L02:
       mov       r14,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [r14],rdx
       jne       near ptr M00_L24
       mov       rax,[r14+8]
       mov       [rsp+30],rax
       mov       rdx,20151800A58
       cmp       rax,[rdx]
       je        near ptr M00_L15
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       r9,[rsp+30]
       test      r9,r9
       je        short M00_L05
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L05
M00_L03:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,[rdx+30]
       mov       [rsp+50],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+50]
       inc       r10d
       cmp       edi,r10d
       jle       short M00_L07
       mov       rax,[rsp+28]
       jmp       short M00_L03
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M00_L04:
       mov       rax,[rsp+28]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L25
       mov       [rsp+50],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L23
       mov       r8,[rdx+30]
M00_L06:
       mov       edx,[rsp+50]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+50]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+30]
       jg        short M00_L04
M00_L07:
       lea       rcx,[r14+20]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+18]
       test      rcx,rcx
       jne       near ptr M00_L14
M00_L08:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L10
       vmovups   ymm0,[7FF923161AC0]
       vbroadcastss ymm1,dword ptr [7FF923161AE0]
       lea       rcx,[rdx-20]
M00_L09:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L09
       vmovd     ecx,xmm0
M00_L10:
       cmp       r9,rdx
       jb        near ptr M00_L16
M00_L11:
       lea       r9d,[r12-1]
       mov       rcx,r14
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r14]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       r14,[rsp+38]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L13
       cmp       edi,r13d
       jl        near ptr M00_L17
       xor       r12d,r12d
M00_L12:
       lea       rcx,[r15+r12*2]
       mov       eax,[r14+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L25
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L12
M00_L13:
       mov       [rsp+48],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L14:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L08
M00_L15:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M00_L16:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L16
       jmp       near ptr M00_L11
M00_L17:
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8]
       cmp       r12d,edi
       jae       near ptr M00_L25
       mov       edx,r12d
       mov       eax,[r14+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L25
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L17
       jmp       near ptr M00_L13
M00_L18:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,20151800A40
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20151800A50
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L19:
       mov       ecx,11
       call      qword ptr [7FF922C17E58]
       int       3
M00_L20:
       mov       rbp,rsi
       jmp       near ptr M00_L13
M00_L21:
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
       call      qword ptr [7FF922D4DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M00_L01
M00_L22:
       mov       rcx,[r14+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r14,rax
       mov       rax,r14
       jmp       near ptr M00_L02
M00_L23:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+28]
       jmp       near ptr M00_L06
M00_L24:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L08
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1194
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M01_L51
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rax],rcx
       jne       near ptr M01_L38
       mov       rcx,rax
       call      qword ptr [7FF922DD3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L19
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF923264B18
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L04:
       mov       rdx,rsi
       call      qword ptr [7FF922B6F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L57
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L11
M01_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L12
M01_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L52
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L14
M01_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M01_L09:
       mov       rax,rbx
       vzeroupper
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
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF9232649B0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF923264AF8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF923265008
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF9232650C8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF9232650D0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B6F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L45
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L39
       mov       ebx,[rsi+8]
M01_L16:
       test      ebx,ebx
       je        near ptr M01_L44
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L43
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L42
       cmp       ebp,[rsi+8]
       ja        near ptr M01_L42
       cmp       ebp,[rbx+8]
       ja        near ptr M01_L42
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L41
       cmp       r8,4000
       jbe       short M01_L17
       mov       rcx,rax
       call      qword ptr [7FF9230EC7C8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L18
M01_L17:
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L40
M01_L18:
       mov       rax,rbx
M01_L19:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M01_L46
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,2013B800A08
       cmp       r12,[rcx]
       je        near ptr M01_L47
M01_L20:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+5C],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+5C]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       jne       near ptr M01_L48
M01_L21:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M01_L50
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,20151800A58
       cmp       rax,[rdx]
       je        near ptr M01_L35
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M01_L24
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M01_L24
M01_L22:
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,[rdx+30]
       mov       [rsp+58],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+58]
       inc       r10d
       cmp       esi,r10d
       jle       short M01_L26
       mov       rax,[rsp+38]
       jmp       short M01_L22
M01_L23:
       mov       rax,[rsp+38]
M01_L24:
       cmp       r10d,esi
       jae       near ptr M01_L60
       mov       [rsp+58],r10d
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M01_L49
       mov       r8,[rdx+30]
M01_L25:
       mov       edx,[rsp+58]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+58]
       inc       ecx
       cmp       esi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M01_L23
M01_L26:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+18]
       test      rcx,rcx
       jne       near ptr M01_L34
M01_L27:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M01_L29
       vmovups   ymm0,[7FF92315FE40]
       vbroadcastss ymm1,dword ptr [7FF92315FE60]
       lea       rcx,[rdx-20]
M01_L28:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M01_L28
       vmovd     ecx,xmm0
M01_L29:
       cmp       r9,rdx
       jb        near ptr M01_L36
M01_L30:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       ebp,ebp
       test      r13d,r13d
       jle       short M01_L32
       cmp       esi,r13d
       jl        near ptr M01_L37
       xor       ebp,ebp
       nop
M01_L31:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M01_L60
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M01_L31
M01_L32:
       mov       rax,r14
M01_L33:
       vzeroupper
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
M01_L34:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L27
M01_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M01_L36:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M01_L36
       jmp       near ptr M01_L30
M01_L37:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M01_L60
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M01_L60
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M01_L37
       jmp       near ptr M01_L32
M01_L38:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L39:
       mov       rcx,rsi
       mov       r11,7FF922940C18
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L18
M01_L41:
       mov       rcx,rax
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L18
M01_L42:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923036AA8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L18
M01_L43:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922940C20
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L18
M01_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,20151800AF0
       mov       rbx,[rdx]
       jmp       near ptr M01_L18
M01_L45:
       mov       rdx,rbx
       mov       rcx,7FF9232781E8
       call      qword ptr [7FF9231CF1B0]
       jmp       near ptr M01_L19
M01_L46:
       jmp       near ptr M01_L33
M01_L47:
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
       call      qword ptr [7FF922D4DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M01_L20
M01_L48:
       mov       rcx,[rdi+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rax,rdi
       jmp       near ptr M01_L21
M01_L49:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M01_L25
M01_L50:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L27
M01_L51:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L52:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L53
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L53
       jmp       short M01_L54
M01_L53:
       mov       rcx,rsi
       mov       rdx,7FF9232650A8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L54:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L55
       jmp       short M01_L56
M01_L55:
       mov       rdx,7FF9232650E8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L56:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M01_L09
M01_L57:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L58
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L58
       jmp       short M01_L59
M01_L58:
       mov       rcx,rbx
       mov       rdx,7FF923264AC0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L59:
       mov       rdx,rsi
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9231CF1B0]
M01_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1984
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M03_L01:
       call      qword ptr [7FF9231C7858]
       int       3
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229FD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M04_L05
       mov       rcx,[rbx]
       cmp       rcx,rsi
       je        near ptr M04_L04
       mov       rax,2013B800038
       mov       rax,[rax]
       add       rax,10
       rorx      rdx,rcx,20
       xor       rdx,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rdx,r8
       mov       r8d,[rax]
       shrx      rdx,rdx,r8
       xor       r8d,r8d
M04_L00:
       lea       r10d,[rdx+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rax+r10*8]
       mov       r9d,[r10]
       and       r9d,0FFFFFFFE
       cmp       [r10+8],rcx
       jne       short M04_L01
       mov       r11,rsi
       xor       r11,[r10+10]
       cmp       r11,1
       jbe       short M04_L03
M04_L01:
       test      r9d,r9d
       je        short M04_L02
       inc       r8d
       add       edx,r8d
       and       edx,[rax+4]
       cmp       r8d,8
       jl        short M04_L00
M04_L02:
       mov       rcx,7FF923234834
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF9229F6340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M04_L03:
       cmp       r9d,[r10]
       jne       short M04_L02
       cmp       r11d,1
       jne       short M04_L02
       mov       rcx,7FF923234828
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L05
M04_L04:
       mov       rcx,7FF923234830
       call      CORINFO_HELP_COUNTPROFILE32
M04_L05:
       mov       rcx,7FF92323482C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 246
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FF9231CD8A8]
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
       jle       short M06_L03
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M06_L03
M06_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       je        short M06_L02
M06_L01:
       mov       rcx,7FF923233240
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M06_L02:
       mov       rcx,2013B800110
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M06_L05
       mov       rcx,2013B8000F0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M06_L04
       mov       rcx,7FF923233248
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M06_L01
M06_L03:
       mov       ecx,2
       call      qword ptr [7FF9231CD4A0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M06_L00
M06_L04:
       mov       rcx,7FF923233244
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF923233240
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF922C15E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
M06_L05:
       mov       rcx,7FF92323324C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M06_L01
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
       jne       short M07_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
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

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark.OrderByWithComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rdi,rsi
       mov       rcx,18FCB402A38
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M00_L19
M00_L00:
       mov       r14,[rbx+2E8]
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L20
       xor       ecx,ecx
       mov       [r15+20],rcx
       lea       rcx,[r15+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       test      rdx,rdx
       je        near ptr M00_L21
M00_L01:
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+48],0
       mov       rdx,rsi
       mov       rcx,7FF92318D980
       call      qword ptr [7FF922D2C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L22
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r15+30]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rdx,[r15+28]
       movzx     r8d,byte ptr [r15+48]
       mov       [rsp+54],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       mov       ecx,[rsp+54]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r15+20],0
       jne       near ptr M00_L23
M00_L02:
       mov       r15,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rdx
       jne       near ptr M00_L25
       mov       rax,[r15+8]
       mov       [rsp+30],rax
       mov       rdx,18FCB402A48
       cmp       rax,[rdx]
       je        near ptr M00_L17
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       r9,[rsp+30]
       test      r9,r9
       je        short M00_L05
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L05
M00_L03:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,rdx
       mov       [rsp+50],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+50]
       inc       r10d
       cmp       edi,r10d
       jle       short M00_L07
       mov       rax,[rsp+28]
       jmp       short M00_L03
M00_L04:
       mov       rax,[rsp+28]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L26
       mov       [rsp+50],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L24
       mov       r8,rdx
M00_L06:
       mov       edx,[rsp+50]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+50]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+30]
       jg        short M00_L04
M00_L07:
       lea       rcx,[r15+20]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       jne       near ptr M00_L18
M00_L09:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L11
       vmovups   ymm0,[7FF923165FE0]
       vbroadcastss ymm1,dword ptr [7FF923166000]
       lea       rcx,[rdx-20]
M00_L10:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L10
       vmovd     ecx,xmm0
M00_L11:
       cmp       r9,rdx
       jb        near ptr M00_L15
M00_L12:
       lea       r9d,[r12-1]
       mov       rcx,r15
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r15]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       r15,[rsp+38]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L14
       cmp       edi,r13d
       jl        short M00_L16
       xor       r12d,r12d
M00_L13:
       lea       rcx,[r14+r12*2]
       mov       eax,[r15+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L13
M00_L14:
       mov       [rsp+48],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L15:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L15
       jmp       near ptr M00_L12
M00_L16:
       mov       ecx,r12d
       lea       rcx,[r14+rcx*8]
       cmp       r12d,edi
       jae       near ptr M00_L26
       mov       edx,r12d
       mov       eax,[r15+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L26
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L16
       jmp       near ptr M00_L14
M00_L17:
       lea       rcx,[r15+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L18:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L19:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,18FCB402A30
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,18FCB402A38
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L20:
       mov       ecx,11
       call      qword ptr [7FF922BF7E58]
       int       3
M00_L21:
       mov       rcx,offset MT_System.Collections.Generic.Comparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,18FCB402B48
       mov       rdx,[rcx]
       jmp       near ptr M00_L01
M00_L22:
       mov       rbp,rsi
       jmp       near ptr M00_L14
M00_L23:
       mov       rcx,[r15+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r15,rax
       mov       rax,r15
       jmp       near ptr M00_L02
M00_L24:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+28]
       jmp       near ptr M00_L06
M00_L25:
       mov       rcx,r15
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1131
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rdx
       jne       near ptr M01_L50
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L37
       mov       rcx,rax
       call      qword ptr [7FF922DB3340]; Precode of System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L18
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF92325B928
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L04:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L56
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L11
M01_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L12
M01_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L51
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L14
M01_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M01_L09:
       mov       rax,rbx
       vzeroupper
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
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF92325B7C0
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF92325B908
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF92325C238
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF92325C2F8
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF92325C300
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L45
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L38
       mov       ebx,[rsi+8]
M01_L16:
       test      ebx,ebx
       je        near ptr M01_L44
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L43
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L42
       cmp       ebp,[rsi+8]
       ja        near ptr M01_L42
       cmp       ebp,[rbx+8]
       ja        near ptr M01_L42
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L41
       cmp       r8,4000
       ja        near ptr M01_L40
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L39
M01_L17:
       mov       rax,rbx
M01_L18:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M01_L46
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+5C],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+5C]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       jne       near ptr M01_L47
M01_L19:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rdx
       jne       near ptr M01_L49
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,18FCB402A48
       cmp       rax,[rdx]
       je        near ptr M01_L35
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M01_L22
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M01_L22
M01_L20:
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,rdx
       mov       [rsp+58],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+58]
       inc       r10d
       cmp       esi,r10d
       jle       short M01_L24
       mov       rax,[rsp+38]
       jmp       short M01_L20
M01_L21:
       mov       rax,[rsp+38]
M01_L22:
       cmp       r10d,esi
       jae       near ptr M01_L59
       mov       [rsp+58],r10d
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M01_L48
       mov       r8,rdx
M01_L23:
       mov       edx,[rsp+58]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+58]
       inc       ecx
       cmp       esi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M01_L21
M01_L24:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M01_L25:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       jne       near ptr M01_L36
M01_L26:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M01_L28
       vmovups   ymm0,[7FF923165860]
       vbroadcastss ymm1,dword ptr [7FF923165880]
       lea       rcx,[rdx-20]
M01_L27:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M01_L27
       vmovd     ecx,xmm0
M01_L28:
       cmp       r9,rdx
       jb        short M01_L33
M01_L29:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       ebp,ebp
       test      r13d,r13d
       jle       short M01_L31
       cmp       esi,r13d
       jl        short M01_L34
       xor       ebp,ebp
M01_L30:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M01_L59
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M01_L30
M01_L31:
       mov       rax,r14
M01_L32:
       vzeroupper
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
M01_L33:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M01_L33
       jmp       short M01_L29
M01_L34:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M01_L59
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M01_L59
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M01_L34
       jmp       short M01_L31
M01_L35:
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L25
M01_L36:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L26
M01_L37:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L38:
       mov       rcx,rsi
       mov       r11,7FF922920E10
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L39:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L17
M01_L40:
       mov       rcx,rax
       call      qword ptr [7FF922F7EEC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L41:
       mov       rcx,rax
       call      qword ptr [7FF9229D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L42:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF9230069D0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L17
M01_L43:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922920E18
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,18FCB402B40
       mov       rbx,[rdx]
       jmp       near ptr M01_L17
M01_L45:
       mov       rdx,rbx
       mov       rcx,7FF92327C358
       call      qword ptr [7FF9231BFDE0]
       jmp       near ptr M01_L18
M01_L46:
       jmp       near ptr M01_L32
M01_L47:
       mov       rcx,[rdi+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rax,rdi
       jmp       near ptr M01_L19
M01_L48:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M01_L23
M01_L49:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L26
M01_L50:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L51:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L52
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L52
       jmp       short M01_L53
M01_L52:
       mov       rcx,rsi
       mov       rdx,7FF92325C2D8
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L53:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L54
       jmp       short M01_L55
M01_L54:
       mov       rdx,7FF9231FDC00
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L55:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M01_L09
M01_L56:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L57
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L57
       jmp       short M01_L58
M01_L57:
       mov       rcx,rbx
       mov       rdx,7FF92325B8D0
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L58:
       mov       rdx,rsi
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9231BFDE0]
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1907
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,rdx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L03
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L01
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M03_L01:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       jmp       short M03_L04
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       call      qword ptr [7FF9230C4A98]
       int       3
M03_L04:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229DD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 96
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF9231BD848]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FF9229D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark.OrderByWithoutComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rdi,rsi
       mov       rcx,14A16000A50
       mov       rbp,[rcx]
       test      rbp,rbp
       je        near ptr M00_L18
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rax,14A00000068
       mov       r15,[rax]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M00_L19
       xor       ecx,ecx
       mov       [r14+20],rcx
       lea       rcx,[r14+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[r14+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+48],0
       mov       rdx,rsi
       mov       rcx,7FF9231B0FF0
       call      qword ptr [7FF922D3C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L20
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       r15,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r14+30]
       mov       rcx,14A00000A08
       cmp       r12,[rcx]
       je        near ptr M00_L21
M00_L01:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rdx,[r14+28]
       movzx     r8d,byte ptr [r14+48]
       mov       [rsp+54],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       mov       ecx,[rsp+54]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r14+20],0
       jne       near ptr M00_L22
M00_L02:
       mov       r14,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [r14],rdx
       jne       near ptr M00_L24
       mov       rax,[r14+8]
       mov       [rsp+30],rax
       mov       rdx,14A16000A58
       cmp       rax,[rdx]
       je        near ptr M00_L15
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       r9,[rsp+30]
       test      r9,r9
       je        short M00_L05
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L05
M00_L03:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,[rdx+30]
       mov       [rsp+50],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+50]
       inc       r10d
       cmp       edi,r10d
       jle       short M00_L07
       mov       rax,[rsp+28]
       jmp       short M00_L03
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M00_L04:
       mov       rax,[rsp+28]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L25
       mov       [rsp+50],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L23
       mov       r8,[rdx+30]
M00_L06:
       mov       edx,[rsp+50]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+50]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+30]
       jg        short M00_L04
M00_L07:
       lea       rcx,[r14+20]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+18]
       test      rcx,rcx
       jne       near ptr M00_L14
M00_L08:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L10
       vmovups   ymm0,[7FF923178F00]
       vbroadcastss ymm1,dword ptr [7FF923178F20]
       lea       rcx,[rdx-20]
M00_L09:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L09
       vmovd     ecx,xmm0
M00_L10:
       cmp       r9,rdx
       jb        near ptr M00_L16
M00_L11:
       lea       r9d,[r12-1]
       mov       rcx,r14
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r14]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       r14,[rsp+38]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L13
       cmp       edi,r13d
       jl        near ptr M00_L17
       xor       r12d,r12d
M00_L12:
       lea       rcx,[r15+r12*2]
       mov       eax,[r14+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L25
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L12
M00_L13:
       mov       [rsp+48],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L14:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L08
M00_L15:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229E58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M00_L16:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L16
       jmp       near ptr M00_L11
M00_L17:
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8]
       cmp       r12d,edi
       jae       near ptr M00_L25
       mov       edx,r12d
       mov       eax,[r14+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L25
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L17
       jmp       near ptr M00_L13
M00_L18:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,14A16000A40
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,14A16000A50
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L19:
       mov       ecx,11
       call      qword ptr [7FF922C07E58]
       int       3
M00_L20:
       mov       rbp,rsi
       jmp       near ptr M00_L13
M00_L21:
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
       call      qword ptr [7FF922D3DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M00_L01
M00_L22:
       mov       rcx,[r14+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r14,rax
       mov       rax,r14
       jmp       near ptr M00_L02
M00_L23:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+28]
       jmp       near ptr M00_L06
M00_L24:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L08
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1194
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M01_L51
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rax],rcx
       jne       near ptr M01_L37
       mov       rcx,rax
       call      qword ptr [7FF922DC3340]; Precode of System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L18
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF92327A680
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L04:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L57
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L11
M01_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L12
M01_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L52
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L14
M01_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M01_L09:
       mov       rax,rbx
       vzeroupper
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
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF92327A518
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF92327A660
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF92327AFB8
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF92327B078
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF92327B080
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L45
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L38
       mov       ebx,[rsi+8]
M01_L16:
       test      ebx,ebx
       je        near ptr M01_L44
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L43
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L42
       cmp       ebp,[rsi+8]
       ja        near ptr M01_L42
       cmp       ebp,[rbx+8]
       ja        near ptr M01_L42
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L41
       cmp       r8,4000
       ja        near ptr M01_L40
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L39
M01_L17:
       mov       rax,rbx
M01_L18:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M01_L46
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,14A00000A08
       cmp       r12,[rcx]
       je        near ptr M01_L47
M01_L19:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+5C],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+5C]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       jne       near ptr M01_L48
M01_L20:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M01_L50
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,14A16000A58
       cmp       rax,[rdx]
       je        near ptr M01_L34
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M01_L23
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M01_L23
M01_L21:
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,[rdx+30]
       mov       [rsp+58],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+58]
       inc       r10d
       cmp       esi,r10d
       jle       short M01_L25
       mov       rax,[rsp+38]
       jmp       short M01_L21
M01_L22:
       mov       rax,[rsp+38]
M01_L23:
       cmp       r10d,esi
       jae       near ptr M01_L60
       mov       [rsp+58],r10d
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M01_L49
       mov       r8,[rdx+30]
M01_L24:
       mov       edx,[rsp+58]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+58]
       inc       ecx
       cmp       esi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M01_L22
M01_L25:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+18]
       test      rcx,rcx
       jne       near ptr M01_L33
M01_L26:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M01_L28
       vmovups   ymm0,[7FF923178740]
       vbroadcastss ymm1,dword ptr [7FF923178760]
       lea       rcx,[rdx-20]
M01_L27:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M01_L27
       vmovd     ecx,xmm0
M01_L28:
       cmp       r9,rdx
       jb        near ptr M01_L35
M01_L29:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       ebp,ebp
       test      r13d,r13d
       jle       short M01_L31
       cmp       esi,r13d
       jl        near ptr M01_L36
       xor       ebp,ebp
M01_L30:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M01_L60
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M01_L30
M01_L31:
       mov       rax,r14
M01_L32:
       vzeroupper
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
M01_L33:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L26
M01_L34:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229E58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M01_L35:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M01_L35
       jmp       near ptr M01_L29
M01_L36:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M01_L60
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M01_L60
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M01_L36
       jmp       near ptr M01_L31
M01_L37:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L38:
       mov       rcx,rsi
       mov       r11,7FF922930E10
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L39:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L17
M01_L40:
       mov       rcx,rax
       call      qword ptr [7FF922F8F360]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L41:
       mov       rcx,rax
       call      qword ptr [7FF9229E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L42:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923026AD8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L17
M01_L43:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922930E18
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,14A16000B50
       mov       rbx,[rdx]
       jmp       near ptr M01_L17
M01_L45:
       mov       rdx,rbx
       mov       rcx,7FF92328CA00
       call      qword ptr [7FF9231CFEA0]
       jmp       near ptr M01_L18
M01_L46:
       jmp       near ptr M01_L32
M01_L47:
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
       call      qword ptr [7FF922D3DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M01_L19
M01_L48:
       mov       rcx,[rdi+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rax,rdi
       jmp       near ptr M01_L20
M01_L49:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M01_L24
M01_L50:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L26
M01_L51:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L52:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L53
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L53
       jmp       short M01_L54
M01_L53:
       mov       rcx,rsi
       mov       rdx,7FF92327B058
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L54:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L55
       jmp       short M01_L56
M01_L55:
       mov       rdx,7FF92320BC90
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L56:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M01_L09
M01_L57:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L58
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L58
       jmp       short M01_L59
M01_L58:
       mov       rcx,rbx
       mov       rdx,7FF92327A628
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L59:
       mov       rdx,rsi
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9231CFEA0]
M01_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1988
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L03
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       jne       short M03_L01
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M03_L01:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M03_L00
       jmp       short M03_L04
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L03:
       call      qword ptr [7FF9230D4BE8]
       int       3
M03_L04:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229ED8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 96
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M04_L05
       mov       rcx,[rbx]
       cmp       rcx,rsi
       je        near ptr M04_L04
       mov       rax,14A00000038
       mov       rax,[rax]
       add       rax,10
       rorx      rdx,rcx,20
       xor       rdx,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rdx,r8
       mov       r8d,[rax]
       shrx      rdx,rdx,r8
       xor       r8d,r8d
M04_L00:
       lea       r10d,[rdx+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rax+r10*8]
       mov       r9d,[r10]
       and       r9d,0FFFFFFFE
       cmp       [r10+8],rcx
       jne       short M04_L01
       mov       r11,rsi
       xor       r11,[r10+10]
       cmp       r11,1
       jbe       short M04_L03
M04_L01:
       test      r9d,r9d
       je        short M04_L02
       inc       r8d
       add       edx,r8d
       and       edx,[rax+4]
       cmp       r8d,8
       jl        short M04_L00
M04_L02:
       mov       rcx,7FF92322102C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF9229E6340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M04_L03:
       cmp       r9d,[r10]
       jne       short M04_L02
       cmp       r11d,1
       jne       short M04_L02
       mov       rcx,7FF923221020
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L05
M04_L04:
       mov       rcx,7FF923221028
       call      CORINFO_HELP_COUNTPROFILE32
M04_L05:
       mov       rcx,7FF923221024
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 246
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FF9231CD8A8]
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
       jle       short M06_L03
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M06_L03
M06_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       je        short M06_L02
M06_L01:
       mov       rcx,7FF9231FFA18
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M06_L02:
       mov       rcx,14A00000110
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M06_L05
       mov       rcx,14A000000F0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M06_L04
       mov       rcx,7FF9231FFA20
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M06_L01
M06_L03:
       mov       ecx,2
       call      qword ptr [7FF9231CCC30]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M06_L00
M06_L04:
       mov       rcx,7FF9231FFA1C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF9231FFA18
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF922C05E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
M06_L05:
       mov       rcx,7FF9231FFA24
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M06_L01
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
       jne       short M07_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
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

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark.OrderByWithComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,1ECF7C02AB8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L21
M00_L00:
       mov       rbp,[rbx+2E8]
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L17
       xor       ecx,ecx
       mov       [r14+20],rcx
       lea       rcx,[r14+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       test      rdx,rdx
       jne       short M00_L02
       test      byte ptr [7FF923320E10],1
       je        near ptr M00_L22
M00_L01:
       mov       rcx,1ECF7C02B28
       mov       rdx,[rcx]
M00_L02:
       lea       rcx,[r14+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+48],0
       mov       rdx,[r14+18]
       mov       rcx,7FF923220BB0
       call      qword ptr [7FF922D3C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L23
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       r15,[rbp+10]
       mov       r13d,[rbp+8]
       mov       r12,[r14+30]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       mov       rdx,[r14+28]
       movzx     r8d,byte ptr [r14+48]
       mov       [rsp+54],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+38]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+38]
       mov       ecx,[rsp+54]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [r14+20],0
       jne       near ptr M00_L24
M00_L03:
       mov       r14,rax
       mov       r12d,edi
       mov       rax,[r14]
       mov       [rsp+40],rax
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rax,rdx
       jne       near ptr M00_L26
       mov       r8,[r14+8]
       mov       [rsp+28],r8
       mov       rdx,1ECF7C02AC8
       cmp       r8,[rdx]
       je        near ptr M00_L19
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+20],rax
       xor       r10d,r10d
       mov       r9,[rsp+28]
       test      r9,r9
       je        short M00_L06
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L06
M00_L04:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,rdx
       mov       [rsp+50],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+50]
       inc       r10d
       cmp       edi,r10d
       jle       short M00_L08
       mov       rax,[rsp+20]
       jmp       short M00_L04
       nop       dword ptr [rax]
M00_L05:
       mov       rax,[rsp+20]
M00_L06:
       cmp       r10d,edi
       jae       near ptr M00_L27
       mov       [rsp+50],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L25
       mov       r8,rdx
M00_L07:
       mov       edx,[rsp+50]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+50]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+28]
       jg        short M00_L05
M00_L08:
       lea       rcx,[r14+20]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
M00_L09:
       mov       rcx,[r14+18]
       test      rcx,rcx
       jne       near ptr M00_L20
M00_L10:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+30],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L12
       vmovups   ymm0,[7FF92329AC40]
       vbroadcastss ymm1,dword ptr [7FF92329AC60]
       lea       rcx,[rdx-20]
M00_L11:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L11
       vmovd     ecx,xmm0
M00_L12:
       cmp       r9,rdx
       jae       short M00_L14
M00_L13:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L13
M00_L14:
       lea       r9d,[r12-1]
       mov       rcx,r14
       mov       rdx,rax
       xor       r8d,r8d
       mov       r14,[rsp+40]
       mov       r10,[r14+40]
       call      qword ptr [r10+30]
       mov       r14,[rsp+30]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L16
       cmp       edi,r13d
       jl        short M00_L18
       xor       r12d,r12d
       xchg      ax,ax
M00_L15:
       lea       rcx,[r15+r12*2]
       mov       eax,[r14+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L27
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L15
M00_L16:
       mov       [rsp+48],rbp
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L17:
       mov       ecx,11
       call      qword ptr [7FF922C07E58]
       int       3
M00_L18:
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8]
       cmp       r12d,edi
       jae       near ptr M00_L27
       mov       edx,r12d
       mov       eax,[r14+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L27
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L18
       jmp       short M00_L16
M00_L19:
       lea       rcx,[r14+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L09
M00_L20:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L10
M00_L21:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1ECF7C02AB0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1ECF7C02AB8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L22:
       mov       rcx,offset MT_System.Collections.Generic.Comparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L23:
       mov       rbp,rsi
       jmp       near ptr M00_L16
M00_L24:
       mov       rcx,[r14+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r14,rax
       mov       rax,r14
       jmp       near ptr M00_L03
M00_L25:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+20]
       jmp       near ptr M00_L07
M00_L26:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rsp+40]
       mov       r10,[rax+40]
       call      qword ptr [r10+20]
       jmp       near ptr M00_L10
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1145
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rdx
       jne       near ptr M01_L50
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       jne       near ptr M01_L37
       mov       rcx,rax
       call      qword ptr [7FF922DC3340]; Precode of System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L18
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF923311CA8
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L04:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L56
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L11
M01_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L12
M01_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L51
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L14
M01_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M01_L09:
       mov       rax,rbx
       vzeroupper
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
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF923311B40
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF923311C88
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9233126B8
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF923312778
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF923312780
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L45
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L38
       mov       ebx,[rsi+8]
M01_L16:
       test      ebx,ebx
       je        near ptr M01_L44
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L43
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L42
       cmp       ebp,[rsi+8]
       ja        near ptr M01_L42
       cmp       ebp,[rbx+8]
       ja        near ptr M01_L42
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L41
       cmp       r8,4000
       ja        near ptr M01_L40
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L39
M01_L17:
       mov       rax,rbx
M01_L18:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M01_L46
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+5C],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+5C]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       jne       near ptr M01_L47
M01_L19:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rdx
       jne       near ptr M01_L49
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,1ECF7C02AC8
       cmp       rax,[rdx]
       je        near ptr M01_L35
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M01_L22
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M01_L22
M01_L20:
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,rdx
       mov       [rsp+58],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+58]
       inc       r10d
       cmp       esi,r10d
       jle       short M01_L24
       mov       rax,[rsp+38]
       jmp       short M01_L20
M01_L21:
       mov       rax,[rsp+38]
M01_L22:
       cmp       r10d,esi
       jae       near ptr M01_L59
       mov       [rsp+58],r10d
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M01_L48
       mov       r8,rdx
M01_L23:
       mov       edx,[rsp+58]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+58]
       inc       ecx
       cmp       esi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M01_L21
M01_L24:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M01_L25:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       jne       near ptr M01_L36
M01_L26:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M01_L28
       vmovups   ymm0,[7FF92329A4C0]
       vbroadcastss ymm1,dword ptr [7FF92329A4E0]
       lea       rcx,[rdx-20]
M01_L27:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M01_L27
       vmovd     ecx,xmm0
M01_L28:
       cmp       r9,rdx
       jae       short M01_L30
M01_L29:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M01_L29
M01_L30:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       ebp,ebp
       test      r13d,r13d
       jle       short M01_L32
       cmp       esi,r13d
       jl        short M01_L34
       xor       ebp,ebp
       nop       word ptr [rax+rax]
M01_L31:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M01_L59
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M01_L31
M01_L32:
       mov       rax,r14
M01_L33:
       vzeroupper
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
M01_L34:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M01_L59
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M01_L59
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M01_L34
       jmp       short M01_L32
M01_L35:
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L25
M01_L36:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L26
M01_L37:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L38:
       mov       rcx,rsi
       mov       r11,7FF922930F58
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L39:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L17
M01_L40:
       mov       rcx,rax
       call      qword ptr [7FF922F8F558]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L41:
       mov       rcx,rax
       call      qword ptr [7FF9229E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L42:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF922F8ED78]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L17
M01_L43:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922930F60
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1ECF7C02B20
       mov       rbx,[rdx]
       jmp       near ptr M01_L17
M01_L45:
       mov       rdx,rbx
       mov       rcx,7FF923320AB0
       call      qword ptr [7FF92320FA08]
       jmp       near ptr M01_L18
M01_L46:
       jmp       near ptr M01_L33
M01_L47:
       mov       rcx,[rdi+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rdi,rax
       mov       rax,rdi
       jmp       near ptr M01_L19
M01_L48:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M01_L23
M01_L49:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L26
M01_L50:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+30]
M01_L51:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L52
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L52
       jmp       short M01_L53
M01_L52:
       mov       rcx,rsi
       mov       rdx,7FF923312758
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L53:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L54
       jmp       short M01_L55
M01_L54:
       mov       rdx,7FF9230EDD18
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L55:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M01_L09
M01_L56:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L57
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L57
       jmp       short M01_L58
M01_L57:
       mov       rcx,rbx
       mov       rdx,7FF923311C50
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L58:
       mov       rdx,rsi
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF92320FA08]
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1911
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,rdx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L02
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L01
       cmp       rdx,[r8]
       je        short M03_L00
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M03_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L02:
       call      qword ptr [7FF9230B4420]
       int       3
M03_L03:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229ED8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF9230BEE50]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FF9229E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark.OrderByWithoutComparer()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,16341400AC8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L18
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rax,1632B400068
       mov       r14,[rax]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L19
       xor       ecx,ecx
       mov       [rbp+20],rcx
       lea       rcx,[rbp+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       lea       rcx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+48],0
       mov       rdx,[rbp+18]
       mov       rcx,7FF9232120B0
       call      qword ptr [7FF922D2C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L20
       mov       edx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rbp+30]
       mov       rcx,1632B400A08
       cmp       r12,[rcx]
       je        near ptr M00_L21
M00_L01:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rdx,[rbp+28]
       movzx     r8d,byte ptr [rbp+48]
       mov       [rsp+54],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+40]
       mov       ecx,[rsp+54]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rbp+20],0
       jne       near ptr M00_L22
M00_L02:
       mov       rbp,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rbp],rdx
       jne       near ptr M00_L24
       mov       rax,[rbp+8]
       mov       [rsp+30],rax
       mov       rdx,16341400AD0
       cmp       rax,[rdx]
       je        near ptr M00_L17
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       r9,[rsp+30]
       test      r9,r9
       je        short M00_L05
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L05
M00_L03:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,[rdx+30]
       mov       [rsp+50],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+50]
       inc       r10d
       cmp       edi,r10d
       jle       short M00_L07
       mov       rax,[rsp+28]
       jmp       short M00_L03
       nop
M00_L04:
       mov       rax,[rsp+28]
M00_L05:
       cmp       r10d,edi
       jae       near ptr M00_L25
       mov       [rsp+50],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L23
       mov       r8,[rdx+30]
M00_L06:
       mov       edx,[rsp+50]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+50]
       inc       ecx
       cmp       edi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+30]
       jg        short M00_L04
M00_L07:
       lea       rcx,[rbp+20]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       jne       near ptr M00_L16
M00_L08:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L10
       vmovups   ymm0,[7FF92328F560]
       vbroadcastss ymm1,dword ptr [7FF92328F580]
       lea       rcx,[rdx-20]
M00_L09:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L09
       vmovd     ecx,xmm0
M00_L10:
       cmp       r9,rdx
       jae       short M00_L12
M00_L11:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L11
M00_L12:
       lea       r9d,[r12-1]
       mov       rcx,rbp
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rbp]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rbp,[rsp+38]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L14
       cmp       edi,r13d
       jl        short M00_L15
       xor       r12d,r12d
M00_L13:
       lea       rcx,[r15+r12*2]
       mov       eax,[rbp+r12+10]
       cmp       eax,edi
       jae       near ptr M00_L25
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L13
M00_L14:
       mov       [rsp+48],r14
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
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
M00_L15:
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8]
       cmp       r12d,edi
       jae       near ptr M00_L25
       mov       edx,r12d
       mov       eax,[rbp+rdx*4+10]
       cmp       eax,edi
       jae       near ptr M00_L25
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L15
       jmp       short M00_L14
M00_L16:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L08
M00_L17:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M00_L18:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,16341400AB8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,16341400AC8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L19:
       mov       ecx,11
       call      qword ptr [7FF922BF7E58]
       int       3
M00_L20:
       mov       r14,rsi
       jmp       near ptr M00_L14
M00_L21:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FF922BF5DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r12
       xor       r8d,r8d
       call      qword ptr [7FF922D2DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M00_L01
M00_L22:
       mov       rcx,[rbp+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       mov       rax,rbp
       jmp       near ptr M00_L02
M00_L23:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+28]
       jmp       near ptr M00_L06
M00_L24:
       mov       rcx,rbp
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L08
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1162
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L02
M01_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M01_L54
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rax],rcx
       jne       near ptr M01_L39
       mov       rcx,rax
       call      qword ptr [7FF922DB3340]; Precode of System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L21
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF923301BA0
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M01_L10
M01_L04:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L60
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M01_L11
M01_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M01_L12
M01_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M01_L55
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M01_L13
M01_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M01_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L14
M01_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M01_L09:
       mov       rax,rbx
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
M01_L10:
       mov       rcx,rbx
       mov       rdx,7FF923301A38
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
       nop       word ptr [rax+rax]
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF923301B80
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF923302358
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF923302418
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF923302420
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L49
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L40
       mov       ebx,[rsi+8]
M01_L16:
       test      ebx,ebx
       je        near ptr M01_L48
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M01_L47
       mov       ebp,[rsi+8]
       mov       r14,[rsi]
       cmp       dword ptr [r14+4],18
       jne       short M01_L17
       cmp       ebp,[rsi+8]
       ja        short M01_L17
       cmp       ebp,[rbx+8]
       jbe       near ptr M01_L37
M01_L17:
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M01_L33
       xor       r14d,r14d
M01_L18:
       test      r14d,r14d
       jg        near ptr M01_L41
       mov       ecx,r14d
       neg       ecx
       js        near ptr M01_L42
       lea       edx,[rcx+rbp]
       cmp       edx,[rsi+8]
       ja        near ptr M01_L42
       mov       rdx,[rbx]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       jne       near ptr M01_L34
       xor       r14d,r14d
M01_L19:
       test      r14d,r14d
       jg        near ptr M01_L43
       mov       edx,r14d
       neg       edx
       js        near ptr M01_L44
       lea       r8d,[rdx+rbp]
       cmp       r8d,[rbx+8]
       ja        near ptr M01_L44
       mov       r8,[rsi]
       movzx     eax,word ptr [r8]
       mov       r10d,ebp
       imul      r10,rax
       mov       ecx,ecx
       imul      rcx,rax
       lea       r9,[rsi+rcx+10]
       mov       ecx,edx
       imul      rcx,rax
       lea       rcx,[rbx+rcx+10]
       test      dword ptr [r8],1000000
       je        near ptr M01_L35
       cmp       r10,4000
       ja        near ptr M01_L46
       mov       rdx,r9
       mov       r8,r10
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M01_L45
M01_L20:
       mov       rax,rbx
M01_L21:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M01_L50
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,[rdi+30]
       mov       rcx,1632B400A08
       cmp       r13,[rcx]
       je        near ptr M01_L51
M01_L22:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,[rdi+28]
       movzx     eax,byte ptr [rdi+48]
       mov       [rsp+2C],eax
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rsp+2C]
       mov       [r12+28],r13b
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       r13,r12
       cmp       qword ptr [rdi+20],0
       jne       near ptr M01_L52
M01_L23:
       mov       edi,esi
       mov       r12,[r13]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       r12,rcx
       jne       near ptr M01_L53
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FF922DB66B8]; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M01_L24:
       mov       edx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+20],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,edi
       lea       rdx,[r9+rdx*4]
       cmp       edi,8
       jl        short M01_L26
       vmovups   ymm0,[7FF92328B160]
       vbroadcastss ymm1,dword ptr [7FF92328B180]
       lea       rcx,[rdx-20]
M01_L25:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M01_L25
       vmovd     ecx,xmm0
M01_L26:
       cmp       r9,rdx
       jae       short M01_L28
M01_L27:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M01_L27
M01_L28:
       lea       r9d,[rdi-1]
       mov       rcx,r13
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r12+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+20]
       xor       r13d,r13d
       test      r15d,r15d
       jle       short M01_L30
       cmp       esi,r15d
       jl        short M01_L32
       xor       r13d,r13d
       nop       dword ptr [rax]
M01_L29:
       lea       rcx,[r14+r13*2]
       mov       r12d,[rdi+r13+10]
       cmp       r12d,esi
       jae       near ptr M01_L63
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r13,4
       dec       r15d
       jne       short M01_L29
M01_L30:
       mov       rax,rbp
M01_L31:
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
M01_L32:
       mov       ecx,r13d
       lea       rcx,[r14+rcx*8]
       cmp       r13d,esi
       jae       near ptr M01_L63
       mov       edx,r13d
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M01_L63
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       cmp       r13d,r15d
       jl        short M01_L32
       jmp       short M01_L30
M01_L33:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       near ptr M01_L18
M01_L34:
       movsxd    rdx,edx
       mov       r14d,[rbx+rdx*4+10]
       jmp       near ptr M01_L19
M01_L35:
       cmp       r10,40
       je        short M01_L36
       mov       rdx,r9
       mov       r8,r10
       call      qword ptr [7FF9229D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L20
M01_L36:
       vmovdqu   ymm0,ymmword ptr [r9]
       vmovdqu   ymm1,ymmword ptr [r9+20]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm1
       jmp       near ptr M01_L20
M01_L37:
       mov       r8d,ebp
       movzx     ecx,word ptr [r14]
       imul      r8,rcx
       lea       rdx,[rsi+10]
       lea       rcx,[rbx+10]
       test      dword ptr [r14],1000000
       jne       short M01_L38
       call      qword ptr [7FF9229D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L20
M01_L38:
       call      qword ptr [7FF9229D57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L20
M01_L39:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
M01_L40:
       mov       rcx,rsi
       mov       r11,7FF922920F60
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L41:
       mov       ecx,167
       mov       rdx,7FF922914000
       call      qword ptr [7FF922BF7798]
       mov       r8,rax
       mov       edx,r14d
       xor       ecx,ecx
       call      qword ptr [7FF9231FFA68]
       int       3
M01_L42:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9231FFAE0]
       mov       rbx,rax
       mov       ecx,12D
       mov       rdx,7FF922914000
       call      qword ptr [7FF922BF7798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF922D27FA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L43:
       mov       ecx,17F
       mov       rdx,7FF922914000
       call      qword ptr [7FF922BF7798]
       mov       r8,rax
       mov       edx,r14d
       xor       ecx,ecx
       call      qword ptr [7FF9231FFA68]
       int       3
M01_L44:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF9231FFAF8]
       mov       rbp,rax
       mov       ecx,145
       mov       rdx,7FF922914000
       call      qword ptr [7FF922BF7798]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,r14
       call      qword ptr [7FF922D27FA8]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M01_L45:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L20
M01_L46:
       mov       rdx,r9
       mov       r8,r10
       call      qword ptr [7FF922F7F558]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L20
M01_L47:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922920F68
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L20
M01_L48:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,16341400B28
       mov       rbx,[rdx]
       jmp       near ptr M01_L20
M01_L49:
       mov       rdx,rbx
       mov       rcx,7FF9233104E8
       call      qword ptr [7FF9231FF9F0]
       jmp       near ptr M01_L21
M01_L50:
       jmp       near ptr M01_L31
M01_L51:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF922BF5DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FF922D2DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M01_L22
M01_L52:
       mov       rcx,[rdi+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M01_L23
M01_L53:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,edi
       mov       rax,[r12+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L24
M01_L54:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
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
       jmp       qword ptr [rax+30]
M01_L55:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L56
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L56
       jmp       short M01_L57
M01_L56:
       mov       rcx,rsi
       mov       rdx,7FF9233023F8
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L57:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L58
       jmp       short M01_L59
M01_L58:
       mov       rdx,7FF9230DEFF0
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M01_L59:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M01_L09
M01_L60:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L61
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L61
       jmp       short M01_L62
M01_L61:
       mov       rcx,rbx
       mov       rdx,7FF923301B48
       call      qword ptr [7FF922BF7B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L62:
       mov       rdx,rsi
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
       jmp       qword ptr [7FF9231FF9F0]
M01_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2109
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       ret
; Total bytes of code 5
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L02
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M03_L01
       cmp       rdx,[r8]
       je        short M03_L00
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       jne       short M03_L03
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M03_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L02:
       call      qword ptr [7FF9230A43F0]
       int       3
M03_L03:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229DD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
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
       mov       r8,1632B400038
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
       and       ebx,0FFFFFFFE
       cmp       [r11+8],rax
       jne       short M04_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       jbe       short M04_L04
M04_L03:
       test      ebx,ebx
       je        short M04_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M04_L02
       jmp       short M04_L05
M04_L04:
       cmp       ebx,[r11]
       jne       short M04_L05
       cmp       esi,1
       je        near ptr M04_L00
M04_L05:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF9229D6340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 156
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FF9230AEF88]
       int       3
; Total bytes of code 44
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       short M06_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M06_L02
M06_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M06_L01
       mov       rax,1632B400110
       mov       rax,[rax]
       test      rax,rax
       jne       short M06_L01
       mov       rax,1632B4000F0
       mov       rax,[rax]
       test      rax,rax
       je        short M06_L03
M06_L01:
       add       rsp,28
       ret
M06_L02:
       mov       ecx,2
       call      qword ptr [7FF9230A4FA8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M06_L00
M06_L03:
       add       rsp,28
       jmp       qword ptr [7FF922BF5E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       jne       short M07_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
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

