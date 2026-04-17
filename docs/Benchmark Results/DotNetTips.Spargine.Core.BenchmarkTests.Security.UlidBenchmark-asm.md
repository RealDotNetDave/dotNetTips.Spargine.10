## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.UlidBenchmark.UlidGetHashCode()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,24BB7C02108
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L01
M00_L00:
       cmp       [rcx],ecx
       call      qword ptr [7FF7A95FAAC0]; System.MulticastDelegate.GetHashCode()
       mov       rcx,[rbx+60]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Core.Ulid>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,7FF7A9C1B408
       mov       r9,7FF7A950D010
       call      qword ptr [7FF7A95C7180]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,24BB7C02108
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       jmp       short M00_L00
; Total bytes of code 121
```
```assembly
; System.MulticastDelegate.GetHashCode()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdx,[rbx+30]
       cmp       rdx,0FFFFFFFFFFFFFFFF
       je        short M01_L03
       test      rdx,rdx
       jne       short M01_L04
M01_L00:
       mov       rdx,[rbx+28]
       mov       rcx,offset MT_System.Object[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M01_L08
       cmp       qword ptr [rbx+20],0
       je        short M01_L05
       mov       rcx,rbx
       call      qword ptr [7FF7A97961D8]; System.Object.GetType()
       mov       rbx,rax
       mov       rcx,rbx
       call      00007FF8091F1BC0
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF7A97977F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
M01_L03:
       mov       rcx,[rbx+18]
       mov       rdx,[rbx+20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF7A9C9D9C8]
M01_L04:
       mov       rdx,[rbx+28]
       mov       rcx,offset MT_System.Delegate
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L00
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+18]
M01_L05:
       cmp       qword ptr [rbx+8],0
       jne       short M01_L06
       xor       esi,esi
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbx+8]
       call      qword ptr [7FF7A99EDC68]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       shl       esi,5
       add       esi,eax
M01_L07:
       mov       rcx,rbx
       call      qword ptr [7FF7A97961D8]; System.Object.GetType()
       mov       rcx,rax
       call      qword ptr [7FF7A99EDC68]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       add       eax,esi
       jmp       near ptr M01_L01
M01_L08:
       xor       edi,edi
       xor       ebp,ebp
       jmp       short M01_L10
M01_L09:
       cmp       ebp,[rsi+8]
       jae       short M01_L11
       mov       rcx,[rsi+rbp*8+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       ecx,edi
       shl       ecx,5
       add       ecx,edi
       lea       edi,[rax+rcx]
       inc       ebp
M01_L10:
       cmp       ebp,[rbx+30]
       jl        short M01_L09
       mov       eax,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 299
```
```assembly
; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       lea       rcx,[rbx+8]
       mov       rdx,rbx
       call      qword ptr [7FFFFEC03FE8]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Security.UlidBenchmark.NewUlid()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,1675B4020F0
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Core.Ulid>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,7FF7A9C0B000
       mov       r9,7FF7A94FD0B0
       call      qword ptr [7FF7A95B6E98]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,1675B4020F0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
```
```assembly
; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       lea       rcx,[rbx+8]
       mov       rdx,rbx
       call      qword ptr [7FFFFEC03FE8]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

