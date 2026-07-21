## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rbp,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbp],rcx
       jne       near ptr M00_L15
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L08
       mov       rcx,239C7C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0BFAECC36
       mov       r8d,0A1F5656C
       cmp       edx,8
       jb        near ptr M00_L09
       mov       r10d,edx
       shr       r10d,3
       nop
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L10
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       r14d,ecx
       rol       r14d,14
       add       r14d,edx
       rol       edx,9
       xor       edx,r14d
       rol       r14d,1B
       add       r14d,edx
       mov       r15d,edx
       rol       r15d,13
       xor       r14d,r15d
M00_L03:
       mov       rax,[rsi+10]
       mov       rcx,[rax+8]
       mov       eax,r14d
       and       eax,7FFFFFFF
       mov       r8d,[rcx+8]
       cdq
       idiv      r8d
       cmp       edx,r8d
       jae       near ptr M00_L17
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L06
M00_L04:
       cmp       r14d,[rsi+18]
       je        near ptr M00_L16
M00_L05:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L08:
       xor       r14d,r14d
       jmp       short M00_L03
M00_L09:
       cmp       edx,4
       jb        short M00_L11
M00_L10:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L11:
       mov       r10d,80
       test      dl,1
       je        short M00_L12
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L12:
       test      dl,2
       je        short M00_L13
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L15:
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FF8A7B40E90
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,[rsi+8]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FF8A7B40E98
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 612
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rbp,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbp],rcx
       jne       near ptr M00_L15
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L08
       mov       rcx,20256C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,8583687E
       mov       r8d,0D4F2A152
       cmp       edx,8
       jb        near ptr M00_L09
       mov       r10d,edx
       shr       r10d,3
       nop
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L10
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       r14d,ecx
       rol       r14d,14
       add       r14d,edx
       rol       edx,9
       xor       edx,r14d
       rol       r14d,1B
       add       r14d,edx
       mov       r15d,edx
       rol       r15d,13
       xor       r14d,r15d
M00_L03:
       mov       rax,[rsi+10]
       mov       rcx,[rax+8]
       mov       eax,r14d
       and       eax,7FFFFFFF
       mov       r8d,[rcx+8]
       cdq
       idiv      r8d
       cmp       edx,r8d
       jae       near ptr M00_L17
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L06
M00_L04:
       cmp       r14d,[rsi+18]
       je        near ptr M00_L16
M00_L05:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L08:
       xor       r14d,r14d
       jmp       short M00_L03
M00_L09:
       cmp       edx,4
       jb        short M00_L11
M00_L10:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L11:
       mov       r10d,80
       test      dl,1
       je        short M00_L12
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L12:
       test      dl,2
       je        short M00_L13
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L15:
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FF8A7B60D88
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,[rsi+8]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FF8A7B60D90
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 612
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rbp,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbp],rcx
       jne       near ptr M00_L15
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L08
       mov       rcx,19997C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0CCC536A7
       mov       r8d,263BF6CA
       cmp       edx,8
       jb        near ptr M00_L09
       mov       r10d,edx
       shr       r10d,3
       nop
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L10
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       r14d,ecx
       rol       r14d,14
       add       r14d,edx
       rol       edx,9
       xor       edx,r14d
       rol       r14d,1B
       add       r14d,edx
       mov       r15d,edx
       rol       r15d,13
       xor       r14d,r15d
M00_L03:
       mov       rax,[rsi+10]
       mov       rcx,[rax+8]
       mov       eax,r14d
       and       eax,7FFFFFFF
       mov       r8d,[rcx+8]
       cdq
       idiv      r8d
       cmp       edx,r8d
       jae       near ptr M00_L17
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L06
M00_L04:
       cmp       r14d,[rsi+18]
       je        near ptr M00_L16
M00_L05:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L08:
       xor       r14d,r14d
       jmp       short M00_L03
M00_L09:
       cmp       edx,4
       jb        short M00_L11
M00_L10:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L11:
       mov       r10d,80
       test      dl,1
       je        short M00_L12
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L12:
       test      dl,2
       je        short M00_L13
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L15:
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FF8A7B40D90
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,[rsi+8]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FF8A7B40D98
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 612
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rbp,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbp],rcx
       jne       near ptr M00_L15
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L08
       mov       rcx,28726C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,358E4BDE
       mov       r8d,255439A9
       cmp       edx,8
       jb        near ptr M00_L09
       mov       r10d,edx
       shr       r10d,3
       nop
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L10
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       r14d,ecx
       rol       r14d,14
       add       r14d,edx
       rol       edx,9
       xor       edx,r14d
       rol       r14d,1B
       add       r14d,edx
       mov       r15d,edx
       rol       r15d,13
       xor       r14d,r15d
M00_L03:
       mov       rax,[rsi+10]
       mov       rcx,[rax+8]
       mov       eax,r14d
       and       eax,7FFFFFFF
       mov       r8d,[rcx+8]
       cdq
       idiv      r8d
       cmp       edx,r8d
       jae       near ptr M00_L17
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L06
M00_L04:
       cmp       r14d,[rsi+18]
       je        near ptr M00_L16
M00_L05:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L08:
       xor       r14d,r14d
       jmp       short M00_L03
M00_L09:
       cmp       edx,4
       jb        short M00_L11
M00_L10:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L11:
       mov       r10d,80
       test      dl,1
       je        short M00_L12
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L12:
       test      dl,2
       je        short M00_L13
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L15:
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FF8A7B40D88
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,[rsi+8]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FF8A7B40D90
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 612
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rbp,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbp],rcx
       jne       near ptr M00_L15
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L08
       mov       rcx,22EDC000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0AA8F7891
       mov       r8d,0DC33D5
       cmp       edx,8
       jb        near ptr M00_L09
       mov       r10d,edx
       shr       r10d,3
       nop
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L10
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       r14d,ecx
       rol       r14d,14
       add       r14d,edx
       rol       edx,9
       xor       edx,r14d
       rol       r14d,1B
       add       r14d,edx
       mov       r15d,edx
       rol       r15d,13
       xor       r14d,r15d
M00_L03:
       mov       rax,[rsi+10]
       mov       rcx,[rax+8]
       mov       eax,r14d
       and       eax,7FFFFFFF
       mov       r8d,[rcx+8]
       cdq
       idiv      r8d
       cmp       edx,r8d
       jae       near ptr M00_L17
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L06
M00_L04:
       cmp       r14d,[rsi+18]
       je        near ptr M00_L16
M00_L05:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L08:
       xor       r14d,r14d
       jmp       short M00_L03
M00_L09:
       cmp       edx,4
       jb        short M00_L11
M00_L10:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L11:
       mov       r10d,80
       test      dl,1
       je        short M00_L12
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L12:
       test      dl,2
       je        short M00_L13
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L15:
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FF8A7B60D90
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,[rsi+8]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FF8A7B60D98
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 612
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rbp,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbp],rcx
       jne       near ptr M00_L15
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L08
       mov       rcx,2269B400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,57A073DE
       mov       r8d,2FF2AC09
       cmp       edx,8
       jb        near ptr M00_L09
       mov       r10d,edx
       shr       r10d,3
       nop
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L10
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       r14d,ecx
       rol       r14d,14
       add       r14d,edx
       rol       edx,9
       xor       edx,r14d
       rol       r14d,1B
       add       r14d,edx
       mov       r15d,edx
       rol       r15d,13
       xor       r14d,r15d
M00_L03:
       mov       rax,[rsi+10]
       mov       rcx,[rax+8]
       mov       eax,r14d
       and       eax,7FFFFFFF
       mov       r8d,[rcx+8]
       cdq
       idiv      r8d
       cmp       edx,r8d
       jae       near ptr M00_L17
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L06
M00_L04:
       cmp       r14d,[rsi+18]
       je        near ptr M00_L16
M00_L05:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L08:
       xor       r14d,r14d
       jmp       short M00_L03
M00_L09:
       cmp       edx,4
       jb        short M00_L11
M00_L10:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L11:
       mov       r10d,80
       test      dl,1
       je        short M00_L12
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L12:
       test      dl,2
       je        short M00_L13
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L15:
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FF8A7B50D90
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,[rsi+8]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FF8A7B50D98
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 612
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rbp,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbp],rcx
       jne       near ptr M00_L15
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L08
       mov       rcx,225BD000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,83BFFB4A
       mov       r8d,24CED359
       cmp       edx,8
       jb        near ptr M00_L09
       mov       r10d,edx
       shr       r10d,3
       nop
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L10
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       r14d,ecx
       rol       r14d,14
       add       r14d,edx
       rol       edx,9
       xor       edx,r14d
       rol       r14d,1B
       add       r14d,edx
       mov       r15d,edx
       rol       r15d,13
       xor       r14d,r15d
M00_L03:
       mov       rax,[rsi+10]
       mov       rcx,[rax+8]
       mov       eax,r14d
       and       eax,7FFFFFFF
       mov       r8d,[rcx+8]
       cdq
       idiv      r8d
       cmp       edx,r8d
       jae       near ptr M00_L17
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L06
M00_L04:
       cmp       r14d,[rsi+18]
       je        near ptr M00_L16
M00_L05:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L08:
       xor       r14d,r14d
       jmp       short M00_L03
M00_L09:
       cmp       edx,4
       jb        short M00_L11
M00_L10:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L11:
       mov       r10d,80
       test      dl,1
       je        short M00_L12
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L12:
       test      dl,2
       je        short M00_L13
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L15:
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FF8A7B70F30
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,[rsi+8]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FF8A7B70F38
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 612
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L06
       mov       rbp,[rsi+8]
       mov       rcx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbp],rcx
       jne       near ptr M00_L15
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L08
       mov       rcx,135A1800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,21BE6D8D
       mov       r8d,74597411
       cmp       edx,8
       jb        near ptr M00_L09
       mov       r10d,edx
       shr       r10d,3
       nop
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L10
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       r14d,ecx
       rol       r14d,14
       add       r14d,edx
       rol       edx,9
       xor       edx,r14d
       rol       r14d,1B
       add       r14d,edx
       mov       r15d,edx
       rol       r15d,13
       xor       r14d,r15d
M00_L03:
       mov       rax,[rsi+10]
       mov       rcx,[rax+8]
       mov       eax,r14d
       and       eax,7FFFFFFF
       mov       r8d,[rcx+8]
       cdq
       idiv      r8d
       cmp       edx,r8d
       jae       near ptr M00_L17
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L06
M00_L04:
       cmp       r14d,[rsi+18]
       je        near ptr M00_L16
M00_L05:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L08:
       xor       r14d,r14d
       jmp       short M00_L03
M00_L09:
       cmp       edx,4
       jb        short M00_L11
M00_L10:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L11:
       mov       r10d,80
       test      dl,1
       je        short M00_L12
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L12:
       test      dl,2
       je        short M00_L13
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L15:
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FF8A7B711B0
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,[rsi+8]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FF8A7B711B8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 612
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
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
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       [rbp-78],rsi
       cmp       [rsi],sil
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       r14,[rcx+10]
       xor       r15d,r15d
       test      r14,r14
       je        near ptr M00_L14
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L02
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD6E0]
       int       3
M00_L03:
       mov       rcx,r13
       call      qword ptr [7FF8A83D7060]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L26
       test      r15d,r15d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+10]
       mov       r13d,1
       cmp       r14d,1
       jle       short M00_L12
       test      r15,r15
       je        short M00_L06
       cmp       [r15+8],r14d
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L09
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L08
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD6E0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FF8A83D7060]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r13d,1
       jo        near ptr M00_L26
       cmp       r13d,r14d
       jl        short M00_L06
M00_L12:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       eax,[rcx+8]
       xor       edx,edx
M00_L13:
       cmp       edx,eax
       jge       near ptr M00_L27
       add       edi,[rcx+rdx*4+10]
       jo        near ptr M00_L26
       add       edx,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L17
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L16
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD6E0]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r13
       call      qword ptr [7FF8A83D7060]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
       nop       dword ptr [rax]
M00_L19:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        short M00_L26
       test      r15d,r15d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L22
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD6E0]
       int       3
M00_L23:
       mov       rcx,r12
       call      qword ptr [7FF8A83D7060]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r13d,1
       jo        short M00_L26
       cmp       r13d,r14d
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       r14d,r14d
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L30
M00_L28:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L73
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L72
       mov       rcx,r15
       call      00007FF9078ADE50
       test      eax,eax
       jne       near ptr M00_L69
M00_L29:
       add       r14d,1
       jo        near ptr M00_L74
       cmp       r14d,[rbp-3C]
       jl        short M00_L28
M00_L30:
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       edi,[rcx+8]
       mov       ecx,edi
       test      ecx,ecx
       jle       near ptr M00_L70
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rsi+10]
       mov       r15,[rcx+10]
       xor       r13d,r13d
       test      r15,r15
       je        near ptr M00_L46
       cmp       dword ptr [r15+8],0
       jle       near ptr M00_L46
M00_L31:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L33
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD6E0]
       int       3
M00_L34:
       mov       rcx,r12
       call      qword ptr [7FF8A83D7060]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       test      r13d,r13d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       r15d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r13,[rcx+10]
       mov       r12d,1
       cmp       r15d,1
       jle       near ptr M00_L43
       test      r13,r13
       je        short M00_L37
       cmp       [r13+8],r15d
       jge       near ptr M00_L57
M00_L37:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       cmp       r12d,[r13+8]
       jae       short M00_L40
       mov       ecx,r12d
       mov       rcx,[r13+rcx*8+10]
       mov       rax,rcx
       test      rax,rax
       je        short M00_L39
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD6E0]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF8A83D7060]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L64
       cmp       r12d,r15d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       dword ptr [rax+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       edx,[rax+8]
       jae       near ptr M00_L63
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L64
       add       edx,1
       jo        near ptr M00_L64
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L44
M00_L45:
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L64
       or        edx,ecx
       jl        near ptr M00_L61
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-68],rax
       xor       r8d,r8d
       jmp       near ptr M00_L59
M00_L46:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L49
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L48
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L50
M00_L47:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L51
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD6E0]
       int       3
M00_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L50:
       mov       rcx,r12
       call      qword ptr [7FF8A83D7060]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L47
M00_L51:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       test      r13d,r13d
       jle       short M00_L46
       jmp       near ptr M00_L36
M00_L52:
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       test      rax,rax
       je        short M00_L54
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L55
M00_L53:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L56
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD6E0]
       int       3
M00_L55:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF8A83D7060]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L53
M00_L56:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L64
       cmp       r12d,r15d
       jge       near ptr M00_L43
M00_L57:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       jmp       short M00_L52
M00_L58:
       mov       rcx,[rbp-70]
       add       ecx,1
       jo        near ptr M00_L64
       mov       r8,rcx
       mov       rax,[rbp-68]
M00_L59:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L65
       cmp       r8d,r12d
       jae       near ptr M00_L63
       mov       [rbp-70],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L58
       mov       r9d,edi
       mov       [rbp-60],r9
M00_L60:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L63
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-88],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        short M00_L64
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-60]
       jne       short M00_L60
       jmp       short M00_L58
M00_L61:
       call      qword ptr [7FF8A83D6400]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FF8A84A4258]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,66CF
       mov       rdx,7FF8A7ED4D10
       call      qword ptr [7FF8A7E17798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF8A7F77D80]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L65:
       xor       edi,edi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L68
M00_L66:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L73
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L72
       mov       rcx,r15
       call      00007FF9078ADE50
       test      eax,eax
       jne       near ptr M00_L71
M00_L67:
       add       edi,1
       jo        near ptr M00_L74
       cmp       edi,[rbp-48]
       jl        short M00_L66
M00_L68:
       mov       [rbp-58],r14
       mov       rdi,[rbx+88]
       mov       rdx,[rbp-58]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
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
M00_L69:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF8A83DD7D0]
       jmp       near ptr M00_L29
M00_L70:
       call      qword ptr [7FF8A83D64A8]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2F9E9ED6FB8
       mov       r8,2F9E9ED6FB8
       call      qword ptr [7FF8A83DCF18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L71:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF8A83DD7D0]
       jmp       near ptr M00_L67
M00_L72:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD6E0]
       int       3
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L75
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L76
       mov       [rbp-3C],ecx
M00_L75:
       add       rsp,28
       ret
M00_L76:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L77
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L78
       mov       [rbp-3C],ecx
M00_L77:
       add       rsp,28
       ret
M00_L78:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L79
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-3C],ecx
M00_L79:
       add       rsp,28
       ret
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L81
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L82
       mov       [rbp-3C],ecx
M00_L81:
       add       rsp,28
       ret
M00_L82:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L88
M00_L83:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       r14d,[rcx+8]
       jae       short M00_L86
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L85
       mov       rcx,r15
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L84
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF8A83DD7D0]
M00_L84:
       add       r14d,1
       jo        short M00_L87
       cmp       r14d,[rbp-3C]
       jl        short M00_L83
       jmp       short M00_L88
M00_L85:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD6E0]
       int       3
M00_L86:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L87:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L88:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L89
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L90
       mov       [rbp-48],ecx
M00_L89:
       add       rsp,28
       ret
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L91
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-48],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L93
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-48],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L95
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-48],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-48]
       jge       short M00_L102
M00_L97:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L100
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L99
       mov       rcx,r15
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L98
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF8A83DD7D0]
M00_L98:
       add       edi,1
       jo        short M00_L101
       cmp       edi,[rbp-48]
       jl        short M00_L97
       jmp       short M00_L102
M00_L99:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD6E0]
       int       3
M00_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L102:
       add       rsp,28
       ret
; Total bytes of code 2210
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
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
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       [rbp-78],rsi
       cmp       [rsi],sil
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       r14,[rcx+10]
       xor       r15d,r15d
       test      r14,r14
       je        near ptr M00_L14
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L02
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD710]
       int       3
M00_L03:
       mov       rcx,r13
       call      qword ptr [7FF8A83FE640]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L26
       test      r15d,r15d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+10]
       mov       r13d,1
       cmp       r14d,1
       jle       short M00_L12
       test      r15,r15
       je        short M00_L06
       cmp       [r15+8],r14d
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L09
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L08
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD710]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FF8A83FE640]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r13d,1
       jo        near ptr M00_L26
       cmp       r13d,r14d
       jl        short M00_L06
M00_L12:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       eax,[rcx+8]
       xor       edx,edx
M00_L13:
       cmp       edx,eax
       jge       near ptr M00_L27
       add       edi,[rcx+rdx*4+10]
       jo        near ptr M00_L26
       add       edx,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L17
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L16
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD710]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r13
       call      qword ptr [7FF8A83FE640]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
       nop       dword ptr [rax]
M00_L19:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        short M00_L26
       test      r15d,r15d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L22
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD710]
       int       3
M00_L23:
       mov       rcx,r12
       call      qword ptr [7FF8A83FE640]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r13d,1
       jo        short M00_L26
       cmp       r13d,r14d
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       r14d,r14d
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L30
M00_L28:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L73
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L72
       mov       rcx,r15
       call      00007FF9078ADE50
       test      eax,eax
       jne       near ptr M00_L69
M00_L29:
       add       r14d,1
       jo        near ptr M00_L74
       cmp       r14d,[rbp-3C]
       jl        short M00_L28
M00_L30:
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       edi,[rcx+8]
       mov       ecx,edi
       test      ecx,ecx
       jle       near ptr M00_L70
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rsi+10]
       mov       r15,[rcx+10]
       xor       r13d,r13d
       test      r15,r15
       je        near ptr M00_L46
       cmp       dword ptr [r15+8],0
       jle       near ptr M00_L46
M00_L31:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L33
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD710]
       int       3
M00_L34:
       mov       rcx,r12
       call      qword ptr [7FF8A83FE640]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       test      r13d,r13d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       r15d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r13,[rcx+10]
       mov       r12d,1
       cmp       r15d,1
       jle       near ptr M00_L43
       test      r13,r13
       je        short M00_L37
       cmp       [r13+8],r15d
       jge       near ptr M00_L57
M00_L37:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       cmp       r12d,[r13+8]
       jae       short M00_L40
       mov       ecx,r12d
       mov       rcx,[r13+rcx*8+10]
       mov       rax,rcx
       test      rax,rax
       je        short M00_L39
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD710]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF8A83FE640]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L64
       cmp       r12d,r15d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       dword ptr [rax+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       edx,[rax+8]
       jae       near ptr M00_L63
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L64
       add       edx,1
       jo        near ptr M00_L64
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L44
M00_L45:
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L64
       or        edx,ecx
       jl        near ptr M00_L61
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-68],rax
       xor       r8d,r8d
       jmp       near ptr M00_L59
M00_L46:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L49
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L48
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L50
M00_L47:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L51
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD710]
       int       3
M00_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L50:
       mov       rcx,r12
       call      qword ptr [7FF8A83FE640]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L47
M00_L51:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       test      r13d,r13d
       jle       short M00_L46
       jmp       near ptr M00_L36
M00_L52:
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       test      rax,rax
       je        short M00_L54
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L55
M00_L53:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L56
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD710]
       int       3
M00_L55:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF8A83FE640]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L53
M00_L56:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L64
       cmp       r12d,r15d
       jge       near ptr M00_L43
M00_L57:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       jmp       short M00_L52
M00_L58:
       mov       rcx,[rbp-70]
       add       ecx,1
       jo        near ptr M00_L64
       mov       r8,rcx
       mov       rax,[rbp-68]
M00_L59:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L65
       cmp       r8d,r12d
       jae       near ptr M00_L63
       mov       [rbp-70],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L58
       mov       r9d,edi
       mov       [rbp-60],r9
M00_L60:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L63
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-88],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        short M00_L64
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-60]
       jne       short M00_L60
       jmp       short M00_L58
M00_L61:
       call      qword ptr [7FF8A83F6520]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FF8A84B42A0]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,66CF
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E37798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF8A7F97D80]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L65:
       xor       edi,edi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L68
M00_L66:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L73
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L72
       mov       rcx,r15
       call      00007FF9078ADE50
       test      eax,eax
       jne       near ptr M00_L71
M00_L67:
       add       edi,1
       jo        near ptr M00_L74
       cmp       edi,[rbp-48]
       jl        short M00_L66
M00_L68:
       mov       [rbp-58],r14
       mov       rdi,[rbx+88]
       mov       rdx,[rbp-58]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
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
M00_L69:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF8A83FD800]
       jmp       near ptr M00_L29
M00_L70:
       call      qword ptr [7FF8A83F65C8]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,239E5466FB8
       mov       r8,239E5466FB8
       call      qword ptr [7FF8A83FCF48]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L71:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF8A83FD800]
       jmp       near ptr M00_L67
M00_L72:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD710]
       int       3
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L75
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L76
       mov       [rbp-3C],ecx
M00_L75:
       add       rsp,28
       ret
M00_L76:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L77
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L78
       mov       [rbp-3C],ecx
M00_L77:
       add       rsp,28
       ret
M00_L78:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L79
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-3C],ecx
M00_L79:
       add       rsp,28
       ret
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L81
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L82
       mov       [rbp-3C],ecx
M00_L81:
       add       rsp,28
       ret
M00_L82:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L88
M00_L83:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       r14d,[rcx+8]
       jae       short M00_L86
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L85
       mov       rcx,r15
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L84
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF8A83FD800]
M00_L84:
       add       r14d,1
       jo        short M00_L87
       cmp       r14d,[rbp-3C]
       jl        short M00_L83
       jmp       short M00_L88
M00_L85:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD710]
       int       3
M00_L86:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L87:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L88:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L89
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L90
       mov       [rbp-48],ecx
M00_L89:
       add       rsp,28
       ret
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L91
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-48],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L93
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-48],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L95
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-48],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-48]
       jge       short M00_L102
M00_L97:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L100
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L99
       mov       rcx,r15
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L98
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF8A83FD800]
M00_L98:
       add       edi,1
       jo        short M00_L101
       cmp       edi,[rbp-48]
       jl        short M00_L97
       jmp       short M00_L102
M00_L99:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD710]
       int       3
M00_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L102:
       add       rsp,28
       ret
; Total bytes of code 2210
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF8A7C58210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF9078AE370
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L01
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 154
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
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
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       [rbp-78],rsi
       cmp       [rsi],sil
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       r14,[rcx+10]
       xor       r15d,r15d
       test      r14,r14
       je        near ptr M00_L14
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L02
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6E0]
       int       3
M00_L03:
       mov       rcx,r13
       call      qword ptr [7FF8A83EE610]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L26
       test      r15d,r15d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+10]
       mov       r13d,1
       cmp       r14d,1
       jle       short M00_L12
       test      r15,r15
       je        short M00_L06
       cmp       [r15+8],r14d
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L09
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L08
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6E0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FF8A83EE610]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r13d,1
       jo        near ptr M00_L26
       cmp       r13d,r14d
       jl        short M00_L06
M00_L12:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       eax,[rcx+8]
       xor       edx,edx
M00_L13:
       cmp       edx,eax
       jge       near ptr M00_L27
       add       edi,[rcx+rdx*4+10]
       jo        near ptr M00_L26
       add       edx,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L17
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L16
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6E0]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r13
       call      qword ptr [7FF8A83EE610]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
       nop       dword ptr [rax]
M00_L19:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        short M00_L26
       test      r15d,r15d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L22
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6E0]
       int       3
M00_L23:
       mov       rcx,r12
       call      qword ptr [7FF8A83EE610]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r13d,1
       jo        short M00_L26
       cmp       r13d,r14d
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       r14d,r14d
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L30
M00_L28:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L73
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L72
       mov       rcx,r15
       call      00007FF9078ADE50
       test      eax,eax
       jne       near ptr M00_L69
M00_L29:
       add       r14d,1
       jo        near ptr M00_L74
       cmp       r14d,[rbp-3C]
       jl        short M00_L28
M00_L30:
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       edi,[rcx+8]
       mov       ecx,edi
       test      ecx,ecx
       jle       near ptr M00_L70
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rsi+10]
       mov       r15,[rcx+10]
       xor       r13d,r13d
       test      r15,r15
       je        near ptr M00_L49
       cmp       dword ptr [r15+8],0
       jle       near ptr M00_L49
M00_L31:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L33
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6E0]
       int       3
M00_L34:
       mov       rcx,r12
       call      qword ptr [7FF8A83EE610]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       test      r13d,r13d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       r15d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r13,[rcx+10]
       mov       r12d,1
       cmp       r15d,1
       jle       near ptr M00_L43
       test      r13,r13
       je        short M00_L37
       cmp       [r13+8],r15d
       jge       near ptr M00_L60
M00_L37:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       cmp       r12d,[r13+8]
       jae       short M00_L40
       mov       ecx,r12d
       mov       rcx,[r13+rcx*8+10]
       mov       rax,rcx
       test      rax,rax
       je        short M00_L39
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6E0]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF8A83EE610]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L64
       cmp       r12d,r15d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       dword ptr [rax+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       edx,[rax+8]
       jae       near ptr M00_L63
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L64
       add       edx,1
       jo        near ptr M00_L64
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L44
M00_L45:
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L64
       or        edx,ecx
       jl        near ptr M00_L61
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-68],rax
       xor       r8d,r8d
       jmp       short M00_L47
M00_L46:
       mov       rcx,[rbp-70]
       add       ecx,1
       jo        near ptr M00_L64
       mov       r8,rcx
       mov       rax,[rbp-68]
M00_L47:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L65
       cmp       r8d,r12d
       jae       near ptr M00_L63
       mov       [rbp-70],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L46
       mov       r9d,edi
       mov       [rbp-60],r9
M00_L48:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L63
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-88],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L64
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-60]
       jne       short M00_L48
       jmp       near ptr M00_L46
M00_L49:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L52
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L51
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L53
M00_L50:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6E0]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       mov       rcx,r12
       call      qword ptr [7FF8A83EE610]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L50
M00_L54:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       test      r13d,r13d
       jle       short M00_L49
       jmp       near ptr M00_L36
M00_L55:
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       test      rax,rax
       je        short M00_L57
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L58
M00_L56:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L59
M00_L57:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6E0]
       int       3
M00_L58:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF8A83EE610]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L56
M00_L59:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L64
       mov       [rbp-48],ecx
       add       r12d,1
       jo        short M00_L64
       cmp       r12d,r15d
       jge       near ptr M00_L43
M00_L60:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       jmp       short M00_L55
M00_L61:
       call      qword ptr [7FF8A83E6508]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FF8A84A4270]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,66CF
       mov       rdx,7FF8A7EE4D10
       call      qword ptr [7FF8A7E27798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF8A7F87D80]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L65:
       xor       edi,edi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L68
M00_L66:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L73
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L72
       mov       rcx,r15
       call      00007FF9078ADE50
       test      eax,eax
       jne       near ptr M00_L71
M00_L67:
       add       edi,1
       jo        near ptr M00_L74
       cmp       edi,[rbp-48]
       jl        short M00_L66
M00_L68:
       mov       [rbp-58],r14
       mov       rdi,[rbx+88]
       mov       rdx,[rbp-58]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
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
M00_L69:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF8A83ED7D0]
       jmp       near ptr M00_L29
M00_L70:
       call      qword ptr [7FF8A83E65B0]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2323F2D6FB8
       mov       r8,2323F2D6FB8
       call      qword ptr [7FF8A83ECF18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L71:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF8A83ED7D0]
       jmp       near ptr M00_L67
M00_L72:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6E0]
       int       3
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L75
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L76
       mov       [rbp-3C],ecx
M00_L75:
       add       rsp,28
       ret
M00_L76:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L77
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L78
       mov       [rbp-3C],ecx
M00_L77:
       add       rsp,28
       ret
M00_L78:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L79
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-3C],ecx
M00_L79:
       add       rsp,28
       ret
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L81
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L82
       mov       [rbp-3C],ecx
M00_L81:
       add       rsp,28
       ret
M00_L82:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L88
M00_L83:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       r14d,[rcx+8]
       jae       short M00_L86
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L85
       mov       rcx,r15
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L84
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF8A83ED7D0]
M00_L84:
       add       r14d,1
       jo        short M00_L87
       cmp       r14d,[rbp-3C]
       jl        short M00_L83
       jmp       short M00_L88
M00_L85:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6E0]
       int       3
M00_L86:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L87:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L88:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L89
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L90
       mov       [rbp-48],ecx
M00_L89:
       add       rsp,28
       ret
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L91
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-48],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L93
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-48],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L95
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-48],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-48]
       jge       short M00_L102
M00_L97:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L100
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L99
       mov       rcx,r15
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L98
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF8A83ED7D0]
M00_L98:
       add       edi,1
       jo        short M00_L101
       cmp       edi,[rbp-48]
       jl        short M00_L97
       jmp       short M00_L102
M00_L99:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6E0]
       int       3
M00_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L102:
       add       rsp,28
       ret
; Total bytes of code 2206
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF8A7C48210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF9078AE370
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L01
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 154
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
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
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       [rbp-78],rsi
       cmp       [rsi],sil
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       r14,[rcx+10]
       xor       r15d,r15d
       test      r14,r14
       je        near ptr M00_L14
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L02
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6F8]
       int       3
M00_L03:
       mov       rcx,r13
       call      qword ptr [7FF8A83EE5F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L26
       test      r15d,r15d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+10]
       mov       r13d,1
       cmp       r14d,1
       jle       short M00_L12
       test      r15,r15
       je        short M00_L06
       cmp       [r15+8],r14d
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L09
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L08
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6F8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FF8A83EE5F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r13d,1
       jo        near ptr M00_L26
       cmp       r13d,r14d
       jl        short M00_L06
M00_L12:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       eax,[rcx+8]
       xor       edx,edx
M00_L13:
       cmp       edx,eax
       jge       near ptr M00_L27
       add       edi,[rcx+rdx*4+10]
       jo        near ptr M00_L26
       add       edx,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L17
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L16
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6F8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r13
       call      qword ptr [7FF8A83EE5F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
       nop       dword ptr [rax]
M00_L19:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        short M00_L26
       test      r15d,r15d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L22
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6F8]
       int       3
M00_L23:
       mov       rcx,r12
       call      qword ptr [7FF8A83EE5F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r13d,1
       jo        short M00_L26
       cmp       r13d,r14d
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       r14d,r14d
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L30
M00_L28:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L73
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L72
       mov       rcx,r15
       call      00007FF9078ADE50
       test      eax,eax
       jne       near ptr M00_L69
M00_L29:
       add       r14d,1
       jo        near ptr M00_L74
       cmp       r14d,[rbp-3C]
       jl        short M00_L28
M00_L30:
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       edi,[rcx+8]
       mov       ecx,edi
       test      ecx,ecx
       jle       near ptr M00_L70
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rsi+10]
       mov       r15,[rcx+10]
       xor       r13d,r13d
       test      r15,r15
       je        near ptr M00_L46
       cmp       dword ptr [r15+8],0
       jle       near ptr M00_L46
M00_L31:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L33
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6F8]
       int       3
M00_L34:
       mov       rcx,r12
       call      qword ptr [7FF8A83EE5F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       test      r13d,r13d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       r15d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r13,[rcx+10]
       mov       r12d,1
       cmp       r15d,1
       jle       near ptr M00_L43
       test      r13,r13
       je        short M00_L37
       cmp       [r13+8],r15d
       jge       near ptr M00_L57
M00_L37:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       cmp       r12d,[r13+8]
       jae       short M00_L40
       mov       ecx,r12d
       mov       rcx,[r13+rcx*8+10]
       mov       rax,rcx
       test      rax,rax
       je        short M00_L39
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6F8]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF8A83EE5F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L64
       cmp       r12d,r15d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       dword ptr [rax+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       edx,[rax+8]
       jae       near ptr M00_L63
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L64
       add       edx,1
       jo        near ptr M00_L64
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L44
M00_L45:
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L64
       or        edx,ecx
       jl        near ptr M00_L61
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-68],rax
       xor       r8d,r8d
       jmp       near ptr M00_L59
M00_L46:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L49
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L48
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L50
M00_L47:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L51
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6F8]
       int       3
M00_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L50:
       mov       rcx,r12
       call      qword ptr [7FF8A83EE5F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L47
M00_L51:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       test      r13d,r13d
       jle       short M00_L46
       jmp       near ptr M00_L36
M00_L52:
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       test      rax,rax
       je        short M00_L54
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L55
M00_L53:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L56
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6F8]
       int       3
M00_L55:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF8A83EE5F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L53
M00_L56:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L64
       cmp       r12d,r15d
       jge       near ptr M00_L43
M00_L57:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       jmp       short M00_L52
M00_L58:
       mov       rcx,[rbp-70]
       add       ecx,1
       jo        near ptr M00_L64
       mov       r8,rcx
       mov       rax,[rbp-68]
M00_L59:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L65
       cmp       r8d,r12d
       jae       near ptr M00_L63
       mov       [rbp-70],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L58
       mov       r9d,edi
       mov       [rbp-60],r9
M00_L60:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L63
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-88],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        short M00_L64
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-60]
       jne       short M00_L60
       jmp       short M00_L58
M00_L61:
       call      qword ptr [7FF8A83E6430]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FF8A83EF780]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,66CF
       mov       rdx,7FF8A7EE4D10
       call      qword ptr [7FF8A7E27798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF8A7F87D80]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L65:
       xor       edi,edi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L68
M00_L66:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L73
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L72
       mov       rcx,r15
       call      00007FF9078ADE50
       test      eax,eax
       jne       near ptr M00_L71
M00_L67:
       add       edi,1
       jo        near ptr M00_L74
       cmp       edi,[rbp-48]
       jl        short M00_L66
M00_L68:
       mov       [rbp-58],r14
       mov       rdi,[rbx+88]
       mov       rdx,[rbp-58]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
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
M00_L69:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF8A83ED7E8]
       jmp       near ptr M00_L29
M00_L70:
       call      qword ptr [7FF8A83E64D8]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,28451B96FB8
       mov       r8,28451B96FB8
       call      qword ptr [7FF8A83ECF30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L71:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF8A83ED7E8]
       jmp       near ptr M00_L67
M00_L72:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6F8]
       int       3
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L75
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L76
       mov       [rbp-3C],ecx
M00_L75:
       add       rsp,28
       ret
M00_L76:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L77
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L78
       mov       [rbp-3C],ecx
M00_L77:
       add       rsp,28
       ret
M00_L78:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L79
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-3C],ecx
M00_L79:
       add       rsp,28
       ret
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L81
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L82
       mov       [rbp-3C],ecx
M00_L81:
       add       rsp,28
       ret
M00_L82:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L88
M00_L83:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       r14d,[rcx+8]
       jae       short M00_L86
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L85
       mov       rcx,r15
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L84
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF8A83ED7E8]
M00_L84:
       add       r14d,1
       jo        short M00_L87
       cmp       r14d,[rbp-3C]
       jl        short M00_L83
       jmp       short M00_L88
M00_L85:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6F8]
       int       3
M00_L86:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L87:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L88:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L89
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L90
       mov       [rbp-48],ecx
M00_L89:
       add       rsp,28
       ret
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L91
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-48],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L93
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-48],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L95
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-48],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-48]
       jge       short M00_L102
M00_L97:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L100
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L99
       mov       rcx,r15
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L98
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF8A83ED7E8]
M00_L98:
       add       edi,1
       jo        short M00_L101
       cmp       edi,[rbp-48]
       jl        short M00_L97
       jmp       short M00_L102
M00_L99:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED6F8]
       int       3
M00_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L102:
       add       rsp,28
       ret
; Total bytes of code 2210
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF8A7C48210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF9078AE370
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L01
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 154
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
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
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L16
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L16
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D6F8]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF8A840E5F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L15
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D6F8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF8A840E5F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jge       short M00_L12
M00_L15:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L22
M00_L16:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L19
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L18
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D6F8]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r15
       call      qword ptr [7FF8A840E5F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L24
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-44],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D6F8]
       int       3
M00_L25:
       mov       rcx,r13
       call      qword ptr [7FF8A840E5F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L23
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L30
M00_L28:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       near ptr M00_L73
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L72
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       near ptr M00_L69
M00_L29:
       add       edi,1
       jo        near ptr M00_L74
       cmp       edi,[rbp-3C]
       jl        short M00_L28
M00_L30:
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rdi
       mov       esi,[rcx+8]
       mov       ecx,esi
       test      ecx,ecx
       jle       near ptr M00_L70
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       xor       r15d,r15d
       test      r14,r14
       je        near ptr M00_L49
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L49
M00_L31:
       xor       eax,eax
       mov       [rbp-4C],eax
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L33
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D6F8]
       int       3
M00_L34:
       mov       rcx,r13
       call      qword ptr [7FF8A840E5F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r15d,1
       jo        near ptr M00_L64
       test      r15d,r15d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       r14d,[rax+8]
       mov       rax,[rcx+10]
       mov       r15,[rax+10]
       mov       r13d,1
       cmp       r14d,1
       jle       short M00_L43
       test      r15,r15
       je        short M00_L37
       cmp       [r15+8],r14d
       jge       near ptr M00_L60
M00_L37:
       xor       eax,eax
       mov       [rbp-50],eax
       cmp       r13d,[r15+8]
       jae       short M00_L40
       mov       eax,r13d
       mov       r12,[r15+rax*8+10]
       test      r12,r12
       je        short M00_L39
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D6F8]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,r12
       call      qword ptr [7FF8A840E5F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       cmp       r13d,r14d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rbp-70]
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       dword ptr [r8+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       edx,[r8+8]
       jae       near ptr M00_L63
       add       ecx,[r8+rdx*4+10]
       jo        near ptr M00_L64
       add       edx,1
       jo        near ptr M00_L64
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       mov       r8d,[r8+8]
       movsxd    r10,edx
       cmp       r8,r10
       jg        short M00_L44
M00_L45:
       mov       edx,esi
       sub       edx,ecx
       jo        near ptr M00_L64
       or        edx,ecx
       jl        near ptr M00_L61
       xor       r14d,r14d
       mov       rcx,[rax+10]
       mov       r15,[rcx+8]
       mov       r13d,[r15+8]
       mov       r12d,r13d
       xor       r8d,r8d
       movsxd    rcx,r8d
       cmp       r12,rcx
       jg        short M00_L47
       jmp       near ptr M00_L65
M00_L46:
       mov       rcx,[rbp-68]
       add       ecx,1
       jo        near ptr M00_L64
       movsxd    rax,ecx
       cmp       r12,rax
       mov       r8,rcx
       jle       near ptr M00_L65
M00_L47:
       cmp       r8d,r13d
       jae       near ptr M00_L63
       mov       [rbp-68],r8
       mov       r10,[r15+r8*8+10]
       test      r10,r10
       je        short M00_L46
       mov       r9d,esi
       mov       [rbp-60],r9
M00_L48:
       movsxd    rcx,r14d
       cmp       rcx,r9
       jae       near ptr M00_L63
       lea       rcx,[rdi+rcx*8+10]
       mov       [rbp-78],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        near ptr M00_L64
       mov       rcx,[rbp-78]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-60]
       jne       short M00_L48
       jmp       short M00_L46
M00_L49:
       xor       eax,eax
       mov       [rbp-4C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L52
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L51
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L53
M00_L50:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D6F8]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       mov       rcx,r13
       call      qword ptr [7FF8A840E5F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L50
M00_L54:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r15d,1
       jo        near ptr M00_L64
       test      r15d,r15d
       jle       short M00_L49
       jmp       near ptr M00_L36
M00_L55:
       mov       eax,r13d
       mov       r12,[r15+rax*8+10]
       test      r12,r12
       je        short M00_L57
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L58
M00_L56:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L59
M00_L57:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D6F8]
       int       3
M00_L58:
       mov       rcx,r12
       call      qword ptr [7FF8A840E5F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L56
M00_L59:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        short M00_L64
       cmp       r13d,r14d
       jge       near ptr M00_L43
M00_L60:
       xor       eax,eax
       mov       [rbp-50],eax
       jmp       short M00_L55
M00_L61:
       call      qword ptr [7FF8A8406430]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FF8A840F780]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,66CF
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E47798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A7FA7D80]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L65:
       xor       esi,esi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L68
M00_L66:
       mov       rax,[rbp-70]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L73
       mov       edx,esi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L72
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       near ptr M00_L71
M00_L67:
       add       esi,1
       jo        near ptr M00_L74
       cmp       esi,[rbp-48]
       jl        short M00_L66
M00_L68:
       mov       [rbp-58],rdi
       mov       rsi,[rbx+88]
       mov       rdx,[rbp-58]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
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
M00_L69:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A840D7E8]
       jmp       near ptr M00_L29
M00_L70:
       call      qword ptr [7FF8A84064D8]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,301AEC06FB8
       mov       r8,301AEC06FB8
       call      qword ptr [7FF8A840CF30]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L71:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A840D7E8]
       jmp       near ptr M00_L67
M00_L72:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D6F8]
       int       3
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L75
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L76
       mov       [rbp-3C],ecx
M00_L75:
       add       rsp,28
       ret
M00_L76:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L77
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L78
       mov       [rbp-3C],ecx
M00_L77:
       add       rsp,28
       ret
M00_L78:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L79
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-3C],ecx
M00_L79:
       add       rsp,28
       ret
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L81
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L82
       mov       [rbp-3C],ecx
M00_L81:
       add       rsp,28
       ret
M00_L82:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L88
M00_L83:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L86
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L85
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L84
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A840D7E8]
M00_L84:
       add       edi,1
       jo        short M00_L87
       cmp       edi,[rbp-3C]
       jl        short M00_L83
       jmp       short M00_L88
M00_L85:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D6F8]
       int       3
M00_L86:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L87:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L88:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L89
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L90
       mov       [rbp-48],ecx
M00_L89:
       add       rsp,28
       ret
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L91
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-48],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L93
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-48],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L95
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-48],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-48]
       jge       short M00_L102
M00_L97:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       esi,[rax+8]
       jae       short M00_L100
       mov       edx,esi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L99
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L98
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A840D7E8]
M00_L98:
       add       esi,1
       jo        short M00_L101
       cmp       esi,[rbp-48]
       jl        short M00_L97
       jmp       short M00_L102
M00_L99:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D6F8]
       int       3
M00_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L102:
       add       rsp,28
       ret
; Total bytes of code 2218
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF8A7C68210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF9078AE370
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L01
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 154
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
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
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L14
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D680]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF8A840E5B0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L25
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D680]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF8A840E5B0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L17
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L16
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D680]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF8A840E5B0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
       nop
M00_L19:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L22
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D680]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF8A840E5B0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        short M00_L26
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L25:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L30
M00_L28:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       near ptr M00_L73
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L72
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       near ptr M00_L69
M00_L29:
       add       edi,1
       jo        near ptr M00_L74
       cmp       edi,[rbp-3C]
       jl        short M00_L28
M00_L30:
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rdi
       mov       esi,[rcx+8]
       mov       ecx,esi
       test      ecx,ecx
       jle       near ptr M00_L70
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       xor       r15d,r15d
       test      r14,r14
       je        near ptr M00_L49
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L49
M00_L31:
       xor       eax,eax
       mov       [rbp-4C],eax
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L33
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D680]
       int       3
M00_L34:
       mov       rcx,r13
       call      qword ptr [7FF8A840E5B0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r15d,1
       jo        near ptr M00_L64
       test      r15d,r15d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       r14d,[rax+8]
       mov       rax,[rcx+10]
       mov       r15,[rax+10]
       mov       r13d,1
       cmp       r14d,1
       jle       short M00_L43
       test      r15,r15
       je        short M00_L37
       cmp       [r15+8],r14d
       jge       near ptr M00_L60
M00_L37:
       xor       eax,eax
       mov       [rbp-50],eax
       cmp       r13d,[r15+8]
       jae       short M00_L40
       mov       eax,r13d
       mov       r12,[r15+rax*8+10]
       test      r12,r12
       je        short M00_L39
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D680]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,r12
       call      qword ptr [7FF8A840E5B0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       cmp       r13d,r14d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rbp-70]
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       dword ptr [r8+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       edx,[r8+8]
       jae       near ptr M00_L63
       add       ecx,[r8+rdx*4+10]
       jo        near ptr M00_L64
       add       edx,1
       jo        near ptr M00_L64
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       mov       r8d,[r8+8]
       movsxd    r10,edx
       cmp       r8,r10
       jg        short M00_L44
M00_L45:
       mov       edx,esi
       sub       edx,ecx
       jo        near ptr M00_L64
       or        edx,ecx
       jl        near ptr M00_L61
       xor       r14d,r14d
       mov       rcx,[rax+10]
       mov       r15,[rcx+8]
       mov       r13d,[r15+8]
       mov       r12d,r13d
       xor       r8d,r8d
       movsxd    rcx,r8d
       cmp       r12,rcx
       jg        short M00_L47
       jmp       near ptr M00_L65
M00_L46:
       mov       rcx,[rbp-68]
       add       ecx,1
       jo        near ptr M00_L64
       movsxd    rax,ecx
       cmp       r12,rax
       mov       r8,rcx
       jle       near ptr M00_L65
M00_L47:
       cmp       r8d,r13d
       jae       near ptr M00_L63
       mov       [rbp-68],r8
       mov       r10,[r15+r8*8+10]
       test      r10,r10
       je        short M00_L46
       mov       r9d,esi
       mov       [rbp-60],r9
M00_L48:
       movsxd    rcx,r14d
       cmp       rcx,r9
       jae       near ptr M00_L63
       lea       rcx,[rdi+rcx*8+10]
       mov       [rbp-78],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        near ptr M00_L64
       mov       rcx,[rbp-78]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-60]
       jne       short M00_L48
       jmp       short M00_L46
M00_L49:
       xor       eax,eax
       mov       [rbp-4C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L52
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L51
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L53
M00_L50:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D680]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       mov       rcx,r13
       call      qword ptr [7FF8A840E5B0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L50
M00_L54:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r15d,1
       jo        near ptr M00_L64
       test      r15d,r15d
       jle       short M00_L49
       jmp       near ptr M00_L36
M00_L55:
       mov       eax,r13d
       mov       r12,[r15+rax*8+10]
       test      r12,r12
       je        short M00_L57
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L58
M00_L56:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L59
M00_L57:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D680]
       int       3
M00_L58:
       mov       rcx,r12
       call      qword ptr [7FF8A840E5B0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L56
M00_L59:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        short M00_L64
       cmp       r13d,r14d
       jge       near ptr M00_L43
M00_L60:
       xor       eax,eax
       mov       [rbp-50],eax
       jmp       short M00_L55
M00_L61:
       call      qword ptr [7FF8A84064C0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FF8A840F708]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,66CF
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E47798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A7FA7D80]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L65:
       xor       esi,esi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L68
M00_L66:
       mov       rax,[rbp-70]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L73
       mov       edx,esi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L72
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       near ptr M00_L71
M00_L67:
       add       esi,1
       jo        near ptr M00_L74
       cmp       esi,[rbp-48]
       jl        short M00_L66
M00_L68:
       mov       [rbp-58],rdi
       mov       rsi,[rbx+88]
       mov       rdx,[rbp-58]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
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
M00_L69:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A840D770]
       jmp       near ptr M00_L29
M00_L70:
       call      qword ptr [7FF8A8406568]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2D3B20C6FB8
       mov       r8,2D3B20C6FB8
       call      qword ptr [7FF8A840CF30]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L71:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A840D770]
       jmp       near ptr M00_L67
M00_L72:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D680]
       int       3
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L75
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L76
       mov       [rbp-3C],ecx
M00_L75:
       add       rsp,28
       ret
M00_L76:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L77
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L78
       mov       [rbp-3C],ecx
M00_L77:
       add       rsp,28
       ret
M00_L78:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L79
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-3C],ecx
M00_L79:
       add       rsp,28
       ret
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L81
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L82
       mov       [rbp-3C],ecx
M00_L81:
       add       rsp,28
       ret
M00_L82:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L88
M00_L83:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L86
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L85
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L84
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A840D770]
M00_L84:
       add       edi,1
       jo        short M00_L87
       cmp       edi,[rbp-3C]
       jl        short M00_L83
       jmp       short M00_L88
M00_L85:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D680]
       int       3
M00_L86:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L87:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L88:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L89
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L90
       mov       [rbp-48],ecx
M00_L89:
       add       rsp,28
       ret
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L91
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-48],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L93
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-48],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L95
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-48],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-48]
       jge       short M00_L102
M00_L97:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       esi,[rax+8]
       jae       short M00_L100
       mov       edx,esi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L99
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L98
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A840D770]
M00_L98:
       add       esi,1
       jo        short M00_L101
       cmp       esi,[rbp-48]
       jl        short M00_L97
       jmp       short M00_L102
M00_L99:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D680]
       int       3
M00_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L102:
       add       rsp,28
       ret
; Total bytes of code 2212
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF8A7C68210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF9078AE370
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L01
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 154
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
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
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L14
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A830E520]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF8A83FE520]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L25
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A830E520]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF8A83FE520]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L17
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L16
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF8A830E520]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF8A83FE520]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
       nop
M00_L19:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L22
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF8A830E520]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF8A83FE520]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        short M00_L26
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L25:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L30
M00_L28:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       near ptr M00_L73
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L72
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       near ptr M00_L69
M00_L29:
       add       edi,1
       jo        near ptr M00_L74
       cmp       edi,[rbp-3C]
       jl        short M00_L28
M00_L30:
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rdi
       mov       esi,[rcx+8]
       mov       ecx,esi
       test      ecx,ecx
       jle       near ptr M00_L70
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       xor       r15d,r15d
       test      r14,r14
       je        near ptr M00_L51
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L51
M00_L31:
       xor       eax,eax
       mov       [rbp-4C],eax
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L33
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF8A830E520]
       int       3
M00_L34:
       mov       rcx,r13
       call      qword ptr [7FF8A83FE520]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r15d,1
       jo        near ptr M00_L64
       test      r15d,r15d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       r14d,[rax+8]
       mov       rax,[rcx+10]
       mov       r15,[rax+10]
       mov       r13d,1
       cmp       r14d,1
       jle       short M00_L43
       test      r15,r15
       je        short M00_L37
       cmp       [r15+8],r14d
       jge       near ptr M00_L50
M00_L37:
       xor       eax,eax
       mov       [rbp-50],eax
       cmp       r13d,[r15+8]
       jae       short M00_L40
       mov       eax,r13d
       mov       r12,[r15+rax*8+10]
       test      r12,r12
       je        short M00_L39
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF8A830E520]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,r12
       call      qword ptr [7FF8A83FE520]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       cmp       r13d,r14d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rbp-70]
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       dword ptr [r8+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       edx,[r8+8]
       jae       near ptr M00_L63
       add       ecx,[r8+rdx*4+10]
       jo        near ptr M00_L64
       add       edx,1
       jo        near ptr M00_L64
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       mov       r8d,[r8+8]
       movsxd    r10,edx
       cmp       r8,r10
       jg        short M00_L44
M00_L45:
       mov       edx,esi
       sub       edx,ecx
       jo        near ptr M00_L64
       or        edx,ecx
       jl        near ptr M00_L61
       xor       r14d,r14d
       mov       rcx,[rax+10]
       mov       r15,[rcx+8]
       mov       r13d,[r15+8]
       mov       r12d,r13d
       xor       r8d,r8d
       jmp       short M00_L47
M00_L46:
       mov       rcx,[rbp-68]
       add       ecx,1
       jo        near ptr M00_L64
       mov       r8,rcx
M00_L47:
       movsxd    rcx,r8d
       cmp       r12,rcx
       jle       near ptr M00_L65
       cmp       r8d,r13d
       jae       near ptr M00_L63
       mov       [rbp-68],r8
       mov       r10,[r15+r8*8+10]
       test      r10,r10
       je        short M00_L46
       mov       r9d,esi
       mov       [rbp-60],r9
M00_L48:
       movsxd    rcx,r14d
       cmp       rcx,r9
       jae       near ptr M00_L63
       lea       rcx,[rdi+rcx*8+10]
       mov       [rbp-78],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        near ptr M00_L64
       mov       rcx,[rbp-78]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-60]
       jne       short M00_L48
       jmp       short M00_L46
M00_L49:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       cmp       r13d,r14d
       jge       near ptr M00_L43
M00_L50:
       xor       eax,eax
       mov       [rbp-50],eax
       jmp       short M00_L57
M00_L51:
       xor       eax,eax
       mov       [rbp-4C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L54
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L53
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L55
M00_L52:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L56
M00_L53:
       xor       ecx,ecx
       call      qword ptr [7FF8A830E520]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       mov       rcx,r13
       call      qword ptr [7FF8A83FE520]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L52
M00_L56:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r15d,1
       jo        near ptr M00_L64
       test      r15d,r15d
       jle       short M00_L51
       jmp       near ptr M00_L36
M00_L57:
       mov       eax,r13d
       mov       r12,[r15+rax*8+10]
       test      r12,r12
       je        short M00_L59
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L60
M00_L58:
       mov       dword ptr [rbp-50],1
       jmp       near ptr M00_L49
M00_L59:
       xor       ecx,ecx
       call      qword ptr [7FF8A830E520]
       int       3
M00_L60:
       mov       rcx,r12
       call      qword ptr [7FF8A83FE520]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L58
M00_L61:
       call      qword ptr [7FF8A83FCEB8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FF8A84C44F8]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,66CF
       mov       rdx,7FF8A7EE4D10
       call      qword ptr [7FF8A7E27798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A7F87D80]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L65:
       xor       esi,esi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L68
M00_L66:
       mov       rax,[rbp-70]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L73
       mov       edx,esi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L72
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       near ptr M00_L71
M00_L67:
       add       esi,1
       jo        near ptr M00_L74
       cmp       esi,[rbp-48]
       jl        short M00_L66
M00_L68:
       mov       [rbp-58],rdi
       mov       rsi,[rbx+88]
       mov       rdx,[rbp-58]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
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
M00_L69:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A830E610]
       jmp       near ptr M00_L29
M00_L70:
       call      qword ptr [7FF8A83FCF60]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,15AFC506FB8
       mov       r8,15AFC506FB8
       call      qword ptr [7FF8A830DD58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L71:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A830E610]
       jmp       near ptr M00_L67
M00_L72:
       xor       ecx,ecx
       call      qword ptr [7FF8A830E520]
       int       3
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L75
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L76
       mov       [rbp-3C],ecx
M00_L75:
       add       rsp,28
       ret
M00_L76:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L77
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L78
       mov       [rbp-3C],ecx
M00_L77:
       add       rsp,28
       ret
M00_L78:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L79
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-3C],ecx
M00_L79:
       add       rsp,28
       ret
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L81
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L82
       mov       [rbp-3C],ecx
M00_L81:
       add       rsp,28
       ret
M00_L82:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L88
M00_L83:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L86
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L85
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L84
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A830E610]
M00_L84:
       add       edi,1
       jo        short M00_L87
       cmp       edi,[rbp-3C]
       jl        short M00_L83
       jmp       short M00_L88
M00_L85:
       xor       ecx,ecx
       call      qword ptr [7FF8A830E520]
       int       3
M00_L86:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L87:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L88:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L89
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L90
       mov       [rbp-48],ecx
M00_L89:
       add       rsp,28
       ret
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L91
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-48],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L93
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-48],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L95
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-48],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-48]
       jge       short M00_L102
M00_L97:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       esi,[rax+8]
       jae       short M00_L100
       mov       edx,esi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L99
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L98
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A830E610]
M00_L98:
       add       esi,1
       jo        short M00_L101
       cmp       esi,[rbp-48]
       jl        short M00_L97
       jmp       short M00_L102
M00_L99:
       xor       ecx,ecx
       call      qword ptr [7FF8A830E520]
       int       3
M00_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L102:
       add       rsp,28
       ret
; Total bytes of code 2212
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF8A7C48210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF9078AE370
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L01
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 154
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
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
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L14
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A83060E8]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF8A8307498]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L25
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A83060E8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF8A8307498]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L17
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L16
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF8A83060E8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF8A8307498]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
       nop
M00_L19:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L22
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF8A83060E8]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF8A8307498]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        short M00_L26
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L25:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L30
M00_L28:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       near ptr M00_L73
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L72
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       near ptr M00_L69
M00_L29:
       add       edi,1
       jo        near ptr M00_L74
       cmp       edi,[rbp-3C]
       jl        short M00_L28
M00_L30:
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rdi
       mov       esi,[rcx+8]
       mov       ecx,esi
       test      ecx,ecx
       jle       near ptr M00_L70
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       xor       r15d,r15d
       test      r14,r14
       je        near ptr M00_L49
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L49
M00_L31:
       xor       eax,eax
       mov       [rbp-4C],eax
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L33
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF8A83060E8]
       int       3
M00_L34:
       mov       rcx,r13
       call      qword ptr [7FF8A8307498]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r15d,1
       jo        near ptr M00_L64
       test      r15d,r15d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       r14d,[rax+8]
       mov       rax,[rcx+10]
       mov       r15,[rax+10]
       mov       r13d,1
       cmp       r14d,1
       jle       short M00_L43
       test      r15,r15
       je        short M00_L37
       cmp       [r15+8],r14d
       jge       near ptr M00_L60
M00_L37:
       xor       eax,eax
       mov       [rbp-50],eax
       cmp       r13d,[r15+8]
       jae       short M00_L40
       mov       eax,r13d
       mov       r12,[r15+rax*8+10]
       test      r12,r12
       je        short M00_L39
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF8A83060E8]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,r12
       call      qword ptr [7FF8A8307498]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       cmp       r13d,r14d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rbp-70]
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       dword ptr [r8+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       edx,[r8+8]
       jae       near ptr M00_L63
       add       ecx,[r8+rdx*4+10]
       jo        near ptr M00_L64
       add       edx,1
       jo        near ptr M00_L64
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       mov       r8d,[r8+8]
       movsxd    r10,edx
       cmp       r8,r10
       jg        short M00_L44
M00_L45:
       mov       edx,esi
       sub       edx,ecx
       jo        near ptr M00_L64
       or        edx,ecx
       jl        near ptr M00_L61
       xor       r14d,r14d
       mov       rcx,[rax+10]
       mov       r15,[rcx+8]
       mov       r13d,[r15+8]
       mov       r12d,r13d
       xor       r8d,r8d
       jmp       short M00_L47
M00_L46:
       mov       rcx,[rbp-68]
       add       ecx,1
       jo        near ptr M00_L64
       mov       r8,rcx
M00_L47:
       movsxd    rcx,r8d
       cmp       r12,rcx
       jle       near ptr M00_L65
       cmp       r8d,r13d
       jae       near ptr M00_L63
       mov       [rbp-68],r8
       mov       r10,[r15+r8*8+10]
       test      r10,r10
       je        short M00_L46
       mov       r9d,esi
       mov       [rbp-60],r9
M00_L48:
       movsxd    rcx,r14d
       cmp       rcx,r9
       jae       near ptr M00_L63
       lea       rcx,[rdi+rcx*8+10]
       mov       [rbp-78],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        near ptr M00_L64
       mov       rcx,[rbp-78]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-60]
       jne       short M00_L48
       jmp       short M00_L46
M00_L49:
       xor       eax,eax
       mov       [rbp-4C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L52
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L51
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L53
M00_L50:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF8A83060E8]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       mov       rcx,r13
       call      qword ptr [7FF8A8307498]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L50
M00_L54:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r15d,1
       jo        near ptr M00_L64
       test      r15d,r15d
       jle       short M00_L49
       jmp       near ptr M00_L36
M00_L55:
       mov       eax,r13d
       mov       r12,[r15+rax*8+10]
       test      r12,r12
       je        short M00_L57
       mov       rcx,r12
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L58
M00_L56:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L59
M00_L57:
       xor       ecx,ecx
       call      qword ptr [7FF8A83060E8]
       int       3
M00_L58:
       mov       rcx,r12
       call      qword ptr [7FF8A8307498]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L56
M00_L59:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        short M00_L64
       cmp       r13d,r14d
       jge       near ptr M00_L43
M00_L60:
       xor       eax,eax
       mov       [rbp-50],eax
       jmp       short M00_L55
M00_L61:
       call      qword ptr [7FF8A842E7F0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FF8A8544858]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,66CF
       mov       rdx,7FF8A7EE4D10
       call      qword ptr [7FF8A7E27798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A7F87D80]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L65:
       xor       esi,esi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L68
M00_L66:
       mov       rax,[rbp-70]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L73
       mov       edx,esi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L72
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       near ptr M00_L71
M00_L67:
       add       esi,1
       jo        near ptr M00_L74
       cmp       esi,[rbp-48]
       jl        short M00_L66
M00_L68:
       mov       [rbp-58],rdi
       mov       rsi,[rbx+88]
       mov       rdx,[rbp-58]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
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
M00_L69:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83061D8]
       jmp       near ptr M00_L29
M00_L70:
       call      qword ptr [7FF8A842E898]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,27575C16FB8
       mov       r8,27575C16FB8
       call      qword ptr [7FF8A8305A70]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L71:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83061D8]
       jmp       near ptr M00_L67
M00_L72:
       xor       ecx,ecx
       call      qword ptr [7FF8A83060E8]
       int       3
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L75
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L76
       mov       [rbp-3C],ecx
M00_L75:
       add       rsp,28
       ret
M00_L76:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L77
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L78
       mov       [rbp-3C],ecx
M00_L77:
       add       rsp,28
       ret
M00_L78:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L79
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-3C],ecx
M00_L79:
       add       rsp,28
       ret
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L81
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L82
       mov       [rbp-3C],ecx
M00_L81:
       add       rsp,28
       ret
M00_L82:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L88
M00_L83:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L86
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L85
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L84
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83061D8]
M00_L84:
       add       edi,1
       jo        short M00_L87
       cmp       edi,[rbp-3C]
       jl        short M00_L83
       jmp       short M00_L88
M00_L85:
       xor       ecx,ecx
       call      qword ptr [7FF8A83060E8]
       int       3
M00_L86:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L87:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L88:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L89
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L90
       mov       [rbp-48],ecx
M00_L89:
       add       rsp,28
       ret
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L91
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-48],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L93
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-48],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L95
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-48],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-48]
       jge       short M00_L102
M00_L97:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       esi,[rax+8]
       jae       short M00_L100
       mov       edx,esi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L99
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L98
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83061D8]
M00_L98:
       add       esi,1
       jo        short M00_L101
       cmp       esi,[rbp-48]
       jl        short M00_L97
       jmp       short M00_L102
M00_L99:
       xor       ecx,ecx
       call      qword ptr [7FF8A83060E8]
       int       3
M00_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L102:
       add       rsp,28
       ret
; Total bytes of code 2201
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L14
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-38],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD338]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF8A83DE268]
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L25
M00_L06:
       xor       eax,eax
       mov       [rbp-3C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD338]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF8A83DE268]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       eax,eax
       mov       [rbp-38],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L17
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L16
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD338]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF8A83DE268]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L22
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD338]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF8A83DE268]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        short M00_L26
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L25:
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+88]
       mov       [rcx+38],esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83DD428]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD338]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L35
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-34],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L37
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-34],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L39
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-34],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L41
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-34],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83DD428]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD338]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 906
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L14
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-38],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DCD98]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF8A83D6778]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L25
M00_L06:
       xor       eax,eax
       mov       [rbp-3C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DCD98]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF8A83D6778]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       eax,eax
       mov       [rbp-38],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L17
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L16
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DCD98]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF8A83D6778]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L22
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DCD98]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF8A83D6778]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        short M00_L26
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L25:
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+88]
       mov       [rcx+38],esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83DCEB8]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DCD98]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L35
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-34],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L37
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-34],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L39
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-34],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L41
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-34],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83DCEB8]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DCD98]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 906
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L16
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L16
M00_L00:
       xor       eax,eax
       mov       [rbp-38],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED308]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF8A83EE208]
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L15
M00_L06:
       xor       eax,eax
       mov       [rbp-3C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED308]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF8A83EE208]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jge       short M00_L12
M00_L15:
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       short M00_L22
M00_L16:
       xor       eax,eax
       mov       [rbp-38],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L19
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L18
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED308]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r15
       call      qword ptr [7FF8A83EE208]
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L24
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-3C],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED308]
       int       3
M00_L25:
       mov       rcx,r13
       call      qword ptr [7FF8A83EE208]
       jmp       short M00_L23
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+88]
       mov       [rcx+38],esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83ED3F8]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED308]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L35
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-34],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L37
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-34],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L39
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-34],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L41
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-34],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83ED3F8]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED308]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 913
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L16
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L16
M00_L00:
       xor       eax,eax
       mov       [rbp-38],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D368]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF8A8406D00]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L15
M00_L06:
       xor       eax,eax
       mov       [rbp-3C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D368]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF8A8406D00]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jge       short M00_L12
M00_L15:
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       short M00_L22
M00_L16:
       xor       eax,eax
       mov       [rbp-38],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L19
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L18
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D368]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r15
       call      qword ptr [7FF8A8406D00]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L24
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-3C],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D368]
       int       3
M00_L25:
       mov       rcx,r13
       call      qword ptr [7FF8A8406D00]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L23
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+88]
       mov       [rcx+38],esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A840D458]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D368]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L35
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-34],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L37
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-34],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L39
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-34],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L41
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-34],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A840D458]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D368]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 913
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L16
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L16
M00_L00:
       xor       eax,eax
       mov       [rbp-38],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A841D350]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF8A841E1F0]
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L15
M00_L06:
       xor       eax,eax
       mov       [rbp-3C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A841D350]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF8A841E1F0]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jge       short M00_L12
M00_L15:
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       short M00_L22
M00_L16:
       xor       eax,eax
       mov       [rbp-38],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L19
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L18
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF8A841D350]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r15
       call      qword ptr [7FF8A841E1F0]
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L24
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-3C],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF8A841D350]
       int       3
M00_L25:
       mov       rcx,r13
       call      qword ptr [7FF8A841E1F0]
       jmp       short M00_L23
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+88]
       mov       [rcx+38],esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A841D440]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF8A841D350]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L35
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-34],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L37
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-34],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L39
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-34],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L41
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-34],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A841D440]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF8A841D350]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 913
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L14
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-38],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED368]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF8A83EE298]
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L25
M00_L06:
       xor       eax,eax
       mov       [rbp-3C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED368]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF8A83EE298]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       eax,eax
       mov       [rbp-38],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L17
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L16
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED368]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF8A83EE298]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L22
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED368]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF8A83EE298]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        short M00_L26
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L25:
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+88]
       mov       [rcx+38],esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83ED458]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED368]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L35
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-34],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L37
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-34],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L39
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-34],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L41
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-34],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83ED458]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED368]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 906
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L14
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-38],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D398]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF8A840CAB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L25
M00_L06:
       xor       eax,eax
       mov       [rbp-3C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D398]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF8A840CAB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       eax,eax
       mov       [rbp-38],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L17
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L16
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D398]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF8A840CAB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L22
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D398]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF8A840CAB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        short M00_L26
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L25:
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+88]
       mov       [rcx+38],esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A840D488]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D398]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L35
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-34],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L37
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-34],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L39
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-34],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L41
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-34],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A840D488]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D398]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 906
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L14
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-38],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A82F60B8]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF8A82F73F0]
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L25
M00_L06:
       xor       eax,eax
       mov       [rbp-3C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A82F60B8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF8A82F73F0]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       eax,eax
       mov       [rbp-38],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L17
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L16
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF8A82F60B8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF8A82F73F0]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L22
       mov       rcx,r13
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF8A82F60B8]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF8A82F73F0]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        short M00_L26
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L25:
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+88]
       mov       [rcx+38],esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A82F61A8]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF8A82F60B8]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L35
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-34],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L37
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-34],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L39
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-34],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L41
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-34],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A82F61A8]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF8A82F60B8]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 906
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2D8]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D308]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF8A840E238]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D308]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF8A840E238]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L17
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L16
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D308]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FF8A840E238]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L22
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D308]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FF8A840E238]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L28
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+88]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF8A840D3F8]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D308]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF8A840D3F8]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D308]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 923
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2D8]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L16
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L16
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED338]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF8A83EE268]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED338]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF8A83EE268]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jge       short M00_L12
M00_L15:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L22
M00_L16:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L19
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L18
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED338]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r14
       call      qword ptr [7FF8A83EE268]
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L24
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED338]
       int       3
M00_L25:
       mov       rcx,r15
       call      qword ptr [7FF8A83EE268]
       jmp       short M00_L23
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+88]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF8A83ED428]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED338]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF8A83ED428]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED338]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 930
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2D8]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED338]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF8A83E68B0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED338]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF8A83E68B0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L17
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L16
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED338]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FF8A83E68B0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L22
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED338]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FF8A83E68B0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L28
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+88]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF8A83ED428]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED338]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF8A83ED428]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED338]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 923
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2D8]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD338]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF8A83FE238]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD338]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF8A83FE238]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L17
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L16
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD338]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FF8A83FE238]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L22
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD338]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FF8A83FE238]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L28
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+88]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF8A83FD428]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD338]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF8A83FD428]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD338]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 923
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2D8]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A841D338]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF8A841E238]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A841D338]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF8A841E238]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L17
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L16
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF8A841D338]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FF8A841E238]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L22
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF8A841D338]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FF8A841E238]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L28
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+88]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF8A841D428]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF8A841D338]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF8A841D428]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF8A841D338]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 923
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2D8]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L16
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L16
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED338]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF8A83E68B0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED338]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF8A83E68B0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jge       short M00_L12
M00_L15:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L22
M00_L16:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L19
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L18
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED338]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r14
       call      qword ptr [7FF8A83E68B0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L24
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED338]
       int       3
M00_L25:
       mov       rcx,r15
       call      qword ptr [7FF8A83E68B0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L23
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+88]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF8A83ED428]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED338]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF8A83ED428]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED338]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 930
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2D8]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A833E520]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF8A842E160]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A833E520]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF8A842E160]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L17
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L16
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF8A833E520]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FF8A842E160]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L22
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF8A833E520]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FF8A842E160]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L28
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+88]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF8A833E610]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF8A833E520]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF8A833E610]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF8A833E520]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 923
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+2D8]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A8316118]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF8A8317498]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A8316118]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF8A8317498]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L17
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L16
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF8A8316118]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FF8A8317498]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L22
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF8A8316118]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FF8A8317498]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L28
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+88]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF8A8316208]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF8A8316118]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF8A8316208]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF8A8316118]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 923
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.ToArray()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-60],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L16
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L16
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A841D4A0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF8A841E3D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L34
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-60]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L27
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A841D4A0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF8A841E3D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L34
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       edx,edx
       xor       ecx,ecx
       mov       rax,[rbp-60]
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       dword ptr [r8+8],0
       je        short M00_L14
M00_L13:
       mov       rax,[rbp-60]
       test      edx,edx
       jl        short M00_L14
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       ecx,[r8+8]
       jae       near ptr M00_L33
       add       edx,[r8+rcx*4+10]
       jo        near ptr M00_L34
       add       ecx,1
       jo        near ptr M00_L34
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       mov       r8d,[r8+8]
       movsxd    r10,ecx
       cmp       r8,r10
       jg        short M00_L13
M00_L14:
       test      edx,edx
       je        near ptr M00_L31
       movsxd    rdx,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       xor       edi,edi
       mov       rax,[rbp-60]
       mov       rcx,[rax+10]
       mov       r14,[rcx+8]
       xor       r15d,r15d
       mov       r13d,[r14+8]
       mov       r12d,r13d
       test      r12,r12
       jg        near ptr M00_L29
M00_L15:
       jmp       near ptr M00_L35
M00_L16:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L19
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L18
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF8A841D4A0]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r14
       call      qword ptr [7FF8A841E3D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L34
       test      edi,edi
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L24
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L26
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF8A841D4A0]
       int       3
M00_L25:
       mov       rcx,r15
       call      qword ptr [7FF8A841E3D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L23
M00_L26:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L34
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L27:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L22
M00_L28:
       add       r15d,1
       jo        near ptr M00_L34
       movsxd    rcx,r15d
       cmp       r12,rcx
       jle       near ptr M00_L15
M00_L29:
       cmp       r15d,r13d
       jae       short M00_L33
       mov       r8,[r14+r15*8+10]
       test      r8,r8
       je        short M00_L28
       mov       r10d,[rsi+8]
       mov       [rbp-58],r10
M00_L30:
       movsxd    rcx,edi
       cmp       rcx,r10
       jae       short M00_L33
       lea       rcx,[rsi+rcx*8+10]
       mov       [rbp-68],r8
       mov       rdx,[r8+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       edi,1
       jo        short M00_L34
       mov       rcx,[rbp-68]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r8,rcx
       mov       r10,[rbp-58]
       jne       short M00_L30
       jmp       short M00_L28
M00_L31:
       test      byte ptr [7FF8A84D3648],1
       jne       short M00_L32
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF8A7C35728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M00_L32:
       mov       rcx,18549000AC0
       mov       rsi,[rcx]
       jmp       short M00_L35
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L35:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L38
M00_L36:
       mov       rax,[rbp-60]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L41
       mov       edx,edi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L40
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L39
M00_L37:
       add       edi,1
       jo        short M00_L42
       cmp       edi,[rbp-3C]
       jl        short M00_L36
M00_L38:
       mov       [rbp-50],rsi
       mov       rdi,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L39:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A841D590]
       jmp       short M00_L37
M00_L40:
       xor       ecx,ecx
       call      qword ptr [7FF8A841D4A0]
       int       3
M00_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L43
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L44
       mov       [rbp-3C],ecx
M00_L43:
       add       rsp,28
       ret
M00_L44:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L45
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L46
       mov       [rbp-3C],ecx
M00_L45:
       add       rsp,28
       ret
M00_L46:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L47
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L48
       mov       [rbp-3C],ecx
M00_L47:
       add       rsp,28
       ret
M00_L48:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L49
       mov       edx,[rbp-3C]
       add       edx,1
       jo        short M00_L50
       mov       [rbp-3C],edx
M00_L49:
       add       rsp,28
       ret
M00_L50:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L56
M00_L51:
       mov       rcx,[rbp-60]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L54
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L53
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A841D590]
M00_L52:
       add       edi,1
       jo        short M00_L55
       cmp       edi,[rbp-3C]
       jl        short M00_L51
       jmp       short M00_L56
M00_L53:
       xor       ecx,ecx
       call      qword ptr [7FF8A841D4A0]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L56:
       add       rsp,28
       ret
; Total bytes of code 1187
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF8A7C78210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF9078AE370
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L01
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 154
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
       jmp       qword ptr [7FF8A7C35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.ToArray()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-60],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L19
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A83F79C0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF8A83F7A08]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L34
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-60]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L30
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A83F79C0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF8A83F7A08]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L34
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       edx,edx
       xor       ecx,ecx
       mov       rax,[rbp-60]
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       dword ptr [r8+8],0
       je        short M00_L14
M00_L13:
       mov       rax,[rbp-60]
       test      edx,edx
       jl        short M00_L14
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       ecx,[r8+8]
       jae       near ptr M00_L33
       add       edx,[r8+rcx*4+10]
       jo        near ptr M00_L34
       add       ecx,1
       jo        near ptr M00_L34
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       mov       r8d,[r8+8]
       movsxd    r10,ecx
       cmp       r8,r10
       jg        short M00_L13
M00_L14:
       test      edx,edx
       je        near ptr M00_L31
       movsxd    rdx,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       xor       edi,edi
       mov       rax,[rbp-60]
       mov       rcx,[rax+10]
       mov       r14,[rcx+8]
       xor       r15d,r15d
       mov       r13d,[r14+8]
       mov       r12d,r13d
       test      r12,r12
       jg        short M00_L17
M00_L15:
       jmp       near ptr M00_L35
M00_L16:
       add       r15d,1
       jo        near ptr M00_L34
       movsxd    rcx,r15d
       cmp       r12,rcx
       jle       short M00_L15
M00_L17:
       cmp       r15d,r13d
       jae       near ptr M00_L33
       mov       r8,[r14+r15*8+10]
       test      r8,r8
       je        short M00_L16
       mov       r10d,[rsi+8]
       mov       [rbp-58],r10
M00_L18:
       movsxd    rcx,edi
       cmp       rcx,r10
       jae       near ptr M00_L33
       lea       rcx,[rsi+rcx*8+10]
       mov       [rbp-68],r8
       mov       rdx,[r8+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       edi,1
       jo        near ptr M00_L34
       mov       rcx,[rbp-68]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r8,rcx
       mov       r10,[rbp-58]
       jne       short M00_L18
       jmp       short M00_L16
M00_L19:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L22
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L21
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FF8A83F79C0]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF8A83F7A08]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L20
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L34
       test      edi,edi
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FF8A83F79C0]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FF8A83F7A08]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L34
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        short M00_L34
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L30:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L25
M00_L31:
       test      byte ptr [7FF8A83D5D48],1
       jne       short M00_L32
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF8A7C15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M00_L32:
       mov       rcx,1F4D1C00A40
       mov       rsi,[rcx]
       jmp       short M00_L35
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L35:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L38
M00_L36:
       mov       rax,[rbp-60]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L41
       mov       edx,edi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L40
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L39
M00_L37:
       add       edi,1
       jo        short M00_L42
       cmp       edi,[rbp-3C]
       jl        short M00_L36
M00_L38:
       mov       [rbp-50],rsi
       mov       rdi,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L39:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83F79D8]
       jmp       short M00_L37
M00_L40:
       xor       ecx,ecx
       call      qword ptr [7FF8A83F79C0]
       int       3
M00_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L43
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L44
       mov       [rbp-3C],ecx
M00_L43:
       add       rsp,28
       ret
M00_L44:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L45
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L46
       mov       [rbp-3C],ecx
M00_L45:
       add       rsp,28
       ret
M00_L46:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L47
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L48
       mov       [rbp-3C],ecx
M00_L47:
       add       rsp,28
       ret
M00_L48:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L49
       mov       edx,[rbp-3C]
       add       edx,1
       jo        short M00_L50
       mov       [rbp-3C],edx
M00_L49:
       add       rsp,28
       ret
M00_L50:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L56
M00_L51:
       mov       rcx,[rbp-60]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L54
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L53
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83F79D8]
M00_L52:
       add       edi,1
       jo        short M00_L55
       cmp       edi,[rbp-3C]
       jl        short M00_L51
       jmp       short M00_L56
M00_L53:
       xor       ecx,ecx
       call      qword ptr [7FF8A83F79C0]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L56:
       add       rsp,28
       ret
; Total bytes of code 1183
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF8A7C58210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF9078AE370
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L01
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 154
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
       jmp       qword ptr [7FF8A7C15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.ToArray()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-60],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L25
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L25
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD4B8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF8A83DE388]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L34
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-60]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD4B8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF8A83DE388]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L34
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       edx,edx
       xor       ecx,ecx
       mov       rax,[rbp-60]
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       dword ptr [r8+8],0
       je        short M00_L14
M00_L13:
       mov       rax,[rbp-60]
       test      edx,edx
       jl        short M00_L14
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       ecx,[r8+8]
       jae       near ptr M00_L33
       add       edx,[r8+rcx*4+10]
       jo        near ptr M00_L34
       add       ecx,1
       jo        near ptr M00_L34
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       mov       r8d,[r8+8]
       movsxd    r10,ecx
       cmp       r8,r10
       jg        short M00_L13
M00_L14:
       test      edx,edx
       je        near ptr M00_L31
       movsxd    rdx,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       xor       edi,edi
       mov       rax,[rbp-60]
       mov       rcx,[rax+10]
       mov       r14,[rcx+8]
       xor       r15d,r15d
       mov       r13d,[r14+8]
       mov       r12d,r13d
       test      r12,r12
       jg        short M00_L17
M00_L15:
       jmp       near ptr M00_L35
M00_L16:
       add       r15d,1
       jo        near ptr M00_L34
       movsxd    rcx,r15d
       cmp       r12,rcx
       jle       short M00_L15
M00_L17:
       cmp       r15d,r13d
       jae       near ptr M00_L33
       mov       r8,[r14+r15*8+10]
       test      r8,r8
       je        short M00_L16
       mov       r10d,[rsi+8]
       mov       [rbp-58],r10
M00_L18:
       movsxd    rcx,edi
       cmp       rcx,r10
       jae       near ptr M00_L33
       lea       rcx,[rsi+rcx*8+10]
       mov       [rbp-68],r8
       mov       rdx,[r8+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       edi,1
       jo        near ptr M00_L34
       mov       rcx,[rbp-68]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r8,rcx
       mov       r10,[rbp-58]
       jne       short M00_L18
       jmp       short M00_L16
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD4B8]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FF8A83DE388]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L34
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L19
M00_L25:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L28
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L27
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L29
M00_L26:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L30
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD4B8]
       int       3
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L29:
       mov       rcx,r14
       call      qword ptr [7FF8A83DE388]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L26
M00_L30:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L34
       mov       [rbp-3C],ecx
       add       edi,1
       jo        short M00_L34
       test      edi,edi
       jle       short M00_L25
       jmp       near ptr M00_L05
M00_L31:
       test      byte ptr [7FF8A8493700],1
       jne       short M00_L32
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF8A7BF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M00_L32:
       mov       rcx,2A9F6400AC0
       mov       rsi,[rcx]
       jmp       short M00_L35
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L35:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L38
M00_L36:
       mov       rax,[rbp-60]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L41
       mov       edx,edi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L40
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L39
M00_L37:
       add       edi,1
       jo        short M00_L42
       cmp       edi,[rbp-3C]
       jl        short M00_L36
M00_L38:
       mov       [rbp-50],rsi
       mov       rdi,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L39:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83DD5A8]
       jmp       short M00_L37
M00_L40:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD4B8]
       int       3
M00_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L43
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L44
       mov       [rbp-3C],ecx
M00_L43:
       add       rsp,28
       ret
M00_L44:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L45
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L46
       mov       [rbp-3C],ecx
M00_L45:
       add       rsp,28
       ret
M00_L46:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L47
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L48
       mov       [rbp-3C],ecx
M00_L47:
       add       rsp,28
       ret
M00_L48:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L49
       mov       edx,[rbp-3C]
       add       edx,1
       jo        short M00_L50
       mov       [rbp-3C],edx
M00_L49:
       add       rsp,28
       ret
M00_L50:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L56
M00_L51:
       mov       rcx,[rbp-60]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L54
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L53
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83DD5A8]
M00_L52:
       add       edi,1
       jo        short M00_L55
       cmp       edi,[rbp-3C]
       jl        short M00_L51
       jmp       short M00_L56
M00_L53:
       xor       ecx,ecx
       call      qword ptr [7FF8A83DD4B8]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L56:
       add       rsp,28
       ret
; Total bytes of code 1183
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF8A7C38210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF9078AE370
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L01
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 154
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
       jmp       qword ptr [7FF8A7BF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.ToArray()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-60],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L19
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D4B8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF8A840E358]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L33
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L33
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-60]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L30
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D4B8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF8A840E358]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L33
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L33
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       edx,edx
       xor       ecx,ecx
       mov       rax,[rbp-60]
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       dword ptr [r8+8],0
       je        short M00_L14
M00_L13:
       mov       rax,[rbp-60]
       test      edx,edx
       jl        short M00_L14
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       ecx,[r8+8]
       jae       near ptr M00_L32
       add       edx,[r8+rcx*4+10]
       jo        near ptr M00_L33
       add       ecx,1
       jo        near ptr M00_L33
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       mov       r8d,[r8+8]
       movsxd    r10,ecx
       cmp       r8,r10
       jg        short M00_L13
M00_L14:
       test      edx,edx
       je        near ptr M00_L31
       movsxd    rdx,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       xor       edi,edi
       mov       rax,[rbp-60]
       mov       rcx,[rax+10]
       mov       r14,[rcx+8]
       xor       r15d,r15d
       mov       r13d,[r14+8]
       mov       r12d,r13d
       test      r12,r12
       jle       short M00_L18
M00_L15:
       cmp       r15d,r13d
       jae       near ptr M00_L32
       mov       r8,[r14+r15*8+10]
       test      r8,r8
       je        short M00_L17
       mov       r10d,[rsi+8]
       mov       [rbp-58],r10
       nop       dword ptr [rax]
M00_L16:
       movsxd    rcx,edi
       cmp       rcx,r10
       jae       near ptr M00_L32
       lea       rcx,[rsi+rcx*8+10]
       mov       [rbp-68],r8
       mov       rdx,[r8+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       edi,1
       jo        near ptr M00_L33
       mov       rcx,[rbp-68]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r8,rcx
       mov       r10,[rbp-58]
       jne       short M00_L16
M00_L17:
       add       r15d,1
       jo        near ptr M00_L33
       movsxd    rcx,r15d
       cmp       r12,rcx
       jg        short M00_L15
M00_L18:
       jmp       near ptr M00_L34
M00_L19:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L22
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L21
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D4B8]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF8A840E358]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L20
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L33
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L33
       test      edi,edi
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D4B8]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FF8A840E358]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L33
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        short M00_L33
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L30:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L25
M00_L31:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF8A7C25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25699C00AC0
       mov       rsi,[rcx]
       jmp       short M00_L34
M00_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L33:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L34:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L37
M00_L35:
       mov       rax,[rbp-60]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L40
       mov       edx,edi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L39
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L38
M00_L36:
       add       edi,1
       jo        short M00_L41
       cmp       edi,[rbp-3C]
       jl        short M00_L35
M00_L37:
       mov       [rbp-50],rsi
       mov       rdi,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L38:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A840D5A8]
       jmp       short M00_L36
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D4B8]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L42
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-3C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L44
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-3C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L46
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-3C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L48
       mov       edx,[rbp-3C]
       add       edx,1
       jo        short M00_L49
       mov       [rbp-3C],edx
M00_L48:
       add       rsp,28
       ret
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L55
M00_L50:
       mov       rcx,[rbp-60]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L53
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L52
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L51
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A840D5A8]
M00_L51:
       add       edi,1
       jo        short M00_L54
       cmp       edi,[rbp-3C]
       jl        short M00_L50
       jmp       short M00_L55
M00_L52:
       xor       ecx,ecx
       call      qword ptr [7FF8A840D4B8]
       int       3
M00_L53:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L54:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L55:
       add       rsp,28
       ret
; Total bytes of code 1179
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
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
       jmp       qword ptr [7FF8A7C25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.ToArray()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-60],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L19
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED4D0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF8A83EE370]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L34
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-60]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L30
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED4D0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF8A83EE370]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L34
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       edx,edx
       xor       ecx,ecx
       mov       rax,[rbp-60]
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       dword ptr [r8+8],0
       je        short M00_L14
M00_L13:
       mov       rax,[rbp-60]
       test      edx,edx
       jl        short M00_L14
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       ecx,[r8+8]
       jae       near ptr M00_L33
       add       edx,[r8+rcx*4+10]
       jo        near ptr M00_L34
       add       ecx,1
       jo        near ptr M00_L34
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       mov       r8d,[r8+8]
       movsxd    r10,ecx
       cmp       r8,r10
       jg        short M00_L13
M00_L14:
       test      edx,edx
       je        near ptr M00_L31
       movsxd    rdx,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       xor       edi,edi
       mov       rax,[rbp-60]
       mov       rcx,[rax+10]
       mov       r14,[rcx+8]
       xor       r15d,r15d
       mov       r13d,[r14+8]
       mov       r12d,r13d
       test      r12,r12
       jg        short M00_L17
M00_L15:
       jmp       near ptr M00_L35
M00_L16:
       add       r15d,1
       jo        near ptr M00_L34
       movsxd    rcx,r15d
       cmp       r12,rcx
       jle       short M00_L15
M00_L17:
       cmp       r15d,r13d
       jae       near ptr M00_L33
       mov       r8,[r14+r15*8+10]
       test      r8,r8
       je        short M00_L16
       mov       r10d,[rsi+8]
       mov       [rbp-58],r10
M00_L18:
       movsxd    rcx,edi
       cmp       rcx,r10
       jae       near ptr M00_L33
       lea       rcx,[rsi+rcx*8+10]
       mov       [rbp-68],r8
       mov       rdx,[r8+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       edi,1
       jo        near ptr M00_L34
       mov       rcx,[rbp-68]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r8,rcx
       mov       r10,[rbp-58]
       jne       short M00_L18
       jmp       short M00_L16
M00_L19:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L22
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L21
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED4D0]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF8A83EE370]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L20
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L34
       test      edi,edi
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED4D0]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FF8A83EE370]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L34
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        short M00_L34
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L30:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L25
M00_L31:
       test      byte ptr [7FF8A84966B8],1
       jne       short M00_L32
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF8A7C05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M00_L32:
       mov       rcx,2016EC00AC0
       mov       rsi,[rcx]
       jmp       short M00_L35
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L35:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L38
M00_L36:
       mov       rax,[rbp-60]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L41
       mov       edx,edi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L40
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L39
M00_L37:
       add       edi,1
       jo        short M00_L42
       cmp       edi,[rbp-3C]
       jl        short M00_L36
M00_L38:
       mov       [rbp-50],rsi
       mov       rdi,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L39:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83ED5C0]
       jmp       short M00_L37
M00_L40:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED4D0]
       int       3
M00_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L43
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L44
       mov       [rbp-3C],ecx
M00_L43:
       add       rsp,28
       ret
M00_L44:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L45
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L46
       mov       [rbp-3C],ecx
M00_L45:
       add       rsp,28
       ret
M00_L46:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L47
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L48
       mov       [rbp-3C],ecx
M00_L47:
       add       rsp,28
       ret
M00_L48:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L49
       mov       edx,[rbp-3C]
       add       edx,1
       jo        short M00_L50
       mov       [rbp-3C],edx
M00_L49:
       add       rsp,28
       ret
M00_L50:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L56
M00_L51:
       mov       rcx,[rbp-60]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L54
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L53
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83ED5C0]
M00_L52:
       add       edi,1
       jo        short M00_L55
       cmp       edi,[rbp-3C]
       jl        short M00_L51
       jmp       short M00_L56
M00_L53:
       xor       ecx,ecx
       call      qword ptr [7FF8A83ED4D0]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L56:
       add       rsp,28
       ret
; Total bytes of code 1183
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
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
       jmp       qword ptr [7FF8A7C05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.ToArray()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-60],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L19
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD4D0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF8A83FE3D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L34
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-60]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L30
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD4D0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF8A83FE3D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L34
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       edx,edx
       xor       ecx,ecx
       mov       rax,[rbp-60]
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       dword ptr [r8+8],0
       je        short M00_L14
M00_L13:
       mov       rax,[rbp-60]
       test      edx,edx
       jl        short M00_L14
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       ecx,[r8+8]
       jae       near ptr M00_L33
       add       edx,[r8+rcx*4+10]
       jo        near ptr M00_L34
       add       ecx,1
       jo        near ptr M00_L34
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       mov       r8d,[r8+8]
       movsxd    r10,ecx
       cmp       r8,r10
       jg        short M00_L13
M00_L14:
       test      edx,edx
       je        near ptr M00_L31
       movsxd    rdx,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       xor       edi,edi
       mov       rax,[rbp-60]
       mov       rcx,[rax+10]
       mov       r14,[rcx+8]
       xor       r15d,r15d
       mov       r13d,[r14+8]
       mov       r12d,r13d
       test      r12,r12
       jg        short M00_L17
M00_L15:
       jmp       near ptr M00_L35
M00_L16:
       add       r15d,1
       jo        near ptr M00_L34
       movsxd    rcx,r15d
       cmp       r12,rcx
       jle       short M00_L15
M00_L17:
       cmp       r15d,r13d
       jae       near ptr M00_L33
       mov       r8,[r14+r15*8+10]
       test      r8,r8
       je        short M00_L16
       mov       r10d,[rsi+8]
       mov       [rbp-58],r10
M00_L18:
       movsxd    rcx,edi
       cmp       rcx,r10
       jae       near ptr M00_L33
       lea       rcx,[rsi+rcx*8+10]
       mov       [rbp-68],r8
       mov       rdx,[r8+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       edi,1
       jo        near ptr M00_L34
       mov       rcx,[rbp-68]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r8,rcx
       mov       r10,[rbp-58]
       jne       short M00_L18
       jmp       short M00_L16
M00_L19:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L22
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L21
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD4D0]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF8A83FE3D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L20
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L34
       test      edi,edi
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD4D0]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FF8A83FE3D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L34
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        short M00_L34
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L30:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L25
M00_L31:
       test      byte ptr [7FF8A84A66B0],1
       jne       short M00_L32
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF8A7C15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M00_L32:
       mov       rcx,1D4A8000AC0
       mov       rsi,[rcx]
       jmp       short M00_L35
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L35:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L38
M00_L36:
       mov       rax,[rbp-60]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L41
       mov       edx,edi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L40
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L39
M00_L37:
       add       edi,1
       jo        short M00_L42
       cmp       edi,[rbp-3C]
       jl        short M00_L36
M00_L38:
       mov       [rbp-50],rsi
       mov       rdi,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L39:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83FD5C0]
       jmp       short M00_L37
M00_L40:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD4D0]
       int       3
M00_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L43
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L44
       mov       [rbp-3C],ecx
M00_L43:
       add       rsp,28
       ret
M00_L44:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L45
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L46
       mov       [rbp-3C],ecx
M00_L45:
       add       rsp,28
       ret
M00_L46:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L47
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L48
       mov       [rbp-3C],ecx
M00_L47:
       add       rsp,28
       ret
M00_L48:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L49
       mov       edx,[rbp-3C]
       add       edx,1
       jo        short M00_L50
       mov       [rbp-3C],edx
M00_L49:
       add       rsp,28
       ret
M00_L50:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L56
M00_L51:
       mov       rcx,[rbp-60]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L54
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L53
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83FD5C0]
M00_L52:
       add       edi,1
       jo        short M00_L55
       cmp       edi,[rbp-3C]
       jl        short M00_L51
       jmp       short M00_L56
M00_L53:
       xor       ecx,ecx
       call      qword ptr [7FF8A83FD4D0]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L56:
       add       rsp,28
       ret
; Total bytes of code 1183
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF8A7C58210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF9078AE370
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L01
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 154
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
       jmp       qword ptr [7FF8A7C15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.ToArray()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-60],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L19
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A830F4C8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF8A840E328]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L34
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-60]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L30
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A830F4C8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF8A840E328]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L34
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       edx,edx
       xor       ecx,ecx
       mov       rax,[rbp-60]
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       dword ptr [r8+8],0
       je        short M00_L14
M00_L13:
       mov       rax,[rbp-60]
       test      edx,edx
       jl        short M00_L14
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       ecx,[r8+8]
       jae       near ptr M00_L33
       add       edx,[r8+rcx*4+10]
       jo        near ptr M00_L34
       add       ecx,1
       jo        near ptr M00_L34
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       mov       r8d,[r8+8]
       movsxd    r10,ecx
       cmp       r8,r10
       jg        short M00_L13
M00_L14:
       test      edx,edx
       je        near ptr M00_L31
       movsxd    rdx,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       xor       edi,edi
       mov       rax,[rbp-60]
       mov       rcx,[rax+10]
       mov       r14,[rcx+8]
       xor       r15d,r15d
       mov       r13d,[r14+8]
       mov       r12d,r13d
       test      r12,r12
       jle       short M00_L18
M00_L15:
       cmp       r15d,r13d
       jae       near ptr M00_L33
       mov       r8,[r14+r15*8+10]
       test      r8,r8
       je        short M00_L17
       mov       r10d,[rsi+8]
       mov       [rbp-58],r10
       nop       dword ptr [rax]
M00_L16:
       movsxd    rcx,edi
       cmp       rcx,r10
       jae       near ptr M00_L33
       lea       rcx,[rsi+rcx*8+10]
       mov       [rbp-68],r8
       mov       rdx,[r8+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       edi,1
       jo        near ptr M00_L34
       mov       rcx,[rbp-68]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r8,rcx
       mov       r10,[rbp-58]
       jne       short M00_L16
M00_L17:
       add       r15d,1
       jo        near ptr M00_L34
       movsxd    rcx,r15d
       cmp       r12,rcx
       jg        short M00_L15
M00_L18:
       jmp       near ptr M00_L35
M00_L19:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L22
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L21
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FF8A830F4C8]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF8A840E328]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L20
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L34
       test      edi,edi
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FF8A830F4C8]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FF8A840E328]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L34
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        short M00_L34
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L30:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L25
M00_L31:
       test      byte ptr [7FF8A84B7C58],1
       jne       short M00_L32
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M00_L32:
       mov       rcx,209E6000B20
       mov       rsi,[rcx]
       jmp       short M00_L35
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L35:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L38
M00_L36:
       mov       rax,[rbp-60]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L41
       mov       edx,edi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L40
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L39
M00_L37:
       add       edi,1
       jo        short M00_L42
       cmp       edi,[rbp-3C]
       jl        short M00_L36
M00_L38:
       mov       [rbp-50],rsi
       mov       rdi,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L39:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A830F5B8]
       jmp       short M00_L37
M00_L40:
       xor       ecx,ecx
       call      qword ptr [7FF8A830F4C8]
       int       3
M00_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L43
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L44
       mov       [rbp-3C],ecx
M00_L43:
       add       rsp,28
       ret
M00_L44:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L45
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L46
       mov       [rbp-3C],ecx
M00_L45:
       add       rsp,28
       ret
M00_L46:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L47
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L48
       mov       [rbp-3C],ecx
M00_L47:
       add       rsp,28
       ret
M00_L48:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L49
       mov       edx,[rbp-3C]
       add       edx,1
       jo        short M00_L50
       mov       [rbp-3C],edx
M00_L49:
       add       rsp,28
       ret
M00_L50:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L56
M00_L51:
       mov       rcx,[rbp-60]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L54
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L53
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A830F5B8]
M00_L52:
       add       edi,1
       jo        short M00_L55
       cmp       edi,[rbp-3C]
       jl        short M00_L51
       jmp       short M00_L56
M00_L53:
       xor       ecx,ecx
       call      qword ptr [7FF8A830F4C8]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L56:
       add       rsp,28
       ret
; Total bytes of code 1187
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF8A7C48210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF9078AE370
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF907B64A90],0
       je        short M01_L01
       call      qword ptr [7FF907B52648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 154
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
       jmp       qword ptr [7FF8A7C05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.ToArray()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+2D8]
       mov       [rbp-60],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L19
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8A83260D0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF8A8327408]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L34
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-60]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L30
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8A83260D0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF8A8327408]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L34
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       edx,edx
       xor       ecx,ecx
       mov       rax,[rbp-60]
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       dword ptr [r8+8],0
       je        short M00_L14
M00_L13:
       mov       rax,[rbp-60]
       test      edx,edx
       jl        short M00_L14
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       ecx,[r8+8]
       jae       near ptr M00_L33
       add       edx,[r8+rcx*4+10]
       jo        near ptr M00_L34
       add       ecx,1
       jo        near ptr M00_L34
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       mov       r8d,[r8+8]
       movsxd    r10,ecx
       cmp       r8,r10
       jg        short M00_L13
M00_L14:
       test      edx,edx
       je        near ptr M00_L31
       movsxd    rdx,edx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       xor       edi,edi
       mov       rax,[rbp-60]
       mov       rcx,[rax+10]
       mov       r14,[rcx+8]
       xor       r15d,r15d
       mov       r13d,[r14+8]
       mov       r12d,r13d
       test      r12,r12
       jle       short M00_L18
M00_L15:
       cmp       r15d,r13d
       jae       near ptr M00_L33
       mov       r8,[r14+r15*8+10]
       test      r8,r8
       je        short M00_L17
       mov       r10d,[rsi+8]
       mov       [rbp-58],r10
       nop       dword ptr [rax]
M00_L16:
       movsxd    rcx,edi
       cmp       rcx,r10
       jae       near ptr M00_L33
       lea       rcx,[rsi+rcx*8+10]
       mov       [rbp-68],r8
       mov       rdx,[r8+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       edi,1
       jo        near ptr M00_L34
       mov       rcx,[rbp-68]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r8,rcx
       mov       r10,[rbp-58]
       jne       short M00_L16
M00_L17:
       add       r15d,1
       jo        near ptr M00_L34
       movsxd    rcx,r15d
       cmp       r12,rcx
       jg        short M00_L15
M00_L18:
       jmp       near ptr M00_L35
M00_L19:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       edi,[rsi+8]
       jae       short M00_L22
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L21
       mov       rcx,r14
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FF8A83260D0]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF8A8327408]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L20
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-3C],ecx
       add       edi,1
       jo        near ptr M00_L34
       test      edi,edi
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FF9078ADF30
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FF8A83260D0]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FF8A8327408]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L34
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        short M00_L34
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L30:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L25
M00_L31:
       test      byte ptr [7FF8A8578A80],1
       jne       short M00_L32
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M00_L32:
       mov       rcx,1FF6FC02B20
       mov       rsi,[rcx]
       jmp       short M00_L35
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L35:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L38
M00_L36:
       mov       rax,[rbp-60]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L41
       mov       edx,edi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L40
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       jne       short M00_L39
M00_L37:
       add       edi,1
       jo        short M00_L42
       cmp       edi,[rbp-3C]
       jl        short M00_L36
M00_L38:
       mov       [rbp-50],rsi
       mov       rdi,[rbx+88]
       mov       rdx,[rbp-50]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L39:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83261C0]
       jmp       short M00_L37
M00_L40:
       xor       ecx,ecx
       call      qword ptr [7FF8A83260D0]
       int       3
M00_L41:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L43
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L44
       mov       [rbp-3C],ecx
M00_L43:
       add       rsp,28
       ret
M00_L44:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L45
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L46
       mov       [rbp-3C],ecx
M00_L45:
       add       rsp,28
       ret
M00_L46:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L47
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L48
       mov       [rbp-3C],ecx
M00_L47:
       add       rsp,28
       ret
M00_L48:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L49
       mov       edx,[rbp-3C]
       add       edx,1
       jo        short M00_L50
       mov       [rbp-3C],edx
M00_L49:
       add       rsp,28
       ret
M00_L50:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L56
M00_L51:
       mov       rcx,[rbp-60]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L54
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L53
       mov       rcx,r14
       call      00007FF9078ADE50
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8A83261C0]
M00_L52:
       add       edi,1
       jo        short M00_L55
       cmp       edi,[rbp-3C]
       jl        short M00_L51
       jmp       short M00_L56
M00_L53:
       xor       ecx,ecx
       call      qword ptr [7FF8A83260D0]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L56:
       add       rsp,28
       ret
; Total bytes of code 1187
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
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
       jmp       qword ptr [7FF8A7C25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryPeek()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,18385C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0EE927141
       mov       r8d,0B2883514
       cmp       edx,8
       jb        near ptr M00_L10
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L11
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       xor       eax,eax
       jmp       short M00_L07
M00_L09:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L10:
       cmp       edx,4
       jb        short M00_L12
M00_L11:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FF8A7B80D90
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF8A7B80D98
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryPeek()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,1B461C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,4968DBDE
       mov       r8d,0F8D21E14
       cmp       edx,8
       jb        near ptr M00_L10
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L11
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       xor       eax,eax
       jmp       short M00_L07
M00_L09:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L10:
       cmp       edx,4
       jb        short M00_L12
M00_L11:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FF8A7B40D90
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF8A7B40D98
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryPeek()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,18F30C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,88DE9E17
       mov       r8d,0A3190C79
       cmp       edx,8
       jb        near ptr M00_L10
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L11
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       xor       eax,eax
       jmp       short M00_L07
M00_L09:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L10:
       cmp       edx,4
       jb        short M00_L12
M00_L11:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FF8A7B40D90
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF8A7B40D98
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryPeek()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,1CC73000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,41FD1B22
       mov       r8d,0DE852B37
       cmp       edx,8
       jb        near ptr M00_L10
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L11
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       xor       eax,eax
       jmp       short M00_L07
M00_L09:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L10:
       cmp       edx,4
       jb        short M00_L12
M00_L11:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FF8A7B40D88
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF8A7B40D90
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryPeek()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,23223C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0E10705C4
       mov       r8d,7A68007A
       cmp       edx,8
       jb        near ptr M00_L10
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L11
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       xor       eax,eax
       jmp       short M00_L07
M00_L09:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L10:
       cmp       edx,4
       jb        short M00_L12
M00_L11:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FF8A7B60D90
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF8A7B60D98
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryPeek()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,2B40B400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,7FF4167
       mov       r8d,0E80955B5
       cmp       edx,8
       jb        near ptr M00_L10
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L11
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       xor       eax,eax
       jmp       short M00_L07
M00_L09:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L10:
       cmp       edx,4
       jb        short M00_L12
M00_L11:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FF8A7B80D90
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF8A7B80D98
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryPeek()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,1D42E000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,92ACE505
       mov       r8d,4FA572AF
       cmp       edx,8
       jb        near ptr M00_L10
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L11
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       xor       eax,eax
       jmp       short M00_L07
M00_L09:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L10:
       cmp       edx,4
       jb        short M00_L12
M00_L11:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FF8A7B40F38
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF8A7B40F40
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryPeek()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+2D8]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L10
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L11
       mov       rcx,1B426000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,958338E6
       mov       r8d,94372427
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
M00_L00:
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
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L09
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
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
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       cmp       edx,4
       jb        short M00_L12
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
       jmp       near ptr M00_L01
M00_L10:
       xor       eax,eax
       jmp       short M00_L07
M00_L11:
       xor       ebp,ebp
       jmp       near ptr M00_L03
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FF8A7B711B0
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF8A7B711B8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 611
```

