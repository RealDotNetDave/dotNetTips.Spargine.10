## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L21
       mov       edi,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L26
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L22
       mov       r14d,[rcx+10]
M00_L00:
       test      r14d,r14d
       je        near ptr M00_L25
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L24
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L23
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r15d
       mov       [r14+1C],ecx
M00_L01:
       mov       [rbp-30],r14
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-30]
       cmp       [r14],rcx
       jne       near ptr M00_L17
       lea       rsi,[r14+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L18
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L10
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L19
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rsi,[r14+10]
M00_L03:
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,22DFBC00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,9BF0E502
       mov       r8d,0F59490AE
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
       mov       ecx,edi
       shl       ecx,5
       xor       ecx,edi
       mov       edi,ecx
       xor       edi,eax
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
       jmp       near ptr M00_L20
M00_L11:
       mov       rcx,r14
       mov       r11,7FFCFC7310E8
       call      qword ptr [r11]
       mov       rsi,rax
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
       mov       rcx,r14
       mov       r11,7FFCFC7310E0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L11
       jmp       near ptr M00_L27
M00_L18:
       call      qword ptr [7FFCFCA6C0D8]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rax,[rbx+60]
       mov       [rax+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L21:
       call      qword ptr [7FFCFCEBE7C0]
       mov       ecx,65
       mov       rdx,7FFCFCD12D08
       call      qword ptr [7FFCFCA67738]
       mov       r14,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBE5D90
       call      qword ptr [7FFCFCA67738]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFCFC7E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD12D08
       call      qword ptr [7FFCFCA67738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7E7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD1044F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD104510]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       r11,7FFCFC7310F8
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,22DFBC02C20
       mov       r14,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,rsi
       mov       r11,7FFCFC731100
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,22DFBC02C20
       mov       r14,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFCFC7310D8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r14
       mov       r11,7FFCFC7310F0
       call      qword ptr [r11]
       jmp       near ptr M00_L20
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L28
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-30]
       cmp       [rax],rcx
       je        short M00_L28
       mov       rcx,rax
       mov       r11,7FFCFC7310F0
       call      qword ptr [r11]
M00_L28:
       nop
       add       rsp,28
       ret
; Total bytes of code 1127
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,26E90D50008
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
       call      qword ptr [7FFCFD1D6E80]
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
       jmp       qword ptr [7FFCFC7E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L21
       mov       edi,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L26
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L22
       mov       r14d,[rcx+10]
M00_L00:
       test      r14d,r14d
       je        near ptr M00_L25
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L24
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L23
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r15d
       mov       [r14+1C],ecx
M00_L01:
       mov       [rbp-30],r14
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-30]
       cmp       [r14],rcx
       jne       near ptr M00_L17
       lea       rsi,[r14+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L18
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L10
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L19
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rsi,[r14+10]
M00_L03:
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,24F23C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0D6062409
       mov       r8d,44E382C3
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
       mov       ecx,edi
       shl       ecx,5
       xor       ecx,edi
       mov       edi,ecx
       xor       edi,eax
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
       jmp       near ptr M00_L20
M00_L11:
       mov       rcx,r14
       mov       r11,7FFCFC720F68
       call      qword ptr [r11]
       mov       rsi,rax
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
       mov       rcx,r14
       mov       r11,7FFCFC720F60
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L11
       jmp       near ptr M00_L27
M00_L18:
       call      qword ptr [7FFCFCA5C0D8]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rax,[rbx+60]
       mov       [rax+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L21:
       call      qword ptr [7FFCFCEAE688]
       mov       ecx,65
       mov       rdx,7FFCFCD02D08
       call      qword ptr [7FFCFCA57738]
       mov       r14,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBD5D90
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFCFC7D7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD02D08
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7D7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0F4438]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0F4450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       r11,7FFCFC720F78
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24F39C00C28
       mov       r14,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,rsi
       mov       r11,7FFCFC720F80
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24F39C00C28
       mov       r14,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFCFC720F58
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r14
       mov       r11,7FFCFC720F70
       call      qword ptr [r11]
       jmp       near ptr M00_L20
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L28
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-30]
       cmp       [rax],rcx
       je        short M00_L28
       mov       rcx,rax
       mov       r11,7FFCFC720F70
       call      qword ptr [r11]
M00_L28:
       nop
       add       rsp,28
       ret
; Total bytes of code 1127
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28FB8DC0008
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
       call      qword ptr [7FFCFD1C6E50]
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
       jmp       qword ptr [7FFCFC7D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L21
       mov       edi,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L26
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L22
       mov       r14d,[rcx+10]
M00_L00:
       test      r14d,r14d
       je        near ptr M00_L25
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L24
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L23
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r15d
       mov       [r14+1C],ecx
M00_L01:
       mov       [rbp-30],r14
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-30]
       cmp       [r14],rcx
       jne       near ptr M00_L17
       lea       rsi,[r14+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L18
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L10
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L19
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rsi,[r14+10]
M00_L03:
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,1A683C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,1D17212A
       mov       r8d,0EDBF56EA
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
       mov       ecx,edi
       shl       ecx,5
       xor       ecx,edi
       mov       edi,ecx
       xor       edi,eax
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
       jmp       near ptr M00_L20
M00_L11:
       mov       rcx,r14
       mov       r11,7FFCFC7110E0
       call      qword ptr [r11]
       mov       rsi,rax
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
       mov       rcx,r14
       mov       r11,7FFCFC7110D8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L11
       jmp       near ptr M00_L27
M00_L18:
       call      qword ptr [7FFCFCA4C0D8]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rax,[rbx+60]
       mov       [rax+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L21:
       call      qword ptr [7FFCFCE9E688]
       mov       ecx,65
       mov       rdx,7FFCFCCF2D08
       call      qword ptr [7FFCFCA47738]
       mov       r14,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBC5D90
       call      qword ptr [7FFCFCA47738]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFCFC7C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCCF2D08
       call      qword ptr [7FFCFCA47738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0E4450]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0E4468]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       r11,7FFCFC7110F0
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1A699C00C28
       mov       r14,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,rsi
       mov       r11,7FFCFC7110F8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1A699C00C28
       mov       r14,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFCFC7110D0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r14
       mov       r11,7FFCFC7110E8
       call      qword ptr [r11]
       jmp       near ptr M00_L20
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L28
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-30]
       cmp       [rax],rcx
       je        short M00_L28
       mov       rcx,rax
       mov       r11,7FFCFC7110E8
       call      qword ptr [r11]
M00_L28:
       nop
       add       rsp,28
       ret
; Total bytes of code 1127
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1E718B20008
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
       call      qword ptr [7FFCFD1B6E68]
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
       jmp       qword ptr [7FFCFC7C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L21
       mov       edi,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L26
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L22
       mov       r14d,[rcx+10]
M00_L00:
       test      r14d,r14d
       je        near ptr M00_L25
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L24
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L23
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r15d
       mov       [r14+1C],ecx
M00_L01:
       mov       [rbp-30],r14
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-30]
       cmp       [r14],rcx
       jne       near ptr M00_L17
       lea       rsi,[r14+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L18
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L10
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L19
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rsi,[r14+10]
M00_L03:
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,1CE5C000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,36D66738
       mov       r8d,0B55A0874
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
       mov       ecx,edi
       shl       ecx,5
       xor       ecx,edi
       mov       edi,ecx
       xor       edi,eax
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
       jmp       near ptr M00_L20
M00_L11:
       mov       rcx,r14
       mov       r11,7FFCFC710F60
       call      qword ptr [r11]
       mov       rsi,rax
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
       mov       rcx,r14
       mov       r11,7FFCFC710F58
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L11
       jmp       near ptr M00_L27
M00_L18:
       call      qword ptr [7FFCFCA4C0D8]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rax,[rbx+60]
       mov       [rax+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L21:
       call      qword ptr [7FFCFCE9E640]
       mov       ecx,65
       mov       rdx,7FFCFCCF2D08
       call      qword ptr [7FFCFCA47738]
       mov       r14,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBC5D90
       call      qword ptr [7FFCFCA47738]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFCFC7C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCCF2D08
       call      qword ptr [7FFCFCA47738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0E43D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0E43F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       r11,7FFCFC710F70
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1CE72000C28
       mov       r14,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,rsi
       mov       r11,7FFCFC710F78
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1CE72000C28
       mov       r14,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFCFC710F50
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r14
       mov       r11,7FFCFC710F68
       call      qword ptr [r11]
       jmp       near ptr M00_L20
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L28
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-30]
       cmp       [rax],rcx
       je        short M00_L28
       mov       rcx,rax
       mov       r11,7FFCFC710F68
       call      qword ptr [r11]
M00_L28:
       nop
       add       rsp,28
       ret
; Total bytes of code 1127
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20EF1160008
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
       call      qword ptr [7FFCFD1B6E68]
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
       jmp       qword ptr [7FFCFC7C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L20
       mov       edi,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L25
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L21
       mov       r14d,[rcx+10]
M00_L00:
       test      r14d,r14d
       je        near ptr M00_L24
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L23
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L22
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r15d
       mov       [r14+1C],ecx
M00_L01:
       mov       [rbp-30],r14
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-30]
       cmp       [r14],rcx
       jne       near ptr M00_L17
       lea       rsi,[r14+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L10
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L19
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L18
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rsi,[r14+10]
M00_L03:
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,26F5D800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,979E8982
       mov       r8d,0EA06AFA1
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
       mov       ecx,edi
       shl       ecx,5
       xor       ecx,edi
       mov       edi,ecx
       xor       edi,eax
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
       call      qword ptr [7FFCFCA4C0D8]
       int       3
M00_L11:
       mov       rcx,r14
       mov       r11,7FFCFC710FA0
       call      qword ptr [r11]
       mov       rsi,rax
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
       mov       rcx,r14
       mov       r11,7FFCFC710F98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L11
       jmp       near ptr M00_L26
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L27
M00_L20:
       call      qword ptr [7FFCFCE9E688]
       mov       ecx,65
       mov       rdx,7FFCFCCF2D08
       call      qword ptr [7FFCFCA47738]
       mov       r14,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBC5D90
       call      qword ptr [7FFCFCA47738]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFCFC7C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCCF2D08
       call      qword ptr [7FFCFCA47738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0E4450]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0E4468]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       mov       r11,7FFCFC710FB0
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L00
M00_L22:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,26F73800AD8
       mov       r14,[rcx]
       jmp       near ptr M00_L01
M00_L23:
       mov       rcx,rsi
       mov       r11,7FFCFC710FB8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,26F73800AD8
       mov       r14,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FFCFC710F90
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,r14
       mov       r11,7FFCFC710FA8
       call      qword ptr [r11]
M00_L27:
       mov       rax,[rbx+60]
       mov       [rax+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L28
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-30]
       cmp       [rax],rcx
       je        short M00_L28
       mov       rcx,rax
       mov       r11,7FFCFC710FA8
       call      qword ptr [r11]
M00_L28:
       nop
       add       rsp,28
       ret
; Total bytes of code 1122
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2AFF27E0008
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
       call      qword ptr [7FFCFD1B6FD0]
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
       jmp       qword ptr [7FFCFC7C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L20
       mov       edi,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L25
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L21
       mov       r14d,[rcx+10]
M00_L00:
       test      r14d,r14d
       je        near ptr M00_L24
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L23
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L22
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r15d
       mov       [r14+1C],ecx
M00_L01:
       mov       [rbp-30],r14
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-30]
       cmp       [r14],rcx
       jne       near ptr M00_L17
       lea       rsi,[r14+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L10
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L19
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L18
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rsi,[r14+10]
M00_L03:
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,1CA6E000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,499427F2
       mov       r8d,94A531C6
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
       mov       ecx,edi
       shl       ecx,5
       xor       ecx,edi
       mov       edi,ecx
       xor       edi,eax
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
       call      qword ptr [7FFCFCA5C0D8]
       int       3
M00_L11:
       mov       rcx,r14
       mov       r11,7FFCFC721120
       call      qword ptr [r11]
       mov       rsi,rax
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
       mov       rcx,r14
       mov       r11,7FFCFC721118
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L11
       jmp       near ptr M00_L26
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L27
M00_L20:
       call      qword ptr [7FFCFCEAE640]
       mov       ecx,65
       mov       rdx,7FFCFCD02D08
       call      qword ptr [7FFCFCA57738]
       mov       r14,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBD5D90
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFCFC7D7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD02D08
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7D7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0F4378]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0F4390]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       mov       r11,7FFCFC721130
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L00
M00_L22:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1CA6E002AD0
       mov       r14,[rcx]
       jmp       near ptr M00_L01
M00_L23:
       mov       rcx,rsi
       mov       r11,7FFCFC721138
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1CA6E002AD0
       mov       r14,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FFCFC721110
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,r14
       mov       r11,7FFCFC721128
       call      qword ptr [r11]
M00_L27:
       mov       rax,[rbx+60]
       mov       [rax+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L28
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-30]
       cmp       [rax],rcx
       je        short M00_L28
       mov       rcx,rax
       mov       r11,7FFCFC721128
       call      qword ptr [r11]
M00_L28:
       nop
       add       rsp,28
       ret
; Total bytes of code 1122
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,20B02FF0008
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
       call      qword ptr [7FFCFD1C6F70]
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
       jmp       qword ptr [7FFCFC7D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L20
       mov       edi,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L25
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L21
       mov       r14d,[rcx+10]
M00_L00:
       test      r14d,r14d
       je        near ptr M00_L24
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L23
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L22
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r15d
       mov       [r14+1C],ecx
M00_L01:
       mov       [rbp-30],r14
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-30]
       cmp       [r14],rcx
       jne       near ptr M00_L17
       lea       rsi,[r14+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L10
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L19
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L18
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rsi,[r14+10]
M00_L03:
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L12
       mov       rcx,1EA91800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0DA1D86F1
       mov       r8d,9FA00456
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
       mov       ecx,edi
       shl       ecx,5
       xor       ecx,edi
       mov       edi,ecx
       xor       edi,eax
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
       call      qword ptr [7FFCFCA5C0D8]
       int       3
M00_L11:
       mov       rcx,r14
       mov       r11,7FFCFC7213B0
       call      qword ptr [r11]
       mov       rsi,rax
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
       mov       rcx,r14
       mov       r11,7FFCFC7213A8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L11
       jmp       near ptr M00_L26
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L27
M00_L20:
       call      qword ptr [7FFCFCEAE688]
       mov       ecx,65
       mov       rdx,7FFCFCD02D08
       call      qword ptr [7FFCFCA57738]
       mov       r14,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBD5D90
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFCFC7D7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCD02D08
       call      qword ptr [7FFCFCA57738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7D7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFD0D54D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFD0D54E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       mov       r11,7FFCFC7213C0
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L00
M00_L22:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1EAA7800AD8
       mov       r14,[rcx]
       jmp       near ptr M00_L01
M00_L23:
       mov       rcx,rsi
       mov       r11,7FFCFC7213C8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1EAA7800AD8
       mov       r14,[rcx]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,rsi
       mov       r11,7FFCFC7213A0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,r14
       mov       r11,7FFCFC7213B8
       call      qword ptr [r11]
M00_L27:
       mov       rax,[rbx+60]
       mov       [rax+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L28
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-30]
       cmp       [rax],rcx
       je        short M00_L28
       mov       rcx,rax
       mov       r11,7FFCFC7213B8
       call      qword ptr [r11]
M00_L28:
       nop
       add       rsp,28
       ret
; Total bytes of code 1122
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22B26630008
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
       call      qword ptr [7FFCFD1C7558]
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
       jmp       qword ptr [7FFCFC7D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.GenerateHashCode()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M00_L21
       mov       edi,1997
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L26
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       near ptr M00_L22
       mov       r14d,[rcx+10]
M00_L00:
       test      r14d,r14d
       je        near ptr M00_L25
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rsi],rcx
       jne       near ptr M00_L24
       cmp       dword ptr [rsi+10],0
       je        near ptr M00_L23
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r15d
       mov       [r14+1C],ecx
M00_L01:
       mov       [rbp-30],r14
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r14,[rbp-30]
       cmp       [r14],rcx
       jne       near ptr M00_L17
       lea       rsi,[r14+8]
       mov       rcx,[rsi]
       mov       rdx,rcx
       mov       eax,[rsi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M00_L18
       mov       ecx,[rsi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M00_L08
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L19
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rsi,[r14+10]
M00_L03:
       test      rsi,rsi
       je        short M00_L02
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L10
       mov       rcx,181CE000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L16
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,1C1FAED3
       mov       r8d,0B0F88632
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
       mov       ecx,edi
       shl       ecx,5
       xor       ecx,edi
       mov       edi,ecx
       xor       edi,eax
       jmp       near ptr M00_L02
M00_L08:
       xor       eax,eax
       mov       [rsi+8],rax
       mov       dword ptr [rsi+14],0FFFFFFFF
       jmp       near ptr M00_L20
M00_L09:
       mov       rcx,r14
       mov       r11,7FFCFC711760
       call      qword ptr [r11]
       mov       rsi,rax
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
       mov       rcx,r14
       mov       r11,7FFCFC711758
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L09
       jmp       near ptr M00_L27
M00_L18:
       call      qword ptr [7FFCFCA4C0D8]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rax,[rbx+60]
       mov       [rax+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L21:
       call      qword ptr [7FFCFCE9E688]
       mov       ecx,65
       mov       rdx,7FFCFCCF2D08
       call      qword ptr [7FFCFCA47738]
       mov       r14,rax
       mov       ecx,1B61
       mov       rdx,7FFCFCBC5D90
       call      qword ptr [7FFCFCA47738]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFCFC7C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCFCCF2D08
       call      qword ptr [7FFCFCA47738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCFC7C7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCFCFF66E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCFCFF6700]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       mov       r11,7FFCFC711770
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,181E4000B98
       mov       r14,[rcx]
       jmp       near ptr M00_L01
M00_L24:
       mov       rcx,rsi
       mov       r11,7FFCFC711778
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,181E4000B98
       mov       r14,[rcx]
       jmp       near ptr M00_L01
M00_L26:
       mov       rcx,rsi
       mov       r11,7FFCFC711750
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,r14
       mov       r11,7FFCFC711768
       call      qword ptr [r11]
       jmp       near ptr M00_L20
       sub       rsp,28
       cmp       qword ptr [rbp-30],0
       je        short M00_L28
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-30]
       cmp       [rax],rcx
       je        short M00_L28
       mov       rcx,rax
       mov       r11,7FFCFC711768
       call      qword ptr [r11]
M00_L28:
       nop
       add       rsp,28
       ret
; Total bytes of code 1135
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
       call      00007FFD5C418D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCFC7C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCFC7C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1C262ED0008
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
       call      qword ptr [7FFCFD10F408]
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
       jmp       qword ptr [7FFCFC7C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L04
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       setle     al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC7110A0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       r11,7FFCFC711098
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 121
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L04
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       setle     al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC7410A0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       r11,7FFCFC741098
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 121
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L04
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       setle     al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC7110A0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       r11,7FFCFC711098
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 121
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L04
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       setle     al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC7310A0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       r11,7FFCFC731098
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 121
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L04
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       setle     al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC7410A0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       r11,7FFCFC741098
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 121
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L04
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       setle     al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC7210A0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       r11,7FFCFC721098
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 121
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L04
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       setle     al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC711340
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       r11,7FFCFC711338
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 121
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L04
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L03
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],r11
       jne       short M00_L02
       mov       esi,[rcx+10]
M00_L00:
       test      esi,esi
       setle     al
       movzx     eax,al
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFCFC7116F0
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L03:
       mov       r11,7FFCFC7116E8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L00
M00_L04:
       mov       eax,1
       jmp       short M00_L01
; Total bytes of code 121
```

