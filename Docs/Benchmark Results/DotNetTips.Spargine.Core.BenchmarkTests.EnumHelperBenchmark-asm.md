## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.FlagCount()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,148
       vzeroupper
       lea       rbp,[rsp+180]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0F0],ymm4
       vmovdqu   ymmword ptr [rbp-0D0],ymm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       lea       rcx,[rbp-128]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-110],rcx
       mov       rcx,rbp
       mov       [rbp-100],rcx
       mov       rcx,offset MT_System.AttributeTargets
       call      00007FFE8C84BEA0
       test      rax,rax
       jne       near ptr M00_L21
M00_L00:
       mov       rcx,21A614001C8
       mov       rdi,[rcx]
       cmp       qword ptr [rdi+8],0
       je        near ptr M00_L07
       mov       r14,[rdi+10]
       xor       r15d,r15d
       mov       r13,[rdi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r13],rcx
       jne       near ptr M00_L24
       mov       rcx,25AF6225F08
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       lea       rcx,[rbp-40]
       cmp       qword ptr [rbp-48],0
       jne       short M00_L01
       mov       rcx,[rbp-40]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       cmp       qword ptr [rbp-48],0
       je        near ptr M00_L22
M00_L01:
       mov       r12,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M00_L23
       mov       rcx,r12
       call      00007FFE8C81A6D0
       test      eax,eax
       je        near ptr M00_L14
M00_L02:
       mov       r12d,eax
M00_L03:
       xor       ecx,ecx
       mov       [rbp-48],rcx
M00_L04:
       mov       rdx,[rdi+8]
       mov       ecx,r12d
       imul      rcx,[rdi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M00_L33
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       eax,[rdx]
       dec       eax
       js        short M00_L07
M00_L05:
       cmp       eax,[r14+8]
       jae       near ptr M00_L33
       mov       edx,eax
       shl       rdx,4
       lea       rdi,[r14+rdx+10]
       cmp       [rdi+8],r12d
       je        near ptr M00_L25
M00_L06:
       mov       eax,[rdi+0C]
       inc       r15d
       cmp       [r14+8],r15d
       jb        near ptr M00_L26
       test      eax,eax
       jge       short M00_L05
M00_L07:
       mov       rcx,25AF6230AA0
       call      00007FFE8C8453D0
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L27
M00_L08:
       mov       [rbp-130],rdi
       mov       rcx,25AF6230AA0
       call      00007FFE8C848680
       mov       r14d,eax
       cmp       [rdi],dil
       mov       rcx,rdi
       call      00007FFE8C891F10
       mov       [rbp-50],rax
       vxorps    ymm1,ymm1,ymm1
       vmovdqu   ymmword ptr [rbp-0A0],ymm1
       vmovdqu   ymmword ptr [rbp-80],ymm1
       vmovdqu   xmmword ptr [rbp-60],xmm1
       mov       dword ptr [rbp-0F0],10
       mov       rcx,[rbp-50]
       lea       r9,[rbp-94]
       mov       [rsp+20],r9
       lea       r9,[rbp-0A0]
       mov       [rsp+28],r9
       lea       r9,[rbp-0F0]
       mov       r8d,r14d
       mov       edx,0C000000
       mov       rax,7FFE2CD5B248
       mov       [rbp-118],rax
       lea       rax,[M00_L09]
       mov       [rbp-108],rax
       lea       rax,[rbp-128]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE8C77EA40
       call      rax
M00_L09:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M00_L10
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M00_L10:
       mov       r8,[rbp-120]
       mov       [rsi+8],r8
       mov       r8d,[rbp-0F0]
       mov       [rbp-98],r8d
       cmp       dword ptr [rbp-98],0
       je        near ptr M00_L28
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B8],xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0D0],xmm0
       vmovdqu   xmmword ptr [rbp-0C8],xmm0
       xor       ebx,ebx
       cmp       dword ptr [rbp-98],0
       jle       near ptr M00_L31
M00_L11:
       cmp       qword ptr [rbp-0A0],0
       jne       near ptr M00_L15
       cmp       ebx,10
       jae       near ptr M00_L33
       lea       r8,[rbp-94]
       mov       edx,[r8+rbx*4]
M00_L12:
       lea       r8,[rbp-0A8]
       lea       r9,[rbp-0B8]
       mov       rcx,[rbp-50]
       call      00007FFE8C849180
       test      eax,eax
       jl        near ptr M00_L30
       mov       ecx,[rbp-0A8]
       mov       rdx,25AF6225F08
       mov       [rsp+20],rdx
       xor       edx,edx
       mov       [rsp+28],edx
       lea       rdx,[rbp-0D0]
       mov       [rsp+30],rdx
       lea       rdx,[rbp-0D8]
       mov       [rsp+38],rdx
       lea       rdx,[rbp-0E0]
       mov       [rsp+40],rdx
       lea       rdx,[rbp-0E8]
       mov       [rsp+48],rdx
       lea       rdx,[rbp-50]
       mov       r8,[rbp-130]
       mov       r9d,r14d
       call      qword ptr [7FFE2CC1EBB0]; System.Reflection.CustomAttribute.FilterCustomAttributeRecord(System.Reflection.MetadataToken, System.Reflection.MetadataImport ByRef, System.Reflection.RuntimeModule, System.Reflection.MetadataToken, System.RuntimeType, Boolean, ListBuilder`1<System.Object> ByRef, System.RuntimeType ByRef, System.IRuntimeMethodInfo ByRef, Boolean ByRef)
       test      eax,eax
       je        near ptr M00_L29
       mov       ebx,1
M00_L13:
       xor       ecx,ecx
       mov       [rbp-0D8],rcx
       mov       [rbp-0E0],rcx
       test      ebx,ebx
       je        near ptr M00_L32
       xor       ebx,ebx
       mov       rcx,offset MT_System.AttributeTargets
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       dword ptr [rcx+8],1C4
       call      qword ptr [7FFE2D24E418]; System.Enum.GetValue()
       test      rax,rax
       je        short M00_L16
       mov       rdx,rax
       mov       rcx,offset MT_System.IConvertible
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r11,7FFE2CB60A70
       xor       edx,edx
       call      qword ptr [r11]
       mov       rsi,rax
       jmp       short M00_L17
M00_L14:
       mov       rcx,r12
       call      qword ptr [7FFE2CC1E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M00_L02
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M00_L15:
       mov       rdx,[rbp-0A0]
       cmp       ebx,[rdx+8]
       jae       near ptr M00_L33
       mov       edx,[rdx+rbx*4+10]
       jmp       near ptr M00_L12
M00_L16:
       xor       esi,esi
M00_L17:
       test      rsi,rsi
       je        short M00_L19
M00_L18:
       mov       eax,esi
       and       eax,1
       add       ebx,eax
       jo        near ptr M00_L34
       shr       rsi,1
       jne       short M00_L18
M00_L19:
       mov       eax,ebx
M00_L20:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+88]
       mov       [rcx+38],eax
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L21:
       mov       rcx,rax
       call      qword ptr [7FFE2CC15860]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rcx,25AF6230AA0
       test      rax,rax
       jne       near ptr M00_L32
       jmp       near ptr M00_L00
M00_L22:
       xor       r12d,r12d
       jmp       near ptr M00_L03
M00_L23:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
       jmp       near ptr M00_L03
M00_L24:
       mov       rcx,r13
       mov       rdx,25AF6225F08
       mov       r11,7FFE2CB60A58
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M00_L04
M00_L25:
       mov       rdx,[rdi]
       mov       rcx,r13
       mov       r8,25AF6225F08
       mov       r11,7FFE2CB60A60
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L06
       jmp       near ptr M00_L07
M00_L26:
       call      qword ptr [7FFE2CE37A08]
       int       3
M00_L27:
       mov       rcx,25AF6230AA0
       call      qword ptr [7FFE2CC17C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rdi,rax
       jmp       near ptr M00_L08
M00_L28:
       xor       ebx,ebx
       jmp       near ptr M00_L13
M00_L29:
       inc       ebx
       cmp       ebx,[rbp-98]
       jl        near ptr M00_L11
       jmp       short M00_L31
M00_L30:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2C54B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L31:
       jmp       short M00_L28
M00_L32:
       mov       eax,1
       jmp       near ptr M00_L20
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1363
```
```assembly
; System.Reflection.CustomAttribute.FilterCustomAttributeRecord(System.Reflection.MetadataToken, System.Reflection.MetadataImport ByRef, System.Reflection.RuntimeModule, System.Reflection.MetadataToken, System.RuntimeType, Boolean, ListBuilder`1<System.Object> ByRef, System.RuntimeType ByRef, System.IRuntimeMethodInfo ByRef, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,108
       vzeroupper
       lea       rbp,[rsp+140]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+20],r8
       mov       esi,ecx
       mov       rbx,rdx
       mov       edi,r9d
       mov       r15,[rbp+30]
       mov       r14,[rbp+48]
       mov       r13,[rbp+50]
       mov       r12,[rbp+58]
       lea       rcx,[rbp-0C8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-90],rax
       mov       rcx,rsp
       mov       [rbp-0B0],rcx
       mov       rcx,rbp
       mov       [rbp-0A0],rcx
       xor       ecx,ecx
       mov       [r13],rcx
       mov       byte ptr [r12],0
       mov       r10,[rbp+20]
       mov       [rbp-108],r10
       mov       rcx,[rbx]
       lea       r8,[rbp-58]
       mov       edx,esi
       call      00007FFE8C8494F0
       test      eax,eax
       jl        near ptr M01_L22
       mov       rcx,[rbp-108]
       mov       edx,[rbp-58]
       xor       r8d,r8d
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFE2CD3F500]; System.Reflection.RuntimeModule.ResolveType(Int32, System.Type[], System.Type[])
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L00
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdx],rcx
       jne       short M01_L00
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       mov       rcx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[r14]
       mov       rdx,[r15+18]
       test      dl,2
       jne       near ptr M01_L23
       mov       edx,[rdx]
       and       edx,80000030
       cmp       edx,30
       sete      dl
       movzx     edx,dl
M01_L02:
       test      edx,edx
       jne       near ptr M01_L24
       test      rcx,rcx
       je        near ptr M01_L30
       cmp       rcx,r15
       jne       near ptr M01_L28
       mov       eax,1
M01_L03:
       test      eax,eax
       je        near ptr M01_L27
M01_L04:
       mov       r15,[r14]
       xor       eax,eax
       cmp       byte ptr [rbp+38],0
       jne       near ptr M01_L31
M01_L05:
       mov       rdx,[rbp+40]
       cmp       dword ptr [rdx+10],0
       jne       near ptr M01_L32
M01_L06:
       mov       ecx,esi
       and       ecx,0FF000000
       cmp       ecx,0A000000
       jne       near ptr M01_L18
       mov       rcx,[rbx]
       lea       r8,[rbp-68]
       mov       edx,esi
       call      00007FFE8C862070
       test      eax,eax
       jl        near ptr M01_L39
       mov       r15d,[rbp-68]
       mov       rax,[rbp-60]
M01_L07:
       test      r15d,r15d
       jle       near ptr M01_L41
       test      byte ptr [rax],5
       setne     cl
       mov       [r12],cl
       cmp       r15d,1
       jle       near ptr M01_L42
       cmp       byte ptr [rax+1],0
       jne       near ptr M01_L43
M01_L08:
       xor       edx,edx
       mov       ecx,edi
       and       ecx,0FF000000
       cmp       ecx,8000000
       je        near ptr M01_L19
       cmp       ecx,6000000
       je        near ptr M01_L48
       cmp       ecx,17000000
       je        near ptr M01_L48
       cmp       ecx,14000000
       je        near ptr M01_L48
       cmp       ecx,4000000
       je        near ptr M01_L48
       cmp       ecx,2000000
       jne       near ptr M01_L49
       mov       edx,edi
M01_L09:
       mov       ecx,edx
       and       ecx,0FF000000
       cmp       ecx,2000000
       jne       near ptr M01_L50
       mov       rcx,[rbp+20]
       cmp       [rcx],cl
       mov       [rbp-50],rcx
       lea       rcx,[rbp-50]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE2CC1EBE0]; System.ModuleHandle.ResolveTypeHandle(Int32, System.RuntimeTypeHandle[], System.RuntimeTypeHandle[])
M01_L10:
       mov       [rbp-40],rax
       mov       rcx,[r14]
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M01_L51
M01_L11:
       mov       [rbp-48],rcx
       mov       rcx,[rbp-48]
       test      rcx,rcx
       je        near ptr M01_L20
       mov       rbx,[rcx+18]
M01_L12:
       cmp       qword ptr [r13],0
       jne       near ptr M01_L52
       xor       edx,edx
M01_L13:
       mov       rcx,[rbp-40]
       test      rcx,rcx
       je        near ptr M01_L21
       mov       rcx,[rcx+18]
       mov       [rbp+50],r13
M01_L14:
       mov       r8,[rbp+20]
       mov       r8,[r8+18]
       lea       r9,[rbp-48]
       mov       [rbp-0D8],r9
       mov       [rbp-0D0],rbx
       lea       r9,[rbp-40]
       mov       [rbp-0E8],r9
       mov       [rbp-0E0],rcx
       lea       rcx,[rbp+20]
       mov       [rbp-0F8],rcx
       mov       [rbp-0F0],r8
       lea       rcx,[rbp-0D8]
       lea       r8,[rbp-0E8]
       lea       r9,[rbp-0F8]
       mov       rax,7FFE2CD60838
       mov       [rbp-0B8],rax
       lea       rax,[M01_L15]
       mov       [rbp-0A8],rax
       lea       rax,[rbp-0C8]
       mov       rbx,[rbp-90]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFE8C7819F0
       call      rax
M01_L15:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M01_L16
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M01_L16:
       mov       rcx,[rbp-0C0]
       mov       [rbx+8],rcx
       test      eax,eax
       setne     al
       movzx     eax,al
       mov       r13,[rbp+50]
       mov       rcx,[r13]
M01_L17:
       movzx     eax,al
       add       rsp,108
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-78],xmm0
       mov       rcx,[rbx]
       lea       r8,[rbp-78]
       mov       edx,esi
       call      00007FFE8C86A760
       test      eax,eax
       jl        near ptr M01_L40
       mov       r15d,[rbp-78]
       mov       rax,[rbp-70]
       jmp       near ptr M01_L07
M01_L19:
       mov       rcx,[rbx]
       lea       r8,[rbp-80]
       mov       edx,edi
       call      00007FFE8C8494F0
       test      eax,eax
       jl        near ptr M01_L46
       mov       edx,[rbp-80]
       mov       rcx,[rbx]
       lea       r8,[rbp-88]
       call      00007FFE8C8494F0
       test      eax,eax
       jl        near ptr M01_L47
       mov       edx,[rbp-88]
       jmp       near ptr M01_L09
M01_L20:
       xor       ebx,ebx
       jmp       near ptr M01_L12
M01_L21:
       xor       ecx,ecx
       mov       [rbp+50],r13
       jmp       near ptr M01_L14
M01_L22:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2C54B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L23:
       xor       edx,edx
       jmp       near ptr M01_L02
M01_L24:
       mov       rax,rcx
       test      rax,rax
       je        short M01_L27
M01_L25:
       mov       [rbp-110],rax
       mov       rcx,rax
       call      qword ptr [7FFE2CB5A358]
       test      eax,eax
       je        short M01_L26
       mov       rcx,[rbp-110]
       call      qword ptr [7FFE2CB5A3C8]; Precode of System.RuntimeType.GetGenericTypeDefinition()
       cmp       rax,r15
       je        near ptr M01_L04
M01_L26:
       mov       rcx,[rbp-110]
       call      qword ptr [7FFE2CC1DB00]; System.RuntimeType.GetBaseType()
       mov       rdx,rax
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFE2CC16328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       mov       rax,rcx
       jne       short M01_L25
M01_L27:
       xor       eax,eax
       jmp       near ptr M01_L17
M01_L28:
       test      rcx,rcx
       je        short M01_L29
       mov       rdx,r15
       call      qword ptr [7FFE2D2C6700]; System.RuntimeTypeHandle.CanCastTo(System.RuntimeType, System.RuntimeType)
       jmp       near ptr M01_L03
M01_L29:
       xor       eax,eax
       jmp       near ptr M01_L03
M01_L30:
       xor       eax,eax
       jmp       near ptr M01_L03
M01_L31:
       mov       rcx,r15
       call      qword ptr [7FFE2D2C5668]
       mov       [rbp-118],rax
       cmp       byte ptr [rax+0D],0
       mov       rax,[rbp-118]
       je        short M01_L27
       jmp       near ptr M01_L05
M01_L32:
       xor       r8d,r8d
       jmp       short M01_L36
M01_L33:
       cmp       qword ptr [rdx],0
       jne       short M01_L34
       mov       [rbp+40],rdx
       mov       rcx,[rdx+8]
       mov       [rbp-118],rax
       mov       [rbp-100],r8
       jmp       short M01_L35
M01_L34:
       mov       rcx,[rdx]
       cmp       r8d,[rcx+8]
       jae       near ptr M01_L53
       mov       [rbp-100],r8
       mov       rcx,[rcx+r8*8+10]
       mov       [rbp-118],rax
       mov       [rbp+40],rdx
M01_L35:
       call      qword ptr [7FFE2CC1C9A8]; System.Object.GetType()
       cmp       rax,r15
       je        short M01_L37
       mov       rcx,[rbp-100]
       inc       ecx
       mov       r8,rcx
       mov       rax,[rbp-118]
       mov       rdx,[rbp+40]
M01_L36:
       cmp       r8d,[rdx+10]
       jl        short M01_L33
       jmp       near ptr M01_L06
M01_L37:
       mov       rax,[rbp-118]
       test      rax,rax
       jne       short M01_L38
       mov       rcx,r15
       call      qword ptr [7FFE2D2C5668]
       mov       r15,rax
       mov       rax,r15
M01_L38:
       movzx     ecx,byte ptr [rax+0C]
       test      ecx,ecx
       je        near ptr M01_L27
       jmp       near ptr M01_L06
M01_L39:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2C54B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L40:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2C54B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L41:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2C5560]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L42:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2C5560]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L43:
       mov       rcx,[r14]
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+8]
       test      eax,eax
       je        short M01_L44
       mov       r15,[rbp+20]
       mov       rcx,[r14]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       edx,esi
       mov       rcx,r15
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFE2CD3F4E8]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+38]
       jmp       short M01_L45
M01_L44:
       mov       rcx,[rbp+20]
       mov       [rbp-50],rcx
       lea       rcx,[rbp-50]
       mov       edx,esi
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE2CD85308]; System.ModuleHandle.ResolveMethodHandle(Int32, System.RuntimeTypeHandle[], System.RuntimeTypeHandle[])
M01_L45:
       mov       rcx,r13
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M01_L08
M01_L46:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2C54B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L47:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2C54B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L48:
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE2D2C6730]
       mov       edx,eax
       jmp       near ptr M01_L09
M01_L49:
       cmp       ecx,2A000000
       jne       near ptr M01_L09
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE2D2C6730]
       mov       edx,eax
       mov       ecx,edx
       and       ecx,0FF000000
       cmp       ecx,6000000
       jne       near ptr M01_L09
       mov       rcx,rbx
       call      qword ptr [7FFE2D2C6730]
       mov       edx,eax
       jmp       near ptr M01_L09
M01_L50:
       xor       eax,eax
       jmp       near ptr M01_L10
M01_L51:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M01_L11
M01_L52:
       mov       [rbp+50],r13
       mov       rcx,[r13]
       mov       r11,7FFE2CB60A50
       call      qword ptr [r11]
       mov       rdx,rax
       mov       r13,[rbp+50]
       jmp       near ptr M01_L13
M01_L53:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1796
```
```assembly
; System.Enum.GetValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
M02_L00:
       lea       rsi,[rbx+8]
       mov       rcx,[rbx]
       call      00007FFE8C84E010
       add       eax,0FFFFFFFE
       cmp       eax,6
       jne       short M02_L02
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rsi]
       mov       [rax+8],ecx
M02_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       cmp       eax,17
       ja        short M02_L03
       mov       ecx,eax
       lea       rax,[7FFE2D324CB0]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M02_L00]
       add       rax,rdx
       jmp       rax
M02_L03:
       call      qword ptr [7FFE2D2C5AD0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,offset MT_System.SByte
       call      CORINFO_HELP_NEWSFAST
       movsx     rcx,byte ptr [rsi]
       mov       [rax+8],cl
       jmp       short M02_L01
       mov       rcx,offset MT_System.Byte
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,byte ptr [rsi]
       mov       [rax+8],cl
       jmp       short M02_L01
       mov       rcx,offset MT_System.Int16
       call      CORINFO_HELP_NEWSFAST
       movsx     rcx,word ptr [rsi]
       mov       [rax+8],cx
       jmp       short M02_L01
       mov       rcx,offset MT_System.UInt16
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,word ptr [rsi]
       mov       [rax+8],cx
       jmp       near ptr M02_L01
       mov       rcx,offset MT_System.UInt32
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rsi]
       mov       [rax+8],ecx
       jmp       near ptr M02_L01
       mov       rcx,offset MT_System.Int64
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,[rsi]
       mov       [rax+8],rcx
       jmp       near ptr M02_L01
       mov       rcx,offset MT_System.UInt64
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,[rsi]
       mov       [rax+8],rcx
       jmp       near ptr M02_L01
       mov       rcx,offset MT_System.Single
       call      CORINFO_HELP_NEWSFAST
       vmovss    xmm0,dword ptr [rsi]
       vmovss    dword ptr [rax+8],xmm0
       jmp       near ptr M02_L01
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       vmovsd    xmm0,qword ptr [rsi]
       vmovsd    qword ptr [rax+8],xmm0
       jmp       near ptr M02_L01
       mov       rcx,offset MT_System.IntPtr
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,[rsi]
       mov       [rax+8],rcx
       jmp       near ptr M02_L01
       mov       rcx,offset MT_System.UIntPtr
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,[rsi]
       mov       [rax+8],rcx
       jmp       near ptr M02_L01
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,word ptr [rsi]
       mov       [rax+8],cx
       jmp       near ptr M02_L01
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,byte ptr [rsi]
       mov       [rax+8],cl
       jmp       near ptr M02_L01
; Total bytes of code 443
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M03_L05
       mov       rax,[rax+38]
       cmp       r8,4
       jl        short M03_L04
       cmp       [rax],rcx
       je        short M03_L01
M03_L00:
       cmp       [rax+8],rcx
       je        short M03_L01
       cmp       [rax+10],rcx
       je        short M03_L01
       cmp       [rax+18],rcx
       jne       short M03_L03
M03_L01:
       mov       rax,rdx
       ret
M03_L02:
       cmp       [rax],rcx
       je        short M03_L01
       jmp       short M03_L00
M03_L03:
       add       rax,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M03_L02
       test      r8,r8
       je        short M03_L05
M03_L04:
       cmp       [rax],rcx
       je        short M03_L01
       add       rax,8
       dec       r8
       test      r8,r8
       jg        short M03_L04
M03_L05:
       jmp       qword ptr [7FFE2D2C4F48]
; Total bytes of code 104
```
```assembly
; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       cmp       qword ptr [rbp+10],0
       je        short M04_L01
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFE8C669030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       mov       ebx,eax
       lea       rcx,[rbp-90]
       call      qword ptr [7FFE8C669038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       eax,ebx
M04_L00:
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
M04_L01:
       xor       eax,eax
       jmp       short M04_L00
; Total bytes of code 119
```
```assembly
; System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       test      cl,2
       jne       short M05_L01
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
M05_L00:
       test      rax,rax
       je        short M05_L02
       ret
M05_L01:
       mov       rax,rcx
       and       rax,0FFFFFFFFFFFFFFFD
       add       rax,8
       mov       rax,[rax]
       jmp       short M05_L00
M05_L02:
       jmp       qword ptr [7FFE2CC15C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
; Total bytes of code 44
```
```assembly
; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-0A0],rcx
       lea       rdx,[rbp-40]
       mov       [rbp-0A8],rdx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE8C669030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp-0A8]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE8C669038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,[rbp-40]
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 132
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetDescription()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       dword ptr [rsp+34],6D
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.Enum+EnumInfo<System.UInt32>>
       mov       rsi,19005CD0AA0
       mov       rdx,rsi
       call      qword ptr [7FFE2D2DCE10]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].Find(System.RuntimeType)
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M00_L03
       cmp       qword ptr [rcx+10],0
       je        near ptr M00_L03
M00_L00:
       mov       edx,[rsp+34]
       call      qword ptr [7FFE2D24E568]; System.Enum.GetNameInlined[[System.UInt32, System.Private.CoreLib]](EnumInfo`1<UInt32>, UInt32)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rdx,rdi
       mov       rcx,rsi
       mov       r8d,1C
       call      qword ptr [7FFE2CB5A490]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L05
       mov       rdx,rsi
       mov       rcx,7FFE2D2AB6C8
       xor       r8d,r8d
       call      qword ptr [7FFE2D1365E0]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M00_L06
M00_L01:
       mov       rdx,rsi
       mov       rcx,7FFE2D2AB750
       xor       r8d,r8d
       call      qword ptr [7FFE2D1365E0]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       rbp,rax
       test      rbp,rbp
       je        short M00_L05
       mov       rcx,[rbp+8]
       call      qword ptr [7FFE2CE3E3E8]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M00_L05
       mov       rsi,[rbp+8]
M00_L02:
       mov       [rsp+28],rsi
       mov       rcx,[rbx+88]
       lea       r8,[rsp+28]
       mov       rdx,7FFE2D2AE1C0
       cmp       [rcx],ecx
       call      qword ptr [7FFE2D24E6D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L03:
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFE2CE3DE48]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       mov       rcx,rax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],6D
       mov       rcx,rax
       call      qword ptr [7FFE2CB56098]; System.Enum.ToString()
       mov       rsi,rax
       jmp       short M00_L02
M00_L05:
       mov       rsi,rdi
       jmp       short M00_L02
M00_L06:
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       call      qword ptr [7FFE2CE3E3E8]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       near ptr M00_L01
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rsi,rax
       jmp       near ptr M00_L02
; Total bytes of code 373
```
```assembly
; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].Find(System.RuntimeType)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rdx+10]
       test      rcx,rcx
       je        short M01_L01
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L01
M01_L00:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L05
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        short M01_L02
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FFE2CC17C30]; System.RuntimeType.InitializeCache()
       jmp       short M01_L00
M01_L02:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M01_L05
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+18]
       test      rax,rax
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rbx
       mov       rdx,7FFE2CD40C98
       call      qword ptr [7FFE2CC1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M01_L04:
       mov       rcx,rsi
       call      rax
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L05:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 171
```
```assembly
; System.Enum.GetNameInlined[[System.UInt32, System.Private.CoreLib]](EnumInfo`1<UInt32>, UInt32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       r8d,edx
       mov       rbx,[rcx+10]
       cmp       byte ptr [rcx+19],0
       je        short M02_L00
       mov       esi,[rbx+8]
       cmp       esi,r8d
       jbe       short M02_L05
       mov       eax,r8d
       mov       rax,[rbx+rax*8+10]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M02_L01
       xor       eax,eax
       xor       r10d,r10d
       jmp       short M02_L02
M02_L01:
       lea       rax,[rcx+10]
       mov       r10d,[rcx+8]
M02_L02:
       cmp       dword ptr [rcx+8],20
       jle       short M02_L03
       mov       rcx,rax
       mov       edx,r10d
       call      qword ptr [7FFE2D2D6D00]
       jmp       short M02_L04
M02_L03:
       mov       rcx,rax
       mov       edx,r8d
       mov       r8d,r10d
       call      qword ptr [7FFE2D2D6F10]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
M02_L04:
       mov       esi,[rbx+8]
       cmp       esi,eax
       jbe       short M02_L05
       mov       eax,eax
       mov       rax,[rbx+rax*8+10]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L05:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 131
```
```assembly
; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      rdi,rdi
       je        near ptr M03_L18
       test      bl,1
       jne       near ptr M03_L19
       mov       ebp,1
M03_L00:
       cmp       qword ptr [rsi+10],0
       je        short M03_L01
       mov       rcx,[rsi+10]
       mov       r14,[rcx]
       test      r14,r14
       jne       near ptr M03_L15
M03_L01:
       mov       rcx,rsi
       call      qword ptr [7FFE2CC17C30]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
M03_L02:
       mov       r14d,ebp
       mov       r15,rdi
       cmp       [rsi],sil
       lea       r13,[rsi+50]
       mov       r12,[r13]
       test      r12,r12
       je        near ptr M03_L20
M03_L03:
       mov       rsi,r12
       cmp       [rsi],sil
       cmp       r14d,1
       jne       near ptr M03_L21
       mov       rbp,[rsi+20]
       test      rbp,rbp
       je        near ptr M03_L25
       test      r15,r15
       je        near ptr M03_L22
       lea       rdx,[r15+0C]
       mov       [rsp+20],rdx
       mov       edx,15051505
       mov       ecx,15051505
       mov       r8,[rsp+20]
       mov       r9d,[r15+8]
       cmp       r9d,2
       jle       short M03_L05
M03_L04:
       add       r9d,0FFFFFFFC
       mov       eax,edx
       rol       eax,5
       add       edx,eax
       xor       edx,[r8]
       mov       eax,ecx
       rol       eax,5
       add       ecx,eax
       xor       ecx,[r8+4]
       add       r8,8
       cmp       r9d,2
       jg        short M03_L04
M03_L05:
       test      r9d,r9d
       jle       short M03_L06
       mov       r9d,ecx
       rol       r9d,5
       add       r9d,ecx
       mov       ecx,r9d
       xor       ecx,[r8]
M03_L06:
       imul      eax,ecx,5D588B65
       add       eax,edx
       xor       edx,edx
       mov       [rsp+20],rdx
M03_L07:
       mov       edx,eax
       not       eax
       test      edx,edx
       cmovl     edx,eax
       mov       r12,[rbp+8]
       mov       edi,[r12+8]
       mov       eax,edx
       cdq
       idiv      edi
       mov       r14d,edx
       cmp       r14d,edi
       jae       near ptr M03_L35
       mov       r8d,r14d
       mov       rcx,[r12+r8*8+10]
       test      rcx,rcx
       je        near ptr M03_L25
M03_L08:
       cmp       rcx,r15
       je        short M03_L09
       test      r15,r15
       je        near ptr M03_L24
       mov       r8d,[rcx+8]
       cmp       r8d,[r15+8]
       jne       near ptr M03_L24
       add       rcx,0C
       add       r8d,r8d
       lea       rdx,[r15+0C]
       call      qword ptr [7FFE2CC1FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M03_L24
M03_L09:
       mov       rcx,[rbp+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M03_L35
       mov       edx,r14d
       mov       rdi,[rcx+rdx*8+10]
M03_L10:
       test      rdi,rdi
       je        near ptr M03_L26
M03_L11:
       xor       esi,esi
       xor       ebx,2
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       mov       r15d,10
       inc       r14d
M03_L12:
       dec       r14d
       je        short M03_L16
       mov       r13,[rdi+r15]
       mov       ecx,[r13+18]
       mov       eax,ebx
       and       eax,ecx
       cmp       eax,ecx
       jne       short M03_L14
       test      rsi,rsi
       jne       near ptr M03_L31
M03_L13:
       mov       rsi,r13
M03_L14:
       add       r15,8
       jmp       short M03_L12
M03_L15:
       mov       rsi,r14
       jmp       near ptr M03_L02
M03_L16:
       test      ebp,ebp
       jne       near ptr M03_L33
M03_L17:
       mov       rax,rsi
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
M03_L18:
       mov       ecx,3E7
       mov       rdx,7FFE2CB54000
       call      qword ptr [7FFE2CE37798]
       mov       rcx,rax
       call      qword ptr [7FFE2D2D4CF0]
       int       3
M03_L19:
       mov       rcx,14F86C00070
       mov       rcx,[rcx]
       mov       rdx,rdi
       call      qword ptr [7FFE2D2D5DE8]
       mov       rdi,rax
       mov       ebp,2
       jmp       near ptr M03_L00
M03_L20:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       call      00007FFE8C836040
       mov       rsi,rax
       test      rsi,rsi
       cmove     rsi,r12
       mov       r12,rsi
       jmp       near ptr M03_L03
M03_L21:
       cmp       ebp,2
       je        near ptr M03_L27
       cmp       byte ptr [r12+18],0
       je        near ptr M03_L30
       jmp       near ptr M03_L29
M03_L22:
       movsx     rdx,byte ptr [0]
       mov       edx,[0]
       add       edx,edx
       movsx     rcx,byte ptr [0]
       xor       ecx,ecx
       mov       r8d,1C021ADD
       mov       r9d,27F45BB5
       call      qword ptr [7FFE2D03D7E8]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       jmp       near ptr M03_L07
M03_L23:
       cmp       r14d,edi
       jae       near ptr M03_L35
       mov       ecx,r14d
       mov       rcx,[r12+rcx*8+10]
       test      rcx,rcx
       je        short M03_L25
       jmp       near ptr M03_L08
M03_L24:
       inc       r14d
       mov       edi,[r12+8]
       cmp       edi,r14d
       jg        short M03_L23
       sub       r14d,edi
       jmp       short M03_L23
M03_L25:
       xor       edi,edi
       jmp       near ptr M03_L10
M03_L26:
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,1
       mov       r9d,2
       call      qword ptr [7FFE2CC1D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M03_L11
M03_L27:
       lea       rcx,[r12+28]
       mov       r8,rdi
       mov       rdx,offset MT_System.Reflection.CerHashtable<System.String, System.Reflection.RuntimeFieldInfo[]>
       call      qword ptr [7FFE2CC1F408]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M03_L28
       mov       rcx,r12
       mov       rdx,rdi
       mov       r8d,2
       mov       r9d,2
       call      qword ptr [7FFE2CC1D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M03_L28:
       mov       rdi,rax
       jmp       near ptr M03_L11
M03_L29:
       mov       rdi,[r12+8]
       jmp       near ptr M03_L11
M03_L30:
       mov       rcx,r12
       mov       r8d,ebp
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFE2CC1D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M03_L11
M03_L31:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r12,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       cmp       r12,rax
       je        near ptr M03_L34
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE2CC1ED78]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M03_L32
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE2CC1ED78]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M03_L32
       mov       ebp,1
M03_L32:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r12,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M03_L13
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE2CC1ED78]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M03_L14
       jmp       near ptr M03_L13
M03_L33:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE2CC1ED78]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M03_L17
M03_L34:
       mov       rcx,rsi
       call      qword ptr [7FFE2D2D60D0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L35:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1132
```
```assembly
; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rcx
       mov       rbx,rdx
       mov       esi,r8d
       test      rbx,rbx
       je        near ptr M04_L21
       mov       rcx,[rcx+18]
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rbp,rax
       mov       rcx,[rbp+18]
       test      cl,2
       jne       near ptr M04_L22
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
M04_L00:
       test      ecx,ecx
       jne       near ptr M04_L23
       mov       rcx,rbp
       call      00007FFE8C847850
       test      eax,eax
       jne       near ptr M04_L24
       mov       rcx,[rbp+18]
       test      cl,2
       jne       near ptr M04_L15
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M04_L15
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M04_L30
M04_L01:
       mov       rcx,rax
M04_L02:
       test      rcx,rcx
       je        near ptr M04_L32
M04_L03:
       mov       rax,19005CC1A60
       cmp       rcx,rax
       jne       near ptr M04_L31
M04_L04:
       mov       rcx,offset MT_System.Reflection.MdFieldInfo
       cmp       [rbx],rcx
       jne       near ptr M04_L33
       mov       r14d,4
M04_L05:
       cmp       r14d,2
       je        near ptr M04_L35
       cmp       r14d,10
       je        near ptr M04_L34
       mov       rcx,offset MT_System.Reflection.MdFieldInfo
       cmp       [rbx],rcx
       jne       near ptr M04_L57
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+58],xmm0
       vmovdqu   xmmword ptr [rsp+60],xmm0
       mov       rcx,19005CC19B8
       cmp       rbp,rcx
       je        near ptr M04_L36
       mov       rcx,19005CC1A60
       cmp       rbp,rcx
       sete      sil
       movzx     esi,sil
M04_L06:
       test      esi,esi
       jne       near ptr M04_L44
       mov       rcx,14F70C001C8
       mov       r14,[rcx]
       mov       rdx,rbp
       cmp       qword ptr [r14+8],0
       je        near ptr M04_L10
       mov       r15,[r14+10]
       xor       r13d,r13d
       mov       r12,[r14+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r12],rcx
       jne       near ptr M04_L39
       mov       [rsp+48],rdx
       xor       ecx,ecx
       mov       [rsp+40],rcx
       lea       rcx,[rsp+48]
       cmp       qword ptr [rsp+40],0
       jne       short M04_L07
       mov       rcx,[rsp+48]
       mov       [rsp+40],rcx
       lea       rcx,[rsp+40]
       cmp       qword ptr [rsp+40],0
       je        near ptr M04_L37
M04_L07:
       mov       rax,[rcx]
       mov       [rsp+30],rax
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rax],rcx
       jne       near ptr M04_L38
       mov       rcx,rax
       call      00007FFE8C81A6D0
       test      eax,eax
       je        near ptr M04_L16
M04_L08:
       xor       ecx,ecx
       mov       [rsp+40],rcx
M04_L09:
       mov       [rsp+54],eax
       mov       rdx,[r14+8]
       mov       ecx,eax
       imul      rcx,[r14+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M04_L59
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r10d,[rdx]
       dec       r10d
       jns       near ptr M04_L40
M04_L10:
       mov       rsi,[rbx+10]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FFE8C8453D0
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M04_L51
M04_L11:
       mov       edx,[rbx+1C]
       mov       r8d,[rsp+68]
       mov       r9,rbp
       call      qword ptr [7FFE2CC1E9B8]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
       mov       rbx,rax
       cmp       dword ptr [rsp+68],0
       jle       short M04_L12
       mov       r9d,[rbx+8]
       sub       r9d,[rsp+68]
       cmp       dword ptr [rsp+68],1
       jne       short M04_L17
       movsxd    rdx,r9d
       mov       rcx,rbx
       mov       r8,[rsp+60]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M04_L12:
       mov       rbp,rbx
       test      rbp,rbp
       je        short M04_L13
       mov       rdx,offset MT_System.Runtime.Serialization.EnumMemberAttribute[]
       cmp       [rbp],rdx
       je        short M04_L13
       mov       rdx,rbx
       mov       rcx,offset MT_System.Attribute[]
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rbp,rax
M04_L13:
       test      rbp,rbp
       je        short M04_L14
       mov       ecx,[rbp+8]
       test      ecx,ecx
       jne       near ptr M04_L18
M04_L14:
       xor       edx,edx
       jmp       near ptr M04_L19
M04_L15:
       xor       eax,eax
       jmp       near ptr M04_L01
M04_L16:
       mov       rcx,[rsp+30]
       call      qword ptr [7FFE2CC1E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M04_L08
M04_L17:
       mov       rcx,[rsp+58]
       mov       esi,[rsp+68]
       test      rcx,rcx
       je        near ptr M04_L56
       mov       rdx,[rcx]
       cmp       rdx,[rbx]
       jne       near ptr M04_L56
       cmp       dword ptr [rdx+4],18
       jne       near ptr M04_L56
       test      r9d,r9d
       jl        near ptr M04_L56
       cmp       esi,[rcx+8]
       ja        near ptr M04_L56
       lea       r8d,[r9+rsi]
       cmp       r8d,[rbx+8]
       ja        near ptr M04_L56
       movzx     r8d,word ptr [rdx]
       mov       eax,esi
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       mov       ecx,r9d
       imul      rcx,r8
       lea       rcx,[rbx+rcx+10]
       test      dword ptr [rdx],1000000
       je        near ptr M04_L54
       cmp       rax,4000
       ja        near ptr M04_L53
       mov       rdx,r10
       mov       r8,rax
       call      00007FFE8C81A2B0
       cmp       dword ptr [7FFE8CB54A90],0
       je        near ptr M04_L12
       jmp       near ptr M04_L52
M04_L18:
       test      ecx,ecx
       je        near ptr M04_L59
       mov       rax,[rbp+10]
       mov       rdx,rax
       cmp       ecx,1
       jne       near ptr M04_L58
M04_L19:
       mov       rax,rdx
       test      rax,rax
       je        short M04_L20
       mov       rcx,rdi
       cmp       [rax],rcx
       je        short M04_L20
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M04_L20:
       nop
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L21:
       mov       ecx,1A1
       mov       rdx,7FFE2CB54000
       call      qword ptr [7FFE2CE37798]
       mov       rcx,rax
       call      qword ptr [7FFE2D2D4CF0]
       int       3
M04_L22:
       xor       ecx,ecx
       jmp       near ptr M04_L00
M04_L23:
       xor       ecx,ecx
       jmp       near ptr M04_L02
M04_L24:
       mov       rcx,rbp
       call      qword ptr [7FFE2CB5A400]
       mov       r14,rax
       mov       r15,19005CC19B8
       xor       r13d,r13d
       jmp       short M04_L28
M04_L25:
       mov       rdx,[r14+r13*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r12,rax
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFE2CC1D398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M04_L27
       mov       rcx,r12
       call      00007FFE8C847850
       test      eax,eax
       je        short M04_L26
       mov       rcx,r12
       call      qword ptr [7FFE2CB5A3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M04_L27
M04_L26:
       mov       r15,r12
M04_L27:
       inc       r13d
M04_L28:
       cmp       [r14+8],r13d
       jg        short M04_L25
       mov       rcx,19005CC19B8
       cmp       r15,rcx
       jne       short M04_L29
       mov       rcx,rbp
       call      qword ptr [7FFE2CB5A3F8]
       mov       rcx,19005CC4B90
       test      al,8
       cmovne    r15,rcx
M04_L29:
       mov       rcx,r15
       jmp       near ptr M04_L02
M04_L30:
       call      qword ptr [7FFE2CC15C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M04_L01
M04_L31:
       call      qword ptr [7FFE2CC1DB00]; System.RuntimeType.GetBaseType()
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M04_L03
M04_L32:
       mov       rcx,offset MT_System.Attribute
       cmp       rdi,rcx
       je        near ptr M04_L04
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2D2D5B78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CF942B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L33:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r14d,eax
       jmp       near ptr M04_L05
M04_L34:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FFE2D13CDE0]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       mov       rbp,rax
       jmp       near ptr M04_L13
M04_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FFE2D2D5B90]
       mov       rbp,rax
       jmp       near ptr M04_L13
M04_L36:
       mov       esi,1
       jmp       near ptr M04_L06
M04_L37:
       xor       eax,eax
       jmp       near ptr M04_L08
M04_L38:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M04_L08
M04_L39:
       mov       rcx,r12
       mov       r11,7FFE2CB60AB0
       call      qword ptr [r11]
       jmp       near ptr M04_L09
M04_L40:
       mov       r14d,[r15+8]
       cmp       r10d,r14d
       jae       near ptr M04_L59
       mov       edx,r10d
       shl       rdx,4
       lea       r10,[r15+rdx+10]
       mov       [rsp+38],r10
       cmp       [r10+8],eax
       jne       short M04_L41
       mov       rdx,[r10]
       mov       rcx,r12
       mov       r8,rbp
       mov       r11,7FFE2CB60AB8
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rsp+38]
       jne       short M04_L42
M04_L41:
       mov       r10d,[r10+0C]
       inc       r13d
       cmp       r14d,r13d
       jb        short M04_L43
       test      r10d,r10d
       mov       eax,[rsp+54]
       jge       short M04_L40
       jmp       near ptr M04_L10
M04_L42:
       mov       rcx,19005CC1AF8
       cmp       rbp,rcx
       jne       short M04_L46
       jmp       short M04_L44
M04_L43:
       call      qword ptr [7FFE2CE37A08]
       int       3
M04_L44:
       mov       rcx,rbx
       call      qword ptr [7FFE2D2D5EF0]
       test      rax,rax
       je        short M04_L45
       lea       rcx,[rsp+58]
       mov       r8,rax
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FFE2CC1D4B8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M04_L45:
       test      esi,esi
       jne       short M04_L47
M04_L46:
       mov       rcx,19005CC1AA8
       cmp       rbp,rcx
       jne       short M04_L49
M04_L47:
       mov       rcx,rbx
       call      qword ptr [7FFE2D2D5F08]
       test      rax,rax
       je        short M04_L48
       lea       rcx,[rsp+58]
       mov       r8,rax
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FFE2CC1D4B8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M04_L48:
       test      esi,esi
       jne       short M04_L50
M04_L49:
       mov       rcx,19005CC1B48
       cmp       rbp,rcx
       jne       near ptr M04_L10
M04_L50:
       test      byte ptr [rbx+30],80
       je        near ptr M04_L10
       mov       rcx,offset MT_System.NonSerializedAttribute
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       lea       rcx,[rsp+58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Attribute>
       call      qword ptr [7FFE2CC1D4B8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       jmp       near ptr M04_L10
M04_L51:
       mov       rcx,rsi
       call      qword ptr [7FFE2CC17C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rcx,rax
       jmp       near ptr M04_L11
M04_L52:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L12
M04_L53:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFE2D1AE850]
       jmp       near ptr M04_L12
M04_L54:
       cmp       rax,10
       jne       short M04_L55
       vmovdqu   xmm0,xmmword ptr [r10]
       vmovdqu   xmmword ptr [rcx],xmm0
       jmp       near ptr M04_L12
M04_L55:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFE2CC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M04_L12
M04_L56:
       mov       [rsp+20],esi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,rbx
       xor       edx,edx
       call      qword ptr [7FFE2D246550]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M04_L12
M04_L57:
       movzx     r8d,sil
       mov       rcx,rbx
       mov       rdx,rbp
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rbx,rax
       jmp       near ptr M04_L12
M04_L58:
       mov       rcx,rdx
       call      qword ptr [7FFE2D2D5B18]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M04_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1855
```
```assembly
; System.String.IsNullOrEmpty(System.String)
       test      rcx,rcx
       je        short M05_L00
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
M05_L00:
       mov       eax,1
       ret
; Total bytes of code 22
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
; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1B8
       vzeroupper
       lea       rbp,[rsp+1F0]
       xor       eax,eax
       mov       [rbp-188],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M07_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M07_L00
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       esi,edx
       lea       rcx,[rbp-158]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp-140],rcx
       mov       rcx,rbp
       mov       [rbp-130],rcx
       test      sil,sil
       je        near ptr M07_L35
       mov       [rbp+10],rbx
       mov       [rbp-50],rbx
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-60],xmm0
       lea       rcx,[rbp-50]
       mov       [rbp-60],rcx
       mov       rcx,[rbp-50]
       test      rcx,rcx
       je        near ptr M07_L41
       mov       rcx,[rcx+18]
M07_L01:
       mov       [rbp-58],rcx
       vmovups   xmm0,[rbp-60]
       vmovups   [rbp-168],xmm0
       lea       rcx,[rbp-168]
       lea       rdx,[rbp-40]
       lea       r8,[rbp-48]
       mov       r9d,1
       mov       rax,7FFE2CB54EE8
       mov       [rbp-148],rax
       lea       rax,[M07_L02]
       mov       [rbp-138],rax
       lea       rax,[rbp-158]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFE8C77E150
       call      rax
M07_L02:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M07_L03
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M07_L03:
       mov       rcx,[rbp-150]
       mov       [rdi+8],rcx
       mov       rbx,[rbp-50]
       cmp       [rbx],bl
       mov       rcx,[rbx+18]
       call      00007FFE8C84BEA0
       test      rax,rax
       jne       near ptr M07_L19
M07_L04:
       mov       rcx,14F70C001C8
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+8],0
       je        near ptr M07_L09
       mov       r14,[rsi+10]
       xor       r15d,r15d
       mov       r13,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r13],rcx
       jne       near ptr M07_L44
       mov       rcx,19005CC5F08
       mov       [rbp-68],rcx
       xor       ecx,ecx
       mov       [rbp-70],rcx
       lea       rcx,[rbp-68]
       cmp       qword ptr [rbp-70],0
       jne       short M07_L05
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       lea       rcx,[rbp-70]
       cmp       qword ptr [rbp-70],0
       je        near ptr M07_L42
M07_L05:
       mov       r12,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M07_L43
       mov       rcx,r12
       call      00007FFE8C81A6D0
       test      eax,eax
       je        near ptr M07_L20
M07_L06:
       mov       r12d,eax
M07_L07:
       xor       ecx,ecx
       mov       [rbp-70],rcx
M07_L08:
       mov       rdx,[rsi+8]
       mov       ecx,r12d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M07_L55
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       eax,[rdx]
       dec       eax
       jns       near ptr M07_L45
M07_L09:
       mov       rcx,rbx
       call      00007FFE8C8453D0
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M07_L49
M07_L10:
       mov       [rbp-190],rsi
       mov       rcx,rbx
       call      00007FFE8C848680
       mov       ebx,eax
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FFE8C891F10
       mov       [rbp-78],rax
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-0C8],ymm0
       vmovdqu   ymmword ptr [rbp-0A8],ymm0
       vmovdqu   xmmword ptr [rbp-88],xmm0
       mov       dword ptr [rbp-118],10
       mov       rcx,[rbp-78]
       lea       r9,[rbp-0BC]
       mov       [rsp+20],r9
       lea       r9,[rbp-0C8]
       mov       [rsp+28],r9
       lea       r9,[rbp-118]
       mov       r8d,ebx
       mov       edx,0C000000
       mov       rax,7FFE2CD5B248
       mov       [rbp-148],rax
       lea       rax,[M07_L11]
       mov       [rbp-138],rax
       lea       rax,[rbp-158]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFE8C77EA40
       call      rax
M07_L11:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M07_L12
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M07_L12:
       mov       r8,[rbp-150]
       mov       [rdi+8],r8
       mov       r8d,[rbp-118]
       mov       [rbp-0C0],r8d
       cmp       dword ptr [rbp-0C0],0
       jne       near ptr M07_L21
M07_L13:
       xor       ecx,ecx
M07_L14:
       xor       eax,eax
       mov       [rbp-100],rax
       mov       [rbp-108],rax
       test      ecx,ecx
       jne       near ptr M07_L48
M07_L15:
       xor       ebx,ebx
M07_L16:
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbp-40]
       mov       r14,[rbp-48]
       mov       [rsi+18],bl
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,1
       mov       ebx,[rdi+8]
       cmp       ebx,1
       jle       near ptr M07_L29
M07_L17:
       lea       eax,[rcx-1]
       cmp       eax,ebx
       jae       near ptr M07_L55
       lea       rax,[rdi+rax*4+10]
       mov       edx,[rdi+rcx*4+10]
       cmp       [rax],edx
       jae       near ptr M07_L26
M07_L18:
       inc       ecx
       cmp       ebx,ecx
       jg        short M07_L17
       jmp       near ptr M07_L29
M07_L19:
       mov       rcx,rax
       call      qword ptr [7FFE2CC15860]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       test      rax,rax
       jne       short M07_L15
       jmp       near ptr M07_L04
M07_L20:
       mov       rcx,r12
       call      qword ptr [7FFE2CC1E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L06
M07_L21:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       vmovdqu   xmmword ptr [rbp-0D8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F8],xmm0
       vmovdqu   xmmword ptr [rbp-0F0],xmm0
       xor       esi,esi
       cmp       dword ptr [rbp-0C0],0
       jle       near ptr M07_L24
M07_L22:
       cmp       qword ptr [rbp-0C8],0
       jne       near ptr M07_L25
       cmp       esi,10
       jae       near ptr M07_L55
       lea       r8,[rbp-0BC]
       mov       edx,[r8+rsi*4]
M07_L23:
       lea       r8,[rbp-0D0]
       lea       r9,[rbp-0E0]
       mov       rcx,[rbp-78]
       call      00007FFE8C849180
       test      eax,eax
       jl        near ptr M07_L50
       mov       ecx,[rbp-0D0]
       mov       rdx,19005CC5F08
       mov       [rsp+20],rdx
       xor       edx,edx
       mov       [rsp+28],edx
       lea       rdx,[rbp-0F8]
       mov       [rsp+30],rdx
       lea       rdx,[rbp-100]
       mov       [rsp+38],rdx
       lea       rdx,[rbp-108]
       mov       [rsp+40],rdx
       lea       rdx,[rbp-110]
       mov       [rsp+48],rdx
       lea       rdx,[rbp-78]
       mov       r8,[rbp-190]
       mov       r9d,ebx
       call      qword ptr [7FFE2CC1EBB0]; System.Reflection.CustomAttribute.FilterCustomAttributeRecord(System.Reflection.MetadataToken, System.Reflection.MetadataImport ByRef, System.Reflection.RuntimeModule, System.Reflection.MetadataToken, System.RuntimeType, Boolean, ListBuilder`1<System.Object> ByRef, System.RuntimeType ByRef, System.IRuntimeMethodInfo ByRef, Boolean ByRef)
       test      eax,eax
       jne       near ptr M07_L51
       inc       esi
       cmp       esi,[rbp-0C0]
       jl        near ptr M07_L22
M07_L24:
       jmp       near ptr M07_L13
M07_L25:
       mov       rdx,[rbp-0C8]
       cmp       esi,[rdx+8]
       jae       near ptr M07_L55
       mov       edx,[rdx+rsi*4+10]
       jmp       near ptr M07_L23
M07_L26:
       cmp       [rax],edx
       jbe       near ptr M07_L18
       mov       r15d,ebx
       test      r14,r14
       je        short M07_L27
       mov       ecx,[r14+8]
       sub       ecx,r15d
       js        near ptr M07_L52
M07_L27:
       test      r14,r14
       je        near ptr M07_L34
       lea       r13,[rdi+10]
       add       r14,10
       test      byte ptr [7FFE2D3A3898],1
       je        near ptr M07_L53
M07_L28:
       mov       rcx,14F86C00330
       mov       rcx,[rcx]
       mov       [rbp-178],r13
       mov       [rbp-170],r15d
       mov       [rbp-188],r14
       mov       [rbp-180],r15d
       lea       r8,[rbp-188]
       lea       rdx,[rbp-178]
       mov       r11,7FFE2CB60C50
       xor       r9d,r9d
       call      qword ptr [r11]
M07_L29:
       xor       r8d,r8d
       test      ebx,ebx
       jle       short M07_L31
M07_L30:
       mov       edx,[rdi+r8*4+10]
       mov       [rbp-120],rdx
       movsxd    rdx,r8d
       cmp       [rbp-120],rdx
       jne       near ptr M07_L54
       inc       r8d
       cmp       ebx,r8d
       jg        short M07_L30
M07_L31:
       mov       r8d,1
M07_L32:
       mov       [rsi+19],r8b
       xor       r8d,r8d
       mov       [rbp-40],r8
       mov       [rbp-48],r8
       mov       rbx,[rbp+10]
       cmp       [rbx],bl
       mov       r8,rsi
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.Enum+EnumInfo<System.UInt32>>
       call      qword ptr [7FFE2CE3DF68]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].Replace(System.RuntimeType, System.__Canon)
M07_L33:
       mov       rax,rsi
       add       rsp,1B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L34:
       mov       rcx,rdi
       mov       r8d,r15d
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFE2D2D71E0]
       jmp       near ptr M07_L29
M07_L35:
       cmp       qword ptr [rbx+10],0
       je        short M07_L36
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       test      rax,rax
       je        short M07_L36
       jmp       short M07_L37
M07_L36:
       mov       rcx,rbx
       call      qword ptr [7FFE2CC17C30]; System.RuntimeType.InitializeCache()
M07_L37:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M07_L39
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M07_L38
       mov       rsi,rax
       jmp       short M07_L40
M07_L38:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M07_L39
       mov       rsi,[rax+28]
       test      rsi,rsi
       je        short M07_L39
       jmp       short M07_L40
M07_L39:
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.Enum+EnumInfo<System.UInt32>>
       call      qword ptr [7FFE2CC1C4F8]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       rsi,rax
M07_L40:
       jmp       near ptr M07_L33
M07_L41:
       xor       ecx,ecx
       jmp       near ptr M07_L01
M07_L42:
       xor       r12d,r12d
       jmp       near ptr M07_L07
M07_L43:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
       jmp       near ptr M07_L07
M07_L44:
       mov       rcx,r13
       mov       rdx,19005CC5F08
       mov       r11,7FFE2CB60C40
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M07_L08
M07_L45:
       mov       esi,[r14+8]
       cmp       eax,esi
       jae       near ptr M07_L55
       mov       edx,eax
       shl       rdx,4
       lea       rax,[r14+rdx+10]
       mov       [rbp-198],rax
       cmp       [rax+8],r12d
       jne       short M07_L46
       mov       rdx,[rax]
       mov       rcx,r13
       mov       r8,19005CC5F08
       mov       r11,7FFE2CB60C48
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-198]
       jne       near ptr M07_L09
M07_L46:
       mov       eax,[rax+0C]
       inc       r15d
       cmp       esi,r15d
       jb        short M07_L47
       test      eax,eax
       jge       short M07_L45
       jmp       near ptr M07_L09
M07_L47:
       call      qword ptr [7FFE2CE37A08]
       int       3
M07_L48:
       mov       ebx,1
       jmp       near ptr M07_L16
M07_L49:
       mov       rcx,rbx
       call      qword ptr [7FFE2CC17C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rsi,rax
       jmp       near ptr M07_L10
M07_L50:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2D58D8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L51:
       mov       ecx,1
       jmp       near ptr M07_L14
M07_L52:
       mov       ecx,10
       call      qword ptr [7FFE2D2DE010]
       int       3
M07_L53:
       mov       rcx,offset MT_System.Collections.Generic.ArraySortHelper<System.UInt32, System.String>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M07_L28
M07_L54:
       xor       r8d,r8d
       jmp       near ptr M07_L32
M07_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1945
```
```assembly
; System.Enum.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
M08_L00:
       mov       rcx,rbx
       call      qword ptr [7FFE2CC1C9A8]; System.Object.GetType()
       mov       rsi,rax
       lea       rdi,[rbx+8]
       mov       rcx,[rbx]
       call      00007FFE8C84E010
       add       eax,0FFFFFFFC
       cmp       eax,4
       jne       near ptr M08_L08
       mov       edi,[rdi]
       mov       rbx,[rsi+10]
       test      rbx,rbx
       je        near ptr M08_L27
       mov       rax,[rbx]
       test      rax,rax
       je        near ptr M08_L27
M08_L01:
       mov       rcx,[rax+80]
       test      rcx,rcx
       je        short M08_L07
       mov       rdx,offset MT_System.Enum+EnumInfo<System.UInt32>
       cmp       [rcx],rdx
       je        short M08_L03
       mov       rdx,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       [rcx],rdx
       je        short M08_L02
       xor       ecx,ecx
M08_L02:
       test      rcx,rcx
       je        short M08_L07
       mov       rcx,[rcx+28]
M08_L03:
       test      rcx,rcx
       je        near ptr M08_L28
       cmp       qword ptr [rcx+10],0
       je        near ptr M08_L28
M08_L04:
       cmp       byte ptr [rcx+18],0
       jne       near ptr M08_L35
       mov       rsi,[rcx+10]
       cmp       byte ptr [rcx+19],0
       je        near ptr M08_L29
       mov       ebx,[rsi+8]
       cmp       ebx,edi
       jbe       near ptr M08_L34
       mov       ecx,edi
       mov       rax,[rsi+rcx*8+10]
M08_L05:
       test      rax,rax
       je        near ptr M08_L36
M08_L06:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L07:
       xor       ecx,ecx
       jmp       short M08_L03
M08_L08:
       cmp       eax,7
       ja        short M08_L09
       mov       ecx,eax
       lea       rdx,[7FFE2D34F150]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M08_L00]
       add       rdx,rax
       jmp       rdx
M08_L09:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFE2D2D7720]
       jmp       short M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFE2D2D7498]
       jmp       short M08_L06
       movzx     edi,byte ptr [rdi]
       mov       rbx,[rsi+10]
       test      rbx,rbx
       je        short M08_L10
       mov       rax,[rbx]
       test      rax,rax
       je        short M08_L10
       jmp       short M08_L11
M08_L10:
       mov       rcx,rsi
       call      qword ptr [7FFE2CC17C30]; System.RuntimeType.InitializeCache()
M08_L11:
       mov       rbx,[rax+80]
       test      rbx,rbx
       je        short M08_L13
       mov       rdx,rbx
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M08_L12
       mov       rcx,rax
       jmp       short M08_L14
M08_L12:
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M08_L13
       mov       rcx,[rax+28]
       jmp       short M08_L14
M08_L13:
       xor       ecx,ecx
M08_L14:
       test      rcx,rcx
       je        short M08_L15
       cmp       qword ptr [rcx+10],0
       jne       short M08_L16
M08_L15:
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFE2D2D7558]
       mov       rcx,rax
M08_L16:
       cmp       byte ptr [rcx+18],0
       jne       short M08_L24
       mov       rsi,[rcx+10]
       cmp       byte ptr [rcx+19],0
       je        short M08_L17
       cmp       [rsi+8],edi
       jbe       short M08_L22
       mov       eax,edi
       mov       rax,[rsi+rax*8+10]
       jmp       short M08_L23
M08_L17:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M08_L18
       xor       eax,eax
       xor       r8d,r8d
       jmp       short M08_L19
M08_L18:
       lea       rax,[rcx+10]
       mov       r8d,[rcx+8]
M08_L19:
       cmp       dword ptr [rcx+8],20
       jle       short M08_L20
       mov       rcx,rax
       mov       edx,r8d
       mov       r8d,edi
       call      qword ptr [7FFE2D2D7678]
       jmp       short M08_L21
M08_L20:
       mov       rcx,rax
       mov       edx,edi
       call      qword ptr [7FFE2D1A6508]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Byte, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib]](Byte ByRef, Byte, Int32)
M08_L21:
       cmp       [rsi+8],eax
       jbe       short M08_L22
       mov       ecx,eax
       mov       rax,[rsi+rcx*8+10]
       jmp       short M08_L23
M08_L22:
       xor       eax,eax
M08_L23:
       jmp       short M08_L25
M08_L24:
       mov       edx,edi
       call      qword ptr [7FFE2D2D74B0]
M08_L25:
       test      rax,rax
       jne       short M08_L26
       mov       ecx,edi
       call      qword ptr [7FFE2CC179F0]; System.Number.UInt32ToDecStr(UInt32)
M08_L26:
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFE2D2D7468]
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFE2D2D7450]
       jmp       near ptr M08_L06
M08_L27:
       mov       rcx,rsi
       call      qword ptr [7FFE2CC17C30]; System.RuntimeType.InitializeCache()
       jmp       near ptr M08_L01
M08_L28:
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFE2CE3DE48]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       mov       rcx,rax
       jmp       near ptr M08_L04
M08_L29:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M08_L30
       xor       eax,eax
       xor       r8d,r8d
       jmp       short M08_L31
M08_L30:
       lea       rax,[rcx+10]
       mov       r8d,[rcx+8]
M08_L31:
       cmp       dword ptr [rcx+8],20
       jle       short M08_L32
       mov       rcx,rax
       mov       edx,r8d
       mov       r8d,edi
       call      qword ptr [7FFE2D2D6D00]
       jmp       short M08_L33
M08_L32:
       mov       rcx,rax
       mov       edx,edi
       call      qword ptr [7FFE2D2D6F10]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
M08_L33:
       mov       ebx,[rsi+8]
       cmp       ebx,eax
       jbe       short M08_L34
       mov       ecx,eax
       mov       rax,[rsi+rcx*8+10]
       jmp       near ptr M08_L05
M08_L34:
       xor       eax,eax
       jmp       near ptr M08_L05
M08_L35:
       mov       edx,edi
       call      qword ptr [7FFE2D2D76D8]
       jmp       near ptr M08_L05
M08_L36:
       mov       ecx,edi
       call      qword ptr [7FFE2CD8F210]; System.Number.Int32ToDecStr(Int32)
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFE2D2D7420]
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFE2D2D7408]
       jmp       near ptr M08_L06
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFE2D2D73F0]
       jmp       near ptr M08_L06
; Total bytes of code 761
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetDescription_NoCache_ForComparison()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],6D
       mov       rcx,rax
       call      qword ptr [7FFE2D24E3A0]; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetDescriptionNoCache(System.Enum)
       mov       [rsp+28],rax
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetDescriptionNoCache(System.Enum)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A8
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqa   xmmword ptr [rsp+90],xmm4
       xor       eax,eax
       mov       [rsp+0A0],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L45
       mov       rcx,rbx
       call      qword ptr [7FFE2CC1C9A8]; System.Object.GetType()
       mov       rsi,rax
       mov       rcx,[rsi+18]
       test      cl,2
       jne       near ptr M01_L46
       mov       rcx,[rcx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M01_L00:
       test      eax,eax
       je        near ptr M01_L47
       mov       rcx,[rsi+18]
       test      cl,2
       jne       near ptr M01_L36
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.Enum
       cmp       rcx,rax
       sete      cl
       movzx     ecx,cl
M01_L01:
       test      ecx,ecx
       je        near ptr M01_L48
M01_L02:
       mov       rcx,rbx
       call      qword ptr [7FFE2D24E4A8]; System.Enum.ToUInt64(System.Object)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE2D24E508]; System.Enum.GetName(System.RuntimeType, UInt64)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L49
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,1C
       call      qword ptr [7FFE2CB5A490]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       mov       rbx,rax
       test      rbx,rbx
       je        near ptr M01_L101
       mov       rsi,203B9260AC8
       mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L50
       mov       rcx,rsi
       call      00007FFE8C847850
       test      eax,eax
       jne       near ptr M01_L51
       mov       rcx,[7FFE2D2AB0A8]
       test      rcx,rcx
       je        near ptr M01_L37
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L57
M01_L03:
       mov       rcx,rax
M01_L04:
       test      rcx,rcx
       je        near ptr M01_L59
M01_L05:
       mov       rax,203B9251A60
       cmp       rcx,rax
       jne       near ptr M01_L58
       mov       rbp,[rbx]
       mov       r14,offset MT_System.Reflection.MdFieldInfo
       cmp       rbp,r14
       jne       near ptr M01_L60
       mov       r15d,4
M01_L06:
       cmp       r15d,2
       je        near ptr M01_L62
       cmp       r15d,10
       je        near ptr M01_L61
       cmp       rbp,r14
       jne       near ptr M01_L72
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+90],xmm0
       vmovdqu   xmmword ptr [rsp+98],xmm0
       mov       rcx,1C3244001C8
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L12
       mov       r15,[rsi+10]
       xor       r13d,r13d
       mov       r12,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r12],rcx
       jne       near ptr M01_L65
       mov       rcx,203B9260AC8
       mov       [rsp+80],rcx
       xor       ecx,ecx
       mov       [rsp+78],rcx
       lea       rcx,[rsp+80]
       cmp       qword ptr [rsp+78],0
       jne       short M01_L07
       mov       rcx,[rsp+80]
       mov       [rsp+78],rcx
       lea       rcx,[rsp+78]
       cmp       qword ptr [rsp+78],0
       je        near ptr M01_L63
M01_L07:
       mov       rax,[rcx]
       mov       [rsp+40],rax
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rax],rcx
       jne       near ptr M01_L64
       mov       rcx,rax
       call      00007FFE8C81A6D0
       test      eax,eax
       je        near ptr M01_L38
M01_L08:
       xor       ecx,ecx
       mov       [rsp+78],rcx
M01_L09:
       mov       [rsp+8C],eax
       mov       rdx,[rsi+8]
       mov       ecx,eax
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M01_L102
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r10d,[rdx]
       dec       r10d
       js        short M01_L12
M01_L10:
       mov       esi,[r15+8]
       cmp       r10d,esi
       jae       near ptr M01_L102
       mov       edx,r10d
       shl       rdx,4
       lea       r10,[r15+rdx+10]
       mov       [rsp+48],r10
       cmp       [r10+8],eax
       je        near ptr M01_L66
M01_L11:
       mov       r10d,[r10+0C]
       inc       r13d
       cmp       esi,r13d
       jb        near ptr M01_L92
       test      r10d,r10d
       mov       eax,[rsp+8C]
       jge       short M01_L10
M01_L12:
       mov       rsi,[rbx+10]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FFE8C8453D0
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L67
M01_L13:
       mov       edx,[rbx+1C]
       mov       r8d,[rsp+0A0]
       mov       r9,203B9260AC8
       call      qword ptr [7FFE2CC1E9B8]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
       mov       rsi,rax
       cmp       dword ptr [rsp+0A0],0
       jle       short M01_L14
       mov       r9d,[rsi+8]
       sub       r9d,[rsp+0A0]
       cmp       dword ptr [rsp+0A0],1
       jne       near ptr M01_L39
       movsxd    rdx,r9d
       mov       rcx,rsi
       mov       r8,[rsp+98]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M01_L14:
       mov       r15,rsi
       test      r15,r15
       je        short M01_L15
       mov       rdx,offset MT_System.ComponentModel.DescriptionAttribute[]
       cmp       [r15],rdx
       je        short M01_L15
       mov       rdx,rsi
       mov       rcx,offset MT_System.Attribute[]
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
M01_L15:
       test      r15,r15
       je        near ptr M01_L40
       mov       ecx,[r15+8]
       test      ecx,ecx
       je        near ptr M01_L40
       test      ecx,ecx
       je        near ptr M01_L102
       mov       rax,[r15+10]
       mov       rdx,rax
       cmp       ecx,1
       jne       near ptr M01_L73
M01_L16:
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L17
       mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute
       cmp       [rsi],rcx
       je        short M01_L17
       call      qword ptr [7FFE2CC1FD08]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rsi,rax
M01_L17:
       test      rsi,rsi
       jne       near ptr M01_L74
M01_L18:
       mov       rsi,203B9260AF0
       mov       rcx,offset MT_System.Runtime.Serialization.EnumMemberAttribute
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L75
       mov       rcx,rsi
       call      00007FFE8C847850
       test      eax,eax
       jne       near ptr M01_L76
       mov       rcx,[7FFE2D2AB268]
       test      rcx,rcx
       je        near ptr M01_L41
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L82
M01_L19:
       mov       rcx,rax
M01_L20:
       test      rcx,rcx
       je        near ptr M01_L84
M01_L21:
       mov       rax,203B9251A60
       cmp       rcx,rax
       jne       near ptr M01_L83
       cmp       rbp,r14
       jne       near ptr M01_L85
       mov       r15d,4
M01_L22:
       cmp       r15d,2
       je        near ptr M01_L87
       cmp       r15d,10
       je        near ptr M01_L86
       cmp       rbp,r14
       jne       near ptr M01_L98
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vmovdqu   xmmword ptr [rsp+68],xmm0
       mov       rcx,1C3244001C8
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+8],0
       je        near ptr M01_L29
       mov       rbp,[rsi+10]
       xor       r14d,r14d
       mov       r15,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r15],rcx
       jne       near ptr M01_L90
       mov       rcx,203B9260AF0
       mov       [rsp+58],rcx
       xor       ecx,ecx
       mov       [rsp+50],rcx
       lea       rcx,[rsp+58]
       cmp       qword ptr [rsp+50],0
       jne       short M01_L23
       mov       rcx,[rsp+58]
       mov       [rsp+50],rcx
       lea       rcx,[rsp+50]
       cmp       qword ptr [rsp+50],0
       je        near ptr M01_L88
M01_L23:
       mov       r13,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M01_L89
       mov       rcx,r13
       call      00007FFE8C81A6D0
       test      eax,eax
       je        near ptr M01_L42
M01_L24:
       mov       r13d,eax
M01_L25:
       xor       ecx,ecx
       mov       [rsp+50],rcx
M01_L26:
       mov       rdx,[rsi+8]
       mov       ecx,r13d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M01_L102
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       eax,[rdx]
       dec       eax
       js        short M01_L29
M01_L27:
       mov       esi,[rbp+8]
       cmp       eax,esi
       jae       near ptr M01_L102
       mov       edx,eax
       shl       rdx,4
       lea       r12,[rbp+rdx+10]
       cmp       [r12+8],r13d
       je        near ptr M01_L91
M01_L28:
       mov       eax,[r12+0C]
       inc       r14d
       cmp       esi,r14d
       jb        near ptr M01_L92
       test      eax,eax
       jge       short M01_L27
M01_L29:
       mov       rsi,[rbx+10]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FFE8C8453D0
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L93
M01_L30:
       mov       edx,[rbx+1C]
       mov       r8d,[rsp+70]
       mov       r9,203B9260AF0
       call      qword ptr [7FFE2CC1E9B8]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
       mov       rbx,rax
       cmp       dword ptr [rsp+70],0
       jle       short M01_L31
       mov       r9d,[rbx+8]
       sub       r9d,[rsp+70]
       cmp       dword ptr [rsp+70],1
       jne       near ptr M01_L43
       movsxd    rdx,r9d
       mov       rcx,rbx
       mov       r8,[rsp+68]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M01_L31:
       mov       rbp,rbx
       test      rbp,rbp
       je        short M01_L32
       mov       rdx,offset MT_System.ComponentModel.DescriptionAttribute[]
       cmp       [rbp],rdx
       je        short M01_L32
       mov       rdx,rbx
       mov       rcx,offset MT_System.Attribute[]
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rbp,rax
M01_L32:
       test      rbp,rbp
       je        near ptr M01_L44
       mov       ecx,[rbp+8]
       test      ecx,ecx
       je        near ptr M01_L44
       test      ecx,ecx
       je        near ptr M01_L102
       mov       rax,[rbp+10]
       mov       rdx,rax
       cmp       ecx,1
       jne       near ptr M01_L99
M01_L33:
       mov       rcx,rdx
       test      rcx,rcx
       je        short M01_L34
       mov       rax,offset MT_System.Runtime.Serialization.EnumMemberAttribute
       cmp       [rcx],rax
       jne       near ptr M01_L100
M01_L34:
       test      rcx,rcx
       je        near ptr M01_L101
       mov       rax,[rcx+8]
       mov       rdx,rax
       test      rdx,rdx
       je        near ptr M01_L101
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L101
M01_L35:
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L36:
       xor       ecx,ecx
       jmp       near ptr M01_L01
M01_L37:
       xor       eax,eax
       jmp       near ptr M01_L03
M01_L38:
       mov       rcx,[rsp+40]
       call      qword ptr [7FFE2CC1E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L08
M01_L39:
       mov       rcx,[rsp+90]
       mov       r15d,[rsp+0A0]
       test      rcx,rcx
       je        near ptr M01_L71
       mov       rdx,[rcx]
       cmp       rdx,[rsi]
       jne       near ptr M01_L71
       cmp       dword ptr [rdx+4],18
       jne       near ptr M01_L71
       test      r9d,r9d
       jl        near ptr M01_L71
       cmp       r15d,[rcx+8]
       ja        near ptr M01_L71
       lea       r8d,[r9+r15]
       cmp       r8d,[rsi+8]
       ja        near ptr M01_L71
       movzx     r8d,word ptr [rdx]
       mov       eax,r15d
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       mov       ecx,r9d
       imul      rcx,r8
       lea       rcx,[rsi+rcx+10]
       test      dword ptr [rdx],1000000
       je        near ptr M01_L70
       cmp       rax,4000
       ja        near ptr M01_L69
       mov       rdx,r10
       mov       r8,rax
       call      00007FFE8C81A2B0
       cmp       dword ptr [7FFE8CB54A90],0
       je        near ptr M01_L14
       jmp       near ptr M01_L68
M01_L40:
       xor       edx,edx
       jmp       near ptr M01_L16
M01_L41:
       xor       eax,eax
       jmp       near ptr M01_L19
M01_L42:
       mov       rcx,r13
       call      qword ptr [7FFE2CC1E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L24
M01_L43:
       mov       rcx,[rsp+60]
       mov       esi,[rsp+70]
       test      rcx,rcx
       je        near ptr M01_L97
       mov       rdx,[rcx]
       cmp       rdx,[rbx]
       jne       near ptr M01_L97
       cmp       dword ptr [rdx+4],18
       jne       near ptr M01_L97
       test      r9d,r9d
       jl        near ptr M01_L97
       cmp       esi,[rcx+8]
       ja        near ptr M01_L97
       lea       r8d,[r9+rsi]
       cmp       r8d,[rbx+8]
       ja        near ptr M01_L97
       movzx     r8d,word ptr [rdx]
       mov       eax,esi
       imul      rax,r8
       add       rcx,10
       mov       r10,rcx
       mov       ecx,r9d
       imul      rcx,r8
       lea       rcx,[rbx+rcx+10]
       test      dword ptr [rdx],1000000
       je        near ptr M01_L96
       cmp       rax,4000
       ja        near ptr M01_L95
       mov       rdx,r10
       mov       r8,rax
       call      00007FFE8C81A2B0
       cmp       dword ptr [7FFE8CB54A90],0
       je        near ptr M01_L31
       jmp       near ptr M01_L94
M01_L44:
       xor       edx,edx
       jmp       near ptr M01_L33
M01_L45:
       call      qword ptr [7FFE2D1AEE80]
       mov       ecx,7
       mov       rdx,7FFE2CEE2E38
       call      qword ptr [7FFE2CE37798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CC17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,5
       mov       rdx,7FFE2CEE2E38
       call      qword ptr [7FFE2CE37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CC17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE2D2CCAC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE2D2C5638]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L46:
       mov       rcx,rsi
       mov       rdx,203B9255F30
       call      qword ptr [7FFE2CB5A608]; System.RuntimeType.IsSubclassOf(System.Type)
       jmp       near ptr M01_L00
M01_L47:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,13
       mov       rdx,7FFE2CEE2E38
       call      qword ptr [7FFE2CE37798]
       mov       rsi,rax
       mov       ecx,7
       mov       rdx,7FFE2CEE2E38
       call      qword ptr [7FFE2CE37798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE2CF961A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L48:
       mov       rcx,rsi
       call      qword ptr [7FFE2D2C6AD8]; System.Type.IsIntegerType(System.Type)
       test      eax,eax
       jne       near ptr M01_L02
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2D2C6AF0]
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFE2CB54000
       call      qword ptr [7FFE2CE37798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE2CF961A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L49:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       jmp       near ptr M01_L35
M01_L50:
       xor       ecx,ecx
       jmp       near ptr M01_L04
M01_L51:
       mov       rcx,rsi
       call      qword ptr [7FFE2CB5A400]
       mov       rbp,rax
       mov       r14,203B92519B8
       xor       r15d,r15d
       jmp       short M01_L55
M01_L52:
       mov       rdx,[rbp+r15*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r13,rax
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFE2CC1D398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M01_L54
       mov       rcx,r13
       call      00007FFE8C847850
       test      eax,eax
       je        short M01_L53
       mov       rcx,r13
       call      qword ptr [7FFE2CB5A3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M01_L54
M01_L53:
       mov       r14,r13
M01_L54:
       inc       r15d
M01_L55:
       cmp       [rbp+8],r15d
       jg        short M01_L52
       mov       rcx,203B92519B8
       cmp       r14,rcx
       jne       short M01_L56
       mov       rcx,rsi
       call      qword ptr [7FFE2CB5A3F8]
       mov       rcx,203B9254B90
       test      al,8
       cmovne    r14,rcx
M01_L56:
       mov       rcx,r14
       jmp       near ptr M01_L04
M01_L57:
       call      qword ptr [7FFE2CC15C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M01_L03
M01_L58:
       call      qword ptr [7FFE2CC1DB00]; System.RuntimeType.GetBaseType()
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L05
M01_L59:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2D2C5AD0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2CF942B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L60:
       mov       rcx,rbx
       mov       rax,[rbp+40]
       call      qword ptr [rax+28]
       mov       r15d,eax
       jmp       near ptr M01_L06
M01_L61:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE2D13CDE0]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       mov       r15,rax
       jmp       near ptr M01_L15
M01_L62:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE2D2C5AE8]
       mov       r15,rax
       jmp       near ptr M01_L15
M01_L63:
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L64:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L08
M01_L65:
       mov       rcx,r12
       mov       rdx,203B9260AC8
       mov       r11,7FFE2CB60AD8
       call      qword ptr [r11]
       jmp       near ptr M01_L09
M01_L66:
       mov       rdx,[r10]
       mov       rcx,r12
       mov       r8,203B9260AC8
       mov       r11,7FFE2CB60AE0
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rsp+48]
       je        near ptr M01_L11
       jmp       near ptr M01_L12
M01_L67:
       mov       rcx,rsi
       call      qword ptr [7FFE2CC17C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rcx,rax
       jmp       near ptr M01_L13
M01_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L14
M01_L69:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFE2D1AE8F8]
       jmp       near ptr M01_L14
M01_L70:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFE2CC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L14
M01_L71:
       mov       [rsp+20],r15d
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,rsi
       xor       edx,edx
       call      qword ptr [7FFE2D246538]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L14
M01_L72:
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[rbp+48]
       call      qword ptr [rax+28]
       mov       rsi,rax
       jmp       near ptr M01_L14
M01_L73:
       mov       rcx,rdx
       call      qword ptr [7FFE2D2C5A70]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L74:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       test      rax,rax
       je        near ptr M01_L18
       cmp       dword ptr [rax+8],0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L18
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L35
M01_L75:
       xor       ecx,ecx
       jmp       near ptr M01_L20
M01_L76:
       mov       rcx,rsi
       call      qword ptr [7FFE2CB5A400]
       mov       r15,rax
       mov       r13,203B92519B8
       xor       r12d,r12d
       jmp       short M01_L80
M01_L77:
       cmp       r12d,[r15+8]
       jae       near ptr M01_L102
       mov       rdx,[r15+r12*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       [rsp+38],rax
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE2CC1D398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M01_L79
       mov       rcx,[rsp+38]
       call      00007FFE8C847850
       test      eax,eax
       je        short M01_L78
       mov       rcx,[rsp+38]
       call      qword ptr [7FFE2CB5A3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M01_L79
M01_L78:
       mov       r13,[rsp+38]
M01_L79:
       inc       r12d
M01_L80:
       cmp       [r15+8],r12d
       jg        short M01_L77
       mov       rcx,203B92519B8
       cmp       r13,rcx
       jne       short M01_L81
       mov       rcx,rsi
       call      qword ptr [7FFE2CB5A3F8]
       mov       rcx,203B9254B90
       test      al,8
       cmovne    r13,rcx
M01_L81:
       mov       rcx,r13
       jmp       near ptr M01_L20
M01_L82:
       call      qword ptr [7FFE2CC15C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M01_L19
M01_L83:
       call      qword ptr [7FFE2CC1DB00]; System.RuntimeType.GetBaseType()
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L21
M01_L84:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE2D2C5AD0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE2CF942B8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L85:
       mov       rcx,rbx
       mov       rax,[rbp+40]
       call      qword ptr [rax+28]
       mov       r15d,eax
       jmp       near ptr M01_L22
M01_L86:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE2D13CDE0]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       mov       rbp,rax
       jmp       near ptr M01_L32
M01_L87:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE2D2C5AE8]
       mov       rbp,rax
       jmp       near ptr M01_L32
M01_L88:
       xor       r13d,r13d
       jmp       near ptr M01_L25
M01_L89:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M01_L25
M01_L90:
       mov       rcx,r15
       mov       rdx,203B9260AF0
       mov       r11,7FFE2CB60AE8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L26
M01_L91:
       mov       rdx,[r12]
       mov       rcx,r15
       mov       r8,203B9260AF0
       mov       r11,7FFE2CB60AF0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L28
       jmp       near ptr M01_L29
M01_L92:
       call      qword ptr [7FFE2CE37A08]
       int       3
M01_L93:
       mov       rcx,rsi
       call      qword ptr [7FFE2CC17C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rcx,rax
       jmp       near ptr M01_L30
M01_L94:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L31
M01_L95:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFE2D1AE8F8]
       jmp       near ptr M01_L31
M01_L96:
       mov       rdx,r10
       mov       r8,rax
       call      qword ptr [7FFE2CC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L31
M01_L97:
       mov       [rsp+20],esi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,rbx
       xor       edx,edx
       call      qword ptr [7FFE2D246538]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L31
M01_L98:
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[rbp+48]
       call      qword ptr [rax+28]
       mov       rbx,rax
       jmp       near ptr M01_L31
M01_L99:
       mov       rcx,rdx
       call      qword ptr [7FFE2D2C5A70]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L100:
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L101:
       mov       rax,rdi
       jmp       near ptr M01_L35
M01_L102:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3730
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetSetFlags()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,1C4
       call      qword ptr [7FFE2D23DE18]; DotNetTips.Spargine.Core.EnumHelper.GetSetFlags[[System.AttributeTargets, System.Private.CoreLib]](System.AttributeTargets)
       mov       [rsp+28],rax
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Core.EnumHelper.GetSetFlags[[System.AttributeTargets, System.Private.CoreLib]](System.AttributeTargets)
; 		var type = typeof(TEnum);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (type.IsDefined(typeof(FlagsAttribute), false) is false)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			throw new ArgumentException($"Enum type {type.Name} is not a flags enumeration.", nameof(input));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var values = Enum.GetValues<TEnum>();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var items = new List<TEnum>(values.Length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var index = 0; index < values.Length; index++)
; 		     ^^^^^^^^^^^^^
; 			var value = values[index];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (input.HasFlag(value) && Convert.ToUInt64(value, CultureInfo.InvariantCulture) != 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				items.Add(value);
; 				^^^^^^^^^^^^^^^^^
; 		return new ReadOnlyCollection<TEnum>(items);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1C8
       vzeroupper
       lea       rbp,[rsp+200]
       xor       eax,eax
       mov       [rbp-128],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-120],xmm4
       vmovdqa   xmmword ptr [rbp-110],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       ebx,ecx
M01_L01:
       lea       rcx,[rbp-168]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-150],rcx
       mov       rcx,rbp
       mov       [rbp-140],rcx
       mov       rdi,18371D00AA0
       mov       rcx,offset MT_System.AttributeTargets
       call      00007FFE8C84BEA0
       test      rax,rax
       jne       near ptr M01_L60
M01_L02:
       mov       rcx,142DCC001C8
       mov       rdi,[rcx]
       cmp       qword ptr [rdi+8],0
       je        near ptr M01_L09
       mov       r14,[rdi+10]
       xor       r15d,r15d
       mov       r13,[rdi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r13],rcx
       jne       near ptr M01_L63
       mov       rcx,18371CF5F08
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       lea       rcx,[rbp-40]
       cmp       qword ptr [rbp-48],0
       jne       short M01_L03
       mov       rcx,[rbp-40]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       cmp       qword ptr [rbp-48],0
       je        near ptr M01_L61
M01_L03:
       mov       r12,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M01_L62
       mov       rcx,r12
       call      00007FFE8C81A6D0
       test      eax,eax
       je        near ptr M01_L42
M01_L04:
       mov       r12d,eax
M01_L05:
       xor       ecx,ecx
       mov       [rbp-48],rcx
M01_L06:
       mov       rdx,[rdi+8]
       mov       ecx,r12d
       imul      rcx,[rdi+20]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M01_L183
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       eax,[rdx]
       dec       eax
       js        short M01_L09
M01_L07:
       cmp       eax,[r14+8]
       jae       near ptr M01_L183
       mov       edx,eax
       shl       rdx,4
       lea       rdi,[r14+rdx+10]
       cmp       [rdi+8],r12d
       je        near ptr M01_L64
M01_L08:
       mov       eax,[rdi+0C]
       inc       r15d
       cmp       [r14+8],r15d
       jb        near ptr M01_L65
       test      eax,eax
       jge       short M01_L07
M01_L09:
       mov       rcx,18371D00AA0
       call      00007FFE8C8453D0
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L66
M01_L10:
       mov       [rbp-1A0],rdi
       mov       rcx,18371D00AA0
       call      00007FFE8C848680
       mov       r14d,eax
       cmp       [rdi],dil
       mov       rcx,rdi
       call      00007FFE8C891F10
       mov       r15,rax
       vxorps    ymm1,ymm1,ymm1
       vmovdqu   ymmword ptr [rbp-98],ymm1
       vmovdqu   ymmword ptr [rbp-78],ymm1
       vmovdqu   xmmword ptr [rbp-58],xmm1
       mov       dword ptr [rbp-0B8],10
       lea       r9,[rbp-8C]
       mov       [rsp+20],r9
       lea       r9,[rbp-98]
       mov       [rsp+28],r9
       lea       r9,[rbp-0B8]
       mov       rcx,r15
       mov       r8d,r14d
       mov       edx,0C000000
       mov       rax,7FFE2CD5B248
       mov       [rbp-158],rax
       lea       rax,[M01_L11]
       mov       [rbp-148],rax
       lea       rax,[rbp-168]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE8C77EA40
       call      rax
M01_L11:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M01_L12
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M01_L12:
       mov       r8,[rbp-160]
       mov       [rsi+8],r8
       mov       r8d,[rbp-0B8]
       mov       [rbp-90],r8d
       cmp       dword ptr [rbp-90],0
       je        near ptr M01_L67
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       vmovdqu   xmmword ptr [rbp-0A8],xmm0
       xor       edi,edi
M01_L13:
       cmp       edi,[rbp-90]
       jge       near ptr M01_L96
       cmp       qword ptr [rbp-98],0
       jne       near ptr M01_L43
       cmp       edi,10
       jae       near ptr M01_L183
       lea       r8,[rbp-8C]
       mov       edx,[r8+rdi*4]
M01_L14:
       lea       r8,[rbp-0A0]
       lea       r9,[rbp-0B0]
       mov       rcx,r15
       call      00007FFE8C849180
       test      eax,eax
       jl        near ptr M01_L84
       mov       r13d,[rbp-0A0]
       mov       r12,[rbp-1A0]
       mov       [rbp-0C0],r12
       xor       eax,eax
       mov       [rbp-1B0],rax
       mov       r10,[rbp-0C0]
       mov       [rbp-1B8],r10
       lea       r8,[rbp-0E0]
       mov       rcx,r15
       mov       edx,r13d
       call      00007FFE8C8494F0
       test      eax,eax
       jl        near ptr M01_L85
       mov       rcx,[rbp-1B8]
       mov       edx,[rbp-0E0]
       xor       r8d,r8d
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFE2CD3F500]; System.Reflection.RuntimeModule.ResolveType(Int32, System.Type[], System.Type[])
       test      rax,rax
       jne       near ptr M01_L44
M01_L15:
       xor       eax,eax
M01_L16:
       mov       rcx,offset MT_System.FlagsAttribute
       mov       ecx,[rcx]
       and       ecx,80000030
       cmp       ecx,30
       sete      cl
       movzx     ecx,cl
       mov       rdx,18371CF5F08
       test      ecx,ecx
       jne       near ptr M01_L68
       test      rax,rax
       je        near ptr M01_L73
       mov       rcx,18371CF5F08
       cmp       rax,rcx
       jne       near ptr M01_L71
       mov       r8d,1
M01_L17:
       test      r8d,r8d
       je        near ptr M01_L74
M01_L18:
       mov       r8d,r13d
       and       r8d,0FF000000
       cmp       r8d,0A000000
       jne       near ptr M01_L45
       mov       [rbp-1A8],rax
       lea       r8,[rbp-0F0]
       mov       rcx,r15
       mov       edx,r13d
       call      00007FFE8C862070
       test      eax,eax
       jl        near ptr M01_L86
       mov       eax,[rbp-0F0]
       mov       r10,[rbp-0E8]
M01_L19:
       test      eax,eax
       jle       near ptr M01_L88
       cmp       [r10],r10b
       cmp       eax,1
       jle       near ptr M01_L89
       cmp       byte ptr [r10+1],0
       jne       near ptr M01_L75
M01_L20:
       xor       edx,edx
       mov       r8d,r14d
       and       r8d,0FF000000
       cmp       r8d,8000000
       je        near ptr M01_L46
       cmp       r8d,6000000
       je        near ptr M01_L78
       cmp       r8d,17000000
       je        near ptr M01_L78
       cmp       r8d,14000000
       je        near ptr M01_L78
       cmp       r8d,4000000
       je        near ptr M01_L78
       cmp       r8d,2000000
       jne       near ptr M01_L79
       mov       edx,r14d
M01_L21:
       mov       ecx,edx
       and       ecx,0FF000000
       cmp       ecx,2000000
       jne       near ptr M01_L82
       mov       rcx,[rbp-0C0]
       cmp       [rcx],cl
       mov       [rbp-0C8],rcx
       lea       rcx,[rbp-0C8]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE2CC1EBE0]; System.ModuleHandle.ResolveTypeHandle(Int32, System.RuntimeTypeHandle[], System.RuntimeTypeHandle[])
M01_L22:
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-1A8]
       cmp       [rcx],cl
       mov       [rbp-0D8],rcx
       mov       rcx,[rbp-0D8]
       test      rcx,rcx
       je        near ptr M01_L47
       mov       rax,[rcx+18]
M01_L23:
       mov       r13,[rbp-1B0]
       test      r13,r13
       jne       near ptr M01_L83
       xor       edx,edx
M01_L24:
       mov       rcx,[rbp-0D0]
       test      rcx,rcx
       je        near ptr M01_L48
       mov       rcx,[rcx+18]
       mov       [rbp-1B0],r13
M01_L25:
       mov       r8,[rbp-0C0]
       mov       r8,[r8+18]
       lea       r9,[rbp-0D8]
       mov       [rbp-178],r9
       mov       [rbp-170],rax
       lea       r9,[rbp-0D0]
       mov       [rbp-188],r9
       mov       [rbp-180],rcx
       lea       rcx,[rbp-0C0]
       mov       [rbp-198],rcx
       mov       [rbp-190],r8
       lea       rcx,[rbp-178]
       lea       r8,[rbp-188]
       lea       r9,[rbp-198]
       mov       rax,7FFE2CD60838
       mov       [rbp-158],rax
       lea       rax,[M01_L26]
       mov       [rbp-148],rax
       lea       rax,[rbp-168]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE8C7819F0
       call      rax
M01_L26:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE8CB54A90],0
       je        short M01_L27
       call      qword ptr [7FFE8CB42648]; CORINFO_HELP_STOP_FOR_GC
M01_L27:
       mov       rcx,[rbp-160]
       mov       [rsi+8],rcx
       test      eax,eax
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L74
       mov       rdi,18371D00AA0
       mov       rcx,offset MT_System.AttributeTargets
       call      00007FFE8C84E010
       add       eax,0FFFFFFFD
       cmp       eax,5
       jne       near ptr M01_L95
       mov       rcx,142DB151158
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L122
M01_L28:
       mov       rcx,[rax+80]
       test      rcx,rcx
       je        near ptr M01_L50
       mov       rdx,[rcx]
       mov       rax,offset MT_System.Enum+EnumInfo<System.UInt32>
       cmp       rdx,rax
       jne       near ptr M01_L49
       mov       rax,rcx
M01_L29:
       test      rax,rax
       je        near ptr M01_L51
M01_L30:
       mov       rsi,[rax+8]
M01_L31:
       mov       edx,[rsi+8]
       test      edx,edx
       jl        near ptr M01_L184
       mov       edi,edx
       mov       edx,edi
       mov       rcx,offset MT_System.AttributeTargets[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       rcx,[rsi]
       cmp       rcx,[r14]
       je        near ptr M01_L171
M01_L32:
       mov       rcx,[rsi]
       mov       eax,[rcx+4]
       add       eax,0FFFFFFE8
       shr       eax,3
       mov       ecx,eax
       test      ecx,ecx
       jne       near ptr M01_L52
       xor       r15d,r15d
M01_L33:
       mov       rcx,[r14]
       mov       edx,[rcx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       mov       ecx,edx
       test      ecx,ecx
       jne       near ptr M01_L53
       xor       r13d,r13d
M01_L34:
       mov       rcx,[rsi]
       cmp       rcx,[r14]
       je        short M01_L35
       mov       ecx,eax
       mov       r8d,1
       test      ecx,ecx
       cmove     ecx,r8d
       mov       r8d,edx
       mov       r10d,1
       test      r8d,r8d
       cmove     r8d,r10d
       cmp       ecx,r8d
       jne       near ptr M01_L173
M01_L35:
       test      edi,edi
       jl        near ptr M01_L174
       test      eax,eax
       jne       near ptr M01_L54
       xor       r12d,r12d
M01_L36:
       cmp       r15d,r12d
       jl        near ptr M01_L175
       sub       r15d,r12d
       js        near ptr M01_L176
       lea       ecx,[r15+rdi]
       cmp       ecx,[rsi+8]
       ja        near ptr M01_L176
       test      edx,edx
       jne       near ptr M01_L55
       xor       r12d,r12d
M01_L37:
       cmp       r13d,r12d
       jl        near ptr M01_L177
       sub       r13d,r12d
       js        near ptr M01_L178
       lea       ecx,[rdi+r13]
       cmp       ecx,[r14+8]
       ja        near ptr M01_L178
       mov       rcx,[rsi]
       cmp       rcx,[r14]
       je        short M01_L38
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFE2D235FC8]; System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       jne       near ptr M01_L180
M01_L38:
       mov       rcx,[rsi]
       movzx     edx,word ptr [rcx]
       mov       r8d,edi
       imul      r8,rdx
       lea       rax,[rsi+8]
       mov       r10,[rsi]
       mov       r10d,[r10+4]
       add       r10,0FFFFFFFFFFFFFFF0
       add       rax,r10
       mov       r10d,r15d
       imul      r10,rdx
       add       r10,rax
       lea       rax,[r14+8]
       mov       r9,[r14]
       mov       r9d,[r9+4]
       add       r9,0FFFFFFFFFFFFFFF0
       add       rax,r9
       mov       r9d,r13d
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       near ptr M01_L179
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFE2CC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L39:
       mov       rcx,offset MT_System.Collections.Generic.List<System.AttributeTargets>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       edi,[r14+8]
       mov       edx,edi
       test      edx,edx
       je        near ptr M01_L181
       mov       rcx,offset MT_System.AttributeTargets[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L40:
       xor       esi,esi
       cmp       edi,esi
       jg        near ptr M01_L59
M01_L41:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.AttributeTargets>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,1C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L42:
       mov       rcx,r12
       call      qword ptr [7FFE2CC1E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L04
M01_L43:
       mov       rdx,[rbp-98]
       cmp       edi,[rdx+8]
       jae       near ptr M01_L183
       mov       edx,[rdx+rdi*4+10]
       jmp       near ptr M01_L14
M01_L44:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rax],rcx
       jne       near ptr M01_L15
       jmp       near ptr M01_L16
M01_L45:
       mov       [rbp-1A8],rax
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-100],xmm0
       lea       r8,[rbp-100]
       mov       rcx,r15
       mov       edx,r13d
       call      00007FFE8C86A760
       test      eax,eax
       jl        near ptr M01_L87
       mov       eax,[rbp-100]
       mov       r10,[rbp-0F8]
       jmp       near ptr M01_L19
M01_L46:
       lea       r8,[rbp-108]
       mov       rcx,r15
       mov       edx,r14d
       call      00007FFE8C8494F0
       test      eax,eax
       jl        near ptr M01_L90
       mov       edx,[rbp-108]
       lea       r8,[rbp-110]
       mov       rcx,r15
       call      00007FFE8C8494F0
       test      eax,eax
       jl        near ptr M01_L91
       mov       eax,[rbp-110]
       mov       edx,eax
       jmp       near ptr M01_L21
M01_L47:
       xor       eax,eax
       mov       [rbp-130],rax
       jmp       near ptr M01_L23
M01_L48:
       xor       ecx,ecx
       mov       [rbp-1B0],r13
       jmp       near ptr M01_L25
M01_L49:
       mov       rax,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       rdx,rax
       jne       short M01_L50
       mov       rax,[rcx+28]
       jmp       near ptr M01_L29
M01_L50:
       xor       eax,eax
       jmp       near ptr M01_L29
M01_L51:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE2CE3DE48]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       jmp       near ptr M01_L30
M01_L52:
       movsxd    rcx,ecx
       mov       r15d,[rsi+rcx*4+10]
       jmp       near ptr M01_L33
M01_L53:
       movsxd    rcx,ecx
       mov       r13d,[r14+rcx*4+10]
       jmp       near ptr M01_L34
M01_L54:
       movsxd    rcx,eax
       mov       r12d,[rsi+rcx*4+10]
       jmp       near ptr M01_L36
M01_L55:
       movsxd    rcx,edx
       mov       r12d,[r14+rcx*4+10]
       jmp       near ptr M01_L37
M01_L56:
       mov       rdx,rax
       mov       rcx,offset MT_System.IConvertible
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r11,7FFE2CB60A90
       xor       edx,edx
       call      qword ptr [r11]
       mov       r13,rax
M01_L57:
       test      r13,r13
       je        short M01_L58
       inc       dword ptr [r12+14]
       mov       rcx,[r12+8]
       mov       edx,[r12+10]
       mov       eax,[rcx+8]
       cmp       eax,edx
       jbe       near ptr M01_L182
       lea       r8d,[rdx+1]
       mov       [r12+10],r8d
       cmp       edx,eax
       jae       near ptr M01_L183
       mov       [rcx+rdx*4+10],r15d
M01_L58:
       add       esi,1
       jo        near ptr M01_L184
       cmp       edi,esi
       jle       near ptr M01_L41
M01_L59:
       cmp       esi,edi
       jae       near ptr M01_L183
       mov       r15d,[r14+rsi*4+10]
       mov       ecx,ebx
       and       ecx,r15d
       cmp       ecx,r15d
       jne       short M01_L58
       mov       rcx,offset MT_System.AttributeTargets
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       [rcx+8],r15d
       call      qword ptr [7FFE2D23DF98]; System.Enum.GetValue()
       test      rax,rax
       jne       near ptr M01_L56
       xor       r13d,r13d
       jmp       near ptr M01_L57
M01_L60:
       mov       rcx,rax
       call      qword ptr [7FFE2CC15860]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       test      rax,rax
       jne       near ptr M01_L67
       jmp       near ptr M01_L02
M01_L61:
       xor       r12d,r12d
       jmp       near ptr M01_L05
M01_L62:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
       jmp       near ptr M01_L05
M01_L63:
       mov       rcx,r13
       mov       rdx,18371CF5F08
       mov       r11,7FFE2CB60A70
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M01_L06
M01_L64:
       mov       rdx,[rdi]
       mov       rcx,r13
       mov       r8,18371CF5F08
       mov       r11,7FFE2CB60A78
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L08
       jmp       near ptr M01_L09
M01_L65:
       call      qword ptr [7FFE2CE37A08]
       int       3
M01_L66:
       mov       rcx,18371D00AA0
       call      qword ptr [7FFE2CC17C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rdi,rax
       jmp       near ptr M01_L10
M01_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2053
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE37798]
       mov       rsi,rax
       mov       rcx,18371D00AA0
       call      qword ptr [7FFE2CB5A2A0]; Precode of System.RuntimeType.get_Name()
       mov       rdi,rax
       mov       ecx,2069
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE37798]
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFE2CC17828]; System.String.Concat(System.String, System.String, System.String)
       mov       rsi,rax
       mov       ecx,2047
       mov       rdx,7FFE2CEE4D10
       call      qword ptr [7FFE2CE37798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE2CF961A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L68:
       mov       [rbp-1A8],rax
       mov       rdx,rax
       test      rdx,rdx
       je        near ptr M01_L74
M01_L69:
       mov       [rbp-1C8],rdx
       mov       rcx,rdx
       call      qword ptr [7FFE2CB5A358]
       test      eax,eax
       je        short M01_L70
       mov       rcx,[rbp-1C8]
       call      qword ptr [7FFE2CB5A3C8]; Precode of System.RuntimeType.GetGenericTypeDefinition()
       mov       rcx,18371CF5F08
       cmp       rax,rcx
       jne       short M01_L70
       mov       rax,[rbp-1A8]
       jmp       near ptr M01_L18
M01_L70:
       mov       rcx,[rbp-1C8]
       call      qword ptr [7FFE2CC1DB00]; System.RuntimeType.GetBaseType()
       mov       rdx,rax
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       test      r8,r8
       mov       rdx,r8
       jne       short M01_L69
       jmp       short M01_L74
M01_L71:
       mov       [rbp-1A8],rax
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L72
       mov       rdx,18371CF5F08
       call      qword ptr [7FFE2D2D68E0]; System.RuntimeTypeHandle.CanCastTo(System.RuntimeType, System.RuntimeType)
       mov       r8d,eax
       mov       rax,[rbp-1A8]
       jmp       near ptr M01_L17
M01_L72:
       xor       r8d,r8d
       mov       rax,[rbp-1A8]
       jmp       near ptr M01_L17
M01_L73:
       xor       r8d,r8d
       jmp       near ptr M01_L17
M01_L74:
       inc       edi
       jmp       near ptr M01_L13
M01_L75:
       mov       rcx,[rbp-1A8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2CB5A378]; Precode of System.RuntimeType.get_IsGenericType()
       test      eax,eax
       je        short M01_L76
       mov       rax,[rbp-0C0]
       mov       [rbp-1C0],rax
       mov       rcx,[rbp-1A8]
       call      qword ptr [7FFE2CB58318]
       mov       r8,rax
       mov       edx,r13d
       mov       rcx,[rbp-1C0]
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFE2CD3F4E8]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+38]
       jmp       short M01_L77
M01_L76:
       mov       rcx,[rbp-0C0]
       mov       [rbp-0C8],rcx
       lea       rcx,[rbp-0C8]
       mov       edx,r13d
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE2CD85308]; System.ModuleHandle.ResolveMethodHandle(Int32, System.RuntimeTypeHandle[], System.RuntimeTypeHandle[])
M01_L77:
       mov       r13,rax
       mov       [rbp-1B0],r13
       jmp       near ptr M01_L20
M01_L78:
       lea       r8,[rbp-118]
       mov       rcx,r15
       mov       edx,r14d
       call      00007FFE8C8494F0
       test      eax,eax
       jl        near ptr M01_L92
       mov       eax,[rbp-118]
       mov       edx,eax
       jmp       near ptr M01_L21
M01_L79:
       cmp       r8d,2A000000
       jne       near ptr M01_L21
       lea       r8,[rbp-120]
       mov       rcx,r15
       mov       edx,r14d
       call      00007FFE8C8494F0
       test      eax,eax
       jl        near ptr M01_L93
       mov       edx,[rbp-120]
       mov       eax,edx
       mov       r8d,eax
       and       r8d,0FF000000
       cmp       r8d,6000000
       jne       short M01_L80
       lea       r8,[rbp-128]
       mov       rcx,r15
       call      00007FFE8C8494F0
       test      eax,eax
       jge       short M01_L81
       jmp       near ptr M01_L94
M01_L80:
       mov       edx,eax
       jmp       near ptr M01_L21
M01_L81:
       mov       eax,[rbp-128]
       mov       edx,eax
       jmp       near ptr M01_L21
M01_L82:
       xor       eax,eax
       jmp       near ptr M01_L22
M01_L83:
       mov       [rbp-130],rax
       mov       [rbp-1B0],r13
       mov       rcx,r13
       mov       r11,7FFE2CB60A80
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,[rbp-130]
       mov       r13,[rbp-1B0]
       jmp       near ptr M01_L24
M01_L84:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2D50F8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L85:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2D50F8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L86:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2D50F8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L87:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2D50F8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L88:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2D51A0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L89:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2D51A0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L90:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2D50F8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L91:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2D50F8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L92:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2D50F8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L93:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE2D2D50F8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L94:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       call      qword ptr [7FFE2D2D50F8]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
M01_L95:
       cmp       eax,16
       ja        short M01_L97
       mov       ecx,eax
       lea       rax,[7FFE2D322250]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M01_L01]
       add       rax,rdx
       jmp       rax
M01_L96:
       jmp       near ptr M01_L67
M01_L97:
       call      qword ptr [7FFE2D2D5680]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,142DB151158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L98
       jmp       short M01_L99
M01_L98:
       mov       rcx,rdi
       call      qword ptr [7FFE2CC17C30]; System.RuntimeType.InitializeCache()
M01_L99:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L101
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L100
       jmp       short M01_L102
M01_L100:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L101
       mov       rax,[rax+28]
       jmp       short M01_L102
M01_L101:
       xor       eax,eax
M01_L102:
       test      rax,rax
       jne       short M01_L103
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE2D2D58C0]
M01_L103:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L31
       mov       rcx,142DB151158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L104
       jmp       short M01_L105
M01_L104:
       mov       rcx,rdi
       call      qword ptr [7FFE2CC17C30]; System.RuntimeType.InitializeCache()
M01_L105:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L107
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L106
       jmp       short M01_L108
M01_L106:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L107
       mov       rax,[rax+28]
       jmp       short M01_L108
M01_L107:
       xor       eax,eax
M01_L108:
       test      rax,rax
       jne       short M01_L109
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE2D2D58C0]
M01_L109:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L31
       mov       rcx,142DB151158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L110
       jmp       short M01_L111
M01_L110:
       mov       rcx,rdi
       call      qword ptr [7FFE2CC17C30]; System.RuntimeType.InitializeCache()
M01_L111:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L113
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt16>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L112
       jmp       short M01_L114
M01_L112:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L113
       mov       rax,[rax+28]
       jmp       short M01_L114
M01_L113:
       xor       eax,eax
M01_L114:
       test      rax,rax
       jne       short M01_L115
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE2D2D5998]
M01_L115:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L31
       mov       rcx,142DB151158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L116
       jmp       short M01_L117
M01_L116:
       mov       rcx,rdi
       call      qword ptr [7FFE2CC17C30]; System.RuntimeType.InitializeCache()
M01_L117:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L119
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt16>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L118
       jmp       short M01_L120
M01_L118:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L119
       mov       rax,[rax+28]
       jmp       short M01_L120
M01_L119:
       xor       eax,eax
M01_L120:
       test      rax,rax
       jne       short M01_L121
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE2D2D5998]
M01_L121:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L31
M01_L122:
       mov       rcx,rdi
       call      qword ptr [7FFE2CC17C30]; System.RuntimeType.InitializeCache()
       jmp       near ptr M01_L28
       mov       rcx,142DB151158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L123
       jmp       short M01_L124
M01_L123:
       mov       rcx,rdi
       call      qword ptr [7FFE2CC17C30]; System.RuntimeType.InitializeCache()
M01_L124:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L126
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L125
       jmp       short M01_L127
M01_L125:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L126
       mov       rax,[rax+28]
       jmp       short M01_L127
M01_L126:
       xor       eax,eax
M01_L127:
       test      rax,rax
       jne       short M01_L128
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE2CE3DE48]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
M01_L128:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L31
       mov       rcx,142DB151158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L129
       jmp       short M01_L130
M01_L129:
       mov       rcx,rdi
       call      qword ptr [7FFE2CC17C30]; System.RuntimeType.InitializeCache()
M01_L130:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L132
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt64>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L131
       jmp       short M01_L133
M01_L131:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L132
       mov       rax,[rax+28]
       jmp       short M01_L133
M01_L132:
       xor       eax,eax
M01_L133:
       test      rax,rax
       jne       short M01_L134
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE2D2D5A40]
M01_L134:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L31
       mov       rcx,142DB151158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L135
       jmp       short M01_L136
M01_L135:
       mov       rcx,rdi
       call      qword ptr [7FFE2CC17C30]; System.RuntimeType.InitializeCache()
M01_L136:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L138
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt64>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L137
       jmp       short M01_L139
M01_L137:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L138
       mov       rax,[rax+28]
       jmp       short M01_L139
M01_L138:
       xor       eax,eax
M01_L139:
       test      rax,rax
       jne       short M01_L140
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE2D2D5A40]
M01_L140:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L31
       mov       rcx,142DB151158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L141
       jmp       short M01_L142
M01_L141:
       mov       rcx,rdi
       call      qword ptr [7FFE2CC17C30]; System.RuntimeType.InitializeCache()
M01_L142:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L144
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UIntPtr>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L143
       jmp       short M01_L145
M01_L143:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L144
       mov       rax,[rax+28]
       jmp       short M01_L145
M01_L144:
       xor       eax,eax
M01_L145:
       test      rax,rax
       jne       short M01_L146
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE2D2D5AA0]
M01_L146:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L31
       mov       rcx,142DB151158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L147
       jmp       short M01_L148
M01_L147:
       mov       rcx,rdi
       call      qword ptr [7FFE2CC17C30]; System.RuntimeType.InitializeCache()
M01_L148:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L150
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UIntPtr>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L149
       jmp       short M01_L151
M01_L149:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L150
       mov       rax,[rax+28]
       jmp       short M01_L151
M01_L150:
       xor       eax,eax
M01_L151:
       test      rax,rax
       jne       short M01_L152
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE2D2D5AA0]
M01_L152:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L31
       mov       rcx,142DB151158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L153
       jmp       short M01_L154
M01_L153:
       mov       rcx,rdi
       call      qword ptr [7FFE2CC17C30]; System.RuntimeType.InitializeCache()
M01_L154:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L156
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Single>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L155
       jmp       short M01_L157
M01_L155:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L156
       mov       rax,[rax+28]
       jmp       short M01_L157
M01_L156:
       xor       eax,eax
M01_L157:
       test      rax,rax
       jne       short M01_L158
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE2D2D5B00]
M01_L158:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L31
       mov       rcx,142DB151158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L159
       jmp       short M01_L160
M01_L159:
       mov       rcx,rdi
       call      qword ptr [7FFE2CC17C30]; System.RuntimeType.InitializeCache()
M01_L160:
       mov       rsi,[rax+80]
       test      rsi,rsi
       je        short M01_L162
       mov       rdx,rsi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Double>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L161
       jmp       short M01_L163
M01_L161:
       mov       rdx,rsi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L162
       mov       rax,[rax+28]
       jmp       short M01_L163
M01_L162:
       xor       eax,eax
M01_L163:
       test      rax,rax
       jne       short M01_L164
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE2D2D5B60]
M01_L164:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L31
       mov       rcx,142DB151158
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L165
       jmp       short M01_L166
M01_L165:
       mov       rcx,rdi
       call      qword ptr [7FFE2CC17C30]; System.RuntimeType.InitializeCache()
M01_L166:
       mov       rcx,[rax+80]
       test      rcx,rcx
       je        short M01_L168
       mov       rdx,[rcx]
       mov       rax,offset MT_System.Enum+EnumInfo<System.Char>
       cmp       rdx,rax
       jne       short M01_L167
       mov       rax,rcx
       jmp       short M01_L169
M01_L167:
       mov       rax,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       rdx,rax
       jne       short M01_L168
       mov       rax,[rcx+28]
       jmp       short M01_L169
M01_L168:
       xor       eax,eax
M01_L169:
       test      rax,rax
       jne       short M01_L170
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE2D2D5BC0]
M01_L170:
       mov       rsi,[rax+8]
       jmp       near ptr M01_L31
M01_L171:
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L32
       cmp       edi,[rsi+8]
       ja        near ptr M01_L32
       cmp       edi,[r14+8]
       ja        near ptr M01_L32
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[r14+10]
       test      dword ptr [rcx],1000000
       je        short M01_L172
       mov       rcx,rax
       call      qword ptr [7FFE2CC157A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L39
M01_L172:
       mov       rcx,rax
       call      qword ptr [7FFE2CC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L39
M01_L173:
       mov       rcx,offset MT_System.RankException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE2D2D5C68]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE2D2D5C80]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L174:
       mov       ecx,0B3
       mov       rdx,7FFE2CB54000
       call      qword ptr [7FFE2CE37798]
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE2D2D4618]
       int       3
M01_L175:
       mov       ecx,167
       mov       rdx,7FFE2CB54000
       call      qword ptr [7FFE2CE37798]
       mov       r8,rax
       mov       edx,r12d
       mov       ecx,r15d
       call      qword ptr [7FFE2D2D5C20]
       int       3
M01_L176:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2D2D5C98]
       mov       rsi,rax
       mov       ecx,12D
       mov       rdx,7FFE2CB54000
       call      qword ptr [7FFE2CE37798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE2CF961A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L177:
       mov       ecx,17F
       mov       rdx,7FFE2CB54000
       call      qword ptr [7FFE2CE37798]
       mov       r8,rax
       mov       edx,r12d
       mov       ecx,r13d
       call      qword ptr [7FFE2D2D5C20]
       int       3
M01_L178:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE2D2D5CB0]
       mov       rsi,rax
       mov       ecx,145
       mov       rdx,7FFE2CB54000
       call      qword ptr [7FFE2CE37798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE2CF961A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L179:
       mov       rcx,rdx
       mov       rdx,r10
       call      qword ptr [7FFE2CC157A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L39
M01_L180:
       mov       [rsp+20],edi
       mov       [rsp+28],eax
       mov       rcx,rsi
       mov       edx,r15d
       mov       r8,r14
       mov       r9d,r13d
       call      qword ptr [7FFE2D2D5CF8]
       jmp       near ptr M01_L39
M01_L181:
       mov       rcx,offset MT_System.Collections.Generic.List<System.AttributeTargets>
       call      qword ptr [7FFE2CC15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,142DCC021A8
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L40
M01_L182:
       mov       rcx,r12
       mov       edx,r15d
       call      qword ptr [7FFE2D23DFF8]
       jmp       near ptr M01_L58
M01_L183:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L184:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 5867
```

