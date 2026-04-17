## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_JsonSerializer_Generator_Person_List()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+58],xmm4
       xor       eax,eax
       mov       [rsp+68],rax
       mov       rbx,rcx
       mov       [rsp+0A0],rbx
       mov       rsi,[rbx+148]
       mov       [rsp+50],rsi
       mov       rcx,27B3C400790
       mov       rdi,[rcx]
       mov       [rsp+48],rdi
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rcx,rdi
       call      qword ptr [7FF7A9DACB28]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rbp,rax
       mov       [rsp+40],rbp
       cmp       [rbp],bpl
       mov       r14,2BBBB30A820
       mov       [rsp+38],r14
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,7FF8091FF0F0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FF809513A10],0
       jne       near ptr M00_L07
M00_L00:
       cmp       ebx,0F
       je        near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,7FF8091FF0F0
       call      rax
       movzx     ebx,al
       mov       r14,[rsp+38]
       cmp       dword ptr [7FF809513A10],0
       jne       near ptr M00_L08
M00_L01:
       cmp       ebx,10
       je        near ptr M00_L11
       mov       rcx,r14
       call      qword ptr [7FF7A94EA398]; System.RuntimeType.get_IsByRefLike()
       test      eax,eax
       jne       near ptr M00_L11
       mov       rcx,r14
       call      qword ptr [7FF7A9774B70]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L09
M00_L02:
       test      rcx,rcx
       je        near ptr M00_L10
       call      00007FF809203260
       test      eax,eax
       jne       near ptr M00_L11
       mov       dword ptr [rsp+20],1
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       rcx,[rsp+40]
       mov       r14,2BBBB30A820
       mov       rdx,r14
       mov       r8d,1
       call      qword ptr [7FF7A9AA4000]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       je        short M00_L05
       cmp       byte ptr [rbx+119],2
       jne       near ptr M00_L12
M00_L03:
       mov       rsi,[rsp+50]
       lea       rcx,[rsi+0C]
       mov       edx,[rsi+8]
       mov       [rsp+58],rcx
       mov       [rsp+60],edx
       lea       rcx,[rsp+58]
       mov       rdx,rbx
       call      qword ptr [7FF7A9DAEBE0]; System.Text.Json.JsonSerializer.ReadFromSpanAsObject(System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       mov       r8,rax
       test      r8,r8
       je        short M00_L04
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r8],rcx
       jne       near ptr M00_L13
M00_L04:
       mov       [rsp+68],r8
       mov       rbx,[rsp+0A0]
       mov       r14,[rbx+60]
       mov       rdx,[rsp+68]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [r14+8],rdx
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       mov       rdx,[rsp+48]
       mov       rcx,r14
       call      qword ptr [7FF7A9F765B0]
       int       3
M00_L06:
       mov       ecx,3888
       mov       rdx,7FF7A9A02F00
       call      qword ptr [7FF7A95AF228]
       mov       rcx,rax
       call      qword ptr [7FF7A99CD4B8]
       int       3
M00_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L00
M00_L08:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L01
M00_L09:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L10:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A99CD9B0]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF7A99CD9C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       ecx,3C7C
       mov       rdx,7FF7A9A02F00
       call      qword ptr [7FF7A95AF228]
       mov       rcx,rax
       mov       r14,2BBBB30A820
       mov       rdx,r14
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF7A9F75668]
       int       3
M00_L12:
       mov       rcx,rbx
       call      qword ptr [7FF7A9AFDC80]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L03
M00_L13:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r8,rax
       jmp       near ptr M00_L04
; Total bytes of code 676
```
```assembly
; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M01_L01
M01_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF7A99C5BA8]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF7A9DA4690]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FF7A9F75650]
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L00
; Total bytes of code 90
```
```assembly
; System.RuntimeType.get_IsByRefLike()
       mov       rax,[rcx+18]
       test      al,2
       jne       short M02_L01
       mov       eax,[rax]
       and       eax,80001000
       cmp       eax,1000
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       jmp       short M02_L00
; Total bytes of code 31
```
```assembly
; System.Type.GetRootElementType()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbx,rcx
       mov       rsi,offset MT_System.RuntimeType
M03_L00:
       cmp       [rbx],rsi
       jne       near ptr M03_L09
       mov       [rsp+20],rbx
       mov       rcx,[rbx+18]
       mov       rax,7FF8091FF0F0
       call      rax
       movzx     ebx,al
       mov       rdi,[rsp+20]
       cmp       dword ptr [7FF809513A10],0
       jne       short M03_L07
M03_L01:
       cmp       ebx,1D
       ja        short M03_L02
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       short M03_L08
M03_L02:
       cmp       ebx,10
       sete      bpl
       movzx     ebp,bpl
M03_L03:
       test      ebp,ebp
       jne       short M03_L04
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L04:
       cmp       [rdi],rsi
       jne       short M03_L05
       mov       rcx,rdi
       call      qword ptr [7FF7A9777648]; System.RuntimeTypeHandle.GetElementType(System.RuntimeType)
       jmp       short M03_L06
M03_L05:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
M03_L06:
       mov       rdi,rax
       mov       rbx,rdi
       jmp       short M03_L00
M03_L07:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L01
M03_L08:
       mov       ebp,1
       jmp       short M03_L03
M03_L09:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       ebp,eax
       mov       rdi,rbx
       jmp       short M03_L03
; Total bytes of code 183
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       mov       [rbp-50],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       xor       ebx,ebx
       cmp       byte ptr [rcx+9E],0
       je        near ptr M04_L41
       mov       r8,[rcx+8]
       test      r8,r8
       je        near ptr M04_L12
M04_L00:
       mov       [rbp-50],r8
       mov       rbx,[r8+8]
       mov       rax,27B264019A8
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M04_L13
M04_L01:
       mov       [rbp-58],rbx
       mov       rax,[rbp+18]
       mov       rdx,rax
       cmp       [rbx],bl
       test      rdx,rdx
       je        near ptr M04_L11
       mov       rdi,[rbx+8]
       mov       r11,[rdi+8]
       cmp       byte ptr [rbx+19],0
       jne       near ptr M04_L10
       mov       rcx,r11
       mov       r11,7FF7A94F10F0
       call      qword ptr [r11]
       mov       ebx,eax
M04_L02:
       mov       r14,[rdi+8]
       mov       rcx,[rdi+10]
       mov       edx,ebx
       imul      rdx,[rdi+28]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M04_L43
       mov       edx,edx
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M04_L17
M04_L03:
       cmp       ebx,[r15+20]
       jne       near ptr M04_L15
       mov       r13,[r15+8]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r14],rcx
       jne       near ptr M04_L16
       test      r13,r13
       je        near ptr M04_L15
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M04_L14
       mov       rax,[rbp+18]
       cmp       rax,r13
       sete      r12b
       movzx     r12d,r12b
M04_L04:
       test      r12d,r12d
       je        near ptr M04_L15
       mov       rdx,[r15+10]
       mov       [rbp-60],rdx
M04_L05:
       cmp       byte ptr [rbp+38],0
       jne       near ptr M04_L37
M04_L06:
       mov       rcx,[rbp-60]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       near ptr M04_L38
       mov       rcx,[rbp-60]
       mov       rbx,[rcx+8]
M04_L07:
       cmp       byte ptr [rbp+20],0
       je        short M04_L08
       test      rbx,rbx
       je        short M04_L08
       cmp       byte ptr [rbx+119],2
       jne       near ptr M04_L40
M04_L08:
       test      rbx,rbx
       je        near ptr M04_L42
M04_L09:
       mov       rax,rbx
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
M04_L10:
       mov       rcx,rdx
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+18]
       mov       ebx,eax
       jmp       near ptr M04_L02
M04_L11:
       mov       ecx,1
       mov       rdx,7FF7A987F038
       call      qword ptr [7FF7A95AF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9AFDA10]
       int       3
M04_L12:
       call      qword ptr [7FF7A9AA4018]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       r8,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M04_L00
M04_L13:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FF7A94ED110
       call      qword ptr [7FF7A95A7180]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,27B264019A8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       jmp       near ptr M04_L01
M04_L14:
       mov       rax,[rbp+18]
       mov       rcx,r13
       mov       rdx,rax
       mov       r8,[r13]
       mov       r8,[r8+40]
       call      qword ptr [r8+10]
       mov       r12d,eax
       mov       rax,[rbp+18]
       jmp       near ptr M04_L04
M04_L15:
       mov       rax,[rbp+18]
       mov       r15,[r15+18]
       test      r15,r15
       jne       near ptr M04_L03
       jmp       short M04_L17
M04_L16:
       mov       rax,[rbp+18]
       mov       rcx,r14
       mov       r8,rax
       mov       rdx,r13
       mov       r11,7FF7A94F10F8
       call      qword ptr [r11]
       mov       r12d,eax
       mov       rax,[rbp+18]
       jmp       near ptr M04_L04
M04_L17:
       mov       rax,[rbp+18]
       xor       edx,edx
       mov       [rbp-60],rdx
       mov       [rbp-68],rdi
       mov       rdx,rax
       mov       r8,[rbp-50]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       [rbp-78],rax
       mov       rsi,[rdi+8]
       jmp       near ptr M04_L32
M04_L18:
       mov       rcx,[rbp-70]
       mov       ecx,[rcx+8]
       cmp       [rbp-3C],ecx
       jae       near ptr M04_L27
       mov       rcx,[rbp-70]
       mov       eax,[rbp-3C]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       short M04_L19
       xor       ecx,ecx
       call      qword ptr [7FF7A99CD4B8]
       int       3
M04_L19:
       mov       rcx,r14
       call      00007FF809262D60
       test      eax,eax
       jne       short M04_L20
       mov       rcx,r14
       call      qword ptr [7FF7A99CD878]
M04_L20:
       mov       dword ptr [rbp-48],1
       mov       rcx,[rbp-68]
       mov       rax,[rbp-58]
       cmp       rcx,[rax+8]
       je        short M04_L23
       mov       rcx,[rax+8]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       cmp       rsi,[rcx+8]
       je        near ptr M04_L31
       mov       rcx,[rbp-68]
       mov       rsi,[rcx+8]
       cmp       byte ptr [rax+19],0
       jne       short M04_L21
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r11,7FF7A94F1108
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M04_L22
M04_L21:
       mov       rcx,[rbp+18]
       mov       rdx,[rcx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+18]
       mov       ebx,eax
M04_L22:
       mov       rax,[rbp-58]
       jmp       near ptr M04_L31
M04_L23:
       xor       r14d,r14d
       mov       r15,[rdi]
       test      r15,r15
       je        short M04_L29
M04_L24:
       cmp       ebx,[r15+20]
       jne       short M04_L25
       mov       rdx,[r15+8]
       mov       rcx,rsi
       mov       r8,[rbp+18]
       mov       r11,7FF7A94F1110
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-58]
       jne       short M04_L26
M04_L25:
       inc       r14d
       mov       r15,[r15+18]
       test      r15,r15
       jne       short M04_L24
       jmp       short M04_L29
M04_L26:
       mov       rcx,[r15+10]
       mov       [rbp-60],rcx
       jmp       near ptr M04_L34
M04_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M04_L29:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13,[rdi]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp-78]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+20],ebx
       mov       rcx,rdi
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-68]
       mov       rdx,[rdx+20]
       mov       ecx,[rdx+8]
       cmp       [rbp-3C],ecx
       jae       short M04_L27
       mov       ecx,[rbp-3C]
       lea       rdx,[rdx+rcx*4+10]
       mov       ecx,[rdx]
       add       ecx,1
       jo        short M04_L28
       mov       [rdx],ecx
       mov       rdx,[rbp-68]
       mov       rdx,[rdx+20]
       mov       ecx,[rdx+8]
       cmp       [rbp-3C],ecx
       jae       near ptr M04_L27
       mov       ecx,[rbp-3C]
       mov       edx,[rdx+rcx*4+10]
       mov       ecx,1
       mov       rax,[rbp-58]
       cmp       edx,[rax+10]
       cmovle    ecx,[rbp-40]
       mov       [rbp-40],ecx
       cmp       r14d,64
       jbe       short M04_L30
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       ecx,1
       test      rax,rax
       cmove     ecx,[rbp-44]
       mov       [rbp-44],ecx
M04_L30:
       call      M04_L44
       jmp       near ptr M04_L35
M04_L31:
       mov       rcx,[rbp-70]
       mov       edx,[rbp-3C]
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M04_L33
       mov       rcx,r14
       call      00007FF809262C80
       test      eax,eax
       je        short M04_L32
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF7A99CD4D0]
M04_L32:
       mov       rax,[rbp-68]
       mov       rax,[rax+18]
       mov       [rbp-70],rax
       mov       rax,[rbp-68]
       mov       rcx,[rax+10]
       mov       rax,[rbp-68]
       mov       r8d,ebx
       imul      r8,[rax+28]
       shr       r8,20
       inc       r8
       mov       r10d,[rcx+8]
       imul      r8,r10
       shr       r8,20
       mov       rax,[rbp-68]
       mov       r10,[rax+18]
       mov       eax,r8d
       xor       edx,edx
       div       dword ptr [r10+8]
       mov       [rbp-3C],edx
       cmp       r8d,[rcx+8]
       jae       near ptr M04_L43
       mov       eax,r8d
       lea       rdi,[rcx+rax*8+10]
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       [rbp-44],ecx
       mov       [rbp-48],ecx
       jmp       near ptr M04_L18
M04_L33:
       xor       ecx,ecx
       call      qword ptr [7FF7A99CD4B8]
       int       3
M04_L34:
       call      M04_L44
       jmp       near ptr M04_L05
M04_L35:
       mov       ecx,[rbp-40]
       or        ecx,[rbp-44]
       je        short M04_L36
       mov       rcx,[rbp-58]
       mov       rdx,[rbp-68]
       mov       r8d,[rbp-40]
       mov       r9d,[rbp-44]
       call      qword ptr [7FF7A9CC5E90]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
M04_L36:
       mov       r8,[rbp-78]
       mov       [rbp-60],r8
       jmp       near ptr M04_L05
M04_L37:
       mov       rcx,[rbp-60]
       cmp       byte ptr [rcx+20],0
       je        short M04_L39
       jmp       near ptr M04_L06
M04_L38:
       call      qword ptr [7FF7A9EAED18]
       int       3
M04_L39:
       mov       rcx,[rbp-50]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-60]
       call      qword ptr [7FF7A9EAED30]
       mov       rbx,rax
       jmp       near ptr M04_L07
M04_L40:
       mov       rcx,rbx
       call      qword ptr [7FF7A9AFDC80]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M04_L08
M04_L41:
       cmp       byte ptr [rbp+30],0
       je        near ptr M04_L08
       mov       rdx,[rbp+18]
       call      qword ptr [7FF7A9AA45A0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       jmp       near ptr M04_L08
M04_L42:
       cmp       byte ptr [rbp+29],0
       je        near ptr M04_L09
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+20]
       mov       rcx,[rbp+18]
       call      qword ptr [7FF7A9EAEB38]
       int       3
M04_L43:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L44:
       sub       rsp,28
       cmp       dword ptr [rbp-48],0
       je        short M04_L47
       mov       rcx,[rbp-70]
       mov       ecx,[rcx+8]
       cmp       [rbp-3C],ecx
       jae       short M04_L45
       mov       rcx,[rbp-70]
       mov       eax,[rbp-3C]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       short M04_L46
       xor       ecx,ecx
       call      qword ptr [7FF7A99CD4B8]
       int       3
M04_L45:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L46:
       mov       rcx,r14
       call      00007FF809262C80
       test      eax,eax
       je        short M04_L47
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF7A99CD4D0]
M04_L47:
       nop
       add       rsp,28
       ret
; Total bytes of code 1572
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpanAsObject(System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,268
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+38],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M05_L00:
       vmovdqa   xmmword ptr [rbp+rax+220],xmm4
       vmovdqa   xmmword ptr [rbp+rax+230],xmm4
       vmovdqa   xmmword ptr [rbp+rax+240],xmm4
       add       rax,30
       jne       short M05_L00
       mov       rax,83C0ECDF2467
       mov       [rbp+8],rax
       mov       rbx,rdx
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       xor       ecx,ecx
       mov       [rbp+40],rcx
       cmp       edi,55
       jle       near ptr M05_L15
       cmp       edi,15555555
       jg        near ptr M05_L16
       mov       rcx,27B26401E48
       mov       r14,[rcx]
       mov       r15,r14
       lea       r13d,[rdi+rdi*2]
       mov       rcx,27B26400C90
       mov       r12,[rcx]
       lea       ecx,[r13-1]
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rbp+234],eax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M05_L17
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+50]
       test      rdx,rdx
       je        near ptr M05_L17
M05_L01:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       je        near ptr M05_L20
       mov       edx,[rcx+8]
       mov       eax,[rbp+234]
       cmp       edx,eax
       jbe       near ptr M05_L21
       mov       edx,eax
       shl       rdx,4
       mov       r8,[rcx+rdx+10]
       test      r8,r8
       je        near ptr M05_L19
       xor       r10d,r10d
       mov       [rcx+rdx+10],r10
       cmp       byte ptr [r12+9D],0
       jne       near ptr M05_L18
M05_L02:
       mov       [rbp+40],r8
M05_L03:
       test      r8,r8
       je        near ptr M05_L36
       lea       r14,[r8+10]
       mov       r15d,[r8+8]
M05_L04:
       mov       [rbp+10],r14
       mov       [rbp+7C],r15d
       mov       [rbp+68],rsi
       mov       [rbp+70],edi
       mov       [rbp+58],r14
       mov       [rbp+60],r15d
       lea       rcx,[rbp+68]
       lea       rdx,[rbp+58]
       call      qword ptr [7FF7A99CF498]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,r15d
       ja        near ptr M05_L07
       mov       [rbp+10],r14
       mov       [rbp+7C],eax
       mov       rdx,[rbx+0B8]
       movzx     ecx,byte ptr [rdx+94]
       movzx     r9d,byte ptr [rdx+92]
       cmp       r9d,2
       jg        near ptr M05_L08
       mov       edx,[rdx+88]
       test      edx,edx
       jl        near ptr M05_L09
       xor       r8d,r8d
       mov       [rbp+1E8],r8
       mov       [rbp+1F0],r8
       mov       byte ptr [rbp+1F8],0
       mov       byte ptr [rbp+1F9],0
       mov       byte ptr [rbp+1FA],0
       mov       byte ptr [rbp+1FB],0
       mov       byte ptr [rbp+1FC],0
       mov       byte ptr [rbp+1FD],0
       mov       [rbp+200],edx
       mov       [rbp+204],r9b
       mov       [rbp+205],cl
       mov       byte ptr [rbp+206],0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+208],xmm0
       vmovdqu   xmmword ptr [rbp+210],xmm0
       mov       [rbp+48],r14
       mov       [rbp+50],eax
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+128]
       lea       r9,[rbp+1E8]
       mov       r8d,1
       call      qword ptr [7FF7A9B5C810]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+88],ymm0
       vmovdqu   ymmword ptr [rbp+0A8],ymm0
       vmovdqu   ymmword ptr [rbp+0C8],ymm0
       vmovdqu   ymmword ptr [rbp+0E8],ymm0
       vmovdqu   ymmword ptr [rbp+108],ymm0
       mov       rcx,[rbx+0B8]
       cmp       dword ptr [rcx+8C],1
       je        near ptr M05_L10
M05_L05:
       mov       [rbp+0E0],rbx
       mov       r8,[rbx+0D0]
       mov       [rbp+0B8],r8
       mov       r8,[rbp+0B8]
       mov       r8,[r8+0C8]
       mov       [rbp+11C],r8
       cmp       byte ptr [rbp+0B1],0
       jne       near ptr M05_L12
       mov       r8,[rbx+0A0]
       test      r8,r8
       jne       near ptr M05_L11
       xor       edx,edx
M05_L06:
       mov       [rbp+113],dl
       mov       byte ptr [rbp+0B0],0
       lea       r8,[rbp+88]
       lea       rdx,[rbp+128]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       [rbp+38],rax
       jmp       short M05_L13
M05_L07:
       call      qword ptr [7FF7A977F228]
       int       3
M05_L08:
       mov       ecx,38A0
       mov       rdx,7FF7A9A02F00
       call      qword ptr [7FF7A95AF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9F74C90]
       int       3
M05_L09:
       mov       ecx,38A0
       mov       rdx,7FF7A9A02F00
       call      qword ptr [7FF7A95AF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9F74CA8]
       int       3
M05_L10:
       mov       rcx,[rcx+38]
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rbp+90],rax
       mov       byte ptr [rbp+0B1],1
       jmp       near ptr M05_L05
M05_L11:
       movzx     edx,byte ptr [r8+34]
       jmp       near ptr M05_L06
M05_L12:
       mov       edx,1
       jmp       near ptr M05_L06
M05_L13:
       call      M05_L39
       nop
       mov       rax,[rbp+38]
       mov       r8,83C0ECDF2467
       cmp       [rbp+8],r8
       je        short M05_L14
       call      CORINFO_HELP_FAIL_FAST
M05_L14:
       nop
       lea       rsp,[rbp+238]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L15:
       test      [rsp],esp
       sub       rsp,100
       lea       r14,[rsp+30]
       mov       r15d,100
       jmp       near ptr M05_L04
M05_L16:
       mov       [rbp+68],rsi
       mov       [rbp+70],edi
       lea       rcx,[rbp+68]
       call      qword ptr [7FF7A99CE970]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       jmp       near ptr M05_L03
M05_L17:
       mov       ecx,0A
       call      qword ptr [7FF7A9EADAA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M05_L01
M05_L18:
       mov       [rbp+30],r8
       mov       rcx,r8
       call      qword ptr [7FF7A9AA4198]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13,[rbp+30]
       mov       eax,[r13+8]
       mov       [rbp+224],eax
       mov       rcx,r14
       call      qword ptr [7FF7A9AA4198]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r14d,[rbp+234]
       mov       [rsp+20],r14d
       mov       edx,r15d
       mov       r8d,[rbp+224]
       mov       rcx,r12
       call      qword ptr [7FF7A9DAF180]
       mov       r8,r13
       jmp       near ptr M05_L02
M05_L19:
       mov       eax,[rbp+234]
       jmp       short M05_L21
M05_L20:
       mov       eax,[rbp+234]
M05_L21:
       mov       rcx,[r15+10]
       cmp       [rcx+8],eax
       jbe       near ptr M05_L31
       mov       edx,eax
       mov       rcx,[rcx+rdx*8+10]
       test      rcx,rcx
       je        near ptr M05_L30
       mov       r13,[rcx+8]
       call      qword ptr [7FF7A9D44B70]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r14d,eax
       sub       r14d,ecx
       xor       eax,eax
       jmp       short M05_L25
M05_L22:
       cmp       r14d,[r13+8]
       jae       near ptr M05_L38
       mov       ecx,r14d
       mov       rdx,[r13+rcx*8+10]
       mov       [rbp+20],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rbp+28],r8
       mov       rcx,rdx
       call      qword ptr [7FF7A9B54D08]; System.Threading.Monitor.Enter(System.Object)
       mov       rdx,[rbp+20]
       mov       rcx,[rdx+8]
       mov       eax,[rdx+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M05_L23
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
       mov       [rbp+28],r8
       mov       r10d,eax
       xor       r9d,r9d
       mov       [rcx+r10*8+10],r9
       mov       [rdx+10],eax
M05_L23:
       mov       rcx,rdx
       call      qword ptr [7FF7A95A6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+28]
       test      rcx,rcx
       jne       short M05_L26
       inc       r14d
       cmp       [r13+8],r14d
       jne       short M05_L24
       xor       r14d,r14d
M05_L24:
       mov       eax,[rbp+220]
       inc       eax
M05_L25:
       mov       [rbp+220],eax
       cmp       [r13+8],eax
       jg        near ptr M05_L22
       jmp       short M05_L27
M05_L26:
       mov       r13,rcx
       jmp       short M05_L28
M05_L27:
       xor       r13d,r13d
M05_L28:
       test      r13,r13
       je        short M05_L30
       cmp       byte ptr [r12+9D],0
       je        short M05_L29
       mov       rcx,r13
       call      qword ptr [7FF7A9AA4198]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+228],eax
       mov       rcx,r15
       call      qword ptr [7FF7A9AA4198]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rbp+234]
       mov       [rsp+20],r15d
       mov       edx,r14d
       mov       r8d,[rbp+228]
       mov       rcx,r12
       call      qword ptr [7FF7A9DAF180]
       mov       r8,r13
       jmp       near ptr M05_L02
M05_L29:
       mov       r8,r13
       jmp       near ptr M05_L02
M05_L30:
       mov       ecx,10
       mov       eax,[rbp+234]
       shlx      r13d,ecx,eax
       jmp       short M05_L33
M05_L31:
       test      r13d,r13d
       jne       short M05_L32
       mov       r8,2BBBB2F6D78
       jmp       near ptr M05_L02
M05_L32:
       mov       ecx,r13d
       mov       rdx,2BBBB2F6F28
       call      qword ptr [7FF7A983E670]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M05_L33:
       cmp       r13d,800
       jge       short M05_L34
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M05_L35
M05_L34:
       mov       ecx,r13d
       xor       edx,edx
       call      qword ptr [7FF7A9BCD6B0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M05_L35:
       cmp       byte ptr [r12+9D],0
       je        near ptr M05_L37
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF7A9AA4198]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+230],eax
       mov       rcx,r15
       call      qword ptr [7FF7A9AA4198]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,[rbp+230]
       mov       rcx,r12
       call      qword ptr [7FF7A9DAF180]
       mov       eax,[r13+8]
       mov       [rbp+22C],eax
       mov       rcx,r15
       call      qword ptr [7FF7A9AA4198]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[r15+10]
       mov       edx,1
       mov       r8d,2
       mov       r15d,[rbp+234]
       cmp       [rcx+8],r15d
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,r14d
       mov       r8d,[rbp+22C]
       call      qword ptr [7FF7A9DAF1C8]
       mov       r8,r13
       jmp       near ptr M05_L02
M05_L36:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M05_L04
M05_L37:
       mov       r8,r13
       jmp       near ptr M05_L02
M05_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L39:
       sub       rsp,38
       cmp       qword ptr [rbp+40],0
       je        near ptr M05_L58
       mov       edx,[rbp+7C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF7A95A57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,27B26401E48
       mov       rbx,[rcx]
       mov       rcx,[rbp+40]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       esi,esi
       lzcnt     esi,ecx
       xor       esi,1F
       add       esi,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0A
       jle       short M05_L40
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       jne       short M05_L41
M05_L40:
       mov       ecx,0A
       call      qword ptr [7FF7A9EADAA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M05_L41:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M05_L42
       mov       rcx,rbx
       call      qword ptr [7FF7A9CC56E0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
M05_L42:
       xor       edi,edi
       mov       r14d,1
       mov       ecx,[rax+8]
       cmp       ecx,esi
       jbe       near ptr M05_L54
       mov       edi,1
       mov       rcx,[rbp+40]
       mov       edx,10
       shlx      edx,edx,esi
       cmp       [rcx+8],edx
       je        short M05_L43
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9DAF588]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FF7A94E4000
       call      qword ptr [7FF7A95AF228]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF7A9926E38]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L43:
       mov       ecx,esi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rdx,[rbp+40]
       mov       rcx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       je        near ptr M05_L54
       mov       rcx,[rbx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M05_L55
       mov       edx,esi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M05_L44
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF7A9F75530]
M05_L44:
       mov       r14,[rax+8]
       call      qword ptr [7FF7A9D44B70]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       r12d,r12d
       jmp       near ptr M05_L51
M05_L45:
       cmp       r15d,[r14+8]
       jae       near ptr M05_L55
       mov       ecx,r15d
       mov       rax,[r14+rcx*8+10]
       mov       [rbp+18],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp+84],edx
       mov       rcx,rax
       call      qword ptr [7FF7A9B54D08]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp+18]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp+80],r8d
       cmp       [rcx+8],r8d
       jbe       short M05_L47
       test      r8d,r8d
       jne       short M05_L48
       xor       edx,edx
       mov       [rax+14],edx
M05_L46:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp+80]
       inc       ecx
       mov       rax,[rbp+18]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+84],1
M05_L47:
       mov       rcx,rax
       call      qword ptr [7FF7A95A6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp+84],0
       je        short M05_L49
       jmp       short M05_L52
M05_L48:
       jmp       short M05_L46
M05_L49:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M05_L50
       xor       r15d,r15d
M05_L50:
       inc       r12d
M05_L51:
       cmp       [r14+8],r12d
       jg        near ptr M05_L45
       jmp       short M05_L53
M05_L52:
       mov       r14d,1
       jmp       short M05_L54
M05_L53:
       xor       r14d,r14d
M05_L54:
       mov       rcx,27B26400C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       je        near ptr M05_L58
       mov       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       je        near ptr M05_L58
       mov       rcx,[rbp+40]
       call      qword ptr [7FF7A9AA4198]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp+40]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF7A9AA4198]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FF7A9EAFAB0]
       test      r14d,edi
       jne       short M05_L58
       mov       rcx,[rbp+40]
       call      qword ptr [7FF7A9AA4198]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,[rbp+40]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF7A9AA4198]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      edi,edi
       jne       short M05_L56
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M05_L57
M05_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L56:
       mov       ecx,esi
       xor       edx,edx
M05_L57:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,r13d
       call      qword ptr [7FF7A9DAF600]
M05_L58:
       nop
       add       rsp,38
       ret
; Total bytes of code 2450
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       rax,[rcx+0B8]
       cmp       qword ptr [rax+20],0
       je        near ptr M06_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       near ptr M06_L07
       mov       rbx,[rcx+0B8]
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M06_L08
M06_L00:
       mov       [rbp-20],rsi
       xor       eax,eax
       mov       [rbp-14],eax
       test      rsi,rsi
       je        short M06_L02
       mov       rcx,rsi
       call      00007FF809262D60
       test      eax,eax
       jne       short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FF7A99CD878]
M06_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M06_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M06_L03
       mov       rcx,7FF7A9F3A5D8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF7A9AFDC98]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M06_L04
M06_L02:
       xor       ecx,ecx
       call      qword ptr [7FF7A99CD4B8]
       int       3
M06_L03:
       mov       rcx,7FF7A9F3A5D4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF7A9EAED18]
       int       3
M06_L04:
       mov       rcx,7FF7A9F3A5DC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FF809262C80
       test      eax,eax
       jne       near ptr M06_L10
M06_L05:
       mov       rcx,7FF7A9F3A5E0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF7A9F3A5E4
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L06:
       call      qword ptr [7FF7A9EAF258]
       int       3
M06_L07:
       mov       rcx,7FF7A9F3A5D0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF7A9EAED18]
       int       3
M06_L08:
       mov       rcx,rbx
       call      qword ptr [7FF7A9AA4048]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M06_L09
       call      qword ptr [7FF7A9EAD5A8]
       int       3
M06_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF8091FCC60
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M06_L00
M06_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF7A99CD4D0]
       jmp       near ptr M06_L05
       sub       rsp,28
       call      qword ptr [7FF7A9EAF270]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M06_L12
       mov       rcx,7FF7A9F3A5DC
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M06_L11
       xor       ecx,ecx
       call      qword ptr [7FF7A99CD4B8]
       int       3
M06_L11:
       mov       rcx,[rbp-20]
       call      00007FF809262C80
       test      eax,eax
       je        short M06_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF7A99CD4D0]
M06_L12:
       mov       rcx,7FF7A9F3A5E0
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 535
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M07_L00
       cmp       [rdx],rcx
       jne       short M07_L01
M07_L00:
       mov       rax,rdx
       ret
M07_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L00
M07_L02:
       test      rax,rax
       je        short M07_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L00
       test      rax,rax
       je        short M07_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L00
       test      rax,rax
       je        short M07_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L00
       test      rax,rax
       je        short M07_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L00
       jmp       short M07_L02
M07_L03:
       xor       edx,edx
       jmp       short M07_L00
; Total bytes of code 88
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_JsonSerializer_Generator_Person()
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
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+140]
       mov       [rbp-68],r8
       mov       rbx,21AEBE0FFC0
       mov       [rbp-0B0],rbx
       mov       rax,1DA6D000748
       mov       rax,[rax]
       mov       [rbp-70],rax
       test      r8,r8
       je        near ptr M00_L22
       mov       rsi,[rax+8]
       test      rsi,rsi
       je        near ptr M00_L23
M00_L00:
       mov       [rbp-78],rsi
       mov       rsi,[rbp-78]
       cmp       [rsi],sil
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       mov       rdx,7FF8091FF0F0
       call      rdx
       movzx     ebx,al
       cmp       dword ptr [7FF809513A10],0
       jne       near ptr M00_L24
M00_L01:
       cmp       ebx,0F
       je        near ptr M00_L32
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       mov       rax,7FF8091FF0F0
       call      rax
       movzx     ebx,al
       mov       rsi,[rbp-0B0]
       cmp       dword ptr [7FF809513A10],0
       jne       near ptr M00_L25
M00_L02:
       cmp       ebx,10
       je        near ptr M00_L32
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       mov       ecx,[rcx]
       and       ecx,80001000
       cmp       ecx,1000
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L32
M00_L03:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M00_L29
       mov       [rbp-80],rsi
       mov       rcx,[rsi+18]
       mov       rax,7FF8091FF0F0
       call      rax
       movzx     ebx,al
       mov       rsi,[rbp-80]
       cmp       dword ptr [7FF809513A10],0
       jne       near ptr M00_L27
M00_L04:
       cmp       ebx,1D
       ja        short M00_L05
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M00_L28
M00_L05:
       cmp       ebx,10
       sete      dil
       movzx     edi,dil
M00_L06:
       test      edi,edi
       jne       near ptr M00_L26
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M00_L30
M00_L07:
       test      rsi,rsi
       je        near ptr M00_L31
       mov       rcx,rsi
       call      00007FF809203260
       test      eax,eax
       jne       near ptr M00_L32
       mov       rsi,[rbp-78]
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L59
       mov       rbx,[rsi+8]
       test      rbx,rbx
       je        near ptr M00_L33
M00_L08:
       mov       rsi,[rbx+8]
       mov       rcx,1DA57001968
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L34
M00_L09:
       mov       [rbp-88],rsi
       cmp       [rsi],sil
       mov       r14,[rsi+8]
       mov       rcx,[r14+8]
       cmp       byte ptr [rsi+19],0
       jne       near ptr M00_L18
       mov       rdx,21AEBE0FFC0
       mov       r11,7FF7A9511140
       call      qword ptr [r11]
       mov       esi,eax
M00_L10:
       mov       r15,[r14+8]
       mov       rcx,[r14+10]
       mov       edx,esi
       imul      rdx,[r14+28]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M00_L64
       mov       edx,edx
       mov       r13,[rcx+rdx*8+10]
       test      r13,r13
       je        near ptr M00_L38
M00_L11:
       cmp       esi,[r13+20]
       jne       near ptr M00_L36
       mov       r12,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r15],rcx
       jne       near ptr M00_L37
       test      r12,r12
       je        near ptr M00_L36
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M00_L35
       mov       rcx,21AEBE0FFC0
       cmp       r12,rcx
       sete      al
       movzx     eax,al
M00_L12:
       test      eax,eax
       je        near ptr M00_L36
       mov       rdx,[r13+10]
       mov       [rbp-90],rdx
M00_L13:
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       near ptr M00_L58
       mov       rcx,[rbp-90]
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        short M00_L14
       cmp       byte ptr [rbx+119],2
       jne       near ptr M00_L19
M00_L14:
       test      rbx,rbx
       je        near ptr M00_L60
       cmp       byte ptr [rbx+119],2
       jne       near ptr M00_L20
M00_L15:
       mov       r8,[rbp-68]
       lea       rcx,[r8+0C]
       mov       edx,[r8+8]
       mov       [rbp-60],rcx
       mov       [rbp-58],edx
       lea       rcx,[rbp-60]
       mov       rdx,rbx
       call      qword ptr [7FF7A9DBD398]; System.Text.Json.JsonSerializer.ReadFromSpanAsObject(System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       test      rax,rax
       jne       short M00_L21
M00_L16:
       xor       ecx,ecx
       mov       [rbp-50],rcx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+60]
       mov       rdx,[rbp-50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
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
M00_L18:
       mov       rcx,21AEBE0FFC0
       mov       rax,[7FF7A950A1C0]
       call      qword ptr [rax+18]
       mov       esi,eax
       jmp       near ptr M00_L10
M00_L19:
       mov       rcx,rbx
       call      qword ptr [7FF7A9AC6AA8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L14
M00_L20:
       mov       rcx,rbx
       call      qword ptr [7FF7A9AC6AA8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L15
M00_L21:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       cmp       [rax],rcx
       jne       short M00_L16
       mov       [rbp-50],rax
       jmp       short M00_L17
M00_L22:
       mov       ecx,3888
       mov       rdx,7FF7A9A12F00
       call      qword ptr [7FF7A95CF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9EA6A78]
       int       3
M00_L23:
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF7A99D4DF8]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,[rbp-70]
       call      qword ptr [7FF7A9D4EDF0]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FF7A9F84FD8]
       mov       rdx,[rbp-70]
       lea       rcx,[rdx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L24:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L01
M00_L25:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L02
M00_L26:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L27:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L28:
       mov       edi,1
       jmp       near ptr M00_L06
M00_L29:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       near ptr M00_L06
M00_L30:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rsi,rax
       jmp       near ptr M00_L07
M00_L31:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9EA7630]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF7A9EA6508]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L32:
       mov       ecx,3C7C
       mov       rdx,7FF7A9A12F00
       call      qword ptr [7FF7A95CF228]
       mov       rcx,rax
       mov       rdx,21AEBE0FFC0
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF7A9F84FF0]
       int       3
M00_L33:
       mov       rcx,rsi
       call      qword ptr [7FF7A99DCDC8]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M00_L08
M00_L34:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FF7A950D110
       call      qword ptr [7FF7A95C7180]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,1DA57001968
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L09
M00_L35:
       mov       rcx,r12
       mov       rdx,21AEBE0FFC0
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L12
M00_L36:
       mov       r13,[r13+18]
       test      r13,r13
       jne       near ptr M00_L11
       jmp       short M00_L38
M00_L37:
       mov       rcx,r15
       mov       r8,21AEBE0FFC0
       mov       rdx,r12
       mov       r11,7FF7A9511148
       call      qword ptr [r11]
       jmp       near ptr M00_L12
M00_L38:
       xor       edx,edx
       mov       [rbp-90],rdx
       mov       [rbp-98],r14
       mov       rdx,21AEBE0FFC0
       mov       r8,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       [rbp-0A8],rax
       mov       rbx,[r14+8]
       jmp       near ptr M00_L53
M00_L39:
       mov       rcx,[rbp-0A0]
       mov       ecx,[rcx+8]
       cmp       [rbp-3C],ecx
       jae       near ptr M00_L48
       mov       rcx,[rbp-0A0]
       mov       eax,[rbp-3C]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       short M00_L40
       xor       ecx,ecx
       call      qword ptr [7FF7A9EA6A78]
       int       3
M00_L40:
       mov       rcx,r14
       call      00007FF809262D60
       test      eax,eax
       jne       short M00_L41
       mov       rcx,r14
       call      qword ptr [7FF7A9EA77E0]
M00_L41:
       mov       dword ptr [rbp-48],1
       mov       rcx,[rbp-98]
       mov       rax,[rbp-88]
       cmp       rcx,[rax+8]
       je        short M00_L44
       mov       rcx,[rax+8]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       rbx,[rcx+8]
       je        near ptr M00_L52
       mov       rcx,[rbp-98]
       mov       rbx,[rcx+8]
       cmp       byte ptr [rax+19],0
       jne       short M00_L42
       mov       rcx,rbx
       mov       rdx,21AEBE0FFC0
       mov       r11,7FF7A9511158
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L43
M00_L42:
       mov       rcx,21AEBE0FFC0
       mov       rdx,[7FF7A950A1C0]
       call      qword ptr [rdx+18]
       mov       esi,eax
M00_L43:
       mov       rax,[rbp-88]
       jmp       near ptr M00_L52
M00_L44:
       xor       r14d,r14d
       mov       r15,[rdi]
       test      r15,r15
       je        short M00_L50
M00_L45:
       cmp       esi,[r15+20]
       jne       short M00_L46
       mov       rdx,[r15+8]
       mov       rcx,rbx
       mov       r8,21AEBE0FFC0
       mov       r11,7FF7A9511160
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-88]
       jne       short M00_L47
M00_L46:
       inc       r14d
       mov       r15,[r15+18]
       test      r15,r15
       jne       short M00_L45
       jmp       short M00_L50
M00_L47:
       mov       rcx,[r15+10]
       mov       [rbp-90],rcx
       jmp       near ptr M00_L55
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L50:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13,[rdi]
       mov       rcx,21AEBE0FFC0
       mov       [r15+8],rcx
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0A8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+20],esi
       mov       rcx,rdi
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-98]
       mov       rdx,[rdx+20]
       mov       ecx,[rdx+8]
       cmp       [rbp-3C],ecx
       jae       short M00_L48
       mov       ecx,[rbp-3C]
       lea       rdx,[rdx+rcx*4+10]
       mov       ecx,[rdx]
       add       ecx,1
       jo        short M00_L49
       mov       [rdx],ecx
       mov       rdx,[rbp-98]
       mov       rdx,[rdx+20]
       mov       ecx,[rdx+8]
       cmp       [rbp-3C],ecx
       jae       near ptr M00_L48
       mov       ecx,[rbp-3C]
       mov       edx,[rdx+rcx*4+10]
       mov       ecx,1
       mov       rax,[rbp-88]
       cmp       edx,[rax+10]
       cmovle    ecx,[rbp-40]
       mov       [rbp-40],ecx
       cmp       r14d,64
       jbe       short M00_L51
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       ecx,1
       test      rax,rax
       cmove     ecx,[rbp-44]
       mov       [rbp-44],ecx
M00_L51:
       call      M00_L65
       jmp       near ptr M00_L56
M00_L52:
       mov       rcx,[rbp-0A0]
       mov       edx,[rbp-3C]
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L54
       mov       rcx,r14
       call      00007FF809262C80
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF7A9EA73C0]
M00_L53:
       mov       rax,[rbp-98]
       mov       rax,[rax+18]
       mov       [rbp-0A0],rax
       mov       rax,[rbp-98]
       mov       rcx,[rax+10]
       mov       rax,[rbp-98]
       mov       r8d,esi
       imul      r8,[rax+28]
       shr       r8,20
       inc       r8
       mov       r10d,[rcx+8]
       imul      r8,r10
       shr       r8,20
       mov       rax,[rbp-98]
       mov       r10,[rax+18]
       mov       eax,r8d
       xor       edx,edx
       div       dword ptr [r10+8]
       mov       [rbp-3C],edx
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L64
       mov       eax,r8d
       lea       rdi,[rcx+rax*8+10]
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       [rbp-44],ecx
       mov       [rbp-48],ecx
       jmp       near ptr M00_L39
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF7A9EA6A78]
       int       3
M00_L55:
       call      M00_L65
       jmp       near ptr M00_L13
M00_L56:
       mov       ecx,[rbp-40]
       or        ecx,[rbp-44]
       je        short M00_L57
       mov       rcx,[rbp-88]
       mov       rdx,[rbp-98]
       mov       r8d,[rbp-40]
       mov       r9d,[rbp-44]
       call      qword ptr [7FF7A9CD40F0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
M00_L57:
       mov       r8,[rbp-0A8]
       mov       [rbp-90],r8
       jmp       near ptr M00_L13
M00_L58:
       call      qword ptr [7FF7A9EAE778]
       int       3
M00_L59:
       mov       rcx,rsi
       mov       rdx,21AEBE0FFC0
       call      qword ptr [7FF7A99DD368]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       jmp       near ptr M00_L14
M00_L60:
       mov       rcx,21AEBE1BA90
       call      qword ptr [7FF7A9F84D68]
       mov       rbx,rax
       mov       rcx,[rbp-70]
       call      qword ptr [7FF7A97961D8]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L61
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L61
       jmp       short M00_L62
M00_L61:
       mov       rcx,rax
       call      qword ptr [7FF7A97956E0]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
M00_L62:
       mov       rsi,[rcx+30]
       test      rsi,rsi
       jne       short M00_L63
       lea       rdx,[rcx+30]
       mov       r8d,1
       call      qword ptr [7FF7A979CC60]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
M00_L63:
       mov       rcx,21AEBE12DD0
       test      rsi,rsi
       cmove     rsi,rcx
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rbx
       mov       rdx,21AEBE0FFC0
       mov       r8,rsi
       call      qword ptr [7FF7A9DBC468]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF7A9945FE0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp-48],0
       je        short M00_L68
       mov       rcx,[rbp-0A0]
       mov       ecx,[rcx+8]
       cmp       [rbp-3C],ecx
       jae       short M00_L66
       mov       rcx,[rbp-0A0]
       mov       eax,[rbp-3C]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       short M00_L67
       xor       ecx,ecx
       call      qword ptr [7FF7A9EA6A78]
       int       3
M00_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L67:
       mov       rcx,r14
       call      00007FF809262C80
       test      eax,eax
       je        short M00_L68
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF7A9EA73C0]
M00_L68:
       nop
       add       rsp,28
       ret
; Total bytes of code 2512
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpanAsObject(System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,268
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+38],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+220],xmm4
       vmovdqa   xmmword ptr [rbp+rax+230],xmm4
       vmovdqa   xmmword ptr [rbp+rax+240],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0E07513D61686
       mov       [rbp+8],rax
       mov       rbx,rdx
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       xor       ecx,ecx
       mov       [rbp+40],rcx
       cmp       edi,55
       jle       near ptr M01_L15
       cmp       edi,15555555
       jg        near ptr M01_L16
       mov       rcx,1DA57001E10
       mov       r14,[rcx]
       mov       r15,r14
       lea       r13d,[rdi+rdi*2]
       mov       rcx,1DA57000C90
       mov       r12,[rcx]
       lea       ecx,[r13-1]
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rbp+234],eax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M01_L17
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+50]
       test      rdx,rdx
       je        near ptr M01_L17
M01_L01:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       je        near ptr M01_L20
       mov       edx,[rcx+8]
       mov       eax,[rbp+234]
       cmp       edx,eax
       jbe       near ptr M01_L21
       mov       edx,eax
       shl       rdx,4
       mov       r8,[rcx+rdx+10]
       test      r8,r8
       je        near ptr M01_L19
       xor       r10d,r10d
       mov       [rcx+rdx+10],r10
       cmp       byte ptr [r12+9D],0
       jne       near ptr M01_L18
M01_L02:
       mov       [rbp+40],r8
M01_L03:
       test      r8,r8
       je        near ptr M01_L36
       lea       r14,[r8+10]
       mov       r15d,[r8+8]
M01_L04:
       mov       [rbp+10],r14
       mov       [rbp+7C],r15d
       mov       [rbp+68],rsi
       mov       [rbp+70],edi
       mov       [rbp+58],r14
       mov       [rbp+60],r15d
       lea       rcx,[rbp+68]
       lea       rdx,[rbp+58]
       call      qword ptr [7FF7A99DC210]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,r15d
       ja        near ptr M01_L07
       mov       [rbp+10],r14
       mov       [rbp+7C],eax
       mov       rdx,[rbx+0B8]
       movzx     ecx,byte ptr [rdx+94]
       movzx     r9d,byte ptr [rdx+92]
       cmp       r9d,2
       jg        near ptr M01_L08
       mov       edx,[rdx+88]
       test      edx,edx
       jl        near ptr M01_L09
       xor       r8d,r8d
       mov       [rbp+1E8],r8
       mov       [rbp+1F0],r8
       mov       byte ptr [rbp+1F8],0
       mov       byte ptr [rbp+1F9],0
       mov       byte ptr [rbp+1FA],0
       mov       byte ptr [rbp+1FB],0
       mov       byte ptr [rbp+1FC],0
       mov       byte ptr [rbp+1FD],0
       mov       [rbp+200],edx
       mov       [rbp+204],r9b
       mov       [rbp+205],cl
       mov       byte ptr [rbp+206],0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+208],xmm0
       vmovdqu   xmmword ptr [rbp+210],xmm0
       mov       [rbp+48],r14
       mov       [rbp+50],eax
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+128]
       lea       r9,[rbp+1E8]
       mov       r8d,1
       call      qword ptr [7FF7A9B456B0]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+88],ymm0
       vmovdqu   ymmword ptr [rbp+0A8],ymm0
       vmovdqu   ymmword ptr [rbp+0C8],ymm0
       vmovdqu   ymmword ptr [rbp+0E8],ymm0
       vmovdqu   ymmword ptr [rbp+108],ymm0
       mov       rcx,[rbx+0B8]
       cmp       dword ptr [rcx+8C],1
       je        near ptr M01_L10
M01_L05:
       mov       [rbp+0E0],rbx
       mov       r8,[rbx+0D0]
       mov       [rbp+0B8],r8
       mov       r8,[rbp+0B8]
       mov       r8,[r8+0C8]
       mov       [rbp+11C],r8
       cmp       byte ptr [rbp+0B1],0
       jne       near ptr M01_L12
       mov       r8,[rbx+0A0]
       test      r8,r8
       jne       near ptr M01_L11
       xor       edx,edx
M01_L06:
       mov       [rbp+113],dl
       mov       byte ptr [rbp+0B0],0
       lea       r8,[rbp+88]
       lea       rdx,[rbp+128]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       [rbp+38],rax
       jmp       short M01_L13
M01_L07:
       call      qword ptr [7FF7A979F228]
       int       3
M01_L08:
       mov       ecx,38A0
       mov       rdx,7FF7A9A12F00
       call      qword ptr [7FF7A95CF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9F848D0]
       int       3
M01_L09:
       mov       ecx,38A0
       mov       rdx,7FF7A9A12F00
       call      qword ptr [7FF7A95CF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9F848E8]
       int       3
M01_L10:
       mov       rcx,[rcx+38]
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rbp+90],rax
       mov       byte ptr [rbp+0B1],1
       jmp       near ptr M01_L05
M01_L11:
       movzx     edx,byte ptr [r8+34]
       jmp       near ptr M01_L06
M01_L12:
       mov       edx,1
       jmp       near ptr M01_L06
M01_L13:
       call      M01_L39
       nop
       mov       rax,[rbp+38]
       mov       r8,0E07513D61686
       cmp       [rbp+8],r8
       je        short M01_L14
       call      CORINFO_HELP_FAIL_FAST
M01_L14:
       nop
       lea       rsp,[rbp+238]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L15:
       test      [rsp],esp
       sub       rsp,100
       lea       r14,[rsp+30]
       mov       r15d,100
       jmp       near ptr M01_L04
M01_L16:
       mov       [rbp+68],rsi
       mov       [rbp+70],edi
       lea       rcx,[rbp+68]
       call      qword ptr [7FF7A99D7660]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       jmp       near ptr M01_L03
M01_L17:
       mov       ecx,0A
       call      qword ptr [7FF7A9EA7270]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L18:
       mov       [rbp+30],r8
       mov       rcx,r8
       call      qword ptr [7FF7A99DCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13,[rbp+30]
       mov       eax,[r13+8]
       mov       [rbp+224],eax
       mov       rcx,r14
       call      qword ptr [7FF7A99DCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r14d,[rbp+234]
       mov       [rsp+20],r14d
       mov       edx,r15d
       mov       r8d,[rbp+224]
       mov       rcx,r12
       call      qword ptr [7FF7A9DBD950]
       mov       r8,r13
       jmp       near ptr M01_L02
M01_L19:
       mov       eax,[rbp+234]
       jmp       short M01_L21
M01_L20:
       mov       eax,[rbp+234]
M01_L21:
       mov       rcx,[r15+10]
       cmp       [rcx+8],eax
       jbe       near ptr M01_L31
       mov       edx,eax
       mov       rcx,[rcx+rdx*8+10]
       test      rcx,rcx
       je        near ptr M01_L30
       mov       r13,[rcx+8]
       call      qword ptr [7FF7A9CDF210]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r14d,eax
       sub       r14d,ecx
       xor       eax,eax
       jmp       short M01_L25
M01_L22:
       cmp       r14d,[r13+8]
       jae       near ptr M01_L38
       mov       ecx,r14d
       mov       rdx,[r13+rcx*8+10]
       mov       [rbp+20],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rbp+28],r8
       mov       rcx,rdx
       call      qword ptr [7FF7A9ACDB48]; System.Threading.Monitor.Enter(System.Object)
       mov       rdx,[rbp+20]
       mov       rcx,[rdx+8]
       mov       eax,[rdx+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M01_L23
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
       mov       [rbp+28],r8
       mov       r10d,eax
       xor       r9d,r9d
       mov       [rcx+r10*8+10],r9
       mov       [rdx+10],eax
M01_L23:
       mov       rcx,rdx
       call      qword ptr [7FF7A95C6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+28]
       test      rcx,rcx
       jne       short M01_L26
       inc       r14d
       cmp       [r13+8],r14d
       jne       short M01_L24
       xor       r14d,r14d
M01_L24:
       mov       eax,[rbp+220]
       inc       eax
M01_L25:
       mov       [rbp+220],eax
       cmp       [r13+8],eax
       jg        near ptr M01_L22
       jmp       short M01_L27
M01_L26:
       mov       r13,rcx
       jmp       short M01_L28
M01_L27:
       xor       r13d,r13d
M01_L28:
       test      r13,r13
       je        short M01_L30
       cmp       byte ptr [r12+9D],0
       je        short M01_L29
       mov       rcx,r13
       call      qword ptr [7FF7A99DCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+228],eax
       mov       rcx,r15
       call      qword ptr [7FF7A99DCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rbp+234]
       mov       [rsp+20],r15d
       mov       edx,r14d
       mov       r8d,[rbp+228]
       mov       rcx,r12
       call      qword ptr [7FF7A9DBD950]
       mov       r8,r13
       jmp       near ptr M01_L02
M01_L29:
       mov       r8,r13
       jmp       near ptr M01_L02
M01_L30:
       mov       ecx,10
       mov       eax,[rbp+234]
       shlx      r13d,ecx,eax
       jmp       short M01_L33
M01_L31:
       test      r13d,r13d
       jne       short M01_L32
       mov       r8,21AEBE06D78
       jmp       near ptr M01_L02
M01_L32:
       mov       ecx,r13d
       mov       rdx,21AEBE06F28
       call      qword ptr [7FF7A985D8C0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M01_L33:
       cmp       r13d,800
       jge       short M01_L34
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M01_L35
M01_L34:
       mov       ecx,r13d
       xor       edx,edx
       call      qword ptr [7FF7A9C179D8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M01_L35:
       cmp       byte ptr [r12+9D],0
       je        near ptr M01_L37
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF7A99DCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+230],eax
       mov       rcx,r15
       call      qword ptr [7FF7A99DCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,[rbp+230]
       mov       rcx,r12
       call      qword ptr [7FF7A9DBD950]
       mov       eax,[r13+8]
       mov       [rbp+22C],eax
       mov       rcx,r15
       call      qword ptr [7FF7A99DCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[r15+10]
       mov       edx,1
       mov       r8d,2
       mov       r15d,[rbp+234]
       cmp       [rcx+8],r15d
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,r14d
       mov       r8d,[rbp+22C]
       call      qword ptr [7FF7A9DBD998]
       mov       r8,r13
       jmp       near ptr M01_L02
M01_L36:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L37:
       mov       r8,r13
       jmp       near ptr M01_L02
M01_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L39:
       sub       rsp,38
       cmp       qword ptr [rbp+40],0
       je        near ptr M01_L58
       mov       edx,[rbp+7C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF7A95C57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,1DA57001E10
       mov       rbx,[rcx]
       mov       rcx,[rbp+40]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       esi,esi
       lzcnt     esi,ecx
       xor       esi,1F
       add       esi,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       short M01_L40
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       jne       short M01_L41
M01_L40:
       mov       ecx,0A
       call      qword ptr [7FF7A9EA7270]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M01_L41:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M01_L42
       mov       rcx,rbx
       call      qword ptr [7FF7A9C1F918]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
M01_L42:
       xor       edi,edi
       mov       r14d,1
       mov       ecx,[rax+8]
       cmp       ecx,esi
       jbe       near ptr M01_L54
       mov       edi,1
       mov       rcx,[rbp+40]
       mov       edx,10
       shlx      edx,edx,esi
       cmp       [rcx+8],edx
       je        short M01_L43
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9DBDD40]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FF7A9504000
       call      qword ptr [7FF7A95CF228]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF7A9946088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L43:
       mov       ecx,esi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rdx,[rbp+40]
       mov       rcx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       je        near ptr M01_L54
       mov       rcx,[rbx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M01_L55
       mov       edx,esi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M01_L44
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF7A9F852C0]
M01_L44:
       mov       r14,[rax+8]
       call      qword ptr [7FF7A9CDF210]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       r12d,r12d
       jmp       near ptr M01_L51
M01_L45:
       cmp       r15d,[r14+8]
       jae       near ptr M01_L55
       mov       ecx,r15d
       mov       rax,[r14+rcx*8+10]
       mov       [rbp+18],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp+84],edx
       mov       rcx,rax
       call      qword ptr [7FF7A9ACDB48]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp+18]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp+80],r8d
       cmp       [rcx+8],r8d
       jbe       short M01_L47
       test      r8d,r8d
       jne       short M01_L48
       xor       edx,edx
       mov       [rax+14],edx
M01_L46:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp+80]
       inc       ecx
       mov       rax,[rbp+18]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+84],1
M01_L47:
       mov       rcx,rax
       call      qword ptr [7FF7A95C6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp+84],0
       je        short M01_L49
       jmp       short M01_L52
M01_L48:
       jmp       short M01_L46
M01_L49:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M01_L50
       xor       r15d,r15d
M01_L50:
       inc       r12d
M01_L51:
       cmp       [r14+8],r12d
       jg        near ptr M01_L45
       jmp       short M01_L53
M01_L52:
       mov       r14d,1
       jmp       short M01_L54
M01_L53:
       xor       r14d,r14d
M01_L54:
       mov       rcx,1DA57000C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       je        near ptr M01_L58
       mov       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L58
       mov       rcx,[rbp+40]
       call      qword ptr [7FF7A99DCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp+40]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF7A99DCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FF7A9EAF768]
       test      r14d,edi
       jne       short M01_L58
       mov       rcx,[rbp+40]
       call      qword ptr [7FF7A99DCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,[rbp+40]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF7A99DCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      edi,edi
       jne       short M01_L56
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M01_L57
M01_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L56:
       mov       ecx,esi
       xor       edx,edx
M01_L57:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,r13d
       call      qword ptr [7FF7A9DBDDB8]
M01_L58:
       nop
       add       rsp,38
       ret
; Total bytes of code 2450
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       rax,[rcx+0B8]
       cmp       qword ptr [rax+20],0
       je        near ptr M02_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       near ptr M02_L07
       mov       rbx,[rcx+0B8]
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M02_L08
M02_L00:
       mov       [rbp-20],rsi
       xor       eax,eax
       mov       [rbp-14],eax
       test      rsi,rsi
       je        short M02_L02
       mov       rcx,rsi
       call      00007FF809262D60
       test      eax,eax
       jne       short M02_L01
       mov       rcx,rsi
       call      qword ptr [7FF7A9EA77E0]
M02_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M02_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M02_L03
       mov       rcx,7FF7A9F44580
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF7A9AC6AC0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M02_L04
M02_L02:
       xor       ecx,ecx
       call      qword ptr [7FF7A9EA6A78]
       int       3
M02_L03:
       mov       rcx,7FF7A9F4457C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF7A9EAE778]
       int       3
M02_L04:
       mov       rcx,7FF7A9F44584
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FF809262C80
       test      eax,eax
       jne       near ptr M02_L10
M02_L05:
       mov       rcx,7FF7A9F44588
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF7A9F4458C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L06:
       call      qword ptr [7FF7A9EAED30]
       int       3
M02_L07:
       mov       rcx,7FF7A9F44578
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF7A9EAE778]
       int       3
M02_L08:
       mov       rcx,rbx
       call      qword ptr [7FF7A99DCDF8]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M02_L09
       call      qword ptr [7FF7A9EA6F88]
       int       3
M02_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF8091FCC60
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M02_L00
M02_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF7A9EA73C0]
       jmp       near ptr M02_L05
       sub       rsp,28
       call      qword ptr [7FF7A9EAED48]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M02_L12
       mov       rcx,7FF7A9F44584
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M02_L11
       xor       ecx,ecx
       call      qword ptr [7FF7A9EA6A78]
       int       3
M02_L11:
       mov       rcx,[rbp-20]
       call      00007FF809262C80
       test      eax,eax
       je        short M02_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF7A9EA73C0]
M02_L12:
       mov       rcx,7FF7A9F44588
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions..ctor()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       dword ptr [rbx+7C],4000
       call      qword ptr [7FF8127484D8]
       movzx     ecx,byte ptr [rax+1]
       mov       [rbx+95],cl
       movzx     eax,byte ptr [rax+2]
       mov       [rbx+96],al
       mov       word ptr [rbx+90],20
       mov       dword ptr [rbx+84],2
       mov       byte ptr [rbx+9D],1
       mov       dword ptr [rbx+88],40
       call      qword ptr [7FF812748550]
       mov       rcx,[rax]
       mov       rdx,rbx
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       xor       r8d,r8d
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [r11]
; Total bytes of code 109
```
```assembly
; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       sub       rsp,28
       cmp       byte ptr [rcx+9E],0
       jne       short M04_L01
       mov       rax,[rcx+58]
       test      rax,rax
       jne       short M04_L02
M04_L00:
       lea       rcx,[rcx+20]
       call      qword ptr [7FF812748278]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M04_L01:
       mov       rcx,[rcx+20]
       call      qword ptr [7FF81274A688]
       mov       rcx,rax
       call      qword ptr [7FF81274CE70]
       int       3
M04_L02:
       cmp       rax,rdx
       je        short M04_L00
       xor       r8d,r8d
       mov       [rax+10],r8
       mov       [rcx+58],r8
       jmp       short M04_L00
; Total bytes of code 76
```
```assembly
; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF81274E588]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF81274C548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       test      rax,rax
       cmove     rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7A99DD368]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M06_L00:
       mov       rcx,7FF7A9F77BCC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-20]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,7FF7A9F77BC8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A9EAED48]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF7A9F84150]
       mov       [rbp-20],rsi
       lea       rax,[M06_L00]
       add       rsp,28
       ret
; Total bytes of code 185
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
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M08_L00
       cmp       [rdx],rcx
       jne       short M08_L01
M08_L00:
       mov       rax,rdx
       ret
M08_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L00
M08_L02:
       test      rax,rax
       je        short M08_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L00
       test      rax,rax
       je        short M08_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L00
       test      rax,rax
       je        short M08_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L00
       test      rax,rax
       je        short M08_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L00
       jmp       short M08_L02
M08_L03:
       xor       edx,edx
       jmp       short M08_L00
; Total bytes of code 88
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
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
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       edi,r9d
       xor       eax,eax
       mov       [rbp-48],eax
       mov       rax,[rcx+8]
       mov       rax,[rax+18]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M09_L15
       mov       rcx,[rax+10]
       call      qword ptr [7FF83A9FAB70]; Precode of System.Threading.Monitor.Enter(System.Object)
       mov       dword ptr [rbp-48],1
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+8]
       jne       near ptr M09_L17
       mov       rax,[rbx+10]
       mov       r14d,[rax+8]
       xor       r15d,r15d
       test      dil,dil
       je        short M09_L01
       mov       rcx,[rbx+8]
       call      qword ptr [7FF83A9FAA38]
       mov       rdi,rax
       test      rdi,rdi
       je        short M09_L01
       mov       rcx,[rbp+10]
       mov       r13,[rcx]
       mov       rcx,r13
       call      qword ptr [7FF83A9FA3B0]
       mov       r15,rax
       mov       rcx,rdi
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       call      qword ptr [r11]
       mov       r8,rax
       test      r8,r8
       je        short M09_L00
       mov       rcx,r15
       cmp       [r8],rcx
       je        short M09_L00
       mov       rdx,rax
       call      qword ptr [7FF83A9FA290]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
       mov       r8,r15
M09_L00:
       mov       r15,r8
M09_L01:
       test      sil,sil
       je        short M09_L04
       test      r15,r15
       jne       short M09_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FF83A9FB158]
       mov       rcx,[rbx+10]
       mov       ecx,[rcx+8]
       shr       ecx,2
       cmp       eax,ecx
       jl        near ptr M09_L14
M09_L02:
       mov       rax,[rbx+10]
       mov       eax,[rax+8]
       add       eax,eax
       js        short M09_L03
       mov       ecx,eax
       call      qword ptr [7FF83A9FAE98]; Precode of System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       call      qword ptr [7FF83A9FAA68]; Precode of System.Array.get_MaxLength()
       cmp       eax,r14d
       jge       short M09_L04
M09_L03:
       call      qword ptr [7FF83A9FAA68]; Precode of System.Array.get_MaxLength()
       mov       r14d,eax
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+10],7FFFFFFF
M09_L04:
       mov       rsi,[rbx+18]
       mov       rdi,rsi
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+18],0
       je        short M09_L06
       cmp       dword ptr [rsi+8],400
       jge       short M09_L06
       mov       eax,[rsi+8]
       add       eax,eax
       movsxd    rcx,eax
       call      qword ptr [7FF83A9FAA20]
       mov       rdi,rax
       mov       r8d,[rsi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF83A9FAA50]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,[rbx+18]
       mov       esi,[rax+8]
       mov       r13d,[rdi+8]
       cmp       r13d,esi
       jle       short M09_L06
M09_L05:
       call      qword ptr [7FF83A9FA988]
       mov       r8,rax
       movsxd    rdx,esi
       mov       rcx,rdi
       call      qword ptr [7FF83A9FA270]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       esi
       cmp       r13d,esi
       jg        short M09_L05
M09_L06:
       mov       rcx,[rbp+10]
       mov       r13,[rcx]
       mov       rcx,r13
       call      qword ptr [7FF83A9FA600]
       mov       rcx,rax
       movsxd    rdx,r14d
       call      qword ptr [7FF83A9FA288]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       ecx,[rdi+8]
       call      qword ptr [7FF83A9FAA28]
       mov       r14,rax
       mov       r12,r15
       test      r12,r12
       jne       short M09_L07
       mov       r12,[rbx+8]
M09_L07:
       mov       rcx,r13
       call      qword ptr [7FF83A9FA450]
       mov       rcx,rax
       call      qword ptr [7FF83A9FA280]; CORINFO_HELP_NEWFAST
       mov       [rbp-78],rax
       lea       rcx,[rax+10]
       mov       rdx,rsi
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+18]
       mov       rdx,rdi
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+20]
       mov       rdx,r14
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rsi+8]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       r12,[rbp-78]
       mov       [r12+28],rax
       mov       rcx,r13
       call      qword ptr [7FF83A9FA418]
       mov       rcx,rax
       lea       r8,[rbp-48]
       mov       rdx,rbx
       call      qword ptr [7FF83A9FB178]
       mov       rbx,[rbx+10]
       xor       eax,eax
       jmp       near ptr M09_L13
M09_L08:
       mov       [rbp-58],rax
       mov       rdx,[rbx+rax*8+10]
       test      rdx,rdx
       je        near ptr M09_L12
M09_L09:
       test      r15,r15
       jne       short M09_L10
       mov       [rbp-68],rdx
       mov       r8d,[rdx+20]
       jmp       short M09_L11
M09_L10:
       mov       [rbp-68],rdx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       call      qword ptr [7FF83A9FA740]
       mov       r8,[rbp-68]
       mov       rdx,[r8+8]
       mov       rcx,r15
       mov       r11,rax
       call      qword ptr [rax]
       mov       r8d,eax
M09_L11:
       mov       r10,[rbp-68]
       mov       r9,[r10+18]
       mov       [rbp-80],r9
       mov       rcx,[r12+10]
       mov       [rbp-4C],r8d
       mov       r11d,r8d
       imul      r11,[r12+28]
       shr       r11,20
       inc       r11
       mov       edx,[rcx+8]
       mov       [rbp-50],edx
       mov       eax,edx
       imul      r11,rax
       shr       r11,20
       mov       rsi,[r12+18]
       mov       eax,r11d
       xor       edx,edx
       div       dword ptr [rsi+8]
       mov       esi,edx
       cmp       r11d,[rbp-50]
       jae       near ptr M09_L15
       mov       eax,r11d
       lea       rax,[rcx+rax*8+10]
       mov       [rbp-70],rax
       mov       rcx,r13
       call      qword ptr [7FF83A9FA438]
       mov       rcx,rax
       call      qword ptr [7FF83A9FA280]; CORINFO_HELP_NEWFAST
       mov       [rbp-88],rax
       mov       r8,[rbp-68]
       mov       rdx,[r8+8]
       mov       r8,[r8+10]
       mov       [rbp-90],r8
       mov       r10,[rbp-70]
       mov       r9,[r10]
       mov       [rbp-98],r9
       lea       rcx,[rax+8]
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-90]
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       lea       rcx,[rax+18]
       mov       rdx,[rbp-98]
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       mov       ecx,[rbp-4C]
       mov       [rax+20],ecx
       mov       rcx,[rbp-70]
       mov       rdx,rax
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       cmp       esi,[r14+8]
       jae       short M09_L15
       mov       eax,esi
       lea       rax,[r14+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        short M09_L16
       mov       [rax],edx
       mov       rsi,[rbp-80]
       test      rsi,rsi
       mov       rdx,rsi
       jne       near ptr M09_L09
M09_L12:
       mov       rsi,[rbp-58]
       inc       esi
       mov       rax,rsi
M09_L13:
       mov       ecx,[rbx+8]
       cmp       ecx,eax
       jg        near ptr M09_L08
       mov       rsi,[rbp-60]
       mov       eax,[rsi+8]
       xor       edx,edx
       div       dword ptr [rdi+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp+10]
       mov       [rax+10],ecx
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L17
M09_L14:
       mov       rcx,[rbp+10]
       mov       edx,[rcx+10]
       add       edx,edx
       mov       [rcx+10],edx
       test      edx,edx
       jge       short M09_L17
       mov       dword ptr [rcx+10],7FFFFFFF
       jmp       short M09_L17
M09_L15:
       call      qword ptr [7FF83A9FA250]
       int       3
M09_L16:
       call      qword ptr [7FF83A9FA248]
       int       3
M09_L17:
       mov       rcx,[rbp+10]
       mov       edx,[rbp-48]
       call      qword ptr [7FF83A9FB188]
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
       sub       rsp,28
       mov       rcx,[rbp+10]
       mov       edx,[rbp-48]
       call      qword ptr [7FF83A9FB188]
       nop
       add       rsp,28
       ret
; Total bytes of code 1103
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rbx+60]
       test      rdi,rdi
       jne       short M10_L00
       mov       rcx,7FF7A9F77C30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbx+20]
M10_L00:
       test      rdi,rdi
       je        short M10_L02
       mov       rcx,rdi
       mov       rdx,7FF7A9F77C38
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rdi
       mov       r8,rbx
       mov       rdx,rsi
       mov       r11,7FF7A9510EB8
       call      qword ptr [r11]
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M10_L06
       mov       rcx,[rbp+0C0]
       mov       rdx,rsi
       call      qword ptr [7FF7A979CC30]; System.Type.op_Equality(System.Type, System.Type)
       test      eax,eax
       je        short M10_L03
       cmp       [rbp+0B8],rbx
       jne       short M10_L04
M10_L01:
       mov       rcx,7FF7A9F77D50
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L02:
       mov       rcx,7FF7A9F77C34
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L03:
       mov       rcx,7FF7A9F77D40
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp+0C0]
       mov       rcx,rsi
       call      qword ptr [7FF7A9F84168]
       int       3
M10_L04:
       mov       rcx,7FF7A9F77D44
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF7A9F84180]
       int       3
M10_L05:
       mov       rcx,7FF7A9F77D48
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L01
M10_L06:
       mov       rcx,21AEBE027E0
       cmp       rsi,rcx
       jne       short M10_L05
       mov       rcx,7FF7A9F77D4C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SlimObjectConverter
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF7A99DE1F0]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       byte ptr [rbp+12],1
       lea       rcx,[rbp+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8,rbx
       call      qword ptr [7FF7A9AC5AA0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Text.Json.Serialization.JsonConverter, System.Text.Json.JsonSerializerOptions)
       mov       rbp,rsi
       jmp       near ptr M10_L01
; Total bytes of code 366
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
       je        short M11_L01
M11_L00:
       add       rsp,20
       pop       rbx
       ret
M11_L01:
       call      qword ptr [7FF7A95C5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M11_L00
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
       je        near ptr M12_L08
M12_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M12_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M12_L09
M12_L01:
       test      rdi,rdi
       jne       near ptr M12_L07
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
       call      00007FF8091FFE50
       mov       r14,rax
       test      r14,r14
       je        near ptr M12_L10
M12_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M12_L05
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
       mov       rax,7FF7A97B8C30
       mov       [rbp-78],rax
       lea       rax,[M12_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF8091A5A20
       call      rax
M12_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF809513A10],0
       je        short M12_L04
       call      qword ptr [7FF809501648]; CORINFO_HELP_STOP_FOR_GC
M12_L04:
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
M12_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF80921C1F0
       mov       rdx,rax
       test      rdx,rdx
       je        short M12_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M12_L11
M12_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M12_L07:
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
M12_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF7A9F873F0]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M12_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF7A9EAC438]
       jmp       near ptr M12_L00
M12_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M12_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF7A9795728]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M12_L02
M12_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       [rbp+18],rdx
       mov       rbx,rcx
       mov       edi,r8d
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r14,rax
       mov       rcx,rsp
       mov       [rbp-68],rcx
       mov       rcx,rbp
       mov       [rbp-58],rcx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M13_L03
       mov       [rbp-48],rcx
       mov       rcx,[rbp-48]
       test      rcx,rcx
       je        near ptr M13_L04
       mov       rcx,[rcx+18]
M13_L00:
       lea       rdx,[rbp-48]
       mov       [rbp-90],rdx
       mov       [rbp-88],rcx
       lea       rcx,[rbp-90]
       mov       edx,edi
       lea       r8,[rbp-40]
       mov       rax,7FF7A96062A8
       mov       [rbp-70],rax
       lea       rax,[M13_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FF80914C260
       call      rax
M13_L01:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FF809513A10],0
       je        short M13_L02
       call      qword ptr [7FF809501648]; CORINFO_HELP_STOP_FOR_GC
M13_L02:
       mov       rcx,[rbp-78]
       mov       [r14+8],rcx
       mov       rbx,[rbp-40]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rbx
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
M13_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9EA7630]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF7A9EA6508]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M13_L04:
       xor       ecx,ecx
       jmp       near ptr M13_L00
; Total bytes of code 312
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_PersonRecord()
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
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+138]
       test      rsi,rsi
       je        near ptr M00_L09
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L09
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M00_L11
       mov       rax,7FFFFDF96090
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L13
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L12
       mov       rax,7FFFFDF96090
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L13
M00_L01:
       test      rsi,rsi
       je        near ptr M00_L14
       mov       rcx,25A5C401DE0
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+9F],0
       je        near ptr M00_L15
M00_L02:
       mov       rbp,[rdi+10]
       test      rbp,rbp
       je        short M00_L03
       mov       rcx,[rbp+0C0]
       mov       rax,29AF1551118
       cmp       rcx,rax
       je        short M00_L06
M00_L03:
       xor       ebp,ebp
       cmp       byte ptr [rdi+9E],0
       je        short M00_L05
       mov       rcx,[rdi+8]
       test      rcx,rcx
       je        near ptr M00_L16
M00_L04:
       cmp       [rcx],cl
       mov       rdx,29AF1551118
       call      qword ptr [7FF7A99FD2F0]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       near ptr M00_L17
       mov       rbp,[rax+8]
       test      rbp,rbp
       je        short M00_L05
       cmp       byte ptr [rbp+119],2
       jne       near ptr M00_L18
M00_L05:
       test      rbp,rbp
       je        near ptr M00_L08
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L06:
       mov       r8,rbp
       test      r8,r8
       je        short M00_L07
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r8],rcx
       jne       near ptr M00_L19
M00_L07:
       lea       rdx,[rsi+0C]
       mov       ecx,[rsi+8]
       mov       [rsp+28],rdx
       mov       [rsp+30],ecx
       lea       rdx,[rsp+28]
       mov       rcx,7FF7A9DB9568
       call      qword ptr [7FF7A9D5F618]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       test      rax,rax
       je        near ptr M00_L20
       mov       [rsp+38],rax
       mov       rbp,[rbx+60]
       mov       rdx,[rsp+38]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp+8],rcx
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       mov       rdx,[rdi+20]
       mov       rcx,29AF1551118
       call      qword ptr [7FF7A9ED43F0]
       int       3
M00_L09:
       call      qword ptr [7FF7A99F4378]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L10
       call      qword ptr [7FF7A9D5FD50]
       mov       rbx,rax
M00_L10:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,29AF155B4E8
       call      qword ptr [7FF7A9D5FD68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       call      qword ptr [7FF7A9CE5D88]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M00_L13
       jmp       near ptr M00_L00
M00_L12:
       call      qword ptr [7FF7A9CE5D88]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       je        near ptr M00_L01
M00_L13:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FF7A9ED4210]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L14:
       mov       ecx,3888
       mov       rdx,7FF7A9A344B8
       call      qword ptr [7FF7A98077B0]
       mov       rcx,rax
       call      qword ptr [7FF7A9DCE7D8]
       int       3
M00_L15:
       mov       rcx,rdi
       call      qword ptr [7FF7A99F75A0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L02
M00_L16:
       mov       rcx,rdi
       call      qword ptr [7FF7A99FCDC8]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rcx,rax
       jmp       near ptr M00_L04
M00_L17:
       call      qword ptr [7FF7A9ED43D8]
       int       3
M00_L18:
       mov       rcx,rbp
       call      qword ptr [7FF7A9AF6AA8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L05
M00_L19:
       mov       rdx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L20:
       lea       rcx,[rsp+40]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FF7A9804E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+50]
       cmp       ecx,[rsp+60]
       ja        near ptr M00_L23
       mov       rdx,[rsp+58]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+60]
       sub       eax,ecx
       cmp       eax,29
       jb        short M00_L21
       vmovups   ymm0,[7FF7A9E692A0]
       vmovups   [rdx],ymm0
       vmovups   ymm0,[7FF7A9E692C0]
       vmovups   [rdx+20],ymm0
       vmovups   xmm0,[7FF7A9E692E0]
       vmovups   [rdx+40],xmm0
       mov       word ptr [rdx+50],20
       mov       ecx,[rsp+50]
       add       ecx,29
       mov       [rsp+50],ecx
       jmp       short M00_L22
M00_L21:
       lea       rcx,[rsp+40]
       mov       rdx,29AF155BB98
       call      qword ptr [7FF7A9D5CEA0]
M00_L22:
       lea       rcx,[rsp+40]
       mov       rdx,7FF7A9CDA148
       mov       r8,29AF1551118
       call      qword ptr [7FF7A980E1A8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ecx,[rsp+50]
       cmp       ecx,[rsp+60]
       jbe       short M00_L24
M00_L23:
       call      qword ptr [7FF7A9757198]
       int       3
M00_L24:
       mov       rdx,[rsp+58]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+60]
       sub       eax,ecx
       je        short M00_L25
       mov       word ptr [rdx],2E
       mov       ecx,[rsp+50]
       inc       ecx
       mov       [rsp+50],ecx
       jmp       short M00_L26
M00_L25:
       lea       rcx,[rsp+40]
       mov       rdx,29AF1540658
       call      qword ptr [7FF7A9D5CEA0]
M00_L26:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rsp+40]
       call      qword ptr [7FF7A9804EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF7A9965FE0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 948
```
```assembly
; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rbx+8]
       call      qword ptr [7FF812748540]
       mov       rbp,[rax]
       test      rbp,rbp
       je        short M01_L01
M01_L00:
       mov       rcx,rdi
       call      qword ptr [7FF8127484C0]
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,rbp
       mov       r9,rbx
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M01_L01:
       call      qword ptr [7FF81274A0D0]
       mov       rbp,rax
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FF81274ACF8]
       call      qword ptr [7FF812748540]
       mov       rcx,rax
       mov       rdx,rbp
       call      qword ptr [7FF812748278]; CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L00
; Total bytes of code 106
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,268
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax+220],xmm4
       vmovdqa   xmmword ptr [rbp+rax+230],xmm4
       vmovdqa   xmmword ptr [rbp+rax+240],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rax,0D6100FB7AE4
       mov       [rbp],rax
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp+38],rcx
       cmp       edi,55
       jle       near ptr M02_L15
       cmp       edi,15555555
       jg        near ptr M02_L16
       mov       rcx,25A5C401DE8
       mov       r14,[rcx]
       mov       r15,r14
       lea       r13d,[rdi+rdi*2]
       mov       rcx,25A5C400C90
       mov       r12,[rcx]
       lea       ecx,[r13-1]
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rbp+234],eax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M02_L17
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+50]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L01:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       je        near ptr M02_L20
       mov       edx,[rcx+8]
       mov       eax,[rbp+234]
       cmp       edx,eax
       jbe       near ptr M02_L21
       mov       edx,eax
       shl       rdx,4
       mov       r8,[rcx+rdx+10]
       test      r8,r8
       je        near ptr M02_L19
       xor       r10d,r10d
       mov       [rcx+rdx+10],r10
       cmp       byte ptr [r12+9D],0
       jne       near ptr M02_L18
M02_L02:
       mov       [rbp+38],r8
M02_L03:
       test      r8,r8
       je        near ptr M02_L36
       lea       r14,[r8+10]
       mov       r15d,[r8+8]
M02_L04:
       mov       [rbp+8],r14
       mov       [rbp+74],r15d
       mov       [rbp+60],rsi
       mov       [rbp+68],edi
       mov       [rbp+50],r14
       mov       [rbp+58],r15d
       lea       rcx,[rbp+60]
       lea       rdx,[rbp+50]
       call      qword ptr [7FF7A99FC210]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,r15d
       ja        near ptr M02_L07
       mov       [rbp+8],r14
       mov       [rbp+74],eax
       mov       rdx,[rbx+0B8]
       movzx     ecx,byte ptr [rdx+94]
       movzx     r9d,byte ptr [rdx+92]
       cmp       r9d,2
       jg        near ptr M02_L08
       mov       edx,[rdx+88]
       test      edx,edx
       jl        near ptr M02_L09
       xor       r8d,r8d
       mov       [rbp+1E8],r8
       mov       [rbp+1F0],r8
       mov       byte ptr [rbp+1F8],0
       mov       byte ptr [rbp+1F9],0
       mov       byte ptr [rbp+1FA],0
       mov       byte ptr [rbp+1FB],0
       mov       byte ptr [rbp+1FC],0
       mov       byte ptr [rbp+1FD],0
       mov       [rbp+200],edx
       mov       [rbp+204],r9b
       mov       [rbp+205],cl
       mov       byte ptr [rbp+206],0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+208],xmm0
       vmovdqu   xmmword ptr [rbp+210],xmm0
       mov       [rbp+40],r14
       mov       [rbp+48],eax
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+128]
       lea       r9,[rbp+1E8]
       mov       r8d,1
       call      qword ptr [7FF7A9B656B0]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+88],ymm0
       vmovdqu   ymmword ptr [rbp+0A8],ymm0
       vmovdqu   ymmword ptr [rbp+0C8],ymm0
       vmovdqu   ymmword ptr [rbp+0E8],ymm0
       vmovdqu   ymmword ptr [rbp+108],ymm0
       mov       rcx,[rbx+0B8]
       cmp       dword ptr [rcx+8C],1
       je        near ptr M02_L10
M02_L05:
       mov       [rbp+0E0],rbx
       mov       rcx,[rbx+0D0]
       mov       [rbp+0B8],rcx
       mov       rcx,[rbp+0B8]
       mov       rcx,[rcx+0C8]
       mov       [rbp+11C],rcx
       cmp       byte ptr [rbp+0B1],0
       jne       near ptr M02_L12
       mov       rcx,[rbx+0A0]
       test      rcx,rcx
       jne       near ptr M02_L11
       xor       r9d,r9d
M02_L06:
       mov       [rbp+113],r9b
       mov       byte ptr [rbp+0B0],0
       lea       rcx,[rbp+88]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+158]
       mov       r9,[rbx+0B8]
       lea       r8,[rbp+80]
       lea       rdx,[rbp+128]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9B65740]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rax,[rbp+80]
       xor       ecx,ecx
       mov       [rbp+80],rcx
       mov       [rbp+30],rax
       jmp       near ptr M02_L13
M02_L07:
       call      qword ptr [7FF7A9757198]
       int       3
M02_L08:
       mov       ecx,38A0
       mov       rdx,7FF7A9A344B8
       call      qword ptr [7FF7A98077B0]
       mov       rcx,rax
       call      qword ptr [7FF7A9ED46C0]
       int       3
M02_L09:
       mov       ecx,38A0
       mov       rdx,7FF7A9A344B8
       call      qword ptr [7FF7A98077B0]
       mov       rcx,rax
       call      qword ptr [7FF7A9ED46D8]
       int       3
M02_L10:
       mov       rcx,[rcx+38]
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rbp+90],rax
       mov       byte ptr [rbp+0B1],1
       jmp       near ptr M02_L05
M02_L11:
       movzx     r9d,byte ptr [rcx+34]
       jmp       near ptr M02_L06
M02_L12:
       mov       r9d,1
       jmp       near ptr M02_L06
M02_L13:
       call      M02_L39
       nop
       mov       rax,[rbp+30]
       mov       r8,0D6100FB7AE4
       cmp       [rbp],r8
       je        short M02_L14
       call      CORINFO_HELP_FAIL_FAST
M02_L14:
       nop
       lea       rsp,[rbp+238]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L15:
       test      [rsp],esp
       sub       rsp,100
       lea       r14,[rsp+30]
       mov       r15d,100
       jmp       near ptr M02_L04
M02_L16:
       mov       [rbp+60],rsi
       mov       [rbp+68],edi
       lea       rcx,[rbp+60]
       call      qword ptr [7FF7A99F7660]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       jmp       near ptr M02_L03
M02_L17:
       mov       ecx,0A
       call      qword ptr [7FF7A9ED4750]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M02_L01
M02_L18:
       mov       [rbp+28],r8
       mov       rcx,r8
       call      qword ptr [7FF7A99FCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13,[rbp+28]
       mov       eax,[r13+8]
       mov       [rbp+224],eax
       mov       rcx,r14
       call      qword ptr [7FF7A99FCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r14d,[rbp+234]
       mov       [rsp+20],r14d
       mov       edx,r15d
       mov       r8d,[rbp+224]
       mov       rcx,r12
       call      qword ptr [7FF7A9D5FAF8]
       mov       r8,r13
       jmp       near ptr M02_L02
M02_L19:
       mov       eax,[rbp+234]
       jmp       short M02_L21
M02_L20:
       mov       eax,[rbp+234]
M02_L21:
       mov       rcx,[r15+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L31
       mov       edx,eax
       mov       rcx,[rcx+rdx*8+10]
       test      rcx,rcx
       je        near ptr M02_L30
       mov       r13,[rcx+8]
       call      qword ptr [7FF7A9CE7450]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r14d,eax
       sub       r14d,ecx
       xor       eax,eax
       jmp       short M02_L25
M02_L22:
       cmp       r14d,[r13+8]
       jae       near ptr M02_L38
       mov       ecx,r14d
       mov       rdx,[r13+rcx*8+10]
       mov       [rbp+18],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rbp+20],r8
       mov       rcx,rdx
       call      qword ptr [7FF7A9AFDB48]; System.Threading.Monitor.Enter(System.Object)
       mov       rdx,[rbp+18]
       mov       rcx,[rdx+8]
       mov       eax,[rdx+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M02_L23
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
       mov       [rbp+20],r8
       mov       r10d,eax
       xor       r9d,r9d
       mov       [rcx+r10*8+10],r9
       mov       [rdx+10],eax
M02_L23:
       mov       rcx,rdx
       call      qword ptr [7FF7A95E6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+20]
       test      rcx,rcx
       jne       short M02_L26
       inc       r14d
       cmp       [r13+8],r14d
       jne       short M02_L24
       xor       r14d,r14d
M02_L24:
       mov       eax,[rbp+220]
       inc       eax
M02_L25:
       mov       [rbp+220],eax
       cmp       [r13+8],eax
       jg        near ptr M02_L22
       jmp       short M02_L27
M02_L26:
       mov       r13,rcx
       jmp       short M02_L28
M02_L27:
       xor       r13d,r13d
M02_L28:
       test      r13,r13
       je        short M02_L30
       cmp       byte ptr [r12+9D],0
       je        short M02_L29
       mov       rcx,r13
       call      qword ptr [7FF7A99FCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+228],eax
       mov       rcx,r15
       call      qword ptr [7FF7A99FCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rbp+234]
       mov       [rsp+20],r15d
       mov       edx,r14d
       mov       r8d,[rbp+228]
       mov       rcx,r12
       call      qword ptr [7FF7A9D5FAF8]
       mov       r8,r13
       jmp       near ptr M02_L02
M02_L29:
       mov       r8,r13
       jmp       near ptr M02_L02
M02_L30:
       mov       ecx,10
       mov       eax,[rbp+234]
       shlx      r13d,ecx,eax
       jmp       short M02_L33
M02_L31:
       test      r13d,r13d
       jne       short M02_L32
       mov       r8,29AF15462A0
       jmp       near ptr M02_L02
M02_L32:
       mov       ecx,r13d
       mov       rdx,29AF1546F28
       call      qword ptr [7FF7A980D8C0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M02_L33:
       cmp       r13d,800
       jge       short M02_L34
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M02_L35
M02_L34:
       mov       ecx,r13d
       xor       edx,edx
       call      qword ptr [7FF7A9B6FD68]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M02_L35:
       cmp       byte ptr [r12+9D],0
       je        near ptr M02_L37
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF7A99FCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+230],eax
       mov       rcx,r15
       call      qword ptr [7FF7A99FCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,[rbp+230]
       mov       rcx,r12
       call      qword ptr [7FF7A9D5FAF8]
       mov       eax,[r13+8]
       mov       [rbp+22C],eax
       mov       rcx,r15
       call      qword ptr [7FF7A99FCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[r15+10]
       mov       edx,1
       mov       r8d,2
       mov       r15d,[rbp+234]
       cmp       [rcx+8],r15d
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,r14d
       mov       r8d,[rbp+22C]
       call      qword ptr [7FF7A9D5FB40]
       mov       r8,r13
       jmp       near ptr M02_L02
M02_L36:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L37:
       mov       r8,r13
       jmp       near ptr M02_L02
M02_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L39:
       sub       rsp,38
       cmp       qword ptr [rbp+38],0
       je        near ptr M02_L58
       mov       edx,[rbp+74]
       mov       rcx,[rbp+8]
       call      qword ptr [7FF7A95E57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,25A5C401DE8
       mov       rbx,[rcx]
       mov       rcx,[rbp+38]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       esi,esi
       lzcnt     esi,ecx
       xor       esi,1F
       add       esi,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0A
       jle       short M02_L40
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       jne       short M02_L41
M02_L40:
       mov       ecx,0A
       call      qword ptr [7FF7A9ED4750]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M02_L41:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L42
       mov       rcx,rbx
       call      qword ptr [7FF7A9C57CA8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
M02_L42:
       xor       edi,edi
       mov       r14d,1
       mov       ecx,[rax+8]
       cmp       ecx,esi
       jbe       near ptr M02_L54
       mov       edi,1
       mov       rcx,[rbp+38]
       mov       edx,10
       shlx      edx,edx,esi
       cmp       [rcx+8],edx
       je        short M02_L43
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9D5FF00]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FF7A9524000
       call      qword ptr [7FF7A98077B0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF7A9966088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L43:
       mov       ecx,esi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rdx,[rbp+38]
       mov       rcx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       je        near ptr M02_L54
       mov       rcx,[rbx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M02_L55
       mov       edx,esi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M02_L44
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF7A9ED5320]
M02_L44:
       mov       r14,[rax+8]
       call      qword ptr [7FF7A9CE7450]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       r12d,r12d
       jmp       near ptr M02_L51
M02_L45:
       cmp       r15d,[r14+8]
       jae       near ptr M02_L55
       mov       ecx,r15d
       mov       rax,[r14+rcx*8+10]
       mov       [rbp+10],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp+7C],edx
       mov       rcx,rax
       call      qword ptr [7FF7A9AFDB48]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp+78],r8d
       cmp       [rcx+8],r8d
       jbe       short M02_L47
       test      r8d,r8d
       jne       short M02_L48
       xor       edx,edx
       mov       [rax+14],edx
M02_L46:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp+78]
       inc       ecx
       mov       rax,[rbp+10]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+7C],1
M02_L47:
       mov       rcx,rax
       call      qword ptr [7FF7A95E6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp+7C],0
       je        short M02_L49
       jmp       short M02_L52
M02_L48:
       jmp       short M02_L46
M02_L49:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M02_L50
       xor       r15d,r15d
M02_L50:
       inc       r12d
M02_L51:
       cmp       [r14+8],r12d
       jg        near ptr M02_L45
       jmp       short M02_L53
M02_L52:
       mov       r14d,1
       jmp       short M02_L54
M02_L53:
       xor       r14d,r14d
M02_L54:
       mov       rcx,25A5C400C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       je        near ptr M02_L58
       mov       rcx,[rbp+38]
       cmp       dword ptr [rcx+8],0
       je        near ptr M02_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FF7A99FCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp+38]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF7A99FCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FF7A9DCE838]
       test      r14d,edi
       jne       short M02_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FF7A99FCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,[rbp+38]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF7A99FCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      edi,edi
       jne       short M02_L56
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M02_L57
M02_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L56:
       mov       ecx,esi
       xor       edx,edx
M02_L57:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,r13d
       call      qword ptr [7FF7A9D5FF78]
M02_L58:
       nop
       add       rsp,38
       ret
; Total bytes of code 2477
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       mov       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       movzx     ecx,cx
       mov       edx,ecx
       shr       edx,9
       movzx     eax,byte ptr [rax+rdx]
       mov       rdx,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       shl       eax,6
       mov       r8d,ecx
       shr       r8d,3
       and       r8d,3E
       add       eax,r8d
       movzx     eax,word ptr [rdx+rax]
       mov       rdx,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       shl       eax,4
       and       ecx,0F
       add       eax,ecx
       movzx     eax,byte ptr [rdx+rax]
       mov       rcx,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       ret
; Total bytes of code 84
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xorps     xmm4,xmm4
       movaps    [rsp+20],xmm4
       movaps    [rsp+30],xmm4
       mov       rbx,rcx
       call      qword ptr [7FF8127484E0]
       cmp       byte ptr [rax],0
       je        near ptr M04_L03
       call      qword ptr [7FF81274EBE8]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M04_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FF812748278]; CORINFO_HELP_ASSIGN_REF
M04_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       call      qword ptr [7FF81274A688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M04_L00
       call      qword ptr [7FF8127484D8]
       cmp       byte ptr [rax],0
       je        short M04_L00
       xorps     xmm0,xmm0
       movups    [rsp+30],xmm0
       mov       [rsp+30],rdi
       mov       [rsp+38],rsi
       lea       rcx,[rsp+20]
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       lea       r8,[rsp+30]
       mov       r9d,2
       call      qword ptr [7FF8127502E8]
       lea       rcx,[rsp+20]
       call      qword ptr [7FF81274EC18]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FF812748278]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M04_L00
       cmp       [rsi+10],rbx
       je        short M04_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+9F],0
       jne       short M04_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF81274E4E0]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M04_L00
M04_L02:
       mov       rcx,[rsi+8]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M04_L00
M04_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L04
       call      qword ptr [7FF81274A6A0]
       test      rax,rax
       je        near ptr M04_L00
M04_L04:
       call      qword ptr [7FF81274CE58]
       int       3
; Total bytes of code 284
```
```assembly
; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF81274E588]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF81274C548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       test      rax,rax
       cmove     rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       rax,[rcx+0B8]
       cmp       qword ptr [rax+20],0
       je        near ptr M06_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       near ptr M06_L07
M06_L00:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+0B8]
       mov       rbx,[rax+8]
       test      rbx,rbx
       je        near ptr M06_L08
M06_L01:
       mov       [rbp-18],rbx
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,rbx
       call      qword ptr [7FF81274B180]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M06_L04
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       short M06_L03
M06_L02:
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF81274EEF8]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M06_L04
M06_L03:
       mov       rcx,rax
       call      qword ptr [7FF81274B218]
       jmp       short M06_L02
M06_L04:
       cmp       byte ptr [rbp-10],0
       je        short M06_L05
       mov       rcx,rbx
       call      qword ptr [7FF81274B188]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
M06_L06:
       call      qword ptr [7FF81274CE50]
       int       3
M06_L07:
       mov       rcx,rax
       call      qword ptr [7FF81274B218]
       jmp       near ptr M06_L00
M06_L08:
       mov       rcx,rax
       call      qword ptr [7FF81274E530]; Precode of System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M06_L01
       sub       rsp,28
       call      qword ptr [7FF81274B210]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      qword ptr [7FF812748278]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      qword ptr [7FF812748258]; CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-10],0
       je        short M06_L09
       mov       rcx,[rbp-18]
       call      qword ptr [7FF81274B188]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 310
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M07_L00
       cmp       [rdx],rcx
       jne       short M07_L01
M07_L00:
       mov       rax,rdx
       ret
M07_L01:
       jmp       qword ptr [7FF7A95EFD20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       xor       eax,eax
       mov       [rbx],rax
       call      qword ptr [7FFFFEC05098]
       mov       rcx,[rax]
       imul      edx,edi,0B
       add       edx,esi
       mov       eax,100
       cmp       edx,100
       cmovle    edx,eax
       cmp       [rcx],ecx
       call      qword ptr [7FFFFEC24888]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbx+8],rax
       test      rax,rax
       je        short M08_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M08_L00:
       mov       [rbx+18],rcx
       mov       [rbx+20],eax
       xor       eax,eax
       mov       [rbx+10],eax
       mov       byte ptr [rbx+14],0
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M08_L00
; Total bytes of code 102
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       xorps     xmm4,xmm4
       movaps    [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       [rsp+50],rdx
       mov       rbx,rcx
       mov       rcx,rdx
       mov       rsi,r8
       cmp       byte ptr [rbx+14],0
       jne       near ptr M09_L06
       test      rsi,rsi
       je        near ptr M09_L01
       mov       rcx,rsi
       call      qword ptr [7FFFFEC12150]
       test      rax,rax
       je        near ptr M09_L04
       mov       rcx,rsi
       call      qword ptr [7FFFFEC12188]
       test      rax,rax
       je        near ptr M09_L02
       mov       rcx,rsi
       call      qword ptr [7FFFFEC133C8]
       mov       rsi,rax
M09_L00:
       mov       rcx,rsi
       lea       rdx,[rbx+18]
       mov       r9d,[rbx+10]
       mov       r8d,[rdx+8]
       cmp       r9d,r8d
       ja        near ptr M09_L08
       mov       rdx,[rdx]
       mov       r11d,r9d
       lea       rdx,[rdx+r11*2]
       sub       r8d,r9d
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       xor       edx,edx
       mov       [rsp+28],rdx
       mov       [rsp+30],edx
       mov       rdx,[rbx]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+38]
       lea       r9,[rsp+28]
       lea       r8,[rsp+48]
       lea       r11,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M09_L07
       mov       ecx,[rsp+48]
       add       [rbx+10],ecx
M09_L01:
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M09_L02:
       mov       rcx,rsi
       call      qword ptr [7FFFFEC133C0]
       mov       rcx,rax
       mov       r8,[rbx]
       lea       r11,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
M09_L03:
       test      rdx,rdx
       je        short M09_L01
       lea       rcx,[rbx+18]
       mov       eax,[rbx+10]
       mov       r8d,[rcx+8]
       cmp       eax,r8d
       ja        short M09_L08
       mov       rcx,[rcx]
       mov       r10d,eax
       lea       rcx,[rcx+r10*2]
       sub       r8d,eax
       mov       esi,[rdx+8]
       cmp       esi,r8d
       ja        short M09_L05
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       call      qword ptr [7FFFFEC188E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       jmp       short M09_L01
M09_L04:
       mov       rcx,rsi
       lea       r11,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M09_L03
M09_L05:
       mov       rcx,rbx
       call      qword ptr [7FFFFEC1FFB0]
       jmp       near ptr M09_L01
M09_L06:
       call      qword ptr [7FFFFEC0B0F8]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFFFEC2F660]
       jmp       near ptr M09_L01
M09_L07:
       mov       rcx,rbx
       call      qword ptr [7FFFFEC1FFD8]
       jmp       near ptr M09_L00
M09_L08:
       call      qword ptr [7FFFFEC1A278]
       int       3
; Total bytes of code 395
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       lea       rsi,[rbx+18]
       mov       rcx,rsi
       mov       eax,[rbx+10]
       cmp       eax,[rcx+8]
       ja        short M10_L01
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       [rsp+30],eax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFFFEC16B10]; Precode of System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rbp,[rbx+8]
       xor       eax,eax
       mov       [rbx+8],rax
       mov       [rsi],rax
       mov       [rsi+8],rax
       mov       [rbx+10],eax
       test      rbp,rbp
       je        short M10_L00
       call      qword ptr [7FFFFEC05098]
       mov       rcx,[rax]
       mov       rdx,rbp
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFFFEC24890]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M10_L00:
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L01:
       call      qword ptr [7FFFFEC1A278]
       int       3
; Total bytes of code 126
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_Person_List()
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
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+148]
       test      rsi,rsi
       je        near ptr M00_L09
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L09
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M00_L11
       mov       rax,7FFFFDF96090
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L13
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L12
       mov       rax,7FFFFDF96090
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L13
M00_L01:
       test      rsi,rsi
       je        near ptr M00_L14
       mov       rcx,29E83401E08
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+9F],0
       je        near ptr M00_L15
M00_L02:
       mov       rbp,[rdi+10]
       test      rbp,rbp
       je        short M00_L03
       mov       rcx,[rbp+0C0]
       mov       rax,2DF184BA820
       cmp       rcx,rax
       je        short M00_L06
M00_L03:
       xor       ebp,ebp
       cmp       byte ptr [rdi+9E],0
       je        short M00_L05
       mov       rcx,[rdi+8]
       test      rcx,rcx
       je        near ptr M00_L16
M00_L04:
       cmp       [rcx],cl
       mov       rdx,2DF184BA820
       call      qword ptr [7FF7A99BD2F0]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       near ptr M00_L17
       mov       rbp,[rax+8]
       test      rbp,rbp
       je        short M00_L05
       cmp       byte ptr [rbp+119],2
       jne       near ptr M00_L18
M00_L05:
       test      rbp,rbp
       je        near ptr M00_L08
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L06:
       mov       r8,rbp
       test      r8,r8
       je        short M00_L07
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       cmp       [r8],rcx
       jne       near ptr M00_L19
M00_L07:
       lea       rdx,[rsi+0C]
       mov       ecx,[rsi+8]
       mov       [rsp+28],rdx
       mov       [rsp+30],ecx
       lea       rdx,[rsp+28]
       mov       rcx,7FF7A9DD0260
       call      qword ptr [7FF7A9D97318]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       test      rax,rax
       je        near ptr M00_L20
       mov       [rsp+38],rax
       mov       rbp,[rbx+60]
       mov       rdx,[rsp+38]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp+8],rcx
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       mov       rdx,[rdi+20]
       mov       rcx,2DF184BA820
       call      qword ptr [7FF7A9E9C030]
       int       3
M00_L09:
       call      qword ptr [7FF7A99B4378]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L10
       call      qword ptr [7FF7A9D97A20]
       mov       rbx,rax
M00_L10:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2DF184BB4E8
       call      qword ptr [7FF7A9D97A38]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       call      qword ptr [7FF7A9CBDB78]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M00_L13
       jmp       near ptr M00_L00
M00_L12:
       call      qword ptr [7FF7A9CBDB78]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       je        near ptr M00_L01
M00_L13:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FF7A9E94DE0]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L14:
       mov       ecx,3888
       mov       rdx,7FF7A99F44B8
       call      qword ptr [7FF7A97C77B0]
       mov       rcx,rax
       call      qword ptr [7FF7A9E948A0]
       int       3
M00_L15:
       mov       rcx,rdi
       call      qword ptr [7FF7A99B75A0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L02
M00_L16:
       mov       rcx,rdi
       call      qword ptr [7FF7A99BCDC8]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rcx,rax
       jmp       near ptr M00_L04
M00_L17:
       call      qword ptr [7FF7A9E9C588]
       int       3
M00_L18:
       mov       rcx,rbp
       call      qword ptr [7FF7A9AB6AA8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L05
M00_L19:
       mov       rdx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L20:
       lea       rcx,[rsp+40]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FF7A97C4E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+50]
       cmp       ecx,[rsp+60]
       ja        near ptr M00_L23
       mov       rdx,[rsp+58]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+60]
       sub       eax,ecx
       cmp       eax,29
       jb        short M00_L21
       vmovups   ymm0,[7FF7A9E83A20]
       vmovups   [rdx],ymm0
       vmovups   ymm0,[7FF7A9E83A40]
       vmovups   [rdx+20],ymm0
       vmovups   xmm0,[7FF7A9E83A60]
       vmovups   [rdx+40],xmm0
       mov       word ptr [rdx+50],20
       mov       ecx,[rsp+50]
       add       ecx,29
       mov       [rsp+50],ecx
       jmp       short M00_L22
M00_L21:
       lea       rcx,[rsp+40]
       mov       rdx,2DF184BB9B0
       call      qword ptr [7FF7A9D94BD0]
M00_L22:
       lea       rcx,[rsp+40]
       mov       rdx,7FF7A9CF0620
       mov       r8,2DF184BA820
       call      qword ptr [7FF7A97CE1A8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ecx,[rsp+50]
       cmp       ecx,[rsp+60]
       jbe       short M00_L24
M00_L23:
       call      qword ptr [7FF7A9717198]
       int       3
M00_L24:
       mov       rdx,[rsp+58]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+60]
       sub       eax,ecx
       je        short M00_L25
       mov       word ptr [rdx],2E
       mov       ecx,[rsp+50]
       inc       ecx
       mov       [rsp+50],ecx
       jmp       short M00_L26
M00_L25:
       lea       rcx,[rsp+40]
       mov       rdx,2DF184A0658
       call      qword ptr [7FF7A9D94BD0]
M00_L26:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rsp+40]
       call      qword ptr [7FF7A97C4EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF7A9925FE0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 948
```
```assembly
; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+8]
       mov       rcx,29E83401968
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L04
M01_L00:
       mov       rcx,7FF7A9F15964
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       [rdi],dil
       test      rbx,rbx
       je        near ptr M01_L05
       mov       r15,[rdi+8]
       mov       rcx,[r15+8]
       cmp       byte ptr [rdi+19],0
       jne       near ptr M01_L03
       mov       rdx,rbx
       mov       r11,7FF7A94F0E38
       call      qword ptr [r11]
       mov       r13d,eax
M01_L01:
       lea       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rbx
       mov       r9d,r13d
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      qword ptr [7FF7A9926670]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       jne       short M01_L02
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-38]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,r13d
       shl       r9,20
       or        r9,1
       mov       rdx,r15
       mov       r8,rbx
       mov       rcx,rdi
       call      qword ptr [7FF7A992C528]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
M01_L02:
       mov       rax,[rbp-38]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M01_L01
M01_L04:
       mov       rcx,7FF7A9F15960
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FF7A94ED050
       call      qword ptr [7FF7A95A6E98]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,29E83401968
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,1
       mov       rdx,7FF7A987F5A8
       call      qword ptr [7FF7A97C77B0]
       mov       rcx,rax
       call      qword ptr [7FF7A9AB6820]
       int       3
; Total bytes of code 390
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,268
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax+220],xmm4
       vmovdqa   xmmword ptr [rbp+rax+230],xmm4
       vmovdqa   xmmword ptr [rbp+rax+240],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rax,657AA78A0E9E
       mov       [rbp],rax
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp+38],rcx
       cmp       edi,55
       jle       near ptr M02_L15
       cmp       edi,15555555
       jg        near ptr M02_L16
       mov       rcx,29E83401E10
       mov       r14,[rcx]
       mov       r15,r14
       lea       r13d,[rdi+rdi*2]
       mov       rcx,29E83400C90
       mov       r12,[rcx]
       lea       ecx,[r13-1]
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rbp+234],eax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M02_L17
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+50]
       test      rdx,rdx
       je        near ptr M02_L17
M02_L01:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       je        near ptr M02_L20
       mov       edx,[rcx+8]
       mov       eax,[rbp+234]
       cmp       edx,eax
       jbe       near ptr M02_L21
       mov       edx,eax
       shl       rdx,4
       mov       r8,[rcx+rdx+10]
       test      r8,r8
       je        near ptr M02_L19
       xor       r10d,r10d
       mov       [rcx+rdx+10],r10
       cmp       byte ptr [r12+9D],0
       jne       near ptr M02_L18
M02_L02:
       mov       [rbp+38],r8
M02_L03:
       test      r8,r8
       je        near ptr M02_L36
       lea       r14,[r8+10]
       mov       r15d,[r8+8]
M02_L04:
       mov       [rbp+8],r14
       mov       [rbp+74],r15d
       mov       [rbp+60],rsi
       mov       [rbp+68],edi
       mov       [rbp+50],r14
       mov       [rbp+58],r15d
       lea       rcx,[rbp+60]
       lea       rdx,[rbp+50]
       call      qword ptr [7FF7A99BC210]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,r15d
       ja        near ptr M02_L07
       mov       [rbp+8],r14
       mov       [rbp+74],eax
       mov       rdx,[rbx+0B8]
       movzx     ecx,byte ptr [rdx+94]
       movzx     r9d,byte ptr [rdx+92]
       cmp       r9d,2
       jg        near ptr M02_L08
       mov       edx,[rdx+88]
       test      edx,edx
       jl        near ptr M02_L09
       xor       r8d,r8d
       mov       [rbp+1E8],r8
       mov       [rbp+1F0],r8
       mov       byte ptr [rbp+1F8],0
       mov       byte ptr [rbp+1F9],0
       mov       byte ptr [rbp+1FA],0
       mov       byte ptr [rbp+1FB],0
       mov       byte ptr [rbp+1FC],0
       mov       byte ptr [rbp+1FD],0
       mov       [rbp+200],edx
       mov       [rbp+204],r9b
       mov       [rbp+205],cl
       mov       byte ptr [rbp+206],0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+208],xmm0
       vmovdqu   xmmword ptr [rbp+210],xmm0
       mov       [rbp+40],r14
       mov       [rbp+48],eax
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+128]
       lea       r9,[rbp+1E8]
       mov       r8d,1
       call      qword ptr [7FF7A9B256B0]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+88],ymm0
       vmovdqu   ymmword ptr [rbp+0A8],ymm0
       vmovdqu   ymmword ptr [rbp+0C8],ymm0
       vmovdqu   ymmword ptr [rbp+0E8],ymm0
       vmovdqu   ymmword ptr [rbp+108],ymm0
       mov       rcx,[rbx+0B8]
       cmp       dword ptr [rcx+8C],1
       je        near ptr M02_L10
M02_L05:
       mov       [rbp+0E0],rbx
       mov       rcx,[rbx+0D0]
       mov       [rbp+0B8],rcx
       mov       rcx,[rbp+0B8]
       mov       rcx,[rcx+0C8]
       mov       [rbp+11C],rcx
       cmp       byte ptr [rbp+0B1],0
       jne       near ptr M02_L12
       mov       rcx,[rbx+0A0]
       test      rcx,rcx
       jne       near ptr M02_L11
       xor       r9d,r9d
M02_L06:
       mov       [rbp+113],r9b
       mov       byte ptr [rbp+0B0],0
       lea       rcx,[rbp+88]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+158]
       mov       r9,[rbx+0B8]
       lea       r8,[rbp+80]
       lea       rdx,[rbp+128]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9B25740]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rax,[rbp+80]
       xor       ecx,ecx
       mov       [rbp+80],rcx
       mov       [rbp+30],rax
       jmp       near ptr M02_L13
M02_L07:
       call      qword ptr [7FF7A9717198]
       int       3
M02_L08:
       mov       ecx,38A0
       mov       rdx,7FF7A99F44B8
       call      qword ptr [7FF7A97C77B0]
       mov       rcx,rax
       call      qword ptr [7FF7A9E9EAC0]
       int       3
M02_L09:
       mov       ecx,38A0
       mov       rdx,7FF7A99F44B8
       call      qword ptr [7FF7A97C77B0]
       mov       rcx,rax
       call      qword ptr [7FF7A9E9EAD8]
       int       3
M02_L10:
       mov       rcx,[rcx+38]
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rbp+90],rax
       mov       byte ptr [rbp+0B1],1
       jmp       near ptr M02_L05
M02_L11:
       movzx     r9d,byte ptr [rcx+34]
       jmp       near ptr M02_L06
M02_L12:
       mov       r9d,1
       jmp       near ptr M02_L06
M02_L13:
       call      M02_L39
       nop
       mov       rax,[rbp+30]
       mov       r8,657AA78A0E9E
       cmp       [rbp],r8
       je        short M02_L14
       call      CORINFO_HELP_FAIL_FAST
M02_L14:
       nop
       lea       rsp,[rbp+238]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L15:
       test      [rsp],esp
       sub       rsp,100
       lea       r14,[rsp+30]
       mov       r15d,100
       jmp       near ptr M02_L04
M02_L16:
       mov       [rbp+60],rsi
       mov       [rbp+68],edi
       lea       rcx,[rbp+60]
       call      qword ptr [7FF7A99B7660]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       jmp       near ptr M02_L03
M02_L17:
       mov       ecx,0A
       call      qword ptr [7FF7A9E95098]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M02_L01
M02_L18:
       mov       [rbp+28],r8
       mov       rcx,r8
       call      qword ptr [7FF7A99BCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13,[rbp+28]
       mov       eax,[r13+8]
       mov       [rbp+224],eax
       mov       rcx,r14
       call      qword ptr [7FF7A99BCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r14d,[rbp+234]
       mov       [rsp+20],r14d
       mov       edx,r15d
       mov       r8d,[rbp+224]
       mov       rcx,r12
       call      qword ptr [7FF7A9D977F8]
       mov       r8,r13
       jmp       near ptr M02_L02
M02_L19:
       mov       eax,[rbp+234]
       jmp       short M02_L21
M02_L20:
       mov       eax,[rbp+234]
M02_L21:
       mov       rcx,[r15+10]
       cmp       [rcx+8],eax
       jbe       near ptr M02_L31
       mov       edx,eax
       mov       rcx,[rcx+rdx*8+10]
       test      rcx,rcx
       je        near ptr M02_L30
       mov       r13,[rcx+8]
       call      qword ptr [7FF7A9CBF240]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r14d,eax
       sub       r14d,ecx
       xor       eax,eax
       jmp       short M02_L25
M02_L22:
       cmp       r14d,[r13+8]
       jae       near ptr M02_L38
       mov       ecx,r14d
       mov       rdx,[r13+rcx*8+10]
       mov       [rbp+18],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rbp+20],r8
       mov       rcx,rdx
       call      qword ptr [7FF7A9ABDB48]; System.Threading.Monitor.Enter(System.Object)
       mov       rdx,[rbp+18]
       mov       rcx,[rdx+8]
       mov       eax,[rdx+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M02_L23
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
       mov       [rbp+20],r8
       mov       r10d,eax
       xor       r9d,r9d
       mov       [rcx+r10*8+10],r9
       mov       [rdx+10],eax
M02_L23:
       mov       rcx,rdx
       call      qword ptr [7FF7A95A6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+20]
       test      rcx,rcx
       jne       short M02_L26
       inc       r14d
       cmp       [r13+8],r14d
       jne       short M02_L24
       xor       r14d,r14d
M02_L24:
       mov       eax,[rbp+220]
       inc       eax
M02_L25:
       mov       [rbp+220],eax
       cmp       [r13+8],eax
       jg        near ptr M02_L22
       jmp       short M02_L27
M02_L26:
       mov       r13,rcx
       jmp       short M02_L28
M02_L27:
       xor       r13d,r13d
M02_L28:
       test      r13,r13
       je        short M02_L30
       cmp       byte ptr [r12+9D],0
       je        short M02_L29
       mov       rcx,r13
       call      qword ptr [7FF7A99BCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+228],eax
       mov       rcx,r15
       call      qword ptr [7FF7A99BCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rbp+234]
       mov       [rsp+20],r15d
       mov       edx,r14d
       mov       r8d,[rbp+228]
       mov       rcx,r12
       call      qword ptr [7FF7A9D977F8]
       mov       r8,r13
       jmp       near ptr M02_L02
M02_L29:
       mov       r8,r13
       jmp       near ptr M02_L02
M02_L30:
       mov       ecx,10
       mov       eax,[rbp+234]
       shlx      r13d,ecx,eax
       jmp       short M02_L33
M02_L31:
       test      r13d,r13d
       jne       short M02_L32
       mov       r8,2DF184A62A0
       jmp       near ptr M02_L02
M02_L32:
       mov       ecx,r13d
       mov       rdx,2DF184A6F28
       call      qword ptr [7FF7A97CD8C0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M02_L33:
       cmp       r13d,800
       jge       short M02_L34
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M02_L35
M02_L34:
       mov       ecx,r13d
       xor       edx,edx
       call      qword ptr [7FF7A9BF7A38]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M02_L35:
       cmp       byte ptr [r12+9D],0
       je        near ptr M02_L37
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF7A99BCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+230],eax
       mov       rcx,r15
       call      qword ptr [7FF7A99BCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,[rbp+230]
       mov       rcx,r12
       call      qword ptr [7FF7A9D977F8]
       mov       eax,[r13+8]
       mov       [rbp+22C],eax
       mov       rcx,r15
       call      qword ptr [7FF7A99BCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[r15+10]
       mov       edx,1
       mov       r8d,2
       mov       r15d,[rbp+234]
       cmp       [rcx+8],r15d
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,r14d
       mov       r8d,[rbp+22C]
       call      qword ptr [7FF7A9D97840]
       mov       r8,r13
       jmp       near ptr M02_L02
M02_L36:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L37:
       mov       r8,r13
       jmp       near ptr M02_L02
M02_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L39:
       sub       rsp,38
       cmp       qword ptr [rbp+38],0
       je        near ptr M02_L58
       mov       edx,[rbp+74]
       mov       rcx,[rbp+8]
       call      qword ptr [7FF7A95A57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,29E83401E10
       mov       rbx,[rcx]
       mov       rcx,[rbp+38]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       esi,esi
       lzcnt     esi,ecx
       xor       esi,1F
       add       esi,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       short M02_L40
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       jne       short M02_L41
M02_L40:
       mov       ecx,0A
       call      qword ptr [7FF7A9E95098]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M02_L41:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L42
       mov       rcx,rbx
       call      qword ptr [7FF7A9BFFA98]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
M02_L42:
       xor       edi,edi
       mov       r14d,1
       mov       ecx,[rax+8]
       cmp       ecx,esi
       jbe       near ptr M02_L54
       mov       edi,1
       mov       rcx,[rbp+38]
       mov       edx,10
       shlx      edx,edx,esi
       cmp       [rcx+8],edx
       je        short M02_L43
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9D97BD0]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FF7A94E4000
       call      qword ptr [7FF7A97C77B0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF7A9926088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L43:
       mov       ecx,esi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rdx,[rbp+38]
       mov       rcx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       je        near ptr M02_L54
       mov       rcx,[rbx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M02_L55
       mov       edx,esi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M02_L44
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF7A9E9F4C8]
M02_L44:
       mov       r14,[rax+8]
       call      qword ptr [7FF7A9CBF240]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       r12d,r12d
       jmp       near ptr M02_L51
M02_L45:
       cmp       r15d,[r14+8]
       jae       near ptr M02_L55
       mov       ecx,r15d
       mov       rax,[r14+rcx*8+10]
       mov       [rbp+10],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp+7C],edx
       mov       rcx,rax
       call      qword ptr [7FF7A9ABDB48]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp+78],r8d
       cmp       [rcx+8],r8d
       jbe       short M02_L47
       test      r8d,r8d
       jne       short M02_L48
       xor       edx,edx
       mov       [rax+14],edx
M02_L46:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp+78]
       inc       ecx
       mov       rax,[rbp+10]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+7C],1
M02_L47:
       mov       rcx,rax
       call      qword ptr [7FF7A95A6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp+7C],0
       je        short M02_L49
       jmp       short M02_L52
M02_L48:
       jmp       short M02_L46
M02_L49:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M02_L50
       xor       r15d,r15d
M02_L50:
       inc       r12d
M02_L51:
       cmp       [r14+8],r12d
       jg        near ptr M02_L45
       jmp       short M02_L53
M02_L52:
       mov       r14d,1
       jmp       short M02_L54
M02_L53:
       xor       r14d,r14d
M02_L54:
       mov       rcx,29E83400C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       je        near ptr M02_L58
       mov       rcx,[rbp+38]
       cmp       dword ptr [rcx+8],0
       je        near ptr M02_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FF7A99BCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp+38]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF7A99BCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FF7A9E9D590]
       test      r14d,edi
       jne       short M02_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FF7A99BCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,[rbp+38]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF7A99BCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      edi,edi
       jne       short M02_L56
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M02_L57
M02_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L56:
       mov       ecx,esi
       xor       edx,edx
M02_L57:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,r13d
       call      qword ptr [7FF7A9D97C48]
M02_L58:
       nop
       add       rsp,38
       ret
; Total bytes of code 2477
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       mov       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       movzx     ecx,cx
       mov       edx,ecx
       shr       edx,9
       movzx     eax,byte ptr [rax+rdx]
       mov       rdx,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       shl       eax,6
       mov       r8d,ecx
       shr       r8d,3
       and       r8d,3E
       add       eax,r8d
       movzx     eax,word ptr [rdx+rax]
       mov       rdx,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       shl       eax,4
       and       ecx,0F
       add       eax,ecx
       movzx     eax,byte ptr [rdx+rax]
       mov       rcx,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       ret
; Total bytes of code 84
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xorps     xmm4,xmm4
       movaps    [rsp+20],xmm4
       movaps    [rsp+30],xmm4
       mov       rbx,rcx
       call      qword ptr [7FF8127484E0]
       cmp       byte ptr [rax],0
       je        near ptr M04_L03
       call      qword ptr [7FF81274EBE8]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M04_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FF812748278]; CORINFO_HELP_ASSIGN_REF
M04_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       call      qword ptr [7FF81274A688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M04_L00
       call      qword ptr [7FF8127484D8]
       cmp       byte ptr [rax],0
       je        short M04_L00
       xorps     xmm0,xmm0
       movups    [rsp+30],xmm0
       mov       [rsp+30],rdi
       mov       [rsp+38],rsi
       lea       rcx,[rsp+20]
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       lea       r8,[rsp+30]
       mov       r9d,2
       call      qword ptr [7FF8127502E8]
       lea       rcx,[rsp+20]
       call      qword ptr [7FF81274EC18]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FF812748278]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M04_L00
       cmp       [rsi+10],rbx
       je        short M04_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+9F],0
       jne       short M04_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF81274E4E0]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M04_L00
M04_L02:
       mov       rcx,[rsi+8]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M04_L00
M04_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L04
       call      qword ptr [7FF81274A6A0]
       test      rax,rax
       je        near ptr M04_L00
M04_L04:
       call      qword ptr [7FF81274CE58]
       int       3
; Total bytes of code 284
```
```assembly
; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF81274E588]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF81274C548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       test      rax,rax
       cmove     rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       rax,[rcx+0B8]
       cmp       qword ptr [rax+20],0
       je        near ptr M06_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       near ptr M06_L07
       mov       rbx,[rcx+0B8]
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M06_L08
M06_L00:
       mov       [rbp-20],rsi
       xor       eax,eax
       mov       [rbp-14],eax
       test      rsi,rsi
       je        short M06_L02
       mov       rcx,rsi
       call      00007FF809262D60
       test      eax,eax
       jne       short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FF7A9E95608]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M06_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M06_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M06_L03
       mov       rcx,7FF7A9F1D9C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF7A9AB6AC0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M06_L04
M06_L02:
       xor       ecx,ecx
       call      qword ptr [7FF7A9E948A0]
       int       3
M06_L03:
       mov       rcx,7FF7A9F1D9BC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF7A9E9C588]
       int       3
M06_L04:
       mov       rcx,7FF7A9F1D9C4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FF809262C80
       test      eax,eax
       jne       near ptr M06_L10
M06_L05:
       mov       rcx,7FF7A9F1D9C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF7A9F1D9CC
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L06:
       call      qword ptr [7FF7A9E9CB58]
       int       3
M06_L07:
       mov       rcx,7FF7A9F1D9B8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF7A9E9C588]
       int       3
M06_L08:
       mov       rcx,rbx
       call      qword ptr [7FF7A99BCDF8]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M06_L09
       call      qword ptr [7FF7A9E94DB0]
       int       3
M06_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF8091FCC60
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M06_L00
M06_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF7A9E951E8]
       jmp       near ptr M06_L05
       sub       rsp,28
       call      qword ptr [7FF7A9E9CB70]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M06_L12
       mov       rcx,7FF7A9F1D9C4
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M06_L11
       xor       ecx,ecx
       call      qword ptr [7FF7A9E948A0]
       int       3
M06_L11:
       mov       rcx,[rbp-20]
       call      00007FF809262C80
       test      eax,eax
       je        short M06_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF7A9E951E8]
M06_L12:
       mov       rcx,7FF7A9F1D9C8
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 535
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M07_L00
       cmp       [rdx],rcx
       jne       short M07_L01
M07_L00:
       mov       rax,rdx
       ret
M07_L01:
       jmp       qword ptr [7FF7A95AFD20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       ecx,ecx
       mov       [rbx],rcx
       mov       rcx,29E83400C88
       mov       rsi,[rcx]
       imul      ecx,r8d,0B
       add       ecx,edx
       mov       edi,100
       cmp       ecx,100
       cmovg     edi,ecx
       mov       rcx,rsi
       mov       rdx,7FF7A9F2E988
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rsi
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbx+8],rax
       test      rax,rax
       je        short M08_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M08_L00:
       mov       [rbx+18],rcx
       mov       [rbx+20],eax
       xor       eax,eax
       mov       [rbx+10],eax
       mov       byte ptr [rbx+14],0
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M08_L00
; Total bytes of code 127
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       xorps     xmm4,xmm4
       movaps    [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       [rsp+50],rdx
       mov       rbx,rcx
       mov       rcx,rdx
       mov       rsi,r8
       cmp       byte ptr [rbx+14],0
       jne       near ptr M09_L06
       test      rsi,rsi
       je        near ptr M09_L01
       mov       rcx,rsi
       call      qword ptr [7FFFFEC12150]
       test      rax,rax
       je        near ptr M09_L04
       mov       rcx,rsi
       call      qword ptr [7FFFFEC12188]
       test      rax,rax
       je        near ptr M09_L02
       mov       rcx,rsi
       call      qword ptr [7FFFFEC133C8]
       mov       rsi,rax
M09_L00:
       mov       rcx,rsi
       lea       rdx,[rbx+18]
       mov       r9d,[rbx+10]
       mov       r8d,[rdx+8]
       cmp       r9d,r8d
       ja        near ptr M09_L08
       mov       rdx,[rdx]
       mov       r11d,r9d
       lea       rdx,[rdx+r11*2]
       sub       r8d,r9d
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       xor       edx,edx
       mov       [rsp+28],rdx
       mov       [rsp+30],edx
       mov       rdx,[rbx]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+38]
       lea       r9,[rsp+28]
       lea       r8,[rsp+48]
       lea       r11,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M09_L07
       mov       ecx,[rsp+48]
       add       [rbx+10],ecx
M09_L01:
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M09_L02:
       mov       rcx,rsi
       call      qword ptr [7FFFFEC133C0]
       mov       rcx,rax
       mov       r8,[rbx]
       lea       r11,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
M09_L03:
       test      rdx,rdx
       je        short M09_L01
       lea       rcx,[rbx+18]
       mov       eax,[rbx+10]
       mov       r8d,[rcx+8]
       cmp       eax,r8d
       ja        short M09_L08
       mov       rcx,[rcx]
       mov       r10d,eax
       lea       rcx,[rcx+r10*2]
       sub       r8d,eax
       mov       esi,[rdx+8]
       cmp       esi,r8d
       ja        short M09_L05
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       call      qword ptr [7FFFFEC188E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       jmp       short M09_L01
M09_L04:
       mov       rcx,rsi
       lea       r11,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M09_L03
M09_L05:
       mov       rcx,rbx
       call      qword ptr [7FFFFEC1FFB0]
       jmp       near ptr M09_L01
M09_L06:
       call      qword ptr [7FFFFEC0B0F8]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFFFEC2F660]
       jmp       near ptr M09_L01
M09_L07:
       mov       rcx,rbx
       call      qword ptr [7FFFFEC1FFD8]
       jmp       near ptr M09_L00
M09_L08:
       call      qword ptr [7FFFFEC1A278]
       int       3
; Total bytes of code 395
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rbx,rcx
       lea       rcx,[rbx+18]
       mov       eax,[rbx+10]
       cmp       eax,[rcx+8]
       ja        near ptr M10_L13
       mov       rcx,[rcx]
       mov       [rsp+48],rcx
       mov       [rsp+50],eax
       lea       rcx,[rsp+48]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rsi,rax
       mov       rdi,[rbx+8]
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       [rbx+18],rcx
       mov       [rbx+20],rcx
       mov       [rbx+10],ecx
       test      rdi,rdi
       je        near ptr M10_L03
       mov       rcx,29E83400C88
       mov       rbx,[rcx]
       mov       ecx,[rdi+8]
       dec       ecx
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M10_L14
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M10_L14
M10_L00:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M10_L15
M10_L01:
       xor       r14d,r14d
       mov       r15d,1
       mov       ecx,[rax+8]
       cmp       ecx,ebp
       jbe       short M10_L02
       mov       r14d,1
       mov       ecx,10
       shlx      ecx,ecx,ebp
       cmp       [rdi+8],ecx
       jne       near ptr M10_L16
       mov       ecx,ebp
       shl       rcx,4
       lea       r13,[rax+rcx+10]
       mov       r12,[r13]
       mov       rcx,r13
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],ecx
       test      r12,r12
       jne       short M10_L04
M10_L02:
       mov       rcx,29E83400C90
       mov       r13,[rcx]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M10_L22
M10_L03:
       mov       rax,rsi
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
M10_L04:
       mov       rcx,[rbx+10]
       cmp       ebp,[rcx+8]
       jae       near ptr M10_L25
       mov       edx,ebp
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       je        near ptr M10_L17
M10_L05:
       mov       r15,[rax+8]
       call      qword ptr [7FF7A9CBF240]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r13d,eax
       sub       r13d,ecx
       mov       eax,[r15+8]
       mov       [rsp+44],eax
       test      eax,eax
       jle       near ptr M10_L21
       mov       [rsp+40],eax
M10_L06:
       cmp       r13d,eax
       jae       near ptr M10_L25
       mov       ecx,r13d
       mov       r8,[r15+rcx*8+10]
       mov       [rsp+38],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rsp+60],r10d
       mov       rcx,r8
       call      00007FF809262D60
       test      eax,eax
       jne       short M10_L07
       mov       rcx,[rsp+38]
       call      qword ptr [7FF7A9E95608]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M10_L07:
       mov       rax,[rsp+38]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+5C],r8d
       cmp       [rcx+8],r8d
       jbe       short M10_L09
       test      r8d,r8d
       je        short M10_L12
M10_L08:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+5C]
       inc       ecx
       mov       rax,[rsp+38]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+60],1
M10_L09:
       mov       rcx,rax
       call      00007FF809262C80
       test      eax,eax
       jne       near ptr M10_L18
M10_L10:
       cmp       dword ptr [rsp+60],0
       je        near ptr M10_L19
       mov       r15d,1
M10_L11:
       jmp       near ptr M10_L02
M10_L12:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       short M10_L08
M10_L13:
       call      qword ptr [7FF7A9717198]
       int       3
M10_L14:
       mov       ecx,3
       call      qword ptr [7FF7A9E95098]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M10_L00
M10_L15:
       mov       rcx,rbx
       call      qword ptr [7FF7A97CCEA0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M10_L01
M10_L16:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7A9D97BD0]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF7A94E4000
       call      qword ptr [7FF7A97C77B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF7A9926088]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M10_L17:
       mov       rcx,rbx
       mov       edx,ebp
       call      qword ptr [7FF7A9CBF108]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
       jmp       near ptr M10_L05
M10_L18:
       mov       ecx,eax
       mov       rdx,[rsp+38]
       call      qword ptr [7FF7A9E951E8]
       jmp       near ptr M10_L10
M10_L19:
       inc       r13d
       mov       ecx,[rsp+44]
       cmp       ecx,r13d
       jne       short M10_L20
       xor       r13d,r13d
M10_L20:
       mov       edx,[rsp+40]
       dec       edx
       mov       [rsp+40],edx
       mov       eax,ecx
       jne       near ptr M10_L06
M10_L21:
       xor       r15d,r15d
       jmp       near ptr M10_L11
M10_L22:
       cmp       dword ptr [rdi+8],0
       je        near ptr M10_L03
       mov       rcx,rdi
       call      qword ptr [7FF7A99BCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       eax,[rdi+8]
       mov       [rsp+64],eax
       mov       rcx,rbx
       call      qword ptr [7FF7A99BCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r13
       mov       r8d,r12d
       mov       r9d,[rsp+64]
       mov       edx,3
       call      qword ptr [7FF7A9E9D590]
       test      r15d,r14d
       jne       near ptr M10_L03
       mov       rcx,rdi
       call      qword ptr [7FF7A99BCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       edi,[rdi+8]
       mov       rcx,rbx
       call      qword ptr [7FF7A99BCF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r14d,r14d
       jne       short M10_L23
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M10_L24
M10_L23:
       mov       ecx,ebp
       xor       edx,edx
M10_L24:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r13
       mov       edx,r15d
       mov       r8d,edi
       call      qword ptr [7FF7A9D97C48]
       jmp       near ptr M10_L03
M10_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 904
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Xml_Ref_Person()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       mov       [rbp-30],rax
       mov       rbx,rcx
       mov       rcx,[rbx+160]
       mov       rsi,rcx
       test      rsi,rsi
       je        near ptr M00_L14
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        near ptr M00_L14
       movzx     edx,word ptr [rsi+0C]
       cmp       edx,100
       jl        short M00_L00
       mov       eax,edx
       shr       eax,9
       mov       r8,7FFFFDF96778
       movzx     eax,byte ptr [r8+rax]
       shl       eax,6
       mov       r8d,edx
       shr       r8d,3
       and       r8d,3E
       add       eax,r8d
       mov       r8,7FFFFDF94280
       movzx     eax,word ptr [r8+rax]
       shl       eax,4
       and       edx,0F
       add       edx,eax
       mov       rax,7FFFFDF9C558
       movzx     edx,byte ptr [rax+rdx]
       mov       rax,7FFFFDFA5028
       cmp       byte ptr [rax+rdx],0
       jl        near ptr M00_L16
       jmp       short M00_L01
M00_L00:
       mov       edx,edx
       mov       rax,7FFFFDF96090
       test      byte ptr [rax+rdx],80
       jne       near ptr M00_L16
M00_L01:
       dec       ecx
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jl        short M00_L02
       mov       edx,ecx
       shr       edx,9
       mov       rax,7FFFFDF96778
       movzx     edx,byte ptr [rax+rdx]
       shl       edx,6
       mov       eax,ecx
       shr       eax,3
       and       eax,3E
       add       edx,eax
       mov       rax,7FFFFDF94280
       movzx     edx,word ptr [rax+rdx]
       shl       edx,4
       and       ecx,0F
       add       ecx,edx
       mov       rdx,7FFFFDF9C558
       movzx     ecx,byte ptr [rdx+rcx]
       mov       rdx,7FFFFDFA5028
       cmp       byte ptr [rdx+rcx],0
       jl        near ptr M00_L16
       jmp       short M00_L03
M00_L02:
       mov       ecx,ecx
       mov       rdx,7FFFFDF96090
       test      byte ptr [rdx+rcx],80
       jne       near ptr M00_L16
M00_L03:
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        near ptr M00_L17
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-60],rdi
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1CA7F0006C0
       mov       r14,[rdx]
       mov       rdx,[r14+10]
       mov       rcx,rsi
       mov       r8,r14
       xor       r9d,r9d
       call      qword ptr [7FF7A9D97C48]; System.Xml.XmlTextReaderImpl..ctor(System.Xml.XmlResolver, System.Xml.XmlReaderSettings, System.Xml.XmlParserContext)
       mov       rcx,20AFDF90008
       mov       [rsi+60],rcx
       movzx     ecx,byte ptr [r14+5D]
       mov       [rsi+17D],cl
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl+LaterInitParam
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+44],3
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15,[rsi+8]
       lea       rcx,[r15+38]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+30],rcx
       mov       dword ptr [r15+44],2
       cmp       byte ptr [r14+58],0
       je        short M00_L04
       mov       byte ptr [r15+48],1
       jmp       near ptr M00_L08
M00_L04:
       mov       r14,[rsi+60]
       mov       rdx,[r15+38]
       lea       rcx,[rsi+1B0]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+1B8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+1C0],rcx
       cmp       qword ptr [rsi+188],0
       jne       short M00_L06
       cmp       byte ptr [r15+48],0
       jne       short M00_L05
       lea       r14,[rsi+188]
       mov       rcx,offset MT_System.Char[]
       mov       edx,1001
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rcx,r14
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L06
M00_L05:
       lea       r14,[rsi+188]
       mov       rcx,offset MT_System.Char[]
       mov       edx,8001
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rcx,r14
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L06:
       mov       rcx,1CA7F0005A0
       mov       rdx,[rcx]
       lea       rcx,[rsi+190]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       byte ptr [rsi+178],0
       sete      cl
       mov       [rsi+1EF],cl
       mov       byte ptr [rsi+1EC],1
       mov       rcx,rsi
       call      qword ptr [7FF7A9D97F00]; System.Xml.XmlTextReaderImpl.ReadData()
       mov       rdx,[rsi+190]
       lea       rcx,[rsi+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M00_L07
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9F650C8]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[rsi+8]
       mov       rdx,[rdx+30]
       mov       rcx,rsi
       call      qword ptr [7FF7A9F650E0]
M00_L07:
       xor       ecx,ecx
       mov       [rsi+8],rcx
M00_L08:
       mov       [rbp-68],rsi
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,20AFDF9FFC0
       xor       r8d,r8d
       call      qword ptr [7FF7A9CB5D40]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       vmovdqu   ymm0,ymmword ptr [r14+38]
       vmovdqu   ymmword ptr [rbp-58],ymm0
       mov       r9,[r14+58]
       mov       [rbp-38],r9
       lea       r9,[rbp-58]
       mov       rdx,rsi
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FF7A9D97F78]; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
       test      rax,rax
       je        short M00_L10
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       cmp       [r14],rcx
       jne       short M00_L09
       jmp       short M00_L11
M00_L09:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L10:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7A9D97450]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF7A9925FE0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       cmp       dword ptr [rsi+160],4
       je        short M00_L12
       movzx     edx,byte ptr [rsi+17D]
       mov       rcx,rsi
       call      qword ptr [7FF7A9D9CDC8]; System.Xml.XmlTextReaderImpl.Close(Boolean)
       nop
M00_L12:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       [rdi+10],ecx
       mov       rsi,[rdi]
       test      dword ptr [rsi],100000
       jne       near ptr M00_L18
M00_L13:
       mov       [rbp-30],r14
       mov       rcx,[rbx+60]
       lea       r8,[rbp-30]
       mov       rdx,7FF7A9DD6C20
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9D9CE28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L14:
       call      qword ptr [7FF7A99B4378]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L15
       call      qword ptr [7FF7A9F67408]
       mov       rbx,rax
M00_L15:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,20AFDFA1748
       call      qword ptr [7FF7A9E06448]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L16:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FF7A9E05DB8]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L17:
       mov       ecx,11
       call      qword ptr [7FF7A95AFD50]
       int       3
M00_L18:
       mov       rcx,rdi
       call      00007FF809209E50
       jmp       near ptr M00_L13
       sub       rsp,28
       mov       rcx,[rbp-68]
       cmp       dword ptr [rcx+160],4
       je        short M00_L19
       movzx     edx,byte ptr [rcx+17D]
       call      qword ptr [7FF7A9D9CDC8]; System.Xml.XmlTextReaderImpl.Close(Boolean)
M00_L19:
       nop
       vzeroupper
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rax,[rbp-60]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       rsi,[rax]
       test      dword ptr [rsi],100000
       je        short M00_L20
       mov       rcx,rax
       call      00007FF809209E50
M00_L20:
       nop
       vzeroupper
       add       rsp,28
       ret
; Total bytes of code 1249
```
```assembly
; System.Xml.XmlTextReaderImpl..ctor(System.Xml.XmlResolver, System.Xml.XmlReaderSettings, System.Xml.XmlParserContext)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       rbx,rcx
       mov       rbp,rdx
       mov       rsi,r8
       mov       rdi,r9
M01_L00:
       mov       dword ptr [rbx+118],0FFFFFFFF
       mov       r14,20AFDF90008
       mov       [rbx+38],r14
       mov       byte ptr [rbx+179],1
       mov       dword ptr [rbx+12C],2
       mov       [rbx+48],r14
       mov       dword ptr [rbx+13C],0FFFFFFFF
       mov       [rbx+60],r14
       mov       dword ptr [rbx+140],9
       mov       dword ptr [rbx+158],1
       xor       ecx,ecx
       mov       [rsp+38],ecx
       mov       [rsp+3C],ecx
       mov       [rsp+40],ecx
       mov       byte ptr [rsp+44],0
       lea       rcx,[rsp+38]
       cmp       qword ptr [rcx],0
       je        near ptr M01_L21
M01_L01:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.ValueTuple<System.Int32, System.Int32, System.Int32, System.Boolean>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       edx,edx
       mov       [rsp+48],edx
       mov       [rsp+4C],edx
       mov       [rsp+50],edx
       mov       byte ptr [rsp+54],0
       lea       rdx,[rsp+48]
       mov       rcx,r15
       call      qword ptr [7FF7A9F65170]; System.Threading.Tasks.Task`1[[System.ValueTuple`4[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.ValueTuple`4<Int32,Int32,Int32,Boolean>)
       mov       rdx,r15
M01_L02:
       lea       rcx,[rbx+0E0]
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rsi+58]
       mov       [rbx+174],cl
       mov       byte ptr [rbx+17E],0
       lea       rcx,[rbx+0C8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl+XmlContext
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+20],ecx
       mov       [rax+8],r14
       mov       [rax+10],r14
       mov       [rax+18],rcx
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15,[rsi+8]
       test      rdi,rdi
       jne       near ptr M01_L26
       test      r15,r15
       jne       near ptr M01_L25
       mov       rcx,offset MT_System.Xml.NameTable
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+14],1F
       mov       edx,[r15+14]
       inc       edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Xml.NameTable+Entry[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       lea       rcx,[rbx+28]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Xml.XmlNamespaceManager
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       call      qword ptr [7FF7A9D97DE0]; System.Xml.XmlNamespaceManager..ctor(System.Xml.XmlNameTable)
       lea       rcx,[rbx+40]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M01_L04:
       mov       rcx,offset MT_System.Xml.NameTable
       cmp       [r15],rcx
       jne       near ptr M01_L27
       mov       rcx,[r15+8]
       mov       r13d,[r15+14]
       and       r13d,5E12C37E
       mov       eax,r13d
       cmp       eax,[rcx+8]
       jae       near ptr M01_L30
       mov       r12,[rcx+rax*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M01_L07
M01_L05:
       cmp       dword ptr [rcx+18],5E12C37E
       je        near ptr M01_L22
M01_L06:
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M01_L05
M01_L07:
       mov       rcx,offset MT_System.Xml.NameTable+Entry
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       rdx,r12
       mov       rcx,20AFDFA1748
       mov       [rax+8],rcx
       mov       dword ptr [rax+18],5E12C37E
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r15+8]
       cmp       r13d,[rcx+8]
       jae       near ptr M01_L30
       mov       edx,r13d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r15+10]
       lea       eax,[rcx+1]
       mov       [r15+10],eax
       cmp       ecx,[r15+14]
       je        near ptr M01_L24
M01_L08:
       mov       r13,[rsp+30]
       mov       rdx,[r13+8]
M01_L09:
       lea       rcx,[rbx+0D0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,20AFDFA17D4
       mov       eax,27EB1F56
       mov       edx,0C0025241
       mov       r8d,1
M01_L10:
       add       eax,[rcx]
       mov       r10d,[rcx+4]
       xor       edx,eax
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       rol       edx,13
       add       r10d,eax
       mov       eax,edx
       xor       eax,r10d
       rol       r10d,14
       add       r10d,eax
       rol       eax,9
       xor       eax,r10d
       rol       r10d,1B
       add       r10d,eax
       rol       eax,13
       mov       edx,r10d
       add       rcx,8
       dec       r8d
       mov       r9d,eax
       mov       eax,edx
       mov       edx,r9d
       jne       short M01_L10
       mov       ecx,[rcx-2]
       shr       ecx,8
       or        ecx,80000000
       shr       ecx,8
       add       ecx,eax
       mov       eax,edx
       xor       eax,ecx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       r13d,ecx
       rol       r13d,14
       add       r13d,eax
       rol       eax,9
       xor       eax,r13d
       rol       r13d,1B
       add       r13d,eax
       mov       r12d,eax
       rol       r12d,13
       xor       r13d,r12d
       mov       rcx,[r15+8]
       mov       r12d,r13d
       and       r12d,[r15+14]
       mov       eax,r12d
       cmp       eax,[rcx+8]
       jae       near ptr M01_L30
       mov       rax,[rcx+rax*8+10]
       mov       rdx,rax
       mov       [rsp+20],rdx
       mov       rcx,rdx
       test      rcx,rcx
       je        short M01_L13
M01_L11:
       cmp       [rcx+18],r13d
       je        near ptr M01_L18
M01_L12:
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M01_L11
M01_L13:
       mov       rcx,offset MT_System.Xml.NameTable+Entry
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       mov       rdx,[rsp+20]
       mov       rcx,20AFDFA17C8
       mov       [rax+8],rcx
       mov       [rax+18],r13d
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r15+8]
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L30
       mov       edx,r12d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r15+10]
       lea       eax,[rcx+1]
       mov       [r15+10],eax
       cmp       ecx,[r15+14]
       je        near ptr M01_L20
M01_L14:
       mov       r15,[rsp+28]
       mov       rdx,[r15+8]
M01_L15:
       lea       rcx,[rbx+0D8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+30]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl+NodeData[]
       mov       edx,8
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl+NodeData
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,[rbx+10]
       mov       rcx,rbp
       xor       edx,edx
       mov       [rax+50],edx
       mov       [rax+8],r14
       mov       [rax+10],r14
       mov       [rax+18],r14
       mov       [rax+20],r14
       mov       [rax+28],r14
       mov       dword ptr [rax+54],0FFFFFFFF
       mov       [rax+40],rdx
       mov       [rax+48],rdx
       mov       byte ptr [rax+67],0
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M01_L30
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rbp+8],0
       jbe       near ptr M01_L30
       mov       rdx,[rbp+10]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+0B0]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+130],1
       movzx     ecx,byte ptr [rsi+5E]
       mov       [rbx+187],cl
       cmp       byte ptr [rsi+5A],0
       setne     cl
       movzx     ecx,cl
       mov       [rbx+128],ecx
       mov       byte ptr [rbx+178],1
       movzx     ecx,byte ptr [rsi+5B]
       mov       [rbx+17A],cl
       movzx     ecx,byte ptr [rsi+5C]
       mov       [rbx+17B],cl
       movzx     ecx,byte ptr [rsi+59]
       mov       [rbx+17C],cl
       mov       ecx,[rsi+40]
       mov       [rbx+134],ecx
       mov       edx,[rsi+44]
       mov       [rbx+138],edx
       inc       ecx
       mov       [rbx+1E0],ecx
       neg       edx
       dec       edx
       mov       [rbx+1E4],edx
       mov       rdx,[rbx+18]
       dec       ecx
       lea       rax,[rbx+188]
       mov       r8d,[rax+48]
       sub       r8d,[rax+5C]
       dec       r8d
       cmp       [rdx],dl
       add       rdx,68
       mov       [rdx],ecx
       mov       [rdx+4],r8d
       mov       ecx,[rsi+4C]
       mov       [rbx+12C],ecx
       mov       rcx,[rsi+30]
       mov       [rbx+0E8],rcx
       mov       rcx,[rsi+38]
       mov       [rbx+0F0],rcx
       xor       ecx,ecx
       mov       [rbx+0F8],rcx
       mov       [rbx+100],rcx
       lea       rcx,[rbx+78]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,500000004
       mov       [rbx+108],rax
       mov       eax,[rsi+48]
       cmp       eax,2
       jne       near ptr M01_L28
M01_L16:
       mov       dword ptr [rbx+140],9
M01_L17:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L18:
       mov       rax,[rcx+8]
       mov       r8,rax
       mov       r10,20AFDFA17C8
       cmp       r8,r10
       je        short M01_L19
       cmp       dword ptr [r8+8],5
       jne       near ptr M01_L12
       mov       r10,6E006C006D0078
       xor       r10,[r8+0C]
       movzx     r8d,word ptr [r8+14]
       xor       r8d,73
       or        r8,r10
       jne       near ptr M01_L12
M01_L19:
       mov       rdx,rax
       jmp       near ptr M01_L15
M01_L20:
       mov       rcx,r15
       call      qword ptr [7FF7A9D9C0A8]; System.Xml.NameTable.Grow()
       jmp       near ptr M01_L14
M01_L21:
       lea       rcx,[rsp+40]
       cmp       qword ptr [rcx],0
       jne       near ptr M01_L01
       mov       rdx,1CA7F0006C8
       mov       rdx,[rdx]
       jmp       near ptr M01_L02
M01_L22:
       mov       rdx,[rcx+8]
       mov       rax,rdx
       mov       r8,20AFDFA1748
       cmp       rax,r8
       je        short M01_L23
       cmp       dword ptr [rax+8],3
       jne       near ptr M01_L06
       mov       r8d,[rax+0C]
       xor       r8d,6D0078
       movzx     eax,word ptr [rax+10]
       xor       eax,6C
       or        eax,r8d
       jne       near ptr M01_L06
M01_L23:
       jmp       near ptr M01_L09
M01_L24:
       mov       rcx,r15
       call      qword ptr [7FF7A9D9C0A8]; System.Xml.NameTable.Grow()
       jmp       near ptr M01_L08
M01_L25:
       mov       byte ptr [rbx+177],1
       jmp       near ptr M01_L03
M01_L26:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FF7A9F65188]
       mov       r15,[rbx+28]
       jmp       near ptr M01_L04
M01_L27:
       mov       rcx,r15
       mov       rdx,r14
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,r15
       mov       rdx,20AFDFA1748
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       lea       rcx,[rbx+0D0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,20AFDFA17C8
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       jmp       near ptr M01_L15
M01_L28:
       cmp       eax,2
       ja        near ptr M01_L16
       mov       eax,eax
       lea       rcx,[7FF7AA0004D0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M01_L00]
       add       rcx,rdx
       jmp       rcx
       xor       eax,eax
       mov       [rbx+140],eax
M01_L29:
       mov       byte ptr [rbx+17F],1
       jmp       near ptr M01_L17
       mov       dword ptr [rbx+140],1
       jmp       short M01_L29
M01_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1872
```
```assembly
; System.Xml.XmlTextReaderImpl.ReadData()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
M02_L00:
       cmp       byte ptr [rbx+1ED],0
       jne       near ptr M02_L17
       cmp       byte ptr [rbx+1EC],0
       je        near ptr M02_L12
       mov       ecx,[rbx+1D4]
       mov       rax,[rbx+188]
       mov       eax,[rax+8]
       dec       eax
       cmp       ecx,eax
       je        near ptr M02_L18
M02_L01:
       cmp       qword ptr [rbx+198],0
       jne       near ptr M02_L21
M02_L02:
       mov       rcx,[rbx+188]
       mov       esi,[rcx+8]
       sub       esi,[rbx+1D4]
       dec       esi
       cmp       esi,50
       jle       short M02_L03
       mov       esi,50
M02_L03:
       cmp       qword ptr [rbx+198],0
       jne       near ptr M02_L30
       mov       rsi,[rbx+1B0]
       test      rsi,rsi
       je        near ptr M02_L40
       mov       rdx,[rbx+188]
       mov       rax,rdx
       mov       ecx,[rbx+1D4]
       mov       edi,ecx
       mov       ebp,[rdx+8]
       sub       ebp,ecx
       dec       ebp
       mov       rdx,offset MT_System.IO.StringReader
       cmp       [rsi],rdx
       jne       near ptr M02_L39
       test      edi,edi
       jl        near ptr M02_L33
       test      ebp,ebp
       jl        near ptr M02_L34
       mov       edx,[rax+8]
       sub       edx,edi
       cmp       edx,ebp
       jl        near ptr M02_L35
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M02_L36
       mov       r14d,[rdx+8]
       sub       r14d,[rsi+10]
       test      r14d,r14d
       jle       short M02_L06
       cmp       r14d,ebp
       cmovg     r14d,ebp
       mov       ebp,[rsi+10]
       cmp       [rdx],dl
       test      r14d,r14d
       jl        near ptr M02_L37
       test      ebp,ebp
       jl        near ptr M02_L38
       mov       r15d,[rdx+8]
       sub       r15d,ebp
       cmp       r14d,r15d
       jl        short M02_L04
       cmp       r14d,r15d
       jg        near ptr M02_L15
M02_L04:
       mov       r15d,[rax+8]
       sub       r15d,r14d
       cmp       edi,r15d
       jl        short M02_L05
       cmp       edi,r15d
       jg        near ptr M02_L16
M02_L05:
       mov       ecx,ebp
       lea       rdx,[rdx+rcx*2+0C]
       mov       ecx,edi
       lea       rcx,[rax+rcx*2+10]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FF7A95A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rsi+10],r14d
M02_L06:
       mov       r13d,r14d
M02_L07:
       mov       esi,r13d
       lea       rcx,[rbx+1D4]
       add       [rcx],esi
M02_L08:
       movsxd    rdi,esi
       cmp       dword ptr [rbx+13C],0
       setge     bpl
       movzx     ebp,bpl
       cmp       qword ptr [rbx+0E8],0
       jg        near ptr M02_L41
M02_L09:
       cmp       qword ptr [rbx+0F0],0
       setg      cl
       movzx     ecx,cl
       test      ebp,ecx
       jne       near ptr M02_L44
M02_L10:
       test      esi,esi
       jne       short M02_L11
       mov       byte ptr [rbx+1ED],1
M02_L11:
       mov       rax,[rbx+188]
       mov       ecx,[rbx+1D4]
       cmp       ecx,[rax+8]
       jae       near ptr M02_L47
       mov       word ptr [rax+rcx*2+10],0
       mov       eax,esi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L12:
       mov       rcx,[rbx+188]
       mov       esi,[rcx+8]
       mov       ecx,esi
       sub       ecx,[rbx+1D4]
       mov       eax,esi
       shr       eax,1
       cmp       ecx,eax
       jle       near ptr M02_L22
M02_L13:
       cmp       qword ptr [rbx+198],0
       jne       near ptr M02_L27
M02_L14:
       mov       rcx,[rbx+188]
       mov       esi,[rcx+8]
       sub       esi,[rbx+1D4]
       dec       esi
       jmp       near ptr M02_L03
M02_L15:
       mov       ecx,167
       mov       rdx,7FF7A94E4000
       call      qword ptr [7FF7A95AF228]
       mov       r8,rax
       mov       edx,r15d
       mov       ecx,r14d
       call      qword ptr [7FF7A9F648A0]
       int       3
M02_L16:
       mov       ecx,17F
       mov       rdx,7FF7A94E4000
       call      qword ptr [7FF7A95AF228]
       mov       r8,rax
       mov       edx,r15d
       mov       ecx,edi
       call      qword ptr [7FF7A9F648A0]
       int       3
M02_L17:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L18:
       xor       esi,esi
       jmp       short M02_L20
M02_L19:
       mov       rcx,[rbx+10]
       mov       eax,[rbx+114]
       lea       eax,[rax+rsi+1]
       cmp       eax,[rcx+8]
       jae       near ptr M02_L47
       mov       rcx,[rcx+rax*8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9F64D80]
       inc       esi
M02_L20:
       cmp       esi,[rbx+11C]
       jl        short M02_L19
       mov       rdx,[rbx+188]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       rcx,[rbx+188]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,[rbx+188]
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF7A9835FF8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       lea       rcx,[rbx+188]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L01
M02_L21:
       mov       edx,[rbx+1DC]
       sub       edx,[rbx+1D8]
       cmp       edx,6
       jge       near ptr M02_L02
       mov       rdx,[rbx+1A8]
       mov       edx,[rdx+8]
       sub       edx,[rbx+1DC]
       cmp       edx,6
       jge       near ptr M02_L02
       mov       rdx,[rbx+1A8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       ecx,[rbx+1DC]
       mov       [rsp+20],ecx
       mov       rcx,[rbx+1A8]
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF7A9835FF8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       lea       rcx,[rbx+1A8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L02
M02_L22:
       xor       edi,edi
       jmp       short M02_L24
M02_L23:
       mov       rcx,[rbx+10]
       mov       eax,[rbx+114]
       lea       eax,[rax+rdi+1]
       cmp       eax,[rcx+8]
       jae       near ptr M02_L47
       mov       rcx,[rcx+rax*8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9F64D80]
       inc       edi
M02_L24:
       cmp       edi,[rbx+11C]
       jl        short M02_L23
       mov       edi,[rbx+1D4]
       sub       edi,[rbx+1D0]
       dec       esi
       cmp       edi,esi
       jge       short M02_L26
       lea       rdx,[rbx+1E4]
       mov       ecx,[rbx+1D0]
       sub       [rdx],ecx
       test      edi,edi
       jle       short M02_L25
       lea       edx,[rdi+rdi]
       mov       [rsp+20],edx
       mov       edx,[rbx+1D0]
       add       edx,edx
       mov       rcx,[rbx+188]
       mov       r8,[rbx+188]
       xor       r9d,r9d
       call      qword ptr [7FF7A9835FF8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
M02_L25:
       xor       edx,edx
       mov       [rbx+1D0],edx
       mov       [rbx+1D4],edi
       jmp       near ptr M02_L13
M02_L26:
       mov       rdx,[rbx+188]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       rcx,[rbx+188]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,[rbx+188]
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF7A9835FF8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       lea       rcx,[rbx+188]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L13
M02_L27:
       mov       esi,[rbx+1DC]
       sub       esi,[rbx+1D8]
       cmp       esi,80
       jg        near ptr M02_L14
       test      esi,esi
       jne       short M02_L28
       xor       ecx,ecx
       mov       [rbx+1DC],ecx
       jmp       short M02_L29
M02_L28:
       mov       [rsp+20],esi
       mov       rcx,[rbx+1A8]
       mov       edx,[rbx+1D8]
       mov       r8,[rbx+1A8]
       xor       r9d,r9d
       call      qword ptr [7FF7A9835FF8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rbx+1DC],esi
M02_L29:
       xor       ecx,ecx
       mov       [rbx+1D8],ecx
       jmp       near ptr M02_L14
M02_L30:
       cmp       byte ptr [rbx+1EE],0
       jne       short M02_L32
       mov       ecx,[rbx+1D8]
       cmp       ecx,[rbx+1DC]
       jne       short M02_L32
       mov       rcx,[rbx+1A8]
       mov       ecx,[rcx+8]
       sub       ecx,[rbx+1DC]
       test      ecx,ecx
       jle       short M02_L32
       mov       rcx,[rbx+198]
       mov       r9,[rbx+1A8]
       mov       r9d,[r9+8]
       sub       r9d,[rbx+1DC]
       mov       r8d,[rbx+1DC]
       mov       rdx,[rbx+1A8]
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L31
       mov       byte ptr [rbx+1EE],1
M02_L31:
       lea       rcx,[rbx+1DC]
       add       [rcx],eax
M02_L32:
       mov       edi,[rbx+1D8]
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF7A9F64DB0]
       mov       esi,eax
       test      esi,esi
       jne       near ptr M02_L08
       cmp       [rbx+1D8],edi
       je        near ptr M02_L08
       jmp       near ptr M02_L00
M02_L33:
       mov       ecx,13CB6
       mov       rdx,7FF7A94E4000
       call      qword ptr [7FF7A95AF228]
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF7A9E05830]
       int       3
M02_L34:
       mov       ecx,28F
       mov       rdx,7FF7A94E4000
       call      qword ptr [7FF7A95AF228]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FF7A9E05830]
       int       3
M02_L35:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7A9E06F28]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF7A9924198]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L36:
       call      qword ptr [7FF7A9F64DC8]
       int       3
M02_L37:
       mov       ecx,28F
       mov       rdx,7FF7A94E4000
       call      qword ptr [7FF7A95AF228]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7A9E05830]
       int       3
M02_L38:
       mov       ecx,167
       mov       rdx,7FF7A94E4000
       call      qword ptr [7FF7A95AF228]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FF7A9E05830]
       int       3
M02_L39:
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8d,edi
       mov       r9d,ebp
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       r13d,eax
       jmp       near ptr M02_L07
M02_L40:
       xor       esi,esi
       jmp       near ptr M02_L08
M02_L41:
       mov       r14,rdi
       add       r14,[rbx+0F8]
       cmp       r14,[rbx+0F8]
       jge       short M02_L42
       mov       rcx,20AFDFAB518
       call      qword ptr [7FF7A9F64798]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,20AFDFAB550
       call      qword ptr [7FF7A9F64DE0]
       jmp       short M02_L43
M02_L42:
       mov       [rbx+0F8],r14
M02_L43:
       mov       rcx,[rbx+0F8]
       cmp       rcx,[rbx+0E8]
       jle       near ptr M02_L09
       mov       rcx,20AFDFAB518
       call      qword ptr [7FF7A9F64798]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,20AFDFAB550
       call      qword ptr [7FF7A9F64DE0]
       jmp       near ptr M02_L09
M02_L44:
       add       rdi,[rbx+100]
       cmp       rdi,[rbx+100]
       jge       short M02_L45
       mov       rcx,20AFDFAB518
       call      qword ptr [7FF7A9F64798]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,20AFDFAB598
       call      qword ptr [7FF7A9F64DE0]
       jmp       short M02_L46
M02_L45:
       mov       [rbx+100],rdi
M02_L46:
       mov       rcx,[rbx+100]
       cmp       rcx,[rbx+0F0]
       jle       near ptr M02_L10
       mov       rcx,20AFDFAB518
       call      qword ptr [7FF7A9F64798]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,20AFDFAB598
       call      qword ptr [7FF7A9F64DE0]
       jmp       near ptr M02_L10
M02_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1857
```
```assembly
; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        near ptr M03_L19
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M03_L20
M03_L00:
       mov       rcx,1CA7F000038
       mov       r14,[rcx]
       mov       r15,[r14+8]
       mov       r13d,[r15+8]
       mov       r12d,r13d
       cmp       qword ptr [r14+20],0
       jne       short M03_L01
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,[r14+20]
       mov       rdx,rsi
       mov       r11,7FF7A94F14A0
       call      qword ptr [r11]
M03_L02:
       mov       r8d,eax
       and       r8d,7FFFFFFF
       imul      eax,r8d,65
       dec       r12d
       xor       edx,edx
       div       r12d
       lea       r12d,[rdx+1]
       mov       [rbp-4C],r12d
       mov       [rbp-50],r8d
       xor       r10d,r10d
       mov       [rbp-54],r10d
       mov       eax,r8d
       xor       edx,edx
       div       r13d
       mov       eax,edx
M03_L03:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       mov       ecx,eax
       lea       r9,[rcx+rcx*2]
       mov       [rbp-88],r9
M03_L04:
       mov       ecx,[r14+38]
       mov       [rbp-58],eax
       cmp       eax,r13d
       jae       near ptr M03_L36
       lea       rdx,[r15+r9*8+10]
       mov       r11,[rdx]
       mov       r12,[rdx+8]
       mov       edx,[rdx+10]
       mov       [rbp-7C],edx
       cmp       byte ptr [r14+3C],0
       jne       near ptr M03_L21
       cmp       ecx,[r14+38]
       jne       near ptr M03_L21
       test      r11,r11
       jne       near ptr M03_L15
M03_L05:
       xor       edx,edx
M03_L06:
       mov       r14,rdx
       test      r14,r14
       je        short M03_L07
       mov       rcx,offset MT_System.Xml.Serialization.TypeDesc
       cmp       [r14],rcx
       jne       near ptr M03_L25
M03_L07:
       test      r14,r14
       jne       near ptr M03_L26
M03_L08:
       xor       r14d,r14d
M03_L09:
       lea       rcx,[rbx+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+18],0
       jne       near ptr M03_L27
       cmp       dword ptr [7FF7A94EB150],1
       je        near ptr M03_L14
       mov       rcx,1CA7F000060
       mov       r14,[rcx]
       mov       rcx,offset MT_System.Xml.Serialization.TempAssemblyCacheKey
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[r14+10]
       cmp       qword ptr [r13+8],0
       je        near ptr M03_L30
       mov       r12,[r13+18]
       mov       rcx,r12
       mov       rdx,r15
       mov       r11,7FF7A94F14B0
       call      qword ptr [r11]
       mov       [rbp-74],eax
       mov       rdx,[r13+8]
       mov       ecx,eax
       imul      rcx,[r13+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M03_L36
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       edx,[rdx]
       mov       r13,[r13+10]
       xor       r10d,r10d
       mov       [rbp-78],r10d
       dec       edx
       cmp       [r13+8],edx
       jbe       near ptr M03_L30
M03_L10:
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r13+rdx*8+10]
       mov       [rbp-98],r9
       cmp       [r9+10],eax
       jne       near ptr M03_L29
       mov       rdx,[r9]
       mov       rcx,r12
       mov       r8,r15
       mov       r11,7FF7A94F14B8
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-98]
       je        near ptr M03_L29
       add       r9,8
M03_L11:
       test      r9,r9
       je        near ptr M03_L31
       mov       rcx,[r9]
       mov       [rbp-68],rcx
M03_L12:
       mov       rdx,[rbp-68]
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       [rbp-70],rcx
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+8],0
       je        near ptr M03_L32
M03_L13:
       cmp       qword ptr [rbx+18],0
       jne       short M03_L14
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF7A9D97F60]; System.Xml.Serialization.XmlReflectionImporter.GetTopLevelMapping(System.Type, System.String)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M03_L14:
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
M03_L15:
       mov       ecx,edx
       and       ecx,7FFFFFFF
       movsxd    rcx,ecx
       mov       r9d,[rbp-50]
       cmp       rcx,r9
       je        short M03_L17
M03_L16:
       mov       eax,[rbp-58]
       mov       r12d,[rbp-4C]
       mov       ecx,r12d
       add       rax,rcx
       mov       r13d,[r15+8]
       mov       ecx,r13d
       cqo
       idiv      rcx
       mov       eax,edx
       mov       ecx,eax
       cmp       dword ptr [rbp-7C],0
       jge       near ptr M03_L05
       mov       r10d,[rbp-54]
       inc       r10d
       cmp       r13d,r10d
       mov       [rbp-54],r10d
       mov       eax,ecx
       jg        near ptr M03_L03
       jmp       near ptr M03_L05
M03_L17:
       cmp       [r14+8],r11
       je        short M03_L16
       cmp       r11,rsi
       jne       short M03_L22
M03_L18:
       mov       rdx,r12
       jmp       near ptr M03_L06
M03_L19:
       mov       ecx,0EBC1
       mov       rdx,7FF7A9C19C60
       call      qword ptr [7FF7A95AF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9E05860]
       int       3
M03_L20:
       mov       rcx,rdi
       mov       rdx,20AFDF90008
       call      qword ptr [7FF7A95A6E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       near ptr M03_L00
       jmp       near ptr M03_L08
M03_L21:
       lea       rcx,[rbp-60]
       mov       edx,14
       call      qword ptr [7FF7A9F64C48]
       mov       eax,[rbp-58]
       mov       r9,[rbp-88]
       jmp       near ptr M03_L04
M03_L22:
       cmp       qword ptr [r14+20],0
       je        short M03_L23
       mov       rcx,[r14+20]
       mov       r8,rsi
       mov       rdx,r11
       mov       r11,7FF7A94F14A8
       call      qword ptr [r11]
       jmp       short M03_L24
M03_L23:
       mov       rcx,r11
       mov       rdx,rsi
       mov       r9,[r11]
       mov       r9,[r9+40]
       call      qword ptr [r9+10]
M03_L24:
       test      eax,eax
       je        near ptr M03_L16
       jmp       near ptr M03_L18
M03_L25:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L26:
       mov       rcx,offset MT_System.Xml.Serialization.ElementAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,[r14+38]
       mov       rdx,[rcx+48]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Xml.Serialization.XmlTypeMapping
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       r8,r15
       xor       edx,edx
       mov       r9d,3
       call      qword ptr [7FF7A9F651D0]
       mov       rcx,rsi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF7A9CBF048]; System.Xml.Serialization.XmlMapping.GenerateKey(System.Type, System.Xml.Serialization.XmlRootAttribute, System.String)
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L09
M03_L27:
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L14
M03_L28:
       cmp       [r13+8],edx
       mov       [rbp-78],r10d
       mov       eax,[rbp-74]
       jbe       short M03_L30
       jmp       near ptr M03_L10
M03_L29:
       mov       edx,[r9+14]
       mov       r10d,[rbp-78]
       inc       r10d
       cmp       [r13+8],r10d
       jae       short M03_L28
       call      qword ptr [7FF7A95AF498]
       int       3
M03_L30:
       xor       r9d,r9d
       jmp       near ptr M03_L11
M03_L31:
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       r14,[r14+8]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       rdx,rax
       mov       rcx,r14
       lea       r8,[rbp-70]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9CB65B0]; System.Runtime.CompilerServices.ConditionalWeakTable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M03_L12
       lea       r8,[rbp-68]
       mov       rcx,[rbp-70]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF7A95EAC10]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       jmp       near ptr M03_L12
M03_L32:
       mov       rdx,1CA7F000060
       mov       rcx,[rdx]
       mov       [rbp-90],rcx
       xor       edx,edx
       mov       [rbp-40],edx
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-90]
       call      qword ptr [7FF7A95A5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1CA7F000060
       mov       rcx,[rcx]
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FF7A9CB6598]; System.Xml.Serialization.TempAssemblyCache.get_Item(System.String, System.Type)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+8],0
       jne       near ptr M03_L35
       xor       r8d,r8d
       mov       [rbp-48],r8
       lea       r8,[rbp-48]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF7A9CB65C8]; System.Xml.Serialization.TempAssembly.LoadGeneratedAssembly(System.Type, System.String, System.Xml.Serialization.XmlSerializerImplementation ByRef)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M03_L34
       cmp       dword ptr [7FF7A94EB150],3
       jne       short M03_L33
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FF7A9CB6808]; System.Xml.Serialization.Compiler.GetTempAssemblyName(System.Reflection.AssemblyName, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.IO.FileLoadException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7A9F65200]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF7A9F65218]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF7A9F65230]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L33:
       mov       rcx,offset MT_System.Xml.Serialization.XmlReflectionImporter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       r8,rdi
       xor       edx,edx
       call      qword ptr [7FF7A9CB6E20]; System.Xml.Serialization.XmlReflectionImporter..ctor(System.Xml.Serialization.XmlAttributeOverrides, System.String)
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9,rdi
       xor       r8d,r8d
       call      qword ptr [7FF7A9CB6E80]; System.Xml.Serialization.XmlReflectionImporter.ImportTypeMapping(System.Type, System.Xml.Serialization.XmlRootAttribute, System.String)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+18]
       mov       rdx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FF7A9CBF240]; System.Xml.Serialization.XmlSerializer.GenerateTempAssembly(System.Xml.Serialization.XmlMapping, System.Type, System.String, System.String)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L35
M03_L34:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF7A9D97F60]; System.Xml.Serialization.XmlReflectionImporter.GetTopLevelMapping(System.Type, System.String)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Xml.Serialization.XmlMapping[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       mov       rdx,[rbx+18]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Xml.Serialization.TempAssembly
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,r14
       mov       r9,[rbp-48]
       call      qword ptr [7FF7A9F65248]
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M03_L35:
       mov       r9,[rbx+8]
       mov       rcx,1CA7F000060
       mov       rcx,[rcx]
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FF7A9D2CFC0]; System.Xml.Serialization.TempAssemblyCache.Add(System.String, System.Type, System.Xml.Serialization.TempAssembly)
       nop
       cmp       byte ptr [rbp-40],0
       je        near ptr M03_L13
       mov       rcx,[rbp-90]
       call      qword ptr [7FF7A95A6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M03_L13
M03_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-40],0
       je        short M03_L37
       mov       rcx,[rbp-90]
       call      qword ptr [7FF7A95A6820]; System.Threading.Monitor.Exit(System.Object)
M03_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1748
```
```assembly
; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+18],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rbx,r9
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       cmp       qword ptr [rsi+10],0
       jne       short M04_L02
       mov       rdx,[rsi+18]
       mov       rcx,rdx
       cmp       dword ptr [7FF7A94EB150],1
       je        short M04_L01
       test      rcx,rcx
       je        short M04_L00
       movzx     ecx,byte ptr [rcx+25]
       test      ecx,ecx
       jne       short M04_L01
M04_L00:
       cmp       byte ptr [rsi+31],0
       jne       short M04_L01
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M04_L04
       cmp       byte ptr [rsi+30],0
       jne       near ptr M04_L04
       mov       [rsp+20],rdi
       mov       r8,[rbp+18]
       mov       r9,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9D97FC0]; System.Xml.Serialization.TempAssembly.InvokeReader(System.Xml.Serialization.XmlMapping, System.Xml.XmlReader, System.Xml.Serialization.XmlDeserializationEvents, System.String)
       jmp       near ptr M04_L05
M04_L01:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r8,rdi
       mov       r9,rbx
       call      qword ptr [7FF7A9F678A0]
       jmp       near ptr M04_L05
M04_L02:
       test      rdi,rdi
       je        short M04_L03
       cmp       dword ptr [rdi+8],0
       jle       short M04_L03
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9F65548]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FF7A9F65218]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A9925FE0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L03:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r8,rbx
       call      qword ptr [7FF7A9F65560]
       jmp       short M04_L05
M04_L04:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,[rbp+18]
       mov       r8,rbx
       mov       r9,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9D9C030]; System.Xml.Serialization.XmlSerializationReader.Init(System.Xml.XmlReader, System.Xml.Serialization.XmlDeserializationEvents, System.String)
       mov       rcx,rsi
       mov       rdx,r14
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       nop
M04_L05:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       sub       rsp,28
       mov       rbx,rcx
       test      rbx,rbx
       jne       short M04_L07
M04_L06:
       mov       rdx,[rbp+18]
       mov       rcx,offset MT_System.Xml.IXmlLineInfo
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M04_L09
       jmp       short M04_L08
M04_L07:
       mov       rax,offset MT_System.Reflection.TargetInvocationException
       cmp       [rbx],rax
       jne       short M04_L06
       call      qword ptr [7FF7A95AC2E8]
       mov       rbx,rax
       jmp       short M04_L06
M04_L08:
       call      qword ptr [7FF7A9F655A8]
       mov       rdi,rax
       mov       rcx,rsi
       mov       r11,7FF7A94F1438
       call      qword ptr [r11]
       mov       [rbp-28],eax
       call      qword ptr [7FF7A9BF5278]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7A9D951A0]; System.Int32.ToString(System.IFormatProvider)
       mov       r14,rax
       mov       rcx,rsi
       mov       r11,7FF7A94F1440
       call      qword ptr [r11]
       mov       [rbp-28],eax
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7A9BF5278]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7A9D951A0]; System.Int32.ToString(System.IFormatProvider)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FF7A9F64ED0]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FF7A99B60B8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7A9F655C0]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FF7A99B60B8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L00
       cmp       [rdx],rcx
       jne       short M05_L01
M05_L00:
       mov       rax,rdx
       ret
M05_L01:
       jmp       qword ptr [7FF7A9774D38]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.Xml.XmlTextReaderImpl.Close(Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       cmp       dword ptr [rbx+108],0C
       je        near ptr M06_L06
M06_L00:
       cmp       dword ptr [rbx+13C],0
       jge       near ptr M06_L09
       lea       rdi,[rbx+188]
       test      sil,sil
       je        near ptr M06_L04
       cmp       qword ptr [rdi+10],0
       jne       short M06_L02
       mov       rdi,[rdi+28]
       test      rdi,rdi
       je        short M06_L04
       mov       rcx,offset MT_System.IO.StringReader
       cmp       [rdi],rcx
       jne       near ptr M06_L11
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       [rdi+10],ecx
M06_L01:
       mov       rcx,rdi
       call      qword ptr [7FF7A9775590]; System.GC.SuppressFinalize(System.Object)
       jmp       short M06_L04
M06_L02:
       mov       rsi,[rdi+10]
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.IO.FileStream
       cmp       rdi,rcx
       jne       near ptr M06_L08
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        short M06_L03
       mov       rax,[rcx]
       mov       rdx,offset MT_System.IO.Strategies.BufferedFileStreamStrategy
       cmp       rax,rdx
       je        near ptr M06_L07
       mov       edx,1
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
M06_L03:
       test      dword ptr [rdi],100000
       jne       near ptr M06_L10
M06_L04:
       mov       rcx,1CA7F0006E0
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M06_L12
M06_L05:
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+108],0C
       xor       eax,eax
       mov       [rbx+68],rax
       mov       rax,20AFDF90008
       mov       [rbx+60],rax
       mov       dword ptr [rbx+160],4
       mov       byte ptr [rbx+176],0
       mov       eax,0FFFFFFFF
       mov       [rbx+118],rax
       xor       eax,eax
       mov       [rbx+120],rax
       mov       [rbx+8],rax
M06_L06:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L07:
       mov       edx,1
       call      qword ptr [7FF7A973A888]
       jmp       near ptr M06_L03
M06_L08:
       mov       rcx,rsi
       mov       rax,[rdi+50]
       call      qword ptr [rax+18]
       jmp       near ptr M06_L04
M06_L09:
       mov       rcx,rbx
       call      qword ptr [7FF7A9F65098]
       jmp       near ptr M06_L00
M06_L10:
       mov       rcx,rsi
       call      00007FF809209E50
       jmp       near ptr M06_L04
M06_L11:
       mov       rcx,rdi
       mov       edx,1
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M06_L01
M06_L12:
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl+NodeData
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF7A9F650B0]
       mov       rcx,1CA7F0006E0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M06_L05
; Total bytes of code 435
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

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Xml_PersonRecord()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       mov       [rbp-30],rax
       mov       rbx,rcx
       mov       rcx,[rbx+158]
       mov       rsi,rcx
       test      rsi,rsi
       je        near ptr M00_L14
       mov       ecx,[rsi+8]
       test      ecx,ecx
       je        near ptr M00_L14
       movzx     edx,word ptr [rsi+0C]
       cmp       edx,100
       jl        short M00_L00
       mov       eax,edx
       shr       eax,9
       mov       r8,7FFFFDF96778
       movzx     eax,byte ptr [r8+rax]
       shl       eax,6
       mov       r8d,edx
       shr       r8d,3
       and       r8d,3E
       add       eax,r8d
       mov       r8,7FFFFDF94280
       movzx     eax,word ptr [r8+rax]
       shl       eax,4
       and       edx,0F
       add       edx,eax
       mov       rax,7FFFFDF9C558
       movzx     edx,byte ptr [rax+rdx]
       mov       rax,7FFFFDFA5028
       cmp       byte ptr [rax+rdx],0
       jl        near ptr M00_L16
       jmp       short M00_L01
M00_L00:
       mov       edx,edx
       mov       rax,7FFFFDF96090
       test      byte ptr [rax+rdx],80
       jne       near ptr M00_L16
M00_L01:
       dec       ecx
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jl        short M00_L02
       mov       edx,ecx
       shr       edx,9
       mov       rax,7FFFFDF96778
       movzx     edx,byte ptr [rax+rdx]
       shl       edx,6
       mov       eax,ecx
       shr       eax,3
       and       eax,3E
       add       edx,eax
       mov       rax,7FFFFDF94280
       movzx     edx,word ptr [rax+rdx]
       shl       edx,4
       and       ecx,0F
       add       ecx,edx
       mov       rdx,7FFFFDF9C558
       movzx     ecx,byte ptr [rdx+rcx]
       mov       rdx,7FFFFDFA5028
       cmp       byte ptr [rdx+rcx],0
       jl        near ptr M00_L16
       jmp       short M00_L03
M00_L02:
       mov       ecx,ecx
       mov       rdx,7FFFFDF96090
       test      byte ptr [rdx+rcx],80
       jne       near ptr M00_L16
M00_L03:
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        near ptr M00_L17
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-60],rdi
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,19013C026B8
       mov       r14,[rdx]
       mov       rdx,[r14+10]
       mov       rcx,rsi
       mov       r8,r14
       xor       r9d,r9d
       call      qword ptr [7FF7A9DC7C00]; System.Xml.XmlTextReaderImpl..ctor(System.Xml.XmlResolver, System.Xml.XmlReaderSettings, System.Xml.XmlParserContext)
       mov       rcx,1D0A8B80008
       mov       [rsi+60],rcx
       movzx     ecx,byte ptr [r14+5D]
       mov       [rsi+17D],cl
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl+LaterInitParam
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+44],3
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15,[rsi+8]
       lea       rcx,[r15+38]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+30],rcx
       mov       dword ptr [r15+44],2
       cmp       byte ptr [r14+58],0
       je        short M00_L04
       mov       byte ptr [r15+48],1
       jmp       near ptr M00_L08
M00_L04:
       mov       r14,[rsi+60]
       mov       rdx,[r15+38]
       lea       rcx,[rsi+1B0]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+1B8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+1C0],rcx
       cmp       qword ptr [rsi+188],0
       jne       short M00_L06
       cmp       byte ptr [r15+48],0
       jne       short M00_L05
       lea       r14,[rsi+188]
       mov       rcx,offset MT_System.Char[]
       mov       edx,1001
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rcx,r14
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L06
M00_L05:
       lea       r14,[rsi+188]
       mov       rcx,offset MT_System.Char[]
       mov       edx,8001
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rcx,r14
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L06:
       mov       rcx,19013C02598
       mov       rdx,[rcx]
       lea       rcx,[rsi+190]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       byte ptr [rsi+178],0
       sete      cl
       mov       [rsi+1EF],cl
       mov       byte ptr [rsi+1EC],1
       mov       rcx,rsi
       call      qword ptr [7FF7A9DC7EB8]; System.Xml.XmlTextReaderImpl.ReadData()
       mov       rdx,[rsi+190]
       lea       rcx,[rsi+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M00_L07
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9F94F18]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[rsi+8]
       mov       rdx,[rdx+30]
       mov       rcx,rsi
       call      qword ptr [7FF7A9F94F30]
M00_L07:
       xor       ecx,ecx
       mov       [rsi+8],rcx
M00_L08:
       mov       [rbp-68],rsi
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,1D0A8B91118
       xor       r8d,r8d
       call      qword ptr [7FF7A9CE5DA0]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       vmovdqu   ymm0,ymmword ptr [r14+38]
       vmovdqu   ymmword ptr [rbp-58],ymm0
       mov       r9,[r14+58]
       mov       [rbp-38],r9
       lea       r9,[rbp-58]
       mov       rdx,rsi
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FF7A9DC7F30]; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
       test      rax,rax
       je        short M00_L10
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       cmp       [r14],rcx
       jne       short M00_L09
       jmp       short M00_L11
M00_L09:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L10:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7A9DC7408]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF7A9955FE0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       cmp       dword ptr [rsi+160],4
       je        short M00_L12
       movzx     edx,byte ptr [rsi+17D]
       mov       rcx,rsi
       call      qword ptr [7FF7A9DCCD98]; System.Xml.XmlTextReaderImpl.Close(Boolean)
       nop
M00_L12:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       [rdi+10],ecx
       mov       rsi,[rdi]
       test      dword ptr [rsi],100000
       jne       near ptr M00_L18
M00_L13:
       mov       [rbp-30],r14
       mov       rcx,[rbx+60]
       lea       r8,[rbp-30]
       mov       rdx,7FF7A9E06E30
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9DCCDF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L14:
       call      qword ptr [7FF7A99E4378]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L15
       call      qword ptr [7FF7A9F97558]
       mov       rbx,rax
M00_L15:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1D0A8B91748
       call      qword ptr [7FF7A9E36508]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L16:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FF7A9E35E78]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L17:
       mov       ecx,11
       call      qword ptr [7FF7A95DFD50]
       int       3
M00_L18:
       mov       rcx,rdi
       call      00007FF809209E50
       jmp       near ptr M00_L13
       sub       rsp,28
       mov       rcx,[rbp-68]
       cmp       dword ptr [rcx+160],4
       je        short M00_L19
       movzx     edx,byte ptr [rcx+17D]
       call      qword ptr [7FF7A9DCCD98]; System.Xml.XmlTextReaderImpl.Close(Boolean)
M00_L19:
       nop
       vzeroupper
       add       rsp,28
       ret
       sub       rsp,28
       xor       ecx,ecx
       mov       rax,[rbp-60]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       rsi,[rax]
       test      dword ptr [rsi],100000
       je        short M00_L20
       mov       rcx,rax
       call      00007FF809209E50
M00_L20:
       nop
       vzeroupper
       add       rsp,28
       ret
; Total bytes of code 1249
```
```assembly
; System.Xml.XmlTextReaderImpl..ctor(System.Xml.XmlResolver, System.Xml.XmlReaderSettings, System.Xml.XmlParserContext)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       rbx,rcx
       mov       rbp,rdx
       mov       rsi,r8
       mov       rdi,r9
M01_L00:
       mov       dword ptr [rbx+118],0FFFFFFFF
       mov       r14,1D0A8B80008
       mov       [rbx+38],r14
       mov       byte ptr [rbx+179],1
       mov       dword ptr [rbx+12C],2
       mov       [rbx+48],r14
       mov       dword ptr [rbx+13C],0FFFFFFFF
       mov       [rbx+60],r14
       mov       dword ptr [rbx+140],9
       mov       dword ptr [rbx+158],1
       xor       ecx,ecx
       mov       [rsp+38],ecx
       mov       [rsp+3C],ecx
       mov       [rsp+40],ecx
       mov       byte ptr [rsp+44],0
       lea       rcx,[rsp+38]
       cmp       qword ptr [rcx],0
       je        near ptr M01_L21
M01_L01:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.ValueTuple<System.Int32, System.Int32, System.Int32, System.Boolean>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       edx,edx
       mov       [rsp+48],edx
       mov       [rsp+4C],edx
       mov       [rsp+50],edx
       mov       byte ptr [rsp+54],0
       lea       rdx,[rsp+48]
       mov       rcx,r15
       call      qword ptr [7FF7A9F94FC0]; System.Threading.Tasks.Task`1[[System.ValueTuple`4[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.ValueTuple`4<Int32,Int32,Int32,Boolean>)
       mov       rdx,r15
M01_L02:
       lea       rcx,[rbx+0E0]
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [rsi+58]
       mov       [rbx+174],cl
       mov       byte ptr [rbx+17E],0
       lea       rcx,[rbx+0C8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl+XmlContext
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+20],ecx
       mov       [rax+8],r14
       mov       [rax+10],r14
       mov       [rax+18],rcx
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15,[rsi+8]
       test      rdi,rdi
       jne       near ptr M01_L26
       test      r15,r15
       jne       near ptr M01_L25
       mov       rcx,offset MT_System.Xml.NameTable
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+14],1F
       mov       edx,[r15+14]
       inc       edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Xml.NameTable+Entry[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       lea       rcx,[rbx+28]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Xml.XmlNamespaceManager
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       call      qword ptr [7FF7A9DC7D98]; System.Xml.XmlNamespaceManager..ctor(System.Xml.XmlNameTable)
       lea       rcx,[rbx+40]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M01_L04:
       mov       rcx,offset MT_System.Xml.NameTable
       cmp       [r15],rcx
       jne       near ptr M01_L27
       mov       rcx,[r15+8]
       mov       r13d,[r15+14]
       and       r13d,29B564F0
       mov       eax,r13d
       cmp       eax,[rcx+8]
       jae       near ptr M01_L30
       mov       r12,[rcx+rax*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M01_L07
M01_L05:
       cmp       dword ptr [rcx+18],29B564F0
       je        near ptr M01_L22
M01_L06:
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M01_L05
M01_L07:
       mov       rcx,offset MT_System.Xml.NameTable+Entry
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       rdx,r12
       mov       rcx,1D0A8B91748
       mov       [rax+8],rcx
       mov       dword ptr [rax+18],29B564F0
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r15+8]
       cmp       r13d,[rcx+8]
       jae       near ptr M01_L30
       mov       edx,r13d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r15+10]
       lea       eax,[rcx+1]
       mov       [r15+10],eax
       cmp       ecx,[r15+14]
       je        near ptr M01_L24
M01_L08:
       mov       r13,[rsp+30]
       mov       rdx,[r13+8]
M01_L09:
       lea       rcx,[rbx+0D0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1D0A8B917D4
       mov       eax,7233593D
       mov       edx,8FE54860
       mov       r8d,1
M01_L10:
       add       eax,[rcx]
       mov       r10d,[rcx+4]
       xor       edx,eax
       rol       eax,14
       add       eax,edx
       rol       edx,9
       xor       edx,eax
       rol       eax,1B
       add       eax,edx
       rol       edx,13
       add       r10d,eax
       mov       eax,edx
       xor       eax,r10d
       rol       r10d,14
       add       r10d,eax
       rol       eax,9
       xor       eax,r10d
       rol       r10d,1B
       add       r10d,eax
       rol       eax,13
       mov       edx,r10d
       add       rcx,8
       dec       r8d
       mov       r9d,eax
       mov       eax,edx
       mov       edx,r9d
       jne       short M01_L10
       mov       ecx,[rcx-2]
       shr       ecx,8
       or        ecx,80000000
       shr       ecx,8
       add       ecx,eax
       mov       eax,edx
       xor       eax,ecx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       mov       r13d,ecx
       rol       r13d,14
       add       r13d,eax
       rol       eax,9
       xor       eax,r13d
       rol       r13d,1B
       add       r13d,eax
       mov       r12d,eax
       rol       r12d,13
       xor       r13d,r12d
       mov       rcx,[r15+8]
       mov       r12d,r13d
       and       r12d,[r15+14]
       mov       eax,r12d
       cmp       eax,[rcx+8]
       jae       near ptr M01_L30
       mov       rax,[rcx+rax*8+10]
       mov       rdx,rax
       mov       [rsp+20],rdx
       mov       rcx,rdx
       test      rcx,rcx
       je        short M01_L13
M01_L11:
       cmp       [rcx+18],r13d
       je        near ptr M01_L18
M01_L12:
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M01_L11
M01_L13:
       mov       rcx,offset MT_System.Xml.NameTable+Entry
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       mov       rdx,[rsp+20]
       mov       rcx,1D0A8B917C8
       mov       [rax+8],rcx
       mov       [rax+18],r13d
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r15+8]
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L30
       mov       edx,r12d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r15+10]
       lea       eax,[rcx+1]
       mov       [r15+10],eax
       cmp       ecx,[r15+14]
       je        near ptr M01_L20
M01_L14:
       mov       r15,[rsp+28]
       mov       rdx,[r15+8]
M01_L15:
       lea       rcx,[rbx+0D8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+30]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl+NodeData[]
       mov       edx,8
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl+NodeData
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,[rbx+10]
       mov       rcx,rbp
       xor       edx,edx
       mov       [rax+50],edx
       mov       [rax+8],r14
       mov       [rax+10],r14
       mov       [rax+18],r14
       mov       [rax+20],r14
       mov       [rax+28],r14
       mov       dword ptr [rax+54],0FFFFFFFF
       mov       [rax+40],rdx
       mov       [rax+48],rdx
       mov       byte ptr [rax+67],0
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M01_L30
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       dword ptr [rbp+8],0
       jbe       near ptr M01_L30
       mov       rdx,[rbp+10]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+0B0]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+130],1
       movzx     ecx,byte ptr [rsi+5E]
       mov       [rbx+187],cl
       cmp       byte ptr [rsi+5A],0
       setne     cl
       movzx     ecx,cl
       mov       [rbx+128],ecx
       mov       byte ptr [rbx+178],1
       movzx     ecx,byte ptr [rsi+5B]
       mov       [rbx+17A],cl
       movzx     ecx,byte ptr [rsi+5C]
       mov       [rbx+17B],cl
       movzx     ecx,byte ptr [rsi+59]
       mov       [rbx+17C],cl
       mov       ecx,[rsi+40]
       mov       [rbx+134],ecx
       mov       edx,[rsi+44]
       mov       [rbx+138],edx
       inc       ecx
       mov       [rbx+1E0],ecx
       neg       edx
       dec       edx
       mov       [rbx+1E4],edx
       mov       rdx,[rbx+18]
       dec       ecx
       lea       rax,[rbx+188]
       mov       r8d,[rax+48]
       sub       r8d,[rax+5C]
       dec       r8d
       cmp       [rdx],dl
       add       rdx,68
       mov       [rdx],ecx
       mov       [rdx+4],r8d
       mov       ecx,[rsi+4C]
       mov       [rbx+12C],ecx
       mov       rcx,[rsi+30]
       mov       [rbx+0E8],rcx
       mov       rcx,[rsi+38]
       mov       [rbx+0F0],rcx
       xor       ecx,ecx
       mov       [rbx+0F8],rcx
       mov       [rbx+100],rcx
       lea       rcx,[rbx+78]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,500000004
       mov       [rbx+108],rax
       mov       eax,[rsi+48]
       cmp       eax,2
       jne       near ptr M01_L28
M01_L16:
       mov       dword ptr [rbx+140],9
M01_L17:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L18:
       mov       rax,[rcx+8]
       mov       r8,rax
       mov       r10,1D0A8B917C8
       cmp       r8,r10
       je        short M01_L19
       cmp       dword ptr [r8+8],5
       jne       near ptr M01_L12
       mov       r10,6E006C006D0078
       xor       r10,[r8+0C]
       movzx     r8d,word ptr [r8+14]
       xor       r8d,73
       or        r8,r10
       jne       near ptr M01_L12
M01_L19:
       mov       rdx,rax
       jmp       near ptr M01_L15
M01_L20:
       mov       rcx,r15
       call      qword ptr [7FF7A9DCC060]; System.Xml.NameTable.Grow()
       jmp       near ptr M01_L14
M01_L21:
       lea       rcx,[rsp+40]
       cmp       qword ptr [rcx],0
       jne       near ptr M01_L01
       mov       rdx,19013C026C0
       mov       rdx,[rdx]
       jmp       near ptr M01_L02
M01_L22:
       mov       rdx,[rcx+8]
       mov       rax,rdx
       mov       r8,1D0A8B91748
       cmp       rax,r8
       je        short M01_L23
       cmp       dword ptr [rax+8],3
       jne       near ptr M01_L06
       mov       r8d,[rax+0C]
       xor       r8d,6D0078
       movzx     eax,word ptr [rax+10]
       xor       eax,6C
       or        eax,r8d
       jne       near ptr M01_L06
M01_L23:
       jmp       near ptr M01_L09
M01_L24:
       mov       rcx,r15
       call      qword ptr [7FF7A9DCC060]; System.Xml.NameTable.Grow()
       jmp       near ptr M01_L08
M01_L25:
       mov       byte ptr [rbx+177],1
       jmp       near ptr M01_L03
M01_L26:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FF7A9F94FD8]
       mov       r15,[rbx+28]
       jmp       near ptr M01_L04
M01_L27:
       mov       rcx,r15
       mov       rdx,r14
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,r15
       mov       rdx,1D0A8B91748
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       lea       rcx,[rbx+0D0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,1D0A8B917C8
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       jmp       near ptr M01_L15
M01_L28:
       cmp       eax,2
       ja        near ptr M01_L16
       mov       eax,eax
       lea       rcx,[7FF7AA02D190]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M01_L00]
       add       rcx,rdx
       jmp       rcx
       xor       eax,eax
       mov       [rbx+140],eax
M01_L29:
       mov       byte ptr [rbx+17F],1
       jmp       near ptr M01_L17
       mov       dword ptr [rbx+140],1
       jmp       short M01_L29
M01_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1872
```
```assembly
; System.Xml.XmlTextReaderImpl.ReadData()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
M02_L00:
       cmp       byte ptr [rbx+1ED],0
       jne       near ptr M02_L17
       cmp       byte ptr [rbx+1EC],0
       jne       near ptr M02_L12
       mov       rcx,[rbx+188]
       mov       esi,[rcx+8]
       mov       ecx,esi
       sub       ecx,[rbx+1D4]
       mov       eax,esi
       shr       eax,1
       cmp       ecx,eax
       jle       near ptr M02_L22
M02_L01:
       cmp       qword ptr [rbx+198],0
       jne       near ptr M02_L27
M02_L02:
       mov       rcx,[rbx+188]
       mov       esi,[rcx+8]
       sub       esi,[rbx+1D4]
       dec       esi
M02_L03:
       cmp       qword ptr [rbx+198],0
       jne       near ptr M02_L30
       mov       rsi,[rbx+1B0]
       test      rsi,rsi
       je        near ptr M02_L40
       mov       rdx,[rbx+188]
       mov       rax,rdx
       mov       ecx,[rbx+1D4]
       mov       edi,ecx
       mov       ebp,[rdx+8]
       sub       ebp,ecx
       dec       ebp
       mov       rdx,offset MT_System.IO.StringReader
       cmp       [rsi],rdx
       jne       near ptr M02_L39
       test      edi,edi
       jl        near ptr M02_L33
       test      ebp,ebp
       jl        near ptr M02_L34
       mov       edx,[rax+8]
       sub       edx,edi
       cmp       edx,ebp
       jl        near ptr M02_L35
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M02_L36
       mov       r14d,[rdx+8]
       sub       r14d,[rsi+10]
       test      r14d,r14d
       jle       short M02_L06
       cmp       r14d,ebp
       cmovg     r14d,ebp
       mov       ebp,[rsi+10]
       cmp       [rdx],dl
       test      r14d,r14d
       jl        near ptr M02_L37
       test      ebp,ebp
       jl        near ptr M02_L38
       mov       r15d,[rdx+8]
       sub       r15d,ebp
       cmp       r14d,r15d
       jl        short M02_L04
       cmp       r14d,r15d
       jg        near ptr M02_L15
M02_L04:
       mov       r15d,[rax+8]
       sub       r15d,r14d
       cmp       edi,r15d
       jl        short M02_L05
       cmp       edi,r15d
       jg        near ptr M02_L16
M02_L05:
       mov       ecx,ebp
       lea       rdx,[rdx+rcx*2+0C]
       mov       ecx,edi
       lea       rcx,[rax+rcx*2+10]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FF7A95D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rsi+10],r14d
M02_L06:
       mov       ebp,r14d
M02_L07:
       mov       esi,ebp
       lea       rcx,[rbx+1D4]
       add       [rcx],esi
M02_L08:
       movsxd    rdi,esi
       cmp       dword ptr [rbx+13C],0
       setge     bpl
       movzx     ebp,bpl
       cmp       qword ptr [rbx+0E8],0
       jg        near ptr M02_L41
M02_L09:
       cmp       qword ptr [rbx+0F0],0
       setg      cl
       movzx     ecx,cl
       test      ebp,ecx
       jne       near ptr M02_L44
M02_L10:
       test      esi,esi
       jne       short M02_L11
       mov       byte ptr [rbx+1ED],1
M02_L11:
       mov       rax,[rbx+188]
       mov       ecx,[rbx+1D4]
       cmp       ecx,[rax+8]
       jae       near ptr M02_L47
       mov       word ptr [rax+rcx*2+10],0
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L12:
       mov       ecx,[rbx+1D4]
       mov       rax,[rbx+188]
       mov       eax,[rax+8]
       dec       eax
       cmp       ecx,eax
       je        near ptr M02_L18
M02_L13:
       cmp       qword ptr [rbx+198],0
       jne       near ptr M02_L21
M02_L14:
       mov       rcx,[rbx+188]
       mov       esi,[rcx+8]
       sub       esi,[rbx+1D4]
       dec       esi
       cmp       esi,50
       jle       near ptr M02_L03
       mov       esi,50
       jmp       near ptr M02_L03
M02_L15:
       mov       ecx,167
       mov       rdx,7FF7A9514000
       call      qword ptr [7FF7A95DF228]
       mov       r8,rax
       mov       edx,r15d
       mov       ecx,r14d
       call      qword ptr [7FF7A9F949F0]
       int       3
M02_L16:
       mov       ecx,17F
       mov       rdx,7FF7A9514000
       call      qword ptr [7FF7A95DF228]
       mov       r8,rax
       mov       edx,r15d
       mov       ecx,edi
       call      qword ptr [7FF7A9F949F0]
       int       3
M02_L17:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L18:
       xor       esi,esi
       jmp       short M02_L20
M02_L19:
       mov       rcx,[rbx+10]
       mov       eax,[rbx+114]
       lea       eax,[rax+rsi+1]
       cmp       eax,[rcx+8]
       jae       near ptr M02_L47
       mov       rcx,[rcx+rax*8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9F94EA0]
       inc       esi
M02_L20:
       cmp       esi,[rbx+11C]
       jl        short M02_L19
       mov       rdx,[rbx+188]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       rcx,[rbx+188]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,[rbx+188]
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF7A9865FF8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       lea       rcx,[rbx+188]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L13
M02_L21:
       mov       edx,[rbx+1DC]
       sub       edx,[rbx+1D8]
       cmp       edx,6
       jge       near ptr M02_L14
       mov       rdx,[rbx+1A8]
       mov       edx,[rdx+8]
       sub       edx,[rbx+1DC]
       cmp       edx,6
       jge       near ptr M02_L14
       mov       rdx,[rbx+1A8]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       ecx,[rbx+1DC]
       mov       [rsp+20],ecx
       mov       rcx,[rbx+1A8]
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF7A9865FF8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       lea       rcx,[rbx+1A8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L14
M02_L22:
       xor       edi,edi
       jmp       short M02_L24
M02_L23:
       mov       rcx,[rbx+10]
       mov       eax,[rbx+114]
       lea       eax,[rax+rdi+1]
       cmp       eax,[rcx+8]
       jae       near ptr M02_L47
       mov       rcx,[rcx+rax*8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9F94EA0]
       inc       edi
M02_L24:
       cmp       edi,[rbx+11C]
       jl        short M02_L23
       mov       edi,[rbx+1D4]
       sub       edi,[rbx+1D0]
       dec       esi
       cmp       edi,esi
       jge       short M02_L26
       lea       rdx,[rbx+1E4]
       mov       ecx,[rbx+1D0]
       sub       [rdx],ecx
       test      edi,edi
       jle       short M02_L25
       lea       edx,[rdi+rdi]
       mov       [rsp+20],edx
       mov       edx,[rbx+1D0]
       add       edx,edx
       mov       rcx,[rbx+188]
       mov       r8,[rbx+188]
       xor       r9d,r9d
       call      qword ptr [7FF7A9865FF8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
M02_L25:
       xor       edx,edx
       mov       [rbx+1D0],edx
       mov       [rbx+1D4],edi
       jmp       near ptr M02_L01
M02_L26:
       mov       rdx,[rbx+188]
       mov       edx,[rdx+8]
       add       edx,edx
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       rcx,[rbx+188]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       mov       [rsp+20],ecx
       mov       rcx,[rbx+188]
       mov       r8,rsi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FF7A9865FF8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       lea       rcx,[rbx+188]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L01
M02_L27:
       mov       esi,[rbx+1DC]
       sub       esi,[rbx+1D8]
       cmp       esi,80
       jg        near ptr M02_L02
       test      esi,esi
       jne       short M02_L28
       xor       ecx,ecx
       mov       [rbx+1DC],ecx
       jmp       short M02_L29
M02_L28:
       mov       [rsp+20],esi
       mov       rcx,[rbx+1A8]
       mov       edx,[rbx+1D8]
       mov       r8,[rbx+1A8]
       xor       r9d,r9d
       call      qword ptr [7FF7A9865FF8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rbx+1DC],esi
M02_L29:
       xor       ecx,ecx
       mov       [rbx+1D8],ecx
       jmp       near ptr M02_L02
M02_L30:
       cmp       byte ptr [rbx+1EE],0
       jne       short M02_L32
       mov       ecx,[rbx+1D8]
       cmp       ecx,[rbx+1DC]
       jne       short M02_L32
       mov       rcx,[rbx+1A8]
       mov       ecx,[rcx+8]
       sub       ecx,[rbx+1DC]
       test      ecx,ecx
       jle       short M02_L32
       mov       rcx,[rbx+198]
       mov       r9,[rbx+1A8]
       mov       r9d,[r9+8]
       sub       r9d,[rbx+1DC]
       mov       r8d,[rbx+1DC]
       mov       rdx,[rbx+1A8]
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L31
       mov       byte ptr [rbx+1EE],1
M02_L31:
       lea       rcx,[rbx+1DC]
       add       [rcx],eax
M02_L32:
       mov       edi,[rbx+1D8]
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF7A9F94ED0]
       mov       esi,eax
       test      esi,esi
       jne       near ptr M02_L08
       cmp       [rbx+1D8],edi
       je        near ptr M02_L08
       jmp       near ptr M02_L00
M02_L33:
       mov       ecx,13CB6
       mov       rdx,7FF7A9514000
       call      qword ptr [7FF7A95DF228]
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF7A9E358F0]
       int       3
M02_L34:
       mov       ecx,28F
       mov       rdx,7FF7A9514000
       call      qword ptr [7FF7A95DF228]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FF7A9E358F0]
       int       3
M02_L35:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7A9E36FE8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF7A9954198]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L36:
       call      qword ptr [7FF7A9F94EE8]
       int       3
M02_L37:
       mov       ecx,28F
       mov       rdx,7FF7A9514000
       call      qword ptr [7FF7A95DF228]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7A9E358F0]
       int       3
M02_L38:
       mov       ecx,167
       mov       rdx,7FF7A9514000
       call      qword ptr [7FF7A95DF228]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FF7A9E358F0]
       int       3
M02_L39:
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8d,edi
       mov       r9d,ebp
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       esi,eax
       mov       ebp,esi
       jmp       near ptr M02_L07
M02_L40:
       xor       esi,esi
       jmp       near ptr M02_L08
M02_L41:
       mov       r14,rdi
       add       r14,[rbx+0F8]
       cmp       r14,[rbx+0F8]
       jge       short M02_L42
       mov       rcx,1D0A8B9B518
       call      qword ptr [7FF7A9F948E8]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,1D0A8B9B550
       call      qword ptr [7FF7A9F94F00]
       jmp       short M02_L43
M02_L42:
       mov       [rbx+0F8],r14
M02_L43:
       mov       rcx,[rbx+0F8]
       cmp       rcx,[rbx+0E8]
       jle       near ptr M02_L09
       mov       rcx,1D0A8B9B518
       call      qword ptr [7FF7A9F948E8]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,1D0A8B9B550
       call      qword ptr [7FF7A9F94F00]
       jmp       near ptr M02_L09
M02_L44:
       add       rdi,[rbx+100]
       cmp       rdi,[rbx+100]
       jge       short M02_L45
       mov       rcx,1D0A8B9B518
       call      qword ptr [7FF7A9F948E8]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,1D0A8B9B598
       call      qword ptr [7FF7A9F94F00]
       jmp       short M02_L46
M02_L45:
       mov       [rbx+100],rdi
M02_L46:
       mov       rcx,[rbx+100]
       cmp       rcx,[rbx+0F0]
       jle       near ptr M02_L10
       mov       rcx,1D0A8B9B518
       call      qword ptr [7FF7A9F948E8]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,1D0A8B9B598
       call      qword ptr [7FF7A9F94F00]
       jmp       near ptr M02_L10
M02_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1855
```
```assembly
; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
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
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        near ptr M03_L19
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M03_L20
M03_L00:
       mov       rcx,19013C02030
       mov       r14,[rcx]
       mov       r15,[r14+8]
       mov       r13d,[r15+8]
       cmp       qword ptr [r14+20],0
       jne       short M03_L01
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,[r14+20]
       mov       rdx,rsi
       mov       r11,7FF7A95214B0
       call      qword ptr [r11]
M03_L02:
       mov       r12d,eax
       and       r12d,7FFFFFFF
       imul      eax,r12d,65
       dec       r13d
       xor       edx,edx
       div       r13d
       lea       r13d,[rdx+1]
       xor       r8d,r8d
       mov       [rbp-4C],r8d
       mov       eax,r12d
       xor       edx,edx
       div       dword ptr [r15+8]
       mov       eax,edx
M03_L03:
       xor       ecx,ecx
       mov       [rbp-58],ecx
       mov       ecx,eax
       lea       r10,[rcx+rcx*2]
       mov       [rbp-80],r10
M03_L04:
       mov       ecx,[r14+38]
       mov       [rbp-50],eax
       cmp       eax,[r15+8]
       jae       near ptr M03_L36
       lea       rdx,[r15+r10*8+10]
       mov       r9,[rdx]
       mov       r11,[rdx+8]
       mov       [rbp-98],r11
       mov       edx,[rdx+10]
       mov       [rbp-74],edx
       cmp       byte ptr [r14+3C],0
       jne       near ptr M03_L21
       cmp       ecx,[r14+38]
       jne       near ptr M03_L21
       test      r9,r9
       je        short M03_L06
       mov       ecx,edx
       and       ecx,7FFFFFFF
       movsxd    rcx,ecx
       mov       r10d,r12d
       cmp       rcx,r10
       je        near ptr M03_L16
M03_L05:
       mov       eax,[rbp-50]
       mov       ecx,r13d
       add       rax,rcx
       mov       ecx,[r15+8]
       cqo
       idiv      rcx
       mov       eax,edx
       mov       ecx,eax
       cmp       dword ptr [rbp-74],0
       jl        near ptr M03_L18
M03_L06:
       xor       edx,edx
M03_L07:
       mov       r14,rdx
       test      r14,r14
       je        short M03_L08
       mov       rcx,offset MT_System.Xml.Serialization.TypeDesc
       cmp       [r14],rcx
       jne       near ptr M03_L25
M03_L08:
       test      r14,r14
       jne       near ptr M03_L26
M03_L09:
       xor       r14d,r14d
M03_L10:
       lea       rcx,[rbx+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+18],0
       jne       near ptr M03_L27
       cmp       dword ptr [7FF7A951B150],1
       je        near ptr M03_L15
       mov       rcx,19013C02058
       mov       r14,[rcx]
       mov       rcx,offset MT_System.Xml.Serialization.TempAssemblyCacheKey
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[r14+10]
       cmp       qword ptr [r13+8],0
       je        near ptr M03_L30
       mov       r12,[r13+18]
       mov       rcx,r12
       mov       rdx,r15
       mov       r11,7FF7A95214C0
       call      qword ptr [r11]
       mov       [rbp-6C],eax
       mov       rdx,[r13+8]
       mov       ecx,eax
       imul      rcx,[r13+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M03_L36
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       edx,[rdx]
       mov       r13,[r13+10]
       xor       r10d,r10d
       mov       [rbp-70],r10d
       dec       edx
       cmp       [r13+8],edx
       jbe       near ptr M03_L30
M03_L11:
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r13+rdx*8+10]
       mov       [rbp-90],r9
       cmp       [r9+10],eax
       jne       near ptr M03_L29
       mov       rdx,[r9]
       mov       rcx,r12
       mov       r8,r15
       mov       r11,7FF7A95214C8
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-90]
       je        near ptr M03_L29
       add       r9,8
M03_L12:
       test      r9,r9
       je        near ptr M03_L31
       mov       rcx,[r9]
       mov       [rbp-60],rcx
M03_L13:
       mov       rdx,[rbp-60]
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+8],0
       je        near ptr M03_L32
M03_L14:
       cmp       qword ptr [rbx+18],0
       jne       short M03_L15
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF7A9DC7F18]; System.Xml.Serialization.XmlReflectionImporter.GetTopLevelMapping(System.Type, System.String)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M03_L15:
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
M03_L16:
       cmp       [r14+8],r9
       je        near ptr M03_L05
       cmp       r9,rsi
       jne       near ptr M03_L22
M03_L17:
       mov       r11,[rbp-98]
       mov       rdx,r11
       jmp       near ptr M03_L07
M03_L18:
       mov       r8d,[rbp-4C]
       inc       r8d
       cmp       [r15+8],r8d
       mov       [rbp-4C],r8d
       mov       eax,ecx
       jg        near ptr M03_L03
       jmp       near ptr M03_L06
M03_L19:
       mov       ecx,0EBC1
       mov       rdx,7FF7A9C4A668
       call      qword ptr [7FF7A95DF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9E35920]
       int       3
M03_L20:
       mov       rcx,rdi
       mov       rdx,1D0A8B80008
       call      qword ptr [7FF7A95D6E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       near ptr M03_L00
       jmp       near ptr M03_L09
M03_L21:
       lea       rcx,[rbp-58]
       mov       edx,14
       call      qword ptr [7FF7A9F94D50]
       mov       eax,[rbp-50]
       mov       r10,[rbp-80]
       jmp       near ptr M03_L04
M03_L22:
       cmp       qword ptr [r14+20],0
       je        short M03_L23
       mov       rcx,[r14+20]
       mov       r8,rsi
       mov       rdx,r9
       mov       r11,7FF7A95214B8
       call      qword ptr [r11]
       jmp       short M03_L24
M03_L23:
       mov       rcx,r9
       mov       rdx,rsi
       mov       r10,[r9]
       mov       r10,[r10+40]
       call      qword ptr [r10+10]
M03_L24:
       test      eax,eax
       je        near ptr M03_L05
       jmp       near ptr M03_L17
M03_L25:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L26:
       mov       rcx,offset MT_System.Xml.Serialization.ElementAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,[r14+38]
       mov       rdx,[rcx+48]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Xml.Serialization.XmlTypeMapping
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       r8,r15
       xor       edx,edx
       mov       r9d,3
       call      qword ptr [7FF7A9F95020]
       mov       rcx,rsi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF7A9CEF0A8]; System.Xml.Serialization.XmlMapping.GenerateKey(System.Type, System.Xml.Serialization.XmlRootAttribute, System.String)
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L10
M03_L27:
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L15
M03_L28:
       cmp       [r13+8],edx
       mov       [rbp-70],r10d
       mov       eax,[rbp-6C]
       jbe       short M03_L30
       jmp       near ptr M03_L11
M03_L29:
       mov       edx,[r9+14]
       mov       r10d,[rbp-70]
       inc       r10d
       cmp       [r13+8],r10d
       jae       short M03_L28
       call      qword ptr [7FF7A95DF498]
       int       3
M03_L30:
       xor       r9d,r9d
       jmp       near ptr M03_L12
M03_L31:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       r14,[r14+8]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       rdx,rax
       mov       rcx,r14
       lea       r8,[rbp-68]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9CE6610]; System.Runtime.CompilerServices.ConditionalWeakTable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M03_L13
       lea       r8,[rbp-60]
       mov       rcx,[rbp-68]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF7A961AC10]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       jmp       near ptr M03_L13
M03_L32:
       mov       rdx,19013C02058
       mov       rcx,[rdx]
       mov       [rbp-88],rcx
       xor       edx,edx
       mov       [rbp-40],edx
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-88]
       call      qword ptr [7FF7A95D5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,19013C02058
       mov       rcx,[rcx]
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FF7A9CE65F8]; System.Xml.Serialization.TempAssemblyCache.get_Item(System.String, System.Type)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+8],0
       jne       near ptr M03_L35
       xor       r8d,r8d
       mov       [rbp-48],r8
       lea       r8,[rbp-48]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF7A9CE6628]; System.Xml.Serialization.TempAssembly.LoadGeneratedAssembly(System.Type, System.String, System.Xml.Serialization.XmlSerializerImplementation ByRef)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M03_L34
       cmp       dword ptr [7FF7A951B150],3
       jne       short M03_L33
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FF7A9CE6868]; System.Xml.Serialization.Compiler.GetTempAssemblyName(System.Reflection.AssemblyName, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.IO.FileLoadException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7A9F95050]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF7A9F95068]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF7A9F95080]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L33:
       mov       rcx,offset MT_System.Xml.Serialization.XmlReflectionImporter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       r8,rdi
       xor       edx,edx
       call      qword ptr [7FF7A9CE6E80]; System.Xml.Serialization.XmlReflectionImporter..ctor(System.Xml.Serialization.XmlAttributeOverrides, System.String)
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9,rdi
       xor       r8d,r8d
       call      qword ptr [7FF7A9CE6EE0]; System.Xml.Serialization.XmlReflectionImporter.ImportTypeMapping(System.Type, System.Xml.Serialization.XmlRootAttribute, System.String)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+18]
       mov       rdx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FF7A9CEF2A0]; System.Xml.Serialization.XmlSerializer.GenerateTempAssembly(System.Xml.Serialization.XmlMapping, System.Type, System.String, System.String)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L35
M03_L34:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF7A9DC7F18]; System.Xml.Serialization.XmlReflectionImporter.GetTopLevelMapping(System.Type, System.String)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Xml.Serialization.XmlMapping[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       mov       rdx,[rbx+18]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Xml.Serialization.TempAssembly
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,r14
       mov       r9,[rbp-48]
       call      qword ptr [7FF7A9F95098]
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M03_L35:
       mov       r9,[rbx+8]
       mov       rcx,19013C02058
       mov       rcx,[rcx]
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FF7A9D5D050]; System.Xml.Serialization.TempAssemblyCache.Add(System.String, System.Type, System.Xml.Serialization.TempAssembly)
       nop
       cmp       byte ptr [rbp-40],0
       je        near ptr M03_L14
       mov       rcx,[rbp-88]
       call      qword ptr [7FF7A95D6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M03_L14
M03_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-40],0
       je        short M03_L37
       mov       rcx,[rbp-88]
       call      qword ptr [7FF7A95D6820]; System.Threading.Monitor.Exit(System.Object)
M03_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1749
```
```assembly
; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+18],rdx
       mov       rsi,rcx
       mov       rdi,r8
       mov       rbx,r9
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       cmp       qword ptr [rsi+10],0
       jne       short M04_L02
       mov       rdx,[rsi+18]
       mov       rcx,rdx
       cmp       dword ptr [7FF7A951B150],1
       je        short M04_L01
       test      rcx,rcx
       je        short M04_L00
       movzx     ecx,byte ptr [rcx+25]
       test      ecx,ecx
       jne       short M04_L01
M04_L00:
       cmp       byte ptr [rsi+31],0
       jne       short M04_L01
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M04_L04
       cmp       byte ptr [rsi+30],0
       jne       near ptr M04_L04
       mov       [rsp+20],rdi
       mov       r8,[rbp+18]
       mov       r9,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9DC7F78]; System.Xml.Serialization.TempAssembly.InvokeReader(System.Xml.Serialization.XmlMapping, System.Xml.XmlReader, System.Xml.Serialization.XmlDeserializationEvents, System.String)
       jmp       near ptr M04_L05
M04_L01:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r8,rdi
       mov       r9,rbx
       call      qword ptr [7FF7A9F97900]
       jmp       near ptr M04_L05
M04_L02:
       test      rdi,rdi
       je        short M04_L03
       cmp       dword ptr [rdi+8],0
       jle       short M04_L03
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9F953F8]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FF7A9F95068]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A9955FE0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L03:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r8,rbx
       call      qword ptr [7FF7A9F95410]
       jmp       short M04_L05
M04_L04:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,[rbp+18]
       mov       r8,rbx
       mov       r9,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9DC7FD8]; System.Xml.Serialization.XmlSerializationReader.Init(System.Xml.XmlReader, System.Xml.Serialization.XmlDeserializationEvents, System.String)
       mov       rcx,rsi
       mov       rdx,r14
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       nop
M04_L05:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       sub       rsp,28
       mov       rbx,rcx
       test      rbx,rbx
       jne       short M04_L07
M04_L06:
       mov       rdx,[rbp+18]
       mov       rcx,offset MT_System.Xml.IXmlLineInfo
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M04_L09
       jmp       short M04_L08
M04_L07:
       mov       rax,offset MT_System.Reflection.TargetInvocationException
       cmp       [rbx],rax
       jne       short M04_L06
       call      qword ptr [7FF7A95DC2E8]
       mov       rbx,rax
       jmp       short M04_L06
M04_L08:
       call      qword ptr [7FF7A9F95458]
       mov       rdi,rax
       mov       rcx,rsi
       mov       r11,7FF7A9521438
       call      qword ptr [r11]
       mov       [rbp-28],eax
       call      qword ptr [7FF7A9C252D8]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7A9DC5230]; System.Int32.ToString(System.IFormatProvider)
       mov       r14,rax
       mov       rcx,rsi
       mov       r11,7FF7A9521440
       call      qword ptr [r11]
       mov       [rbp-28],eax
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7A9C252D8]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7A9DC5230]; System.Int32.ToString(System.IFormatProvider)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FF7A9F95218]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FF7A99E60B8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7A9F95470]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FF7A99E60B8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L00
       cmp       [rdx],rcx
       jne       short M05_L01
M05_L00:
       mov       rax,rdx
       ret
M05_L01:
       jmp       qword ptr [7FF7A97A4D38]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.Xml.XmlTextReaderImpl.Close(Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       cmp       dword ptr [rbx+108],0C
       je        near ptr M06_L06
M06_L00:
       cmp       dword ptr [rbx+13C],0
       jge       near ptr M06_L09
       lea       rdi,[rbx+188]
       test      sil,sil
       je        near ptr M06_L04
       cmp       qword ptr [rdi+10],0
       jne       short M06_L02
       mov       rdi,[rdi+28]
       test      rdi,rdi
       je        short M06_L04
       mov       rcx,offset MT_System.IO.StringReader
       cmp       [rdi],rcx
       jne       near ptr M06_L11
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       [rdi+10],ecx
M06_L01:
       mov       rcx,rdi
       call      qword ptr [7FF7A97A5590]; System.GC.SuppressFinalize(System.Object)
       jmp       short M06_L04
M06_L02:
       mov       rsi,[rdi+10]
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.IO.FileStream
       cmp       rdi,rcx
       jne       near ptr M06_L08
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        short M06_L03
       mov       rax,[rcx]
       mov       rdx,offset MT_System.IO.Strategies.BufferedFileStreamStrategy
       cmp       rax,rdx
       je        near ptr M06_L07
       mov       edx,1
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
M06_L03:
       test      dword ptr [rdi],100000
       jne       near ptr M06_L10
M06_L04:
       mov       rcx,19013C026D8
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M06_L12
M06_L05:
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+108],0C
       xor       eax,eax
       mov       [rbx+68],rax
       mov       rax,1D0A8B80008
       mov       [rbx+60],rax
       mov       dword ptr [rbx+160],4
       mov       byte ptr [rbx+176],0
       mov       eax,0FFFFFFFF
       mov       [rbx+118],rax
       xor       eax,eax
       mov       [rbx+120],rax
       mov       [rbx+8],rax
M06_L06:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L07:
       mov       edx,1
       call      qword ptr [7FF7A976A888]
       jmp       near ptr M06_L03
M06_L08:
       mov       rcx,rsi
       mov       rax,[rdi+50]
       call      qword ptr [rax+18]
       jmp       near ptr M06_L04
M06_L09:
       mov       rcx,rbx
       call      qword ptr [7FF7A9F95980]
       jmp       near ptr M06_L00
M06_L10:
       mov       rcx,rsi
       call      00007FF809209E50
       jmp       near ptr M06_L04
M06_L11:
       mov       rcx,rdi
       mov       edx,1
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M06_L01
M06_L12:
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl+NodeData
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF7A9F95998]
       mov       rcx,19013C026D8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M06_L05
; Total bytes of code 435
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

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_JsonSerializer_Generator_Person_List()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       vzeroupper
       lea       rbp,[rsp+120]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0E0],ymm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+150]
       mov       [rbp-0A0],r8
       mov       rbx,22DCDBCA820
       mov       [rbp-0F8],rbx
       mov       rax,1ED38C02740
       mov       rax,[rax]
       mov       [rbp-0A8],rax
       test      r8,r8
       je        short M00_L00
       mov       rcx,r8
       call      qword ptr [7FF7A97A61D8]; System.Object.GetType()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A951A610]; System.RuntimeType.IsAssignableFrom(System.Type)
       test      eax,eax
       mov       rbx,[rbp-0F8]
       mov       r8,[rbp-0A0]
       je        near ptr M00_L27
M00_L00:
       mov       rax,[rbp-0A8]
       mov       rsi,[rax+8]
       test      rsi,rsi
       je        near ptr M00_L30
M00_L01:
       mov       [rbp-0B0],rsi
       mov       rsi,[rbp-0B0]
       cmp       [rsi],sil
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdx,7FF8091FF0F0
       call      rdx
       movzx     ebx,al
       cmp       dword ptr [7FF809513A10],0
       jne       near ptr M00_L31
M00_L02:
       cmp       ebx,0F
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,7FF8091FF0F0
       call      rax
       movzx     ebx,al
       mov       rsi,[rbp-0F8]
       cmp       dword ptr [7FF809513A10],0
       jne       near ptr M00_L32
M00_L03:
       cmp       ebx,10
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       ecx,[rcx]
       and       ecx,80001000
       cmp       ecx,1000
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L39
M00_L04:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M00_L36
       mov       [rbp-0B8],rsi
       mov       rcx,[rsi+18]
       mov       rax,7FF8091FF0F0
       call      rax
       movzx     ebx,al
       mov       rsi,[rbp-0B8]
       cmp       dword ptr [7FF809513A10],0
       jne       near ptr M00_L34
M00_L05:
       cmp       ebx,1D
       ja        short M00_L06
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M00_L35
M00_L06:
       cmp       ebx,10
       sete      dil
       movzx     edi,dil
M00_L07:
       test      edi,edi
       jne       near ptr M00_L33
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M00_L37
M00_L08:
       test      rsi,rsi
       je        near ptr M00_L38
       mov       rcx,rsi
       call      00007FF809203260
       test      eax,eax
       jne       near ptr M00_L39
       mov       rsi,[rbp-0B0]
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L66
       mov       rbx,[rsi+8]
       test      rbx,rbx
       je        near ptr M00_L40
M00_L09:
       mov       rsi,[rbx+8]
       mov       rcx,1ED38C01968
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L41
M00_L10:
       mov       [rbp-0C0],rsi
       cmp       [rsi],sil
       mov       r14,[rsi+8]
       mov       rcx,[r14+8]
       cmp       byte ptr [rsi+19],0
       jne       near ptr M00_L22
       mov       rdx,22DCDBCA820
       mov       r11,7FF7A95211B0
       call      qword ptr [r11]
       mov       esi,eax
M00_L11:
       mov       r15,[r14+8]
       mov       rcx,[r14+10]
       mov       edx,esi
       imul      rdx,[r14+28]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M00_L75
       mov       edx,edx
       mov       r13,[rcx+rdx*8+10]
       test      r13,r13
       je        near ptr M00_L44
M00_L12:
       cmp       esi,[r13+20]
       jne       near ptr M00_L23
       mov       r12,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r15],rcx
       jne       near ptr M00_L43
       test      r12,r12
       je        near ptr M00_L23
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M00_L42
       mov       rcx,22DCDBCA820
       cmp       r12,rcx
       sete      al
       movzx     eax,al
M00_L13:
       test      eax,eax
       je        near ptr M00_L23
       mov       rdx,[r13+10]
       mov       [rbp-0C8],rdx
M00_L14:
       mov       rcx,[rbp-0C8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       near ptr M00_L64
       mov       rcx,[rbp-0C8]
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        short M00_L15
       cmp       byte ptr [rbx+119],2
       jne       near ptr M00_L65
M00_L15:
       test      rbx,rbx
       je        near ptr M00_L67
       cmp       byte ptr [rbx+119],2
       jne       near ptr M00_L71
M00_L16:
       mov       rsi,[rbx+0B8]
       lea       rdx,[rbp-58]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9C27900]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       esi,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M00_L72
       mov       rcx,[rcx+240]
       mov       rdi,[rcx+48]
       test      rdi,rdi
       je        near ptr M00_L72
M00_L17:
       mov       rax,[rdi+10]
       test      rax,rax
       jne       short M00_L18
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,22DCDBB6D78
       mov       [rax+18],rcx
       xor       ecx,ecx
       mov       [rax+20],rcx
       mov       byte ptr [rax+28],1
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r14
M00_L18:
       mov       ecx,[rax+18]
       lea       edx,[rcx+1]
       mov       [rax+18],edx
       test      ecx,ecx
       jne       near ptr M00_L24
       mov       rcx,[rax+8]
       mov       [rbp-0E8],rcx
       mov       r14,[rax+10]
       mov       rcx,[rbp-0E8]
       cmp       [rcx],cl
       mov       rcx,[rbp-0E8]
       add       rcx,18
       mov       rdx,[rcx]
       mov       edx,[rdx+8]
       sub       edx,[rcx+0C]
       cmp       edx,esi
       jl        near ptr M00_L28
M00_L19:
       lea       rcx,[r14+8]
       mov       rdx,[rbp-0E8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-58]
       mov       esi,[rbp-50]
       mov       edi,[rbp-4C]
       lea       rcx,[r14+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+78],esi
       mov       [r14+7C],edi
       mov       ecx,9
       mov       eax,20
       test      byte ptr [r14+7C],8
       cmove     ecx,eax
       mov       [r14+3C],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        near ptr M00_L29
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L20:
       mov       [r14+2C],eax
       test      dil,4
       jne       near ptr M00_L73
       mov       rsi,22DCDBB1718
M00_L21:
       mov       ecx,[rsi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+78],0
       jne       near ptr M00_L26
       mov       dword ptr [r14+78],3E8
       jmp       near ptr M00_L26
M00_L22:
       mov       rcx,22DCDBCA820
       mov       rax,[7FF7A951A1C0]
       call      qword ptr [rax+18]
       mov       esi,eax
       jmp       near ptr M00_L11
M00_L23:
       mov       r13,[r13+18]
       test      r13,r13
       jne       near ptr M00_L12
       jmp       near ptr M00_L44
M00_L24:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      esi,esi
       je        near ptr M00_L74
       mov       rcx,1ED38C01E10
       mov       rcx,[rcx]
       mov       edx,esi
       call      qword ptr [7FF7A9C49A28]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
M00_L25:
       mov       [rbp-70],rax
       lea       rcx,[rdi+18]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+20],rcx
       mov       byte ptr [rdi+28],1
       mov       [rbp-0E8],rdi
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdx,[rbp-58]
       mov       rcx,r14
       call      qword ptr [7FF7A9C27A50]; System.Text.Json.Utf8JsonWriter.SetOptions(System.Text.Json.JsonWriterOptions)
M00_L26:
       mov       [rbp-0F0],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,[rbp-0A0]
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r9,[rbp-0E8]
       cmp       [r9],r9b
       mov       rdx,[rbp-0E8]
       add       rdx,18
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-80],xmm0
       mov       r9d,[rdx+0C]
       mov       r8d,[rdx+8]
       sub       r9d,r8d
       mov       rdx,[rdx]
       lea       rcx,[rbp-80]
       call      qword ptr [7FF7A9C2F918]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rcx,[rbp-80]
       mov       eax,[rbp-78]
       mov       [rbp-98],rcx
       mov       [rbp-90],eax
       lea       rcx,[rbp-98]
       call      qword ptr [7FF7A9B56040]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rbx,rax
       mov       rcx,r14
       mov       rdx,[rbp-0E8]
       call      qword ptr [7FF7A9C2F930]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       [rbp-88],rbx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-88]
       mov       rdx,7FF7A9E09288
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9DCD998]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,0E8
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
       mov       rdx,r8
       mov       rcx,rbx
       call      qword ptr [7FF7A9F94C18]
       int       3
M00_L28:
       mov       edx,esi
       call      qword ptr [7FF7A9C27990]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L19
M00_L29:
       mov       eax,2
       jmp       near ptr M00_L20
M00_L30:
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF7A99E4DF8]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,[rbp-0A8]
       call      qword ptr [7FF7A9D5EE98]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FF7A9F94D80]
       mov       rdx,[rbp-0A8]
       lea       rcx,[rdx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L31:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L02
M00_L32:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L03
M00_L33:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rsi,rax
       jmp       near ptr M00_L04
M00_L34:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L05
M00_L35:
       mov       edi,1
       jmp       near ptr M00_L07
M00_L36:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       near ptr M00_L07
M00_L37:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rsi,rax
       jmp       near ptr M00_L08
M00_L38:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9EB6E98]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF7A9EB6EB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L39:
       mov       ecx,3C7C
       mov       rdx,7FF7A9A22F00
       call      qword ptr [7FF7A95DF228]
       mov       rcx,rax
       mov       rdx,22DCDBCA820
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF7A9F94D98]
       int       3
M00_L40:
       mov       rcx,rsi
       call      qword ptr [7FF7A99ECDC8]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M00_L09
M00_L41:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FF7A951D110
       call      qword ptr [7FF7A95D7180]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,1ED38C01968
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L10
M00_L42:
       mov       rcx,r12
       mov       rdx,22DCDBCA820
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L13
M00_L43:
       mov       rcx,r15
       mov       r8,22DCDBCA820
       mov       rdx,r12
       mov       r11,7FF7A95211B8
       call      qword ptr [r11]
       jmp       near ptr M00_L13
M00_L44:
       xor       edx,edx
       mov       [rbp-0C8],rdx
       mov       [rbp-0D0],r14
       mov       rdx,22DCDBCA820
       mov       r8,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       [rbp-0E0],rax
       mov       rbx,[r14+8]
       jmp       near ptr M00_L59
M00_L45:
       mov       rcx,[rbp-0D8]
       mov       ecx,[rcx+8]
       cmp       [rbp-3C],ecx
       jae       near ptr M00_L54
       mov       rcx,[rbp-0D8]
       mov       eax,[rbp-3C]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       short M00_L46
       xor       ecx,ecx
       call      qword ptr [7FF7A9EB62B0]
       int       3
M00_L46:
       mov       rcx,r14
       call      00007FF809262D60
       test      eax,eax
       jne       short M00_L47
       mov       rcx,r14
       call      qword ptr [7FF7A9EB7060]
M00_L47:
       mov       dword ptr [rbp-48],1
       mov       rcx,[rbp-0D0]
       mov       rax,[rbp-0C0]
       cmp       rcx,[rax+8]
       je        short M00_L50
       mov       rcx,[rax+8]
       mov       [rbp-0D0],rcx
       mov       rcx,[rbp-0D0]
       cmp       rbx,[rcx+8]
       je        near ptr M00_L58
       mov       rcx,[rbp-0D0]
       mov       rbx,[rcx+8]
       cmp       byte ptr [rax+19],0
       jne       short M00_L48
       mov       rcx,rbx
       mov       rdx,22DCDBCA820
       mov       r11,7FF7A95211C8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L49
M00_L48:
       mov       rcx,22DCDBCA820
       mov       rdx,[7FF7A951A1C0]
       call      qword ptr [rdx+18]
       mov       esi,eax
M00_L49:
       mov       rax,[rbp-0C0]
       jmp       near ptr M00_L58
M00_L50:
       xor       r14d,r14d
       mov       r15,[rdi]
       test      r15,r15
       je        short M00_L56
M00_L51:
       cmp       esi,[r15+20]
       jne       short M00_L52
       mov       rdx,[r15+8]
       mov       rcx,rbx
       mov       r8,22DCDBCA820
       mov       r11,7FF7A95211D0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0C0]
       jne       short M00_L53
M00_L52:
       inc       r14d
       mov       r15,[r15+18]
       test      r15,r15
       jne       short M00_L51
       jmp       short M00_L56
M00_L53:
       mov       rcx,[r15+10]
       mov       [rbp-0C8],rcx
       jmp       near ptr M00_L61
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L56:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13,[rdi]
       mov       rcx,22DCDBCA820
       mov       [r15+8],rcx
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0E0]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+20],esi
       mov       rcx,rdi
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0D0]
       mov       rdx,[rdx+20]
       mov       ecx,[rdx+8]
       cmp       [rbp-3C],ecx
       jae       short M00_L54
       mov       ecx,[rbp-3C]
       lea       rdx,[rdx+rcx*4+10]
       mov       ecx,[rdx]
       add       ecx,1
       jo        short M00_L55
       mov       [rdx],ecx
       mov       rdx,[rbp-0D0]
       mov       rdx,[rdx+20]
       mov       ecx,[rdx+8]
       cmp       [rbp-3C],ecx
       jae       near ptr M00_L54
       mov       ecx,[rbp-3C]
       mov       edx,[rdx+rcx*4+10]
       mov       ecx,1
       mov       rax,[rbp-0C0]
       cmp       edx,[rax+10]
       cmovle    ecx,[rbp-40]
       mov       [rbp-40],ecx
       cmp       r14d,64
       jbe       short M00_L57
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FF7A95D6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       ecx,1
       test      rax,rax
       cmove     ecx,[rbp-44]
       mov       [rbp-44],ecx
M00_L57:
       call      M00_L76
       jmp       near ptr M00_L62
M00_L58:
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-3C]
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L60
       mov       rcx,r14
       call      00007FF809262C80
       test      eax,eax
       je        short M00_L59
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF7A9EB6E80]
M00_L59:
       mov       rax,[rbp-0D0]
       mov       rax,[rax+18]
       mov       [rbp-0D8],rax
       mov       rax,[rbp-0D0]
       mov       rcx,[rax+10]
       mov       rax,[rbp-0D0]
       mov       r8d,esi
       imul      r8,[rax+28]
       shr       r8,20
       inc       r8
       mov       r10d,[rcx+8]
       imul      r8,r10
       shr       r8,20
       mov       rax,[rbp-0D0]
       mov       r10,[rax+18]
       mov       eax,r8d
       xor       edx,edx
       div       dword ptr [r10+8]
       mov       [rbp-3C],edx
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L75
       mov       eax,r8d
       lea       rdi,[rcx+rax*8+10]
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       [rbp-44],ecx
       mov       [rbp-48],ecx
       jmp       near ptr M00_L45
M00_L60:
       xor       ecx,ecx
       call      qword ptr [7FF7A9EB62B0]
       int       3
M00_L61:
       call      M00_L76
       jmp       near ptr M00_L14
M00_L62:
       mov       ecx,[rbp-40]
       or        ecx,[rbp-44]
       je        short M00_L63
       mov       rcx,[rbp-0C0]
       mov       rdx,[rbp-0D0]
       mov       r8d,[rbp-40]
       mov       r9d,[rbp-44]
       call      qword ptr [7FF7A9CE4108]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
M00_L63:
       mov       r8,[rbp-0E0]
       mov       [rbp-0C8],r8
       jmp       near ptr M00_L14
M00_L64:
       call      qword ptr [7FF7A9EBDFF8]
       int       3
M00_L65:
       mov       rcx,rbx
       call      qword ptr [7FF7A9AD6AA8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L15
M00_L66:
       mov       rcx,rsi
       mov       rdx,22DCDBCA820
       call      qword ptr [7FF7A99ED368]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       jmp       near ptr M00_L15
M00_L67:
       mov       rcx,22DCDBCBAF8
       call      qword ptr [7FF7A9F94C30]
       mov       rbx,rax
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FF7A97A61D8]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L68
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L68
       jmp       short M00_L69
M00_L68:
       mov       rcx,rax
       call      qword ptr [7FF7A97A56E0]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
M00_L69:
       mov       rsi,[rcx+30]
       test      rsi,rsi
       jne       short M00_L70
       lea       rdx,[rcx+30]
       mov       r8d,1
       call      qword ptr [7FF7A97ACC60]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
M00_L70:
       mov       rcx,22DCDBC2DD0
       test      rsi,rsi
       cmove     rsi,rcx
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rbx
       mov       rdx,22DCDBCA820
       mov       r8,rsi
       call      qword ptr [7FF7A9DCC540]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF7A9955FE0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L71:
       mov       rcx,rbx
       call      qword ptr [7FF7A9AD6AA8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L16
M00_L72:
       mov       ecx,9
       call      qword ptr [7FF7A9EB6AC0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdi,rax
       jmp       near ptr M00_L17
M00_L73:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1ED38C02A90
       mov       rsi,[rcx]
       jmp       near ptr M00_L21
M00_L74:
       mov       rax,22DCDBB6D78
       jmp       near ptr M00_L25
M00_L75:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L76:
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp-48],0
       je        short M00_L79
       mov       rcx,[rbp-0D8]
       mov       ecx,[rcx+8]
       cmp       [rbp-3C],ecx
       jae       short M00_L77
       mov       rcx,[rbp-0D8]
       mov       eax,[rbp-3C]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       short M00_L78
       xor       ecx,ecx
       call      qword ptr [7FF7A9EB62B0]
       int       3
M00_L77:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L78:
       mov       rcx,r14
       call      00007FF809262C80
       test      eax,eax
       je        short M00_L79
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF7A9EB6E80]
M00_L79:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E8]
       call      qword ptr [7FF7A9C2F930]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       nop
       add       rsp,28
       ret
; Total bytes of code 3321
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
       je        short M01_L01
M01_L00:
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       call      qword ptr [7FF7A95D5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M01_L00
; Total bytes of code 41
```
```assembly
; System.RuntimeType.IsAssignableFrom(System.Type)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L06
       cmp       rbx,rsi
       jne       short M02_L01
M02_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rdx,rax
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FF7A95D6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF7A9EB6C70]; System.RuntimeTypeHandle.CanCastTo(System.RuntimeType, System.RuntimeType)
M02_L02:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      qword ptr [7FF7A95D6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M02_L06
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rax,[rbx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rsi
       call      qword ptr [7FF7A97A69B8]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       je        short M02_L03
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF7A9EB6C10]
M02_L03:
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FF8092028C0
       test      eax,eax
       je        short M02_L06
       mov       rcx,rsi
       call      qword ptr [7FF7A951A400]
       mov       rsi,rax
       xor       edi,edi
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rsi+rdi*8+10]
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M02_L06
       inc       edi
M02_L05:
       cmp       [rsi+8],edi
       jg        short M02_L04
       jmp       near ptr M02_L00
M02_L06:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 252
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rax,rdx
       mov       rbx,[rcx+40]
       cmp       byte ptr [rcx+9C],0
       setne     sil
       movzx     esi,sil
       movzx     edx,word ptr [rcx+90]
       cmp       edx,20
       jne       near ptr M03_L10
       and       esi,0FFFFFFF7
M03_L00:
       mov       edx,[rcx+84]
       cmp       edx,7F
       ja        near ptr M03_L12
       and       esi,0FFFFF80F
       test      edx,edx
       je        near ptr M03_L07
       xor       r8d,r8d
       cmp       edx,2
       cmovne    r8d,edx
M03_L01:
       shl       r8d,4
       or        esi,r8d
       mov       edi,[rcx+88]
       test      edi,edi
       jl        near ptr M03_L13
       mov       r8,[rcx+50]
       test      r8,r8
       je        near ptr M03_L14
M03_L02:
       mov       rcx,22DCDBBFFA8
       cmp       r8,rcx
       je        short M03_L04
       cmp       dword ptr [r8+8],1
       jne       short M03_L03
       cmp       word ptr [r8+0C],0A
       je        short M03_L04
M03_L03:
       mov       rcx,22DCDBB1718
       cmp       r8,rcx
       je        short M03_L04
       cmp       dword ptr [r8+8],2
       jne       short M03_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M03_L08
M03_L04:
       mov       rcx,22DCDBB1718
       cmp       r8,rcx
       je        short M03_L05
       cmp       dword ptr [r8+8],2
       jne       short M03_L09
       cmp       dword ptr [r8+0C],0A000D
       jne       short M03_L09
M03_L05:
       and       esi,0FFFFFFFB
M03_L06:
       or        esi,2
       mov       [rax],rbx
       mov       [rax+8],edi
       mov       [rax+0C],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L07:
       mov       r8d,2
       jmp       near ptr M03_L01
M03_L08:
       mov       ecx,38A0
       mov       rdx,7FF7A9A22F00
       call      qword ptr [7FF7A95DF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9F94DF8]
       int       3
M03_L09:
       or        esi,4
       jmp       short M03_L06
M03_L10:
       cmp       edx,9
       je        short M03_L11
       mov       ecx,38A0
       mov       rdx,7FF7A9A22F00
       call      qword ptr [7FF7A95DF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9F94DB0]
       int       3
M03_L11:
       or        esi,8
       jmp       near ptr M03_L00
M03_L12:
       mov       ecx,38A0
       mov       rdx,7FF7A9A22F00
       call      qword ptr [7FF7A95DF228]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FF7A9F94DC8]
       int       3
M03_L13:
       mov       ecx,38A0
       mov       rdx,7FF7A9A22F00
       call      qword ptr [7FF7A95DF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9F94DE0]
       int       3
M03_L14:
       mov       r8,22DCDBB1718
       mov       [rcx+50],r8
       jmp       near ptr M03_L02
; Total bytes of code 418
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       ebx,edx
       mov       rcx,1ED38C00C90
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0A
       jle       short M04_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M04_L02
M04_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M04_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M04_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M04_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M04_L03
M04_L01:
       mov       rax,r14
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
M04_L02:
       mov       ecx,0A
       call      qword ptr [7FF7A9EB6AC0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M04_L00
M04_L03:
       mov       rcx,r14
       call      qword ptr [7FF7A99ECF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF7A99ECF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF7A9EBF090]
       jmp       short M04_L01
M04_L04:
       mov       rax,[rsi+10]
       cmp       [rax+8],ebp
       jbe       near ptr M04_L13
       mov       ecx,ebp
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        near ptr M04_L12
       mov       r14,[rax+8]
       call      qword ptr [7FF7A9CEF258]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       ebx,eax
       sub       ebx,ecx
       xor       r15d,r15d
       jmp       short M04_L08
M04_L05:
       cmp       ebx,[r14+8]
       jae       near ptr M04_L18
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FF7A9ADDB48]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M04_L06
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M04_L06:
       mov       rcx,r13
       call      qword ptr [7FF7A95D6820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M04_L09
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M04_L07
       xor       ebx,ebx
M04_L07:
       inc       r15d
M04_L08:
       cmp       [r14+8],r15d
       jg        short M04_L05
       jmp       short M04_L10
M04_L09:
       mov       r14,r12
       jmp       short M04_L11
M04_L10:
       xor       r14d,r14d
M04_L11:
       test      r14,r14
       je        short M04_L12
       cmp       byte ptr [rdi+9D],0
       je        near ptr M04_L01
       mov       rcx,r14
       call      qword ptr [7FF7A99ECF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF7A99ECF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF7A9EBF090]
       jmp       near ptr M04_L01
M04_L12:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M04_L15
M04_L13:
       test      ebx,ebx
       jne       short M04_L14
       mov       rax,22DCDBB6D78
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
M04_L14:
       mov       ecx,ebx
       mov       rdx,22DCDBB6F28
       call      qword ptr [7FF7A986D8C0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M04_L15:
       cmp       ebx,800
       jge       short M04_L16
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M04_L17
M04_L16:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FF7A9C27A38]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M04_L17:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M04_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FF7A99ECF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF7A99ECF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF7A9EBF090]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF7A99ECF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rsi+10]
       mov       edx,1
       mov       r8d,2
       cmp       [rcx+8],ebp
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rdi
       mov       edx,ebx
       mov       r8d,r15d
       call      qword ptr [7FF7A9EBF0A8]
       jmp       near ptr M04_L01
M04_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 712
```
```assembly
; System.Text.Json.Utf8JsonWriter.SetOptions(System.Text.Json.JsonWriterOptions)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       lea       rdi,[rbx+70]
       mov       rsi,rdx
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       ecx,9
       mov       eax,20
       test      byte ptr [rbx+7C],8
       cmove     ecx,eax
       mov       [rbx+3C],cl
       mov       ecx,[rdx+0C]
       and       ecx,7F0
       sar       ecx,4
       je        short M05_L02
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M05_L00:
       mov       [rbx+2C],eax
       test      byte ptr [rdx+0C],4
       jne       short M05_L03
       mov       rsi,22DCDBB1718
M05_L01:
       mov       ecx,[rsi+8]
       mov       [rbx+30],ecx
       cmp       dword ptr [rbx+78],0
       je        short M05_L04
       mov       rcx,7FF7A9FBAA70
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       eax,2
       jmp       short M05_L00
M05_L03:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      qword ptr [7FF7A95D5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1ED38C02A90
       mov       rsi,[rcx]
       jmp       short M05_L01
M05_L04:
       mov       rcx,7FF7A9FBAA74
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF7A9FBAA70
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+70]
       mov       edx,3E8
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF7A9F94E10]
; Total bytes of code 211
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       sub       rsp,28
       test      rdx,rdx
       je        short M06_L01
       mov       r8d,r8d
       mov       eax,r9d
       add       rax,r8
       mov       r10d,[rdx+8]
       cmp       rax,r10
       ja        short M06_L02
       add       rdx,10
       add       rdx,r8
       mov       [rcx],rdx
       mov       [rcx+8],r9d
M06_L00:
       add       rsp,28
       ret
M06_L01:
       or        r8d,r9d
       jne       short M06_L02
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       jmp       short M06_L00
M06_L02:
       call      qword ptr [7FF7A97AF228]
       int       3
; Total bytes of code 69
```
```assembly
; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-40],rax
       mov       r8,1ED38C013D8
       mov       rbx,[r8]
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       r8d,1
       test      edi,edi
       cmove     rsi,r8
       mov       [rbp-38],rsi
       test      rsi,rsi
       je        near ptr M07_L03
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FF7A97ACD98]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       mov       r9d,eax
       sub       r9d,esi
       mov       r14d,r9d
       add       r14d,[rbp-48]
       cmp       r9d,edi
       jne       near ptr M07_L04
M07_L00:
       test      r14d,r14d
       je        near ptr M07_L05
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FF809259F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       [rbp-40],rcx
       mov       r13,[rbp-40]
       test      r13,r13
       je        near ptr M07_L06
       mov       ecx,edi
       or        ecx,r14d
       jl        near ptr M07_L07
       lea       rcx,[rbp-58]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-60]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       mov       edx,edi
       mov       r8,r13
       mov       r9d,r14d
       call      qword ptr [7FF7A97ACDC8]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
       mov       ecx,[rbp-58]
       sub       ecx,esi
       mov       rdx,[rbp-60]
       sub       rdx,r13
       mov       r8,rdx
       shr       r8,3F
       add       rdx,r8
       sar       rdx,1
       cmp       ecx,edi
       jne       short M07_L08
M07_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
M07_L02:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       near ptr M07_L09
M07_L03:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FF7A9B5DFB0]
       int       3
M07_L04:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FF7A9B5DF80]
       add       r14d,eax
       jns       near ptr M07_L00
       call      qword ptr [7FF7A9B5DFC8]
       int       3
M07_L05:
       mov       r15,22DCDBB0008
       jmp       short M07_L02
M07_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FF7A9B5DFB0]
       int       3
M07_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FF7A9B55E60]
       int       3
M07_L08:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,r13
       call      qword ptr [7FF7A9B5E220]
       jmp       near ptr M07_L01
M07_L09:
       mov       rax,r15
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,48
       call      qword ptr [7FF7A9B5E760]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 442
```
```assembly
; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M08_L05
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M08_L05
M08_L00:
       mov       rdi,[rax+10]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       [rbx+20],rcx
       mov       [rbx+40],rcx
       mov       [rbx+48],rcx
       mov       byte ptr [rbx+38],0
       mov       word ptr [rbx+39],0
       mov       [rbx+28],ecx
       mov       [rbx+50],rcx
       mov       [rbx+58],rcx
       mov       [rbx+60],rcx
       mov       [rbx+68],cx
       mov       [rbx+6A],cl
       mov       byte ptr [rbx+3B],0
       mov       [rbx+10],rcx
       mov       [rbx+18],rcx
       mov       [rbx+8],rcx
       cmp       [rsi],sil
       add       rsi,18
       mov       [rsi+8],ecx
       mov       [rsi+0C],ecx
       mov       rbx,[rsi]
       mov       rcx,22DCDBB6D78
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M08_L04
       mov       esi,[rbx+8]
       test      esi,esi
       je        near ptr M08_L04
       mov       rcx,1ED38C01E10
       mov       rbp,[rcx]
       lea       ecx,[rsi-1]
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M08_L06
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        near ptr M08_L06
M08_L01:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M08_L07
M08_L02:
       xor       r15d,r15d
       mov       r13d,1
       mov       ecx,[rax+8]
       cmp       ecx,r14d
       jbe       short M08_L03
       mov       r15d,1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       esi,ecx
       jne       near ptr M08_L08
       mov       ecx,r14d
       shl       rcx,4
       lea       r12,[rax+rcx+10]
       mov       rax,[r12]
       mov       [rsp+38],rax
       mov       rcx,r12
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r12+8],ecx
       mov       r12,[rsp+38]
       test      r12,r12
       jne       near ptr M08_L09
M08_L03:
       mov       rcx,1ED38C00C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       jne       near ptr M08_L21
M08_L04:
       dec       dword ptr [rdi+18]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L05:
       mov       ecx,9
       call      qword ptr [7FF7A9EB6AC0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M08_L00
M08_L06:
       mov       ecx,0A
       call      qword ptr [7FF7A9EB6AC0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M08_L01
M08_L07:
       mov       rcx,rbp
       call      qword ptr [7FF7A9C2F978]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L02
M08_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9EBF120]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FF7A9514000
       call      qword ptr [7FF7A95DF228]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7A9956088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rcx,[rbp+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M08_L24
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L10
       mov       rcx,rbp
       mov       edx,r14d
       call      qword ptr [7FF7A9F94930]
M08_L10:
       mov       r13,[rax+8]
       call      qword ptr [7FF7A9CEF258]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M08_L17
M08_L11:
       cmp       eax,[r13+8]
       jae       near ptr M08_L24
       mov       [rsp+4C],eax
       mov       ecx,eax
       mov       r8,[r13+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rsp+44],r10d
       mov       rcx,r8
       call      qword ptr [7FF7A9ADDB48]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+40],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L13
       test      r8d,r8d
       jne       short M08_L14
       xor       edx,edx
       mov       [rax+14],edx
M08_L12:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+40]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+44],1
M08_L13:
       mov       rcx,rax
       call      qword ptr [7FF7A95D6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+44],0
       je        short M08_L15
       jmp       short M08_L18
M08_L14:
       jmp       short M08_L12
M08_L15:
       mov       eax,[rsp+4C]
       inc       eax
       mov       ecx,eax
       cmp       [r13+8],ecx
       jne       short M08_L16
       xor       ecx,ecx
M08_L16:
       mov       edx,[rsp+48]
       inc       edx
       mov       eax,ecx
M08_L17:
       mov       [rsp+48],edx
       cmp       [r13+8],edx
       jg        near ptr M08_L11
       jmp       short M08_L19
M08_L18:
       mov       r13d,1
       jmp       short M08_L20
M08_L19:
       xor       r13d,r13d
M08_L20:
       jmp       near ptr M08_L03
M08_L21:
       mov       rcx,rbx
       call      qword ptr [7FF7A99ECF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+54],eax
       mov       [rsp+50],esi
       mov       rcx,rbp
       call      qword ptr [7FF7A99ECF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rsp+54]
       mov       r9d,[rsp+50]
       mov       edx,3
       call      qword ptr [7FF7A9EBF138]
       test      r13d,r15d
       jne       near ptr M08_L04
       mov       rcx,rbx
       call      qword ptr [7FF7A99ECF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rbp
       call      qword ptr [7FF7A99ECF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r15d,r15d
       jne       short M08_L22
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M08_L23
M08_L22:
       mov       ecx,r14d
       xor       edx,edx
M08_L23:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,ebx
       mov       r8d,esi
       call      qword ptr [7FF7A9EBF150]
       jmp       near ptr M08_L04
M08_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 952
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
; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rbx,rcx
       mov       r8,[rbx]
       cmp       dword ptr [r8+8],0
       je        near ptr M10_L08
       mov       eax,[rbx+8]
       mov       ecx,[r8+8]
       mov       esi,[rbx+0C]
       sub       ecx,esi
       add       ecx,eax
       cmp       edx,ecx
       jle       near ptr M10_L09
       sub       esi,eax
       add       edx,esi
       cmp       edx,7FFFFFC7
       ja        near ptr M10_L10
       mov       ecx,[r8+8]
       add       ecx,ecx
       mov       eax,7FFFFFC7
       cmp       rcx,7FFFFFC7
       cmovl     rax,rcx
       cmp       edx,eax
       cmovl     edx,eax
       cmp       byte ptr [rbx+10],0
       je        near ptr M10_L11
       mov       rcx,1ED38C01E10
       mov       rcx,[rcx]
       call      qword ptr [7FF7A9C49A28]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rsi,rax
M10_L00:
       mov       rdi,[rbx]
       mov       ebp,[rbx+0C]
       mov       r14d,[rbx+8]
       sub       ebp,r14d
       je        near ptr M10_L03
       test      rdi,rdi
       je        near ptr M10_L12
       test      rsi,rsi
       je        near ptr M10_L13
       mov       r15d,[rdi+8]
       mov       rcx,offset MT_System.Byte[]
       cmp       [rdi],rcx
       jne       near ptr M10_L14
M10_L01:
       mov       r13,r15
       cmp       rdi,rsi
       je        short M10_L02
       mov       r13d,[rsi+8]
       mov       rcx,offset MT_System.Byte[]
       cmp       [rsi],rcx
       jne       near ptr M10_L16
M10_L02:
       test      r14d,r14d
       jl        near ptr M10_L18
       test      ebp,ebp
       jl        near ptr M10_L19
       mov       r8d,ebp
       mov       edx,r14d
       lea       rcx,[rdx+r8]
       cmp       rcx,r15
       ja        near ptr M10_L20
       cmp       r13,r8
       jb        near ptr M10_L20
       lea       rcx,[rsi+10]
       lea       rdx,[rdi+rdx+10]
       call      qword ptr [7FF7A95D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M10_L03:
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+10],0
       je        near ptr M10_L07
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        near ptr M10_L07
       mov       rcx,1ED38C01E10
       mov       rsi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M10_L21
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        near ptr M10_L21
M10_L04:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M10_L22
M10_L05:
       xor       r14d,r14d
       mov       r15d,1
       mov       ecx,[rax+8]
       cmp       ecx,ebp
       jbe       short M10_L06
       mov       r14d,1
       mov       ecx,10
       shlx      ecx,ecx,ebp
       cmp       ebx,ecx
       jne       near ptr M10_L23
       mov       ecx,ebp
       shl       rcx,4
       lea       r13,[rax+rcx+10]
       mov       r12,[r13]
       mov       rcx,r13
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],ecx
       test      r12,r12
       jne       near ptr M10_L24
M10_L06:
       mov       rcx,1ED38C00C90
       mov       r13,[rcx]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M10_L36
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
       mov       rcx,1ED38C01E10
       mov       rcx,[rcx]
       call      qword ptr [7FF7A9C49A28]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,rbx
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M10_L07
M10_L09:
       mov       edx,esi
       sub       edx,eax
       mov       [rsp+20],edx
       mov       edx,eax
       mov       rcx,r8
       xor       r9d,r9d
       call      qword ptr [7FF7A9865FF8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       jmp       short M10_L07
M10_L10:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A9EBEF88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M10_L11:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       near ptr M10_L00
M10_L12:
       mov       ecx,257
       mov       rdx,7FF7A9514000
       call      qword ptr [7FF7A95DF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9EB62B0]
       int       3
M10_L13:
       mov       ecx,25F
       mov       rdx,7FF7A9514000
       call      qword ptr [7FF7A95DF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9EB62B0]
       int       3
M10_L14:
       mov       rcx,rdi
       call      00007FF80914ACC0
       mov       ecx,3003FFC
       bt        ecx,eax
       jb        short M10_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9EB7978]
       mov       rsi,rax
       mov       ecx,257
       mov       rdx,7FF7A9514000
       call      qword ptr [7FF7A95DF228]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7A9956088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M10_L15:
       mov       rcx,[rdi]
       movzx     ecx,word ptr [rcx]
       imul      r15,rcx
       jmp       near ptr M10_L01
M10_L16:
       mov       rcx,rsi
       call      00007FF80914ACC0
       mov       ecx,3003FFC
       bt        ecx,eax
       jb        short M10_L17
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF7A9EB7978]
       mov       rbp,rax
       mov       ecx,25F
       mov       rdx,7FF7A9514000
       call      qword ptr [7FF7A95DF228]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,r14
       call      qword ptr [7FF7A9956088]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M10_L17:
       mov       rcx,[rsi]
       movzx     ecx,word ptr [rcx]
       imul      r13,rcx
       jmp       near ptr M10_L02
M10_L18:
       mov       ecx,267
       mov       rdx,7FF7A9514000
       call      qword ptr [7FF7A95DF228]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7A9EB6280]
       int       3
M10_L19:
       mov       ecx,28F
       mov       rdx,7FF7A9514000
       call      qword ptr [7FF7A95DF228]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FF7A9EB6280]
       int       3
M10_L20:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF7A9EB7990]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF7A9954198]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M10_L21:
       mov       ecx,0A
       call      qword ptr [7FF7A9EB6AC0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M10_L04
M10_L22:
       mov       rcx,rsi
       call      qword ptr [7FF7A9C2F978]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M10_L05
M10_L23:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7A9EBF120]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF7A9514000
       call      qword ptr [7FF7A95DF228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF7A9956088]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M10_L24:
       mov       rcx,[rsi+10]
       cmp       ebp,[rcx+8]
       jae       near ptr M10_L39
       mov       edx,ebp
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M10_L25
       mov       rcx,rsi
       mov       edx,ebp
       call      qword ptr [7FF7A9F94930]
M10_L25:
       mov       r15,[rax+8]
       call      qword ptr [7FF7A9CEF258]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r13d,eax
       sub       r13d,ecx
       xor       eax,eax
       jmp       near ptr M10_L32
M10_L26:
       cmp       r13d,[r15+8]
       jae       near ptr M10_L39
       mov       ecx,r13d
       mov       rdx,[r15+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+3C],r8d
       mov       rcx,rdx
       call      qword ptr [7FF7A9ADDB48]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+38],r8d
       cmp       [rcx+8],r8d
       jbe       short M10_L28
       test      r8d,r8d
       jne       short M10_L29
       xor       edx,edx
       mov       [rax+14],edx
M10_L27:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+38]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+3C],1
M10_L28:
       mov       rcx,rax
       call      qword ptr [7FF7A95D6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+3C],0
       je        short M10_L30
       jmp       short M10_L33
M10_L29:
       jmp       short M10_L27
M10_L30:
       inc       r13d
       cmp       [r15+8],r13d
       jne       short M10_L31
       xor       r13d,r13d
M10_L31:
       mov       eax,[rsp+40]
       inc       eax
M10_L32:
       mov       [rsp+40],eax
       cmp       [r15+8],eax
       jg        near ptr M10_L26
       jmp       short M10_L34
M10_L33:
       mov       r15d,1
       jmp       short M10_L35
M10_L34:
       xor       r15d,r15d
M10_L35:
       jmp       near ptr M10_L06
M10_L36:
       mov       rcx,rdi
       call      qword ptr [7FF7A99ECF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       [rsp+44],ebx
       mov       rcx,rsi
       call      qword ptr [7FF7A99ECF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r13
       mov       r8d,r12d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FF7A9EBF138]
       test      r15d,r14d
       jne       near ptr M10_L07
       mov       rcx,rdi
       call      qword ptr [7FF7A99ECF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,rsi
       call      qword ptr [7FF7A99ECF48]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r14d,r14d
       jne       short M10_L37
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M10_L38
M10_L37:
       mov       ecx,ebp
       xor       edx,edx
M10_L38:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r13
       mov       edx,edi
       mov       r8d,ebx
       call      qword ptr [7FF7A9EBF150]
       jmp       near ptr M10_L07
M10_L39:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1552
```
```assembly
; System.Text.Json.JsonSerializerOptions..ctor()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       dword ptr [rbx+7C],4000
       call      qword ptr [7FF8127484D8]
       movzx     ecx,byte ptr [rax+1]
       mov       [rbx+95],cl
       movzx     eax,byte ptr [rax+2]
       mov       [rbx+96],al
       mov       word ptr [rbx+90],20
       mov       dword ptr [rbx+84],2
       mov       byte ptr [rbx+9D],1
       mov       dword ptr [rbx+88],40
       call      qword ptr [7FF812748550]
       mov       rcx,[rax]
       mov       rdx,rbx
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       xor       r8d,r8d
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [r11]
; Total bytes of code 109
```
```assembly
; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       sub       rsp,28
       cmp       byte ptr [rcx+9E],0
       jne       short M12_L01
       mov       rax,[rcx+58]
       test      rax,rax
       jne       short M12_L02
M12_L00:
       lea       rcx,[rcx+20]
       call      qword ptr [7FF812748278]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M12_L01:
       mov       rcx,[rcx+20]
       call      qword ptr [7FF81274A688]
       mov       rcx,rax
       call      qword ptr [7FF81274CE70]
       int       3
M12_L02:
       cmp       rax,rdx
       je        short M12_L00
       xor       r8d,r8d
       mov       [rax+10],r8
       mov       [rcx+58],r8
       jmp       short M12_L00
; Total bytes of code 76
```
```assembly
; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF81274E588]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF81274C548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       test      rax,rax
       cmove     rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7A99ED368]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M14_L00:
       mov       rcx,7FF7A9F82474
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-20]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,7FF7A9F82470
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A9EBE5C8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF7A9EBFB28]
       mov       [rbp-20],rsi
       lea       rax,[M14_L00]
       add       rsp,28
       ret
; Total bytes of code 185
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
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M16_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M16_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L02
M16_L00:
       test      rax,rax
       je        short M16_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L02
       test      rax,rax
       je        short M16_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L02
       test      rax,rax
       jne       short M16_L03
M16_L01:
       xor       edx,edx
M16_L02:
       mov       rax,rdx
       ret
M16_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L02
       test      rax,rax
       je        short M16_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L02
       jmp       short M16_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
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
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       edi,r9d
       xor       eax,eax
       mov       [rbp-48],eax
       mov       rax,[rcx+8]
       mov       rax,[rax+18]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M17_L15
       mov       rcx,[rax+10]
       call      qword ptr [7FF83A9FAB70]; Precode of System.Threading.Monitor.Enter(System.Object)
       mov       dword ptr [rbp-48],1
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+8]
       jne       near ptr M17_L17
       mov       rax,[rbx+10]
       mov       r14d,[rax+8]
       xor       r15d,r15d
       test      dil,dil
       je        short M17_L01
       mov       rcx,[rbx+8]
       call      qword ptr [7FF83A9FAA38]
       mov       rdi,rax
       test      rdi,rdi
       je        short M17_L01
       mov       rcx,[rbp+10]
       mov       r13,[rcx]
       mov       rcx,r13
       call      qword ptr [7FF83A9FA3B0]
       mov       r15,rax
       mov       rcx,rdi
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       call      qword ptr [r11]
       mov       r8,rax
       test      r8,r8
       je        short M17_L00
       mov       rcx,r15
       cmp       [r8],rcx
       je        short M17_L00
       mov       rdx,rax
       call      qword ptr [7FF83A9FA290]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
       mov       r8,r15
M17_L00:
       mov       r15,r8
M17_L01:
       test      sil,sil
       je        short M17_L04
       test      r15,r15
       jne       short M17_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FF83A9FB158]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetCountNoLocks()
       mov       rcx,[rbx+10]
       mov       ecx,[rcx+8]
       shr       ecx,2
       cmp       eax,ecx
       jl        near ptr M17_L14
M17_L02:
       mov       rax,[rbx+10]
       mov       eax,[rax+8]
       add       eax,eax
       js        short M17_L03
       mov       ecx,eax
       call      qword ptr [7FF83A9FAE98]; Precode of System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       call      qword ptr [7FF83A9FAA68]; Precode of System.Array.get_MaxLength()
       cmp       eax,r14d
       jge       short M17_L04
M17_L03:
       call      qword ptr [7FF83A9FAA68]; Precode of System.Array.get_MaxLength()
       mov       r14d,eax
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+10],7FFFFFFF
M17_L04:
       mov       rsi,[rbx+18]
       mov       rdi,rsi
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+18],0
       je        short M17_L06
       cmp       dword ptr [rsi+8],400
       jge       short M17_L06
       mov       eax,[rsi+8]
       add       eax,eax
       movsxd    rcx,eax
       call      qword ptr [7FF83A9FAA20]
       mov       rdi,rax
       mov       r8d,[rsi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF83A9FAA50]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,[rbx+18]
       mov       esi,[rax+8]
       mov       r13d,[rdi+8]
       cmp       r13d,esi
       jle       short M17_L06
M17_L05:
       call      qword ptr [7FF83A9FA988]
       mov       r8,rax
       movsxd    rdx,esi
       mov       rcx,rdi
       call      qword ptr [7FF83A9FA270]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       esi
       cmp       r13d,esi
       jg        short M17_L05
M17_L06:
       mov       rcx,[rbp+10]
       mov       r13,[rcx]
       mov       rcx,r13
       call      qword ptr [7FF83A9FA600]
       mov       rcx,rax
       movsxd    rdx,r14d
       call      qword ptr [7FF83A9FA288]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       ecx,[rdi+8]
       call      qword ptr [7FF83A9FAA28]
       mov       r14,rax
       mov       r12,r15
       test      r12,r12
       jne       short M17_L07
       mov       r12,[rbx+8]
M17_L07:
       mov       rcx,r13
       call      qword ptr [7FF83A9FA450]
       mov       rcx,rax
       call      qword ptr [7FF83A9FA280]; CORINFO_HELP_NEWFAST
       mov       [rbp-78],rax
       lea       rcx,[rax+10]
       mov       rdx,rsi
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+18]
       mov       rdx,rdi
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+20]
       mov       rdx,r14
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rsi+8]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       r12,[rbp-78]
       mov       [r12+28],rax
       mov       rcx,r13
       call      qword ptr [7FF83A9FA418]
       mov       rcx,rax
       lea       r8,[rbp-48]
       mov       rdx,rbx
       call      qword ptr [7FF83A9FB178]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].AcquirePostFirstLock(Tables<System.__Canon,System.__Canon>, Int32 ByRef)
       mov       rbx,[rbx+10]
       xor       eax,eax
       jmp       near ptr M17_L13
M17_L08:
       mov       [rbp-58],rax
       mov       rdx,[rbx+rax*8+10]
       test      rdx,rdx
       je        near ptr M17_L12
M17_L09:
       test      r15,r15
       jne       short M17_L10
       mov       [rbp-68],rdx
       mov       r8d,[rdx+20]
       jmp       short M17_L11
M17_L10:
       mov       [rbp-68],rdx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       call      qword ptr [7FF83A9FA740]
       mov       r8,[rbp-68]
       mov       rdx,[r8+8]
       mov       rcx,r15
       mov       r11,rax
       call      qword ptr [rax]
       mov       r8d,eax
M17_L11:
       mov       r10,[rbp-68]
       mov       r9,[r10+18]
       mov       [rbp-80],r9
       mov       rcx,[r12+10]
       mov       [rbp-4C],r8d
       mov       r11d,r8d
       imul      r11,[r12+28]
       shr       r11,20
       inc       r11
       mov       edx,[rcx+8]
       mov       [rbp-50],edx
       mov       eax,edx
       imul      r11,rax
       shr       r11,20
       mov       rsi,[r12+18]
       mov       eax,r11d
       xor       edx,edx
       div       dword ptr [rsi+8]
       mov       esi,edx
       cmp       r11d,[rbp-50]
       jae       near ptr M17_L15
       mov       eax,r11d
       lea       rax,[rcx+rax*8+10]
       mov       [rbp-70],rax
       mov       rcx,r13
       call      qword ptr [7FF83A9FA438]
       mov       rcx,rax
       call      qword ptr [7FF83A9FA280]; CORINFO_HELP_NEWFAST
       mov       [rbp-88],rax
       mov       r8,[rbp-68]
       mov       rdx,[r8+8]
       mov       r8,[r8+10]
       mov       [rbp-90],r8
       mov       r10,[rbp-70]
       mov       r9,[r10]
       mov       [rbp-98],r9
       lea       rcx,[rax+8]
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-90]
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       lea       rcx,[rax+18]
       mov       rdx,[rbp-98]
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       mov       ecx,[rbp-4C]
       mov       [rax+20],ecx
       mov       rcx,[rbp-70]
       mov       rdx,rax
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       cmp       esi,[r14+8]
       jae       short M17_L15
       mov       eax,esi
       lea       rax,[r14+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        short M17_L16
       mov       [rax],edx
       mov       rsi,[rbp-80]
       test      rsi,rsi
       mov       rdx,rsi
       jne       near ptr M17_L09
M17_L12:
       mov       rsi,[rbp-58]
       inc       esi
       mov       rax,rsi
M17_L13:
       mov       ecx,[rbx+8]
       cmp       ecx,eax
       jg        near ptr M17_L08
       mov       rsi,[rbp-60]
       mov       eax,[rsi+8]
       xor       edx,edx
       div       dword ptr [rdi+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp+10]
       mov       [rax+10],ecx
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       jmp       short M17_L17
M17_L14:
       mov       rcx,[rbp+10]
       mov       edx,[rcx+10]
       add       edx,edx
       mov       [rcx+10],edx
       test      edx,edx
       jge       short M17_L17
       mov       dword ptr [rcx+10],7FFFFFFF
       jmp       short M17_L17
M17_L15:
       call      qword ptr [7FF83A9FA250]
       int       3
M17_L16:
       call      qword ptr [7FF83A9FA248]
       int       3
M17_L17:
       mov       rcx,[rbp+10]
       mov       edx,[rbp-48]
       call      qword ptr [7FF83A9FB188]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32)
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
       sub       rsp,28
       mov       rcx,[rbp+10]
       mov       edx,[rbp-48]
       call      qword ptr [7FF83A9FB188]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 1103
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       rax,[rcx+0B8]
       cmp       qword ptr [rax+20],0
       je        near ptr M18_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       near ptr M18_L07
       mov       rbx,[rcx+0B8]
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M18_L08
M18_L00:
       mov       [rbp-20],rsi
       xor       eax,eax
       mov       [rbp-14],eax
       test      rsi,rsi
       je        short M18_L02
       mov       rcx,rsi
       call      00007FF809262D60
       test      eax,eax
       jne       short M18_L01
       mov       rcx,rsi
       call      qword ptr [7FF7A9EB7060]
M18_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M18_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M18_L03
       mov       rcx,7FF7A9F51048
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF7A9AD6AC0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M18_L04
M18_L02:
       xor       ecx,ecx
       call      qword ptr [7FF7A9EB62B0]
       int       3
M18_L03:
       mov       rcx,7FF7A9F51044
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF7A9EBDFF8]
       int       3
M18_L04:
       mov       rcx,7FF7A9F5104C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FF809262C80
       test      eax,eax
       jne       near ptr M18_L10
M18_L05:
       mov       rcx,7FF7A9F51050
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF7A9F51054
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M18_L06:
       call      qword ptr [7FF7A9EBE5B0]
       int       3
M18_L07:
       mov       rcx,7FF7A9F51040
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF7A9EBDFF8]
       int       3
M18_L08:
       mov       rcx,rbx
       call      qword ptr [7FF7A99ECDF8]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M18_L09
       call      qword ptr [7FF7A9EB67D8]
       int       3
M18_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF8091FCC60
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M18_L00
M18_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF7A9EB6E80]
       jmp       near ptr M18_L05
       sub       rsp,28
       call      qword ptr [7FF7A9EBE5C8]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M18_L12
       mov       rcx,7FF7A9F5104C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M18_L11
       xor       ecx,ecx
       call      qword ptr [7FF7A9EB62B0]
       int       3
M18_L11:
       mov       rcx,[rbp-20]
       call      00007FF809262C80
       test      eax,eax
       je        short M18_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF7A9EB6E80]
M18_L12:
       mov       rcx,7FF7A9F51050
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rbx+60]
       test      rdi,rdi
       jne       short M19_L00
       mov       rcx,7FF7A9F824D8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbx+20]
M19_L00:
       test      rdi,rdi
       je        short M19_L02
       mov       rcx,rdi
       mov       rdx,7FF7A9F824E0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rdi
       mov       r8,rbx
       mov       rdx,rsi
       mov       r11,7FF7A9520E20
       call      qword ptr [r11]
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M19_L06
       mov       rcx,[rbp+0C0]
       mov       rdx,rsi
       call      qword ptr [7FF7A97ACC30]; System.Type.op_Equality(System.Type, System.Type)
       test      eax,eax
       je        short M19_L03
       cmp       [rbp+0B8],rbx
       jne       short M19_L04
M19_L01:
       mov       rcx,7FF7A9F825F8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M19_L02:
       mov       rcx,7FF7A9F824DC
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M19_L03:
       mov       rcx,7FF7A9F825E8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp+0C0]
       mov       rcx,rsi
       call      qword ptr [7FF7A9EBFB40]
       int       3
M19_L04:
       mov       rcx,7FF7A9F825EC
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF7A9EBFB58]
       int       3
M19_L05:
       mov       rcx,7FF7A9F825F0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M19_L01
M19_L06:
       mov       rcx,22DCDBB27E0
       cmp       rsi,rcx
       jne       short M19_L05
       mov       rcx,7FF7A9F825F4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SlimObjectConverter
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF7A99EE1F0]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       byte ptr [rbp+12],1
       lea       rcx,[rbp+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8,rbx
       call      qword ptr [7FF7A9AD5AA0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Text.Json.Serialization.JsonConverter, System.Text.Json.JsonSerializerOptions)
       mov       rbp,rsi
       jmp       near ptr M19_L01
; Total bytes of code 366
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
       je        near ptr M20_L08
M20_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M20_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M20_L09
M20_L01:
       test      rdi,rdi
       jne       near ptr M20_L07
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
       call      00007FF8091FFE50
       mov       r14,rax
       test      r14,r14
       je        near ptr M20_L10
M20_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M20_L05
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
       mov       rax,7FF7A97C8C30
       mov       [rbp-78],rax
       lea       rax,[M20_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF8091A5A20
       call      rax
M20_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF809513A10],0
       je        short M20_L04
       call      qword ptr [7FF809501648]; CORINFO_HELP_STOP_FOR_GC
M20_L04:
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
M20_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF80921C1F0
       mov       rdx,rax
       test      rdx,rdx
       je        short M20_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M20_L11
M20_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M20_L07:
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
M20_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF7A9F96F88]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M20_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF7A9EB7CA8]
       jmp       near ptr M20_L00
M20_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M20_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF7A97A5728]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M20_L02
M20_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       [rbp+18],rdx
       mov       rbx,rcx
       mov       edi,r8d
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r14,rax
       mov       rcx,rsp
       mov       [rbp-68],rcx
       mov       rcx,rbp
       mov       [rbp-58],rcx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M21_L03
       mov       [rbp-48],rcx
       mov       rcx,[rbp-48]
       test      rcx,rcx
       je        near ptr M21_L04
       mov       rcx,[rcx+18]
M21_L00:
       lea       rdx,[rbp-48]
       mov       [rbp-90],rdx
       mov       [rbp-88],rcx
       lea       rcx,[rbp-90]
       mov       edx,edi
       lea       r8,[rbp-40]
       mov       rax,7FF7A96162A8
       mov       [rbp-70],rax
       lea       rax,[M21_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FF80914C260
       call      rax
M21_L01:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FF809513A10],0
       je        short M21_L02
       call      qword ptr [7FF809501648]; CORINFO_HELP_STOP_FOR_GC
M21_L02:
       mov       rcx,[rbp-78]
       mov       [r14+8],rcx
       mov       rbx,[rbp-40]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rbx
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
M21_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9EB6E98]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF7A9EB6EB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M21_L04:
       xor       ecx,ecx
       jmp       near ptr M21_L00
; Total bytes of code 312
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFFFEC1CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M22_L01
       cmp       [rax],ecx
       jle       short M22_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M22_L03
M22_L00:
       add       rsp,20
       pop       rbx
       ret
M22_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M22_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M22_L00
M22_L02:
       cmp       [rax+4],edx
       jle       short M22_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M22_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M22_L03
       jmp       short M22_L00
M22_L03:
       mov       ecx,ebx
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M23_L00
       ret
M23_L00:
       jmp       qword ptr [7FF7A95D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_JsonSerializer_Generator_Person()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       vzeroupper
       lea       rbp,[rsp+120]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0E0],ymm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp+10],rcx
       mov       rdx,rcx
       mov       r8,[rdx+48]
       mov       [rbp-0A0],r8
       mov       rbx,20E370AFFC0
       mov       [rbp-0F8],rbx
       mov       rcx,1CDA2002740
       mov       rcx,[rcx]
       mov       [rbp-0A8],rcx
       test      r8,r8
       je        short M00_L00
       mov       rcx,r8
       call      qword ptr [7FF7A97A61D8]; System.Object.GetType()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A951A610]; System.RuntimeType.IsAssignableFrom(System.Type)
       test      eax,eax
       mov       rbx,[rbp-0F8]
       mov       r8,[rbp-0A0]
       je        near ptr M00_L27
M00_L00:
       mov       rcx,[rbp-0A8]
       mov       rsi,[rcx+8]
       test      rsi,rsi
       je        near ptr M00_L30
M00_L01:
       mov       [rbp-0B0],rsi
       mov       rsi,[rbp-0B0]
       cmp       [rsi],sil
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       mov       rax,7FF8091FF0F0
       call      rax
       movzx     esi,al
       cmp       dword ptr [7FF809513A10],0
       jne       near ptr M00_L31
M00_L02:
       cmp       esi,0F
       je        near ptr M00_L39
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       mov       rax,7FF8091FF0F0
       call      rax
       movzx     esi,al
       mov       rbx,[rbp-0F8]
       cmp       dword ptr [7FF809513A10],0
       jne       near ptr M00_L32
M00_L03:
       cmp       esi,10
       je        near ptr M00_L39
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       mov       ecx,[rcx]
       and       ecx,80001000
       cmp       ecx,1000
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L39
M00_L04:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbx],rcx
       jne       near ptr M00_L36
       mov       [rbp-0B8],rbx
       mov       rcx,[rbx+18]
       mov       rax,7FF8091FF0F0
       call      rax
       movzx     esi,al
       mov       rbx,[rbp-0B8]
       cmp       dword ptr [7FF809513A10],0
       jne       near ptr M00_L34
M00_L05:
       cmp       esi,1D
       ja        short M00_L06
       mov       ecx,1FEF7FFF
       bt        ecx,esi
       jae       near ptr M00_L35
M00_L06:
       cmp       esi,10
       sete      dil
       movzx     edi,dil
M00_L07:
       test      edi,edi
       jne       near ptr M00_L33
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbx],rcx
       jne       near ptr M00_L37
M00_L08:
       test      rbx,rbx
       je        near ptr M00_L38
       mov       rcx,rbx
       call      00007FF809203260
       test      eax,eax
       jne       near ptr M00_L39
       mov       rsi,[rbp-0B0]
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L67
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M00_L40
M00_L09:
       mov       rsi,[rdi+8]
       mov       rcx,1CDA2001968
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M00_L41
M00_L10:
       mov       [rbp-0C0],rsi
       cmp       [rsi],sil
       mov       r14,[rsi+8]
       mov       rcx,[r14+8]
       cmp       byte ptr [rsi+19],0
       jne       near ptr M00_L22
       mov       rdx,20E370AFFC0
       mov       r11,7FF7A95211B0
       call      qword ptr [r11]
       mov       esi,eax
M00_L11:
       mov       r15,[r14+8]
       mov       rcx,[r14+10]
       mov       edx,esi
       imul      rdx,[r14+28]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M00_L77
       mov       edx,edx
       mov       r13,[rcx+rdx*8+10]
       test      r13,r13
       je        near ptr M00_L45
M00_L12:
       cmp       esi,[r13+20]
       jne       near ptr M00_L43
       mov       r12,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r15],rcx
       jne       near ptr M00_L44
       test      r12,r12
       je        near ptr M00_L43
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M00_L42
       mov       rcx,20E370AFFC0
       cmp       r12,rcx
       sete      al
       movzx     eax,al
M00_L13:
       test      eax,eax
       je        near ptr M00_L43
       mov       rdx,[r13+10]
       mov       [rbp-0C8],rdx
M00_L14:
       mov       rcx,[rbp-0C8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       near ptr M00_L65
       mov       rcx,[rbp-0C8]
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        short M00_L15
       cmp       byte ptr [rbx+119],2
       jne       near ptr M00_L66
M00_L15:
       test      rbx,rbx
       je        near ptr M00_L68
       cmp       byte ptr [rbx+119],2
       jne       near ptr M00_L72
M00_L16:
       mov       rsi,[rbx+0B8]
       lea       rdx,[rbp-68]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9C27960]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       esi,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M00_L73
       mov       rcx,[rcx+240]
       mov       rdi,[rcx+48]
       test      rdi,rdi
       je        near ptr M00_L73
M00_L17:
       mov       rax,[rdi+10]
       test      rax,rax
       jne       short M00_L18
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,20E370A6EF8
       mov       [rax+18],rcx
       xor       ecx,ecx
       mov       [rax+20],rcx
       mov       byte ptr [rax+28],1
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r14
M00_L18:
       mov       ecx,[rax+18]
       lea       edx,[rcx+1]
       mov       [rax+18],edx
       test      ecx,ecx
       jne       near ptr M00_L23
       mov       rcx,[rax+8]
       mov       [rbp-0E8],rcx
       mov       r14,[rax+10]
       mov       rcx,[rbp-0E8]
       cmp       [rcx],cl
       mov       rcx,[rbp-0E8]
       add       rcx,18
       mov       rdx,[rcx]
       mov       edx,[rdx+8]
       sub       edx,[rcx+0C]
       cmp       edx,esi
       jl        near ptr M00_L28
M00_L19:
       lea       rcx,[r14+8]
       mov       rdx,[rbp-0E8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-5C]
       lea       rdi,[r14+70]
       lea       rsi,[rbp-68]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       ecx,9
       mov       eax,20
       test      byte ptr [r14+7C],8
       cmove     ecx,eax
       mov       [r14+3C],cl
       mov       ecx,edx
       and       ecx,7F0
       sar       ecx,4
       je        near ptr M00_L29
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L20:
       mov       [r14+2C],eax
       test      dl,4
       jne       near ptr M00_L74
       mov       rsi,20E370A1718
M00_L21:
       mov       ecx,[rsi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+78],0
       jne       near ptr M00_L26
       mov       dword ptr [r14+78],3E8
       jmp       near ptr M00_L26
M00_L22:
       mov       rcx,20E370AFFC0
       mov       rax,[7FF7A951A1C0]
       call      qword ptr [rax+18]
       mov       esi,eax
       jmp       near ptr M00_L11
M00_L23:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      esi,esi
       je        near ptr M00_L75
       mov       rcx,1CDA2001E10
       mov       rcx,[rcx]
       mov       edx,esi
       call      qword ptr [7FF7A9C4C760]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
M00_L24:
       mov       [rbp-80],rax
       lea       rcx,[rdi+18]
       mov       rdx,[rbp-80]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+20],rcx
       mov       byte ptr [rdi+28],1
       mov       [rbp-0E8],rdi
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       vmovdqu   xmm0,xmmword ptr [rbp-68]
       vmovdqu   xmmword ptr [rbp-90],xmm0
       lea       rcx,[r14+70]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-88]
       mov       [r14+78],ecx
       mov       ecx,[rbp-84]
       mov       [r14+7C],ecx
       lea       rcx,[r14+70]
       call      qword ptr [7FF7A9F95C38]
       mov       [r14+3C],al
       lea       rcx,[rbp-90]
       call      qword ptr [7FF7A9F95C50]
       mov       [r14+2C],eax
       test      byte ptr [rbp-84],4
       jne       near ptr M00_L76
       mov       rsi,20E370A1718
M00_L25:
       mov       ecx,[rsi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+78],0
       jne       short M00_L26
       mov       dword ptr [r14+78],3E8
M00_L26:
       mov       [rbp-0F0],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,[rbp-0A0]
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       lea       rdx,[rbp-58]
       mov       rcx,[rbp-0E8]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9F95C68]; System.Text.Json.PooledByteBufferWriter.get_WrittenSpan()
       lea       rcx,[rbp-58]
       call      qword ptr [7FF7A9B56070]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rbx,rax
       mov       rcx,r14
       mov       rdx,[rbp-0E8]
       call      qword ptr [7FF7A9C2FB70]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       [rbp-98],rbx
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+60]
       lea       r8,[rbp-98]
       mov       rdx,7FF7A9E0ADE0
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9DCD8A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,0E8
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
       mov       rdx,r8
       mov       rcx,rbx
       call      qword ptr [7FF7A9F94888]
       int       3
M00_L28:
       mov       edx,esi
       call      qword ptr [7FF7A9C279F0]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L19
M00_L29:
       mov       eax,2
       jmp       near ptr M00_L20
M00_L30:
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF7A99E4E28]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,[rbp-0A8]
       call      qword ptr [7FF7A9D5EF40]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FF7A9F94A08]
       mov       rdx,[rbp-0A8]
       lea       rcx,[rdx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L31:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L02
M00_L32:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L03
M00_L33:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rbx,rax
       jmp       near ptr M00_L04
M00_L34:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L05
M00_L35:
       mov       edi,1
       jmp       near ptr M00_L07
M00_L36:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       near ptr M00_L07
M00_L37:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rbx,rax
       jmp       near ptr M00_L08
M00_L38:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9EB6D90]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF7A9EB6DA8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L39:
       mov       ecx,3C7C
       mov       rdx,7FF7A9A244B8
       call      qword ptr [7FF7A95DF228]
       mov       rcx,rax
       mov       rdx,20E370AFFC0
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF7A9F94A20]
       int       3
M00_L40:
       mov       rcx,rsi
       call      qword ptr [7FF7A99ECDF8]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rdi,rax
       jmp       near ptr M00_L09
M00_L41:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FF7A951D110
       call      qword ptr [7FF7A95D7180]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,1CDA2001968
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L10
M00_L42:
       mov       rcx,r12
       mov       rdx,20E370AFFC0
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L13
M00_L43:
       mov       r13,[r13+18]
       test      r13,r13
       jne       near ptr M00_L12
       jmp       short M00_L45
M00_L44:
       mov       rcx,r15
       mov       r8,20E370AFFC0
       mov       rdx,r12
       mov       r11,7FF7A95211B8
       call      qword ptr [r11]
       jmp       near ptr M00_L13
M00_L45:
       xor       edx,edx
       mov       [rbp-0C8],rdx
       mov       [rbp-0D0],r14
       mov       rdx,20E370AFFC0
       mov       r8,rdi
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       [rbp-0E0],rax
       mov       rdi,[r14+8]
       jmp       near ptr M00_L60
M00_L46:
       mov       rcx,[rbp-0D8]
       mov       ecx,[rcx+8]
       cmp       [rbp-3C],ecx
       jae       near ptr M00_L55
       mov       rcx,[rbp-0D8]
       mov       eax,[rbp-3C]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       short M00_L47
       xor       ecx,ecx
       call      qword ptr [7FF7A9EB61C0]
       int       3
M00_L47:
       mov       rcx,r14
       call      00007FF809262D60
       test      eax,eax
       jne       short M00_L48
       mov       rcx,r14
       call      qword ptr [7FF7A97AFBD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M00_L48:
       mov       dword ptr [rbp-48],1
       mov       rcx,[rbp-0D0]
       mov       rax,[rbp-0C0]
       cmp       rcx,[rax+8]
       je        short M00_L51
       mov       rcx,[rax+8]
       mov       [rbp-0D0],rcx
       mov       rcx,[rbp-0D0]
       cmp       rdi,[rcx+8]
       je        near ptr M00_L59
       mov       rcx,[rbp-0D0]
       mov       rdi,[rcx+8]
       cmp       byte ptr [rax+19],0
       jne       short M00_L49
       mov       rcx,rdi
       mov       rdx,20E370AFFC0
       mov       r11,7FF7A95211C8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L50
M00_L49:
       mov       rcx,20E370AFFC0
       mov       rdx,[7FF7A951A1C0]
       call      qword ptr [rdx+18]
       mov       esi,eax
M00_L50:
       mov       rax,[rbp-0C0]
       jmp       near ptr M00_L59
M00_L51:
       xor       r14d,r14d
       mov       r15,[rbx]
       test      r15,r15
       je        short M00_L57
M00_L52:
       cmp       esi,[r15+20]
       jne       short M00_L53
       mov       rdx,[r15+8]
       mov       rcx,rdi
       mov       r8,20E370AFFC0
       mov       r11,7FF7A95211D0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0C0]
       jne       short M00_L54
M00_L53:
       inc       r14d
       mov       r15,[r15+18]
       test      r15,r15
       jne       short M00_L52
       jmp       short M00_L57
M00_L54:
       mov       rcx,[r15+10]
       mov       [rbp-0C8],rcx
       jmp       near ptr M00_L62
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L57:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13,[rbx]
       mov       rcx,20E370AFFC0
       mov       [r15+8],rcx
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0E0]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+20],esi
       mov       rcx,rbx
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0D0]
       mov       rdx,[rdx+20]
       mov       ecx,[rdx+8]
       cmp       [rbp-3C],ecx
       jae       short M00_L55
       mov       ecx,[rbp-3C]
       lea       rdx,[rdx+rcx*4+10]
       mov       ecx,[rdx]
       add       ecx,1
       jo        short M00_L56
       mov       [rdx],ecx
       mov       rdx,[rbp-0D0]
       mov       rdx,[rdx+20]
       mov       ecx,[rdx+8]
       cmp       [rbp-3C],ecx
       jae       near ptr M00_L55
       mov       ecx,[rbp-3C]
       mov       edx,[rdx+rcx*4+10]
       mov       ecx,1
       mov       rax,[rbp-0C0]
       cmp       edx,[rax+10]
       cmovle    ecx,[rbp-40]
       mov       [rbp-40],ecx
       cmp       r14d,64
       jbe       short M00_L58
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FF7A95D6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       ecx,1
       test      rax,rax
       cmove     ecx,[rbp-44]
       mov       [rbp-44],ecx
M00_L58:
       call      M00_L78
       jmp       near ptr M00_L63
M00_L59:
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-3C]
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L61
       mov       rcx,r14
       call      00007FF809262C80
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF7A986CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L60:
       mov       rax,[rbp-0D0]
       mov       rax,[rax+18]
       mov       [rbp-0D8],rax
       mov       rax,[rbp-0D0]
       mov       rcx,[rax+10]
       mov       rax,[rbp-0D0]
       mov       r8d,esi
       imul      r8,[rax+28]
       shr       r8,20
       inc       r8
       mov       r10d,[rcx+8]
       imul      r8,r10
       shr       r8,20
       mov       rax,[rbp-0D0]
       mov       r10,[rax+18]
       mov       eax,r8d
       xor       edx,edx
       div       dword ptr [r10+8]
       mov       [rbp-3C],edx
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L77
       mov       eax,r8d
       lea       rbx,[rcx+rax*8+10]
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       [rbp-44],ecx
       mov       [rbp-48],ecx
       jmp       near ptr M00_L46
M00_L61:
       xor       ecx,ecx
       call      qword ptr [7FF7A9EB61C0]
       int       3
M00_L62:
       call      M00_L78
       jmp       near ptr M00_L14
M00_L63:
       mov       ecx,[rbp-40]
       or        ecx,[rbp-44]
       je        short M00_L64
       mov       rcx,[rbp-0C0]
       mov       rdx,[rbp-0D0]
       mov       r8d,[rbp-40]
       mov       r9d,[rbp-44]
       call      qword ptr [7FF7A9CE4348]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
M00_L64:
       mov       r8,[rbp-0E0]
       mov       [rbp-0C8],r8
       jmp       near ptr M00_L14
M00_L65:
       call      qword ptr [7FF7A9EBDED8]
       int       3
M00_L66:
       mov       rcx,rbx
       call      qword ptr [7FF7A9AE6AD8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L15
M00_L67:
       mov       rcx,rsi
       mov       rdx,20E370AFFC0
       call      qword ptr [7FF7A99ED398]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       jmp       near ptr M00_L15
M00_L68:
       mov       rcx,20E370BBA48
       call      qword ptr [7FF7A9F948A0]
       mov       rbx,rax
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FF7A97A61D8]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L69
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L69
       jmp       short M00_L70
M00_L69:
       mov       rcx,rax
       call      qword ptr [7FF7A97A56E0]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
M00_L70:
       mov       rsi,[rcx+30]
       test      rsi,rsi
       jne       short M00_L71
       lea       rdx,[rcx+30]
       mov       r8d,1
       call      qword ptr [7FF7A97ACC60]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
M00_L71:
       mov       rcx,20E370B2DF0
       test      rsi,rsi
       cmove     rsi,rcx
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rbx
       mov       rdx,20E370AFFC0
       mov       r8,rsi
       call      qword ptr [7FF7A9DCC450]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF7A9956010]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L72:
       mov       rcx,rbx
       call      qword ptr [7FF7A9AE6AD8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L16
M00_L73:
       mov       ecx,9
       call      qword ptr [7FF7A9EB69D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdi,rax
       jmp       near ptr M00_L17
M00_L74:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1CDA2002A90
       mov       rsi,[rcx]
       jmp       near ptr M00_L21
M00_L75:
       mov       rax,20E370A6EF8
       jmp       near ptr M00_L24
M00_L76:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1CDA2002A90
       mov       rsi,[rcx]
       jmp       near ptr M00_L25
M00_L77:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L78:
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp-48],0
       je        short M00_L81
       mov       rcx,[rbp-0D8]
       mov       ecx,[rcx+8]
       cmp       [rbp-3C],ecx
       jae       short M00_L79
       mov       rcx,[rbp-0D8]
       mov       eax,[rbp-3C]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       short M00_L80
       xor       ecx,ecx
       call      qword ptr [7FF7A9EB61C0]
       int       3
M00_L79:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L80:
       mov       rcx,r14
       call      00007FF809262C80
       test      eax,eax
       je        short M00_L81
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF7A986CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L81:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E8]
       call      qword ptr [7FF7A9C2FB70]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       nop
       add       rsp,28
       ret
; Total bytes of code 3398
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
       je        short M01_L01
M01_L00:
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       call      qword ptr [7FF7A95D5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M01_L00
; Total bytes of code 41
```
```assembly
; System.RuntimeType.IsAssignableFrom(System.Type)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L06
       cmp       rbx,rsi
       jne       short M02_L01
M02_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rdx,rax
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FF7A95D6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF7A9EB6B80]; System.RuntimeTypeHandle.CanCastTo(System.RuntimeType, System.RuntimeType)
M02_L02:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      qword ptr [7FF7A95D6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M02_L06
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rax,[rbx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rsi
       call      qword ptr [7FF7A97A69B8]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       je        short M02_L03
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF7A9EB6B20]
M02_L03:
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FF8092028C0
       test      eax,eax
       je        short M02_L06
       mov       rcx,rsi
       call      qword ptr [7FF7A951A400]
       mov       rsi,rax
       xor       edi,edi
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rsi+rdi*8+10]
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M02_L06
       inc       edi
M02_L05:
       cmp       [rsi+8],edi
       jg        short M02_L04
       jmp       near ptr M02_L00
M02_L06:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 252
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rax,rdx
       mov       rbx,[rcx+40]
       cmp       byte ptr [rcx+9C],0
       setne     sil
       movzx     esi,sil
       movzx     edx,word ptr [rcx+90]
       cmp       edx,20
       jne       near ptr M03_L10
       and       esi,0FFFFFFF7
M03_L00:
       mov       edx,[rcx+84]
       cmp       edx,7F
       ja        near ptr M03_L12
       and       esi,0FFFFF80F
       test      edx,edx
       je        near ptr M03_L07
       xor       r8d,r8d
       cmp       edx,2
       cmovne    r8d,edx
M03_L01:
       shl       r8d,4
       or        esi,r8d
       mov       edi,[rcx+88]
       test      edi,edi
       jl        near ptr M03_L13
       mov       r8,[rcx+50]
       test      r8,r8
       je        near ptr M03_L14
M03_L02:
       mov       rcx,20E370AFFA8
       cmp       r8,rcx
       je        short M03_L04
       cmp       dword ptr [r8+8],1
       jne       short M03_L03
       cmp       word ptr [r8+0C],0A
       je        short M03_L04
M03_L03:
       mov       rcx,20E370A1718
       cmp       r8,rcx
       je        short M03_L04
       cmp       dword ptr [r8+8],2
       jne       short M03_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M03_L08
M03_L04:
       mov       rcx,20E370A1718
       cmp       r8,rcx
       je        short M03_L05
       cmp       dword ptr [r8+8],2
       jne       short M03_L09
       cmp       dword ptr [r8+0C],0A000D
       jne       short M03_L09
M03_L05:
       and       esi,0FFFFFFFB
M03_L06:
       or        esi,2
       mov       [rax],rbx
       mov       [rax+8],edi
       mov       [rax+0C],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L07:
       mov       r8d,2
       jmp       near ptr M03_L01
M03_L08:
       mov       ecx,38A0
       mov       rdx,7FF7A9A244B8
       call      qword ptr [7FF7A95DF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9F94A80]
       int       3
M03_L09:
       or        esi,4
       jmp       short M03_L06
M03_L10:
       cmp       edx,9
       je        short M03_L11
       mov       ecx,38A0
       mov       rdx,7FF7A9A244B8
       call      qword ptr [7FF7A95DF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9F94A38]
       int       3
M03_L11:
       or        esi,8
       jmp       near ptr M03_L00
M03_L12:
       mov       ecx,38A0
       mov       rdx,7FF7A9A244B8
       call      qword ptr [7FF7A95DF228]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FF7A9F94A50]
       int       3
M03_L13:
       mov       ecx,38A0
       mov       rdx,7FF7A9A244B8
       call      qword ptr [7FF7A95DF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9F94A68]
       int       3
M03_L14:
       mov       r8,20E370A1718
       mov       [rcx+50],r8
       jmp       near ptr M03_L02
; Total bytes of code 418
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       ebx,edx
       mov       rcx,1CDA20003A0
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0A
       jle       short M04_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M04_L02
M04_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M04_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M04_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M04_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M04_L03
M04_L01:
       mov       rax,r14
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
M04_L02:
       mov       ecx,0A
       call      qword ptr [7FF7A9EB69D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M04_L00
M04_L03:
       mov       rcx,r14
       call      qword ptr [7FF7A99ECF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF7A99ECF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF7A9EBF030]
       jmp       short M04_L01
M04_L04:
       mov       rax,[rsi+10]
       cmp       [rax+8],ebp
       jbe       near ptr M04_L13
       mov       ecx,ebp
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        near ptr M04_L12
       mov       r14,[rax+8]
       call      qword ptr [7FF7A9CEF360]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       ebx,eax
       sub       ebx,ecx
       xor       r15d,r15d
       jmp       short M04_L08
M04_L05:
       cmp       ebx,[r14+8]
       jae       near ptr M04_L18
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FF7A9AEDB78]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M04_L06
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M04_L06:
       mov       rcx,r13
       call      qword ptr [7FF7A95D6820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M04_L09
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M04_L07
       xor       ebx,ebx
M04_L07:
       inc       r15d
M04_L08:
       cmp       [r14+8],r15d
       jg        short M04_L05
       jmp       short M04_L10
M04_L09:
       mov       r14,r12
       jmp       short M04_L11
M04_L10:
       xor       r14d,r14d
M04_L11:
       test      r14,r14
       je        short M04_L12
       cmp       byte ptr [rdi+9D],0
       je        near ptr M04_L01
       mov       rcx,r14
       call      qword ptr [7FF7A99ECF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF7A99ECF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF7A9EBF030]
       jmp       near ptr M04_L01
M04_L12:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M04_L15
M04_L13:
       test      ebx,ebx
       jne       short M04_L14
       mov       rax,20E370A6EF8
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
M04_L14:
       mov       ecx,ebx
       mov       rdx,20E370A3D28
       call      qword ptr [7FF7A986D920]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M04_L15:
       cmp       ebx,800
       jge       short M04_L16
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M04_L17
M04_L16:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FF7A9C27A98]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M04_L17:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M04_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FF7A99ECF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF7A99ECF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF7A9EBF030]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF7A99ECF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rsi+10]
       mov       edx,1
       mov       r8d,2
       cmp       [rcx+8],ebp
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rdi
       mov       edx,ebx
       mov       r8d,r15d
       call      qword ptr [7FF7A9EBF048]
       jmp       near ptr M04_L01
M04_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 712
```
```assembly
; System.Text.Json.PooledByteBufferWriter.get_WrittenSpan()
       sub       rsp,28
       add       rcx,18
       mov       rax,[rcx]
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       mov       ecx,[rcx+0C]
       sub       ecx,r8d
       test      rax,rax
       je        short M05_L01
       mov       r8d,ecx
       add       r8,r10
       mov       r9d,[rax+8]
       cmp       r8,r9
       ja        short M05_L02
       lea       rax,[rax+r10+10]
M05_L00:
       mov       [rdx],rax
       mov       [rdx+8],ecx
       mov       rax,rdx
       add       rsp,28
       ret
M05_L01:
       or        r10d,ecx
       jne       short M05_L02
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M05_L00
M05_L02:
       call      qword ptr [7FF7A97AF750]
       int       3
; Total bytes of code 81
```
```assembly
; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-40],rax
       mov       r8,1CDA20013D8
       mov       rbx,[r8]
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       r8d,1
       test      edi,edi
       cmove     rsi,r8
       mov       [rbp-38],rsi
       test      rsi,rsi
       je        near ptr M06_L03
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FF7A97ACD98]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       mov       r9d,eax
       sub       r9d,esi
       mov       r14d,r9d
       add       r14d,[rbp-48]
       cmp       r9d,edi
       jne       near ptr M06_L04
M06_L00:
       test      r14d,r14d
       je        near ptr M06_L05
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FF809259F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       [rbp-40],rcx
       mov       r13,[rbp-40]
       test      r13,r13
       je        near ptr M06_L06
       mov       ecx,edi
       or        ecx,r14d
       jl        near ptr M06_L07
       lea       rcx,[rbp-58]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-60]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       mov       edx,edi
       mov       r8,r13
       mov       r9d,r14d
       call      qword ptr [7FF7A97ACDC8]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
       mov       ecx,[rbp-58]
       sub       ecx,esi
       mov       rdx,[rbp-60]
       sub       rdx,r13
       mov       r8,rdx
       shr       r8,3F
       add       rdx,r8
       sar       rdx,1
       cmp       ecx,edi
       jne       short M06_L08
M06_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
M06_L02:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       near ptr M06_L09
M06_L03:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FF7A9B5DFE0]
       int       3
M06_L04:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FF7A9B5DFB0]
       add       r14d,eax
       jns       near ptr M06_L00
       call      qword ptr [7FF7A9B5DFF8]
       int       3
M06_L05:
       mov       r15,20E370A0008
       jmp       short M06_L02
M06_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FF7A9B5DFE0]
       int       3
M06_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FF7A9B55E90]
       int       3
M06_L08:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,r13
       call      qword ptr [7FF7A9B5E250]
       jmp       near ptr M06_L01
M06_L09:
       mov       rax,r15
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,48
       call      qword ptr [7FF7A9B5E790]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 442
```
```assembly
; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
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
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M07_L37
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M07_L37
M07_L00:
       mov       rdi,[rax+10]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       [rbx+20],rcx
       mov       [rbx+40],rcx
       mov       [rbx+48],rcx
       mov       byte ptr [rbx+38],0
       mov       word ptr [rbx+39],0
       mov       [rbx+28],ecx
       mov       [rbx+50],rcx
       mov       [rbx+58],rcx
       mov       [rbx+60],rcx
       mov       [rbx+68],cx
       mov       [rbx+6A],cl
       mov       byte ptr [rbx+3B],0
       mov       [rbx+10],rcx
       mov       [rbx+18],rcx
       mov       [rbx+8],rcx
       cmp       [rsi],sil
       add       rsi,18
       mov       [rsi+8],ecx
       mov       [rsi+0C],ecx
       mov       rbx,[rsi]
       mov       rcx,20E370A6EF8
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M07_L36
       cmp       dword ptr [rbx+8],0
       je        near ptr M07_L36
       mov       rcx,1CDA2001E10
       mov       rsi,[rcx]
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M07_L38
       mov       rcx,[rcx+240]
       mov       r15,[rcx+50]
       test      r15,r15
       je        near ptr M07_L38
M07_L01:
       mov       rax,[r15+10]
       test      rax,rax
       jne       near ptr M07_L16
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolThreadLocalArray[]
       mov       edx,1B
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       lea       rcx,[r15+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15,[rsi+8]
       mov       rcx,[r15+8]
       mov       [rbp-80],rcx
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       qword ptr [rbp-80],0
       je        near ptr M07_L07
       mov       rcx,[rbp-80]
       call      00007FF809262D60
       test      eax,eax
       jne       short M07_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FF7A97AFBD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M07_L02:
       mov       dword ptr [rbp-40],1
       mov       rcx,[r15+10]
       lea       r8,[rbp-48]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF7A986CFA8]; System.Runtime.CompilerServices.ConditionalWeakTable`2+Container[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindEntry(System.__Canon, System.Object ByRef)
       cmp       eax,0FFFFFFFF
       jne       near ptr M07_L08
       mov       r12,[r15+10]
       mov       ecx,[r12+28]
       mov       rax,[r12+18]
       cmp       ecx,[rax+8]
       jge       near ptr M07_L09
M07_L03:
       cmp       byte ptr [r12+2C],0
       jne       near ptr M07_L10
       mov       byte ptr [r12+2C],1
       mov       rcx,r13
       call      00007FF8091F1BC0
       test      eax,eax
       je        near ptr M07_L06
M07_L04:
       mov       r15d,eax
       and       r15d,7FFFFFFF
       mov       eax,[r12+28]
       mov       [rbp-4C],eax
       lea       ecx,[rax+1]
       mov       [r12+28],ecx
       mov       rcx,[r12+18]
       cmp       eax,[rcx+8]
       jae       near ptr M07_L11
       mov       edx,eax
       shl       rdx,4
       lea       r8,[rcx+rdx+10]
       mov       [r8],r15d
       mov       [rbp-88],r8
       mov       rcx,r13
       xor       edx,edx
       call      00007FF809225B60
       test      rax,rax
       je        near ptr M07_L12
M07_L05:
       mov       rcx,[rbp-88]
       mov       [rcx+8],rax
       mov       rcx,[r12+10]
       mov       eax,[rcx+8]
       dec       eax
       and       eax,r15d
       mov       rdx,[r12+18]
       mov       r15d,[rbp-4C]
       cmp       r15d,[rdx+8]
       jae       near ptr M07_L11
       mov       r8d,r15d
       shl       r8,4
       mov       r10,rcx
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       near ptr M07_L11
       mov       r10d,[r10+rax*4+10]
       mov       [rdx+r8+14],r10d
       mov       [rcx+rax*4+10],r15d
       mov       byte ptr [r12+2C],0
       jmp       near ptr M07_L13
M07_L06:
       mov       rcx,r13
       call      qword ptr [7FF7A97A77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L04
M07_L07:
       xor       ecx,ecx
       call      qword ptr [7FF7A9EB61C0]
       int       3
M07_L08:
       mov       ecx,36
       call      qword ptr [7FF7A9EBF330]
       int       3
M07_L09:
       mov       rcx,r12
       call      qword ptr [7FF7A9F95C80]
       mov       r12,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M07_L03
M07_L10:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9F95C98]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A9956010]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M07_L12:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF7A9F95CB0]
       jmp       near ptr M07_L05
M07_L13:
       mov       rcx,[rbp-80]
       call      00007FF809262C80
       test      eax,eax
       jne       near ptr M07_L39
M07_L14:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       lea       rcx,[rsi+18]
       mov       eax,1
       xchg      al,[rcx]
       movzx     eax,al
       test      eax,eax
       je        near ptr M07_L27
M07_L15:
       mov       rax,r13
M07_L16:
       xor       r15d,r15d
       mov       r13d,1
       cmp       [rax+8],r14d
       jbe       near ptr M07_L23
       mov       r15d,1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       [rbx+8],ecx
       jne       near ptr M07_L41
       mov       ecx,r14d
       shl       rcx,4
       lea       r12,[rax+rcx+10]
       mov       rax,[r12]
       mov       [rbp-78],rax
       mov       rcx,r12
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r12+8],ecx
       mov       r12,[rbp-78]
       test      r12,r12
       je        near ptr M07_L23
       mov       rcx,[rsi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M07_L46
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M07_L17
       mov       rcx,rsi
       mov       edx,r14d
       call      qword ptr [7FF7A9F948E8]
M07_L17:
       mov       r13,[rax+8]
       call      qword ptr [7FF7A9CEF360]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       mov       edx,[r13+8]
       mov       [rbp-6C],edx
       test      edx,edx
       jle       near ptr M07_L45
       mov       [rbp-70],edx
M07_L18:
       cmp       eax,edx
       jae       near ptr M07_L46
       mov       [rbp-5C],eax
       mov       ecx,eax
       mov       r10,[r13+rcx*8+10]
       mov       [rbp-90],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-60],r9d
       mov       rcx,r10
       call      00007FF809262D60
       test      eax,eax
       jne       short M07_L19
       mov       rcx,[rbp-90]
       call      qword ptr [7FF7A97AFBD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M07_L19:
       mov       rax,[rbp-90]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-64],r8d
       cmp       [rcx+8],r8d
       jbe       short M07_L21
       test      r8d,r8d
       je        near ptr M07_L30
M07_L20:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-64]
       inc       ecx
       mov       rax,[rbp-90]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-60],1
M07_L21:
       mov       rcx,rax
       call      00007FF809262C80
       test      eax,eax
       jne       near ptr M07_L42
M07_L22:
       cmp       dword ptr [rbp-60],0
       je        near ptr M07_L43
       mov       r13d,1
M07_L23:
       mov       rcx,1CDA20003A0
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       je        near ptr M07_L36
       mov       rcx,rbx
       call      00007FF8091F1BC0
       test      eax,eax
       je        near ptr M07_L31
       mov       [rbp-68],eax
M07_L24:
       mov       edx,[rbx+8]
       mov       [rbp-3C],edx
       mov       rcx,rsi
       call      00007FF8091F1BC0
       test      eax,eax
       je        near ptr M07_L32
M07_L25:
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-68]
       mov       r9d,[rbp-3C]
       mov       edx,3
       call      qword ptr [7FF7A9EBF0D8]
       test      r13d,r15d
       jne       near ptr M07_L36
       mov       rcx,rbx
       call      qword ptr [7FF7A99ECF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      00007FF8091F1BC0
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M07_L33
M07_L26:
       test      r15d,r15d
       jne       near ptr M07_L34
       mov       r14d,0FFFFFFFF
       mov       ecx,1
       jmp       near ptr M07_L35
M07_L27:
       mov       r15,1CDA2001F60
       mov       r12,[r15]
       test      r12,r12
       jne       short M07_L28
       mov       rcx,offset MT_System.Func<System.Object, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,1CDA2001F58
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Buffers.SharedArrayPool`1+<>c[[System.Byte, System.Private.CoreLib]].<InitializeTlsBucketsAndTrimming>b__11_0(System.Object)
       mov       [r12+18],rcx
       mov       rcx,r15
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M07_L28:
       mov       rcx,offset MT_System.Gen2GcCallback
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       xor       edx,edx
       call      00007FF8091FFF00
       test      rax,rax
       je        near ptr M07_L40
M07_L29:
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [r15+18],rcx
       jmp       near ptr M07_L15
M07_L30:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       near ptr M07_L20
M07_L31:
       mov       rcx,rbx
       call      qword ptr [7FF7A97A77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       [rbp-68],eax
       jmp       near ptr M07_L24
M07_L32:
       mov       rcx,rsi
       call      qword ptr [7FF7A97A77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M07_L25
M07_L33:
       mov       rcx,rsi
       call      qword ptr [7FF7A97A77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M07_L26
M07_L34:
       xor       ecx,ecx
M07_L35:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,ebx
       call      qword ptr [7FF7A9EBF0F0]
M07_L36:
       dec       dword ptr [rdi+18]
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
M07_L37:
       mov       ecx,9
       call      qword ptr [7FF7A9EB69D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M07_L00
M07_L38:
       mov       ecx,0A
       call      qword ptr [7FF7A9EB69D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M07_L01
M07_L39:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FF7A986CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M07_L14
M07_L40:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF7A9F95D28]
       jmp       near ptr M07_L29
M07_L41:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7A9EBF0C0]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF7A9514000
       call      qword ptr [7FF7A95DF228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF7A99560B8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M07_L42:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FF7A986CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M07_L22
M07_L43:
       mov       eax,[rbp-5C]
       inc       eax
       mov       ecx,eax
       mov       edx,[rbp-6C]
       cmp       edx,ecx
       jne       short M07_L44
       xor       ecx,ecx
M07_L44:
       mov       r8d,[rbp-70]
       dec       r8d
       mov       [rbp-70],r8d
       mov       eax,ecx
       jne       near ptr M07_L18
M07_L45:
       xor       r13d,r13d
       jmp       near ptr M07_L23
M07_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-40],0
       je        short M07_L48
       cmp       qword ptr [rbp-80],0
       jne       short M07_L47
       xor       ecx,ecx
       call      qword ptr [7FF7A9EB61C0]
       int       3
M07_L47:
       mov       rcx,[rbp-80]
       call      00007FF809262C80
       test      eax,eax
       je        short M07_L48
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FF7A986CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M07_L48:
       nop
       add       rsp,38
       ret
; Total bytes of code 1862
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
; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,[rbx]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M09_L20
       mov       rcx,1CDA2001E10
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       ebp,edx
       mov       rcx,1CDA20003A0
       mov       r14,[rcx]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0A
       jle       short M09_L04
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M09_L04
M09_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M09_L06
       mov       eax,[rcx+8]
       cmp       eax,r15d
       jbe       near ptr M09_L06
       mov       eax,r15d
       shl       rax,4
       mov       r13,[rcx+rax+10]
       test      r13,r13
       je        short M09_L06
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [r14+9D],0
       jne       short M09_L05
M09_L01:
       mov       rdx,r13
M09_L02:
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M09_L03:
       nop
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
M09_L04:
       mov       ecx,0A
       call      qword ptr [7FF7A9EB69D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M09_L00
M09_L05:
       mov       rcx,r13
       call      qword ptr [7FF7A99ECF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       ebp,[r13+8]
       mov       rcx,rsi
       call      qword ptr [7FF7A99ECF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF7A9EBF030]
       jmp       short M09_L01
M09_L06:
       mov       rax,[rdi+10]
       cmp       [rax+8],r15d
       jbe       near ptr M09_L15
       mov       ecx,r15d
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        near ptr M09_L14
       mov       r13,[rax+8]
       call      qword ptr [7FF7A9CEF360]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       ebp,eax
       sub       ebp,ecx
       xor       esi,esi
       jmp       short M09_L10
M09_L07:
       cmp       ebp,[r13+8]
       jae       near ptr M09_L26
       mov       ecx,ebp
       mov       r12,[r13+rcx*8+10]
       cmp       [r12],r12b
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rcx,r12
       call      qword ptr [7FF7A9AEDB78]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r12+8]
       mov       eax,[r12+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M09_L08
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       mov       [rsp+30],rdx
       mov       r8d,eax
       xor       r10d,r10d
       mov       [rcx+r8*8+10],r10
       mov       [r12+10],eax
M09_L08:
       mov       rcx,r12
       call      qword ptr [7FF7A95D6820]; System.Threading.Monitor.Exit(System.Object)
       mov       r12,[rsp+30]
       test      r12,r12
       jne       short M09_L11
       inc       ebp
       cmp       [r13+8],ebp
       jne       short M09_L09
       xor       ebp,ebp
M09_L09:
       inc       esi
M09_L10:
       cmp       [r13+8],esi
       jg        short M09_L07
       jmp       short M09_L12
M09_L11:
       mov       r13,r12
       jmp       short M09_L13
M09_L12:
       xor       r13d,r13d
M09_L13:
       test      r13,r13
       je        short M09_L14
       cmp       byte ptr [r14+9D],0
       je        near ptr M09_L01
       mov       rcx,r13
       call      qword ptr [7FF7A99ECF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF7A99ECF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF7A9EBF030]
       jmp       near ptr M09_L01
M09_L14:
       mov       ecx,10
       shlx      ebp,ecx,r15d
       jmp       short M09_L17
M09_L15:
       test      ebp,ebp
       jne       short M09_L16
       mov       rdx,20E370A6EF8
       jmp       near ptr M09_L02
M09_L16:
       mov       ecx,ebp
       mov       rdx,20E370A3D28
       call      qword ptr [7FF7A986D920]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M09_L17:
       cmp       ebp,800
       jge       short M09_L18
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M09_L19
M09_L18:
       mov       ecx,ebp
       xor       edx,edx
       call      qword ptr [7FF7A9C27A98]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M09_L19:
       cmp       byte ptr [r14+9D],0
       je        near ptr M09_L01
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF7A99ECF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF7A99ECF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF7A9EBF030]
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF7A99ECF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rdi+10]
       mov       edx,1
       mov       r8d,2
       cmp       [rcx+8],r15d
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r14
       mov       edx,esi
       mov       r8d,ebp
       call      qword ptr [7FF7A9EBF048]
       jmp       near ptr M09_L01
M09_L20:
       mov       ecx,[rbx+8]
       mov       rax,[rbx]
       mov       eax,[rax+8]
       sub       eax,[rbx+0C]
       add       ecx,eax
       cmp       edx,ecx
       jg        short M09_L21
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       r8,[rbx]
       mov       rcx,[rbx]
       xor       r9d,r9d
       call      qword ptr [7FF7A98668C8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       eax,[rbx+8]
       sub       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+8],eax
       jmp       near ptr M09_L03
M09_L21:
       mov       ecx,[rbx+0C]
       sub       ecx,[rbx+8]
       add       ecx,edx
       cmp       ecx,7FFFFFC7
       jbe       short M09_L22
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A9EBEF28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L22:
       mov       rdx,[rbx]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,7FFFFFC7
       cmp       rdx,7FFFFFC7
       cmovl     rax,rdx
       cmp       ecx,eax
       mov       edx,eax
       cmovge    edx,ecx
       cmp       byte ptr [rbx+10],0
       jne       short M09_L23
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M09_L24
M09_L23:
       mov       rcx,1CDA2001E10
       mov       rcx,[rcx]
       call      qword ptr [7FF7A9C4C760]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rsi,rax
M09_L24:
       mov       rdi,[rbx]
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       je        short M09_L25
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       rcx,rdi
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF7A98668C8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
M09_L25:
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+10],0
       je        near ptr M09_L03
       cmp       dword ptr [rdi+8],0
       je        near ptr M09_L03
       mov       rcx,1CDA2001E10
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF7A9C4C768]; Precode of System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M09_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1092
```
```assembly
; System.Text.Json.JsonSerializerOptions..ctor()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       dword ptr [rbx+7C],4000
       call      qword ptr [7FF8127484D8]
       movzx     ecx,byte ptr [rax+1]
       mov       [rbx+95],cl
       movzx     eax,byte ptr [rax+2]
       mov       [rbx+96],al
       mov       word ptr [rbx+90],20
       mov       dword ptr [rbx+84],2
       mov       byte ptr [rbx+9D],1
       mov       dword ptr [rbx+88],40
       call      qword ptr [7FF812748550]
       mov       rcx,[rax]
       mov       rdx,rbx
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       xor       r8d,r8d
       cmp       [rcx],ecx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [r11]
; Total bytes of code 109
```
```assembly
; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       sub       rsp,28
       cmp       byte ptr [rcx+9E],0
       jne       short M11_L01
       mov       rax,[rcx+58]
       test      rax,rax
       jne       short M11_L02
M11_L00:
       lea       rcx,[rcx+20]
       call      qword ptr [7FF812748278]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M11_L01:
       mov       rcx,[rcx+20]
       call      qword ptr [7FF81274A688]
       mov       rcx,rax
       call      qword ptr [7FF81274CE70]
       int       3
M11_L02:
       cmp       rax,rdx
       je        short M11_L00
       xor       r8d,r8d
       mov       [rax+10],r8
       mov       [rcx+58],r8
       jmp       short M11_L00
; Total bytes of code 76
```
```assembly
; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF81274E588]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF81274C548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       test      rax,rax
       cmove     rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7A99ED398]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M13_L00:
       mov       rcx,7FF7A9F86BE4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-20]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,7FF7A9F86BE0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A9EBE4A8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF7A9EBFA08]
       mov       [rbp-20],rsi
       lea       rax,[M13_L00]
       add       rsp,28
       ret
; Total bytes of code 185
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
       call      qword ptr [7FFFFEC04030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFFFEC04038]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M16_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M16_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L02
M16_L00:
       test      rax,rax
       je        short M16_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L02
       test      rax,rax
       je        short M16_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L02
       test      rax,rax
       jne       short M16_L03
M16_L01:
       xor       edx,edx
M16_L02:
       mov       rax,rdx
       ret
M16_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L02
       test      rax,rax
       je        short M16_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L02
       jmp       short M16_L00
; Total bytes of code 86
```
```assembly
; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       mov       [rbp+18],rdx
       mov       edx,ecx
       lea       rcx,[rbp+18]
       mov       [rbp-9C],rcx
       mov       [rbp-94],edx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFFFEC04030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       mov       rcx,[rbp-9C]
       mov       edx,[rbp-94]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFFFEC04038]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 119
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
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
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       edi,r9d
       xor       eax,eax
       mov       [rbp-48],eax
       mov       rax,[rcx+8]
       mov       rax,[rax+18]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M18_L15
       mov       rcx,[rax+10]
       call      qword ptr [7FF83A9FAB70]; Precode of System.Threading.Monitor.Enter(System.Object)
       mov       dword ptr [rbp-48],1
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+8]
       jne       near ptr M18_L17
       mov       rax,[rbx+10]
       mov       r14d,[rax+8]
       xor       r15d,r15d
       test      dil,dil
       je        short M18_L01
       mov       rcx,[rbx+8]
       call      qword ptr [7FF83A9FAA38]
       mov       rdi,rax
       test      rdi,rdi
       je        short M18_L01
       mov       rcx,[rbp+10]
       mov       r13,[rcx]
       mov       rcx,r13
       call      qword ptr [7FF83A9FA3B0]
       mov       r15,rax
       mov       rcx,rdi
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       call      qword ptr [r11]
       mov       r8,rax
       test      r8,r8
       je        short M18_L00
       mov       rcx,r15
       cmp       [r8],rcx
       je        short M18_L00
       mov       rdx,rax
       call      qword ptr [7FF83A9FA290]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
       mov       r8,r15
M18_L00:
       mov       r15,r8
M18_L01:
       test      sil,sil
       je        short M18_L04
       test      r15,r15
       jne       short M18_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FF83A9FB158]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetCountNoLocks()
       mov       rcx,[rbx+10]
       mov       ecx,[rcx+8]
       shr       ecx,2
       cmp       eax,ecx
       jl        near ptr M18_L14
M18_L02:
       mov       rax,[rbx+10]
       mov       eax,[rax+8]
       add       eax,eax
       js        short M18_L03
       mov       ecx,eax
       call      qword ptr [7FF83A9FAE98]; Precode of System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       call      qword ptr [7FF83A9FAA68]; Precode of System.Array.get_MaxLength()
       cmp       eax,r14d
       jge       short M18_L04
M18_L03:
       call      qword ptr [7FF83A9FAA68]; Precode of System.Array.get_MaxLength()
       mov       r14d,eax
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+10],7FFFFFFF
M18_L04:
       mov       rsi,[rbx+18]
       mov       rdi,rsi
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+18],0
       je        short M18_L06
       cmp       dword ptr [rsi+8],400
       jge       short M18_L06
       mov       eax,[rsi+8]
       add       eax,eax
       movsxd    rcx,eax
       call      qword ptr [7FF83A9FAA20]
       mov       rdi,rax
       mov       r8d,[rsi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF83A9FAA50]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,[rbx+18]
       mov       esi,[rax+8]
       mov       r13d,[rdi+8]
       cmp       r13d,esi
       jle       short M18_L06
M18_L05:
       call      qword ptr [7FF83A9FA988]
       mov       r8,rax
       movsxd    rdx,esi
       mov       rcx,rdi
       call      qword ptr [7FF83A9FA270]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       esi
       cmp       r13d,esi
       jg        short M18_L05
M18_L06:
       mov       rcx,[rbp+10]
       mov       r13,[rcx]
       mov       rcx,r13
       call      qword ptr [7FF83A9FA600]
       mov       rcx,rax
       movsxd    rdx,r14d
       call      qword ptr [7FF83A9FA288]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       ecx,[rdi+8]
       call      qword ptr [7FF83A9FAA28]
       mov       r14,rax
       mov       r12,r15
       test      r12,r12
       jne       short M18_L07
       mov       r12,[rbx+8]
M18_L07:
       mov       rcx,r13
       call      qword ptr [7FF83A9FA450]
       mov       rcx,rax
       call      qword ptr [7FF83A9FA280]; CORINFO_HELP_NEWFAST
       mov       [rbp-78],rax
       lea       rcx,[rax+10]
       mov       rdx,rsi
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+18]
       mov       rdx,rdi
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+20]
       mov       rdx,r14
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rsi+8]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       r12,[rbp-78]
       mov       [r12+28],rax
       mov       rcx,r13
       call      qword ptr [7FF83A9FA418]
       mov       rcx,rax
       lea       r8,[rbp-48]
       mov       rdx,rbx
       call      qword ptr [7FF83A9FB178]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].AcquirePostFirstLock(Tables<System.__Canon,System.__Canon>, Int32 ByRef)
       mov       rbx,[rbx+10]
       xor       eax,eax
       jmp       near ptr M18_L13
M18_L08:
       mov       [rbp-58],rax
       mov       rdx,[rbx+rax*8+10]
       test      rdx,rdx
       je        near ptr M18_L12
M18_L09:
       test      r15,r15
       jne       short M18_L10
       mov       [rbp-68],rdx
       mov       r8d,[rdx+20]
       jmp       short M18_L11
M18_L10:
       mov       [rbp-68],rdx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       call      qword ptr [7FF83A9FA740]
       mov       r8,[rbp-68]
       mov       rdx,[r8+8]
       mov       rcx,r15
       mov       r11,rax
       call      qword ptr [rax]
       mov       r8d,eax
M18_L11:
       mov       r10,[rbp-68]
       mov       r9,[r10+18]
       mov       [rbp-80],r9
       mov       rcx,[r12+10]
       mov       [rbp-4C],r8d
       mov       r11d,r8d
       imul      r11,[r12+28]
       shr       r11,20
       inc       r11
       mov       edx,[rcx+8]
       mov       [rbp-50],edx
       mov       eax,edx
       imul      r11,rax
       shr       r11,20
       mov       rsi,[r12+18]
       mov       eax,r11d
       xor       edx,edx
       div       dword ptr [rsi+8]
       mov       esi,edx
       cmp       r11d,[rbp-50]
       jae       near ptr M18_L15
       mov       eax,r11d
       lea       rax,[rcx+rax*8+10]
       mov       [rbp-70],rax
       mov       rcx,r13
       call      qword ptr [7FF83A9FA438]
       mov       rcx,rax
       call      qword ptr [7FF83A9FA280]; CORINFO_HELP_NEWFAST
       mov       [rbp-88],rax
       mov       r8,[rbp-68]
       mov       rdx,[r8+8]
       mov       r8,[r8+10]
       mov       [rbp-90],r8
       mov       r10,[rbp-70]
       mov       r9,[r10]
       mov       [rbp-98],r9
       lea       rcx,[rax+8]
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-90]
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       lea       rcx,[rax+18]
       mov       rdx,[rbp-98]
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       mov       ecx,[rbp-4C]
       mov       [rax+20],ecx
       mov       rcx,[rbp-70]
       mov       rdx,rax
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       cmp       esi,[r14+8]
       jae       short M18_L15
       mov       eax,esi
       lea       rax,[r14+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        short M18_L16
       mov       [rax],edx
       mov       rsi,[rbp-80]
       test      rsi,rsi
       mov       rdx,rsi
       jne       near ptr M18_L09
M18_L12:
       mov       rsi,[rbp-58]
       inc       esi
       mov       rax,rsi
M18_L13:
       mov       ecx,[rbx+8]
       cmp       ecx,eax
       jg        near ptr M18_L08
       mov       rsi,[rbp-60]
       mov       eax,[rsi+8]
       xor       edx,edx
       div       dword ptr [rdi+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp+10]
       mov       [rax+10],ecx
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      qword ptr [7FF83A9FA258]; CORINFO_HELP_ASSIGN_REF
       jmp       short M18_L17
M18_L14:
       mov       rcx,[rbp+10]
       mov       edx,[rcx+10]
       add       edx,edx
       mov       [rcx+10],edx
       test      edx,edx
       jge       short M18_L17
       mov       dword ptr [rcx+10],7FFFFFFF
       jmp       short M18_L17
M18_L15:
       call      qword ptr [7FF83A9FA250]
       int       3
M18_L16:
       call      qword ptr [7FF83A9FA248]
       int       3
M18_L17:
       mov       rcx,[rbp+10]
       mov       edx,[rbp-48]
       call      qword ptr [7FF83A9FB188]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32)
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
       sub       rsp,28
       mov       rcx,[rbp+10]
       mov       edx,[rbp-48]
       call      qword ptr [7FF83A9FB188]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 1103
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       rax,[rcx+0B8]
       cmp       qword ptr [rax+20],0
       je        near ptr M19_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       near ptr M19_L07
       mov       rbx,[rcx+0B8]
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M19_L08
M19_L00:
       mov       [rbp-20],rsi
       xor       eax,eax
       mov       [rbp-14],eax
       test      rsi,rsi
       je        short M19_L02
       mov       rcx,rsi
       call      00007FF809262D60
       test      eax,eax
       jne       short M19_L01
       mov       rcx,rsi
       call      qword ptr [7FF7A97AFBD0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M19_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M19_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M19_L03
       mov       rcx,7FF7A9F54580
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF7A9AE6AF0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M19_L04
M19_L02:
       xor       ecx,ecx
       call      qword ptr [7FF7A9EB61C0]
       int       3
M19_L03:
       mov       rcx,7FF7A9F5457C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF7A9EBDED8]
       int       3
M19_L04:
       mov       rcx,7FF7A9F54584
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FF809262C80
       test      eax,eax
       jne       near ptr M19_L10
M19_L05:
       mov       rcx,7FF7A9F54588
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF7A9F5458C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M19_L06:
       call      qword ptr [7FF7A9EBE490]
       int       3
M19_L07:
       mov       rcx,7FF7A9F54578
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF7A9EBDED8]
       int       3
M19_L08:
       mov       rcx,rbx
       call      qword ptr [7FF7A99ECE28]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M19_L09
       call      qword ptr [7FF7A9EB66E8]
       int       3
M19_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF8091FCC60
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M19_L00
M19_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF7A986CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M19_L05
       sub       rsp,28
       call      qword ptr [7FF7A9EBE4A8]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M19_L12
       mov       rcx,7FF7A9F54584
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M19_L11
       xor       ecx,ecx
       call      qword ptr [7FF7A9EB61C0]
       int       3
M19_L11:
       mov       rcx,[rbp-20]
       call      00007FF809262C80
       test      eax,eax
       je        short M19_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF7A986CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M19_L12:
       mov       rcx,7FF7A9F54588
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rbx+60]
       test      rdi,rdi
       jne       short M20_L00
       mov       rcx,7FF7A9F86C48
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbx+20]
M20_L00:
       test      rdi,rdi
       je        short M20_L02
       mov       rcx,rdi
       mov       rdx,7FF7A9F86C50
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rdi
       mov       r8,rbx
       mov       rdx,rsi
       mov       r11,7FF7A9520E20
       call      qword ptr [r11]
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M20_L06
       mov       rcx,[rbp+0C0]
       mov       rdx,rsi
       call      qword ptr [7FF7A97ACC30]; System.Type.op_Equality(System.Type, System.Type)
       test      eax,eax
       je        short M20_L03
       cmp       [rbp+0B8],rbx
       jne       short M20_L04
M20_L01:
       mov       rcx,7FF7A9F86D68
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M20_L02:
       mov       rcx,7FF7A9F86C4C
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M20_L03:
       mov       rcx,7FF7A9F86D58
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp+0C0]
       mov       rcx,rsi
       call      qword ptr [7FF7A9EBFA20]
       int       3
M20_L04:
       mov       rcx,7FF7A9F86D5C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF7A9EBFA38]
       int       3
M20_L05:
       mov       rcx,7FF7A9F86D60
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M20_L01
M20_L06:
       mov       rcx,20E370A27E0
       cmp       rsi,rcx
       jne       short M20_L05
       mov       rcx,7FF7A9F86D64
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SlimObjectConverter
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF7A99EE220]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       byte ptr [rbp+12],1
       lea       rcx,[rbp+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8,rbx
       call      qword ptr [7FF7A9AE5AD0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Text.Json.Serialization.JsonConverter, System.Text.Json.JsonSerializerOptions)
       mov       rbp,rsi
       jmp       near ptr M20_L01
; Total bytes of code 366
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
       je        near ptr M21_L08
M21_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M21_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M21_L09
M21_L01:
       test      rdi,rdi
       jne       near ptr M21_L07
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
       call      00007FF8091FFE50
       mov       r14,rax
       test      r14,r14
       je        near ptr M21_L10
M21_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M21_L05
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
       mov       rax,7FF7A97C8C30
       mov       [rbp-78],rax
       lea       rax,[M21_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF8091A5A20
       call      rax
M21_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF809513A10],0
       je        short M21_L04
       call      qword ptr [7FF809501648]; CORINFO_HELP_STOP_FOR_GC
M21_L04:
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
M21_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF80921C1F0
       mov       rdx,rax
       test      rdx,rdx
       je        short M21_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M21_L11
M21_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M21_L07:
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
M21_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF7A9F97078]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M21_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF7A9EB7B88]
       jmp       near ptr M21_L00
M21_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M21_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF7A97A5728]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M21_L02
M21_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       [rbp+18],rdx
       mov       rbx,rcx
       mov       edi,r8d
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r14,rax
       mov       rcx,rsp
       mov       [rbp-68],rcx
       mov       rcx,rbp
       mov       [rbp-58],rcx
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M22_L03
       mov       [rbp-48],rcx
       mov       rcx,[rbp-48]
       test      rcx,rcx
       je        near ptr M22_L04
       mov       rcx,[rcx+18]
M22_L00:
       lea       rdx,[rbp-48]
       mov       [rbp-90],rdx
       mov       [rbp-88],rcx
       lea       rcx,[rbp-90]
       mov       edx,edi
       lea       r8,[rbp-40]
       mov       rax,7FF7A96162A8
       mov       [rbp-70],rax
       lea       rax,[M22_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FF80914C260
       call      rax
M22_L01:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FF809513A10],0
       je        short M22_L02
       call      qword ptr [7FF809501648]; CORINFO_HELP_STOP_FOR_GC
M22_L02:
       mov       rcx,[rbp-78]
       mov       [r14+8],rcx
       mov       rbx,[rbp-40]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rbx
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
M22_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9EB6D90]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF7A9EB6DA8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M22_L04:
       xor       ecx,ecx
       jmp       near ptr M22_L00
; Total bytes of code 312
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFFFEC1CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M23_L01
       cmp       [rax],ecx
       jle       short M23_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M23_L03
M23_L00:
       add       rsp,20
       pop       rbx
       ret
M23_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M23_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M23_L00
M23_L02:
       cmp       [rax+4],edx
       jle       short M23_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M23_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M23_L03
       jmp       short M23_L00
M23_L03:
       mov       ecx,ebx
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M24_L00
       ret
M24_L00:
       jmp       qword ptr [7FF7A95D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_Ref_Person()
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
       mov       rcx,[rbx+48]
       test      rcx,rcx
       je        near ptr M00_L37
       mov       [rbp-40],rcx
       mov       rcx,18597C01E08
       mov       r14,[rcx]
       cmp       byte ptr [r14+9F],0
       je        near ptr M00_L38
M00_L01:
       mov       rdx,[r14+18]
       test      rdx,rdx
       jne       near ptr M00_L09
       xor       esi,esi
       cmp       byte ptr [r14+9E],0
       je        near ptr M00_L06
       mov       rsi,[r14+8]
       test      rsi,rsi
       je        near ptr M00_L39
M00_L02:
       mov       rdi,[rsi+8]
       mov       rcx,18597C01968
       mov       r15,[rcx]
       test      r15,r15
       jne       short M00_L03
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF7A952D110
       mov       [r15+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [r15+20],rcx
       mov       rcx,18597C01968
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M00_L03:
       cmp       [rdi],dil
       mov       r13,[rdi+8]
       mov       rcx,[r13+8]
       cmp       byte ptr [rdi+19],0
       jne       near ptr M00_L07
       mov       r11,7FF7A9531078
       mov       rdx,1C62CD427E0
       call      qword ptr [r11]
       mov       r12d,eax
M00_L04:
       lea       r9,[rbp-48]
       mov       [rsp+20],r9
       mov       r9d,r12d
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       mov       r8,1C62CD427E0
       call      qword ptr [7FF7A99666A0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       jne       short M00_L05
       mov       r8,rsi
       mov       rdx,1C62CD427E0
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-48]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,r12d
       shl       r9,20
       or        r9,1
       mov       rdx,r13
       mov       rcx,rdi
       mov       r8,1C62CD427E0
       call      qword ptr [7FF7A996C558]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
M00_L05:
       mov       rcx,[rbp-48]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rax,[rcx+10]
       test      rax,rax
       jne       near ptr M00_L40
       mov       rsi,[rcx+8]
       test      rsi,rsi
       je        short M00_L06
       cmp       byte ptr [rsi+119],2
       jne       near ptr M00_L41
M00_L06:
       test      rsi,rsi
       jne       short M00_L08
       mov       rdx,[r14+20]
       mov       rcx,1C62CD427E0
       call      qword ptr [7FF7A9EE70F0]
       int       3
M00_L07:
       mov       rcx,1C62CD427E0
       mov       rax,[7FF7A952A1C0]
       call      qword ptr [rax+18]
       mov       r12d,eax
       jmp       near ptr M00_L04
M00_L08:
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
M00_L09:
       mov       r14,rdx
       test      r14,r14
       je        short M00_L10
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
       cmp       [r14],rcx
       jne       near ptr M00_L42
M00_L10:
       mov       rsi,[r14+0B8]
       lea       rdx,[rbp-58]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9C37918]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       r15d,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M00_L43
       mov       rcx,[rcx+240]
       mov       rsi,[rcx+48]
       test      rsi,rsi
       je        near ptr M00_L43
M00_L11:
       mov       rax,[rsi+10]
       test      rax,rax
       jne       short M00_L12
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,1C62CD46EF8
       mov       [rax+18],rcx
       xor       ecx,ecx
       mov       [rax+20],rcx
       mov       byte ptr [rax+28],1
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
M00_L12:
       mov       ecx,[rax+18]
       lea       edx,[rcx+1]
       mov       [rax+18],edx
       test      ecx,ecx
       je        near ptr M00_L18
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      r15d,r15d
       je        near ptr M00_L45
       mov       rcx,18597C01E10
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FF7A9C5C730]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
M00_L13:
       mov       [rbp-70],rax
       lea       rcx,[rsi+18]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       byte ptr [rsi+28],1
       mov       [rbp-148],rsi
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-4C]
       lea       rdi,[r13+70]
       lea       rsi,[rbp-58]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       ecx,9
       mov       eax,20
       test      byte ptr [r13+7C],8
       cmove     ecx,eax
       mov       [r13+3C],cl
       mov       ecx,edx
       and       ecx,7F0
       sar       ecx,4
       je        short M00_L17
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L14:
       mov       [r13+2C],eax
       test      dl,4
       jne       near ptr M00_L46
       mov       r15,1C62CD41718
M00_L15:
       mov       ecx,[r15+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       short M00_L16
       mov       dword ptr [r13+78],3E8
M00_L16:
       mov       [rbp-150],r13
       jmp       near ptr M00_L24
M00_L17:
       mov       eax,2
       jmp       short M00_L14
M00_L18:
       mov       rcx,[rax+8]
       mov       [rbp-148],rcx
       mov       r13,[rax+10]
       mov       rcx,[rbp-148]
       cmp       [rcx],cl
       mov       rcx,[rbp-148]
       add       rcx,18
       mov       rdx,[rcx]
       mov       edx,[rdx+8]
       sub       edx,[rcx+0C]
       cmp       edx,r15d
       jl        near ptr M00_L22
M00_L19:
       lea       rcx,[r13+8]
       mov       rdx,[rbp-148]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rbp-4C]
       lea       rdi,[r13+70]
       lea       rsi,[rbp-58]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       ecx,9
       mov       eax,20
       test      byte ptr [r13+7C],8
       cmove     ecx,eax
       mov       [r13+3C],cl
       mov       ecx,edx
       and       ecx,7F0
       sar       ecx,4
       je        short M00_L23
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L20:
       mov       [r13+2C],eax
       test      dl,4
       jne       near ptr M00_L44
       mov       rsi,1C62CD41718
M00_L21:
       mov       ecx,[rsi+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       near ptr M00_L16
       mov       dword ptr [r13+78],3E8
       jmp       near ptr M00_L16
M00_L22:
       mov       edx,r15d
       call      qword ptr [7FF7A9C379A8]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L19
M00_L23:
       mov       eax,2
       jmp       short M00_L20
M00_L24:
       cmp       byte ptr [r14+116],0
       jne       near ptr M00_L32
       mov       rcx,[r14+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M00_L30
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L30
       mov       rsi,[r14+0B8]
       mov       rcx,[rbp-40]
       cmp       [rsi],sil
       call      qword ptr [7FF7A97B61D8]; System.Object.GetType()
       mov       r9,1C62CD427E0
       cmp       rax,r9
       je        near ptr M00_L30
       mov       r14,[rsi+10]
       test      r14,r14
       je        near ptr M00_L33
       mov       r9,[r14+0C0]
       cmp       r9,rax
       jne       near ptr M00_L33
M00_L25:
       cmp       byte ptr [r14+11A],0
       je        near ptr M00_L29
M00_L26:
       mov       r8,[r14+0F8]
       test      r8,r8
       cmovne    r14,r8
       mov       r8,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],r8
       jne       near ptr M00_L35
       mov       r9,[rbp-40]
       mov       r8,r9
       test      r8,r8
       je        short M00_L27
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       cmp       [r8],rcx
       jne       near ptr M00_L34
M00_L27:
       mov       [rbp-118],r8
       lea       r8,[rbp-118]
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FF7A9C37A80]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       xor       edx,edx
       mov       [rbp-118],rdx
M00_L28:
       mov       r9,[rbp-148]
       cmp       [r9],r9b
       mov       rdx,[rbp-148]
       add       rdx,18
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-128],xmm0
       mov       r9d,[rdx+0C]
       mov       r8d,[rdx+8]
       sub       r9d,r8d
       mov       rdx,[rdx]
       lea       rcx,[rbp-128]
       call      qword ptr [7FF7A9C3FAC8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rcx,[rbp-128]
       mov       eax,[rbp-120]
       mov       [rbp-140],rcx
       mov       [rbp-138],eax
       lea       rcx,[rbp-140]
       call      qword ptr [7FF7A9B66070]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rsi,rax
       jmp       near ptr M00_L36
M00_L29:
       mov       rcx,r14
       call      qword ptr [7FF7A9C3E070]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[r14+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+11A],1
       jmp       near ptr M00_L26
M00_L30:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-110],ymm0
       vmovdqu   ymmword ptr [rbp-0F0],ymm0
       vmovdqu   ymmword ptr [rbp-0D0],ymm0
       vmovdqu   ymmword ptr [rbp-0B0],ymm0
       vmovdqu   ymmword ptr [rbp-90],ymm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-110]
       mov       rdx,r14
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF7A9C3EFD0]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-110]
       mov       [rsp+20],rcx
       mov       rcx,[r14+158]
       mov       r9,[r14+0B8]
       lea       r8,[rbp-40]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9C3EFE8]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L31:
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9C3FAB0]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M00_L28
M00_L32:
       mov       rax,[r14+148]
       mov       rdx,r13
       mov       r8,[rbp-40]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M00_L31
M00_L33:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9d,101
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8d,1
       call      qword ptr [7FF7A99FCDE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r14,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L25
M00_L34:
       mov       rdx,r9
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L35:
       mov       rcx,r14
       mov       rdx,r13
       mov       r8,[rbp-40]
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L28
M00_L36:
       mov       rcx,r13
       mov       rdx,[rbp-148]
       call      qword ptr [7FF7A9C3FAE0]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       [rbp-130],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-130]
       mov       rdx,7FF7A9E0F038
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9DD7180]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L37:
       call      qword ptr [7FF7A9B6E880]
       mov       ecx,1C4D
       mov       rdx,7FF7A98B5420
       call      qword ptr [7FF7A95EF228]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FF7A98B5420
       call      qword ptr [7FF7A95EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A95ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FF7A98B5420
       call      qword ptr [7FF7A95EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A95ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7A9EEF870]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7A9EE4540]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       rcx,r14
       call      qword ptr [7FF7A99F75D0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L39:
       mov       rcx,r14
       call      qword ptr [7FF7A99FCDF8]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rax
       call      qword ptr [7FF7A9EE7648]
       int       3
M00_L41:
       mov       rcx,rsi
       call      qword ptr [7FF7A9AF6AD8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L06
M00_L42:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L43:
       mov       ecx,9
       call      qword ptr [7FF7A9EE4180]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rsi,rax
       jmp       near ptr M00_L11
M00_L44:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,18597C027E0
       mov       rsi,[rcx]
       jmp       near ptr M00_L21
M00_L45:
       mov       rax,1C62CD46EF8
       jmp       near ptr M00_L13
M00_L46:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,18597C027E0
       mov       r15,[rcx]
       jmp       near ptr M00_L15
       sub       rsp,48
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-148]
       call      qword ptr [7FF7A9C3FAE0]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       nop
       add       rsp,48
       ret
; Total bytes of code 2261
```
```assembly
; System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7A99FD398]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M01_L00:
       mov       rcx,7FF7A9F88BFC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-20]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,7FF7A9F88BF8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A9EE7C30]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF7A9EED1A0]
       mov       [rbp-20],rsi
       lea       rax,[M01_L00]
       add       rsp,28
       ret
; Total bytes of code 185
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       ebx,r9d
       mov       rbp,[rdx+8]
       mov       rcx,[rdx+10]
       mov       eax,ebx
       imul      rax,[rdx+28]
       shr       rax,20
       inc       rax
       mov       edx,[rcx+8]
       mov       r8d,edx
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M02_L05
       mov       edx,eax
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       jne       short M02_L03
M02_L00:
       mov       rcx,7FF7A9F3EC3C
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       mov       rbx,[rsp+80]
       mov       [rbx],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       rdx,7FF7A9F3EB28
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rbp
       mov       rdx,[r14+8]
       mov       r11,r15
       mov       r8,rdi
       call      qword ptr [r15]
       test      eax,eax
       jne       short M02_L04
       mov       rcx,7FF7A9F3EC34
       call      CORINFO_HELP_COUNTPROFILE32
M02_L02:
       mov       rcx,7FF7A9F3EC38
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r14,[r14+18]
       test      r14,r14
       je        short M02_L00
M02_L03:
       cmp       ebx,[r14+20]
       jne       short M02_L02
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       jne       short M02_L01
       mov       rcx,rsi
       mov       rdx,7FF7A9F478D8
       call      qword ptr [7FF7A95EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,7FF7A9F3EC30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[r14+10]
       mov       rcx,[rsp+80]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 305
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
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
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+28],r9
       mov       rbx,r8
       mov       esi,[rbp+40]
       movzx     r9d,r9b
       mov       rdx,[rbp+18]
       mov       rdi,[rdx+8]
       mov       r14d,[rbp+2C]
       test      r9d,r9d
       jne       short M03_L05
       cmp       byte ptr [rcx+19],0
       jne       short M03_L04
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+78]
       test      r11,r11
       je        short M03_L03
M03_L00:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
M03_L01:
       mov       r15d,eax
M03_L02:
       jmp       near ptr M03_L34
M03_L03:
       mov       rcx,rdx
       mov       rdx,7FF7A9F477E8
       call      qword ptr [7FF7A95EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M03_L00
M03_L04:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       short M03_L01
M03_L05:
       mov       rcx,7FF7A9F8ED08
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r15d,r14d
       jmp       short M03_L02
M03_L06:
       test      sil,sil
       je        short M03_L08
       mov       rcx,7FF7A9F8ED0C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-44],ecx
       jae       near ptr M03_L30
       mov       rcx,[rbp-60]
       mov       eax,[rbp-44]
       mov       r12,[rcx+rax*8+10]
       test      r12,r12
       je        near ptr M03_L29
       mov       rcx,r12
       call      00007FF809262D60
       test      eax,eax
       jne       short M03_L07
       mov       rcx,r12
       call      qword ptr [7FF7A9876DF0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M03_L07:
       mov       dword ptr [rbp-50],1
M03_L08:
       mov       rcx,[rbp+18]
       cmp       rcx,[r14+8]
       je        short M03_L11
       mov       rcx,[r14+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+18]
       cmp       rdi,[rcx+8]
       je        short M03_L10
       mov       rcx,7FF7A9F8ED10
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdi,[rcx+8]
       cmp       byte ptr [r14+19],0
       jne       near ptr M03_L28
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M03_L27
M03_L09:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       r15d,eax
M03_L10:
       mov       rcx,7FF7A9F8ED14
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L32
M03_L11:
       xor       esi,esi
       mov       r12,[r13]
       test      r12,r12
       jne       near ptr M03_L20
M03_L12:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        near ptr M03_L24
M03_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rax,[r13]
       mov       [rbp-68],rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,[rbp-68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+20],r15d
       mov       rcx,r13
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       mov       eax,[rcx+8]
       cmp       [rbp-44],eax
       jae       near ptr M03_L30
       mov       eax,[rbp-44]
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M03_L31
       mov       [rcx],eax
       cmp       eax,[r14+10]
       jle       short M03_L14
       mov       rcx,7FF7A9F8ED30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       dword ptr [rbp-48],1
M03_L14:
       cmp       esi,64
       jbe       near ptr M03_L26
       mov       rcx,rdi
       mov       rdx,7FF7A9F8ED38
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FF7A95E6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M03_L25
       mov       rcx,7FF7A9F8EE40
       call      CORINFO_HELP_COUNTPROFILE32
       mov       dword ptr [rbp-4C],1
       jmp       near ptr M03_L36
M03_L15:
       mov       rcx,7FF7A9F8ED1C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[r12+10]
       mov       rcx,[rbp+48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L23
M03_L16:
       mov       rcx,rax
M03_L17:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M03_L21
M03_L18:
       mov       rdx,[r12+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M03_L22
       mov       rcx,7FF7A9F8ED18
       call      CORINFO_HELP_COUNTPROFILE32
M03_L19:
       mov       rcx,7FF7A9F8ED28
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       mov       rcx,7FF7A9F8ED2C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r12,[r12+18]
       test      r12,r12
       je        near ptr M03_L12
M03_L20:
       cmp       r15d,[r12+20]
       jne       short M03_L19
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       jne       near ptr M03_L16
       mov       rdx,7FF7A9F48088
       call      qword ptr [7FF7A95EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L17
M03_L21:
       mov       rdx,7FF7A9F478D8
       call      qword ptr [7FF7A95EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M03_L18
M03_L22:
       cmp       byte ptr [rbp+38],0
       je        near ptr M03_L15
       lea       rcx,[r12+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L23:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       jmp       near ptr M03_L35
M03_L24:
       mov       rdx,7FF7A9F79958
       call      qword ptr [7FF7A95EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M03_L13
M03_L25:
       mov       rcx,7FF7A9F8ED24
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L36
M03_L26:
       mov       rcx,7FF7A9F8ED20
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L36
M03_L27:
       mov       rdx,7FF7A9F477E8
       call      qword ptr [7FF7A95EF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M03_L09
M03_L28:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M03_L10
M03_L29:
       xor       ecx,ecx
       call      qword ptr [7FF7A9DDF960]
       int       3
M03_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L31:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L32:
       cmp       dword ptr [rbp-50],0
       je        short M03_L33
       mov       rcx,7FF7A9F8EE44
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-44],ecx
       jae       near ptr M03_L40
       mov       rcx,[rbp-60]
       mov       eax,[rbp-44]
       mov       r12,[rcx+rax*8+10]
       test      r12,r12
       je        near ptr M03_L39
       mov       rcx,r12
       call      00007FF809262C80
       test      eax,eax
       jne       near ptr M03_L38
M03_L33:
       mov       rcx,7FF7A9F8EE48
       call      CORINFO_HELP_COUNTPROFILE32
       nop
M03_L34:
       mov       rax,[rbp+18]
       mov       rcx,[rax+18]
       mov       [rbp-60],rcx
       mov       r14,[rbp+10]
       cmp       [r14],r14d
       mov       rax,[rbp+18]
       mov       r8,[rax+10]
       mov       rax,[rbp+18]
       mov       r10d,r15d
       imul      r10,[rax+28]
       shr       r10,20
       inc       r10
       mov       r9d,[r8+8]
       mov       r11d,r9d
       imul      r10,r11
       shr       r10,20
       mov       eax,r10d
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rbp-44],edx
       cmp       r10d,r9d
       jae       near ptr M03_L40
       mov       ecx,r10d
       lea       r13,[r8+rcx*8+10]
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       [rbp-4C],ecx
       mov       [rbp-50],ecx
       jmp       near ptr M03_L06
M03_L35:
       call      M03_L41
       nop
       mov       rcx,7FF7A9F8EE54
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,[rbp-54]
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
M03_L36:
       call      M03_L41
       nop
       mov       ecx,[rbp-48]
       or        ecx,[rbp-4C]
       je        short M03_L37
       mov       rcx,7FF7A9F8EE4C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8d,[rbp-48]
       mov       r9d,[rbp-4C]
       call      qword ptr [7FF7A9CF42D0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
M03_L37:
       mov       rcx,7FF7A9F8EE50
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
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
M03_L38:
       mov       ecx,eax
       mov       rdx,r12
       call      qword ptr [7FF7A987CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M03_L33
M03_L39:
       xor       ecx,ecx
       call      qword ptr [7FF7A9DDF960]
       int       3
M03_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L41:
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M03_L44
       mov       rcx,7FF7A9F8EE44
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-44],ecx
       jae       short M03_L42
       mov       rcx,[rbp-60]
       mov       eax,[rbp-44]
       mov       r12,[rcx+rax*8+10]
       test      r12,r12
       jne       short M03_L43
       xor       ecx,ecx
       call      qword ptr [7FF7A9DDF960]
       int       3
M03_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L43:
       mov       rcx,r12
       call      00007FF809262C80
       test      eax,eax
       je        short M03_L44
       mov       ecx,eax
       mov       rdx,r12
       call      qword ptr [7FF7A987CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M03_L44:
       mov       rcx,7FF7A9F8EE48
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 1520
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rax,rdx
       mov       rbx,[rcx+40]
       cmp       byte ptr [rcx+9C],0
       setne     sil
       movzx     esi,sil
       movzx     edx,word ptr [rcx+90]
       cmp       edx,20
       jne       near ptr M04_L10
       and       esi,0FFFFFFF7
M04_L00:
       mov       edx,[rcx+84]
       cmp       edx,7F
       ja        near ptr M04_L12
       and       esi,0FFFFF80F
       test      edx,edx
       je        near ptr M04_L07
       xor       r8d,r8d
       cmp       edx,2
       cmovne    r8d,edx
M04_L01:
       shl       r8d,4
       or        esi,r8d
       mov       edi,[rcx+88]
       test      edi,edi
       jl        near ptr M04_L13
       mov       r8,[rcx+50]
       test      r8,r8
       je        near ptr M04_L14
M04_L02:
       mov       rcx,1C62CD4FFA8
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],1
       jne       short M04_L03
       cmp       word ptr [r8+0C],0A
       je        short M04_L04
M04_L03:
       mov       rcx,1C62CD41718
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],2
       jne       short M04_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M04_L08
M04_L04:
       mov       rcx,1C62CD41718
       cmp       r8,rcx
       je        short M04_L05
       cmp       dword ptr [r8+8],2
       jne       short M04_L09
       cmp       dword ptr [r8+0C],0A000D
       jne       short M04_L09
M04_L05:
       and       esi,0FFFFFFFB
M04_L06:
       or        esi,2
       mov       [rax],rbx
       mov       [rax+8],edi
       mov       [rax+0C],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L07:
       mov       r8d,2
       jmp       near ptr M04_L01
M04_L08:
       mov       ecx,38A0
       mov       rdx,7FF7A9A344B8
       call      qword ptr [7FF7A95EF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9EEE7D8]
       int       3
M04_L09:
       or        esi,4
       jmp       short M04_L06
M04_L10:
       cmp       edx,9
       je        short M04_L11
       mov       ecx,38A0
       mov       rdx,7FF7A9A344B8
       call      qword ptr [7FF7A95EF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9EEE790]
       int       3
M04_L11:
       or        esi,8
       jmp       near ptr M04_L00
M04_L12:
       mov       ecx,38A0
       mov       rdx,7FF7A9A344B8
       call      qword ptr [7FF7A95EF228]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FF7A9EEE7A8]
       int       3
M04_L13:
       mov       ecx,38A0
       mov       rdx,7FF7A9A344B8
       call      qword ptr [7FF7A95EF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9EEE7C0]
       int       3
M04_L14:
       mov       r8,1C62CD41718
       mov       [rcx+50],r8
       jmp       near ptr M04_L02
; Total bytes of code 418
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       ebx,edx
       mov       rcx,18597C00AC0
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       short M05_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M05_L02
M05_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M05_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M05_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M05_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M05_L03
M05_L01:
       mov       rax,r14
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
M05_L02:
       mov       ecx,0A
       call      qword ptr [7FF7A9EE4180]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L03:
       mov       rcx,r14
       call      qword ptr [7FF7A99FCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF7A99FCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF7A9EEC7C8]
       jmp       short M05_L01
M05_L04:
       mov       rax,[rsi+10]
       cmp       [rax+8],ebp
       jbe       near ptr M05_L13
       mov       ecx,ebp
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        near ptr M05_L12
       mov       r14,[rax+8]
       call      qword ptr [7FF7A9CFF300]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       ebx,eax
       sub       ebx,ecx
       xor       r15d,r15d
       jmp       short M05_L08
M05_L05:
       cmp       ebx,[r14+8]
       jae       near ptr M05_L18
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FF7A9AFDB78]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M05_L06
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M05_L06:
       mov       rcx,r13
       call      qword ptr [7FF7A95E6820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M05_L09
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M05_L07
       xor       ebx,ebx
M05_L07:
       inc       r15d
M05_L08:
       cmp       [r14+8],r15d
       jg        short M05_L05
       jmp       short M05_L10
M05_L09:
       mov       r14,r12
       jmp       short M05_L11
M05_L10:
       xor       r14d,r14d
M05_L11:
       test      r14,r14
       je        short M05_L12
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       mov       rcx,r14
       call      qword ptr [7FF7A99FCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF7A99FCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF7A9EEC7C8]
       jmp       near ptr M05_L01
M05_L12:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M05_L15
M05_L13:
       test      ebx,ebx
       jne       short M05_L14
       mov       rax,1C62CD46EF8
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
M05_L14:
       mov       ecx,ebx
       mov       rdx,1C62CD44430
       call      qword ptr [7FF7A987D920]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M05_L15:
       cmp       ebx,800
       jge       short M05_L16
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M05_L17
M05_L16:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FF7A9C37A50]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M05_L17:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FF7A99FCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF7A99FCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF7A9EEC7C8]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF7A99FCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rsi+10]
       mov       edx,1
       mov       r8d,2
       cmp       [rcx+8],ebp
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rdi
       mov       edx,ebx
       mov       r8d,r15d
       call      qword ptr [7FF7A9EEC7E0]
       jmp       near ptr M05_L01
M05_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 712
```
```assembly
; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,[rbx]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M06_L20
       mov       rcx,18597C01E10
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       ebp,edx
       mov       rcx,18597C00AC0
       mov       r14,[rcx]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       short M06_L04
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M06_L04
M06_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M06_L06
       mov       eax,[rcx+8]
       cmp       eax,r15d
       jbe       near ptr M06_L06
       mov       eax,r15d
       shl       rax,4
       mov       r13,[rcx+rax+10]
       test      r13,r13
       je        short M06_L06
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [r14+9D],0
       jne       short M06_L05
M06_L01:
       mov       rdx,r13
M06_L02:
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M06_L03:
       nop
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
M06_L04:
       mov       ecx,0A
       call      qword ptr [7FF7A9EE4180]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M06_L00
M06_L05:
       mov       rcx,r13
       call      qword ptr [7FF7A99FCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       ebp,[r13+8]
       mov       rcx,rsi
       call      qword ptr [7FF7A99FCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF7A9EEC7C8]
       jmp       short M06_L01
M06_L06:
       mov       rax,[rdi+10]
       cmp       [rax+8],r15d
       jbe       near ptr M06_L15
       mov       ecx,r15d
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        near ptr M06_L14
       mov       r13,[rax+8]
       call      qword ptr [7FF7A9CFF300]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       ebp,eax
       sub       ebp,ecx
       xor       esi,esi
       jmp       short M06_L10
M06_L07:
       cmp       ebp,[r13+8]
       jae       near ptr M06_L26
       mov       ecx,ebp
       mov       r12,[r13+rcx*8+10]
       cmp       [r12],r12b
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rcx,r12
       call      qword ptr [7FF7A9AFDB78]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r12+8]
       mov       eax,[r12+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M06_L08
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       mov       [rsp+30],rdx
       mov       r8d,eax
       xor       r10d,r10d
       mov       [rcx+r8*8+10],r10
       mov       [r12+10],eax
M06_L08:
       mov       rcx,r12
       call      qword ptr [7FF7A95E6820]; System.Threading.Monitor.Exit(System.Object)
       mov       r12,[rsp+30]
       test      r12,r12
       jne       short M06_L11
       inc       ebp
       cmp       [r13+8],ebp
       jne       short M06_L09
       xor       ebp,ebp
M06_L09:
       inc       esi
M06_L10:
       cmp       [r13+8],esi
       jg        short M06_L07
       jmp       short M06_L12
M06_L11:
       mov       r13,r12
       jmp       short M06_L13
M06_L12:
       xor       r13d,r13d
M06_L13:
       test      r13,r13
       je        short M06_L14
       cmp       byte ptr [r14+9D],0
       je        near ptr M06_L01
       mov       rcx,r13
       call      qword ptr [7FF7A99FCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF7A99FCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF7A9EEC7C8]
       jmp       near ptr M06_L01
M06_L14:
       mov       ecx,10
       shlx      ebp,ecx,r15d
       jmp       short M06_L17
M06_L15:
       test      ebp,ebp
       jne       short M06_L16
       mov       rdx,1C62CD46EF8
       jmp       near ptr M06_L02
M06_L16:
       mov       ecx,ebp
       mov       rdx,1C62CD44430
       call      qword ptr [7FF7A987D920]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M06_L17:
       cmp       ebp,800
       jge       short M06_L18
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M06_L19
M06_L18:
       mov       ecx,ebp
       xor       edx,edx
       call      qword ptr [7FF7A9C37A50]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M06_L19:
       cmp       byte ptr [r14+9D],0
       je        near ptr M06_L01
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF7A99FCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF7A99FCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF7A9EEC7C8]
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF7A99FCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rdi+10]
       mov       edx,1
       mov       r8d,2
       cmp       [rcx+8],r15d
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r14
       mov       edx,esi
       mov       r8d,ebp
       call      qword ptr [7FF7A9EEC7E0]
       jmp       near ptr M06_L01
M06_L20:
       mov       ecx,[rbx+8]
       mov       rax,[rbx]
       mov       eax,[rax+8]
       sub       eax,[rbx+0C]
       add       ecx,eax
       cmp       edx,ecx
       jg        short M06_L21
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       r8,[rbx]
       mov       rcx,[rbx]
       xor       r9d,r9d
       call      qword ptr [7FF7A9876760]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       eax,[rbx+8]
       sub       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+8],eax
       jmp       near ptr M06_L03
M06_L21:
       mov       ecx,[rbx+0C]
       sub       ecx,[rbx+8]
       add       ecx,edx
       cmp       ecx,7FFFFFC7
       jbe       short M06_L22
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A9EEC6C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L22:
       mov       rdx,[rbx]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,7FFFFFC7
       cmp       rdx,7FFFFFC7
       cmovl     rax,rdx
       cmp       ecx,eax
       mov       edx,eax
       cmovge    edx,ecx
       cmp       byte ptr [rbx+10],0
       jne       short M06_L23
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M06_L24
M06_L23:
       mov       rcx,18597C01E10
       mov       rcx,[rcx]
       call      qword ptr [7FF7A9C5C730]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rsi,rax
M06_L24:
       mov       rdi,[rbx]
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       je        short M06_L25
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       rcx,rdi
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF7A9876760]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
M06_L25:
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+10],0
       je        near ptr M06_L03
       cmp       dword ptr [rdi+8],0
       je        near ptr M06_L03
       mov       rcx,18597C01E10
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF7A9C5C738]; Precode of System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M06_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1092
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
       je        short M07_L01
M07_L00:
       add       rsp,20
       pop       rbx
       ret
M07_L01:
       call      qword ptr [7FF7A95E5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M07_L00
; Total bytes of code 41
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
M08_L00:
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E0
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqu   ymmword ptr [rsp+0C0],ymm4
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       rbp,r9
       cmp       byte ptr [rbx+116],0
       jne       near ptr M08_L09
       mov       rcx,[rbx+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M08_L06
       mov       r8,[rsi]
       test      r8,r8
       je        near ptr M08_L06
       mov       r14,[rbx+0B8]
       mov       rcx,r8
       cmp       [r14],r14b
       call      qword ptr [7FF7A97B61D8]; System.Object.GetType()
       mov       r9,1C62CD427E0
       cmp       rax,r9
       je        near ptr M08_L06
       mov       rbx,[r14+10]
       test      rbx,rbx
       je        near ptr M08_L10
       mov       r9,[rbx+0C0]
       cmp       r9,rax
       jne       near ptr M08_L10
M08_L01:
       cmp       byte ptr [rbx+11A],0
       je        short M08_L05
M08_L02:
       mov       r8,[rbx+0F8]
       test      r8,r8
       cmovne    rbx,r8
       mov       r9,[rsi]
       mov       r8,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r8
       jne       near ptr M08_L12
       mov       r8,r9
       test      r8,r8
       je        short M08_L03
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       cmp       [r8],rcx
       jne       near ptr M08_L11
M08_L03:
       mov       [rsp+38],r8
       lea       r8,[rsp+38]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF7A9C37A80]
M08_L04:
       nop
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L05:
       mov       rcx,rbx
       call      qword ptr [7FF7A9C3E070]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[rbx+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+11A],1
       jmp       near ptr M08_L02
M08_L06:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+40],ymm0
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   ymmword ptr [rsp+0C0],ymm0
       mov       [rsp+0A8],rbx
       mov       rcx,[rbx+0D0]
       mov       [rsp+0A0],rcx
       mov       rcx,[rsp+0A0]
       mov       rcx,[rcx+0C8]
       mov       [rsp+0D0],rcx
       mov       byte ptr [rsp+8E],0
       mov       byte ptr [rsp+8F],0
       mov       r14,[rbx+0B8]
       cmp       dword ptr [r14+8C],0
       je        short M08_L07
       mov       rcx,[r14+38]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rsp+60],rax
       cmp       dword ptr [r14+8C],2
       jne       short M08_L07
       test      rbp,rbp
       je        short M08_L07
       mov       rcx,[rbx+0C0]
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       jne       near ptr M08_L13
M08_L07:
       lea       rcx,[rsp+40]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+158]
       mov       r9,[rbx+0B8]
       mov       rdx,rdi
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9C3EFE8]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M08_L08:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9C3FAB0]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M08_L04
M08_L09:
       mov       rax,[rbx+148]
       mov       r8,[rsi]
       mov       rdx,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M08_L08
M08_L10:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9d,101
       mov       rcx,r14
       mov       rdx,rax
       mov       r8d,1
       call      qword ptr [7FF7A99FCDE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbx,rax
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L01
M08_L11:
       mov       rdx,r9
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M08_L12:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,r9
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M08_L04
M08_L13:
       mov       rcx,[rsp+60]
       mov       rdx,rbp
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       near ptr M08_L07
; Total bytes of code 706
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       sub       rsp,28
       test      rdx,rdx
       je        short M09_L01
       mov       r8d,r8d
       mov       eax,r9d
       add       rax,r8
       mov       r10d,[rdx+8]
       cmp       rax,r10
       ja        short M09_L02
       add       rdx,10
       add       rdx,r8
       mov       [rcx],rdx
       mov       [rcx+8],r9d
M09_L00:
       add       rsp,28
       ret
M09_L01:
       or        r8d,r9d
       jne       short M09_L02
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       jmp       short M09_L00
M09_L02:
       call      qword ptr [7FF7A97BF228]
       int       3
; Total bytes of code 69
```
```assembly
; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-40],rax
       mov       r8,18597C013D8
       mov       rbx,[r8]
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       r8d,1
       test      edi,edi
       cmove     rsi,r8
       mov       [rbp-38],rsi
       test      rsi,rsi
       je        near ptr M10_L04
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FF7A97BCD98]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       mov       r9d,eax
       sub       r9d,esi
       mov       r14d,r9d
       add       r14d,[rbp-48]
       cmp       r9d,edi
       jne       near ptr M10_L05
M10_L00:
       test      r14d,r14d
       je        near ptr M10_L02
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FF809259F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       [rbp-40],rcx
       mov       r13,[rbp-40]
       test      r13,r13
       je        near ptr M10_L06
       mov       ecx,edi
       or        ecx,r14d
       jl        near ptr M10_L07
       lea       rcx,[rbp-58]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-60]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       mov       edx,edi
       mov       r8,r13
       mov       r9d,r14d
       call      qword ptr [7FF7A97BCDC8]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
       mov       ecx,[rbp-58]
       sub       ecx,esi
       mov       rdx,[rbp-60]
       sub       rdx,r13
       mov       r8,rdx
       shr       r8,3F
       add       rdx,r8
       sar       rdx,1
       cmp       ecx,edi
       jne       short M10_L08
M10_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       jmp       short M10_L03
M10_L02:
       mov       r15,1C62CD40008
M10_L03:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       near ptr M10_L09
M10_L04:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FF7A9B6DFE0]
       int       3
M10_L05:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FF7A9B6DFB0]
       add       r14d,eax
       jns       near ptr M10_L00
       call      qword ptr [7FF7A9B6DFF8]
       int       3
M10_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FF7A9B6DFE0]
       int       3
M10_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FF7A9B65E90]
       int       3
M10_L08:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,r13
       call      qword ptr [7FF7A9B6E250]
       jmp       near ptr M10_L01
M10_L09:
       mov       rax,r15
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,48
       call      qword ptr [7FF7A9DDE3A0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 442
```
```assembly
; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       cmp       qword ptr [rbx+80],0
       jne       near ptr M11_L08
       xor       esi,esi
       mov       rcx,[rbx+0C0]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdi,rax
       test      rdi,rdi
       je        short M11_L02
M11_L00:
       mov       rdx,[rbx+0B8]
       mov       rcx,rdi
       call      qword ptr [7FF81274F030]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        short M11_L01
       mov       rcx,[rax+80]
       test      rcx,rcx
       jne       short M11_L04
M11_L01:
       mov       rcx,rdi
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       call      qword ptr [r11]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M11_L00
M11_L02:
       mov       rcx,[rbx+0C0]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdi,rax
       xor       ebp,ebp
       cmp       [rdi+8],ebp
       jg        short M11_L05
M11_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M11_L04:
       mov       rsi,rax
       jmp       short M11_L02
M11_L05:
       mov       r14,[rdi+rbp*8+10]
       mov       rdx,[rbx+0B8]
       mov       rcx,r14
       call      qword ptr [7FF81274F030]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
       mov       r15,rax
       test      r15,r15
       je        short M11_L07
       mov       rcx,[r15+80]
       test      rcx,rcx
       je        short M11_L07
       test      rsi,rsi
       je        short M11_L06
       mov       rcx,[rsi+0C0]
       mov       rdx,r14
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M11_L06
       mov       rdx,[rsi+0C0]
       mov       rcx,r14
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M11_L07
       jmp       short M11_L08
M11_L06:
       mov       rsi,r15
M11_L07:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        short M11_L05
       jmp       near ptr M11_L03
M11_L08:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 292
```
```assembly
; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rbp,r8
       mov       edi,r9d
       lea       rcx,[rbx+68]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rsi+0D0]
       lea       rcx,[rbx+60]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+60]
       mov       rcx,[rcx+0C8]
       mov       [rbx+90],rcx
       mov       [rbx+4E],dil
       movzx     edi,byte ptr [rsp+70]
       mov       [rbx+4F],dil
       mov       rdi,[rsi+0B8]
       cmp       dword ptr [rdi+8C],0
       jne       short M12_L01
M12_L00:
       mov       rcx,7FF7A9FB3CA8
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M12_L01:
       mov       r14,[rdi+38]
       mov       rcx,r14
       mov       rdx,7FF7A9FB3BA0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r14
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       dword ptr [rdi+8C],2
       jne       near ptr M12_L04
       test      rbp,rbp
       je        short M12_L03
       mov       rcx,[rsi+0C0]
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        short M12_L02
       mov       rcx,7FF7A9FB3CAC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF7A9FB3CA8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rbx,[rbx+20]
       mov       rcx,rbx
       mov       rdx,7FF7A9FB3CB0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rbx
       mov       rdx,rbp
       mov       rax,[rcx]
       mov       rax,[rax+48]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M12_L02:
       mov       rcx,7FF7A9FB3DB8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L00
M12_L03:
       mov       rcx,7FF7A9FB3DBC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L00
M12_L04:
       mov       rcx,7FF7A9FB3DC0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L00
; Total bytes of code 354
```
```assembly
; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-48],xmm4
       xor       eax,eax
       mov       [rbp-38],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14,r9
       mov       r15d,[rbx+28]
       and       r15d,7FFFFFFF
       cmp       r15d,[r14+88]
       jge       near ptr M13_L20
       cmp       byte ptr [rsi+17],0
       jne       short M13_L00
       cmp       qword ptr [rdi],0
       je        near ptr M13_L21
M13_L00:
       cmp       byte ptr [rsi+10],2
       jne       near ptr M13_L10
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+90],0
       jne       near ptr M13_L22
M13_L01:
       mov       r8,[rdi]
       mov       rdx,offset MT_System.Text.Json.Serialization.Converters.StringConverter
       cmp       [rsi],rdx
       jne       near ptr M13_L26
       test      r8,r8
       je        near ptr M13_L07
       lea       r14,[r8+0C]
       mov       edi,[r8+8]
       cmp       edi,9EF21AA
       jg        near ptr M13_L23
       lea       rdx,[rbx+70]
       mov       rdx,[rdx]
       test      edi,edi
       je        short M13_L02
       mov       [rbp-38],r14
       mov       r8,r14
       mov       rax,18597C01400
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       [rbp-50],rdx
       mov       rcx,rdx
       mov       rdx,r8
       mov       r8d,edi
       mov       rax,[rbp-50]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rcx,[rbp+30]
       jmp       short M13_L03
M13_L02:
       mov       eax,0FFFFFFFF
M13_L03:
       xor       edx,edx
       mov       [rbp-38],rdx
       cmp       eax,0FFFFFFFF
       jne       short M13_L05
       test      byte ptr [rbx+7C],2
       je        near ptr M13_L24
M13_L04:
       mov       rcx,[rbp+30]
       test      byte ptr [rbx+7C],1
       jne       near ptr M13_L25
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FF7A9C3F3F0]; System.Text.Json.Utf8JsonWriter.WriteStringMinimized(System.ReadOnlySpan`1<Char>)
       jmp       short M13_L06
M13_L05:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FF7A9C3F438]; System.Text.Json.Utf8JsonWriter.WriteStringEscapeValue(System.ReadOnlySpan`1<Char>, Int32)
M13_L06:
       or        dword ptr [rbx+28],80000000
       mov       byte ptr [rbx+3A],7
       jmp       short M13_L08
M13_L07:
       mov       rcx,rbx
       call      qword ptr [7FF7A9C3F780]
M13_L08:
       mov       ecx,[rbx+28]
       and       ecx,7FFFFFFF
       cmp       r15d,ecx
       jne       near ptr M13_L27
M13_L09:
       mov       eax,1
       jmp       near ptr M13_L34
M13_L10:
       mov       rcx,[rbp+30]
       cmp       dword ptr [rcx+44],0
       setne     r15b
       movzx     r15d,r15b
       cmp       qword ptr [rdi],0
       je        short M13_L16
       cmp       byte ptr [rcx+8E],1
       je        short M13_L16
       cmp       dword ptr [rcx+40],0
       jne       short M13_L11
       mov       r8,[rcx+68]
       jmp       short M13_L13
M13_L11:
       mov       rax,[rcx+60]
       mov       r13,[rax+88]
       cmp       byte ptr [r13+119],2
       jne       near ptr M13_L28
M13_L12:
       mov       r8,r13
       mov       rcx,[rbp+30]
M13_L13:
       cmp       byte ptr [rsi+12],0
       jne       near ptr M13_L29
       cmp       qword ptr [r8+0A0],0
       jne       near ptr M13_L29
       xor       r13d,r13d
M13_L14:
       test      r15d,r15d
       jne       short M13_L15
       cmp       dword ptr [r14+8C],0
       jne       near ptr M13_L30
M13_L15:
       mov       rcx,[rbp+30]
       test      r13,r13
       jne       near ptr M13_L31
M13_L16:
       call      qword ptr [7FF7A9C3F018]; System.Text.Json.WriteStack.Push()
       mov       r8,[rdi]
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SmallObjectWithParameterizedConstructorConverter<DotNetTips.Spargine.Tester.Models.RefTypes.Address, System.String, System.Object, System.Object, System.Object>
       cmp       [rsi],rcx
       jne       short M13_L19
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FF7A9B22D78]; System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[[System.__Canon, System.Private.CoreLib]].OnTryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       mov       r15d,eax
M13_L17:
       mov       rcx,[rbp+30]
       mov       edx,r15d
       call      qword ptr [7FF7A9C3F5D0]; System.Text.Json.WriteStack.Pop(Boolean)
       test      r15d,r15d
       je        short M13_L18
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+8F],0
       jne       near ptr M13_L32
M13_L18:
       mov       eax,r15d
       jmp       near ptr M13_L34
M13_L19:
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       mov       r15d,eax
       jmp       short M13_L17
M13_L20:
       mov       ecx,[r14+88]
       call      qword ptr [7FF7A9C3F750]
       int       3
M13_L21:
       mov       rcx,rbx
       call      qword ptr [7FF7A9C3F780]
       jmp       near ptr M13_L09
M13_L22:
       cmp       byte ptr [rsi+1A],0
       je        near ptr M13_L01
       mov       rdi,[rdi]
       add       rcx,90
       call      qword ptr [7FF7A9B65F68]; System.Nullable`1[[System.Text.Json.Serialization.JsonNumberHandling, System.Text.Json]].get_Value()
       mov       r9d,eax
       mov       r8,rdi
       mov       rdx,rbx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       jmp       near ptr M13_L08
M13_L23:
       mov       ecx,edi
       call      qword ptr [7FF7A9EEDD58]
       int       3
M13_L24:
       mov       rcx,rbx
       call      qword ptr [7FF7A9EEDD70]
       test      eax,eax
       jne       near ptr M13_L04
       mov       rcx,rbx
       call      qword ptr [7FF7A9EEDD88]
       jmp       near ptr M13_L04
M13_L25:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FF7A9EEDDA0]
       jmp       near ptr M13_L06
M13_L26:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+28]
       jmp       near ptr M13_L08
M13_L27:
       mov       rcx,rsi
       call      qword ptr [7FF7A9C3F6F0]
       int       3
M13_L28:
       mov       rcx,r13
       call      qword ptr [7FF7A9AF6AD8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M13_L12
M13_L29:
       mov       [rsp+20],rcx
       mov       rdx,[rdi]
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FF7A9EEDCE0]
       mov       r13,rax
       mov       rcx,[rbp+30]
       jmp       near ptr M13_L14
M13_L30:
       mov       [rsp+20],r13
       mov       [rsp+28],rcx
       mov       r8,[rdi]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FF7A9EEDCF8]
       test      eax,eax
       je        near ptr M13_L15
       jmp       near ptr M13_L09
M13_L31:
       mov       [rsp+20],rcx
       mov       r8,[rdi]
       mov       rcx,r13
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+8]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       lea       rax,[rcx+50]
       xor       edx,edx
       mov       r8d,2
       test      r15d,r15d
       cmove     edx,r8d
       mov       [rax+3E],dl
       test      r15d,r15d
       je        near ptr M13_L18
       cmp       byte ptr [rcx+8F],0
       je        near ptr M13_L18
       mov       rax,[rcx+20]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M13_L33
M13_L32:
       mov       rax,[rcx+20]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M13_L33:
       mov       rcx,[rbp+30]
       mov       byte ptr [rcx+8F],0
       jmp       near ptr M13_L18
M13_L34:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+4F],0
       jne       short M13_L35
       call      qword ptr [7FF7A9EEE898]
M13_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.InvalidOperationException
       call      qword ptr [7FF7A95E6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M13_L37
       mov       rdx,rbx
       mov       rcx,offset MT_System.Text.Json.JsonException
       call      qword ptr [7FF7A95E6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M13_L36
       mov       rcx,rsi
       call      qword ptr [7FF7A9EEE8B0]
       test      rax,rax
       jne       near ptr M13_L39
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FF7A9EEE8C8]
       jmp       near ptr M13_L39
M13_L36:
       mov       rdx,rbx
       mov       rcx,offset MT_System.NotSupportedException
       call      qword ptr [7FF7A95E6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M13_L39
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,1C62CD4F168
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9EEE8F8]
       test      eax,eax
       jne       short M13_L39
       jmp       short M13_L38
M13_L37:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       rdx,1C62CD4F118
       call      qword ptr [7FF7A95EC318]; System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M13_L39
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FF7A9EEE8E0]
       jmp       short M13_L39
M13_L38:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FF7A9EEE910]
M13_L39:
       call      CORINFO_HELP_RETHROW
       int       3
; Total bytes of code 1292
```
```assembly
; System.Text.Json.Utf8JsonWriter.Flush()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+10]
       test      rsi,rsi
       jne       short M14_L00
       cmp       qword ptr [rbx+8],0
       je        short M14_L03
M14_L00:
       xor       ecx,ecx
       mov       [rbx+40],rcx
       mov       [rbx+48],rcx
       test      rsi,rsi
       jne       short M14_L04
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M14_L02
       mov       rcx,[rbx+8]
       mov       r11,offset MT_System.Text.Json.PooledByteBufferWriter
       cmp       [rcx],r11
       jne       near ptr M14_L06
       add       rcx,18
       add       [rcx+0C],edx
M14_L01:
       movsxd    rcx,dword ptr [rbx+34]
       add       [rbx+20],rcx
       xor       ecx,ecx
       mov       [rbx+34],ecx
M14_L02:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M14_L03:
       call      qword ptr [7FF7A9EEE568]
       int       3
M14_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M14_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9FB2088]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9EEE598]
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       mov       rcx,[rbx+18]
       movsxd    rcx,dword ptr [rcx+10]
       add       [rbx+20],rcx
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9EEE5B0]
M14_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M14_L02
M14_L06:
       mov       r11,7FF7A9531070
       call      qword ptr [r11]
       jmp       near ptr M14_L01
; Total bytes of code 232
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+68],r9d
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       xor       ebp,ebp
       cmp       byte ptr [rbx+9E],0
       jne       short M15_L02
       cmp       byte ptr [rsp+70],0
       jne       short M15_L01
       mov       rcx,7FF7A9F3E688
       call      CORINFO_HELP_COUNTPROFILE32
M15_L00:
       test      rbp,rbp
       jne       near ptr M15_L08
       cmp       byte ptr [rsp+69],0
       je        near ptr M15_L07
       mov       rcx,7FF7A9F3E67C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FF7A9EE70F0]
       int       3
M15_L01:
       mov       rcx,7FF7A9F3E678
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF7A99FD398]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbp,rax
       jmp       short M15_L00
M15_L02:
       mov       rbp,[rbx+8]
       test      rbp,rbp
       je        near ptr M15_L09
M15_L03:
       cmp       [rbp],bpl
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF7A99FD320]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       cmp       byte ptr [rsp+78],0
       jne       near ptr M15_L11
M15_L04:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       near ptr M15_L12
       mov       rbp,[rax+8]
M15_L05:
       test      dil,dil
       je        near ptr M15_L00
       test      rbp,rbp
       jne       short M15_L06
       mov       rcx,7FF7A9F3E674
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M15_L00
M15_L06:
       mov       rcx,7FF7A9F3E670
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       byte ptr [rbp+119],2
       je        near ptr M15_L00
       jmp       near ptr M15_L14
M15_L07:
       mov       rcx,7FF7A9F3E684
       call      CORINFO_HELP_COUNTPROFILE32
M15_L08:
       mov       rcx,7FF7A9F3E680
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M15_L09:
       mov       rcx,rbx
       call      qword ptr [7FF7A99FCE28]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rbp,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M15_L10
       call      qword ptr [7FF7A9DDFE88]
       int       3
M15_L10:
       mov       rdx,rbp
       xor       r8d,r8d
       call      00007FF8091FCC60
       test      rax,rax
       cmove     rax,rbp
       mov       rbp,rax
       jmp       near ptr M15_L03
M15_L11:
       cmp       byte ptr [rax+20],0
       je        short M15_L13
       jmp       near ptr M15_L04
M15_L12:
       call      qword ptr [7FF7A9EE7648]
       int       3
M15_L13:
       mov       rcx,rbp
       mov       rdx,rsi
       mov       r8,rax
       call      qword ptr [7FF7A9EE7660]
       mov       rbp,rax
       jmp       near ptr M15_L05
M15_L14:
       mov       rcx,rbp
       call      qword ptr [7FF7A9AF6AD8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M15_L00
; Total bytes of code 411
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M16_L01
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M16_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L01
M16_L00:
       test      rax,rax
       je        short M16_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L01
       test      rax,rax
       je        short M16_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L01
       test      rax,rax
       je        short M16_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L01
       test      rax,rax
       je        short M16_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M16_L00
M16_L01:
       mov       rax,rdx
       ret
M16_L02:
       jmp       qword ptr [7FF7A9EE4588]
; Total bytes of code 88
```
```assembly
; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
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
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M17_L37
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M17_L37
M17_L00:
       mov       rdi,[rax+10]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       [rbx+20],rcx
       mov       [rbx+40],rcx
       mov       [rbx+48],rcx
       mov       byte ptr [rbx+38],0
       mov       word ptr [rbx+39],0
       mov       [rbx+28],ecx
       mov       [rbx+50],rcx
       mov       [rbx+58],rcx
       mov       [rbx+60],rcx
       mov       [rbx+68],cx
       mov       [rbx+6A],cl
       mov       byte ptr [rbx+3B],0
       mov       [rbx+10],rcx
       mov       [rbx+18],rcx
       mov       [rbx+8],rcx
       cmp       [rsi],sil
       add       rsi,18
       mov       [rsi+8],ecx
       mov       [rsi+0C],ecx
       mov       rbx,[rsi]
       mov       rcx,1C62CD46EF8
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M17_L36
       cmp       dword ptr [rbx+8],0
       je        near ptr M17_L36
       mov       rcx,18597C01E10
       mov       rsi,[rcx]
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M17_L38
       mov       rcx,[rcx+240]
       mov       r15,[rcx+50]
       test      r15,r15
       je        near ptr M17_L38
M17_L01:
       mov       rax,[r15+10]
       test      rax,rax
       jne       near ptr M17_L16
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolThreadLocalArray[]
       mov       edx,1B
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       lea       rcx,[r15+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15,[rsi+8]
       mov       rcx,[r15+8]
       mov       [rbp-80],rcx
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       qword ptr [rbp-80],0
       je        near ptr M17_L07
       mov       rcx,[rbp-80]
       call      00007FF809262D60
       test      eax,eax
       jne       short M17_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FF7A9876DF0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M17_L02:
       mov       dword ptr [rbp-40],1
       mov       rcx,[r15+10]
       lea       r8,[rbp-48]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF7A987CFA8]; System.Runtime.CompilerServices.ConditionalWeakTable`2+Container[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindEntry(System.__Canon, System.Object ByRef)
       cmp       eax,0FFFFFFFF
       jne       near ptr M17_L08
       mov       r12,[r15+10]
       mov       ecx,[r12+28]
       mov       rax,[r12+18]
       cmp       ecx,[rax+8]
       jge       near ptr M17_L09
M17_L03:
       cmp       byte ptr [r12+2C],0
       jne       near ptr M17_L10
       mov       byte ptr [r12+2C],1
       mov       rcx,r13
       call      00007FF8091F1BC0
       test      eax,eax
       je        near ptr M17_L06
M17_L04:
       mov       r15d,eax
       and       r15d,7FFFFFFF
       mov       eax,[r12+28]
       mov       [rbp-4C],eax
       lea       ecx,[rax+1]
       mov       [r12+28],ecx
       mov       rcx,[r12+18]
       cmp       eax,[rcx+8]
       jae       near ptr M17_L11
       mov       edx,eax
       shl       rdx,4
       lea       r8,[rcx+rdx+10]
       mov       [r8],r15d
       mov       [rbp-88],r8
       mov       rcx,r13
       xor       edx,edx
       call      00007FF809225B60
       test      rax,rax
       je        near ptr M17_L12
M17_L05:
       mov       rcx,[rbp-88]
       mov       [rcx+8],rax
       mov       rcx,[r12+10]
       mov       eax,[rcx+8]
       dec       eax
       and       eax,r15d
       mov       rdx,[r12+18]
       mov       r15d,[rbp-4C]
       cmp       r15d,[rdx+8]
       jae       near ptr M17_L11
       mov       r8d,r15d
       shl       r8,4
       mov       r10,rcx
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       near ptr M17_L11
       mov       r10d,[r10+rax*4+10]
       mov       [rdx+r8+14],r10d
       mov       [rcx+rax*4+10],r15d
       mov       byte ptr [r12+2C],0
       jmp       near ptr M17_L13
M17_L06:
       mov       rcx,r13
       call      qword ptr [7FF7A97B77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M17_L04
M17_L07:
       xor       ecx,ecx
       call      qword ptr [7FF7A9DDF960]
       int       3
M17_L08:
       mov       ecx,36
       call      qword ptr [7FF7A9EECAC8]
       int       3
M17_L09:
       mov       rcx,r12
       call      qword ptr [7FF7A9EEF9F0]
       mov       r12,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M17_L03
M17_L10:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9EEFA08]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A9966010]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M17_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M17_L12:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF7A9EEFA20]
       jmp       near ptr M17_L05
M17_L13:
       mov       rcx,[rbp-80]
       call      00007FF809262C80
       test      eax,eax
       jne       near ptr M17_L39
M17_L14:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       lea       rcx,[rsi+18]
       mov       eax,1
       xchg      al,[rcx]
       movzx     eax,al
       test      eax,eax
       je        near ptr M17_L27
M17_L15:
       mov       rax,r13
M17_L16:
       xor       r15d,r15d
       mov       r13d,1
       cmp       [rax+8],r14d
       jbe       near ptr M17_L23
       mov       r15d,1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       [rbx+8],ecx
       jne       near ptr M17_L41
       mov       ecx,r14d
       shl       rcx,4
       lea       r12,[rax+rcx+10]
       mov       rax,[r12]
       mov       [rbp-78],rax
       mov       rcx,r12
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r12+8],ecx
       mov       r12,[rbp-78]
       test      r12,r12
       je        near ptr M17_L23
       mov       rcx,[rsi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M17_L46
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M17_L17
       mov       rcx,rsi
       mov       edx,r14d
       call      qword ptr [7FF7A9EEE5C8]
M17_L17:
       mov       r13,[rax+8]
       call      qword ptr [7FF7A9CFF300]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       mov       edx,[r13+8]
       mov       [rbp-6C],edx
       test      edx,edx
       jle       near ptr M17_L45
       mov       [rbp-70],edx
M17_L18:
       cmp       eax,edx
       jae       near ptr M17_L46
       mov       [rbp-5C],eax
       mov       ecx,eax
       mov       r10,[r13+rcx*8+10]
       mov       [rbp-90],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-60],r9d
       mov       rcx,r10
       call      00007FF809262D60
       test      eax,eax
       jne       short M17_L19
       mov       rcx,[rbp-90]
       call      qword ptr [7FF7A9876DF0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M17_L19:
       mov       rax,[rbp-90]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-64],r8d
       cmp       [rcx+8],r8d
       jbe       short M17_L21
       test      r8d,r8d
       je        near ptr M17_L30
M17_L20:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-64]
       inc       ecx
       mov       rax,[rbp-90]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-60],1
M17_L21:
       mov       rcx,rax
       call      00007FF809262C80
       test      eax,eax
       jne       near ptr M17_L42
M17_L22:
       cmp       dword ptr [rbp-60],0
       je        near ptr M17_L43
       mov       r13d,1
M17_L23:
       mov       rcx,18597C00AC0
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       je        near ptr M17_L36
       mov       rcx,rbx
       call      00007FF8091F1BC0
       test      eax,eax
       je        near ptr M17_L31
       mov       [rbp-68],eax
M17_L24:
       mov       edx,[rbx+8]
       mov       [rbp-3C],edx
       mov       rcx,rsi
       call      00007FF8091F1BC0
       test      eax,eax
       je        near ptr M17_L32
M17_L25:
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-68]
       mov       r9d,[rbp-3C]
       mov       edx,3
       call      qword ptr [7FF7A9EEC870]
       test      r13d,r15d
       jne       near ptr M17_L36
       mov       rcx,rbx
       call      qword ptr [7FF7A99FCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      00007FF8091F1BC0
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M17_L33
M17_L26:
       test      r15d,r15d
       jne       near ptr M17_L34
       mov       r14d,0FFFFFFFF
       mov       ecx,1
       jmp       near ptr M17_L35
M17_L27:
       mov       r15,18597C01F60
       mov       r12,[r15]
       test      r12,r12
       jne       short M17_L28
       mov       rcx,offset MT_System.Func<System.Object, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,18597C01F58
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Buffers.SharedArrayPool`1+<>c[[System.Byte, System.Private.CoreLib]].<InitializeTlsBucketsAndTrimming>b__11_0(System.Object)
       mov       [r12+18],rcx
       mov       rcx,r15
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M17_L28:
       mov       rcx,offset MT_System.Gen2GcCallback
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       xor       edx,edx
       call      00007FF8091FFF00
       test      rax,rax
       je        near ptr M17_L40
M17_L29:
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [r15+18],rcx
       jmp       near ptr M17_L15
M17_L30:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       near ptr M17_L20
M17_L31:
       mov       rcx,rbx
       call      qword ptr [7FF7A97B77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       [rbp-68],eax
       jmp       near ptr M17_L24
M17_L32:
       mov       rcx,rsi
       call      qword ptr [7FF7A97B77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M17_L25
M17_L33:
       mov       rcx,rsi
       call      qword ptr [7FF7A97B77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M17_L26
M17_L34:
       xor       ecx,ecx
M17_L35:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,ebx
       call      qword ptr [7FF7A9EEC888]
M17_L36:
       dec       dword ptr [rdi+18]
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
M17_L37:
       mov       ecx,9
       call      qword ptr [7FF7A9EE4180]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M17_L00
M17_L38:
       mov       ecx,0A
       call      qword ptr [7FF7A9EE4180]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M17_L01
M17_L39:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FF7A987CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M17_L14
M17_L40:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF7A9EEFA38]
       jmp       near ptr M17_L29
M17_L41:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7A9EEC858]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF7A9524000
       call      qword ptr [7FF7A95EF228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF7A99660B8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M17_L42:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FF7A987CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M17_L22
M17_L43:
       mov       eax,[rbp-5C]
       inc       eax
       mov       ecx,eax
       mov       edx,[rbp-6C]
       cmp       edx,ecx
       jne       short M17_L44
       xor       ecx,ecx
M17_L44:
       mov       r8d,[rbp-70]
       dec       r8d
       mov       [rbp-70],r8d
       mov       eax,ecx
       jne       near ptr M17_L18
M17_L45:
       xor       r13d,r13d
       jmp       near ptr M17_L23
M17_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-40],0
       je        short M17_L48
       cmp       qword ptr [rbp-80],0
       jne       short M17_L47
       xor       ecx,ecx
       call      qword ptr [7FF7A9DDF960]
       int       3
M17_L47:
       mov       rcx,[rbp-80]
       call      00007FF809262C80
       test      eax,eax
       je        short M17_L48
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FF7A987CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M17_L48:
       nop
       add       rsp,38
       ret
; Total bytes of code 1862
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
       je        near ptr M19_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M19_L01
       test      rsi,rsi
       je        short M19_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M19_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M19_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF809259F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7A95E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7A95E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M19_L00:
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
M19_L01:
       test      rsi,rsi
       je        short M19_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M19_L03
M19_L02:
       mov       rax,1C62CD40008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M19_L03:
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
M19_L04:
       call      qword ptr [7FF7A9EE4E88]
       int       3
; Total bytes of code 244
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xorps     xmm4,xmm4
       movaps    [rsp+20],xmm4
       movaps    [rsp+30],xmm4
       mov       rbx,rcx
       call      qword ptr [7FF8127484E0]
       cmp       byte ptr [rax],0
       je        near ptr M20_L03
       call      qword ptr [7FF81274EBE8]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M20_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FF812748278]; CORINFO_HELP_ASSIGN_REF
M20_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M20_L01:
       call      qword ptr [7FF81274A688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M20_L00
       call      qword ptr [7FF8127484D8]
       cmp       byte ptr [rax],0
       je        short M20_L00
       xorps     xmm0,xmm0
       movups    [rsp+30],xmm0
       mov       [rsp+30],rdi
       mov       [rsp+38],rsi
       lea       rcx,[rsp+20]
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       lea       r8,[rsp+30]
       mov       r9d,2
       call      qword ptr [7FF8127502E8]
       lea       rcx,[rsp+20]
       call      qword ptr [7FF81274EC18]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FF812748278]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M20_L00
       cmp       [rsi+10],rbx
       je        short M20_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+9F],0
       jne       short M20_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF81274E4E0]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M20_L00
M20_L02:
       mov       rcx,[rsi+8]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M20_L00
M20_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M20_L04
       call      qword ptr [7FF81274A6A0]
       test      rax,rax
       je        near ptr M20_L00
M20_L04:
       call      qword ptr [7FF81274CE58]
       int       3
; Total bytes of code 284
```
```assembly
; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF81274E588]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF81274C548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       test      rax,rax
       cmove     rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       rax,[rcx+0B8]
       cmp       qword ptr [rax+20],0
       je        near ptr M22_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       near ptr M22_L07
       mov       rbx,[rcx+0B8]
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M22_L08
M22_L00:
       mov       [rbp-20],rsi
       xor       eax,eax
       mov       [rbp-14],eax
       test      rsi,rsi
       je        short M22_L02
       mov       rcx,rsi
       call      00007FF809262D60
       test      eax,eax
       jne       short M22_L01
       mov       rcx,rsi
       call      qword ptr [7FF7A9876DF0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M22_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M22_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M22_L03
       mov       rcx,7FF7A9F569D8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF7A9AF6AF0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M22_L04
M22_L02:
       xor       ecx,ecx
       call      qword ptr [7FF7A9DDF960]
       int       3
M22_L03:
       mov       rcx,7FF7A9F569D4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF7A9EE7648]
       int       3
M22_L04:
       mov       rcx,7FF7A9F569DC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FF809262C80
       test      eax,eax
       jne       near ptr M22_L10
M22_L05:
       mov       rcx,7FF7A9F569E0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF7A9F569E4
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M22_L06:
       call      qword ptr [7FF7A9EE7C18]
       int       3
M22_L07:
       mov       rcx,7FF7A9F569D0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF7A9EE7648]
       int       3
M22_L08:
       mov       rcx,rbx
       call      qword ptr [7FF7A99FCE28]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M22_L09
       call      qword ptr [7FF7A9DDFE88]
       int       3
M22_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF8091FCC60
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M22_L00
M22_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF7A987CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M22_L05
       sub       rsp,28
       call      qword ptr [7FF7A9EE7C30]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M22_L12
       mov       rcx,7FF7A9F569DC
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M22_L11
       xor       ecx,ecx
       call      qword ptr [7FF7A9DDF960]
       int       3
M22_L11:
       mov       rcx,[rbp-20]
       call      00007FF809262C80
       test      eax,eax
       je        short M22_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF7A987CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M22_L12:
       mov       rcx,7FF7A9F569E0
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 535
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFFFEC1CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M23_L01
       cmp       [rax],ecx
       jle       short M23_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M23_L03
M23_L00:
       add       rsp,20
       pop       rbx
       ret
M23_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M23_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M23_L00
M23_L02:
       cmp       [rax+4],edx
       jle       short M23_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M23_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M23_L03
       jmp       short M23_L00
M23_L03:
       mov       ecx,ebx
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M24_L00
       ret
M24_L00:
       jmp       qword ptr [7FF7A95E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_PersonRecord()
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
       mov       rcx,[rbx+40]
       test      rcx,rcx
       je        near ptr M00_L37
       mov       [rbp-40],rcx
       mov       rcx,1D2CF001E08
       mov       r14,[rcx]
       cmp       byte ptr [r14+9F],0
       je        near ptr M00_L38
M00_L01:
       mov       rdx,[r14+18]
       test      rdx,rdx
       jne       near ptr M00_L09
       xor       esi,esi
       cmp       byte ptr [r14+9E],0
       je        near ptr M00_L06
       mov       rsi,[r14+8]
       test      rsi,rsi
       je        near ptr M00_L39
M00_L02:
       mov       rdi,[rsi+8]
       mov       rcx,1D2CF001968
       mov       r15,[rcx]
       test      r15,r15
       jne       short M00_L03
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF7A950D110
       mov       [r15+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [r15+20],rcx
       mov       rcx,1D2CF001968
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M00_L03:
       cmp       [rdi],dil
       mov       r13,[rdi+8]
       mov       rcx,[r13+8]
       cmp       byte ptr [rdi+19],0
       jne       near ptr M00_L07
       mov       r11,7FF7A9510FB0
       mov       rdx,21363DC27E0
       call      qword ptr [r11]
       mov       r12d,eax
M00_L04:
       lea       r9,[rbp-48]
       mov       [rsp+20],r9
       mov       r9d,r12d
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       mov       r8,21363DC27E0
       call      qword ptr [7FF7A99466A0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       jne       short M00_L05
       mov       r8,rsi
       mov       rdx,21363DC27E0
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-48]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,r12d
       shl       r9,20
       or        r9,1
       mov       rdx,r13
       mov       rcx,rdi
       mov       r8,21363DC27E0
       call      qword ptr [7FF7A994C558]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
M00_L05:
       mov       rcx,[rbp-48]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rax,[rcx+10]
       test      rax,rax
       jne       near ptr M00_L40
       mov       rsi,[rcx+8]
       test      rsi,rsi
       je        short M00_L06
       cmp       byte ptr [rsi+119],2
       jne       near ptr M00_L41
M00_L06:
       test      rsi,rsi
       jne       short M00_L08
       mov       rdx,[r14+20]
       mov       rcx,21363DC27E0
       call      qword ptr [7FF7A9EC7108]
       int       3
M00_L07:
       mov       rcx,21363DC27E0
       mov       rax,[7FF7A950A1C0]
       call      qword ptr [rax+18]
       mov       r12d,eax
       jmp       near ptr M00_L04
M00_L08:
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
M00_L09:
       mov       r14,rdx
       test      r14,r14
       je        short M00_L10
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
       cmp       [r14],rcx
       jne       near ptr M00_L42
M00_L10:
       mov       rsi,[r14+0B8]
       lea       rdx,[rbp-58]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9C17918]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       r15d,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M00_L43
       mov       rcx,[rcx+240]
       mov       rsi,[rcx+48]
       test      rsi,rsi
       je        near ptr M00_L43
M00_L11:
       mov       rax,[rsi+10]
       test      rax,rax
       jne       short M00_L12
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,21363DC6EF8
       mov       [rax+18],rcx
       xor       ecx,ecx
       mov       [rax+20],rcx
       mov       byte ptr [rax+28],1
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
M00_L12:
       mov       ecx,[rax+18]
       lea       edx,[rcx+1]
       mov       [rax+18],edx
       test      ecx,ecx
       je        near ptr M00_L18
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      r15d,r15d
       je        near ptr M00_L45
       mov       rcx,1D2CF001E10
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FF7A9C3C730]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
M00_L13:
       mov       [rbp-70],rax
       lea       rcx,[rsi+18]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       byte ptr [rsi+28],1
       mov       [rbp-148],rsi
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12d,[rbp-4C]
       mov       edx,r12d
       lea       rdi,[r13+70]
       lea       rsi,[rbp-58]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       ecx,9
       mov       eax,20
       test      r12b,8
       cmove     ecx,eax
       mov       [r13+3C],cl
       mov       ecx,edx
       and       ecx,7F0
       sar       ecx,4
       je        short M00_L17
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L14:
       mov       [r13+2C],eax
       test      dl,4
       jne       near ptr M00_L46
       mov       r15,21363DC1718
M00_L15:
       mov       ecx,[r15+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       short M00_L16
       mov       dword ptr [r13+78],3E8
M00_L16:
       mov       [rbp-150],r13
       jmp       near ptr M00_L24
M00_L17:
       mov       eax,2
       jmp       short M00_L14
M00_L18:
       mov       rcx,[rax+8]
       mov       [rbp-148],rcx
       mov       r13,[rax+10]
       mov       rcx,[rbp-148]
       cmp       [rcx],cl
       mov       rcx,[rbp-148]
       add       rcx,18
       mov       rdx,[rcx]
       mov       edx,[rdx+8]
       sub       edx,[rcx+0C]
       cmp       edx,r15d
       jl        near ptr M00_L22
M00_L19:
       lea       rcx,[r13+8]
       mov       rdx,[rbp-148]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12d,[rbp-4C]
       mov       edx,r12d
       lea       rdi,[r13+70]
       lea       rsi,[rbp-58]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       ecx,9
       mov       eax,20
       test      r12b,8
       cmove     ecx,eax
       mov       [r13+3C],cl
       mov       ecx,edx
       and       ecx,7F0
       sar       ecx,4
       je        short M00_L23
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L20:
       mov       [r13+2C],eax
       test      dl,4
       jne       near ptr M00_L44
       mov       rsi,21363DC1718
M00_L21:
       mov       ecx,[rsi+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       near ptr M00_L16
       mov       dword ptr [r13+78],3E8
       jmp       near ptr M00_L16
M00_L22:
       mov       edx,r15d
       call      qword ptr [7FF7A9C179A8]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L19
M00_L23:
       mov       eax,2
       jmp       short M00_L20
M00_L24:
       cmp       byte ptr [r14+116],0
       jne       near ptr M00_L32
       mov       rcx,[r14+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M00_L30
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L30
       mov       rsi,[r14+0B8]
       mov       rcx,[rbp-40]
       cmp       [rsi],sil
       call      qword ptr [7FF7A97961D8]; System.Object.GetType()
       mov       r9,21363DC27E0
       cmp       rax,r9
       je        near ptr M00_L30
       mov       r14,[rsi+10]
       test      r14,r14
       je        near ptr M00_L33
       mov       r9,[r14+0C0]
       cmp       r9,rax
       jne       near ptr M00_L33
M00_L25:
       cmp       byte ptr [r14+11A],0
       je        near ptr M00_L29
M00_L26:
       mov       r8,[r14+0F8]
       test      r8,r8
       cmovne    r14,r8
       mov       r8,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r14],r8
       jne       near ptr M00_L35
       mov       r9,[rbp-40]
       mov       r8,r9
       test      r8,r8
       je        short M00_L27
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       cmp       [r8],rcx
       jne       near ptr M00_L34
M00_L27:
       mov       [rbp-118],r8
       lea       r8,[rbp-118]
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FF7A9C17A80]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       xor       edx,edx
       mov       [rbp-118],rdx
M00_L28:
       mov       r9,[rbp-148]
       cmp       [r9],r9b
       mov       rdx,[rbp-148]
       add       rdx,18
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-128],xmm0
       mov       r9d,[rdx+0C]
       mov       r8d,[rdx+8]
       sub       r9d,r8d
       mov       rdx,[rdx]
       lea       rcx,[rbp-128]
       call      qword ptr [7FF7A9C1F930]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rcx,[rbp-128]
       mov       eax,[rbp-120]
       mov       [rbp-140],rcx
       mov       [rbp-138],eax
       lea       rcx,[rbp-140]
       call      qword ptr [7FF7A9B46070]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rsi,rax
       jmp       near ptr M00_L36
M00_L29:
       mov       rcx,r14
       call      qword ptr [7FF7A9C1E070]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[r14+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+11A],1
       jmp       near ptr M00_L26
M00_L30:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-110],ymm0
       vmovdqu   ymmword ptr [rbp-0F0],ymm0
       vmovdqu   ymmword ptr [rbp-0D0],ymm0
       vmovdqu   ymmword ptr [rbp-0B0],ymm0
       vmovdqu   ymmword ptr [rbp-90],ymm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-110]
       mov       rdx,r14
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF7A9C1EFD0]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-110]
       mov       [rsp+20],rcx
       mov       rcx,[r14+158]
       mov       r9,[r14+0B8]
       lea       r8,[rbp-40]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9C1EFE8]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L31:
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9C1F918]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M00_L28
M00_L32:
       mov       rax,[r14+148]
       mov       rdx,r13
       mov       r8,[rbp-40]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M00_L31
M00_L33:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9d,101
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8d,1
       call      qword ptr [7FF7A99DCDE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r14,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L25
M00_L34:
       mov       rdx,r9
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L35:
       mov       rcx,r14
       mov       rdx,r13
       mov       r8,[rbp-40]
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L28
M00_L36:
       mov       rcx,r13
       mov       rdx,[rbp-148]
       call      qword ptr [7FF7A9C1F948]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       [rbp-130],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-130]
       mov       rdx,7FF7A9DEF620
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9DB7270]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L37:
       call      qword ptr [7FF7A9B4E880]
       mov       ecx,1C4D
       mov       rdx,7FF7A9895420
       call      qword ptr [7FF7A95CF228]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FF7A9895420
       call      qword ptr [7FF7A95CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A95CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FF7A9895420
       call      qword ptr [7FF7A95CF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A95CD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7A9ECF5A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7A9EC4558]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       rcx,r14
       call      qword ptr [7FF7A99D75D0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L39:
       mov       rcx,r14
       call      qword ptr [7FF7A99DCDF8]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rax
       call      qword ptr [7FF7A9EC7660]
       int       3
M00_L41:
       mov       rcx,rsi
       call      qword ptr [7FF7A9AD6AD8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L06
M00_L42:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L43:
       mov       ecx,9
       call      qword ptr [7FF7A9EC4198]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rsi,rax
       jmp       near ptr M00_L11
M00_L44:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D2E50007E8
       mov       rsi,[rcx]
       jmp       near ptr M00_L21
M00_L45:
       mov       rax,21363DC6EF8
       jmp       near ptr M00_L13
M00_L46:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D2E50007E8
       mov       r15,[rcx]
       jmp       near ptr M00_L15
       sub       rsp,48
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-148]
       call      qword ptr [7FF7A9C1F948]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       nop
       add       rsp,48
       ret
; Total bytes of code 2267
```
```assembly
; System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7A99DD398]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M01_L00:
       mov       rcx,7FF7A9F68BFC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-20]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,7FF7A9F68BF8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A9EC7C48]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF7A9ECD1B8]
       mov       [rbp-20],rsi
       lea       rax,[M01_L00]
       add       rsp,28
       ret
; Total bytes of code 185
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       ebx,r9d
       mov       rbp,[rdx+8]
       mov       rcx,[rdx+10]
       mov       eax,ebx
       imul      rax,[rdx+28]
       shr       rax,20
       inc       rax
       mov       edx,[rcx+8]
       mov       r8d,edx
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M02_L05
       mov       edx,eax
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       jne       short M02_L03
M02_L00:
       mov       rcx,7FF7A9F1EC3C
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       mov       rbx,[rsp+80]
       mov       [rbx],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       rdx,7FF7A9F1EB28
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rbp
       mov       rdx,[r14+8]
       mov       r11,r15
       mov       r8,rdi
       call      qword ptr [r15]
       test      eax,eax
       jne       short M02_L04
       mov       rcx,7FF7A9F1EC34
       call      CORINFO_HELP_COUNTPROFILE32
M02_L02:
       mov       rcx,7FF7A9F1EC38
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r14,[r14+18]
       test      r14,r14
       je        short M02_L00
M02_L03:
       cmp       ebx,[r14+20]
       jne       short M02_L02
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       jne       short M02_L01
       mov       rcx,rsi
       mov       rdx,7FF7A9F27978
       call      qword ptr [7FF7A95CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,7FF7A9F1EC30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[r14+10]
       mov       rcx,[rsp+80]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 305
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
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
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+28],r9
       mov       rbx,r8
       mov       esi,[rbp+40]
       movzx     r9d,r9b
       mov       rdx,[rbp+18]
       mov       rdi,[rdx+8]
       mov       r14d,[rbp+2C]
       test      r9d,r9d
       jne       short M03_L05
       cmp       byte ptr [rcx+19],0
       jne       short M03_L04
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+78]
       test      r11,r11
       je        short M03_L03
M03_L00:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
M03_L01:
       mov       r15d,eax
M03_L02:
       jmp       near ptr M03_L34
M03_L03:
       mov       rcx,rdx
       mov       rdx,7FF7A9F27888
       call      qword ptr [7FF7A95CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M03_L00
M03_L04:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       short M03_L01
M03_L05:
       mov       rcx,7FF7A9F6ED08
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r15d,r14d
       jmp       short M03_L02
M03_L06:
       test      sil,sil
       je        short M03_L08
       mov       rcx,7FF7A9F6ED0C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-44],ecx
       jae       near ptr M03_L30
       mov       rcx,[rbp-60]
       mov       eax,[rbp-44]
       mov       r12,[rcx+rax*8+10]
       test      r12,r12
       je        near ptr M03_L29
       mov       rcx,r12
       call      00007FF809262D60
       test      eax,eax
       jne       short M03_L07
       mov       rcx,r12
       call      qword ptr [7FF7A979FDF8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M03_L07:
       mov       dword ptr [rbp-50],1
M03_L08:
       mov       rcx,[rbp+18]
       cmp       rcx,[r14+8]
       je        short M03_L11
       mov       rcx,[r14+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+18]
       cmp       rdi,[rcx+8]
       je        short M03_L10
       mov       rcx,7FF7A9F6ED10
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdi,[rcx+8]
       cmp       byte ptr [r14+19],0
       jne       near ptr M03_L28
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M03_L27
M03_L09:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       r15d,eax
M03_L10:
       mov       rcx,7FF7A9F6ED14
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L32
M03_L11:
       xor       esi,esi
       mov       r12,[r13]
       test      r12,r12
       jne       near ptr M03_L20
M03_L12:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        near ptr M03_L24
M03_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rax,[r13]
       mov       [rbp-68],rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,[rbp-68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+20],r15d
       mov       rcx,r13
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       mov       eax,[rcx+8]
       cmp       [rbp-44],eax
       jae       near ptr M03_L30
       mov       eax,[rbp-44]
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M03_L31
       mov       [rcx],eax
       cmp       eax,[r14+10]
       jle       short M03_L14
       mov       rcx,7FF7A9F6ED30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       dword ptr [rbp-48],1
M03_L14:
       cmp       esi,64
       jbe       near ptr M03_L26
       mov       rcx,rdi
       mov       rdx,7FF7A9F6ED38
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FF7A95C6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M03_L25
       mov       rcx,7FF7A9F6EE40
       call      CORINFO_HELP_COUNTPROFILE32
       mov       dword ptr [rbp-4C],1
       jmp       near ptr M03_L36
M03_L15:
       mov       rcx,7FF7A9F6ED1C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[r12+10]
       mov       rcx,[rbp+48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L23
M03_L16:
       mov       rcx,rax
M03_L17:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M03_L21
M03_L18:
       mov       rdx,[r12+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M03_L22
       mov       rcx,7FF7A9F6ED18
       call      CORINFO_HELP_COUNTPROFILE32
M03_L19:
       mov       rcx,7FF7A9F6ED28
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       mov       rcx,7FF7A9F6ED2C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r12,[r12+18]
       test      r12,r12
       je        near ptr M03_L12
M03_L20:
       cmp       r15d,[r12+20]
       jne       short M03_L19
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       jne       near ptr M03_L16
       mov       rdx,7FF7A9F28128
       call      qword ptr [7FF7A95CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L17
M03_L21:
       mov       rdx,7FF7A9F27978
       call      qword ptr [7FF7A95CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M03_L18
M03_L22:
       cmp       byte ptr [rbp+38],0
       je        near ptr M03_L15
       lea       rcx,[r12+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L23:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       jmp       near ptr M03_L35
M03_L24:
       mov       rdx,7FF7A9F59990
       call      qword ptr [7FF7A95CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M03_L13
M03_L25:
       mov       rcx,7FF7A9F6ED24
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L36
M03_L26:
       mov       rcx,7FF7A9F6ED20
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L36
M03_L27:
       mov       rdx,7FF7A9F27888
       call      qword ptr [7FF7A95CF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M03_L09
M03_L28:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M03_L10
M03_L29:
       xor       ecx,ecx
       call      qword ptr [7FF7A9DBF978]
       int       3
M03_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L31:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L32:
       cmp       dword ptr [rbp-50],0
       je        short M03_L33
       mov       rcx,7FF7A9F6EE44
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-44],ecx
       jae       near ptr M03_L40
       mov       rcx,[rbp-60]
       mov       eax,[rbp-44]
       mov       r12,[rcx+rax*8+10]
       test      r12,r12
       je        near ptr M03_L39
       mov       rcx,r12
       call      00007FF809262C80
       test      eax,eax
       jne       near ptr M03_L38
M03_L33:
       mov       rcx,7FF7A9F6EE48
       call      CORINFO_HELP_COUNTPROFILE32
       nop
M03_L34:
       mov       rax,[rbp+18]
       mov       rcx,[rax+18]
       mov       [rbp-60],rcx
       mov       r14,[rbp+10]
       cmp       [r14],r14d
       mov       rax,[rbp+18]
       mov       r8,[rax+10]
       mov       rax,[rbp+18]
       mov       r10d,r15d
       imul      r10,[rax+28]
       shr       r10,20
       inc       r10
       mov       r9d,[r8+8]
       mov       r11d,r9d
       imul      r10,r11
       shr       r10,20
       mov       eax,r10d
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rbp-44],edx
       cmp       r10d,r9d
       jae       near ptr M03_L40
       mov       ecx,r10d
       lea       r13,[r8+rcx*8+10]
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       [rbp-4C],ecx
       mov       [rbp-50],ecx
       jmp       near ptr M03_L06
M03_L35:
       call      M03_L41
       nop
       mov       rcx,7FF7A9F6EE54
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,[rbp-54]
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
M03_L36:
       call      M03_L41
       nop
       mov       ecx,[rbp-48]
       or        ecx,[rbp-4C]
       je        short M03_L37
       mov       rcx,7FF7A9F6EE4C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8d,[rbp-48]
       mov       r9d,[rbp-4C]
       call      qword ptr [7FF7A9CD4150]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
M03_L37:
       mov       rcx,7FF7A9F6EE50
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
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
M03_L38:
       mov       ecx,eax
       mov       rdx,r12
       call      qword ptr [7FF7A985CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M03_L33
M03_L39:
       xor       ecx,ecx
       call      qword ptr [7FF7A9DBF978]
       int       3
M03_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L41:
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M03_L44
       mov       rcx,7FF7A9F6EE44
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-44],ecx
       jae       short M03_L42
       mov       rcx,[rbp-60]
       mov       eax,[rbp-44]
       mov       r12,[rcx+rax*8+10]
       test      r12,r12
       jne       short M03_L43
       xor       ecx,ecx
       call      qword ptr [7FF7A9DBF978]
       int       3
M03_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L43:
       mov       rcx,r12
       call      00007FF809262C80
       test      eax,eax
       je        short M03_L44
       mov       ecx,eax
       mov       rdx,r12
       call      qword ptr [7FF7A985CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M03_L44:
       mov       rcx,7FF7A9F6EE48
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 1520
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rax,rdx
       mov       rbx,[rcx+40]
       cmp       byte ptr [rcx+9C],0
       setne     sil
       movzx     esi,sil
       movzx     edx,word ptr [rcx+90]
       cmp       edx,20
       jne       near ptr M04_L10
       and       esi,0FFFFFFF7
M04_L00:
       mov       edx,[rcx+84]
       cmp       edx,7F
       ja        near ptr M04_L12
       and       esi,0FFFFF80F
       test      edx,edx
       je        near ptr M04_L07
       xor       r8d,r8d
       cmp       edx,2
       cmovne    r8d,edx
M04_L01:
       shl       r8d,4
       or        esi,r8d
       mov       edi,[rcx+88]
       test      edi,edi
       jl        near ptr M04_L13
       mov       r8,[rcx+50]
       test      r8,r8
       je        near ptr M04_L14
M04_L02:
       mov       rcx,21363DCFFA8
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],1
       jne       short M04_L03
       cmp       word ptr [r8+0C],0A
       je        short M04_L04
M04_L03:
       mov       rcx,21363DC1718
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],2
       jne       short M04_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M04_L08
M04_L04:
       mov       rcx,21363DC1718
       cmp       r8,rcx
       je        short M04_L05
       cmp       dword ptr [r8+8],2
       jne       short M04_L09
       cmp       dword ptr [r8+0C],0A000D
       jne       short M04_L09
M04_L05:
       and       esi,0FFFFFFFB
M04_L06:
       or        esi,2
       mov       [rax],rbx
       mov       [rax+8],edi
       mov       [rax+0C],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L07:
       mov       r8d,2
       jmp       near ptr M04_L01
M04_L08:
       mov       ecx,38A0
       mov       rdx,7FF7A9A144B8
       call      qword ptr [7FF7A95CF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9ECE2B0]
       int       3
M04_L09:
       or        esi,4
       jmp       short M04_L06
M04_L10:
       cmp       edx,9
       je        short M04_L11
       mov       ecx,38A0
       mov       rdx,7FF7A9A144B8
       call      qword ptr [7FF7A95CF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9ECE268]
       int       3
M04_L11:
       or        esi,8
       jmp       near ptr M04_L00
M04_L12:
       mov       ecx,38A0
       mov       rdx,7FF7A9A144B8
       call      qword ptr [7FF7A95CF228]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FF7A9ECE280]
       int       3
M04_L13:
       mov       ecx,38A0
       mov       rdx,7FF7A9A144B8
       call      qword ptr [7FF7A95CF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9ECE298]
       int       3
M04_L14:
       mov       r8,21363DC1718
       mov       [rcx+50],r8
       jmp       near ptr M04_L02
; Total bytes of code 418
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       ebx,edx
       mov       rcx,1D2CF0003A0
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       short M05_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M05_L02
M05_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M05_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M05_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M05_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M05_L03
M05_L01:
       mov       rax,r14
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
M05_L02:
       mov       ecx,0A
       call      qword ptr [7FF7A9EC4198]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L03:
       mov       rcx,r14
       call      qword ptr [7FF7A99DCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF7A99DCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF7A9ECC720]
       jmp       short M05_L01
M05_L04:
       mov       rax,[rsi+10]
       cmp       [rax+8],ebp
       jbe       near ptr M05_L13
       mov       ecx,ebp
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        near ptr M05_L12
       mov       r14,[rax+8]
       call      qword ptr [7FF7A9CDF288]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       ebx,eax
       sub       ebx,ecx
       xor       r15d,r15d
       jmp       short M05_L08
M05_L05:
       cmp       ebx,[r14+8]
       jae       near ptr M05_L18
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FF7A9ADD890]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M05_L06
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M05_L06:
       mov       rcx,r13
       call      qword ptr [7FF7A95C6820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M05_L09
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M05_L07
       xor       ebx,ebx
M05_L07:
       inc       r15d
M05_L08:
       cmp       [r14+8],r15d
       jg        short M05_L05
       jmp       short M05_L10
M05_L09:
       mov       r14,r12
       jmp       short M05_L11
M05_L10:
       xor       r14d,r14d
M05_L11:
       test      r14,r14
       je        short M05_L12
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       mov       rcx,r14
       call      qword ptr [7FF7A99DCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF7A99DCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF7A9ECC720]
       jmp       near ptr M05_L01
M05_L12:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M05_L15
M05_L13:
       test      ebx,ebx
       jne       short M05_L14
       mov       rax,21363DC6EF8
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
M05_L14:
       mov       ecx,ebx
       mov       rdx,21363DC3D28
       call      qword ptr [7FF7A985D920]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M05_L15:
       cmp       ebx,800
       jge       short M05_L16
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M05_L17
M05_L16:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FF7A9C17A50]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M05_L17:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FF7A99DCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF7A99DCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF7A9ECC720]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF7A99DCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rsi+10]
       mov       edx,1
       mov       r8d,2
       cmp       [rcx+8],ebp
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rdi
       mov       edx,ebx
       mov       r8d,r15d
       call      qword ptr [7FF7A9ECC738]
       jmp       near ptr M05_L01
M05_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 712
```
```assembly
; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,[rbx]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M06_L20
       mov       rcx,1D2CF001E10
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       ebp,edx
       mov       rcx,1D2CF0003A0
       mov       r14,[rcx]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       short M06_L04
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M06_L04
M06_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M06_L06
       mov       eax,[rcx+8]
       cmp       eax,r15d
       jbe       near ptr M06_L06
       mov       eax,r15d
       shl       rax,4
       mov       r13,[rcx+rax+10]
       test      r13,r13
       je        short M06_L06
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [r14+9D],0
       jne       short M06_L05
M06_L01:
       mov       rdx,r13
M06_L02:
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M06_L03:
       nop
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
M06_L04:
       mov       ecx,0A
       call      qword ptr [7FF7A9EC4198]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M06_L00
M06_L05:
       mov       rcx,r13
       call      qword ptr [7FF7A99DCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       ebp,[r13+8]
       mov       rcx,rsi
       call      qword ptr [7FF7A99DCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF7A9ECC720]
       jmp       short M06_L01
M06_L06:
       mov       rax,[rdi+10]
       cmp       [rax+8],r15d
       jbe       near ptr M06_L15
       mov       ecx,r15d
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        near ptr M06_L14
       mov       r13,[rax+8]
       call      qword ptr [7FF7A9CDF288]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       ebp,eax
       sub       ebp,ecx
       xor       esi,esi
       jmp       short M06_L10
M06_L07:
       cmp       ebp,[r13+8]
       jae       near ptr M06_L26
       mov       ecx,ebp
       mov       r12,[r13+rcx*8+10]
       cmp       [r12],r12b
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rcx,r12
       call      qword ptr [7FF7A9ADD890]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r12+8]
       mov       eax,[r12+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M06_L08
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       mov       [rsp+30],rdx
       mov       r8d,eax
       xor       r10d,r10d
       mov       [rcx+r8*8+10],r10
       mov       [r12+10],eax
M06_L08:
       mov       rcx,r12
       call      qword ptr [7FF7A95C6820]; System.Threading.Monitor.Exit(System.Object)
       mov       r12,[rsp+30]
       test      r12,r12
       jne       short M06_L11
       inc       ebp
       cmp       [r13+8],ebp
       jne       short M06_L09
       xor       ebp,ebp
M06_L09:
       inc       esi
M06_L10:
       cmp       [r13+8],esi
       jg        short M06_L07
       jmp       short M06_L12
M06_L11:
       mov       r13,r12
       jmp       short M06_L13
M06_L12:
       xor       r13d,r13d
M06_L13:
       test      r13,r13
       je        short M06_L14
       cmp       byte ptr [r14+9D],0
       je        near ptr M06_L01
       mov       rcx,r13
       call      qword ptr [7FF7A99DCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF7A99DCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF7A9ECC720]
       jmp       near ptr M06_L01
M06_L14:
       mov       ecx,10
       shlx      ebp,ecx,r15d
       jmp       short M06_L17
M06_L15:
       test      ebp,ebp
       jne       short M06_L16
       mov       rdx,21363DC6EF8
       jmp       near ptr M06_L02
M06_L16:
       mov       ecx,ebp
       mov       rdx,21363DC3D28
       call      qword ptr [7FF7A985D920]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M06_L17:
       cmp       ebp,800
       jge       short M06_L18
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M06_L19
M06_L18:
       mov       ecx,ebp
       xor       edx,edx
       call      qword ptr [7FF7A9C17A50]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M06_L19:
       cmp       byte ptr [r14+9D],0
       je        near ptr M06_L01
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF7A99DCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF7A99DCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF7A9ECC720]
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF7A99DCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rdi+10]
       mov       edx,1
       mov       r8d,2
       cmp       [rcx+8],r15d
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r14
       mov       edx,esi
       mov       r8d,ebp
       call      qword ptr [7FF7A9ECC738]
       jmp       near ptr M06_L01
M06_L20:
       mov       ecx,[rbx+8]
       mov       rax,[rbx]
       mov       eax,[rax+8]
       sub       eax,[rbx+0C]
       add       ecx,eax
       cmp       edx,ecx
       jg        short M06_L21
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       r8,[rbx]
       mov       rcx,[rbx]
       xor       r9d,r9d
       call      qword ptr [7FF7A98568C8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       eax,[rbx+8]
       sub       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+8],eax
       jmp       near ptr M06_L03
M06_L21:
       mov       ecx,[rbx+0C]
       sub       ecx,[rbx+8]
       add       ecx,edx
       cmp       ecx,7FFFFFC7
       jbe       short M06_L22
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A9ECC618]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L22:
       mov       rdx,[rbx]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,7FFFFFC7
       cmp       rdx,7FFFFFC7
       cmovl     rax,rdx
       cmp       ecx,eax
       mov       edx,eax
       cmovge    edx,ecx
       cmp       byte ptr [rbx+10],0
       jne       short M06_L23
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M06_L24
M06_L23:
       mov       rcx,1D2CF001E10
       mov       rcx,[rcx]
       call      qword ptr [7FF7A9C3C730]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rsi,rax
M06_L24:
       mov       rdi,[rbx]
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       je        short M06_L25
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       rcx,rdi
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF7A98568C8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
M06_L25:
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+10],0
       je        near ptr M06_L03
       cmp       dword ptr [rdi+8],0
       je        near ptr M06_L03
       mov       rcx,1D2CF001E10
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF7A9C3C738]; Precode of System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M06_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1092
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
       je        short M07_L01
M07_L00:
       add       rsp,20
       pop       rbx
       ret
M07_L01:
       call      qword ptr [7FF7A95C5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M07_L00
; Total bytes of code 41
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
M08_L00:
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E0
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqu   ymmword ptr [rsp+0C0],ymm4
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       rbp,r9
       cmp       byte ptr [rbx+116],0
       jne       near ptr M08_L10
       mov       rcx,[rbx+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M08_L07
       mov       r8,[rsi]
       test      r8,r8
       je        near ptr M08_L07
       mov       r14,[rbx+0B8]
       mov       rcx,r8
       cmp       [r14],r14b
       call      qword ptr [7FF7A97961D8]; System.Object.GetType()
       mov       r9,21363DC27E0
       cmp       rax,r9
       je        near ptr M08_L07
       mov       rbx,[r14+10]
       test      rbx,rbx
       je        near ptr M08_L05
       mov       r9,[rbx+0C0]
       cmp       r9,rax
       jne       short M08_L05
M08_L01:
       cmp       byte ptr [rbx+11A],0
       je        near ptr M08_L06
M08_L02:
       mov       r8,[rbx+0F8]
       test      r8,r8
       cmovne    rbx,r8
       mov       r9,[rsi]
       mov       r8,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rbx],r8
       jne       near ptr M08_L12
       mov       r8,r9
       test      r8,r8
       je        short M08_L03
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       cmp       [r8],rcx
       jne       near ptr M08_L11
M08_L03:
       mov       [rsp+38],r8
       lea       r8,[rsp+38]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF7A9C17A80]
M08_L04:
       nop
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L05:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9d,101
       mov       rcx,r14
       mov       rdx,rax
       mov       r8d,1
       call      qword ptr [7FF7A99DCDE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbx,rax
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L01
M08_L06:
       mov       rcx,rbx
       call      qword ptr [7FF7A9C1E070]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[rbx+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+11A],1
       jmp       near ptr M08_L02
M08_L07:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+40],ymm0
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   ymmword ptr [rsp+0C0],ymm0
       mov       [rsp+0A8],rbx
       mov       rcx,[rbx+0D0]
       mov       [rsp+0A0],rcx
       mov       rcx,[rsp+0A0]
       mov       rcx,[rcx+0C8]
       mov       [rsp+0D0],rcx
       mov       byte ptr [rsp+8E],0
       mov       byte ptr [rsp+8F],0
       mov       r14,[rbx+0B8]
       cmp       dword ptr [r14+8C],0
       je        short M08_L08
       mov       rcx,[r14+38]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rsp+60],rax
       cmp       dword ptr [r14+8C],2
       jne       short M08_L08
       test      rbp,rbp
       jne       short M08_L13
M08_L08:
       lea       rcx,[rsp+40]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+158]
       mov       r9,[rbx+0B8]
       mov       rdx,rdi
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9C1EFE8]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M08_L09:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9C1F918]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M08_L04
M08_L10:
       mov       rax,[rbx+148]
       mov       r8,[rsi]
       mov       rdx,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M08_L09
M08_L11:
       mov       rdx,r9
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M08_L12:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,r9
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M08_L04
M08_L13:
       mov       rcx,[rbx+0C0]
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        near ptr M08_L08
       mov       rcx,[rsp+60]
       mov       rdx,rbp
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       near ptr M08_L08
; Total bytes of code 706
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       sub       rsp,28
       test      rdx,rdx
       je        short M09_L01
       mov       r8d,r8d
       mov       eax,r9d
       add       rax,r8
       mov       r10d,[rdx+8]
       cmp       rax,r10
       ja        short M09_L02
       add       rdx,10
       add       rdx,r8
       mov       [rcx],rdx
       mov       [rcx+8],r9d
M09_L00:
       add       rsp,28
       ret
M09_L01:
       or        r8d,r9d
       jne       short M09_L02
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       jmp       short M09_L00
M09_L02:
       call      qword ptr [7FF7A979F228]
       int       3
; Total bytes of code 69
```
```assembly
; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-40],rax
       mov       r8,1D2CF0013D8
       mov       rbx,[r8]
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       r8d,1
       test      edi,edi
       cmove     rsi,r8
       mov       [rbp-38],rsi
       test      rsi,rsi
       je        near ptr M10_L04
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FF7A979CD98]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       mov       r9d,eax
       sub       r9d,esi
       mov       r14d,r9d
       add       r14d,[rbp-48]
       cmp       r9d,edi
       jne       near ptr M10_L05
M10_L00:
       test      r14d,r14d
       je        near ptr M10_L02
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FF809259F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       [rbp-40],rcx
       mov       r13,[rbp-40]
       test      r13,r13
       je        near ptr M10_L06
       mov       ecx,edi
       or        ecx,r14d
       jl        near ptr M10_L07
       lea       rcx,[rbp-58]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-60]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       mov       edx,edi
       mov       r8,r13
       mov       r9d,r14d
       call      qword ptr [7FF7A979CDC8]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
       mov       ecx,[rbp-58]
       sub       ecx,esi
       mov       rdx,[rbp-60]
       sub       rdx,r13
       mov       r8,rdx
       shr       r8,3F
       add       rdx,r8
       sar       rdx,1
       cmp       ecx,edi
       jne       short M10_L08
M10_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       jmp       short M10_L03
M10_L02:
       mov       r15,21363DC0008
M10_L03:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       near ptr M10_L09
M10_L04:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FF7A9B4DFE0]
       int       3
M10_L05:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FF7A9B4DFB0]
       add       r14d,eax
       jns       near ptr M10_L00
       call      qword ptr [7FF7A9B4DFF8]
       int       3
M10_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FF7A9B4DFE0]
       int       3
M10_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FF7A9B45E90]
       int       3
M10_L08:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,r13
       call      qword ptr [7FF7A9B4E250]
       jmp       near ptr M10_L01
M10_L09:
       mov       rax,r15
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,48
       call      qword ptr [7FF7A9DBE3B8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 442
```
```assembly
; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       cmp       qword ptr [rbx+80],0
       jne       near ptr M11_L08
       xor       esi,esi
       mov       rcx,[rbx+0C0]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdi,rax
       test      rdi,rdi
       je        short M11_L02
M11_L00:
       mov       rdx,[rbx+0B8]
       mov       rcx,rdi
       call      qword ptr [7FF81274F030]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        short M11_L01
       mov       rcx,[rax+80]
       test      rcx,rcx
       jne       short M11_L04
M11_L01:
       mov       rcx,rdi
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       call      qword ptr [r11]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M11_L00
M11_L02:
       mov       rcx,[rbx+0C0]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdi,rax
       xor       ebp,ebp
       cmp       [rdi+8],ebp
       jg        short M11_L05
M11_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M11_L04:
       mov       rsi,rax
       jmp       short M11_L02
M11_L05:
       mov       r14,[rdi+rbp*8+10]
       mov       rdx,[rbx+0B8]
       mov       rcx,r14
       call      qword ptr [7FF81274F030]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
       mov       r15,rax
       test      r15,r15
       je        short M11_L07
       mov       rcx,[r15+80]
       test      rcx,rcx
       je        short M11_L07
       test      rsi,rsi
       je        short M11_L06
       mov       rcx,[rsi+0C0]
       mov       rdx,r14
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M11_L06
       mov       rdx,[rsi+0C0]
       mov       rcx,r14
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M11_L07
       jmp       short M11_L08
M11_L06:
       mov       rsi,r15
M11_L07:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        short M11_L05
       jmp       near ptr M11_L03
M11_L08:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 292
```
```assembly
; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rbp,r8
       mov       edi,r9d
       lea       rcx,[rbx+68]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rsi+0D0]
       lea       rcx,[rbx+60]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+60]
       mov       rcx,[rcx+0C8]
       mov       [rbx+90],rcx
       mov       [rbx+4E],dil
       movzx     edi,byte ptr [rsp+70]
       mov       [rbx+4F],dil
       mov       rdi,[rsi+0B8]
       cmp       dword ptr [rdi+8C],0
       jne       short M12_L01
M12_L00:
       mov       rcx,7FF7A9F7C120
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M12_L01:
       mov       r14,[rdi+38]
       mov       rcx,r14
       mov       rdx,7FF7A9F7C018
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r14
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       dword ptr [rdi+8C],2
       jne       near ptr M12_L04
       test      rbp,rbp
       je        short M12_L03
       mov       rcx,[rsi+0C0]
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        short M12_L02
       mov       rcx,7FF7A9F7C124
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF7A9F7C120
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rbx,[rbx+20]
       mov       rcx,rbx
       mov       rdx,7FF7A9F7C128
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rbx
       mov       rdx,rbp
       mov       rax,[rcx]
       mov       rax,[rax+48]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M12_L02:
       mov       rcx,7FF7A9F7C230
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L00
M12_L03:
       mov       rcx,7FF7A9F7C234
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L00
M12_L04:
       mov       rcx,7FF7A9F7C238
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L00
; Total bytes of code 354
```
```assembly
; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-48],xmm4
       xor       eax,eax
       mov       [rbp-38],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14,r9
       mov       r15d,[rbx+28]
       and       r15d,7FFFFFFF
       cmp       r15d,[r14+88]
       jge       near ptr M13_L21
       cmp       byte ptr [rsi+17],0
       jne       short M13_L00
       cmp       qword ptr [rdi],0
       je        near ptr M13_L22
M13_L00:
       cmp       byte ptr [rsi+10],2
       jne       near ptr M13_L11
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+90],0
       jne       near ptr M13_L23
M13_L01:
       mov       r8,[rdi]
       mov       rdx,offset MT_System.Text.Json.Serialization.Converters.StringConverter
       cmp       [rsi],rdx
       jne       near ptr M13_L25
       test      r8,r8
       je        near ptr M13_L08
       lea       r14,[r8+0C]
       mov       edi,[r8+8]
       cmp       edi,9EF21AA
       jg        near ptr M13_L24
       lea       rdx,[rbx+70]
       mov       rdx,[rdx]
       test      edi,edi
       je        short M13_L02
       mov       [rbp-38],r14
       mov       r8,r14
       mov       rax,1D2CF001400
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       [rbp-50],rdx
       mov       rcx,rdx
       mov       rdx,r8
       mov       r8d,edi
       mov       rax,[rbp-50]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rcx,[rbp+30]
       jmp       short M13_L03
M13_L02:
       mov       eax,0FFFFFFFF
M13_L03:
       xor       edx,edx
       mov       [rbp-38],rdx
       cmp       eax,0FFFFFFFF
       jne       short M13_L06
       test      byte ptr [rbx+7C],2
       jne       short M13_L04
       movzx     eax,byte ptr [rbx+38]
       cmp       eax,10
       sete      dl
       movzx     edx,dl
       movzx     r8d,byte ptr [rbx+3A]
       cmp       eax,r8d
       sete      al
       movzx     eax,al
       or        eax,edx
       jne       short M13_L04
       mov       rcx,rbx
       call      qword ptr [7FF7A9ECDDA0]
       mov       rcx,[rbp+30]
M13_L04:
       test      byte ptr [rbx+7C],1
       jne       short M13_L05
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FF7A9C1F3F0]; System.Text.Json.Utf8JsonWriter.WriteStringMinimized(System.ReadOnlySpan`1<Char>)
       jmp       short M13_L07
M13_L05:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FF7A9ECDDB8]
       jmp       short M13_L07
M13_L06:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FF7A9CD4228]; System.Text.Json.Utf8JsonWriter.WriteStringEscapeValue(System.ReadOnlySpan`1<Char>, Int32)
M13_L07:
       or        dword ptr [rbx+28],80000000
       mov       byte ptr [rbx+3A],7
       jmp       short M13_L09
M13_L08:
       mov       rcx,rbx
       call      qword ptr [7FF7A9C1F600]
M13_L09:
       mov       ecx,[rbx+28]
       and       ecx,7FFFFFFF
       cmp       r15d,ecx
       jne       near ptr M13_L26
M13_L10:
       mov       eax,1
       jmp       near ptr M13_L33
M13_L11:
       mov       rcx,[rbp+30]
       cmp       dword ptr [rcx+44],0
       setne     r15b
       movzx     r15d,r15b
       cmp       qword ptr [rdi],0
       je        short M13_L17
       cmp       byte ptr [rcx+8E],1
       je        short M13_L17
       cmp       dword ptr [rcx+40],0
       jne       short M13_L12
       mov       r8,[rcx+68]
       jmp       short M13_L14
M13_L12:
       mov       rax,[rcx+60]
       mov       r13,[rax+88]
       cmp       byte ptr [r13+119],2
       jne       near ptr M13_L27
M13_L13:
       mov       r8,r13
       mov       rcx,[rbp+30]
M13_L14:
       cmp       byte ptr [rsi+12],0
       jne       near ptr M13_L28
       cmp       qword ptr [r8+0A0],0
       jne       near ptr M13_L28
       xor       r13d,r13d
M13_L15:
       test      r15d,r15d
       jne       short M13_L16
       cmp       dword ptr [r14+8C],0
       jne       near ptr M13_L29
M13_L16:
       mov       rcx,[rbp+30]
       test      r13,r13
       jne       near ptr M13_L30
M13_L17:
       call      qword ptr [7FF7A9C1F018]; System.Text.Json.WriteStack.Push()
       mov       r8,[rdi]
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SmallObjectWithParameterizedConstructorConverter<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, System.String, System.Object, System.Object, System.Object>
       cmp       [rsi],rcx
       je        short M13_L20
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       mov       r15d,eax
M13_L18:
       mov       rcx,[rbp+30]
       mov       edx,r15d
       call      qword ptr [7FF7A9C1F450]; System.Text.Json.WriteStack.Pop(Boolean)
       test      r15d,r15d
       je        short M13_L19
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+8F],0
       jne       near ptr M13_L31
M13_L19:
       mov       eax,r15d
       jmp       near ptr M13_L33
M13_L20:
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FF7A9B02D78]; System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[[System.__Canon, System.Private.CoreLib]].OnTryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       mov       r15d,eax
       jmp       short M13_L18
M13_L21:
       mov       ecx,[r14+88]
       call      qword ptr [7FF7A9C1F5D0]
       int       3
M13_L22:
       mov       rcx,rbx
       call      qword ptr [7FF7A9C1F600]
       jmp       near ptr M13_L10
M13_L23:
       cmp       byte ptr [rsi+1A],0
       je        near ptr M13_L01
       mov       rdi,[rdi]
       add       rcx,90
       call      qword ptr [7FF7A9B45F68]; System.Nullable`1[[System.Text.Json.Serialization.JsonNumberHandling, System.Text.Json]].get_Value()
       mov       r9d,eax
       mov       r8,rdi
       mov       rdx,rbx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       jmp       near ptr M13_L09
M13_L24:
       mov       ecx,edi
       call      qword ptr [7FF7A9ECDD70]
       int       3
M13_L25:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+28]
       jmp       near ptr M13_L09
M13_L26:
       mov       rcx,rsi
       call      qword ptr [7FF7A9C1F570]
       int       3
M13_L27:
       mov       rcx,r13
       call      qword ptr [7FF7A9AD6AD8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M13_L13
M13_L28:
       mov       [rsp+20],rcx
       mov       rdx,[rdi]
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FF7A9ECDCE0]
       mov       r13,rax
       mov       rcx,[rbp+30]
       jmp       near ptr M13_L15
M13_L29:
       mov       [rsp+20],r13
       mov       [rsp+28],rcx
       mov       r8,[rdi]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FF7A9ECDCF8]
       test      eax,eax
       je        near ptr M13_L16
       jmp       near ptr M13_L10
M13_L30:
       mov       [rsp+20],rcx
       mov       r8,[rdi]
       mov       rcx,r13
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+8]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       lea       rax,[rcx+50]
       xor       edx,edx
       mov       r8d,2
       test      r15d,r15d
       cmove     edx,r8d
       mov       [rax+3E],dl
       test      r15d,r15d
       je        near ptr M13_L19
       cmp       byte ptr [rcx+8F],0
       je        near ptr M13_L19
       mov       rax,[rcx+20]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M13_L32
M13_L31:
       mov       rax,[rcx+20]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M13_L32:
       mov       rcx,[rbp+30]
       mov       byte ptr [rcx+8F],0
       jmp       near ptr M13_L19
M13_L33:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+4F],0
       jne       short M13_L34
       call      qword ptr [7FF7A9ECE370]
M13_L34:
       mov       rdx,rbx
       mov       rcx,offset MT_System.InvalidOperationException
       call      qword ptr [7FF7A95C6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M13_L36
       mov       rdx,rbx
       mov       rcx,offset MT_System.Text.Json.JsonException
       call      qword ptr [7FF7A95C6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M13_L35
       mov       rcx,rsi
       call      qword ptr [7FF7A9ECE388]
       test      rax,rax
       jne       near ptr M13_L38
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FF7A9ECE3A0]
       jmp       near ptr M13_L38
M13_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.NotSupportedException
       call      qword ptr [7FF7A95C6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M13_L38
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,21363DCF168
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9ECE3D0]
       test      eax,eax
       jne       short M13_L38
       jmp       short M13_L37
M13_L36:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       rdx,21363DCF118
       call      qword ptr [7FF7A95CC318]; System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M13_L38
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FF7A9ECE3B8]
       jmp       short M13_L38
M13_L37:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FF7A9ECE3E8]
M13_L38:
       call      CORINFO_HELP_RETHROW
       int       3
; Total bytes of code 1290
```
```assembly
; System.Text.Json.Utf8JsonWriter.Flush()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+10]
       test      rsi,rsi
       jne       short M14_L00
       cmp       qword ptr [rbx+8],0
       je        short M14_L03
M14_L00:
       xor       ecx,ecx
       mov       [rbx+40],rcx
       mov       [rbx+48],rcx
       test      rsi,rsi
       jne       short M14_L04
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M14_L02
       mov       rcx,[rbx+8]
       mov       r11,offset MT_System.Text.Json.PooledByteBufferWriter
       cmp       [rcx],r11
       jne       near ptr M14_L06
       add       rcx,18
       add       [rcx+0C],edx
M14_L01:
       movsxd    rcx,dword ptr [rbx+34]
       add       [rbx+20],rcx
       xor       ecx,ecx
       mov       [rbx+34],ecx
M14_L02:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M14_L03:
       call      qword ptr [7FF7A9ECE808]
       int       3
M14_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M14_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9F7B430]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9ECE838]
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       mov       rcx,[rbx+18]
       movsxd    rcx,dword ptr [rcx+10]
       add       [rbx+20],rcx
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9ECE850]
M14_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M14_L02
M14_L06:
       mov       r11,7FF7A9511038
       call      qword ptr [r11]
       jmp       near ptr M14_L01
; Total bytes of code 232
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+68],r9d
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       xor       ebp,ebp
       cmp       byte ptr [rbx+9E],0
       jne       short M15_L02
       cmp       byte ptr [rsp+70],0
       jne       short M15_L01
       mov       rcx,7FF7A9F1E688
       call      CORINFO_HELP_COUNTPROFILE32
M15_L00:
       test      rbp,rbp
       jne       near ptr M15_L08
       cmp       byte ptr [rsp+69],0
       je        near ptr M15_L07
       mov       rcx,7FF7A9F1E67C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FF7A9EC7108]
       int       3
M15_L01:
       mov       rcx,7FF7A9F1E678
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF7A99DD398]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbp,rax
       jmp       short M15_L00
M15_L02:
       mov       rbp,[rbx+8]
       test      rbp,rbp
       je        near ptr M15_L09
M15_L03:
       cmp       [rbp],bpl
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF7A99DD320]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       cmp       byte ptr [rsp+78],0
       jne       near ptr M15_L11
M15_L04:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       near ptr M15_L12
       mov       rbp,[rax+8]
M15_L05:
       test      dil,dil
       je        near ptr M15_L00
       test      rbp,rbp
       jne       short M15_L06
       mov       rcx,7FF7A9F1E674
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M15_L00
M15_L06:
       mov       rcx,7FF7A9F1E670
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       byte ptr [rbp+119],2
       je        near ptr M15_L00
       jmp       near ptr M15_L14
M15_L07:
       mov       rcx,7FF7A9F1E684
       call      CORINFO_HELP_COUNTPROFILE32
M15_L08:
       mov       rcx,7FF7A9F1E680
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M15_L09:
       mov       rcx,rbx
       call      qword ptr [7FF7A99DCE28]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rbp,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M15_L10
       call      qword ptr [7FF7A9DBFEA0]
       int       3
M15_L10:
       mov       rdx,rbp
       xor       r8d,r8d
       call      00007FF8091FCC60
       test      rax,rax
       cmove     rax,rbp
       mov       rbp,rax
       jmp       near ptr M15_L03
M15_L11:
       cmp       byte ptr [rax+20],0
       je        short M15_L13
       jmp       near ptr M15_L04
M15_L12:
       call      qword ptr [7FF7A9EC7660]
       int       3
M15_L13:
       mov       rcx,rbp
       mov       rdx,rsi
       mov       r8,rax
       call      qword ptr [7FF7A9EC7678]
       mov       rbp,rax
       jmp       near ptr M15_L05
M15_L14:
       mov       rcx,rbp
       call      qword ptr [7FF7A9AD6AD8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M15_L00
; Total bytes of code 411
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M16_L01
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M16_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L01
M16_L00:
       test      rax,rax
       je        short M16_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L01
       test      rax,rax
       je        short M16_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L01
       test      rax,rax
       je        short M16_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L01
       test      rax,rax
       je        short M16_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M16_L00
M16_L01:
       mov       rax,rdx
       ret
M16_L02:
       jmp       qword ptr [7FF7A9EC45A0]
; Total bytes of code 88
```
```assembly
; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
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
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M17_L37
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M17_L37
M17_L00:
       mov       rdi,[rax+10]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       [rbx+20],rcx
       mov       [rbx+40],rcx
       mov       [rbx+48],rcx
       mov       byte ptr [rbx+38],0
       mov       word ptr [rbx+39],0
       mov       [rbx+28],ecx
       mov       [rbx+50],rcx
       mov       [rbx+58],rcx
       mov       [rbx+60],rcx
       mov       [rbx+68],cx
       mov       [rbx+6A],cl
       mov       byte ptr [rbx+3B],0
       mov       [rbx+10],rcx
       mov       [rbx+18],rcx
       mov       [rbx+8],rcx
       cmp       [rsi],sil
       add       rsi,18
       mov       [rsi+8],ecx
       mov       [rsi+0C],ecx
       mov       rbx,[rsi]
       mov       rcx,21363DC6EF8
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M17_L36
       cmp       dword ptr [rbx+8],0
       je        near ptr M17_L36
       mov       rcx,1D2CF001E10
       mov       rsi,[rcx]
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M17_L38
       mov       rcx,[rcx+240]
       mov       r15,[rcx+50]
       test      r15,r15
       je        near ptr M17_L38
M17_L01:
       mov       rax,[r15+10]
       test      rax,rax
       jne       near ptr M17_L16
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolThreadLocalArray[]
       mov       edx,1B
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       lea       rcx,[r15+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15,[rsi+8]
       mov       rcx,[r15+8]
       mov       [rbp-80],rcx
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       qword ptr [rbp-80],0
       je        near ptr M17_L07
       mov       rcx,[rbp-80]
       call      00007FF809262D60
       test      eax,eax
       jne       short M17_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FF7A979FDF8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M17_L02:
       mov       dword ptr [rbp-40],1
       mov       rcx,[r15+10]
       lea       r8,[rbp-48]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF7A985CFA8]; System.Runtime.CompilerServices.ConditionalWeakTable`2+Container[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindEntry(System.__Canon, System.Object ByRef)
       cmp       eax,0FFFFFFFF
       jne       near ptr M17_L08
       mov       r12,[r15+10]
       mov       ecx,[r12+28]
       mov       rax,[r12+18]
       cmp       ecx,[rax+8]
       jge       near ptr M17_L09
M17_L03:
       cmp       byte ptr [r12+2C],0
       jne       near ptr M17_L10
       mov       byte ptr [r12+2C],1
       mov       rcx,r13
       call      00007FF8091F1BC0
       test      eax,eax
       je        near ptr M17_L06
M17_L04:
       mov       r15d,eax
       and       r15d,7FFFFFFF
       mov       eax,[r12+28]
       mov       [rbp-4C],eax
       lea       ecx,[rax+1]
       mov       [r12+28],ecx
       mov       rcx,[r12+18]
       cmp       eax,[rcx+8]
       jae       near ptr M17_L11
       mov       edx,eax
       shl       rdx,4
       lea       r8,[rcx+rdx+10]
       mov       [r8],r15d
       mov       [rbp-88],r8
       mov       rcx,r13
       xor       edx,edx
       call      00007FF809225B60
       test      rax,rax
       je        near ptr M17_L12
M17_L05:
       mov       rcx,[rbp-88]
       mov       [rcx+8],rax
       mov       rcx,[r12+10]
       mov       eax,[rcx+8]
       dec       eax
       and       eax,r15d
       mov       rdx,[r12+18]
       mov       r15d,[rbp-4C]
       cmp       r15d,[rdx+8]
       jae       near ptr M17_L11
       mov       r8d,r15d
       shl       r8,4
       mov       r10,rcx
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       near ptr M17_L11
       mov       r10d,[r10+rax*4+10]
       mov       [rdx+r8+14],r10d
       mov       [rcx+rax*4+10],r15d
       mov       byte ptr [r12+2C],0
       jmp       near ptr M17_L13
M17_L06:
       mov       rcx,r13
       call      qword ptr [7FF7A97977F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M17_L04
M17_L07:
       xor       ecx,ecx
       call      qword ptr [7FF7A9DBF978]
       int       3
M17_L08:
       mov       ecx,36
       call      qword ptr [7FF7A9ECCA20]
       int       3
M17_L09:
       mov       rcx,r12
       call      qword ptr [7FF7A9ECF690]
       mov       r12,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M17_L03
M17_L10:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9ECF6A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A9946010]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M17_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M17_L12:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF7A9ECF6C0]
       jmp       near ptr M17_L05
M17_L13:
       mov       rcx,[rbp-80]
       call      00007FF809262C80
       test      eax,eax
       jne       near ptr M17_L39
M17_L14:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       lea       rcx,[rsi+18]
       mov       eax,1
       xchg      al,[rcx]
       movzx     eax,al
       test      eax,eax
       je        near ptr M17_L27
M17_L15:
       mov       rax,r13
M17_L16:
       xor       r15d,r15d
       mov       r13d,1
       cmp       [rax+8],r14d
       jbe       near ptr M17_L23
       mov       r15d,1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       [rbx+8],ecx
       jne       near ptr M17_L41
       mov       ecx,r14d
       shl       rcx,4
       lea       r12,[rax+rcx+10]
       mov       rax,[r12]
       mov       [rbp-78],rax
       mov       rcx,r12
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r12+8],ecx
       mov       r12,[rbp-78]
       test      r12,r12
       je        near ptr M17_L23
       mov       rcx,[rsi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M17_L46
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M17_L17
       mov       rcx,rsi
       mov       edx,r14d
       call      qword ptr [7FF7A9ECE250]
M17_L17:
       mov       r13,[rax+8]
       call      qword ptr [7FF7A9CDF288]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       mov       edx,[r13+8]
       mov       [rbp-6C],edx
       test      edx,edx
       jle       near ptr M17_L45
       mov       [rbp-70],edx
M17_L18:
       cmp       eax,edx
       jae       near ptr M17_L46
       mov       [rbp-5C],eax
       mov       ecx,eax
       mov       r10,[r13+rcx*8+10]
       mov       [rbp-90],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-60],r9d
       mov       rcx,r10
       call      00007FF809262D60
       test      eax,eax
       jne       short M17_L19
       mov       rcx,[rbp-90]
       call      qword ptr [7FF7A979FDF8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M17_L19:
       mov       rax,[rbp-90]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-64],r8d
       cmp       [rcx+8],r8d
       jbe       short M17_L21
       test      r8d,r8d
       je        near ptr M17_L30
M17_L20:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-64]
       inc       ecx
       mov       rax,[rbp-90]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-60],1
M17_L21:
       mov       rcx,rax
       call      00007FF809262C80
       test      eax,eax
       jne       near ptr M17_L42
M17_L22:
       cmp       dword ptr [rbp-60],0
       je        near ptr M17_L43
       mov       r13d,1
M17_L23:
       mov       rcx,1D2CF0003A0
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       je        near ptr M17_L36
       mov       rcx,rbx
       call      00007FF8091F1BC0
       test      eax,eax
       je        near ptr M17_L31
       mov       [rbp-68],eax
M17_L24:
       mov       edx,[rbx+8]
       mov       [rbp-3C],edx
       mov       rcx,rsi
       call      00007FF8091F1BC0
       test      eax,eax
       je        near ptr M17_L32
M17_L25:
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-68]
       mov       r9d,[rbp-3C]
       mov       edx,3
       call      qword ptr [7FF7A9ECC7C8]
       test      r13d,r15d
       jne       near ptr M17_L36
       mov       rcx,rbx
       call      qword ptr [7FF7A99DCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      00007FF8091F1BC0
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M17_L33
M17_L26:
       test      r15d,r15d
       jne       near ptr M17_L34
       mov       r14d,0FFFFFFFF
       mov       ecx,1
       jmp       near ptr M17_L35
M17_L27:
       mov       r15,1D2CF001F60
       mov       r12,[r15]
       test      r12,r12
       jne       short M17_L28
       mov       rcx,offset MT_System.Func<System.Object, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,1D2CF001F58
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Buffers.SharedArrayPool`1+<>c[[System.Byte, System.Private.CoreLib]].<InitializeTlsBucketsAndTrimming>b__11_0(System.Object)
       mov       [r12+18],rcx
       mov       rcx,r15
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M17_L28:
       mov       rcx,offset MT_System.Gen2GcCallback
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       xor       edx,edx
       call      00007FF8091FFF00
       test      rax,rax
       je        near ptr M17_L40
M17_L29:
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [r15+18],rcx
       jmp       near ptr M17_L15
M17_L30:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       near ptr M17_L20
M17_L31:
       mov       rcx,rbx
       call      qword ptr [7FF7A97977F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       [rbp-68],eax
       jmp       near ptr M17_L24
M17_L32:
       mov       rcx,rsi
       call      qword ptr [7FF7A97977F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M17_L25
M17_L33:
       mov       rcx,rsi
       call      qword ptr [7FF7A97977F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M17_L26
M17_L34:
       xor       ecx,ecx
M17_L35:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,ebx
       call      qword ptr [7FF7A9ECC7E0]
M17_L36:
       dec       dword ptr [rdi+18]
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
M17_L37:
       mov       ecx,9
       call      qword ptr [7FF7A9EC4198]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M17_L00
M17_L38:
       mov       ecx,0A
       call      qword ptr [7FF7A9EC4198]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M17_L01
M17_L39:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FF7A985CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M17_L14
M17_L40:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF7A9ECF6D8]
       jmp       near ptr M17_L29
M17_L41:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7A9ECC7B0]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF7A9504000
       call      qword ptr [7FF7A95CF228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF7A99460B8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M17_L42:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FF7A985CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M17_L22
M17_L43:
       mov       eax,[rbp-5C]
       inc       eax
       mov       ecx,eax
       mov       edx,[rbp-6C]
       cmp       edx,ecx
       jne       short M17_L44
       xor       ecx,ecx
M17_L44:
       mov       r8d,[rbp-70]
       dec       r8d
       mov       [rbp-70],r8d
       mov       eax,ecx
       jne       near ptr M17_L18
M17_L45:
       xor       r13d,r13d
       jmp       near ptr M17_L23
M17_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-40],0
       je        short M17_L48
       cmp       qword ptr [rbp-80],0
       jne       short M17_L47
       xor       ecx,ecx
       call      qword ptr [7FF7A9DBF978]
       int       3
M17_L47:
       mov       rcx,[rbp-80]
       call      00007FF809262C80
       test      eax,eax
       je        short M17_L48
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FF7A985CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M17_L48:
       nop
       add       rsp,38
       ret
; Total bytes of code 1862
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
       je        near ptr M19_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M19_L01
       test      rsi,rsi
       je        short M19_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M19_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M19_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF809259F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7A95C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7A95C5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M19_L00:
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
M19_L01:
       test      rsi,rsi
       je        short M19_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M19_L03
M19_L02:
       mov       rax,21363DC0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M19_L03:
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
M19_L04:
       call      qword ptr [7FF7A9EC4EA0]
       int       3
; Total bytes of code 244
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xorps     xmm4,xmm4
       movaps    [rsp+20],xmm4
       movaps    [rsp+30],xmm4
       mov       rbx,rcx
       call      qword ptr [7FF8127484E0]
       cmp       byte ptr [rax],0
       je        near ptr M20_L03
       call      qword ptr [7FF81274EBE8]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M20_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FF812748278]; CORINFO_HELP_ASSIGN_REF
M20_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M20_L01:
       call      qword ptr [7FF81274A688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M20_L00
       call      qword ptr [7FF8127484D8]
       cmp       byte ptr [rax],0
       je        short M20_L00
       xorps     xmm0,xmm0
       movups    [rsp+30],xmm0
       mov       [rsp+30],rdi
       mov       [rsp+38],rsi
       lea       rcx,[rsp+20]
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       lea       r8,[rsp+30]
       mov       r9d,2
       call      qword ptr [7FF8127502E8]
       lea       rcx,[rsp+20]
       call      qword ptr [7FF81274EC18]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FF812748278]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M20_L00
       cmp       [rsi+10],rbx
       je        short M20_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+9F],0
       jne       short M20_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF81274E4E0]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M20_L00
M20_L02:
       mov       rcx,[rsi+8]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M20_L00
M20_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M20_L04
       call      qword ptr [7FF81274A6A0]
       test      rax,rax
       je        near ptr M20_L00
M20_L04:
       call      qword ptr [7FF81274CE58]
       int       3
; Total bytes of code 284
```
```assembly
; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF81274E588]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF81274C548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       test      rax,rax
       cmove     rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       rax,[rcx+0B8]
       cmp       qword ptr [rax+20],0
       je        near ptr M22_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       near ptr M22_L07
       mov       rbx,[rcx+0B8]
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M22_L08
M22_L00:
       mov       [rbp-20],rsi
       xor       eax,eax
       mov       [rbp-14],eax
       test      rsi,rsi
       je        short M22_L02
       mov       rcx,rsi
       call      00007FF809262D60
       test      eax,eax
       jne       short M22_L01
       mov       rcx,rsi
       call      qword ptr [7FF7A979FDF8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M22_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M22_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M22_L03
       mov       rcx,7FF7A9F369D8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF7A9AD6AF0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M22_L04
M22_L02:
       xor       ecx,ecx
       call      qword ptr [7FF7A9DBF978]
       int       3
M22_L03:
       mov       rcx,7FF7A9F369D4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF7A9EC7660]
       int       3
M22_L04:
       mov       rcx,7FF7A9F369DC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FF809262C80
       test      eax,eax
       jne       near ptr M22_L10
M22_L05:
       mov       rcx,7FF7A9F369E0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF7A9F369E4
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M22_L06:
       call      qword ptr [7FF7A9EC7C30]
       int       3
M22_L07:
       mov       rcx,7FF7A9F369D0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF7A9EC7660]
       int       3
M22_L08:
       mov       rcx,rbx
       call      qword ptr [7FF7A99DCE28]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M22_L09
       call      qword ptr [7FF7A9DBFEA0]
       int       3
M22_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF8091FCC60
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M22_L00
M22_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF7A985CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M22_L05
       sub       rsp,28
       call      qword ptr [7FF7A9EC7C48]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M22_L12
       mov       rcx,7FF7A9F369DC
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M22_L11
       xor       ecx,ecx
       call      qword ptr [7FF7A9DBF978]
       int       3
M22_L11:
       mov       rcx,[rbp-20]
       call      00007FF809262C80
       test      eax,eax
       je        short M22_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF7A985CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M22_L12:
       mov       rcx,7FF7A9F369E0
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 535
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFFFEC1CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M23_L01
       cmp       [rax],ecx
       jle       short M23_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M23_L03
M23_L00:
       add       rsp,20
       pop       rbx
       ret
M23_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M23_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M23_L00
M23_L02:
       cmp       [rax+4],edx
       jle       short M23_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M23_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M23_L03
       jmp       short M23_L00
M23_L03:
       mov       ecx,ebx
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M24_L00
       ret
M24_L00:
       jmp       qword ptr [7FF7A95C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_Person_List()
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
       mov       rcx,[rbx+150]
       test      rcx,rcx
       je        near ptr M00_L36
       mov       [rbp-40],rcx
       mov       rcx,1D537801E08
       mov       r14,[rcx]
       cmp       byte ptr [r14+9F],0
       je        near ptr M00_L37
M00_L01:
       mov       rdx,[r14+18]
       test      rdx,rdx
       jne       near ptr M00_L09
       xor       esi,esi
       cmp       byte ptr [r14+9E],0
       je        near ptr M00_L06
       mov       rsi,[r14+8]
       test      rsi,rsi
       je        near ptr M00_L38
M00_L02:
       mov       rdi,[rsi+8]
       mov       rcx,1D537801968
       mov       r15,[rcx]
       test      r15,r15
       jne       short M00_L03
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF7A94ED110
       mov       [r15+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [r15+20],rcx
       mov       rcx,1D537801968
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M00_L03:
       cmp       [rdi],dil
       mov       r13,[rdi+8]
       mov       rcx,[r13+8]
       cmp       byte ptr [rdi+19],0
       jne       near ptr M00_L07
       mov       r11,7FF7A94F1040
       mov       rdx,215CC6C27E0
       call      qword ptr [r11]
       mov       r12d,eax
M00_L04:
       lea       r9,[rbp-48]
       mov       [rsp+20],r9
       mov       r9d,r12d
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       mov       r8,215CC6C27E0
       call      qword ptr [7FF7A99266A0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       jne       short M00_L05
       mov       r8,rsi
       mov       rdx,215CC6C27E0
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-48]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,r12d
       shl       r9,20
       or        r9,1
       mov       rdx,r13
       mov       rcx,rdi
       mov       r8,215CC6C27E0
       call      qword ptr [7FF7A992C558]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
M00_L05:
       mov       rcx,[rbp-48]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rax,[rcx+10]
       test      rax,rax
       jne       near ptr M00_L39
       mov       rsi,[rcx+8]
       test      rsi,rsi
       je        short M00_L06
       cmp       byte ptr [rsi+119],2
       jne       near ptr M00_L40
M00_L06:
       test      rsi,rsi
       jne       short M00_L08
       mov       rdx,[r14+20]
       mov       rcx,215CC6C27E0
       call      qword ptr [7FF7A9EA71C8]
       int       3
M00_L07:
       mov       rcx,215CC6C27E0
       mov       rax,[7FF7A94EA1C0]
       call      qword ptr [rax+18]
       mov       r12d,eax
       jmp       near ptr M00_L04
M00_L08:
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
M00_L09:
       mov       r14,rdx
       test      r14,r14
       je        short M00_L10
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
       cmp       [r14],rcx
       jne       near ptr M00_L41
M00_L10:
       mov       rsi,[r14+0B8]
       lea       rdx,[rbp-58]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9BF78E8]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       r15d,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M00_L42
       mov       rcx,[rcx+240]
       mov       rsi,[rcx+48]
       test      rsi,rsi
       je        near ptr M00_L42
M00_L11:
       mov       rax,[rsi+10]
       test      rax,rax
       jne       short M00_L12
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,215CC6C6E30
       mov       [rax+18],rcx
       xor       ecx,ecx
       mov       [rax+20],rcx
       mov       byte ptr [rax+28],1
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
M00_L12:
       mov       ecx,[rax+18]
       lea       edx,[rcx+1]
       mov       [rax+18],edx
       test      ecx,ecx
       je        near ptr M00_L18
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      r15d,r15d
       je        near ptr M00_L44
       mov       rcx,1D537801E10
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FF7A9C1B348]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
M00_L13:
       mov       [rbp-70],rax
       lea       rcx,[rsi+18]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       byte ptr [rsi+28],1
       mov       [rbp-148],rsi
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12d,[rbp-4C]
       mov       edx,r12d
       lea       rdi,[r13+70]
       lea       rsi,[rbp-58]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       ecx,9
       mov       eax,20
       test      r12b,8
       cmove     ecx,eax
       mov       [r13+3C],cl
       mov       ecx,edx
       and       ecx,7F0
       sar       ecx,4
       je        short M00_L17
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L14:
       mov       [r13+2C],eax
       test      dl,4
       jne       near ptr M00_L45
       mov       r15,215CC6C1718
M00_L15:
       mov       ecx,[r15+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       short M00_L16
       mov       dword ptr [r13+78],3E8
M00_L16:
       mov       [rbp-150],r13
       jmp       near ptr M00_L24
M00_L17:
       mov       eax,2
       jmp       short M00_L14
M00_L18:
       mov       rcx,[rax+8]
       mov       [rbp-148],rcx
       mov       r13,[rax+10]
       mov       rcx,[rbp-148]
       cmp       [rcx],cl
       mov       rcx,[rbp-148]
       add       rcx,18
       mov       rdx,[rcx]
       mov       edx,[rdx+8]
       sub       edx,[rcx+0C]
       cmp       edx,r15d
       jl        near ptr M00_L22
M00_L19:
       lea       rcx,[r13+8]
       mov       rdx,[rbp-148]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12d,[rbp-4C]
       mov       edx,r12d
       lea       rdi,[r13+70]
       lea       rsi,[rbp-58]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       mov       ecx,9
       mov       eax,20
       test      r12b,8
       cmove     ecx,eax
       mov       [r13+3C],cl
       mov       ecx,edx
       and       ecx,7F0
       sar       ecx,4
       je        short M00_L23
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L20:
       mov       [r13+2C],eax
       test      dl,4
       jne       near ptr M00_L43
       mov       rsi,215CC6C1718
M00_L21:
       mov       ecx,[rsi+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       near ptr M00_L16
       mov       dword ptr [r13+78],3E8
       jmp       near ptr M00_L16
M00_L22:
       mov       edx,r15d
       call      qword ptr [7FF7A9BF7978]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L19
M00_L23:
       mov       eax,2
       jmp       short M00_L20
M00_L24:
       cmp       byte ptr [r14+116],0
       jne       near ptr M00_L32
       mov       rcx,[r14+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M00_L30
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L30
       mov       rsi,[r14+0B8]
       mov       rcx,[rbp-40]
       cmp       [rsi],sil
       call      qword ptr [7FF7A97761D8]; System.Object.GetType()
       mov       r9,215CC6C27E0
       cmp       rax,r9
       je        near ptr M00_L30
       mov       r14,[rsi+10]
       test      r14,r14
       je        near ptr M00_L33
       mov       r9,[r14+0C0]
       cmp       r9,rax
       jne       near ptr M00_L33
M00_L25:
       cmp       byte ptr [r14+11A],0
       je        near ptr M00_L29
M00_L26:
       mov       rdx,[r14+0F8]
       test      rdx,rdx
       cmovne    r14,rdx
       mov       rdx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       cmp       [r14],rdx
       jne       near ptr M00_L34
       mov       rsi,[rbp-40]
       mov       rax,rsi
       test      rax,rax
       je        short M00_L27
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       je        short M00_L27
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
M00_L27:
       mov       [rbp-118],rax
       lea       r8,[rbp-118]
       mov       rcx,r14
       mov       rdx,r13
       mov       r9,rsi
       call      qword ptr [7FF7A9BF7A50]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       xor       ecx,ecx
       mov       [rbp-118],rcx
M00_L28:
       mov       r9,[rbp-148]
       cmp       [r9],r9b
       mov       rdx,[rbp-148]
       add       rdx,18
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-128],xmm0
       mov       r9d,[rdx+0C]
       mov       r8d,[rdx+8]
       sub       r9d,r8d
       mov       rdx,[rdx]
       lea       rcx,[rbp-128]
       call      qword ptr [7FF7A9BFF900]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rcx,[rbp-128]
       mov       eax,[rbp-120]
       mov       [rbp-140],rcx
       mov       [rbp-138],eax
       lea       rcx,[rbp-140]
       call      qword ptr [7FF7A9B26070]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rsi,rax
       jmp       near ptr M00_L35
M00_L29:
       mov       rcx,r14
       call      qword ptr [7FF7A9BFE040]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[r14+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+11A],1
       jmp       near ptr M00_L26
M00_L30:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-110],ymm0
       vmovdqu   ymmword ptr [rbp-0F0],ymm0
       vmovdqu   ymmword ptr [rbp-0D0],ymm0
       vmovdqu   ymmword ptr [rbp-0B0],ymm0
       vmovdqu   ymmword ptr [rbp-90],ymm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-110]
       mov       rdx,r14
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF7A9BFEFA0]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-110]
       mov       [rsp+20],rcx
       mov       rcx,[r14+158]
       mov       r9,[r14+0B8]
       lea       r8,[rbp-40]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9BFEFB8]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L31:
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9BFF8E8]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M00_L28
M00_L32:
       mov       rax,[r14+148]
       mov       rdx,r13
       mov       r8,[rbp-40]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M00_L31
M00_L33:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9d,101
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8d,1
       call      qword ptr [7FF7A99BCDE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r14,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L25
M00_L34:
       mov       rcx,r14
       mov       rdx,r13
       mov       r8,[rbp-40]
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L28
M00_L35:
       mov       rcx,r13
       mov       rdx,[rbp-148]
       call      qword ptr [7FF7A9BFF918]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       [rbp-130],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-130]
       mov       rdx,7FF7A9DCF4A8
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9D97318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L36:
       call      qword ptr [7FF7A9B2E880]
       mov       ecx,1C4D
       mov       rdx,7FF7A9874FD8
       call      qword ptr [7FF7A95AF228]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FF7A9874FD8
       call      qword ptr [7FF7A95AF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A95AD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FF7A9874FD8
       call      qword ptr [7FF7A95AF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A95AD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7A9EAF3D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7A9EA4618]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L37:
       mov       rcx,r14
       call      qword ptr [7FF7A99B75D0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L38:
       mov       rcx,r14
       call      qword ptr [7FF7A99BCDF8]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L39:
       mov       rcx,rax
       call      qword ptr [7FF7A9EA7720]
       int       3
M00_L40:
       mov       rcx,rsi
       call      qword ptr [7FF7A9AB6AD8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L06
M00_L41:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L42:
       mov       ecx,9
       call      qword ptr [7FF7A9EA4258]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rsi,rax
       jmp       near ptr M00_L11
M00_L43:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D54D800800
       mov       rsi,[rcx]
       jmp       near ptr M00_L21
M00_L44:
       mov       rax,215CC6C6E30
       jmp       near ptr M00_L13
M00_L45:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D54D800800
       mov       r15,[rcx]
       jmp       near ptr M00_L15
       sub       rsp,48
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-148]
       call      qword ptr [7FF7A9BFF918]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       nop
       add       rsp,48
       ret
; Total bytes of code 2268
```
```assembly
; System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7A99BD398]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M01_L00:
       mov       rcx,7FF7A9F48BFC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-20]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,7FF7A9F48BF8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A9EA7D08]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF7A9EAD278]
       mov       [rbp-20],rsi
       lea       rax,[M01_L00]
       add       rsp,28
       ret
; Total bytes of code 185
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,r8
       mov       ebx,r9d
       mov       rbp,[rdx+8]
       mov       rcx,[rdx+10]
       mov       eax,ebx
       imul      rax,[rdx+28]
       shr       rax,20
       inc       rax
       mov       edx,[rcx+8]
       mov       r8d,edx
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M02_L05
       mov       edx,eax
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       jne       short M02_L03
M02_L00:
       mov       rcx,7FF7A9EFEC3C
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       mov       rbx,[rsp+80]
       mov       [rbx],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,rbp
       mov       rdx,7FF7A9EFEB28
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rbp
       mov       rdx,[r14+8]
       mov       r11,r15
       mov       r8,rdi
       call      qword ptr [r15]
       test      eax,eax
       jne       short M02_L04
       mov       rcx,7FF7A9EFEC34
       call      CORINFO_HELP_COUNTPROFILE32
M02_L02:
       mov       rcx,7FF7A9EFEC38
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r14,[r14+18]
       test      r14,r14
       je        short M02_L00
M02_L03:
       cmp       ebx,[r14+20]
       jne       short M02_L02
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       jne       short M02_L01
       mov       rcx,rsi
       mov       rdx,7FF7A9F07A10
       call      qword ptr [7FF7A95AF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,7FF7A9EFEC30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[r14+10]
       mov       rcx,[rsp+80]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 305
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
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
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+28],r9
       mov       rbx,r8
       mov       esi,[rbp+40]
       movzx     r9d,r9b
       mov       rdx,[rbp+18]
       mov       rdi,[rdx+8]
       mov       r14d,[rbp+2C]
       test      r9d,r9d
       jne       short M03_L05
       cmp       byte ptr [rcx+19],0
       jne       short M03_L04
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+78]
       test      r11,r11
       je        short M03_L03
M03_L00:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
M03_L01:
       mov       r15d,eax
M03_L02:
       jmp       near ptr M03_L34
M03_L03:
       mov       rcx,rdx
       mov       rdx,7FF7A9F07920
       call      qword ptr [7FF7A95AF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M03_L00
M03_L04:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       short M03_L01
M03_L05:
       mov       rcx,7FF7A9F4ED08
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r15d,r14d
       jmp       short M03_L02
M03_L06:
       test      sil,sil
       je        short M03_L08
       mov       rcx,7FF7A9F4ED0C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-44],ecx
       jae       near ptr M03_L30
       mov       rcx,[rbp-60]
       mov       eax,[rbp-44]
       mov       r12,[rcx+rax*8+10]
       test      r12,r12
       je        near ptr M03_L29
       mov       rcx,r12
       call      00007FF809262D60
       test      eax,eax
       jne       short M03_L07
       mov       rcx,r12
       call      qword ptr [7FF7A983CDC8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M03_L07:
       mov       dword ptr [rbp-50],1
M03_L08:
       mov       rcx,[rbp+18]
       cmp       rcx,[r14+8]
       je        short M03_L11
       mov       rcx,[r14+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+18]
       cmp       rdi,[rcx+8]
       je        short M03_L10
       mov       rcx,7FF7A9F4ED10
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rdi,[rcx+8]
       cmp       byte ptr [r14+19],0
       jne       near ptr M03_L28
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        near ptr M03_L27
M03_L09:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       r15d,eax
M03_L10:
       mov       rcx,7FF7A9F4ED14
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L32
M03_L11:
       xor       esi,esi
       mov       r12,[r13]
       test      r12,r12
       jne       near ptr M03_L20
M03_L12:
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        near ptr M03_L24
M03_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rax,[r13]
       mov       [rbp-68],rax
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,[rbp-68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+20],r15d
       mov       rcx,r13
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       mov       eax,[rcx+8]
       cmp       [rbp-44],eax
       jae       near ptr M03_L30
       mov       eax,[rbp-44]
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M03_L31
       mov       [rcx],eax
       cmp       eax,[r14+10]
       jle       short M03_L14
       mov       rcx,7FF7A9F4ED30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       dword ptr [rbp-48],1
M03_L14:
       cmp       esi,64
       jbe       near ptr M03_L26
       mov       rcx,rdi
       mov       rdx,7FF7A9F4ED38
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FF7A95A6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M03_L25
       mov       rcx,7FF7A9F4EE40
       call      CORINFO_HELP_COUNTPROFILE32
       mov       dword ptr [rbp-4C],1
       jmp       near ptr M03_L36
M03_L15:
       mov       rcx,7FF7A9F4ED1C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[r12+10]
       mov       rcx,[rbp+48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L23
M03_L16:
       mov       rcx,rax
M03_L17:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        near ptr M03_L21
M03_L18:
       mov       rdx,[r12+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M03_L22
       mov       rcx,7FF7A9F4ED18
       call      CORINFO_HELP_COUNTPROFILE32
M03_L19:
       mov       rcx,7FF7A9F4ED28
       call      CORINFO_HELP_COUNTPROFILE32
       inc       esi
       mov       rcx,7FF7A9F4ED2C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r12,[r12+18]
       test      r12,r12
       je        near ptr M03_L12
M03_L20:
       cmp       r15d,[r12+20]
       jne       short M03_L19
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       jne       near ptr M03_L16
       mov       rdx,7FF7A9F081C0
       call      qword ptr [7FF7A95AF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L17
M03_L21:
       mov       rdx,7FF7A9F07A10
       call      qword ptr [7FF7A95AF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M03_L18
M03_L22:
       cmp       byte ptr [rbp+38],0
       je        near ptr M03_L15
       lea       rcx,[r12+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L23:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       jmp       near ptr M03_L35
M03_L24:
       mov       rdx,7FF7A9F39B40
       call      qword ptr [7FF7A95AF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M03_L13
M03_L25:
       mov       rcx,7FF7A9F4ED24
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L36
M03_L26:
       mov       rcx,7FF7A9F4ED20
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L36
M03_L27:
       mov       rdx,7FF7A9F07920
       call      qword ptr [7FF7A95AF4C8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M03_L09
M03_L28:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M03_L10
M03_L29:
       xor       ecx,ecx
       call      qword ptr [7FF7A9D9FA38]
       int       3
M03_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L31:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L32:
       cmp       dword ptr [rbp-50],0
       je        short M03_L33
       mov       rcx,7FF7A9F4EE44
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-44],ecx
       jae       near ptr M03_L40
       mov       rcx,[rbp-60]
       mov       eax,[rbp-44]
       mov       r12,[rcx+rax*8+10]
       test      r12,r12
       je        near ptr M03_L39
       mov       rcx,r12
       call      00007FF809262C80
       test      eax,eax
       jne       near ptr M03_L38
M03_L33:
       mov       rcx,7FF7A9F4EE48
       call      CORINFO_HELP_COUNTPROFILE32
       nop
M03_L34:
       mov       rax,[rbp+18]
       mov       rcx,[rax+18]
       mov       [rbp-60],rcx
       mov       r14,[rbp+10]
       cmp       [r14],r14d
       mov       rax,[rbp+18]
       mov       r8,[rax+10]
       mov       rax,[rbp+18]
       mov       r10d,r15d
       imul      r10,[rax+28]
       shr       r10,20
       inc       r10
       mov       r9d,[r8+8]
       mov       r11d,r9d
       imul      r10,r11
       shr       r10,20
       mov       eax,r10d
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rbp-44],edx
       cmp       r10d,r9d
       jae       near ptr M03_L40
       mov       ecx,r10d
       lea       r13,[r8+rcx*8+10]
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       [rbp-4C],ecx
       mov       [rbp-50],ecx
       jmp       near ptr M03_L06
M03_L35:
       call      M03_L41
       nop
       mov       rcx,7FF7A9F4EE54
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,[rbp-54]
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
M03_L36:
       call      M03_L41
       nop
       mov       ecx,[rbp-48]
       or        ecx,[rbp-4C]
       je        short M03_L37
       mov       rcx,7FF7A9F4EE4C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8d,[rbp-48]
       mov       r9d,[rbp-4C]
       call      qword ptr [7FF7A9CB4138]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
M03_L37:
       mov       rcx,7FF7A9F4EE50
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
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
M03_L38:
       mov       ecx,eax
       mov       rdx,r12
       call      qword ptr [7FF7A983CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M03_L33
M03_L39:
       xor       ecx,ecx
       call      qword ptr [7FF7A9D9FA38]
       int       3
M03_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L41:
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M03_L44
       mov       rcx,7FF7A9F4EE44
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-44],ecx
       jae       short M03_L42
       mov       rcx,[rbp-60]
       mov       eax,[rbp-44]
       mov       r12,[rcx+rax*8+10]
       test      r12,r12
       jne       short M03_L43
       xor       ecx,ecx
       call      qword ptr [7FF7A9D9FA38]
       int       3
M03_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L43:
       mov       rcx,r12
       call      00007FF809262C80
       test      eax,eax
       je        short M03_L44
       mov       ecx,eax
       mov       rdx,r12
       call      qword ptr [7FF7A983CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M03_L44:
       mov       rcx,7FF7A9F4EE48
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 1520
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rax,rdx
       mov       rbx,[rcx+40]
       cmp       byte ptr [rcx+9C],0
       setne     sil
       movzx     esi,sil
       movzx     edx,word ptr [rcx+90]
       cmp       edx,20
       jne       near ptr M04_L10
       and       esi,0FFFFFFF7
M04_L00:
       mov       edx,[rcx+84]
       cmp       edx,7F
       ja        near ptr M04_L12
       and       esi,0FFFFF80F
       test      edx,edx
       je        near ptr M04_L07
       xor       r8d,r8d
       cmp       edx,2
       cmovne    r8d,edx
M04_L01:
       shl       r8d,4
       or        esi,r8d
       mov       edi,[rcx+88]
       test      edi,edi
       jl        near ptr M04_L13
       mov       r8,[rcx+50]
       test      r8,r8
       je        near ptr M04_L14
M04_L02:
       mov       rcx,215CC6CFFA8
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],1
       jne       short M04_L03
       cmp       word ptr [r8+0C],0A
       je        short M04_L04
M04_L03:
       mov       rcx,215CC6C1718
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],2
       jne       short M04_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M04_L08
M04_L04:
       mov       rcx,215CC6C1718
       cmp       r8,rcx
       je        short M04_L05
       cmp       dword ptr [r8+8],2
       jne       short M04_L09
       cmp       dword ptr [r8+0C],0A000D
       jne       short M04_L09
M04_L05:
       and       esi,0FFFFFFFB
M04_L06:
       or        esi,2
       mov       [rax],rbx
       mov       [rax+8],edi
       mov       [rax+0C],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L07:
       mov       r8d,2
       jmp       near ptr M04_L01
M04_L08:
       mov       ecx,38A0
       mov       rdx,7FF7A99F3858
       call      qword ptr [7FF7A95AF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9EAED60]
       int       3
M04_L09:
       or        esi,4
       jmp       short M04_L06
M04_L10:
       cmp       edx,9
       je        short M04_L11
       mov       ecx,38A0
       mov       rdx,7FF7A99F3858
       call      qword ptr [7FF7A95AF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9EAED18]
       int       3
M04_L11:
       or        esi,8
       jmp       near ptr M04_L00
M04_L12:
       mov       ecx,38A0
       mov       rdx,7FF7A99F3858
       call      qword ptr [7FF7A95AF228]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FF7A9EAED30]
       int       3
M04_L13:
       mov       ecx,38A0
       mov       rdx,7FF7A99F3858
       call      qword ptr [7FF7A95AF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9EAED48]
       int       3
M04_L14:
       mov       r8,215CC6C1718
       mov       [rcx+50],r8
       jmp       near ptr M04_L02
; Total bytes of code 418
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       ebx,edx
       mov       rcx,1D537800C90
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       short M05_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M05_L02
M05_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M05_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M05_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M05_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M05_L03
M05_L01:
       mov       rax,r14
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
M05_L02:
       mov       ecx,0A
       call      qword ptr [7FF7A9EA4258]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L03:
       mov       rcx,r14
       call      qword ptr [7FF7A99BCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF7A99BCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF7A9EAC7E0]
       jmp       short M05_L01
M05_L04:
       mov       rax,[rsi+10]
       cmp       [rax+8],ebp
       jbe       near ptr M05_L13
       mov       ecx,ebp
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        near ptr M05_L12
       mov       r14,[rax+8]
       call      qword ptr [7FF7A9CBF138]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       ebx,eax
       sub       ebx,ecx
       xor       r15d,r15d
       jmp       short M05_L08
M05_L05:
       cmp       ebx,[r14+8]
       jae       near ptr M05_L18
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FF7A9ABD890]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M05_L06
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M05_L06:
       mov       rcx,r13
       call      qword ptr [7FF7A95A6820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M05_L09
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M05_L07
       xor       ebx,ebx
M05_L07:
       inc       r15d
M05_L08:
       cmp       [r14+8],r15d
       jg        short M05_L05
       jmp       short M05_L10
M05_L09:
       mov       r14,r12
       jmp       short M05_L11
M05_L10:
       xor       r14d,r14d
M05_L11:
       test      r14,r14
       je        short M05_L12
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       mov       rcx,r14
       call      qword ptr [7FF7A99BCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF7A99BCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF7A9EAC7E0]
       jmp       near ptr M05_L01
M05_L12:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M05_L15
M05_L13:
       test      ebx,ebx
       jne       short M05_L14
       mov       rax,215CC6C6E30
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
M05_L14:
       mov       ecx,ebx
       mov       rdx,215CC6C6EF8
       call      qword ptr [7FF7A983D920]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M05_L15:
       cmp       ebx,800
       jge       short M05_L16
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M05_L17
M05_L16:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FF7A9BF7A20]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M05_L17:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FF7A99BCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF7A99BCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF7A9EAC7E0]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF7A99BCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rsi+10]
       mov       edx,1
       mov       r8d,2
       cmp       [rcx+8],ebp
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rdi
       mov       edx,ebx
       mov       r8d,r15d
       call      qword ptr [7FF7A9EAC7F8]
       jmp       near ptr M05_L01
M05_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 712
```
```assembly
; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rbx,rcx
       mov       r8,[rbx]
       cmp       dword ptr [r8+8],0
       je        near ptr M06_L08
       mov       eax,[rbx+8]
       mov       ecx,[r8+8]
       mov       esi,[rbx+0C]
       sub       ecx,esi
       add       ecx,eax
       cmp       edx,ecx
       jle       near ptr M06_L09
       sub       esi,eax
       add       edx,esi
       cmp       edx,7FFFFFC7
       ja        near ptr M06_L10
       mov       ecx,[r8+8]
       add       ecx,ecx
       mov       eax,7FFFFFC7
       cmp       rcx,7FFFFFC7
       cmovl     rax,rcx
       cmp       edx,eax
       cmovl     edx,eax
       cmp       byte ptr [rbx+10],0
       je        near ptr M06_L11
       mov       rcx,1D537801E10
       mov       rcx,[rcx]
       call      qword ptr [7FF7A9C1B348]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rsi,rax
M06_L00:
       mov       rdi,[rbx]
       mov       ebp,[rbx+0C]
       mov       r14d,[rbx+8]
       sub       ebp,r14d
       je        near ptr M06_L03
       test      rdi,rdi
       je        near ptr M06_L12
       test      rsi,rsi
       je        near ptr M06_L13
       mov       r15d,[rdi+8]
       mov       rcx,offset MT_System.Byte[]
       cmp       [rdi],rcx
       jne       near ptr M06_L14
M06_L01:
       mov       r13,r15
       cmp       rdi,rsi
       je        short M06_L02
       mov       r13d,[rsi+8]
       mov       rcx,offset MT_System.Byte[]
       cmp       [rsi],rcx
       jne       near ptr M06_L16
M06_L02:
       test      r14d,r14d
       jl        near ptr M06_L18
       test      ebp,ebp
       jl        near ptr M06_L19
       mov       r8d,ebp
       mov       edx,r14d
       lea       rcx,[rdx+r8]
       cmp       rcx,r15
       ja        near ptr M06_L20
       cmp       r13,r8
       jb        near ptr M06_L20
       lea       rcx,[rsi+10]
       lea       rdx,[rdi+rdx+10]
       call      qword ptr [7FF7A95A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L03:
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+10],0
       je        near ptr M06_L07
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        near ptr M06_L07
       mov       rcx,1D537801E10
       mov       rsi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M06_L21
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        near ptr M06_L21
M06_L04:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M06_L22
M06_L05:
       xor       r14d,r14d
       mov       r15d,1
       mov       ecx,[rax+8]
       cmp       ecx,ebp
       jbe       short M06_L06
       mov       r14d,1
       mov       ecx,10
       shlx      ecx,ecx,ebp
       cmp       ebx,ecx
       jne       near ptr M06_L23
       mov       ecx,ebp
       shl       rcx,4
       lea       r13,[rax+rcx+10]
       mov       r12,[r13]
       mov       rcx,r13
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],ecx
       test      r12,r12
       jne       near ptr M06_L24
M06_L06:
       mov       rcx,1D537800C90
       mov       r13,[rcx]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M06_L36
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
       mov       rcx,1D537801E10
       mov       rcx,[rcx]
       call      qword ptr [7FF7A9C1B348]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,rbx
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M06_L07
M06_L09:
       mov       edx,esi
       sub       edx,eax
       mov       [rsp+20],edx
       mov       edx,eax
       mov       rcx,r8
       xor       r9d,r9d
       call      qword ptr [7FF7A9835FF8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       jmp       short M06_L07
M06_L10:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A9EAC6D8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L11:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       near ptr M06_L00
M06_L12:
       mov       ecx,257
       mov       rdx,7FF7A94E4000
       call      qword ptr [7FF7A95AF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9D9FA38]
       int       3
M06_L13:
       mov       ecx,25F
       mov       rdx,7FF7A94E4000
       call      qword ptr [7FF7A95AF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9D9FA38]
       int       3
M06_L14:
       mov       rcx,rdi
       call      00007FF80914ACC0
       mov       ecx,3003FFC
       bt        ecx,eax
       jb        short M06_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9EA50C8]
       mov       rsi,rax
       mov       ecx,257
       mov       rdx,7FF7A94E4000
       call      qword ptr [7FF7A95AF228]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7A99260B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L15:
       mov       rcx,[rdi]
       movzx     ecx,word ptr [rcx]
       imul      r15,rcx
       jmp       near ptr M06_L01
M06_L16:
       mov       rcx,rsi
       call      00007FF80914ACC0
       mov       ecx,3003FFC
       bt        ecx,eax
       jb        short M06_L17
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF7A9EA50C8]
       mov       rbp,rax
       mov       ecx,25F
       mov       rdx,7FF7A94E4000
       call      qword ptr [7FF7A95AF228]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,r14
       call      qword ptr [7FF7A99260B8]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M06_L17:
       mov       rcx,[rsi]
       movzx     ecx,word ptr [rcx]
       imul      r13,rcx
       jmp       near ptr M06_L02
M06_L18:
       mov       ecx,267
       mov       rdx,7FF7A94E4000
       call      qword ptr [7FF7A95AF228]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF7A9D9FA08]
       int       3
M06_L19:
       mov       ecx,28F
       mov       rdx,7FF7A94E4000
       call      qword ptr [7FF7A95AF228]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FF7A9D9FA08]
       int       3
M06_L20:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF7A9EA50E0]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF7A99241C8]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M06_L21:
       mov       ecx,0A
       call      qword ptr [7FF7A9EA4258]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M06_L04
M06_L22:
       mov       rcx,rsi
       call      qword ptr [7FF7A9BFF960]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M06_L05
M06_L23:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7A9EAC870]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF7A94E4000
       call      qword ptr [7FF7A95AF228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF7A99260B8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M06_L24:
       mov       rcx,[rsi+10]
       cmp       ebp,[rcx+8]
       jae       near ptr M06_L39
       mov       edx,ebp
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M06_L25
       mov       rcx,rsi
       mov       edx,ebp
       call      qword ptr [7FF7A9EAE700]
M06_L25:
       mov       r15,[rax+8]
       call      qword ptr [7FF7A9CBF138]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r13d,eax
       sub       r13d,ecx
       xor       eax,eax
       jmp       near ptr M06_L32
M06_L26:
       cmp       r13d,[r15+8]
       jae       near ptr M06_L39
       mov       ecx,r13d
       mov       rdx,[r15+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+3C],r8d
       mov       rcx,rdx
       call      qword ptr [7FF7A9ABD890]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+38],r8d
       cmp       [rcx+8],r8d
       jbe       short M06_L28
       test      r8d,r8d
       jne       short M06_L29
       xor       edx,edx
       mov       [rax+14],edx
M06_L27:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+38]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+3C],1
M06_L28:
       mov       rcx,rax
       call      qword ptr [7FF7A95A6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+3C],0
       je        short M06_L30
       jmp       short M06_L33
M06_L29:
       jmp       short M06_L27
M06_L30:
       inc       r13d
       cmp       [r15+8],r13d
       jne       short M06_L31
       xor       r13d,r13d
M06_L31:
       mov       eax,[rsp+40]
       inc       eax
M06_L32:
       mov       [rsp+40],eax
       cmp       [r15+8],eax
       jg        near ptr M06_L26
       jmp       short M06_L34
M06_L33:
       mov       r15d,1
       jmp       short M06_L35
M06_L34:
       xor       r15d,r15d
M06_L35:
       jmp       near ptr M06_L06
M06_L36:
       mov       rcx,rdi
       call      qword ptr [7FF7A99BCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       [rsp+44],ebx
       mov       rcx,rsi
       call      qword ptr [7FF7A99BCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r13
       mov       r8d,r12d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FF7A9EAC888]
       test      r15d,r14d
       jne       near ptr M06_L07
       mov       rcx,rdi
       call      qword ptr [7FF7A99BCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,rsi
       call      qword ptr [7FF7A99BCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r14d,r14d
       jne       short M06_L37
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M06_L38
M06_L37:
       mov       ecx,ebp
       xor       edx,edx
M06_L38:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r13
       mov       edx,edi
       mov       r8d,ebx
       call      qword ptr [7FF7A9EAC8A0]
       jmp       near ptr M06_L07
M06_L39:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1552
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
       je        short M07_L01
M07_L00:
       add       rsp,20
       pop       rbx
       ret
M07_L01:
       call      qword ptr [7FF7A95A5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M07_L00
; Total bytes of code 41
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L01
M08_L00:
       test      rax,rax
       je        short M08_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L01
       test      rax,rax
       je        short M08_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L01
       test      rax,rax
       je        short M08_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L01
       test      rax,rax
       je        short M08_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M08_L00
M08_L01:
       mov       rax,rdx
       ret
M08_L02:
       jmp       qword ptr [7FF7A9EA4660]
; Total bytes of code 78
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
M09_L00:
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E0
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqu   ymmword ptr [rsp+0C0],ymm4
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       rbp,r9
       cmp       byte ptr [rbx+116],0
       jne       near ptr M09_L08
       mov       rcx,[rbx+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M09_L06
       mov       r8,[rsi]
       test      r8,r8
       je        near ptr M09_L06
       mov       r14,[rbx+0B8]
       mov       rcx,r8
       cmp       [r14],r14b
       call      qword ptr [7FF7A97761D8]; System.Object.GetType()
       mov       r9,215CC6C27E0
       cmp       rax,r9
       je        near ptr M09_L06
       mov       rbx,[r14+10]
       test      rbx,rbx
       je        near ptr M09_L09
       mov       r9,[rbx+0C0]
       cmp       r9,rax
       jne       near ptr M09_L09
M09_L01:
       cmp       byte ptr [rbx+11A],0
       je        short M09_L05
M09_L02:
       mov       rdx,[rbx+0F8]
       test      rdx,rdx
       cmovne    rbx,rdx
       mov       rbp,[rsi]
       mov       rdx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       cmp       [rbx],rdx
       jne       near ptr M09_L10
       mov       rax,rbp
       test      rax,rax
       je        short M09_L03
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       je        short M09_L03
       mov       rdx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
M09_L03:
       mov       [rsp+38],rax
       lea       r8,[rsp+38]
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r9,rbp
       call      qword ptr [7FF7A9BF7A50]
M09_L04:
       nop
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M09_L05:
       mov       rcx,rbx
       call      qword ptr [7FF7A9BFE040]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[rbx+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+11A],1
       jmp       near ptr M09_L02
M09_L06:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+40],ymm0
       vmovdqu   ymmword ptr [rsp+60],ymm0
       vmovdqu   ymmword ptr [rsp+80],ymm0
       vmovdqu   ymmword ptr [rsp+0A0],ymm0
       vmovdqu   ymmword ptr [rsp+0C0],ymm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rsp+40]
       mov       rdx,rbx
       mov       r8,rbp
       xor       r9d,r9d
       call      qword ptr [7FF7A9BFEFA0]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rsp+40]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+158]
       mov       r9,[rbx+0B8]
       mov       rdx,rdi
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9BFEFB8]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M09_L07:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9BFF8E8]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M09_L04
M09_L08:
       mov       rax,[rbx+148]
       mov       r8,[rsi]
       mov       rdx,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M09_L07
M09_L09:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9d,101
       mov       rcx,r14
       mov       rdx,rax
       mov       r8d,1
       call      qword ptr [7FF7A99BCDE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbx,rax
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M09_L01
M09_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rbp
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M09_L04
; Total bytes of code 565
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       sub       rsp,28
       test      rdx,rdx
       je        short M10_L01
       mov       r8d,r8d
       mov       eax,r9d
       add       rax,r8
       mov       r10d,[rdx+8]
       cmp       rax,r10
       ja        short M10_L02
       add       rdx,10
       add       rdx,r8
       mov       [rcx],rdx
       mov       [rcx+8],r9d
M10_L00:
       add       rsp,28
       ret
M10_L01:
       or        r8d,r9d
       jne       short M10_L02
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       jmp       short M10_L00
M10_L02:
       call      qword ptr [7FF7A977F228]
       int       3
; Total bytes of code 69
```
```assembly
; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-40],rax
       mov       r8,1D5378013D8
       mov       rbx,[r8]
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       r8d,1
       test      edi,edi
       cmove     rsi,r8
       mov       [rbp-38],rsi
       test      rsi,rsi
       je        near ptr M11_L04
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FF7A977CD98]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       mov       r9d,eax
       sub       r9d,esi
       mov       r14d,r9d
       add       r14d,[rbp-48]
       cmp       r9d,edi
       jne       near ptr M11_L05
M11_L00:
       test      r14d,r14d
       je        near ptr M11_L02
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FF809259F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       [rbp-40],rcx
       mov       r13,[rbp-40]
       test      r13,r13
       je        near ptr M11_L06
       mov       ecx,edi
       or        ecx,r14d
       jl        near ptr M11_L07
       lea       rcx,[rbp-58]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-60]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       mov       edx,edi
       mov       r8,r13
       mov       r9d,r14d
       call      qword ptr [7FF7A977CDC8]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
       mov       ecx,[rbp-58]
       sub       ecx,esi
       mov       rdx,[rbp-60]
       sub       rdx,r13
       mov       r8,rdx
       shr       r8,3F
       add       rdx,r8
       sar       rdx,1
       cmp       ecx,edi
       jne       short M11_L08
M11_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       jmp       short M11_L03
M11_L02:
       mov       r15,215CC6C0008
M11_L03:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       near ptr M11_L09
M11_L04:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FF7A9B2DFE0]
       int       3
M11_L05:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FF7A9B2DFB0]
       add       r14d,eax
       jns       near ptr M11_L00
       call      qword ptr [7FF7A9B2DFF8]
       int       3
M11_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FF7A9B2DFE0]
       int       3
M11_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FF7A9B25E90]
       int       3
M11_L08:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,r13
       call      qword ptr [7FF7A9B2E238]
       jmp       near ptr M11_L01
M11_L09:
       mov       rax,r15
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,48
       call      qword ptr [7FF7A9D9E478]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 442
```
```assembly
; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       cmp       qword ptr [rbx+80],0
       jne       near ptr M12_L08
       xor       esi,esi
       mov       rcx,[rbx+0C0]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdi,rax
       test      rdi,rdi
       je        short M12_L02
M12_L00:
       mov       rdx,[rbx+0B8]
       mov       rcx,rdi
       call      qword ptr [7FF81274F030]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        short M12_L01
       mov       rcx,[rax+80]
       test      rcx,rcx
       jne       short M12_L04
M12_L01:
       mov       rcx,rdi
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       call      qword ptr [r11]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M12_L00
M12_L02:
       mov       rcx,[rbx+0C0]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdi,rax
       xor       ebp,ebp
       cmp       [rdi+8],ebp
       jg        short M12_L05
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
       mov       rsi,rax
       jmp       short M12_L02
M12_L05:
       mov       r14,[rdi+rbp*8+10]
       mov       rdx,[rbx+0B8]
       mov       rcx,r14
       call      qword ptr [7FF81274F030]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
       mov       r15,rax
       test      r15,r15
       je        short M12_L07
       mov       rcx,[r15+80]
       test      rcx,rcx
       je        short M12_L07
       test      rsi,rsi
       je        short M12_L06
       mov       rcx,[rsi+0C0]
       mov       rdx,r14
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M12_L06
       mov       rdx,[rsi+0C0]
       mov       rcx,r14
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       test      eax,eax
       jne       short M12_L07
       jmp       short M12_L08
M12_L06:
       mov       rsi,r15
M12_L07:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        short M12_L05
       jmp       near ptr M12_L03
M12_L08:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 292
```
```assembly
; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rbp,r8
       mov       edi,r9d
       lea       rcx,[rbx+68]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rsi+0D0]
       lea       rcx,[rbx+60]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+60]
       mov       rcx,[rcx+0C8]
       mov       [rbx+90],rcx
       mov       [rbx+4E],dil
       movzx     edi,byte ptr [rsp+70]
       mov       [rbx+4F],dil
       mov       rdi,[rsi+0B8]
       cmp       dword ptr [rdi+8C],0
       jne       short M13_L01
M13_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M13_L01:
       mov       rcx,[rdi+38]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       dword ptr [rdi+8C],2
       jne       short M13_L00
       test      rbp,rbp
       je        short M13_L00
       mov       rcx,[rsi+0C0]
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        short M13_L00
       mov       rcx,[rbx+20]
       mov       rdx,rbp
       mov       rax,[rcx]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 196
```
```assembly
; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-48],xmm4
       xor       eax,eax
       mov       [rbp-38],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       r14,r9
       mov       r15d,[rbx+28]
       and       r15d,7FFFFFFF
       cmp       r15d,[r14+88]
       jge       near ptr M14_L20
       cmp       byte ptr [rsi+17],0
       jne       short M14_L00
       cmp       qword ptr [rdi],0
       je        near ptr M14_L21
M14_L00:
       cmp       byte ptr [rsi+10],2
       jne       near ptr M14_L10
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+90],0
       jne       near ptr M14_L22
M14_L01:
       mov       r8,[rdi]
       mov       rdx,offset MT_System.Text.Json.Serialization.Converters.StringConverter
       cmp       [rsi],rdx
       jne       near ptr M14_L26
       test      r8,r8
       je        near ptr M14_L07
       lea       r14,[r8+0C]
       mov       edi,[r8+8]
       cmp       edi,9EF21AA
       jg        near ptr M14_L23
       lea       rdx,[rbx+70]
       mov       rdx,[rdx]
       test      edi,edi
       je        short M14_L02
       mov       [rbp-38],r14
       mov       r8,r14
       mov       rax,1D537801400
       test      rdx,rdx
       cmove     rdx,[rax]
       mov       [rbp-50],rdx
       mov       rcx,rdx
       mov       rdx,r8
       mov       r8d,edi
       mov       rax,[rbp-50]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rcx,[rbp+30]
       jmp       short M14_L03
M14_L02:
       mov       eax,0FFFFFFFF
M14_L03:
       xor       edx,edx
       mov       [rbp-38],rdx
       cmp       eax,0FFFFFFFF
       jne       short M14_L05
       test      byte ptr [rbx+7C],2
       je        near ptr M14_L24
M14_L04:
       mov       rcx,[rbp+30]
       test      byte ptr [rbx+7C],1
       jne       near ptr M14_L25
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FF7A9BFF3C0]; System.Text.Json.Utf8JsonWriter.WriteStringMinimized(System.ReadOnlySpan`1<Char>)
       jmp       short M14_L06
M14_L05:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FF7A9D2F2B8]; System.Text.Json.Utf8JsonWriter.WriteStringEscapeValue(System.ReadOnlySpan`1<Char>, Int32)
M14_L06:
       or        dword ptr [rbx+28],80000000
       mov       byte ptr [rbx+3A],7
       jmp       short M14_L08
M14_L07:
       mov       rcx,rbx
       call      qword ptr [7FF7A9BFF5D0]
M14_L08:
       mov       ecx,[rbx+28]
       and       ecx,7FFFFFFF
       cmp       r15d,ecx
       jne       near ptr M14_L27
M14_L09:
       mov       eax,1
       jmp       near ptr M14_L34
M14_L10:
       mov       rcx,[rbp+30]
       cmp       dword ptr [rcx+44],0
       setne     r15b
       movzx     r15d,r15b
       cmp       qword ptr [rdi],0
       je        short M14_L16
       cmp       byte ptr [rcx+8E],1
       je        short M14_L16
       cmp       dword ptr [rcx+40],0
       jne       short M14_L11
       mov       r8,[rcx+68]
       jmp       short M14_L13
M14_L11:
       mov       rax,[rcx+60]
       mov       r13,[rax+88]
       cmp       byte ptr [r13+119],2
       jne       near ptr M14_L28
M14_L12:
       mov       r8,r13
       mov       rcx,[rbp+30]
M14_L13:
       cmp       byte ptr [rsi+12],0
       jne       near ptr M14_L29
       cmp       qword ptr [r8+0A0],0
       jne       near ptr M14_L29
       xor       r13d,r13d
M14_L14:
       test      r15d,r15d
       jne       short M14_L15
       cmp       dword ptr [r14+8C],0
       jne       near ptr M14_L30
M14_L15:
       mov       rcx,[rbp+30]
       test      r13,r13
       jne       near ptr M14_L31
M14_L16:
       call      qword ptr [7FF7A9BFEFE8]; System.Text.Json.WriteStack.Push()
       mov       r8,[rdi]
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SmallObjectWithParameterizedConstructorConverter<DotNetTips.Spargine.Tester.Models.RefTypes.Address, System.String, System.Object, System.Object, System.Object>
       cmp       [rsi],rcx
       jne       short M14_L19
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FF7A9AE18B8]; System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[[System.__Canon, System.Private.CoreLib]].OnTryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       mov       r15d,eax
M14_L17:
       mov       rcx,[rbp+30]
       mov       edx,r15d
       call      qword ptr [7FF7A9BFF420]; System.Text.Json.WriteStack.Pop(Boolean)
       test      r15d,r15d
       je        short M14_L18
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+8F],0
       jne       near ptr M14_L32
M14_L18:
       mov       eax,r15d
       jmp       near ptr M14_L34
M14_L19:
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       mov       r15d,eax
       jmp       short M14_L17
M14_L20:
       mov       ecx,[r14+88]
       call      qword ptr [7FF7A9BFF5A0]
       int       3
M14_L21:
       mov       rcx,rbx
       call      qword ptr [7FF7A9BFF5D0]
       jmp       near ptr M14_L09
M14_L22:
       cmp       byte ptr [rsi+1A],0
       je        near ptr M14_L01
       mov       rdi,[rdi]
       add       rcx,90
       call      qword ptr [7FF7A9B25F68]; System.Nullable`1[[System.Text.Json.Serialization.JsonNumberHandling, System.Text.Json]].get_Value()
       mov       r9d,eax
       mov       r8,rdi
       mov       rdx,rbx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       jmp       near ptr M14_L08
M14_L23:
       mov       ecx,edi
       call      qword ptr [7FF7A9EAE100]
       int       3
M14_L24:
       mov       rcx,rbx
       call      qword ptr [7FF7A9EAE118]
       test      eax,eax
       jne       near ptr M14_L04
       mov       rcx,rbx
       call      qword ptr [7FF7A9EAE130]
       jmp       near ptr M14_L04
M14_L25:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FF7A9EAE148]
       jmp       near ptr M14_L06
M14_L26:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+28]
       jmp       near ptr M14_L08
M14_L27:
       mov       rcx,rsi
       call      qword ptr [7FF7A9BFF540]
       int       3
M14_L28:
       mov       rcx,r13
       call      qword ptr [7FF7A9AB6AD8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M14_L12
M14_L29:
       mov       [rsp+20],rcx
       mov       rdx,[rdi]
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FF7A9EAE088]
       mov       r13,rax
       mov       rcx,[rbp+30]
       jmp       near ptr M14_L14
M14_L30:
       mov       [rsp+20],r13
       mov       [rsp+28],rcx
       mov       r8,[rdi]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FF7A9EAE0A0]
       test      eax,eax
       je        near ptr M14_L15
       jmp       near ptr M14_L09
M14_L31:
       mov       [rsp+20],rcx
       mov       r8,[rdi]
       mov       rcx,r13
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+8]
       mov       r15d,eax
       mov       rcx,[rbp+30]
       lea       rax,[rcx+50]
       xor       edx,edx
       mov       r8d,2
       test      r15d,r15d
       cmove     edx,r8d
       mov       [rax+3E],dl
       test      r15d,r15d
       je        near ptr M14_L18
       cmp       byte ptr [rcx+8F],0
       je        near ptr M14_L18
       mov       rax,[rcx+20]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M14_L33
M14_L32:
       mov       rax,[rcx+20]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M14_L33:
       mov       rcx,[rbp+30]
       mov       byte ptr [rcx+8F],0
       jmp       near ptr M14_L18
M14_L34:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+4F],0
       jne       short M14_L35
       call      qword ptr [7FF7A9EAEE08]
M14_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.InvalidOperationException
       call      qword ptr [7FF7A95A6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M14_L37
       mov       rdx,rbx
       mov       rcx,offset MT_System.Text.Json.JsonException
       call      qword ptr [7FF7A95A6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M14_L36
       mov       rcx,rsi
       call      qword ptr [7FF7A9EAEE20]
       test      rax,rax
       jne       near ptr M14_L39
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FF7A9EAEE38]
       jmp       near ptr M14_L39
M14_L36:
       mov       rdx,rbx
       mov       rcx,offset MT_System.NotSupportedException
       call      qword ptr [7FF7A95A6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M14_L39
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,215CC6CF168
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9EAEE68]
       test      eax,eax
       jne       short M14_L39
       jmp       short M14_L38
M14_L37:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       rdx,215CC6CF118
       call      qword ptr [7FF7A95AC318]; System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M14_L39
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FF7A9EAEE50]
       jmp       short M14_L39
M14_L38:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FF7A9EAEE80]
M14_L39:
       call      CORINFO_HELP_RETHROW
       int       3
; Total bytes of code 1292
```
```assembly
; System.Text.Json.Utf8JsonWriter.Flush()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+10]
       test      rsi,rsi
       jne       short M15_L00
       cmp       qword ptr [rbx+8],0
       je        short M15_L03
M15_L00:
       xor       ecx,ecx
       mov       [rbx+40],rcx
       mov       [rbx+48],rcx
       test      rsi,rsi
       jne       short M15_L04
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M15_L02
       mov       rcx,[rbx+8]
       mov       r11,offset MT_System.Text.Json.PooledByteBufferWriter
       cmp       [rcx],r11
       jne       near ptr M15_L06
       add       rcx,18
       add       [rcx+0C],edx
M15_L01:
       movsxd    rcx,dword ptr [rbx+34]
       add       [rbx+20],rcx
       xor       ecx,ecx
       mov       [rbx+34],ecx
M15_L02:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M15_L03:
       call      qword ptr [7FF7A9EAEE98]
       int       3
M15_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M15_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9F749F8]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9EAEEC8]
       lea       rdx,[rsp+28]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+38]
       mov       rcx,[rbx+18]
       movsxd    rcx,dword ptr [rcx+10]
       add       [rbx+20],rcx
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9EAEEE0]
M15_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M15_L02
M15_L06:
       mov       r11,7FF7A94F1038
       call      qword ptr [r11]
       jmp       near ptr M15_L01
; Total bytes of code 232
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+68],r9d
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       xor       ebp,ebp
       cmp       byte ptr [rbx+9E],0
       jne       short M16_L02
       cmp       byte ptr [rsp+70],0
       jne       short M16_L01
       mov       rcx,7FF7A9EFE688
       call      CORINFO_HELP_COUNTPROFILE32
M16_L00:
       test      rbp,rbp
       jne       near ptr M16_L08
       cmp       byte ptr [rsp+69],0
       je        near ptr M16_L07
       mov       rcx,7FF7A9EFE67C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FF7A9EA71C8]
       int       3
M16_L01:
       mov       rcx,7FF7A9EFE678
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF7A99BD398]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbp,rax
       jmp       short M16_L00
M16_L02:
       mov       rbp,[rbx+8]
       test      rbp,rbp
       je        near ptr M16_L09
M16_L03:
       cmp       [rbp],bpl
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF7A99BD320]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       cmp       byte ptr [rsp+78],0
       jne       near ptr M16_L11
M16_L04:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       near ptr M16_L12
       mov       rbp,[rax+8]
M16_L05:
       test      dil,dil
       je        near ptr M16_L00
       test      rbp,rbp
       jne       short M16_L06
       mov       rcx,7FF7A9EFE674
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M16_L00
M16_L06:
       mov       rcx,7FF7A9EFE670
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       byte ptr [rbp+119],2
       je        near ptr M16_L00
       jmp       near ptr M16_L14
M16_L07:
       mov       rcx,7FF7A9EFE684
       call      CORINFO_HELP_COUNTPROFILE32
M16_L08:
       mov       rcx,7FF7A9EFE680
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M16_L09:
       mov       rcx,rbx
       call      qword ptr [7FF7A99BCE28]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rbp,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M16_L10
       call      qword ptr [7FF7A9D9FEE8]
       int       3
M16_L10:
       mov       rdx,rbp
       xor       r8d,r8d
       call      00007FF8091FCC60
       test      rax,rax
       cmove     rax,rbp
       mov       rbp,rax
       jmp       near ptr M16_L03
M16_L11:
       cmp       byte ptr [rax+20],0
       je        short M16_L13
       jmp       near ptr M16_L04
M16_L12:
       call      qword ptr [7FF7A9EA7720]
       int       3
M16_L13:
       mov       rcx,rbp
       mov       rdx,rsi
       mov       r8,rax
       call      qword ptr [7FF7A9EA7738]
       mov       rbp,rax
       jmp       near ptr M16_L05
M16_L14:
       mov       rcx,rbp
       call      qword ptr [7FF7A9AB6AD8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M16_L00
; Total bytes of code 411
```
```assembly
; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M17_L05
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M17_L05
M17_L00:
       mov       rdi,[rax+10]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       [rbx+20],rcx
       mov       [rbx+40],rcx
       mov       [rbx+48],rcx
       mov       byte ptr [rbx+38],0
       mov       word ptr [rbx+39],0
       mov       [rbx+28],ecx
       mov       [rbx+50],rcx
       mov       [rbx+58],rcx
       mov       [rbx+60],rcx
       mov       [rbx+68],cx
       mov       [rbx+6A],cl
       mov       byte ptr [rbx+3B],0
       mov       [rbx+10],rcx
       mov       [rbx+18],rcx
       mov       [rbx+8],rcx
       cmp       [rsi],sil
       add       rsi,18
       mov       [rsi+8],ecx
       mov       [rsi+0C],ecx
       mov       rbx,[rsi]
       mov       rcx,215CC6C6E30
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M17_L04
       mov       esi,[rbx+8]
       test      esi,esi
       je        near ptr M17_L04
       mov       rcx,1D537801E10
       mov       rbp,[rcx]
       lea       ecx,[rsi-1]
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M17_L06
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        near ptr M17_L06
M17_L01:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M17_L07
M17_L02:
       xor       r15d,r15d
       mov       r13d,1
       mov       ecx,[rax+8]
       cmp       ecx,r14d
       jbe       short M17_L03
       mov       r15d,1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       esi,ecx
       jne       near ptr M17_L08
       mov       ecx,r14d
       shl       rcx,4
       lea       r12,[rax+rcx+10]
       mov       rax,[r12]
       mov       [rsp+38],rax
       mov       rcx,r12
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r12+8],ecx
       mov       r12,[rsp+38]
       test      r12,r12
       jne       near ptr M17_L09
M17_L03:
       mov       rcx,1D537800C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       jne       near ptr M17_L21
M17_L04:
       dec       dword ptr [rdi+18]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M17_L05:
       mov       ecx,9
       call      qword ptr [7FF7A9EA4258]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M17_L00
M17_L06:
       mov       ecx,0A
       call      qword ptr [7FF7A9EA4258]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M17_L01
M17_L07:
       mov       rcx,rbp
       call      qword ptr [7FF7A9BFF960]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M17_L02
M17_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9EAC870]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FF7A94E4000
       call      qword ptr [7FF7A95AF228]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7A99260B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M17_L09:
       mov       rcx,[rbp+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M17_L24
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M17_L10
       mov       rcx,rbp
       mov       edx,r14d
       call      qword ptr [7FF7A9EAE700]
M17_L10:
       mov       r13,[rax+8]
       call      qword ptr [7FF7A9CBF138]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M17_L17
M17_L11:
       cmp       eax,[r13+8]
       jae       near ptr M17_L24
       mov       [rsp+4C],eax
       mov       ecx,eax
       mov       r8,[r13+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rsp+44],r10d
       mov       rcx,r8
       call      qword ptr [7FF7A9ABD890]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+40],r8d
       cmp       [rcx+8],r8d
       jbe       short M17_L13
       test      r8d,r8d
       jne       short M17_L14
       xor       edx,edx
       mov       [rax+14],edx
M17_L12:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+40]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+44],1
M17_L13:
       mov       rcx,rax
       call      qword ptr [7FF7A95A6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+44],0
       je        short M17_L15
       jmp       short M17_L18
M17_L14:
       jmp       short M17_L12
M17_L15:
       mov       eax,[rsp+4C]
       inc       eax
       mov       ecx,eax
       cmp       [r13+8],ecx
       jne       short M17_L16
       xor       ecx,ecx
M17_L16:
       mov       edx,[rsp+48]
       inc       edx
       mov       eax,ecx
M17_L17:
       mov       [rsp+48],edx
       cmp       [r13+8],edx
       jg        near ptr M17_L11
       jmp       short M17_L19
M17_L18:
       mov       r13d,1
       jmp       short M17_L20
M17_L19:
       xor       r13d,r13d
M17_L20:
       jmp       near ptr M17_L03
M17_L21:
       mov       rcx,rbx
       call      qword ptr [7FF7A99BCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+54],eax
       mov       [rsp+50],esi
       mov       rcx,rbp
       call      qword ptr [7FF7A99BCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rsp+54]
       mov       r9d,[rsp+50]
       mov       edx,3
       call      qword ptr [7FF7A9EAC888]
       test      r13d,r15d
       jne       near ptr M17_L04
       mov       rcx,rbx
       call      qword ptr [7FF7A99BCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rbp
       call      qword ptr [7FF7A99BCF78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r15d,r15d
       jne       short M17_L22
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M17_L23
M17_L22:
       mov       ecx,r14d
       xor       edx,edx
M17_L23:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,ebx
       mov       r8d,esi
       call      qword ptr [7FF7A9EAC8A0]
       jmp       near ptr M17_L04
M17_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 952
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
       je        near ptr M19_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M19_L01
       test      rsi,rsi
       je        short M19_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M19_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M19_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF809259F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7A95A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7A95A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M19_L00:
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
M19_L01:
       test      rsi,rsi
       je        short M19_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M19_L03
M19_L02:
       mov       rax,215CC6C0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M19_L03:
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
M19_L04:
       call      qword ptr [7FF7A9EA4F60]
       int       3
; Total bytes of code 244
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xorps     xmm4,xmm4
       movaps    [rsp+20],xmm4
       movaps    [rsp+30],xmm4
       mov       rbx,rcx
       call      qword ptr [7FF8127484E0]
       cmp       byte ptr [rax],0
       je        near ptr M20_L03
       call      qword ptr [7FF81274EBE8]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M20_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FF812748278]; CORINFO_HELP_ASSIGN_REF
M20_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M20_L01:
       call      qword ptr [7FF81274A688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M20_L00
       call      qword ptr [7FF8127484D8]
       cmp       byte ptr [rax],0
       je        short M20_L00
       xorps     xmm0,xmm0
       movups    [rsp+30],xmm0
       mov       [rsp+30],rdi
       mov       [rsp+38],rsi
       lea       rcx,[rsp+20]
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       lea       r8,[rsp+30]
       mov       r9d,2
       call      qword ptr [7FF8127502E8]
       lea       rcx,[rsp+20]
       call      qword ptr [7FF81274EC18]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FF812748278]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M20_L00
       cmp       [rsi+10],rbx
       je        short M20_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+9F],0
       jne       short M20_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF81274E4E0]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M20_L00
M20_L02:
       mov       rcx,[rsi+8]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M20_L00
M20_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M20_L04
       call      qword ptr [7FF81274A6A0]
       test      rax,rax
       je        near ptr M20_L00
M20_L04:
       call      qword ptr [7FF81274CE58]
       int       3
; Total bytes of code 284
```
```assembly
; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF81274E588]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF81274C548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       test      rax,rax
       cmove     rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       rax,[rcx+0B8]
       cmp       qword ptr [rax+20],0
       je        near ptr M22_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       near ptr M22_L07
       mov       rbx,[rcx+0B8]
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M22_L08
M22_L00:
       mov       [rbp-20],rsi
       xor       eax,eax
       mov       [rbp-14],eax
       test      rsi,rsi
       je        short M22_L02
       mov       rcx,rsi
       call      00007FF809262D60
       test      eax,eax
       jne       short M22_L01
       mov       rcx,rsi
       call      qword ptr [7FF7A983CDC8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M22_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M22_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M22_L03
       mov       rcx,7FF7A9F169D8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF7A9AB6AF0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M22_L04
M22_L02:
       xor       ecx,ecx
       call      qword ptr [7FF7A9D9FA38]
       int       3
M22_L03:
       mov       rcx,7FF7A9F169D4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF7A9EA7720]
       int       3
M22_L04:
       mov       rcx,7FF7A9F169DC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FF809262C80
       test      eax,eax
       jne       near ptr M22_L10
M22_L05:
       mov       rcx,7FF7A9F169E0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF7A9F169E4
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M22_L06:
       call      qword ptr [7FF7A9EA7CF0]
       int       3
M22_L07:
       mov       rcx,7FF7A9F169D0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF7A9EA7720]
       int       3
M22_L08:
       mov       rcx,rbx
       call      qword ptr [7FF7A99BCE28]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M22_L09
       call      qword ptr [7FF7A9D9FEE8]
       int       3
M22_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF8091FCC60
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M22_L00
M22_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF7A983CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M22_L05
       sub       rsp,28
       call      qword ptr [7FF7A9EA7D08]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M22_L12
       mov       rcx,7FF7A9F169DC
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M22_L11
       xor       ecx,ecx
       call      qword ptr [7FF7A9D9FA38]
       int       3
M22_L11:
       mov       rcx,[rbp-20]
       call      00007FF809262C80
       test      eax,eax
       je        short M22_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF7A983CEE8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M22_L12:
       mov       rcx,7FF7A9F169E0
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 535
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M23_L01
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M23_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M23_L01
M23_L00:
       test      rax,rax
       je        short M23_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M23_L01
       test      rax,rax
       je        short M23_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M23_L01
       test      rax,rax
       je        short M23_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M23_L01
       test      rax,rax
       je        short M23_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M23_L00
M23_L01:
       mov       rax,rdx
       ret
M23_L02:
       jmp       qword ptr [7FF7A9EA4660]
; Total bytes of code 88
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFFFEC1CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M24_L01
       cmp       [rax],ecx
       jle       short M24_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M24_L03
M24_L00:
       add       rsp,20
       pop       rbx
       ret
M24_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M24_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M24_L00
M24_L02:
       cmp       [rax+4],edx
       jle       short M24_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M24_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M24_L03
       jmp       short M24_L00
M24_L03:
       mov       ecx,ebx
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M25_L00
       ret
M25_L00:
       jmp       qword ptr [7FF7A95A5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.6 (10.0.6, 10.0.626.17701), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_XML_Ref_Person()
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
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,[rbx+48]
       test      rsi,rsi
       je        near ptr M00_L14
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L15
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L15
M00_L00:
       mov       r15,[rax+10]
       test      r15,r15
       jne       short M00_L01
       mov       rax,1C24F800190
       mov       r15,[rax]
       test      r15,r15
       jne       short M00_L01
       mov       rax,1C24F800170
       mov       r15,[rax]
       test      r15,r15
       je        near ptr M00_L16
M00_L01:
       mov       rcx,1C24F800280
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,202E45F1718
       mov       [rdi+10],rcx
       lea       rcx,[rdi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+30],1
       mov       [rbp-48],rdi
       mov       rcx,1C24F801FC0
       mov       r14,[rcx]
       mov       rcx,offset MT_System.Xml.XmlEncodedRawTextWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,100000001
       mov       [r15+68],rcx
       mov       dword ptr [r15+7C],1800
       movzx     ecx,byte ptr [r14+58]
       mov       [r15+94],cl
       mov       r13d,[r14+40]
       mov       [r15+88],r13d
       movzx     ecx,byte ptr [r14+59]
       mov       [r15+9B],cl
       mov       r12,[r14+10]
       lea       rcx,[r15+60]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r14+5C]
       mov       [r15+9C],cl
       movzx     edx,byte ptr [r14+5B]
       mov       [r15+9A],dl
       mov       edx,[r14+4C]
       mov       [r15+8C],edx
       mov       edx,[r14+50]
       mov       [r15+90],edx
       movzx     edx,byte ptr [r14+5F]
       mov       [r15+9E],dl
       test      ecx,ecx
       je        short M00_L02
       test      r13d,r13d
       jne       short M00_L02
       mov       rcx,r12
       mov       rdx,202E4601610
       xor       r8d,r8d
       call      qword ptr [7FF7A9CE5AA0]; System.Xml.XmlEncodedRawTextWriter.ValidateContentChars(System.String, System.String, Boolean)
M00_L02:
       lea       rcx,[r15+48]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rdi+28]
       test      rdx,rdx
       jne       short M00_L03
       mov       rcx,offset MT_System.Text.UnicodeEncoding
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       byte ptr [r13+24],1
       mov       dword ptr [r13+20],4B0
       mov       rcx,r13
       mov       rax,[7FF7A9A56478]
       call      qword ptr [rax+20]
       mov       word ptr [r13+26],0
       lea       rcx,[rdi+28]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r13
M00_L03:
       lea       rcx,[r15+30]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       byte ptr [r14+58],0
       je        short M00_L04
       mov       dword ptr [r15+7C],10000
M00_L04:
       mov       edx,[r15+7C]
       add       edx,20
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r15+38]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       byte ptr [r14+60],0
       je        short M00_L05
       mov       edx,[r15+8C]
       mov       rcx,r15
       call      qword ptr [7FF7A9CDEED0]; System.Xml.XmlEncodedRawTextWriter.WriteXmlDeclaration(System.Xml.XmlStandalone)
       mov       byte ptr [r15+9D],1
M00_L05:
       mov       rcx,offset MT_System.Xml.XmlWellFormedWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+20],rcx
       mov       rcx,offset MT_System.Xml.XmlWellFormedWriter+NamespaceResolverProxy
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r12,[r13+18]
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r12
       mov       rdx,r15
       mov       rax,[r12]
       mov       rax,[rax+90]
       call      qword ptr [rax+10]
       movzx     ecx,byte ptr [r14+5C]
       mov       [r13+81],cl
       mov       ecx,[r14+44]
       and       ecx,1
       mov       [r13+82],cl
       movzx     ecx,byte ptr [r14+5D]
       mov       [r13+83],cl
       mov       ecx,[r14+48]
       mov       [r13+7C],ecx
       cmp       ecx,2
       jne       short M00_L06
       mov       rcx,1C24F801FE8
       mov       rdx,[rcx]
       jmp       short M00_L07
M00_L06:
       mov       rdx,1C24F801FF0
       mov       rdx,[rdx]
M00_L07:
       lea       rcx,[r13+60]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+78],ecx
       mov       rcx,offset MT_System.Xml.XmlWellFormedWriter+Namespace[]
       mov       edx,8
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r13+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[r13+28]
       mov       rcx,r14
       mov       r15d,[rcx+8]
       test      r15d,r15d
       je        near ptr M00_L11
       add       rcx,10
       mov       r11,202E46017C8
       mov       [rcx],r11
       mov       r11,202E46017E8
       mov       [rcx+8],r11
       mov       dword ptr [rcx+10],3
       mov       dword ptr [rcx+14],0FFFFFFFF
       mov       rcx,r14
       cmp       r15d,1
       jbe       near ptr M00_L11
       add       rcx,28
       mov       r11,202E4601748
       mov       [rcx],r11
       mov       r11,202E4601768
       mov       [rcx+8],r11
       mov       dword ptr [rcx+10],3
       mov       dword ptr [rcx+14],0FFFFFFFF
       cmp       qword ptr [r13+20],0
       je        short M00_L08
       mov       rcx,[r13+20]
       mov       r11,7FF7A95211E0
       mov       r12,202E45F0008
       mov       rdx,r12
       call      qword ptr [r11]
       mov       rdx,rax
       mov       r14,[r13+28]
       cmp       dword ptr [r14+8],2
       jbe       near ptr M00_L11
       add       r14,40
       test      rdx,rdx
       cmove     rdx,r12
       mov       [r14],r12
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+10],2
       mov       dword ptr [r14+14],0FFFFFFFF
       jmp       short M00_L09
M00_L08:
       cmp       r15d,2
       jbe       near ptr M00_L11
       add       r14,40
       mov       r12,202E45F0008
       mov       [r14],r12
       mov       [r14+8],r12
       mov       dword ptr [r14+10],2
       mov       dword ptr [r14+14],0FFFFFFFF
M00_L09:
       mov       dword ptr [r13+68],2
       mov       rcx,offset MT_System.Xml.XmlWellFormedWriter+ElementScope[]
       mov       edx,8
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r13+38]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r13+38]
       add       rcx,10
       mov       rdx,rcx
       mov       eax,[r13+68]
       mov       [rdx+20],eax
       mov       [rdx],r12
       mov       [rdx+10],r12
       mov       [rdx+8],r12
       mov       dword ptr [rdx+24],0FFFFFFFF
       xor       eax,eax
       mov       [rdx+18],rax
       mov       [rcx+24],eax
       mov       [rcx+18],rax
       mov       [r13+6C],eax
       mov       rcx,offset MT_System.Xml.XmlWellFormedWriter+AttrName[]
       mov       edx,8
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r13+40]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-50],r13
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,rsi
       call      qword ptr [7FF7A97A61D8]; System.Object.GetType()
       mov       rdx,rax
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FF7A9CE5CE0]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],rcx
       mov       rcx,r14
       mov       rdx,r13
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF7A9D5D128]; System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       mov       rcx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A987CB50]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       ecx,[r13+78]
       cmp       ecx,10
       jg        short M00_L10
       mov       rax,1C24F801FE0
       mov       rax,[rax]
       cmp       ecx,11
       jae       short M00_L11
       mov       ecx,[rax+rcx*4+10]
       cmp       ecx,5
       je        short M00_L12
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF7A9CF08B8]; System.Xml.XmlWellFormedWriter.Close()
       jmp       short M00_L12
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       mov       byte ptr [rdi+30],0
       mov       rcx,[rdi]
       test      dword ptr [rcx],100000
       jne       near ptr M00_L17
M00_L13:
       mov       [rbp-40],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-40]
       mov       rdx,7FF7A9DFF1B0
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9DC71C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L14:
       call      qword ptr [7FF7A9B5E8C8]
       mov       ecx,1C4D
       mov       rdx,7FF7A98A5420
       call      qword ptr [7FF7A95DF228]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FF7A98A5420
       call      qword ptr [7FF7A95DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A95DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FF7A98A5420
       call      qword ptr [7FF7A95DF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A95DD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7A9EDFA50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7A9ED45D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L15:
       mov       ecx,2
       call      qword ptr [7FF7A9ED41F8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L16:
       call      qword ptr [7FF7A95DD4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L17:
       mov       rcx,rdi
       call      00007FF809209E50
       jmp       near ptr M00_L13
       sub       rsp,38
       mov       rcx,[rbp-50]
       mov       eax,[rcx+78]
       cmp       eax,10
       jg        short M00_L18
       mov       rdx,1C24F801FE0
       mov       rdi,[rdx]
       cmp       eax,11
       jae       short M00_L20
       mov       esi,[rdi+rax*4+10]
       cmp       esi,5
       je        short M00_L19
M00_L18:
       call      qword ptr [7FF7A9CF08B8]; System.Xml.XmlWellFormedWriter.Close()
M00_L19:
       nop
       add       rsp,38
       ret
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       mov       rcx,[rbp-48]
       mov       byte ptr [rcx+30],0
       mov       rsi,[rcx]
       test      dword ptr [rsi],100000
       je        short M00_L21
       call      00007FF809209E50
M00_L21:
       nop
       add       rsp,38
       ret
; Total bytes of code 1775
```
```assembly
; System.Xml.XmlEncodedRawTextWriter.ValidateContentChars(System.String, System.String, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,rdx
       test      r8b,r8b
       jne       short M01_L03
       xor       edi,edi
       mov       ebp,[rbx+8]
       cmp       ebp,edi
       jle       short M01_L02
M01_L00:
       mov       ecx,edi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       mov       eax,ecx
       mov       rdx,7FFFFEE0BB78
       test      byte ptr [rdx+rax],40
       jne       short M01_L01
       mov       eax,ecx
       cmp       eax,26
       jg        near ptr M01_L09
       lea       edx,[rax-9]
       cmp       edx,4
       ja        near ptr M01_L07
       mov       eax,13
       bt        eax,edx
       jae       near ptr M01_L08
M01_L01:
       inc       edi
       cmp       ebp,edi
       jg        short M01_L00
M01_L02:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       test      rbx,rbx
       jne       short M01_L04
       xor       edi,edi
       xor       ebp,ebp
       jmp       short M01_L05
M01_L04:
       lea       rdi,[rbx+0C]
       mov       ebp,[rbx+8]
M01_L05:
       mov       rcx,offset MT_System.Xml.XmlCharType
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1C24F8027E8
       mov       rcx,[rdx]
       test      rcx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FF7A95DFD50]
       int       3
M01_L06:
       mov       [rsp+28],rdi
       mov       [rsp+30],ebp
       lea       rdx,[rsp+28]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       test      eax,eax
       jl        short M01_L02
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9EDE2E0]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF7A9EDDDD0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A99541C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L07:
       cmp       eax,26
       je        short M01_L12
M01_L08:
       call      qword ptr [7FF7A9EDFAE0]
       test      eax,eax
       je        short M01_L11
       jmp       short M01_L10
M01_L09:
       cmp       eax,3C
       je        short M01_L12
       cmp       eax,5D
       jne       short M01_L08
       jmp       short M01_L12
M01_L10:
       lea       ecx,[rdi+1]
       cmp       ebp,ecx
       jle       short M01_L13
       lea       ecx,[rdi+1]
       cmp       ecx,ebp
       jae       near ptr M01_L16
       lea       ecx,[rdi+1]
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       call      qword ptr [7FF7A9EDFAF8]
       test      eax,eax
       je        short M01_L13
       inc       edi
       jmp       near ptr M01_L01
M01_L11:
       mov       ecx,edi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       call      qword ptr [7FF7A9EDFAF8]
       test      eax,eax
       je        near ptr M01_L01
       jmp       short M01_L14
M01_L12:
       mov       rcx,202E4601640
       call      qword ptr [7FF7A9EDE2F8]
       mov       rbp,rax
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF7A9EDFB10]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF7A9EDE328]
       mov       rbp,rax
       jmp       short M01_L15
M01_L13:
       mov       rcx,202E46016D0
       call      qword ptr [7FF7A9EDE2F8]
       mov       rbp,rax
       jmp       short M01_L15
M01_L14:
       mov       rcx,202E4601680
       call      qword ptr [7FF7A9EDE2F8]
       mov       rbp,rax
       mov       r8d,edi
       movzx     ecx,word ptr [rbx+r8*2+0C]
       mov       r8,1C24F800180
       mov       r8,[r8]
       mov       rdx,202E4601730
       call      qword ptr [7FF7A986F180]; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF7A9EDDDD0]
       mov       rbp,rax
M01_L15:
       call      qword ptr [7FF7A9EDE340]
       mov       rbx,rax
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF7A9EDE328]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF7A99541C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```
```assembly
; System.Xml.XmlEncodedRawTextWriter.WriteXmlDeclaration(System.Xml.XmlStandalone)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       mov       rbx,rcx
       mov       esi,edx
       cmp       byte ptr [rbx+9B],0
       jne       near ptr M02_L26
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M02_L26
       cmp       byte ptr [rbx+98],0
       jne       near ptr M02_L27
M02_L00:
       mov       rdi,202E4609E9C
       lea       rbp,[rdi+1E]
       mov       r14,[rbx+38]
       mov       [rsp+48],r14
       test      r14,r14
       je        near ptr M02_L28
       cmp       dword ptr [r14+8],0
       je        near ptr M02_L28
       add       r14,10
M02_L01:
       movsxd    rcx,dword ptr [rbx+68]
       lea       r15,[r14+rcx*2]
       xor       r13d,r13d
M02_L02:
       mov       rcx,rbp
       sub       rcx,rdi
       mov       rax,rcx
       shr       rax,3F
       add       rcx,rax
       sar       rcx,1
       lea       rcx,[r15+rcx*2]
       movsxd    rax,dword ptr [rbx+7C]
       lea       rax,[r14+rax*2]
       cmp       rax,rcx
       jb        near ptr M02_L29
M02_L03:
       cmp       r15,rcx
       jae       short M02_L05
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M02_L04:
       movzx     r13d,word ptr [rdi]
       cmp       r13d,0D800
       jge       short M02_L05
       add       rdi,2
       mov       [r15],r13w
       add       r15,2
       cmp       r15,rcx
       jb        short M02_L04
M02_L05:
       cmp       rdi,rbp
       jb        near ptr M02_L30
       mov       rax,r15
       sub       rax,r14
       mov       rcx,rax
       shr       rcx,3F
       add       rax,rcx
       sar       rax,1
       mov       [rbx+68],eax
       xor       ecx,ecx
       mov       [rsp+48],rcx
       mov       rdi,202E4609ED4
       lea       rbp,[rdi+6]
       mov       r14,[rbx+38]
       mov       [rsp+40],r14
       test      r14,r14
       je        near ptr M02_L36
       cmp       dword ptr [r14+8],0
       je        near ptr M02_L36
       add       r14,10
M02_L06:
       movsxd    rcx,eax
       lea       r15,[r14+rcx*2]
       xor       r13d,r13d
M02_L07:
       mov       rcx,rbp
       sub       rcx,rdi
       mov       rax,rcx
       shr       rax,3F
       add       rcx,rax
       sar       rcx,1
       lea       rcx,[r15+rcx*2]
       movsxd    rax,dword ptr [rbx+7C]
       lea       rax,[r14+rax*2]
       cmp       rax,rcx
       jb        near ptr M02_L37
M02_L08:
       cmp       r15,rcx
       jae       short M02_L10
       nop       word ptr [rax+rax]
M02_L09:
       movzx     r13d,word ptr [rdi]
       cmp       r13d,0D800
       jge       short M02_L10
       add       rdi,2
       mov       [r15],r13w
       add       r15,2
       cmp       r15,rcx
       jb        short M02_L09
M02_L10:
       cmp       rdi,rbp
       jb        near ptr M02_L38
       mov       rax,r15
       sub       rax,r14
       mov       rcx,rax
       shr       rcx,3F
       add       rax,rcx
       sar       rax,1
       mov       [rbx+68],eax
       xor       ecx,ecx
       mov       [rsp+40],rcx
       cmp       qword ptr [rbx+30],0
       je        near ptr M02_L24
       mov       rdi,202E4609EF4
       lea       rbp,[rdi+18]
       mov       r14,[rbx+38]
       mov       [rsp+38],r14
       test      r14,r14
       je        near ptr M02_L44
       cmp       dword ptr [r14+8],0
       je        near ptr M02_L44
       add       r14,10
M02_L11:
       movsxd    rcx,eax
       lea       r15,[r14+rcx*2]
       xor       r13d,r13d
M02_L12:
       mov       rcx,rbp
       sub       rcx,rdi
       mov       rax,rcx
       shr       rax,3F
       add       rcx,rax
       sar       rcx,1
       lea       rcx,[r15+rcx*2]
       movsxd    rax,dword ptr [rbx+7C]
       lea       rax,[r14+rax*2]
       cmp       rax,rcx
       jb        near ptr M02_L45
M02_L13:
       cmp       r15,rcx
       jae       short M02_L15
       nop       word ptr [rax+rax]
M02_L14:
       movzx     r13d,word ptr [rdi]
       cmp       r13d,0D800
       jge       short M02_L15
       add       rdi,2
       mov       [r15],r13w
       add       r15,2
       cmp       r15,rcx
       jb        short M02_L14
M02_L15:
       cmp       rdi,rbp
       jb        near ptr M02_L46
       mov       rcx,r15
       sub       rcx,r14
       mov       rax,rcx
       shr       rax,3F
       add       rcx,rax
       sar       rcx,1
       mov       [rbx+68],ecx
       xor       ecx,ecx
       mov       [rsp+38],rcx
       mov       rdi,[rbx+30]
       mov       rcx,offset MT_System.Text.UnicodeEncoding
       cmp       [rdi],rcx
       jne       near ptr M02_L53
       cmp       qword ptr [rdi+8],0
       jne       short M02_L16
       mov       ecx,[rdi+20]
       call      qword ptr [7FF7A9D5D458]; System.Text.EncodingTable.GetCodePageDataItem(Int32)
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rdi+8],0
       je        near ptr M02_L52
M02_L16:
       mov       rcx,[rdi+8]
       mov       rbp,[rcx+8]
M02_L17:
       test      rbp,rbp
       je        near ptr M02_L54
       lea       rcx,[rbp+0C]
       mov       [rsp+30],rcx
       mov       rdi,[rsp+30]
M02_L18:
       mov       ecx,[rbp+8]
       lea       rbp,[rdi+rcx*2]
       mov       r14,[rbx+38]
       mov       [rsp+28],r14
       test      r14,r14
       je        near ptr M02_L55
       cmp       dword ptr [r14+8],0
       je        near ptr M02_L55
       add       r14,10
M02_L19:
       movsxd    rcx,dword ptr [rbx+68]
       lea       r15,[r14+rcx*2]
       xor       r13d,r13d
M02_L20:
       mov       rcx,rbp
       sub       rcx,rdi
       mov       rax,rcx
       shr       rax,3F
       add       rcx,rax
       sar       rcx,1
       lea       rcx,[r15+rcx*2]
       movsxd    rax,dword ptr [rbx+7C]
       lea       rax,[r14+rax*2]
       cmp       rax,rcx
       jb        near ptr M02_L56
M02_L21:
       cmp       r15,rcx
       jae       short M02_L23
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M02_L22:
       movzx     r13d,word ptr [rdi]
       cmp       r13d,0D800
       jge       short M02_L23
       add       rdi,2
       mov       [r15],r13w
       add       r15,2
       cmp       r15,rcx
       jb        short M02_L22
M02_L23:
       cmp       rdi,rbp
       jb        near ptr M02_L57
       mov       rcx,r15
       sub       rcx,r14
       mov       rdx,rcx
       shr       rdx,3F
       add       rcx,rdx
       sar       rcx,1
       mov       [rbx+68],ecx
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+30],rcx
M02_L24:
       test      esi,esi
       jne       near ptr M02_L63
M02_L25:
       mov       rdx,202E4609F5C
       lea       r8,[rdx+6]
       mov       rcx,rbx
       call      qword ptr [7FF7A9D5D410]; System.Xml.XmlEncodedRawTextWriter.RawText(Char*, Char*)
M02_L26:
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L27:
       cmp       byte ptr [rbx+99],0
       je        near ptr M02_L00
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF7A9EDF9D8]
       jmp       near ptr M02_L00
M02_L28:
       xor       r14d,r14d
       jmp       near ptr M02_L01
M02_L29:
       movsxd    rcx,dword ptr [rbx+7C]
       lea       rcx,[r14+rcx*2]
       jmp       near ptr M02_L03
M02_L30:
       cmp       r15,rcx
       jb        short M02_L31
       mov       rax,r15
       sub       rax,r14
       mov       rdx,rax
       shr       rdx,3F
       add       rax,rdx
       sar       rax,1
       mov       [rbx+68],eax
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+0A8]
       call      qword ptr [rax+10]
       lea       r15,[r14+2]
       jmp       near ptr M02_L02
M02_L31:
       mov       ecx,r13d
       call      qword ptr [7FF7A9EDF9A8]
       test      eax,eax
       je        short M02_L32
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,r15
       call      qword ptr [7FF7A9EDDC98]
       mov       r15,rax
       add       rdi,4
       jmp       near ptr M02_L02
M02_L32:
       cmp       r13d,7F
       jle       short M02_L33
       cmp       r13d,0FFFE
       jl        short M02_L35
M02_L33:
       mov       rcx,rbx
       mov       edx,r13d
       mov       r8,r15
       xor       r9d,r9d
       call      qword ptr [7FF7A9EDF9C0]
       mov       r15,rax
M02_L34:
       add       rdi,2
       jmp       near ptr M02_L02
M02_L35:
       mov       [r15],r13w
       add       r15,2
       jmp       short M02_L34
M02_L36:
       xor       r14d,r14d
       jmp       near ptr M02_L06
M02_L37:
       movsxd    rcx,dword ptr [rbx+7C]
       lea       rcx,[r14+rcx*2]
       jmp       near ptr M02_L08
M02_L38:
       cmp       r15,rcx
       jb        short M02_L39
       mov       rax,r15
       sub       rax,r14
       mov       rdx,rax
       shr       rdx,3F
       add       rax,rdx
       sar       rax,1
       mov       [rbx+68],eax
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+0A8]
       call      qword ptr [rax+10]
       lea       r15,[r14+2]
       jmp       near ptr M02_L07
M02_L39:
       mov       ecx,r13d
       call      qword ptr [7FF7A9EDF9A8]
       test      eax,eax
       je        short M02_L40
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,r15
       call      qword ptr [7FF7A9EDDC98]
       mov       r15,rax
       add       rdi,4
       jmp       near ptr M02_L07
M02_L40:
       cmp       r13d,7F
       jle       short M02_L41
       cmp       r13d,0FFFE
       jl        short M02_L43
M02_L41:
       mov       rcx,rbx
       mov       edx,r13d
       mov       r8,r15
       xor       r9d,r9d
       call      qword ptr [7FF7A9EDF9C0]
       mov       r15,rax
M02_L42:
       add       rdi,2
       jmp       near ptr M02_L07
M02_L43:
       mov       [r15],r13w
       add       r15,2
       jmp       short M02_L42
M02_L44:
       xor       r14d,r14d
       jmp       near ptr M02_L11
M02_L45:
       movsxd    rcx,dword ptr [rbx+7C]
       lea       rcx,[r14+rcx*2]
       jmp       near ptr M02_L13
M02_L46:
       cmp       r15,rcx
       jb        short M02_L47
       mov       rcx,r15
       sub       rcx,r14
       mov       rax,rcx
       shr       rax,3F
       add       rcx,rax
       sar       rcx,1
       mov       [rbx+68],ecx
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+0A8]
       call      qword ptr [rax+10]
       lea       r15,[r14+2]
       jmp       near ptr M02_L12
M02_L47:
       mov       ecx,r13d
       call      qword ptr [7FF7A9EDF9A8]
       test      eax,eax
       je        short M02_L48
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,r15
       call      qword ptr [7FF7A9EDDC98]
       mov       r15,rax
       add       rdi,4
       jmp       near ptr M02_L12
M02_L48:
       cmp       r13d,7F
       jle       short M02_L49
       cmp       r13d,0FFFE
       jl        short M02_L51
M02_L49:
       mov       rcx,rbx
       mov       edx,r13d
       mov       r8,r15
       xor       r9d,r9d
       call      qword ptr [7FF7A9EDF9C0]
       mov       r15,rax
M02_L50:
       add       rdi,2
       jmp       near ptr M02_L12
M02_L51:
       mov       [r15],r13w
       add       r15,2
       jmp       short M02_L50
M02_L52:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9EDE760]
       mov       rsi,rax
       mov       ecx,[rdi+20]
       mov       [rbx+8],ecx
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7A9CE6D18]; System.SR.Format(System.String, System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF7A95DF240]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L53:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rbp,rax
       jmp       near ptr M02_L17
M02_L54:
       xor       edi,edi
       jmp       near ptr M02_L18
M02_L55:
       xor       r14d,r14d
       jmp       near ptr M02_L19
M02_L56:
       movsxd    rcx,dword ptr [rbx+7C]
       lea       rcx,[r14+rcx*2]
       jmp       near ptr M02_L21
M02_L57:
       cmp       r15,rcx
       jb        short M02_L58
       mov       rcx,r15
       sub       rcx,r14
       mov       rax,rcx
       shr       rax,3F
       add       rcx,rax
       sar       rcx,1
       mov       [rbx+68],ecx
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+0A8]
       call      qword ptr [rax+10]
       lea       r15,[r14+2]
       jmp       near ptr M02_L20
M02_L58:
       mov       ecx,r13d
       call      qword ptr [7FF7A9EDF9A8]
       test      eax,eax
       je        short M02_L59
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,r15
       call      qword ptr [7FF7A9EDDC98]
       mov       r15,rax
       add       rdi,4
       jmp       near ptr M02_L20
M02_L59:
       cmp       r13d,7F
       jle       short M02_L60
       cmp       r13d,0FFFE
       jl        short M02_L62
M02_L60:
       mov       rcx,rbx
       mov       edx,r13d
       mov       r8,r15
       xor       r9d,r9d
       call      qword ptr [7FF7A9EDF9C0]
       mov       r15,rax
M02_L61:
       add       rdi,2
       jmp       near ptr M02_L20
M02_L62:
       mov       [r15],r13w
       add       r15,2
       jmp       short M02_L61
M02_L63:
       mov       rcx,rbx
       mov       rdx,202E4609F18
       call      qword ptr [7FF7A9D5D710]; System.Xml.XmlEncodedRawTextWriter.RawText(System.String)
       mov       rdx,202E4609E70
       mov       rcx,202E4609E50
       cmp       esi,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF7A9D5D710]; System.Xml.XmlEncodedRawTextWriter.RawText(System.String)
       jmp       near ptr M02_L25
; Total bytes of code 1825
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
       je        short M03_L01
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       call      qword ptr [7FF7A95D5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M03_L00
; Total bytes of code 41
```
```assembly
; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        near ptr M04_L17
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M04_L18
M04_L00:
       mov       rcx,1C24F802030
       mov       r14,[rcx]
       mov       r15,[r14+8]
       mov       r13d,[r15+8]
       mov       r12d,r13d
       cmp       qword ptr [r14+20],0
       jne       short M04_L01
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       short M04_L02
M04_L01:
       mov       rcx,[r14+20]
       mov       rdx,rsi
       mov       r11,7FF7A95215C8
       call      qword ptr [r11]
M04_L02:
       mov       r8d,eax
       and       r8d,7FFFFFFF
       imul      eax,r8d,65
       dec       r12d
       xor       edx,edx
       div       r12d
       lea       r12d,[rdx+1]
       mov       [rbp-4C],r12d
       mov       [rbp-50],r8d
       xor       r10d,r10d
       mov       [rbp-54],r10d
       mov       eax,r8d
       xor       edx,edx
       div       r13d
       mov       eax,edx
M04_L03:
       xor       ecx,ecx
       mov       [rbp-60],ecx
       mov       ecx,eax
       lea       r9,[rcx+rcx*2]
       mov       [rbp-88],r9
M04_L04:
       mov       ecx,[r14+38]
       mov       [rbp-58],eax
       cmp       eax,r13d
       jae       near ptr M04_L36
       lea       rdx,[r15+r9*8+10]
       mov       r11,[rdx]
       mov       r12,[rdx+8]
       mov       edx,[rdx+10]
       mov       [rbp-7C],edx
       cmp       byte ptr [r14+3C],0
       jne       near ptr M04_L19
       cmp       ecx,[r14+38]
       jne       near ptr M04_L19
       test      r11,r11
       jne       near ptr M04_L15
M04_L05:
       xor       edx,edx
M04_L06:
       mov       r14,rdx
       test      r14,r14
       je        short M04_L07
       mov       rcx,offset MT_System.Xml.Serialization.TypeDesc
       cmp       [r14],rcx
       jne       near ptr M04_L25
M04_L07:
       test      r14,r14
       jne       near ptr M04_L26
M04_L08:
       xor       r14d,r14d
M04_L09:
       lea       rcx,[rbx+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+18],0
       jne       near ptr M04_L27
       cmp       dword ptr [7FF7A951B150],1
       je        near ptr M04_L14
       mov       rcx,1C24F802058
       mov       r14,[rcx]
       mov       rcx,offset MT_System.Xml.Serialization.TempAssemblyCacheKey
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[r14+10]
       cmp       qword ptr [r13+8],0
       je        near ptr M04_L30
       mov       r12,[r13+18]
       mov       rcx,r12
       mov       rdx,r15
       mov       r11,7FF7A95215D8
       call      qword ptr [r11]
       mov       [rbp-74],eax
       mov       rdx,[r13+8]
       mov       ecx,eax
       imul      rcx,[r13+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M04_L36
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       edx,[rdx]
       mov       r13,[r13+10]
       xor       r10d,r10d
       mov       [rbp-78],r10d
       dec       edx
       cmp       [r13+8],edx
       jbe       near ptr M04_L30
M04_L10:
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r13+rdx*8+10]
       mov       [rbp-98],r9
       cmp       [r9+10],eax
       jne       near ptr M04_L29
       mov       rdx,[r9]
       mov       rcx,r12
       mov       r8,r15
       mov       r11,7FF7A95215E0
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-98]
       je        near ptr M04_L29
       add       r9,8
M04_L11:
       test      r9,r9
       je        near ptr M04_L31
       mov       rcx,[r9]
       mov       [rbp-68],rcx
M04_L12:
       mov       rdx,[rbp-68]
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       [rbp-70],rcx
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+8],0
       je        near ptr M04_L32
M04_L13:
       cmp       qword ptr [rbx+18],0
       jne       short M04_L14
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF7A9DC71B0]; System.Xml.Serialization.XmlReflectionImporter.GetTopLevelMapping(System.Type, System.String)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M04_L14:
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
M04_L15:
       mov       ecx,edx
       and       ecx,7FFFFFFF
       movsxd    rcx,ecx
       mov       r9d,[rbp-50]
       cmp       rcx,r9
       jne       near ptr M04_L22
       cmp       [r14+8],r11
       je        near ptr M04_L22
       cmp       r11,rsi
       jne       short M04_L20
M04_L16:
       mov       rdx,r12
       jmp       near ptr M04_L06
M04_L17:
       mov       ecx,0EBC1
       mov       rdx,7FF7A9C4D370
       call      qword ptr [7FF7A95DF228]
       mov       rcx,rax
       call      qword ptr [7FF7A9DCF9D8]
       int       3
M04_L18:
       mov       rcx,rdi
       mov       rdx,202E45F0008
       call      qword ptr [7FF7A95D6E08]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       near ptr M04_L00
       jmp       near ptr M04_L08
M04_L19:
       lea       rcx,[rbp-60]
       mov       edx,14
       call      qword ptr [7FF7A9EDDF08]
       mov       eax,[rbp-58]
       mov       r9,[rbp-88]
       jmp       near ptr M04_L04
M04_L20:
       cmp       qword ptr [r14+20],0
       je        short M04_L21
       mov       rcx,[r14+20]
       mov       r8,rsi
       mov       rdx,r11
       mov       r11,7FF7A95215D0
       call      qword ptr [r11]
       jmp       short M04_L23
M04_L21:
       mov       rcx,r11
       mov       rdx,rsi
       mov       r9,[r11]
       mov       r9,[r9+40]
       call      qword ptr [r9+10]
       jmp       short M04_L23
M04_L22:
       mov       eax,[rbp-58]
       mov       r12d,[rbp-4C]
       mov       ecx,r12d
       add       rax,rcx
       mov       r13d,[r15+8]
       mov       ecx,r13d
       cqo
       idiv      rcx
       mov       eax,edx
       mov       ecx,eax
       cmp       dword ptr [rbp-7C],0
       jge       near ptr M04_L05
       jmp       short M04_L24
M04_L23:
       test      eax,eax
       je        short M04_L22
       jmp       near ptr M04_L16
M04_L24:
       mov       r10d,[rbp-54]
       inc       r10d
       cmp       r13d,r10d
       mov       [rbp-54],r10d
       mov       eax,ecx
       jg        near ptr M04_L03
       jmp       near ptr M04_L05
M04_L25:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M04_L26:
       mov       rcx,offset MT_System.Xml.Serialization.ElementAccessor
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,[r14+38]
       mov       rdx,[rcx+48]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Xml.Serialization.XmlTypeMapping
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       r8,r15
       xor       edx,edx
       mov       r9d,3
       call      qword ptr [7FF7A9EDE370]
       mov       rcx,rsi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF7A9CEEFE8]; System.Xml.Serialization.XmlMapping.GenerateKey(System.Type, System.Xml.Serialization.XmlRootAttribute, System.String)
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L09
M04_L27:
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L14
M04_L28:
       cmp       [r13+8],edx
       mov       [rbp-78],r10d
       mov       eax,[rbp-74]
       jbe       short M04_L30
       jmp       near ptr M04_L10
M04_L29:
       mov       edx,[r9+14]
       mov       r10d,[rbp-78]
       inc       r10d
       cmp       [r13+8],r10d
       jae       short M04_L28
       call      qword ptr [7FF7A95DF498]
       int       3
M04_L30:
       xor       r9d,r9d
       jmp       near ptr M04_L11
M04_L31:
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       r14,[r14+8]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       rdx,rax
       mov       rcx,r14
       lea       r8,[rbp-70]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9CE6550]; System.Runtime.CompilerServices.ConditionalWeakTable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M04_L12
       lea       r8,[rbp-68]
       mov       rcx,[rbp-70]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF7A961AC10]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       jmp       near ptr M04_L12
M04_L32:
       mov       rdx,1C24F802058
       mov       rcx,[rdx]
       mov       [rbp-90],rcx
       xor       edx,edx
       mov       [rbp-40],edx
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-90]
       call      qword ptr [7FF7A95D5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1C24F802058
       mov       rcx,[rcx]
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FF7A9CE6538]; System.Xml.Serialization.TempAssemblyCache.get_Item(System.String, System.Type)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+8],0
       jne       near ptr M04_L35
       xor       r8d,r8d
       mov       [rbp-48],r8
       lea       r8,[rbp-48]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF7A9CE6568]; System.Xml.Serialization.TempAssembly.LoadGeneratedAssembly(System.Type, System.String, System.Xml.Serialization.XmlSerializerImplementation ByRef)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M04_L34
       cmp       dword ptr [7FF7A951B150],3
       jne       short M04_L33
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FF7A9CE67A8]; System.Xml.Serialization.Compiler.GetTempAssemblyName(System.Reflection.AssemblyName, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.IO.FileLoadException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7A9EDE3A0]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF7A9EDDDD0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF7A9EDE3B8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M04_L33:
       mov       rcx,offset MT_System.Xml.Serialization.XmlReflectionImporter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       r8,rdi
       xor       edx,edx
       call      qword ptr [7FF7A9CE6DC0]; System.Xml.Serialization.XmlReflectionImporter..ctor(System.Xml.Serialization.XmlAttributeOverrides, System.String)
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9,rdi
       xor       r8d,r8d
       call      qword ptr [7FF7A9CE6E20]; System.Xml.Serialization.XmlReflectionImporter.ImportTypeMapping(System.Type, System.Xml.Serialization.XmlRootAttribute, System.String)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+18]
       mov       rdx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FF7A9CEF1E0]; System.Xml.Serialization.XmlSerializer.GenerateTempAssembly(System.Xml.Serialization.XmlMapping, System.Type, System.String, System.String)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M04_L35
M04_L34:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF7A9DC71B0]; System.Xml.Serialization.XmlReflectionImporter.GetTopLevelMapping(System.Type, System.String)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Xml.Serialization.XmlMapping[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       mov       rdx,[rbx+18]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Xml.Serialization.TempAssembly
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,r14
       mov       r9,[rbp-48]
       call      qword ptr [7FF7A9EDE3D0]
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M04_L35:
       mov       r9,[rbx+8]
       mov       rcx,1C24F802058
       mov       rcx,[rcx]
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FF7A9D5CFC0]; System.Xml.Serialization.TempAssemblyCache.Add(System.String, System.Type, System.Xml.Serialization.TempAssembly)
       nop
       cmp       byte ptr [rbp-40],0
       je        near ptr M04_L13
       mov       rcx,[rbp-90]
       call      qword ptr [7FF7A95D6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M04_L13
M04_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-40],0
       je        short M04_L37
       mov       rcx,[rbp-90]
       call      qword ptr [7FF7A95D6820]; System.Threading.Monitor.Exit(System.Object)
M04_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1756
```
```assembly
; System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rsi,rdx
       mov       r14,r8
       mov       rdi,r9
       cmp       qword ptr [rbx+10],0
       jne       near ptr M05_L04
       mov       r15,[rbx+18]
       mov       rcx,r15
       cmp       dword ptr [7FF7A951B150],1
       je        short M05_L03
       test      rcx,rcx
       je        short M05_L00
       movzx     ecx,byte ptr [rcx+25]
       test      ecx,ecx
       jne       short M05_L03
M05_L00:
       cmp       byte ptr [rbx+31],0
       jne       short M05_L03
       mov       r13,[rbx+8]
       test      r13,r13
       je        near ptr M05_L06
       cmp       byte ptr [rbx+30],0
       jne       near ptr M05_L06
       test      rdi,rdi
       jne       near ptr M05_L09
M05_L01:
       call      qword ptr [7FF7A9D5D158]; System.Xml.Serialization.XmlSerializer.get_DefaultNamespaces()
       mov       rdi,rax
M05_L02:
       mov       [rsp+20],rdi
       mov       rdi,[rbp+30]
       mov       [rsp+28],rdi
       mov       r12,[rbp+38]
       mov       [rsp+30],r12
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rsi
       mov       r9,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9D5D200]; System.Xml.Serialization.TempAssembly.InvokeWriter(System.Xml.Serialization.XmlMapping, System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       jmp       near ptr M05_L10
M05_L03:
       mov       r15,[rbp+30]
       mov       [rsp+20],r15
       mov       r12,[rbp+38]
       mov       [rsp+28],r12
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,r14
       mov       r9,rdi
       call      qword ptr [7FF7A9EDFC00]
       jmp       near ptr M05_L10
M05_L04:
       mov       r15,[rbp+30]
       test      r15,r15
       je        short M05_L05
       cmp       dword ptr [r15+8],0
       jle       short M05_L05
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7A9EDE640]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF7A9EDDDD0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7A9956010]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L05:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,r14
       mov       r9,rdi
       call      qword ptr [7FF7A9EDE658]
       jmp       short M05_L10
M05_L06:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r15,rax
       test      rdi,rdi
       je        short M05_L07
       mov       rcx,rdi
       call      qword ptr [7FF7A9EDFC18]
       test      eax,eax
       je        short M05_L07
       mov       r8,rdi
       jmp       short M05_L08
M05_L07:
       call      qword ptr [7FF7A9D5D158]; System.Xml.Serialization.XmlSerializer.get_DefaultNamespaces()
       mov       r8,rax
M05_L08:
       mov       r12,[rbp+38]
       mov       [rsp+20],r12
       mov       rcx,r15
       mov       rdx,rsi
       mov       r9,[rbp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF7A9EDFC30]
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,r15
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M05_L10
M05_L09:
       mov       rcx,rdi
       call      qword ptr [7FF7A9EDFC18]
       test      eax,eax
       je        near ptr M05_L01
       jmp       near ptr M05_L02
M05_L10:
       mov       rcx,offset MT_System.Xml.XmlWellFormedWriter
       cmp       [rsi],rcx
       jne       short M05_L11
       mov       rcx,rsi
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FF7A9CF08C0]; System.Xml.XmlWellFormedWriter.Flush()
M05_L11:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+58]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [rax+28]
       sub       rsp,38
       mov       rbx,rcx
       test      rbx,rbx
       jne       short M05_L13
M05_L12:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7A9EDE6B8]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FF7A99E60E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L13:
       mov       rax,offset MT_System.Reflection.TargetInvocationException
       cmp       [rbx],rax
       jne       short M05_L12
       call      qword ptr [7FF7A95DC2E8]
       mov       rbx,rax
       jmp       short M05_L12
; Total bytes of code 575
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M06_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF809259F20
       mov       rsi,rax
M06_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M06_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M06_L03
       cmp       [rdx+8],r8d
       jb        short M06_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FF7A95D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M06_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rax,202E45F0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF7A9514000
       call      qword ptr [7FF7A95DF228]
       mov       rbx,rax
       call      qword ptr [7FF7A9DCFEA0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7A986D950]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Xml.XmlWellFormedWriter.Close()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,90
       lea       rbp,[rsp+0A0]
       mov       [rbp+10],rcx
       mov       ebx,[rcx+78]
       cmp       ebx,0F
       je        near ptr M07_L12
       cmp       byte ptr [rcx+83],0
       je        near ptr M07_L05
       cmp       ebx,10
       je        short M07_L01
M07_L00:
       cmp       dword ptr [rcx+6C],0
       jg        short M07_L04
M07_L01:
       mov       eax,[rcx+78]
       cmp       eax,5
       je        near ptr M07_L06
       cmp       eax,6
       je        near ptr M07_L06
       cmp       eax,0D
       je        near ptr M07_L06
M07_L02:
       mov       rbx,[rcx+10]
       mov       rax,offset MT_System.Xml.XmlEncodedRawTextWriter
       cmp       [rbx],rax
       jne       near ptr M07_L10
       mov       rcx,rbx
       call      qword ptr [7FF7A9CDEF88]; System.Xml.XmlEncodedRawTextWriter.FlushBuffer()
       cmp       qword ptr [rbx+28],0
       jne       near ptr M07_L07
M07_L03:
       cmp       qword ptr [rbx+28],0
       jne       near ptr M07_L08
       mov       rcx,[rbx+48]
       test      rcx,rcx
       je        near ptr M07_L11
       mov       rax,offset MT_System.IO.StringWriter
       cmp       [rcx],rax
       je        near ptr M07_L11
       jmp       near ptr M07_L09
M07_L04:
       call      qword ptr [7FF7A9CF0828]; System.Xml.XmlWellFormedWriter.WriteEndElement()
       mov       rcx,[rbp+10]
       cmp       dword ptr [rcx+78],10
       je        near ptr M07_L01
       jmp       near ptr M07_L00
M07_L05:
       cmp       ebx,10
       je        near ptr M07_L01
       cmp       dword ptr [rcx+6C],0
       jle       near ptr M07_L01
       mov       edx,6
       call      qword ptr [7FF7A9D5D3E0]; System.Xml.XmlWellFormedWriter.AdvanceState(Token)
       mov       rcx,[rbp+10]
       jmp       near ptr M07_L01
M07_L06:
       cmp       qword ptr [rcx+18],0
       je        near ptr M07_L02
       mov       rax,[rcx+18]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+98]
       call      qword ptr [rax+30]
       mov       rcx,[rbp+10]
       jmp       near ptr M07_L02
M07_L07:
       mov       rcx,[rbx+40]
       mov       rdx,[rbx+20]
       mov       [rsp+20],rdx
       xor       edx,edx
       mov       [rsp+28],edx
       mov       rdx,[rbx+20]
       mov       edx,[rdx+8]
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       lea       rdx,[rbp-18]
       mov       [rsp+40],rdx
       lea       rdx,[rbp-20]
       mov       [rsp+48],rdx
       lea       rdx,[rbp-28]
       mov       [rsp+50],rdx
       mov       rdx,[rbx+38]
       mov       r8d,1
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       cmp       dword ptr [rbp-20],0
       je        near ptr M07_L03
       mov       rcx,[rbx+28]
       mov       rdx,[rbx+20]
       mov       r9d,[rbp-20]
       xor       r8d,r8d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       jmp       near ptr M07_L03
M07_L08:
       mov       rcx,[rbx+28]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M07_L11
M07_L09:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M07_L11
M07_L10:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       call      qword ptr [rax+28]
       nop
M07_L11:
       call      M07_L29
       nop
M07_L12:
       add       rsp,90
       pop       rbx
       pop       rsi
       pop       rbp
       ret
       sub       rsp,58
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+78],10
       call      CORINFO_HELP_RETHROW
       int       3
M07_L13:
       sub       rsp,58
       xor       ecx,ecx
       mov       rax,[rbp-48]
       mov       [rax+28],rcx
       add       rsp,58
       ret
M07_L14:
       sub       rsp,58
       mov       rcx,[rbp-48]
       cmp       byte ptr [rcx+9A],0
       je        short M07_L18
       mov       rbx,[rcx+28]
       mov       rsi,[rbx]
       mov       rdx,offset MT_System.IO.FileStream
       cmp       rsi,rdx
       jne       short M07_L17
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M07_L16
       mov       r8,[rax]
       mov       rdx,offset MT_System.IO.Strategies.BufferedFileStreamStrategy
       cmp       r8,rdx
       jne       short M07_L15
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FF7A976A888]
       jmp       short M07_L16
M07_L15:
       mov       rcx,rax
       mov       edx,1
       mov       rax,[r8+50]
       call      qword ptr [rax+20]
M07_L16:
       test      dword ptr [rsi],100000
       je        short M07_L18
       mov       rcx,rbx
       call      00007FF809209E50
       jmp       short M07_L18
M07_L17:
       mov       rcx,rbx
       mov       rax,[rsi+50]
       call      qword ptr [rax+18]
       nop
M07_L18:
       mov       rcx,[rbp-48]
       call      M07_L13
       nop
       add       rsp,58
       ret
M07_L19:
       sub       rsp,58
       xor       ecx,ecx
       mov       rdx,[rbp-48]
       mov       [rdx+48],rcx
       add       rsp,58
       ret
M07_L20:
       sub       rsp,58
       mov       rcx,[rbp-48]
       cmp       byte ptr [rcx+9A],0
       je        short M07_L23
       mov       rbx,[rcx+48]
       mov       rdx,offset MT_System.IO.StringWriter
       cmp       [rbx],rdx
       jne       short M07_L21
       mov       byte ptr [rbx+30],0
       jmp       short M07_L22
M07_L21:
       mov       rcx,rbx
       mov       edx,1
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M07_L22:
       mov       rcx,rbx
       call      qword ptr [7FF7A97A5590]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,[rbp-48]
M07_L23:
       call      M07_L19
       nop
       add       rsp,58
       ret
M07_L24:
       sub       rsp,58
       mov       rcx,[rbp-48]
       mov       byte ptr [rcx+95],1
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M07_L25
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       nop
       call      M07_L14
       jmp       short M07_L27
M07_L25:
       mov       rcx,[rbp-48]
       cmp       qword ptr [rcx+48],0
       je        short M07_L27
       mov       rax,[rcx+48]
       mov       rdx,offset MT_System.IO.StringWriter
       cmp       [rax],rdx
       je        short M07_L26
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
M07_L26:
       nop
       call      M07_L20
       nop
M07_L27:
       add       rsp,58
       ret
M07_L28:
       sub       rsp,58
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+78],0F
       add       rsp,58
       ret
M07_L29:
       sub       rsp,58
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M07_L35
       mov       edx,[rcx+78]
       cmp       edx,10
       jg        short M07_L30
       mov       r8,1C24F801FE0
       mov       r8,[r8]
       cmp       edx,11
       jae       near ptr M07_L34
       mov       edx,[r8+rdx*4+10]
       jmp       short M07_L31
M07_L30:
       mov       edx,6
M07_L31:
       mov       r8,offset MT_System.Xml.XmlEncodedRawTextWriter
       cmp       [rax],r8
       jne       near ptr M07_L33
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       call      qword ptr [7FF7A9CDEF88]; System.Xml.XmlEncodedRawTextWriter.FlushBuffer()
       mov       rcx,[rbp-48]
       cmp       qword ptr [rcx+28],0
       je        near ptr M07_L32
       mov       rax,[rcx+40]
       mov       rdx,[rcx+20]
       mov       [rsp+20],rdx
       xor       edx,edx
       mov       [rsp+28],edx
       mov       rdx,[rcx+20]
       mov       edx,[rdx+8]
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       lea       rdx,[rbp-30]
       mov       [rsp+40],rdx
       lea       rdx,[rbp-38]
       mov       [rsp+48],rdx
       lea       rdx,[rbp-40]
       mov       [rsp+50],rdx
       mov       rcx,rax
       mov       r10,[rbp-48]
       mov       rdx,[r10+38]
       mov       r8d,1
       xor       r9d,r9d
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       cmp       dword ptr [rbp-38],0
       je        short M07_L32
       mov       r10,[rbp-48]
       mov       rcx,[r10+28]
       mov       rdx,[r10+20]
       mov       r9d,[rbp-38]
       xor       r8d,r8d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       nop
M07_L32:
       mov       rcx,[rbp-48]
       call      M07_L24
       jmp       short M07_L36
M07_L33:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+98]
       call      qword ptr [rax+38]
       jmp       short M07_L36
M07_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M07_L35:
       mov       rax,[rcx+10]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+20]
       nop
M07_L36:
       call      M07_L28
       nop
       add       rsp,58
       ret
; Total bytes of code 1180
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
       je        near ptr M09_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M09_L01
       test      rsi,rsi
       je        short M09_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M09_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M09_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF809259F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7A95D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7A95D5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L01:
       test      rsi,rsi
       je        short M09_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M09_L03
M09_L02:
       mov       rax,202E45F0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L04:
       call      qword ptr [7FF7A9ED4F30]
       int       3
; Total bytes of code 231
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFFFEC1CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M10_L01
       cmp       [rax],ecx
       jle       short M10_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M10_L03
M10_L00:
       add       rsp,20
       pop       rbx
       ret
M10_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M10_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M10_L00
M10_L02:
       cmp       [rax+4],edx
       jle       short M10_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M10_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M10_L03
       jmp       short M10_L00
M10_L03:
       mov       ecx,ebx
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFFFEC047E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFFFEC1B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M11_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFFFEC1CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L00:
       call      qword ptr [7FFFFEC1A3D0]
       int       3
; Total bytes of code 61
```

