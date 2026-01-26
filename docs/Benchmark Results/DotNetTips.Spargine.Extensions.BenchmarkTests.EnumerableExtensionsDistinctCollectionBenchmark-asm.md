## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,68
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+48]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.EnumerableExtensions+<AddLast>d__41<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
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
       mov       rcx,12800001F58
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       call      qword ptr [7FFCEF7C6C40]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<AddLast>d__41`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
       mov       [rbp-58],rax
M00_L00:
       mov       rcx,rax
       mov       r11,7FFCEED01EA0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L02
       mov       rcx,[rbp-58]
       mov       r11,7FFCEED01EA8
       call      qword ptr [r11]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       short M00_L01
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       mov       edx,edx
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rax,[rbp-58]
       jmp       short M00_L00
M00_L01:
       mov       rcx,rsi
       mov       rdx,rax
       call      qword ptr [7FFCEEF2E370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-58]
       jmp       short M00_L00
M00_L02:
       mov       rcx,[rbp-58]
       mov       r11,7FFCEED01EB0
       call      qword ptr [r11]
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       mov       r11,7FFCEED01ED0
       call      qword ptr [r11]
       cmp       eax,800
       jle       near ptr M00_L53
       mov       rcx,offset MT_System.Linq.Enumerable+DistinctIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+20],rcx
M00_L03:
       mov       rax,offset MT_System.Linq.Enumerable+DistinctIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rax
       jne       near ptr M00_L54
       cmp       dword ptr [rsi+14],0
       jne       short M00_L04
       mov       edi,[rsi+10]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       edi,eax
       jne       short M00_L04
       jmp       short M00_L05
M00_L04:
       mov       rcx,offset MT_System.Linq.Enumerable+DistinctIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rsi+18]
       mov       rsi,[rsi+20]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+10],eax
       lea       rcx,[rdi+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rdi
M00_L05:
       mov       dword ptr [rsi+14],1
M00_L06:
       mov       [rbp-60],rsi
M00_L07:
       mov       rdx,offset MT_System.Linq.Enumerable+DistinctIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rcx,[rbp-60]
       cmp       [rcx],rdx
       jne       near ptr M00_L48
       mov       rsi,rcx
       mov       edx,[rsi+14]
       cmp       edx,1
       je        near ptr M00_L29
       cmp       edx,2
       jne       near ptr M00_L32
M00_L08:
       mov       rax,[rsi+30]
       mov       rdx,[rax]
       mov       r8,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rdx,r8
       jne       near ptr M00_L46
       lea       rcx,[rax+8]
       call      qword ptr [7FFCEEFD4480]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L09:
       test      eax,eax
       je        near ptr M00_L32
       mov       rcx,[rsi+30]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       near ptr M00_L37
       mov       rdi,[rcx+10]
M00_L10:
       mov       r14,[rsi+28]
       cmp       qword ptr [r14+8],0
       je        near ptr M00_L38
M00_L11:
       mov       r15,[r14+10]
       mov       r13,[r14+18]
       xor       r12d,r12d
       test      rdi,rdi
       je        near ptr M00_L26
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r13],rcx
       jne       near ptr M00_L44
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L39
       mov       rcx,12800000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L43
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,6306B5A1
       mov       r8d,6F9425EE
       cmp       edx,8
       jb        near ptr M00_L24
       mov       r10d,edx
       shr       r10d,3
M00_L12:
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
       jne       short M00_L12
       test      dl,4
       jne       near ptr M00_L25
M00_L13:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L14:
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
       mov       eax,ecx
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       mov       r8d,edx
       rol       r8d,13
       xor       eax,r8d
M00_L15:
       mov       [rbp-4C],eax
       mov       r10,[r14+8]
       mov       [rbp-80],r10
       mov       r8,[r14+20]
       mov       edx,[r10+8]
       mov       ecx,eax
       call      qword ptr [7FFCEEFD7A50]; System.Collections.HashHelpers.FastMod(UInt32, UInt32, UInt64)
       mov       rdx,[rbp-80]
       cmp       eax,[rdx+8]
       jae       near ptr M00_L50
       mov       ecx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       [rbp-70],rax
       mov       r10d,[rax]
       dec       r10d
       js        short M00_L18
M00_L16:
       cmp       r10d,[r15+8]
       jae       near ptr M00_L50
       mov       edx,r10d
       shl       rdx,4
       lea       r10,[r15+rdx+10]
       mov       [rbp-78],r10
       mov       r9d,[rbp-4C]
       cmp       [r10+8],r9d
       je        near ptr M00_L45
M00_L17:
       mov       r10d,[r10+0C]
       inc       r12d
       cmp       [r15+8],r12d
       jb        near ptr M00_L49
       test      r10d,r10d
       jge       short M00_L16
M00_L18:
       cmp       dword ptr [r14+30],0
       jg        near ptr M00_L28
       mov       edx,[r14+28]
       mov       [rbp-50],edx
       cmp       [r15+8],edx
       je        near ptr M00_L27
M00_L19:
       mov       edx,[rbp-50]
       mov       r15d,edx
       lea       ecx,[r15+1]
       mov       [r14+28],ecx
       mov       rcx,[r14+10]
       mov       r8,rcx
M00_L20:
       cmp       r15d,[r8+8]
       jae       near ptr M00_L50
       mov       ecx,r15d
       shl       rcx,4
       mov       [rbp-68],r8
       lea       rcx,[r8+rcx+10]
       mov       r9d,[rbp-4C]
       mov       [rcx+8],r9d
       mov       rax,[rbp-70]
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       rdx,[rbp-70]
       mov       [rdx],r15d
       inc       dword ptr [r14+34]
       cmp       r12d,64
       ja        near ptr M00_L47
M00_L21:
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L22:
       mov       rcx,[rbp-60]
       mov       rsi,[rcx+8]
M00_L23:
       mov       [rbp-40],rsi
       mov       rsi,[rbx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       jmp       near ptr M00_L07
M00_L24:
       cmp       edx,4
       jb        near ptr M00_L40
M00_L25:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L13
M00_L26:
       xor       eax,eax
       jmp       near ptr M00_L15
M00_L27:
       mov       rcx,r14
       call      qword ptr [7FFCEF7F4A08]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       mov       rcx,r14
       mov       edx,[rbp-4C]
       call      qword ptr [7FFCEF7F4CF0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].GetBucketRef(Int32)
       mov       r15,rax
       mov       [rbp-70],r15
       jmp       near ptr M00_L19
M00_L28:
       mov       ecx,[r14+2C]
       mov       r8d,ecx
       dec       dword ptr [r14+30]
       cmp       ecx,[r15+8]
       jae       near ptr M00_L50
       shl       rcx,4
       mov       ecx,[r15+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [r14+2C],ecx
       mov       eax,r8d
       mov       r8,r15
       mov       r15d,eax
       jmp       near ptr M00_L20
M00_L29:
       mov       rax,[rsi+18]
       mov       rdx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rdx
       jne       near ptr M00_L34
       mov       rcx,rax
       call      qword ptr [7FFCEF1EB390]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       lea       rcx,[rsi+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
       mov       rdx,[rcx]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       rdx,rax
       jne       near ptr M00_L35
       add       rcx,8
       call      qword ptr [7FFCEEFD4480]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L30:
       test      eax,eax
       je        near ptr M00_L32
       mov       rcx,[rbp-60]
       mov       r11,[rcx+30]
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [r11],rax
       jne       near ptr M00_L36
       mov       rsi,[r11+10]
M00_L31:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rbp-60]
       mov       rdx,[rcx+20]
       mov       rcx,rdi
       call      qword ptr [7FFCEEDBDB90]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,rdi
       mov       edx,7
       call      qword ptr [7FFCEEDBE898]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-60]
       mov       rdx,[rcx+28]
       cmp       [rdx],dl
       lea       r8,[rbp-48]
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FFCEEDBE910]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].AddIfNotPresent(System.__Canon, Int32 ByRef)
       mov       rcx,[rbp-60]
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-60]
       mov       dword ptr [rcx+14],2
       jmp       near ptr M00_L22
M00_L32:
       mov       rcx,rsi
       call      qword ptr [7FFCEF185BE0]; System.Linq.Enumerable+DistinctIterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       near ptr M00_L51
M00_L33:
       mov       rcx,[rbp-60]
       mov       r11,7FFCEED01EE8
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L23
M00_L34:
       mov       rcx,rax
       mov       r11,7FFCEED01EF8
       call      qword ptr [r11]
       lea       rcx,[rsi+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+30]
M00_L35:
       mov       r11,7FFCEED01F00
       call      qword ptr [r11]
       jmp       near ptr M00_L30
M00_L36:
       mov       rcx,r11
       mov       r11,7FFCEED01F08
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       near ptr M00_L31
M00_L37:
       mov       r11,7FFCEED01F18
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L10
M00_L38:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFCEEDBE898]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M00_L11
M00_L39:
       xor       eax,eax
       jmp       near ptr M00_L15
M00_L40:
       mov       r10d,80
       test      dl,1
       je        short M00_L41
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L41:
       test      dl,2
       je        short M00_L42
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L14
M00_L42:
       mov       ecx,r10d
       jmp       near ptr M00_L14
M00_L43:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L15
M00_L44:
       mov       rcx,r13
       mov       rdx,rdi
       mov       r11,7FFCEED01F20
       call      qword ptr [r11]
       jmp       near ptr M00_L15
M00_L45:
       mov       rdx,[r10]
       mov       rcx,r13
       mov       r8,rdi
       mov       r11,7FFCEED01F28
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rbp-78]
       je        near ptr M00_L17
       jmp       near ptr M00_L08
M00_L46:
       mov       rcx,rax
       mov       r11,7FFCEED01F10
       call      qword ptr [r11]
       jmp       near ptr M00_L09
M00_L47:
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L21
       mov       r15,[rbp-68]
       mov       edx,[r15+8]
       mov       rcx,r14
       mov       r8d,1
       call      qword ptr [7FFCEF13D5A8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFCEEDBE958]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L21
M00_L48:
       mov       r11,7FFCEED01EE0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L33
       jmp       short M00_L51
M00_L49:
       call      qword ptr [7FFCEEFD79A8]
       int       3
M00_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L51:
       mov       rcx,offset MT_System.Linq.Enumerable+DistinctIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-60]
       cmp       [rax],rcx
       jne       short M00_L55
       mov       rcx,rax
       call      qword ptr [7FFCEF185BE0]; System.Linq.Enumerable+DistinctIterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
M00_L52:
       nop
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
M00_L53:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFCEF13D3E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       jmp       near ptr M00_L03
M00_L54:
       mov       rcx,rsi
       mov       r11,7FFCEED01ED8
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rsi,rcx
       jmp       near ptr M00_L06
M00_L55:
       mov       rcx,rax
       mov       r11,7FFCEED01EF0
       call      qword ptr [r11]
       jmp       short M00_L52
       sub       rsp,28
       mov       rcx,[rbp-58]
       test      rcx,rcx
       je        short M00_L56
       mov       r11,7FFCEED01EB0
       call      qword ptr [r11]
M00_L56:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-60],0
       je        short M00_L58
       mov       rcx,offset MT_System.Linq.Enumerable+DistinctIterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-60]
       cmp       [rax],rcx
       jne       short M00_L57
       mov       rcx,rax
       call      qword ptr [7FFCEF185BE0]; System.Linq.Enumerable+DistinctIterator`1[[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L58
M00_L57:
       mov       rcx,rax
       mov       r11,7FFCEED01EF0
       call      qword ptr [r11]
M00_L58:
       nop
       add       rsp,28
       ret
; Total bytes of code 2237
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions+<AddLast>d__41`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
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
       call      qword ptr [7FFCEF72EE38]; DotNetTips.Spargine.Extensions.EnumerableExtensions+<AddLast>d__41`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       jmp       short M01_L00
; Total bytes of code 100
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L02
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M02_L01
       cmp       rdx,[r8]
       je        short M02_L00
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       jne       short M02_L03
M02_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFD4E9D9DD0
M02_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L02:
       call      qword ptr [7FFCEF4C55C0]
       int       3
M02_L03:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFCEEDBD908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
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
       jne       near ptr M03_L04
       mov       r15d,4
M03_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M03_L07
       cmp       [r14+8],r15d
       je        short M03_L03
       test      r15d,r15d
       jle       near ptr M03_L08
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+78]
       test      rax,rax
       je        short M03_L05
       mov       rcx,rax
M03_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jg        short M03_L06
M03_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
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
M03_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M03_L00
M03_L05:
       mov       rdx,7FFCEF4A6950
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M03_L01
M03_L06:
       mov       rcx,r14
       mov       r8d,edi
       mov       rdx,r15
       call      qword ptr [7FFCEEDB7060]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M03_L02
M03_L07:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFCEF345E18]
       int       3
M03_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+80]
       test      rdx,rdx
       je        short M03_L09
       jmp       short M03_L10
M03_L09:
       mov       rdx,7FFCEF4FB5F8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M03_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L03
; Total bytes of code 316
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
       jne       short M04_L01
       mov       ecx,[rbx+14]
       cmp       ecx,[rdx+10]
       jae       short M04_L00
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       short M04_L02
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       eax,1
       add       rsp,20
       pop       rbx
       ret
M04_L00:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       call      qword ptr [7FFCEEFDC0D8]
       int       3
M04_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```
```assembly
; System.Collections.HashHelpers.FastMod(UInt32, UInt32, UInt64)
       mov       eax,ecx
       imul      rax,r8
       shr       rax,20
       inc       rax
       mov       ecx,edx
       imul      rax,rcx
       shr       rax,20
       ret
; Total bytes of code 24
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       ecx,[rbx+28]
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M06_L10
M06_L00:
       mov       ecx,eax
       call      qword ptr [7FFCEEDB5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
M06_L01:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        near ptr M06_L07
       mov       rcx,rax
M06_L02:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       ebp,[rbx+28]
       mov       r14,[rbx+10]
       test      r14,r14
       je        near ptr M06_L14
       mov       rcx,[r14]
       cmp       rcx,[rdi]
       jne       near ptr M06_L15
       cmp       dword ptr [rcx+4],18
       jne       near ptr M06_L15
       cmp       ebp,[r14+8]
       ja        near ptr M06_L15
       cmp       ebp,[rdi+8]
       ja        near ptr M06_L15
       mov       r8d,ebp
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M06_L13
       cmp       r8,4000
       ja        near ptr M06_L12
       mov       rcx,rax
       call      00007FFD4E98B8A0
       cmp       dword ptr [7FFD4ECEF778],0
       jne       near ptr M06_L11
M06_L03:
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
       test      ebp,ebp
       jle       short M06_L06
       mov       edx,[rdi+8]
       cmp       edx,ebp
       jl        near ptr M06_L08
M06_L04:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rdi+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M06_L05
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
       jae       near ptr M06_L17
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M06_L05:
       inc       ecx
       cmp       ecx,ebp
       jl        short M06_L04
M06_L06:
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L07:
       mov       rdx,7FFCEF80A690
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M06_L02
M06_L08:
       cmp       ecx,edx
       jae       near ptr M06_L17
       mov       eax,ecx
       shl       rax,4
       lea       rax,[rdi+rax+10]
       cmp       dword ptr [rax+0C],0FFFFFFFF
       jl        short M06_L09
       mov       r8d,[rax+8]
       mov       r10,[rbx+8]
       imul      r8,[rbx+20]
       shr       r8,20
       inc       r8
       mov       r9d,[r10+8]
       mov       r11d,r9d
       imul      r8,r11
       shr       r8,20
       cmp       r8d,r9d
       jae       near ptr M06_L17
       mov       r8d,r8d
       lea       r8,[r10+r8*4+10]
       mov       r10d,[r8]
       dec       r10d
       mov       [rax+0C],r10d
       lea       eax,[rcx+1]
       mov       [r8],eax
M06_L09:
       inc       ecx
       cmp       ecx,ebp
       jl        short M06_L08
       jmp       near ptr M06_L06
M06_L10:
       cmp       ecx,7FFFFFC3
       jge       near ptr M06_L00
       mov       esi,7FFFFFC3
       jmp       near ptr M06_L01
M06_L11:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L03
M06_L12:
       mov       rcx,rax
       call      qword ptr [7FFCEF34E598]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L03
M06_L13:
       mov       rcx,rax
       call      qword ptr [7FFCEEDB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M06_L03
M06_L14:
       xor       r15d,r15d
       jmp       short M06_L16
M06_L15:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFCEF4CC540]; System.Array.GetLowerBound(Int32)
       mov       r15d,eax
M06_L16:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFCEF4CC540]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebp
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r15d
       mov       r8,rdi
       call      qword ptr [7FFCEF4C5E78]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M06_L03
M06_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
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
       jae       short M07_L00
       mov       ecx,edx
       lea       rax,[rax+rcx*4+10]
       add       rsp,28
       ret
M07_L00:
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
       je        near ptr M08_L04
M08_L00:
       mov       rcx,[rbx+8]
       mov       rdi,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdi
       jne       near ptr M08_L06
       mov       ebp,[rcx+10]
M08_L01:
       test      ebp,ebp
       je        near ptr M08_L09
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M08_L05
M08_L02:
       mov       rsi,[rbx+8]
       cmp       [rsi],rdi
       jne       near ptr M08_L08
       cmp       dword ptr [rsi+10],0
       je        short M08_L07
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
M08_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M08_L04:
       mov       rdx,7FFCEF731BD0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M08_L00
M08_L05:
       mov       rcx,rsi
       mov       rdx,7FFCEF731D08
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M08_L02
M08_L06:
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M08_L01
M08_L07:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,12816000DC8
       mov       rdi,[rax]
       jmp       short M08_L03
M08_L08:
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M08_L09:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M08_L10
       jmp       short M08_L11
M08_L10:
       mov       rcx,rsi
       mov       rdx,7FFCEF731CF8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M08_L11:
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
       jne       short M09_L01
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        short M09_L03
M09_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
M09_L01:
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.String
       cmp       [rcx],rax
       je        short M09_L04
M09_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L03:
       mov       rdx,7FFCEF80AE20
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M09_L00
M09_L04:
       mov       rcx,[rbx+18]
       call      qword ptr [7FFCEEDB6358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M09_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        short M09_L05
       jmp       short M09_L06
M09_L05:
       mov       rdx,7FFCEF80A6A8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M09_L06:
       mov       rcx,rdx
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L02
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
       call      qword ptr [7FFCEEDB5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       je        short M10_L01
       mov       rcx,rax
M10_L00:
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
M10_L01:
       mov       rdx,7FFCEF80A690
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M10_L00
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
       je        near ptr M11_L15
M11_L00:
       mov       rbp,[rbx+10]
       mov       r14,[rbx+18]
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M11_L12
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M11_L14
M11_L01:
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rcx
       jne       near ptr M11_L23
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M11_L16
       mov       rcx,12800000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M11_L22
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,6306B5A1
       mov       r8d,6F9425EE
       cmp       edx,8
       jb        near ptr M11_L17
       mov       r10d,edx
       shr       r10d,3
M11_L02:
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
       jne       short M11_L02
       test      dl,4
       jne       near ptr M11_L18
M11_L03:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M11_L04:
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
M11_L05:
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
       jae       near ptr M11_L30
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       mov       eax,[r12]
       dec       eax
       js        short M11_L08
M11_L06:
       cmp       eax,[rbp+8]
       jae       near ptr M11_L30
       mov       [rsp+3C],eax
       mov       ecx,eax
       shl       rcx,4
       lea       r8,[rbp+rcx+10]
       mov       [rsp+28],r8
       cmp       [r8+8],r13d
       je        near ptr M11_L24
M11_L07:
       mov       r8,[rsp+28]
       mov       eax,[r8+0C]
       inc       r15d
       cmp       [rbp+8],r15d
       jb        near ptr M11_L27
       test      eax,eax
       jge       short M11_L06
M11_L08:
       cmp       dword ptr [rbx+30],0
       jg        near ptr M11_L13
       mov       eax,[rbx+28]
       mov       [rsp+38],eax
       cmp       [rbp+8],eax
       je        near ptr M11_L28
M11_L09:
       mov       eax,[rsp+38]
       mov       ebp,eax
       lea       ecx,[rbp+1]
       mov       [rbx+28],ecx
       mov       rcx,[rbx+10]
       mov       rax,rcx
M11_L10:
       cmp       ebp,[rax+8]
       jae       near ptr M11_L30
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
       ja        near ptr M11_L29
M11_L11:
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
M11_L12:
       xor       r13d,r13d
       jmp       near ptr M11_L05
M11_L13:
       mov       ecx,[rbx+2C]
       mov       eax,ecx
       dec       dword ptr [rbx+30]
       cmp       ecx,[rbp+8]
       jae       near ptr M11_L30
       shl       rcx,4
       mov       ecx,[rbp+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rbx+2C],ecx
       mov       ecx,eax
       mov       rax,rbp
       mov       ebp,ecx
       jmp       near ptr M11_L10
M11_L14:
       mov       rdx,7FFCEF6224C8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M11_L01
M11_L15:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCEEDBE898]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M11_L00
M11_L16:
       xor       r13d,r13d
       jmp       near ptr M11_L05
M11_L17:
       cmp       edx,4
       jb        short M11_L19
M11_L18:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M11_L03
M11_L19:
       mov       r10d,80
       test      dl,1
       je        short M11_L20
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M11_L20:
       test      dl,2
       je        short M11_L21
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M11_L04
M11_L21:
       mov       ecx,r10d
       jmp       near ptr M11_L04
M11_L22:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M11_L05
M11_L23:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M11_L05
M11_L24:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M11_L25
       jmp       short M11_L26
M11_L25:
       mov       rdx,7FFCEF6224E0
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M11_L26:
       mov       rax,[rsp+28]
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M11_L07
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
M11_L27:
       call      qword ptr [7FFCEEFD79A8]
       int       3
M11_L28:
       mov       rcx,rbx
       call      qword ptr [7FFCEF7F4A08]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize()
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
       jae       short M11_L30
       mov       edx,edx
       lea       r12,[rcx+rdx*4+10]
       jmp       near ptr M11_L09
M11_L29:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M11_L11
       mov       rbp,[rsp+30]
       mov       edx,[rbp+8]
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFCEF13D5A8]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFCEEDBE958]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       mov       [rdi],eax
       jmp       near ptr M11_L11
M11_L30:
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
       je        short M12_L01
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       cmp       [rcx],r11
       jne       short M12_L02
M12_L00:
       xor       eax,eax
       mov       [rbx+30],rax
       mov       [rbx+28],rax
M12_L01:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M12_L02:
       mov       r11,7FFCEED01E90
       call      qword ptr [r11]
       jmp       short M12_L00
; Total bytes of code 76
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M13_L00
       cmp       [rdx],rcx
       jne       short M13_L01
M13_L00:
       mov       rax,rdx
       ret
M13_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M13_L00
M13_L02:
       test      rax,rax
       je        short M13_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M13_L00
       test      rax,rax
       jne       short M13_L04
M13_L03:
       xor       edx,edx
       jmp       short M13_L00
M13_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M13_L00
       test      rax,rax
       je        short M13_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M13_L00
       test      rax,rax
       je        short M13_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M13_L00
       jmp       short M13_L02
; Total bytes of code 88
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
       je        near ptr M14_L06
       mov       rcx,rax
M14_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       r15,[rbx+10]
       test      r15,r15
       je        near ptr M14_L12
       mov       rcx,[r15]
       cmp       rcx,[rbp]
       jne       near ptr M14_L13
       cmp       dword ptr [rcx+4],18
       jne       near ptr M14_L13
       cmp       r14d,[r15+8]
       ja        near ptr M14_L13
       cmp       r14d,[rbp+8]
       ja        near ptr M14_L13
       mov       r8d,r14d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r15+10]
       lea       rax,[rbp+10]
       test      dword ptr [rcx],1000000
       je        near ptr M14_L11
       cmp       r8,4000
       ja        near ptr M14_L10
       mov       rcx,rax
       call      00007FFD4E98B8A0
       cmp       dword ptr [7FFD4ECEF778],0
       jne       near ptr M14_L09
M14_L01:
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M14_L15
M14_L02:
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
       jle       short M14_L05
       mov       r13d,[rbp+8]
       cmp       r13d,r14d
       jl        near ptr M14_L07
M14_L03:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M14_L04
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
       jae       near ptr M14_L24
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M14_L04:
       inc       ecx
       cmp       ecx,r14d
       jl        short M14_L03
M14_L05:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       nop
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
M14_L06:
       mov       rdx,7FFCEF80A690
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M14_L00
M14_L07:
       cmp       ecx,r13d
       jae       near ptr M14_L24
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M14_L08
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
       jae       near ptr M14_L24
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M14_L08:
       inc       ecx
       cmp       ecx,r14d
       jl        short M14_L07
       jmp       near ptr M14_L05
M14_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M14_L01
M14_L10:
       mov       rcx,rax
       call      qword ptr [7FFCEF34E598]; System.Buffer.BulkMoveWithWriteBarrierBatch(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M14_L01
M14_L11:
       mov       rcx,rax
       call      qword ptr [7FFCEEDB5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M14_L01
M14_L12:
       xor       r13d,r13d
       jmp       short M14_L14
M14_L13:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFCEF4CC540]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M14_L14:
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FFCEF4CC540]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r14d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r13d
       mov       r8,rbp
       call      qword ptr [7FFCEF4C5E78]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M14_L01
M14_L15:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdi,[rdx+90]
       test      rdi,rdi
       je        short M14_L16
       jmp       short M14_L17
M14_L16:
       mov       rdx,7FFCEF80A6A8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M14_L17:
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
       jge       near ptr M14_L02
M14_L18:
       mov       r13d,[rbp+8]
       cmp       r15d,r13d
       jae       short M14_L24
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M14_L23
       cmp       qword ptr [r13],0
       jne       short M14_L19
       xor       r12d,r12d
       jmp       short M14_L22
M14_L19:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        short M14_L20
       jmp       short M14_L21
M14_L20:
       mov       rdx,7FFCEF6224C8
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M14_L21:
       mov       rdx,[r13]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12d,eax
M14_L22:
       mov       [r13+8],r12d
M14_L23:
       inc       r15d
       cmp       r15d,r14d
       jl        short M14_L18
       jmp       near ptr M14_L02
M14_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 862
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M15_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M15_L10
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M15_L08
M15_L00:
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r14],rcx
       jne       near ptr M15_L13
       mov       [rsp+28],rsi
       xor       ecx,ecx
       mov       [rsp+20],rcx
       lea       rcx,[rsp+28]
       cmp       qword ptr [rsp+20],0
       jne       short M15_L01
       mov       rcx,[rsp+28]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       cmp       qword ptr [rsp+20],0
       je        near ptr M15_L11
M15_L01:
       mov       r15,[rcx]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country
       cmp       [r15],rcx
       jne       near ptr M15_L12
       mov       rcx,r15
       call      00007FFD4E98C390
       test      eax,eax
       je        near ptr M15_L09
M15_L02:
       mov       r15d,eax
M15_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
M15_L04:
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
       jae       near ptr M15_L18
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M15_L07
M15_L05:
       cmp       r13d,[rdi+8]
       jae       near ptr M15_L18
       mov       ecx,r13d
       shl       rcx,4
       lea       r12,[rdi+rcx+10]
       cmp       [r12+8],r15d
       je        near ptr M15_L14
M15_L06:
       mov       r13d,[r12+0C]
       inc       ebp
       cmp       [rdi+8],ebp
       jb        near ptr M15_L17
       test      r13d,r13d
       jge       short M15_L05
M15_L07:
       mov       eax,0FFFFFFFF
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
M15_L08:
       mov       rdx,7FFCEF6224C8
       call      qword ptr [7FFCEEDBC5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M15_L00
M15_L09:
       mov       rcx,r15
       call      qword ptr [7FFCEEDBE940]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M15_L02
M15_L10:
       xor       r15d,r15d
       jmp       near ptr M15_L04
M15_L11:
       xor       r15d,r15d
       jmp       near ptr M15_L03
M15_L12:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M15_L03
M15_L13:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M15_L04
M15_L14:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M15_L15
       jmp       short M15_L16
M15_L15:
       mov       rdx,7FFCEF6224E0
       call      qword ptr [7FFCEEDBC5D0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M15_L16:
       mov       rdx,[r12]
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M15_L06
       mov       eax,r13d
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
M15_L17:
       call      qword ptr [7FFCEEFD79A8]
       int       3
M15_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 532
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
       call      qword ptr [7FFD4E80CBE0]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M16_L05
       mov       rdi,[rbx]
       mov       rcx,rdi
       call      qword ptr [7FFD4E7EA440]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFD4E7E7080]; Precode of System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M16_L02
       mov       r14,[rbx+18]
       test      r14,r14
       je        near ptr M16_L06
M16_L00:
       mov       rdx,[rbp+18]
       test      rdx,rdx
       je        near ptr M16_L07
M16_L01:
       mov       rcx,r14
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       test      eax,eax
       je        short M16_L02
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
M16_L02:
       mov       rcx,rdi
       call      qword ptr [7FFD4E7EA498]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFD4E7E7080]; Precode of System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M16_L03
       mov       rcx,rdi
       call      qword ptr [7FFD4E7EC070]
       mov       rcx,rbp
       mov       r11,rax
       call      qword ptr [rax]
       test      eax,eax
       jle       short M16_L03
       mov       rcx,rbx
       mov       edx,eax
       call      qword ptr [7FFD4E80CC68]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
M16_L03:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFD4E80CC28]; Precode of System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].UnionWith(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       ecx,[rbx+28]
       test      ecx,ecx
       jle       short M16_L04
       mov       rax,[rbx+10]
       mov       eax,[rax+8]
       xor       edx,edx
       div       ecx
       cmp       eax,3
       jg        short M16_L08
M16_L04:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M16_L05:
       mov       ecx,17
       call      qword ptr [7FFD4E7FD420]
       int       3
M16_L06:
       mov       rcx,rdi
       call      qword ptr [7FFD4E7EA438]
       mov       rcx,rax
       call      qword ptr [7FFD4E7F0388]
       mov       rcx,rax
       call      qword ptr [7FFD4E7E7088]; Precode of System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
       jmp       near ptr M16_L00
M16_L07:
       mov       rcx,[rbp]
       call      qword ptr [7FFD4E7EA438]
       mov       rcx,rax
       call      qword ptr [7FFD4E7F0388]
       mov       rcx,rax
       call      qword ptr [7FFD4E7E7088]; Precode of System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       jmp       near ptr M16_L01
M16_L08:
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

