## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ContainsValueComparer()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonEqualityComparer
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       r14,[rcx+48]
       cmp       [rbx],bl
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass23_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r15+10]
       test      rdx,rdx
       je        near ptr M00_L10
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r15+8]
       mov       rdx,20131C00A48
       mov       rdx,[rdx]
       cmp       [rcx],rsi
       jne       near ptr M00_L11
       cmp       rcx,rdx
       je        near ptr M00_L12
M00_L00:
       mov       rax,[rbx+28]
       test      rax,rax
       je        near ptr M00_L13
M00_L01:
       mov       rbx,[rax+8]
       mov       rcx,rbx
       mov       edx,[rcx+38]
       sub       edx,[rcx+40]
       je        near ptr M00_L23
       mov       edi,[rbx+44]
       xor       r14d,r14d
       jmp       short M00_L05
M00_L02:
       mov       rdx,7FF91CB47DC0
       call      qword ptr [7FF91C34C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M00_L07
M00_L03:
       call      qword ptr [7FF91C34FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L04:
       test      eax,eax
       mov       r14d,r13d
       jne       near ptr M00_L20
M00_L05:
       cmp       edi,[rbx+44]
       jne       near ptr M00_L21
       cmp       r14d,[rbx+38]
       jae       near ptr M00_L08
M00_L06:
       mov       rcx,[rbx+10]
       lea       edx,[r14+1]
       mov       r13d,edx
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L27
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        near ptr M00_L19
       mov       r14,[rcx+8]
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M00_L02
M00_L07:
       mov       rcx,[r15+8]
       mov       r8,[r15+10]
       cmp       [rcx],rsi
       jne       near ptr M00_L18
       cmp       r14,r8
       je        near ptr M00_L17
       test      r14,r14
       je        near ptr M00_L16
       test      r8,r8
       je        near ptr M00_L16
       mov       rcx,[r14+28]
       mov       rdx,[r8+28]
       cmp       rcx,rdx
       je        near ptr M00_L14
       test      rcx,rcx
       je        near ptr M00_L15
       test      rdx,rdx
       je        near ptr M00_L15
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L15
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       jne       near ptr M00_L03
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r11,[rdx]
       xor       r11,rax
       xor       rcx,[rdx+2]
       or        rcx,r11
       sete      al
       movzx     eax,al
       jmp       near ptr M00_L04
M00_L08:
       xor       ebx,ebx
M00_L09:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L10:
       call      qword ptr [7FF91C8FF528]
       mov       ecx,10B0
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C56C060]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C56C060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C347840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C56C060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C347840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CBD5740]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91C8FF1B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L00
M00_L12:
       mov       rdx,[r15+10]
       mov       rcx,rbx
       call      qword ptr [7FF91CB26EE0]
       mov       ebx,eax
       jmp       near ptr M00_L09
M00_L13:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+ValueCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FF91CBD5758]
       lea       rcx,[rbx+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       jmp       near ptr M00_L01
M00_L14:
       mov       eax,1
       jmp       near ptr M00_L04
M00_L15:
       xor       eax,eax
       jmp       near ptr M00_L04
M00_L16:
       xor       eax,eax
       jmp       near ptr M00_L04
M00_L17:
       mov       eax,1
       jmp       near ptr M00_L04
M00_L18:
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L19:
       cmp       r13d,[rbx+38]
       mov       r14d,r13d
       jb        near ptr M00_L06
       jmp       near ptr M00_L08
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L22
M00_L21:
       call      qword ptr [7FF91C56C9F0]
       int       3
M00_L22:
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L09
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20131C00B08
       mov       rcx,[rcx]
       mov       [rbp-40],rcx
M00_L24:
       mov       rcx,[rbp-40]
       mov       r11,[rcx]
       mov       r11,7FF91C290EB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L25
       mov       rcx,[rbp-40]
       mov       r11,7FF91C290EB8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,r15
       mov       rax,offset DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary`2+<>c__DisplayClass23_0[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ContainsValue>b__0(System.__Canon)
       call      rax
       test      eax,eax
       je        short M00_L24
       mov       dword ptr [rbp-34],1
       jmp       short M00_L26
M00_L25:
       mov       rcx,[rbp-40]
       mov       r11,7FF91C290EC0
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L26:
       call      M00_L28
       jmp       near ptr M00_L22
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L29
       mov       rcx,[rbp-40]
       mov       r11,7FF91C290EC0
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1002
```
```assembly
; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       mov       rbx,rcx
       mov       rsi,rdx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       r8,rsp
       mov       [rbp-58],r8
       mov       r8,rbp
       mov       [rbp-48],r8
       xor       r8d,r8d
       mov       [rsp+20],r8
       mov       r8,rsi
       mov       rdx,rbx
       xor       ecx,ecx
       mov       r9d,0FFFFFFFF
       mov       rax,7FF91C420458
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF97BF9B800
       call      rax
M01_L00:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF97C2B39A0],0
       je        short M01_L01
       call      qword ptr [7FF97C2A1648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rcx,[rbp-68]
       mov       [rdi+8],rcx
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
; Total bytes of code 174
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L01
       cmp       rcx,rdx
       je        near ptr M02_L11
       cmp       r8,20
       jb        near ptr M02_L08
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        near ptr M02_L07
       vmovups   ymm0,[rcx]
       vpcmpeqb  ymm0,ymm0,[rdx]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        short M02_L06
M02_L00:
       xor       eax,eax
       vzeroupper
       ret
M02_L01:
       cmp       r8,4
       jae       short M02_L04
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L02
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L02:
       test      r8b,1
       je        short M02_L03
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L03:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L05
M02_L04:
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
M02_L05:
       vzeroupper
       ret
M02_L06:
       add       rax,20
       cmp       r8,rax
       jbe       short M02_L07
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L00
       jmp       short M02_L06
M02_L07:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       near ptr M02_L00
       jmp       short M02_L11
M02_L08:
       cmp       r8,10
       jb        short M02_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L10
       vmovups   xmm0,[rcx]
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L00
M02_L09:
       add       rax,10
       cmp       r8,rax
       jbe       short M02_L10
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L00
       jmp       short M02_L09
M02_L10:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M02_L00
M02_L11:
       mov       eax,1
       vzeroupper
       ret
M02_L12:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L05
; Total bytes of code 349
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
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C345818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C345818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M03_L00:
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
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,241B0C30008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
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
M03_L04:
       call      qword ptr [7FF91CB2CEB8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FF91C345C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary`2+<>c__DisplayClass23_0[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ContainsValue>b__0(System.__Canon)
; 		return this.Values.Any(v => comparer.Equals(v, value));
; 		                            ^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M05_L01
M05_L00:
       mov       rcx,[rbx+8]
       mov       r8,[rbx+10]
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonEqualityComparer
       cmp       [rcx],rdx
       jne       short M05_L05
       cmp       rsi,r8
       je        short M05_L02
       test      rsi,rsi
       je        short M05_L04
       test      r8,r8
       je        short M05_L04
       mov       rcx,[rsi+28]
       mov       rdx,[r8+28]
       mov       r8d,4
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91C4B4B28]; System.String.Equals(System.String, System.String, System.StringComparison)
M05_L01:
       mov       rdx,7FF91CB47DC0
       call      qword ptr [7FF91C34C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M05_L00
M05_L02:
       mov       eax,1
M05_L03:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L04:
       xor       eax,eax
       jmp       short M05_L03
M05_L05:
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
; Total bytes of code 149
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ContainsValueComparer()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonEqualityComparer
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       r14,[rcx+48]
       cmp       [rbx],bl
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass23_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r15+10]
       test      rdx,rdx
       je        near ptr M00_L10
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r15+8]
       mov       rdx,1A12B800A08
       mov       rdx,[rdx]
       cmp       [rcx],rsi
       jne       near ptr M00_L11
       cmp       rcx,rdx
       je        near ptr M00_L12
M00_L00:
       mov       rax,[rbx+28]
       test      rax,rax
       je        near ptr M00_L13
M00_L01:
       mov       rbx,[rax+8]
       mov       rcx,rbx
       mov       edx,[rcx+38]
       sub       edx,[rcx+40]
       je        near ptr M00_L23
       mov       edi,[rbx+44]
       xor       r14d,r14d
       jmp       short M00_L05
M00_L02:
       mov       rdx,7FF91CAE8F70
       call      qword ptr [7FF91C35C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M00_L07
M00_L03:
       call      qword ptr [7FF91C35FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L04:
       test      eax,eax
       mov       r14d,r13d
       jne       near ptr M00_L20
M00_L05:
       cmp       edi,[rbx+44]
       jne       near ptr M00_L21
       cmp       r14d,[rbx+38]
       jae       near ptr M00_L08
M00_L06:
       mov       rcx,[rbx+10]
       lea       edx,[r14+1]
       mov       r13d,edx
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L27
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        near ptr M00_L19
       mov       r14,[rcx+8]
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M00_L02
M00_L07:
       mov       rcx,[r15+8]
       mov       r8,[r15+10]
       cmp       [rcx],rsi
       jne       near ptr M00_L18
       cmp       r14,r8
       je        near ptr M00_L17
       test      r14,r14
       je        near ptr M00_L16
       test      r8,r8
       je        near ptr M00_L16
       mov       rcx,[r14+28]
       mov       rdx,[r8+28]
       cmp       rcx,rdx
       je        near ptr M00_L14
       test      rcx,rcx
       je        near ptr M00_L15
       test      rdx,rdx
       je        near ptr M00_L15
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L15
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       jne       near ptr M00_L03
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r11,[rdx]
       xor       r11,rax
       xor       rcx,[rdx+2]
       or        rcx,r11
       sete      al
       movzx     eax,al
       jmp       near ptr M00_L04
M00_L08:
       xor       ebx,ebx
M00_L09:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L10:
       call      qword ptr [7FF91C907390]
       mov       ecx,10B0
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C5777B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C5777B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C357840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C5777B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C357840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CB273A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CB273C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L00
M00_L12:
       mov       rdx,[r15+10]
       mov       rcx,rbx
       call      qword ptr [7FF91CA2DB00]
       mov       ebx,eax
       jmp       near ptr M00_L09
M00_L13:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+ValueCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FF91CB273D8]
       lea       rcx,[rbx+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       jmp       near ptr M00_L01
M00_L14:
       mov       eax,1
       jmp       near ptr M00_L04
M00_L15:
       xor       eax,eax
       jmp       near ptr M00_L04
M00_L16:
       xor       eax,eax
       jmp       near ptr M00_L04
M00_L17:
       mov       eax,1
       jmp       near ptr M00_L04
M00_L18:
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L19:
       cmp       r13d,[rbx+38]
       mov       r14d,r13d
       jb        near ptr M00_L06
       jmp       near ptr M00_L08
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L22
M00_L21:
       call      qword ptr [7FF91C57C150]
       int       3
M00_L22:
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L09
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1A12B800A30
       mov       rcx,[rcx]
       mov       [rbp-40],rcx
M00_L24:
       mov       rcx,[rbp-40]
       mov       r11,[rcx]
       mov       r11,7FF91C2A0B40
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L25
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2A0B48
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,r15
       mov       rax,offset DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary`2+<>c__DisplayClass23_0[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ContainsValue>b__0(System.__Canon)
       call      rax
       test      eax,eax
       je        short M00_L24
       mov       dword ptr [rbp-34],1
       jmp       short M00_L26
M00_L25:
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2A0B50
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L26:
       call      M00_L28
       jmp       near ptr M00_L22
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L29
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2A0B50
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1002
```
```assembly
; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       xor       r8d,r8d
       mov       [rsp+20],r8
       mov       r8,rdx
       mov       [rbp-9C],r8
       mov       rdx,rcx
       mov       [rbp-0A4],rdx
       xor       ecx,ecx
       mov       [rbp-0AC],rcx
       mov       r9d,0FFFFFFFF
       mov       [rbp-94],r9d
       lea       rcx,[rbp-90]
       call      qword ptr [7FF96DF65030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[rbp-9C]
       mov       rdx,[rbp-0A4]
       mov       rcx,[rbp-0AC]
       mov       r9d,[rbp-94]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rcx,[rbp-90]
       call      qword ptr [7FF96DF65038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,rbx
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
; Total bytes of code 166
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L02
       cmp       rcx,rdx
       je        near ptr M02_L12
       cmp       r8,20
       jb        near ptr M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
M02_L00:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        short M02_L07
M02_L01:
       xor       eax,eax
       vzeroupper
       ret
M02_L02:
       cmp       r8,4
       jae       short M02_L05
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L03
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L03:
       test      r8b,1
       je        short M02_L04
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L06
M02_L05:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L06:
       vzeroupper
       ret
M02_L07:
       add       rax,20
       cmp       r8,rax
       ja        short M02_L00
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L01
       jmp       short M02_L12
M02_L09:
       cmp       r8,10
       jb        short M02_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L01
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M02_L01
M02_L12:
       mov       eax,1
       vzeroupper
       ret
M02_L13:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L06
; Total bytes of code 297
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
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C355818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C355818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,1E1AA950008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       call      qword ptr [7FF91CB27630]
       int       3
; Total bytes of code 231
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FF91C355C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary`2+<>c__DisplayClass23_0[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ContainsValue>b__0(System.__Canon)
; 		return this.Values.Any(v => comparer.Equals(v, value));
; 		                            ^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M05_L01
M05_L00:
       mov       rcx,[rbx+8]
       mov       r8,[rbx+10]
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonEqualityComparer
       cmp       [rcx],rdx
       jne       short M05_L05
       cmp       rsi,r8
       je        short M05_L02
       test      rsi,rsi
       je        short M05_L04
       test      r8,r8
       je        short M05_L04
       mov       rcx,[rsi+28]
       mov       rdx,[r8+28]
       mov       r8d,4
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91C4C4B28]; System.String.Equals(System.String, System.String, System.StringComparison)
M05_L01:
       mov       rdx,7FF91CAE8F70
       call      qword ptr [7FF91C35C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M05_L00
M05_L02:
       mov       eax,1
M05_L03:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L04:
       xor       eax,eax
       jmp       short M05_L03
M05_L05:
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
; Total bytes of code 149
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ContainsValueComparer()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonEqualityComparer
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       r14,[rcx+48]
       cmp       [rbx],bl
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass23_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r15+10]
       test      rdx,rdx
       je        near ptr M00_L10
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r15+8]
       mov       rdx,259F2002A18
       mov       rdx,[rdx]
       cmp       [rcx],rsi
       jne       near ptr M00_L11
       cmp       rcx,rdx
       je        near ptr M00_L12
M00_L00:
       mov       rax,[rbx+28]
       test      rax,rax
       je        near ptr M00_L13
M00_L01:
       mov       rbx,[rax+8]
       mov       rcx,rbx
       mov       edx,[rcx+38]
       sub       edx,[rcx+40]
       je        near ptr M00_L23
       mov       edi,[rbx+44]
       xor       r14d,r14d
       jmp       short M00_L05
M00_L02:
       mov       rdx,7FF91CB5AE80
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M00_L07
M00_L03:
       call      qword ptr [7FF91C37FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L04:
       test      eax,eax
       mov       r14d,r13d
       jne       near ptr M00_L20
M00_L05:
       cmp       edi,[rbx+44]
       jne       near ptr M00_L21
       cmp       r14d,[rbx+38]
       jae       near ptr M00_L08
M00_L06:
       mov       rcx,[rbx+10]
       lea       edx,[r14+1]
       mov       r13d,edx
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L27
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        near ptr M00_L19
       mov       r14,[rcx+8]
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M00_L02
M00_L07:
       mov       rcx,[r15+8]
       mov       r8,[r15+10]
       cmp       [rcx],rsi
       jne       near ptr M00_L18
       cmp       r14,r8
       je        near ptr M00_L17
       test      r14,r14
       je        near ptr M00_L16
       test      r8,r8
       je        near ptr M00_L16
       mov       rcx,[r14+28]
       mov       rdx,[r8+28]
       cmp       rcx,rdx
       je        near ptr M00_L14
       test      rcx,rcx
       je        near ptr M00_L15
       test      rdx,rdx
       je        near ptr M00_L15
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L15
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       jne       near ptr M00_L03
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r11,[rdx]
       xor       r11,rax
       xor       rcx,[rdx+2]
       or        rcx,r11
       sete      al
       movzx     eax,al
       jmp       near ptr M00_L04
M00_L08:
       xor       ebx,ebx
M00_L09:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L10:
       call      qword ptr [7FF91C92F0A8]
       mov       ecx,10B0
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C377840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C377840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CB6C2D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CB6C2E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L00
M00_L12:
       mov       rdx,[r15+10]
       mov       rcx,rbx
       call      qword ptr [7FF91CB657A0]
       mov       ebx,eax
       jmp       near ptr M00_L09
M00_L13:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+ValueCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FF91CB6E988]
       lea       rcx,[rbx+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       jmp       near ptr M00_L01
M00_L14:
       mov       eax,1
       jmp       near ptr M00_L04
M00_L15:
       xor       eax,eax
       jmp       near ptr M00_L04
M00_L16:
       xor       eax,eax
       jmp       near ptr M00_L04
M00_L17:
       mov       eax,1
       jmp       near ptr M00_L04
M00_L18:
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L19:
       cmp       r13d,[rbx+38]
       mov       r14d,r13d
       jb        near ptr M00_L06
       jmp       near ptr M00_L08
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L22
M00_L21:
       call      qword ptr [7FF91C59C150]
       int       3
M00_L22:
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L09
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,259F2002A98
       mov       rcx,[rcx]
       mov       [rbp-40],rcx
M00_L24:
       mov       rcx,[rbp-40]
       mov       r11,[rcx]
       mov       r11,7FF91C2C0C40
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L25
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2C0C48
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,r15
       mov       rax,offset DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary`2+<>c__DisplayClass23_0[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ContainsValue>b__0(System.__Canon)
       call      rax
       test      eax,eax
       je        short M00_L24
       mov       dword ptr [rbp-34],1
       jmp       short M00_L26
M00_L25:
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2C0C50
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L26:
       call      M00_L28
       jmp       near ptr M00_L22
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L29
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2C0C50
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1002
```
```assembly
; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       xor       r8d,r8d
       mov       [rsp+20],r8
       mov       r8,rdx
       mov       [rbp-9C],r8
       mov       rdx,rcx
       mov       [rbp-0A4],rdx
       xor       ecx,ecx
       mov       [rbp-0AC],rcx
       mov       r9d,0FFFFFFFF
       mov       [rbp-94],r9d
       lea       rcx,[rbp-90]
       call      qword ptr [7FF96DF65030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[rbp-9C]
       mov       rdx,[rbp-0A4]
       mov       rcx,[rbp-0AC]
       mov       r9d,[rbp-94]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rcx,[rbp-90]
       call      qword ptr [7FF96DF65038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,rbx
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
; Total bytes of code 166
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L02
       cmp       rcx,rdx
       je        near ptr M02_L12
       cmp       r8,20
       jb        near ptr M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
M02_L00:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        short M02_L07
M02_L01:
       xor       eax,eax
       vzeroupper
       ret
M02_L02:
       cmp       r8,4
       jae       short M02_L05
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L03
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L03:
       test      r8b,1
       je        short M02_L04
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L06
M02_L05:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L06:
       vzeroupper
       ret
M02_L07:
       add       rax,20
       cmp       r8,rax
       ja        short M02_L00
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L01
       jmp       short M02_L12
M02_L09:
       cmp       r8,10
       jb        short M02_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L01
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M02_L01
M02_L12:
       mov       eax,1
       vzeroupper
       ret
M02_L13:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L06
; Total bytes of code 297
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
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C375818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C375818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M03_L00:
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
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,29A871A0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
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
M03_L04:
       call      qword ptr [7FF91CB6E268]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FF91C375C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary`2+<>c__DisplayClass23_0[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ContainsValue>b__0(System.__Canon)
; 		return this.Values.Any(v => comparer.Equals(v, value));
; 		                            ^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M05_L01
M05_L00:
       mov       rcx,[rbx+8]
       mov       r8,[rbx+10]
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonEqualityComparer
       cmp       [rcx],rdx
       jne       short M05_L05
       cmp       rsi,r8
       je        short M05_L02
       test      rsi,rsi
       je        short M05_L04
       test      r8,r8
       je        short M05_L04
       mov       rcx,[rsi+28]
       mov       rdx,[r8+28]
       mov       r8d,4
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91C4E4B28]; System.String.Equals(System.String, System.String, System.StringComparison)
M05_L01:
       mov       rdx,7FF91CB5AE80
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M05_L00
M05_L02:
       mov       eax,1
M05_L03:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L04:
       xor       eax,eax
       jmp       short M05_L03
M05_L05:
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
; Total bytes of code 149
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ContainsValueComparer()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonEqualityComparer
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       r14,[rcx+48]
       cmp       [rbx],bl
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass23_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r15+10]
       test      rdx,rdx
       je        near ptr M00_L10
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r15+8]
       mov       rdx,17711002A18
       mov       rdx,[rdx]
       cmp       [rcx],rsi
       jne       near ptr M00_L11
       cmp       rcx,rdx
       je        near ptr M00_L12
M00_L00:
       mov       rax,[rbx+28]
       test      rax,rax
       je        near ptr M00_L13
M00_L01:
       mov       rbx,[rax+8]
       mov       rcx,rbx
       mov       edx,[rcx+38]
       sub       edx,[rcx+40]
       je        near ptr M00_L23
       mov       edi,[rbx+44]
       xor       r14d,r14d
       jmp       short M00_L05
M00_L02:
       mov       rdx,7FF91CB4AE80
       call      qword ptr [7FF91C36C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M00_L07
M00_L03:
       call      qword ptr [7FF91C36FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L04:
       test      eax,eax
       mov       r14d,r13d
       jne       near ptr M00_L20
M00_L05:
       cmp       edi,[rbx+44]
       jne       near ptr M00_L21
       cmp       r14d,[rbx+38]
       jae       near ptr M00_L08
M00_L06:
       mov       rcx,[rbx+10]
       lea       edx,[r14+1]
       mov       r13d,edx
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L27
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        near ptr M00_L19
       mov       r14,[rcx+8]
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M00_L02
M00_L07:
       mov       rcx,[r15+8]
       mov       r8,[r15+10]
       cmp       [rcx],rsi
       jne       near ptr M00_L18
       cmp       r14,r8
       je        near ptr M00_L17
       test      r14,r14
       je        near ptr M00_L16
       test      r8,r8
       je        near ptr M00_L16
       mov       rcx,[r14+28]
       mov       rdx,[r8+28]
       cmp       rcx,rdx
       je        near ptr M00_L14
       test      rcx,rcx
       je        near ptr M00_L15
       test      rdx,rdx
       je        near ptr M00_L15
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L15
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       jne       near ptr M00_L03
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r11,[rdx]
       xor       r11,rax
       xor       rcx,[rdx+2]
       or        rcx,r11
       sete      al
       movzx     eax,al
       jmp       near ptr M00_L04
M00_L08:
       xor       ebx,ebx
M00_L09:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L10:
       call      qword ptr [7FF91C91F0A8]
       mov       ecx,10B0
       mov       rdx,7FF91C645548
       call      qword ptr [7FF91C5877B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C645548
       call      qword ptr [7FF91C5877B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C367840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C645548
       call      qword ptr [7FF91C5877B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C367840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CB5C2D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CB5C2E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L00
M00_L12:
       mov       rdx,[r15+10]
       mov       rcx,rbx
       call      qword ptr [7FF91CB557A0]
       mov       ebx,eax
       jmp       near ptr M00_L09
M00_L13:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+ValueCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FF91CB5E9A0]
       lea       rcx,[rbx+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       jmp       near ptr M00_L01
M00_L14:
       mov       eax,1
       jmp       near ptr M00_L04
M00_L15:
       xor       eax,eax
       jmp       near ptr M00_L04
M00_L16:
       xor       eax,eax
       jmp       near ptr M00_L04
M00_L17:
       mov       eax,1
       jmp       near ptr M00_L04
M00_L18:
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L19:
       cmp       r13d,[rbx+38]
       mov       r14d,r13d
       jb        near ptr M00_L06
       jmp       near ptr M00_L08
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L22
M00_L21:
       call      qword ptr [7FF91C58C150]
       int       3
M00_L22:
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L09
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,17711002A98
       mov       rcx,[rcx]
       mov       [rbp-40],rcx
M00_L24:
       mov       rcx,[rbp-40]
       mov       r11,[rcx]
       mov       r11,7FF91C2B0DC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L25
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2B0DD0
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,r15
       mov       rax,offset DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary`2+<>c__DisplayClass23_0[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ContainsValue>b__0(System.__Canon)
       call      rax
       test      eax,eax
       je        short M00_L24
       mov       dword ptr [rbp-34],1
       jmp       short M00_L26
M00_L25:
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2B0DD8
       call      qword ptr [r11]
       jmp       near ptr M00_L08
M00_L26:
       call      M00_L28
       jmp       near ptr M00_L22
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L29
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2B0DD8
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1002
```
```assembly
; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       xor       r8d,r8d
       mov       [rsp+20],r8
       mov       r8,rdx
       mov       [rbp-9C],r8
       mov       rdx,rcx
       mov       [rbp-0A4],rdx
       xor       ecx,ecx
       mov       [rbp-0AC],rcx
       mov       r9d,0FFFFFFFF
       mov       [rbp-94],r9d
       lea       rcx,[rbp-90]
       call      qword ptr [7FF96DF65030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[rbp-9C]
       mov       rdx,[rbp-0A4]
       mov       rcx,[rbp-0AC]
       mov       r9d,[rbp-94]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rcx,[rbp-90]
       call      qword ptr [7FF96DF65038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,rbx
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
; Total bytes of code 166
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L02
       cmp       rcx,rdx
       je        near ptr M02_L12
       cmp       r8,20
       jb        near ptr M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
M02_L00:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        short M02_L07
M02_L01:
       xor       eax,eax
       vzeroupper
       ret
M02_L02:
       cmp       r8,4
       jae       short M02_L05
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L03
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L03:
       test      r8b,1
       je        short M02_L04
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L06
M02_L05:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L06:
       vzeroupper
       ret
M02_L07:
       add       rax,20
       cmp       r8,rax
       ja        short M02_L00
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L01
       jmp       short M02_L12
M02_L09:
       cmp       r8,10
       jb        short M02_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L01
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M02_L01
M02_L12:
       mov       eax,1
       vzeroupper
       ret
M02_L13:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L06
; Total bytes of code 297
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
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C365818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C365818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M03_L00:
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
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,1B7A60B0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
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
M03_L04:
       call      qword ptr [7FF91CB5E268]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FF91C365C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary`2+<>c__DisplayClass23_0[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ContainsValue>b__0(System.__Canon)
; 		return this.Values.Any(v => comparer.Equals(v, value));
; 		                            ^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M05_L01
M05_L00:
       mov       rcx,[rbx+8]
       mov       r8,[rbx+10]
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonEqualityComparer
       cmp       [rcx],rdx
       jne       short M05_L05
       cmp       rsi,r8
       je        short M05_L02
       test      rsi,rsi
       je        short M05_L04
       test      r8,r8
       je        short M05_L04
       mov       rcx,[rsi+28]
       mov       rdx,[r8+28]
       mov       r8d,4
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91C4D4B28]; System.String.Equals(System.String, System.String, System.StringComparison)
M05_L01:
       mov       rdx,7FF91CB4AE80
       call      qword ptr [7FF91C36C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M05_L00
M05_L02:
       mov       eax,1
M05_L03:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L04:
       xor       eax,eax
       jmp       short M05_L03
M05_L05:
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
; Total bytes of code 149
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ContainsValueComparer()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonEqualityComparer
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       r14,[rcx+48]
       cmp       [rbx],bl
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass23_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r15+10]
       test      rdx,rdx
       je        near ptr M00_L12
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r15+8]
       mov       rdx,181AC000A20
       mov       rdx,[rdx]
       cmp       [rcx],rsi
       jne       near ptr M00_L13
       cmp       rcx,rdx
       je        near ptr M00_L14
M00_L00:
       mov       rax,[rbx+28]
       test      rax,rax
       je        near ptr M00_L15
M00_L01:
       mov       rcx,[rax+8]
       mov       edx,[rcx+38]
       sub       edx,[rcx+40]
       je        near ptr M00_L23
       mov       rbx,[rax+8]
       mov       edi,[rbx+44]
       xor       r14d,r14d
       jmp       short M00_L05
M00_L02:
       mov       rdx,7FF91CB5AF68
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M00_L07
M00_L03:
       call      qword ptr [7FF91C37FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L04:
       test      eax,eax
       mov       r14d,r13d
       jne       near ptr M00_L08
M00_L05:
       cmp       edi,[rbx+44]
       jne       near ptr M00_L22
       cmp       r14d,[rbx+38]
       jae       near ptr M00_L11
M00_L06:
       mov       rcx,[rbx+10]
       lea       edx,[r14+1]
       mov       r13d,edx
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L27
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        near ptr M00_L21
       mov       r14,[rcx+8]
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M00_L02
M00_L07:
       mov       rcx,[r15+8]
       mov       r8,[r15+10]
       cmp       [rcx],rsi
       jne       near ptr M00_L20
       cmp       r14,r8
       je        near ptr M00_L19
       test      r14,r14
       je        near ptr M00_L18
       test      r8,r8
       je        near ptr M00_L18
       mov       rcx,[r14+28]
       mov       rdx,[r8+28]
       cmp       rcx,rdx
       je        near ptr M00_L16
       test      rcx,rcx
       je        near ptr M00_L17
       test      rdx,rdx
       je        near ptr M00_L17
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L17
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       jne       near ptr M00_L03
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r11,[rdx]
       xor       r11,rax
       xor       rcx,[rdx+2]
       or        rcx,r11
       sete      al
       movzx     eax,al
       jmp       near ptr M00_L04
M00_L08:
       mov       dword ptr [rbp-34],1
M00_L09:
       mov       ebx,[rbp-34]
M00_L10:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L11:
       xor       ebx,ebx
       jmp       short M00_L10
M00_L12:
       call      qword ptr [7FF91C92F108]
       mov       ecx,10B0
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C377840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C377840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CB6C2D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CB6C2E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L00
M00_L14:
       mov       rdx,[r15+10]
       mov       rcx,rbx
       call      qword ptr [7FF91CB658D8]
       mov       ebx,eax
       jmp       near ptr M00_L10
M00_L15:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+ValueCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FF91CB6EA18]
       lea       rcx,[rbx+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       jmp       near ptr M00_L01
M00_L16:
       mov       eax,1
       jmp       near ptr M00_L04
M00_L17:
       xor       eax,eax
       jmp       near ptr M00_L04
M00_L18:
       xor       eax,eax
       jmp       near ptr M00_L04
M00_L19:
       mov       eax,1
       jmp       near ptr M00_L04
M00_L20:
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L21:
       cmp       r13d,[rbx+38]
       mov       r14d,r13d
       jb        near ptr M00_L06
       jmp       near ptr M00_L11
M00_L22:
       call      qword ptr [7FF91C59C150]
       int       3
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,181AC000AA0
       mov       rcx,[rcx]
       mov       [rbp-40],rcx
M00_L24:
       mov       rcx,[rbp-40]
       mov       r11,[rcx]
       mov       r11,7FF91C2C0C38
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L25
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2C0C40
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,r15
       mov       rax,offset DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary`2+<>c__DisplayClass23_0[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ContainsValue>b__0(System.__Canon)
       call      rax
       test      eax,eax
       je        short M00_L24
       mov       dword ptr [rbp-34],1
       jmp       short M00_L26
M00_L25:
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2C0C48
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L26:
       call      M00_L28
       jmp       near ptr M00_L09
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L29
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2C0C48
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 998
```
```assembly
; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       xor       r8d,r8d
       mov       [rsp+20],r8
       mov       r8,rdx
       mov       [rbp-9C],r8
       mov       rdx,rcx
       mov       [rbp-0A4],rdx
       xor       ecx,ecx
       mov       [rbp-0AC],rcx
       mov       r9d,0FFFFFFFF
       mov       [rbp-94],r9d
       lea       rcx,[rbp-90]
       call      qword ptr [7FF96DF65030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[rbp-9C]
       mov       rdx,[rbp-0A4]
       mov       rcx,[rbp-0AC]
       mov       r9d,[rbp-94]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rcx,[rbp-90]
       call      qword ptr [7FF96DF65038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,rbx
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
; Total bytes of code 166
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L02
       cmp       rcx,rdx
       je        near ptr M02_L12
       cmp       r8,20
       jb        near ptr M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
M02_L00:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        short M02_L07
M02_L01:
       xor       eax,eax
       vzeroupper
       ret
M02_L02:
       cmp       r8,4
       jae       short M02_L05
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L03
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L03:
       test      r8b,1
       je        short M02_L04
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L06
M02_L05:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L06:
       vzeroupper
       ret
M02_L07:
       add       rax,20
       cmp       r8,rax
       ja        short M02_L00
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L01
       jmp       short M02_L12
M02_L09:
       cmp       r8,10
       jb        short M02_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L01
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M02_L01
M02_L12:
       mov       eax,1
       vzeroupper
       ret
M02_L13:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L06
; Total bytes of code 297
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
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C375818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C375818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M03_L00:
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
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,1C22B0A0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
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
M03_L04:
       call      qword ptr [7FF91CB6E2E0]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FF91C375C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary`2+<>c__DisplayClass23_0[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ContainsValue>b__0(System.__Canon)
; 		return this.Values.Any(v => comparer.Equals(v, value));
; 		                            ^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M05_L01
M05_L00:
       mov       rcx,[rbx+8]
       mov       r8,[rbx+10]
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonEqualityComparer
       cmp       [rcx],rdx
       jne       short M05_L05
       cmp       rsi,r8
       je        short M05_L02
       test      rsi,rsi
       je        short M05_L04
       test      r8,r8
       je        short M05_L04
       mov       rcx,[rsi+28]
       mov       rdx,[r8+28]
       mov       r8d,4
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91C4E4B28]; System.String.Equals(System.String, System.String, System.StringComparison)
M05_L01:
       mov       rdx,7FF91CB5AF68
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M05_L00
M05_L02:
       mov       eax,1
M05_L03:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L04:
       xor       eax,eax
       jmp       short M05_L03
M05_L05:
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
; Total bytes of code 149
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ContainsValueComparer()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonEqualityComparer
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       r14,[rcx+48]
       cmp       [rbx],bl
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass23_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r15+10]
       test      rdx,rdx
       je        near ptr M00_L12
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r15+8]
       mov       rdx,20D3C800A20
       mov       rdx,[rdx]
       cmp       [rcx],rsi
       jne       near ptr M00_L13
       cmp       rcx,rdx
       je        near ptr M00_L14
M00_L00:
       mov       rax,[rbx+28]
       test      rax,rax
       je        near ptr M00_L15
M00_L01:
       mov       rcx,[rax+8]
       mov       edx,[rcx+38]
       sub       edx,[rcx+40]
       je        near ptr M00_L23
       mov       rbx,[rax+8]
       mov       edi,[rbx+44]
       xor       r14d,r14d
       jmp       short M00_L05
M00_L02:
       mov       rdx,7FF91CB3AF68
       call      qword ptr [7FF91C35C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M00_L07
M00_L03:
       call      qword ptr [7FF91C35FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L04:
       test      eax,eax
       mov       r14d,r13d
       jne       near ptr M00_L08
M00_L05:
       cmp       edi,[rbx+44]
       jne       near ptr M00_L22
       cmp       r14d,[rbx+38]
       jae       near ptr M00_L11
M00_L06:
       mov       rcx,[rbx+10]
       lea       edx,[r14+1]
       mov       r13d,edx
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L27
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        near ptr M00_L21
       mov       r14,[rcx+8]
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M00_L02
M00_L07:
       mov       rcx,[r15+8]
       mov       r8,[r15+10]
       cmp       [rcx],rsi
       jne       near ptr M00_L20
       cmp       r14,r8
       je        near ptr M00_L19
       test      r14,r14
       je        near ptr M00_L18
       test      r8,r8
       je        near ptr M00_L18
       mov       rcx,[r14+28]
       mov       rdx,[r8+28]
       cmp       rcx,rdx
       je        near ptr M00_L16
       test      rcx,rcx
       je        near ptr M00_L17
       test      rdx,rdx
       je        near ptr M00_L17
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L17
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       jne       near ptr M00_L03
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r11,[rdx]
       xor       r11,rax
       xor       rcx,[rdx+2]
       or        rcx,r11
       sete      al
       movzx     eax,al
       jmp       near ptr M00_L04
M00_L08:
       mov       dword ptr [rbp-34],1
M00_L09:
       mov       ebx,[rbp-34]
M00_L10:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L11:
       xor       ebx,ebx
       jmp       short M00_L10
M00_L12:
       call      qword ptr [7FF91C90F0D8]
       mov       ecx,10B0
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C5777B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C5777B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C357840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C5777B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C357840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CB4C2D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CB4C2E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L00
M00_L14:
       mov       rdx,[r15+10]
       mov       rcx,rbx
       call      qword ptr [7FF91CB458A8]
       mov       ebx,eax
       jmp       near ptr M00_L10
M00_L15:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+ValueCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FF91CB4EA00]
       lea       rcx,[rbx+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       jmp       near ptr M00_L01
M00_L16:
       mov       eax,1
       jmp       near ptr M00_L04
M00_L17:
       xor       eax,eax
       jmp       near ptr M00_L04
M00_L18:
       xor       eax,eax
       jmp       near ptr M00_L04
M00_L19:
       mov       eax,1
       jmp       near ptr M00_L04
M00_L20:
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L21:
       cmp       r13d,[rbx+38]
       mov       r14d,r13d
       jb        near ptr M00_L06
       jmp       near ptr M00_L11
M00_L22:
       call      qword ptr [7FF91C57C150]
       int       3
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20D3C800AA0
       mov       rcx,[rcx]
       mov       [rbp-40],rcx
M00_L24:
       mov       rcx,[rbp-40]
       mov       r11,[rcx]
       mov       r11,7FF91C2A0DC8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L25
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2A0DD0
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,r15
       mov       rax,offset DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary`2+<>c__DisplayClass23_0[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ContainsValue>b__0(System.__Canon)
       call      rax
       test      eax,eax
       je        short M00_L24
       mov       dword ptr [rbp-34],1
       jmp       short M00_L26
M00_L25:
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2A0DD8
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L26:
       call      M00_L28
       jmp       near ptr M00_L09
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L29
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2A0DD8
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 998
```
```assembly
; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       xor       r8d,r8d
       mov       [rsp+20],r8
       mov       r8,rdx
       mov       [rbp-9C],r8
       mov       rdx,rcx
       mov       [rbp-0A4],rdx
       xor       ecx,ecx
       mov       [rbp-0AC],rcx
       mov       r9d,0FFFFFFFF
       mov       [rbp-94],r9d
       lea       rcx,[rbp-90]
       call      qword ptr [7FF96DF65030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[rbp-9C]
       mov       rdx,[rbp-0A4]
       mov       rcx,[rbp-0AC]
       mov       r9d,[rbp-94]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rcx,[rbp-90]
       call      qword ptr [7FF96DF65038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,rbx
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
; Total bytes of code 166
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L02
       cmp       rcx,rdx
       je        near ptr M02_L12
       cmp       r8,20
       jb        near ptr M02_L09
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
M02_L00:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        short M02_L07
M02_L01:
       xor       eax,eax
       vzeroupper
       ret
M02_L02:
       cmp       r8,4
       jae       short M02_L05
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L03
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L03:
       test      r8b,1
       je        short M02_L04
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L06
M02_L05:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M02_L06:
       vzeroupper
       ret
M02_L07:
       add       rax,20
       cmp       r8,rax
       ja        short M02_L00
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M02_L01
       jmp       short M02_L12
M02_L09:
       cmp       r8,10
       jb        short M02_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L11
M02_L10:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M02_L01
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M02_L01
M02_L12:
       mov       eax,1
       vzeroupper
       ret
M02_L13:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L06
; Total bytes of code 297
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
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C355818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C355818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M03_L00:
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
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,24DBB840008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
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
M03_L04:
       call      qword ptr [7FF91CB4E268]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FF91C355C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary`2+<>c__DisplayClass23_0[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ContainsValue>b__0(System.__Canon)
; 		return this.Values.Any(v => comparer.Equals(v, value));
; 		                            ^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M05_L01
M05_L00:
       mov       rcx,[rbx+8]
       mov       r8,[rbx+10]
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonEqualityComparer
       cmp       [rcx],rdx
       jne       short M05_L05
       cmp       rsi,r8
       je        short M05_L02
       test      rsi,rsi
       je        short M05_L04
       test      r8,r8
       je        short M05_L04
       mov       rcx,[rsi+28]
       mov       rdx,[r8+28]
       mov       r8d,4
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91C4C4B28]; System.String.Equals(System.String, System.String, System.StringComparison)
M05_L01:
       mov       rdx,7FF91CB3AF68
       call      qword ptr [7FF91C35C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M05_L00
M05_L02:
       mov       eax,1
M05_L03:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L04:
       xor       eax,eax
       jmp       short M05_L03
M05_L05:
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
; Total bytes of code 149
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ContainsValueComparer()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonEqualityComparer
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       r14,[rcx+48]
       cmp       [rbx],bl
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass23_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r15+10]
       test      rdx,rdx
       je        near ptr M00_L12
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r15+8]
       mov       rdx,29A8E400A20
       mov       rdx,[rdx]
       cmp       [rcx],rsi
       jne       near ptr M00_L13
       cmp       rcx,rdx
       je        near ptr M00_L14
M00_L00:
       mov       rax,[rbx+28]
       test      rax,rax
       je        near ptr M00_L15
M00_L01:
       mov       rcx,[rax+8]
       mov       edx,[rcx+38]
       sub       edx,[rcx+40]
       je        near ptr M00_L23
       mov       rbx,[rax+8]
       mov       edi,[rbx+44]
       xor       r14d,r14d
       jmp       short M00_L04
M00_L02:
       call      qword ptr [7FF91C37FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L03:
       test      eax,eax
       mov       r14d,r13d
       jne       near ptr M00_L08
M00_L04:
       cmp       edi,[rbx+44]
       jne       near ptr M00_L22
       cmp       r14d,[rbx+38]
       jae       near ptr M00_L11
M00_L05:
       mov       rcx,[rbx+10]
       lea       edx,[r14+1]
       mov       r13d,edx
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L27
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        near ptr M00_L21
       mov       r14,[rcx+8]
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+18]
       test      r11,r11
       je        near ptr M00_L07
M00_L06:
       mov       rcx,[r15+8]
       mov       r8,[r15+10]
       cmp       [rcx],rsi
       jne       near ptr M00_L20
       cmp       r14,r8
       je        near ptr M00_L19
       test      r14,r14
       je        near ptr M00_L18
       test      r8,r8
       je        near ptr M00_L18
       mov       rcx,[r14+28]
       mov       rdx,[r8+28]
       cmp       rcx,rdx
       je        near ptr M00_L16
       test      rcx,rcx
       je        near ptr M00_L17
       test      rdx,rdx
       je        near ptr M00_L17
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L17
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       jne       near ptr M00_L02
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r11,[rdx]
       xor       r11,rax
       xor       rcx,[rdx+2]
       or        rcx,r11
       sete      al
       movzx     eax,al
       jmp       near ptr M00_L03
M00_L07:
       mov       rdx,7FF91CB7F488
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M00_L06
M00_L08:
       mov       dword ptr [rbp-34],1
M00_L09:
       mov       ebx,[rbp-34]
M00_L10:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L11:
       xor       ebx,ebx
       jmp       short M00_L10
M00_L12:
       call      qword ptr [7FF91C92F0D8]
       mov       ecx,10B0
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C377840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C377840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CB5C2D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CB5C2E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L00
M00_L14:
       mov       rdx,[r15+10]
       mov       rcx,rbx
       call      qword ptr [7FF91CB570F0]
       mov       ebx,eax
       jmp       near ptr M00_L10
M00_L15:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+ValueCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FF91CB5F768]
       lea       rcx,[rbx+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       jmp       near ptr M00_L01
M00_L16:
       mov       eax,1
       jmp       near ptr M00_L03
M00_L17:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L18:
       xor       eax,eax
       jmp       near ptr M00_L03
M00_L19:
       mov       eax,1
       jmp       near ptr M00_L03
M00_L20:
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L21:
       cmp       r13d,[rbx+38]
       mov       r14d,r13d
       jb        near ptr M00_L05
       jmp       near ptr M00_L11
M00_L22:
       call      qword ptr [7FF91C59C150]
       int       3
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,29A8E400B00
       mov       rcx,[rcx]
       mov       [rbp-40],rcx
M00_L24:
       mov       rcx,[rbp-40]
       mov       r11,[rcx]
       mov       r11,7FF91C2C0E68
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L25
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2C0E70
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,r15
       mov       rax,offset DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary`2+<>c__DisplayClass23_0[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ContainsValue>b__0(System.__Canon)
       call      rax
       test      eax,eax
       je        short M00_L24
       mov       dword ptr [rbp-34],1
       jmp       short M00_L26
M00_L25:
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2C0E78
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L26:
       call      M00_L28
       jmp       near ptr M00_L09
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L29
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2C0E78
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 1005
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M01_L04
       cmp       rcx,rdx
       je        near ptr M01_L13
       cmp       r8,20
       jb        short M01_L02
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        near ptr M01_L09
M01_L00:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       je        near ptr M01_L08
M01_L01:
       xor       eax,eax
       vzeroupper
       ret
M01_L02:
       cmp       r8,10
       jae       near ptr M01_L10
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M01_L03:
       vzeroupper
       ret
M01_L04:
       cmp       r8,4
       jae       short M01_L07
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M01_L05
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M01_L05:
       test      r8b,1
       je        short M01_L06
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M01_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L07:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
       jmp       short M01_L03
M01_L08:
       add       rax,20
       cmp       r8,rax
       ja        near ptr M01_L00
M01_L09:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       near ptr M01_L01
       jmp       short M01_L13
M01_L10:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M01_L12
       vmovups   xmm0,[rcx]
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M01_L01
M01_L11:
       add       rax,10
       cmp       r8,rax
       jbe       short M01_L12
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M01_L01
       jmp       short M01_L11
M01_L12:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       near ptr M01_L01
M01_L13:
       mov       eax,1
       vzeroupper
       ret
; Total bytes of code 337
```
```assembly
; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       mov       rbx,rcx
       mov       rsi,rdx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       r8,rsp
       mov       [rbp-58],r8
       mov       r8,rbp
       mov       [rbp-48],r8
       xor       r8d,r8d
       mov       [rsp+20],r8
       mov       r8,rsi
       mov       rdx,rbx
       xor       ecx,ecx
       mov       r9d,0FFFFFFFF
       mov       rax,7FF91C450458
       mov       [rbp-60],rax
       lea       rax,[M02_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF97BF9B800
       call      rax
M02_L00:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF97C2B39A0],0
       je        short M02_L01
       call      qword ptr [7FF97C2A1648]; CORINFO_HELP_STOP_FOR_GC
M02_L01:
       mov       rcx,[rbp-68]
       mov       [rdi+8],rcx
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
; Total bytes of code 174
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
       je        near ptr M03_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M03_L01
       test      rsi,rsi
       je        short M03_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M03_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C375818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C375818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M03_L00:
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
M03_L01:
       test      rsi,rsi
       je        short M03_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       rax,2DB0D540008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
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
M03_L04:
       call      qword ptr [7FF91CB5EA48]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FF91C375C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary`2+<>c__DisplayClass23_0[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ContainsValue>b__0(System.__Canon)
; 		return this.Values.Any(v => comparer.Equals(v, value));
; 		                            ^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M05_L01
M05_L00:
       mov       rcx,[rbx+8]
       mov       r8,[rbx+10]
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonEqualityComparer
       cmp       [rcx],rdx
       jne       short M05_L05
       cmp       rsi,r8
       je        short M05_L02
       test      rsi,rsi
       je        short M05_L04
       test      r8,r8
       je        short M05_L04
       mov       rcx,[rsi+28]
       mov       rdx,[r8+28]
       mov       r8d,4
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91C4E4B28]; System.String.Equals(System.String, System.String, System.StringComparison)
M05_L01:
       mov       rdx,7FF91CB7F488
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M05_L00
M05_L02:
       mov       eax,1
M05_L03:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L04:
       xor       eax,eax
       jmp       short M05_L03
M05_L05:
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
; Total bytes of code 149
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ContainsValueComparer()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       rsi,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonEqualityComparer
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rbp+10]
       mov       r14,[rcx+48]
       cmp       [rbx],bl
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass23_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r15+10]
       test      rdx,rdx
       je        near ptr M00_L12
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r15+8]
       mov       rdx,1568FC00AC8
       mov       rdx,[rdx]
       cmp       [rcx],rsi
       jne       near ptr M00_L13
       cmp       rcx,rdx
       je        near ptr M00_L14
M00_L00:
       mov       rax,[rbx+28]
       test      rax,rax
       je        near ptr M00_L15
M00_L01:
       mov       rcx,[rax+8]
       mov       edx,[rcx+38]
       sub       edx,[rcx+40]
       je        near ptr M00_L23
       mov       rbx,[rax+8]
       mov       edi,[rbx+44]
       xor       r14d,r14d
       jmp       short M00_L05
M00_L02:
       mov       rdx,7FF91CC020D0
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M00_L07
M00_L03:
       call      qword ptr [7FF91C37FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L04:
       test      eax,eax
       mov       r14d,r13d
       jne       near ptr M00_L08
M00_L05:
       cmp       edi,[rbx+44]
       jne       near ptr M00_L22
       cmp       r14d,[rbx+38]
       jae       near ptr M00_L11
M00_L06:
       mov       rcx,[rbx+10]
       lea       edx,[r14+1]
       mov       r13d,edx
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L27
       mov       edx,r14d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        near ptr M00_L21
       mov       r14,[rcx+8]
       mov       rcx,[r15]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M00_L02
M00_L07:
       mov       rcx,[r15+8]
       mov       r8,[r15+10]
       cmp       [rcx],rsi
       jne       near ptr M00_L20
       cmp       r14,r8
       je        near ptr M00_L19
       test      r14,r14
       je        near ptr M00_L18
       test      r8,r8
       je        near ptr M00_L18
       mov       rcx,[r14+28]
       mov       rdx,[r8+28]
       cmp       rcx,rdx
       je        near ptr M00_L16
       test      rcx,rcx
       je        near ptr M00_L17
       test      rdx,rdx
       je        near ptr M00_L17
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L17
       add       rcx,0C
       add       rdx,0C
       add       r8d,r8d
       cmp       r8,0A
       jne       near ptr M00_L03
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r11,[rdx]
       xor       r11,rax
       xor       rcx,[rdx+2]
       or        rcx,r11
       sete      al
       movzx     eax,al
       jmp       near ptr M00_L04
M00_L08:
       mov       dword ptr [rbp-34],1
M00_L09:
       mov       ebx,[rbp-34]
M00_L10:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L11:
       xor       ebx,ebx
       jmp       short M00_L10
M00_L12:
       call      qword ptr [7FF91C92F0A8]
       mov       ecx,10B0
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C377840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C377840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CA64F60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CA64F78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M00_L00
M00_L14:
       mov       rdx,[r15+10]
       mov       rcx,rbx
       call      qword ptr [7FF91CBADE48]
       mov       ebx,eax
       jmp       near ptr M00_L10
M00_L15:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+ValueCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FF91CBAFB40]
       lea       rcx,[rbx+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       jmp       near ptr M00_L01
M00_L16:
       mov       eax,1
       jmp       near ptr M00_L04
M00_L17:
       xor       eax,eax
       jmp       near ptr M00_L04
M00_L18:
       xor       eax,eax
       jmp       near ptr M00_L04
M00_L19:
       mov       eax,1
       jmp       near ptr M00_L04
M00_L20:
       mov       rdx,r14
       call      qword ptr [r11]
       jmp       near ptr M00_L04
M00_L21:
       cmp       r13d,[rbx+38]
       mov       r14d,r13d
       jb        near ptr M00_L06
       jmp       near ptr M00_L11
M00_L22:
       call      qword ptr [7FF91C59C150]
       int       3
M00_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1568FC00B08
       mov       rcx,[rcx]
       mov       [rbp-40],rcx
M00_L24:
       mov       rcx,[rbp-40]
       mov       r11,[rcx]
       mov       r11,7FF91C2C1100
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L25
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2C1108
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,r15
       mov       rax,offset DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary`2+<>c__DisplayClass23_0[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ContainsValue>b__0(System.__Canon)
       call      rax
       test      eax,eax
       je        short M00_L24
       mov       dword ptr [rbp-34],1
       jmp       short M00_L26
M00_L25:
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2C1110
       call      qword ptr [r11]
       jmp       near ptr M00_L11
M00_L26:
       call      M00_L28
       jmp       near ptr M00_L09
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       qword ptr [rbp-40],0
       je        short M00_L29
       mov       rcx,[rbp-40]
       mov       r11,7FF91C2C1110
       call      qword ptr [r11]
M00_L29:
       nop
       add       rsp,28
       ret
; Total bytes of code 998
```
```assembly
; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       mov       rbx,rcx
       mov       rsi,rdx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       r8,rsp
       mov       [rbp-58],r8
       mov       r8,rbp
       mov       [rbp-48],r8
       xor       r8d,r8d
       mov       [rsp+20],r8
       mov       r8,rsi
       mov       rdx,rbx
       xor       ecx,ecx
       mov       r9d,0FFFFFFFF
       mov       rax,7FF91C450458
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF97BF9B800
       call      rax
M01_L00:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF97C2B39A0],0
       je        short M01_L01
       call      qword ptr [7FF97C2A1648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rcx,[rbp-68]
       mov       [rdi+8],rcx
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
; Total bytes of code 174
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L01
       cmp       rcx,rdx
       je        near ptr M02_L13
       cmp       r8,20
       jae       near ptr M02_L07
       cmp       r8,10
       jae       near ptr M02_L10
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       vzeroupper
       ret
M02_L01:
       cmp       r8,4
       jae       short M02_L06
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       jne       short M02_L04
M02_L02:
       test      r8b,1
       jne       short M02_L05
M02_L03:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L04:
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
       jmp       short M02_L02
M02_L05:
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
       jmp       short M02_L03
M02_L06:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L09
M02_L08:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L14
       add       rax,20
       cmp       r8,rax
       ja        short M02_L08
M02_L09:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       short M02_L14
       jmp       short M02_L13
M02_L10:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L12
M02_L11:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L14
       add       rax,10
       cmp       r8,rax
       ja        short M02_L11
M02_L12:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L14
M02_L13:
       mov       eax,1
       vzeroupper
       ret
M02_L14:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 295
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
       je        near ptr M03_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M03_L00
       test      rbx,rbx
       je        near ptr M03_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M03_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M03_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C375818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C375818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L00:
       test      rbx,rbx
       je        short M03_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L02
M03_L01:
       mov       rax,1970EC30008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L04:
       call      qword ptr [7FF91CBAE688]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FF91C375C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary`2+<>c__DisplayClass23_0[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<ContainsValue>b__0(System.__Canon)
; 		return this.Values.Any(v => comparer.Equals(v, value));
; 		                            ^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+18]
       test      r11,r11
       je        short M05_L01
M05_L00:
       mov       rcx,[rbx+8]
       mov       r8,[rbx+10]
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Comparers.PersonEqualityComparer
       cmp       [rcx],rdx
       jne       short M05_L05
       cmp       rsi,r8
       je        short M05_L02
       test      rsi,rsi
       je        short M05_L04
       test      r8,r8
       je        short M05_L04
       mov       rcx,[rsi+28]
       mov       rdx,[r8+28]
       mov       r8d,4
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91C4E4B28]; System.String.Equals(System.String, System.String, System.StringComparison)
M05_L01:
       mov       rdx,7FF91CC020D0
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M05_L00
M05_L02:
       mov       eax,1
M05_L03:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L04:
       xor       eax,eax
       jmp       short M05_L03
M05_L05:
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
; Total bytes of code 149
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ContainsValue()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       mov       rbp,rdi
       cmp       [rsi],sil
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass23_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+8],rcx
       lea       rcx,[r14+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       test      rdx,rdx
       je        short M00_L04
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[r14+10]
       mov       rbp,[rsi+10]
       test      rdi,rdi
       je        near ptr M00_L05
       xor       r14d,r14d
       cmp       dword ptr [rsi+38],0
       jle       short M00_L02
M00_L00:
       cmp       r14d,[rbp+8]
       jae       near ptr M00_L10
       lea       rcx,[r14+r14*2]
       lea       rcx,[rbp+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M00_L01
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L01
       mov       rdx,rdi
       mov       r11,7FF91C290C20
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L09
M00_L01:
       inc       r14d
       cmp       r14d,[rsi+38]
       jl        short M00_L00
M00_L02:
       xor       eax,eax
M00_L03:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L04:
       call      qword ptr [7FF91C8FF108]
       mov       ecx,10B0
       mov       rdx,7FF91C625548
       call      qword ptr [7FF91C5677B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C625548
       call      qword ptr [7FF91C5677B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C347840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C625548
       call      qword ptr [7FF91C5677B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C347840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CB3C048]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CB3C060]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       xor       eax,eax
       jmp       short M00_L08
M00_L06:
       cmp       eax,[rbp+8]
       jae       short M00_L10
       lea       rcx,[rax+rax*2]
       cmp       dword ptr [rbp+rcx*8+24],0FFFFFFFF
       jl        short M00_L07
       lea       rcx,[rax+rax*2]
       cmp       qword ptr [rbp+rcx*8+18],0
       je        short M00_L09
M00_L07:
       inc       eax
M00_L08:
       cmp       eax,[rsi+38]
       jl        short M00_L06
       jmp       near ptr M00_L02
M00_L09:
       mov       eax,1
       jmp       near ptr M00_L03
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 406
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
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C345818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C345818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,242CB040008
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
       call      qword ptr [7FF91CB3E250]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ContainsValue()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       mov       rbp,rdi
       cmp       [rsi],sil
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass23_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+8],rcx
       lea       rcx,[r14+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       test      rdx,rdx
       je        short M00_L04
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[r14+10]
       mov       rbp,[rsi+10]
       test      rdi,rdi
       je        near ptr M00_L05
       xor       r14d,r14d
       cmp       dword ptr [rsi+38],0
       jle       short M00_L02
M00_L00:
       cmp       r14d,[rbp+8]
       jae       near ptr M00_L10
       lea       rcx,[r14+r14*2]
       lea       rcx,[rbp+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M00_L01
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L01
       mov       rdx,rdi
       mov       r11,7FF91C2B0B18
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L09
M00_L01:
       inc       r14d
       cmp       r14d,[rsi+38]
       jl        short M00_L00
M00_L02:
       xor       eax,eax
M00_L03:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L04:
       call      qword ptr [7FF91C917390]
       mov       ecx,10B0
       mov       rdx,7FF91C645548
       call      qword ptr [7FF91C5877B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C645548
       call      qword ptr [7FF91C5877B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C367840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C645548
       call      qword ptr [7FF91C5877B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C367840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CB371E0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CB371F8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       xor       eax,eax
       jmp       short M00_L08
M00_L06:
       cmp       eax,[rbp+8]
       jae       short M00_L10
       lea       rcx,[rax+rax*2]
       cmp       dword ptr [rbp+rcx*8+24],0FFFFFFFF
       jl        short M00_L07
       lea       rcx,[rax+rax*2]
       cmp       qword ptr [rbp+rcx*8+18],0
       je        short M00_L09
M00_L07:
       inc       eax
M00_L08:
       cmp       eax,[rsi+38]
       jl        short M00_L06
       jmp       near ptr M00_L02
M00_L09:
       mov       eax,1
       jmp       near ptr M00_L03
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 406
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
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C365818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C365818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
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
       mov       rax,1B6BB730008
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
       call      qword ptr [7FF91CB37498]
       int       3
; Total bytes of code 231
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ContainsValue()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       mov       rbp,rdi
       cmp       [rsi],sil
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass23_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+8],rcx
       lea       rcx,[r14+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       test      rdx,rdx
       je        short M00_L04
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[r14+10]
       mov       rbp,[rsi+10]
       test      rdi,rdi
       je        near ptr M00_L05
       xor       r14d,r14d
       cmp       dword ptr [rsi+38],0
       jle       short M00_L02
M00_L00:
       cmp       r14d,[rbp+8]
       jae       near ptr M00_L10
       lea       rcx,[r14+r14*2]
       lea       rcx,[rbp+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M00_L01
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L01
       mov       rdx,rdi
       mov       r11,7FF91C2C0C18
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L09
M00_L01:
       inc       r14d
       cmp       r14d,[rsi+38]
       jl        short M00_L00
M00_L02:
       xor       eax,eax
M00_L03:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L04:
       call      qword ptr [7FF91C92F0A8]
       mov       ecx,10B0
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C377840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C377840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CB6C1B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CB6C1C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       xor       eax,eax
       jmp       short M00_L08
M00_L06:
       cmp       eax,[rbp+8]
       jae       short M00_L10
       lea       rcx,[rax+rax*2]
       cmp       dword ptr [rbp+rcx*8+24],0FFFFFFFF
       jl        short M00_L07
       lea       rcx,[rax+rax*2]
       cmp       qword ptr [rbp+rcx*8+18],0
       je        short M00_L09
M00_L07:
       inc       eax
M00_L08:
       cmp       eax,[rsi+38]
       jl        short M00_L06
       jmp       near ptr M00_L02
M00_L09:
       mov       eax,1
       jmp       near ptr M00_L03
M00_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 406
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
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C375818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C375818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2559FB50008
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
       call      qword ptr [7FF91CB6E1F0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ContainsValue()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       mov       rbp,rdi
       cmp       [rsi],sil
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass23_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+8],rcx
       lea       rcx,[r14+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       test      rdx,rdx
       je        near ptr M00_L05
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[r14+10]
       mov       rbp,[rsi+10]
       test      rdi,rdi
       je        near ptr M00_L06
       xor       r14d,r14d
       cmp       dword ptr [rsi+38],0
       jg        short M00_L04
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L03
       mov       rdx,rdi
       mov       r11,7FF91C2A0B18
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L10
M00_L03:
       inc       r14d
       cmp       r14d,[rsi+38]
       jge       short M00_L00
M00_L04:
       cmp       r14d,[rbp+8]
       jae       near ptr M00_L11
       lea       rcx,[r14+r14*2]
       lea       rcx,[rbp+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M00_L03
       jmp       short M00_L02
M00_L05:
       call      qword ptr [7FF91C907390]
       mov       ecx,10B0
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C5777B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C5777B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C357840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C5777B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C357840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CB27060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CB27078]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       xor       eax,eax
       jmp       short M00_L09
M00_L07:
       cmp       eax,[rbp+8]
       jae       short M00_L11
       lea       rcx,[rax+rax*2]
       cmp       dword ptr [rbp+rcx*8+24],0FFFFFFFF
       jl        short M00_L08
       lea       rcx,[rax+rax*2]
       cmp       qword ptr [rbp+rcx*8+18],0
       je        short M00_L10
M00_L08:
       inc       eax
M00_L09:
       cmp       eax,[rsi+38]
       jl        short M00_L07
       jmp       near ptr M00_L00
M00_L10:
       mov       eax,1
       jmp       near ptr M00_L01
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 412
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
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C355818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C355818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
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
       mov       rax,2474BC20008
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
       call      qword ptr [7FF91CB274B0]
       int       3
; Total bytes of code 231
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ContainsValue()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       mov       rbp,rdi
       cmp       [rsi],sil
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass23_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+8],rcx
       lea       rcx,[r14+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       test      rdx,rdx
       je        near ptr M00_L08
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[r14+10]
       mov       rbp,[rsi+10]
       test      rdi,rdi
       je        short M00_L02
       xor       r14d,r14d
       cmp       dword ptr [rsi+38],0
       jg        short M00_L06
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       xor       eax,eax
       cmp       dword ptr [rsi+38],0
       jle       short M00_L00
       mov       ecx,[rbp+8]
       jmp       short M00_L04
M00_L03:
       inc       eax
       cmp       eax,[rsi+38]
       jge       short M00_L00
M00_L04:
       cmp       eax,[rbp+8]
       jae       near ptr M00_L09
       lea       rcx,[rax+rax*2]
       lea       rcx,[rbp+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M00_L03
       cmp       qword ptr [rcx+8],0
       jne       short M00_L03
       jmp       short M00_L07
M00_L05:
       inc       r14d
       cmp       r14d,[rsi+38]
       jge       short M00_L00
M00_L06:
       cmp       r14d,[rbp+8]
       jae       near ptr M00_L09
       lea       rcx,[r14+r14*2]
       lea       rcx,[rbp+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M00_L05
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L05
       mov       rdx,rdi
       mov       r11,7FF91C2A0C10
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L05
M00_L07:
       mov       eax,1
       jmp       near ptr M00_L01
M00_L08:
       call      qword ptr [7FF91C90F0A8]
       mov       ecx,10B0
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C5777B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C5777B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C357840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C5777B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C357840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CB4C1B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CB4C1C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 411
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
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C355818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C355818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2C0F56F0008
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
       call      qword ptr [7FF91CB4E1F0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ContainsValue()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       mov       rbp,rdi
       cmp       [rsi],sil
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass23_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+8],rcx
       lea       rcx,[r14+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       test      rdx,rdx
       je        near ptr M00_L08
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[r14+10]
       mov       rbp,[rsi+10]
       test      rdi,rdi
       je        short M00_L02
       xor       r14d,r14d
       cmp       dword ptr [rsi+38],0
       jg        short M00_L06
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       xor       eax,eax
       cmp       dword ptr [rsi+38],0
       jle       short M00_L00
       mov       ecx,[rbp+8]
       jmp       short M00_L04
M00_L03:
       inc       eax
       cmp       eax,[rsi+38]
       jge       short M00_L00
M00_L04:
       cmp       eax,[rbp+8]
       jae       near ptr M00_L09
       lea       rcx,[rax+rax*2]
       lea       rcx,[rbp+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M00_L03
       cmp       qword ptr [rcx+8],0
       jne       short M00_L03
       jmp       short M00_L07
M00_L05:
       inc       r14d
       cmp       r14d,[rsi+38]
       jge       short M00_L00
M00_L06:
       cmp       r14d,[rbp+8]
       jae       near ptr M00_L09
       lea       rcx,[r14+r14*2]
       lea       rcx,[rbp+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M00_L05
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L05
       mov       rdx,rdi
       mov       r11,7FF91C2A0D90
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L05
M00_L07:
       mov       eax,1
       jmp       near ptr M00_L01
M00_L08:
       call      qword ptr [7FF91C90F108]
       mov       ecx,10B0
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C5777B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C5777B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C357840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C5777B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C357840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CB4C1B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CB4C1C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 411
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
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C355818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C355818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1DEDCC10008
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
       call      qword ptr [7FF91CB4E268]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ContainsValue()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       mov       rbp,rdi
       cmp       [rsi],sil
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass23_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+8],rcx
       lea       rcx,[r14+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       test      rdx,rdx
       je        near ptr M00_L08
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[r14+10]
       mov       rbp,[rsi+10]
       test      rdi,rdi
       je        short M00_L02
       xor       r14d,r14d
       cmp       dword ptr [rsi+38],0
       jg        short M00_L06
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       xor       eax,eax
       cmp       dword ptr [rsi+38],0
       jle       short M00_L00
       mov       ecx,[rbp+8]
       jmp       short M00_L04
M00_L03:
       inc       eax
       cmp       eax,[rsi+38]
       jge       short M00_L00
M00_L04:
       cmp       eax,[rbp+8]
       jae       near ptr M00_L09
       lea       rcx,[rax+rax*2]
       lea       rcx,[rbp+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M00_L03
       cmp       qword ptr [rcx+8],0
       jne       short M00_L03
       jmp       short M00_L07
M00_L05:
       inc       r14d
       cmp       r14d,[rsi+38]
       jge       short M00_L00
M00_L06:
       cmp       r14d,[rbp+8]
       jae       near ptr M00_L09
       lea       rcx,[r14+r14*2]
       lea       rcx,[rbp+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M00_L05
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L05
       mov       rdx,rdi
       mov       r11,7FF91C2A0E38
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L05
M00_L07:
       mov       eax,1
       jmp       near ptr M00_L01
M00_L08:
       call      qword ptr [7FF91C90F0C0]
       mov       ecx,10B0
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C5777B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C5777B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C357840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C635548
       call      qword ptr [7FF91C5777B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C357840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CA4D200]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CA4D218]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 411
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
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C355818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C355818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2C9DA820008
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
       call      qword ptr [7FF91CB4EA60]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ContainsValue()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       mov       rbp,rdi
       cmp       [rsi],sil
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.AutoDefaultDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+<>c__DisplayClass23_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+8],rcx
       lea       rcx,[r14+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       test      rdx,rdx
       je        near ptr M00_L08
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[r14+10]
       mov       rbp,[rsi+10]
       test      rdi,rdi
       je        short M00_L02
       xor       r14d,r14d
       cmp       dword ptr [rsi+38],0
       jg        short M00_L06
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       xor       eax,eax
       cmp       dword ptr [rsi+38],0
       jle       short M00_L00
       mov       ecx,[rbp+8]
       jmp       short M00_L04
M00_L03:
       inc       eax
       cmp       eax,[rsi+38]
       jge       short M00_L00
M00_L04:
       cmp       eax,[rbp+8]
       jae       near ptr M00_L09
       lea       rcx,[rax+rax*2]
       lea       rcx,[rbp+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M00_L03
       cmp       qword ptr [rcx+8],0
       jne       short M00_L03
       jmp       short M00_L07
M00_L05:
       inc       r14d
       cmp       r14d,[rsi+38]
       jge       short M00_L00
M00_L06:
       cmp       r14d,[rbp+8]
       jae       near ptr M00_L09
       lea       rcx,[r14+r14*2]
       lea       rcx,[rbp+rcx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M00_L05
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M00_L05
       mov       rdx,rdi
       mov       r11,7FF91C2910C0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L05
M00_L07:
       mov       eax,1
       jmp       near ptr M00_L01
M00_L08:
       call      qword ptr [7FF91C8FF108]
       mov       ecx,10B0
       mov       rdx,7FF91C625548
       call      qword ptr [7FF91C5677B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C625548
       call      qword ptr [7FF91C5677B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C347840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C625548
       call      qword ptr [7FF91C5677B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C347840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CA34ED0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CA34EE8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 411
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
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C345818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C345818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,30374230008
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
       call      qword ptr [7FF91CB7ED90]
       int       3
; Total bytes of code 235
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.GetValueOrDefault()
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
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,[rbx+48]
       mov       rdi,[rcx+28]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L09
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L06
       mov       rbp,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [rbp],rcx
       jne       near ptr M00_L10
       lea       rcx,[rdi+0C]
       mov       [rsp+30],rcx
       mov       ecx,15051505
       mov       edx,15051505
       mov       r11,[rsp+30]
       mov       eax,[rdi+8]
       cmp       eax,2
       jle       short M00_L01
M00_L00:
       add       eax,0FFFFFFFC
       mov       r8d,ecx
       rol       r8d,5
       add       ecx,r8d
       xor       ecx,[r11]
       mov       r8d,edx
       rol       r8d,5
       add       edx,r8d
       xor       edx,[r11+4]
       add       r11,8
       cmp       eax,2
       jg        short M00_L00
M00_L01:
       test      eax,eax
       jle       short M00_L02
       mov       eax,edx
       rol       eax,5
       add       eax,edx
       mov       edx,eax
       xor       edx,[r11]
M00_L02:
       imul      r14d,edx,5D588B65
       add       r14d,ecx
       xor       ecx,ecx
       mov       [rsp+30],rcx
M00_L03:
       mov       rdx,[rsi+8]
       mov       ecx,r14d
       imul      rcx,[rsi+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L16
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r13,[rsi+10]
       xor       r12d,r12d
       dec       r15d
       mov       eax,[r13+8]
       mov       [rsp+24],eax
       cmp       eax,r15d
       jbe       short M00_L06
M00_L04:
       mov       edx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       r15,[r13+rdx*8+10]
       cmp       [r15+10],r14d
       je        near ptr M00_L11
M00_L05:
       mov       r15d,[r15+14]
       inc       r12d
       mov       eax,[rsp+24]
       cmp       eax,r12d
       jb        near ptr M00_L12
       cmp       eax,r15d
       ja        short M00_L04
M00_L06:
       xor       r15d,r15d
M00_L07:
       test      r15,r15
       jne       near ptr M00_L14
       cmp       qword ptr [rsi+50],0
       jne       near ptr M00_L15
       mov       rbp,[rsi+48]
M00_L08:
       mov       [rsp+28],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L09:
       call      qword ptr [7FF91C8FF0A8]
       mov       ecx,0FD4
       mov       rdx,7FF91C625548
       call      qword ptr [7FF91C5677B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C625548
       call      qword ptr [7FF91C5677B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C347840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C625548
       call      qword ptr [7FF91C5677B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C347840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CB3C108]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CB3C120]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FF91C290DA0
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rdx,[r15]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FF91C290DA8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L13
       jmp       near ptr M00_L05
M00_L12:
       call      qword ptr [7FF91C567A20]
       int       3
M00_L13:
       add       r15,8
       jmp       near ptr M00_L07
M00_L14:
       mov       rbp,[r15]
       jmp       near ptr M00_L08
M00_L15:
       mov       rax,[rsi+50]
       mov       rdx,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbp,rax
       jmp       near ptr M00_L08
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
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
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C345818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C345818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,232911A0008
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
       call      qword ptr [7FF91CB3E130]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.GetValueOrDefault()
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
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,[rbx+48]
       mov       rdi,[rcx+28]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L08
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L05
       mov       rbp,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [rbp],rcx
       jne       near ptr M00_L09
       lea       rcx,[rdi+0C]
       mov       [rsp+30],rcx
       mov       ecx,15051505
       mov       edx,15051505
       mov       r11,[rsp+30]
       mov       eax,[rdi+8]
       cmp       eax,2
       jle       short M00_L01
M00_L00:
       add       eax,0FFFFFFFC
       mov       r8d,ecx
       rol       r8d,5
       add       ecx,r8d
       xor       ecx,[r11]
       mov       r8d,edx
       rol       r8d,5
       add       edx,r8d
       xor       edx,[r11+4]
       add       r11,8
       cmp       eax,2
       jg        short M00_L00
M00_L01:
       test      eax,eax
       jle       short M00_L02
       mov       eax,edx
       rol       eax,5
       add       eax,edx
       mov       edx,eax
       xor       edx,[r11]
M00_L02:
       imul      r14d,edx,5D588B65
       add       r14d,ecx
       xor       ecx,ecx
       mov       [rsp+30],rcx
M00_L03:
       mov       rdx,[rsi+8]
       mov       ecx,r14d
       imul      rcx,[rsi+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L15
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r13,[rsi+10]
       xor       r12d,r12d
       dec       r15d
M00_L04:
       cmp       [r13+8],r15d
       ja        near ptr M00_L10
M00_L05:
       xor       r15d,r15d
M00_L06:
       test      r15,r15
       jne       near ptr M00_L13
       cmp       qword ptr [rsi+50],0
       jne       near ptr M00_L14
       mov       rbp,[rsi+48]
M00_L07:
       mov       [rsp+28],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L08:
       call      qword ptr [7FF91C93F0D8]
       mov       ecx,0FD4
       mov       rdx,7FF91C665548
       call      qword ptr [7FF91C5A77B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C665548
       call      qword ptr [7FF91C5A77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C387840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C665548
       call      qword ptr [7FF91C5A77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C387840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CB77FA8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CB77FC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FF91C2D0D98
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       edx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       r15,[r13+rdx*8+10]
       cmp       [r15+10],r14d
       jne       short M00_L11
       mov       rdx,[r15]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FF91C2D0DA0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L12
M00_L11:
       mov       r15d,[r15+14]
       inc       r12d
       cmp       [r13+8],r12d
       jae       near ptr M00_L04
       call      qword ptr [7FF91C5A7A20]
       int       3
M00_L12:
       add       r15,8
       jmp       near ptr M00_L06
M00_L13:
       mov       rbp,[r15]
       jmp       near ptr M00_L07
M00_L14:
       mov       rax,[rsi+50]
       mov       rdx,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbp,rax
       jmp       near ptr M00_L07
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
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
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C385818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C385818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2BFF3F80008
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
       call      qword ptr [7FF91CB7E160]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.GetValueOrDefault()
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
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,[rbx+48]
       mov       rdi,[rcx+28]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L08
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L05
       mov       rbp,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [rbp],rcx
       jne       near ptr M00_L09
       lea       rcx,[rdi+0C]
       mov       [rsp+30],rcx
       mov       ecx,15051505
       mov       edx,15051505
       mov       r11,[rsp+30]
       mov       eax,[rdi+8]
       cmp       eax,2
       jle       short M00_L01
M00_L00:
       add       eax,0FFFFFFFC
       mov       r8d,ecx
       rol       r8d,5
       add       ecx,r8d
       xor       ecx,[r11]
       mov       r8d,edx
       rol       r8d,5
       add       edx,r8d
       xor       edx,[r11+4]
       add       r11,8
       cmp       eax,2
       jg        short M00_L00
M00_L01:
       test      eax,eax
       jle       short M00_L02
       mov       eax,edx
       rol       eax,5
       add       eax,edx
       mov       edx,eax
       xor       edx,[r11]
M00_L02:
       imul      r14d,edx,5D588B65
       add       r14d,ecx
       xor       ecx,ecx
       mov       [rsp+30],rcx
M00_L03:
       mov       rdx,[rsi+8]
       mov       ecx,r14d
       imul      rcx,[rsi+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L15
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r13,[rsi+10]
       xor       r12d,r12d
       dec       r15d
M00_L04:
       cmp       [r13+8],r15d
       ja        near ptr M00_L10
M00_L05:
       xor       r15d,r15d
M00_L06:
       test      r15,r15
       jne       near ptr M00_L13
       cmp       qword ptr [rsi+50],0
       jne       near ptr M00_L14
       mov       rbp,[rsi+48]
M00_L07:
       mov       [rsp+28],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L08:
       call      qword ptr [7FF91C91EBF8]
       mov       ecx,0FD4
       mov       rdx,7FF91C645548
       call      qword ptr [7FF91C5877B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C645548
       call      qword ptr [7FF91C5877B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C367840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C645548
       call      qword ptr [7FF91C5877B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C367840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CB4C3D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CB4C3F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FF91C2B0DA0
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       edx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       r15,[r13+rdx*8+10]
       cmp       [r15+10],r14d
       jne       short M00_L11
       mov       rdx,[r15]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FF91C2B0DA8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L12
M00_L11:
       mov       r15d,[r15+14]
       inc       r12d
       cmp       [r13+8],r12d
       jae       near ptr M00_L04
       call      qword ptr [7FF91C587A20]
       int       3
M00_L12:
       add       r15,8
       jmp       near ptr M00_L06
M00_L13:
       mov       rbp,[r15]
       jmp       near ptr M00_L07
M00_L14:
       mov       rax,[rsi+50]
       mov       rdx,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbp,rax
       jmp       near ptr M00_L07
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
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
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C365818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C365818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,234AFA90008
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
       call      qword ptr [7FF91CB4E118]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.GetValueOrDefault()
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
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,[rbx+48]
       mov       rdi,[rcx+28]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L08
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L05
       mov       rbp,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [rbp],rcx
       jne       near ptr M00_L09
       lea       rcx,[rdi+0C]
       mov       [rsp+30],rcx
       mov       ecx,15051505
       mov       edx,15051505
       mov       r11,[rsp+30]
       mov       eax,[rdi+8]
       cmp       eax,2
       jle       short M00_L01
M00_L00:
       add       eax,0FFFFFFFC
       mov       r8d,ecx
       rol       r8d,5
       add       ecx,r8d
       xor       ecx,[r11]
       mov       r8d,edx
       rol       r8d,5
       add       edx,r8d
       xor       edx,[r11+4]
       add       r11,8
       cmp       eax,2
       jg        short M00_L00
M00_L01:
       test      eax,eax
       jle       short M00_L02
       mov       eax,edx
       rol       eax,5
       add       eax,edx
       mov       edx,eax
       xor       edx,[r11]
M00_L02:
       imul      r14d,edx,5D588B65
       add       r14d,ecx
       xor       ecx,ecx
       mov       [rsp+30],rcx
M00_L03:
       mov       rdx,[rsi+8]
       mov       ecx,r14d
       imul      rcx,[rsi+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L15
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r13,[rsi+10]
       xor       r12d,r12d
       dec       r15d
M00_L04:
       cmp       [r13+8],r15d
       ja        near ptr M00_L10
M00_L05:
       xor       r15d,r15d
M00_L06:
       test      r15,r15
       jne       near ptr M00_L13
       cmp       qword ptr [rsi+50],0
       jne       near ptr M00_L14
       mov       rbp,[rsi+48]
M00_L07:
       mov       [rsp+28],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L08:
       call      qword ptr [7FF91C92F0D8]
       mov       ecx,0FD4
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C377840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C377840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CB6C1C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CB6C1E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FF91C2C0DA0
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       edx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       r15,[r13+rdx*8+10]
       cmp       [r15+10],r14d
       jne       short M00_L11
       mov       rdx,[r15]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FF91C2C0DA8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L12
M00_L11:
       mov       r15d,[r15+14]
       inc       r12d
       cmp       [r13+8],r12d
       jae       near ptr M00_L04
       call      qword ptr [7FF91C597A20]
       int       3
M00_L12:
       add       r15,8
       jmp       near ptr M00_L06
M00_L13:
       mov       rbp,[r15]
       jmp       near ptr M00_L07
M00_L14:
       mov       rax,[rsi+50]
       mov       rdx,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbp,rax
       jmp       near ptr M00_L07
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
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
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C375818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C375818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1FCB1260008
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
       call      qword ptr [7FF91CB6E160]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.GetValueOrDefault()
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
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,[rbx+48]
       mov       rdi,[rcx+28]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L09
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L06
       mov       rbp,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [rbp],rcx
       jne       near ptr M00_L10
       lea       rcx,[rdi+0C]
       mov       [rsp+30],rcx
       mov       ecx,15051505
       mov       edx,15051505
       mov       r11,[rsp+30]
       mov       eax,[rdi+8]
       cmp       eax,2
       jle       short M00_L01
M00_L00:
       add       eax,0FFFFFFFC
       mov       r8d,ecx
       rol       r8d,5
       add       ecx,r8d
       xor       ecx,[r11]
       mov       r8d,edx
       rol       r8d,5
       add       edx,r8d
       xor       edx,[r11+4]
       add       r11,8
       cmp       eax,2
       jg        short M00_L00
M00_L01:
       test      eax,eax
       jle       short M00_L02
       mov       eax,edx
       rol       eax,5
       add       eax,edx
       mov       edx,eax
       xor       edx,[r11]
M00_L02:
       imul      r14d,edx,5D588B65
       add       r14d,ecx
       xor       ecx,ecx
       mov       [rsp+30],rcx
M00_L03:
       mov       rdx,[rsi+8]
       mov       ecx,r14d
       imul      rcx,[rsi+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L16
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r13,[rsi+10]
       xor       r12d,r12d
       dec       r15d
       mov       eax,[r13+8]
       mov       [rsp+24],eax
       cmp       eax,r15d
       jbe       short M00_L06
M00_L04:
       mov       edx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       r15,[r13+rdx*8+10]
       cmp       [r15+10],r14d
       je        near ptr M00_L11
M00_L05:
       mov       r15d,[r15+14]
       inc       r12d
       mov       eax,[rsp+24]
       cmp       eax,r12d
       jb        near ptr M00_L12
       cmp       eax,r15d
       ja        short M00_L04
M00_L06:
       xor       r15d,r15d
M00_L07:
       test      r15,r15
       jne       near ptr M00_L14
       cmp       qword ptr [rsi+50],0
       jne       near ptr M00_L15
       mov       rbp,[rsi+48]
M00_L08:
       mov       [rsp+28],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L09:
       call      qword ptr [7FF91C8FF108]
       mov       ecx,0FD4
       mov       rdx,7FF91C625548
       call      qword ptr [7FF91C5677B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C625548
       call      qword ptr [7FF91C5677B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C347840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C625548
       call      qword ptr [7FF91C5677B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C347840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CB3C120]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CB3C138]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FF91C290D98
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L11:
       mov       rdx,[r15]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FF91C290DA0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L13
       jmp       near ptr M00_L05
M00_L12:
       call      qword ptr [7FF91C567A20]
       int       3
M00_L13:
       add       r15,8
       jmp       near ptr M00_L07
M00_L14:
       mov       rbp,[r15]
       jmp       near ptr M00_L08
M00_L15:
       mov       rax,[rsi+50]
       mov       rdx,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbp,rax
       jmp       near ptr M00_L08
M00_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
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
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C345818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C345818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22EEBDD0008
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
       call      qword ptr [7FF91CB3E1C0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.GetValueOrDefault()
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
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,[rbx+48]
       mov       rdi,[rcx+28]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L08
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L05
       mov       rbp,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [rbp],rcx
       jne       near ptr M00_L09
       lea       rcx,[rdi+0C]
       mov       [rsp+30],rcx
       mov       ecx,15051505
       mov       edx,15051505
       mov       r11,[rsp+30]
       mov       eax,[rdi+8]
       cmp       eax,2
       jle       short M00_L01
M00_L00:
       add       eax,0FFFFFFFC
       mov       r8d,ecx
       rol       r8d,5
       add       ecx,r8d
       xor       ecx,[r11]
       mov       r8d,edx
       rol       r8d,5
       add       edx,r8d
       xor       edx,[r11+4]
       add       r11,8
       cmp       eax,2
       jg        short M00_L00
M00_L01:
       test      eax,eax
       jle       short M00_L02
       mov       eax,edx
       rol       eax,5
       add       eax,edx
       mov       edx,eax
       xor       edx,[r11]
M00_L02:
       imul      r14d,edx,5D588B65
       add       r14d,ecx
       xor       ecx,ecx
       mov       [rsp+30],rcx
M00_L03:
       mov       rdx,[rsi+8]
       mov       ecx,r14d
       imul      rcx,[rsi+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L15
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r13,[rsi+10]
       xor       r12d,r12d
       dec       r15d
M00_L04:
       cmp       [r13+8],r15d
       ja        near ptr M00_L10
M00_L05:
       xor       r15d,r15d
M00_L06:
       test      r15,r15
       jne       near ptr M00_L13
       cmp       qword ptr [rsi+50],0
       jne       near ptr M00_L14
       mov       rbp,[rsi+48]
M00_L07:
       mov       [rsp+28],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L08:
       call      qword ptr [7FF91C93F0A8]
       mov       ecx,0FD4
       mov       rdx,7FF91C665548
       call      qword ptr [7FF91C5A77B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C665548
       call      qword ptr [7FF91C5A77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C387840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C665548
       call      qword ptr [7FF91C5A77B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C387840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CB7C120]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CB7C138]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FF91C2D0D98
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L10:
       mov       edx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       r15,[r13+rdx*8+10]
       cmp       [r15+10],r14d
       jne       short M00_L11
       mov       rdx,[r15]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FF91C2D0DA0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L12
M00_L11:
       mov       r15d,[r15+14]
       inc       r12d
       cmp       [r13+8],r12d
       jae       near ptr M00_L04
       call      qword ptr [7FF91C5A7A20]
       int       3
M00_L12:
       add       r15,8
       jmp       near ptr M00_L06
M00_L13:
       mov       rbp,[r15]
       jmp       near ptr M00_L07
M00_L14:
       mov       rax,[rsi+50]
       mov       rdx,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbp,rax
       jmp       near ptr M00_L07
M00_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
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
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C385818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C385818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,225EA630008
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
       call      qword ptr [7FF91CB7E160]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.GetValueOrDefault()
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
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,[rbx+48]
       mov       rdi,[rcx+28]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L09
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L06
       mov       rbp,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [rbp],rcx
       jne       near ptr M00_L11
       lea       rcx,[rdi+0C]
       mov       [rsp+30],rcx
       mov       ecx,15051505
       mov       edx,15051505
       mov       r11,[rsp+30]
       mov       eax,[rdi+8]
       cmp       eax,2
       jle       short M00_L01
M00_L00:
       add       eax,0FFFFFFFC
       mov       r8d,ecx
       rol       r8d,5
       add       ecx,r8d
       xor       ecx,[r11]
       mov       r8d,edx
       rol       r8d,5
       add       edx,r8d
       xor       edx,[r11+4]
       add       r11,8
       cmp       eax,2
       jg        short M00_L00
M00_L01:
       test      eax,eax
       jg        near ptr M00_L10
M00_L02:
       imul      r14d,edx,5D588B65
       add       r14d,ecx
       xor       ecx,ecx
       mov       [rsp+30],rcx
M00_L03:
       mov       rdx,[rsi+8]
       mov       ecx,r14d
       imul      rcx,[rsi+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L17
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r13,[rsi+10]
       xor       r12d,r12d
       dec       r15d
       mov       eax,[r13+8]
       mov       [rsp+24],eax
       cmp       eax,r15d
       jbe       short M00_L06
M00_L04:
       mov       edx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       r15,[r13+rdx*8+10]
       cmp       [r15+10],r14d
       je        near ptr M00_L12
M00_L05:
       mov       r15d,[r15+14]
       inc       r12d
       mov       eax,[rsp+24]
       cmp       eax,r12d
       jb        near ptr M00_L13
       cmp       eax,r15d
       ja        short M00_L04
M00_L06:
       xor       r15d,r15d
M00_L07:
       test      r15,r15
       jne       near ptr M00_L15
       cmp       qword ptr [rsi+50],0
       jne       near ptr M00_L16
       mov       rbp,[rsi+48]
M00_L08:
       mov       [rsp+28],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L09:
       call      qword ptr [7FF91C91F0D8]
       mov       ecx,0FD4
       mov       rdx,7FF91C645548
       call      qword ptr [7FF91C5877B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C645548
       call      qword ptr [7FF91C5877B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C367840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C645548
       call      qword ptr [7FF91C5877B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C367840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CA5D410]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CA5D428]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       eax,edx
       rol       eax,5
       add       eax,edx
       mov       edx,eax
       xor       edx,[r11]
       jmp       near ptr M00_L02
M00_L11:
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FF91C2B0F68
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L12:
       mov       rdx,[r15]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FF91C2B0F70
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L14
       jmp       near ptr M00_L05
M00_L13:
       call      qword ptr [7FF91C587A20]
       int       3
M00_L14:
       add       r15,8
       jmp       near ptr M00_L07
M00_L15:
       mov       rbp,[r15]
       jmp       near ptr M00_L08
M00_L16:
       mov       rax,[rsi+50]
       mov       rdx,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbp,rax
       jmp       near ptr M00_L08
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 662
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
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C365818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C365818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,215A0BB0008
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
       call      qword ptr [7FF91CB5E9D0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.GetValueOrDefault()
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
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,[rbx+48]
       mov       rdi,[rcx+28]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L09
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L06
       mov       rbp,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [rbp],rcx
       jne       near ptr M00_L11
       lea       rcx,[rdi+0C]
       mov       [rsp+30],rcx
       mov       ecx,15051505
       mov       edx,15051505
       mov       r11,[rsp+30]
       mov       eax,[rdi+8]
       cmp       eax,2
       jle       short M00_L01
M00_L00:
       add       eax,0FFFFFFFC
       mov       r8d,ecx
       rol       r8d,5
       add       ecx,r8d
       xor       ecx,[r11]
       mov       r8d,edx
       rol       r8d,5
       add       edx,r8d
       xor       edx,[r11+4]
       add       r11,8
       cmp       eax,2
       jg        short M00_L00
M00_L01:
       test      eax,eax
       jg        near ptr M00_L10
M00_L02:
       imul      r14d,edx,5D588B65
       add       r14d,ecx
       xor       ecx,ecx
       mov       [rsp+30],rcx
M00_L03:
       mov       rdx,[rsi+8]
       mov       ecx,r14d
       imul      rcx,[rsi+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L17
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r13,[rsi+10]
       xor       r12d,r12d
       dec       r15d
       mov       eax,[r13+8]
       mov       [rsp+24],eax
       cmp       eax,r15d
       jbe       short M00_L06
M00_L04:
       mov       edx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       r15,[r13+rdx*8+10]
       cmp       [r15+10],r14d
       je        near ptr M00_L12
M00_L05:
       mov       r15d,[r15+14]
       inc       r12d
       mov       eax,[rsp+24]
       cmp       eax,r12d
       jb        near ptr M00_L13
       cmp       eax,r15d
       ja        short M00_L04
M00_L06:
       xor       r15d,r15d
M00_L07:
       test      r15,r15
       jne       near ptr M00_L15
       cmp       qword ptr [rsi+50],0
       jne       near ptr M00_L16
       mov       rbp,[rsi+48]
M00_L08:
       mov       [rsp+28],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L09:
       call      qword ptr [7FF91C92F0A8]
       mov       ecx,0FD4
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C377840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF91C655548
       call      qword ptr [7FF91C5977B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91C377840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91CA64FA8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91CA64FC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       eax,edx
       rol       eax,5
       add       eax,edx
       mov       edx,eax
       xor       edx,[r11]
       jmp       near ptr M00_L02
M00_L11:
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FF91C2C11D8
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L12:
       mov       rdx,[r15]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FF91C2C11E0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L14
       jmp       near ptr M00_L05
M00_L13:
       call      qword ptr [7FF91C597A20]
       int       3
M00_L14:
       add       r15,8
       jmp       near ptr M00_L07
M00_L15:
       mov       rbp,[r15]
       jmp       near ptr M00_L08
M00_L16:
       mov       rax,[rsi+50]
       mov       rdx,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbp,rax
       jmp       near ptr M00_L08
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 662
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
       call      00007FF97BFFA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF91C375818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF91C375818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1FDC1900008
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
       call      qword ptr [7FF91CBAE550]
       int       3
; Total bytes of code 235
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ToImmutableDictionary()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,158
       lea       rbp,[rsp+190]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-140],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       cmp       [rsi],sil
       mov       rcx,1F636000A20
       mov       r14,[rcx]
       mov       r15,[r14+8]
       mov       r13,[r14+10]
       xor       r12d,r12d
       mov       ecx,[rsi+38]
       sub       ecx,[rsi+40]
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[rsi+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       mov       [rbp-0C8],rsi
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-0C8]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
       mov       rcx,rdx
M00_L01:
       mov       [rbp-148],rcx
M00_L02:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-148]
       cmp       [rcx],rdx
       jne       near ptr M00_L30
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF91C6F7F30]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L03:
       test      eax,eax
       je        near ptr M00_L32
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-148]
       cmp       [rcx],rdx
       jne       near ptr M00_L20
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-58],xmm0
M00_L04:
       cmp       qword ptr [rbp-58],0
       je        near ptr M00_L31
       mov       rdx,[r13+8]
       mov       r11,offset MT_System.Collections.Generic.StringEqualityComparer
       cmp       [rdx],r11
       jne       near ptr M00_L24
       mov       rdx,[rbp-58]
       add       rdx,0C
       mov       r11,[rbp-58]
       mov       r11d,[r11+8]
       add       r11d,r11d
       mov       eax,0AD28F744
       mov       r8d,24BF9E16
       cmp       r11d,8
       jb        near ptr M00_L15
       mov       r10d,r11d
       shr       r10d,3
M00_L05:
       add       eax,[rdx]
       mov       r9d,[rdx+4]
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
       add       rdx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L05
       test      r11b,4
       jne       near ptr M00_L16
M00_L06:
       mov       r10d,r11d
       and       r10,7
       mov       edx,[rdx+r10-4]
       shr       edx,8
       or        edx,80000000
       not       r11d
       shl       r11d,3
       shrx      edx,edx,r11d
M00_L07:
       add       edx,eax
       mov       r11d,r8d
       xor       r11d,edx
       rol       edx,14
       add       edx,r11d
       rol       r11d,9
       xor       r11d,edx
       rol       edx,1B
       add       edx,r11d
       rol       r11d,13
       xor       r11d,edx
       mov       esi,edx
       rol       esi,14
       add       esi,r11d
       rol       r11d,9
       xor       r11d,esi
       rol       esi,1B
       add       esi,r11d
       mov       edi,r11d
       rol       edi,13
       xor       esi,edi
M00_L08:
       cmp       [r15],r15b
       mov       rdx,r15
       cmp       qword ptr [r15+8],0
       je        short M00_L11
       nop
M00_L09:
       mov       r9d,[rdx+18]
       cmp       esi,r9d
       je        near ptr M00_L25
       jg        near ptr M00_L17
       mov       rdx,[rdx+8]
M00_L10:
       cmp       qword ptr [rdx+8],0
       jne       short M00_L09
M00_L11:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
M00_L12:
       vmovdqu   xmm0,xmmword ptr [rbp-0E0]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rdx,[rbp-0D0]
       mov       [rbp-60],rdx
       mov       rdx,[rbp-50]
       mov       [rsp+20],rdx
       mov       [rsp+28],r13
       mov       rdx,[r13+10]
       mov       [rsp+30],rdx
       mov       dword ptr [rsp+38],2
       lea       rdx,[rbp-78]
       mov       [rsp+40],rdx
       lea       rdx,[rbp-90]
       lea       rcx,[rbp-70]
       mov       r9,[rbp-58]
       mov       r8,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket
       call      qword ptr [7FF91CB65B18]; System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, KeyCollisionBehavior<System.__Canon,System.__Canon>, OperationResult<System.__Canon,System.__Canon> ByRef)
       mov       rcx,[rbp-90]
       test      rcx,rcx
       je        near ptr M00_L26
       vmovdqu   xmm0,xmmword ptr [rbp-90]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       mov       r8,[rbp-80]
       mov       [rbp-0F8],r8
       mov       [rbp-108],rcx
       xor       ecx,ecx
       mov       [rbp-0E8],ecx
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L19
       mov       rdi,r15
       cmp       esi,[rdi+18]
       jg        near ptr M00_L18
       cmp       esi,[rdi+18]
       jge       near ptr M00_L27
       mov       dword ptr [rsp+20],1
       lea       rcx,[rbp-0E8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0F0]
       mov       [rsp+30],rcx
       mov       rcx,[rdi+8]
       lea       r8,[rbp-108]
       mov       edx,esi
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65B90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       mov       rdx,rax
       cmp       byte ptr [rbp-0F0],0
       je        short M00_L13
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FF91CB65BC0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       rdi,rax
M00_L13:
       cmp       byte ptr [rbp-0F0],0
       je        near ptr M00_L29
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FF91CB65BD8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       r15,rax
M00_L14:
       cmp       dword ptr [rbp-78],1
       jne       near ptr M00_L02
       inc       r12d
       jmp       near ptr M00_L02
M00_L15:
       cmp       r11d,4
       jb        near ptr M00_L21
M00_L16:
       add       eax,[rdx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L06
M00_L17:
       mov       rdx,[rdx+10]
       jmp       near ptr M00_L10
M00_L18:
       mov       dword ptr [rsp+20],1
       lea       rcx,[rbp-0E8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0F0]
       mov       [rsp+30],rcx
       mov       rcx,[rdi+10]
       lea       r8,[rbp-108]
       mov       edx,esi
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65B90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rbp-0F0],0
       je        near ptr M00_L13
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF91CB65BC0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       jmp       near ptr M00_L13
M00_L19:
       mov       dword ptr [rbp-0F0],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rbp-108]
       mov       rcx,rdi
       mov       edx,esi
       mov       r9,r15
       call      qword ptr [7FF91CB65BA8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r15,rdi
       jmp       near ptr M00_L14
M00_L20:
       lea       rdx,[rbp-58]
       mov       r11,7FF91C2C0C48
       call      qword ptr [r11]
       mov       rcx,[rbp-148]
       jmp       near ptr M00_L04
M00_L21:
       mov       r10d,80
       test      r11b,1
       je        short M00_L22
       mov       r10d,r11d
       and       r10,2
       movzx     r10d,byte ptr [rdx+r10]
       or        r10d,8000
M00_L22:
       test      r11b,2
       je        short M00_L23
       shl       r10d,10
       movzx     edx,word ptr [rdx]
       or        r10d,edx
       mov       edx,r10d
       jmp       near ptr M00_L07
M00_L23:
       mov       edx,r10d
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,rdx
       mov       rdx,[rbp-58]
       mov       r11,7FF91C2C0C50
       call      qword ptr [r11]
       mov       esi,eax
       mov       rcx,[rbp-148]
       jmp       near ptr M00_L08
M00_L25:
       vmovdqu   xmm0,xmmword ptr [rdx+20]
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       mov       r9,[rdx+30]
       mov       [rbp-0D0],r9
       jmp       near ptr M00_L12
M00_L26:
       lea       r8,[rbp-0E8]
       mov       rcx,r15
       mov       edx,esi
       call      qword ptr [7FF91CB6F078]
       mov       r15,rax
       jmp       near ptr M00_L14
M00_L27:
       vmovdqu   xmm0,xmmword ptr [r15+20]
       vmovdqu   xmmword ptr [rbp-128],xmm0
       mov       r8,[r15+30]
       mov       [rbp-118],r8
       vmovdqu   xmm0,xmmword ptr [rbp-108]
       vmovdqu   xmmword ptr [rbp-140],xmm0
       mov       r8,[rbp-0F8]
       mov       [rbp-130],r8
       lea       r8,[rbp-140]
       lea       rdx,[rbp-128]
       mov       rcx,r13
       mov       r11,7FF91C2C0C60
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L28
       xor       ecx,ecx
       mov       [rbp-0F0],ecx
       jmp       near ptr M00_L14
M00_L28:
       mov       dword ptr [rbp-0F0],1
       mov       dword ptr [rbp-0E8],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r9,[r15+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[r15+8]
       lea       r8,[rbp-108]
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF91CB65BA8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       jmp       near ptr M00_L13
M00_L29:
       mov       r15,rdi
       jmp       near ptr M00_L14
M00_L30:
       mov       r11,7FF91C2C0C40
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L31:
       mov       ecx,717
       mov       rdx,7FF91CB7CA70
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6EC70]
       int       3
M00_L32:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r11,[rbp-148]
       cmp       [r11],rcx
       jne       near ptr M00_L35
M00_L33:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       lea       rcx,[rbp-0A0]
       mov       r9d,r12d
       mov       r8,r15
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FF91CB6F1E0]; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-0A0]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       lea       rcx,[rbp-48]
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FF91CB6F1F8]; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableDictionary`2<System.__Canon,System.__Canon>)
       mov       [rbp-110],rax
       mov       rcx,[rbx+60]
       lea       r8,[rbp-110]
       mov       rdx,7FF91CB9BDB8
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65D40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,158
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1F636000AD0
       mov       rcx,[rdx]
       jmp       near ptr M00_L01
M00_L35:
       mov       rcx,r11
       mov       r11,7FF91C2C0C58
       call      qword ptr [r11]
       jmp       near ptr M00_L33
       sub       rsp,48
       cmp       qword ptr [rbp-148],0
       je        short M00_L36
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-148]
       cmp       [rax],rcx
       je        short M00_L36
       mov       rcx,rax
       mov       r11,7FF91C2C0C58
       call      qword ptr [r11]
M00_L36:
       nop
       add       rsp,48
       ret
; Total bytes of code 1870
```
```assembly
; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+8]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+44]
       jne       short M01_L02
       mov       ecx,[rbx+0C]
       cmp       ecx,[rdx+38]
       jae       short M01_L01
M01_L00:
       mov       rcx,[rbx]
       mov       rcx,[rcx+10]
       mov       edx,[rbx+0C]
       lea       eax,[rdx+1]
       mov       [rbx+0C],eax
       cmp       edx,[rcx+8]
       jae       short M01_L04
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L03
       mov       rdx,[rcx]
       mov       rsi,[rcx+8]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       mov       rax,[rbx]
       mov       eax,[rax+38]
       inc       eax
       mov       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+18],rax
       mov       [rbx+20],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       call      qword ptr [7FF91C59C150]
       int       3
M01_L03:
       mov       ecx,[rbx+0C]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+38]
       jb        short M01_L00
       jmp       short M01_L01
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 158
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, KeyCollisionBehavior<System.__Canon,System.__Canon>, OperationResult<System.__Canon,System.__Canon> ByRef)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A0
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       xor       eax,eax
       mov       [rsp+90],rax
       mov       [rsp+98],r8
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
M02_L00:
       cmp       qword ptr [rdi],0
       jne       short M02_L04
       mov       r14,[rsp+120]
       mov       dword ptr [r14],1
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L03
M02_L01:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbx],rcx
       mov       [rbx+8],rbp
       mov       r15,[rsp+100]
       mov       [rbx+10],r15
M02_L02:
       mov       rax,rbx
       add       rsp,0A0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF91CBFE260
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FF91CBFE040
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L06:
       mov       [rsp+40],rbp
       mov       r15,[rsp+100]
       mov       [rsp+48],r15
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+40]
       lea       r8,[rsp+30]
       mov       rcx,[rsp+108]
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M02_L10
       mov       r13d,[rsp+118]
       cmp       r13d,3
       ja        short M02_L07
       mov       ecx,r13d
       lea       rax,[7FF91CAEBC50]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M02_L00]
       add       rax,rdx
       jmp       rax
M02_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF91CB6ECB8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
       xor       r8d,r8d
       mov       r14,[rsp+120]
       mov       [r14],r8d
       mov       [rsp+40],rbp
       mov       [rsp+48],r15
       lea       r8,[rsp+40]
       mov       r9,[rdi]
       lea       rcx,[rsp+50]
       mov       rdx,rsi
       call      qword ptr [7FF91CB6ED00]
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rsp+60]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       lea       r13,[rdi+8]
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FF91CBFE1A8
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L09:
       mov       rdx,[r13+8]
       mov       rcx,[rsp+110]
       mov       r8,r15
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M02_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB6EC88]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB6ECA0]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF91CB6EC88]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB6ECA0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L10:
       mov       rcx,[rdi]
       cmp       [rcx],cl
       mov       [rsp+40],rbp
       mov       [rsp+48],r15
       mov       r13,[rsp+108]
       mov       [rsp+20],r13
       lea       rdx,[rsp+40]
       mov       r9d,[rcx+18]
       xor       r8d,r8d
       call      qword ptr [7FF91CB6ECD0]
       test      eax,eax
       jge       short M02_L11
       mov       r14,[rsp+120]
       mov       dword ptr [r14],1
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,[rdi]
       mov       [rsp+30],rbp
       mov       [rsp+38],r15
       lea       rdx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB6ECE8]
       mov       r9,rax
       lea       r8,[rsp+40]
       lea       rcx,[rsp+68]
       mov       rdx,rsi
       call      qword ptr [7FF91CB6ED00]
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rax,[rsp+78]
       mov       [rbx+10],rax
       jmp       near ptr M02_L02
M02_L11:
       mov       r13d,[rsp+118]
       cmp       r13d,3
       ja        short M02_L12
       mov       ecx,r13d
       lea       rdx,[7FF91CAEBC60]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M02_L00]
       add       rdx,r8
       jmp       rdx
M02_L12:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FF91CB6ECB8]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
       xor       ecx,ecx
       mov       r14,[rsp+120]
       mov       [r14],ecx
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,[rdi]
       mov       [rsp+30],rbp
       mov       [rsp+38],r15
       lea       r8,[rsp+30]
       mov       edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB6ED18]
       mov       r9,rax
       lea       r8,[rsp+40]
       lea       rcx,[rsp+80]
       mov       rdx,rsi
       call      qword ptr [7FF91CB6ED00]
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rsp+90]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       mov       rcx,[rdi]
       mov       edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB6ED30]
       mov       r13,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FF91CBFE1A8
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L14:
       mov       rdx,[r13+8]
       mov       rcx,[rsp+110]
       mov       r8,r15
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB6EC88]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB6ECA0]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M02_L15:
       mov       r14,[rsp+120]
       mov       dword ptr [r14],2
       vmovdqu   xmm0,xmmword ptr [rdi]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rdi+10]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF91CB6EC88]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB6ECA0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 1163
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M03_L00:
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
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       [rsp+0D0],rcx
       mov       rbx,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       r14,r9
       mov       r13,[rsp+148]
       mov       r15,[rsp+150]
       mov       byte ptr [r13],0
       cmp       qword ptr [rbx+8],0
       je        near ptr M03_L18
       mov       r12,rbx
       cmp       ebp,[r12+18]
       jg        near ptr M03_L10
       cmp       ebp,[r12+18]
       jge       near ptr M03_L33
       mov       rdi,[r12+8]
       mov       rdx,rdi
       mov       [rsp+38],rdx
       cmp       [rdx],dl
       mov       byte ptr [r13],0
       cmp       qword ptr [rdx+8],0
       je        near ptr M03_L09
       mov       rdi,rdx
       cmp       ebp,[rdi+18]
       jg        near ptr M03_L06
       cmp       ebp,[rdi+18]
       jge       near ptr M03_L25
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r13
       mov       [rsp+30],r15
       mov       rcx,[rdi+8]
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65B90]
       mov       rsi,rax
       cmp       byte ptr [r15],0
       je        short M03_L02
       mov       rbp,[rsp+38]
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M03_L23
       test      rsi,rsi
       je        short M03_L01
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rcx,[rbp+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbp+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L40
       cmp       ecx,0FF
       ja        near ptr M03_L40
       mov       [rbp+1D],cl
       mov       rdi,rbp
M03_L02:
       cmp       byte ptr [r15],0
       je        near ptr M03_L30
       mov       rbp,[rsp+38]
       mov       rcx,[rbp]
       mov       rdx,rdi
       call      qword ptr [7FF91CB65BD8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       rdi,rax
M03_L03:
       cmp       byte ptr [r15],0
       je        short M03_L05
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L31
       test      rdi,rdi
       je        short M03_L04
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M03_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L40
       cmp       ecx,0FF
       ja        near ptr M03_L40
       mov       [rbx+1D],cl
       mov       r12,rbx
M03_L05:
       cmp       byte ptr [r15],0
       je        near ptr M03_L38
       mov       r15,[rbx]
       test      r12,r12
       je        near ptr M03_L39
       mov       rdx,[r12+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rcx,[r12+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       edx,ecx
       cmp       edx,2
       jl        near ptr M03_L13
       mov       rcx,[r12+10]
       test      rcx,rcx
       je        near ptr M03_L39
       mov       rdx,[rcx+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rcx,[rcx+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       edx,ecx
       js        near ptr M03_L16
       mov       rcx,r15
       mov       rdx,r12
       call      qword ptr [7FF91CB65C68]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       near ptr M03_L17
M03_L06:
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r13
       mov       [rsp+30],r15
       mov       rcx,[rdi+10]
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65B90]
       mov       rbp,rax
       cmp       byte ptr [r15],0
       je        near ptr M03_L02
       mov       rdi,[rsp+38]
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M03_L21
       test      rbp,rbp
       je        short M03_L07
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M03_L07:
       mov       rcx,[rdi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rdi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L40
       cmp       ecx,0FF
       ja        near ptr M03_L40
       mov       [rdi+1D],cl
       mov       rsi,rdi
M03_L08:
       mov       rdi,rsi
       jmp       near ptr M03_L02
M03_L09:
       mov       byte ptr [r15],1
       mov       rcx,[rdx]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+18],ebp
       lea       rdi,[r14+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       rcx,[r14+8]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+1C],0
       mov       rbp,[rsp+38]
       movzx     ecx,byte ptr [rbp+1D]
       add       ecx,1
       jo        near ptr M03_L40
       cmp       ecx,0FF
       ja        near ptr M03_L40
       mov       [r14+1D],cl
       mov       rdi,r14
       jmp       near ptr M03_L03
M03_L10:
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r13
       mov       [rsp+30],r15
       mov       rcx,[r12+10]
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65B90]
       mov       rbp,rax
       cmp       byte ptr [r15],0
       je        near ptr M03_L05
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L19
       test      rbp,rbp
       je        short M03_L11
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M03_L11:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L40
       cmp       ecx,0FF
       ja        near ptr M03_L40
       mov       [rbx+1D],cl
       mov       r12,rbx
M03_L12:
       jmp       near ptr M03_L05
M03_L13:
       cmp       edx,0FFFFFFFE
       jle       short M03_L14
       mov       rax,r12
       jmp       short M03_L17
M03_L14:
       mov       rdx,[r12+8]
       mov       rcx,r15
       call      qword ptr [7FF91CB65C08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       test      eax,eax
       jle       short M03_L15
       mov       rcx,r15
       mov       rdx,r12
       call      qword ptr [7FF91CB65C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       short M03_L17
M03_L15:
       mov       rcx,r15
       mov       rdx,r12
       call      qword ptr [7FF91CB65C38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       short M03_L17
M03_L16:
       mov       rcx,r15
       mov       rdx,r12
       call      qword ptr [7FF91CB65C80]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M03_L17:
       nop
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
M03_L18:
       mov       byte ptr [r15],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+18],ebp
       lea       rdi,[r14+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+1C],0
       movzx     eax,byte ptr [rbx+1D]
       add       eax,1
       jo        near ptr M03_L40
       cmp       eax,0FF
       ja        near ptr M03_L40
       mov       [r14+1D],al
       mov       rax,r14
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
M03_L19:
       mov       r12d,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+0B8],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+0C8],rcx
       mov       rsi,[rbx+8]
       test      rbp,rbp
       jne       short M03_L20
       mov       rbp,[rbx+10]
M03_L20:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       vmovdqu   xmm0,xmmword ptr [rsp+0B8]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+0C8]
       mov       [rsp+68],r8
       mov       [rsp+20],rbp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,r12d
       mov       rcx,rdi
       mov       r9,rsi
       call      qword ptr [7FF91CB65BA8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r12,rdi
       jmp       near ptr M03_L12
M03_L21:
       mov       esi,[rdi+18]
       vmovdqu   xmm0,xmmword ptr [rdi+20]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       rcx,[rdi+30]
       mov       [rsp+0B0],rcx
       mov       r14,[rdi+8]
       test      rbp,rbp
       jne       short M03_L22
       mov       rbp,[rdi+10]
M03_L22:
       mov       rcx,[rdi]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+0B0]
       mov       [rsp+68],r8
       mov       [rsp+20],rbp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,esi
       mov       rcx,r13
       mov       r9,r14
       call      qword ptr [7FF91CB65BA8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rsi,r13
       jmp       near ptr M03_L08
M03_L23:
       mov       edi,[rbp+18]
       vmovdqu   xmm0,xmmword ptr [rbp+20]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       mov       rcx,[rbp+30]
       mov       [rsp+98],rcx
       test      rsi,rsi
       jne       short M03_L24
       mov       rsi,[rbp+8]
M03_L24:
       mov       r14,[rbp+10]
       mov       rcx,[rbp]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       vmovdqu   xmm0,xmmword ptr [rsp+88]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+98]
       mov       [rsp+68],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,edi
       mov       rcx,r13
       mov       r9,rsi
       call      qword ptr [7FF91CB65BA8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdi,r13
       jmp       near ptr M03_L02
M03_L25:
       mov       rdx,[rsp+38]
       mov       rcx,[rdx]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r11,[rax+60]
       test      r11,r11
       je        short M03_L26
       jmp       short M03_L27
M03_L26:
       mov       rdx,7FF91CBFD9F0
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L27:
       mov       rdi,[rsp+38]
       vmovdqu   xmm0,xmmword ptr [rdi+20]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       rdx,[rdi+30]
       mov       [rsp+68],rdx
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdx,[rsi+10]
       mov       [rsp+50],rdx
       lea       rdx,[rsp+58]
       lea       r8,[rsp+40]
       mov       rcx,r14
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L28
       mov       byte ptr [r15],0
       jmp       near ptr M03_L03
M03_L28:
       cmp       byte ptr [rsp+140],0
       je        short M03_L29
       mov       byte ptr [r15],1
       mov       byte ptr [r13],1
       mov       rcx,[rdi]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r9,[rdi+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[rdi+8]
       mov       rcx,r13
       mov       edx,ebp
       mov       r8,rsi
       call      qword ptr [7FF91CB65BA8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdi,r13
       jmp       near ptr M03_L02
M03_L29:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF91CB6EC88]
       mov       rdi,rax
       mov       [r15+8],ebp
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r15
       mov       rcx,rdi
       call      qword ptr [7FF91CB6ECA0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M03_L30:
       jmp       near ptr M03_L03
M03_L31:
       mov       r12d,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+80],rcx
       test      rdi,rdi
       jne       short M03_L32
       mov       rdi,[rbx+8]
M03_L32:
       mov       rsi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       vmovdqu   xmm0,xmmword ptr [rsp+70]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+80]
       mov       [rsp+68],r8
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,r12d
       mov       rcx,rbp
       mov       r9,rdi
       call      qword ptr [7FF91CB65BA8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r12,rbp
       jmp       near ptr M03_L05
M03_L33:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L34
       jmp       short M03_L35
M03_L34:
       mov       rdx,7FF91CBFD9F0
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L35:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       rdx,[rbx+30]
       mov       [rsp+68],rdx
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdx,[rsi+10]
       mov       [rsp+50],rdx
       lea       rdx,[rsp+58]
       lea       r8,[rsp+40]
       mov       rcx,r14
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L36
       mov       byte ptr [r15],0
       mov       rax,rbx
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
M03_L36:
       cmp       byte ptr [rsp+140],0
       je        short M03_L37
       mov       byte ptr [r15],1
       mov       byte ptr [r13],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       r9,[rbx+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[rbx+8]
       mov       rcx,r12
       mov       edx,ebp
       mov       r8,rsi
       call      qword ptr [7FF91CB65BA8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       jmp       near ptr M03_L05
M03_L37:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF91CB6EC88]
       mov       r13,rax
       mov       [r15+8],ebp
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,r15
       mov       rcx,r13
       call      qword ptr [7FF91CB6ECA0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
M03_L38:
       mov       rax,r12
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
M03_L39:
       mov       ecx,869
       mov       rdx,7FF91CB7CA70
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6EC70]
       int       3
M03_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2237
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       [rsp+60],rax
       mov       [rsp+68],rcx
       mov       rbx,rcx
       mov       rsi,r8
       cmp       byte ptr [rbx+1C],0
       jne       short M04_L02
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M04_L00:
       test      rsi,rsi
       je        short M04_L01
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M04_L01:
       mov       rax,[rbx+8]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rbx+10]
       movzx     ecx,byte ptr [rcx+1D]
       cmp       eax,ecx
       cmovl     eax,ecx
       add       eax,1
       jo        near ptr M04_L05
       cmp       eax,0FF
       ja        near ptr M04_L05
       mov       [rbx+1D],al
       mov       rax,rbx
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L02:
       mov       edi,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+60],rcx
       mov       rbp,rdx
       test      rbp,rbp
       jne       short M04_L03
       mov       rbp,[rbx+8]
M04_L03:
       test      rsi,rsi
       jne       short M04_L04
       mov       rsi,[rbx+10]
M04_L04:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r8,[rsp+60]
       mov       [rsp+48],r8
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,edi
       mov       rcx,r14
       mov       r9,rbp
       call      qword ptr [7FF91CB65BA8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rax,r14
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 267
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L04
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rbx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       cmp       eax,2
       jge       short M05_L02
       cmp       eax,0FFFFFFFE
       jle       short M05_L00
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FF91CB65C08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       test      eax,eax
       jg        short M05_L01
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB65C38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB65C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L02:
       mov       rdx,[rbx+10]
       mov       rcx,rsi
       call      qword ptr [7FF91CB65C08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       test      eax,eax
       jl        short M05_L03
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB65C68]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB65C80]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L04:
       mov       ecx,869
       mov       rdx,7FF91CB7CA70
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6EC70]
       int       3
; Total bytes of code 201
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rbp,r9
       mov       r14,[rsp+80]
       cmp       [rbx],ebx
       test      rbp,rbp
       je        short M06_L00
       test      r14,r14
       je        near ptr M06_L01
       mov       [rbx+18],edx
       lea       rdi,[rbx+20]
       mov       rsi,r8
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r15d,byte ptr [rsp+88]
       mov       [rbx+1C],r15b
       movzx     ecx,byte ptr [rbp+1D]
       movzx     edx,byte ptr [r14+1D]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        short M06_L02
       cmp       ecx,0FF
       ja        short M06_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       mov       ecx,847
       mov       rdx,7FF91CB7CA70
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6EC70]
       int       3
M06_L01:
       mov       ecx,851
       mov       rdx,7FF91CB7CA70
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6EC70]
       int       3
M06_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 220
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r9d
       test      r8,r8
       je        short M07_L00
       mov       rcx,rbx
       mov       rdx,r8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rbx+8],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       mov       ecx,4AB
       mov       rdx,7FF91CB7CA70
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6EC70]
       int       3
; Total bytes of code 69
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableDictionary`2<System.__Canon,System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rdx
       mov       rbx,r8
       test      rbx,rbx
       je        near ptr M08_L05
       mov       rsi,[rcx]
       mov       edi,[rbx+18]
       add       edi,[rcx+8]
       test      rsi,rsi
       je        near ptr M08_L08
       cmp       [rbx+8],rsi
       je        near ptr M08_L09
       cmp       qword ptr [rsi+8],0
       je        near ptr M08_L08
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+10]
       test      rdx,rdx
       je        near ptr M08_L06
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0E8]
       test      rdx,rdx
       je        near ptr M08_L04
M08_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax+8]
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M08_L02
       test      rbx,rbx
       je        short M08_L01
       mov       r14d,[rsi+18]
       lea       rcx,[rsi+20]
       mov       r15,[rcx]
       vmovdqu   xmm0,xmmword ptr [rcx]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       mov       rax,[rcx+10]
       mov       [rsp+38],rax
       vmovdqu   xmm0,xmmword ptr [rsp+28]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rcx,[rsp+38]
       mov       [rsp+58],rcx
       mov       rcx,offset System.Collections.Immutable.ImmutableDictionary`2+<>c[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<.cctor>b__109_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>)
       cmp       [rbx+18],rcx
       jne       near ptr M08_L07
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       test      r15,r15
       je        short M08_L01
       cmp       byte ptr [r15+1C],0
       jne       short M08_L01
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65D28]; System.Collections.Immutable.ImmutableList`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Freeze()
       mov       rcx,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65D28]; System.Collections.Immutable.ImmutableList`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Freeze()
       mov       byte ptr [r15+1C],1
M08_L01:
       mov       rcx,[rsi+8]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65CE0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>>)
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65CE0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>>)
       mov       byte ptr [rsi+1C],1
M08_L02:
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+18],edi
       mov       rbx,rbp
M08_L03:
       mov       rax,rbx
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
       mov       rdx,7FF91CC30508
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L00
M08_L05:
       mov       ecx,737
       mov       rdx,7FF91CB7CA70
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6EC70]
       int       3
M08_L06:
       mov       ecx,6DB
       mov       rdx,7FF91CB7CA70
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6EC70]
       int       3
M08_L07:
       mov       [rsp+40],r14d
       mov       [rsp+48],r15
       lea       rdx,[rsp+40]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       near ptr M08_L01
M08_L08:
       mov       rcx,rbx
       call      qword ptr [7FF91CB6EF70]
       mov       rbx,rax
       jmp       near ptr M08_L03
M08_L09:
       jmp       near ptr M08_L03
; Total bytes of code 523
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M10_L00
       ret
M10_L00:
       jmp       qword ptr [7FF91C375C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ToImmutableDictionary()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,158
       lea       rbp,[rsp+190]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-140],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       cmp       [rsi],sil
       mov       rcx,1CC54C02A18
       mov       r14,[rcx]
       mov       r15,[r14+8]
       mov       r13,[r14+10]
       xor       r12d,r12d
       mov       ecx,[rsi+38]
       sub       ecx,[rsi+40]
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[rsi+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       mov       [rbp-0C8],rsi
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-0C8]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
       mov       rcx,rdx
M00_L01:
       mov       [rbp-148],rcx
M00_L02:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-148]
       cmp       [rcx],rdx
       jne       near ptr M00_L30
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF91C6D7F30]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L03:
       test      eax,eax
       je        near ptr M00_L32
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-148]
       cmp       [rcx],rdx
       jne       near ptr M00_L21
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-58],xmm0
M00_L04:
       cmp       qword ptr [rbp-58],0
       je        near ptr M00_L31
       mov       rdx,[r13+8]
       mov       r11,offset MT_System.Collections.Generic.StringEqualityComparer
       cmp       [rdx],r11
       jne       near ptr M00_L25
       mov       rdx,[rbp-58]
       add       rdx,0C
       mov       r11,[rbp-58]
       mov       r11d,[r11+8]
       add       r11d,r11d
       mov       eax,0CD9CED7C
       mov       r8d,217F861
       cmp       r11d,8
       jb        near ptr M00_L13
       mov       r10d,r11d
       shr       r10d,3
M00_L05:
       add       eax,[rdx]
       mov       r9d,[rdx+4]
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
       add       rdx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L05
       test      r11b,4
       jne       near ptr M00_L14
M00_L06:
       mov       r10d,r11d
       and       r10,7
       mov       edx,[rdx+r10-4]
       shr       edx,8
       or        edx,80000000
       not       r11d
       shl       r11d,3
       shrx      edx,edx,r11d
M00_L07:
       add       edx,eax
       mov       r11d,r8d
       xor       r11d,edx
       rol       edx,14
       add       edx,r11d
       rol       r11d,9
       xor       r11d,edx
       rol       edx,1B
       add       edx,r11d
       rol       r11d,13
       xor       r11d,edx
       mov       esi,edx
       rol       esi,14
       add       esi,r11d
       rol       r11d,9
       xor       r11d,esi
       rol       esi,1B
       add       esi,r11d
       mov       edi,r11d
       rol       edi,13
       xor       esi,edi
M00_L08:
       cmp       [r15],r15b
       mov       rdx,r15
       cmp       qword ptr [r15+8],0
       jne       near ptr M00_L17
M00_L09:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
M00_L10:
       vmovdqu   xmm0,xmmword ptr [rbp-0E0]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rdx,[rbp-0D0]
       mov       [rbp-60],rdx
       mov       rdx,[rbp-50]
       mov       [rsp+20],rdx
       mov       [rsp+28],r13
       mov       rdx,[r13+10]
       mov       [rsp+30],rdx
       mov       dword ptr [rsp+38],2
       lea       rdx,[rbp-78]
       mov       [rsp+40],rdx
       lea       rdx,[rbp-90]
       lea       rcx,[rbp-70]
       mov       r9,[rbp-58]
       mov       r8,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket
       call      qword ptr [7FF91CB45A88]; System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, KeyCollisionBehavior<System.__Canon,System.__Canon>, OperationResult<System.__Canon,System.__Canon> ByRef)
       mov       rcx,[rbp-90]
       test      rcx,rcx
       je        near ptr M00_L20
       vmovdqu   xmm0,xmmword ptr [rbp-90]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       mov       r8,[rbp-80]
       mov       [rbp-0F8],r8
       mov       [rbp-108],rcx
       xor       ecx,ecx
       mov       [rbp-0E8],ecx
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L19
       mov       rdi,r15
       cmp       esi,[rdi+18]
       jle       near ptr M00_L18
       mov       dword ptr [rsp+20],1
       lea       rcx,[rbp-0E8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0F0]
       mov       [rsp+30],rcx
       mov       rcx,[rdi+10]
       lea       r8,[rbp-108]
       mov       edx,esi
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB45B00]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rbp-0F0],0
       je        short M00_L11
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF91CB45B30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       rdi,rax
M00_L11:
       cmp       byte ptr [rbp-0F0],0
       je        near ptr M00_L29
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FF91CB45B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M00_L12:
       mov       r15,rax
       cmp       dword ptr [rbp-78],1
       jne       near ptr M00_L02
       inc       r12d
       jmp       near ptr M00_L02
M00_L13:
       cmp       r11d,4
       jb        near ptr M00_L22
M00_L14:
       add       eax,[rdx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L06
       nop       dword ptr [rax]
M00_L15:
       mov       rdx,[rdx+10]
M00_L16:
       cmp       qword ptr [rdx+8],0
       je        near ptr M00_L09
M00_L17:
       mov       r9d,[rdx+18]
       cmp       esi,r9d
       je        near ptr M00_L26
       jg        short M00_L15
       mov       rdx,[rdx+8]
       jmp       short M00_L16
M00_L18:
       cmp       esi,[rdi+18]
       jge       near ptr M00_L27
       mov       dword ptr [rsp+20],1
       lea       rcx,[rbp-0E8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0F0]
       mov       [rsp+30],rcx
       mov       rcx,[rdi+8]
       lea       r8,[rbp-108]
       mov       edx,esi
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB45B00]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       mov       rdx,rax
       cmp       byte ptr [rbp-0F0],0
       je        near ptr M00_L11
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FF91CB45B30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       jmp       near ptr M00_L11
M00_L19:
       mov       dword ptr [rbp-0F0],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rbp-108]
       mov       rcx,rdi
       mov       edx,esi
       mov       r9,r15
       call      qword ptr [7FF91CB45B18]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M00_L12
M00_L20:
       lea       r8,[rbp-0E8]
       mov       rcx,r15
       mov       edx,esi
       call      qword ptr [7FF91CB4F0C0]
       jmp       near ptr M00_L12
M00_L21:
       lea       rdx,[rbp-58]
       mov       r11,7FF91C2A0C50
       call      qword ptr [r11]
       mov       rcx,[rbp-148]
       jmp       near ptr M00_L04
M00_L22:
       mov       r10d,80
       test      r11b,1
       je        short M00_L23
       mov       r10d,r11d
       and       r10,2
       movzx     r10d,byte ptr [rdx+r10]
       or        r10d,8000
M00_L23:
       test      r11b,2
       je        short M00_L24
       shl       r10d,10
       movzx     edx,word ptr [rdx]
       or        r10d,edx
       mov       edx,r10d
       jmp       near ptr M00_L07
M00_L24:
       mov       edx,r10d
       jmp       near ptr M00_L07
M00_L25:
       mov       rcx,rdx
       mov       rdx,[rbp-58]
       mov       r11,7FF91C2A0C58
       call      qword ptr [r11]
       mov       esi,eax
       mov       rcx,[rbp-148]
       jmp       near ptr M00_L08
M00_L26:
       vmovdqu   xmm0,xmmword ptr [rdx+20]
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       mov       r9,[rdx+30]
       mov       [rbp-0D0],r9
       jmp       near ptr M00_L10
M00_L27:
       vmovdqu   xmm0,xmmword ptr [r15+20]
       vmovdqu   xmmword ptr [rbp-128],xmm0
       mov       r8,[r15+30]
       mov       [rbp-118],r8
       vmovdqu   xmm0,xmmword ptr [rbp-108]
       vmovdqu   xmmword ptr [rbp-140],xmm0
       mov       r8,[rbp-0F8]
       mov       [rbp-130],r8
       lea       r8,[rbp-140]
       lea       rdx,[rbp-128]
       mov       rcx,r13
       mov       r11,7FF91C2A0C68
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L28
       xor       eax,eax
       mov       [rbp-0F0],eax
       mov       rax,r15
       jmp       near ptr M00_L12
M00_L28:
       mov       dword ptr [rbp-0F0],1
       mov       dword ptr [rbp-0E8],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r9,[r15+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[r15+8]
       lea       r8,[rbp-108]
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF91CB45B18]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       jmp       near ptr M00_L11
M00_L29:
       mov       rax,rdi
       jmp       near ptr M00_L12
M00_L30:
       mov       r11,7FF91C2A0C48
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L31:
       mov       ecx,717
       mov       rdx,7FF91CB5C508
       call      qword ptr [7FF91C5777B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB4ECB8]
       int       3
M00_L32:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r11,[rbp-148]
       cmp       [r11],rcx
       jne       near ptr M00_L35
M00_L33:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       lea       rcx,[rbp-0A0]
       mov       r9d,r12d
       mov       r8,r15
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FF91CB4F198]; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-0A0]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       lea       rcx,[rbp-48]
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FF91CB4F1B0]; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableDictionary`2<System.__Canon,System.__Canon>)
       mov       [rbp-110],rax
       mov       rcx,[rbx+60]
       lea       r8,[rbp-110]
       mov       rdx,7FF91CB7B898
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB45CB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,158
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1CC54C02AC8
       mov       rcx,[rdx]
       jmp       near ptr M00_L01
M00_L35:
       mov       rcx,r11
       mov       r11,7FF91C2A0C60
       call      qword ptr [r11]
       jmp       near ptr M00_L33
       sub       rsp,48
       cmp       qword ptr [rbp-148],0
       je        short M00_L36
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-148]
       cmp       [rax],rcx
       je        short M00_L36
       mov       rcx,rax
       mov       r11,7FF91C2A0C60
       call      qword ptr [r11]
M00_L36:
       nop
       add       rsp,48
       ret
; Total bytes of code 1877
```
```assembly
; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+8]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+44]
       jne       short M01_L01
       mov       ecx,[rbx+0C]
       cmp       ecx,[rdx+38]
       jae       short M01_L03
M01_L00:
       mov       rcx,[rbx]
       mov       rcx,[rcx+10]
       mov       edx,[rbx+0C]
       lea       eax,[rdx+1]
       mov       [rbx+0C],eax
       cmp       edx,[rcx+8]
       jae       short M01_L04
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L02
       mov       rdx,[rcx]
       mov       rsi,[rcx+8]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF91C57C150]
       int       3
M01_L02:
       mov       ecx,[rbx+0C]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+38]
       jb        short M01_L00
M01_L03:
       mov       rax,[rbx]
       mov       eax,[rax+38]
       inc       eax
       mov       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+18],rax
       mov       [rbx+20],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, KeyCollisionBehavior<System.__Canon,System.__Canon>, OperationResult<System.__Canon,System.__Canon> ByRef)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A0
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       xor       eax,eax
       mov       [rsp+90],rax
       mov       [rsp+98],r8
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
M02_L00:
       cmp       qword ptr [rdi],0
       jne       short M02_L04
       mov       r14,[rsp+120]
       mov       dword ptr [r14],1
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L03
M02_L01:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbx],rcx
       mov       [rbx+8],rbp
       mov       r15,[rsp+100]
       mov       [rbx+10],r15
M02_L02:
       mov       rax,rbx
       add       rsp,0A0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF91CBDE548
       call      qword ptr [7FF91C35C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FF91CBDE328
       call      qword ptr [7FF91C35C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L06:
       mov       [rsp+40],rbp
       mov       r15,[rsp+100]
       mov       [rsp+48],r15
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+40]
       lea       r8,[rsp+30]
       mov       rcx,[rsp+108]
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M02_L10
       mov       r13d,[rsp+118]
       cmp       r13d,3
       ja        short M02_L07
       mov       ecx,r13d
       lea       rax,[7FF91CACB630]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M02_L00]
       add       rax,rdx
       jmp       rax
M02_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF91CB4ED00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
       xor       r8d,r8d
       mov       r14,[rsp+120]
       mov       [r14],r8d
       mov       [rsp+40],rbp
       mov       [rsp+48],r15
       lea       r8,[rsp+40]
       mov       r9,[rdi]
       lea       rcx,[rsp+50]
       mov       rdx,rsi
       call      qword ptr [7FF91CB4ED48]
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rsp+60]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       lea       r13,[rdi+8]
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FF91CBDE490
       call      qword ptr [7FF91C35C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L09:
       mov       rdx,[r13+8]
       mov       rcx,[rsp+110]
       mov       r8,r15
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M02_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB4ECD0]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB4ECE8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF91C6D5E00]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF91CB4ECD0]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB4ECE8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6D5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L10:
       mov       rcx,[rdi]
       cmp       [rcx],cl
       mov       [rsp+40],rbp
       mov       [rsp+48],r15
       mov       r13,[rsp+108]
       mov       [rsp+20],r13
       lea       rdx,[rsp+40]
       mov       r9d,[rcx+18]
       xor       r8d,r8d
       call      qword ptr [7FF91CB4ED18]
       test      eax,eax
       jge       short M02_L11
       mov       r14,[rsp+120]
       mov       dword ptr [r14],1
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,[rdi]
       mov       [rsp+30],rbp
       mov       [rsp+38],r15
       lea       rdx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB4ED30]
       mov       r9,rax
       lea       r8,[rsp+40]
       lea       rcx,[rsp+68]
       mov       rdx,rsi
       call      qword ptr [7FF91CB4ED48]
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rax,[rsp+78]
       mov       [rbx+10],rax
       jmp       near ptr M02_L02
M02_L11:
       mov       r13d,[rsp+118]
       cmp       r13d,3
       ja        short M02_L12
       mov       ecx,r13d
       lea       rdx,[7FF91CACB640]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M02_L00]
       add       rdx,r8
       jmp       rdx
M02_L12:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FF91CB4ED00]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
       xor       ecx,ecx
       mov       r14,[rsp+120]
       mov       [r14],ecx
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,[rdi]
       mov       [rsp+30],rbp
       mov       [rsp+38],r15
       lea       r8,[rsp+30]
       mov       edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB4ED60]
       mov       r9,rax
       lea       r8,[rsp+40]
       lea       rcx,[rsp+80]
       mov       rdx,rsi
       call      qword ptr [7FF91CB4ED48]
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rsp+90]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       mov       rcx,[rdi]
       mov       edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB4ED78]
       mov       r13,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FF91CBDE490
       call      qword ptr [7FF91C35C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L14:
       mov       rdx,[r13+8]
       mov       rcx,[rsp+110]
       mov       r8,r15
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB4ECD0]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB4ECE8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF91C6D5E00]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M02_L15:
       mov       r14,[rsp+120]
       mov       dword ptr [r14],2
       vmovdqu   xmm0,xmmword ptr [rdi]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rdi+10]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF91CB4ECD0]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB4ECE8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6D5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 1163
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M03_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A0
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqa   xmmword ptr [rsp+80],xmm4
       mov       [rsp+90],rax
       mov       [rsp+98],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       rbp,r9
       mov       r15,[rsp+108]
       mov       r14,[rsp+110]
       mov       byte ptr [r15],0
       cmp       qword ptr [rbx+8],0
       je        near ptr M03_L11
       mov       r13,rbx
       cmp       edi,[r13+18]
       jle       near ptr M03_L03
       movzx     ecx,byte ptr [rsp+100]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB45B00]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        short M03_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L12
       test      rdi,rdi
       je        short M03_L01
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L23
       cmp       ecx,0FF
       ja        near ptr M03_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M03_L02:
       cmp       byte ptr [r14],0
       je        near ptr M03_L21
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M03_L22
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jl        near ptr M03_L06
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M03_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       js        near ptr M03_L09
       mov       rdx,r13
       call      qword ptr [7FF91CB45BC0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       near ptr M03_L10
M03_L03:
       cmp       edi,[r13+18]
       jge       near ptr M03_L16
       movzx     ecx,byte ptr [rsp+100]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB45B00]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        near ptr M03_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L14
       test      rsi,rsi
       je        short M03_L04
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M03_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L23
       cmp       ecx,0FF
       ja        near ptr M03_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M03_L05:
       jmp       near ptr M03_L02
M03_L06:
       cmp       edx,0FFFFFFFE
       jle       short M03_L07
       mov       rax,r13
       jmp       short M03_L10
M03_L07:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M03_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M03_L08
       mov       rdx,r13
       call      qword ptr [7FF91CB45BA8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       short M03_L10
M03_L08:
       mov       rdx,r13
       call      qword ptr [7FF91CB45BD8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       short M03_L10
M03_L09:
       mov       rdx,r13
       call      qword ptr [7FF91CB45BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M03_L10:
       nop
       add       rsp,0A0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L11:
       mov       byte ptr [r14],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rbp+18],edi
       lea       rdi,[rbp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+1C],0
       movzx     eax,byte ptr [rbx+1D]
       add       eax,1
       jo        near ptr M03_L23
       cmp       eax,0FF
       ja        near ptr M03_L23
       mov       [rbp+1D],al
       mov       rax,rbp
       add       rsp,0A0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L12:
       mov       r13d,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+80],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+90],rcx
       mov       r15,[rbx+8]
       test      rdi,rdi
       jne       short M03_L13
       mov       rdi,[rbx+10]
M03_L13:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       mov       r8,[rsp+90]
       mov       [rsp+60],r8
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+50]
       mov       edx,r13d
       mov       rcx,rsi
       mov       r9,r15
       call      qword ptr [7FF91CB45B18]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r13,rsi
       jmp       near ptr M03_L02
M03_L14:
       mov       r13d,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+68],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+78],rcx
       test      rsi,rsi
       jne       short M03_L15
       mov       rsi,[rbx+8]
M03_L15:
       mov       rbp,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       mov       r8,[rsp+78]
       mov       [rsp+60],r8
       mov       [rsp+20],rbp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+50]
       mov       edx,r13d
       mov       rcx,r15
       mov       r9,rsi
       call      qword ptr [7FF91CB45B18]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r13,r15
       jmp       near ptr M03_L05
M03_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L17
       jmp       short M03_L18
M03_L17:
       mov       rdx,7FF91CBDDD88
       call      qword ptr [7FF91C35C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L18:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       mov       rdx,[rbx+30]
       mov       [rsp+60],rdx
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       rdx,[rsi+10]
       mov       [rsp+48],rdx
       lea       rdx,[rsp+50]
       lea       r8,[rsp+38]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L19
       mov       byte ptr [r14],0
       mov       rax,rbx
       add       rsp,0A0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L19:
       cmp       byte ptr [rsp+100],0
       je        short M03_L20
       mov       byte ptr [r14],1
       mov       byte ptr [r15],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r9,[rbx+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[rbx+8]
       mov       rcx,r13
       mov       edx,edi
       mov       r8,rsi
       call      qword ptr [7FF91CB45B18]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       jmp       near ptr M03_L02
M03_L20:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB4ECD0]
       mov       rsi,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FF91CB4ECE8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6D5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L21:
       mov       rax,r13
       add       rsp,0A0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L22:
       mov       ecx,869
       mov       rdx,7FF91CB5C508
       call      qword ptr [7FF91C5777B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB4ECB8]
       int       3
M03_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1266
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       [rsp+60],rax
       mov       [rsp+68],rcx
       mov       rbx,rcx
       mov       rsi,r8
       cmp       byte ptr [rbx+1C],0
       jne       short M04_L02
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M04_L00:
       test      rsi,rsi
       je        short M04_L01
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M04_L01:
       mov       rax,[rbx+8]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rbx+10]
       movzx     ecx,byte ptr [rcx+1D]
       cmp       eax,ecx
       cmovl     eax,ecx
       add       eax,1
       jo        near ptr M04_L05
       cmp       eax,0FF
       ja        near ptr M04_L05
       mov       [rbx+1D],al
       mov       rax,rbx
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L02:
       mov       edi,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+60],rcx
       mov       rbp,rdx
       test      rbp,rbp
       jne       short M04_L03
       mov       rbp,[rbx+8]
M04_L03:
       test      rsi,rsi
       jne       short M04_L04
       mov       rsi,[rbx+10]
M04_L04:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r8,[rsp+60]
       mov       [rsp+48],r8
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,edi
       mov       rcx,r14
       mov       r9,rbp
       call      qword ptr [7FF91CB45B18]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rax,r14
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 267
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M05_L02
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rbx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       cmp       eax,2
       jge       short M05_L00
       cmp       eax,0FFFFFFFE
       jle       short M05_L03
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       mov       rdx,[rbx+10]
       mov       rcx,rsi
       call      qword ptr [7FF91CB45B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       test      eax,eax
       jl        short M05_L01
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB45BC0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB45BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L02:
       mov       ecx,869
       mov       rdx,7FF91CB5C508
       call      qword ptr [7FF91C5777B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB4ECB8]
       int       3
M05_L03:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FF91CB45B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       test      eax,eax
       jg        short M05_L04
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB45BD8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L04:
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB45BA8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
; Total bytes of code 197
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rbp,r9
       mov       r14,[rsp+80]
       cmp       [rbx],ebx
       test      rbp,rbp
       je        short M06_L00
       test      r14,r14
       je        near ptr M06_L01
       mov       [rbx+18],edx
       lea       rdi,[rbx+20]
       mov       rsi,r8
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r15d,byte ptr [rsp+88]
       mov       [rbx+1C],r15b
       movzx     ecx,byte ptr [rbp+1D]
       movzx     edx,byte ptr [r14+1D]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        short M06_L02
       cmp       ecx,0FF
       ja        short M06_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       mov       ecx,847
       mov       rdx,7FF91CB5C508
       call      qword ptr [7FF91C5777B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB4ECB8]
       int       3
M06_L01:
       mov       ecx,851
       mov       rdx,7FF91CB5C508
       call      qword ptr [7FF91C5777B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB4ECB8]
       int       3
M06_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 220
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r9d
       test      r8,r8
       je        short M07_L00
       mov       rcx,rbx
       mov       rdx,r8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rbx+8],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       mov       ecx,4AB
       mov       rdx,7FF91CB5C508
       call      qword ptr [7FF91C5777B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB4ECB8]
       int       3
; Total bytes of code 69
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableDictionary`2<System.__Canon,System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rdx
       mov       rbx,r8
       test      rbx,rbx
       je        near ptr M08_L05
       mov       rsi,[rcx]
       mov       edi,[rbx+18]
       add       edi,[rcx+8]
       test      rsi,rsi
       je        near ptr M08_L08
       cmp       [rbx+8],rsi
       je        near ptr M08_L09
       cmp       qword ptr [rsi+8],0
       je        near ptr M08_L08
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+10]
       test      rdx,rdx
       je        near ptr M08_L06
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0E8]
       test      rdx,rdx
       je        near ptr M08_L04
M08_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax+8]
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M08_L02
       test      rbx,rbx
       je        short M08_L01
       mov       r14d,[rsi+18]
       lea       rcx,[rsi+20]
       mov       r15,[rcx]
       vmovdqu   xmm0,xmmword ptr [rcx]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       mov       rax,[rcx+10]
       mov       [rsp+38],rax
       vmovdqu   xmm0,xmmword ptr [rsp+28]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rcx,[rsp+38]
       mov       [rsp+58],rcx
       mov       rcx,offset System.Collections.Immutable.ImmutableDictionary`2+<>c[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<.cctor>b__109_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>)
       cmp       [rbx+18],rcx
       jne       near ptr M08_L07
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       test      r15,r15
       je        short M08_L01
       cmp       byte ptr [r15+1C],0
       jne       short M08_L01
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB45C98]; System.Collections.Immutable.ImmutableList`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Freeze()
       mov       rcx,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB45C98]; System.Collections.Immutable.ImmutableList`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Freeze()
       mov       byte ptr [r15+1C],1
M08_L01:
       mov       rcx,[rsi+8]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB45C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>>)
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB45C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>>)
       mov       byte ptr [rsi+1C],1
M08_L02:
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+18],edi
       mov       rbx,rbp
M08_L03:
       mov       rax,rbx
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
       mov       rdx,7FF91CC107E8
       call      qword ptr [7FF91C35C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L00
M08_L05:
       mov       ecx,737
       mov       rdx,7FF91CB5C508
       call      qword ptr [7FF91C5777B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB4ECB8]
       int       3
M08_L06:
       mov       ecx,6DB
       mov       rdx,7FF91CB5C508
       call      qword ptr [7FF91C5777B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB4ECB8]
       int       3
M08_L07:
       mov       [rsp+40],r14d
       mov       [rsp+48],r15
       lea       rdx,[rsp+40]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       near ptr M08_L01
M08_L08:
       mov       rcx,rbx
       call      qword ptr [7FF91CB4EFB8]
       mov       rbx,rax
       jmp       near ptr M08_L03
M08_L09:
       jmp       near ptr M08_L03
; Total bytes of code 523
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M10_L00
       ret
M10_L00:
       jmp       qword ptr [7FF91C355C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ToImmutableDictionary()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,158
       lea       rbp,[rsp+190]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-140],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       cmp       [rsi],sil
       mov       rcx,2CAA3C00A20
       mov       r14,[rcx]
       mov       r15,[r14+8]
       mov       r13,[r14+10]
       xor       r12d,r12d
       mov       ecx,[rsi+38]
       sub       ecx,[rsi+40]
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[rsi+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       mov       [rbp-0C8],rsi
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-0C8]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
       mov       rcx,rdx
M00_L01:
       mov       [rbp-148],rcx
M00_L02:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-148]
       cmp       [rcx],rdx
       jne       near ptr M00_L30
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF91C6E7F30]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L03:
       test      eax,eax
       je        near ptr M00_L32
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-148]
       cmp       [rcx],rdx
       jne       near ptr M00_L21
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-58],xmm0
M00_L04:
       cmp       qword ptr [rbp-58],0
       je        near ptr M00_L31
       mov       rdx,[r13+8]
       mov       r11,offset MT_System.Collections.Generic.StringEqualityComparer
       cmp       [rdx],r11
       jne       near ptr M00_L25
       mov       rdx,[rbp-58]
       add       rdx,0C
       mov       r11,[rbp-58]
       mov       r11d,[r11+8]
       add       r11d,r11d
       mov       eax,0FBCA6B87
       mov       r8d,2138FEF7
       cmp       r11d,8
       jb        near ptr M00_L13
       mov       r10d,r11d
       shr       r10d,3
M00_L05:
       add       eax,[rdx]
       mov       r9d,[rdx+4]
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
       add       rdx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L05
       test      r11b,4
       jne       near ptr M00_L14
M00_L06:
       mov       r10d,r11d
       and       r10,7
       mov       edx,[rdx+r10-4]
       shr       edx,8
       or        edx,80000000
       not       r11d
       shl       r11d,3
       shrx      edx,edx,r11d
M00_L07:
       add       edx,eax
       mov       r11d,r8d
       xor       r11d,edx
       rol       edx,14
       add       edx,r11d
       rol       r11d,9
       xor       r11d,edx
       rol       edx,1B
       add       edx,r11d
       rol       r11d,13
       xor       r11d,edx
       mov       esi,edx
       rol       esi,14
       add       esi,r11d
       rol       r11d,9
       xor       r11d,esi
       rol       esi,1B
       add       esi,r11d
       mov       edi,r11d
       rol       edi,13
       xor       esi,edi
M00_L08:
       cmp       [r15],r15b
       mov       rdx,r15
       cmp       qword ptr [r15+8],0
       jne       near ptr M00_L17
M00_L09:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
M00_L10:
       vmovdqu   xmm0,xmmword ptr [rbp-0E0]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rdx,[rbp-0D0]
       mov       [rbp-60],rdx
       mov       rdx,[rbp-50]
       mov       [rsp+20],rdx
       mov       [rsp+28],r13
       mov       rdx,[r13+10]
       mov       [rsp+30],rdx
       mov       dword ptr [rsp+38],2
       lea       rdx,[rbp-78]
       mov       [rsp+40],rdx
       lea       rdx,[rbp-90]
       lea       rcx,[rbp-70]
       mov       r9,[rbp-58]
       mov       r8,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket
       call      qword ptr [7FF91CB55B90]; System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, KeyCollisionBehavior<System.__Canon,System.__Canon>, OperationResult<System.__Canon,System.__Canon> ByRef)
       mov       rcx,[rbp-90]
       test      rcx,rcx
       je        near ptr M00_L20
       vmovdqu   xmm0,xmmword ptr [rbp-90]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       mov       r8,[rbp-80]
       mov       [rbp-0F8],r8
       mov       [rbp-108],rcx
       xor       ecx,ecx
       mov       [rbp-0E8],ecx
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L19
       mov       rdi,r15
       cmp       esi,[rdi+18]
       jg        near ptr M00_L18
       cmp       esi,[rdi+18]
       jge       near ptr M00_L27
       mov       dword ptr [rsp+20],1
       lea       rcx,[rbp-0E8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0F0]
       mov       [rsp+30],rcx
       mov       rcx,[rdi+8]
       lea       r8,[rbp-108]
       mov       edx,esi
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55C08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       mov       rdx,rax
       cmp       byte ptr [rbp-0F0],0
       je        short M00_L11
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FF91CB55C38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       rdi,rax
M00_L11:
       cmp       byte ptr [rbp-0F0],0
       je        near ptr M00_L29
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FF91CB55C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       r15,rax
M00_L12:
       cmp       dword ptr [rbp-78],1
       jne       near ptr M00_L02
       inc       r12d
       jmp       near ptr M00_L02
M00_L13:
       cmp       r11d,4
       jb        near ptr M00_L22
M00_L14:
       add       eax,[rdx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L06
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M00_L15:
       mov       rdx,[rdx+8]
M00_L16:
       cmp       qword ptr [rdx+8],0
       je        near ptr M00_L09
M00_L17:
       mov       r9d,[rdx+18]
       cmp       esi,r9d
       je        near ptr M00_L26
       jle       short M00_L15
       mov       rdx,[rdx+10]
       jmp       short M00_L16
M00_L18:
       mov       dword ptr [rsp+20],1
       lea       rcx,[rbp-0E8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0F0]
       mov       [rsp+30],rcx
       mov       rcx,[rdi+10]
       lea       r8,[rbp-108]
       mov       edx,esi
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55C08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rbp-0F0],0
       je        near ptr M00_L11
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF91CB55C38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       jmp       near ptr M00_L11
M00_L19:
       mov       dword ptr [rbp-0F0],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rbp-108]
       mov       rcx,rdi
       mov       edx,esi
       mov       r9,r15
       call      qword ptr [7FF91CB55C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r15,rdi
       jmp       near ptr M00_L12
M00_L20:
       lea       r8,[rbp-0E8]
       mov       rcx,r15
       mov       edx,esi
       call      qword ptr [7FF91CB5F108]
       mov       r15,rax
       jmp       near ptr M00_L12
M00_L21:
       lea       rdx,[rbp-58]
       mov       r11,7FF91C2B0C50
       call      qword ptr [r11]
       mov       rcx,[rbp-148]
       jmp       near ptr M00_L04
M00_L22:
       mov       r10d,80
       test      r11b,1
       je        short M00_L23
       mov       r10d,r11d
       and       r10,2
       movzx     r10d,byte ptr [rdx+r10]
       or        r10d,8000
M00_L23:
       test      r11b,2
       je        short M00_L24
       shl       r10d,10
       movzx     edx,word ptr [rdx]
       or        r10d,edx
       mov       edx,r10d
       jmp       near ptr M00_L07
M00_L24:
       mov       edx,r10d
       jmp       near ptr M00_L07
M00_L25:
       mov       rcx,rdx
       mov       rdx,[rbp-58]
       mov       r11,7FF91C2B0C58
       call      qword ptr [r11]
       mov       esi,eax
       mov       rcx,[rbp-148]
       jmp       near ptr M00_L08
M00_L26:
       vmovdqu   xmm0,xmmword ptr [rdx+20]
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       mov       r9,[rdx+30]
       mov       [rbp-0D0],r9
       jmp       near ptr M00_L10
M00_L27:
       vmovdqu   xmm0,xmmword ptr [r15+20]
       vmovdqu   xmmword ptr [rbp-128],xmm0
       mov       r8,[r15+30]
       mov       [rbp-118],r8
       vmovdqu   xmm0,xmmword ptr [rbp-108]
       vmovdqu   xmmword ptr [rbp-140],xmm0
       mov       r8,[rbp-0F8]
       mov       [rbp-130],r8
       lea       r8,[rbp-140]
       lea       rdx,[rbp-128]
       mov       rcx,r13
       mov       r11,7FF91C2B0C68
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L28
       xor       ecx,ecx
       mov       [rbp-0F0],ecx
       jmp       near ptr M00_L12
M00_L28:
       mov       dword ptr [rbp-0F0],1
       mov       dword ptr [rbp-0E8],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r9,[r15+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[r15+8]
       lea       r8,[rbp-108]
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF91CB55C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       jmp       near ptr M00_L11
M00_L29:
       mov       r15,rdi
       jmp       near ptr M00_L12
M00_L30:
       mov       r11,7FF91C2B0C48
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L31:
       mov       ecx,717
       mov       rdx,7FF91CB6DDC8
       call      qword ptr [7FF91C5877B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB5ED00]
       int       3
M00_L32:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r11,[rbp-148]
       cmp       [r11],rcx
       jne       near ptr M00_L35
M00_L33:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       lea       rcx,[rbp-0A0]
       mov       r9d,r12d
       mov       r8,r15
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FF91CB5F1E0]; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-0A0]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       lea       rcx,[rbp-48]
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FF91CB5F1F8]; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableDictionary`2<System.__Canon,System.__Canon>)
       mov       [rbp-110],rax
       mov       rcx,[rbx+60]
       lea       r8,[rbp-110]
       mov       rdx,7FF91CB8D0E0
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55DB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,158
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2CAA3C00AD0
       mov       rcx,[rdx]
       jmp       near ptr M00_L01
M00_L35:
       mov       rcx,r11
       mov       r11,7FF91C2B0C60
       call      qword ptr [r11]
       jmp       near ptr M00_L33
       sub       rsp,48
       cmp       qword ptr [rbp-148],0
       je        short M00_L36
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-148]
       cmp       [rax],rcx
       je        short M00_L36
       mov       rcx,rax
       mov       r11,7FF91C2B0C60
       call      qword ptr [r11]
M00_L36:
       nop
       add       rsp,48
       ret
; Total bytes of code 1883
```
```assembly
; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+8]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+44]
       jne       short M01_L01
       mov       ecx,[rbx+0C]
       cmp       ecx,[rdx+38]
       jae       short M01_L03
M01_L00:
       mov       rcx,[rbx]
       mov       rcx,[rcx+10]
       mov       edx,[rbx+0C]
       lea       eax,[rdx+1]
       mov       [rbx+0C],eax
       cmp       edx,[rcx+8]
       jae       short M01_L04
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L02
       mov       rdx,[rcx]
       mov       rsi,[rcx+8]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF91C58C150]
       int       3
M01_L02:
       mov       ecx,[rbx+0C]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+38]
       jb        short M01_L00
M01_L03:
       mov       rax,[rbx]
       mov       eax,[rax+38]
       inc       eax
       mov       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+18],rax
       mov       [rbx+20],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, KeyCollisionBehavior<System.__Canon,System.__Canon>, OperationResult<System.__Canon,System.__Canon> ByRef)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A0
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       xor       eax,eax
       mov       [rsp+90],rax
       mov       [rsp+98],r8
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
M02_L00:
       cmp       qword ptr [rdi],0
       jne       short M02_L04
       mov       r14,[rsp+120]
       mov       dword ptr [r14],1
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L03
M02_L01:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbx],rcx
       mov       [rbx+8],rbp
       mov       r15,[rsp+100]
       mov       [rbx+10],r15
M02_L02:
       mov       rax,rbx
       add       rsp,0A0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF91CBEE4E8
       call      qword ptr [7FF91C36C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FF91CBEE2C8
       call      qword ptr [7FF91C36C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L06:
       mov       [rsp+40],rbp
       mov       r15,[rsp+100]
       mov       [rsp+48],r15
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+40]
       lea       r8,[rsp+30]
       mov       rcx,[rsp+108]
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M02_L10
       mov       r13d,[rsp+118]
       cmp       r13d,3
       ja        short M02_L07
       mov       ecx,r13d
       lea       rax,[7FF91CADCC40]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M02_L00]
       add       rax,rdx
       jmp       rax
M02_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF91CB5ED48]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
       xor       r8d,r8d
       mov       r14,[rsp+120]
       mov       [r14],r8d
       mov       [rsp+40],rbp
       mov       [rsp+48],r15
       lea       r8,[rsp+40]
       mov       r9,[rdi]
       lea       rcx,[rsp+50]
       mov       rdx,rsi
       call      qword ptr [7FF91CB5ED90]
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rsp+60]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       lea       r13,[rdi+8]
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FF91CBEE430
       call      qword ptr [7FF91C36C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L09:
       mov       rdx,[r13+8]
       mov       rcx,[rsp+110]
       mov       r8,r15
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M02_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB5ED18]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB5ED30]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF91C6E5E00]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF91CB5ED18]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB5ED30]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6E5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L10:
       mov       rcx,[rdi]
       cmp       [rcx],cl
       mov       [rsp+40],rbp
       mov       [rsp+48],r15
       mov       r13,[rsp+108]
       mov       [rsp+20],r13
       lea       rdx,[rsp+40]
       mov       r9d,[rcx+18]
       xor       r8d,r8d
       call      qword ptr [7FF91CB5ED60]
       test      eax,eax
       jge       short M02_L11
       mov       r14,[rsp+120]
       mov       dword ptr [r14],1
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,[rdi]
       mov       [rsp+30],rbp
       mov       [rsp+38],r15
       lea       rdx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB5ED78]
       mov       r9,rax
       lea       r8,[rsp+40]
       lea       rcx,[rsp+68]
       mov       rdx,rsi
       call      qword ptr [7FF91CB5ED90]
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rax,[rsp+78]
       mov       [rbx+10],rax
       jmp       near ptr M02_L02
M02_L11:
       mov       r13d,[rsp+118]
       cmp       r13d,3
       ja        short M02_L12
       mov       ecx,r13d
       lea       rdx,[7FF91CADCC50]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M02_L00]
       add       rdx,r8
       jmp       rdx
M02_L12:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FF91CB5ED48]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
       xor       ecx,ecx
       mov       r14,[rsp+120]
       mov       [r14],ecx
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,[rdi]
       mov       [rsp+30],rbp
       mov       [rsp+38],r15
       lea       r8,[rsp+30]
       mov       edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB5EDA8]
       mov       r9,rax
       lea       r8,[rsp+40]
       lea       rcx,[rsp+80]
       mov       rdx,rsi
       call      qword ptr [7FF91CB5ED90]
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rsp+90]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       mov       rcx,[rdi]
       mov       edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB5EDC0]
       mov       r13,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FF91CBEE430
       call      qword ptr [7FF91C36C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L14:
       mov       rdx,[r13+8]
       mov       rcx,[rsp+110]
       mov       r8,r15
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB5ED18]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB5ED30]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF91C6E5E00]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M02_L15:
       mov       r14,[rsp+120]
       mov       dword ptr [r14],2
       vmovdqu   xmm0,xmmword ptr [rdi]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rdi+10]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF91CB5ED18]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB5ED30]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6E5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 1163
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M03_L00:
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
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       [rsp+0D0],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       rbp,r9
       mov       r15,[rsp+148]
       mov       r14,[rsp+150]
       mov       byte ptr [r15],0
       cmp       qword ptr [rbx+8],0
       je        near ptr M03_L19
       mov       r13,rbx
       cmp       edi,[r13+18]
       jg        near ptr M03_L11
       cmp       edi,[r13+18]
       jge       near ptr M03_L35
       mov       r12,[r13+8]
       cmp       [r12],r12b
       mov       byte ptr [r15],0
       cmp       qword ptr [r12+8],0
       je        near ptr M03_L10
       mov       rdx,r12
       cmp       edi,[rdx+18]
       jg        near ptr M03_L07
       cmp       edi,[rdx+18]
       jge       near ptr M03_L27
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       [rsp+38],rdx
       mov       rcx,[rdx+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55C08]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        near ptr M03_L26
       cmp       byte ptr [r12+1C],0
       jne       near ptr M03_L24
       test      rsi,rsi
       je        short M03_L01
       lea       rcx,[r12+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rcx,[r12+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L42
       cmp       ecx,0FF
       ja        near ptr M03_L42
       mov       [r12+1D],cl
       mov       rdi,r12
M03_L02:
       mov       rsi,rdi
M03_L03:
       cmp       byte ptr [r14],0
       je        near ptr M03_L32
       mov       rcx,[r12]
       mov       rdx,rsi
       call      qword ptr [7FF91CB55C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       r12,rax
M03_L04:
       cmp       byte ptr [r14],0
       je        short M03_L06
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L33
       test      r12,r12
       je        short M03_L05
       lea       rcx,[rbx+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M03_L05:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L42
       cmp       ecx,0FF
       ja        near ptr M03_L42
       mov       [rbx+1D],cl
       mov       r13,rbx
M03_L06:
       cmp       byte ptr [r14],0
       je        near ptr M03_L40
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M03_L41
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jl        near ptr M03_L14
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M03_L41
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       js        near ptr M03_L17
       mov       rdx,r13
       call      qword ptr [7FF91CB55CE0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       near ptr M03_L18
M03_L07:
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       [rsp+38],rdx
       mov       rcx,[rdx+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55C08]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       mov       rsi,[rsp+38]
       je        near ptr M03_L03
       cmp       byte ptr [r12+1C],0
       jne       near ptr M03_L22
       test      rdi,rdi
       je        short M03_L08
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M03_L08:
       mov       rcx,[r12+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L42
       cmp       ecx,0FF
       ja        near ptr M03_L42
       mov       [r12+1D],cl
       mov       rsi,r12
M03_L09:
       jmp       near ptr M03_L03
M03_L10:
       mov       byte ptr [r14],1
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+20],r12
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,rsi
       mov       r9,r12
       call      qword ptr [7FF91CB55C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r12,rbp
       jmp       near ptr M03_L04
M03_L11:
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55C08]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        near ptr M03_L06
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L20
       test      rdi,rdi
       je        short M03_L12
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M03_L12:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L42
       cmp       ecx,0FF
       ja        near ptr M03_L42
       mov       [rbx+1D],cl
       mov       r13,rbx
M03_L13:
       jmp       near ptr M03_L06
M03_L14:
       cmp       edx,0FFFFFFFE
       jle       short M03_L15
       mov       rax,r13
       jmp       short M03_L18
M03_L15:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M03_L41
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M03_L16
       mov       rdx,r13
       call      qword ptr [7FF91CB55CC8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       short M03_L18
M03_L16:
       mov       rdx,r13
       call      qword ptr [7FF91CB55CB0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       short M03_L18
M03_L17:
       mov       rdx,r13
       call      qword ptr [7FF91CB55CF8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M03_L18:
       nop
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
M03_L19:
       mov       byte ptr [r14],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rbp+18],edi
       lea       rdi,[rbp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+1C],0
       movzx     eax,byte ptr [rbx+1D]
       add       eax,1
       jo        near ptr M03_L42
       cmp       eax,0FF
       ja        near ptr M03_L42
       mov       [rbp+1D],al
       mov       rax,rbp
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
M03_L20:
       mov       r13d,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+0B8],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+0C8],rcx
       mov       rsi,[rbx+8]
       test      rdi,rdi
       jne       short M03_L21
       mov       rdi,[rbx+10]
M03_L21:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       vmovdqu   xmm0,xmmword ptr [rsp+0B8]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+0C8]
       mov       [rsp+68],r8
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,r13d
       mov       rcx,rbp
       mov       r9,rsi
       call      qword ptr [7FF91CB55C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r13,rbp
       jmp       near ptr M03_L13
M03_L22:
       mov       esi,[r12+18]
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       rcx,[r12+30]
       mov       [rsp+0B0],rcx
       mov       rbp,[r12+8]
       test      rdi,rdi
       jne       short M03_L23
       mov       rdi,[r12+10]
M03_L23:
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+0B0]
       mov       [rsp+68],r8
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,esi
       mov       rcx,r15
       mov       r9,rbp
       call      qword ptr [7FF91CB55C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdx,r15
       mov       rsi,rdx
       jmp       near ptr M03_L09
M03_L24:
       mov       edi,[r12+18]
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       mov       rcx,[r12+30]
       mov       [rsp+98],rcx
       test      rsi,rsi
       jne       short M03_L25
       mov       rsi,[r12+8]
M03_L25:
       mov       rbp,[r12+10]
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       vmovdqu   xmm0,xmmword ptr [rsp+88]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+98]
       mov       [rsp+68],r8
       mov       [rsp+20],rbp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,edi
       mov       rcx,r15
       mov       r9,rsi
       call      qword ptr [7FF91CB55C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdx,r15
       mov       rdi,rdx
       jmp       near ptr M03_L02
M03_L26:
       mov       rsi,[rsp+38]
       jmp       near ptr M03_L03
M03_L27:
       mov       rcx,[r12]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L28
       jmp       short M03_L29
M03_L28:
       mov       rdx,7FF91CBEDC78
       call      qword ptr [7FF91C36C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L29:
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       rdx,[r12+30]
       mov       [rsp+68],rdx
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdx,[rsi+10]
       mov       [rsp+50],rdx
       lea       rdx,[rsp+58]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L30
       mov       byte ptr [r14],0
       jmp       near ptr M03_L04
M03_L30:
       cmp       byte ptr [rsp+140],0
       je        short M03_L31
       mov       byte ptr [r14],1
       mov       byte ptr [r15],1
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r9,[r12+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[r12+8]
       mov       rcx,r15
       mov       edx,edi
       mov       r8,rsi
       call      qword ptr [7FF91CB55C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdi,r15
       mov       rsi,rdi
       jmp       near ptr M03_L03
M03_L31:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB5ED18]
       mov       r12,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r14
       mov       rcx,r12
       call      qword ptr [7FF91CB5ED30]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6E5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L32:
       mov       r12,rsi
       jmp       near ptr M03_L04
M03_L33:
       mov       r13d,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+80],rcx
       test      r12,r12
       jne       short M03_L34
       mov       r12,[rbx+8]
M03_L34:
       mov       rsi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       vmovdqu   xmm0,xmmword ptr [rsp+70]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+80]
       mov       [rsp+68],r8
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,r13d
       mov       rcx,rdi
       mov       r9,r12
       call      qword ptr [7FF91CB55C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r13,rdi
       jmp       near ptr M03_L06
M03_L35:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L36
       jmp       short M03_L37
M03_L36:
       mov       rdx,7FF91CBEDC78
       call      qword ptr [7FF91C36C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L37:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       rdx,[rbx+30]
       mov       [rsp+68],rdx
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdx,[rsi+10]
       mov       [rsp+50],rdx
       lea       rdx,[rsp+58]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L38
       mov       byte ptr [r14],0
       mov       rax,rbx
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
M03_L38:
       cmp       byte ptr [rsp+140],0
       je        short M03_L39
       mov       byte ptr [r14],1
       mov       byte ptr [r15],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r9,[rbx+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[rbx+8]
       mov       rcx,r13
       mov       edx,edi
       mov       r8,rsi
       call      qword ptr [7FF91CB55C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       jmp       near ptr M03_L06
M03_L39:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB5ED18]
       mov       r15,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF91CB5ED30]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF91C6E5E00]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M03_L40:
       mov       rax,r13
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
M03_L41:
       mov       ecx,869
       mov       rdx,7FF91CB6DDC8
       call      qword ptr [7FF91C5877B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB5ED00]
       int       3
M03_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2214
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       [rsp+60],rax
       mov       [rsp+68],rcx
       mov       rbx,rcx
       mov       rsi,r8
       cmp       byte ptr [rbx+1C],0
       jne       short M04_L02
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M04_L00:
       test      rsi,rsi
       je        short M04_L01
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M04_L01:
       mov       rax,[rbx+8]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rbx+10]
       movzx     ecx,byte ptr [rcx+1D]
       cmp       eax,ecx
       cmovl     eax,ecx
       add       eax,1
       jo        near ptr M04_L05
       cmp       eax,0FF
       ja        near ptr M04_L05
       mov       [rbx+1D],al
       mov       rax,rbx
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L02:
       mov       edi,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+60],rcx
       mov       rbp,rdx
       test      rbp,rbp
       jne       short M04_L03
       mov       rbp,[rbx+8]
M04_L03:
       test      rsi,rsi
       jne       short M04_L04
       mov       rsi,[rbx+10]
M04_L04:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r8,[rsp+60]
       mov       [rsp+48],r8
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,edi
       mov       rcx,r14
       mov       r9,rbp
       call      qword ptr [7FF91CB55C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rax,r14
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 267
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L04
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rbx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       cmp       eax,2
       jge       short M05_L02
       cmp       eax,0FFFFFFFE
       jle       short M05_L00
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FF91CB55C80]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       test      eax,eax
       jg        short M05_L01
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB55CB0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB55CC8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L02:
       mov       rdx,[rbx+10]
       mov       rcx,rsi
       call      qword ptr [7FF91CB55C80]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       test      eax,eax
       jl        short M05_L03
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB55CE0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB55CF8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L04:
       mov       ecx,869
       mov       rdx,7FF91CB6DDC8
       call      qword ptr [7FF91C5877B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB5ED00]
       int       3
; Total bytes of code 201
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rbp,r9
       mov       r14,[rsp+80]
       cmp       [rbx],ebx
       test      rbp,rbp
       je        short M06_L00
       test      r14,r14
       je        near ptr M06_L01
       mov       [rbx+18],edx
       lea       rdi,[rbx+20]
       mov       rsi,r8
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r15d,byte ptr [rsp+88]
       mov       [rbx+1C],r15b
       movzx     ecx,byte ptr [rbp+1D]
       movzx     edx,byte ptr [r14+1D]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        short M06_L02
       cmp       ecx,0FF
       ja        short M06_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       mov       ecx,847
       mov       rdx,7FF91CB6DDC8
       call      qword ptr [7FF91C5877B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB5ED00]
       int       3
M06_L01:
       mov       ecx,851
       mov       rdx,7FF91CB6DDC8
       call      qword ptr [7FF91C5877B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB5ED00]
       int       3
M06_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 220
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r9d
       test      r8,r8
       je        short M07_L00
       mov       rcx,rbx
       mov       rdx,r8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rbx+8],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       mov       ecx,4AB
       mov       rdx,7FF91CB6DDC8
       call      qword ptr [7FF91C5877B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB5ED00]
       int       3
; Total bytes of code 69
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableDictionary`2<System.__Canon,System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rdx
       mov       rbx,r8
       test      rbx,rbx
       je        near ptr M08_L05
       mov       rsi,[rcx]
       mov       edi,[rbx+18]
       add       edi,[rcx+8]
       test      rsi,rsi
       je        near ptr M08_L08
       cmp       [rbx+8],rsi
       je        near ptr M08_L09
       cmp       qword ptr [rsi+8],0
       je        near ptr M08_L08
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+10]
       test      rdx,rdx
       je        near ptr M08_L06
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0E8]
       test      rdx,rdx
       je        near ptr M08_L04
M08_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax+8]
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M08_L02
       test      rbx,rbx
       je        short M08_L01
       mov       r14d,[rsi+18]
       lea       rcx,[rsi+20]
       mov       r15,[rcx]
       vmovdqu   xmm0,xmmword ptr [rcx]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       mov       rax,[rcx+10]
       mov       [rsp+38],rax
       vmovdqu   xmm0,xmmword ptr [rsp+28]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rcx,[rsp+38]
       mov       [rsp+58],rcx
       mov       rcx,offset System.Collections.Immutable.ImmutableDictionary`2+<>c[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<.cctor>b__109_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>)
       cmp       [rbx+18],rcx
       jne       near ptr M08_L07
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       test      r15,r15
       je        short M08_L01
       cmp       byte ptr [r15+1C],0
       jne       short M08_L01
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55DA0]; System.Collections.Immutable.ImmutableList`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Freeze()
       mov       rcx,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55DA0]; System.Collections.Immutable.ImmutableList`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Freeze()
       mov       byte ptr [r15+1C],1
M08_L01:
       mov       rcx,[rsi+8]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55D58]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>>)
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55D58]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>>)
       mov       byte ptr [rsi+1C],1
M08_L02:
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+18],edi
       mov       rbx,rbp
M08_L03:
       mov       rax,rbx
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
       mov       rdx,7FF91CC20778
       call      qword ptr [7FF91C36C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L00
M08_L05:
       mov       ecx,737
       mov       rdx,7FF91CB6DDC8
       call      qword ptr [7FF91C5877B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB5ED00]
       int       3
M08_L06:
       mov       ecx,6DB
       mov       rdx,7FF91CB6DDC8
       call      qword ptr [7FF91C5877B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB5ED00]
       int       3
M08_L07:
       mov       [rsp+40],r14d
       mov       [rsp+48],r15
       lea       rdx,[rsp+40]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       near ptr M08_L01
M08_L08:
       mov       rcx,rbx
       call      qword ptr [7FF91CB5F000]
       mov       rbx,rax
       jmp       near ptr M08_L03
M08_L09:
       jmp       near ptr M08_L03
; Total bytes of code 523
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M10_L00
       ret
M10_L00:
       jmp       qword ptr [7FF91C365C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ToImmutableDictionary()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,158
       lea       rbp,[rsp+190]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-140],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       cmp       [rsi],sil
       mov       rcx,1B97BC00A20
       mov       r14,[rcx]
       mov       r15,[r14+8]
       mov       r13,[r14+10]
       xor       r12d,r12d
       mov       ecx,[rsi+38]
       sub       ecx,[rsi+40]
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[rsi+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       mov       [rbp-0C8],rsi
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-0C8]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
       mov       rcx,rdx
M00_L01:
       mov       [rbp-148],rcx
M00_L02:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-148]
       cmp       [rcx],rdx
       jne       near ptr M00_L30
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF91C6F7F30]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L03:
       test      eax,eax
       je        near ptr M00_L32
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-148]
       cmp       [rcx],rdx
       jne       near ptr M00_L21
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-58],xmm0
M00_L04:
       cmp       qword ptr [rbp-58],0
       je        near ptr M00_L31
       mov       rdx,[r13+8]
       mov       r11,offset MT_System.Collections.Generic.StringEqualityComparer
       cmp       [rdx],r11
       jne       near ptr M00_L25
       mov       rdx,[rbp-58]
       add       rdx,0C
       mov       r11,[rbp-58]
       mov       r11d,[r11+8]
       add       r11d,r11d
       mov       eax,0E5606BF1
       mov       r8d,1F6C326E
       cmp       r11d,8
       jb        near ptr M00_L13
       mov       r10d,r11d
       shr       r10d,3
M00_L05:
       add       eax,[rdx]
       mov       r9d,[rdx+4]
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
       add       rdx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L05
       test      r11b,4
       jne       near ptr M00_L14
M00_L06:
       mov       r10d,r11d
       and       r10,7
       mov       edx,[rdx+r10-4]
       shr       edx,8
       or        edx,80000000
       not       r11d
       shl       r11d,3
       shrx      edx,edx,r11d
M00_L07:
       add       edx,eax
       mov       r11d,r8d
       xor       r11d,edx
       rol       edx,14
       add       edx,r11d
       rol       r11d,9
       xor       r11d,edx
       rol       edx,1B
       add       edx,r11d
       rol       r11d,13
       xor       r11d,edx
       mov       esi,edx
       rol       esi,14
       add       esi,r11d
       rol       r11d,9
       xor       r11d,esi
       rol       esi,1B
       add       esi,r11d
       mov       edi,r11d
       rol       edi,13
       xor       esi,edi
M00_L08:
       cmp       [r15],r15b
       mov       rdx,r15
       cmp       qword ptr [r15+8],0
       jne       near ptr M00_L17
M00_L09:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
M00_L10:
       vmovdqu   xmm0,xmmword ptr [rbp-0E0]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rdx,[rbp-0D0]
       mov       [rbp-60],rdx
       mov       rdx,[rbp-50]
       mov       [rsp+20],rdx
       mov       [rsp+28],r13
       mov       rdx,[r13+10]
       mov       [rsp+30],rdx
       mov       dword ptr [rsp+38],2
       lea       rdx,[rbp-78]
       mov       [rsp+40],rdx
       lea       rdx,[rbp-90]
       lea       rcx,[rbp-70]
       mov       r9,[rbp-58]
       mov       r8,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket
       call      qword ptr [7FF91CB65AA0]; System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, KeyCollisionBehavior<System.__Canon,System.__Canon>, OperationResult<System.__Canon,System.__Canon> ByRef)
       mov       rcx,[rbp-90]
       test      rcx,rcx
       je        near ptr M00_L20
       vmovdqu   xmm0,xmmword ptr [rbp-90]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       mov       r8,[rbp-80]
       mov       [rbp-0F8],r8
       mov       [rbp-108],rcx
       xor       ecx,ecx
       mov       [rbp-0E8],ecx
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L19
       mov       rdi,r15
       cmp       esi,[rdi+18]
       jg        near ptr M00_L18
       cmp       esi,[rdi+18]
       jge       near ptr M00_L27
       mov       dword ptr [rsp+20],1
       lea       rcx,[rbp-0E8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0F0]
       mov       [rsp+30],rcx
       mov       rcx,[rdi+8]
       lea       r8,[rbp-108]
       mov       edx,esi
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65B18]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       mov       rdx,rax
       cmp       byte ptr [rbp-0F0],0
       je        short M00_L11
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FF91CB65B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       rdi,rax
M00_L11:
       cmp       byte ptr [rbp-0F0],0
       je        near ptr M00_L29
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FF91CB65B60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       r15,rax
M00_L12:
       cmp       dword ptr [rbp-78],1
       jne       near ptr M00_L02
       inc       r12d
       jmp       near ptr M00_L02
M00_L13:
       cmp       r11d,4
       jb        near ptr M00_L22
M00_L14:
       add       eax,[rdx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L06
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M00_L15:
       mov       rdx,[rdx+8]
M00_L16:
       cmp       qword ptr [rdx+8],0
       je        near ptr M00_L09
M00_L17:
       mov       r9d,[rdx+18]
       cmp       esi,r9d
       je        near ptr M00_L26
       jle       short M00_L15
       mov       rdx,[rdx+10]
       jmp       short M00_L16
M00_L18:
       mov       dword ptr [rsp+20],1
       lea       rcx,[rbp-0E8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0F0]
       mov       [rsp+30],rcx
       mov       rcx,[rdi+10]
       lea       r8,[rbp-108]
       mov       edx,esi
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65B18]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rbp-0F0],0
       je        near ptr M00_L11
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF91CB65B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       jmp       near ptr M00_L11
M00_L19:
       mov       dword ptr [rbp-0F0],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rbp-108]
       mov       rcx,rdi
       mov       edx,esi
       mov       r9,r15
       call      qword ptr [7FF91CB65B30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r15,rdi
       jmp       near ptr M00_L12
M00_L20:
       lea       r8,[rbp-0E8]
       mov       rcx,r15
       mov       edx,esi
       call      qword ptr [7FF91CB6F0D8]
       mov       r15,rax
       jmp       near ptr M00_L12
M00_L21:
       lea       rdx,[rbp-58]
       mov       r11,7FF91C2C0C50
       call      qword ptr [r11]
       mov       rcx,[rbp-148]
       jmp       near ptr M00_L04
M00_L22:
       mov       r10d,80
       test      r11b,1
       je        short M00_L23
       mov       r10d,r11d
       and       r10,2
       movzx     r10d,byte ptr [rdx+r10]
       or        r10d,8000
M00_L23:
       test      r11b,2
       je        short M00_L24
       shl       r10d,10
       movzx     edx,word ptr [rdx]
       or        r10d,edx
       mov       edx,r10d
       jmp       near ptr M00_L07
M00_L24:
       mov       edx,r10d
       jmp       near ptr M00_L07
M00_L25:
       mov       rcx,rdx
       mov       rdx,[rbp-58]
       mov       r11,7FF91C2C0C58
       call      qword ptr [r11]
       mov       esi,eax
       mov       rcx,[rbp-148]
       jmp       near ptr M00_L08
M00_L26:
       vmovdqu   xmm0,xmmword ptr [rdx+20]
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       mov       r9,[rdx+30]
       mov       [rbp-0D0],r9
       jmp       near ptr M00_L10
M00_L27:
       vmovdqu   xmm0,xmmword ptr [r15+20]
       vmovdqu   xmmword ptr [rbp-128],xmm0
       mov       r8,[r15+30]
       mov       [rbp-118],r8
       vmovdqu   xmm0,xmmword ptr [rbp-108]
       vmovdqu   xmmword ptr [rbp-140],xmm0
       mov       r8,[rbp-0F8]
       mov       [rbp-130],r8
       lea       r8,[rbp-140]
       lea       rdx,[rbp-128]
       mov       rcx,r13
       mov       r11,7FF91C2C0C68
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L28
       xor       ecx,ecx
       mov       [rbp-0F0],ecx
       jmp       near ptr M00_L12
M00_L28:
       mov       dword ptr [rbp-0F0],1
       mov       dword ptr [rbp-0E8],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r9,[r15+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[r15+8]
       lea       r8,[rbp-108]
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF91CB65B30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       jmp       near ptr M00_L11
M00_L29:
       mov       r15,rdi
       jmp       near ptr M00_L12
M00_L30:
       mov       r11,7FF91C2C0C48
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L31:
       mov       ecx,717
       mov       rdx,7FF91CB7C508
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6ECB8]
       int       3
M00_L32:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r11,[rbp-148]
       cmp       [r11],rcx
       jne       near ptr M00_L35
M00_L33:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       lea       rcx,[rbp-0A0]
       mov       r9d,r12d
       mov       r8,r15
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FF91CB6F1C8]; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-0A0]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       lea       rcx,[rbp-48]
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FF91CB6F1E0]; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableDictionary`2<System.__Canon,System.__Canon>)
       mov       [rbp-110],rax
       mov       rcx,[rbx+60]
       lea       r8,[rbp-110]
       mov       rdx,7FF91CB9B898
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65CC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,158
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1B97BC00AD0
       mov       rcx,[rdx]
       jmp       near ptr M00_L01
M00_L35:
       mov       rcx,r11
       mov       r11,7FF91C2C0C60
       call      qword ptr [r11]
       jmp       near ptr M00_L33
       sub       rsp,48
       cmp       qword ptr [rbp-148],0
       je        short M00_L36
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-148]
       cmp       [rax],rcx
       je        short M00_L36
       mov       rcx,rax
       mov       r11,7FF91C2C0C60
       call      qword ptr [r11]
M00_L36:
       nop
       add       rsp,48
       ret
; Total bytes of code 1883
```
```assembly
; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+8]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+44]
       jne       short M01_L01
       mov       ecx,[rbx+0C]
       cmp       ecx,[rdx+38]
       jae       short M01_L03
M01_L00:
       mov       rcx,[rbx]
       mov       rcx,[rcx+10]
       mov       edx,[rbx+0C]
       lea       eax,[rdx+1]
       mov       [rbx+0C],eax
       cmp       edx,[rcx+8]
       jae       short M01_L04
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L02
       mov       rdx,[rcx]
       mov       rsi,[rcx+8]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF91C59C150]
       int       3
M01_L02:
       mov       ecx,[rbx+0C]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+38]
       jb        short M01_L00
M01_L03:
       mov       rax,[rbx]
       mov       eax,[rax+38]
       inc       eax
       mov       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+18],rax
       mov       [rbx+20],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, KeyCollisionBehavior<System.__Canon,System.__Canon>, OperationResult<System.__Canon,System.__Canon> ByRef)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A0
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       xor       eax,eax
       mov       [rsp+90],rax
       mov       [rsp+98],r8
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
M02_L00:
       cmp       qword ptr [rdi],0
       jne       short M02_L04
       mov       r14,[rsp+120]
       mov       dword ptr [r14],1
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L03
M02_L01:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbx],rcx
       mov       [rbx+8],rbp
       mov       r15,[rsp+100]
       mov       [rbx+10],r15
M02_L02:
       mov       rax,rbx
       add       rsp,0A0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF91CBFDB88
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FF91CBFD968
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L06:
       mov       [rsp+40],rbp
       mov       r15,[rsp+100]
       mov       [rsp+48],r15
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+40]
       lea       r8,[rsp+30]
       mov       rcx,[rsp+108]
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M02_L10
       mov       r13d,[rsp+118]
       cmp       r13d,3
       ja        short M02_L07
       mov       ecx,r13d
       lea       rax,[7FF91CAEBB50]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M02_L00]
       add       rax,rdx
       jmp       rax
M02_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF91CB6ED00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
       xor       r8d,r8d
       mov       r14,[rsp+120]
       mov       [r14],r8d
       mov       [rsp+40],rbp
       mov       [rsp+48],r15
       lea       r8,[rsp+40]
       mov       r9,[rdi]
       lea       rcx,[rsp+50]
       mov       rdx,rsi
       call      qword ptr [7FF91CB6ED48]
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rsp+60]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       lea       r13,[rdi+8]
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FF91CBFDAD0
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L09:
       mov       rdx,[r13+8]
       mov       rcx,[rsp+110]
       mov       r8,r15
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M02_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB6ECD0]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB6ECE8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF91CB6ECD0]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB6ECE8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L10:
       mov       rcx,[rdi]
       cmp       [rcx],cl
       mov       [rsp+40],rbp
       mov       [rsp+48],r15
       mov       r13,[rsp+108]
       mov       [rsp+20],r13
       lea       rdx,[rsp+40]
       mov       r9d,[rcx+18]
       xor       r8d,r8d
       call      qword ptr [7FF91CB6ED18]
       test      eax,eax
       jge       short M02_L11
       mov       r14,[rsp+120]
       mov       dword ptr [r14],1
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,[rdi]
       mov       [rsp+30],rbp
       mov       [rsp+38],r15
       lea       rdx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB6ED30]
       mov       r9,rax
       lea       r8,[rsp+40]
       lea       rcx,[rsp+68]
       mov       rdx,rsi
       call      qword ptr [7FF91CB6ED48]
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rax,[rsp+78]
       mov       [rbx+10],rax
       jmp       near ptr M02_L02
M02_L11:
       mov       r13d,[rsp+118]
       cmp       r13d,3
       ja        short M02_L12
       mov       ecx,r13d
       lea       rdx,[7FF91CAEBB60]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M02_L00]
       add       rdx,r8
       jmp       rdx
M02_L12:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FF91CB6ED00]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
       xor       ecx,ecx
       mov       r14,[rsp+120]
       mov       [r14],ecx
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,[rdi]
       mov       [rsp+30],rbp
       mov       [rsp+38],r15
       lea       r8,[rsp+30]
       mov       edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB6ED60]
       mov       r9,rax
       lea       r8,[rsp+40]
       lea       rcx,[rsp+80]
       mov       rdx,rsi
       call      qword ptr [7FF91CB6ED48]
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rsp+90]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       mov       rcx,[rdi]
       mov       edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB6ED78]
       mov       r13,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FF91CBFDAD0
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L14:
       mov       rdx,[r13+8]
       mov       rcx,[rsp+110]
       mov       r8,r15
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB6ECD0]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB6ECE8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M02_L15:
       mov       r14,[rsp+120]
       mov       dword ptr [r14],2
       vmovdqu   xmm0,xmmword ptr [rdi]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rdi+10]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF91CB6ECD0]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB6ECE8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 1163
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M03_L00:
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
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       [rsp+0D0],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       rbp,r9
       mov       r15,[rsp+148]
       mov       r14,[rsp+150]
       mov       byte ptr [r15],0
       cmp       qword ptr [rbx+8],0
       je        near ptr M03_L18
       mov       r13,rbx
       cmp       edi,[r13+18]
       jg        near ptr M03_L10
       cmp       edi,[r13+18]
       jge       near ptr M03_L34
       mov       r12,[r13+8]
       cmp       [r12],r12b
       mov       byte ptr [r15],0
       cmp       qword ptr [r12+8],0
       je        near ptr M03_L09
       mov       rdx,r12
       cmp       edi,[rdx+18]
       jg        near ptr M03_L06
       cmp       edi,[rdx+18]
       jge       near ptr M03_L26
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       [rsp+38],rdx
       mov       rcx,[rdx+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65B18]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       mov       rdi,[rsp+38]
       je        short M03_L02
       cmp       byte ptr [r12+1C],0
       jne       near ptr M03_L24
       test      rsi,rsi
       je        short M03_L01
       lea       rcx,[r12+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rcx,[r12+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L41
       cmp       ecx,0FF
       ja        near ptr M03_L41
       mov       [r12+1D],cl
       mov       rdi,r12
M03_L02:
       cmp       byte ptr [r14],0
       je        near ptr M03_L31
       mov       rcx,[r12]
       mov       rdx,rdi
       call      qword ptr [7FF91CB65B60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       r12,rax
M03_L03:
       cmp       byte ptr [r14],0
       je        short M03_L05
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L32
       test      r12,r12
       je        short M03_L04
       lea       rcx,[rbx+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M03_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L41
       cmp       ecx,0FF
       ja        near ptr M03_L41
       mov       [rbx+1D],cl
       mov       r13,rbx
M03_L05:
       cmp       byte ptr [r14],0
       je        near ptr M03_L39
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M03_L40
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jl        near ptr M03_L13
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M03_L40
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       js        near ptr M03_L16
       mov       rdx,r13
       call      qword ptr [7FF91CB65BD8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       near ptr M03_L17
M03_L06:
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       [rsp+38],rdx
       mov       rcx,[rdx+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65B18]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        near ptr M03_L23
       cmp       byte ptr [r12+1C],0
       jne       near ptr M03_L21
       test      rdi,rdi
       je        short M03_L07
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M03_L07:
       mov       rcx,[r12+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L41
       cmp       ecx,0FF
       ja        near ptr M03_L41
       mov       [r12+1D],cl
       mov       rsi,r12
M03_L08:
       mov       rdi,rsi
       jmp       near ptr M03_L02
M03_L09:
       mov       byte ptr [r14],1
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+20],r12
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,rsi
       mov       r9,r12
       call      qword ptr [7FF91CB65B30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r12,rbp
       jmp       near ptr M03_L03
M03_L10:
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65B18]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        near ptr M03_L05
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L19
       test      rdi,rdi
       je        short M03_L11
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M03_L11:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L41
       cmp       ecx,0FF
       ja        near ptr M03_L41
       mov       [rbx+1D],cl
       mov       r13,rbx
M03_L12:
       jmp       near ptr M03_L05
M03_L13:
       cmp       edx,0FFFFFFFE
       jle       short M03_L14
       mov       rax,r13
       jmp       short M03_L17
M03_L14:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M03_L40
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M03_L15
       mov       rdx,r13
       call      qword ptr [7FF91CB65C08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       short M03_L17
M03_L15:
       mov       rdx,r13
       call      qword ptr [7FF91CB65BC0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       short M03_L17
M03_L16:
       mov       rdx,r13
       call      qword ptr [7FF91CB65BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M03_L17:
       nop
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
M03_L18:
       mov       byte ptr [r14],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rbp+18],edi
       lea       rdi,[rbp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+1C],0
       movzx     eax,byte ptr [rbx+1D]
       add       eax,1
       jo        near ptr M03_L41
       cmp       eax,0FF
       ja        near ptr M03_L41
       mov       [rbp+1D],al
       mov       rax,rbp
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
M03_L19:
       mov       r13d,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+0B8],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+0C8],rcx
       mov       rsi,[rbx+8]
       test      rdi,rdi
       jne       short M03_L20
       mov       rdi,[rbx+10]
M03_L20:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       vmovdqu   xmm0,xmmword ptr [rsp+0B8]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+0C8]
       mov       [rsp+68],r8
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,r13d
       mov       rcx,rbp
       mov       r9,rsi
       call      qword ptr [7FF91CB65B30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r13,rbp
       jmp       near ptr M03_L12
M03_L21:
       mov       esi,[r12+18]
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       rcx,[r12+30]
       mov       [rsp+0B0],rcx
       mov       rbp,[r12+8]
       test      rdi,rdi
       jne       short M03_L22
       mov       rdi,[r12+10]
M03_L22:
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+0B0]
       mov       [rsp+68],r8
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,esi
       mov       rcx,r15
       mov       r9,rbp
       call      qword ptr [7FF91CB65B30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdx,r15
       mov       rsi,rdx
       jmp       near ptr M03_L08
M03_L23:
       mov       rdi,[rsp+38]
       jmp       near ptr M03_L02
M03_L24:
       mov       edi,[r12+18]
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       mov       rcx,[r12+30]
       mov       [rsp+98],rcx
       test      rsi,rsi
       jne       short M03_L25
       mov       rsi,[r12+8]
M03_L25:
       mov       rbp,[r12+10]
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       vmovdqu   xmm0,xmmword ptr [rsp+88]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+98]
       mov       [rsp+68],r8
       mov       [rsp+20],rbp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,edi
       mov       rcx,r15
       mov       r9,rsi
       call      qword ptr [7FF91CB65B30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdx,r15
       mov       rdi,rdx
       jmp       near ptr M03_L02
M03_L26:
       mov       rcx,[r12]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+58]
       test      r11,r11
       je        short M03_L27
       jmp       short M03_L28
M03_L27:
       mov       rdx,7FF91CBFD270
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L28:
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       rdx,[r12+30]
       mov       [rsp+68],rdx
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdx,[rsi+10]
       mov       [rsp+50],rdx
       lea       rdx,[rsp+58]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L29
       mov       byte ptr [r14],0
       jmp       near ptr M03_L03
M03_L29:
       cmp       byte ptr [rsp+140],0
       je        short M03_L30
       mov       byte ptr [r14],1
       mov       byte ptr [r15],1
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r9,[r12+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[r12+8]
       mov       rcx,r15
       mov       edx,edi
       mov       r8,rsi
       call      qword ptr [7FF91CB65B30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdi,r15
       jmp       near ptr M03_L02
M03_L30:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB6ECD0]
       mov       r12,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r14
       mov       rcx,r12
       call      qword ptr [7FF91CB6ECE8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L31:
       mov       r12,rdi
       jmp       near ptr M03_L03
M03_L32:
       mov       r13d,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+80],rcx
       test      r12,r12
       jne       short M03_L33
       mov       r12,[rbx+8]
M03_L33:
       mov       rsi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       vmovdqu   xmm0,xmmword ptr [rsp+70]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+80]
       mov       [rsp+68],r8
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,r13d
       mov       rcx,rdi
       mov       r9,r12
       call      qword ptr [7FF91CB65B30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r13,rdi
       jmp       near ptr M03_L05
M03_L34:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+58]
       test      r11,r11
       je        short M03_L35
       jmp       short M03_L36
M03_L35:
       mov       rdx,7FF91CBFD270
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L36:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       rdx,[rbx+30]
       mov       [rsp+68],rdx
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdx,[rsi+10]
       mov       [rsp+50],rdx
       lea       rdx,[rsp+58]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L37
       mov       byte ptr [r14],0
       mov       rax,rbx
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
M03_L37:
       cmp       byte ptr [rsp+140],0
       je        short M03_L38
       mov       byte ptr [r14],1
       mov       byte ptr [r15],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r9,[rbx+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[rbx+8]
       mov       rcx,r13
       mov       edx,edi
       mov       r8,rsi
       call      qword ptr [7FF91CB65B30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       jmp       near ptr M03_L05
M03_L38:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB6ECD0]
       mov       r15,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF91CB6ECE8]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M03_L39:
       mov       rax,r13
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
M03_L40:
       mov       ecx,869
       mov       rdx,7FF91CB7C508
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6ECB8]
       int       3
M03_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2207
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       [rsp+60],rax
       mov       [rsp+68],rcx
       mov       rbx,rcx
       mov       rsi,r8
       cmp       byte ptr [rbx+1C],0
       jne       short M04_L02
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M04_L00:
       test      rsi,rsi
       je        short M04_L01
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M04_L01:
       mov       rax,[rbx+8]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rbx+10]
       movzx     ecx,byte ptr [rcx+1D]
       cmp       eax,ecx
       cmovl     eax,ecx
       add       eax,1
       jo        near ptr M04_L05
       cmp       eax,0FF
       ja        near ptr M04_L05
       mov       [rbx+1D],al
       mov       rax,rbx
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L02:
       mov       edi,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+60],rcx
       mov       rbp,rdx
       test      rbp,rbp
       jne       short M04_L03
       mov       rbp,[rbx+8]
M04_L03:
       test      rsi,rsi
       jne       short M04_L04
       mov       rsi,[rbx+10]
M04_L04:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r8,[rsp+60]
       mov       [rsp+48],r8
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,edi
       mov       rcx,r14
       mov       r9,rbp
       call      qword ptr [7FF91CB65B30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rax,r14
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 267
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L03
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rbx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       cmp       eax,2
       jge       short M05_L01
       cmp       eax,0FFFFFFFE
       jle       short M05_L00
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FF91CB65B90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       test      eax,eax
       jg        short M05_L04
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB65BC0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L01:
       mov       rdx,[rbx+10]
       mov       rcx,rsi
       call      qword ptr [7FF91CB65B90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       test      eax,eax
       jge       short M05_L02
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB65BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L02:
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB65BD8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L03:
       mov       ecx,869
       mov       rdx,7FF91CB7C508
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6ECB8]
       int       3
M05_L04:
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB65C08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
; Total bytes of code 201
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rbp,r9
       mov       r14,[rsp+80]
       cmp       [rbx],ebx
       test      rbp,rbp
       je        short M06_L00
       test      r14,r14
       je        near ptr M06_L01
       mov       [rbx+18],edx
       lea       rdi,[rbx+20]
       mov       rsi,r8
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r15d,byte ptr [rsp+88]
       mov       [rbx+1C],r15b
       movzx     ecx,byte ptr [rbp+1D]
       movzx     edx,byte ptr [r14+1D]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        short M06_L02
       cmp       ecx,0FF
       ja        short M06_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       mov       ecx,847
       mov       rdx,7FF91CB7C508
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6ECB8]
       int       3
M06_L01:
       mov       ecx,851
       mov       rdx,7FF91CB7C508
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6ECB8]
       int       3
M06_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 220
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r9d
       test      r8,r8
       je        short M07_L00
       mov       rcx,rbx
       mov       rdx,r8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rbx+8],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       mov       ecx,4AB
       mov       rdx,7FF91CB7C508
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6ECB8]
       int       3
; Total bytes of code 69
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableDictionary`2<System.__Canon,System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rdx
       mov       rbx,r8
       test      rbx,rbx
       je        near ptr M08_L05
       mov       rsi,[rcx]
       mov       edi,[rbx+18]
       add       edi,[rcx+8]
       test      rsi,rsi
       je        near ptr M08_L08
       cmp       [rbx+8],rsi
       je        near ptr M08_L09
       cmp       qword ptr [rsi+8],0
       je        near ptr M08_L08
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+10]
       test      rdx,rdx
       je        near ptr M08_L06
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0C8]
       test      rdx,rdx
       je        near ptr M08_L04
M08_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax+8]
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M08_L02
       test      rbx,rbx
       je        short M08_L01
       mov       r14d,[rsi+18]
       lea       rcx,[rsi+20]
       mov       r15,[rcx]
       vmovdqu   xmm0,xmmword ptr [rcx]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       mov       rax,[rcx+10]
       mov       [rsp+38],rax
       vmovdqu   xmm0,xmmword ptr [rsp+28]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rcx,[rsp+38]
       mov       [rsp+58],rcx
       mov       rcx,offset System.Collections.Immutable.ImmutableDictionary`2+<>c[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<.cctor>b__109_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>)
       cmp       [rbx+18],rcx
       jne       near ptr M08_L07
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       test      r15,r15
       je        short M08_L01
       cmp       byte ptr [r15+1C],0
       jne       short M08_L01
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65CB0]; System.Collections.Immutable.ImmutableList`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Freeze()
       mov       rcx,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65CB0]; System.Collections.Immutable.ImmutableList`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Freeze()
       mov       byte ptr [r15+1C],1
M08_L01:
       mov       rcx,[rsi+8]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65C68]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>>)
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65C68]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>>)
       mov       byte ptr [rsi+1C],1
M08_L02:
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+18],edi
       mov       rbx,rbp
M08_L03:
       mov       rax,rbx
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
       mov       rdx,7FF91CBFF650
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L00
M08_L05:
       mov       ecx,737
       mov       rdx,7FF91CB7C508
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6ECB8]
       int       3
M08_L06:
       mov       ecx,6DB
       mov       rdx,7FF91CB7C508
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6ECB8]
       int       3
M08_L07:
       mov       [rsp+40],r14d
       mov       [rsp+48],r15
       lea       rdx,[rsp+40]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       near ptr M08_L01
M08_L08:
       mov       rcx,rbx
       call      qword ptr [7FF91CB6EEF8]
       mov       rbx,rax
       jmp       near ptr M08_L03
M08_L09:
       jmp       near ptr M08_L03
; Total bytes of code 523
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M10_L00
       ret
M10_L00:
       jmp       qword ptr [7FF91C375C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ToImmutableDictionary()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,158
       lea       rbp,[rsp+190]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-140],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       cmp       [rsi],sil
       mov       rcx,12F54C00A20
       mov       r14,[rcx]
       mov       r15,[r14+8]
       mov       r13,[r14+10]
       xor       r12d,r12d
       mov       ecx,[rsi+38]
       sub       ecx,[rsi+40]
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[rsi+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       mov       [rbp-0C8],rsi
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-0C8]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
       mov       rcx,rdx
M00_L01:
       mov       [rbp-148],rcx
M00_L02:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-148]
       cmp       [rcx],rdx
       jne       near ptr M00_L30
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF91C6E7F30]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L03:
       test      eax,eax
       je        near ptr M00_L32
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-148]
       cmp       [rcx],rdx
       jne       near ptr M00_L21
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-58],xmm0
M00_L04:
       cmp       qword ptr [rbp-58],0
       je        near ptr M00_L31
       mov       rdx,[r13+8]
       mov       r11,offset MT_System.Collections.Generic.StringEqualityComparer
       cmp       [rdx],r11
       jne       near ptr M00_L25
       mov       rdx,[rbp-58]
       add       rdx,0C
       mov       r11,[rbp-58]
       mov       r11d,[r11+8]
       add       r11d,r11d
       mov       eax,1C0849B0
       mov       r8d,9B158FF2
       cmp       r11d,8
       jb        near ptr M00_L13
       mov       r10d,r11d
       shr       r10d,3
M00_L05:
       add       eax,[rdx]
       mov       r9d,[rdx+4]
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
       add       rdx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L05
       test      r11b,4
       jne       near ptr M00_L14
M00_L06:
       mov       r10d,r11d
       and       r10,7
       mov       edx,[rdx+r10-4]
       shr       edx,8
       or        edx,80000000
       not       r11d
       shl       r11d,3
       shrx      edx,edx,r11d
M00_L07:
       add       edx,eax
       mov       r11d,r8d
       xor       r11d,edx
       rol       edx,14
       add       edx,r11d
       rol       r11d,9
       xor       r11d,edx
       rol       edx,1B
       add       edx,r11d
       rol       r11d,13
       xor       r11d,edx
       mov       esi,edx
       rol       esi,14
       add       esi,r11d
       rol       r11d,9
       xor       r11d,esi
       rol       esi,1B
       add       esi,r11d
       mov       edi,r11d
       rol       edi,13
       xor       esi,edi
M00_L08:
       cmp       [r15],r15b
       mov       rdx,r15
       cmp       qword ptr [r15+8],0
       jne       near ptr M00_L17
M00_L09:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
M00_L10:
       vmovdqu   xmm0,xmmword ptr [rbp-0E0]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rdx,[rbp-0D0]
       mov       [rbp-60],rdx
       mov       rdx,[rbp-50]
       mov       [rsp+20],rdx
       mov       [rsp+28],r13
       mov       rdx,[r13+10]
       mov       [rsp+30],rdx
       mov       dword ptr [rsp+38],2
       lea       rdx,[rbp-78]
       mov       [rsp+40],rdx
       lea       rdx,[rbp-90]
       lea       rcx,[rbp-70]
       mov       r9,[rbp-58]
       mov       r8,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket
       call      qword ptr [7FF91CB55BC0]; System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, KeyCollisionBehavior<System.__Canon,System.__Canon>, OperationResult<System.__Canon,System.__Canon> ByRef)
       mov       rcx,[rbp-90]
       test      rcx,rcx
       je        near ptr M00_L20
       vmovdqu   xmm0,xmmword ptr [rbp-90]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       mov       r8,[rbp-80]
       mov       [rbp-0F8],r8
       mov       [rbp-108],rcx
       xor       ecx,ecx
       mov       [rbp-0E8],ecx
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L19
       mov       rdi,r15
       cmp       esi,[rdi+18]
       jle       near ptr M00_L18
       mov       dword ptr [rsp+20],1
       lea       rcx,[rbp-0E8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0F0]
       mov       [rsp+30],rcx
       mov       rcx,[rdi+10]
       lea       r8,[rbp-108]
       mov       edx,esi
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55C38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rbp-0F0],0
       je        short M00_L11
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF91CB55C68]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       rdi,rax
M00_L11:
       cmp       byte ptr [rbp-0F0],0
       je        near ptr M00_L29
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FF91CB55C80]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M00_L12:
       mov       r15,rax
       cmp       dword ptr [rbp-78],1
       jne       near ptr M00_L02
       inc       r12d
       jmp       near ptr M00_L02
M00_L13:
       cmp       r11d,4
       jb        near ptr M00_L22
M00_L14:
       add       eax,[rdx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L06
       nop       dword ptr [rax]
M00_L15:
       mov       rdx,[rdx+10]
M00_L16:
       cmp       qword ptr [rdx+8],0
       je        near ptr M00_L09
M00_L17:
       mov       r9d,[rdx+18]
       cmp       esi,r9d
       je        near ptr M00_L26
       jg        short M00_L15
       mov       rdx,[rdx+8]
       jmp       short M00_L16
M00_L18:
       cmp       esi,[rdi+18]
       jge       near ptr M00_L27
       mov       dword ptr [rsp+20],1
       lea       rcx,[rbp-0E8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0F0]
       mov       [rsp+30],rcx
       mov       rcx,[rdi+8]
       lea       r8,[rbp-108]
       mov       edx,esi
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55C38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       mov       rdx,rax
       cmp       byte ptr [rbp-0F0],0
       je        near ptr M00_L11
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FF91CB55C68]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       jmp       near ptr M00_L11
M00_L19:
       mov       dword ptr [rbp-0F0],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rbp-108]
       mov       rcx,rdi
       mov       edx,esi
       mov       r9,r15
       call      qword ptr [7FF91CB55C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M00_L12
M00_L20:
       lea       r8,[rbp-0E8]
       mov       rcx,r15
       mov       edx,esi
       call      qword ptr [7FF91CB5F120]
       jmp       near ptr M00_L12
M00_L21:
       lea       rdx,[rbp-58]
       mov       r11,7FF91C2B0C50
       call      qword ptr [r11]
       mov       rcx,[rbp-148]
       jmp       near ptr M00_L04
M00_L22:
       mov       r10d,80
       test      r11b,1
       je        short M00_L23
       mov       r10d,r11d
       and       r10,2
       movzx     r10d,byte ptr [rdx+r10]
       or        r10d,8000
M00_L23:
       test      r11b,2
       je        short M00_L24
       shl       r10d,10
       movzx     edx,word ptr [rdx]
       or        r10d,edx
       mov       edx,r10d
       jmp       near ptr M00_L07
M00_L24:
       mov       edx,r10d
       jmp       near ptr M00_L07
M00_L25:
       mov       rcx,rdx
       mov       rdx,[rbp-58]
       mov       r11,7FF91C2B0C58
       call      qword ptr [r11]
       mov       esi,eax
       mov       rcx,[rbp-148]
       jmp       near ptr M00_L08
M00_L26:
       vmovdqu   xmm0,xmmword ptr [rdx+20]
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       mov       r9,[rdx+30]
       mov       [rbp-0D0],r9
       jmp       near ptr M00_L10
M00_L27:
       vmovdqu   xmm0,xmmword ptr [r15+20]
       vmovdqu   xmmword ptr [rbp-128],xmm0
       mov       r8,[r15+30]
       mov       [rbp-118],r8
       vmovdqu   xmm0,xmmword ptr [rbp-108]
       vmovdqu   xmmword ptr [rbp-140],xmm0
       mov       r8,[rbp-0F8]
       mov       [rbp-130],r8
       lea       r8,[rbp-140]
       lea       rdx,[rbp-128]
       mov       rcx,r13
       mov       r11,7FF91C2B0C68
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L28
       xor       eax,eax
       mov       [rbp-0F0],eax
       mov       rax,r15
       jmp       near ptr M00_L12
M00_L28:
       mov       dword ptr [rbp-0F0],1
       mov       dword ptr [rbp-0E8],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r9,[r15+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[r15+8]
       lea       r8,[rbp-108]
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF91CB55C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       jmp       near ptr M00_L11
M00_L29:
       mov       rax,rdi
       jmp       near ptr M00_L12
M00_L30:
       mov       r11,7FF91C2B0C48
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L31:
       mov       ecx,717
       mov       rdx,7FF91CB6DDC8
       call      qword ptr [7FF91C5877B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB5ECE8]
       int       3
M00_L32:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r11,[rbp-148]
       cmp       [r11],rcx
       jne       near ptr M00_L35
M00_L33:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       lea       rcx,[rbp-0A0]
       mov       r9d,r12d
       mov       r8,r15
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FF91CB5F2A0]; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-0A0]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       lea       rcx,[rbp-48]
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FF91CB5F2B8]; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableDictionary`2<System.__Canon,System.__Canon>)
       mov       [rbp-110],rax
       mov       rcx,[rbx+60]
       lea       r8,[rbp-110]
       mov       rdx,7FF91CB8D0E0
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55DE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,158
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,12F54C00AD0
       mov       rcx,[rdx]
       jmp       near ptr M00_L01
M00_L35:
       mov       rcx,r11
       mov       r11,7FF91C2B0C60
       call      qword ptr [r11]
       jmp       near ptr M00_L33
       sub       rsp,48
       cmp       qword ptr [rbp-148],0
       je        short M00_L36
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-148]
       cmp       [rax],rcx
       je        short M00_L36
       mov       rcx,rax
       mov       r11,7FF91C2B0C60
       call      qword ptr [r11]
M00_L36:
       nop
       add       rsp,48
       ret
; Total bytes of code 1877
```
```assembly
; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+8]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+44]
       jne       short M01_L01
       mov       ecx,[rbx+0C]
       cmp       ecx,[rdx+38]
       jae       short M01_L03
M01_L00:
       mov       rcx,[rbx]
       mov       rcx,[rcx+10]
       mov       edx,[rbx+0C]
       lea       eax,[rdx+1]
       mov       [rbx+0C],eax
       cmp       edx,[rcx+8]
       jae       short M01_L04
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L02
       mov       rdx,[rcx]
       mov       rsi,[rcx+8]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF91C58C150]
       int       3
M01_L02:
       mov       ecx,[rbx+0C]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+38]
       jb        short M01_L00
M01_L03:
       mov       rax,[rbx]
       mov       eax,[rax+38]
       inc       eax
       mov       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+18],rax
       mov       [rbx+20],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, KeyCollisionBehavior<System.__Canon,System.__Canon>, OperationResult<System.__Canon,System.__Canon> ByRef)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A0
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       xor       eax,eax
       mov       [rsp+90],rax
       mov       [rsp+98],r8
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
M02_L00:
       cmp       qword ptr [rdi],0
       jne       short M02_L04
       mov       r14,[rsp+120]
       mov       dword ptr [r14],1
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L03
M02_L01:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbx],rcx
       mov       [rbx+8],rbp
       mov       r15,[rsp+100]
       mov       [rbx+10],r15
M02_L02:
       mov       rax,rbx
       add       rsp,0A0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF91CBEDB28
       call      qword ptr [7FF91C36C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FF91CBED908
       call      qword ptr [7FF91C36C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L06:
       mov       [rsp+40],rbp
       mov       r15,[rsp+100]
       mov       [rsp+48],r15
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+40]
       lea       r8,[rsp+30]
       mov       rcx,[rsp+108]
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M02_L10
       mov       r13d,[rsp+118]
       cmp       r13d,3
       ja        short M02_L07
       mov       ecx,r13d
       lea       rax,[7FF91CADCB30]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M02_L00]
       add       rax,rdx
       jmp       rax
M02_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF91CB5ED60]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
       xor       r8d,r8d
       mov       r14,[rsp+120]
       mov       [r14],r8d
       mov       [rsp+40],rbp
       mov       [rsp+48],r15
       lea       r8,[rsp+40]
       mov       r9,[rdi]
       lea       rcx,[rsp+50]
       mov       rdx,rsi
       call      qword ptr [7FF91CB5EDA8]
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rsp+60]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       lea       r13,[rdi+8]
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FF91CBEDA70
       call      qword ptr [7FF91C36C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L09:
       mov       rdx,[r13+8]
       mov       rcx,[rsp+110]
       mov       r8,r15
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M02_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB5ED00]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB5ED18]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF91C6E5E00]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF91CB5ED00]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB5ED18]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6E5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L10:
       mov       rcx,[rdi]
       cmp       [rcx],cl
       mov       [rsp+40],rbp
       mov       [rsp+48],r15
       mov       r13,[rsp+108]
       mov       [rsp+20],r13
       lea       rdx,[rsp+40]
       mov       r9d,[rcx+18]
       xor       r8d,r8d
       call      qword ptr [7FF91CB5ED78]
       test      eax,eax
       jge       short M02_L11
       mov       r14,[rsp+120]
       mov       dword ptr [r14],1
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,[rdi]
       mov       [rsp+30],rbp
       mov       [rsp+38],r15
       lea       rdx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB5ED90]
       mov       r9,rax
       lea       r8,[rsp+40]
       lea       rcx,[rsp+68]
       mov       rdx,rsi
       call      qword ptr [7FF91CB5EDA8]
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rax,[rsp+78]
       mov       [rbx+10],rax
       jmp       near ptr M02_L02
M02_L11:
       mov       r13d,[rsp+118]
       cmp       r13d,3
       ja        short M02_L12
       mov       ecx,r13d
       lea       rdx,[7FF91CADCB40]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M02_L00]
       add       rdx,r8
       jmp       rdx
M02_L12:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FF91CB5ED60]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
       xor       ecx,ecx
       mov       r14,[rsp+120]
       mov       [r14],ecx
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,[rdi]
       mov       [rsp+30],rbp
       mov       [rsp+38],r15
       lea       r8,[rsp+30]
       mov       edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB5EDC0]
       mov       r9,rax
       lea       r8,[rsp+40]
       lea       rcx,[rsp+80]
       mov       rdx,rsi
       call      qword ptr [7FF91CB5EDA8]
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rsp+90]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       mov       rcx,[rdi]
       mov       edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB5EDD8]
       mov       r13,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FF91CBEDA70
       call      qword ptr [7FF91C36C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L14:
       mov       rdx,[r13+8]
       mov       rcx,[rsp+110]
       mov       r8,r15
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB5ED00]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB5ED18]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF91C6E5E00]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M02_L15:
       mov       r14,[rsp+120]
       mov       dword ptr [r14],2
       vmovdqu   xmm0,xmmword ptr [rdi]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rdi+10]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF91CB5ED00]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB5ED18]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6E5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 1163
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M03_L00:
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
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       [rsp+0D0],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       rbp,r9
       mov       r15,[rsp+148]
       mov       r14,[rsp+150]
       mov       byte ptr [r15],0
       cmp       qword ptr [rbx+8],0
       je        near ptr M03_L19
       mov       r13,rbx
       cmp       edi,[r13+18]
       jle       near ptr M03_L11
       mov       r12,[r13+10]
       cmp       [r12],r12b
       mov       byte ptr [r15],0
       cmp       qword ptr [r12+8],0
       je        near ptr M03_L10
       mov       rdx,r12
       cmp       edi,[rdx+18]
       jle       near ptr M03_L07
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       [rsp+38],rdx
       mov       rcx,[rdx+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55C38]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        near ptr M03_L22
       cmp       byte ptr [r12+1C],0
       jne       near ptr M03_L20
       test      rdi,rdi
       je        short M03_L01
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rcx,[r12+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L42
       cmp       ecx,0FF
       ja        near ptr M03_L42
       mov       [r12+1D],cl
       mov       rbp,r12
M03_L02:
       mov       rdi,rbp
M03_L03:
       cmp       byte ptr [r14],0
       je        near ptr M03_L30
       mov       rcx,[r12]
       mov       rdx,rdi
       call      qword ptr [7FF91CB55C80]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       r12,rax
M03_L04:
       cmp       byte ptr [r14],0
       je        short M03_L06
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L31
       test      r12,r12
       je        short M03_L05
       lea       rcx,[rbx+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M03_L05:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L42
       cmp       ecx,0FF
       ja        near ptr M03_L42
       mov       [rbx+1D],cl
       mov       r13,rbx
M03_L06:
       cmp       byte ptr [r14],0
       je        near ptr M03_L40
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M03_L41
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jl        near ptr M03_L14
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M03_L41
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       js        near ptr M03_L17
       mov       rdx,r13
       call      qword ptr [7FF91CB55CF8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       near ptr M03_L18
M03_L07:
       cmp       edi,[rdx+18]
       jge       near ptr M03_L25
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       [rsp+38],rdx
       mov       rcx,[rdx+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55C38]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       mov       rdi,[rsp+38]
       je        near ptr M03_L03
       cmp       byte ptr [r12+1C],0
       jne       near ptr M03_L23
       test      rsi,rsi
       je        short M03_L08
       lea       rcx,[r12+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M03_L08:
       mov       rcx,[r12+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L42
       cmp       ecx,0FF
       ja        near ptr M03_L42
       mov       [r12+1D],cl
       mov       rdi,r12
M03_L09:
       jmp       near ptr M03_L03
M03_L10:
       mov       byte ptr [r14],1
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+20],r12
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,rsi
       mov       r9,r12
       call      qword ptr [7FF91CB55C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r12,rbp
       jmp       near ptr M03_L04
M03_L11:
       cmp       edi,[r13+18]
       jge       near ptr M03_L35
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55C38]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        near ptr M03_L06
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L33
       test      rsi,rsi
       je        short M03_L12
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M03_L12:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L42
       cmp       ecx,0FF
       ja        near ptr M03_L42
       mov       [rbx+1D],cl
       mov       r13,rbx
M03_L13:
       jmp       near ptr M03_L06
M03_L14:
       cmp       edx,0FFFFFFFE
       jle       short M03_L15
       mov       rax,r13
       jmp       short M03_L18
M03_L15:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M03_L41
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M03_L16
       mov       rdx,r13
       call      qword ptr [7FF91CB55CE0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       short M03_L18
M03_L16:
       mov       rdx,r13
       call      qword ptr [7FF91CB55D10]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       short M03_L18
M03_L17:
       mov       rdx,r13
       call      qword ptr [7FF91CB55D28]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M03_L18:
       nop
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
M03_L19:
       mov       byte ptr [r14],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rbp+18],edi
       lea       rdi,[rbp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+1C],0
       movzx     eax,byte ptr [rbx+1D]
       add       eax,1
       jo        near ptr M03_L42
       cmp       eax,0FF
       ja        near ptr M03_L42
       mov       [rbp+1D],al
       mov       rax,rbp
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
M03_L20:
       mov       ebp,[r12+18]
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rsp+0B8],xmm0
       mov       rcx,[r12+30]
       mov       [rsp+0C8],rcx
       mov       r15,[r12+8]
       test      rdi,rdi
       jne       short M03_L21
       mov       rdi,[r12+10]
M03_L21:
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       vmovdqu   xmm0,xmmword ptr [rsp+0B8]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+0C8]
       mov       [rsp+68],r8
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,ebp
       mov       rcx,rsi
       mov       r9,r15
       call      qword ptr [7FF91CB55C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdx,rsi
       mov       rbp,rdx
       jmp       near ptr M03_L02
M03_L22:
       mov       rdi,[rsp+38]
       jmp       near ptr M03_L03
M03_L23:
       mov       edi,[r12+18]
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       rcx,[r12+30]
       mov       [rsp+0B0],rcx
       test      rsi,rsi
       jne       short M03_L24
       mov       rsi,[r12+8]
M03_L24:
       mov       rbp,[r12+10]
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+0B0]
       mov       [rsp+68],r8
       mov       [rsp+20],rbp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,edi
       mov       rcx,r15
       mov       r9,rsi
       call      qword ptr [7FF91CB55C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdx,r15
       mov       rdi,rdx
       jmp       near ptr M03_L09
M03_L25:
       mov       rcx,[r12]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L26
       jmp       short M03_L27
M03_L26:
       mov       rdx,7FF91CBED1D0
       call      qword ptr [7FF91C36C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L27:
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       rdx,[r12+30]
       mov       [rsp+68],rdx
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdx,[rsi+10]
       mov       [rsp+50],rdx
       lea       rdx,[rsp+58]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L28
       mov       byte ptr [r14],0
       jmp       near ptr M03_L04
M03_L28:
       cmp       byte ptr [rsp+140],0
       je        short M03_L29
       mov       byte ptr [r14],1
       mov       byte ptr [r15],1
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r9,[r12+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[r12+8]
       mov       rcx,r15
       mov       edx,edi
       mov       r8,rsi
       call      qword ptr [7FF91CB55C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdi,r15
       jmp       near ptr M03_L03
M03_L29:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB5ED00]
       mov       r12,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r14
       mov       rcx,r12
       call      qword ptr [7FF91CB5ED18]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6E5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L30:
       mov       r12,rdi
       jmp       near ptr M03_L04
M03_L31:
       mov       r13d,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+98],rcx
       mov       rdi,[rbx+8]
       test      r12,r12
       jne       short M03_L32
       mov       r12,[rbx+10]
M03_L32:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       vmovdqu   xmm0,xmmword ptr [rsp+88]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+98]
       mov       [rsp+68],r8
       mov       [rsp+20],r12
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,r13d
       mov       rcx,rsi
       mov       r9,rdi
       call      qword ptr [7FF91CB55C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r13,rsi
       jmp       near ptr M03_L06
M03_L33:
       mov       r13d,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+80],rcx
       test      rsi,rsi
       jne       short M03_L34
       mov       rsi,[rbx+8]
M03_L34:
       mov       rbp,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       vmovdqu   xmm0,xmmword ptr [rsp+70]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+80]
       mov       [rsp+68],r8
       mov       [rsp+20],rbp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,r13d
       mov       rcx,r15
       mov       r9,rsi
       call      qword ptr [7FF91CB55C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r13,r15
       jmp       near ptr M03_L13
M03_L35:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L36
       jmp       short M03_L37
M03_L36:
       mov       rdx,7FF91CBED1D0
       call      qword ptr [7FF91C36C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L37:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       rdx,[rbx+30]
       mov       [rsp+68],rdx
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdx,[rsi+10]
       mov       [rsp+50],rdx
       lea       rdx,[rsp+58]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L38
       mov       byte ptr [r14],0
       mov       rax,rbx
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
M03_L38:
       cmp       byte ptr [rsp+140],0
       je        short M03_L39
       mov       byte ptr [r14],1
       mov       byte ptr [r15],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r9,[rbx+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[rbx+8]
       mov       rcx,r13
       mov       edx,edi
       mov       r8,rsi
       call      qword ptr [7FF91CB55C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       jmp       near ptr M03_L06
M03_L39:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB5ED00]
       mov       rsi,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FF91CB5ED18]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6E5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L40:
       mov       rax,r13
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
M03_L41:
       mov       ecx,869
       mov       rdx,7FF91CB6DDC8
       call      qword ptr [7FF91C5877B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB5ECE8]
       int       3
M03_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2211
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       [rsp+60],rax
       mov       [rsp+68],rcx
       mov       rbx,rcx
       mov       rsi,r8
       cmp       byte ptr [rbx+1C],0
       jne       short M04_L02
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M04_L00:
       test      rsi,rsi
       je        short M04_L01
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M04_L01:
       mov       rax,[rbx+8]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rbx+10]
       movzx     ecx,byte ptr [rcx+1D]
       cmp       eax,ecx
       cmovl     eax,ecx
       add       eax,1
       jo        near ptr M04_L05
       cmp       eax,0FF
       ja        near ptr M04_L05
       mov       [rbx+1D],al
       mov       rax,rbx
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L02:
       mov       edi,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+60],rcx
       mov       rbp,rdx
       test      rbp,rbp
       jne       short M04_L03
       mov       rbp,[rbx+8]
M04_L03:
       test      rsi,rsi
       jne       short M04_L04
       mov       rsi,[rbx+10]
M04_L04:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r8,[rsp+60]
       mov       [rsp+48],r8
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,edi
       mov       rcx,r14
       mov       r9,rbp
       call      qword ptr [7FF91CB55C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rax,r14
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 267
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L04
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rbx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       cmp       eax,2
       jge       short M05_L02
       cmp       eax,0FFFFFFFE
       jle       short M05_L00
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FF91CB55CB0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       test      eax,eax
       jle       short M05_L01
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB55CE0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB55D10]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L02:
       mov       rdx,[rbx+10]
       mov       rcx,rsi
       call      qword ptr [7FF91CB55CB0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       test      eax,eax
       jl        short M05_L03
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB55CF8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB55D28]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L04:
       mov       ecx,869
       mov       rdx,7FF91CB6DDC8
       call      qword ptr [7FF91C5877B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB5ECE8]
       int       3
; Total bytes of code 201
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rbp,r9
       mov       r14,[rsp+80]
       cmp       [rbx],ebx
       test      rbp,rbp
       je        short M06_L00
       test      r14,r14
       je        near ptr M06_L01
       mov       [rbx+18],edx
       lea       rdi,[rbx+20]
       mov       rsi,r8
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r15d,byte ptr [rsp+88]
       mov       [rbx+1C],r15b
       movzx     ecx,byte ptr [rbp+1D]
       movzx     edx,byte ptr [r14+1D]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        short M06_L02
       cmp       ecx,0FF
       ja        short M06_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       mov       ecx,847
       mov       rdx,7FF91CB6DDC8
       call      qword ptr [7FF91C5877B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB5ECE8]
       int       3
M06_L01:
       mov       ecx,851
       mov       rdx,7FF91CB6DDC8
       call      qword ptr [7FF91C5877B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB5ECE8]
       int       3
M06_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 220
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r9d
       test      r8,r8
       je        short M07_L00
       mov       rcx,rbx
       mov       rdx,r8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rbx+8],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       mov       ecx,4AB
       mov       rdx,7FF91CB6DDC8
       call      qword ptr [7FF91C5877B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB5ECE8]
       int       3
; Total bytes of code 69
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableDictionary`2<System.__Canon,System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rdx
       mov       rbx,r8
       test      rbx,rbx
       je        near ptr M08_L05
       mov       rsi,[rcx]
       mov       edi,[rbx+18]
       add       edi,[rcx+8]
       test      rsi,rsi
       je        near ptr M08_L08
       cmp       [rbx+8],rsi
       je        near ptr M08_L09
       cmp       qword ptr [rsi+8],0
       je        near ptr M08_L08
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+10]
       test      rdx,rdx
       je        near ptr M08_L06
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0E8]
       test      rdx,rdx
       je        near ptr M08_L04
M08_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax+8]
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M08_L02
       test      rbx,rbx
       je        short M08_L01
       mov       r14d,[rsi+18]
       lea       rcx,[rsi+20]
       mov       r15,[rcx]
       vmovdqu   xmm0,xmmword ptr [rcx]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       mov       rax,[rcx+10]
       mov       [rsp+38],rax
       vmovdqu   xmm0,xmmword ptr [rsp+28]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rcx,[rsp+38]
       mov       [rsp+58],rcx
       mov       rcx,offset System.Collections.Immutable.ImmutableDictionary`2+<>c[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<.cctor>b__109_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>)
       cmp       [rbx+18],rcx
       jne       near ptr M08_L07
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       test      r15,r15
       je        short M08_L01
       cmp       byte ptr [r15+1C],0
       jne       short M08_L01
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55DD0]; System.Collections.Immutable.ImmutableList`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Freeze()
       mov       rcx,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55DD0]; System.Collections.Immutable.ImmutableList`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Freeze()
       mov       byte ptr [r15+1C],1
M08_L01:
       mov       rcx,[rsi+8]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55D88]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>>)
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB55D88]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>>)
       mov       byte ptr [rsi+1C],1
M08_L02:
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+18],edi
       mov       rbx,rbp
M08_L03:
       mov       rax,rbx
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
       mov       rdx,7FF91CBEFDA8
       call      qword ptr [7FF91C36C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L00
M08_L05:
       mov       ecx,737
       mov       rdx,7FF91CB6DDC8
       call      qword ptr [7FF91C5877B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB5ECE8]
       int       3
M08_L06:
       mov       ecx,6DB
       mov       rdx,7FF91CB6DDC8
       call      qword ptr [7FF91C5877B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB5ECE8]
       int       3
M08_L07:
       mov       [rsp+40],r14d
       mov       [rsp+48],r15
       lea       rdx,[rsp+40]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       near ptr M08_L01
M08_L08:
       mov       rcx,rbx
       call      qword ptr [7FF91CB5F018]
       mov       rbx,rax
       jmp       near ptr M08_L03
M08_L09:
       jmp       near ptr M08_L03
; Total bytes of code 523
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M10_L00
       ret
M10_L00:
       jmp       qword ptr [7FF91C365C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ToImmutableDictionary()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,158
       lea       rbp,[rsp+190]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-140],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       cmp       [rsi],sil
       mov       rcx,2E3F5802A18
       mov       r14,[rcx]
       mov       r15,[r14+8]
       mov       r13,[r14+10]
       xor       r12d,r12d
       mov       ecx,[rsi+38]
       sub       ecx,[rsi+40]
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[rsi+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       mov       [rbp-0C8],rsi
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-0C8]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
       mov       rcx,rdx
M00_L01:
       mov       [rbp-148],rcx
M00_L02:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-148]
       cmp       [rcx],rdx
       jne       near ptr M00_L30
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF91C6F7F30]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L03:
       test      eax,eax
       je        near ptr M00_L32
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-148]
       cmp       [rcx],rdx
       jne       near ptr M00_L21
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-58],xmm0
M00_L04:
       cmp       qword ptr [rbp-58],0
       je        near ptr M00_L31
       mov       rdx,[r13+8]
       mov       r11,offset MT_System.Collections.Generic.StringEqualityComparer
       cmp       [rdx],r11
       jne       near ptr M00_L25
       mov       rdx,[rbp-58]
       add       rdx,0C
       mov       r11,[rbp-58]
       mov       r11d,[r11+8]
       add       r11d,r11d
       mov       eax,91C20E75
       mov       r8d,2068D543
       cmp       r11d,8
       jb        near ptr M00_L11
       mov       r10d,r11d
       shr       r10d,3
M00_L05:
       add       eax,[rdx]
       mov       r9d,[rdx+4]
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
       add       rdx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L05
       test      r11b,4
       jne       near ptr M00_L12
M00_L06:
       mov       r10d,r11d
       and       r10,7
       mov       edx,[rdx+r10-4]
       shr       edx,8
       or        edx,80000000
       not       r11d
       shl       r11d,3
       shrx      edx,edx,r11d
M00_L07:
       add       edx,eax
       mov       r11d,r8d
       xor       r11d,edx
       rol       edx,14
       add       edx,r11d
       rol       r11d,9
       xor       r11d,edx
       rol       edx,1B
       add       edx,r11d
       rol       r11d,13
       xor       r11d,edx
       mov       esi,edx
       rol       esi,14
       add       esi,r11d
       rol       r11d,9
       xor       r11d,esi
       rol       esi,1B
       add       esi,r11d
       mov       edi,r11d
       rol       edi,13
       xor       esi,edi
M00_L08:
       cmp       [r15],r15b
       mov       rdx,r15
       cmp       qword ptr [r15+8],0
       jne       near ptr M00_L15
M00_L09:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
M00_L10:
       vmovdqu   xmm0,xmmword ptr [rbp-0E0]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rdx,[rbp-0D0]
       mov       [rbp-60],rdx
       mov       rdx,[rbp-50]
       mov       [rsp+20],rdx
       mov       [rsp+28],r13
       mov       rdx,[r13+10]
       mov       [rsp+30],rdx
       mov       dword ptr [rsp+38],2
       lea       rdx,[rbp-78]
       mov       [rsp+40],rdx
       lea       rdx,[rbp-90]
       lea       rcx,[rbp-70]
       mov       r9,[rbp-58]
       mov       r8,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket
       call      qword ptr [7FF91CB65B60]; System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, KeyCollisionBehavior<System.__Canon,System.__Canon>, OperationResult<System.__Canon,System.__Canon> ByRef)
       mov       rcx,[rbp-90]
       test      rcx,rcx
       je        near ptr M00_L20
       vmovdqu   xmm0,xmmword ptr [rbp-90]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       mov       r8,[rbp-80]
       mov       [rbp-0F8],r8
       mov       [rbp-108],rcx
       xor       ecx,ecx
       mov       [rbp-0E8],ecx
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L19
       mov       rdi,r15
       cmp       esi,[rdi+18]
       jle       near ptr M00_L16
       mov       dword ptr [rsp+20],1
       lea       rcx,[rbp-0E8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0F0]
       mov       [rsp+30],rcx
       mov       rcx,[rdi+10]
       lea       r8,[rbp-108]
       mov       edx,esi
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65BD8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rbp-0F0],0
       je        near ptr M00_L17
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF91CB65C08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       jmp       near ptr M00_L17
M00_L11:
       cmp       r11d,4
       jb        near ptr M00_L22
M00_L12:
       add       eax,[rdx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L06
       nop       dword ptr [rax]
M00_L13:
       mov       rdx,[rdx+8]
M00_L14:
       cmp       qword ptr [rdx+8],0
       je        near ptr M00_L09
M00_L15:
       mov       r9d,[rdx+18]
       cmp       esi,r9d
       je        near ptr M00_L26
       jle       short M00_L13
       mov       rdx,[rdx+10]
       jmp       short M00_L14
M00_L16:
       cmp       esi,[rdi+18]
       jge       near ptr M00_L27
       mov       dword ptr [rsp+20],1
       lea       rcx,[rbp-0E8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0F0]
       mov       [rsp+30],rcx
       mov       rcx,[rdi+8]
       lea       r8,[rbp-108]
       mov       edx,esi
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65BD8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       mov       rdx,rax
       cmp       byte ptr [rbp-0F0],0
       je        short M00_L17
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FF91CB65C08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       rdi,rax
M00_L17:
       cmp       byte ptr [rbp-0F0],0
       je        near ptr M00_L29
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FF91CB65C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M00_L18:
       mov       r15,rax
       cmp       dword ptr [rbp-78],1
       jne       near ptr M00_L02
       inc       r12d
       jmp       near ptr M00_L02
M00_L19:
       mov       dword ptr [rbp-0F0],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rbp-108]
       mov       rcx,rdi
       mov       edx,esi
       mov       r9,r15
       call      qword ptr [7FF91CB65BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       short M00_L18
M00_L20:
       lea       r8,[rbp-0E8]
       mov       rcx,r15
       mov       edx,esi
       call      qword ptr [7FF91CB6F0A8]
       jmp       short M00_L18
M00_L21:
       lea       rdx,[rbp-58]
       mov       r11,7FF91C2C0C50
       call      qword ptr [r11]
       mov       rcx,[rbp-148]
       jmp       near ptr M00_L04
M00_L22:
       mov       r10d,80
       test      r11b,1
       je        short M00_L23
       mov       r10d,r11d
       and       r10,2
       movzx     r10d,byte ptr [rdx+r10]
       or        r10d,8000
M00_L23:
       test      r11b,2
       je        short M00_L24
       shl       r10d,10
       movzx     edx,word ptr [rdx]
       or        r10d,edx
       mov       edx,r10d
       jmp       near ptr M00_L07
M00_L24:
       mov       edx,r10d
       jmp       near ptr M00_L07
M00_L25:
       mov       rcx,rdx
       mov       rdx,[rbp-58]
       mov       r11,7FF91C2C0C58
       call      qword ptr [r11]
       mov       esi,eax
       mov       rcx,[rbp-148]
       jmp       near ptr M00_L08
M00_L26:
       vmovdqu   xmm0,xmmword ptr [rdx+20]
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       mov       r9,[rdx+30]
       mov       [rbp-0D0],r9
       jmp       near ptr M00_L10
M00_L27:
       vmovdqu   xmm0,xmmword ptr [r15+20]
       vmovdqu   xmmword ptr [rbp-128],xmm0
       mov       r8,[r15+30]
       mov       [rbp-118],r8
       vmovdqu   xmm0,xmmword ptr [rbp-108]
       vmovdqu   xmmword ptr [rbp-140],xmm0
       mov       r8,[rbp-0F8]
       mov       [rbp-130],r8
       lea       r8,[rbp-140]
       lea       rdx,[rbp-128]
       mov       rcx,r13
       mov       r11,7FF91C2C0C68
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L28
       xor       eax,eax
       mov       [rbp-0F0],eax
       mov       rax,r15
       jmp       near ptr M00_L18
M00_L28:
       mov       dword ptr [rbp-0F0],1
       mov       dword ptr [rbp-0E8],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r9,[r15+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[r15+8]
       lea       r8,[rbp-108]
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF91CB65BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       jmp       near ptr M00_L17
M00_L29:
       mov       rax,rdi
       jmp       near ptr M00_L18
M00_L30:
       mov       r11,7FF91C2C0C48
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L31:
       mov       ecx,717
       mov       rdx,7FF91CB7CA80
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6EC70]
       int       3
M00_L32:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r11,[rbp-148]
       cmp       [r11],rcx
       jne       near ptr M00_L35
M00_L33:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       lea       rcx,[rbp-0A0]
       mov       r9d,r12d
       mov       r8,r15
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FF91CB6F1B0]; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-0A0]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       lea       rcx,[rbp-48]
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FF91CB6F1C8]; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableDictionary`2<System.__Canon,System.__Canon>)
       mov       [rbp-110],rax
       mov       rcx,[rbx+60]
       lea       r8,[rbp-110]
       mov       rdx,7FF91CB9BDB8
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65D88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,158
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,2E3F5802AC8
       mov       rcx,[rdx]
       jmp       near ptr M00_L01
M00_L35:
       mov       rcx,r11
       mov       r11,7FF91C2C0C60
       call      qword ptr [r11]
       jmp       near ptr M00_L33
       sub       rsp,48
       cmp       qword ptr [rbp-148],0
       je        short M00_L36
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-148]
       cmp       [rax],rcx
       je        short M00_L36
       mov       rcx,rax
       mov       r11,7FF91C2C0C60
       call      qword ptr [r11]
M00_L36:
       nop
       add       rsp,48
       ret
; Total bytes of code 1867
```
```assembly
; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+8]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+44]
       jne       short M01_L01
       mov       ecx,[rbx+0C]
       cmp       ecx,[rdx+38]
       jae       short M01_L03
M01_L00:
       mov       rcx,[rbx]
       mov       rcx,[rcx+10]
       mov       edx,[rbx+0C]
       lea       eax,[rdx+1]
       mov       [rbx+0C],eax
       cmp       edx,[rcx+8]
       jae       short M01_L04
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L02
       mov       rdx,[rcx]
       mov       rsi,[rcx+8]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF91C59C150]
       int       3
M01_L02:
       mov       ecx,[rbx+0C]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+38]
       jb        short M01_L00
M01_L03:
       mov       rax,[rbx]
       mov       eax,[rax+38]
       inc       eax
       mov       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+18],rax
       mov       [rbx+20],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, KeyCollisionBehavior<System.__Canon,System.__Canon>, OperationResult<System.__Canon,System.__Canon> ByRef)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A0
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       xor       eax,eax
       mov       [rsp+90],rax
       mov       [rsp+98],r8
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
M02_L00:
       cmp       qword ptr [rdi],0
       jne       short M02_L04
       mov       r14,[rsp+120]
       mov       dword ptr [r14],1
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L03
M02_L01:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbx],rcx
       mov       [rbx+8],rbp
       mov       r15,[rsp+100]
       mov       [rbx+10],r15
M02_L02:
       mov       rax,rbx
       add       rsp,0A0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF91CBFDC10
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FF91CBFD9F0
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L06:
       mov       [rsp+40],rbp
       mov       r15,[rsp+100]
       mov       [rsp+48],r15
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+40]
       lea       r8,[rsp+30]
       mov       rcx,[rsp+108]
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M02_L10
       mov       r13d,[rsp+118]
       cmp       r13d,3
       ja        short M02_L07
       mov       ecx,r13d
       lea       rax,[7FF91CAEBB70]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M02_L00]
       add       rax,rdx
       jmp       rax
M02_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF91CB6ECB8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
       xor       r8d,r8d
       mov       r14,[rsp+120]
       mov       [r14],r8d
       mov       [rsp+40],rbp
       mov       [rsp+48],r15
       lea       r8,[rsp+40]
       mov       r9,[rdi]
       lea       rcx,[rsp+50]
       mov       rdx,rsi
       call      qword ptr [7FF91CB6ED00]
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rsp+60]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       lea       r13,[rdi+8]
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FF91CBFDB58
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L09:
       mov       rdx,[r13+8]
       mov       rcx,[rsp+110]
       mov       r8,r15
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M02_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB6EC88]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB6ECA0]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF91CB6EC88]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB6ECA0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L10:
       mov       rcx,[rdi]
       cmp       [rcx],cl
       mov       [rsp+40],rbp
       mov       [rsp+48],r15
       mov       r13,[rsp+108]
       mov       [rsp+20],r13
       lea       rdx,[rsp+40]
       mov       r9d,[rcx+18]
       xor       r8d,r8d
       call      qword ptr [7FF91CB6ECD0]
       test      eax,eax
       jge       short M02_L11
       mov       r14,[rsp+120]
       mov       dword ptr [r14],1
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,[rdi]
       mov       [rsp+30],rbp
       mov       [rsp+38],r15
       lea       rdx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB6ECE8]
       mov       r9,rax
       lea       r8,[rsp+40]
       lea       rcx,[rsp+68]
       mov       rdx,rsi
       call      qword ptr [7FF91CB6ED00]
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rax,[rsp+78]
       mov       [rbx+10],rax
       jmp       near ptr M02_L02
M02_L11:
       mov       r13d,[rsp+118]
       cmp       r13d,3
       ja        short M02_L12
       mov       ecx,r13d
       lea       rdx,[7FF91CAEBB80]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M02_L00]
       add       rdx,r8
       jmp       rdx
M02_L12:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FF91CB6ECB8]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
       xor       ecx,ecx
       mov       r14,[rsp+120]
       mov       [r14],ecx
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,[rdi]
       mov       [rsp+30],rbp
       mov       [rsp+38],r15
       lea       r8,[rsp+30]
       mov       edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB6ED18]
       mov       r9,rax
       lea       r8,[rsp+40]
       lea       rcx,[rsp+80]
       mov       rdx,rsi
       call      qword ptr [7FF91CB6ED00]
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rsp+90]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       mov       rcx,[rdi]
       mov       edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB6ED30]
       mov       r13,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FF91CBFDB58
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L14:
       mov       rdx,[r13+8]
       mov       rcx,[rsp+110]
       mov       r8,r15
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB6EC88]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB6ECA0]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M02_L15:
       mov       r14,[rsp+120]
       mov       dword ptr [r14],2
       vmovdqu   xmm0,xmmword ptr [rdi]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rdi+10]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF91CB6EC88]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB6ECA0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 1163
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M03_L00:
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
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       [rsp+0D0],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       rbp,r9
       mov       r15,[rsp+148]
       mov       r14,[rsp+150]
       mov       byte ptr [r15],0
       cmp       qword ptr [rbx+8],0
       je        near ptr M03_L18
       mov       r13,rbx
       cmp       edi,[r13+18]
       jle       near ptr M03_L10
       mov       r12,[r13+10]
       cmp       [r12],r12b
       mov       byte ptr [r15],0
       cmp       qword ptr [r12+8],0
       je        near ptr M03_L09
       mov       rdx,r12
       cmp       edi,[rdx+18]
       jle       near ptr M03_L03
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       [rsp+38],rdx
       mov       rcx,[rdx+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65BD8]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        near ptr M03_L21
       cmp       byte ptr [r12+1C],0
       jne       near ptr M03_L19
       test      rdi,rdi
       je        short M03_L01
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rcx,[r12+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L41
       cmp       ecx,0FF
       ja        near ptr M03_L41
       mov       [r12+1D],cl
       mov       rbp,r12
M03_L02:
       mov       rdi,rbp
       jmp       near ptr M03_L05
M03_L03:
       cmp       edi,[rdx+18]
       jge       near ptr M03_L24
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       [rsp+38],rdx
       mov       rcx,[rdx+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65BD8]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       mov       rdi,[rsp+38]
       je        short M03_L05
       cmp       byte ptr [r12+1C],0
       jne       near ptr M03_L22
       test      rsi,rsi
       je        short M03_L04
       lea       rcx,[r12+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M03_L04:
       mov       rcx,[r12+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L41
       cmp       ecx,0FF
       ja        near ptr M03_L41
       mov       [r12+1D],cl
       mov       rdi,r12
M03_L05:
       cmp       byte ptr [r14],0
       je        near ptr M03_L29
       mov       rcx,[r12]
       mov       rdx,rdi
       call      qword ptr [7FF91CB65C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       r12,rax
M03_L06:
       cmp       byte ptr [r14],0
       je        near ptr M03_L12
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L30
       test      r12,r12
       je        short M03_L07
       lea       rcx,[rbx+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M03_L07:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L41
       cmp       ecx,0FF
       ja        near ptr M03_L41
       mov       [rbx+1D],cl
       mov       r13,rbx
M03_L08:
       jmp       near ptr M03_L12
M03_L09:
       mov       byte ptr [r14],1
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+20],r12
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,rsi
       mov       r9,r12
       call      qword ptr [7FF91CB65BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r12,rbp
       jmp       near ptr M03_L06
M03_L10:
       cmp       edi,[r13+18]
       jge       near ptr M03_L34
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65BD8]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        short M03_L12
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L32
       test      rsi,rsi
       je        short M03_L11
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M03_L11:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L41
       cmp       ecx,0FF
       ja        near ptr M03_L41
       mov       [rbx+1D],cl
       mov       r13,rbx
M03_L12:
       cmp       byte ptr [r14],0
       je        near ptr M03_L39
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M03_L40
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jl        short M03_L13
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M03_L40
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       js        short M03_L16
       mov       rdx,r13
       call      qword ptr [7FF91CB65C80]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       short M03_L17
M03_L13:
       cmp       edx,0FFFFFFFE
       jle       short M03_L14
       mov       rax,r13
       jmp       short M03_L17
M03_L14:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M03_L40
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M03_L15
       mov       rdx,r13
       call      qword ptr [7FF91CB65CC8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       short M03_L17
M03_L15:
       mov       rdx,r13
       call      qword ptr [7FF91CB65CB0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       short M03_L17
M03_L16:
       mov       rdx,r13
       call      qword ptr [7FF91CB65C98]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M03_L17:
       nop
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
M03_L18:
       mov       byte ptr [r14],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rbp+18],edi
       lea       rdi,[rbp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+1C],0
       movzx     eax,byte ptr [rbx+1D]
       add       eax,1
       jo        near ptr M03_L41
       cmp       eax,0FF
       ja        near ptr M03_L41
       mov       [rbp+1D],al
       mov       rax,rbp
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
M03_L19:
       mov       ebp,[r12+18]
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rsp+0B8],xmm0
       mov       rcx,[r12+30]
       mov       [rsp+0C8],rcx
       mov       r15,[r12+8]
       test      rdi,rdi
       jne       short M03_L20
       mov       rdi,[r12+10]
M03_L20:
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       vmovdqu   xmm0,xmmword ptr [rsp+0B8]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+0C8]
       mov       [rsp+68],r8
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,ebp
       mov       rcx,rsi
       mov       r9,r15
       call      qword ptr [7FF91CB65BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdx,rsi
       mov       rbp,rdx
       jmp       near ptr M03_L02
M03_L21:
       mov       rdi,[rsp+38]
       jmp       near ptr M03_L05
M03_L22:
       mov       edi,[r12+18]
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       rcx,[r12+30]
       mov       [rsp+0B0],rcx
       test      rsi,rsi
       jne       short M03_L23
       mov       rsi,[r12+8]
M03_L23:
       mov       rbp,[r12+10]
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+0B0]
       mov       [rsp+68],r8
       mov       [rsp+20],rbp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,edi
       mov       rcx,r15
       mov       r9,rsi
       call      qword ptr [7FF91CB65BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdx,r15
       mov       rdi,rdx
       jmp       near ptr M03_L05
M03_L24:
       mov       rcx,[r12]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L25
       jmp       short M03_L26
M03_L25:
       mov       rdx,7FF91CBFD3A0
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L26:
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       rdx,[r12+30]
       mov       [rsp+68],rdx
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdx,[rsi+10]
       mov       [rsp+50],rdx
       lea       rdx,[rsp+58]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L27
       mov       byte ptr [r14],0
       jmp       near ptr M03_L06
M03_L27:
       cmp       byte ptr [rsp+140],0
       je        short M03_L28
       mov       byte ptr [r14],1
       mov       byte ptr [r15],1
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r9,[r12+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[r12+8]
       mov       rcx,r15
       mov       edx,edi
       mov       r8,rsi
       call      qword ptr [7FF91CB65BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdi,r15
       jmp       near ptr M03_L05
M03_L28:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB6EC88]
       mov       r12,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r14
       mov       rcx,r12
       call      qword ptr [7FF91CB6ECA0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L29:
       mov       r12,rdi
       jmp       near ptr M03_L06
M03_L30:
       mov       r13d,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+98],rcx
       mov       rdi,[rbx+8]
       test      r12,r12
       jne       short M03_L31
       mov       r12,[rbx+10]
M03_L31:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       vmovdqu   xmm0,xmmword ptr [rsp+88]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+98]
       mov       [rsp+68],r8
       mov       [rsp+20],r12
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,r13d
       mov       rcx,rsi
       mov       r9,rdi
       call      qword ptr [7FF91CB65BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r13,rsi
       jmp       near ptr M03_L08
M03_L32:
       mov       r13d,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+80],rcx
       test      rsi,rsi
       jne       short M03_L33
       mov       rsi,[rbx+8]
M03_L33:
       mov       rbp,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       vmovdqu   xmm0,xmmword ptr [rsp+70]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+80]
       mov       [rsp+68],r8
       mov       [rsp+20],rbp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,r13d
       mov       rcx,r15
       mov       r9,rsi
       call      qword ptr [7FF91CB65BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r13,r15
       jmp       near ptr M03_L12
M03_L34:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L35
       jmp       short M03_L36
M03_L35:
       mov       rdx,7FF91CBFD3A0
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L36:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       rdx,[rbx+30]
       mov       [rsp+68],rdx
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdx,[rsi+10]
       mov       [rsp+50],rdx
       lea       rdx,[rsp+58]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L37
       mov       byte ptr [r14],0
       mov       rax,rbx
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
M03_L37:
       cmp       byte ptr [rsp+140],0
       je        short M03_L38
       mov       byte ptr [r14],1
       mov       byte ptr [r15],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r9,[rbx+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[rbx+8]
       mov       rcx,r13
       mov       edx,edi
       mov       r8,rsi
       call      qword ptr [7FF91CB65BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       jmp       near ptr M03_L12
M03_L38:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB6EC88]
       mov       rsi,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FF91CB6ECA0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L39:
       mov       rax,r13
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
M03_L40:
       mov       ecx,869
       mov       rdx,7FF91CB7CA80
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6EC70]
       int       3
M03_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2196
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       [rsp+60],rax
       mov       [rsp+68],rcx
       mov       rbx,rcx
       mov       rsi,r8
       cmp       byte ptr [rbx+1C],0
       jne       short M04_L02
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M04_L00:
       test      rsi,rsi
       je        short M04_L01
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M04_L01:
       mov       rax,[rbx+8]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rbx+10]
       movzx     ecx,byte ptr [rcx+1D]
       cmp       eax,ecx
       cmovl     eax,ecx
       add       eax,1
       jo        near ptr M04_L05
       cmp       eax,0FF
       ja        near ptr M04_L05
       mov       [rbx+1D],al
       mov       rax,rbx
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L02:
       mov       edi,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+60],rcx
       mov       rbp,rdx
       test      rbp,rbp
       jne       short M04_L03
       mov       rbp,[rbx+8]
M04_L03:
       test      rsi,rsi
       jne       short M04_L04
       mov       rsi,[rbx+10]
M04_L04:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r8,[rsp+60]
       mov       [rsp+48],r8
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,edi
       mov       rcx,r14
       mov       r9,rbp
       call      qword ptr [7FF91CB65BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rax,r14
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 267
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L04
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rbx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       cmp       eax,2
       jge       short M05_L02
       cmp       eax,0FFFFFFFE
       jle       short M05_L00
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FF91CB65C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       test      eax,eax
       jle       short M05_L01
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB65CC8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB65CB0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L02:
       mov       rdx,[rbx+10]
       mov       rcx,rsi
       call      qword ptr [7FF91CB65C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       test      eax,eax
       jge       short M05_L03
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB65C98]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB65C80]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L04:
       mov       ecx,869
       mov       rdx,7FF91CB7CA80
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6EC70]
       int       3
; Total bytes of code 201
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rbp,r9
       mov       r14,[rsp+80]
       cmp       [rbx],ebx
       test      rbp,rbp
       je        short M06_L00
       test      r14,r14
       je        near ptr M06_L01
       mov       [rbx+18],edx
       lea       rdi,[rbx+20]
       mov       rsi,r8
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r15d,byte ptr [rsp+88]
       mov       [rbx+1C],r15b
       movzx     ecx,byte ptr [rbp+1D]
       movzx     edx,byte ptr [r14+1D]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        short M06_L02
       cmp       ecx,0FF
       ja        short M06_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       mov       ecx,847
       mov       rdx,7FF91CB7CA80
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6EC70]
       int       3
M06_L01:
       mov       ecx,851
       mov       rdx,7FF91CB7CA80
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6EC70]
       int       3
M06_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 220
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r9d
       test      r8,r8
       je        short M07_L00
       mov       rcx,rbx
       mov       rdx,r8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rbx+8],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       mov       ecx,4AB
       mov       rdx,7FF91CB7CA80
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6EC70]
       int       3
; Total bytes of code 69
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableDictionary`2<System.__Canon,System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rdx
       mov       rbx,r8
       test      rbx,rbx
       je        near ptr M08_L05
       mov       rsi,[rcx]
       mov       edi,[rbx+18]
       add       edi,[rcx+8]
       test      rsi,rsi
       je        near ptr M08_L08
       cmp       [rbx+8],rsi
       je        near ptr M08_L09
       cmp       qword ptr [rsi+8],0
       je        near ptr M08_L08
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+10]
       test      rdx,rdx
       je        near ptr M08_L06
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0E8]
       test      rdx,rdx
       je        near ptr M08_L04
M08_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax+8]
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M08_L02
       test      rbx,rbx
       je        short M08_L01
       mov       r14d,[rsi+18]
       lea       rcx,[rsi+20]
       mov       r15,[rcx]
       vmovdqu   xmm0,xmmword ptr [rcx]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       mov       rax,[rcx+10]
       mov       [rsp+38],rax
       vmovdqu   xmm0,xmmword ptr [rsp+28]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rcx,[rsp+38]
       mov       [rsp+58],rcx
       mov       rcx,offset System.Collections.Immutable.ImmutableDictionary`2+<>c[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<.cctor>b__109_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>)
       cmp       [rbx+18],rcx
       jne       near ptr M08_L07
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       test      r15,r15
       je        short M08_L01
       cmp       byte ptr [r15+1C],0
       jne       short M08_L01
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65D70]; System.Collections.Immutable.ImmutableList`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Freeze()
       mov       rcx,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65D70]; System.Collections.Immutable.ImmutableList`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Freeze()
       mov       byte ptr [r15+1C],1
M08_L01:
       mov       rcx,[rsi+8]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65D28]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>>)
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB65D28]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>>)
       mov       byte ptr [rsi+1C],1
M08_L02:
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+18],edi
       mov       rbx,rbp
M08_L03:
       mov       rax,rbx
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
       mov       rdx,7FF91CC300A0
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L00
M08_L05:
       mov       ecx,737
       mov       rdx,7FF91CB7CA80
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6EC70]
       int       3
M08_L06:
       mov       ecx,6DB
       mov       rdx,7FF91CB7CA80
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB6EC70]
       int       3
M08_L07:
       mov       [rsp+40],r14d
       mov       [rsp+48],r15
       lea       rdx,[rsp+40]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       near ptr M08_L01
M08_L08:
       mov       rcx,rbx
       call      qword ptr [7FF91CB6EFA0]
       mov       rbx,rax
       jmp       near ptr M08_L03
M08_L09:
       jmp       near ptr M08_L03
; Total bytes of code 523
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M10_L00
       ret
M10_L00:
       jmp       qword ptr [7FF91C375C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ToImmutableDictionary()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,158
       lea       rbp,[rsp+190]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-140],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       cmp       [rsi],sil
       mov       rcx,1FCBDC00A20
       mov       r14,[rcx]
       mov       r15,[r14+8]
       mov       r13,[r14+10]
       xor       r12d,r12d
       mov       ecx,[rsi+38]
       sub       ecx,[rsi+40]
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[rsi+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       mov       [rbp-0C8],rsi
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-0C8]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
       mov       rcx,rdx
M00_L01:
       mov       [rbp-148],rcx
M00_L02:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-148]
       cmp       [rcx],rdx
       jne       near ptr M00_L30
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF91C6C7F30]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L03:
       test      eax,eax
       je        near ptr M00_L32
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-148]
       cmp       [rcx],rdx
       jne       near ptr M00_L21
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-58],xmm0
M00_L04:
       cmp       qword ptr [rbp-58],0
       je        near ptr M00_L31
       mov       rdx,[r13+8]
       mov       r11,offset MT_System.Collections.Generic.StringEqualityComparer
       cmp       [rdx],r11
       jne       near ptr M00_L25
       mov       rdx,[rbp-58]
       add       rdx,0C
       mov       r11,[rbp-58]
       mov       r11d,[r11+8]
       add       r11d,r11d
       mov       eax,5F2F5F62
       mov       r8d,0AA30981B
       cmp       r11d,8
       jb        near ptr M00_L13
       mov       r10d,r11d
       shr       r10d,3
M00_L05:
       add       eax,[rdx]
       mov       r9d,[rdx+4]
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
       add       rdx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L05
       test      r11b,4
       jne       near ptr M00_L14
M00_L06:
       mov       r10d,r11d
       and       r10,7
       mov       edx,[rdx+r10-4]
       shr       edx,8
       or        edx,80000000
       not       r11d
       shl       r11d,3
       shrx      edx,edx,r11d
M00_L07:
       add       edx,eax
       mov       r11d,r8d
       xor       r11d,edx
       rol       edx,14
       add       edx,r11d
       rol       r11d,9
       xor       r11d,edx
       rol       edx,1B
       add       edx,r11d
       rol       r11d,13
       xor       r11d,edx
       mov       esi,edx
       rol       esi,14
       add       esi,r11d
       rol       r11d,9
       xor       r11d,esi
       rol       esi,1B
       add       esi,r11d
       mov       edi,r11d
       rol       edi,13
       xor       esi,edi
M00_L08:
       cmp       [r15],r15b
       mov       rdx,r15
       cmp       qword ptr [r15+8],0
       jne       near ptr M00_L17
M00_L09:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
M00_L10:
       vmovdqu   xmm0,xmmword ptr [rbp-0E0]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rdx,[rbp-0D0]
       mov       [rbp-60],rdx
       mov       rdx,[rbp-50]
       mov       [rsp+20],rdx
       mov       [rsp+28],r13
       mov       rdx,[r13+10]
       mov       [rsp+30],rdx
       mov       dword ptr [rsp+38],2
       lea       rdx,[rbp-78]
       mov       [rsp+40],rdx
       lea       rdx,[rbp-90]
       lea       rcx,[rbp-70]
       mov       r9,[rbp-58]
       mov       r8,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket
       call      qword ptr [7FF91CB167F0]; System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, KeyCollisionBehavior<System.__Canon,System.__Canon>, OperationResult<System.__Canon,System.__Canon> ByRef)
       mov       rcx,[rbp-90]
       test      rcx,rcx
       je        near ptr M00_L20
       vmovdqu   xmm0,xmmword ptr [rbp-90]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       mov       r8,[rbp-80]
       mov       [rbp-0F8],r8
       mov       [rbp-108],rcx
       xor       ecx,ecx
       mov       [rbp-0E8],ecx
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L19
       mov       rdi,r15
       cmp       esi,[rdi+18]
       jle       near ptr M00_L18
       mov       dword ptr [rsp+20],1
       lea       rcx,[rbp-0E8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0F0]
       mov       [rsp+30],rcx
       mov       rcx,[rdi+10]
       lea       r8,[rbp-108]
       mov       edx,esi
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB16868]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rbp-0F0],0
       je        short M00_L11
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF91CB16898]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       rdi,rax
M00_L11:
       cmp       byte ptr [rbp-0F0],0
       je        near ptr M00_L29
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FF91CB168B0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M00_L12:
       mov       r15,rax
       cmp       dword ptr [rbp-78],1
       jne       near ptr M00_L02
       inc       r12d
       jmp       near ptr M00_L02
M00_L13:
       cmp       r11d,4
       jb        near ptr M00_L22
M00_L14:
       add       eax,[rdx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L06
       nop       dword ptr [rax]
M00_L15:
       mov       rdx,[rdx+8]
M00_L16:
       cmp       qword ptr [rdx+8],0
       je        near ptr M00_L09
M00_L17:
       mov       r9d,[rdx+18]
       cmp       esi,r9d
       je        near ptr M00_L26
       jle       short M00_L15
       mov       rdx,[rdx+10]
       jmp       short M00_L16
M00_L18:
       cmp       esi,[rdi+18]
       jge       near ptr M00_L27
       mov       dword ptr [rsp+20],1
       lea       rcx,[rbp-0E8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0F0]
       mov       [rsp+30],rcx
       mov       rcx,[rdi+8]
       lea       r8,[rbp-108]
       mov       edx,esi
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB16868]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       mov       rdx,rax
       cmp       byte ptr [rbp-0F0],0
       je        near ptr M00_L11
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FF91CB16898]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       jmp       near ptr M00_L11
M00_L19:
       mov       dword ptr [rbp-0F0],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rbp-108]
       mov       rcx,rdi
       mov       edx,esi
       mov       r9,r15
       call      qword ptr [7FF91CB16880]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M00_L12
M00_L20:
       lea       r8,[rbp-0E8]
       mov       rcx,r15
       mov       edx,esi
       call      qword ptr [7FF91CB1EE20]
       jmp       near ptr M00_L12
M00_L21:
       lea       rdx,[rbp-58]
       mov       r11,7FF91C290DA0
       call      qword ptr [r11]
       mov       rcx,[rbp-148]
       jmp       near ptr M00_L04
M00_L22:
       mov       r10d,80
       test      r11b,1
       je        short M00_L23
       mov       r10d,r11d
       and       r10,2
       movzx     r10d,byte ptr [rdx+r10]
       or        r10d,8000
M00_L23:
       test      r11b,2
       je        short M00_L24
       shl       r10d,10
       movzx     edx,word ptr [rdx]
       or        r10d,edx
       mov       edx,r10d
       jmp       near ptr M00_L07
M00_L24:
       mov       edx,r10d
       jmp       near ptr M00_L07
M00_L25:
       mov       rcx,rdx
       mov       rdx,[rbp-58]
       mov       r11,7FF91C290DA8
       call      qword ptr [r11]
       mov       esi,eax
       mov       rcx,[rbp-148]
       jmp       near ptr M00_L08
M00_L26:
       vmovdqu   xmm0,xmmword ptr [rdx+20]
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       mov       r9,[rdx+30]
       mov       [rbp-0D0],r9
       jmp       near ptr M00_L10
M00_L27:
       vmovdqu   xmm0,xmmword ptr [r15+20]
       vmovdqu   xmmword ptr [rbp-128],xmm0
       mov       r8,[r15+30]
       mov       [rbp-118],r8
       vmovdqu   xmm0,xmmword ptr [rbp-108]
       vmovdqu   xmmword ptr [rbp-140],xmm0
       mov       r8,[rbp-0F8]
       mov       [rbp-130],r8
       lea       r8,[rbp-140]
       lea       rdx,[rbp-128]
       mov       rcx,r13
       mov       r11,7FF91C290DB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L28
       xor       eax,eax
       mov       [rbp-0F0],eax
       mov       rax,r15
       jmp       near ptr M00_L12
M00_L28:
       mov       dword ptr [rbp-0F0],1
       mov       dword ptr [rbp-0E8],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r9,[r15+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[r15+8]
       lea       r8,[rbp-108]
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF91CB16880]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       jmp       near ptr M00_L11
M00_L29:
       mov       rax,rdi
       jmp       near ptr M00_L12
M00_L30:
       mov       r11,7FF91C290D98
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L31:
       mov       ecx,717
       mov       rdx,7FF91CB31B70
       call      qword ptr [7FF91C5677B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB1EA30]
       int       3
M00_L32:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r11,[rbp-148]
       cmp       [r11],rcx
       jne       near ptr M00_L35
M00_L33:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       lea       rcx,[rbp-0A0]
       mov       r9d,r12d
       mov       r8,r15
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FF91CB1F018]; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-0A0]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       lea       rcx,[rbp-48]
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FF91CB1F030]; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableDictionary`2<System.__Canon,System.__Canon>)
       mov       [rbp-110],rax
       mov       rcx,[rbx+60]
       lea       r8,[rbp-110]
       mov       rdx,7FF91CB50FC0
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB16A18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,158
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1FCBDC00B00
       mov       rcx,[rdx]
       jmp       near ptr M00_L01
M00_L35:
       mov       rcx,r11
       mov       r11,7FF91C290DB0
       call      qword ptr [r11]
       jmp       near ptr M00_L33
       sub       rsp,48
       cmp       qword ptr [rbp-148],0
       je        short M00_L36
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-148]
       cmp       [rax],rcx
       je        short M00_L36
       mov       rcx,rax
       mov       r11,7FF91C290DB0
       call      qword ptr [r11]
M00_L36:
       nop
       add       rsp,48
       ret
; Total bytes of code 1877
```
```assembly
; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+8]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+44]
       jne       short M01_L01
       mov       ecx,[rbx+0C]
       cmp       ecx,[rdx+38]
       jae       short M01_L03
M01_L00:
       mov       rcx,[rbx]
       mov       rcx,[rcx+10]
       mov       edx,[rbx+0C]
       lea       eax,[rdx+1]
       mov       [rbx+0C],eax
       cmp       edx,[rcx+8]
       jae       short M01_L04
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L02
       mov       rdx,[rcx]
       mov       rsi,[rcx+8]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF91C56C150]
       int       3
M01_L02:
       mov       ecx,[rbx+0C]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+38]
       jb        short M01_L00
M01_L03:
       mov       rax,[rbx]
       mov       eax,[rax+38]
       inc       eax
       mov       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+18],rax
       mov       [rbx+20],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, KeyCollisionBehavior<System.__Canon,System.__Canon>, OperationResult<System.__Canon,System.__Canon> ByRef)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A0
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       xor       eax,eax
       mov       [rsp+90],rax
       mov       [rsp+98],r8
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
M02_L00:
       cmp       qword ptr [rdi],0
       jne       short M02_L04
       mov       r14,[rsp+120]
       mov       dword ptr [r14],1
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L03
M02_L01:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbx],rcx
       mov       [rbx+8],rbp
       mov       r15,[rsp+100]
       mov       [rbx+10],r15
M02_L02:
       mov       rax,rbx
       add       rsp,0A0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF91CBE69E0
       call      qword ptr [7FF91C34C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FF91CBE67C0
       call      qword ptr [7FF91C34C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L06:
       mov       [rsp+40],rbp
       mov       r15,[rsp+100]
       mov       [rsp+48],r15
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+40]
       lea       r8,[rsp+30]
       mov       rcx,[rsp+108]
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M02_L10
       mov       r13d,[rsp+118]
       cmp       r13d,3
       ja        short M02_L07
       mov       ecx,r13d
       lea       rax,[7FF91CAB11D0]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M02_L00]
       add       rax,rdx
       jmp       rax
M02_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF91CB1D1A0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
       xor       r8d,r8d
       mov       r14,[rsp+120]
       mov       [r14],r8d
       mov       [rsp+40],rbp
       mov       [rsp+48],r15
       lea       r8,[rsp+40]
       mov       r9,[rdi]
       lea       rcx,[rsp+50]
       mov       rdx,rsi
       call      qword ptr [7FF91CB1EAA8]
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rsp+60]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       lea       r13,[rdi+8]
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FF91CBE6928
       call      qword ptr [7FF91C34C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L09:
       mov       rdx,[r13+8]
       mov       rcx,[rsp+110]
       mov       r8,r15
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M02_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB1EA48]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB1EA60]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF91C6C5E00]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF91CB1EA48]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB1EA60]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6C5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L10:
       mov       rcx,[rdi]
       cmp       [rcx],cl
       mov       [rsp+40],rbp
       mov       [rsp+48],r15
       mov       r13,[rsp+108]
       mov       [rsp+20],r13
       lea       rdx,[rsp+40]
       mov       r9d,[rcx+18]
       xor       r8d,r8d
       call      qword ptr [7FF91CB1EA78]
       test      eax,eax
       jge       short M02_L11
       mov       r14,[rsp+120]
       mov       dword ptr [r14],1
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,[rdi]
       mov       [rsp+30],rbp
       mov       [rsp+38],r15
       lea       rdx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB1EA90]
       mov       r9,rax
       lea       r8,[rsp+40]
       lea       rcx,[rsp+68]
       mov       rdx,rsi
       call      qword ptr [7FF91CB1EAA8]
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rax,[rsp+78]
       mov       [rbx+10],rax
       jmp       near ptr M02_L02
M02_L11:
       mov       r13d,[rsp+118]
       cmp       r13d,3
       ja        short M02_L12
       mov       ecx,r13d
       lea       rdx,[7FF91CAB11E0]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M02_L00]
       add       rdx,r8
       jmp       rdx
M02_L12:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FF91CB1D1A0]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
       xor       ecx,ecx
       mov       r14,[rsp+120]
       mov       [r14],ecx
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,[rdi]
       mov       [rsp+30],rbp
       mov       [rsp+38],r15
       lea       r8,[rsp+30]
       mov       edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB1EAC0]
       mov       r9,rax
       lea       r8,[rsp+40]
       lea       rcx,[rsp+80]
       mov       rdx,rsi
       call      qword ptr [7FF91CB1EAA8]
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rsp+90]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       mov       rcx,[rdi]
       mov       edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB1EAD8]
       mov       r13,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FF91CBE6928
       call      qword ptr [7FF91C34C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L14:
       mov       rdx,[r13+8]
       mov       rcx,[rsp+110]
       mov       r8,r15
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB1EA48]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB1EA60]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF91C6C5E00]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M02_L15:
       mov       r14,[rsp+120]
       mov       dword ptr [r14],2
       vmovdqu   xmm0,xmmword ptr [rdi]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rdi+10]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF91CB1EA48]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CB1EA60]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6C5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 1163
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M03_L00:
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
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       [rsp+0D0],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       rbp,r9
       mov       r15,[rsp+148]
       mov       r14,[rsp+150]
       mov       byte ptr [r15],0
       cmp       qword ptr [rbx+8],0
       je        near ptr M03_L19
       mov       r13,rbx
       cmp       edi,[r13+18]
       jle       near ptr M03_L11
       mov       r12,[r13+10]
       cmp       [r12],r12b
       mov       byte ptr [r15],0
       cmp       qword ptr [r12+8],0
       je        near ptr M03_L10
       mov       rdx,r12
       cmp       edi,[rdx+18]
       jle       near ptr M03_L07
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       [rsp+38],rdx
       mov       rcx,[rdx+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB16868]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        near ptr M03_L22
       cmp       byte ptr [r12+1C],0
       jne       near ptr M03_L20
       test      rdi,rdi
       je        short M03_L01
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rcx,[r12+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L42
       cmp       ecx,0FF
       ja        near ptr M03_L42
       mov       [r12+1D],cl
       mov       rbp,r12
M03_L02:
       mov       rdi,rbp
M03_L03:
       cmp       byte ptr [r14],0
       je        near ptr M03_L30
       mov       rcx,[r12]
       mov       rdx,rdi
       call      qword ptr [7FF91CB168B0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       r12,rax
M03_L04:
       cmp       byte ptr [r14],0
       je        short M03_L06
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L31
       test      r12,r12
       je        short M03_L05
       lea       rcx,[rbx+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M03_L05:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L42
       cmp       ecx,0FF
       ja        near ptr M03_L42
       mov       [rbx+1D],cl
       mov       r13,rbx
M03_L06:
       cmp       byte ptr [r14],0
       je        near ptr M03_L40
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M03_L41
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jl        near ptr M03_L14
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M03_L41
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       js        near ptr M03_L17
       mov       rdx,r13
       call      qword ptr [7FF91CB16928]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       near ptr M03_L18
M03_L07:
       cmp       edi,[rdx+18]
       jge       near ptr M03_L25
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       [rsp+38],rdx
       mov       rcx,[rdx+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB16868]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       mov       rdi,[rsp+38]
       je        near ptr M03_L03
       cmp       byte ptr [r12+1C],0
       jne       near ptr M03_L23
       test      rsi,rsi
       je        short M03_L08
       lea       rcx,[r12+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M03_L08:
       mov       rcx,[r12+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L42
       cmp       ecx,0FF
       ja        near ptr M03_L42
       mov       [r12+1D],cl
       mov       rdi,r12
M03_L09:
       jmp       near ptr M03_L03
M03_L10:
       mov       byte ptr [r14],1
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+20],r12
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,rsi
       mov       r9,r12
       call      qword ptr [7FF91CB16880]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r12,rbp
       jmp       near ptr M03_L04
M03_L11:
       cmp       edi,[r13+18]
       jge       near ptr M03_L35
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB16868]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        near ptr M03_L06
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L33
       test      rsi,rsi
       je        short M03_L12
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M03_L12:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L42
       cmp       ecx,0FF
       ja        near ptr M03_L42
       mov       [rbx+1D],cl
       mov       r13,rbx
M03_L13:
       jmp       near ptr M03_L06
M03_L14:
       cmp       edx,0FFFFFFFE
       jle       short M03_L15
       mov       rax,r13
       jmp       short M03_L18
M03_L15:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M03_L41
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M03_L16
       mov       rdx,r13
       call      qword ptr [7FF91CB16910]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       short M03_L18
M03_L16:
       mov       rdx,r13
       call      qword ptr [7FF91CB16940]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       short M03_L18
M03_L17:
       mov       rdx,r13
       call      qword ptr [7FF91CB16958]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M03_L18:
       nop
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
M03_L19:
       mov       byte ptr [r14],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rbp+18],edi
       lea       rdi,[rbp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+1C],0
       movzx     eax,byte ptr [rbx+1D]
       add       eax,1
       jo        near ptr M03_L42
       cmp       eax,0FF
       ja        near ptr M03_L42
       mov       [rbp+1D],al
       mov       rax,rbp
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
M03_L20:
       mov       ebp,[r12+18]
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rsp+0B8],xmm0
       mov       rcx,[r12+30]
       mov       [rsp+0C8],rcx
       mov       r15,[r12+8]
       test      rdi,rdi
       jne       short M03_L21
       mov       rdi,[r12+10]
M03_L21:
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       vmovdqu   xmm0,xmmword ptr [rsp+0B8]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+0C8]
       mov       [rsp+68],r8
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,ebp
       mov       rcx,rsi
       mov       r9,r15
       call      qword ptr [7FF91CB16880]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdx,rsi
       mov       rbp,rdx
       jmp       near ptr M03_L02
M03_L22:
       mov       rdi,[rsp+38]
       jmp       near ptr M03_L03
M03_L23:
       mov       edi,[r12+18]
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       rcx,[r12+30]
       mov       [rsp+0B0],rcx
       test      rsi,rsi
       jne       short M03_L24
       mov       rsi,[r12+8]
M03_L24:
       mov       rbp,[r12+10]
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+0B0]
       mov       [rsp+68],r8
       mov       [rsp+20],rbp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,edi
       mov       rcx,r15
       mov       r9,rsi
       call      qword ptr [7FF91CB16880]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdx,r15
       mov       rdi,rdx
       jmp       near ptr M03_L09
M03_L25:
       mov       rcx,[r12]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L26
       jmp       short M03_L27
M03_L26:
       mov       rdx,7FF91CBE6220
       call      qword ptr [7FF91C34C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L27:
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       rdx,[r12+30]
       mov       [rsp+68],rdx
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdx,[rsi+10]
       mov       [rsp+50],rdx
       lea       rdx,[rsp+58]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L28
       mov       byte ptr [r14],0
       jmp       near ptr M03_L04
M03_L28:
       cmp       byte ptr [rsp+140],0
       je        short M03_L29
       mov       byte ptr [r14],1
       mov       byte ptr [r15],1
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r9,[r12+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[r12+8]
       mov       rcx,r15
       mov       edx,edi
       mov       r8,rsi
       call      qword ptr [7FF91CB16880]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdi,r15
       jmp       near ptr M03_L03
M03_L29:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB1EA48]
       mov       r12,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r14
       mov       rcx,r12
       call      qword ptr [7FF91CB1EA60]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6C5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L30:
       mov       r12,rdi
       jmp       near ptr M03_L04
M03_L31:
       mov       r13d,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+98],rcx
       mov       rdi,[rbx+8]
       test      r12,r12
       jne       short M03_L32
       mov       r12,[rbx+10]
M03_L32:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       vmovdqu   xmm0,xmmword ptr [rsp+88]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+98]
       mov       [rsp+68],r8
       mov       [rsp+20],r12
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,r13d
       mov       rcx,rsi
       mov       r9,rdi
       call      qword ptr [7FF91CB16880]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r13,rsi
       jmp       near ptr M03_L06
M03_L33:
       mov       r13d,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+80],rcx
       test      rsi,rsi
       jne       short M03_L34
       mov       rsi,[rbx+8]
M03_L34:
       mov       rbp,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       vmovdqu   xmm0,xmmword ptr [rsp+70]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+80]
       mov       [rsp+68],r8
       mov       [rsp+20],rbp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,r13d
       mov       rcx,r15
       mov       r9,rsi
       call      qword ptr [7FF91CB16880]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r13,r15
       jmp       near ptr M03_L13
M03_L35:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L36
       jmp       short M03_L37
M03_L36:
       mov       rdx,7FF91CBE6220
       call      qword ptr [7FF91C34C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L37:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       rdx,[rbx+30]
       mov       [rsp+68],rdx
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdx,[rsi+10]
       mov       [rsp+50],rdx
       lea       rdx,[rsp+58]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L38
       mov       byte ptr [r14],0
       mov       rax,rbx
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
M03_L38:
       cmp       byte ptr [rsp+140],0
       je        short M03_L39
       mov       byte ptr [r14],1
       mov       byte ptr [r15],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r9,[rbx+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[rbx+8]
       mov       rcx,r13
       mov       edx,edi
       mov       r8,rsi
       call      qword ptr [7FF91CB16880]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       jmp       near ptr M03_L06
M03_L39:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CB1EA48]
       mov       rsi,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FF91CB1EA60]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6C5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L40:
       mov       rax,r13
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
M03_L41:
       mov       ecx,869
       mov       rdx,7FF91CB31B70
       call      qword ptr [7FF91C5677B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB1EA30]
       int       3
M03_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2211
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       [rsp+60],rax
       mov       [rsp+68],rcx
       mov       rbx,rcx
       mov       rsi,r8
       cmp       byte ptr [rbx+1C],0
       jne       short M04_L02
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M04_L00:
       test      rsi,rsi
       je        short M04_L01
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M04_L01:
       mov       rax,[rbx+8]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rbx+10]
       movzx     ecx,byte ptr [rcx+1D]
       cmp       eax,ecx
       cmovl     eax,ecx
       add       eax,1
       jo        near ptr M04_L05
       cmp       eax,0FF
       ja        near ptr M04_L05
       mov       [rbx+1D],al
       mov       rax,rbx
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L02:
       mov       edi,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+60],rcx
       mov       rbp,rdx
       test      rbp,rbp
       jne       short M04_L03
       mov       rbp,[rbx+8]
M04_L03:
       test      rsi,rsi
       jne       short M04_L04
       mov       rsi,[rbx+10]
M04_L04:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r8,[rsp+60]
       mov       [rsp+48],r8
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,edi
       mov       rcx,r14
       mov       r9,rbp
       call      qword ptr [7FF91CB16880]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rax,r14
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 267
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L03
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rbx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       cmp       eax,2
       jge       short M05_L01
       cmp       eax,0FFFFFFFE
       jle       short M05_L00
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FF91CB168E0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       test      eax,eax
       jg        short M05_L04
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB16940]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L01:
       mov       rdx,[rbx+10]
       mov       rcx,rsi
       call      qword ptr [7FF91CB168E0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       test      eax,eax
       jge       short M05_L02
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB16958]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L02:
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB16928]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L03:
       mov       ecx,869
       mov       rdx,7FF91CB31B70
       call      qword ptr [7FF91C5677B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB1EA30]
       int       3
M05_L04:
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CB16910]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
; Total bytes of code 201
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rbp,r9
       mov       r14,[rsp+80]
       cmp       [rbx],ebx
       test      rbp,rbp
       je        short M06_L00
       test      r14,r14
       je        near ptr M06_L01
       mov       [rbx+18],edx
       lea       rdi,[rbx+20]
       mov       rsi,r8
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r15d,byte ptr [rsp+88]
       mov       [rbx+1C],r15b
       movzx     ecx,byte ptr [rbp+1D]
       movzx     edx,byte ptr [r14+1D]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        short M06_L02
       cmp       ecx,0FF
       ja        short M06_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       mov       ecx,847
       mov       rdx,7FF91CB31B70
       call      qword ptr [7FF91C5677B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB1EA30]
       int       3
M06_L01:
       mov       ecx,851
       mov       rdx,7FF91CB31B70
       call      qword ptr [7FF91C5677B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB1EA30]
       int       3
M06_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 220
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r9d
       test      r8,r8
       je        short M07_L00
       mov       rcx,rbx
       mov       rdx,r8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rbx+8],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       mov       ecx,4AB
       mov       rdx,7FF91CB31B70
       call      qword ptr [7FF91C5677B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB1EA30]
       int       3
; Total bytes of code 69
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableDictionary`2<System.__Canon,System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rdx
       mov       rbx,r8
       test      rbx,rbx
       je        near ptr M08_L05
       mov       rsi,[rcx]
       mov       edi,[rbx+18]
       add       edi,[rcx+8]
       test      rsi,rsi
       je        near ptr M08_L08
       cmp       [rbx+8],rsi
       je        near ptr M08_L09
       cmp       qword ptr [rsi+8],0
       je        near ptr M08_L08
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+10]
       test      rdx,rdx
       je        near ptr M08_L06
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp]
       mov       rcx,rbx
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0E8]
       test      rdx,rdx
       je        near ptr M08_L04
M08_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax+8]
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M08_L02
       test      rbx,rbx
       je        short M08_L01
       mov       r14d,[rsi+18]
       lea       rcx,[rsi+20]
       mov       r15,[rcx]
       vmovdqu   xmm0,xmmword ptr [rcx]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       mov       rax,[rcx+10]
       mov       [rsp+38],rax
       vmovdqu   xmm0,xmmword ptr [rsp+28]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rcx,[rsp+38]
       mov       [rsp+58],rcx
       mov       rcx,offset System.Collections.Immutable.ImmutableDictionary`2+<>c[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<.cctor>b__109_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>)
       cmp       [rbx+18],rcx
       jne       near ptr M08_L07
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       test      r15,r15
       je        short M08_L01
       cmp       byte ptr [r15+1C],0
       jne       short M08_L01
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB16A00]; System.Collections.Immutable.ImmutableList`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Freeze()
       mov       rcx,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB16A00]; System.Collections.Immutable.ImmutableList`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Freeze()
       mov       byte ptr [r15+1C],1
M08_L01:
       mov       rcx,[rsi+8]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB169B8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>>)
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF91CB169B8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>>)
       mov       byte ptr [rsi+1C],1
M08_L02:
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+18],edi
       mov       rbx,rbp
M08_L03:
       mov       rax,rbx
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
       mov       rdx,7FF91CBE8D98
       call      qword ptr [7FF91C34C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L00
M08_L05:
       mov       ecx,737
       mov       rdx,7FF91CB31B70
       call      qword ptr [7FF91C5677B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB1EA30]
       int       3
M08_L06:
       mov       ecx,6DB
       mov       rdx,7FF91CB31B70
       call      qword ptr [7FF91C5677B0]
       mov       rcx,rax
       call      qword ptr [7FF91CB1EA30]
       int       3
M08_L07:
       mov       [rsp+40],r14d
       mov       [rsp+48],r15
       lea       rdx,[rsp+40]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       near ptr M08_L01
M08_L08:
       mov       rcx,rbx
       call      qword ptr [7FF91CB1ED18]
       mov       rbx,rax
       jmp       near ptr M08_L03
M08_L09:
       jmp       near ptr M08_L03
; Total bytes of code 523
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M10_L00
       ret
M10_L00:
       jmp       qword ptr [7FF91C345C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.AutoDefaultDictionaryCollectionBenchmark.ToImmutableDictionary()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,158
       lea       rbp,[rsp+190]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-140],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       cmp       [rsi],sil
       mov       rcx,212F6000AC8
       mov       r14,[rcx]
       mov       r15,[r14+8]
       mov       r13,[r14+10]
       xor       r12d,r12d
       mov       ecx,[rsi+38]
       sub       ecx,[rsi+40]
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       r8d,[rsi+44]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       mov       [rbp-0C8],rsi
       lea       rdi,[rdx+8]
       lea       rsi,[rbp-0C8]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       [rdx+10],r8d
       xor       ecx,ecx
       mov       [rdx+14],ecx
       mov       dword ptr [rdx+18],2
       mov       rcx,rdx
M00_L01:
       mov       [rbp-148],rcx
M00_L02:
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-148]
       cmp       [rcx],rdx
       jne       near ptr M00_L30
       mov       rdx,[rcx]
       add       rcx,8
       call      qword ptr [7FF91C6F7F30]; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L03:
       test      eax,eax
       je        near ptr M00_L32
       mov       rdx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rcx,[rbp-148]
       cmp       [rcx],rdx
       jne       near ptr M00_L21
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-58],xmm0
M00_L04:
       cmp       qword ptr [rbp-58],0
       je        near ptr M00_L31
       mov       rdx,[r13+8]
       mov       r11,offset MT_System.Collections.Generic.StringEqualityComparer
       cmp       [rdx],r11
       jne       near ptr M00_L25
       mov       rdx,[rbp-58]
       add       rdx,0C
       mov       r11,[rbp-58]
       mov       r11d,[r11+8]
       add       r11d,r11d
       mov       eax,21C5CF7C
       mov       r8d,856F5367
       cmp       r11d,8
       jb        near ptr M00_L11
       mov       r10d,r11d
       shr       r10d,3
M00_L05:
       add       eax,[rdx]
       mov       r9d,[rdx+4]
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
       add       rdx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L05
       test      r11b,4
       jne       near ptr M00_L12
M00_L06:
       mov       r10d,r11d
       and       r10,7
       mov       edx,[rdx+r10-4]
       shr       edx,8
       or        edx,80000000
       not       r11d
       shl       r11d,3
       shrx      edx,edx,r11d
M00_L07:
       add       edx,eax
       mov       r11d,r8d
       xor       r11d,edx
       rol       edx,14
       add       edx,r11d
       rol       r11d,9
       xor       r11d,edx
       rol       edx,1B
       add       edx,r11d
       rol       r11d,13
       xor       r11d,edx
       mov       esi,edx
       rol       esi,14
       add       esi,r11d
       rol       r11d,9
       xor       r11d,esi
       rol       esi,1B
       add       esi,r11d
       mov       edi,r11d
       rol       edi,13
       xor       esi,edi
M00_L08:
       cmp       [r15],r15b
       mov       rdx,r15
       cmp       qword ptr [r15+8],0
       jne       near ptr M00_L15
M00_L09:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
M00_L10:
       vmovdqu   xmm0,xmmword ptr [rbp-0E0]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rdx,[rbp-0D0]
       mov       [rbp-60],rdx
       mov       rdx,[rbp-50]
       mov       [rsp+20],rdx
       mov       [rsp+28],r13
       mov       rdx,[r13+10]
       mov       [rsp+30],rdx
       mov       dword ptr [rsp+38],2
       lea       rdx,[rbp-78]
       mov       [rsp+40],rdx
       lea       rdx,[rbp-90]
       lea       rcx,[rbp-70]
       mov       r9,[rbp-58]
       mov       r8,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket
       call      qword ptr [7FF91CBAE130]; System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, KeyCollisionBehavior<System.__Canon,System.__Canon>, OperationResult<System.__Canon,System.__Canon> ByRef)
       mov       rcx,[rbp-90]
       test      rcx,rcx
       je        near ptr M00_L20
       vmovdqu   xmm0,xmmword ptr [rbp-90]
       vmovdqu   xmmword ptr [rbp-108],xmm0
       mov       r8,[rbp-80]
       mov       [rbp-0F8],r8
       mov       [rbp-108],rcx
       xor       ecx,ecx
       mov       [rbp-0E8],ecx
       cmp       qword ptr [r15+8],0
       je        near ptr M00_L19
       mov       rdi,r15
       cmp       esi,[rdi+18]
       jle       near ptr M00_L16
       mov       dword ptr [rsp+20],1
       lea       rcx,[rbp-0E8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0F0]
       mov       [rsp+30],rcx
       mov       rcx,[rdi+10]
       lea       r8,[rbp-108]
       mov       edx,esi
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91CBAE1A8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       mov       r8,rax
       cmp       byte ptr [rbp-0F0],0
       je        near ptr M00_L17
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF91CBAE1D8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       jmp       near ptr M00_L17
M00_L11:
       cmp       r11d,4
       jb        near ptr M00_L22
M00_L12:
       add       eax,[rdx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L06
       nop       dword ptr [rax]
M00_L13:
       mov       rdx,[rdx+8]
M00_L14:
       cmp       qword ptr [rdx+8],0
       je        near ptr M00_L09
M00_L15:
       mov       r9d,[rdx+18]
       cmp       esi,r9d
       je        near ptr M00_L26
       jle       short M00_L13
       mov       rdx,[rdx+10]
       jmp       short M00_L14
M00_L16:
       cmp       esi,[rdi+18]
       jge       near ptr M00_L27
       mov       dword ptr [rsp+20],1
       lea       rcx,[rbp-0E8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0F0]
       mov       [rsp+30],rcx
       mov       rcx,[rdi+8]
       lea       r8,[rbp-108]
       mov       edx,esi
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF91CBAE1A8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       mov       rdx,rax
       cmp       byte ptr [rbp-0F0],0
       je        short M00_L17
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FF91CBAE1D8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       rdi,rax
M00_L17:
       cmp       byte ptr [rbp-0F0],0
       je        near ptr M00_L29
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FF91CBAE1F0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M00_L18:
       mov       r15,rax
       cmp       dword ptr [rbp-78],1
       jne       near ptr M00_L02
       inc       r12d
       jmp       near ptr M00_L02
M00_L19:
       mov       dword ptr [rbp-0F0],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rbp-108]
       mov       rcx,rdi
       mov       edx,esi
       mov       r9,r15
       call      qword ptr [7FF91CBAE1C0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       short M00_L18
M00_L20:
       lea       r8,[rbp-0E8]
       mov       rcx,r15
       mov       edx,esi
       call      qword ptr [7FF91CCF4270]
       jmp       short M00_L18
M00_L21:
       lea       rdx,[rbp-58]
       mov       r11,7FF91C2C0FE0
       call      qword ptr [r11]
       mov       rcx,[rbp-148]
       jmp       near ptr M00_L04
M00_L22:
       mov       r10d,80
       test      r11b,1
       je        short M00_L23
       mov       r10d,r11d
       and       r10,2
       movzx     r10d,byte ptr [rdx+r10]
       or        r10d,8000
M00_L23:
       test      r11b,2
       je        short M00_L24
       shl       r10d,10
       movzx     edx,word ptr [rdx]
       or        r10d,edx
       mov       edx,r10d
       jmp       near ptr M00_L07
M00_L24:
       mov       edx,r10d
       jmp       near ptr M00_L07
M00_L25:
       mov       rcx,rdx
       mov       rdx,[rbp-58]
       mov       r11,7FF91C2C0FE8
       call      qword ptr [r11]
       mov       esi,eax
       mov       rcx,[rbp-148]
       jmp       near ptr M00_L08
M00_L26:
       vmovdqu   xmm0,xmmword ptr [rdx+20]
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       mov       r9,[rdx+30]
       mov       [rbp-0D0],r9
       jmp       near ptr M00_L10
M00_L27:
       vmovdqu   xmm0,xmmword ptr [r15+20]
       vmovdqu   xmmword ptr [rbp-128],xmm0
       mov       r8,[r15+30]
       mov       [rbp-118],r8
       vmovdqu   xmm0,xmmword ptr [rbp-108]
       vmovdqu   xmmword ptr [rbp-140],xmm0
       mov       r8,[rbp-0F8]
       mov       [rbp-130],r8
       lea       r8,[rbp-140]
       lea       rdx,[rbp-128]
       mov       rcx,r13
       mov       r11,7FF91C2C0FF8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L28
       xor       eax,eax
       mov       [rbp-0F0],eax
       mov       rax,r15
       jmp       near ptr M00_L18
M00_L28:
       mov       dword ptr [rbp-0F0],1
       mov       dword ptr [rbp-0E8],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r9,[r15+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[r15+8]
       lea       r8,[rbp-108]
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF91CBAE1C0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       jmp       near ptr M00_L17
M00_L29:
       mov       rax,rdi
       jmp       near ptr M00_L18
M00_L30:
       mov       r11,7FF91C2C0FD8
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L31:
       mov       ecx,717
       mov       rdx,7FF91CC14190
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CBAF6A8]
       int       3
M00_L32:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       r11,[rbp-148]
       cmp       [r11],rcx
       jne       near ptr M00_L35
M00_L33:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       lea       rcx,[rbp-0A0]
       mov       r9d,r12d
       mov       r8,r15
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FF91CCF43C0]; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-0A0]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       lea       rcx,[rbp-48]
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableDictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FF91CCF43D8]; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableDictionary`2<System.__Canon,System.__Canon>)
       mov       [rbp-110],rax
       mov       rcx,[rbx+60]
       lea       r8,[rbp-110]
       mov       rdx,7FF91CC33630
       cmp       [rcx],ecx
       call      qword ptr [7FF91CBAE358]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,158
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       mov       rcx,offset MT_System.GenericEmptyEnumerator<System.Collections.Generic.KeyValuePair<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,212F6000B38
       mov       rcx,[rdx]
       jmp       near ptr M00_L01
M00_L35:
       mov       rcx,r11
       mov       r11,7FF91C2C0FF0
       call      qword ptr [r11]
       jmp       near ptr M00_L33
       sub       rsp,48
       cmp       qword ptr [rbp-148],0
       je        short M00_L36
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.String, DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       mov       rax,[rbp-148]
       cmp       [rax],rcx
       je        short M00_L36
       mov       rcx,rax
       mov       r11,7FF91C2C0FF0
       call      qword ptr [r11]
M00_L36:
       nop
       add       rsp,48
       ret
; Total bytes of code 1867
```
```assembly
; System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+8]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+44]
       jne       short M01_L01
       mov       ecx,[rbx+0C]
       cmp       ecx,[rdx+38]
       jae       short M01_L03
M01_L00:
       mov       rcx,[rbx]
       mov       rcx,[rcx+10]
       mov       edx,[rbx+0C]
       lea       eax,[rdx+1]
       mov       [rbx+0C],eax
       cmp       edx,[rcx+8]
       jae       short M01_L04
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[rcx+rdx*8+10]
       cmp       dword ptr [rcx+14],0FFFFFFFF
       jl        short M01_L02
       mov       rdx,[rcx]
       mov       rsi,[rcx+8]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       call      qword ptr [7FF91C59C150]
       int       3
M01_L02:
       mov       ecx,[rbx+0C]
       mov       rdx,[rbx]
       cmp       ecx,[rdx+38]
       jb        short M01_L00
M01_L03:
       mov       rax,[rbx]
       mov       eax,[rax+38]
       inc       eax
       mov       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+18],rax
       mov       [rbx+20],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon, System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>, KeyCollisionBehavior<System.__Canon,System.__Canon>, OperationResult<System.__Canon,System.__Canon> ByRef)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A0
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       xor       eax,eax
       mov       [rsp+90],rax
       mov       [rsp+98],r8
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
M02_L00:
       cmp       qword ptr [rdi],0
       jne       short M02_L04
       mov       r14,[rsp+120]
       mov       dword ptr [r14],1
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L03
M02_L01:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,[rax]
       mov       [rbx],rcx
       mov       [rbx+8],rbp
       mov       r15,[rsp+100]
       mov       [rbx+10],r15
M02_L02:
       mov       rax,rbx
       add       rsp,0A0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF91CCD10F8
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FF91CCD0ED8
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L06:
       mov       [rsp+40],rbp
       mov       r15,[rsp+100]
       mov       [rsp+48],r15
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+40]
       lea       r8,[rsp+30]
       mov       rcx,[rsp+108]
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M02_L10
       mov       r13d,[rsp+118]
       cmp       r13d,3
       ja        short M02_L07
       mov       ecx,r13d
       lea       rax,[7FF91CC60070]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M02_L00]
       add       rax,rdx
       jmp       rax
M02_L07:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF91CA66A30]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
       xor       r8d,r8d
       mov       r14,[rsp+120]
       mov       [r14],r8d
       mov       [rsp+40],rbp
       mov       [rsp+48],r15
       lea       r8,[rsp+40]
       mov       r9,[rdi]
       lea       rcx,[rsp+50]
       mov       rdx,rsi
       call      qword ptr [7FF91CBAF720]
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rsp+60]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       lea       r13,[rdi+8]
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FF91CCD1040
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L09:
       mov       rdx,[r13+8]
       mov       rcx,[rsp+110]
       mov       r8,r15
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M02_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CBAF6C0]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CBAF6D8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF91CBAF6C0]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CBAF6D8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L10:
       mov       rcx,[rdi]
       cmp       [rcx],cl
       mov       [rsp+40],rbp
       mov       [rsp+48],r15
       mov       r13,[rsp+108]
       mov       [rsp+20],r13
       lea       rdx,[rsp+40]
       mov       r9d,[rcx+18]
       xor       r8d,r8d
       call      qword ptr [7FF91CBAF6F0]
       test      eax,eax
       jge       short M02_L11
       mov       r14,[rsp+120]
       mov       dword ptr [r14],1
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,[rdi]
       mov       [rsp+30],rbp
       mov       [rsp+38],r15
       lea       rdx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CBAF708]
       mov       r9,rax
       lea       r8,[rsp+40]
       lea       rcx,[rsp+68]
       mov       rdx,rsi
       call      qword ptr [7FF91CBAF720]
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rax,[rsp+78]
       mov       [rbx+10],rax
       jmp       near ptr M02_L02
M02_L11:
       mov       r13d,[rsp+118]
       cmp       r13d,3
       ja        short M02_L12
       mov       ecx,r13d
       lea       rdx,[7FF91CC60080]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M02_L00]
       add       rdx,r8
       jmp       rdx
M02_L12:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FF91CA66A30]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
       xor       ecx,ecx
       mov       r14,[rsp+120]
       mov       [r14],ecx
       vmovdqu   xmm0,xmmword ptr [rdi+8]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,[rdi]
       mov       [rsp+30],rbp
       mov       [rsp+38],r15
       lea       r8,[rsp+30]
       mov       edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF91CBAF738]
       mov       r9,rax
       lea       r8,[rsp+40]
       lea       rcx,[rsp+80]
       mov       rdx,rsi
       call      qword ptr [7FF91CBAF720]
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rsp+90]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       mov       rcx,[rdi]
       mov       edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF91CBAF750]
       mov       r13,rax
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FF91CCD1040
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L14:
       mov       rdx,[r13+8]
       mov       rcx,[rsp+110]
       mov       r8,r15
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CBAF6C0]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CBAF6D8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M02_L15:
       mov       r14,[rsp+120]
       mov       dword ptr [r14],2
       vmovdqu   xmm0,xmmword ptr [rdi]
       vmovdqu   xmmword ptr [rbx],xmm0
       mov       rcx,[rdi+10]
       mov       [rbx+10],rcx
       jmp       near ptr M02_L02
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF91CBAF6C0]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF91CBAF6D8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 1163
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon,System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M03_L00:
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
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       [rsp+0D0],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       rbp,r9
       mov       r15,[rsp+148]
       mov       r14,[rsp+150]
       mov       byte ptr [r15],0
       cmp       qword ptr [rbx+8],0
       je        near ptr M03_L19
       mov       r13,rbx
       cmp       edi,[r13+18]
       jle       near ptr M03_L11
       mov       r12,[r13+10]
       cmp       [r12],r12b
       mov       byte ptr [r15],0
       cmp       qword ptr [r12+8],0
       je        near ptr M03_L10
       mov       rdx,r12
       cmp       edi,[rdx+18]
       jle       near ptr M03_L04
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       [rsp+38],rdx
       mov       rcx,[rdx+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CBAE1A8]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        short M03_L03
       cmp       byte ptr [r12+1C],0
       jne       near ptr M03_L20
       test      rdi,rdi
       je        short M03_L01
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rcx,[r12+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L41
       cmp       ecx,0FF
       ja        near ptr M03_L41
       mov       [r12+1D],cl
       mov       rbp,r12
M03_L02:
       mov       rdi,rbp
       jmp       near ptr M03_L06
M03_L03:
       mov       rdi,[rsp+38]
       jmp       near ptr M03_L06
M03_L04:
       cmp       edi,[rdx+18]
       jge       near ptr M03_L24
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       [rsp+38],rdx
       mov       rcx,[rdx+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CBAE1A8]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       mov       rdi,[rsp+38]
       je        short M03_L06
       cmp       byte ptr [r12+1C],0
       jne       near ptr M03_L22
       test      rsi,rsi
       je        short M03_L05
       lea       rcx,[r12+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M03_L05:
       mov       rcx,[r12+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r12+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L41
       cmp       ecx,0FF
       ja        near ptr M03_L41
       mov       [r12+1D],cl
       mov       rdi,r12
M03_L06:
       cmp       byte ptr [r14],0
       je        near ptr M03_L29
       mov       rcx,[r12]
       mov       rdx,rdi
       call      qword ptr [7FF91CBAE1F0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       mov       r12,rax
M03_L07:
       cmp       byte ptr [r14],0
       je        near ptr M03_L13
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L30
       test      r12,r12
       je        short M03_L08
       lea       rcx,[rbx+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M03_L08:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L41
       cmp       ecx,0FF
       ja        near ptr M03_L41
       mov       [rbx+1D],cl
       mov       r13,rbx
M03_L09:
       jmp       near ptr M03_L13
M03_L10:
       mov       byte ptr [r14],1
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+20],r12
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,edi
       mov       r8,rsi
       mov       r9,r12
       call      qword ptr [7FF91CBAE1C0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r12,rbp
       jmp       near ptr M03_L07
M03_L11:
       cmp       edi,[r13+18]
       jge       near ptr M03_L34
       movzx     ecx,byte ptr [rsp+140]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF91CBAE1A8]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        short M03_L13
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L32
       test      rsi,rsi
       je        short M03_L12
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M03_L12:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L41
       cmp       ecx,0FF
       ja        near ptr M03_L41
       mov       [rbx+1D],cl
       mov       r13,rbx
M03_L13:
       cmp       byte ptr [r14],0
       je        near ptr M03_L39
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M03_L40
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jge       short M03_L16
       cmp       edx,0FFFFFFFE
       jle       short M03_L14
       mov       rax,r13
       jmp       short M03_L18
M03_L14:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M03_L40
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M03_L15
       mov       rdx,r13
       call      qword ptr [7FF91CBAE298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       short M03_L18
M03_L15:
       mov       rdx,r13
       call      qword ptr [7FF91CBAE250]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       short M03_L18
M03_L16:
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M03_L40
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       jns       short M03_L17
       mov       rdx,r13
       call      qword ptr [7FF91CBAE280]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       jmp       short M03_L18
M03_L17:
       mov       rdx,r13
       call      qword ptr [7FF91CBAE268]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M03_L18:
       nop
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
M03_L19:
       mov       byte ptr [r14],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rbp+18],edi
       lea       rdi,[rbp+20]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+1C],0
       movzx     eax,byte ptr [rbx+1D]
       add       eax,1
       jo        near ptr M03_L41
       cmp       eax,0FF
       ja        near ptr M03_L41
       mov       [rbp+1D],al
       mov       rax,rbp
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
M03_L20:
       mov       ebp,[r12+18]
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rsp+0B8],xmm0
       mov       rcx,[r12+30]
       mov       [rsp+0C8],rcx
       mov       r15,[r12+8]
       test      rdi,rdi
       jne       short M03_L21
       mov       rdi,[r12+10]
M03_L21:
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       vmovdqu   xmm0,xmmword ptr [rsp+0B8]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+0C8]
       mov       [rsp+68],r8
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,ebp
       mov       rcx,rsi
       mov       r9,r15
       call      qword ptr [7FF91CBAE1C0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdx,rsi
       mov       rbp,rdx
       jmp       near ptr M03_L02
M03_L22:
       mov       edi,[r12+18]
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       rcx,[r12+30]
       mov       [rsp+0B0],rcx
       test      rsi,rsi
       jne       short M03_L23
       mov       rsi,[r12+8]
M03_L23:
       mov       rbp,[r12+10]
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+0B0]
       mov       [rsp+68],r8
       mov       [rsp+20],rbp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,edi
       mov       rcx,r15
       mov       r9,rsi
       call      qword ptr [7FF91CBAE1C0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdx,r15
       mov       rdi,rdx
       jmp       near ptr M03_L06
M03_L24:
       mov       rcx,[r12]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L25
       jmp       short M03_L26
M03_L25:
       mov       rdx,7FF91CCD0888
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L26:
       vmovdqu   xmm0,xmmword ptr [r12+20]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       rdx,[r12+30]
       mov       [rsp+68],rdx
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdx,[rsi+10]
       mov       [rsp+50],rdx
       lea       rdx,[rsp+58]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L27
       mov       byte ptr [r14],0
       jmp       near ptr M03_L07
M03_L27:
       cmp       byte ptr [rsp+140],0
       je        short M03_L28
       mov       byte ptr [r14],1
       mov       byte ptr [r15],1
       mov       rcx,[r12]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r9,[r12+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[r12+8]
       mov       rcx,r15
       mov       edx,edi
       mov       r8,rsi
       call      qword ptr [7FF91CBAE1C0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rdi,r15
       jmp       near ptr M03_L06
M03_L28:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CBAF6C0]
       mov       r12,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r14
       mov       rcx,r12
       call      qword ptr [7FF91CBAF6D8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L29:
       mov       r12,rdi
       jmp       near ptr M03_L07
M03_L30:
       mov       r13d,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+98],rcx
       mov       rdi,[rbx+8]
       test      r12,r12
       jne       short M03_L31
       mov       r12,[rbx+10]
M03_L31:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       vmovdqu   xmm0,xmmword ptr [rsp+88]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+98]
       mov       [rsp+68],r8
       mov       [rsp+20],r12
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,r13d
       mov       rcx,rsi
       mov       r9,rdi
       call      qword ptr [7FF91CBAE1C0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r13,rsi
       jmp       near ptr M03_L09
M03_L32:
       mov       r13d,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+80],rcx
       test      rsi,rsi
       jne       short M03_L33
       mov       rsi,[rbx+8]
M03_L33:
       mov       rbp,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       vmovdqu   xmm0,xmmword ptr [rsp+70]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       r8,[rsp+80]
       mov       [rsp+68],r8
       mov       [rsp+20],rbp
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+58]
       mov       edx,r13d
       mov       rcx,r15
       mov       r9,rsi
       call      qword ptr [7FF91CBAE1C0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       r13,r15
       jmp       near ptr M03_L13
M03_L34:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L35
       jmp       short M03_L36
M03_L35:
       mov       rdx,7FF91CCD0888
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L36:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       rdx,[rbx+30]
       mov       [rsp+68],rdx
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rdx,[rsi+10]
       mov       [rsp+50],rdx
       lea       rdx,[rsp+58]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L37
       mov       byte ptr [r14],0
       mov       rax,rbx
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
M03_L37:
       cmp       byte ptr [rsp+140],0
       je        short M03_L38
       mov       byte ptr [r14],1
       mov       byte ptr [r15],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r9,[rbx+10]
       mov       [rsp+20],r9
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[rbx+8]
       mov       rcx,r13
       mov       edx,edi
       mov       r8,rsi
       call      qword ptr [7FF91CBAE1C0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       jmp       near ptr M03_L13
M03_L38:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF91CBAF6C0]
       mov       rsi,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FF91CBAF6D8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF91C6F5E00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L39:
       mov       rax,r13
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
M03_L40:
       mov       ecx,869
       mov       rdx,7FF91CC14190
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CBAF6A8]
       int       3
M03_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2192
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       [rsp+60],rax
       mov       [rsp+68],rcx
       mov       rbx,rcx
       mov       rsi,r8
       cmp       byte ptr [rbx+1C],0
       jne       short M04_L02
       test      rdx,rdx
       je        short M04_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M04_L00:
       test      rsi,rsi
       je        short M04_L01
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M04_L01:
       mov       rax,[rbx+8]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rbx+10]
       movzx     ecx,byte ptr [rcx+1D]
       cmp       eax,ecx
       cmovl     eax,ecx
       add       eax,1
       jo        near ptr M04_L05
       cmp       eax,0FF
       ja        near ptr M04_L05
       mov       [rbx+1D],al
       mov       rax,rbx
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L02:
       mov       edi,[rbx+18]
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       mov       rcx,[rbx+30]
       mov       [rsp+60],rcx
       mov       rbp,rdx
       test      rbp,rbp
       jne       short M04_L03
       mov       rbp,[rbx+8]
M04_L03:
       test      rsi,rsi
       jne       short M04_L04
       mov       rsi,[rbx+10]
M04_L04:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r8,[rsp+60]
       mov       [rsp+48],r8
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,edi
       mov       rcx,r14
       mov       r9,rbp
       call      qword ptr [7FF91CBAE1C0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       mov       rax,r14
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 267
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].MakeBalanced(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L04
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rbx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       cmp       eax,2
       jge       short M05_L02
       cmp       eax,0FFFFFFFE
       jle       short M05_L00
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FF91CBAE220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       test      eax,eax
       jle       short M05_L01
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CBAE298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CBAE250]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L02:
       mov       rdx,[rbx+10]
       mov       rcx,rsi
       call      qword ptr [7FF91CBAE220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
       test      eax,eax
       jl        short M05_L03
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CBAE268]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF91CBAE280]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>)
M05_L04:
       mov       ecx,869
       mov       rdx,7FF91CC14190
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CBAF6A8]
       int       3
; Total bytes of code 201
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon,System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Boolean)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rbp,r9
       mov       r14,[rsp+80]
       cmp       [rbx],ebx
       test      rbp,rbp
       je        short M06_L00
       test      r14,r14
       je        near ptr M06_L01
       mov       [rbx+18],edx
       lea       rdi,[rbx+20]
       mov       rsi,r8
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r15d,byte ptr [rsp+88]
       mov       [rbx+1C],r15b
       movzx     ecx,byte ptr [rbp+1D]
       movzx     edx,byte ptr [r14+1D]
       cmp       ecx,edx
       cmovl     ecx,edx
       add       ecx,1
       jo        short M06_L02
       cmp       ecx,0FF
       ja        short M06_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       mov       ecx,847
       mov       rdx,7FF91CC14190
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CBAF6A8]
       int       3
M06_L01:
       mov       ecx,851
       mov       rdx,7FF91CC14190
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CBAF6A8]
       int       3
M06_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 220
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon,System.__Canon>>, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r9d
       test      r8,r8
       je        short M07_L00
       mov       rcx,rbx
       mov       rdx,r8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rbx+8],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       mov       ecx,4AB
       mov       rdx,7FF91CC14190
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CBAF6A8]
       int       3
; Total bytes of code 69
```
```assembly
; System.Collections.Immutable.ImmutableDictionary`2+MutationResult[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableDictionary`2<System.__Canon,System.__Canon>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rdx
       mov       rbx,r8
       test      rbx,rbx
       je        near ptr M08_L05
       mov       rsi,[rcx]
       mov       edi,[rbx+18]
       add       edi,[rcx+8]
       test      rsi,rsi
       je        near ptr M08_L08
       cmp       [rbx+8],rsi
       je        near ptr M08_L09
       cmp       qword ptr [rsi+8],0
       je        near ptr M08_L08
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rbx+10]
       test      rdx,rdx
       je        near ptr M08_L06
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0E8]
       test      rdx,rdx
       je        near ptr M08_L04
M08_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp]
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbx,[rax+8]
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M08_L02
       test      rbx,rbx
       je        short M08_L01
       mov       r14d,[rsi+18]
       lea       rcx,[rsi+20]
       mov       r15,[rcx]
       vmovdqu   xmm0,xmmword ptr [rcx]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       mov       rax,[rcx+10]
       mov       [rsp+38],rax
       vmovdqu   xmm0,xmmword ptr [rsp+28]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       rcx,[rsp+38]
       mov       [rsp+58],rcx
       mov       rcx,offset System.Collections.Immutable.ImmutableDictionary`2+<>c[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].<.cctor>b__109_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>)
       cmp       [rbx+18],rcx
       jne       near ptr M08_L07
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       test      r15,r15
       je        short M08_L01
       cmp       byte ptr [r15+1C],0
       jne       short M08_L01
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CBAE340]; System.Collections.Immutable.ImmutableList`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Freeze()
       mov       rcx,[r15+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF91CBAE340]; System.Collections.Immutable.ImmutableList`1+Node[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Freeze()
       mov       byte ptr [r15+1C],1
M08_L01:
       mov       rcx,[rsi+8]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF91CBAE2F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>>)
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF91CBAE2F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableDictionary`2+HashBucket[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon,System.__Canon>>>)
       mov       byte ptr [rsi+1C],1
M08_L02:
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+18],edi
       mov       rbx,rbp
M08_L03:
       mov       rax,rbx
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
       mov       rdx,7FF91CCD63D8
       call      qword ptr [7FF91C37C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M08_L00
M08_L05:
       mov       ecx,737
       mov       rdx,7FF91CC14190
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CBAF6A8]
       int       3
M08_L06:
       mov       ecx,6DB
       mov       rdx,7FF91CC14190
       call      qword ptr [7FF91C5977B0]
       mov       rcx,rax
       call      qword ptr [7FF91CBAF6A8]
       int       3
M08_L07:
       mov       [rsp+40],r14d
       mov       [rsp+48],r15
       lea       rdx,[rsp+40]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       near ptr M08_L01
M08_L08:
       mov       rcx,rbx
       call      qword ptr [7FF91CCF4168]
       mov       rbx,rax
       jmp       near ptr M08_L03
M08_L09:
       jmp       near ptr M08_L03
; Total bytes of code 521
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
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M10_L00
       ret
M10_L00:
       jmp       qword ptr [7FF91C375C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

