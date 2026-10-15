## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark.OrderByWithComparer()
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
       mov       rcx,2DF18400A80
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
       mov       rcx,7FF9231D2080
       call      qword ptr [7FF922D6D080]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,2DF18400A98
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
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovups   ymm0,[7FF9231A21A0]
       lea       rcx,[rdx-20]
M00_L10:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,[7FF9231A21C0]
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
       mov       rdx,2DF18400A78
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2DF18400A80
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L17:
       mov       ecx,11
       call      qword ptr [7FF922C2C6F0]
       int       3
M00_L18:
       mov       rcx,offset MT_System.Collections.Generic.Comparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2DF18400B70
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
       call      qword ptr [7FF922DF3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L19
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF9232AA370
       call      qword ptr [7FF922C2C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF9232AA208
       call      qword ptr [7FF922C2C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF9232AA350
       call      qword ptr [7FF922C2C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9232AA768
       call      qword ptr [7FF922C2C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF9232AA828
       call      qword ptr [7FF922C2C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF9232AA830
       call      qword ptr [7FF922C2C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FF922E2EC58]
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
       mov       rdx,2DF18400A98
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
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovups   ymm0,[7FF92319EC20]
       lea       rcx,[rdx-20]
M01_L28:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,[7FF92319EC40]
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
       mov       r11,7FF922950EA0
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L37:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L18
M01_L38:
       mov       rcx,rax
       call      qword ptr [7FF922A05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L18
M01_L39:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF922E2F168]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L18
M01_L40:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922950EA8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L18
M01_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2DF18400B68
       mov       rbx,[rdx]
       jmp       near ptr M01_L18
M01_L42:
       mov       rdx,rbx
       mov       rcx,7FF9232CA5E8
       call      qword ptr [7FF923275BD8]
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
       mov       rdx,7FF9232AA808
       call      qword ptr [7FF922C2C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L53:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L54
       jmp       short M01_L55
M01_L54:
       mov       rdx,7FF922FFB048
       call      qword ptr [7FF922C2C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF9232AA318
       call      qword ptr [7FF922C2C3F0]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       jmp       qword ptr [7FF923275BD8]
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1889
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       jmp       qword ptr [7FF922A0D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M03_L02:
       call      qword ptr [7FF922E2DFE0]
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
       call      qword ptr [7FF922E2EB98]
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
       jmp       qword ptr [7FF922A05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark.OrderByWithoutComparer()
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
       mov       [rsp+58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,1DE66C00A50
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L22
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rax,1DE50C00068
       mov       r14,[rax]
       mov       r15,r14
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L24
       xor       ecx,ecx
       mov       [rbp+20],rcx
       lea       rcx,[rbp+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+48],0
       mov       rcx,1DE66C00A58
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L23
M00_L01:
       mov       rcx,rbp
       mov       rdx,offset MT_System.Linq.IOrderedEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r8,7FF9231F2A38
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       r8,r14
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r9d,r9d
       call      rax
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M00_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L43
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L36
       mov       esi,[rdi+8]
M00_L02:
       test      esi,esi
       je        near ptr M00_L42
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L41
       mov       ebp,[rdi+8]
       mov       rcx,[rdi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L40
       cmp       ebp,[rdi+8]
       ja        near ptr M00_L40
       cmp       ebp,[rsi+8]
       ja        near ptr M00_L40
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rdi+10]
       lea       rax,[rsi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L39
       cmp       r8,4000
       ja        near ptr M00_L38
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M00_L37
M00_L03:
       mov       [rsp+58],rsi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+58]
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
M00_L04:
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L35
       mov       rdx,[rdi+18]
       mov       rcx,7FF9231152B8
       call      qword ptr [7FF922D4C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       ebp,[rsi+8]
       cmp       ebp,1
       jle       near ptr M00_L25
       mov       edx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,1DE50C00A08
       cmp       r12,[rcx]
       je        near ptr M00_L26
M00_L05:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+64],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+64]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       je        short M00_L07
       mov       rcx,[rdi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L27
       mov       rdx,r12
       call      qword ptr [7FF922DD4740]; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M00_L06:
       mov       rdi,rax
       mov       rax,rdi
M00_L07:
       mov       rdi,rax
       mov       r12d,ebp
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,1DE66C00A60
       cmp       rax,[rdx]
       je        near ptr M00_L31
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M00_L11
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L11
M00_L08:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M00_L28
M00_L09:
       mov       [rsp+60],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+60]
       inc       r10d
       cmp       ebp,r10d
       jle       short M00_L13
       mov       rax,[rsp+38]
       jmp       short M00_L08
M00_L10:
       mov       rax,[rsp+38]
M00_L11:
       cmp       r10d,ebp
       jae       near ptr M00_L44
       mov       [rsp+60],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L29
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M00_L30
M00_L12:
       mov       edx,[rsp+60]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+60]
       inc       ecx
       cmp       ebp,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M00_L10
M00_L13:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M00_L14:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M00_L15
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L32
       mov       rdx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF922DD66B8]; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M00_L15:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L17
       vmovups   ymm0,[7FF9231662C0]
       lea       rcx,[rdx-20]
M00_L16:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,[7FF9231662E0]
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L16
       vmovd     ecx,xmm0
M00_L17:
       cmp       r9,rdx
       jb        near ptr M00_L34
M00_L18:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L20
       cmp       ebp,r13d
       jl        short M00_L21
       xor       r12d,r12d
M00_L19:
       lea       rcx,[r15+r12*2]
       mov       eax,[rdi+r12+10]
       cmp       eax,ebp
       jae       near ptr M00_L44
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L19
M00_L20:
       mov       rsi,r14
       jmp       near ptr M00_L03
M00_L21:
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8]
       cmp       r12d,ebp
       jae       near ptr M00_L44
       mov       edx,r12d
       mov       eax,[rdi+rdx*4+10]
       cmp       eax,ebp
       jae       near ptr M00_L44
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L21
       jmp       short M00_L20
M00_L22:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1DE66C00A40
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DE66C00A50
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1DE66C00A40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DE66C00A58
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L24:
       mov       ecx,11
       call      qword ptr [7FF922C17E58]
       int       3
M00_L25:
       mov       r14,rsi
       jmp       near ptr M00_L20
M00_L26:
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
       jmp       near ptr M00_L05
M00_L27:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L06
M00_L28:
       mov       r8,21EE5AB0008
       jmp       near ptr M00_L09
M00_L29:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M00_L12
M00_L30:
       mov       r8,21EE5AB0008
       jmp       near ptr M00_L12
M00_L31:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L14
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
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L34
       jmp       near ptr M00_L18
M00_L35:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M00_L20
M00_L36:
       mov       rcx,rdi
       mov       r11,7FF922940DC8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L02
M00_L37:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L03
M00_L38:
       mov       rcx,rax
       call      qword ptr [7FF922F9EEC8]
       jmp       near ptr M00_L03
M00_L39:
       mov       rcx,rax
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L40:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923036AA8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L03
M00_L41:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF922940DD0
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1DE66C00AF8
       mov       rsi,[rdx]
       jmp       near ptr M00_L03
M00_L43:
       mov       rdx,rsi
       mov       rcx,7FF9232789F0
       call      qword ptr [7FF9231CF1F8]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1877
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
       mov       r9,1DE50C00A10
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M03_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M03_L01
       cmp       [r10],rcx
       je        short M03_L06
M03_L00:
       cmp       [r10+8],rcx
       je        short M03_L06
       cmp       [r10+10],rcx
       je        short M03_L06
       cmp       [r10+18],rcx
       je        short M03_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M03_L04
       test      r8,r8
       je        short M03_L03
M03_L01:
       cmp       [r10],rcx
       je        short M03_L06
M03_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M03_L03
       cmp       [r10],rcx
       je        short M03_L06
       jmp       short M03_L02
M03_L03:
       test      dword ptr [rax],500C0000
       je        short M03_L05
       jmp       qword ptr [7FF922D4F648]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M03_L04:
       cmp       [r10],rcx
       je        short M03_L06
       jmp       short M03_L00
M03_L05:
       xor       edx,edx
M03_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
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
       jle       short M04_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M04_L02
M04_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M04_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M04_L53
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M04_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rax],rcx
       jne       near ptr M04_L36
       mov       rcx,rax
       call      qword ptr [7FF922DD3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M04_L01:
       jmp       near ptr M04_L18
M04_L02:
       mov       rcx,rbx
       mov       rdx,7FF923264410
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M04_L00
M04_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M04_L10
M04_L04:
       mov       rdx,rsi
       call      qword ptr [7FF922B6F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L59
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M04_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M04_L11
M04_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M04_L12
M04_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M04_L54
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M04_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M04_L13
M04_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M04_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M04_L14
M04_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M04_L09:
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
M04_L10:
       mov       rcx,rbx
       mov       rdx,7FF9232642A8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
       nop       dword ptr [rax+rax]
M04_L11:
       mov       rcx,rbx
       mov       rdx,7FF9232643F0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M04_L05
M04_L12:
       mov       rcx,rsi
       mov       rdx,7FF923264EB0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L06
M04_L13:
       mov       rcx,rsi
       mov       rdx,7FF923264F70
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L07
M04_L14:
       mov       rcx,rsi
       mov       rdx,7FF923264F78
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L08
M04_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B6F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M04_L44
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M04_L37
       mov       ebx,[rsi+8]
M04_L16:
       test      ebx,ebx
       je        near ptr M04_L43
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M04_L42
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M04_L41
       cmp       ebp,[rsi+8]
       ja        near ptr M04_L41
       cmp       ebp,[rbx+8]
       ja        near ptr M04_L41
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M04_L40
       cmp       r8,4000
       ja        near ptr M04_L39
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M04_L38
M04_L17:
       mov       rax,rbx
M04_L18:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M04_L45
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,1DE50C00A08
       cmp       r12,[rcx]
       je        near ptr M04_L46
M04_L19:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+5C],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+48]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+48]
       mov       ecx,[rsp+5C]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       je        short M04_L21
       mov       rcx,[rdi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M04_L47
       mov       rdx,r12
       call      qword ptr [7FF922DD4740]; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M04_L20:
       mov       rdi,rax
       mov       rax,rdi
M04_L21:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M04_L51
       mov       rax,[rdi+8]
       mov       [rsp+38],rax
       mov       rdx,1DE66C00A60
       cmp       rax,[rdx]
       je        near ptr M04_L49
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+30],rax
       xor       r8d,r8d
       mov       rax,[rsp+30]
       jmp       short M04_L25
M04_L22:
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M04_L48
M04_L23:
       mov       r9,rdx
M04_L24:
       movsxd    rdx,dword ptr [rsp+50]
       mov       rcx,rax
       mov       r8,r9
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rcx,[rsp+50]
       inc       ecx
       cmp       esi,ecx
       mov       r8,rcx
       mov       rax,[rsp+30]
       jle       short M04_L26
M04_L25:
       mov       [rsp+50],r8
       mov       rdx,[rbx+r8*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       r10,[rsp+38]
       cmp       [r10+18],rcx
       je        short M04_L22
       mov       rcx,[r10+8]
       call      qword ptr [r10+18]
       mov       r9,rax
       mov       rax,[rsp+30]
       jmp       short M04_L24
M04_L26:
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M04_L27:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M04_L28
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M04_L50
       mov       rdx,rbx
       mov       r8d,r12d
       call      qword ptr [7FF922DD66B8]; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M04_L28:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+40],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M04_L30
       vmovups   ymm0,[7FF92315E760]
       lea       rcx,[rdx-20]
M04_L29:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,[7FF92315E780]
       add       r9,20
       cmp       r9,rcx
       jbe       short M04_L29
       vmovd     ecx,xmm0
M04_L30:
       cmp       r9,rdx
       jb        near ptr M04_L52
M04_L31:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+40]
       xor       ebp,ebp
       test      r13d,r13d
       jle       short M04_L33
       cmp       esi,r13d
       jl        short M04_L35
       xor       ebp,ebp
       nop
M04_L32:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M04_L62
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M04_L32
M04_L33:
       mov       rax,r14
M04_L34:
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
M04_L35:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M04_L62
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M04_L62
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M04_L35
       jmp       short M04_L33
M04_L36:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M04_L01
M04_L37:
       mov       rcx,rsi
       mov       r11,7FF922940C20
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M04_L16
M04_L38:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L17
M04_L39:
       mov       rcx,rax
       call      qword ptr [7FF922F9EEC8]
       jmp       near ptr M04_L17
M04_L40:
       mov       rcx,rax
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L17
M04_L41:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923036AA8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L17
M04_L42:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922940C28
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M04_L17
M04_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1DE66C00AF8
       mov       rbx,[rdx]
       jmp       near ptr M04_L17
M04_L44:
       mov       rdx,rbx
       mov       rcx,7FF9232789F0
       call      qword ptr [7FF9231CF1F8]
       jmp       near ptr M04_L18
M04_L45:
       jmp       near ptr M04_L34
M04_L46:
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
       jmp       near ptr M04_L19
M04_L47:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M04_L20
M04_L48:
       mov       rdx,21EE5AB0008
       jmp       near ptr M04_L23
M04_L49:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L27
M04_L50:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M04_L28
M04_L51:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M04_L28
M04_L52:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M04_L52
       jmp       near ptr M04_L31
M04_L53:
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
M04_L54:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M04_L55
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M04_L55
       jmp       short M04_L56
M04_L55:
       mov       rcx,rsi
       mov       rdx,7FF923264F50
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L56:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M04_L57
       jmp       short M04_L58
M04_L57:
       mov       rdx,7FF923264F90
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M04_L58:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M04_L09
M04_L59:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M04_L60
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M04_L60
       jmp       short M04_L61
M04_L60:
       mov       rcx,rbx
       mov       rdx,7FF9232643B8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L61:
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
M04_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1995
```
```assembly
; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M05_L00:
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
       mov       rdi,[rbx+30]
       mov       rbp,[rbx]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.String
       cmp       [rcx+8],rax
       jne       short M05_L01
       mov       rcx,1DE50C00A08
       cmp       rdi,[rcx]
       je        near ptr M05_L07
M05_L01:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M05_L06
M05_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+28]
       movzx     r14d,byte ptr [rbx+48]
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
       mov       rsi,[rbx+20]
       test      rsi,rsi
       je        near ptr M05_L05
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M05_L12
       mov       rdi,[rsi+30]
       mov       rcx,1DE50C00A08
       cmp       rdi,[rcx]
       je        near ptr M05_L10
M05_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,[rsi+28]
       movzx     r15d,byte ptr [rsi+48]
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
       cmp       qword ptr [rsi+20],0
       je        short M05_L04
       mov       rcx,[rsi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M05_L11
       mov       rdx,r14
       call      qword ptr [7FF922DD4740]
       mov       rbp,rax
M05_L04:
       mov       rax,rbp
M05_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L06:
       mov       rcx,rbp
       mov       rdx,7FF9232647A8
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L07:
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
       call      qword ptr [7FF922D4DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M05_L08
       jmp       short M05_L09
M05_L08:
       mov       rcx,rbp
       mov       rdx,7FF9232647C0
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M05_L09:
       mov       rdx,rdi
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M05_L01
M05_L10:
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
       call      qword ptr [7FF922D4DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M05_L03
M05_L11:
       mov       rdx,r14
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M05_L04
M05_L12:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M05_L04
; Total bytes of code 570
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+20]
       mov       rcx,21EE5AB0008
       test      rax,rax
       cmove     rax,rcx
       ret
; Total bytes of code 22
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M07_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M07_L02
       cmp       rdx,[r8]
       jne       short M07_L03
M07_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M07_L01:
       call      qword ptr [7FF9231CC108]
       int       3
M07_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M07_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M07_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229FD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M08_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rbp,[rsi+8]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdx,[rdx+48]
       test      rdx,rdx
       je        near ptr M08_L07
M08_L01:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rbp
       je        near ptr M08_L15
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+50]
       test      rax,rax
       je        near ptr M08_L08
       mov       rcx,rax
M08_L02:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M08_L05
       test      rbx,rbx
       je        near ptr M08_L09
       test      rbp,rbp
       je        near ptr M08_L09
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rbp+18],rdx
       jne       near ptr M08_L09
       cmp       [rbx+8],r13d
       jl        near ptr M08_L09
M08_L03:
       mov       edx,r15d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M08_L12
M08_L04:
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M08_L03
M08_L05:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M08_L06:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       near ptr M08_L11
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L07:
       mov       rdx,7FF9232648B8
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L01
M08_L08:
       mov       rdx,7FF9232648C8
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L09:
       cmp       r15d,[rbx+8]
       jae       near ptr M08_L19
       mov       edx,r15d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rbp+18],rcx
       jne       short M08_L13
       mov       r8,[rdx+20]
       test      r8,r8
       je        short M08_L14
M08_L10:
       mov       edx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M08_L09
       jmp       near ptr M08_L05
M08_L11:
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M08_L18
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922DD66B8]
M08_L12:
       mov       r8,21EE5AB0008
       jmp       near ptr M08_L04
M08_L13:
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
       mov       r8,rax
       jmp       short M08_L10
M08_L14:
       mov       r8,21EE5AB0008
       jmp       short M08_L10
M08_L15:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M08_L16
       jmp       short M08_L17
M08_L16:
       mov       rdx,7FF9232648C8
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L17:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L18:
       mov       rdx,rbx
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+20]
M08_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 557
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       mov       rcx,21EE5AB0008
       test      rax,rax
       cmove     rax,rcx
       ret
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M10_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M10_L00:
       call      qword ptr [7FF9231CD908]
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
       jle       short M11_L03
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M11_L03
M11_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       je        short M11_L02
M11_L01:
       mov       rcx,7FF923233390
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M11_L02:
       mov       rcx,1DE50C00110
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M11_L05
       mov       rcx,1DE50C000F0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M11_L04
       mov       rcx,7FF923233398
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M11_L01
M11_L03:
       mov       ecx,2
       call      qword ptr [7FF9231CD500]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M11_L00
M11_L04:
       mov       rcx,7FF923233394
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF923233390
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF922C15E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
M11_L05:
       mov       rcx,7FF92323339C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M11_L01
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
       jne       short M12_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
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
       je        near ptr M13_L05
       mov       rcx,[rbx]
       cmp       rcx,rsi
       je        near ptr M13_L04
       mov       rax,1DE50C00038
       mov       rax,[rax]
       add       rax,10
       rorx      rdx,rcx,20
       xor       rdx,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rdx,r8
       mov       r8d,[rax]
       shrx      rdx,rdx,r8
       xor       r8d,r8d
M13_L00:
       lea       r10d,[rdx+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rax+r10*8]
       mov       r9d,[r10]
       and       r9d,0FFFFFFFE
       cmp       [r10+8],rcx
       jne       short M13_L01
       mov       r11,rsi
       xor       r11,[r10+10]
       cmp       r11,1
       jbe       short M13_L03
M13_L01:
       test      r9d,r9d
       je        short M13_L02
       inc       r8d
       add       edx,r8d
       and       edx,[rax+4]
       cmp       r8d,8
       jl        short M13_L00
M13_L02:
       mov       rcx,7FF923234984
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF9229F6340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M13_L03:
       cmp       r9d,[r10]
       jne       short M13_L02
       cmp       r11d,1
       jne       short M13_L02
       mov       rcx,7FF923234978
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M13_L05
M13_L04:
       mov       rcx,7FF923234980
       call      CORINFO_HELP_COUNTPROFILE32
M13_L05:
       mov       rcx,7FF92323497C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 246
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M14_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M14_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M14_L02
       test      r8b,18
       je        short M14_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M14_L05
M14_L00:
       test      r8b,4
       je        short M14_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M14_L05
M14_L01:
       test      r8,r8
       je        short M14_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M14_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M14_L05
M14_L02:
       cmp       r8,40
       ja        short M14_L06
M14_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M14_L09
M14_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M14_L05:
       vzeroupper
       ret
M14_L06:
       cmp       r8,800
       ja        near ptr M14_L12
       cmp       r8,100
       jae       short M14_L10
M14_L07:
       mov       r9,r8
       shr       r9,6
M14_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M14_L08
       and       r8,3F
       cmp       r8,10
       ja        short M14_L03
       jmp       short M14_L04
M14_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M14_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M14_L04
M14_L10:
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
       jmp       short M14_L07
M14_L11:
       cmp       rcx,rdx
       jne       short M14_L12
       cmp       [rdx],dl
       jmp       near ptr M14_L05
M14_L12:
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
       je        near ptr M15_L09
       test      rsi,rsi
       je        near ptr M15_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M15_L00
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
       jne       near ptr M15_L10
M15_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M15_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M15_L07
       sub       edi,eax
       js        near ptr M15_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M15_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M15_L06
       sub       ebp,eax
       js        near ptr M15_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M15_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M15_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98246A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M15_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M15_L16
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
M15_L01:
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
       jne       short M15_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246D930]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M15_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M15_L15
M15_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M15_L04:
       cmp       r8,4000
       jbe       short M15_L05
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
M15_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M15_L02
       jmp       near ptr M15_L14
M15_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M15_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M15_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M15_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M15_L10:
       call      qword ptr [7FF982463788]
       mov       rbx,rax
       call      qword ptr [7FF98246ED60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246D7C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M15_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF982481910]
       int       3
M15_L12:
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
M15_L13:
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
M15_L14:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M15_L02
M15_L15:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M15_L03
M15_L16:
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
       jne       short M16_L00
       ret
M16_L00:
       jmp       qword ptr [7FF9229F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark.OrderByWithComparer()
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
       mov       rcx,23CD4000A48
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
       mov       rcx,7FF9231152B8
       call      qword ptr [7FF922D4C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,23CD4000A60
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
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovups   ymm0,[7FF9231626E0]
       vbroadcastss ymm1,dword ptr [7FF923162700]
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
       mov       rdx,23CD4000A40
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,23CD4000A48
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L17:
       mov       ecx,11
       call      qword ptr [7FF922C17E58]
       int       3
M00_L18:
       mov       rcx,offset MT_System.Collections.Generic.Comparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,23CD4000B00
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
       call      qword ptr [7FF922DD3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L18
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF9232641D8
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
       mov       rdx,7FF923264070
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF9232641B8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9232647B0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF923264870
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF923264878
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B6F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,23CD4000A60
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
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovups   ymm0,[7FF92315F100]
       vbroadcastss ymm1,dword ptr [7FF92315F120]
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
       mov       r11,7FF922940C18
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L36:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L17
M01_L37:
       mov       rcx,rax
       call      qword ptr [7FF922F9F360]
       jmp       near ptr M01_L17
M01_L38:
       mov       rcx,rax
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L39:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923036AC0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L17
M01_L40:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922940C20
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,23CD4000AF8
       mov       rbx,[rdx]
       jmp       near ptr M01_L17
M01_L42:
       mov       rdx,rbx
       mov       rcx,7FF923277910
       call      qword ptr [7FF9231CF1B0]
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
       mov       rdx,7FF923264850
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L53:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L54
       jmp       short M01_L55
M01_L54:
       mov       rdx,7FF923264890
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
       mov       rdx,7FF923264180
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
       jmp       qword ptr [7FF9231CF1B0]
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1914
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF9231CC108]
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
       call      qword ptr [7FF9231CD8C0]
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
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark.OrderByWithoutComparer()
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
       mov       [rsp+58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,25ED6002A48
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L22
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rax,25ED6000068
       mov       r14,[rax]
       mov       r15,r14
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L24
       xor       ecx,ecx
       mov       [rbp+20],rcx
       lea       rcx,[rbp+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+48],0
       mov       rcx,25ED6002A50
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L23
M00_L01:
       mov       rcx,rbp
       mov       rdx,offset MT_System.Linq.IOrderedEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r8,7FF9231E2A38
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       r8,r14
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r9d,r9d
       call      rax
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M00_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L43
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L36
       mov       esi,[rdi+8]
M00_L02:
       test      esi,esi
       je        near ptr M00_L42
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L41
       mov       ebp,[rdi+8]
       mov       rcx,[rdi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L40
       cmp       ebp,[rdi+8]
       ja        near ptr M00_L40
       cmp       ebp,[rsi+8]
       ja        near ptr M00_L40
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rdi+10]
       lea       rax,[rsi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L39
       cmp       r8,4000
       ja        near ptr M00_L38
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M00_L37
M00_L03:
       mov       [rsp+58],rsi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+58]
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
M00_L04:
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L35
       mov       rdx,[rdi+18]
       mov       rcx,7FF9231052B8
       call      qword ptr [7FF922D3C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       ebp,[rsi+8]
       cmp       ebp,1
       jle       near ptr M00_L25
       mov       edx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,25ED6000A08
       cmp       r12,[rcx]
       je        near ptr M00_L26
M00_L05:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+64],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+64]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       je        short M00_L07
       mov       rcx,[rdi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L27
       mov       rdx,r12
       call      qword ptr [7FF922DC4740]; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M00_L06:
       mov       rdi,rax
       mov       rax,rdi
M00_L07:
       mov       rdi,rax
       mov       r12d,ebp
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,25ED6002A58
       cmp       rax,[rdx]
       je        near ptr M00_L31
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M00_L11
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L11
M00_L08:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M00_L28
M00_L09:
       mov       [rsp+60],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+60]
       inc       r10d
       cmp       ebp,r10d
       jle       short M00_L13
       mov       rax,[rsp+38]
       jmp       short M00_L08
M00_L10:
       mov       rax,[rsp+38]
M00_L11:
       cmp       r10d,ebp
       jae       near ptr M00_L44
       mov       [rsp+60],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L29
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M00_L30
M00_L12:
       mov       edx,[rsp+60]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+60]
       inc       ecx
       cmp       ebp,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M00_L10
M00_L13:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M00_L14:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M00_L15
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L32
       mov       rdx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF922DC66B8]; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M00_L15:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L17
       vmovups   ymm0,[7FF9231525C0]
       vbroadcastss ymm1,dword ptr [7FF9231525E0]
       lea       rcx,[rdx-20]
M00_L16:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L16
       vmovd     ecx,xmm0
M00_L17:
       cmp       r9,rdx
       jb        near ptr M00_L34
M00_L18:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L20
       cmp       ebp,r13d
       jl        short M00_L21
       xor       r12d,r12d
       nop       dword ptr [rax+rax]
M00_L19:
       lea       rcx,[r15+r12*2]
       mov       eax,[rdi+r12+10]
       cmp       eax,ebp
       jae       near ptr M00_L44
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L19
M00_L20:
       mov       rsi,r14
       jmp       near ptr M00_L03
M00_L21:
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8]
       cmp       r12d,ebp
       jae       near ptr M00_L44
       mov       edx,r12d
       mov       eax,[rdi+rdx*4+10]
       cmp       eax,ebp
       jae       near ptr M00_L44
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L21
       jmp       short M00_L20
M00_L22:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,25ED6002A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25ED6002A48
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,25ED6002A38
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25ED6002A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L24:
       mov       ecx,11
       call      qword ptr [7FF922C07E58]
       int       3
M00_L25:
       mov       r14,rsi
       jmp       near ptr M00_L20
M00_L26:
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
       jmp       near ptr M00_L05
M00_L27:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L06
M00_L28:
       mov       r8,29F6AE00008
       jmp       near ptr M00_L09
M00_L29:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M00_L12
M00_L30:
       mov       r8,29F6AE00008
       jmp       near ptr M00_L12
M00_L31:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229E58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L14
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
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L34
       jmp       near ptr M00_L18
M00_L35:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M00_L20
M00_L36:
       mov       rcx,rdi
       mov       r11,7FF922930C50
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L02
M00_L37:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L03
M00_L38:
       mov       rcx,rax
       call      qword ptr [7FF922F8F360]
       jmp       near ptr M00_L03
M00_L39:
       mov       rcx,rax
       call      qword ptr [7FF9229E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L40:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923026AC0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L03
M00_L41:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF922930C58
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,25ED6002AF0
       mov       rsi,[rdx]
       jmp       near ptr M00_L03
M00_L43:
       mov       rdx,rsi
       mov       rcx,7FF9232687A8
       call      qword ptr [7FF9231BF228]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1887
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
       mov       r9,25ED6000A10
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M03_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M03_L01
       cmp       [r10],rcx
       je        short M03_L06
M03_L00:
       cmp       [r10+8],rcx
       je        short M03_L06
       cmp       [r10+10],rcx
       je        short M03_L06
       cmp       [r10+18],rcx
       je        short M03_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M03_L04
       test      r8,r8
       je        short M03_L03
M03_L01:
       cmp       [r10],rcx
       je        short M03_L06
M03_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M03_L03
       cmp       [r10],rcx
       je        short M03_L06
       jmp       short M03_L02
M03_L03:
       test      dword ptr [rax],500C0000
       je        short M03_L05
       jmp       qword ptr [7FF922D3F648]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M03_L04:
       cmp       [r10],rcx
       je        short M03_L06
       jmp       short M03_L00
M03_L05:
       xor       edx,edx
M03_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
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
       jle       short M04_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M04_L02
M04_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M04_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M04_L53
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M04_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rax],rcx
       jne       near ptr M04_L36
       mov       rcx,rax
       call      qword ptr [7FF922DC3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M04_L01:
       jmp       near ptr M04_L18
M04_L02:
       mov       rcx,rbx
       mov       rdx,7FF923254468
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M04_L00
M04_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M04_L10
M04_L04:
       mov       rdx,rsi
       call      qword ptr [7FF922B5F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L59
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M04_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M04_L11
M04_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M04_L12
M04_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M04_L54
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M04_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M04_L13
M04_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M04_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M04_L14
M04_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M04_L09:
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
M04_L10:
       mov       rcx,rbx
       mov       rdx,7FF923254300
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M04_L11:
       mov       rcx,rbx
       mov       rdx,7FF923254448
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M04_L05
M04_L12:
       mov       rcx,rsi
       mov       rdx,7FF923254E90
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L06
M04_L13:
       mov       rcx,rsi
       mov       rdx,7FF923254F50
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L07
M04_L14:
       mov       rcx,rsi
       mov       rdx,7FF923254F58
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L08
M04_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B5F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M04_L44
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M04_L37
       mov       ebx,[rsi+8]
M04_L16:
       test      ebx,ebx
       je        near ptr M04_L43
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M04_L42
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M04_L41
       cmp       ebp,[rsi+8]
       ja        near ptr M04_L41
       cmp       ebp,[rbx+8]
       ja        near ptr M04_L41
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M04_L40
       cmp       r8,4000
       ja        near ptr M04_L39
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M04_L38
M04_L17:
       mov       rax,rbx
M04_L18:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M04_L45
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,25ED6000A08
       cmp       r12,[rcx]
       je        near ptr M04_L46
M04_L19:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+5C],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+48]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+48]
       mov       ecx,[rsp+5C]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       je        short M04_L21
       mov       rcx,[rdi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M04_L47
       mov       rdx,r12
       call      qword ptr [7FF922DC4740]; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M04_L20:
       mov       rdi,rax
       mov       rax,rdi
M04_L21:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M04_L51
       mov       rax,[rdi+8]
       mov       [rsp+38],rax
       mov       rdx,25ED6002A58
       cmp       rax,[rdx]
       je        near ptr M04_L49
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+30],rax
       xor       r8d,r8d
       mov       rax,[rsp+30]
       jmp       short M04_L25
M04_L22:
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M04_L48
M04_L23:
       mov       r9,rdx
M04_L24:
       movsxd    rdx,dword ptr [rsp+50]
       mov       rcx,rax
       mov       r8,r9
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rcx,[rsp+50]
       inc       ecx
       cmp       esi,ecx
       mov       r8,rcx
       mov       rax,[rsp+30]
       jle       short M04_L26
M04_L25:
       mov       [rsp+50],r8
       mov       rdx,[rbx+r8*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       r10,[rsp+38]
       cmp       [r10+18],rcx
       je        short M04_L22
       mov       rcx,[r10+8]
       call      qword ptr [r10+18]
       mov       r9,rax
       mov       rax,[rsp+30]
       jmp       short M04_L24
M04_L26:
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M04_L27:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M04_L28
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M04_L50
       mov       rdx,rbx
       mov       r8d,r12d
       call      qword ptr [7FF922DC66B8]; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M04_L28:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+40],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M04_L30
       vmovups   ymm0,[7FF92314EC20]
       vbroadcastss ymm1,dword ptr [7FF92314EC40]
       lea       rcx,[rdx-20]
M04_L29:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M04_L29
       vmovd     ecx,xmm0
M04_L30:
       cmp       r9,rdx
       jb        near ptr M04_L52
M04_L31:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+40]
       xor       ebp,ebp
       test      r13d,r13d
       jle       short M04_L33
       cmp       esi,r13d
       jl        short M04_L35
       xor       ebp,ebp
M04_L32:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M04_L62
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M04_L32
M04_L33:
       mov       rax,r14
M04_L34:
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
M04_L35:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M04_L62
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M04_L62
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M04_L35
       jmp       short M04_L33
M04_L36:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M04_L01
M04_L37:
       mov       rcx,rsi
       mov       r11,7FF922930C20
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M04_L16
M04_L38:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L17
M04_L39:
       mov       rcx,rax
       call      qword ptr [7FF922F8F360]
       jmp       near ptr M04_L17
M04_L40:
       mov       rcx,rax
       call      qword ptr [7FF9229E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L17
M04_L41:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923026AC0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L17
M04_L42:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922930C28
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M04_L17
M04_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,25ED6002AF0
       mov       rbx,[rdx]
       jmp       near ptr M04_L17
M04_L44:
       mov       rdx,rbx
       mov       rcx,7FF9232687A8
       call      qword ptr [7FF9231BF228]
       jmp       near ptr M04_L18
M04_L45:
       jmp       near ptr M04_L34
M04_L46:
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
       jmp       near ptr M04_L19
M04_L47:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M04_L20
M04_L48:
       mov       rdx,29F6AE00008
       jmp       near ptr M04_L23
M04_L49:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229E58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L27
M04_L50:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M04_L28
M04_L51:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M04_L28
M04_L52:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M04_L52
       jmp       near ptr M04_L31
M04_L53:
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
M04_L54:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M04_L55
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M04_L55
       jmp       short M04_L56
M04_L55:
       mov       rcx,rsi
       mov       rdx,7FF923254F30
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L56:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M04_L57
       jmp       short M04_L58
M04_L57:
       mov       rdx,7FF923254F70
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M04_L58:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M04_L09
M04_L59:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M04_L60
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M04_L60
       jmp       short M04_L61
M04_L60:
       mov       rcx,rbx
       mov       rdx,7FF923254410
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L61:
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
       jmp       qword ptr [7FF9231BF228]
M04_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2006
```
```assembly
; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M05_L00:
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
       mov       rdi,[rbx+30]
       mov       rbp,[rbx]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.String
       cmp       [rcx+8],rax
       jne       short M05_L01
       mov       rcx,25ED6000A08
       cmp       rdi,[rcx]
       je        near ptr M05_L07
M05_L01:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M05_L06
M05_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+28]
       movzx     r14d,byte ptr [rbx+48]
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
       mov       rsi,[rbx+20]
       test      rsi,rsi
       je        near ptr M05_L05
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M05_L12
       mov       rdi,[rsi+30]
       mov       rcx,25ED6000A08
       cmp       rdi,[rcx]
       je        near ptr M05_L10
M05_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,[rsi+28]
       movzx     r15d,byte ptr [rsi+48]
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
       cmp       qword ptr [rsi+20],0
       je        short M05_L04
       mov       rcx,[rsi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M05_L11
       mov       rdx,r14
       call      qword ptr [7FF922DC4740]
       mov       rbp,rax
M05_L04:
       mov       rax,rbp
M05_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L06:
       mov       rcx,rbp
       mov       rdx,7FF923254800
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L07:
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
       call      qword ptr [7FF922D3DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M05_L08
       jmp       short M05_L09
M05_L08:
       mov       rcx,rbp
       mov       rdx,7FF923254818
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M05_L09:
       mov       rdx,rdi
       call      qword ptr [7FF9229E58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M05_L01
M05_L10:
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
       call      qword ptr [7FF922D3DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M05_L03
M05_L11:
       mov       rdx,r14
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M05_L04
M05_L12:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M05_L04
; Total bytes of code 570
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+20]
       mov       rcx,29F6AE00008
       test      rax,rax
       cmove     rax,rcx
       ret
; Total bytes of code 22
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M07_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M07_L02
       cmp       rdx,[r8]
       jne       short M07_L03
M07_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M07_L01:
       call      qword ptr [7FF9231BC180]
       int       3
M07_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M07_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M07_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229ED8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M08_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rbp,[rsi+8]
       mov       r14,[rsi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdx,[rdx+48]
       test      rdx,rdx
       je        near ptr M08_L07
M08_L01:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rbp
       je        near ptr M08_L15
       mov       rcx,[r14+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M08_L08
M08_L02:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M08_L05
       test      rbx,rbx
       je        near ptr M08_L09
       test      rbp,rbp
       je        near ptr M08_L09
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rbp+18],rdx
       jne       near ptr M08_L09
       cmp       [rbx+8],r13d
       jl        near ptr M08_L09
M08_L03:
       mov       edx,r15d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M08_L12
M08_L04:
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M08_L03
M08_L05:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M08_L06:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       near ptr M08_L11
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L07:
       mov       rdx,7FF923254910
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L01
M08_L08:
       mov       rcx,r14
       mov       rdx,7FF923254920
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L09:
       cmp       r15d,[rbx+8]
       jae       near ptr M08_L19
       mov       edx,r15d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rbp+18],rcx
       jne       short M08_L13
       mov       r8,[rdx+20]
       test      r8,r8
       je        short M08_L14
M08_L10:
       mov       edx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M08_L09
       jmp       near ptr M08_L05
M08_L11:
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M08_L18
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922DC66B8]
M08_L12:
       mov       r8,29F6AE00008
       jmp       near ptr M08_L04
M08_L13:
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
       mov       r8,rax
       jmp       short M08_L10
M08_L14:
       mov       r8,29F6AE00008
       jmp       short M08_L10
M08_L15:
       mov       rcx,[r14+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M08_L16
       jmp       short M08_L17
M08_L16:
       mov       rcx,r14
       mov       rdx,7FF923254920
       call      qword ptr [7FF9229EC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M08_L17:
       mov       rdx,rbx
       call      qword ptr [7FF9229E58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L18:
       mov       rdx,rbx
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+20]
M08_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 554
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       mov       rcx,29F6AE00008
       test      rax,rax
       cmove     rax,rcx
       ret
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M10_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M10_L00:
       call      qword ptr [7FF9231BD938]
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
       jle       short M11_L03
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M11_L03
M11_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       je        short M11_L02
M11_L01:
       mov       rcx,7FF923223328
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M11_L02:
       mov       rcx,25ED6000110
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M11_L05
       mov       rcx,25ED60000F0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M11_L04
       mov       rcx,7FF923223330
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M11_L01
M11_L03:
       mov       ecx,2
       call      qword ptr [7FF9231BD530]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M11_L00
M11_L04:
       mov       rcx,7FF92322332C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF923223328
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF922C05E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
M11_L05:
       mov       rcx,7FF923223334
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M11_L01
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
       jne       short M12_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
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
       je        near ptr M13_L05
       mov       rcx,[rbx]
       cmp       rcx,rsi
       je        near ptr M13_L04
       mov       rax,25ED6000038
       mov       rax,[rax]
       add       rax,10
       rorx      rdx,rcx,20
       xor       rdx,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rdx,r8
       mov       r8d,[rax]
       shrx      rdx,rdx,r8
       xor       r8d,r8d
M13_L00:
       lea       r10d,[rdx+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rax+r10*8]
       mov       r9d,[r10]
       and       r9d,0FFFFFFFE
       cmp       [r10+8],rcx
       jne       short M13_L01
       mov       r11,rsi
       xor       r11,[r10+10]
       cmp       r11,1
       jbe       short M13_L03
M13_L01:
       test      r9d,r9d
       je        short M13_L02
       inc       r8d
       add       edx,r8d
       and       edx,[rax+4]
       cmp       r8d,8
       jl        short M13_L00
M13_L02:
       mov       rcx,7FF923224954
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF9229E6340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M13_L03:
       cmp       r9d,[r10]
       jne       short M13_L02
       cmp       r11d,1
       jne       short M13_L02
       mov       rcx,7FF923224948
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M13_L05
M13_L04:
       mov       rcx,7FF923224950
       call      CORINFO_HELP_COUNTPROFILE32
M13_L05:
       mov       rcx,7FF92322494C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 246
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M14_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M14_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M14_L02
       test      r8b,18
       je        short M14_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M14_L05
M14_L00:
       test      r8b,4
       je        short M14_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M14_L05
M14_L01:
       test      r8,r8
       je        short M14_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M14_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M14_L05
M14_L02:
       cmp       r8,40
       ja        short M14_L06
M14_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M14_L10
M14_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M14_L05:
       vzeroupper
       ret
M14_L06:
       cmp       r8,800
       ja        near ptr M14_L12
       cmp       r8,100
       jae       short M14_L09
M14_L07:
       mov       r9,r8
       shr       r9,6
M14_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M14_L08
       and       r8,3F
       cmp       r8,10
       ja        short M14_L03
       jmp       short M14_L04
M14_L09:
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
       jmp       short M14_L07
M14_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M14_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M14_L04
M14_L11:
       cmp       rcx,rdx
       jne       short M14_L12
       cmp       [rdx],dl
       jmp       near ptr M14_L05
M14_L12:
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
       je        near ptr M15_L09
       test      rsi,rsi
       je        near ptr M15_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M15_L00
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
       jne       near ptr M15_L10
M15_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M15_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M15_L07
       sub       edi,eax
       js        near ptr M15_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M15_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M15_L06
       sub       ebp,eax
       js        near ptr M15_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M15_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M15_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98246A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M15_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M15_L16
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
M15_L01:
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
       jne       short M15_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246D930]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M15_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M15_L15
M15_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M15_L04:
       cmp       r8,4000
       jbe       short M15_L05
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
M15_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M15_L02
       jmp       near ptr M15_L14
M15_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M15_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M15_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M15_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M15_L10:
       call      qword ptr [7FF982463788]
       mov       rbx,rax
       call      qword ptr [7FF98246ED60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246D7C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M15_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF982481910]
       int       3
M15_L12:
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
M15_L13:
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
M15_L14:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M15_L02
M15_L15:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M15_L03
M15_L16:
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
       jne       short M16_L00
       ret
M16_L00:
       jmp       qword ptr [7FF9229E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark.OrderByWithComparer()
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
       mov       rcx,1CDA0400A48
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
       mov       rcx,7FF9231052B8
       call      qword ptr [7FF922D3C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,1CDA0400A60
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
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovups   ymm0,[7FF923151BE0]
       vbroadcastss ymm1,dword ptr [7FF923151C00]
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
       mov       rdx,1CDA0400A40
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1CDA0400A48
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L17:
       mov       ecx,11
       call      qword ptr [7FF922C07E58]
       int       3
M00_L18:
       mov       rcx,offset MT_System.Collections.Generic.Comparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1CDA0400B00
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
       call      qword ptr [7FF922DC3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L18
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF9232545D8
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
       mov       rdx,7FF923254470
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF9232545B8
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF923254A90
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF923254B50
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF923254B58
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B5F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,1CDA0400A60
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
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovups   ymm0,[7FF92314E5C0]
       vbroadcastss ymm1,dword ptr [7FF92314E5E0]
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
       mov       r11,7FF922930C18
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L36:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L17
M01_L37:
       mov       rcx,rax
       call      qword ptr [7FF922F8EEC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L38:
       mov       rcx,rax
       call      qword ptr [7FF9229E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L39:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923016A60]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L17
M01_L40:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922930C20
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1CDA0400AF8
       mov       rbx,[rdx]
       jmp       near ptr M01_L17
M01_L42:
       mov       rdx,rbx
       mov       rcx,7FF923267AB0
       call      qword ptr [7FF9231BF180]
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
       mov       rdx,7FF923254B30
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L53:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L54
       jmp       short M01_L55
M01_L54:
       mov       rdx,7FF923254B70
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
       mov       rdx,7FF923254580
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
       jmp       qword ptr [7FF9231BF180]
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1914
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF9231BC0F0]
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
       call      qword ptr [7FF9231BD878]
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
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark.OrderByWithoutComparer()
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
       mov       [rsp+58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,24663000A50
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L22
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rax,2464D000068
       mov       r14,[rax]
       mov       r15,r14
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L24
       xor       ecx,ecx
       mov       [rbp+20],rcx
       lea       rcx,[rbp+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+48],0
       mov       rcx,24663000A58
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L23
M00_L01:
       mov       rcx,rbp
       mov       rdx,offset MT_System.Linq.IOrderedEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r8,7FF923203708
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       r8,r14
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r9d,r9d
       call      rax
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M00_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L43
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L36
       mov       esi,[rdi+8]
M00_L02:
       test      esi,esi
       je        near ptr M00_L42
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L41
       mov       ebp,[rdi+8]
       mov       rcx,[rdi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L40
       cmp       ebp,[rdi+8]
       ja        near ptr M00_L40
       cmp       ebp,[rsi+8]
       ja        near ptr M00_L40
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rdi+10]
       lea       rax,[rsi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L39
       cmp       r8,4000
       ja        near ptr M00_L38
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M00_L37
M00_L03:
       mov       [rsp+58],rsi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+58]
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
M00_L04:
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L35
       mov       rdx,[rdi+18]
       mov       rcx,7FF9231252B8
       call      qword ptr [7FF922D5C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       ebp,[rsi+8]
       cmp       ebp,1
       jle       near ptr M00_L25
       mov       edx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,2464D000A08
       cmp       r12,[rcx]
       je        near ptr M00_L26
M00_L05:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+64],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+64]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       je        short M00_L07
       mov       rcx,[rdi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L27
       mov       rdx,r12
       call      qword ptr [7FF922DE4740]; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M00_L06:
       mov       rdi,rax
       mov       rax,rdi
M00_L07:
       mov       rdi,rax
       mov       r12d,ebp
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,24663000A60
       cmp       rax,[rdx]
       je        near ptr M00_L31
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M00_L11
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L11
M00_L08:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M00_L28
M00_L09:
       mov       [rsp+60],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+60]
       inc       r10d
       cmp       ebp,r10d
       jle       short M00_L13
       mov       rax,[rsp+38]
       jmp       short M00_L08
M00_L10:
       mov       rax,[rsp+38]
M00_L11:
       cmp       r10d,ebp
       jae       near ptr M00_L44
       mov       [rsp+60],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L29
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M00_L30
M00_L12:
       mov       edx,[rsp+60]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+60]
       inc       ecx
       cmp       ebp,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M00_L10
M00_L13:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M00_L14:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M00_L15
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L32
       mov       rdx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF922DE66B8]; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M00_L15:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L17
       vmovups   ymm0,[7FF923171EE0]
       vbroadcastss ymm1,dword ptr [7FF923171F00]
       lea       rcx,[rdx-20]
M00_L16:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L16
       vmovd     ecx,xmm0
M00_L17:
       cmp       r9,rdx
       jb        near ptr M00_L34
M00_L18:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L20
       cmp       ebp,r13d
       jl        short M00_L21
       xor       r12d,r12d
       nop       dword ptr [rax+rax]
M00_L19:
       lea       rcx,[r15+r12*2]
       mov       eax,[rdi+r12+10]
       cmp       eax,ebp
       jae       near ptr M00_L44
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L19
M00_L20:
       mov       rsi,r14
       jmp       near ptr M00_L03
M00_L21:
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8]
       cmp       r12d,ebp
       jae       near ptr M00_L44
       mov       edx,r12d
       mov       eax,[rdi+rdx*4+10]
       cmp       eax,ebp
       jae       near ptr M00_L44
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L21
       jmp       short M00_L20
M00_L22:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,24663000A40
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,24663000A50
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,24663000A40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,24663000A58
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L24:
       mov       ecx,11
       call      qword ptr [7FF922C27E58]
       int       3
M00_L25:
       mov       r14,rsi
       jmp       near ptr M00_L20
M00_L26:
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
       jmp       near ptr M00_L05
M00_L27:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L06
M00_L28:
       mov       r8,286E1E40008
       jmp       near ptr M00_L09
M00_L29:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M00_L12
M00_L30:
       mov       r8,286E1E40008
       jmp       near ptr M00_L12
M00_L31:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L14
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
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L34
       jmp       near ptr M00_L18
M00_L35:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M00_L20
M00_L36:
       mov       rcx,rdi
       mov       r11,7FF922950DE0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L02
M00_L37:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L03
M00_L38:
       mov       rcx,rax
       call      qword ptr [7FF922FAEEC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L39:
       mov       rcx,rax
       call      qword ptr [7FF922A05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L40:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923036A48]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L03
M00_L41:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF922950DE8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,24663000AF8
       mov       rsi,[rdx]
       jmp       near ptr M00_L03
M00_L43:
       mov       rdx,rsi
       mov       rcx,7FF923284818
       call      qword ptr [7FF9231DED90]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1887
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
       mov       r9,2464D000A10
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M03_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M03_L01
       cmp       [r10],rcx
       je        short M03_L06
M03_L00:
       cmp       [r10+8],rcx
       je        short M03_L06
       cmp       [r10+10],rcx
       je        short M03_L06
       cmp       [r10+18],rcx
       je        short M03_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M03_L04
       test      r8,r8
       je        short M03_L03
M03_L01:
       cmp       [r10],rcx
       je        short M03_L06
M03_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M03_L03
       cmp       [r10],rcx
       je        short M03_L06
       jmp       short M03_L02
M03_L03:
       test      dword ptr [rax],500C0000
       je        short M03_L05
       jmp       qword ptr [7FF922D5F648]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M03_L04:
       cmp       [r10],rcx
       je        short M03_L06
       jmp       short M03_L00
M03_L05:
       xor       edx,edx
M03_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
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
       jle       short M04_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M04_L02
M04_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M04_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M04_L53
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M04_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rax],rcx
       jne       near ptr M04_L36
       mov       rcx,rax
       call      qword ptr [7FF922DE3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M04_L01:
       jmp       near ptr M04_L18
M04_L02:
       mov       rcx,rbx
       mov       rdx,7FF923272EC0
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M04_L00
M04_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M04_L10
M04_L04:
       mov       rdx,rsi
       call      qword ptr [7FF922B7F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L59
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M04_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M04_L11
M04_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M04_L12
M04_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M04_L54
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M04_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M04_L13
M04_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M04_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M04_L14
M04_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M04_L09:
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
M04_L10:
       mov       rcx,rbx
       mov       rdx,7FF923272D58
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
M04_L11:
       mov       rcx,rbx
       mov       rdx,7FF923272EA0
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M04_L05
M04_L12:
       mov       rcx,rsi
       mov       rdx,7FF923273D08
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L06
M04_L13:
       mov       rcx,rsi
       mov       rdx,7FF923273DC8
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L07
M04_L14:
       mov       rcx,rsi
       mov       rdx,7FF923273DD0
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L08
M04_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B7F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M04_L44
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M04_L37
       mov       ebx,[rsi+8]
M04_L16:
       test      ebx,ebx
       je        near ptr M04_L43
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M04_L42
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M04_L41
       cmp       ebp,[rsi+8]
       ja        near ptr M04_L41
       cmp       ebp,[rbx+8]
       ja        near ptr M04_L41
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M04_L40
       cmp       r8,4000
       ja        near ptr M04_L39
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M04_L38
M04_L17:
       mov       rax,rbx
M04_L18:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M04_L45
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,2464D000A08
       cmp       r12,[rcx]
       je        near ptr M04_L46
M04_L19:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+5C],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+48]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+48]
       mov       ecx,[rsp+5C]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       je        short M04_L21
       mov       rcx,[rdi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M04_L47
       mov       rdx,r12
       call      qword ptr [7FF922DE4740]; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M04_L20:
       mov       rdi,rax
       mov       rax,rdi
M04_L21:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M04_L51
       mov       rax,[rdi+8]
       mov       [rsp+38],rax
       mov       rdx,24663000A60
       cmp       rax,[rdx]
       je        near ptr M04_L49
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+30],rax
       xor       r8d,r8d
       mov       rax,[rsp+30]
       jmp       short M04_L25
M04_L22:
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        near ptr M04_L48
M04_L23:
       mov       r9,rdx
M04_L24:
       movsxd    rdx,dword ptr [rsp+50]
       mov       rcx,rax
       mov       r8,r9
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rcx,[rsp+50]
       inc       ecx
       cmp       esi,ecx
       mov       r8,rcx
       mov       rax,[rsp+30]
       jle       short M04_L27
M04_L25:
       mov       [rsp+50],r8
       mov       rdx,[rbx+r8*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       r10,[rsp+38]
       cmp       [r10+18],rcx
       je        short M04_L22
       mov       rcx,[r10+8]
       call      qword ptr [r10+18]
       mov       r9,rax
       mov       rax,[rsp+30]
       jmp       short M04_L24
M04_L26:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M04_L62
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M04_L62
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M04_L26
       jmp       near ptr M04_L34
M04_L27:
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M04_L28:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M04_L29
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M04_L50
       mov       rdx,rbx
       mov       r8d,r12d
       call      qword ptr [7FF922DE66B8]; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M04_L29:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+40],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M04_L31
       vmovups   ymm0,[7FF92316E7E0]
       vbroadcastss ymm1,dword ptr [7FF92316E800]
       lea       rcx,[rdx-20]
M04_L30:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M04_L30
       vmovd     ecx,xmm0
M04_L31:
       cmp       r9,rdx
       jb        near ptr M04_L52
M04_L32:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+40]
       xor       ebp,ebp
       test      r13d,r13d
       jle       short M04_L34
       cmp       esi,r13d
       jl        near ptr M04_L26
       xor       ebp,ebp
       nop       word ptr [rax+rax]
M04_L33:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M04_L62
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M04_L33
M04_L34:
       mov       rax,r14
M04_L35:
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
M04_L36:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M04_L01
M04_L37:
       mov       rcx,rsi
       mov       r11,7FF922950DB0
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M04_L16
M04_L38:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L17
M04_L39:
       mov       rcx,rax
       call      qword ptr [7FF922FAEEC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L17
M04_L40:
       mov       rcx,rax
       call      qword ptr [7FF922A05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L17
M04_L41:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923036A48]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L17
M04_L42:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922950DB8
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M04_L17
M04_L43:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,24663000AF8
       mov       rbx,[rdx]
       jmp       near ptr M04_L17
M04_L44:
       mov       rdx,rbx
       mov       rcx,7FF923284818
       call      qword ptr [7FF9231DED90]
       jmp       near ptr M04_L18
M04_L45:
       jmp       near ptr M04_L35
M04_L46:
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
       jmp       near ptr M04_L19
M04_L47:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M04_L20
M04_L48:
       mov       rdx,286E1E40008
       jmp       near ptr M04_L23
M04_L49:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L28
M04_L50:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M04_L29
M04_L51:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M04_L29
M04_L52:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M04_L52
       jmp       near ptr M04_L32
M04_L53:
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
M04_L54:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M04_L55
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M04_L55
       jmp       short M04_L56
M04_L55:
       mov       rcx,rsi
       mov       rdx,7FF923273DA8
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L56:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M04_L57
       jmp       short M04_L58
M04_L57:
       mov       rdx,7FF923273DE8
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M04_L58:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M04_L09
M04_L59:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M04_L60
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M04_L60
       jmp       short M04_L61
M04_L60:
       mov       rcx,rbx
       mov       rdx,7FF923272E68
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L61:
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
       jmp       qword ptr [7FF9231DED90]
M04_L62:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2007
```
```assembly
; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M05_L00:
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
       mov       rdi,[rbx+30]
       mov       rbp,[rbx]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.String
       cmp       [rcx+8],rax
       jne       short M05_L01
       mov       rcx,2464D000A08
       cmp       rdi,[rcx]
       je        near ptr M05_L07
M05_L01:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M05_L06
M05_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+28]
       movzx     r14d,byte ptr [rbx+48]
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
       mov       rsi,[rbx+20]
       test      rsi,rsi
       je        near ptr M05_L05
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M05_L12
       mov       rdi,[rsi+30]
       mov       rcx,2464D000A08
       cmp       rdi,[rcx]
       je        near ptr M05_L10
M05_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,[rsi+28]
       movzx     r15d,byte ptr [rsi+48]
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
       cmp       qword ptr [rsi+20],0
       je        short M05_L04
       mov       rcx,[rsi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M05_L11
       mov       rdx,r14
       call      qword ptr [7FF922DE4740]
       mov       rbp,rax
M05_L04:
       mov       rax,rbp
M05_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L06:
       mov       rcx,rbp
       mov       rdx,7FF923273258
       call      qword ptr [7FF922A0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L07:
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
       call      qword ptr [7FF922D5DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M05_L08
       jmp       short M05_L09
M05_L08:
       mov       rcx,rbp
       mov       rdx,7FF923273270
       call      qword ptr [7FF922A0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M05_L09:
       mov       rdx,rdi
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M05_L01
M05_L10:
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
       call      qword ptr [7FF922D5DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M05_L03
M05_L11:
       mov       rdx,r14
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M05_L04
M05_L12:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M05_L04
; Total bytes of code 570
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+20]
       mov       rcx,286E1E40008
       test      rax,rax
       cmove     rax,rcx
       ret
; Total bytes of code 22
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M07_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M07_L02
       cmp       rdx,[r8]
       jne       short M07_L03
M07_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M07_L01:
       call      qword ptr [7FF9231DC138]
       int       3
M07_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M07_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M07_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF922A0D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M08_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rbp,[rsi+8]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdx,[rdx+48]
       test      rdx,rdx
       je        near ptr M08_L07
M08_L01:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rbp
       je        near ptr M08_L15
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+50]
       test      rax,rax
       je        near ptr M08_L08
       mov       rcx,rax
M08_L02:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M08_L05
       test      rbx,rbx
       je        near ptr M08_L09
       test      rbp,rbp
       je        near ptr M08_L09
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rbp+18],rdx
       jne       near ptr M08_L09
       cmp       [rbx+8],r13d
       jl        near ptr M08_L09
M08_L03:
       mov       edx,r15d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M08_L12
M08_L04:
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M08_L03
M08_L05:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M08_L06:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       near ptr M08_L11
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L07:
       mov       rdx,7FF923273368
       call      qword ptr [7FF922A0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L01
M08_L08:
       mov       rdx,7FF923273378
       call      qword ptr [7FF922A0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L09:
       cmp       r15d,[rbx+8]
       jae       near ptr M08_L19
       mov       edx,r15d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rbp+18],rcx
       jne       short M08_L13
       mov       r8,[rdx+20]
       test      r8,r8
       je        short M08_L14
M08_L10:
       mov       edx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M08_L09
       jmp       near ptr M08_L05
M08_L11:
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M08_L18
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922DE66B8]
M08_L12:
       mov       r8,286E1E40008
       jmp       near ptr M08_L04
M08_L13:
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
       mov       r8,rax
       jmp       short M08_L10
M08_L14:
       mov       r8,286E1E40008
       jmp       short M08_L10
M08_L15:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M08_L16
       jmp       short M08_L17
M08_L16:
       mov       rdx,7FF923273378
       call      qword ptr [7FF922A0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L17:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L18:
       mov       rdx,rbx
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+20]
M08_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 557
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       mov       rcx,286E1E40008
       test      rax,rax
       cmove     rax,rcx
       ret
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M10_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M10_L00:
       call      qword ptr [7FF9231DD470]
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
       jle       short M11_L03
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M11_L03
M11_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       je        short M11_L02
M11_L01:
       mov       rcx,7FF92322C680
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M11_L02:
       mov       rcx,2464D000110
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M11_L05
       mov       rcx,2464D0000F0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M11_L04
       mov       rcx,7FF92322C688
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M11_L01
M11_L03:
       mov       ecx,2
       call      qword ptr [7FF9231DD068]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M11_L00
M11_L04:
       mov       rcx,7FF92322C684
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF92322C680
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF922C25E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
M11_L05:
       mov       rcx,7FF92322C68C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M11_L01
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
       jne       short M12_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
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
       je        near ptr M13_L05
       mov       rcx,[rbx]
       cmp       rcx,rsi
       je        near ptr M13_L04
       mov       rax,2464D000038
       mov       rax,[rax]
       add       rax,10
       rorx      rdx,rcx,20
       xor       rdx,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rdx,r8
       mov       r8d,[rax]
       shrx      rdx,rdx,r8
       xor       r8d,r8d
M13_L00:
       lea       r10d,[rdx+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rax+r10*8]
       mov       r9d,[r10]
       and       r9d,0FFFFFFFE
       cmp       [r10+8],rcx
       jne       short M13_L01
       mov       r11,rsi
       xor       r11,[r10+10]
       cmp       r11,1
       jbe       short M13_L03
M13_L01:
       test      r9d,r9d
       je        short M13_L02
       inc       r8d
       add       edx,r8d
       and       edx,[rax+4]
       cmp       r8d,8
       jl        short M13_L00
M13_L02:
       mov       rcx,7FF92322DCAC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF922A06340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M13_L03:
       cmp       r9d,[r10]
       jne       short M13_L02
       cmp       r11d,1
       jne       short M13_L02
       mov       rcx,7FF92322DCA0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M13_L05
M13_L04:
       mov       rcx,7FF92322DCA8
       call      CORINFO_HELP_COUNTPROFILE32
M13_L05:
       mov       rcx,7FF92322DCA4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 246
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
       je        short M14_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M14_L06
M14_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FF98246A630]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M14_L04
M14_L01:
       cmp       rdi,4000
       ja        short M14_L00
M14_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M14_L05
M14_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M14_L04:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       short M14_L01
M14_L05:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       short M14_L03
M14_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M14_L07
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
M14_L07:
       cmp       rdi,4000
       ja        short M14_L06
       jmp       short M14_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M15_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M15_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M15_L02
       test      r8b,18
       je        short M15_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M15_L05
M15_L00:
       test      r8b,4
       je        short M15_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M15_L05
M15_L01:
       test      r8,r8
       je        short M15_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M15_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M15_L05
M15_L02:
       cmp       r8,40
       ja        short M15_L06
M15_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M15_L09
M15_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M15_L05:
       vzeroupper
       ret
M15_L06:
       cmp       r8,800
       ja        near ptr M15_L12
       cmp       r8,100
       jae       short M15_L10
M15_L07:
       mov       r9,r8
       shr       r9,6
M15_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M15_L08
       and       r8,3F
       cmp       r8,10
       ja        short M15_L03
       jmp       short M15_L04
M15_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M15_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M15_L04
M15_L10:
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
       jmp       short M15_L07
M15_L11:
       cmp       rcx,rdx
       jne       short M15_L12
       cmp       [rdx],dl
       jmp       near ptr M15_L05
M15_L12:
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
       je        near ptr M16_L09
       test      rsi,rsi
       je        near ptr M16_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M16_L00
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
       jne       near ptr M16_L10
M16_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M16_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M16_L07
       sub       edi,eax
       js        near ptr M16_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M16_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M16_L06
       sub       ebp,eax
       js        near ptr M16_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M16_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M16_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98246A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M16_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M16_L16
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
M16_L01:
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
       jne       short M16_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246D930]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M16_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M16_L15
M16_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M16_L04:
       cmp       r8,4000
       jbe       short M16_L05
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
M16_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M16_L02
       jmp       near ptr M16_L14
M16_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M16_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M16_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M16_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M16_L10:
       call      qword ptr [7FF982463788]
       mov       rbx,rax
       call      qword ptr [7FF98246ED60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246D7C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M16_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF982481910]
       int       3
M16_L12:
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
M16_L13:
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
M16_L14:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M16_L02
M16_L15:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M16_L03
M16_L16:
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
       jne       short M17_L00
       ret
M17_L00:
       jmp       qword ptr [7FF922A05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark.OrderByWithComparer()
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
       mov       rcx,28977C00A48
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
       mov       rcx,7FF9231152B8
       call      qword ptr [7FF922D4C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       edi,[rsi+8]
       cmp       edi,1
       jle       near ptr M00_L20
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
       jne       near ptr M00_L21
M00_L02:
       mov       r15,rax
       mov       r12d,edi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r15],rdx
       jne       near ptr M00_L25
       mov       rax,[r15+8]
       mov       [rsp+30],rax
       mov       rdx,28977C00A60
       cmp       rax,[rdx]
       je        near ptr M00_L23
       mov       edx,r12d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       r9,[rsp+30]
       test      r9,r9
       je        short M00_L05
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L22
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
       jne       near ptr M00_L24
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
       vmovups   ymm0,[7FF9231623C0]
       vbroadcastss ymm1,dword ptr [7FF9231623E0]
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
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,28977C00A40
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28977C00A48
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L18:
       mov       ecx,11
       call      qword ptr [7FF922C17E58]
       int       3
M00_L19:
       mov       rcx,offset MT_System.Collections.Generic.Comparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,28977C00B00
       mov       rdx,[rcx]
       jmp       near ptr M00_L01
M00_L20:
       mov       rbp,rsi
       jmp       near ptr M00_L14
M00_L21:
       mov       rcx,[r15+20]
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r15,rax
       mov       rax,r15
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
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L09
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
       jne       near ptr M01_L34
       mov       rcx,rax
       call      qword ptr [7FF922DD3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L18
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF923264530
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
       mov       rdx,7FF9232643C8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF923264510
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9232649E8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF923264AA8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF923264AB0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L08
M01_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B6F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,28977C00A60
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
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovups   ymm0,[7FF92315EE60]
       vbroadcastss ymm1,dword ptr [7FF92315EE80]
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
       mov       r11,7FF922940C10
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L36:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L17
M01_L37:
       mov       rcx,rax
       call      qword ptr [7FF922F9EEC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L38:
       mov       rcx,rax
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L39:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923036B08]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L17
M01_L40:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922940C18
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,28977C00AF8
       mov       rbx,[rdx]
       jmp       near ptr M01_L17
M01_L42:
       mov       rdx,rbx
       mov       rcx,7FF923278050
       call      qword ptr [7FF9231CF210]
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
       mov       rdx,7FF923264A88
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L53:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L54
       jmp       short M01_L55
M01_L54:
       mov       rdx,7FF923264AC8
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
       mov       rdx,7FF9232644D8
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
       jmp       qword ptr [7FF9231CF210]
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1914
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF9231CC108]
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
       call      qword ptr [7FF9231CD908]
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
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark.OrderByWithoutComparer()
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
       mov       [rsp+58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,26DD6802A48
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L22
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rax,26DD6800068
       mov       r14,[rax]
       mov       r15,r14
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L24
       xor       ecx,ecx
       mov       [rbp+20],rcx
       lea       rcx,[rbp+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+48],0
       mov       rcx,26DD6802A50
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L23
M00_L01:
       mov       rcx,rbp
       mov       rdx,offset MT_System.Linq.IOrderedEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r8,7FF9231F3708
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       r8,r14
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r9d,r9d
       call      rax
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M00_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L43
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L36
       mov       esi,[rdi+8]
M00_L02:
       test      esi,esi
       je        near ptr M00_L42
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L41
       mov       ebp,[rdi+8]
       mov       rcx,[rdi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L40
       cmp       ebp,[rdi+8]
       ja        near ptr M00_L40
       cmp       ebp,[rsi+8]
       ja        near ptr M00_L40
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rdi+10]
       lea       rax,[rsi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L39
       cmp       r8,4000
       ja        near ptr M00_L38
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M00_L37
M00_L03:
       mov       [rsp+58],rsi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+58]
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
M00_L04:
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L35
       mov       rdx,[rdi+18]
       mov       rcx,7FF9231152B8
       call      qword ptr [7FF922D4C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       ebp,[rsi+8]
       cmp       ebp,1
       jle       near ptr M00_L25
       mov       edx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,26DD6800A08
       cmp       r12,[rcx]
       je        near ptr M00_L26
M00_L05:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+64],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+64]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       je        short M00_L07
       mov       rcx,[rdi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L27
       mov       rdx,r12
       call      qword ptr [7FF922DD4740]; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M00_L06:
       mov       rdi,rax
       mov       rax,rdi
M00_L07:
       mov       rdi,rax
       mov       r12d,ebp
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,26DD6802A58
       cmp       rax,[rdx]
       je        near ptr M00_L31
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M00_L11
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L11
M00_L08:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M00_L28
M00_L09:
       mov       [rsp+60],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+60]
       inc       r10d
       cmp       ebp,r10d
       jle       short M00_L13
       mov       rax,[rsp+38]
       jmp       short M00_L08
M00_L10:
       mov       rax,[rsp+38]
M00_L11:
       cmp       r10d,ebp
       jae       near ptr M00_L44
       mov       [rsp+60],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L29
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M00_L30
M00_L12:
       mov       edx,[rsp+60]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+60]
       inc       ecx
       cmp       ebp,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M00_L10
M00_L13:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M00_L14:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M00_L15
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L32
       mov       rdx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF922DD66B8]; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M00_L15:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L17
       vmovups   ymm0,[7FF9231648E0]
       vbroadcastss ymm1,dword ptr [7FF923164900]
       lea       rcx,[rdx-20]
M00_L16:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L16
       vmovd     ecx,xmm0
M00_L17:
       cmp       r9,rdx
       jb        near ptr M00_L34
M00_L18:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L20
       cmp       ebp,r13d
       jl        short M00_L21
       xor       r12d,r12d
       nop       dword ptr [rax+rax]
M00_L19:
       lea       rcx,[r15+r12*2]
       mov       eax,[rdi+r12+10]
       cmp       eax,ebp
       jae       near ptr M00_L44
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L19
M00_L20:
       mov       rsi,r14
       jmp       near ptr M00_L03
M00_L21:
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8]
       cmp       r12d,ebp
       jae       near ptr M00_L44
       mov       edx,r12d
       mov       eax,[rdi+rdx*4+10]
       cmp       eax,ebp
       jae       near ptr M00_L44
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L21
       jmp       short M00_L20
M00_L22:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,26DD6802A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26DD6802A48
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,26DD6802A38
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26DD6802A50
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L24:
       mov       ecx,11
       call      qword ptr [7FF922C17E58]
       int       3
M00_L25:
       mov       r14,rsi
       jmp       near ptr M00_L20
M00_L26:
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
       jmp       near ptr M00_L05
M00_L27:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L06
M00_L28:
       mov       r8,2AE6B700008
       jmp       near ptr M00_L09
M00_L29:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M00_L12
M00_L30:
       mov       r8,2AE6B700008
       jmp       near ptr M00_L12
M00_L31:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L14
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
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L34
       jmp       near ptr M00_L18
M00_L35:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M00_L20
M00_L36:
       mov       rcx,rdi
       mov       r11,7FF922940DE8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L02
M00_L37:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L03
M00_L38:
       mov       rcx,rax
       call      qword ptr [7FF922F9EEC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L39:
       mov       rcx,rax
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L40:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923036AC0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L03
M00_L41:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF922940DF0
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L42:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,26DD6802AF0
       mov       rsi,[rdx]
       jmp       near ptr M00_L03
M00_L43:
       mov       rdx,rsi
       mov       rcx,7FF92327BA10
       call      qword ptr [7FF9231CF240]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1887
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
       mov       r9,26DD6800A10
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M03_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M03_L01
       cmp       [r10],rcx
       je        short M03_L06
M03_L00:
       cmp       [r10+8],rcx
       je        short M03_L06
       cmp       [r10+10],rcx
       je        short M03_L06
       cmp       [r10+18],rcx
       je        short M03_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M03_L04
       test      r8,r8
       je        short M03_L03
M03_L01:
       cmp       [r10],rcx
       je        short M03_L06
M03_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M03_L03
       cmp       [r10],rcx
       je        short M03_L06
       jmp       short M03_L02
M03_L03:
       test      dword ptr [rax],500C0000
       je        short M03_L05
       jmp       qword ptr [7FF922D4F648]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M03_L04:
       cmp       [r10],rcx
       je        short M03_L06
       jmp       short M03_L00
M03_L05:
       xor       edx,edx
M03_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
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
       jle       short M04_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M04_L02
M04_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M04_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M04_L56
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M04_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rax],rcx
       jne       near ptr M04_L37
       mov       rcx,rax
       call      qword ptr [7FF922DD3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M04_L01:
       jmp       near ptr M04_L18
M04_L02:
       mov       rcx,rbx
       mov       rdx,7FF923264730
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M04_L00
M04_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M04_L10
M04_L04:
       mov       rdx,rsi
       call      qword ptr [7FF922B6F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L62
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M04_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M04_L11
M04_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M04_L12
M04_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M04_L57
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M04_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M04_L13
M04_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M04_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M04_L14
M04_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M04_L09:
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
M04_L10:
       mov       rcx,rbx
       mov       rdx,7FF9232645C8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
       nop       dword ptr [rax+rax]
M04_L11:
       mov       rcx,rbx
       mov       rdx,7FF923264710
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M04_L05
M04_L12:
       mov       rcx,rsi
       mov       rdx,7FF923265708
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L06
M04_L13:
       mov       rcx,rsi
       mov       rdx,7FF9232657C8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L07
M04_L14:
       mov       rcx,rsi
       mov       rdx,7FF9232657D0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L08
M04_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B6F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M04_L45
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M04_L38
       mov       ebx,[rsi+8]
M04_L16:
       test      ebx,ebx
       je        near ptr M04_L44
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M04_L43
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M04_L42
       cmp       ebp,[rsi+8]
       ja        near ptr M04_L42
       cmp       ebp,[rbx+8]
       ja        near ptr M04_L42
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M04_L41
       cmp       r8,4000
       ja        near ptr M04_L40
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M04_L39
M04_L17:
       mov       rax,rbx
M04_L18:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M04_L46
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,26DD6800A08
       cmp       r12,[rcx]
       je        near ptr M04_L47
M04_L19:
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
       je        short M04_L21
       mov       rcx,[rdi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M04_L48
       mov       rdx,r12
       call      qword ptr [7FF922DD4740]; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M04_L20:
       mov       rdi,rax
       mov       rax,rdi
M04_L21:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M04_L54
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,26DD6802A58
       cmp       rax,[rdx]
       je        near ptr M04_L52
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M04_L25
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M04_L25
M04_L22:
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M04_L49
M04_L23:
       mov       [rsp+58],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+58]
       inc       r10d
       cmp       esi,r10d
       jle       short M04_L27
       mov       rax,[rsp+38]
       jmp       short M04_L22
M04_L24:
       mov       rax,[rsp+38]
M04_L25:
       cmp       r10d,esi
       jae       near ptr M04_L65
       mov       [rsp+58],r10d
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M04_L50
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M04_L51
M04_L26:
       mov       edx,[rsp+58]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+58]
       inc       ecx
       cmp       esi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M04_L24
M04_L27:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
M04_L28:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M04_L29
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M04_L53
       mov       rdx,rbx
       mov       r8d,r12d
       call      qword ptr [7FF922DD66B8]; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M04_L29:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M04_L31
       vmovups   ymm0,[7FF923161380]
       vbroadcastss ymm1,dword ptr [7FF9231613A0]
       lea       rcx,[rdx-20]
M04_L30:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M04_L30
       vmovd     ecx,xmm0
M04_L31:
       cmp       r9,rdx
       jb        near ptr M04_L55
M04_L32:
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
       jle       short M04_L34
       cmp       esi,r13d
       jl        short M04_L36
       xor       ebp,ebp
M04_L33:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M04_L65
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M04_L33
M04_L34:
       mov       rax,r14
M04_L35:
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
M04_L36:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M04_L65
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M04_L65
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M04_L36
       jmp       short M04_L34
M04_L37:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M04_L01
M04_L38:
       mov       rcx,rsi
       mov       r11,7FF922940DB8
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M04_L16
M04_L39:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L17
M04_L40:
       mov       rcx,rax
       call      qword ptr [7FF922F9EEC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L17
M04_L41:
       mov       rcx,rax
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L17
M04_L42:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923036AC0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L17
M04_L43:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922940DC0
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M04_L17
M04_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,26DD6802AF0
       mov       rbx,[rdx]
       jmp       near ptr M04_L17
M04_L45:
       mov       rdx,rbx
       mov       rcx,7FF92327BA10
       call      qword ptr [7FF9231CF240]
       jmp       near ptr M04_L18
M04_L46:
       jmp       near ptr M04_L35
M04_L47:
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
       jmp       near ptr M04_L19
M04_L48:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M04_L20
M04_L49:
       mov       r8,2AE6B700008
       jmp       near ptr M04_L23
M04_L50:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M04_L26
M04_L51:
       mov       r8,2AE6B700008
       jmp       near ptr M04_L26
M04_L52:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L28
M04_L53:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M04_L29
M04_L54:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M04_L29
M04_L55:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M04_L55
       jmp       near ptr M04_L32
M04_L56:
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
M04_L57:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M04_L58
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M04_L58
       jmp       short M04_L59
M04_L58:
       mov       rcx,rsi
       mov       rdx,7FF9232657A8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L59:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M04_L60
       jmp       short M04_L61
M04_L60:
       mov       rdx,7FF9232657E8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M04_L61:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M04_L09
M04_L62:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M04_L63
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M04_L63
       jmp       short M04_L64
M04_L63:
       mov       rcx,rbx
       mov       rdx,7FF9232646D8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L64:
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
       jmp       qword ptr [7FF9231CF240]
M04_L65:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2106
```
```assembly
; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M05_L00:
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
       mov       rdi,[rbx+30]
       mov       rbp,[rbx]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.String
       cmp       [rcx+8],rax
       jne       short M05_L01
       mov       rcx,26DD6800A08
       cmp       rdi,[rcx]
       je        near ptr M05_L07
M05_L01:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M05_L06
M05_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+28]
       movzx     r14d,byte ptr [rbx+48]
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
       mov       rsi,[rbx+20]
       test      rsi,rsi
       je        near ptr M05_L05
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M05_L12
       mov       rdi,[rsi+30]
       mov       rcx,26DD6800A08
       cmp       rdi,[rcx]
       je        near ptr M05_L10
M05_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,[rsi+28]
       movzx     r15d,byte ptr [rsi+48]
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
       cmp       qword ptr [rsi+20],0
       je        short M05_L04
       mov       rcx,[rsi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M05_L11
       mov       rdx,r14
       call      qword ptr [7FF922DD4740]
       mov       rbp,rax
M05_L04:
       mov       rax,rbp
M05_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L06:
       mov       rcx,rbp
       mov       rdx,7FF923264AC8
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L07:
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
       call      qword ptr [7FF922D4DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M05_L08
       jmp       short M05_L09
M05_L08:
       mov       rcx,rbp
       mov       rdx,7FF923264AE0
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M05_L09:
       mov       rdx,rdi
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M05_L01
M05_L10:
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
       call      qword ptr [7FF922D4DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M05_L03
M05_L11:
       mov       rdx,r14
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M05_L04
M05_L12:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M05_L04
; Total bytes of code 570
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+20]
       mov       rcx,2AE6B700008
       test      rax,rax
       cmove     rax,rcx
       ret
; Total bytes of code 22
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M07_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M07_L02
       cmp       rdx,[r8]
       jne       short M07_L03
M07_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M07_L01:
       call      qword ptr [7FF9231C7990]
       int       3
M07_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M07_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M07_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229FD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M08_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rbp,[rsi+8]
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdx,[rdx+48]
       test      rdx,rdx
       je        near ptr M08_L07
M08_L01:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rbp
       je        near ptr M08_L15
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+50]
       test      rax,rax
       je        near ptr M08_L08
       mov       rcx,rax
M08_L02:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M08_L05
       test      rbx,rbx
       je        near ptr M08_L09
       test      rbp,rbp
       je        near ptr M08_L09
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rbp+18],rdx
       jne       near ptr M08_L09
       cmp       [rbx+8],r13d
       jl        near ptr M08_L09
M08_L03:
       mov       edx,r15d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M08_L12
M08_L04:
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M08_L03
M08_L05:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M08_L06:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       near ptr M08_L11
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L07:
       mov       rdx,7FF923264BD8
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L01
M08_L08:
       mov       rdx,7FF923264BE8
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L09:
       cmp       r15d,[rbx+8]
       jae       near ptr M08_L19
       mov       edx,r15d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rbp+18],rcx
       jne       short M08_L13
       mov       r8,[rdx+20]
       test      r8,r8
       je        short M08_L14
M08_L10:
       mov       edx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M08_L09
       jmp       near ptr M08_L05
M08_L11:
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M08_L18
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922DD66B8]
M08_L12:
       mov       r8,2AE6B700008
       jmp       near ptr M08_L04
M08_L13:
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
       mov       r8,rax
       jmp       short M08_L10
M08_L14:
       mov       r8,2AE6B700008
       jmp       short M08_L10
M08_L15:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M08_L16
       jmp       short M08_L17
M08_L16:
       mov       rdx,7FF923264BE8
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M08_L17:
       mov       rcx,rdx
       mov       rdx,rbx
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L18:
       mov       rdx,rbx
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+20]
M08_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 557
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       mov       rcx,2AE6B700008
       test      rax,rax
       cmove     rax,rcx
       ret
; Total bytes of code 22
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M10_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M10_L00:
       call      qword ptr [7FF9231CD938]
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
       jle       short M11_L03
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M11_L03
M11_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       je        short M11_L02
M11_L01:
       mov       rcx,7FF923233838
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M11_L02:
       mov       rcx,26DD6800110
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M11_L05
       mov       rcx,26DD68000F0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M11_L04
       mov       rcx,7FF923233840
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M11_L01
M11_L03:
       mov       ecx,2
       call      qword ptr [7FF9231CD530]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M11_L00
M11_L04:
       mov       rcx,7FF92323383C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF923233838
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF922C15E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
M11_L05:
       mov       rcx,7FF923233844
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M11_L01
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
       jne       short M12_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
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
       je        near ptr M13_L05
       mov       rcx,[rbx]
       cmp       rcx,rsi
       je        near ptr M13_L04
       mov       rax,26DD6800038
       mov       rax,[rax]
       add       rax,10
       rorx      rdx,rcx,20
       xor       rdx,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rdx,r8
       mov       r8d,[rax]
       shrx      rdx,rdx,r8
       xor       r8d,r8d
M13_L00:
       lea       r10d,[rdx+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rax+r10*8]
       mov       r9d,[r10]
       and       r9d,0FFFFFFFE
       cmp       [r10+8],rcx
       jne       short M13_L01
       mov       r11,rsi
       xor       r11,[r10+10]
       cmp       r11,1
       jbe       short M13_L03
M13_L01:
       test      r9d,r9d
       je        short M13_L02
       inc       r8d
       add       edx,r8d
       and       edx,[rax+4]
       cmp       r8d,8
       jl        short M13_L00
M13_L02:
       mov       rcx,7FF923234E2C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF9229F6340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M13_L03:
       cmp       r9d,[r10]
       jne       short M13_L02
       cmp       r11d,1
       jne       short M13_L02
       mov       rcx,7FF923234E20
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M13_L05
M13_L04:
       mov       rcx,7FF923234E28
       call      CORINFO_HELP_COUNTPROFILE32
M13_L05:
       mov       rcx,7FF923234E24
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 246
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
       je        short M14_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M14_L06
M14_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FF98246A630]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M14_L04
M14_L01:
       cmp       rdi,4000
       ja        short M14_L00
M14_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M14_L05
M14_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M14_L04:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       short M14_L01
M14_L05:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       short M14_L03
M14_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M14_L07
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
M14_L07:
       cmp       rdi,4000
       ja        short M14_L06
       jmp       short M14_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M15_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M15_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M15_L02
       test      r8b,18
       je        short M15_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M15_L05
M15_L00:
       test      r8b,4
       je        short M15_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M15_L05
M15_L01:
       test      r8,r8
       je        short M15_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M15_L05
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M15_L05
M15_L02:
       cmp       r8,40
       ja        short M15_L06
M15_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M15_L09
M15_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M15_L05:
       vzeroupper
       ret
M15_L06:
       cmp       r8,800
       ja        near ptr M15_L12
       cmp       r8,100
       jae       short M15_L10
M15_L07:
       mov       r9,r8
       shr       r9,6
M15_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M15_L08
       and       r8,3F
       cmp       r8,10
       ja        short M15_L03
       jmp       short M15_L04
M15_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M15_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M15_L04
M15_L10:
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
       jmp       short M15_L07
M15_L11:
       cmp       rcx,rdx
       jne       short M15_L12
       cmp       [rdx],dl
       jmp       near ptr M15_L05
M15_L12:
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
       je        near ptr M16_L09
       test      rsi,rsi
       je        near ptr M16_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M16_L00
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
       jne       near ptr M16_L10
M16_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M16_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M16_L07
       sub       edi,eax
       js        near ptr M16_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M16_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M16_L06
       sub       ebp,eax
       js        near ptr M16_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M16_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M16_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98246A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M16_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M16_L16
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
M16_L01:
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
       jne       short M16_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246D930]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M16_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M16_L15
M16_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M16_L04:
       cmp       r8,4000
       jbe       short M16_L05
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
M16_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M16_L02
       jmp       near ptr M16_L14
M16_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M16_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M16_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M16_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M16_L10:
       call      qword ptr [7FF982463788]
       mov       rbx,rax
       call      qword ptr [7FF98246ED60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246D7C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M16_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF982481910]
       int       3
M16_L12:
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
M16_L13:
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
M16_L14:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M16_L02
M16_L15:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M16_L03
M16_L16:
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
       jne       short M17_L00
       ret
M17_L00:
       jmp       qword ptr [7FF9229F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark.OrderByWithComparer()
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
       mov       rcx,1FE1F800A48
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
       mov       rdx,1FE1F800A60
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
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovups   ymm0,[7FF92314F6A0]
       vbroadcastss ymm1,dword ptr [7FF92314F6C0]
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
       mov       rdx,1FE1F800A40
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1FE1F800A48
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
       mov       rcx,1FE1F800B00
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
       mov       rdx,7FF9232531C8
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
       mov       rdx,7FF923253060
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF9232531A8
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF923253790
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF923253850
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF923253858
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
       mov       rdx,1FE1F800A60
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
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovups   ymm0,[7FF92314DAE0]
       vbroadcastss ymm1,dword ptr [7FF92314DB00]
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
       call      qword ptr [7FF923016A60]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rdx,1FE1F800AF8
       mov       rbx,[rdx]
       jmp       near ptr M01_L17
M01_L45:
       mov       rdx,rbx
       mov       rcx,7FF9232614A0
       call      qword ptr [7FF9231BED78]
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
       mov       rdx,7FF923253830
       call      qword ptr [7FF922C07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L53:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L54
       jmp       short M01_L55
M01_L54:
       mov       rdx,7FF923253870
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
       mov       rdx,7FF923253170
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
       jmp       qword ptr [7FF9231BED78]
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1921
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF9231BD380]
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
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark.OrderByWithoutComparer()
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
       mov       [rsp+58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,11DB5C00A50
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L23
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rax,11D9FC00068
       mov       r14,[rax]
       mov       r15,r14
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L25
       xor       ecx,ecx
       mov       [rbp+20],rcx
       lea       rcx,[rbp+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+48],0
       mov       rcx,11DB5C00A58
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L01:
       mov       rcx,rbp
       mov       rdx,offset MT_System.Linq.IOrderedEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r8,7FF9231F2A38
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       r8,r14
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r9d,r9d
       call      rax
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M00_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L42
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L35
       mov       esi,[rdi+8]
M00_L02:
       test      esi,esi
       je        near ptr M00_L41
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L40
       mov       ebp,[rdi+8]
       mov       rcx,[rdi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L39
       cmp       ebp,[rdi+8]
       ja        near ptr M00_L39
       cmp       ebp,[rsi+8]
       ja        near ptr M00_L39
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rdi+10]
       lea       rax,[rsi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L38
       cmp       r8,4000
       ja        near ptr M00_L37
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M00_L36
M00_L03:
       mov       [rsp+58],rsi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+58]
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
M00_L04:
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L34
       mov       rdx,[rdi+18]
       mov       rcx,7FF9231152B8
       call      qword ptr [7FF922D4C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       ebp,[rsi+8]
       cmp       ebp,1
       jle       near ptr M00_L26
       mov       edx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,11D9FC00A08
       cmp       r12,[rcx]
       je        near ptr M00_L27
M00_L05:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+64],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+64]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       je        short M00_L07
       mov       rcx,[rdi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L28
       mov       rdx,r12
       call      qword ptr [7FF922DD4740]; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M00_L06:
       mov       rdi,rax
       mov       rax,rdi
M00_L07:
       mov       rdi,rax
       mov       r12d,ebp
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,11DB5C00A60
       cmp       rax,[rdx]
       je        near ptr M00_L20
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M00_L11
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L11
M00_L08:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M00_L29
M00_L09:
       mov       [rsp+60],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+60]
       inc       r10d
       cmp       ebp,r10d
       jle       short M00_L13
       mov       rax,[rsp+38]
       jmp       short M00_L08
M00_L10:
       mov       rax,[rsp+38]
M00_L11:
       cmp       r10d,ebp
       jae       near ptr M00_L43
       mov       [rsp+60],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L30
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M00_L31
M00_L12:
       mov       edx,[rsp+60]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+60]
       inc       ecx
       cmp       ebp,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M00_L10
M00_L13:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M00_L14
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L32
       mov       rdx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF922DD66B8]; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M00_L14:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L16
       vmovups   ymm0,[7FF923162AC0]
       vbroadcastss ymm1,dword ptr [7FF923162AE0]
       lea       rcx,[rdx-20]
M00_L15:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L15
       vmovd     ecx,xmm0
M00_L16:
       cmp       r9,rdx
       jb        short M00_L21
       nop       dword ptr [rax]
M00_L17:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L19
       cmp       ebp,r13d
       jl        short M00_L22
       xor       r12d,r12d
       nop       dword ptr [rax+rax]
M00_L18:
       lea       rcx,[r15+r12*2]
       mov       eax,[rdi+r12+10]
       cmp       eax,ebp
       jae       near ptr M00_L43
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L18
M00_L19:
       mov       rsi,r14
       jmp       near ptr M00_L03
M00_L20:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M00_L21:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L21
       jmp       near ptr M00_L17
M00_L22:
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8]
       cmp       r12d,ebp
       jae       near ptr M00_L43
       mov       edx,r12d
       mov       eax,[rdi+rdx*4+10]
       cmp       eax,ebp
       jae       near ptr M00_L43
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L22
       jmp       short M00_L19
M00_L23:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,11DB5C00A40
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,11DB5C00A50
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,11DB5C00A40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,11DB5C00A58
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L25:
       mov       ecx,11
       call      qword ptr [7FF922C17E58]
       int       3
M00_L26:
       mov       r14,rsi
       jmp       near ptr M00_L19
M00_L27:
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
       jmp       near ptr M00_L05
M00_L28:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L06
M00_L29:
       mov       r8,15E34AC0008
       jmp       near ptr M00_L09
M00_L30:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M00_L12
M00_L31:
       mov       r8,15E34AC0008
       jmp       near ptr M00_L12
M00_L32:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L14
M00_L33:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L14
M00_L34:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M00_L19
M00_L35:
       mov       rcx,rdi
       mov       r11,7FF922940C68
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L02
M00_L36:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L03
M00_L37:
       mov       rcx,rax
       call      qword ptr [7FF922F9EAC0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L38:
       mov       rcx,rax
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L39:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923036A90]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L03
M00_L40:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF922940C70
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,11DB5C00AF8
       mov       rsi,[rdx]
       jmp       near ptr M00_L03
M00_L42:
       mov       rdx,rsi
       mov       rcx,7FF923278598
       call      qword ptr [7FF9231CF228]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L43:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1871
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
       mov       r9,11D9FC00A10
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M03_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M03_L01
       cmp       [r10],rcx
       je        short M03_L06
M03_L00:
       cmp       [r10+8],rcx
       je        short M03_L06
       cmp       [r10+10],rcx
       je        short M03_L06
       cmp       [r10+18],rcx
       je        short M03_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M03_L04
       test      r8,r8
       je        short M03_L03
M03_L01:
       cmp       [r10],rcx
       je        short M03_L06
M03_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M03_L03
       cmp       [r10],rcx
       je        short M03_L06
       jmp       short M03_L02
M03_L03:
       test      dword ptr [rax],500C0000
       je        short M03_L05
       jmp       qword ptr [7FF922D4F648]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M03_L04:
       cmp       [r10],rcx
       je        short M03_L06
       jmp       short M03_L00
M03_L05:
       xor       edx,edx
M03_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
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
       jle       short M04_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M04_L02
M04_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M04_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M04_L55
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M04_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rax],rcx
       jne       near ptr M04_L38
       mov       rcx,rax
       call      qword ptr [7FF922DD3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M04_L01:
       jmp       near ptr M04_L18
M04_L02:
       mov       rcx,rbx
       mov       rdx,7FF9232648F0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M04_L00
M04_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M04_L10
M04_L04:
       mov       rdx,rsi
       call      qword ptr [7FF922B6F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L61
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M04_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M04_L11
M04_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M04_L12
M04_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M04_L56
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M04_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M04_L13
M04_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M04_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M04_L14
M04_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M04_L09:
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
M04_L10:
       mov       rcx,rbx
       mov       rdx,7FF923264788
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
       nop       dword ptr [rax+rax]
M04_L11:
       mov       rcx,rbx
       mov       rdx,7FF9232648D0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M04_L05
M04_L12:
       mov       rcx,rsi
       mov       rdx,7FF923265390
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L06
M04_L13:
       mov       rcx,rsi
       mov       rdx,7FF923265450
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L07
M04_L14:
       mov       rcx,rsi
       mov       rdx,7FF923265458
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L08
M04_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B6F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M04_L46
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M04_L39
       mov       ebx,[rsi+8]
M04_L16:
       test      ebx,ebx
       je        near ptr M04_L45
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M04_L44
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M04_L43
       cmp       ebp,[rsi+8]
       ja        near ptr M04_L43
       cmp       ebp,[rbx+8]
       ja        near ptr M04_L43
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M04_L42
       cmp       r8,4000
       ja        near ptr M04_L41
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M04_L40
M04_L17:
       mov       rax,rbx
M04_L18:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M04_L47
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,11D9FC00A08
       cmp       r12,[rcx]
       je        near ptr M04_L48
M04_L19:
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
       je        short M04_L21
       mov       rcx,[rdi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M04_L49
       mov       rdx,r12
       call      qword ptr [7FF922DD4740]; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M04_L20:
       mov       rdi,rax
       mov       rax,rdi
M04_L21:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M04_L54
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,11DB5C00A60
       cmp       rax,[rdx]
       je        near ptr M04_L35
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M04_L25
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M04_L25
M04_L22:
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M04_L50
M04_L23:
       mov       [rsp+58],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+58]
       inc       r10d
       cmp       esi,r10d
       jle       short M04_L27
       mov       rax,[rsp+38]
       jmp       short M04_L22
M04_L24:
       mov       rax,[rsp+38]
M04_L25:
       cmp       r10d,esi
       jae       near ptr M04_L64
       mov       [rsp+58],r10d
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M04_L51
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M04_L52
M04_L26:
       mov       edx,[rsp+58]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+58]
       inc       ecx
       cmp       esi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M04_L24
M04_L27:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M04_L28
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M04_L53
       mov       rdx,rbx
       mov       r8d,r12d
       call      qword ptr [7FF922DD66B8]; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M04_L28:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M04_L30
       vmovups   ymm0,[7FF92315F520]
       vbroadcastss ymm1,dword ptr [7FF92315F540]
       lea       rcx,[rdx-20]
M04_L29:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M04_L29
       vmovd     ecx,xmm0
M04_L30:
       cmp       r9,rdx
       jb        near ptr M04_L36
M04_L31:
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
       jle       short M04_L33
       cmp       esi,r13d
       jl        short M04_L37
       xor       ebp,ebp
M04_L32:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M04_L64
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M04_L32
M04_L33:
       mov       rax,r14
M04_L34:
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
M04_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M04_L36:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M04_L36
       jmp       near ptr M04_L31
M04_L37:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M04_L64
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M04_L64
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M04_L37
       jmp       short M04_L33
M04_L38:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M04_L01
M04_L39:
       mov       rcx,rsi
       mov       r11,7FF922940C38
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M04_L16
M04_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L17
M04_L41:
       mov       rcx,rax
       call      qword ptr [7FF922F9EAC0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L17
M04_L42:
       mov       rcx,rax
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L17
M04_L43:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923036A90]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L17
M04_L44:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922940C40
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M04_L17
M04_L45:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,11DB5C00AF8
       mov       rbx,[rdx]
       jmp       near ptr M04_L17
M04_L46:
       mov       rdx,rbx
       mov       rcx,7FF923278598
       call      qword ptr [7FF9231CF228]
       jmp       near ptr M04_L18
M04_L47:
       jmp       near ptr M04_L34
M04_L48:
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
       jmp       near ptr M04_L19
M04_L49:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M04_L20
M04_L50:
       mov       r8,15E34AC0008
       jmp       near ptr M04_L23
M04_L51:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M04_L26
M04_L52:
       mov       r8,15E34AC0008
       jmp       near ptr M04_L26
M04_L53:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M04_L28
M04_L54:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M04_L28
M04_L55:
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
M04_L56:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M04_L57
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M04_L57
       jmp       short M04_L58
M04_L57:
       mov       rcx,rsi
       mov       rdx,7FF923265430
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L58:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M04_L59
       jmp       short M04_L60
M04_L59:
       mov       rdx,7FF923265470
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M04_L60:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M04_L09
M04_L61:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M04_L62
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M04_L62
       jmp       short M04_L63
M04_L62:
       mov       rcx,rbx
       mov       rdx,7FF923264898
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L63:
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
       jmp       qword ptr [7FF9231CF228]
M04_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2090
```
```assembly
; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M05_L00:
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
       mov       rdi,[rbx+30]
       mov       rbp,[rbx]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.String
       cmp       [rcx+8],rax
       jne       short M05_L01
       mov       rcx,11D9FC00A08
       cmp       rdi,[rcx]
       je        near ptr M05_L07
M05_L01:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M05_L06
M05_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+28]
       movzx     r14d,byte ptr [rbx+48]
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
       mov       rsi,[rbx+20]
       test      rsi,rsi
       je        near ptr M05_L05
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M05_L12
       mov       rdi,[rsi+30]
       mov       rcx,11D9FC00A08
       cmp       rdi,[rcx]
       je        near ptr M05_L10
M05_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,[rsi+28]
       movzx     r15d,byte ptr [rsi+48]
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
       cmp       qword ptr [rsi+20],0
       je        short M05_L04
       mov       rcx,[rsi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M05_L11
       mov       rdx,r14
       call      qword ptr [7FF922DD4740]
       mov       rbp,rax
M05_L04:
       mov       rax,rbp
M05_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L06:
       mov       rcx,rbp
       mov       rdx,7FF923264C88
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L07:
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
       call      qword ptr [7FF922D4DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M05_L08
       jmp       short M05_L09
M05_L08:
       mov       rcx,rbp
       mov       rdx,7FF923264CA0
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M05_L09:
       mov       rdx,rdi
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M05_L01
M05_L10:
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
       call      qword ptr [7FF922D4DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M05_L03
M05_L11:
       mov       rdx,r14
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M05_L04
M05_L12:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M05_L04
; Total bytes of code 570
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+20]
       mov       rcx,15E34AC0008
       test      rax,rax
       cmove     rax,rcx
       ret
; Total bytes of code 22
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M07_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M07_L02
       cmp       rdx,[r8]
       jne       short M07_L03
M07_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M07_L01:
       call      qword ptr [7FF9231CC138]
       int       3
M07_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M07_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M07_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229FD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M08_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rbp,[rsi+8]
       mov       r14,[rsi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdx,[rdx+48]
       test      rdx,rdx
       je        near ptr M08_L07
M08_L01:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rbp
       je        near ptr M08_L11
       mov       rcx,[r14+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M08_L08
M08_L02:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M08_L05
       test      rbx,rbx
       je        near ptr M08_L09
       test      rbp,rbp
       je        near ptr M08_L09
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rbp+18],rdx
       jne       near ptr M08_L09
       cmp       [rbx+8],r13d
       jl        near ptr M08_L09
M08_L03:
       mov       edx,r15d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M08_L15
M08_L04:
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M08_L03
M08_L05:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M08_L06:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       near ptr M08_L14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L07:
       mov       rdx,7FF923264D98
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L01
M08_L08:
       mov       rcx,r14
       mov       rdx,7FF923264DA8
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L09:
       cmp       r15d,[rbx+8]
       jae       near ptr M08_L21
       mov       edx,r15d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rbp+18],rcx
       jne       near ptr M08_L16
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M08_L17
M08_L10:
       mov       edx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M08_L09
       jmp       near ptr M08_L05
M08_L11:
       mov       rcx,[r14+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M08_L18
M08_L12:
       mov       rdx,rbx
       test      rdx,rdx
       je        short M08_L13
       cmp       [rdx],rcx
       jne       near ptr M08_L19
M08_L13:
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L14:
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       short M08_L20
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922DD66B8]
M08_L15:
       mov       r8,15E34AC0008
       jmp       near ptr M08_L04
M08_L16:
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
       mov       r8,rax
       jmp       near ptr M08_L10
M08_L17:
       mov       r8,15E34AC0008
       jmp       near ptr M08_L10
M08_L18:
       mov       rcx,r14
       mov       rdx,7FF923264DA8
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L12
M08_L19:
       mov       rdx,rbx
       call      qword ptr [7FF9229F58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M08_L13
M08_L20:
       mov       rdx,rbx
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+20]
M08_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 589
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M09_L05
       mov       rcx,[rbx]
       cmp       rcx,rsi
       je        near ptr M09_L04
       mov       rax,11D9FC00038
       mov       rax,[rax]
       add       rax,10
       rorx      rdx,rcx,20
       xor       rdx,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rdx,r8
       mov       r8d,[rax]
       shrx      rdx,rdx,r8
       xor       r8d,r8d
M09_L00:
       lea       r10d,[rdx+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rax+r10*8]
       mov       r9d,[r10]
       and       r9d,0FFFFFFFE
       cmp       [r10+8],rcx
       jne       short M09_L01
       mov       r11,rsi
       xor       r11,[r10+10]
       cmp       r11,1
       jbe       short M09_L03
M09_L01:
       test      r9d,r9d
       je        short M09_L02
       inc       r8d
       add       edx,r8d
       and       edx,[rax+4]
       cmp       r8d,8
       jl        short M09_L00
M09_L02:
       mov       rcx,7FF923234A8C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF9229F6340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M09_L03:
       cmp       r9d,[r10]
       jne       short M09_L02
       cmp       r11d,1
       jne       short M09_L02
       mov       rcx,7FF923234A80
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L05
M09_L04:
       mov       rcx,7FF923234A88
       call      CORINFO_HELP_COUNTPROFILE32
M09_L05:
       mov       rcx,7FF923234A84
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 246
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       mov       rcx,15E34AC0008
       test      rax,rax
       cmove     rax,rcx
       ret
; Total bytes of code 22
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
       call      qword ptr [7FF9231CD938]
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
       mov       rcx,7FF923233498
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M12_L02:
       mov       rcx,11D9FC00110
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M12_L05
       mov       rcx,11D9FC000F0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M12_L04
       mov       rcx,7FF9232334A0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M12_L01
M12_L03:
       mov       ecx,2
       call      qword ptr [7FF9231CD530]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M12_L00
M12_L04:
       mov       rcx,7FF92323349C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF923233498
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF922C15E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
M12_L05:
       mov       rcx,7FF9232334A4
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
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M14_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M14_L06
M14_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FF98246A630]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M14_L04
M14_L01:
       cmp       rdi,4000
       ja        short M14_L00
M14_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M14_L05
M14_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M14_L04:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       short M14_L01
M14_L05:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       short M14_L03
M14_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M14_L07
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
M14_L07:
       cmp       rdi,4000
       ja        short M14_L06
       jmp       short M14_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M15_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M15_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M15_L02
       test      r8b,18
       jne       short M15_L01
       test      r8b,4
       je        short M15_L00
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M15_L05
M15_L00:
       test      r8,r8
       je        short M15_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M15_L05
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M15_L05
M15_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M15_L05
M15_L02:
       cmp       r8,40
       ja        short M15_L06
M15_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M15_L09
M15_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M15_L05:
       vzeroupper
       ret
M15_L06:
       cmp       r8,800
       ja        near ptr M15_L12
       cmp       r8,100
       jae       short M15_L10
M15_L07:
       mov       r9,r8
       shr       r9,6
M15_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M15_L08
       and       r8,3F
       cmp       r8,10
       ja        short M15_L03
       jmp       short M15_L04
M15_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M15_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M15_L04
M15_L10:
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
       jmp       short M15_L07
M15_L11:
       cmp       rcx,rdx
       jne       short M15_L12
       cmp       [rdx],dl
       jmp       near ptr M15_L05
M15_L12:
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
       je        near ptr M16_L09
       test      rsi,rsi
       je        near ptr M16_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M16_L00
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
       jne       near ptr M16_L10
M16_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M16_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M16_L07
       sub       edi,eax
       js        near ptr M16_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M16_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M16_L06
       sub       ebp,eax
       js        near ptr M16_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M16_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M16_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98246A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M16_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M16_L16
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
M16_L01:
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
       jne       short M16_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246D930]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M16_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M16_L15
M16_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M16_L04:
       cmp       r8,4000
       jbe       short M16_L05
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
M16_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M16_L02
       jmp       near ptr M16_L14
M16_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M16_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M16_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M16_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M16_L10:
       call      qword ptr [7FF982463788]
       mov       rbx,rax
       call      qword ptr [7FF98246ED60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246D7C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M16_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF982481910]
       int       3
M16_L12:
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
M16_L13:
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
M16_L14:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M16_L02
M16_L15:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M16_L03
M16_L16:
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
       jne       short M17_L00
       ret
M17_L00:
       jmp       qword ptr [7FF9229F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark.OrderByWithComparer()
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
       mov       rcx,2754DC00A48
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
       mov       rdx,2754DC00A60
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
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovups   ymm0,[7FF923162560]
       vbroadcastss ymm1,dword ptr [7FF923162580]
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
       mov       rdx,2754DC00A40
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2754DC00A48
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
       mov       rcx,2754DC00B00
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
       mov       rdx,7FF923264718
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
       mov       rdx,7FF9232645B0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF9232646F8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF923264BD0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF923264C90
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF923264C98
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
       mov       rdx,2754DC00A60
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
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovups   ymm0,[7FF923160820]
       vbroadcastss ymm1,dword ptr [7FF923160840]
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
       call      qword ptr [7FF923036AF0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
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
       mov       rdx,2754DC00AF8
       mov       rbx,[rdx]
       jmp       near ptr M01_L17
M01_L45:
       mov       rdx,rbx
       mov       rcx,7FF9232781B0
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
       mov       rdx,7FF923264C70
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L53:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L54
       jmp       short M01_L55
M01_L54:
       mov       rdx,7FF923264CB0
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
       mov       rdx,7FF9232646C0
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
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark.OrderByWithoutComparer()
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
       mov       [rsp+58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,196FCC00A50
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L23
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rax,196E6C00068
       mov       r14,[rax]
       mov       r15,r14
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L25
       xor       ecx,ecx
       mov       [rbp+20],rcx
       lea       rcx,[rbp+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+48],0
       mov       rcx,196FCC00A58
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L01:
       mov       rcx,rbp
       mov       rdx,offset MT_System.Linq.IOrderedEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r8,7FF9232036F8
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       r8,r14
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r9d,r9d
       call      rax
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M00_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L42
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L35
       mov       esi,[rdi+8]
M00_L02:
       test      esi,esi
       je        near ptr M00_L41
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L40
       mov       ebp,[rdi+8]
       mov       rcx,[rdi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L39
       cmp       ebp,[rdi+8]
       ja        near ptr M00_L39
       cmp       ebp,[rsi+8]
       ja        near ptr M00_L39
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rdi+10]
       lea       rax,[rsi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L38
       cmp       r8,4000
       ja        near ptr M00_L37
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M00_L36
M00_L03:
       mov       [rsp+58],rsi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+58]
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
M00_L04:
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L34
       mov       rdx,[rdi+18]
       mov       rcx,7FF9231252B8
       call      qword ptr [7FF922D5C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       ebp,[rsi+8]
       cmp       ebp,1
       jle       near ptr M00_L26
       mov       edx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,196E6C00A08
       cmp       r12,[rcx]
       je        near ptr M00_L27
M00_L05:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+64],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+64]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       je        short M00_L07
       mov       rcx,[rdi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L28
       mov       rdx,r12
       call      qword ptr [7FF922DE4740]; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M00_L06:
       mov       rdi,rax
       mov       rax,rdi
M00_L07:
       mov       rdi,rax
       mov       r12d,ebp
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,196FCC00A60
       cmp       rax,[rdx]
       je        near ptr M00_L20
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M00_L11
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L11
M00_L08:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M00_L29
M00_L09:
       mov       [rsp+60],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+60]
       inc       r10d
       cmp       ebp,r10d
       jle       short M00_L13
       mov       rax,[rsp+38]
       jmp       short M00_L08
M00_L10:
       mov       rax,[rsp+38]
M00_L11:
       cmp       r10d,ebp
       jae       near ptr M00_L43
       mov       [rsp+60],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L30
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M00_L31
M00_L12:
       mov       edx,[rsp+60]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+60]
       inc       ecx
       cmp       ebp,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M00_L10
M00_L13:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M00_L14
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L32
       mov       rdx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF922DE66B8]; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M00_L14:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L16
       vmovups   ymm0,[7FF923172740]
       vbroadcastss ymm1,dword ptr [7FF923172760]
       lea       rcx,[rdx-20]
M00_L15:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L15
       vmovd     ecx,xmm0
M00_L16:
       cmp       r9,rdx
       jb        short M00_L21
       nop       dword ptr [rax]
M00_L17:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L19
       cmp       ebp,r13d
       jl        short M00_L22
       xor       r12d,r12d
       nop       dword ptr [rax+rax]
M00_L18:
       lea       rcx,[r15+r12*2]
       mov       eax,[rdi+r12+10]
       cmp       eax,ebp
       jae       near ptr M00_L43
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L18
M00_L19:
       mov       rsi,r14
       jmp       near ptr M00_L03
M00_L20:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M00_L21:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L21
       jmp       near ptr M00_L17
M00_L22:
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8]
       cmp       r12d,ebp
       jae       near ptr M00_L43
       mov       edx,r12d
       mov       eax,[rdi+rdx*4+10]
       cmp       eax,ebp
       jae       near ptr M00_L43
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L22
       jmp       short M00_L19
M00_L23:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,196FCC00A40
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,196FCC00A50
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,196FCC00A40
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,196FCC00A58
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L25:
       mov       ecx,11
       call      qword ptr [7FF922C27E58]
       int       3
M00_L26:
       mov       r14,rsi
       jmp       near ptr M00_L19
M00_L27:
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
       jmp       near ptr M00_L05
M00_L28:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L06
M00_L29:
       mov       r8,1D77BD40008
       jmp       near ptr M00_L09
M00_L30:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M00_L12
M00_L31:
       mov       r8,1D77BD40008
       jmp       near ptr M00_L12
M00_L32:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L14
M00_L33:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L14
M00_L34:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M00_L19
M00_L35:
       mov       rcx,rdi
       mov       r11,7FF922950C68
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L02
M00_L36:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L03
M00_L37:
       mov       rcx,rax
       call      qword ptr [7FF922FAEEC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L38:
       mov       rcx,rax
       call      qword ptr [7FF922A05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L39:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923046B08]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L03
M00_L40:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF922950C70
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,196FCC00AF8
       mov       rsi,[rdx]
       jmp       near ptr M00_L03
M00_L42:
       mov       rdx,rsi
       mov       rcx,7FF923288B58
       call      qword ptr [7FF9231DF240]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L43:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1871
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
       mov       r9,196E6C00A10
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M03_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M03_L01
       cmp       [r10],rcx
       je        short M03_L06
M03_L00:
       cmp       [r10+8],rcx
       je        short M03_L06
       cmp       [r10+10],rcx
       je        short M03_L06
       cmp       [r10+18],rcx
       je        short M03_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M03_L04
       test      r8,r8
       je        short M03_L03
M03_L01:
       cmp       [r10],rcx
       je        short M03_L06
M03_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M03_L03
       cmp       [r10],rcx
       je        short M03_L06
       jmp       short M03_L02
M03_L03:
       test      dword ptr [rax],500C0000
       je        short M03_L05
       jmp       qword ptr [7FF922D5F648]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M03_L04:
       cmp       [r10],rcx
       je        short M03_L06
       jmp       short M03_L00
M03_L05:
       xor       edx,edx
M03_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
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
       jle       short M04_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M04_L02
M04_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M04_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M04_L55
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M04_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rax],rcx
       jne       near ptr M04_L38
       mov       rcx,rax
       call      qword ptr [7FF922DE3340]; System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M04_L01:
       jmp       near ptr M04_L18
M04_L02:
       mov       rcx,rbx
       mov       rdx,7FF923274B00
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M04_L00
M04_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M04_L10
M04_L04:
       mov       rdx,rsi
       call      qword ptr [7FF922B7F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L61
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M04_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M04_L11
M04_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M04_L12
M04_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M04_L56
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M04_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M04_L13
M04_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M04_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M04_L14
M04_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M04_L09:
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
M04_L10:
       mov       rcx,rbx
       mov       rdx,7FF923274998
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
       nop       dword ptr [rax+rax]
M04_L11:
       mov       rcx,rbx
       mov       rdx,7FF923274AE0
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M04_L05
M04_L12:
       mov       rcx,rsi
       mov       rdx,7FF923275B80
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L06
M04_L13:
       mov       rcx,rsi
       mov       rdx,7FF923275C40
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L07
M04_L14:
       mov       rcx,rsi
       mov       rdx,7FF923275C48
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L08
M04_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF922B7F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M04_L46
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M04_L39
       mov       ebx,[rsi+8]
M04_L16:
       test      ebx,ebx
       je        near ptr M04_L45
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M04_L44
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M04_L43
       cmp       ebp,[rsi+8]
       ja        near ptr M04_L43
       cmp       ebp,[rbx+8]
       ja        near ptr M04_L43
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M04_L42
       cmp       r8,4000
       ja        near ptr M04_L41
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M04_L40
M04_L17:
       mov       rax,rbx
M04_L18:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M04_L47
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,196E6C00A08
       cmp       r12,[rcx]
       je        near ptr M04_L48
M04_L19:
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
       je        short M04_L21
       mov       rcx,[rdi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M04_L49
       mov       rdx,r12
       call      qword ptr [7FF922DE4740]; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M04_L20:
       mov       rdi,rax
       mov       rax,rdi
M04_L21:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M04_L54
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,196FCC00A60
       cmp       rax,[rdx]
       je        near ptr M04_L35
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M04_L25
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M04_L25
M04_L22:
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M04_L50
M04_L23:
       mov       [rsp+58],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+58]
       inc       r10d
       cmp       esi,r10d
       jle       short M04_L27
       mov       rax,[rsp+38]
       jmp       short M04_L22
M04_L24:
       mov       rax,[rsp+38]
M04_L25:
       cmp       r10d,esi
       jae       near ptr M04_L64
       mov       [rsp+58],r10d
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M04_L51
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M04_L52
M04_L26:
       mov       edx,[rsp+58]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+58]
       inc       ecx
       cmp       esi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M04_L24
M04_L27:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M04_L28
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M04_L53
       mov       rdx,rbx
       mov       r8d,r12d
       call      qword ptr [7FF922DE66B8]; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M04_L28:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M04_L30
       vmovups   ymm0,[7FF92316FD80]
       vbroadcastss ymm1,dword ptr [7FF92316FDA0]
       lea       rcx,[rdx-20]
M04_L29:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M04_L29
       vmovd     ecx,xmm0
M04_L30:
       cmp       r9,rdx
       jb        near ptr M04_L36
M04_L31:
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
       jle       short M04_L33
       cmp       esi,r13d
       jl        short M04_L37
       xor       ebp,ebp
M04_L32:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M04_L64
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M04_L32
M04_L33:
       mov       rax,r14
M04_L34:
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
M04_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M04_L36:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M04_L36
       jmp       near ptr M04_L31
M04_L37:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M04_L64
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M04_L64
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M04_L37
       jmp       short M04_L33
M04_L38:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M04_L01
M04_L39:
       mov       rcx,rsi
       mov       r11,7FF922950C48
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M04_L16
M04_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L17
M04_L41:
       mov       rcx,rax
       call      qword ptr [7FF922FAEEC8]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L17
M04_L42:
       mov       rcx,rax
       call      qword ptr [7FF922A05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L17
M04_L43:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923046B08]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L17
M04_L44:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922950C50
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M04_L17
M04_L45:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,196FCC00AF8
       mov       rbx,[rdx]
       jmp       near ptr M04_L17
M04_L46:
       mov       rdx,rbx
       mov       rcx,7FF923288B58
       call      qword ptr [7FF9231DF240]
       jmp       near ptr M04_L18
M04_L47:
       jmp       near ptr M04_L34
M04_L48:
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
       jmp       near ptr M04_L19
M04_L49:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M04_L20
M04_L50:
       mov       r8,1D77BD40008
       jmp       near ptr M04_L23
M04_L51:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M04_L26
M04_L52:
       mov       r8,1D77BD40008
       jmp       near ptr M04_L26
M04_L53:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M04_L28
M04_L54:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M04_L28
M04_L55:
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
M04_L56:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M04_L57
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M04_L57
       jmp       short M04_L58
M04_L57:
       mov       rcx,rsi
       mov       rdx,7FF923275C20
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L58:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M04_L59
       jmp       short M04_L60
M04_L59:
       mov       rdx,7FF923275C60
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M04_L60:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M04_L09
M04_L61:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M04_L62
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M04_L62
       jmp       short M04_L63
M04_L62:
       mov       rcx,rbx
       mov       rdx,7FF923274AA8
       call      qword ptr [7FF922C27B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L63:
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
       jmp       qword ptr [7FF9231DF240]
M04_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2090
```
```assembly
; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M05_L00:
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
       mov       rdi,[rbx+30]
       mov       rbp,[rbx]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.String
       cmp       [rcx+8],rax
       jne       short M05_L01
       mov       rcx,196E6C00A08
       cmp       rdi,[rcx]
       je        near ptr M05_L07
M05_L01:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M05_L06
M05_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+28]
       movzx     r14d,byte ptr [rbx+48]
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
       mov       rsi,[rbx+20]
       test      rsi,rsi
       je        near ptr M05_L05
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M05_L12
       mov       rdi,[rsi+30]
       mov       rcx,196E6C00A08
       cmp       rdi,[rcx]
       je        near ptr M05_L10
M05_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,[rsi+28]
       movzx     r15d,byte ptr [rsi+48]
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
       cmp       qword ptr [rsi+20],0
       je        short M05_L04
       mov       rcx,[rsi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M05_L11
       mov       rdx,r14
       call      qword ptr [7FF922DE4740]
       mov       rbp,rax
M05_L04:
       mov       rax,rbp
M05_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L06:
       mov       rcx,rbp
       mov       rdx,7FF923274E98
       call      qword ptr [7FF922A0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L07:
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
       call      qword ptr [7FF922D5DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M05_L08
       jmp       short M05_L09
M05_L08:
       mov       rcx,rbp
       mov       rdx,7FF923274EB0
       call      qword ptr [7FF922A0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M05_L09:
       mov       rdx,rdi
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M05_L01
M05_L10:
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
       call      qword ptr [7FF922D5DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M05_L03
M05_L11:
       mov       rdx,r14
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M05_L04
M05_L12:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M05_L04
; Total bytes of code 570
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+20]
       mov       rcx,1D77BD40008
       test      rax,rax
       cmove     rax,rcx
       ret
; Total bytes of code 22
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M07_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M07_L02
       cmp       rdx,[r8]
       jne       short M07_L03
M07_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M07_L01:
       call      qword ptr [7FF9231D7990]
       int       3
M07_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M07_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M07_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF922A0D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M08_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rbp,[rsi+8]
       mov       r14,[rsi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdx,[rdx+48]
       test      rdx,rdx
       je        near ptr M08_L07
M08_L01:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rbp
       je        near ptr M08_L11
       mov       rcx,[r14+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M08_L08
M08_L02:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M08_L05
       test      rbx,rbx
       je        near ptr M08_L09
       test      rbp,rbp
       je        near ptr M08_L09
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rbp+18],rdx
       jne       near ptr M08_L09
       cmp       [rbx+8],r13d
       jl        near ptr M08_L09
M08_L03:
       mov       edx,r15d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M08_L15
M08_L04:
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M08_L03
M08_L05:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M08_L06:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       near ptr M08_L14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L07:
       mov       rdx,7FF923274FA8
       call      qword ptr [7FF922A0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L01
M08_L08:
       mov       rcx,r14
       mov       rdx,7FF923274FB8
       call      qword ptr [7FF922A0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L09:
       cmp       r15d,[rbx+8]
       jae       near ptr M08_L21
       mov       edx,r15d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rbp+18],rcx
       jne       near ptr M08_L16
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M08_L17
M08_L10:
       mov       edx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M08_L09
       jmp       near ptr M08_L05
M08_L11:
       mov       rcx,[r14+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M08_L18
M08_L12:
       mov       rdx,rbx
       test      rdx,rdx
       je        short M08_L13
       cmp       [rdx],rcx
       jne       near ptr M08_L19
M08_L13:
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L14:
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       short M08_L20
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922DE66B8]
M08_L15:
       mov       r8,1D77BD40008
       jmp       near ptr M08_L04
M08_L16:
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
       mov       r8,rax
       jmp       near ptr M08_L10
M08_L17:
       mov       r8,1D77BD40008
       jmp       near ptr M08_L10
M08_L18:
       mov       rcx,r14
       mov       rdx,7FF923274FB8
       call      qword ptr [7FF922A0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L12
M08_L19:
       mov       rdx,rbx
       call      qword ptr [7FF922A058D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M08_L13
M08_L20:
       mov       rdx,rbx
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+20]
M08_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 589
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M09_L05
       mov       rcx,[rbx]
       cmp       rcx,rsi
       je        near ptr M09_L04
       mov       rax,196E6C00038
       mov       rax,[rax]
       add       rax,10
       rorx      rdx,rcx,20
       xor       rdx,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rdx,r8
       mov       r8d,[rax]
       shrx      rdx,rdx,r8
       xor       r8d,r8d
M09_L00:
       lea       r10d,[rdx+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rax+r10*8]
       mov       r9d,[r10]
       and       r9d,0FFFFFFFE
       cmp       [r10+8],rcx
       jne       short M09_L01
       mov       r11,rsi
       xor       r11,[r10+10]
       cmp       r11,1
       jbe       short M09_L03
M09_L01:
       test      r9d,r9d
       je        short M09_L02
       inc       r8d
       add       edx,r8d
       and       edx,[rax+4]
       cmp       r8d,8
       jl        short M09_L00
M09_L02:
       mov       rcx,7FF923244E2C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF922A06340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M09_L03:
       cmp       r9d,[r10]
       jne       short M09_L02
       cmp       r11d,1
       jne       short M09_L02
       mov       rcx,7FF923244E20
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L05
M09_L04:
       mov       rcx,7FF923244E28
       call      CORINFO_HELP_COUNTPROFILE32
M09_L05:
       mov       rcx,7FF923244E24
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 246
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       mov       rcx,1D77BD40008
       test      rax,rax
       cmove     rax,rcx
       ret
; Total bytes of code 22
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
       call      qword ptr [7FF9231DD938]
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
       mov       rcx,7FF923243800
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M12_L02:
       mov       rcx,196E6C00110
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M12_L05
       mov       rcx,196E6C000F0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M12_L04
       mov       rcx,7FF923243808
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M12_L01
M12_L03:
       mov       ecx,2
       call      qword ptr [7FF9231DD530]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M12_L00
M12_L04:
       mov       rcx,7FF923243804
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF923243800
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF922C25E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
M12_L05:
       mov       rcx,7FF92324380C
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
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M14_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M14_L06
M14_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FF98246A630]
       add       rbx,4000
       add       rsi,4000
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M14_L04
M14_L01:
       cmp       rdi,4000
       ja        short M14_L00
M14_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       short M14_L05
M14_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M14_L04:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       short M14_L01
M14_L05:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       short M14_L03
M14_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M14_L07
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
M14_L07:
       cmp       rdi,4000
       ja        short M14_L06
       jmp       short M14_L02
; Total bytes of code 199
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M15_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M15_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M15_L02
       test      r8b,18
       jne       short M15_L01
       test      r8b,4
       je        short M15_L00
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M15_L05
M15_L00:
       test      r8,r8
       je        short M15_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M15_L05
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M15_L05
M15_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M15_L05
M15_L02:
       cmp       r8,40
       ja        short M15_L06
M15_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M15_L09
M15_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M15_L05:
       vzeroupper
       ret
M15_L06:
       cmp       r8,800
       ja        near ptr M15_L12
       cmp       r8,100
       jae       short M15_L10
M15_L07:
       mov       r9,r8
       shr       r9,6
M15_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M15_L08
       and       r8,3F
       cmp       r8,10
       ja        short M15_L03
       jmp       short M15_L04
M15_L09:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M15_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M15_L04
M15_L10:
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
       jmp       short M15_L07
M15_L11:
       cmp       rcx,rdx
       jne       short M15_L12
       cmp       [rdx],dl
       jmp       near ptr M15_L05
M15_L12:
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
       je        near ptr M16_L09
       test      rsi,rsi
       je        near ptr M16_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M16_L00
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
       jne       near ptr M16_L10
M16_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M16_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M16_L07
       sub       edi,eax
       js        near ptr M16_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M16_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M16_L06
       sub       ebp,eax
       js        near ptr M16_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M16_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M16_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98246A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M16_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M16_L16
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
M16_L01:
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
       jne       short M16_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246D930]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M16_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M16_L15
M16_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M16_L04:
       cmp       r8,4000
       jbe       short M16_L05
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
M16_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M16_L02
       jmp       near ptr M16_L14
M16_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M16_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M16_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M16_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M16_L10:
       call      qword ptr [7FF982463788]
       mov       rbx,rax
       call      qword ptr [7FF98246ED60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246D7C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M16_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF982481910]
       int       3
M16_L12:
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
M16_L13:
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
M16_L14:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M16_L02
M16_L15:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M16_L03
M16_L16:
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
       jne       short M17_L00
       ret
M17_L00:
       jmp       qword ptr [7FF922A05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark.OrderByWithComparer()
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
       mov       rcx,1F2FA400A80
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
       mov       rcx,7FF9231C6010
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
       mov       rdx,1F2FA400A98
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
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovups   ymm0,[7FF9231999E0]
       vbroadcastss ymm1,dword ptr [7FF923199A00]
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
       mov       rdx,1F2FA400A78
       mov       rdx,[rdx]
       mov       rcx,rbp
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F2FA400A80
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
       mov       rcx,1F2FA400B60
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
       call      qword ptr [7FF922DD3340]; Precode of System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L18
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF92327B008
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
       mov       rdx,7FF92327AEA0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF92327AFE8
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF92327B7D0
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF92327B890
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF92327B898
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,1F2FA400A98
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
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovups   ymm0,[7FF923199340]
       vbroadcastss ymm1,dword ptr [7FF923199360]
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
       mov       r11,7FF922940E10
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L39:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L17
M01_L40:
       mov       rcx,rax
       call      qword ptr [7FF922F9EFD0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF923036A90]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L17
M01_L43:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922940E18
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1F2FA400B58
       mov       rbx,[rdx]
       jmp       near ptr M01_L17
M01_L45:
       mov       rdx,rbx
       mov       rcx,7FF92329D8B8
       call      qword ptr [7FF9231EFF60]
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
       mov       rdx,7FF92327B870
       call      qword ptr [7FF922C17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L53:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L54
       jmp       short M01_L55
M01_L54:
       mov       rdx,7FF92322B778
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
       mov       rdx,7FF92327AFB0
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
       jmp       qword ptr [7FF9231EFF60]
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1907
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF9230E4BD0]
       int       3
M03_L04:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229FD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       call      qword ptr [7FF9230EECB8]
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
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark.OrderByWithoutComparer()
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
       mov       [rsp+58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2F0]
       mov       rcx,2B3FFC02A58
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L23
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rax,2B3FFC00068
       mov       r14,[rax]
       mov       r15,r14
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L25
       xor       ecx,ecx
       mov       [rbp+20],rcx
       lea       rcx,[rbp+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+48],0
       mov       rcx,2B3FFC02A60
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L01:
       mov       rcx,rbp
       mov       rdx,offset MT_System.Linq.IOrderedEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r8,7FF92322F290
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       r8,r14
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r9d,r9d
       call      rax
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M00_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L42
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L35
       mov       esi,[rdi+8]
M00_L02:
       test      esi,esi
       je        near ptr M00_L41
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L40
       mov       ebp,[rdi+8]
       mov       rcx,[rdi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M00_L39
       cmp       ebp,[rdi+8]
       ja        near ptr M00_L39
       cmp       ebp,[rsi+8]
       ja        near ptr M00_L39
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rdi+10]
       lea       rax,[rsi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M00_L38
       cmp       r8,4000
       ja        near ptr M00_L37
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M00_L36
M00_L03:
       mov       [rsp+58],rsi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+58]
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
M00_L04:
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L34
       mov       rdx,[rdi+18]
       mov       rcx,7FF9231E1550
       call      qword ptr [7FF922D6C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       ebp,[rsi+8]
       cmp       ebp,1
       jle       near ptr M00_L26
       mov       edx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,2B3FFC00A08
       cmp       r12,[rcx]
       je        near ptr M00_L27
M00_L05:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
       mov       [rsp+64],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+50]
       mov       ecx,[rsp+64]
       mov       [r12+28],cl
       xor       ecx,ecx
       mov       [r12+18],rcx
       mov       rax,r12
       cmp       qword ptr [rdi+20],0
       je        short M00_L07
       mov       rcx,[rdi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L28
       mov       rdx,r12
       call      qword ptr [7FF922DF4740]; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M00_L06:
       mov       rdi,rax
       mov       rax,rdi
M00_L07:
       mov       rdi,rax
       mov       r12d,ebp
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L33
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,2B3FFC02A68
       cmp       rax,[rdx]
       je        near ptr M00_L22
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M00_L11
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L11
M00_L08:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M00_L29
M00_L09:
       mov       [rsp+60],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+60]
       inc       r10d
       cmp       ebp,r10d
       jle       short M00_L13
       mov       rax,[rsp+38]
       jmp       short M00_L08
M00_L10:
       mov       rax,[rsp+38]
M00_L11:
       cmp       r10d,ebp
       jae       near ptr M00_L43
       mov       [rsp+60],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L30
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M00_L31
M00_L12:
       mov       edx,[rsp+60]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+60]
       inc       ecx
       cmp       ebp,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M00_L10
M00_L13:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M00_L14
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L32
       mov       rdx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF922DF66B8]; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M00_L14:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L16
       vmovups   ymm0,[7FF9231A80A0]
       vbroadcastss ymm1,dword ptr [7FF9231A80C0]
       lea       rcx,[rdx-20]
M00_L15:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L15
       vmovd     ecx,xmm0
M00_L16:
       cmp       r9,rdx
       jb        short M00_L20
M00_L17:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+48]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L19
       cmp       ebp,r13d
       jl        short M00_L21
       xor       r12d,r12d
M00_L18:
       lea       rcx,[r15+r12*2]
       mov       eax,[rdi+r12+10]
       cmp       eax,ebp
       jae       near ptr M00_L43
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L18
M00_L19:
       mov       rsi,r14
       jmp       near ptr M00_L03
M00_L20:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L20
       jmp       short M00_L17
M00_L21:
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8]
       cmp       r12d,ebp
       jae       near ptr M00_L43
       mov       edx,r12d
       mov       eax,[rdi+rdx*4+10]
       cmp       eax,ebp
       jae       near ptr M00_L43
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L21
       jmp       short M00_L19
M00_L22:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF922A158D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M00_L23:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2B3FFC02A48
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF922A16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2B3FFC02A58
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2B3FFC02A48
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF922A16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2B3FFC02A60
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L25:
       mov       ecx,11
       call      qword ptr [7FF922C37E58]
       int       3
M00_L26:
       mov       r14,rsi
       jmp       near ptr M00_L19
M00_L27:
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
       jmp       near ptr M00_L05
M00_L28:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L06
M00_L29:
       mov       r8,2F494C70008
       jmp       near ptr M00_L09
M00_L30:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M00_L12
M00_L31:
       mov       r8,2F494C70008
       jmp       near ptr M00_L12
M00_L32:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L14
M00_L33:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L14
M00_L34:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M00_L19
M00_L35:
       mov       rcx,rdi
       mov       r11,7FF922960E58
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L02
M00_L36:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L03
M00_L37:
       mov       rcx,rax
       call      qword ptr [7FF922FBF360]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L38:
       mov       rcx,rax
       call      qword ptr [7FF922A15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
M00_L39:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923046AA8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M00_L03
M00_L40:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF922960E60
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2B3FFC02B50
       mov       rsi,[rdx]
       jmp       near ptr M00_L03
M00_L42:
       mov       rdx,rsi
       mov       rcx,7FF9232BC838
       call      qword ptr [7FF9231FFEE8]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L43:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1859
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
       mov       r9,2B3FFC00A10
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
       jmp       qword ptr [7FF922B8FFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
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
       je        short M02_L03
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
M02_L03:
       xor       edx,edx
       jmp       short M02_L00
; Total bytes of code 88
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L00
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M03_L06
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M03_L04
       cmp       [r10],rcx
       jne       short M03_L01
M03_L00:
       mov       rax,rdx
       ret
M03_L01:
       cmp       [r10+8],rcx
       je        short M03_L00
       jmp       short M03_L03
M03_L02:
       cmp       [r10],rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L03:
       cmp       [r10+10],rcx
       je        short M03_L00
       cmp       [r10+18],rcx
       je        short M03_L00
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M03_L02
       test      r8,r8
       je        short M03_L06
M03_L04:
       cmp       [r10],rcx
       je        short M03_L00
M03_L05:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M03_L06
       cmp       [r10],rcx
       je        short M03_L00
       jmp       short M03_L05
M03_L06:
       test      dword ptr [rax],500C0000
       jne       short M03_L07
       xor       edx,edx
       jmp       short M03_L00
M03_L07:
       jmp       qword ptr [7FF922D6F648]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 125
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
       jle       short M04_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M04_L02
M04_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M04_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M04_L55
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M04_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rax],rcx
       jne       near ptr M04_L38
       mov       rcx,rax
       call      qword ptr [7FF922DF3340]; Precode of System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M04_L01:
       jmp       near ptr M04_L18
M04_L02:
       mov       rcx,rbx
       mov       rdx,7FF9232A9C30
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M04_L00
M04_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M04_L10
M04_L04:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M04_L61
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M04_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M04_L11
M04_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M04_L12
M04_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M04_L56
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M04_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M04_L13
M04_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M04_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M04_L14
M04_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M04_L09:
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
M04_L10:
       mov       rcx,rbx
       mov       rdx,7FF9232A9AC8
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L04
       nop       word ptr [rax+rax]
M04_L11:
       mov       rcx,rbx
       mov       rdx,7FF9232A9C10
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M04_L05
M04_L12:
       mov       rcx,rsi
       mov       rdx,7FF9232AAC68
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L06
M04_L13:
       mov       rcx,rsi
       mov       rdx,7FF9232AAD28
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M04_L07
M04_L14:
       mov       rcx,rsi
       mov       rdx,7FF9232AAD30
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M04_L08
M04_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M04_L46
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M04_L39
       mov       ebx,[rsi+8]
M04_L16:
       test      ebx,ebx
       je        near ptr M04_L45
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M04_L44
       mov       ebp,[rsi+8]
       mov       rcx,[rsi]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M04_L43
       cmp       ebp,[rsi+8]
       ja        near ptr M04_L43
       cmp       ebp,[rbx+8]
       ja        near ptr M04_L43
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rbx+10]
       test      dword ptr [rcx],1000000
       je        near ptr M04_L42
       cmp       r8,4000
       ja        near ptr M04_L41
       mov       rcx,rax
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M04_L40
M04_L17:
       mov       rax,rbx
M04_L18:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M04_L47
       mov       ebp,esi
       mov       rdx,rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,2B3FFC00A08
       cmp       r12,[rcx]
       je        near ptr M04_L48
M04_L19:
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
       je        short M04_L21
       mov       rcx,[rdi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M04_L49
       mov       rdx,r12
       call      qword ptr [7FF922DF4740]; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M04_L20:
       mov       rdi,rax
       mov       rax,rdi
M04_L21:
       mov       rdi,rax
       mov       r12d,esi
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M04_L54
       mov       rax,[rdi+8]
       mov       [rsp+40],rax
       mov       rdx,2B3FFC02A68
       cmp       rax,[rdx]
       je        near ptr M04_L37
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+38],rax
       xor       r10d,r10d
       mov       r9,[rsp+40]
       test      r9,r9
       je        short M04_L25
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M04_L25
M04_L22:
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M04_L50
M04_L23:
       mov       [rsp+58],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+58]
       inc       r10d
       cmp       esi,r10d
       jle       short M04_L27
       mov       rax,[rsp+38]
       jmp       short M04_L22
M04_L24:
       mov       rax,[rsp+38]
M04_L25:
       cmp       r10d,esi
       jae       near ptr M04_L64
       mov       [rsp+58],r10d
       mov       edx,r10d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M04_L51
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M04_L52
M04_L26:
       mov       edx,[rsp+58]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+58]
       inc       ecx
       cmp       esi,ecx
       mov       r10d,ecx
       mov       r9,[rsp+40]
       jg        short M04_L24
M04_L27:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M04_L28
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M04_L53
       mov       rdx,rbx
       mov       r8d,r12d
       call      qword ptr [7FF922DF66B8]; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M04_L28:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+48],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       lea       rdx,[r9+rbp*4]
       cmp       r12d,8
       jl        short M04_L30
       vmovups   ymm0,[7FF9231A7100]
       vbroadcastss ymm1,dword ptr [7FF9231A7120]
       lea       rcx,[rdx-20]
M04_L29:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M04_L29
       vmovd     ecx,xmm0
M04_L30:
       cmp       r9,rdx
       jb        short M04_L35
M04_L31:
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
       jle       short M04_L33
       cmp       esi,r13d
       jl        short M04_L36
       xor       ebp,ebp
M04_L32:
       lea       rcx,[r15+rbp*2]
       mov       r12d,[rdi+rbp+10]
       cmp       r12d,esi
       jae       near ptr M04_L64
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbp,4
       dec       r13d
       jne       short M04_L32
M04_L33:
       mov       rax,r14
M04_L34:
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
M04_L35:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M04_L35
       jmp       short M04_L31
M04_L36:
       mov       ecx,ebp
       lea       rcx,[r15+rcx*8]
       cmp       ebp,esi
       jae       near ptr M04_L64
       mov       edx,ebp
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M04_L64
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       ebp
       cmp       ebp,r13d
       jl        short M04_L36
       jmp       short M04_L33
M04_L37:
       mov       rdx,rbx
       mov       rcx,offset MT_System.String[]
       call      qword ptr [7FF922A158D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M04_L38:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M04_L01
M04_L39:
       mov       rcx,rsi
       mov       r11,7FF922960E48
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M04_L16
M04_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L17
M04_L41:
       mov       rcx,rax
       call      qword ptr [7FF922FBF360]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L17
M04_L42:
       mov       rcx,rax
       call      qword ptr [7FF922A15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L17
M04_L43:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923046AA8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L17
M04_L44:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922960E50
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M04_L17
M04_L45:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2B3FFC02B50
       mov       rbx,[rdx]
       jmp       near ptr M04_L17
M04_L46:
       mov       rdx,rbx
       mov       rcx,7FF9232BC838
       call      qword ptr [7FF9231FFEE8]
       jmp       near ptr M04_L18
M04_L47:
       jmp       near ptr M04_L34
M04_L48:
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
       jmp       near ptr M04_L19
M04_L49:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M04_L20
M04_L50:
       mov       r8,2F494C70008
       jmp       near ptr M04_L23
M04_L51:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+38]
       jmp       near ptr M04_L26
M04_L52:
       mov       r8,2F494C70008
       jmp       near ptr M04_L26
M04_L53:
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M04_L28
M04_L54:
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M04_L28
M04_L55:
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
M04_L56:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M04_L57
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M04_L57
       jmp       short M04_L58
M04_L57:
       mov       rcx,rsi
       mov       rdx,7FF9232AAD08
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L58:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M04_L59
       jmp       short M04_L60
M04_L59:
       mov       rdx,7FF92323B840
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M04_L60:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M04_L09
M04_L61:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M04_L62
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M04_L62
       jmp       short M04_L63
M04_L62:
       mov       rcx,rbx
       mov       rdx,7FF9232A9BD8
       call      qword ptr [7FF922C37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L63:
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
       jmp       qword ptr [7FF9231FFEE8]
M04_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2083
```
```assembly
; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M05_L00:
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
       mov       rdi,[rbx+30]
       mov       rbp,[rbx]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.String
       cmp       [rcx+8],rax
       jne       short M05_L01
       mov       rcx,2B3FFC00A08
       cmp       rdi,[rcx]
       je        near ptr M05_L07
M05_L01:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M05_L06
M05_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+28]
       movzx     r14d,byte ptr [rbx+48]
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
       mov       rsi,[rbx+20]
       test      rsi,rsi
       je        near ptr M05_L05
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M05_L12
       mov       rdi,[rsi+30]
       mov       rcx,2B3FFC00A08
       cmp       rdi,[rcx]
       je        near ptr M05_L10
M05_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,[rsi+28]
       movzx     r15d,byte ptr [rsi+48]
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
       cmp       qword ptr [rsi+20],0
       je        short M05_L04
       mov       rcx,[rsi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M05_L11
       mov       rdx,r14
       call      qword ptr [7FF922DF4740]
       mov       rbp,rax
M05_L04:
       mov       rax,rbp
M05_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L06:
       mov       rcx,rbp
       mov       rdx,7FF9232A9FB0
       call      qword ptr [7FF922A1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M05_L02
M05_L07:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF922C35DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF922D6DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M05_L08
       jmp       short M05_L09
M05_L08:
       mov       rcx,rbp
       mov       rdx,7FF9232A9FC8
       call      qword ptr [7FF922A1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M05_L09:
       mov       rdx,rdi
       call      qword ptr [7FF922A158D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M05_L01
M05_L10:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF922C35DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF922D6DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M05_L03
M05_L11:
       mov       rdx,r14
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M05_L04
M05_L12:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M05_L04
; Total bytes of code 570
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+20]
       mov       rcx,2F494C70008
       test      rax,rax
       cmove     rax,rcx
       ret
; Total bytes of code 22
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M07_L03
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M07_L02
       cmp       rdx,[r8]
       jne       short M07_L01
M07_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M07_L01:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M07_L00
       jmp       short M07_L04
M07_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M07_L03:
       call      qword ptr [7FF923104BB8]
       int       3
M07_L04:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF922A1D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 96
```
```assembly
; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M08_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rbp,[rsi+8]
       mov       r14,[rsi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdx,[rdx+48]
       test      rdx,rdx
       je        near ptr M08_L07
M08_L01:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rbp
       je        near ptr M08_L11
       mov       rcx,[r14+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M08_L08
M08_L02:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M08_L05
       test      rbx,rbx
       je        near ptr M08_L09
       test      rbp,rbp
       je        near ptr M08_L09
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rbp+18],rdx
       jne       near ptr M08_L09
       cmp       [rbx+8],r13d
       jl        near ptr M08_L09
M08_L03:
       mov       edx,r15d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M08_L15
M08_L04:
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M08_L03
M08_L05:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M08_L06:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       near ptr M08_L14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L07:
       mov       rdx,7FF9232AA0C0
       call      qword ptr [7FF922A1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L01
M08_L08:
       mov       rcx,r14
       mov       rdx,7FF9232AA0D0
       call      qword ptr [7FF922A1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L09:
       cmp       r15d,[rbx+8]
       jae       near ptr M08_L21
       mov       edx,r15d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rbp+18],rcx
       jne       near ptr M08_L16
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M08_L17
M08_L10:
       mov       edx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M08_L09
       jmp       near ptr M08_L05
M08_L11:
       mov       rcx,[r14+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M08_L18
M08_L12:
       mov       rdx,rbx
       test      rdx,rdx
       je        short M08_L13
       cmp       [rdx],rcx
       jne       near ptr M08_L19
M08_L13:
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L06
M08_L14:
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       short M08_L20
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922DF66B8]
M08_L15:
       mov       r8,2F494C70008
       jmp       near ptr M08_L04
M08_L16:
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
       mov       r8,rax
       jmp       near ptr M08_L10
M08_L17:
       mov       r8,2F494C70008
       jmp       near ptr M08_L10
M08_L18:
       mov       rcx,r14
       mov       rdx,7FF9232AA0D0
       call      qword ptr [7FF922A1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L12
M08_L19:
       mov       rdx,rbx
       call      qword ptr [7FF922A158D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M08_L13
M08_L20:
       mov       rdx,rbx
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+20]
M08_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 589
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M09_L05
       mov       rcx,[rbx]
       cmp       rcx,rsi
       je        near ptr M09_L04
       mov       rax,2B3FFC00038
       mov       rax,[rax]
       add       rax,10
       rorx      rdx,rcx,20
       xor       rdx,rsi
       mov       r8,9E3779B97F4A7C15
       imul      rdx,r8
       mov       r8d,[rax]
       shrx      rdx,rdx,r8
       xor       r8d,r8d
M09_L00:
       lea       r10d,[rdx+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rax+r10*8]
       mov       r9d,[r10]
       and       r9d,0FFFFFFFE
       cmp       [r10+8],rcx
       jne       short M09_L01
       mov       r11,rsi
       xor       r11,[r10+10]
       cmp       r11,1
       jbe       short M09_L03
M09_L01:
       test      r9d,r9d
       je        short M09_L02
       inc       r8d
       add       edx,r8d
       and       edx,[rax+4]
       cmp       r8d,8
       jl        short M09_L00
M09_L02:
       mov       rcx,7FF92324483C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF922A16340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
M09_L03:
       cmp       r9d,[r10]
       jne       short M09_L02
       cmp       r11d,1
       jne       short M09_L02
       mov       rcx,7FF923244830
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L05
M09_L04:
       mov       rcx,7FF923244838
       call      CORINFO_HELP_COUNTPROFILE32
M09_L05:
       mov       rcx,7FF923244834
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 246
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       mov       rcx,2F494C70008
       test      rax,rax
       cmove     rax,rcx
       ret
; Total bytes of code 22
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
       call      qword ptr [7FF9231FD950]
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
       mov       rcx,7FF9232431D8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M12_L02:
       mov       rcx,2B3FFC00110
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M12_L05
       mov       rcx,2B3FFC000F0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        short M12_L04
       mov       rcx,7FF9232431E0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M12_L01
M12_L03:
       mov       ecx,2
       call      qword ptr [7FF9231FD548]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M12_L00
M12_L04:
       mov       rcx,7FF9232431DC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF9232431D8
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF922C35E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
M12_L05:
       mov       rcx,7FF9232431E4
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
; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M14_L03
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M14_L06
M14_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      00007FF9826037E0
       add       rbx,4000
       add       rsi,4000
       cmp       dword ptr [7FF982943A90],0
       jne       short M14_L04
M14_L01:
       cmp       rdi,4000
       ja        short M14_L00
M14_L02:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M14_L05
M14_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M14_L04:
       call      CORINFO_HELP_POLL_GC
       jmp       short M14_L01
M14_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M14_L03
M14_L06:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       je        short M14_L07
       call      CORINFO_HELP_POLL_GC
M14_L07:
       cmp       rdi,4000
       ja        short M14_L06
       jmp       short M14_L02
; Total bytes of code 184
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M15_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M15_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M15_L03
       test      r8b,18
       je        short M15_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M15_L00:
       vzeroupper
       ret
M15_L01:
       test      r8b,4
       jne       short M15_L02
       test      r8,r8
       je        short M15_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M15_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M15_L00
M15_L02:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M15_L00
M15_L03:
       cmp       r8,40
       ja        short M15_L07
M15_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M15_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M15_L06
M15_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M15_L00
M15_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M15_L05
M15_L07:
       cmp       r8,800
       ja        short M15_L11
       cmp       r8,100
       jb        short M15_L08
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
M15_L08:
       mov       r9,r8
       shr       r9,6
M15_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M15_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M15_L04
       jmp       near ptr M15_L05
M15_L10:
       cmp       rcx,rdx
       jne       short M15_L11
       cmp       [rdx],dl
       jmp       near ptr M15_L00
M15_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF922A166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       je        near ptr M16_L09
       test      rsi,rsi
       je        near ptr M16_L08
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M16_L00
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
       jne       near ptr M16_L10
M16_L00:
       mov       r14d,[rsp+70]
       test      r14d,r14d
       jl        near ptr M16_L11
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       edi,eax
       jl        near ptr M16_L07
       sub       edi,eax
       js        near ptr M16_L12
       lea       ecx,[rdi+r14]
       cmp       ecx,[rbx+8]
       ja        near ptr M16_L12
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF98246A390]; Precode of System.Array.GetLowerBound(Int32)
       cmp       ebp,eax
       jl        near ptr M16_L06
       sub       ebp,eax
       js        near ptr M16_L13
       lea       ecx,[r14+rbp]
       cmp       ecx,[rsi+8]
       ja        near ptr M16_L13
       mov       rcx,[rbx]
       cmp       rcx,[rsi]
       je        short M16_L01
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF98246A2B0]; Precode of System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       je        short M16_L01
       cmp       byte ptr [rsp+78],0
       jne       near ptr M16_L16
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
M16_L01:
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
       jne       short M16_L04
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246D930]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M16_L02:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M16_L15
M16_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M16_L04:
       cmp       r8,4000
       jbe       short M16_L05
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
M16_L05:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FF98246A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M16_L02
       jmp       near ptr M16_L14
M16_L06:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,ebp
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M16_L07:
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       ecx,edi
       mov       edx,eax
       call      qword ptr [7FF982481928]
       int       3
M16_L08:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M16_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FF98246C210]
       int       3
M16_L10:
       call      qword ptr [7FF982463788]
       mov       rbx,rax
       call      qword ptr [7FF98246ED60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF98246D7C0]
       mov       rcx,rbx
       call      qword ptr [7FF982458FC0]; CORINFO_HELP_THROW
       int       3
M16_L11:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,r14d
       call      qword ptr [7FF982481910]
       int       3
M16_L12:
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
M16_L13:
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
M16_L14:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M16_L02
M16_L15:
       call      qword ptr [7FF982459040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M16_L03
M16_L16:
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
       jne       short M17_L00
       ret
M17_L00:
       jmp       qword ptr [7FF922A15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark.OrderByWithComparer()
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
       mov       rcx,202A1002AE8
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
       test      byte ptr [7FF923347C08],1
       je        near ptr M00_L22
M00_L01:
       mov       rcx,202A1002B60
       mov       rdx,[rcx]
M00_L02:
       lea       rcx,[r14+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+48],0
       mov       rdx,[r14+18]
       mov       rcx,7FF923238B78
       call      qword ptr [7FF922D5C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       mov       rdx,202A1002B00
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
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovups   ymm0,[7FF9232C3C40]
       vbroadcastss ymm1,dword ptr [7FF9232C3C60]
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
       call      qword ptr [7FF922C27E58]
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
       mov       rdx,202A1002AE0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF922A06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,202A1002AE8
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
       call      qword ptr [7FF922DE3340]; Precode of System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L01:
       jmp       near ptr M01_L18
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FF9233352C8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF923335160
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,7FF9233352A8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF923335AC0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF923335B80
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rdx,7FF923335B88
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,202A1002B00
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
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovups   ymm0,[7FF9232C35A0]
       vbroadcastss ymm1,dword ptr [7FF9232C35C0]
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
       mov       r11,7FF922950FB8
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L16
M01_L39:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L17
M01_L40:
       mov       rcx,rax
       call      qword ptr [7FF923016A00]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L41:
       mov       rcx,rax
       call      qword ptr [7FF922A05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L17
M01_L42:
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       r8,rbx
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF923016220]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L17
M01_L43:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922950FC0
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L44:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,202A1002B58
       mov       rbx,[rdx]
       jmp       near ptr M01_L17
M01_L45:
       mov       rdx,rbx
       mov       rcx,7FF9233478A8
       call      qword ptr [7FF9233541B0]
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
       mov       rdx,7FF923335B60
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L53:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L54
       jmp       short M01_L55
M01_L54:
       mov       rdx,7FF923119F50
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rdx,7FF923335270
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       jmp       qword ptr [7FF9233541B0]
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1882
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithComparer>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       call      qword ptr [7FF9230D4BB8]
       int       3
M03_L03:
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
       call      qword ptr [7FF9230D6298]
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
       jmp       qword ptr [7FF922A05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.13 (10.0.13, 10.0.1326.50504), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark.OrderByWithoutComparer()
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
       mov       rcx,1EDDF800AF8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L32
M00_L00:
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rax,1EDC9800068
       mov       r14,[rax]
       mov       r15,r14
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L34
       xor       ecx,ecx
       mov       [rbp+20],rcx
       lea       rcx,[rbp+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       lea       rcx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+48],0
       mov       rcx,1EDDF800B00
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L33
M00_L01:
       mov       rcx,rbp
       mov       rdx,offset MT_System.Linq.IOrderedEnumerable<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r8,7FF923279070
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       r8,r14
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r9d,r9d
       call      rax
       mov       rsi,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M00_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L53
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       esi,[rdi+8]
M00_L02:
       test      esi,esi
       je        near ptr M00_L52
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L51
       mov       ebp,[rdi+8]
       mov       r14,[rdi]
       cmp       dword ptr [r14+4],18
       jne       short M00_L03
       cmp       ebp,[rdi+8]
       ja        short M00_L03
       cmp       ebp,[rsi+8]
       jbe       near ptr M00_L11
M00_L03:
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M00_L07
       xor       r14d,r14d
M00_L04:
       test      r14d,r14d
       jg        near ptr M00_L45
       mov       ecx,r14d
       neg       ecx
       js        near ptr M00_L46
       lea       edx,[rcx+rbp]
       cmp       edx,[rdi+8]
       ja        near ptr M00_L46
       mov       rdx,[rsi]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       jne       near ptr M00_L08
       xor       r14d,r14d
M00_L05:
       test      r14d,r14d
       jg        near ptr M00_L47
       mov       edx,r14d
       neg       edx
       js        near ptr M00_L48
       lea       r8d,[rdx+rbp]
       cmp       r8d,[rsi+8]
       ja        near ptr M00_L48
       mov       r8,[rdi]
       movzx     eax,word ptr [r8]
       mov       r10d,ebp
       imul      r10,rax
       mov       ecx,ecx
       imul      rcx,rax
       lea       r9,[rdi+rcx+10]
       mov       ecx,edx
       imul      rcx,rax
       lea       rcx,[rsi+rcx+10]
       test      dword ptr [r8],1000000
       je        short M00_L09
       cmp       r10,4000
       ja        near ptr M00_L50
       mov       rdx,r9
       mov       r8,r10
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M00_L49
M00_L06:
       mov       [rsp+48],rsi
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
M00_L07:
       movsxd    rcx,ecx
       mov       r14d,[rdi+rcx*4+10]
       jmp       near ptr M00_L04
M00_L08:
       movsxd    rdx,edx
       mov       r14d,[rsi+rdx*4+10]
       jmp       near ptr M00_L05
M00_L09:
       cmp       r10,40
       je        short M00_L10
       mov       rdx,r9
       mov       r8,r10
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L06
M00_L10:
       vmovdqu   ymm0,ymmword ptr [r9]
       vmovdqu   ymm1,ymmword ptr [r9+20]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm1
       jmp       short M00_L06
M00_L11:
       mov       r8d,ebp
       movzx     ecx,word ptr [r14]
       imul      r8,rcx
       lea       rdx,[rdi+10]
       lea       rcx,[rsi+10]
       test      dword ptr [r14],1000000
       jne       short M00_L12
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L06
       nop       dword ptr [rax+rax]
M00_L12:
       call      qword ptr [7FF9229F57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L06
M00_L13:
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L43
       mov       rdx,[rdi+18]
       mov       rcx,7FF92322C320
       call      qword ptr [7FF922D4C7F8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       ebp,[rsi+8]
       cmp       ebp,1
       jle       near ptr M00_L35
       mov       edx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       r15,[r14+10]
       mov       r13d,[r14+8]
       mov       r12,[rdi+30]
       mov       rcx,1EDC9800A08
       cmp       r12,[rcx]
       je        near ptr M00_L36
M00_L14:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rdx,[rdi+28]
       movzx     r8d,byte ptr [rdi+48]
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
       cmp       qword ptr [rdi+20],0
       je        short M00_L16
       mov       rcx,[rdi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L37
       mov       rdx,r12
       call      qword ptr [7FF922DD4740]; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M00_L15:
       mov       rdi,rax
       mov       rax,rdi
M00_L16:
       mov       rdi,rax
       mov       r12d,ebp
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M00_L42
       mov       rax,[rdi+8]
       mov       [rsp+30],rax
       mov       rdx,1EDDF800B08
       cmp       rax,[rdx]
       je        near ptr M00_L31
       mov       edx,r12d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       r9,[rsp+30]
       test      r9,r9
       je        short M00_L20
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rdx
       jne       short M00_L20
M00_L17:
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       r8,[rdx+30]
       test      r8,r8
       je        near ptr M00_L38
M00_L18:
       mov       [rsp+50],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       r10d,[rsp+50]
       inc       r10d
       cmp       ebp,r10d
       jle       short M00_L22
       mov       rax,[rsp+28]
       jmp       short M00_L17
M00_L19:
       mov       rax,[rsp+28]
M00_L20:
       cmp       r10d,ebp
       jae       near ptr M00_L54
       mov       [rsp+50],r10d
       mov       edx,r10d
       mov       rdx,[rsi+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r9+18],rcx
       jne       near ptr M00_L39
       mov       r8,[rdx+30]
       test      r8,r8
       je        near ptr M00_L40
M00_L21:
       mov       edx,[rsp+50]
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rsp+50]
       inc       ecx
       cmp       ebp,ecx
       mov       r10d,ecx
       mov       r9,[rsp+30]
       jg        short M00_L19
M00_L22:
       lea       rcx,[rdi+20]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M00_L23
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M00_L41
       mov       rdx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF922DD66B8]; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M00_L23:
       mov       edx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+38],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,r12d
       lea       rdx,[r9+rdx*4]
       cmp       r12d,8
       jl        short M00_L25
       vmovups   ymm0,[7FF9232B55E0]
       vbroadcastss ymm1,dword ptr [7FF9232B5600]
       lea       rcx,[rdx-20]
M00_L24:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M00_L24
       vmovd     ecx,xmm0
M00_L25:
       cmp       r9,rdx
       jae       short M00_L27
M00_L26:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M00_L26
M00_L27:
       lea       r9d,[r12-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+38]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L29
       cmp       ebp,r13d
       jl        short M00_L30
       xor       r12d,r12d
       nop       dword ptr [rax]
M00_L28:
       lea       rcx,[r15+r12*2]
       mov       eax,[rdi+r12+10]
       cmp       eax,ebp
       jae       near ptr M00_L54
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,4
       dec       r13d
       jne       short M00_L28
M00_L29:
       mov       rsi,r14
       jmp       near ptr M00_L06
M00_L30:
       mov       ecx,r12d
       lea       rcx,[r15+rcx*8]
       cmp       r12d,ebp
       jae       near ptr M00_L54
       mov       edx,r12d
       mov       eax,[rdi+rdx*4+10]
       cmp       eax,ebp
       jae       near ptr M00_L54
       mov       edx,eax
       mov       rdx,[rsi+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L30
       jmp       short M00_L29
M00_L31:
       mov       rdx,rsi
       mov       rcx,offset MT_System.String[]
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       int       3
M00_L32:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1EDDF800AE8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1EDDF800AF8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L33:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1EDDF800AE8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9229F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1EDDF800B00
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L34:
       mov       ecx,11
       call      qword ptr [7FF922C17E58]
       int       3
M00_L35:
       mov       r14,rsi
       jmp       near ptr M00_L29
M00_L36:
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
       jmp       near ptr M00_L14
M00_L37:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L15
M00_L38:
       mov       r8,22E5E9A0008
       jmp       near ptr M00_L18
M00_L39:
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rsp+28]
       jmp       near ptr M00_L21
M00_L40:
       mov       r8,22E5E9A0008
       jmp       near ptr M00_L21
M00_L41:
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L23
M00_L42:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,r12d
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M00_L23
M00_L43:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M00_L29
M00_L44:
       mov       rcx,rdi
       mov       r11,7FF922940FB8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M00_L02
M00_L45:
       mov       ecx,167
       mov       rdx,7FF922934000
       call      qword ptr [7FF922C17798]
       mov       r8,rax
       mov       edx,r14d
       xor       ecx,ecx
       call      qword ptr [7FF9230E7990]
       int       3
M00_L46:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9230E7A20]
       mov       rsi,rax
       mov       ecx,12D
       mov       rdx,7FF922934000
       call      qword ptr [7FF922C17798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF922D47FA8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L47:
       mov       ecx,17F
       mov       rdx,7FF922934000
       call      qword ptr [7FF922C17798]
       mov       r8,rax
       mov       edx,r14d
       xor       ecx,ecx
       call      qword ptr [7FF9230E7990]
       int       3
M00_L48:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF9230E7A38]
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
M00_L49:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L06
M00_L50:
       mov       rdx,r9
       mov       r8,r10
       call      qword ptr [7FF922F9EAC0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L06
M00_L51:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FF922940FC0
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L06
M00_L52:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1EDDF800B60
       mov       rsi,[rdx]
       jmp       near ptr M00_L06
M00_L53:
       mov       rdx,rsi
       mov       rcx,7FF92332B4C8
       call      qword ptr [7FF923334330]
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2275
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
       mov       r9,1EDC9800A10
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L00
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M03_L06
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M03_L04
       cmp       [r10],rcx
       jne       short M03_L01
M03_L00:
       mov       rax,rdx
       ret
M03_L01:
       cmp       [r10+8],rcx
       je        short M03_L00
       jmp       short M03_L03
M03_L02:
       cmp       [r10],rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L03:
       cmp       [r10+10],rcx
       je        short M03_L00
       cmp       [r10+18],rcx
       je        short M03_L00
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M03_L02
       test      r8,r8
       je        short M03_L06
M03_L04:
       cmp       [r10],rcx
       je        short M03_L00
M03_L05:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M03_L06
       cmp       [r10],rcx
       je        short M03_L00
       jmp       short M03_L05
M03_L06:
       test      dword ptr [rax],500C0000
       jne       short M03_L07
       xor       edx,edx
       jmp       short M03_L00
M03_L07:
       jmp       qword ptr [7FF922D4F648]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 125
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
       ja        short M04_L03
       test      r8b,18
       jne       short M04_L02
       test      r8b,4
       je        short M04_L01
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M04_L00:
       vzeroupper
       ret
M04_L01:
       test      r8,r8
       je        short M04_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M04_L00
M04_L02:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M04_L00
M04_L03:
       cmp       r8,40
       ja        short M04_L07
M04_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M04_L06
M04_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M04_L00
M04_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M04_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L05
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
       ja        near ptr M04_L04
       jmp       near ptr M04_L05
M04_L10:
       cmp       rcx,rdx
       jne       short M04_L11
       cmp       [rdx],dl
       jmp       near ptr M04_L00
M04_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF9229F66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M05_L02
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       short M05_L01
M05_L00:
       add       rsp,28
       ret
M05_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L00
M05_L02:
       add       rsp,28
       jmp       qword ptr [7FF922F9EAC0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 49
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
       jle       short M06_L02
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M06_L02
M06_L00:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M06_L03
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rdi],rdx
       jne       near ptr M06_L54
       mov       rbx,[rdi+18]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M06_L15
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rax],rcx
       jne       near ptr M06_L39
       mov       rcx,rax
       call      qword ptr [7FF922DD3340]; Precode of System.Linq.Enumerable+OrderedIterator`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M06_L01:
       jmp       near ptr M06_L21
M06_L02:
       mov       rcx,rbx
       mov       rdx,7FF923342A98
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L00
M06_L03:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M06_L10
M06_L04:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M06_L60
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M06_L11
       mov       rsi,[rcx+38]
       test      rsi,rsi
       je        near ptr M06_L11
M06_L05:
       mov       rcx,[rsi+18]
       mov       r11,[rcx+28]
       test      r11,r11
       je        near ptr M06_L12
M06_L06:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       je        near ptr M06_L55
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],38
       jle       near ptr M06_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M06_L13
M06_L07:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],40
       jle       near ptr M06_L14
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M06_L14
M06_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [r11]
M06_L09:
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
M06_L10:
       mov       rcx,rbx
       mov       rdx,7FF923342930
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M06_L04
M06_L11:
       mov       rcx,rbx
       mov       rdx,7FF923342A78
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M06_L05
M06_L12:
       mov       rcx,rsi
       mov       rdx,7FF923343B20
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M06_L06
M06_L13:
       mov       rcx,rsi
       mov       rdx,7FF923343BE0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M06_L07
M06_L14:
       mov       rcx,rsi
       mov       rdx,7FF923343BE8
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M06_L08
M06_L15:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M06_L49
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M06_L40
       mov       ebx,[rsi+8]
M06_L16:
       test      ebx,ebx
       je        near ptr M06_L48
       movsxd    rdx,ebx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rsi],rcx
       jne       near ptr M06_L47
       mov       ebp,[rsi+8]
       mov       r14,[rsi]
       cmp       dword ptr [r14+4],18
       jne       short M06_L17
       cmp       ebp,[rsi+8]
       ja        short M06_L17
       cmp       ebp,[rbx+8]
       jbe       near ptr M06_L37
M06_L17:
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M06_L33
       xor       r14d,r14d
M06_L18:
       test      r14d,r14d
       jg        near ptr M06_L41
       mov       ecx,r14d
       neg       ecx
       js        near ptr M06_L42
       lea       edx,[rcx+rbp]
       cmp       edx,[rsi+8]
       ja        near ptr M06_L42
       mov       rdx,[rbx]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       jne       near ptr M06_L34
       xor       r14d,r14d
M06_L19:
       test      r14d,r14d
       jg        near ptr M06_L43
       mov       edx,r14d
       neg       edx
       js        near ptr M06_L44
       lea       r8d,[rdx+rbp]
       cmp       r8d,[rbx+8]
       ja        near ptr M06_L44
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
       je        near ptr M06_L35
       cmp       r10,4000
       ja        near ptr M06_L46
       mov       rdx,r9
       mov       r8,r10
       call      00007FF9826037E0
       cmp       dword ptr [7FF982943A90],0
       jne       near ptr M06_L45
M06_L20:
       mov       rax,rbx
M06_L21:
       mov       rbx,rax
       mov       esi,[rbx+8]
       cmp       esi,1
       jle       near ptr M06_L50
       mov       edx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,[rdi+30]
       mov       rcx,1EDC9800A08
       cmp       r13,[rcx]
       je        near ptr M06_L51
M06_L22:
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
       je        short M06_L23
       mov       rcx,[rdi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M06_L52
       mov       rdx,r12
       call      qword ptr [7FF922DD4740]; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
       mov       r13,rax
M06_L23:
       mov       edi,esi
       mov       r12,[r13]
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       r12,rcx
       jne       near ptr M06_L53
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FF922DD66B8]; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M06_L24:
       mov       edx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+20],rax
       lea       r9,[rax+10]
       xor       ecx,ecx
       mov       edx,edi
       lea       rdx,[r9+rdx*4]
       cmp       edi,8
       jl        short M06_L26
       vmovups   ymm0,[7FF9232B43E0]
       vbroadcastss ymm1,dword ptr [7FF9232B4400]
       lea       rcx,[rdx-20]
M06_L25:
       vmovups   [r9],ymm0
       vpaddd    ymm0,ymm0,ymm1
       add       r9,20
       cmp       r9,rcx
       jbe       short M06_L25
       vmovd     ecx,xmm0
M06_L26:
       cmp       r9,rdx
       jae       short M06_L28
M06_L27:
       lea       r8d,[rcx+1]
       mov       [r9],ecx
       add       r9,4
       cmp       r9,rdx
       mov       ecx,r8d
       jb        short M06_L27
M06_L28:
       lea       r9d,[rdi-1]
       mov       rcx,r13
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r12+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+20]
       xor       r13d,r13d
       test      r15d,r15d
       jle       short M06_L30
       cmp       esi,r15d
       jl        short M06_L32
       xor       r13d,r13d
M06_L29:
       lea       rcx,[r14+r13*2]
       mov       r12d,[rdi+r13+10]
       cmp       r12d,esi
       jae       near ptr M06_L63
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r13,4
       dec       r15d
       jne       short M06_L29
M06_L30:
       mov       rax,rbp
M06_L31:
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
M06_L32:
       mov       ecx,r13d
       lea       rcx,[r14+rcx*8]
       cmp       r13d,esi
       jae       near ptr M06_L63
       mov       edx,r13d
       mov       r12d,[rdi+rdx*4+10]
       cmp       r12d,esi
       jae       near ptr M06_L63
       mov       edx,r12d
       mov       rdx,[rbx+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       cmp       r13d,r15d
       jl        short M06_L32
       jmp       short M06_L30
M06_L33:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       near ptr M06_L18
M06_L34:
       movsxd    rdx,edx
       mov       r14d,[rbx+rdx*4+10]
       jmp       near ptr M06_L19
M06_L35:
       cmp       r10,40
       je        short M06_L36
       mov       rdx,r9
       mov       r8,r10
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L20
M06_L36:
       vmovdqu   ymm0,ymmword ptr [r9]
       vmovdqu   ymm1,ymmword ptr [r9+20]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm1
       jmp       near ptr M06_L20
M06_L37:
       mov       r8d,ebp
       movzx     ecx,word ptr [r14]
       imul      r8,rcx
       lea       rdx,[rsi+10]
       lea       rcx,[rbx+10]
       test      dword ptr [r14],1000000
       jne       short M06_L38
       call      qword ptr [7FF9229F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L20
M06_L38:
       call      qword ptr [7FF9229F57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L20
M06_L39:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M06_L01
M06_L40:
       mov       rcx,rsi
       mov       r11,7FF922940FA8
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M06_L16
M06_L41:
       mov       ecx,167
       mov       rdx,7FF922934000
       call      qword ptr [7FF922C17798]
       mov       r8,rax
       mov       edx,r14d
       xor       ecx,ecx
       call      qword ptr [7FF9230E7990]
       int       3
M06_L42:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9230E7A20]
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
M06_L43:
       mov       ecx,17F
       mov       rdx,7FF922934000
       call      qword ptr [7FF922C17798]
       mov       r8,rax
       mov       edx,r14d
       xor       ecx,ecx
       call      qword ptr [7FF9230E7990]
       int       3
M06_L44:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF9230E7A38]
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
M06_L45:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L20
M06_L46:
       mov       rdx,r9
       mov       r8,r10
       call      qword ptr [7FF922F9EAC0]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L20
M06_L47:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF922940FB0
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M06_L20
M06_L48:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1EDDF800B60
       mov       rbx,[rdx]
       jmp       near ptr M06_L20
M06_L49:
       mov       rdx,rbx
       mov       rcx,7FF92332B4C8
       call      qword ptr [7FF923334330]
       jmp       near ptr M06_L21
M06_L50:
       jmp       near ptr M06_L31
M06_L51:
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
       call      qword ptr [7FF922D4DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M06_L22
M06_L52:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M06_L23
M06_L53:
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8d,edi
       mov       rax,[r12+40]
       call      qword ptr [rax+20]
       jmp       near ptr M06_L24
M06_L54:
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
M06_L55:
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],30
       jle       short M06_L56
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M06_L56
       jmp       short M06_L57
M06_L56:
       mov       rcx,rsi
       mov       rdx,7FF923343BC0
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M06_L57:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M06_L58
       jmp       short M06_L59
M06_L58:
       mov       rdx,7FF923107D88
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M06_L59:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax]
       jmp       near ptr M06_L09
M06_L60:
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M06_L61
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M06_L61
       jmp       short M06_L62
M06_L61:
       mov       rcx,rbx
       mov       rdx,7FF923342A40
       call      System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M06_L62:
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
       jmp       qword ptr [7FF923334330]
M06_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2111
```
```assembly
; System.Linq.Enumerable+OrderedIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerableSorter(EnumerableSorter`1<System.__Canon>)
M07_L00:
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
       mov       rdi,[rbx+30]
       mov       rbp,[rbx]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.String
       cmp       [rcx+8],rax
       jne       short M07_L01
       mov       rcx,1EDC9800A08
       cmp       rdi,[rcx]
       je        near ptr M07_L07
M07_L01:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        near ptr M07_L06
M07_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+28]
       movzx     r14d,byte ptr [rbx+48]
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
       mov       rsi,[rbx+20]
       test      rsi,rsi
       je        near ptr M07_L05
       mov       rcx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rsi],rcx
       jne       near ptr M07_L12
       mov       rdi,[rsi+30]
       mov       rcx,1EDC9800A08
       cmp       rdi,[rcx]
       je        near ptr M07_L10
M07_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,[rsi+28]
       movzx     r15d,byte ptr [rsi+48]
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
       cmp       qword ptr [rsi+20],0
       je        short M07_L04
       mov       rcx,[rsi+20]
       mov       rdx,offset MT_System.Linq.Enumerable+OrderedIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       near ptr M07_L11
       mov       rdx,r14
       call      qword ptr [7FF922DD4740]
       mov       rbp,rax
M07_L04:
       mov       rax,rbp
M07_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L06:
       mov       rcx,rbp
       mov       rdx,7FF923342E18
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M07_L02
M07_L07:
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
       call      qword ptr [7FF922D4DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       mov       rcx,[rbp+30]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M07_L08
       jmp       short M07_L09
M07_L08:
       mov       rcx,rbp
       mov       rdx,7FF923342E30
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M07_L09:
       mov       rdx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M07_L01
M07_L10:
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
       call      qword ptr [7FF922D4DDA0]; System.CultureAwareComparer..ctor(System.Globalization.CompareInfo, System.Globalization.CompareOptions)
       jmp       near ptr M07_L03
M07_L11:
       mov       rdx,r14
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M07_L04
M07_L12:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M07_L04
; Total bytes of code 569
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+30]
       mov       rcx,22E5E9A0008
       test      rax,rax
       cmove     rax,rcx
       ret
; Total bytes of code 22
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M09_L02
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M09_L01
       cmp       rdx,[r8]
       je        short M09_L00
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       jne       short M09_L03
M09_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF982683F50
M09_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M09_L02:
       call      qword ptr [7FF9230E4B88]
       int       3
M09_L03:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9229FD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Linq.Enumerable+EnumerableSorter`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ComputeKeys(System.__Canon[], Int32)
M10_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rbp,[rsi+8]
       mov       r14,[rsi]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdx,[rdx+48]
       test      rdx,rdx
       je        near ptr M10_L07
M10_L01:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       [rax],rbp
       je        near ptr M10_L11
       mov       rcx,[r14+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        near ptr M10_L08
M10_L02:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jle       short M10_L05
       test      rbx,rbx
       je        near ptr M10_L09
       test      rbp,rbp
       je        near ptr M10_L09
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rbp+18],rdx
       jne       near ptr M10_L09
       cmp       [rbx+8],r13d
       jl        near ptr M10_L09
M10_L03:
       mov       edx,r15d
       mov       rdx,[rbx+rdx*8+10]
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M10_L15
M10_L04:
       movsxd    rdx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M10_L03
M10_L05:
       lea       rcx,[rsi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M10_L06:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       near ptr M10_L14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M10_L07:
       mov       rdx,7FF923342F28
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M10_L01
M10_L08:
       mov       rcx,r14
       mov       rdx,7FF923342F38
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M10_L02
M10_L09:
       cmp       r15d,[rbx+8]
       jae       near ptr M10_L21
       mov       edx,r15d
       mov       rdx,[rbx+rdx*8+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [rbp+18],rcx
       jne       near ptr M10_L16
       mov       r8,[rdx+20]
       test      r8,r8
       je        near ptr M10_L17
M10_L10:
       mov       edx,r15d
       mov       rcx,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r15d
       cmp       r13d,r15d
       jg        short M10_L09
       jmp       near ptr M10_L05
M10_L11:
       mov       rcx,[r14+30]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M10_L18
M10_L12:
       mov       rdx,rbx
       test      rdx,rdx
       je        short M10_L13
       cmp       [rdx],rcx
       jne       near ptr M10_L19
M10_L13:
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M10_L06
M10_L14:
       mov       rdx,offset MT_System.Linq.Enumerable+EnumerableSorter<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.String>
       cmp       [rcx],rdx
       jne       short M10_L20
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF922DD66B8]
M10_L15:
       mov       r8,22E5E9A0008
       jmp       near ptr M10_L04
M10_L16:
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
       mov       r8,rax
       jmp       near ptr M10_L10
M10_L17:
       mov       r8,22E5E9A0008
       jmp       near ptr M10_L10
M10_L18:
       mov       rcx,r14
       mov       rdx,7FF923342F38
       call      qword ptr [7FF9229FC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M10_L12
M10_L19:
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M10_L13
M10_L20:
       mov       rdx,rbx
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax+20]
M10_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 588
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M11_L00
       mov       rax,[rdx]
       cmp       rax,rcx
       jne       short M11_L01
M11_L00:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M11_L01:
       mov       r8,1EDC9800038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M11_L02:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       and       ebx,0FFFFFFFE
       cmp       [r11+8],rax
       jne       short M11_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       jbe       short M11_L04
M11_L03:
       test      ebx,ebx
       je        short M11_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M11_L02
       jmp       short M11_L05
M11_L04:
       cmp       ebx,[r11]
       jne       short M11_L05
       cmp       esi,1
       je        near ptr M11_L00
M11_L05:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF9229F6340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
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
       je        short M12_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
       call      qword ptr [7FF9230E6850]
       int       3
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.Comparers.PersonComparerByLastNameThenFirstNameBenchmark+<>c.<OrderByWithoutComparer>b__3_1(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       mov       rax,[rdx+20]
       mov       rcx,22E5E9A0008
       test      rax,rax
       cmove     rax,rcx
       ret
; Total bytes of code 22
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       short M14_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M14_L02
M14_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M14_L01
       mov       rax,1EDC9800110
       mov       rax,[rax]
       test      rax,rax
       jne       short M14_L01
       mov       rax,1EDC98000F0
       mov       rax,[rax]
       test      rax,rax
       je        short M14_L03
M14_L01:
       add       rsp,28
       ret
M14_L02:
       mov       ecx,2
       call      qword ptr [7FF9230E6448]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M14_L00
M14_L03:
       add       rsp,28
       jmp       qword ptr [7FF922C15E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       jne       short M15_L00
       mov       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M15_L00:
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M17_L00
       ret
M17_L00:
       jmp       qword ptr [7FF9229F5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

