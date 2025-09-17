## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       mov       rcx,15B63C026E8
       mov       rdi,[rcx]
       mov       [rsp+48],rdi
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rcx,rdi
       call      qword ptr [7FFE77B26400]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rbp,rax
       mov       [rsp+40],rbp
       cmp       [rbp],bpl
       mov       r14,19BF8C89FF0
       mov       [rsp+38],r14
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,7FFED6E9E4E0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M00_L07
M00_L00:
       cmp       ebx,0F
       je        near ptr M00_L11
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,7FFED6E9E4E0
       call      rax
       movzx     ebx,al
       mov       r14,[rsp+38]
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M00_L08
M00_L01:
       cmp       ebx,10
       je        near ptr M00_L11
       mov       rcx,r14
       call      qword ptr [7FFE771CA398]; System.RuntimeType.get_IsByRefLike()
       test      eax,eax
       jne       near ptr M00_L11
       mov       rcx,r14
       call      qword ptr [7FFE7728C678]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L09
M00_L02:
       test      rcx,rcx
       je        near ptr M00_L10
       call      00007FFED6EA1090
       test      eax,eax
       jne       near ptr M00_L11
       mov       dword ptr [rsp+20],1
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       rcx,[rsp+40]
       mov       r14,19BF8C89FF0
       mov       rdx,r14
       mov       r8d,1
       call      qword ptr [7FFE7779C498]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FFE77B2C4C8]; System.Text.Json.JsonSerializer.ReadFromSpanAsObject(System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       mov       r8,rax
       test      r8,r8
       je        short M00_L04
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r8],rcx
       jne       near ptr M00_L13
M00_L04:
       mov       [rsp+68],r8
       mov       rbx,[rsp+0A0]
       mov       r14,[rbx+18]
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
       call      qword ptr [7FFE77D95AE8]
       int       3
M00_L06:
       mov       ecx,3888
       mov       rdx,7FFE77789C30
       call      qword ptr [7FFE775076F0]
       mov       rcx,rax
       call      qword ptr [7FFE77BB5DE8]
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
       call      qword ptr [7FFE77BB6970]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE77BB6988]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       mov       ecx,3C7C
       mov       rdx,7FFE77789C30
       call      qword ptr [7FFE775076F0]
       mov       rcx,rax
       mov       r14,19BF8C89FF0
       mov       rdx,r14
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE77D94B88]
       int       3
M00_L12:
       mov       rcx,rbx
       call      qword ptr [7FFE77876208]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
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
       call      qword ptr [7FFE777944B0]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE77ABE070]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FFE77D94B70]
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
       mov       rax,7FFED6E9E4E0
       call      rax
       movzx     ebx,al
       mov       rdi,[rsp+20]
       cmp       dword ptr [7FFED71EE808],0
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
       je        near ptr M04_L40
       mov       r8,[rcx+8]
       test      r8,r8
       je        near ptr M04_L13
M04_L00:
       mov       [rbp-50],r8
       mov       rbx,[r8+8]
       mov       rdx,15B63C01938
       mov       rsi,[rdx]
       test      rsi,rsi
       jne       short M04_L01
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE771CD050
       mov       [rsi+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [rsi+20],rcx
       mov       rcx,15B63C01938
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
M04_L01:
       mov       [rbp-58],rbx
       mov       rax,[rbp+18]
       mov       rdx,rax
       cmp       [rbx],bl
       test      rdx,rdx
       je        near ptr M04_L12
       mov       rdi,[rbx+8]
       mov       r11,[rdi+8]
       cmp       byte ptr [rbx+19],0
       jne       near ptr M04_L10
       mov       rcx,r11
       mov       r11,7FFE771D10A8
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
       jae       near ptr M04_L42
       mov       edx,edx
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M04_L16
M04_L03:
       cmp       ebx,[r15+20]
       jne       near ptr M04_L14
       mov       r13,[r15+8]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r14],rcx
       jne       near ptr M04_L15
       test      r13,r13
       je        near ptr M04_L14
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M04_L11
       mov       rax,[rbp+18]
       cmp       rax,r13
       sete      r12b
       movzx     r12d,r12b
M04_L04:
       test      r12d,r12d
       je        near ptr M04_L14
       mov       rdx,[r15+10]
       mov       [rbp-60],rdx
M04_L05:
       cmp       byte ptr [rbp+38],0
       jne       near ptr M04_L36
M04_L06:
       mov       rcx,[rbp-60]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       near ptr M04_L37
       mov       rcx,[rbp-60]
       mov       rbx,[rcx+8]
M04_L07:
       cmp       byte ptr [rbp+20],0
       je        short M04_L08
       test      rbx,rbx
       je        short M04_L08
       cmp       byte ptr [rbx+119],2
       jne       near ptr M04_L39
M04_L08:
       test      rbx,rbx
       je        near ptr M04_L41
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
       mov       rax,[rbp+18]
       mov       rcx,r13
       mov       rdx,rax
       mov       r8,[r13]
       mov       r8,[r8+40]
       call      qword ptr [r8+10]
       mov       r12d,eax
       mov       rax,[rbp+18]
       jmp       near ptr M04_L04
M04_L12:
       mov       ecx,1
       mov       rdx,7FFE7762FC38
       call      qword ptr [7FFE775076F0]
       mov       rcx,rax
       call      qword ptr [7FFE77875F80]
       int       3
M04_L13:
       call      qword ptr [7FFE7779C4B0]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       r8,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M04_L00
M04_L14:
       mov       rax,[rbp+18]
       mov       r15,[r15+18]
       test      r15,r15
       jne       near ptr M04_L03
       jmp       short M04_L16
M04_L15:
       mov       rax,[rbp+18]
       mov       rcx,r14
       mov       r8,rax
       mov       rdx,r13
       mov       r11,7FFE771D10B0
       call      qword ptr [r11]
       mov       r12d,eax
       mov       rax,[rbp+18]
       jmp       near ptr M04_L04
M04_L16:
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
       jmp       near ptr M04_L31
M04_L17:
       mov       rcx,[rbp-70]
       mov       ecx,[rcx+8]
       cmp       [rbp-3C],ecx
       jae       near ptr M04_L26
       mov       rcx,[rbp-70]
       mov       eax,[rbp-3C]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       short M04_L18
       xor       ecx,ecx
       call      qword ptr [7FFE77BB5DE8]
       int       3
M04_L18:
       mov       rcx,r14
       call      00007FFED6E20370
       test      eax,eax
       jne       short M04_L19
       mov       rcx,r14
       call      qword ptr [7FFE77BB6B38]
M04_L19:
       mov       dword ptr [rbp-48],1
       mov       rcx,[rbp-68]
       mov       rax,[rbp-58]
       cmp       rcx,[rax+8]
       je        short M04_L22
       mov       rcx,[rax+8]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       cmp       rsi,[rcx+8]
       je        near ptr M04_L30
       mov       rcx,[rbp-68]
       mov       rsi,[rcx+8]
       cmp       byte ptr [rax+19],0
       jne       short M04_L20
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r11,7FFE771D10C0
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       short M04_L21
M04_L20:
       mov       rcx,[rbp+18]
       mov       rdx,[rcx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+18]
       mov       ebx,eax
M04_L21:
       mov       rax,[rbp-58]
       jmp       near ptr M04_L30
M04_L22:
       xor       r14d,r14d
       mov       r15,[rdi]
       test      r15,r15
       je        short M04_L28
M04_L23:
       cmp       ebx,[r15+20]
       jne       short M04_L24
       mov       rdx,[r15+8]
       mov       rcx,rsi
       mov       r8,[rbp+18]
       mov       r11,7FFE771D10C8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-58]
       jne       short M04_L25
M04_L24:
       inc       r14d
       mov       r15,[r15+18]
       test      r15,r15
       jne       short M04_L23
       jmp       short M04_L28
M04_L25:
       mov       rcx,[r15+10]
       mov       [rbp-60],rcx
       jmp       near ptr M04_L33
M04_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L27:
       call      CORINFO_HELP_OVERFLOW
       int       3
M04_L28:
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
       jae       short M04_L26
       mov       ecx,[rbp-3C]
       lea       rdx,[rdx+rcx*4+10]
       mov       ecx,[rdx]
       add       ecx,1
       jo        short M04_L27
       mov       [rdx],ecx
       mov       rdx,[rbp-68]
       mov       rdx,[rdx+20]
       mov       ecx,[rdx+8]
       cmp       [rbp-3C],ecx
       jae       near ptr M04_L26
       mov       ecx,[rbp-3C]
       mov       edx,[rdx+rcx*4+10]
       mov       ecx,1
       mov       rax,[rbp-58]
       cmp       edx,[rax+10]
       cmovle    ecx,[rbp-40]
       mov       [rbp-40],ecx
       cmp       r14d,64
       jbe       short M04_L29
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FFE77286850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       ecx,1
       test      rax,rax
       cmove     ecx,[rbp-44]
       mov       [rbp-44],ecx
M04_L29:
       call      M04_L43
       jmp       near ptr M04_L34
M04_L30:
       mov       rcx,[rbp-70]
       mov       edx,[rbp-3C]
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M04_L32
       mov       rcx,r14
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M04_L31
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE77BB6940]
M04_L31:
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
       jae       near ptr M04_L42
       mov       eax,r8d
       lea       rdi,[rcx+rax*8+10]
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       [rbp-44],ecx
       mov       [rbp-48],ecx
       jmp       near ptr M04_L17
M04_L32:
       xor       ecx,ecx
       call      qword ptr [7FFE77BB5DE8]
       int       3
M04_L33:
       call      M04_L43
       jmp       near ptr M04_L05
M04_L34:
       mov       ecx,[rbp-40]
       or        ecx,[rbp-44]
       je        short M04_L35
       mov       rcx,[rbp-58]
       mov       rdx,[rbp-68]
       mov       r8d,[rbp-40]
       mov       r9d,[rbp-44]
       call      qword ptr [7FFE7797F408]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
M04_L35:
       mov       r8,[rbp-78]
       mov       [rbp-60],r8
       jmp       near ptr M04_L05
M04_L36:
       mov       rcx,[rbp-60]
       cmp       byte ptr [rcx+20],0
       je        short M04_L38
       jmp       near ptr M04_L06
M04_L37:
       call      qword ptr [7FFE77BBD638]
       int       3
M04_L38:
       mov       rcx,[rbp-50]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-60]
       call      qword ptr [7FFE77BBDBA8]
       mov       rbx,rax
       jmp       near ptr M04_L07
M04_L39:
       mov       rcx,rbx
       call      qword ptr [7FFE77876208]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M04_L08
M04_L40:
       mov       rax,[rbp+18]
       cmp       byte ptr [rbp+30],0
       je        near ptr M04_L08
       mov       rdx,rax
       call      qword ptr [7FFE7779CA50]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       jmp       near ptr M04_L08
M04_L41:
       cmp       byte ptr [rbp+29],0
       je        near ptr M04_L09
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+20]
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE77BBD650]
       int       3
M04_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L43:
       sub       rsp,28
       cmp       dword ptr [rbp-48],0
       je        short M04_L46
       mov       rcx,[rbp-70]
       mov       ecx,[rcx+8]
       cmp       [rbp-3C],ecx
       jae       short M04_L44
       mov       rcx,[rbp-70]
       mov       eax,[rbp-3C]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       short M04_L45
       xor       ecx,ecx
       call      qword ptr [7FFE77BB5DE8]
       int       3
M04_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L45:
       mov       rcx,r14
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M04_L46
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE77BB6940]
M04_L46:
       nop
       add       rsp,28
       ret
; Total bytes of code 1576
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
       mov       rax,0CC2906DA2B2B
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
       mov       rcx,15B63C01DD0
       mov       r14,[rcx]
       mov       r15,r14
       lea       r13d,[rdi+rdi*2]
       mov       rcx,15B63C00C90
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
       cmp       dword ptr [rcx+238],0B
       jle       near ptr M05_L17
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+58]
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
       call      qword ptr [7FFE777978D0]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
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
       call      qword ptr [7FFE778F4E58]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
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
       call      qword ptr [7FFE774270D8]
       int       3
M05_L08:
       mov       ecx,38A0
       mov       rdx,7FFE77789C30
       call      qword ptr [7FFE775076F0]
       mov       rcx,rax
       call      qword ptr [7FFE77BBFE70]
       int       3
M05_L09:
       mov       ecx,38A0
       mov       rdx,7FFE77789C30
       call      qword ptr [7FFE775076F0]
       mov       rcx,rax
       call      qword ptr [7FFE77BBFE88]
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
       mov       rcx,0CC2906DA2B2B
       cmp       [rbp+8],rcx
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
       call      qword ptr [7FFE77796D30]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       jmp       near ptr M05_L03
M05_L17:
       mov       ecx,0B
       call      qword ptr [7FFE77794420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M05_L01
M05_L18:
       mov       [rbp+30],r8
       mov       rcx,r8
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13,[rbp+30]
       mov       eax,[r13+8]
       mov       [rbp+224],eax
       mov       rcx,r14
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r14d,[rbp+234]
       mov       [rsp+20],r14d
       mov       edx,r15d
       mov       r8d,[rbp+224]
       mov       rcx,r12
       call      qword ptr [7FFE77B2CA80]
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
       call      qword ptr [7FFE77A4E448]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FFE7787D2D8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFE77286820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+228],eax
       mov       rcx,r15
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rbp+234]
       mov       [rsp+20],r15d
       mov       edx,r14d
       mov       r8d,[rbp+228]
       mov       rcx,r12
       call      qword ptr [7FFE77B2CA80]
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
       mov       r8,19BF8C762A0
       jmp       near ptr M05_L02
M05_L32:
       mov       ecx,r13d
       mov       rdx,19BF8C76F28
       call      qword ptr [7FFE7750D788]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFE77976D48]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M05_L35:
       cmp       byte ptr [r12+9D],0
       je        near ptr M05_L37
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+230],eax
       mov       rcx,r15
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,[rbp+230]
       mov       rcx,r12
       call      qword ptr [7FFE77B2CA80]
       mov       eax,[r13+8]
       mov       [rbp+22C],eax
       mov       rcx,r15
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE77B2CAC8]
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
       call      qword ptr [7FFE772857E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,15B63C01DD0
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
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0B
       jle       short M05_L40
       mov       rcx,[rcx+240]
       mov       rax,[rcx+58]
       test      rax,rax
       jne       short M05_L41
M05_L40:
       mov       ecx,0B
       call      qword ptr [7FFE77794420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M05_L41:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M05_L42
       mov       rcx,rbx
       call      qword ptr [7FFE7797EC70]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
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
       call      qword ptr [7FFE77B2CE70]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FFE771C4000
       call      qword ptr [7FFE775076F0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE776E5B30]
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
       call      qword ptr [7FFE77D94A50]
M05_L44:
       mov       r14,[rax+8]
       call      qword ptr [7FFE77A4E448]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FFE7787D2D8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFE77286820]; System.Threading.Monitor.Exit(System.Object)
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
       mov       rcx,15B63C00C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       je        near ptr M05_L58
       mov       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       je        near ptr M05_L58
       mov       rcx,[rbp+40]
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp+40]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FFE77BBEDC0]
       test      r14d,edi
       jne       short M05_L58
       mov       rcx,[rbp+40]
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,[rbp+40]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE77B2CEE8]
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
       call      00007FFED6E20370
       test      eax,eax
       jne       short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FFE77BB6B38]
M06_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M06_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M06_L03
       mov       rcx,7FFE77D37B98
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FFE77876220]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M06_L04
M06_L02:
       xor       ecx,ecx
       call      qword ptr [7FFE77BB5DE8]
       int       3
M06_L03:
       mov       rcx,7FFE77D37B94
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE77BBD638]
       int       3
M06_L04:
       mov       rcx,7FFE77D37B9C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FFED6E6FFC0
       test      eax,eax
       jne       near ptr M06_L10
M06_L05:
       mov       rcx,7FFE77D37BA0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFE77D37BA4
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L06:
       call      qword ptr [7FFE77BBE148]
       int       3
M06_L07:
       mov       rcx,7FFE77D37B90
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE77BBD638]
       int       3
M06_L08:
       mov       rcx,rbx
       call      qword ptr [7FFE7779C4E0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M06_L09
       call      qword ptr [7FFE77BB62F8]
       int       3
M06_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFED6E8EEF0
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M06_L00
M06_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE77BB6940]
       jmp       near ptr M06_L05
       sub       rsp,28
       call      qword ptr [7FFE77BBE160]
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
       mov       rcx,7FFE77D37B9C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M06_L11
       xor       ecx,ecx
       call      qword ptr [7FFE77BB5DE8]
       int       3
M06_L11:
       mov       rcx,[rbp-20]
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M06_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFE77BB6940]
M06_L12:
       mov       rcx,7FFE77D37BA0
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
       jne       short M07_L04
M07_L03:
       xor       edx,edx
       jmp       short M07_L00
M07_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L00
       test      rax,rax
       je        short M07_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L00
       jmp       short M07_L02
; Total bytes of code 88
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       mov       rbx,1B538A8F9F0
       mov       [rbp-0B0],rbx
       mov       rax,174B9C006F0
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
       mov       rdx,7FFED6E9E4E0
       call      rdx
       movzx     ebx,al
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M00_L24
M00_L01:
       cmp       ebx,0F
       je        near ptr M00_L32
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       mov       rax,7FFED6E9E4E0
       call      rax
       movzx     ebx,al
       mov       rsi,[rbp-0B0]
       cmp       dword ptr [7FFED71EE808],0
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
       mov       rax,7FFED6E9E4E0
       call      rax
       movzx     ebx,al
       mov       rsi,[rbp-80]
       cmp       dword ptr [7FFED71EE808],0
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
       call      00007FFED6EA1090
       test      eax,eax
       jne       near ptr M00_L32
       mov       rsi,[rbp-78]
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L58
       mov       rbx,[rsi+8]
       test      rbx,rbx
       je        near ptr M00_L33
M00_L08:
       mov       rsi,[rbx+8]
       mov       rcx,174A3C01938
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M00_L09
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE771FD050
       mov       [rdi+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [rdi+20],rcx
       mov       rcx,174A3C01938
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L09:
       mov       [rbp-88],rsi
       cmp       [rsi],sil
       mov       r14,[rsi+8]
       mov       rcx,[r14+8]
       cmp       byte ptr [rsi+19],0
       jne       near ptr M00_L18
       mov       rdx,1B538A8F9F0
       mov       r11,7FFE77201250
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
       jae       near ptr M00_L63
       mov       edx,edx
       mov       r13,[rcx+rdx*8+10]
       test      r13,r13
       je        near ptr M00_L37
M00_L11:
       cmp       esi,[r13+20]
       jne       near ptr M00_L35
       mov       r12,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r15],rcx
       jne       near ptr M00_L36
       test      r12,r12
       je        near ptr M00_L35
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M00_L34
       mov       rcx,1B538A8F9F0
       cmp       r12,rcx
       sete      al
       movzx     eax,al
M00_L12:
       test      eax,eax
       je        near ptr M00_L35
       mov       rdx,[r13+10]
       mov       [rbp-90],rdx
M00_L13:
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       near ptr M00_L57
       mov       rcx,[rbp-90]
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        short M00_L14
       cmp       byte ptr [rbx+119],2
       jne       near ptr M00_L19
M00_L14:
       test      rbx,rbx
       je        near ptr M00_L59
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
       call      qword ptr [7FFE77B5C4B0]; System.Text.Json.JsonSerializer.ReadFromSpanAsObject(System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       test      rax,rax
       jne       short M00_L21
M00_L16:
       xor       ecx,ecx
       mov       [rbp-50],rcx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+18]
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
       mov       rcx,1B538A8F9F0
       mov       rax,[7FFE771FA1C0]
       call      qword ptr [rax+18]
       mov       esi,eax
       jmp       near ptr M00_L10
M00_L19:
       mov       rcx,rbx
       call      qword ptr [7FFE778A6208]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L14
M00_L20:
       mov       rcx,rbx
       call      qword ptr [7FFE778A6208]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L15
M00_L21:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       cmp       [rax],rcx
       jne       short M00_L16
       mov       [rbp-50],rax
       jmp       short M00_L17
M00_L22:
       mov       ecx,3888
       mov       rdx,7FFE777B9C30
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE77BE6190]
       int       3
M00_L23:
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE777C44B0]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,[rbp-70]
       call      qword ptr [7FFE77AEE160]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FFE77DC47F8]
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
       call      qword ptr [7FFE77BE6D18]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE77BE6D30]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L32:
       mov       ecx,3C7C
       mov       rdx,7FFE777B9C30
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       mov       rdx,1B538A8F9F0
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE77DC4810]
       int       3
M00_L33:
       mov       rcx,rsi
       call      qword ptr [7FFE777CC4B0]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M00_L08
M00_L34:
       mov       rcx,r12
       mov       rdx,1B538A8F9F0
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L12
M00_L35:
       mov       r13,[r13+18]
       test      r13,r13
       jne       near ptr M00_L11
       jmp       short M00_L37
M00_L36:
       mov       rcx,r15
       mov       r8,1B538A8F9F0
       mov       rdx,r12
       mov       r11,7FFE77201258
       call      qword ptr [r11]
       jmp       near ptr M00_L12
M00_L37:
       xor       edx,edx
       mov       [rbp-90],rdx
       mov       [rbp-98],r14
       mov       rdx,1B538A8F9F0
       mov       r8,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       [rbp-0A8],rax
       mov       rbx,[r14+8]
       jmp       near ptr M00_L52
M00_L38:
       mov       rcx,[rbp-0A0]
       mov       ecx,[rcx+8]
       cmp       [rbp-3C],ecx
       jae       near ptr M00_L47
       mov       rcx,[rbp-0A0]
       mov       eax,[rbp-3C]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       short M00_L39
       xor       ecx,ecx
       call      qword ptr [7FFE77BE6190]
       int       3
M00_L39:
       mov       rcx,r14
       call      00007FFED6E20370
       test      eax,eax
       jne       short M00_L40
       mov       rcx,r14
       call      qword ptr [7FFE77BE6EE0]
M00_L40:
       mov       dword ptr [rbp-48],1
       mov       rcx,[rbp-98]
       mov       rax,[rbp-88]
       cmp       rcx,[rax+8]
       je        short M00_L43
       mov       rcx,[rax+8]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       rbx,[rcx+8]
       je        near ptr M00_L51
       mov       rcx,[rbp-98]
       mov       rbx,[rcx+8]
       cmp       byte ptr [rax+19],0
       jne       short M00_L41
       mov       rcx,rbx
       mov       rdx,1B538A8F9F0
       mov       r11,7FFE77201268
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L42
M00_L41:
       mov       rcx,1B538A8F9F0
       mov       rdx,[7FFE771FA1C0]
       call      qword ptr [rdx+18]
       mov       esi,eax
M00_L42:
       mov       rax,[rbp-88]
       jmp       near ptr M00_L51
M00_L43:
       xor       r14d,r14d
       mov       r15,[rdi]
       test      r15,r15
       je        short M00_L49
M00_L44:
       cmp       esi,[r15+20]
       jne       short M00_L45
       mov       rdx,[r15+8]
       mov       rcx,rbx
       mov       r8,1B538A8F9F0
       mov       r11,7FFE77201270
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-88]
       jne       short M00_L46
M00_L45:
       inc       r14d
       mov       r15,[r15+18]
       test      r15,r15
       jne       short M00_L44
       jmp       short M00_L49
M00_L46:
       mov       rcx,[r15+10]
       mov       [rbp-90],rcx
       jmp       near ptr M00_L54
M00_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L48:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L49:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13,[rdi]
       mov       rcx,1B538A8F9F0
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
       jae       short M00_L47
       mov       ecx,[rbp-3C]
       lea       rdx,[rdx+rcx*4+10]
       mov       ecx,[rdx]
       add       ecx,1
       jo        short M00_L48
       mov       [rdx],ecx
       mov       rdx,[rbp-98]
       mov       rdx,[rdx+20]
       mov       ecx,[rdx+8]
       cmp       [rbp-3C],ecx
       jae       near ptr M00_L47
       mov       ecx,[rbp-3C]
       mov       edx,[rdx+rcx*4+10]
       mov       ecx,1
       mov       rax,[rbp-88]
       cmp       edx,[rax+10]
       cmovle    ecx,[rbp-40]
       mov       [rbp-40],ecx
       cmp       r14d,64
       jbe       short M00_L50
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       ecx,1
       test      rax,rax
       cmove     ecx,[rbp-44]
       mov       [rbp-44],ecx
M00_L50:
       call      M00_L64
       jmp       near ptr M00_L55
M00_L51:
       mov       rcx,[rbp-0A0]
       mov       edx,[rbp-3C]
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L53
       mov       rcx,r14
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M00_L52
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE77BE6AA8]
M00_L52:
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
       jae       near ptr M00_L63
       mov       eax,r8d
       lea       rdi,[rcx+rax*8+10]
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       [rbp-44],ecx
       mov       [rbp-48],ecx
       jmp       near ptr M00_L38
M00_L53:
       xor       ecx,ecx
       call      qword ptr [7FFE77BE6190]
       int       3
M00_L54:
       call      M00_L64
       jmp       near ptr M00_L13
M00_L55:
       mov       ecx,[rbp-40]
       or        ecx,[rbp-44]
       je        short M00_L56
       mov       rcx,[rbp-88]
       mov       rdx,[rbp-98]
       mov       r8d,[rbp-40]
       mov       r9d,[rbp-44]
       call      qword ptr [7FFE779AF4E0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
M00_L56:
       mov       r8,[rbp-0A8]
       mov       [rbp-90],r8
       jmp       near ptr M00_L13
M00_L57:
       call      qword ptr [7FFE77BED9C8]
       int       3
M00_L58:
       mov       rcx,rsi
       mov       rdx,1B538A8F9F0
       call      qword ptr [7FFE777CCA50]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       jmp       near ptr M00_L14
M00_L59:
       mov       rcx,1B538A9B218
       call      qword ptr [7FFE77DC46D8]
       mov       rbx,rax
       mov       rcx,[rbp-70]
       call      qword ptr [7FFE772BC960]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L60
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L60
       jmp       short M00_L61
M00_L60:
       mov       rcx,rax
       call      qword ptr [7FFE772B7C00]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
M00_L61:
       mov       rsi,[rcx+30]
       test      rsi,rsi
       jne       short M00_L62
       lea       rdx,[rcx+30]
       mov       r8d,1
       call      qword ptr [7FFE77454A50]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
M00_L62:
       mov       rcx,1B538A925E0
       test      rsi,rsi
       cmove     rsi,rcx
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rbx
       mov       rdx,1B538A8F9F0
       mov       r8,rsi
       call      qword ptr [7FFE77B57570]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE77715A88]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L64:
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp-48],0
       je        short M00_L67
       mov       rcx,[rbp-0A0]
       mov       ecx,[rcx+8]
       cmp       [rbp-3C],ecx
       jae       short M00_L65
       mov       rcx,[rbp-0A0]
       mov       eax,[rbp-3C]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       short M00_L66
       xor       ecx,ecx
       call      qword ptr [7FFE77BE6190]
       int       3
M00_L65:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L66:
       mov       rcx,r14
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M00_L67
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE77BE6AA8]
M00_L67:
       nop
       add       rsp,28
       ret
; Total bytes of code 2512
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
       call      qword ptr [7FFE777CCA50]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M01_L00:
       mov       rcx,7FFE77DA4F84
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
       mov       rcx,7FFE77DA4F80
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77BEE520]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE77BEFA20]
       mov       [rbp-20],rsi
       lea       rax,[M01_L00]
       add       rsp,28
       ret
; Total bytes of code 185
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
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax+220],xmm4
       vmovdqa   xmmword ptr [rbp+rax+230],xmm4
       vmovdqa   xmmword ptr [rbp+rax+240],xmm4
       add       rax,30
       jne       short M02_L00
       mov       rax,0A179AF0A2F49
       mov       [rbp+8],rax
       mov       rbx,rdx
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       xor       ecx,ecx
       mov       [rbp+40],rcx
       cmp       edi,55
       jle       near ptr M02_L15
       cmp       edi,15555555
       jg        near ptr M02_L16
       mov       rcx,174A3C01DD0
       mov       r14,[rcx]
       mov       r15,r14
       lea       r13d,[rdi+rdi*2]
       mov       rcx,174A3C00C90
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
       cmp       dword ptr [rcx+238],0B
       jle       near ptr M02_L17
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+58]
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
       mov       [rbp+40],r8
M02_L03:
       test      r8,r8
       je        near ptr M02_L36
       lea       r14,[r8+10]
       mov       r15d,[r8+8]
M02_L04:
       mov       [rbp+10],r14
       mov       [rbp+7C],r15d
       mov       [rbp+68],rsi
       mov       [rbp+70],edi
       mov       [rbp+58],r14
       mov       [rbp+60],r15d
       lea       rcx,[rbp+68]
       lea       rdx,[rbp+58]
       call      qword ptr [7FFE777C78D0]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,r15d
       ja        near ptr M02_L07
       mov       [rbp+10],r14
       mov       [rbp+7C],eax
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
       mov       [rbp+48],r14
       mov       [rbp+50],eax
       lea       rdx,[rbp+48]
       lea       rcx,[rbp+128]
       lea       r9,[rbp+1E8]
       mov       r8d,1
       call      qword ptr [7FFE77924E58]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
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
       mov       r8,[rbx+0D0]
       mov       [rbp+0B8],r8
       mov       r8,[rbp+0B8]
       mov       r8,[r8+0C8]
       mov       [rbp+11C],r8
       cmp       byte ptr [rbp+0B1],0
       jne       near ptr M02_L12
       mov       r8,[rbx+0A0]
       test      r8,r8
       jne       near ptr M02_L11
       xor       edx,edx
M02_L06:
       mov       [rbp+113],dl
       mov       byte ptr [rbp+0B0],0
       lea       r8,[rbp+88]
       lea       rdx,[rbp+128]
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       [rbp+38],rax
       jmp       short M02_L13
M02_L07:
       call      qword ptr [7FFE774570D8]
       int       3
M02_L08:
       mov       ecx,38A0
       mov       rdx,7FFE777B9C30
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE77DC41B0]
       int       3
M02_L09:
       mov       ecx,38A0
       mov       rdx,7FFE777B9C30
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE77DC41C8]
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
       movzx     edx,byte ptr [r8+34]
       jmp       near ptr M02_L06
M02_L12:
       mov       edx,1
       jmp       near ptr M02_L06
M02_L13:
       call      M02_L39
       nop
       mov       rax,[rbp+38]
       mov       rcx,0A179AF0A2F49
       cmp       [rbp+8],rcx
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
       mov       [rbp+68],rsi
       mov       [rbp+70],edi
       lea       rcx,[rbp+68]
       call      qword ptr [7FFE777C6D30]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       jmp       near ptr M02_L03
M02_L17:
       mov       ecx,0B
       call      qword ptr [7FFE777C4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M02_L01
M02_L18:
       mov       [rbp+30],r8
       mov       rcx,r8
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13,[rbp+30]
       mov       eax,[r13+8]
       mov       [rbp+224],eax
       mov       rcx,r14
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r14d,[rbp+234]
       mov       [rsp+20],r14d
       mov       edx,r15d
       mov       r8d,[rbp+224]
       mov       rcx,r12
       call      qword ptr [7FFE77B5CA68]
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
       call      qword ptr [7FFE77A7E508]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       mov       [rbp+20],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rbp+28],r8
       mov       rcx,rdx
       call      qword ptr [7FFE778ACFD8]; System.Threading.Monitor.Enter(System.Object)
       mov       rdx,[rbp+20]
       mov       rcx,[rdx+8]
       mov       eax,[rdx+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M02_L23
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
       mov       [rbp+28],r8
       mov       r10d,eax
       xor       r9d,r9d
       mov       [rcx+r10*8+10],r9
       mov       [rdx+10],eax
M02_L23:
       mov       rcx,rdx
       call      qword ptr [7FFE772B6820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+28]
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
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+228],eax
       mov       rcx,r15
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rbp+234]
       mov       [rsp+20],r15d
       mov       edx,r14d
       mov       r8d,[rbp+228]
       mov       rcx,r12
       call      qword ptr [7FFE77B5CA68]
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
       mov       r8,1B538A862A0
       jmp       near ptr M02_L02
M02_L32:
       mov       ecx,r13d
       mov       rdx,1B538A86F28
       call      qword ptr [7FFE7753D788]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFE779A6DF0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M02_L35:
       cmp       byte ptr [r12+9D],0
       je        near ptr M02_L37
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+230],eax
       mov       rcx,r15
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,[rbp+230]
       mov       rcx,r12
       call      qword ptr [7FFE77B5CA68]
       mov       eax,[r13+8]
       mov       [rbp+22C],eax
       mov       rcx,r15
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE77B5CAB0]
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
       cmp       qword ptr [rbp+40],0
       je        near ptr M02_L58
       mov       edx,[rbp+7C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE772B57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,174A3C01DD0
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
       cmp       dword ptr [rcx+238],0B
       jle       short M02_L40
       mov       rcx,[rcx+240]
       mov       rax,[rcx+58]
       test      rax,rax
       jne       short M02_L41
M02_L40:
       mov       ecx,0B
       call      qword ptr [7FFE777C4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M02_L41:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L42
       mov       rcx,rbx
       call      qword ptr [7FFE779AED30]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
M02_L42:
       xor       edi,edi
       mov       r14d,1
       cmp       [rax+8],esi
       jbe       near ptr M02_L54
       mov       edi,1
       mov       rcx,[rbp+40]
       mov       edx,10
       shlx      edx,edx,esi
       cmp       [rcx+8],edx
       je        short M02_L43
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77B5CE58]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE77715B30]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L43:
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
       call      qword ptr [7FFE77DC4AE0]
M02_L44:
       mov       r14,[rax+8]
       call      qword ptr [7FFE77A7E508]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       mov       [rbp+18],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp+84],edx
       mov       rcx,rax
       call      qword ptr [7FFE778ACFD8]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp+18]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp+80],r8d
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
       mov       ecx,[rbp+80]
       inc       ecx
       mov       rax,[rbp+18]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+84],1
M02_L47:
       mov       rcx,rax
       call      qword ptr [7FFE772B6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp+84],0
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
       mov       rcx,174A3C00C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       je        near ptr M02_L58
       mov       rcx,[rbp+40]
       cmp       dword ptr [rcx+8],0
       je        near ptr M02_L58
       mov       rcx,[rbp+40]
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp+40]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FFE77BEF090]
       test      r14d,edi
       jne       short M02_L58
       mov       rcx,[rbp+40]
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,[rbp+40]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE77B5CED0]
M02_L58:
       nop
       add       rsp,38
       ret
; Total bytes of code 2448
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
       je        near ptr M03_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       near ptr M03_L07
       mov       rbx,[rcx+0B8]
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M03_L08
M03_L00:
       mov       [rbp-20],rsi
       xor       eax,eax
       mov       [rbp-14],eax
       test      rsi,rsi
       je        short M03_L02
       mov       rcx,rsi
       call      00007FFED6E20370
       test      eax,eax
       jne       short M03_L01
       mov       rcx,rsi
       call      qword ptr [7FFE77BE6EE0]
M03_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M03_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M03_L03
       mov       rcx,7FFE77D6CC38
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FFE778A6220]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M03_L04
M03_L02:
       xor       ecx,ecx
       call      qword ptr [7FFE77BE6190]
       int       3
M03_L03:
       mov       rcx,7FFE77D6CC34
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE77BED9C8]
       int       3
M03_L04:
       mov       rcx,7FFE77D6CC3C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FFED6E6FFC0
       test      eax,eax
       jne       near ptr M03_L10
M03_L05:
       mov       rcx,7FFE77D6CC40
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFE77D6CC44
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M03_L06:
       call      qword ptr [7FFE77BEE508]
       int       3
M03_L07:
       mov       rcx,7FFE77D6CC30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE77BED9C8]
       int       3
M03_L08:
       mov       rcx,rbx
       call      qword ptr [7FFE777CC4E0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M03_L09
       call      qword ptr [7FFE77BE66A0]
       int       3
M03_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFED6E8EEF0
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M03_L00
M03_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE77BE6AA8]
       jmp       near ptr M03_L05
       sub       rsp,28
       call      qword ptr [7FFE77BEE520]
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
       je        short M03_L12
       mov       rcx,7FFE77D6CC3C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M03_L11
       xor       ecx,ecx
       call      qword ptr [7FFE77BE6190]
       int       3
M03_L11:
       mov       rcx,[rbp-20]
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M03_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFE77BE6AA8]
M03_L12:
       mov       rcx,7FFE77D6CC40
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
       call      qword ptr [7FFFAFF9F470]
       movzx     ecx,byte ptr [rax+1]
       mov       [rbx+95],cl
       movzx     eax,byte ptr [rax+2]
       mov       [rbx+96],al
       mov       word ptr [rbx+90],20
       mov       dword ptr [rbx+84],2
       mov       byte ptr [rbx+9D],1
       mov       dword ptr [rbx+88],40
       call      qword ptr [7FFFAFF9F4E8]
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
       jne       short M05_L01
       mov       rax,[rcx+58]
       test      rax,rax
       jne       short M05_L02
M05_L00:
       lea       rcx,[rcx+20]
       call      qword ptr [7FFFAFF9F230]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M05_L01:
       mov       rcx,[rcx+20]
       call      qword ptr [7FFFAFFA1550]
       mov       rcx,rax
       call      qword ptr [7FFFAFFA3BE8]
       int       3
M05_L02:
       cmp       rax,rdx
       je        short M05_L00
       xor       r8d,r8d
       mov       [rax+10],r8
       mov       [rcx+58],r8
       jmp       short M05_L00
; Total bytes of code 76
```
```assembly
; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFFAFFA52F8]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFFAFFA32C0]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       test      rax,rax
       cmove     rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
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
       jbe       near ptr M08_L15
       mov       rcx,[rax+10]
       call      qword ptr [7FFFB7240038]; Precode of System.Threading.Monitor.Enter(System.Object)
       mov       dword ptr [rbp-48],1
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+8]
       jne       near ptr M08_L18
       mov       rax,[rbx+10]
       mov       r14d,[rax+8]
       xor       r15d,r15d
       test      dil,dil
       jne       near ptr M08_L13
M08_L00:
       test      sil,sil
       je        short M08_L02
       test      r15,r15
       jne       short M08_L01
       mov       rcx,[rbp+10]
       call      qword ptr [7FFFB72408B0]
       mov       rcx,[rbx+10]
       mov       ecx,[rcx+8]
       shr       ecx,2
       cmp       eax,ecx
       jl        near ptr M08_L12
M08_L01:
       mov       rax,[rbx+10]
       mov       eax,[rax+8]
       add       eax,eax
       js        near ptr M08_L17
       mov       ecx,eax
       call      qword ptr [7FFFB72403B8]; Precode of System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       call      qword ptr [7FFFB723FF30]; Precode of System.Array.get_MaxLength()
       cmp       eax,r14d
       jl        near ptr M08_L17
M08_L02:
       mov       rsi,[rbx+18]
       mov       rdi,rsi
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+18],0
       je        short M08_L04
       cmp       dword ptr [rsi+8],400
       jge       short M08_L04
       mov       eax,[rsi+8]
       add       eax,eax
       movsxd    rcx,eax
       call      qword ptr [7FFFB723FED8]
       mov       rdi,rax
       mov       r8d,[rsi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFFB723FF18]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,[rbx+18]
       mov       esi,[rax+8]
       mov       r13d,[rdi+8]
       cmp       r13d,esi
       jle       short M08_L04
M08_L03:
       call      qword ptr [7FFFB723FE30]
       mov       r8,rax
       movsxd    rdx,esi
       mov       rcx,rdi
       call      qword ptr [7FFFB723F2A8]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       esi
       cmp       r13d,esi
       jg        short M08_L03
M08_L04:
       mov       rcx,[rbp+10]
       mov       r13,[rcx]
       mov       rcx,r13
       call      qword ptr [7FFFB723F9E0]
       mov       rcx,rax
       movsxd    rdx,r14d
       call      qword ptr [7FFFB723F2C0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       ecx,[rdi+8]
       call      qword ptr [7FFFB723FEE0]
       mov       r14,rax
       mov       r12,r15
       test      r12,r12
       jne       short M08_L05
       mov       r12,[rbx+8]
M08_L05:
       mov       rcx,r13
       call      qword ptr [7FFFB723F738]
       mov       rcx,rax
       call      qword ptr [7FFFB723F2B8]; CORINFO_HELP_NEWFAST
       mov       [rbp-78],rax
       lea       rcx,[rax+10]
       mov       rdx,rsi
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+18]
       mov       rdx,rdi
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+20]
       mov       rdx,r14
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rsi+8]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       r12,[rbp-78]
       mov       [r12+28],rax
       mov       rcx,r13
       call      qword ptr [7FFFB723F700]
       mov       rcx,rax
       lea       r8,[rbp-48]
       mov       rdx,rbx
       call      qword ptr [7FFFB72408D0]
       mov       rbx,[rbx+10]
       xor       eax,eax
       mov       edx,[rbx+8]
       cmp       edx,eax
       jg        near ptr M08_L10
M08_L06:
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
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L18
M08_L07:
       test      r15,r15
       jne       near ptr M08_L11
       mov       [rbp-68],rdx
       mov       r8d,[rdx+20]
M08_L08:
       mov       rdx,[rbp-68]
       mov       r10,[rdx+18]
       mov       [rbp-80],r10
       mov       rcx,[r12+10]
       mov       [rbp-4C],r8d
       mov       r9d,r8d
       imul      r9,[r12+28]
       shr       r9,20
       inc       r9
       mov       r11d,[rcx+8]
       mov       esi,r11d
       imul      r9,rsi
       shr       r9,20
       mov       rsi,[r12+18]
       mov       eax,r9d
       xor       edx,edx
       div       dword ptr [rsi+8]
       mov       esi,edx
       cmp       r9d,r11d
       jae       near ptr M08_L15
       mov       eax,r9d
       lea       rax,[rcx+rax*8+10]
       mov       [rbp-70],rax
       mov       rcx,r13
       call      qword ptr [7FFFB723F720]
       mov       rcx,rax
       call      qword ptr [7FFFB723F2B8]; CORINFO_HELP_NEWFAST
       mov       [rbp-88],rax
       mov       r8,[rbp-68]
       mov       rdx,[r8+8]
       mov       r8,[r8+10]
       mov       [rbp-90],r8
       mov       r10,[rbp-70]
       mov       r9,[r10]
       mov       [rbp-98],r9
       lea       rcx,[rax+8]
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-90]
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       lea       rcx,[rax+18]
       mov       rdx,[rbp-98]
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       mov       ecx,[rbp-4C]
       mov       [rax+20],ecx
       mov       rcx,[rbp-70]
       mov       rdx,rax
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       cmp       esi,[r14+8]
       jae       near ptr M08_L15
       mov       eax,esi
       lea       rax,[r14+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M08_L16
       mov       [rax],edx
       mov       rsi,[rbp-80]
       test      rsi,rsi
       mov       rdx,rsi
       jne       near ptr M08_L07
M08_L09:
       mov       rax,[rbp-58]
       inc       eax
       mov       edx,[rbx+8]
       cmp       edx,eax
       jle       near ptr M08_L06
M08_L10:
       mov       [rbp-58],rax
       mov       rdx,[rbx+rax*8+10]
       test      rdx,rdx
       jne       near ptr M08_L07
       jmp       short M08_L09
M08_L11:
       mov       [rbp-68],rdx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       call      qword ptr [7FFFB723FBA8]
       mov       r8,[rbp-68]
       mov       rdx,[r8+8]
       mov       rcx,r15
       mov       r11,rax
       call      qword ptr [rax]
       mov       r8d,eax
       jmp       near ptr M08_L08
M08_L12:
       mov       rcx,[rbp+10]
       mov       eax,[rcx+10]
       add       eax,eax
       mov       [rcx+10],eax
       test      eax,eax
       jge       near ptr M08_L18
       jmp       short M08_L14
M08_L13:
       mov       rcx,[rbx+8]
       call      qword ptr [7FFFB723FEF8]
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M08_L00
       mov       rcx,[rbp+10]
       mov       r13,[rcx]
       mov       rcx,r13
       call      qword ptr [7FFFB723F548]
       mov       r15,rax
       mov       rcx,rdi
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFFB723F2C8]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M08_L00
M08_L14:
       mov       dword ptr [rcx+10],7FFFFFFF
       jmp       short M08_L18
M08_L15:
       call      qword ptr [7FFFB723F288]
       int       3
M08_L16:
       call      qword ptr [7FFFB723F280]
       int       3
M08_L17:
       call      qword ptr [7FFFB723FF30]; Precode of System.Array.get_MaxLength()
       mov       r14d,eax
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+10],7FFFFFFF
       jmp       near ptr M08_L02
M08_L18:
       mov       rcx,[rbp+10]
       mov       edx,[rbp-48]
       call      qword ptr [7FFFB72408E0]
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
       call      qword ptr [7FFFB72408E0]
       nop
       add       rsp,28
       ret
; Total bytes of code 1137
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
       jne       short M09_L00
       mov       rcx,7FFE77DA4FE8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbx+20]
M09_L00:
       test      rdi,rdi
       je        short M09_L02
       mov       rcx,rdi
       mov       rdx,7FFE77DA4FF0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rdi
       mov       r8,rbx
       mov       rdx,rsi
       mov       r11,7FFE77200E90
       call      qword ptr [r11]
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M09_L06
       mov       rcx,[rbp+0C0]
       mov       rdx,rsi
       call      qword ptr [7FFE77454A20]; System.Type.op_Equality(System.Type, System.Type)
       test      eax,eax
       je        short M09_L03
       cmp       [rbp+0B8],rbx
       jne       short M09_L04
M09_L01:
       mov       rcx,7FFE77DA5108
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M09_L02:
       mov       rcx,7FFE77DA4FEC
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M09_L03:
       mov       rcx,7FFE77DA50F8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp+0C0]
       mov       rcx,rsi
       call      qword ptr [7FFE77BEFA38]
       int       3
M09_L04:
       mov       rcx,7FFE77DA50FC
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFE77BEFA50]
       int       3
M09_L05:
       mov       rcx,7FFE77DA5100
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L01
M09_L06:
       mov       rcx,1B538A819B8
       cmp       rsi,rcx
       jne       short M09_L05
       mov       rcx,7FFE77DA5104
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SlimObjectConverter
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE777CD8F0]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       call      qword ptr [7FFE778A51A0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Text.Json.Serialization.JsonConverter, System.Text.Json.JsonSerializerOptions)
       mov       rbp,rsi
       jmp       near ptr M09_L01
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
       je        short M10_L01
M10_L00:
       add       rsp,20
       pop       rbx
       ret
M10_L01:
       call      qword ptr [7FFE772B5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M10_L00
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
       je        near ptr M11_L08
M11_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M11_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M11_L09
M11_L01:
       test      rdi,rdi
       jne       near ptr M11_L07
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
       call      00007FFED6E34140
       mov       r14,rax
       test      r14,r14
       je        near ptr M11_L10
M11_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M11_L05
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
       mov       rax,7FFE77416D90
       mov       [rbp-78],rax
       lea       rax,[M11_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFED6DD50B0
       call      rax
M11_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFED71EE808],0
       je        short M11_L04
       call      qword ptr [7FFED71DC608]; CORINFO_HELP_STOP_FOR_GC
M11_L04:
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
M11_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFED6EB03C0
       mov       rdx,rax
       test      rdx,rdx
       je        short M11_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M11_L11
M11_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M11_L07:
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
M11_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FFE77DC6DC0]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M11_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE77BE7B58]
       jmp       near ptr M11_L00
M11_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M11_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFE772B7C48]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M11_L02
M11_L11:
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
       je        near ptr M12_L04
       mov       [rbp-48],rcx
       mov       rcx,[rbp-48]
       test      rcx,rcx
       je        near ptr M12_L03
       mov       rcx,[rcx+18]
M12_L00:
       lea       rdx,[rbp-48]
       mov       [rbp-90],rdx
       mov       [rbp-88],rcx
       lea       rcx,[rbp-90]
       mov       edx,edi
       lea       r8,[rbp-40]
       mov       rax,7FFE77324D48
       mov       [rbp-70],rax
       lea       rax,[M12_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFED6E38460
       call      rax
M12_L01:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFED71EE808],0
       je        short M12_L02
       call      qword ptr [7FFED71DC608]; CORINFO_HELP_STOP_FOR_GC
M12_L02:
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
M12_L03:
       xor       ecx,ecx
       jmp       near ptr M12_L00
M12_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77BE6D18]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE77BE6D30]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 312
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       mov       rax,7FFED6077778
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L13
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L12
       mov       rax,7FFED6077778
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L13
M00_L01:
       test      rsi,rsi
       je        near ptr M00_L14
       mov       rcx,2069D401DC8
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+9F],0
       je        near ptr M00_L15
M00_L02:
       mov       rbp,[rdi+10]
       test      rbp,rbp
       je        short M00_L03
       mov       rcx,[rbp+0C0]
       mov       rax,247324A0B20
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
       mov       rdx,247324A0B20
       call      qword ptr [7FFE777BC9D8]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
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
       mov       rcx,7FFE77BAA980
       call      qword ptr [7FFE77B46898]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       test      rax,rax
       je        near ptr M00_L20
       mov       [rsp+38],rax
       mov       rbp,[rbx+18]
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
       mov       rcx,247324A0B20
       call      qword ptr [7FFE77CA7660]
       int       3
M00_L09:
       call      qword ptr [7FFE7770FD38]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L10
       call      qword ptr [7FFE77B46FA0]
       mov       rbx,rax
M00_L10:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,247324AAC70
       call      qword ptr [7FFE77B46FB8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       call      qword ptr [7FFE77A8D3F8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M00_L13
       jmp       near ptr M00_L00
M00_L12:
       call      qword ptr [7FFE77A8D3F8]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       je        near ptr M00_L01
M00_L13:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFE77CA4390]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L14:
       mov       ecx,3888
       mov       rdx,7FFE777A9C30
       call      qword ptr [7FFE775276F0]
       mov       rcx,rax
       call      qword ptr [7FFE77B4FE40]
       int       3
M00_L15:
       mov       rcx,rdi
       call      qword ptr [7FFE777B6C70]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L02
M00_L16:
       mov       rcx,rdi
       call      qword ptr [7FFE777BC4B0]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rcx,rax
       jmp       near ptr M00_L04
M00_L17:
       call      qword ptr [7FFE77CA7648]
       int       3
M00_L18:
       mov       rcx,rbp
       call      qword ptr [7FFE77896208]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L05
M00_L19:
       mov       rdx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L20:
       lea       rcx,[rsp+40]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FFE77524DB0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
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
       vmovups   ymm0,[7FFE77C6FA80]
       vmovups   [rdx],ymm0
       vmovups   ymm0,[7FFE77C6FAA0]
       vmovups   [rdx+20],ymm0
       vmovups   xmm0,[7FFE77C6FAC0]
       vmovups   [rdx+40],xmm0
       mov       word ptr [rdx+50],20
       mov       ecx,[rsp+50]
       add       ecx,29
       mov       [rsp+50],ecx
       jmp       short M00_L22
M00_L21:
       lea       rcx,[rsp+40]
       mov       rdx,247324AB348
       call      qword ptr [7FFE77B441B0]
M00_L22:
       lea       rcx,[rsp+40]
       mov       rdx,7FFE77AA4980
       mov       r8,247324A0B20
       call      qword ptr [7FFE7752E028]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ecx,[rsp+50]
       cmp       ecx,[rsp+60]
       jbe       short M00_L24
M00_L23:
       call      qword ptr [7FFE774470D8]
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
       mov       rdx,24732490658
       call      qword ptr [7FFE77B441B0]
M00_L26:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE77524DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE77705A88]
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
       mov       rcx,2069D401938
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L04
M01_L00:
       mov       rcx,7FFE77D38E6C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       [rdi],dil
       test      rbx,rbx
       je        near ptr M01_L05
       mov       r15,[rdi+8]
       mov       rcx,[r15+8]
       cmp       byte ptr [rdi+19],0
       jne       short M01_L03
       mov       rdx,rbx
       mov       r11,7FFE771F0DD0
       call      qword ptr [r11]
       mov       r13d,eax
M01_L01:
       lea       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rbx
       mov       r9d,r13d
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      qword ptr [7FFE77706118]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L06
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
       jmp       short M01_L01
M01_L04:
       mov       rcx,7FFE77D38E68
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FFE771ED050
       call      qword ptr [7FFE772A6E68]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,2069D401938
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,1
       mov       rdx,7FFE7764FC38
       call      qword ptr [7FFE775276F0]
       mov       rcx,rax
       call      qword ptr [7FFE77895F80]
       int       3
M01_L06:
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
       call      qword ptr [7FFE77707FC0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M01_L02
; Total bytes of code 392
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
       mov       rax,1D7EBB71B2B0
       mov       [rbp],rax
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp+38],rcx
       cmp       edi,55
       jle       near ptr M02_L16
       cmp       edi,15555555
       jg        near ptr M02_L15
       mov       rcx,2069D401DD0
       mov       r14,[rcx]
       mov       r15,r14
       lea       r13d,[rdi+rdi*2]
       mov       rcx,2069D400C90
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
       cmp       dword ptr [rcx+238],0B
       jle       near ptr M02_L17
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+58]
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
       call      qword ptr [7FFE777B78D0]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
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
       call      qword ptr [7FFE77914E58]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
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
       call      qword ptr [7FFE77914EE8]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rax,[rbp+80]
       xor       ecx,ecx
       mov       [rbp+80],rcx
       mov       [rbp+30],rax
       jmp       near ptr M02_L13
M02_L07:
       call      qword ptr [7FFE774470D8]
       int       3
M02_L08:
       mov       ecx,38A0
       mov       rdx,7FFE777A9C30
       call      qword ptr [7FFE775276F0]
       mov       rcx,rax
       call      qword ptr [7FFE77CAE250]
       int       3
M02_L09:
       mov       ecx,38A0
       mov       rdx,7FFE777A9C30
       call      qword ptr [7FFE775276F0]
       mov       rcx,rax
       call      qword ptr [7FFE77CAE268]
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
       mov       rcx,1D7EBB71B2B0
       cmp       [rbp],rcx
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
       mov       [rbp+60],rsi
       mov       [rbp+68],edi
       lea       rcx,[rbp+60]
       call      qword ptr [7FFE777B6D30]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       jmp       near ptr M02_L03
M02_L16:
       test      [rsp],esp
       sub       rsp,100
       lea       r14,[rsp+30]
       mov       r15d,100
       jmp       near ptr M02_L04
M02_L17:
       mov       ecx,0B
       call      qword ptr [7FFE777B4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M02_L01
M02_L18:
       mov       [rbp+28],r8
       mov       rcx,r8
       call      qword ptr [7FFE777BC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13,[rbp+28]
       mov       eax,[r13+8]
       mov       [rbp+224],eax
       mov       rcx,r14
       call      qword ptr [7FFE777BC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r14d,[rbp+234]
       mov       [rsp+20],r14d
       mov       edx,r15d
       mov       r8d,[rbp+224]
       mov       rcx,r12
       call      qword ptr [7FFE77B46D78]
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
       call      qword ptr [7FFE77A8EAF0]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FFE7789CFD8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFE772A6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFE777BC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+228],eax
       mov       rcx,r15
       call      qword ptr [7FFE777BC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rbp+234]
       mov       [rsp+20],r15d
       mov       edx,r14d
       mov       r8d,[rbp+228]
       mov       rcx,r12
       call      qword ptr [7FFE77B46D78]
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
       mov       r8,247324962A0
       jmp       near ptr M02_L02
M02_L32:
       mov       ecx,r13d
       mov       rdx,24732496F28
       call      qword ptr [7FFE7752D788]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFE779A72D0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M02_L35:
       cmp       byte ptr [r12+9D],0
       je        near ptr M02_L37
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFE777BC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+230],eax
       mov       rcx,r15
       call      qword ptr [7FFE777BC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,[rbp+230]
       mov       rcx,r12
       call      qword ptr [7FFE77B46D78]
       mov       eax,[r13+8]
       mov       [rbp+22C],eax
       mov       rcx,r15
       call      qword ptr [7FFE777BC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE77B46DC0]
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
       call      qword ptr [7FFE772A57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,2069D401DD0
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
       cmp       dword ptr [rcx+238],0B
       jle       short M02_L40
       mov       rcx,[rcx+240]
       mov       rax,[rcx+58]
       test      rax,rax
       jne       short M02_L41
M02_L40:
       mov       ecx,0B
       call      qword ptr [7FFE777B4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M02_L41:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L42
       mov       rcx,rbx
       call      qword ptr [7FFE779AF318]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
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
       call      qword ptr [7FFE77B47150]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FFE771E4000
       call      qword ptr [7FFE775276F0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE77705B30]
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
       call      qword ptr [7FFE77CAEC40]
M02_L44:
       mov       r14,[rax+8]
       call      qword ptr [7FFE77A8EAF0]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FFE7789CFD8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFE772A6820]; System.Threading.Monitor.Exit(System.Object)
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
       mov       rcx,2069D400C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       je        near ptr M02_L58
       mov       rcx,[rbp+38]
       cmp       dword ptr [rcx+8],0
       je        near ptr M02_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FFE777BC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp+38]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFE777BC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FFE77CACDF8]
       test      r14d,edi
       jne       short M02_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FFE777BC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,[rbp+38]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFE777BC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE77B471C8]
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
       call      qword ptr [7FFFAFF9F478]
       cmp       byte ptr [rax],0
       je        near ptr M04_L04
       call      qword ptr [7FFFAFFA5968]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M04_L00
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFFAFF9F230]; CORINFO_HELP_ASSIGN_REF
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFFAFFA1550]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M04_L02
M04_L01:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L02:
       call      qword ptr [7FFFAFF9F470]
       cmp       byte ptr [rax],0
       je        short M04_L01
       xorps     xmm0,xmm0
       movups    [rsp+30],xmm0
       mov       [rsp+30],rdi
       mov       [rsp+38],rsi
       lea       rcx,[rsp+20]
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       lea       r8,[rsp+30]
       mov       r9d,2
       call      qword ptr [7FFFAFFA6E98]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFFAFFA5998]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FFFAFF9F230]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M04_L01
       cmp       [rsi+10],rbx
       je        short M04_L03
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+9F],0
       jne       short M04_L03
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFFAFFA5250]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M04_L01
M04_L03:
       mov       rcx,[rsi+8]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M04_L01
M04_L04:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L05
       call      qword ptr [7FFFAFFA1568]
       test      rax,rax
       je        near ptr M04_L01
M04_L05:
       call      qword ptr [7FFFAFFA3BD0]
       int       3
; Total bytes of code 286
```
```assembly
; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFFAFFA52F8]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFFAFFA32C0]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       call      00007FFED6E20370
       test      eax,eax
       jne       short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FFE77CA4B88]
M06_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M06_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M06_L03
       mov       rcx,7FFE77D41048
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FFE77896220]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M06_L04
M06_L02:
       xor       ecx,ecx
       call      qword ptr [7FFE77B4FE40]
       int       3
M06_L03:
       mov       rcx,7FFE77D41044
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE77CA7648]
       int       3
M06_L04:
       mov       rcx,7FFE77D4104C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FFED6E6FFC0
       test      eax,eax
       jne       near ptr M06_L10
M06_L05:
       mov       rcx,7FFE77D41050
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFE77D41054
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L06:
       call      qword ptr [7FFE77CAC180]
       int       3
M06_L07:
       mov       rcx,7FFE77D41040
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE77CA7648]
       int       3
M06_L08:
       mov       rcx,rbx
       call      qword ptr [7FFE777BC4E0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M06_L09
       call      qword ptr [7FFE77CA4360]
       int       3
M06_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFED6E8EEF0
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M06_L00
M06_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE77CA4768]
       jmp       near ptr M06_L05
       sub       rsp,28
       call      qword ptr [7FFE77CAC198]
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
       mov       rcx,7FFE77D4104C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M06_L11
       xor       ecx,ecx
       call      qword ptr [7FFE77B4FE40]
       int       3
M06_L11:
       mov       rcx,[rbp-20]
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M06_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFE77CA4768]
M06_L12:
       mov       rcx,7FFE77D41050
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
       jmp       qword ptr [7FFE772AFCA8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       mov       rcx,2069D400C88
       mov       rsi,[rcx]
       imul      ecx,r8d,0B
       add       ecx,edx
       mov       edi,100
       cmp       ecx,100
       cmovg     edi,ecx
       mov       rcx,rsi
       mov       rdx,7FFE77D631E0
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
       je        short M09_L01
       mov       rcx,rsi
       call      qword ptr [7FFED6CFD260]
       test      rax,rax
       jne       short M09_L02
       mov       rcx,rsi
       lea       r11,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       call      qword ptr [r11]
       mov       rdx,rax
M09_L00:
       test      rdx,rdx
       je        short M09_L01
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
       call      qword ptr [7FFED6D03A28]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
M09_L01:
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M09_L02:
       mov       rcx,rsi
       call      qword ptr [7FFED6CFD298]
       test      rax,rax
       je        short M09_L04
       mov       rcx,rsi
       call      qword ptr [7FFED6CFE4D8]
       mov       rsi,rax
M09_L03:
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
       je        short M09_L06
       mov       ecx,[rsp+48]
       add       [rbx+10],ecx
       jmp       near ptr M09_L01
M09_L04:
       mov       rcx,rsi
       call      qword ptr [7FFED6CFE4D0]
       mov       rcx,rax
       mov       r8,[rbx]
       lea       r11,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M09_L00
M09_L05:
       call      qword ptr [7FFED6CF6128]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFED6D1A8E8]
       jmp       near ptr M09_L01
M09_L06:
       mov       rcx,rbx
       call      qword ptr [7FFED6D0B170]
       jmp       near ptr M09_L03
M09_L07:
       call      qword ptr [7FFED6D053B8]
       int       3
M09_L08:
       mov       rcx,rbx
       call      qword ptr [7FFED6D0B148]
       jmp       near ptr M09_L01
; Total bytes of code 393
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
       mov       rcx,2069D400C88
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
       mov       rcx,2069D400C90
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
       call      qword ptr [7FFE77A8EAF0]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      00007FFED6E20370
       test      eax,eax
       jne       short M10_L07
       mov       rcx,[rsp+38]
       call      qword ptr [7FFE77CA4B88]
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
       call      00007FFED6E6FFC0
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
       call      qword ptr [7FFE774470D8]
       int       3
M10_L14:
       mov       ecx,3
       call      qword ptr [7FFE777B4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M10_L00
M10_L15:
       mov       rcx,rbx
       call      qword ptr [7FFE7752CDE0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M10_L01
M10_L16:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE77B47150]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFE771E4000
       call      qword ptr [7FFE775276F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE77705B30]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M10_L17:
       mov       rcx,rbx
       mov       edx,ebp
       call      qword ptr [7FFE77A8E9B8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
       jmp       near ptr M10_L05
M10_L18:
       mov       ecx,eax
       mov       rdx,[rsp+38]
       call      qword ptr [7FFE77CA4768]
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
       call      qword ptr [7FFE777BC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       eax,[rdi+8]
       mov       [rsp+64],eax
       mov       rcx,rbx
       call      qword ptr [7FFE777BC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r13
       mov       r8d,r12d
       mov       r9d,[rsp+64]
       mov       edx,3
       call      qword ptr [7FFE77CACDF8]
       test      r15d,r14d
       jne       near ptr M10_L03
       mov       rcx,rdi
       call      qword ptr [7FFE777BC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       edi,[rdi+8]
       mov       rcx,rbx
       call      qword ptr [7FFE777BC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE77B471C8]
       jmp       near ptr M10_L03
M10_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 904
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       mov       rax,7FFED6077778
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L13
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L12
       mov       rax,7FFED6077778
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L13
M00_L01:
       test      rsi,rsi
       je        near ptr M00_L14
       mov       rcx,295E7C01DC8
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+9F],0
       je        near ptr M00_L15
M00_L02:
       mov       rbp,[rdi+10]
       test      rbp,rbp
       je        short M00_L03
       mov       rcx,[rbp+0C0]
       mov       rax,2D67CD39FF0
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
       mov       rdx,2D67CD39FF0
       call      qword ptr [7FFE7779CA08]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
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
       mov       rcx,7FFE77B9B790
       call      qword ptr [7FFE77B36A78]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       test      rax,rax
       je        near ptr M00_L20
       mov       [rsp+38],rax
       mov       rbp,[rbx+18]
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
       mov       rcx,2D67CD39FF0
       call      qword ptr [7FFE77C977F8]
       int       3
M00_L09:
       call      qword ptr [7FFE776FFD68]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L10
       call      qword ptr [7FFE77B37180]
       mov       rbx,rax
M00_L10:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2D67CD3AC70
       call      qword ptr [7FFE77B37198]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       call      qword ptr [7FFE77A7D578]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M00_L13
       jmp       near ptr M00_L00
M00_L12:
       call      qword ptr [7FFE77A7D578]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       je        near ptr M00_L01
M00_L13:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFE77C94528]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L14:
       mov       ecx,3888
       mov       rdx,7FFE777A9C30
       call      qword ptr [7FFE775176F0]
       mov       rcx,rax
       call      qword ptr [7FFE77B3FFD8]
       int       3
M00_L15:
       mov       rcx,rdi
       call      qword ptr [7FFE77796CA0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L02
M00_L16:
       mov       rcx,rdi
       call      qword ptr [7FFE7779C4E0]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rcx,rax
       jmp       near ptr M00_L04
M00_L17:
       call      qword ptr [7FFE77C977E0]
       int       3
M00_L18:
       mov       rcx,rbp
       call      qword ptr [7FFE77886238]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L05
M00_L19:
       mov       rdx,rbp
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L20:
       lea       rcx,[rsp+40]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FFE77514DB0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
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
       vmovups   ymm0,[7FFE77C60560]
       vmovups   [rdx],ymm0
       vmovups   ymm0,[7FFE77C60580]
       vmovups   [rdx+20],ymm0
       vmovups   xmm0,[7FFE77C605A0]
       vmovups   [rdx+40],xmm0
       mov       word ptr [rdx+50],20
       mov       ecx,[rsp+50]
       add       ecx,29
       mov       [rsp+50],ecx
       jmp       short M00_L22
M00_L21:
       lea       rcx,[rsp+40]
       mov       rdx,2D67CD3B438
       call      qword ptr [7FFE77B342E8]
M00_L22:
       lea       rcx,[rsp+40]
       mov       rdx,7FFE77A954B8
       mov       r8,2D67CD39FF0
       call      qword ptr [7FFE7751E058]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ecx,[rsp+50]
       cmp       ecx,[rsp+60]
       jbe       short M00_L24
M00_L23:
       call      qword ptr [7FFE774370D8]
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
       mov       rdx,2D67CD20658
       call      qword ptr [7FFE77B342E8]
M00_L26:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE77514DE0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE776F5AB8]
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
       mov       rcx,295E7C01938
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L04
M01_L00:
       mov       rcx,7FFE77D28EA4
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       [rdi],dil
       test      rbx,rbx
       je        near ptr M01_L05
       mov       r15,[rdi+8]
       mov       rcx,[r15+8]
       cmp       byte ptr [rdi+19],0
       jne       short M01_L03
       mov       rdx,rbx
       mov       r11,7FFE771E0E00
       call      qword ptr [r11]
       mov       r13d,eax
M01_L01:
       lea       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,rbx
       mov       r9d,r13d
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      qword ptr [7FFE776F6148]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L06
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
       jmp       short M01_L01
M01_L04:
       mov       rcx,7FFE77D28EA0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FFE771DD050
       call      qword ptr [7FFE77296E68]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,295E7C01938
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L05:
       mov       ecx,1
       mov       rdx,7FFE7763FC38
       call      qword ptr [7FFE775176F0]
       mov       rcx,rax
       call      qword ptr [7FFE77885FB0]
       int       3
M01_L06:
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
       call      qword ptr [7FFE776FC000]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M01_L02
; Total bytes of code 392
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
       mov       rax,0DD13E48037A0
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
       mov       rcx,295E7C01DD0
       mov       r14,[rcx]
       mov       r15,r14
       lea       r13d,[rdi+rdi*2]
       mov       rcx,295E7C00C90
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
       cmp       dword ptr [rcx+238],0B
       jle       near ptr M02_L17
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+58]
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
       call      qword ptr [7FFE77797900]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
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
       call      qword ptr [7FFE77904E88]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
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
       call      qword ptr [7FFE77904F18]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rax,[rbp+80]
       xor       ecx,ecx
       mov       [rbp+80],rcx
       mov       [rbp+30],rax
       jmp       near ptr M02_L13
M02_L07:
       call      qword ptr [7FFE774370D8]
       int       3
M02_L08:
       mov       ecx,38A0
       mov       rdx,7FFE777A9C30
       call      qword ptr [7FFE775176F0]
       mov       rcx,rax
       call      qword ptr [7FFE77C9E3B8]
       int       3
M02_L09:
       mov       ecx,38A0
       mov       rdx,7FFE777A9C30
       call      qword ptr [7FFE775176F0]
       mov       rcx,rax
       call      qword ptr [7FFE77C9E3D0]
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
       mov       rcx,0DD13E48037A0
       cmp       [rbp],rcx
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
       call      qword ptr [7FFE77796D60]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       jmp       near ptr M02_L03
M02_L17:
       mov       ecx,0B
       call      qword ptr [7FFE77794450]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M02_L01
M02_L18:
       mov       [rbp+28],r8
       mov       rcx,r8
       call      qword ptr [7FFE7779C660]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13,[rbp+28]
       mov       eax,[r13+8]
       mov       [rbp+224],eax
       mov       rcx,r14
       call      qword ptr [7FFE7779C660]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r14d,[rbp+234]
       mov       [rsp+20],r14d
       mov       edx,r15d
       mov       r8d,[rbp+224]
       mov       rcx,r12
       call      qword ptr [7FFE77B36F58]
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
       call      qword ptr [7FFE77A7EC70]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FFE7788D230]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFE77296820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFE7779C660]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+228],eax
       mov       rcx,r15
       call      qword ptr [7FFE7779C660]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rbp+234]
       mov       [rsp+20],r15d
       mov       edx,r14d
       mov       r8d,[rbp+228]
       mov       rcx,r12
       call      qword ptr [7FFE77B36F58]
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
       mov       r8,2D67CD262A0
       jmp       near ptr M02_L02
M02_L32:
       mov       ecx,r13d
       mov       rdx,2D67CD26F28
       call      qword ptr [7FFE7751D7B8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFE779A7438]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M02_L35:
       cmp       byte ptr [r12+9D],0
       je        near ptr M02_L37
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFE7779C660]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+230],eax
       mov       rcx,r15
       call      qword ptr [7FFE7779C660]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,[rbp+230]
       mov       rcx,r12
       call      qword ptr [7FFE77B36F58]
       mov       eax,[r13+8]
       mov       [rbp+22C],eax
       mov       rcx,r15
       call      qword ptr [7FFE7779C660]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE77B36FA0]
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
       call      qword ptr [7FFE772957E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,295E7C01DD0
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
       cmp       dword ptr [rcx+238],0B
       jle       short M02_L40
       mov       rcx,[rcx+240]
       mov       rax,[rcx+58]
       test      rax,rax
       jne       short M02_L41
M02_L40:
       mov       ecx,0B
       call      qword ptr [7FFE77794450]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M02_L41:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L42
       mov       rcx,rbx
       call      qword ptr [7FFE779AF360]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
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
       call      qword ptr [7FFE77B37330]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FFE771D4000
       call      qword ptr [7FFE775176F0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE776F5B60]
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
       call      qword ptr [7FFE77C9EDC0]
M02_L44:
       mov       r14,[rax+8]
       call      qword ptr [7FFE77A7EC70]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FFE7788D230]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFE77296820]; System.Threading.Monitor.Exit(System.Object)
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
       mov       rcx,295E7C00C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       je        near ptr M02_L58
       mov       rcx,[rbp+38]
       cmp       dword ptr [rcx+8],0
       je        near ptr M02_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FFE7779C660]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp+38]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFE7779C660]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FFE77C9CF90]
       test      r14d,edi
       jne       short M02_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FFE7779C660]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,[rbp+38]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FFE7779C660]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE77B373A8]
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
       call      qword ptr [7FFFAFF9F478]
       cmp       byte ptr [rax],0
       je        near ptr M04_L04
       call      qword ptr [7FFFAFFA5968]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M04_L00
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFFAFF9F230]; CORINFO_HELP_ASSIGN_REF
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFFAFFA1550]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M04_L02
M04_L01:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L02:
       call      qword ptr [7FFFAFF9F470]
       cmp       byte ptr [rax],0
       je        short M04_L01
       xorps     xmm0,xmm0
       movups    [rsp+30],xmm0
       mov       [rsp+30],rdi
       mov       [rsp+38],rsi
       lea       rcx,[rsp+20]
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       lea       r8,[rsp+30]
       mov       r9d,2
       call      qword ptr [7FFFAFFA6E98]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFFAFFA5998]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FFFAFF9F230]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M04_L01
       cmp       [rsi+10],rbx
       je        short M04_L03
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+9F],0
       jne       short M04_L03
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFFAFFA5250]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M04_L01
M04_L03:
       mov       rcx,[rsi+8]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M04_L01
M04_L04:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L05
       call      qword ptr [7FFFAFFA1568]
       test      rax,rax
       je        near ptr M04_L01
M04_L05:
       call      qword ptr [7FFFAFFA3BD0]
       int       3
; Total bytes of code 286
```
```assembly
; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFFAFFA52F8]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFFAFFA32C0]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       call      00007FFED6E20370
       test      eax,eax
       jne       short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FFE77C94D20]
M06_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M06_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M06_L03
       mov       rcx,7FFE77D31048
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FFE77886250]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M06_L04
M06_L02:
       xor       ecx,ecx
       call      qword ptr [7FFE77B3FFD8]
       int       3
M06_L03:
       mov       rcx,7FFE77D31044
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE77C977E0]
       int       3
M06_L04:
       mov       rcx,7FFE77D3104C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FFED6E6FFC0
       test      eax,eax
       jne       near ptr M06_L10
M06_L05:
       mov       rcx,7FFE77D31050
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFE77D31054
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L06:
       call      qword ptr [7FFE77C9C318]
       int       3
M06_L07:
       mov       rcx,7FFE77D31040
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE77C977E0]
       int       3
M06_L08:
       mov       rcx,rbx
       call      qword ptr [7FFE7779C510]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M06_L09
       call      qword ptr [7FFE77C944F8]
       int       3
M06_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFED6E8EEF0
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M06_L00
M06_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE77C94900]
       jmp       near ptr M06_L05
       sub       rsp,28
       call      qword ptr [7FFE77C9C330]
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
       mov       rcx,7FFE77D3104C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M06_L11
       xor       ecx,ecx
       call      qword ptr [7FFE77B3FFD8]
       int       3
M06_L11:
       mov       rcx,[rbp-20]
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M06_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFE77C94900]
M06_L12:
       mov       rcx,7FFE77D31050
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
       jmp       qword ptr [7FFE7729FCA8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       mov       rcx,295E7C00C88
       mov       rsi,[rcx]
       imul      ecx,r8d,0B
       add       ecx,edx
       mov       edi,100
       cmp       ecx,100
       cmovg     edi,ecx
       mov       rcx,rsi
       mov       rdx,7FFE77D531E0
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
       je        short M09_L01
       mov       rcx,rsi
       call      qword ptr [7FFED6CFD260]
       test      rax,rax
       jne       short M09_L02
       mov       rcx,rsi
       lea       r11,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       call      qword ptr [r11]
       mov       rdx,rax
M09_L00:
       test      rdx,rdx
       je        short M09_L01
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
       call      qword ptr [7FFED6D03A28]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
M09_L01:
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M09_L02:
       mov       rcx,rsi
       call      qword ptr [7FFED6CFD298]
       test      rax,rax
       je        short M09_L04
       mov       rcx,rsi
       call      qword ptr [7FFED6CFE4D8]
       mov       rsi,rax
M09_L03:
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
       je        short M09_L06
       mov       ecx,[rsp+48]
       add       [rbx+10],ecx
       jmp       near ptr M09_L01
M09_L04:
       mov       rcx,rsi
       call      qword ptr [7FFED6CFE4D0]
       mov       rcx,rax
       mov       r8,[rbx]
       lea       r11,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M09_L00
M09_L05:
       call      qword ptr [7FFED6CF6128]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFED6D1A8E8]
       jmp       near ptr M09_L01
M09_L06:
       mov       rcx,rbx
       call      qword ptr [7FFED6D0B170]
       jmp       near ptr M09_L03
M09_L07:
       call      qword ptr [7FFED6D053B8]
       int       3
M09_L08:
       mov       rcx,rbx
       call      qword ptr [7FFED6D0B148]
       jmp       near ptr M09_L01
; Total bytes of code 393
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
       mov       rcx,295E7C00C88
       mov       rbx,[rcx]
       mov       ecx,[rdi+8]
       dec       ecx
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
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
       mov       rcx,295E7C00C90
       mov       r13,[rcx]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M10_L23
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
       jae       near ptr M10_L26
       mov       edx,ebp
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       je        near ptr M10_L17
M10_L05:
       mov       r15,[rax+8]
       call      qword ptr [7FFE77A7EC70]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       jle       near ptr M10_L22
       mov       [rsp+40],eax
M10_L06:
       cmp       r13d,eax
       jae       near ptr M10_L26
       mov       ecx,r13d
       mov       r8,[r15+rcx*8+10]
       mov       [rsp+38],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rsp+60],r10d
       mov       rcx,r8
       call      00007FFED6E20370
       test      eax,eax
       je        near ptr M10_L18
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
       call      00007FFED6E6FFC0
       test      eax,eax
       jne       near ptr M10_L19
M10_L10:
       cmp       dword ptr [rsp+60],0
       je        near ptr M10_L20
       mov       r15d,1
M10_L11:
       jmp       near ptr M10_L02
M10_L12:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       short M10_L08
M10_L13:
       call      qword ptr [7FFE774370D8]
       int       3
M10_L14:
       mov       ecx,3
       call      qword ptr [7FFE77794450]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M10_L00
M10_L15:
       mov       rcx,rbx
       call      qword ptr [7FFE7751CE10]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M10_L01
M10_L16:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE77B37330]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFE771D4000
       call      qword ptr [7FFE775176F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE776F5B60]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M10_L17:
       mov       rcx,rbx
       mov       edx,ebp
       call      qword ptr [7FFE77A7EB38]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].CreatePerCorePartitions(Int32)
       jmp       near ptr M10_L05
M10_L18:
       mov       rcx,[rsp+38]
       call      qword ptr [7FFE77C94D20]
       jmp       near ptr M10_L07
M10_L19:
       mov       ecx,eax
       mov       rdx,[rsp+38]
       call      qword ptr [7FFE77C94900]
       jmp       near ptr M10_L10
M10_L20:
       inc       r13d
       mov       ecx,[rsp+44]
       cmp       ecx,r13d
       jne       short M10_L21
       xor       r13d,r13d
M10_L21:
       mov       edx,[rsp+40]
       dec       edx
       mov       [rsp+40],edx
       mov       eax,ecx
       jne       near ptr M10_L06
M10_L22:
       xor       r15d,r15d
       jmp       near ptr M10_L11
M10_L23:
       cmp       dword ptr [rdi+8],0
       je        near ptr M10_L03
       mov       rcx,rdi
       call      qword ptr [7FFE7779C660]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       eax,[rdi+8]
       mov       [rsp+64],eax
       mov       rcx,rbx
       call      qword ptr [7FFE7779C660]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r13
       mov       r8d,r12d
       mov       r9d,[rsp+64]
       mov       edx,3
       call      qword ptr [7FFE77C9CF90]
       test      r15d,r14d
       jne       near ptr M10_L03
       mov       rcx,rdi
       call      qword ptr [7FFE7779C660]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       edi,[rdi+8]
       mov       rcx,rbx
       call      qword ptr [7FFE7779C660]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r14d,r14d
       jne       short M10_L24
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M10_L25
M10_L24:
       mov       ecx,ebp
       xor       edx,edx
M10_L25:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r13
       mov       edx,r15d
       mov       r8d,edi
       call      qword ptr [7FFE77B373A8]
       jmp       near ptr M10_L03
M10_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 913
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       mov       r8,7FFED6077E60
       movzx     eax,byte ptr [r8+rax]
       shl       eax,6
       mov       r8d,edx
       shr       r8d,3
       and       r8d,3E
       add       eax,r8d
       mov       r8,7FFED6075968
       movzx     eax,word ptr [r8+rax]
       shl       eax,4
       and       edx,0F
       add       edx,eax
       mov       rax,7FFED607DC40
       movzx     edx,byte ptr [rax+rdx]
       mov       rax,7FFED6086710
       cmp       byte ptr [rax+rdx],0
       jl        near ptr M00_L16
       jmp       short M00_L01
M00_L00:
       mov       edx,edx
       mov       rax,7FFED6077778
       test      byte ptr [rax+rdx],80
       jne       near ptr M00_L16
M00_L01:
       dec       ecx
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jl        short M00_L02
       mov       edx,ecx
       shr       edx,9
       mov       rax,7FFED6077E60
       movzx     edx,byte ptr [rax+rdx]
       shl       edx,6
       mov       eax,ecx
       shr       eax,3
       and       eax,3E
       add       edx,eax
       mov       rax,7FFED6075968
       movzx     edx,word ptr [rax+rdx]
       shl       edx,4
       and       ecx,0F
       add       ecx,edx
       mov       rdx,7FFED607DC40
       movzx     ecx,byte ptr [rdx+rcx]
       mov       rdx,7FFED6086710
       cmp       byte ptr [rdx+rcx],0
       jl        near ptr M00_L16
       jmp       short M00_L03
M00_L02:
       mov       ecx,ecx
       mov       rdx,7FFED6077778
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
       mov       rdx,1CDD6002660
       mov       r14,[rdx]
       mov       rdx,[r14+10]
       mov       rcx,rsi
       mov       r8,r14
       xor       r9d,r9d
       call      qword ptr [7FFE77B57090]; System.Xml.XmlTextReaderImpl..ctor(System.Xml.XmlResolver, System.Xml.XmlReaderSettings, System.Xml.XmlParserContext)
       mov       rcx,20E6B1C0008
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
       mov       rcx,1CDD6002550
       mov       rdx,[rcx]
       lea       rcx,[rsi+190]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       byte ptr [rsi+178],0
       sete      cl
       mov       [rsi+1EF],cl
       mov       byte ptr [rsi+1EC],1
       mov       rcx,rsi
       call      qword ptr [7FFE77B57348]; System.Xml.XmlTextReaderImpl.ReadData()
       mov       rdx,[rsi+190]
       lea       rcx,[rsi+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M00_L07
       cmp       [rcx],ecx
       call      qword ptr [7FFE77DC4750]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[rsi+8]
       mov       rdx,[rdx+30]
       mov       rcx,rsi
       call      qword ptr [7FFE77DC4768]
M00_L07:
       xor       ecx,ecx
       mov       [rsi+8],rcx
M00_L08:
       mov       [rbp-68],rsi
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,20E6B1CF9F0
       xor       r8d,r8d
       call      qword ptr [7FFE77A95608]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       vmovdqu   ymm0,ymmword ptr [r14+38]
       vmovdqu   ymmword ptr [rbp-58],ymm0
       mov       r9,[r14+58]
       mov       [rbp-38],r9
       lea       r9,[rbp-58]
       mov       rdx,rsi
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FFE77B573C0]; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
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
       call      qword ptr [7FFE77B56898]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE77715A88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       cmp       dword ptr [rsi+160],4
       je        short M00_L12
       movzx     edx,byte ptr [rsi+17D]
       mov       rcx,rsi
       call      qword ptr [7FFE77B5C210]; System.Xml.XmlTextReaderImpl.Close(Boolean)
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
       mov       rcx,[rbx+18]
       lea       r8,[rbp-30]
       mov       rdx,7FFE77BBD2F0
       cmp       [rcx],ecx
       call      qword ptr [7FFE77B5C270]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE7771FD38]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L15
       call      qword ptr [7FFE77DC6D90]
       mov       rbx,rax
M00_L15:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,20E6B1D1150
       call      qword ptr [7FFE77C05B00]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L16:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFE77C05488]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L17:
       mov       ecx,11
       call      qword ptr [7FFE7753C180]
       int       3
M00_L18:
       mov       rcx,rdi
       call      00007FFED6EA5FF0
       jmp       near ptr M00_L13
       sub       rsp,28
       mov       rcx,[rbp-68]
       cmp       dword ptr [rcx+160],4
       je        short M00_L19
       movzx     edx,byte ptr [rcx+17D]
       call      qword ptr [7FFE77B5C210]; System.Xml.XmlTextReaderImpl.Close(Boolean)
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
       call      00007FFED6EA5FF0
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
       mov       r14,20E6B1C0008
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
       call      qword ptr [7FFE77DC47F8]; System.Threading.Tasks.Task`1[[System.ValueTuple`4[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.ValueTuple`4<Int32,Int32,Int32,Boolean>)
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
       call      qword ptr [7FFE77B57228]; System.Xml.XmlNamespaceManager..ctor(System.Xml.XmlNameTable)
       lea       rcx,[rbx+40]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M01_L04:
       mov       rcx,offset MT_System.Xml.NameTable
       cmp       [r15],rcx
       jne       near ptr M01_L27
       mov       rcx,[r15+8]
       mov       r13d,[r15+14]
       and       r13d,0D17B111E
       mov       eax,r13d
       cmp       eax,[rcx+8]
       jae       near ptr M01_L30
       mov       r12,[rcx+rax*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M01_L07
M01_L05:
       cmp       dword ptr [rcx+18],0D17B111E
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
       mov       rcx,20E6B1D1150
       mov       [rax+8],rcx
       mov       dword ptr [rax+18],0D17B111E
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
       mov       rcx,20E6B1D11DC
       mov       eax,54DCB6D
       mov       edx,0E5737DE6
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
       mov       rcx,20E6B1D11D0
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
       mov       r10,20E6B1D11D0
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
       call      qword ptr [7FFE77B574E0]; System.Xml.NameTable.Grow()
       jmp       near ptr M01_L14
M01_L21:
       lea       rcx,[rsp+40]
       cmp       qword ptr [rcx],0
       jne       near ptr M01_L01
       mov       rdx,1CDD6002668
       mov       rdx,[rdx]
       jmp       near ptr M01_L02
M01_L22:
       mov       rdx,[rcx+8]
       mov       rax,rdx
       mov       r8,20E6B1D1150
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
       call      qword ptr [7FFE77B574E0]; System.Xml.NameTable.Grow()
       jmp       near ptr M01_L08
M01_L25:
       mov       byte ptr [rbx+177],1
       jmp       near ptr M01_L03
M01_L26:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE77DC4810]
       mov       r15,[rbx+28]
       jmp       near ptr M01_L04
M01_L27:
       mov       rcx,r15
       mov       rdx,r14
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,r15
       mov       rdx,20E6B1D1150
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       lea       rcx,[rbx+0D0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,20E6B1D11D0
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       jmp       near ptr M01_L15
M01_L28:
       cmp       eax,2
       ja        near ptr M01_L16
       mov       eax,eax
       lea       rcx,[7FFE77E3C8B0]
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
       call      qword ptr [7FFE772B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       r8,rax
       mov       edx,r15d
       mov       ecx,r14d
       call      qword ptr [7FFE77DC4228]
       int       3
M02_L16:
       mov       ecx,17F
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       r8,rax
       mov       edx,r15d
       mov       ecx,edi
       call      qword ptr [7FFE77DC4228]
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
       call      qword ptr [7FFE77DC46D8]
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
       call      qword ptr [7FFE7745DEA8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFE7745DEA8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFE77DC46D8]
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
       call      qword ptr [7FFE7745DEA8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFE7745DEA8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFE7745DEA8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFE77DC4708]
       mov       esi,eax
       test      esi,esi
       jne       near ptr M02_L08
       cmp       [rbx+1D8],edi
       je        near ptr M02_L08
       jmp       near ptr M02_L00
M02_L33:
       mov       ecx,13D06
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE77C04EE8]
       int       3
M02_L34:
       mov       ecx,28F
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FFE77C04EE8]
       int       3
M02_L35:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE77C06628]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE7753FC90]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L36:
       call      qword ptr [7FFE77DC4720]
       int       3
M02_L37:
       mov       ecx,28F
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE77C04EE8]
       int       3
M02_L38:
       mov       ecx,167
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FFE77C04EE8]
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
       mov       rcx,20E6B1DACA0
       call      qword ptr [7FFE77DC40F0]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,20E6B1DACD8
       call      qword ptr [7FFE77DC4738]
       jmp       short M02_L43
M02_L42:
       mov       [rbx+0F8],r14
M02_L43:
       mov       rcx,[rbx+0F8]
       cmp       rcx,[rbx+0E8]
       jle       near ptr M02_L09
       mov       rcx,20E6B1DACA0
       call      qword ptr [7FFE77DC40F0]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,20E6B1DACD8
       call      qword ptr [7FFE77DC4738]
       jmp       near ptr M02_L09
M02_L44:
       add       rdi,[rbx+100]
       cmp       rdi,[rbx+100]
       jge       short M02_L45
       mov       rcx,20E6B1DACA0
       call      qword ptr [7FFE77DC40F0]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,20E6B1DAD20
       call      qword ptr [7FFE77DC4738]
       jmp       short M02_L46
M02_L45:
       mov       [rbx+100],rdi
M02_L46:
       mov       rcx,[rbx+100]
       cmp       rcx,[rbx+0F0]
       jle       near ptr M02_L10
       mov       rcx,20E6B1DACA0
       call      qword ptr [7FFE77DC40F0]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,20E6B1DAD20
       call      qword ptr [7FFE77DC4738]
       jmp       near ptr M02_L10
M02_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1851
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
       je        near ptr M03_L18
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       jne       near ptr M03_L19
M03_L00:
       mov       rcx,1CDD6001FB8
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
       mov       r11,7FFE772014D0
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
       jne       near ptr M03_L20
       cmp       ecx,[r14+38]
       jne       near ptr M03_L20
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
       cmp       dword ptr [7FFE771FB160],1
       je        near ptr M03_L14
       mov       rcx,1CDD6001FF0
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
       mov       r11,7FFE772014E0
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
       jne       near ptr M03_L17
       mov       rdx,[r9]
       mov       rcx,r12
       mov       r8,r15
       mov       r11,7FFE772014E8
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-98]
       je        near ptr M03_L17
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
       call      qword ptr [7FFE77B573A8]; System.Xml.Serialization.XmlReflectionImporter.GetTopLevelMapping(System.Type, System.String)
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
       jne       near ptr M03_L23
       cmp       [r14+8],r11
       je        near ptr M03_L23
       cmp       r11,rsi
       jne       near ptr M03_L21
M03_L16:
       mov       rdx,r12
       jmp       near ptr M03_L06
M03_L17:
       mov       edx,[r9+14]
       mov       r10d,[rbp-78]
       inc       r10d
       cmp       [r13+8],r10d
       jae       near ptr M03_L29
       call      qword ptr [7FFE77537960]
       int       3
M03_L18:
       mov       ecx,0EB9B
       mov       rdx,7FFE779EE358
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE77C04F18]
       int       3
M03_L19:
       mov       rcx,rdi
       mov       rdx,20E6B1C0008
       call      qword ptr [7FFE772BC7F8]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       near ptr M03_L00
       jmp       near ptr M03_L08
M03_L20:
       lea       rcx,[rbp-60]
       mov       edx,14
       call      qword ptr [7FFE77DC4588]
       mov       eax,[rbp-58]
       mov       r9,[rbp-88]
       jmp       near ptr M03_L04
M03_L21:
       cmp       qword ptr [r14+20],0
       je        short M03_L22
       mov       rcx,[r14+20]
       mov       r8,rsi
       mov       rdx,r11
       mov       r11,7FFE772014D8
       call      qword ptr [r11]
       jmp       short M03_L24
M03_L22:
       mov       rcx,r11
       mov       rdx,rsi
       mov       r9,[r11]
       mov       r9,[r9+40]
       call      qword ptr [r9+10]
       jmp       short M03_L24
M03_L23:
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
       jmp       short M03_L25
M03_L24:
       test      eax,eax
       je        short M03_L23
       jmp       near ptr M03_L16
M03_L25:
       mov       r10d,[rbp-54]
       inc       r10d
       cmp       r13d,r10d
       mov       [rbp-54],r10d
       mov       eax,ecx
       jg        near ptr M03_L03
       jmp       near ptr M03_L05
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
       call      qword ptr [7FFE77DC4858]
       mov       rcx,rsi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE77A9E940]; System.Xml.Serialization.XmlMapping.GenerateKey(System.Type, System.Xml.Serialization.XmlRootAttribute, System.String)
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
       ja        near ptr M03_L10
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
       call      qword ptr [7FFE77A95E60]; System.Runtime.CompilerServices.ConditionalWeakTable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M03_L12
       lea       r8,[rbp-68]
       mov       rcx,[rbp-70]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE77329680]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       jmp       near ptr M03_L12
M03_L32:
       mov       rdx,1CDD6001FF0
       mov       rcx,[rdx]
       mov       [rbp-90],rcx
       xor       edx,edx
       mov       [rbp-40],edx
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE772B5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1CDD6001FF0
       mov       rcx,[rcx]
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE77A95E48]; System.Xml.Serialization.TempAssemblyCache.get_Item(System.String, System.Type)
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
       call      qword ptr [7FFE77A95E78]; System.Xml.Serialization.TempAssembly.LoadGeneratedAssembly(System.Type, System.String, System.Xml.Serialization.XmlSerializerImplementation ByRef)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M03_L34
       cmp       dword ptr [7FFE771FB160],3
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
       call      qword ptr [7FFE77A960B8]; System.Xml.Serialization.Compiler.GetTempAssemblyName(System.Reflection.AssemblyName, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.IO.FileLoadException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE77DC4888]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFE77DC48A0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE77DC48B8]
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
       call      qword ptr [7FFE77A966E8]; System.Xml.Serialization.XmlReflectionImporter..ctor(System.Xml.Serialization.XmlAttributeOverrides, System.String)
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE77A96748]; System.Xml.Serialization.XmlReflectionImporter.ImportTypeMapping(System.Type, System.Xml.Serialization.XmlRootAttribute, System.String)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+18]
       mov       rdx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FFE77A9EB38]; System.Xml.Serialization.XmlSerializer.GenerateTempAssembly(System.Xml.Serialization.XmlMapping, System.Type, System.String, System.String)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L35
M03_L34:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFE77B573A8]; System.Xml.Serialization.XmlReflectionImporter.GetTopLevelMapping(System.Type, System.String)
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
       call      qword ptr [7FFE77DC48D0]
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M03_L35:
       mov       r9,[rbx+8]
       mov       rcx,1CDD6001FF0
       mov       rcx,[rcx]
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE77AFC8A0]; System.Xml.Serialization.TempAssemblyCache.Add(System.String, System.Type, System.Xml.Serialization.TempAssembly)
       nop
       cmp       byte ptr [rbp-40],0
       je        near ptr M03_L13
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE772B6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M03_L13
M03_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-40],0
       je        short M03_L37
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE772B6820]; System.Threading.Monitor.Exit(System.Object)
M03_L37:
       nop
       add       rsp,28
       ret
; Total bytes of code 1763
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
       cmp       dword ptr [7FFE771FB160],1
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
       call      qword ptr [7FFE77B57408]; System.Xml.Serialization.TempAssembly.InvokeReader(System.Xml.Serialization.XmlMapping, System.Xml.XmlReader, System.Xml.Serialization.XmlDeserializationEvents, System.String)
       jmp       near ptr M04_L05
M04_L01:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r8,rdi
       mov       r9,rbx
       call      qword ptr [7FFE77DC7198]
       jmp       near ptr M04_L05
M04_L02:
       test      rdi,rdi
       je        short M04_L03
       cmp       dword ptr [rdi+8],0
       jle       short M04_L03
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77DC4BB8]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFE77DC48A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77715A88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L03:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r8,rbx
       call      qword ptr [7FFE77DC4BD0]
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
       call      qword ptr [7FFE77B57468]; System.Xml.Serialization.XmlSerializationReader.Init(System.Xml.XmlReader, System.Xml.Serialization.XmlDeserializationEvents, System.String)
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
       call      qword ptr [7FFE77534E10]
       mov       rbx,rax
       jmp       short M04_L06
M04_L08:
       call      qword ptr [7FFE77DC4C18]
       mov       rdi,rax
       mov       rcx,rsi
       mov       r11,7FFE77201428
       call      qword ptr [r11]
       mov       [rbp-28],eax
       call      qword ptr [7FFE779B4840]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FFE77B546D8]; System.Int32.ToString(System.IFormatProvider)
       mov       r14,rax
       mov       rcx,rsi
       mov       r11,7FFE77201430
       call      qword ptr [r11]
       mov       [rbp-28],eax
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE779B4840]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FFE77B546D8]; System.Int32.ToString(System.IFormatProvider)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FFE77DC4A20]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFE777C5788]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE77DC4C30]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFE777C5788]
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
       jmp       qword ptr [7FFE772BFC90]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       je        near ptr M06_L07
M06_L00:
       cmp       dword ptr [rbx+13C],0
       jge       near ptr M06_L09
       lea       rdi,[rbx+188]
       test      sil,sil
       je        near ptr M06_L05
       cmp       qword ptr [rdi+10],0
       jne       short M06_L02
       mov       rdi,[rdi+28]
       test      rdi,rdi
       je        near ptr M06_L05
       mov       rcx,offset MT_System.IO.StringReader
       cmp       [rdi],rcx
       jne       near ptr M06_L11
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       [rdi+10],ecx
M06_L01:
       mov       rcx,rdi
       call      qword ptr [7FFE772B7AB0]; System.GC.SuppressFinalize(System.Object)
       jmp       short M06_L05
M06_L02:
       mov       rsi,[rdi+10]
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.IO.FileStream
       cmp       rdi,rcx
       jne       near ptr M06_L08
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        short M06_L04
       mov       rax,[rcx]
       mov       rdx,offset MT_System.IO.Strategies.BufferedFileStreamStrategy
       cmp       rax,rdx
       je        short M06_L03
       mov       edx,1
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       jmp       short M06_L04
M06_L03:
       mov       edx,1
       call      qword ptr [7FFE7760BEC0]
M06_L04:
       test      dword ptr [rdi],100000
       jne       near ptr M06_L10
M06_L05:
       mov       rcx,1CDD6002680
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M06_L12
M06_L06:
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+108],0C
       xor       eax,eax
       mov       [rbx+68],rax
       mov       rax,20E6B1C0008
       mov       [rbx+60],rax
       mov       dword ptr [rbx+160],4
       mov       byte ptr [rbx+176],0
       mov       eax,0FFFFFFFF
       mov       [rbx+118],rax
       xor       eax,eax
       mov       [rbx+120],rax
       mov       [rbx+8],rax
M06_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L08:
       mov       rcx,rsi
       mov       rax,[rdi+50]
       call      qword ptr [rax+18]
       jmp       short M06_L05
M06_L09:
       mov       rcx,rbx
       call      qword ptr [7FFE77DC50F8]
       jmp       near ptr M06_L00
M06_L10:
       mov       rcx,rsi
       call      00007FFED6EA5FF0
       jmp       near ptr M06_L05
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
       call      qword ptr [7FFE77DC5110]
       mov       rcx,1CDD6002680
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M06_L06
; Total bytes of code 429
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

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       mov       r8,7FFED6077E60
       movzx     eax,byte ptr [r8+rax]
       shl       eax,6
       mov       r8d,edx
       shr       r8d,3
       and       r8d,3E
       add       eax,r8d
       mov       r8,7FFED6075968
       movzx     eax,word ptr [r8+rax]
       shl       eax,4
       and       edx,0F
       add       edx,eax
       mov       rax,7FFED607DC40
       movzx     edx,byte ptr [rax+rdx]
       mov       rax,7FFED6086710
       cmp       byte ptr [rax+rdx],0
       jl        near ptr M00_L16
       jmp       short M00_L01
M00_L00:
       mov       edx,edx
       mov       rax,7FFED6077778
       test      byte ptr [rax+rdx],80
       jne       near ptr M00_L16
M00_L01:
       dec       ecx
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jl        short M00_L02
       mov       edx,ecx
       shr       edx,9
       mov       rax,7FFED6077E60
       movzx     edx,byte ptr [rax+rdx]
       shl       edx,6
       mov       eax,ecx
       shr       eax,3
       and       eax,3E
       add       edx,eax
       mov       rax,7FFED6075968
       movzx     edx,word ptr [rax+rdx]
       shl       edx,4
       and       ecx,0F
       add       ecx,edx
       mov       rdx,7FFED607DC40
       movzx     ecx,byte ptr [rdx+rcx]
       mov       rdx,7FFED6086710
       cmp       byte ptr [rdx+rcx],0
       jl        near ptr M00_L16
       jmp       short M00_L03
M00_L02:
       mov       ecx,ecx
       mov       rdx,7FFED6077778
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
       mov       rdx,1FD4C000668
       mov       r14,[rdx]
       mov       rdx,[r14+10]
       mov       rcx,rsi
       mov       r8,r14
       xor       r9d,r9d
       call      qword ptr [7FFE77B57120]; System.Xml.XmlTextReaderImpl..ctor(System.Xml.XmlResolver, System.Xml.XmlReaderSettings, System.Xml.XmlParserContext)
       mov       rcx,23DCB220008
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
       mov       rcx,1FD4C000558
       mov       rdx,[rcx]
       lea       rcx,[rsi+190]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       byte ptr [rsi+178],0
       sete      cl
       mov       [rsi+1EF],cl
       mov       byte ptr [rsi+1EC],1
       mov       rcx,rsi
       call      qword ptr [7FFE77B573D8]; System.Xml.XmlTextReaderImpl.ReadData()
       mov       rdx,[rsi+190]
       lea       rcx,[rsi+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M00_L07
       cmp       [rcx],ecx
       call      qword ptr [7FFE77DC47B0]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[rsi+8]
       mov       rdx,[rdx+30]
       mov       rcx,rsi
       call      qword ptr [7FFE77DC47C8]
M00_L07:
       xor       ecx,ecx
       mov       [rsi+8],rcx
M00_L08:
       mov       [rbp-68],rsi
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,23DCB230B20
       xor       r8d,r8d
       call      qword ptr [7FFE77A95638]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       vmovdqu   ymm0,ymmword ptr [r14+38]
       vmovdqu   ymmword ptr [rbp-58],ymm0
       mov       r9,[r14+58]
       mov       [rbp-38],r9
       lea       r9,[rbp-58]
       mov       rdx,rsi
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FFE77B57450]; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
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
       call      qword ptr [7FFE77B56928]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE77715A88]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       cmp       dword ptr [rsi+160],4
       je        short M00_L12
       movzx     edx,byte ptr [rsi+17D]
       mov       rcx,rsi
       call      qword ptr [7FFE77B5C2B8]; System.Xml.XmlTextReaderImpl.Close(Boolean)
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
       mov       rcx,[rbx+18]
       lea       r8,[rbp-30]
       mov       rdx,7FFE77BC19C0
       cmp       [rcx],ecx
       call      qword ptr [7FFE77B5C318]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE7771FD38]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L15
       call      qword ptr [7FFE77DC6DF0]
       mov       rbx,rax
M00_L15:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,23DCB231150
       call      qword ptr [7FFE77C05B90]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L16:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFE77C05518]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L17:
       mov       ecx,11
       call      qword ptr [7FFE7753C180]
       int       3
M00_L18:
       mov       rcx,rdi
       call      00007FFED6EA5FF0
       jmp       near ptr M00_L13
       sub       rsp,28
       mov       rcx,[rbp-68]
       cmp       dword ptr [rcx+160],4
       je        short M00_L19
       movzx     edx,byte ptr [rcx+17D]
       call      qword ptr [7FFE77B5C2B8]; System.Xml.XmlTextReaderImpl.Close(Boolean)
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
       call      00007FFED6EA5FF0
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
       mov       r14,23DCB220008
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
       call      qword ptr [7FFE77DC4858]; System.Threading.Tasks.Task`1[[System.ValueTuple`4[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.ValueTuple`4<Int32,Int32,Int32,Boolean>)
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
       call      qword ptr [7FFE77B572B8]; System.Xml.XmlNamespaceManager..ctor(System.Xml.XmlNameTable)
       lea       rcx,[rbx+40]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M01_L04:
       mov       rcx,offset MT_System.Xml.NameTable
       cmp       [r15],rcx
       jne       near ptr M01_L27
       mov       rcx,[r15+8]
       mov       r13d,[r15+14]
       and       r13d,0E22220EA
       mov       eax,r13d
       cmp       eax,[rcx+8]
       jae       near ptr M01_L30
       mov       r12,[rcx+rax*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M01_L07
M01_L05:
       cmp       dword ptr [rcx+18],0E22220EA
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
       mov       rcx,23DCB231150
       mov       [rax+8],rcx
       mov       dword ptr [rax+18],0E22220EA
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
       mov       rcx,23DCB2311DC
       mov       eax,51F83C5A
       mov       edx,7C29CFF8
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
       mov       rcx,23DCB2311D0
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
       mov       r10,23DCB2311D0
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
       call      qword ptr [7FFE77B57570]; System.Xml.NameTable.Grow()
       jmp       near ptr M01_L14
M01_L21:
       lea       rcx,[rsp+40]
       cmp       qword ptr [rcx],0
       jne       near ptr M01_L01
       mov       rdx,1FD4C000670
       mov       rdx,[rdx]
       jmp       near ptr M01_L02
M01_L22:
       mov       rdx,[rcx+8]
       mov       rax,rdx
       mov       r8,23DCB231150
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
       call      qword ptr [7FFE77B57570]; System.Xml.NameTable.Grow()
       jmp       near ptr M01_L08
M01_L25:
       mov       byte ptr [rbx+177],1
       jmp       near ptr M01_L03
M01_L26:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE77DC4870]
       mov       r15,[rbx+28]
       jmp       near ptr M01_L04
M01_L27:
       mov       rcx,r15
       mov       rdx,r14
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,r15
       mov       rdx,23DCB231150
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       lea       rcx,[rbx+0D0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,23DCB2311D0
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       jmp       near ptr M01_L15
M01_L28:
       cmp       eax,2
       ja        near ptr M01_L16
       mov       eax,eax
       lea       rcx,[7FFE77E3C5D0]
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
       call      qword ptr [7FFE772B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       r8,rax
       mov       edx,r15d
       mov       ecx,r14d
       call      qword ptr [7FFE77DC4288]
       int       3
M02_L16:
       mov       ecx,17F
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       r8,rax
       mov       edx,r15d
       mov       ecx,edi
       call      qword ptr [7FFE77DC4288]
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
       call      qword ptr [7FFE77DC4738]
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
       call      qword ptr [7FFE7745DEA8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFE7745DEA8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFE77DC4738]
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
       call      qword ptr [7FFE7745DEA8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFE7745DEA8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFE7745DEA8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFE77DC4768]
       mov       esi,eax
       test      esi,esi
       jne       near ptr M02_L08
       cmp       [rbx+1D8],edi
       je        near ptr M02_L08
       jmp       near ptr M02_L00
M02_L33:
       mov       ecx,13D06
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE77C04F90]
       int       3
M02_L34:
       mov       ecx,28F
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FFE77C04F90]
       int       3
M02_L35:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE77C066A0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE7753FC90]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L36:
       call      qword ptr [7FFE77DC4780]
       int       3
M02_L37:
       mov       ecx,28F
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE77C04F90]
       int       3
M02_L38:
       mov       ecx,167
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FFE77C04F90]
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
       mov       rcx,23DCB23ACA0
       call      qword ptr [7FFE77DC4150]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,23DCB23ACD8
       call      qword ptr [7FFE77DC4798]
       jmp       short M02_L43
M02_L42:
       mov       [rbx+0F8],r14
M02_L43:
       mov       rcx,[rbx+0F8]
       cmp       rcx,[rbx+0E8]
       jle       near ptr M02_L09
       mov       rcx,23DCB23ACA0
       call      qword ptr [7FFE77DC4150]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,23DCB23ACD8
       call      qword ptr [7FFE77DC4798]
       jmp       near ptr M02_L09
M02_L44:
       add       rdi,[rbx+100]
       cmp       rdi,[rbx+100]
       jge       short M02_L45
       mov       rcx,23DCB23ACA0
       call      qword ptr [7FFE77DC4150]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,23DCB23AD20
       call      qword ptr [7FFE77DC4798]
       jmp       short M02_L46
M02_L45:
       mov       [rbx+100],rdi
M02_L46:
       mov       rcx,[rbx+100]
       cmp       rcx,[rbx+0F0]
       jle       near ptr M02_L10
       mov       rcx,23DCB23ACA0
       call      qword ptr [7FFE77DC4150]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,23DCB23AD20
       call      qword ptr [7FFE77DC4798]
       jmp       near ptr M02_L10
M02_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1851
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
       mov       rcx,1FD36001FB8
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
       mov       r11,7FFE772014D0
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
       cmp       dword ptr [7FFE771FB160],1
       je        near ptr M03_L14
       mov       rcx,1FD36001FF0
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
       mov       r11,7FFE772014E0
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
       mov       r11,7FFE772014E8
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
       call      qword ptr [7FFE77B57438]; System.Xml.Serialization.XmlReflectionImporter.GetTopLevelMapping(System.Type, System.String)
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
       mov       ecx,0EB9B
       mov       rdx,7FFE779EE180
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE77C04FC0]
       int       3
M03_L20:
       mov       rcx,rdi
       mov       rdx,23DCB220008
       call      qword ptr [7FFE772BC7F8]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       near ptr M03_L00
       jmp       near ptr M03_L08
M03_L21:
       lea       rcx,[rbp-60]
       mov       edx,14
       call      qword ptr [7FFE77DC45E8]
       mov       eax,[rbp-58]
       mov       r9,[rbp-88]
       jmp       near ptr M03_L04
M03_L22:
       cmp       qword ptr [r14+20],0
       je        short M03_L23
       mov       rcx,[r14+20]
       mov       r8,rsi
       mov       rdx,r11
       mov       r11,7FFE772014D8
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
       call      qword ptr [7FFE77DC48B8]
       mov       rcx,rsi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE77A9E970]; System.Xml.Serialization.XmlMapping.GenerateKey(System.Type, System.Xml.Serialization.XmlRootAttribute, System.String)
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
       call      qword ptr [7FFE77537960]
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
       call      qword ptr [7FFE77A95E90]; System.Runtime.CompilerServices.ConditionalWeakTable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M03_L12
       lea       r8,[rbp-68]
       mov       rcx,[rbp-70]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE77329680]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       jmp       near ptr M03_L12
M03_L32:
       mov       rdx,1FD36001FF0
       mov       rcx,[rdx]
       mov       [rbp-90],rcx
       xor       edx,edx
       mov       [rbp-40],edx
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE772B5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1FD36001FF0
       mov       rcx,[rcx]
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE77A95E78]; System.Xml.Serialization.TempAssemblyCache.get_Item(System.String, System.Type)
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
       call      qword ptr [7FFE77A95EA8]; System.Xml.Serialization.TempAssembly.LoadGeneratedAssembly(System.Type, System.String, System.Xml.Serialization.XmlSerializerImplementation ByRef)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M03_L34
       cmp       dword ptr [7FFE771FB160],3
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
       call      qword ptr [7FFE77A960E8]; System.Xml.Serialization.Compiler.GetTempAssemblyName(System.Reflection.AssemblyName, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.IO.FileLoadException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE77DC48E8]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFE77DC4900]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE77DC4918]
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
       call      qword ptr [7FFE77A96718]; System.Xml.Serialization.XmlReflectionImporter..ctor(System.Xml.Serialization.XmlAttributeOverrides, System.String)
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE77A96778]; System.Xml.Serialization.XmlReflectionImporter.ImportTypeMapping(System.Type, System.Xml.Serialization.XmlRootAttribute, System.String)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+18]
       mov       rdx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FFE77A9EB68]; System.Xml.Serialization.XmlSerializer.GenerateTempAssembly(System.Xml.Serialization.XmlMapping, System.Type, System.String, System.String)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L35
M03_L34:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFE77B57438]; System.Xml.Serialization.XmlReflectionImporter.GetTopLevelMapping(System.Type, System.String)
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
       call      qword ptr [7FFE77DC4930]
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M03_L35:
       mov       r9,[rbx+8]
       mov       rcx,1FD36001FF0
       mov       rcx,[rcx]
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE77AFC8D0]; System.Xml.Serialization.TempAssemblyCache.Add(System.String, System.Type, System.Xml.Serialization.TempAssembly)
       nop
       cmp       byte ptr [rbp-40],0
       je        near ptr M03_L13
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE772B6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M03_L13
M03_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-40],0
       je        short M03_L37
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE772B6820]; System.Threading.Monitor.Exit(System.Object)
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
       cmp       dword ptr [7FFE771FB160],1
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
       call      qword ptr [7FFE77B57498]; System.Xml.Serialization.TempAssembly.InvokeReader(System.Xml.Serialization.XmlMapping, System.Xml.XmlReader, System.Xml.Serialization.XmlDeserializationEvents, System.String)
       jmp       near ptr M04_L05
M04_L01:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r8,rdi
       mov       r9,rbx
       call      qword ptr [7FFE77DC71F8]
       jmp       near ptr M04_L05
M04_L02:
       test      rdi,rdi
       je        short M04_L03
       cmp       dword ptr [rdi+8],0
       jle       short M04_L03
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77DC4C18]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFE77DC4900]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77715A88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L03:
       mov       rcx,rsi
       mov       rdx,[rbp+18]
       mov       r8,rbx
       call      qword ptr [7FFE77DC4C30]
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
       call      qword ptr [7FFE77B574F8]; System.Xml.Serialization.XmlSerializationReader.Init(System.Xml.XmlReader, System.Xml.Serialization.XmlDeserializationEvents, System.String)
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
       call      qword ptr [7FFE77534E10]
       mov       rbx,rax
       jmp       short M04_L06
M04_L08:
       call      qword ptr [7FFE77DC4C78]
       mov       rdi,rax
       mov       rcx,rsi
       mov       r11,7FFE77201428
       call      qword ptr [r11]
       mov       [rbp-28],eax
       call      qword ptr [7FFE779B4A08]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FFE77B54768]
       mov       r14,rax
       mov       rcx,rsi
       mov       r11,7FFE77201430
       call      qword ptr [r11]
       mov       [rbp-28],eax
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE779B4A08]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       rdx,rax
       lea       rcx,[rbp-28]
       call      qword ptr [7FFE77B54768]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FFE77DC4A80]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFE777C5788]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M04_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE77DC4C90]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFE777C5788]
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
       jmp       qword ptr [7FFE772BFC90]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       je        short M06_L04
       cmp       qword ptr [rdi+10],0
       jne       near ptr M06_L07
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
       call      qword ptr [7FFE772B7AB0]; System.GC.SuppressFinalize(System.Object)
       jmp       short M06_L04
M06_L02:
       mov       edx,1
       call      qword ptr [7FFE7760BEC0]
M06_L03:
       test      dword ptr [rdi],100000
       jne       near ptr M06_L10
M06_L04:
       mov       rcx,1FD4C000688
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M06_L12
M06_L05:
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+108],0C
       xor       eax,eax
       mov       [rbx+68],rax
       mov       rax,23DCB220008
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
       mov       rsi,[rdi+10]
       mov       rdi,[rsi]
       mov       rcx,offset MT_System.IO.FileStream
       cmp       rdi,rcx
       jne       short M06_L08
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        near ptr M06_L03
       mov       rax,[rcx]
       mov       rdx,offset MT_System.IO.Strategies.BufferedFileStreamStrategy
       cmp       rax,rdx
       je        near ptr M06_L02
       mov       edx,1
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       jmp       near ptr M06_L03
M06_L08:
       mov       rcx,rsi
       mov       rax,[rdi+50]
       call      qword ptr [rax+18]
       jmp       near ptr M06_L04
M06_L09:
       mov       rcx,rbx
       call      qword ptr [7FFE77DC5158]
       jmp       near ptr M06_L00
M06_L10:
       mov       rcx,rsi
       call      00007FFED6EA5FF0
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
       call      qword ptr [7FFE77DC5170]
       mov       rcx,1FD4C000688
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

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       mov       rbx,28C381C9FF0
       mov       [rbp-0F8],rbx
       mov       rax,24BA30026E8
       mov       rax,[rax]
       mov       [rbp-0A8],rax
       test      r8,r8
       je        short M00_L00
       mov       rcx,r8
       call      qword ptr [7FFE772BC960]; System.Object.GetType()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE771FA610]; System.RuntimeType.IsAssignableFrom(System.Type)
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
       mov       rdx,7FFED6E9E4E0
       call      rdx
       movzx     ebx,al
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M00_L31
M00_L02:
       cmp       ebx,0F
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,7FFED6E9E4E0
       call      rax
       movzx     ebx,al
       mov       rsi,[rbp-0F8]
       cmp       dword ptr [7FFED71EE808],0
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
       mov       rax,7FFED6E9E4E0
       call      rax
       movzx     ebx,al
       mov       rsi,[rbp-0B8]
       cmp       dword ptr [7FFED71EE808],0
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
       call      00007FFED6EA1090
       test      eax,eax
       jne       near ptr M00_L39
       mov       rsi,[rbp-0B0]
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L65
       mov       rbx,[rsi+8]
       test      rbx,rbx
       je        near ptr M00_L40
M00_L09:
       mov       rsi,[rbx+8]
       mov       rcx,24BA3001938
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M00_L10
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE771FD050
       mov       [rdi+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [rdi+20],rcx
       mov       rcx,24BA3001938
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L10:
       mov       [rbp-0C0],rsi
       cmp       [rsi],sil
       mov       r14,[rsi+8]
       mov       rcx,[r14+8]
       cmp       byte ptr [rsi+19],0
       jne       near ptr M00_L22
       mov       rdx,28C381C9FF0
       mov       r11,7FFE772011C0
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
       jae       near ptr M00_L74
       mov       edx,edx
       mov       r13,[rcx+rdx*8+10]
       test      r13,r13
       je        near ptr M00_L43
M00_L12:
       cmp       esi,[r13+20]
       jne       near ptr M00_L23
       mov       r12,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r15],rcx
       jne       near ptr M00_L42
       test      r12,r12
       je        near ptr M00_L23
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M00_L41
       mov       rcx,28C381C9FF0
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
       jne       near ptr M00_L63
       mov       rcx,[rbp-0C8]
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        short M00_L15
       cmp       byte ptr [rbx+119],2
       jne       near ptr M00_L64
M00_L15:
       test      rbx,rbx
       je        near ptr M00_L66
       cmp       byte ptr [rbx+119],2
       jne       near ptr M00_L70
M00_L16:
       mov       rsi,[rbx+0B8]
       lea       rdx,[rbp-58]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE779B72D0]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       esi,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M00_L71
       mov       rcx,[rcx+240]
       mov       rdi,[rcx+50]
       test      rdi,rdi
       je        near ptr M00_L71
M00_L17:
       mov       rax,[rdi+10]
       test      rax,rax
       jne       short M00_L18
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,28C381B62A0
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
       jne       near ptr M00_L72
       mov       rsi,28C381B1518
M00_L21:
       mov       ecx,[rsi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+78],0
       jne       near ptr M00_L26
       mov       dword ptr [r14+78],3E8
       jmp       near ptr M00_L26
M00_L22:
       mov       rcx,28C381C9FF0
       mov       rax,[7FFE771FA1C0]
       call      qword ptr [rax+18]
       mov       esi,eax
       jmp       near ptr M00_L11
M00_L23:
       mov       r13,[r13+18]
       test      r13,r13
       jne       near ptr M00_L12
       jmp       near ptr M00_L43
M00_L24:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      esi,esi
       je        near ptr M00_L73
       mov       rcx,24BA3001DD0
       mov       rcx,[rcx]
       mov       edx,esi
       call      qword ptr [7FFE779EE0C0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFE779B7420]; System.Text.Json.Utf8JsonWriter.SetOptions(System.Text.Json.JsonWriterOptions)
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
       call      qword ptr [7FFE779BF2D0]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rcx,[rbp-80]
       mov       eax,[rbp-78]
       mov       [rbp-98],rcx
       mov       [rbp-90],eax
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE779257E8]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rbx,rax
       mov       rcx,r14
       mov       rdx,[rbp-0E8]
       call      qword ptr [7FFE779BF2E8]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       [rbp-88],rbx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       lea       r8,[rbp-88]
       mov       rdx,7FFE77BC8F28
       cmp       [rcx],ecx
       call      qword ptr [7FFE77B5D0F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE77DC45A0]
       int       3
M00_L28:
       mov       edx,esi
       call      qword ptr [7FFE779B7360]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L19
M00_L29:
       mov       eax,2
       jmp       near ptr M00_L20
M00_L30:
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE777C44B0]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,[rbp-0A8]
       call      qword ptr [7FFE77AFE808]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FFE77DC4708]
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
       call      qword ptr [7FFE77BF65B0]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE77BF65C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L39:
       mov       ecx,3C7C
       mov       rdx,7FFE777B9C30
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       mov       rdx,28C381C9FF0
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE77DC4720]
       int       3
M00_L40:
       mov       rcx,rsi
       call      qword ptr [7FFE777CC4B0]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M00_L09
M00_L41:
       mov       rcx,r12
       mov       rdx,28C381C9FF0
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L13
M00_L42:
       mov       rcx,r15
       mov       r8,28C381C9FF0
       mov       rdx,r12
       mov       r11,7FFE772011C8
       call      qword ptr [r11]
       jmp       near ptr M00_L13
M00_L43:
       xor       edx,edx
       mov       [rbp-0C8],rdx
       mov       [rbp-0D0],r14
       mov       rdx,28C381C9FF0
       mov       r8,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       [rbp-0E0],rax
       mov       rbx,[r14+8]
       jmp       near ptr M00_L58
M00_L44:
       mov       rcx,[rbp-0D8]
       mov       ecx,[rcx+8]
       cmp       [rbp-3C],ecx
       jae       near ptr M00_L53
       mov       rcx,[rbp-0D8]
       mov       eax,[rbp-3C]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       short M00_L45
       xor       ecx,ecx
       call      qword ptr [7FFE77BF59F8]
       int       3
M00_L45:
       mov       rcx,r14
       call      00007FFED6E20370
       test      eax,eax
       jne       short M00_L46
       mov       rcx,r14
       call      qword ptr [7FFE77BF6778]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M00_L46:
       mov       dword ptr [rbp-48],1
       mov       rcx,[rbp-0D0]
       mov       rax,[rbp-0C0]
       cmp       rcx,[rax+8]
       je        short M00_L49
       mov       rcx,[rax+8]
       mov       [rbp-0D0],rcx
       mov       rcx,[rbp-0D0]
       cmp       rbx,[rcx+8]
       je        near ptr M00_L57
       mov       rcx,[rbp-0D0]
       mov       rbx,[rcx+8]
       cmp       byte ptr [rax+19],0
       jne       short M00_L47
       mov       rcx,rbx
       mov       rdx,28C381C9FF0
       mov       r11,7FFE772011D8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L48
M00_L47:
       mov       rcx,28C381C9FF0
       mov       rdx,[7FFE771FA1C0]
       call      qword ptr [rdx+18]
       mov       esi,eax
M00_L48:
       mov       rax,[rbp-0C0]
       jmp       near ptr M00_L57
M00_L49:
       xor       r14d,r14d
       mov       r15,[rdi]
       test      r15,r15
       je        short M00_L55
M00_L50:
       cmp       esi,[r15+20]
       jne       short M00_L51
       mov       rdx,[r15+8]
       mov       rcx,rbx
       mov       r8,28C381C9FF0
       mov       r11,7FFE772011E0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0C0]
       jne       short M00_L52
M00_L51:
       inc       r14d
       mov       r15,[r15+18]
       test      r15,r15
       jne       short M00_L50
       jmp       short M00_L55
M00_L52:
       mov       rcx,[r15+10]
       mov       [rbp-0C8],rcx
       jmp       near ptr M00_L60
M00_L53:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L54:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L55:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13,[rdi]
       mov       rcx,28C381C9FF0
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
       jae       short M00_L53
       mov       ecx,[rbp-3C]
       lea       rdx,[rdx+rcx*4+10]
       mov       ecx,[rdx]
       add       ecx,1
       jo        short M00_L54
       mov       [rdx],ecx
       mov       rdx,[rbp-0D0]
       mov       rdx,[rdx+20]
       mov       ecx,[rdx+8]
       cmp       [rbp-3C],ecx
       jae       near ptr M00_L53
       mov       ecx,[rbp-3C]
       mov       edx,[rdx+rcx*4+10]
       mov       ecx,1
       mov       rax,[rbp-0C0]
       cmp       edx,[rax+10]
       cmovle    ecx,[rbp-40]
       mov       [rbp-40],ecx
       cmp       r14d,64
       jbe       short M00_L56
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FFE772B6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       ecx,1
       test      rax,rax
       cmove     ecx,[rbp-44]
       mov       [rbp-44],ecx
M00_L56:
       call      M00_L75
       jmp       near ptr M00_L61
M00_L57:
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-3C]
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L59
       mov       rcx,r14
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M00_L58
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE77BF6580]
M00_L58:
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
       jae       near ptr M00_L74
       mov       eax,r8d
       lea       rdi,[rcx+rax*8+10]
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       [rbp-44],ecx
       mov       [rbp-48],ecx
       jmp       near ptr M00_L44
M00_L59:
       xor       ecx,ecx
       call      qword ptr [7FFE77BF59F8]
       int       3
M00_L60:
       call      M00_L75
       jmp       near ptr M00_L14
M00_L61:
       mov       ecx,[rbp-40]
       or        ecx,[rbp-44]
       je        short M00_L62
       mov       rcx,[rbp-0C0]
       mov       rdx,[rbp-0D0]
       mov       r8d,[rbp-40]
       mov       r9d,[rbp-44]
       call      qword ptr [7FFE779BFAC8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
M00_L62:
       mov       r8,[rbp-0E0]
       mov       [rbp-0C8],r8
       jmp       near ptr M00_L14
M00_L63:
       call      qword ptr [7FFE77BFD260]
       int       3
M00_L64:
       mov       rcx,rbx
       call      qword ptr [7FFE778A6208]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L15
M00_L65:
       mov       rcx,rsi
       mov       rdx,28C381C9FF0
       call      qword ptr [7FFE777CCA50]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       jmp       near ptr M00_L15
M00_L66:
       mov       rcx,28C381CB280
       call      qword ptr [7FFE77DC45B8]
       mov       rbx,rax
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FFE772BC960]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L67
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L67
       jmp       short M00_L68
M00_L67:
       mov       rcx,rax
       call      qword ptr [7FFE772B7C00]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
M00_L68:
       mov       rsi,[rcx+30]
       test      rsi,rsi
       jne       short M00_L69
       lea       rdx,[rcx+30]
       mov       r8d,1
       call      qword ptr [7FFE77454A50]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
M00_L69:
       mov       rcx,28C381C25E0
       test      rsi,rsi
       cmove     rsi,rcx
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rbx
       mov       rdx,28C381C9FF0
       mov       r8,rsi
       call      qword ptr [7FFE77B57CD8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE77715A88]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L70:
       mov       rcx,rbx
       call      qword ptr [7FFE778A6208]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L16
M00_L71:
       mov       ecx,0A
       call      qword ptr [7FFE777C4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdi,rax
       jmp       near ptr M00_L17
M00_L72:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24BA3002A38
       mov       rsi,[rcx]
       jmp       near ptr M00_L21
M00_L73:
       mov       rax,28C381B62A0
       jmp       near ptr M00_L25
M00_L74:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L75:
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp-48],0
       je        short M00_L78
       mov       rcx,[rbp-0D8]
       mov       ecx,[rcx+8]
       cmp       [rbp-3C],ecx
       jae       short M00_L76
       mov       rcx,[rbp-0D8]
       mov       eax,[rbp-3C]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       short M00_L77
       xor       ecx,ecx
       call      qword ptr [7FFE77BF59F8]
       int       3
M00_L76:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L77:
       mov       rcx,r14
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M00_L78
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE77BF6580]
M00_L78:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E8]
       call      qword ptr [7FFE779BF2E8]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
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
       call      qword ptr [7FFE772B5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      qword ptr [7FFE772B6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE77BF6388]; System.RuntimeTypeHandle.CanCastTo(System.RuntimeType, System.RuntimeType)
M02_L02:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      qword ptr [7FFE772B6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE772BD350]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       je        short M02_L03
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE77BF6328]
M02_L03:
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FFED6EA0F50
       test      eax,eax
       je        short M02_L06
       mov       rcx,rsi
       call      qword ptr [7FFE771FA400]
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
       call      qword ptr [7FFE777CCA50]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M03_L00:
       mov       rcx,7FFE77D91FD4
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
       mov       rcx,7FFE77D91FD0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77BFDD88]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE77BFF420]
       mov       [rbp-20],rsi
       lea       rax,[M03_L00]
       add       rsp,28
       ret
; Total bytes of code 185
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
       mov       rcx,28C381BF9D8
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],1
       jne       short M04_L03
       cmp       word ptr [r8+0C],0A
       je        short M04_L04
M04_L03:
       mov       rcx,28C381B1518
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],2
       jne       short M04_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M04_L08
M04_L04:
       mov       rcx,28C381B1518
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
       mov       rdx,7FFE777B9C30
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE77DC4780]
       int       3
M04_L09:
       or        esi,4
       jmp       short M04_L06
M04_L10:
       cmp       edx,9
       je        short M04_L11
       mov       ecx,38A0
       mov       rdx,7FFE777B9C30
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE77DC4738]
       int       3
M04_L11:
       or        esi,8
       jmp       near ptr M04_L00
M04_L12:
       mov       ecx,38A0
       mov       rdx,7FFE777B9C30
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FFE77DC4750]
       int       3
M04_L13:
       mov       ecx,38A0
       mov       rdx,7FFE777B9C30
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE77DC4768]
       int       3
M04_L14:
       mov       r8,28C381B1518
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
       mov       rcx,24BA3000C90
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0B
       jle       short M05_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+58]
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
       mov       ecx,0B
       call      qword ptr [7FFE777C4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L03:
       mov       rcx,r14
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFE77BFE9D0]
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
       call      qword ptr [7FFE77A9EC40]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FFE778AD2D8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFE772B6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFE77BFE9D0]
       jmp       near ptr M05_L01
M05_L12:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M05_L15
M05_L13:
       test      ebx,ebx
       jne       short M05_L14
       mov       rax,28C381B62A0
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
       mov       rdx,28C381B6F28
       call      qword ptr [7FFE7753D788]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFE779B7408]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M05_L17:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFE77BFE9D0]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE77BFE9E8]
       jmp       near ptr M05_L01
M05_L18:
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
       je        short M06_L02
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M06_L00:
       mov       [rbx+2C],eax
       test      byte ptr [rdx+0C],4
       jne       short M06_L03
       mov       rsi,28C381B1518
M06_L01:
       mov       ecx,[rsi+8]
       mov       [rbx+30],ecx
       cmp       dword ptr [rbx+78],0
       je        short M06_L04
       mov       rcx,7FFE77DF1208
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L02:
       mov       eax,2
       jmp       short M06_L00
M06_L03:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      qword ptr [7FFE772B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24BA3002A38
       mov       rsi,[rcx]
       jmp       short M06_L01
M06_L04:
       mov       rcx,7FFE77DF120C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFE77DF1208
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+70]
       mov       edx,3E8
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE77DC4798]
; Total bytes of code 211
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       sub       rsp,28
       test      rdx,rdx
       je        short M07_L01
       mov       r8d,r8d
       mov       eax,r9d
       add       rax,r8
       mov       r10d,[rdx+8]
       cmp       rax,r10
       ja        short M07_L02
       add       rdx,10
       add       rdx,r8
       mov       [rcx],rdx
       mov       [rcx+8],r9d
M07_L00:
       add       rsp,28
       ret
M07_L01:
       or        r8d,r9d
       jne       short M07_L02
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       jmp       short M07_L00
M07_L02:
       call      qword ptr [7FFE774570D8]
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
       mov       r8,24BA30013A8
       mov       rbx,[r8]
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       r8d,1
       test      edi,edi
       cmove     rsi,r8
       mov       [rbp-38],rsi
       test      rsi,rsi
       je        near ptr M08_L03
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFE77454B88]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       mov       r9d,eax
       sub       r9d,esi
       mov       r14d,r9d
       add       r14d,[rbp-48]
       cmp       r9d,edi
       jne       near ptr M08_L04
M08_L00:
       test      r14d,r14d
       je        near ptr M08_L05
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFED6EDF840
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       [rbp-40],rcx
       mov       r13,[rbp-40]
       test      r13,r13
       je        near ptr M08_L06
       mov       ecx,edi
       or        ecx,r14d
       jl        near ptr M08_L07
       lea       rcx,[rbp-58]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-60]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       mov       edx,edi
       mov       r8,r13
       mov       r9d,r14d
       call      qword ptr [7FFE77454BB8]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
       mov       ecx,[rbp-58]
       sub       ecx,esi
       mov       rdx,[rbp-60]
       sub       rdx,r13
       mov       r8,rdx
       shr       r8,3F
       add       rdx,r8
       sar       rdx,1
       cmp       ecx,edi
       jne       short M08_L08
M08_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
M08_L02:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       near ptr M08_L09
M08_L03:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FFE7792D830]
       int       3
M08_L04:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FFE7792DE30]
       add       r14d,eax
       jns       near ptr M08_L00
       call      qword ptr [7FFE7792DE48]
       int       3
M08_L05:
       mov       r15,28C381B0008
       jmp       short M08_L02
M08_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FFE7792D830]
       int       3
M08_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FFE77925608]
       int       3
M08_L08:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,r13
       call      qword ptr [7FFE7792D848]
       jmp       near ptr M08_L01
M08_L09:
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
       call      qword ptr [7FFE7792DE60]
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
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M09_L05
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        near ptr M09_L05
M09_L00:
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
       mov       rcx,28C381B62A0
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M09_L04
       mov       esi,[rbx+8]
       test      esi,esi
       je        near ptr M09_L04
       mov       rcx,24BA3001DD0
       mov       rbp,[rcx]
       lea       ecx,[rsi-1]
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0B
       jle       near ptr M09_L06
       mov       rcx,[rcx+240]
       mov       rax,[rcx+58]
       test      rax,rax
       je        near ptr M09_L06
M09_L01:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M09_L07
M09_L02:
       xor       r15d,r15d
       mov       r13d,1
       mov       ecx,[rax+8]
       cmp       ecx,r14d
       jbe       short M09_L03
       mov       r15d,1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       esi,ecx
       jne       near ptr M09_L08
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
       jne       near ptr M09_L09
M09_L03:
       mov       rcx,24BA3000C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       jne       near ptr M09_L21
M09_L04:
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
M09_L05:
       mov       ecx,0A
       call      qword ptr [7FFE777C4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M09_L00
M09_L06:
       mov       ecx,0B
       call      qword ptr [7FFE777C4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M09_L01
M09_L07:
       mov       rcx,rbp
       call      qword ptr [7FFE779BF330]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M09_L02
M09_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77BFEA60]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE77715B30]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L09:
       mov       rcx,[rbp+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M09_L24
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M09_L10
       mov       rcx,rbp
       mov       edx,r14d
       call      qword ptr [7FFE77DC4240]
M09_L10:
       mov       r13,[rax+8]
       call      qword ptr [7FFE77A9EC40]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       xor       edx,edx
       jmp       near ptr M09_L17
M09_L11:
       cmp       eax,[r13+8]
       jae       near ptr M09_L24
       mov       [rsp+4C],eax
       mov       ecx,eax
       mov       r8,[r13+rcx*8+10]
       mov       [rsp+30],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rsp+44],r10d
       mov       rcx,r8
       call      qword ptr [7FFE778AD2D8]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+40],r8d
       cmp       [rcx+8],r8d
       jbe       short M09_L13
       test      r8d,r8d
       jne       short M09_L14
       xor       edx,edx
       mov       [rax+14],edx
M09_L12:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+40]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+44],1
M09_L13:
       mov       rcx,rax
       call      qword ptr [7FFE772B6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+44],0
       je        short M09_L15
       jmp       short M09_L18
M09_L14:
       jmp       short M09_L12
M09_L15:
       mov       eax,[rsp+4C]
       inc       eax
       mov       ecx,eax
       cmp       [r13+8],ecx
       jne       short M09_L16
       xor       ecx,ecx
M09_L16:
       mov       edx,[rsp+48]
       inc       edx
       mov       eax,ecx
M09_L17:
       mov       [rsp+48],edx
       cmp       [r13+8],edx
       jg        near ptr M09_L11
       jmp       short M09_L19
M09_L18:
       mov       r13d,1
       jmp       short M09_L20
M09_L19:
       xor       r13d,r13d
M09_L20:
       jmp       near ptr M09_L03
M09_L21:
       mov       rcx,rbx
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+54],eax
       mov       [rsp+50],esi
       mov       rcx,rbp
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rsp+54]
       mov       r9d,[rsp+50]
       mov       edx,3
       call      qword ptr [7FFE77BFEA78]
       test      r13d,r15d
       jne       near ptr M09_L04
       mov       rcx,rbx
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rbp
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r15d,r15d
       jne       short M09_L22
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M09_L23
M09_L22:
       mov       ecx,r14d
       xor       edx,edx
M09_L23:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,ebx
       mov       r8d,esi
       call      qword ptr [7FFE77BFEA90]
       jmp       near ptr M09_L04
M09_L24:
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
       je        near ptr M11_L08
       mov       eax,[rbx+8]
       mov       ecx,[r8+8]
       mov       esi,[rbx+0C]
       sub       ecx,esi
       add       ecx,eax
       cmp       edx,ecx
       jle       near ptr M11_L09
       sub       esi,eax
       add       edx,esi
       cmp       edx,7FFFFFC7
       ja        near ptr M11_L10
       mov       ecx,[r8+8]
       add       ecx,ecx
       mov       eax,7FFFFFC7
       cmp       rcx,7FFFFFC7
       cmovl     rax,rcx
       cmp       edx,eax
       cmovl     edx,eax
       cmp       byte ptr [rbx+10],0
       je        near ptr M11_L11
       mov       rcx,24BA3001DD0
       mov       rcx,[rcx]
       call      qword ptr [7FFE779EE0C0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rsi,rax
M11_L00:
       mov       rdi,[rbx]
       mov       ebp,[rbx+0C]
       mov       r14d,[rbx+8]
       sub       ebp,r14d
       je        near ptr M11_L03
       test      rdi,rdi
       je        near ptr M11_L12
       test      rsi,rsi
       je        near ptr M11_L13
       mov       r15d,[rdi+8]
       mov       rcx,offset MT_System.Byte[]
       cmp       [rdi],rcx
       jne       near ptr M11_L14
M11_L01:
       mov       r13,r15
       cmp       rdi,rsi
       je        short M11_L02
       mov       r13d,[rsi+8]
       mov       rcx,offset MT_System.Byte[]
       cmp       [rsi],rcx
       jne       near ptr M11_L16
M11_L02:
       test      r14d,r14d
       jl        near ptr M11_L18
       test      ebp,ebp
       jl        near ptr M11_L19
       mov       r8d,ebp
       mov       edx,r14d
       lea       rcx,[rdx+r8]
       cmp       rcx,r15
       ja        near ptr M11_L20
       cmp       r13,r8
       jb        near ptr M11_L20
       lea       rcx,[rsi+10]
       lea       rdx,[rdi+rdx+10]
       call      qword ptr [7FFE772B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M11_L03:
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+10],0
       je        near ptr M11_L07
       mov       ebx,[rdi+8]
       test      ebx,ebx
       je        near ptr M11_L07
       mov       rcx,24BA3001DD0
       mov       rsi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0B
       jle       near ptr M11_L21
       mov       rcx,[rcx+240]
       mov       rax,[rcx+58]
       test      rax,rax
       je        near ptr M11_L21
M11_L04:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M11_L22
M11_L05:
       xor       r14d,r14d
       mov       r15d,1
       mov       ecx,[rax+8]
       cmp       ecx,ebp
       jbe       short M11_L06
       mov       r14d,1
       mov       ecx,10
       shlx      ecx,ecx,ebp
       cmp       ebx,ecx
       jne       near ptr M11_L23
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
       jne       near ptr M11_L24
M11_L06:
       mov       rcx,24BA3000C90
       mov       r13,[rcx]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M11_L36
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
       mov       rcx,24BA3001DD0
       mov       rcx,[rcx]
       call      qword ptr [7FFE779EE0C0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,rbx
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M11_L07
M11_L09:
       mov       edx,esi
       sub       edx,eax
       mov       [rsp+20],edx
       mov       edx,eax
       mov       rcx,r8
       xor       r9d,r9d
       call      qword ptr [7FFE7745DEA8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       jmp       short M11_L07
M11_L10:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77BFE8B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L11:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       near ptr M11_L00
M11_L12:
       mov       ecx,257
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE77BF59F8]
       int       3
M11_L13:
       mov       ecx,25F
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE77BF59F8]
       int       3
M11_L14:
       mov       rcx,rdi
       call      00007FFED6E36B80
       mov       ecx,3003FFC
       bt        ecx,eax
       jb        short M11_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77BF70C0]
       mov       rsi,rax
       mov       ecx,257
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE77715B30]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L15:
       mov       rcx,[rdi]
       movzx     ecx,word ptr [rcx]
       imul      r15,rcx
       jmp       near ptr M11_L01
M11_L16:
       mov       rcx,rsi
       call      00007FFED6E36B80
       mov       ecx,3003FFC
       bt        ecx,eax
       jb        short M11_L17
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE77BF70C0]
       mov       rbp,rax
       mov       ecx,25F
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,r14
       call      qword ptr [7FFE77715B30]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M11_L17:
       mov       rcx,[rsi]
       movzx     ecx,word ptr [rcx]
       imul      r13,rcx
       jmp       near ptr M11_L02
M11_L18:
       mov       ecx,267
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE77BF59C8]
       int       3
M11_L19:
       mov       ecx,28F
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FFE77BF59C8]
       int       3
M11_L20:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFE77BF70D8]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE7753FC90]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M11_L21:
       mov       ecx,0B
       call      qword ptr [7FFE777C4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M11_L04
M11_L22:
       mov       rcx,rsi
       call      qword ptr [7FFE779BF330]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M11_L05
M11_L23:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE77BFEA60]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE77715B30]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M11_L24:
       mov       rcx,[rsi+10]
       cmp       ebp,[rcx+8]
       jae       near ptr M11_L39
       mov       edx,ebp
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M11_L25
       mov       rcx,rsi
       mov       edx,ebp
       call      qword ptr [7FFE77DC4240]
M11_L25:
       mov       r15,[rax+8]
       call      qword ptr [7FFE77A9EC40]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r13d,eax
       sub       r13d,ecx
       xor       eax,eax
       jmp       near ptr M11_L32
M11_L26:
       cmp       r13d,[r15+8]
       jae       near ptr M11_L39
       mov       ecx,r13d
       mov       rdx,[r15+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+3C],r8d
       mov       rcx,rdx
       call      qword ptr [7FFE778AD2D8]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+38],r8d
       cmp       [rcx+8],r8d
       jbe       short M11_L28
       test      r8d,r8d
       jne       short M11_L29
       xor       edx,edx
       mov       [rax+14],edx
M11_L27:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+38]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+3C],1
M11_L28:
       mov       rcx,rax
       call      qword ptr [7FFE772B6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+3C],0
       je        short M11_L30
       jmp       short M11_L33
M11_L29:
       jmp       short M11_L27
M11_L30:
       inc       r13d
       cmp       [r15+8],r13d
       jne       short M11_L31
       xor       r13d,r13d
M11_L31:
       mov       eax,[rsp+40]
       inc       eax
M11_L32:
       mov       [rsp+40],eax
       cmp       [r15+8],eax
       jg        near ptr M11_L26
       jmp       short M11_L34
M11_L33:
       mov       r15d,1
       jmp       short M11_L35
M11_L34:
       xor       r15d,r15d
M11_L35:
       jmp       near ptr M11_L06
M11_L36:
       mov       rcx,rdi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       [rsp+44],ebx
       mov       rcx,rsi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r13
       mov       r8d,r12d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FFE77BFEA78]
       test      r15d,r14d
       jne       near ptr M11_L07
       mov       rcx,rdi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,rsi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r14d,r14d
       jne       short M11_L37
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M11_L38
M11_L37:
       mov       ecx,ebp
       xor       edx,edx
M11_L38:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r13
       mov       edx,edi
       mov       r8d,ebx
       call      qword ptr [7FFE77BFEA90]
       jmp       near ptr M11_L07
M11_L39:
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
       call      qword ptr [7FFFAFF9F470]
       movzx     ecx,byte ptr [rax+1]
       mov       [rbx+95],cl
       movzx     eax,byte ptr [rax+2]
       mov       [rbx+96],al
       mov       word ptr [rbx+90],20
       mov       dword ptr [rbx+84],2
       mov       byte ptr [rbx+9D],1
       mov       dword ptr [rbx+88],40
       call      qword ptr [7FFFAFF9F4E8]
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
       jne       short M13_L01
       mov       rax,[rcx+58]
       test      rax,rax
       jne       short M13_L02
M13_L00:
       lea       rcx,[rcx+20]
       call      qword ptr [7FFFAFF9F230]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M13_L01:
       mov       rcx,[rcx+20]
       call      qword ptr [7FFFAFFA1550]
       mov       rcx,rax
       call      qword ptr [7FFFAFFA3BE8]
       int       3
M13_L02:
       cmp       rax,rdx
       je        short M13_L00
       xor       r8d,r8d
       mov       [rax+10],r8
       mov       [rcx+58],r8
       jmp       short M13_L00
; Total bytes of code 76
```
```assembly
; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFFAFFA52F8]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFFAFFA32C0]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       test      rax,rax
       cmove     rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
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
       call      qword ptr [7FFED6CEF020]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFED6CEF028]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7FFFB7240038]; Precode of System.Threading.Monitor.Enter(System.Object)
       mov       dword ptr [rbp-48],1
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+8]
       jne       near ptr M17_L18
       mov       rax,[rbx+10]
       mov       r14d,[rax+8]
       xor       r15d,r15d
       test      dil,dil
       jne       near ptr M17_L13
M17_L00:
       test      sil,sil
       je        short M17_L02
       test      r15,r15
       jne       short M17_L01
       mov       rcx,[rbp+10]
       call      qword ptr [7FFFB72408B0]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetCountNoLocks()
       mov       rcx,[rbx+10]
       mov       ecx,[rcx+8]
       shr       ecx,2
       cmp       eax,ecx
       jl        near ptr M17_L12
M17_L01:
       mov       rax,[rbx+10]
       mov       eax,[rax+8]
       add       eax,eax
       js        near ptr M17_L17
       mov       ecx,eax
       call      qword ptr [7FFFB72403B8]; Precode of System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       call      qword ptr [7FFFB723FF30]; Precode of System.Array.get_MaxLength()
       cmp       eax,r14d
       jl        near ptr M17_L17
M17_L02:
       mov       rsi,[rbx+18]
       mov       rdi,rsi
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+18],0
       je        short M17_L04
       cmp       dword ptr [rsi+8],400
       jge       short M17_L04
       mov       eax,[rsi+8]
       add       eax,eax
       movsxd    rcx,eax
       call      qword ptr [7FFFB723FED8]
       mov       rdi,rax
       mov       r8d,[rsi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFFB723FF18]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,[rbx+18]
       mov       esi,[rax+8]
       mov       r13d,[rdi+8]
       cmp       r13d,esi
       jle       short M17_L04
M17_L03:
       call      qword ptr [7FFFB723FE30]
       mov       r8,rax
       movsxd    rdx,esi
       mov       rcx,rdi
       call      qword ptr [7FFFB723F2A8]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       esi
       cmp       r13d,esi
       jg        short M17_L03
M17_L04:
       mov       rcx,[rbp+10]
       mov       r13,[rcx]
       mov       rcx,r13
       call      qword ptr [7FFFB723F9E0]
       mov       rcx,rax
       movsxd    rdx,r14d
       call      qword ptr [7FFFB723F2C0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       ecx,[rdi+8]
       call      qword ptr [7FFFB723FEE0]
       mov       r14,rax
       mov       r12,r15
       test      r12,r12
       jne       short M17_L05
       mov       r12,[rbx+8]
M17_L05:
       mov       rcx,r13
       call      qword ptr [7FFFB723F738]
       mov       rcx,rax
       call      qword ptr [7FFFB723F2B8]; CORINFO_HELP_NEWFAST
       mov       [rbp-78],rax
       lea       rcx,[rax+10]
       mov       rdx,rsi
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+18]
       mov       rdx,rdi
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+20]
       mov       rdx,r14
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rsi+8]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       r12,[rbp-78]
       mov       [r12+28],rax
       mov       rcx,r13
       call      qword ptr [7FFFB723F700]
       mov       rcx,rax
       lea       r8,[rbp-48]
       mov       rdx,rbx
       call      qword ptr [7FFFB72408D0]
       mov       rbx,[rbx+10]
       xor       eax,eax
       mov       edx,[rbx+8]
       cmp       edx,eax
       jg        near ptr M17_L10
M17_L06:
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
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M17_L18
M17_L07:
       test      r15,r15
       jne       near ptr M17_L11
       mov       [rbp-68],rdx
       mov       r8d,[rdx+20]
M17_L08:
       mov       rdx,[rbp-68]
       mov       r10,[rdx+18]
       mov       [rbp-80],r10
       mov       rcx,[r12+10]
       mov       [rbp-4C],r8d
       mov       r9d,r8d
       imul      r9,[r12+28]
       shr       r9,20
       inc       r9
       mov       r11d,[rcx+8]
       mov       esi,r11d
       imul      r9,rsi
       shr       r9,20
       mov       rsi,[r12+18]
       mov       eax,r9d
       xor       edx,edx
       div       dword ptr [rsi+8]
       mov       esi,edx
       cmp       r9d,r11d
       jae       near ptr M17_L15
       mov       eax,r9d
       lea       rax,[rcx+rax*8+10]
       mov       [rbp-70],rax
       mov       rcx,r13
       call      qword ptr [7FFFB723F720]
       mov       rcx,rax
       call      qword ptr [7FFFB723F2B8]; CORINFO_HELP_NEWFAST
       mov       [rbp-88],rax
       mov       r8,[rbp-68]
       mov       rdx,[r8+8]
       mov       r8,[r8+10]
       mov       [rbp-90],r8
       mov       r10,[rbp-70]
       mov       r9,[r10]
       mov       [rbp-98],r9
       lea       rcx,[rax+8]
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-90]
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       lea       rcx,[rax+18]
       mov       rdx,[rbp-98]
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       mov       ecx,[rbp-4C]
       mov       [rax+20],ecx
       mov       rcx,[rbp-70]
       mov       rdx,rax
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       cmp       esi,[r14+8]
       jae       near ptr M17_L15
       mov       eax,esi
       lea       rax,[r14+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M17_L16
       mov       [rax],edx
       mov       rsi,[rbp-80]
       test      rsi,rsi
       mov       rdx,rsi
       jne       near ptr M17_L07
M17_L09:
       mov       rax,[rbp-58]
       inc       eax
       mov       edx,[rbx+8]
       cmp       edx,eax
       jle       near ptr M17_L06
M17_L10:
       mov       [rbp-58],rax
       mov       rdx,[rbx+rax*8+10]
       test      rdx,rdx
       jne       near ptr M17_L07
       jmp       short M17_L09
M17_L11:
       mov       [rbp-68],rdx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       call      qword ptr [7FFFB723FBA8]
       mov       r8,[rbp-68]
       mov       rdx,[r8+8]
       mov       rcx,r15
       mov       r11,rax
       call      qword ptr [rax]
       mov       r8d,eax
       jmp       near ptr M17_L08
M17_L12:
       mov       rcx,[rbp+10]
       mov       eax,[rcx+10]
       add       eax,eax
       mov       [rcx+10],eax
       test      eax,eax
       jge       near ptr M17_L18
       jmp       short M17_L14
M17_L13:
       mov       rcx,[rbx+8]
       call      qword ptr [7FFFB723FEF8]
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M17_L00
       mov       rcx,[rbp+10]
       mov       r13,[rcx]
       mov       rcx,r13
       call      qword ptr [7FFFB723F548]
       mov       r15,rax
       mov       rcx,rdi
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFFB723F2C8]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M17_L00
M17_L14:
       mov       dword ptr [rcx+10],7FFFFFFF
       jmp       short M17_L18
M17_L15:
       call      qword ptr [7FFFB723F288]
       int       3
M17_L16:
       call      qword ptr [7FFFB723F280]
       int       3
M17_L17:
       call      qword ptr [7FFFB723FF30]; Precode of System.Array.get_MaxLength()
       mov       r14d,eax
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+10],7FFFFFFF
       jmp       near ptr M17_L02
M17_L18:
       mov       rcx,[rbp+10]
       mov       edx,[rbp-48]
       call      qword ptr [7FFFB72408E0]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32)
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
       call      qword ptr [7FFFB72408E0]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 1137
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
       call      00007FFED6E20370
       test      eax,eax
       jne       short M18_L01
       mov       rcx,rsi
       call      qword ptr [7FFE77BF6778]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M18_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M18_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M18_L03
       mov       rcx,7FFE77D58FC0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FFE778A6220]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M18_L04
M18_L02:
       xor       ecx,ecx
       call      qword ptr [7FFE77BF59F8]
       int       3
M18_L03:
       mov       rcx,7FFE77D58FBC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE77BFD260]
       int       3
M18_L04:
       mov       rcx,7FFE77D58FC4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FFED6E6FFC0
       test      eax,eax
       jne       near ptr M18_L10
M18_L05:
       mov       rcx,7FFE77D58FC8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFE77D58FCC
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M18_L06:
       call      qword ptr [7FFE77BFDD70]
       int       3
M18_L07:
       mov       rcx,7FFE77D58FB8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE77BFD260]
       int       3
M18_L08:
       mov       rcx,rbx
       call      qword ptr [7FFE777CC4E0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M18_L09
       call      qword ptr [7FFE77BF5F20]
       int       3
M18_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFED6E8EEF0
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M18_L00
M18_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE77BF6580]
       jmp       near ptr M18_L05
       sub       rsp,28
       call      qword ptr [7FFE77BFDD88]
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
       mov       rcx,7FFE77D58FC4
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M18_L11
       xor       ecx,ecx
       call      qword ptr [7FFE77BF59F8]
       int       3
M18_L11:
       mov       rcx,[rbp-20]
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M18_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFE77BF6580]
M18_L12:
       mov       rcx,7FFE77D58FC8
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
       mov       rcx,7FFE77D92038
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbx+20]
M19_L00:
       test      rdi,rdi
       je        short M19_L02
       mov       rcx,rdi
       mov       rdx,7FFE77D92040
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rdi
       mov       r8,rbx
       mov       rdx,rsi
       mov       r11,7FFE77200DF0
       call      qword ptr [r11]
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M19_L06
       mov       rcx,[rbp+0C0]
       mov       rdx,rsi
       call      qword ptr [7FFE77454A20]; System.Type.op_Equality(System.Type, System.Type)
       test      eax,eax
       je        short M19_L03
       cmp       [rbp+0B8],rbx
       jne       short M19_L04
M19_L01:
       mov       rcx,7FFE77D92158
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M19_L02:
       mov       rcx,7FFE77D9203C
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M19_L03:
       mov       rcx,7FFE77D92148
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp+0C0]
       mov       rcx,rsi
       call      qword ptr [7FFE77BFF438]
       int       3
M19_L04:
       mov       rcx,7FFE77D9214C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFE77BFF450]
       int       3
M19_L05:
       mov       rcx,7FFE77D92150
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M19_L01
M19_L06:
       mov       rcx,28C381B19B8
       cmp       rsi,rcx
       jne       short M19_L05
       mov       rcx,7FFE77D92154
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SlimObjectConverter
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE777CD8F0]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       call      qword ptr [7FFE778A51A0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Text.Json.Serialization.JsonConverter, System.Text.Json.JsonSerializerOptions)
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
       call      00007FFED6E34140
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
       mov       rax,7FFE77416D90
       mov       [rbp-78],rax
       lea       rax,[M20_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFED6DD50B0
       call      rax
M20_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFED71EE808],0
       je        short M20_L04
       call      qword ptr [7FFED71DC608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFED6EB03C0
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
       call      qword ptr [7FFE77DC69B8]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M20_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE77BF73F0]
       jmp       near ptr M20_L00
M20_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M20_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFE772B7C48]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       je        near ptr M21_L04
       mov       [rbp-48],rcx
       mov       rcx,[rbp-48]
       test      rcx,rcx
       je        near ptr M21_L03
       mov       rcx,[rcx+18]
M21_L00:
       lea       rdx,[rbp-48]
       mov       [rbp-90],rdx
       mov       [rbp-88],rcx
       lea       rcx,[rbp-90]
       mov       edx,edi
       lea       r8,[rbp-40]
       mov       rax,7FFE77324D48
       mov       [rbp-70],rax
       lea       rax,[M21_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFED6E38460
       call      rax
M21_L01:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFED71EE808],0
       je        short M21_L02
       call      qword ptr [7FFED71DC608]; CORINFO_HELP_STOP_FOR_GC
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
       xor       ecx,ecx
       jmp       near ptr M21_L00
M21_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77BF65B0]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE77BF65C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 312
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFED6D07E38]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFE772B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       mov       r8,[rcx+50]
       mov       [rbp-0A0],r8
       mov       rbx,21E7B2CF9F0
       mov       [rbp-0F8],rbx
       mov       rax,1DDFC4006F0
       mov       rax,[rax]
       mov       [rbp-0A8],rax
       test      r8,r8
       je        short M00_L00
       mov       rcx,r8
       call      qword ptr [7FFE772BC960]; System.Object.GetType()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE771FA610]; System.RuntimeType.IsAssignableFrom(System.Type)
       test      eax,eax
       mov       rbx,[rbp-0F8]
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
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       mov       rdx,7FFED6E9E4E0
       call      rdx
       movzx     ebx,al
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M00_L30
M00_L02:
       cmp       ebx,0F
       je        near ptr M00_L38
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       mov       rax,7FFED6E9E4E0
       call      rax
       movzx     ebx,al
       mov       rsi,[rbp-0F8]
       cmp       dword ptr [7FFED71EE808],0
       jne       near ptr M00_L31
M00_L03:
       cmp       ebx,10
       je        near ptr M00_L38
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
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
       mov       rax,7FFED6E9E4E0
       call      rax
       movzx     ebx,al
       mov       rsi,[rbp-0B8]
       cmp       dword ptr [7FFED71EE808],0
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
       call      00007FFED6EA1090
       test      eax,eax
       jne       near ptr M00_L38
       mov       rsi,[rbp-0B0]
       cmp       byte ptr [rsi+9E],0
       je        near ptr M00_L65
       mov       rbx,[rsi+8]
       test      rbx,rbx
       je        near ptr M00_L39
M00_L09:
       mov       rsi,[rbx+8]
       mov       rcx,1DDE6401938
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M00_L10
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE771FD050
       mov       [rdi+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [rdi+20],rcx
       mov       rcx,1DDE6401938
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L10:
       mov       [rbp-0C0],rsi
       cmp       [rsi],sil
       mov       r14,[rsi+8]
       mov       rcx,[r14+8]
       cmp       byte ptr [rsi+19],0
       jne       near ptr M00_L22
       mov       rdx,21E7B2CF9F0
       mov       r11,7FFE772011C0
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
       jae       near ptr M00_L74
       mov       edx,edx
       mov       r13,[rcx+rdx*8+10]
       test      r13,r13
       je        near ptr M00_L43
M00_L12:
       cmp       esi,[r13+20]
       jne       near ptr M00_L41
       mov       r12,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r15],rcx
       jne       near ptr M00_L42
       test      r12,r12
       je        near ptr M00_L41
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M00_L40
       mov       rcx,21E7B2CF9F0
       cmp       r12,rcx
       sete      al
       movzx     eax,al
M00_L13:
       test      eax,eax
       je        near ptr M00_L41
       mov       rdx,[r13+10]
       mov       [rbp-0C8],rdx
M00_L14:
       mov       rcx,[rbp-0C8]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       near ptr M00_L63
       mov       rcx,[rbp-0C8]
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        short M00_L15
       cmp       byte ptr [rbx+119],2
       jne       near ptr M00_L64
M00_L15:
       test      rbx,rbx
       je        near ptr M00_L66
       cmp       byte ptr [rbx+119],2
       jne       near ptr M00_L70
M00_L16:
       mov       rsi,[rbx+0B8]
       lea       rdx,[rbp-58]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE779A6C40]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       esi,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M00_L71
       mov       rcx,[rcx+240]
       mov       rdi,[rcx+50]
       test      rdi,rdi
       je        near ptr M00_L71
M00_L17:
       mov       rax,[rdi+10]
       test      rax,rax
       jne       short M00_L18
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,21E7B2C62A0
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
       jl        near ptr M00_L27
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
       je        near ptr M00_L28
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M00_L20:
       mov       [r14+2C],eax
       test      dil,4
       jne       near ptr M00_L72
       mov       rsi,21E7B2C1518
M00_L21:
       mov       ecx,[rsi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+78],0
       jne       near ptr M00_L25
       mov       dword ptr [r14+78],3E8
       jmp       near ptr M00_L25
M00_L22:
       mov       rcx,21E7B2CF9F0
       mov       rax,[7FFE771FA1C0]
       call      qword ptr [rax+18]
       mov       esi,eax
       jmp       near ptr M00_L11
M00_L23:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      esi,esi
       je        near ptr M00_L73
       mov       rcx,1DDE6401DD0
       mov       rcx,[rcx]
       mov       edx,esi
       call      qword ptr [7FFE779BC8D0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
M00_L24:
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
       call      qword ptr [7FFE779A6D90]; System.Text.Json.Utf8JsonWriter.SetOptions(System.Text.Json.JsonWriterOptions)
M00_L25:
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
       call      qword ptr [7FFE779AEC40]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rcx,[rbp-80]
       mov       eax,[rbp-78]
       mov       [rbp-98],rcx
       mov       [rbp-90],eax
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE779257E8]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rbx,rax
       mov       rcx,r14
       mov       rdx,[rbp-0E8]
       call      qword ptr [7FFE779AEC58]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       [rbp-88],rbx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+18]
       lea       r8,[rbp-88]
       mov       rdx,7FFE77BAB468
       cmp       [rcx],ecx
       call      qword ptr [7FFE77B5C858]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE77C0F960]
       int       3
M00_L27:
       mov       edx,esi
       call      qword ptr [7FFE779A6CD0]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L19
M00_L28:
       mov       eax,2
       jmp       near ptr M00_L20
M00_L29:
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE777C44B0]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,[rbp-0A8]
       call      qword ptr [7FFE77AEE0A0]; System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FFE77C0FAE0]
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
       call      qword ptr [7FFE77C05ED8]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE77C05EF0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       ecx,3C7C
       mov       rdx,7FFE777B9C30
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       mov       rdx,21E7B2CF9F0
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE77C0FAF8]
       int       3
M00_L39:
       mov       rcx,rsi
       call      qword ptr [7FFE777CC4B0]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M00_L09
M00_L40:
       mov       rcx,r12
       mov       rdx,21E7B2CF9F0
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L13
M00_L41:
       mov       r13,[r13+18]
       test      r13,r13
       jne       near ptr M00_L12
       jmp       short M00_L43
M00_L42:
       mov       rcx,r15
       mov       r8,21E7B2CF9F0
       mov       rdx,r12
       mov       r11,7FFE772011C8
       call      qword ptr [r11]
       jmp       near ptr M00_L13
M00_L43:
       xor       edx,edx
       mov       [rbp-0C8],rdx
       mov       [rbp-0D0],r14
       mov       rdx,21E7B2CF9F0
       mov       r8,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       [rbp-0E0],rax
       mov       rbx,[r14+8]
       jmp       near ptr M00_L58
M00_L44:
       mov       rcx,[rbp-0D8]
       mov       ecx,[rcx+8]
       cmp       [rbp-3C],ecx
       jae       near ptr M00_L53
       mov       rcx,[rbp-0D8]
       mov       eax,[rbp-3C]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       short M00_L45
       xor       ecx,ecx
       call      qword ptr [7FFE77C05320]
       int       3
M00_L45:
       mov       rcx,r14
       call      00007FFED6E20370
       test      eax,eax
       jne       short M00_L46
       mov       rcx,r14
       call      qword ptr [7FFE77C060A0]
M00_L46:
       mov       dword ptr [rbp-48],1
       mov       rcx,[rbp-0D0]
       mov       rax,[rbp-0C0]
       cmp       rcx,[rax+8]
       je        short M00_L49
       mov       rcx,[rax+8]
       mov       [rbp-0D0],rcx
       mov       rcx,[rbp-0D0]
       cmp       rbx,[rcx+8]
       je        near ptr M00_L57
       mov       rcx,[rbp-0D0]
       mov       rbx,[rcx+8]
       cmp       byte ptr [rax+19],0
       jne       short M00_L47
       mov       rcx,rbx
       mov       rdx,21E7B2CF9F0
       mov       r11,7FFE772011D8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L48
M00_L47:
       mov       rcx,21E7B2CF9F0
       mov       rdx,[7FFE771FA1C0]
       call      qword ptr [rdx+18]
       mov       esi,eax
M00_L48:
       mov       rax,[rbp-0C0]
       jmp       near ptr M00_L57
M00_L49:
       xor       r14d,r14d
       mov       r15,[rdi]
       test      r15,r15
       je        short M00_L55
M00_L50:
       cmp       esi,[r15+20]
       jne       short M00_L51
       mov       rdx,[r15+8]
       mov       rcx,rbx
       mov       r8,21E7B2CF9F0
       mov       r11,7FFE772011E0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-0C0]
       jne       short M00_L52
M00_L51:
       inc       r14d
       mov       r15,[r15+18]
       test      r15,r15
       jne       short M00_L50
       jmp       short M00_L55
M00_L52:
       mov       rcx,[r15+10]
       mov       [rbp-0C8],rcx
       jmp       near ptr M00_L60
M00_L53:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L54:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L55:
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>+Node
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13,[rdi]
       mov       rcx,21E7B2CF9F0
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
       jae       short M00_L53
       mov       ecx,[rbp-3C]
       lea       rdx,[rdx+rcx*4+10]
       mov       ecx,[rdx]
       add       ecx,1
       jo        short M00_L54
       mov       [rdx],ecx
       mov       rdx,[rbp-0D0]
       mov       rdx,[rdx+20]
       mov       ecx,[rdx+8]
       cmp       [rbp-3C],ecx
       jae       near ptr M00_L53
       mov       ecx,[rbp-3C]
       mov       edx,[rdx+rcx*4+10]
       mov       ecx,1
       mov       rax,[rbp-0C0]
       cmp       edx,[rax+10]
       cmovle    ecx,[rbp-40]
       mov       [rbp-40],ecx
       cmp       r14d,64
       jbe       short M00_L56
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FFE772B6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       ecx,1
       test      rax,rax
       cmove     ecx,[rbp-44]
       mov       [rbp-44],ecx
M00_L56:
       call      M00_L75
       jmp       near ptr M00_L61
M00_L57:
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-3C]
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L59
       mov       rcx,r14
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M00_L58
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE77C05EC0]
M00_L58:
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
       jae       near ptr M00_L74
       mov       eax,r8d
       lea       rdi,[rcx+rax*8+10]
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       [rbp-44],ecx
       mov       [rbp-48],ecx
       jmp       near ptr M00_L44
M00_L59:
       xor       ecx,ecx
       call      qword ptr [7FFE77C05320]
       int       3
M00_L60:
       call      M00_L75
       jmp       near ptr M00_L14
M00_L61:
       mov       ecx,[rbp-40]
       or        ecx,[rbp-44]
       je        short M00_L62
       mov       rcx,[rbp-0C0]
       mov       rdx,[rbp-0D0]
       mov       r8d,[rbp-40]
       mov       r9d,[rbp-44]
       call      qword ptr [7FFE779AF438]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
M00_L62:
       mov       r8,[rbp-0E0]
       mov       [rbp-0C8],r8
       jmp       near ptr M00_L14
M00_L63:
       call      qword ptr [7FFE77C0CBB8]
       int       3
M00_L64:
       mov       rcx,rbx
       call      qword ptr [7FFE778A6208]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L15
M00_L65:
       mov       rcx,rsi
       mov       rdx,21E7B2CF9F0
       call      qword ptr [7FFE777CCA50]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       jmp       near ptr M00_L15
M00_L66:
       mov       rcx,21E7B2DB1D0
       call      qword ptr [7FFE77C0F978]
       mov       rbx,rax
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FFE772BC960]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L67
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L67
       jmp       short M00_L68
M00_L67:
       mov       rcx,rax
       call      qword ptr [7FFE772B7C00]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
M00_L68:
       mov       rsi,[rcx+30]
       test      rsi,rsi
       jne       short M00_L69
       lea       rdx,[rcx+30]
       mov       r8d,1
       call      qword ptr [7FFE77454A50]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
M00_L69:
       mov       rcx,21E7B2D25E0
       test      rsi,rsi
       cmove     rsi,rcx
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rbx
       mov       rdx,21E7B2CF9F0
       mov       r8,rsi
       call      qword ptr [7FFE77B57408]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE77715A88]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L70:
       mov       rcx,rbx
       call      qword ptr [7FFE778A6208]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L16
M00_L71:
       mov       ecx,0A
       call      qword ptr [7FFE777C4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdi,rax
       jmp       near ptr M00_L17
M00_L72:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1DDFC400A40
       mov       rsi,[rcx]
       jmp       near ptr M00_L21
M00_L73:
       mov       rax,21E7B2C62A0
       jmp       near ptr M00_L24
M00_L74:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L75:
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp-48],0
       je        short M00_L78
       mov       rcx,[rbp-0D8]
       mov       ecx,[rcx+8]
       cmp       [rbp-3C],ecx
       jae       short M00_L76
       mov       rcx,[rbp-0D8]
       mov       eax,[rbp-3C]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       jne       short M00_L77
       xor       ecx,ecx
       call      qword ptr [7FFE77C05320]
       int       3
M00_L76:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L77:
       mov       rcx,r14
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M00_L78
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FFE77C05EC0]
M00_L78:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E8]
       call      qword ptr [7FFE779AEC58]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       nop
       add       rsp,28
       ret
; Total bytes of code 3315
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
       call      qword ptr [7FFE772B5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      qword ptr [7FFE772B6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE77C05CC8]; System.RuntimeTypeHandle.CanCastTo(System.RuntimeType, System.RuntimeType)
M02_L02:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      qword ptr [7FFE772B6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE772BD350]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       je        short M02_L03
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE77C05C50]
M02_L03:
       cmp       [rsi],sil
       mov       rcx,rsi
       call      00007FFED6EA0F50
       test      eax,eax
       je        short M02_L06
       mov       rcx,rsi
       call      qword ptr [7FFE771FA400]
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
       call      qword ptr [7FFE777CCA50]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M03_L00:
       mov       rcx,7FFE77D9985C
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
       mov       rcx,7FFE77D99858
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77C0D6C8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE77C0ED78]
       mov       [rbp-20],rsi
       lea       rax,[M03_L00]
       add       rsp,28
       ret
; Total bytes of code 185
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
       mov       rcx,21E7B2CF9D8
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],1
       jne       short M04_L03
       cmp       word ptr [r8+0C],0A
       je        short M04_L04
M04_L03:
       mov       rcx,21E7B2C1518
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],2
       jne       short M04_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M04_L08
M04_L04:
       mov       rcx,21E7B2C1518
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
       mov       rdx,7FFE777B9C30
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE77C0FB58]
       int       3
M04_L09:
       or        esi,4
       jmp       short M04_L06
M04_L10:
       cmp       edx,9
       je        short M04_L11
       mov       ecx,38A0
       mov       rdx,7FFE777B9C30
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE77C0FB10]
       int       3
M04_L11:
       or        esi,8
       jmp       near ptr M04_L00
M04_L12:
       mov       ecx,38A0
       mov       rdx,7FFE777B9C30
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FFE77C0FB28]
       int       3
M04_L13:
       mov       ecx,38A0
       mov       rdx,7FFE777B9C30
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE77C0FB40]
       int       3
M04_L14:
       mov       r8,21E7B2C1518
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
       mov       rcx,1DDE6400C90
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0B
       jle       short M05_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+58]
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
       mov       ecx,0B
       call      qword ptr [7FFE777C4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L03:
       mov       rcx,r14
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFE77C0E310]
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
       call      qword ptr [7FFE77A7E478]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FFE778ACFD8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFE772B6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFE77C0E310]
       jmp       near ptr M05_L01
M05_L12:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M05_L15
M05_L13:
       test      ebx,ebx
       jne       short M05_L14
       mov       rax,21E7B2C62A0
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
       mov       rdx,21E7B2C6F28
       call      qword ptr [7FFE7753D788]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFE779A6D78]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M05_L17:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFE77C0E310]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE77C0E328]
       jmp       near ptr M05_L01
M05_L18:
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
       je        short M06_L02
       xor       eax,eax
       cmp       ecx,2
       cmovne    eax,ecx
M06_L00:
       mov       [rbx+2C],eax
       test      byte ptr [rdx+0C],4
       jne       short M06_L03
       mov       rsi,21E7B2C1518
M06_L01:
       mov       ecx,[rsi+8]
       mov       [rbx+30],ecx
       cmp       dword ptr [rbx+78],0
       je        short M06_L04
       mov       rcx,7FFE77DAC360
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L02:
       mov       eax,2
       jmp       short M06_L00
M06_L03:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      qword ptr [7FFE772B5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1DDFC400A40
       mov       rsi,[rcx]
       jmp       short M06_L01
M06_L04:
       mov       rcx,7FFE77DAC364
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFE77DAC360
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+70]
       mov       edx,3E8
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE77C0FB70]
; Total bytes of code 211
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       sub       rsp,28
       test      rdx,rdx
       je        short M07_L01
       mov       r8d,r8d
       mov       eax,r9d
       add       rax,r8
       mov       r10d,[rdx+8]
       cmp       rax,r10
       ja        short M07_L02
       add       rdx,10
       add       rdx,r8
       mov       [rcx],rdx
       mov       [rcx+8],r9d
M07_L00:
       add       rsp,28
       ret
M07_L01:
       or        r8d,r9d
       jne       short M07_L02
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       jmp       short M07_L00
M07_L02:
       call      qword ptr [7FFE774570D8]
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
       mov       r8,1DDE64013A8
       mov       rbx,[r8]
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       r8d,1
       test      edi,edi
       cmove     rsi,r8
       mov       [rbp-38],rsi
       test      rsi,rsi
       je        near ptr M08_L04
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFE77454B88]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       mov       r9d,eax
       sub       r9d,esi
       mov       r14d,r9d
       add       r14d,[rbp-48]
       cmp       r9d,edi
       jne       near ptr M08_L05
M08_L00:
       test      r14d,r14d
       je        near ptr M08_L02
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFED6EDF840
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       [rbp-40],rcx
       mov       r13,[rbp-40]
       test      r13,r13
       je        near ptr M08_L06
       mov       ecx,edi
       or        ecx,r14d
       jl        near ptr M08_L07
       lea       rcx,[rbp-58]
       mov       [rsp+20],rcx
       lea       rcx,[rbp-60]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       mov       edx,edi
       mov       r8,r13
       mov       r9d,r14d
       call      qword ptr [7FFE77454BB8]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
       mov       ecx,[rbp-58]
       sub       ecx,esi
       mov       rdx,[rbp-60]
       sub       rdx,r13
       mov       r8,rdx
       shr       r8,3F
       add       rdx,r8
       sar       rdx,1
       cmp       ecx,edi
       jne       short M08_L08
M08_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       jmp       short M08_L03
M08_L02:
       mov       r15,21E7B2C0008
M08_L03:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       near ptr M08_L09
M08_L04:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FFE77B5FC90]
       int       3
M08_L05:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FFE77C04288]
       add       r14d,eax
       jns       near ptr M08_L00
       call      qword ptr [7FFE77C042A0]
       int       3
M08_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FFE77B5FC90]
       int       3
M08_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FFE77925608]
       int       3
M08_L08:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       [rsp+30],edx
       mov       dword ptr [rsp+38],1
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       mov       r9,r13
       call      qword ptr [7FFE77B5FCA8]
       jmp       near ptr M08_L01
M08_L09:
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
       call      qword ptr [7FFE77C042B8]
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
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M09_L37
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        near ptr M09_L37
M09_L00:
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
       mov       rcx,21E7B2C62A0
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M09_L36
       cmp       dword ptr [rbx+8],0
       je        near ptr M09_L36
       mov       rcx,1DDE6401DD0
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
       cmp       dword ptr [rcx+238],0B
       jle       near ptr M09_L38
       mov       rcx,[rcx+240]
       mov       r15,[rcx+58]
       test      r15,r15
       je        near ptr M09_L38
M09_L01:
       mov       rax,[r15+10]
       test      rax,rax
       jne       near ptr M09_L16
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
       je        near ptr M09_L08
       mov       rcx,[rbp-80]
       call      00007FFED6E20370
       test      eax,eax
       jne       short M09_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FFE77C060A0]
M09_L02:
       mov       dword ptr [rbp-40],1
       mov       rcx,[r15+10]
       lea       r8,[rbp-48]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFE7753CE88]; System.Runtime.CompilerServices.ConditionalWeakTable`2+Container[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindEntry(System.__Canon, System.Object ByRef)
       cmp       eax,0FFFFFFFF
       jne       near ptr M09_L09
       mov       r12,[r15+10]
       mov       ecx,[r12+28]
       mov       rax,[r12+18]
       cmp       ecx,[rax+8]
       jge       near ptr M09_L06
M09_L03:
       cmp       byte ptr [r12+2C],0
       jne       near ptr M09_L10
       mov       byte ptr [r12+2C],1
       mov       rcx,r13
       call      00007FFED6E834A0
       test      eax,eax
       je        near ptr M09_L07
M09_L04:
       mov       r15d,eax
       and       r15d,7FFFFFFF
       mov       eax,[r12+28]
       mov       [rbp-4C],eax
       lea       ecx,[rax+1]
       mov       [r12+28],ecx
       mov       rcx,[r12+18]
       cmp       eax,[rcx+8]
       jae       near ptr M09_L11
       mov       edx,eax
       shl       rdx,4
       lea       r8,[rcx+rdx+10]
       mov       [r8],r15d
       mov       [rbp-88],r8
       mov       rcx,r13
       xor       edx,edx
       call      00007FFED6EC3BA0
       test      rax,rax
       je        near ptr M09_L12
M09_L05:
       mov       rcx,[rbp-88]
       mov       [rcx+8],rax
       mov       rcx,[r12+10]
       mov       eax,[rcx+8]
       dec       eax
       and       eax,r15d
       mov       rdx,[r12+18]
       mov       r15d,[rbp-4C]
       cmp       r15d,[rdx+8]
       jae       near ptr M09_L11
       mov       r8d,r15d
       shl       r8,4
       mov       r10,rcx
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       near ptr M09_L11
       mov       r10d,[r10+rax*4+10]
       mov       [rdx+r8+14],r10d
       mov       [rcx+rax*4+10],r15d
       mov       byte ptr [r12+2C],0
       jmp       near ptr M09_L13
M09_L06:
       mov       rcx,r12
       call      qword ptr [7FFE77DE5860]
       mov       r12,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M09_L03
M09_L07:
       mov       rcx,r13
       call      qword ptr [7FFE772BE8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M09_L04
M09_L08:
       xor       ecx,ecx
       call      qword ptr [7FFE77C05320]
       int       3
M09_L09:
       mov       ecx,36
       call      qword ptr [7FFE77C0E6D0]
       int       3
M09_L10:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77DE5878]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77715A88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M09_L12:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFE77DE5890]
       jmp       near ptr M09_L05
M09_L13:
       mov       rcx,[rbp-80]
       call      00007FFED6E6FFC0
       test      eax,eax
       jne       near ptr M09_L39
M09_L14:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       lea       rcx,[rsi+18]
       mov       eax,1
       xchg      al,[rcx]
       movzx     eax,al
       test      eax,eax
       je        near ptr M09_L27
M09_L15:
       mov       rax,r13
M09_L16:
       xor       r15d,r15d
       mov       r13d,1
       cmp       [rax+8],r14d
       jbe       near ptr M09_L23
       mov       r15d,1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       [rbx+8],ecx
       jne       near ptr M09_L41
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
       je        near ptr M09_L23
       mov       rcx,[rsi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M09_L47
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M09_L17
       mov       rcx,rsi
       mov       edx,r14d
       call      qword ptr [7FFE77C0F9C0]
M09_L17:
       mov       r13,[rax+8]
       call      qword ptr [7FFE77A7E478]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       mov       edx,[r13+8]
       mov       [rbp-6C],edx
       test      edx,edx
       jle       near ptr M09_L46
       mov       [rbp-70],edx
M09_L18:
       cmp       eax,edx
       jae       near ptr M09_L47
       mov       [rbp-5C],eax
       mov       ecx,eax
       mov       r10,[r13+rcx*8+10]
       mov       [rbp-90],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-60],r9d
       mov       rcx,r10
       call      00007FFED6E20370
       test      eax,eax
       je        near ptr M09_L42
M09_L19:
       mov       rax,[rbp-90]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-64],r8d
       cmp       [rcx+8],r8d
       jbe       short M09_L21
       test      r8d,r8d
       je        near ptr M09_L30
M09_L20:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-64]
       inc       ecx
       mov       rax,[rbp-90]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-60],1
M09_L21:
       mov       rcx,rax
       call      00007FFED6E6FFC0
       test      eax,eax
       jne       near ptr M09_L43
M09_L22:
       cmp       dword ptr [rbp-60],0
       je        near ptr M09_L44
       mov       r13d,1
M09_L23:
       mov       rcx,1DDE6400C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       je        near ptr M09_L36
       mov       rcx,rbx
       call      00007FFED6E834A0
       test      eax,eax
       je        near ptr M09_L31
       mov       [rbp-68],eax
M09_L24:
       mov       edx,[rbx+8]
       mov       [rbp-3C],edx
       mov       rcx,rsi
       call      00007FFED6E834A0
       test      eax,eax
       je        near ptr M09_L32
M09_L25:
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-68]
       mov       r9d,[rbp-3C]
       mov       edx,3
       call      qword ptr [7FFE77C0E3B8]
       test      r13d,r15d
       jne       near ptr M09_L36
       mov       rcx,rbx
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      00007FFED6E834A0
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M09_L33
M09_L26:
       test      r15d,r15d
       jne       near ptr M09_L34
       mov       r14d,0FFFFFFFF
       mov       ecx,1
       jmp       near ptr M09_L35
M09_L27:
       mov       r15,1DDE6401F20
       mov       r12,[r15]
       test      r12,r12
       jne       short M09_L28
       mov       rcx,offset MT_System.Func<System.Object, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,1DDE6401F18
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Buffers.SharedArrayPool`1+<>c[[System.Byte, System.Private.CoreLib]].<InitializeTlsBucketsAndTrimming>b__11_0(System.Object)
       mov       [r12+18],rcx
       mov       rcx,r15
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M09_L28:
       mov       rcx,offset MT_System.Gen2GcCallback
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       xor       edx,edx
       call      00007FFED6E9FFF0
       test      rax,rax
       je        near ptr M09_L40
M09_L29:
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [r15+18],rcx
       jmp       near ptr M09_L15
M09_L30:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       near ptr M09_L20
M09_L31:
       mov       rcx,rbx
       call      qword ptr [7FFE772BE8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       [rbp-68],eax
       jmp       near ptr M09_L24
M09_L32:
       mov       rcx,rsi
       call      qword ptr [7FFE772BE8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M09_L25
M09_L33:
       mov       rcx,rsi
       call      qword ptr [7FFE772BE8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M09_L26
M09_L34:
       xor       ecx,ecx
M09_L35:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,ebx
       call      qword ptr [7FFE77C0E3D0]
M09_L36:
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
M09_L37:
       mov       ecx,0A
       call      qword ptr [7FFE777C4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M09_L00
M09_L38:
       mov       ecx,0B
       call      qword ptr [7FFE777C4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M09_L01
M09_L39:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE77C05EC0]
       jmp       near ptr M09_L14
M09_L40:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFE77DE58A8]
       jmp       near ptr M09_L29
M09_L41:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE77C0E3A0]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE77715B30]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M09_L42:
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE77C060A0]
       jmp       near ptr M09_L19
M09_L43:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE77C05EC0]
       jmp       near ptr M09_L22
M09_L44:
       mov       eax,[rbp-5C]
       inc       eax
       mov       ecx,eax
       mov       edx,[rbp-6C]
       cmp       edx,ecx
       jne       short M09_L45
       xor       ecx,ecx
M09_L45:
       mov       r8d,[rbp-70]
       dec       r8d
       mov       [rbp-70],r8d
       mov       eax,ecx
       jne       near ptr M09_L18
M09_L46:
       xor       r13d,r13d
       jmp       near ptr M09_L23
M09_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-40],0
       je        short M09_L49
       cmp       qword ptr [rbp-80],0
       jne       short M09_L48
       xor       ecx,ecx
       call      qword ptr [7FFE77C05320]
       int       3
M09_L48:
       mov       rcx,[rbp-80]
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M09_L49
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE77C05EC0]
M09_L49:
       nop
       add       rsp,38
       ret
; Total bytes of code 1871
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
       jne       near ptr M11_L20
       mov       rcx,1DDE6401DD0
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       ebp,edx
       mov       rcx,1DDE6400C90
       mov       r14,[rcx]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0B
       jle       short M11_L04
       mov       rcx,[rcx+240]
       mov       rax,[rcx+58]
       test      rax,rax
       je        short M11_L04
M11_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M11_L06
       mov       eax,[rcx+8]
       cmp       eax,r15d
       jbe       near ptr M11_L06
       mov       eax,r15d
       shl       rax,4
       mov       r13,[rcx+rax+10]
       test      r13,r13
       je        short M11_L06
       xor       edx,edx
       mov       [rcx+rax+10],rdx
       cmp       byte ptr [r14+9D],0
       jne       short M11_L05
M11_L01:
       mov       rdx,r13
M11_L02:
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M11_L03:
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
M11_L04:
       mov       ecx,0B
       call      qword ptr [7FFE777C4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M11_L00
M11_L05:
       mov       rcx,r13
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       ebp,[r13+8]
       mov       rcx,rsi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFE77C0E310]
       jmp       short M11_L01
M11_L06:
       mov       rax,[rdi+10]
       cmp       [rax+8],r15d
       jbe       near ptr M11_L15
       mov       ecx,r15d
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        near ptr M11_L14
       mov       r13,[rax+8]
       call      qword ptr [7FFE77A7E478]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       ebp,eax
       sub       ebp,ecx
       xor       esi,esi
       jmp       short M11_L10
M11_L07:
       cmp       ebp,[r13+8]
       jae       near ptr M11_L26
       mov       ecx,ebp
       mov       r12,[r13+rcx*8+10]
       cmp       [r12],r12b
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rcx,r12
       call      qword ptr [7FFE778ACFD8]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r12+8]
       mov       eax,[r12+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M11_L08
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       mov       [rsp+30],rdx
       mov       r8d,eax
       xor       r10d,r10d
       mov       [rcx+r8*8+10],r10
       mov       [r12+10],eax
M11_L08:
       mov       rcx,r12
       call      qword ptr [7FFE772B6820]; System.Threading.Monitor.Exit(System.Object)
       mov       r12,[rsp+30]
       test      r12,r12
       jne       short M11_L11
       inc       ebp
       cmp       [r13+8],ebp
       jne       short M11_L09
       xor       ebp,ebp
M11_L09:
       inc       esi
M11_L10:
       cmp       [r13+8],esi
       jg        short M11_L07
       jmp       short M11_L12
M11_L11:
       mov       r13,r12
       jmp       short M11_L13
M11_L12:
       xor       r13d,r13d
M11_L13:
       test      r13,r13
       je        short M11_L14
       cmp       byte ptr [r14+9D],0
       je        near ptr M11_L01
       mov       rcx,r13
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFE77C0E310]
       jmp       near ptr M11_L01
M11_L14:
       mov       ecx,10
       shlx      ebp,ecx,r15d
       jmp       short M11_L17
M11_L15:
       test      ebp,ebp
       jne       short M11_L16
       mov       rdx,21E7B2C62A0
       jmp       near ptr M11_L02
M11_L16:
       mov       ecx,ebp
       mov       rdx,21E7B2C6F28
       call      qword ptr [7FFE7753D788]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M11_L17:
       cmp       ebp,800
       jge       short M11_L18
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M11_L19
M11_L18:
       mov       ecx,ebp
       xor       edx,edx
       call      qword ptr [7FFE779A6D78]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M11_L19:
       cmp       byte ptr [r14+9D],0
       je        near ptr M11_L01
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFE77C0E310]
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE77C0E328]
       jmp       near ptr M11_L01
M11_L20:
       mov       ecx,[rbx+8]
       mov       rax,[rbx]
       mov       eax,[rax+8]
       sub       eax,[rbx+0C]
       add       ecx,eax
       cmp       edx,ecx
       jg        short M11_L21
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       r8,[rbx]
       mov       rcx,[rbx]
       xor       r9d,r9d
       call      qword ptr [7FFE7745DEA8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
       mov       eax,[rbx+8]
       sub       [rbx+0C],eax
       xor       eax,eax
       mov       [rbx+8],eax
       jmp       near ptr M11_L03
M11_L21:
       mov       ecx,[rbx+0C]
       sub       ecx,[rbx+8]
       add       ecx,edx
       cmp       ecx,7FFFFFC7
       jbe       short M11_L22
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77C0E1F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M11_L22:
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
       jne       short M11_L23
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M11_L24
M11_L23:
       mov       rcx,1DDE6401DD0
       mov       rcx,[rcx]
       call      qword ptr [7FFE779BC8D0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rsi,rax
M11_L24:
       mov       rdi,[rbx]
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       je        short M11_L25
       mov       edx,[rbx+0C]
       sub       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,[rbx+8]
       mov       rcx,rdi
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE7745DEA8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
M11_L25:
       mov       ecx,[rbx+8]
       sub       [rbx+0C],ecx
       xor       ecx,ecx
       mov       [rbx+8],ecx
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+10],0
       je        near ptr M11_L03
       cmp       dword ptr [rdi+8],0
       je        near ptr M11_L03
       mov       rcx,1DDE6401DD0
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
       jmp       qword ptr [7FFE779BC8D8]; Precode of System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M11_L26:
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
       call      qword ptr [7FFFAFF9F470]
       movzx     ecx,byte ptr [rax+1]
       mov       [rbx+95],cl
       movzx     eax,byte ptr [rax+2]
       mov       [rbx+96],al
       mov       word ptr [rbx+90],20
       mov       dword ptr [rbx+84],2
       mov       byte ptr [rbx+9D],1
       mov       dword ptr [rbx+88],40
       call      qword ptr [7FFFAFF9F4E8]
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
       jne       short M13_L01
       mov       rax,[rcx+58]
       test      rax,rax
       jne       short M13_L02
M13_L00:
       lea       rcx,[rcx+20]
       call      qword ptr [7FFFAFF9F230]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
M13_L01:
       mov       rcx,[rcx+20]
       call      qword ptr [7FFFAFFA1550]
       mov       rcx,rax
       call      qword ptr [7FFFAFFA3BE8]
       int       3
M13_L02:
       cmp       rax,rdx
       je        short M13_L00
       xor       r8d,r8d
       mov       [rax+10],r8
       mov       [rcx+58],r8
       jmp       short M13_L00
; Total bytes of code 76
```
```assembly
; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFFAFFA52F8]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFFAFFA32C0]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       test      rax,rax
       cmove     rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 60
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
       call      qword ptr [7FFFB7240038]; Precode of System.Threading.Monitor.Enter(System.Object)
       mov       dword ptr [rbp-48],1
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+8]
       jne       near ptr M16_L18
       mov       rax,[rbx+10]
       mov       r14d,[rax+8]
       xor       r15d,r15d
       test      dil,dil
       jne       near ptr M16_L13
M16_L00:
       test      sil,sil
       je        short M16_L02
       test      r15,r15
       jne       short M16_L01
       mov       rcx,[rbp+10]
       call      qword ptr [7FFFB72408B0]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetCountNoLocks()
       mov       rcx,[rbx+10]
       mov       ecx,[rcx+8]
       shr       ecx,2
       cmp       eax,ecx
       jl        near ptr M16_L12
M16_L01:
       mov       rax,[rbx+10]
       mov       eax,[rax+8]
       add       eax,eax
       js        near ptr M16_L17
       mov       ecx,eax
       call      qword ptr [7FFFB72403B8]; Precode of System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
       call      qword ptr [7FFFB723FF30]; Precode of System.Array.get_MaxLength()
       cmp       eax,r14d
       jl        near ptr M16_L17
M16_L02:
       mov       rsi,[rbx+18]
       mov       rdi,rsi
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+18],0
       je        short M16_L04
       cmp       dword ptr [rsi+8],400
       jge       short M16_L04
       mov       eax,[rsi+8]
       add       eax,eax
       movsxd    rcx,eax
       call      qword ptr [7FFFB723FED8]
       mov       rdi,rax
       mov       r8d,[rsi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFFB723FF18]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,[rbx+18]
       mov       esi,[rax+8]
       mov       r13d,[rdi+8]
       cmp       r13d,esi
       jle       short M16_L04
M16_L03:
       call      qword ptr [7FFFB723FE30]
       mov       r8,rax
       movsxd    rdx,esi
       mov       rcx,rdi
       call      qword ptr [7FFFB723F2A8]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       esi
       cmp       r13d,esi
       jg        short M16_L03
M16_L04:
       mov       rcx,[rbp+10]
       mov       r13,[rcx]
       mov       rcx,r13
       call      qword ptr [7FFFB723F9E0]
       mov       rcx,rax
       movsxd    rdx,r14d
       call      qword ptr [7FFFB723F2C0]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rsi,rax
       mov       [rbp-60],rsi
       mov       ecx,[rdi+8]
       call      qword ptr [7FFFB723FEE0]
       mov       r14,rax
       mov       r12,r15
       test      r12,r12
       jne       short M16_L05
       mov       r12,[rbx+8]
M16_L05:
       mov       rcx,r13
       call      qword ptr [7FFFB723F738]
       mov       rcx,rax
       call      qword ptr [7FFFB723F2B8]; CORINFO_HELP_NEWFAST
       mov       [rbp-78],rax
       lea       rcx,[rax+10]
       mov       rdx,rsi
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+18]
       mov       rdx,rdi
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+20]
       mov       rdx,r14
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rsi+8]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       r12,[rbp-78]
       mov       [r12+28],rax
       mov       rcx,r13
       call      qword ptr [7FFFB723F700]
       mov       rcx,rax
       lea       r8,[rbp-48]
       mov       rdx,rbx
       call      qword ptr [7FFFB72408D0]
       mov       rbx,[rbx+10]
       xor       eax,eax
       mov       edx,[rbx+8]
       cmp       edx,eax
       jg        near ptr M16_L10
M16_L06:
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
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M16_L18
M16_L07:
       test      r15,r15
       jne       near ptr M16_L11
       mov       [rbp-68],rdx
       mov       r8d,[rdx+20]
M16_L08:
       mov       rdx,[rbp-68]
       mov       r10,[rdx+18]
       mov       [rbp-80],r10
       mov       rcx,[r12+10]
       mov       [rbp-4C],r8d
       mov       r9d,r8d
       imul      r9,[r12+28]
       shr       r9,20
       inc       r9
       mov       r11d,[rcx+8]
       mov       esi,r11d
       imul      r9,rsi
       shr       r9,20
       mov       rsi,[r12+18]
       mov       eax,r9d
       xor       edx,edx
       div       dword ptr [rsi+8]
       mov       esi,edx
       cmp       r9d,r11d
       jae       near ptr M16_L15
       mov       eax,r9d
       lea       rax,[rcx+rax*8+10]
       mov       [rbp-70],rax
       mov       rcx,r13
       call      qword ptr [7FFFB723F720]
       mov       rcx,rax
       call      qword ptr [7FFFB723F2B8]; CORINFO_HELP_NEWFAST
       mov       [rbp-88],rax
       mov       r8,[rbp-68]
       mov       rdx,[r8+8]
       mov       r8,[r8+10]
       mov       [rbp-90],r8
       mov       r10,[rbp-70]
       mov       r9,[r10]
       mov       [rbp-98],r9
       lea       rcx,[rax+8]
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-90]
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       lea       rcx,[rax+18]
       mov       rdx,[rbp-98]
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
       mov       ecx,[rbp-4C]
       mov       [rax+20],ecx
       mov       rcx,[rbp-70]
       mov       rdx,rax
       call      qword ptr [7FFFB723F290]; CORINFO_HELP_ASSIGN_REF
       cmp       esi,[r14+8]
       jae       near ptr M16_L15
       mov       eax,esi
       lea       rax,[r14+rax*4+10]
       mov       edx,[rax]
       add       edx,1
       jo        near ptr M16_L16
       mov       [rax],edx
       mov       rsi,[rbp-80]
       test      rsi,rsi
       mov       rdx,rsi
       jne       near ptr M16_L07
M16_L09:
       mov       rax,[rbp-58]
       inc       eax
       mov       edx,[rbx+8]
       cmp       edx,eax
       jle       near ptr M16_L06
M16_L10:
       mov       [rbp-58],rax
       mov       rdx,[rbx+rax*8+10]
       test      rdx,rdx
       jne       near ptr M16_L07
       jmp       short M16_L09
M16_L11:
       mov       [rbp-68],rdx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       call      qword ptr [7FFFB723FBA8]
       mov       r8,[rbp-68]
       mov       rdx,[r8+8]
       mov       rcx,r15
       mov       r11,rax
       call      qword ptr [rax]
       mov       r8d,eax
       jmp       near ptr M16_L08
M16_L12:
       mov       rcx,[rbp+10]
       mov       eax,[rcx+10]
       add       eax,eax
       mov       [rcx+10],eax
       test      eax,eax
       jge       near ptr M16_L18
       jmp       short M16_L14
M16_L13:
       mov       rcx,[rbx+8]
       call      qword ptr [7FFFB723FEF8]
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M16_L00
       mov       rcx,[rbp+10]
       mov       r13,[rcx]
       mov       rcx,r13
       call      qword ptr [7FFFB723F548]
       mov       r15,rax
       mov       rcx,rdi
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFFB723F2C8]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M16_L00
M16_L14:
       mov       dword ptr [rcx+10],7FFFFFFF
       jmp       short M16_L18
M16_L15:
       call      qword ptr [7FFFB723F288]
       int       3
M16_L16:
       call      qword ptr [7FFFB723F280]
       int       3
M16_L17:
       call      qword ptr [7FFFB723FF30]; Precode of System.Array.get_MaxLength()
       mov       r14d,eax
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+10],7FFFFFFF
       jmp       near ptr M16_L02
M16_L18:
       mov       rcx,[rbp+10]
       mov       edx,[rbp-48]
       call      qword ptr [7FFFB72408E0]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32)
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
       call      qword ptr [7FFFB72408E0]; Precode of System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].ReleaseLocks(Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 1137
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
       je        near ptr M17_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       near ptr M17_L07
       mov       rbx,[rcx+0B8]
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M17_L08
M17_L00:
       mov       [rbp-20],rsi
       xor       eax,eax
       mov       [rbp-14],eax
       test      rsi,rsi
       je        short M17_L02
       mov       rcx,rsi
       call      00007FFED6E20370
       test      eax,eax
       jne       short M17_L01
       mov       rcx,rsi
       call      qword ptr [7FFE77C060A0]
M17_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M17_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M17_L03
       mov       rcx,7FFE77D60458
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FFE778A6220]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M17_L04
M17_L02:
       xor       ecx,ecx
       call      qword ptr [7FFE77C05320]
       int       3
M17_L03:
       mov       rcx,7FFE77D60454
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE77C0CBB8]
       int       3
M17_L04:
       mov       rcx,7FFE77D6045C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FFED6E6FFC0
       test      eax,eax
       jne       near ptr M17_L10
M17_L05:
       mov       rcx,7FFE77D60460
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFE77D60464
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M17_L06:
       call      qword ptr [7FFE77C0D6B0]
       int       3
M17_L07:
       mov       rcx,7FFE77D60450
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE77C0CBB8]
       int       3
M17_L08:
       mov       rcx,rbx
       call      qword ptr [7FFE777CC4E0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M17_L09
       call      qword ptr [7FFE77C05848]
       int       3
M17_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFED6E8EEF0
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M17_L00
M17_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE77C05EC0]
       jmp       near ptr M17_L05
       sub       rsp,28
       call      qword ptr [7FFE77C0D6C8]
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
       je        short M17_L12
       mov       rcx,7FFE77D6045C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M17_L11
       xor       ecx,ecx
       call      qword ptr [7FFE77C05320]
       int       3
M17_L11:
       mov       rcx,[rbp-20]
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M17_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFE77C05EC0]
M17_L12:
       mov       rcx,7FFE77D60460
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
       jne       short M18_L00
       mov       rcx,7FFE77D998C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbx+20]
M18_L00:
       test      rdi,rdi
       je        short M18_L02
       mov       rcx,rdi
       mov       rdx,7FFE77D998C8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rdi
       mov       r8,rbx
       mov       rdx,rsi
       mov       r11,7FFE77200DF0
       call      qword ptr [r11]
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M18_L06
       mov       rcx,[rbp+0C0]
       mov       rdx,rsi
       call      qword ptr [7FFE77454A20]; System.Type.op_Equality(System.Type, System.Type)
       test      eax,eax
       je        short M18_L03
       cmp       [rbp+0B8],rbx
       jne       short M18_L04
M18_L01:
       mov       rcx,7FFE77D999E0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M18_L02:
       mov       rcx,7FFE77D998C4
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M18_L03:
       mov       rcx,7FFE77D999D0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp+0C0]
       mov       rcx,rsi
       call      qword ptr [7FFE77C0ED90]
       int       3
M18_L04:
       mov       rcx,7FFE77D999D4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFE77C0EDA8]
       int       3
M18_L05:
       mov       rcx,7FFE77D999D8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M18_L01
M18_L06:
       mov       rcx,21E7B2C19B8
       cmp       rsi,rcx
       jne       short M18_L05
       mov       rcx,7FFE77D999DC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SlimObjectConverter
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE777CD8F0]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       call      qword ptr [7FFE778A51A0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Text.Json.Serialization.JsonConverter, System.Text.Json.JsonSerializerOptions)
       mov       rbp,rsi
       jmp       near ptr M18_L01
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
       call      00007FFED6E34140
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
       mov       rax,7FFE77416D90
       mov       [rbp-78],rax
       lea       rax,[M19_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFED6DD50B0
       call      rax
M19_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFED71EE808],0
       je        short M19_L04
       call      qword ptr [7FFED71DC608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFED6EB03C0
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
       call      qword ptr [7FFE77DE6088]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M19_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE77C06D30]
       jmp       near ptr M19_L00
M19_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M19_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFE772B7C48]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       je        near ptr M20_L04
       mov       [rbp-48],rcx
       mov       rcx,[rbp-48]
       test      rcx,rcx
       je        near ptr M20_L03
       mov       rcx,[rcx+18]
M20_L00:
       lea       rdx,[rbp-48]
       mov       [rbp-90],rdx
       mov       [rbp-88],rcx
       lea       rcx,[rbp-90]
       mov       edx,edi
       lea       r8,[rbp-40]
       mov       rax,7FFE77324D48
       mov       [rbp-70],rax
       lea       rax,[M20_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFED6E38460
       call      rax
M20_L01:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFED71EE808],0
       je        short M20_L02
       call      qword ptr [7FFED71DC608]; CORINFO_HELP_STOP_FOR_GC
M20_L02:
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
M20_L03:
       xor       ecx,ecx
       jmp       near ptr M20_L00
M20_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77C05ED8]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE77C05EF0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 312
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFED6D07E38]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFE772B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       sub       rsp,148
       lea       rbp,[rsp+180]
       xor       eax,eax
       mov       [rbp-138],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+50]
       test      rcx,rcx
       je        near ptr M00_L26
       mov       [rbp-40],rcx
       mov       rcx,17E64401DA0
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9F],0
       je        near ptr M00_L27
M00_L01:
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        near ptr M00_L28
M00_L02:
       mov       r14,rdx
       test      r14,r14
       je        short M00_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
       cmp       [r14],rcx
       jne       near ptr M00_L29
M00_L03:
       mov       rsi,[r14+0B8]
       lea       rdx,[rbp-60]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE778FF660]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       r15d,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M00_L30
       mov       rcx,[rcx+240]
       mov       rsi,[rcx+50]
       test      rsi,rsi
       je        near ptr M00_L30
M00_L04:
       mov       rax,[rsi+10]
       test      rax,rax
       jne       short M00_L05
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,1BEF94262A0
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
       je        near ptr M00_L32
       mov       rcx,17E64401DA8
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FFE77959680]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
M00_L06:
       mov       [rbp-78],rax
       lea       rcx,[rsi+18]
       mov       rdx,[rbp-78]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       byte ptr [rsi+28],1
       mov       [rbp-140],rsi
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12d,[rbp-54]
       mov       edx,r12d
       lea       rdi,[r13+70]
       lea       rsi,[rbp-60]
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
       jne       near ptr M00_L33
       mov       r15,1BEF9421518
M00_L08:
       mov       ecx,[r15+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       short M00_L09
       mov       dword ptr [r13+78],3E8
M00_L09:
       mov       [rbp-148],r13
       jmp       near ptr M00_L17
M00_L10:
       mov       eax,2
       jmp       short M00_L07
M00_L11:
       mov       rcx,[rax+8]
       mov       [rbp-140],rcx
       mov       r13,[rax+10]
       mov       rcx,[rbp-140]
       cmp       [rcx],cl
       mov       rcx,[rbp-140]
       add       rcx,18
       mov       rdx,[rcx]
       mov       edx,[rdx+8]
       sub       edx,[rcx+0C]
       cmp       edx,r15d
       jl        near ptr M00_L15
M00_L12:
       lea       rcx,[r13+8]
       mov       rdx,[rbp-140]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12d,[rbp-54]
       mov       edx,r12d
       lea       rdi,[r13+70]
       lea       rsi,[rbp-60]
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
       jne       near ptr M00_L31
       mov       rsi,1BEF9421518
M00_L14:
       mov       ecx,[rsi+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       near ptr M00_L09
       mov       dword ptr [r13+78],3E8
       jmp       near ptr M00_L09
M00_L15:
       mov       edx,r15d
       call      qword ptr [7FFE778FF6F0]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
       jmp       near ptr M00_L12
M00_L16:
       mov       eax,2
       jmp       short M00_L13
M00_L17:
       cmp       byte ptr [r14+116],0
       jne       near ptr M00_L23
       mov       rcx,[r14+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M00_L21
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L21
       mov       rsi,[r14+0B8]
       mov       rcx,[rbp-40]
       cmp       [rsi],sil
       call      qword ptr [7FFE7728C960]; System.Object.GetType()
       mov       rcx,1BEF94219B8
       cmp       rax,rcx
       je        near ptr M00_L21
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8d,1
       call      qword ptr [7FFE7779C480]; System.Text.Json.JsonSerializerOptions.GetTypeInfoForRootType(System.Type, Boolean)
       mov       r14,rax
       cmp       byte ptr [r14+11A],0
       je        near ptr M00_L20
M00_L18:
       mov       rdx,[r14+0F8]
       test      rdx,rdx
       cmovne    r14,rdx
       mov       rdx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [r14],rdx
       jne       near ptr M00_L24
       mov       rsi,[rbp-40]
       mov       rdx,rsi
       mov       rcx,7FFE779EDA38
       call      qword ptr [7FFE779C6CE8]; System.Text.Json.JsonSerializer.UnboxOnWrite[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       [rbp-120],rax
       lea       r8,[rbp-120]
       mov       rcx,r14
       mov       rdx,r13
       mov       r9,rsi
       call      qword ptr [7FFE778FF7C8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       xor       ecx,ecx
       mov       [rbp-120],rcx
M00_L19:
       mov       rcx,[rbp-140]
       cmp       [rcx],cl
       mov       rcx,[rbp-140]
       add       rcx,18
       lea       rdx,[rbp-130]
       call      qword ptr [7FFE77B6F768]; System.Net.ArrayBuffer.get_ActiveSpan()
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-130]
       call      qword ptr [7FFE77797900]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       lea       rcx,[rbp-50]
       call      qword ptr [7FFE778F57E8]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rsi,rax
       jmp       near ptr M00_L25
M00_L20:
       mov       rcx,r14
       call      qword ptr [7FFE779C5DB8]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[r14+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+11A],1
       jmp       near ptr M00_L18
M00_L21:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-118],ymm0
       vmovdqu   ymmword ptr [rbp-0F8],ymm0
       vmovdqu   ymmword ptr [rbp-0D8],ymm0
       vmovdqu   ymmword ptr [rbp-0B8],ymm0
       vmovdqu   ymmword ptr [rbp-98],ymm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-118]
       mov       rdx,r14
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE779C6D18]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-118]
       mov       [rsp+20],rcx
       mov       rcx,[r14+158]
       mov       r9,[r14+0B8]
       lea       r8,[rbp-40]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFE779C6D30]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L22:
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFE779C7660]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M00_L19
M00_L23:
       mov       rax,[r14+148]
       mov       rdx,r13
       mov       r8,[rbp-40]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M00_L22
M00_L24:
       mov       rcx,r14
       mov       rdx,r13
       mov       r8,[rbp-40]
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L19
M00_L25:
       mov       rcx,r13
       mov       rdx,[rbp-140]
       call      qword ptr [7FFE779C7690]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       [rbp-138],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rbp-138]
       mov       rdx,7FFE77B3BC48
       cmp       [rcx],ecx
       call      qword ptr [7FFE77AAEC10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L26:
       call      qword ptr [7FFE778F62E0]
       mov       ecx,1C77
       mov       rdx,7FFE77625418
       call      qword ptr [7FFE775076F0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFE77625418
       call      qword ptr [7FFE775076F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77287810]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFE77625418
       call      qword ptr [7FFE775076F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77287810]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE77B6F738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE77B6F750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L27:
       mov       rcx,rsi
       call      qword ptr [7FFE77796C70]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L28:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       mov       r9d,101
       mov       rcx,rsi
       mov       rdx,1BEF94219B8
       mov       r8d,1
       call      qword ptr [7FFE7779C498]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r14,rax
       lea       rcx,[rsi+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       jmp       near ptr M00_L02
M00_L29:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L30:
       mov       ecx,0A
       call      qword ptr [7FFE77794420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rsi,rax
       jmp       near ptr M00_L04
M00_L31:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      qword ptr [7FFE77285728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,17E7A400670
       mov       rsi,[rcx]
       jmp       near ptr M00_L14
M00_L32:
       mov       rax,1BEF94262A0
       jmp       near ptr M00_L06
M00_L33:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      qword ptr [7FFE77285728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,17E7A400670
       mov       r15,[rcx]
       jmp       near ptr M00_L08
       sub       rsp,38
       mov       rcx,[rbp-148]
       mov       rdx,[rbp-140]
       call      qword ptr [7FFE779C7690]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       nop
       add       rsp,38
       ret
; Total bytes of code 1757
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
       mov       r8,1BEF9421518
       mov       [rcx+50],r8
M01_L02:
       mov       rcx,1BEF942F9D8
       cmp       r8,rcx
       je        short M01_L04
       cmp       dword ptr [r8+8],1
       jne       short M01_L03
       cmp       word ptr [r8+0C],0A
       je        short M01_L04
M01_L03:
       mov       rcx,1BEF9421518
       cmp       r8,rcx
       je        short M01_L04
       cmp       dword ptr [r8+8],2
       jne       short M01_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M01_L08
M01_L04:
       mov       rcx,1BEF9421518
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
       mov       rdx,7FFE77789C30
       call      qword ptr [7FFE775076F0]
       mov       rcx,rax
       call      qword ptr [7FFE77B6E328]
       int       3
M01_L09:
       or        esi,4
       jmp       short M01_L06
M01_L10:
       cmp       edx,9
       je        short M01_L11
       mov       ecx,38A0
       mov       rdx,7FFE77789C30
       call      qword ptr [7FFE775076F0]
       mov       rcx,rax
       call      qword ptr [7FFE77B6E2E0]
       int       3
M01_L11:
       or        esi,8
       jmp       near ptr M01_L00
M01_L12:
       mov       ecx,38A0
       mov       rdx,7FFE77789C30
       call      qword ptr [7FFE775076F0]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FFE77B6E2F8]
       int       3
M01_L13:
       mov       ecx,38A0
       mov       rdx,7FFE77789C30
       call      qword ptr [7FFE775076F0]
       mov       rcx,rax
       call      qword ptr [7FFE77B6E310]
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
       mov       rcx,17E64400C90
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0B
       jle       short M02_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+58]
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
       mov       ecx,0B
       call      qword ptr [7FFE77794420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M02_L00
M02_L03:
       mov       rcx,r14
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFE77B6E478]
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
       call      qword ptr [7FFE77A46EB0]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FFE7787D2D8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFE77286820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFE77B6E478]
       jmp       near ptr M02_L01
M02_L12:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M02_L15
M02_L13:
       test      ebx,ebx
       jne       short M02_L14
       mov       rax,1BEF94262A0
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
       mov       rdx,1BEF9426F28
       call      qword ptr [7FFE7750D788]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFE778FF798]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M02_L17:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFE77B6E478]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE77B6E490]
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
       mov       rcx,17E64401DA8
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       ebp,edx
       mov       rcx,17E64400C90
       mov       r14,[rcx]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0B
       jle       short M03_L04
       mov       rcx,[rcx+240]
       mov       rax,[rcx+58]
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
       mov       ecx,0B
       call      qword ptr [7FFE77794420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M03_L00
M03_L05:
       mov       rcx,r13
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       ebp,[r13+8]
       mov       rcx,rsi
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFE77B6E478]
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
       call      qword ptr [7FFE77A46EB0]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FFE7787D2D8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFE77286820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFE77B6E478]
       jmp       near ptr M03_L01
M03_L14:
       mov       ecx,10
       shlx      ebp,ecx,r15d
       jmp       short M03_L17
M03_L15:
       test      ebp,ebp
       jne       short M03_L16
       mov       rdx,1BEF94262A0
       jmp       near ptr M03_L02
M03_L16:
       mov       ecx,ebp
       mov       rdx,1BEF9426F28
       call      qword ptr [7FFE7750D788]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFE778FF798]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M03_L19:
       cmp       byte ptr [r14+9D],0
       je        near ptr M03_L01
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFE77B6E478]
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE77B6E490]
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
       call      qword ptr [7FFE7742DEA8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFE77B6E358]
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
       mov       rcx,17E64401DA8
       mov       rcx,[rcx]
       call      qword ptr [7FFE77959680]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFE7742DEA8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rcx,17E64401DA8
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
       jmp       qword ptr [7FFE77959688]; Precode of System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       call      qword ptr [7FFE77285C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M04_L00
; Total bytes of code 41
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoForRootType(System.Type, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       rbp,[rsi+10]
       test      rbp,rbp
       je        short M05_L02
       mov       r14,[rbp+0C0]
M05_L00:
       cmp       r14,rbx
       jne       short M05_L03
M05_L01:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M05_L02:
       xor       r14d,r14d
       jmp       short M05_L00
M05_L03:
       test      r14,r14
       je        short M05_L04
       test      rbx,rbx
       je        short M05_L04
       mov       rdx,r14
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFE77286850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M05_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FFE77286850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M05_L04
       mov       rcx,r14
       mov       rdx,rbx
       mov       rax,[r14]
       mov       rax,[rax+0A8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M05_L01
M05_L04:
       movzx     r9d,dil
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],r9d
       mov       r9d,101
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FFE7779C498]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbp,rax
       lea       rcx,[rsi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L01
; Total bytes of code 199
```
```assembly
; System.Text.Json.JsonSerializer.UnboxOnWrite[[System.__Canon, System.Private.CoreLib]](System.Object)
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rcx,[rcx+18]
       mov       rcx,[rcx]
       mov       rax,rdx
       test      rax,rax
       je        short M06_L00
       cmp       [rax],rcx
       je        short M06_L00
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M06_L00:
       nop
       add       rsp,28
       ret
; Total bytes of code 40
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
M07_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,118
       lea       rbp,[rsp+150]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0F0],ymm4
       vmovdqu   ymmword ptr [rbp-0D0],ymm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       r14,r9
       cmp       byte ptr [rbx+116],0
       jne       near ptr M07_L19
       mov       rcx,[rbx+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M07_L17
       mov       r8,[rsi]
       test      r8,r8
       je        near ptr M07_L17
       mov       r15,[rbx+0B8]
       mov       rcx,r8
       cmp       [r15],r15b
       call      qword ptr [7FFE7728C960]; System.Object.GetType()
       mov       r13,rax
       mov       rcx,1BEF94219B8
       cmp       r13,rcx
       je        near ptr M07_L17
       mov       rbx,[r15+10]
       test      rbx,rbx
       je        short M07_L01
       mov       rcx,[rbx+0C0]
       cmp       rcx,r13
       je        near ptr M07_L09
M07_L01:
       xor       ebx,ebx
       cmp       byte ptr [r15+9E],0
       je        near ptr M07_L08
       mov       rbx,[r15+8]
       test      rbx,rbx
       je        near ptr M07_L20
M07_L02:
       mov       r14,[rbx+8]
       mov       rcx,17E64401938
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M07_L21
M07_L03:
       mov       rdx,r13
       cmp       [r14],r14b
       mov       rax,[r14+8]
       mov       [rbp-0F8],rax
       mov       rcx,[rax+8]
       cmp       byte ptr [r14+19],0
       jne       near ptr M07_L13
       mov       r11,7FFE771D0C58
       call      qword ptr [r11]
M07_L04:
       mov       [rbp-0DC],eax
       mov       r10,[rbp-0F8]
       mov       r9,[r10+8]
       mov       [rbp-100],r9
       mov       rdx,[r10+10]
       mov       ecx,eax
       imul      rcx,[r10+28]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M07_L28
       mov       ecx,ecx
       mov       r11,[rdx+rcx*8+10]
       test      r11,r11
       je        near ptr M07_L15
M07_L05:
       cmp       eax,[r11+20]
       jne       near ptr M07_L14
       mov       [rbp-108],r11
       mov       rdx,[r11+8]
       mov       rcx,r9
       mov       r8,r13
       mov       r11,7FFE771D0C60
       call      qword ptr [r11]
       test      eax,eax
       mov       r9,[rbp-100]
       mov       r11,[rbp-108]
       je        near ptr M07_L14
       mov       rdx,[r11+10]
       mov       [rbp-0E8],rdx
M07_L06:
       mov       r8,[rbp-0E8]
       xor       ecx,ecx
       mov       [rbp-0E8],rcx
       cmp       byte ptr [r8+20],0
       je        near ptr M07_L23
       mov       rcx,[r8+10]
       test      rcx,rcx
       jne       near ptr M07_L22
       mov       rbx,[r8+8]
M07_L07:
       test      rbx,rbx
       je        short M07_L08
       cmp       byte ptr [rbx+119],2
       jne       near ptr M07_L24
M07_L08:
       test      rbx,rbx
       je        near ptr M07_L25
       lea       rcx,[r15+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M07_L09:
       cmp       byte ptr [rbx+11A],0
       je        near ptr M07_L16
M07_L10:
       mov       r8,[rbx+0F8]
       test      r8,r8
       cmovne    rbx,r8
       mov       r9,[rsi]
       mov       r8,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rbx],r8
       jne       near ptr M07_L27
       mov       r8,r9
       test      r8,r8
       je        short M07_L11
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       cmp       [r8],rcx
       jne       near ptr M07_L26
M07_L11:
       mov       [rbp-0F0],r8
       lea       r8,[rbp-0F0]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFE778FF7C8]
M07_L12:
       nop
       add       rsp,118
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L13:
       mov       rcx,rdx
       mov       rdx,[7FFE771CA1C0]
       call      qword ptr [rdx+18]
       jmp       near ptr M07_L04
M07_L14:
       mov       r11,[r11+18]
       test      r11,r11
       je        short M07_L15
       mov       eax,[rbp-0DC]
       jmp       near ptr M07_L05
M07_L15:
       xor       edx,edx
       mov       [rbp-0E8],rdx
       mov       rdx,r13
       mov       r8,rbx
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-0E8]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,[rbp-0DC]
       shl       r9,20
       or        r9,1
       mov       rdx,[rbp-0F8]
       mov       r8,r13
       mov       rcx,r14
       call      qword ptr [7FFE776E7FC0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M07_L06
M07_L16:
       mov       rcx,rbx
       call      qword ptr [7FFE779C5DB8]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       lea       rcx,[rbx+0F8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+11A],1
       jmp       near ptr M07_L10
M07_L17:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-0D8],ymm0
       vmovdqu   ymmword ptr [rbp-0B8],ymm0
       vmovdqu   ymmword ptr [rbp-98],ymm0
       vmovdqu   ymmword ptr [rbp-78],ymm0
       vmovdqu   ymmword ptr [rbp-58],ymm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0D8]
       mov       rdx,rbx
       mov       r8,r14
       xor       r9d,r9d
       call      qword ptr [7FFE779C6D18]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-0D8]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+158]
       mov       r9,[rbx+0B8]
       mov       rdx,rdi
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE779C6D30]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M07_L18:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE779C7660]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M07_L12
M07_L19:
       mov       rax,[rbx+148]
       mov       r8,[rsi]
       mov       rdx,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M07_L18
M07_L20:
       mov       rcx,r15
       call      qword ptr [7FFE7779C4B0]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbx,rax
       jmp       near ptr M07_L02
M07_L21:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE771CD050
       mov       [r12+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [r12+20],rcx
       mov       rcx,17E64401938
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M07_L03
M07_L22:
       call      qword ptr [7FFE77B6E208]
       int       3
M07_L23:
       mov       rcx,rbx
       mov       rdx,r13
       call      qword ptr [7FFE77B6E4A8]
       mov       rbx,rax
       jmp       near ptr M07_L07
M07_L24:
       mov       rcx,rbx
       call      qword ptr [7FFE77876208]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M07_L08
M07_L25:
       mov       rdx,[r15+20]
       mov       rcx,r13
       call      qword ptr [7FFE77B6E220]
       int       3
M07_L26:
       mov       rdx,r9
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M07_L27:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,r9
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M07_L12
M07_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1170
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
       call      qword ptr [7FFE774270D8]
       int       3
; Total bytes of code 77
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       ret
; Total bytes of code 16
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
       mov       r8,17E644013A8
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
       call      qword ptr [7FFE77424B88]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
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
       call      00007FFED6EDF840
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
       call      qword ptr [7FFE77424BB8]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
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
       call      qword ptr [7FFE778F5608]
       int       3
M10_L03:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FFE77B6EC88]
       int       3
M10_L04:
       mov       r15,1BEF9420008
M10_L05:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       short M10_L09
M10_L06:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FFE77B6EC88]
       int       3
M10_L07:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FFE77B6ECA0]
       add       r14d,eax
       jns       near ptr M10_L00
       call      qword ptr [7FFE77B6ECB8]
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
       call      qword ptr [7FFE77B6ECD0]
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
       call      qword ptr [7FFE77B6ECE8]
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
       call      qword ptr [7FFFAFFA5DB0]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
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
       call      qword ptr [7FFFAFFA5DB0]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
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
       jne       short M12_L01
M12_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M12_L01:
       mov       rcx,[rdi+38]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       dword ptr [rdi+8C],2
       jne       short M12_L00
       test      rbp,rbp
       je        short M12_L00
       mov       rcx,[rsi+0C0]
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        short M12_L00
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
       mov       rax,17E644013D0
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
       call      qword ptr [7FFE77B6DA10]
       mov       rcx,[rbp+30]
M13_L04:
       test      byte ptr [rbx+7C],1
       jne       short M13_L05
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FFE779C7138]; System.Text.Json.Utf8JsonWriter.WriteStringMinimized(System.ReadOnlySpan`1<Char>)
       jmp       short M13_L07
M13_L05:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FFE77B6DA28]
       jmp       short M13_L07
M13_L06:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FFE77AA7060]; System.Text.Json.Utf8JsonWriter.WriteStringEscapeValue(System.ReadOnlySpan`1<Char>, Int32)
M13_L07:
       or        dword ptr [rbx+28],80000000
       mov       byte ptr [rbx+3A],7
       jmp       short M13_L09
M13_L08:
       mov       rcx,rbx
       call      qword ptr [7FFE779C7348]
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
       call      qword ptr [7FFE779C6D60]; System.Text.Json.WriteStack.Push()
       mov       r8,[rdi]
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SmallObjectWithParameterizedConstructorConverter<DotNetTips.Spargine.Tester.Models.RefTypes.Address, System.String, System.Object, System.Object, System.Object>
       cmp       [rsi],rcx
       jne       short M13_L20
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FFE778AA880]; System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[[System.__Canon, System.Private.CoreLib]].OnTryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       mov       r15d,eax
M13_L18:
       mov       rcx,[rbp+30]
       mov       edx,r15d
       call      qword ptr [7FFE779C7198]; System.Text.Json.WriteStack.Pop(Boolean)
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
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       mov       r15d,eax
       jmp       short M13_L18
M13_L21:
       mov       ecx,[r14+88]
       call      qword ptr [7FFE779C7318]
       int       3
M13_L22:
       mov       rcx,rbx
       call      qword ptr [7FFE779C7348]
       jmp       near ptr M13_L10
M13_L23:
       cmp       byte ptr [rsi+1A],0
       je        near ptr M13_L01
       mov       rdi,[rdi]
       add       rcx,90
       call      qword ptr [7FFE778F56E0]; System.Nullable`1[[System.Text.Json.Serialization.JsonNumberHandling, System.Text.Json]].get_Value()
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
       call      qword ptr [7FFE77B6D9E0]
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
       call      qword ptr [7FFE779C72B8]
       int       3
M13_L27:
       mov       rcx,r13
       call      qword ptr [7FFE77876208]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M13_L13
M13_L28:
       mov       [rsp+20],rcx
       mov       rdx,[rdi]
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FFE77B6D590]
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
       call      qword ptr [7FFE77B6D5A8]
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
       call      qword ptr [7FFE77B6E550]
M13_L34:
       mov       rdx,rbx
       mov       rcx,offset MT_System.InvalidOperationException
       call      qword ptr [7FFE77286850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M13_L36
       mov       rdx,rbx
       mov       rcx,offset MT_System.Text.Json.JsonException
       call      qword ptr [7FFE77286850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M13_L35
       mov       rcx,rsi
       call      qword ptr [7FFE77B6E568]
       test      rax,rax
       jne       near ptr M13_L38
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FFE77B6E580]
       jmp       near ptr M13_L38
M13_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.NotSupportedException
       call      qword ptr [7FFE77286850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M13_L38
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,1BEF942E9D0
       cmp       [rcx],ecx
       call      qword ptr [7FFE77B6E5B0]
       test      eax,eax
       jne       short M13_L38
       jmp       short M13_L37
M13_L36:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       rdx,1BEF942E980
       call      qword ptr [7FFE77504E40]; System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M13_L38
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFE77B6E598]
       jmp       short M13_L38
M13_L37:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFE77B6E5C8]
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
       call      qword ptr [7FFE77B6EB80]
       int       3
M14_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M14_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE77BA8A40]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFE77B6EBB0]
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
       call      qword ptr [7FFE77B6EBC8]
M14_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M14_L02
M14_L06:
       mov       r11,7FFE771D0CF0
       call      qword ptr [r11]
       jmp       near ptr M14_L01
; Total bytes of code 232
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
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M15_L38
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       je        near ptr M15_L38
M15_L00:
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
       mov       rcx,1BEF94262A0
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M15_L37
       cmp       dword ptr [rbx+8],0
       je        near ptr M15_L37
       mov       rcx,17E64401DA8
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
       cmp       dword ptr [rcx+238],0B
       jle       near ptr M15_L39
       mov       rcx,[rcx+240]
       mov       r15,[rcx+58]
       test      r15,r15
       je        near ptr M15_L39
M15_L01:
       mov       rax,[r15+10]
       test      rax,rax
       jne       near ptr M15_L17
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
       je        near ptr M15_L08
       mov       rcx,[rbp-80]
       call      00007FFED6E20370
       test      eax,eax
       je        near ptr M15_L09
M15_L02:
       mov       dword ptr [rbp-40],1
       mov       rcx,[r15+10]
       lea       r8,[rbp-48]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFE7750CE88]; System.Runtime.CompilerServices.ConditionalWeakTable`2+Container[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindEntry(System.__Canon, System.Object ByRef)
       cmp       eax,0FFFFFFFF
       jne       near ptr M15_L10
       mov       r12,[r15+10]
       mov       ecx,[r12+28]
       mov       rax,[r12+18]
       cmp       ecx,[rax+8]
       jge       near ptr M15_L06
M15_L03:
       cmp       byte ptr [r12+2C],0
       jne       near ptr M15_L11
       mov       byte ptr [r12+2C],1
       mov       rcx,r13
       call      00007FFED6E834A0
       test      eax,eax
       je        near ptr M15_L07
M15_L04:
       mov       r15d,eax
       and       r15d,7FFFFFFF
       mov       eax,[r12+28]
       mov       [rbp-4C],eax
       lea       ecx,[rax+1]
       mov       [r12+28],ecx
       mov       rcx,[r12+18]
       cmp       eax,[rcx+8]
       jae       near ptr M15_L12
       mov       edx,eax
       shl       rdx,4
       lea       r8,[rcx+rdx+10]
       mov       [r8],r15d
       mov       [rbp-88],r8
       mov       rcx,r13
       xor       edx,edx
       call      00007FFED6EC3BA0
       test      rax,rax
       je        near ptr M15_L13
M15_L05:
       mov       rcx,[rbp-88]
       mov       [rcx+8],rax
       mov       rcx,[r12+10]
       mov       eax,[rcx+8]
       dec       eax
       and       eax,r15d
       mov       rdx,[r12+18]
       mov       r15d,[rbp-4C]
       cmp       r15d,[rdx+8]
       jae       near ptr M15_L12
       mov       r8d,r15d
       shl       r8,4
       mov       r10,rcx
       mov       r9d,[r10+8]
       cmp       eax,r9d
       jae       near ptr M15_L12
       mov       r10d,[r10+rax*4+10]
       mov       [rdx+r8+14],r10d
       mov       [rcx+rax*4+10],r15d
       mov       byte ptr [r12+2C],0
       jmp       near ptr M15_L14
M15_L06:
       mov       rcx,r12
       call      qword ptr [7FFE77B6F948]
       mov       r12,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M15_L03
M15_L07:
       mov       rcx,r13
       call      qword ptr [7FFE7728E8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M15_L04
M15_L08:
       xor       ecx,ecx
       call      qword ptr [7FFE77B6D110]
       int       3
M15_L09:
       mov       rcx,[rbp-80]
       call      qword ptr [7FFE77B6F1C8]
       jmp       near ptr M15_L02
M15_L10:
       mov       ecx,36
       call      qword ptr [7FFE77B6F930]
       int       3
M15_L11:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77B6F960]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE776E5A88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M15_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M15_L13:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFE77B6F978]
       jmp       near ptr M15_L05
M15_L14:
       mov       rcx,[rbp-80]
       call      00007FFED6E6FFC0
       test      eax,eax
       jne       near ptr M15_L40
M15_L15:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       lea       rcx,[rsi+18]
       mov       eax,1
       xchg      al,[rcx]
       movzx     eax,al
       test      eax,eax
       je        near ptr M15_L28
M15_L16:
       mov       rax,r13
M15_L17:
       xor       r15d,r15d
       mov       r13d,1
       cmp       [rax+8],r14d
       jbe       near ptr M15_L24
       mov       r15d,1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       [rbx+8],ecx
       jne       near ptr M15_L42
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
       je        near ptr M15_L24
       mov       rcx,[rsi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M15_L48
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M15_L18
       mov       rcx,rsi
       mov       edx,r14d
       call      qword ptr [7FFE77B6E280]
M15_L18:
       mov       r13,[rax+8]
       call      qword ptr [7FFE77A46EB0]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       sub       eax,ecx
       mov       edx,[r13+8]
       mov       [rbp-6C],edx
       test      edx,edx
       jle       near ptr M15_L47
       mov       [rbp-70],edx
M15_L19:
       cmp       eax,edx
       jae       near ptr M15_L48
       mov       [rbp-5C],eax
       mov       ecx,eax
       mov       r10,[r13+rcx*8+10]
       mov       [rbp-90],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-60],r9d
       mov       rcx,r10
       call      00007FFED6E20370
       test      eax,eax
       je        near ptr M15_L43
M15_L20:
       mov       rax,[rbp-90]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp-64],r8d
       cmp       [rcx+8],r8d
       jbe       short M15_L22
       test      r8d,r8d
       je        near ptr M15_L31
M15_L21:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-64]
       inc       ecx
       mov       rax,[rbp-90]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-60],1
M15_L22:
       mov       rcx,rax
       call      00007FFED6E6FFC0
       test      eax,eax
       jne       near ptr M15_L44
M15_L23:
       cmp       dword ptr [rbp-60],0
       je        near ptr M15_L45
       mov       r13d,1
M15_L24:
       mov       rcx,17E64400C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       je        near ptr M15_L37
       mov       rcx,rbx
       call      00007FFED6E834A0
       test      eax,eax
       je        near ptr M15_L32
       mov       [rbp-68],eax
M15_L25:
       mov       edx,[rbx+8]
       mov       [rbp-3C],edx
       mov       rcx,rsi
       call      00007FFED6E834A0
       test      eax,eax
       je        near ptr M15_L33
M15_L26:
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-68]
       mov       r9d,[rbp-3C]
       mov       edx,3
       call      qword ptr [7FFE77B6E2B0]
       test      r13d,r15d
       jne       near ptr M15_L37
       mov       rcx,rbx
       call      qword ptr [7FFE7779C630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      00007FFED6E834A0
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M15_L34
M15_L27:
       test      r15d,r15d
       jne       near ptr M15_L35
       mov       r14d,0FFFFFFFF
       mov       ecx,1
       jmp       near ptr M15_L36
M15_L28:
       mov       r15,17E64401EF8
       mov       r12,[r15]
       test      r12,r12
       jne       short M15_L29
       mov       rcx,offset MT_System.Func<System.Object, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,17E64401EF0
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Buffers.SharedArrayPool`1+<>c[[System.Byte, System.Private.CoreLib]].<InitializeTlsBucketsAndTrimming>b__11_0(System.Object)
       mov       [r12+18],rcx
       mov       rcx,r15
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M15_L29:
       mov       rcx,offset MT_System.Gen2GcCallback
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       xor       edx,edx
       call      00007FFED6E9FFF0
       test      rax,rax
       je        near ptr M15_L41
M15_L30:
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       [r15+18],rcx
       jmp       near ptr M15_L16
M15_L31:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       near ptr M15_L21
M15_L32:
       mov       rcx,rbx
       call      qword ptr [7FFE7728E8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       [rbp-68],eax
       jmp       near ptr M15_L25
M15_L33:
       mov       rcx,rsi
       call      qword ptr [7FFE7728E8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M15_L26
M15_L34:
       mov       rcx,rsi
       call      qword ptr [7FFE7728E8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M15_L27
M15_L35:
       xor       ecx,ecx
M15_L36:
       mov       [rsp+20],r14d
       mov       [rsp+28],ecx
       mov       rcx,r12
       mov       edx,r13d
       mov       r8d,ebx
       call      qword ptr [7FFE77B6E2C8]
M15_L37:
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
M15_L38:
       mov       ecx,0A
       call      qword ptr [7FFE77794420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M15_L00
M15_L39:
       mov       ecx,0B
       call      qword ptr [7FFE77794420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M15_L01
M15_L40:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE77B6D128]
       jmp       near ptr M15_L15
M15_L41:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFE77B6F990]
       jmp       near ptr M15_L30
M15_L42:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE77B6E268]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFE771C4000
       call      qword ptr [7FFE775076F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE776E5B30]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M15_L43:
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE77B6F1C8]
       jmp       near ptr M15_L20
M15_L44:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE77B6D128]
       jmp       near ptr M15_L23
M15_L45:
       mov       eax,[rbp-5C]
       inc       eax
       mov       ecx,eax
       mov       edx,[rbp-6C]
       cmp       edx,ecx
       jne       short M15_L46
       xor       ecx,ecx
M15_L46:
       mov       r8d,[rbp-70]
       dec       r8d
       mov       [rbp-70],r8d
       mov       eax,ecx
       jne       near ptr M15_L19
M15_L47:
       xor       r13d,r13d
       jmp       near ptr M15_L24
M15_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       cmp       dword ptr [rbp-40],0
       je        short M15_L50
       cmp       qword ptr [rbp-80],0
       jne       short M15_L49
       xor       ecx,ecx
       call      qword ptr [7FFE77B6D110]
       int       3
M15_L49:
       mov       rcx,[rbp-80]
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M15_L50
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE77B6D128]
M15_L50:
       nop
       add       rsp,38
       ret
; Total bytes of code 1880
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
       je        near ptr M17_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M17_L01
       test      rsi,rsi
       je        short M17_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M17_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M17_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFED6EDF840
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE77285818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE77285818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M17_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M17_L01:
       test      rsi,rsi
       je        short M17_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M17_L03
M17_L02:
       mov       rax,1BEF9420008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M17_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M17_L04:
       call      qword ptr [7FFE77B6F9A8]
       int       3
; Total bytes of code 231
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
       call      qword ptr [7FFFAFF9F478]
       cmp       byte ptr [rax],0
       je        near ptr M18_L04
       call      qword ptr [7FFFAFFA5968]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M18_L00
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFFAFF9F230]; CORINFO_HELP_ASSIGN_REF
       jmp       short M18_L01
M18_L00:
       call      qword ptr [7FFFAFFA1550]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M18_L02
M18_L01:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M18_L02:
       call      qword ptr [7FFFAFF9F470]
       cmp       byte ptr [rax],0
       je        short M18_L01
       xorps     xmm0,xmm0
       movups    [rsp+30],xmm0
       mov       [rsp+30],rdi
       mov       [rsp+38],rsi
       lea       rcx,[rsp+20]
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       lea       r8,[rsp+30]
       mov       r9d,2
       call      qword ptr [7FFFAFFA6E98]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFFAFFA5998]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FFFAFF9F230]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M18_L01
       cmp       [rsi+10],rbx
       je        short M18_L03
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+9F],0
       jne       short M18_L03
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFFAFFA5250]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M18_L01
M18_L03:
       mov       rcx,[rsi+8]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M18_L01
M18_L04:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M18_L05
       call      qword ptr [7FFFAFFA1568]
       test      rax,rax
       je        near ptr M18_L01
M18_L05:
       call      qword ptr [7FFFAFFA3BD0]
       int       3
; Total bytes of code 286
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
       je        near ptr M19_L11
       mov       rbp,[rbx+8]
       test      rbp,rbp
       je        short M19_L07
M19_L00:
       cmp       [rbp],bpl
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFFAFFA52C0]; Precode of System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       mov       r14,rax
       cmp       byte ptr [rsp+78],0
       jne       short M19_L08
M19_L01:
       mov       rcx,[r14+10]
       test      rcx,rcx
       jne       short M19_L09
M19_L02:
       mov       rbp,[r14+8]
M19_L03:
       test      dil,dil
       je        short M19_L04
       test      rbp,rbp
       je        short M19_L04
       cmp       byte ptr [rbp+119],2
       jne       short M19_L06
M19_L04:
       test      rbp,rbp
       je        short M19_L12
M19_L05:
       mov       rax,rbp
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M19_L06:
       mov       rcx,rbp
       call      qword ptr [7FFFAFFA5D18]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       short M19_L04
M19_L07:
       mov       rcx,rbx
       call      qword ptr [7FFFAFFA52A0]; Precode of System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rbp,rax
       jmp       short M19_L00
M19_L08:
       cmp       byte ptr [r14+20],0
       je        short M19_L10
       jmp       short M19_L01
M19_L09:
       call      qword ptr [7FFFAFFA2030]
       jmp       short M19_L02
M19_L10:
       mov       rcx,rbp
       mov       rdx,rsi
       mov       r8,r14
       call      qword ptr [7FFFAFFA52D0]
       mov       rbp,rax
       jmp       short M19_L03
M19_L11:
       cmp       byte ptr [rsp+70],0
       je        short M19_L04
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFFAFFA5260]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbp,rax
       jmp       short M19_L04
M19_L12:
       cmp       byte ptr [rsp+69],0
       je        short M19_L05
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FFFAFFA3DC8]
       int       3
; Total bytes of code 232
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M20_L00
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M20_L00
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M20_L01
M20_L00:
       mov       rax,rdx
       ret
M20_L01:
       test      rax,rax
       je        short M20_L04
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M20_L00
       jmp       short M20_L03
M20_L02:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M20_L00
       jmp       short M20_L01
M20_L03:
       test      rax,rax
       je        short M20_L04
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M20_L00
       test      rax,rax
       je        short M20_L04
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M20_L00
       test      rax,rax
       jne       short M20_L02
M20_L04:
       jmp       qword ptr [7FFE77B6F2A0]
; Total bytes of code 92
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFED6D07E38]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFE77285C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       mov       rcx,[rbx+48]
       test      rcx,rcx
       je        near ptr M00_L37
       mov       [rbp-40],rcx
       mov       rcx,277A8801DC8
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
       mov       rcx,277A8801938
       mov       r15,[rcx]
       test      r15,r15
       jne       short M00_L03
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE771DD050
       mov       [r15+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [r15+20],rcx
       mov       rcx,277A8801938
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M00_L03:
       cmp       [rdi],dil
       mov       r13,[rdi+8]
       mov       rcx,[r13+8]
       cmp       byte ptr [rdi+19],0
       jne       near ptr M00_L07
       mov       r11,7FFE771E1048
       mov       rdx,2B83D7619B8
       call      qword ptr [r11]
       mov       r12d,eax
M00_L04:
       lea       r9,[rbp-48]
       mov       [rsp+20],r9
       mov       r9d,r12d
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       mov       r8,2B83D7619B8
       call      qword ptr [7FFE776F6118]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       jne       short M00_L05
       mov       r8,rsi
       mov       rdx,2B83D7619B8
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
       mov       r8,2B83D7619B8
       call      qword ptr [7FFE776F7FC0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
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
       mov       rcx,2B83D7619B8
       call      qword ptr [7FFE77C96928]
       int       3
M00_L07:
       mov       rcx,2B83D7619B8
       mov       rax,[7FFE771DA1C0]
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
       call      qword ptr [7FFE779A72B8]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       r15d,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M00_L43
       mov       rcx,[rcx+240]
       mov       rsi,[rcx+50]
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
       mov       rcx,2B83D7662A0
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
       mov       rcx,277A8801DD0
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FFE779CE0C0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       r15,2B83D761518
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
       mov       rsi,2B83D761518
M00_L21:
       mov       ecx,[rsi+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       near ptr M00_L16
       mov       dword ptr [r13+78],3E8
       jmp       near ptr M00_L16
M00_L22:
       mov       edx,r15d
       call      qword ptr [7FFE779A7348]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
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
       call      qword ptr [7FFE7729C960]; System.Object.GetType()
       mov       r9,2B83D7619B8
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
       call      qword ptr [7FFE779A7420]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
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
       call      qword ptr [7FFE779AF2B8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rcx,[rbp-128]
       mov       eax,[rbp-120]
       mov       [rbp-140],rcx
       mov       [rbp-138],eax
       lea       rcx,[rbp-140]
       call      qword ptr [7FFE779057E8]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rsi,rax
       jmp       near ptr M00_L36
M00_L29:
       mov       rcx,r14
       call      qword ptr [7FFE779AD9F8]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
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
       call      qword ptr [7FFE779AE958]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-110]
       mov       [rsp+20],rcx
       mov       rcx,[r14+158]
       mov       r9,[r14+0B8]
       lea       r8,[rbp-40]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFE779AE970]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L31:
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFE779AF2A0]; System.Text.Json.Utf8JsonWriter.Flush()
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
       call      qword ptr [7FFE777AC498]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FFE779AF2D0]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       [rbp-130],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rbp-130]
       mov       rdx,7FFE77B961D0
       cmp       [rcx],ecx
       call      qword ptr [7FFE77B368E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE7790DF20]
       mov       ecx,1C77
       mov       rdx,7FFE77635418
       call      qword ptr [7FFE775176F0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFE77635418
       call      qword ptr [7FFE775176F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77297810]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFE77635418
       call      qword ptr [7FFE775176F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77297810]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE77C9EEC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE77B3FC90]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L38:
       mov       rcx,r14
       call      qword ptr [7FFE777A6C70]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L39:
       mov       rcx,r14
       call      qword ptr [7FFE777AC4B0]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L40:
       mov       rcx,rax
       call      qword ptr [7FFE77C96910]
       int       3
M00_L41:
       mov       rcx,rsi
       call      qword ptr [7FFE77886208]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L06
M00_L42:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L43:
       mov       ecx,0A
       call      qword ptr [7FFE777A4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rsi,rax
       jmp       near ptr M00_L11
M00_L44:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,277BE800790
       mov       rsi,[rcx]
       jmp       near ptr M00_L21
M00_L45:
       mov       rax,2B83D7662A0
       jmp       near ptr M00_L13
M00_L46:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,277BE800790
       mov       r15,[rcx]
       jmp       near ptr M00_L15
       sub       rsp,48
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-148]
       call      qword ptr [7FFE779AF2D0]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
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
       call      qword ptr [7FFE777ACA50]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M01_L00:
       mov       rcx,7FFE77D61FD4
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
       mov       rcx,7FFE77D61FD0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77C97450]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE77C9CAF8]
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
       je        near ptr M02_L04
M02_L00:
       cmp       esi,[r14+20]
       jne       near ptr M02_L03
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       je        short M02_L02
M02_L01:
       mov       rcx,rbp
       mov       rdx,7FFE77D210D8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rbp
       mov       rdx,[r14+8]
       mov       r11,r15
       mov       r8,rdi
       call      qword ptr [r15]
       test      eax,eax
       je        near ptr M02_L05
       mov       rcx,7FFE77D211E0
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
       mov       rdx,7FFE77D15D10
       call      qword ptr [7FFE7729C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
       jmp       short M02_L01
M02_L03:
       mov       rcx,7FFE77D211E8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r14,[r14+18]
       test      r14,r14
       jne       near ptr M02_L00
M02_L04:
       mov       rcx,7FFE77D211EC
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
M02_L05:
       mov       rcx,7FFE77D211E4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M02_L03
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
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
       mov       rax,[rbp+18]
       mov       rax,[rax+8]
       mov       [rbp-50],rax
       mov       ebx,[rbp+2C]
       test      r9d,r9d
       jne       near ptr M03_L40
       cmp       byte ptr [rcx+19],0
       jne       near ptr M03_L39
       mov       rax,[rcx]
       mov       r8,[rax+30]
       mov       r8,[r8]
       mov       r11,[r8+78]
       test      r11,r11
       je        near ptr M03_L38
M03_L00:
       mov       rcx,[rbp-50]
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
M03_L01:
       mov       [rbp-3C],eax
M03_L02:
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
       jae       near ptr M03_L42
       mov       ecx,r9d
       lea       rbx,[r10+rcx*8+10]
       xor       esi,esi
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       byte ptr [rbp+40],0
       je        short M03_L04
       mov       rcx,7FFE77D680CC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-58]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M03_L25
       mov       rcx,[rbp-58]
       mov       eax,[rbp-40]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        near ptr M03_L17
       mov       rcx,r14
       call      00007FFED6E20370
       test      eax,eax
       jne       short M03_L03
       mov       rcx,r14
       call      qword ptr [7FFE77B3FE40]
M03_L03:
       mov       dword ptr [rbp-44],1
M03_L04:
       mov       rcx,[rbp+18]
       mov       r8,[rbp+10]
       cmp       rcx,[r8+8]
       jne       near ptr M03_L18
       xor       r14d,r14d
       mov       r15,[rbx]
       test      r15,r15
       jne       near ptr M03_L08
M03_L05:
       mov       rcx,[r8]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        near ptr M03_L16
M03_L06:
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
       jg        near ptr M03_L28
M03_L07:
       cmp       r14d,64
       ja        near ptr M03_L29
       mov       rcx,7FFE77D680E4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L30
M03_L08:
       mov       ecx,[rbp-3C]
       cmp       ecx,[r15+20]
       jne       short M03_L11
       mov       rcx,[r8]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M03_L12
       mov       rcx,rax
M03_L09:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M03_L13
M03_L10:
       mov       rdx,[r15+8]
       mov       rcx,[rbp-50]
       mov       r8,[rbp+20]
       call      qword ptr [r11]
       test      eax,eax
       jne       short M03_L14
       mov       rcx,7FFE77D680D8
       call      CORINFO_HELP_COUNTPROFILE32
M03_L11:
       mov       rcx,7FFE77D680E8
       call      CORINFO_HELP_COUNTPROFILE32
       inc       r14d
       mov       rcx,7FFE77D680EC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r15,[r15+18]
       test      r15,r15
       mov       r8,[rbp+10]
       jne       near ptr M03_L08
       jmp       near ptr M03_L05
M03_L12:
       mov       rdx,7FFE77D164E8
       call      qword ptr [7FFE7729C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L09
M03_L13:
       mov       rdx,7FFE77D15D10
       call      qword ptr [7FFE7729C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M03_L10
M03_L14:
       cmp       byte ptr [rbp+38],0
       je        near ptr M03_L27
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L15:
       xor       ecx,ecx
       mov       [rbp-48],ecx
       jmp       near ptr M03_L37
M03_L16:
       mov       rdx,7FFE77D4A8B8
       call      qword ptr [7FFE7729C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M03_L06
M03_L17:
       xor       ecx,ecx
       call      qword ptr [7FFE77B3F0C0]
       int       3
M03_L18:
       mov       rcx,[r8+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp-50]
       mov       rax,[rbp+18]
       cmp       rcx,[rax+8]
       je        short M03_L23
       mov       rcx,7FFE77D680D0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       mov       [rbp-50],rcx
       mov       r8,[rbp+10]
       cmp       byte ptr [r8+19],0
       jne       short M03_L21
       mov       rcx,[r8]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        short M03_L19
       jmp       short M03_L20
M03_L19:
       mov       rdx,7FFE77D15C08
       call      qword ptr [7FFE7729C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L20:
       mov       rcx,[rbp-50]
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       jmp       short M03_L22
M03_L21:
       mov       rcx,[rbp+20]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
M03_L22:
       mov       [rbp-3C],eax
M03_L23:
       mov       rcx,7FFE77D680D4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L35
M03_L24:
       mov       rcx,7FFE77D680DC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L30
M03_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L27:
       mov       rcx,7FFE77D680E0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[r15+10]
       mov       rcx,[rbp+48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L15
M03_L28:
       mov       rcx,7FFE77D680F0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       esi,1
       jmp       near ptr M03_L07
M03_L29:
       mov       rdx,[rbp-50]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FFE77296850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L24
       mov       rcx,7FFE77D680F4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edi,1
M03_L30:
       cmp       dword ptr [rbp-44],0
       je        short M03_L31
       mov       rcx,7FFE77D680F8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-58]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M03_L42
       mov       rcx,[rbp-58]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       mov       rbx,rcx
       test      rbx,rbx
       je        short M03_L33
       mov       rcx,rbx
       call      00007FFED6E6FFC0
       test      eax,eax
       jne       short M03_L34
M03_L31:
       mov       rcx,7FFE77D680FC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,esi
       or        ecx,edi
       jne       near ptr M03_L41
M03_L32:
       mov       rcx,7FFE77D68104
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
M03_L33:
       xor       ecx,ecx
       call      qword ptr [7FFE77B3F0C0]
       int       3
M03_L34:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFE77B3FA08]
       jmp       short M03_L31
M03_L35:
       call      M03_L43
       jmp       near ptr M03_L02
M03_L36:
       mov       rcx,7FFE77D68108
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
M03_L37:
       call      M03_L43
       jmp       short M03_L36
M03_L38:
       mov       rcx,rax
       mov       rdx,7FFE77D15C08
       call      qword ptr [7FFE7729C570]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M03_L00
M03_L39:
       mov       rdx,[rbp+20]
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L01
M03_L40:
       mov       rcx,7FFE77D680C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       jmp       near ptr M03_L01
M03_L41:
       mov       rcx,7FFE77D68100
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FFE779AFAC8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
       jmp       near ptr M03_L32
M03_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L43:
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M03_L44
       mov       rcx,7FFE77D680F8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-58]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       short M03_L46
       mov       rcx,[rbp-58]
       mov       eax,[rbp-40]
       mov       rsi,[rcx+rax*8+10]
       test      rsi,rsi
       je        short M03_L45
       mov       rcx,rsi
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M03_L44
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE77B3FA08]
M03_L44:
       mov       rcx,7FFE77D680FC
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
M03_L45:
       xor       ecx,ecx
       call      qword ptr [7FFE77B3F0C0]
       int       3
M03_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1517
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
       mov       rcx,2B83D76F9D8
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],1
       jne       short M04_L03
       cmp       word ptr [r8+0C],0A
       je        short M04_L04
M04_L03:
       mov       rcx,2B83D761518
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],2
       jne       short M04_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M04_L08
M04_L04:
       mov       rcx,2B83D761518
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
       mov       rdx,7FFE77799C30
       call      qword ptr [7FFE775176F0]
       mov       rcx,rax
       call      qword ptr [7FFE77C9DC08]
       int       3
M04_L09:
       or        esi,4
       jmp       short M04_L06
M04_L10:
       cmp       edx,9
       je        short M04_L11
       mov       ecx,38A0
       mov       rdx,7FFE77799C30
       call      qword ptr [7FFE775176F0]
       mov       rcx,rax
       call      qword ptr [7FFE77C9DBC0]
       int       3
M04_L11:
       or        esi,8
       jmp       near ptr M04_L00
M04_L12:
       mov       ecx,38A0
       mov       rdx,7FFE77799C30
       call      qword ptr [7FFE775176F0]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FFE77C9DBD8]
       int       3
M04_L13:
       mov       ecx,38A0
       mov       rdx,7FFE77799C30
       call      qword ptr [7FFE775176F0]
       mov       rcx,rax
       call      qword ptr [7FFE77C9DBF0]
       int       3
M04_L14:
       mov       r8,2B83D761518
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
       mov       rcx,277A8800C90
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0B
       jle       short M05_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+58]
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
       mov       ecx,0B
       call      qword ptr [7FFE777A4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L03:
       mov       rcx,r14
       call      qword ptr [7FFE777AC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFE777AC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFE77C9C0A8]
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
       call      qword ptr [7FFE77A7EAF0]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FFE7788D2D8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFE77296820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFE777AC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFE777AC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFE77C9C0A8]
       jmp       near ptr M05_L01
M05_L12:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M05_L15
M05_L13:
       test      ebx,ebx
       jne       short M05_L14
       mov       rax,2B83D7662A0
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
       mov       rdx,2B83D766F28
       call      qword ptr [7FFE7751D788]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFE779A73F0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M05_L17:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFE777AC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFE777AC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFE77C9C0A8]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFE777AC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE77C9C0C0]
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
       mov       rcx,277A8801DD0
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       ebp,edx
       mov       rcx,277A8800C90
       mov       r14,[rcx]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0B
       jle       short M06_L04
       mov       rcx,[rcx+240]
       mov       rax,[rcx+58]
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
       mov       ecx,0B
       call      qword ptr [7FFE777A4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M06_L00
M06_L05:
       mov       rcx,r13
       call      qword ptr [7FFE777AC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       ebp,[r13+8]
       mov       rcx,rsi
       call      qword ptr [7FFE777AC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,edi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFE77C9C0A8]
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
       call      qword ptr [7FFE77A7EAF0]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FFE7788D2D8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFE77296820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFE777AC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFE777AC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],r15d
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFE77C9C0A8]
       jmp       near ptr M06_L01
M06_L14:
       mov       ecx,10
       shlx      ebp,ecx,r15d
       jmp       short M06_L17
M06_L15:
       test      ebp,ebp
       jne       short M06_L16
       mov       rdx,2B83D7662A0
       jmp       near ptr M06_L02
M06_L16:
       mov       ecx,ebp
       mov       rdx,2B83D766F28
       call      qword ptr [7FFE7751D788]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFE779A73F0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M06_L19:
       cmp       byte ptr [r14+9D],0
       je        near ptr M06_L01
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFE777AC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFE777AC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,esi
       mov       r8d,ebp
       mov       rcx,r14
       call      qword ptr [7FFE77C9C0A8]
       mov       ebp,[r13+8]
       mov       rcx,rdi
       call      qword ptr [7FFE777AC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE77C9C0C0]
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
       call      qword ptr [7FFE7743DEA8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFE77C97F78]
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
       mov       rcx,277A8801DD0
       mov       rcx,[rcx]
       call      qword ptr [7FFE779CE0C0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFE7743DEA8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       mov       rcx,277A8801DD0
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
       jmp       qword ptr [7FFE779CE0C8]; Precode of System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       call      qword ptr [7FFE77295C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       call      qword ptr [7FFE7729C960]; System.Object.GetType()
       mov       r9,2B83D7619B8
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
       call      qword ptr [7FFE779A7420]
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
       call      qword ptr [7FFE777AC498]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbx,rax
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L01
M08_L06:
       mov       rcx,rbx
       call      qword ptr [7FFE779AD9F8]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
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
       call      qword ptr [7FFE779AE970]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M08_L09:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE779AF2A0]; System.Text.Json.Utf8JsonWriter.Flush()
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
       call      qword ptr [7FFE774370D8]
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
       mov       r8,277A88013A8
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
       call      qword ptr [7FFE77434B88]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
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
       call      00007FFED6EDF840
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
       call      qword ptr [7FFE77434BB8]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
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
       call      qword ptr [7FFE7790D878]
       int       3
M10_L04:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FFE7790DE30]
       add       r14d,eax
       jns       near ptr M10_L00
       call      qword ptr [7FFE7790DE48]
       int       3
M10_L05:
       mov       r15,2B83D760008
       jmp       short M10_L02
M10_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FFE7790D878]
       int       3
M10_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FFE77905608]
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
       call      qword ptr [7FFE7790D890]
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
       call      qword ptr [7FFE7790DE60]
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
       call      qword ptr [7FFFAFFA5DB0]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
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
       call      qword ptr [7FFFAFFA5DB0]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
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
       mov       rcx,7FFE77D77168
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
       mov       rdx,7FFE77D77060
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
       mov       rcx,7FFE77D7716C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFE77D77168
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rbx,[rbx+20]
       mov       rcx,rbx
       mov       rdx,7FFE77D77170
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
       mov       rcx,7FFE77D77278
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L00
M12_L03:
       mov       rcx,7FFE77D7727C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L00
M12_L04:
       mov       rcx,7FFE77D77280
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
       mov       rax,277A88013D0
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
       call      qword ptr [7FFE77C9D6F8]
       mov       rcx,[rbp+30]
M13_L04:
       test      byte ptr [rbx+7C],1
       jne       short M13_L05
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FFE779AED78]; System.Text.Json.Utf8JsonWriter.WriteStringMinimized(System.ReadOnlySpan`1<Char>)
       jmp       short M13_L07
M13_L05:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FFE77C9D710]
       jmp       short M13_L07
M13_L06:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FFE77ADECB8]; System.Text.Json.Utf8JsonWriter.WriteStringEscapeValue(System.ReadOnlySpan`1<Char>, Int32)
M13_L07:
       or        dword ptr [rbx+28],80000000
       mov       byte ptr [rbx+3A],7
       jmp       short M13_L09
M13_L08:
       mov       rcx,rbx
       call      qword ptr [7FFE779AEF88]
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
       call      qword ptr [7FFE779AE9A0]; System.Text.Json.WriteStack.Push()
       mov       r8,[rdi]
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SmallObjectWithParameterizedConstructorConverter<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, System.String, System.Object, System.Object, System.Object>
       cmp       [rsi],rcx
       jne       short M13_L20
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FFE778BA880]; System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[[System.__Canon, System.Private.CoreLib]].OnTryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       mov       r15d,eax
M13_L18:
       mov       rcx,[rbp+30]
       mov       edx,r15d
       call      qword ptr [7FFE779AEDD8]; System.Text.Json.WriteStack.Pop(Boolean)
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
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       mov       r15d,eax
       jmp       short M13_L18
M13_L21:
       mov       ecx,[r14+88]
       call      qword ptr [7FFE779AEF58]
       int       3
M13_L22:
       mov       rcx,rbx
       call      qword ptr [7FFE779AEF88]
       jmp       near ptr M13_L10
M13_L23:
       cmp       byte ptr [rsi+1A],0
       je        near ptr M13_L01
       mov       rdi,[rdi]
       add       rcx,90
       call      qword ptr [7FFE779056E0]; System.Nullable`1[[System.Text.Json.Serialization.JsonNumberHandling, System.Text.Json]].get_Value()
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
       call      qword ptr [7FFE77C9D6C8]
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
       call      qword ptr [7FFE779AEEF8]
       int       3
M13_L27:
       mov       rcx,r13
       call      qword ptr [7FFE77886208]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M13_L13
M13_L28:
       mov       [rsp+20],rcx
       mov       rdx,[rdi]
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FFE77C9D620]
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
       call      qword ptr [7FFE77C9D638]
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
       call      qword ptr [7FFE77C9DCC8]
M13_L34:
       mov       rdx,rbx
       mov       rcx,offset MT_System.InvalidOperationException
       call      qword ptr [7FFE77296850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M13_L36
       mov       rdx,rbx
       mov       rcx,offset MT_System.Text.Json.JsonException
       call      qword ptr [7FFE77296850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M13_L35
       mov       rcx,rsi
       call      qword ptr [7FFE77C9DCE0]
       test      rax,rax
       jne       near ptr M13_L38
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FFE77C9DCF8]
       jmp       near ptr M13_L38
M13_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.NotSupportedException
       call      qword ptr [7FFE77296850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M13_L38
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,2B83D76E9D0
       cmp       [rcx],ecx
       call      qword ptr [7FFE77C9DD28]
       test      eax,eax
       jne       short M13_L38
       jmp       short M13_L37
M13_L36:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       rdx,2B83D76E980
       call      qword ptr [7FFE77514E40]; System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M13_L38
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFE77C9DD10]
       jmp       short M13_L38
M13_L37:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFE77C9DD40]
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
       call      qword ptr [7FFE77C9E178]
       int       3
M14_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M14_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE77D76478]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFE77C9E1A8]
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
       call      qword ptr [7FFE77C9E1C0]
M14_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M14_L02
M14_L06:
       mov       r11,7FFE771E10D0
       call      qword ptr [r11]
       jmp       near ptr M14_L01
; Total bytes of code 232
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
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+28],r9d
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       xor       r14d,r14d
       cmp       byte ptr [rsi+9E],0
       je        near ptr M15_L20
       mov       r14,[rsi+8]
       test      r14,r14
       je        near ptr M15_L10
M15_L00:
       mov       r15,[r14+8]
       mov       rcx,277A8801938
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M15_L11
M15_L01:
       cmp       [r15],r15b
       test      rbx,rbx
       je        near ptr M15_L12
       mov       r12,[r15+8]
       mov       rcx,[r12+8]
       cmp       byte ptr [r15+19],0
       jne       near ptr M15_L08
       mov       rdx,rbx
       mov       r11,7FFE771E0D20
       call      qword ptr [r11]
M15_L02:
       lea       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,r12
       mov       r8,rbx
       mov       [rbp-44],eax
       mov       r9d,eax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      qword ptr [7FFE776F6118]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M15_L13
M15_L03:
       mov       r8,[rbp-40]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       cmp       byte ptr [rbp+38],0
       jne       near ptr M15_L14
M15_L04:
       mov       rcx,[r8+10]
       test      rcx,rcx
       jne       near ptr M15_L15
       mov       r14,[r8+8]
M15_L05:
       test      dil,dil
       je        short M15_L06
       test      r14,r14
       je        near ptr M15_L17
       mov       rcx,7FFE77D20EC0
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       byte ptr [r14+119],2
       jne       short M15_L09
M15_L06:
       test      r14,r14
       je        near ptr M15_L21
M15_L07:
       mov       rcx,7FFE77D20ED8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,r14
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
M15_L08:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M15_L02
M15_L09:
       mov       rcx,r14
       call      qword ptr [7FFE77886208]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       short M15_L06
M15_L10:
       mov       rcx,rsi
       call      qword ptr [7FFE777AC4B0]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       r14,rax
       jmp       near ptr M15_L00
M15_L11:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FFE771DD050
       call      qword ptr [7FFE77296E68]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,277A8801938
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M15_L01
M15_L12:
       mov       ecx,1
       mov       rdx,7FFE7763FC38
       call      qword ptr [7FFE775176F0]
       mov       rcx,rax
       call      qword ptr [7FFE77885F80]
       int       3
M15_L13:
       mov       rdx,rbx
       mov       r8,r14
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-40]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,[rbp-44]
       shl       r9,20
       or        r9,1
       mov       rdx,r12
       mov       r8,rbx
       mov       rcx,r15
       call      qword ptr [7FFE776F7FC0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M15_L03
M15_L14:
       cmp       byte ptr [r8+20],0
       je        short M15_L16
       jmp       near ptr M15_L04
M15_L15:
       call      qword ptr [7FFE77C96910]
       int       3
M15_L16:
       mov       rcx,r14
       mov       rdx,rbx
       call      qword ptr [7FFE77C96E80]
       mov       r14,rax
       jmp       near ptr M15_L05
M15_L17:
       mov       rcx,7FFE77D20EC4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M15_L06
M15_L18:
       mov       rcx,7FFE77D20EC8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M15_L06
M15_L19:
       mov       rcx,7FFE77D20ECC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M15_L07
M15_L20:
       cmp       byte ptr [rbp+30],0
       je        short M15_L18
       mov       rcx,7FFE77D20ED0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE777ACA50]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       r14,rax
       jmp       near ptr M15_L06
M15_L21:
       cmp       byte ptr [rbp+29],0
       je        short M15_L19
       mov       rcx,7FFE77D20ED4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rsi+20]
       mov       rcx,rbx
       call      qword ptr [7FFE77C96928]
       int       3
; Total bytes of code 711
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
       jmp       qword ptr [7FFE77B3FCD8]
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
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M17_L37
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
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
       mov       rcx,2B83D7662A0
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M17_L36
       cmp       dword ptr [rbx+8],0
       je        near ptr M17_L36
       mov       rcx,277A8801DD0
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
       cmp       dword ptr [rcx+238],0B
       jle       near ptr M17_L38
       mov       rcx,[rcx+240]
       mov       r15,[rcx+58]
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
       je        near ptr M17_L08
       mov       rcx,[rbp-80]
       call      00007FFED6E20370
       test      eax,eax
       jne       short M17_L02
       mov       rcx,[rbp-80]
       call      qword ptr [7FFE77B3FE40]
M17_L02:
       mov       dword ptr [rbp-40],1
       mov       rcx,[r15+10]
       lea       r8,[rbp-48]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFE7751CE88]; System.Runtime.CompilerServices.ConditionalWeakTable`2+Container[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindEntry(System.__Canon, System.Object ByRef)
       cmp       eax,0FFFFFFFF
       jne       near ptr M17_L09
       mov       r12,[r15+10]
       mov       ecx,[r12+28]
       mov       rax,[r12+18]
       cmp       ecx,[rax+8]
       jge       near ptr M17_L06
M17_L03:
       cmp       byte ptr [r12+2C],0
       jne       near ptr M17_L10
       mov       byte ptr [r12+2C],1
       mov       rcx,r13
       call      00007FFED6E834A0
       test      eax,eax
       je        near ptr M17_L07
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
       call      00007FFED6EC3BA0
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
       mov       rcx,r12
       call      qword ptr [7FFE77C9EFB8]
       mov       r12,rax
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M17_L03
M17_L07:
       mov       rcx,r13
       call      qword ptr [7FFE7729E8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M17_L04
M17_L08:
       xor       ecx,ecx
       call      qword ptr [7FFE77B3F0C0]
       int       3
M17_L09:
       mov       ecx,36
       call      qword ptr [7FFE77C9C450]
       int       3
M17_L10:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77C9EFD0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE776F5A88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M17_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M17_L12:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFE77C9EFE8]
       jmp       near ptr M17_L05
M17_L13:
       mov       rcx,[rbp-80]
       call      00007FFED6E6FFC0
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
       call      qword ptr [7FFE77C9DBA8]
M17_L17:
       mov       r13,[rax+8]
       call      qword ptr [7FFE77A7EAF0]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      00007FFED6E20370
       test      eax,eax
       jne       short M17_L19
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE77B3FE40]
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
       call      00007FFED6E6FFC0
       test      eax,eax
       jne       near ptr M17_L42
M17_L22:
       cmp       dword ptr [rbp-60],0
       je        near ptr M17_L43
       mov       r13d,1
M17_L23:
       mov       rcx,277A8800C90
       mov       r12,[rcx]
       cmp       byte ptr [r12+9D],0
       je        near ptr M17_L36
       mov       rcx,rbx
       call      00007FFED6E834A0
       test      eax,eax
       je        near ptr M17_L31
       mov       [rbp-68],eax
M17_L24:
       mov       edx,[rbx+8]
       mov       [rbp-3C],edx
       mov       rcx,rsi
       call      00007FFED6E834A0
       test      eax,eax
       je        near ptr M17_L32
M17_L25:
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rbp-68]
       mov       r9d,[rbp-3C]
       mov       edx,3
       call      qword ptr [7FFE77C9C150]
       test      r13d,r15d
       jne       near ptr M17_L36
       mov       rcx,rbx
       call      qword ptr [7FFE777AC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       ebx,[rbx+8]
       mov       rcx,rsi
       call      00007FFED6E834A0
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
       mov       r15,277A8801F20
       mov       r12,[r15]
       test      r12,r12
       jne       short M17_L28
       mov       rcx,offset MT_System.Func<System.Object, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,277A8801F18
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
       call      00007FFED6E9FFF0
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
       call      qword ptr [7FFE7729E8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       [rbp-68],eax
       jmp       near ptr M17_L24
M17_L32:
       mov       rcx,rsi
       call      qword ptr [7FFE7729E8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M17_L25
M17_L33:
       mov       rcx,rsi
       call      qword ptr [7FFE7729E8F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       call      qword ptr [7FFE77C9C168]
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
       mov       ecx,0A
       call      qword ptr [7FFE777A4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M17_L00
M17_L38:
       mov       ecx,0B
       call      qword ptr [7FFE777A4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M17_L01
M17_L39:
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE77B3FA08]
       jmp       near ptr M17_L14
M17_L40:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFE77C9F000]
       jmp       near ptr M17_L29
M17_L41:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE77C9C138]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFE771D4000
       call      qword ptr [7FFE775176F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE776F5B30]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M17_L42:
       mov       ecx,eax
       mov       rdx,[rbp-90]
       call      qword ptr [7FFE77B3FA08]
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
       call      qword ptr [7FFE77B3F0C0]
       int       3
M17_L47:
       mov       rcx,[rbp-80]
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M17_L48
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FFE77B3FA08]
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
       call      00007FFED6EDF840
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE77295818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2B83D760008
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
       call      qword ptr [7FFE77C94630]
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
       call      qword ptr [7FFFAFF9F478]
       cmp       byte ptr [rax],0
       je        near ptr M20_L04
       call      qword ptr [7FFFAFFA5968]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M20_L00
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFFAFF9F230]; CORINFO_HELP_ASSIGN_REF
       jmp       short M20_L01
M20_L00:
       call      qword ptr [7FFFAFFA1550]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M20_L02
M20_L01:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M20_L02:
       call      qword ptr [7FFFAFF9F470]
       cmp       byte ptr [rax],0
       je        short M20_L01
       xorps     xmm0,xmm0
       movups    [rsp+30],xmm0
       mov       [rsp+30],rdi
       mov       [rsp+38],rsi
       lea       rcx,[rsp+20]
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       lea       r8,[rsp+30]
       mov       r9d,2
       call      qword ptr [7FFFAFFA6E98]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFFAFFA5998]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FFFAFF9F230]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M20_L01
       cmp       [rsi+10],rbx
       je        short M20_L03
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+9F],0
       jne       short M20_L03
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFFAFFA5250]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M20_L01
M20_L03:
       mov       rcx,[rsi+8]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M20_L01
M20_L04:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M20_L05
       call      qword ptr [7FFFAFFA1568]
       test      rax,rax
       je        near ptr M20_L01
M20_L05:
       call      qword ptr [7FFFAFFA3BD0]
       int       3
; Total bytes of code 286
```
```assembly
; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFFAFFA52F8]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFFAFFA32C0]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       call      00007FFED6E20370
       test      eax,eax
       jne       short M22_L01
       mov       rcx,rsi
       call      qword ptr [7FFE77B3FE40]
M22_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M22_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M22_L03
       mov       rcx,7FFE77D290B0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FFE77886220]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M22_L04
M22_L02:
       xor       ecx,ecx
       call      qword ptr [7FFE77B3F0C0]
       int       3
M22_L03:
       mov       rcx,7FFE77D290AC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE77C96910]
       int       3
M22_L04:
       mov       rcx,7FFE77D290B4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FFED6E6FFC0
       test      eax,eax
       jne       near ptr M22_L10
M22_L05:
       mov       rcx,7FFE77D290B8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFE77D290BC
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M22_L06:
       call      qword ptr [7FFE77C97438]
       int       3
M22_L07:
       mov       rcx,7FFE77D290A8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE77C96910]
       int       3
M22_L08:
       mov       rcx,rbx
       call      qword ptr [7FFE777AC4E0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M22_L09
       call      qword ptr [7FFE77B3F600]
       int       3
M22_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFED6E8EEF0
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M22_L00
M22_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE77B3FA08]
       jmp       near ptr M22_L05
       sub       rsp,28
       call      qword ptr [7FFE77C97450]
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
       mov       rcx,7FFE77D290B4
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M22_L11
       xor       ecx,ecx
       call      qword ptr [7FFE77B3F0C0]
       int       3
M22_L11:
       mov       rcx,[rbp-20]
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M22_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFE77B3FA08]
M22_L12:
       mov       rcx,7FFE77D290B8
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
       call      qword ptr [7FFED6D07E38]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFE77295C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       mov       rcx,20A9BC01DC8
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
       mov       rcx,20A9BC01938
       mov       r15,[rcx]
       test      r15,r15
       jne       short M00_L03
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE771FD050
       mov       [r15+18],rcx
       mov       rcx,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       [r15+20],rcx
       mov       rcx,20A9BC01938
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M00_L03:
       cmp       [rdi],dil
       mov       r13,[rdi+8]
       mov       rcx,[r13+8]
       cmp       byte ptr [rdi+19],0
       jne       near ptr M00_L07
       mov       r11,7FFE77201010
       mov       rdx,24B30A119B8
       call      qword ptr [r11]
       mov       r12d,eax
M00_L04:
       lea       r9,[rbp-48]
       mov       [rsp+20],r9
       mov       r9d,r12d
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       mov       r8,24B30A119B8
       call      qword ptr [7FFE77716118]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       jne       short M00_L05
       mov       r8,rsi
       mov       rdx,24B30A119B8
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
       mov       r8,24B30A119B8
       call      qword ptr [7FFE77717FC0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
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
       mov       rcx,24B30A119B8
       call      qword ptr [7FFE77CC6A48]
       int       3
M00_L07:
       mov       rcx,24B30A119B8
       mov       rax,[7FFE771FA1C0]
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
       call      qword ptr [7FFE779B72E8]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       r15d,[rsi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M00_L42
       mov       rcx,[rcx+240]
       mov       rsi,[rcx+50]
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
       mov       rcx,24B30A162A0
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
       mov       rcx,20A9BC01DD0
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FFE779EE178]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       r15,24B30A11518
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
       mov       rsi,24B30A11518
M00_L21:
       mov       ecx,[rsi+8]
       mov       [r13+30],ecx
       cmp       dword ptr [r13+78],0
       jne       near ptr M00_L16
       mov       dword ptr [r13+78],3E8
       jmp       near ptr M00_L16
M00_L22:
       mov       edx,r15d
       call      qword ptr [7FFE779B7378]; System.Net.ArrayBuffer.EnsureAvailableSpaceCore(Int32)
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
       call      qword ptr [7FFE772BC978]; System.Object.GetType()
       mov       r9,24B30A119B8
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
       call      qword ptr [7FFE779B7450]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
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
       call      qword ptr [7FFE779BF2E8]; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[], Int32, Int32)
       mov       rcx,[rbp-128]
       mov       eax,[rbp-120]
       mov       [rbp-140],rcx
       mov       [rbp-138],eax
       lea       rcx,[rbp-140]
       call      qword ptr [7FFE779257E8]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       rsi,rax
       jmp       near ptr M00_L35
M00_L29:
       mov       rcx,r14
       call      qword ptr [7FFE779BDA28]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
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
       call      qword ptr [7FFE779BE988]; System.Text.Json.WriteStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, System.Object, Boolean, Boolean)
       lea       rcx,[rbp-110]
       mov       [rsp+20],rcx
       mov       rcx,[r14+158]
       mov       r9,[r14+0B8]
       lea       r8,[rbp-40]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFE779BE9A0]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M00_L31:
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFE779BF2D0]; System.Text.Json.Utf8JsonWriter.Flush()
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
       call      qword ptr [7FFE777CC498]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FFE779BF300]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
       mov       [rbp-130],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rbp-130]
       mov       rdx,7FFE77BBB570
       cmp       [rcx],ecx
       call      qword ptr [7FFE77B569E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE7792DF20]
       mov       ecx,1C77
       mov       rdx,7FFE77655418
       call      qword ptr [7FFE775376F0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFE77655418
       call      qword ptr [7FFE775376F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE772B7828]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFE77655418
       call      qword ptr [7FFE775376F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE772B7828]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE77CCEE50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE77B5FDB0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L37:
       mov       rcx,r14
       call      qword ptr [7FFE777C6C70]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L01
M00_L38:
       mov       rcx,r14
       call      qword ptr [7FFE777CC4B0]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L39:
       mov       rcx,rax
       call      qword ptr [7FFE77CC6A30]
       int       3
M00_L40:
       mov       rcx,rsi
       call      qword ptr [7FFE778A6208]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M00_L06
M00_L41:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L42:
       mov       ecx,0A
       call      qword ptr [7FFE777C4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rsi,rax
       jmp       near ptr M00_L11
M00_L43:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20AB1C007A8
       mov       rsi,[rcx]
       jmp       near ptr M00_L21
M00_L44:
       mov       rax,24B30A162A0
       jmp       near ptr M00_L13
M00_L45:
       mov       rcx,offset MT_System.Text.Json.JsonWriterOptions
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,20AB1C007A8
       mov       r15,[rcx]
       jmp       near ptr M00_L15
       sub       rsp,48
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-148]
       call      qword ptr [7FFE779BF300]; System.Text.Json.Utf8JsonWriterCache.ReturnWriterAndBuffer(System.Text.Json.Utf8JsonWriter, System.Text.Json.PooledByteBufferWriter)
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
       call      qword ptr [7FFE777CCA50]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       setne     cl
       mov       [rdi+20],cl
       mov       [rbp-20],rdi
M01_L00:
       mov       rcx,7FFE77D8579C
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
       mov       rcx,7FFE77D85798
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77CC7570]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE77CCCC18]
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
       je        near ptr M02_L04
M02_L00:
       cmp       esi,[r14+20]
       jne       near ptr M02_L03
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+80]
       test      r15,r15
       je        short M02_L02
M02_L01:
       mov       rcx,rbp
       mov       rdx,7FFE77D44830
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rbp
       mov       rdx,[r14+8]
       mov       r11,r15
       mov       r8,rdi
       call      qword ptr [r15]
       test      eax,eax
       je        near ptr M02_L05
       mov       rcx,7FFE77D44938
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
       mov       rdx,7FFE77D29180
       call      qword ptr [7FFE772BC588]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
       jmp       short M02_L01
M02_L03:
       mov       rcx,7FFE77D44940
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r14,[r14+18]
       test      r14,r14
       jne       near ptr M02_L00
M02_L04:
       mov       rcx,7FFE77D44944
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
M02_L05:
       mov       rcx,7FFE77D4493C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M02_L03
M02_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 323
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
       mov       rax,[rbp+18]
       mov       rax,[rax+8]
       mov       [rbp-50],rax
       mov       ebx,[rbp+2C]
       test      r9d,r9d
       jne       near ptr M03_L40
       cmp       byte ptr [rcx+19],0
       jne       near ptr M03_L39
       mov       rax,[rcx]
       mov       r8,[rax+30]
       mov       r8,[r8]
       mov       r11,[r8+78]
       test      r11,r11
       je        near ptr M03_L38
M03_L00:
       mov       rcx,[rbp-50]
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
M03_L01:
       mov       [rbp-3C],eax
M03_L02:
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
       jae       near ptr M03_L42
       mov       ecx,r9d
       lea       rbx,[r10+rcx*8+10]
       xor       esi,esi
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       byte ptr [rbp+40],0
       je        short M03_L04
       mov       rcx,7FFE77D8B894
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-58]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M03_L25
       mov       rcx,[rbp-58]
       mov       eax,[rbp-40]
       mov       r14,[rcx+rax*8+10]
       test      r14,r14
       je        near ptr M03_L17
       mov       rcx,r14
       call      00007FFED6E20370
       test      eax,eax
       jne       short M03_L03
       mov       rcx,r14
       call      qword ptr [7FFE77B5FF60]
M03_L03:
       mov       dword ptr [rbp-44],1
M03_L04:
       mov       rcx,[rbp+18]
       mov       r8,[rbp+10]
       cmp       rcx,[r8+8]
       jne       near ptr M03_L18
       xor       r14d,r14d
       mov       r15,[rbx]
       test      r15,r15
       jne       near ptr M03_L08
M03_L05:
       mov       rcx,[r8]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+90]
       test      rdx,rdx
       je        near ptr M03_L16
M03_L06:
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
       jg        near ptr M03_L28
M03_L07:
       cmp       r14d,64
       ja        near ptr M03_L29
       mov       rcx,7FFE77D8B8AC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L30
M03_L08:
       mov       ecx,[rbp-3C]
       cmp       ecx,[r15+20]
       jne       short M03_L11
       mov       rcx,[r8]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+88]
       test      rax,rax
       je        short M03_L12
       mov       rcx,rax
M03_L09:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+80]
       test      r11,r11
       je        short M03_L13
M03_L10:
       mov       rdx,[r15+8]
       mov       rcx,[rbp-50]
       mov       r8,[rbp+20]
       call      qword ptr [r11]
       test      eax,eax
       jne       short M03_L14
       mov       rcx,7FFE77D8B8A0
       call      CORINFO_HELP_COUNTPROFILE32
M03_L11:
       mov       rcx,7FFE77D8B8B0
       call      CORINFO_HELP_COUNTPROFILE32
       inc       r14d
       mov       rcx,7FFE77D8B8B4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r15,[r15+18]
       test      r15,r15
       mov       r8,[rbp+10]
       jne       near ptr M03_L08
       jmp       near ptr M03_L05
M03_L12:
       mov       rdx,7FFE77D29958
       call      qword ptr [7FFE772BC588]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M03_L09
M03_L13:
       mov       rdx,7FFE77D29180
       call      qword ptr [7FFE772BC588]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M03_L10
M03_L14:
       cmp       byte ptr [rbp+38],0
       je        near ptr M03_L27
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L15:
       xor       ecx,ecx
       mov       [rbp-48],ecx
       jmp       near ptr M03_L37
M03_L16:
       mov       rdx,7FFE77D6DBC8
       call      qword ptr [7FFE772BC588]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M03_L06
M03_L17:
       xor       ecx,ecx
       call      qword ptr [7FFE77B5F1F8]
       int       3
M03_L18:
       mov       rcx,[r8+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp-50]
       mov       rax,[rbp+18]
       cmp       rcx,[rax+8]
       je        short M03_L23
       mov       rcx,7FFE77D8B898
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       mov       [rbp-50],rcx
       mov       r8,[rbp+10]
       cmp       byte ptr [r8+19],0
       jne       short M03_L21
       mov       rcx,[r8]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+78]
       test      r11,r11
       je        short M03_L19
       jmp       short M03_L20
M03_L19:
       mov       rdx,7FFE77D29078
       call      qword ptr [7FFE772BC588]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
M03_L20:
       mov       rcx,[rbp-50]
       mov       rdx,[rbp+20]
       call      qword ptr [r11]
       jmp       short M03_L22
M03_L21:
       mov       rcx,[rbp+20]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
M03_L22:
       mov       [rbp-3C],eax
M03_L23:
       mov       rcx,7FFE77D8B89C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L35
M03_L24:
       mov       rcx,7FFE77D8B8A4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L30
M03_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L27:
       mov       rcx,7FFE77D8B8A8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[r15+10]
       mov       rcx,[rbp+48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M03_L15
M03_L28:
       mov       rcx,7FFE77D8B8B8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       esi,1
       jmp       near ptr M03_L07
M03_L29:
       mov       rdx,[rbp-50]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      qword ptr [7FFE772B6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L24
       mov       rcx,7FFE77D8B8BC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edi,1
M03_L30:
       cmp       dword ptr [rbp-44],0
       je        short M03_L31
       mov       rcx,7FFE77D8B8C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-58]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M03_L42
       mov       rcx,[rbp-58]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       mov       rbx,rcx
       test      rbx,rbx
       je        short M03_L33
       mov       rcx,rbx
       call      00007FFED6E6FFC0
       test      eax,eax
       jne       short M03_L34
M03_L31:
       mov       rcx,7FFE77D8B8C4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,esi
       or        ecx,edi
       jne       near ptr M03_L41
M03_L32:
       mov       rcx,7FFE77D8B8CC
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
M03_L33:
       xor       ecx,ecx
       call      qword ptr [7FFE77B5F1F8]
       int       3
M03_L34:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FFE77B5FB28]
       jmp       short M03_L31
M03_L35:
       call      M03_L43
       jmp       near ptr M03_L02
M03_L36:
       mov       rcx,7FFE77D8B8D0
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
M03_L37:
       call      M03_L43
       jmp       short M03_L36
M03_L38:
       mov       rcx,rax
       mov       rdx,7FFE77D29078
       call      qword ptr [7FFE772BC588]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M03_L00
M03_L39:
       mov       rdx,[rbp+20]
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L01
M03_L40:
       mov       rcx,7FFE77D8B890
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       jmp       near ptr M03_L01
M03_L41:
       mov       rcx,7FFE77D8B8C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FFE779BFAE0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GrowTable(Tables<System.__Canon,System.__Canon>, Boolean, Boolean)
       jmp       near ptr M03_L32
M03_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L43:
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M03_L44
       mov       rcx,7FFE77D8B8C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-58]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       short M03_L46
       mov       rcx,[rbp-58]
       mov       eax,[rbp-40]
       mov       rsi,[rcx+rax*8+10]
       test      rsi,rsi
       je        short M03_L45
       mov       rcx,rsi
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M03_L44
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE77B5FB28]
M03_L44:
       mov       rcx,7FFE77D8B8C4
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
M03_L45:
       xor       ecx,ecx
       call      qword ptr [7FFE77B5F1F8]
       int       3
M03_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1517
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
       mov       rcx,24B30A1F9D8
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],1
       jne       short M04_L03
       cmp       word ptr [r8+0C],0A
       je        short M04_L04
M04_L03:
       mov       rcx,24B30A11518
       cmp       r8,rcx
       je        short M04_L04
       cmp       dword ptr [r8+8],2
       jne       short M04_L08
       cmp       dword ptr [r8+0C],0A000D
       jne       short M04_L08
M04_L04:
       mov       rcx,24B30A11518
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
       mov       rdx,7FFE777B9C30
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE77CCE898]
       int       3
M04_L09:
       or        esi,4
       jmp       short M04_L06
M04_L10:
       cmp       edx,9
       je        short M04_L11
       mov       ecx,38A0
       mov       rdx,7FFE777B9C30
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE77CCE850]
       int       3
M04_L11:
       or        esi,8
       jmp       near ptr M04_L00
M04_L12:
       mov       ecx,38A0
       mov       rdx,7FFE777B9C30
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       xor       edx,edx
       mov       r8d,7F
       call      qword ptr [7FFE77CCE868]
       int       3
M04_L13:
       mov       ecx,38A0
       mov       rdx,7FFE777B9C30
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE77CCE880]
       int       3
M04_L14:
       mov       r8,24B30A11518
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
       mov       rcx,20A9BC00C90
       mov       rdi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0B
       jle       short M05_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+58]
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
       mov       ecx,0B
       call      qword ptr [7FFE777C4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M05_L00
M05_L03:
       mov       rcx,r14
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFE77CCC288]
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
       call      qword ptr [7FFE77A9EC40]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FFE778AD2D8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFE772B6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       [rsp+20],ebp
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFE77CCC288]
       jmp       near ptr M05_L01
M05_L12:
       mov       ecx,10
       shlx      ebx,ecx,ebp
       jmp       short M05_L15
M05_L13:
       test      ebx,ebx
       jne       short M05_L14
       mov       rax,24B30A162A0
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
       mov       rdx,24B30A16F28
       call      qword ptr [7FFE7753D788]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFE779B7420]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M05_L17:
       cmp       byte ptr [rdi+9D],0
       je        near ptr M05_L01
       cmp       [r14],r14b
       mov       rcx,r14
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,ebx
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FFE77CCC288]
       mov       r15d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE77CCC2A0]
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
       mov       rcx,20A9BC01DD0
       mov       rcx,[rcx]
       call      qword ptr [7FFE779EE178]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFE772B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,20A9BC01DD0
       mov       rsi,[rcx]
       lea       ecx,[rbx-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0B
       jle       near ptr M06_L21
       mov       rcx,[rcx+240]
       mov       rax,[rcx+58]
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
       mov       rcx,20A9BC00C90
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
       mov       rcx,20A9BC01DD0
       mov       rcx,[rcx]
       call      qword ptr [7FFE779EE178]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFE7745DEA8]; System.Buffer.BlockCopy(System.Array, Int32, System.Array, Int32, Int32)
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
       call      qword ptr [7FFE77CCC168]
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
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE77B5F1F8]
       int       3
M06_L13:
       mov       ecx,25F
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE77B5F1F8]
       int       3
M06_L14:
       mov       rcx,rdi
       call      00007FFED6E36B80
       mov       ecx,3003FFC
       bt        ecx,eax
       jb        short M06_L15
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77CC48B8]
       mov       rsi,rax
       mov       ecx,257
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE77715B30]
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
       call      00007FFED6E36B80
       mov       ecx,3003FFC
       bt        ecx,eax
       jb        short M06_L17
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE77CC48B8]
       mov       rbp,rax
       mov       ecx,25F
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,r14
       call      qword ptr [7FFE77715B30]
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
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE77B5F1C8]
       int       3
M06_L19:
       mov       ecx,28F
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       rdx,rax
       mov       ecx,ebp
       call      qword ptr [7FFE77B5F1C8]
       int       3
M06_L20:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFE77CC48D0]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE7753FC90]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M06_L21:
       mov       ecx,0B
       call      qword ptr [7FFE777C4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M06_L04
M06_L22:
       mov       rcx,rsi
       call      qword ptr [7FFE779BF348]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M06_L05
M06_L23:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE77CCC318]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE77715B30]
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
       call      qword ptr [7FFE77CCE4A8]
M06_L25:
       mov       r15,[rax+8]
       call      qword ptr [7FFE77A9EC40]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FFE778AD2D8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFE772B6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       [rsp+44],ebx
       mov       rcx,rsi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r13
       mov       r8d,r12d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FFE77CCC330]
       test      r15d,r14d
       jne       near ptr M06_L07
       mov       rcx,rdi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,rsi
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE77CCC348]
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
       call      qword ptr [7FFE772B5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       jmp       qword ptr [7FFE77B5FDF8]
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
       jne       near ptr M09_L09
       mov       rcx,[rbx+0C8]
       cmp       byte ptr [rcx+12],0
       je        near ptr M09_L06
       mov       r8,[rsi]
       test      r8,r8
       je        near ptr M09_L06
       mov       r14,[rbx+0B8]
       mov       rcx,r8
       cmp       [r14],r14b
       call      qword ptr [7FFE772BC978]; System.Object.GetType()
       mov       r9,24B30A119B8
       cmp       rax,r9
       je        near ptr M09_L06
       mov       rbx,[r14+10]
       test      rbx,rbx
       je        near ptr M09_L10
       mov       r9,[rbx+0C0]
       cmp       r9,rax
       jne       near ptr M09_L10
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
       jne       near ptr M09_L11
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
       call      qword ptr [7FFE779B7450]
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
       call      qword ptr [7FFE779BDA28]; System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.FindNearestPolymorphicBaseType(System.Text.Json.Serialization.Metadata.JsonTypeInfo)
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
       je        short M09_L07
       mov       rcx,[r14+38]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rsp+60],rax
       cmp       dword ptr [r14+8C],2
       jne       short M09_L07
       test      rbp,rbp
       jne       near ptr M09_L12
M09_L07:
       lea       rcx,[rsp+40]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+158]
       mov       r9,[rbx+0B8]
       mov       rdx,rdi
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE779BE9A0]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].WriteCore(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
M09_L08:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE779BF2D0]; System.Text.Json.Utf8JsonWriter.Flush()
       jmp       near ptr M09_L04
M09_L09:
       mov       rax,[rbx+148]
       mov       r8,[rsi]
       mov       rdx,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M09_L08
M09_L10:
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9d,101
       mov       rcx,r14
       mov       rdx,rax
       mov       r8d,1
       call      qword ptr [7FFE777CC498]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbx,rax
       lea       rcx,[r14+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M09_L01
M09_L11:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rbp
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M09_L04
M09_L12:
       mov       rcx,[rbx+0C0]
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        near ptr M09_L07
       mov       rcx,[rsp+60]
       mov       rdx,rbp
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       near ptr M09_L07
; Total bytes of code 708
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
       call      qword ptr [7FFE774570D8]
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
       mov       r8,20A9BC013A8
       mov       rbx,[r8]
       mov       rsi,[rcx]
       mov       edi,[rcx+8]
       mov       r8d,1
       test      edi,edi
       cmove     rsi,r8
       mov       [rbp-38],rsi
       test      rsi,rsi
       je        near ptr M11_L03
       lea       r8,[rbp-48]
       lea       r9,[rbp-50]
       mov       rcx,rsi
       mov       edx,edi
       call      qword ptr [7FFE77454BA0]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       mov       r9d,eax
       sub       r9d,esi
       mov       r14d,r9d
       add       r14d,[rbp-48]
       cmp       r9d,edi
       jne       near ptr M11_L04
M11_L00:
       test      r14d,r14d
       je        near ptr M11_L05
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String
       call      00007FFED6EDF840
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
       call      qword ptr [7FFE77454BD0]; System.Text.Unicode.Utf8Utility.TranscodeToUtf16(Byte*, Int32, Char*, Int32, Byte* ByRef, Char* ByRef)
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
M11_L02:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-38],rax
       jmp       near ptr M11_L09
M11_L03:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FFE7792D830]
       int       3
M11_L04:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,edi
       call      qword ptr [7FFE7792DE30]
       add       r14d,eax
       jns       near ptr M11_L00
       call      qword ptr [7FFE7792DE48]
       int       3
M11_L05:
       mov       r15,24B30A10008
       jmp       short M11_L02
M11_L06:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FFE7792D830]
       int       3
M11_L07:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FFE77925608]
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
       call      qword ptr [7FFE7792D848]
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
       call      qword ptr [7FFE7792DE60]
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
       call      qword ptr [7FFFAFFA5DB0]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
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
       call      qword ptr [7FFFAFFA5DB0]; Precode of System.Text.Json.Serialization.Metadata.PolymorphicTypeResolver.<FindNearestPolymorphicBaseType>g__ResolveAncestorTypeInfo|27_0(System.Type, System.Text.Json.JsonSerializerOptions)
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
       mov       rcx,7FFE77DCE770
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
       mov       rdx,7FFE77DCE668
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
       mov       rcx,7FFE77DCE774
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFE77DCE770
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rbx,[rbx+20]
       mov       rcx,rbx
       mov       rdx,7FFE77DCE778
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
       mov       rcx,7FFE77DCE880
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M13_L00
M13_L03:
       mov       rcx,7FFE77DCE884
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M13_L00
M13_L04:
       mov       rcx,7FFE77DCE888
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
       mov       rax,20A9BC013D0
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
       call      qword ptr [7FFE779BEDA8]; System.Text.Json.Utf8JsonWriter.WriteStringMinimized(System.ReadOnlySpan`1<Char>)
       jmp       short M14_L06
M14_L05:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FFE779BFBA0]; System.Text.Json.Utf8JsonWriter.WriteStringEscapeValue(System.ReadOnlySpan`1<Char>, Int32)
M14_L06:
       or        dword ptr [rbx+28],80000000
       mov       byte ptr [rbx+3A],7
       jmp       short M14_L08
M14_L07:
       mov       rcx,rbx
       call      qword ptr [7FFE779BEFB8]
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
       call      qword ptr [7FFE779BE9D0]; System.Text.Json.WriteStack.Push()
       mov       r8,[rdi]
       mov       rcx,offset MT_System.Text.Json.Serialization.Converters.SmallObjectWithParameterizedConstructorConverter<DotNetTips.Spargine.Tester.Models.RefTypes.Address, System.String, System.Object, System.Object, System.Object>
       cmp       [rsi],rcx
       jne       short M14_L19
       mov       rcx,[rbp+30]
       mov       [rsp+20],rcx
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r9,r14
       call      qword ptr [7FFE778DA880]; System.Text.Json.Serialization.Converters.ObjectDefaultConverter`1[[System.__Canon, System.Private.CoreLib]].OnTryWrite(System.Text.Json.Utf8JsonWriter, System.__Canon, System.Text.Json.JsonSerializerOptions, System.Text.Json.WriteStack ByRef)
       mov       r15d,eax
M14_L17:
       mov       rcx,[rbp+30]
       mov       edx,r15d
       call      qword ptr [7FFE779BEE08]; System.Text.Json.WriteStack.Pop(Boolean)
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
       call      qword ptr [7FFE779BEF88]
       int       3
M14_L21:
       mov       rcx,rbx
       call      qword ptr [7FFE779BEFB8]
       jmp       near ptr M14_L09
M14_L22:
       cmp       byte ptr [rsi+1A],0
       je        near ptr M14_L01
       mov       rdi,[rdi]
       add       rcx,90
       call      qword ptr [7FFE779256E0]; System.Nullable`1[[System.Text.Json.Serialization.JsonNumberHandling, System.Text.Json]].get_Value()
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
       call      qword ptr [7FFE77CCDB60]
       int       3
M14_L24:
       mov       rcx,rbx
       call      qword ptr [7FFE77CCDB78]
       test      eax,eax
       jne       near ptr M14_L04
       mov       rcx,rbx
       call      qword ptr [7FFE77CCDB90]
       jmp       near ptr M14_L04
M14_L25:
       mov       [rbp-48],r14
       mov       [rbp-40],edi
       lea       rdx,[rbp-48]
       mov       rcx,rbx
       call      qword ptr [7FFE77CCDBA8]
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
       call      qword ptr [7FFE779BEF28]
       int       3
M14_L28:
       mov       rcx,r13
       call      qword ptr [7FFE778A6208]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       near ptr M14_L12
M14_L29:
       mov       [rsp+20],rcx
       mov       rdx,[rdi]
       mov       rcx,rsi
       mov       r9,r14
       call      qword ptr [7FFE77CCDA88]
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
       call      qword ptr [7FFE77CCDAA0]
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
       call      qword ptr [7FFE77CCE940]
M14_L35:
       mov       rdx,rbx
       mov       rcx,offset MT_System.InvalidOperationException
       call      qword ptr [7FFE772B6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M14_L37
       mov       rdx,rbx
       mov       rcx,offset MT_System.Text.Json.JsonException
       call      qword ptr [7FFE772B6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M14_L36
       mov       rcx,rsi
       call      qword ptr [7FFE77CCE958]
       test      rax,rax
       jne       near ptr M14_L39
       mov       rcx,[rbp+30]
       mov       rdx,rsi
       call      qword ptr [7FFE77CCE970]
       jmp       near ptr M14_L39
M14_L36:
       mov       rdx,rbx
       mov       rcx,offset MT_System.NotSupportedException
       call      qword ptr [7FFE772B6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M14_L39
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       mov       rdx,24B30A1E9D0
       cmp       [rcx],ecx
       call      qword ptr [7FFE77CCE9A0]
       test      eax,eax
       jne       short M14_L39
       jmp       short M14_L38
M14_L37:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       mov       rdx,24B30A1E980
       call      qword ptr [7FFE77534E40]; System.String.op_Equality(System.String, System.String)
       test      eax,eax
       je        short M14_L39
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFE77CCE988]
       jmp       short M14_L39
M14_L38:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      qword ptr [7FFE77CCE9B8]
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
       call      qword ptr [7FFE77CCE640]
       int       3
M15_L04:
       mov       edx,[rbx+34]
       test      edx,edx
       je        short M15_L05
       mov       rcx,[rbx+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE77DCB608]
       xor       ecx,ecx
       mov       [rbx+34],ecx
       mov       rsi,[rbx+10]
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFE77CCE670]
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
       call      qword ptr [7FFE77CCE688]
M15_L05:
       mov       rcx,[rbx+10]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+30]
       jmp       short M15_L02
M15_L06:
       mov       r11,7FFE77201008
       call      qword ptr [r11]
       jmp       near ptr M15_L01
; Total bytes of code 232
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
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+28],r9d
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       xor       r14d,r14d
       cmp       byte ptr [rsi+9E],0
       je        near ptr M16_L20
       mov       r14,[rsi+8]
       test      r14,r14
       je        near ptr M16_L10
M16_L00:
       mov       r15,[r14+8]
       mov       rcx,20A9BC01938
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M16_L11
M16_L01:
       cmp       [r15],r15b
       test      rbx,rbx
       je        near ptr M16_L12
       mov       r12,[r15+8]
       mov       rcx,[r12+8]
       cmp       byte ptr [r15+19],0
       jne       near ptr M16_L08
       mov       rdx,rbx
       mov       r11,7FFE77200D28
       call      qword ptr [r11]
M16_L02:
       lea       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,r12
       mov       r8,rbx
       mov       [rbp-44],eax
       mov       r9d,eax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      qword ptr [7FFE77716118]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValueInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, Int32, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M16_L13
M16_L03:
       mov       r8,[rbp-40]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       cmp       byte ptr [rbp+38],0
       jne       near ptr M16_L14
M16_L04:
       mov       rcx,[r8+10]
       test      rcx,rcx
       jne       near ptr M16_L15
       mov       r14,[r8+8]
M16_L05:
       test      dil,dil
       je        short M16_L06
       test      r14,r14
       je        near ptr M16_L17
       mov       rcx,7FFE77D44618
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       byte ptr [r14+119],2
       jne       short M16_L09
M16_L06:
       test      r14,r14
       je        near ptr M16_L21
M16_L07:
       mov       rcx,7FFE77D44630
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,r14
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
M16_L08:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M16_L02
M16_L09:
       mov       rcx,r14
       call      qword ptr [7FFE778A6208]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       short M16_L06
M16_L10:
       mov       rcx,rsi
       call      qword ptr [7FFE777CC4B0]; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       mov       r14,rax
       jmp       near ptr M16_L00
M16_L11:
       mov       rcx,offset MT_System.Func<System.Type, System.Text.Json.JsonSerializerOptions+CachingContext, System.Text.Json.JsonSerializerOptions+CachingContext+CacheEntry>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       xor       edx,edx
       mov       r8,offset System.Text.Json.JsonSerializerOptions+CachingContext.CreateCacheEntry(System.Type, CachingContext)
       mov       r9,7FFE771FD050
       call      qword ptr [7FFE772B6E68]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,20A9BC01938
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M16_L01
M16_L12:
       mov       ecx,1
       mov       rdx,7FFE7765FC38
       call      qword ptr [7FFE775376F0]
       mov       rcx,rax
       call      qword ptr [7FFE778A5F80]
       int       3
M16_L13:
       mov       rdx,rbx
       mov       r8,r14
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-40]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,[rbp-44]
       shl       r9,20
       or        r9,1
       mov       rdx,r12
       mov       r8,rbx
       mov       rcx,r15
       call      qword ptr [7FFE77717FC0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M16_L03
M16_L14:
       cmp       byte ptr [r8+20],0
       je        short M16_L16
       jmp       near ptr M16_L04
M16_L15:
       call      qword ptr [7FFE77CC6A30]
       int       3
M16_L16:
       mov       rcx,r14
       mov       rdx,rbx
       call      qword ptr [7FFE77CC6FA0]
       mov       r14,rax
       jmp       near ptr M16_L05
M16_L17:
       mov       rcx,7FFE77D4461C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M16_L06
M16_L18:
       mov       rcx,7FFE77D44620
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M16_L06
M16_L19:
       mov       rcx,7FFE77D44624
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M16_L07
M16_L20:
       cmp       byte ptr [rbp+30],0
       je        short M16_L18
       mov       rcx,7FFE77D44628
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE777CCA50]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       r14,rax
       jmp       near ptr M16_L06
M16_L21:
       cmp       byte ptr [rbp+29],0
       je        short M16_L19
       mov       rcx,7FFE77D4462C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rsi+20]
       mov       rcx,rbx
       call      qword ptr [7FFE77CC6A48]
       int       3
; Total bytes of code 711
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
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M17_L05
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
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
       mov       rcx,24B30A162A0
       mov       [rsi],rcx
       cmp       byte ptr [rsi+10],0
       je        near ptr M17_L04
       mov       esi,[rbx+8]
       test      esi,esi
       je        near ptr M17_L04
       mov       rcx,20A9BC01DD0
       mov       rbp,[rcx]
       lea       ecx,[rsi-1]
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],0B
       jle       near ptr M17_L06
       mov       rcx,[rcx+240]
       mov       rax,[rcx+58]
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
       mov       rcx,20A9BC00C90
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
       mov       ecx,0A
       call      qword ptr [7FFE777C4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M17_L00
M17_L06:
       mov       ecx,0B
       call      qword ptr [7FFE777C4420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M17_L01
M17_L07:
       mov       rcx,rbp
       call      qword ptr [7FFE779BF348]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M17_L02
M17_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77CCC318]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FFE771F4000
       call      qword ptr [7FFE775376F0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE77715B30]
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
       call      qword ptr [7FFE77CCE4A8]
M17_L10:
       mov       r13,[rax+8]
       call      qword ptr [7FFE77A9EC40]; System.Threading.Thread.GetCurrentProcessorNumber()
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
       call      qword ptr [7FFE778AD2D8]; System.Threading.Monitor.Enter(System.Object)
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
       call      qword ptr [7FFE772B6820]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+54],eax
       mov       [rsp+50],esi
       mov       rcx,rbp
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r12
       mov       r8d,[rsp+54]
       mov       r9d,[rsp+50]
       mov       edx,3
       call      qword ptr [7FFE77CCC330]
       test      r13d,r15d
       jne       near ptr M17_L04
       mov       rcx,rbx
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rbp
       call      qword ptr [7FFE777CC630]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFE77CCC348]
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
       call      00007FFED6EDF840
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE772B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE772B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24B30A10008
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
       call      qword ptr [7FFE77CC4750]
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
       call      qword ptr [7FFFAFF9F478]
       cmp       byte ptr [rax],0
       je        near ptr M20_L04
       call      qword ptr [7FFFAFFA5968]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M20_L00
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFFAFF9F230]; CORINFO_HELP_ASSIGN_REF
       jmp       short M20_L01
M20_L00:
       call      qword ptr [7FFFAFFA1550]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M20_L02
M20_L01:
       mov       byte ptr [rbx+9E],1
       mov       byte ptr [rbx+9F],1
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M20_L02:
       call      qword ptr [7FFFAFF9F470]
       cmp       byte ptr [rax],0
       je        short M20_L01
       xorps     xmm0,xmm0
       movups    [rsp+30],xmm0
       mov       [rsp+30],rdi
       mov       [rsp+38],rsi
       lea       rcx,[rsp+20]
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       lea       r8,[rsp+30]
       mov       r9d,2
       call      qword ptr [7FFFAFFA6E98]
       lea       rcx,[rsp+20]
       call      qword ptr [7FFFAFFA5998]
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      qword ptr [7FFFAFF9F230]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M20_L01
       cmp       [rsi+10],rbx
       je        short M20_L03
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+9F],0
       jne       short M20_L03
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFFAFFA5250]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M20_L01
M20_L03:
       mov       rcx,[rsi+8]
       lea       r11,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M20_L01
M20_L04:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M20_L05
       call      qword ptr [7FFFAFFA1568]
       test      rax,rax
       je        near ptr M20_L01
M20_L05:
       call      qword ptr [7FFFAFFA3BD0]
       int       3
; Total bytes of code 286
```
```assembly
; System.Text.Json.JsonSerializerOptions.<get_CacheContext>g__GetOrCreate|1_0()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFFAFFA52F8]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       cmp       [rbx],bl
       lea       rdx,[rbx+8]
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFFAFFA32C0]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
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
       call      00007FFED6E20370
       test      eax,eax
       jne       short M22_L01
       mov       rcx,rsi
       call      qword ptr [7FFE77B5FF60]
M22_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M22_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M22_L03
       mov       rcx,7FFE77D4C808
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FFE778A6220]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M22_L04
M22_L02:
       xor       ecx,ecx
       call      qword ptr [7FFE77B5F1F8]
       int       3
M22_L03:
       mov       rcx,7FFE77D4C804
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE77CC6A30]
       int       3
M22_L04:
       mov       rcx,7FFE77D4C80C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FFED6E6FFC0
       test      eax,eax
       jne       near ptr M22_L10
M22_L05:
       mov       rcx,7FFE77D4C810
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFE77D4C814
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M22_L06:
       call      qword ptr [7FFE77CC7558]
       int       3
M22_L07:
       mov       rcx,7FFE77D4C800
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FFE77CC6A30]
       int       3
M22_L08:
       mov       rcx,rbx
       call      qword ptr [7FFE777CC4E0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M22_L09
       call      qword ptr [7FFE77B5F720]
       int       3
M22_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FFED6E8EEF0
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M22_L00
M22_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FFE77B5FB28]
       jmp       near ptr M22_L05
       sub       rsp,28
       call      qword ptr [7FFE77CC7570]
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
       mov       rcx,7FFE77D4C80C
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M22_L11
       xor       ecx,ecx
       call      qword ptr [7FFE77B5F1F8]
       int       3
M22_L11:
       mov       rcx,[rbp-20]
       call      00007FFED6E6FFC0
       test      eax,eax
       je        short M22_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FFE77B5FB28]
M22_L12:
       mov       rcx,7FFE77D4C810
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
       jmp       qword ptr [7FFE77B5FDF8]
; Total bytes of code 88
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFED6D07E38]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jmp       qword ptr [7FFE772B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+50]
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
       mov       rcx,[rcx+40]
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
       mov       rax,15847800110
       mov       r15,[rax]
       test      r15,r15
       jne       short M00_L01
       mov       rax,158478000F0
       mov       r15,[rax]
       test      r15,r15
       je        near ptr M00_L16
M00_L01:
       mov       rcx,15847800C58
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,198DC7F1518
       mov       [rdi+10],rcx
       lea       rcx,[rdi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+30],1
       mov       [rbp-48],rdi
       mov       rcx,15847801F80
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
       mov       rdx,198DC801018
       xor       r8d,r8d
       call      qword ptr [7FFE77A653F8]; System.Xml.XmlEncodedRawTextWriter.ValidateContentChars(System.String, System.String, Boolean)
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
       mov       rax,[7FFE777EB6C8]
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
       call      qword ptr [7FFE77A53EA0]; System.Xml.XmlEncodedRawTextWriter.WriteXmlDeclaration(System.Xml.XmlStandalone)
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
       mov       rcx,15847801FA8
       mov       rdx,[rcx]
       jmp       short M00_L07
M00_L06:
       mov       rdx,15847801FB0
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
       mov       r11,198DC8011D0
       mov       [rcx],r11
       mov       r11,198DC8011F0
       mov       [rcx+8],r11
       mov       dword ptr [rcx+10],3
       mov       dword ptr [rcx+14],0FFFFFFFF
       mov       rcx,r14
       cmp       r15d,1
       jbe       near ptr M00_L11
       add       rcx,28
       mov       r11,198DC801150
       mov       [rcx],r11
       mov       r11,198DC801170
       mov       [rcx+8],r11
       mov       dword ptr [rcx+10],3
       mov       dword ptr [rcx+14],0FFFFFFFF
       cmp       qword ptr [r13+20],0
       je        short M00_L08
       mov       rcx,[r13+20]
       mov       r11,7FFE771D1288
       mov       r12,198DC7F0008
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
       mov       r12,198DC7F0008
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
       call      qword ptr [7FFE7728C960]; System.Object.GetType()
       mov       rdx,rax
       mov       rcx,r14
       xor       r8d,r8d
       call      qword ptr [7FFE77A65638]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],rcx
       mov       rcx,r14
       mov       rdx,r13
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE77ACCA38]; System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       mov       rcx,[rdi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE774CF790]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       ecx,[r13+78]
       cmp       ecx,10
       jg        short M00_L10
       mov       rax,15847801FA0
       mov       rax,[rax]
       cmp       ecx,11
       jae       short M00_L11
       mov       ecx,[rax+rcx*4+10]
       cmp       ecx,5
       je        short M00_L12
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FFE77A555C0]; System.Xml.XmlWellFormedWriter.Close()
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
       mov       rcx,[rbx+18]
       lea       r8,[rbp-40]
       mov       rdx,7FFE77B8A6E8
       cmp       [rcx],ecx
       call      qword ptr [7FFE77B26808]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE778FDDE8]
       mov       ecx,1C77
       mov       rdx,7FFE77625418
       call      qword ptr [7FFE775076F0]
       mov       rbx,rax
       mov       ecx,1B55
       mov       rdx,7FFE77625418
       call      qword ptr [7FFE775076F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77287810]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFE77625418
       call      qword ptr [7FFE775076F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77287810]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE77C9F378]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE77B2FC90]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L15:
       mov       ecx,2
       call      qword ptr [7FFE77794420]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L16:
       call      qword ptr [7FFE77505D40]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L17:
       mov       rcx,rdi
       call      00007FFED6EA5FF0
       jmp       near ptr M00_L13
       sub       rsp,38
       mov       rcx,[rbp-50]
       mov       eax,[rcx+78]
       cmp       eax,10
       jg        short M00_L18
       mov       rdx,15847801FA0
       mov       rdi,[rdx]
       cmp       eax,11
       jae       short M00_L20
       mov       esi,[rdi+rax*4+10]
       cmp       esi,5
       je        short M00_L19
M00_L18:
       call      qword ptr [7FFE77A555C0]; System.Xml.XmlWellFormedWriter.Close()
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
       call      00007FFED6EA5FF0
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
       mov       rdx,7FFED3D4B3E0
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
       mov       rdx,15847802790
       mov       rcx,[rdx]
       test      rcx,rcx
       jne       short M01_L06
       mov       ecx,6
       call      qword ptr [7FFE7750C180]
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
       call      qword ptr [7FFE77C9DB00]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFE77C9D5F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE7750FC90]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L07:
       cmp       eax,26
       je        short M01_L12
M01_L08:
       call      qword ptr [7FFE77C9F438]
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
       call      qword ptr [7FFE77C9F450]
       test      eax,eax
       je        short M01_L13
       inc       edi
       jmp       near ptr M01_L01
M01_L11:
       mov       ecx,edi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       call      qword ptr [7FFE77C9F450]
       test      eax,eax
       je        near ptr M01_L01
       jmp       short M01_L14
M01_L12:
       mov       rcx,198DC801048
       call      qword ptr [7FFE77C9DB18]
       mov       rbp,rax
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE77C9F468]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE77C9DB48]
       mov       rbp,rax
       jmp       short M01_L15
M01_L13:
       mov       rcx,198DC8010D8
       call      qword ptr [7FFE77C9DB18]
       mov       rbp,rax
       jmp       short M01_L15
M01_L14:
       mov       rcx,198DC801088
       call      qword ptr [7FFE77C9DB18]
       mov       rbp,rax
       mov       r8d,edi
       movzx     ecx,word ptr [rbx+r8*2+0C]
       mov       r8,15847800100
       mov       r8,[r8]
       mov       rdx,198DC801138
       call      qword ptr [7FFE7750EA00]; System.Number.<FormatUInt32>g__FormatUInt32Slow|23_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE77C9D5F0]
       mov       rbp,rax
M01_L15:
       call      qword ptr [7FFE77C9DB60]
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
       call      qword ptr [7FFE77C9DB48]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE7750FC90]
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
       mov       rdi,198DC80966C
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
       mov       rdi,198DC8096A4
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
       mov       rdi,198DC8096C4
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
       call      qword ptr [7FFE77ACCD68]; System.Text.EncodingTable.GetCodePageDataItem(Int32)
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
       mov       rdx,198DC80972C
       lea       r8,[rdx+6]
       mov       rcx,rbx
       call      qword ptr [7FFE77ACCD20]; System.Xml.XmlEncodedRawTextWriter.RawText(Char*, Char*)
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
       call      qword ptr [7FFE77C9F300]
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
       call      qword ptr [7FFE77C9F2D0]
       test      eax,eax
       je        short M02_L32
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,r15
       call      qword ptr [7FFE77C9D4B8]
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
       call      qword ptr [7FFE77C9F2E8]
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
       call      qword ptr [7FFE77C9F2D0]
       test      eax,eax
       je        short M02_L40
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,r15
       call      qword ptr [7FFE77C9D4B8]
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
       call      qword ptr [7FFE77C9F2E8]
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
       call      qword ptr [7FFE77C9F2D0]
       test      eax,eax
       je        short M02_L48
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,r15
       call      qword ptr [7FFE77C9D4B8]
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
       call      qword ptr [7FFE77C9F2E8]
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
       call      qword ptr [7FFE77C9DF50]
       mov       rsi,rax
       mov       ecx,[rdi+20]
       mov       [rbx+8],ecx
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE77A66670]; System.SR.Format(System.String, System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE77507708]
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
       call      qword ptr [7FFE77C9F2D0]
       test      eax,eax
       je        short M02_L59
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8,r15
       call      qword ptr [7FFE77C9D4B8]
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
       call      qword ptr [7FFE77C9F2E8]
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
       mov       rdx,198DC8096E8
       call      qword ptr [7FFE77ACD020]; System.Xml.XmlEncodedRawTextWriter.RawText(System.String)
       mov       rdx,198DC809640
       mov       rcx,198DC809620
       cmp       esi,1
       cmovne    rdx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFE77ACD020]; System.Xml.XmlEncodedRawTextWriter.RawText(System.String)
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
       call      qword ptr [7FFE77285C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       mov       rcx,15847801FB8
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
       mov       r11,7FFE771D1678
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
       cmp       dword ptr [7FFE771CB160],1
       je        near ptr M04_L14
       mov       rcx,15847801FF0
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
       mov       r11,7FFE771D1688
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
       mov       r11,7FFE771D1690
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
       call      qword ptr [7FFE77B267F0]; System.Xml.Serialization.XmlReflectionImporter.GetTopLevelMapping(System.Type, System.String)
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
       mov       ecx,0EB9B
       mov       rdx,7FFE779BE1C0
       call      qword ptr [7FFE775076F0]
       mov       rcx,rax
       call      qword ptr [7FFE77B2F0C0]
       int       3
M04_L18:
       mov       rcx,rdi
       mov       rdx,198DC7F0008
       call      qword ptr [7FFE7728C7F8]; System.String.Equals(System.String, System.String)
       test      eax,eax
       jne       near ptr M04_L00
       jmp       near ptr M04_L08
M04_L19:
       lea       rcx,[rbp-60]
       mov       edx,14
       call      qword ptr [7FFE77C9D728]
       mov       eax,[rbp-58]
       mov       r9,[rbp-88]
       jmp       near ptr M04_L04
M04_L20:
       cmp       qword ptr [r14+20],0
       je        short M04_L21
       mov       rcx,[r14+20]
       mov       r8,rsi
       mov       rdx,r11
       mov       r11,7FFE771D1680
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
       call      qword ptr [7FFE77C9DB90]
       mov       rcx,rsi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE77A6E970]; System.Xml.Serialization.XmlMapping.GenerateKey(System.Type, System.Xml.Serialization.XmlRootAttribute, System.String)
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
       call      qword ptr [7FFE77507960]
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
       call      qword ptr [7FFE77A65E90]; System.Runtime.CompilerServices.ConditionalWeakTable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M04_L12
       lea       r8,[rbp-68]
       mov       rcx,[rbp-70]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE772F9680]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       jmp       near ptr M04_L12
M04_L32:
       mov       rdx,15847801FF0
       mov       rcx,[rdx]
       mov       [rbp-90],rcx
       xor       edx,edx
       mov       [rbp-40],edx
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE77285998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,15847801FF0
       mov       rcx,[rcx]
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE77A65E78]; System.Xml.Serialization.TempAssemblyCache.get_Item(System.String, System.Type)
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
       call      qword ptr [7FFE77A65EA8]; System.Xml.Serialization.TempAssembly.LoadGeneratedAssembly(System.Type, System.String, System.Xml.Serialization.XmlSerializerImplementation ByRef)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M04_L34
       cmp       dword ptr [7FFE771CB160],3
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
       call      qword ptr [7FFE77A660E8]; System.Xml.Serialization.Compiler.GetTempAssemblyName(System.Reflection.AssemblyName, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.IO.FileLoadException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE77C9DBC0]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFE77C9D5F0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE77C9DBD8]
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
       call      qword ptr [7FFE77A66718]; System.Xml.Serialization.XmlReflectionImporter..ctor(System.Xml.Serialization.XmlAttributeOverrides, System.String)
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE77A66778]; System.Xml.Serialization.XmlReflectionImporter.ImportTypeMapping(System.Type, System.Xml.Serialization.XmlRootAttribute, System.String)
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+18]
       mov       rdx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FFE77A6EB68]; System.Xml.Serialization.XmlSerializer.GenerateTempAssembly(System.Xml.Serialization.XmlMapping, System.Type, System.String, System.String)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M04_L35
M04_L34:
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFE77B267F0]; System.Xml.Serialization.XmlReflectionImporter.GetTopLevelMapping(System.Type, System.String)
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
       call      qword ptr [7FFE77C9DBF0]
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M04_L35:
       mov       r9,[rbx+8]
       mov       rcx,15847801FF0
       mov       rcx,[rcx]
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE77ACC8D0]; System.Xml.Serialization.TempAssemblyCache.Add(System.String, System.Type, System.Xml.Serialization.TempAssembly)
       nop
       cmp       byte ptr [rbp-40],0
       je        near ptr M04_L13
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE77286820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M04_L13
M04_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       byte ptr [rbp-40],0
       je        short M04_L37
       mov       rcx,[rbp-90]
       call      qword ptr [7FFE77286820]; System.Threading.Monitor.Exit(System.Object)
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
       mov       r15,[rbp+30]
       cmp       qword ptr [rbx+10],0
       jne       near ptr M05_L04
       mov       r13,[rbx+18]
       mov       rcx,r13
       cmp       dword ptr [7FFE771CB160],1
       je        short M05_L03
       test      rcx,rcx
       je        short M05_L00
       movzx     ecx,byte ptr [rcx+25]
       test      ecx,ecx
       jne       short M05_L03
M05_L00:
       cmp       byte ptr [rbx+31],0
       jne       short M05_L03
       mov       r12,[rbx+8]
       test      r12,r12
       je        near ptr M05_L06
       cmp       byte ptr [rbx+30],0
       jne       near ptr M05_L06
       test      rdi,rdi
       jne       near ptr M05_L09
M05_L01:
       call      qword ptr [7FFE77ACCA68]; System.Xml.Serialization.XmlSerializer.get_DefaultNamespaces()
       mov       rdi,rax
M05_L02:
       mov       [rsp+20],rdi
       mov       [rsp+28],r15
       mov       rdi,[rbp+38]
       mov       [rsp+30],rdi
       mov       rcx,r12
       mov       rdx,r13
       mov       r8,rsi
       mov       r9,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE77ACCB10]; System.Xml.Serialization.TempAssembly.InvokeWriter(System.Xml.Serialization.XmlMapping, System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       jmp       near ptr M05_L10
M05_L03:
       mov       [rsp+20],r15
       mov       r15,[rbp+38]
       mov       [rsp+28],r15
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,r14
       mov       r9,rdi
       call      qword ptr [7FFE77C9F558]
       jmp       near ptr M05_L10
M05_L04:
       test      r15,r15
       je        short M05_L05
       cmp       dword ptr [r15+8],0
       jle       short M05_L05
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77C9DE30]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE77C9D5F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE776E5A88]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L05:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,r14
       mov       r9,rdi
       call      qword ptr [7FFE77C9DE48]
       jmp       short M05_L10
M05_L06:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r13,rax
       test      rdi,rdi
       je        short M05_L07
       mov       rcx,rdi
       call      qword ptr [7FFE77C9F570]
       test      eax,eax
       je        short M05_L07
       mov       r8,rdi
       jmp       short M05_L08
M05_L07:
       call      qword ptr [7FFE77ACCA68]; System.Xml.Serialization.XmlSerializer.get_DefaultNamespaces()
       mov       r8,rax
M05_L08:
       mov       rdi,[rbp+38]
       mov       [rsp+20],rdi
       mov       rcx,r13
       mov       rdx,rsi
       mov       r9,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE77C9F588]
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,r13
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M05_L10
M05_L09:
       mov       rcx,rdi
       call      qword ptr [7FFE77C9F570]
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
       jmp       qword ptr [7FFE77A555C8]; System.Xml.XmlWellFormedWriter.Flush()
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
       call      qword ptr [7FFE77C9DEA8]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFE77795788]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M05_L13:
       mov       rax,offset MT_System.Reflection.TargetInvocationException
       cmp       [rbx],rax
       jne       short M05_L12
       call      qword ptr [7FFE77504E10]
       mov       rbx,rax
       jmp       short M05_L12
; Total bytes of code 566
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
       call      00007FFED6EDF840
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
       call      qword ptr [7FFE77285818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,198DC7F0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,196A5
       mov       rdx,7FFE771C4000
       call      qword ptr [7FFE775076F0]
       mov       rbx,rax
       call      qword ptr [7FFE77B2F600]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE77875CB0]
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
       call      qword ptr [7FFE77A53F58]; System.Xml.XmlEncodedRawTextWriter.FlushBuffer()
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
       call      qword ptr [7FFE77A55530]; System.Xml.XmlWellFormedWriter.WriteEndElement()
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
       call      qword ptr [7FFE77ACCCF0]; System.Xml.XmlWellFormedWriter.AdvanceState(Token)
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
       call      qword ptr [7FFE775DBEC0]
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
       call      00007FFED6EA5FF0
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
       call      qword ptr [7FFE77287AB0]; System.GC.SuppressFinalize(System.Object)
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
       mov       r8,15847801FA0
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
       call      qword ptr [7FFE77A53F58]; System.Xml.XmlEncodedRawTextWriter.FlushBuffer()
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
       call      00007FFED6EDF840
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE77285818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE77285818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,198DC7F0008
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
       call      qword ptr [7FFE77C94630]
       int       3
; Total bytes of code 231
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFED6D07E38]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFED6CEF7D8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFED6D06B30]
       mov       rdx,rax
       test      rsi,rsi
       je        short M11_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFED6D07CE8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L00:
       call      qword ptr [7FFED6D05510]
       int       3
; Total bytes of code 61
```

