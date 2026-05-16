## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetInstances()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FF910B1D6B0]; System.Reflection.Assembly.GetExecutingAssembly()
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__3<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+30],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+34],eax
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],rdi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 108
```
```assembly
; System.Reflection.Assembly.GetExecutingAssembly()
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
       xor       eax,eax
       mov       [rbp-48],rax
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-68],rcx
       mov       rcx,rbp
       mov       [rbp-58],rcx
       mov       dword ptr [rbp-3C],1
       lea       rcx,[rbp-3C]
       lea       rdx,[rbp-48]
       mov       rax,7FF9106626D8
       mov       [rbp-70],rax
       lea       rax,[M01_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF9700D9340
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF9704239A0],0
       je        short M01_L01
       call      qword ptr [7FF970411648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-78]
       mov       [rbx+8],rax
       mov       rax,[rbp-48]
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
; Total bytes of code 171
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetTypes()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       call      qword ptr [7FF910AFD158]; System.Reflection.Assembly.GetExecutingAssembly()
       mov       rcx,rax
       call      qword ptr [7FF910AFD1B8]; DotNetTips.Spargine.Extensions.AssemblyExtensionsHelper.GetLoadableTypes(System.Reflection.Assembly)
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebp,[rsi+8]
       mov       edx,ebp
       test      edx,edx
       je        near ptr M00_L18
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       r14d,10
       inc       ebp
       jmp       near ptr M00_L09
M00_L01:
       test      r9d,r9d
       je        short M00_L02
       inc       eax
       add       r8d,eax
       and       r8d,[rdx+4]
       cmp       eax,8
       jl        near ptr M00_L12
M00_L02:
       mov       r11d,2
       jmp       near ptr M00_L13
M00_L03:
       cmp       r11d,1
       je        short M00_L04
       mov       rdx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark
       mov       r8d,1
       call      qword ptr [7FF9106B4C00]; System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       mov       r12d,eax
       jmp       near ptr M00_L14
M00_L04:
       mov       r12d,1
       jmp       near ptr M00_L14
M00_L05:
       mov       rdx,r15
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L08
       mov       rcx,r15
       mov       rdx,24856057000
       mov       rax,[r13+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L07
       mov       rcx,24856057000
       call      qword ptr [7FF9106B69B8]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       near ptr M00_L16
       mov       rcx,24856057000
       call      00007FF9701141D0
       test      eax,eax
       je        short M00_L08
       mov       rcx,24856057000
       call      qword ptr [7FF91042A400]
       mov       r13d,[rax+8]
       test      r13d,r13d
       jle       short M00_L07
       lea       r12,[rax+10]
M00_L06:
       mov       rcx,[r12]
       mov       rdx,r15
       mov       rax,[rcx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M00_L08
       add       r12,8
       dec       r13d
       jne       short M00_L06
M00_L07:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L22
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L08:
       add       r14,8
M00_L09:
       dec       ebp
       je        near ptr M00_L17
       mov       r15,[rsi+r14]
       mov       r13,[r15]
       mov       r12,offset MT_System.RuntimeType
       cmp       r13,r12
       jne       near ptr M00_L19
       mov       rcx,r15
       call      00007FF9700EE370
M00_L10:
       test      al,80
       jne       short M00_L08
       mov       rcx,24856057000
       cmp       r15,rcx
       je        short M00_L07
       cmp       r13,r12
       jne       near ptr M00_L20
       mov       rax,r15
M00_L11:
       test      rax,rax
       je        near ptr M00_L05
       cmp       [rax],r12
       jne       near ptr M00_L05
       mov       r13,rax
       mov       rcx,[r13+18]
       mov       rdx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark
       cmp       rcx,rdx
       je        near ptr M00_L21
       mov       rdx,207C1000038
       mov       rdx,[rdx]
       add       rdx,10
       rorx      r8,rcx,20
       mov       rax,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark
       xor       r8,rax
       mov       rax,9E3779B97F4A7C15
       imul      r8,rax
       mov       eax,[rdx]
       shrx      r8,r8,rax
       xor       eax,eax
M00_L12:
       lea       r10d,[r8+1]
       movsxd    r10,r10d
       lea       r10,[r10+r10*2]
       lea       r10,[rdx+r10*8]
       mov       r9d,[r10]
       mov       r11,[r10+8]
       and       r9d,0FFFFFFFE
       cmp       r11,rcx
       jne       near ptr M00_L01
       mov       r11,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark
       xor       r11,[r10+10]
       cmp       r11,1
       ja        near ptr M00_L01
       cmp       r9d,[r10]
       jne       near ptr M00_L02
M00_L13:
       test      r11d,r11d
       jne       near ptr M00_L03
       xor       r12d,r12d
M00_L14:
       mov       rdx,24856057000
       movzx     r13d,r12b
M00_L15:
       test      r13d,r13d
       je        near ptr M00_L08
       jmp       near ptr M00_L07
M00_L16:
       mov       rcx,r15
       mov       rdx,24856057000
       call      qword ptr [7FF910BB4A80]
       mov       r13d,eax
       jmp       short M00_L15
M00_L17:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L18:
       mov       rcx,207C1001B58
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L19:
       mov       rcx,r15
       mov       rax,[r13+70]
       call      qword ptr [rax+18]
       jmp       near ptr M00_L10
M00_L20:
       mov       rcx,r15
       mov       rax,[r13+58]
       call      qword ptr [rax]
       jmp       near ptr M00_L11
M00_L21:
       mov       r11d,1
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FF9104E71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L08
; Total bytes of code 862
```
```assembly
; System.Reflection.Assembly.GetExecutingAssembly()
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
       xor       eax,eax
       mov       [rbp-48],rax
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-68],rcx
       mov       rcx,rbp
       mov       [rbp-58],rcx
       mov       dword ptr [rbp-3C],1
       lea       rcx,[rbp-3C]
       lea       rdx,[rbp-48]
       mov       rax,7FF9106526D8
       mov       [rbp-70],rax
       lea       rax,[M01_L00]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF9700D9340
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF9704239A0],0
       je        short M01_L01
       call      qword ptr [7FF970411648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-78]
       mov       [rbx+8],rax
       mov       rax,[rbp-48]
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
; Total bytes of code 171
```
```assembly
; DotNetTips.Spargine.Extensions.AssemblyExtensionsHelper.GetLoadableTypes(System.Reflection.Assembly)
; 		assembly = assembly.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return assembly.GetTypes();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			return [.. ex.Types
; 			^^^^^^^^^^^^^^^^^^^
; 				.Where(static type => type is not null)
; 				                                       
; 				.Cast<Type>()];
; 				               
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rcx],rax
       jne       short M02_L01
       call      qword ptr [7FF910653088]; System.Reflection.Assembly.GetTypes()
M02_L00:
       mov       [rbp-20],rax
       jmp       short M02_L02
M02_L01:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       short M02_L00
M02_L02:
       mov       rax,[rbp-20]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L03:
       call      qword ptr [7FF910A6E5B0]
       mov       ecx,49
       mov       rdx,7FF9108BB7C8
       call      qword ptr [7FF9104EF228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FF9107B4FE0
       call      qword ptr [7FF9104EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9108BB7C8
       call      qword ptr [7FF9104EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9104ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF910BB5F98]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF910BB5260]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       cmp       [rcx],ecx
       call      qword ptr [7FF910AFD2A8]
       mov       rbx,rax
       test      byte ptr [7FF910B41E70],1
       jne       short M02_L04
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.AssemblyExtensionsHelper+<>c
       call      qword ptr [7FF9104E5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M02_L04:
       mov       rsi,207D7000170
       mov       r8,[rsi]
       test      r8,r8
       jne       short M02_L05
       mov       rcx,offset MT_System.Func<System.Type, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,207D7000168
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FF910AF9290
       call      qword ptr [7FF9104E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,rsi
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
M02_L05:
       mov       rdx,rbx
       mov       rcx,7FF910B41FC0
       call      qword ptr [7FF9108645E8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,rax
       mov       rcx,7FF910B420D8
       call      qword ptr [7FF910AFD248]
       mov       rdx,rax
       mov       rcx,7FF910B42160
       call      qword ptr [7FF910866988]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-20],rax
       lea       rax,[M02_L02]
       add       rsp,28
       ret
; Total bytes of code 415
```
```assembly
; System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
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
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r14,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       test      sil,2
       jne       short M03_L01
       test      bl,2
       jne       near ptr M03_L08
       mov       ecx,[rbx]
       and       ecx,0F0000
       cmp       ecx,50000
       je        near ptr M03_L05
M03_L00:
       mov       rcx,7FF910BAFBF4
       call      CORINFO_HELP_COUNTPROFILE32
M03_L01:
       mov       rcx,7FF910BAFBFC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,7FF9105C6208
       mov       [rbp-60],rax
       lea       rax,[M03_L02]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FF970000C60
       call      rax
M03_L02:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FF9704239A0],0
       je        short M03_L03
       call      qword ptr [7FF970411648]; CORINFO_HELP_STOP_FOR_GC
M03_L03:
       mov       rcx,[rbp-68]
       mov       [r14+8],rcx
       test      eax,eax
       setne     dil
       movzx     edi,dil
M03_L04:
       movzx     eax,dil
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
M03_L05:
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       rcx,rsi
       jne       short M03_L07
M03_L06:
       mov       rcx,7FF910BAFBF0
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     edi,dil
       jmp       short M03_L04
M03_L07:
       mov       rdx,rsi
       call      qword ptr [7FF910BB4A98]
       test      eax,eax
       je        near ptr M03_L00
       jmp       short M03_L06
M03_L08:
       mov       rcx,7FF910BAFBF8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L01
; Total bytes of code 317
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M04_L00
       cmp       [rdx],rcx
       jne       short M04_L01
M04_L00:
       mov       rax,rdx
       ret
M04_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
M04_L02:
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L00
       jmp       short M04_L02
M04_L03:
       xor       edx,edx
       jmp       short M04_L00
; Total bytes of code 88
```
```assembly
; System.RuntimeType.get_IsActualInterface()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+18]
       test      cl,2
       jne       short M05_L01
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      sil
       movzx     esi,sil
M05_L00:
       mov       rcx,7FF910BAD9AC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L01:
       mov       rcx,7FF910BAD9A8
       call      CORINFO_HELP_COUNTPROFILE32
       xor       esi,esi
       jmp       short M05_L00
; Total bytes of code 83
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M06_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M06_L02
       cmp       rdx,[r8]
       je        short M06_L01
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M06_L01
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF9106B6EE0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M06_L00:
       call      qword ptr [7FF910AFEE98]
       int       3
M06_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF970168B20
M06_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M07_L01
       mov       edx,4
M07_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FF96FF59D08]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      qword ptr [7FF96FF34008]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M07_L00
; Total bytes of code 105
```

