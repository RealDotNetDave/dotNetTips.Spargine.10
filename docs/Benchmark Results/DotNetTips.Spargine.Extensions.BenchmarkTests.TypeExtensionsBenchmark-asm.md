## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetTypeMembersWithAttribute()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetMembersWithAttribute>d__36<System.Text.Json.Serialization.JsonPropertyNameAttribute>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rdx,2E3F8C706C0
       mov       [rsi+18],rdx
       mov       rdx,rsi
       mov       rcx,7FFA02FAC908
       call      qword ptr [7FFA02F674B0]; System.Linq.Enumerable.<ToArray>g__EnumerableToArray|324_0[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Reflection.MemberInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M00_L00
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],rdi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       mov       ecx,14
       call      qword ptr [7FFA02B6C228]
       int       3
; Total bytes of code 170
```
```assembly
; System.Linq.Enumerable.<ToArray>g__EnumerableToArray|324_0[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1A8
       lea       rbp,[rsp+1E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L32
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-80],ymm0
       vmovdqu   ymmword ptr [rbp-60],ymm0
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-178],ymm0
       vmovdqu   ymmword ptr [rbp-158],ymm0
       vmovdqu   ymmword ptr [rbp-138],ymm0
       vmovdqu   ymmword ptr [rbp-118],ymm0
       vmovdqu   ymmword ptr [rbp-0F8],ymm0
       vmovdqu   ymmword ptr [rbp-0D8],ymm0
       vmovdqu   ymmword ptr [rbp-0C0],ymm0
       xor       edx,edx
       mov       [rbp-188],edx
       mov       [rbp-184],edx
       mov       [rbp-180],edx
       lea       rdx,[rbp-80]
       mov       [rbp-0A0],rdx
       mov       dword ptr [rbp-98],8
       lea       rdx,[rbp-80]
       mov       [rbp-90],rdx
       mov       dword ptr [rbp-88],8
       mov       rdx,[rcx+18]
       mov       rsi,[rdx+28]
       test      rsi,rsi
       je        near ptr M01_L30
M01_L01:
       mov       rdi,rsi
       mov       r14,[rbp-90]
       mov       r15d,[rbp-88]
       mov       r13d,[rbp-180]
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+40]
       test      r11,r11
       je        near ptr M01_L31
M01_L02:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-1B8],rbx
M01_L03:
       mov       rcx,rbx
       mov       r11,7FFA02890A08
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+48]
       test      r11,r11
       je        short M01_L05
M01_L04:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       r12,rax
       cmp       r13d,r15d
       jae       short M01_L06
       mov       ecx,r13d
       lea       rcx,[r14+rcx*8]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       jmp       short M01_L03
M01_L05:
       mov       rcx,rdi
       mov       rdx,7FFA0302B8E0
       call      qword ptr [7FFA0294C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M01_L04
M01_L06:
       lea       rcx,[rbp-188]
       mov       rdx,rdi
       mov       r8d,10
       call      qword ptr [7FFA03065968]
       mov       r14,[rbp-90]
       mov       r15d,[rbp-88]
       test      r15d,r15d
       je        short M01_L07
       mov       rcx,r14
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r13d,1
       jmp       near ptr M01_L03
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L08:
       mov       rcx,rbx
       mov       r11,7FFA02890A10
       call      qword ptr [r11]
       mov       [rbp-180],r13d
       mov       rbx,rsi
       mov       edi,[rbp-184]
       add       edi,[rbp-180]
       jo        near ptr M01_L42
       mov       r14d,edi
       test      r14d,r14d
       jne       near ptr M01_L15
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+50]
       test      rcx,rcx
       je        short M01_L13
M01_L09:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L14
M01_L10:
       mov       rcx,rdx
       call      qword ptr [7FFA02945728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax]
M01_L11:
       mov       rdx,rsi
       mov       r8d,[rbp-188]
       test      r8d,r8d
       jne       near ptr M01_L41
M01_L12:
       mov       rax,r15
       add       rsp,1A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L13:
       mov       rcx,rbx
       mov       rdx,7FFA0302B928
       call      qword ptr [7FFA0294C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L09
M01_L14:
       mov       rdx,7FFA0302C218
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L10
M01_L15:
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        near ptr M01_L22
M01_L16:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M01_L23
       mov       rcx,rax
M01_L17:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],60
       jle       near ptr M01_L24
       mov       rcx,[rcx+60]
       test      rcx,rcx
       je        near ptr M01_L24
M01_L18:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M01_L25
M01_L19:
       cmp       [r15],rax
       jne       near ptr M01_L33
       lea       r14,[r15+10]
       mov       r13,r14
       mov       r12d,edi
       mov       eax,[rbp-188]
       mov       [rbp-18C],eax
       test      eax,eax
       jne       near ptr M01_L26
M01_L20:
       mov       ecx,[rbp-180]
       cmp       ecx,[rbp-88]
       jbe       near ptr M01_L27
M01_L21:
       call      qword ptr [7FFA02AB7198]
       int       3
M01_L22:
       mov       rcx,rbx
       mov       rdx,7FFA0302B960
       call      qword ptr [7FFA0294C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L16
M01_L23:
       mov       rdx,7FFA0302BBE0
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L17
M01_L24:
       mov       rcx,rbx
       mov       rdx,7FFA0302BAC8
       call      qword ptr [7FFA0294C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M01_L18
M01_L25:
       mov       rdx,7FFA0302BC60
       call      qword ptr [7FFA0294C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L19
M01_L26:
       mov       rdx,[rbp-0A0]
       mov       r13d,[rbp-98]
       cmp       r13d,edi
       jg        short M01_L29
       mov       r12d,r13d
       shl       r12,3
       mov       r8,r12
       mov       rcx,r14
       call      qword ptr [7FFA029457A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14,r12
       sub       edi,r13d
       mov       r12d,edi
       mov       r13,r14
       mov       edi,[rbp-18C]
       dec       edi
       je        near ptr M01_L20
       jmp       near ptr M01_L34
M01_L27:
       mov       rdx,[rbp-90]
       cmp       ecx,r12d
       ja        short M01_L29
       mov       r8d,ecx
       shl       r8,3
       cmp       r8,4000
       jbe       short M01_L28
       mov       rcx,r13
       call      qword ptr [7FFA03065998]
       jmp       near ptr M01_L11
M01_L28:
       mov       rcx,r13
       call      00007FFA6254DC70
       cmp       dword ptr [7FFA628A3B10],0
       je        near ptr M01_L11
       jmp       near ptr M01_L40
M01_L29:
       call      qword ptr [7FFA02D5C4E0]
       int       3
M01_L30:
       mov       rdx,7FFA0302B498
       call      qword ptr [7FFA02B67B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L31:
       mov       rcx,rdi
       mov       rdx,7FFA0302B8C8
       call      qword ptr [7FFA0294C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L02
M01_L32:
       mov       ecx,11
       call      qword ptr [7FFA02B67E58]
       int       3
M01_L33:
       call      qword ptr [7FFA03065980]
       int       3
M01_L34:
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],70
       jle       short M01_L35
       mov       rdx,[rcx+70]
       test      rdx,rdx
       je        short M01_L35
       jmp       short M01_L36
M01_L35:
       mov       rcx,rbx
       mov       rdx,7FFA0302BCF0
       call      qword ptr [7FFA0294C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L36:
       lea       rcx,[rbp-1A0]
       lea       r8,[rbp-178]
       mov       r9d,1B
       call      qword ptr [7FFA03065740]
       cmp       edi,[rbp-198]
       ja        near ptr M01_L21
       mov       rbx,[rbp-1A0]
       xor       r14d,r14d
M01_L37:
       mov       r8,[rbx+r14*8]
       test      r8,r8
       jne       short M01_L38
       xor       edx,edx
       xor       eax,eax
       jmp       short M01_L39
M01_L38:
       lea       rdx,[r8+10]
       mov       eax,[r8+8]
M01_L39:
       cmp       eax,r12d
       jg        near ptr M01_L29
       mov       [rbp-1A4],eax
       mov       r10d,eax
       shl       r10,3
       mov       [rbp-1B0],r10
       mov       r8,r10
       mov       rcx,r13
       call      qword ptr [7FFA029457A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbp-1B0]
       add       r13,rcx
       sub       r12d,[rbp-1A4]
       inc       r14d
       cmp       r14d,edi
       jl        short M01_L37
       jmp       near ptr M01_L20
M01_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L11
M01_L41:
       lea       rcx,[rbp-188]
       call      qword ptr [7FFA030659B0]
       jmp       near ptr M01_L12
M01_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       mov       rbx,[rbp-1B8]
       test      rbx,rbx
       je        short M01_L43
       mov       rcx,rbx
       mov       r11,7FFA02890A10
       call      qword ptr [r11]
M01_L43:
       nop
       add       rsp,28
       ret
; Total bytes of code 1393
```

