## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
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
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1FFA8C01FF0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object[]
       mov       edx,0C
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
M00_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[r14+r15*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L17
       cmp       r15d,0C
       jl        short M00_L00
       mov       edx,0C
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       edx,1F
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       dword ptr [rdi+18],2
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L09
       mov       ecx,[rsi+34]
       mov       [rsp+30],rsi
       xor       edx,edx
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       mov       [rsp+44],edx
M00_L01:
       lea       rcx,[rsp+30]
       mov       rdx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      qword ptr [7FFB41D2C258]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L08
       mov       rsi,[rsp+38]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,[rdi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L15
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L10
       mov       rcx,1FFA8C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0C166A861
       mov       r8d,165038D8
       cmp       edx,8
       jb        near ptr M00_L06
       mov       r10d,edx
       shr       r10d,3
M00_L02:
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
       jne       short M00_L02
       test      dl,4
       jne       short M00_L07
M00_L03:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L04:
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
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,edx
       rol       edx,9
       xor       edx,r8d
       rol       r8d,1B
       add       r8d,edx
       mov       eax,edx
       rol       eax,13
       xor       r8d,eax
M00_L05:
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r9d,r9d
       call      qword ptr [7FFB41D2C3C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       jmp       near ptr M00_L01
M00_L06:
       cmp       edx,4
       jb        near ptr M00_L11
M00_L07:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L03
M00_L08:
       mov       [rsp+28],rdi
       mov       rcx,[rbx+60]
       lea       r8,[rsp+28]
       mov       rdx,7FFB41D67010
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D2C4E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L09:
       call      qword ptr [7FFB41B749A8]
       mov       ecx,65
       mov       rdx,7FFB4194C248
       call      qword ptr [7FFB4153F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB41815AC0
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4194C248
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41DB5350]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB4195E268]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       xor       r8d,r8d
       jmp       near ptr M00_L05
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
       jmp       near ptr M00_L04
M00_L13:
       mov       ecx,r10d
       jmp       near ptr M00_L04
M00_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L15:
       mov       rdx,rsi
       mov       r11,7FFB41480D70
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L16:
       call      qword ptr [7FFB41B749A8]
       mov       ecx,245B
       mov       rdx,7FFB41815AC0
       call      qword ptr [7FFB4153F228]
       mov       rdi,rax
       mov       ecx,191A
       mov       rdx,7FFB41815AC0
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFB41815AC0
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41DB5350]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB4195E268]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1174
```
```assembly
; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       sub       rsp,28
       mov       edx,[rcx+10]
       mov       rax,[rcx]
       cmp       edx,[rax+34]
       jne       short M01_L02
       mov       edx,[rcx+14]
       cmp       edx,[rax+28]
       jae       short M01_L01
M01_L00:
       mov       rdx,[rcx]
       mov       rdx,[rdx+10]
       mov       eax,[rcx+14]
       lea       r8d,[rax+1]
       mov       [rcx+14],r8d
       cmp       eax,[rdx+8]
       jae       short M01_L04
       shl       rax,4
       lea       rdx,[rdx+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M01_L03
       mov       rdx,[rdx]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       eax,[rax+28]
       inc       eax
       mov       [rcx+14],eax
       xor       eax,eax
       mov       [rcx+8],rax
       add       rsp,28
       ret
M01_L02:
       call      qword ptr [7FFB4153FC60]
       int       3
M01_L03:
       mov       edx,[rcx+14]
       mov       rax,[rcx]
       cmp       edx,[rax+28]
       jb        short M01_L00
       jmp       short M01_L01
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 131
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return acquireLock ? this.AddInternalLocked(item, hashCode) : this.AddInternalUnlocked(item, hashCode);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       [rcx],ecx
       cmp       qword ptr [rbp+18],0
       je        near ptr M02_L06
       mov       rax,[rbp+18]
       mov       [rbp+18],rax
       test      r9b,r9b
       jne       near ptr M02_L10
       mov       ebx,r8d
       mov       rsi,[rcx+10]
       mov       r8,[rsi+8]
       mov       r10d,[r8+8]
       mov       rax,[rsi+10]
       mov       r9d,[rax+8]
       mov       eax,ebx
       and       eax,7FFFFFFF
       cdq
       idiv      r10d
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r9d
       mov       r14d,edx
       cmp       edi,[r8+8]
       jae       near ptr M02_L63
       mov       edx,edi
       mov       r15,[r8+rdx*8+10]
       test      r15,r15
       je        short M02_L02
M02_L00:
       cmp       ebx,[r15+18]
       je        near ptr M02_L07
M02_L01:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M02_L00
M02_L02:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M02_L05
M02_L03:
       mov       r15,rax
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r12,[rsi+8]
       mov       rcx,r12
       mov       edx,edi
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r15,rax
       cmp       edi,[r12+8]
       jae       near ptr M02_L63
       mov       ecx,edi
       mov       rdi,[r12+rcx*8+10]
       lea       rcx,[r13+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+18],ebx
       lea       rcx,[r13+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rsi+18]
       cmp       r14d,[rax+8]
       jae       near ptr M02_L63
       mov       edx,r14d
       lea       rax,[rax+rdx*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M02_L64
       mov       [rax],edx
       mov       eax,1
M02_L04:
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
M02_L05:
       mov       rcx,rdx
       mov       rdx,7FFB41D48760
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L03
M02_L06:
       call      qword ptr [7FFB41B749A8]
       mov       ecx,245B
       mov       rdx,7FFB41815AC0
       call      qword ptr [7FFB4153F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB41815AC0
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFB41815AC0
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41DB5350]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB4195E268]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L07:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+48]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rdx
       mov       rdx,7FFB41D48A18
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp+18]
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       je        near ptr M02_L01
       xor       eax,eax
       jmp       near ptr M02_L04
M02_L10:
       mov       [rbp-44],r8d
M02_L11:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       rax,[rbx+10]
       mov       r10d,[rax+8]
       mov       eax,[rbp-44]
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r10d
       mov       edi,edx
       mov       rdx,[rbx+10]
       cmp       edi,[rdx+8]
       jae       near ptr M02_L63
       mov       eax,edi
       mov       rdx,[rdx+rax*8+10]
       mov       [rbp-90],rdx
       mov       byte ptr [rbp-50],0
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41535998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M02_L23
       mov       r14d,[rbp-44]
       mov       rdx,[rbx+8]
       cmp       esi,[rdx+8]
       jae       near ptr M02_L18
       mov       eax,esi
       mov       r15,[rdx+rax*8+10]
       test      r15,r15
       je        short M02_L17
M02_L12:
       cmp       r14d,[r15+18]
       jne       short M02_L15
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+48]
       test      r11,r11
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rdx
       mov       rdx,7FFB41D48A18
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp+18]
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       short M02_L16
M02_L15:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M02_L12
       jmp       short M02_L17
M02_L16:
       xor       r15d,r15d
       xor       r13d,r13d
       jmp       near ptr M02_L22
M02_L17:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M02_L20
       jmp       short M02_L21
M02_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L20:
       mov       rcx,rdx
       mov       rdx,7FFB41D48760
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L21:
       mov       r15,rax
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r15,rax
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       short M02_L18
       mov       edx,esi
       mov       rsi,[rcx+rdx*8+10]
       lea       rcx,[r13+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+18],r14d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M02_L18
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M02_L19
       mov       [rcx],eax
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M02_L18
       mov       eax,edi
       mov       ecx,[rcx+rax*4+10]
       mov       rax,[rbp+10]
       cmp       ecx,[rax+18]
       setg      r13b
       movzx     r13d,r13b
       mov       r15d,1
       mov       rcx,[rbp+10]
M02_L22:
       movzx     esi,r13b
       cmp       byte ptr [rbp-50],0
       je        short M02_L24
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41536820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M02_L24
M02_L23:
       call      M02_L65
       jmp       near ptr M02_L11
M02_L24:
       test      esi,esi
       je        near ptr M02_L61
       xor       edx,edx
       mov       [rbp-54],edx
       mov       rdx,[rcx+10]
       mov       rsi,[rdx+10]
       xor       edi,edi
       test      edi,edi
       jg        short M02_L29
M02_L25:
       mov       byte ptr [rbp-60],0
       cmp       edi,[rsi+8]
       jae       short M02_L26
       mov       rcx,[rsi+rdi*8+10]
       lea       rdx,[rbp-60]
       call      qword ptr [7FFB41535998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       jmp       short M02_L27
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L27:
       cmp       byte ptr [rbp-60],0
       je        short M02_L28
       mov       edx,[rbp-54]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rbp-54],edx
M02_L28:
       add       edi,1
       jo        near ptr M02_L58
       test      edi,edi
       jle       short M02_L25
M02_L29:
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M02_L62
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M02_L31
M02_L30:
       mov       r8,[rbx+18]
       cmp       r9d,[r8+8]
       jae       near ptr M02_L57
       movsxd    r8,dword ptr [r8+r9*4+10]
       add       rdx,r8
       jo        near ptr M02_L58
       add       r9d,1
       jo        near ptr M02_L58
M02_L31:
       mov       r8,[rbx+18]
       mov       r8d,[r8+8]
       movsxd    rax,r9d
       cmp       r8,rax
       jg        short M02_L30
       mov       r9,[rbx+8]
       mov       r9d,[r9+8]
       shr       r9,2
       cmp       r9,rdx
       jle       short M02_L32
       movsxd    rdx,dword ptr [rcx+18]
       imul      rdx,2
       jo        near ptr M02_L58
       mov       r9d,7FFFFFFF
       cmp       rdx,7FFFFFFF
       cmovg     rdx,r9
       movsxd    r9,edx
       cmp       rdx,r9
       jne       near ptr M02_L58
       mov       [rcx+18],edx
       mov       edx,1
       test      edx,edx
       jne       near ptr M02_L62
M02_L32:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       mov       rcx,[rcx]
       lea       r9,[rbp-68]
       mov       r8d,7FEFFFFF
       call      qword ptr [7FFB41DB53F8]
       test      eax,eax
       jne       short M02_L33
       mov       esi,7FEFFFFF
       mov       edi,1
       jmp       short M02_L34
M02_L33:
       mov       esi,[rbp-68]
       xor       edi,edi
M02_L34:
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r13,[rdx+10]
       mov       r12d,1
       jmp       short M02_L39
M02_L35:
       mov       byte ptr [rbp-70],0
       cmp       r12d,[r13+8]
       jae       short M02_L36
       mov       rcx,[r13+r12*8+10]
       lea       rdx,[rbp-70]
       call      qword ptr [7FFB41535998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       jmp       short M02_L37
M02_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L37:
       cmp       byte ptr [rbp-70],0
       je        short M02_L38
       mov       edx,[rbp-54]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rbp-54],edx
M02_L38:
       add       r12d,1
       jo        near ptr M02_L58
M02_L39:
       cmp       r12d,r14d
       jl        short M02_L35
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+1C],0
       je        short M02_L40
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],400
       jl        short M02_L41
M02_L40:
       mov       r14,[rbx+10]
       jmp       near ptr M02_L44
M02_L41:
       mov       rdx,[rbx+10]
       mov       edx,[rdx+8]
       imul      rdx,2
       jo        near ptr M02_L58
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       ecx,[rcx+8]
       mov       [rsp+20],ecx
       mov       rcx,[rbx+10]
       mov       r8,r14
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFB41AF4750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,[rbx+10]
       mov       r13d,[rcx+8]
       jmp       short M02_L43
M02_L42:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[r14+8]
       cmp       r13,rcx
       jae       near ptr M02_L57
       lea       rcx,[r14+r13*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r13,1
       jo        near ptr M02_L58
M02_L43:
       mov       ecx,[r14+8]
       cmp       rcx,r13
       jg        short M02_L42
M02_L44:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L45
       jmp       short M02_L46
M02_L45:
       mov       rcx,rdx
       mov       rdx,7FFB41D48000
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L46:
       mov       rcx,rax
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       edx,[r14+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       rcx,[rbp+10]
       mov       r12,[rcx]
       xor       r8d,r8d
       jmp       near ptr M02_L52
M02_L47:
       mov       rax,[rbx+8]
       cmp       r8d,[rax+8]
       jae       near ptr M02_L57
       mov       [rbp-88],r8
       mov       r10,[rax+r8*8+10]
       test      r10,r10
       je        near ptr M02_L51
M02_L48:
       mov       r9,[r10+10]
       mov       [rbp-0A0],r9
       mov       [rbp-98],r10
       lea       rax,[r10+18]
       mov       r11d,[rsi+8]
       mov       edx,[r14+8]
       mov       [rbp-7C],edx
       mov       eax,[rax]
       and       eax,7FFFFFFF
       cdq
       idiv      r11d
       mov       r11d,edx
       mov       [rbp-74],r11d
       mov       eax,r11d
       cdq
       idiv      dword ptr [rbp-7C]
       mov       [rbp-78],edx
       mov       rdx,[r12+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M02_L49
       mov       rax,rdx
       jmp       short M02_L50
M02_L49:
       mov       rcx,r12
       mov       rdx,7FFB41D48760
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L50:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0A8],rax
       mov       r8,[rbp-98]
       mov       rdx,[r8+8]
       mov       r8d,[r8+18]
       mov       [rbp-80],r8d
       mov       r10d,[rbp-74]
       cmp       r10d,[rsi+8]
       jae       near ptr M02_L57
       mov       ecx,r10d
       mov       r9,[rsi+rcx*8+10]
       mov       [rbp-0B0],r9
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0A8]
       mov       ecx,[rbp-80]
       mov       [rax+18],ecx
       lea       rcx,[rax+10]
       mov       rdx,[rbp-0B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-74]
       mov       rcx,rsi
       mov       r8,[rbp-0A8]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       eax,[rbp-78]
       cmp       eax,[r13+8]
       jae       near ptr M02_L57
       lea       rax,[r13+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rax],edx
       mov       r8,[rbp-0A0]
       mov       rax,r8
       test      rax,rax
       mov       r10,rax
       jne       near ptr M02_L48
M02_L51:
       mov       r8,[rbp-88]
       add       r8d,1
       jo        near ptr M02_L58
       mov       rax,r8
M02_L52:
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       movsxd    rdx,r8d
       cmp       rax,rdx
       jg        near ptr M02_L47
       mov       eax,[rsi+8]
       mov       r8d,[r14+8]
       test      edi,edi
       jne       short M02_L53
       cdq
       idiv      r8d
       mov       edx,1
       cmp       eax,1
       cmovg     edx,eax
       jmp       short M02_L54
M02_L53:
       mov       edx,7FFFFFFF
M02_L54:
       mov       rcx,[rbp+10]
       mov       [rcx+18],edx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       test      rax,rax
       je        short M02_L55
       jmp       short M02_L56
M02_L55:
       mov       rcx,rdx
       mov       rdx,7FFB41D48248
       call      System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L56:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       jmp       short M02_L62
M02_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L59:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       ebx,[rax+8]
       jae       short M02_L63
       mov       edx,ebx
       mov       rcx,[rax+rdx*8+10]
       call      qword ptr [7FFB41536820]; System.Threading.Monitor.Exit(System.Object)
       add       ebx,1
       jo        short M02_L64
       mov       rcx,[rbp+10]
M02_L60:
       cmp       ebx,[rbp-54]
       jl        short M02_L59
M02_L61:
       mov       eax,r15d
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
M02_L62:
       xor       eax,eax
       xor       ebx,ebx
       jmp       short M02_L60
M02_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L65:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M02_L66
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41536820]; System.Threading.Monitor.Exit(System.Object)
M02_L66:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-60],0
       je        short M02_L67
       mov       edx,[rbp-54]
       add       edx,1
       jo        short M02_L68
       mov       [rbp-54],edx
M02_L67:
       add       rsp,28
       ret
M02_L68:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-70],0
       je        short M02_L69
       mov       edx,[rbp-54]
       add       edx,1
       jo        short M02_L70
       mov       [rbp-54],edx
M02_L69:
       add       rsp,28
       ret
M02_L70:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r15d,r15d
       cmp       r15d,[rbp-54]
       jge       short M02_L72
M02_L71:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       r15d,[rax+8]
       jae       short M02_L73
       mov       edx,r15d
       mov       rcx,[rax+rdx*8+10]
       call      qword ptr [7FFB41536820]; System.Threading.Monitor.Exit(System.Object)
       add       r15d,1
       jo        short M02_L74
       cmp       r15d,[rbp-54]
       jl        short M02_L71
M02_L72:
       add       rsp,28
       ret
M02_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2489
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
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M04_L00:
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
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,2403D9D0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L03:
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
M04_L04:
       call      qword ptr [7FFB41D2D170]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
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
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1824D401FB0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object[]
       mov       edx,0C
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
M00_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[r14+r15*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L17
       cmp       r15d,0C
       jl        short M00_L00
       mov       edx,0C
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       edx,1F
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       dword ptr [rdi+18],2
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L09
       mov       ecx,[rsi+34]
       mov       [rsp+30],rsi
       xor       edx,edx
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       mov       [rsp+44],edx
M00_L01:
       lea       rcx,[rsp+30]
       mov       rdx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      qword ptr [7FFB41CF5788]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L08
       mov       rsi,[rsp+38]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,[rdi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L15
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L10
       mov       rcx,1824D400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0A37C63CC
       mov       r8d,0F418C38B
       cmp       edx,8
       jb        near ptr M00_L06
       mov       r10d,edx
       shr       r10d,3
M00_L02:
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
       jne       short M00_L02
       test      dl,4
       jne       short M00_L07
M00_L03:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L04:
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
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,edx
       rol       edx,9
       xor       edx,r8d
       rol       r8d,1B
       add       r8d,edx
       mov       eax,edx
       rol       eax,13
       xor       r8d,eax
M00_L05:
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r9d,r9d
       call      qword ptr [7FFB41CF58F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       jmp       near ptr M00_L01
M00_L06:
       cmp       edx,4
       jb        near ptr M00_L11
M00_L07:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L03
M00_L08:
       mov       [rsp+28],rdi
       mov       rcx,[rbx+60]
       lea       r8,[rsp+28]
       mov       rdx,7FFB41D0FD58
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF5A10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L09:
       call      qword ptr [7FFB41ABEFD0]
       mov       ecx,65
       mov       rdx,7FFB4191C248
       call      qword ptr [7FFB4151F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417E5AC0
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4191C248
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CFC390]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CFC3A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       xor       r8d,r8d
       jmp       near ptr M00_L05
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
       jmp       near ptr M00_L04
M00_L13:
       mov       ecx,r10d
       jmp       near ptr M00_L04
M00_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L15:
       mov       rdx,rsi
       mov       r11,7FFB41460BF8
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L16:
       call      qword ptr [7FFB41ABEFD0]
       mov       ecx,245B
       mov       rdx,7FFB417E5AC0
       call      qword ptr [7FFB4151F228]
       mov       rdi,rax
       mov       ecx,191A
       mov       rdx,7FFB417E5AC0
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFB417E5AC0
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CFC390]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CFC3A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1174
```
```assembly
; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       sub       rsp,28
       mov       edx,[rcx+10]
       mov       rax,[rcx]
       cmp       edx,[rax+34]
       jne       short M01_L01
       mov       edx,[rcx+14]
       cmp       edx,[rax+28]
       jae       short M01_L03
M01_L00:
       mov       rdx,[rcx]
       mov       rdx,[rdx+10]
       mov       eax,[rcx+14]
       lea       r8d,[rax+1]
       mov       [rcx+14],r8d
       cmp       eax,[rdx+8]
       jae       short M01_L04
       shl       rax,4
       lea       rdx,[rdx+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M01_L02
       mov       rdx,[rdx]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFB4151FC60]
       int       3
M01_L02:
       mov       edx,[rcx+14]
       mov       rax,[rcx]
       cmp       edx,[rax+28]
       jb        short M01_L00
M01_L03:
       mov       rax,[rcx]
       mov       eax,[rax+28]
       inc       eax
       mov       [rcx+14],eax
       xor       eax,eax
       mov       [rcx+8],rax
       add       rsp,28
       ret
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return acquireLock ? this.AddInternalLocked(item, hashCode) : this.AddInternalUnlocked(item, hashCode);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       [rcx],ecx
       cmp       qword ptr [rbp+18],0
       je        near ptr M02_L06
       mov       rax,[rbp+18]
       mov       [rbp+18],rax
       test      r9b,r9b
       jne       near ptr M02_L10
       mov       ebx,r8d
       mov       rsi,[rcx+10]
       mov       r8,[rsi+8]
       mov       r10d,[r8+8]
       mov       rax,[rsi+10]
       mov       r9d,[rax+8]
       mov       eax,ebx
       and       eax,7FFFFFFF
       cdq
       idiv      r10d
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r9d
       mov       r14d,edx
       cmp       edi,[r8+8]
       jae       near ptr M02_L63
       mov       edx,edi
       mov       r15,[r8+rdx*8+10]
       test      r15,r15
       je        short M02_L02
M02_L00:
       cmp       ebx,[r15+18]
       je        near ptr M02_L07
M02_L01:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M02_L00
M02_L02:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M02_L05
M02_L03:
       mov       r15,rax
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r12,[rsi+8]
       mov       rcx,r12
       mov       edx,edi
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r15,rax
       cmp       edi,[r12+8]
       jae       near ptr M02_L63
       mov       ecx,edi
       mov       rdi,[r12+rcx*8+10]
       lea       rcx,[r13+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+18],ebx
       lea       rcx,[r13+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rsi+18]
       cmp       r14d,[rax+8]
       jae       near ptr M02_L63
       mov       edx,r14d
       lea       rax,[rax+rdx*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M02_L64
       mov       [rax],edx
       mov       eax,1
M02_L04:
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
M02_L05:
       mov       rcx,rdx
       mov       rdx,7FFB41CEBC40
       call      qword ptr [7FFB4151F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L03
M02_L06:
       call      qword ptr [7FFB41ABEFD0]
       mov       ecx,245B
       mov       rdx,7FFB417E5AC0
       call      qword ptr [7FFB4151F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417E5AC0
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFB417E5AC0
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CFC390]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CFC3A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L07:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+48]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rdx
       mov       rdx,7FFB41CEBEF8
       call      qword ptr [7FFB4151F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp+18]
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       je        near ptr M02_L01
       xor       eax,eax
       jmp       near ptr M02_L04
M02_L10:
       mov       [rbp-44],r8d
M02_L11:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       rax,[rbx+10]
       mov       r10d,[rax+8]
       mov       eax,[rbp-44]
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r10d
       mov       edi,edx
       mov       rdx,[rbx+10]
       cmp       edi,[rdx+8]
       jae       near ptr M02_L63
       mov       eax,edi
       mov       rdx,[rdx+rax*8+10]
       mov       [rbp-90],rdx
       mov       byte ptr [rbp-50],0
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41515998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M02_L23
       mov       r14d,[rbp-44]
       mov       rdx,[rbx+8]
       cmp       esi,[rdx+8]
       jae       near ptr M02_L18
       mov       eax,esi
       mov       r15,[rdx+rax*8+10]
       test      r15,r15
       je        short M02_L17
M02_L12:
       cmp       r14d,[r15+18]
       jne       short M02_L15
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+48]
       test      r11,r11
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rdx
       mov       rdx,7FFB41CEBEF8
       call      qword ptr [7FFB4151F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp+18]
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       short M02_L16
M02_L15:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M02_L12
       jmp       short M02_L17
M02_L16:
       xor       r15d,r15d
       xor       r13d,r13d
       jmp       near ptr M02_L22
M02_L17:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M02_L20
       jmp       short M02_L21
M02_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L20:
       mov       rcx,rdx
       mov       rdx,7FFB41CEBC40
       call      qword ptr [7FFB4151F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L21:
       mov       r15,rax
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r15,rax
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       short M02_L18
       mov       edx,esi
       mov       rsi,[rcx+rdx*8+10]
       lea       rcx,[r13+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+18],r14d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M02_L18
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M02_L19
       mov       [rcx],eax
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M02_L18
       mov       eax,edi
       mov       ecx,[rcx+rax*4+10]
       mov       rax,[rbp+10]
       cmp       ecx,[rax+18]
       setg      r13b
       movzx     r13d,r13b
       mov       r15d,1
       mov       rcx,[rbp+10]
M02_L22:
       movzx     esi,r13b
       cmp       byte ptr [rbp-50],0
       je        short M02_L24
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41516820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M02_L24
M02_L23:
       call      M02_L65
       jmp       near ptr M02_L11
M02_L24:
       test      esi,esi
       je        near ptr M02_L61
       xor       edx,edx
       mov       [rbp-54],edx
       mov       rdx,[rcx+10]
       mov       rsi,[rdx+10]
       xor       edi,edi
       test      edi,edi
       jg        short M02_L29
M02_L25:
       mov       byte ptr [rbp-60],0
       cmp       edi,[rsi+8]
       jae       short M02_L26
       mov       rcx,[rsi+rdi*8+10]
       lea       rdx,[rbp-60]
       call      qword ptr [7FFB41515998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       jmp       short M02_L27
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L27:
       cmp       byte ptr [rbp-60],0
       je        short M02_L28
       mov       edx,[rbp-54]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rbp-54],edx
M02_L28:
       add       edi,1
       jo        near ptr M02_L58
       test      edi,edi
       jle       short M02_L25
M02_L29:
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M02_L62
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M02_L31
M02_L30:
       mov       r8,[rbx+18]
       cmp       r9d,[r8+8]
       jae       near ptr M02_L57
       movsxd    r8,dword ptr [r8+r9*4+10]
       add       rdx,r8
       jo        near ptr M02_L58
       add       r9d,1
       jo        near ptr M02_L58
M02_L31:
       mov       r8,[rbx+18]
       mov       r8d,[r8+8]
       movsxd    rax,r9d
       cmp       r8,rax
       jg        short M02_L30
       mov       r9,[rbx+8]
       mov       r9d,[r9+8]
       shr       r9,2
       cmp       r9,rdx
       jle       short M02_L32
       movsxd    rdx,dword ptr [rcx+18]
       imul      rdx,2
       jo        near ptr M02_L58
       mov       r9d,7FFFFFFF
       cmp       rdx,7FFFFFFF
       cmovg     rdx,r9
       movsxd    r9,edx
       cmp       rdx,r9
       jne       near ptr M02_L58
       mov       [rcx+18],edx
       mov       edx,1
       test      edx,edx
       jne       near ptr M02_L62
M02_L32:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       mov       rcx,[rcx]
       lea       r9,[rbp-68]
       mov       r8d,7FEFFFFF
       call      qword ptr [7FFB41CFEA90]
       test      eax,eax
       jne       short M02_L33
       mov       esi,7FEFFFFF
       mov       edi,1
       jmp       short M02_L34
M02_L33:
       mov       esi,[rbp-68]
       xor       edi,edi
M02_L34:
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r13,[rdx+10]
       mov       r12d,1
       jmp       short M02_L39
M02_L35:
       mov       byte ptr [rbp-70],0
       cmp       r12d,[r13+8]
       jae       short M02_L36
       mov       rcx,[r13+r12*8+10]
       lea       rdx,[rbp-70]
       call      qword ptr [7FFB41515998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       jmp       short M02_L37
M02_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L37:
       cmp       byte ptr [rbp-70],0
       je        short M02_L38
       mov       edx,[rbp-54]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rbp-54],edx
M02_L38:
       add       r12d,1
       jo        near ptr M02_L58
M02_L39:
       cmp       r12d,r14d
       jl        short M02_L35
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+1C],0
       je        short M02_L40
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],400
       jl        short M02_L41
M02_L40:
       mov       r14,[rbx+10]
       jmp       near ptr M02_L44
M02_L41:
       mov       rdx,[rbx+10]
       mov       edx,[rdx+8]
       imul      rdx,2
       jo        near ptr M02_L58
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       ecx,[rcx+8]
       mov       [rsp+20],ecx
       mov       rcx,[rbx+10]
       mov       r8,r14
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFB41A3D518]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,[rbx+10]
       mov       r13d,[rcx+8]
       jmp       short M02_L43
M02_L42:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[r14+8]
       cmp       r13,rcx
       jae       near ptr M02_L57
       lea       rcx,[r14+r13*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r13,1
       jo        near ptr M02_L58
M02_L43:
       mov       ecx,[r14+8]
       cmp       rcx,r13
       jg        short M02_L42
M02_L44:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L45
       jmp       short M02_L46
M02_L45:
       mov       rcx,rdx
       mov       rdx,7FFB41CEB4E0
       call      qword ptr [7FFB4151F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L46:
       mov       rcx,rax
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       edx,[r14+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       rcx,[rbp+10]
       mov       r12,[rcx]
       xor       r8d,r8d
       jmp       near ptr M02_L52
M02_L47:
       mov       rax,[rbx+8]
       cmp       r8d,[rax+8]
       jae       near ptr M02_L57
       mov       [rbp-88],r8
       mov       r10,[rax+r8*8+10]
       test      r10,r10
       je        near ptr M02_L51
M02_L48:
       mov       r9,[r10+10]
       mov       [rbp-0A0],r9
       mov       [rbp-98],r10
       lea       rax,[r10+18]
       mov       r11d,[rsi+8]
       mov       edx,[r14+8]
       mov       [rbp-7C],edx
       mov       eax,[rax]
       and       eax,7FFFFFFF
       cdq
       idiv      r11d
       mov       r11d,edx
       mov       [rbp-74],r11d
       mov       eax,r11d
       cdq
       idiv      dword ptr [rbp-7C]
       mov       [rbp-78],edx
       mov       rdx,[r12+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M02_L49
       mov       rax,rdx
       jmp       short M02_L50
M02_L49:
       mov       rcx,r12
       mov       rdx,7FFB41CEBC40
       call      qword ptr [7FFB4151F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L50:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0A8],rax
       mov       r8,[rbp-98]
       mov       rdx,[r8+8]
       mov       r8d,[r8+18]
       mov       [rbp-80],r8d
       mov       r10d,[rbp-74]
       cmp       r10d,[rsi+8]
       jae       near ptr M02_L57
       mov       ecx,r10d
       mov       r9,[rsi+rcx*8+10]
       mov       [rbp-0B0],r9
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0A8]
       mov       ecx,[rbp-80]
       mov       [rax+18],ecx
       lea       rcx,[rax+10]
       mov       rdx,[rbp-0B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-74]
       mov       rcx,rsi
       mov       r8,[rbp-0A8]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       eax,[rbp-78]
       cmp       eax,[r13+8]
       jae       near ptr M02_L57
       lea       rax,[r13+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rax],edx
       mov       r8,[rbp-0A0]
       mov       rax,r8
       test      rax,rax
       mov       r10,rax
       jne       near ptr M02_L48
M02_L51:
       mov       r8,[rbp-88]
       add       r8d,1
       jo        near ptr M02_L58
       mov       rax,r8
M02_L52:
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       movsxd    rdx,r8d
       cmp       rax,rdx
       jg        near ptr M02_L47
       mov       eax,[rsi+8]
       mov       r8d,[r14+8]
       test      edi,edi
       jne       short M02_L53
       cdq
       idiv      r8d
       mov       edx,1
       cmp       eax,1
       cmovg     edx,eax
       jmp       short M02_L54
M02_L53:
       mov       edx,7FFFFFFF
M02_L54:
       mov       rcx,[rbp+10]
       mov       [rcx+18],edx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       test      rax,rax
       je        short M02_L55
       jmp       short M02_L56
M02_L55:
       mov       rcx,rdx
       mov       rdx,7FFB41CEB728
       call      qword ptr [7FFB4151F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L56:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       jmp       short M02_L62
M02_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L59:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       ebx,[rax+8]
       jae       short M02_L63
       mov       edx,ebx
       mov       rcx,[rax+rdx*8+10]
       call      qword ptr [7FFB41516820]; System.Threading.Monitor.Exit(System.Object)
       add       ebx,1
       jo        short M02_L64
       mov       rcx,[rbp+10]
M02_L60:
       cmp       ebx,[rbp-54]
       jl        short M02_L59
M02_L61:
       mov       eax,r15d
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
M02_L62:
       xor       eax,eax
       xor       ebx,ebx
       jmp       short M02_L60
M02_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L65:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M02_L66
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41516820]; System.Threading.Monitor.Exit(System.Object)
M02_L66:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-60],0
       je        short M02_L67
       mov       edx,[rbp-54]
       add       edx,1
       jo        short M02_L68
       mov       [rbp-54],edx
M02_L67:
       add       rsp,28
       ret
M02_L68:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-70],0
       je        short M02_L69
       mov       edx,[rbp-54]
       add       edx,1
       jo        short M02_L70
       mov       [rbp-54],edx
M02_L69:
       add       rsp,28
       ret
M02_L70:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r15d,r15d
       cmp       r15d,[rbp-54]
       jge       short M02_L72
M02_L71:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       r15d,[rax+8]
       jae       short M02_L73
       mov       edx,r15d
       mov       rcx,[rax+rdx*8+10]
       call      qword ptr [7FFB41516820]; System.Threading.Monitor.Exit(System.Object)
       add       r15d,1
       jo        short M02_L74
       cmp       r15d,[rbp-54]
       jl        short M02_L71
M02_L72:
       add       rsp,28
       ret
M02_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2496
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
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41515818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41515818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M04_L00:
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
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,1C2E2560008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L03:
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
M04_L04:
       call      qword ptr [7FFB41CFE3A0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
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
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,172EF801FB0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object[]
       mov       edx,0C
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
M00_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[r14+r15*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L17
       cmp       r15d,0C
       jl        short M00_L00
       mov       edx,0C
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       edx,1F
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       dword ptr [rdi+18],2
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L09
       mov       ecx,[rsi+34]
       mov       [rsp+30],rsi
       xor       edx,edx
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       mov       [rsp+44],edx
M00_L01:
       lea       rcx,[rsp+30]
       mov       rdx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      qword ptr [7FFB41CE5650]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L08
       mov       rsi,[rsp+38]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,[rdi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L15
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L10
       mov       rcx,172EF800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,9916D502
       mov       r8d,0AAD79E13
       cmp       edx,8
       jb        near ptr M00_L06
       mov       r10d,edx
       shr       r10d,3
M00_L02:
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
       jne       short M00_L02
       test      dl,4
       jne       short M00_L07
M00_L03:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L04:
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
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,edx
       rol       edx,9
       xor       edx,r8d
       rol       r8d,1B
       add       r8d,edx
       mov       eax,edx
       rol       eax,13
       xor       r8d,eax
M00_L05:
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r9d,r9d
       call      qword ptr [7FFB41CE57B8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       jmp       near ptr M00_L01
M00_L06:
       cmp       edx,4
       jb        near ptr M00_L11
M00_L07:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L03
M00_L08:
       mov       [rsp+28],rdi
       mov       rcx,[rbx+60]
       lea       r8,[rsp+28]
       mov       rdx,7FFB41CFF838
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CE58D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L09:
       call      qword ptr [7FFB41AAEE68]
       mov       ecx,65
       mov       rdx,7FFB4190C248
       call      qword ptr [7FFB4150F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4190C248
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CEC5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CEC600]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       xor       r8d,r8d
       jmp       near ptr M00_L05
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
       jmp       near ptr M00_L04
M00_L13:
       mov       ecx,r10d
       jmp       near ptr M00_L04
M00_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L15:
       mov       rdx,rsi
       mov       r11,7FFB41450BF8
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L16:
       call      qword ptr [7FFB41AAEE68]
       mov       ecx,245B
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rdi,rax
       mov       ecx,191A
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CEC5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CEC600]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1174
```
```assembly
; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       sub       rsp,28
       mov       edx,[rcx+10]
       mov       rax,[rcx]
       cmp       edx,[rax+34]
       jne       short M01_L01
       mov       edx,[rcx+14]
       cmp       edx,[rax+28]
       jae       short M01_L03
M01_L00:
       mov       rdx,[rcx]
       mov       rdx,[rdx+10]
       mov       eax,[rcx+14]
       lea       r8d,[rax+1]
       mov       [rcx+14],r8d
       cmp       eax,[rdx+8]
       jae       short M01_L04
       shl       rax,4
       lea       rdx,[rdx+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M01_L02
       mov       rdx,[rdx]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFB4150FC60]
       int       3
M01_L02:
       mov       edx,[rcx+14]
       mov       rax,[rcx]
       cmp       edx,[rax+28]
       jb        short M01_L00
M01_L03:
       mov       rax,[rcx]
       mov       eax,[rax+28]
       inc       eax
       mov       [rcx+14],eax
       xor       eax,eax
       mov       [rcx+8],rax
       add       rsp,28
       ret
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return acquireLock ? this.AddInternalLocked(item, hashCode) : this.AddInternalUnlocked(item, hashCode);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       [rcx],ecx
       cmp       qword ptr [rbp+18],0
       je        near ptr M02_L06
       mov       rax,[rbp+18]
       mov       [rbp+18],rax
       test      r9b,r9b
       jne       near ptr M02_L10
       mov       ebx,r8d
       mov       rsi,[rcx+10]
       mov       r8,[rsi+8]
       mov       r10d,[r8+8]
       mov       rax,[rsi+10]
       mov       r9d,[rax+8]
       mov       eax,ebx
       and       eax,7FFFFFFF
       cdq
       idiv      r10d
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r9d
       mov       r14d,edx
       cmp       edi,[r8+8]
       jae       near ptr M02_L63
       mov       edx,edi
       mov       r15,[r8+rdx*8+10]
       test      r15,r15
       je        short M02_L02
M02_L00:
       cmp       ebx,[r15+18]
       je        near ptr M02_L07
M02_L01:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M02_L00
M02_L02:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M02_L05
M02_L03:
       mov       r15,rax
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r12,[rsi+8]
       mov       rcx,r12
       mov       edx,edi
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r15,rax
       cmp       edi,[r12+8]
       jae       near ptr M02_L63
       mov       ecx,edi
       mov       rdi,[r12+rcx*8+10]
       lea       rcx,[r13+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+18],ebx
       lea       rcx,[r13+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rsi+18]
       cmp       r14d,[rax+8]
       jae       near ptr M02_L63
       mov       edx,r14d
       lea       rax,[rax+rdx*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M02_L64
       mov       [rax],edx
       mov       eax,1
M02_L04:
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
M02_L05:
       mov       rcx,rdx
       mov       rdx,7FFB41CDBB58
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L03
M02_L06:
       call      qword ptr [7FFB41AAEE68]
       mov       ecx,245B
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CEC5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CEC600]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L07:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+48]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rdx
       mov       rdx,7FFB41CDBE10
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp+18]
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       je        near ptr M02_L01
       xor       eax,eax
       jmp       near ptr M02_L04
M02_L10:
       mov       [rbp-44],r8d
M02_L11:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       rax,[rbx+10]
       mov       r10d,[rax+8]
       mov       eax,[rbp-44]
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r10d
       mov       edi,edx
       mov       rdx,[rbx+10]
       cmp       edi,[rdx+8]
       jae       near ptr M02_L63
       mov       eax,edi
       mov       rdx,[rdx+rax*8+10]
       mov       [rbp-90],rdx
       mov       byte ptr [rbp-50],0
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41505998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M02_L23
       mov       r14d,[rbp-44]
       mov       rdx,[rbx+8]
       cmp       esi,[rdx+8]
       jae       near ptr M02_L18
       mov       eax,esi
       mov       r15,[rdx+rax*8+10]
       test      r15,r15
       je        short M02_L17
M02_L12:
       cmp       r14d,[r15+18]
       jne       short M02_L15
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+48]
       test      r11,r11
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rdx
       mov       rdx,7FFB41CDBE10
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp+18]
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       short M02_L16
M02_L15:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M02_L12
       jmp       short M02_L17
M02_L16:
       xor       r15d,r15d
       xor       r13d,r13d
       jmp       near ptr M02_L22
M02_L17:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M02_L20
       jmp       short M02_L21
M02_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L20:
       mov       rcx,rdx
       mov       rdx,7FFB41CDBB58
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L21:
       mov       r15,rax
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r15,rax
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       short M02_L18
       mov       edx,esi
       mov       rsi,[rcx+rdx*8+10]
       lea       rcx,[r13+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+18],r14d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M02_L18
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M02_L19
       mov       [rcx],eax
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M02_L18
       mov       eax,edi
       mov       ecx,[rcx+rax*4+10]
       mov       rax,[rbp+10]
       cmp       ecx,[rax+18]
       setg      r13b
       movzx     r13d,r13b
       mov       r15d,1
       mov       rcx,[rbp+10]
M02_L22:
       movzx     esi,r13b
       cmp       byte ptr [rbp-50],0
       je        short M02_L24
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41506820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M02_L24
M02_L23:
       call      M02_L65
       jmp       near ptr M02_L11
M02_L24:
       test      esi,esi
       je        near ptr M02_L61
       xor       edx,edx
       mov       [rbp-54],edx
       mov       rdx,[rcx+10]
       mov       rsi,[rdx+10]
       xor       edi,edi
       test      edi,edi
       jg        short M02_L29
M02_L25:
       mov       byte ptr [rbp-60],0
       cmp       edi,[rsi+8]
       jae       short M02_L26
       mov       rcx,[rsi+rdi*8+10]
       lea       rdx,[rbp-60]
       call      qword ptr [7FFB41505998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       jmp       short M02_L27
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L27:
       cmp       byte ptr [rbp-60],0
       je        short M02_L28
       mov       edx,[rbp-54]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rbp-54],edx
M02_L28:
       add       edi,1
       jo        near ptr M02_L58
       test      edi,edi
       jle       short M02_L25
M02_L29:
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M02_L62
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M02_L31
M02_L30:
       mov       r8,[rbx+18]
       cmp       r9d,[r8+8]
       jae       near ptr M02_L57
       movsxd    r8,dword ptr [r8+r9*4+10]
       add       rdx,r8
       jo        near ptr M02_L58
       add       r9d,1
       jo        near ptr M02_L58
M02_L31:
       mov       r8,[rbx+18]
       mov       r8d,[r8+8]
       movsxd    rax,r9d
       cmp       r8,rax
       jg        short M02_L30
       mov       r9,[rbx+8]
       mov       r9d,[r9+8]
       shr       r9,2
       cmp       r9,rdx
       jle       short M02_L32
       movsxd    rdx,dword ptr [rcx+18]
       imul      rdx,2
       jo        near ptr M02_L58
       mov       r9d,7FFFFFFF
       cmp       rdx,7FFFFFFF
       cmovg     rdx,r9
       movsxd    r9,edx
       cmp       rdx,r9
       jne       near ptr M02_L58
       mov       [rcx+18],edx
       mov       edx,1
       test      edx,edx
       jne       near ptr M02_L62
M02_L32:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       mov       rcx,[rcx]
       lea       r9,[rbp-68]
       mov       r8d,7FEFFFFF
       call      qword ptr [7FFB41CEEA48]
       test      eax,eax
       jne       short M02_L33
       mov       esi,7FEFFFFF
       mov       edi,1
       jmp       short M02_L34
M02_L33:
       mov       esi,[rbp-68]
       xor       edi,edi
M02_L34:
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r13,[rdx+10]
       mov       r12d,1
       jmp       short M02_L39
M02_L35:
       mov       byte ptr [rbp-70],0
       cmp       r12d,[r13+8]
       jae       short M02_L36
       mov       rcx,[r13+r12*8+10]
       lea       rdx,[rbp-70]
       call      qword ptr [7FFB41505998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       jmp       short M02_L37
M02_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L37:
       cmp       byte ptr [rbp-70],0
       je        short M02_L38
       mov       edx,[rbp-54]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rbp-54],edx
M02_L38:
       add       r12d,1
       jo        near ptr M02_L58
M02_L39:
       cmp       r12d,r14d
       jl        short M02_L35
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+1C],0
       je        short M02_L40
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],400
       jl        short M02_L41
M02_L40:
       mov       r14,[rbx+10]
       jmp       near ptr M02_L44
M02_L41:
       mov       rdx,[rbx+10]
       mov       edx,[rdx+8]
       imul      rdx,2
       jo        near ptr M02_L58
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       ecx,[rcx+8]
       mov       [rsp+20],ecx
       mov       rcx,[rbx+10]
       mov       r8,r14
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFB41A2D518]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,[rbx+10]
       mov       r13d,[rcx+8]
       jmp       short M02_L43
M02_L42:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[r14+8]
       cmp       r13,rcx
       jae       near ptr M02_L57
       lea       rcx,[r14+r13*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r13,1
       jo        near ptr M02_L58
M02_L43:
       mov       ecx,[r14+8]
       cmp       rcx,r13
       jg        short M02_L42
M02_L44:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L45
       jmp       short M02_L46
M02_L45:
       mov       rcx,rdx
       mov       rdx,7FFB41CDB3F8
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L46:
       mov       rcx,rax
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       edx,[r14+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       rcx,[rbp+10]
       mov       r12,[rcx]
       xor       r8d,r8d
       jmp       near ptr M02_L52
M02_L47:
       mov       rax,[rbx+8]
       cmp       r8d,[rax+8]
       jae       near ptr M02_L57
       mov       [rbp-88],r8
       mov       r10,[rax+r8*8+10]
       test      r10,r10
       je        near ptr M02_L51
M02_L48:
       mov       r9,[r10+10]
       mov       [rbp-0A0],r9
       mov       [rbp-98],r10
       lea       rax,[r10+18]
       mov       r11d,[rsi+8]
       mov       edx,[r14+8]
       mov       [rbp-7C],edx
       mov       eax,[rax]
       and       eax,7FFFFFFF
       cdq
       idiv      r11d
       mov       r11d,edx
       mov       [rbp-74],r11d
       mov       eax,r11d
       cdq
       idiv      dword ptr [rbp-7C]
       mov       [rbp-78],edx
       mov       rdx,[r12+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M02_L49
       mov       rax,rdx
       jmp       short M02_L50
M02_L49:
       mov       rcx,r12
       mov       rdx,7FFB41CDBB58
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L50:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0A8],rax
       mov       r8,[rbp-98]
       mov       rdx,[r8+8]
       mov       r8d,[r8+18]
       mov       [rbp-80],r8d
       mov       r10d,[rbp-74]
       cmp       r10d,[rsi+8]
       jae       near ptr M02_L57
       mov       ecx,r10d
       mov       r9,[rsi+rcx*8+10]
       mov       [rbp-0B0],r9
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0A8]
       mov       ecx,[rbp-80]
       mov       [rax+18],ecx
       lea       rcx,[rax+10]
       mov       rdx,[rbp-0B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-74]
       mov       rcx,rsi
       mov       r8,[rbp-0A8]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       eax,[rbp-78]
       cmp       eax,[r13+8]
       jae       near ptr M02_L57
       lea       rax,[r13+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rax],edx
       mov       r8,[rbp-0A0]
       mov       rax,r8
       test      rax,rax
       mov       r10,rax
       jne       near ptr M02_L48
M02_L51:
       mov       r8,[rbp-88]
       add       r8d,1
       jo        near ptr M02_L58
       mov       rax,r8
M02_L52:
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       movsxd    rdx,r8d
       cmp       rax,rdx
       jg        near ptr M02_L47
       mov       eax,[rsi+8]
       mov       r8d,[r14+8]
       test      edi,edi
       jne       short M02_L53
       cdq
       idiv      r8d
       mov       edx,1
       cmp       eax,1
       cmovg     edx,eax
       jmp       short M02_L54
M02_L53:
       mov       edx,7FFFFFFF
M02_L54:
       mov       rcx,[rbp+10]
       mov       [rcx+18],edx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       test      rax,rax
       je        short M02_L55
       jmp       short M02_L56
M02_L55:
       mov       rcx,rdx
       mov       rdx,7FFB41CDB640
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L56:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       jmp       short M02_L62
M02_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L59:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       ebx,[rax+8]
       jae       short M02_L63
       mov       edx,ebx
       mov       rcx,[rax+rdx*8+10]
       call      qword ptr [7FFB41506820]; System.Threading.Monitor.Exit(System.Object)
       add       ebx,1
       jo        short M02_L64
       mov       rcx,[rbp+10]
M02_L60:
       cmp       ebx,[rbp-54]
       jl        short M02_L59
M02_L61:
       mov       eax,r15d
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
M02_L62:
       xor       eax,eax
       xor       ebx,ebx
       jmp       short M02_L60
M02_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L65:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M02_L66
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41506820]; System.Threading.Monitor.Exit(System.Object)
M02_L66:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-60],0
       je        short M02_L67
       mov       edx,[rbp-54]
       add       edx,1
       jo        short M02_L68
       mov       [rbp-54],edx
M02_L67:
       add       rsp,28
       ret
M02_L68:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-70],0
       je        short M02_L69
       mov       edx,[rbp-54]
       add       edx,1
       jo        short M02_L70
       mov       [rbp-54],edx
M02_L69:
       add       rsp,28
       ret
M02_L70:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r15d,r15d
       cmp       r15d,[rbp-54]
       jge       short M02_L72
M02_L71:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       r15d,[rax+8]
       jae       short M02_L73
       mov       edx,r15d
       mov       rcx,[rax+rdx*8+10]
       call      qword ptr [7FFB41506820]; System.Threading.Monitor.Exit(System.Object)
       add       r15d,1
       jo        short M02_L74
       cmp       r15d,[rbp-54]
       jl        short M02_L71
M02_L72:
       add       rsp,28
       ret
M02_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2496
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
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41505818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41505818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M04_L00:
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
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,1B384780008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L03:
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
M04_L04:
       call      qword ptr [7FFB41CEE358]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
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
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,122A6801FB0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object[]
       mov       edx,0C
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
M00_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[r14+r15*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L17
       cmp       r15d,0C
       jl        short M00_L00
       mov       edx,0C
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       edx,1F
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       dword ptr [rdi+18],2
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L09
       mov       ecx,[rsi+34]
       mov       [rsp+30],rsi
       xor       edx,edx
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       mov       [rsp+44],edx
       jmp       near ptr M00_L06
M00_L01:
       mov       r10d,edx
       shr       r10d,3
M00_L02:
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
       jne       short M00_L02
       test      dl,4
       jne       near ptr M00_L07
M00_L03:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L04:
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
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,edx
       rol       edx,9
       xor       edx,r8d
       rol       r8d,1B
       add       r8d,edx
       mov       eax,edx
       rol       eax,13
       xor       r8d,eax
M00_L05:
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r9d,r9d
       call      qword ptr [7FFB41CE57B8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
M00_L06:
       lea       rcx,[rsp+30]
       mov       rdx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      qword ptr [7FFB41CE5650]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L08
       mov       rsi,[rsp+38]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,[rdi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L15
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L10
       mov       rcx,122A6800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,537534BB
       mov       r8d,0CD62FCB3
       cmp       edx,8
       jae       near ptr M00_L01
       cmp       edx,4
       jb        near ptr M00_L11
M00_L07:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L03
M00_L08:
       mov       [rsp+28],rdi
       mov       rcx,[rbx+60]
       lea       r8,[rsp+28]
       mov       rdx,7FFB41CFF838
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CE58D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L09:
       call      qword ptr [7FFB41AAEF70]
       mov       ecx,65
       mov       rdx,7FFB4190C248
       call      qword ptr [7FFB4150F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4190C248
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CEC2E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CEC300]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       xor       r8d,r8d
       jmp       near ptr M00_L05
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
       jmp       near ptr M00_L04
M00_L13:
       mov       ecx,r10d
       jmp       near ptr M00_L04
M00_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L15:
       mov       rdx,rsi
       mov       r11,7FFB41450C00
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L16:
       call      qword ptr [7FFB41AAEF70]
       mov       ecx,245B
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rdi,rax
       mov       ecx,191A
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CEC2E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CEC300]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1178
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return acquireLock ? this.AddInternalLocked(item, hashCode) : this.AddInternalUnlocked(item, hashCode);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       [rcx],ecx
       cmp       qword ptr [rbp+18],0
       je        near ptr M01_L06
       mov       rax,[rbp+18]
       mov       [rbp+18],rax
       test      r9b,r9b
       jne       near ptr M01_L10
       mov       ebx,r8d
       mov       rsi,[rcx+10]
       mov       r8,[rsi+8]
       mov       r10d,[r8+8]
       mov       rax,[rsi+10]
       mov       r9d,[rax+8]
       mov       eax,ebx
       and       eax,7FFFFFFF
       cdq
       idiv      r10d
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r9d
       mov       r14d,edx
       cmp       edi,[r8+8]
       jae       near ptr M01_L63
       mov       edx,edi
       mov       r15,[r8+rdx*8+10]
       test      r15,r15
       je        short M01_L02
M01_L00:
       cmp       ebx,[r15+18]
       je        near ptr M01_L07
M01_L01:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M01_L00
M01_L02:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
M01_L03:
       mov       r15,rax
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r12,[rsi+8]
       mov       rcx,r12
       mov       edx,edi
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r15,rax
       cmp       edi,[r12+8]
       jae       near ptr M01_L63
       mov       ecx,edi
       mov       rdi,[r12+rcx*8+10]
       lea       rcx,[r13+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+18],ebx
       lea       rcx,[r13+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rsi+18]
       cmp       r14d,[rax+8]
       jae       near ptr M01_L63
       mov       edx,r14d
       lea       rax,[rax+rdx*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M01_L64
       mov       [rax],edx
       mov       eax,1
M01_L04:
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
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFB41CDBB58
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L03
M01_L06:
       call      qword ptr [7FFB41AAEF70]
       mov       ecx,245B
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CEC2E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CEC300]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L07:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+48]
       test      r11,r11
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdx
       mov       rdx,7FFB41CDBE10
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp+18]
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       je        near ptr M01_L01
       xor       eax,eax
       jmp       near ptr M01_L04
M01_L10:
       mov       [rbp-44],r8d
M01_L11:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       rax,[rbx+10]
       mov       r10d,[rax+8]
       mov       eax,[rbp-44]
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r10d
       mov       edi,edx
       mov       rdx,[rbx+10]
       cmp       edi,[rdx+8]
       jae       near ptr M01_L63
       mov       eax,edi
       mov       rdx,[rdx+rax*8+10]
       mov       [rbp-90],rdx
       mov       byte ptr [rbp-50],0
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41505998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L23
       mov       r14d,[rbp-44]
       mov       rdx,[rbx+8]
       cmp       esi,[rdx+8]
       jae       near ptr M01_L18
       mov       eax,esi
       mov       r15,[rdx+rax*8+10]
       test      r15,r15
       je        short M01_L17
M01_L12:
       cmp       r14d,[r15+18]
       jne       short M01_L15
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+48]
       test      r11,r11
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rdx
       mov       rdx,7FFB41CDBE10
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M01_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp+18]
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       short M01_L16
M01_L15:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M01_L12
       jmp       short M01_L17
M01_L16:
       xor       r15d,r15d
       xor       r13d,r13d
       jmp       near ptr M01_L22
M01_L17:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M01_L20
       jmp       short M01_L21
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L20:
       mov       rcx,rdx
       mov       rdx,7FFB41CDBB58
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M01_L21:
       mov       r15,rax
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r15,rax
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       short M01_L18
       mov       edx,esi
       mov       rsi,[rcx+rdx*8+10]
       lea       rcx,[r13+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+18],r14d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M01_L18
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M01_L19
       mov       [rcx],eax
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L18
       mov       eax,edi
       mov       ecx,[rcx+rax*4+10]
       mov       rax,[rbp+10]
       cmp       ecx,[rax+18]
       setg      r13b
       movzx     r13d,r13b
       mov       r15d,1
       mov       rcx,[rbp+10]
M01_L22:
       movzx     esi,r13b
       cmp       byte ptr [rbp-50],0
       je        short M01_L24
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41506820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M01_L24
M01_L23:
       call      M01_L65
       jmp       near ptr M01_L11
M01_L24:
       test      esi,esi
       je        near ptr M01_L61
       xor       edx,edx
       mov       [rbp-54],edx
       mov       rdx,[rcx+10]
       mov       rsi,[rdx+10]
       xor       edi,edi
       test      edi,edi
       jg        short M01_L29
M01_L25:
       mov       byte ptr [rbp-60],0
       cmp       edi,[rsi+8]
       jae       short M01_L26
       mov       rcx,[rsi+rdi*8+10]
       lea       rdx,[rbp-60]
       call      qword ptr [7FFB41505998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       jmp       short M01_L27
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L27:
       cmp       byte ptr [rbp-60],0
       je        short M01_L28
       mov       edx,[rbp-54]
       add       edx,1
       jo        near ptr M01_L58
       mov       [rbp-54],edx
M01_L28:
       add       edi,1
       jo        near ptr M01_L58
       test      edi,edi
       jle       short M01_L25
M01_L29:
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L62
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M01_L31
M01_L30:
       mov       r8,[rbx+18]
       cmp       r9d,[r8+8]
       jae       near ptr M01_L57
       movsxd    r8,dword ptr [r8+r9*4+10]
       add       rdx,r8
       jo        near ptr M01_L58
       add       r9d,1
       jo        near ptr M01_L58
M01_L31:
       mov       r8,[rbx+18]
       mov       r8d,[r8+8]
       movsxd    rax,r9d
       cmp       r8,rax
       jg        short M01_L30
       mov       r9,[rbx+8]
       mov       r9d,[r9+8]
       shr       r9,2
       cmp       r9,rdx
       jle       short M01_L32
       movsxd    rdx,dword ptr [rcx+18]
       imul      rdx,2
       jo        near ptr M01_L58
       mov       r9d,7FFFFFFF
       cmp       rdx,7FFFFFFF
       cmovg     rdx,r9
       movsxd    r9,edx
       cmp       rdx,r9
       jne       near ptr M01_L58
       mov       [rcx+18],edx
       mov       edx,1
       test      edx,edx
       jne       near ptr M01_L62
M01_L32:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       mov       rcx,[rcx]
       lea       r9,[rbp-68]
       mov       r8d,7FEFFFFF
       call      qword ptr [7FFB41CEE9B8]
       test      eax,eax
       jne       short M01_L33
       mov       esi,7FEFFFFF
       mov       edi,1
       jmp       short M01_L34
M01_L33:
       mov       esi,[rbp-68]
       xor       edi,edi
M01_L34:
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r13,[rdx+10]
       mov       r12d,1
       jmp       short M01_L39
M01_L35:
       mov       byte ptr [rbp-70],0
       cmp       r12d,[r13+8]
       jae       short M01_L36
       mov       rcx,[r13+r12*8+10]
       lea       rdx,[rbp-70]
       call      qword ptr [7FFB41505998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       jmp       short M01_L37
M01_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L37:
       cmp       byte ptr [rbp-70],0
       je        short M01_L38
       mov       edx,[rbp-54]
       add       edx,1
       jo        near ptr M01_L58
       mov       [rbp-54],edx
M01_L38:
       add       r12d,1
       jo        near ptr M01_L58
M01_L39:
       cmp       r12d,r14d
       jl        short M01_L35
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+1C],0
       je        short M01_L40
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],400
       jl        short M01_L41
M01_L40:
       mov       r14,[rbx+10]
       jmp       near ptr M01_L44
M01_L41:
       mov       rdx,[rbx+10]
       mov       edx,[rdx+8]
       imul      rdx,2
       jo        near ptr M01_L58
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       ecx,[rcx+8]
       mov       [rsp+20],ecx
       mov       rcx,[rbx+10]
       mov       r8,r14
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFB41A2D518]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,[rbx+10]
       mov       r13d,[rcx+8]
       jmp       short M01_L43
M01_L42:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[r14+8]
       cmp       r13,rcx
       jae       near ptr M01_L57
       lea       rcx,[r14+r13*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r13,1
       jo        near ptr M01_L58
M01_L43:
       mov       ecx,[r14+8]
       cmp       rcx,r13
       jg        short M01_L42
M01_L44:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M01_L45
       jmp       short M01_L46
M01_L45:
       mov       rcx,rdx
       mov       rdx,7FFB41CDB3F8
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M01_L46:
       mov       rcx,rax
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       edx,[r14+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       rcx,[rbp+10]
       mov       r12,[rcx]
       xor       r8d,r8d
       jmp       near ptr M01_L52
M01_L47:
       mov       rax,[rbx+8]
       cmp       r8d,[rax+8]
       jae       near ptr M01_L57
       mov       [rbp-88],r8
       mov       r10,[rax+r8*8+10]
       test      r10,r10
       je        near ptr M01_L51
M01_L48:
       mov       r9,[r10+10]
       mov       [rbp-0A0],r9
       mov       [rbp-98],r10
       lea       rax,[r10+18]
       mov       r11d,[rsi+8]
       mov       edx,[r14+8]
       mov       [rbp-7C],edx
       mov       eax,[rax]
       and       eax,7FFFFFFF
       cdq
       idiv      r11d
       mov       r11d,edx
       mov       [rbp-74],r11d
       mov       eax,r11d
       cdq
       idiv      dword ptr [rbp-7C]
       mov       [rbp-78],edx
       mov       rdx,[r12+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M01_L49
       mov       rax,rdx
       jmp       short M01_L50
M01_L49:
       mov       rcx,r12
       mov       rdx,7FFB41CDBB58
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M01_L50:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0A8],rax
       mov       r8,[rbp-98]
       mov       rdx,[r8+8]
       mov       r8d,[r8+18]
       mov       [rbp-80],r8d
       mov       r10d,[rbp-74]
       cmp       r10d,[rsi+8]
       jae       near ptr M01_L57
       mov       ecx,r10d
       mov       r9,[rsi+rcx*8+10]
       mov       [rbp-0B0],r9
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0A8]
       mov       ecx,[rbp-80]
       mov       [rax+18],ecx
       lea       rcx,[rax+10]
       mov       rdx,[rbp-0B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-74]
       mov       rcx,rsi
       mov       r8,[rbp-0A8]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       eax,[rbp-78]
       cmp       eax,[r13+8]
       jae       near ptr M01_L57
       lea       rax,[r13+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M01_L58
       mov       [rax],edx
       mov       r8,[rbp-0A0]
       mov       rax,r8
       test      rax,rax
       mov       r10,rax
       jne       near ptr M01_L48
M01_L51:
       mov       r8,[rbp-88]
       add       r8d,1
       jo        near ptr M01_L58
       mov       rax,r8
M01_L52:
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       movsxd    rdx,r8d
       cmp       rax,rdx
       jg        near ptr M01_L47
       mov       eax,[rsi+8]
       mov       r8d,[r14+8]
       test      edi,edi
       jne       short M01_L53
       cdq
       idiv      r8d
       mov       edx,1
       cmp       eax,1
       cmovg     edx,eax
       jmp       short M01_L54
M01_L53:
       mov       edx,7FFFFFFF
M01_L54:
       mov       rcx,[rbp+10]
       mov       [rcx+18],edx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       test      rax,rax
       je        short M01_L55
       jmp       short M01_L56
M01_L55:
       mov       rcx,rdx
       mov       rdx,7FFB41CDB640
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M01_L56:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       jmp       short M01_L62
M01_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L59:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       ebx,[rax+8]
       jae       short M01_L63
       mov       edx,ebx
       mov       rcx,[rax+rdx*8+10]
       call      qword ptr [7FFB41506820]; System.Threading.Monitor.Exit(System.Object)
       add       ebx,1
       jo        short M01_L64
       mov       rcx,[rbp+10]
M01_L60:
       cmp       ebx,[rbp-54]
       jl        short M01_L59
M01_L61:
       mov       eax,r15d
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
M01_L62:
       xor       eax,eax
       xor       ebx,ebx
       jmp       short M01_L60
M01_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L65:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M01_L66
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41506820]; System.Threading.Monitor.Exit(System.Object)
M01_L66:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-60],0
       je        short M01_L67
       mov       edx,[rbp-54]
       add       edx,1
       jo        short M01_L68
       mov       [rbp-54],edx
M01_L67:
       add       rsp,28
       ret
M01_L68:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-70],0
       je        short M01_L69
       mov       edx,[rbp-54]
       add       edx,1
       jo        short M01_L70
       mov       [rbp-54],edx
M01_L69:
       add       rsp,28
       ret
M01_L70:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r15d,r15d
       cmp       r15d,[rbp-54]
       jge       short M01_L72
M01_L71:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       r15d,[rax+8]
       jae       short M01_L73
       mov       edx,r15d
       mov       rcx,[rax+rdx*8+10]
       call      qword ptr [7FFB41506820]; System.Threading.Monitor.Exit(System.Object)
       add       r15d,1
       jo        short M01_L74
       cmp       r15d,[rbp-54]
       jl        short M01_L71
M01_L72:
       add       rsp,28
       ret
M01_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2496
```
```assembly
; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       sub       rsp,28
       mov       edx,[rcx+10]
       mov       rax,[rcx]
       cmp       edx,[rax+34]
       jne       short M02_L01
       mov       edx,[rcx+14]
       cmp       edx,[rax+28]
       jae       short M02_L03
M02_L00:
       mov       rdx,[rcx]
       mov       rdx,[rdx+10]
       mov       eax,[rcx+14]
       lea       r8d,[rax+1]
       mov       [rcx+14],r8d
       cmp       eax,[rdx+8]
       jae       short M02_L04
       shl       rax,4
       lea       rdx,[rdx+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M02_L02
       mov       rdx,[rdx]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       ret
M02_L01:
       call      qword ptr [7FFB4150FC60]
       int       3
M02_L02:
       mov       edx,[rcx+14]
       mov       rax,[rcx]
       cmp       edx,[rax+28]
       jb        short M02_L00
M02_L03:
       mov       rax,[rcx]
       mov       eax,[rax+28]
       inc       eax
       mov       [rcx+14],eax
       xor       eax,eax
       mov       [rcx+8],rax
       add       rsp,28
       ret
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 129
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
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41505818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41505818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M04_L00:
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
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,1633B710008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L03:
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
M04_L04:
       call      qword ptr [7FFB41CEE328]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
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
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,220A5C01FB0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object[]
       mov       edx,0C
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
M00_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[r14+r15*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L17
       cmp       r15d,0C
       jl        short M00_L00
       mov       edx,0C
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       edx,1F
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       dword ptr [rdi+18],2
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L09
       mov       ecx,[rsi+34]
       mov       [rsp+30],rsi
       xor       edx,edx
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       mov       [rsp+44],edx
M00_L01:
       lea       rcx,[rsp+30]
       mov       rdx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      qword ptr [7FFB41CF5770]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L08
       mov       rsi,[rsp+38]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,[rdi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L15
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L10
       mov       rcx,220A5C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,7F398571
       mov       r8d,47E0ED89
       cmp       edx,8
       jb        near ptr M00_L06
       mov       r10d,edx
       shr       r10d,3
M00_L02:
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
       jne       short M00_L02
       test      dl,4
       jne       short M00_L07
M00_L03:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L04:
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
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,edx
       rol       edx,9
       xor       edx,r8d
       rol       r8d,1B
       add       r8d,edx
       mov       eax,edx
       rol       eax,13
       xor       r8d,eax
M00_L05:
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r9d,r9d
       call      qword ptr [7FFB41CF58D8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       jmp       near ptr M00_L01
M00_L06:
       cmp       edx,4
       jb        near ptr M00_L11
M00_L07:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L03
M00_L08:
       mov       [rsp+28],rdi
       mov       rcx,[rbx+60]
       lea       r8,[rsp+28]
       mov       rdx,7FFB41D0FD88
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF59F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L09:
       call      qword ptr [7FFB41ABEF88]
       mov       ecx,65
       mov       rdx,7FFB4191C248
       call      qword ptr [7FFB4151F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417E5AC0
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4191C248
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CF5C50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CF5C68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       xor       r8d,r8d
       jmp       near ptr M00_L05
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
       jmp       near ptr M00_L04
M00_L13:
       mov       ecx,r10d
       jmp       near ptr M00_L04
M00_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L15:
       mov       rdx,rsi
       mov       r11,7FFB41460C00
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L16:
       call      qword ptr [7FFB41ABEF88]
       mov       ecx,245B
       mov       rdx,7FFB417E5AC0
       call      qword ptr [7FFB4151F228]
       mov       rdi,rax
       mov       ecx,191A
       mov       rdx,7FFB417E5AC0
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFB417E5AC0
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CF5C50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CF5C68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1174
```
```assembly
; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       sub       rsp,28
       mov       edx,[rcx+10]
       mov       rax,[rcx]
       cmp       edx,[rax+34]
       jne       short M01_L01
       mov       edx,[rcx+14]
       cmp       edx,[rax+28]
       jae       short M01_L03
M01_L00:
       mov       rdx,[rcx]
       mov       rdx,[rdx+10]
       mov       eax,[rcx+14]
       lea       r8d,[rax+1]
       mov       [rcx+14],r8d
       cmp       eax,[rdx+8]
       jae       short M01_L04
       shl       rax,4
       lea       rdx,[rdx+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M01_L02
       mov       rdx,[rdx]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFB4151FC60]
       int       3
M01_L02:
       mov       edx,[rcx+14]
       mov       rax,[rcx]
       cmp       edx,[rax+28]
       jb        short M01_L00
M01_L03:
       mov       rax,[rcx]
       mov       eax,[rax+28]
       inc       eax
       mov       [rcx+14],eax
       xor       eax,eax
       mov       [rcx+8],rax
       add       rsp,28
       ret
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return acquireLock ? this.AddInternalLocked(item, hashCode) : this.AddInternalUnlocked(item, hashCode);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       [rcx],ecx
       cmp       qword ptr [rbp+18],0
       je        near ptr M02_L06
       mov       rax,[rbp+18]
       mov       [rbp+18],rax
       test      r9b,r9b
       jne       near ptr M02_L10
       mov       ebx,r8d
       mov       rsi,[rcx+10]
       mov       r8,[rsi+8]
       mov       r10d,[r8+8]
       mov       rax,[rsi+10]
       mov       r9d,[rax+8]
       mov       eax,ebx
       and       eax,7FFFFFFF
       cdq
       idiv      r10d
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r9d
       mov       r14d,edx
       cmp       edi,[r8+8]
       jae       near ptr M02_L63
       mov       edx,edi
       mov       r15,[r8+rdx*8+10]
       test      r15,r15
       je        short M02_L02
M02_L00:
       cmp       ebx,[r15+18]
       je        near ptr M02_L07
M02_L01:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M02_L00
M02_L02:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M02_L05
M02_L03:
       mov       r15,rax
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r12,[rsi+8]
       mov       rcx,r12
       mov       edx,edi
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r15,rax
       cmp       edi,[r12+8]
       jae       near ptr M02_L63
       mov       ecx,edi
       mov       rdi,[r12+rcx*8+10]
       lea       rcx,[r13+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+18],ebx
       lea       rcx,[r13+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rsi+18]
       cmp       r14d,[rax+8]
       jae       near ptr M02_L63
       mov       edx,r14d
       lea       rax,[rax+rdx*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M02_L64
       mov       [rax],edx
       mov       eax,1
M02_L04:
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
M02_L05:
       mov       rcx,rdx
       mov       rdx,7FFB41CEBC40
       call      qword ptr [7FFB4151F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L03
M02_L06:
       call      qword ptr [7FFB41ABEF88]
       mov       ecx,245B
       mov       rdx,7FFB417E5AC0
       call      qword ptr [7FFB4151F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417E5AC0
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFB417E5AC0
       call      qword ptr [7FFB4151F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4151D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CF5C50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CF5C68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L07:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+48]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rdx
       mov       rdx,7FFB41CEBEF8
       call      qword ptr [7FFB4151F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp+18]
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       je        near ptr M02_L01
       xor       eax,eax
       jmp       near ptr M02_L04
M02_L10:
       mov       [rbp-44],r8d
M02_L11:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       rax,[rbx+10]
       mov       r10d,[rax+8]
       mov       eax,[rbp-44]
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r10d
       mov       edi,edx
       mov       rdx,[rbx+10]
       cmp       edi,[rdx+8]
       jae       near ptr M02_L63
       mov       eax,edi
       mov       rdx,[rdx+rax*8+10]
       mov       [rbp-90],rdx
       mov       byte ptr [rbp-50],0
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41515998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M02_L23
       mov       r14d,[rbp-44]
       mov       rdx,[rbx+8]
       cmp       esi,[rdx+8]
       jae       near ptr M02_L18
       mov       eax,esi
       mov       r15,[rdx+rax*8+10]
       test      r15,r15
       je        short M02_L17
M02_L12:
       cmp       r14d,[r15+18]
       jne       short M02_L15
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+48]
       test      r11,r11
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rdx
       mov       rdx,7FFB41CEBEF8
       call      qword ptr [7FFB4151F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp+18]
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       short M02_L16
M02_L15:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M02_L12
       jmp       short M02_L17
M02_L16:
       xor       r15d,r15d
       xor       r13d,r13d
       jmp       near ptr M02_L22
M02_L17:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M02_L20
       jmp       short M02_L21
M02_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L20:
       mov       rcx,rdx
       mov       rdx,7FFB41CEBC40
       call      qword ptr [7FFB4151F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L21:
       mov       r15,rax
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r15,rax
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       short M02_L18
       mov       edx,esi
       mov       rsi,[rcx+rdx*8+10]
       lea       rcx,[r13+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+18],r14d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M02_L18
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M02_L19
       mov       [rcx],eax
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M02_L18
       mov       eax,edi
       mov       ecx,[rcx+rax*4+10]
       mov       rax,[rbp+10]
       cmp       ecx,[rax+18]
       setg      r13b
       movzx     r13d,r13b
       mov       r15d,1
       mov       rcx,[rbp+10]
M02_L22:
       movzx     esi,r13b
       cmp       byte ptr [rbp-50],0
       je        short M02_L24
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41516820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M02_L24
M02_L23:
       call      M02_L65
       jmp       near ptr M02_L11
M02_L24:
       test      esi,esi
       je        near ptr M02_L61
       xor       edx,edx
       mov       [rbp-54],edx
       mov       rdx,[rcx+10]
       mov       rsi,[rdx+10]
       xor       edi,edi
       test      edi,edi
       jg        short M02_L29
M02_L25:
       mov       byte ptr [rbp-60],0
       cmp       edi,[rsi+8]
       jae       short M02_L26
       mov       rcx,[rsi+rdi*8+10]
       lea       rdx,[rbp-60]
       call      qword ptr [7FFB41515998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       jmp       short M02_L27
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L27:
       cmp       byte ptr [rbp-60],0
       je        short M02_L28
       mov       edx,[rbp-54]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rbp-54],edx
M02_L28:
       add       edi,1
       jo        near ptr M02_L58
       test      edi,edi
       jle       short M02_L25
M02_L29:
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M02_L62
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M02_L31
M02_L30:
       mov       r8,[rbx+18]
       cmp       r9d,[r8+8]
       jae       near ptr M02_L57
       movsxd    r8,dword ptr [r8+r9*4+10]
       add       rdx,r8
       jo        near ptr M02_L58
       add       r9d,1
       jo        near ptr M02_L58
M02_L31:
       mov       r8,[rbx+18]
       mov       r8d,[r8+8]
       movsxd    rax,r9d
       cmp       r8,rax
       jg        short M02_L30
       mov       r9,[rbx+8]
       mov       r9d,[r9+8]
       shr       r9,2
       cmp       r9,rdx
       jle       short M02_L32
       movsxd    rdx,dword ptr [rcx+18]
       imul      rdx,2
       jo        near ptr M02_L58
       mov       r9d,7FFFFFFF
       cmp       rdx,7FFFFFFF
       cmovg     rdx,r9
       movsxd    r9,edx
       cmp       rdx,r9
       jne       near ptr M02_L58
       mov       [rcx+18],edx
       mov       edx,1
       test      edx,edx
       jne       near ptr M02_L62
M02_L32:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       mov       rcx,[rcx]
       lea       r9,[rbp-68]
       mov       r8d,7FEFFFFF
       call      qword ptr [7FFB41CFEA78]
       test      eax,eax
       jne       short M02_L33
       mov       esi,7FEFFFFF
       mov       edi,1
       jmp       short M02_L34
M02_L33:
       mov       esi,[rbp-68]
       xor       edi,edi
M02_L34:
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r13,[rdx+10]
       mov       r12d,1
       jmp       short M02_L39
M02_L35:
       mov       byte ptr [rbp-70],0
       cmp       r12d,[r13+8]
       jae       short M02_L36
       mov       rcx,[r13+r12*8+10]
       lea       rdx,[rbp-70]
       call      qword ptr [7FFB41515998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       jmp       short M02_L37
M02_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L37:
       cmp       byte ptr [rbp-70],0
       je        short M02_L38
       mov       edx,[rbp-54]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rbp-54],edx
M02_L38:
       add       r12d,1
       jo        near ptr M02_L58
M02_L39:
       cmp       r12d,r14d
       jl        short M02_L35
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+1C],0
       je        short M02_L40
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],400
       jl        short M02_L41
M02_L40:
       mov       r14,[rbx+10]
       jmp       near ptr M02_L44
M02_L41:
       mov       rdx,[rbx+10]
       mov       edx,[rdx+8]
       imul      rdx,2
       jo        near ptr M02_L58
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       ecx,[rcx+8]
       mov       [rsp+20],ecx
       mov       rcx,[rbx+10]
       mov       r8,r14
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFB41A3D518]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,[rbx+10]
       mov       r13d,[rcx+8]
       jmp       short M02_L43
M02_L42:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[r14+8]
       cmp       r13,rcx
       jae       near ptr M02_L57
       lea       rcx,[r14+r13*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r13,1
       jo        near ptr M02_L58
M02_L43:
       mov       ecx,[r14+8]
       cmp       rcx,r13
       jg        short M02_L42
M02_L44:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L45
       jmp       short M02_L46
M02_L45:
       mov       rcx,rdx
       mov       rdx,7FFB41CEB4E0
       call      qword ptr [7FFB4151F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L46:
       mov       rcx,rax
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       edx,[r14+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       rcx,[rbp+10]
       mov       r12,[rcx]
       xor       r8d,r8d
       jmp       near ptr M02_L52
M02_L47:
       mov       rax,[rbx+8]
       cmp       r8d,[rax+8]
       jae       near ptr M02_L57
       mov       [rbp-88],r8
       mov       r10,[rax+r8*8+10]
       test      r10,r10
       je        near ptr M02_L51
M02_L48:
       mov       r9,[r10+10]
       mov       [rbp-0A0],r9
       mov       [rbp-98],r10
       lea       rax,[r10+18]
       mov       r11d,[rsi+8]
       mov       edx,[r14+8]
       mov       [rbp-7C],edx
       mov       eax,[rax]
       and       eax,7FFFFFFF
       cdq
       idiv      r11d
       mov       r11d,edx
       mov       [rbp-74],r11d
       mov       eax,r11d
       cdq
       idiv      dword ptr [rbp-7C]
       mov       [rbp-78],edx
       mov       rdx,[r12+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M02_L49
       mov       rax,rdx
       jmp       short M02_L50
M02_L49:
       mov       rcx,r12
       mov       rdx,7FFB41CEBC40
       call      qword ptr [7FFB4151F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L50:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0A8],rax
       mov       r8,[rbp-98]
       mov       rdx,[r8+8]
       mov       r8d,[r8+18]
       mov       [rbp-80],r8d
       mov       r10d,[rbp-74]
       cmp       r10d,[rsi+8]
       jae       near ptr M02_L57
       mov       ecx,r10d
       mov       r9,[rsi+rcx*8+10]
       mov       [rbp-0B0],r9
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0A8]
       mov       ecx,[rbp-80]
       mov       [rax+18],ecx
       lea       rcx,[rax+10]
       mov       rdx,[rbp-0B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-74]
       mov       rcx,rsi
       mov       r8,[rbp-0A8]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       eax,[rbp-78]
       cmp       eax,[r13+8]
       jae       near ptr M02_L57
       lea       rax,[r13+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rax],edx
       mov       r8,[rbp-0A0]
       mov       rax,r8
       test      rax,rax
       mov       r10,rax
       jne       near ptr M02_L48
M02_L51:
       mov       r8,[rbp-88]
       add       r8d,1
       jo        near ptr M02_L58
       mov       rax,r8
M02_L52:
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       movsxd    rdx,r8d
       cmp       rax,rdx
       jg        near ptr M02_L47
       mov       eax,[rsi+8]
       mov       r8d,[r14+8]
       test      edi,edi
       jne       short M02_L53
       cdq
       idiv      r8d
       mov       edx,1
       cmp       eax,1
       cmovg     edx,eax
       jmp       short M02_L54
M02_L53:
       mov       edx,7FFFFFFF
M02_L54:
       mov       rcx,[rbp+10]
       mov       [rcx+18],edx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       test      rax,rax
       je        short M02_L55
       jmp       short M02_L56
M02_L55:
       mov       rcx,rdx
       mov       rdx,7FFB41CEB728
       call      qword ptr [7FFB4151F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L56:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       jmp       short M02_L62
M02_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L59:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       ebx,[rax+8]
       jae       short M02_L63
       mov       edx,ebx
       mov       rcx,[rax+rdx*8+10]
       call      qword ptr [7FFB41516820]; System.Threading.Monitor.Exit(System.Object)
       add       ebx,1
       jo        short M02_L64
       mov       rcx,[rbp+10]
M02_L60:
       cmp       ebx,[rbp-54]
       jl        short M02_L59
M02_L61:
       mov       eax,r15d
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
M02_L62:
       xor       eax,eax
       xor       ebx,ebx
       jmp       short M02_L60
M02_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L65:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M02_L66
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41516820]; System.Threading.Monitor.Exit(System.Object)
M02_L66:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-60],0
       je        short M02_L67
       mov       edx,[rbp-54]
       add       edx,1
       jo        short M02_L68
       mov       [rbp-54],edx
M02_L67:
       add       rsp,28
       ret
M02_L68:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-70],0
       je        short M02_L69
       mov       edx,[rbp-54]
       add       edx,1
       jo        short M02_L70
       mov       [rbp-54],edx
M02_L69:
       add       rsp,28
       ret
M02_L70:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r15d,r15d
       cmp       r15d,[rbp-54]
       jge       short M02_L72
M02_L71:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       r15d,[rax+8]
       jae       short M02_L73
       mov       edx,r15d
       mov       rcx,[rax+rdx*8+10]
       call      qword ptr [7FFB41516820]; System.Threading.Monitor.Exit(System.Object)
       add       r15d,1
       jo        short M02_L74
       cmp       r15d,[rbp-54]
       jl        short M02_L71
M02_L72:
       add       rsp,28
       ret
M02_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2496
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
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41515818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41515818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M04_L00:
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
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,2613AB40008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L03:
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
M04_L04:
       call      qword ptr [7FFB41CFE370]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
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
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2702C401FB0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object[]
       mov       edx,0C
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
M00_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[r14+r15*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L17
       cmp       r15d,0C
       jl        short M00_L00
       mov       edx,0C
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       edx,1F
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       dword ptr [rdi+18],2
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L09
       mov       ecx,[rsi+34]
       mov       [rsp+30],rsi
       xor       edx,edx
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       mov       [rsp+44],edx
M00_L01:
       lea       rcx,[rsp+30]
       mov       rdx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      qword ptr [7FFB41D15680]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L08
       mov       rsi,[rsp+38]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,[rdi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L15
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L10
       mov       rcx,2702C400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0F3E93C7A
       mov       r8d,0BBC34A34
       cmp       edx,8
       jb        near ptr M00_L06
       mov       r10d,edx
       shr       r10d,3
M00_L02:
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
       jne       short M00_L02
       test      dl,4
       jne       short M00_L07
M00_L03:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L04:
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
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,edx
       rol       edx,9
       xor       edx,r8d
       rol       r8d,1B
       add       r8d,edx
       mov       eax,edx
       rol       eax,13
       xor       r8d,eax
M00_L05:
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r9d,r9d
       call      qword ptr [7FFB41D157E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       jmp       near ptr M00_L01
M00_L06:
       cmp       edx,4
       jb        near ptr M00_L11
M00_L07:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L03
M00_L08:
       mov       [rsp+28],rdi
       mov       rcx,[rbx+60]
       lea       r8,[rsp+28]
       mov       rdx,7FFB41D2F838
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D15908]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L09:
       call      qword ptr [7FFB41ADEF70]
       mov       ecx,65
       mov       rdx,7FFB4193C248
       call      qword ptr [7FFB4153F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB41805AC0
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4193C248
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D17090]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D170A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       xor       r8d,r8d
       jmp       near ptr M00_L05
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
       jmp       near ptr M00_L04
M00_L13:
       mov       ecx,r10d
       jmp       near ptr M00_L04
M00_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L15:
       mov       rdx,rsi
       mov       r11,7FFB41480BF8
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L16:
       call      qword ptr [7FFB41ADEF70]
       mov       ecx,245B
       mov       rdx,7FFB41805AC0
       call      qword ptr [7FFB4153F228]
       mov       rdi,rax
       mov       ecx,191A
       mov       rdx,7FFB41805AC0
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFB41805AC0
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D17090]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D170A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1174
```
```assembly
; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       sub       rsp,28
       mov       edx,[rcx+10]
       mov       rax,[rcx]
       cmp       edx,[rax+34]
       jne       short M01_L01
       mov       edx,[rcx+14]
       cmp       edx,[rax+28]
       jae       short M01_L03
M01_L00:
       mov       rdx,[rcx]
       mov       rdx,[rdx+10]
       mov       eax,[rcx+14]
       lea       r8d,[rax+1]
       mov       [rcx+14],r8d
       cmp       eax,[rdx+8]
       jae       short M01_L04
       shl       rax,4
       lea       rdx,[rdx+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M01_L02
       mov       rdx,[rdx]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFB4153FC60]
       int       3
M01_L02:
       mov       edx,[rcx+14]
       mov       rax,[rcx]
       cmp       edx,[rax+28]
       jb        short M01_L00
M01_L03:
       mov       rax,[rcx]
       mov       eax,[rax+28]
       inc       eax
       mov       [rcx+14],eax
       xor       eax,eax
       mov       [rcx+8],rax
       add       rsp,28
       ret
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return acquireLock ? this.AddInternalLocked(item, hashCode) : this.AddInternalUnlocked(item, hashCode);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       [rcx],ecx
       cmp       qword ptr [rbp+18],0
       je        near ptr M02_L06
       mov       rax,[rbp+18]
       mov       [rbp+18],rax
       test      r9b,r9b
       jne       near ptr M02_L10
       mov       ebx,r8d
       mov       rsi,[rcx+10]
       mov       r8,[rsi+8]
       mov       r10d,[r8+8]
       mov       rax,[rsi+10]
       mov       r9d,[rax+8]
       mov       eax,ebx
       and       eax,7FFFFFFF
       cdq
       idiv      r10d
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r9d
       mov       r14d,edx
       cmp       edi,[r8+8]
       jae       near ptr M02_L63
       mov       edx,edi
       mov       r15,[r8+rdx*8+10]
       test      r15,r15
       je        short M02_L02
M02_L00:
       cmp       ebx,[r15+18]
       je        near ptr M02_L07
M02_L01:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M02_L00
M02_L02:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M02_L05
M02_L03:
       mov       r15,rax
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r12,[rsi+8]
       mov       rcx,r12
       mov       edx,edi
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r15,rax
       cmp       edi,[r12+8]
       jae       near ptr M02_L63
       mov       ecx,edi
       mov       rdi,[r12+rcx*8+10]
       lea       rcx,[r13+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+18],ebx
       lea       rcx,[r13+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rsi+18]
       cmp       r14d,[rax+8]
       jae       near ptr M02_L63
       mov       edx,r14d
       lea       rax,[rax+rdx*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M02_L64
       mov       [rax],edx
       mov       eax,1
M02_L04:
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
M02_L05:
       mov       rcx,rdx
       mov       rdx,7FFB41D0BB58
       call      qword ptr [7FFB4153F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L03
M02_L06:
       call      qword ptr [7FFB41ADEF70]
       mov       ecx,245B
       mov       rdx,7FFB41805AC0
       call      qword ptr [7FFB4153F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB41805AC0
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFB41805AC0
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D17090]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D170A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L07:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+48]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rdx
       mov       rdx,7FFB41D0BE10
       call      qword ptr [7FFB4153F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp+18]
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       je        near ptr M02_L01
       xor       eax,eax
       jmp       near ptr M02_L04
M02_L10:
       mov       [rbp-44],r8d
M02_L11:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       rax,[rbx+10]
       mov       r10d,[rax+8]
       mov       eax,[rbp-44]
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r10d
       mov       edi,edx
       mov       rdx,[rbx+10]
       cmp       edi,[rdx+8]
       jae       near ptr M02_L63
       mov       eax,edi
       mov       rdx,[rdx+rax*8+10]
       mov       [rbp-90],rdx
       mov       byte ptr [rbp-50],0
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41535998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M02_L23
       mov       r14d,[rbp-44]
       mov       rdx,[rbx+8]
       cmp       esi,[rdx+8]
       jae       near ptr M02_L18
       mov       eax,esi
       mov       r15,[rdx+rax*8+10]
       test      r15,r15
       je        short M02_L17
M02_L12:
       cmp       r14d,[r15+18]
       jne       short M02_L15
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+48]
       test      r11,r11
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rdx
       mov       rdx,7FFB41D0BE10
       call      qword ptr [7FFB4153F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp+18]
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       short M02_L16
M02_L15:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M02_L12
       jmp       short M02_L17
M02_L16:
       xor       r15d,r15d
       xor       r13d,r13d
       jmp       near ptr M02_L22
M02_L17:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M02_L20
       jmp       short M02_L21
M02_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L20:
       mov       rcx,rdx
       mov       rdx,7FFB41D0BB58
       call      qword ptr [7FFB4153F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L21:
       mov       r15,rax
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r15,rax
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       short M02_L18
       mov       edx,esi
       mov       rsi,[rcx+rdx*8+10]
       lea       rcx,[r13+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+18],r14d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M02_L18
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M02_L19
       mov       [rcx],eax
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M02_L18
       mov       eax,edi
       mov       ecx,[rcx+rax*4+10]
       mov       rax,[rbp+10]
       cmp       ecx,[rax+18]
       setg      r13b
       movzx     r13d,r13b
       mov       r15d,1
       mov       rcx,[rbp+10]
M02_L22:
       movzx     esi,r13b
       cmp       byte ptr [rbp-50],0
       je        short M02_L24
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41536820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M02_L24
M02_L23:
       call      M02_L65
       jmp       near ptr M02_L11
M02_L24:
       test      esi,esi
       je        near ptr M02_L61
       xor       edx,edx
       mov       [rbp-54],edx
       mov       rdx,[rcx+10]
       mov       rsi,[rdx+10]
       xor       edi,edi
       test      edi,edi
       jg        short M02_L29
M02_L25:
       mov       byte ptr [rbp-60],0
       cmp       edi,[rsi+8]
       jae       short M02_L26
       mov       rcx,[rsi+rdi*8+10]
       lea       rdx,[rbp-60]
       call      qword ptr [7FFB41535998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       jmp       short M02_L27
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L27:
       cmp       byte ptr [rbp-60],0
       je        short M02_L28
       mov       edx,[rbp-54]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rbp-54],edx
M02_L28:
       add       edi,1
       jo        near ptr M02_L58
       test      edi,edi
       jle       short M02_L25
M02_L29:
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M02_L62
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M02_L31
M02_L30:
       mov       r8,[rbx+18]
       cmp       r9d,[r8+8]
       jae       near ptr M02_L57
       movsxd    r8,dword ptr [r8+r9*4+10]
       add       rdx,r8
       jo        near ptr M02_L58
       add       r9d,1
       jo        near ptr M02_L58
M02_L31:
       mov       r8,[rbx+18]
       mov       r8d,[r8+8]
       movsxd    rax,r9d
       cmp       r8,rax
       jg        short M02_L30
       mov       r9,[rbx+8]
       mov       r9d,[r9+8]
       shr       r9,2
       cmp       r9,rdx
       jle       short M02_L32
       movsxd    rdx,dword ptr [rcx+18]
       imul      rdx,2
       jo        near ptr M02_L58
       mov       r9d,7FFFFFFF
       cmp       rdx,7FFFFFFF
       cmovg     rdx,r9
       movsxd    r9,edx
       cmp       rdx,r9
       jne       near ptr M02_L58
       mov       [rcx+18],edx
       mov       edx,1
       test      edx,edx
       jne       near ptr M02_L62
M02_L32:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       mov       rcx,[rcx]
       lea       r9,[rbp-68]
       mov       r8d,7FEFFFFF
       call      qword ptr [7FFB41D1EA00]
       test      eax,eax
       jne       short M02_L33
       mov       esi,7FEFFFFF
       mov       edi,1
       jmp       short M02_L34
M02_L33:
       mov       esi,[rbp-68]
       xor       edi,edi
M02_L34:
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r13,[rdx+10]
       mov       r12d,1
       jmp       short M02_L39
M02_L35:
       mov       byte ptr [rbp-70],0
       cmp       r12d,[r13+8]
       jae       short M02_L36
       mov       rcx,[r13+r12*8+10]
       lea       rdx,[rbp-70]
       call      qword ptr [7FFB41535998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       jmp       short M02_L37
M02_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L37:
       cmp       byte ptr [rbp-70],0
       je        short M02_L38
       mov       edx,[rbp-54]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rbp-54],edx
M02_L38:
       add       r12d,1
       jo        near ptr M02_L58
M02_L39:
       cmp       r12d,r14d
       jl        short M02_L35
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+1C],0
       je        short M02_L40
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],400
       jl        short M02_L41
M02_L40:
       mov       r14,[rbx+10]
       jmp       near ptr M02_L44
M02_L41:
       mov       rdx,[rbx+10]
       mov       edx,[rdx+8]
       imul      rdx,2
       jo        near ptr M02_L58
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       ecx,[rcx+8]
       mov       [rsp+20],ecx
       mov       rcx,[rbx+10]
       mov       r8,r14
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFB41A5D518]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,[rbx+10]
       mov       r13d,[rcx+8]
       jmp       short M02_L43
M02_L42:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[r14+8]
       cmp       r13,rcx
       jae       near ptr M02_L57
       lea       rcx,[r14+r13*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r13,1
       jo        near ptr M02_L58
M02_L43:
       mov       ecx,[r14+8]
       cmp       rcx,r13
       jg        short M02_L42
M02_L44:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L45
       jmp       short M02_L46
M02_L45:
       mov       rcx,rdx
       mov       rdx,7FFB41D0B3F8
       call      qword ptr [7FFB4153F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L46:
       mov       rcx,rax
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       edx,[r14+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       rcx,[rbp+10]
       mov       r12,[rcx]
       xor       r8d,r8d
       jmp       near ptr M02_L52
M02_L47:
       mov       rax,[rbx+8]
       cmp       r8d,[rax+8]
       jae       near ptr M02_L57
       mov       [rbp-88],r8
       mov       r10,[rax+r8*8+10]
       test      r10,r10
       je        near ptr M02_L51
M02_L48:
       mov       r9,[r10+10]
       mov       [rbp-0A0],r9
       mov       [rbp-98],r10
       lea       rax,[r10+18]
       mov       r11d,[rsi+8]
       mov       edx,[r14+8]
       mov       [rbp-7C],edx
       mov       eax,[rax]
       and       eax,7FFFFFFF
       cdq
       idiv      r11d
       mov       r11d,edx
       mov       [rbp-74],r11d
       mov       eax,r11d
       cdq
       idiv      dword ptr [rbp-7C]
       mov       [rbp-78],edx
       mov       rdx,[r12+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M02_L49
       mov       rax,rdx
       jmp       short M02_L50
M02_L49:
       mov       rcx,r12
       mov       rdx,7FFB41D0BB58
       call      qword ptr [7FFB4153F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L50:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0A8],rax
       mov       r8,[rbp-98]
       mov       rdx,[r8+8]
       mov       r8d,[r8+18]
       mov       [rbp-80],r8d
       mov       r10d,[rbp-74]
       cmp       r10d,[rsi+8]
       jae       near ptr M02_L57
       mov       ecx,r10d
       mov       r9,[rsi+rcx*8+10]
       mov       [rbp-0B0],r9
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0A8]
       mov       ecx,[rbp-80]
       mov       [rax+18],ecx
       lea       rcx,[rax+10]
       mov       rdx,[rbp-0B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-74]
       mov       rcx,rsi
       mov       r8,[rbp-0A8]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       eax,[rbp-78]
       cmp       eax,[r13+8]
       jae       near ptr M02_L57
       lea       rax,[r13+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rax],edx
       mov       r8,[rbp-0A0]
       mov       rax,r8
       test      rax,rax
       mov       r10,rax
       jne       near ptr M02_L48
M02_L51:
       mov       r8,[rbp-88]
       add       r8d,1
       jo        near ptr M02_L58
       mov       rax,r8
M02_L52:
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       movsxd    rdx,r8d
       cmp       rax,rdx
       jg        near ptr M02_L47
       mov       eax,[rsi+8]
       mov       r8d,[r14+8]
       test      edi,edi
       jne       short M02_L53
       cdq
       idiv      r8d
       mov       edx,1
       cmp       eax,1
       cmovg     edx,eax
       jmp       short M02_L54
M02_L53:
       mov       edx,7FFFFFFF
M02_L54:
       mov       rcx,[rbp+10]
       mov       [rcx+18],edx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       test      rax,rax
       je        short M02_L55
       jmp       short M02_L56
M02_L55:
       mov       rcx,rdx
       mov       rdx,7FFB41D0B640
       call      qword ptr [7FFB4153F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L56:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       jmp       short M02_L62
M02_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L59:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       ebx,[rax+8]
       jae       short M02_L63
       mov       edx,ebx
       mov       rcx,[rax+rdx*8+10]
       call      qword ptr [7FFB41536820]; System.Threading.Monitor.Exit(System.Object)
       add       ebx,1
       jo        short M02_L64
       mov       rcx,[rbp+10]
M02_L60:
       cmp       ebx,[rbp-54]
       jl        short M02_L59
M02_L61:
       mov       eax,r15d
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
M02_L62:
       xor       eax,eax
       xor       ebx,ebx
       jmp       short M02_L60
M02_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L65:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M02_L66
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41536820]; System.Threading.Monitor.Exit(System.Object)
M02_L66:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-60],0
       je        short M02_L67
       mov       edx,[rbp-54]
       add       edx,1
       jo        short M02_L68
       mov       [rbp-54],edx
M02_L67:
       add       rsp,28
       ret
M02_L68:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-70],0
       je        short M02_L69
       mov       edx,[rbp-54]
       add       edx,1
       jo        short M02_L70
       mov       [rbp-54],edx
M02_L69:
       add       rsp,28
       ret
M02_L70:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r15d,r15d
       cmp       r15d,[rbp-54]
       jge       short M02_L72
M02_L71:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       r15d,[rax+8]
       jae       short M02_L73
       mov       edx,r15d
       mov       rcx,[rax+rdx*8+10]
       call      qword ptr [7FFB41536820]; System.Threading.Monitor.Exit(System.Object)
       add       r15d,1
       jo        short M02_L74
       cmp       r15d,[rbp-54]
       jl        short M02_L71
M02_L72:
       add       rsp,28
       ret
M02_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2496
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
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M04_L00:
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
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,2B0C11E0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L03:
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
M04_L04:
       call      qword ptr [7FFB41D1E370]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
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
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1A9F0C01FB0
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object[]
       mov       edx,0C
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
M00_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[r14+r15*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L17
       cmp       r15d,0C
       jl        short M00_L00
       mov       edx,0C
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       edx,1F
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       dword ptr [rdi+18],2
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L09
       mov       ecx,[rsi+34]
       mov       [rsp+30],rsi
       xor       edx,edx
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       mov       [rsp+44],edx
M00_L01:
       lea       rcx,[rsp+30]
       mov       rdx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      qword ptr [7FFB41CF6EE0]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L08
       mov       rsi,[rsp+38]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,[rdi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L15
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L10
       mov       rcx,1A9F0C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0FDF77934
       mov       r8d,17355BD5
       cmp       edx,8
       jb        near ptr M00_L06
       mov       r10d,edx
       shr       r10d,3
M00_L02:
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
       jne       short M00_L02
       test      dl,4
       jne       short M00_L07
M00_L03:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L04:
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
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,edx
       rol       edx,9
       xor       edx,r8d
       rol       r8d,1B
       add       r8d,edx
       mov       eax,edx
       rol       eax,13
       xor       r8d,eax
M00_L05:
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r9d,r9d
       call      qword ptr [7FFB41CF7048]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       jmp       near ptr M00_L01
M00_L06:
       cmp       edx,4
       jb        near ptr M00_L11
M00_L07:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L03
M00_L08:
       mov       [rsp+28],rdi
       mov       rcx,[rbx+60]
       lea       r8,[rsp+28]
       mov       rdx,7FFB41D30F50
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF7168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L09:
       call      qword ptr [7FFB41ACEF40]
       mov       ecx,65
       mov       rdx,7FFB4192C248
       call      qword ptr [7FFB4152F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417F5AC0
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4192C248
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CF73D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CF73F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       xor       r8d,r8d
       jmp       near ptr M00_L05
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
       jmp       near ptr M00_L04
M00_L13:
       mov       ecx,r10d
       jmp       near ptr M00_L04
M00_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L15:
       mov       rdx,rsi
       mov       r11,7FFB41470E28
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L16:
       call      qword ptr [7FFB41ACEF40]
       mov       ecx,245B
       mov       rdx,7FFB417F5AC0
       call      qword ptr [7FFB4152F228]
       mov       rdi,rax
       mov       ecx,191A
       mov       rdx,7FFB417F5AC0
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFB417F5AC0
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CF73D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CF73F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1174
```
```assembly
; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       sub       rsp,28
       mov       edx,[rcx+10]
       mov       rax,[rcx]
       cmp       edx,[rax+34]
       jne       short M01_L01
       mov       edx,[rcx+14]
       cmp       edx,[rax+28]
       jae       short M01_L03
M01_L00:
       mov       rdx,[rcx]
       mov       rdx,[rdx+10]
       mov       eax,[rcx+14]
       lea       r8d,[rax+1]
       mov       [rcx+14],r8d
       cmp       eax,[rdx+8]
       jae       short M01_L04
       shl       rax,4
       lea       rdx,[rdx+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M01_L02
       mov       rdx,[rdx]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFB4152FC60]
       int       3
M01_L02:
       mov       edx,[rcx+14]
       mov       rax,[rcx]
       cmp       edx,[rax+28]
       jb        short M01_L00
M01_L03:
       mov       rax,[rcx]
       mov       eax,[rax+28]
       inc       eax
       mov       [rcx+14],eax
       xor       eax,eax
       mov       [rcx+8],rax
       add       rsp,28
       ret
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return acquireLock ? this.AddInternalLocked(item, hashCode) : this.AddInternalUnlocked(item, hashCode);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       [rcx],ecx
       cmp       qword ptr [rbp+18],0
       je        near ptr M02_L06
       mov       rax,[rbp+18]
       mov       [rbp+18],rax
       test      r9b,r9b
       jne       near ptr M02_L10
       mov       ebx,r8d
       mov       rsi,[rcx+10]
       mov       r8,[rsi+8]
       mov       r10d,[r8+8]
       mov       rax,[rsi+10]
       mov       r9d,[rax+8]
       mov       eax,ebx
       and       eax,7FFFFFFF
       cdq
       idiv      r10d
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r9d
       mov       r14d,edx
       cmp       edi,[r8+8]
       jae       near ptr M02_L63
       mov       edx,edi
       mov       r15,[r8+rdx*8+10]
       test      r15,r15
       je        short M02_L02
M02_L00:
       cmp       ebx,[r15+18]
       je        near ptr M02_L07
M02_L01:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M02_L00
M02_L02:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M02_L05
M02_L03:
       mov       r15,rax
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r12,[rsi+8]
       mov       rcx,r12
       mov       edx,edi
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r15,rax
       cmp       edi,[r12+8]
       jae       near ptr M02_L63
       mov       ecx,edi
       mov       rdi,[r12+rcx*8+10]
       lea       rcx,[r13+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+18],ebx
       lea       rcx,[r13+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rsi+18]
       cmp       r14d,[rax+8]
       jae       near ptr M02_L63
       mov       edx,r14d
       lea       rax,[rax+rdx*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M02_L64
       mov       [rax],edx
       mov       eax,1
M02_L04:
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
M02_L05:
       mov       rcx,rdx
       mov       rdx,7FFB41D1DB88
       call      qword ptr [7FFB4152F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L03
M02_L06:
       call      qword ptr [7FFB41ACEF40]
       mov       ecx,245B
       mov       rdx,7FFB417F5AC0
       call      qword ptr [7FFB4152F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417F5AC0
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFB417F5AC0
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CF73D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CF73F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L07:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+48]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rdx
       mov       rdx,7FFB41D1DE40
       call      qword ptr [7FFB4152F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp+18]
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       je        near ptr M02_L01
       xor       eax,eax
       jmp       near ptr M02_L04
M02_L10:
       mov       [rbp-44],r8d
M02_L11:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       rax,[rbx+10]
       mov       r10d,[rax+8]
       mov       eax,[rbp-44]
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r10d
       mov       edi,edx
       mov       rdx,[rbx+10]
       cmp       edi,[rdx+8]
       jae       near ptr M02_L63
       mov       eax,edi
       mov       rdx,[rdx+rax*8+10]
       mov       [rbp-90],rdx
       mov       byte ptr [rbp-50],0
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41525998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M02_L23
       mov       r14d,[rbp-44]
       mov       rdx,[rbx+8]
       cmp       esi,[rdx+8]
       jae       near ptr M02_L18
       mov       eax,esi
       mov       r15,[rdx+rax*8+10]
       test      r15,r15
       je        short M02_L17
M02_L12:
       cmp       r14d,[r15+18]
       jne       short M02_L15
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+48]
       test      r11,r11
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rdx
       mov       rdx,7FFB41D1DE40
       call      qword ptr [7FFB4152F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp+18]
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       short M02_L16
M02_L15:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M02_L12
       jmp       short M02_L17
M02_L16:
       xor       r15d,r15d
       xor       r13d,r13d
       jmp       near ptr M02_L22
M02_L17:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M02_L20
       jmp       short M02_L21
M02_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L20:
       mov       rcx,rdx
       mov       rdx,7FFB41D1DB88
       call      qword ptr [7FFB4152F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L21:
       mov       r15,rax
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r15,rax
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       short M02_L18
       mov       edx,esi
       mov       rsi,[rcx+rdx*8+10]
       lea       rcx,[r13+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+18],r14d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M02_L18
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M02_L19
       mov       [rcx],eax
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M02_L18
       mov       eax,edi
       mov       ecx,[rcx+rax*4+10]
       mov       rax,[rbp+10]
       cmp       ecx,[rax+18]
       setg      r13b
       movzx     r13d,r13b
       mov       r15d,1
       mov       rcx,[rbp+10]
M02_L22:
       movzx     esi,r13b
       cmp       byte ptr [rbp-50],0
       je        short M02_L24
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41526820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M02_L24
M02_L23:
       call      M02_L65
       jmp       near ptr M02_L11
M02_L24:
       test      esi,esi
       je        near ptr M02_L61
       xor       edx,edx
       mov       [rbp-54],edx
       mov       rdx,[rcx+10]
       mov       rsi,[rdx+10]
       xor       edi,edi
       test      edi,edi
       jg        short M02_L29
M02_L25:
       mov       byte ptr [rbp-60],0
       cmp       edi,[rsi+8]
       jae       short M02_L26
       mov       rcx,[rsi+rdi*8+10]
       lea       rdx,[rbp-60]
       call      qword ptr [7FFB41525998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       jmp       short M02_L27
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L27:
       cmp       byte ptr [rbp-60],0
       je        short M02_L28
       mov       edx,[rbp-54]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rbp-54],edx
M02_L28:
       add       edi,1
       jo        near ptr M02_L58
       test      edi,edi
       jle       short M02_L25
M02_L29:
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M02_L62
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M02_L31
M02_L30:
       mov       r8,[rbx+18]
       cmp       r9d,[r8+8]
       jae       near ptr M02_L57
       movsxd    r8,dword ptr [r8+r9*4+10]
       add       rdx,r8
       jo        near ptr M02_L58
       add       r9d,1
       jo        near ptr M02_L58
M02_L31:
       mov       r8,[rbx+18]
       mov       r8d,[r8+8]
       movsxd    rax,r9d
       cmp       r8,rax
       jg        short M02_L30
       mov       r9,[rbx+8]
       mov       r9d,[r9+8]
       shr       r9,2
       cmp       r9,rdx
       jle       short M02_L32
       movsxd    rdx,dword ptr [rcx+18]
       imul      rdx,2
       jo        near ptr M02_L58
       mov       r9d,7FFFFFFF
       cmp       rdx,7FFFFFFF
       cmovg     rdx,r9
       movsxd    r9,edx
       cmp       rdx,r9
       jne       near ptr M02_L58
       mov       [rcx+18],edx
       mov       edx,1
       test      edx,edx
       jne       near ptr M02_L62
M02_L32:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       mov       rcx,[rcx]
       lea       r9,[rbp-68]
       mov       r8d,7FEFFFFF
       call      qword ptr [7FFB41CFF840]
       test      eax,eax
       jne       short M02_L33
       mov       esi,7FEFFFFF
       mov       edi,1
       jmp       short M02_L34
M02_L33:
       mov       esi,[rbp-68]
       xor       edi,edi
M02_L34:
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r13,[rdx+10]
       mov       r12d,1
       jmp       short M02_L39
M02_L35:
       mov       byte ptr [rbp-70],0
       cmp       r12d,[r13+8]
       jae       short M02_L36
       mov       rcx,[r13+r12*8+10]
       lea       rdx,[rbp-70]
       call      qword ptr [7FFB41525998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       jmp       short M02_L37
M02_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L37:
       cmp       byte ptr [rbp-70],0
       je        short M02_L38
       mov       edx,[rbp-54]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rbp-54],edx
M02_L38:
       add       r12d,1
       jo        near ptr M02_L58
M02_L39:
       cmp       r12d,r14d
       jl        short M02_L35
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+1C],0
       je        short M02_L40
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],400
       jl        short M02_L41
M02_L40:
       mov       r14,[rbx+10]
       jmp       near ptr M02_L44
M02_L41:
       mov       rdx,[rbx+10]
       mov       edx,[rdx+8]
       imul      rdx,2
       jo        near ptr M02_L58
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       ecx,[rcx+8]
       mov       [rsp+20],ecx
       mov       rcx,[rbx+10]
       mov       r8,r14
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFB41A4D518]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,[rbx+10]
       mov       r13d,[rcx+8]
       jmp       short M02_L43
M02_L42:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[r14+8]
       cmp       r13,rcx
       jae       near ptr M02_L57
       lea       rcx,[r14+r13*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r13,1
       jo        near ptr M02_L58
M02_L43:
       mov       ecx,[r14+8]
       cmp       rcx,r13
       jg        short M02_L42
M02_L44:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L45
       jmp       short M02_L46
M02_L45:
       mov       rcx,rdx
       mov       rdx,7FFB41D1D428
       call      qword ptr [7FFB4152F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L46:
       mov       rcx,rax
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       edx,[r14+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       rcx,[rbp+10]
       mov       r12,[rcx]
       xor       r8d,r8d
       jmp       near ptr M02_L52
M02_L47:
       mov       rax,[rbx+8]
       cmp       r8d,[rax+8]
       jae       near ptr M02_L57
       mov       [rbp-88],r8
       mov       r10,[rax+r8*8+10]
       test      r10,r10
       je        near ptr M02_L51
M02_L48:
       mov       r9,[r10+10]
       mov       [rbp-0A0],r9
       mov       [rbp-98],r10
       lea       rax,[r10+18]
       mov       r11d,[rsi+8]
       mov       edx,[r14+8]
       mov       [rbp-7C],edx
       mov       eax,[rax]
       and       eax,7FFFFFFF
       cdq
       idiv      r11d
       mov       r11d,edx
       mov       [rbp-74],r11d
       mov       eax,r11d
       cdq
       idiv      dword ptr [rbp-7C]
       mov       [rbp-78],edx
       mov       rdx,[r12+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M02_L49
       mov       rax,rdx
       jmp       short M02_L50
M02_L49:
       mov       rcx,r12
       mov       rdx,7FFB41D1DB88
       call      qword ptr [7FFB4152F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L50:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0A8],rax
       mov       r8,[rbp-98]
       mov       rdx,[r8+8]
       mov       r8d,[r8+18]
       mov       [rbp-80],r8d
       mov       r10d,[rbp-74]
       cmp       r10d,[rsi+8]
       jae       near ptr M02_L57
       mov       ecx,r10d
       mov       r9,[rsi+rcx*8+10]
       mov       [rbp-0B0],r9
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0A8]
       mov       ecx,[rbp-80]
       mov       [rax+18],ecx
       lea       rcx,[rax+10]
       mov       rdx,[rbp-0B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-74]
       mov       rcx,rsi
       mov       r8,[rbp-0A8]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       eax,[rbp-78]
       cmp       eax,[r13+8]
       jae       near ptr M02_L57
       lea       rax,[r13+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rax],edx
       mov       r8,[rbp-0A0]
       mov       rax,r8
       test      rax,rax
       mov       r10,rax
       jne       near ptr M02_L48
M02_L51:
       mov       r8,[rbp-88]
       add       r8d,1
       jo        near ptr M02_L58
       mov       rax,r8
M02_L52:
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       movsxd    rdx,r8d
       cmp       rax,rdx
       jg        near ptr M02_L47
       mov       eax,[rsi+8]
       mov       r8d,[r14+8]
       test      edi,edi
       jne       short M02_L53
       cdq
       idiv      r8d
       mov       edx,1
       cmp       eax,1
       cmovg     edx,eax
       jmp       short M02_L54
M02_L53:
       mov       edx,7FFFFFFF
M02_L54:
       mov       rcx,[rbp+10]
       mov       [rcx+18],edx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       test      rax,rax
       je        short M02_L55
       jmp       short M02_L56
M02_L55:
       mov       rcx,rdx
       mov       rdx,7FFB41D1D670
       call      qword ptr [7FFB4152F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L56:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       jmp       short M02_L62
M02_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L59:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       ebx,[rax+8]
       jae       short M02_L63
       mov       edx,ebx
       mov       rcx,[rax+rdx*8+10]
       call      qword ptr [7FFB41526820]; System.Threading.Monitor.Exit(System.Object)
       add       ebx,1
       jo        short M02_L64
       mov       rcx,[rbp+10]
M02_L60:
       cmp       ebx,[rbp-54]
       jl        short M02_L59
M02_L61:
       mov       eax,r15d
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
M02_L62:
       xor       eax,eax
       xor       ebx,ebx
       jmp       short M02_L60
M02_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L65:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M02_L66
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41526820]; System.Threading.Monitor.Exit(System.Object)
M02_L66:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-60],0
       je        short M02_L67
       mov       edx,[rbp-54]
       add       edx,1
       jo        short M02_L68
       mov       [rbp-54],edx
M02_L67:
       add       rsp,28
       ret
M02_L68:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-70],0
       je        short M02_L69
       mov       edx,[rbp-54]
       add       edx,1
       jo        short M02_L70
       mov       [rbp-54],edx
M02_L69:
       add       rsp,28
       ret
M02_L70:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r15d,r15d
       cmp       r15d,[rbp-54]
       jge       short M02_L72
M02_L71:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       r15d,[rax+8]
       jae       short M02_L73
       mov       edx,r15d
       mov       rcx,[rax+rdx*8+10]
       call      qword ptr [7FFB41526820]; System.Threading.Monitor.Exit(System.Object)
       add       r15d,1
       jo        short M02_L74
       cmp       r15d,[rbp-54]
       jl        short M02_L71
M02_L72:
       add       rsp,28
       ret
M02_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2496
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
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M04_L00:
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
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,1EA85CC0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L03:
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
M04_L04:
       call      qword ptr [7FFB41CFEB68]
       int       3
; Total bytes of code 244
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToConcurrentHashSet()
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
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,13725C01FE8
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object[]
       mov       edx,0C
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       xor       r15d,r15d
M00_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[r14+r15*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L17
       cmp       r15d,0C
       jl        short M00_L00
       mov       edx,0C
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       edx,1F
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+1C],1
       mov       dword ptr [rdi+18],2
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M00_L09
       mov       ecx,[rsi+34]
       mov       [rsp+30],rsi
       xor       edx,edx
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       mov       [rsp+44],edx
M00_L01:
       lea       rcx,[rsp+30]
       mov       rdx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      qword ptr [7FFB41D2DD10]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L08
       mov       rsi,[rsp+38]
       test      rsi,rsi
       je        near ptr M00_L16
       mov       rcx,[rdi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L15
       mov       rdx,[rsi+28]
       test      rdx,rdx
       je        near ptr M00_L10
       mov       rcx,13725C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0B2AB1867
       mov       r8d,22F02CE
       cmp       edx,8
       jb        near ptr M00_L06
       mov       r10d,edx
       shr       r10d,3
M00_L02:
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
       jne       short M00_L02
       test      dl,4
       jne       short M00_L07
M00_L03:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L04:
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
       mov       r8d,ecx
       rol       r8d,14
       add       r8d,edx
       rol       edx,9
       xor       edx,r8d
       rol       r8d,1B
       add       r8d,edx
       mov       eax,edx
       rol       eax,13
       xor       r8d,eax
M00_L05:
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r9d,r9d
       call      qword ptr [7FFB41D2DE78]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
       jmp       near ptr M00_L01
M00_L06:
       cmp       edx,4
       jb        near ptr M00_L11
M00_L07:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L03
M00_L08:
       mov       [rsp+28],rdi
       mov       rcx,[rbx+60]
       lea       r8,[rsp+28]
       mov       rdx,7FFB41D87010
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D2DF98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L09:
       call      qword ptr [7FFB41AAEF88]
       mov       ecx,65
       mov       rdx,7FFB4190C248
       call      qword ptr [7FFB4150F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4190C248
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41BE4E58]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41BE4E70]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       xor       r8d,r8d
       jmp       near ptr M00_L05
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
       jmp       near ptr M00_L04
M00_L13:
       mov       ecx,r10d
       jmp       near ptr M00_L04
M00_L14:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L15:
       mov       rdx,rsi
       mov       r11,7FFB41450F90
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L16:
       call      qword ptr [7FFB41AAEF88]
       mov       ecx,245B
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rdi,rax
       mov       ecx,191A
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41BE4E58]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41BE4E70]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1174
```
```assembly
; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       sub       rsp,28
       mov       edx,[rcx+10]
       mov       rax,[rcx]
       cmp       edx,[rax+34]
       jne       short M01_L01
       mov       edx,[rcx+14]
       cmp       edx,[rax+28]
       jae       short M01_L03
M01_L00:
       mov       rdx,[rcx]
       mov       rdx,[rdx+10]
       mov       eax,[rcx+14]
       lea       r8d,[rax+1]
       mov       [rcx+14],r8d
       cmp       eax,[rdx+8]
       jae       short M01_L04
       shl       rax,4
       lea       rdx,[rdx+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M01_L02
       mov       rdx,[rdx]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFB4150FC60]
       int       3
M01_L02:
       mov       edx,[rcx+14]
       mov       rax,[rcx]
       cmp       edx,[rax+28]
       jb        short M01_L00
M01_L03:
       mov       rax,[rcx]
       mov       eax,[rax+28]
       inc       eax
       mov       [rcx+14],eax
       xor       eax,eax
       mov       [rcx+8],rax
       add       rsp,28
       ret
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return acquireLock ? this.AddInternalLocked(item, hashCode) : this.AddInternalUnlocked(item, hashCode);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       [rcx],ecx
       cmp       qword ptr [rbp+18],0
       je        near ptr M02_L06
       mov       rax,[rbp+18]
       mov       [rbp+18],rax
       test      r9b,r9b
       jne       near ptr M02_L10
       mov       ebx,r8d
       mov       rsi,[rcx+10]
       mov       r8,[rsi+8]
       mov       r10d,[r8+8]
       mov       rax,[rsi+10]
       mov       r9d,[rax+8]
       mov       eax,ebx
       and       eax,7FFFFFFF
       cdq
       idiv      r10d
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r9d
       mov       r14d,edx
       cmp       edi,[r8+8]
       jae       near ptr M02_L63
       mov       edx,edi
       mov       r15,[r8+rdx*8+10]
       test      r15,r15
       je        short M02_L02
M02_L00:
       cmp       ebx,[r15+18]
       je        near ptr M02_L07
M02_L01:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M02_L00
M02_L02:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M02_L05
M02_L03:
       mov       r15,rax
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r12,[rsi+8]
       mov       rcx,r12
       mov       edx,edi
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r15,rax
       cmp       edi,[r12+8]
       jae       near ptr M02_L63
       mov       ecx,edi
       mov       rdi,[r12+rcx*8+10]
       lea       rcx,[r13+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+18],ebx
       lea       rcx,[r13+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rsi+18]
       cmp       r14d,[rax+8]
       jae       near ptr M02_L63
       mov       edx,r14d
       lea       rax,[rax+rdx*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M02_L64
       mov       [rax],edx
       mov       eax,1
M02_L04:
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
M02_L05:
       mov       rcx,rdx
       mov       rdx,7FFB41D91188
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L03
M02_L06:
       call      qword ptr [7FFB41AAEF88]
       mov       ecx,245B
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41BE4E58]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41BE4E70]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L07:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+48]
       test      r11,r11
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rdx
       mov       rdx,7FFB41D91440
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp+18]
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       je        near ptr M02_L01
       xor       eax,eax
       jmp       near ptr M02_L04
M02_L10:
       mov       [rbp-44],r8d
M02_L11:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       rax,[rbx+10]
       mov       r10d,[rax+8]
       mov       eax,[rbp-44]
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r10d
       mov       edi,edx
       mov       rdx,[rbx+10]
       cmp       edi,[rdx+8]
       jae       near ptr M02_L63
       mov       eax,edi
       mov       rdx,[rdx+rax*8+10]
       mov       [rbp-90],rdx
       mov       byte ptr [rbp-50],0
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41505998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M02_L23
       mov       r14d,[rbp-44]
       mov       rdx,[rbx+8]
       cmp       esi,[rdx+8]
       jae       near ptr M02_L18
       mov       eax,esi
       mov       r15,[rdx+rax*8+10]
       test      r15,r15
       je        short M02_L17
M02_L12:
       cmp       r14d,[r15+18]
       jne       short M02_L15
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+48]
       test      r11,r11
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rdx
       mov       rdx,7FFB41D91440
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp+18]
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       short M02_L16
M02_L15:
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M02_L12
       jmp       short M02_L17
M02_L16:
       xor       r15d,r15d
       xor       r13d,r13d
       jmp       near ptr M02_L22
M02_L17:
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M02_L20
       jmp       short M02_L21
M02_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L20:
       mov       rcx,rdx
       mov       rdx,7FFB41D91188
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L21:
       mov       r15,rax
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       r15,rax
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       short M02_L18
       mov       edx,esi
       mov       rsi,[rcx+rdx*8+10]
       lea       rcx,[r13+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r13+18],r14d
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M02_L18
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M02_L19
       mov       [rcx],eax
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M02_L18
       mov       eax,edi
       mov       ecx,[rcx+rax*4+10]
       mov       rax,[rbp+10]
       cmp       ecx,[rax+18]
       setg      r13b
       movzx     r13d,r13b
       mov       r15d,1
       mov       rcx,[rbp+10]
M02_L22:
       movzx     esi,r13b
       cmp       byte ptr [rbp-50],0
       je        short M02_L24
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41506820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M02_L24
M02_L23:
       call      M02_L65
       jmp       near ptr M02_L11
M02_L24:
       test      esi,esi
       je        near ptr M02_L61
       xor       edx,edx
       mov       [rbp-54],edx
       mov       rdx,[rcx+10]
       mov       rsi,[rdx+10]
       xor       edi,edi
       test      edi,edi
       jg        short M02_L29
M02_L25:
       mov       byte ptr [rbp-60],0
       cmp       edi,[rsi+8]
       jae       short M02_L26
       mov       rcx,[rsi+rdi*8+10]
       lea       rdx,[rbp-60]
       call      qword ptr [7FFB41505998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       jmp       short M02_L27
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L27:
       cmp       byte ptr [rbp-60],0
       je        short M02_L28
       mov       edx,[rbp-54]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rbp-54],edx
M02_L28:
       add       edi,1
       jo        near ptr M02_L58
       test      edi,edi
       jle       short M02_L25
M02_L29:
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M02_L62
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M02_L31
M02_L30:
       mov       r8,[rbx+18]
       cmp       r9d,[r8+8]
       jae       near ptr M02_L57
       movsxd    r8,dword ptr [r8+r9*4+10]
       add       rdx,r8
       jo        near ptr M02_L58
       add       r9d,1
       jo        near ptr M02_L58
M02_L31:
       mov       r8,[rbx+18]
       mov       r8d,[r8+8]
       movsxd    rax,r9d
       cmp       r8,rax
       jg        short M02_L30
       mov       r9,[rbx+8]
       mov       r9d,[r9+8]
       shr       r9,2
       cmp       r9,rdx
       jle       short M02_L32
       movsxd    rdx,dword ptr [rcx+18]
       imul      rdx,2
       jo        near ptr M02_L58
       mov       r9d,7FFFFFFF
       cmp       rdx,7FFFFFFF
       cmovg     rdx,r9
       movsxd    r9,edx
       cmp       rdx,r9
       jne       near ptr M02_L58
       mov       [rcx+18],edx
       mov       edx,1
       test      edx,edx
       jne       near ptr M02_L62
M02_L32:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       mov       rcx,[rcx]
       lea       r9,[rbp-68]
       mov       r8d,7FEFFFFF
       call      qword ptr [7FFB41D2F390]
       test      eax,eax
       jne       short M02_L33
       mov       esi,7FEFFFFF
       mov       edi,1
       jmp       short M02_L34
M02_L33:
       mov       esi,[rbp-68]
       xor       edi,edi
M02_L34:
       mov       rcx,[rbx+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       r13,[rdx+10]
       mov       r12d,1
       jmp       short M02_L39
M02_L35:
       mov       byte ptr [rbp-70],0
       cmp       r12d,[r13+8]
       jae       short M02_L36
       mov       rcx,[r13+r12*8+10]
       lea       rdx,[rbp-70]
       call      qword ptr [7FFB41505998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       jmp       short M02_L37
M02_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L37:
       cmp       byte ptr [rbp-70],0
       je        short M02_L38
       mov       edx,[rbp-54]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rbp-54],edx
M02_L38:
       add       r12d,1
       jo        near ptr M02_L58
M02_L39:
       cmp       r12d,r14d
       jl        short M02_L35
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+1C],0
       je        short M02_L40
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],400
       jl        short M02_L41
M02_L40:
       mov       r14,[rbx+10]
       jmp       near ptr M02_L44
M02_L41:
       mov       rdx,[rbx+10]
       mov       edx,[rdx+8]
       imul      rdx,2
       jo        near ptr M02_L58
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,[rbx+10]
       mov       ecx,[rcx+8]
       mov       [rsp+20],ecx
       mov       rcx,[rbx+10]
       mov       r8,r14
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFB41A2D518]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,[rbx+10]
       mov       r13d,[rcx+8]
       jmp       short M02_L43
M02_L42:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[r14+8]
       cmp       r13,rcx
       jae       near ptr M02_L57
       lea       rcx,[r14+r13*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r13,1
       jo        near ptr M02_L58
M02_L43:
       mov       ecx,[r14+8]
       cmp       rcx,r13
       jg        short M02_L42
M02_L44:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L45
       jmp       short M02_L46
M02_L45:
       mov       rcx,rdx
       mov       rdx,7FFB41D90A28
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L46:
       mov       rcx,rax
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       edx,[r14+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       rcx,[rbp+10]
       mov       r12,[rcx]
       xor       r8d,r8d
       jmp       near ptr M02_L52
M02_L47:
       mov       rax,[rbx+8]
       cmp       r8d,[rax+8]
       jae       near ptr M02_L57
       mov       [rbp-88],r8
       mov       r10,[rax+r8*8+10]
       test      r10,r10
       je        near ptr M02_L51
M02_L48:
       mov       r9,[r10+10]
       mov       [rbp-0A0],r9
       mov       [rbp-98],r10
       lea       rax,[r10+18]
       mov       r11d,[rsi+8]
       mov       edx,[r14+8]
       mov       [rbp-7C],edx
       mov       eax,[rax]
       and       eax,7FFFFFFF
       cdq
       idiv      r11d
       mov       r11d,edx
       mov       [rbp-74],r11d
       mov       eax,r11d
       cdq
       idiv      dword ptr [rbp-7C]
       mov       [rbp-78],edx
       mov       rdx,[r12+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M02_L49
       mov       rax,rdx
       jmp       short M02_L50
M02_L49:
       mov       rcx,r12
       mov       rdx,7FFB41D91188
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L50:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0A8],rax
       mov       r8,[rbp-98]
       mov       rdx,[r8+8]
       mov       r8d,[r8+18]
       mov       [rbp-80],r8d
       mov       r10d,[rbp-74]
       cmp       r10d,[rsi+8]
       jae       near ptr M02_L57
       mov       ecx,r10d
       mov       r9,[rsi+rcx*8+10]
       mov       [rbp-0B0],r9
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0A8]
       mov       ecx,[rbp-80]
       mov       [rax+18],ecx
       lea       rcx,[rax+10]
       mov       rdx,[rbp-0B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-74]
       mov       rcx,rsi
       mov       r8,[rbp-0A8]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       eax,[rbp-78]
       cmp       eax,[r13+8]
       jae       near ptr M02_L57
       lea       rax,[r13+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M02_L58
       mov       [rax],edx
       mov       r8,[rbp-0A0]
       mov       rax,r8
       test      rax,rax
       mov       r10,rax
       jne       near ptr M02_L48
M02_L51:
       mov       r8,[rbp-88]
       add       r8d,1
       jo        near ptr M02_L58
       mov       rax,r8
M02_L52:
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       movsxd    rdx,r8d
       cmp       rax,rdx
       jg        near ptr M02_L47
       mov       eax,[rsi+8]
       mov       r8d,[r14+8]
       test      edi,edi
       jne       short M02_L53
       cdq
       idiv      r8d
       mov       edx,1
       cmp       eax,1
       cmovg     edx,eax
       jmp       short M02_L54
M02_L53:
       mov       edx,7FFFFFFF
M02_L54:
       mov       rcx,[rbp+10]
       mov       [rcx+18],edx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       test      rax,rax
       je        short M02_L55
       jmp       short M02_L56
M02_L55:
       mov       rcx,rdx
       mov       rdx,7FFB41D90C70
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L56:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       jmp       short M02_L62
M02_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L59:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       ebx,[rax+8]
       jae       short M02_L63
       mov       edx,ebx
       mov       rcx,[rax+rdx*8+10]
       call      qword ptr [7FFB41506820]; System.Threading.Monitor.Exit(System.Object)
       add       ebx,1
       jo        short M02_L64
       mov       rcx,[rbp+10]
M02_L60:
       cmp       ebx,[rbp-54]
       jl        short M02_L59
M02_L61:
       mov       eax,r15d
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
M02_L62:
       xor       eax,eax
       xor       ebx,ebx
       jmp       short M02_L60
M02_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L65:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M02_L66
       mov       rcx,[rbp-90]
       call      qword ptr [7FFB41506820]; System.Threading.Monitor.Exit(System.Object)
M02_L66:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-60],0
       je        short M02_L67
       mov       edx,[rbp-54]
       add       edx,1
       jo        short M02_L68
       mov       [rbp-54],edx
M02_L67:
       add       rsp,28
       ret
M02_L68:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-70],0
       je        short M02_L69
       mov       edx,[rbp-54]
       add       edx,1
       jo        short M02_L70
       mov       [rbp-54],edx
M02_L69:
       add       rsp,28
       ret
M02_L70:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r15d,r15d
       cmp       r15d,[rbp-54]
       jge       short M02_L72
M02_L71:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       r15d,[rax+8]
       jae       short M02_L73
       mov       edx,r15d
       mov       rcx,[rax+rdx*8+10]
       call      qword ptr [7FFB41506820]; System.Threading.Monitor.Exit(System.Object)
       add       r15d,1
       jo        short M02_L74
       cmp       r15d,[rbp-54]
       jl        short M02_L71
M02_L72:
       add       rsp,28
       ret
M02_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2496
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
       je        near ptr M04_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M04_L00
       test      rbx,rbx
       je        near ptr M04_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M04_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41505818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41505818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L00:
       test      rbx,rbx
       je        short M04_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L02
M04_L01:
       mov       rax,177BADC0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L04:
       call      qword ptr [7FFB41D2E778]
       int       3
; Total bytes of code 235
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,138
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+0C0],ymm4
       vmovdqu   ymmword ptr [rsp+0E0],ymm4
       vmovdqu   ymmword ptr [rsp+100],ymm4
       vmovdqa   xmmword ptr [rsp+120],xmm4
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L32
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L33
       mov       rcx,rsi
       mov       r11,7FFB41470C18
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB41DCA5B0],1
       je        near ptr M00_L34
M00_L00:
       mov       rdx,226C8C02AD8
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB41470C20
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L35
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       rcx,226C8C02A20
       mov       rbp,[rcx]
       mov       r14,[rbp+10]
       mov       r15,[rbp+8]
       mov       r13,[rbp+18]
       xor       r12d,r12d
       xor       eax,eax
       inc       edi
M00_L04:
       dec       edi
       je        near ptr M00_L27
       mov       [rsp+0B8],rax
       mov       r8,[rsi+rax]
       mov       [rsp+0B0],r8
       test      r8,r8
       je        short M00_L05
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FFB41470C28
       call      qword ptr [r11]
       mov       r10d,eax
       mov       r8,[rsp+0B0]
       jmp       short M00_L06
M00_L05:
       xor       ecx,ecx
       xor       r10d,r10d
M00_L06:
       mov       [rsp+134],r10d
       cmp       [r14],r14b
       mov       rcx,r14
       cmp       qword ptr [r14+8],0
       jne       near ptr M00_L31
M00_L07:
       xor       r9d,r9d
       xor       r11d,r11d
M00_L08:
       mov       [rsp+68],r11
       test      r11,r11
       jne       near ptr M00_L37
       xor       edx,edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+100],xmm0
       mov       [rsp+100],r8
       mov       rcx,226C8C02A48
       mov       rcx,[rcx]
       mov       [rsp+108],rcx
       mov       rcx,[rsp+100]
       mov       r11,[rsp+108]
M00_L09:
       test      edx,edx
       jne       near ptr M00_L25
       test      r11,r11
       je        near ptr M00_L41
       test      r13,r13
       je        near ptr M00_L49
       xor       r8d,r8d
       mov       [rsp+0F8],r8d
       cmp       qword ptr [r14+8],0
       je        near ptr M00_L26
       mov       r9,r14
       mov       r10d,[rsp+134]
       cmp       r10d,[r9+18]
       jg        near ptr M00_L15
       cmp       r10d,[r9+18]
       jge       near ptr M00_L46
       mov       [rsp+0A8],r9
       mov       r8,[r9+8]
       mov       [rsp+0D0],rcx
       mov       [rsp+0D8],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+0F8]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+0F0]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+0D0]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D05B30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+0F0],0
       je        short M00_L13
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L44
       test      rax,rax
       je        short M00_L10
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L10:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L14
M00_L11:
       add       ecx,1
       jo        near ptr M00_L51
       cmp       ecx,0FF
       ja        near ptr M00_L51
       mov       [r14+1D],cl
       mov       r9,r14
M00_L12:
       mov       r14,r9
       mov       [rsp+0A8],r14
M00_L13:
       cmp       byte ptr [rsp+0F0],0
       je        near ptr M00_L48
       mov       r14,[rsp+0A8]
       test      r14,r14
       je        near ptr M00_L50
       mov       rdx,[r14+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       edx,ecx
       cmp       edx,2
       jl        near ptr M00_L20
       mov       rdx,[r14+10]
       test      rdx,rdx
       je        near ptr M00_L50
       mov       rcx,[rdx+10]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       ecx,edx
       js        near ptr M00_L23
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41D05BD8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M00_L24
M00_L14:
       mov       ecx,eax
       jmp       near ptr M00_L11
M00_L15:
       mov       [rsp+0A8],r9
       mov       r8,[r9+10]
       mov       [rsp+0D0],rcx
       mov       [rsp+0D8],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+0F8]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+0F0]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+0D0]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D05B30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+0F0],0
       je        near ptr M00_L13
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L42
       test      rax,rax
       je        short M00_L16
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L16:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        short M00_L19
M00_L17:
       add       ecx,1
       jo        near ptr M00_L51
       cmp       ecx,0FF
       ja        near ptr M00_L51
       mov       [r14+1D],cl
       mov       r9,r14
M00_L18:
       mov       r14,r9
       mov       [rsp+0A8],r14
       jmp       near ptr M00_L13
M00_L19:
       mov       ecx,eax
       jmp       short M00_L17
M00_L20:
       cmp       edx,0FFFFFFFE
       jle       short M00_L21
       mov       rax,r14
       jmp       short M00_L24
M00_L21:
       mov       rdx,[r14+8]
       test      rdx,rdx
       je        near ptr M00_L50
       mov       rcx,[rdx+10]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       ecx,edx
       test      ecx,ecx
       jle       short M00_L22
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41D05C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M00_L24
M00_L22:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41D05C08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M00_L24
M00_L23:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41D05BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M00_L24:
       mov       r14,rax
       inc       r12d
M00_L25:
       mov       rax,[rsp+0B8]
       add       rax,8
       jmp       near ptr M00_L04
M00_L26:
       mov       [rsp+58],r11
       mov       [rsp+60],rcx
       mov       dword ptr [rsp+0F0],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+98],rax
       mov       r8d,[rsp+134]
       mov       [rax+18],r8d
       lea       rcx,[rax+20]
       mov       rdx,[rsp+60]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+98]
       lea       rcx,[rax+28]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+98]
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+98]
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+98]
       mov       byte ptr [rax+1C],0
       movzx     r8d,byte ptr [r14+1D]
       add       r8d,1
       jo        near ptr M00_L51
       cmp       r8d,0FF
       ja        near ptr M00_L51
       mov       [rax+1D],r8b
       jmp       near ptr M00_L24
M00_L27:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+120],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+120]
       mov       r9d,r12d
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFB41D0EEC8]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       mov       rsi,[rsp+120]
       mov       edi,[rsp+128]
       mov       r14d,[rsp+12C]
       mov       rdx,rbp
       mov       rcx,7FFB41DCA750
       mov       r8,2675DDB15E8
       call      qword ptr [7FFB41D059C8]; System.Collections.Immutable.Requires.NotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String)
       mov       r8d,edi
       test      r14d,r14d
       jne       short M00_L28
       mov       r8d,edi
       add       r8d,[rbp+20]
M00_L28:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFB41D05C38]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32)
       mov       [rsp+0E0],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+0E0]
       mov       rdx,7FFB41D3D038
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D05C98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,138
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L29:
       mov       rcx,[rcx+8]
M00_L30:
       cmp       qword ptr [rcx+8],0
       je        near ptr M00_L07
       mov       r10d,[rsp+134]
M00_L31:
       mov       edx,[rcx+18]
       cmp       r10d,edx
       je        near ptr M00_L36
       jle       short M00_L29
       mov       rcx,[rcx+10]
       jmp       short M00_L30
M00_L32:
       call      qword ptr [7FFB41ACEFD0]
       mov       ecx,65
       mov       rdx,7FFB4192C248
       call      qword ptr [7FFB4152F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417F5AC0
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4192C248
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D0C600]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D0C618]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L33:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L35:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L36:
       mov       r9,[rcx+20]
       mov       r11,[rcx+28]
       jmp       near ptr M00_L08
M00_L37:
       mov       rcx,r15
       mov       [rsp+70],r9
       mov       r8,r9
       mov       rdx,[rsp+0B0]
       mov       r11,7FFB41470C30
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L38
       mov       [rsp+20],r15
       mov       r11,[rsp+68]
       mov       r9d,[r11+20]
       mov       [rsp+68],r11
       mov       rcx,r11
       mov       rdx,[rsp+0B0]
       xor       r8d,r8d
       call      qword ptr [7FFB41D0ECB8]
       test      eax,eax
       jl        short M00_L39
M00_L38:
       mov       ecx,1
       mov       rax,[rsp+70]
       mov       r10,[rsp+68]
       mov       edx,ecx
       mov       rcx,rax
       mov       r11,r10
       jmp       near ptr M00_L09
M00_L39:
       xor       edx,edx
       mov       [rsp+130],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+110],xmm0
       mov       rcx,[rsp+68]
       mov       rdx,[rsp+0B0]
       call      qword ptr [7FFB41D0ECD0]
       mov       rcx,[rsp+70]
       mov       [rsp+110],rcx
       test      rax,rax
       jne       short M00_L40
       mov       rax,226C8C02A48
       mov       rax,[rax]
M00_L40:
       mov       [rsp+118],rax
       mov       rcx,[rsp+110]
       mov       rax,rcx
       mov       r11,[rsp+118]
       mov       r10,r11
       mov       rcx,rax
       mov       r11,r10
       mov       edx,[rsp+130]
       jmp       near ptr M00_L09
M00_L41:
       mov       r10d,[rsp+134]
       lea       r8,[rsp+0F8]
       mov       rcx,r14
       mov       edx,r10d
       call      qword ptr [7FFB41D0EEB0]
       jmp       near ptr M00_L24
M00_L42:
       mov       edx,[r14+18]
       mov       [rsp+0EC],edx
       mov       r8,[r14+20]
       mov       [rsp+50],r8
       mov       r10,[r14+28]
       mov       [rsp+48],r10
       mov       r9,[r14+8]
       mov       [rsp+90],r9
       test      rax,rax
       mov       [rsp+88],rax
       jne       short M00_L43
       mov       rax,[r14+10]
       mov       [rsp+88],rax
M00_L43:
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rsp+50]
       mov       [rsp+0D0],r8
       mov       r8,[rsp+48]
       mov       [rsp+0D8],r8
       mov       r8,[rsp+88]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0D0]
       mov       edx,[rsp+0EC]
       mov       rcx,r14
       mov       r9,[rsp+90]
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r9,r14
       jmp       near ptr M00_L18
M00_L44:
       mov       edx,[r14+18]
       mov       [rsp+0E8],edx
       mov       r8,[r14+20]
       mov       [rsp+40],r8
       mov       r10,[r14+28]
       mov       [rsp+38],r10
       test      rax,rax
       mov       [rsp+80],rax
       jne       short M00_L45
       mov       rax,[r14+8]
       mov       [rsp+80],rax
M00_L45:
       mov       r14,[r14+10]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rsp+78],r9
       mov       r8,[rsp+40]
       mov       [rsp+0D0],r8
       mov       r8,[rsp+38]
       mov       [rsp+0D8],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0D0]
       mov       edx,[rsp+0E8]
       mov       rcx,r9
       mov       r9,[rsp+80]
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+78]
       mov       r9,r14
       jmp       near ptr M00_L12
M00_L46:
       vmovdqu   xmm0,xmmword ptr [r14+20]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       mov       [rsp+60],rcx
       mov       [rsp+0C0],rcx
       mov       [rsp+58],r11
       mov       [rsp+0C8],r11
       lea       r8,[rsp+0C0]
       lea       rdx,[rsp+0D0]
       mov       rcx,r13
       mov       r11,7FFB41470C38
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L47
       xor       ecx,ecx
       mov       [rsp+0F0],ecx
       mov       rax,r14
       jmp       near ptr M00_L24
M00_L47:
       mov       dword ptr [rsp+0F0],1
       mov       dword ptr [rsp+0F8],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A0],rax
       mov       r10,[rsp+60]
       mov       [rsp+0D0],r10
       mov       r11,[rsp+58]
       mov       [rsp+0D8],r11
       mov       r8,[r14+10]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0D0]
       mov       r9,[r14+8]
       mov       edx,[rsp+134]
       mov       rcx,rax
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0A0]
       mov       [rsp+0A8],r14
       jmp       near ptr M00_L13
M00_L48:
       mov       r14,[rsp+0A8]
       mov       rax,r14
       jmp       near ptr M00_L24
M00_L49:
       mov       ecx,511
       mov       rdx,7FFB41D1ADB0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M00_L50:
       mov       ecx,869
       mov       rdx,7FFB41D1ADB0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2673
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M02_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       rbp,r9
       mov       r15,[rsp+0D8]
       mov       r14,[rsp+0E0]
       mov       byte ptr [r15],0
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L11
       mov       r13,rbx
       cmp       edi,[r13+18]
       jg        near ptr M02_L03
       cmp       edi,[r13+18]
       jge       near ptr M02_L16
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D05B30]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        short M02_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M02_L14
       test      rsi,rsi
       je        short M02_L01
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M02_L01:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M02_L23
       cmp       ecx,0FF
       ja        near ptr M02_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M02_L02:
       cmp       byte ptr [r14],0
       je        near ptr M02_L21
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M02_L22
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jl        near ptr M02_L06
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M02_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       js        near ptr M02_L09
       mov       rdx,r13
       call      qword ptr [7FFB41D05BD8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M02_L10
M02_L03:
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D05B30]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        near ptr M02_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M02_L12
       test      rdi,rdi
       je        short M02_L04
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M02_L23
       cmp       ecx,0FF
       ja        near ptr M02_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M02_L05:
       jmp       near ptr M02_L02
M02_L06:
       cmp       edx,0FFFFFFFE
       jle       short M02_L07
       mov       rax,r13
       jmp       short M02_L10
M02_L07:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M02_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M02_L08
       mov       rdx,r13
       call      qword ptr [7FFB41D05C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M02_L10
M02_L08:
       mov       rdx,r13
       call      qword ptr [7FFB41D05C08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M02_L10
M02_L09:
       mov       rdx,r13
       call      qword ptr [7FFB41D05BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M02_L10:
       nop
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
M02_L11:
       mov       byte ptr [r14],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rbp+18],edi
       lea       rdi,[rbp+20]
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
       jo        near ptr M02_L23
       cmp       eax,0FF
       ja        near ptr M02_L23
       mov       [rbp+1D],al
       mov       rax,rbp
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
M02_L12:
       mov       r13d,[rbx+18]
       mov       rsi,[rbx+20]
       mov       rbp,[rbx+28]
       mov       r15,[rbx+8]
       test      rdi,rdi
       jne       short M02_L13
       mov       rdi,[rbx+10]
M02_L13:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       [rsp+50],rsi
       mov       [rsp+58],rbp
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+50]
       mov       edx,r13d
       mov       rcx,r12
       mov       r9,r15
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M02_L05
M02_L14:
       mov       r13d,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r15,[rbx+28]
       test      rsi,rsi
       jne       short M02_L15
       mov       rsi,[rbx+8]
M02_L15:
       mov       rdi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       [rsp+50],rbp
       mov       [rsp+58],r15
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+50]
       mov       edx,r13d
       mov       rcx,r12
       mov       r9,rsi
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M02_L02
M02_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFB41D9E610
       call      qword ptr [7FFB4152F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L18:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rdx,[rsp+50]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L19
       mov       byte ptr [r14],0
       mov       rax,rbx
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
M02_L19:
       cmp       byte ptr [rsp+0D0],0
       je        short M02_L20
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
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M02_L02
M02_L20:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFB41D0EC70]
       mov       r15,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFB41D0EC88]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB41895E60]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M02_L21:
       mov       rax,r13
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
M02_L22:
       mov       ecx,869
       mov       rdx,7FFB41D1ADB0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M02_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1145
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M03_L02
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M03_L03
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L04
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L06
       cmp       ecx,0FF
       ja        near ptr M03_L06
       mov       [rbx+1D],cl
M03_L00:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M03_L05
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L06
       cmp       ecx,0FF
       ja        near ptr M03_L06
       mov       [rsi+1D],cl
       mov       rax,rsi
M03_L01:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L02:
       mov       ecx,869
       mov       rdx,7FFB41D1ADB0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M03_L03:
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       ebp,[rbx+18]
       mov       r14,[rbx+20]
       mov       r15,[rbx+28]
       mov       r13,[rbx+8]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+38],r14
       mov       [rsp+40],r15
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,ebp
       mov       rcx,rbx
       mov       r9,r13
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M03_L00
M03_L05:
       mov       edi,[rsi+18]
       mov       rbp,[rsi+20]
       mov       r14,[rsi+28]
       mov       r15,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+38],rbp
       mov       [rsp+40],r14
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,edi
       mov       rcx,rsi
       mov       r9,rbx
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 419
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
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
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M04_L14
       mov       rsi,[rbx+8]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M04_L08
       test      rsi,rsi
       je        near ptr M04_L14
       mov       rbp,[rsi+10]
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M04_L09
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M04_L10
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rdi+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M04_L18
       cmp       ecx,0FF
       ja        near ptr M04_L18
       mov       [rsi+1D],cl
M04_L00:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M04_L11
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbp+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M04_L18
       cmp       ecx,0FF
       ja        near ptr M04_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M04_L01:
       mov       rsi,rdx
M04_L02:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M04_L12
       test      rsi,rsi
       je        short M04_L03
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M04_L03:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M04_L18
       cmp       ecx,0FF
       ja        near ptr M04_L18
       mov       [rbx+1D],cl
M04_L04:
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M04_L15
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M04_L16
       test      rbp,rbp
       je        short M04_L05
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M04_L05:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M04_L18
       cmp       ecx,0FF
       ja        near ptr M04_L18
       mov       [rbx+1D],cl
M04_L06:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M04_L17
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rdi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M04_L18
       cmp       ecx,0FF
       ja        near ptr M04_L18
       mov       [rdi+1D],cl
       mov       rax,rdi
M04_L07:
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
M04_L08:
       mov       rax,rbx
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
M04_L09:
       jmp       near ptr M04_L02
M04_L10:
       mov       r15d,[rsi+18]
       mov       r13,[rsi+20]
       mov       r12,[rsi+28]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],r13
       mov       [rsp+38],r12
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       rcx,rsi
       mov       r9,rdi
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M04_L00
M04_L11:
       mov       edi,[rbp+18]
       mov       r14,[rbp+20]
       mov       r15,[rbp+28]
       mov       r13,[rbp+10]
       mov       rcx,[rbp]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],r13
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbp
       mov       r9,rsi
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M04_L01
M04_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       test      rsi,rsi
       jne       short M04_L13
       mov       rsi,[rbx+8]
M04_L13:
       mov       r15,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbx
       mov       r9,rsi
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M04_L04
M04_L14:
       mov       ecx,869
       mov       rdx,7FFB41D1ADB0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M04_L15:
       mov       rax,rbx
       jmp       near ptr M04_L07
M04_L16:
       mov       r14d,[rbx+18]
       mov       r15,[rbx+20]
       mov       r13,[rbx+28]
       test      rbp,rbp
       cmove     rbp,rsi
       mov       rsi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],r15
       mov       [rsp+38],r13
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r14d
       mov       rcx,rbx
       mov       r9,rbp
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M04_L06
M04_L17:
       mov       esi,[rdi+18]
       mov       rbp,[rdi+20]
       mov       r14,[rdi+28]
       mov       r15,[rdi+8]
       mov       rcx,[rdi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],rbx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,esi
       mov       rcx,rdi
       mov       r9,r15
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M04_L07
M04_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 941
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L03
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M05_L04
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M05_L05
       test      rbp,rbp
       je        short M05_L00
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M05_L00:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L07
       cmp       ecx,0FF
       ja        near ptr M05_L07
       mov       [rbx+1D],cl
M05_L01:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M05_L06
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rdi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L07
       cmp       ecx,0FF
       ja        near ptr M05_L07
       mov       [rdi+1D],cl
       mov       rax,rdi
M05_L02:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L03:
       mov       ecx,869
       mov       rdx,7FFB41D1ADB0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M05_L04:
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L05:
       mov       r14d,[rbx+18]
       mov       r15,[rbx+20]
       mov       r13,[rbx+28]
       test      rbp,rbp
       cmove     rbp,rsi
       mov       rsi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+38],r15
       mov       [rsp+40],r13
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,r14d
       mov       rcx,rbx
       mov       r9,rbp
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M05_L01
M05_L06:
       mov       esi,[rdi+18]
       mov       rbp,[rdi+20]
       mov       r14,[rdi+28]
       mov       r15,[rdi+8]
       mov       rcx,[rdi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+38],rbp
       mov       [rsp+40],r14
       mov       [rsp+20],rbx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,esi
       mov       rcx,rdi
       mov       r9,r15
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M05_L02
M05_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 438
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
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
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M06_L14
       mov       rsi,[rbx+10]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M06_L08
       test      rsi,rsi
       je        near ptr M06_L14
       cmp       qword ptr [rdi+8],0
       je        near ptr M06_L09
       mov       rbp,rdi
       mov       rdx,[rbp+10]
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M06_L10
       test      r14,r14
       je        short M06_L00
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M06_L00:
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rsi+1D],cl
M06_L01:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M06_L11
       lea       rcx,[rbp+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbp+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M06_L02:
       mov       rsi,rdx
M06_L03:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L12
       test      rsi,rsi
       je        short M06_L04
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M06_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rbx+1D],cl
M06_L05:
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M06_L15
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L16
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rbx+1D],cl
M06_L06:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M06_L17
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rsi+1D],cl
       mov       rax,rsi
M06_L07:
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
M06_L08:
       mov       rax,rbx
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
M06_L09:
       jmp       near ptr M06_L03
M06_L10:
       mov       r15d,[rsi+18]
       mov       r13,[rsi+20]
       mov       r12,[rsi+28]
       test      r14,r14
       cmove     r14,rdi
       mov       rdi,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],r13
       mov       [rsp+38],r12
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L01
M06_L11:
       mov       edi,[rbp+18]
       mov       r14,[rbp+20]
       mov       r15,[rbp+28]
       mov       r13,[rbp+8]
       mov       rcx,[rbp]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbp
       mov       r9,r13
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M06_L02
M06_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       mov       r15,[rbx+8]
       test      rsi,rsi
       jne       short M06_L13
       mov       rsi,[rbx+10]
M06_L13:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbx
       mov       r9,r15
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L05
M06_L14:
       mov       ecx,869
       mov       rdx,7FFB41D1ADB0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M06_L15:
       mov       rax,rbx
       jmp       near ptr M06_L07
M06_L16:
       mov       ebp,[rbx+18]
       mov       r14,[rbx+20]
       mov       r15,[rbx+28]
       mov       r13,[rbx+8]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,ebp
       mov       rcx,rbx
       mov       r9,r13
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L06
M06_L17:
       mov       edi,[rsi+18]
       mov       rbp,[rsi+20]
       mov       r14,[rsi+28]
       mov       r15,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rsi
       mov       r9,rbx
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M06_L07
M06_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 943
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
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
       mov       esi,[rsp+60]
       mov       [rbx+0C],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       mov       ecx,4AB
       mov       rdx,7FFB41D1ADB0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
; Total bytes of code 76
```
```assembly
; System.Collections.Immutable.Requires.NotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String)
       sub       rsp,28
       test      rdx,rdx
       je        short M08_L00
       add       rsp,28
       ret
M08_L00:
       mov       rcx,r8
       call      qword ptr [7FFB41D0EC58]
       int       3
; Total bytes of code 24
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       cmp       rbx,[rsi+10]
       je        near ptr M09_L04
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14,[rsi+8]
       test      rbx,rbx
       je        near ptr M09_L05
       test      r14,r14
       je        near ptr M09_L06
       mov       r15,[rbp]
       mov       rcx,r15
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r13,[rax+8]
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M09_L01
       test      r13,r13
       je        short M09_L00
       mov       r12d,[rbx+18]
       mov       rax,[rbx+20]
       mov       rdx,[rbx+28]
       mov       [rsp+20],rdx
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__89_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [r13+18],rcx
       jne       near ptr M09_L07
       mov       rcx,[r13+8]
       cmp       [rcx],ecx
       test      rdx,rdx
       je        short M09_L00
       cmp       byte ptr [rdx+24],0
       jne       short M09_L00
       mov       rcx,[rdx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D05C80]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       r12,[rsp+20]
       mov       rcx,[r12+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D05C80]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r12+24],1
M09_L00:
       mov       rcx,[rbx+8]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D059F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       rcx,[rbx+10]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D059F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       byte ptr [rbx+1C],1
M09_L01:
       lea       rcx,[rbp+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+20],edi
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M09_L03
M09_L02:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbp
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
M09_L03:
       mov       rdx,7FFB41DD31A8
       call      qword ptr [7FFB4152F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M09_L02
M09_L04:
       mov       rax,rsi
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
M09_L05:
       mov       ecx,4AB
       mov       rdx,7FFB41D1ADB0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M09_L06:
       mov       ecx,4B5
       mov       rdx,7FFB41D1ADB0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M09_L07:
       mov       [rsp+28],r12d
       mov       [rsp+30],rax
       mov       [rsp+38],rdx
       lea       rdx,[rsp+28]
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       jmp       near ptr M09_L00
; Total bytes of code 470
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
       je        near ptr M11_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M11_L01
       test      rsi,rsi
       je        short M11_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M11_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M11_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M11_L00:
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
M11_L01:
       test      rsi,rsi
       je        short M11_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M11_L03
M11_L02:
       mov       rax,2675DDA0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M11_L03:
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
M11_L04:
       call      qword ptr [7FFB41D0E610]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FFB41525C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
       je        short M13_L00
       test      r14,r14
       je        near ptr M13_L01
       mov       [rbx+18],edx
       lea       rdi,[rbx+20]
       mov       rsi,r8
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
       jo        short M13_L02
       cmp       ecx,0FF
       ja        short M13_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M13_L00:
       mov       ecx,847
       mov       rdx,7FFB41D1ADB0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M13_L01:
       mov       ecx,851
       mov       rdx,7FFB41D1ADB0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M13_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 215
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,138
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+0C0],ymm4
       vmovdqu   ymmword ptr [rsp+0E0],ymm4
       vmovdqu   ymmword ptr [rsp+100],ymm4
       vmovdqa   xmmword ptr [rsp+120],xmm4
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L32
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L33
       mov       rcx,rsi
       mov       r11,7FFB41470C18
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB41DCA288],1
       je        near ptr M00_L34
M00_L00:
       mov       rdx,22EAC400AE0
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB41470C20
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L35
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       rcx,22EAC400A28
       mov       rbp,[rcx]
       mov       r14,[rbp+10]
       mov       r15,[rbp+8]
       mov       r13,[rbp+18]
       xor       r12d,r12d
       xor       eax,eax
       inc       edi
M00_L04:
       dec       edi
       je        near ptr M00_L27
       mov       [rsp+0B8],rax
       mov       r8,[rsi+rax]
       mov       [rsp+0B0],r8
       test      r8,r8
       je        short M00_L05
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FFB41470C28
       call      qword ptr [r11]
       mov       r10d,eax
       mov       r8,[rsp+0B0]
       jmp       short M00_L06
M00_L05:
       xor       ecx,ecx
       xor       r10d,r10d
M00_L06:
       mov       [rsp+134],r10d
       cmp       [r14],r14b
       mov       rcx,r14
       cmp       qword ptr [r14+8],0
       jne       near ptr M00_L31
M00_L07:
       xor       r9d,r9d
       xor       r11d,r11d
M00_L08:
       mov       [rsp+68],r11
       test      r11,r11
       jne       near ptr M00_L37
       xor       edx,edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+100],xmm0
       mov       [rsp+100],r8
       mov       rcx,22EAC400A50
       mov       rcx,[rcx]
       mov       [rsp+108],rcx
       mov       rcx,[rsp+100]
       mov       r11,[rsp+108]
M00_L09:
       test      edx,edx
       jne       near ptr M00_L25
       test      r11,r11
       je        near ptr M00_L41
       test      r13,r13
       je        near ptr M00_L49
       xor       r8d,r8d
       mov       [rsp+0F8],r8d
       cmp       qword ptr [r14+8],0
       je        near ptr M00_L26
       mov       r9,r14
       mov       r10d,[rsp+134]
       cmp       r10d,[r9+18]
       jle       near ptr M00_L15
       mov       [rsp+0A8],r9
       mov       r8,[r9+10]
       mov       [rsp+0D0],rcx
       mov       [rsp+0D8],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+0F8]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+0F0]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+0D0]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D05B30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+0F0],0
       je        short M00_L13
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L42
       test      rax,rax
       je        short M00_L10
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L10:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L14
M00_L11:
       add       ecx,1
       jo        near ptr M00_L51
       cmp       ecx,0FF
       ja        near ptr M00_L51
       mov       [r14+1D],cl
       mov       r9,r14
M00_L12:
       mov       r14,r9
       mov       [rsp+0A8],r14
M00_L13:
       cmp       byte ptr [rsp+0F0],0
       je        near ptr M00_L48
       mov       r14,[rsp+0A8]
       test      r14,r14
       je        near ptr M00_L50
       mov       rdx,[r14+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       edx,ecx
       cmp       edx,2
       jl        near ptr M00_L20
       mov       rdx,[r14+10]
       test      rdx,rdx
       je        near ptr M00_L50
       mov       rcx,[rdx+10]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       ecx,edx
       js        near ptr M00_L23
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41D05BD8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L14:
       mov       ecx,eax
       jmp       near ptr M00_L11
M00_L15:
       cmp       r10d,[r9+18]
       jge       near ptr M00_L46
       mov       [rsp+0A8],r9
       mov       r8,[r9+8]
       mov       [rsp+0D0],rcx
       mov       [rsp+0D8],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+0F8]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+0F0]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+0D0]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D05B30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+0F0],0
       je        near ptr M00_L13
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L44
       test      rax,rax
       je        short M00_L16
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L16:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        short M00_L19
M00_L17:
       add       ecx,1
       jo        near ptr M00_L51
       cmp       ecx,0FF
       ja        near ptr M00_L51
       mov       [r14+1D],cl
       mov       r9,r14
M00_L18:
       mov       r14,r9
       mov       [rsp+0A8],r14
       jmp       near ptr M00_L13
M00_L19:
       mov       ecx,eax
       jmp       short M00_L17
M00_L20:
       cmp       edx,0FFFFFFFE
       jle       short M00_L21
       jmp       short M00_L24
M00_L21:
       mov       rdx,[r14+8]
       test      rdx,rdx
       je        near ptr M00_L50
       mov       rcx,[rdx+10]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       ecx,edx
       test      ecx,ecx
       jle       short M00_L22
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41D05C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       short M00_L24
M00_L22:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41D05C08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       short M00_L24
M00_L23:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41D05BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
M00_L24:
       inc       r12d
M00_L25:
       mov       rax,[rsp+0B8]
       add       rax,8
       jmp       near ptr M00_L04
M00_L26:
       mov       [rsp+58],r11
       mov       [rsp+60],rcx
       mov       dword ptr [rsp+0F0],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+98],rax
       mov       r8d,[rsp+134]
       mov       [rax+18],r8d
       lea       rcx,[rax+20]
       mov       rdx,[rsp+60]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+98]
       lea       rcx,[rax+28]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+98]
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+98]
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsp+98]
       mov       byte ptr [r8+1C],0
       movzx     ecx,byte ptr [r14+1D]
       add       ecx,1
       jo        near ptr M00_L51
       cmp       ecx,0FF
       ja        near ptr M00_L51
       mov       [r8+1D],cl
       mov       r14,r8
       jmp       near ptr M00_L24
M00_L27:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+120],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+120]
       mov       r9d,r12d
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFB41D0EEC8]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       mov       rsi,[rsp+120]
       mov       edi,[rsp+128]
       mov       r14d,[rsp+12C]
       mov       rdx,rbp
       mov       rcx,7FFB41DCA428
       mov       r8,26F2B2515E8
       call      qword ptr [7FFB41D059C8]; System.Collections.Immutable.Requires.NotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String)
       mov       r8d,edi
       test      r14d,r14d
       jne       short M00_L28
       mov       r8d,edi
       add       r8d,[rbp+20]
M00_L28:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFB41D05C38]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32)
       mov       [rsp+0E0],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+0E0]
       mov       rdx,7FFB41D3D038
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D05C98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,138
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L29:
       mov       rcx,[rcx+10]
M00_L30:
       cmp       qword ptr [rcx+8],0
       je        near ptr M00_L07
       mov       r10d,[rsp+134]
M00_L31:
       mov       edx,[rcx+18]
       cmp       r10d,edx
       je        near ptr M00_L36
       jg        short M00_L29
       mov       rcx,[rcx+8]
       jmp       short M00_L30
M00_L32:
       call      qword ptr [7FFB41ACEFD0]
       mov       ecx,65
       mov       rdx,7FFB4192C248
       call      qword ptr [7FFB4152F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417F5AC0
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4192C248
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D0C600]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D0C618]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L33:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L35:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L36:
       mov       r9,[rcx+20]
       mov       r11,[rcx+28]
       jmp       near ptr M00_L08
M00_L37:
       mov       rcx,r15
       mov       [rsp+70],r9
       mov       r8,r9
       mov       rdx,[rsp+0B0]
       mov       r11,7FFB41470C30
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L38
       mov       [rsp+20],r15
       mov       r11,[rsp+68]
       mov       r9d,[r11+20]
       mov       [rsp+68],r11
       mov       rcx,r11
       mov       rdx,[rsp+0B0]
       xor       r8d,r8d
       call      qword ptr [7FFB41D0ECB8]
       test      eax,eax
       jl        short M00_L39
M00_L38:
       mov       ecx,1
       mov       rax,[rsp+70]
       mov       r10,[rsp+68]
       mov       edx,ecx
       mov       rcx,rax
       mov       r11,r10
       jmp       near ptr M00_L09
M00_L39:
       xor       edx,edx
       mov       [rsp+130],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+110],xmm0
       mov       rcx,[rsp+68]
       mov       rdx,[rsp+0B0]
       call      qword ptr [7FFB41D0ECD0]
       mov       rcx,[rsp+70]
       mov       [rsp+110],rcx
       test      rax,rax
       jne       short M00_L40
       mov       rax,22EAC400A50
       mov       rax,[rax]
M00_L40:
       mov       [rsp+118],rax
       mov       rcx,[rsp+110]
       mov       rax,rcx
       mov       r11,[rsp+118]
       mov       r10,r11
       mov       rcx,rax
       mov       r11,r10
       mov       edx,[rsp+130]
       jmp       near ptr M00_L09
M00_L41:
       mov       r10d,[rsp+134]
       lea       r8,[rsp+0F8]
       mov       rcx,r14
       mov       edx,r10d
       call      qword ptr [7FFB41D0EEB0]
       mov       r14,rax
       jmp       near ptr M00_L24
M00_L42:
       mov       edx,[r14+18]
       mov       [rsp+0EC],edx
       mov       r8,[r14+20]
       mov       [rsp+50],r8
       mov       r10,[r14+28]
       mov       [rsp+48],r10
       mov       r9,[r14+8]
       mov       [rsp+90],r9
       test      rax,rax
       mov       [rsp+88],rax
       jne       short M00_L43
       mov       rax,[r14+10]
       mov       [rsp+88],rax
M00_L43:
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rsp+50]
       mov       [rsp+0D0],r8
       mov       r8,[rsp+48]
       mov       [rsp+0D8],r8
       mov       r8,[rsp+88]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0D0]
       mov       edx,[rsp+0EC]
       mov       rcx,r14
       mov       r9,[rsp+90]
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r9,r14
       jmp       near ptr M00_L12
M00_L44:
       mov       edx,[r14+18]
       mov       [rsp+0E8],edx
       mov       r8,[r14+20]
       mov       [rsp+40],r8
       mov       r10,[r14+28]
       mov       [rsp+38],r10
       test      rax,rax
       mov       [rsp+80],rax
       jne       short M00_L45
       mov       rax,[r14+8]
       mov       [rsp+80],rax
M00_L45:
       mov       r14,[r14+10]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rsp+78],r9
       mov       r8,[rsp+40]
       mov       [rsp+0D0],r8
       mov       r8,[rsp+38]
       mov       [rsp+0D8],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0D0]
       mov       edx,[rsp+0E8]
       mov       rcx,r9
       mov       r9,[rsp+80]
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+78]
       mov       r9,r14
       jmp       near ptr M00_L18
M00_L46:
       vmovdqu   xmm0,xmmword ptr [r14+20]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       mov       [rsp+60],rcx
       mov       [rsp+0C0],rcx
       mov       [rsp+58],r11
       mov       [rsp+0C8],r11
       lea       r8,[rsp+0C0]
       lea       rdx,[rsp+0D0]
       mov       rcx,r13
       mov       r11,7FFB41470C38
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L47
       xor       ecx,ecx
       mov       [rsp+0F0],ecx
       jmp       near ptr M00_L24
M00_L47:
       mov       dword ptr [rsp+0F0],1
       mov       dword ptr [rsp+0F8],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A0],rax
       mov       r10,[rsp+60]
       mov       [rsp+0D0],r10
       mov       r11,[rsp+58]
       mov       [rsp+0D8],r11
       mov       r8,[r14+10]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0D0]
       mov       r9,[r14+8]
       mov       edx,[rsp+134]
       mov       rcx,rax
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0A0]
       mov       [rsp+0A8],r14
       jmp       near ptr M00_L13
M00_L48:
       mov       r14,[rsp+0A8]
       jmp       near ptr M00_L24
M00_L49:
       mov       ecx,511
       mov       rdx,7FFB41D1ADE0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M00_L50:
       mov       ecx,869
       mov       rdx,7FFB41D1ADE0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2678
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M02_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       rbp,r9
       mov       r15,[rsp+0D8]
       mov       r14,[rsp+0E0]
       mov       byte ptr [r15],0
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L11
       mov       r13,rbx
       cmp       edi,[r13+18]
       jle       near ptr M02_L03
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D05B30]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        short M02_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M02_L12
       test      rdi,rdi
       je        short M02_L01
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L01:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M02_L23
       cmp       ecx,0FF
       ja        near ptr M02_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M02_L02:
       cmp       byte ptr [r14],0
       je        near ptr M02_L21
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M02_L22
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jl        near ptr M02_L06
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M02_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       js        near ptr M02_L09
       mov       rdx,r13
       call      qword ptr [7FFB41D05BD8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M02_L10
M02_L03:
       cmp       edi,[r13+18]
       jge       near ptr M02_L16
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D05B30]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        near ptr M02_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M02_L14
       test      rsi,rsi
       je        short M02_L04
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M02_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M02_L23
       cmp       ecx,0FF
       ja        near ptr M02_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M02_L05:
       jmp       near ptr M02_L02
M02_L06:
       cmp       edx,0FFFFFFFE
       jle       short M02_L07
       mov       rax,r13
       jmp       short M02_L10
M02_L07:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M02_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M02_L08
       mov       rdx,r13
       call      qword ptr [7FFB41D05C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M02_L10
M02_L08:
       mov       rdx,r13
       call      qword ptr [7FFB41D05C08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M02_L10
M02_L09:
       mov       rdx,r13
       call      qword ptr [7FFB41D05BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M02_L10:
       nop
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
M02_L11:
       mov       byte ptr [r14],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rbp+18],edi
       lea       rdi,[rbp+20]
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
       jo        near ptr M02_L23
       cmp       eax,0FF
       ja        near ptr M02_L23
       mov       [rbp+1D],al
       mov       rax,rbp
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
M02_L12:
       mov       r13d,[rbx+18]
       mov       r15,[rbx+20]
       mov       rsi,[rbx+28]
       mov       rbp,[rbx+8]
       test      rdi,rdi
       jne       short M02_L13
       mov       rdi,[rbx+10]
M02_L13:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       [rsp+50],r15
       mov       [rsp+58],rsi
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+50]
       mov       edx,r13d
       mov       rcx,r12
       mov       r9,rbp
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M02_L02
M02_L14:
       mov       r13d,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r15,[rbx+28]
       test      rsi,rsi
       jne       short M02_L15
       mov       rsi,[rbx+8]
M02_L15:
       mov       rdi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       [rsp+50],rbp
       mov       [rsp+58],r15
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+50]
       mov       edx,r13d
       mov       rcx,r12
       mov       r9,rsi
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M02_L05
M02_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFB41D9E650
       call      qword ptr [7FFB4152F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L18:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rdx,[rsp+50]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L19
       mov       byte ptr [r14],0
       mov       rax,rbx
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
M02_L19:
       cmp       byte ptr [rsp+0D0],0
       je        short M02_L20
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
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M02_L02
M02_L20:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFB41D0EC70]
       mov       rsi,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFB41D0EC88]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB41895E60]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L21:
       mov       rax,r13
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
M02_L22:
       mov       ecx,869
       mov       rdx,7FFB41D1ADE0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M02_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1145
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M03_L02
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M03_L03
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L04
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L06
       cmp       ecx,0FF
       ja        near ptr M03_L06
       mov       [rbx+1D],cl
M03_L00:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M03_L05
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L06
       cmp       ecx,0FF
       ja        near ptr M03_L06
       mov       [rsi+1D],cl
       mov       rax,rsi
M03_L01:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L02:
       mov       ecx,869
       mov       rdx,7FFB41D1ADE0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M03_L03:
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L04:
       mov       ebp,[rbx+18]
       mov       r14,[rbx+20]
       mov       r15,[rbx+28]
       mov       r13,[rbx+8]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+38],r14
       mov       [rsp+40],r15
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,ebp
       mov       rcx,rbx
       mov       r9,r13
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M03_L00
M03_L05:
       mov       edi,[rsi+18]
       mov       rbp,[rsi+20]
       mov       r14,[rsi+28]
       mov       r15,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+38],rbp
       mov       [rsp+40],r14
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,edi
       mov       rcx,rsi
       mov       r9,rbx
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 419
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
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
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M04_L14
       mov       rsi,[rbx+8]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M04_L08
       test      rsi,rsi
       je        near ptr M04_L14
       mov       rbp,[rsi+10]
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M04_L09
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M04_L10
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rdi+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M04_L18
       cmp       ecx,0FF
       ja        near ptr M04_L18
       mov       [rsi+1D],cl
M04_L00:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M04_L11
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbp+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M04_L18
       cmp       ecx,0FF
       ja        near ptr M04_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M04_L01:
       mov       rsi,rdx
M04_L02:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M04_L12
       test      rsi,rsi
       je        short M04_L03
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M04_L03:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M04_L18
       cmp       ecx,0FF
       ja        near ptr M04_L18
       mov       [rbx+1D],cl
M04_L04:
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M04_L15
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M04_L16
       test      rbp,rbp
       je        short M04_L05
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M04_L05:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M04_L18
       cmp       ecx,0FF
       ja        near ptr M04_L18
       mov       [rbx+1D],cl
M04_L06:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M04_L17
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rdi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M04_L18
       cmp       ecx,0FF
       ja        near ptr M04_L18
       mov       [rdi+1D],cl
       mov       rax,rdi
M04_L07:
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
M04_L08:
       mov       rax,rbx
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
M04_L09:
       jmp       near ptr M04_L02
M04_L10:
       mov       r15d,[rsi+18]
       mov       r13,[rsi+20]
       mov       r12,[rsi+28]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],r13
       mov       [rsp+38],r12
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       rcx,rsi
       mov       r9,rdi
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M04_L00
M04_L11:
       mov       edi,[rbp+18]
       mov       r14,[rbp+20]
       mov       r15,[rbp+28]
       mov       r13,[rbp+10]
       mov       rcx,[rbp]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],r13
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbp
       mov       r9,rsi
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M04_L01
M04_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       test      rsi,rsi
       jne       short M04_L13
       mov       rsi,[rbx+8]
M04_L13:
       mov       r15,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbx
       mov       r9,rsi
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M04_L04
M04_L14:
       mov       ecx,869
       mov       rdx,7FFB41D1ADE0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M04_L15:
       mov       rax,rbx
       jmp       near ptr M04_L07
M04_L16:
       mov       r14d,[rbx+18]
       mov       r15,[rbx+20]
       mov       r13,[rbx+28]
       test      rbp,rbp
       cmove     rbp,rsi
       mov       rsi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],r15
       mov       [rsp+38],r13
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r14d
       mov       rcx,rbx
       mov       r9,rbp
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M04_L06
M04_L17:
       mov       esi,[rdi+18]
       mov       rbp,[rdi+20]
       mov       r14,[rdi+28]
       mov       r15,[rdi+8]
       mov       rcx,[rdi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],rbx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,esi
       mov       rcx,rdi
       mov       r9,r15
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M04_L07
M04_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 941
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L03
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M05_L04
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M05_L05
       test      rbp,rbp
       je        short M05_L00
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M05_L00:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L07
       cmp       ecx,0FF
       ja        near ptr M05_L07
       mov       [rbx+1D],cl
M05_L01:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M05_L06
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rdi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L07
       cmp       ecx,0FF
       ja        near ptr M05_L07
       mov       [rdi+1D],cl
       mov       rax,rdi
M05_L02:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L03:
       mov       ecx,869
       mov       rdx,7FFB41D1ADE0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M05_L04:
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L05:
       mov       r14d,[rbx+18]
       mov       r15,[rbx+20]
       mov       r13,[rbx+28]
       test      rbp,rbp
       cmove     rbp,rsi
       mov       rsi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+38],r15
       mov       [rsp+40],r13
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,r14d
       mov       rcx,rbx
       mov       r9,rbp
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M05_L01
M05_L06:
       mov       esi,[rdi+18]
       mov       rbp,[rdi+20]
       mov       r14,[rdi+28]
       mov       r15,[rdi+8]
       mov       rcx,[rdi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+38],rbp
       mov       [rsp+40],r14
       mov       [rsp+20],rbx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,esi
       mov       rcx,rdi
       mov       r9,r15
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M05_L02
M05_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 438
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
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
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M06_L14
       mov       rsi,[rbx+10]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M06_L08
       test      rsi,rsi
       je        near ptr M06_L14
       cmp       qword ptr [rdi+8],0
       je        near ptr M06_L09
       mov       rbp,rdi
       mov       rdx,[rbp+10]
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M06_L10
       test      r14,r14
       je        short M06_L00
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M06_L00:
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rsi+1D],cl
M06_L01:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M06_L11
       lea       rcx,[rbp+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbp+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M06_L02:
       mov       rsi,rdx
M06_L03:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L12
       test      rsi,rsi
       je        short M06_L04
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M06_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rbx+1D],cl
M06_L05:
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M06_L15
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L16
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rbx+1D],cl
M06_L06:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M06_L17
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rsi+1D],cl
       mov       rax,rsi
M06_L07:
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
M06_L08:
       mov       rax,rbx
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
M06_L09:
       jmp       near ptr M06_L03
M06_L10:
       mov       r15d,[rsi+18]
       mov       r13,[rsi+20]
       mov       r12,[rsi+28]
       test      r14,r14
       cmove     r14,rdi
       mov       rdi,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],r13
       mov       [rsp+38],r12
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L01
M06_L11:
       mov       edi,[rbp+18]
       mov       r14,[rbp+20]
       mov       r15,[rbp+28]
       mov       r13,[rbp+8]
       mov       rcx,[rbp]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbp
       mov       r9,r13
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M06_L02
M06_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       mov       r15,[rbx+8]
       test      rsi,rsi
       jne       short M06_L13
       mov       rsi,[rbx+10]
M06_L13:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbx
       mov       r9,r15
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L05
M06_L14:
       mov       ecx,869
       mov       rdx,7FFB41D1ADE0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M06_L15:
       mov       rax,rbx
       jmp       near ptr M06_L07
M06_L16:
       mov       ebp,[rbx+18]
       mov       r14,[rbx+20]
       mov       r15,[rbx+28]
       mov       r13,[rbx+8]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,ebp
       mov       rcx,rbx
       mov       r9,r13
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L06
M06_L17:
       mov       edi,[rsi+18]
       mov       rbp,[rsi+20]
       mov       r14,[rsi+28]
       mov       r15,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rsi
       mov       r9,rbx
       call      qword ptr [7FFB41D05B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M06_L07
M06_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 943
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
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
       mov       esi,[rsp+60]
       mov       [rbx+0C],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       mov       ecx,4AB
       mov       rdx,7FFB41D1ADE0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
; Total bytes of code 76
```
```assembly
; System.Collections.Immutable.Requires.NotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String)
       sub       rsp,28
       test      rdx,rdx
       je        short M08_L00
       add       rsp,28
       ret
M08_L00:
       mov       rcx,r8
       call      qword ptr [7FFB41D0EC58]
       int       3
; Total bytes of code 24
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       cmp       rbx,[rsi+10]
       je        near ptr M09_L04
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14,[rsi+8]
       test      rbx,rbx
       je        near ptr M09_L05
       test      r14,r14
       je        near ptr M09_L06
       mov       r15,[rbp]
       mov       rcx,r15
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r13,[rax+8]
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M09_L01
       test      r13,r13
       je        short M09_L00
       mov       r12d,[rbx+18]
       mov       rax,[rbx+20]
       mov       rdx,[rbx+28]
       mov       [rsp+20],rdx
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__89_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [r13+18],rcx
       jne       near ptr M09_L07
       mov       rcx,[r13+8]
       cmp       [rcx],ecx
       test      rdx,rdx
       je        short M09_L00
       cmp       byte ptr [rdx+24],0
       jne       short M09_L00
       mov       rcx,[rdx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D05C80]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       r12,[rsp+20]
       mov       rcx,[r12+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D05C80]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r12+24],1
M09_L00:
       mov       rcx,[rbx+8]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D059F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       rcx,[rbx+10]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D059F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       byte ptr [rbx+1C],1
M09_L01:
       lea       rcx,[rbp+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+20],edi
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M09_L03
M09_L02:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbp
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
M09_L03:
       mov       rdx,7FFB41DD31F8
       call      qword ptr [7FFB4152F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M09_L02
M09_L04:
       mov       rax,rsi
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
M09_L05:
       mov       ecx,4AB
       mov       rdx,7FFB41D1ADE0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M09_L06:
       mov       ecx,4B5
       mov       rdx,7FFB41D1ADE0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M09_L07:
       mov       [rsp+28],r12d
       mov       [rsp+30],rax
       mov       [rsp+38],rdx
       lea       rdx,[rsp+28]
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       jmp       near ptr M09_L00
; Total bytes of code 470
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
       je        near ptr M11_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M11_L01
       test      rsi,rsi
       je        short M11_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M11_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M11_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M11_L00:
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
M11_L01:
       test      rsi,rsi
       je        short M11_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M11_L03
M11_L02:
       mov       rax,26F2B240008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M11_L03:
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
M11_L04:
       call      qword ptr [7FFB41D0E610]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FFB41525C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
       je        short M13_L00
       test      r14,r14
       je        near ptr M13_L01
       mov       [rbx+18],edx
       lea       rdi,[rbx+20]
       mov       rsi,r8
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
       jo        short M13_L02
       cmp       ecx,0FF
       ja        short M13_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M13_L00:
       mov       ecx,847
       mov       rdx,7FFB41D1ADE0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M13_L01:
       mov       ecx,851
       mov       rdx,7FFB41D1ADE0
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D0EC58]
       int       3
M13_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 215
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,138
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+0C0],ymm4
       vmovdqu   ymmword ptr [rsp+0E0],ymm4
       vmovdqu   ymmword ptr [rsp+100],ymm4
       vmovdqa   xmmword ptr [rsp+120],xmm4
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L32
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L33
       mov       rcx,rsi
       mov       r11,7FFB41470C18
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB41DDA200],1
       je        near ptr M00_L34
M00_L00:
       mov       rdx,1D7DA402AD8
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB41470C20
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L35
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       rcx,1D7DA402A20
       mov       rbp,[rcx]
       mov       r14,[rbp+10]
       mov       r15,[rbp+8]
       mov       r13,[rbp+18]
       xor       r12d,r12d
       xor       eax,eax
       inc       edi
       jmp       short M00_L08
M00_L04:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41CF56E0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       short M00_L06
M00_L05:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41CF5728]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
M00_L06:
       inc       r12d
M00_L07:
       mov       rax,[rsp+0B8]
       add       rax,8
M00_L08:
       dec       edi
       je        near ptr M00_L27
       mov       [rsp+0B8],rax
       mov       r8,[rsi+rax]
       mov       [rsp+0B0],r8
       test      r8,r8
       je        short M00_L09
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FFB41470C28
       call      qword ptr [r11]
       mov       r10d,eax
       mov       r8,[rsp+0B0]
       jmp       short M00_L10
M00_L09:
       xor       ecx,ecx
       xor       r10d,r10d
M00_L10:
       mov       [rsp+134],r10d
       cmp       [r14],r14b
       mov       rcx,r14
       cmp       qword ptr [r14+8],0
       jne       near ptr M00_L31
M00_L11:
       xor       r9d,r9d
       xor       r11d,r11d
M00_L12:
       mov       [rsp+68],r11
       test      r11,r11
       jne       near ptr M00_L37
       xor       edx,edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+100],xmm0
       mov       [rsp+100],r8
       mov       rcx,1D7DA402A48
       mov       rcx,[rcx]
       mov       [rsp+108],rcx
       mov       rcx,[rsp+100]
       mov       r11,[rsp+108]
M00_L13:
       test      edx,edx
       jne       near ptr M00_L07
       test      r11,r11
       je        near ptr M00_L41
       test      r13,r13
       je        near ptr M00_L49
       xor       r8d,r8d
       mov       [rsp+0F8],r8d
       cmp       qword ptr [r14+8],0
       je        near ptr M00_L26
       mov       r9,r14
       mov       r10d,[rsp+134]
       cmp       r10d,[r9+18]
       jle       near ptr M00_L19
       mov       [rsp+0A8],r9
       mov       r8,[r9+10]
       mov       [rsp+0D0],rcx
       mov       [rsp+0D8],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+0F8]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+0F0]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+0D0]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF5638]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+0F0],0
       je        short M00_L17
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L42
       test      rax,rax
       je        short M00_L14
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L14:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L18
M00_L15:
       add       ecx,1
       jo        near ptr M00_L51
       cmp       ecx,0FF
       ja        near ptr M00_L51
       mov       [r14+1D],cl
       mov       r9,r14
M00_L16:
       mov       r14,r9
       mov       [rsp+0A8],r14
M00_L17:
       cmp       byte ptr [rsp+0F0],0
       je        near ptr M00_L48
       mov       r14,[rsp+0A8]
       test      r14,r14
       je        near ptr M00_L50
       mov       rdx,[r14+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       edx,ecx
       cmp       edx,2
       jl        near ptr M00_L24
       mov       rdx,[r14+10]
       test      rdx,rdx
       je        near ptr M00_L50
       mov       rcx,[rdx+10]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       ecx,edx
       js        near ptr M00_L05
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41CF5710]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L18:
       mov       ecx,eax
       jmp       near ptr M00_L15
M00_L19:
       cmp       r10d,[r9+18]
       jge       near ptr M00_L46
       mov       [rsp+0A8],r9
       mov       r8,[r9+8]
       mov       [rsp+0D0],rcx
       mov       [rsp+0D8],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+0F8]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+0F0]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+0D0]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF5638]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+0F0],0
       je        near ptr M00_L17
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L44
       test      rax,rax
       je        short M00_L20
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L20:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        short M00_L23
M00_L21:
       add       ecx,1
       jo        near ptr M00_L51
       cmp       ecx,0FF
       ja        near ptr M00_L51
       mov       [r14+1D],cl
       mov       r9,r14
M00_L22:
       mov       r14,r9
       mov       [rsp+0A8],r14
       jmp       near ptr M00_L17
M00_L23:
       mov       ecx,eax
       jmp       short M00_L21
M00_L24:
       cmp       edx,0FFFFFFFE
       jle       short M00_L25
       jmp       near ptr M00_L06
M00_L25:
       mov       rdx,[r14+8]
       test      rdx,rdx
       je        near ptr M00_L50
       mov       rcx,[rdx+10]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       ecx,edx
       test      ecx,ecx
       jle       near ptr M00_L04
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41CF56F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L26:
       mov       [rsp+58],r11
       mov       [rsp+60],rcx
       mov       dword ptr [rsp+0F0],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+98],rax
       mov       r8d,[rsp+134]
       mov       [rax+18],r8d
       lea       rcx,[rax+20]
       mov       rdx,[rsp+60]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+98]
       lea       rcx,[rax+28]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+98]
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+98]
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsp+98]
       mov       byte ptr [r8+1C],0
       movzx     ecx,byte ptr [r14+1D]
       add       ecx,1
       jo        near ptr M00_L51
       cmp       ecx,0FF
       ja        near ptr M00_L51
       mov       [r8+1D],cl
       mov       r14,r8
       jmp       near ptr M00_L06
M00_L27:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+120],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+120]
       mov       r9d,r12d
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFB41CFEEE0]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       mov       rsi,[rsp+120]
       mov       edi,[rsp+128]
       mov       r14d,[rsp+12C]
       mov       rdx,rbp
       mov       rcx,7FFB41DDA3A0
       mov       r8,2186F3D15E8
       call      qword ptr [7FFB41CF54D0]; System.Collections.Immutable.Requires.NotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String)
       mov       r8d,edi
       test      r14d,r14d
       jne       short M00_L28
       mov       r8d,edi
       add       r8d,[rbp+20]
M00_L28:
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFB41CF5740]; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32)
       mov       [rsp+0E0],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+0E0]
       mov       rdx,7FFB41D2F310
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF57A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,138
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L29:
       mov       rcx,[rcx+10]
M00_L30:
       cmp       qword ptr [rcx+8],0
       je        near ptr M00_L11
       mov       r10d,[rsp+134]
M00_L31:
       mov       edx,[rcx+18]
       cmp       r10d,edx
       je        near ptr M00_L36
       jg        short M00_L29
       mov       rcx,[rcx+8]
       jmp       short M00_L30
M00_L32:
       call      qword ptr [7FFB41ACEB68]
       mov       ecx,65
       mov       rdx,7FFB4192C248
       call      qword ptr [7FFB4152F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417F5AC0
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4192C248
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CFC420]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CFC438]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L33:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L35:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L36:
       mov       r9,[rcx+20]
       mov       r11,[rcx+28]
       jmp       near ptr M00_L12
M00_L37:
       mov       rcx,r15
       mov       [rsp+70],r9
       mov       r8,r9
       mov       rdx,[rsp+0B0]
       mov       r11,7FFB41470C30
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L38
       mov       [rsp+20],r15
       mov       r11,[rsp+68]
       mov       r9d,[r11+20]
       mov       [rsp+68],r11
       mov       rcx,r11
       mov       rdx,[rsp+0B0]
       xor       r8d,r8d
       call      qword ptr [7FFB41CFECD0]
       test      eax,eax
       jl        short M00_L39
M00_L38:
       mov       ecx,1
       mov       rax,[rsp+70]
       mov       r10,[rsp+68]
       mov       edx,ecx
       mov       rcx,rax
       mov       r11,r10
       jmp       near ptr M00_L13
M00_L39:
       xor       edx,edx
       mov       [rsp+130],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+110],xmm0
       mov       rcx,[rsp+68]
       mov       rdx,[rsp+0B0]
       call      qword ptr [7FFB41CFECE8]
       mov       rcx,[rsp+70]
       mov       [rsp+110],rcx
       test      rax,rax
       jne       short M00_L40
       mov       rax,1D7DA402A48
       mov       rax,[rax]
M00_L40:
       mov       [rsp+118],rax
       mov       rcx,[rsp+110]
       mov       rax,rcx
       mov       r11,[rsp+118]
       mov       r10,r11
       mov       rcx,rax
       mov       r11,r10
       mov       edx,[rsp+130]
       jmp       near ptr M00_L13
M00_L41:
       mov       r10d,[rsp+134]
       lea       r8,[rsp+0F8]
       mov       rcx,r14
       mov       edx,r10d
       call      qword ptr [7FFB41CFEEC8]
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L42:
       mov       edx,[r14+18]
       mov       [rsp+0EC],edx
       mov       r8,[r14+20]
       mov       [rsp+50],r8
       mov       r10,[r14+28]
       mov       [rsp+48],r10
       mov       r9,[r14+8]
       mov       [rsp+90],r9
       test      rax,rax
       mov       [rsp+88],rax
       jne       short M00_L43
       mov       rax,[r14+10]
       mov       [rsp+88],rax
M00_L43:
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rsp+50]
       mov       [rsp+0D0],r8
       mov       r8,[rsp+48]
       mov       [rsp+0D8],r8
       mov       r8,[rsp+88]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0D0]
       mov       edx,[rsp+0EC]
       mov       rcx,r14
       mov       r9,[rsp+90]
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r9,r14
       jmp       near ptr M00_L16
M00_L44:
       mov       edx,[r14+18]
       mov       [rsp+0E8],edx
       mov       r8,[r14+20]
       mov       [rsp+40],r8
       mov       r10,[r14+28]
       mov       [rsp+38],r10
       test      rax,rax
       mov       [rsp+80],rax
       jne       short M00_L45
       mov       rax,[r14+8]
       mov       [rsp+80],rax
M00_L45:
       mov       r14,[r14+10]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rsp+78],r9
       mov       r8,[rsp+40]
       mov       [rsp+0D0],r8
       mov       r8,[rsp+38]
       mov       [rsp+0D8],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0D0]
       mov       edx,[rsp+0E8]
       mov       rcx,r9
       mov       r9,[rsp+80]
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+78]
       mov       r9,r14
       jmp       near ptr M00_L22
M00_L46:
       vmovdqu   xmm0,xmmword ptr [r14+20]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       mov       [rsp+60],rcx
       mov       [rsp+0C0],rcx
       mov       [rsp+58],r11
       mov       [rsp+0C8],r11
       lea       r8,[rsp+0C0]
       lea       rdx,[rsp+0D0]
       mov       rcx,r13
       mov       r11,7FFB41470C38
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L47
       xor       ecx,ecx
       mov       [rsp+0F0],ecx
       jmp       near ptr M00_L06
M00_L47:
       mov       dword ptr [rsp+0F0],1
       mov       dword ptr [rsp+0F8],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A0],rax
       mov       r10,[rsp+60]
       mov       [rsp+0D0],r10
       mov       r11,[rsp+58]
       mov       [rsp+0D8],r11
       mov       r8,[r14+10]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0D0]
       mov       r9,[r14+8]
       mov       edx,[rsp+134]
       mov       rcx,rax
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0A0]
       mov       [rsp+0A8],r14
       jmp       near ptr M00_L17
M00_L48:
       mov       r14,[rsp+0A8]
       jmp       near ptr M00_L06
M00_L49:
       mov       ecx,511
       mov       rdx,7FFB41CECFF8
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFEC70]
       int       3
M00_L50:
       mov       ecx,869
       mov       rdx,7FFB41CECFF8
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFEC70]
       int       3
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2685
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L03
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M02_L04
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M02_L05
       test      rbp,rbp
       je        short M02_L00
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M02_L00:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M02_L07
       cmp       ecx,0FF
       ja        near ptr M02_L07
       mov       [rbx+1D],cl
M02_L01:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M02_L06
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rdi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M02_L07
       cmp       ecx,0FF
       ja        near ptr M02_L07
       mov       [rdi+1D],cl
       mov       rax,rdi
M02_L02:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       ecx,869
       mov       rdx,7FFB41CECFF8
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFEC70]
       int       3
M02_L04:
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L05:
       mov       r14d,[rbx+18]
       mov       r15,[rbx+20]
       mov       r13,[rbx+28]
       test      rbp,rbp
       cmove     rbp,rsi
       mov       rsi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+38],r15
       mov       [rsp+40],r13
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,r14d
       mov       rcx,rbx
       mov       r9,rbp
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M02_L01
M02_L06:
       mov       esi,[rdi+18]
       mov       rbp,[rdi+20]
       mov       r14,[rdi+28]
       mov       r15,[rdi+8]
       mov       rcx,[rdi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+38],rbp
       mov       [rsp+40],r14
       mov       [rsp+20],rbx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,esi
       mov       rcx,rdi
       mov       r9,r15
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M02_L02
M02_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 438
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
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
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M03_L14
       mov       rsi,[rbx+10]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M03_L08
       test      rsi,rsi
       je        near ptr M03_L14
       cmp       qword ptr [rdi+8],0
       je        near ptr M03_L09
       mov       rbp,rdi
       mov       rdx,[rbp+10]
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M03_L10
       test      r14,r14
       je        short M03_L00
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M03_L00:
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L18
       cmp       ecx,0FF
       ja        near ptr M03_L18
       mov       [rsi+1D],cl
M03_L01:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M03_L11
       lea       rcx,[rbp+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbp+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L18
       cmp       ecx,0FF
       ja        near ptr M03_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M03_L02:
       mov       rsi,rdx
M03_L03:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L12
       test      rsi,rsi
       je        short M03_L04
       lea       rcx,[rbx+10]
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
       jo        near ptr M03_L18
       cmp       ecx,0FF
       ja        near ptr M03_L18
       mov       [rbx+1D],cl
M03_L05:
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M03_L15
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L16
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L18
       cmp       ecx,0FF
       ja        near ptr M03_L18
       mov       [rbx+1D],cl
M03_L06:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M03_L17
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M03_L18
       cmp       ecx,0FF
       ja        near ptr M03_L18
       mov       [rsi+1D],cl
       mov       rax,rsi
M03_L07:
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
M03_L08:
       mov       rax,rbx
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
M03_L09:
       jmp       near ptr M03_L03
M03_L10:
       mov       r15d,[rsi+18]
       mov       r13,[rsi+20]
       mov       r12,[rsi+28]
       test      r14,r14
       cmove     r14,rdi
       mov       rdi,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],r13
       mov       [rsp+38],r12
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M03_L01
M03_L11:
       mov       edi,[rbp+18]
       mov       r14,[rbp+20]
       mov       r15,[rbp+28]
       mov       r13,[rbp+8]
       mov       rcx,[rbp]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbp
       mov       r9,r13
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M03_L02
M03_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       mov       r15,[rbx+8]
       test      rsi,rsi
       jne       short M03_L13
       mov       rsi,[rbx+10]
M03_L13:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbx
       mov       r9,r15
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M03_L05
M03_L14:
       mov       ecx,869
       mov       rdx,7FFB41CECFF8
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFEC70]
       int       3
M03_L15:
       mov       rax,rbx
       jmp       near ptr M03_L07
M03_L16:
       mov       ebp,[rbx+18]
       mov       r14,[rbx+20]
       mov       r15,[rbx+28]
       mov       r13,[rbx+8]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,ebp
       mov       rcx,rbx
       mov       r9,r13
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M03_L06
M03_L17:
       mov       edi,[rsi+18]
       mov       rbp,[rsi+20]
       mov       r14,[rsi+28]
       mov       r15,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rsi
       mov       r9,rbx
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M03_L07
M03_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 943
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M04_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       rbp,r9
       mov       r15,[rsp+0D8]
       mov       r14,[rsp+0E0]
       mov       byte ptr [r15],0
       cmp       qword ptr [rbx+8],0
       je        near ptr M04_L11
       mov       r13,rbx
       cmp       edi,[r13+18]
       jle       near ptr M04_L03
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF5638]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        short M04_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M04_L12
       test      rdi,rdi
       je        short M04_L01
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M04_L01:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M04_L23
       cmp       ecx,0FF
       ja        near ptr M04_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M04_L02:
       cmp       byte ptr [r14],0
       je        near ptr M04_L21
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M04_L22
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jl        near ptr M04_L06
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M04_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       js        near ptr M04_L09
       mov       rdx,r13
       call      qword ptr [7FFB41CF5710]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M04_L10
M04_L03:
       cmp       edi,[r13+18]
       jge       near ptr M04_L16
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF5638]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        near ptr M04_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M04_L14
       test      rsi,rsi
       je        short M04_L04
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M04_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M04_L23
       cmp       ecx,0FF
       ja        near ptr M04_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M04_L05:
       jmp       near ptr M04_L02
M04_L06:
       cmp       edx,0FFFFFFFE
       jle       short M04_L07
       mov       rax,r13
       jmp       short M04_L10
M04_L07:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M04_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M04_L08
       mov       rdx,r13
       call      qword ptr [7FFB41CF56F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M04_L10
M04_L08:
       mov       rdx,r13
       call      qword ptr [7FFB41CF56E0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M04_L10
M04_L09:
       mov       rdx,r13
       call      qword ptr [7FFB41CF5728]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M04_L10:
       nop
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
M04_L11:
       mov       byte ptr [r14],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rbp+18],edi
       lea       rdi,[rbp+20]
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
       jo        near ptr M04_L23
       cmp       eax,0FF
       ja        near ptr M04_L23
       mov       [rbp+1D],al
       mov       rax,rbp
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
M04_L12:
       mov       r13d,[rbx+18]
       mov       r15,[rbx+20]
       mov       rsi,[rbx+28]
       mov       rbp,[rbx+8]
       test      rdi,rdi
       jne       short M04_L13
       mov       rdi,[rbx+10]
M04_L13:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       [rsp+50],r15
       mov       [rsp+58],rsi
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+50]
       mov       edx,r13d
       mov       rcx,r12
       mov       r9,rbp
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M04_L02
M04_L14:
       mov       r13d,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r15,[rbx+28]
       test      rsi,rsi
       jne       short M04_L15
       mov       rsi,[rbx+8]
M04_L15:
       mov       rdi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       [rsp+50],rbp
       mov       [rsp+58],r15
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+50]
       mov       edx,r13d
       mov       rcx,r12
       mov       r9,rsi
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M04_L05
M04_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M04_L17
       jmp       short M04_L18
M04_L17:
       mov       rdx,7FFB41D8FD18
       call      qword ptr [7FFB4152F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M04_L18:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rdx,[rsp+50]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M04_L19
       mov       byte ptr [r14],0
       mov       rax,rbx
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
M04_L19:
       cmp       byte ptr [rsp+0D0],0
       je        short M04_L20
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
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M04_L02
M04_L20:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFB41CFEC88]
       mov       rsi,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFB41CFECA0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB41895E60]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M04_L21:
       mov       rax,r13
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
M04_L22:
       mov       ecx,869
       mov       rdx,7FFB41CECFF8
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFEC70]
       int       3
M04_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1145
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L02
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M05_L03
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M05_L04
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L06
       cmp       ecx,0FF
       ja        near ptr M05_L06
       mov       [rbx+1D],cl
M05_L00:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M05_L05
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L06
       cmp       ecx,0FF
       ja        near ptr M05_L06
       mov       [rsi+1D],cl
       mov       rax,rsi
M05_L01:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L02:
       mov       ecx,869
       mov       rdx,7FFB41CECFF8
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFEC70]
       int       3
M05_L03:
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L04:
       mov       ebp,[rbx+18]
       mov       r14,[rbx+20]
       mov       r15,[rbx+28]
       mov       r13,[rbx+8]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+38],r14
       mov       [rsp+40],r15
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,ebp
       mov       rcx,rbx
       mov       r9,r13
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M05_L00
M05_L05:
       mov       edi,[rsi+18]
       mov       rbp,[rsi+20]
       mov       r14,[rsi+28]
       mov       r15,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+38],rbp
       mov       [rsp+40],r14
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,edi
       mov       rcx,rsi
       mov       r9,rbx
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M05_L01
M05_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 419
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
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
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M06_L14
       mov       rsi,[rbx+8]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M06_L08
       test      rsi,rsi
       je        near ptr M06_L14
       mov       rbp,[rsi+10]
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M06_L09
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M06_L10
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rdi+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rsi+1D],cl
M06_L00:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M06_L11
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbp+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M06_L01:
       mov       rsi,rdx
M06_L02:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L12
       test      rsi,rsi
       je        short M06_L03
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M06_L03:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rbx+1D],cl
M06_L04:
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M06_L15
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L16
       test      rbp,rbp
       je        short M06_L05
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M06_L05:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rbx+1D],cl
M06_L06:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M06_L17
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rdi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rdi+1D],cl
       mov       rax,rdi
M06_L07:
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
M06_L08:
       mov       rax,rbx
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
M06_L09:
       jmp       near ptr M06_L02
M06_L10:
       mov       r15d,[rsi+18]
       mov       r13,[rsi+20]
       mov       r12,[rsi+28]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],r13
       mov       [rsp+38],r12
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       rcx,rsi
       mov       r9,rdi
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L00
M06_L11:
       mov       edi,[rbp+18]
       mov       r14,[rbp+20]
       mov       r15,[rbp+28]
       mov       r13,[rbp+10]
       mov       rcx,[rbp]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],r13
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbp
       mov       r9,rsi
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M06_L01
M06_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       test      rsi,rsi
       jne       short M06_L13
       mov       rsi,[rbx+8]
M06_L13:
       mov       r15,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbx
       mov       r9,rsi
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L04
M06_L14:
       mov       ecx,869
       mov       rdx,7FFB41CECFF8
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFEC70]
       int       3
M06_L15:
       mov       rax,rbx
       jmp       near ptr M06_L07
M06_L16:
       mov       r14d,[rbx+18]
       mov       r15,[rbx+20]
       mov       r13,[rbx+28]
       test      rbp,rbp
       cmove     rbp,rsi
       mov       rsi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],r15
       mov       [rsp+38],r13
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r14d
       mov       rcx,rbx
       mov       r9,rbp
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L06
M06_L17:
       mov       esi,[rdi+18]
       mov       rbp,[rdi+20]
       mov       r14,[rdi+28]
       mov       r15,[rdi+8]
       mov       rcx,[rdi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],rbx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,esi
       mov       rcx,rdi
       mov       r9,r15
       call      qword ptr [7FFB41CF5650]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M06_L07
M06_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 941
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
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
       mov       esi,[rsp+60]
       mov       [rbx+0C],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       mov       ecx,4AB
       mov       rdx,7FFB41CECFF8
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFEC70]
       int       3
; Total bytes of code 76
```
```assembly
; System.Collections.Immutable.Requires.NotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String)
       sub       rsp,28
       test      rdx,rdx
       je        short M08_L00
       add       rsp,28
       ret
M08_L00:
       mov       rcx,r8
       call      qword ptr [7FFB41CFEC70]
       int       3
; Total bytes of code 24
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1[[System.__Canon, System.Private.CoreLib]].Wrap(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       cmp       rbx,[rsi+10]
       je        near ptr M09_L04
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14,[rsi+8]
       test      rbx,rbx
       je        near ptr M09_L05
       test      r14,r14
       je        near ptr M09_L06
       mov       r15,[rbp]
       mov       rcx,r15
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r13,[rax+8]
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M09_L01
       test      r13,r13
       je        short M09_L00
       mov       r12d,[rbx+18]
       mov       rax,[rbx+20]
       mov       rdx,[rbx+28]
       mov       [rsp+20],rdx
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__89_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [r13+18],rcx
       jne       near ptr M09_L07
       mov       rcx,[r13+8]
       cmp       [rcx],ecx
       test      rdx,rdx
       je        short M09_L00
       cmp       byte ptr [rdx+24],0
       jne       short M09_L00
       mov       rcx,[rdx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF5788]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       r12,[rsp+20]
       mov       rcx,[r12+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF5788]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r12+24],1
M09_L00:
       mov       rcx,[rbx+8]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF5500]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       rcx,[rbx+10]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF5500]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       byte ptr [rbx+1C],1
M09_L01:
       lea       rcx,[rbp+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+20],edi
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M09_L03
M09_L02:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbp
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
M09_L03:
       mov       rdx,7FFB41DC4920
       call      qword ptr [7FFB4152F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M09_L02
M09_L04:
       mov       rax,rsi
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
M09_L05:
       mov       ecx,4AB
       mov       rdx,7FFB41CECFF8
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFEC70]
       int       3
M09_L06:
       mov       ecx,4B5
       mov       rdx,7FFB41CECFF8
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFEC70]
       int       3
M09_L07:
       mov       [rsp+28],r12d
       mov       [rsp+30],rax
       mov       [rsp+38],rdx
       lea       rdx,[rsp+28]
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       jmp       near ptr M09_L00
; Total bytes of code 470
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
       je        near ptr M11_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M11_L01
       test      rsi,rsi
       je        short M11_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M11_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M11_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M11_L00:
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
M11_L01:
       test      rsi,rsi
       je        short M11_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M11_L03
M11_L02:
       mov       rax,2186F3C0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M11_L03:
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
M11_L04:
       call      qword ptr [7FFB41CFE628]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FFB41525C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
       je        short M13_L00
       test      r14,r14
       je        near ptr M13_L01
       mov       [rbx+18],edx
       lea       rdi,[rbx+20]
       mov       rsi,r8
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
       jo        short M13_L02
       cmp       ecx,0FF
       ja        short M13_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M13_L00:
       mov       ecx,847
       mov       rdx,7FFB41CECFF8
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFEC70]
       int       3
M13_L01:
       mov       ecx,851
       mov       rdx,7FFB41CECFF8
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFEC70]
       int       3
M13_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 215
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,178
       xor       eax,eax
       mov       [rsp+0E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+0F0],ymm4
       vmovdqu   ymmword ptr [rsp+110],ymm4
       vmovdqu   ymmword ptr [rsp+130],ymm4
       vmovdqu   ymmword ptr [rsp+150],ymm4
       mov       [rsp+170],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L34
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L35
       mov       rcx,rsi
       mov       r11,7FFB41480C18
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB41DDA5E0],1
       je        near ptr M00_L36
M00_L00:
       mov       rdx,19D6D002AD8
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB41480C20
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L37
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       rcx,19D6D002A20
       mov       rbp,[rcx]
       mov       r14,[rbp+10]
       mov       r15,[rbp+8]
       mov       r13,[rbp+18]
       xor       r12d,r12d
       xor       eax,eax
       inc       edi
M00_L04:
       dec       edi
       je        near ptr M00_L30
       mov       [rsp+0E0],rax
       mov       r8,[rsi+rax]
       mov       [rsp+0D8],r8
       test      r8,r8
       je        short M00_L05
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FFB41480C28
       call      qword ptr [r11]
       mov       r10d,eax
       mov       r8,[rsp+0D8]
       jmp       short M00_L06
M00_L05:
       xor       ecx,ecx
       xor       r10d,r10d
M00_L06:
       mov       [rsp+164],r10d
       cmp       [r14],r14b
       mov       rcx,r14
       cmp       qword ptr [r14+8],0
       jne       near ptr M00_L33
M00_L07:
       xor       r9d,r9d
       xor       r11d,r11d
M00_L08:
       mov       [rsp+78],r11
       test      r11,r11
       jne       near ptr M00_L39
       xor       edx,edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+130],xmm0
       mov       [rsp+130],r8
       mov       rcx,19D6D002A48
       mov       rcx,[rcx]
       mov       [rsp+138],rcx
       mov       rcx,[rsp+130]
       mov       r11,[rsp+138]
M00_L09:
       test      edx,edx
       jne       near ptr M00_L17
       test      r11,r11
       je        near ptr M00_L43
       test      r13,r13
       je        near ptr M00_L53
       xor       r8d,r8d
       mov       [rsp+128],r8d
       cmp       qword ptr [r14+8],0
       je        near ptr M00_L29
       mov       r9,r14
       mov       r10d,[rsp+164]
       cmp       r10d,[r9+18]
       jg        near ptr M00_L19
       cmp       r10d,[r9+18]
       jge       near ptr M00_L48
       mov       [rsp+0D0],r9
       mov       r8,[r9+8]
       mov       [rsp+0F8],rcx
       mov       [rsp+100],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+128]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+120]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+0F8]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D15B30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+120],0
       je        short M00_L13
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L46
       test      rax,rax
       je        short M00_L10
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L10:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L18
M00_L11:
       add       ecx,1
       jo        near ptr M00_L55
       cmp       ecx,0FF
       ja        near ptr M00_L55
       mov       [r14+1D],cl
       mov       r9,r14
M00_L12:
       mov       r14,r9
       mov       [rsp+0D0],r14
M00_L13:
       cmp       byte ptr [rsp+120],0
       je        near ptr M00_L50
       mov       r14,[rsp+0D0]
       test      r14,r14
       je        near ptr M00_L54
       mov       rax,[r14+10]
       movzx     edx,byte ptr [rax+1D]
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       edx,ecx
       cmp       edx,2
       jl        near ptr M00_L24
       mov       rdx,rax
       test      rdx,rdx
       je        near ptr M00_L54
       mov       rcx,[rdx+10]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       ecx,edx
       js        near ptr M00_L27
       cmp       qword ptr [rax+8],0
       je        near ptr M00_L51
       mov       [rsp+98],rax
       mov       rdx,[rax+8]
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L52
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L28
M00_L14:
       add       ecx,1
       jo        near ptr M00_L55
       cmp       ecx,0FF
       ja        near ptr M00_L55
       mov       [r14+1D],cl
       mov       rdx,r14
M00_L15:
       mov       rcx,[rsp+98]
       xor       r8d,r8d
       call      qword ptr [7FFB41D15B60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M00_L16:
       mov       r14,rax
       inc       r12d
M00_L17:
       mov       rax,[rsp+0E0]
       add       rax,8
       jmp       near ptr M00_L04
M00_L18:
       mov       ecx,eax
       jmp       near ptr M00_L11
M00_L19:
       mov       [rsp+0D0],r9
       mov       r8,[r9+10]
       mov       [rsp+0F8],rcx
       mov       [rsp+100],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+128]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+120]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+0F8]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D15B30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+120],0
       je        near ptr M00_L13
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L44
       test      rax,rax
       je        short M00_L20
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L20:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        short M00_L23
M00_L21:
       add       ecx,1
       jo        near ptr M00_L55
       cmp       ecx,0FF
       ja        near ptr M00_L55
       mov       [r14+1D],cl
       mov       r9,r14
M00_L22:
       mov       r14,r9
       mov       [rsp+0D0],r14
       jmp       near ptr M00_L13
M00_L23:
       mov       ecx,eax
       jmp       short M00_L21
M00_L24:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41D15BC0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jne       short M00_L25
       mov       rax,r14
       jmp       near ptr M00_L16
M00_L25:
       mov       rdx,[r14+8]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41D15BA8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jle       short M00_L26
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41D15C08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M00_L16
M00_L26:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41D15BD8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M00_L16
M00_L27:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41D15C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M00_L16
M00_L28:
       mov       ecx,eax
       jmp       near ptr M00_L14
M00_L29:
       mov       [rsp+68],r11
       mov       [rsp+70],rcx
       mov       dword ptr [rsp+120],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0C0],rax
       mov       r8d,[rsp+164]
       mov       [rax+18],r8d
       lea       rcx,[rax+20]
       mov       rdx,[rsp+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0C0]
       lea       rcx,[rax+28]
       mov       rdx,[rsp+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0C0]
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0C0]
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0C0]
       mov       byte ptr [rax+1C],0
       movzx     r8d,byte ptr [r14+1D]
       add       r8d,1
       jo        near ptr M00_L55
       cmp       r8d,0FF
       ja        near ptr M00_L55
       mov       [rax+1D],r8b
       jmp       near ptr M00_L16
M00_L30:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+150],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+150]
       mov       r9d,r12d
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFB41D1EE68]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rsp+150]
       vmovdqu   xmmword ptr [rsp+168],xmm0
       lea       rcx,[rsp+168]
       mov       r8,rbp
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFB41D1EE80]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableHashSet`1<System.__Canon>)
       mov       [rsp+108],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+108]
       mov       rdx,7FFB41D4D038
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D15C98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,178
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L31:
       mov       rcx,[rcx+10]
M00_L32:
       cmp       qword ptr [rcx+8],0
       je        near ptr M00_L07
       mov       r10d,[rsp+164]
M00_L33:
       mov       edx,[rcx+18]
       cmp       r10d,edx
       je        near ptr M00_L38
       jg        short M00_L31
       mov       rcx,[rcx+8]
       jmp       short M00_L32
M00_L34:
       call      qword ptr [7FFB41ADEFA0]
       mov       ecx,65
       mov       rdx,7FFB4193C248
       call      qword ptr [7FFB4153F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB41805AC0
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4193C248
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D1C420]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D1C438]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L35:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L36:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L37:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L38:
       mov       r9,[rcx+20]
       mov       r11,[rcx+28]
       jmp       near ptr M00_L08
M00_L39:
       mov       rcx,r15
       mov       [rsp+80],r9
       mov       r8,r9
       mov       rdx,[rsp+0D8]
       mov       r11,7FFB41480C30
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L40
       mov       [rsp+20],r15
       mov       r11,[rsp+78]
       mov       r9d,[r11+20]
       mov       [rsp+78],r11
       mov       rcx,r11
       mov       rdx,[rsp+0D8]
       xor       r8d,r8d
       call      qword ptr [7FFB41D1EBF8]
       test      eax,eax
       jl        short M00_L41
M00_L40:
       mov       ecx,1
       mov       rax,[rsp+80]
       mov       r10,[rsp+78]
       mov       edx,ecx
       mov       rcx,rax
       mov       r11,r10
       jmp       near ptr M00_L09
M00_L41:
       xor       edx,edx
       mov       [rsp+160],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+140],xmm0
       mov       rcx,[rsp+78]
       mov       rdx,[rsp+0D8]
       call      qword ptr [7FFB41D1EC10]
       mov       rcx,[rsp+80]
       mov       [rsp+140],rcx
       test      rax,rax
       jne       short M00_L42
       mov       rax,19D6D002A48
       mov       rax,[rax]
M00_L42:
       mov       [rsp+148],rax
       mov       rcx,[rsp+140]
       mov       rax,rcx
       mov       r11,[rsp+148]
       mov       r10,r11
       mov       rcx,rax
       mov       r11,r10
       mov       edx,[rsp+160]
       jmp       near ptr M00_L09
M00_L43:
       mov       r10d,[rsp+164]
       lea       r8,[rsp+128]
       mov       rcx,r14
       mov       edx,r10d
       call      qword ptr [7FFB41D1EE50]
       jmp       near ptr M00_L16
M00_L44:
       mov       edx,[r14+18]
       mov       [rsp+11C],edx
       mov       r8,[r14+20]
       mov       [rsp+60],r8
       mov       r10,[r14+28]
       mov       [rsp+58],r10
       mov       r9,[r14+8]
       mov       [rsp+0B8],r9
       test      rax,rax
       mov       [rsp+0B0],rax
       jne       short M00_L45
       mov       rax,[r14+10]
       mov       [rsp+0B0],rax
M00_L45:
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rsp+60]
       mov       [rsp+0F8],r8
       mov       r8,[rsp+58]
       mov       [rsp+100],r8
       mov       r8,[rsp+0B0]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0F8]
       mov       edx,[rsp+11C]
       mov       rcx,r14
       mov       r9,[rsp+0B8]
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r9,r14
       jmp       near ptr M00_L22
M00_L46:
       mov       edx,[r14+18]
       mov       [rsp+118],edx
       mov       r8,[r14+20]
       mov       [rsp+50],r8
       mov       r10,[r14+28]
       mov       [rsp+48],r10
       test      rax,rax
       mov       [rsp+0A8],rax
       jne       short M00_L47
       mov       rax,[r14+8]
       mov       [rsp+0A8],rax
M00_L47:
       mov       r14,[r14+10]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rsp+0A0],r9
       mov       r8,[rsp+50]
       mov       [rsp+0F8],r8
       mov       r8,[rsp+48]
       mov       [rsp+100],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0F8]
       mov       edx,[rsp+118]
       mov       rcx,r9
       mov       r9,[rsp+0A8]
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0A0]
       mov       r9,r14
       jmp       near ptr M00_L12
M00_L48:
       vmovdqu   xmm0,xmmword ptr [r14+20]
       vmovdqu   xmmword ptr [rsp+0F8],xmm0
       mov       [rsp+70],rcx
       mov       [rsp+0E8],rcx
       mov       [rsp+68],r11
       mov       [rsp+0F0],r11
       lea       r8,[rsp+0E8]
       lea       rdx,[rsp+0F8]
       mov       rcx,r13
       mov       r11,7FFB41480C38
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L49
       xor       ecx,ecx
       mov       [rsp+120],ecx
       mov       rax,r14
       jmp       near ptr M00_L16
M00_L49:
       mov       dword ptr [rsp+120],1
       mov       dword ptr [rsp+128],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0C8],rax
       mov       r10,[rsp+70]
       mov       [rsp+0F8],r10
       mov       r11,[rsp+68]
       mov       [rsp+100],r11
       mov       r8,[r14+10]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0F8]
       mov       r9,[r14+8]
       mov       edx,[rsp+164]
       mov       rcx,rax
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0C8]
       mov       [rsp+0D0],r14
       jmp       near ptr M00_L13
M00_L50:
       mov       r14,[rsp+0D0]
       mov       rax,r14
       jmp       near ptr M00_L16
M00_L51:
       mov       rax,r14
       jmp       near ptr M00_L16
M00_L52:
       mov       r8d,[r14+18]
       mov       [rsp+114],r8d
       mov       r10,[r14+20]
       mov       [rsp+40],r10
       mov       r9,[r14+28]
       mov       [rsp+38],r9
       mov       r14,[r14+8]
       mov       [rsp+90],rdx
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+88],rax
       mov       r8,[rsp+40]
       mov       [rsp+0F8],r8
       mov       r8,[rsp+38]
       mov       [rsp+100],r8
       mov       r8,[rsp+90]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0F8]
       mov       edx,[rsp+114]
       mov       rcx,[rsp+88]
       mov       r9,r14
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+88]
       mov       rdx,r14
       jmp       near ptr M00_L15
M00_L53:
       mov       ecx,511
       mov       rdx,7FFB41D2ADB0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D1EB98]
       int       3
M00_L54:
       mov       ecx,869
       mov       rdx,7FFB41D2ADB0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D1EB98]
       int       3
M00_L55:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2955
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M02_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       rbp,r9
       mov       r15,[rsp+0D8]
       mov       r14,[rsp+0E0]
       mov       byte ptr [r15],0
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L11
       mov       r13,rbx
       cmp       edi,[r13+18]
       jg        near ptr M02_L03
       cmp       edi,[r13+18]
       jge       near ptr M02_L16
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D15B30]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        short M02_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M02_L14
       test      rsi,rsi
       je        short M02_L01
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M02_L01:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M02_L23
       cmp       ecx,0FF
       ja        near ptr M02_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M02_L02:
       cmp       byte ptr [r14],0
       je        near ptr M02_L21
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M02_L22
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jl        near ptr M02_L06
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M02_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       js        near ptr M02_L09
       mov       rdx,r13
       call      qword ptr [7FFB41D15BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M02_L10
M02_L03:
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D15B30]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        near ptr M02_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M02_L12
       test      rdi,rdi
       je        short M02_L04
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M02_L23
       cmp       ecx,0FF
       ja        near ptr M02_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M02_L05:
       jmp       near ptr M02_L02
M02_L06:
       cmp       edx,0FFFFFFFE
       jle       short M02_L07
       mov       rax,r13
       jmp       short M02_L10
M02_L07:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M02_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M02_L08
       mov       rdx,r13
       call      qword ptr [7FFB41D15C08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M02_L10
M02_L08:
       mov       rdx,r13
       call      qword ptr [7FFB41D15BD8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M02_L10
M02_L09:
       mov       rdx,r13
       call      qword ptr [7FFB41D15C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M02_L10:
       nop
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
M02_L11:
       mov       byte ptr [r14],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rbp+18],edi
       lea       rdi,[rbp+20]
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
       jo        near ptr M02_L23
       cmp       eax,0FF
       ja        near ptr M02_L23
       mov       [rbp+1D],al
       mov       rax,rbp
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
M02_L12:
       mov       r13d,[rbx+18]
       mov       rsi,[rbx+20]
       mov       rbp,[rbx+28]
       mov       r15,[rbx+8]
       test      rdi,rdi
       jne       short M02_L13
       mov       rdi,[rbx+10]
M02_L13:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       [rsp+50],rsi
       mov       [rsp+58],rbp
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+50]
       mov       edx,r13d
       mov       rcx,r12
       mov       r9,r15
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M02_L05
M02_L14:
       mov       r13d,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r15,[rbx+28]
       test      rsi,rsi
       jne       short M02_L15
       mov       rsi,[rbx+8]
M02_L15:
       mov       rdi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       [rsp+50],rbp
       mov       [rsp+58],r15
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+50]
       mov       edx,r13d
       mov       rcx,r12
       mov       r9,rsi
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M02_L02
M02_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFB41DAD778
       call      qword ptr [7FFB4153F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L18:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rdx,[rsp+50]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L19
       mov       byte ptr [r14],0
       mov       rax,rbx
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
M02_L19:
       cmp       byte ptr [rsp+0D0],0
       je        short M02_L20
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
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M02_L02
M02_L20:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFB41D1EBB0]
       mov       r15,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFB41D1EBC8]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB418A5E60]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M02_L21:
       mov       rax,r13
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
M02_L22:
       mov       ecx,869
       mov       rdx,7FFB41D2ADB0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D1EB98]
       int       3
M02_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1145
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbx,rcx
       mov       rsi,r8
       cmp       byte ptr [rbx+1C],0
       jne       short M03_L02
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M03_L00:
       test      rsi,rsi
       je        short M03_L01
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rax,[rbx+8]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rbx+10]
       movzx     ecx,byte ptr [rcx+1D]
       cmp       eax,ecx
       cmovl     eax,ecx
       add       eax,1
       jo        near ptr M03_L05
       cmp       eax,0FF
       ja        near ptr M03_L05
       mov       [rbx+1D],al
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L02:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       mov       r15,rdx
       test      r15,r15
       jne       short M03_L03
       mov       r15,[rbx+8]
M03_L03:
       test      rsi,rsi
       jne       short M03_L04
       mov       rsi,[rbx+10]
M03_L04:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       [rsp+38],rbp
       mov       [rsp+40],r14
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,edi
       mov       rcx,r13
       mov       r9,r15
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,r13
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 245
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M04_L00
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rdx+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       eax,ecx
       cmp       eax,0FFFFFFFE
       setle     al
       movzx     eax,al
       add       rsp,28
       ret
M04_L00:
       mov       ecx,869
       mov       rdx,7FFB41D2ADB0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D1EB98]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M05_L00
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rdx+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       eax,ecx
       add       rsp,28
       ret
M05_L00:
       mov       ecx,869
       mov       rdx,7FFB41D2ADB0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D1EB98]
       int       3
; Total bytes of code 63
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
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
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M06_L14
       mov       rsi,[rbx+8]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M06_L08
       test      rsi,rsi
       je        near ptr M06_L14
       mov       rbp,[rsi+10]
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M06_L09
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M06_L10
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rdi+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rsi+1D],cl
M06_L00:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M06_L11
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbp+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M06_L01:
       mov       rsi,rdx
M06_L02:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L12
       test      rsi,rsi
       je        short M06_L03
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M06_L03:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rbx+1D],cl
M06_L04:
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M06_L15
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L16
       test      rbp,rbp
       je        short M06_L05
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M06_L05:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rbx+1D],cl
M06_L06:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M06_L17
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rdi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rdi+1D],cl
       mov       rax,rdi
M06_L07:
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
M06_L08:
       mov       rax,rbx
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
M06_L09:
       jmp       near ptr M06_L02
M06_L10:
       mov       r15d,[rsi+18]
       mov       r13,[rsi+20]
       mov       r12,[rsi+28]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],r13
       mov       [rsp+38],r12
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       rcx,rsi
       mov       r9,rdi
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L00
M06_L11:
       mov       edi,[rbp+18]
       mov       r14,[rbp+20]
       mov       r15,[rbp+28]
       mov       r13,[rbp+10]
       mov       rcx,[rbp]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],r13
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbp
       mov       r9,rsi
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M06_L01
M06_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       test      rsi,rsi
       jne       short M06_L13
       mov       rsi,[rbx+8]
M06_L13:
       mov       r15,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbx
       mov       r9,rsi
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L04
M06_L14:
       mov       ecx,869
       mov       rdx,7FFB41D2ADB0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D1EB98]
       int       3
M06_L15:
       mov       rax,rbx
       jmp       near ptr M06_L07
M06_L16:
       mov       r14d,[rbx+18]
       mov       r15,[rbx+20]
       mov       r13,[rbx+28]
       test      rbp,rbp
       cmove     rbp,rsi
       mov       rsi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],r15
       mov       [rsp+38],r13
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r14d
       mov       rcx,rbx
       mov       r9,rbp
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L06
M06_L17:
       mov       esi,[rdi+18]
       mov       rbp,[rdi+20]
       mov       r14,[rdi+28]
       mov       r15,[rdi+8]
       mov       rcx,[rdi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],rbx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,esi
       mov       rcx,rdi
       mov       r9,r15
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M06_L07
M06_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 941
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M07_L03
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M07_L04
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M07_L05
       test      rbp,rbp
       je        short M07_L00
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M07_L00:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L07
       cmp       ecx,0FF
       ja        near ptr M07_L07
       mov       [rbx+1D],cl
M07_L01:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M07_L06
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rdi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L07
       cmp       ecx,0FF
       ja        near ptr M07_L07
       mov       [rdi+1D],cl
       mov       rax,rdi
M07_L02:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L03:
       mov       ecx,869
       mov       rdx,7FFB41D2ADB0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D1EB98]
       int       3
M07_L04:
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L05:
       mov       r14d,[rbx+18]
       mov       r15,[rbx+20]
       mov       r13,[rbx+28]
       test      rbp,rbp
       cmove     rbp,rsi
       mov       rsi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+38],r15
       mov       [rsp+40],r13
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,r14d
       mov       rcx,rbx
       mov       r9,rbp
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M07_L01
M07_L06:
       mov       esi,[rdi+18]
       mov       rbp,[rdi+20]
       mov       r14,[rdi+28]
       mov       r15,[rdi+8]
       mov       rcx,[rdi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+38],rbp
       mov       [rsp+40],r14
       mov       [rsp+20],rbx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,esi
       mov       rcx,rdi
       mov       r9,r15
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M07_L02
M07_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 438
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
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
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M08_L14
       mov       rsi,[rbx+10]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M08_L08
       test      rsi,rsi
       je        near ptr M08_L14
       cmp       qword ptr [rdi+8],0
       je        near ptr M08_L09
       mov       rbp,rdi
       mov       rdx,[rbp+10]
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M08_L10
       test      r14,r14
       je        short M08_L00
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M08_L00:
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M08_L18
       cmp       ecx,0FF
       ja        near ptr M08_L18
       mov       [rsi+1D],cl
M08_L01:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M08_L11
       lea       rcx,[rbp+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbp+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M08_L18
       cmp       ecx,0FF
       ja        near ptr M08_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M08_L02:
       mov       rsi,rdx
M08_L03:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M08_L12
       test      rsi,rsi
       je        short M08_L04
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M08_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M08_L18
       cmp       ecx,0FF
       ja        near ptr M08_L18
       mov       [rbx+1D],cl
M08_L05:
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M08_L15
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M08_L16
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M08_L18
       cmp       ecx,0FF
       ja        near ptr M08_L18
       mov       [rbx+1D],cl
M08_L06:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M08_L17
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M08_L18
       cmp       ecx,0FF
       ja        near ptr M08_L18
       mov       [rsi+1D],cl
       mov       rax,rsi
M08_L07:
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
M08_L08:
       mov       rax,rbx
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
M08_L09:
       jmp       near ptr M08_L03
M08_L10:
       mov       r15d,[rsi+18]
       mov       r13,[rsi+20]
       mov       r12,[rsi+28]
       test      r14,r14
       cmove     r14,rdi
       mov       rdi,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],r13
       mov       [rsp+38],r12
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M08_L01
M08_L11:
       mov       edi,[rbp+18]
       mov       r14,[rbp+20]
       mov       r15,[rbp+28]
       mov       r13,[rbp+8]
       mov       rcx,[rbp]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbp
       mov       r9,r13
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M08_L02
M08_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       mov       r15,[rbx+8]
       test      rsi,rsi
       jne       short M08_L13
       mov       rsi,[rbx+10]
M08_L13:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbx
       mov       r9,r15
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M08_L05
M08_L14:
       mov       ecx,869
       mov       rdx,7FFB41D2ADB0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D1EB98]
       int       3
M08_L15:
       mov       rax,rbx
       jmp       near ptr M08_L07
M08_L16:
       mov       ebp,[rbx+18]
       mov       r14,[rbx+20]
       mov       r15,[rbx+28]
       mov       r13,[rbx+8]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,ebp
       mov       rcx,rbx
       mov       r9,r13
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M08_L06
M08_L17:
       mov       edi,[rsi+18]
       mov       rbp,[rsi+20]
       mov       r14,[rsi+28]
       mov       r15,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rsi
       mov       r9,rbx
       call      qword ptr [7FFB41D15B48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M08_L07
M08_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 943
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r9d
       test      r8,r8
       je        short M09_L00
       mov       rcx,rbx
       mov       rdx,r8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rbx+8],esi
       mov       esi,[rsp+60]
       mov       [rbx+0C],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L00:
       mov       ecx,4AB
       mov       rdx,7FFB41D2ADB0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D1EB98]
       int       3
; Total bytes of code 76
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableHashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rdx
       mov       rbx,r8
       test      rbx,rbx
       je        near ptr M10_L06
       mov       esi,[rcx+8]
       cmp       dword ptr [rcx+0C],0
       jne       short M10_L00
       add       esi,[rbx+20]
M10_L00:
       mov       rdi,[rcx]
       cmp       rdi,[rbx+10]
       je        near ptr M10_L07
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rbx,[rbx+8]
       test      rdi,rdi
       je        near ptr M10_L08
       test      rbx,rbx
       je        near ptr M10_L09
       mov       r14,[rbp]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax+8]
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M10_L02
       test      r15,r15
       je        short M10_L01
       mov       r13d,[rdi+18]
       mov       r12,[rdi+20]
       mov       rax,[rdi+28]
       mov       [rsp+20],rax
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__89_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [r15+18],rcx
       jne       near ptr M10_L10
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       test      rax,rax
       je        short M10_L01
       cmp       byte ptr [rax+24],0
       jne       short M10_L01
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D15C80]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       r12,[rsp+20]
       mov       rcx,[r12+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D15C80]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r12+24],1
M10_L01:
       mov       rcx,[rdi+8]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D159F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       rcx,[rdi+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D159F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       byte ptr [rdi+1C],1
M10_L02:
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+20],esi
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M10_L05
M10_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,rbp
M10_L04:
       mov       rax,rbx
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
M10_L05:
       mov       rdx,7FFB41DE29D8
       call      qword ptr [7FFB4153F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M10_L03
M10_L06:
       mov       ecx,577
       mov       rdx,7FFB41D2ADB0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D1EB98]
       int       3
M10_L07:
       jmp       short M10_L04
M10_L08:
       mov       ecx,4AB
       mov       rdx,7FFB41D2ADB0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D1EB98]
       int       3
M10_L09:
       mov       ecx,4B5
       mov       rdx,7FFB41D2ADB0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D1EB98]
       int       3
M10_L10:
       mov       [rsp+28],r13d
       mov       [rsp+30],r12
       mov       [rsp+38],rax
       lea       rdx,[rsp+28]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       jmp       near ptr M10_L01
; Total bytes of code 504
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
       je        near ptr M12_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M12_L01
       test      rsi,rsi
       je        short M12_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M12_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M12_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M12_L00:
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
M12_L01:
       test      rsi,rsi
       je        short M12_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M12_L03
M12_L02:
       mov       rax,1DE01FF0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M12_L03:
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
M12_L04:
       call      qword ptr [7FFB41D1E5C8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M13_L00
       ret
M13_L00:
       jmp       qword ptr [7FFB41535C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
       je        short M14_L00
       test      r14,r14
       je        near ptr M14_L01
       mov       [rbx+18],edx
       lea       rdi,[rbx+20]
       mov       rsi,r8
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
       jo        short M14_L02
       cmp       ecx,0FF
       ja        short M14_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M14_L00:
       mov       ecx,847
       mov       rdx,7FFB41D2ADB0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D1EB98]
       int       3
M14_L01:
       mov       ecx,851
       mov       rdx,7FFB41D2ADB0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D1EB98]
       int       3
M14_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 215
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,178
       xor       eax,eax
       mov       [rsp+0E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+0F0],ymm4
       vmovdqu   ymmword ptr [rsp+110],ymm4
       vmovdqu   ymmword ptr [rsp+130],ymm4
       vmovdqu   ymmword ptr [rsp+150],ymm4
       mov       [rsp+170],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L34
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L35
       mov       rcx,rsi
       mov       r11,7FFB41450C18
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB41DAA6A8],1
       je        near ptr M00_L36
M00_L00:
       mov       rdx,191AB002AD8
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB41450C20
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L37
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       rcx,191AB002A20
       mov       rbp,[rcx]
       mov       r14,[rbp+10]
       mov       r15,[rbp+8]
       mov       r13,[rbp+18]
       xor       r12d,r12d
       xor       eax,eax
       inc       edi
       jmp       near ptr M00_L17
M00_L04:
       xor       ecx,ecx
       xor       r10d,r10d
M00_L05:
       mov       [rsp+164],r10d
       cmp       [r14],r14b
       mov       rcx,r14
       cmp       qword ptr [r14+8],0
       jne       near ptr M00_L33
M00_L06:
       xor       r9d,r9d
       xor       r11d,r11d
M00_L07:
       mov       [rsp+78],r11
       test      r11,r11
       jne       near ptr M00_L39
       xor       edx,edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+130],xmm0
       mov       [rsp+130],r8
       mov       rcx,191AB002A48
       mov       rcx,[rcx]
       mov       [rsp+138],rcx
       mov       rcx,[rsp+130]
       mov       r11,[rsp+138]
M00_L08:
       test      edx,edx
       jne       near ptr M00_L16
       test      r11,r11
       je        near ptr M00_L43
       test      r13,r13
       je        near ptr M00_L53
       xor       r8d,r8d
       mov       [rsp+128],r8d
       cmp       qword ptr [r14+8],0
       je        near ptr M00_L29
       mov       r9,r14
       mov       r10d,[rsp+164]
       cmp       r10d,[r9+18]
       jle       near ptr M00_L19
       mov       [rsp+0D0],r9
       mov       r8,[r9+10]
       mov       [rsp+0F8],rcx
       mov       [rsp+100],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+128]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+120]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+0F8]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CE5B60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+120],0
       je        short M00_L12
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L44
       test      rax,rax
       je        short M00_L09
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L09:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L18
M00_L10:
       add       ecx,1
       jo        near ptr M00_L55
       cmp       ecx,0FF
       ja        near ptr M00_L55
       mov       [r14+1D],cl
       mov       r9,r14
M00_L11:
       mov       r14,r9
       mov       [rsp+0D0],r14
M00_L12:
       cmp       byte ptr [rsp+120],0
       je        near ptr M00_L50
       mov       r14,[rsp+0D0]
       test      r14,r14
       je        near ptr M00_L54
       mov       rax,[r14+10]
       movzx     edx,byte ptr [rax+1D]
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       edx,ecx
       cmp       edx,2
       jl        near ptr M00_L24
       mov       rdx,rax
       test      rdx,rdx
       je        near ptr M00_L54
       mov       rcx,[rdx+10]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       ecx,edx
       js        near ptr M00_L27
       cmp       qword ptr [rax+8],0
       je        near ptr M00_L51
       mov       [rsp+98],rax
       mov       rdx,[rax+8]
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L52
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L28
M00_L13:
       add       ecx,1
       jo        near ptr M00_L55
       cmp       ecx,0FF
       ja        near ptr M00_L55
       mov       [r14+1D],cl
       mov       rdx,r14
M00_L14:
       mov       rcx,[rsp+98]
       xor       r8d,r8d
       call      qword ptr [7FFB41CE5B90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
M00_L15:
       inc       r12d
M00_L16:
       mov       rax,[rsp+0E0]
       add       rax,8
M00_L17:
       dec       edi
       je        near ptr M00_L30
       mov       [rsp+0E0],rax
       mov       r8,[rsi+rax]
       mov       [rsp+0D8],r8
       test      r8,r8
       je        near ptr M00_L04
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FFB41450C28
       call      qword ptr [r11]
       mov       r10d,eax
       mov       r8,[rsp+0D8]
       jmp       near ptr M00_L05
M00_L18:
       mov       ecx,eax
       jmp       near ptr M00_L10
M00_L19:
       cmp       r10d,[r9+18]
       jge       near ptr M00_L48
       mov       [rsp+0D0],r9
       mov       r8,[r9+8]
       mov       [rsp+0F8],rcx
       mov       [rsp+100],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+128]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+120]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+0F8]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CE5B60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+120],0
       je        near ptr M00_L12
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L46
       test      rax,rax
       je        short M00_L20
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L20:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        short M00_L23
M00_L21:
       add       ecx,1
       jo        near ptr M00_L55
       cmp       ecx,0FF
       ja        near ptr M00_L55
       mov       [r14+1D],cl
       mov       r9,r14
M00_L22:
       mov       r14,r9
       mov       [rsp+0D0],r14
       jmp       near ptr M00_L12
M00_L23:
       mov       ecx,eax
       jmp       short M00_L21
M00_L24:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41CE5BF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jne       short M00_L25
       jmp       near ptr M00_L15
M00_L25:
       mov       rdx,[r14+8]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41CE5BD8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jle       short M00_L26
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41CE5C38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       near ptr M00_L15
M00_L26:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41CE5C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       near ptr M00_L15
M00_L27:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41CE5C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       near ptr M00_L15
M00_L28:
       mov       ecx,eax
       jmp       near ptr M00_L13
M00_L29:
       mov       [rsp+68],r11
       mov       [rsp+70],rcx
       mov       dword ptr [rsp+120],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0C0],rax
       mov       r8d,[rsp+164]
       mov       [rax+18],r8d
       lea       rcx,[rax+20]
       mov       rdx,[rsp+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0C0]
       lea       rcx,[rax+28]
       mov       rdx,[rsp+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0C0]
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0C0]
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsp+0C0]
       mov       byte ptr [r8+1C],0
       movzx     ecx,byte ptr [r14+1D]
       add       ecx,1
       jo        near ptr M00_L55
       cmp       ecx,0FF
       ja        near ptr M00_L55
       mov       [r8+1D],cl
       mov       r14,r8
       jmp       near ptr M00_L15
M00_L30:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+150],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+150]
       mov       r9d,r12d
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFB41CEEEE0]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rsp+150]
       vmovdqu   xmmword ptr [rsp+168],xmm0
       lea       rcx,[rsp+168]
       mov       r8,rbp
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFB41CEEEF8]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableHashSet`1<System.__Canon>)
       mov       [rsp+108],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+108]
       mov       rdx,7FFB41D1D038
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CE5CC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,178
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L31:
       mov       rcx,[rcx+10]
M00_L32:
       cmp       qword ptr [rcx+8],0
       je        near ptr M00_L06
       mov       r10d,[rsp+164]
M00_L33:
       mov       edx,[rcx+18]
       cmp       r10d,edx
       je        near ptr M00_L38
       jg        short M00_L31
       mov       rcx,[rcx+8]
       jmp       short M00_L32
M00_L34:
       call      qword ptr [7FFB41AAEFD0]
       mov       ecx,65
       mov       rdx,7FFB4190C248
       call      qword ptr [7FFB4150F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417D5AC0
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4190C248
       call      qword ptr [7FFB4150F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4150D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CEC588]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CEC5A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L35:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L36:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L37:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L38:
       mov       r9,[rcx+20]
       mov       r11,[rcx+28]
       jmp       near ptr M00_L07
M00_L39:
       mov       rcx,r15
       mov       [rsp+80],r9
       mov       r8,r9
       mov       rdx,[rsp+0D8]
       mov       r11,7FFB41450C30
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L40
       mov       [rsp+20],r15
       mov       r11,[rsp+78]
       mov       r9d,[r11+20]
       mov       [rsp+78],r11
       mov       rcx,r11
       mov       rdx,[rsp+0D8]
       xor       r8d,r8d
       call      qword ptr [7FFB41CEEC70]
       test      eax,eax
       jl        short M00_L41
M00_L40:
       mov       ecx,1
       mov       rax,[rsp+80]
       mov       r10,[rsp+78]
       mov       edx,ecx
       mov       rcx,rax
       mov       r11,r10
       jmp       near ptr M00_L08
M00_L41:
       xor       edx,edx
       mov       [rsp+160],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+140],xmm0
       mov       rcx,[rsp+78]
       mov       rdx,[rsp+0D8]
       call      qword ptr [7FFB41CEEC88]
       mov       rcx,[rsp+80]
       mov       [rsp+140],rcx
       test      rax,rax
       jne       short M00_L42
       mov       rax,191AB002A48
       mov       rax,[rax]
M00_L42:
       mov       [rsp+148],rax
       mov       rcx,[rsp+140]
       mov       rax,rcx
       mov       r11,[rsp+148]
       mov       r10,r11
       mov       rcx,rax
       mov       r11,r10
       mov       edx,[rsp+160]
       jmp       near ptr M00_L08
M00_L43:
       mov       r10d,[rsp+164]
       lea       r8,[rsp+128]
       mov       rcx,r14
       mov       edx,r10d
       call      qword ptr [7FFB41CEEEC8]
       mov       r14,rax
       jmp       near ptr M00_L15
M00_L44:
       mov       edx,[r14+18]
       mov       [rsp+11C],edx
       mov       r8,[r14+20]
       mov       [rsp+60],r8
       mov       r10,[r14+28]
       mov       [rsp+58],r10
       mov       r9,[r14+8]
       mov       [rsp+0B8],r9
       test      rax,rax
       mov       [rsp+0B0],rax
       jne       short M00_L45
       mov       rax,[r14+10]
       mov       [rsp+0B0],rax
M00_L45:
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rsp+60]
       mov       [rsp+0F8],r8
       mov       r8,[rsp+58]
       mov       [rsp+100],r8
       mov       r8,[rsp+0B0]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0F8]
       mov       edx,[rsp+11C]
       mov       rcx,r14
       mov       r9,[rsp+0B8]
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r9,r14
       jmp       near ptr M00_L11
M00_L46:
       mov       edx,[r14+18]
       mov       [rsp+118],edx
       mov       r8,[r14+20]
       mov       [rsp+50],r8
       mov       r10,[r14+28]
       mov       [rsp+48],r10
       test      rax,rax
       mov       [rsp+0A8],rax
       jne       short M00_L47
       mov       rax,[r14+8]
       mov       [rsp+0A8],rax
M00_L47:
       mov       r14,[r14+10]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rsp+0A0],r9
       mov       r8,[rsp+50]
       mov       [rsp+0F8],r8
       mov       r8,[rsp+48]
       mov       [rsp+100],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0F8]
       mov       edx,[rsp+118]
       mov       rcx,r9
       mov       r9,[rsp+0A8]
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0A0]
       mov       r9,r14
       jmp       near ptr M00_L22
M00_L48:
       vmovdqu   xmm0,xmmword ptr [r14+20]
       vmovdqu   xmmword ptr [rsp+0F8],xmm0
       mov       [rsp+70],rcx
       mov       [rsp+0E8],rcx
       mov       [rsp+68],r11
       mov       [rsp+0F0],r11
       lea       r8,[rsp+0E8]
       lea       rdx,[rsp+0F8]
       mov       rcx,r13
       mov       r11,7FFB41450C38
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L49
       xor       ecx,ecx
       mov       [rsp+120],ecx
       jmp       near ptr M00_L15
M00_L49:
       mov       dword ptr [rsp+120],1
       mov       dword ptr [rsp+128],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0C8],rax
       mov       r10,[rsp+70]
       mov       [rsp+0F8],r10
       mov       r11,[rsp+68]
       mov       [rsp+100],r11
       mov       r8,[r14+10]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0F8]
       mov       r9,[r14+8]
       mov       edx,[rsp+164]
       mov       rcx,rax
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0C8]
       mov       [rsp+0D0],r14
       jmp       near ptr M00_L12
M00_L50:
       mov       r14,[rsp+0D0]
       jmp       near ptr M00_L15
M00_L51:
       jmp       near ptr M00_L15
M00_L52:
       mov       r8d,[r14+18]
       mov       [rsp+114],r8d
       mov       r10,[r14+20]
       mov       [rsp+40],r10
       mov       r9,[r14+28]
       mov       [rsp+38],r9
       mov       r14,[r14+8]
       mov       [rsp+90],rdx
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+88],rax
       mov       r8,[rsp+40]
       mov       [rsp+0F8],r8
       mov       r8,[rsp+38]
       mov       [rsp+100],r8
       mov       r8,[rsp+90]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0F8]
       mov       edx,[rsp+114]
       mov       rcx,[rsp+88]
       mov       r9,r14
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+88]
       mov       rdx,r14
       jmp       near ptr M00_L14
M00_L53:
       mov       ecx,511
       mov       rdx,7FFB41CFADC0
       call      qword ptr [7FFB4150F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CEEC10]
       int       3
M00_L54:
       mov       ecx,869
       mov       rdx,7FFB41CFADC0
       call      qword ptr [7FFB4150F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CEEC10]
       int       3
M00_L55:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2964
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M02_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       rbp,r9
       mov       r15,[rsp+0D8]
       mov       r14,[rsp+0E0]
       mov       byte ptr [r15],0
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L11
       mov       r13,rbx
       cmp       edi,[r13+18]
       jle       near ptr M02_L03
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CE5B60]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        short M02_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M02_L12
       test      rdi,rdi
       je        short M02_L01
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L01:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M02_L23
       cmp       ecx,0FF
       ja        near ptr M02_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M02_L02:
       cmp       byte ptr [r14],0
       je        near ptr M02_L21
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M02_L22
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jl        near ptr M02_L06
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M02_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       js        near ptr M02_L09
       mov       rdx,r13
       call      qword ptr [7FFB41CE5C08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M02_L10
M02_L03:
       cmp       edi,[r13+18]
       jge       near ptr M02_L16
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CE5B60]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        near ptr M02_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M02_L14
       test      rsi,rsi
       je        short M02_L04
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M02_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M02_L23
       cmp       ecx,0FF
       ja        near ptr M02_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M02_L05:
       jmp       near ptr M02_L02
M02_L06:
       cmp       edx,0FFFFFFFE
       jle       short M02_L07
       mov       rax,r13
       jmp       short M02_L10
M02_L07:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M02_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M02_L08
       mov       rdx,r13
       call      qword ptr [7FFB41CE5C38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M02_L10
M02_L08:
       mov       rdx,r13
       call      qword ptr [7FFB41CE5C20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M02_L10
M02_L09:
       mov       rdx,r13
       call      qword ptr [7FFB41CE5C50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M02_L10:
       nop
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
M02_L11:
       mov       byte ptr [r14],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rbp+18],edi
       lea       rdi,[rbp+20]
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
       jo        near ptr M02_L23
       cmp       eax,0FF
       ja        near ptr M02_L23
       mov       [rbp+1D],al
       mov       rax,rbp
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
M02_L12:
       mov       r13d,[rbx+18]
       mov       r15,[rbx+20]
       mov       rsi,[rbx+28]
       mov       rbp,[rbx+8]
       test      rdi,rdi
       jne       short M02_L13
       mov       rdi,[rbx+10]
M02_L13:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       [rsp+50],r15
       mov       [rsp+58],rsi
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+50]
       mov       edx,r13d
       mov       rcx,r12
       mov       r9,rbp
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M02_L02
M02_L14:
       mov       r13d,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r15,[rbx+28]
       test      rsi,rsi
       jne       short M02_L15
       mov       rsi,[rbx+8]
M02_L15:
       mov       rdi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       [rsp+50],rbp
       mov       [rsp+58],r15
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+50]
       mov       edx,r13d
       mov       rcx,r12
       mov       r9,rsi
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M02_L05
M02_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFB41D7D8F0
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L18:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rdx,[rsp+50]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L19
       mov       byte ptr [r14],0
       mov       rax,rbx
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
M02_L19:
       cmp       byte ptr [rsp+0D0],0
       je        short M02_L20
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
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M02_L02
M02_L20:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFB41CEEC28]
       mov       rsi,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFB41CEEC40]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB41875E60]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L21:
       mov       rax,r13
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
M02_L22:
       mov       ecx,869
       mov       rdx,7FFB41CFADC0
       call      qword ptr [7FFB4150F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CEEC10]
       int       3
M02_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1145
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbx,rcx
       mov       rsi,r8
       cmp       byte ptr [rbx+1C],0
       jne       short M03_L02
       test      rdx,rdx
       je        short M03_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M03_L00:
       test      rsi,rsi
       je        short M03_L01
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rax,[rbx+8]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rbx+10]
       movzx     ecx,byte ptr [rcx+1D]
       cmp       eax,ecx
       cmovl     eax,ecx
       add       eax,1
       jo        near ptr M03_L05
       cmp       eax,0FF
       ja        near ptr M03_L05
       mov       [rbx+1D],al
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L02:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       mov       r15,rdx
       test      r15,r15
       jne       short M03_L03
       mov       r15,[rbx+8]
M03_L03:
       test      rsi,rsi
       jne       short M03_L04
       mov       rsi,[rbx+10]
M03_L04:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       [rsp+38],rbp
       mov       [rsp+40],r14
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,edi
       mov       rcx,r13
       mov       r9,r15
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,r13
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 245
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M04_L00
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rdx+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       eax,ecx
       cmp       eax,0FFFFFFFE
       setle     al
       movzx     eax,al
       add       rsp,28
       ret
M04_L00:
       mov       ecx,869
       mov       rdx,7FFB41CFADC0
       call      qword ptr [7FFB4150F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CEEC10]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M05_L00
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rdx+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       eax,ecx
       add       rsp,28
       ret
M05_L00:
       mov       ecx,869
       mov       rdx,7FFB41CFADC0
       call      qword ptr [7FFB4150F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CEEC10]
       int       3
; Total bytes of code 63
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
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
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M06_L14
       mov       rsi,[rbx+8]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M06_L08
       test      rsi,rsi
       je        near ptr M06_L14
       mov       rbp,[rsi+10]
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M06_L09
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M06_L10
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rdi+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rsi+1D],cl
M06_L00:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M06_L11
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbp+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M06_L01:
       mov       rsi,rdx
M06_L02:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L12
       test      rsi,rsi
       je        short M06_L03
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M06_L03:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rbx+1D],cl
M06_L04:
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M06_L15
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L16
       test      rbp,rbp
       je        short M06_L05
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M06_L05:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rbx+1D],cl
M06_L06:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M06_L17
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rdi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L18
       cmp       ecx,0FF
       ja        near ptr M06_L18
       mov       [rdi+1D],cl
       mov       rax,rdi
M06_L07:
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
M06_L08:
       mov       rax,rbx
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
M06_L09:
       jmp       near ptr M06_L02
M06_L10:
       mov       r15d,[rsi+18]
       mov       r13,[rsi+20]
       mov       r12,[rsi+28]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],r13
       mov       [rsp+38],r12
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       rcx,rsi
       mov       r9,rdi
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L00
M06_L11:
       mov       edi,[rbp+18]
       mov       r14,[rbp+20]
       mov       r15,[rbp+28]
       mov       r13,[rbp+10]
       mov       rcx,[rbp]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],r13
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbp
       mov       r9,rsi
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M06_L01
M06_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       test      rsi,rsi
       jne       short M06_L13
       mov       rsi,[rbx+8]
M06_L13:
       mov       r15,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbx
       mov       r9,rsi
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L04
M06_L14:
       mov       ecx,869
       mov       rdx,7FFB41CFADC0
       call      qword ptr [7FFB4150F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CEEC10]
       int       3
M06_L15:
       mov       rax,rbx
       jmp       near ptr M06_L07
M06_L16:
       mov       r14d,[rbx+18]
       mov       r15,[rbx+20]
       mov       r13,[rbx+28]
       test      rbp,rbp
       cmove     rbp,rsi
       mov       rsi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],r15
       mov       [rsp+38],r13
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r14d
       mov       rcx,rbx
       mov       r9,rbp
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L06
M06_L17:
       mov       esi,[rdi+18]
       mov       rbp,[rdi+20]
       mov       r14,[rdi+28]
       mov       r15,[rdi+8]
       mov       rcx,[rdi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],rbx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,esi
       mov       rcx,rdi
       mov       r9,r15
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M06_L07
M06_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 941
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M07_L03
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M07_L04
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M07_L05
       test      rbp,rbp
       je        short M07_L00
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M07_L00:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L07
       cmp       ecx,0FF
       ja        near ptr M07_L07
       mov       [rbx+1D],cl
M07_L01:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M07_L06
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rdi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L07
       cmp       ecx,0FF
       ja        near ptr M07_L07
       mov       [rdi+1D],cl
       mov       rax,rdi
M07_L02:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L03:
       mov       ecx,869
       mov       rdx,7FFB41CFADC0
       call      qword ptr [7FFB4150F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CEEC10]
       int       3
M07_L04:
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L05:
       mov       r14d,[rbx+18]
       mov       r15,[rbx+20]
       mov       r13,[rbx+28]
       test      rbp,rbp
       cmove     rbp,rsi
       mov       rsi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+38],r15
       mov       [rsp+40],r13
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,r14d
       mov       rcx,rbx
       mov       r9,rbp
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M07_L01
M07_L06:
       mov       esi,[rdi+18]
       mov       rbp,[rdi+20]
       mov       r14,[rdi+28]
       mov       r15,[rdi+8]
       mov       rcx,[rdi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+38],rbp
       mov       [rsp+40],r14
       mov       [rsp+20],rbx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,esi
       mov       rcx,rdi
       mov       r9,r15
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M07_L02
M07_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 438
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
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
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M08_L14
       mov       rsi,[rbx+10]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M08_L08
       test      rsi,rsi
       je        near ptr M08_L14
       cmp       qword ptr [rdi+8],0
       je        near ptr M08_L09
       mov       rbp,rdi
       mov       rdx,[rbp+10]
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M08_L10
       test      r14,r14
       je        short M08_L00
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M08_L00:
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M08_L18
       cmp       ecx,0FF
       ja        near ptr M08_L18
       mov       [rsi+1D],cl
M08_L01:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M08_L11
       lea       rcx,[rbp+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbp+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M08_L18
       cmp       ecx,0FF
       ja        near ptr M08_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M08_L02:
       mov       rsi,rdx
M08_L03:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M08_L12
       test      rsi,rsi
       je        short M08_L04
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M08_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M08_L18
       cmp       ecx,0FF
       ja        near ptr M08_L18
       mov       [rbx+1D],cl
M08_L05:
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M08_L15
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M08_L16
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M08_L18
       cmp       ecx,0FF
       ja        near ptr M08_L18
       mov       [rbx+1D],cl
M08_L06:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M08_L17
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M08_L18
       cmp       ecx,0FF
       ja        near ptr M08_L18
       mov       [rsi+1D],cl
       mov       rax,rsi
M08_L07:
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
M08_L08:
       mov       rax,rbx
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
M08_L09:
       jmp       near ptr M08_L03
M08_L10:
       mov       r15d,[rsi+18]
       mov       r13,[rsi+20]
       mov       r12,[rsi+28]
       test      r14,r14
       cmove     r14,rdi
       mov       rdi,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],r13
       mov       [rsp+38],r12
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M08_L01
M08_L11:
       mov       edi,[rbp+18]
       mov       r14,[rbp+20]
       mov       r15,[rbp+28]
       mov       r13,[rbp+8]
       mov       rcx,[rbp]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbp
       mov       r9,r13
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M08_L02
M08_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       mov       r15,[rbx+8]
       test      rsi,rsi
       jne       short M08_L13
       mov       rsi,[rbx+10]
M08_L13:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbx
       mov       r9,r15
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M08_L05
M08_L14:
       mov       ecx,869
       mov       rdx,7FFB41CFADC0
       call      qword ptr [7FFB4150F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CEEC10]
       int       3
M08_L15:
       mov       rax,rbx
       jmp       near ptr M08_L07
M08_L16:
       mov       ebp,[rbx+18]
       mov       r14,[rbx+20]
       mov       r15,[rbx+28]
       mov       r13,[rbx+8]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,ebp
       mov       rcx,rbx
       mov       r9,r13
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M08_L06
M08_L17:
       mov       edi,[rsi+18]
       mov       rbp,[rsi+20]
       mov       r14,[rsi+28]
       mov       r15,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rsi
       mov       r9,rbx
       call      qword ptr [7FFB41CE5B78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M08_L07
M08_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 943
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r9d
       test      r8,r8
       je        short M09_L00
       mov       rcx,rbx
       mov       rdx,r8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rbx+8],esi
       mov       esi,[rsp+60]
       mov       [rbx+0C],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L00:
       mov       ecx,4AB
       mov       rdx,7FFB41CFADC0
       call      qword ptr [7FFB4150F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CEEC10]
       int       3
; Total bytes of code 76
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableHashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rdx
       mov       rbx,r8
       test      rbx,rbx
       je        near ptr M10_L06
       mov       esi,[rcx+8]
       cmp       dword ptr [rcx+0C],0
       jne       short M10_L00
       add       esi,[rbx+20]
M10_L00:
       mov       rdi,[rcx]
       cmp       rdi,[rbx+10]
       je        near ptr M10_L07
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rbx,[rbx+8]
       test      rdi,rdi
       je        near ptr M10_L08
       test      rbx,rbx
       je        near ptr M10_L09
       mov       r14,[rbp]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax+8]
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M10_L02
       test      r15,r15
       je        short M10_L01
       mov       r13d,[rdi+18]
       mov       r12,[rdi+20]
       mov       rax,[rdi+28]
       mov       [rsp+20],rax
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__89_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [r15+18],rcx
       jne       near ptr M10_L10
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       test      rax,rax
       je        short M10_L01
       cmp       byte ptr [rax+24],0
       jne       short M10_L01
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CE5CB0]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       r12,[rsp+20]
       mov       rcx,[r12+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CE5CB0]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r12+24],1
M10_L01:
       mov       rcx,[rdi+8]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CE5A28]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       rcx,[rdi+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CE5A28]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       byte ptr [rdi+1C],1
M10_L02:
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+20],esi
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M10_L05
M10_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,rbp
M10_L04:
       mov       rax,rbx
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
M10_L05:
       mov       rdx,7FFB41DB2988
       call      qword ptr [7FFB4150F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M10_L03
M10_L06:
       mov       ecx,577
       mov       rdx,7FFB41CFADC0
       call      qword ptr [7FFB4150F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CEEC10]
       int       3
M10_L07:
       jmp       short M10_L04
M10_L08:
       mov       ecx,4AB
       mov       rdx,7FFB41CFADC0
       call      qword ptr [7FFB4150F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CEEC10]
       int       3
M10_L09:
       mov       ecx,4B5
       mov       rdx,7FFB41CFADC0
       call      qword ptr [7FFB4150F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CEEC10]
       int       3
M10_L10:
       mov       [rsp+28],r13d
       mov       [rsp+30],r12
       mov       [rsp+38],rax
       lea       rdx,[rsp+28]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       jmp       near ptr M10_L01
; Total bytes of code 504
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
       je        near ptr M12_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M12_L01
       test      rsi,rsi
       je        short M12_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M12_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M12_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41505818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41505818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M12_L00:
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
M12_L01:
       test      rsi,rsi
       je        short M12_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M12_L03
M12_L02:
       mov       rax,1D23FF20008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M12_L03:
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
M12_L04:
       call      qword ptr [7FFB41CEE640]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M13_L00
       ret
M13_L00:
       jmp       qword ptr [7FFB41505C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
       je        short M14_L00
       test      r14,r14
       je        near ptr M14_L01
       mov       [rbx+18],edx
       lea       rdi,[rbx+20]
       mov       rsi,r8
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
       jo        short M14_L02
       cmp       ecx,0FF
       ja        short M14_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M14_L00:
       mov       ecx,847
       mov       rdx,7FFB41CFADC0
       call      qword ptr [7FFB4150F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CEEC10]
       int       3
M14_L01:
       mov       ecx,851
       mov       rdx,7FFB41CFADC0
       call      qword ptr [7FFB4150F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CEEC10]
       int       3
M14_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 215
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,198
       xor       eax,eax
       mov       [rsp+108],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+110],ymm4
       vmovdqu   ymmword ptr [rsp+130],ymm4
       vmovdqu   ymmword ptr [rsp+150],ymm4
       vmovdqu   ymmword ptr [rsp+170],ymm4
       mov       [rsp+190],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L38
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFB41526850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L39
       mov       rcx,rsi
       mov       r11,7FFB41470B18
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB41D4EF98],1
       je        near ptr M00_L40
M00_L00:
       mov       rdx,16BD3000A68
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB41470B20
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L41
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       rcx,16BD3000A10
       mov       rbp,[rcx]
       mov       r14,[rbp+10]
       mov       r15,[rbp+8]
       mov       r13,[rbp+18]
       xor       r12d,r12d
       xor       eax,eax
       inc       edi
       jmp       near ptr M00_L23
M00_L04:
       mov       rcx,[rcx+10]
M00_L05:
       cmp       qword ptr [rcx+8],0
       je        short M00_L09
       mov       r10d,[rsp+184]
M00_L06:
       mov       edx,[rcx+18]
       cmp       r10d,edx
       je        near ptr M00_L42
       jg        short M00_L04
       mov       rcx,[rcx+8]
       jmp       short M00_L05
M00_L07:
       xor       ecx,ecx
       xor       r10d,r10d
M00_L08:
       mov       [rsp+184],r10d
       cmp       [r14],r14b
       mov       rcx,r14
       cmp       qword ptr [r14+8],0
       jne       short M00_L06
M00_L09:
       xor       r9d,r9d
       xor       r11d,r11d
M00_L10:
       mov       [rsp+88],r11
       test      r11,r11
       jne       near ptr M00_L43
       xor       edx,edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+150],xmm0
       mov       [rsp+150],r8
       mov       rcx,16BD3000A38
       mov       rcx,[rcx]
       mov       [rsp+158],rcx
       mov       rcx,[rsp+150]
       mov       r11,[rsp+158]
M00_L11:
       test      edx,edx
       jne       near ptr M00_L22
       test      r11,r11
       je        near ptr M00_L47
       test      r13,r13
       je        near ptr M00_L58
       xor       r8d,r8d
       mov       [rsp+148],r8d
       cmp       qword ptr [r14+8],0
       je        near ptr M00_L36
       mov       r9,r14
       mov       r10d,[rsp+184]
       cmp       r10d,[r9+18]
       jg        near ptr M00_L25
       cmp       r10d,[r9+18]
       jge       near ptr M00_L52
       mov       [rsp+0F0],r9
       mov       r8,[r9+8]
       mov       [rsp+118],rcx
       mov       [rsp+120],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+148]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+140]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+118]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41BEDE78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+140],0
       je        short M00_L15
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L50
       test      rax,rax
       je        short M00_L12
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L24
M00_L13:
       add       ecx,1
       jo        near ptr M00_L60
       cmp       ecx,0FF
       ja        near ptr M00_L60
       mov       [r14+1D],cl
       mov       r9,r14
M00_L14:
       mov       r14,r9
       mov       [rsp+0F0],r14
M00_L15:
       cmp       byte ptr [rsp+140],0
       je        near ptr M00_L54
       mov       r14,[rsp+0F0]
       test      r14,r14
       je        near ptr M00_L59
       mov       rax,[r14+10]
       movzx     edx,byte ptr [rax+1D]
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       edx,ecx
       cmp       edx,2
       jl        near ptr M00_L30
       mov       rdx,rax
       test      rdx,rdx
       je        near ptr M00_L59
       mov       rcx,[rdx+10]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       ecx,edx
       js        near ptr M00_L33
       cmp       qword ptr [rax+8],0
       je        near ptr M00_L55
       mov       [rsp+0B8],rax
       mov       rdx,[rax+8]
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L56
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L34
M00_L16:
       add       ecx,1
       jo        near ptr M00_L60
       cmp       ecx,0FF
       ja        near ptr M00_L60
       mov       [r14+1D],cl
       mov       rdx,r14
M00_L17:
       mov       r14,[rsp+0B8]
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L57
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L35
M00_L18:
       add       ecx,1
       jo        near ptr M00_L60
       cmp       ecx,0FF
       ja        near ptr M00_L60
       mov       [r14+1D],cl
M00_L19:
       mov       rax,r14
M00_L20:
       mov       r14,rax
M00_L21:
       inc       r12d
M00_L22:
       mov       rax,[rsp+100]
       add       rax,8
M00_L23:
       dec       edi
       je        near ptr M00_L37
       mov       [rsp+100],rax
       mov       r8,[rsi+rax]
       mov       [rsp+0F8],r8
       test      r8,r8
       je        near ptr M00_L07
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FFB41470B28
       call      qword ptr [r11]
       mov       r10d,eax
       mov       r8,[rsp+0F8]
       jmp       near ptr M00_L08
M00_L24:
       mov       ecx,eax
       jmp       near ptr M00_L13
M00_L25:
       mov       [rsp+0F0],r9
       mov       r8,[r9+10]
       mov       [rsp+118],rcx
       mov       [rsp+120],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+148]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+140]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+118]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41BEDE78]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+140],0
       je        near ptr M00_L15
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L48
       test      rax,rax
       je        short M00_L26
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L26:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        short M00_L29
M00_L27:
       add       ecx,1
       jo        near ptr M00_L60
       cmp       ecx,0FF
       ja        near ptr M00_L60
       mov       [r14+1D],cl
       mov       r9,r14
M00_L28:
       mov       r14,r9
       mov       [rsp+0F0],r14
       jmp       near ptr M00_L15
M00_L29:
       mov       ecx,eax
       jmp       short M00_L27
M00_L30:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41BEDF08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jne       short M00_L31
       mov       rax,r14
       jmp       near ptr M00_L20
M00_L31:
       mov       rdx,[r14+8]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41BEDEF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jle       short M00_L32
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41BEDF68]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M00_L20
M00_L32:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41BEDF38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M00_L20
M00_L33:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41BEDF50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M00_L20
M00_L34:
       mov       ecx,eax
       jmp       near ptr M00_L16
M00_L35:
       mov       ecx,eax
       jmp       near ptr M00_L18
M00_L36:
       mov       [rsp+78],r11
       mov       [rsp+80],rcx
       mov       dword ptr [rsp+140],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0E0],rax
       mov       r8,[rsp+80]
       mov       [rsp+118],r8
       mov       r8,[rsp+78]
       mov       [rsp+120],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+118]
       mov       edx,[rsp+184]
       mov       rcx,rax
       mov       r9,r14
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0E0]
       mov       rax,r14
       jmp       near ptr M00_L20
M00_L37:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+170],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+170]
       mov       r9d,r12d
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFB41D17870]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rsp+170]
       vmovdqu   xmmword ptr [rsp+188],xmm0
       lea       rcx,[rsp+188]
       mov       r8,rbp
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFB41D17888]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableHashSet`1<System.__Canon>)
       mov       [rsp+128],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+128]
       mov       rdx,7FFB41CD8F78
       cmp       [rcx],ecx
       call      qword ptr [7FFB41BEDFE0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,198
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L38:
       call      qword ptr [7FFB41AC7240]
       mov       ecx,65
       mov       rdx,7FFB4192C248
       call      qword ptr [7FFB4152F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB417F5AC0
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4192C248
       call      qword ptr [7FFB4152F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4152D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41D17C00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41D17C18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L39:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L41:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L42:
       mov       r9,[rcx+20]
       mov       r11,[rcx+28]
       jmp       near ptr M00_L10
M00_L43:
       mov       rcx,r15
       mov       [rsp+90],r9
       mov       r8,r9
       mov       rdx,[rsp+0F8]
       mov       r11,7FFB41470B30
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L44
       mov       [rsp+20],r15
       mov       r11,[rsp+88]
       mov       r9d,[r11+20]
       mov       [rsp+88],r11
       mov       rcx,r11
       mov       rdx,[rsp+0F8]
       xor       r8d,r8d
       call      qword ptr [7FFB41D16AC0]
       test      eax,eax
       jl        short M00_L45
M00_L44:
       mov       ecx,1
       mov       rax,[rsp+90]
       mov       r10,[rsp+88]
       mov       edx,ecx
       mov       rcx,rax
       mov       r11,r10
       jmp       near ptr M00_L11
M00_L45:
       xor       edx,edx
       mov       [rsp+180],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+160],xmm0
       mov       rcx,[rsp+88]
       mov       rdx,[rsp+0F8]
       call      qword ptr [7FFB41D16AD8]
       mov       rcx,[rsp+90]
       mov       [rsp+160],rcx
       test      rax,rax
       jne       short M00_L46
       mov       rax,16BD3000A38
       mov       rax,[rax]
M00_L46:
       mov       [rsp+168],rax
       mov       rcx,[rsp+160]
       mov       rax,rcx
       mov       r11,[rsp+168]
       mov       r10,r11
       mov       rcx,rax
       mov       r11,r10
       mov       edx,[rsp+180]
       jmp       near ptr M00_L11
M00_L47:
       mov       r10d,[rsp+184]
       lea       r8,[rsp+148]
       mov       rcx,r14
       mov       edx,r10d
       call      qword ptr [7FFB41D17858]
       mov       r14,rax
       jmp       near ptr M00_L21
M00_L48:
       mov       edx,[r14+18]
       mov       [rsp+13C],edx
       mov       r8,[r14+20]
       mov       [rsp+70],r8
       mov       r10,[r14+28]
       mov       [rsp+68],r10
       mov       r9,[r14+8]
       mov       [rsp+0D8],r9
       test      rax,rax
       mov       [rsp+0D0],rax
       jne       short M00_L49
       mov       rax,[r14+10]
       mov       [rsp+0D0],rax
M00_L49:
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rsp+70]
       mov       [rsp+118],r8
       mov       r8,[rsp+68]
       mov       [rsp+120],r8
       mov       r8,[rsp+0D0]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+118]
       mov       edx,[rsp+13C]
       mov       rcx,r14
       mov       r9,[rsp+0D8]
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r9,r14
       jmp       near ptr M00_L28
M00_L50:
       mov       edx,[r14+18]
       mov       [rsp+138],edx
       mov       r8,[r14+20]
       mov       [rsp+60],r8
       mov       r10,[r14+28]
       mov       [rsp+58],r10
       test      rax,rax
       mov       [rsp+0C8],rax
       jne       short M00_L51
       mov       rax,[r14+8]
       mov       [rsp+0C8],rax
M00_L51:
       mov       r14,[r14+10]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rsp+0C0],r9
       mov       r8,[rsp+60]
       mov       [rsp+118],r8
       mov       r8,[rsp+58]
       mov       [rsp+120],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+118]
       mov       edx,[rsp+138]
       mov       rcx,r9
       mov       r9,[rsp+0C8]
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0C0]
       mov       r9,r14
       jmp       near ptr M00_L14
M00_L52:
       vmovdqu   xmm0,xmmword ptr [r14+20]
       vmovdqu   xmmword ptr [rsp+118],xmm0
       mov       [rsp+80],rcx
       mov       [rsp+108],rcx
       mov       [rsp+78],r11
       mov       [rsp+110],r11
       lea       r8,[rsp+108]
       lea       rdx,[rsp+118]
       mov       rcx,r13
       mov       r11,7FFB41470B38
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L53
       xor       ecx,ecx
       mov       [rsp+140],ecx
       mov       rax,r14
       jmp       near ptr M00_L20
M00_L53:
       mov       dword ptr [rsp+140],1
       mov       dword ptr [rsp+148],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0E8],rax
       mov       r10,[rsp+80]
       mov       [rsp+118],r10
       mov       r11,[rsp+78]
       mov       [rsp+120],r11
       mov       r8,[r14+10]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+118]
       mov       r9,[r14+8]
       mov       edx,[rsp+184]
       mov       rcx,rax
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0E8]
       mov       [rsp+0F0],r14
       jmp       near ptr M00_L15
M00_L54:
       mov       r14,[rsp+0F0]
       mov       rax,r14
       jmp       near ptr M00_L20
M00_L55:
       mov       rax,r14
       jmp       near ptr M00_L20
M00_L56:
       mov       r8d,[r14+18]
       mov       [rsp+134],r8d
       mov       r10,[r14+20]
       mov       [rsp+50],r10
       mov       r9,[r14+28]
       mov       [rsp+48],r9
       mov       r14,[r14+8]
       mov       [rsp+0B0],rdx
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A8],rax
       mov       r8,[rsp+50]
       mov       [rsp+118],r8
       mov       r8,[rsp+48]
       mov       [rsp+120],r8
       mov       r8,[rsp+0B0]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+118]
       mov       edx,[rsp+134]
       mov       rcx,[rsp+0A8]
       mov       r9,r14
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0A8]
       mov       rdx,r14
       jmp       near ptr M00_L17
M00_L57:
       mov       eax,[r14+18]
       mov       [rsp+130],eax
       mov       r8,[r14+20]
       mov       [rsp+40],r8
       mov       r10,[r14+28]
       mov       [rsp+38],r10
       mov       [rsp+0A0],rdx
       mov       r14,[r14+10]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+98],rax
       mov       r8,[rsp+40]
       mov       [rsp+118],r8
       mov       r8,[rsp+38]
       mov       [rsp+120],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+118]
       mov       edx,[rsp+130]
       mov       rcx,rax
       mov       r9,[rsp+0A0]
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+98]
       jmp       near ptr M00_L19
M00_L58:
       mov       ecx,511
       mov       rdx,7FFB41CB6C20
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D169D0]
       int       3
M00_L59:
       mov       ecx,869
       mov       rdx,7FFB41CB6C20
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D169D0]
       int       3
M00_L60:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 3148
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M02_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       rbp,r9
       mov       r15,[rsp+0D8]
       mov       r14,[rsp+0E0]
       mov       byte ptr [r15],0
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L11
       mov       r13,rbx
       cmp       edi,[r13+18]
       jg        near ptr M02_L03
       cmp       edi,[r13+18]
       jge       near ptr M02_L16
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB41BEDE78]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        short M02_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M02_L14
       test      rsi,rsi
       je        short M02_L01
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M02_L01:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M02_L23
       cmp       ecx,0FF
       ja        near ptr M02_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M02_L02:
       cmp       byte ptr [r14],0
       je        near ptr M02_L21
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M02_L22
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jl        near ptr M02_L06
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M02_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       js        near ptr M02_L09
       mov       rdx,r13
       call      qword ptr [7FFB41BEDF20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M02_L10
M02_L03:
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB41BEDE78]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        near ptr M02_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M02_L12
       test      rdi,rdi
       je        short M02_L04
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M02_L23
       cmp       ecx,0FF
       ja        near ptr M02_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M02_L05:
       jmp       near ptr M02_L02
M02_L06:
       cmp       edx,0FFFFFFFE
       jle       short M02_L07
       mov       rax,r13
       jmp       short M02_L10
M02_L07:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M02_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M02_L08
       mov       rdx,r13
       call      qword ptr [7FFB41BEDF68]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M02_L10
M02_L08:
       mov       rdx,r13
       call      qword ptr [7FFB41BEDF38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M02_L10
M02_L09:
       mov       rdx,r13
       call      qword ptr [7FFB41BEDF50]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M02_L10:
       nop
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
M02_L11:
       mov       byte ptr [r14],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rbp+18],edi
       lea       rdi,[rbp+20]
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
       jo        near ptr M02_L23
       cmp       eax,0FF
       ja        near ptr M02_L23
       mov       [rbp+1D],al
       mov       rax,rbp
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
M02_L12:
       mov       r13d,[rbx+18]
       mov       rsi,[rbx+20]
       mov       rbp,[rbx+28]
       mov       r15,[rbx+8]
       test      rdi,rdi
       jne       short M02_L13
       mov       rdi,[rbx+10]
M02_L13:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       [rsp+50],rsi
       mov       [rsp+58],rbp
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+50]
       mov       edx,r13d
       mov       rcx,r12
       mov       r9,r15
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M02_L05
M02_L14:
       mov       r13d,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r15,[rbx+28]
       test      rsi,rsi
       jne       short M02_L15
       mov       rsi,[rbx+8]
M02_L15:
       mov       rdi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       [rsp+50],rbp
       mov       [rsp+58],r15
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+50]
       mov       edx,r13d
       mov       rcx,r12
       mov       r9,rsi
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M02_L02
M02_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFB41CE14D8
       call      qword ptr [7FFB4152F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L18:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rdx,[rsp+50]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L19
       mov       byte ptr [r14],0
       mov       rax,rbx
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
M02_L19:
       cmp       byte ptr [rsp+0D0],0
       je        short M02_L20
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
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M02_L02
M02_L20:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFB41D169E8]
       mov       r15,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFB41D16A00]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB41895E60]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M02_L21:
       mov       rax,r13
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
M02_L22:
       mov       ecx,869
       mov       rdx,7FFB41CB6C20
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D169D0]
       int       3
M02_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1145
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M03_L00
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rdx+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       eax,ecx
       cmp       eax,0FFFFFFFE
       setle     al
       movzx     eax,al
       add       rsp,28
       ret
M03_L00:
       mov       ecx,869
       mov       rdx,7FFB41CB6C20
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D169D0]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M04_L00
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rdx+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       eax,ecx
       add       rsp,28
       ret
M04_L00:
       mov       ecx,869
       mov       rdx,7FFB41CB6C20
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D169D0]
       int       3
; Total bytes of code 63
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
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
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L14
       mov       rsi,[rbx+8]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M05_L08
       test      rsi,rsi
       je        near ptr M05_L14
       mov       rbp,[rsi+10]
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M05_L09
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M05_L10
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rdi+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L18
       cmp       ecx,0FF
       ja        near ptr M05_L18
       mov       [rsi+1D],cl
M05_L00:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M05_L11
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbp+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L18
       cmp       ecx,0FF
       ja        near ptr M05_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M05_L01:
       mov       rsi,rdx
M05_L02:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M05_L12
       test      rsi,rsi
       je        short M05_L03
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M05_L03:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L18
       cmp       ecx,0FF
       ja        near ptr M05_L18
       mov       [rbx+1D],cl
M05_L04:
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M05_L15
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M05_L16
       test      rbp,rbp
       je        short M05_L05
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M05_L05:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L18
       cmp       ecx,0FF
       ja        near ptr M05_L18
       mov       [rbx+1D],cl
M05_L06:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M05_L17
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rdi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L18
       cmp       ecx,0FF
       ja        near ptr M05_L18
       mov       [rdi+1D],cl
       mov       rax,rdi
M05_L07:
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
M05_L08:
       mov       rax,rbx
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
M05_L09:
       jmp       near ptr M05_L02
M05_L10:
       mov       r15d,[rsi+18]
       mov       r13,[rsi+20]
       mov       r12,[rsi+28]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],r13
       mov       [rsp+38],r12
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       rcx,rsi
       mov       r9,rdi
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M05_L00
M05_L11:
       mov       edi,[rbp+18]
       mov       r14,[rbp+20]
       mov       r15,[rbp+28]
       mov       r13,[rbp+10]
       mov       rcx,[rbp]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],r13
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbp
       mov       r9,rsi
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M05_L01
M05_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       test      rsi,rsi
       jne       short M05_L13
       mov       rsi,[rbx+8]
M05_L13:
       mov       r15,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbx
       mov       r9,rsi
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M05_L04
M05_L14:
       mov       ecx,869
       mov       rdx,7FFB41CB6C20
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D169D0]
       int       3
M05_L15:
       mov       rax,rbx
       jmp       near ptr M05_L07
M05_L16:
       mov       r14d,[rbx+18]
       mov       r15,[rbx+20]
       mov       r13,[rbx+28]
       test      rbp,rbp
       cmove     rbp,rsi
       mov       rsi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],r15
       mov       [rsp+38],r13
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r14d
       mov       rcx,rbx
       mov       r9,rbp
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M05_L06
M05_L17:
       mov       esi,[rdi+18]
       mov       rbp,[rdi+20]
       mov       r14,[rdi+28]
       mov       r15,[rdi+8]
       mov       rcx,[rdi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],rbx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,esi
       mov       rcx,rdi
       mov       r9,r15
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M05_L07
M05_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 941
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M06_L03
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M06_L04
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L05
       test      rbp,rbp
       je        short M06_L00
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M06_L00:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L07
       cmp       ecx,0FF
       ja        near ptr M06_L07
       mov       [rbx+1D],cl
M06_L01:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M06_L06
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rdi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L07
       cmp       ecx,0FF
       ja        near ptr M06_L07
       mov       [rdi+1D],cl
       mov       rax,rdi
M06_L02:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L03:
       mov       ecx,869
       mov       rdx,7FFB41CB6C20
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D169D0]
       int       3
M06_L04:
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L05:
       mov       r14d,[rbx+18]
       mov       r15,[rbx+20]
       mov       r13,[rbx+28]
       test      rbp,rbp
       cmove     rbp,rsi
       mov       rsi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+38],r15
       mov       [rsp+40],r13
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,r14d
       mov       rcx,rbx
       mov       r9,rbp
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L01
M06_L06:
       mov       esi,[rdi+18]
       mov       rbp,[rdi+20]
       mov       r14,[rdi+28]
       mov       r15,[rdi+8]
       mov       rcx,[rdi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+38],rbp
       mov       [rsp+40],r14
       mov       [rsp+20],rbx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,esi
       mov       rcx,rdi
       mov       r9,r15
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M06_L02
M06_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 438
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
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
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M07_L14
       mov       rsi,[rbx+10]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M07_L08
       test      rsi,rsi
       je        near ptr M07_L14
       cmp       qword ptr [rdi+8],0
       je        near ptr M07_L09
       mov       rbp,rdi
       mov       rdx,[rbp+10]
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M07_L10
       test      r14,r14
       je        short M07_L00
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L00:
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L18
       cmp       ecx,0FF
       ja        near ptr M07_L18
       mov       [rsi+1D],cl
M07_L01:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M07_L11
       lea       rcx,[rbp+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbp+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L18
       cmp       ecx,0FF
       ja        near ptr M07_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M07_L02:
       mov       rsi,rdx
M07_L03:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M07_L12
       test      rsi,rsi
       je        short M07_L04
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M07_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L18
       cmp       ecx,0FF
       ja        near ptr M07_L18
       mov       [rbx+1D],cl
M07_L05:
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M07_L15
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M07_L16
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L18
       cmp       ecx,0FF
       ja        near ptr M07_L18
       mov       [rbx+1D],cl
M07_L06:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M07_L17
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L18
       cmp       ecx,0FF
       ja        near ptr M07_L18
       mov       [rsi+1D],cl
       mov       rax,rsi
M07_L07:
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
M07_L08:
       mov       rax,rbx
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
M07_L09:
       jmp       near ptr M07_L03
M07_L10:
       mov       r15d,[rsi+18]
       mov       r13,[rsi+20]
       mov       r12,[rsi+28]
       test      r14,r14
       cmove     r14,rdi
       mov       rdi,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],r13
       mov       [rsp+38],r12
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M07_L01
M07_L11:
       mov       edi,[rbp+18]
       mov       r14,[rbp+20]
       mov       r15,[rbp+28]
       mov       r13,[rbp+8]
       mov       rcx,[rbp]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbp
       mov       r9,r13
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M07_L02
M07_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       mov       r15,[rbx+8]
       test      rsi,rsi
       jne       short M07_L13
       mov       rsi,[rbx+10]
M07_L13:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbx
       mov       r9,r15
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M07_L05
M07_L14:
       mov       ecx,869
       mov       rdx,7FFB41CB6C20
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D169D0]
       int       3
M07_L15:
       mov       rax,rbx
       jmp       near ptr M07_L07
M07_L16:
       mov       ebp,[rbx+18]
       mov       r14,[rbx+20]
       mov       r15,[rbx+28]
       mov       r13,[rbx+8]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,ebp
       mov       rcx,rbx
       mov       r9,r13
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M07_L06
M07_L17:
       mov       edi,[rsi+18]
       mov       rbp,[rsi+20]
       mov       r14,[rsi+28]
       mov       r15,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rsi
       mov       r9,rbx
       call      qword ptr [7FFB41BEDE90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M07_L07
M07_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 943
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
       je        short M08_L00
       test      r14,r14
       je        near ptr M08_L01
       mov       [rbx+18],edx
       lea       rdi,[rbx+20]
       mov       rsi,r8
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
       jo        short M08_L02
       cmp       ecx,0FF
       ja        short M08_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L00:
       mov       ecx,847
       mov       rdx,7FFB41CB6C20
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D169D0]
       int       3
M08_L01:
       mov       ecx,851
       mov       rdx,7FFB41CB6C20
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D169D0]
       int       3
M08_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 215
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r9d
       test      r8,r8
       je        short M09_L00
       mov       rcx,rbx
       mov       rdx,r8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rbx+8],esi
       mov       esi,[rsp+60]
       mov       [rbx+0C],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L00:
       mov       ecx,4AB
       mov       rdx,7FFB41CB6C20
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D169D0]
       int       3
; Total bytes of code 76
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableHashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rdx
       mov       rbx,r8
       test      rbx,rbx
       je        near ptr M10_L06
       mov       esi,[rcx+8]
       cmp       dword ptr [rcx+0C],0
       jne       short M10_L00
       add       esi,[rbx+20]
M10_L00:
       mov       rdi,[rcx]
       cmp       rdi,[rbx+10]
       je        near ptr M10_L07
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rbx,[rbx+8]
       test      rdi,rdi
       je        near ptr M10_L08
       test      rbx,rbx
       je        near ptr M10_L09
       mov       r14,[rbp]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax+8]
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M10_L02
       test      r15,r15
       je        short M10_L01
       mov       r13d,[rdi+18]
       mov       r12,[rdi+20]
       mov       rax,[rdi+28]
       mov       [rsp+20],rax
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__89_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [r15+18],rcx
       jne       near ptr M10_L10
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       test      rax,rax
       je        short M10_L01
       cmp       byte ptr [rax+24],0
       jne       short M10_L01
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB41BEDFC8]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       r12,[rsp+20]
       mov       rcx,[r12+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB41BEDFC8]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r12+24],1
M10_L01:
       mov       rcx,[rdi+8]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB41BEDD40]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       rcx,[rdi+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB41BEDD40]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       byte ptr [rdi+1C],1
M10_L02:
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+20],esi
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M10_L05
M10_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,rbp
M10_L04:
       mov       rax,rbx
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
M10_L05:
       mov       rdx,7FFB41CEA970
       call      qword ptr [7FFB4152F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M10_L03
M10_L06:
       mov       ecx,577
       mov       rdx,7FFB41CB6C20
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D169D0]
       int       3
M10_L07:
       jmp       short M10_L04
M10_L08:
       mov       ecx,4AB
       mov       rdx,7FFB41CB6C20
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D169D0]
       int       3
M10_L09:
       mov       ecx,4B5
       mov       rdx,7FFB41CB6C20
       call      qword ptr [7FFB4152F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D169D0]
       int       3
M10_L10:
       mov       [rsp+28],r13d
       mov       [rsp+30],r12
       mov       [rsp+38],rax
       lea       rdx,[rsp+28]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       jmp       near ptr M10_L01
; Total bytes of code 504
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
       je        near ptr M12_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M12_L01
       test      rsi,rsi
       je        short M12_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M12_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M12_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41525818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M12_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M12_L01:
       test      rsi,rsi
       je        short M12_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M12_L03
M12_L02:
       mov       rax,1AC51E80008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M12_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M12_L04:
       call      qword ptr [7FFB41D17F78]
       int       3
; Total bytes of code 231
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M13_L00
       ret
M13_L00:
       jmp       qword ptr [7FFB41525C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,198
       xor       eax,eax
       mov       [rsp+108],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+110],ymm4
       vmovdqu   ymmword ptr [rsp+130],ymm4
       vmovdqu   ymmword ptr [rsp+150],ymm4
       vmovdqu   ymmword ptr [rsp+170],ymm4
       mov       [rsp+190],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L38
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L39
       mov       rcx,rsi
       mov       r11,7FFB41480D98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB41DF3530],1
       je        near ptr M00_L40
M00_L00:
       mov       rdx,2EEB4800B10
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB41480DA0
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L41
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       rcx,2EEB4800A28
       mov       rbp,[rcx]
       mov       r14,[rbp+10]
       mov       r15,[rbp+8]
       mov       r13,[rbp+18]
       xor       r12d,r12d
       xor       eax,eax
       inc       edi
M00_L04:
       dec       edi
       je        near ptr M00_L34
       mov       [rsp+100],rax
       mov       r8,[rsi+rax]
       mov       [rsp+0F8],r8
       test      r8,r8
       je        short M00_L05
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FFB41480DA8
       call      qword ptr [r11]
       mov       r10d,eax
       mov       r8,[rsp+0F8]
       jmp       short M00_L06
M00_L05:
       xor       ecx,ecx
       xor       r10d,r10d
M00_L06:
       mov       [rsp+184],r10d
       cmp       [r14],r14b
       mov       rcx,r14
       cmp       qword ptr [r14+8],0
       jne       near ptr M00_L37
M00_L07:
       xor       r9d,r9d
       xor       r11d,r11d
M00_L08:
       mov       [rsp+88],r11
       test      r11,r11
       jne       near ptr M00_L43
       xor       edx,edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+150],xmm0
       mov       [rsp+150],r8
       mov       rcx,2EEB4800A50
       mov       rcx,[rcx]
       mov       [rsp+158],rcx
       mov       rcx,[rsp+150]
       mov       r11,[rsp+158]
M00_L09:
       test      edx,edx
       jne       near ptr M00_L20
       test      r11,r11
       je        near ptr M00_L47
       test      r13,r13
       je        near ptr M00_L58
       xor       r8d,r8d
       mov       [rsp+148],r8d
       cmp       qword ptr [r14+8],0
       je        near ptr M00_L33
       mov       r9,r14
       mov       r10d,[rsp+184]
       cmp       r10d,[r9+18]
       jg        near ptr M00_L22
       cmp       r10d,[r9+18]
       jge       near ptr M00_L52
       mov       [rsp+0F0],r9
       mov       r8,[r9+8]
       mov       [rsp+118],rcx
       mov       [rsp+120],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+148]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+140]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+118]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF66B8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+140],0
       je        short M00_L13
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L50
       test      rax,rax
       je        short M00_L10
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L10:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L21
M00_L11:
       add       ecx,1
       jo        near ptr M00_L60
       cmp       ecx,0FF
       ja        near ptr M00_L60
       mov       [r14+1D],cl
       mov       r9,r14
M00_L12:
       mov       r14,r9
       mov       [rsp+0F0],r14
M00_L13:
       cmp       byte ptr [rsp+140],0
       je        near ptr M00_L54
       mov       r14,[rsp+0F0]
       test      r14,r14
       je        near ptr M00_L59
       mov       rax,[r14+10]
       movzx     edx,byte ptr [rax+1D]
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       edx,ecx
       cmp       edx,2
       jl        near ptr M00_L27
       mov       rdx,rax
       test      rdx,rdx
       je        near ptr M00_L59
       mov       rcx,[rdx+10]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       ecx,edx
       js        near ptr M00_L30
       cmp       qword ptr [rax+8],0
       je        near ptr M00_L55
       mov       [rsp+0B8],rax
       mov       rdx,[rax+8]
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L56
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L31
M00_L14:
       add       ecx,1
       jo        near ptr M00_L60
       cmp       ecx,0FF
       ja        near ptr M00_L60
       mov       [r14+1D],cl
       mov       rdx,r14
M00_L15:
       mov       r14,[rsp+0B8]
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L57
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L32
M00_L16:
       add       ecx,1
       jo        near ptr M00_L60
       cmp       ecx,0FF
       ja        near ptr M00_L60
       mov       [r14+1D],cl
M00_L17:
       mov       rax,r14
M00_L18:
       mov       r14,rax
M00_L19:
       inc       r12d
M00_L20:
       mov       rax,[rsp+100]
       add       rax,8
       jmp       near ptr M00_L04
M00_L21:
       mov       ecx,eax
       jmp       near ptr M00_L11
M00_L22:
       mov       [rsp+0F0],r9
       mov       r8,[r9+10]
       mov       [rsp+118],rcx
       mov       [rsp+120],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+148]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+140]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+118]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF66B8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+140],0
       je        near ptr M00_L13
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L48
       test      rax,rax
       je        short M00_L23
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L23:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        short M00_L26
M00_L24:
       add       ecx,1
       jo        near ptr M00_L60
       cmp       ecx,0FF
       ja        near ptr M00_L60
       mov       [r14+1D],cl
       mov       r9,r14
M00_L25:
       mov       r14,r9
       mov       [rsp+0F0],r14
       jmp       near ptr M00_L13
M00_L26:
       mov       ecx,eax
       jmp       short M00_L24
M00_L27:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41CF6748]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jne       short M00_L28
       mov       rax,r14
       jmp       near ptr M00_L18
M00_L28:
       mov       rdx,[r14+8]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41CF6730]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jle       short M00_L29
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41CF67A8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M00_L18
M00_L29:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41CF6790]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M00_L18
M00_L30:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41CF6778]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M00_L18
M00_L31:
       mov       ecx,eax
       jmp       near ptr M00_L14
       nop       dword ptr [rax]
M00_L32:
       mov       ecx,eax
       jmp       near ptr M00_L16
M00_L33:
       mov       [rsp+78],r11
       mov       [rsp+80],rcx
       mov       dword ptr [rsp+140],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0E0],rax
       mov       r8,[rsp+80]
       mov       [rsp+118],r8
       mov       r8,[rsp+78]
       mov       [rsp+120],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+118]
       mov       edx,[rsp+184]
       mov       rcx,rax
       mov       r9,r14
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0E0]
       mov       rax,r14
       jmp       near ptr M00_L18
M00_L34:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+170],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+170]
       mov       r9d,r12d
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFB41CFF4B0]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rsp+170]
       vmovdqu   xmmword ptr [rsp+188],xmm0
       lea       rcx,[rsp+188]
       mov       r8,rbp
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFB41CFF4C8]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableHashSet`1<System.__Canon>)
       mov       [rsp+128],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+128]
       mov       rdx,7FFB41D30688
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF6820]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,198
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L35:
       mov       rcx,[rcx+10]
M00_L36:
       cmp       qword ptr [rcx+8],0
       je        near ptr M00_L07
       mov       r10d,[rsp+184]
M00_L37:
       mov       edx,[rcx+18]
       cmp       r10d,edx
       je        near ptr M00_L42
       jg        short M00_L35
       mov       rcx,[rcx+8]
       jmp       short M00_L36
M00_L38:
       call      qword ptr [7FFB41AD7228]
       mov       ecx,65
       mov       rdx,7FFB4193C248
       call      qword ptr [7FFB4153F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB41805AC0
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4193C248
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41CFD980]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41CFD998]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L39:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L41:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L42:
       mov       r9,[rcx+20]
       mov       r11,[rcx+28]
       jmp       near ptr M00_L08
M00_L43:
       mov       rcx,r15
       mov       [rsp+90],r9
       mov       r8,r9
       mov       rdx,[rsp+0F8]
       mov       r11,7FFB41480DB0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L44
       mov       [rsp+20],r15
       mov       r11,[rsp+88]
       mov       r9d,[r11+20]
       mov       [rsp+88],r11
       mov       rcx,r11
       mov       rdx,[rsp+0F8]
       xor       r8d,r8d
       call      qword ptr [7FFB41CFF180]
       test      eax,eax
       jl        short M00_L45
M00_L44:
       mov       ecx,1
       mov       rax,[rsp+90]
       mov       r10,[rsp+88]
       mov       edx,ecx
       mov       rcx,rax
       mov       r11,r10
       jmp       near ptr M00_L09
M00_L45:
       xor       edx,edx
       mov       [rsp+180],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+160],xmm0
       mov       rcx,[rsp+88]
       mov       rdx,[rsp+0F8]
       call      qword ptr [7FFB41CFF198]
       mov       rcx,[rsp+90]
       mov       [rsp+160],rcx
       test      rax,rax
       jne       short M00_L46
       mov       rax,2EEB4800A50
       mov       rax,[rax]
M00_L46:
       mov       [rsp+168],rax
       mov       rcx,[rsp+160]
       mov       rax,rcx
       mov       r11,[rsp+168]
       mov       r10,r11
       mov       rcx,rax
       mov       r11,r10
       mov       edx,[rsp+180]
       jmp       near ptr M00_L09
M00_L47:
       mov       r10d,[rsp+184]
       lea       r8,[rsp+148]
       mov       rcx,r14
       mov       edx,r10d
       call      qword ptr [7FFB41CFF498]
       mov       r14,rax
       jmp       near ptr M00_L19
M00_L48:
       mov       edx,[r14+18]
       mov       [rsp+13C],edx
       mov       r8,[r14+20]
       mov       [rsp+70],r8
       mov       r10,[r14+28]
       mov       [rsp+68],r10
       mov       r9,[r14+8]
       mov       [rsp+0D8],r9
       test      rax,rax
       mov       [rsp+0D0],rax
       jne       short M00_L49
       mov       rax,[r14+10]
       mov       [rsp+0D0],rax
M00_L49:
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rsp+70]
       mov       [rsp+118],r8
       mov       r8,[rsp+68]
       mov       [rsp+120],r8
       mov       r8,[rsp+0D0]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+118]
       mov       edx,[rsp+13C]
       mov       rcx,r14
       mov       r9,[rsp+0D8]
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r9,r14
       jmp       near ptr M00_L25
M00_L50:
       mov       edx,[r14+18]
       mov       [rsp+138],edx
       mov       r8,[r14+20]
       mov       [rsp+60],r8
       mov       r10,[r14+28]
       mov       [rsp+58],r10
       test      rax,rax
       mov       [rsp+0C8],rax
       jne       short M00_L51
       mov       rax,[r14+8]
       mov       [rsp+0C8],rax
M00_L51:
       mov       r14,[r14+10]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rsp+0C0],r9
       mov       r8,[rsp+60]
       mov       [rsp+118],r8
       mov       r8,[rsp+58]
       mov       [rsp+120],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+118]
       mov       edx,[rsp+138]
       mov       rcx,r9
       mov       r9,[rsp+0C8]
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0C0]
       mov       r9,r14
       jmp       near ptr M00_L12
M00_L52:
       vmovdqu   xmm0,xmmword ptr [r14+20]
       vmovdqu   xmmword ptr [rsp+118],xmm0
       mov       [rsp+80],rcx
       mov       [rsp+108],rcx
       mov       [rsp+78],r11
       mov       [rsp+110],r11
       lea       r8,[rsp+108]
       lea       rdx,[rsp+118]
       mov       rcx,r13
       mov       r11,7FFB41480DB8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L53
       xor       ecx,ecx
       mov       [rsp+140],ecx
       mov       rax,r14
       jmp       near ptr M00_L18
M00_L53:
       mov       dword ptr [rsp+140],1
       mov       dword ptr [rsp+148],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0E8],rax
       mov       r10,[rsp+80]
       mov       [rsp+118],r10
       mov       r11,[rsp+78]
       mov       [rsp+120],r11
       mov       r8,[r14+10]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+118]
       mov       r9,[r14+8]
       mov       edx,[rsp+184]
       mov       rcx,rax
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0E8]
       mov       [rsp+0F0],r14
       jmp       near ptr M00_L13
M00_L54:
       mov       r14,[rsp+0F0]
       mov       rax,r14
       jmp       near ptr M00_L18
M00_L55:
       mov       rax,r14
       jmp       near ptr M00_L18
M00_L56:
       mov       r8d,[r14+18]
       mov       [rsp+134],r8d
       mov       r10,[r14+20]
       mov       [rsp+50],r10
       mov       r9,[r14+28]
       mov       [rsp+48],r9
       mov       r14,[r14+8]
       mov       [rsp+0B0],rdx
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A8],rax
       mov       r8,[rsp+50]
       mov       [rsp+118],r8
       mov       r8,[rsp+48]
       mov       [rsp+120],r8
       mov       r8,[rsp+0B0]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+118]
       mov       edx,[rsp+134]
       mov       rcx,[rsp+0A8]
       mov       r9,r14
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0A8]
       mov       rdx,r14
       jmp       near ptr M00_L15
M00_L57:
       mov       eax,[r14+18]
       mov       [rsp+130],eax
       mov       r8,[r14+20]
       mov       [rsp+40],r8
       mov       r10,[r14+28]
       mov       [rsp+38],r10
       mov       [rsp+0A0],rdx
       mov       r14,[r14+10]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+98],rax
       mov       r8,[rsp+40]
       mov       [rsp+118],r8
       mov       r8,[rsp+38]
       mov       [rsp+120],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+118]
       mov       edx,[rsp+130]
       mov       rcx,rax
       mov       r9,[rsp+0A0]
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+98]
       jmp       near ptr M00_L17
M00_L58:
       mov       ecx,511
       mov       rdx,7FFB41D0E1A0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFF120]
       int       3
M00_L59:
       mov       ecx,869
       mov       rdx,7FFB41D0E1A0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFF120]
       int       3
M00_L60:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 3151
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M01_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
M01_L00:
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       jne       short M01_L03
M01_L01:
       xor       edx,edx
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       test      rax,rax
       je        short M01_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L02
       jmp       short M01_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M02_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       rbp,r9
       mov       r15,[rsp+0D8]
       mov       r14,[rsp+0E0]
       mov       byte ptr [r15],0
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L11
       mov       r13,rbx
       cmp       edi,[r13+18]
       jg        near ptr M02_L03
       cmp       edi,[r13+18]
       jge       near ptr M02_L16
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF66B8]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        short M02_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M02_L14
       test      rsi,rsi
       je        short M02_L01
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M02_L01:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M02_L23
       cmp       ecx,0FF
       ja        near ptr M02_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M02_L02:
       cmp       byte ptr [r14],0
       je        near ptr M02_L21
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M02_L22
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jl        near ptr M02_L06
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M02_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       js        near ptr M02_L09
       mov       rdx,r13
       call      qword ptr [7FFB41CF6760]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M02_L10
M02_L03:
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF66B8]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        near ptr M02_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M02_L12
       test      rdi,rdi
       je        short M02_L04
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M02_L23
       cmp       ecx,0FF
       ja        near ptr M02_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M02_L05:
       jmp       near ptr M02_L02
M02_L06:
       cmp       edx,0FFFFFFFE
       jle       short M02_L07
       mov       rax,r13
       jmp       short M02_L10
M02_L07:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M02_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M02_L08
       mov       rdx,r13
       call      qword ptr [7FFB41CF67A8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M02_L10
M02_L08:
       mov       rdx,r13
       call      qword ptr [7FFB41CF6790]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M02_L10
M02_L09:
       mov       rdx,r13
       call      qword ptr [7FFB41CF6778]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M02_L10:
       nop
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
M02_L11:
       mov       byte ptr [r14],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rbp+18],edi
       lea       rdi,[rbp+20]
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
       jo        near ptr M02_L23
       cmp       eax,0FF
       ja        near ptr M02_L23
       mov       [rbp+1D],al
       mov       rax,rbp
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
M02_L12:
       mov       r13d,[rbx+18]
       mov       rsi,[rbx+20]
       mov       rbp,[rbx+28]
       mov       r15,[rbx+8]
       test      rdi,rdi
       jne       short M02_L13
       mov       rdi,[rbx+10]
M02_L13:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       [rsp+50],rsi
       mov       [rsp+58],rbp
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+50]
       mov       edx,r13d
       mov       rcx,r12
       mov       r9,r15
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M02_L05
M02_L14:
       mov       r13d,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r15,[rbx+28]
       test      rsi,rsi
       jne       short M02_L15
       mov       rsi,[rbx+8]
M02_L15:
       mov       rdi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       [rsp+50],rbp
       mov       [rsp+58],r15
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+50]
       mov       edx,r13d
       mov       rcx,r12
       mov       r9,rsi
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M02_L02
M02_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFB41DBB660
       call      qword ptr [7FFB4153F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L18:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rdx,[rsp+50]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L19
       mov       byte ptr [r14],0
       mov       rax,rbx
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
M02_L19:
       cmp       byte ptr [rsp+0D0],0
       je        short M02_L20
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
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M02_L02
M02_L20:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFB41CFF138]
       mov       r15,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFB41CFF150]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB418A5E60]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M02_L21:
       mov       rax,r13
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
M02_L22:
       mov       ecx,869
       mov       rdx,7FFB41D0E1A0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFF120]
       int       3
M02_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1145
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M03_L00
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rdx+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       eax,ecx
       cmp       eax,0FFFFFFFE
       setle     al
       movzx     eax,al
       add       rsp,28
       ret
M03_L00:
       mov       ecx,869
       mov       rdx,7FFB41D0E1A0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFF120]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M04_L00
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rdx+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       eax,ecx
       add       rsp,28
       ret
M04_L00:
       mov       ecx,869
       mov       rdx,7FFB41D0E1A0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFF120]
       int       3
; Total bytes of code 63
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
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
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L14
       mov       rsi,[rbx+8]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M05_L08
       test      rsi,rsi
       je        near ptr M05_L14
       mov       rbp,[rsi+10]
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M05_L09
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M05_L10
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rdi+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L18
       cmp       ecx,0FF
       ja        near ptr M05_L18
       mov       [rsi+1D],cl
M05_L00:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M05_L11
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbp+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L18
       cmp       ecx,0FF
       ja        near ptr M05_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M05_L01:
       mov       rsi,rdx
M05_L02:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M05_L12
       test      rsi,rsi
       je        short M05_L03
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M05_L03:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L18
       cmp       ecx,0FF
       ja        near ptr M05_L18
       mov       [rbx+1D],cl
M05_L04:
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M05_L15
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M05_L16
       test      rbp,rbp
       je        short M05_L05
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M05_L05:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L18
       cmp       ecx,0FF
       ja        near ptr M05_L18
       mov       [rbx+1D],cl
M05_L06:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M05_L17
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rdi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L18
       cmp       ecx,0FF
       ja        near ptr M05_L18
       mov       [rdi+1D],cl
       mov       rax,rdi
M05_L07:
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
M05_L08:
       mov       rax,rbx
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
M05_L09:
       jmp       near ptr M05_L02
M05_L10:
       mov       r15d,[rsi+18]
       mov       r13,[rsi+20]
       mov       r12,[rsi+28]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],r13
       mov       [rsp+38],r12
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       rcx,rsi
       mov       r9,rdi
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M05_L00
M05_L11:
       mov       edi,[rbp+18]
       mov       r14,[rbp+20]
       mov       r15,[rbp+28]
       mov       r13,[rbp+10]
       mov       rcx,[rbp]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],r13
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbp
       mov       r9,rsi
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M05_L01
M05_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       test      rsi,rsi
       jne       short M05_L13
       mov       rsi,[rbx+8]
M05_L13:
       mov       r15,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbx
       mov       r9,rsi
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M05_L04
M05_L14:
       mov       ecx,869
       mov       rdx,7FFB41D0E1A0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFF120]
       int       3
M05_L15:
       mov       rax,rbx
       jmp       near ptr M05_L07
M05_L16:
       mov       r14d,[rbx+18]
       mov       r15,[rbx+20]
       mov       r13,[rbx+28]
       test      rbp,rbp
       cmove     rbp,rsi
       mov       rsi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],r15
       mov       [rsp+38],r13
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r14d
       mov       rcx,rbx
       mov       r9,rbp
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M05_L06
M05_L17:
       mov       esi,[rdi+18]
       mov       rbp,[rdi+20]
       mov       r14,[rdi+28]
       mov       r15,[rdi+8]
       mov       rcx,[rdi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],rbx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,esi
       mov       rcx,rdi
       mov       r9,r15
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M05_L07
M05_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 941
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M06_L03
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M06_L04
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L05
       test      rbp,rbp
       je        short M06_L00
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M06_L00:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L07
       cmp       ecx,0FF
       ja        near ptr M06_L07
       mov       [rbx+1D],cl
M06_L01:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M06_L06
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rdi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L07
       cmp       ecx,0FF
       ja        near ptr M06_L07
       mov       [rdi+1D],cl
       mov       rax,rdi
M06_L02:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L03:
       mov       ecx,869
       mov       rdx,7FFB41D0E1A0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFF120]
       int       3
M06_L04:
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L05:
       mov       r14d,[rbx+18]
       mov       r15,[rbx+20]
       mov       r13,[rbx+28]
       test      rbp,rbp
       cmove     rbp,rsi
       mov       rsi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+38],r15
       mov       [rsp+40],r13
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,r14d
       mov       rcx,rbx
       mov       r9,rbp
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L01
M06_L06:
       mov       esi,[rdi+18]
       mov       rbp,[rdi+20]
       mov       r14,[rdi+28]
       mov       r15,[rdi+8]
       mov       rcx,[rdi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+38],rbp
       mov       [rsp+40],r14
       mov       [rsp+20],rbx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,esi
       mov       rcx,rdi
       mov       r9,r15
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M06_L02
M06_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 438
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
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
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M07_L14
       mov       rsi,[rbx+10]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M07_L08
       test      rsi,rsi
       je        near ptr M07_L14
       cmp       qword ptr [rdi+8],0
       je        near ptr M07_L09
       mov       rbp,rdi
       mov       rdx,[rbp+10]
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M07_L10
       test      r14,r14
       je        short M07_L00
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L00:
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L18
       cmp       ecx,0FF
       ja        near ptr M07_L18
       mov       [rsi+1D],cl
M07_L01:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M07_L11
       lea       rcx,[rbp+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbp+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L18
       cmp       ecx,0FF
       ja        near ptr M07_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M07_L02:
       mov       rsi,rdx
M07_L03:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M07_L12
       test      rsi,rsi
       je        short M07_L04
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M07_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L18
       cmp       ecx,0FF
       ja        near ptr M07_L18
       mov       [rbx+1D],cl
M07_L05:
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M07_L15
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M07_L16
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L18
       cmp       ecx,0FF
       ja        near ptr M07_L18
       mov       [rbx+1D],cl
M07_L06:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M07_L17
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L18
       cmp       ecx,0FF
       ja        near ptr M07_L18
       mov       [rsi+1D],cl
       mov       rax,rsi
M07_L07:
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
M07_L08:
       mov       rax,rbx
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
M07_L09:
       jmp       near ptr M07_L03
M07_L10:
       mov       r15d,[rsi+18]
       mov       r13,[rsi+20]
       mov       r12,[rsi+28]
       test      r14,r14
       cmove     r14,rdi
       mov       rdi,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],r13
       mov       [rsp+38],r12
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M07_L01
M07_L11:
       mov       edi,[rbp+18]
       mov       r14,[rbp+20]
       mov       r15,[rbp+28]
       mov       r13,[rbp+8]
       mov       rcx,[rbp]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbp
       mov       r9,r13
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M07_L02
M07_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       mov       r15,[rbx+8]
       test      rsi,rsi
       jne       short M07_L13
       mov       rsi,[rbx+10]
M07_L13:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbx
       mov       r9,r15
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M07_L05
M07_L14:
       mov       ecx,869
       mov       rdx,7FFB41D0E1A0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFF120]
       int       3
M07_L15:
       mov       rax,rbx
       jmp       near ptr M07_L07
M07_L16:
       mov       ebp,[rbx+18]
       mov       r14,[rbx+20]
       mov       r15,[rbx+28]
       mov       r13,[rbx+8]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,ebp
       mov       rcx,rbx
       mov       r9,r13
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M07_L06
M07_L17:
       mov       edi,[rsi+18]
       mov       rbp,[rsi+20]
       mov       r14,[rsi+28]
       mov       r15,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rsi
       mov       r9,rbx
       call      qword ptr [7FFB41CF66D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M07_L07
M07_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 943
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
       je        short M08_L00
       test      r14,r14
       je        near ptr M08_L01
       mov       [rbx+18],edx
       lea       rdi,[rbx+20]
       mov       rsi,r8
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
       jo        short M08_L02
       cmp       ecx,0FF
       ja        short M08_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L00:
       mov       ecx,847
       mov       rdx,7FFB41D0E1A0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFF120]
       int       3
M08_L01:
       mov       ecx,851
       mov       rdx,7FFB41D0E1A0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFF120]
       int       3
M08_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 215
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r9d
       test      r8,r8
       je        short M09_L00
       mov       rcx,rbx
       mov       rdx,r8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rbx+8],esi
       mov       esi,[rsp+60]
       mov       [rbx+0C],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L00:
       mov       ecx,4AB
       mov       rdx,7FFB41D0E1A0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFF120]
       int       3
; Total bytes of code 76
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableHashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rdx
       mov       rbx,r8
       test      rbx,rbx
       je        near ptr M10_L06
       mov       esi,[rcx+8]
       cmp       dword ptr [rcx+0C],0
       jne       short M10_L00
       add       esi,[rbx+20]
M10_L00:
       mov       rdi,[rcx]
       cmp       rdi,[rbx+10]
       je        near ptr M10_L07
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rbx,[rbx+8]
       test      rdi,rdi
       je        near ptr M10_L08
       test      rbx,rbx
       je        near ptr M10_L09
       mov       r14,[rbp]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax+8]
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M10_L02
       test      r15,r15
       je        short M10_L01
       mov       r13d,[rdi+18]
       mov       r12,[rdi+20]
       mov       rax,[rdi+28]
       mov       [rsp+20],rax
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__89_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [r15+18],rcx
       jne       near ptr M10_L10
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       test      rax,rax
       je        short M10_L01
       cmp       byte ptr [rax+24],0
       jne       short M10_L01
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF6808]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       r12,[rsp+20]
       mov       rcx,[r12+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF6808]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r12+24],1
M10_L01:
       mov       rcx,[rdi+8]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF6580]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       rcx,[rdi+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB41CF6580]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       byte ptr [rdi+1C],1
M10_L02:
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+20],esi
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+98]
       test      rdx,rdx
       je        short M10_L05
M10_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,rbp
M10_L04:
       mov       rax,rbx
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
M10_L05:
       mov       rdx,7FFB41DBDB08
       call      qword ptr [7FFB4153F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M10_L03
M10_L06:
       mov       ecx,577
       mov       rdx,7FFB41D0E1A0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFF120]
       int       3
M10_L07:
       jmp       short M10_L04
M10_L08:
       mov       ecx,4AB
       mov       rdx,7FFB41D0E1A0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFF120]
       int       3
M10_L09:
       mov       ecx,4B5
       mov       rdx,7FFB41D0E1A0
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41CFF120]
       int       3
M10_L10:
       mov       [rsp+28],r13d
       mov       [rsp+30],r12
       mov       [rsp+38],rax
       lea       rdx,[rsp+28]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       jmp       near ptr M10_L01
; Total bytes of code 504
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
       je        near ptr M12_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M12_L01
       test      rsi,rsi
       je        short M12_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M12_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M12_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M12_L00:
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
M12_L01:
       test      rsi,rsi
       je        short M12_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M12_L03
M12_L02:
       mov       rax,32F33610008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M12_L03:
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
M12_L04:
       call      qword ptr [7FFB41CFE598]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M13_L00
       ret
M13_L00:
       jmp       qword ptr [7FFB41535C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.HashSetExtensionsCollectionBenchmark.ToImmutableHashSet()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,198
       xor       eax,eax
       mov       [rsp+108],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+110],ymm4
       vmovdqu   ymmword ptr [rsp+130],ymm4
       vmovdqu   ymmword ptr [rsp+150],ymm4
       vmovdqu   ymmword ptr [rsp+170],ymm4
       mov       [rsp+190],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M00_L38
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L39
       mov       rcx,rsi
       mov       r11,7FFB41480FA0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L01
       test      byte ptr [7FFB41E9D850],1
       je        near ptr M00_L40
M00_L00:
       mov       rdx,24765C00B48
       mov       rdi,[rdx]
       jmp       short M00_L02
M00_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r11,7FFB41480FA8
       xor       r8d,r8d
       call      qword ptr [r11]
M00_L02:
       test      rdi,rdi
       je        near ptr M00_L41
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
M00_L03:
       mov       rcx,24765C00AD0
       mov       rbp,[rcx]
       mov       r14,[rbp+10]
       mov       r15,[rbp+8]
       mov       r13,[rbp+18]
       xor       r12d,r12d
       xor       eax,eax
       inc       edi
       jmp       near ptr M00_L20
M00_L04:
       xor       ecx,ecx
       xor       r10d,r10d
M00_L05:
       mov       [rsp+184],r10d
       cmp       [r14],r14b
       mov       rcx,r14
       cmp       qword ptr [r14+8],0
       jne       near ptr M00_L37
M00_L06:
       xor       r9d,r9d
       xor       r11d,r11d
M00_L07:
       mov       [rsp+88],r11
       test      r11,r11
       jne       near ptr M00_L43
       xor       edx,edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+150],xmm0
       mov       [rsp+150],r8
       mov       rcx,24765C00AF8
       mov       rcx,[rcx]
       mov       [rsp+158],rcx
       mov       rcx,[rsp+150]
       mov       r11,[rsp+158]
M00_L08:
       test      edx,edx
       jne       near ptr M00_L19
       test      r11,r11
       je        near ptr M00_L47
       test      r13,r13
       je        near ptr M00_L58
       xor       r8d,r8d
       mov       [rsp+148],r8d
       cmp       qword ptr [r14+8],0
       je        near ptr M00_L33
       mov       r9,r14
       mov       r10d,[rsp+184]
       cmp       r10d,[r9+18]
       jg        near ptr M00_L22
       cmp       r10d,[r9+18]
       jge       near ptr M00_L52
       mov       [rsp+0F0],r9
       mov       r8,[r9+8]
       mov       [rsp+118],rcx
       mov       [rsp+120],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+148]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+140]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+118]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D5E0D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+140],0
       je        short M00_L12
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L50
       test      rax,rax
       je        short M00_L09
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L09:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L21
M00_L10:
       add       ecx,1
       jo        near ptr M00_L60
       cmp       ecx,0FF
       ja        near ptr M00_L60
       mov       [r14+1D],cl
       mov       r9,r14
M00_L11:
       mov       r14,r9
       mov       [rsp+0F0],r14
M00_L12:
       cmp       byte ptr [rsp+140],0
       je        near ptr M00_L54
       mov       r14,[rsp+0F0]
       test      r14,r14
       je        near ptr M00_L59
       mov       rax,[r14+10]
       movzx     edx,byte ptr [rax+1D]
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       edx,ecx
       cmp       edx,2
       jl        near ptr M00_L27
       mov       rdx,rax
       test      rdx,rdx
       je        near ptr M00_L59
       mov       rcx,[rdx+10]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       ecx,edx
       js        near ptr M00_L30
       cmp       qword ptr [rax+8],0
       je        near ptr M00_L55
       mov       [rsp+0B8],rax
       mov       rdx,[rax+8]
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L56
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L31
M00_L13:
       add       ecx,1
       jo        near ptr M00_L60
       cmp       ecx,0FF
       ja        near ptr M00_L60
       mov       [r14+1D],cl
       mov       rdx,r14
M00_L14:
       mov       r14,[rsp+0B8]
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L57
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L32
M00_L15:
       add       ecx,1
       jo        near ptr M00_L60
       cmp       ecx,0FF
       ja        near ptr M00_L60
       mov       [r14+1D],cl
M00_L16:
       mov       rax,r14
M00_L17:
       mov       r14,rax
M00_L18:
       inc       r12d
M00_L19:
       mov       rax,[rsp+100]
       add       rax,8
M00_L20:
       dec       edi
       je        near ptr M00_L34
       mov       [rsp+100],rax
       mov       r8,[rsi+rax]
       mov       [rsp+0F8],r8
       test      r8,r8
       je        near ptr M00_L04
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FFB41480FB0
       call      qword ptr [r11]
       mov       r10d,eax
       mov       r8,[rsp+0F8]
       jmp       near ptr M00_L05
M00_L21:
       mov       ecx,eax
       jmp       near ptr M00_L10
M00_L22:
       mov       [rsp+0F0],r9
       mov       r8,[r9+10]
       mov       [rsp+118],rcx
       mov       [rsp+120],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+148]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+140]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+118]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D5E0D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+140],0
       je        near ptr M00_L12
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L48
       test      rax,rax
       je        short M00_L23
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L23:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        short M00_L26
M00_L24:
       add       ecx,1
       jo        near ptr M00_L60
       cmp       ecx,0FF
       ja        near ptr M00_L60
       mov       [r14+1D],cl
       mov       r9,r14
M00_L25:
       mov       r14,r9
       mov       [rsp+0F0],r14
       jmp       near ptr M00_L12
M00_L26:
       mov       ecx,eax
       jmp       short M00_L24
M00_L27:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41D5E160]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jne       short M00_L28
       mov       rax,r14
       jmp       near ptr M00_L17
M00_L28:
       mov       rdx,[r14+8]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41D5E148]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jle       short M00_L29
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41D5E178]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M00_L17
M00_L29:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41D5E1A8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M00_L17
M00_L30:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      qword ptr [7FFB41D5E1C0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M00_L17
M00_L31:
       mov       ecx,eax
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,eax
       jmp       near ptr M00_L15
M00_L33:
       mov       [rsp+78],r11
       mov       [rsp+80],rcx
       mov       dword ptr [rsp+140],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0E0],rax
       mov       r8,[rsp+80]
       mov       [rsp+118],r8
       mov       r8,[rsp+78]
       mov       [rsp+120],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+118]
       mov       edx,[rsp+184]
       mov       rcx,rax
       mov       r9,r14
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0E0]
       mov       rax,r14
       jmp       near ptr M00_L17
M00_L34:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+170],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+170]
       mov       r9d,r12d
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFB41EA4000]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rsp+170]
       vmovdqu   xmmword ptr [rsp+188],xmm0
       lea       rcx,[rsp+188]
       mov       r8,rbp
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFB41EA4018]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableHashSet`1<System.__Canon>)
       mov       [rsp+128],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+128]
       mov       rdx,7FFB41DD4A30
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D5E238]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,198
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L35:
       mov       rcx,[rcx+8]
M00_L36:
       cmp       qword ptr [rcx+8],0
       je        near ptr M00_L06
       mov       r10d,[rsp+184]
M00_L37:
       mov       edx,[rcx+18]
       cmp       r10d,edx
       je        near ptr M00_L42
       jle       short M00_L35
       mov       rcx,[rcx+10]
       jmp       short M00_L36
M00_L38:
       call      qword ptr [7FFB41ADEFD0]
       mov       ecx,65
       mov       rdx,7FFB4193C248
       call      qword ptr [7FFB4153F228]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFB41805AC0
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB4193C248
       call      qword ptr [7FFB4153F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB4153D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB41C14DB0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB41C14DC8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L39:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L41:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L03
M00_L42:
       mov       r9,[rcx+20]
       mov       r11,[rcx+28]
       jmp       near ptr M00_L07
M00_L43:
       mov       rcx,r15
       mov       [rsp+90],r9
       mov       r8,r9
       mov       rdx,[rsp+0F8]
       mov       r11,7FFB41480FB8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L44
       mov       [rsp+20],r15
       mov       r11,[rsp+88]
       mov       r9d,[r11+20]
       mov       [rsp+88],r11
       mov       rcx,r11
       mov       rdx,[rsp+0F8]
       xor       r8d,r8d
       call      qword ptr [7FFB41D5FD80]
       test      eax,eax
       jl        short M00_L45
M00_L44:
       mov       ecx,1
       mov       rax,[rsp+90]
       mov       r10,[rsp+88]
       mov       edx,ecx
       mov       rcx,rax
       mov       r11,r10
       jmp       near ptr M00_L08
M00_L45:
       xor       edx,edx
       mov       [rsp+180],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+160],xmm0
       mov       rcx,[rsp+88]
       mov       rdx,[rsp+0F8]
       call      qword ptr [7FFB41D5FD98]
       mov       rcx,[rsp+90]
       mov       [rsp+160],rcx
       test      rax,rax
       jne       short M00_L46
       mov       rax,24765C00AF8
       mov       rax,[rax]
M00_L46:
       mov       [rsp+168],rax
       mov       rcx,[rsp+160]
       mov       rax,rcx
       mov       r11,[rsp+168]
       mov       r10,r11
       mov       rcx,rax
       mov       r11,r10
       mov       edx,[rsp+180]
       jmp       near ptr M00_L08
M00_L47:
       mov       r10d,[rsp+184]
       lea       r8,[rsp+148]
       mov       rcx,r14
       mov       edx,r10d
       call      qword ptr [7FFB41D5FFD8]
       mov       r14,rax
       jmp       near ptr M00_L18
M00_L48:
       mov       edx,[r14+18]
       mov       [rsp+13C],edx
       mov       r8,[r14+20]
       mov       [rsp+70],r8
       mov       r10,[r14+28]
       mov       [rsp+68],r10
       mov       r9,[r14+8]
       mov       [rsp+0D8],r9
       test      rax,rax
       mov       [rsp+0D0],rax
       jne       short M00_L49
       mov       rax,[r14+10]
       mov       [rsp+0D0],rax
M00_L49:
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rsp+70]
       mov       [rsp+118],r8
       mov       r8,[rsp+68]
       mov       [rsp+120],r8
       mov       r8,[rsp+0D0]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+118]
       mov       edx,[rsp+13C]
       mov       rcx,r14
       mov       r9,[rsp+0D8]
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r9,r14
       jmp       near ptr M00_L25
M00_L50:
       mov       edx,[r14+18]
       mov       [rsp+138],edx
       mov       r8,[r14+20]
       mov       [rsp+60],r8
       mov       r10,[r14+28]
       mov       [rsp+58],r10
       test      rax,rax
       mov       [rsp+0C8],rax
       jne       short M00_L51
       mov       rax,[r14+8]
       mov       [rsp+0C8],rax
M00_L51:
       mov       r14,[r14+10]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rsp+0C0],r9
       mov       r8,[rsp+60]
       mov       [rsp+118],r8
       mov       r8,[rsp+58]
       mov       [rsp+120],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+118]
       mov       edx,[rsp+138]
       mov       rcx,r9
       mov       r9,[rsp+0C8]
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0C0]
       mov       r9,r14
       jmp       near ptr M00_L11
M00_L52:
       vmovdqu   xmm0,xmmword ptr [r14+20]
       vmovdqu   xmmword ptr [rsp+118],xmm0
       mov       [rsp+80],rcx
       mov       [rsp+108],rcx
       mov       [rsp+78],r11
       mov       [rsp+110],r11
       lea       r8,[rsp+108]
       lea       rdx,[rsp+118]
       mov       rcx,r13
       mov       r11,7FFB41480FC0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L53
       xor       ecx,ecx
       mov       [rsp+140],ecx
       mov       rax,r14
       jmp       near ptr M00_L17
M00_L53:
       mov       dword ptr [rsp+140],1
       mov       dword ptr [rsp+148],1
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0E8],rax
       mov       r10,[rsp+80]
       mov       [rsp+118],r10
       mov       r11,[rsp+78]
       mov       [rsp+120],r11
       mov       r8,[r14+10]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+118]
       mov       r9,[r14+8]
       mov       edx,[rsp+184]
       mov       rcx,rax
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0E8]
       mov       [rsp+0F0],r14
       jmp       near ptr M00_L12
M00_L54:
       mov       r14,[rsp+0F0]
       mov       rax,r14
       jmp       near ptr M00_L17
M00_L55:
       mov       rax,r14
       jmp       near ptr M00_L17
M00_L56:
       mov       r8d,[r14+18]
       mov       [rsp+134],r8d
       mov       r10,[r14+20]
       mov       [rsp+50],r10
       mov       r9,[r14+28]
       mov       [rsp+48],r9
       mov       r14,[r14+8]
       mov       [rsp+0B0],rdx
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A8],rax
       mov       r8,[rsp+50]
       mov       [rsp+118],r8
       mov       r8,[rsp+48]
       mov       [rsp+120],r8
       mov       r8,[rsp+0B0]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+118]
       mov       edx,[rsp+134]
       mov       rcx,[rsp+0A8]
       mov       r9,r14
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0A8]
       mov       rdx,r14
       jmp       near ptr M00_L14
M00_L57:
       mov       eax,[r14+18]
       mov       [rsp+130],eax
       mov       r8,[r14+20]
       mov       [rsp+40],r8
       mov       r10,[r14+28]
       mov       [rsp+38],r10
       mov       [rsp+0A0],rdx
       mov       r14,[r14+10]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+98],rax
       mov       r8,[rsp+40]
       mov       [rsp+118],r8
       mov       r8,[rsp+38]
       mov       [rsp+120],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+118]
       mov       edx,[rsp+130]
       mov       rcx,rax
       mov       r9,[rsp+0A0]
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+98]
       jmp       near ptr M00_L16
M00_L58:
       mov       ecx,511
       mov       rdx,7FFB41DB2758
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D5FD20]
       int       3
M00_L59:
       mov       ecx,869
       mov       rdx,7FFB41DB2758
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D5FD20]
       int       3
M00_L60:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 3155
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L00
       cmp       [rdx],rcx
       jne       short M01_L01
M01_L00:
       mov       rax,rdx
       ret
M01_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
M01_L02:
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       jne       short M01_L04
M01_L03:
       xor       edx,edx
       jmp       short M01_L00
M01_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M01_L00
       jmp       short M01_L02
; Total bytes of code 88
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M02_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       [rsp+60],rcx
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       rbp,r9
       mov       r15,[rsp+0D8]
       mov       r14,[rsp+0E0]
       mov       byte ptr [r15],0
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L11
       mov       r13,rbx
       cmp       edi,[r13+18]
       jg        near ptr M02_L03
       cmp       edi,[r13+18]
       jge       near ptr M02_L16
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D5E0D0]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        short M02_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M02_L14
       test      rsi,rsi
       je        short M02_L01
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M02_L01:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M02_L23
       cmp       ecx,0FF
       ja        near ptr M02_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M02_L02:
       cmp       byte ptr [r14],0
       je        near ptr M02_L21
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M02_L22
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jl        near ptr M02_L06
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M02_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       js        near ptr M02_L09
       mov       rdx,r13
       call      qword ptr [7FFB41D5E190]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M02_L10
M02_L03:
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D5E0D0]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        near ptr M02_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M02_L12
       test      rdi,rdi
       je        short M02_L04
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M02_L23
       cmp       ecx,0FF
       ja        near ptr M02_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M02_L05:
       jmp       near ptr M02_L02
M02_L06:
       cmp       edx,0FFFFFFFE
       jle       short M02_L07
       mov       rax,r13
       jmp       short M02_L10
M02_L07:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M02_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M02_L08
       mov       rdx,r13
       call      qword ptr [7FFB41D5E178]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M02_L10
M02_L08:
       mov       rdx,r13
       call      qword ptr [7FFB41D5E1A8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M02_L10
M02_L09:
       mov       rdx,r13
       call      qword ptr [7FFB41D5E1C0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M02_L10:
       nop
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
M02_L11:
       mov       byte ptr [r14],1
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rbp+18],edi
       lea       rdi,[rbp+20]
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
       jo        near ptr M02_L23
       cmp       eax,0FF
       ja        near ptr M02_L23
       mov       [rbp+1D],al
       mov       rax,rbp
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
M02_L12:
       mov       r13d,[rbx+18]
       mov       rsi,[rbx+20]
       mov       rbp,[rbx+28]
       mov       r15,[rbx+8]
       test      rdi,rdi
       jne       short M02_L13
       mov       rdi,[rbx+10]
M02_L13:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       [rsp+50],rsi
       mov       [rsp+58],rbp
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+50]
       mov       edx,r13d
       mov       rcx,r12
       mov       r9,r15
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M02_L05
M02_L14:
       mov       r13d,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r15,[rbx+28]
       test      rsi,rsi
       jne       short M02_L15
       mov       rsi,[rbx+8]
M02_L15:
       mov       rdi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       [rsp+50],rbp
       mov       [rsp+58],r15
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+50]
       mov       edx,r13d
       mov       rcx,r12
       mov       r9,rsi
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M02_L02
M02_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFB41E809F0
       call      qword ptr [7FFB4153F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M02_L18:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rdx,[rsp+50]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L19
       mov       byte ptr [r14],0
       mov       rax,rbx
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
M02_L19:
       cmp       byte ptr [rsp+0D0],0
       je        short M02_L20
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
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M02_L02
M02_L20:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFB41D5FD38]
       mov       r15,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFB41D5FD50]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFB418A5E60]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M02_L21:
       mov       rax,r13
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
M02_L22:
       mov       ecx,869
       mov       rdx,7FFB41DB2758
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D5FD20]
       int       3
M02_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1145
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M03_L00
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rdx+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       eax,ecx
       cmp       eax,0FFFFFFFE
       setle     al
       movzx     eax,al
       add       rsp,28
       ret
M03_L00:
       mov       ecx,869
       mov       rdx,7FFB41DB2758
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D5FD20]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M04_L00
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rdx+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       eax,ecx
       add       rsp,28
       ret
M04_L00:
       mov       ecx,869
       mov       rdx,7FFB41DB2758
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D5FD20]
       int       3
; Total bytes of code 63
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
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
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L14
       mov       rsi,[rbx+8]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M05_L08
       test      rsi,rsi
       je        near ptr M05_L14
       mov       rbp,[rsi+10]
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M05_L09
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M05_L10
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rdi+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L18
       cmp       ecx,0FF
       ja        near ptr M05_L18
       mov       [rsi+1D],cl
M05_L00:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M05_L11
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbp+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L18
       cmp       ecx,0FF
       ja        near ptr M05_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M05_L01:
       mov       rsi,rdx
M05_L02:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M05_L12
       test      rsi,rsi
       je        short M05_L03
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M05_L03:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L18
       cmp       ecx,0FF
       ja        near ptr M05_L18
       mov       [rbx+1D],cl
M05_L04:
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M05_L15
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M05_L16
       test      rbp,rbp
       je        short M05_L05
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M05_L05:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L18
       cmp       ecx,0FF
       ja        near ptr M05_L18
       mov       [rbx+1D],cl
M05_L06:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M05_L17
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rdi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M05_L18
       cmp       ecx,0FF
       ja        near ptr M05_L18
       mov       [rdi+1D],cl
       mov       rax,rdi
M05_L07:
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
M05_L08:
       mov       rax,rbx
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
M05_L09:
       jmp       near ptr M05_L02
M05_L10:
       mov       r15d,[rsi+18]
       mov       r13,[rsi+20]
       mov       r12,[rsi+28]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],r13
       mov       [rsp+38],r12
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       rcx,rsi
       mov       r9,rdi
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M05_L00
M05_L11:
       mov       edi,[rbp+18]
       mov       r14,[rbp+20]
       mov       r15,[rbp+28]
       mov       r13,[rbp+10]
       mov       rcx,[rbp]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],r13
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbp
       mov       r9,rsi
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M05_L01
M05_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       test      rsi,rsi
       jne       short M05_L13
       mov       rsi,[rbx+8]
M05_L13:
       mov       r15,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbx
       mov       r9,rsi
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M05_L04
M05_L14:
       mov       ecx,869
       mov       rdx,7FFB41DB2758
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D5FD20]
       int       3
M05_L15:
       mov       rax,rbx
       jmp       near ptr M05_L07
M05_L16:
       mov       r14d,[rbx+18]
       mov       r15,[rbx+20]
       mov       r13,[rbx+28]
       test      rbp,rbp
       cmove     rbp,rsi
       mov       rsi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],r15
       mov       [rsp+38],r13
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r14d
       mov       rcx,rbx
       mov       r9,rbp
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M05_L06
M05_L17:
       mov       esi,[rdi+18]
       mov       rbp,[rdi+20]
       mov       r14,[rdi+28]
       mov       r15,[rdi+8]
       mov       rcx,[rdi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],rbx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,esi
       mov       rcx,rdi
       mov       r9,r15
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M05_L07
M05_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 941
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M06_L03
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M06_L04
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L05
       test      rbp,rbp
       je        short M06_L00
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M06_L00:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L07
       cmp       ecx,0FF
       ja        near ptr M06_L07
       mov       [rbx+1D],cl
M06_L01:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M06_L06
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rdi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L07
       cmp       ecx,0FF
       ja        near ptr M06_L07
       mov       [rdi+1D],cl
       mov       rax,rdi
M06_L02:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L03:
       mov       ecx,869
       mov       rdx,7FFB41DB2758
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D5FD20]
       int       3
M06_L04:
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L05:
       mov       r14d,[rbx+18]
       mov       r15,[rbx+20]
       mov       r13,[rbx+28]
       test      rbp,rbp
       cmove     rbp,rsi
       mov       rsi,[rbx+10]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+38],r15
       mov       [rsp+40],r13
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,r14d
       mov       rcx,rbx
       mov       r9,rbp
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L01
M06_L06:
       mov       esi,[rdi+18]
       mov       rbp,[rdi+20]
       mov       r14,[rdi+28]
       mov       r15,[rdi+8]
       mov       rcx,[rdi]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+38],rbp
       mov       [rsp+40],r14
       mov       [rsp+20],rbx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+38]
       mov       edx,esi
       mov       rcx,rdi
       mov       r9,r15
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M06_L02
M06_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 438
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
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
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       [rsp+40],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M07_L14
       mov       rsi,[rbx+10]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M07_L08
       test      rsi,rsi
       je        near ptr M07_L14
       cmp       qword ptr [rdi+8],0
       je        near ptr M07_L09
       mov       rbp,rdi
       mov       rdx,[rbp+10]
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M07_L10
       test      r14,r14
       je        short M07_L00
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L00:
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L18
       cmp       ecx,0FF
       ja        near ptr M07_L18
       mov       [rsi+1D],cl
M07_L01:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M07_L11
       lea       rcx,[rbp+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbp+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L18
       cmp       ecx,0FF
       ja        near ptr M07_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M07_L02:
       mov       rsi,rdx
M07_L03:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M07_L12
       test      rsi,rsi
       je        short M07_L04
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M07_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L18
       cmp       ecx,0FF
       ja        near ptr M07_L18
       mov       [rbx+1D],cl
M07_L05:
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M07_L15
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M07_L16
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L18
       cmp       ecx,0FF
       ja        near ptr M07_L18
       mov       [rbx+1D],cl
M07_L06:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M07_L17
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L18
       cmp       ecx,0FF
       ja        near ptr M07_L18
       mov       [rsi+1D],cl
       mov       rax,rsi
M07_L07:
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
M07_L08:
       mov       rax,rbx
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
M07_L09:
       jmp       near ptr M07_L03
M07_L10:
       mov       r15d,[rsi+18]
       mov       r13,[rsi+20]
       mov       r12,[rsi+28]
       test      r14,r14
       cmove     r14,rdi
       mov       rdi,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],r13
       mov       [rsp+38],r12
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M07_L01
M07_L11:
       mov       edi,[rbp+18]
       mov       r14,[rbp+20]
       mov       r15,[rbp+28]
       mov       r13,[rbp+8]
       mov       rcx,[rbp]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbp
       mov       r9,r13
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M07_L02
M07_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       mov       r15,[rbx+8]
       test      rsi,rsi
       jne       short M07_L13
       mov       rsi,[rbx+10]
M07_L13:
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],rsi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rbx
       mov       r9,r15
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M07_L05
M07_L14:
       mov       ecx,869
       mov       rdx,7FFB41DB2758
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D5FD20]
       int       3
M07_L15:
       mov       rax,rbx
       jmp       near ptr M07_L07
M07_L16:
       mov       ebp,[rbx+18]
       mov       r14,[rbx+20]
       mov       r15,[rbx+28]
       mov       r13,[rbx+8]
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       [rsp+30],r14
       mov       [rsp+38],r15
       mov       [rsp+20],rdi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,ebp
       mov       rcx,rbx
       mov       r9,r13
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M07_L06
M07_L17:
       mov       edi,[rsi+18]
       mov       rbp,[rsi+20]
       mov       r14,[rsi+28]
       mov       r15,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+30],rbp
       mov       [rsp+38],r14
       mov       [rsp+20],r15
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+30]
       mov       edx,edi
       mov       rcx,rsi
       mov       r9,rbx
       call      qword ptr [7FFB41D5E0E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M07_L07
M07_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 943
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
       je        short M08_L00
       test      r14,r14
       je        near ptr M08_L01
       mov       [rbx+18],edx
       lea       rdi,[rbx+20]
       mov       rsi,r8
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
       jo        short M08_L02
       cmp       ecx,0FF
       ja        short M08_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L00:
       mov       ecx,847
       mov       rdx,7FFB41DB2758
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D5FD20]
       int       3
M08_L01:
       mov       ecx,851
       mov       rdx,7FFB41DB2758
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D5FD20]
       int       3
M08_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 215
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r9d
       test      r8,r8
       je        short M09_L00
       mov       rcx,rbx
       mov       rdx,r8
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rbx+8],esi
       mov       esi,[rsp+60]
       mov       [rbx+0C],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L00:
       mov       ecx,4AB
       mov       rdx,7FFB41DB2758
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D5FD20]
       int       3
; Total bytes of code 76
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableHashSet`1<System.__Canon>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rdx
       mov       rbx,r8
       test      rbx,rbx
       je        near ptr M10_L06
       mov       esi,[rcx+8]
       cmp       dword ptr [rcx+0C],0
       jne       short M10_L00
       add       esi,[rbx+20]
M10_L00:
       mov       rdi,[rcx]
       cmp       rdi,[rbx+10]
       je        near ptr M10_L07
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rbx,[rbx+8]
       test      rdi,rdi
       je        near ptr M10_L08
       test      rbx,rbx
       je        near ptr M10_L09
       mov       r14,[rbp]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax+8]
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M10_L02
       test      r15,r15
       je        short M10_L01
       mov       r13d,[rdi+18]
       mov       r12,[rdi+20]
       mov       rax,[rdi+28]
       mov       [rsp+20],rax
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__89_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [r15+18],rcx
       jne       near ptr M10_L10
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       test      rax,rax
       je        short M10_L01
       cmp       byte ptr [rax+24],0
       jne       short M10_L01
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D5E220]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       r12,[rsp+20]
       mov       rcx,[r12+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D5E220]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r12+24],1
M10_L01:
       mov       rcx,[rdi+8]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D5DF98]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       rcx,[rdi+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFB41D5DF98]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       byte ptr [rdi+1C],1
M10_L02:
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+20],esi
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M10_L05
M10_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,rbp
M10_L04:
       mov       rax,rbx
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
M10_L05:
       mov       rdx,7FFB41E85E58
       call      qword ptr [7FFB4153F4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M10_L03
M10_L06:
       mov       ecx,577
       mov       rdx,7FFB41DB2758
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D5FD20]
       int       3
M10_L07:
       jmp       short M10_L04
M10_L08:
       mov       ecx,4AB
       mov       rdx,7FFB41DB2758
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D5FD20]
       int       3
M10_L09:
       mov       ecx,4B5
       mov       rdx,7FFB41DB2758
       call      qword ptr [7FFB4153F228]
       mov       rcx,rax
       call      qword ptr [7FFB41D5FD20]
       int       3
M10_L10:
       mov       [rsp+28],r13d
       mov       [rsp+30],r12
       mov       [rsp+38],rax
       lea       rdx,[rsp+28]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       jmp       near ptr M10_L01
; Total bytes of code 504
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
       je        near ptr M12_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M12_L00
       test      rbx,rbx
       je        near ptr M12_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M12_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M12_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFBA11B9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB41535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB41535818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M12_L00:
       test      rbx,rbx
       je        short M12_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M12_L02
M12_L01:
       mov       rax,287E49F0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M12_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M12_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M12_L04:
       call      qword ptr [7FFB41D5E9E8]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M13_L00
       ret
M13_L00:
       jmp       qword ptr [7FFB41535C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

