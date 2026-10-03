## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1EB7FC01FF8
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
       call      qword ptr [7FFC13706D48]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,1EB7FC00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0E688EB4F
       mov       r8d,8BFB00A
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
       call      qword ptr [7FFC13706EB0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
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
       mov       rcx,[rbx+90]
       lea       r8,[rsp+28]
       mov       rdx,7FFC137335D8
       cmp       [rcx],ecx
       call      qword ptr [7FFC13706FD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFC134CFDC8]
       mov       ecx,65
       mov       rdx,7FFC13350E78
       call      qword ptr [7FFC1314C030]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC132057E0
       call      qword ptr [7FFC1314C030]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13350E78
       call      qword ptr [7FFC1314C030]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC137967D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC134CF570]
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
       mov       r11,7FFC12E70E58
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L16:
       call      qword ptr [7FFC134CFDC8]
       mov       ecx,24AB
       mov       rdx,7FFC132057E0
       call      qword ptr [7FFC1314C030]
       mov       rdi,rax
       mov       ecx,191A
       mov       rdx,7FFC132057E0
       call      qword ptr [7FFC1314C030]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFC132057E0
       call      qword ptr [7FFC1314C030]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC137967D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC134CF570]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1177
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
       call      qword ptr [7FFC1314C9C0]
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
       mov       rdx,7FFC13718678
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L03
M02_L06:
       call      qword ptr [7FFC134CFDC8]
       mov       ecx,24AB
       mov       rdx,7FFC132057E0
       call      qword ptr [7FFC1314C030]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC132057E0
       call      qword ptr [7FFC1314C030]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFC132057E0
       call      qword ptr [7FFC1314C030]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC137967D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC134CF570]
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
       mov       rdx,7FFC13718930
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F25998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFC13718930
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       xor       esi,esi
       xor       eax,eax
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
       mov       rdx,7FFC13718678
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       setg      cl
       movzx     ecx,cl
       mov       esi,1
       mov       eax,ecx
       mov       rcx,[rbp+10]
M02_L22:
       movzx     edi,al
       cmp       byte ptr [rbp-50],0
       je        short M02_L24
       mov       rcx,[rbp-90]
       call      qword ptr [7FFC12F26820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+10]
       jmp       short M02_L24
M02_L23:
       call      M02_L65
       jmp       near ptr M02_L11
M02_L24:
       test      edi,edi
       je        near ptr M02_L61
       xor       edx,edx
       mov       [rbp-54],edx
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+10]
       xor       r14d,r14d
       test      r14d,r14d
       jg        short M02_L29
M02_L25:
       mov       byte ptr [rbp-60],0
       cmp       r14d,[rdi+8]
       jae       short M02_L26
       mov       rcx,[rdi+r14*8+10]
       lea       rdx,[rbp-60]
       call      qword ptr [7FFC12F25998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       add       r14d,1
       jo        near ptr M02_L58
       test      r14d,r14d
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
       call      qword ptr [7FFC13796880]
       test      eax,eax
       jne       short M02_L33
       mov       edi,7FEFFFFF
       mov       r14d,1
       jmp       short M02_L34
M02_L33:
       mov       edi,[rbp-68]
       xor       r14d,r14d
M02_L34:
       mov       rcx,[rbx+10]
       mov       r15d,[rcx+8]
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
       call      qword ptr [7FFC12F25998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       cmp       r12d,r15d
       jl        short M02_L35
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+1C],0
       je        short M02_L40
       mov       rdx,[rbx+10]
       cmp       dword ptr [rdx+8],400
       jl        short M02_L41
M02_L40:
       mov       r15,[rbx+10]
       jmp       near ptr M02_L44
M02_L41:
       mov       rdx,[rbx+10]
       mov       edx,[rdx+8]
       imul      rdx,2
       jo        near ptr M02_L58
       mov       rcx,offset MT_System.Object[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       mov       rcx,[rbx+10]
       mov       ecx,[rcx+8]
       mov       [rsp+20],ecx
       mov       rcx,[rbx+10]
       mov       r8,r15
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFC1345E6B8]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rcx,[rbx+10]
       mov       r13d,[rcx+8]
       jmp       short M02_L43
M02_L42:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[r15+8]
       cmp       r13,rcx
       jae       near ptr M02_L57
       lea       rcx,[r15+r13*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r13,1
       jo        near ptr M02_L58
M02_L43:
       mov       ecx,[r15+8]
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
       mov       rdx,7FFC13717F18
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L46:
       mov       rcx,rax
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       edx,[r15+8]
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
       mov       r11d,[rdi+8]
       mov       edx,[r15+8]
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
       mov       rdx,7FFC13718678
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L50:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0A8],rax
       mov       r8,[rbp-98]
       mov       rdx,[r8+8]
       mov       r8d,[r8+18]
       mov       [rbp-80],r8d
       mov       r10d,[rbp-74]
       cmp       r10d,[rdi+8]
       jae       near ptr M02_L57
       mov       ecx,r10d
       mov       r9,[rdi+rcx*8+10]
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
       mov       rcx,rdi
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
       mov       eax,[rdi+8]
       mov       r8d,[r15+8]
       test      r14d,r14d
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
       mov       rdx,7FFC13718160
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L56:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r15
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
       call      qword ptr [7FFC12F26820]; System.Threading.Monitor.Exit(System.Object)
       add       ebx,1
       jo        short M02_L64
       mov       rcx,[rbp+10]
M02_L60:
       cmp       ebx,[rbp-54]
       jl        short M02_L59
M02_L61:
       mov       eax,esi
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
       call      qword ptr [7FFC12F26820]; System.Threading.Monitor.Exit(System.Object)
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
       xor       esi,esi
       cmp       esi,[rbp-54]
       jge       short M02_L72
M02_L71:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       esi,[rax+8]
       jae       short M02_L73
       mov       edx,esi
       mov       rcx,[rax+rdx*8+10]
       call      qword ptr [7FFC12F26820]; System.Threading.Monitor.Exit(System.Object)
       add       esi,1
       jo        short M02_L74
       cmp       esi,[rbp-54]
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
; Total bytes of code 2494
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
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22C14A80008
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
       call      qword ptr [7FFC1370D980]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2197D001FD0
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
       call      qword ptr [7FFC136C5F50]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,2197D000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,96FE11DF
       mov       r8d,0DA79C9E1
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
       call      qword ptr [7FFC136C60B8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
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
       mov       rcx,[rbx+90]
       lea       r8,[rsp+28]
       mov       rdx,7FFC136F7DA0
       cmp       [rcx],ecx
       call      qword ptr [7FFC136C61D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFC134AEFA0]
       mov       ecx,65
       mov       rdx,7FFC13320598
       call      qword ptr [7FFC13127798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131D4F28
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13320598
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136CF0D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136CE4F0]
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
       mov       r11,7FFC12E50C00
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L16:
       call      qword ptr [7FFC134AEFA0]
       mov       ecx,24AB
       mov       rdx,7FFC131D4F28
       call      qword ptr [7FFC13127798]
       mov       rdi,rax
       mov       ecx,191A
       mov       rdx,7FFC131D4F28
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFC131D4F28
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136CF0D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136CE4F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1177
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
       call      qword ptr [7FFC1312C138]
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
       mov       rdx,7FFC136EA7F8
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L03
M02_L06:
       call      qword ptr [7FFC134AEFA0]
       mov       ecx,24AB
       mov       rdx,7FFC131D4F28
       call      qword ptr [7FFC13127798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131D4F28
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFC131D4F28
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136CF0D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136CE4F0]
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
       mov       rdx,7FFC136EAAB0
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F05998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFC136EAAB0
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC136EA7F8
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F06820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12F05998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFC136CF180]
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
       call      qword ptr [7FFC12F05998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFC1342D9B0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rdx,7FFC136EA098
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC136EA7F8
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC136EA2E0
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F06820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12F06820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12F06820]; System.Threading.Monitor.Exit(System.Object)
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
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,25A12160008
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
       call      qword ptr [7FFC136CEAD8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1FE7EC01FB8
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
       call      qword ptr [7FFC136C5BF0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
M00_L06:
       lea       rcx,[rsp+30]
       mov       rdx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      qword ptr [7FFC136C5A88]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,1FE7EC00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,4EF0C118
       mov       r8d,1C134B0D
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
       mov       rcx,[rbx+90]
       lea       r8,[rsp+28]
       mov       rdx,7FFC136F4AE0
       cmp       [rcx],ecx
       call      qword ptr [7FFC136C5D10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFC134BEB08]
       mov       ecx,65
       mov       rdx,7FFC13330598
       call      qword ptr [7FFC13137798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13330598
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136CF0C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136CE4D8]
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
       mov       r11,7FFC12E60C08
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L16:
       call      qword ptr [7FFC134BEB08]
       mov       ecx,24AB
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdi,rax
       mov       ecx,191A
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136CF0C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136CE4D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1181
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
       mov       rdx,7FFC136EA428
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L03
M01_L06:
       call      qword ptr [7FFC134BEB08]
       mov       ecx,24AB
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136CF0C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136CE4D8]
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
       mov       rdx,7FFC136EA6E0
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFC136EA6E0
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC136EA428
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F16820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12F15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFC136CF168]
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
       call      qword ptr [7FFC12F15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFC1343D9B0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rdx,7FFC136E9CC8
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC136EA428
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC136E9F10
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F16820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12F16820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12F16820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC1313C138]
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
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23F13C70008
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
       call      qword ptr [7FFC136CEAC0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,20220C01FD0
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
       call      qword ptr [7FFC136D5F50]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
M00_L06:
       lea       rcx,[rsp+30]
       mov       rdx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      qword ptr [7FFC136D5DE8]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,20220C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0F42B9948
       mov       r8d,0E77F4CD8
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
       mov       rcx,[rbx+90]
       lea       r8,[rsp+28]
       mov       rdx,7FFC13706370
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D6070]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFC134BEEB0]
       mov       ecx,65
       mov       rdx,7FFC13330598
       call      qword ptr [7FFC13137798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13330598
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136DF0F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136DE4F0]
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
       mov       r11,7FFC12E60D88
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L16:
       call      qword ptr [7FFC134BEEB0]
       mov       ecx,24AB
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdi,rax
       mov       ecx,191A
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136DF0F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136DE4F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1181
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
       mov       rdx,7FFC136FA7F8
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L03
M01_L06:
       call      qword ptr [7FFC134BEEB0]
       mov       ecx,24AB
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136DF0F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136DE4F0]
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
       mov       rdx,7FFC136FAAB0
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFC136FAAB0
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC136FA7F8
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F16820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12F15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFC136DF198]
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
       call      qword ptr [7FFC12F15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFC1343D9B0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rdx,7FFC136FA098
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC136FA7F8
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC136FA2E0
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F16820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12F16820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12F16820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC1313C138]
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
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,242B5AD0008
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
       call      qword ptr [7FFC136DEAD8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,211BF801FB8
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
       call      qword ptr [7FFC135EE778]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,211BF800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,43D2E9BD
       mov       r8d,0A3E28032
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
       call      qword ptr [7FFC135EE8E0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
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
       mov       rcx,[rbx+90]
       lea       r8,[rsp+28]
       mov       rdx,7FFC136C4740
       cmp       [rcx],ecx
       call      qword ptr [7FFC135EEA00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFC134B7720]
       mov       ecx,65
       mov       rdx,7FFC13330598
       call      qword ptr [7FFC13137798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13330598
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC135EECB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC135EECD0]
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
       mov       r11,7FFC12E60B08
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L16:
       call      qword ptr [7FFC134B7720]
       mov       ecx,24AB
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdi,rax
       mov       ecx,191A
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC135EECB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC135EECD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1177
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
       call      qword ptr [7FFC1313C138]
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
       mov       rdx,7FFC136BA0A8
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L03
M02_L06:
       call      qword ptr [7FFC134B7720]
       mov       ecx,24AB
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC135EECB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC135EECD0]
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
       mov       rdx,7FFC136BA360
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFC136BA360
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC136BA0A8
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F16820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12F15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFC136E7CF0]
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
       call      qword ptr [7FFC12F15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFC1343D9B0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rdx,7FFC136B9948
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC136BA0A8
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F157B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       mov       rdx,7FFC136B9B90
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F16820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12F16820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12F16820]; System.Threading.Monitor.Exit(System.Object)
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
; Total bytes of code 2497
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
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,252547B0008
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
       call      qword ptr [7FFC136ED098]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,140E0001FB8
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
       call      qword ptr [7FFC136B5B90]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
M00_L06:
       lea       rcx,[rsp+30]
       mov       rdx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      qword ptr [7FFC136B5A28]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,140E0000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,2E80B1E2
       mov       r8d,0DDCED36B
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
       mov       rcx,[rbx+90]
       lea       r8,[rsp+28]
       mov       rdx,7FFC136E44E8
       cmp       [rcx],ecx
       call      qword ptr [7FFC136B5CB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFC1349EAA8]
       mov       ecx,65
       mov       rdx,7FFC13310598
       call      qword ptr [7FFC13117798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131C4F28
       call      qword ptr [7FFC13117798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12EF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13310598
       call      qword ptr [7FFC13117798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12EF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136B6010]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136B6028]
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
       mov       r11,7FFC12E40C00
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L16:
       call      qword ptr [7FFC1349EAA8]
       mov       ecx,24AB
       mov       rdx,7FFC131C4F28
       call      qword ptr [7FFC13117798]
       mov       rdi,rax
       mov       ecx,191A
       mov       rdx,7FFC131C4F28
       call      qword ptr [7FFC13117798]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC12EF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFC131C4F28
       call      qword ptr [7FFC13117798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12EF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136B6010]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136B6028]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1181
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
       mov       rdx,7FFC136CA428
       call      qword ptr [7FFC12EFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L03
M01_L06:
       call      qword ptr [7FFC1349EAA8]
       mov       ecx,24AB
       mov       rdx,7FFC131C4F28
       call      qword ptr [7FFC13117798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131C4F28
       call      qword ptr [7FFC13117798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12EF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFC131C4F28
       call      qword ptr [7FFC13117798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12EF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136B6010]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136B6028]
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
       mov       rdx,7FFC136CA6E0
       call      qword ptr [7FFC12EFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12EF5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFC136CA6E0
       call      qword ptr [7FFC12EFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC136CA428
       call      qword ptr [7FFC12EFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12EF6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12EF5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFC136BF048]
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
       call      qword ptr [7FFC12EF5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFC1341D9B0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rdx,7FFC136C9CC8
       call      qword ptr [7FFC12EFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC136CA428
       call      qword ptr [7FFC12EFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC136C9F10
       call      qword ptr [7FFC12EFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12EF6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12EF6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12EF6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC1311C138]
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
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12EF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12EF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,18174F50008
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
       call      qword ptr [7FFC136BEA18]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,22847801FB8
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
       call      qword ptr [7FFC136E6610]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
M00_L06:
       lea       rcx,[rsp+30]
       mov       rdx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
       call      qword ptr [7FFC136E64A8]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,22847800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0DDA37D6B
       mov       r8d,0C544D60C
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
       mov       rcx,[rbx+90]
       lea       r8,[rsp+28]
       mov       rdx,7FFC13715010
       cmp       [rcx],ecx
       call      qword ptr [7FFC136E6730]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFC134C7738]
       mov       ecx,65
       mov       rdx,7FFC13340598
       call      qword ptr [7FFC13147798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13340598
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136E7438]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136E7450]
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
       mov       r11,7FFC12E70D20
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L16:
       call      qword ptr [7FFC134C7738]
       mov       ecx,24AB
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rdi,rax
       mov       ecx,191A
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136E7438]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136E7450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1181
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
       mov       rdx,7FFC1370A470
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L03
M01_L06:
       call      qword ptr [7FFC134C7738]
       mov       ecx,24AB
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136E7438]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136E7450]
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
       mov       rdx,7FFC1370A728
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F25998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFC1370A728
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC1370A470
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F26820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12F25998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFC136EFAF8]
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
       call      qword ptr [7FFC12F25998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFC1344D9B0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rdx,7FFC13709D10
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC1370A470
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC13709F58
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F26820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12F26820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12F26820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC1314C138]
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
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,268DC6A0008
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
       call      qword ptr [7FFC136EEE08]
       int       3
; Total bytes of code 244
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+2E8]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,25D9D802008
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
       call      qword ptr [7FFC1373E688]; System.Collections.Generic.HashSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,25D9D800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L14
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,150410B
       mov       r8d,3207ACA
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
       call      qword ptr [7FFC1373E7F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AddInternal(System.__Canon, Int32, Boolean)
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
       mov       rcx,[rbx+90]
       lea       r8,[rsp+28]
       mov       rdx,7FFC137BB038
       cmp       [rcx],ecx
       call      qword ptr [7FFC1373E910]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFC134CEF28]
       mov       ecx,65
       mov       rdx,7FFC13340598
       call      qword ptr [7FFC13147798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13340598
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136077B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136077C8]
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
       mov       r11,7FFC12E70FB0
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L16:
       call      qword ptr [7FFC134CEF28]
       mov       ecx,24AB
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rdi,rax
       mov       ecx,191A
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136077B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136077C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1177
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
       call      qword ptr [7FFC1314C138]
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
       mov       rdx,7FFC137A4BA8
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L03
M02_L06:
       call      qword ptr [7FFC134CEF28]
       mov       ecx,24AB
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136077B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136077C8]
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
       mov       rdx,7FFC137A4E60
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F25998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       mov       rdx,7FFC137A4E60
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC137A4BA8
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F26820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12F25998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFC1373FD50]
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
       call      qword ptr [7FFC12F25998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
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
       call      qword ptr [7FFC1344D9B0]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rdx,7FFC137A4448
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC137A4BA8
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdx,7FFC137A4690
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       call      qword ptr [7FFC12F26820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12F26820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFC12F26820]; System.Threading.Monitor.Exit(System.Object)
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
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,29E32950008
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
       call      qword ptr [7FFC1373F108]
       int       3
; Total bytes of code 235
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,158
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       vmovdqu   ymmword ptr [rsp+0F0],ymm4
       vmovdqu   ymmword ptr [rsp+110],ymm4
       vmovdqu   ymmword ptr [rsp+130],ymm4
       xor       eax,eax
       mov       [rsp+150],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L33
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC12EF6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L34
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rdi,rcx
       jne       near ptr M00_L35
       mov       eax,[rsi+28]
       sub       eax,[rsi+30]
M00_L00:
       test      eax,eax
       je        near ptr M00_L38
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r8,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rdi,r8
       jne       near ptr M00_L37
       xor       edi,edi
       mov       r14d,[rsi+28]
       sub       r14d,[rsi+30]
       js        near ptr M00_L36
       mov       r8d,[rbp+8]
       test      r8d,r8d
       jl        near ptr M00_L06
       cmp       r8d,r14d
       jl        near ptr M00_L06
       mov       r15,[rsi+10]
       xor       r13d,r13d
       cmp       dword ptr [rsi+28],0
       jle       short M00_L03
M00_L01:
       test      r14d,r14d
       je        short M00_L03
       cmp       r13d,[r15+8]
       jae       near ptr M00_L55
       mov       r8,r13
       shl       r8,4
       lea       r8,[r15+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M00_L02
       lea       edx,[rdi+1]
       mov       r12d,edx
       mov       r8,[r8]
       movsxd    rdx,edi
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r14d
       mov       edi,r12d
M00_L02:
       inc       r13d
       cmp       r13d,[rsi+28]
       jl        short M00_L01
M00_L03:
       test      rbp,rbp
       je        near ptr M00_L39
       lea       rsi,[rbp+10]
       mov       edi,[rbp+8]
M00_L04:
       mov       rcx,1926C000A30
       mov       rbp,[rcx]
       mov       r14,[rbp+10]
       mov       r15,[rbp+8]
       mov       r13,[rbp+18]
       xor       r12d,r12d
       xor       eax,eax
       inc       edi
M00_L05:
       dec       edi
       jne       near ptr M00_L07
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+130],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+130]
       mov       r9d,r12d
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFC136FC228]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rsp+130]
       vmovdqu   xmmword ptr [rsp+148],xmm0
       lea       rcx,[rsp+148]
       mov       r8,rbp
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFC136FC240]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableHashSet`1<System.__Canon>)
       mov       [rsp+0F0],rax
       mov       rcx,[rbx+90]
       lea       r8,[rsp+0F0]
       mov       rdx,7FFC136C1DD0
       cmp       [rcx],ecx
       call      qword ptr [7FFC135CEB80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,158
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L06:
       mov       ecx,6
       call      qword ptr [7FFC136FC0A8]
       int       3
M00_L07:
       mov       [rsp+0C0],rax
       mov       r8,[rsi+rax]
       mov       [rsp+0B8],r8
       test      r8,r8
       je        short M00_L08
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FFC12E40B30
       call      qword ptr [r11]
       mov       r10d,eax
       mov       r8,[rsp+0B8]
       jmp       short M00_L09
M00_L08:
       xor       ecx,ecx
       xor       r10d,r10d
M00_L09:
       mov       [rsp+144],r10d
       cmp       [r14],r14b
       mov       rcx,r14
       cmp       qword ptr [r14+8],0
       jne       near ptr M00_L32
M00_L10:
       xor       r9d,r9d
       xor       r11d,r11d
M00_L11:
       mov       [rsp+68],r11
       test      r11,r11
       jne       near ptr M00_L41
       xor       edx,edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+110],xmm0
       mov       [rsp+110],r8
       mov       rcx,1926C000A58
       mov       rcx,[rcx]
       mov       [rsp+118],rcx
       mov       rcx,[rsp+110]
       mov       r11,[rsp+118]
M00_L12:
       test      edx,edx
       jne       near ptr M00_L28
       test      r11,r11
       je        near ptr M00_L45
       test      r13,r13
       je        near ptr M00_L53
       xor       r8d,r8d
       mov       [rsp+108],r8d
       mov       r9,[r14+8]
       test      r9,r9
       je        near ptr M00_L29
       mov       rdx,r14
       mov       r8d,[rdx+18]
       mov       r10d,[rsp+144]
       cmp       r10d,r8d
       jle       near ptr M00_L18
       mov       [rsp+0B0],rdx
       mov       r8,[rdx+10]
       mov       [rsp+0E0],rcx
       mov       [rsp+0E8],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+108]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+100]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+0E0]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC135CEA18]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+100],0
       je        short M00_L16
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L46
       test      rax,rax
       je        short M00_L13
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L13:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L17
M00_L14:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+1D],cl
       mov       rdx,r14
M00_L15:
       mov       [rsp+0B0],rdx
M00_L16:
       cmp       byte ptr [rsp+100],0
       je        near ptr M00_L52
       mov       r14,[rsp+0B0]
       test      r14,r14
       je        near ptr M00_L54
       mov       rax,[r14+10]
       movzx     edx,byte ptr [rax+1D]
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       edx,ecx
       cmp       edx,2
       jl        near ptr M00_L23
       mov       [rsp+78],rax
       mov       rdx,rax
       mov       rcx,7FFC13730B28
       mov       r8,1D2EB071A18
       call      qword ptr [7FFC135CE8B0]; System.Collections.Immutable.Requires.NotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String)
       mov       rdx,[rsp+78]
       mov       rcx,[rdx+10]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       ecx,edx
       js        near ptr M00_L26
       mov       rdx,r14
       mov       r14,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,r14
       call      qword ptr [7FFC135CEAC0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       near ptr M00_L27
M00_L17:
       mov       ecx,eax
       jmp       near ptr M00_L14
M00_L18:
       cmp       r10d,r8d
       jge       near ptr M00_L50
       mov       [rsp+0B0],rdx
       mov       [rsp+0E0],rcx
       mov       [rsp+0E8],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+108]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+100]
       mov       [rsp+30],rcx
       mov       rcx,r9
       lea       r8,[rsp+0E0]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC135CEA18]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+100],0
       je        near ptr M00_L16
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L48
       test      rax,rax
       je        short M00_L19
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L19:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        short M00_L22
M00_L20:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+1D],cl
       mov       rdx,r14
M00_L21:
       mov       r14,rdx
       mov       [rsp+0B0],r14
       jmp       near ptr M00_L16
M00_L22:
       mov       ecx,eax
       jmp       short M00_L20
M00_L23:
       mov       rdx,r14
       mov       rax,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       [rsp+0C8],rax
       mov       rcx,rax
       call      qword ptr [7FFC135CEAA8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jne       short M00_L24
       jmp       short M00_L27
M00_L24:
       mov       rdx,[r14+8]
       mov       rcx,[rsp+0C8]
       call      qword ptr [7FFC135CEA90]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jle       short M00_L25
       mov       rdx,r14
       mov       rcx,[rsp+0C8]
       call      qword ptr [7FFC135CEB08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       short M00_L27
M00_L25:
       mov       rdx,r14
       mov       rcx,[rsp+0C8]
       call      qword ptr [7FFC135CEAF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       short M00_L27
M00_L26:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r14,rcx
       call      qword ptr [7FFC135CEAD8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
M00_L27:
       inc       r12d
M00_L28:
       mov       rax,[rsp+0C0]
       add       rax,8
       jmp       near ptr M00_L05
M00_L29:
       mov       [rsp+58],r11
       mov       [rsp+60],rcx
       mov       dword ptr [rsp+100],1
       mov       rdx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A0],rax
       mov       r8d,[rsp+144]
       mov       [rax+18],r8d
       lea       rcx,[rax+20]
       mov       rdx,[rsp+60]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       lea       rcx,[rax+28]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsp+0A0]
       mov       byte ptr [r8+1C],0
       movzx     ecx,byte ptr [r14+1D]
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r8+1D],cl
       mov       r14,r8
       jmp       near ptr M00_L27
M00_L30:
       mov       rcx,[rcx+10]
M00_L31:
       cmp       qword ptr [rcx+8],0
       je        near ptr M00_L10
       mov       r10d,[rsp+144]
M00_L32:
       mov       edx,[rcx+18]
       cmp       r10d,edx
       je        near ptr M00_L40
       jg        short M00_L30
       mov       rcx,[rcx+8]
       jmp       short M00_L31
M00_L33:
       call      qword ptr [7FFC13497738]
       mov       ecx,65
       mov       rdx,7FFC13310598
       call      qword ptr [7FFC13117798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131C4F28
       call      qword ptr [7FFC13117798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12EF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13310598
       call      qword ptr [7FFC13117798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12EF7840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136FC660]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136FC678]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rbp,rax
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,rsi
       mov       r11,7FFC12E40B20
       call      qword ptr [r11]
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,28F
       mov       rdx,7FFC12E34000
       call      qword ptr [7FFC13117798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFC136FC078]
       int       3
M00_L37:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFC12E40B28
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L38:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1926C000A80
       mov       rbp,[rcx]
       jmp       near ptr M00_L03
M00_L39:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L04
M00_L40:
       mov       r9,[rcx+20]
       mov       r11,[rcx+28]
       jmp       near ptr M00_L11
M00_L41:
       mov       rcx,r15
       mov       [rsp+70],r9
       mov       r8,r9
       mov       rdx,[rsp+0B8]
       mov       r11,7FFC12E40B38
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L42
       mov       [rsp+20],r15
       mov       r11,[rsp+68]
       mov       r9d,[r11+20]
       mov       [rsp+68],r11
       mov       rcx,r11
       mov       rdx,[rsp+0B8]
       xor       r8d,r8d
       call      qword ptr [7FFC136F7EB8]
       test      eax,eax
       jl        short M00_L43
M00_L42:
       mov       ecx,1
       mov       rax,[rsp+70]
       mov       r10,[rsp+68]
       mov       edx,ecx
       mov       rcx,rax
       mov       r11,r10
       jmp       near ptr M00_L12
M00_L43:
       xor       edx,edx
       mov       [rsp+140],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+120],xmm0
       mov       rcx,[rsp+68]
       mov       rdx,[rsp+0B8]
       call      qword ptr [7FFC136F7ED0]
       mov       rcx,[rsp+70]
       mov       [rsp+120],rcx
       test      rax,rax
       jne       short M00_L44
       mov       rax,1926C000A58
       mov       rax,[rax]
M00_L44:
       mov       [rsp+128],rax
       mov       rcx,[rsp+120]
       mov       rax,rcx
       mov       r11,[rsp+128]
       mov       r10,r11
       mov       rcx,rax
       mov       r11,r10
       mov       edx,[rsp+140]
       jmp       near ptr M00_L12
M00_L45:
       mov       r10d,[rsp+144]
       lea       r8,[rsp+108]
       mov       rcx,r14
       mov       edx,r10d
       call      qword ptr [7FFC136FC210]
       mov       r14,rax
       jmp       near ptr M00_L27
M00_L46:
       mov       edx,[r14+18]
       mov       [rsp+0FC],edx
       mov       r8,[r14+20]
       mov       [rsp+50],r8
       mov       r10,[r14+28]
       mov       [rsp+48],r10
       mov       r9,[r14+8]
       mov       [rsp+98],r9
       test      rax,rax
       mov       [rsp+90],rax
       jne       short M00_L47
       mov       rax,[r14+10]
       mov       [rsp+90],rax
M00_L47:
       mov       r14,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rsp+50]
       mov       [rsp+0E0],r8
       mov       r8,[rsp+48]
       mov       [rsp+0E8],r8
       mov       r8,[rsp+90]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0E0]
       mov       edx,[rsp+0FC]
       mov       rcx,r14
       mov       r9,[rsp+98]
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,r14
       jmp       near ptr M00_L15
M00_L48:
       mov       edx,[r14+18]
       mov       [rsp+0F8],edx
       mov       r8,[r14+20]
       mov       [rsp+40],r8
       mov       r10,[r14+28]
       mov       [rsp+38],r10
       test      rax,rax
       mov       [rsp+88],rax
       jne       short M00_L49
       mov       rax,[r14+8]
       mov       [rsp+88],rax
M00_L49:
       mov       r14,[r14+10]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r9,rcx
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+80],rax
       mov       r8,[rsp+40]
       mov       [rsp+0E0],r8
       mov       r8,[rsp+38]
       mov       [rsp+0E8],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0E0]
       mov       edx,[rsp+0F8]
       mov       rcx,[rsp+80]
       mov       r9,[rsp+88]
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+80]
       mov       rdx,r14
       jmp       near ptr M00_L21
M00_L50:
       vmovdqu   xmm0,xmmword ptr [r14+20]
       vmovdqu   xmmword ptr [rsp+0E0],xmm0
       mov       [rsp+60],rcx
       mov       [rsp+0D0],rcx
       mov       [rsp+58],r11
       mov       [rsp+0D8],r11
       lea       r8,[rsp+0D0]
       lea       rdx,[rsp+0E0]
       mov       rcx,r13
       mov       r11,7FFC12E40B40
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L51
       xor       ecx,ecx
       mov       [rsp+100],ecx
       jmp       near ptr M00_L27
M00_L51:
       mov       dword ptr [rsp+100],1
       mov       dword ptr [rsp+108],1
       mov       r9,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rax,r9
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A8],rax
       mov       r10,[rsp+60]
       mov       [rsp+0E0],r10
       mov       r11,[rsp+58]
       mov       [rsp+0E8],r11
       mov       r8,[r14+10]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0E0]
       mov       r9,[r14+8]
       mov       edx,[rsp+144]
       mov       rcx,rax
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0A8]
       mov       [rsp+0B0],r14
       jmp       near ptr M00_L16
M00_L52:
       mov       r14,[rsp+0B0]
       jmp       near ptr M00_L27
M00_L53:
       mov       ecx,511
       mov       rdx,7FFC1369F178
       call      qword ptr [7FFC13117798]
       mov       rcx,rax
       call      qword ptr [7FFC136F7DE0]
       int       3
M00_L54:
       mov       ecx,869
       mov       rdx,7FFC1369F178
       call      qword ptr [7FFC13117798]
       mov       rcx,rax
       call      qword ptr [7FFC136F7DE0]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2940
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
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       jne       short M02_L03
M02_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFC72BA40D0
M02_L01:
       call      qword ptr [7FFC136F7D20]
       int       3
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M02_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFC12EFD8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r9d
       test      r8,r8
       je        short M03_L00
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
M03_L00:
       mov       ecx,4AB
       mov       rdx,7FFC1369F178
       call      qword ptr [7FFC13117798]
       mov       rcx,rax
       call      qword ptr [7FFC136F7DE0]
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
       je        near ptr M04_L06
       mov       esi,[rcx+8]
       cmp       dword ptr [rcx+0C],0
       jne       short M04_L00
       add       esi,[rbx+20]
M04_L00:
       mov       rdi,[rcx]
       cmp       rdi,[rbx+10]
       je        near ptr M04_L07
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rbx,[rbx+8]
       test      rdi,rdi
       je        near ptr M04_L08
       test      rbx,rbx
       je        near ptr M04_L09
       mov       r14,[rbp]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax+8]
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M04_L02
       test      r15,r15
       je        short M04_L01
       mov       r13d,[rdi+18]
       mov       r12,[rdi+20]
       mov       rax,[rdi+28]
       mov       [rsp+20],rax
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__89_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [r15+18],rcx
       jne       near ptr M04_L10
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       test      rax,rax
       je        short M04_L01
       cmp       byte ptr [rax+24],0
       jne       short M04_L01
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC135CEB68]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       r12,[rsp+20]
       mov       rcx,[r12+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFC135CEB68]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r12+24],1
M04_L01:
       mov       rcx,[rdi+8]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC135CE8E0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       rcx,[rdi+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC135CE8E0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       byte ptr [rdi+1C],1
M04_L02:
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
       je        short M04_L05
M04_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,rbp
M04_L04:
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
M04_L05:
       mov       rdx,7FFC136D8A10
       call      qword ptr [7FFC12EFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M04_L03
M04_L06:
       mov       ecx,577
       mov       rdx,7FFC1369F178
       call      qword ptr [7FFC13117798]
       mov       rcx,rax
       call      qword ptr [7FFC136F7DE0]
       int       3
M04_L07:
       jmp       short M04_L04
M04_L08:
       mov       ecx,4AB
       mov       rdx,7FFC1369F178
       call      qword ptr [7FFC13117798]
       mov       rcx,rax
       call      qword ptr [7FFC136F7DE0]
       int       3
M04_L09:
       mov       ecx,4B5
       mov       rdx,7FFC1369F178
       call      qword ptr [7FFC13117798]
       mov       rcx,rax
       call      qword ptr [7FFC136F7DE0]
       int       3
M04_L10:
       mov       [rsp+28],r13d
       mov       [rsp+30],r12
       mov       [rsp+38],rax
       lea       rdx,[rsp+28]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       jmp       near ptr M04_L01
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
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M06_L00:
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
       je        near ptr M06_L11
       mov       r13,rbx
       cmp       edi,[r13+18]
       jle       near ptr M06_L03
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFC135CEA18]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        short M06_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L12
       test      rdi,rdi
       je        short M06_L01
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M06_L01:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L23
       cmp       ecx,0FF
       ja        near ptr M06_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M06_L02:
       cmp       byte ptr [r14],0
       je        near ptr M06_L21
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M06_L22
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jl        near ptr M06_L06
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M06_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       js        near ptr M06_L09
       mov       rdx,r13
       call      qword ptr [7FFC135CEAC0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M06_L10
M06_L03:
       cmp       edi,[r13+18]
       jge       near ptr M06_L16
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFC135CEA18]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        near ptr M06_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L14
       test      rsi,rsi
       je        short M06_L04
       lea       rcx,[rbx+8]
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
       jo        near ptr M06_L23
       cmp       ecx,0FF
       ja        near ptr M06_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M06_L05:
       jmp       near ptr M06_L02
M06_L06:
       cmp       edx,0FFFFFFFE
       jle       short M06_L07
       mov       rax,r13
       jmp       short M06_L10
M06_L07:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M06_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M06_L08
       mov       rdx,r13
       call      qword ptr [7FFC135CEB08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M06_L10
M06_L08:
       mov       rdx,r13
       call      qword ptr [7FFC135CEAF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M06_L10
M06_L09:
       mov       rdx,r13
       call      qword ptr [7FFC135CEAD8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M06_L10:
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
M06_L11:
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
       jo        near ptr M06_L23
       cmp       eax,0FF
       ja        near ptr M06_L23
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
M06_L12:
       mov       r13d,[rbx+18]
       mov       r15,[rbx+20]
       mov       rsi,[rbx+28]
       mov       rbp,[rbx+8]
       test      rdi,rdi
       jne       short M06_L13
       mov       rdi,[rbx+10]
M06_L13:
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
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M06_L02
M06_L14:
       mov       r13d,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r15,[rbx+28]
       test      rsi,rsi
       jne       short M06_L15
       mov       rsi,[rbx+8]
M06_L15:
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
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M06_L05
M06_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M06_L17
       jmp       short M06_L18
M06_L17:
       mov       rdx,7FFC136D3288
       call      qword ptr [7FFC12EFC5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M06_L18:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rdx,[rsp+50]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M06_L19
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
M06_L19:
       cmp       byte ptr [rsp+0D0],0
       je        short M06_L20
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
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L02
M06_L20:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFC136F7DF8]
       mov       rsi,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFC136F7E10]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC13245F98]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M06_L21:
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
M06_L22:
       mov       ecx,869
       mov       rdx,7FFC1369F178
       call      qword ptr [7FFC13117798]
       mov       rcx,rax
       call      qword ptr [7FFC136F7DE0]
       int       3
M06_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1145
```
```assembly
; System.Collections.Immutable.Requires.NotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String)
       sub       rsp,28
       test      rdx,rdx
       je        short M07_L00
       add       rsp,28
       ret
M07_L00:
       mov       rcx,r8
       call      qword ptr [7FFC136F7DE0]
       int       3
; Total bytes of code 24
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
       je        near ptr M08_L02
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M08_L03
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M08_L04
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
       jo        near ptr M08_L06
       cmp       ecx,0FF
       ja        near ptr M08_L06
       mov       [rbx+1D],cl
M08_L00:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M08_L05
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
       jo        near ptr M08_L06
       cmp       ecx,0FF
       ja        near ptr M08_L06
       mov       [rsi+1D],cl
       mov       rax,rsi
M08_L01:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L02:
       mov       ecx,869
       mov       rdx,7FFC1369F178
       call      qword ptr [7FFC13117798]
       mov       rcx,rax
       call      qword ptr [7FFC136F7DE0]
       int       3
M08_L03:
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
M08_L04:
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
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M08_L00
M08_L05:
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
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M08_L01
M08_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 419
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M09_L00
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
M09_L00:
       mov       ecx,869
       mov       rdx,7FFC1369F178
       call      qword ptr [7FFC13117798]
       mov       rcx,rax
       call      qword ptr [7FFC136F7DE0]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M10_L00
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rdx+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       eax,ecx
       add       rsp,28
       ret
M10_L00:
       mov       ecx,869
       mov       rdx,7FFC1369F178
       call      qword ptr [7FFC13117798]
       mov       rcx,rax
       call      qword ptr [7FFC136F7DE0]
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
       je        near ptr M11_L14
       mov       rsi,[rbx+8]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M11_L08
       test      rsi,rsi
       je        near ptr M11_L14
       mov       rbp,[rsi+10]
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M11_L09
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M11_L10
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rdi+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M11_L18
       cmp       ecx,0FF
       ja        near ptr M11_L18
       mov       [rsi+1D],cl
M11_L00:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M11_L11
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
       jo        near ptr M11_L18
       cmp       ecx,0FF
       ja        near ptr M11_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M11_L01:
       mov       rsi,rdx
M11_L02:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M11_L12
       test      rsi,rsi
       je        short M11_L03
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M11_L03:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M11_L18
       cmp       ecx,0FF
       ja        near ptr M11_L18
       mov       [rbx+1D],cl
M11_L04:
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M11_L15
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M11_L16
       test      rbp,rbp
       je        short M11_L05
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M11_L05:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M11_L18
       cmp       ecx,0FF
       ja        near ptr M11_L18
       mov       [rbx+1D],cl
M11_L06:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M11_L17
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
       jo        near ptr M11_L18
       cmp       ecx,0FF
       ja        near ptr M11_L18
       mov       [rdi+1D],cl
       mov       rax,rdi
M11_L07:
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
M11_L08:
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
M11_L09:
       jmp       near ptr M11_L02
M11_L10:
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
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M11_L00
M11_L11:
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
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M11_L01
M11_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       test      rsi,rsi
       jne       short M11_L13
       mov       rsi,[rbx+8]
M11_L13:
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
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M11_L04
M11_L14:
       mov       ecx,869
       mov       rdx,7FFC1369F178
       call      qword ptr [7FFC13117798]
       mov       rcx,rax
       call      qword ptr [7FFC136F7DE0]
       int       3
M11_L15:
       mov       rax,rbx
       jmp       near ptr M11_L07
M11_L16:
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
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M11_L06
M11_L17:
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
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M11_L07
M11_L18:
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
       je        near ptr M12_L03
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M12_L04
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M12_L05
       test      rbp,rbp
       je        short M12_L00
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M12_L00:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M12_L07
       cmp       ecx,0FF
       ja        near ptr M12_L07
       mov       [rbx+1D],cl
M12_L01:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M12_L06
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
       jo        near ptr M12_L07
       cmp       ecx,0FF
       ja        near ptr M12_L07
       mov       [rdi+1D],cl
       mov       rax,rdi
M12_L02:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M12_L03:
       mov       ecx,869
       mov       rdx,7FFC1369F178
       call      qword ptr [7FFC13117798]
       mov       rcx,rax
       call      qword ptr [7FFC136F7DE0]
       int       3
M12_L04:
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
M12_L05:
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
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M12_L01
M12_L06:
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
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M12_L02
M12_L07:
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
       je        near ptr M13_L14
       mov       rsi,[rbx+10]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M13_L08
       test      rsi,rsi
       je        near ptr M13_L14
       cmp       qword ptr [rdi+8],0
       je        near ptr M13_L09
       mov       rbp,rdi
       mov       rdx,[rbp+10]
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M13_L10
       test      r14,r14
       je        short M13_L00
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M13_L00:
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M13_L18
       cmp       ecx,0FF
       ja        near ptr M13_L18
       mov       [rsi+1D],cl
M13_L01:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M13_L11
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
       jo        near ptr M13_L18
       cmp       ecx,0FF
       ja        near ptr M13_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M13_L02:
       mov       rsi,rdx
M13_L03:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M13_L12
       test      rsi,rsi
       je        short M13_L04
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M13_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M13_L18
       cmp       ecx,0FF
       ja        near ptr M13_L18
       mov       [rbx+1D],cl
M13_L05:
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M13_L15
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M13_L16
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
       jo        near ptr M13_L18
       cmp       ecx,0FF
       ja        near ptr M13_L18
       mov       [rbx+1D],cl
M13_L06:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M13_L17
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
       jo        near ptr M13_L18
       cmp       ecx,0FF
       ja        near ptr M13_L18
       mov       [rsi+1D],cl
       mov       rax,rsi
M13_L07:
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
M13_L08:
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
M13_L09:
       jmp       near ptr M13_L03
M13_L10:
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
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M13_L01
M13_L11:
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
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M13_L02
M13_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       mov       r15,[rbx+8]
       test      rsi,rsi
       jne       short M13_L13
       mov       rsi,[rbx+10]
M13_L13:
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
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M13_L05
M13_L14:
       mov       ecx,869
       mov       rdx,7FFC1369F178
       call      qword ptr [7FFC13117798]
       mov       rcx,rax
       call      qword ptr [7FFC136F7DE0]
       int       3
M13_L15:
       mov       rax,rbx
       jmp       near ptr M13_L07
M13_L16:
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
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M13_L06
M13_L17:
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
       call      qword ptr [7FFC135CEA30]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M13_L07
M13_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 943
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
       je        near ptr M14_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M14_L01
       test      rsi,rsi
       je        short M14_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M14_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M14_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12EF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12EF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M14_L00:
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
M14_L01:
       test      rsi,rsi
       je        short M14_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M14_L03
M14_L02:
       mov       rax,1D2EB060008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M14_L03:
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
M14_L04:
       call      qword ptr [7FFC136FCAC8]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M15_L00
       ret
M15_L00:
       jmp       qword ptr [7FFC12EF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       je        short M16_L00
       test      r14,r14
       je        near ptr M16_L01
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
       jo        short M16_L02
       cmp       ecx,0FF
       ja        short M16_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M16_L00:
       mov       ecx,847
       mov       rdx,7FFC1369F178
       call      qword ptr [7FFC13117798]
       mov       rcx,rax
       call      qword ptr [7FFC136F7DE0]
       int       3
M16_L01:
       mov       ecx,851
       mov       rdx,7FFC1369F178
       call      qword ptr [7FFC13117798]
       mov       rcx,rax
       call      qword ptr [7FFC136F7DE0]
       int       3
M16_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 215
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,158
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       vmovdqu   ymmword ptr [rsp+0F0],ymm4
       vmovdqu   ymmword ptr [rsp+110],ymm4
       vmovdqu   ymmword ptr [rsp+130],ymm4
       xor       eax,eax
       mov       [rsp+150],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L33
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L34
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rdi,rcx
       jne       near ptr M00_L35
       mov       eax,[rsi+28]
       sub       eax,[rsi+30]
M00_L00:
       test      eax,eax
       je        near ptr M00_L38
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r8,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rdi,r8
       jne       near ptr M00_L37
       xor       edi,edi
       mov       r14d,[rsi+28]
       sub       r14d,[rsi+30]
       js        near ptr M00_L36
       mov       r8d,[rbp+8]
       test      r8d,r8d
       jl        near ptr M00_L13
       cmp       r8d,r14d
       jl        near ptr M00_L13
       mov       r15,[rsi+10]
       xor       r13d,r13d
       cmp       dword ptr [rsi+28],0
       jle       short M00_L03
M00_L01:
       test      r14d,r14d
       je        short M00_L03
       cmp       r13d,[r15+8]
       jae       near ptr M00_L57
       mov       r8,r13
       shl       r8,4
       lea       r8,[r15+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M00_L02
       lea       edx,[rdi+1]
       mov       r12d,edx
       mov       r8,[r8]
       movsxd    rdx,edi
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r14d
       mov       edi,r12d
M00_L02:
       inc       r13d
       cmp       r13d,[rsi+28]
       jl        short M00_L01
M00_L03:
       test      rbp,rbp
       je        near ptr M00_L39
       lea       rsi,[rbp+10]
       mov       edi,[rbp+8]
M00_L04:
       mov       rcx,2BFE6800A48
       mov       rbp,[rcx]
       mov       r14,[rbp+10]
       mov       r15,[rbp+8]
       mov       r13,[rbp+18]
       xor       r12d,r12d
       xor       eax,eax
       inc       edi
       jmp       near ptr M00_L12
M00_L05:
       mov       ecx,eax
       jmp       near ptr M00_L27
M00_L06:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r8,rcx
       mov       [rsp+0C8],r8
       mov       rcx,r8
       call      qword ptr [7FFC136D6388]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jne       short M00_L07
       mov       rax,r14
       jmp       short M00_L10
M00_L07:
       mov       rdx,[r14+8]
       mov       rcx,[rsp+0C8]
       call      qword ptr [7FFC136D6370]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jle       short M00_L08
       mov       rdx,r14
       mov       rcx,[rsp+0C8]
       call      qword ptr [7FFC136D63A0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M00_L10
M00_L08:
       mov       rdx,r14
       mov       rcx,[rsp+0C8]
       call      qword ptr [7FFC136D63D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M00_L10
M00_L09:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r14,rcx
       call      qword ptr [7FFC136D63E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M00_L10:
       mov       r14,rax
       inc       r12d
M00_L11:
       mov       rax,[rsp+0C0]
       add       rax,8
M00_L12:
       dec       edi
       jne       near ptr M00_L14
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+130],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+130]
       mov       r9d,r12d
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFC136DF5B8]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rsp+130]
       vmovdqu   xmmword ptr [rsp+148],xmm0
       lea       rcx,[rsp+148]
       mov       r8,rbp
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFC136DF5D0]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableHashSet`1<System.__Canon>)
       mov       [rsp+0F0],rax
       mov       rcx,[rbx+90]
       lea       r8,[rsp+0F0]
       mov       rdx,7FFC13725050
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D6460]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,158
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L13:
       mov       ecx,6
       call      qword ptr [7FFC136DF2A0]
       int       3
M00_L14:
       mov       [rsp+0C0],rax
       mov       r8,[rsi+rax]
       mov       [rsp+0B8],r8
       test      r8,r8
       je        short M00_L15
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FFC12E60C30
       call      qword ptr [r11]
       mov       r10d,eax
       mov       r8,[rsp+0B8]
       jmp       short M00_L16
M00_L15:
       xor       ecx,ecx
       xor       r10d,r10d
M00_L16:
       mov       [rsp+144],r10d
       cmp       [r14],r14b
       mov       rcx,r14
       cmp       qword ptr [r14+8],0
       jne       near ptr M00_L32
M00_L17:
       xor       r9d,r9d
       xor       r11d,r11d
M00_L18:
       mov       [rsp+68],r11
       test      r11,r11
       jne       near ptr M00_L41
       xor       edx,edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+110],xmm0
       mov       [rsp+110],r8
       mov       rcx,2BFE6800A70
       mov       rcx,[rcx]
       mov       [rsp+118],rcx
       mov       rcx,[rsp+110]
       mov       r11,[rsp+118]
M00_L19:
       test      edx,edx
       jne       near ptr M00_L11
       test      r11,r11
       je        near ptr M00_L45
       test      r13,r13
       je        near ptr M00_L55
       xor       r8d,r8d
       mov       [rsp+108],r8d
       mov       r8,[r14+8]
       test      r8,r8
       je        near ptr M00_L29
       mov       r9,r14
       mov       [rsp+0B0],r9
       mov       edx,[r9+18]
       mov       r10d,[rsp+144]
       cmp       r10d,edx
       jg        near ptr M00_L25
       cmp       r10d,edx
       jge       near ptr M00_L52
       mov       [rsp+0E0],rcx
       mov       [rsp+0E8],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+108]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+100]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+0E0]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D62F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+100],0
       je        near ptr M00_L51
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L49
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
       jl        near ptr M00_L24
M00_L21:
       add       ecx,1
       jo        near ptr M00_L58
       cmp       ecx,0FF
       ja        near ptr M00_L58
       mov       [r14+1D],cl
       mov       r9,r14
M00_L22:
       mov       r14,r9
M00_L23:
       cmp       byte ptr [rsp+100],0
       je        near ptr M00_L54
       test      r14,r14
       je        near ptr M00_L56
       mov       rax,[r14+10]
       movzx     edx,byte ptr [rax+1D]
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       edx,ecx
       cmp       edx,2
       jl        near ptr M00_L06
       mov       [rsp+78],rax
       mov       rdx,rax
       mov       rcx,7FFC137C70E0
       mov       r8,30065611A18
       call      qword ptr [7FFC136D6190]; System.Collections.Immutable.Requires.NotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String)
       mov       rdx,[rsp+78]
       mov       rcx,[rdx+10]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       ecx,edx
       js        near ptr M00_L09
       mov       rdx,r14
       mov       r14,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,r14
       call      qword ptr [7FFC136D63B8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M00_L10
M00_L24:
       mov       ecx,eax
       jmp       near ptr M00_L21
M00_L25:
       mov       r9,[rsp+0B0]
       mov       r8,[r9+10]
       mov       [rsp+0E0],rcx
       mov       [rsp+0E8],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+108]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+100]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+0E0]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D62F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+100],0
       je        near ptr M00_L48
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L46
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
       jl        near ptr M00_L05
M00_L27:
       add       ecx,1
       jo        near ptr M00_L58
       cmp       ecx,0FF
       ja        near ptr M00_L58
       mov       [r14+1D],cl
       mov       r9,r14
M00_L28:
       mov       r14,r9
       jmp       near ptr M00_L23
M00_L29:
       mov       [rsp+58],r11
       mov       [rsp+60],rcx
       mov       dword ptr [rsp+100],1
       mov       rdx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A0],rax
       mov       r8d,[rsp+144]
       mov       [rax+18],r8d
       lea       rcx,[rax+20]
       mov       rdx,[rsp+60]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       lea       rcx,[rax+28]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       mov       byte ptr [rax+1C],0
       movzx     r8d,byte ptr [r14+1D]
       add       r8d,1
       jo        near ptr M00_L58
       cmp       r8d,0FF
       ja        near ptr M00_L58
       mov       [rax+1D],r8b
       jmp       near ptr M00_L10
M00_L30:
       mov       rcx,[rcx+8]
M00_L31:
       cmp       qword ptr [rcx+8],0
       je        near ptr M00_L17
       mov       r10d,[rsp+144]
M00_L32:
       mov       edx,[rcx+18]
       cmp       r10d,edx
       je        near ptr M00_L40
       jle       short M00_L30
       mov       rcx,[rcx+10]
       jmp       short M00_L31
M00_L33:
       call      qword ptr [7FFC134BEFA0]
       mov       ecx,65
       mov       rdx,7FFC13330598
       call      qword ptr [7FFC13137798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13330598
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136DF858]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136DE760]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rbp,rax
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,rsi
       mov       r11,7FFC12E60C20
       call      qword ptr [r11]
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,28F
       mov       rdx,7FFC12E54000
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFC136DD278]
       int       3
M00_L37:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFC12E60C28
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L38:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2BFE6800B00
       mov       rbp,[rcx]
       jmp       near ptr M00_L03
M00_L39:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L04
M00_L40:
       mov       r9,[rcx+20]
       mov       r11,[rcx+28]
       jmp       near ptr M00_L18
M00_L41:
       mov       rcx,r15
       mov       [rsp+70],r9
       mov       r8,r9
       mov       rdx,[rsp+0B8]
       mov       r11,7FFC12E60C38
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L42
       mov       [rsp+20],r15
       mov       r11,[rsp+68]
       mov       r9d,[r11+20]
       mov       [rsp+68],r11
       mov       rcx,r11
       mov       rdx,[rsp+0B8]
       xor       r8d,r8d
       call      qword ptr [7FFC136DF3A8]
       test      eax,eax
       jl        short M00_L43
M00_L42:
       mov       ecx,1
       mov       rax,[rsp+70]
       mov       r10,[rsp+68]
       mov       edx,ecx
       mov       rcx,rax
       mov       r11,r10
       jmp       near ptr M00_L19
M00_L43:
       xor       edx,edx
       mov       [rsp+140],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+120],xmm0
       mov       rcx,[rsp+68]
       mov       rdx,[rsp+0B8]
       call      qword ptr [7FFC136DF3C0]
       mov       rcx,[rsp+70]
       mov       [rsp+120],rcx
       test      rax,rax
       jne       short M00_L44
       mov       rax,2BFE6800A70
       mov       rax,[rax]
M00_L44:
       mov       [rsp+128],rax
       mov       rcx,[rsp+120]
       mov       rax,rcx
       mov       r11,[rsp+128]
       mov       r10,r11
       mov       rcx,rax
       mov       r11,r10
       mov       edx,[rsp+140]
       jmp       near ptr M00_L19
M00_L45:
       mov       r10d,[rsp+144]
       lea       r8,[rsp+108]
       mov       rcx,r14
       mov       edx,r10d
       call      qword ptr [7FFC136DF5A0]
       jmp       near ptr M00_L10
M00_L46:
       mov       edx,[r14+18]
       mov       [rsp+0FC],edx
       mov       r8,[r14+20]
       mov       [rsp+50],r8
       mov       r10,[r14+28]
       mov       [rsp+48],r10
       mov       r9,[r14+8]
       mov       [rsp+98],r9
       test      rax,rax
       mov       [rsp+90],rax
       jne       short M00_L47
       mov       rax,[r14+10]
       mov       [rsp+90],rax
M00_L47:
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r14,rcx
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rsp+50]
       mov       [rsp+0E0],r8
       mov       r8,[rsp+48]
       mov       [rsp+0E8],r8
       mov       r8,[rsp+90]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0E0]
       mov       edx,[rsp+0FC]
       mov       rcx,r14
       mov       r9,[rsp+98]
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r9,r14
       jmp       near ptr M00_L28
M00_L48:
       mov       r14,[rsp+0B0]
       jmp       near ptr M00_L23
M00_L49:
       mov       edx,[r14+18]
       mov       [rsp+0F8],edx
       mov       r8,[r14+20]
       mov       [rsp+40],r8
       mov       r10,[r14+28]
       mov       [rsp+38],r10
       test      rax,rax
       mov       [rsp+88],rax
       jne       short M00_L50
       mov       rax,[r14+8]
       mov       [rsp+88],rax
M00_L50:
       mov       r14,[r14+10]
       mov       r11,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,r11
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rsp+80],r9
       mov       r8,[rsp+40]
       mov       [rsp+0E0],r8
       mov       r8,[rsp+38]
       mov       [rsp+0E8],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0E0]
       mov       edx,[rsp+0F8]
       mov       rcx,r9
       mov       r9,[rsp+88]
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+80]
       mov       r9,r14
       jmp       near ptr M00_L22
M00_L51:
       mov       r14,[rsp+0B0]
       jmp       near ptr M00_L23
M00_L52:
       vmovdqu   xmm0,xmmword ptr [r14+20]
       vmovdqu   xmmword ptr [rsp+0E0],xmm0
       mov       [rsp+60],rcx
       mov       [rsp+0D0],rcx
       mov       [rsp+58],r11
       mov       [rsp+0D8],r11
       lea       r8,[rsp+0D0]
       lea       rdx,[rsp+0E0]
       mov       rcx,r13
       mov       r11,7FFC12E60C40
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L53
       xor       ecx,ecx
       mov       [rsp+100],ecx
       mov       rax,r14
       jmp       near ptr M00_L10
M00_L53:
       mov       dword ptr [rsp+100],1
       mov       dword ptr [rsp+108],1
       mov       r11,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rax,r11
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A8],rax
       mov       r10,[rsp+60]
       mov       [rsp+0E0],r10
       mov       r11,[rsp+58]
       mov       [rsp+0E8],r11
       mov       r8,[r14+10]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0E0]
       mov       r9,[r14+8]
       mov       edx,[rsp+144]
       mov       rcx,rax
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0A8]
       jmp       near ptr M00_L23
M00_L54:
       mov       rax,r14
       jmp       near ptr M00_L10
M00_L55:
       mov       ecx,511
       mov       rdx,7FFC13702DF8
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC136DF348]
       int       3
M00_L56:
       mov       ecx,869
       mov       rdx,7FFC13702DF8
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC136DF348]
       int       3
M00_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2935
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
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       jne       short M02_L03
M02_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFC72BA40D0
M02_L01:
       call      qword ptr [7FFC136DC6A8]
       int       3
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M02_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFC12F1D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
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
       mov       rdx,7FFC13702DF8
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC136DF348]
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
       mov       rdx,7FFC13702DF8
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC136DF348]
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
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M05_L04
M05_L14:
       mov       ecx,869
       mov       rdx,7FFC13702DF8
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC136DF348]
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
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
       mov       rdx,7FFC13702DF8
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC136DF348]
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
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M07_L05
M07_L14:
       mov       ecx,869
       mov       rdx,7FFC13702DF8
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC136DF348]
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
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M07_L07
M07_L18:
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
       je        short M08_L00
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
M08_L00:
       mov       ecx,4AB
       mov       rdx,7FFC13702DF8
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC136DF348]
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
       je        near ptr M09_L06
       mov       esi,[rcx+8]
       cmp       dword ptr [rcx+0C],0
       jne       short M09_L00
       add       esi,[rbx+20]
M09_L00:
       mov       rdi,[rcx]
       cmp       rdi,[rbx+10]
       je        near ptr M09_L07
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rbx,[rbx+8]
       test      rdi,rdi
       je        near ptr M09_L08
       test      rbx,rbx
       je        near ptr M09_L09
       mov       r14,[rbp]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax+8]
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M09_L02
       test      r15,r15
       je        short M09_L01
       mov       r13d,[rdi+18]
       mov       r12,[rdi+20]
       mov       rax,[rdi+28]
       mov       [rsp+20],rax
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__89_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [r15+18],rcx
       jne       near ptr M09_L10
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       test      rax,rax
       je        short M09_L01
       cmp       byte ptr [rax+24],0
       jne       short M09_L01
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D6448]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       r12,[rsp+20]
       mov       rcx,[r12+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D6448]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r12+24],1
M09_L01:
       mov       rcx,[rdi+8]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D61C0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       rcx,[rdi+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D61C0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       byte ptr [rdi+1C],1
M09_L02:
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
       je        short M09_L05
M09_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,rbp
M09_L04:
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
M09_L05:
       mov       rdx,7FFC137B4718
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M09_L03
M09_L06:
       mov       ecx,577
       mov       rdx,7FFC13702DF8
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC136DF348]
       int       3
M09_L07:
       jmp       short M09_L04
M09_L08:
       mov       ecx,4AB
       mov       rdx,7FFC13702DF8
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC136DF348]
       int       3
M09_L09:
       mov       ecx,4B5
       mov       rdx,7FFC13702DF8
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC136DF348]
       int       3
M09_L10:
       mov       [rsp+28],r13d
       mov       [rsp+30],r12
       mov       [rsp+38],rax
       lea       rdx,[rsp+28]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       jmp       near ptr M09_L01
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
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M11_L00:
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
       je        near ptr M11_L11
       mov       r13,rbx
       cmp       edi,[r13+18]
       jg        near ptr M11_L03
       cmp       edi,[r13+18]
       jge       near ptr M11_L16
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D62F8]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        short M11_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M11_L14
       test      rsi,rsi
       je        short M11_L01
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M11_L01:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M11_L23
       cmp       ecx,0FF
       ja        near ptr M11_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M11_L02:
       cmp       byte ptr [r14],0
       je        near ptr M11_L21
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M11_L22
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jl        near ptr M11_L06
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M11_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       js        near ptr M11_L09
       mov       rdx,r13
       call      qword ptr [7FFC136D63B8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M11_L10
M11_L03:
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D62F8]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        near ptr M11_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M11_L12
       test      rdi,rdi
       je        short M11_L04
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M11_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M11_L23
       cmp       ecx,0FF
       ja        near ptr M11_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M11_L05:
       jmp       near ptr M11_L02
M11_L06:
       cmp       edx,0FFFFFFFE
       jle       short M11_L07
       mov       rax,r13
       jmp       short M11_L10
M11_L07:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M11_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M11_L08
       mov       rdx,r13
       call      qword ptr [7FFC136D63A0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M11_L10
M11_L08:
       mov       rdx,r13
       call      qword ptr [7FFC136D63D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M11_L10
M11_L09:
       mov       rdx,r13
       call      qword ptr [7FFC136D63E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M11_L10:
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
M11_L11:
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
       jo        near ptr M11_L23
       cmp       eax,0FF
       ja        near ptr M11_L23
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
M11_L12:
       mov       r13d,[rbx+18]
       mov       rsi,[rbx+20]
       mov       rbp,[rbx+28]
       mov       r15,[rbx+8]
       test      rdi,rdi
       jne       short M11_L13
       mov       rdi,[rbx+10]
M11_L13:
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
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M11_L05
M11_L14:
       mov       r13d,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r15,[rbx+28]
       test      rsi,rsi
       jne       short M11_L15
       mov       rsi,[rbx+8]
M11_L15:
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
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M11_L02
M11_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M11_L17
       jmp       short M11_L18
M11_L17:
       mov       rdx,7FFC1378FC10
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M11_L18:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rdx,[rsp+50]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M11_L19
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
M11_L19:
       cmp       byte ptr [rsp+0D0],0
       je        short M11_L20
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
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M11_L02
M11_L20:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFC136DF360]
       mov       r15,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFC136DF378]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFC13265F98]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M11_L21:
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
M11_L22:
       mov       ecx,869
       mov       rdx,7FFC13702DF8
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC136DF348]
       int       3
M11_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1145
```
```assembly
; System.Collections.Immutable.Requires.NotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String)
       sub       rsp,28
       test      rdx,rdx
       je        short M12_L00
       add       rsp,28
       ret
M12_L00:
       mov       rcx,r8
       call      qword ptr [7FFC136DF348]
       int       3
; Total bytes of code 24
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
       je        near ptr M13_L02
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M13_L03
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M13_L04
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
       jo        near ptr M13_L06
       cmp       ecx,0FF
       ja        near ptr M13_L06
       mov       [rbx+1D],cl
M13_L00:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M13_L05
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
       jo        near ptr M13_L06
       cmp       ecx,0FF
       ja        near ptr M13_L06
       mov       [rsi+1D],cl
       mov       rax,rsi
M13_L01:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M13_L02:
       mov       ecx,869
       mov       rdx,7FFC13702DF8
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC136DF348]
       int       3
M13_L03:
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
M13_L04:
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
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M13_L00
M13_L05:
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
       call      qword ptr [7FFC136D6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M13_L01
M13_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 419
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
       je        near ptr M14_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M14_L01
       test      rsi,rsi
       je        short M14_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M14_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M14_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M14_L00:
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
M14_L01:
       test      rsi,rsi
       je        short M14_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M14_L03
M14_L02:
       mov       rax,30065600008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M14_L03:
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
M14_L04:
       call      qword ptr [7FFC136DED48]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M15_L00
       ret
M15_L00:
       jmp       qword ptr [7FFC12F15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       je        short M16_L00
       test      r14,r14
       je        near ptr M16_L01
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
       jo        short M16_L02
       cmp       ecx,0FF
       ja        short M16_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M16_L00:
       mov       ecx,847
       mov       rdx,7FFC13702DF8
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC136DF348]
       int       3
M16_L01:
       mov       ecx,851
       mov       rdx,7FFC13702DF8
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC136DF348]
       int       3
M16_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 215
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,158
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       vmovdqu   ymmword ptr [rsp+0F0],ymm4
       vmovdqu   ymmword ptr [rsp+110],ymm4
       vmovdqu   ymmword ptr [rsp+130],ymm4
       xor       eax,eax
       mov       [rsp+150],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L33
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC12F06850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L34
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rdi,rcx
       jne       near ptr M00_L35
       mov       eax,[rsi+28]
       sub       eax,[rsi+30]
M00_L00:
       test      eax,eax
       je        near ptr M00_L38
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r8,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rdi,r8
       jne       near ptr M00_L37
       xor       edi,edi
       mov       r14d,[rsi+28]
       sub       r14d,[rsi+30]
       js        near ptr M00_L36
       mov       r8d,[rbp+8]
       test      r8d,r8d
       jl        near ptr M00_L28
       cmp       r8d,r14d
       jl        near ptr M00_L28
       mov       r15,[rsi+10]
       xor       r13d,r13d
       cmp       dword ptr [rsi+28],0
       jle       short M00_L03
M00_L01:
       test      r14d,r14d
       je        short M00_L03
       cmp       r13d,[r15+8]
       jae       near ptr M00_L55
       mov       r8,r13
       shl       r8,4
       lea       r8,[r15+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M00_L02
       lea       edx,[rdi+1]
       mov       r12d,edx
       mov       r8,[r8]
       movsxd    rdx,edi
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r14d
       mov       edi,r12d
M00_L02:
       inc       r13d
       cmp       r13d,[rsi+28]
       jl        short M00_L01
M00_L03:
       test      rbp,rbp
       je        near ptr M00_L39
       lea       rsi,[rbp+10]
       mov       edi,[rbp+8]
M00_L04:
       mov       rcx,2BAD6C00A30
       mov       rbp,[rcx]
       mov       r14,[rbp+10]
       mov       r15,[rbp+8]
       mov       r13,[rbp+18]
       xor       r12d,r12d
       xor       eax,eax
       inc       edi
       jmp       near ptr M00_L27
M00_L05:
       mov       [rsp+0C0],rax
       mov       r8,[rsi+rax]
       mov       [rsp+0B8],r8
       test      r8,r8
       je        short M00_L06
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FFC12E50B30
       call      qword ptr [r11]
       mov       r10d,eax
       mov       r8,[rsp+0B8]
       jmp       short M00_L07
M00_L06:
       xor       ecx,ecx
       xor       r10d,r10d
M00_L07:
       mov       [rsp+144],r10d
       cmp       [r14],r14b
       mov       rcx,r14
       cmp       qword ptr [r14+8],0
       jne       near ptr M00_L32
M00_L08:
       xor       r9d,r9d
       xor       r11d,r11d
M00_L09:
       mov       [rsp+68],r11
       test      r11,r11
       jne       near ptr M00_L41
       xor       edx,edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+110],xmm0
       mov       [rsp+110],r8
       mov       rcx,2BAD6C00A58
       mov       rcx,[rcx]
       mov       [rsp+118],rcx
       mov       rcx,[rsp+110]
       mov       r11,[rsp+118]
M00_L10:
       test      edx,edx
       jne       near ptr M00_L26
       test      r11,r11
       je        near ptr M00_L45
       test      r13,r13
       je        near ptr M00_L53
       xor       r8d,r8d
       mov       [rsp+108],r8d
       mov       r9,[r14+8]
       test      r9,r9
       je        near ptr M00_L29
       mov       rdx,r14
       mov       r8d,[rdx+18]
       mov       r10d,[rsp+144]
       cmp       r10d,r8d
       jle       near ptr M00_L16
       mov       [rsp+0B0],rdx
       mov       r8,[rdx+10]
       mov       [rsp+0E0],rcx
       mov       [rsp+0E8],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+108]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+100]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+0E0]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC135DEB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+100],0
       je        short M00_L14
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L46
       test      rax,rax
       je        short M00_L11
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L11:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L15
M00_L12:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+1D],cl
       mov       rdx,r14
M00_L13:
       mov       [rsp+0B0],rdx
M00_L14:
       cmp       byte ptr [rsp+100],0
       je        near ptr M00_L52
       mov       r14,[rsp+0B0]
       test      r14,r14
       je        near ptr M00_L54
       mov       rax,[r14+10]
       movzx     edx,byte ptr [rax+1D]
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       edx,ecx
       cmp       edx,2
       jl        near ptr M00_L21
       mov       [rsp+78],rax
       mov       rdx,rax
       mov       rcx,7FFC13741158
       mov       r8,2FB55C91A18
       call      qword ptr [7FFC135DE9B8]; System.Collections.Immutable.Requires.NotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String)
       mov       rdx,[rsp+78]
       mov       rcx,[rdx+10]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       ecx,edx
       js        near ptr M00_L24
       mov       rdx,r14
       mov       r14,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,r14
       call      qword ptr [7FFC135DEBF8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       near ptr M00_L25
M00_L15:
       mov       ecx,eax
       jmp       near ptr M00_L12
M00_L16:
       cmp       r10d,r8d
       jge       near ptr M00_L50
       mov       [rsp+0B0],rdx
       mov       [rsp+0E0],rcx
       mov       [rsp+0E8],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+108]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+100]
       mov       [rsp+30],rcx
       mov       rcx,r9
       lea       r8,[rsp+0E0]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC135DEB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+100],0
       je        near ptr M00_L14
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L48
       test      rax,rax
       je        short M00_L17
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L17:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        short M00_L20
M00_L18:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+1D],cl
       mov       rdx,r14
M00_L19:
       mov       r14,rdx
       mov       [rsp+0B0],r14
       jmp       near ptr M00_L14
M00_L20:
       mov       ecx,eax
       jmp       short M00_L18
M00_L21:
       mov       rdx,r14
       mov       rax,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       [rsp+0C8],rax
       mov       rcx,rax
       call      qword ptr [7FFC135DEBB0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jne       short M00_L22
       jmp       short M00_L25
M00_L22:
       mov       rdx,[r14+8]
       mov       rcx,[rsp+0C8]
       call      qword ptr [7FFC135DEB98]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jle       short M00_L23
       mov       rdx,r14
       mov       rcx,[rsp+0C8]
       call      qword ptr [7FFC135DEC10]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       short M00_L25
M00_L23:
       mov       rdx,r14
       mov       rcx,[rsp+0C8]
       call      qword ptr [7FFC135DEBE0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       short M00_L25
M00_L24:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r14,rcx
       call      qword ptr [7FFC135DEBC8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
M00_L25:
       inc       r12d
M00_L26:
       mov       rax,[rsp+0C0]
       add       rax,8
M00_L27:
       dec       edi
       jne       near ptr M00_L05
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+130],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+130]
       mov       r9d,r12d
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFC1370C300]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rsp+130]
       vmovdqu   xmmword ptr [rsp+148],xmm0
       lea       rcx,[rsp+148]
       mov       r8,rbp
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFC1370C318]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableHashSet`1<System.__Canon>)
       mov       [rsp+0F0],rax
       mov       rcx,[rbx+90]
       lea       r8,[rsp+0F0]
       mov       rdx,7FFC136D1DD0
       cmp       [rcx],ecx
       call      qword ptr [7FFC135DEC88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,158
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L28:
       mov       ecx,6
       call      qword ptr [7FFC1370C180]
       int       3
M00_L29:
       mov       [rsp+58],r11
       mov       [rsp+60],rcx
       mov       dword ptr [rsp+100],1
       mov       rdx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A0],rax
       mov       r8d,[rsp+144]
       mov       [rax+18],r8d
       lea       rcx,[rax+20]
       mov       rdx,[rsp+60]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       lea       rcx,[rax+28]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsp+0A0]
       mov       byte ptr [r8+1C],0
       movzx     ecx,byte ptr [r14+1D]
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r8+1D],cl
       mov       r14,r8
       jmp       near ptr M00_L25
M00_L30:
       mov       rcx,[rcx+10]
M00_L31:
       cmp       qword ptr [rcx+8],0
       je        near ptr M00_L08
       mov       r10d,[rsp+144]
M00_L32:
       mov       edx,[rcx+18]
       cmp       r10d,edx
       je        near ptr M00_L40
       jg        short M00_L30
       mov       rcx,[rcx+8]
       jmp       short M00_L31
M00_L33:
       call      qword ptr [7FFC134A7738]
       mov       ecx,65
       mov       rdx,7FFC13320598
       call      qword ptr [7FFC13127798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131D4F28
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13320598
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC1370C528]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC1370C540]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rbp,rax
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,rsi
       mov       r11,7FFC12E50B20
       call      qword ptr [r11]
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,28F
       mov       rdx,7FFC12E44000
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFC1370C150]
       int       3
M00_L37:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFC12E50B28
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L38:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2BAD6C00A80
       mov       rbp,[rcx]
       jmp       near ptr M00_L03
M00_L39:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L04
M00_L40:
       mov       r9,[rcx+20]
       mov       r11,[rcx+28]
       jmp       near ptr M00_L09
M00_L41:
       mov       rcx,r15
       mov       [rsp+70],r9
       mov       r8,r9
       mov       rdx,[rsp+0B8]
       mov       r11,7FFC12E50B38
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L42
       mov       [rsp+20],r15
       mov       r11,[rsp+68]
       mov       r9d,[r11+20]
       mov       [rsp+68],r11
       mov       rcx,r11
       mov       rdx,[rsp+0B8]
       xor       r8d,r8d
       call      qword ptr [7FFC13707F90]
       test      eax,eax
       jl        short M00_L43
M00_L42:
       mov       ecx,1
       mov       rax,[rsp+70]
       mov       r10,[rsp+68]
       mov       edx,ecx
       mov       rcx,rax
       mov       r11,r10
       jmp       near ptr M00_L10
M00_L43:
       xor       edx,edx
       mov       [rsp+140],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+120],xmm0
       mov       rcx,[rsp+68]
       mov       rdx,[rsp+0B8]
       call      qword ptr [7FFC13707FA8]
       mov       rcx,[rsp+70]
       mov       [rsp+120],rcx
       test      rax,rax
       jne       short M00_L44
       mov       rax,2BAD6C00A58
       mov       rax,[rax]
M00_L44:
       mov       [rsp+128],rax
       mov       rcx,[rsp+120]
       mov       rax,rcx
       mov       r11,[rsp+128]
       mov       r10,r11
       mov       rcx,rax
       mov       r11,r10
       mov       edx,[rsp+140]
       jmp       near ptr M00_L10
M00_L45:
       mov       r10d,[rsp+144]
       lea       r8,[rsp+108]
       mov       rcx,r14
       mov       edx,r10d
       call      qword ptr [7FFC1370C2E8]
       mov       r14,rax
       jmp       near ptr M00_L25
M00_L46:
       mov       edx,[r14+18]
       mov       [rsp+0FC],edx
       mov       r8,[r14+20]
       mov       [rsp+50],r8
       mov       r10,[r14+28]
       mov       [rsp+48],r10
       mov       r9,[r14+8]
       mov       [rsp+98],r9
       test      rax,rax
       mov       [rsp+90],rax
       jne       short M00_L47
       mov       rax,[r14+10]
       mov       [rsp+90],rax
M00_L47:
       mov       r14,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rsp+50]
       mov       [rsp+0E0],r8
       mov       r8,[rsp+48]
       mov       [rsp+0E8],r8
       mov       r8,[rsp+90]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0E0]
       mov       edx,[rsp+0FC]
       mov       rcx,r14
       mov       r9,[rsp+98]
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,r14
       jmp       near ptr M00_L13
M00_L48:
       mov       edx,[r14+18]
       mov       [rsp+0F8],edx
       mov       r8,[r14+20]
       mov       [rsp+40],r8
       mov       r10,[r14+28]
       mov       [rsp+38],r10
       test      rax,rax
       mov       [rsp+88],rax
       jne       short M00_L49
       mov       rax,[r14+8]
       mov       [rsp+88],rax
M00_L49:
       mov       r14,[r14+10]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r9,rcx
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+80],rax
       mov       r8,[rsp+40]
       mov       [rsp+0E0],r8
       mov       r8,[rsp+38]
       mov       [rsp+0E8],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0E0]
       mov       edx,[rsp+0F8]
       mov       rcx,[rsp+80]
       mov       r9,[rsp+88]
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+80]
       mov       rdx,r14
       jmp       near ptr M00_L19
M00_L50:
       vmovdqu   xmm0,xmmword ptr [r14+20]
       vmovdqu   xmmword ptr [rsp+0E0],xmm0
       mov       [rsp+60],rcx
       mov       [rsp+0D0],rcx
       mov       [rsp+58],r11
       mov       [rsp+0D8],r11
       lea       r8,[rsp+0D0]
       lea       rdx,[rsp+0E0]
       mov       rcx,r13
       mov       r11,7FFC12E50B40
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L51
       xor       ecx,ecx
       mov       [rsp+100],ecx
       jmp       near ptr M00_L25
M00_L51:
       mov       dword ptr [rsp+100],1
       mov       dword ptr [rsp+108],1
       mov       r9,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rax,r9
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A8],rax
       mov       r10,[rsp+60]
       mov       [rsp+0E0],r10
       mov       r11,[rsp+58]
       mov       [rsp+0E8],r11
       mov       r8,[r14+10]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0E0]
       mov       r9,[r14+8]
       mov       edx,[rsp+144]
       mov       rcx,rax
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0A8]
       mov       [rsp+0B0],r14
       jmp       near ptr M00_L14
M00_L52:
       mov       r14,[rsp+0B0]
       jmp       near ptr M00_L25
M00_L53:
       mov       ecx,511
       mov       rdx,7FFC1369F730
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13707EB8]
       int       3
M00_L54:
       mov       ecx,869
       mov       rdx,7FFC1369F730
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13707EB8]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2940
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
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       jne       short M02_L03
M02_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFC72BA40D0
M02_L01:
       call      qword ptr [7FFC13707E70]
       int       3
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M02_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFC12F0D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M03_L00:
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
       je        near ptr M03_L11
       mov       r13,rbx
       cmp       edi,[r13+18]
       jle       near ptr M03_L03
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFC135DEB20]
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
       call      qword ptr [7FFC135DEBF8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M03_L10
M03_L03:
       cmp       edi,[r13+18]
       jge       near ptr M03_L16
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFC135DEB20]
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
       call      qword ptr [7FFC135DEC10]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M03_L10
M03_L08:
       mov       rdx,r13
       call      qword ptr [7FFC135DEBE0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M03_L10
M03_L09:
       mov       rdx,r13
       call      qword ptr [7FFC135DEBC8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M03_L10:
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
M03_L11:
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
       jo        near ptr M03_L23
       cmp       eax,0FF
       ja        near ptr M03_L23
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
M03_L12:
       mov       r13d,[rbx+18]
       mov       r15,[rbx+20]
       mov       rsi,[rbx+28]
       mov       rbp,[rbx+8]
       test      rdi,rdi
       jne       short M03_L13
       mov       rdi,[rbx+10]
M03_L13:
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
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M03_L02
M03_L14:
       mov       r13d,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r15,[rbx+28]
       test      rsi,rsi
       jne       short M03_L15
       mov       rsi,[rbx+8]
M03_L15:
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
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
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
       mov       rdx,7FFC136E35E8
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L18:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rdx,[rsp+50]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L19
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
M03_L19:
       cmp       byte ptr [rsp+0D0],0
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
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M03_L02
M03_L20:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFC13707ED0]
       mov       rsi,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFC13707EE8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC13255F98]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L21:
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
M03_L22:
       mov       ecx,869
       mov       rdx,7FFC1369F730
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13707EB8]
       int       3
M03_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1145
```
```assembly
; System.Collections.Immutable.Requires.NotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String)
       sub       rsp,28
       test      rdx,rdx
       je        short M04_L00
       add       rsp,28
       ret
M04_L00:
       mov       rcx,r8
       call      qword ptr [7FFC13707EB8]
       int       3
; Total bytes of code 24
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
       mov       rdx,7FFC1369F730
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13707EB8]
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
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M05_L01
M05_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 419
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M06_L00
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
M06_L00:
       mov       ecx,869
       mov       rdx,7FFC1369F730
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13707EB8]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M07_L00
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rdx+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       eax,ecx
       add       rsp,28
       ret
M07_L00:
       mov       ecx,869
       mov       rdx,7FFC1369F730
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13707EB8]
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
       je        near ptr M08_L14
       mov       rsi,[rbx+8]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M08_L08
       test      rsi,rsi
       je        near ptr M08_L14
       mov       rbp,[rsi+10]
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M08_L09
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M08_L10
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rdi+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M08_L18
       cmp       ecx,0FF
       ja        near ptr M08_L18
       mov       [rsi+1D],cl
M08_L00:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M08_L11
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
       jo        near ptr M08_L18
       cmp       ecx,0FF
       ja        near ptr M08_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M08_L01:
       mov       rsi,rdx
M08_L02:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M08_L12
       test      rsi,rsi
       je        short M08_L03
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M08_L03:
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
M08_L04:
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M08_L15
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M08_L16
       test      rbp,rbp
       je        short M08_L05
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M08_L05:
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
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M08_L17
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
       jo        near ptr M08_L18
       cmp       ecx,0FF
       ja        near ptr M08_L18
       mov       [rdi+1D],cl
       mov       rax,rdi
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
       jmp       near ptr M08_L02
M08_L10:
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
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M08_L00
M08_L11:
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
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M08_L01
M08_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       test      rsi,rsi
       jne       short M08_L13
       mov       rsi,[rbx+8]
M08_L13:
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
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M08_L04
M08_L14:
       mov       ecx,869
       mov       rdx,7FFC1369F730
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13707EB8]
       int       3
M08_L15:
       mov       rax,rbx
       jmp       near ptr M08_L07
M08_L16:
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
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M08_L06
M08_L17:
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
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M08_L07
M08_L18:
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
       je        near ptr M09_L03
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M09_L04
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M09_L05
       test      rbp,rbp
       je        short M09_L00
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M09_L00:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M09_L07
       cmp       ecx,0FF
       ja        near ptr M09_L07
       mov       [rbx+1D],cl
M09_L01:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M09_L06
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
       jo        near ptr M09_L07
       cmp       ecx,0FF
       ja        near ptr M09_L07
       mov       [rdi+1D],cl
       mov       rax,rdi
M09_L02:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M09_L03:
       mov       ecx,869
       mov       rdx,7FFC1369F730
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13707EB8]
       int       3
M09_L04:
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
M09_L05:
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
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M09_L01
M09_L06:
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
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M09_L02
M09_L07:
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
       je        near ptr M10_L14
       mov       rsi,[rbx+10]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M10_L08
       test      rsi,rsi
       je        near ptr M10_L14
       cmp       qword ptr [rdi+8],0
       je        near ptr M10_L09
       mov       rbp,rdi
       mov       rdx,[rbp+10]
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M10_L10
       test      r14,r14
       je        short M10_L00
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M10_L00:
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M10_L18
       cmp       ecx,0FF
       ja        near ptr M10_L18
       mov       [rsi+1D],cl
M10_L01:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M10_L11
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
       jo        near ptr M10_L18
       cmp       ecx,0FF
       ja        near ptr M10_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M10_L02:
       mov       rsi,rdx
M10_L03:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M10_L12
       test      rsi,rsi
       je        short M10_L04
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M10_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M10_L18
       cmp       ecx,0FF
       ja        near ptr M10_L18
       mov       [rbx+1D],cl
M10_L05:
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M10_L15
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M10_L16
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
       jo        near ptr M10_L18
       cmp       ecx,0FF
       ja        near ptr M10_L18
       mov       [rbx+1D],cl
M10_L06:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M10_L17
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
       jo        near ptr M10_L18
       cmp       ecx,0FF
       ja        near ptr M10_L18
       mov       [rsi+1D],cl
       mov       rax,rsi
M10_L07:
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
M10_L08:
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
M10_L09:
       jmp       near ptr M10_L03
M10_L10:
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
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M10_L01
M10_L11:
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
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M10_L02
M10_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       mov       r15,[rbx+8]
       test      rsi,rsi
       jne       short M10_L13
       mov       rsi,[rbx+10]
M10_L13:
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
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M10_L05
M10_L14:
       mov       ecx,869
       mov       rdx,7FFC1369F730
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13707EB8]
       int       3
M10_L15:
       mov       rax,rbx
       jmp       near ptr M10_L07
M10_L16:
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
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M10_L06
M10_L17:
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
       call      qword ptr [7FFC135DEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M10_L07
M10_L18:
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
       je        short M11_L00
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
M11_L00:
       mov       ecx,4AB
       mov       rdx,7FFC1369F730
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13707EB8]
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
       je        near ptr M12_L06
       mov       esi,[rcx+8]
       cmp       dword ptr [rcx+0C],0
       jne       short M12_L00
       add       esi,[rbx+20]
M12_L00:
       mov       rdi,[rcx]
       cmp       rdi,[rbx+10]
       je        near ptr M12_L07
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rbx,[rbx+8]
       test      rdi,rdi
       je        near ptr M12_L08
       test      rbx,rbx
       je        near ptr M12_L09
       mov       r14,[rbp]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax+8]
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M12_L02
       test      r15,r15
       je        short M12_L01
       mov       r13d,[rdi+18]
       mov       r12,[rdi+20]
       mov       rax,[rdi+28]
       mov       [rsp+20],rax
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__89_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [r15+18],rcx
       jne       near ptr M12_L10
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       test      rax,rax
       je        short M12_L01
       cmp       byte ptr [rax+24],0
       jne       short M12_L01
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC135DEC70]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       r12,[rsp+20]
       mov       rcx,[r12+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFC135DEC70]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r12+24],1
M12_L01:
       mov       rcx,[rdi+8]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC135DE9E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       rcx,[rdi+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC135DE9E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       byte ptr [rdi+1C],1
M12_L02:
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
       je        short M12_L05
M12_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,rbp
M12_L04:
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
M12_L05:
       mov       rdx,7FFC136E8E48
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M12_L03
M12_L06:
       mov       ecx,577
       mov       rdx,7FFC1369F730
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13707EB8]
       int       3
M12_L07:
       jmp       short M12_L04
M12_L08:
       mov       ecx,4AB
       mov       rdx,7FFC1369F730
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13707EB8]
       int       3
M12_L09:
       mov       ecx,4B5
       mov       rdx,7FFC1369F730
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13707EB8]
       int       3
M12_L10:
       mov       [rsp+28],r13d
       mov       [rsp+30],r12
       mov       [rsp+38],rax
       lea       rdx,[rsp+28]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       jmp       near ptr M12_L01
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
       je        near ptr M14_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M14_L01
       test      rsi,rsi
       je        short M14_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M14_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M14_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M14_L00:
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
M14_L01:
       test      rsi,rsi
       je        short M14_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M14_L03
M14_L02:
       mov       rax,2FB55C80008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M14_L03:
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
M14_L04:
       call      qword ptr [7FFC1370D740]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M15_L00
       ret
M15_L00:
       jmp       qword ptr [7FFC12F05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       je        short M16_L00
       test      r14,r14
       je        near ptr M16_L01
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
       jo        short M16_L02
       cmp       ecx,0FF
       ja        short M16_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M16_L00:
       mov       ecx,847
       mov       rdx,7FFC1369F730
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13707EB8]
       int       3
M16_L01:
       mov       ecx,851
       mov       rdx,7FFC1369F730
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13707EB8]
       int       3
M16_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 215
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,158
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       vmovdqu   ymmword ptr [rsp+0F0],ymm4
       vmovdqu   ymmword ptr [rsp+110],ymm4
       vmovdqu   ymmword ptr [rsp+130],ymm4
       xor       eax,eax
       mov       [rsp+150],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L33
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L34
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rdi,rcx
       jne       near ptr M00_L35
       mov       eax,[rsi+28]
       sub       eax,[rsi+30]
M00_L00:
       test      eax,eax
       je        near ptr M00_L38
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r8,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rdi,r8
       jne       near ptr M00_L37
       xor       edi,edi
       mov       r14d,[rsi+28]
       sub       r14d,[rsi+30]
       js        near ptr M00_L36
       mov       r8d,[rbp+8]
       test      r8d,r8d
       jl        near ptr M00_L06
       cmp       r8d,r14d
       jl        near ptr M00_L06
       mov       r15,[rsi+10]
       xor       r13d,r13d
       cmp       dword ptr [rsi+28],0
       jle       short M00_L03
M00_L01:
       test      r14d,r14d
       je        short M00_L03
       cmp       r13d,[r15+8]
       jae       near ptr M00_L55
       mov       r8,r13
       shl       r8,4
       lea       r8,[r15+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M00_L02
       lea       edx,[rdi+1]
       mov       r12d,edx
       mov       r8,[r8]
       movsxd    rdx,edi
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r14d
       mov       edi,r12d
M00_L02:
       inc       r13d
       cmp       r13d,[rsi+28]
       jl        short M00_L01
M00_L03:
       test      rbp,rbp
       je        near ptr M00_L39
       lea       rsi,[rbp+10]
       mov       edi,[rbp+8]
M00_L04:
       mov       rcx,229C7C02A40
       mov       rbp,[rcx]
       mov       r14,[rbp+10]
       mov       r15,[rbp+8]
       mov       r13,[rbp+18]
       xor       r12d,r12d
       xor       eax,eax
       inc       edi
M00_L05:
       dec       edi
       jne       near ptr M00_L07
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+130],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+130]
       mov       r9d,r12d
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFC136EF5A0]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rsp+130]
       vmovdqu   xmmword ptr [rsp+148],xmm0
       lea       rcx,[rsp+148]
       mov       r8,rbp
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFC136EF5B8]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableHashSet`1<System.__Canon>)
       mov       [rsp+0F0],rax
       mov       rcx,[rbx+90]
       lea       r8,[rsp+0F0]
       mov       rdx,7FFC13733FF8
       cmp       [rcx],ecx
       call      qword ptr [7FFC136E63E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,158
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L06:
       mov       ecx,6
       call      qword ptr [7FFC136EF3F0]
       int       3
M00_L07:
       mov       [rsp+0C0],rax
       mov       r8,[rsi+rax]
       mov       [rsp+0B8],r8
       test      r8,r8
       je        short M00_L08
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FFC12E70C30
       call      qword ptr [r11]
       mov       r10d,eax
       mov       r8,[rsp+0B8]
       jmp       short M00_L09
M00_L08:
       xor       ecx,ecx
       xor       r10d,r10d
M00_L09:
       mov       [rsp+144],r10d
       cmp       [r14],r14b
       mov       rcx,r14
       cmp       qword ptr [r14+8],0
       jne       near ptr M00_L32
M00_L10:
       xor       r9d,r9d
       xor       r11d,r11d
M00_L11:
       mov       [rsp+68],r11
       test      r11,r11
       jne       near ptr M00_L41
       xor       edx,edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+110],xmm0
       mov       [rsp+110],r8
       mov       rcx,229C7C02A68
       mov       rcx,[rcx]
       mov       [rsp+118],rcx
       mov       rcx,[rsp+110]
       mov       r11,[rsp+118]
M00_L12:
       test      edx,edx
       jne       near ptr M00_L28
       test      r11,r11
       je        near ptr M00_L45
       test      r13,r13
       je        near ptr M00_L53
       xor       r8d,r8d
       mov       [rsp+108],r8d
       mov       r8,[r14+8]
       test      r8,r8
       je        near ptr M00_L29
       mov       r9,r14
       mov       [rsp+0B0],r9
       mov       edx,[r9+18]
       mov       r10d,[rsp+144]
       cmp       r10d,edx
       jg        near ptr M00_L18
       cmp       r10d,edx
       jge       near ptr M00_L50
       mov       [rsp+0E0],rcx
       mov       [rsp+0E8],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+108]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+100]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+0E0]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC136E6280]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+100],0
       je        short M00_L16
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L48
       test      rax,rax
       je        short M00_L13
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L13:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L17
M00_L14:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+1D],cl
       mov       r9,r14
M00_L15:
       mov       r14,r9
       mov       [rsp+0B0],r14
M00_L16:
       cmp       byte ptr [rsp+100],0
       je        near ptr M00_L52
       mov       r14,[rsp+0B0]
       test      r14,r14
       je        near ptr M00_L54
       mov       rax,[r14+10]
       movzx     edx,byte ptr [rax+1D]
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       edx,ecx
       cmp       edx,2
       jl        near ptr M00_L23
       mov       [rsp+78],rax
       mov       rdx,rax
       mov       rcx,7FFC137D4788
       mov       r8,26A5CDA1A18
       call      qword ptr [7FFC136E6118]; System.Collections.Immutable.Requires.NotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String)
       mov       rdx,[rsp+78]
       mov       rcx,[rdx+10]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       ecx,edx
       js        near ptr M00_L26
       mov       rdx,r14
       mov       r14,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,r14
       call      qword ptr [7FFC136E6340]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M00_L27
M00_L17:
       mov       ecx,eax
       jmp       near ptr M00_L14
M00_L18:
       mov       r9,[rsp+0B0]
       mov       r8,[r9+10]
       mov       [rsp+0E0],rcx
       mov       [rsp+0E8],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+108]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+100]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+0E0]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC136E6280]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+100],0
       je        near ptr M00_L16
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L46
       test      rax,rax
       je        short M00_L19
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L19:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        short M00_L22
M00_L20:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+1D],cl
       mov       r9,r14
M00_L21:
       mov       r14,r9
       mov       [rsp+0B0],r14
       jmp       near ptr M00_L16
M00_L22:
       mov       ecx,eax
       jmp       short M00_L20
M00_L23:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r8,rcx
       mov       [rsp+0C8],r8
       mov       rcx,r8
       call      qword ptr [7FFC136E6310]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jne       short M00_L24
       mov       rax,r14
       jmp       short M00_L27
M00_L24:
       mov       rdx,[r14+8]
       mov       rcx,[rsp+0C8]
       call      qword ptr [7FFC136E62F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jle       short M00_L25
       mov       rdx,r14
       mov       rcx,[rsp+0C8]
       call      qword ptr [7FFC136E6328]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M00_L27
M00_L25:
       mov       rdx,r14
       mov       rcx,[rsp+0C8]
       call      qword ptr [7FFC136E6358]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M00_L27
M00_L26:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r14,rcx
       call      qword ptr [7FFC136E6370]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M00_L27:
       mov       r14,rax
       inc       r12d
M00_L28:
       mov       rax,[rsp+0C0]
       add       rax,8
       jmp       near ptr M00_L05
M00_L29:
       mov       [rsp+58],r11
       mov       [rsp+60],rcx
       mov       dword ptr [rsp+100],1
       mov       rdx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A0],rax
       mov       r8d,[rsp+144]
       mov       [rax+18],r8d
       lea       rcx,[rax+20]
       mov       rdx,[rsp+60]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       lea       rcx,[rax+28]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       mov       byte ptr [rax+1C],0
       movzx     r8d,byte ptr [r14+1D]
       add       r8d,1
       jo        near ptr M00_L56
       cmp       r8d,0FF
       ja        near ptr M00_L56
       mov       [rax+1D],r8b
       jmp       near ptr M00_L27
M00_L30:
       mov       rcx,[rcx+8]
M00_L31:
       cmp       qword ptr [rcx+8],0
       je        near ptr M00_L10
       mov       r10d,[rsp+144]
M00_L32:
       mov       edx,[rcx+18]
       cmp       r10d,edx
       je        near ptr M00_L40
       jle       short M00_L30
       mov       rcx,[rcx+10]
       jmp       short M00_L31
M00_L33:
       call      qword ptr [7FFC134CEEC8]
       mov       ecx,65
       mov       rdx,7FFC13340598
       call      qword ptr [7FFC13147798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131F4F28
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13340598
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F27840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136EF870]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136EE760]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rbp,rax
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,rsi
       mov       r11,7FFC12E70C20
       call      qword ptr [r11]
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,28F
       mov       rdx,7FFC12E64000
       call      qword ptr [7FFC13147798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFC136ED278]
       int       3
M00_L37:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFC12E70C28
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L38:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,229C7C02AF8
       mov       rbp,[rcx]
       jmp       near ptr M00_L03
M00_L39:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L04
M00_L40:
       mov       r9,[rcx+20]
       mov       r11,[rcx+28]
       jmp       near ptr M00_L11
M00_L41:
       mov       rcx,r15
       mov       [rsp+70],r9
       mov       r8,r9
       mov       rdx,[rsp+0B8]
       mov       r11,7FFC12E70C38
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L42
       mov       [rsp+20],r15
       mov       r11,[rsp+68]
       mov       r9d,[r11+20]
       mov       [rsp+68],r11
       mov       rcx,r11
       mov       rdx,[rsp+0B8]
       xor       r8d,r8d
       call      qword ptr [7FFC136EF2E8]
       test      eax,eax
       jl        short M00_L43
M00_L42:
       mov       ecx,1
       mov       rax,[rsp+70]
       mov       r10,[rsp+68]
       mov       edx,ecx
       mov       rcx,rax
       mov       r11,r10
       jmp       near ptr M00_L12
M00_L43:
       xor       edx,edx
       mov       [rsp+140],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+120],xmm0
       mov       rcx,[rsp+68]
       mov       rdx,[rsp+0B8]
       call      qword ptr [7FFC136EF300]
       mov       rcx,[rsp+70]
       mov       [rsp+120],rcx
       test      rax,rax
       jne       short M00_L44
       mov       rax,229C7C02A68
       mov       rax,[rax]
M00_L44:
       mov       [rsp+128],rax
       mov       rcx,[rsp+120]
       mov       rax,rcx
       mov       r11,[rsp+128]
       mov       r10,r11
       mov       rcx,rax
       mov       r11,r10
       mov       edx,[rsp+140]
       jmp       near ptr M00_L12
M00_L45:
       mov       r10d,[rsp+144]
       lea       r8,[rsp+108]
       mov       rcx,r14
       mov       edx,r10d
       call      qword ptr [7FFC136EF588]
       jmp       near ptr M00_L27
M00_L46:
       mov       edx,[r14+18]
       mov       [rsp+0FC],edx
       mov       r8,[r14+20]
       mov       [rsp+50],r8
       mov       r10,[r14+28]
       mov       [rsp+48],r10
       mov       r9,[r14+8]
       mov       [rsp+98],r9
       test      rax,rax
       mov       [rsp+90],rax
       jne       short M00_L47
       mov       rax,[r14+10]
       mov       [rsp+90],rax
M00_L47:
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r14,rcx
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rsp+50]
       mov       [rsp+0E0],r8
       mov       r8,[rsp+48]
       mov       [rsp+0E8],r8
       mov       r8,[rsp+90]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0E0]
       mov       edx,[rsp+0FC]
       mov       rcx,r14
       mov       r9,[rsp+98]
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r9,r14
       jmp       near ptr M00_L21
M00_L48:
       mov       edx,[r14+18]
       mov       [rsp+0F8],edx
       mov       r8,[r14+20]
       mov       [rsp+40],r8
       mov       r10,[r14+28]
       mov       [rsp+38],r10
       test      rax,rax
       mov       [rsp+88],rax
       jne       short M00_L49
       mov       rax,[r14+8]
       mov       [rsp+88],rax
M00_L49:
       mov       r14,[r14+10]
       mov       r11,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,r11
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rsp+80],r9
       mov       r8,[rsp+40]
       mov       [rsp+0E0],r8
       mov       r8,[rsp+38]
       mov       [rsp+0E8],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0E0]
       mov       edx,[rsp+0F8]
       mov       rcx,r9
       mov       r9,[rsp+88]
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+80]
       mov       r9,r14
       jmp       near ptr M00_L15
M00_L50:
       vmovdqu   xmm0,xmmword ptr [r14+20]
       vmovdqu   xmmword ptr [rsp+0E0],xmm0
       mov       [rsp+60],rcx
       mov       [rsp+0D0],rcx
       mov       [rsp+58],r11
       mov       [rsp+0D8],r11
       lea       r8,[rsp+0D0]
       lea       rdx,[rsp+0E0]
       mov       rcx,r13
       mov       r11,7FFC12E70C40
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L51
       xor       ecx,ecx
       mov       [rsp+100],ecx
       mov       rax,r14
       jmp       near ptr M00_L27
M00_L51:
       mov       dword ptr [rsp+100],1
       mov       dword ptr [rsp+108],1
       mov       r11,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rax,r11
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A8],rax
       mov       r10,[rsp+60]
       mov       [rsp+0E0],r10
       mov       r11,[rsp+58]
       mov       [rsp+0E8],r11
       mov       r8,[r14+10]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0E0]
       mov       r9,[r14+8]
       mov       edx,[rsp+144]
       mov       rcx,rax
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0A8]
       mov       [rsp+0B0],r14
       jmp       near ptr M00_L16
M00_L52:
       mov       r14,[rsp+0B0]
       mov       rax,r14
       jmp       near ptr M00_L27
M00_L53:
       mov       ecx,511
       mov       rdx,7FFC13711B90
       call      qword ptr [7FFC13147798]
       mov       rcx,rax
       call      qword ptr [7FFC136EF288]
       int       3
M00_L54:
       mov       ecx,869
       mov       rdx,7FFC13711B90
       call      qword ptr [7FFC13147798]
       mov       rcx,rax
       call      qword ptr [7FFC136EF288]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2938
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
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       jne       short M02_L03
M02_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFC72BA40D0
M02_L01:
       call      qword ptr [7FFC136EC6A8]
       int       3
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M02_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFC12F2D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r9d
       test      r8,r8
       je        short M03_L00
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
M03_L00:
       mov       ecx,4AB
       mov       rdx,7FFC13711B90
       call      qword ptr [7FFC13147798]
       mov       rcx,rax
       call      qword ptr [7FFC136EF288]
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
       je        near ptr M04_L06
       mov       esi,[rcx+8]
       cmp       dword ptr [rcx+0C],0
       jne       short M04_L00
       add       esi,[rbx+20]
M04_L00:
       mov       rdi,[rcx]
       cmp       rdi,[rbx+10]
       je        near ptr M04_L07
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rbx,[rbx+8]
       test      rdi,rdi
       je        near ptr M04_L08
       test      rbx,rbx
       je        near ptr M04_L09
       mov       r14,[rbp]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax+8]
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M04_L02
       test      r15,r15
       je        short M04_L01
       mov       r13d,[rdi+18]
       mov       r12,[rdi+20]
       mov       rax,[rdi+28]
       mov       [rsp+20],rax
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__89_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [r15+18],rcx
       jne       near ptr M04_L10
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       test      rax,rax
       je        short M04_L01
       cmp       byte ptr [rax+24],0
       jne       short M04_L01
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC136E63D0]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       r12,[rsp+20]
       mov       rcx,[r12+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFC136E63D0]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r12+24],1
M04_L01:
       mov       rcx,[rdi+8]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC136E6148]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       rcx,[rdi+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC136E6148]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       byte ptr [rdi+1C],1
M04_L02:
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
       je        short M04_L05
M04_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,rbp
M04_L04:
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
M04_L05:
       mov       rdx,7FFC137C4028
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M04_L03
M04_L06:
       mov       ecx,577
       mov       rdx,7FFC13711B90
       call      qword ptr [7FFC13147798]
       mov       rcx,rax
       call      qword ptr [7FFC136EF288]
       int       3
M04_L07:
       jmp       short M04_L04
M04_L08:
       mov       ecx,4AB
       mov       rdx,7FFC13711B90
       call      qword ptr [7FFC13147798]
       mov       rcx,rax
       call      qword ptr [7FFC136EF288]
       int       3
M04_L09:
       mov       ecx,4B5
       mov       rdx,7FFC13711B90
       call      qword ptr [7FFC13147798]
       mov       rcx,rax
       call      qword ptr [7FFC136EF288]
       int       3
M04_L10:
       mov       [rsp+28],r13d
       mov       [rsp+30],r12
       mov       [rsp+38],rax
       lea       rdx,[rsp+28]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       jmp       near ptr M04_L01
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
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M06_L00:
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
       je        near ptr M06_L11
       mov       r13,rbx
       cmp       edi,[r13+18]
       jg        near ptr M06_L03
       cmp       edi,[r13+18]
       jge       near ptr M06_L16
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFC136E6280]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        short M06_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L14
       test      rsi,rsi
       je        short M06_L01
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M06_L01:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L23
       cmp       ecx,0FF
       ja        near ptr M06_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M06_L02:
       cmp       byte ptr [r14],0
       je        near ptr M06_L21
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M06_L22
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jl        near ptr M06_L06
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M06_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       js        near ptr M06_L09
       mov       rdx,r13
       call      qword ptr [7FFC136E6340]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M06_L10
M06_L03:
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFC136E6280]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        near ptr M06_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L12
       test      rdi,rdi
       je        short M06_L04
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M06_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L23
       cmp       ecx,0FF
       ja        near ptr M06_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M06_L05:
       jmp       near ptr M06_L02
M06_L06:
       cmp       edx,0FFFFFFFE
       jle       short M06_L07
       mov       rax,r13
       jmp       short M06_L10
M06_L07:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M06_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M06_L08
       mov       rdx,r13
       call      qword ptr [7FFC136E6328]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M06_L10
M06_L08:
       mov       rdx,r13
       call      qword ptr [7FFC136E6358]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M06_L10
M06_L09:
       mov       rdx,r13
       call      qword ptr [7FFC136E6370]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M06_L10:
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
M06_L11:
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
       jo        near ptr M06_L23
       cmp       eax,0FF
       ja        near ptr M06_L23
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
M06_L12:
       mov       r13d,[rbx+18]
       mov       rsi,[rbx+20]
       mov       rbp,[rbx+28]
       mov       r15,[rbx+8]
       test      rdi,rdi
       jne       short M06_L13
       mov       rdi,[rbx+10]
M06_L13:
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
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M06_L05
M06_L14:
       mov       r13d,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r15,[rbx+28]
       test      rsi,rsi
       jne       short M06_L15
       mov       rsi,[rbx+8]
M06_L15:
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
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M06_L02
M06_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M06_L17
       jmp       short M06_L18
M06_L17:
       mov       rdx,7FFC1379EE08
       call      qword ptr [7FFC12F2C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M06_L18:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rdx,[rsp+50]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M06_L19
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
M06_L19:
       cmp       byte ptr [rsp+0D0],0
       je        short M06_L20
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
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L02
M06_L20:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFC136EF2A0]
       mov       r15,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFC136EF2B8]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFC13275F98]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M06_L21:
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
M06_L22:
       mov       ecx,869
       mov       rdx,7FFC13711B90
       call      qword ptr [7FFC13147798]
       mov       rcx,rax
       call      qword ptr [7FFC136EF288]
       int       3
M06_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1145
```
```assembly
; System.Collections.Immutable.Requires.NotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String)
       sub       rsp,28
       test      rdx,rdx
       je        short M07_L00
       add       rsp,28
       ret
M07_L00:
       mov       rcx,r8
       call      qword ptr [7FFC136EF288]
       int       3
; Total bytes of code 24
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
       je        near ptr M08_L02
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M08_L03
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M08_L04
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
       jo        near ptr M08_L06
       cmp       ecx,0FF
       ja        near ptr M08_L06
       mov       [rbx+1D],cl
M08_L00:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M08_L05
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
       jo        near ptr M08_L06
       cmp       ecx,0FF
       ja        near ptr M08_L06
       mov       [rsi+1D],cl
       mov       rax,rsi
M08_L01:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L02:
       mov       ecx,869
       mov       rdx,7FFC13711B90
       call      qword ptr [7FFC13147798]
       mov       rcx,rax
       call      qword ptr [7FFC136EF288]
       int       3
M08_L03:
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
M08_L04:
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
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M08_L00
M08_L05:
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
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M08_L01
M08_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 419
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M09_L00
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
M09_L00:
       mov       ecx,869
       mov       rdx,7FFC13711B90
       call      qword ptr [7FFC13147798]
       mov       rcx,rax
       call      qword ptr [7FFC136EF288]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M10_L00
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rdx+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       eax,ecx
       add       rsp,28
       ret
M10_L00:
       mov       ecx,869
       mov       rdx,7FFC13711B90
       call      qword ptr [7FFC13147798]
       mov       rcx,rax
       call      qword ptr [7FFC136EF288]
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
       je        near ptr M11_L14
       mov       rsi,[rbx+8]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M11_L08
       test      rsi,rsi
       je        near ptr M11_L14
       mov       rbp,[rsi+10]
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M11_L09
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M11_L10
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rdi+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M11_L18
       cmp       ecx,0FF
       ja        near ptr M11_L18
       mov       [rsi+1D],cl
M11_L00:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M11_L11
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
       jo        near ptr M11_L18
       cmp       ecx,0FF
       ja        near ptr M11_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M11_L01:
       mov       rsi,rdx
M11_L02:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M11_L12
       test      rsi,rsi
       je        short M11_L03
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M11_L03:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M11_L18
       cmp       ecx,0FF
       ja        near ptr M11_L18
       mov       [rbx+1D],cl
M11_L04:
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M11_L15
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M11_L16
       test      rbp,rbp
       je        short M11_L05
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M11_L05:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M11_L18
       cmp       ecx,0FF
       ja        near ptr M11_L18
       mov       [rbx+1D],cl
M11_L06:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M11_L17
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
       jo        near ptr M11_L18
       cmp       ecx,0FF
       ja        near ptr M11_L18
       mov       [rdi+1D],cl
       mov       rax,rdi
M11_L07:
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
M11_L08:
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
M11_L09:
       jmp       near ptr M11_L02
M11_L10:
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
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M11_L00
M11_L11:
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
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M11_L01
M11_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       test      rsi,rsi
       jne       short M11_L13
       mov       rsi,[rbx+8]
M11_L13:
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
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M11_L04
M11_L14:
       mov       ecx,869
       mov       rdx,7FFC13711B90
       call      qword ptr [7FFC13147798]
       mov       rcx,rax
       call      qword ptr [7FFC136EF288]
       int       3
M11_L15:
       mov       rax,rbx
       jmp       near ptr M11_L07
M11_L16:
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
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M11_L06
M11_L17:
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
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M11_L07
M11_L18:
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
       je        near ptr M12_L03
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M12_L04
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M12_L05
       test      rbp,rbp
       je        short M12_L00
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M12_L00:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M12_L07
       cmp       ecx,0FF
       ja        near ptr M12_L07
       mov       [rbx+1D],cl
M12_L01:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M12_L06
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
       jo        near ptr M12_L07
       cmp       ecx,0FF
       ja        near ptr M12_L07
       mov       [rdi+1D],cl
       mov       rax,rdi
M12_L02:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M12_L03:
       mov       ecx,869
       mov       rdx,7FFC13711B90
       call      qword ptr [7FFC13147798]
       mov       rcx,rax
       call      qword ptr [7FFC136EF288]
       int       3
M12_L04:
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
M12_L05:
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
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M12_L01
M12_L06:
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
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M12_L02
M12_L07:
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
       je        near ptr M13_L14
       mov       rsi,[rbx+10]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M13_L08
       test      rsi,rsi
       je        near ptr M13_L14
       cmp       qword ptr [rdi+8],0
       je        near ptr M13_L09
       mov       rbp,rdi
       mov       rdx,[rbp+10]
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M13_L10
       test      r14,r14
       je        short M13_L00
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M13_L00:
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M13_L18
       cmp       ecx,0FF
       ja        near ptr M13_L18
       mov       [rsi+1D],cl
M13_L01:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M13_L11
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
       jo        near ptr M13_L18
       cmp       ecx,0FF
       ja        near ptr M13_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M13_L02:
       mov       rsi,rdx
M13_L03:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M13_L12
       test      rsi,rsi
       je        short M13_L04
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M13_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M13_L18
       cmp       ecx,0FF
       ja        near ptr M13_L18
       mov       [rbx+1D],cl
M13_L05:
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M13_L15
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M13_L16
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
       jo        near ptr M13_L18
       cmp       ecx,0FF
       ja        near ptr M13_L18
       mov       [rbx+1D],cl
M13_L06:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M13_L17
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
       jo        near ptr M13_L18
       cmp       ecx,0FF
       ja        near ptr M13_L18
       mov       [rsi+1D],cl
       mov       rax,rsi
M13_L07:
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
M13_L08:
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
M13_L09:
       jmp       near ptr M13_L03
M13_L10:
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
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M13_L01
M13_L11:
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
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M13_L02
M13_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       mov       r15,[rbx+8]
       test      rsi,rsi
       jne       short M13_L13
       mov       rsi,[rbx+10]
M13_L13:
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
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M13_L05
M13_L14:
       mov       ecx,869
       mov       rdx,7FFC13711B90
       call      qword ptr [7FFC13147798]
       mov       rcx,rax
       call      qword ptr [7FFC136EF288]
       int       3
M13_L15:
       mov       rax,rbx
       jmp       near ptr M13_L07
M13_L16:
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
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M13_L06
M13_L17:
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
       call      qword ptr [7FFC136E6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M13_L07
M13_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 943
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
       je        near ptr M14_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M14_L01
       test      rsi,rsi
       je        short M14_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M14_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M14_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M14_L00:
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
M14_L01:
       test      rsi,rsi
       je        short M14_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M14_L03
M14_L02:
       mov       rax,26A5CD90008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M14_L03:
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
M14_L04:
       call      qword ptr [7FFC136EED48]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M15_L00
       ret
M15_L00:
       jmp       qword ptr [7FFC12F25C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       je        short M16_L00
       test      r14,r14
       je        near ptr M16_L01
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
       jo        short M16_L02
       cmp       ecx,0FF
       ja        short M16_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M16_L00:
       mov       ecx,847
       mov       rdx,7FFC13711B90
       call      qword ptr [7FFC13147798]
       mov       rcx,rax
       call      qword ptr [7FFC136EF288]
       int       3
M16_L01:
       mov       ecx,851
       mov       rdx,7FFC13711B90
       call      qword ptr [7FFC13147798]
       mov       rcx,rax
       call      qword ptr [7FFC136EF288]
       int       3
M16_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 215
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,158
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       vmovdqu   ymmword ptr [rsp+0F0],ymm4
       vmovdqu   ymmword ptr [rsp+110],ymm4
       vmovdqu   ymmword ptr [rsp+130],ymm4
       xor       eax,eax
       mov       [rsp+150],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L33
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFC12F16850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L34
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rdi,rcx
       jne       near ptr M00_L35
       mov       eax,[rsi+28]
       sub       eax,[rsi+30]
M00_L00:
       test      eax,eax
       je        near ptr M00_L38
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r8,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rdi,r8
       jne       near ptr M00_L37
       xor       edi,edi
       mov       r14d,[rsi+28]
       sub       r14d,[rsi+30]
       js        near ptr M00_L36
       mov       r8d,[rbp+8]
       test      r8d,r8d
       jl        near ptr M00_L05
       cmp       r8d,r14d
       jl        near ptr M00_L05
       mov       r15,[rsi+10]
       xor       r13d,r13d
       cmp       dword ptr [rsi+28],0
       jle       short M00_L03
M00_L01:
       test      r14d,r14d
       je        short M00_L03
       cmp       r13d,[r15+8]
       jae       near ptr M00_L57
       mov       r8,r13
       shl       r8,4
       lea       r8,[r15+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M00_L02
       lea       edx,[rdi+1]
       mov       r12d,edx
       mov       r8,[r8]
       movsxd    rdx,edi
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r14d
       mov       edi,r12d
M00_L02:
       inc       r13d
       cmp       r13d,[rsi+28]
       jl        short M00_L01
M00_L03:
       test      rbp,rbp
       je        near ptr M00_L39
       lea       rsi,[rbp+10]
       mov       edi,[rbp+8]
M00_L04:
       mov       rcx,2165C800A30
       mov       rbp,[rcx]
       mov       r14,[rbp+10]
       mov       r15,[rbp+8]
       mov       r13,[rbp+18]
       xor       r12d,r12d
       xor       eax,eax
       inc       edi
       jmp       near ptr M00_L28
M00_L05:
       mov       ecx,6
       call      qword ptr [7FFC1371C4B0]
       int       3
M00_L06:
       mov       [rsp+0C0],rax
       mov       r8,[rsi+rax]
       mov       [rsp+0B8],r8
       test      r8,r8
       je        short M00_L07
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FFC12E60B30
       call      qword ptr [r11]
       mov       r10d,eax
       mov       r8,[rsp+0B8]
       jmp       short M00_L08
M00_L07:
       xor       ecx,ecx
       xor       r10d,r10d
M00_L08:
       mov       [rsp+144],r10d
       cmp       [r14],r14b
       mov       rcx,r14
       cmp       qword ptr [r14+8],0
       jne       near ptr M00_L32
M00_L09:
       xor       r9d,r9d
       xor       r11d,r11d
M00_L10:
       mov       [rsp+68],r11
       test      r11,r11
       jne       near ptr M00_L41
       xor       edx,edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+110],xmm0
       mov       [rsp+110],r8
       mov       rcx,2165C800A58
       mov       rcx,[rcx]
       mov       [rsp+118],rcx
       mov       rcx,[rsp+110]
       mov       r11,[rsp+118]
M00_L11:
       test      edx,edx
       jne       near ptr M00_L27
       test      r11,r11
       je        near ptr M00_L45
       test      r13,r13
       je        near ptr M00_L55
       xor       r8d,r8d
       mov       [rsp+108],r8d
       mov       r8,[r14+8]
       test      r8,r8
       je        near ptr M00_L29
       mov       r9,r14
       mov       [rsp+0B0],r9
       mov       edx,[r9+18]
       mov       r10d,[rsp+144]
       cmp       r10d,edx
       jg        near ptr M00_L17
       cmp       r10d,edx
       jge       near ptr M00_L52
       mov       [rsp+0E0],rcx
       mov       [rsp+0E8],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+108]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+100]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+0E0]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC135EEA48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+100],0
       je        near ptr M00_L51
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L49
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
       jl        near ptr M00_L16
M00_L13:
       add       ecx,1
       jo        near ptr M00_L58
       cmp       ecx,0FF
       ja        near ptr M00_L58
       mov       [r14+1D],cl
       mov       r9,r14
M00_L14:
       mov       r14,r9
M00_L15:
       cmp       byte ptr [rsp+100],0
       je        near ptr M00_L54
       test      r14,r14
       je        near ptr M00_L56
       mov       rax,[r14+10]
       movzx     edx,byte ptr [rax+1D]
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       edx,ecx
       cmp       edx,2
       jl        near ptr M00_L22
       mov       [rsp+78],rax
       mov       rdx,rax
       mov       rcx,7FFC137588C8
       mov       r8,256DB871A18
       call      qword ptr [7FFC135EE8E0]; System.Collections.Immutable.Requires.NotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String)
       mov       rdx,[rsp+78]
       mov       rcx,[rdx+10]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       ecx,edx
       js        near ptr M00_L25
       mov       rdx,r14
       mov       r14,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,r14
       call      qword ptr [7FFC135EEB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M00_L26
M00_L16:
       mov       ecx,eax
       jmp       near ptr M00_L13
M00_L17:
       mov       r9,[rsp+0B0]
       mov       r8,[r9+10]
       mov       [rsp+0E0],rcx
       mov       [rsp+0E8],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+108]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+100]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+0E0]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC135EEA48]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+100],0
       je        near ptr M00_L48
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L46
       test      rax,rax
       je        short M00_L18
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L18:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        short M00_L21
M00_L19:
       add       ecx,1
       jo        near ptr M00_L58
       cmp       ecx,0FF
       ja        near ptr M00_L58
       mov       [r14+1D],cl
       mov       r9,r14
M00_L20:
       mov       r14,r9
       jmp       near ptr M00_L15
M00_L21:
       mov       ecx,eax
       jmp       short M00_L19
M00_L22:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r8,rcx
       mov       [rsp+0C8],r8
       mov       rcx,r8
       call      qword ptr [7FFC135EEAD8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jne       short M00_L23
       mov       rax,r14
       jmp       short M00_L26
M00_L23:
       mov       rdx,[r14+8]
       mov       rcx,[rsp+0C8]
       call      qword ptr [7FFC135EEAC0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jle       short M00_L24
       mov       rdx,r14
       mov       rcx,[rsp+0C8]
       call      qword ptr [7FFC135EEB08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M00_L26
M00_L24:
       mov       rdx,r14
       mov       rcx,[rsp+0C8]
       call      qword ptr [7FFC135EEAF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M00_L26
M00_L25:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r14,rcx
       call      qword ptr [7FFC135EEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M00_L26:
       mov       r14,rax
       inc       r12d
M00_L27:
       mov       rax,[rsp+0C0]
       add       rax,8
M00_L28:
       dec       edi
       jne       near ptr M00_L06
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+130],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+130]
       mov       r9d,r12d
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFC1371C630]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rsp+130]
       vmovdqu   xmmword ptr [rsp+148],xmm0
       lea       rcx,[rsp+148]
       mov       r8,rbp
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFC1371C648]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableHashSet`1<System.__Canon>)
       mov       [rsp+0F0],rax
       mov       rcx,[rbx+90]
       lea       r8,[rsp+0F0]
       mov       rdx,7FFC136E1DD0
       cmp       [rcx],ecx
       call      qword ptr [7FFC135EEBB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,158
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
       mov       [rsp+58],r11
       mov       [rsp+60],rcx
       mov       dword ptr [rsp+100],1
       mov       rdx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A0],rax
       mov       r8d,[rsp+144]
       mov       [rax+18],r8d
       lea       rcx,[rax+20]
       mov       rdx,[rsp+60]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       lea       rcx,[rax+28]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       mov       byte ptr [rax+1C],0
       movzx     r8d,byte ptr [r14+1D]
       add       r8d,1
       jo        near ptr M00_L58
       cmp       r8d,0FF
       ja        near ptr M00_L58
       mov       [rax+1D],r8b
       jmp       near ptr M00_L26
M00_L30:
       mov       rcx,[rcx+8]
M00_L31:
       cmp       qword ptr [rcx+8],0
       je        near ptr M00_L09
       mov       r10d,[rsp+144]
M00_L32:
       mov       edx,[rcx+18]
       cmp       r10d,edx
       je        near ptr M00_L40
       jle       short M00_L30
       mov       rcx,[rcx+10]
       jmp       short M00_L31
M00_L33:
       call      qword ptr [7FFC134B7720]
       mov       ecx,65
       mov       rdx,7FFC13330598
       call      qword ptr [7FFC13137798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131E4F28
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13330598
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC1371C8B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC1371C8D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rbp,rax
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,rsi
       mov       r11,7FFC12E60B20
       call      qword ptr [r11]
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,28F
       mov       rdx,7FFC12E54000
       call      qword ptr [7FFC13137798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFC1371C480]
       int       3
M00_L37:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFC12E60B28
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L38:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2165C800A88
       mov       rbp,[rcx]
       jmp       near ptr M00_L03
M00_L39:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L04
M00_L40:
       mov       r9,[rcx+20]
       mov       r11,[rcx+28]
       jmp       near ptr M00_L10
M00_L41:
       mov       rcx,r15
       mov       [rsp+70],r9
       mov       r8,r9
       mov       rdx,[rsp+0B8]
       mov       r11,7FFC12E60B38
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L42
       mov       [rsp+20],r15
       mov       r11,[rsp+68]
       mov       r9d,[r11+20]
       mov       [rsp+68],r11
       mov       rcx,r11
       mov       rdx,[rsp+0B8]
       xor       r8d,r8d
       call      qword ptr [7FFC1371C048]
       test      eax,eax
       jl        short M00_L43
M00_L42:
       mov       ecx,1
       mov       rax,[rsp+70]
       mov       r10,[rsp+68]
       mov       edx,ecx
       mov       rcx,rax
       mov       r11,r10
       jmp       near ptr M00_L11
M00_L43:
       xor       edx,edx
       mov       [rsp+140],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+120],xmm0
       mov       rcx,[rsp+68]
       mov       rdx,[rsp+0B8]
       call      qword ptr [7FFC1371C060]
       mov       rcx,[rsp+70]
       mov       [rsp+120],rcx
       test      rax,rax
       jne       short M00_L44
       mov       rax,2165C800A58
       mov       rax,[rax]
M00_L44:
       mov       [rsp+128],rax
       mov       rcx,[rsp+120]
       mov       rax,rcx
       mov       r11,[rsp+128]
       mov       r10,r11
       mov       rcx,rax
       mov       r11,r10
       mov       edx,[rsp+140]
       jmp       near ptr M00_L11
M00_L45:
       mov       r10d,[rsp+144]
       lea       r8,[rsp+108]
       mov       rcx,r14
       mov       edx,r10d
       call      qword ptr [7FFC1371C618]
       jmp       near ptr M00_L26
M00_L46:
       mov       edx,[r14+18]
       mov       [rsp+0FC],edx
       mov       r8,[r14+20]
       mov       [rsp+50],r8
       mov       r10,[r14+28]
       mov       [rsp+48],r10
       mov       r9,[r14+8]
       mov       [rsp+98],r9
       test      rax,rax
       mov       [rsp+90],rax
       jne       short M00_L47
       mov       rax,[r14+10]
       mov       [rsp+90],rax
M00_L47:
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r14,rcx
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rsp+50]
       mov       [rsp+0E0],r8
       mov       r8,[rsp+48]
       mov       [rsp+0E8],r8
       mov       r8,[rsp+90]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0E0]
       mov       edx,[rsp+0FC]
       mov       rcx,r14
       mov       r9,[rsp+98]
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r9,r14
       jmp       near ptr M00_L20
M00_L48:
       mov       r14,[rsp+0B0]
       jmp       near ptr M00_L15
M00_L49:
       mov       edx,[r14+18]
       mov       [rsp+0F8],edx
       mov       r8,[r14+20]
       mov       [rsp+40],r8
       mov       r10,[r14+28]
       mov       [rsp+38],r10
       test      rax,rax
       mov       [rsp+88],rax
       jne       short M00_L50
       mov       rax,[r14+8]
       mov       [rsp+88],rax
M00_L50:
       mov       r14,[r14+10]
       mov       r11,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,r11
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rsp+80],r9
       mov       r8,[rsp+40]
       mov       [rsp+0E0],r8
       mov       r8,[rsp+38]
       mov       [rsp+0E8],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0E0]
       mov       edx,[rsp+0F8]
       mov       rcx,r9
       mov       r9,[rsp+88]
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+80]
       mov       r9,r14
       jmp       near ptr M00_L14
M00_L51:
       mov       r14,[rsp+0B0]
       jmp       near ptr M00_L15
M00_L52:
       vmovdqu   xmm0,xmmword ptr [r14+20]
       vmovdqu   xmmword ptr [rsp+0E0],xmm0
       mov       [rsp+60],rcx
       mov       [rsp+0D0],rcx
       mov       [rsp+58],r11
       mov       [rsp+0D8],r11
       lea       r8,[rsp+0D0]
       lea       rdx,[rsp+0E0]
       mov       rcx,r13
       mov       r11,7FFC12E60B40
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L53
       xor       ecx,ecx
       mov       [rsp+100],ecx
       mov       rax,r14
       jmp       near ptr M00_L26
M00_L53:
       mov       dword ptr [rsp+100],1
       mov       dword ptr [rsp+108],1
       mov       r11,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rax,r11
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A8],rax
       mov       r10,[rsp+60]
       mov       [rsp+0E0],r10
       mov       r11,[rsp+58]
       mov       [rsp+0E8],r11
       mov       r8,[r14+10]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0E0]
       mov       r9,[r14+8]
       mov       edx,[rsp+144]
       mov       rcx,rax
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0A8]
       jmp       near ptr M00_L15
M00_L54:
       mov       rax,r14
       jmp       near ptr M00_L26
M00_L55:
       mov       ecx,511
       mov       rdx,7FFC136BF178
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC13717F60]
       int       3
M00_L56:
       mov       ecx,869
       mov       rdx,7FFC136BF178
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC13717F60]
       int       3
M00_L57:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2929
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
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       jne       short M02_L03
M02_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFC72BA40D0
M02_L01:
       call      qword ptr [7FFC13717F18]
       int       3
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M02_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFC12F1D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M03_L00:
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
       je        near ptr M03_L11
       mov       r13,rbx
       cmp       edi,[r13+18]
       jg        near ptr M03_L03
       cmp       edi,[r13+18]
       jge       near ptr M03_L16
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFC135EEA48]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        short M03_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L14
       test      rsi,rsi
       je        short M03_L01
       lea       rcx,[rbx+8]
       mov       rdx,rsi
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
       call      qword ptr [7FFC135EEB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M03_L10
M03_L03:
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFC135EEA48]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        near ptr M03_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M03_L12
       test      rdi,rdi
       je        short M03_L04
       lea       rcx,[rbx+10]
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
       call      qword ptr [7FFC135EEB08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M03_L10
M03_L08:
       mov       rdx,r13
       call      qword ptr [7FFC135EEAF0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M03_L10
M03_L09:
       mov       rdx,r13
       call      qword ptr [7FFC135EEB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M03_L10:
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
M03_L11:
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
       jo        near ptr M03_L23
       cmp       eax,0FF
       ja        near ptr M03_L23
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
M03_L12:
       mov       r13d,[rbx+18]
       mov       rsi,[rbx+20]
       mov       rbp,[rbx+28]
       mov       r15,[rbx+8]
       test      rdi,rdi
       jne       short M03_L13
       mov       rdi,[rbx+10]
M03_L13:
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
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M03_L05
M03_L14:
       mov       r13d,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r15,[rbx+28]
       test      rsi,rsi
       jne       short M03_L15
       mov       rsi,[rbx+8]
M03_L15:
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
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M03_L02
M03_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M03_L17
       jmp       short M03_L18
M03_L17:
       mov       rdx,7FFC136F3A18
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L18:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rdx,[rsp+50]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L19
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
M03_L19:
       cmp       byte ptr [rsp+0D0],0
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
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M03_L02
M03_L20:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFC13717F78]
       mov       r15,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFC13717F90]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFC13265F98]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M03_L21:
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
M03_L22:
       mov       ecx,869
       mov       rdx,7FFC136BF178
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC13717F60]
       int       3
M03_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1145
```
```assembly
; System.Collections.Immutable.Requires.NotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String)
       sub       rsp,28
       test      rdx,rdx
       je        short M04_L00
       add       rsp,28
       ret
M04_L00:
       mov       rcx,r8
       call      qword ptr [7FFC13717F60]
       int       3
; Total bytes of code 24
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
       mov       rdx,7FFC136BF178
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC13717F60]
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
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M05_L01
M05_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 419
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M06_L00
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
M06_L00:
       mov       ecx,869
       mov       rdx,7FFC136BF178
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC13717F60]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M07_L00
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rdx+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       eax,ecx
       add       rsp,28
       ret
M07_L00:
       mov       ecx,869
       mov       rdx,7FFC136BF178
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC13717F60]
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
       je        near ptr M08_L14
       mov       rsi,[rbx+8]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M08_L08
       test      rsi,rsi
       je        near ptr M08_L14
       mov       rbp,[rsi+10]
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M08_L09
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M08_L10
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rdi+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M08_L18
       cmp       ecx,0FF
       ja        near ptr M08_L18
       mov       [rsi+1D],cl
M08_L00:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M08_L11
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
       jo        near ptr M08_L18
       cmp       ecx,0FF
       ja        near ptr M08_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M08_L01:
       mov       rsi,rdx
M08_L02:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M08_L12
       test      rsi,rsi
       je        short M08_L03
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M08_L03:
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
M08_L04:
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M08_L15
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M08_L16
       test      rbp,rbp
       je        short M08_L05
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M08_L05:
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
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M08_L17
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
       jo        near ptr M08_L18
       cmp       ecx,0FF
       ja        near ptr M08_L18
       mov       [rdi+1D],cl
       mov       rax,rdi
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
       jmp       near ptr M08_L02
M08_L10:
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
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M08_L00
M08_L11:
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
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M08_L01
M08_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       test      rsi,rsi
       jne       short M08_L13
       mov       rsi,[rbx+8]
M08_L13:
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
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M08_L04
M08_L14:
       mov       ecx,869
       mov       rdx,7FFC136BF178
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC13717F60]
       int       3
M08_L15:
       mov       rax,rbx
       jmp       near ptr M08_L07
M08_L16:
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
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M08_L06
M08_L17:
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
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M08_L07
M08_L18:
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
       je        near ptr M09_L03
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M09_L04
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M09_L05
       test      rbp,rbp
       je        short M09_L00
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M09_L00:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M09_L07
       cmp       ecx,0FF
       ja        near ptr M09_L07
       mov       [rbx+1D],cl
M09_L01:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M09_L06
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
       jo        near ptr M09_L07
       cmp       ecx,0FF
       ja        near ptr M09_L07
       mov       [rdi+1D],cl
       mov       rax,rdi
M09_L02:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M09_L03:
       mov       ecx,869
       mov       rdx,7FFC136BF178
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC13717F60]
       int       3
M09_L04:
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
M09_L05:
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
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M09_L01
M09_L06:
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
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M09_L02
M09_L07:
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
       je        near ptr M10_L14
       mov       rsi,[rbx+10]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M10_L08
       test      rsi,rsi
       je        near ptr M10_L14
       cmp       qword ptr [rdi+8],0
       je        near ptr M10_L09
       mov       rbp,rdi
       mov       rdx,[rbp+10]
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M10_L10
       test      r14,r14
       je        short M10_L00
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M10_L00:
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M10_L18
       cmp       ecx,0FF
       ja        near ptr M10_L18
       mov       [rsi+1D],cl
M10_L01:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M10_L11
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
       jo        near ptr M10_L18
       cmp       ecx,0FF
       ja        near ptr M10_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M10_L02:
       mov       rsi,rdx
M10_L03:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M10_L12
       test      rsi,rsi
       je        short M10_L04
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M10_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M10_L18
       cmp       ecx,0FF
       ja        near ptr M10_L18
       mov       [rbx+1D],cl
M10_L05:
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M10_L15
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M10_L16
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
       jo        near ptr M10_L18
       cmp       ecx,0FF
       ja        near ptr M10_L18
       mov       [rbx+1D],cl
M10_L06:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M10_L17
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
       jo        near ptr M10_L18
       cmp       ecx,0FF
       ja        near ptr M10_L18
       mov       [rsi+1D],cl
       mov       rax,rsi
M10_L07:
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
M10_L08:
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
M10_L09:
       jmp       near ptr M10_L03
M10_L10:
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
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M10_L01
M10_L11:
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
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M10_L02
M10_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       mov       r15,[rbx+8]
       test      rsi,rsi
       jne       short M10_L13
       mov       rsi,[rbx+10]
M10_L13:
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
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M10_L05
M10_L14:
       mov       ecx,869
       mov       rdx,7FFC136BF178
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC13717F60]
       int       3
M10_L15:
       mov       rax,rbx
       jmp       near ptr M10_L07
M10_L16:
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
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M10_L06
M10_L17:
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
       call      qword ptr [7FFC135EEA60]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M10_L07
M10_L18:
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
       je        short M11_L00
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
M11_L00:
       mov       ecx,4AB
       mov       rdx,7FFC136BF178
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC13717F60]
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
       je        near ptr M12_L06
       mov       esi,[rcx+8]
       cmp       dword ptr [rcx+0C],0
       jne       short M12_L00
       add       esi,[rbx+20]
M12_L00:
       mov       rdi,[rcx]
       cmp       rdi,[rbx+10]
       je        near ptr M12_L07
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rbx,[rbx+8]
       test      rdi,rdi
       je        near ptr M12_L08
       test      rbx,rbx
       je        near ptr M12_L09
       mov       r14,[rbp]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax+8]
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M12_L02
       test      r15,r15
       je        short M12_L01
       mov       r13d,[rdi+18]
       mov       r12,[rdi+20]
       mov       rax,[rdi+28]
       mov       [rsp+20],rax
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__89_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [r15+18],rcx
       jne       near ptr M12_L10
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       test      rax,rax
       je        short M12_L01
       cmp       byte ptr [rax+24],0
       jne       short M12_L01
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC135EEB98]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       r12,[rsp+20]
       mov       rcx,[r12+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFC135EEB98]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r12+24],1
M12_L01:
       mov       rcx,[rdi+8]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC135EE910]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       rcx,[rdi+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC135EE910]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       byte ptr [rdi+1C],1
M12_L02:
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
       je        short M12_L05
M12_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,rbp
M12_L04:
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
M12_L05:
       mov       rdx,7FFC136F9F88
       call      qword ptr [7FFC12F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M12_L03
M12_L06:
       mov       ecx,577
       mov       rdx,7FFC136BF178
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC13717F60]
       int       3
M12_L07:
       jmp       short M12_L04
M12_L08:
       mov       ecx,4AB
       mov       rdx,7FFC136BF178
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC13717F60]
       int       3
M12_L09:
       mov       ecx,4B5
       mov       rdx,7FFC136BF178
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC13717F60]
       int       3
M12_L10:
       mov       [rsp+28],r13d
       mov       [rsp+30],r12
       mov       [rsp+38],rax
       lea       rdx,[rsp+28]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       jmp       near ptr M12_L01
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
       je        near ptr M14_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M14_L01
       test      rsi,rsi
       je        short M14_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M14_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M14_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M14_L00:
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
M14_L01:
       test      rsi,rsi
       je        short M14_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M14_L03
M14_L02:
       mov       rax,256DB860008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M14_L03:
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
M14_L04:
       call      qword ptr [7FFC1371CBA0]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M15_L00
       ret
M15_L00:
       jmp       qword ptr [7FFC12F15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       je        short M16_L00
       test      r14,r14
       je        near ptr M16_L01
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
       jo        short M16_L02
       cmp       ecx,0FF
       ja        short M16_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M16_L00:
       mov       ecx,847
       mov       rdx,7FFC136BF178
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC13717F60]
       int       3
M16_L01:
       mov       ecx,851
       mov       rdx,7FFC136BF178
       call      qword ptr [7FFC13137798]
       mov       rcx,rax
       call      qword ptr [7FFC13717F60]
       int       3
M16_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 215
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,158
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+0D0],ymm4
       vmovdqu   ymmword ptr [rsp+0F0],ymm4
       vmovdqu   ymmword ptr [rsp+110],ymm4
       vmovdqu   ymmword ptr [rsp+130],ymm4
       xor       eax,eax
       mov       [rsp+150],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L33
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L34
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rdi,rcx
       jne       near ptr M00_L35
       mov       eax,[rsi+28]
       sub       eax,[rsi+30]
M00_L00:
       test      eax,eax
       je        near ptr M00_L38
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r8,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rdi,r8
       jne       near ptr M00_L37
       xor       edi,edi
       mov       r14d,[rsi+28]
       sub       r14d,[rsi+30]
       js        near ptr M00_L36
       mov       r8d,[rbp+8]
       test      r8d,r8d
       jl        near ptr M00_L06
       cmp       r8d,r14d
       jl        near ptr M00_L06
       mov       r15,[rsi+10]
       xor       r13d,r13d
       cmp       dword ptr [rsi+28],0
       jle       short M00_L03
M00_L01:
       test      r14d,r14d
       je        short M00_L03
       cmp       r13d,[r15+8]
       jae       near ptr M00_L55
       mov       r8,r13
       shl       r8,4
       lea       r8,[r15+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M00_L02
       lea       edx,[rdi+1]
       mov       r12d,edx
       mov       r8,[r8]
       movsxd    rdx,edi
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r14d
       mov       edi,r12d
M00_L02:
       inc       r13d
       cmp       r13d,[rsi+28]
       jl        short M00_L01
M00_L03:
       test      rbp,rbp
       je        near ptr M00_L39
       lea       rsi,[rbp+10]
       mov       edi,[rbp+8]
M00_L04:
       mov       rcx,1843E800A48
       mov       rbp,[rcx]
       mov       r14,[rbp+10]
       mov       r15,[rbp+8]
       mov       r13,[rbp+18]
       xor       r12d,r12d
       xor       eax,eax
       inc       edi
M00_L05:
       dec       edi
       jne       near ptr M00_L07
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+130],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+130]
       mov       r9d,r12d
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFC136FF5D0]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rsp+130]
       vmovdqu   xmmword ptr [rsp+148],xmm0
       lea       rcx,[rsp+148]
       mov       r8,rbp
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFC136FF5E8]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableHashSet`1<System.__Canon>)
       mov       [rsp+0F0],rax
       mov       rcx,[rbx+90]
       lea       r8,[rsp+0F0]
       mov       rdx,7FFC13745050
       cmp       [rcx],ecx
       call      qword ptr [7FFC136F6370]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,158
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L06:
       mov       ecx,6
       call      qword ptr [7FFC136FF450]
       int       3
M00_L07:
       mov       [rsp+0C0],rax
       mov       r8,[rsi+rax]
       mov       [rsp+0B8],r8
       test      r8,r8
       je        short M00_L08
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FFC12E80C30
       call      qword ptr [r11]
       mov       r10d,eax
       mov       r8,[rsp+0B8]
       jmp       short M00_L09
M00_L08:
       xor       ecx,ecx
       xor       r10d,r10d
M00_L09:
       mov       [rsp+144],r10d
       cmp       [r14],r14b
       mov       rcx,r14
       cmp       qword ptr [r14+8],0
       jne       near ptr M00_L32
M00_L10:
       xor       r9d,r9d
       xor       r11d,r11d
M00_L11:
       mov       [rsp+68],r11
       test      r11,r11
       jne       near ptr M00_L41
       xor       edx,edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+110],xmm0
       mov       [rsp+110],r8
       mov       rcx,1843E800A70
       mov       rcx,[rcx]
       mov       [rsp+118],rcx
       mov       rcx,[rsp+110]
       mov       r11,[rsp+118]
M00_L12:
       test      edx,edx
       jne       near ptr M00_L28
       test      r11,r11
       je        near ptr M00_L45
       test      r13,r13
       je        near ptr M00_L53
       xor       r8d,r8d
       mov       [rsp+108],r8d
       mov       r9,[r14+8]
       test      r9,r9
       je        near ptr M00_L29
       mov       rdx,r14
       mov       r8d,[rdx+18]
       mov       r10d,[rsp+144]
       cmp       r10d,r8d
       jle       near ptr M00_L17
       mov       [rsp+0B0],rdx
       mov       r8,[rdx+10]
       mov       [rsp+0E0],rcx
       mov       [rsp+0E8],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+108]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+100]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+0E0]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC136F6208]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+100],0
       je        near ptr M00_L21
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L46
       test      rax,rax
       je        short M00_L13
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L13:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        short M00_L16
M00_L14:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+1D],cl
       mov       rdx,r14
M00_L15:
       mov       [rsp+0B0],rdx
       jmp       near ptr M00_L21
M00_L16:
       mov       ecx,eax
       jmp       short M00_L14
M00_L17:
       cmp       r10d,r8d
       jge       near ptr M00_L50
       mov       [rsp+0B0],rdx
       mov       [rsp+0E0],rcx
       mov       [rsp+0E8],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+108]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+100]
       mov       [rsp+30],rcx
       mov       rcx,r9
       lea       r8,[rsp+0E0]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC136F6208]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+100],0
       je        short M00_L21
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L48
       test      rax,rax
       je        short M00_L18
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L18:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L22
M00_L19:
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r14+1D],cl
       mov       rdx,r14
M00_L20:
       mov       r14,rdx
       mov       [rsp+0B0],r14
M00_L21:
       cmp       byte ptr [rsp+100],0
       je        near ptr M00_L52
       mov       r14,[rsp+0B0]
       test      r14,r14
       je        near ptr M00_L54
       mov       rax,[r14+10]
       movzx     edx,byte ptr [rax+1D]
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       edx,ecx
       cmp       edx,2
       jl        short M00_L23
       mov       [rsp+78],rax
       mov       rdx,rax
       mov       rcx,7FFC137E4FC8
       mov       r8,1C4BD911A18
       call      qword ptr [7FFC136F60A0]; System.Collections.Immutable.Requires.NotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String)
       mov       rdx,[rsp+78]
       mov       rcx,[rdx+10]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       ecx,edx
       js        near ptr M00_L26
       mov       rdx,r14
       mov       r14,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,r14
       call      qword ptr [7FFC136F62C8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       near ptr M00_L27
M00_L22:
       mov       ecx,eax
       jmp       near ptr M00_L19
M00_L23:
       mov       rdx,r14
       mov       rax,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       [rsp+0C8],rax
       mov       rcx,rax
       call      qword ptr [7FFC136F6298]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jne       short M00_L24
       jmp       short M00_L27
M00_L24:
       mov       rdx,[r14+8]
       mov       rcx,[rsp+0C8]
       call      qword ptr [7FFC136F6280]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jle       short M00_L25
       mov       rdx,r14
       mov       rcx,[rsp+0C8]
       call      qword ptr [7FFC136F62F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       short M00_L27
M00_L25:
       mov       rdx,r14
       mov       rcx,[rsp+0C8]
       call      qword ptr [7FFC136F62B0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       short M00_L27
M00_L26:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r14,rcx
       call      qword ptr [7FFC136F62E0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
M00_L27:
       inc       r12d
M00_L28:
       mov       rax,[rsp+0C0]
       add       rax,8
       jmp       near ptr M00_L05
M00_L29:
       mov       [rsp+58],r11
       mov       [rsp+60],rcx
       mov       dword ptr [rsp+100],1
       mov       rdx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A0],rax
       mov       r8d,[rsp+144]
       mov       [rax+18],r8d
       lea       rcx,[rax+20]
       mov       rdx,[rsp+60]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       lea       rcx,[rax+28]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0A0]
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsp+0A0]
       mov       byte ptr [r8+1C],0
       movzx     ecx,byte ptr [r14+1D]
       add       ecx,1
       jo        near ptr M00_L56
       cmp       ecx,0FF
       ja        near ptr M00_L56
       mov       [r8+1D],cl
       mov       r14,r8
       jmp       near ptr M00_L27
M00_L30:
       mov       rcx,[rcx+8]
M00_L31:
       cmp       qword ptr [rcx+8],0
       je        near ptr M00_L10
       mov       r10d,[rsp+144]
M00_L32:
       mov       edx,[rcx+18]
       cmp       r10d,edx
       je        near ptr M00_L40
       jle       short M00_L30
       mov       rcx,[rcx+10]
       jmp       short M00_L31
M00_L33:
       call      qword ptr [7FFC134DEFA0]
       mov       ecx,65
       mov       rdx,7FFC13350598
       call      qword ptr [7FFC13157798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC13204F28
       call      qword ptr [7FFC13157798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F37840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13350598
       call      qword ptr [7FFC13157798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F37840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136FCFA8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136FCFC0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rbp,rax
       jmp       near ptr M00_L03
M00_L35:
       mov       rcx,rsi
       mov       r11,7FFC12E80C20
       call      qword ptr [r11]
       jmp       near ptr M00_L00
M00_L36:
       mov       ecx,28F
       mov       rdx,7FFC12E74000
       call      qword ptr [7FFC13157798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFC136FD2C0]
       int       3
M00_L37:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFC12E80C28
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L38:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1843E800B00
       mov       rbp,[rcx]
       jmp       near ptr M00_L03
M00_L39:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L04
M00_L40:
       mov       r9,[rcx+20]
       mov       r11,[rcx+28]
       jmp       near ptr M00_L11
M00_L41:
       mov       rcx,r15
       mov       [rsp+70],r9
       mov       r8,r9
       mov       rdx,[rsp+0B8]
       mov       r11,7FFC12E80C38
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L42
       mov       [rsp+20],r15
       mov       r11,[rsp+68]
       mov       r9d,[r11+20]
       mov       [rsp+68],r11
       mov       rcx,r11
       mov       rdx,[rsp+0B8]
       xor       r8d,r8d
       call      qword ptr [7FFC136FF348]
       test      eax,eax
       jl        short M00_L43
M00_L42:
       mov       ecx,1
       mov       rax,[rsp+70]
       mov       r10,[rsp+68]
       mov       edx,ecx
       mov       rcx,rax
       mov       r11,r10
       jmp       near ptr M00_L12
M00_L43:
       xor       edx,edx
       mov       [rsp+140],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+120],xmm0
       mov       rcx,[rsp+68]
       mov       rdx,[rsp+0B8]
       call      qword ptr [7FFC136FF360]
       mov       rcx,[rsp+70]
       mov       [rsp+120],rcx
       test      rax,rax
       jne       short M00_L44
       mov       rax,1843E800A70
       mov       rax,[rax]
M00_L44:
       mov       [rsp+128],rax
       mov       rcx,[rsp+120]
       mov       rax,rcx
       mov       r11,[rsp+128]
       mov       r10,r11
       mov       rcx,rax
       mov       r11,r10
       mov       edx,[rsp+140]
       jmp       near ptr M00_L12
M00_L45:
       mov       r10d,[rsp+144]
       lea       r8,[rsp+108]
       mov       rcx,r14
       mov       edx,r10d
       call      qword ptr [7FFC136FF5B8]
       mov       r14,rax
       jmp       near ptr M00_L27
M00_L46:
       mov       edx,[r14+18]
       mov       [rsp+0FC],edx
       mov       r8,[r14+20]
       mov       [rsp+50],r8
       mov       r10,[r14+28]
       mov       [rsp+48],r10
       mov       r9,[r14+8]
       mov       [rsp+98],r9
       test      rax,rax
       mov       [rsp+90],rax
       jne       short M00_L47
       mov       rax,[r14+10]
       mov       [rsp+90],rax
M00_L47:
       mov       r14,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rsp+50]
       mov       [rsp+0E0],r8
       mov       r8,[rsp+48]
       mov       [rsp+0E8],r8
       mov       r8,[rsp+90]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0E0]
       mov       edx,[rsp+0FC]
       mov       rcx,r14
       mov       r9,[rsp+98]
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,r14
       jmp       near ptr M00_L15
M00_L48:
       mov       edx,[r14+18]
       mov       [rsp+0F8],edx
       mov       r8,[r14+20]
       mov       [rsp+40],r8
       mov       r10,[r14+28]
       mov       [rsp+38],r10
       test      rax,rax
       mov       [rsp+88],rax
       jne       short M00_L49
       mov       rax,[r14+8]
       mov       [rsp+88],rax
M00_L49:
       mov       r14,[r14+10]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r9,rcx
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+80],rax
       mov       r8,[rsp+40]
       mov       [rsp+0E0],r8
       mov       r8,[rsp+38]
       mov       [rsp+0E8],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0E0]
       mov       edx,[rsp+0F8]
       mov       rcx,[rsp+80]
       mov       r9,[rsp+88]
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+80]
       mov       rdx,r14
       jmp       near ptr M00_L20
M00_L50:
       vmovdqu   xmm0,xmmword ptr [r14+20]
       vmovdqu   xmmword ptr [rsp+0E0],xmm0
       mov       [rsp+60],rcx
       mov       [rsp+0D0],rcx
       mov       [rsp+58],r11
       mov       [rsp+0D8],r11
       lea       r8,[rsp+0D0]
       lea       rdx,[rsp+0E0]
       mov       rcx,r13
       mov       r11,7FFC12E80C40
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L51
       xor       ecx,ecx
       mov       [rsp+100],ecx
       jmp       near ptr M00_L27
M00_L51:
       mov       dword ptr [rsp+100],1
       mov       dword ptr [rsp+108],1
       mov       r9,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rax,r9
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A8],rax
       mov       r10,[rsp+60]
       mov       [rsp+0E0],r10
       mov       r11,[rsp+58]
       mov       [rsp+0E8],r11
       mov       r8,[r14+10]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+0E0]
       mov       r9,[r14+8]
       mov       edx,[rsp+144]
       mov       rcx,rax
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0A8]
       mov       [rsp+0B0],r14
       jmp       near ptr M00_L21
M00_L52:
       mov       r14,[rsp+0B0]
       jmp       near ptr M00_L27
M00_L53:
       mov       ecx,511
       mov       rdx,7FFC13722DE8
       call      qword ptr [7FFC13157798]
       mov       rcx,rax
       call      qword ptr [7FFC136FF2E8]
       int       3
M00_L54:
       mov       ecx,869
       mov       rdx,7FFC13722DE8
       call      qword ptr [7FFC13157798]
       mov       rcx,rax
       call      qword ptr [7FFC136FF2E8]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 2935
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
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       jne       short M02_L03
M02_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFC72BA40D0
M02_L01:
       call      qword ptr [7FFC136FC6F0]
       int       3
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M02_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFC12F3D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r9d
       test      r8,r8
       je        short M03_L00
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
M03_L00:
       mov       ecx,4AB
       mov       rdx,7FFC13722DE8
       call      qword ptr [7FFC13157798]
       mov       rcx,rax
       call      qword ptr [7FFC136FF2E8]
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
       je        near ptr M04_L06
       mov       esi,[rcx+8]
       cmp       dword ptr [rcx+0C],0
       jne       short M04_L00
       add       esi,[rbx+20]
M04_L00:
       mov       rdi,[rcx]
       cmp       rdi,[rbx+10]
       je        near ptr M04_L07
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rbx,[rbx+8]
       test      rdi,rdi
       je        near ptr M04_L08
       test      rbx,rbx
       je        near ptr M04_L09
       mov       r14,[rbp]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax+8]
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M04_L02
       test      r15,r15
       je        short M04_L01
       mov       r13d,[rdi+18]
       mov       r12,[rdi+20]
       mov       rax,[rdi+28]
       mov       [rsp+20],rax
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__89_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [r15+18],rcx
       jne       near ptr M04_L10
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       test      rax,rax
       je        short M04_L01
       cmp       byte ptr [rax+24],0
       jne       short M04_L01
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC136F6358]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       r12,[rsp+20]
       mov       rcx,[r12+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFC136F6358]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r12+24],1
M04_L01:
       mov       rcx,[rdi+8]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC136F60D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       rcx,[rdi+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC136F60D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       byte ptr [rdi+1C],1
M04_L02:
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
       je        short M04_L05
M04_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,rbp
M04_L04:
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
M04_L05:
       mov       rdx,7FFC137D4128
       call      qword ptr [7FFC12F3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M04_L03
M04_L06:
       mov       ecx,577
       mov       rdx,7FFC13722DE8
       call      qword ptr [7FFC13157798]
       mov       rcx,rax
       call      qword ptr [7FFC136FF2E8]
       int       3
M04_L07:
       jmp       short M04_L04
M04_L08:
       mov       ecx,4AB
       mov       rdx,7FFC13722DE8
       call      qword ptr [7FFC13157798]
       mov       rcx,rax
       call      qword ptr [7FFC136FF2E8]
       int       3
M04_L09:
       mov       ecx,4B5
       mov       rdx,7FFC13722DE8
       call      qword ptr [7FFC13157798]
       mov       rcx,rax
       call      qword ptr [7FFC136FF2E8]
       int       3
M04_L10:
       mov       [rsp+28],r13d
       mov       [rsp+30],r12
       mov       [rsp+38],rax
       lea       rdx,[rsp+28]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       jmp       near ptr M04_L01
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
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M06_L00:
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
       je        near ptr M06_L11
       mov       r13,rbx
       cmp       edi,[r13+18]
       jg        near ptr M06_L03
       cmp       edi,[r13+18]
       jge       near ptr M06_L16
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFC136F6208]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        short M06_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L14
       test      rsi,rsi
       je        short M06_L01
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M06_L01:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L23
       cmp       ecx,0FF
       ja        near ptr M06_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M06_L02:
       cmp       byte ptr [r14],0
       je        near ptr M06_L21
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M06_L22
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jl        near ptr M06_L06
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M06_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       js        near ptr M06_L09
       mov       rdx,r13
       call      qword ptr [7FFC136F62C8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M06_L10
M06_L03:
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFC136F6208]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        near ptr M06_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L12
       test      rdi,rdi
       je        short M06_L04
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M06_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L23
       cmp       ecx,0FF
       ja        near ptr M06_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M06_L05:
       jmp       near ptr M06_L02
M06_L06:
       cmp       edx,0FFFFFFFE
       jle       short M06_L07
       mov       rax,r13
       jmp       short M06_L10
M06_L07:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M06_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M06_L08
       mov       rdx,r13
       call      qword ptr [7FFC136F62F8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M06_L10
M06_L08:
       mov       rdx,r13
       call      qword ptr [7FFC136F62B0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M06_L10
M06_L09:
       mov       rdx,r13
       call      qword ptr [7FFC136F62E0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M06_L10:
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
M06_L11:
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
       jo        near ptr M06_L23
       cmp       eax,0FF
       ja        near ptr M06_L23
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
M06_L12:
       mov       r13d,[rbx+18]
       mov       rsi,[rbx+20]
       mov       rbp,[rbx+28]
       mov       r15,[rbx+8]
       test      rdi,rdi
       jne       short M06_L13
       mov       rdi,[rbx+10]
M06_L13:
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
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M06_L05
M06_L14:
       mov       r13d,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r15,[rbx+28]
       test      rsi,rsi
       jne       short M06_L15
       mov       rsi,[rbx+8]
M06_L15:
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
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M06_L02
M06_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M06_L17
       jmp       short M06_L18
M06_L17:
       mov       rdx,7FFC137AEFD0
       call      qword ptr [7FFC12F3C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M06_L18:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rdx,[rsp+50]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M06_L19
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
M06_L19:
       cmp       byte ptr [rsp+0D0],0
       je        short M06_L20
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
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L02
M06_L20:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFC136FF300]
       mov       r15,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFC136FF318]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFC13285F98]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M06_L21:
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
M06_L22:
       mov       ecx,869
       mov       rdx,7FFC13722DE8
       call      qword ptr [7FFC13157798]
       mov       rcx,rax
       call      qword ptr [7FFC136FF2E8]
       int       3
M06_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1145
```
```assembly
; System.Collections.Immutable.Requires.NotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String)
       sub       rsp,28
       test      rdx,rdx
       je        short M07_L00
       add       rsp,28
       ret
M07_L00:
       mov       rcx,r8
       call      qword ptr [7FFC136FF2E8]
       int       3
; Total bytes of code 24
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
       je        near ptr M08_L02
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M08_L03
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M08_L04
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
       jo        near ptr M08_L06
       cmp       ecx,0FF
       ja        near ptr M08_L06
       mov       [rbx+1D],cl
M08_L00:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M08_L05
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
       jo        near ptr M08_L06
       cmp       ecx,0FF
       ja        near ptr M08_L06
       mov       [rsi+1D],cl
       mov       rax,rsi
M08_L01:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L02:
       mov       ecx,869
       mov       rdx,7FFC13722DE8
       call      qword ptr [7FFC13157798]
       mov       rcx,rax
       call      qword ptr [7FFC136FF2E8]
       int       3
M08_L03:
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
M08_L04:
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
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M08_L00
M08_L05:
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
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M08_L01
M08_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 419
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M09_L00
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
M09_L00:
       mov       ecx,869
       mov       rdx,7FFC13722DE8
       call      qword ptr [7FFC13157798]
       mov       rcx,rax
       call      qword ptr [7FFC136FF2E8]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M10_L00
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rdx+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       eax,ecx
       add       rsp,28
       ret
M10_L00:
       mov       ecx,869
       mov       rdx,7FFC13722DE8
       call      qword ptr [7FFC13157798]
       mov       rcx,rax
       call      qword ptr [7FFC136FF2E8]
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
       je        near ptr M11_L14
       mov       rsi,[rbx+8]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M11_L08
       test      rsi,rsi
       je        near ptr M11_L14
       mov       rbp,[rsi+10]
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M11_L09
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M11_L10
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rdi+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M11_L18
       cmp       ecx,0FF
       ja        near ptr M11_L18
       mov       [rsi+1D],cl
M11_L00:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M11_L11
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
       jo        near ptr M11_L18
       cmp       ecx,0FF
       ja        near ptr M11_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M11_L01:
       mov       rsi,rdx
M11_L02:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M11_L12
       test      rsi,rsi
       je        short M11_L03
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M11_L03:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M11_L18
       cmp       ecx,0FF
       ja        near ptr M11_L18
       mov       [rbx+1D],cl
M11_L04:
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M11_L15
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M11_L16
       test      rbp,rbp
       je        short M11_L05
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M11_L05:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M11_L18
       cmp       ecx,0FF
       ja        near ptr M11_L18
       mov       [rbx+1D],cl
M11_L06:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M11_L17
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
       jo        near ptr M11_L18
       cmp       ecx,0FF
       ja        near ptr M11_L18
       mov       [rdi+1D],cl
       mov       rax,rdi
M11_L07:
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
M11_L08:
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
M11_L09:
       jmp       near ptr M11_L02
M11_L10:
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
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M11_L00
M11_L11:
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
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M11_L01
M11_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       test      rsi,rsi
       jne       short M11_L13
       mov       rsi,[rbx+8]
M11_L13:
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
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M11_L04
M11_L14:
       mov       ecx,869
       mov       rdx,7FFC13722DE8
       call      qword ptr [7FFC13157798]
       mov       rcx,rax
       call      qword ptr [7FFC136FF2E8]
       int       3
M11_L15:
       mov       rax,rbx
       jmp       near ptr M11_L07
M11_L16:
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
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M11_L06
M11_L17:
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
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M11_L07
M11_L18:
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
       je        near ptr M12_L03
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M12_L04
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M12_L05
       test      rbp,rbp
       je        short M12_L00
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M12_L00:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M12_L07
       cmp       ecx,0FF
       ja        near ptr M12_L07
       mov       [rbx+1D],cl
M12_L01:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M12_L06
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
       jo        near ptr M12_L07
       cmp       ecx,0FF
       ja        near ptr M12_L07
       mov       [rdi+1D],cl
       mov       rax,rdi
M12_L02:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M12_L03:
       mov       ecx,869
       mov       rdx,7FFC13722DE8
       call      qword ptr [7FFC13157798]
       mov       rcx,rax
       call      qword ptr [7FFC136FF2E8]
       int       3
M12_L04:
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
M12_L05:
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
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M12_L01
M12_L06:
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
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M12_L02
M12_L07:
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
       je        near ptr M13_L14
       mov       rsi,[rbx+10]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M13_L08
       test      rsi,rsi
       je        near ptr M13_L14
       cmp       qword ptr [rdi+8],0
       je        near ptr M13_L09
       mov       rbp,rdi
       mov       rdx,[rbp+10]
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M13_L10
       test      r14,r14
       je        short M13_L00
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M13_L00:
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M13_L18
       cmp       ecx,0FF
       ja        near ptr M13_L18
       mov       [rsi+1D],cl
M13_L01:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M13_L11
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
       jo        near ptr M13_L18
       cmp       ecx,0FF
       ja        near ptr M13_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M13_L02:
       mov       rsi,rdx
M13_L03:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M13_L12
       test      rsi,rsi
       je        short M13_L04
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M13_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M13_L18
       cmp       ecx,0FF
       ja        near ptr M13_L18
       mov       [rbx+1D],cl
M13_L05:
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M13_L15
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M13_L16
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
       jo        near ptr M13_L18
       cmp       ecx,0FF
       ja        near ptr M13_L18
       mov       [rbx+1D],cl
M13_L06:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M13_L17
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
       jo        near ptr M13_L18
       cmp       ecx,0FF
       ja        near ptr M13_L18
       mov       [rsi+1D],cl
       mov       rax,rsi
M13_L07:
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
M13_L08:
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
M13_L09:
       jmp       near ptr M13_L03
M13_L10:
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
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M13_L01
M13_L11:
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
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M13_L02
M13_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       mov       r15,[rbx+8]
       test      rsi,rsi
       jne       short M13_L13
       mov       rsi,[rbx+10]
M13_L13:
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
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M13_L05
M13_L14:
       mov       ecx,869
       mov       rdx,7FFC13722DE8
       call      qword ptr [7FFC13157798]
       mov       rcx,rax
       call      qword ptr [7FFC136FF2E8]
       int       3
M13_L15:
       mov       rax,rbx
       jmp       near ptr M13_L07
M13_L16:
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
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M13_L06
M13_L17:
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
       call      qword ptr [7FFC136F6220]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M13_L07
M13_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 943
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
       je        near ptr M14_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M14_L01
       test      rsi,rsi
       je        short M14_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M14_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M14_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M14_L00:
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
M14_L01:
       test      rsi,rsi
       je        short M14_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M14_L03
M14_L02:
       mov       rax,1C4BD900008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M14_L03:
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
M14_L04:
       call      qword ptr [7FFC136FED78]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M15_L00
       ret
M15_L00:
       jmp       qword ptr [7FFC12F35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       je        short M16_L00
       test      r14,r14
       je        near ptr M16_L01
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
       jo        short M16_L02
       cmp       ecx,0FF
       ja        short M16_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M16_L00:
       mov       ecx,847
       mov       rdx,7FFC13722DE8
       call      qword ptr [7FFC13157798]
       mov       rcx,rax
       call      qword ptr [7FFC136FF2E8]
       int       3
M16_L01:
       mov       ecx,851
       mov       rdx,7FFC13722DE8
       call      qword ptr [7FFC13157798]
       mov       rcx,rax
       call      qword ptr [7FFC136FF2E8]
       int       3
M16_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 215
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,188
       xor       eax,eax
       mov       [rsp+0F8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+100],ymm4
       vmovdqu   ymmword ptr [rsp+120],ymm4
       vmovdqu   ymmword ptr [rsp+140],ymm4
       vmovdqu   ymmword ptr [rsp+160],ymm4
       mov       [rsp+180],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L36
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L37
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rdi,rcx
       jne       near ptr M00_L38
       mov       eax,[rsi+28]
       sub       eax,[rsi+30]
M00_L00:
       test      eax,eax
       je        near ptr M00_L41
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r8,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rdi,r8
       jne       near ptr M00_L40
       xor       edi,edi
       mov       r14d,[rsi+28]
       sub       r14d,[rsi+30]
       js        near ptr M00_L39
       mov       r8d,[rbp+8]
       test      r8d,r8d
       jl        near ptr M00_L05
       cmp       r8d,r14d
       jl        near ptr M00_L05
       mov       r15,[rsi+10]
       xor       r13d,r13d
       cmp       dword ptr [rsi+28],0
       jle       short M00_L03
M00_L01:
       test      r14d,r14d
       je        short M00_L03
       cmp       r13d,[r15+8]
       jae       near ptr M00_L61
       mov       r8,r13
       shl       r8,4
       lea       r8,[r15+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M00_L02
       lea       edx,[rdi+1]
       mov       r12d,edx
       mov       r8,[r8]
       movsxd    rdx,edi
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r14d
       mov       edi,r12d
M00_L02:
       inc       r13d
       cmp       r13d,[rsi+28]
       jl        short M00_L01
M00_L03:
       test      rbp,rbp
       je        near ptr M00_L42
       lea       rsi,[rbp+10]
       mov       edi,[rbp+8]
M00_L04:
       mov       rcx,1F7CA800A48
       mov       rbp,[rcx]
       mov       r14,[rbp+10]
       mov       r15,[rbp+8]
       mov       r13,[rbp+18]
       xor       r12d,r12d
       xor       eax,eax
       inc       edi
       jmp       near ptr M00_L31
M00_L05:
       mov       ecx,6
       call      qword ptr [7FFC137C44F8]
       int       3
M00_L06:
       mov       [rsp+0E0],rax
       mov       r8,[rsi+rax]
       mov       [rsp+0D8],r8
       test      r8,r8
       je        short M00_L07
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FFC12E50DA0
       call      qword ptr [r11]
       mov       r10d,eax
       mov       r8,[rsp+0D8]
       jmp       short M00_L08
M00_L07:
       xor       ecx,ecx
       xor       r10d,r10d
M00_L08:
       mov       [rsp+174],r10d
       cmp       [r14],r14b
       mov       rcx,r14
       cmp       qword ptr [r14+8],0
       jne       near ptr M00_L35
M00_L09:
       xor       r9d,r9d
       xor       r11d,r11d
M00_L10:
       mov       [rsp+78],r11
       test      r11,r11
       jne       near ptr M00_L44
       xor       edx,edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+140],xmm0
       mov       [rsp+140],r8
       mov       rcx,1F7CA800A70
       mov       rcx,[rcx]
       mov       [rsp+148],rcx
       mov       rcx,[rsp+140]
       mov       r11,[rsp+148]
M00_L11:
       test      edx,edx
       jne       near ptr M00_L30
       test      r11,r11
       je        near ptr M00_L48
       test      r13,r13
       je        near ptr M00_L59
       xor       r8d,r8d
       mov       [rsp+138],r8d
       mov       r9,[r14+8]
       test      r9,r9
       je        near ptr M00_L32
       mov       rdx,r14
       mov       r8d,[rdx+18]
       mov       r10d,[rsp+174]
       cmp       r10d,r8d
       jle       near ptr M00_L16
       mov       [rsp+0D0],rdx
       mov       r8,[rdx+10]
       mov       [rsp+108],rcx
       mov       [rsp+110],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+138]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+130]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+108]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D7510]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+130],0
       je        near ptr M00_L20
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L49
       test      rax,rax
       je        short M00_L12
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        short M00_L15
M00_L13:
       add       ecx,1
       jo        near ptr M00_L62
       cmp       ecx,0FF
       ja        near ptr M00_L62
       mov       [r14+1D],cl
       mov       rdx,r14
M00_L14:
       mov       [rsp+0D0],rdx
       jmp       near ptr M00_L20
M00_L15:
       mov       ecx,eax
       jmp       short M00_L13
M00_L16:
       cmp       r10d,r8d
       jge       near ptr M00_L53
       mov       [rsp+0D0],rdx
       mov       [rsp+108],rcx
       mov       [rsp+110],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+138]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+130]
       mov       [rsp+30],rcx
       mov       rcx,r9
       lea       r8,[rsp+108]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D7510]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+130],0
       je        short M00_L20
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L51
       test      rax,rax
       je        short M00_L17
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L17:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L24
M00_L18:
       add       ecx,1
       jo        near ptr M00_L62
       cmp       ecx,0FF
       ja        near ptr M00_L62
       mov       [r14+1D],cl
       mov       rdx,r14
M00_L19:
       mov       r14,rdx
       mov       [rsp+0D0],r14
M00_L20:
       cmp       byte ptr [rsp+130],0
       je        near ptr M00_L55
       mov       r14,[rsp+0D0]
       test      r14,r14
       je        near ptr M00_L60
       mov       rax,[r14+10]
       movzx     edx,byte ptr [rax+1D]
       mov       rcx,[r14+8]
       movzx     r8d,byte ptr [rcx+1D]
       mov       [rsp+0F4],r8d
       sub       edx,r8d
       cmp       edx,2
       jl        near ptr M00_L25
       mov       rdx,rax
       test      rdx,rdx
       je        near ptr M00_L60
       mov       rcx,[rdx+10]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       ecx,edx
       js        near ptr M00_L28
       cmp       qword ptr [rax+8],0
       je        near ptr M00_L56
       mov       [rsp+98],rax
       mov       rdx,[rax+8]
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L57
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+0F4]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L58
M00_L21:
       add       ecx,1
       jo        near ptr M00_L62
       cmp       ecx,0FF
       ja        near ptr M00_L62
       mov       [r14+1D],cl
       mov       rdx,r14
M00_L22:
       mov       rcx,[rsp+98]
       xor       r8d,r8d
       call      qword ptr [7FFC136D7540]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
M00_L23:
       jmp       near ptr M00_L29
M00_L24:
       mov       ecx,eax
       jmp       near ptr M00_L18
M00_L25:
       mov       rdx,r14
       mov       rax,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       [rsp+0E8],rax
       mov       rcx,rax
       call      qword ptr [7FFC136D75A0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jne       short M00_L26
       jmp       short M00_L29
M00_L26:
       mov       rdx,[r14+8]
       mov       rcx,[rsp+0E8]
       call      qword ptr [7FFC136D7588]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jle       short M00_L27
       mov       rdx,r14
       mov       rcx,[rsp+0E8]
       call      qword ptr [7FFC136D7600]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       short M00_L29
M00_L27:
       mov       rdx,r14
       mov       rcx,[rsp+0E8]
       call      qword ptr [7FFC136D75D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       short M00_L29
M00_L28:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r14,rcx
       call      qword ptr [7FFC136D75B8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
M00_L29:
       inc       r12d
M00_L30:
       mov       rax,[rsp+0E0]
       add       rax,8
M00_L31:
       dec       edi
       jne       near ptr M00_L06
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+160],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+160]
       mov       r9d,r12d
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFC137C4720]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rsp+160]
       vmovdqu   xmmword ptr [rsp+178],xmm0
       lea       rcx,[rsp+178]
       mov       r8,rbp
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFC137C4738]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableHashSet`1<System.__Canon>)
       mov       [rsp+118],rax
       mov       rcx,[rbx+90]
       lea       r8,[rsp+118]
       mov       rdx,7FFC13725F48
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D7678]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L32:
       mov       [rsp+68],r11
       mov       [rsp+70],rcx
       mov       dword ptr [rsp+130],1
       mov       rdx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0C0],rax
       mov       r8,[rsp+70]
       mov       [rsp+108],r8
       mov       r8,[rsp+68]
       mov       [rsp+110],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+108]
       mov       edx,[rsp+174]
       mov       rcx,rax
       mov       r9,r14
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0C0]
       jmp       near ptr M00_L29
M00_L33:
       mov       rcx,[rcx+10]
M00_L34:
       cmp       qword ptr [rcx+8],0
       je        near ptr M00_L09
       mov       r10d,[rsp+174]
M00_L35:
       mov       edx,[rcx+18]
       cmp       r10d,edx
       je        near ptr M00_L43
       jg        short M00_L33
       mov       rcx,[rcx+8]
       jmp       short M00_L34
M00_L36:
       call      qword ptr [7FFC134AEFA0]
       mov       ecx,65
       mov       rdx,7FFC13320598
       call      qword ptr [7FFC13127798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131D4F28
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13320598
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC136DE970]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC136DE988]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L37:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rbp,rax
       jmp       near ptr M00_L03
M00_L38:
       mov       rcx,rsi
       mov       r11,7FFC12E50D90
       call      qword ptr [r11]
       jmp       near ptr M00_L00
M00_L39:
       mov       ecx,28F
       mov       rdx,7FFC12E44000
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFC136DD278]
       int       3
M00_L40:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFC12E50D98
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L41:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F7CA800B60
       mov       rbp,[rcx]
       jmp       near ptr M00_L03
M00_L42:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L04
M00_L43:
       mov       r9,[rcx+20]
       mov       r11,[rcx+28]
       jmp       near ptr M00_L10
M00_L44:
       mov       rcx,r15
       mov       [rsp+80],r9
       mov       r8,r9
       mov       rdx,[rsp+0D8]
       mov       r11,7FFC12E50DA8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L45
       mov       [rsp+20],r15
       mov       r11,[rsp+78]
       mov       r9d,[r11+20]
       mov       [rsp+78],r11
       mov       rcx,r11
       mov       rdx,[rsp+0D8]
       xor       r8d,r8d
       call      qword ptr [7FFC137C43D8]
       test      eax,eax
       jl        short M00_L46
M00_L45:
       mov       ecx,1
       mov       rax,[rsp+80]
       mov       r10,[rsp+78]
       mov       edx,ecx
       mov       rcx,rax
       mov       r11,r10
       jmp       near ptr M00_L11
M00_L46:
       xor       edx,edx
       mov       [rsp+170],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+150],xmm0
       mov       rcx,[rsp+78]
       mov       rdx,[rsp+0D8]
       call      qword ptr [7FFC137C43F0]
       mov       rcx,[rsp+80]
       mov       [rsp+150],rcx
       test      rax,rax
       jne       short M00_L47
       mov       rax,1F7CA800A70
       mov       rax,[rax]
M00_L47:
       mov       [rsp+158],rax
       mov       rcx,[rsp+150]
       mov       rax,rcx
       mov       r11,[rsp+158]
       mov       r10,r11
       mov       rcx,rax
       mov       r11,r10
       mov       edx,[rsp+170]
       jmp       near ptr M00_L11
M00_L48:
       mov       r10d,[rsp+174]
       lea       r8,[rsp+138]
       mov       rcx,r14
       mov       edx,r10d
       call      qword ptr [7FFC137C4708]
       mov       r14,rax
       jmp       near ptr M00_L29
M00_L49:
       mov       edx,[r14+18]
       mov       [rsp+12C],edx
       mov       r8,[r14+20]
       mov       [rsp+60],r8
       mov       r10,[r14+28]
       mov       [rsp+58],r10
       mov       r9,[r14+8]
       mov       [rsp+0B8],r9
       test      rax,rax
       mov       [rsp+0B0],rax
       jne       short M00_L50
       mov       rax,[r14+10]
       mov       [rsp+0B0],rax
M00_L50:
       mov       r14,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rsp+60]
       mov       [rsp+108],r8
       mov       r8,[rsp+58]
       mov       [rsp+110],r8
       mov       r8,[rsp+0B0]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+108]
       mov       edx,[rsp+12C]
       mov       rcx,r14
       mov       r9,[rsp+0B8]
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,r14
       jmp       near ptr M00_L14
M00_L51:
       mov       edx,[r14+18]
       mov       [rsp+128],edx
       mov       r8,[r14+20]
       mov       [rsp+50],r8
       mov       r10,[r14+28]
       mov       [rsp+48],r10
       test      rax,rax
       mov       [rsp+0A8],rax
       jne       short M00_L52
       mov       rax,[r14+8]
       mov       [rsp+0A8],rax
M00_L52:
       mov       r14,[r14+10]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r9,rcx
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A0],rax
       mov       r8,[rsp+50]
       mov       [rsp+108],r8
       mov       r8,[rsp+48]
       mov       [rsp+110],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+108]
       mov       edx,[rsp+128]
       mov       rcx,[rsp+0A0]
       mov       r9,[rsp+0A8]
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0A0]
       mov       rdx,r14
       jmp       near ptr M00_L19
M00_L53:
       vmovdqu   xmm0,xmmword ptr [r14+20]
       vmovdqu   xmmword ptr [rsp+108],xmm0
       mov       [rsp+70],rcx
       mov       [rsp+0F8],rcx
       mov       [rsp+68],r11
       mov       [rsp+100],r11
       lea       r8,[rsp+0F8]
       lea       rdx,[rsp+108]
       mov       rcx,r13
       mov       r11,7FFC12E50DB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L54
       xor       ecx,ecx
       mov       [rsp+130],ecx
       jmp       near ptr M00_L29
M00_L54:
       mov       dword ptr [rsp+130],1
       mov       dword ptr [rsp+138],1
       mov       r9,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rax,r9
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0C8],rax
       mov       r10,[rsp+70]
       mov       [rsp+108],r10
       mov       r11,[rsp+68]
       mov       [rsp+110],r11
       mov       r8,[r14+10]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+108]
       mov       r9,[r14+8]
       mov       edx,[rsp+174]
       mov       rcx,rax
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0C8]
       mov       [rsp+0D0],r14
       jmp       near ptr M00_L20
M00_L55:
       mov       r14,[rsp+0D0]
       jmp       near ptr M00_L29
M00_L56:
       jmp       near ptr M00_L23
M00_L57:
       mov       r8d,[r14+18]
       mov       [rsp+124],r8d
       mov       r10,[r14+20]
       mov       [rsp+40],r10
       mov       r9,[r14+28]
       mov       [rsp+38],r9
       mov       r14,[r14+8]
       mov       [rsp+90],rdx
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r11,rcx
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+88],rax
       mov       r8,[rsp+40]
       mov       [rsp+108],r8
       mov       r8,[rsp+38]
       mov       [rsp+110],r8
       mov       r8,[rsp+90]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+108]
       mov       edx,[rsp+124]
       mov       rcx,[rsp+88]
       mov       r9,r14
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+88]
       mov       rdx,r14
       jmp       near ptr M00_L22
M00_L58:
       mov       ecx,eax
       jmp       near ptr M00_L21
M00_L59:
       mov       ecx,511
       mov       rdx,7FFC13703B28
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC137C4378]
       int       3
M00_L60:
       mov       ecx,869
       mov       rdx,7FFC13703B28
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC137C4378]
       int       3
M00_L61:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L62:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 3143
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
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       jne       short M02_L03
M02_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFC72BA40D0
M02_L01:
       call      qword ptr [7FFC136D7F00]
       int       3
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M02_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFC12F0D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M03_L00:
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
       je        near ptr M03_L11
       mov       r13,rbx
       cmp       edi,[r13+18]
       jle       near ptr M03_L03
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D7510]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        near ptr M03_L05
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
       jmp       near ptr M03_L05
M03_L03:
       cmp       edi,[r13+18]
       jge       near ptr M03_L16
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D7510]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        short M03_L05
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
       jge       short M03_L08
       cmp       edx,0FFFFFFFE
       jle       short M03_L06
       mov       rax,r13
       jmp       short M03_L10
M03_L06:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M03_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M03_L07
       mov       rdx,r13
       call      qword ptr [7FFC136D7600]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M03_L10
M03_L07:
       mov       rdx,r13
       call      qword ptr [7FFC136D75D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M03_L10
M03_L08:
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M03_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       jns       short M03_L09
       mov       rdx,r13
       call      qword ptr [7FFC136D75B8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M03_L10
M03_L09:
       mov       rdx,r13
       call      qword ptr [7FFC136D75E8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M03_L10:
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
M03_L11:
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
       jo        near ptr M03_L23
       cmp       eax,0FF
       ja        near ptr M03_L23
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
M03_L12:
       mov       r13d,[rbx+18]
       mov       r15,[rbx+20]
       mov       rsi,[rbx+28]
       mov       rbp,[rbx+8]
       test      rdi,rdi
       jne       short M03_L13
       mov       rdi,[rbx+10]
M03_L13:
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
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M03_L02
M03_L14:
       mov       r13d,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r15,[rbx+28]
       test      rsi,rsi
       jne       short M03_L15
       mov       rsi,[rbx+8]
M03_L15:
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
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
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
       mov       rdx,7FFC137AE388
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L18:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rdx,[rsp+50]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M03_L19
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
M03_L19:
       cmp       byte ptr [rsp+0D0],0
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
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M03_L05
M03_L20:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFC137C4390]
       mov       rsi,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFC137C43A8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC13255F98]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L21:
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
M03_L22:
       mov       ecx,869
       mov       rdx,7FFC13703B28
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC137C4378]
       int       3
M03_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1134
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
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L02:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       mov       r15,rdx
       test      r15,r15
       jne       short M04_L03
       mov       r15,[rbx+8]
M04_L03:
       test      rsi,rsi
       jne       short M04_L04
       mov       rsi,[rbx+10]
M04_L04:
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
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
M04_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 245
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M05_L00
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
M05_L00:
       mov       ecx,869
       mov       rdx,7FFC13703B28
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC137C4378]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M06_L00
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rdx+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       eax,ecx
       add       rsp,28
       ret
M06_L00:
       mov       ecx,869
       mov       rdx,7FFC13703B28
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC137C4378]
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
       je        near ptr M07_L14
       mov       rsi,[rbx+8]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M07_L08
       test      rsi,rsi
       je        near ptr M07_L14
       mov       rbp,[rsi+10]
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M07_L09
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M07_L10
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rdi+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M07_L18
       cmp       ecx,0FF
       ja        near ptr M07_L18
       mov       [rsi+1D],cl
M07_L00:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M07_L11
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
       jo        near ptr M07_L18
       cmp       ecx,0FF
       ja        near ptr M07_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M07_L01:
       mov       rsi,rdx
M07_L02:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M07_L12
       test      rsi,rsi
       je        short M07_L03
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M07_L03:
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
M07_L04:
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M07_L15
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M07_L16
       test      rbp,rbp
       je        short M07_L05
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M07_L05:
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
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M07_L17
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
       jo        near ptr M07_L18
       cmp       ecx,0FF
       ja        near ptr M07_L18
       mov       [rdi+1D],cl
       mov       rax,rdi
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
       jmp       near ptr M07_L02
M07_L10:
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
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M07_L00
M07_L11:
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
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M07_L01
M07_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       test      rsi,rsi
       jne       short M07_L13
       mov       rsi,[rbx+8]
M07_L13:
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
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M07_L04
M07_L14:
       mov       ecx,869
       mov       rdx,7FFC13703B28
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC137C4378]
       int       3
M07_L15:
       mov       rax,rbx
       jmp       near ptr M07_L07
M07_L16:
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
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M07_L06
M07_L17:
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
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M07_L07
M07_L18:
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
       je        near ptr M08_L03
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M08_L04
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M08_L05
       test      rbp,rbp
       je        short M08_L00
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M08_L00:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M08_L07
       cmp       ecx,0FF
       ja        near ptr M08_L07
       mov       [rbx+1D],cl
M08_L01:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M08_L06
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
       jo        near ptr M08_L07
       cmp       ecx,0FF
       ja        near ptr M08_L07
       mov       [rdi+1D],cl
       mov       rax,rdi
M08_L02:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L03:
       mov       ecx,869
       mov       rdx,7FFC13703B28
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC137C4378]
       int       3
M08_L04:
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
M08_L05:
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
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M08_L01
M08_L06:
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
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M08_L02
M08_L07:
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
       je        near ptr M09_L14
       mov       rsi,[rbx+10]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M09_L08
       test      rsi,rsi
       je        near ptr M09_L14
       cmp       qword ptr [rdi+8],0
       je        near ptr M09_L09
       mov       rbp,rdi
       mov       rdx,[rbp+10]
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M09_L10
       test      r14,r14
       je        short M09_L00
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M09_L00:
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M09_L18
       cmp       ecx,0FF
       ja        near ptr M09_L18
       mov       [rsi+1D],cl
M09_L01:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M09_L11
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
       jo        near ptr M09_L18
       cmp       ecx,0FF
       ja        near ptr M09_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M09_L02:
       mov       rsi,rdx
M09_L03:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M09_L12
       test      rsi,rsi
       je        short M09_L04
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M09_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M09_L18
       cmp       ecx,0FF
       ja        near ptr M09_L18
       mov       [rbx+1D],cl
M09_L05:
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M09_L15
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M09_L16
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
       jo        near ptr M09_L18
       cmp       ecx,0FF
       ja        near ptr M09_L18
       mov       [rbx+1D],cl
M09_L06:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M09_L17
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
       jo        near ptr M09_L18
       cmp       ecx,0FF
       ja        near ptr M09_L18
       mov       [rsi+1D],cl
       mov       rax,rsi
M09_L07:
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
M09_L08:
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
M09_L09:
       jmp       near ptr M09_L03
M09_L10:
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
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M09_L01
M09_L11:
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
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M09_L02
M09_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       mov       r15,[rbx+8]
       test      rsi,rsi
       jne       short M09_L13
       mov       rsi,[rbx+10]
M09_L13:
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
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M09_L05
M09_L14:
       mov       ecx,869
       mov       rdx,7FFC13703B28
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC137C4378]
       int       3
M09_L15:
       mov       rax,rbx
       jmp       near ptr M09_L07
M09_L16:
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
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M09_L06
M09_L17:
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
       call      qword ptr [7FFC136D7528]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M09_L07
M09_L18:
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
       je        short M10_L00
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
M10_L00:
       mov       ecx,4AB
       mov       rdx,7FFC13703B28
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC137C4378]
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
       je        near ptr M11_L06
       mov       esi,[rcx+8]
       cmp       dword ptr [rcx+0C],0
       jne       short M11_L00
       add       esi,[rbx+20]
M11_L00:
       mov       rdi,[rcx]
       cmp       rdi,[rbx+10]
       je        near ptr M11_L07
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rbx,[rbx+8]
       test      rdi,rdi
       je        near ptr M11_L08
       test      rbx,rbx
       je        near ptr M11_L09
       mov       r14,[rbp]
       mov       rcx,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r15,[rax+8]
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M11_L02
       test      r15,r15
       je        short M11_L01
       mov       r13d,[rdi+18]
       mov       r12,[rdi+20]
       mov       rax,[rdi+28]
       mov       [rsp+20],rax
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__89_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [r15+18],rcx
       jne       near ptr M11_L10
       mov       rcx,[r15+8]
       cmp       [rcx],ecx
       test      rax,rax
       je        short M11_L01
       cmp       byte ptr [rax+24],0
       jne       short M11_L01
       mov       rcx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D7660]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       r12,[rsp+20]
       mov       rcx,[r12+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D7660]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r12+24],1
M11_L01:
       mov       rcx,[rdi+8]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D73D8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       rcx,[rdi+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC136D73D8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       byte ptr [rdi+1C],1
M11_L02:
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
       je        short M11_L05
M11_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,rbp
M11_L04:
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
M11_L05:
       mov       rdx,7FFC137E08F8
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M11_L03
M11_L06:
       mov       ecx,577
       mov       rdx,7FFC13703B28
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC137C4378]
       int       3
M11_L07:
       jmp       short M11_L04
M11_L08:
       mov       ecx,4AB
       mov       rdx,7FFC13703B28
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC137C4378]
       int       3
M11_L09:
       mov       ecx,4B5
       mov       rdx,7FFC13703B28
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC137C4378]
       int       3
M11_L10:
       mov       [rsp+28],r13d
       mov       [rsp+30],r12
       mov       [rsp+38],rax
       lea       rdx,[rsp+28]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       jmp       near ptr M11_L01
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
       mov       rdx,7FFC13703B28
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC137C4378]
       int       3
M13_L01:
       mov       ecx,851
       mov       rdx,7FFC13703B28
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC137C4378]
       int       3
M13_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 215
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
       je        near ptr M14_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M14_L01
       test      rsi,rsi
       je        short M14_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M14_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M14_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M14_L00:
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
M14_L01:
       test      rsi,rsi
       je        short M14_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M14_L03
M14_L02:
       mov       rax,238495C0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M14_L03:
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
M14_L04:
       call      qword ptr [7FFC136DF798]
       int       3
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M15_L00
       ret
M15_L00:
       jmp       qword ptr [7FFC12F05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,188
       xor       eax,eax
       mov       [rsp+0F8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+100],ymm4
       vmovdqu   ymmword ptr [rsp+120],ymm4
       vmovdqu   ymmword ptr [rsp+140],ymm4
       vmovdqu   ymmword ptr [rsp+160],ymm4
       mov       [rsp+180],rax
       mov       rbx,rcx
       mov       rsi,[rbx+2E8]
       test      rsi,rsi
       je        near ptr M00_L35
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L36
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rdi,rcx
       jne       near ptr M00_L37
       mov       eax,[rsi+28]
       sub       eax,[rsi+30]
M00_L00:
       test      eax,eax
       je        near ptr M00_L40
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       r8,offset MT_System.Collections.Generic.HashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       rdi,r8
       jne       near ptr M00_L39
       xor       edi,edi
       mov       r14d,[rsi+28]
       sub       r14d,[rsi+30]
       js        near ptr M00_L38
       mov       r8d,[rbp+8]
       test      r8d,r8d
       jl        near ptr M00_L06
       cmp       r8d,r14d
       jl        near ptr M00_L06
       mov       r15,[rsi+10]
       xor       r13d,r13d
       cmp       dword ptr [rsi+28],0
       jle       short M00_L03
M00_L01:
       test      r14d,r14d
       je        short M00_L03
       cmp       r13d,[r15+8]
       jae       near ptr M00_L61
       mov       r8,r13
       shl       r8,4
       lea       r8,[r15+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M00_L02
       lea       edx,[rdi+1]
       mov       r12d,edx
       mov       r8,[r8]
       movsxd    rdx,edi
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r14d
       mov       edi,r12d
M00_L02:
       inc       r13d
       cmp       r13d,[rsi+28]
       jl        short M00_L01
M00_L03:
       test      rbp,rbp
       je        near ptr M00_L41
       lea       rsi,[rbp+10]
       mov       edi,[rbp+8]
M00_L04:
       mov       rcx,17F92800AF0
       mov       rbp,[rcx]
       mov       r14,[rbp+10]
       mov       r15,[rbp+8]
       mov       r13,[rbp+18]
       xor       r12d,r12d
       xor       eax,eax
       inc       edi
M00_L05:
       dec       edi
       jne       near ptr M00_L07
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+160],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+160]
       mov       r9d,r12d
       mov       r8,r14
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFC13874A68]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       vmovdqu   xmm0,xmmword ptr [rsp+160]
       vmovdqu   xmmword ptr [rsp+178],xmm0
       lea       rcx,[rsp+178]
       mov       r8,rbp
       mov       rdx,offset MT_System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+MutationResult
       call      qword ptr [7FFC13874A80]; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]].Finalize(System.Collections.Immutable.ImmutableHashSet`1<System.__Canon>)
       mov       [rsp+118],rax
       mov       rcx,[rbx+90]
       lea       r8,[rsp+118]
       mov       rdx,7FFC137A8F78
       cmp       [rcx],ecx
       call      qword ptr [7FFC1371EC70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,188
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L06:
       mov       ecx,6
       call      qword ptr [7FFC135FFA68]
       int       3
M00_L07:
       mov       [rsp+0E0],rax
       mov       r8,[rsi+rax]
       mov       [rsp+0D8],r8
       test      r8,r8
       je        short M00_L08
       mov       rcx,r15
       mov       rdx,r8
       mov       r11,7FFC12E50F98
       call      qword ptr [r11]
       mov       r10d,eax
       mov       r8,[rsp+0D8]
       jmp       short M00_L09
M00_L08:
       xor       ecx,ecx
       xor       r10d,r10d
M00_L09:
       mov       [rsp+174],r10d
       cmp       [r14],r14b
       mov       rcx,r14
       cmp       qword ptr [r14+8],0
       jne       near ptr M00_L34
M00_L10:
       xor       r9d,r9d
       xor       r11d,r11d
M00_L11:
       mov       [rsp+78],r11
       test      r11,r11
       jne       near ptr M00_L43
       xor       edx,edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+140],xmm0
       mov       [rsp+140],r8
       mov       rcx,17F92800B18
       mov       rcx,[rcx]
       mov       [rsp+148],rcx
       mov       rcx,[rsp+140]
       mov       r11,[rsp+148]
M00_L12:
       test      edx,edx
       jne       near ptr M00_L31
       test      r11,r11
       je        near ptr M00_L47
       test      r13,r13
       je        near ptr M00_L59
       xor       r8d,r8d
       mov       [rsp+138],r8d
       mov       r9,[r14+8]
       test      r9,r9
       je        near ptr M00_L48
       mov       rdx,r14
       mov       r8d,[rdx+18]
       mov       r10d,[rsp+174]
       cmp       r10d,r8d
       jle       near ptr M00_L21
       mov       [rsp+0D0],rdx
       mov       r8,[rdx+10]
       mov       [rsp+108],rcx
       mov       [rsp+110],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+138]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+130]
       mov       [rsp+30],rcx
       mov       rcx,r8
       lea       r8,[rsp+108]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC1371EB08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+130],0
       je        short M00_L16
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L49
       test      rax,rax
       je        short M00_L13
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L13:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L20
M00_L14:
       add       ecx,1
       jo        near ptr M00_L62
       cmp       ecx,0FF
       ja        near ptr M00_L62
       mov       [r14+1D],cl
       mov       rdx,r14
M00_L15:
       mov       [rsp+0D0],rdx
M00_L16:
       cmp       byte ptr [rsp+130],0
       je        near ptr M00_L55
       mov       r14,[rsp+0D0]
       test      r14,r14
       je        near ptr M00_L60
       mov       rax,[r14+10]
       movzx     edx,byte ptr [rax+1D]
       mov       rcx,[r14+8]
       movzx     r8d,byte ptr [rcx+1D]
       mov       [rsp+0F4],r8d
       sub       edx,r8d
       cmp       edx,2
       jl        near ptr M00_L26
       mov       rdx,rax
       test      rdx,rdx
       je        near ptr M00_L60
       mov       rcx,[rdx+10]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       ecx,edx
       js        near ptr M00_L29
       cmp       qword ptr [rax+8],0
       je        near ptr M00_L56
       mov       [rsp+98],rax
       mov       rdx,[rax+8]
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L57
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+0F4]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        near ptr M00_L58
M00_L17:
       add       ecx,1
       jo        near ptr M00_L62
       cmp       ecx,0FF
       ja        near ptr M00_L62
       mov       [r14+1D],cl
       mov       rdx,r14
M00_L18:
       mov       rcx,[rsp+98]
       xor       r8d,r8d
       call      qword ptr [7FFC1371EB38]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Mutate(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
M00_L19:
       jmp       near ptr M00_L30
M00_L20:
       mov       ecx,eax
       jmp       near ptr M00_L14
M00_L21:
       cmp       r10d,r8d
       jge       near ptr M00_L53
       mov       [rsp+0D0],rdx
       mov       [rsp+108],rcx
       mov       [rsp+110],r11
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+138]
       mov       [rsp+28],rcx
       lea       rcx,[rsp+130]
       mov       [rsp+30],rcx
       mov       rcx,r9
       lea       r8,[rsp+108]
       mov       edx,r10d
       mov       r9,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC1371EB08]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
       cmp       byte ptr [rsp+130],0
       je        near ptr M00_L16
       cmp       byte ptr [r14+1C],0
       jne       near ptr M00_L51
       test      rax,rax
       je        short M00_L22
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L22:
       mov       rcx,[r14+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[r14+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       jl        short M00_L25
M00_L23:
       add       ecx,1
       jo        near ptr M00_L62
       cmp       ecx,0FF
       ja        near ptr M00_L62
       mov       [r14+1D],cl
       mov       rdx,r14
M00_L24:
       mov       r14,rdx
       mov       [rsp+0D0],r14
       jmp       near ptr M00_L16
M00_L25:
       mov       ecx,eax
       jmp       short M00_L23
M00_L26:
       mov       rdx,r14
       mov       rax,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       [rsp+0E8],rax
       mov       rcx,rax
       call      qword ptr [7FFC1371EB98]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jne       short M00_L27
       jmp       short M00_L30
M00_L27:
       mov       rdx,[r14+8]
       mov       rcx,[rsp+0E8]
       call      qword ptr [7FFC1371EB80]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       test      eax,eax
       jle       short M00_L28
       mov       rdx,r14
       mov       rcx,[rsp+0E8]
       call      qword ptr [7FFC1371EBC8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       short M00_L30
M00_L28:
       mov       rdx,r14
       mov       rcx,[rsp+0E8]
       call      qword ptr [7FFC1371EBE0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
       jmp       short M00_L30
M00_L29:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r14,rcx
       call      qword ptr [7FFC1371EBF8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       mov       r14,rax
M00_L30:
       inc       r12d
M00_L31:
       mov       rax,[rsp+0E0]
       add       rax,8
       jmp       near ptr M00_L05
M00_L32:
       mov       rcx,[rcx+10]
M00_L33:
       cmp       qword ptr [rcx+8],0
       je        near ptr M00_L10
       mov       r10d,[rsp+174]
M00_L34:
       mov       edx,[rcx+18]
       cmp       r10d,edx
       je        near ptr M00_L42
       jg        short M00_L32
       mov       rcx,[rcx+8]
       jmp       short M00_L33
M00_L35:
       call      qword ptr [7FFC134AF3C0]
       mov       ecx,65
       mov       rdx,7FFC13320598
       call      qword ptr [7FFC13127798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFC131D4F28
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFC13320598
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC12F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC135F70D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFC135F70F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rbp,rax
       jmp       near ptr M00_L03
M00_L37:
       mov       rcx,rsi
       mov       r11,7FFC12E50F88
       call      qword ptr [r11]
       jmp       near ptr M00_L00
M00_L38:
       mov       ecx,28F
       mov       rdx,7FFC12E44000
       call      qword ptr [7FFC13127798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFC135F5B60]
       int       3
M00_L39:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r11,7FFC12E50F90
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M00_L03
M00_L40:
       mov       rcx,offset MT_System.Array+EmptyArray<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,17F92800B68
       mov       rbp,[rcx]
       jmp       near ptr M00_L03
M00_L41:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L04
M00_L42:
       mov       r9,[rcx+20]
       mov       r11,[rcx+28]
       jmp       near ptr M00_L11
M00_L43:
       mov       rcx,r15
       mov       [rsp+80],r9
       mov       r8,r9
       mov       rdx,[rsp+0D8]
       mov       r11,7FFC12E50FA0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L44
       mov       [rsp+20],r15
       mov       r11,[rsp+78]
       mov       r9d,[r11+20]
       mov       [rsp+78],r11
       mov       rcx,r11
       mov       rdx,[rsp+0D8]
       xor       r8d,r8d
       call      qword ptr [7FFC138747F8]
       test      eax,eax
       jl        short M00_L45
M00_L44:
       mov       ecx,1
       mov       rax,[rsp+80]
       mov       r10,[rsp+78]
       mov       edx,ecx
       mov       rcx,rax
       mov       r11,r10
       jmp       near ptr M00_L12
M00_L45:
       xor       edx,edx
       mov       [rsp+170],edx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+150],xmm0
       mov       rcx,[rsp+78]
       mov       rdx,[rsp+0D8]
       call      qword ptr [7FFC13874810]
       mov       rcx,[rsp+80]
       mov       [rsp+150],rcx
       test      rax,rax
       jne       short M00_L46
       mov       rax,17F92800B18
       mov       rax,[rax]
M00_L46:
       mov       [rsp+158],rax
       mov       rcx,[rsp+150]
       mov       rax,rcx
       mov       r11,[rsp+158]
       mov       r10,r11
       mov       rcx,rax
       mov       r11,r10
       mov       edx,[rsp+170]
       jmp       near ptr M00_L12
M00_L47:
       mov       r10d,[rsp+174]
       lea       r8,[rsp+138]
       mov       rcx,r14
       mov       edx,r10d
       call      qword ptr [7FFC13874A50]
       mov       r14,rax
       jmp       near ptr M00_L30
M00_L48:
       mov       [rsp+68],r11
       mov       [rsp+70],rcx
       mov       dword ptr [rsp+130],1
       mov       rdx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0C0],rax
       mov       r8,[rsp+70]
       mov       [rsp+108],r8
       mov       r8,[rsp+68]
       mov       [rsp+110],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+108]
       mov       edx,[rsp+174]
       mov       rcx,rax
       mov       r9,r14
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0C0]
       jmp       near ptr M00_L30
M00_L49:
       mov       edx,[r14+18]
       mov       [rsp+12C],edx
       mov       r8,[r14+20]
       mov       [rsp+60],r8
       mov       r10,[r14+28]
       mov       [rsp+58],r10
       mov       r9,[r14+8]
       mov       [rsp+0B8],r9
       test      rax,rax
       mov       [rsp+0B0],rax
       jne       short M00_L50
       mov       rax,[r14+10]
       mov       [rsp+0B0],rax
M00_L50:
       mov       r14,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r8,[rsp+60]
       mov       [rsp+108],r8
       mov       r8,[rsp+58]
       mov       [rsp+110],r8
       mov       r8,[rsp+0B0]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+108]
       mov       edx,[rsp+12C]
       mov       rcx,r14
       mov       r9,[rsp+0B8]
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,r14
       jmp       near ptr M00_L15
M00_L51:
       mov       edx,[r14+18]
       mov       [rsp+128],edx
       mov       r8,[r14+20]
       mov       [rsp+50],r8
       mov       r10,[r14+28]
       mov       [rsp+48],r10
       test      rax,rax
       mov       [rsp+0A8],rax
       jne       short M00_L52
       mov       rax,[r14+8]
       mov       [rsp+0A8],rax
M00_L52:
       mov       r14,[r14+10]
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r9,rcx
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A0],rax
       mov       r8,[rsp+50]
       mov       [rsp+108],r8
       mov       r8,[rsp+48]
       mov       [rsp+110],r8
       mov       [rsp+20],r14
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+108]
       mov       edx,[rsp+128]
       mov       rcx,[rsp+0A0]
       mov       r9,[rsp+0A8]
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0A0]
       mov       rdx,r14
       jmp       near ptr M00_L24
M00_L53:
       vmovdqu   xmm0,xmmword ptr [r14+20]
       vmovdqu   xmmword ptr [rsp+108],xmm0
       mov       [rsp+70],rcx
       mov       [rsp+0F8],rcx
       mov       [rsp+68],r11
       mov       [rsp+100],r11
       lea       r8,[rsp+0F8]
       lea       rdx,[rsp+108]
       mov       rcx,r13
       mov       r11,7FFC12E50FA8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L54
       xor       ecx,ecx
       mov       [rsp+130],ecx
       jmp       near ptr M00_L30
M00_L54:
       mov       dword ptr [rsp+130],1
       mov       dword ptr [rsp+138],1
       mov       r9,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       rax,r9
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0C8],rax
       mov       r10,[rsp+70]
       mov       [rsp+108],r10
       mov       r11,[rsp+68]
       mov       [rsp+110],r11
       mov       r8,[r14+10]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+108]
       mov       r9,[r14+8]
       mov       edx,[rsp+174]
       mov       rcx,rax
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+0C8]
       mov       [rsp+0D0],r14
       jmp       near ptr M00_L16
M00_L55:
       mov       r14,[rsp+0D0]
       jmp       near ptr M00_L30
M00_L56:
       jmp       near ptr M00_L19
M00_L57:
       mov       r8d,[r14+18]
       mov       [rsp+124],r8d
       mov       r10,[r14+20]
       mov       [rsp+40],r10
       mov       r9,[r14+28]
       mov       [rsp+38],r9
       mov       r14,[r14+8]
       mov       [rsp+90],rdx
       mov       rcx,offset MT_System.Collections.Immutable.SortedInt32KeyNode<System.Collections.Immutable.ImmutableHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+HashBucket>
       mov       r11,rcx
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+88],rax
       mov       r8,[rsp+40]
       mov       [rsp+108],r8
       mov       r8,[rsp+38]
       mov       [rsp+110],r8
       mov       r8,[rsp+90]
       mov       [rsp+20],r8
       xor       r8d,r8d
       mov       [rsp+28],r8d
       lea       r8,[rsp+108]
       mov       edx,[rsp+124]
       mov       rcx,[rsp+88]
       mov       r9,r14
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r14,[rsp+88]
       mov       rdx,r14
       jmp       near ptr M00_L18
M00_L58:
       mov       ecx,eax
       jmp       near ptr M00_L17
M00_L59:
       mov       ecx,511
       mov       rdx,7FFC13786C30
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13874000]
       int       3
M00_L60:
       mov       ecx,869
       mov       rdx,7FFC13786C30
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13874000]
       int       3
M00_L61:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L62:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 3143
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
       jmp       near ptr 00007FFC72BA40D0
M02_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M02_L02:
       call      qword ptr [7FFC135F4B58]
       int       3
M02_L03:
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFC12F0D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Collections.Immutable.ImmutableHashSet`1+MutationResult[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Int32, CountType<System.__Canon>)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,r9d
       test      r8,r8
       je        short M03_L00
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
M03_L00:
       mov       ecx,4AB
       mov       rdx,7FFC13786C30
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13874000]
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
       je        near ptr M04_L06
       mov       esi,[rcx+8]
       cmp       dword ptr [rcx+0C],0
       jne       short M04_L00
       add       esi,[rbx+20]
M04_L00:
       mov       rdi,[rcx]
       cmp       rdi,[rbx+10]
       je        near ptr M04_L07
       mov       rcx,[rbx]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rbx,[rbx+8]
       test      rdi,rdi
       je        near ptr M04_L08
       test      rbx,rbx
       je        near ptr M04_L09
       mov       rcx,[rbp]
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax+8]
       cmp       byte ptr [rdi+1C],0
       jne       short M04_L02
       test      r14,r14
       je        short M04_L01
       mov       r15d,[rdi+18]
       mov       r13,[rdi+20]
       mov       r12,[rdi+28]
       mov       rcx,offset System.Collections.Immutable.ImmutableHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<.cctor>b__89_0(System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>)
       cmp       [r14+18],rcx
       jne       near ptr M04_L10
       mov       rcx,[r14+8]
       cmp       [rcx],ecx
       test      r12,r12
       je        short M04_L01
       cmp       byte ptr [r12+24],0
       jne       short M04_L01
       mov       rcx,[r12+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC1371EC58]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       rcx,[r12+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFC1371EC58]; System.Collections.Immutable.ImmutableList`1+Node[[System.__Canon, System.Private.CoreLib]].Freeze()
       mov       byte ptr [r12+24],1
M04_L01:
       mov       rcx,[rdi+8]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC1371E9D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       rcx,[rdi+10]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC1371E9D0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Freeze(System.Action`1<System.Collections.Generic.KeyValuePair`2<Int32,HashBucket<System.__Canon>>>)
       mov       byte ptr [rdi+1C],1
M04_L02:
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+20],esi
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+0B8]
       test      rdx,rdx
       je        short M04_L05
M04_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,rbp
M04_L04:
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
M04_L05:
       mov       rdx,7FFC13867EB0
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M04_L03
M04_L06:
       mov       ecx,577
       mov       rdx,7FFC13786C30
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13874000]
       int       3
M04_L07:
       jmp       short M04_L04
M04_L08:
       mov       ecx,4AB
       mov       rdx,7FFC13786C30
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13874000]
       int       3
M04_L09:
       mov       ecx,4B5
       mov       rdx,7FFC13786C30
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13874000]
       int       3
M04_L10:
       mov       [rsp+28],r15d
       mov       [rsp+30],r13
       mov       [rsp+38],r12
       lea       rdx,[rsp+28]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       jmp       near ptr M04_L01
; Total bytes of code 491
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
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].SetOrAdd(Int32, HashBucket<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<HashBucket<System.__Canon>>, Boolean, Boolean ByRef, Boolean ByRef)
M06_L00:
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
       je        near ptr M06_L11
       mov       r13,rbx
       cmp       edi,[r13+18]
       jle       near ptr M06_L03
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+10]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFC1371EB08]
       mov       rdi,rax
       cmp       byte ptr [r14],0
       je        short M06_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L12
       test      rdi,rdi
       je        short M06_L01
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M06_L01:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M06_L23
       cmp       ecx,0FF
       ja        near ptr M06_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M06_L02:
       cmp       byte ptr [r14],0
       je        near ptr M06_L21
       mov       rcx,[rbx]
       test      r13,r13
       je        near ptr M06_L22
       mov       rdx,[r13+10]
       movzx     edx,byte ptr [rdx+1D]
       mov       rax,[r13+8]
       movzx     eax,byte ptr [rax+1D]
       sub       edx,eax
       cmp       edx,2
       jl        near ptr M06_L06
       mov       rdx,[r13+10]
       test      rdx,rdx
       je        near ptr M06_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       js        near ptr M06_L09
       mov       rdx,r13
       call      qword ptr [7FFC1371EBB0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       near ptr M06_L10
M06_L03:
       cmp       edi,[r13+18]
       jge       near ptr M06_L16
       movzx     ecx,byte ptr [rsp+0D0]
       mov       [rsp+20],ecx
       mov       [rsp+28],r15
       mov       [rsp+30],r14
       mov       rcx,[r13+8]
       mov       edx,edi
       mov       r8,rsi
       mov       r9,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFC1371EB08]
       mov       rsi,rax
       cmp       byte ptr [r14],0
       je        near ptr M06_L02
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M06_L14
       test      rsi,rsi
       je        short M06_L04
       lea       rcx,[rbx+8]
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
       jo        near ptr M06_L23
       cmp       ecx,0FF
       ja        near ptr M06_L23
       mov       [rbx+1D],cl
       mov       r13,rbx
M06_L05:
       jmp       near ptr M06_L02
M06_L06:
       cmp       edx,0FFFFFFFE
       jle       short M06_L07
       mov       rax,r13
       jmp       short M06_L10
M06_L07:
       mov       rdx,[r13+8]
       test      rdx,rdx
       je        near ptr M06_L22
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rdx,[rdx+8]
       movzx     edx,byte ptr [rdx+1D]
       sub       eax,edx
       test      eax,eax
       jle       short M06_L08
       mov       rdx,r13
       call      qword ptr [7FFC1371EBC8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M06_L10
M06_L08:
       mov       rdx,r13
       call      qword ptr [7FFC1371EBE0]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].RotateRight(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       jmp       short M06_L10
M06_L09:
       mov       rdx,r13
       call      qword ptr [7FFC1371EBF8]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].DoubleLeft(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
M06_L10:
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
M06_L11:
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
       jo        near ptr M06_L23
       cmp       eax,0FF
       ja        near ptr M06_L23
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
M06_L12:
       mov       r13d,[rbx+18]
       mov       r15,[rbx+20]
       mov       rsi,[rbx+28]
       mov       rbp,[rbx+8]
       test      rdi,rdi
       jne       short M06_L13
       mov       rdi,[rbx+10]
M06_L13:
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
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M06_L02
M06_L14:
       mov       r13d,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r15,[rbx+28]
       test      rsi,rsi
       jne       short M06_L15
       mov       rsi,[rbx+8]
M06_L15:
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
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       r13,r12
       jmp       near ptr M06_L05
M06_L16:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        short M06_L17
       jmp       short M06_L18
M06_L17:
       mov       rdx,7FFC138606D8
       call      qword ptr [7FFC12F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M06_L18:
       vmovdqu   xmm0,xmmword ptr [rbx+20]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       lea       rdx,[rsp+50]
       lea       r8,[rsp+40]
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       je        short M06_L19
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
M06_L19:
       cmp       byte ptr [rsp+0D0],0
       je        short M06_L20
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
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M06_L02
M06_L20:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFC13874018]
       mov       rsi,rax
       mov       [r14+8],edi
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      qword ptr [7FFC13874030]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFC13255F98]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M06_L21:
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
M06_L22:
       mov       ecx,869
       mov       rdx,7FFC13786C30
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13874000]
       int       3
M06_L23:
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
       jne       short M07_L02
       test      rdx,rdx
       je        short M07_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M07_L00:
       test      rsi,rsi
       je        short M07_L01
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M07_L01:
       mov       rax,[rbx+8]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rbx+10]
       movzx     ecx,byte ptr [rcx+1D]
       cmp       eax,ecx
       cmovl     eax,ecx
       add       eax,1
       jo        near ptr M07_L05
       cmp       eax,0FF
       ja        near ptr M07_L05
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
M07_L02:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       mov       r15,rdx
       test      r15,r15
       jne       short M07_L03
       mov       r15,[rbx+8]
M07_L03:
       test      rsi,rsi
       jne       short M07_L04
       mov       rsi,[rbx+10]
M07_L04:
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
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
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
M07_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 245
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].IsLeftHeavy(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M08_L00
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
M08_L00:
       mov       ecx,869
       mov       rdx,7FFC13786C30
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13874000]
       int       3
; Total bytes of code 72
```
```assembly
; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]].Balance(System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>)
       sub       rsp,28
       test      rdx,rdx
       je        short M09_L00
       mov       rax,[rdx+10]
       movzx     eax,byte ptr [rax+1D]
       mov       rcx,[rdx+8]
       movzx     ecx,byte ptr [rcx+1D]
       sub       eax,ecx
       add       rsp,28
       ret
M09_L00:
       mov       ecx,869
       mov       rdx,7FFC13786C30
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13874000]
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
       je        near ptr M10_L14
       mov       rsi,[rbx+8]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M10_L08
       test      rsi,rsi
       je        near ptr M10_L14
       mov       rbp,[rsi+10]
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M10_L09
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M10_L10
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rdi+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M10_L18
       cmp       ecx,0FF
       ja        near ptr M10_L18
       mov       [rsi+1D],cl
M10_L00:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M10_L11
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
       jo        near ptr M10_L18
       cmp       ecx,0FF
       ja        near ptr M10_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M10_L01:
       mov       rsi,rdx
M10_L02:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M10_L12
       test      rsi,rsi
       je        short M10_L03
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M10_L03:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M10_L18
       cmp       ecx,0FF
       ja        near ptr M10_L18
       mov       [rbx+1D],cl
M10_L04:
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M10_L15
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M10_L16
       test      rbp,rbp
       je        short M10_L05
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M10_L05:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M10_L18
       cmp       ecx,0FF
       ja        near ptr M10_L18
       mov       [rbx+1D],cl
M10_L06:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M10_L17
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
       jo        near ptr M10_L18
       cmp       ecx,0FF
       ja        near ptr M10_L18
       mov       [rdi+1D],cl
       mov       rax,rdi
M10_L07:
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
M10_L08:
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
M10_L09:
       jmp       near ptr M10_L02
M10_L10:
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
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M10_L00
M10_L11:
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
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M10_L01
M10_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       test      rsi,rsi
       jne       short M10_L13
       mov       rsi,[rbx+8]
M10_L13:
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
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M10_L04
M10_L14:
       mov       ecx,869
       mov       rdx,7FFC13786C30
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13874000]
       int       3
M10_L15:
       mov       rax,rbx
       jmp       near ptr M10_L07
M10_L16:
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
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M10_L06
M10_L17:
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
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M10_L07
M10_L18:
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
       je        near ptr M11_L03
       mov       rsi,[rbx+8]
       cmp       qword ptr [rsi+8],0
       je        near ptr M11_L04
       mov       rdi,rsi
       mov       rdx,[rdi+10]
       mov       rbp,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M11_L05
       test      rbp,rbp
       je        short M11_L00
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M11_L00:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M11_L07
       cmp       ecx,0FF
       ja        near ptr M11_L07
       mov       [rbx+1D],cl
M11_L01:
       cmp       byte ptr [rdi+1C],0
       jne       near ptr M11_L06
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
       jo        near ptr M11_L07
       cmp       ecx,0FF
       ja        near ptr M11_L07
       mov       [rdi+1D],cl
       mov       rax,rdi
M11_L02:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M11_L03:
       mov       ecx,869
       mov       rdx,7FFC13786C30
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13874000]
       int       3
M11_L04:
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
M11_L05:
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
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M11_L01
M11_L06:
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
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rdi
       jmp       near ptr M11_L02
M11_L07:
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
       je        near ptr M12_L14
       mov       rsi,[rbx+10]
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M12_L08
       test      rsi,rsi
       je        near ptr M12_L14
       cmp       qword ptr [rdi+8],0
       je        near ptr M12_L09
       mov       rbp,rdi
       mov       rdx,[rbp+10]
       mov       r14,rdx
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M12_L10
       test      r14,r14
       je        short M12_L00
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M12_L00:
       mov       rcx,[rsi+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rsi+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M12_L18
       cmp       ecx,0FF
       ja        near ptr M12_L18
       mov       [rsi+1D],cl
M12_L01:
       cmp       byte ptr [rbp+1C],0
       jne       near ptr M12_L11
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
       jo        near ptr M12_L18
       cmp       ecx,0FF
       ja        near ptr M12_L18
       mov       [rbp+1D],cl
       mov       rdx,rbp
M12_L02:
       mov       rsi,rdx
M12_L03:
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M12_L12
       test      rsi,rsi
       je        short M12_L04
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M12_L04:
       mov       rcx,[rbx+8]
       movzx     ecx,byte ptr [rcx+1D]
       mov       rax,[rbx+10]
       movzx     eax,byte ptr [rax+1D]
       cmp       ecx,eax
       cmovl     ecx,eax
       add       ecx,1
       jo        near ptr M12_L18
       cmp       ecx,0FF
       ja        near ptr M12_L18
       mov       [rbx+1D],cl
M12_L05:
       mov       rsi,[rbx+10]
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M12_L15
       mov       rdi,rdx
       cmp       byte ptr [rbx+1C],0
       jne       near ptr M12_L16
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
       jo        near ptr M12_L18
       cmp       ecx,0FF
       ja        near ptr M12_L18
       mov       [rbx+1D],cl
M12_L06:
       cmp       byte ptr [rsi+1C],0
       jne       near ptr M12_L17
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
       jo        near ptr M12_L18
       cmp       ecx,0FF
       ja        near ptr M12_L18
       mov       [rsi+1D],cl
       mov       rax,rsi
M12_L07:
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
M12_L08:
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
M12_L09:
       jmp       near ptr M12_L03
M12_L10:
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
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M12_L01
M12_L11:
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
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rdx,rbp
       jmp       near ptr M12_L02
M12_L12:
       mov       edi,[rbx+18]
       mov       rbp,[rbx+20]
       mov       r14,[rbx+28]
       mov       r15,[rbx+8]
       test      rsi,rsi
       jne       short M12_L13
       mov       rsi,[rbx+10]
M12_L13:
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
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M12_L05
M12_L14:
       mov       ecx,869
       mov       rdx,7FFC13786C30
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13874000]
       int       3
M12_L15:
       mov       rax,rbx
       jmp       near ptr M12_L07
M12_L16:
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
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       jmp       near ptr M12_L06
M12_L17:
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
       call      qword ptr [7FFC1371EB20]; System.Collections.Immutable.SortedInt32KeyNode`1[[System.Collections.Immutable.ImmutableHashSet`1+HashBucket[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]]..ctor(Int32, HashBucket<System.__Canon>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, System.Collections.Immutable.SortedInt32KeyNode`1<HashBucket<System.__Canon>>, Boolean)
       mov       rax,rsi
       jmp       near ptr M12_L07
M12_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 943
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
       je        near ptr M13_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M13_L00
       test      rbx,rbx
       je        near ptr M13_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M13_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M13_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC72BA52E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC12F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC12F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M13_L00:
       test      rbx,rbx
       je        short M13_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M13_L02
M13_L01:
       mov       rax,1C011940008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M13_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M13_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M13_L04:
       call      qword ptr [7FFC1371F438]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M14_L00
       ret
M14_L00:
       jmp       qword ptr [7FFC12F05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       je        short M15_L00
       test      r14,r14
       je        near ptr M15_L01
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
       jo        short M15_L02
       cmp       ecx,0FF
       ja        short M15_L02
       mov       [rbx+1D],cl
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M15_L00:
       mov       ecx,847
       mov       rdx,7FFC13786C30
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13874000]
       int       3
M15_L01:
       mov       ecx,851
       mov       rdx,7FFC13786C30
       call      qword ptr [7FFC13127798]
       mov       rcx,rax
       call      qword ptr [7FFC13874000]
       int       3
M15_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 215
```

