## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1E46CC00740
       mov       rdi,[rcx]
       mov       [rsp+48],rdi
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rcx,rdi
       call      qword ptr [7FF8247B7588]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rbp,rax
       mov       [rsp+40],rbp
       cmp       [rbp],bpl
       mov       r14,224EBCBA7F8
       mov       [rsp+38],r14
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,7FF883B29D00
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FF883E53B10],0
       jne       near ptr M00_L07
M00_L00:
       cmp       ebx,0F
       je        near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,7FF883B29D00
       call      rax
       movzx     ebx,al
       mov       r14,[rsp+38]
       cmp       dword ptr [7FF883E53B10],0
       jne       near ptr M00_L08
M00_L01:
       cmp       ebx,10
       je        near ptr M00_L11
       mov       rcx,r14
       call      qword ptr [7FF823E5A398]; System.RuntimeType.get_IsByRefLike()
       test      eax,eax
       jne       near ptr M00_L11
       mov       rcx,r14
       call      qword ptr [7FF823F1C6A8]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L09
M00_L02:
       test      rcx,rcx
       je        near ptr M00_L10
       call      00007FF883AA4ED0
       test      eax,eax
       jne       near ptr M00_L11
       mov       dword ptr [rsp+20],1
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       rcx,[rsp+40]
       mov       r14,224EBCBA7F8
       mov       rdx,r14
       mov       r8d,1
       call      qword ptr [7FF8243CCAE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FF8247BD650]; System.Text.Json.JsonSerializer.ReadFromSpanAsObject(System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
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
       call      qword ptr [7FF824986340]
       int       3
M00_L06:
       mov       ecx,3888
       mov       rdx,7FF8243DF2D8
       call      qword ptr [7FF824137798]
       mov       rcx,rax
       call      qword ptr [7FF8248A6D90]
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
       call      qword ptr [7FF8248A7918]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8248A6700]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       ecx,3C7C
       mov       rdx,7FF8243DF2D8
       call      qword ptr [7FF824137798]
       mov       rcx,rax
       mov       r14,224EBCBA7F8
       mov       rdx,r14
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF8249854B8]
       int       3
M00_L12:
       mov       rcx,rbx
       call      qword ptr [7FF8244B67D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
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
       call      qword ptr [7FF8243C4B10]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF82474EE50]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FF8249854A0]
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
       jne       short M03_L07
       mov       [rsp+20],rbx
       mov       rcx,[rbx+18]
       mov       rax,7FF883B29D00
       call      rax
       movzx     ebx,al
       mov       rdi,[rsp+20]
       cmp       dword ptr [7FF883E53B10],0
       jne       short M03_L05
M03_L01:
       cmp       ebx,1D
       ja        short M03_L02
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       short M03_L06
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
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rdi,rax
       mov       rbx,rdi
       jmp       short M03_L00
M03_L05:
       call      CORINFO_HELP_POLL_GC
       jmp       short M03_L01
M03_L06:
       mov       ebp,1
       jmp       short M03_L03
M03_L07:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       ebp,eax
       mov       rdi,rbx
       jmp       short M03_L03
; Total bytes of code 163
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
       je        near ptr M04_L11
M04_L00:
       mov       [rbp-50],r8
       mov       rbx,[r8+8]
       mov       rax,1E456C01960
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M04_L12
M04_L01:
       mov       [rbp-58],rbx
       mov       rax,[rbp+18]
       mov       rdx,rax
       cmp       [rbx],bl
       test      rdx,rdx
       je        near ptr M04_L10
       mov       rdi,[rbx+8]
       mov       r10,[rdi+8]
       cmp       byte ptr [rbx+19],0
       je        near ptr M04_L13
       mov       rcx,rdx
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+18]
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
       mov       ecx,1
       mov       rdx,7FF82428E998
       call      qword ptr [7FF824137798]
       mov       rcx,rax
       call      qword ptr [7FF8244B6550]
       int       3
M04_L11:
       call      qword ptr [7FF8243CCAF8]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       r8,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M04_L00
M04_L12:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FF823E5D050
       call      qword ptr [7FF823F16E98]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,1E456C01960
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       jmp       near ptr M04_L01
M04_L13:
       mov       rcx,r10
       mov       r11,7FF823E61098
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M04_L02
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
       mov       r11,7FF823E610A0
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
       call      qword ptr [7FF8248A6D90]
       int       3
M04_L19:
       mov       rcx,r14
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M04_L20
       mov       rcx,r14
       call      qword ptr [7FF8248A7AC8]
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
       mov       r11,7FF823E610B0
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
       mov       r11,7FF823E610B8
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
       call      qword ptr [7FF823F16850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      00007FF883B9DA10
       test      eax,eax
       je        short M04_L32
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8248A76D8]
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
       call      qword ptr [7FF8248A6D90]
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
       call      qword ptr [7FF8246D4288]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
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
       call      qword ptr [7FF8248AEA78]
       int       3
M04_L39:
       mov       rcx,[rbp-50]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-60]
       call      qword ptr [7FF8248AEA90]
       mov       rbx,rax
       jmp       near ptr M04_L07
M04_L40:
       mov       rcx,rbx
       call      qword ptr [7FF8244B67D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M04_L08
M04_L41:
       cmp       byte ptr [rbp+30],0
       je        near ptr M04_L08
       mov       rdx,[rbp+18]
       call      qword ptr [7FF8243CD098]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       jmp       near ptr M04_L08
M04_L42:
       cmp       byte ptr [rbp+29],0
       je        near ptr M04_L09
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+20]
       mov       rcx,[rbp+18]
       call      qword ptr [7FF8248AE520]
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
       call      qword ptr [7FF8248A6D90]
       int       3
M04_L45:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L46:
       mov       rcx,r14
       call      00007FF883B9DA10
       test      eax,eax
       je        short M04_L47
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF8248A76D8]
M04_L47:
       nop
       add       rsp,28
       ret
; Total bytes of code 1573
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
       mov       rax,519858BCC47C
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
       mov       rcx,1E456C01E08
       mov       r14,[rcx]
       mov       r15,r14
       lea       r13d,[rdi+rdi*2]
       mov       rcx,1E456C00C90
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
       call      qword ptr [7FF8243C7F30]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
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
       call      qword ptr [7FF824535410]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
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
       call      qword ptr [7FF824087198]
       int       3
M05_L08:
       mov       ecx,38A0
       mov       rdx,7FF8243DF2D8
       call      qword ptr [7FF824137798]
       mov       rcx,rax
       call      qword ptr [7FF824984B58]
       int       3
M05_L09:
       mov       ecx,38A0
       mov       rdx,7FF8243DF2D8
       call      qword ptr [7FF824137798]
       mov       rcx,rax
       call      qword ptr [7FF824984B70]
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
       mov       r8,519858BCC47C
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
       call      qword ptr [7FF8243C7390]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       jmp       near ptr M05_L03
M05_L17:
       mov       ecx,0A
       call      qword ptr [7FF8248A7588]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M05_L01
M05_L18:
       mov       [rbp+30],r8
       mov       rcx,r8
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13,[rbp+30]
       mov       eax,[r13+8]
       mov       [rbp+224],eax
       mov       rcx,r14
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r14d,[rbp+234]
       mov       [rsp+20],r14d
       mov       edx,r15d
       mov       r8d,[rbp+224]
       mov       rcx,r12
       call      qword ptr [7FF8247BDC08]
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
       call      qword ptr [7FF8246DF240]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FF8244BD890]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF823F16820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+228],eax
       mov       rcx,r15
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rbp+234]
       mov       [rsp+20],r15d
       mov       edx,r14d
       mov       r8d,[rbp+228]
       mov       rcx,r12
       call      qword ptr [7FF8247BDC08]
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
       mov       r8,224EBCA62A0
       jmp       near ptr M05_L02
M05_L32:
       mov       ecx,r13d
       mov       rdx,224EBCA6F28
       call      qword ptr [7FF82413D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FF824617B88]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M05_L35:
       cmp       byte ptr [r12+9D],0
       je        near ptr M05_L37
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+230],eax
       mov       rcx,r15
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,[rbp+230]
       mov       rcx,r12
       call      qword ptr [7FF8247BDC08]
       mov       eax,[r13+8]
       mov       [rbp+22C],eax
       mov       rcx,r15
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF8247BDC50]
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
       call      qword ptr [7FF823F157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,1E456C01E08
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
       jle       short M05_L40
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       jne       short M05_L41
M05_L40:
       mov       ecx,0A
       call      qword ptr [7FF8248A7588]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M05_L41:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M05_L42
       mov       rcx,rbx
       call      qword ptr [7FF82461FAC8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
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
       call      qword ptr [7FF8247BDFF8]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FF823E54000
       call      qword ptr [7FF824137798]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF824336070]
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
       call      qword ptr [7FF824985380]
M05_L44:
       mov       r14,[rax+8]
       call      qword ptr [7FF8246DF240]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FF8244BD890]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF823F16820]; System.Threading.Monitor.Exit(System.Object)
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
       mov       rcx,1E456C00C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       je        near ptr M05_L58
       mov       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       je        near ptr M05_L58
       mov       rcx,[rbp+40]
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp+40]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FF8248AFA68]
       test      r14d,edi
       jne       short M05_L58
       mov       rcx,[rbp+40]
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,[rbp+40]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF8247BE070]
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
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FF8248A7AC8]
M06_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M06_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M06_L03
       mov       rcx,7FF8249493C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF8244B67F0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M06_L04
M06_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8248A6D90]
       int       3
M06_L03:
       mov       rcx,7FF8249493BC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF8248AEA78]
       int       3
M06_L04:
       mov       rcx,7FF8249493C4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FF883B9DA10
       test      eax,eax
       jne       near ptr M06_L10
M06_L05:
       mov       rcx,7FF8249493C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF8249493CC
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L06:
       call      qword ptr [7FF8248AF030]
       int       3
M06_L07:
       mov       rcx,7FF8249493B8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF8248AEA78]
       int       3
M06_L08:
       mov       rcx,rbx
       call      qword ptr [7FF8243CCB28]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M06_L09
       call      qword ptr [7FF8248A72A0]
       int       3
M06_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF883B19D60
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M06_L00
M06_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF8248A76D8]
       jmp       near ptr M06_L05
       sub       rsp,28
       call      qword ptr [7FF8248AF048]
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
       mov       rcx,7FF8249493C4
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M06_L11
       xor       ecx,ecx
       call      qword ptr [7FF8248A6D90]
       int       3
M06_L11:
       mov       rcx,[rbp-20]
       call      00007FF883B9DA10
       test      eax,eax
       je        short M06_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF8248A76D8]
M06_L12:
       mov       rcx,7FF8249493C8
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

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,0A8
       vzeroupper
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+140]
       mov       [rbp-68],r8
       mov       rbx,2B5A170FFC0
       mov       [rbp-0B8],rbx
       mov       rax,2750C802728
       mov       rax,[rax]
       mov       [rbp-70],rax
       test      r8,r8
       je        near ptr M00_L21
       mov       rsi,[rax+8]
       test      rsi,rsi
       je        near ptr M00_L22
M00_L00:
       mov       [rbp-78],rsi
       mov       rsi,[rbp-78]
       cmp       [rsi],sil
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       mov       rdx,7FF883B29D00
       call      rdx
       movzx     ebx,al
       cmp       dword ptr [7FF883E53B10],0
       jne       near ptr M00_L23
M00_L01:
       cmp       ebx,0F
       je        near ptr M00_L31
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       mov       rax,7FF883B29D00
       call      rax
       movzx     ebx,al
       mov       rsi,[rbp-0B8]
       cmp       dword ptr [7FF883E53B10],0
       jne       near ptr M00_L24
M00_L02:
       cmp       ebx,10
       je        near ptr M00_L31
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       mov       ecx,[rcx]
       and       ecx,80001000
       cmp       ecx,1000
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L31
M00_L03:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M00_L28
       mov       [rbp-80],rsi
       mov       rcx,[rsi+18]
       mov       rax,7FF883B29D00
       call      rax
       movzx     ebx,al
       mov       rsi,[rbp-80]
       cmp       dword ptr [7FF883E53B10],0
       jne       near ptr M00_L26
M00_L04:
       cmp       ebx,1D
       ja        short M00_L05
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M00_L27
M00_L05:
       cmp       ebx,10
       sete      dil
       movzx     edi,dil
M00_L06:
       test      edi,edi
       jne       near ptr M00_L25
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M00_L29
M00_L07:
       test      rsi,rsi
       je        near ptr M00_L30
       mov       rcx,rsi
       call      00007FF883AA4ED0
       test      eax,eax
       jne       near ptr M00_L31
       mov       rsi,[rbp-78]
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L60
       mov       rbx,[rsi+8]
       test      rbx,rbx
       je        near ptr M00_L32
M00_L08:
       mov       rsi,[rbx+8]
       mov       rcx,2750C801960
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L33
M00_L09:
       mov       [rbp-88],rsi
       mov       rcx,[rbp-88]
       cmp       [rcx],cl
       mov       rsi,[rcx+8]
       mov       rax,[rsi+8]
       cmp       byte ptr [rcx+19],0
       je        near ptr M00_L34
       mov       rcx,2B5A170FFC0
       mov       rax,[7FF823E3A1C0]
       call      qword ptr [rax+18]
       mov       r14d,eax
M00_L10:
       mov       r15,[rsi+8]
       mov       rcx,[rsi+10]
       mov       edx,r14d
       imul      rdx,[rsi+28]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M00_L65
       mov       edx,edx
       mov       r13,[rcx+rdx*8+10]
       test      r13,r13
       je        near ptr M00_L38
M00_L11:
       cmp       r14d,[r13+20]
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
       mov       rcx,2B5A170FFC0
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
       jne       near ptr M00_L59
       mov       rcx,[rbp-90]
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        short M00_L14
       cmp       byte ptr [rbx+119],2
       jne       short M00_L18
M00_L14:
       test      rbx,rbx
       je        near ptr M00_L61
       cmp       byte ptr [rbx+119],2
       jne       short M00_L19
M00_L15:
       mov       r8,[rbp-68]
       lea       rcx,[r8+0C]
       mov       edx,[r8+8]
       mov       [rbp-60],rcx
       mov       [rbp-58],edx
       lea       rcx,[rbp-60]
       mov       rdx,rbx
       call      qword ptr [7FF824775758]; System.Text.Json.JsonSerializer.ReadFromSpanAsObject(System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       test      rax,rax
       jne       short M00_L20
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
M00_L18:
       mov       rcx,rbx
       call      qword ptr [7FF8244967D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       short M00_L14
M00_L19:
       mov       rcx,rbx
       call      qword ptr [7FF8244967D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       short M00_L15
M00_L20:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       cmp       [rax],rcx
       jne       short M00_L16
       mov       [rbp-50],rax
       jmp       short M00_L17
M00_L21:
       mov       ecx,3888
       mov       rdx,7FF8243BF2D8
       call      qword ptr [7FF824117798]
       mov       rcx,rax
       call      qword ptr [7FF8247E4CC0]
       int       3
M00_L22:
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF8243A4B10]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,[rbp-70]
       call      qword ptr [7FF824707228]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FF8247E69E8]
       mov       rdx,[rbp-70]
       lea       rcx,[rdx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L23:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L01
M00_L24:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L26:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L27:
       mov       edi,1
       jmp       near ptr M00_L06
M00_L28:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       near ptr M00_L06
M00_L29:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rsi,rax
       jmp       near ptr M00_L07
M00_L30:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8247E6A48]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8247E6A60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L31:
       mov       ecx,3C7C
       mov       rdx,7FF8243BF2D8
       call      qword ptr [7FF824117798]
       mov       rcx,rax
       mov       rdx,2B5A170FFC0
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF8247E6A00]
       int       3
M00_L32:
       mov       rcx,rsi
       call      qword ptr [7FF8243ACAF8]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M00_L08
M00_L33:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FF823E3D050
       call      qword ptr [7FF823EF6E98]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,2750C801960
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L09
M00_L34:
       mov       rcx,rax
       mov       rdx,2B5A170FFC0
       mov       r11,7FF823E40D70
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L10
M00_L35:
       mov       rcx,r12
       mov       rdx,2B5A170FFC0
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
       mov       r8,2B5A170FFC0
       mov       rdx,r12
       mov       r11,7FF823E40D78
       call      qword ptr [r11]
       jmp       near ptr M00_L12
M00_L38:
       xor       edx,edx
       mov       [rbp-90],rdx
       mov       [rbp-98],rsi
       mov       rdx,2B5A170FFC0
       mov       r8,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       [rbp-0B0],rax
       mov       rax,[rsi+8]
       mov       [rbp-0A0],rax
       mov       [rbp-3C],r14d
M00_L39:
       mov       rax,[rbp-98]
       mov       rax,[rax+18]
       mov       [rbp-0A8],rax
       mov       rax,[rbp-98]
       mov       rcx,[rax+10]
       mov       rax,[rbp-98]
       mov       r8d,[rbp-3C]
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
       mov       [rbp-40],edx
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L65
       mov       eax,r8d
       lea       rbx,[rcx+rax*8+10]
       xor       esi,esi
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-44],ecx
       mov       rcx,[rbp-0A8]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M00_L48
       mov       rcx,[rbp-0A8]
       mov       eax,[rbp-40]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       short M00_L40
       xor       ecx,ecx
       call      qword ptr [7FF8247E4CC0]
       int       3
M00_L40:
       mov       rcx,r14
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M00_L41
       mov       rcx,r14
       call      qword ptr [7FF8247E4D08]
M00_L41:
       mov       dword ptr [rbp-44],1
       mov       rdx,[rbp-98]
       mov       rcx,[rbp-88]
       cmp       rdx,[rcx+8]
       je        near ptr M00_L44
       mov       rcx,[rbp-88]
       mov       rax,[rcx+8]
       mov       [rbp-98],rax
       mov       rax,[rbp-0A0]
       mov       rdx,[rbp-98]
       cmp       rax,[rdx+8]
       je        near ptr M00_L55
       mov       rax,[rbp-98]
       mov       rax,[rax+8]
       mov       [rbp-0A0],rax
       cmp       byte ptr [rcx+19],0
       jne       short M00_L42
       mov       rcx,[rbp-0A0]
       mov       rdx,2B5A170FFC0
       mov       r11,7FF823E40D88
       call      qword ptr [r11]
       jmp       short M00_L43
M00_L42:
       mov       rcx,2B5A170FFC0
       mov       rax,[7FF823E3A1C0]
       call      qword ptr [rax+18]
M00_L43:
       mov       [rbp-3C],eax
       mov       rcx,[rbp-88]
       jmp       near ptr M00_L55
M00_L44:
       xor       r14d,r14d
       mov       r15,[rbx]
       test      r15,r15
       je        short M00_L50
M00_L45:
       mov       edx,[rbp-3C]
       cmp       edx,[r15+20]
       jne       short M00_L46
       mov       rdx,[r15+8]
       mov       rcx,[rbp-0A0]
       mov       r8,2B5A170FFC0
       mov       r11,7FF823E40D90
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L47
M00_L46:
       inc       r14d
       mov       r15,[r15+18]
       test      r15,r15
       jne       short M00_L45
       jmp       short M00_L50
M00_L47:
       mov       rax,[r15+10]
       mov       [rbp-90],rax
       jmp       near ptr M00_L56
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
       mov       r13,[rbx]
       mov       rcx,2B5A170FFC0
       mov       [r15+8],rcx
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0B0]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-3C]
       mov       [r15+20],ecx
       mov       rcx,rbx
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-98]
       mov       rdx,[rdx+20]
       mov       ecx,[rdx+8]
       cmp       [rbp-40],ecx
       jae       short M00_L48
       mov       ecx,[rbp-40]
       lea       rdx,[rdx+rcx*4+10]
       mov       ecx,[rdx]
       add       ecx,1
       jo        short M00_L49
       mov       [rdx],ecx
       mov       rdx,[rbp-98]
       mov       rdx,[rdx+20]
       mov       ecx,[rdx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M00_L48
       mov       ecx,[rbp-40]
       mov       edx,[rdx+rcx*4+10]
       mov       rcx,[rbp-88]
       cmp       edx,[rcx+10]
       jle       short M00_L51
       mov       esi,1
M00_L51:
       cmp       r14d,64
       jbe       short M00_L52
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       ecx,1
       test      rax,rax
       cmovne    edi,ecx
M00_L52:
       mov       rax,[rbp-0A8]
       mov       edx,[rbp-40]
       mov       rax,[rax+rdx*8+10]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L53
       xor       ecx,ecx
       call      qword ptr [7FF8247E4CC0]
       int       3
M00_L53:
       mov       rcx,rbx
       call      00007FF883B9DA10
       test      eax,eax
       je        short M00_L54
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF8247E4CD8]
M00_L54:
       mov       ecx,esi
       or        ecx,edi
       je        short M00_L58
       jmp       short M00_L57
M00_L55:
       call      M00_L66
       jmp       near ptr M00_L39
M00_L56:
       call      M00_L66
       jmp       near ptr M00_L13
M00_L57:
       mov       rcx,[rbp-88]
       mov       rdx,[rbp-98]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FF82460C690]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
M00_L58:
       mov       r8,[rbp-0B0]
       mov       [rbp-90],r8
       jmp       near ptr M00_L13
M00_L59:
       call      qword ptr [7FF8247E6AA8]
       int       3
M00_L60:
       mov       rcx,rsi
       mov       rdx,2B5A170FFC0
       call      qword ptr [7FF8243AD098]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       jmp       near ptr M00_L14
M00_L61:
       mov       rcx,2B5A171B9D8
       call      qword ptr [7FF8247E68C8]
       mov       rbx,rax
       mov       rcx,[rbp-70]
       call      qword ptr [7FF823EFC9A8]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L62
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L62
       jmp       short M00_L63
M00_L62:
       mov       rcx,rax
       call      qword ptr [7FF823EF7C30]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
M00_L63:
       mov       rsi,[rcx+30]
       test      rsi,rsi
       jne       short M00_L64
       lea       rdx,[rcx+30]
       mov       r8d,1
       call      qword ptr [7FF824064AF8]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
M00_L64:
       mov       rcx,2B5A1712DA8
       test      rsi,rsi
       cmove     rsi,rcx
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rbx
       mov       rdx,2B5A170FFC0
       mov       r8,rsi
       call      qword ptr [7FF824774828]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF824315FC8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L65:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L66:
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp-44],0
       je        short M00_L67
       mov       rcx,[rbp-0A8]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       short M00_L69
       mov       rcx,[rbp-0A8]
       mov       eax,[rbp-40]
       mov       rsi,[rcx+rax*8+10]
       test      rsi,rsi
       je        short M00_L68
       mov       rcx,rsi
       call      00007FF883B9DA10
       test      eax,eax
       je        short M00_L67
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF8247E4CD8]
M00_L67:
       nop
       add       rsp,28
       ret
M00_L68:
       xor       ecx,ecx
       call      qword ptr [7FF8247E4CC0]
       int       3
M00_L69:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2529
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
       mov       rax,546007A0E773
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
       mov       rcx,2750C801DE0
       mov       r14,[rcx]
       mov       r15,r14
       lea       r13d,[rdi+rdi*2]
       mov       rcx,2750C800C90
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
       call      qword ptr [7FF8243A7F30]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
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
       call      qword ptr [7FF824515410]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
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
       call      qword ptr [7FF824067198]
       int       3
M01_L08:
       mov       ecx,38A0
       mov       rdx,7FF8243BF2D8
       call      qword ptr [7FF824117798]
       mov       rcx,rax
       call      qword ptr [7FF8247E6B50]
       int       3
M01_L09:
       mov       ecx,38A0
       mov       rdx,7FF8243BF2D8
       call      qword ptr [7FF824117798]
       mov       rcx,rax
       call      qword ptr [7FF8247E6B68]
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
       mov       r8,546007A0E773
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
       call      qword ptr [7FF8243A7390]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       jmp       near ptr M01_L03
M01_L17:
       mov       ecx,0A
       call      qword ptr [7FF8247E5B48]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L18:
       mov       [rbp+30],r8
       mov       rcx,r8
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13,[rbp+30]
       mov       eax,[r13+8]
       mov       [rbp+224],eax
       mov       rcx,r14
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r14d,[rbp+234]
       mov       [rsp+20],r14d
       mov       edx,r15d
       mov       r8d,[rbp+224]
       mov       rcx,r12
       call      qword ptr [7FF824775D10]
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
       call      qword ptr [7FF824697648]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FF82449D890]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF823EF6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+228],eax
       mov       rcx,r15
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rbp+234]
       mov       [rsp+20],r15d
       mov       edx,r14d
       mov       r8d,[rbp+228]
       mov       rcx,r12
       call      qword ptr [7FF824775D10]
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
       mov       r8,2B5A17062A0
       jmp       near ptr M01_L02
M01_L32:
       mov       ecx,r13d
       mov       rdx,2B5A1706F28
       call      qword ptr [7FF82411D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FF82451FE88]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M01_L35:
       cmp       byte ptr [r12+9D],0
       je        near ptr M01_L37
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+230],eax
       mov       rcx,r15
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,[rbp+230]
       mov       rcx,r12
       call      qword ptr [7FF824775D10]
       mov       eax,[r13+8]
       mov       [rbp+22C],eax
       mov       rcx,r15
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF824775D58]
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
       call      qword ptr [7FF823EF57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,2750C801DE0
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
       call      qword ptr [7FF8247E5B48]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M01_L41:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M01_L42
       mov       rcx,rbx
       call      qword ptr [7FF824607ED0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
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
       call      qword ptr [7FF824776118]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FF823E34000
       call      qword ptr [7FF824117798]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF824316070]
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
       call      qword ptr [7FF8247E7AC8]
M01_L44:
       mov       r14,[rax+8]
       call      qword ptr [7FF824697648]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FF82449D890]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF823EF6820]; System.Threading.Monitor.Exit(System.Object)
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
       mov       rcx,2750C800C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       je        near ptr M01_L58
       mov       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L58
       mov       rcx,[rbp+40]
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp+40]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FF8247E4D20]
       test      r14d,edi
       jne       short M01_L58
       mov       rcx,[rbp+40]
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,[rbp+40]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF824776190]
M01_L58:
       nop
       add       rsp,38
       ret
; Total bytes of code 2450
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
       je        near ptr M02_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       near ptr M02_L07
M02_L00:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+0B8]
       mov       rbx,[rax+8]
       test      rbx,rbx
       je        near ptr M02_L08
M02_L01:
       mov       [rbp-18],rbx
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,rbx
       call      qword ptr [7FF95510A180]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M02_L04
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF95510DEF0]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M02_L04
M02_L03:
       mov       rcx,rax
       call      qword ptr [7FF95510A218]
       jmp       short M02_L02
M02_L04:
       cmp       byte ptr [rbp-10],0
       je        short M02_L05
       mov       rcx,rbx
       call      qword ptr [7FF95510A188]; Precode of System.Threading.Monitor.Exit(System.Object)
M02_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
M02_L06:
       call      qword ptr [7FF95510BE50]
       int       3
M02_L07:
       mov       rcx,rax
       call      qword ptr [7FF95510A218]
       jmp       near ptr M02_L00
M02_L08:
       mov       rcx,rax
       call      qword ptr [7FF95510D528]; Precode of System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M02_L01
       sub       rsp,28
       call      qword ptr [7FF95510A210]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      qword ptr [7FF955107258]; CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-10],0
       je        short M02_L09
       mov       rcx,[rbp-18]
       call      qword ptr [7FF95510A188]; Precode of System.Threading.Monitor.Exit(System.Object)
M02_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 310
```
```assembly
; System.Text.Json.JsonSerializerOptions..ctor()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       dword ptr [rbx+7C],4000
       call      qword ptr [7FF9551074D8]
       movzx     ecx,byte ptr [rax+1]
       mov       [rbx+95],cl
       movzx     eax,byte ptr [rax+2]
       mov       [rbx+96],al
       mov       word ptr [rbx+90],20
       mov       dword ptr [rbx+84],2
       mov       byte ptr [rbx+9D],1
       mov       dword ptr [rbx+88],40
       call      qword ptr [7FF955107550]
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
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M04_L01:
       mov       rcx,[rcx+20]
       call      qword ptr [7FF955109688]
       mov       rcx,rax
       call      qword ptr [7FF95510BE70]
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
       call      qword ptr [7FF95510D580]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF95510B548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF955108CC8]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF95510D4E8]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M06_L00:
       mov       rax,[rbp-20]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FF955108CC8]
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FF95510A210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95510D570]
       mov       [rbp-20],rsi
       lea       rax,[M06_L00]
       add       rsp,28
       ret
; Total bytes of code 138
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
       call      qword ptr [7FF883967FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF881EB1D50]; Precode of System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF881EB1C10]
       mov       rdi,rax
       test      rdi,rdi
       je        short M09_L01
       mov       rcx,[rbp+10]
       mov       r13,[rcx]
       mov       rcx,r13
       call      qword ptr [7FF881EB1418]
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
       call      qword ptr [7FF881EB1298]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       call      qword ptr [7FF881EB2420]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetCountNoLocks()
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
       call      qword ptr [7FF881EB2098]; Precode of System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       call      qword ptr [7FF881EB1C40]; Precode of System.Array.get_MaxLength()
       cmp       eax,r14d
       jge       short M09_L04
M09_L03:
       call      qword ptr [7FF881EB1C40]; Precode of System.Array.get_MaxLength()
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
       call      qword ptr [7FF881EB1BF8]
       mov       rdi,rax
       mov       r8d,[rsi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF881EB1C28]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,[rbx+18]
       mov       esi,[rax+8]
       mov       r13d,[rdi+8]
       cmp       r13d,esi
       jle       short M09_L06
M09_L05:
       call      qword ptr [7FF881EB1B60]
       mov       r8,rax
       movsxd    rdx,esi
       mov       rcx,rdi
       call      qword ptr [7FF881EB1278]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       esi
       cmp       r13d,esi
       jg        short M09_L05
M09_L06:
       mov       rcx,[rbp+10]
       mov       r13,[rcx]
       mov       rcx,r13
       call      qword ptr [7FF881EB1780]
       mov       rcx,rax
       movsxd    rdx,r14d
       call      qword ptr [7FF881EB1290]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       ecx,[rdi+8]
       call      qword ptr [7FF881EB1C00]
       mov       r14,rax
       mov       r12,r15
       test      r12,r12
       jne       short M09_L07
       mov       r12,[rbx+8]
M09_L07:
       mov       rcx,r13
       call      qword ptr [7FF881EB1578]
       mov       rcx,rax
       call      qword ptr [7FF881EB1288]; CORINFO_HELP_NEWFAST
       mov       [rbp-78],rax
       lea       rcx,[rax+10]
       mov       rdx,rsi
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+18]
       mov       rdx,rdi
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+20]
       mov       rdx,r14
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rsi+8]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       r12,[rbp-78]
       mov       [r12+28],rax
       mov       rcx,r13
       call      qword ptr [7FF881EB1540]
       mov       rcx,rax
       lea       r8,[rbp-48]
       mov       rdx,rbx
       call      qword ptr [7FF881EB2440]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].AcquirePostFirstLock(Tables<System.__Canon,System.__Canon>, Int32 ByRef)
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
       call      qword ptr [7FF881EB18F0]
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
       call      qword ptr [7FF881EB1560]
       mov       rcx,rax
       call      qword ptr [7FF881EB1288]; CORINFO_HELP_NEWFAST
       mov       [rbp-88],rax
       mov       r8,[rbp-68]
       mov       rdx,[r8+8]
       mov       r8,[r8+10]
       mov       [rbp-90],r8
       mov       r10,[rbp-70]
       mov       r9,[r10]
       mov       [rbp-98],r9
       lea       rcx,[rax+8]
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-90]
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       lea       rcx,[rax+18]
       mov       rdx,[rbp-98]
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       mov       ecx,[rbp-4C]
       mov       [rax+20],ecx
       mov       rcx,[rbp-70]
       mov       rdx,rax
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF881EB1258]
       int       3
M09_L16:
       call      qword ptr [7FF881EB1250]
       int       3
M09_L17:
       mov       rcx,[rbp+10]
       mov       edx,[rbp-48]
       call      qword ptr [7FF881EB2450]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32)
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
       call      qword ptr [7FF881EB2450]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32)
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
       mov       rdi,[rbx+20]
M10_L00:
       test      rdi,rdi
       je        short M10_L02
       mov       rcx,rdi
       mov       r8,rbx
       mov       rdx,rsi
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       call      qword ptr [r11]
       mov       rbp,rax
       test      rbp,rbp
       je        short M10_L05
       mov       rcx,[rbp+0C0]
       mov       rdx,rsi
       call      qword ptr [7FF955109E40]; Precode of System.Type.op_Inequality(System.Type, System.Type)
       test      eax,eax
       jne       short M10_L03
       cmp       [rbp+0B8],rbx
       jne       short M10_L04
M10_L01:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L02:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L03:
       mov       rdx,[rbp+0C0]
       mov       rcx,rsi
       call      qword ptr [7FF95510BE40]
       int       3
M10_L04:
       call      qword ptr [7FF95510BE48]
       int       3
M10_L05:
       call      qword ptr [7FF9551075C0]
       mov       rdx,[rax]
       mov       rcx,rsi
       call      qword ptr [7FF955109E38]; Precode of System.Type.op_Equality(System.Type, System.Type)
       test      eax,eax
       je        short M10_L01
       call      qword ptr [7FF955108E88]
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF95510EC00]; Precode of System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       byte ptr [rbp+12],1
       lea       rcx,[rbp+30]
       mov       rdx,rdi
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF955108FC0]
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8,rbx
       call      qword ptr [7FF95510ED40]
       mov       rbp,rsi
       jmp       near ptr M10_L01
; Total bytes of code 224
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
       call      qword ptr [7FF823EF5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      00007FF883B35510
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
       mov       rax,7FF824031B50
       mov       [rbp-78],rax
       lea       rax,[M12_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF883A92CB0
       call      rax
M12_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF883E53B10],0
       je        short M12_L04
       call      qword ptr [7FF883E41648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF883B5BB40
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
       call      qword ptr [7FF8247EEFB8]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M12_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF8247ED638]
       jmp       near ptr M12_L00
M12_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M12_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF823EF7C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rcx,[rcx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       mov       edx,r8d
       call      qword ptr [7FF88397A1A8]; Precode of System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF883967FD8]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 64
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF882CF6998
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L13
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L12
       mov       rax,7FF882CF6998
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L13
M00_L01:
       test      rsi,rsi
       je        near ptr M00_L14
       mov       rcx,28859801E00
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+9F],0
       je        near ptr M00_L15
M00_L02:
       mov       rbp,[rdi+10]
       test      rbp,rbp
       je        short M00_L03
       mov       rcx,[rbp+0C0]
       mov       rax,2C8EE9410F0
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
       mov       rdx,2C8EE9410F0
       call      qword ptr [7FF8243BD020]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
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
       mov       rcx,7FF8247DE788
       call      qword ptr [7FF8247A7468]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       mov       rcx,2C8EE9410F0
       call      qword ptr [7FF8248AC018]
       int       3
M00_L09:
       call      qword ptr [7FF8243B4378]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L10
       call      qword ptr [7FF8247A7B70]
       mov       rbx,rax
M00_L10:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2C8EE94B4C0
       call      qword ptr [7FF8247A7B88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       call      qword ptr [7FF8246CDBA8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M00_L13
       jmp       near ptr M00_L00
M00_L12:
       call      qword ptr [7FF8246CDBA8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       je        near ptr M00_L01
M00_L13:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FF8248A4DE0]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L14:
       mov       ecx,3888
       mov       rdx,7FF8243CF2D8
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF8248A48A0]
       int       3
M00_L15:
       mov       rcx,rdi
       call      qword ptr [7FF8243B72D0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L02
M00_L16:
       mov       rcx,rdi
       call      qword ptr [7FF8243BCAF8]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rcx,rax
       jmp       near ptr M00_L04
M00_L17:
       call      qword ptr [7FF8248AC570]
       int       3
M00_L18:
       mov       rcx,rbp
       call      qword ptr [7FF8244A67D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L05
M00_L19:
       mov       rdx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L20:
       lea       rcx,[rsp+40]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FF824124E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
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
       vmovups   ymm0,[7FF824881B60]
       vmovups   [rdx],ymm0
       vmovups   ymm0,[7FF824881B80]
       vmovups   [rdx+20],ymm0
       vmovups   xmm0,[7FF824881BA0]
       vmovups   [rdx+40],xmm0
       mov       word ptr [rdx+50],20
       mov       ecx,[rsp+50]
       add       ecx,29
       mov       [rsp+50],ecx
       jmp       short M00_L22
M00_L21:
       lea       rcx,[rsp+40]
       mov       rdx,2C8EE94BC00
       call      qword ptr [7FF8247A4D08]
M00_L22:
       lea       rcx,[rsp+40]
       mov       rdx,7FF8246FF070
       mov       r8,2C8EE9410F0
       call      qword ptr [7FF82412E190]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ecx,[rsp+50]
       cmp       ecx,[rsp+60]
       jbe       short M00_L24
M00_L23:
       call      qword ptr [7FF824077198]
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
       mov       rdx,2C8EE930658
       call      qword ptr [7FF8247A4D08]
M00_L26:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rsp+40]
       call      qword ptr [7FF824124EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF824325FC8]
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
       mov       rcx,28859801960
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L03
M01_L00:
       mov       rcx,7FF824923A8C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       [rdi],dil
       test      rbx,rbx
       je        near ptr M01_L04
       mov       r15,[rdi+8]
       mov       rcx,[r15+8]
       cmp       byte ptr [rdi+19],0
       je        near ptr M01_L05
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r13d,eax
M01_L01:
       lea       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rbx
       mov       r9d,r13d
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      qword ptr [7FF824326658]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
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
       call      qword ptr [7FF82432C510]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
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
       mov       rcx,7FF824923A88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FF823E4D050
       call      qword ptr [7FF823F06E98]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,28859801960
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,1
       mov       rdx,7FF82427E998
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF8244A6550]
       int       3
M01_L05:
       mov       rdx,rbx
       mov       r11,7FF823E50E00
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L01
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
       mov       rax,7427F7E161F9
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
       mov       rcx,28859801E08
       mov       r14,[rcx]
       mov       r15,r14
       lea       r13d,[rdi+rdi*2]
       mov       rcx,28859800C90
       mov       r12,[rcx]
       lea       ecx,[r13-1]
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rbp+234],eax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
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
       call      qword ptr [7FF8243B7F30]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
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
       call      qword ptr [7FF824525410]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
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
       call      qword ptr [7FF8245254A0]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rax,[rbp+80]
       xor       ecx,ecx
       mov       [rbp+80],rcx
       mov       [rbp+30],rax
       jmp       near ptr M02_L13
M02_L07:
       call      qword ptr [7FF824077198]
       int       3
M02_L08:
       mov       ecx,38A0
       mov       rdx,7FF8243CF2D8
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF8248AEA60]
       int       3
M02_L09:
       mov       ecx,38A0
       mov       rdx,7FF8243CF2D8
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF8248AEA78]
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
       mov       r8,7427F7E161F9
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
       call      qword ptr [7FF8243B7390]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       jmp       near ptr M02_L03
M02_L17:
       mov       ecx,0A
       call      qword ptr [7FF8248A5098]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M02_L01
M02_L18:
       mov       [rbp+28],r8
       mov       rcx,r8
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13,[rbp+28]
       mov       eax,[r13+8]
       mov       [rbp+224],eax
       mov       rcx,r14
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r14d,[rbp+234]
       mov       [rsp+20],r14d
       mov       edx,r15d
       mov       r8d,[rbp+224]
       mov       rcx,r12
       call      qword ptr [7FF8247A7948]
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
       call      qword ptr [7FF8246CF240]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FF8244AD890]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF823F06820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+228],eax
       mov       rcx,r15
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rbp+234]
       mov       [rsp+20],r15d
       mov       edx,r14d
       mov       r8d,[rbp+228]
       mov       rcx,r12
       call      qword ptr [7FF8247A7948]
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
       mov       r8,2C8EE9362A0
       jmp       near ptr M02_L02
M02_L32:
       mov       ecx,r13d
       mov       rdx,2C8EE936F28
       call      qword ptr [7FF82412D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FF824607B88]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M02_L35:
       cmp       byte ptr [r12+9D],0
       je        near ptr M02_L37
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+230],eax
       mov       rcx,r15
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,[rbp+230]
       mov       rcx,r12
       call      qword ptr [7FF8247A7948]
       mov       eax,[r13+8]
       mov       [rbp+22C],eax
       mov       rcx,r15
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF8247A7990]
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
       call      qword ptr [7FF823F057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,28859801E08
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
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0A
       jle       short M02_L40
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       jne       short M02_L41
M02_L40:
       mov       ecx,0A
       call      qword ptr [7FF8248A5098]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M02_L41:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L42
       mov       rcx,rbx
       call      qword ptr [7FF82460FAC8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
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
       call      qword ptr [7FF8247A7D20]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF824326070]
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
       call      qword ptr [7FF8248AF468]
M02_L44:
       mov       r14,[rax+8]
       call      qword ptr [7FF8246CF240]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FF8244AD890]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF823F06820]; System.Threading.Monitor.Exit(System.Object)
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
       mov       rcx,28859800C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       je        near ptr M02_L58
       mov       rcx,[rbp+38]
       cmp       dword ptr [rcx+8],0
       je        near ptr M02_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp+38]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FF8248AD578]
       test      r14d,edi
       jne       short M02_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,[rbp+38]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF8247A7D98]
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
       call      qword ptr [7FF9551074E0]
       cmp       byte ptr [rax],0
       je        near ptr M04_L03
       call      qword ptr [7FF95510DBE0]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M04_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
M04_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       call      qword ptr [7FF955109688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M04_L00
       call      qword ptr [7FF9551074D8]
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
       call      qword ptr [7FF95510F2E0]
       lea       rcx,[rsp+20]
       call      qword ptr [7FF95510DC10]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF95510D4D8]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
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
       call      qword ptr [7FF9551096A0]
       test      rax,rax
       je        near ptr M04_L00
M04_L04:
       call      qword ptr [7FF95510BE58]
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
       call      qword ptr [7FF95510D580]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF95510B548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FF8248A55D8]
M06_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M06_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M06_L03
       mov       rcx,7FF82492BC20
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF8244A67F0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M06_L04
M06_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8248A48A0]
       int       3
M06_L03:
       mov       rcx,7FF82492BC1C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF8248AC570]
       int       3
M06_L04:
       mov       rcx,7FF82492BC24
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FF883B9DA10
       test      eax,eax
       jne       near ptr M06_L10
M06_L05:
       mov       rcx,7FF82492BC28
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF82492BC2C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L06:
       call      qword ptr [7FF8248ACB40]
       int       3
M06_L07:
       mov       rcx,7FF82492BC18
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF8248AC570]
       int       3
M06_L08:
       mov       rcx,rbx
       call      qword ptr [7FF8243BCB28]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M06_L09
       call      qword ptr [7FF8248A4DB0]
       int       3
M06_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF883B19D60
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M06_L00
M06_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF8248A51E8]
       jmp       near ptr M06_L05
       sub       rsp,28
       call      qword ptr [7FF8248ACB58]
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
       mov       rcx,7FF82492BC24
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M06_L11
       xor       ecx,ecx
       call      qword ptr [7FF8248A48A0]
       int       3
M06_L11:
       mov       rcx,[rbp-20]
       call      00007FF883B9DA10
       test      eax,eax
       je        short M06_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF8248A51E8]
M06_L12:
       mov       rcx,7FF82492BC28
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
       jmp       qword ptr [7FF823F0FD08]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       mov       rcx,28859800C88
       mov       rsi,[rcx]
       imul      ecx,r8d,0B
       add       ecx,edx
       mov       edi,100
       cmp       ecx,100
       cmovg     edi,ecx
       mov       rcx,rsi
       mov       rdx,7FF82494CA78
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
       jne       near ptr M09_L05
       test      rsi,rsi
       je        near ptr M09_L06
       mov       rcx,rsi
       call      qword ptr [7FF883976148]
       test      rax,rax
       jne       short M09_L01
       mov       rcx,rsi
       lea       r11,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       call      qword ptr [r11]
       mov       rdx,rax
M09_L00:
       test      rdx,rdx
       je        near ptr M09_L06
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        near ptr M09_L07
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        near ptr M09_L08
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FF88397C900]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       jmp       near ptr M09_L06
M09_L01:
       mov       rcx,rsi
       call      qword ptr [7FF883976180]
       test      rax,rax
       je        near ptr M09_L04
       mov       rcx,rsi
       call      qword ptr [7FF8839773C0]
       mov       rsi,rax
M09_L02:
       mov       rcx,rsi
       lea       rdx,[rbx+18]
       mov       r9d,[rbx+10]
       mov       r8d,[rdx+8]
       cmp       r9d,r8d
       ja        near ptr M09_L07
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
       jne       short M09_L03
       mov       rcx,rbx
       call      qword ptr [7FF883983FC0]
       jmp       short M09_L02
M09_L03:
       mov       ecx,[rsp+48]
       add       [rbx+10],ecx
       jmp       short M09_L06
M09_L04:
       mov       rcx,rsi
       call      qword ptr [7FF8839773B8]
       mov       rcx,rax
       mov       r8,[rbx]
       lea       r11,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M09_L00
M09_L05:
       call      qword ptr [7FF88396F0C8]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF883993628]
M09_L06:
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M09_L07:
       call      qword ptr [7FF88397E290]
       int       3
M09_L08:
       mov       rcx,rbx
       call      qword ptr [7FF883983F98]
       jmp       short M09_L06
; Total bytes of code 397
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
       lea       rsi,[rbx+18]
       mov       rcx,rsi
       mov       eax,[rbx+10]
       cmp       eax,[rcx+8]
       ja        near ptr M10_L13
       mov       rcx,[rcx]
       mov       [rsp+48],rcx
       mov       [rsp+50],eax
       lea       rcx,[rsp+48]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rbp,[rbx+8]
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       [rsi],rcx
       mov       [rsi+8],rcx
       mov       [rbx+10],ecx
       test      rbp,rbp
       je        near ptr M10_L03
       mov       rcx,28859800C88
       mov       rbx,[rcx]
       mov       ecx,[rbp+8]
       dec       ecx
       or        ecx,0F
       xor       esi,esi
       lzcnt     esi,ecx
       xor       esi,1F
       add       esi,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
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
       cmp       ecx,esi
       jbe       short M10_L02
       mov       r14d,1
       mov       ecx,10
       shlx      ecx,ecx,esi
       cmp       [rbp+8],ecx
       jne       near ptr M10_L16
       mov       ecx,esi
       shl       rcx,4
       lea       r13,[rax+rcx+10]
       mov       r12,[r13]
       mov       rcx,r13
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],ecx
       test      r12,r12
       jne       short M10_L04
M10_L02:
       mov       rcx,28859800C90
       mov       r13,[rcx]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M10_L22
M10_L03:
       mov       rax,rdi
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
       cmp       esi,[rcx+8]
       jae       near ptr M10_L25
       mov       edx,esi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       je        near ptr M10_L17
M10_L05:
       mov       r15,[rax+8]
       call      qword ptr [7FF8246CF240]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M10_L07
       mov       rcx,[rsp+38]
       call      qword ptr [7FF8248A55D8]
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
       call      00007FF883B9DA10
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
       call      qword ptr [7FF824077198]
       int       3
M10_L14:
       mov       ecx,3
       call      qword ptr [7FF8248A5098]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M10_L00
M10_L15:
       mov       rcx,rbx
       call      qword ptr [7FF82412CE88]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M10_L01
M10_L16:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF8247A7D20]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FF824326070]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M10_L17:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF8246CF108]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
       jmp       near ptr M10_L05
M10_L18:
       mov       ecx,eax
       mov       rdx,[rsp+38]
       call      qword ptr [7FF8248A51E8]
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
       cmp       dword ptr [rbp+8],0
       je        near ptr M10_L03
       mov       rcx,rbp
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       eax,[rbp+8]
       mov       [rsp+64],eax
       mov       rcx,rbx
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r13
       mov       r8d,r12d
       mov       r9d,[rsp+64]
       mov       edx,3
       call      qword ptr [7FF8248AD578]
       test      r15d,r14d
       jne       near ptr M10_L03
       mov       rcx,rbp
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       ebp,[rbp+8]
       mov       rcx,rbx
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r14d,r14d
       jne       short M10_L23
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M10_L24
M10_L23:
       mov       ecx,esi
       xor       edx,edx
M10_L24:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r13
       mov       edx,r15d
       mov       r8d,ebp
       call      qword ptr [7FF8247A7D98]
       jmp       near ptr M10_L03
M10_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 906
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FF882CF6998
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L13
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L12
       mov       rax,7FF882CF6998
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L13
M00_L01:
       test      rsi,rsi
       je        near ptr M00_L14
       mov       rcx,18559801E00
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+9F],0
       je        near ptr M00_L15
M00_L02:
       mov       rbp,[rdi+10]
       test      rbp,rbp
       je        short M00_L03
       mov       rcx,[rbp+0C0]
       mov       rax,1C5EE76A7F8
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
       mov       rdx,1C5EE76A7F8
       call      qword ptr [7FF82439D020]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
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
       mov       rcx,7FF8247BF310
       call      qword ptr [7FF8247874F8]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       mov       rcx,1C5EE76A7F8
       call      qword ptr [7FF82488C0F0]
       int       3
M00_L09:
       call      qword ptr [7FF824394378]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L10
       call      qword ptr [7FF824787C18]
       mov       rbx,rax
M00_L10:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1C5EE76B4C0
       call      qword ptr [7FF824787C30]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       call      qword ptr [7FF8246ADCF8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M00_L13
       jmp       near ptr M00_L00
M00_L12:
       call      qword ptr [7FF8246ADCF8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       je        near ptr M00_L01
M00_L13:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FF824884EB8]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L14:
       mov       ecx,3888
       mov       rdx,7FF8243AF2D8
       call      qword ptr [7FF824107798]
       mov       rcx,rax
       call      qword ptr [7FF824884978]
       int       3
M00_L15:
       mov       rcx,rdi
       call      qword ptr [7FF8243972D0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L02
M00_L16:
       mov       rcx,rdi
       call      qword ptr [7FF82439CAF8]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rcx,rax
       jmp       near ptr M00_L04
M00_L17:
       call      qword ptr [7FF82488C648]
       int       3
M00_L18:
       mov       rcx,rbp
       call      qword ptr [7FF8244867D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L05
M00_L19:
       mov       rdx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L20:
       lea       rcx,[rsp+40]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FF824104E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
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
       vmovups   ymm0,[7FF824862C20]
       vmovups   [rdx],ymm0
       vmovups   ymm0,[7FF824862C40]
       vmovups   [rdx+20],ymm0
       vmovups   xmm0,[7FF824862C60]
       vmovups   [rdx+40],xmm0
       mov       word ptr [rdx+50],20
       mov       ecx,[rsp+50]
       add       ecx,29
       mov       [rsp+50],ecx
       jmp       short M00_L22
M00_L21:
       lea       rcx,[rsp+40]
       mov       rdx,1C5EE76B988
       call      qword ptr [7FF824784CD8]
M00_L22:
       lea       rcx,[rsp+40]
       mov       rdx,7FF8246DF070
       mov       r8,1C5EE76A7F8
       call      qword ptr [7FF82410E190]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ecx,[rsp+50]
       cmp       ecx,[rsp+60]
       jbe       short M00_L24
M00_L23:
       call      qword ptr [7FF824057198]
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
       mov       rdx,1C5EE750658
       call      qword ptr [7FF824784CD8]
M00_L26:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rsp+40]
       call      qword ptr [7FF824104EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF824305FC8]
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
       mov       rcx,18559801960
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L03
M01_L00:
       mov       rcx,7FF824905954
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       [rdi],dil
       test      rbx,rbx
       je        near ptr M01_L04
       mov       r15,[rdi+8]
       mov       rcx,[r15+8]
       cmp       byte ptr [rdi+19],0
       je        near ptr M01_L05
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r13d,eax
M01_L01:
       lea       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rbx
       mov       r9d,r13d
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      qword ptr [7FF824306658]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
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
       call      qword ptr [7FF82430C510]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
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
       mov       rcx,7FF824905950
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FF823E2D050
       call      qword ptr [7FF823EE6E98]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,18559801960
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,1
       mov       rdx,7FF82425E998
       call      qword ptr [7FF824107798]
       mov       rcx,rax
       call      qword ptr [7FF824486550]
       int       3
M01_L05:
       mov       rdx,rbx
       mov       r11,7FF823E30E38
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L01
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
       mov       rax,0EFE41AF60CE8
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
       mov       rcx,18559801E08
       mov       r14,[rcx]
       mov       r15,r14
       lea       r13d,[rdi+rdi*2]
       mov       rcx,18559800C90
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
       call      qword ptr [7FF824397F30]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
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
       call      qword ptr [7FF824505410]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
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
       call      qword ptr [7FF8245054A0]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rax,[rbp+80]
       xor       ecx,ecx
       mov       [rbp+80],rcx
       mov       [rbp+30],rax
       jmp       near ptr M02_L13
M02_L07:
       call      qword ptr [7FF824057198]
       int       3
M02_L08:
       mov       ecx,38A0
       mov       rdx,7FF8243AF2D8
       call      qword ptr [7FF824107798]
       mov       rcx,rax
       call      qword ptr [7FF82488EB50]
       int       3
M02_L09:
       mov       ecx,38A0
       mov       rdx,7FF8243AF2D8
       call      qword ptr [7FF824107798]
       mov       rcx,rax
       call      qword ptr [7FF82488EB68]
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
       mov       r8,0EFE41AF60CE8
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
       call      qword ptr [7FF824397390]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       jmp       near ptr M02_L03
M02_L17:
       mov       ecx,0A
       call      qword ptr [7FF824885170]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M02_L01
M02_L18:
       mov       [rbp+28],r8
       mov       rcx,r8
       call      qword ptr [7FF82439CC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13,[rbp+28]
       mov       eax,[r13+8]
       mov       [rbp+224],eax
       mov       rcx,r14
       call      qword ptr [7FF82439CC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r14d,[rbp+234]
       mov       [rsp+20],r14d
       mov       edx,r15d
       mov       r8d,[rbp+224]
       mov       rcx,r12
       call      qword ptr [7FF8247879D8]
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
       call      qword ptr [7FF8246AF390]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FF82448D878]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF823EE6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF82439CC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+228],eax
       mov       rcx,r15
       call      qword ptr [7FF82439CC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rbp+234]
       mov       [rsp+20],r15d
       mov       edx,r14d
       mov       r8d,[rbp+228]
       mov       rcx,r12
       call      qword ptr [7FF8247879D8]
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
       mov       r8,1C5EE7562A0
       jmp       near ptr M02_L02
M02_L32:
       mov       ecx,r13d
       mov       rdx,1C5EE756F28
       call      qword ptr [7FF82410D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FF8245E7BA0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M02_L35:
       cmp       byte ptr [r12+9D],0
       je        near ptr M02_L37
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF82439CC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+230],eax
       mov       rcx,r15
       call      qword ptr [7FF82439CC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,[rbp+230]
       mov       rcx,r12
       call      qword ptr [7FF8247879D8]
       mov       eax,[r13+8]
       mov       [rbp+22C],eax
       mov       rcx,r15
       call      qword ptr [7FF82439CC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF824787A20]
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
       call      qword ptr [7FF823EE57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,18559801E08
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
       call      qword ptr [7FF824885170]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M02_L41:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L42
       mov       rcx,rbx
       call      qword ptr [7FF8245EFAE0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
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
       call      qword ptr [7FF824787DC8]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FF823E24000
       call      qword ptr [7FF824107798]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF824306070]
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
       call      qword ptr [7FF82488F4B0]
M02_L44:
       mov       r14,[rax+8]
       call      qword ptr [7FF8246AF390]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FF82448D878]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF823EE6820]; System.Threading.Monitor.Exit(System.Object)
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
       mov       rcx,18559800C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       je        near ptr M02_L58
       mov       rcx,[rbp+38]
       cmp       dword ptr [rcx+8],0
       je        near ptr M02_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FF82439CC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp+38]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF82439CC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FF82488D710]
       test      r14d,edi
       jne       short M02_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FF82439CC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,[rbp+38]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF82439CC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF824787E40]
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
       call      qword ptr [7FF9551074E0]
       cmp       byte ptr [rax],0
       je        near ptr M04_L03
       call      qword ptr [7FF95510DBE0]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M04_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
M04_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       call      qword ptr [7FF955109688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M04_L00
       call      qword ptr [7FF9551074D8]
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
       call      qword ptr [7FF95510F2E0]
       lea       rcx,[rsp+20]
       call      qword ptr [7FF95510DC10]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF95510D4D8]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
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
       call      qword ptr [7FF9551096A0]
       test      rax,rax
       je        near ptr M04_L00
M04_L04:
       call      qword ptr [7FF95510BE58]
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
       call      qword ptr [7FF95510D580]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF95510B548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FF8248856B0]
M06_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M06_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M06_L03
       mov       rcx,7FF82490DB20
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF8244867F0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M06_L04
M06_L02:
       xor       ecx,ecx
       call      qword ptr [7FF824884978]
       int       3
M06_L03:
       mov       rcx,7FF82490DB1C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF82488C648]
       int       3
M06_L04:
       mov       rcx,7FF82490DB24
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FF883B9DA10
       test      eax,eax
       jne       near ptr M06_L10
M06_L05:
       mov       rcx,7FF82490DB28
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF82490DB2C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L06:
       call      qword ptr [7FF82488CC18]
       int       3
M06_L07:
       mov       rcx,7FF82490DB18
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF82488C648]
       int       3
M06_L08:
       mov       rcx,rbx
       call      qword ptr [7FF82439CB28]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M06_L09
       call      qword ptr [7FF824884E88]
       int       3
M06_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF883B19D60
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M06_L00
M06_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF8248852C0]
       jmp       near ptr M06_L05
       sub       rsp,28
       call      qword ptr [7FF82488CC30]
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
       mov       rcx,7FF82490DB24
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M06_L11
       xor       ecx,ecx
       call      qword ptr [7FF824884978]
       int       3
M06_L11:
       mov       rcx,[rbp-20]
       call      00007FF883B9DA10
       test      eax,eax
       je        short M06_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF8248852C0]
M06_L12:
       mov       rcx,7FF82490DB28
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
       jmp       qword ptr [7FF823EEFD08]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       mov       rcx,18559800C88
       mov       rsi,[rcx]
       imul      ecx,r8d,0B
       add       ecx,edx
       mov       edi,100
       cmp       ecx,100
       cmovg     edi,ecx
       mov       rcx,rsi
       mov       rdx,7FF82491ED30
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
       jne       near ptr M09_L05
       test      rsi,rsi
       je        near ptr M09_L06
       mov       rcx,rsi
       call      qword ptr [7FF883976148]
       test      rax,rax
       jne       short M09_L01
       mov       rcx,rsi
       lea       r11,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       call      qword ptr [r11]
       mov       rdx,rax
M09_L00:
       test      rdx,rdx
       je        near ptr M09_L06
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        near ptr M09_L07
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        near ptr M09_L08
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FF88397C900]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       jmp       near ptr M09_L06
M09_L01:
       mov       rcx,rsi
       call      qword ptr [7FF883976180]
       test      rax,rax
       je        near ptr M09_L04
       mov       rcx,rsi
       call      qword ptr [7FF8839773C0]
       mov       rsi,rax
M09_L02:
       mov       rcx,rsi
       lea       rdx,[rbx+18]
       mov       r9d,[rbx+10]
       mov       r8d,[rdx+8]
       cmp       r9d,r8d
       ja        near ptr M09_L07
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
       jne       short M09_L03
       mov       rcx,rbx
       call      qword ptr [7FF883983FC0]
       jmp       short M09_L02
M09_L03:
       mov       ecx,[rsp+48]
       add       [rbx+10],ecx
       jmp       short M09_L06
M09_L04:
       mov       rcx,rsi
       call      qword ptr [7FF8839773B8]
       mov       rcx,rax
       mov       r8,[rbx]
       lea       r11,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M09_L00
M09_L05:
       call      qword ptr [7FF88396F0C8]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF883993628]
M09_L06:
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M09_L07:
       call      qword ptr [7FF88397E290]
       int       3
M09_L08:
       mov       rcx,rbx
       call      qword ptr [7FF883983F98]
       jmp       short M09_L06
; Total bytes of code 397
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
       lea       rsi,[rbx+18]
       mov       rcx,rsi
       mov       eax,[rbx+10]
       cmp       eax,[rcx+8]
       ja        near ptr M10_L13
       mov       rcx,[rcx]
       mov       [rsp+48],rcx
       mov       [rsp+50],eax
       lea       rcx,[rsp+48]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rbp,[rbx+8]
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       [rsi],rcx
       mov       [rsi+8],rcx
       mov       [rbx+10],ecx
       test      rbp,rbp
       je        near ptr M10_L03
       mov       rcx,18559800C88
       mov       rbx,[rcx]
       mov       ecx,[rbp+8]
       dec       ecx
       or        ecx,0F
       xor       esi,esi
       lzcnt     esi,ecx
       xor       esi,1F
       add       esi,0FFFFFFFD
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
       cmp       ecx,esi
       jbe       short M10_L02
       mov       r14d,1
       mov       ecx,10
       shlx      ecx,ecx,esi
       cmp       [rbp+8],ecx
       jne       near ptr M10_L16
       mov       ecx,esi
       shl       rcx,4
       lea       r13,[rax+rcx+10]
       mov       r12,[r13]
       mov       rcx,r13
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],ecx
       test      r12,r12
       jne       short M10_L04
M10_L02:
       mov       rcx,18559800C90
       mov       r13,[rcx]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M10_L22
M10_L03:
       mov       rax,rdi
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
       cmp       esi,[rcx+8]
       jae       near ptr M10_L25
       mov       edx,esi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       je        near ptr M10_L17
M10_L05:
       mov       r15,[rax+8]
       call      qword ptr [7FF8246AF390]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M10_L07
       mov       rcx,[rsp+38]
       call      qword ptr [7FF8248856B0]
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
       call      00007FF883B9DA10
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
       call      qword ptr [7FF824057198]
       int       3
M10_L14:
       mov       ecx,3
       call      qword ptr [7FF824885170]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M10_L00
M10_L15:
       mov       rcx,rbx
       call      qword ptr [7FF82410CE88]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M10_L01
M10_L16:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF824787DC8]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF823E24000
       call      qword ptr [7FF824107798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FF824306070]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M10_L17:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF8246AF258]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
       jmp       near ptr M10_L05
M10_L18:
       mov       ecx,eax
       mov       rdx,[rsp+38]
       call      qword ptr [7FF8248852C0]
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
       cmp       dword ptr [rbp+8],0
       je        near ptr M10_L03
       mov       rcx,rbp
       call      qword ptr [7FF82439CC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       eax,[rbp+8]
       mov       [rsp+64],eax
       mov       rcx,rbx
       call      qword ptr [7FF82439CC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r13
       mov       r8d,r12d
       mov       r9d,[rsp+64]
       mov       edx,3
       call      qword ptr [7FF82488D710]
       test      r15d,r14d
       jne       near ptr M10_L03
       mov       rcx,rbp
       call      qword ptr [7FF82439CC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       ebp,[rbp+8]
       mov       rcx,rbx
       call      qword ptr [7FF82439CC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r14d,r14d
       jne       short M10_L23
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M10_L24
M10_L23:
       mov       ecx,esi
       xor       edx,edx
M10_L24:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r13
       mov       edx,r15d
       mov       r8d,ebp
       call      qword ptr [7FF824787E40]
       jmp       near ptr M10_L03
M10_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 906
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r8,7FF882CF7080
       movzx     eax,byte ptr [r8+rax]
       shl       eax,6
       mov       r8d,edx
       shr       r8d,3
       and       r8d,3E
       add       eax,r8d
       mov       r8,7FF882CF4B88
       movzx     eax,word ptr [r8+rax]
       shl       eax,4
       and       edx,0F
       add       edx,eax
       mov       rax,7FF882CFCE60
       movzx     edx,byte ptr [rax+rdx]
       mov       rax,7FF882D05930
       cmp       byte ptr [rax+rdx],0
       jl        near ptr M00_L16
       jmp       short M00_L01
M00_L00:
       mov       edx,edx
       mov       rax,7FF882CF6998
       test      byte ptr [rax+rdx],80
       jne       near ptr M00_L16
M00_L01:
       dec       ecx
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jl        short M00_L02
       mov       edx,ecx
       shr       edx,9
       mov       rax,7FF882CF7080
       movzx     edx,byte ptr [rax+rdx]
       shl       edx,6
       mov       eax,ecx
       shr       eax,3
       and       eax,3E
       add       edx,eax
       mov       rax,7FF882CF4B88
       movzx     edx,word ptr [rax+rdx]
       shl       edx,4
       and       ecx,0F
       add       ecx,edx
       mov       rdx,7FF882CFCE60
       movzx     ecx,byte ptr [rdx+rcx]
       mov       rdx,7FF882D05930
       cmp       byte ptr [rdx+rcx],0
       jl        near ptr M00_L16
       jmp       short M00_L03
M00_L02:
       mov       ecx,ecx
       mov       rdx,7FF882CF6998
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
       mov       rdx,2A6D58006A8
       mov       r14,[rdx]
       mov       rdx,[r14+10]
       mov       rcx,rsi
       mov       r8,r14
       xor       r9d,r9d
       call      qword ptr [7FF824794000]; System.Xml.XmlTextReaderImpl..ctor(System.Xml.XmlResolver, System.Xml.XmlReaderSettings, System.Xml.XmlParserContext)
       mov       rcx,2E754810008
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
       mov       rcx,2A6D5800588
       mov       rdx,[rcx]
       lea       rcx,[rsi+190]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       byte ptr [rsi+178],0
       sete      cl
       mov       [rsi+1EF],cl
       mov       byte ptr [rsi+1EC],1
       mov       rcx,rsi
       call      qword ptr [7FF8247942B8]; System.Xml.XmlTextReaderImpl.ReadData()
       mov       rdx,[rsi+190]
       lea       rcx,[rsi+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M00_L07
       cmp       [rcx],ecx
       call      qword ptr [7FF824817210]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[rsi+8]
       mov       rdx,[rdx+30]
       mov       rcx,rsi
       call      qword ptr [7FF824817228]
M00_L07:
       xor       ecx,ecx
       mov       [rsi+8],rcx
M00_L08:
       mov       [rbp-68],rsi
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,2E75481FFC0
       xor       r8d,r8d
       call      qword ptr [7FF82462E100]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       vmovdqu   ymm0,ymmword ptr [r14+38]
       vmovdqu   ymmword ptr [rbp-58],ymm0
       mov       r9,[r14+58]
       mov       [rbp-38],r9
       lea       r9,[rbp-58]
       mov       rdx,rsi
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FF824794330]; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
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
       call      qword ptr [7FF82472F7F8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF824335FC8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       cmp       dword ptr [rsi+160],4
       je        short M00_L12
       movzx     edx,byte ptr [rsi+17D]
       mov       rcx,rsi
       call      qword ptr [7FF824795170]; System.Xml.XmlTextReaderImpl.Close(Boolean)
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
       mov       rdx,7FF8247A2D30
       cmp       [rcx],ecx
       call      qword ptr [7FF8247951D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF8243C4378]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L15
       call      qword ptr [7FF82481D428]
       mov       rbx,rax
M00_L15:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2E754821720
       call      qword ptr [7FF824814438]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L16:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FF8248171F8]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L17:
       mov       ecx,11
       call      qword ptr [7FF82413C228]
       int       3
M00_L18:
       mov       rcx,rdi
       call      00007FF883B4C160
       jmp       near ptr M00_L13
       sub       rsp,28
       mov       rcx,[rbp-68]
       cmp       dword ptr [rcx+160],4
       je        short M00_L19
       movzx     edx,byte ptr [rcx+17D]
       call      qword ptr [7FF824795170]; System.Xml.XmlTextReaderImpl.Close(Boolean)
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
       call      00007FF883B4C160
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
       mov       r14,2E754810008
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
       call      qword ptr [7FF8248172B8]; System.Threading.Tasks.Task`1[[System.ValueTuple`4[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.ValueTuple`4<Int32,Int32,Int32,Boolean>)
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
       call      qword ptr [7FF824794198]; System.Xml.XmlNamespaceManager..ctor(System.Xml.XmlNameTable)
       lea       rcx,[rbx+40]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M01_L04:
       mov       rcx,offset MT_System.Xml.NameTable
       cmp       [r15],rcx
       jne       near ptr M01_L27
       mov       rcx,[r15+8]
       mov       r13d,[r15+14]
       and       r13d,0DF92D247
       mov       eax,r13d
       cmp       eax,[rcx+8]
       jae       near ptr M01_L30
       mov       r12,[rcx+rax*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M01_L07
M01_L05:
       cmp       dword ptr [rcx+18],0DF92D247
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
       mov       rcx,2E754821720
       mov       [rax+8],rcx
       mov       dword ptr [rax+18],0DF92D247
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
       mov       rcx,2E7548217AC
       mov       eax,0C6E68CF9
       mov       edx,7EADED94
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
       mov       rcx,2E7548217A0
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
       mov       r10,2E7548217A0
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
       call      qword ptr [7FF824794450]; System.Xml.NameTable.Grow()
       jmp       near ptr M01_L14
M01_L21:
       lea       rcx,[rsp+40]
       cmp       qword ptr [rcx],0
       jne       near ptr M01_L01
       mov       rdx,2A6D58006B0
       mov       rdx,[rdx]
       jmp       near ptr M01_L02
M01_L22:
       mov       rdx,[rcx+8]
       mov       rax,rdx
       mov       r8,2E754821720
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
       call      qword ptr [7FF824794450]; System.Xml.NameTable.Grow()
       jmp       near ptr M01_L08
M01_L25:
       mov       byte ptr [rbx+177],1
       jmp       near ptr M01_L03
M01_L26:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FF8248172D0]
       mov       r15,[rbx+28]
       jmp       near ptr M01_L04
M01_L27:
       mov       rcx,r15
       mov       rdx,r14
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,r15
       mov       rdx,2E754821720
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       lea       rcx,[rbx+0D0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,2E7548217A0
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       jmp       near ptr M01_L15
M01_L28:
       cmp       eax,2
       ja        near ptr M01_L16
       mov       eax,eax
       lea       rcx,[7FF82489F5F0]
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
       jne       near ptr M02_L21
       cmp       byte ptr [rbx+1EC],0
       je        short M02_L03
       mov       ecx,[rbx+1D4]
       mov       rax,[rbx+188]
       mov       eax,[rax+8]
       dec       eax
       cmp       ecx,eax
       je        near ptr M02_L22
M02_L01:
       cmp       qword ptr [rbx+198],0
       jne       near ptr M02_L25
M02_L02:
       mov       rcx,[rbx+188]
       mov       esi,[rcx+8]
       sub       esi,[rbx+1D4]
       dec       esi
       cmp       esi,50
       jle       short M02_L06
       mov       esi,50
       jmp       short M02_L06
M02_L03:
       mov       rcx,[rbx+188]
       mov       esi,[rcx+8]
       mov       ecx,esi
       sub       ecx,[rbx+1D4]
       mov       eax,esi
       shr       eax,1
       cmp       ecx,eax
       jle       near ptr M02_L26
M02_L04:
       cmp       qword ptr [rbx+198],0
       jne       near ptr M02_L31
M02_L05:
       mov       rcx,[rbx+188]
       mov       esi,[rcx+8]
       sub       esi,[rbx+1D4]
       dec       esi
M02_L06:
       cmp       qword ptr [rbx+198],0
       jne       short M02_L07
       mov       rsi,[rbx+1B0]
       test      rsi,rsi
       je        near ptr M02_L42
       mov       rcx,[rbx+188]
       mov       rax,rcx
       mov       edx,[rbx+1D4]
       mov       edi,edx
       mov       ebp,[rcx+8]
       sub       ebp,edx
       dec       ebp
       mov       rcx,offset MT_System.IO.StringReader
       cmp       [rsi],rcx
       jne       near ptr M02_L41
       test      edi,edi
       jge       short M02_L09
       mov       ecx,13CB6
       mov       rdx,7FF823E54000
       call      qword ptr [7FF824137798]
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF8248140D8]
       int       3
M02_L07:
       cmp       byte ptr [rbx+1EE],0
       je        near ptr M02_L34
M02_L08:
       mov       edi,[rbx+1D8]
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF824817108]
       mov       esi,eax
       test      esi,esi
       jne       near ptr M02_L14
       jmp       near ptr M02_L36
M02_L09:
       test      ebp,ebp
       jl        near ptr M02_L20
       mov       ecx,[rax+8]
       sub       ecx,edi
       cmp       ecx,ebp
       jl        near ptr M02_L37
       mov       r8,[rsi+8]
       test      r8,r8
       je        near ptr M02_L38
       mov       r14d,[r8+8]
       sub       r14d,[rsi+10]
       test      r14d,r14d
       jle       short M02_L12
       cmp       r14d,ebp
       cmovg     r14d,ebp
       mov       ebp,[rsi+10]
       cmp       [r8],r8b
       test      r14d,r14d
       jl        near ptr M02_L19
       test      ebp,ebp
       jl        near ptr M02_L18
       mov       r15d,[r8+8]
       sub       r15d,ebp
       cmp       r14d,r15d
       jl        short M02_L10
       cmp       r14d,r15d
       jg        near ptr M02_L39
M02_L10:
       mov       r15d,[rax+8]
       sub       r15d,r14d
       cmp       edi,r15d
       jl        short M02_L11
       cmp       edi,r15d
       jg        near ptr M02_L40
M02_L11:
       mov       edx,ebp
       lea       rdx,[r8+rdx*2+0C]
       mov       ecx,edi
       lea       rcx,[rax+rcx*2+10]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FF823F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rsi+10],r14d
M02_L12:
       mov       ebp,r14d
M02_L13:
       mov       esi,ebp
       lea       rcx,[rbx+1D4]
       add       [rcx],esi
M02_L14:
       movsxd    rdi,esi
       cmp       dword ptr [rbx+13C],0
       setge     bpl
       movzx     ebp,bpl
       cmp       qword ptr [rbx+0E8],0
       jg        near ptr M02_L43
M02_L15:
       cmp       qword ptr [rbx+0F0],0
       setg      cl
       movzx     ecx,cl
       test      ebp,ecx
       jne       near ptr M02_L46
M02_L16:
       test      esi,esi
       jne       short M02_L17
       mov       byte ptr [rbx+1ED],1
M02_L17:
       mov       rax,[rbx+188]
       mov       ecx,[rbx+1D4]
       cmp       ecx,[rax+8]
       jae       near ptr M02_L49
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
M02_L18:
       mov       ecx,167
       mov       rdx,7FF823E54000
       call      qword ptr [7FF824137798]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FF8248140D8]
       int       3
M02_L19:
       mov       ecx,28F
       mov       rdx,7FF823E54000
       call      qword ptr [7FF824137798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8248140D8]
       int       3
M02_L20:
       mov       ecx,28F
       mov       rdx,7FF823E54000
       call      qword ptr [7FF824137798]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FF8248140D8]
       int       3
M02_L21:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L22:
       xor       esi,esi
       jmp       short M02_L24
M02_L23:
       mov       rcx,[rbx+10]
       mov       eax,[rbx+114]
       lea       eax,[rax+rsi+1]
       cmp       eax,[rcx+8]
       jae       near ptr M02_L49
       mov       rcx,[rcx+rax*8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8248170D8]
       inc       esi
M02_L24:
       cmp       esi,[rbx+11C]
       jl        short M02_L23
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
       call      qword ptr [7FF82408DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       lea       rcx,[rbx+188]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L01
M02_L25:
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
       call      qword ptr [7FF82408DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       lea       rcx,[rbx+1A8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L02
M02_L26:
       xor       edi,edi
       jmp       short M02_L28
M02_L27:
       mov       rcx,[rbx+10]
       mov       eax,[rbx+114]
       lea       eax,[rax+rdi+1]
       cmp       eax,[rcx+8]
       jae       near ptr M02_L49
       mov       rcx,[rcx+rax*8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8248170D8]
       inc       edi
M02_L28:
       cmp       edi,[rbx+11C]
       jl        short M02_L27
       mov       edi,[rbx+1D4]
       sub       edi,[rbx+1D0]
       dec       esi
       cmp       edi,esi
       jge       short M02_L30
       lea       rdx,[rbx+1E4]
       mov       ecx,[rbx+1D0]
       sub       [rdx],ecx
       test      edi,edi
       jle       short M02_L29
       lea       edx,[rdi+rdi]
       mov       [rsp+20],edx
       mov       edx,[rbx+1D0]
       add       edx,edx
       mov       rcx,[rbx+188]
       mov       r8,[rbx+188]
       xor       r9d,r9d
       call      qword ptr [7FF82408DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
M02_L29:
       xor       edx,edx
       mov       [rbx+1D0],edx
       mov       [rbx+1D4],edi
       jmp       near ptr M02_L04
M02_L30:
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
       call      qword ptr [7FF82408DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       lea       rcx,[rbx+188]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L04
M02_L31:
       mov       esi,[rbx+1DC]
       sub       esi,[rbx+1D8]
       cmp       esi,80
       jg        near ptr M02_L05
       test      esi,esi
       jne       short M02_L32
       xor       ecx,ecx
       mov       [rbx+1DC],ecx
       jmp       short M02_L33
M02_L32:
       mov       [rsp+20],esi
       mov       rcx,[rbx+1A8]
       mov       edx,[rbx+1D8]
       mov       r8,[rbx+1A8]
       xor       r9d,r9d
       call      qword ptr [7FF82408DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rbx+1DC],esi
M02_L33:
       xor       ecx,ecx
       mov       [rbx+1D8],ecx
       jmp       near ptr M02_L05
M02_L34:
       mov       ecx,[rbx+1D8]
       cmp       ecx,[rbx+1DC]
       jne       near ptr M02_L08
       mov       rcx,[rbx+1A8]
       mov       ecx,[rcx+8]
       sub       ecx,[rbx+1DC]
       test      ecx,ecx
       jle       near ptr M02_L08
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
       jne       short M02_L35
       mov       byte ptr [rbx+1EE],1
M02_L35:
       lea       rcx,[rbx+1DC]
       add       [rcx],eax
       jmp       near ptr M02_L08
M02_L36:
       cmp       [rbx+1D8],edi
       je        near ptr M02_L14
       jmp       near ptr M02_L00
M02_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF824817120]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF824334180]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L38:
       call      qword ptr [7FF824817138]
       int       3
M02_L39:
       mov       ecx,167
       mov       rdx,7FF823E54000
       call      qword ptr [7FF824137798]
       mov       r8,rax
       mov       edx,r15d
       mov       ecx,r14d
       call      qword ptr [7FF824814588]
       int       3
M02_L40:
       mov       ecx,17F
       mov       rdx,7FF823E54000
       call      qword ptr [7FF824137798]
       mov       r8,rax
       mov       edx,r15d
       mov       ecx,edi
       call      qword ptr [7FF824814588]
       int       3
M02_L41:
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8d,edi
       mov       r9d,ebp
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       esi,eax
       mov       ebp,esi
       jmp       near ptr M02_L13
M02_L42:
       xor       esi,esi
       jmp       near ptr M02_L14
M02_L43:
       mov       r14,rdi
       add       r14,[rbx+0F8]
       cmp       r14,[rbx+0F8]
       jge       short M02_L44
       mov       rcx,2E75482B4F0
       call      qword ptr [7FF82479FF60]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,2E75482B528
       call      qword ptr [7FF824817150]
       jmp       short M02_L45
M02_L44:
       mov       [rbx+0F8],r14
M02_L45:
       mov       rcx,[rbx+0F8]
       cmp       rcx,[rbx+0E8]
       jle       near ptr M02_L15
       mov       rcx,2E75482B4F0
       call      qword ptr [7FF82479FF60]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,2E75482B528
       call      qword ptr [7FF824817150]
       jmp       near ptr M02_L15
M02_L46:
       add       rdi,[rbx+100]
       cmp       rdi,[rbx+100]
       jge       short M02_L47
       mov       rcx,2E75482B4F0
       call      qword ptr [7FF82479FF60]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,2E75482B570
       call      qword ptr [7FF824817150]
       jmp       short M02_L48
M02_L47:
       mov       [rbx+100],rdi
M02_L48:
       mov       rcx,[rbx+100]
       cmp       rcx,[rbx+0F0]
       jle       near ptr M02_L16
       mov       rcx,2E75482B4F0
       call      qword ptr [7FF82479FF60]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,2E75482B570
       call      qword ptr [7FF824817150]
       jmp       near ptr M02_L16
M02_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1859
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
       je        near ptr M03_L20
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M03_L21
M03_L00:
       mov       rcx,2A6BF801FC8
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
       mov       r11,7FF823E61290
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
       jne       near ptr M03_L22
       cmp       ecx,[r14+38]
       jne       near ptr M03_L22
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
       jl        near ptr M03_L26
M03_L06:
       xor       edx,edx
M03_L07:
       mov       r14,rdx
       test      r14,r14
       je        short M03_L08
       mov       rcx,offset MT_System.Xml.Serialization.TypeDesc
       cmp       [r14],rcx
       jne       near ptr M03_L27
M03_L08:
       test      r14,r14
       jne       near ptr M03_L28
M03_L09:
       xor       r14d,r14d
M03_L10:
       lea       rcx,[rbx+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+18],0
       jne       near ptr M03_L29
       cmp       dword ptr [7FF823E5B150],1
       je        near ptr M03_L15
       mov       rcx,2A6D5800038
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
       je        near ptr M03_L18
       mov       r12,[r13+18]
       mov       rcx,r12
       mov       rdx,r15
       mov       r11,7FF823E612A0
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
       jbe       near ptr M03_L18
M03_L11:
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r13+rdx*8+10]
       mov       [rbp-90],r9
       cmp       [r9+10],eax
       jne       near ptr M03_L31
       mov       rdx,[r9]
       mov       rcx,r12
       mov       r8,r15
       mov       r11,7FF823E612A8
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-90]
       je        near ptr M03_L31
       add       r9,8
M03_L12:
       test      r9,r9
       je        near ptr M03_L19
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
       call      qword ptr [7FF824794318]; System.Xml.Serialization.XmlReflectionImporter.GetTopLevelMapping(System.Type, System.String)
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
       jne       near ptr M03_L23
M03_L17:
       mov       r11,[rbp-98]
       mov       rdx,r11
       jmp       near ptr M03_L07
M03_L18:
       xor       r9d,r9d
       jmp       near ptr M03_L12
M03_L19:
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
       call      qword ptr [7FF82462E970]; System.Runtime.CompilerServices.ConditionalWeakTable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M03_L13
       lea       r8,[rbp-60]
       mov       rcx,[rbp-68]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF823F5AC10]
       jmp       near ptr M03_L13
M03_L20:
       mov       ecx,0EBC1
       mov       rdx,7FF8245CCD40
       call      qword ptr [7FF824137798]
       mov       rcx,rax
       call      qword ptr [7FF82479F9C0]
       int       3
M03_L21:
       mov       rcx,rdi
       mov       rdx,2E754810008
       call      qword ptr [7FF823F1C828]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       near ptr M03_L00
       jmp       near ptr M03_L09
M03_L22:
       lea       rcx,[rbp-58]
       mov       edx,14
       call      qword ptr [7FF824815920]
       mov       eax,[rbp-50]
       mov       r10,[rbp-80]
       jmp       near ptr M03_L04
M03_L23:
       cmp       qword ptr [r14+20],0
       je        short M03_L24
       mov       rcx,[r14+20]
       mov       r8,rsi
       mov       rdx,r9
       mov       r11,7FF823E61298
       call      qword ptr [r11]
       jmp       short M03_L25
M03_L24:
       mov       rcx,r9
       mov       rdx,rsi
       mov       r10,[r9]
       mov       r10,[r10+40]
       call      qword ptr [r10+10]
M03_L25:
       test      eax,eax
       je        near ptr M03_L05
       jmp       near ptr M03_L17
M03_L26:
       mov       r8d,[rbp-4C]
       inc       r8d
       cmp       [r15+8],r8d
       mov       [rbp-4C],r8d
       mov       eax,ecx
       jg        near ptr M03_L03
       jmp       near ptr M03_L06
M03_L27:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L28:
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
       call      qword ptr [7FF824817468]
       mov       rcx,rsi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF8246B73D8]; System.Xml.Serialization.XmlMapping.GenerateKey(System.Type, System.Xml.Serialization.XmlRootAttribute, System.String)
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L10
M03_L29:
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L15
M03_L30:
       cmp       [r13+8],edx
       mov       [rbp-70],r10d
       mov       eax,[rbp-6C]
       jbe       near ptr M03_L18
       jmp       near ptr M03_L11
M03_L31:
       mov       edx,[r9+14]
       mov       r10d,[rbp-70]
       inc       r10d
       cmp       [r13+8],r10d
       jae       short M03_L30
       call      qword ptr [7FF824137A08]
       int       3
M03_L32:
       mov       rdx,2A6D5800038
       mov       rcx,[rdx]
       mov       [rbp-88],rcx
       xor       edx,edx
       mov       [rbp-40],edx
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-88]
       call      qword ptr [7FF823F15998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,2A6D5800038
       mov       rcx,[rcx]
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FF82462E958]; System.Xml.Serialization.TempAssemblyCache.get_Item(System.String, System.Type)
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
       call      qword ptr [7FF82462E988]; System.Xml.Serialization.TempAssembly.LoadGeneratedAssembly(System.Type, System.String, System.Xml.Serialization.XmlSerializerImplementation ByRef)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M03_L34
       cmp       dword ptr [7FF823E5B150],3
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
       call      qword ptr [7FF82462EBC8]; System.Xml.Serialization.Compiler.GetTempAssemblyName(System.Reflection.AssemblyName, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.IO.FileLoadException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF824817498]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF8248174B0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF8248174C8]
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
       call      qword ptr [7FF82462F1E0]; System.Xml.Serialization.XmlReflectionImporter..ctor(System.Xml.Serialization.XmlAttributeOverrides, System.String)
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9,rdi
       xor       r8d,r8d
       call      qword ptr [7FF82462F240]; System.Xml.Serialization.XmlReflectionImporter.ImportTypeMapping(System.Type, System.Xml.Serialization.XmlRootAttribute, System.String)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+18]
       mov       rdx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FF8246B75D0]; System.Xml.Serialization.XmlSerializer.GenerateTempAssembly(System.Xml.Serialization.XmlMapping, System.Type, System.String, System.String)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L35
M03_L34:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF824794318]; System.Xml.Serialization.XmlReflectionImporter.GetTopLevelMapping(System.Type, System.String)
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
       call      qword ptr [7FF8248174E0]
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M03_L35:
       mov       r9,[rbx+8]
       mov       rcx,2A6D5800038
       mov       rcx,[rcx]
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FF824725380]; System.Xml.Serialization.TempAssemblyCache.Add(System.String, System.Type, System.Xml.Serialization.TempAssembly)
       nop
       cmp       byte ptr [rbp-40],0
       je        near ptr M03_L14
       mov       rcx,[rbp-88]
       call      qword ptr [7FF823F16820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M03_L14
M03_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-40],0
       je        short M03_L37
       mov       rcx,[rbp-88]
       call      qword ptr [7FF823F16820]; System.Threading.Monitor.Exit(System.Object)
M03_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1753
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
       cmp       dword ptr [7FF823E5B150],1
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
       call      qword ptr [7FF824794378]; System.Xml.Serialization.TempAssembly.InvokeReader(System.Xml.Serialization.XmlMapping, System.Xml.XmlReader, System.Xml.Serialization.XmlDeserializationEvents, System.String)
       jmp       near ptr M04_L05
M04_L01:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r8,rdi
       mov       r9,rbx
       call      qword ptr [7FF8249B43D8]
       jmp       near ptr M04_L05
M04_L02:
       test      rdi,rdi
       je        short M04_L03
       cmp       dword ptr [rdi+8],0
       jle       short M04_L03
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF82481C6D8]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FF8248174B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF824335FC8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L03:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r8,rbx
       call      qword ptr [7FF82481C6F0]
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
       call      qword ptr [7FF8247943D8]; System.Xml.Serialization.XmlSerializationReader.Init(System.Xml.XmlReader, System.Xml.Serialization.XmlDeserializationEvents, System.String)
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
       call      qword ptr [7FF824134ED0]
       mov       rbx,rax
       jmp       short M04_L06
M04_L08:
       call      qword ptr [7FF82481C738]
       mov       rdi,rax
       mov       rcx,rsi
       mov       r11,7FF823E61238
       call      qword ptr [r11]
       mov       [rbp-28],eax
       call      qword ptr [7FF82453D788]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FF82472D620]
       mov       r14,rax
       mov       rcx,rsi
       mov       r11,7FF823E61240
       call      qword ptr [r11]
       mov       [rbp-28],eax
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF82453D788]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FF82472D620]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FF82481C3A8]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FF8243C5DE8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF82481C750]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FF8243C5DE8]
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
       jmp       qword ptr [7FF823F1FD08]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.Xml.XmlTextReaderImpl.Close(Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       cmp       dword ptr [rbx+108],0C
       je        near ptr M06_L06
M06_L00:
       cmp       dword ptr [rbx+13C],0
       jge       near ptr M06_L10
       lea       rdi,[rbx+188]
       test      sil,sil
       je        near ptr M06_L04
       cmp       qword ptr [rdi+10],0
       jne       short M06_L02
       mov       rdi,[rdi+28]
       test      rdi,rdi
       je        near ptr M06_L04
       mov       rcx,offset MT_System.IO.StringReader
       cmp       [rdi],rcx
       jne       near ptr M06_L13
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       [rdi+10],ecx
M06_L01:
       mov       rcx,rdi
       call      qword ptr [7FF823F17AE0]; System.GC.SuppressFinalize(System.Object)
       jmp       short M06_L04
M06_L02:
       mov       rsi,[rdi+10]
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.IO.FileStream
       cmp       rdi,rcx
       jne       near ptr M06_L09
       mov       rbp,[rsi+10]
       test      rbp,rbp
       je        short M06_L03
       mov       rax,[rbp]
       mov       rcx,offset MT_System.IO.Strategies.SyncWindowsFileStreamStrategy
       cmp       rax,rcx
       je        near ptr M06_L07
       mov       rcx,rbp
       mov       edx,1
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
M06_L03:
       test      dword ptr [rdi],100000
       jne       near ptr M06_L12
M06_L04:
       mov       rcx,2A6D58006C8
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M06_L14
M06_L05:
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+108],0C
       xor       eax,eax
       mov       [rbx+68],rax
       mov       rax,2E754810008
       mov       [rbx+60],rax
       mov       dword ptr [rbx+160],4
       mov       byte ptr [rbx+176],0
       mov       eax,0FFFFFFFF
       mov       [rbx+118],rax
       xor       eax,eax
       mov       [rbx+120],rax
       mov       [rbx+8],rax
M06_L06:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L07:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        near ptr M06_L03
       test      byte ptr [rcx+10],1
       jne       near ptr M06_L03
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       jne       short M06_L11
M06_L08:
       mov       rbp,[rbp+18]
       cmp       [rbp],bpl
       mov       rcx,rbp
       mov       edx,1
       call      qword ptr [7FF823F1C768]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,rbp
       call      qword ptr [7FF823F17AE0]; System.GC.SuppressFinalize(System.Object)
       jmp       near ptr M06_L03
M06_L09:
       mov       rcx,rsi
       mov       rax,[rdi+50]
       call      qword ptr [rax+18]
       jmp       near ptr M06_L04
M06_L10:
       mov       rcx,rbx
       call      qword ptr [7FF82481CC78]
       jmp       near ptr M06_L00
M06_L11:
       call      qword ptr [7FF824919200]
       jmp       short M06_L08
M06_L12:
       mov       rcx,rsi
       call      00007FF883B4C160
       jmp       near ptr M06_L04
M06_L13:
       mov       rcx,rdi
       mov       edx,1
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M06_L01
M06_L14:
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl+NodeData
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF82481CCA8]
       mov       rcx,2A6D58006C8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M06_L05
; Total bytes of code 509
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

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       r8,7FF882CF7080
       movzx     eax,byte ptr [r8+rax]
       shl       eax,6
       mov       r8d,edx
       shr       r8d,3
       and       r8d,3E
       add       eax,r8d
       mov       r8,7FF882CF4B88
       movzx     eax,word ptr [r8+rax]
       shl       eax,4
       and       edx,0F
       add       edx,eax
       mov       rax,7FF882CFCE60
       movzx     edx,byte ptr [rax+rdx]
       mov       rax,7FF882D05930
       cmp       byte ptr [rax+rdx],0
       jl        near ptr M00_L16
       jmp       short M00_L01
M00_L00:
       mov       edx,edx
       mov       rax,7FF882CF6998
       test      byte ptr [rax+rdx],80
       jne       near ptr M00_L16
M00_L01:
       dec       ecx
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jl        short M00_L02
       mov       edx,ecx
       shr       edx,9
       mov       rax,7FF882CF7080
       movzx     edx,byte ptr [rax+rdx]
       shl       edx,6
       mov       eax,ecx
       shr       eax,3
       and       eax,3E
       add       edx,eax
       mov       rax,7FF882CF4B88
       movzx     edx,word ptr [rax+rdx]
       shl       edx,4
       and       ecx,0F
       add       ecx,edx
       mov       rdx,7FF882CFCE60
       movzx     ecx,byte ptr [rdx+rcx]
       mov       rdx,7FF882D05930
       cmp       byte ptr [rdx+rcx],0
       jl        near ptr M00_L16
       jmp       short M00_L03
M00_L02:
       mov       ecx,ecx
       mov       rdx,7FF882CF6998
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
       mov       rdx,2078C0006B8
       mov       r14,[rdx]
       mov       rdx,[r14+10]
       mov       rcx,rsi
       mov       r8,r14
       xor       r9d,r9d
       call      qword ptr [7FF8247A7D80]; System.Xml.XmlTextReaderImpl..ctor(System.Xml.XmlResolver, System.Xml.XmlReaderSettings, System.Xml.XmlParserContext)
       mov       rcx,2480B3A0008
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
       mov       rcx,2078C000598
       mov       rdx,[rcx]
       lea       rcx,[rsi+190]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       byte ptr [rsi+178],0
       sete      cl
       mov       [rsi+1EF],cl
       mov       byte ptr [rsi+1EC],1
       mov       rcx,rsi
       call      qword ptr [7FF8247AC048]; System.Xml.XmlTextReaderImpl.ReadData()
       mov       rdx,[rsi+190]
       lea       rcx,[rsi+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M00_L07
       cmp       [rcx],ecx
       call      qword ptr [7FF824975488]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[rsi+8]
       mov       rdx,[rdx+30]
       mov       rcx,rsi
       call      qword ptr [7FF8249754A0]
M00_L07:
       xor       ecx,ecx
       mov       [rsi+8],rcx
M00_L08:
       mov       [rbp-68],rsi
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,2480B3B10F0
       xor       r8d,r8d
       call      qword ptr [7FF8246C5F20]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       vmovdqu   ymm0,ymmword ptr [r14+38]
       vmovdqu   ymmword ptr [rbp-58],ymm0
       mov       r9,[r14+58]
       mov       [rbp-38],r9
       lea       r9,[rbp-58]
       mov       rdx,rsi
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FF8247AC0C0]; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
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
       call      qword ptr [7FF8247A7588]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF824325FC8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       cmp       dword ptr [rsi+160],4
       je        short M00_L12
       movzx     edx,byte ptr [rsi+17D]
       mov       rcx,rsi
       call      qword ptr [7FF8247ACF18]; System.Xml.XmlTextReaderImpl.Close(Boolean)
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
       mov       rdx,7FF8247E9620
       cmp       [rcx],ecx
       call      qword ptr [7FF8247ACF78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF8243B4378]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L15
       call      qword ptr [7FF824977690]
       mov       rbx,rax
M00_L15:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2480B3B1720
       call      qword ptr [7FF824816598]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L16:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FF824815F20]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L17:
       mov       ecx,11
       call      qword ptr [7FF82412C228]
       int       3
M00_L18:
       mov       rcx,rdi
       call      00007FF883B4C160
       jmp       near ptr M00_L13
       sub       rsp,28
       mov       rcx,[rbp-68]
       cmp       dword ptr [rcx+160],4
       je        short M00_L19
       movzx     edx,byte ptr [rcx+17D]
       call      qword ptr [7FF8247ACF18]; System.Xml.XmlTextReaderImpl.Close(Boolean)
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
       call      00007FF883B4C160
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
       mov       r14,2480B3A0008
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
       call      qword ptr [7FF824975530]; System.Threading.Tasks.Task`1[[System.ValueTuple`4[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.ValueTuple`4<Int32,Int32,Int32,Boolean>)
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
       call      qword ptr [7FF8247A7F18]; System.Xml.XmlNamespaceManager..ctor(System.Xml.XmlNameTable)
       lea       rcx,[rbx+40]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M01_L04:
       mov       rcx,offset MT_System.Xml.NameTable
       cmp       [r15],rcx
       jne       near ptr M01_L27
       mov       rcx,[r15+8]
       mov       r13d,[r15+14]
       and       r13d,87AA588B
       mov       eax,r13d
       cmp       eax,[rcx+8]
       jae       near ptr M01_L30
       mov       r12,[rcx+rax*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M01_L07
M01_L05:
       cmp       dword ptr [rcx+18],87AA588B
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
       mov       rcx,2480B3B1720
       mov       [rax+8],rcx
       mov       dword ptr [rax+18],87AA588B
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
       mov       rcx,2480B3B17AC
       mov       eax,0CEBCD255
       mov       edx,1873E7E8
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
       mov       rcx,2480B3B17A0
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
       mov       r10,2480B3B17A0
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
       call      qword ptr [7FF8247AC1E0]; System.Xml.NameTable.Grow()
       jmp       near ptr M01_L14
M01_L21:
       lea       rcx,[rsp+40]
       cmp       qword ptr [rcx],0
       jne       near ptr M01_L01
       mov       rdx,2078C0006C0
       mov       rdx,[rdx]
       jmp       near ptr M01_L02
M01_L22:
       mov       rdx,[rcx+8]
       mov       rax,rdx
       mov       r8,2480B3B1720
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
       call      qword ptr [7FF8247AC1E0]; System.Xml.NameTable.Grow()
       jmp       near ptr M01_L08
M01_L25:
       mov       byte ptr [rbx+177],1
       jmp       near ptr M01_L03
M01_L26:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FF824975548]
       mov       r15,[rbx+28]
       jmp       near ptr M01_L04
M01_L27:
       mov       rcx,r15
       mov       rdx,r14
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,r15
       mov       rdx,2480B3B1720
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       lea       rcx,[rbx+0D0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,2480B3B17A0
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       jmp       near ptr M01_L15
M01_L28:
       cmp       eax,2
       ja        near ptr M01_L16
       mov       eax,eax
       lea       rcx,[7FF824A25570]
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
       jne       near ptr M02_L15
       cmp       byte ptr [rbx+1EC],0
       jne       near ptr M02_L12
       mov       rcx,[rbx+188]
       mov       esi,[rcx+8]
       mov       ecx,esi
       sub       ecx,[rbx+1D4]
       mov       eax,esi
       shr       eax,1
       cmp       ecx,eax
       jle       near ptr M02_L20
M02_L01:
       cmp       qword ptr [rbx+198],0
       jne       near ptr M02_L25
M02_L02:
       mov       rcx,[rbx+188]
       mov       esi,[rcx+8]
       sub       esi,[rbx+1D4]
       dec       esi
M02_L03:
       cmp       qword ptr [rbx+198],0
       jne       near ptr M02_L28
       mov       rsi,[rbx+1B0]
       test      rsi,rsi
       je        near ptr M02_L40
       mov       rcx,[rbx+188]
       mov       rax,rcx
       mov       edx,[rbx+1D4]
       mov       edi,edx
       mov       ebp,[rcx+8]
       sub       ebp,edx
       dec       ebp
       mov       rcx,offset MT_System.IO.StringReader
       cmp       [rsi],rcx
       jne       near ptr M02_L39
       test      edi,edi
       jl        near ptr M02_L31
       test      ebp,ebp
       jl        near ptr M02_L32
       mov       ecx,[rax+8]
       sub       ecx,edi
       cmp       ecx,ebp
       jl        near ptr M02_L33
       mov       r8,[rsi+8]
       test      r8,r8
       je        near ptr M02_L34
       mov       r14d,[r8+8]
       sub       r14d,[rsi+10]
       test      r14d,r14d
       jle       short M02_L06
       cmp       r14d,ebp
       cmovg     r14d,ebp
       mov       ebp,[rsi+10]
       cmp       [r8],r8b
       test      r14d,r14d
       jl        near ptr M02_L35
       test      ebp,ebp
       jl        near ptr M02_L36
       mov       r15d,[r8+8]
       sub       r15d,ebp
       cmp       r14d,r15d
       jl        short M02_L04
       cmp       r14d,r15d
       jg        near ptr M02_L37
M02_L04:
       mov       r15d,[rax+8]
       sub       r15d,r14d
       cmp       edi,r15d
       jl        short M02_L05
       cmp       edi,r15d
       jg        near ptr M02_L38
M02_L05:
       mov       edx,ebp
       lea       rdx,[r8+rdx*2+0C]
       mov       ecx,edi
       lea       rcx,[rax+rcx*2+10]
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FF823F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       je        short M02_L16
M02_L13:
       cmp       qword ptr [rbx+198],0
       jne       near ptr M02_L19
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
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L16:
       xor       esi,esi
       jmp       short M02_L18
M02_L17:
       mov       rcx,[rbx+10]
       mov       eax,[rbx+114]
       lea       eax,[rax+rsi+1]
       cmp       eax,[rcx+8]
       jae       near ptr M02_L47
       mov       rcx,[rcx+rax*8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF824974F30]
       inc       esi
M02_L18:
       cmp       esi,[rbx+11C]
       jl        short M02_L17
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
       call      qword ptr [7FF82407DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       lea       rcx,[rbx+188]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L13
M02_L19:
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
       call      qword ptr [7FF82407DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       lea       rcx,[rbx+1A8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L14
M02_L20:
       xor       edi,edi
       jmp       short M02_L22
M02_L21:
       mov       rcx,[rbx+10]
       mov       eax,[rbx+114]
       lea       eax,[rax+rdi+1]
       cmp       eax,[rcx+8]
       jae       near ptr M02_L47
       mov       rcx,[rcx+rax*8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF824974F30]
       inc       edi
M02_L22:
       cmp       edi,[rbx+11C]
       jl        short M02_L21
       mov       edi,[rbx+1D4]
       sub       edi,[rbx+1D0]
       dec       esi
       cmp       edi,esi
       jge       short M02_L24
       lea       rdx,[rbx+1E4]
       mov       ecx,[rbx+1D0]
       sub       [rdx],ecx
       test      edi,edi
       jle       short M02_L23
       lea       edx,[rdi+rdi]
       mov       [rsp+20],edx
       mov       edx,[rbx+1D0]
       add       edx,edx
       mov       rcx,[rbx+188]
       mov       r8,[rbx+188]
       xor       r9d,r9d
       call      qword ptr [7FF82407DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
M02_L23:
       xor       edx,edx
       mov       [rbx+1D0],edx
       mov       [rbx+1D4],edi
       jmp       near ptr M02_L01
M02_L24:
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
       call      qword ptr [7FF82407DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       lea       rcx,[rbx+188]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L01
M02_L25:
       mov       esi,[rbx+1DC]
       sub       esi,[rbx+1D8]
       cmp       esi,80
       jg        near ptr M02_L02
       test      esi,esi
       jne       short M02_L26
       xor       ecx,ecx
       mov       [rbx+1DC],ecx
       jmp       short M02_L27
M02_L26:
       mov       [rsp+20],esi
       mov       rcx,[rbx+1A8]
       mov       edx,[rbx+1D8]
       mov       r8,[rbx+1A8]
       xor       r9d,r9d
       call      qword ptr [7FF82407DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       [rbx+1DC],esi
M02_L27:
       xor       ecx,ecx
       mov       [rbx+1D8],ecx
       jmp       near ptr M02_L02
M02_L28:
       cmp       byte ptr [rbx+1EE],0
       jne       short M02_L30
       mov       ecx,[rbx+1D8]
       cmp       ecx,[rbx+1DC]
       jne       short M02_L30
       mov       rcx,[rbx+1A8]
       mov       ecx,[rcx+8]
       sub       ecx,[rbx+1DC]
       test      ecx,ecx
       jle       short M02_L30
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
       jne       short M02_L29
       mov       byte ptr [rbx+1EE],1
M02_L29:
       lea       rcx,[rbx+1DC]
       add       [rcx],eax
M02_L30:
       mov       edi,[rbx+1D8]
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF824974F60]
       mov       esi,eax
       test      esi,esi
       jne       near ptr M02_L08
       cmp       [rbx+1D8],edi
       je        near ptr M02_L08
       jmp       near ptr M02_L00
M02_L31:
       mov       ecx,13CB6
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF824815998]
       int       3
M02_L32:
       mov       ecx,28F
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FF824815998]
       int       3
M02_L33:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF824817030]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF824324180]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L34:
       call      qword ptr [7FF824974F78]
       int       3
M02_L35:
       mov       ecx,28F
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF824815998]
       int       3
M02_L36:
       mov       ecx,167
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FF824815998]
       int       3
M02_L37:
       mov       ecx,167
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       edx,r15d
       mov       ecx,r14d
       call      qword ptr [7FF824974AB0]
       int       3
M02_L38:
       mov       ecx,17F
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       edx,r15d
       mov       ecx,edi
       call      qword ptr [7FF824974AB0]
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
       mov       rcx,2480B3BB4F0
       call      qword ptr [7FF8249749A8]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,2480B3BB528
       call      qword ptr [7FF824974F90]
       jmp       short M02_L43
M02_L42:
       mov       [rbx+0F8],r14
M02_L43:
       mov       rcx,[rbx+0F8]
       cmp       rcx,[rbx+0E8]
       jle       near ptr M02_L09
       mov       rcx,2480B3BB4F0
       call      qword ptr [7FF8249749A8]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,2480B3BB528
       call      qword ptr [7FF824974F90]
       jmp       near ptr M02_L09
M02_L44:
       add       rdi,[rbx+100]
       cmp       rdi,[rbx+100]
       jge       short M02_L45
       mov       rcx,2480B3BB4F0
       call      qword ptr [7FF8249749A8]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,2480B3BB570
       call      qword ptr [7FF824974F90]
       jmp       short M02_L46
M02_L45:
       mov       [rbx+100],rdi
M02_L46:
       mov       rcx,[rbx+100]
       cmp       rcx,[rbx+0F0]
       jle       near ptr M02_L10
       mov       rcx,2480B3BB4F0
       call      qword ptr [7FF8249749A8]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,2480B3BB570
       call      qword ptr [7FF824974F90]
       jmp       near ptr M02_L10
M02_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1852
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
       je        near ptr M03_L20
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M03_L21
M03_L00:
       mov       rcx,20776001FF0
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
       mov       r11,7FF823E514C0
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
       jne       near ptr M03_L22
       cmp       ecx,[r14+38]
       jne       near ptr M03_L22
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
       jne       near ptr M03_L26
M03_L07:
       test      r14,r14
       jne       near ptr M03_L27
M03_L08:
       xor       r14d,r14d
M03_L09:
       lea       rcx,[rbx+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+18],0
       jne       near ptr M03_L28
       cmp       dword ptr [7FF823E4B150],1
       je        near ptr M03_L14
       mov       rcx,2078C000058
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
       je        near ptr M03_L19
       mov       r12,[r13+18]
       mov       rcx,r12
       mov       rdx,r15
       mov       r11,7FF823E514D0
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
       jbe       near ptr M03_L19
M03_L10:
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r13+rdx*8+10]
       mov       [rbp-98],r9
       cmp       [r9+10],eax
       jne       near ptr M03_L30
       mov       rdx,[r9]
       mov       rcx,r12
       mov       r8,r15
       mov       r11,7FF823E514D8
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-98]
       je        near ptr M03_L30
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
       call      qword ptr [7FF8247AC0A8]; System.Xml.Serialization.XmlReflectionImporter.GetTopLevelMapping(System.Type, System.String)
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
       jne       short M03_L23
M03_L18:
       mov       rdx,r12
       jmp       near ptr M03_L06
M03_L19:
       xor       r9d,r9d
       jmp       near ptr M03_L11
M03_L20:
       mov       ecx,0EBC1
       mov       rdx,7FF82462C1F0
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF8248159C8]
       int       3
M03_L21:
       mov       rcx,rdi
       mov       rdx,2480B3A0008
       call      qword ptr [7FF823F0C828]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       near ptr M03_L00
       jmp       near ptr M03_L08
M03_L22:
       lea       rcx,[rbp-60]
       mov       edx,14
       call      qword ptr [7FF824974E10]
       mov       eax,[rbp-58]
       mov       r9,[rbp-88]
       jmp       near ptr M03_L04
M03_L23:
       cmp       qword ptr [r14+20],0
       je        short M03_L24
       mov       rcx,[r14+20]
       mov       r8,rsi
       mov       rdx,r11
       mov       r11,7FF823E514C8
       call      qword ptr [r11]
       jmp       short M03_L25
M03_L24:
       mov       rcx,r11
       mov       rdx,rsi
       mov       r9,[r11]
       mov       r9,[r9+40]
       call      qword ptr [r9+10]
M03_L25:
       test      eax,eax
       je        near ptr M03_L16
       jmp       near ptr M03_L18
M03_L26:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L27:
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
       call      qword ptr [7FF824975590]
       mov       rcx,rsi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF8246CF1F8]; System.Xml.Serialization.XmlMapping.GenerateKey(System.Type, System.Xml.Serialization.XmlRootAttribute, System.String)
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L09
M03_L28:
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L14
M03_L29:
       cmp       [r13+8],edx
       mov       [rbp-78],r10d
       mov       eax,[rbp-74]
       jbe       near ptr M03_L19
       jmp       near ptr M03_L10
M03_L30:
       mov       edx,[r9+14]
       mov       r10d,[rbp-78]
       inc       r10d
       cmp       [r13+8],r10d
       jae       short M03_L29
       call      qword ptr [7FF824127A08]
       int       3
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
       call      qword ptr [7FF8246C6790]; System.Runtime.CompilerServices.ConditionalWeakTable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M03_L12
       lea       r8,[rbp-68]
       mov       rcx,[rbp-70]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF823F4AC10]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       jmp       near ptr M03_L12
M03_L32:
       mov       rdx,2078C000058
       mov       rcx,[rdx]
       mov       [rbp-90],rcx
       xor       edx,edx
       mov       [rbp-40],edx
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-90]
       call      qword ptr [7FF823F05998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,2078C000058
       mov       rcx,[rcx]
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FF8246C6778]; System.Xml.Serialization.TempAssemblyCache.get_Item(System.String, System.Type)
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
       call      qword ptr [7FF8246C67A8]; System.Xml.Serialization.TempAssembly.LoadGeneratedAssembly(System.Type, System.String, System.Xml.Serialization.XmlSerializerImplementation ByRef)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M03_L34
       cmp       dword ptr [7FF823E4B150],3
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
       call      qword ptr [7FF8246C69E8]; System.Xml.Serialization.Compiler.GetTempAssemblyName(System.Reflection.AssemblyName, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.IO.FileLoadException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8249755C0]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF824975020]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF8249755D8]
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
       call      qword ptr [7FF8246C7000]; System.Xml.Serialization.XmlReflectionImporter..ctor(System.Xml.Serialization.XmlAttributeOverrides, System.String)
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9,rdi
       xor       r8d,r8d
       call      qword ptr [7FF8246C7060]; System.Xml.Serialization.XmlReflectionImporter.ImportTypeMapping(System.Type, System.Xml.Serialization.XmlRootAttribute, System.String)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+18]
       mov       rdx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FF8246CF3F0]; System.Xml.Serialization.XmlSerializer.GenerateTempAssembly(System.Xml.Serialization.XmlMapping, System.Type, System.String, System.String)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L35
M03_L34:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF8247AC0A8]; System.Xml.Serialization.XmlReflectionImporter.GetTopLevelMapping(System.Type, System.String)
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
       call      qword ptr [7FF8249755F0]
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M03_L35:
       mov       r9,[rbx+8]
       mov       rcx,2078C000058
       mov       rcx,[rcx]
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FF82473D158]; System.Xml.Serialization.TempAssemblyCache.Add(System.String, System.Type, System.Xml.Serialization.TempAssembly)
       nop
       cmp       byte ptr [rbp-40],0
       je        near ptr M03_L13
       mov       rcx,[rbp-90]
       call      qword ptr [7FF823F06820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M03_L13
M03_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-40],0
       je        short M03_L37
       mov       rcx,[rbp-90]
       call      qword ptr [7FF823F06820]; System.Threading.Monitor.Exit(System.Object)
M03_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1752
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
       cmp       dword ptr [7FF823E4B150],1
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
       call      qword ptr [7FF8247AC108]; System.Xml.Serialization.TempAssembly.InvokeReader(System.Xml.Serialization.XmlMapping, System.Xml.XmlReader, System.Xml.Serialization.XmlDeserializationEvents, System.String)
       jmp       near ptr M04_L05
M04_L01:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r8,rdi
       mov       r9,rbx
       call      qword ptr [7FF824977A98]
       jmp       near ptr M04_L05
M04_L02:
       test      rdi,rdi
       je        short M04_L03
       cmp       dword ptr [rdi+8],0
       jle       short M04_L03
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8249756E0]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FF824975020]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF824325FC8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L03:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r8,rbx
       call      qword ptr [7FF8249756F8]
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
       call      qword ptr [7FF8247AC168]; System.Xml.Serialization.XmlSerializationReader.Init(System.Xml.XmlReader, System.Xml.Serialization.XmlDeserializationEvents, System.String)
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
       call      qword ptr [7FF824124ED0]
       mov       rbx,rax
       jmp       short M04_L06
M04_L08:
       call      qword ptr [7FF824975740]
       mov       rdi,rax
       mov       rcx,rsi
       mov       r11,7FF823E51438
       call      qword ptr [r11]
       mov       [rbp-28],eax
       call      qword ptr [7FF824605488]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FF8247A52D8]; System.Int32.ToString(System.IFormatProvider)
       mov       r14,rax
       mov       rcx,rsi
       mov       r11,7FF823E51440
       call      qword ptr [r11]
       mov       [rbp-28],eax
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF824605488]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FF8247A52D8]; System.Int32.ToString(System.IFormatProvider)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FF8249750F8]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FF8243B5DE8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF824975758]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FF8243B5DE8]
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
       jmp       qword ptr [7FF823F0FD08]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.Xml.XmlTextReaderImpl.Close(Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       cmp       dword ptr [rbx+108],0C
       je        near ptr M06_L06
M06_L00:
       cmp       dword ptr [rbx+13C],0
       jge       near ptr M06_L10
       lea       rdi,[rbx+188]
       test      sil,sil
       je        near ptr M06_L04
       cmp       qword ptr [rdi+10],0
       jne       short M06_L02
       mov       rdi,[rdi+28]
       test      rdi,rdi
       je        near ptr M06_L04
       mov       rcx,offset MT_System.IO.StringReader
       cmp       [rdi],rcx
       jne       near ptr M06_L13
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       [rdi+10],ecx
M06_L01:
       mov       rcx,rdi
       call      qword ptr [7FF823F07AE0]; System.GC.SuppressFinalize(System.Object)
       jmp       short M06_L04
M06_L02:
       mov       rsi,[rdi+10]
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.IO.FileStream
       cmp       rdi,rcx
       jne       near ptr M06_L09
       mov       rbp,[rsi+10]
       test      rbp,rbp
       je        short M06_L03
       mov       rax,[rbp]
       mov       rcx,offset MT_System.IO.Strategies.SyncWindowsFileStreamStrategy
       cmp       rax,rcx
       je        near ptr M06_L07
       mov       rcx,rbp
       mov       edx,1
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
M06_L03:
       test      dword ptr [rdi],100000
       jne       near ptr M06_L12
M06_L04:
       mov       rcx,2078C0006D8
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M06_L14
M06_L05:
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+108],0C
       xor       eax,eax
       mov       [rbx+68],rax
       mov       rax,2480B3A0008
       mov       [rbx+60],rax
       mov       dword ptr [rbx+160],4
       mov       byte ptr [rbx+176],0
       mov       eax,0FFFFFFFF
       mov       [rbx+118],rax
       xor       eax,eax
       mov       [rbx+120],rax
       mov       [rbx+8],rax
M06_L06:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L07:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        near ptr M06_L03
       test      byte ptr [rcx+10],1
       jne       near ptr M06_L03
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       jne       short M06_L11
M06_L08:
       mov       rbp,[rbp+18]
       cmp       [rbp],bpl
       mov       rcx,rbp
       mov       edx,1
       call      qword ptr [7FF823F0C768]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,rbp
       call      qword ptr [7FF823F07AE0]; System.GC.SuppressFinalize(System.Object)
       jmp       near ptr M06_L03
M06_L09:
       mov       rcx,rsi
       mov       rax,[rdi+50]
       call      qword ptr [rax+18]
       jmp       near ptr M06_L04
M06_L10:
       mov       rcx,rbx
       call      qword ptr [7FF824975440]
       jmp       near ptr M06_L00
M06_L11:
       call      qword ptr [7FF8249B1198]
       jmp       short M06_L08
M06_L12:
       mov       rcx,rsi
       call      00007FF883B4C160
       jmp       near ptr M06_L04
M06_L13:
       mov       rcx,rdi
       mov       edx,1
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M06_L01
M06_L14:
       mov       rcx,offset MT_System.Xml.XmlTextReaderImpl+NodeData
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF824975470]
       mov       rcx,2078C0006D8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M06_L05
; Total bytes of code 509
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

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       xor       eax,eax
       mov       [rbp-0E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0E0],ymm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+150]
       mov       [rbp-0A0],r8
       mov       rbx,213F9CBA7F8
       mov       [rbp-100],rbx
       mov       rax,1D37AC00730
       mov       rax,[rax]
       mov       [rbp-0A8],rax
       test      r8,r8
       je        short M00_L00
       mov       rcx,r8
       call      qword ptr [7FF823F0C9A8]; System.Object.GetType()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF823E4A610]; System.RuntimeType.IsAssignableFrom(System.Type)
       test      eax,eax
       mov       rbx,[rbp-100]
       mov       r8,[rbp-0A0]
       je        near ptr M00_L26
M00_L00:
       mov       rax,[rbp-0A8]
       mov       rsi,[rax+8]
       test      rsi,rsi
       je        near ptr M00_L29
M00_L01:
       mov       [rbp-0B0],rsi
       mov       rsi,[rbp-0B0]
       cmp       [rsi],sil
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rdx,7FF883B29D00
       call      rdx
       movzx     ebx,al
       cmp       dword ptr [7FF883E53B10],0
       jne       near ptr M00_L30
M00_L02:
       cmp       ebx,0F
       je        near ptr M00_L38
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,7FF883B29D00
       call      rax
       movzx     ebx,al
       mov       rsi,[rbp-100]
       cmp       dword ptr [7FF883E53B10],0
       jne       near ptr M00_L31
M00_L03:
       cmp       ebx,10
       je        near ptr M00_L38
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       ecx,[rcx]
       and       ecx,80001000
       cmp       ecx,1000
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L38
M00_L04:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M00_L35
       mov       [rbp-0B8],rsi
       mov       rcx,[rsi+18]
       mov       rax,7FF883B29D00
       call      rax
       movzx     ebx,al
       mov       rsi,[rbp-0B8]
       cmp       dword ptr [7FF883E53B10],0
       jne       near ptr M00_L33
M00_L05:
       cmp       ebx,1D
       ja        short M00_L06
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M00_L34
M00_L06:
       cmp       ebx,10
       sete      dil
       movzx     edi,dil
M00_L07:
       test      edi,edi
       jne       near ptr M00_L32
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M00_L36
M00_L08:
       test      rsi,rsi
       je        near ptr M00_L37
       mov       rcx,rsi
       call      00007FF883AA4ED0
       test      eax,eax
       jne       near ptr M00_L38
       mov       rsi,[rbp-0B0]
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L67
       mov       rbx,[rsi+8]
       test      rbx,rbx
       je        near ptr M00_L39
M00_L09:
       mov       rsi,[rbx+8]
       mov       rcx,1D364C01960
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L40
M00_L10:
       mov       [rbp-0C0],rsi
       mov       rcx,[rbp-0C0]
       cmp       [rcx],cl
       mov       rsi,[rcx+8]
       mov       rax,[rsi+8]
       cmp       byte ptr [rcx+19],0
       je        near ptr M00_L41
       mov       rcx,213F9CBA7F8
       mov       rax,[7FF823E4A1C0]
       call      qword ptr [rax+18]
       mov       r14d,eax
M00_L11:
       mov       r15,[rsi+8]
       mov       rcx,[rsi+10]
       mov       edx,r14d
       imul      rdx,[rsi+28]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M00_L76
       mov       edx,edx
       mov       r13,[rcx+rdx*8+10]
       test      r13,r13
       je        near ptr M00_L44
M00_L12:
       cmp       r14d,[r13+20]
       jne       near ptr M00_L22
       mov       r12,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r15],rcx
       jne       near ptr M00_L43
       test      r12,r12
       je        near ptr M00_L22
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M00_L42
       mov       rcx,213F9CBA7F8
       cmp       r12,rcx
       sete      al
       movzx     eax,al
M00_L13:
       test      eax,eax
       je        near ptr M00_L22
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
       lea       rdx,[rbp-58]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF82452FD50]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
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
       mov       rcx,213F9CA62A0
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
       mov       [rbp-0F0],rcx
       mov       r14,[rax+10]
       mov       rcx,[rbp-0F0]
       cmp       [rcx],cl
       mov       rcx,[rbp-0F0]
       add       rcx,18
       mov       rdx,[rcx]
       mov       edx,[rdx+8]
       sub       edx,[rcx+0C]
       cmp       edx,esi
       jl        near ptr M00_L27
M00_L19:
       lea       rcx,[r14+8]
       mov       rdx,[rbp-0F0]
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
       je        near ptr M00_L28
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L20:
       mov       [r14+2C],eax
       test      dil,4
       jne       near ptr M00_L74
       mov       rsi,213F9CA1518
M00_L21:
       mov       ecx,[rsi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+78],0
       jne       near ptr M00_L25
       mov       dword ptr [r14+78],3E8
       jmp       near ptr M00_L25
M00_L22:
       mov       r13,[r13+18]
       test      r13,r13
       jne       near ptr M00_L12
       jmp       near ptr M00_L44
M00_L23:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      esi,esi
       je        near ptr M00_L75
       mov       rcx,1D364C01DE0
       mov       rcx,[rcx]
       mov       edx,esi
       call      qword ptr [7FF8245BC0E0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
M00_L24:
       mov       [rbp-70],rax
       lea       rcx,[rdi+18]
       mov       rdx,[rbp-70]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+20],rcx
       mov       byte ptr [rdi+28],1
       mov       [rbp-0F0],rdi
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdx,[rbp-58]
       mov       rcx,r14
       call      qword ptr [7FF82452FEA0]; System.Text.Json.Utf8JsonWriter.SetOptions(System.Text.Json.JsonWriterOptions)
M00_L25:
       mov       [rbp-0F8],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,[rbp-0A0]
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r9,[rbp-0F0]
       cmp       [r9],r9b
       mov       rdx,[rbp-0F0]
       add       rdx,18
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-80],xmm0
       mov       r9d,[rdx+0C]
       mov       r8d,[rdx+8]
       sub       r9d,r8d
       mov       rdx,[rdx]
       lea       rcx,[rbp-80]
       call      qword ptr [7FF824617EA0]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rcx,[rbp-80]
       mov       eax,[rbp-78]
       mov       [rbp-98],rcx
       mov       [rbp-90],eax
       lea       rcx,[rbp-98]
       call      qword ptr [7FF824525DA0]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rbx,rax
       mov       rcx,r14
       mov       rdx,[rbp-0F0]
       call      qword ptr [7FF824617EB8]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       [rbp-88],rbx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+60]
       lea       r8,[rbp-88]
       mov       rdx,7FF824797998
       cmp       [rcx],ecx
       call      qword ptr [7FF824785EA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L26:
       mov       rdx,r8
       mov       rcx,rbx
       call      qword ptr [7FF8247F5FB0]
       int       3
M00_L27:
       mov       edx,esi
       call      qword ptr [7FF82452FDE0]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L19
M00_L28:
       mov       eax,2
       jmp       near ptr M00_L20
M00_L29:
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF8243B4B10]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,[rbp-0A8]
       call      qword ptr [7FF824717288]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FF8247F6190]
       mov       rdx,[rbp-0A8]
       lea       rcx,[rdx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L30:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L02
M00_L31:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L03
M00_L32:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rsi,rax
       jmp       near ptr M00_L04
M00_L33:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L05
M00_L34:
       mov       edi,1
       jmp       near ptr M00_L07
M00_L35:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       near ptr M00_L07
M00_L36:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rsi,rax
       jmp       near ptr M00_L08
M00_L37:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8247F61F0]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8247F6208]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,3C7C
       mov       rdx,7FF8243CF2D8
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       mov       rdx,213F9CBA7F8
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF8247F61A8]
       int       3
M00_L39:
       mov       rcx,rsi
       call      qword ptr [7FF8243BCAF8]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M00_L09
M00_L40:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FF823E4D050
       call      qword ptr [7FF823F06E98]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,1D364C01960
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L10
M00_L41:
       mov       rcx,rax
       mov       rdx,213F9CBA7F8
       mov       r11,7FF823E50E40
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L11
M00_L42:
       mov       rcx,r12
       mov       rdx,213F9CBA7F8
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L13
M00_L43:
       mov       rcx,r15
       mov       r8,213F9CBA7F8
       mov       rdx,r12
       mov       r11,7FF823E50E48
       call      qword ptr [r11]
       jmp       near ptr M00_L13
M00_L44:
       xor       edx,edx
       mov       [rbp-0C8],rdx
       mov       [rbp-0D0],rsi
       mov       rdx,213F9CBA7F8
       mov       r8,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       [rbp-0E8],rax
       mov       rax,[rsi+8]
       mov       [rbp-0D8],rax
       mov       [rbp-3C],r14d
M00_L45:
       mov       rax,[rbp-0D0]
       mov       rax,[rax+18]
       mov       [rbp-0E0],rax
       mov       rax,[rbp-0D0]
       mov       rcx,[rax+10]
       mov       rax,[rbp-0D0]
       mov       r8d,[rbp-3C]
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
       mov       [rbp-40],edx
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L76
       mov       eax,r8d
       lea       rbx,[rcx+rax*8+10]
       xor       esi,esi
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-44],ecx
       mov       rcx,[rbp-0E0]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M00_L54
       mov       rcx,[rbp-0E0]
       mov       eax,[rbp-40]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       short M00_L46
       xor       ecx,ecx
       call      qword ptr [7FF8247F4C90]
       int       3
M00_L46:
       mov       rcx,r14
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M00_L47
       mov       rcx,r14
       call      qword ptr [7FF8247F5338]
M00_L47:
       mov       dword ptr [rbp-44],1
       mov       rdx,[rbp-0D0]
       mov       rcx,[rbp-0C0]
       cmp       rdx,[rcx+8]
       je        near ptr M00_L50
       mov       rcx,[rbp-0C0]
       mov       rax,[rcx+8]
       mov       [rbp-0D0],rax
       mov       rax,[rbp-0D8]
       mov       rdx,[rbp-0D0]
       cmp       rax,[rdx+8]
       je        near ptr M00_L61
       mov       rax,[rbp-0D0]
       mov       rax,[rax+8]
       mov       [rbp-0D8],rax
       cmp       byte ptr [rcx+19],0
       jne       short M00_L48
       mov       rcx,[rbp-0D8]
       mov       rdx,213F9CBA7F8
       mov       r11,7FF823E50E58
       call      qword ptr [r11]
       jmp       short M00_L49
M00_L48:
       mov       rcx,213F9CBA7F8
       mov       rax,[7FF823E4A1C0]
       call      qword ptr [rax+18]
M00_L49:
       mov       [rbp-3C],eax
       mov       rcx,[rbp-0C0]
       jmp       near ptr M00_L61
M00_L50:
       xor       r14d,r14d
       mov       r15,[rbx]
       test      r15,r15
       je        short M00_L56
M00_L51:
       mov       edx,[rbp-3C]
       cmp       edx,[r15+20]
       jne       short M00_L52
       mov       rdx,[r15+8]
       mov       rcx,[rbp-0D8]
       mov       r8,213F9CBA7F8
       mov       r11,7FF823E50E60
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L53
M00_L52:
       inc       r14d
       mov       r15,[r15+18]
       test      r15,r15
       jne       short M00_L51
       jmp       short M00_L56
M00_L53:
       mov       rax,[r15+10]
       mov       [rbp-0C8],rax
       jmp       near ptr M00_L62
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
       mov       r13,[rbx]
       mov       rcx,213F9CBA7F8
       mov       [r15+8],rcx
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0E8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-3C]
       mov       [r15+20],ecx
       mov       rcx,rbx
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0D0]
       mov       rdx,[rdx+20]
       mov       ecx,[rdx+8]
       cmp       [rbp-40],ecx
       jae       short M00_L54
       mov       ecx,[rbp-40]
       lea       rdx,[rdx+rcx*4+10]
       mov       ecx,[rdx]
       add       ecx,1
       jo        short M00_L55
       mov       [rdx],ecx
       mov       rdx,[rbp-0D0]
       mov       rdx,[rdx+20]
       mov       ecx,[rdx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M00_L54
       mov       ecx,[rbp-40]
       mov       edx,[rdx+rcx*4+10]
       mov       rcx,[rbp-0C0]
       cmp       edx,[rcx+10]
       jle       short M00_L57
       mov       esi,1
M00_L57:
       cmp       r14d,64
       jbe       short M00_L58
       mov       rdx,[rbp-0D8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FF823F06850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       ecx,1
       test      rax,rax
       cmovne    edi,ecx
M00_L58:
       mov       rax,[rbp-0E0]
       mov       edx,[rbp-40]
       mov       rax,[rax+rdx*8+10]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L59
       xor       ecx,ecx
       call      qword ptr [7FF8247F4C90]
       int       3
M00_L59:
       mov       rcx,rbx
       call      00007FF883B9DA10
       test      eax,eax
       je        short M00_L60
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF8247F5350]
M00_L60:
       mov       ecx,esi
       or        ecx,edi
       je        short M00_L64
       jmp       short M00_L63
M00_L61:
       call      M00_L77
       jmp       near ptr M00_L45
M00_L62:
       call      M00_L77
       jmp       near ptr M00_L14
M00_L63:
       mov       rcx,[rbp-0C0]
       mov       rdx,[rbp-0D0]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FF82461C6C0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
M00_L64:
       mov       r8,[rbp-0E8]
       mov       [rbp-0C8],r8
       jmp       near ptr M00_L14
M00_L65:
       call      qword ptr [7FF8247F6250]
       int       3
M00_L66:
       mov       rcx,rbx
       call      qword ptr [7FF8244A67D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L15
M00_L67:
       mov       rcx,rsi
       mov       rdx,213F9CBA7F8
       call      qword ptr [7FF8243BD098]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       jmp       near ptr M00_L15
M00_L68:
       mov       rcx,213F9CBBA40
       call      qword ptr [7FF8247F5FC8]
       mov       rbx,rax
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FF823F0C9A8]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L69
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L69
       jmp       short M00_L70
M00_L69:
       mov       rcx,rax
       call      qword ptr [7FF823F07C30]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
M00_L70:
       mov       rsi,[rcx+30]
       test      rsi,rsi
       jne       short M00_L71
       lea       rdx,[rcx+30]
       mov       r8d,1
       call      qword ptr [7FF824074AF8]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
M00_L71:
       mov       rcx,213F9CB2DA8
       test      rsi,rsi
       cmove     rsi,rcx
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rbx
       mov       rdx,213F9CBA7F8
       mov       r8,rsi
       call      qword ptr [7FF824784A98]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF824325FC8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L72:
       mov       rcx,rbx
       call      qword ptr [7FF8244A67D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L16
M00_L73:
       mov       ecx,9
       call      qword ptr [7FF8247F5170]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdi,rax
       jmp       near ptr M00_L17
M00_L74:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      qword ptr [7FF823F05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D37AC00960
       mov       rsi,[rcx]
       jmp       near ptr M00_L21
M00_L75:
       mov       rax,213F9CA62A0
       jmp       near ptr M00_L24
M00_L76:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L77:
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp-44],0
       je        short M00_L78
       mov       rcx,[rbp-0E0]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       short M00_L80
       mov       rcx,[rbp-0E0]
       mov       eax,[rbp-40]
       mov       rsi,[rcx+rax*8+10]
       test      rsi,rsi
       je        short M00_L79
       mov       rcx,rsi
       call      00007FF883B9DA10
       test      eax,eax
       je        short M00_L78
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF8247F5350]
M00_L78:
       nop
       add       rsp,28
       ret
M00_L79:
       xor       ecx,ecx
       call      qword ptr [7FF8247F4C90]
       int       3
M00_L80:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       vzeroupper
       mov       rcx,[rbp-0F8]
       mov       rdx,[rbp-0F0]
       call      qword ptr [7FF824617EB8]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       nop
       add       rsp,28
       ret
; Total bytes of code 3364
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
       call      qword ptr [7FF823F05C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      qword ptr [7FF823F06850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF8247F6AA8]; System.RuntimeTypeHandle.CanCastTo(System.RuntimeType, System.RuntimeType)
M02_L02:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      qword ptr [7FF823F06850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF823F0D398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       je        short M02_L03
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF8247F6070]
M02_L03:
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FF883B39010
       test      eax,eax
       je        short M02_L06
       mov       rcx,rsi
       call      qword ptr [7FF823E4A400]
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
       jne       short M03_L02
       mov       r8,213F9CA1518
       mov       [rcx+50],r8
M03_L02:
       mov       rcx,213F9CAFFA8
       cmp       r8,rcx
       je        short M03_L04
       cmp       dword ptr [r8+8],1
       jne       short M03_L03
       cmp       word ptr [r8+0C],0A
       je        short M03_L04
M03_L03:
       mov       rcx,213F9CA1518
       cmp       r8,rcx
       je        short M03_L04
       cmp       dword ptr [r8+8],2
       jne       short M03_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M03_L08
M03_L04:
       mov       rcx,213F9CA1518
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
       mov       rdx,7FF8243CF2D8
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF8247F6358]
       int       3
M03_L09:
       or        esi,4
       jmp       short M03_L06
M03_L10:
       cmp       edx,9
       je        short M03_L11
       mov       ecx,38A0
       mov       rdx,7FF8243CF2D8
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF8247F6310]
       int       3
M03_L11:
       or        esi,8
       jmp       near ptr M03_L00
M03_L12:
       mov       ecx,38A0
       mov       rdx,7FF8243CF2D8
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FF8247F6328]
       int       3
M03_L13:
       mov       ecx,38A0
       mov       rdx,7FF8243CF2D8
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF8247F6340]
       int       3
; Total bytes of code 409
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
       mov       rcx,1D364C00C90
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
       call      qword ptr [7FF8247F5170]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M04_L00
M04_L03:
       mov       rcx,r14
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF8247F5320]
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
       call      qword ptr [7FF8246A7678]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FF8244AD578]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF823F06820]
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
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF8247F5320]
       jmp       near ptr M04_L01
M04_L12:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M04_L15
M04_L13:
       test      ebx,ebx
       jne       short M04_L14
       mov       rax,213F9CA62A0
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
       mov       rdx,213F9CA6F28
       call      qword ptr [7FF82412D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FF82452FE88]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M04_L17:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M04_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF8247F5320]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF8247F5368]
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
       mov       rsi,213F9CA1518
M05_L01:
       mov       ecx,[rsi+8]
       mov       [rbx+30],ecx
       cmp       dword ptr [rbx+78],0
       je        short M05_L04
       mov       rcx,7FF8248B7BD0
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
       call      qword ptr [7FF823F05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D37AC00960
       mov       rsi,[rcx]
       jmp       short M05_L01
M05_L04:
       mov       rcx,7FF8248B7BD4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF8248B7BD0
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+70]
       mov       edx,3E8
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF8247F6370]
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
       call      qword ptr [7FF824077198]
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
       mov       r8,1D364C013D0
       mov       rbx,[r8]
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       r8d,1
       test      edi,edi
       cmove     rsi,r8
       mov       [rbp-38],rsi
       test      rsi,rsi
       je        near ptr M07_L06
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FF824074C30]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       mov       r9d,eax
       sub       r9d,esi
       mov       r14d,r9d
       add       r14d,[rbp-48]
       cmp       r9d,edi
       jne       near ptr M07_L07
M07_L00:
       test      r14d,r14d
       je        near ptr M07_L04
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FF883B94CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       [rbp-40],rcx
       mov       r13,[rbp-40]
       test      r13,r13
       je        short M07_L03
       mov       ecx,edi
       or        ecx,r14d
       jl        short M07_L02
       lea       rcx,[rbp-58]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-60]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       mov       edx,edi
       mov       r8,r13
       mov       r9d,r14d
       call      qword ptr [7FF824074C60]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
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
       jmp       short M07_L05
M07_L02:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FF824525BC0]
       int       3
M07_L03:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FF8247F5AA0]
       int       3
M07_L04:
       mov       r15,213F9CA0008
M07_L05:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       short M07_L09
M07_L06:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FF8247F5AA0]
       int       3
M07_L07:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FF8247F5AB8]
       add       r14d,eax
       jns       near ptr M07_L00
       call      qword ptr [7FF8247F5AD0]
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
       call      qword ptr [7FF8247F5AE8]
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
       call      qword ptr [7FF8247F5B00]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 431
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
       mov       rcx,213F9CA62A0
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M08_L04
       mov       esi,[rbx+8]
       test      esi,esi
       je        near ptr M08_L04
       mov       rcx,1D364C01DE0
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
       mov       rcx,1D364C00C90
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
       call      qword ptr [7FF8247F5170]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M08_L00
M08_L06:
       mov       ecx,0A
       call      qword ptr [7FF8247F5170]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M08_L01
M08_L07:
       mov       rcx,rbp
       call      qword ptr [7FF824617F00]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M08_L02
M08_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8247F5188]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF824326070]
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
       call      qword ptr [7FF8247F51A0]
M08_L10:
       mov       r13,[rax+8]
       call      qword ptr [7FF8246A7678]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FF8244AD578]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF823F06820]
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
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+54],eax
       mov       [rsp+50],esi
       mov       rcx,rbp
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rsp+54]
       mov       r9d,[rsp+50]
       mov       edx,3
       call      qword ptr [7FF8247F51B8]
       test      r13d,r15d
       jne       near ptr M08_L04
       mov       rcx,rbx
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rbp
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF8247F51D0]
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
       mov       rcx,1D364C01DE0
       mov       rcx,[rcx]
       call      qword ptr [7FF8245BC0E0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FF823F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,1D364C01DE0
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
       mov       rcx,1D364C00C90
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
       mov       rcx,1D364C01DE0
       mov       rcx,[rcx]
       call      qword ptr [7FF8245BC0E0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FF82407DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF8247F51E8]
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
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF8247F4C90]
       int       3
M10_L13:
       mov       ecx,25F
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF8247F4C90]
       int       3
M10_L14:
       mov       rcx,rdi
       call      00007FF883A38270
       mov       ecx,3003FFC
       bt        ecx,eax
       jb        short M10_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8247F5398]
       mov       rsi,rax
       mov       ecx,257
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF824326070]
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
       call      00007FF883A38270
       mov       ecx,3003FFC
       bt        ecx,eax
       jb        short M10_L17
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF8247F5398]
       mov       rbp,rax
       mov       ecx,25F
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,r14
       call      qword ptr [7FF824326070]
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
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8247F52C0]
       int       3
M10_L19:
       mov       ecx,28F
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FF8247F52C0]
       int       3
M10_L20:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF8247F53B0]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF824324180]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M10_L21:
       mov       ecx,0A
       call      qword ptr [7FF8247F5170]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M10_L04
M10_L22:
       mov       rcx,rsi
       call      qword ptr [7FF824617F00]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M10_L05
M10_L23:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8247F5188]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF824326070]
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
       call      qword ptr [7FF8247F51A0]
M10_L25:
       mov       r15,[rax+8]
       call      qword ptr [7FF8246A7678]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FF8244AD578]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF823F06820]
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
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       [rsp+44],ebx
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r13
       mov       r8d,r12d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FF8247F51B8]
       test      r15d,r14d
       jne       near ptr M10_L07
       mov       rcx,rdi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF8247F51D0]
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
       call      qword ptr [7FF9551074D8]
       movzx     ecx,byte ptr [rax+1]
       mov       [rbx+95],cl
       movzx     eax,byte ptr [rax+2]
       mov       [rbx+96],al
       mov       word ptr [rbx+90],20
       mov       dword ptr [rbx+84],2
       mov       byte ptr [rbx+9D],1
       mov       dword ptr [rbx+88],40
       call      qword ptr [7FF955107550]
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
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M12_L01:
       mov       rcx,[rcx+20]
       call      qword ptr [7FF955109688]
       mov       rcx,rax
       call      qword ptr [7FF95510BE70]
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
       call      qword ptr [7FF95510D580]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF95510B548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF955108CC8]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF95510D4E8]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M14_L00:
       mov       rax,[rbp-20]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FF955108CC8]
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FF95510A210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95510D570]
       mov       [rbp-20],rsi
       lea       rax,[M14_L00]
       add       rsp,28
       ret
; Total bytes of code 138
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
       call      qword ptr [7FF883967FD0]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF881EB1D50]; Precode of System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF881EB1C10]
       mov       rdi,rax
       test      rdi,rdi
       je        short M17_L01
       mov       rcx,[rbp+10]
       mov       r13,[rcx]
       mov       rcx,r13
       call      qword ptr [7FF881EB1418]
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
       call      qword ptr [7FF881EB1298]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       call      qword ptr [7FF881EB2420]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetCountNoLocks()
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
       call      qword ptr [7FF881EB2098]; Precode of System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       call      qword ptr [7FF881EB1C40]; Precode of System.Array.get_MaxLength()
       cmp       eax,r14d
       jge       short M17_L04
M17_L03:
       call      qword ptr [7FF881EB1C40]; Precode of System.Array.get_MaxLength()
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
       call      qword ptr [7FF881EB1BF8]
       mov       rdi,rax
       mov       r8d,[rsi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF881EB1C28]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,[rbx+18]
       mov       esi,[rax+8]
       mov       r13d,[rdi+8]
       cmp       r13d,esi
       jle       short M17_L06
M17_L05:
       call      qword ptr [7FF881EB1B60]
       mov       r8,rax
       movsxd    rdx,esi
       mov       rcx,rdi
       call      qword ptr [7FF881EB1278]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       esi
       cmp       r13d,esi
       jg        short M17_L05
M17_L06:
       mov       rcx,[rbp+10]
       mov       r13,[rcx]
       mov       rcx,r13
       call      qword ptr [7FF881EB1780]
       mov       rcx,rax
       movsxd    rdx,r14d
       call      qword ptr [7FF881EB1290]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       ecx,[rdi+8]
       call      qword ptr [7FF881EB1C00]
       mov       r14,rax
       mov       r12,r15
       test      r12,r12
       jne       short M17_L07
       mov       r12,[rbx+8]
M17_L07:
       mov       rcx,r13
       call      qword ptr [7FF881EB1578]
       mov       rcx,rax
       call      qword ptr [7FF881EB1288]; CORINFO_HELP_NEWFAST
       mov       [rbp-78],rax
       lea       rcx,[rax+10]
       mov       rdx,rsi
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+18]
       mov       rdx,rdi
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+20]
       mov       rdx,r14
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rsi+8]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       r12,[rbp-78]
       mov       [r12+28],rax
       mov       rcx,r13
       call      qword ptr [7FF881EB1540]
       mov       rcx,rax
       lea       r8,[rbp-48]
       mov       rdx,rbx
       call      qword ptr [7FF881EB2440]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].AcquirePostFirstLock(Tables<System.__Canon,System.__Canon>, Int32 ByRef)
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
       call      qword ptr [7FF881EB18F0]
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
       call      qword ptr [7FF881EB1560]
       mov       rcx,rax
       call      qword ptr [7FF881EB1288]; CORINFO_HELP_NEWFAST
       mov       [rbp-88],rax
       mov       r8,[rbp-68]
       mov       rdx,[r8+8]
       mov       r8,[r8+10]
       mov       [rbp-90],r8
       mov       r10,[rbp-70]
       mov       r9,[r10]
       mov       [rbp-98],r9
       lea       rcx,[rax+8]
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-90]
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       lea       rcx,[rax+18]
       mov       rdx,[rbp-98]
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       mov       ecx,[rbp-4C]
       mov       [rax+20],ecx
       mov       rcx,[rbp-70]
       mov       rdx,rax
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF881EB1258]
       int       3
M17_L16:
       call      qword ptr [7FF881EB1250]
       int       3
M17_L17:
       mov       rcx,[rbp+10]
       mov       edx,[rbp-48]
       call      qword ptr [7FF881EB2450]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32)
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
       call      qword ptr [7FF881EB2450]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 1103
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
       je        near ptr M18_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       near ptr M18_L07
M18_L00:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+0B8]
       mov       rbx,[rax+8]
       test      rbx,rbx
       je        near ptr M18_L08
M18_L01:
       mov       [rbp-18],rbx
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,rbx
       call      qword ptr [7FF95510A180]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M18_L04
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       short M18_L03
M18_L02:
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF95510DEF0]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M18_L04
M18_L03:
       mov       rcx,rax
       call      qword ptr [7FF95510A218]
       jmp       short M18_L02
M18_L04:
       cmp       byte ptr [rbp-10],0
       je        short M18_L05
       mov       rcx,rbx
       call      qword ptr [7FF95510A188]
M18_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
M18_L06:
       call      qword ptr [7FF95510BE50]
       int       3
M18_L07:
       mov       rcx,rax
       call      qword ptr [7FF95510A218]
       jmp       near ptr M18_L00
M18_L08:
       mov       rcx,rax
       call      qword ptr [7FF95510D528]; Precode of System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M18_L01
       sub       rsp,28
       call      qword ptr [7FF95510A210]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      qword ptr [7FF955107258]; CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-10],0
       je        short M18_L09
       mov       rcx,[rbp-18]
       call      qword ptr [7FF95510A188]
M18_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 310
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
       mov       rdi,[rbx+20]
M19_L00:
       test      rdi,rdi
       je        short M19_L02
       mov       rcx,rdi
       mov       r8,rbx
       mov       rdx,rsi
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       call      qword ptr [r11]
       mov       rbp,rax
       test      rbp,rbp
       je        short M19_L05
       mov       rcx,[rbp+0C0]
       mov       rdx,rsi
       call      qword ptr [7FF955109E40]; Precode of System.Type.op_Inequality(System.Type, System.Type)
       test      eax,eax
       jne       short M19_L03
       cmp       [rbp+0B8],rbx
       jne       short M19_L04
M19_L01:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M19_L02:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M19_L03:
       mov       rdx,[rbp+0C0]
       mov       rcx,rsi
       call      qword ptr [7FF95510BE40]
       int       3
M19_L04:
       call      qword ptr [7FF95510BE48]
       int       3
M19_L05:
       call      qword ptr [7FF9551075C0]
       mov       rdx,[rax]
       mov       rcx,rsi
       call      qword ptr [7FF955109E38]; Precode of System.Type.op_Equality(System.Type, System.Type)
       test      eax,eax
       je        short M19_L01
       call      qword ptr [7FF955108E88]
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF95510EC00]; Precode of System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       byte ptr [rbp+12],1
       lea       rcx,[rbp+30]
       mov       rdx,rdi
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF955108FC0]
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8,rbx
       call      qword ptr [7FF95510ED40]
       mov       rbp,rsi
       jmp       near ptr M19_L01
; Total bytes of code 224
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
       call      00007FF883B35510
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
       mov       rax,7FF824041B50
       mov       [rbp-78],rax
       lea       rax,[M20_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF883A92CB0
       call      rax
M20_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF883E53B10],0
       je        short M20_L04
       call      qword ptr [7FF883E41648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FF883B5BB40
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
       call      qword ptr [7FF8247FDB48]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M20_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF8247FC3A8]
       jmp       near ptr M20_L00
M20_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M20_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF823F07C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rcx,[rcx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       mov       edx,r8d
       call      qword ptr [7FF88397A1A8]; Precode of System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF883967FD8]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF883980CF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FF823F05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       xor       eax,eax
       mov       [rbp-0E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0E0],ymm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       [rbp+10],rcx
       mov       rdx,rcx
       mov       r8,[rdx+48]
       mov       [rbp-0A0],r8
       mov       rbx,1F3C716FFC0
       mov       [rbp-100],rbx
       mov       rcx,1B348000730
       mov       rcx,[rcx]
       mov       [rbp-0A8],rcx
       test      r8,r8
       je        short M00_L00
       mov       rcx,r8
       call      qword ptr [7FF823EFC9A8]; System.Object.GetType()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF823E3A610]; System.RuntimeType.IsAssignableFrom(System.Type)
       test      eax,eax
       mov       rbx,[rbp-100]
       mov       r8,[rbp-0A0]
       je        near ptr M00_L29
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
       mov       rax,7FF883B29D00
       call      rax
       movzx     esi,al
       cmp       dword ptr [7FF883E53B10],0
       jne       near ptr M00_L31
M00_L02:
       cmp       esi,0F
       je        near ptr M00_L39
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       mov       rax,7FF883B29D00
       call      rax
       movzx     esi,al
       mov       rbx,[rbp-100]
       cmp       dword ptr [7FF883E53B10],0
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
       mov       rax,7FF883B29D00
       call      rax
       movzx     esi,al
       mov       rbx,[rbp-0B8]
       cmp       dword ptr [7FF883E53B10],0
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
       call      00007FF883AA4ED0
       test      eax,eax
       jne       near ptr M00_L39
       mov       rsi,[rbp-0B0]
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L69
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M00_L40
M00_L09:
       mov       rsi,[rdi+8]
       mov       rcx,1B332001960
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M00_L41
M00_L10:
       mov       [rbp-0C0],rsi
       mov       rcx,[rbp-0C0]
       cmp       [rcx],cl
       mov       rsi,[rcx+8]
       mov       rax,[rsi+8]
       cmp       byte ptr [rcx+19],0
       je        near ptr M00_L42
       mov       rcx,1F3C716FFC0
       mov       rax,[7FF823E3A1C0]
       call      qword ptr [rax+18]
       mov       r14d,eax
M00_L11:
       mov       r15,[rsi+8]
       mov       rcx,[rsi+10]
       mov       edx,r14d
       imul      rdx,[rsi+28]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M00_L79
       mov       edx,edx
       mov       r13,[rcx+rdx*8+10]
       test      r13,r13
       je        near ptr M00_L46
M00_L12:
       cmp       r14d,[r13+20]
       jne       near ptr M00_L44
       mov       r12,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r15],rcx
       jne       near ptr M00_L45
       test      r12,r12
       je        near ptr M00_L44
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M00_L43
       mov       rcx,1F3C716FFC0
       cmp       r12,rcx
       sete      al
       movzx     eax,al
M00_L13:
       test      eax,eax
       je        near ptr M00_L44
       mov       rdx,[r13+10]
       mov       [rbp-0C8],rdx
M00_L14:
       mov       rcx,[rbp-0C8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       near ptr M00_L67
       mov       rcx,[rbp-0C8]
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        short M00_L15
       cmp       byte ptr [rbx+119],2
       jne       near ptr M00_L68
M00_L15:
       test      rbx,rbx
       je        near ptr M00_L70
       cmp       byte ptr [rbx+119],2
       jne       near ptr M00_L74
M00_L16:
       mov       rsi,[rbx+0B8]
       lea       rdx,[rbp-68]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF82451FDB0]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       esi,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M00_L75
       mov       rcx,[rcx+240]
       mov       rdi,[rcx+48]
       test      rdi,rdi
       je        near ptr M00_L75
M00_L17:
       mov       rax,[rdi+10]
       test      rax,rax
       jne       short M00_L18
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,1F3C71662A0
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
       je        near ptr M00_L22
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      esi,esi
       je        near ptr M00_L77
       mov       rcx,1B332001DE0
       mov       rcx,[rcx]
       mov       edx,esi
       call      qword ptr [7FF8245AC110]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
M00_L19:
       mov       [rbp-80],rax
       lea       rcx,[rdi+18]
       mov       rdx,[rbp-80]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+20],rcx
       mov       byte ptr [rdi+28],1
       mov       [rbp-0F0],rdi
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
       call      qword ptr [7FF8247E61D8]
       mov       [r14+3C],al
       lea       rcx,[rbp-90]
       call      qword ptr [7FF8247E61F0]
       mov       [r14+2C],eax
       test      byte ptr [rbp-84],4
       jne       near ptr M00_L78
       mov       rsi,1F3C7161518
M00_L20:
       mov       ecx,[rsi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+78],0
       jne       short M00_L21
       mov       dword ptr [r14+78],3E8
M00_L21:
       mov       [rbp-0F8],r14
       jmp       near ptr M00_L28
M00_L22:
       mov       rcx,[rax+8]
       mov       [rbp-0F0],rcx
       mov       r14,[rax+10]
       mov       rcx,[rbp-0F0]
       cmp       [rcx],cl
       mov       rcx,[rbp-0F0]
       add       rcx,18
       mov       rdx,[rcx]
       mov       edx,[rdx+8]
       sub       edx,[rcx+0C]
       cmp       edx,esi
       jl        near ptr M00_L26
M00_L23:
       lea       rcx,[r14+8]
       mov       rdx,[rbp-0F0]
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
       je        short M00_L27
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L24:
       mov       [r14+2C],eax
       test      dl,4
       jne       near ptr M00_L76
       mov       rsi,1F3C7161518
M00_L25:
       mov       ecx,[rsi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+78],0
       jne       near ptr M00_L21
       mov       dword ptr [r14+78],3E8
       jmp       near ptr M00_L21
M00_L26:
       mov       edx,esi
       call      qword ptr [7FF82451FE40]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L23
M00_L27:
       mov       eax,2
       jmp       short M00_L24
M00_L28:
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,[rbp-0A0]
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       lea       rdx,[rbp-58]
       mov       rcx,[rbp-0F0]
       cmp       [rcx],ecx
       call      qword ptr [7FF8247E6208]; System.Text.Json.PooledByteBufferWriter.get_WrittenSpan()
       lea       rcx,[rbp-58]
       call      qword ptr [7FF824515DA0]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rbx,rax
       mov       rcx,r14
       mov       rdx,[rbp-0F0]
       call      qword ptr [7FF824607DF8]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       [rbp-98],rbx
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+60]
       lea       r8,[rbp-98]
       mov       rdx,7FF824786CF0
       cmp       [rcx],ecx
       call      qword ptr [7FF824775D58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L29:
       mov       rdx,r8
       mov       rcx,rbx
       call      qword ptr [7FF8247E4DC8]
       int       3
M00_L30:
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF8243A4B10]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,[rbp-0A8]
       call      qword ptr [7FF824707288]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FF8247E5020]
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
       call      qword ptr [7FF8247E5080]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8247E5098]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L39:
       mov       ecx,3C7C
       mov       rdx,7FF8243BF2D8
       call      qword ptr [7FF824117798]
       mov       rcx,rax
       mov       rdx,1F3C716FFC0
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF8247E5038]
       int       3
M00_L40:
       mov       rcx,rsi
       call      qword ptr [7FF8243ACAF8]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rdi,rax
       jmp       near ptr M00_L09
M00_L41:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FF823E3D050
       call      qword ptr [7FF823EF6E98]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,1B332001960
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L10
M00_L42:
       mov       rcx,rax
       mov       rdx,1F3C716FFC0
       mov       r11,7FF823E40D78
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M00_L11
M00_L43:
       mov       rcx,r12
       mov       rdx,1F3C716FFC0
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L13
M00_L44:
       mov       r13,[r13+18]
       test      r13,r13
       jne       near ptr M00_L12
       jmp       short M00_L46
M00_L45:
       mov       rcx,r15
       mov       r8,1F3C716FFC0
       mov       rdx,r12
       mov       r11,7FF823E40D80
       call      qword ptr [r11]
       jmp       near ptr M00_L13
M00_L46:
       xor       edx,edx
       mov       [rbp-0C8],rdx
       mov       [rbp-0D0],rsi
       mov       rdx,1F3C716FFC0
       mov       r8,rdi
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       [rbp-0E8],rax
       mov       rax,[rsi+8]
       mov       [rbp-0D8],rax
       mov       [rbp-3C],r14d
M00_L47:
       mov       rax,[rbp-0D0]
       mov       rax,[rax+18]
       mov       [rbp-0E0],rax
       mov       rax,[rbp-0D0]
       mov       rcx,[rax+10]
       mov       rax,[rbp-0D0]
       mov       r8d,[rbp-3C]
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
       mov       [rbp-40],edx
       cmp       r8d,[rcx+8]
       jae       near ptr M00_L79
       mov       eax,r8d
       lea       rsi,[rcx+rax*8+10]
       xor       edi,edi
       xor       ebx,ebx
       xor       ecx,ecx
       mov       [rbp-44],ecx
       mov       rcx,[rbp-0E0]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M00_L56
       mov       rcx,[rbp-0E0]
       mov       eax,[rbp-40]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       short M00_L48
       xor       ecx,ecx
       call      qword ptr [7FF8247E4270]
       int       3
M00_L48:
       mov       rcx,r14
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M00_L49
       mov       rcx,r14
       call      qword ptr [7FF8247E5368]
M00_L49:
       mov       dword ptr [rbp-44],1
       mov       rdx,[rbp-0D0]
       mov       rcx,[rbp-0C0]
       cmp       rdx,[rcx+8]
       je        near ptr M00_L52
       mov       rcx,[rbp-0C0]
       mov       rax,[rcx+8]
       mov       [rbp-0D0],rax
       mov       rax,[rbp-0D8]
       mov       rdx,[rbp-0D0]
       cmp       rax,[rdx+8]
       je        near ptr M00_L63
       mov       rax,[rbp-0D0]
       mov       rax,[rax+8]
       mov       [rbp-0D8],rax
       cmp       byte ptr [rcx+19],0
       jne       short M00_L50
       mov       rcx,[rbp-0D8]
       mov       rdx,1F3C716FFC0
       mov       r11,7FF823E40D90
       call      qword ptr [r11]
       jmp       short M00_L51
M00_L50:
       mov       rcx,1F3C716FFC0
       mov       rax,[7FF823E3A1C0]
       call      qword ptr [rax+18]
M00_L51:
       mov       [rbp-3C],eax
       mov       rcx,[rbp-0C0]
       jmp       near ptr M00_L63
M00_L52:
       xor       r14d,r14d
       mov       r15,[rsi]
       test      r15,r15
       je        short M00_L58
M00_L53:
       mov       edx,[rbp-3C]
       cmp       edx,[r15+20]
       jne       short M00_L54
       mov       rdx,[r15+8]
       mov       rcx,[rbp-0D8]
       mov       r8,1F3C716FFC0
       mov       r11,7FF823E40D98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L55
M00_L54:
       inc       r14d
       mov       r15,[r15+18]
       test      r15,r15
       jne       short M00_L53
       jmp       short M00_L58
M00_L55:
       mov       rax,[r15+10]
       mov       [rbp-0C8],rax
       jmp       near ptr M00_L64
M00_L56:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L57:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L58:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13,[rsi]
       mov       rcx,1F3C716FFC0
       mov       [r15+8],rcx
       lea       rcx,[r15+10]
       mov       rdx,[rbp-0E8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-3C]
       mov       [r15+20],ecx
       mov       rcx,rsi
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0D0]
       mov       rdx,[rdx+20]
       mov       ecx,[rdx+8]
       cmp       [rbp-40],ecx
       jae       short M00_L56
       mov       ecx,[rbp-40]
       lea       rdx,[rdx+rcx*4+10]
       mov       ecx,[rdx]
       add       ecx,1
       jo        short M00_L57
       mov       [rdx],ecx
       mov       rdx,[rbp-0D0]
       mov       rdx,[rdx+20]
       mov       ecx,[rdx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M00_L56
       mov       ecx,[rbp-40]
       mov       edx,[rdx+rcx*4+10]
       mov       rcx,[rbp-0C0]
       cmp       edx,[rcx+10]
       jle       short M00_L59
       mov       edi,1
M00_L59:
       cmp       r14d,64
       jbe       short M00_L60
       mov       rdx,[rbp-0D8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FF823EF6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       ecx,1
       test      rax,rax
       cmovne    ebx,ecx
M00_L60:
       mov       rax,[rbp-0E0]
       mov       edx,[rbp-40]
       mov       rax,[rax+rdx*8+10]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M00_L61
       xor       ecx,ecx
       call      qword ptr [7FF8247E4270]
       int       3
M00_L61:
       mov       rcx,rsi
       call      00007FF883B9DA10
       test      eax,eax
       je        short M00_L62
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF8247E4288]
M00_L62:
       mov       ecx,edi
       or        ecx,ebx
       je        short M00_L66
       jmp       short M00_L65
M00_L63:
       call      M00_L80
       jmp       near ptr M00_L47
M00_L64:
       call      M00_L80
       jmp       near ptr M00_L14
M00_L65:
       mov       rcx,[rbp-0C0]
       mov       rdx,[rbp-0D0]
       mov       r8d,edi
       mov       r9d,ebx
       call      qword ptr [7FF82460C5E8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
M00_L66:
       mov       r8,[rbp-0E8]
       mov       [rbp-0C8],r8
       jmp       near ptr M00_L14
M00_L67:
       call      qword ptr [7FF8247E50E0]
       int       3
M00_L68:
       mov       rcx,rbx
       call      qword ptr [7FF8244967D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L15
M00_L69:
       mov       rcx,rsi
       mov       rdx,1F3C716FFC0
       call      qword ptr [7FF8243AD098]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       jmp       near ptr M00_L15
M00_L70:
       mov       rcx,1F3C717B990
       call      qword ptr [7FF8247E4DE0]
       mov       rbx,rax
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FF823EFC9A8]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L71
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L71
       jmp       short M00_L72
M00_L71:
       mov       rcx,rax
       call      qword ptr [7FF823EF7C30]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
M00_L72:
       mov       rsi,[rcx+30]
       test      rsi,rsi
       jne       short M00_L73
       lea       rdx,[rcx+30]
       mov       r8d,1
       call      qword ptr [7FF824064AF8]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
M00_L73:
       mov       rcx,1F3C7172DA8
       test      rsi,rsi
       cmove     rsi,rcx
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rbx
       mov       rdx,1F3C716FFC0
       mov       r8,rsi
       call      qword ptr [7FF824774918]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF824315FC8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L74:
       mov       rcx,rbx
       call      qword ptr [7FF8244967D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L16
M00_L75:
       mov       ecx,9
       call      qword ptr [7FF8247E4DF8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdi,rax
       jmp       near ptr M00_L17
M00_L76:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B348000960
       mov       rsi,[rcx]
       jmp       near ptr M00_L25
M00_L77:
       mov       rax,1F3C71662A0
       jmp       near ptr M00_L19
M00_L78:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B348000960
       mov       rsi,[rcx]
       jmp       near ptr M00_L20
M00_L79:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L80:
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp-44],0
       je        short M00_L81
       mov       rcx,[rbp-0E0]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       short M00_L83
       mov       rcx,[rbp-0E0]
       mov       eax,[rbp-40]
       mov       rbx,[rcx+rax*8+10]
       test      rbx,rbx
       je        short M00_L82
       mov       rcx,rbx
       call      00007FF883B9DA10
       test      eax,eax
       je        short M00_L81
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF8247E4288]
M00_L81:
       nop
       add       rsp,28
       ret
M00_L82:
       xor       ecx,ecx
       call      qword ptr [7FF8247E4270]
       int       3
M00_L83:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       vzeroupper
       mov       rcx,[rbp-0F8]
       mov       rdx,[rbp-0F0]
       call      qword ptr [7FF824607DF8]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       nop
       add       rsp,28
       ret
; Total bytes of code 3438
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
       call      qword ptr [7FF823EF5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      qword ptr [7FF823EF6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF8247E6298]; System.RuntimeTypeHandle.CanCastTo(System.RuntimeType, System.RuntimeType)
M02_L02:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      qword ptr [7FF823EF6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF823EFD398]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       je        short M02_L03
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF8247E4F00]
M02_L03:
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FF883B39010
       test      eax,eax
       je        short M02_L06
       mov       rcx,rsi
       call      qword ptr [7FF823E3A400]
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
       jne       short M03_L02
       mov       r8,1F3C7161518
       mov       [rcx+50],r8
M03_L02:
       mov       rcx,1F3C716FFA8
       cmp       r8,rcx
       je        short M03_L04
       cmp       dword ptr [r8+8],1
       jne       short M03_L03
       cmp       word ptr [r8+0C],0A
       je        short M03_L04
M03_L03:
       mov       rcx,1F3C7161518
       cmp       r8,rcx
       je        short M03_L04
       cmp       dword ptr [r8+8],2
       jne       short M03_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M03_L08
M03_L04:
       mov       rcx,1F3C7161518
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
       mov       rdx,7FF8243BF2D8
       call      qword ptr [7FF824117798]
       mov       rcx,rax
       call      qword ptr [7FF8247E51E8]
       int       3
M03_L09:
       or        esi,4
       jmp       short M03_L06
M03_L10:
       cmp       edx,9
       je        short M03_L11
       mov       ecx,38A0
       mov       rdx,7FF8243BF2D8
       call      qword ptr [7FF824117798]
       mov       rcx,rax
       call      qword ptr [7FF8247E51A0]
       int       3
M03_L11:
       or        esi,8
       jmp       near ptr M03_L00
M03_L12:
       mov       ecx,38A0
       mov       rdx,7FF8243BF2D8
       call      qword ptr [7FF824117798]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FF8247E51B8]
       int       3
M03_L13:
       mov       ecx,38A0
       mov       rdx,7FF8243BF2D8
       call      qword ptr [7FF824117798]
       mov       rcx,rax
       call      qword ptr [7FF8247E51D0]
       int       3
; Total bytes of code 409
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
       mov       rcx,1B332000C90
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
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
       call      qword ptr [7FF8247E4DF8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M04_L00
M04_L03:
       mov       rcx,r14
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF8247E5350]
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
       call      qword ptr [7FF8246976F0]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FF82449D590]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF823EF6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF8247E5350]
       jmp       near ptr M04_L01
M04_L12:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M04_L15
M04_L13:
       test      ebx,ebx
       jne       short M04_L14
       mov       rax,1F3C71662A0
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
       mov       rdx,1F3C7166F28
       call      qword ptr [7FF82411D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FF82451FEE8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M04_L17:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M04_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF8247E5350]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF8247E5380]
       jmp       near ptr M04_L01
M04_L18:
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
       jne       near ptr M05_L20
       mov       rcx,1B332001DE0
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       ebp,edx
       mov       rcx,1B332000C90
       mov       r14,[rcx]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0A
       jle       short M05_L04
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M05_L04
M05_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M05_L06
       mov       eax,[rcx+8]
       cmp       eax,r15d
       jbe       near ptr M05_L06
       mov       eax,r15d
       shl       rax,4
       mov       r13,[rcx+rax+10]
       test      r13,r13
       je        short M05_L06
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [r14+9D],0
       jne       short M05_L05
M05_L01:
       mov       rdx,r13
M05_L02:
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M05_L03:
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
M05_L04:
       mov       ecx,0A
       call      qword ptr [7FF8247E4DF8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L05:
       mov       rcx,r13
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       ebp,[r13+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF8247E5350]
       jmp       short M05_L01
M05_L06:
       mov       rax,[rdi+10]
       cmp       [rax+8],r15d
       jbe       near ptr M05_L15
       mov       ecx,r15d
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        near ptr M05_L14
       mov       r13,[rax+8]
       call      qword ptr [7FF8246976F0]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       ebp,eax
       sub       ebp,ecx
       xor       esi,esi
       jmp       short M05_L10
M05_L07:
       cmp       ebp,[r13+8]
       jae       near ptr M05_L26
       mov       ecx,ebp
       mov       r12,[r13+rcx*8+10]
       cmp       [r12],r12b
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rcx,r12
       call      qword ptr [7FF82449D590]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r12+8]
       mov       eax,[r12+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M05_L08
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       mov       [rsp+30],rdx
       mov       r8d,eax
       xor       r10d,r10d
       mov       [rcx+r8*8+10],r10
       mov       [r12+10],eax
M05_L08:
       mov       rcx,r12
       call      qword ptr [7FF823EF6820]; System.Threading.Monitor.Exit(System.Object)
       mov       r12,[rsp+30]
       test      r12,r12
       jne       short M05_L11
       inc       ebp
       cmp       [r13+8],ebp
       jne       short M05_L09
       xor       ebp,ebp
M05_L09:
       inc       esi
M05_L10:
       cmp       [r13+8],esi
       jg        short M05_L07
       jmp       short M05_L12
M05_L11:
       mov       r13,r12
       jmp       short M05_L13
M05_L12:
       xor       r13d,r13d
M05_L13:
       test      r13,r13
       je        short M05_L14
       cmp       byte ptr [r14+9D],0
       je        near ptr M05_L01
       mov       rcx,r13
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF8247E5350]
       jmp       near ptr M05_L01
M05_L14:
       mov       ecx,10
       shlx      ebp,ecx,r15d
       jmp       short M05_L17
M05_L15:
       test      ebp,ebp
       jne       short M05_L16
       mov       rdx,1F3C71662A0
       jmp       near ptr M05_L02
M05_L16:
       mov       ecx,ebp
       mov       rdx,1F3C7166F28
       call      qword ptr [7FF82411D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M05_L17:
       cmp       ebp,800
       jge       short M05_L18
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M05_L19
M05_L18:
       mov       ecx,ebp
       xor       edx,edx
       call      qword ptr [7FF82451FEE8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M05_L19:
       cmp       byte ptr [r14+9D],0
       je        near ptr M05_L01
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF8247E5350]
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF8247E5380]
       jmp       near ptr M05_L01
M05_L20:
       mov       ecx,[rbx+8]
       mov       rax,[rbx]
       mov       eax,[rax+8]
       sub       eax,[rbx+0C]
       add       ecx,eax
       cmp       edx,ecx
       jg        short M05_L21
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       r8,[rbx]
       mov       rcx,[rbx]
       xor       r9d,r9d
       call      qword ptr [7FF82406DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       eax,[rbx+8]
       sub       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+8],eax
       jmp       near ptr M05_L03
M05_L21:
       mov       ecx,[rbx+0C]
       sub       ecx,[rbx+8]
       add       ecx,edx
       cmp       ecx,7FFFFFC7
       jbe       short M05_L22
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8247E5218]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L22:
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
       jne       short M05_L23
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M05_L24
M05_L23:
       mov       rcx,1B332001DE0
       mov       rcx,[rcx]
       call      qword ptr [7FF8245AC110]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rsi,rax
M05_L24:
       mov       rdi,[rbx]
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       je        short M05_L25
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       rcx,rdi
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF82406DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
M05_L25:
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+10],0
       je        near ptr M05_L03
       cmp       dword ptr [rdi+8],0
       je        near ptr M05_L03
       mov       rcx,1B332001DE0
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
       jmp       qword ptr [7FF8245AC118]; Precode of System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M05_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1092
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
       je        short M06_L01
       mov       r8d,ecx
       add       r8,r10
       mov       r9d,[rax+8]
       cmp       r8,r9
       ja        short M06_L02
       lea       rax,[rax+r10+10]
M06_L00:
       mov       [rdx],rax
       mov       [rdx+8],ecx
       mov       rax,rdx
       add       rsp,28
       ret
M06_L01:
       or        r10d,ecx
       jne       short M06_L02
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M06_L00
M06_L02:
       call      qword ptr [7FF824067198]
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
       mov       r8,1B3320013D0
       mov       rbx,[r8]
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       r8d,1
       test      edi,edi
       cmove     rsi,r8
       mov       [rbp-38],rsi
       test      rsi,rsi
       je        near ptr M07_L06
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FF824064C30]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       mov       r9d,eax
       sub       r9d,esi
       mov       r14d,r9d
       add       r14d,[rbp-48]
       cmp       r9d,edi
       jne       near ptr M07_L07
M07_L00:
       test      r14d,r14d
       je        near ptr M07_L04
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FF883B94CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       [rbp-40],rcx
       mov       r13,[rbp-40]
       test      r13,r13
       je        short M07_L03
       mov       ecx,edi
       or        ecx,r14d
       jl        short M07_L02
       lea       rcx,[rbp-58]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-60]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       mov       edx,edi
       mov       r8,r13
       mov       r9d,r14d
       call      qword ptr [7FF824064C60]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
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
       jmp       short M07_L05
M07_L02:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FF824515BC0]
       int       3
M07_L03:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FF8247E56C8]
       int       3
M07_L04:
       mov       r15,1F3C7160008
M07_L05:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       short M07_L09
M07_L06:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FF8247E56C8]
       int       3
M07_L07:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FF8247E56E0]
       add       r14d,eax
       jns       near ptr M07_L00
       call      qword ptr [7FF8247E56F8]
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
       call      qword ptr [7FF8247E5710]
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
       call      qword ptr [7FF8247E5728]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 431
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
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M08_L37
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M08_L37
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
       mov       rcx,1F3C71662A0
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M08_L36
       cmp       dword ptr [rbx+8],0
       je        near ptr M08_L36
       mov       rcx,1B332001DE0
       mov       rsi,[rcx]
       mov       ecx,[rbx+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M08_L38
       mov       rcx,[rcx+240]
       mov       r15,[rcx+50]
       test      r15,r15
       je        near ptr M08_L38
M08_L01:
       mov       rax,[r15+10]
       test      rax,rax
       jne       near ptr M08_L16
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
       je        near ptr M08_L07
       mov       rcx,[rbp-80]
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M08_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FF8247E5368]
M08_L02:
       mov       dword ptr [rbp-40],1
       mov       rcx,[r15+10]
       lea       r8,[rbp-48]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF82411CF30]; System.Runtime.CompilerServices.ConditionalWeakTable`2+Container[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindEntry(System.__Canon, System.Object ByRef)
       cmp       eax,0FFFFFFFF
       jne       near ptr M08_L08
       mov       r12,[r15+10]
       mov       ecx,[r12+28]
       mov       rax,[r12+18]
       cmp       ecx,[rax+8]
       jge       near ptr M08_L09
M08_L03:
       cmp       byte ptr [r12+2C],0
       jne       near ptr M08_L10
       mov       byte ptr [r12+2C],1
       mov       rcx,r13
       call      00007FF883AFE4B0
       test      eax,eax
       je        near ptr M08_L06
M08_L04:
       mov       r15d,eax
       and       r15d,7FFFFFFF
       mov       eax,[r12+28]
       mov       [rbp-4C],eax
       lea       ecx,[rax+1]
       mov       [r12+28],ecx
       mov       rcx,[r12+18]
       cmp       eax,[rcx+8]
       jae       near ptr M08_L11
       mov       edx,eax
       shl       rdx,4
       lea       r8,[rcx+rdx+10]
       mov       [r8],r15d
       mov       [rbp-88],r8
       mov       rcx,r13
       xor       edx,edx
       call      00007FF883B63160
       test      rax,rax
       je        near ptr M08_L12
M08_L05:
       mov       rcx,[rbp-88]
       mov       [rcx+8],rax
       mov       rcx,[r12+10]
       mov       eax,[rcx+8]
       dec       eax
       and       eax,r15d
       mov       rdx,[r12+18]
       mov       r15d,[rbp-4C]
       cmp       r15d,[rdx+8]
       jae       near ptr M08_L11
       mov       r8d,r15d
       shl       r8,4
       mov       r10,rcx
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       near ptr M08_L11
       mov       r10d,[r10+rax*4+10]
       mov       [rdx+r8+14],r10d
       mov       [rcx+rax*4+10],r15d
       mov       byte ptr [r12+2C],0
       jmp       near ptr M08_L13
M08_L06:
       mov       rcx,r13
       call      qword ptr [7FF823EFE970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M08_L04
M08_L07:
       xor       ecx,ecx
       call      qword ptr [7FF8247E4270]
       int       3
M08_L08:
       mov       ecx,36
       call      qword ptr [7FF8247E6220]
       int       3
M08_L09:
       mov       rcx,r12
       call      qword ptr [7FF8247E6238]
       mov       r12,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L03
M08_L10:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8247E6250]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF824315FC8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M08_L12:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF8247E6268]
       jmp       near ptr M08_L05
M08_L13:
       mov       rcx,[rbp-80]
       call      00007FF883B9DA10
       test      eax,eax
       jne       near ptr M08_L39
M08_L14:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       lea       rcx,[rsi+18]
       mov       eax,1
       xchg      al,[rcx]
       movzx     eax,al
       test      eax,eax
       je        near ptr M08_L27
M08_L15:
       mov       rax,r13
M08_L16:
       xor       r15d,r15d
       mov       r13d,1
       cmp       [rax+8],r14d
       jbe       near ptr M08_L23
       mov       r15d,1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       [rbx+8],ecx
       jne       near ptr M08_L41
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
       je        near ptr M08_L23
       mov       rcx,[rsi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M08_L46
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M08_L17
       mov       rcx,rsi
       mov       edx,r14d
       call      qword ptr [7FF8247E4E58]
M08_L17:
       mov       r13,[rax+8]
       call      qword ptr [7FF8246976F0]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       mov       edx,[r13+8]
       mov       [rbp-6C],edx
       test      edx,edx
       jle       near ptr M08_L45
       mov       [rbp-70],edx
M08_L18:
       cmp       eax,edx
       jae       near ptr M08_L46
       mov       [rbp-5C],eax
       mov       ecx,eax
       mov       r10,[r13+rcx*8+10]
       mov       [rbp-90],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-60],r9d
       mov       rcx,r10
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M08_L19
       mov       rcx,[rbp-90]
       call      qword ptr [7FF8247E5368]
M08_L19:
       mov       rax,[rbp-90]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-64],r8d
       cmp       [rcx+8],r8d
       jbe       short M08_L21
       test      r8d,r8d
       je        near ptr M08_L30
M08_L20:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-64]
       inc       ecx
       mov       rax,[rbp-90]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-60],1
M08_L21:
       mov       rcx,rax
       call      00007FF883B9DA10
       test      eax,eax
       jne       near ptr M08_L42
M08_L22:
       cmp       dword ptr [rbp-60],0
       je        near ptr M08_L43
       mov       r13d,1
M08_L23:
       mov       rcx,1B332000C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       je        near ptr M08_L36
       mov       rcx,rbx
       call      00007FF883AFE4B0
       test      eax,eax
       je        near ptr M08_L31
       mov       [rbp-68],eax
M08_L24:
       mov       edx,[rbx+8]
       mov       [rbp-3C],edx
       mov       rcx,rsi
       call      00007FF883AFE4B0
       test      eax,eax
       je        near ptr M08_L32
M08_L25:
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-68]
       mov       r9d,[rbp-3C]
       mov       edx,3
       call      qword ptr [7FF8247E4E70]
       test      r13d,r15d
       jne       near ptr M08_L36
       mov       rcx,rbx
       call      qword ptr [7FF8243ACC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      00007FF883AFE4B0
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M08_L33
M08_L26:
       test      r15d,r15d
       jne       near ptr M08_L34
       mov       r14d,0FFFFFFFF
       mov       ecx,1
       jmp       near ptr M08_L35
M08_L27:
       mov       r15,1B332001F30
       mov       r12,[r15]
       test      r12,r12
       jne       short M08_L28
       mov       rcx,offset MT_System.Func<System.Object, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,1B332001F28
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Buffers.SharedArrayPool`1+<>c[[System.Byte, System.Private.CoreLib]].<InitializeTlsBucketsAndTrimming>b__11_0(System.Object)
       mov       [r12+18],rcx
       mov       rcx,r15
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M08_L28:
       mov       rcx,offset MT_System.Gen2GcCallback
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       xor       edx,edx
       call      00007FF883B2B5A0
       test      rax,rax
       je        near ptr M08_L40
M08_L29:
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [r15+18],rcx
       jmp       near ptr M08_L15
M08_L30:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       near ptr M08_L20
M08_L31:
       mov       rcx,rbx
       call      qword ptr [7FF823EFE970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       [rbp-68],eax
       jmp       near ptr M08_L24
M08_L32:
       mov       rcx,rsi
       call      qword ptr [7FF823EFE970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M08_L25
M08_L33:
       mov       rcx,rsi
       call      qword ptr [7FF823EFE970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M08_L26
M08_L34:
       xor       ecx,ecx
M08_L35:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,ebx
       call      qword ptr [7FF8247E4E88]
M08_L36:
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
M08_L37:
       mov       ecx,9
       call      qword ptr [7FF8247E4DF8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M08_L00
M08_L38:
       mov       ecx,0A
       call      qword ptr [7FF8247E4DF8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M08_L01
M08_L39:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FF8247E4288]
       jmp       near ptr M08_L14
M08_L40:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8247E63E8]
       jmp       near ptr M08_L29
M08_L41:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8247E4E40]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF823E34000
       call      qword ptr [7FF824117798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF824316070]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M08_L42:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FF8247E4288]
       jmp       near ptr M08_L22
M08_L43:
       mov       eax,[rbp-5C]
       inc       eax
       mov       ecx,eax
       mov       edx,[rbp-6C]
       cmp       edx,ecx
       jne       short M08_L44
       xor       ecx,ecx
M08_L44:
       mov       r8d,[rbp-70]
       dec       r8d
       mov       [rbp-70],r8d
       mov       eax,ecx
       jne       near ptr M08_L18
M08_L45:
       xor       r13d,r13d
       jmp       near ptr M08_L23
M08_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-40],0
       je        short M08_L48
       cmp       qword ptr [rbp-80],0
       jne       short M08_L47
       xor       ecx,ecx
       call      qword ptr [7FF8247E4270]
       int       3
M08_L47:
       mov       rcx,[rbp-80]
       call      00007FF883B9DA10
       test      eax,eax
       je        short M08_L48
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FF8247E4288]
M08_L48:
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
; System.Text.Json.JsonSerializerOptions..ctor()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       dword ptr [rbx+7C],4000
       call      qword ptr [7FF9551074D8]
       movzx     ecx,byte ptr [rax+1]
       mov       [rbx+95],cl
       movzx     eax,byte ptr [rax+2]
       mov       [rbx+96],al
       mov       word ptr [rbx+90],20
       mov       dword ptr [rbx+84],2
       mov       byte ptr [rbx+9D],1
       mov       dword ptr [rbx+88],40
       call      qword ptr [7FF955107550]
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
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M11_L01:
       mov       rcx,[rcx+20]
       call      qword ptr [7FF955109688]
       mov       rcx,rax
       call      qword ptr [7FF95510BE70]
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
       call      qword ptr [7FF95510D580]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF95510B548]
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
       call      qword ptr [7FF955108CC8]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF95510D4E8]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M13_L00:
       mov       rax,[rbp-20]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FF955108CC8]
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FF95510A210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95510D570]
       mov       [rbp-20],rsi
       lea       rax,[M13_L00]
       add       rsp,28
       ret
; Total bytes of code 138
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
       call      qword ptr [7FF883967FD0]; CORINFO_HELP_ASSIGN_REF
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
       je        short M15_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M15_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M15_L02
M15_L00:
       test      rax,rax
       je        short M15_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M15_L02
       test      rax,rax
       je        short M15_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M15_L02
       test      rax,rax
       jne       short M15_L03
M15_L01:
       xor       edx,edx
M15_L02:
       mov       rax,rdx
       ret
M15_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M15_L02
       test      rax,rax
       je        short M15_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M15_L02
       jmp       short M15_L00
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
       jbe       near ptr M16_L15
       mov       rcx,[rax+10]
       call      qword ptr [7FF881EB1D50]; Precode of System.Threading.Monitor.Enter(System.Object)
       mov       dword ptr [rbp-48],1
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+8]
       jne       near ptr M16_L17
       mov       rax,[rbx+10]
       mov       r14d,[rax+8]
       xor       r15d,r15d
       test      dil,dil
       je        short M16_L01
       mov       rcx,[rbx+8]
       call      qword ptr [7FF881EB1C10]
       mov       rdi,rax
       test      rdi,rdi
       je        short M16_L01
       mov       rcx,[rbp+10]
       mov       r13,[rcx]
       mov       rcx,r13
       call      qword ptr [7FF881EB1418]
       mov       r15,rax
       mov       rcx,rdi
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       call      qword ptr [r11]
       mov       r8,rax
       test      r8,r8
       je        short M16_L00
       mov       rcx,r15
       cmp       [r8],rcx
       je        short M16_L00
       mov       rdx,rax
       call      qword ptr [7FF881EB1298]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
       mov       r8,r15
M16_L00:
       mov       r15,r8
M16_L01:
       test      sil,sil
       je        short M16_L04
       test      r15,r15
       jne       short M16_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FF881EB2420]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetCountNoLocks()
       mov       rcx,[rbx+10]
       mov       ecx,[rcx+8]
       shr       ecx,2
       cmp       eax,ecx
       jl        near ptr M16_L14
M16_L02:
       mov       rax,[rbx+10]
       mov       eax,[rax+8]
       add       eax,eax
       js        short M16_L03
       mov       ecx,eax
       call      qword ptr [7FF881EB2098]; Precode of System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       call      qword ptr [7FF881EB1C40]; Precode of System.Array.get_MaxLength()
       cmp       eax,r14d
       jge       short M16_L04
M16_L03:
       call      qword ptr [7FF881EB1C40]; Precode of System.Array.get_MaxLength()
       mov       r14d,eax
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+10],7FFFFFFF
M16_L04:
       mov       rsi,[rbx+18]
       mov       rdi,rsi
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+18],0
       je        short M16_L06
       cmp       dword ptr [rsi+8],400
       jge       short M16_L06
       mov       eax,[rsi+8]
       add       eax,eax
       movsxd    rcx,eax
       call      qword ptr [7FF881EB1BF8]
       mov       rdi,rax
       mov       r8d,[rsi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF881EB1C28]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,[rbx+18]
       mov       esi,[rax+8]
       mov       r13d,[rdi+8]
       cmp       r13d,esi
       jle       short M16_L06
M16_L05:
       call      qword ptr [7FF881EB1B60]
       mov       r8,rax
       movsxd    rdx,esi
       mov       rcx,rdi
       call      qword ptr [7FF881EB1278]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       esi
       cmp       r13d,esi
       jg        short M16_L05
M16_L06:
       mov       rcx,[rbp+10]
       mov       r13,[rcx]
       mov       rcx,r13
       call      qword ptr [7FF881EB1780]
       mov       rcx,rax
       movsxd    rdx,r14d
       call      qword ptr [7FF881EB1290]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       ecx,[rdi+8]
       call      qword ptr [7FF881EB1C00]
       mov       r14,rax
       mov       r12,r15
       test      r12,r12
       jne       short M16_L07
       mov       r12,[rbx+8]
M16_L07:
       mov       rcx,r13
       call      qword ptr [7FF881EB1578]
       mov       rcx,rax
       call      qword ptr [7FF881EB1288]; CORINFO_HELP_NEWFAST
       mov       [rbp-78],rax
       lea       rcx,[rax+10]
       mov       rdx,rsi
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+18]
       mov       rdx,rdi
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+20]
       mov       rdx,r14
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rsi+8]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       r12,[rbp-78]
       mov       [r12+28],rax
       mov       rcx,r13
       call      qword ptr [7FF881EB1540]
       mov       rcx,rax
       lea       r8,[rbp-48]
       mov       rdx,rbx
       call      qword ptr [7FF881EB2440]
       mov       rbx,[rbx+10]
       xor       eax,eax
       jmp       near ptr M16_L13
M16_L08:
       mov       [rbp-58],rax
       mov       rdx,[rbx+rax*8+10]
       test      rdx,rdx
       je        near ptr M16_L12
M16_L09:
       test      r15,r15
       jne       short M16_L10
       mov       [rbp-68],rdx
       mov       r8d,[rdx+20]
       jmp       short M16_L11
M16_L10:
       mov       [rbp-68],rdx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       call      qword ptr [7FF881EB18F0]
       mov       r8,[rbp-68]
       mov       rdx,[r8+8]
       mov       rcx,r15
       mov       r11,rax
       call      qword ptr [rax]
       mov       r8d,eax
M16_L11:
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
       jae       near ptr M16_L15
       mov       eax,r11d
       lea       rax,[rcx+rax*8+10]
       mov       [rbp-70],rax
       mov       rcx,r13
       call      qword ptr [7FF881EB1560]
       mov       rcx,rax
       call      qword ptr [7FF881EB1288]; CORINFO_HELP_NEWFAST
       mov       [rbp-88],rax
       mov       r8,[rbp-68]
       mov       rdx,[r8+8]
       mov       r8,[r8+10]
       mov       [rbp-90],r8
       mov       r10,[rbp-70]
       mov       r9,[r10]
       mov       [rbp-98],r9
       lea       rcx,[rax+8]
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-90]
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       lea       rcx,[rax+18]
       mov       rdx,[rbp-98]
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       mov       ecx,[rbp-4C]
       mov       [rax+20],ecx
       mov       rcx,[rbp-70]
       mov       rdx,rax
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       cmp       esi,[r14+8]
       jae       short M16_L15
       mov       eax,esi
       lea       rax,[r14+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        short M16_L16
       mov       [rax],edx
       mov       rsi,[rbp-80]
       test      rsi,rsi
       mov       rdx,rsi
       jne       near ptr M16_L09
M16_L12:
       mov       rsi,[rbp-58]
       inc       esi
       mov       rax,rsi
M16_L13:
       mov       ecx,[rbx+8]
       cmp       ecx,eax
       jg        near ptr M16_L08
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
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       jmp       short M16_L17
M16_L14:
       mov       rcx,[rbp+10]
       mov       edx,[rcx+10]
       add       edx,edx
       mov       [rcx+10],edx
       test      edx,edx
       jge       short M16_L17
       mov       dword ptr [rcx+10],7FFFFFFF
       jmp       short M16_L17
M16_L15:
       call      qword ptr [7FF881EB1258]
       int       3
M16_L16:
       call      qword ptr [7FF881EB1250]
       int       3
M16_L17:
       mov       rcx,[rbp+10]
       mov       edx,[rbp-48]
       call      qword ptr [7FF881EB2450]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32)
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
       call      qword ptr [7FF881EB2450]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 1103
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
       je        near ptr M17_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       near ptr M17_L07
M17_L00:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+0B8]
       mov       rbx,[rax+8]
       test      rbx,rbx
       je        near ptr M17_L08
M17_L01:
       mov       [rbp-18],rbx
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,rbx
       call      qword ptr [7FF95510A180]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M17_L04
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       short M17_L03
M17_L02:
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF95510DEF0]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M17_L04
M17_L03:
       mov       rcx,rax
       call      qword ptr [7FF95510A218]
       jmp       short M17_L02
M17_L04:
       cmp       byte ptr [rbp-10],0
       je        short M17_L05
       mov       rcx,rbx
       call      qword ptr [7FF95510A188]; Precode of System.Threading.Monitor.Exit(System.Object)
M17_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
M17_L06:
       call      qword ptr [7FF95510BE50]
       int       3
M17_L07:
       mov       rcx,rax
       call      qword ptr [7FF95510A218]
       jmp       near ptr M17_L00
M17_L08:
       mov       rcx,rax
       call      qword ptr [7FF95510D528]; Precode of System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M17_L01
       sub       rsp,28
       call      qword ptr [7FF95510A210]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      qword ptr [7FF955107258]; CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-10],0
       je        short M17_L09
       mov       rcx,[rbp-18]
       call      qword ptr [7FF95510A188]; Precode of System.Threading.Monitor.Exit(System.Object)
M17_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 310
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
       jne       short M18_L00
       mov       rdi,[rbx+20]
M18_L00:
       test      rdi,rdi
       je        short M18_L02
       mov       rcx,rdi
       mov       r8,rbx
       mov       rdx,rsi
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       call      qword ptr [r11]
       mov       rbp,rax
       test      rbp,rbp
       je        short M18_L05
       mov       rcx,[rbp+0C0]
       mov       rdx,rsi
       call      qword ptr [7FF955109E40]; Precode of System.Type.op_Inequality(System.Type, System.Type)
       test      eax,eax
       jne       short M18_L03
       cmp       [rbp+0B8],rbx
       jne       short M18_L04
M18_L01:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M18_L02:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M18_L03:
       mov       rdx,[rbp+0C0]
       mov       rcx,rsi
       call      qword ptr [7FF95510BE40]
       int       3
M18_L04:
       call      qword ptr [7FF95510BE48]
       int       3
M18_L05:
       call      qword ptr [7FF9551075C0]
       mov       rdx,[rax]
       mov       rcx,rsi
       call      qword ptr [7FF955109E38]; Precode of System.Type.op_Equality(System.Type, System.Type)
       test      eax,eax
       je        short M18_L01
       call      qword ptr [7FF955108E88]
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF95510EC00]; Precode of System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       byte ptr [rbp+12],1
       lea       rcx,[rbp+30]
       mov       rdx,rdi
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF955108FC0]
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8,rbx
       call      qword ptr [7FF95510ED40]
       mov       rbp,rsi
       jmp       near ptr M18_L01
; Total bytes of code 224
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
       je        near ptr M19_L08
M19_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M19_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M19_L09
M19_L01:
       test      rdi,rdi
       jne       near ptr M19_L07
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
       call      00007FF883B35510
       mov       r14,rax
       test      r14,r14
       je        near ptr M19_L10
M19_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M19_L05
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
       mov       rax,7FF824031B50
       mov       [rbp-78],rax
       lea       rax,[M19_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF883A92CB0
       call      rax
M19_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF883E53B10],0
       je        short M19_L04
       call      qword ptr [7FF883E41648]; CORINFO_HELP_STOP_FOR_GC
M19_L04:
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
M19_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF883B5BB40
       mov       rdx,rax
       test      rdx,rdx
       je        short M19_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M19_L11
M19_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M19_L07:
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
M19_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF8247ED548]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M19_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF8247E7930]
       jmp       near ptr M19_L00
M19_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M19_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF823EF7C78]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M19_L02
M19_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rcx,[rcx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       mov       edx,r8d
       call      qword ptr [7FF88397A1A8]; Precode of System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF883967FD8]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF883980CF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M21_L01
       cmp       [rax],ecx
       jle       short M21_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M21_L03
M21_L00:
       add       rsp,20
       pop       rbx
       ret
M21_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M21_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M21_L00
M21_L02:
       cmp       [rax+4],edx
       jle       short M21_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M21_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M21_L03
       jmp       short M21_L00
M21_L03:
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
       jne       short M22_L00
       ret
M22_L00:
       jmp       qword ptr [7FF823EF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L36
       mov       [rbp-40],rcx
       mov       rcx,1EA83C01E00
       mov       r14,[rcx]
       cmp       byte ptr [r14+9F],0
       je        near ptr M00_L37
M00_L01:
       mov       rdx,[r14+18]
       test      rdx,rdx
       jne       near ptr M00_L07
       xor       esi,esi
       cmp       byte ptr [r14+9E],0
       je        near ptr M00_L06
       mov       rsi,[r14+8]
       test      rsi,rsi
       je        near ptr M00_L38
M00_L02:
       mov       rdi,[rsi+8]
       mov       rcx,1EA83C01960
       mov       r15,[rcx]
       test      r15,r15
       jne       short M00_L03
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF823E4D050
       mov       [r15+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [r15+20],rcx
       mov       rcx,1EA83C01960
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M00_L03:
       cmp       [rdi],dil
       mov       r13,[rdi+8]
       mov       rcx,[r13+8]
       cmp       byte ptr [rdi+19],0
       je        near ptr M00_L39
       mov       rcx,22B18A419B8
       mov       rax,[7FF823E4A1C0]
       call      qword ptr [rax+18]
       mov       r12d,eax
M00_L04:
       lea       r9,[rbp-48]
       mov       [rsp+20],r9
       mov       r9d,r12d
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       mov       r8,22B18A419B8
       call      qword ptr [7FF824326658]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       jne       short M00_L05
       mov       r8,rsi
       mov       rdx,22B18A419B8
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
       mov       r8,22B18A419B8
       call      qword ptr [7FF82432C510]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
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
       je        near ptr M00_L35
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
M00_L07:
       mov       r14,rdx
       test      r14,r14
       je        short M00_L08
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
       cmp       [r14],rcx
       jne       near ptr M00_L42
M00_L08:
       mov       rsi,[r14+0B8]
       lea       rdx,[rbp-58]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF824607A50]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       r15d,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M00_L43
       mov       rcx,[rcx+240]
       mov       rsi,[rcx+48]
       test      rsi,rsi
       je        near ptr M00_L43
M00_L09:
       mov       rax,[rsi+10]
       test      rax,rax
       jne       short M00_L10
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,22B18A462A0
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
M00_L10:
       mov       ecx,[rax+18]
       lea       edx,[rcx+1]
       mov       [rax+18],edx
       test      ecx,ecx
       je        near ptr M00_L16
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      r15d,r15d
       je        near ptr M00_L45
       mov       rcx,1EA83C01E08
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FF82462B8C8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
M00_L11:
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
       je        short M00_L15
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L12:
       mov       [r13+2C],eax
       test      dl,4
       jne       near ptr M00_L46
       mov       r15,22B18A41518
M00_L13:
       mov       ecx,[r15+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       short M00_L14
       mov       dword ptr [r13+78],3E8
M00_L14:
       mov       [rbp-150],r13
       jmp       near ptr M00_L22
M00_L15:
       mov       eax,2
       jmp       short M00_L12
M00_L16:
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
       jl        near ptr M00_L20
M00_L17:
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
       je        short M00_L21
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L18:
       mov       [r13+2C],eax
       test      dl,4
       jne       near ptr M00_L44
       mov       rsi,22B18A41518
M00_L19:
       mov       ecx,[rsi+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       near ptr M00_L14
       mov       dword ptr [r13+78],3E8
       jmp       near ptr M00_L14
M00_L20:
       mov       edx,r15d
       call      qword ptr [7FF824607AE0]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L17
M00_L21:
       mov       eax,2
       jmp       short M00_L18
M00_L22:
       cmp       byte ptr [r14+116],0
       jne       near ptr M00_L30
       mov       rcx,[r14+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M00_L28
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L28
       mov       rsi,[r14+0B8]
       mov       rcx,[rbp-40]
       cmp       [rsi],sil
       call      qword ptr [7FF823F0C9A8]; System.Object.GetType()
       mov       r9,22B18A419B8
       cmp       rax,r9
       je        near ptr M00_L28
       mov       r14,[rsi+10]
       test      r14,r14
       je        near ptr M00_L31
       mov       r9,[r14+0C0]
       cmp       r9,rax
       jne       near ptr M00_L31
M00_L23:
       cmp       byte ptr [r14+11A],0
       je        near ptr M00_L27
M00_L24:
       mov       r8,[r14+0F8]
       test      r8,r8
       cmovne    r14,r8
       mov       r8,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],r8
       jne       near ptr M00_L33
       mov       r9,[rbp-40]
       mov       r8,r9
       test      r8,r8
       je        short M00_L25
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       cmp       [r8],rcx
       jne       near ptr M00_L32
M00_L25:
       mov       [rbp-118],r8
       lea       r8,[rbp-118]
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FF824607BB8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       xor       edx,edx
       mov       [rbp-118],rdx
M00_L26:
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
       call      qword ptr [7FF82460FA68]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rcx,[rbp-128]
       mov       eax,[rbp-120]
       mov       [rbp-140],rcx
       mov       [rbp-138],eax
       lea       rcx,[rbp-140]
       call      qword ptr [7FF824525DA0]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rsi,rax
       jmp       near ptr M00_L34
M00_L27:
       mov       rcx,r14
       call      qword ptr [7FF82460E1A8]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[r14+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+11A],1
       jmp       near ptr M00_L24
M00_L28:
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
       call      qword ptr [7FF82460F108]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-110]
       mov       [rsp+20],rcx
       mov       rcx,[r14+158]
       mov       r9,[r14+0B8]
       lea       r8,[rbp-40]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF82460F120]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L29:
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF82460FA50]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M00_L26
M00_L30:
       mov       rax,[r14+148]
       mov       rdx,r13
       mov       r8,[rbp-40]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M00_L29
M00_L31:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9d,101
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8d,1
       call      qword ptr [7FF8243BCAE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r14,rax
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L23
M00_L32:
       mov       rdx,r9
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L33:
       mov       rcx,r14
       mov       rdx,r13
       mov       r8,[rbp-40]
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L26
M00_L34:
       mov       rcx,r13
       mov       rdx,[rbp-148]
       call      qword ptr [7FF82460FA80]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       [rbp-130],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-130]
       mov       rdx,7FF8247DE4E0
       cmp       [rcx],ecx
       call      qword ptr [7FF8247A7390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L35:
       mov       rdx,[r14+20]
       mov       rcx,22B18A419B8
       call      qword ptr [7FF8248B7258]
       int       3
M00_L36:
       call      qword ptr [7FF82452E5F8]
       mov       ecx,1C4D
       mov       rdx,7FF824274870
       call      qword ptr [7FF824127798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FF824274870
       call      qword ptr [7FF824127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF823F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FF824274870
       call      qword ptr [7FF824127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF823F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8248BF648]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8248B4678]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L37:
       mov       rcx,r14
       call      qword ptr [7FF8243B72D0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L38:
       mov       rcx,r14
       call      qword ptr [7FF8243BCAF8]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L39:
       mov       r11,7FF823E51070
       mov       rdx,22B18A419B8
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M00_L04
M00_L40:
       mov       rcx,rax
       call      qword ptr [7FF8248B77B0]
       int       3
M00_L41:
       mov       rcx,rsi
       call      qword ptr [7FF8244A67D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L06
M00_L42:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L43:
       mov       ecx,9
       call      qword ptr [7FF8248B42D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rsi,rax
       jmp       near ptr M00_L09
M00_L44:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1EA83C027D8
       mov       rsi,[rcx]
       jmp       near ptr M00_L19
M00_L45:
       mov       rax,22B18A462A0
       jmp       near ptr M00_L11
M00_L46:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1EA83C027D8
       mov       r15,[rcx]
       jmp       near ptr M00_L13
       sub       rsp,48
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-148]
       call      qword ptr [7FF82460FA80]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       nop
       add       rsp,48
       ret
; Total bytes of code 2271
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
       call      qword ptr [7FF8243BD098]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M01_L00:
       mov       rcx,7FF824957BBC
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
       mov       rcx,7FF824957BB8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FF8248B7D98]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF8248BD2D8]
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
       mov       rbx,rcx
       mov       rdi,r8
       mov       esi,r9d
       mov       rbp,[rdx+8]
       mov       rcx,[rdx+10]
       mov       eax,esi
       imul      rax,[rdx+28]
       shr       rax,20
       inc       rax
       mov       edx,[rcx+8]
       mov       r8d,edx
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       near ptr M02_L06
       mov       edx,eax
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M02_L03
M02_L00:
       cmp       esi,[r14+20]
       jne       near ptr M02_L05
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       je        short M02_L02
M02_L01:
       mov       rcx,rbp
       mov       rdx,7FF82491E9C8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rbp
       mov       rdx,[r14+8]
       mov       r11,r15
       mov       r8,rdi
       call      qword ptr [r15]
       test      eax,eax
       je        short M02_L04
       mov       rcx,7FF82491EAD0
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
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FF824907978
       call      qword ptr [7FF823F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
       jmp       short M02_L01
M02_L03:
       mov       rcx,7FF82491EADC
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
M02_L04:
       mov       rcx,7FF82491EAD4
       call      CORINFO_HELP_COUNTPROFILE32
M02_L05:
       mov       rcx,7FF82491EAD8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r14,[r14+18]
       test      r14,r14
       jne       near ptr M02_L00
       jmp       short M02_L03
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 319
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
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
       mov       [rbp-50],rax
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       movzx     r9d,r9b
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       mov       [rbp-50],rcx
       mov       ebx,[rbp+2C]
       test      r9d,r9d
       je        near ptr M03_L32
       mov       rcx,7FF82495DCB0
       call      CORINFO_HELP_COUNTPROFILE32
M03_L00:
       mov       [rbp-3C],ebx
M03_L01:
       mov       rax,[rbp+18]
       mov       rcx,[rax+18]
       mov       [rbp-58],rcx
       mov       r8,[rbp+10]
       cmp       [r8],r8d
       mov       rax,[rbp+18]
       mov       r10,[rax+10]
       mov       rax,[rbp+18]
       mov       r9d,[rbp-3C]
       imul      r9,[rax+28]
       shr       r9,20
       inc       r9
       mov       r11d,[r10+8]
       mov       ebx,r11d
       imul      r9,rbx
       shr       r9,20
       mov       eax,r9d
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rbp-40],edx
       cmp       r9d,r11d
       jae       near ptr M03_L43
       mov       ecx,r9d
       lea       rbx,[r10+rcx*8+10]
       xor       esi,esi
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       byte ptr [rbp+40],0
       je        short M03_L03
       mov       rcx,7FF82495DCB4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-58]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M03_L25
       mov       rcx,[rbp-58]
       mov       eax,[rbp-40]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        near ptr M03_L08
       mov       rcx,r14
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M03_L02
       mov       rcx,r14
       call      qword ptr [7FF8248B4828]
M03_L02:
       mov       dword ptr [rbp-44],1
M03_L03:
       mov       rcx,[rbp+18]
       mov       r8,[rbp+10]
       cmp       rcx,[r8+8]
       jne       near ptr M03_L09
       xor       r14d,r14d
       mov       r15,[rbx]
       test      r15,r15
       jne       near ptr M03_L15
M03_L04:
       mov       rcx,[r8]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        near ptr M03_L07
M03_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13,[rbx]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-3C]
       mov       [r15+20],ecx
       mov       rcx,rbx
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       mov       eax,[rcx+8]
       cmp       [rbp-40],eax
       jae       near ptr M03_L25
       mov       eax,[rbp-40]
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M03_L26
       mov       [rcx],eax
       mov       r8,[rbp+10]
       cmp       eax,[r8+10]
       jg        near ptr M03_L27
M03_L06:
       cmp       r14d,64
       ja        near ptr M03_L28
       mov       rcx,7FF82495DCCC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L29
M03_L07:
       mov       rdx,7FF824949340
       call      qword ptr [7FF823F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M03_L05
M03_L08:
       xor       ecx,ecx
       call      qword ptr [7FF8247AFAB0]
       int       3
M03_L09:
       mov       rcx,[r8+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp-50]
       mov       rax,[rbp+18]
       cmp       rcx,[rax+8]
       je        short M03_L14
       mov       rcx,7FF82495DCB8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       mov       [rbp-50],rcx
       mov       r8,[rbp+10]
       cmp       byte ptr [r8+19],0
       jne       short M03_L12
       mov       r8,[rbp+10]
       mov       rcx,[r8]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rdx,7FF824907870
       call      qword ptr [7FF823F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L11:
       mov       rcx,[rbp-50]
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       jmp       short M03_L13
M03_L12:
       mov       rcx,[rbp+20]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
M03_L13:
       mov       [rbp-3C],eax
M03_L14:
       mov       rcx,7FF82495DCBC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L39
M03_L15:
       mov       ecx,[rbp-3C]
       cmp       ecx,[r15+20]
       jne       short M03_L20
       mov       rcx,[r8]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M03_L16
       mov       rcx,rax
       jmp       short M03_L17
M03_L16:
       mov       rdx,7FF824908150
       call      qword ptr [7FF823F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L17:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M03_L18
       jmp       short M03_L19
M03_L18:
       mov       rdx,7FF824907978
       call      qword ptr [7FF823F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L19:
       mov       rdx,[r15+8]
       mov       rcx,[rbp-50]
       mov       r8,[rbp+20]
       call      qword ptr [r11]
       test      eax,eax
       jne       short M03_L21
       mov       rcx,7FF82495DCC0
       call      CORINFO_HELP_COUNTPROFILE32
M03_L20:
       mov       rcx,7FF82495DCD0
       call      CORINFO_HELP_COUNTPROFILE32
       inc       r14d
       mov       rcx,7FF82495DCD4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r15,[r15+18]
       test      r15,r15
       mov       r8,[rbp+10]
       jne       near ptr M03_L15
       jmp       near ptr M03_L04
M03_L21:
       cmp       byte ptr [rbp+38],0
       je        short M03_L22
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L23
M03_L22:
       mov       rcx,7FF82495DCC4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[r15+10]
       mov       rcx,[rbp+48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L23:
       xor       ecx,ecx
       mov       [rbp-48],ecx
       jmp       near ptr M03_L40
M03_L24:
       mov       rcx,7FF82495DCC8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L29
M03_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L27:
       mov       rcx,7FF82495DCD8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       esi,1
       jmp       near ptr M03_L06
M03_L28:
       mov       rdx,[rbp-50]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FF823F06850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L24
       mov       rcx,7FF82495DCDC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edi,1
M03_L29:
       cmp       dword ptr [rbp-44],0
       je        short M03_L30
       mov       rcx,7FF82495DCE0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-58]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M03_L43
       mov       rcx,[rbp-58]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M03_L37
       mov       rcx,rbx
       call      00007FF883B9DA10
       test      eax,eax
       jne       near ptr M03_L38
M03_L30:
       mov       rcx,7FF82495DCE4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,esi
       or        ecx,edi
       jne       near ptr M03_L41
M03_L31:
       mov       rcx,7FF82495DCEC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L32:
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+19],0
       jne       short M03_L35
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+78]
       test      r11,r11
       je        short M03_L33
       jmp       short M03_L34
M03_L33:
       mov       rcx,rdx
       mov       rdx,7FF824907870
       call      qword ptr [7FF823F0C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L34:
       mov       rcx,[rbp-50]
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M03_L36
M03_L35:
       mov       rcx,[rbp+20]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       ebx,eax
M03_L36:
       jmp       near ptr M03_L00
M03_L37:
       xor       ecx,ecx
       call      qword ptr [7FF8247AFAB0]
       int       3
M03_L38:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF8248B4420]
       jmp       near ptr M03_L30
M03_L39:
       call      M03_L44
       jmp       near ptr M03_L01
M03_L40:
       call      M03_L44
       jmp       short M03_L42
M03_L41:
       mov       rcx,7FF82495DCE8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FF8246C4288]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
       jmp       near ptr M03_L31
M03_L42:
       mov       rcx,7FF82495DCF0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,[rbp-48]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L43:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L44:
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M03_L45
       mov       rcx,7FF82495DCE0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-58]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       short M03_L47
       mov       rcx,[rbp-58]
       mov       eax,[rbp-40]
       mov       rsi,[rcx+rax*8+10]
       test      rsi,rsi
       je        short M03_L46
       mov       rcx,rsi
       call      00007FF883B9DA10
       test      eax,eax
       je        short M03_L45
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF8248B4420]
M03_L45:
       mov       rcx,7FF82495DCE4
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
M03_L46:
       xor       ecx,ecx
       call      qword ptr [7FF8247AFAB0]
       int       3
M03_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1512
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
       mov       rcx,22B18A4FFA8
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],1
       jne       short M04_L03
       cmp       word ptr [r8+0C],0A
       je        short M04_L04
M04_L03:
       mov       rcx,22B18A41518
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],2
       jne       short M04_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M04_L08
M04_L04:
       mov       rcx,22B18A41518
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
       mov       rdx,7FF8243CF2D8
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF8248BE3D0]
       int       3
M04_L09:
       or        esi,4
       jmp       short M04_L06
M04_L10:
       cmp       edx,9
       je        short M04_L11
       mov       ecx,38A0
       mov       rdx,7FF8243CF2D8
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF8248BE388]
       int       3
M04_L11:
       or        esi,8
       jmp       near ptr M04_L00
M04_L12:
       mov       ecx,38A0
       mov       rdx,7FF8243CF2D8
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FF8248BE3A0]
       int       3
M04_L13:
       mov       ecx,38A0
       mov       rdx,7FF8243CF2D8
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF8248BE3B8]
       int       3
M04_L14:
       mov       r8,22B18A41518
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
       mov       rcx,1EA83C00C90
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
       call      qword ptr [7FF8248B42D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L03:
       mov       rcx,r14
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF8248BC870]
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
       call      qword ptr [7FF8246CF240]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FF8244AD7B8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF823F06820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF8248BC870]
       jmp       near ptr M05_L01
M05_L12:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M05_L15
M05_L13:
       test      ebx,ebx
       jne       short M05_L14
       mov       rax,22B18A462A0
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
       mov       rdx,22B18A46F28
       call      qword ptr [7FF82412D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FF824607B88]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M05_L17:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF8248BC870]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF8248BC888]
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
       mov       rcx,1EA83C01E08
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       ebp,edx
       mov       rcx,1EA83C00C90
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
       call      qword ptr [7FF8248B42D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M06_L00
M06_L05:
       mov       rcx,r13
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       ebp,[r13+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF8248BC870]
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
       call      qword ptr [7FF8246CF240]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FF8244AD7B8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FF823F06820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF8248BC870]
       jmp       near ptr M06_L01
M06_L14:
       mov       ecx,10
       shlx      ebp,ecx,r15d
       jmp       short M06_L17
M06_L15:
       test      ebp,ebp
       jne       short M06_L16
       mov       rdx,22B18A462A0
       jmp       near ptr M06_L02
M06_L16:
       mov       ecx,ebp
       mov       rdx,22B18A46F28
       call      qword ptr [7FF82412D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FF824607B88]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M06_L19:
       cmp       byte ptr [r14+9D],0
       je        near ptr M06_L01
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF8248BC870]
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF8248BC888]
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
       call      qword ptr [7FF82407DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FF8248BC768]
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
       mov       rcx,1EA83C01E08
       mov       rcx,[rcx]
       call      qword ptr [7FF82462B8C8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FF82407DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rcx,1EA83C01E08
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
       jmp       qword ptr [7FF82462B8D0]; Precode of System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       call      qword ptr [7FF823F05C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      qword ptr [7FF823F0C9A8]; System.Object.GetType()
       mov       r9,22B18A419B8
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
       call      qword ptr [7FF824607BB8]
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
       call      qword ptr [7FF82460E1A8]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
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
       jne       near ptr M08_L13
M08_L07:
       lea       rcx,[rsp+40]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+158]
       mov       r9,[rbx+0B8]
       mov       rdx,rdi
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF82460F120]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M08_L08:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF82460FA50]; System.Text.Json.Utf8JsonWriter.Flush()
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
       call      qword ptr [7FF8243BCAE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       mov       rcx,[rbx+0C0]
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        near ptr M08_L07
       mov       rcx,[rsp+60]
       mov       rdx,rbp
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       near ptr M08_L07
; Total bytes of code 710
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
       call      qword ptr [7FF824077198]
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
       mov       r8,1EA83C013D0
       mov       rbx,[r8]
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       r8d,1
       test      edi,edi
       cmove     rsi,r8
       mov       [rbp-38],rsi
       test      rsi,rsi
       je        near ptr M10_L03
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FF824074C30]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       mov       r9d,eax
       sub       r9d,esi
       mov       r14d,r9d
       add       r14d,[rbp-48]
       cmp       r9d,edi
       jne       near ptr M10_L04
M10_L00:
       test      r14d,r14d
       je        near ptr M10_L05
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FF883B94CB0
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
       call      qword ptr [7FF824074C60]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
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
M10_L02:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       near ptr M10_L09
M10_L03:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FF82452DD10]
       int       3
M10_L04:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FF82452DCE0]
       add       r14d,eax
       jns       near ptr M10_L00
       call      qword ptr [7FF82452DD28]
       int       3
M10_L05:
       mov       r15,22B18A40008
       jmp       short M10_L02
M10_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FF82452DD10]
       int       3
M10_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FF824525BC0]
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
       call      qword ptr [7FF82452DF80]
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
       call      qword ptr [7FF82452E4C0]
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
       call      qword ptr [7FF95510E028]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
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
       call      qword ptr [7FF95510E028]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
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
       mov       rcx,7FF82496BEA8
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
       mov       rdx,7FF82496BDA0
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
       mov       rcx,7FF82496BEAC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF82496BEA8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rbx,[rbx+20]
       mov       rcx,rbx
       mov       rdx,7FF82496BEB0
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
       mov       rcx,7FF82496BFB8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L00
M12_L03:
       mov       rcx,7FF82496BFBC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L00
M12_L04:
       mov       rcx,7FF82496BFC0
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
       mov       rax,1EA83C013F8
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
       call      qword ptr [7FF8248BDEC0]
       mov       rcx,[rbp+30]
M13_L04:
       test      byte ptr [rbx+7C],1
       jne       short M13_L05
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FF82460F528]; System.Text.Json.Utf8JsonWriter.WriteStringMinimized(System.ReadOnlySpan`1<Char>)
       jmp       short M13_L07
M13_L05:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FF8248BDED8]
       jmp       short M13_L07
M13_L06:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FF82473F408]; System.Text.Json.Utf8JsonWriter.WriteStringEscapeValue(System.ReadOnlySpan`1<Char>, Int32)
M13_L07:
       or        dword ptr [rbx+28],80000000
       mov       byte ptr [rbx+3A],7
       jmp       short M13_L09
M13_L08:
       mov       rcx,rbx
       call      qword ptr [7FF82460F738]
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
       call      qword ptr [7FF82460F150]; System.Text.Json.WriteStack.Push()
       mov       r8,[rdi]
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SmallObjectWithParameterizedConstructorConverter<DotNetTips.Spargine.Tester.Models.RefTypes.Address, System.String, System.Object, System.Object, System.Object>
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
       call      qword ptr [7FF82460F588]; System.Text.Json.WriteStack.Pop(Boolean)
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
       call      qword ptr [7FF8244CDD00]; System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[[System.__Canon, System.Private.CoreLib]].OnTryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       mov       r15d,eax
       jmp       short M13_L18
M13_L21:
       mov       ecx,[r14+88]
       call      qword ptr [7FF82460F708]
       int       3
M13_L22:
       mov       rcx,rbx
       call      qword ptr [7FF82460F738]
       jmp       near ptr M13_L10
M13_L23:
       cmp       byte ptr [rsi+1A],0
       je        near ptr M13_L01
       mov       rdi,[rdi]
       add       rcx,90
       call      qword ptr [7FF824525C98]; System.Nullable`1[[System.Text.Json.Serialization.JsonNumberHandling, System.Text.Json]].get_Value()
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
       call      qword ptr [7FF8248BDE90]
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
       call      qword ptr [7FF82460F6A8]
       int       3
M13_L27:
       mov       rcx,r13
       call      qword ptr [7FF8244A67D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M13_L13
M13_L28:
       mov       [rsp+20],rcx
       mov       rdx,[rdi]
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FF8248BDE00]
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
       call      qword ptr [7FF8248BDE18]
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
       call      qword ptr [7FF8248BE490]
M13_L34:
       mov       rdx,rbx
       mov       rcx,offset MT_System.InvalidOperationException
       call      qword ptr [7FF823F06850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M13_L36
       mov       rdx,rbx
       mov       rcx,offset MT_System.Text.Json.JsonException
       call      qword ptr [7FF823F06850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M13_L35
       mov       rcx,rsi
       call      qword ptr [7FF8248BE4A8]
       test      rax,rax
       jne       near ptr M13_L38
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FF8248BE4C0]
       jmp       near ptr M13_L38
M13_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.NotSupportedException
       call      qword ptr [7FF823F06850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M13_L38
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,22B18A4EF70
       cmp       [rcx],ecx
       call      qword ptr [7FF8248BE4F0]
       test      eax,eax
       jne       short M13_L38
       jmp       short M13_L37
M13_L36:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       rdx,22B18A4EF20
       call      qword ptr [7FF824124F00]; System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M13_L38
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FF8248BE4D8]
       jmp       short M13_L38
M13_L37:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FF8248BE508]
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
       call      qword ptr [7FF8248BE928]
       int       3
M14_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M14_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF82496B1B8]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF8248BE958]
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
       call      qword ptr [7FF8248BE970]
M14_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M14_L02
M14_L06:
       mov       r11,7FF823E510F8
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
       mov       rcx,7FF82491E528
       call      CORINFO_HELP_COUNTPROFILE32
M15_L00:
       test      rbp,rbp
       jne       near ptr M15_L08
       cmp       byte ptr [rsp+69],0
       je        near ptr M15_L07
       mov       rcx,7FF82491E51C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FF8248B7258]
       int       3
M15_L01:
       mov       rcx,7FF82491E518
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF8243BD098]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
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
       call      qword ptr [7FF8243BD020]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
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
       mov       rcx,7FF82491E514
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M15_L00
M15_L06:
       mov       rcx,7FF82491E510
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       byte ptr [rbp+119],2
       je        near ptr M15_L00
       jmp       near ptr M15_L14
M15_L07:
       mov       rcx,7FF82491E524
       call      CORINFO_HELP_COUNTPROFILE32
M15_L08:
       mov       rcx,7FF82491E520
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
       call      qword ptr [7FF8243BCB28]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rbp,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M15_L10
       call      qword ptr [7FF8247AFFD8]
       int       3
M15_L10:
       mov       rdx,rbp
       xor       r8d,r8d
       call      00007FF883B19D60
       test      rax,rax
       cmove     rax,rbp
       mov       rbp,rax
       jmp       near ptr M15_L03
M15_L11:
       cmp       byte ptr [rax+20],0
       je        short M15_L13
       jmp       near ptr M15_L04
M15_L12:
       call      qword ptr [7FF8248B77B0]
       int       3
M15_L13:
       mov       rcx,rbp
       mov       rdx,rsi
       mov       r8,rax
       call      qword ptr [7FF8248B77C8]
       mov       rbp,rax
       jmp       near ptr M15_L05
M15_L14:
       mov       rcx,rbp
       call      qword ptr [7FF8244A67D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
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
       jmp       qword ptr [7FF8248B46C0]
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
       mov       rcx,22B18A462A0
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M17_L36
       cmp       dword ptr [rbx+8],0
       je        near ptr M17_L36
       mov       rcx,1EA83C01E08
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
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M17_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FF8248B4828]
M17_L02:
       mov       dword ptr [rbp-40],1
       mov       rcx,[r15+10]
       lea       r8,[rbp-48]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF82412CF30]; System.Runtime.CompilerServices.ConditionalWeakTable`2+Container[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindEntry(System.__Canon, System.Object ByRef)
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
       call      00007FF883AFE4B0
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
       call      00007FF883B63160
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
       call      qword ptr [7FF823F0E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M17_L04
M17_L07:
       xor       ecx,ecx
       call      qword ptr [7FF8247AFAB0]
       int       3
M17_L08:
       mov       ecx,36
       call      qword ptr [7FF8248BCB58]
       int       3
M17_L09:
       mov       rcx,r12
       call      qword ptr [7FF8248BF738]
       mov       r12,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M17_L03
M17_L10:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8248BF750]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF824325FC8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M17_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M17_L12:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF8248BF768]
       jmp       near ptr M17_L05
M17_L13:
       mov       rcx,[rbp-80]
       call      00007FF883B9DA10
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
       call      qword ptr [7FF8248BE370]
M17_L17:
       mov       r13,[rax+8]
       call      qword ptr [7FF8246CF240]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M17_L19
       mov       rcx,[rbp-90]
       call      qword ptr [7FF8248B4828]
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
       call      00007FF883B9DA10
       test      eax,eax
       jne       near ptr M17_L42
M17_L22:
       cmp       dword ptr [rbp-60],0
       je        near ptr M17_L43
       mov       r13d,1
M17_L23:
       mov       rcx,1EA83C00C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       je        near ptr M17_L36
       mov       rcx,rbx
       call      00007FF883AFE4B0
       test      eax,eax
       je        near ptr M17_L31
       mov       [rbp-68],eax
M17_L24:
       mov       edx,[rbx+8]
       mov       [rbp-3C],edx
       mov       rcx,rsi
       call      00007FF883AFE4B0
       test      eax,eax
       je        near ptr M17_L32
M17_L25:
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-68]
       mov       r9d,[rbp-3C]
       mov       edx,3
       call      qword ptr [7FF8248BC918]
       test      r13d,r15d
       jne       near ptr M17_L36
       mov       rcx,rbx
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      00007FF883AFE4B0
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
       mov       r15,1EA83C01F58
       mov       r12,[r15]
       test      r12,r12
       jne       short M17_L28
       mov       rcx,offset MT_System.Func<System.Object, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,1EA83C01F50
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
       call      00007FF883B2B5A0
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
       call      qword ptr [7FF823F0E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       [rbp-68],eax
       jmp       near ptr M17_L24
M17_L32:
       mov       rcx,rsi
       call      qword ptr [7FF823F0E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M17_L25
M17_L33:
       mov       rcx,rsi
       call      qword ptr [7FF823F0E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       call      qword ptr [7FF8248BC930]
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
       call      qword ptr [7FF8248B42D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M17_L00
M17_L38:
       mov       ecx,0A
       call      qword ptr [7FF8248B42D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M17_L01
M17_L39:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FF8248B4420]
       jmp       near ptr M17_L14
M17_L40:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8248BF780]
       jmp       near ptr M17_L29
M17_L41:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8248BC900]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF824326070]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M17_L42:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FF8248B4420]
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
       call      qword ptr [7FF8247AFAB0]
       int       3
M17_L47:
       mov       rcx,[rbp-80]
       call      00007FF883B9DA10
       test      eax,eax
       je        short M17_L48
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FF8248B4420]
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
       call      00007FF883B94CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF823F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF823F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,22B18A40008
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
       call      qword ptr [7FF8248B4F78]
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
       call      qword ptr [7FF9551074E0]
       cmp       byte ptr [rax],0
       je        near ptr M20_L03
       call      qword ptr [7FF95510DBE0]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M20_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
M20_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M20_L01:
       call      qword ptr [7FF955109688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M20_L00
       call      qword ptr [7FF9551074D8]
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
       call      qword ptr [7FF95510F2E0]
       lea       rcx,[rsp+20]
       call      qword ptr [7FF95510DC10]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FF95510D4D8]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
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
       call      qword ptr [7FF9551096A0]
       test      rax,rax
       je        near ptr M20_L00
M20_L04:
       call      qword ptr [7FF95510BE58]
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
       call      qword ptr [7FF95510D580]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF95510B548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M22_L01
       mov       rcx,rsi
       call      qword ptr [7FF8248B4828]
M22_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M22_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M22_L03
       mov       rcx,7FF824926A80
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF8244A67F0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M22_L04
M22_L02:
       xor       ecx,ecx
       call      qword ptr [7FF8247AFAB0]
       int       3
M22_L03:
       mov       rcx,7FF824926A7C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF8248B77B0]
       int       3
M22_L04:
       mov       rcx,7FF824926A84
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FF883B9DA10
       test      eax,eax
       jne       near ptr M22_L10
M22_L05:
       mov       rcx,7FF824926A88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF824926A8C
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M22_L06:
       call      qword ptr [7FF8248B7D80]
       int       3
M22_L07:
       mov       rcx,7FF824926A78
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF8248B77B0]
       int       3
M22_L08:
       mov       rcx,rbx
       call      qword ptr [7FF8243BCB28]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M22_L09
       call      qword ptr [7FF8247AFFD8]
       int       3
M22_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF883B19D60
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M22_L00
M22_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF8248B4420]
       jmp       near ptr M22_L05
       sub       rsp,28
       call      qword ptr [7FF8248B7D98]
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
       mov       rcx,7FF824926A84
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M22_L11
       xor       ecx,ecx
       call      qword ptr [7FF8247AFAB0]
       int       3
M22_L11:
       mov       rcx,[rbp-20]
       call      00007FF883B9DA10
       test      eax,eax
       je        short M22_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF8248B4420]
M22_L12:
       mov       rcx,7FF824926A88
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
       call      qword ptr [7FF883980CF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FF823F05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,178
       lea       rbp,[rsp+1B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-150],xmm4
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
       je        near ptr M00_L41
       mov       [rbp-40],rcx
       mov       rcx,2852EC01DD8
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9F],0
       je        near ptr M00_L42
M00_L01:
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        near ptr M00_L43
M00_L02:
       mov       r14,rdx
       test      r14,r14
       je        short M00_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
       cmp       [r14],rcx
       jne       near ptr M00_L44
M00_L03:
       mov       rsi,[r14+0B8]
       lea       rdx,[rbp-50]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF82453FD98]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       r15d,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M00_L45
       mov       rcx,[rcx+240]
       mov       rsi,[rcx+48]
       test      rsi,rsi
       je        near ptr M00_L45
M00_L04:
       mov       rax,[rsi+10]
       test      rax,rax
       jne       short M00_L05
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,2C5C3CD62A0
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
M00_L05:
       mov       ecx,[rax+18]
       lea       edx,[rcx+1]
       mov       [rax+18],edx
       test      ecx,ecx
       je        near ptr M00_L11
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      r15d,r15d
       je        near ptr M00_L47
       mov       rcx,2852EC01DE0
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FF8245CC110]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
M00_L06:
       mov       [rbp-68],rax
       lea       rcx,[rsi+18]
       mov       rdx,[rbp-68]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       byte ptr [rsi+28],1
       mov       [rbp-158],rsi
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12d,[rbp-44]
       mov       edx,r12d
       lea       rdi,[r13+70]
       lea       rsi,[rbp-50]
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
       je        short M00_L10
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L07:
       mov       [r13+2C],eax
       test      dl,4
       jne       near ptr M00_L48
       mov       r15,2C5C3CD1518
M00_L08:
       mov       ecx,[r15+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       short M00_L09
       mov       dword ptr [r13+78],3E8
M00_L09:
       mov       [rbp-160],r13
       jmp       near ptr M00_L17
M00_L10:
       mov       eax,2
       jmp       short M00_L07
M00_L11:
       mov       rcx,[rax+8]
       mov       [rbp-158],rcx
       mov       r13,[rax+10]
       mov       rcx,[rbp-158]
       cmp       [rcx],cl
       mov       rcx,[rbp-158]
       add       rcx,18
       mov       rdx,[rcx]
       mov       edx,[rdx+8]
       sub       edx,[rcx+0C]
       cmp       edx,r15d
       jl        near ptr M00_L15
M00_L12:
       lea       rcx,[r13+8]
       mov       rdx,[rbp-158]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12d,[rbp-44]
       mov       edx,r12d
       lea       rdi,[r13+70]
       lea       rsi,[rbp-50]
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
       je        short M00_L16
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L13:
       mov       [r13+2C],eax
       test      dl,4
       jne       near ptr M00_L46
       mov       rsi,2C5C3CD1518
M00_L14:
       mov       ecx,[rsi+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       near ptr M00_L09
       mov       dword ptr [r13+78],3E8
       jmp       near ptr M00_L09
M00_L15:
       mov       edx,r15d
       call      qword ptr [7FF82453FE28]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L12
M00_L16:
       mov       eax,2
       jmp       short M00_L13
M00_L17:
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
       call      qword ptr [7FF823F1C9A8]; System.Object.GetType()
       mov       rdi,rax
       mov       rcx,2C5C3CD19B8
       cmp       rdi,rcx
       je        near ptr M00_L30
       mov       r14,[rsi+10]
       test      r14,r14
       je        short M00_L18
       mov       rcx,[r14+0C0]
       cmp       rcx,rdi
       je        near ptr M00_L25
M00_L18:
       xor       r14d,r14d
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L24
       mov       r14,[rsi+8]
       test      r14,r14
       je        near ptr M00_L33
M00_L19:
       mov       r15,[r14+8]
       mov       rcx,2852EC01960
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M00_L34
M00_L20:
       cmp       [r15],r15b
       mov       rax,[r15+8]
       mov       [rbp-168],rax
       mov       rcx,[rax+8]
       cmp       byte ptr [r15+19],0
       je        near ptr M00_L35
       mov       rcx,rdi
       mov       rdx,[7FF823E5A1C0]
       call      qword ptr [rdx+18]
M00_L21:
       lea       rdx,[rbp-110]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-168]
       mov       r8,rdi
       mov       [rbp-114],eax
       mov       r9d,eax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      qword ptr [7FF824336658]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       jne       short M00_L22
       mov       rdx,rdi
       mov       r8,r14
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-110]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,[rbp-114]
       shl       r9,20
       or        r9,1
       mov       rdx,[rbp-168]
       mov       r8,rdi
       mov       rcx,r15
       call      qword ptr [7FF82433C510]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
M00_L22:
       mov       r8,[rbp-110]
       xor       ecx,ecx
       mov       [rbp-110],rcx
       cmp       byte ptr [r8+20],0
       je        near ptr M00_L37
       mov       rcx,[r8+10]
       test      rcx,rcx
       jne       near ptr M00_L36
       mov       r14,[r8+8]
M00_L23:
       test      r14,r14
       je        short M00_L24
       cmp       byte ptr [r14+119],2
       jne       near ptr M00_L38
M00_L24:
       test      r14,r14
       je        near ptr M00_L29
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L25:
       cmp       byte ptr [r14+11A],0
       je        near ptr M00_L28
M00_L26:
       mov       rcx,[r14+0F8]
       test      rcx,rcx
       cmovne    r14,rcx
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [r14],rcx
       jne       near ptr M00_L39
       mov       rcx,r14
       mov       rdx,r13
       mov       r8,[rbp-40]
       call      qword ptr [7FF824437858]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].SerializeAsObject(System.Text.Json.Utf8JsonWriter, System.Object)
M00_L27:
       mov       rcx,[rbp-158]
       cmp       [rcx],cl
       mov       rcx,[rbp-158]
       add       rcx,18
       lea       rdx,[rbp-128]
       call      qword ptr [7FF8248A46C0]; System.Net.ArrayBuffer.get_ActiveSpan()
       mov       rdx,[rbp-128]
       mov       r8d,[rbp-120]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-138],xmm0
       lea       rcx,[rbp-138]
       call      qword ptr [7FF8248A46D8]; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte ByRef, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-138]
       vmovdqu   xmmword ptr [rbp-150],xmm0
       lea       rcx,[rbp-150]
       call      qword ptr [7FF824535DA0]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rsi,rax
       jmp       near ptr M00_L40
M00_L28:
       mov       rcx,r14
       call      qword ptr [7FF8246264F0]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[r14+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+11A],1
       jmp       near ptr M00_L26
M00_L29:
       mov       rdx,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FF82479ECA0]
       int       3
M00_L30:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-108],ymm0
       vmovdqu   ymmword ptr [rbp-0E8],ymm0
       vmovdqu   ymmword ptr [rbp-0C8],ymm0
       vmovdqu   ymmword ptr [rbp-0A8],ymm0
       vmovdqu   ymmword ptr [rbp-88],ymm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-108]
       mov       rdx,r14
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF824627450]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-108]
       mov       [rsp+20],rcx
       mov       rcx,[r14+158]
       mov       r9,[r14+0B8]
       lea       r8,[rbp-40]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF824627468]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L31:
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF824627EB8]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M00_L27
M00_L32:
       mov       rax,[r14+148]
       mov       rdx,r13
       mov       r8,[rbp-40]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M00_L31
M00_L33:
       mov       rcx,rsi
       call      qword ptr [7FF8243CCAF8]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       r14,rax
       jmp       near ptr M00_L19
M00_L34:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF823E5D050
       mov       [r12+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [r12+20],rcx
       mov       rcx,2852EC01960
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L20
M00_L35:
       mov       rdx,rdi
       mov       r11,7FF823E60C80
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L36:
       call      qword ptr [7FF82479EC88]
       int       3
M00_L37:
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF82479EF40]
       mov       r14,rax
       jmp       near ptr M00_L23
M00_L38:
       mov       rcx,r14
       call      qword ptr [7FF8244B67D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L24
M00_L39:
       mov       rcx,r14
       mov       rdx,r13
       mov       r8,[rbp-40]
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L27
M00_L40:
       mov       rcx,r13
       mov       rdx,[rbp-158]
       call      qword ptr [7FF824627EE8]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       [rbp-140],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-140]
       mov       rdx,7FF8247889B8
       cmp       [rcx],ecx
       call      qword ptr [7FF82472F600]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,178
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L41:
       call      qword ptr [7FF8245368F8]
       mov       ecx,1C4D
       mov       rdx,7FF824284870
       call      qword ptr [7FF824137798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FF824284870
       call      qword ptr [7FF824137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF823F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FF824284870
       call      qword ptr [7FF824137798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF823F17840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8248A4690]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8248A46A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L42:
       mov       rcx,rsi
       call      qword ptr [7FF8243C72D0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L43:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       mov       r9d,101
       mov       rcx,rsi
       mov       rdx,2C5C3CD19B8
       mov       r8d,1
       call      qword ptr [7FF8243CCAE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rdi,rax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       jmp       near ptr M00_L02
M00_L44:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L45:
       mov       ecx,9
       call      qword ptr [7FF82479ECB8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rsi,rax
       jmp       near ptr M00_L04
M00_L46:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,28544C006C0
       mov       rsi,[rcx]
       jmp       near ptr M00_L14
M00_L47:
       mov       rax,2C5C3CD62A0
       jmp       near ptr M00_L06
M00_L48:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,28544C006C0
       mov       r15,[rcx]
       jmp       near ptr M00_L08
       sub       rsp,48
       mov       rcx,[rbp-160]
       mov       rdx,[rbp-158]
       call      qword ptr [7FF824627EE8]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       nop
       add       rsp,48
       ret
; Total bytes of code 2257
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
       jne       near ptr M01_L10
       and       esi,0FFFFFFF7
M01_L00:
       mov       edx,[rcx+84]
       cmp       edx,7F
       ja        near ptr M01_L12
       and       esi,0FFFFF80F
       test      edx,edx
       je        near ptr M01_L07
       xor       r8d,r8d
       cmp       edx,2
       cmovne    r8d,edx
M01_L01:
       shl       r8d,4
       or        esi,r8d
       mov       edi,[rcx+88]
       test      edi,edi
       jl        near ptr M01_L13
       mov       r8,[rcx+50]
       test      r8,r8
       jne       short M01_L02
       mov       r8,2C5C3CD1518
       mov       [rcx+50],r8
M01_L02:
       mov       rcx,2C5C3CDFFA8
       cmp       r8,rcx
       je        short M01_L04
       cmp       dword ptr [r8+8],1
       jne       short M01_L03
       cmp       word ptr [r8+0C],0A
       je        short M01_L04
M01_L03:
       mov       rcx,2C5C3CD1518
       cmp       r8,rcx
       je        short M01_L04
       cmp       dword ptr [r8+8],2
       jne       short M01_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M01_L08
M01_L04:
       mov       rcx,2C5C3CD1518
       cmp       r8,rcx
       je        short M01_L05
       cmp       dword ptr [r8+8],2
       jne       short M01_L09
       cmp       dword ptr [r8+0C],0A000D
       jne       short M01_L09
M01_L05:
       and       esi,0FFFFFFFB
M01_L06:
       or        esi,2
       mov       [rax],rbx
       mov       [rax+8],edi
       mov       [rax+0C],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       r8d,2
       jmp       near ptr M01_L01
M01_L08:
       mov       ecx,38A0
       mov       rdx,7FF8243DF2D8
       call      qword ptr [7FF824137798]
       mov       rcx,rax
       call      qword ptr [7FF82479EDA8]
       int       3
M01_L09:
       or        esi,4
       jmp       short M01_L06
M01_L10:
       cmp       edx,9
       je        short M01_L11
       mov       ecx,38A0
       mov       rdx,7FF8243DF2D8
       call      qword ptr [7FF824137798]
       mov       rcx,rax
       call      qword ptr [7FF82479ED60]
       int       3
M01_L11:
       or        esi,8
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,38A0
       mov       rdx,7FF8243DF2D8
       call      qword ptr [7FF824137798]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FF82479ED78]
       int       3
M01_L13:
       mov       ecx,38A0
       mov       rdx,7FF8243DF2D8
       call      qword ptr [7FF824137798]
       mov       rcx,rax
       call      qword ptr [7FF82479ED90]
       int       3
; Total bytes of code 409
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
       mov       rcx,2852EC00C90
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
       jle       short M02_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M02_L02
M02_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M02_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M02_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M02_L03
M02_L01:
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
M02_L02:
       mov       ecx,0A
       call      qword ptr [7FF82479ECB8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M02_L00
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF82479EF10]
       jmp       short M02_L01
M02_L04:
       mov       rax,[rsi+10]
       cmp       [rax+8],ebp
       jbe       near ptr M02_L13
       mov       ecx,ebp
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        near ptr M02_L12
       mov       r14,[rax+8]
       call      qword ptr [7FF8246B76A8]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       ebx,eax
       sub       ebx,ecx
       xor       r15d,r15d
       jmp       short M02_L08
M02_L05:
       cmp       ebx,[r14+8]
       jae       near ptr M02_L18
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FF8244BD890]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M02_L06
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M02_L06:
       mov       rcx,r13
       call      qword ptr [7FF823F16820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M02_L09
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M02_L07
       xor       ebx,ebx
M02_L07:
       inc       r15d
M02_L08:
       cmp       [r14+8],r15d
       jg        short M02_L05
       jmp       short M02_L10
M02_L09:
       mov       r14,r12
       jmp       short M02_L11
M02_L10:
       xor       r14d,r14d
M02_L11:
       test      r14,r14
       je        short M02_L12
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L01
       mov       rcx,r14
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF82479EF10]
       jmp       near ptr M02_L01
M02_L12:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M02_L15
M02_L13:
       test      ebx,ebx
       jne       short M02_L14
       mov       rax,2C5C3CD62A0
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
M02_L14:
       mov       ecx,ebx
       mov       rdx,2C5C3CD6F28
       call      qword ptr [7FF82413D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M02_L15:
       cmp       ebx,800
       jge       short M02_L16
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M02_L17
M02_L16:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FF82453FED0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M02_L17:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF82479EF10]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF82479EF28]
       jmp       near ptr M02_L01
M02_L18:
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
       jne       near ptr M03_L20
       mov       rcx,2852EC01DE0
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       ebp,edx
       mov       rcx,2852EC00C90
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
       jle       short M03_L04
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M03_L04
M03_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M03_L06
       mov       eax,[rcx+8]
       cmp       eax,r15d
       jbe       near ptr M03_L06
       mov       eax,r15d
       shl       rax,4
       mov       r13,[rcx+rax+10]
       test      r13,r13
       je        short M03_L06
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [r14+9D],0
       jne       short M03_L05
M03_L01:
       mov       rdx,r13
M03_L02:
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L03:
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
M03_L04:
       mov       ecx,0A
       call      qword ptr [7FF82479ECB8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M03_L00
M03_L05:
       mov       rcx,r13
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       ebp,[r13+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF82479EF10]
       jmp       short M03_L01
M03_L06:
       mov       rax,[rdi+10]
       cmp       [rax+8],r15d
       jbe       near ptr M03_L15
       mov       ecx,r15d
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        near ptr M03_L14
       mov       r13,[rax+8]
       call      qword ptr [7FF8246B76A8]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       ebp,eax
       sub       ebp,ecx
       xor       esi,esi
       jmp       short M03_L10
M03_L07:
       cmp       ebp,[r13+8]
       jae       near ptr M03_L26
       mov       ecx,ebp
       mov       r12,[r13+rcx*8+10]
       cmp       [r12],r12b
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rcx,r12
       call      qword ptr [7FF8244BD890]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r12+8]
       mov       eax,[r12+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M03_L08
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       mov       [rsp+30],rdx
       mov       r8d,eax
       xor       r10d,r10d
       mov       [rcx+r8*8+10],r10
       mov       [r12+10],eax
M03_L08:
       mov       rcx,r12
       call      qword ptr [7FF823F16820]; System.Threading.Monitor.Exit(System.Object)
       mov       r12,[rsp+30]
       test      r12,r12
       jne       short M03_L11
       inc       ebp
       cmp       [r13+8],ebp
       jne       short M03_L09
       xor       ebp,ebp
M03_L09:
       inc       esi
M03_L10:
       cmp       [r13+8],esi
       jg        short M03_L07
       jmp       short M03_L12
M03_L11:
       mov       r13,r12
       jmp       short M03_L13
M03_L12:
       xor       r13d,r13d
M03_L13:
       test      r13,r13
       je        short M03_L14
       cmp       byte ptr [r14+9D],0
       je        near ptr M03_L01
       mov       rcx,r13
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF82479EF10]
       jmp       near ptr M03_L01
M03_L14:
       mov       ecx,10
       shlx      ebp,ecx,r15d
       jmp       short M03_L17
M03_L15:
       test      ebp,ebp
       jne       short M03_L16
       mov       rdx,2C5C3CD62A0
       jmp       near ptr M03_L02
M03_L16:
       mov       ecx,ebp
       mov       rdx,2C5C3CD6F28
       call      qword ptr [7FF82413D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M03_L17:
       cmp       ebp,800
       jge       short M03_L18
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M03_L19
M03_L18:
       mov       ecx,ebp
       xor       edx,edx
       call      qword ptr [7FF82453FED0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M03_L19:
       cmp       byte ptr [r14+9D],0
       je        near ptr M03_L01
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FF82479EF10]
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF82479EF28]
       jmp       near ptr M03_L01
M03_L20:
       mov       ecx,[rbx+8]
       mov       rax,[rbx]
       mov       eax,[rax+8]
       sub       eax,[rbx+0C]
       add       ecx,eax
       cmp       edx,ecx
       jg        short M03_L21
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       r8,[rbx]
       mov       rcx,[rbx]
       xor       r9d,r9d
       call      qword ptr [7FF82408DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       eax,[rbx+8]
       sub       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+8],eax
       jmp       near ptr M03_L03
M03_L21:
       mov       ecx,[rbx+0C]
       sub       ecx,[rbx+8]
       add       ecx,edx
       cmp       ecx,7FFFFFC7
       jbe       short M03_L22
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF82479EDD8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L22:
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
       jne       short M03_L23
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M03_L24
M03_L23:
       mov       rcx,2852EC01DE0
       mov       rcx,[rcx]
       call      qword ptr [7FF8245CC110]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rsi,rax
M03_L24:
       mov       rdi,[rbx]
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       je        short M03_L25
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       rcx,rdi
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF82408DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
M03_L25:
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+10],0
       je        near ptr M03_L03
       cmp       dword ptr [rdi+8],0
       je        near ptr M03_L03
       mov       rcx,2852EC01DE0
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
       jmp       qword ptr [7FF8245CC118]; Precode of System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M03_L26:
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
       je        short M04_L01
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       call      qword ptr [7FF823F15C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M04_L00
; Total bytes of code 41
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rdi,r8
       mov       esi,r9d
       mov       rbp,[rdx+8]
       mov       rcx,[rdx+10]
       mov       eax,esi
       imul      rax,[rdx+28]
       shr       rax,20
       inc       rax
       mov       edx,[rcx+8]
       mov       r8d,edx
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       short M05_L03
       mov       eax,eax
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        short M05_L01
M05_L00:
       cmp       esi,[r14+20]
       jne       short M05_L02
       mov       rcx,rbx
       call      qword ptr [7FF881EB1AF0]
       mov       rdx,[r14+8]
       mov       rcx,rbp
       mov       r11,rax
       mov       r8,rdi
       call      qword ptr [rax]
       test      eax,eax
       je        short M05_L02
       mov       rdx,[r14+10]
       mov       rcx,[rsp+80]
       call      qword ptr [7FF881EB1268]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L01:
       xor       eax,eax
       mov       rbx,[rsp+80]
       mov       [rbx],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L02:
       mov       r14,[r14+18]
       test      r14,r14
       jne       short M05_L00
       jmp       short M05_L01
M05_L03:
       call      qword ptr [7FF881EB1258]
       int       3
; Total bytes of code 186
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
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
       mov       [rbp-58],rax
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       movzx     r9d,r9b
       mov       r11,[rbp+18]
       mov       r11,[r11+8]
       mov       [rbp-58],r11
       mov       eax,[rbp+2C]
       test      r9d,r9d
       je        near ptr M06_L20
M06_L00:
       mov       [rbp-3C],eax
M06_L01:
       mov       rax,[rbp+18]
       mov       rcx,[rax+18]
       mov       [rbp-60],rcx
       mov       r8,[rbp+10]
       cmp       [r8],r8d
       mov       rax,[rbp+18]
       mov       r10,[rax+10]
       mov       rax,[rbp+18]
       mov       r9d,[rbp-3C]
       imul      r9,[rax+28]
       shr       r9,20
       inc       r9
       mov       r11d,[r10+8]
       mov       ebx,r11d
       imul      r9,rbx
       shr       r9,20
       mov       eax,r9d
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rbp-40],edx
       cmp       r9d,r11d
       jae       near ptr M06_L27
       mov       ecx,r9d
       lea       rbx,[r10+rcx*8+10]
       xor       esi,esi
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-48],ecx
       cmp       byte ptr [rbp+40],0
       je        short M06_L02
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M06_L13
       mov       rcx,[rbp-60]
       mov       edx,[rbp-40]
       mov       rcx,[rcx+rdx*8+10]
       lea       rdx,[rbp-48]
       call      qword ptr [7FF881EB1D58]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
M06_L02:
       mov       rcx,[rbp+18]
       mov       r8,[rbp+10]
       cmp       rcx,[r8+8]
       jne       near ptr M06_L05
       xor       r14d,r14d
       mov       r15,[rbx]
       test      r15,r15
       jne       near ptr M06_L08
M06_L03:
       mov       rcx,[r8]
       call      qword ptr [7FF881EB1558]
       mov       rcx,rax
       call      qword ptr [7FF881EB1288]; CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       r13,[rbx]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+20]
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-3C]
       mov       [r15+20],ecx
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       mov       eax,[rcx+8]
       cmp       [rbp-40],eax
       jae       near ptr M06_L13
       mov       eax,[rbp-40]
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M06_L14
       mov       [rcx],eax
       mov       r8,[rbp+10]
       cmp       eax,[r8+10]
       jg        near ptr M06_L15
M06_L04:
       cmp       r14d,64
       jbe       near ptr M06_L17
       jmp       near ptr M06_L16
M06_L05:
       mov       rcx,[r8+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp-58]
       mov       r11,[rbp+18]
       cmp       rcx,[r11+8]
       je        near ptr M06_L23
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       mov       [rbp-58],rcx
       cmp       byte ptr [r8+19],0
       jne       short M06_L06
       mov       r8,[rbp+10]
       mov       rcx,[r8]
       call      qword ptr [7FF881EB18E8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
       jmp       short M06_L07
M06_L06:
       mov       rcx,[rbp+20]
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
M06_L07:
       mov       [rbp-3C],eax
       mov       r8,[rbp+10]
       jmp       near ptr M06_L23
M06_L08:
       mov       ecx,[rbp-3C]
       cmp       ecx,[r15+20]
       jne       short M06_L09
       mov       rcx,[r8]
       call      qword ptr [7FF881EB1500]
       mov       rcx,rax
       call      qword ptr [7FF881EB1AE8]
       mov       rdx,[r15+8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       r8,[rbp+20]
       call      qword ptr [rax]
       test      eax,eax
       mov       r8,[rbp+10]
       jne       short M06_L10
M06_L09:
       inc       r14d
       mov       r15,[r15+18]
       test      r15,r15
       jne       short M06_L08
       jmp       near ptr M06_L03
M06_L10:
       cmp       byte ptr [rbp+38],0
       je        short M06_L11
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF881EB1268]; CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M06_L12
M06_L11:
       mov       rdx,[r15+10]
       mov       rcx,[rbp+48]
       call      qword ptr [7FF881EB1268]; CORINFO_HELP_CHECKED_ASSIGN_REF
M06_L12:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       jmp       near ptr M06_L24
M06_L13:
       call      qword ptr [7FF881EB1258]
       int       3
M06_L14:
       call      qword ptr [7FF881EB1250]
       int       3
M06_L15:
       mov       esi,1
       jmp       near ptr M06_L04
M06_L16:
       mov       rcx,[rbp-58]
       call      qword ptr [7FF881EB1C10]
       mov       ecx,1
       test      rax,rax
       cmovne    edi,ecx
M06_L17:
       mov       r8,[rbp+10]
       cmp       byte ptr [rbp-48],0
       je        short M06_L18
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M06_L27
       mov       rcx,[rbp-60]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FF881EB1D60]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       r8,[rbp+10]
M06_L18:
       mov       ecx,esi
       or        ecx,edi
       jne       short M06_L25
M06_L19:
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF881EB1268]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L20:
       cmp       byte ptr [rcx+19],0
       jne       short M06_L21
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       call      qword ptr [7FF881EB18E8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
       jmp       short M06_L22
M06_L21:
       mov       rcx,[rbp+20]
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
M06_L22:
       mov       rcx,[rbp+10]
       jmp       near ptr M06_L00
M06_L23:
       call      M06_L28
       jmp       near ptr M06_L01
M06_L24:
       call      M06_L28
       jmp       short M06_L26
M06_L25:
       mov       rcx,r8
       mov       rdx,[rbp+18]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FF881EB2430]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
       jmp       near ptr M06_L19
M06_L26:
       mov       eax,[rbp-4C]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L27:
       call      qword ptr [7FF881EB1258]
       int       3
M06_L28:
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M06_L29
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       short M06_L30
       mov       rcx,[rbp-60]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FF881EB1D60]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L29:
       nop
       add       rsp,28
       ret
M06_L30:
       call      qword ptr [7FF881EB1258]
       int       3
; Total bytes of code 950
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].SerializeAsObject(System.Text.Json.Utf8JsonWriter, System.Object)
M07_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E0
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       vmovdqu   ymmword ptr [rsp+0B0],ymm4
       xor       eax,eax
       mov       [rsp+0D0],rax
       mov       [rsp+0D8],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+48]
       test      rax,rax
       je        near ptr M07_L08
M07_L01:
       mov       rcx,[rax+18]
       mov       rcx,[rcx]
       mov       rax,rsi
       test      rax,rax
       je        short M07_L02
       cmp       [rax],rcx
       je        short M07_L02
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M07_L02:
       mov       [rsp+0D0],rax
       cmp       byte ptr [rbx+116],0
       jne       near ptr M07_L17
       mov       rcx,[rbx+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M07_L14
       cmp       qword ptr [rsp+0D0],0
       je        near ptr M07_L14
       mov       rbp,[rbx+0B8]
       mov       rcx,[rsp+0D0]
       cmp       [rbp],bpl
       call      qword ptr [7FF823F1C9A8]; System.Object.GetType()
       mov       r14,rax
       mov       rcx,2C5C3CD19B8
       cmp       r14,rcx
       je        near ptr M07_L14
       mov       rsi,[rbp+10]
       test      rsi,rsi
       je        short M07_L03
       mov       rcx,[rsi+0C0]
       cmp       rcx,r14
       je        near ptr M07_L10
M07_L03:
       xor       esi,esi
       cmp       byte ptr [rbp+9E],0
       je        short M07_L07
       mov       rsi,[rbp+8]
       test      rsi,rsi
       je        near ptr M07_L18
M07_L04:
       mov       r15,[rsi+8]
       mov       rcx,2852EC01960
       mov       r9,[rcx]
       test      r9,r9
       je        near ptr M07_L19
M07_L05:
       mov       [rsp+20],rsi
       mov       rcx,r15
       mov       r8,r14
       mov       rdx,7FF824450118
       cmp       [rcx],ecx
       call      qword ptr [7FF8243CD050]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)
       cmp       byte ptr [rax+20],0
       je        near ptr M07_L21
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       near ptr M07_L20
       mov       rsi,[rax+8]
M07_L06:
       test      rsi,rsi
       je        short M07_L07
       cmp       byte ptr [rsi+119],2
       jne       near ptr M07_L22
M07_L07:
       test      rsi,rsi
       jne       short M07_L09
       mov       rdx,[rbp+20]
       mov       rcx,r14
       call      qword ptr [7FF82479ECA0]
       int       3
M07_L08:
       mov       rdx,7FF8247E74D8
       call      qword ptr [7FF823F1C5A0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M07_L01
M07_L09:
       lea       rcx,[rbp+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M07_L10:
       cmp       byte ptr [rsi+11A],0
       je        short M07_L13
M07_L11:
       mov       rcx,[rsi+0F8]
       test      rcx,rcx
       cmovne    rsi,rcx
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord>
       cmp       [rsi],rcx
       jne       near ptr M07_L23
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FF824437858]
M07_L12:
       nop
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L13:
       mov       rcx,rsi
       call      qword ptr [7FF8246264F0]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[rsi+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+11A],1
       jmp       short M07_L11
M07_L14:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+30],ymm0
       vmovdqu   ymmword ptr [rsp+50],ymm0
       vmovdqu   ymmword ptr [rsp+70],ymm0
       vmovdqu   ymmword ptr [rsp+90],ymm0
       vmovdqu   ymmword ptr [rsp+0B0],ymm0
       mov       [rsp+98],rbx
       mov       rcx,[rbx+0D0]
       mov       [rsp+90],rcx
       mov       rcx,[rsp+90]
       mov       rcx,[rcx+0C8]
       mov       [rsp+0C0],rcx
       mov       byte ptr [rsp+7E],0
       mov       byte ptr [rsp+7F],0
       mov       rbp,[rbx+0B8]
       cmp       dword ptr [rbp+8C],0
       je        short M07_L15
       mov       rcx,[rbp+38]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rsp+50],rax
       cmp       dword ptr [rbp+8C],2
       jne       short M07_L15
       test      rsi,rsi
       jne       near ptr M07_L24
M07_L15:
       lea       rcx,[rsp+30]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+158]
       mov       r9,[rbx+0B8]
       lea       r8,[rsp+0D0]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF824627468]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M07_L16:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF824627EB8]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M07_L12
M07_L17:
       mov       rax,[rbx+148]
       mov       rdx,rdi
       mov       r8,[rsp+0D0]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M07_L16
M07_L18:
       mov       rcx,rbp
       call      qword ptr [7FF8243CCAF8]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rsi,rax
       jmp       near ptr M07_L04
M07_L19:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF823E5D050
       mov       [r13+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [r13+20],rcx
       mov       rcx,2852EC01960
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M07_L05
M07_L20:
       call      qword ptr [7FF82479EC88]
       int       3
M07_L21:
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rax
       call      qword ptr [7FF82479EF40]
       mov       rsi,rax
       jmp       near ptr M07_L06
M07_L22:
       mov       rcx,rsi
       call      qword ptr [7FF8244B67D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M07_L07
M07_L23:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8,[rsp+0D0]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M07_L12
M07_L24:
       mov       rcx,[rbx+0C0]
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        near ptr M07_L15
       mov       rcx,[rsp+50]
       mov       rdx,rsi
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       near ptr M07_L15
; Total bytes of code 1011
```
```assembly
; System.Net.ArrayBuffer.get_ActiveSpan()
       sub       rsp,28
       mov       rax,[rcx]
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       mov       ecx,[rcx+0C]
       sub       ecx,r8d
       test      rax,rax
       je        short M08_L01
       mov       r8d,ecx
       add       r8,r10
       mov       r9d,[rax+8]
       cmp       r8,r9
       ja        short M08_L02
       lea       rax,[rax+r10+10]
M08_L00:
       mov       [rdx],rax
       mov       [rdx+8],ecx
       mov       rax,rdx
       add       rsp,28
       ret
M08_L01:
       or        r10d,ecx
       jne       short M08_L02
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M08_L00
M08_L02:
       call      qword ptr [7FF824087198]
       int       3
; Total bytes of code 77
```
```assembly
; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte ByRef, Int32)
       mov       [rcx],rdx
       mov       [rcx+8],r8d
       ret
; Total bytes of code 8
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
       mov       r8,2852EC013D0
       mov       rbx,[r8]
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       r8d,1
       test      edi,edi
       cmove     rsi,r8
       mov       [rbp-38],rsi
       test      rsi,rsi
       je        near ptr M10_L06
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FF824084C30]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       mov       r9d,eax
       sub       r9d,esi
       mov       r14d,r9d
       add       r14d,[rbp-48]
       cmp       r9d,edi
       jne       near ptr M10_L07
M10_L00:
       test      r14d,r14d
       je        near ptr M10_L04
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FF883B94CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       [rbp-40],rcx
       mov       r13,[rbp-40]
       test      r13,r13
       je        short M10_L03
       mov       ecx,edi
       or        ecx,r14d
       jl        short M10_L02
       lea       rcx,[rbp-58]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-60]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       mov       edx,edi
       mov       r8,r13
       mov       r9d,r14d
       call      qword ptr [7FF824084C60]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
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
       jmp       short M10_L05
M10_L02:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FF824535BC0]
       int       3
M10_L03:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FF82479FD68]
       int       3
M10_L04:
       mov       r15,2C5C3CD0008
M10_L05:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       short M10_L09
M10_L06:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FF82479FD68]
       int       3
M10_L07:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FF82479FD80]
       add       r14d,eax
       jns       near ptr M10_L00
       call      qword ptr [7FF82479FD98]
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
       call      qword ptr [7FF82479FDB0]
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
       call      qword ptr [7FF82479FDC8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 431
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
       call      qword ptr [7FF95510E028]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
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
       call      qword ptr [7FF95510E028]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
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
       mov       rcx,7FF824804738
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
       mov       rdx,7FF824804630
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
       mov       rcx,7FF82480473C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF824804738
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rbx,[rbx+20]
       mov       rcx,rbx
       mov       rdx,7FF824804740
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
       mov       rcx,7FF824804848
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L00
M12_L03:
       mov       rcx,7FF82480484C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L00
M12_L04:
       mov       rcx,7FF824804850
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
       mov       rax,2852EC013F8
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
       call      qword ptr [7FF824627870]; System.Text.Json.Utf8JsonWriter.WriteStringMinimized(System.ReadOnlySpan`1<Char>)
       jmp       short M13_L06
M13_L05:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FF8246278B8]; System.Text.Json.Utf8JsonWriter.WriteStringEscapeValue(System.ReadOnlySpan`1<Char>, Int32)
M13_L06:
       or        dword ptr [rbx+28],80000000
       mov       byte ptr [rbx+3A],7
       jmp       short M13_L08
M13_L07:
       mov       rcx,rbx
       call      qword ptr [7FF824627BA0]
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
       call      qword ptr [7FF824627498]; System.Text.Json.WriteStack.Push()
       mov       r8,[rdi]
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SmallObjectWithParameterizedConstructorConverter<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, System.String, System.Object, System.Object, System.Object>
       cmp       [rsi],rcx
       jne       short M13_L19
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FF8244DDD00]; System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[[System.__Canon, System.Private.CoreLib]].OnTryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       mov       r15d,eax
M13_L17:
       mov       rcx,[rbp+30]
       mov       edx,r15d
       call      qword ptr [7FF8246279F0]; System.Text.Json.WriteStack.Pop(Boolean)
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
       call      qword ptr [7FF824627B70]
       int       3
M13_L21:
       mov       rcx,rbx
       call      qword ptr [7FF824627BA0]
       jmp       near ptr M13_L09
M13_L22:
       cmp       byte ptr [rsi+1A],0
       je        near ptr M13_L01
       mov       rdi,[rdi]
       add       rcx,90
       call      qword ptr [7FF824535C98]; System.Nullable`1[[System.Text.Json.Serialization.JsonNumberHandling, System.Text.Json]].get_Value()
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
       call      qword ptr [7FF82479E148]
       int       3
M13_L24:
       mov       rcx,rbx
       call      qword ptr [7FF82479E160]
       test      eax,eax
       jne       near ptr M13_L04
       mov       rcx,rbx
       call      qword ptr [7FF82479E178]
       jmp       near ptr M13_L04
M13_L25:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FF82479E190]
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
       call      qword ptr [7FF824627B10]
       int       3
M13_L28:
       mov       rcx,r13
       call      qword ptr [7FF8244B67D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M13_L12
M13_L29:
       mov       [rsp+20],rcx
       mov       rdx,[rdi]
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FF82479E028]
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
       call      qword ptr [7FF82479E040]
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
       call      qword ptr [7FF82479EFE8]
M13_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.InvalidOperationException
       call      qword ptr [7FF823F16850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M13_L37
       mov       rdx,rbx
       mov       rcx,offset MT_System.Text.Json.JsonException
       call      qword ptr [7FF823F16850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M13_L36
       mov       rcx,rsi
       call      qword ptr [7FF82479F000]
       test      rax,rax
       jne       near ptr M13_L39
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FF82479F018]
       jmp       near ptr M13_L39
M13_L36:
       mov       rdx,rbx
       mov       rcx,offset MT_System.NotSupportedException
       call      qword ptr [7FF823F16850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M13_L39
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,2C5C3CDEF70
       cmp       [rcx],ecx
       call      qword ptr [7FF82479F048]
       test      eax,eax
       jne       short M13_L39
       jmp       short M13_L38
M13_L37:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       rdx,2C5C3CDEF20
       call      qword ptr [7FF824134F00]; System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M13_L39
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FF82479F030]
       jmp       short M13_L39
M13_L38:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FF82479F060]
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
       call      qword ptr [7FF82479FC60]
       int       3
M14_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M14_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF824802918]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF82479FC90]
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
       call      qword ptr [7FF82479FCA8]
M14_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M14_L02
M14_L06:
       mov       r11,7FF823E60D20
       call      qword ptr [r11]
       jmp       near ptr M14_L01
; Total bytes of code 232
```
```assembly
; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF95510D580]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF95510B548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF955108CC8]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF95510D4E8]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M16_L00:
       mov       rax,[rbp-20]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FF955108CC8]
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FF95510A210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95510D570]
       mov       [rbp-20],rsi
       lea       rax,[M16_L00]
       add       rsp,28
       ret
; Total bytes of code 138
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
       je        near ptr M17_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       near ptr M17_L07
M17_L00:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+0B8]
       mov       rbx,[rax+8]
       test      rbx,rbx
       je        near ptr M17_L08
M17_L01:
       mov       [rbp-18],rbx
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,rbx
       call      qword ptr [7FF95510A180]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M17_L04
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       short M17_L03
M17_L02:
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF95510DEF0]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M17_L04
M17_L03:
       mov       rcx,rax
       call      qword ptr [7FF95510A218]
       jmp       short M17_L02
M17_L04:
       cmp       byte ptr [rbp-10],0
       je        short M17_L05
       mov       rcx,rbx
       call      qword ptr [7FF95510A188]; Precode of System.Threading.Monitor.Exit(System.Object)
M17_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
M17_L06:
       call      qword ptr [7FF95510BE50]
       int       3
M17_L07:
       mov       rcx,rax
       call      qword ptr [7FF95510A218]
       jmp       near ptr M17_L00
M17_L08:
       mov       rcx,rax
       call      qword ptr [7FF95510D528]; Precode of System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M17_L01
       sub       rsp,28
       call      qword ptr [7FF95510A210]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      qword ptr [7FF955107258]; CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-10],0
       je        short M17_L09
       mov       rcx,[rbp-18]
       call      qword ptr [7FF95510A188]; Precode of System.Threading.Monitor.Exit(System.Object)
M17_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 310
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
       jle       near ptr M18_L37
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M18_L37
M18_L00:
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
       mov       rcx,2C5C3CD62A0
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M18_L36
       cmp       dword ptr [rbx+8],0
       je        near ptr M18_L36
       mov       rcx,2852EC01DE0
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
       jle       near ptr M18_L38
       mov       rcx,[rcx+240]
       mov       r15,[rcx+50]
       test      r15,r15
       je        near ptr M18_L38
M18_L01:
       mov       rax,[r15+10]
       test      rax,rax
       jne       near ptr M18_L16
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
       je        near ptr M18_L07
       mov       rcx,[rbp-80]
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M18_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FF82479DB18]
M18_L02:
       mov       dword ptr [rbp-40],1
       mov       rcx,[r15+10]
       lea       r8,[rbp-48]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF82413CF30]; System.Runtime.CompilerServices.ConditionalWeakTable`2+Container[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindEntry(System.__Canon, System.Object ByRef)
       cmp       eax,0FFFFFFFF
       jne       near ptr M18_L08
       mov       r12,[r15+10]
       mov       ecx,[r12+28]
       mov       rax,[r12+18]
       cmp       ecx,[rax+8]
       jge       near ptr M18_L09
M18_L03:
       cmp       byte ptr [r12+2C],0
       jne       near ptr M18_L10
       mov       byte ptr [r12+2C],1
       mov       rcx,r13
       call      00007FF883AFE4B0
       test      eax,eax
       je        near ptr M18_L06
M18_L04:
       mov       r15d,eax
       and       r15d,7FFFFFFF
       mov       eax,[r12+28]
       mov       [rbp-4C],eax
       lea       ecx,[rax+1]
       mov       [r12+28],ecx
       mov       rcx,[r12+18]
       cmp       eax,[rcx+8]
       jae       near ptr M18_L11
       mov       edx,eax
       shl       rdx,4
       lea       r8,[rcx+rdx+10]
       mov       [r8],r15d
       mov       [rbp-88],r8
       mov       rcx,r13
       xor       edx,edx
       call      00007FF883B63160
       test      rax,rax
       je        near ptr M18_L12
M18_L05:
       mov       rcx,[rbp-88]
       mov       [rcx+8],rax
       mov       rcx,[r12+10]
       mov       eax,[rcx+8]
       dec       eax
       and       eax,r15d
       mov       rdx,[r12+18]
       mov       r15d,[rbp-4C]
       cmp       r15d,[rdx+8]
       jae       near ptr M18_L11
       mov       r8d,r15d
       shl       r8,4
       mov       r10,rcx
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       near ptr M18_L11
       mov       r10d,[r10+rax*4+10]
       mov       [rdx+r8+14],r10d
       mov       [rcx+rax*4+10],r15d
       mov       byte ptr [r12+2C],0
       jmp       near ptr M18_L13
M18_L06:
       mov       rcx,r13
       call      qword ptr [7FF823F1E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M18_L04
M18_L07:
       xor       ecx,ecx
       call      qword ptr [7FF82479DAD0]
       int       3
M18_L08:
       mov       ecx,36
       call      qword ptr [7FF8248A4A08]
       int       3
M18_L09:
       mov       rcx,r12
       call      qword ptr [7FF8248A4A20]
       mov       r12,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M18_L03
M18_L10:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8248A4A38]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF824335FC8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M18_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M18_L12:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF8248A4A50]
       jmp       near ptr M18_L05
M18_L13:
       mov       rcx,[rbp-80]
       call      00007FF883B9DA10
       test      eax,eax
       jne       near ptr M18_L39
M18_L14:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       lea       rcx,[rsi+18]
       mov       eax,1
       xchg      al,[rcx]
       movzx     eax,al
       test      eax,eax
       je        near ptr M18_L27
M18_L15:
       mov       rax,r13
M18_L16:
       xor       r15d,r15d
       mov       r13d,1
       cmp       [rax+8],r14d
       jbe       near ptr M18_L23
       mov       r15d,1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       [rbx+8],ecx
       jne       near ptr M18_L41
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
       je        near ptr M18_L23
       mov       rcx,[rsi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M18_L46
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M18_L17
       mov       rcx,rsi
       mov       edx,r14d
       call      qword ptr [7FF82479ED18]
M18_L17:
       mov       r13,[rax+8]
       call      qword ptr [7FF8246B76A8]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       mov       edx,[r13+8]
       mov       [rbp-6C],edx
       test      edx,edx
       jle       near ptr M18_L45
       mov       [rbp-70],edx
M18_L18:
       cmp       eax,edx
       jae       near ptr M18_L46
       mov       [rbp-5C],eax
       mov       ecx,eax
       mov       r10,[r13+rcx*8+10]
       mov       [rbp-90],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-60],r9d
       mov       rcx,r10
       call      00007FF883B9DAF0
       test      eax,eax
       jne       short M18_L19
       mov       rcx,[rbp-90]
       call      qword ptr [7FF82479DB18]
M18_L19:
       mov       rax,[rbp-90]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-64],r8d
       cmp       [rcx+8],r8d
       jbe       short M18_L21
       test      r8d,r8d
       je        near ptr M18_L30
M18_L20:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-64]
       inc       ecx
       mov       rax,[rbp-90]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-60],1
M18_L21:
       mov       rcx,rax
       call      00007FF883B9DA10
       test      eax,eax
       jne       near ptr M18_L42
M18_L22:
       cmp       dword ptr [rbp-60],0
       je        near ptr M18_L43
       mov       r13d,1
M18_L23:
       mov       rcx,2852EC00C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       je        near ptr M18_L36
       mov       rcx,rbx
       call      00007FF883AFE4B0
       test      eax,eax
       je        near ptr M18_L31
       mov       [rbp-68],eax
M18_L24:
       mov       edx,[rbx+8]
       mov       [rbp-3C],edx
       mov       rcx,rsi
       call      00007FF883AFE4B0
       test      eax,eax
       je        near ptr M18_L32
M18_L25:
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-68]
       mov       r9d,[rbp-3C]
       mov       edx,3
       call      qword ptr [7FF82479DB30]
       test      r13d,r15d
       jne       near ptr M18_L36
       mov       rcx,rbx
       call      qword ptr [7FF8243CCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      00007FF883AFE4B0
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M18_L33
M18_L26:
       test      r15d,r15d
       jne       near ptr M18_L34
       mov       r14d,0FFFFFFFF
       mov       ecx,1
       jmp       near ptr M18_L35
M18_L27:
       mov       r15,2852EC01F30
       mov       r12,[r15]
       test      r12,r12
       jne       short M18_L28
       mov       rcx,offset MT_System.Func<System.Object, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,2852EC01F28
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Buffers.SharedArrayPool`1+<>c[[System.Byte, System.Private.CoreLib]].<InitializeTlsBucketsAndTrimming>b__11_0(System.Object)
       mov       [r12+18],rcx
       mov       rcx,r15
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M18_L28:
       mov       rcx,offset MT_System.Gen2GcCallback
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       xor       edx,edx
       call      00007FF883B2B5A0
       test      rax,rax
       je        near ptr M18_L40
M18_L29:
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [r15+18],rcx
       jmp       near ptr M18_L15
M18_L30:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       near ptr M18_L20
M18_L31:
       mov       rcx,rbx
       call      qword ptr [7FF823F1E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       [rbp-68],eax
       jmp       near ptr M18_L24
M18_L32:
       mov       rcx,rsi
       call      qword ptr [7FF823F1E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M18_L25
M18_L33:
       mov       rcx,rsi
       call      qword ptr [7FF823F1E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M18_L26
M18_L34:
       xor       ecx,ecx
M18_L35:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,ebx
       call      qword ptr [7FF82479ED48]
M18_L36:
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
M18_L37:
       mov       ecx,9
       call      qword ptr [7FF82479ECB8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M18_L00
M18_L38:
       mov       ecx,0A
       call      qword ptr [7FF82479ECB8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M18_L01
M18_L39:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FF82479DAE8]
       jmp       near ptr M18_L14
M18_L40:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8248A4A68]
       jmp       near ptr M18_L29
M18_L41:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF82479ED00]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF823E54000
       call      qword ptr [7FF824137798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF824336070]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M18_L42:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FF82479DAE8]
       jmp       near ptr M18_L22
M18_L43:
       mov       eax,[rbp-5C]
       inc       eax
       mov       ecx,eax
       mov       edx,[rbp-6C]
       cmp       edx,ecx
       jne       short M18_L44
       xor       ecx,ecx
M18_L44:
       mov       r8d,[rbp-70]
       dec       r8d
       mov       [rbp-70],r8d
       mov       eax,ecx
       jne       near ptr M18_L18
M18_L45:
       xor       r13d,r13d
       jmp       near ptr M18_L23
M18_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-40],0
       je        short M18_L48
       cmp       qword ptr [rbp-80],0
       jne       short M18_L47
       xor       ecx,ecx
       call      qword ptr [7FF82479DAD0]
       int       3
M18_L47:
       mov       rcx,[rbp-80]
       call      00007FF883B9DA10
       test      eax,eax
       je        short M18_L48
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FF82479DAE8]
M18_L48:
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
       je        near ptr M20_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M20_L01
       test      rsi,rsi
       je        short M20_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M20_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M20_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF883B94CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF823F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF823F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M20_L00:
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
M20_L01:
       test      rsi,rsi
       je        short M20_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M20_L03
M20_L02:
       mov       rax,2C5C3CD0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M20_L03:
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
M20_L04:
       call      qword ptr [7FF8248A4B10]
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
       call      qword ptr [7FF9551074E0]
       cmp       byte ptr [rax],0
       je        near ptr M21_L03
       call      qword ptr [7FF95510DBE0]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M21_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
M21_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M21_L01:
       call      qword ptr [7FF955109688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M21_L00
       call      qword ptr [7FF9551074D8]
       cmp       byte ptr [rax],0
       je        short M21_L00
       xorps     xmm0,xmm0
       movups    [rsp+30],xmm0
       mov       [rsp+30],rdi
       mov       [rsp+38],rsi
       lea       rcx,[rsp+20]
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       lea       r8,[rsp+30]
       mov       r9d,2
       call      qword ptr [7FF95510F2E0]
       lea       rcx,[rsp+20]
       call      qword ptr [7FF95510DC10]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M21_L00
       cmp       [rsi+10],rbx
       je        short M21_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+9F],0
       jne       short M21_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF95510D4D8]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M21_L00
M21_L02:
       mov       rcx,[rsi+8]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M21_L00
M21_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M21_L04
       call      qword ptr [7FF9551096A0]
       test      rax,rax
       je        near ptr M21_L00
M21_L04:
       call      qword ptr [7FF95510BE58]
       int       3
; Total bytes of code 284
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       [rsp+68],r9d
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       xor       ebp,ebp
       cmp       byte ptr [rbx+9E],0
       jne       short M22_L01
       cmp       byte ptr [rsp+70],0
       je        short M22_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95510D4E8]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbp,rax
M22_L00:
       test      rbp,rbp
       jne       short M22_L06
       cmp       byte ptr [rsp+69],0
       je        short M22_L06
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FF95510C050]
       int       3
M22_L01:
       mov       rbp,[rbx+8]
       test      rbp,rbp
       je        short M22_L07
M22_L02:
       cmp       [rbp],bpl
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF95510D548]; Precode of System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       mov       r14,rax
       cmp       byte ptr [rsp+78],0
       jne       short M22_L08
M22_L03:
       mov       rcx,[r14+10]
       test      rcx,rcx
       jne       short M22_L09
M22_L04:
       mov       rbp,[r14+8]
M22_L05:
       test      dil,dil
       je        short M22_L00
       test      rbp,rbp
       je        short M22_L00
       cmp       byte ptr [rbp+119],2
       je        short M22_L00
       jmp       short M22_L11
M22_L06:
       mov       rax,rbp
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M22_L07:
       mov       rcx,rbx
       call      qword ptr [7FF95510D528]; Precode of System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbp,rax
       jmp       short M22_L02
M22_L08:
       cmp       byte ptr [r14+20],0
       je        short M22_L10
       jmp       short M22_L03
M22_L09:
       call      qword ptr [7FF95510A218]
       jmp       short M22_L04
M22_L10:
       mov       rcx,rbp
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FF95510D558]
       mov       rbp,rax
       jmp       short M22_L05
M22_L11:
       mov       rcx,rbp
       call      qword ptr [7FF95510DF90]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M22_L00
; Total bytes of code 231
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M23_L00
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M23_L00
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M23_L01
M23_L00:
       mov       rax,rdx
       ret
M23_L01:
       test      rax,rax
       je        short M23_L04
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M23_L00
       jmp       short M23_L03
M23_L02:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M23_L00
       jmp       short M23_L01
M23_L03:
       test      rax,rax
       je        short M23_L04
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M23_L00
       test      rax,rax
       je        short M23_L04
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M23_L00
       test      rax,rax
       jne       short M23_L02
M23_L04:
       jmp       qword ptr [7FF8248A42A0]
; Total bytes of code 92
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF883980CF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FF823F15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,178
       lea       rbp,[rsp+1B0]
       xor       eax,eax
       mov       [rbp-158],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-150],xmm4
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
       je        near ptr M00_L39
       mov       [rbp-40],rcx
       mov       rcx,1F054401DD8
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9F],0
       je        near ptr M00_L40
M00_L01:
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        near ptr M00_L41
M00_L02:
       mov       r14,rdx
       test      r14,r14
       je        short M00_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
       cmp       [r14],rcx
       jne       near ptr M00_L42
M00_L03:
       mov       rsi,[r14+0B8]
       lea       rdx,[rbp-50]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF82452FD50]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       r15d,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],9
       jle       near ptr M00_L43
       mov       rcx,[rcx+240]
       mov       rsi,[rcx+48]
       test      rsi,rsi
       je        near ptr M00_L43
M00_L04:
       mov       rax,[rsi+10]
       test      rax,rax
       jne       short M00_L05
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,230E91F62A0
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
M00_L05:
       mov       ecx,[rax+18]
       lea       edx,[rcx+1]
       mov       [rax+18],edx
       test      ecx,ecx
       je        near ptr M00_L11
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      r15d,r15d
       je        near ptr M00_L45
       mov       rcx,1F054401DE0
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FF8245BC0E0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
M00_L06:
       mov       [rbp-68],rax
       lea       rcx,[rsi+18]
       mov       rdx,[rbp-68]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       byte ptr [rsi+28],1
       mov       [rbp-160],rsi
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12d,[rbp-44]
       mov       edx,r12d
       lea       rdi,[r13+70]
       lea       rsi,[rbp-50]
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
       je        short M00_L10
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L07:
       mov       [r13+2C],eax
       test      dl,4
       jne       near ptr M00_L46
       mov       r15,230E91F1518
M00_L08:
       mov       ecx,[r15+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       short M00_L09
       mov       dword ptr [r13+78],3E8
M00_L09:
       mov       [rbp-168],r13
       jmp       near ptr M00_L17
M00_L10:
       mov       eax,2
       jmp       short M00_L07
M00_L11:
       mov       rcx,[rax+8]
       mov       [rbp-160],rcx
       mov       r13,[rax+10]
       mov       rcx,[rbp-160]
       cmp       [rcx],cl
       mov       rcx,[rbp-160]
       add       rcx,18
       mov       rdx,[rcx]
       mov       edx,[rdx+8]
       sub       edx,[rcx+0C]
       cmp       edx,r15d
       jl        near ptr M00_L15
M00_L12:
       lea       rcx,[r13+8]
       mov       rdx,[rbp-160]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12d,[rbp-44]
       mov       edx,r12d
       lea       rdi,[r13+70]
       lea       rsi,[rbp-50]
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
       je        short M00_L16
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L13:
       mov       [r13+2C],eax
       test      dl,4
       jne       near ptr M00_L44
       mov       rsi,230E91F1518
M00_L14:
       mov       ecx,[rsi+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       near ptr M00_L09
       mov       dword ptr [r13+78],3E8
       jmp       near ptr M00_L09
M00_L15:
       mov       edx,r15d
       call      qword ptr [7FF82452FDE0]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L12
M00_L16:
       mov       eax,2
       jmp       short M00_L13
M00_L17:
       cmp       byte ptr [r14+116],0
       jne       near ptr M00_L30
       mov       rcx,[r14+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M00_L28
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L28
       mov       rsi,[r14+0B8]
       mov       rcx,[rbp-40]
       cmp       [rsi],sil
       call      qword ptr [7FF823F0C9A8]; System.Object.GetType()
       mov       rdi,rax
       mov       rcx,230E91F19B8
       cmp       rdi,rcx
       je        near ptr M00_L28
       mov       r14,[rsi+10]
       test      r14,r14
       je        short M00_L18
       mov       rcx,[r14+0C0]
       cmp       rcx,rdi
       je        near ptr M00_L25
M00_L18:
       xor       r14d,r14d
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L24
       mov       r14,[rsi+8]
       test      r14,r14
       je        near ptr M00_L31
M00_L19:
       mov       r15,[r14+8]
       mov       rcx,1F054401960
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M00_L32
M00_L20:
       cmp       [r15],r15b
       mov       rax,[r15+8]
       mov       [rbp-170],rax
       mov       rcx,[rax+8]
       cmp       byte ptr [r15+19],0
       je        near ptr M00_L33
       mov       rcx,rdi
       mov       rdx,[7FF823E4A1C0]
       call      qword ptr [rdx+18]
M00_L21:
       lea       rdx,[rbp-110]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-170]
       mov       r8,rdi
       mov       [rbp-114],eax
       mov       r9d,eax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      qword ptr [7FF824326658]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       jne       short M00_L22
       mov       rdx,rdi
       mov       r8,r14
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-110]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,[rbp-114]
       shl       r9,20
       or        r9,1
       mov       rdx,[rbp-170]
       mov       r8,rdi
       mov       rcx,r15
       call      qword ptr [7FF82432C510]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
M00_L22:
       mov       r8,[rbp-110]
       xor       ecx,ecx
       mov       [rbp-110],rcx
       cmp       byte ptr [r8+20],0
       je        near ptr M00_L35
       mov       rcx,[r8+10]
       test      rcx,rcx
       jne       near ptr M00_L34
       mov       r14,[r8+8]
M00_L23:
       test      r14,r14
       je        short M00_L24
       cmp       byte ptr [r14+119],2
       jne       near ptr M00_L36
M00_L24:
       test      r14,r14
       je        near ptr M00_L27
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L25:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF8248949D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.get_AncestorPolymorphicType()
       test      rax,rax
       cmovne    r14,rax
       mov       rdx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       cmp       [r14],rdx
       jne       near ptr M00_L37
       mov       rsi,[rbp-40]
       mov       rdx,rsi
       mov       rcx,7FF824778968
       call      qword ptr [7FF8246173D8]; System.Text.Json.JsonSerializer.UnboxOnWrite[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       [rbp-120],rax
       lea       r8,[rbp-120]
       mov       rcx,r14
       mov       rdx,r13
       mov       r9,rsi
       call      qword ptr [7FF82452FEB8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       xor       ecx,ecx
       mov       [rbp-120],rcx
M00_L26:
       mov       rcx,[rbp-160]
       cmp       [rcx],cl
       mov       rcx,[rbp-160]
       add       rcx,18
       lea       rdx,[rbp-130]
       call      qword ptr [7FF8248949F0]; System.Net.ArrayBuffer.get_ActiveSpan()
       mov       rdx,[rbp-130]
       mov       r8d,[rbp-128]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-140],xmm0
       lea       rcx,[rbp-140]
       call      qword ptr [7FF824894A08]; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte ByRef, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-140]
       vmovdqu   xmmword ptr [rbp-158],xmm0
       lea       rcx,[rbp-158]
       call      qword ptr [7FF824525DA0]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rsi,rax
       jmp       near ptr M00_L38
M00_L27:
       mov       rdx,[rsi+20]
       mov       rcx,rdi
       call      qword ptr [7FF82478FAB0]
       int       3
M00_L28:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-108],ymm0
       vmovdqu   ymmword ptr [rbp-0E8],ymm0
       vmovdqu   ymmword ptr [rbp-0C8],ymm0
       vmovdqu   ymmword ptr [rbp-0A8],ymm0
       vmovdqu   ymmword ptr [rbp-88],ymm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-108]
       mov       rdx,r14
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF824617408]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-108]
       mov       [rsp+20],rcx
       mov       rcx,[r14+158]
       mov       r9,[r14+0B8]
       lea       r8,[rbp-40]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF824617420]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L29:
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF824617D50]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M00_L26
M00_L30:
       mov       rax,[r14+148]
       mov       rdx,r13
       mov       r8,[rbp-40]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M00_L29
M00_L31:
       mov       rcx,rsi
       call      qword ptr [7FF8243BCAF8]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       r14,rax
       jmp       near ptr M00_L19
M00_L32:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF823E4D050
       mov       [r12+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [r12+20],rcx
       mov       rcx,1F054401960
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L20
M00_L33:
       mov       rdx,rdi
       mov       r11,7FF823E50CF8
       call      qword ptr [r11]
       jmp       near ptr M00_L21
M00_L34:
       call      qword ptr [7FF82478FA98]
       int       3
M00_L35:
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF82478FB88]
       mov       r14,rax
       jmp       near ptr M00_L23
M00_L36:
       mov       rcx,r14
       call      qword ptr [7FF8244A67D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L24
M00_L37:
       mov       rcx,r14
       mov       rdx,r13
       mov       r8,[rbp-40]
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L26
M00_L38:
       mov       rcx,r13
       mov       rdx,[rbp-160]
       call      qword ptr [7FF824617D80]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       [rbp-148],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rbp-148]
       mov       rdx,7FF824778B80
       cmp       [rcx],ecx
       call      qword ptr [7FF82471F678]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,178
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
       call      qword ptr [7FF8245268F8]
       mov       ecx,1C4D
       mov       rdx,7FF824274870
       call      qword ptr [7FF824127798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FF824274870
       call      qword ptr [7FF824127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF823F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FF824274870
       call      qword ptr [7FF824127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF823F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8248949A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8248949C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L40:
       mov       rcx,rsi
       call      qword ptr [7FF8243B72D0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L41:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       mov       r9d,101
       mov       rcx,rsi
       mov       rdx,230E91F19B8
       mov       r8d,1
       call      qword ptr [7FF8243BCAE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rdi,rax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       jmp       near ptr M00_L02
M00_L42:
       call      qword ptr [7FF823F06328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L43:
       mov       ecx,9
       call      qword ptr [7FF82478EE80]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rsi,rax
       jmp       near ptr M00_L04
M00_L44:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      qword ptr [7FF823F05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F06A4006C0
       mov       rsi,[rcx]
       jmp       near ptr M00_L14
M00_L45:
       mov       rax,230E91F62A0
       jmp       near ptr M00_L06
M00_L46:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      qword ptr [7FF823F05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F06A4006C0
       mov       r15,[rcx]
       jmp       near ptr M00_L08
       sub       rsp,48
       mov       rcx,[rbp-168]
       mov       rdx,[rbp-160]
       call      qword ptr [7FF824617D80]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       nop
       add       rsp,48
       ret
; Total bytes of code 2270
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
       jne       near ptr M01_L10
       and       esi,0FFFFFFF7
M01_L00:
       mov       edx,[rcx+84]
       cmp       edx,7F
       ja        near ptr M01_L12
       and       esi,0FFFFF80F
       test      edx,edx
       je        near ptr M01_L07
       xor       r8d,r8d
       cmp       edx,2
       cmovne    r8d,edx
M01_L01:
       shl       r8d,4
       or        esi,r8d
       mov       edi,[rcx+88]
       test      edi,edi
       jl        near ptr M01_L13
       mov       r8,[rcx+50]
       test      r8,r8
       jne       short M01_L02
       mov       r8,230E91F1518
       mov       [rcx+50],r8
M01_L02:
       mov       rcx,230E91FFFA8
       cmp       r8,rcx
       je        short M01_L04
       cmp       dword ptr [r8+8],1
       jne       short M01_L03
       cmp       word ptr [r8+0C],0A
       je        short M01_L04
M01_L03:
       mov       rcx,230E91F1518
       cmp       r8,rcx
       je        short M01_L04
       cmp       dword ptr [r8+8],2
       jne       short M01_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M01_L08
M01_L04:
       mov       rcx,230E91F1518
       cmp       r8,rcx
       je        short M01_L05
       cmp       dword ptr [r8+8],2
       jne       short M01_L09
       cmp       dword ptr [r8+0C],0A000D
       jne       short M01_L09
M01_L05:
       and       esi,0FFFFFFFB
M01_L06:
       or        esi,2
       mov       [rax],rbx
       mov       [rax+8],edi
       mov       [rax+0C],esi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       r8d,2
       jmp       near ptr M01_L01
M01_L08:
       mov       ecx,38A0
       mov       rdx,7FF8243CF2D8
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF82478FB58]
       int       3
M01_L09:
       or        esi,4
       jmp       short M01_L06
M01_L10:
       cmp       edx,9
       je        short M01_L11
       mov       ecx,38A0
       mov       rdx,7FF8243CF2D8
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF82478FB10]
       int       3
M01_L11:
       or        esi,8
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,38A0
       mov       rdx,7FF8243CF2D8
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FF82478FB28]
       int       3
M01_L13:
       mov       ecx,38A0
       mov       rdx,7FF8243CF2D8
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF82478FB40]
       int       3
; Total bytes of code 409
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
       mov       rcx,1F054400C90
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
       jle       short M02_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        short M02_L02
M02_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,ebp
       jbe       short M02_L04
       mov       eax,ebp
       shl       rax,4
       mov       r14,[rcx+rax+10]
       test      r14,r14
       je        short M02_L04
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [rdi+9D],0
       jne       short M02_L03
M02_L01:
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
M02_L02:
       mov       ecx,0A
       call      qword ptr [7FF82478EE80]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M02_L00
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF82478EE98]
       jmp       short M02_L01
M02_L04:
       mov       rax,[rsi+10]
       cmp       [rax+8],ebp
       jbe       near ptr M02_L13
       mov       ecx,ebp
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        near ptr M02_L12
       mov       r14,[rax+8]
       call      qword ptr [7FF8246A7540]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       ebx,eax
       sub       ebx,ecx
       xor       r15d,r15d
       jmp       short M02_L08
M02_L05:
       cmp       ebx,[r14+8]
       jae       near ptr M02_L18
       mov       ecx,ebx
       mov       r13,[r14+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FF8244AD890]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M02_L06
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M02_L06:
       mov       rcx,r13
       call      qword ptr [7FF823F06820]
       test      r12,r12
       jne       short M02_L09
       inc       ebx
       cmp       [r14+8],ebx
       jne       short M02_L07
       xor       ebx,ebx
M02_L07:
       inc       r15d
M02_L08:
       cmp       [r14+8],r15d
       jg        short M02_L05
       jmp       short M02_L10
M02_L09:
       mov       r14,r12
       jmp       short M02_L11
M02_L10:
       xor       r14d,r14d
M02_L11:
       test      r14,r14
       je        short M02_L12
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L01
       mov       rcx,r14
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF82478EE98]
       jmp       near ptr M02_L01
M02_L12:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M02_L15
M02_L13:
       test      ebx,ebx
       jne       short M02_L14
       mov       rax,230E91F62A0
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
M02_L14:
       mov       ecx,ebx
       mov       rdx,230E91F6F28
       call      qword ptr [7FF82412D8A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M02_L15:
       cmp       ebx,800
       jge       short M02_L16
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M02_L17
M02_L16:
       mov       ecx,ebx
       xor       edx,edx
       call      qword ptr [7FF82452FE88]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M02_L17:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF82478EE98]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FF82478EEE0]
       jmp       near ptr M02_L01
M02_L18:
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
       je        near ptr M03_L08
       mov       eax,[rbx+8]
       mov       ecx,[r8+8]
       mov       esi,[rbx+0C]
       sub       ecx,esi
       add       ecx,eax
       cmp       edx,ecx
       jle       near ptr M03_L09
       sub       esi,eax
       add       edx,esi
       cmp       edx,7FFFFFC7
       ja        near ptr M03_L10
       mov       ecx,[r8+8]
       add       ecx,ecx
       mov       eax,7FFFFFC7
       cmp       rcx,7FFFFFC7
       cmovl     rax,rcx
       cmp       edx,eax
       cmovl     edx,eax
       cmp       byte ptr [rbx+10],0
       je        near ptr M03_L11
       mov       rcx,1F054401DE0
       mov       rcx,[rcx]
       call      qword ptr [7FF8245BC0E0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rsi,rax
M03_L00:
       mov       rdi,[rbx]
       mov       ebp,[rbx+0C]
       mov       r14d,[rbx+8]
       sub       ebp,r14d
       je        near ptr M03_L03
       test      rdi,rdi
       je        near ptr M03_L12
       test      rsi,rsi
       je        near ptr M03_L13
       mov       r15d,[rdi+8]
       mov       rcx,offset MT_System.Byte[]
       cmp       [rdi],rcx
       jne       near ptr M03_L14
M03_L01:
       mov       r13,r15
       cmp       rdi,rsi
       je        short M03_L02
       mov       r13d,[rsi+8]
       mov       rcx,offset MT_System.Byte[]
       cmp       [rsi],rcx
       jne       near ptr M03_L16
M03_L02:
       test      r14d,r14d
       jl        near ptr M03_L18
       test      ebp,ebp
       jl        near ptr M03_L19
       mov       r8d,ebp
       mov       edx,r14d
       lea       rcx,[rdx+r8]
       cmp       rcx,r15
       ja        near ptr M03_L20
       cmp       r13,r8
       jb        near ptr M03_L20
       lea       rcx,[rsi+10]
       lea       rdx,[rdi+rdx+10]
       call      qword ptr [7FF823F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L03:
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+10],0
       je        near ptr M03_L07
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        near ptr M03_L07
       mov       rcx,1F054401DE0
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
       jle       near ptr M03_L21
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        near ptr M03_L21
M03_L04:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M03_L22
M03_L05:
       xor       r14d,r14d
       mov       r15d,1
       mov       ecx,[rax+8]
       cmp       ecx,ebp
       jbe       short M03_L06
       mov       r14d,1
       mov       ecx,10
       shlx      ecx,ecx,ebp
       cmp       ebx,ecx
       jne       near ptr M03_L23
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
       jne       near ptr M03_L24
M03_L06:
       mov       rcx,1F054400C90
       mov       r13,[rcx]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M03_L36
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
       mov       rcx,1F054401DE0
       mov       rcx,[rcx]
       call      qword ptr [7FF8245BC0E0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,rbx
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L07
M03_L09:
       mov       edx,esi
       sub       edx,eax
       mov       [rsp+20],edx
       mov       edx,eax
       mov       rcx,r8
       xor       r9d,r9d
       call      qword ptr [7FF82407DF68]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       jmp       short M03_L07
M03_L10:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF82478ED48]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       near ptr M03_L00
M03_L12:
       mov       ecx,257
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF82478F5E8]
       int       3
M03_L13:
       mov       ecx,25F
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF82478F5E8]
       int       3
M03_L14:
       mov       rcx,rdi
       call      00007FF883A38270
       mov       ecx,3003FFC
       bt        ecx,eax
       jb        short M03_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF82478F600]
       mov       rsi,rax
       mov       ecx,257
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF824326070]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L15:
       mov       rcx,[rdi]
       movzx     ecx,word ptr [rcx]
       imul      r15,rcx
       jmp       near ptr M03_L01
M03_L16:
       mov       rcx,rsi
       call      00007FF883A38270
       mov       ecx,3003FFC
       bt        ecx,eax
       jb        short M03_L17
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF82478F600]
       mov       rbp,rax
       mov       ecx,25F
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,r14
       call      qword ptr [7FF824326070]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M03_L17:
       mov       rcx,[rsi]
       movzx     ecx,word ptr [rcx]
       imul      r13,rcx
       jmp       near ptr M03_L02
M03_L18:
       mov       ecx,267
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF82478EE20]
       int       3
M03_L19:
       mov       ecx,28F
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FF82478EE20]
       int       3
M03_L20:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF82478F618]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF824324180]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M03_L21:
       mov       ecx,0A
       call      qword ptr [7FF82478EE80]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L04
M03_L22:
       mov       rcx,rsi
       call      qword ptr [7FF824617DC8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M03_L05
M03_L23:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF82478EF70]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF824326070]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L24:
       mov       rcx,[rsi+10]
       cmp       ebp,[rcx+8]
       jae       near ptr M03_L39
       mov       edx,ebp
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M03_L25
       mov       rcx,rsi
       mov       edx,ebp
       call      qword ptr [7FF82478EF88]
M03_L25:
       mov       r15,[rax+8]
       call      qword ptr [7FF8246A7540]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r13d,eax
       sub       r13d,ecx
       xor       eax,eax
       jmp       near ptr M03_L32
M03_L26:
       cmp       r13d,[r15+8]
       jae       near ptr M03_L39
       mov       ecx,r13d
       mov       rdx,[r15+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+3C],r8d
       mov       rcx,rdx
       call      qword ptr [7FF8244AD890]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+38],r8d
       cmp       [rcx+8],r8d
       jbe       short M03_L28
       test      r8d,r8d
       jne       short M03_L29
       xor       edx,edx
       mov       [rax+14],edx
M03_L27:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+38]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+3C],1
M03_L28:
       mov       rcx,rax
       call      qword ptr [7FF823F06820]
       cmp       dword ptr [rsp+3C],0
       je        short M03_L30
       jmp       short M03_L33
M03_L29:
       jmp       short M03_L27
M03_L30:
       inc       r13d
       cmp       [r15+8],r13d
       jne       short M03_L31
       xor       r13d,r13d
M03_L31:
       mov       eax,[rsp+40]
       inc       eax
M03_L32:
       mov       [rsp+40],eax
       cmp       [r15+8],eax
       jg        near ptr M03_L26
       jmp       short M03_L34
M03_L33:
       mov       r15d,1
       jmp       short M03_L35
M03_L34:
       xor       r15d,r15d
M03_L35:
       jmp       near ptr M03_L06
M03_L36:
       mov       rcx,rdi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       [rsp+44],ebx
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r13
       mov       r8d,r12d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FF82478EFA0]
       test      r15d,r14d
       jne       near ptr M03_L07
       mov       rcx,rdi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,rsi
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r14d,r14d
       jne       short M03_L37
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M03_L38
M03_L37:
       mov       ecx,ebp
       xor       edx,edx
M03_L38:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r13
       mov       edx,edi
       mov       r8d,ebx
       call      qword ptr [7FF82478EFB8]
       jmp       near ptr M03_L07
M03_L39:
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
       je        short M04_L01
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       call      qword ptr [7FF823F05C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M04_L00
; Total bytes of code 41
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rdi,r8
       mov       esi,r9d
       mov       rbp,[rdx+8]
       mov       rcx,[rdx+10]
       mov       eax,esi
       imul      rax,[rdx+28]
       shr       rax,20
       inc       rax
       mov       edx,[rcx+8]
       mov       r8d,edx
       imul      rax,r8
       shr       rax,20
       cmp       eax,edx
       jae       short M05_L03
       mov       eax,eax
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        short M05_L01
M05_L00:
       cmp       esi,[r14+20]
       jne       short M05_L02
       mov       rcx,rbx
       call      qword ptr [7FF881EB1AF0]
       mov       rdx,[r14+8]
       mov       rcx,rbp
       mov       r11,rax
       mov       r8,rdi
       call      qword ptr [rax]
       test      eax,eax
       je        short M05_L02
       mov       rdx,[r14+10]
       mov       rcx,[rsp+80]
       call      qword ptr [7FF881EB1268]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L01:
       xor       eax,eax
       mov       rbx,[rsp+80]
       mov       [rbx],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L02:
       mov       r14,[r14+18]
       test      r14,r14
       jne       short M05_L00
       jmp       short M05_L01
M05_L03:
       call      qword ptr [7FF881EB1258]
       int       3
; Total bytes of code 186
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
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
       mov       [rbp-58],rax
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       movzx     r9d,r9b
       mov       r11,[rbp+18]
       mov       r11,[r11+8]
       mov       [rbp-58],r11
       mov       eax,[rbp+2C]
       test      r9d,r9d
       je        near ptr M06_L20
M06_L00:
       mov       [rbp-3C],eax
M06_L01:
       mov       rax,[rbp+18]
       mov       rcx,[rax+18]
       mov       [rbp-60],rcx
       mov       r8,[rbp+10]
       cmp       [r8],r8d
       mov       rax,[rbp+18]
       mov       r10,[rax+10]
       mov       rax,[rbp+18]
       mov       r9d,[rbp-3C]
       imul      r9,[rax+28]
       shr       r9,20
       inc       r9
       mov       r11d,[r10+8]
       mov       ebx,r11d
       imul      r9,rbx
       shr       r9,20
       mov       eax,r9d
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rbp-40],edx
       cmp       r9d,r11d
       jae       near ptr M06_L27
       mov       ecx,r9d
       lea       rbx,[r10+rcx*8+10]
       xor       esi,esi
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-48],ecx
       cmp       byte ptr [rbp+40],0
       je        short M06_L02
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M06_L13
       mov       rcx,[rbp-60]
       mov       edx,[rbp-40]
       mov       rcx,[rcx+rdx*8+10]
       lea       rdx,[rbp-48]
       call      qword ptr [7FF881EB1D58]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
M06_L02:
       mov       rcx,[rbp+18]
       mov       r8,[rbp+10]
       cmp       rcx,[r8+8]
       jne       near ptr M06_L05
       xor       r14d,r14d
       mov       r15,[rbx]
       test      r15,r15
       jne       near ptr M06_L08
M06_L03:
       mov       rcx,[r8]
       call      qword ptr [7FF881EB1558]
       mov       rcx,rax
       call      qword ptr [7FF881EB1288]; CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       r13,[rbx]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+20]
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-3C]
       mov       [r15+20],ecx
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       mov       eax,[rcx+8]
       cmp       [rbp-40],eax
       jae       near ptr M06_L13
       mov       eax,[rbp-40]
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M06_L14
       mov       [rcx],eax
       mov       r8,[rbp+10]
       cmp       eax,[r8+10]
       jg        near ptr M06_L15
M06_L04:
       cmp       r14d,64
       jbe       near ptr M06_L17
       jmp       near ptr M06_L16
M06_L05:
       mov       rcx,[r8+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp-58]
       mov       r11,[rbp+18]
       cmp       rcx,[r11+8]
       je        near ptr M06_L23
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       mov       [rbp-58],rcx
       cmp       byte ptr [r8+19],0
       jne       short M06_L06
       mov       r8,[rbp+10]
       mov       rcx,[r8]
       call      qword ptr [7FF881EB18E8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
       jmp       short M06_L07
M06_L06:
       mov       rcx,[rbp+20]
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
M06_L07:
       mov       [rbp-3C],eax
       mov       r8,[rbp+10]
       jmp       near ptr M06_L23
M06_L08:
       mov       ecx,[rbp-3C]
       cmp       ecx,[r15+20]
       jne       short M06_L09
       mov       rcx,[r8]
       call      qword ptr [7FF881EB1500]
       mov       rcx,rax
       call      qword ptr [7FF881EB1AE8]
       mov       rdx,[r15+8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       r8,[rbp+20]
       call      qword ptr [rax]
       test      eax,eax
       mov       r8,[rbp+10]
       jne       short M06_L10
M06_L09:
       inc       r14d
       mov       r15,[r15+18]
       test      r15,r15
       jne       short M06_L08
       jmp       near ptr M06_L03
M06_L10:
       cmp       byte ptr [rbp+38],0
       je        short M06_L11
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF881EB1260]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF881EB1268]; CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M06_L12
M06_L11:
       mov       rdx,[r15+10]
       mov       rcx,[rbp+48]
       call      qword ptr [7FF881EB1268]; CORINFO_HELP_CHECKED_ASSIGN_REF
M06_L12:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       jmp       near ptr M06_L24
M06_L13:
       call      qword ptr [7FF881EB1258]
       int       3
M06_L14:
       call      qword ptr [7FF881EB1250]
       int       3
M06_L15:
       mov       esi,1
       jmp       near ptr M06_L04
M06_L16:
       mov       rcx,[rbp-58]
       call      qword ptr [7FF881EB1C10]
       mov       ecx,1
       test      rax,rax
       cmovne    edi,ecx
M06_L17:
       mov       r8,[rbp+10]
       cmp       byte ptr [rbp-48],0
       je        short M06_L18
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M06_L27
       mov       rcx,[rbp-60]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FF881EB1D60]
       mov       r8,[rbp+10]
M06_L18:
       mov       ecx,esi
       or        ecx,edi
       jne       short M06_L25
M06_L19:
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF881EB1268]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L20:
       cmp       byte ptr [rcx+19],0
       jne       short M06_L21
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       call      qword ptr [7FF881EB18E8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
       jmp       short M06_L22
M06_L21:
       mov       rcx,[rbp+20]
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
M06_L22:
       mov       rcx,[rbp+10]
       jmp       near ptr M06_L00
M06_L23:
       call      M06_L28
       jmp       near ptr M06_L01
M06_L24:
       call      M06_L28
       jmp       short M06_L26
M06_L25:
       mov       rcx,r8
       mov       rdx,[rbp+18]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FF881EB2430]
       jmp       near ptr M06_L19
M06_L26:
       mov       eax,[rbp-4C]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L27:
       call      qword ptr [7FF881EB1258]
       int       3
M06_L28:
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M06_L29
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       short M06_L30
       mov       rcx,[rbp-60]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FF881EB1D60]
M06_L29:
       nop
       add       rsp,28
       ret
M06_L30:
       call      qword ptr [7FF881EB1258]
       int       3
; Total bytes of code 950
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.get_AncestorPolymorphicType()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       byte ptr [rbx+11A],0
       je        short M07_L01
M07_L00:
       mov       rax,[rbx+0F8]
       add       rsp,20
       pop       rbx
       ret
M07_L01:
       mov       rcx,rbx
       call      qword ptr [7FF8246164A8]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[rbx+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+11A],1
       jmp       short M07_L00
; Total bytes of code 63
```
```assembly
; System.Text.Json.JsonSerializer.UnboxOnWrite[[System.__Canon, System.Private.CoreLib]](System.Object)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rcx,[rcx+18]
       mov       rcx,[rcx]
       mov       rax,rdx
       test      rax,rax
       je        short M08_L00
       cmp       [rax],rcx
       je        short M08_L00
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M08_L00:
       nop
       add       rsp,28
       ret
; Total bytes of code 40
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
M09_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0D0
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqu   ymmword ptr [rsp+70],ymm4
       vmovdqu   ymmword ptr [rsp+90],ymm4
       vmovdqu   ymmword ptr [rsp+0B0],ymm4
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       rbp,r9
       cmp       byte ptr [rbx+116],0
       jne       near ptr M09_L15
       mov       rcx,[rbx+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M09_L12
       mov       r8,[rsi]
       test      r8,r8
       je        near ptr M09_L12
       mov       r14,[rbx+0B8]
       mov       rcx,r8
       cmp       [r14],r14b
       call      qword ptr [7FF823F0C9A8]; System.Object.GetType()
       mov       r15,rax
       mov       rcx,230E91F19B8
       cmp       r15,rcx
       je        near ptr M09_L12
       mov       rbx,[r14+10]
       test      rbx,rbx
       je        short M09_L01
       mov       rcx,[rbx+0C0]
       cmp       rcx,r15
       je        near ptr M09_L06
M09_L01:
       xor       ebx,ebx
       cmp       byte ptr [r14+9E],0
       je        short M09_L05
       mov       rbx,[r14+8]
       test      rbx,rbx
       je        near ptr M09_L16
M09_L02:
       mov       rbp,[rbx+8]
       mov       rcx,1F054401960
       mov       r9,[rcx]
       test      r9,r9
       je        near ptr M09_L17
M09_L03:
       mov       [rsp+20],rbx
       mov       rcx,rbp
       mov       r8,r15
       mov       rdx,7FF824440118
       cmp       [rcx],ecx
       call      qword ptr [7FF8243BD050]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)
       cmp       byte ptr [rax+20],0
       je        near ptr M09_L19
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       near ptr M09_L18
       mov       rbx,[rax+8]
M09_L04:
       test      rbx,rbx
       je        short M09_L05
       cmp       byte ptr [rbx+119],2
       jne       near ptr M09_L20
M09_L05:
       test      rbx,rbx
       je        near ptr M09_L11
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M09_L06:
       cmp       byte ptr [rbx+11A],0
       je        short M09_L10
M09_L07:
       mov       rdx,[rbx+0F8]
       test      rdx,rdx
       cmovne    rbx,rdx
       mov       r14,[rsi]
       mov       rdx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>>
       cmp       [rbx],rdx
       jne       near ptr M09_L21
       mov       rax,r14
       test      rax,rax
       je        short M09_L08
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],rcx
       je        short M09_L08
       mov       rdx,r14
       call      qword ptr [7FF823F0FD08]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
M09_L08:
       mov       [rsp+28],rax
       lea       r8,[rsp+28]
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r9,r14
       call      qword ptr [7FF82452FEB8]
M09_L09:
       nop
       add       rsp,0D0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M09_L10:
       mov       rcx,rbx
       call      qword ptr [7FF8246164A8]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[rbx+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+11A],1
       jmp       near ptr M09_L07
M09_L11:
       mov       rdx,[r14+20]
       mov       rcx,r15
       call      qword ptr [7FF82478FAB0]
       int       3
M09_L12:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+30],ymm0
       vmovdqu   ymmword ptr [rsp+50],ymm0
       vmovdqu   ymmword ptr [rsp+70],ymm0
       vmovdqu   ymmword ptr [rsp+90],ymm0
       vmovdqu   ymmword ptr [rsp+0B0],ymm0
       mov       [rsp+98],rbx
       mov       rcx,[rbx+0D0]
       mov       [rsp+90],rcx
       mov       rcx,[rsp+90]
       mov       rcx,[rcx+0C8]
       mov       [rsp+0C0],rcx
       mov       byte ptr [rsp+7E],0
       mov       byte ptr [rsp+7F],0
       mov       r14,[rbx+0B8]
       cmp       dword ptr [r14+8C],0
       je        short M09_L13
       mov       rcx,[r14+38]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rsp+50],rax
       cmp       dword ptr [r14+8C],2
       jne       short M09_L13
       test      rbp,rbp
       jne       near ptr M09_L22
M09_L13:
       lea       rcx,[rsp+30]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+158]
       mov       r9,[rbx+0B8]
       mov       rdx,rdi
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF824617420]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M09_L14:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF824617D50]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M09_L09
M09_L15:
       mov       rax,[rbx+148]
       mov       r8,[rsi]
       mov       rdx,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M09_L14
M09_L16:
       mov       rcx,r14
       call      qword ptr [7FF8243BCAF8]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M09_L02
M09_L17:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF823E4D050
       mov       [r13+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [r13+20],rcx
       mov       rcx,1F054401960
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M09_L03
M09_L18:
       call      qword ptr [7FF82478FA98]
       int       3
M09_L19:
       mov       rcx,rbx
       mov       rdx,r15
       mov       r8,rax
       call      qword ptr [7FF82478FB88]
       mov       rbx,rax
       jmp       near ptr M09_L04
M09_L20:
       mov       rcx,rbx
       call      qword ptr [7FF8244A67D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M09_L05
M09_L21:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,r14
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M09_L09
M09_L22:
       mov       rcx,[rbx+0C0]
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        near ptr M09_L13
       mov       rcx,[rsp+50]
       mov       rdx,rbp
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       near ptr M09_L13
; Total bytes of code 949
```
```assembly
; System.Net.ArrayBuffer.get_ActiveSpan()
       sub       rsp,28
       mov       rax,[rcx]
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       mov       ecx,[rcx+0C]
       sub       ecx,r8d
       test      rax,rax
       je        short M10_L01
       mov       r8d,ecx
       add       r8,r10
       mov       r9d,[rax+8]
       cmp       r8,r9
       ja        short M10_L02
       lea       rax,[rax+r10+10]
M10_L00:
       mov       [rdx],rax
       mov       [rdx+8],ecx
       mov       rax,rdx
       add       rsp,28
       ret
M10_L01:
       or        r10d,ecx
       jne       short M10_L02
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M10_L00
M10_L02:
       call      qword ptr [7FF824077198]
       int       3
; Total bytes of code 77
```
```assembly
; System.ReadOnlySpan`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte ByRef, Int32)
       mov       [rcx],rdx
       mov       [rcx+8],r8d
       ret
; Total bytes of code 8
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
       mov       r8,1F0544013D0
       mov       rbx,[r8]
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       r8d,1
       test      edi,edi
       cmove     rsi,r8
       mov       [rbp-38],rsi
       test      rsi,rsi
       je        near ptr M12_L06
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FF824074C30]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       mov       r9d,eax
       sub       r9d,esi
       mov       r14d,r9d
       add       r14d,[rbp-48]
       cmp       r9d,edi
       jne       near ptr M12_L07
M12_L00:
       test      r14d,r14d
       je        near ptr M12_L04
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FF883B94CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       [rbp-40],rcx
       mov       r13,[rbp-40]
       test      r13,r13
       je        short M12_L03
       mov       ecx,edi
       or        ecx,r14d
       jl        short M12_L02
       lea       rcx,[rbp-58]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-60]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       mov       edx,edi
       mov       r8,r13
       mov       r9d,r14d
       call      qword ptr [7FF824074C60]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
       mov       ecx,[rbp-58]
       sub       ecx,esi
       mov       rdx,[rbp-60]
       sub       rdx,r13
       mov       r8,rdx
       shr       r8,3F
       add       rdx,r8
       sar       rdx,1
       cmp       ecx,edi
       jne       short M12_L08
M12_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       jmp       short M12_L05
M12_L02:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FF824525BC0]
       int       3
M12_L03:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FF82478FF78]
       int       3
M12_L04:
       mov       r15,230E91F0008
M12_L05:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       short M12_L09
M12_L06:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FF82478FF78]
       int       3
M12_L07:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FF82478FF90]
       add       r14d,eax
       jns       near ptr M12_L00
       call      qword ptr [7FF82478FFA8]
       int       3
M12_L08:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,r13
       call      qword ptr [7FF82478FFC0]
       jmp       near ptr M12_L01
M12_L09:
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
       call      qword ptr [7FF82478FFD8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 431
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
       jne       short M13_L01
M13_L00:
       mov       rcx,7FF824801080
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M13_L01:
       mov       r14,[rdi+38]
       mov       rcx,r14
       mov       rdx,7FF824800F78
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
       jne       near ptr M13_L04
       test      rbp,rbp
       je        short M13_L03
       mov       rcx,[rsi+0C0]
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        short M13_L02
       mov       rcx,7FF824801084
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF824801080
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rbx,[rbx+20]
       mov       rcx,rbx
       mov       rdx,7FF824801088
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
M13_L02:
       mov       rcx,7FF824801190
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M13_L00
M13_L03:
       mov       rcx,7FF824801194
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M13_L00
M13_L04:
       mov       rcx,7FF824801198
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M13_L00
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
       mov       rax,1F0544013F8
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
       call      qword ptr [7FF824617828]; System.Text.Json.Utf8JsonWriter.WriteStringMinimized(System.ReadOnlySpan`1<Char>)
       jmp       short M14_L06
M14_L05:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FF8247176F0]; System.Text.Json.Utf8JsonWriter.WriteStringEscapeValue(System.ReadOnlySpan`1<Char>, Int32)
M14_L06:
       or        dword ptr [rbx+28],80000000
       mov       byte ptr [rbx+3A],7
       jmp       short M14_L08
M14_L07:
       mov       rcx,rbx
       call      qword ptr [7FF824617A38]
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
       je        short M14_L14
       cmp       byte ptr [rcx+8E],1
       je        short M14_L14
       cmp       dword ptr [rcx+40],0
       jne       near ptr M14_L17
       mov       r8,[rcx+68]
M14_L11:
       cmp       byte ptr [rsi+12],0
       jne       near ptr M14_L29
       cmp       qword ptr [r8+0A0],0
       jne       near ptr M14_L29
       xor       r13d,r13d
M14_L12:
       test      r15d,r15d
       jne       short M14_L13
       cmp       dword ptr [r14+8C],0
       jne       near ptr M14_L30
M14_L13:
       mov       rcx,[rbp+30]
       test      r13,r13
       jne       near ptr M14_L31
M14_L14:
       call      qword ptr [7FF824617450]; System.Text.Json.WriteStack.Push()
       mov       r8,[rdi]
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SmallObjectWithParameterizedConstructorConverter<DotNetTips.Spargine.Tester.Models.RefTypes.Address, System.String, System.Object, System.Object, System.Object>
       cmp       [rsi],rcx
       je        short M14_L19
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       mov       r15d,eax
M14_L15:
       mov       rcx,[rbp+30]
       mov       edx,r15d
       call      qword ptr [7FF824617888]; System.Text.Json.WriteStack.Pop(Boolean)
       test      r15d,r15d
       je        short M14_L16
       mov       rcx,[rbp+30]
       cmp       byte ptr [rcx+8F],0
       jne       near ptr M14_L32
M14_L16:
       mov       eax,r15d
       jmp       near ptr M14_L34
M14_L17:
       mov       rax,[rcx+60]
       mov       r13,[rax+88]
       cmp       byte ptr [r13+119],2
       jne       near ptr M14_L28
M14_L18:
       mov       r8,r13
       mov       rcx,[rbp+30]
       jmp       near ptr M14_L11
M14_L19:
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FF8244CDD00]; System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[[System.__Canon, System.Private.CoreLib]].OnTryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       mov       r15d,eax
       jmp       short M14_L15
M14_L20:
       mov       ecx,[r14+88]
       call      qword ptr [7FF824617A08]
       int       3
M14_L21:
       mov       rcx,rbx
       call      qword ptr [7FF824617A38]
       jmp       near ptr M14_L09
M14_L22:
       cmp       byte ptr [rsi+1A],0
       je        near ptr M14_L01
       mov       rdi,[rdi]
       add       rcx,90
       call      qword ptr [7FF824525C98]; System.Nullable`1[[System.Text.Json.Serialization.JsonNumberHandling, System.Text.Json]].get_Value()
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
       call      qword ptr [7FF82478E0B8]
       int       3
M14_L24:
       mov       rcx,rbx
       call      qword ptr [7FF82478E0D0]
       test      eax,eax
       jne       near ptr M14_L04
       mov       rcx,rbx
       call      qword ptr [7FF82478E0E8]
       jmp       near ptr M14_L04
M14_L25:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FF82478E100]
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
       call      qword ptr [7FF8246179A8]
       int       3
M14_L28:
       mov       rcx,r13
       call      qword ptr [7FF8244A67D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M14_L18
M14_L29:
       mov       [rsp+20],rcx
       mov       rdx,[rdi]
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FF82478DE30]
       mov       r13,rax
       mov       rcx,[rbp+30]
       jmp       near ptr M14_L12
M14_L30:
       mov       [rsp+20],r13
       mov       [rsp+28],rcx
       mov       r8,[rdi]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FF82478DE48]
       test      eax,eax
       je        near ptr M14_L13
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
       je        near ptr M14_L16
       cmp       byte ptr [rcx+8F],0
       je        near ptr M14_L16
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
       jmp       near ptr M14_L16
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
       call      qword ptr [7FF82478FC30]
M14_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.InvalidOperationException
       call      qword ptr [7FF823F06850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M14_L37
       mov       rdx,rbx
       mov       rcx,offset MT_System.Text.Json.JsonException
       call      qword ptr [7FF823F06850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M14_L36
       mov       rcx,rsi
       call      qword ptr [7FF82478FC48]
       test      rax,rax
       jne       near ptr M14_L39
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FF82478FC60]
       jmp       near ptr M14_L39
M14_L36:
       mov       rdx,rbx
       mov       rcx,offset MT_System.NotSupportedException
       call      qword ptr [7FF823F06850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M14_L39
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,230E91FEF70
       cmp       [rcx],ecx
       call      qword ptr [7FF82478FC90]
       test      eax,eax
       jne       short M14_L39
       jmp       short M14_L38
M14_L37:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       rdx,230E91FEF20
       call      qword ptr [7FF824124F00]; System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M14_L39
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FF82478FC78]
       jmp       short M14_L39
M14_L38:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FF82478FCA8]
M14_L39:
       call      CORINFO_HELP_RETHROW
       int       3
; Total bytes of code 1299
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
       call      qword ptr [7FF82478FE40]
       int       3
M15_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M15_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF8247F56C0]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF82478FE70]
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
       call      qword ptr [7FF82478FE88]
M15_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M15_L02
M15_L06:
       mov       r11,7FF823E50D20
       call      qword ptr [r11]
       jmp       near ptr M15_L01
; Total bytes of code 232
```
```assembly
; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF95510D580]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF95510B548]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       call      qword ptr [7FF955108CC8]
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF95510D4E8]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M17_L00:
       mov       rax,[rbp-20]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FF955108CC8]
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FF95510A210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95510D570]
       mov       [rbp-20],rsi
       lea       rax,[M17_L00]
       add       rsp,28
       ret
; Total bytes of code 138
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
       je        near ptr M18_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       near ptr M18_L07
M18_L00:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+0B8]
       mov       rbx,[rax+8]
       test      rbx,rbx
       je        near ptr M18_L08
M18_L01:
       mov       [rbp-18],rbx
       xor       edx,edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       mov       rcx,rbx
       call      qword ptr [7FF95510A180]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M18_L04
       mov       rax,[rcx+0F0]
       test      rax,rax
       jne       short M18_L03
M18_L02:
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF95510DEF0]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M18_L04
M18_L03:
       mov       rcx,rax
       call      qword ptr [7FF95510A218]
       jmp       short M18_L02
M18_L04:
       cmp       byte ptr [rbp-10],0
       je        short M18_L05
       mov       rcx,rbx
       call      qword ptr [7FF95510A188]
M18_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
M18_L06:
       call      qword ptr [7FF95510BE50]
       int       3
M18_L07:
       mov       rcx,rax
       call      qword ptr [7FF95510A218]
       jmp       near ptr M18_L00
M18_L08:
       mov       rcx,rax
       call      qword ptr [7FF95510D528]; Precode of System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M18_L01
       sub       rsp,28
       call      qword ptr [7FF95510A210]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      qword ptr [7FF955107258]; CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-10],0
       je        short M18_L09
       mov       rcx,[rbp-18]
       call      qword ptr [7FF95510A188]
M18_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 310
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
       jle       near ptr M19_L05
       mov       rcx,[rcx+240]
       mov       rax,[rcx+48]
       test      rax,rax
       je        near ptr M19_L05
M19_L00:
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
       mov       rcx,230E91F62A0
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M19_L04
       mov       esi,[rbx+8]
       test      esi,esi
       je        near ptr M19_L04
       mov       rcx,1F054401DE0
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
       jle       near ptr M19_L06
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        near ptr M19_L06
M19_L01:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M19_L07
M19_L02:
       xor       r15d,r15d
       mov       r13d,1
       mov       ecx,[rax+8]
       cmp       ecx,r14d
       jbe       short M19_L03
       mov       r15d,1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       esi,ecx
       jne       near ptr M19_L08
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
       jne       near ptr M19_L09
M19_L03:
       mov       rcx,1F054400C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       jne       near ptr M19_L21
M19_L04:
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
M19_L05:
       mov       ecx,9
       call      qword ptr [7FF82478EE80]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M19_L00
M19_L06:
       mov       ecx,0A
       call      qword ptr [7FF82478EE80]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M19_L01
M19_L07:
       mov       rcx,rbp
       call      qword ptr [7FF824617DC8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M19_L02
M19_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF82478EF70]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF824326070]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M19_L09:
       mov       rcx,[rbp+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M19_L24
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M19_L10
       mov       rcx,rbp
       mov       edx,r14d
       call      qword ptr [7FF82478EF88]
M19_L10:
       mov       r13,[rax+8]
       call      qword ptr [7FF8246A7540]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M19_L17
M19_L11:
       cmp       eax,[r13+8]
       jae       near ptr M19_L24
       mov       [rsp+4C],eax
       mov       ecx,eax
       mov       r8,[r13+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rsp+44],r10d
       mov       rcx,r8
       call      qword ptr [7FF8244AD890]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+40],r8d
       cmp       [rcx+8],r8d
       jbe       short M19_L13
       test      r8d,r8d
       jne       short M19_L14
       xor       edx,edx
       mov       [rax+14],edx
M19_L12:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+40]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+44],1
M19_L13:
       mov       rcx,rax
       call      qword ptr [7FF823F06820]
       cmp       dword ptr [rsp+44],0
       je        short M19_L15
       jmp       short M19_L18
M19_L14:
       jmp       short M19_L12
M19_L15:
       mov       eax,[rsp+4C]
       inc       eax
       mov       ecx,eax
       cmp       [r13+8],ecx
       jne       short M19_L16
       xor       ecx,ecx
M19_L16:
       mov       edx,[rsp+48]
       inc       edx
       mov       eax,ecx
M19_L17:
       mov       [rsp+48],edx
       cmp       [r13+8],edx
       jg        near ptr M19_L11
       jmp       short M19_L19
M19_L18:
       mov       r13d,1
       jmp       short M19_L20
M19_L19:
       xor       r13d,r13d
M19_L20:
       jmp       near ptr M19_L03
M19_L21:
       mov       rcx,rbx
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+54],eax
       mov       [rsp+50],esi
       mov       rcx,rbp
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rsp+54]
       mov       r9d,[rsp+50]
       mov       edx,3
       call      qword ptr [7FF82478EFA0]
       test      r13d,r15d
       jne       near ptr M19_L04
       mov       rcx,rbx
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rbp
       call      qword ptr [7FF8243BCC78]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r15d,r15d
       jne       short M19_L22
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M19_L23
M19_L22:
       mov       ecx,r14d
       xor       edx,edx
M19_L23:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,ebx
       mov       r8d,esi
       call      qword ptr [7FF82478EFB8]
       jmp       near ptr M19_L04
M19_L24:
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
       je        near ptr M21_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M21_L01
       test      rsi,rsi
       je        short M21_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M21_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M21_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF883B94CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF823F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF823F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M21_L00:
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
M21_L01:
       test      rsi,rsi
       je        short M21_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M21_L03
M21_L02:
       mov       rax,230E91F0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M21_L03:
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
M21_L04:
       call      qword ptr [7FF8248958A8]
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
       call      qword ptr [7FF9551074E0]
       cmp       byte ptr [rax],0
       je        near ptr M22_L03
       call      qword ptr [7FF95510DBE0]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M22_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
M22_L00:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M22_L01:
       call      qword ptr [7FF955109688]
       mov       rdi,rax
       test      rdi,rdi
       je        short M22_L00
       call      qword ptr [7FF9551074D8]
       cmp       byte ptr [rax],0
       je        short M22_L00
       xorps     xmm0,xmm0
       movups    [rsp+30],xmm0
       mov       [rsp+30],rdi
       mov       [rsp+38],rsi
       lea       rcx,[rsp+20]
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       lea       r8,[rsp+30]
       mov       r9d,2
       call      qword ptr [7FF95510F2E0]
       lea       rcx,[rsp+20]
       call      qword ptr [7FF95510DC10]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FF955107278]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M22_L00
       cmp       [rsi+10],rbx
       je        short M22_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+9F],0
       jne       short M22_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF95510D4D8]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M22_L00
M22_L02:
       mov       rcx,[rsi+8]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M22_L00
M22_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M22_L04
       call      qword ptr [7FF9551096A0]
       test      rax,rax
       je        near ptr M22_L00
M22_L04:
       call      qword ptr [7FF95510BE58]
       int       3
; Total bytes of code 284
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       [rsp+68],r9d
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       xor       ebp,ebp
       cmp       byte ptr [rbx+9E],0
       jne       short M23_L01
       cmp       byte ptr [rsp+70],0
       je        short M23_L00
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF95510D4E8]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbp,rax
M23_L00:
       test      rbp,rbp
       jne       short M23_L06
       cmp       byte ptr [rsp+69],0
       je        short M23_L06
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FF95510C050]
       int       3
M23_L01:
       mov       rbp,[rbx+8]
       test      rbp,rbp
       je        short M23_L07
M23_L02:
       cmp       [rbp],bpl
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FF95510D548]; Precode of System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       mov       r14,rax
       cmp       byte ptr [rsp+78],0
       jne       short M23_L08
M23_L03:
       mov       rcx,[r14+10]
       test      rcx,rcx
       jne       short M23_L09
M23_L04:
       mov       rbp,[r14+8]
M23_L05:
       test      dil,dil
       je        short M23_L00
       test      rbp,rbp
       je        short M23_L00
       cmp       byte ptr [rbp+119],2
       je        short M23_L00
       jmp       short M23_L11
M23_L06:
       mov       rax,rbp
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M23_L07:
       mov       rcx,rbx
       call      qword ptr [7FF95510D528]; Precode of System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbp,rax
       jmp       short M23_L02
M23_L08:
       cmp       byte ptr [r14+20],0
       je        short M23_L10
       jmp       short M23_L03
M23_L09:
       call      qword ptr [7FF95510A218]
       jmp       short M23_L04
M23_L10:
       mov       rcx,rbp
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FF95510D558]
       mov       rbp,rax
       jmp       short M23_L05
M23_L11:
       mov       rcx,rbp
       call      qword ptr [7FF95510DF90]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M23_L00
; Total bytes of code 231
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M24_L01
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M24_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M24_L01
M24_L00:
       test      rax,rax
       je        short M24_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M24_L01
       test      rax,rax
       je        short M24_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M24_L01
       test      rax,rax
       je        short M24_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M24_L01
       test      rax,rax
       je        short M24_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M24_L00
M24_L01:
       mov       rax,rdx
       ret
M24_L02:
       jmp       qword ptr [7FF8248946F0]
; Total bytes of code 88
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF883980CF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M25_L01
       cmp       [rax],ecx
       jle       short M25_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M25_L03
M25_L00:
       add       rsp,20
       pop       rbx
       ret
M25_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M25_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M25_L00
M25_L02:
       cmp       [rax+4],edx
       jle       short M25_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M25_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M25_L03
       jmp       short M25_L00
M25_L03:
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
       jne       short M26_L00
       ret
M26_L00:
       jmp       qword ptr [7FF823F05C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.4 (10.0.4, 10.0.426.12010), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rcx+30]
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
       mov       rax,27DAEC00110
       mov       r15,[rax]
       test      r15,r15
       jne       short M00_L01
       mov       rax,27DAEC000F0
       mov       r15,[rax]
       test      r15,r15
       je        near ptr M00_L16
M00_L01:
       mov       rcx,27DAEC00C58
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2BE43E21518
       mov       [rdi+10],rcx
       lea       rcx,[rdi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+30],1
       mov       [rbp-48],rdi
       mov       rcx,27DAEC01FB8
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
       mov       rdx,2BE43E315E8
       xor       r8d,r8d
       call      qword ptr [7FF8246C5C98]; System.Xml.XmlEncodedRawTextWriter.ValidateContentChars(System.String, System.String, Boolean)
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
       mov       rax,[7FF824421668]
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
       call      qword ptr [7FF8246BDAC8]; System.Xml.XmlEncodedRawTextWriter.WriteXmlDeclaration(System.Xml.XmlStandalone)
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
       mov       rcx,27DAEC01FE0
       mov       rdx,[rcx]
       jmp       short M00_L07
M00_L06:
       mov       rdx,27DAEC01FE8
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
       mov       r11,2BE43E317A0
       mov       [rcx],r11
       mov       r11,2BE43E317C0
       mov       [rcx+8],r11
       mov       dword ptr [rcx+10],3
       mov       dword ptr [rcx+14],0FFFFFFFF
       mov       rcx,r14
       cmp       r15d,1
       jbe       near ptr M00_L11
       add       rcx,28
       mov       r11,2BE43E31720
       mov       [rcx],r11
       mov       r11,2BE43E31740
       mov       [rcx+8],r11
       mov       dword ptr [rcx+10],3
       mov       dword ptr [rcx+14],0FFFFFFFF
       cmp       qword ptr [r13+20],0
       je        short M00_L08
       mov       rcx,[r13+20]
       mov       r11,7FF823E51278
       mov       r12,2BE43E20008
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
       mov       r12,2BE43E20008
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
       call      qword ptr [7FF823F0C9A8]; System.Object.GetType()
       mov       rdx,rax
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FF8246C5ED8]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],rcx
       mov       rcx,r14
       mov       rdx,r13
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF82473D290]; System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       mov       rcx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8240F2100]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       ecx,[r13+78]
       cmp       ecx,10
       jg        short M00_L10
       mov       rax,27DAEC01FD8
       mov       rax,[rax]
       cmp       ecx,11
       jae       short M00_L11
       mov       ecx,[rax+rcx*4+10]
       cmp       ecx,5
       je        short M00_L12
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF8246BF1E8]; System.Xml.XmlWellFormedWriter.Close()
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
       mov       rdx,7FF8247DE268
       cmp       [rcx],ecx
       call      qword ptr [7FF8247A73A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF82452E5F8]
       mov       ecx,1C4D
       mov       rdx,7FF824274870
       call      qword ptr [7FF824127798]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FF824274870
       call      qword ptr [7FF824127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF823F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FF824274870
       call      qword ptr [7FF824127798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF823F07840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8248BFC60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8248B46C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L15:
       mov       ecx,2
       call      qword ptr [7FF8248B42E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L16:
       call      qword ptr [7FF824125E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L17:
       mov       rcx,rdi
       call      00007FF883B4C160
       jmp       near ptr M00_L13
       sub       rsp,38
       mov       rcx,[rbp-50]
       mov       eax,[rcx+78]
       cmp       eax,10
       jg        short M00_L18
       mov       rdx,27DAEC01FD8
       mov       rdi,[rdx]
       cmp       eax,11
       jae       short M00_L20
       mov       esi,[rdi+rax*4+10]
       cmp       esi,5
       je        short M00_L19
M00_L18:
       call      qword ptr [7FF8246BF1E8]; System.Xml.XmlWellFormedWriter.Close()
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
       call      00007FF883B4C160
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
       mov       rdx,7FF87FA3BB80
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
       mov       rdx,27DC4C007E8
       mov       rcx,[rdx]
       test      rcx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FF82412C228]
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
       call      qword ptr [7FF8248BE3B8]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF8248BDEA8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF824324180]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L07:
       cmp       eax,26
       je        short M01_L12
M01_L08:
       call      qword ptr [7FF8248BFD20]
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
       call      qword ptr [7FF8248BFD38]
       test      eax,eax
       je        short M01_L13
       inc       edi
       jmp       near ptr M01_L01
M01_L11:
       mov       ecx,edi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       call      qword ptr [7FF8248BFD38]
       test      eax,eax
       je        near ptr M01_L01
       jmp       short M01_L14
M01_L12:
       mov       rcx,2BE43E31618
       call      qword ptr [7FF8248BE3D0]
       mov       rbp,rax
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF8248BFD50]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF8248BE400]
       mov       rbp,rax
       jmp       short M01_L15
M01_L13:
       mov       rcx,2BE43E316A8
       call      qword ptr [7FF8248BE3D0]
       mov       rbp,rax
       jmp       short M01_L15
M01_L14:
       mov       rcx,2BE43E31658
       call      qword ptr [7FF8248BE3D0]
       mov       rbp,rax
       mov       r8d,edi
       movzx     ecx,word ptr [rbx+r8*2+0C]
       mov       r8,27DAEC00100
       mov       r8,[r8]
       mov       rdx,2BE43E31708
       call      qword ptr [7FF82412F108]; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF8248BDEA8]
       mov       rbp,rax
M01_L15:
       call      qword ptr [7FF8248BE418]
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
       call      qword ptr [7FF8248BE400]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF824324180]
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
       mov       rdi,2BE43E39E74
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
       mov       rdi,2BE43E39EAC
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
       mov       rdi,2BE43E39ECC
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
       call      qword ptr [7FF82473D5C0]; System.Text.EncodingTable.GetCodePageDataItem(Int32)
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
       mov       rdx,2BE43E39F34
       lea       r8,[rdx+6]
       mov       rcx,rbx
       call      qword ptr [7FF82473D578]; System.Xml.XmlEncodedRawTextWriter.RawText(Char*, Char*)
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
       call      qword ptr [7FF8248BFBD0]
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
       call      qword ptr [7FF8248BFBA0]
       test      eax,eax
       je        short M02_L32
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,r15
       call      qword ptr [7FF8248BDD70]
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
       call      qword ptr [7FF8248BFBB8]
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
       call      qword ptr [7FF8248BFBA0]
       test      eax,eax
       je        short M02_L40
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,r15
       call      qword ptr [7FF8248BDD70]
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
       call      qword ptr [7FF8248BFBB8]
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
       call      qword ptr [7FF8248BFBA0]
       test      eax,eax
       je        short M02_L48
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,r15
       call      qword ptr [7FF8248BDD70]
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
       call      qword ptr [7FF8248BFBB8]
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
       call      qword ptr [7FF8248BE880]
       mov       rsi,rax
       mov       ecx,[rdi+20]
       mov       [rbx+8],ecx
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8246C6F10]; System.SR.Format(System.String, System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF8241277B0]
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
       call      qword ptr [7FF8248BFBA0]
       test      eax,eax
       je        short M02_L59
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,r15
       call      qword ptr [7FF8248BDD70]
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
       call      qword ptr [7FF8248BFBB8]
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
       mov       rdx,2BE43E39EF0
       call      qword ptr [7FF82473D878]; System.Xml.XmlEncodedRawTextWriter.RawText(System.String)
       mov       rdx,2BE43E39E48
       mov       rcx,2BE43E39E28
       cmp       esi,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       call      qword ptr [7FF82473D878]; System.Xml.XmlEncodedRawTextWriter.RawText(System.String)
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
       call      qword ptr [7FF823F05C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        near ptr M04_L18
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M04_L19
M04_L00:
       mov       rcx,27DAEC01FF0
       mov       r14,[rcx]
       mov       r15,[r14+8]
       mov       r13d,[r15+8]
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
       mov       r11,7FF823E515C8
       call      qword ptr [r11]
M04_L02:
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
M04_L03:
       xor       ecx,ecx
       mov       [rbp-58],ecx
       mov       ecx,eax
       lea       r10,[rcx+rcx*2]
       mov       [rbp-80],r10
M04_L04:
       mov       ecx,[r14+38]
       mov       [rbp-50],eax
       cmp       eax,[r15+8]
       jae       near ptr M04_L36
       lea       rdx,[r15+r10*8+10]
       mov       r9,[rdx]
       mov       r11,[rdx+8]
       mov       [rbp-98],r11
       mov       edx,[rdx+10]
       mov       [rbp-74],edx
       cmp       byte ptr [r14+3C],0
       jne       near ptr M04_L20
       cmp       ecx,[r14+38]
       jne       near ptr M04_L20
       test      r9,r9
       je        short M04_L06
       mov       ecx,edx
       and       ecx,7FFFFFFF
       movsxd    rcx,ecx
       mov       r10d,r12d
       cmp       rcx,r10
       je        near ptr M04_L16
M04_L05:
       mov       eax,[rbp-50]
       mov       ecx,r13d
       add       rax,rcx
       mov       ecx,[r15+8]
       cqo
       idiv      rcx
       mov       eax,edx
       mov       ecx,eax
       cmp       dword ptr [rbp-74],0
       jl        near ptr M04_L24
M04_L06:
       xor       edx,edx
M04_L07:
       mov       r14,rdx
       test      r14,r14
       je        short M04_L08
       mov       rcx,offset MT_System.Xml.Serialization.TypeDesc
       cmp       [r14],rcx
       jne       near ptr M04_L25
M04_L08:
       test      r14,r14
       jne       near ptr M04_L26
M04_L09:
       xor       r14d,r14d
M04_L10:
       lea       rcx,[rbx+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+18],0
       jne       near ptr M04_L27
       cmp       dword ptr [7FF823E4B150],1
       je        near ptr M04_L15
       mov       rcx,27DC4C00058
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
       mov       r11,7FF823E515D8
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
       jae       near ptr M04_L36
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       edx,[rdx]
       mov       r13,[r13+10]
       xor       r10d,r10d
       mov       [rbp-70],r10d
       dec       edx
       cmp       [r13+8],edx
       jbe       near ptr M04_L30
M04_L11:
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       r9,[r13+rdx*8+10]
       mov       [rbp-90],r9
       cmp       [r9+10],eax
       jne       near ptr M04_L29
       mov       rdx,[r9]
       mov       rcx,r12
       mov       r8,r15
       mov       r11,7FF823E515E0
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-90]
       je        near ptr M04_L29
       add       r9,8
M04_L12:
       test      r9,r9
       je        near ptr M04_L31
       mov       rcx,[r9]
       mov       [rbp-60],rcx
M04_L13:
       mov       rdx,[rbp-60]
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rbx+8],0
       je        near ptr M04_L32
M04_L14:
       cmp       qword ptr [rbx+18],0
       jne       short M04_L15
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF8247A7390]; System.Xml.Serialization.XmlReflectionImporter.GetTopLevelMapping(System.Type, System.String)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M04_L15:
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
M04_L16:
       cmp       [r14+8],r9
       je        near ptr M04_L05
       cmp       r9,rsi
       jne       short M04_L21
M04_L17:
       mov       r11,[rbp-98]
       mov       rdx,r11
       jmp       near ptr M04_L07
M04_L18:
       mov       ecx,0EBC1
       mov       rdx,7FF82462C1F0
       call      qword ptr [7FF824127798]
       mov       rcx,rax
       call      qword ptr [7FF8247AFAC8]
       int       3
M04_L19:
       mov       rcx,rdi
       mov       rdx,2BE43E20008
       call      qword ptr [7FF823F0C828]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       near ptr M04_L00
       jmp       near ptr M04_L09
M04_L20:
       lea       rcx,[rbp-58]
       mov       edx,14
       call      qword ptr [7FF8248BDFE0]
       mov       eax,[rbp-50]
       mov       r10,[rbp-80]
       jmp       near ptr M04_L04
M04_L21:
       cmp       qword ptr [r14+20],0
       je        short M04_L22
       mov       rcx,[r14+20]
       mov       r8,rsi
       mov       rdx,r9
       mov       r11,7FF823E515D0
       call      qword ptr [r11]
       jmp       short M04_L23
M04_L22:
       mov       rcx,r9
       mov       rdx,rsi
       mov       r10,[r9]
       mov       r10,[r10+40]
       call      qword ptr [r10+10]
M04_L23:
       test      eax,eax
       je        near ptr M04_L05
       jmp       near ptr M04_L17
M04_L24:
       mov       r8d,[rbp-4C]
       inc       r8d
       cmp       [r15+8],r8d
       mov       [rbp-4C],r8d
       mov       eax,ecx
       jg        near ptr M04_L03
       jmp       near ptr M04_L06
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
       call      qword ptr [7FF8248BE448]
       mov       rcx,rsi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF8246CF1B0]; System.Xml.Serialization.XmlMapping.GenerateKey(System.Type, System.Xml.Serialization.XmlRootAttribute, System.String)
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L10
M04_L27:
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L15
M04_L28:
       cmp       [r13+8],edx
       mov       [rbp-70],r10d
       mov       eax,[rbp-6C]
       jbe       short M04_L30
       jmp       near ptr M04_L11
M04_L29:
       mov       edx,[r9+14]
       mov       r10d,[rbp-70]
       inc       r10d
       cmp       [r13+8],r10d
       jae       short M04_L28
       call      qword ptr [7FF824127A08]
       int       3
M04_L30:
       xor       r9d,r9d
       jmp       near ptr M04_L12
M04_L31:
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
       call      qword ptr [7FF8246C6748]; System.Runtime.CompilerServices.ConditionalWeakTable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M04_L13
       lea       r8,[rbp-60]
       mov       rcx,[rbp-68]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF823F4AC10]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       jmp       near ptr M04_L13
M04_L32:
       mov       rdx,27DC4C00058
       mov       rcx,[rdx]
       mov       [rbp-88],rcx
       xor       edx,edx
       mov       [rbp-40],edx
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-88]
       call      qword ptr [7FF823F05998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,27DC4C00058
       mov       rcx,[rcx]
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FF8246C6730]; System.Xml.Serialization.TempAssemblyCache.get_Item(System.String, System.Type)
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
       call      qword ptr [7FF8246C6760]; System.Xml.Serialization.TempAssembly.LoadGeneratedAssembly(System.Type, System.String, System.Xml.Serialization.XmlSerializerImplementation ByRef)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M04_L34
       cmp       dword ptr [7FF823E4B150],3
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
       call      qword ptr [7FF8246C69A0]; System.Xml.Serialization.Compiler.GetTempAssemblyName(System.Reflection.AssemblyName, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.IO.FileLoadException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF8248BE478]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF8248BDEA8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF8248BE490]
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
       call      qword ptr [7FF8246C6FB8]; System.Xml.Serialization.XmlReflectionImporter..ctor(System.Xml.Serialization.XmlAttributeOverrides, System.String)
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9,rdi
       xor       r8d,r8d
       call      qword ptr [7FF8246C7018]; System.Xml.Serialization.XmlReflectionImporter.ImportTypeMapping(System.Type, System.Xml.Serialization.XmlRootAttribute, System.String)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+18]
       mov       rdx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FF8246CF3A8]; System.Xml.Serialization.XmlSerializer.GenerateTempAssembly(System.Xml.Serialization.XmlMapping, System.Type, System.String, System.String)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M04_L35
M04_L34:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF8247A7390]; System.Xml.Serialization.XmlReflectionImporter.GetTopLevelMapping(System.Type, System.String)
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
       call      qword ptr [7FF8248BE4A8]
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M04_L35:
       mov       r9,[rbx+8]
       mov       rcx,27DC4C00058
       mov       rcx,[rcx]
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FF82473D128]; System.Xml.Serialization.TempAssemblyCache.Add(System.String, System.Type, System.Xml.Serialization.TempAssembly)
       nop
       cmp       byte ptr [rbp-40],0
       je        near ptr M04_L14
       mov       rcx,[rbp-88]
       call      qword ptr [7FF823F06820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M04_L14
M04_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-40],0
       je        short M04_L37
       mov       rcx,[rbp-88]
       call      qword ptr [7FF823F06820]; System.Threading.Monitor.Exit(System.Object)
M04_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1745
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
       cmp       dword ptr [7FF823E4B150],1
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
       call      qword ptr [7FF82473D2C0]; System.Xml.Serialization.XmlSerializer.get_DefaultNamespaces()
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
       call      qword ptr [7FF82473D368]; System.Xml.Serialization.TempAssembly.InvokeWriter(System.Xml.Serialization.XmlMapping, System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
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
       call      qword ptr [7FF8248BFE40]
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
       call      qword ptr [7FF8248BE760]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF8248BDEA8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF824325FC8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L05:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,r14
       mov       r9,rdi
       call      qword ptr [7FF8248BE778]
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
       call      qword ptr [7FF8248BFE58]
       test      eax,eax
       je        short M05_L07
       mov       r8,rdi
       jmp       short M05_L08
M05_L07:
       call      qword ptr [7FF82473D2C0]; System.Xml.Serialization.XmlSerializer.get_DefaultNamespaces()
       mov       r8,rax
M05_L08:
       mov       r12,[rbp+38]
       mov       [rsp+20],r12
       mov       rcx,r15
       mov       rdx,rsi
       mov       r9,[rbp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF8248BFE70]
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,r15
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M05_L10
M05_L09:
       mov       rcx,rdi
       call      qword ptr [7FF8248BFE58]
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
       jmp       qword ptr [7FF8246BF1F0]; System.Xml.XmlWellFormedWriter.Flush()
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
       call      qword ptr [7FF8248BE7D8]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FF8243B5DE8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L13:
       mov       rax,offset MT_System.Reflection.TargetInvocationException
       cmp       [rbx],rax
       jne       short M05_L12
       call      qword ptr [7FF824124ED0]
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
       call      00007FF883B94CB0
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
       call      qword ptr [7FF823F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2BE43E20008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF823E44000
       call      qword ptr [7FF824127798]
       mov       rbx,rax
       call      qword ptr [7FF8248B4018]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF82412D8D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Xml.XmlWellFormedWriter.Close()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0B0]
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
       call      qword ptr [7FF8246BDB80]; System.Xml.XmlEncodedRawTextWriter.FlushBuffer()
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
       call      qword ptr [7FF8246BF158]; System.Xml.XmlWellFormedWriter.WriteEndElement()
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
       call      qword ptr [7FF82473D548]; System.Xml.XmlWellFormedWriter.AdvanceState(Token)
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
       lea       rdx,[rbp-20]
       mov       [rsp+40],rdx
       lea       rdx,[rbp-28]
       mov       [rsp+48],rdx
       lea       rdx,[rbp-30]
       mov       [rsp+50],rdx
       mov       rdx,[rbx+38]
       mov       r8d,1
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       cmp       dword ptr [rbp-28],0
       je        near ptr M07_L03
       mov       rcx,[rbx+28]
       mov       rdx,[rbx+20]
       mov       r9d,[rbp-28]
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
       call      M07_L31
       nop
M07_L12:
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
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
       mov       rax,[rbp-50]
       mov       [rax+28],rcx
       add       rsp,58
       ret
M07_L14:
       sub       rsp,58
       mov       rcx,[rbp-50]
       cmp       byte ptr [rcx+9A],0
       je        near ptr M07_L20
       mov       rbx,[rcx+28]
       mov       rsi,[rbx]
       mov       rdx,offset MT_System.IO.FileStream
       cmp       rsi,rdx
       jne       near ptr M07_L19
       mov       rdi,[rbx+10]
       test      rdi,rdi
       je        short M07_L16
       mov       rdx,offset MT_System.IO.Strategies.SyncWindowsFileStreamStrategy
       cmp       [rdi],rdx
       jne       short M07_L17
       mov       rax,[rdi+18]
       test      rax,rax
       je        short M07_L16
       test      byte ptr [rax+10],1
       jne       short M07_L16
       mov       rax,[rdi+18]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M07_L15
       mov       rcx,rax
       call      qword ptr [7FF8249A3338]
M07_L15:
       mov       rdi,[rdi+18]
       cmp       [rdi],dil
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FF823F0C768]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,rdi
       call      qword ptr [7FF823F07AE0]; System.GC.SuppressFinalize(System.Object)
M07_L16:
       test      dword ptr [rsi],100000
       je        short M07_L20
       jmp       short M07_L18
M07_L17:
       mov       rcx,rdi
       mov       edx,1
       mov       rax,[rdi]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       jmp       short M07_L16
M07_L18:
       mov       rcx,rbx
       call      00007FF883B4C160
       jmp       short M07_L20
M07_L19:
       mov       rcx,rbx
       mov       rax,[rsi+50]
       call      qword ptr [rax+18]
       nop
M07_L20:
       mov       rcx,[rbp-50]
       call      M07_L13
       nop
       add       rsp,58
       ret
M07_L21:
       sub       rsp,58
       xor       ecx,ecx
       mov       rdx,[rbp-50]
       mov       [rdx+48],rcx
       add       rsp,58
       ret
M07_L22:
       sub       rsp,58
       mov       rcx,[rbp-50]
       cmp       byte ptr [rcx+9A],0
       je        short M07_L25
       mov       rbx,[rcx+48]
       mov       rdx,offset MT_System.IO.StringWriter
       cmp       [rbx],rdx
       jne       short M07_L23
       mov       byte ptr [rbx+30],0
       jmp       short M07_L24
M07_L23:
       mov       rcx,rbx
       mov       edx,1
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M07_L24:
       mov       rcx,rbx
       call      qword ptr [7FF823F07AE0]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,[rbp-50]
M07_L25:
       call      M07_L21
       nop
       add       rsp,58
       ret
M07_L26:
       sub       rsp,58
       mov       rcx,[rbp-50]
       mov       byte ptr [rcx+95],1
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M07_L27
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       nop
       call      M07_L14
       jmp       short M07_L29
M07_L27:
       mov       rcx,[rbp-50]
       cmp       qword ptr [rcx+48],0
       je        short M07_L29
       mov       rax,[rcx+48]
       mov       rdx,offset MT_System.IO.StringWriter
       cmp       [rax],rdx
       je        short M07_L28
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
M07_L28:
       nop
       call      M07_L22
       nop
M07_L29:
       add       rsp,58
       ret
M07_L30:
       sub       rsp,58
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+78],0F
       add       rsp,58
       ret
M07_L31:
       sub       rsp,58
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M07_L37
       mov       edx,[rcx+78]
       cmp       edx,10
       jg        short M07_L32
       mov       r8,27DAEC01FD8
       mov       r8,[r8]
       cmp       edx,11
       jae       near ptr M07_L36
       mov       edx,[r8+rdx*4+10]
       jmp       short M07_L33
M07_L32:
       mov       edx,6
M07_L33:
       mov       r8,offset MT_System.Xml.XmlEncodedRawTextWriter
       cmp       [rax],r8
       jne       near ptr M07_L35
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FF8246BDB80]; System.Xml.XmlEncodedRawTextWriter.FlushBuffer()
       mov       rcx,[rbp-50]
       cmp       qword ptr [rcx+28],0
       je        near ptr M07_L34
       mov       rax,[rcx+40]
       mov       rdx,[rcx+20]
       mov       [rsp+20],rdx
       xor       edx,edx
       mov       [rsp+28],edx
       mov       rdx,[rcx+20]
       mov       edx,[rdx+8]
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       lea       rdx,[rbp-38]
       mov       [rsp+40],rdx
       lea       rdx,[rbp-40]
       mov       [rsp+48],rdx
       lea       rdx,[rbp-48]
       mov       [rsp+50],rdx
       mov       rcx,rax
       mov       r10,[rbp-50]
       mov       rdx,[r10+38]
       mov       r8d,1
       xor       r9d,r9d
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       cmp       dword ptr [rbp-40],0
       je        short M07_L34
       mov       r10,[rbp-50]
       mov       rcx,[r10+28]
       mov       rdx,[r10+20]
       mov       r9d,[rbp-40]
       xor       r8d,r8d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       nop
M07_L34:
       mov       rcx,[rbp-50]
       call      M07_L26
       jmp       short M07_L38
M07_L35:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+98]
       call      qword ptr [rax+38]
       jmp       short M07_L38
M07_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M07_L37:
       mov       rax,[rcx+10]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+20]
       nop
M07_L38:
       call      M07_L30
       nop
       add       rsp,58
       ret
; Total bytes of code 1245
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
       call      00007FF883B94CB0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF823F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF823F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2BE43E20008
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
       call      qword ptr [7FF8248B4FD8]
       int       3
; Total bytes of code 231
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF883980CF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF8839687D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF88397FA00]
       mov       rdx,rax
       test      rsi,rsi
       je        short M11_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF883980BA0]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L00:
       call      qword ptr [7FF88397E3E8]
       int       3
; Total bytes of code 61
```

