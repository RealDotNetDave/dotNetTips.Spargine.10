## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L22
       mov       rcx,1F969800AC0
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L23
       mov       r15d,[rcx+10]
M00_L00:
       test      r15d,r15d
       je        near ptr M00_L26
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L25
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L24
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-38],r15
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-38]
       cmp       [r15],rcx
       jne       near ptr M00_L18
       lea       rsi,[r15+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L19
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L10
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L20
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rdx,[r15+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,1F953800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,263CFB6
       mov       r8d,0FAACB47
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L04:
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
       jne       short M00_L04
       test      dl,4
       jne       short M00_L09
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
M00_L07:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,eax
       jmp       near ptr M00_L02
M00_L08:
       cmp       edx,4
       jb        short M00_L13
M00_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L10:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L11:
       mov       rcx,r15
       mov       r11,7FF7DBEB10B8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L12:
       xor       eax,eax
       jmp       short M00_L07
M00_L13:
       mov       r10d,80
       test      dl,1
       je        short M00_L14
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L14:
       test      dl,2
       je        short M00_L15
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L15:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L16:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L17:
       mov       rcx,rdi
       mov       r11,7FF7DBEB10C0
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FF7DBEB10B0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L28
M00_L19:
       call      qword ptr [7FF7DBF6FC48]
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       mov       rax,[rbx+60]
       mov       [rax+38],r14d
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L22:
       call      qword ptr [7FF7DC5BE700]
       mov       ecx,65
       mov       rdx,7FF7DC4226D0
       call      qword ptr [7FF7DBF6F210]
       mov       r15,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3040A0
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4226D0
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7A4378]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7A4390]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       r11,7FF7DBEB10D0
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F969800C28
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FF7DBEB10D8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F969800C28
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FF7DBEB10A8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r15
       mov       r11,7FF7DBEB10C8
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L29
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L29
       mov       rcx,rax
       mov       r11,7FF7DBEB10C8
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1194
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,239E8790008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FF7DC8C6A18]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF7DBF65C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L22
       mov       rcx,20FFE400AC8
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L23
       mov       r15d,[rcx+10]
M00_L00:
       test      r15d,r15d
       je        near ptr M00_L26
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L25
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L24
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-38],r15
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-38]
       cmp       [r15],rcx
       jne       near ptr M00_L18
       lea       rsi,[r15+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L19
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L10
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L20
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rdx,[r15+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,20FE8400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,78EA9C15
       mov       r8d,7E7889FF
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L04:
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
       jne       short M00_L04
       test      dl,4
       jne       short M00_L09
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
M00_L07:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,eax
       jmp       near ptr M00_L02
M00_L08:
       cmp       edx,4
       jb        short M00_L13
M00_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L10:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L11:
       mov       rcx,r15
       mov       r11,7FF7DBEB0F38
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L12:
       xor       eax,eax
       jmp       short M00_L07
M00_L13:
       mov       r10d,80
       test      dl,1
       je        short M00_L14
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L14:
       test      dl,2
       je        short M00_L15
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L15:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L16:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L17:
       mov       rcx,rdi
       mov       r11,7FF7DBEB0F40
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FF7DBEB0F30
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L28
M00_L19:
       call      qword ptr [7FF7DBF6FC48]
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       mov       rax,[rbx+60]
       mov       [rax+38],r14d
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L22:
       call      qword ptr [7FF7DC5BE280]
       mov       ecx,65
       mov       rdx,7FF7DC4226D0
       call      qword ptr [7FF7DBF6F210]
       mov       r15,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3040A0
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4226D0
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC72FF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC72FF18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       r11,7FF7DBEB0F50
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20FFE400C28
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FF7DBEB0F58
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20FFE400C28
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FF7DBEB0F28
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r15
       mov       r11,7FF7DBEB0F48
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L29
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L29
       mov       rcx,rax
       mov       r11,7FF7DBEB0F48
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1194
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,2507D520008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FF7DC8C6A00]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF7DBF65C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L22
       mov       rcx,163ABC00AC8
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L23
       mov       r15d,[rcx+10]
M00_L00:
       test      r15d,r15d
       je        near ptr M00_L26
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L25
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L24
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-38],r15
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-38]
       cmp       [r15],rcx
       jne       near ptr M00_L18
       lea       rsi,[r15+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L19
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L10
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L20
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rdx,[r15+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,16395C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,626A0FAF
       mov       r8d,0A183F93A
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L04:
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
       jne       short M00_L04
       test      dl,4
       jne       short M00_L09
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
M00_L07:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,eax
       jmp       near ptr M00_L02
M00_L08:
       cmp       edx,4
       jb        short M00_L13
M00_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L10:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L11:
       mov       rcx,r15
       mov       r11,7FF7DBEA10B0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L12:
       xor       eax,eax
       jmp       short M00_L07
M00_L13:
       mov       r10d,80
       test      dl,1
       je        short M00_L14
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L14:
       test      dl,2
       je        short M00_L15
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L15:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L16:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L17:
       mov       rcx,rdi
       mov       r11,7FF7DBEA10B8
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FF7DBEA10A8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L28
M00_L19:
       call      qword ptr [7FF7DBF5FC48]
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       mov       rax,[rbx+60]
       mov       [rax+38],r14d
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L22:
       call      qword ptr [7FF7DC5AE748]
       mov       ecx,65
       mov       rdx,7FF7DC4126D0
       call      qword ptr [7FF7DBF5F210]
       mov       r15,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F40A0
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4126D0
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7943F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC794408]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       r11,7FF7DBEA10C8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,163ABC00C28
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FF7DBEA10D0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,163ABC00C28
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FF7DBEA10A0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r15
       mov       r11,7FF7DBEA10C0
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L29
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L29
       mov       rcx,rax
       mov       r11,7FF7DBEA10C0
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1194
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,1A42AA40008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FF7DC8B6A48]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF7DBF55C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L22
       mov       rcx,2AE62400AC8
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L23
       mov       r15d,[rcx+10]
M00_L00:
       test      r15d,r15d
       je        near ptr M00_L26
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L25
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L24
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-38],r15
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-38]
       cmp       [r15],rcx
       jne       near ptr M00_L18
       lea       rsi,[r15+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L19
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L10
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L20
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rdx,[r15+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,2AE4C400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,2C3E36D3
       mov       r8d,0EC942C0C
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L04:
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
       jne       short M00_L04
       test      dl,4
       jne       short M00_L09
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
M00_L07:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,eax
       jmp       near ptr M00_L02
M00_L08:
       cmp       edx,4
       jb        short M00_L13
M00_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L10:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L11:
       mov       rcx,r15
       mov       r11,7FF7DBEC0F30
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L12:
       xor       eax,eax
       jmp       short M00_L07
M00_L13:
       mov       r10d,80
       test      dl,1
       je        short M00_L14
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L14:
       test      dl,2
       je        short M00_L15
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L15:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L16:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L17:
       mov       rcx,rdi
       mov       r11,7FF7DBEC0F38
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FF7DBEC0F28
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L28
M00_L19:
       call      qword ptr [7FF7DBF7FC48]
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       mov       rax,[rbx+60]
       mov       [rax+38],r14d
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L22:
       call      qword ptr [7FF7DC5CE748]
       mov       ecx,65
       mov       rdx,7FF7DC4326D0
       call      qword ptr [7FF7DBF7F210]
       mov       r15,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3140A0
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4326D0
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7B43A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7B43C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       r11,7FF7DBEC0F48
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2AE62400C28
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FF7DBEC0F50
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2AE62400C28
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FF7DBEC0F20
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r15
       mov       r11,7FF7DBEC0F40
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L29
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L29
       mov       rcx,rax
       mov       r11,7FF7DBEC0F40
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1194
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,2EEE11C0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FF7DC8D6A48]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF7DBF75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L21
       mov       rcx,1FEB1800AC0
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L26
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L22
       mov       r15d,[rcx+10]
M00_L00:
       test      r15d,r15d
       je        near ptr M00_L25
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L24
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L23
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-38],r15
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-38]
       cmp       [r15],rcx
       jne       near ptr M00_L18
       lea       rsi,[r15+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L10
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L20
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L19
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rdx,[r15+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,1FE9B800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,518AF70D
       mov       r8d,0A5C5F9FC
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L04:
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
       jne       short M00_L04
       test      dl,4
       jne       short M00_L09
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
M00_L07:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,eax
       jmp       near ptr M00_L02
M00_L08:
       cmp       edx,4
       jb        short M00_L13
M00_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L10:
       call      qword ptr [7FF7DBF7FC48]
       int       3
M00_L11:
       mov       rcx,r15
       mov       r11,7FF7DBEC0F70
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L12:
       xor       eax,eax
       jmp       short M00_L07
M00_L13:
       mov       r10d,80
       test      dl,1
       je        short M00_L14
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L14:
       test      dl,2
       je        short M00_L15
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L15:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L16:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L17:
       mov       rcx,rdi
       mov       r11,7FF7DBEC0F78
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FF7DBEC0F68
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L27
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L28
M00_L21:
       call      qword ptr [7FF7DC5CE2F8]
       mov       ecx,65
       mov       rdx,7FF7DC4326D0
       call      qword ptr [7FF7DBF7F210]
       mov       r15,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC313D40
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4326D0
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC73FF90]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC73FFA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       r11,7FF7DBEC0F88
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1FEB1800AD8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,rsi
       mov       r11,7FF7DBEC0F90
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1FEB1800AD8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rsi
       mov       r11,7FF7DBEC0F60
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r15
       mov       r11,7FF7DBEC0F80
       call      qword ptr [r11]
M00_L28:
       mov       rax,[rbx+60]
       mov       [rax+38],r14d
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L29
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L29
       mov       rcx,rax
       mov       r11,7FF7DBEC0F80
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1189
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,23F308A0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FF7DC8D6B68]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF7DBF75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L21
       mov       rcx,16DE8400AC8
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L26
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L22
       mov       r15d,[rcx+10]
M00_L00:
       test      r15d,r15d
       je        near ptr M00_L25
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L24
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L23
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-38],r15
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-38]
       cmp       [r15],rcx
       jne       near ptr M00_L18
       lea       rsi,[r15+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L10
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L20
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L19
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rdx,[r15+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,16DD2400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,2EB4681B
       mov       r8d,293FFC6D
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L04:
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
       jne       short M00_L04
       test      dl,4
       jne       short M00_L09
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
M00_L07:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,eax
       jmp       near ptr M00_L02
M00_L08:
       cmp       edx,4
       jb        short M00_L13
M00_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L10:
       call      qword ptr [7FF7DBF7FC48]
       int       3
M00_L11:
       mov       rcx,r15
       mov       r11,7FF7DBEC10F0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L12:
       xor       eax,eax
       jmp       short M00_L07
M00_L13:
       mov       r10d,80
       test      dl,1
       je        short M00_L14
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L14:
       test      dl,2
       je        short M00_L15
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L15:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L16:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L17:
       mov       rcx,rdi
       mov       r11,7FF7DBEC10F8
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FF7DBEC10E8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L27
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L28
M00_L21:
       call      qword ptr [7FF7DC5CE748]
       mov       ecx,65
       mov       rdx,7FF7DC4326D0
       call      qword ptr [7FF7DBF7F210]
       mov       r15,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3140A0
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4326D0
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC8344F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC834510]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       r11,7FF7DBEC1108
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,16DE8400AD8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,rsi
       mov       r11,7FF7DBEC1110
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,16DE8400AD8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rsi
       mov       r11,7FF7DBEC10E0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r15
       mov       r11,7FF7DBEC1100
       call      qword ptr [r11]
M00_L28:
       mov       rax,[rbx+60]
       mov       [rax+38],r14d
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L29
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L29
       mov       rcx,rax
       mov       r11,7FF7DBEC1100
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1189
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,1AE67560008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FF7DC8D6B98]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF7DBF75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L21
       mov       rcx,25957C02AC0
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L26
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L22
       mov       r15d,[rcx+10]
M00_L00:
       test      r15d,r15d
       je        near ptr M00_L25
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L24
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L23
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-38],r15
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-38]
       cmp       [r15],rcx
       jne       near ptr M00_L18
       lea       rsi,[r15+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L10
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L20
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L19
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rdx,[r15+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,25957C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0C1DD3E50
       mov       r8d,3BABD4A1
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
M00_L04:
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
       jne       short M00_L04
       test      dl,4
       jne       short M00_L09
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
M00_L07:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,eax
       jmp       near ptr M00_L02
M00_L08:
       cmp       edx,4
       jb        short M00_L13
M00_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L10:
       call      qword ptr [7FF7DBF5FC48]
       int       3
M00_L11:
       mov       rcx,r15
       mov       r11,7FF7DBEA1328
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L12:
       xor       eax,eax
       jmp       short M00_L07
M00_L13:
       mov       r10d,80
       test      dl,1
       je        short M00_L14
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L14:
       test      dl,2
       je        short M00_L15
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L15:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L16:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L17:
       mov       rcx,rdi
       mov       r11,7FF7DBEA1330
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FF7DBEA1320
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L11
       jmp       near ptr M00_L27
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L28
M00_L21:
       call      qword ptr [7FF7DC5AE220]
       mov       ecx,65
       mov       rdx,7FF7DC4126D0
       call      qword ptr [7FF7DBF5F210]
       mov       r15,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F3D40
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4126D0
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC805368]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC805380]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       r11,7FF7DBEA1340
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25957C02AD0
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,rsi
       mov       r11,7FF7DBEA1348
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25957C02AD0
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rsi
       mov       r11,7FF7DBEA1318
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r15
       mov       r11,7FF7DBEA1338
       call      qword ptr [r11]
M00_L28:
       mov       rax,[rbx+60]
       mov       [rax+38],r14d
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L29
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L29
       mov       rcx,rax
       mov       r11,7FF7DBEA1338
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1189
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
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M01_L00:
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
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,299ECD60008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
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
M01_L04:
       call      qword ptr [7FF7DC8B7180]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF7DBF55C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionExtensionsBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L22
       mov       rcx,24D5B400D50
       mov       rdi,[rcx]
       mov       r14d,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L27
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L23
       mov       r15d,[rcx+10]
M00_L00:
       test      r15d,r15d
       je        near ptr M00_L26
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L25
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L24
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13d,[rsi+14]
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r13d
       mov       [r15+1C],ecx
M00_L01:
       mov       [rbp-38],r15
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r15,[rbp-38]
       cmp       [r15],rcx
       jne       near ptr M00_L18
       lea       rsi,[r15+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L19
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L08
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L20
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rdx,[r15+10]
M00_L03:
       test      rdx,rdx
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       jne       near ptr M00_L17
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L10
       mov       rcx,24D45400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,9E7B2B04
       mov       r8d,3B64D2DD
       cmp       edx,8
       jb        near ptr M00_L11
       mov       r10d,edx
       shr       r10d,3
M00_L04:
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
       jne       short M00_L04
       test      dl,4
       jne       near ptr M00_L12
M00_L05:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L06:
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
M00_L07:
       mov       ecx,r14d
       shl       ecx,5
       xor       ecx,r14d
       mov       r14d,ecx
       xor       r14d,eax
       jmp       near ptr M00_L02
M00_L08:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L21
M00_L09:
       mov       rcx,r15
       mov       r11,7FF7DBEC1BD0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L10:
       xor       eax,eax
       jmp       short M00_L07
M00_L11:
       cmp       edx,4
       jb        short M00_L13
M00_L12:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L05
M00_L13:
       mov       r10d,80
       test      dl,1
       je        short M00_L14
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L14:
       test      dl,2
       je        short M00_L15
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L15:
       mov       ecx,r10d
       jmp       near ptr M00_L06
M00_L16:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L07
M00_L17:
       mov       rcx,rdi
       mov       r11,7FF7DBEC1BD8
       call      qword ptr [r11]
       jmp       near ptr M00_L07
M00_L18:
       mov       rcx,r15
       mov       r11,7FF7DBEC1BC8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L09
       jmp       near ptr M00_L28
M00_L19:
       call      qword ptr [7FF7DBF7FC48]
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L21:
       mov       rax,[rbx+60]
       mov       [rax+38],r14d
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L22:
       call      qword ptr [7FF7DC5CE1F0]
       mov       ecx,65
       mov       rdx,7FF7DC4326D0
       call      qword ptr [7FF7DBF7F210]
       mov       r15,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3140A0
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4326D0
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC737D38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC737D50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L23:
       mov       r11,7FF7DBEC1BE8
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M00_L00
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24D5B400D60
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FF7DBEC1BF0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24D5B400D60
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,rsi
       mov       r11,7FF7DBEC1BC0
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L28:
       mov       rcx,r15
       mov       r11,7FF7DBEC1BE0
       call      qword ptr [r11]
       jmp       near ptr M00_L21
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M00_L29
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-38]
       cmp       [rax],rcx
       je        short M00_L29
       mov       rcx,rax
       mov       r11,7FF7DBEC1BE0
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1198
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L00
       test      rbx,rbx
       je        near ptr M01_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M01_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       test      rbx,rbx
       je        short M01_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L02
M01_L01:
       mov       rax,28DDA450008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      qword ptr [7FF7DC85ED48]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF7DBF75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

