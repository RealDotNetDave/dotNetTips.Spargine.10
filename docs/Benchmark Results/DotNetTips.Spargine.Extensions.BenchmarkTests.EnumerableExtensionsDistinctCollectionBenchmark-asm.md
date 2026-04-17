## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsDistinctCollectionBenchmark.DistinctFastDistinctReadOnlyCollectionRef()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<AddLast>d__43<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+38],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+3C],eax
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1D7E3001F50
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       call      qword ptr [7FFA073193D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<AddLast>d__43`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
       mov       [rbp-70],rax
       test      rax,rax
       je        near ptr M00_L03
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       cmp       [rax],rcx
       jne       near ptr M00_L03
M00_L00:
       mov       rcx,rax
       call      qword ptr [7FFA06D32C40]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L07
       mov       rcx,[rbp-70]
       mov       r11,7FFA068E1A00
       call      qword ptr [r11]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edi,[rsi+10]
       cmp       [rcx+8],edi
       jbe       short M00_L01
       lea       edx,[rdi+1]
       mov       [rsi+10],edx
       mov       edx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rax,[rbp-70]
       jmp       short M00_L00
M00_L01:
       mov       rcx,rsi
       mov       rdx,rax
       call      qword ptr [7FFA06B0E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-70]
       jmp       short M00_L00
M00_L02:
       mov       rcx,[rbp-70]
       mov       r11,7FFA068E1A00
       call      qword ptr [r11]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edi,[rsi+10]
       cmp       [rcx+8],edi
       jbe       short M00_L06
       lea       edx,[rdi+1]
       mov       [rsi+10],edx
       mov       edx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rax,[rbp-70]
M00_L03:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       cmp       [rax],rcx
       jne       short M00_L05
       mov       rcx,rax
       call      qword ptr [7FFA06D32C40]; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L04:
       test      eax,eax
       jne       short M00_L02
       jmp       short M00_L07
M00_L05:
       mov       rcx,rax
       mov       r11,7FFA068E19F8
       call      qword ptr [r11]
       jmp       short M00_L04
       nop
M00_L06:
       mov       rcx,rsi
       mov       rdx,rax
       call      qword ptr [7FFA06B0E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-70]
       jmp       short M00_L03
M00_L07:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       mov       rax,[rbp-70]
       cmp       [rax],rcx
       jne       near ptr M00_L62
       cmp       qword ptr [rax+28],0
       je        short M00_L09
       mov       rcx,[rax+28]
       mov       rdx,offset MT_System.Linq.Enumerable+IListSelectIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       cmp       [rcx],rdx
       jne       near ptr M00_L61
       call      qword ptr [7FFA06FA6E68]; System.Linq.Enumerable+IListSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Dispose()
M00_L08:
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+28],rcx
M00_L09:
       xor       ecx,ecx
       mov       [rax+8],rcx
       mov       dword ptr [rax+14],0FFFFFFFF
M00_L10:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       mov       r11,7FFA068E1A30
       call      qword ptr [r11]
       cmp       eax,800
       jle       near ptr M00_L63
       mov       rsi,offset MT_System.Linq.Enumerable+DistinctIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+20],rcx
M00_L11:
       mov       rax,offset MT_System.Linq.Enumerable+DistinctIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdi,rax
       cmp       [rsi],rdi
       jne       near ptr M00_L64
       cmp       dword ptr [rsi+14],0
       jne       short M00_L12
       mov       r14d,[rsi+10]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r14d,eax
       jne       short M00_L12
       jmp       short M00_L13
M00_L12:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15,[rsi+18]
       mov       rsi,[rsi+20]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,r14
M00_L13:
       mov       dword ptr [rsi+14],1
M00_L14:
       mov       [rbp-78],rsi
M00_L15:
       mov       rcx,[rbp-78]
       cmp       [rcx],rdi
       jne       near ptr M00_L56
       mov       rsi,rcx
       mov       edx,[rsi+14]
       cmp       edx,1
       je        near ptr M00_L37
       cmp       edx,2
       jne       near ptr M00_L40
M00_L16:
       mov       rax,[rsi+30]
       mov       rdx,[rax]
       mov       r8,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rdx,r8
       jne       near ptr M00_L54
       lea       rcx,[rax+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA06BB44E0]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L17:
       test      eax,eax
       je        near ptr M00_L40
       mov       rcx,[rsi+30]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L45
       mov       r14,[rcx+10]
M00_L18:
       mov       r15,[rsi+28]
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L46
M00_L19:
       mov       r13,[r15+10]
       mov       r12,[r15+18]
       xor       eax,eax
       mov       [rbp-4C],eax
       test      r14,r14
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r12],rcx
       jne       near ptr M00_L52
       mov       rdx,[r14+28]
       test      rdx,rdx
       je        near ptr M00_L47
       mov       rcx,1D7E3000068
       mov       rcx,[rcx]
       mov       r8,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],r8
       jne       near ptr M00_L51
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       dword ptr [rbp-60],0A587434D
       mov       dword ptr [rbp-68],0D96F0126
       cmp       edx,8
       jb        near ptr M00_L32
       mov       r8d,edx
       shr       r8d,3
M00_L20:
       mov       r10d,[rbp-60]
       add       r10d,[rcx]
       mov       [rbp-60],r10d
       mov       r10d,[rcx+4]
       mov       r9d,[rbp-60]
       mov       r11d,[rbp-68]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       mov       [rbp-60],r9d
       mov       [rbp-68],r11d
       add       r10d,[rbp-60]
       mov       [rbp-60],r10d
       mov       r10d,[rbp-60]
       mov       r9d,[rbp-68]
       xor       r9d,r10d
       rol       r10d,14
       add       r10d,r9d
       rol       r9d,9
       xor       r9d,r10d
       rol       r10d,1B
       add       r10d,r9d
       rol       r9d,13
       mov       [rbp-60],r10d
       mov       [rbp-68],r9d
       add       rcx,8
       dec       r8d
       jne       short M00_L20
       test      dl,4
       jne       near ptr M00_L33
M00_L21:
       mov       r8d,edx
       and       r8,7
       mov       ecx,[rcx+r8-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L22:
       add       ecx,[rbp-60]
       mov       [rbp-60],ecx
       mov       ecx,[rbp-60]
       mov       edx,[rbp-68]
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       mov       [rbp-60],ecx
       mov       [rbp-68],edx
       lea       rcx,[rbp-60]
       lea       rdx,[rbp-68]
       call      qword ptr [7FFA07307198]; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rbp-68]
       xor       eax,[rbp-60]
M00_L23:
       mov       [rbp-50],eax
       mov       rdx,[r15+8]
       mov       ecx,eax
       imul      rcx,[r15+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L58
       mov       ecx,ecx
       lea       r10,[rdx+rcx*4+10]
       mov       [rbp-88],r10
       mov       r9d,[r10]
       dec       r9d
       js        short M00_L26
M00_L24:
       cmp       r9d,[r13+8]
       jae       near ptr M00_L58
       mov       edx,r9d
       shl       rdx,4
       lea       r9,[r13+rdx+10]
       mov       [rbp-90],r9
       cmp       [r9+8],eax
       je        near ptr M00_L53
M00_L25:
       mov       r9d,[r9+0C]
       mov       ecx,[rbp-4C]
       inc       ecx
       mov       [rbp-4C],ecx
       cmp       [r13+8],ecx
       jb        near ptr M00_L57
       test      r9d,r9d
       mov       eax,[rbp-50]
       jge       short M00_L24
M00_L26:
       cmp       dword ptr [r15+30],0
       jg        near ptr M00_L36
       mov       edx,[r15+28]
       mov       [rbp-54],edx
       cmp       [r13+8],edx
       je        near ptr M00_L35
M00_L27:
       mov       edx,[rbp-54]
       mov       r13d,edx
       lea       edx,[r13+1]
       mov       [r15+28],edx
       mov       rdx,[r15+10]
       mov       r8,rdx
M00_L28:
       cmp       r13d,[r8+8]
       jae       near ptr M00_L58
       mov       edx,r13d
       shl       rdx,4
       mov       [rbp-80],r8
       lea       r9,[r8+rdx+10]
       mov       [r9+8],eax
       mov       r10,[rbp-88]
       mov       edx,[r10]
       dec       edx
       mov       [r9+0C],edx
       mov       rcx,r9
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r13d
       mov       rdx,[rbp-88]
       mov       [rdx],r13d
       inc       dword ptr [r15+34]
       cmp       dword ptr [rbp-4C],64
       ja        near ptr M00_L55
M00_L29:
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L30:
       mov       rcx,[rbp-78]
       mov       rsi,[rcx+8]
M00_L31:
       mov       [rbp-40],rsi
       mov       rsi,[rbx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       jmp       near ptr M00_L15
M00_L32:
       cmp       edx,4
       jb        near ptr M00_L48
M00_L33:
       mov       r8d,[rbp-60]
       add       r8d,[rcx]
       mov       [rbp-60],r8d
       mov       r8d,[rbp-60]
       mov       r10d,[rbp-68]
       xor       r10d,r8d
       rol       r8d,14
       add       r8d,r10d
       rol       r10d,9
       xor       r10d,r8d
       rol       r8d,1B
       add       r8d,r10d
       rol       r10d,13
       mov       [rbp-60],r8d
       mov       [rbp-68],r10d
       jmp       near ptr M00_L21
M00_L34:
       xor       edx,edx
       xor       r10d,r10d
       mov       eax,r10d
       jmp       near ptr M00_L23
M00_L35:
       mov       ecx,[r15+28]
       call      qword ptr [7FFA06B05020]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFA06D1D7E8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       edx,[rbp-50]
       call      qword ptr [7FFA073071F8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].GetBucketRef(Int32)
       mov       r13,rax
       mov       [rbp-88],r13
       mov       eax,[rbp-50]
       jmp       near ptr M00_L27
M00_L36:
       mov       edx,[r15+2C]
       mov       r8d,edx
       dec       dword ptr [r15+30]
       cmp       edx,[r13+8]
       jae       near ptr M00_L58
       shl       rdx,4
       mov       edx,[r13+rdx+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [r15+2C],edx
       mov       ecx,r8d
       mov       r8,r13
       mov       r13d,ecx
       jmp       near ptr M00_L28
M00_L37:
       mov       rax,[rsi+18]
       mov       rdx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M00_L42
       mov       rcx,rax
       call      qword ptr [7FFA06DCFE18]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       lea       rcx,[rsi+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rdx,[rcx]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rdx,rax
       jne       near ptr M00_L43
       add       rcx,8
       call      qword ptr [7FFA06BB44E0]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L38:
       test      eax,eax
       je        near ptr M00_L40
       mov       rcx,[rbp-78]
       mov       r11,[rcx+30]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [r11],rax
       jne       near ptr M00_L44
       mov       rsi,[r11+10]
M00_L39:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,[rbp-78]
       mov       rdx,[rcx+20]
       mov       rcx,r14
       call      qword ptr [7FFA0699E100]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,r14
       mov       edx,7
       call      qword ptr [7FFA0699EE08]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rcx,[rbp-78]
       lea       rcx,[rcx+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-78]
       mov       rdx,[rcx+28]
       cmp       [rdx],dl
       lea       r8,[rbp-48]
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FFA0699EE80]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       mov       rcx,[rbp-78]
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-78]
       mov       dword ptr [rcx+14],2
       jmp       near ptr M00_L30
M00_L40:
       mov       rcx,rsi
       call      qword ptr [7FFA06D67D78]; System.Linq.Enumerable+DistinctIterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       near ptr M00_L59
M00_L41:
       mov       rcx,[rbp-78]
       mov       r11,7FFA068E1A48
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L31
M00_L42:
       mov       rcx,rax
       mov       r11,7FFA068E1A58
       call      qword ptr [r11]
       lea       rcx,[rsi+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
M00_L43:
       mov       r11,7FFA068E1A60
       call      qword ptr [r11]
       jmp       near ptr M00_L38
M00_L44:
       mov       rcx,r11
       mov       r11,7FFA068E1A68
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L39
M00_L45:
       mov       r11,7FFA068E1A78
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L18
M00_L46:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFA0699EE08]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L19
M00_L47:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L23
M00_L48:
       mov       r8d,80
       test      dl,1
       je        short M00_L49
       mov       r8d,edx
       and       r8,2
       movzx     r8d,byte ptr [rcx+r8]
       or        r8d,8000
M00_L49:
       test      dl,2
       je        short M00_L50
       shl       r8d,10
       movzx     ecx,word ptr [rcx]
       or        r8d,ecx
       mov       ecx,r8d
       jmp       near ptr M00_L22
M00_L50:
       mov       ecx,r8d
       jmp       near ptr M00_L22
M00_L51:
       mov       r8,[rcx]
       mov       r8,[r8+48]
       call      qword ptr [r8+18]
       jmp       near ptr M00_L23
M00_L52:
       mov       rcx,r12
       mov       rdx,r14
       mov       r11,7FFA068E1A80
       call      qword ptr [r11]
       jmp       near ptr M00_L23
M00_L53:
       mov       rdx,[r9]
       mov       rcx,r12
       mov       r8,r14
       mov       r11,7FFA068E1A88
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-90]
       je        near ptr M00_L25
       jmp       near ptr M00_L16
M00_L54:
       mov       rcx,rax
       mov       r11,7FFA068E1A70
       call      qword ptr [r11]
       jmp       near ptr M00_L17
M00_L55:
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L29
       mov       r13,[rbp-80]
       mov       edx,[r13+8]
       mov       rcx,r15
       mov       r8d,1
       call      qword ptr [7FFA06D1D7E8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFA0699EEC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L29
M00_L56:
       mov       r11,7FFA068E1A40
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L41
       jmp       short M00_L59
M00_L57:
       call      qword ptr [7FFA06BB7A20]
       int       3
M00_L58:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L59:
       mov       rcx,[rbp-78]
       cmp       [rcx],rdi
       jne       near ptr M00_L65
       call      qword ptr [7FFA06D67D78]; System.Linq.Enumerable+DistinctIterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
M00_L60:
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
M00_L61:
       mov       r11,7FFA068E1A20
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L62:
       mov       rcx,rax
       mov       r11,7FFA068E1A08
       call      qword ptr [r11]
       jmp       near ptr M00_L10
M00_L63:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFA06D1D620]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       jmp       near ptr M00_L11
M00_L64:
       mov       rcx,rsi
       mov       r11,7FFA068E1A38
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rsi,rcx
       jmp       near ptr M00_L14
M00_L65:
       mov       r11,7FFA068E1A50
       call      qword ptr [r11]
       jmp       near ptr M00_L60
       sub       rsp,28
       cmp       qword ptr [rbp-70],0
       je        short M00_L70
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       mov       rax,[rbp-70]
       cmp       [rax],rcx
       jne       short M00_L69
       mov       rcx,[rax+28]
       test      rcx,rcx
       je        short M00_L68
       mov       rdx,offset MT_System.Linq.Enumerable+IListSelectIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       cmp       [rcx],rdx
       jne       short M00_L66
       call      qword ptr [7FFA06FA6E68]; System.Linq.Enumerable+IListSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L67
M00_L66:
       mov       r11,7FFA068E1A20
       call      qword ptr [r11]
M00_L67:
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+28],rcx
M00_L68:
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+8],rcx
       mov       dword ptr [rax+14],0FFFFFFFF
       jmp       short M00_L70
M00_L69:
       mov       rcx,rax
       mov       r11,7FFA068E1A08
       call      qword ptr [r11]
M00_L70:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-78],0
       je        short M00_L72
       mov       rdi,offset MT_System.Linq.Enumerable+DistinctIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,[rbp-78]
       cmp       [rcx],rdi
       jne       short M00_L71
       call      qword ptr [7FFA06D67D78]; System.Linq.Enumerable+DistinctIterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L72
M00_L71:
       mov       r11,7FFA068E1A50
       call      qword ptr [r11]
M00_L72:
       nop
       add       rsp,28
       ret
; Total bytes of code 2682
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions+<AddLast>d__43`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       cmp       dword ptr [rbx+38],0FFFFFFFE
       jne       short M01_L01
       mov       esi,[rbx+3C]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       esi,eax
       jne       short M01_L01
       xor       ecx,ecx
       mov       [rbx+38],ecx
       mov       rsi,rbx
M01_L00:
       mov       rdx,[rbx+18]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+28]
       lea       rcx,[rsi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA073052D8]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<AddLast>d__43`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       jmp       short M01_L00
; Total bytes of code 100
```
```assembly
; System.Linq.Enumerable+IEnumerableWhereIterator`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,[rbx+14]
       cmp       ecx,1
       je        near ptr M02_L07
       cmp       ecx,2
       jne       near ptr M02_L26
M02_L00:
       mov       rsi,[rbx+28]
       mov       rdi,offset MT_System.Linq.Enumerable+IListSelectIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       cmp       [rsi],rdi
       jne       near ptr M02_L35
       mov       ecx,[rsi+14]
       cmp       ecx,1
       je        near ptr M02_L14
       cmp       ecx,2
       jne       near ptr M02_L21
M02_L01:
       mov       rcx,[rsi+28]
       mov       rdx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Address>+Enumerator
       cmp       [rcx],rdx
       jne       near ptr M02_L32
       lea       rbp,[rcx+8]
       mov       rcx,[rbp]
       mov       rdx,rcx
       mov       eax,[rbp+10]
       cmp       eax,[rcx+14]
       jne       near ptr M02_L36
       mov       ecx,[rbp+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M02_L17
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M02_L40
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
M02_L02:
       mov       rbp,[rsi+20]
       mov       rcx,[rsi+28]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Address>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M02_L33
       mov       rdx,[rcx+10]
       mov       rcx,offset DotNetTips.Spargine.Tester.RandomData+<>c.<GeneratePersonRef>b__65_0(DotNetTips.Spargine.Tester.Models.RefTypes.Address)
       cmp       [rbp+18],rcx
       jne       near ptr M02_L34
M02_L03:
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
M02_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       r11,[rdx+28]
       test      r11,r11
       je        near ptr M02_L16
M02_L05:
       mov       rcx,[rbx+28]
       cmp       [rcx],rdi
       jne       near ptr M02_L28
       mov       rdi,[rcx+8]
       mov       rsi,[rbx+20]
       mov       rcx,offset DotNetTips.Spargine.Tester.RandomData+<>c.<GeneratePersonRef>b__65_1(DotNetTips.Spargine.Tester.Models.RefTypes.Address)
       cmp       [rsi+18],rcx
       jne       near ptr M02_L29
       test      rdi,rdi
       je        near ptr M02_L00
M02_L06:
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       r11,[rdx+20]
       test      r11,r11
       je        short M02_L12
M02_L08:
       mov       rsi,[rbx+18]
       mov       rdi,offset MT_System.Linq.Enumerable+IListSelectIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       cmp       [rsi],rdi
       jne       near ptr M02_L27
       cmp       dword ptr [rsi+14],0
       jne       short M02_L09
       mov       ebp,[rsi+10]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       ebp,eax
       je        short M02_L13
M02_L09:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbp,[rsi+18]
       mov       rsi,[rsi+20]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+10],eax
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M02_L10:
       mov       dword ptr [rdx+14],1
M02_L11:
       lea       rcx,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+14],2
       jmp       near ptr M02_L00
M02_L12:
       mov       rdx,7FFA071FD708
       call      qword ptr [7FFA0699C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L08
M02_L13:
       mov       rdx,rsi
       jmp       short M02_L10
M02_L14:
       mov       rcx,[rsi+18]
       mov       rax,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       cmp       [rcx],rax
       jne       near ptr M02_L31
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       cmp       [rcx],rax
       jne       near ptr M02_L30
       call      qword ptr [7FFA06A835D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
       mov       rdx,rax
M02_L15:
       lea       rcx,[rsi+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+14],2
       jmp       near ptr M02_L01
M02_L16:
       mov       rdx,7FFA071FD720
       call      qword ptr [7FFA0699C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M02_L05
M02_L17:
       xor       eax,eax
       mov       [rbp+8],rax
       mov       dword ptr [rbp+14],0FFFFFFFF
M02_L18:
       cmp       qword ptr [rsi+28],0
       je        short M02_L20
       mov       rcx,[rsi+28]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Address>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M02_L37
M02_L19:
       xor       ecx,ecx
       mov       [rsi+28],rcx
M02_L20:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       dword ptr [rsi+14],0FFFFFFFF
M02_L21:
       cmp       qword ptr [rbx+28],0
       je        short M02_L25
       mov       rsi,[rbx+28]
       cmp       [rsi],rdi
       jne       near ptr M02_L39
       mov       rcx,[rsi+28]
       test      rcx,rcx
       je        short M02_L23
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Address>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M02_L38
M02_L22:
       xor       ecx,ecx
       mov       [rsi+28],rcx
M02_L23:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       dword ptr [rsi+14],0FFFFFFFF
M02_L24:
       xor       eax,eax
       mov       [rbx+28],rax
M02_L25:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
M02_L26:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L27:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M02_L11
M02_L28:
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rsi,[rbx+20]
M02_L29:
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        near ptr M02_L00
       jmp       near ptr M02_L06
M02_L30:
       mov       r11,7FFA068E0FD0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M02_L15
M02_L31:
       mov       r11,7FFA068E0FB8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M02_L15
M02_L32:
       mov       r11,7FFA068E0FC0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M02_L18
       jmp       near ptr M02_L02
M02_L33:
       mov       r11,7FFA068E0FC8
       call      qword ptr [r11]
       mov       rdx,rax
M02_L34:
       mov       rcx,[rbp+8]
       call      qword ptr [rbp+18]
       mov       rdx,rax
       jmp       near ptr M02_L03
M02_L35:
       mov       rcx,rsi
       mov       r11,7FFA068E0FB0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M02_L04
       jmp       near ptr M02_L21
M02_L36:
       call      qword ptr [7FFA06BBC150]
       int       3
M02_L37:
       mov       r11,7FFA068E0FD8
       call      qword ptr [r11]
       jmp       near ptr M02_L19
M02_L38:
       mov       r11,7FFA068E0FE8
       call      qword ptr [r11]
       jmp       near ptr M02_L22
M02_L39:
       mov       rcx,rsi
       mov       r11,7FFA068E0FE0
       call      qword ptr [r11]
       jmp       near ptr M02_L24
M02_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1007
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
       jmp       near ptr 00007FFA66628D10
M03_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L02:
       call      qword ptr [7FFA07084EE8]
       int       3
M03_L03:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFA0699D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M04_L04
       mov       r15d,4
M04_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M04_L06
       cmp       [r14+8],r15d
       je        short M04_L03
       test      r15d,r15d
       jle       near ptr M04_L08
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+78]
       test      rax,rax
       je        short M04_L05
       mov       rcx,rax
M04_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jg        short M04_L07
M04_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M04_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M04_L00
M04_L05:
       mov       rdx,7FFA0703E558
       call      qword ptr [7FFA0699C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M04_L01
M04_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA06F26208]
       int       3
M04_L07:
       mov       rcx,r14
       mov       r8d,edi
       mov       rdx,r15
       call      qword ptr [7FFA06B05050]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M04_L02
M04_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M04_L09
       jmp       short M04_L10
M04_L09:
       mov       rdx,7FFA0703ED68
       call      qword ptr [7FFA0699C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M04_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L03
; Total bytes of code 318
```
```assembly
; System.Linq.Enumerable+IListSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Dispose()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M05_L01
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Address>+Enumerator
       cmp       [rcx],r11
       jne       short M05_L02
M05_L00:
       xor       eax,eax
       mov       [rbx+28],rax
M05_L01:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M05_L02:
       mov       r11,7FFA068E1680
       call      qword ptr [r11]
       jmp       short M05_L00
; Total bytes of code 72
```
```assembly
; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,rcx
       mov       eax,[rbx+10]
       cmp       eax,[rcx+14]
       jne       short M06_L01
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M06_L00
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M06_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M06_L00:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M06_L01:
       call      qword ptr [7FFA06BBC150]
       int       3
M06_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Marvin.Block(UInt32 ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       r8d,eax
       xor       r8d,[rdx]
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       mov       [rcx],eax
       mov       [rdx],r8d
       ret
; Total bytes of code 37
```
```assembly
; System.Collections.HashHelpers.ExpandPrime(Int32)
       lea       edx,[rcx+rcx]
       cmp       edx,7FFFFFC3
       ja        short M08_L01
M08_L00:
       mov       ecx,edx
       jmp       qword ptr [7FFA06995A88]; System.Collections.HashHelpers.GetPrime(Int32)
M08_L01:
       cmp       ecx,7FFFFFC3
       jge       short M08_L00
       mov       eax,7FFFFFC3
       ret
; Total bytes of code 33
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M09_L07
       mov       rcx,rax
M09_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       r15,[rbx+10]
       test      r15,r15
       je        near ptr M09_L25
       mov       rcx,[r15]
       cmp       rcx,[rbp]
       jne       near ptr M09_L26
       cmp       dword ptr [rcx+4],18
       jne       near ptr M09_L26
       cmp       r14d,[r15+8]
       ja        near ptr M09_L26
       cmp       r14d,[rbp+8]
       ja        near ptr M09_L26
       mov       r8d,r14d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r15+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M09_L13
       mov       rcx,rax
       mov       r10,rdx
       mov       r9,r8
       mov       r11,rcx
       sub       r11,r10
       cmp       r11,r9
       jb        near ptr M09_L23
       mov       r11,r10
       sub       r11,rcx
       cmp       r11,r9
       jb        near ptr M09_L23
       lea       r11,[r10+r9]
       lea       r15,[rcx+r9]
       cmp       r9,10
       ja        near ptr M09_L10
       test      r8b,18
       jne       near ptr M09_L09
       test      r8b,4
       je        near ptr M09_L08
       mov       r8d,[rdx]
       mov       [rax],r8d
       mov       edx,[r11-4]
       mov       [r15-4],edx
M09_L01:
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M09_L28
M09_L02:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M09_L06
       mov       r13d,[rbp+8]
       cmp       r13d,r14d
       jl        near ptr M09_L16
       jmp       short M09_L05
M09_L03:
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M09_L37
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M09_L04:
       inc       ecx
       cmp       ecx,r14d
       jge       short M09_L06
M09_L05:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M09_L04
       jmp       short M09_L03
M09_L06:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       nop
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
M09_L07:
       mov       rdx,7FFA0732D988
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M09_L00
M09_L08:
       test      r8,r8
       je        near ptr M09_L01
       movzx     edx,byte ptr [rdx]
       mov       [rax],dl
       test      r8b,2
       je        near ptr M09_L01
       movsx     rax,word ptr [r11-2]
       mov       [r15-2],ax
       jmp       near ptr M09_L01
M09_L09:
       mov       r9,[rdx]
       mov       [rax],r9
       mov       rax,[r11-8]
       mov       [r15-8],rax
       jmp       near ptr M09_L01
M09_L10:
       cmp       r9,40
       ja        near ptr M09_L20
M09_L11:
       vmovups   xmm0,[r10]
       vmovups   [rcx],xmm0
       cmp       r9,20
       ja        near ptr M09_L19
M09_L12:
       vmovups   xmm0,[r11-10]
       vmovups   [r15-10],xmm0
       jmp       near ptr M09_L01
M09_L13:
       cmp       r8,4000
       ja        near ptr M09_L18
       mov       rcx,rax
       call      00007FFA665C1380
       cmp       dword ptr [7FFA668E3A10],0
       je        near ptr M09_L01
       jmp       short M09_L17
M09_L14:
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M09_L37
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M09_L15:
       inc       ecx
       cmp       ecx,r14d
       jge       near ptr M09_L06
M09_L16:
       cmp       ecx,r13d
       jae       near ptr M09_L37
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M09_L15
       jmp       short M09_L14
M09_L17:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M09_L01
M09_L18:
       mov       rcx,rax
       call      qword ptr [7FFA06F2FF90]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M09_L01
M09_L19:
       vmovups   xmm0,[r10+10]
       vmovups   [rcx+10],xmm0
       cmp       r9,30
       jbe       near ptr M09_L12
       vmovups   xmm0,[r10+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M09_L12
M09_L20:
       cmp       r9,800
       ja        near ptr M09_L24
       cmp       r9,100
       jb        short M09_L21
       mov       r10,rax
       and       r10,3F
       mov       r9,r10
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rax],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rax+20],ymm0
       lea       r10,[rdx+r9]
       lea       rcx,[rax+r9]
       sub       r8,r9
       mov       r9,r8
M09_L21:
       mov       rax,r9
       shr       rax,6
M09_L22:
       vmovdqu   ymm0,ymmword ptr [r10]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [r10+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       r10,40
       dec       rax
       jne       short M09_L22
       and       r9,3F
       cmp       r9,10
       ja        near ptr M09_L11
       jmp       near ptr M09_L12
M09_L23:
       cmp       rax,rdx
       je        near ptr M09_L01
M09_L24:
       cmp       [rax],al
       mov       rcx,rax
       call      qword ptr [7FFA069966E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M09_L01
M09_L25:
       xor       r13d,r13d
       jmp       short M09_L27
M09_L26:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFA070860A0]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M09_L27:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFA070860A0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFA0708F840]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M09_L01
M09_L28:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+90]
       test      rdi,rdi
       je        short M09_L29
       jmp       short M09_L30
M09_L29:
       mov       rdx,7FFA0732D9A0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M09_L30:
       mov       rdx,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M09_L02
M09_L31:
       mov       r13d,[rbp+8]
       cmp       r15d,r13d
       jae       short M09_L37
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M09_L36
       cmp       qword ptr [r13],0
       jne       short M09_L32
       xor       r12d,r12d
       jmp       short M09_L35
M09_L32:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        short M09_L33
       jmp       short M09_L34
M09_L33:
       mov       rdx,7FFA0732BA48
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M09_L34:
       mov       rdx,[r13]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
M09_L35:
       mov       [r13+8],r12d
M09_L36:
       inc       r15d
       cmp       r15d,r14d
       jl        short M09_L31
       jmp       near ptr M09_L02
M09_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1245
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].GetBucketRef(Int32)
       sub       rsp,28
       mov       rax,[rcx+8]
       mov       edx,edx
       imul      rdx,[rcx+20]
       shr       rdx,20
       inc       rdx
       mov       ecx,[rax+8]
       mov       r8d,ecx
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,ecx
       jae       short M10_L00
       mov       ecx,edx
       lea       rax,[rax+rcx*4+10]
       add       rsp,28
       ret
M10_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 58
```
```assembly
; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,[rbx]
       mov       rcx,rsi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+38]
       test      r11,r11
       je        near ptr M11_L04
M11_L00:
       mov       rcx,[rbx+8]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdi
       jne       near ptr M11_L06
       mov       ebp,[rcx+10]
M11_L01:
       test      ebp,ebp
       je        near ptr M11_L09
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+58]
       test      r11,r11
       je        short M11_L05
M11_L02:
       mov       rsi,[rbx+8]
       cmp       [rsi],rdi
       jne       near ptr M11_L08
       cmp       dword ptr [rsi+10],0
       je        short M11_L07
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebp,[rsi+14]
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       mov       [rdi+18],ebp
       mov       [rdi+1C],ecx
M11_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L04:
       mov       rdx,7FFA071FB698
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M11_L00
M11_L05:
       mov       rcx,rsi
       mov       rdx,7FFA0732E290
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M11_L02
M11_L06:
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M11_L01
M11_L07:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,1D7E3002BD8
       mov       rdi,[rax]
       jmp       short M11_L03
M11_L08:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M11_L09:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M11_L10
       jmp       short M11_L11
M11_L10:
       mov       rcx,rsi
       mov       rdx,7FFA0732E280
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M11_L11:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 324
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       test      rdx,rdx
       jne       short M12_L01
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        short M12_L03
M12_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
M12_L01:
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       je        short M12_L04
M12_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L03:
       mov       rdx,7FFA0732E320
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M12_L00
M12_L04:
       mov       rcx,[rbx+18]
       call      qword ptr [7FFA06996358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M12_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M12_L05
       jmp       short M12_L06
M12_L05:
       mov       rdx,7FFA0732D9A0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M12_L06:
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M12_L02
; Total bytes of code 198
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FFA06995A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M13_L01
       mov       rcx,rax
M13_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M13_L01:
       mov       rdx,7FFA0732D988
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M13_L00
; Total bytes of code 169
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       qword ptr [rbx+8],0
       je        near ptr M14_L15
M14_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M14_L16
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M14_L14
M14_L01:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M14_L22
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M14_L17
       mov       rcx,1D7E3000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M14_L21
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0A587434D
       mov       r8d,0D96F0126
       cmp       edx,8
       jb        near ptr M14_L12
       mov       r10d,edx
       shr       r10d,3
M14_L02:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M14_L02
       test      dl,4
       jne       near ptr M14_L13
M14_L03:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M14_L04:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r13d,ecx
       rol       r13d,14
       add       r13d,edx
       rol       edx,9
       xor       edx,r13d
       rol       r13d,1B
       add       r13d,edx
       mov       r12d,edx
       rol       r12d,13
       xor       r13d,r12d
M14_L05:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M14_L30
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       js        short M14_L08
M14_L06:
       cmp       eax,[rbp+8]
       jae       near ptr M14_L30
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r8,[rbp+rcx+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r13d
       je        near ptr M14_L23
M14_L07:
       mov       r8,[rsp+28]
       mov       eax,[r8+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M14_L26
       test      eax,eax
       jge       short M14_L06
M14_L08:
       cmp       dword ptr [rbx+30],0
       jg        near ptr M14_L27
       mov       eax,[rbx+28]
       mov       [rsp+38],eax
       cmp       [rbp+8],eax
       je        near ptr M14_L28
M14_L09:
       mov       eax,[rsp+38]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rbx+28],ecx
       mov       rcx,[rbx+10]
       mov       rax,rcx
M14_L10:
       cmp       ebp,[rax+8]
       jae       near ptr M14_L30
       mov       ecx,ebp
       shl       rcx,4
       mov       [rsp+30],rax
       lea       rcx,[rax+rcx+10]
       mov       [rcx+8],r13d
       mov       edx,[r12]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       edx,[rbp+1]
       mov       [r12],edx
       inc       dword ptr [rbx+34]
       mov       [rdi],ebp
       cmp       r15d,64
       ja        near ptr M14_L29
M14_L11:
       mov       eax,1
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
M14_L12:
       cmp       edx,4
       jb        short M14_L18
M14_L13:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M14_L03
M14_L14:
       mov       rdx,7FFA0732BA48
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M14_L01
M14_L15:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA0699EE08]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M14_L00
M14_L16:
       xor       r13d,r13d
       jmp       near ptr M14_L05
M14_L17:
       xor       r13d,r13d
       jmp       near ptr M14_L05
M14_L18:
       mov       r10d,80
       test      dl,1
       je        short M14_L19
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M14_L19:
       test      dl,2
       je        short M14_L20
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M14_L04
M14_L20:
       mov       ecx,r10d
       jmp       near ptr M14_L04
M14_L21:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M14_L05
M14_L22:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M14_L05
M14_L23:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M14_L24
       jmp       short M14_L25
M14_L24:
       mov       rdx,7FFA0732BA60
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M14_L25:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M14_L07
       mov       eax,[rsp+3C]
       mov       [rdi],eax
       xor       eax,eax
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
M14_L26:
       call      qword ptr [7FFA06BB7A20]
       int       3
M14_L27:
       mov       ecx,[rbx+2C]
       mov       eax,ecx
       dec       dword ptr [rbx+30]
       cmp       ecx,[rbp+8]
       jae       near ptr M14_L30
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+2C],ecx
       mov       ecx,eax
       mov       rax,rbp
       mov       ebp,ecx
       jmp       near ptr M14_L10
M14_L28:
       mov       rcx,rbx
       call      qword ptr [7FFA07306F28]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       short M14_L30
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M14_L09
M14_L29:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M14_L11
       mov       rbp,[rsp+30]
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFA06D1D7E8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA0699EEC8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       [rdi],eax
       jmp       near ptr M14_L11
M14_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1091
```
```assembly
; System.Linq.Enumerable+DistinctIterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M15_L01
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       short M15_L02
M15_L00:
       xor       eax,eax
       mov       [rbx+30],rax
       mov       [rbx+28],rax
M15_L01:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M15_L02:
       mov       r11,7FFA068E19E8
       call      qword ptr [r11]
       jmp       short M15_L00
; Total bytes of code 76
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M16_L00
       cmp       [rdx],rcx
       jne       short M16_L01
M16_L00:
       mov       rax,rdx
       ret
M16_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L00
M16_L02:
       test      rax,rax
       je        short M16_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L00
       test      rax,rax
       je        short M16_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L00
       test      rax,rax
       jne       short M16_L04
M16_L03:
       xor       edx,edx
       jmp       short M16_L00
M16_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L00
       test      rax,rax
       je        short M16_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L00
       jmp       short M16_L02
; Total bytes of code 88
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       mov       [rsp+38],rax
       mov       [rsp+30],rax
       mov       [rsp+40],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M17_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M17_L10
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M17_L08
M17_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M17_L13
       mov       [rsp+38],rsi
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+30],0
       jne       short M17_L01
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       cmp       qword ptr [rsp+30],0
       je        near ptr M17_L11
M17_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country
       cmp       [r15],rcx
       jne       near ptr M17_L12
       mov       rcx,r15
       call      00007FFA665C1BC0
       test      eax,eax
       je        near ptr M17_L09
M17_L02:
       mov       r15d,eax
M17_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
M17_L04:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M17_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M17_L07
M17_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M17_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+28],rax
       cmp       [rax+8],r15d
       je        near ptr M17_L14
M17_L06:
       mov       rax,[rsp+28]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M17_L17
       test      r13d,r13d
       jge       short M17_L05
M17_L07:
       mov       eax,0FFFFFFFF
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
M17_L08:
       mov       rdx,7FFA0732BA48
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M17_L00
M17_L09:
       mov       rcx,r15
       call      qword ptr [7FFA0699EEB0]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M17_L02
M17_L10:
       xor       r15d,r15d
       jmp       near ptr M17_L04
M17_L11:
       xor       r15d,r15d
       jmp       near ptr M17_L03
M17_L12:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M17_L03
M17_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M17_L04
M17_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M17_L15
       jmp       short M17_L16
M17_L15:
       mov       rdx,7FFA0732BA60
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M17_L16:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M17_L06
       mov       eax,r13d
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
M17_L17:
       call      qword ptr [7FFA06BB7A20]
       int       3
M17_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 545
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,rbx
       mov       rdx,r8
       call      qword ptr [7FFA66419B68]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M18_L05
       mov       rdi,[rbx]
       mov       rcx,rdi
       call      qword ptr [7FFA663F7448]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFA663F4098]; Precode of System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M18_L02
       mov       r14,[rbx+18]
       test      r14,r14
       je        near ptr M18_L06
M18_L00:
       mov       rdx,[rbp+18]
       test      rdx,rdx
       je        near ptr M18_L07
M18_L01:
       mov       rcx,r14
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       test      eax,eax
       je        short M18_L02
       mov       rcx,rbx
       mov       rdx,rbp
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M18_L02:
       mov       rcx,rdi
       call      qword ptr [7FFA663F74A0]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFA663F4098]; Precode of System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M18_L03
       mov       rcx,rdi
       call      qword ptr [7FFA663F9078]
       mov       rcx,rbp
       mov       r11,rax
       call      qword ptr [rax]
       test      eax,eax
       jle       short M18_L03
       mov       rcx,rbx
       mov       edx,eax
       call      qword ptr [7FFA66419BF0]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M18_L03:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFA66419BB0]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       ecx,[rbx+28]
       test      ecx,ecx
       jle       short M18_L04
       mov       rax,[rbx+10]
       mov       eax,[rax+8]
       xor       edx,edx
       div       ecx
       cmp       eax,3
       jg        short M18_L08
M18_L04:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M18_L05:
       mov       ecx,17
       call      qword ptr [7FFA6640A388]
       int       3
M18_L06:
       mov       rcx,rdi
       call      qword ptr [7FFA663F7440]
       mov       rcx,rax
       call      qword ptr [7FFA663FD2F8]
       mov       rcx,rax
       call      qword ptr [7FFA663F40A0]; Precode of System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
       jmp       near ptr M18_L00
M18_L07:
       mov       rcx,[rbp]
       call      qword ptr [7FFA663F7440]
       mov       rcx,rax
       call      qword ptr [7FFA663FD2F8]
       mov       rcx,rax
       call      qword ptr [7FFA663F40A0]; Precode of System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M18_L01
M18_L08:
       mov       edx,ecx
       sub       edx,[rbx+30]
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
; Total bytes of code 363
```

