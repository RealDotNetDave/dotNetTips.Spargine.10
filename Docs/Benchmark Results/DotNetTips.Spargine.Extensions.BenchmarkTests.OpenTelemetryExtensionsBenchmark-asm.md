## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.OpenTelemetryExtensionsBenchmark.AddTagsIfPresent()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Diagnostics.Activity
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,23AF6C001C0
       mov       rdx,[rcx]
       lea       rcx,[rsi+88]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+0A8],1
       mov       rcx,27B75B30C08
       mov       [rsi+80],rcx
       mov       [rbp-50],rsi
       mov       rcx,rsi
       call      qword ptr [7FFAE0D8E490]; System.Diagnostics.Activity.Start()
       mov       rsi,[rbx+1A0]
       test      rsi,rsi
       je        near ptr M00_L15
       mov       edi,[rsi+8]
       test      edi,edi
       jne       near ptr M00_L17
       test      byte ptr [7FFAE0DF2798],1
       je        near ptr M00_L18
M00_L00:
       mov       rcx,23AF6C002D8
       mov       r14,[rcx]
M00_L01:
       jmp       short M00_L03
M00_L02:
       mov       rcx,[rbp-58]
       call      00007FFB403EDE50
       test      eax,eax
       jne       near ptr M00_L21
M00_L03:
       mov       ecx,[r14+8]
       inc       ecx
       mov       eax,ecx
       cmp       eax,[r14+0C]
       jae       near ptr M00_L14
       mov       [r14+8],eax
       mov       rax,[r14+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L23
       mov       ecx,ecx
       shl       rcx,4
       lea       rcx,[rax+rcx+10]
       mov       rsi,[rcx]
       mov       rdi,[rcx+8]
       mov       rcx,rsi
       test      rcx,rcx
       je        short M00_L03
       xor       r15d,r15d
       cmp       dword ptr [rsi+8],0
       jle       short M00_L03
M00_L04:
       movzx     ecx,word ptr [rsi+r15*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L19
       mov       rax,7FFB0EEC6B88
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L20
M00_L05:
       test      rdi,rdi
       je        short M00_L03
       mov       rcx,[rbp-50]
       cmp       qword ptr [rcx+40],0
       je        near ptr M00_L16
M00_L06:
       mov       rcx,[rbp-50]
       mov       r15,[rcx+40]
       cmp       [r15],r15b
       mov       [rbp-58],r15
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rcx,r15
       call      00007FFB403EDF30
       test      eax,eax
       je        near ptr M00_L12
M00_L07:
       mov       dword ptr [rbp-3C],1
       mov       r13,[r15+8]
       test      r13,r13
       je        short M00_L10
M00_L08:
       mov       r8,[r13+10]
       cmp       r8,rsi
       je        near ptr M00_L11
       test      r8,r8
       je        short M00_L09
       mov       edx,[r8+8]
       cmp       edx,[rsi+8]
       jne       short M00_L09
       lea       rcx,[r8+0C]
       mov       r8d,[r8+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFAE074C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       short M00_L11
M00_L09:
       mov       r13,[r13+8]
       test      r13,r13
       jne       short M00_L08
M00_L10:
       mov       rcx,offset MT_System.Diagnostics.DiagNode<System.Collections.Generic.KeyValuePair<System.String, System.Object>>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [r15+8],0
       je        short M00_L13
       mov       rcx,[r15+10]
       lea       rcx,[rcx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L11:
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L12:
       mov       rcx,r15
       call      qword ptr [7FFAE0E15878]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L07
M00_L13:
       lea       rcx,[r15+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
M00_L15:
       mov       rcx,[rbp-50]
       mov       [rbp-48],rcx
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       jmp       near ptr M00_L24
M00_L16:
       mov       rcx,offset MT_System.Diagnostics.Activity+TagsLinkedList
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,[rbp-50]
       lea       r13,[rcx+40]
       mov       rcx,offset MT_System.Diagnostics.DiagNode<System.Collections.Generic.KeyValuePair<System.String, System.Object>>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       test      r13,r13
       je        near ptr M00_L22
       mov       rcx,r13
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FFB40386040
       test      rax,rax
       je        near ptr M00_L03
       jmp       near ptr M00_L06
M00_L17:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFAE0D8EAA8]; System.SZGenericArrayEnumeratorBase..ctor(Int32)
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L18:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>>
       call      qword ptr [7FFAE0745728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L00
M00_L19:
       call      qword ptr [7FFAE0E15E30]
       test      eax,eax
       je        near ptr M00_L05
M00_L20:
       inc       r15d
       cmp       [rsi+8],r15d
       jg        near ptr M00_L04
       jmp       near ptr M00_L03
M00_L21:
       mov       ecx,eax
       mov       rdx,[rbp-58]
       call      qword ptr [7FFAE0E15368]
       jmp       near ptr M00_L03
M00_L22:
       call      qword ptr [7FFAE0E15BA8]
       int       3
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L24:
       mov       rcx,[rbp-50]
       test      byte ptr [rcx+0A4],80
       jne       short M00_L25
       call      qword ptr [7FFAE0D8EC28]; System.Diagnostics.Activity.Stop()
       mov       rcx,[rbp-50]
M00_L25:
       mov       rbx,[rcx]
       test      dword ptr [rbx],100000
       jne       short M00_L27
M00_L26:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L27:
       call      00007FFB4039D4D0
       jmp       short M00_L26
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L28
       mov       rcx,[rbp-58]
       call      00007FFB403EDE50
       test      eax,eax
       je        short M00_L28
       mov       ecx,eax
       mov       rdx,[rbp-58]
       call      qword ptr [7FFAE0E15368]
M00_L28:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,[rbp-50]
       test      byte ptr [rcx+0A4],80
       jne       short M00_L29
       call      qword ptr [7FFAE0D8EC28]; System.Diagnostics.Activity.Stop()
       mov       rcx,[rbp-50]
M00_L29:
       mov       rbx,[rcx]
       test      dword ptr [rbx],100000
       je        short M00_L30
       call      00007FFB4039D4D0
M00_L30:
       nop
       add       rsp,28
       ret
; Total bytes of code 1035
```
```assembly
; System.Diagnostics.Activity.Start()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       rbx,rcx
       cmp       qword ptr [rbx+10],0
       jne       near ptr M01_L21
       cmp       qword ptr [rbx+38],0
       jne       near ptr M01_L21
       mov       rcx,23AF6C001C8
       mov       rsi,[rcx]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M01_L22
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M01_L22
M01_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M01_L01
       call      qword ptr [7FFAE09DFCF0]; System.Threading.Thread.InitializeCurrentThread()
M01_L01:
       mov       rcx,[rax+8]
       test      rcx,rcx
       je        short M01_L02
       mov       rcx,[rcx+8]
       lea       r8,[rsp+58]
       mov       rdx,rsi
       mov       r11,7FFAE0690AD0
       call      qword ptr [r11]
       mov       rdx,[rsp+58]
       jmp       short M01_L03
M01_L02:
       xor       edx,edx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+58],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L04
       mov       rcx,offset MT_System.Diagnostics.Activity
       cmp       [rsi],rcx
       je        short M01_L04
       call      qword ptr [7FFAE0914D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbx+78]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       jne       short M01_L05
       cmp       qword ptr [rbx+28],0
       jne       short M01_L05
       test      rsi,rsi
       jne       near ptr M01_L23
M01_L05:
       mov       [rsp+90],rbx
       mov       rcx,[rbx+0B8]
       shl       rcx,2
       jne       short M01_L08
       lea       rcx,[rsp+50]
       mov       rax,7FFB8F885380
       call      rax
       mov       rbx,[rsp+50]
       mov       rax,23AE0C01B08
       mov       rsi,[rax]
       sub       rbx,[rsi+8]
       cmp       dword ptr [7FFB406A4A90],0
       jne       near ptr M01_L24
M01_L06:
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jae       near ptr M01_L25
       add       rbx,[rsi+10]
M01_L07:
       mov       rsi,[rsp+90]
       mov       [rsi+0B8],rbx
       mov       [rsp+90],rsi
M01_L08:
       mov       rbx,[rsp+90]
       test      byte ptr [rbx+0A4],3
       jne       short M01_L11
       cmp       byte ptr [7FFAE068B174],0
       jne       short M01_L09
       cmp       qword ptr [rbx+90],0
       jne       near ptr M01_L28
       cmp       qword ptr [rbx+28],0
       jne       near ptr M01_L27
       cmp       qword ptr [rbx+20],0
       jne       near ptr M01_L26
M01_L09:
       call      qword ptr [7FFAE0D8E868]; System.Diagnostics.Activity.get_DefaultIdFormat()
M01_L10:
       movzx     ecx,byte ptr [rbx+0A4]
       and       ecx,0FC
       movzx     eax,al
       and       eax,3
       or        ecx,eax
       mov       [rbx+0A4],cl
M01_L11:
       movzx     ecx,byte ptr [rbx+0A4]
       and       ecx,3
       cmp       ecx,2
       jne       near ptr M01_L29
       cmp       qword ptr [rbx+30],0
       jne       short M01_L14
       mov       rcx,rbx
       call      qword ptr [7FFAE0D8E8C8]; System.Diagnostics.Activity.TrySetTraceIdFromParent()
       test      eax,eax
       jne       short M01_L14
       mov       rax,23AF6C001E0
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M01_L12
       call      qword ptr [7FFAE0D8E8E0]; System.Diagnostics.ActivityTraceId.CreateRandom()
       mov       rdx,rax
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rdx,rax
M01_L13:
       mov       rcx,27B75B312F0
       test      rdx,rdx
       cmove     rdx,rcx
       lea       rcx,[rbx+30]
       call      CORINFO_HELP_ASSIGN_REF
M01_L14:
       test      byte ptr [rbx+0A5],80
       jne       short M01_L15
       mov       rcx,rbx
       call      qword ptr [7FFAE0D8E988]; System.Diagnostics.Activity.TrySetTraceFlagsFromParent()
M01_L15:
       lea       rsi,[rsp+48]
       call      qword ptr [7FFAE0D8E910]; System.Diagnostics.RandomNumberGenerator.get_Current()
       mov       rcx,[rax+10]
       lea       rdx,[rcx+rcx*4]
       rol       rdx,7
       lea       rdx,[rdx+rdx*8]
       mov       r8,rcx
       shl       r8,11
       mov       r10,[rax+18]
       mov       r9,[rax+8]
       xor       r10,r9
       mov       [rax+18],r10
       mov       r11,rcx
       xor       r11,[rax+20]
       mov       [rax+20],r11
       xor       rcx,r10
       mov       [rax+10],rcx
       xor       r9,r11
       mov       [rax+8],r9
       xor       r8,r10
       mov       [rax+18],r8
       rol       r11,2D
       mov       [rax+20],r11
       mov       [rsi],rdx
       lea       rcx,[rsp+48]
       mov       rax,23AE0C01EA8
       mov       rsi,[rax]
       mov       [rsp+30],rcx
       mov       dword ptr [rsp+38],8
       mov       dword ptr [rsp+40],2020
       test      rsi,rsi
       jne       short M01_L16
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,23AE0C01EA0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       mov       [rsi+18],rcx
       mov       rcx,23AE0C01EA8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L16:
       mov       rcx,offset MT_System.String
       mov       edx,10
       call      00007FFB403E50F0
       mov       rdi,rax
       cmp       [rdi],dil
       lea       rdx,[rdi+0C]
       mov       [rsp+20],rdx
       mov       dword ptr [rsp+28],10
       lea       rdx,[rsp+20]
       lea       r8,[rsp+30]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       lea       rcx,[rbx+38]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L17:
       mov       rcx,rbx
       call      qword ptr [7FFAE0D8E9B8]; System.Diagnostics.Activity.SetCurrent(System.Diagnostics.Activity)
       mov       rcx,[rbx+88]
       mov       rsi,[rcx+8]
       test      rsi,rsi
       je        short M01_L20
       mov       rcx,[rsi+10]
       cmp       dword ptr [rcx+8],0
       jle       short M01_L20
       mov       rcx,23AF6C00240
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M01_L18
       mov       rcx,offset MT_System.Action<System.Diagnostics.ActivityListener, System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,23AF6C00208
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFAE0E11FE0
       mov       [rdi+18],rcx
       mov       rcx,23AF6C00240
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L18:
       mov       rsi,[rsi+10]
       mov       ebp,[rsi+8]
       mov       r14d,10
       inc       ebp
M01_L19:
       dec       ebp
       jne       near ptr M01_L30
M01_L20:
       mov       rax,rbx
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L21:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,27B75B31180
       call      qword ptr [7FFAE0E15FB0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAE09DD860]; System.InvalidOperationException..ctor(System.String)
       mov       rcx,rsi
       call      qword ptr [7FFAE0E15FC8]
       jmp       short M01_L20
M01_L22:
       mov       ecx,4
       call      qword ptr [7FFAE0E15530]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L23:
       lea       rcx,[rbx+90]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L24:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L06
M01_L25:
       call      qword ptr [7FFAE0C76D78]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L07
M01_L26:
       mov       rcx,[rbx+20]
       call      qword ptr [7FFAE0E15FF8]
       test      eax,eax
       jne       short M01_L27
       mov       eax,1
       jmp       near ptr M01_L10
M01_L27:
       mov       eax,2
       jmp       near ptr M01_L10
M01_L28:
       mov       rax,[rbx+90]
       movzx     eax,byte ptr [rax+0A4]
       and       eax,3
       jmp       near ptr M01_L10
M01_L29:
       mov       rcx,rbx
       call      qword ptr [7FFAE0E16010]
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L17
M01_L30:
       mov       rdx,[rsi+r14]
       mov       r8,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       add       r14,8
       jmp       near ptr M01_L19
; Total bytes of code 1237
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L02
       cmp       rcx,rdx
       je        near ptr M02_L12
       cmp       r8,20
       jae       near ptr M02_L07
       cmp       r8,10
       jb        near ptr M02_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        near ptr M02_L11
M02_L00:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       je        near ptr M02_L10
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
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L09
M02_L08:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M02_L01
       add       rax,20
       cmp       r8,rax
       ja        short M02_L08
M02_L09:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       near ptr M02_L01
       jmp       short M02_L12
M02_L10:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M02_L00
M02_L11:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M02_L01
M02_L12:
       mov       eax,1
       vzeroupper
       ret
M02_L13:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L06
; Total bytes of code 314
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
       call      qword ptr [7FFB0FB39030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFB0FB39038]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.SZGenericArrayEnumeratorBase..ctor(Int32)
       mov       dword ptr [rcx+8],0FFFFFFFF
       mov       [rcx+0C],edx
       ret
; Total bytes of code 11
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFAE0745C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Diagnostics.Activity.Stop()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       cmp       qword ptr [rbx+10],0
       jne       short M06_L00
       cmp       qword ptr [rbx+38],0
       je        near ptr M06_L11
M06_L00:
       movzx     ecx,byte ptr [rbx+0A4]
       test      cl,80
       jne       near ptr M06_L10
       or        ecx,80
       mov       [rbx+0A4],cl
       mov       [rsp+60],rbx
       mov       rcx,[rbx+0B0]
       test      rcx,rcx
       jne       near ptr M06_L06
       lea       rcx,[rsp+28]
       mov       rax,7FFB8F885380
       call      rax
       mov       rbx,[rsp+28]
       mov       rax,23AE0C01B08
       mov       rsi,[rax]
       sub       rbx,[rsi+8]
       cmp       dword ptr [7FFB406A4A90],0
       jne       near ptr M06_L12
M06_L01:
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jae       near ptr M06_L13
       add       rbx,[rsi+10]
M06_L02:
       mov       rcx,rbx
       shr       rcx,3E
       mov       eax,ecx
       shr       eax,1
       andn      ecx,eax,ecx
       cmp       ecx,1
       jne       short M06_L04
       mov       rsi,[rsp+60]
       mov       rcx,[rsi+0B8]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rax,rcx
       mov       rcx,rax
       mov       [rsi+0B0],rcx
       test      rax,rax
       jle       short M06_L03
       mov       [rsp+60],rsi
       jmp       short M06_L06
M06_L03:
       mov       qword ptr [rsi+0B0],1
       mov       [rsp+60],rsi
       jmp       short M06_L06
M06_L04:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,27B75B313E8
       call      qword ptr [7FFAE0E15FB0]
       mov       rdx,rax
       test      rdx,rdx
       je        near ptr M06_L14
M06_L05:
       mov       rcx,80131500E0434352
       mov       [rbx+68],rcx
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+6C],80131509
       mov       rcx,rbx
       call      qword ptr [7FFAE0E15FC8]
M06_L06:
       mov       rbx,[rsp+60]
       mov       rcx,[rbx+88]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M06_L09
       mov       rsi,[rcx+10]
       cmp       dword ptr [rsi+8],0
       jle       short M06_L09
       mov       rcx,23AF6C00248
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M06_L07
       mov       rcx,offset MT_System.Action<System.Diagnostics.ActivityListener, System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,23AF6C00208
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFAE0E12148
       mov       [rdi+18],rcx
       mov       rcx,23AF6C00248
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M06_L07:
       mov       ebp,[rsi+8]
       mov       r14d,10
       inc       ebp
M06_L08:
       dec       ebp
       jne       near ptr M06_L15
M06_L09:
       mov       rcx,[rbx+78]
       call      qword ptr [7FFAE0D8E9B8]; System.Diagnostics.Activity.SetCurrent(System.Diagnostics.Activity)
M06_L10:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L11:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,27B75B313A8
       call      qword ptr [7FFAE0E15FB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE09DD860]; System.InvalidOperationException..ctor(System.String)
       mov       rcx,rbx
       call      qword ptr [7FFAE0E15FC8]
       jmp       short M06_L10
M06_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L01
M06_L13:
       call      qword ptr [7FFAE0C76D78]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M06_L02
M06_L14:
       mov       rcx,27B75B27230
       call      qword ptr [7FFAE0E170D8]
       mov       rdx,rax
       jmp       near ptr M06_L05
M06_L15:
       mov       rdx,[rsi+r14]
       mov       r8,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       add       r14,8
       jmp       near ptr M06_L08
; Total bytes of code 627
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.OpenTelemetryExtensionsBenchmark.SetStatusIfError()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Diagnostics.Activity
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1B339C001C0
       mov       rdx,[rcx]
       lea       rcx,[rsi+88]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+0A8],1
       mov       rcx,1F3B8C00C08
       mov       [rsi+80],rcx
       mov       [rbp-30],rsi
       mov       rcx,rsi
       call      qword ptr [7FFAE0DBE4D8]; System.Diagnostics.Activity.Start()
       mov       rdi,[rbx+198]
       test      rdi,rdi
       je        short M00_L01
       mov       rcx,offset MT_System.InvalidOperationException
       cmp       [rdi],rcx
       jne       near ptr M00_L05
       mov       rdx,[rdi+10]
       test      rdx,rdx
       je        short M00_L02
M00_L00:
       mov       dword ptr [rsi+9C],2
       lea       rcx,[rsi+70]
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-28],rsi
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       jmp       short M00_L06
M00_L02:
       mov       rcx,1F3B8C013A8
       call      qword ptr [7FFAE0E46178]
       mov       r14,rax
       mov       rcx,rdi
       call      qword ptr [7FFAE09461C0]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L03
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L03
       mov       rax,rcx
       jmp       short M00_L04
M00_L03:
       mov       rcx,rax
       call      qword ptr [7FFAE09456C8]; System.RuntimeType.InitializeCache()
M00_L04:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFAE0E46190]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFAE0E461A8]
       mov       rdx,rax
       jmp       near ptr M00_L00
M00_L05:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M00_L00
M00_L06:
       test      byte ptr [rsi+0A4],80
       jne       short M00_L07
       mov       rcx,rsi
       call      qword ptr [7FFAE0DBEB98]; System.Diagnostics.Activity.Stop()
M00_L07:
       mov       rbx,[rsi]
       test      dword ptr [rbx],100000
       jne       short M00_L09
M00_L08:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L09:
       mov       rcx,rsi
       call      00007FFB4039D4D0
       jmp       short M00_L08
       sub       rsp,28
       mov       rcx,[rbp-30]
       test      byte ptr [rcx+0A4],80
       jne       short M00_L10
       call      qword ptr [7FFAE0DBEB98]; System.Diagnostics.Activity.Stop()
       mov       rcx,[rbp-30]
M00_L10:
       mov       rbx,[rcx]
       test      dword ptr [rbx],100000
       je        short M00_L11
       call      00007FFB4039D4D0
M00_L11:
       nop
       add       rsp,28
       ret
; Total bytes of code 407
```
```assembly
; System.Diagnostics.Activity.Start()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       rbx,rcx
       cmp       qword ptr [rbx+10],0
       jne       near ptr M01_L22
       cmp       qword ptr [rbx+38],0
       jne       near ptr M01_L22
       mov       rcx,1B339C001C8
       mov       rsi,[rcx]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M01_L23
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M01_L23
M01_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M01_L01
       call      qword ptr [7FFAE0A0FCF0]; System.Threading.Thread.InitializeCurrentThread()
M01_L01:
       mov       rcx,[rax+8]
       test      rcx,rcx
       je        short M01_L02
       mov       rcx,[rcx+8]
       lea       r8,[rsp+58]
       mov       rdx,rsi
       mov       r11,7FFAE06C0A70
       call      qword ptr [r11]
       mov       rdx,[rsp+58]
       jmp       short M01_L03
M01_L02:
       xor       edx,edx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+58],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M01_L04
       mov       rcx,offset MT_System.Diagnostics.Activity
       cmp       [rsi],rcx
       je        short M01_L04
       call      qword ptr [7FFAE0944D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rsi,rax
M01_L04:
       mov       rdx,rsi
       lea       rcx,[rbx+78]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+20],0
       jne       short M01_L05
       cmp       qword ptr [rbx+28],0
       jne       short M01_L05
       test      rsi,rsi
       jne       near ptr M01_L24
M01_L05:
       mov       [rsp+90],rbx
       mov       rcx,[rbx+0B8]
       shl       rcx,2
       jne       short M01_L08
       lea       rcx,[rsp+50]
       mov       rax,7FFB8F885380
       call      rax
       mov       rbx,[rsp+50]
       mov       rax,1B323C01B08
       mov       rsi,[rax]
       sub       rbx,[rsi+8]
       cmp       dword ptr [7FFB406A4A90],0
       jne       near ptr M01_L25
M01_L06:
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jae       near ptr M01_L26
       add       rbx,[rsi+10]
M01_L07:
       mov       rsi,[rsp+90]
       mov       [rsi+0B8],rbx
       mov       [rsp+90],rsi
M01_L08:
       mov       rbx,[rsp+90]
       test      byte ptr [rbx+0A4],3
       jne       short M01_L11
       cmp       byte ptr [7FFAE06BB174],0
       jne       short M01_L09
       cmp       qword ptr [rbx+90],0
       jne       near ptr M01_L28
       cmp       qword ptr [rbx+28],0
       jne       near ptr M01_L27
       cmp       qword ptr [rbx+20],0
       jne       short M01_L12
M01_L09:
       call      qword ptr [7FFAE0DBE8B0]; System.Diagnostics.Activity.get_DefaultIdFormat()
M01_L10:
       movzx     ecx,byte ptr [rbx+0A4]
       and       ecx,0FC
       movzx     eax,al
       and       eax,3
       or        ecx,eax
       mov       [rbx+0A4],cl
M01_L11:
       movzx     ecx,byte ptr [rbx+0A4]
       and       ecx,3
       cmp       ecx,2
       jne       near ptr M01_L29
       cmp       qword ptr [rbx+30],0
       jne       short M01_L15
       mov       rcx,rbx
       call      qword ptr [7FFAE0DBE910]; System.Diagnostics.Activity.TrySetTraceIdFromParent()
       test      eax,eax
       jne       short M01_L15
       mov       rax,1B339C001E0
       mov       rsi,[rax]
       test      rsi,rsi
       je        short M01_L13
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rdx,rax
       jmp       short M01_L14
M01_L12:
       mov       rcx,[rbx+20]
       call      qword ptr [7FFAE0E46058]
       test      eax,eax
       jne       near ptr M01_L27
       mov       eax,1
       jmp       short M01_L10
M01_L13:
       call      qword ptr [7FFAE0DBE928]; System.Diagnostics.ActivityTraceId.CreateRandom()
       mov       rdx,rax
M01_L14:
       mov       rcx,1F3B8C012F0
       test      rdx,rdx
       cmove     rdx,rcx
       lea       rcx,[rbx+30]
       call      CORINFO_HELP_ASSIGN_REF
M01_L15:
       test      byte ptr [rbx+0A5],80
       jne       short M01_L16
       mov       rcx,rbx
       call      qword ptr [7FFAE0DBE9D0]; System.Diagnostics.Activity.TrySetTraceFlagsFromParent()
M01_L16:
       lea       rsi,[rsp+48]
       call      qword ptr [7FFAE0DBE958]; System.Diagnostics.RandomNumberGenerator.get_Current()
       mov       rcx,[rax+10]
       lea       rdx,[rcx+rcx*4]
       rol       rdx,7
       lea       rdx,[rdx+rdx*8]
       mov       r8,rcx
       shl       r8,11
       mov       r10,[rax+18]
       mov       r9,[rax+8]
       xor       r10,r9
       mov       [rax+18],r10
       mov       r11,rcx
       xor       r11,[rax+20]
       mov       [rax+20],r11
       xor       rcx,r10
       mov       [rax+10],rcx
       xor       r9,r11
       mov       [rax+8],r9
       xor       r8,r10
       mov       [rax+18],r8
       rol       r11,2D
       mov       [rax+20],r11
       mov       [rsi],rdx
       lea       rcx,[rsp+48]
       mov       rax,1B323C01EA8
       mov       rsi,[rax]
       mov       [rsp+30],rcx
       mov       dword ptr [rsp+38],8
       mov       dword ptr [rsp+40],2020
       test      rsi,rsi
       jne       short M01_L17
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1B323C01EA0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       mov       [rsi+18],rcx
       mov       rcx,1B323C01EA8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L17:
       mov       rcx,offset MT_System.String
       mov       edx,10
       call      00007FFB403E50F0
       mov       rdi,rax
       cmp       [rdi],dil
       lea       rdx,[rdi+0C]
       mov       [rsp+20],rdx
       mov       dword ptr [rsp+28],10
       lea       rdx,[rsp+20]
       lea       r8,[rsp+30]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       lea       rcx,[rbx+38]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L18:
       mov       rcx,rbx
       call      qword ptr [7FFAE0DBEA00]; System.Diagnostics.Activity.SetCurrent(System.Diagnostics.Activity)
       mov       rcx,[rbx+88]
       mov       rsi,[rcx+8]
       test      rsi,rsi
       je        short M01_L21
       mov       rcx,[rsi+10]
       cmp       dword ptr [rcx+8],0
       jle       short M01_L21
       mov       rcx,1B339C00240
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M01_L19
       mov       rcx,offset MT_System.Action<System.Diagnostics.ActivityListener, System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1B339C00208
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFAE0E42040
       mov       [rdi+18],rcx
       mov       rcx,1B339C00240
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L19:
       mov       rsi,[rsi+10]
       mov       ebp,[rsi+8]
       mov       r14d,10
       inc       ebp
M01_L20:
       dec       ebp
       jne       near ptr M01_L30
M01_L21:
       mov       rax,rbx
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L22:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1F3B8C01180
       call      qword ptr [7FFAE0E46010]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFAE0A0D860]; System.InvalidOperationException..ctor(System.String)
       mov       rcx,rsi
       call      qword ptr [7FFAE0E46028]
       jmp       short M01_L21
M01_L23:
       mov       ecx,4
       call      qword ptr [7FFAE0E45500]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L24:
       lea       rcx,[rbx+90]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L25:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L06
M01_L26:
       call      qword ptr [7FFAE0CA6D78]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M01_L07
M01_L27:
       mov       eax,2
       jmp       near ptr M01_L10
M01_L28:
       mov       rax,[rbx+90]
       movzx     eax,byte ptr [rax+0A4]
       and       eax,3
       jmp       near ptr M01_L10
M01_L29:
       mov       rcx,rbx
       call      qword ptr [7FFAE0E46070]
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L18
M01_L30:
       mov       rdx,[rsi+r14]
       mov       r8,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       add       r14,8
       jmp       near ptr M01_L20
; Total bytes of code 1234
```
```assembly
; System.Object.GetType()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FFAE0775C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M02_L00
; Total bytes of code 41
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M03_L08
M03_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M03_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M03_L09
M03_L01:
       test      rdi,rdi
       jne       near ptr M03_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FFB403953D0
       mov       r14,rax
       test      r14,r14
       je        near ptr M03_L10
M03_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M03_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FFAE0968420
       mov       [rbp-78],rax
       lea       rax,[M03_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFB402723D0
       call      rax
M03_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFB406A4A90],0
       je        short M03_L04
       call      qword ptr [7FFB40692648]; CORINFO_HELP_STOP_FOR_GC
M03_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M03_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFB403ABEF0
       mov       rdx,rax
       test      rdx,rdx
       je        short M03_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M03_L11
M03_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M03_L07:
       mov       rax,rdi
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
M03_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFAE0E4CA68]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M03_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFAE0E46280]
       jmp       near ptr M03_L00
M03_L09:
       call      qword ptr [7FFAE0776328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFAE0945710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M03_L02
M03_L11:
       mov       rdx,rax
       call      qword ptr [7FFAE0776328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 568
```
```assembly
; System.Diagnostics.Activity.Stop()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       cmp       qword ptr [rbx+10],0
       jne       short M04_L00
       cmp       qword ptr [rbx+38],0
       je        near ptr M04_L11
M04_L00:
       movzx     ecx,byte ptr [rbx+0A4]
       test      cl,80
       jne       near ptr M04_L10
       or        ecx,80
       mov       [rbx+0A4],cl
       mov       [rsp+60],rbx
       mov       rcx,[rbx+0B0]
       test      rcx,rcx
       jne       near ptr M04_L06
       lea       rcx,[rsp+28]
       mov       rax,7FFB8F885380
       call      rax
       mov       rbx,[rsp+28]
       mov       rax,1B323C01B08
       mov       rsi,[rax]
       sub       rbx,[rsi+8]
       cmp       dword ptr [7FFB406A4A90],0
       jne       near ptr M04_L12
M04_L01:
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jae       near ptr M04_L13
       add       rbx,[rsi+10]
M04_L02:
       mov       rcx,rbx
       shr       rcx,3E
       mov       eax,ecx
       shr       eax,1
       andn      ecx,eax,ecx
       cmp       ecx,1
       jne       short M04_L04
       mov       rsi,[rsp+60]
       mov       rcx,[rsi+0B8]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rax,rcx
       mov       rcx,rax
       mov       [rsi+0B0],rcx
       test      rax,rax
       jle       short M04_L03
       mov       [rsp+60],rsi
       jmp       short M04_L06
M04_L03:
       mov       qword ptr [rsi+0B0],1
       mov       [rsp+60],rsi
       jmp       short M04_L06
M04_L04:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,1F3B8C01428
       call      qword ptr [7FFAE0E46010]
       mov       rdx,rax
       test      rdx,rdx
       je        near ptr M04_L14
M04_L05:
       mov       rcx,80131500E0434352
       mov       [rbx+68],rcx
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+6C],80131509
       mov       rcx,rbx
       call      qword ptr [7FFAE0E46028]
M04_L06:
       mov       rbx,[rsp+60]
       mov       rcx,[rbx+88]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M04_L09
       mov       rsi,[rcx+10]
       cmp       dword ptr [rsi+8],0
       jle       short M04_L09
       mov       rcx,1B339C00248
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M04_L07
       mov       rcx,offset MT_System.Action<System.Diagnostics.ActivityListener, System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1B339C00208
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFAE0E421C0
       mov       [rdi+18],rcx
       mov       rcx,1B339C00248
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M04_L07:
       mov       ebp,[rsi+8]
       mov       r14d,10
       inc       ebp
M04_L08:
       dec       ebp
       jne       near ptr M04_L15
M04_L09:
       mov       rcx,[rbx+78]
       call      qword ptr [7FFAE0DBEA00]; System.Diagnostics.Activity.SetCurrent(System.Diagnostics.Activity)
M04_L10:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L11:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,1F3B8C013E8
       call      qword ptr [7FFAE0E46010]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFAE0A0D860]; System.InvalidOperationException..ctor(System.String)
       mov       rcx,rbx
       call      qword ptr [7FFAE0E46028]
       jmp       short M04_L10
M04_L12:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M04_L01
M04_L13:
       call      qword ptr [7FFAE0CA6D78]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M04_L02
M04_L14:
       mov       rcx,1F3B8BF7230
       call      qword ptr [7FFAE0E46178]
       mov       rdx,rax
       jmp       near ptr M04_L05
M04_L15:
       mov       rdx,[rsi+r14]
       mov       r8,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       add       r14,8
       jmp       near ptr M04_L08
; Total bytes of code 627
```

