## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark.GetRecordCountAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFC62BB4A98]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFC635C7630]; DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<GetRecordCountAsync>d__9.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFC63ED6070]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFC638F53C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFC63ADF930]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFC63ED6070]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFC63ADF8D0]
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFCC22A9030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.HashCode.Combine[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFCC22A9038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFCC22AAEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFCC22A8FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<GetRecordCountAsync>d__9.MoveNext()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,258
       vzeroupper
       lea       rbp,[rsp+290]
       xor       eax,eax
       mov       [rbp-198],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M03_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L00
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L196
       mov       rsi,[rbx+1A8]
       test      rsi,rsi
       je        near ptr M03_L107
       mov       rcx,offset MT_LinqToDB.Internal.Linq.Table<DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TestDbEntity>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TempFileDataContext
       cmp       [rsi],rcx
       jne       near ptr M03_L108
       mov       r14,[rsi+28]
M03_L01:
       cmp       [r14],r14b
       mov       r15,287B5C645E0
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TestDbEntity
       test      dword ptr [rcx],80000000
       je        short M03_L02
       xor       eax,eax
       jmp       short M03_L03
M03_L02:
       test      byte ptr [rcx],30
       setne     al
       movzx     eax,al
M03_L03:
       movzx     ecx,al
       test      ecx,ecx
       jne       near ptr M03_L109
M03_L04:
       xor       ecx,ecx
M03_L05:
       test      rcx,rcx
       cmove     rcx,r15
       mov       r15,rcx
       mov       r13,[r14+10]
       mov       r12d,[r13+8]
       test      r12d,r12d
       jle       short M03_L07
       add       r13,10
M03_L06:
       mov       rcx,[r13]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC6323D0E0]; LinqToDB.Internal.Mapping.MappingSchemaInfo.GetScalarType(System.Type)
       mov       [rbp-50],ax
       cmp       byte ptr [rbp-50],0
       jne       near ptr M03_L110
       add       r13,8
       dec       r12d
       jne       short M03_L06
M03_L07:
       mov       rcx,[r14+28]
       mov       r14,[rcx+10]
       mov       r13,r15
       mov       r12,[rcx+8]
       cmp       [r14],r14b
       test      r12,r12
       je        near ptr M03_L111
       mov       rax,[r14+8]
       mov       [rbp-1A0],rax
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       near ptr M03_L112
       mov       rcx,287B5C64C40
       mov       [rbp-98],rcx
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       cmp       qword ptr [rbp-0A0],0
       jne       short M03_L08
       mov       rcx,[rbp-98]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-0A0]
       cmp       qword ptr [rbp-0A0],0
       je        near ptr M03_L28
M03_L08:
       mov       rdx,[rcx]
       mov       [rbp-1A8],rdx
       mov       rcx,offset MT_LinqToDB.Internal.SqlQuery.SqlParameter
       cmp       [rdx],rcx
       je        near ptr M03_L29
       mov       rcx,rdx
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+18]
       mov       edx,eax
M03_L09:
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       imul      eax,edx,0A5555529
       mov       [rbp-8C],eax
       mov       [rbp-0A8],r13
       mov       [rbp-0B0],rcx
       lea       rcx,[rbp-0A8]
       cmp       qword ptr [rbp-0B0],0
       jne       short M03_L10
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       lea       rcx,[rbp-0B0]
       cmp       qword ptr [rbp-0B0],0
       je        near ptr M03_L32
M03_L10:
       mov       r13,[rcx]
       mov       rcx,offset MT_LinqToDB.Internal.SqlQuery.SqlParameter
       cmp       [r13],rcx
       je        near ptr M03_L33
       mov       rcx,r13
       mov       rdx,[r13]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+18]
       mov       r13d,eax
M03_L11:
       xor       ecx,ecx
       mov       [rbp-0B0],rcx
       imul      r13d,0A5555529
       mov       [rbp-0B8],rcx
       mov       [rbp-0C0],rcx
       lea       rcx,[rbp-0B8]
       cmp       qword ptr [rbp-0C0],0
       jne       short M03_L12
       mov       rcx,[rbp-0B8]
       mov       [rbp-0C0],rcx
       lea       rcx,[rbp-0C0]
       cmp       qword ptr [rbp-0C0],0
       je        near ptr M03_L36
M03_L12:
       mov       rax,[rcx]
       mov       [rbp-1B0],rax
       mov       rcx,offset MT_LinqToDB.Internal.SqlQuery.SqlParameter
       cmp       [rax],rcx
       je        near ptr M03_L37
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
M03_L13:
       xor       edx,edx
       mov       [rbp-0C0],rdx
       mov       r8d,[rbp-8C]
       add       r13d,r8d
       add       r13d,eax
M03_L14:
       mov       rax,[rbp-1A0]
       mov       r8,[rax+8]
       mov       [rbp-1B8],r8
       test      r8,r8
       jne       near ptr M03_L114
       mov       rcx,[rax+10]
       mov       edx,r13d
       imul      rdx,[rax+28]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M03_L195
       mov       edx,edx
       mov       r8,[rcx+rdx*8+10]
       test      r8,r8
       je        near ptr M03_L46
M03_L15:
       cmp       r13d,[r8+18]
       jne       near ptr M03_L45
       mov       [rbp-1C8],r8
       lea       rcx,[r8+20]
       mov       r10,[rcx]
       mov       r9,[rcx+8]
       mov       [rbp-240],r9
       mov       r11,[rcx+10]
       mov       [rbp-248],r11
       test      r10,r10
       je        near ptr M03_L44
       mov       rdx,offset MT_System.RuntimeType
       cmp       [r10],rdx
       je        near ptr M03_L40
       mov       rcx,r10
       mov       rdx,287B5C64C40
       mov       r10,[r10]
       mov       r10,[r10+40]
       call      qword ptr [r10+10]
M03_L16:
       test      eax,eax
       je        near ptr M03_L113
       mov       r9,[rbp-240]
       test      r9,r9
       je        near ptr M03_L43
       mov       rdx,offset MT_System.RuntimeType
       mov       rax,rdx
       cmp       [r9],rax
       je        near ptr M03_L41
       mov       rcx,r9
       mov       rdx,r15
       mov       rax,[r9]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
M03_L17:
       test      eax,eax
       je        near ptr M03_L43
       cmp       qword ptr [rbp-248],0
       je        near ptr M03_L42
       xor       edx,edx
M03_L18:
       test      edx,edx
       mov       r8,[rbp-1C8]
       je        near ptr M03_L45
       mov       rax,[r8+8]
       mov       [rbp-70],rax
M03_L19:
       mov       rdx,[rbp-70]
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       r14,rdx
       test      r14,r14
       je        short M03_L20
       mov       rcx,offset MT_LinqToDB.Mapping.ScalarTypeAttribute[]
       cmp       [r14],rcx
       je        short M03_L20
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r14,rax
M03_L20:
       mov       rcx,24736C01548
       test      r14,r14
       cmove     r14,[rcx]
       cmp       dword ptr [r14+8],0
       jne       near ptr M03_L118
       xor       r13d,r13d
M03_L21:
       xor       r14d,r14d
       test      r13,r13
       jne       near ptr M03_L119
       mov       rax,offset MT_System.RuntimeType
       mov       r12,rax
       cmp       [r15],r12
       jne       near ptr M03_L121
       mov       rcx,[r15+18]
       test      cl,2
       jne       near ptr M03_L120
       mov       rcx,[rcx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M03_L22:
       test      eax,eax
       jne       near ptr M03_L123
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+78]
       call      qword ptr [rax]
       test      eax,eax
       jne       near ptr M03_L123
       cmp       byte ptr [7FFC6276B198],0
       jne       near ptr M03_L122
M03_L23:
       mov       eax,r14d
M03_L24:
       test      eax,eax
       jne       near ptr M03_L162
       mov       rcx,offset MT_System.Type[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,287B5C645E0
       mov       [rax+10],r15
       mov       rcx,24736C01CC0
       mov       rcx,[rcx]
       mov       rdx,rax
       call      qword ptr [7FFC62969DE0]; System.Reflection.RuntimeMethodInfo.MakeGenericMethod(System.Type[])
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TempFileDataContext
       cmp       [rsi],rcx
       jne       near ptr M03_L124
       mov       r12,[rsi+28]
M03_L25:
       mov       rcx,rsi
       call      qword ptr [7FFC6282C9A8]; System.Object.GetType()
       mov       r14,rax
       mov       rcx,offset MT_LinqToDB.Internal.Expressions.SqlQueryRootExpression
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       test      r15,r15
       je        near ptr M03_L125
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [r15],rcx
       jne       near ptr M03_L126
       mov       rcx,r15
       call      qword ptr [7FFC62969D90]; System.Reflection.RuntimeMethodInfo.get_ContainsGenericParameters()
M03_L26:
       test      eax,eax
       jne       near ptr M03_L127
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [r15],rcx
       jne       near ptr M03_L47
       mov       r14d,[r15+5C]
M03_L27:
       test      r14b,10
       jne       near ptr M03_L48
       call      qword ptr [7FFC638FF840]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L28:
       xor       edx,edx
       jmp       near ptr M03_L09
M03_L29:
       mov       rcx,rdx
       call      00007FFCC2453FE0
       test      eax,eax
       je        short M03_L31
       mov       edx,eax
M03_L30:
       jmp       near ptr M03_L09
M03_L31:
       mov       rcx,[rbp-1A8]
       call      qword ptr [7FFC6282E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       edx,eax
       jmp       short M03_L30
M03_L32:
       xor       r13d,r13d
       jmp       near ptr M03_L11
M03_L33:
       mov       rcx,r13
       call      00007FFCC2453FE0
       test      eax,eax
       je        short M03_L35
       mov       r13d,eax
M03_L34:
       jmp       near ptr M03_L11
M03_L35:
       mov       rcx,r13
       call      qword ptr [7FFC6282E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r13d,eax
       jmp       short M03_L34
M03_L36:
       xor       eax,eax
       jmp       near ptr M03_L13
M03_L37:
       mov       rcx,rax
       call      00007FFCC2453FE0
       test      eax,eax
       je        short M03_L39
M03_L38:
       jmp       near ptr M03_L13
M03_L39:
       mov       rcx,[rbp-1B0]
       call      qword ptr [7FFC6282E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       short M03_L38
M03_L40:
       mov       rcx,287B5C64C40
       cmp       r10,rcx
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
       jmp       near ptr M03_L16
M03_L41:
       cmp       r15,r9
       sete      al
       movzx     eax,al
       jmp       near ptr M03_L17
M03_L42:
       mov       edx,1
       jmp       near ptr M03_L18
M03_L43:
       xor       edx,edx
       jmp       near ptr M03_L18
M03_L44:
       mov       r8,[rbp-1C8]
M03_L45:
       mov       r8,[r8+10]
       test      r8,r8
       jne       near ptr M03_L15
M03_L46:
       xor       edx,edx
       mov       [rbp-70],rdx
       mov       rdx,287B5C64C40
       mov       [rbp-68],rdx
       mov       [rbp-60],r15
       xor       edx,edx
       mov       [rbp-58],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-68]
       vmovdqu   xmmword ptr [rbp-158],xmm0
       mov       rdx,[rbp-58]
       mov       [rbp-148],rdx
       lea       rdx,[rbp-68]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       dword ptr [rsp+30],1
       lea       r8,[rbp-70]
       mov       [rsp+38],r8
       mov       [rsp+20],rax
       lea       r8,[rbp-158]
       mov       r9d,r13d
       shl       r9,20
       or        r9,1
       mov       rdx,[rbp-1A0]
       mov       rcx,r14
       call      qword ptr [7FFC63236718]; System.Collections.Concurrent.ConcurrentDictionary`2[[LinqToDB.Internal.Mapping.MappingAttributesCache+CacheKey, linq2db],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<CacheKey,System.__Canon>, CacheKey, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M03_L19
M03_L47:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       r14d,eax
       jmp       near ptr M03_L27
M03_L48:
       mov       rcx,24736C006A0
       mov       r14,[rcx]
       mov       r12,offset MT_System.RuntimeType
       cmp       [r15],r12
       jne       near ptr M03_L130
       mov       rcx,r15
       call      00007FFCC2453FE0
       test      eax,eax
       je        near ptr M03_L95
M03_L49:
       mov       rcx,[r14+8]
       mov       edx,eax
       and       edx,[r14+10]
       cmp       edx,[rcx+8]
       jae       near ptr M03_L195
       mov       r8,[rcx+rdx*8+10]
       mov       [rbp-1D8],r8
       test      r8,r8
       je        near ptr M03_L132
       cmp       [r8+18],eax
       jne       near ptr M03_L132
       mov       rcx,[r8+8]
       cmp       [rcx],r12
       jne       near ptr M03_L131
       cmp       r15,rcx
       jne       near ptr M03_L132
M03_L50:
       mov       r8,[rbp-1D8]
       mov       r14,[r8+10]
M03_L51:
       mov       ecx,[r14+8]
       cmp       ecx,1
       jne       near ptr M03_L133
       test      ecx,ecx
       je        near ptr M03_L195
       mov       r14,[r14+10]
       mov       [rbp-0C8],r13
       mov       r13,[rbp-0C8]
       test      r13,r13
       je        near ptr M03_L135
       mov       rcx,offset MT_System.Linq.Expressions.TypedParameterExpression
       cmp       [r13],rcx
       jne       near ptr M03_L96
       mov       eax,26
M03_L52:
       cmp       eax,17
       je        near ptr M03_L97
       cmp       eax,37
       je        near ptr M03_L136
M03_L53:
       mov       rcx,offset MT_System.Reflection.RuntimeParameterInfo
       cmp       [r14],rcx
       jne       near ptr M03_L145
       cmp       qword ptr [r14+8],0
       je        near ptr M03_L142
M03_L54:
       mov       r13,[r14+8]
M03_L55:
       mov       r14,r13
       cmp       [r14],r12
       jne       near ptr M03_L146
       mov       rcx,[r14+18]
       call      00007FFC634D1050
       movzx     ecx,al
       cmp       ecx,10
       je        near ptr M03_L147
M03_L56:
       mov       rcx,287B5C51440
       cmp       r14,rcx
       je        short M03_L62
       cmp       [r14],r12
       jne       near ptr M03_L155
       mov       r13,r14
M03_L57:
       cmp       [r13],r12
       jne       near ptr M03_L152
       mov       rcx,[r13+18]
       call      00007FFC634D1050
       movzx     ecx,al
       cmp       ecx,1D
       ja        short M03_L58
       mov       eax,1FEF7FFF
       bt        eax,ecx
       jae       near ptr M03_L151
M03_L58:
       cmp       ecx,10
       sete      al
       movzx     eax,al
M03_L59:
       test      eax,eax
       jne       near ptr M03_L148
       cmp       [r13],r12
       jne       near ptr M03_L153
M03_L60:
       test      r13,r13
       je        near ptr M03_L154
       mov       rcx,r13
       call      00007FFCC2489400
M03_L61:
       test      eax,eax
       jne       near ptr M03_L156
M03_L62:
       mov       rcx,[rbp-0C8]
       mov       rax,offset MT_System.Linq.Expressions.ConstantExpression
       cmp       [rcx],rax
       jne       near ptr M03_L101
       mov       rcx,[rbp-0C8]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        near ptr M03_L159
       call      qword ptr [7FFC6282C9A8]; System.Object.GetType()
       mov       r12,rax
M03_L63:
       test      r14,r14
       je        near ptr M03_L160
       mov       rcx,r14
       mov       rdx,r12
       mov       rax,[r14]
       mov       rax,[rax+0A0]
       call      qword ptr [rax+10]
       test      eax,eax
       je        near ptr M03_L160
M03_L64:
       mov       r14,[rbp-0C8]
       mov       rcx,offset MT_System.Linq.Expressions.MethodCallExpression1
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M03_L65:
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r13
       test      rdx,rdx
       je        near ptr M03_L163
M03_L66:
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TempFileDataContext
       cmp       [rsi],rcx
       jne       near ptr M03_L164
       mov       r14,[rsi+28]
       mov       r15,[rsi+8]
M03_L67:
       mov       rax,[r15+28]
       test      rax,rax
       je        near ptr M03_L165
M03_L68:
       mov       rsi,[rax+58]
       mov       rcx,24736C002E0
       mov       r15,[rcx]
       mov       rcx,offset MT_LinqToDB.Internal.DataProvider.SQLite.SQLiteMappingSchema+MicrosoftMappingSchema
       cmp       [r14],rcx
       jne       near ptr M03_L167
       mov       r13d,[r14+54]
       cmp       byte ptr [r14+50],0
       je        near ptr M03_L166
M03_L69:
       mov       rcx,24736C002D8
       test      rsi,rsi
       cmove     rsi,[rcx]
       mov       rcx,24736C00388
       mov       r12,[rcx]
       mov       rcx,287B5C645E0
       mov       [rbp-250],rcx
       test      r12,r12
       je        near ptr M03_L168
M03_L70:
       cmp       byte ptr [r15+30],0
       jne       near ptr M03_L169
       xor       ecx,ecx
       mov       [rbp-0D0],rcx
       mov       rcx,[r15+20]
       mov       rcx,[rcx+8]
       mov       rdx,offset MT_LinqToDB.Internal.Cache.SystemClock
       cmp       [rcx],rdx
       jne       near ptr M03_L170
       call      qword ptr [7FFC62D57B88]; System.DateTime.get_UtcNow()
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       xor       ecx,ecx
       mov       [rbp-0E0],ecx
       mov       [rbp-0D8],rdx
M03_L71:
       xor       eax,eax
       mov       [rbp-0E4],eax
       mov       rcx,[r15+8]
       mov       rdx,[rbp-250]
       mov       [rbp-0F8],rdx
       mov       [rbp-0F0],r13d
       mov       rdx,[rcx+8]
       mov       [rbp-1F0],rdx
       mov       r8,[rdx+8]
       mov       [rbp-1F8],r8
       test      r8,r8
       jne       near ptr M03_L176
       xor       ecx,ecx
       mov       [rbp-108],rcx
       lea       rcx,[rbp-0F8]
       cmp       qword ptr [rbp-108],0
       jne       short M03_L72
       mov       rcx,[rbp-0F8]
       mov       [rbp-108],rcx
       lea       rcx,[rbp-108]
       cmp       qword ptr [rbp-108],0
       je        near ptr M03_L171
M03_L72:
       mov       r8,[rcx]
       mov       [rbp-210],r8
       mov       rcx,offset MT_System.RuntimeType
       mov       r10,rcx
       cmp       [r8],r10
       jne       near ptr M03_L172
       mov       rcx,r8
       call      00007FFCC2453FE0
       test      eax,eax
       je        near ptr M03_L102
M03_L73:
       mov       r8d,eax
M03_L74:
       mov       ecx,[rbp-0F0]
       imul      edx,r8d,0C2B2AE3D
       add       edx,1A701AA7
       rol       edx,11
       imul      edx,27D4EB2F
       imul      ecx,0C2B2AE3D
       add       ecx,edx
       rol       ecx,11
       imul      ecx,27D4EB2F
       mov       edx,ecx
       shr       edx,0F
       xor       edx,ecx
       imul      ecx,edx,85EBCA77
       mov       edx,ecx
       shr       edx,0D
       xor       edx,ecx
       imul      ecx,edx,0C2B2AE3D
       mov       eax,ecx
       shr       eax,10
       xor       eax,ecx
       xor       ecx,ecx
       mov       [rbp-108],rcx
       mov       [rbp-100],eax
       mov       r8,[rbp-1F0]
       mov       rcx,[r8+10]
       mov       edx,eax
       imul      rdx,[r8+28]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rdx,r10
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M03_L195
       mov       edx,edx
       mov       r8,[rcx+rdx*8+10]
       test      r8,r8
       je        near ptr M03_L88
M03_L75:
       cmp       eax,[r8+18]
       jne       near ptr M03_L173
       mov       rcx,[r8+20]
       mov       [rbp-208],r8
       mov       r10d,[r8+28]
       mov       [rbp-13C],r10d
       mov       rdx,[rbp-0F8]
       mov       r9d,[rbp-0F0]
       mov       [rbp-140],r9d
       test      rcx,rcx
       je        near ptr M03_L104
       test      rdx,rdx
       je        near ptr M03_L174
       mov       r11,offset MT_System.RuntimeType
       cmp       [rcx],r11
       je        near ptr M03_L103
       mov       r11,[rcx]
       mov       r11,[r11+40]
       call      qword ptr [r11+10]
M03_L76:
       test      eax,eax
       je        near ptr M03_L174
M03_L77:
       mov       r10d,[rbp-13C]
       cmp       r10d,[rbp-140]
       jne       near ptr M03_L174
       mov       r8,[rbp-208]
       mov       rax,[r8+8]
M03_L78:
       cmp       byte ptr [rax+51],0
       jne       near ptr M03_L175
       mov       [rbp-1E8],rax
       lea       rdx,[rax+58]
       movzx     ecx,byte ptr [rdx]
       vmovups   xmm0,[rdx+8]
       vmovups   [rbp-128],xmm0
       test      ecx,ecx
       jne       near ptr M03_L180
M03_L79:
       mov       rax,[rbp-1E8]
       movzx     ecx,byte ptr [rax+80]
       mov       rdx,[rax+88]
       test      ecx,ecx
       je        short M03_L80
       mov       rcx,[rax+0B8]
       mov       r8,[rbp-0D8]
       sub       r8,rcx
       cmp       r8,rdx
       jge       near ptr M03_L181
M03_L80:
       mov       [rbp-1E8],rax
       mov       rcx,rax
       call      qword ptr [7FFC6323CAF8]; LinqToDB.Internal.Cache.CacheEntry`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].CheckForExpiredTokens()
       test      eax,eax
       jne       near ptr M03_L182
M03_L81:
       mov       dword ptr [rbp-0E4],1
       vmovups   xmm0,[rbp-0E0]
       mov       rdx,[rbp-1E8]
       vmovups   [rdx+0B0],xmm0
       mov       [rbp-1E8],rdx
       mov       rcx,[rdx+40]
       mov       [rbp-0D0],rcx
       mov       rcx,24736C012E8
       mov       r8,[rcx]
       mov       [rbp-220],r8
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M03_L184
       mov       rcx,[rcx+240]
       mov       r10,[rcx+20]
       test      r10,r10
       je        near ptr M03_L184
M03_L82:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M03_L83
       call      qword ptr [7FFC62BB4A98]; System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M03_L83:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        near ptr M03_L185
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Threading.AsyncLocalValueMap+TwoElementAsyncLocalValueMap
       cmp       [rcx],r11
       jne       near ptr M03_L186
       mov       r8,[rbp-220]
       cmp       r8,[rcx+8]
       jne       near ptr M03_L105
       mov       rcx,[rcx+10]
       mov       [rbp-138],rcx
M03_L84:
       mov       r8,[rbp-138]
M03_L85:
       xor       ecx,ecx
       mov       [rbp-138],rcx
       mov       r10,r8
       test      r10,r10
       je        short M03_L86
       mov       rcx,offset MT_LinqToDB.Internal.Cache.CacheEntryStack<System.ValueTuple<System.Type, System.Int32>, LinqToDB.Mapping.EntityDescriptor>
       cmp       [r10],rcx
       jne       near ptr M03_L187
M03_L86:
       test      r10,r10
       je        near ptr M03_L188
M03_L87:
       mov       rdx,[r10+8]
       mov       rcx,[rbp-1E8]
       cmp       [rcx],ecx
       call      qword ptr [7FFC63234B58]; LinqToDB.Internal.Cache.CacheEntry`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].PropagateOptions(LinqToDB.Internal.Cache.CacheEntry`2<System.ValueTuple`2<System.__Canon,Int32>,System.__Canon>)
M03_L88:
       mov       rcx,[r15+20]
       mov       rcx,[rcx+18]
       mov       rax,[r15+40]
       mov       rdx,[rbp-0D8]
       sub       rdx,rax
       cmp       rcx,rdx
       jl        near ptr M03_L189
M03_L89:
       mov       edx,[rbp-0E4]
       test      edx,edx
       je        near ptr M03_L191
M03_L90:
       mov       rsi,[rbp-0D0]
       xor       ecx,ecx
       mov       [rbp-0D0],rcx
       lea       rdx,[rsi+0A8]
       cmp       [rdx],dl
       lea       rcx,[rdi+50]
       cmp       [rcx],cl
       mov       r8d,28
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       esi,[rsi+98]
       cmp       [rdi+48],esi
       jne       near ptr M03_L192
M03_L91:
       mov       rdx,rdi
       mov       rcx,7FFC6367F968
       call      qword ptr [7FFC63466B68]; System.Linq.Enumerable.Count[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       esi,eax
       lea       ecx,[rsi+1]
       cmp       ecx,0A
       jb        near ptr M03_L193
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+34],1000000
       mov       [rax+38],esi
M03_L92:
       cmp       [rax],al
       mov       [rbp-48],rax
       xor       ecx,ecx
       mov       [rbp-40],ecx
       test      byte ptr [rbp-40],4
       jne       near ptr M03_L194
       mov       rcx,[rbp-48]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L194
M03_L93:
       mov       rdx,[rbp-48]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L197
M03_L94:
       mov       rdx,[rbp-48]
       mov       edx,[rdx+38]
       mov       rax,[rbx+90]
       mov       [rax+38],edx
       jmp       near ptr M03_L198
M03_L95:
       mov       rcx,r15
       call      qword ptr [7FFC6282E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M03_L49
M03_L96:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M03_L52
M03_L97:
       mov       rcx,r13
       test      rcx,rcx
       je        short M03_L98
       mov       rdx,offset MT_System.Linq.Expressions.PropertyExpression
       cmp       [rcx],rdx
       jne       near ptr M03_L137
M03_L98:
       mov       rax,offset MT_System.Linq.Expressions.PropertyExpression
       cmp       [rcx],rax
       jne       near ptr M03_L138
       mov       rdx,[rcx+10]
M03_L99:
       mov       rcx,rdx
       test      rcx,rcx
       je        short M03_L100
       mov       rax,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rcx],rax
       jne       near ptr M03_L139
M03_L100:
       test      rcx,rcx
       je        near ptr M03_L53
       mov       rax,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rcx],rax
       jne       near ptr M03_L140
       cmp       qword ptr [rcx+18],0
       jne       near ptr M03_L53
       jmp       near ptr M03_L141
M03_L101:
       mov       rcx,[rbp-0C8]
       mov       rax,[rbp-0C8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r12,rax
       jmp       near ptr M03_L63
M03_L102:
       mov       rcx,[rbp-210]
       call      qword ptr [7FFC6282E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M03_L73
M03_L103:
       cmp       rdx,rcx
       sete      dl
       movzx     edx,dl
       mov       eax,edx
       jmp       near ptr M03_L76
M03_L104:
       test      rdx,rdx
       jne       near ptr M03_L174
       jmp       near ptr M03_L77
M03_L105:
       cmp       r8,[rcx+18]
       jne       short M03_L106
       mov       r8,[rcx+20]
       mov       [rbp-138],r8
       jmp       near ptr M03_L84
M03_L106:
       xor       r8d,r8d
       mov       [rbp-138],r8
       jmp       near ptr M03_L84
M03_L107:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC63235A28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L108:
       mov       rcx,rsi
       mov       r11,7FFC63E02AD0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M03_L01
M03_L109:
       mov       rcx,287B5C645E0
       mov       rax,[7FFC6276A1E0]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M03_L04
       mov       rcx,287B5C645E0
       mov       rax,[7FFC6276A1E8]
       call      qword ptr [rax+18]
       mov       rcx,287B5C5E418
       cmp       rax,rcx
       jne       near ptr M03_L04
       mov       rcx,287B5C645E0
       mov       rax,[7FFC6276A1E8]
       call      qword ptr [rax+28]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M03_L195
       mov       rcx,[rax+10]
       jmp       near ptr M03_L05
M03_L110:
       lea       rcx,[rbp-50]
       call      qword ptr [7FFC6323C258]
       jmp       near ptr M03_L24
M03_L111:
       mov       ecx,0B80
       mov       rdx,7FFC62B2E448
       call      qword ptr [7FFC62A47798]
       mov       rcx,rax
       call      qword ptr [7FFC62D57ED0]
       int       3
M03_L112:
       mov       rdx,287B5C64C40
       mov       [rbp-88],rdx
       mov       [rbp-80],r13
       xor       edx,edx
       mov       [rbp-78],rdx
       lea       rdx,[rbp-88]
       mov       r11,7FFC63E02AE0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M03_L14
M03_L113:
       mov       r8,[rbp-1C8]
       jmp       near ptr M03_L45
M03_L114:
       mov       rdx,[rax+10]
       mov       ecx,r13d
       imul      rcx,[rax+28]
       shr       rcx,20
       inc       rcx
       mov       r11d,[rdx+8]
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M03_L195
       mov       ecx,ecx
       mov       r10,[rdx+rcx*8+10]
       test      r10,r10
       je        near ptr M03_L46
M03_L115:
       cmp       r13d,[r10+18]
       jne       short M03_L116
       mov       rdx,287B5C64C40
       mov       [rbp-68],rdx
       mov       [rbp-60],r15
       xor       edx,edx
       mov       [rbp-58],rdx
       mov       [rbp-1C0],r10
       vmovdqu   xmm0,xmmword ptr [r10+20]
       vmovdqu   xmmword ptr [rbp-158],xmm0
       mov       rdx,[r10+30]
       mov       [rbp-148],rdx
       lea       rdx,[rbp-158]
       lea       r8,[rbp-68]
       mov       rcx,[rbp-1B8]
       mov       r11,7FFC63E02AE8
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rbp-1C0]
       jne       short M03_L117
M03_L116:
       mov       r10,[r10+10]
       test      r10,r10
       jne       short M03_L115
       jmp       near ptr M03_L46
M03_L117:
       mov       rdx,[r10+8]
       mov       [rbp-70],rdx
       jmp       near ptr M03_L19
M03_L118:
       cmp       dword ptr [r14+8],0
       jbe       near ptr M03_L195
       mov       r13,[r14+10]
       jmp       near ptr M03_L21
M03_L119:
       movzx     r14d,byte ptr [r13+10]
       jmp       near ptr M03_L23
M03_L120:
       mov       rcx,r15
       mov       rdx,287B5C55F30
       call      qword ptr [7FFC6276A608]; System.RuntimeType.IsSubclassOf(System.Type)
       jmp       near ptr M03_L22
M03_L121:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+70]
       call      qword ptr [rax+30]
       jmp       near ptr M03_L22
M03_L122:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        near ptr M03_L23
M03_L123:
       mov       r14d,1
       jmp       near ptr M03_L23
M03_L124:
       mov       rcx,rsi
       mov       r11,7FFC63E02AD8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M03_L25
M03_L125:
       mov       ecx,2C61
       mov       rdx,7FFC62ECCC40
       call      qword ptr [7FFC62A47798]
       mov       rcx,rax
       call      qword ptr [7FFC62DDEF10]
       int       3
M03_L126:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+58]
       call      qword ptr [rax+28]
       jmp       near ptr M03_L26
M03_L127:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+58]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M03_L128
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,287B5C62968
       call      qword ptr [7FFC638FD020]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFC638FD038]
       mov       rdx,rax
       mov       rcx,r13
       mov       r8,287B5C54D10
       call      qword ptr [7FFC62BB7018]
       jmp       short M03_L129
M03_L128:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,287B5C629C0
       call      qword ptr [7FFC638FD020]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFC638FD038]
       mov       rdx,rax
       mov       rcx,r13
       mov       r8,287B5C54D10
       call      qword ptr [7FFC62BB7018]
M03_L129:
       mov       rcx,r13
       call      CORINFO_HELP_THROW
       int       3
M03_L130:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L49
M03_L131:
       mov       rdx,r15
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M03_L50
M03_L132:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       [rbp-1D0],rax
       mov       rcx,r15
       mov       rdx,[r15]
       mov       rdx,[rdx+50]
       call      qword ptr [rdx]
       test      eax,eax
       jne       short M03_L134
       mov       rcx,r14
       mov       rdx,r15
       mov       r8,[rbp-1D0]
       call      qword ptr [7FFC62FF7D08]; System.Dynamic.Utils.CacheDict`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon)
       mov       r14,[rbp-1D0]
       jmp       near ptr M03_L51
M03_L133:
       mov       ecx,2C61
       mov       rdx,7FFC62ECCC40
       call      qword ptr [7FFC62A47798]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFC638FE658]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L134:
       mov       r14,[rbp-1D0]
       jmp       near ptr M03_L51
M03_L135:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,2E81
       mov       rdx,7FFC62ECCC40
       call      qword ptr [7FFC62A47798]
       mov       rcx,rax
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC638FC3D8]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFC62BB6820]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M03_L136:
       mov       rdx,r13
       mov       rcx,offset MT_System.Linq.Expressions.IndexExpression
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       cmp       qword ptr [rax+18],0
       je        near ptr M03_L53
       mov       rcx,[rax+18]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       near ptr M03_L53
       jmp       short M03_L141
M03_L137:
       mov       rdx,r13
       mov       rcx,offset MT_System.Linq.Expressions.MemberExpression
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M03_L98
M03_L138:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdx,rax
       jmp       near ptr M03_L99
M03_L139:
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M03_L100
M03_L140:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       near ptr M03_L53
M03_L141:
       mov       ecx,2E81
       mov       rdx,7FFC62ECCC40
       call      qword ptr [7FFC62A47798]
       mov       rcx,rax
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC638FC3F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L142:
       cmp       dword ptr [r14+2C],0FFFFFFFF
       jne       short M03_L143
       mov       rcx,[r14+30]
       mov       rdx,[rcx+18]
       jmp       short M03_L144
M03_L143:
       mov       rdx,[r14+30]
       mov       rcx,[rdx+8]
       mov       edx,[r14+2C]
       cmp       edx,[rcx+8]
       jae       near ptr M03_L195
       mov       rdx,[rcx+rdx*8+10]
M03_L144:
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L54
M03_L145:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M03_L55
M03_L146:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax+18]
       test      eax,eax
       je        near ptr M03_L56
M03_L147:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M03_L56
M03_L148:
       cmp       [r13],r12
       jne       short M03_L149
       mov       rcx,r13
       call      qword ptr [7FFC6282DB30]; System.RuntimeTypeHandle.GetElementType(System.RuntimeType)
       jmp       short M03_L150
M03_L149:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
M03_L150:
       mov       r13,rax
       jmp       near ptr M03_L57
M03_L151:
       mov       eax,1
       jmp       near ptr M03_L59
M03_L152:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       jmp       near ptr M03_L59
M03_L153:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       r13,rax
       jmp       near ptr M03_L60
M03_L154:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFC62DDF318]
       mov       r8,rax
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFC62DDF330]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M03_L155:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       jmp       near ptr M03_L61
M03_L156:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       short M03_L157
       mov       rcx,287B5C54D10
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC638FD008]
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,287B5C623A0
       call      qword ptr [7FFC638FD020]
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FFC638FD038]
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8,r15
       call      qword ptr [7FFC62BB7018]
       jmp       short M03_L158
M03_L157:
       mov       rcx,287B5C54D10
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC638FD008]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,287B5C623F0
       call      qword ptr [7FFC638FD020]
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FFC638FD038]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rdi
       call      qword ptr [7FFC62BB7018]
       mov       rdi,rsi
M03_L158:
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L159:
       mov       r12,287B5C519B8
       jmp       near ptr M03_L63
M03_L160:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       jne       short M03_L161
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       jne       short M03_L161
       mov       rcx,r14
       mov       rdx,r12
       mov       rax,[r14]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+20]
       test      eax,eax
       jne       near ptr M03_L64
M03_L161:
       lea       rdx,[rbp-0C8]
       mov       rcx,r14
       call      qword ptr [7FFC638FF348]
       test      eax,eax
       jne       near ptr M03_L64
       mov       rcx,[rbp-0C8]
       mov       rax,[rbp-0C8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdi,rax
       mov       ecx,2E81
       mov       rdx,7FFC62ECCC40
       call      qword ptr [7FFC62A47798]
       mov       r9,rax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       r8,r15
       mov       rdx,r14
       call      qword ptr [7FFC638FF8A0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L162:
       xor       r13d,r13d
       jmp       near ptr M03_L65
M03_L163:
       mov       rcx,offset MT_System.Linq.Expressions.ConstantExpression
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       jmp       near ptr M03_L66
M03_L164:
       mov       rcx,rsi
       mov       r11,7FFC63E02AF0
       call      qword ptr [r11]
       mov       r14,rax
       mov       rcx,rsi
       mov       r11,7FFC63E02AF8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M03_L67
M03_L165:
       mov       rcx,24736C001A8
       mov       rsi,[rcx]
       lea       rcx,[r15+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M03_L68
M03_L166:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC6300E830]; Precode of LinqToDB.Internal.Mapping.LockedMappingSchema.GenerateID()
       mov       r13d,eax
       mov       byte ptr [r14+50],1
       mov       [r14+54],r13d
       jmp       near ptr M03_L69
M03_L167:
       mov       rcx,r14
       mov       r11,7FFC63E02B08
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M03_L69
M03_L168:
       mov       rcx,offset MT_System.Func<LinqToDB.Internal.Cache.ICacheEntry<System.ValueTuple<System.Type, System.Int32>, LinqToDB.Mapping.EntityDescriptor>, System.ValueTuple<LinqToDB.Mapping.MappingSchema, System.Action<LinqToDB.Mapping.MappingSchema, LinqToDB.Mapping.IEntityChangeDescriptor>>, LinqToDB.Mapping.EntityDescriptor>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,24736C002E8
       mov       rdx,[rdx]
       mov       rcx,r12
       mov       r8,offset LinqToDB.Mapping.MappingSchema+<>c.<GetEntityDescriptor>b__99_0(LinqToDB.Internal.Cache.ICacheEntry`2<System.ValueTuple`2<System.Type,Int32>,LinqToDB.Mapping.EntityDescriptor>, System.ValueTuple`2<LinqToDB.Mapping.MappingSchema,System.Action`2<LinqToDB.Mapping.MappingSchema,LinqToDB.Mapping.IEntityChangeDescriptor>>)
       call      qword ptr [7FFC62826BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,24736C00388
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L70
M03_L169:
       mov       rcx,287B5C64630
       call      qword ptr [7FFC638FC498]
       int       3
M03_L170:
       lea       rdx,[rbp-0E0]
       mov       r11,7FFC63E02B38
       call      qword ptr [r11]
       jmp       near ptr M03_L71
M03_L171:
       xor       r8d,r8d
       jmp       near ptr M03_L74
M03_L172:
       mov       rcx,r8
       mov       r8,[r8]
       mov       r8,[r8+40]
       call      qword ptr [r8+18]
       mov       r8d,eax
       jmp       near ptr M03_L74
M03_L173:
       mov       [rbp-208],r8
M03_L174:
       mov       r8,[rbp-208]
       mov       r8,[r8+10]
       test      r8,r8
       mov       eax,[rbp-100]
       jne       near ptr M03_L75
       jmp       near ptr M03_L88
M03_L175:
       mov       [rbp-1E8],rax
       jmp       near ptr M03_L182
M03_L176:
       vmovdqu   xmm0,xmmword ptr [rbp-0F8]
       vmovdqu   xmmword ptr [rbp-118],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-118]
       vmovdqu   xmmword ptr [rbp-168],xmm0
       lea       rdx,[rbp-168]
       mov       rcx,r8
       mov       r11,7FFC63E02B48
       call      qword ptr [r11]
       mov       [rbp-0FC],eax
       mov       r8,[rbp-1F0]
       mov       rdx,[r8+10]
       mov       ecx,eax
       imul      rcx,[r8+28]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       imul      r8,rcx
       shr       r8,20
       cmp       r8d,[rdx+8]
       jae       near ptr M03_L195
       mov       r8d,r8d
       mov       r10,[rdx+r8*8+10]
       test      r10,r10
       je        near ptr M03_L88
M03_L177:
       cmp       eax,[r10+18]
       jne       short M03_L178
       mov       [rbp-200],r10
       vmovdqu   xmm0,xmmword ptr [r10+20]
       vmovdqu   xmmword ptr [rbp-168],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-0F8]
       vmovdqu   xmmword ptr [rbp-178],xmm0
       lea       r8,[rbp-178]
       lea       rdx,[rbp-168]
       mov       rcx,[rbp-1F8]
       mov       r11,7FFC63E02B40
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rbp-200]
       jne       short M03_L179
M03_L178:
       mov       r10,[r10+10]
       test      r10,r10
       mov       eax,[rbp-0FC]
       jne       short M03_L177
       jmp       near ptr M03_L88
M03_L179:
       mov       rax,[r10+8]
       jmp       near ptr M03_L78
M03_L180:
       vmovups   xmm0,[rbp-0E0]
       vmovups   [rbp-188],xmm0
       lea       rdx,[rbp-188]
       lea       rcx,[rbp-128]
       call      qword ptr [7FFC6323CB10]
       test      eax,eax
       je        near ptr M03_L79
       mov       rax,[rbp-1E8]
M03_L181:
       mov       [rbp-1E8],rax
       mov       rcx,rax
       mov       edx,3
       call      qword ptr [7FFC6323C9D8]
M03_L182:
       mov       rax,[rbp-1E8]
       cmp       dword ptr [rax+4C],2
       je        short M03_L183
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFC63234AF8]
       jmp       near ptr M03_L88
M03_L183:
       mov       [rbp-1E8],rax
       jmp       near ptr M03_L81
M03_L184:
       mov       ecx,4
       call      qword ptr [7FFC638F53C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M03_L82
M03_L185:
       xor       r8d,r8d
       jmp       near ptr M03_L85
M03_L186:
       lea       r8,[rbp-138]
       mov       rdx,[rbp-220]
       mov       r11,7FFC63E02B50
       call      qword ptr [r11]
       jmp       near ptr M03_L84
M03_L187:
       mov       rdx,r8
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L188:
       mov       rcx,24736C012F0
       mov       r8,[rcx]
       mov       r10,r8
       mov       [rbp-218],r10
       mov       rcx,24736C012E8
       mov       rcx,[rcx]
       mov       rdx,r10
       call      qword ptr [7FFC63234E70]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       r10,[rbp-218]
       jmp       near ptr M03_L87
M03_L189:
       mov       ecx,[rbp-0E0]
       mov       [r15+38],ecx
       mov       rcx,[rbp-0D8]
       mov       [r15+40],rcx
       mov       rcx,24720C00C00
       mov       rax,[rcx]
       mov       [rbp-228],rax
       mov       rcx,offset MT_LinqToDB.Internal.Cache.MemoryCache<System.ValueTuple<System.Type, System.Int32>, LinqToDB.Mapping.EntityDescriptor>+<>c
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24736C038C0
       mov       rax,[rcx]
       test      rax,rax
       mov       [rbp-230],rax
       jne       near ptr M03_L190
       mov       rcx,offset MT_System.Action<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-238],rax
       mov       rcx,offset MT_LinqToDB.Internal.Cache.MemoryCache<System.ValueTuple<System.Type, System.Int32>, LinqToDB.Mapping.EntityDescriptor>+<>c
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,24736C038B8
       mov       rdx,[rdx]
       mov       rcx,[rbp-238]
       mov       r8,7FFC63230C30
       call      qword ptr [7FFC62826BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,offset MT_LinqToDB.Internal.Cache.MemoryCache<System.ValueTuple<System.Type, System.Int32>, LinqToDB.Mapping.EntityDescriptor>+<>c
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24736C038C0
       mov       rdx,[rbp-238]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-238]
       mov       [rbp-230],rax
M03_L190:
       mov       rcx,offset MT_System.Threading.Tasks.TaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,24736C038F0
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rbp-230]
       mov       r8,r15
       mov       rcx,[rbp-228]
       xor       r9d,r9d
       mov       dword ptr [rsp+20],8
       call      qword ptr [7FFC63234CC0]
       jmp       near ptr M03_L89
M03_L191:
       mov       rdx,287B5C645E0
       mov       [rbp-168],rdx
       mov       [rbp-160],r13d
       lea       rdx,[rbp-168]
       mov       rcx,r15
       mov       r11,7FFC63E02B20
       call      qword ptr [r11]
       mov       [rbp-1E0],rax
       mov       [rbp-198],r14
       mov       [rbp-190],rsi
       lea       r8,[rbp-198]
       mov       rdx,[rbp-1E0]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-1E0]
       mov       rdx,[rbp-0D0]
       mov       r11,7FFC63E02B28
       call      qword ptr [r11]
       nop
       mov       rcx,[rbp-1E0]
       mov       r11,7FFC63E02B30
       call      qword ptr [r11]
       jmp       near ptr M03_L90
M03_L192:
       mov       rdx,[rdi+8]
       mov       r8d,esi
       mov       rcx,offset MT_LinqToDB.Internal.Linq.Table<DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TestDbEntity>
       call      qword ptr [7FFC63526568]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+48],esi
       jmp       near ptr M03_L91
M03_L193:
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,24736C03B30
       mov       rcx,[rcx]
       lea       edx,[rsi+1]
       cmp       edx,[rcx+8]
       jae       short M03_L195
       inc       esi
       mov       edx,esi
       mov       rax,[rcx+rdx*8+10]
       jmp       near ptr M03_L92
M03_L194:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-40]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFC63ED60B8]
       mov       rdx,rax
       lea       rcx,[rbp-48]
       call      qword ptr [7FFC63ED60D0]
       jmp       short M03_L199
M03_L195:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L196:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L93
M03_L197:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFC63ADF8D0]
       jmp       near ptr M03_L94
M03_L198:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L200
       mov       rdx,24720C00C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L199:
       nop
       add       rsp,258
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L200:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFC63ADF918]
       jmp       short M03_L199
       sub       rsp,48
       vzeroupper
       cmp       qword ptr [rbp-1E0],0
       je        short M03_L201
       mov       rcx,[rbp-1E0]
       mov       r11,7FFC63E02B30
       call      qword ptr [r11]
M03_L201:
       nop
       add       rsp,48
       ret
       sub       rsp,48
       vzeroupper
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFC635C7750]
       lea       rax,[M03_L199]
       add       rsp,48
       ret
; Total bytes of code 7525
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFCC22C1D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.HashCode.Combine[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark.GetRecordCountWithPredicateAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFC62A6FDE0]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFC6354F108]; DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<GetRecordCountWithPredicateAsync>d__10.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFC641E7858]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFC6391E958]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFC63DDDE90]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFC641E7858]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62DDEFD0]; System.Threading.Tasks.Task.GetAwaiter()
       mov       [rbp-8],rax
       lea       rcx,[rbp-8]
       call      qword ptr [7FFC62DDEFE8]; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 53
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFCC22A9030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.HashCode.Combine[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFCC22A9038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFCC22AAEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFCC22A8FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<GetRecordCountWithPredicateAsync>d__10.MoveNext()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,188
       vzeroupper
       lea       rbp,[rsp+1C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0E0],ymm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L161
       mov       rsi,[rbx+1A8]
       test      rsi,rsi
       je        near ptr M03_L87
       mov       rdi,20D7C0445E0
       mov       r14,20D7C0445E0
M03_L00:
       mov       rax,offset MT_System.RuntimeType
       cmp       [r14],rax
       jne       near ptr M03_L90
       mov       rax,[r14+18]
       mov       rcx,rax
       call      00007FFC63491170
       movzx     ecx,al
       cmp       ecx,1D
       ja        short M03_L01
       mov       eax,1FEF7FFF
       bt        eax,ecx
       jae       near ptr M03_L89
M03_L01:
       cmp       ecx,10
       sete      r15b
       movzx     r15d,r15b
M03_L02:
       test      r15d,r15d
       jne       near ptr M03_L88
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r14],rcx
       jne       near ptr M03_L91
M03_L03:
       test      r14,r14
       je        near ptr M03_L92
       mov       rcx,r14
       call      00007FFCC2489400
       test      eax,eax
       jne       near ptr M03_L93
       mov       rcx,20D7C0445E0
       mov       rax,[7FFC6278A1D8]
       call      qword ptr [rax+20]
       test      eax,eax
       jne       near ptr M03_L130
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TestDbEntity
       call      00007FFC63491170
       movzx     ecx,al
       mov       rax,20D7C0445E0
       cmp       ecx,10
       sete      r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       near ptr M03_L96
M03_L04:
       mov       rcx,rdi
       mov       r8d,r14d
       mov       rdx,20D7C04C628
       call      qword ptr [7FFC62E5F348]; System.Linq.Expressions.ParameterExpression.Make(System.Type, System.String, Boolean)
       mov       rdi,rax
       mov       rcx,7FFC62B61458
       call      qword ptr [7FFC62E5CC48]; System.RuntimeMethodInfoStub.FromPtr(IntPtr)
       mov       r14,rax
       test      r14,r14
       je        near ptr M03_L97
       mov       rcx,offset MT_System.RuntimeMethodInfoStub
       cmp       [r14],rcx
       jne       near ptr M03_L07
       mov       rdx,[r14+50]
M03_L05:
       xor       ecx,ecx
       call      qword ptr [7FFC6284FC48]; System.RuntimeType.GetMethodBase(System.RuntimeType, System.RuntimeMethodHandleInternal)
       mov       r15,rax
       test      r15,r15
       je        near ptr M03_L98
       mov       r14,[r15]
       mov       r13,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       r14,r13
       jne       near ptr M03_L100
       mov       rcx,[r15+8]
       cmp       byte ptr [rcx+9C],0
       jne       near ptr M03_L99
       mov       r13,[r15+38]
M03_L06:
       test      r13,r13
       je        short M03_L11
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M03_L102
       mov       rcx,[r13+18]
       test      cl,2
       jne       near ptr M03_L101
       test      dword ptr [rcx],80000000
       jne       short M03_L08
       test      byte ptr [rcx],30
       setne     al
       movzx     eax,al
       jmp       short M03_L09
M03_L07:
       mov       rcx,r14
       mov       r11,7FFC63E55110
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M03_L05
M03_L08:
       xor       eax,eax
M03_L09:
       movzx     r14d,al
M03_L10:
       test      r14d,r14d
       jne       near ptr M03_L103
M03_L11:
       mov       r14,r15
       test      r14,r14
       je        short M03_L12
       mov       rdx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [r14],rdx
       jne       near ptr M03_L104
M03_L12:
       test      r14,r14
       je        near ptr M03_L105
       mov       rcx,[r14]
       mov       r15,rcx
       mov       r13,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       r15,r13
       jne       near ptr M03_L106
       mov       rcx,r14
       call      qword ptr [7FFC62989D90]; System.Reflection.RuntimeMethodInfo.get_ContainsGenericParameters()
M03_L13:
       test      eax,eax
       jne       near ptr M03_L107
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+38]
       mov       r12,rax
       test      r12,r12
       je        near ptr M03_L120
       cmp       r15,r13
       jne       short M03_L15
       mov       r13d,[r14+5C]
M03_L14:
       mov       edx,8
       mov       ecx,4
       test      r13b,10
       cmove     edx,ecx
       or        edx,30
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       r13,rax
       xor       r12d,r12d
       jmp       near ptr M03_L35
M03_L15:
       mov       rcx,r14
       mov       rax,[r15+50]
       call      qword ptr [rax+20]
       mov       r13d,eax
       jmp       short M03_L14
M03_L16:
       cmp       [rax],r10
       jne       near ptr M03_L36
       mov       rcx,[r14+50]
       cmp       rcx,[rax+50]
       jne       near ptr M03_L36
       mov       rcx,[r14+38]
       cmp       rcx,[rax+38]
       jne       near ptr M03_L36
       mov       rcx,[r14+8]
       mov       rcx,[rcx+8]
       mov       rdx,[rax+8]
       cmp       rcx,[rdx+8]
       jne       near ptr M03_L36
M03_L17:
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFC63074EB8]; System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression, System.Reflection.PropertyInfo)
       mov       r14,rax
       mov       r15,20D7C030020
M03_L18:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M03_L123
       mov       rcx,[r15+18]
       call      00007FFC63491170
       movzx     ecx,al
       cmp       ecx,1D
       ja        short M03_L19
       mov       eax,1FEF7FFF
       bt        eax,ecx
       jae       near ptr M03_L122
M03_L19:
       cmp       ecx,10
       sete      r13b
       movzx     r13d,r13b
M03_L20:
       test      r13d,r13d
       jne       near ptr M03_L121
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M03_L124
M03_L21:
       test      r15,r15
       je        near ptr M03_L125
       mov       rcx,r15
       call      00007FFCC2489400
       test      eax,eax
       jne       near ptr M03_L126
       mov       rcx,offset MT_System.String
       call      00007FFC63491170
       movzx     ecx,al
       mov       rax,20D7C030020
       cmp       ecx,10
       je        near ptr M03_L129
       mov       rcx,offset MT_System.String
       call      00007FFC63491170
       movzx     ecx,al
       mov       rax,20D7C030020
       cmp       ecx,0F
       je        near ptr M03_L130
       mov       rcx,offset MT_System.Linq.Expressions.ConstantExpression
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,20D7C040428
       mov       [r15+8],rcx
       test      r14,r14
       je        near ptr M03_L131
       mov       rcx,offset MT_System.Linq.Expressions.PropertyExpression
       cmp       [r14],rcx
       jne       near ptr M03_L132
       mov       rdx,[r14+10]
M03_L22:
       mov       rcx,rdx
       test      rcx,rcx
       je        short M03_L23
       mov       rax,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rcx],rax
       jne       near ptr M03_L133
M03_L23:
       test      rcx,rcx
       je        short M03_L24
       mov       rax,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rcx],rax
       jne       near ptr M03_L134
       cmp       qword ptr [rcx+18],0
       je        near ptr M03_L135
M03_L24:
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,r14
       mov       r9,r15
       mov       ecx,0D
       mov       rdx,20D7C042B30
       call      qword ptr [7FFC63075818]; System.Linq.Expressions.Expression.GetEqualityComparisonOperator(System.Linq.Expressions.ExpressionType, System.String, System.Linq.Expressions.Expression, System.Linq.Expressions.Expression, Boolean)
       mov       r14,rax
       mov       rcx,offset MT_System.Linq.Expressions.ParameterExpression[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-50],r14
       mov       rdx,1CCFD000668
       cmp       r15,[rdx]
       je        near ptr M03_L139
       mov       edx,1
       mov       rcx,offset MT_System.Linq.Expressions.ParameterExpression[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,[r15]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M03_L138
       cmp       dword ptr [r15+8],0
       je        near ptr M03_L138
       cmp       dword ptr [rdi+8],0
       je        near ptr M03_L138
       movzx     r8d,word ptr [rcx]
       lea       rdx,[r15+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M03_L39
       cmp       r8,4000
       ja        near ptr M03_L137
       mov       rcx,rax
       call      00007FFCC24537A0
       cmp       dword ptr [7FFCC2793A90],0
       jne       near ptr M03_L136
M03_L25:
       mov       rcx,offset MT_System.Runtime.CompilerServices.TrueReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M03_L26:
       lea       rdx,[rbp-50]
       mov       r8,r14
       mov       rcx,20D7C04C650
       mov       r9,20D7C042510
       call      qword ptr [7FFC62E5F918]; System.Linq.Expressions.Expression.ValidateLambdaArgs(System.Type, System.Linq.Expressions.Expression ByRef, System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>, System.String)
       mov       [rsp+20],r14
       mov       rdx,[rbp-50]
       mov       rcx,offset MT_System.Linq.Expressions.Expression<System.Func<DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TestDbEntity, System.Boolean>>
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC62E5F9C0]; System.Linq.Expressions.Expression`1[[System.__Canon, System.Private.CoreLib]].Create(System.Linq.Expressions.Expression, System.String, Boolean, System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.ParameterExpression>)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M03_L140
       mov       rcx,offset MT_LinqToDB.Internal.Linq.Table<DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TestDbEntity>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TempFileDataContext
       cmp       [rsi],rcx
       jne       near ptr M03_L141
       mov       r15,[rsi+28]
M03_L27:
       cmp       [r15],r15b
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TestDbEntity
       test      dword ptr [rcx],80000000
       jne       near ptr M03_L40
       test      byte ptr [rcx],30
       setne     al
       movzx     eax,al
       jmp       near ptr M03_L41
M03_L28:
       mov       [rbp-0E8],r8
       mov       rcx,r10
       mov       [rbp-108],r10
       mov       rdx,[r10]
       mov       rdx,[rdx+70]
       call      qword ptr [rdx+18]
       test      al,20
       jne       near ptr M03_L114
M03_L29:
       mov       rcx,r15
       mov       rax,[r15]
       mov       [rbp-0F0],rax
       mov       rdx,[rax+50]
       call      qword ptr [rdx+30]
       test      eax,eax
       je        near ptr M03_L34
       mov       rcx,r15
       mov       edx,1
       mov       rax,[rbp-0F0]
       mov       rax,[rax+58]
       call      qword ptr [rax+18]
       mov       [rbp-110],rax
       mov       rcx,[r14]
       mov       r8,rcx
       mov       r10,offset MT_System.Reflection.RuntimeMethodInfo
       mov       rcx,r10
       cmp       r8,rcx
       jne       near ptr M03_L115
       test      rax,rax
       je        short M03_L30
       cmp       [rax],rcx
       jne       short M03_L30
       mov       rcx,[r14+50]
       cmp       rcx,[rax+50]
       jne       short M03_L30
       mov       rcx,[r14+38]
       cmp       rcx,[rax+38]
       jne       short M03_L30
       mov       rcx,[r14+8]
       mov       rcx,[rcx+8]
       mov       rdx,[rax+8]
       cmp       rcx,[rdx+8]
       je        near ptr M03_L17
M03_L30:
       mov       rcx,[r14+8]
       cmp       byte ptr [rcx+9C],0
       jne       near ptr M03_L116
       mov       r10,[r14+38]
M03_L31:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r10],rcx
       je        short M03_L32
       mov       [rbp-0E8],r8
       mov       rcx,r10
       mov       [rbp-118],r10
       mov       rdx,[r10]
       mov       rdx,[rdx+70]
       call      qword ptr [rdx+18]
       test      al,20
       je        short M03_L34
       jmp       near ptr M03_L119
M03_L32:
       mov       rcx,[r10+18]
       test      cl,2
       jne       near ptr M03_L118
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
M03_L33:
       mov       [rbp-118],r10
       test      ecx,ecx
       mov       [rbp-0E8],r8
       jne       near ptr M03_L119
M03_L34:
       inc       r12d
M03_L35:
       mov       ecx,[r13+8]
       cmp       ecx,r12d
       jle       near ptr M03_L120
       cmp       r12d,ecx
       jae       near ptr M03_L160
       mov       r15,[r13+r12*8+10]
       mov       rcx,r15
       mov       rax,[r15]
       mov       [rbp-0F0],rax
       mov       rdx,[rax+50]
       call      qword ptr [rdx+28]
       test      eax,eax
       je        near ptr M03_L29
       mov       rcx,r15
       mov       edx,1
       mov       rax,[rbp-0F0]
       mov       rax,[rax+58]
       call      qword ptr [rax+8]
       mov       [rbp-100],rax
       mov       rcx,[r14]
       mov       r8,rcx
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       mov       r10,rcx
       cmp       r8,r10
       jne       near ptr M03_L110
       test      rax,rax
       jne       near ptr M03_L16
M03_L36:
       mov       rcx,[r14+8]
       cmp       byte ptr [rcx+9C],0
       jne       near ptr M03_L111
       mov       r10,[r14+38]
M03_L37:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r10],rcx
       jne       near ptr M03_L28
       mov       rcx,[r10+18]
       test      cl,2
       jne       near ptr M03_L113
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
M03_L38:
       mov       [rbp-108],r10
       test      ecx,ecx
       mov       [rbp-0E8],r8
       je        near ptr M03_L29
       jmp       near ptr M03_L114
M03_L39:
       mov       rcx,rax
       call      qword ptr [7FFC62845818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L25
M03_L40:
       xor       eax,eax
M03_L41:
       mov       rcx,20D7C0445E0
       movzx     ecx,al
       test      ecx,ecx
       jne       near ptr M03_L142
M03_L42:
       xor       ecx,ecx
M03_L43:
       mov       rdx,20D7C0445E0
       test      rcx,rcx
       cmove     rcx,rdx
       mov       r13,rcx
       mov       r12,[r15+10]
       xor       eax,eax
       cmp       dword ptr [r12+8],0
       jle       short M03_L45
M03_L44:
       mov       [rbp-0F8],rax
       mov       rcx,[r12+rax*8+10]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC63254B70]; LinqToDB.Internal.Mapping.MappingSchemaInfo.GetScalarType(System.Type)
       mov       [rbp-58],ax
       cmp       byte ptr [rbp-58],0
       jne       near ptr M03_L143
       mov       rcx,[rbp-0F8]
       inc       ecx
       cmp       [r12+8],ecx
       mov       rax,rcx
       jg        short M03_L44
M03_L45:
       mov       rcx,[r15+28]
       mov       r15,[rcx+10]
       mov       r12,r13
       mov       rax,[rcx+8]
       mov       [rbp-120],rax
       cmp       [r15],r15b
       test      rax,rax
       je        near ptr M03_L144
       mov       rdx,[r15+8]
       mov       [rbp-128],rdx
       mov       rcx,[rdx+8]
       test      rcx,rcx
       jne       near ptr M03_L145
       mov       rcx,20D7C044C40
       mov       [rbp-0A0],rcx
       xor       ecx,ecx
       mov       [rbp-0A8],rcx
       lea       rcx,[rbp-0A0]
       cmp       qword ptr [rbp-0A8],0
       jne       short M03_L46
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       lea       rcx,[rbp-0A8]
       cmp       qword ptr [rbp-0A8],0
       je        near ptr M03_L68
M03_L46:
       mov       r8,[rcx]
       mov       [rbp-130],r8
       mov       rcx,offset MT_System.Linq.Expressions.TypedParameterExpression
       cmp       [r8],rcx
       je        near ptr M03_L69
       mov       rcx,r8
       mov       r8,[r8]
       mov       r8,[r8+40]
       call      qword ptr [r8+18]
       mov       r8d,eax
M03_L47:
       xor       ecx,ecx
       mov       [rbp-0A8],rcx
       imul      eax,r8d,0A5555529
       mov       [rbp-94],eax
       mov       [rbp-0B0],r12
       mov       [rbp-0B8],rcx
       lea       rcx,[rbp-0B0]
       cmp       qword ptr [rbp-0B8],0
       jne       short M03_L48
       mov       rcx,[rbp-0B0]
       mov       [rbp-0B8],rcx
       lea       rcx,[rbp-0B8]
       cmp       qword ptr [rbp-0B8],0
       je        near ptr M03_L72
M03_L48:
       mov       r12,[rcx]
       mov       rcx,offset MT_System.Linq.Expressions.TypedParameterExpression
       cmp       [r12],rcx
       je        near ptr M03_L73
       mov       rcx,r12
       mov       rdx,[r12]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+18]
       mov       r12d,eax
M03_L49:
       xor       ecx,ecx
       mov       [rbp-0B8],rcx
       imul      r12d,0A5555529
       mov       [rbp-0C0],rcx
       mov       [rbp-0C8],rcx
       lea       rcx,[rbp-0C0]
       cmp       qword ptr [rbp-0C8],0
       jne       short M03_L50
       mov       rcx,[rbp-0C0]
       mov       [rbp-0C8],rcx
       lea       rcx,[rbp-0C8]
       cmp       qword ptr [rbp-0C8],0
       je        near ptr M03_L76
M03_L50:
       mov       rax,[rcx]
       mov       [rbp-138],rax
       mov       rcx,offset MT_System.Linq.Expressions.TypedParameterExpression
       cmp       [rax],rcx
       je        near ptr M03_L77
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
M03_L51:
       xor       edx,edx
       mov       [rbp-0C8],rdx
       mov       r8d,[rbp-94]
       add       r12d,r8d
       add       r12d,eax
M03_L52:
       mov       rax,[rbp-128]
       mov       r8,[rax+8]
       mov       [rbp-140],r8
       test      r8,r8
       jne       near ptr M03_L148
       mov       rcx,[rax+10]
       mov       edx,r12d
       imul      rdx,[rax+28]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M03_L160
       mov       edx,edx
       mov       r8,[rcx+rdx*8+10]
       test      r8,r8
       je        near ptr M03_L86
M03_L53:
       cmp       r12d,[r8+18]
       jne       near ptr M03_L85
       mov       [rbp-150],r8
       lea       rcx,[r8+20]
       mov       r10,[rcx]
       mov       r9,[rcx+8]
       mov       [rbp-160],r9
       mov       r11,[rcx+10]
       mov       [rbp-168],r11
       test      r10,r10
       je        near ptr M03_L84
       mov       rcx,offset MT_LinqToDB.Internal.SqlQuery.SelectQuery
       cmp       [r10],rcx
       je        near ptr M03_L80
       mov       rcx,r10
       mov       rdx,20D7C044C40
       mov       r10,[r10]
       mov       r10,[r10+40]
       call      qword ptr [r10+10]
M03_L54:
       test      eax,eax
       je        near ptr M03_L146
       mov       r9,[rbp-160]
       test      r9,r9
       je        near ptr M03_L82
       test      r13,r13
       je        near ptr M03_L147
       mov       rcx,offset MT_LinqToDB.Internal.SqlQuery.SelectQuery
       cmp       [r9],rcx
       je        near ptr M03_L81
       mov       rcx,r9
       mov       rdx,r13
       mov       rax,[r9]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
M03_L55:
       test      eax,eax
       je        near ptr M03_L147
M03_L56:
       cmp       qword ptr [rbp-168],0
       je        near ptr M03_L83
       xor       edx,edx
M03_L57:
       test      edx,edx
       mov       r8,[rbp-150]
       je        near ptr M03_L85
       mov       rax,[r8+8]
       mov       [rbp-78],rax
M03_L58:
       mov       rdx,[rbp-78]
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       r15,rdx
       test      r15,r15
       je        short M03_L59
       mov       rcx,offset MT_LinqToDB.Mapping.ScalarTypeAttribute[]
       cmp       [r15],rcx
       je        short M03_L59
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
M03_L59:
       mov       rcx,1CCFD001508
       test      r15,r15
       cmove     r15,[rcx]
       cmp       dword ptr [r15+8],0
       jne       near ptr M03_L152
       xor       r12d,r12d
M03_L60:
       xor       r15d,r15d
       test      r12,r12
       jne       near ptr M03_L153
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M03_L154
       mov       rcx,r13
       call      qword ptr [7FFC6278A420]; System.RuntimeType.get_IsEnum()
M03_L61:
       test      eax,eax
       jne       near ptr M03_L156
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+78]
       call      qword ptr [rax]
       test      eax,eax
       jne       near ptr M03_L156
       cmp       byte ptr [7FFC6278B188],0
       jne       near ptr M03_L155
M03_L62:
       mov       eax,r15d
M03_L63:
       test      eax,eax
       jne       near ptr M03_L158
       mov       rcx,offset MT_System.Type[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,20D7C0445E0
       mov       [rax+10],rcx
       mov       rcx,1CCFD001C90
       mov       rcx,[rcx]
       mov       rdx,rax
       call      qword ptr [7FFC62989DE0]; System.Reflection.RuntimeMethodInfo.MakeGenericMethod(System.Type[])
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TempFileDataContext
       cmp       [rsi],rcx
       jne       near ptr M03_L157
       mov       r13,[rsi+28]
M03_L64:
       mov       rcx,rsi
       call      qword ptr [7FFC6284C9A8]; System.Object.GetType()
       mov       r12,rax
       mov       rcx,offset MT_LinqToDB.Internal.Expressions.SqlQueryRootExpression
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-158],rax
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-158]
       lea       rcx,[r13+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      qword ptr [7FFC634A57A0]; System.Linq.Expressions.Expression.Call(System.Reflection.MethodInfo, System.Linq.Expressions.Expression)
M03_L65:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rax
       xor       r9d,r9d
       call      qword ptr [7FFC634ACEB8]; LinqToDB.Internal.Linq.Table`1[[System.__Canon, System.Private.CoreLib]].InitTable(LinqToDB.IDataContext, System.Linq.Expressions.Expression, LinqToDB.Mapping.EntityDescriptor)
       xor       r9d,r9d
       mov       rdx,r14
       mov       r8,rdi
       mov       rcx,7FFC636420F0
       call      qword ptr [7FFC6354F2D0]; LinqToDB.Async.AsyncExtensions.CountAsync[[System.__Canon, System.Private.CoreLib]](System.Linq.IQueryable`1<System.__Canon>, System.Linq.Expressions.Expression`1<System.Func`2<System.__Canon,Boolean>>, System.Threading.CancellationToken)
       cmp       [rax],al
       mov       [rbp-48],rax
       xor       ecx,ecx
       mov       [rbp-40],ecx
       test      byte ptr [rbp-40],4
       jne       near ptr M03_L159
       mov       rcx,[rbp-48]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L159
M03_L66:
       mov       rdx,[rbp-48]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L162
M03_L67:
       mov       rdx,[rbp-48]
       mov       edx,[rdx+38]
       mov       rax,[rbx+90]
       mov       [rax+38],edx
       jmp       near ptr M03_L163
M03_L68:
       xor       r8d,r8d
       jmp       near ptr M03_L47
M03_L69:
       mov       rcx,r8
       call      00007FFCC2453FE0
       test      eax,eax
       je        short M03_L71
       mov       r8d,eax
M03_L70:
       jmp       near ptr M03_L47
M03_L71:
       mov       rcx,[rbp-130]
       call      qword ptr [7FFC6284E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r8d,eax
       jmp       short M03_L70
M03_L72:
       xor       r12d,r12d
       jmp       near ptr M03_L49
M03_L73:
       mov       rcx,r12
       call      00007FFCC2453FE0
       test      eax,eax
       je        short M03_L75
       mov       r12d,eax
M03_L74:
       jmp       near ptr M03_L49
M03_L75:
       mov       rcx,r12
       call      qword ptr [7FFC6284E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r12d,eax
       jmp       short M03_L74
M03_L76:
       xor       eax,eax
       jmp       near ptr M03_L51
M03_L77:
       mov       rcx,rax
       call      00007FFCC2453FE0
       test      eax,eax
       je        short M03_L79
M03_L78:
       jmp       near ptr M03_L51
M03_L79:
       mov       rcx,[rbp-138]
       call      qword ptr [7FFC6284E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       short M03_L78
M03_L80:
       mov       rcx,20D7C044C40
       cmp       r10,rcx
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
       jmp       near ptr M03_L54
M03_L81:
       cmp       r9,r13
       sete      al
       movzx     eax,al
       jmp       near ptr M03_L55
M03_L82:
       test      r13,r13
       jne       near ptr M03_L147
       jmp       near ptr M03_L56
M03_L83:
       mov       edx,1
       jmp       near ptr M03_L57
M03_L84:
       mov       r8,[rbp-150]
M03_L85:
       mov       r8,[r8+10]
       test      r8,r8
       jne       near ptr M03_L53
M03_L86:
       xor       edx,edx
       mov       [rbp-78],rdx
       mov       rdx,20D7C044C40
       mov       [rbp-70],rdx
       mov       [rbp-68],r13
       xor       edx,edx
       mov       [rbp-60],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       mov       rdx,[rbp-60]
       mov       [rbp-0D0],rdx
       lea       rdx,[rbp-70]
       mov       r8,[rbp-120]
       mov       rcx,[r8+8]
       call      qword ptr [r8+18]
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       dword ptr [rsp+30],1
       lea       r8,[rbp-78]
       mov       [rsp+38],r8
       mov       [rsp+20],rax
       lea       r8,[rbp-0E0]
       mov       r9d,r12d
       shl       r9,20
       or        r9,1
       mov       rdx,[rbp-128]
       mov       rcx,r15
       call      qword ptr [7FFC631BE1A8]; System.Collections.Concurrent.ConcurrentDictionary`2[[LinqToDB.Internal.Mapping.MappingAttributesCache+CacheKey, linq2db],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<CacheKey,System.__Canon>, CacheKey, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M03_L58
M03_L87:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC631BD4B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L88:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M03_L00
M03_L89:
       mov       r15d,1
       jmp       near ptr M03_L02
M03_L90:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       r15d,eax
       jmp       near ptr M03_L02
M03_L91:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M03_L03
M03_L92:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6391F678]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC63547690]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L93:
       mov       rcx,20D7C0445E0
       mov       rax,[7FFC6278A1E0]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       short M03_L94
       mov       rcx,20D7C031A88
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC63985E78]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,20D7C0423A0
       call      qword ptr [7FFC63985E90]
       mov       rcx,rax
       mov       rdx,20D7C0445E0
       call      qword ptr [7FFC63985EA8]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFC62BC6370]
       jmp       short M03_L95
M03_L94:
       mov       rcx,20D7C031A88
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC63985E78]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,20D7C0423F0
       call      qword ptr [7FFC63985E90]
       mov       rcx,rax
       mov       rdx,20D7C0445E0
       call      qword ptr [7FFC63985EA8]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       call      qword ptr [7FFC62BC6370]
       mov       rsi,rbx
M03_L95:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L96:
       mov       rcx,20D7C0445E0
       mov       rax,[7FFC6278A1E8]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M03_L04
M03_L97:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC63DDFAB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC62BC4480]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L98:
       xor       r13d,r13d
       jmp       near ptr M03_L06
M03_L99:
       xor       r13d,r13d
       jmp       near ptr M03_L06
M03_L100:
       mov       rcx,r15
       mov       rax,[r14+40]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M03_L06
M03_L101:
       xor       eax,eax
       jmp       near ptr M03_L09
M03_L102:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+60]
       call      qword ptr [rax+8]
       mov       r14d,eax
       jmp       near ptr M03_L10
M03_L103:
       call      qword ptr [7FFC63DDFAC8]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rdi
       call      qword ptr [7FFC6391E748]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC62BC4480]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L104:
       mov       rdx,r15
       mov       rcx,offset MT_System.Reflection.MethodInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r14,rax
       jmp       near ptr M03_L12
M03_L105:
       mov       ecx,3167
       mov       rdx,7FFC62E8F788
       call      qword ptr [7FFC62A67798]
       mov       rcx,rax
       call      qword ptr [7FFC6391D2A8]
       int       3
M03_L106:
       mov       rcx,r14
       mov       rax,[r15+58]
       call      qword ptr [rax+28]
       jmp       near ptr M03_L13
M03_L107:
       mov       rcx,r14
       mov       rax,[r15+58]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M03_L108
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,20D7C042968
       call      qword ptr [7FFC63985E90]
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FFC63985EA8]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,20D7C042A20
       call      qword ptr [7FFC62BC6370]
       jmp       short M03_L109
M03_L108:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,20D7C0429C0
       call      qword ptr [7FFC63985E90]
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FFC63985EA8]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,20D7C042A20
       call      qword ptr [7FFC62BC6370]
M03_L109:
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L110:
       mov       rcx,r14
       mov       rdx,rax
       mov       [rbp-0E8],r8
       mov       r10,[r8+40]
       call      qword ptr [r10+10]
       test      eax,eax
       je        short M03_L112
       jmp       near ptr M03_L17
M03_L111:
       xor       r10d,r10d
       jmp       near ptr M03_L37
M03_L112:
       mov       rcx,r14
       mov       rax,[rbp-0E8]
       mov       rdx,[rax+40]
       call      qword ptr [rdx+38]
       mov       r10,rax
       mov       rax,[rbp-100]
       mov       r8,[rbp-0E8]
       jmp       near ptr M03_L37
M03_L113:
       xor       ecx,ecx
       jmp       near ptr M03_L38
M03_L114:
       mov       rcx,r14
       mov       r8,[rbp-0E8]
       mov       rdx,[r8+40]
       call      qword ptr [rdx+30]
       mov       [rbp-170],rax
       mov       rcx,[rbp-100]
       mov       rdx,[rcx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       mov       rcx,[rbp-170]
       call      qword ptr [7FFC6284C828]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M03_L29
       mov       rcx,r14
       mov       rax,[rbp-0E8]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,[rbp-108]
       mov       r8d,1C
       call      qword ptr [7FFC62788420]; Precode of System.Type.GetMethod(System.String, System.Reflection.BindingFlags)
       mov       rdx,[rbp-100]
       cmp       rax,rdx
       je        near ptr M03_L17
       test      rax,rax
       je        near ptr M03_L29
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M03_L17
       jmp       near ptr M03_L29
M03_L115:
       mov       rcx,r14
       mov       rdx,rax
       mov       [rbp-0E8],r8
       mov       r10,[r8+40]
       call      qword ptr [r10+10]
       test      eax,eax
       je        short M03_L117
       jmp       near ptr M03_L17
M03_L116:
       xor       r10d,r10d
       jmp       near ptr M03_L31
M03_L117:
       mov       rcx,r14
       mov       rax,[rbp-0E8]
       mov       rdx,[rax+40]
       call      qword ptr [rdx+38]
       mov       r10,rax
       mov       rax,[rbp-110]
       mov       r8,[rbp-0E8]
       jmp       near ptr M03_L31
M03_L118:
       xor       ecx,ecx
       jmp       near ptr M03_L33
M03_L119:
       mov       rcx,r14
       mov       r8,[rbp-0E8]
       mov       rdx,[r8+40]
       call      qword ptr [rdx+30]
       mov       [rbp-178],rax
       mov       rcx,[rbp-110]
       mov       rdx,[rcx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       mov       rcx,[rbp-178]
       call      qword ptr [7FFC6284C828]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M03_L34
       mov       rcx,r14
       mov       rax,[rbp-0E8]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,[rbp-118]
       mov       r8d,1C
       call      qword ptr [7FFC62788420]; Precode of System.Type.GetMethod(System.String, System.Reflection.BindingFlags)
       mov       rdx,[rbp-110]
       cmp       rax,rdx
       je        near ptr M03_L17
       test      rax,rax
       je        near ptr M03_L34
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M03_L17
       jmp       near ptr M03_L34
M03_L120:
       mov       rcx,r14
       mov       rax,[r14]
       mov       r15,rax
       mov       rax,[r15+40]
       call      qword ptr [rax+38]
       mov       r15,rax
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r14,rax
       mov       ecx,3167
       mov       rdx,7FFC62E8F788
       call      qword ptr [7FFC62A67798]
       mov       r8,rax
       mov       rcx,r15
       mov       rdx,r14
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFC63DDFAE0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L121:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r15,rax
       jmp       near ptr M03_L18
M03_L122:
       mov       r13d,1
       jmp       near ptr M03_L20
M03_L123:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       r13d,eax
       jmp       near ptr M03_L20
M03_L124:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       r15,rax
       jmp       near ptr M03_L21
M03_L125:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6391F678]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC63547690]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L126:
       mov       rcx,20D7C030020
       call      qword ptr [7FFC6278A380]; System.RuntimeType.get_IsGenericTypeDefinition()
       test      eax,eax
       jne       short M03_L127
       mov       rcx,20D7C031A88
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC63985E78]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,20D7C0423A0
       call      qword ptr [7FFC63985E90]
       mov       rcx,rax
       mov       rdx,20D7C030020
       call      qword ptr [7FFC63985EA8]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFC62BC6370]
       jmp       short M03_L128
M03_L127:
       mov       rcx,20D7C031A88
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC63985E78]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,20D7C0423F0
       call      qword ptr [7FFC63985E90]
       mov       rcx,rax
       mov       rdx,20D7C030020
       call      qword ptr [7FFC63985EA8]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       call      qword ptr [7FFC62BC6370]
       mov       rsi,rbx
M03_L128:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L129:
       mov       ecx,2ECB
       mov       rdx,7FFC62E8F788
       call      qword ptr [7FFC62A67798]
       mov       rcx,rax
       call      qword ptr [7FFC63985EC0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L130:
       mov       ecx,2ECB
       mov       rdx,7FFC62E8F788
       call      qword ptr [7FFC62A67798]
       mov       rcx,rax
       call      qword ptr [7FFC63985ED8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L131:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2BF3
       mov       rdx,7FFC62E8F788
       call      qword ptr [7FFC62A67798]
       mov       rcx,rax
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC63984CC0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC62BC5B78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L132:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdx,rax
       jmp       near ptr M03_L22
M03_L133:
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M03_L23
M03_L134:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       near ptr M03_L24
M03_L135:
       mov       ecx,2BF3
       mov       rdx,7FFC62E8F788
       call      qword ptr [7FFC62A67798]
       mov       rcx,rax
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC63984CD8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L136:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L25
M03_L137:
       mov       rcx,rax
       call      qword ptr [7FFC63984EB8]
       jmp       near ptr M03_L25
M03_L138:
       mov       dword ptr [rsp+20],1
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFC62DDEB38]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M03_L25
M03_L139:
       mov       rdx,1CCFD000668
       mov       r14,[rdx]
       jmp       near ptr M03_L26
M03_L140:
       mov       ecx,0D5
       mov       rdx,7FFC62C31720
       call      qword ptr [7FFC62A67798]
       mov       rcx,rax
       call      qword ptr [7FFC6391D2A8]
       int       3
M03_L141:
       mov       rcx,rsi
       mov       r11,7FFC63E55128
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M03_L27
M03_L142:
       mov       rcx,20D7C0445E0
       mov       rax,[7FFC6278A1E0]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M03_L42
       mov       rcx,20D7C0445E0
       mov       rax,[7FFC6278A1E8]
       call      qword ptr [rax+18]
       mov       rcx,20D7C03E418
       cmp       rax,rcx
       jne       near ptr M03_L42
       mov       rcx,20D7C0445E0
       mov       rax,[7FFC6278A1E8]
       call      qword ptr [rax+28]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M03_L160
       mov       rcx,[rax+10]
       jmp       near ptr M03_L43
M03_L143:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC631BFCD8]
       jmp       near ptr M03_L63
M03_L144:
       mov       ecx,0B80
       mov       rdx,7FFC62B61930
       call      qword ptr [7FFC62A67798]
       mov       rcx,rax
       call      qword ptr [7FFC62D67228]
       int       3
M03_L145:
       mov       r11,20D7C044C40
       mov       [rbp-90],r11
       mov       [rbp-88],r12
       xor       r11d,r11d
       mov       [rbp-80],r11
       lea       rdx,[rbp-90]
       mov       r11,7FFC63E55138
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M03_L52
M03_L146:
       mov       r8,[rbp-150]
       jmp       near ptr M03_L85
M03_L147:
       xor       edx,edx
       jmp       near ptr M03_L57
M03_L148:
       mov       rdx,[rax+10]
       mov       ecx,r12d
       imul      rcx,[rax+28]
       shr       rcx,20
       inc       rcx
       mov       r11d,[rdx+8]
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M03_L160
       mov       ecx,ecx
       mov       r10,[rdx+rcx*8+10]
       test      r10,r10
       je        near ptr M03_L86
M03_L149:
       cmp       r12d,[r10+18]
       jne       short M03_L150
       mov       rdx,20D7C044C40
       mov       [rbp-70],rdx
       mov       [rbp-68],r13
       xor       edx,edx
       mov       [rbp-60],rdx
       mov       [rbp-148],r10
       vmovdqu   xmm0,xmmword ptr [r10+20]
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       mov       rdx,[r10+30]
       mov       [rbp-0D0],rdx
       lea       rdx,[rbp-0E0]
       lea       r8,[rbp-70]
       mov       rcx,[rbp-140]
       mov       r11,7FFC63E55140
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rbp-148]
       jne       short M03_L151
M03_L150:
       mov       r10,[r10+10]
       test      r10,r10
       jne       short M03_L149
       jmp       near ptr M03_L86
M03_L151:
       mov       rdx,[r10+8]
       mov       [rbp-78],rdx
       jmp       near ptr M03_L58
M03_L152:
       cmp       dword ptr [r15+8],0
       jbe       near ptr M03_L160
       mov       r12,[r15+10]
       jmp       near ptr M03_L60
M03_L153:
       movzx     r15d,byte ptr [r12+10]
       jmp       near ptr M03_L62
M03_L154:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+70]
       call      qword ptr [rax+30]
       jmp       near ptr M03_L61
M03_L155:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        near ptr M03_L62
M03_L156:
       mov       r15d,1
       jmp       near ptr M03_L62
M03_L157:
       mov       rcx,rsi
       mov       r11,7FFC63E55130
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M03_L64
M03_L158:
       xor       eax,eax
       jmp       near ptr M03_L65
M03_L159:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-40]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFC641E78B8]
       mov       rdx,rax
       lea       rcx,[rbp-48]
       call      qword ptr [7FFC641E78D0]
       jmp       short M03_L164
M03_L160:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L161:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L66
M03_L162:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFC6398DE30]
       jmp       near ptr M03_L67
M03_L163:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L165
       mov       rdx,1CCE7000C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L164:
       nop
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L165:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFC63DD5D88]
       jmp       short M03_L164
       sub       rsp,48
       vzeroupper
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFC6354F240]
       lea       rax,[M03_L164]
       add       rsp,48
       ret
; Total bytes of code 6619
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFCC22C1D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.HashCode.Combine[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M06_L00
       ret
M06_L00:
       xor       edx,edx
       jmp       qword ptr [7FFC6398DE30]
; Total bytes of code 29
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark.HasRecordsAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFC62A7FDE0]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFC635F6D30]; DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<HasRecordsAsync>d__11.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFC63EC71C8]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFC638CFF00]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFC63B0E0A0]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFC63EC71C8]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFC6394F570]
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFCC22A9030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.HashCode.Combine[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFCC22A9038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFCC22AAEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFCC22A8FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<HasRecordsAsync>d__11.MoveNext()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,2A8
       vzeroupper
       lea       rbp,[rsp+2E0]
       xor       eax,eax
       mov       [rbp-1E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1E0],xmm4
       vmovdqa   xmmword ptr [rbp-1D0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M03_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L00
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L202
       mov       rsi,[rbx+1A8]
       test      rsi,rsi
       je        near ptr M03_L112
       mov       rcx,offset MT_LinqToDB.Internal.Linq.Table<DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TestDbEntity>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TempFileDataContext
       cmp       [rsi],rcx
       jne       near ptr M03_L113
       mov       r14,[rsi+28]
M03_L01:
       cmp       [r14],r14b
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TestDbEntity
       test      dword ptr [rcx],80000000
       je        short M03_L02
       xor       eax,eax
       jmp       short M03_L03
M03_L02:
       test      byte ptr [rcx],30
       setne     al
       movzx     eax,al
M03_L03:
       mov       rcx,1BA086845E0
       movzx     ecx,al
       test      ecx,ecx
       jne       near ptr M03_L114
M03_L04:
       xor       ecx,ecx
M03_L05:
       mov       rdx,1BA086845E0
       test      rcx,rcx
       cmove     rcx,rdx
       mov       r15,rcx
       mov       r13,[r14+10]
       xor       r12d,r12d
       cmp       dword ptr [r13+8],0
       jle       short M03_L07
M03_L06:
       mov       rcx,[r13+r12*8+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFC6328C7B0]; LinqToDB.Internal.Mapping.MappingSchemaInfo.GetScalarType(System.Type)
       mov       [rbp-50],ax
       cmp       byte ptr [rbp-50],0
       jne       near ptr M03_L115
       inc       r12d
       cmp       [r13+8],r12d
       jg        short M03_L06
M03_L07:
       mov       rcx,[r14+28]
       mov       r14,[rcx+10]
       mov       r13,r15
       mov       r12,[rcx+8]
       cmp       [r14],r14b
       test      r12,r12
       je        near ptr M03_L116
       mov       rax,[r14+8]
       mov       [rbp-1F0],rax
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       near ptr M03_L117
       mov       rcx,1BA08684C40
       mov       [rbp-98],rcx
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       cmp       qword ptr [rbp-0A0],0
       jne       short M03_L08
       mov       rcx,[rbp-98]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-0A0]
       cmp       qword ptr [rbp-0A0],0
       je        near ptr M03_L30
M03_L08:
       mov       rdx,[rcx]
       mov       [rbp-1F8],rdx
       mov       rcx,offset MT_LinqToDB.Internal.SqlQuery.SqlParameter
       cmp       [rdx],rcx
       jne       near ptr M03_L32
       mov       rcx,rdx
       call      00007FFCC2453FE0
       test      eax,eax
       je        near ptr M03_L31
M03_L09:
       mov       edx,eax
M03_L10:
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       imul      eax,edx,0A5555529
       mov       [rbp-8C],eax
       mov       [rbp-0A8],r13
       mov       [rbp-0B0],rcx
       lea       rcx,[rbp-0A8]
       cmp       qword ptr [rbp-0B0],0
       jne       short M03_L11
       mov       rcx,[rbp-0A8]
       mov       [rbp-0B0],rcx
       lea       rcx,[rbp-0B0]
       cmp       qword ptr [rbp-0B0],0
       je        near ptr M03_L33
M03_L11:
       mov       r13,[rcx]
       mov       rcx,offset MT_LinqToDB.Internal.SqlQuery.SqlParameter
       cmp       [r13],rcx
       jne       near ptr M03_L35
       mov       rcx,r13
       call      00007FFCC2453FE0
       test      eax,eax
       je        near ptr M03_L34
M03_L12:
       mov       r13d,eax
M03_L13:
       xor       ecx,ecx
       mov       [rbp-0B0],rcx
       imul      r13d,0A5555529
       mov       [rbp-0B8],rcx
       mov       [rbp-0C0],rcx
       lea       rcx,[rbp-0B8]
       cmp       qword ptr [rbp-0C0],0
       jne       short M03_L14
       mov       rcx,[rbp-0B8]
       mov       [rbp-0C0],rcx
       lea       rcx,[rbp-0C0]
       cmp       qword ptr [rbp-0C0],0
       je        near ptr M03_L36
M03_L14:
       mov       rax,[rcx]
       mov       [rbp-200],rax
       mov       rcx,offset MT_LinqToDB.Internal.SqlQuery.SqlParameter
       cmp       [rax],rcx
       jne       near ptr M03_L38
       mov       rcx,rax
       call      00007FFCC2453FE0
       test      eax,eax
       je        near ptr M03_L37
M03_L15:
       xor       edx,edx
       mov       [rbp-0C0],rdx
       mov       r8d,[rbp-8C]
       add       r13d,r8d
       add       r13d,eax
M03_L16:
       mov       rax,[rbp-1F0]
       mov       r8,[rax+8]
       mov       [rbp-208],r8
       test      r8,r8
       jne       near ptr M03_L119
       mov       rcx,[rax+10]
       mov       edx,r13d
       imul      rdx,[rax+28]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M03_L201
       mov       edx,edx
       mov       r8,[rcx+rdx*8+10]
       test      r8,r8
       je        near ptr M03_L45
M03_L17:
       cmp       r13d,[r8+18]
       jne       near ptr M03_L44
       mov       [rbp-218],r8
       lea       rcx,[r8+20]
       mov       r10,[rcx]
       mov       r9,[rcx+8]
       mov       [rbp-290],r9
       mov       r11,[rcx+10]
       mov       [rbp-298],r11
       test      r10,r10
       je        near ptr M03_L43
       mov       rdx,offset MT_System.RuntimeType
       cmp       [r10],rdx
       jne       near ptr M03_L39
       mov       rcx,1BA08684C40
       cmp       r10,rcx
       sete      dl
       movzx     edx,dl
M03_L18:
       test      edx,edx
       je        near ptr M03_L118
       mov       r9,[rbp-290]
       test      r9,r9
       je        near ptr M03_L42
       mov       rdx,offset MT_System.RuntimeType
       mov       r10,rdx
       cmp       [r9],r10
       jne       near ptr M03_L40
       cmp       r15,r9
       sete      r10b
       movzx     r10d,r10b
M03_L19:
       test      r10d,r10d
       je        near ptr M03_L42
       cmp       qword ptr [rbp-298],0
       je        near ptr M03_L41
       xor       edx,edx
M03_L20:
       test      edx,edx
       mov       r8,[rbp-218]
       je        near ptr M03_L44
       mov       rax,[r8+8]
       mov       [rbp-70],rax
M03_L21:
       mov       rdx,[rbp-70]
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       r14,rdx
       test      r14,r14
       je        short M03_L22
       mov       rcx,offset MT_LinqToDB.Mapping.ScalarTypeAttribute[]
       cmp       [r14],rcx
       je        short M03_L22
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r14,rax
M03_L22:
       mov       rcx,17989801530
       test      r14,r14
       cmove     r14,[rcx]
       cmp       dword ptr [r14+8],0
       jne       near ptr M03_L123
       xor       r13d,r13d
M03_L23:
       xor       r14d,r14d
       test      r13,r13
       jne       near ptr M03_L124
       mov       r10,offset MT_System.RuntimeType
       mov       r12,r10
       cmp       [r15],r12
       jne       near ptr M03_L126
       mov       rcx,[r15+18]
       test      cl,2
       jne       near ptr M03_L125
       mov       rcx,[rcx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rcx,rdx
       sete      al
       movzx     eax,al
M03_L24:
       test      eax,eax
       jne       near ptr M03_L128
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+78]
       call      qword ptr [rax]
       test      eax,eax
       jne       near ptr M03_L128
       cmp       byte ptr [7FFC6279B188],0
       jne       near ptr M03_L127
M03_L25:
       mov       eax,r14d
M03_L26:
       test      eax,eax
       jne       near ptr M03_L168
       mov       rcx,offset MT_System.Type[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,1BA086845E0
       mov       [rax+10],rcx
       mov       rcx,17989801CB8
       mov       rcx,[rcx]
       mov       rdx,rax
       call      qword ptr [7FFC62999DE0]; System.Reflection.RuntimeMethodInfo.MakeGenericMethod(System.Type[])
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TempFileDataContext
       cmp       [rsi],rcx
       jne       near ptr M03_L129
       mov       r12,[rsi+28]
M03_L27:
       mov       rcx,rsi
       call      qword ptr [7FFC6285C9A8]; System.Object.GetType()
       mov       r15,rax
       mov       rcx,offset MT_LinqToDB.Internal.Expressions.SqlQueryRootExpression
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       je        near ptr M03_L130
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [r14],rcx
       jne       near ptr M03_L131
       mov       rcx,r14
       call      qword ptr [7FFC62999D90]; System.Reflection.RuntimeMethodInfo.get_ContainsGenericParameters()
M03_L28:
       test      eax,eax
       jne       near ptr M03_L132
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [r14],rcx
       jne       near ptr M03_L46
       mov       r15d,[r14+5C]
M03_L29:
       test      r15b,10
       jne       near ptr M03_L47
       call      qword ptr [7FFC63B04228]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L30:
       xor       edx,edx
       jmp       near ptr M03_L10
M03_L31:
       mov       rcx,[rbp-1F8]
       call      qword ptr [7FFC6285E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M03_L09
M03_L32:
       mov       rcx,rdx
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+18]
       mov       edx,eax
       jmp       near ptr M03_L10
M03_L33:
       xor       r13d,r13d
       jmp       near ptr M03_L13
M03_L34:
       mov       rcx,r13
       call      qword ptr [7FFC6285E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M03_L12
M03_L35:
       mov       rcx,r13
       mov       rdx,[r13]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+18]
       mov       r13d,eax
       jmp       near ptr M03_L13
M03_L36:
       xor       eax,eax
       jmp       near ptr M03_L15
M03_L37:
       mov       rcx,[rbp-200]
       call      qword ptr [7FFC6285E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M03_L15
M03_L38:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L15
M03_L39:
       mov       rcx,r10
       mov       rdx,1BA08684C40
       mov       r10,[r10]
       mov       r10,[r10+40]
       call      qword ptr [r10+10]
       mov       edx,eax
       jmp       near ptr M03_L18
M03_L40:
       mov       rcx,r9
       mov       rdx,r15
       mov       r10,[r9]
       mov       r10,[r10+40]
       call      qword ptr [r10+10]
       mov       r10d,eax
       jmp       near ptr M03_L19
M03_L41:
       mov       edx,1
       jmp       near ptr M03_L20
M03_L42:
       xor       edx,edx
       jmp       near ptr M03_L20
M03_L43:
       mov       r8,[rbp-218]
M03_L44:
       mov       r8,[r8+10]
       test      r8,r8
       jne       near ptr M03_L17
M03_L45:
       xor       edx,edx
       mov       [rbp-70],rdx
       mov       rdx,1BA08684C40
       mov       [rbp-68],rdx
       mov       [rbp-60],r15
       xor       edx,edx
       mov       [rbp-58],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-68]
       vmovdqu   xmmword ptr [rbp-188],xmm0
       mov       rdx,[rbp-58]
       mov       [rbp-178],rdx
       lea       rdx,[rbp-68]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       dword ptr [rsp+30],1
       lea       r8,[rbp-70]
       mov       [rsp+38],r8
       mov       [rsp+20],rax
       lea       r8,[rbp-188]
       mov       r9d,r13d
       shl       r9,20
       or        r9,1
       mov       rdx,[rbp-1F0]
       mov       rcx,r14
       call      qword ptr [7FFC63285DE8]; System.Collections.Concurrent.ConcurrentDictionary`2[[LinqToDB.Internal.Mapping.MappingAttributesCache+CacheKey, linq2db],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<CacheKey,System.__Canon>, CacheKey, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M03_L21
M03_L46:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       r15d,eax
       jmp       near ptr M03_L29
M03_L47:
       mov       rcx,17989800688
       mov       r15,[rcx]
       mov       r12,offset MT_System.RuntimeType
       cmp       [r14],r12
       jne       near ptr M03_L135
       mov       rcx,r14
       call      00007FFCC2453FE0
       test      eax,eax
       je        near ptr M03_L95
M03_L48:
       mov       rcx,[r15+8]
       mov       edx,eax
       and       edx,[r15+10]
       cmp       edx,[rcx+8]
       jae       near ptr M03_L201
       mov       r8,[rcx+rdx*8+10]
       mov       [rbp-228],r8
       test      r8,r8
       je        near ptr M03_L137
       cmp       [r8+18],eax
       jne       near ptr M03_L137
       mov       rcx,[r8+8]
       cmp       [rcx],r12
       jne       near ptr M03_L136
       cmp       r14,rcx
       jne       near ptr M03_L137
M03_L49:
       mov       r8,[rbp-228]
       mov       r15,[r8+10]
M03_L50:
       mov       ecx,[r15+8]
       cmp       ecx,1
       jne       near ptr M03_L138
       test      ecx,ecx
       je        near ptr M03_L201
       mov       r15,[r15+10]
       mov       [rbp-0C8],r13
       mov       r13,[rbp-0C8]
       test      r13,r13
       je        near ptr M03_L140
       mov       rcx,offset MT_System.Linq.Expressions.TypedParameterExpression
       cmp       [r13],rcx
       je        near ptr M03_L96
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
M03_L51:
       cmp       eax,17
       je        near ptr M03_L97
       cmp       eax,37
       je        near ptr M03_L141
M03_L52:
       mov       rcx,offset MT_System.Reflection.RuntimeParameterInfo
       cmp       [r15],rcx
       jne       near ptr M03_L150
       cmp       qword ptr [r15+8],0
       je        near ptr M03_L147
M03_L53:
       mov       r13,[r15+8]
M03_L54:
       mov       r15,r13
       cmp       [r15],r12
       jne       near ptr M03_L151
       mov       rcx,[r15+18]
       call      00007FFC63501158
       movzx     ecx,al
       cmp       ecx,10
       je        near ptr M03_L152
M03_L55:
       mov       rcx,1BA08671440
       cmp       r15,rcx
       je        short M03_L61
       cmp       [r15],r12
       jne       near ptr M03_L158
       mov       r13,r15
M03_L56:
       cmp       [r13],r12
       jne       near ptr M03_L155
       mov       rcx,[r13+18]
       call      00007FFC63501158
       movzx     ecx,al
       cmp       ecx,1D
       ja        short M03_L57
       mov       eax,1FEF7FFF
       bt        eax,ecx
       jae       near ptr M03_L154
M03_L57:
       cmp       ecx,10
       sete      al
       movzx     eax,al
M03_L58:
       test      eax,eax
       jne       near ptr M03_L153
       cmp       [r13],r12
       jne       near ptr M03_L156
M03_L59:
       test      r13,r13
       je        near ptr M03_L157
       mov       rcx,r13
       call      00007FFCC2489400
M03_L60:
       test      eax,eax
       jne       near ptr M03_L159
M03_L61:
       mov       rcx,[rbp-0C8]
       mov       rax,[rcx]
       mov       rcx,offset MT_System.Linq.Expressions.ConstantExpression
       cmp       rax,rcx
       je        near ptr M03_L101
       mov       rcx,[rbp-0C8]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,rax
M03_L62:
       test      r15,r15
       je        near ptr M03_L106
       cmp       [r15],r12
       jne       near ptr M03_L165
       test      r13,r13
       jne       near ptr M03_L102
M03_L63:
       xor       r12d,r12d
M03_L64:
       test      r12d,r12d
       je        near ptr M03_L106
M03_L65:
       mov       r12,[rbp-0C8]
       mov       rcx,offset MT_System.Linq.Expressions.MethodCallExpression1
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M03_L66:
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       test      rdx,rdx
       je        near ptr M03_L169
M03_L67:
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TempFileDataContext
       cmp       [rsi],rcx
       jne       near ptr M03_L170
       mov       r14,[rsi+28]
       mov       r15,[rsi+8]
M03_L68:
       mov       rax,[r15+28]
       test      rax,rax
       je        near ptr M03_L171
M03_L69:
       mov       rsi,[rax+58]
       mov       rcx,179898002C8
       mov       r15,[rcx]
       mov       rcx,offset MT_LinqToDB.Internal.DataProvider.SQLite.SQLiteMappingSchema+MicrosoftMappingSchema
       cmp       [r14],rcx
       jne       near ptr M03_L173
       mov       r13d,[r14+54]
       cmp       byte ptr [r14+50],0
       je        near ptr M03_L172
M03_L70:
       mov       rcx,179898002C0
       test      rsi,rsi
       cmove     rsi,[rcx]
       mov       rcx,17989800370
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M03_L174
M03_L71:
       cmp       byte ptr [r15+30],0
       jne       near ptr M03_L175
       xor       eax,eax
       mov       [rbp-100],rax
       mov       rax,[r15+20]
       mov       rcx,[rax+8]
       mov       rax,offset MT_LinqToDB.Internal.Cache.SystemClock
       cmp       [rcx],rax
       jne       near ptr M03_L176
       call      qword ptr [7FFC62D76EE0]; System.DateTime.get_UtcNow()
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       xor       ecx,ecx
       mov       [rbp-110],ecx
       mov       [rbp-108],rdx
M03_L72:
       xor       eax,eax
       mov       [rbp-114],eax
       mov       rcx,[r15+8]
       mov       rdx,1BA086845E0
       mov       [rbp-128],rdx
       mov       [rbp-120],r13d
       mov       rdx,[rcx+8]
       mov       [rbp-240],rdx
       mov       r8,[rdx+8]
       mov       [rbp-248],r8
       test      r8,r8
       jne       near ptr M03_L183
       xor       ecx,ecx
       mov       [rbp-138],rcx
       lea       rcx,[rbp-128]
       cmp       qword ptr [rbp-138],0
       jne       short M03_L73
       mov       rcx,[rbp-128]
       mov       [rbp-138],rcx
       lea       rcx,[rbp-138]
       cmp       qword ptr [rbp-138],0
       je        near ptr M03_L177
M03_L73:
       mov       r8,[rcx]
       mov       [rbp-260],r8
       mov       rcx,offset MT_System.RuntimeType
       mov       r10,rcx
       cmp       [r8],r10
       jne       near ptr M03_L178
       mov       rcx,r8
       call      00007FFCC2453FE0
       test      eax,eax
       je        near ptr M03_L108
M03_L74:
       mov       r8d,eax
M03_L75:
       mov       ecx,[rbp-120]
       imul      edx,r8d,0C2B2AE3D
       add       edx,309FA4B9
       rol       edx,11
       imul      edx,27D4EB2F
       imul      ecx,0C2B2AE3D
       add       ecx,edx
       rol       ecx,11
       imul      ecx,27D4EB2F
       mov       edx,ecx
       shr       edx,0F
       xor       edx,ecx
       imul      ecx,edx,85EBCA77
       mov       edx,ecx
       shr       edx,0D
       xor       edx,ecx
       imul      ecx,edx,0C2B2AE3D
       mov       eax,ecx
       shr       eax,10
       xor       eax,ecx
       xor       ecx,ecx
       mov       [rbp-138],rcx
       mov       [rbp-130],eax
       mov       r8,[rbp-240]
       mov       rcx,[r8+10]
       mov       edx,eax
       imul      rdx,[r8+28]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       r10d,r8d
       imul      rdx,r10
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M03_L201
       mov       edx,edx
       mov       r8,[rcx+rdx*8+10]
       test      r8,r8
       je        near ptr M03_L89
M03_L76:
       cmp       eax,[r8+18]
       jne       near ptr M03_L179
       mov       rcx,[r8+20]
       mov       [rbp-258],r8
       mov       r10d,[r8+28]
       mov       [rbp-16C],r10d
       mov       rdx,[rbp-128]
       mov       r9d,[rbp-120]
       mov       [rbp-170],r9d
       test      rcx,rcx
       je        near ptr M03_L181
       test      rdx,rdx
       je        near ptr M03_L180
       mov       r11,offset MT_System.RuntimeType
       cmp       [rcx],r11
       jne       near ptr M03_L109
       cmp       rdx,rcx
       sete      r11b
       movzx     r11d,r11b
M03_L77:
       test      r11d,r11d
       je        near ptr M03_L180
M03_L78:
       mov       r10d,[rbp-16C]
       cmp       r10d,[rbp-170]
       jne       near ptr M03_L180
       mov       r8,[rbp-258]
       mov       rax,[r8+8]
M03_L79:
       cmp       byte ptr [rax+51],0
       jne       near ptr M03_L182
       mov       [rbp-238],rax
       lea       rdx,[rax+58]
       movzx     ecx,byte ptr [rdx]
       vmovups   xmm0,[rdx+8]
       vmovups   [rbp-158],xmm0
       test      ecx,ecx
       jne       near ptr M03_L187
M03_L80:
       mov       rax,[rbp-238]
       movzx     ecx,byte ptr [rax+80]
       mov       rdx,[rax+88]
       test      ecx,ecx
       je        short M03_L81
       mov       rcx,[rax+0B8]
       mov       r8,[rbp-108]
       sub       r8,rcx
       cmp       r8,rdx
       jge       near ptr M03_L188
M03_L81:
       mov       [rbp-238],rax
       mov       rcx,rax
       call      qword ptr [7FFC6328C1C8]; LinqToDB.Internal.Cache.CacheEntry`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].CheckForExpiredTokens()
       test      eax,eax
       jne       near ptr M03_L189
M03_L82:
       mov       dword ptr [rbp-114],1
       vmovups   xmm0,[rbp-110]
       mov       rdx,[rbp-238]
       vmovups   [rdx+0B0],xmm0
       mov       [rbp-238],rdx
       mov       rcx,[rdx+40]
       mov       [rbp-100],rcx
       mov       rcx,179898012D0
       mov       r8,[rcx]
       mov       [rbp-270],r8
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M03_L191
       mov       rcx,[rcx+240]
       mov       r10,[rcx+20]
       test      r10,r10
       je        near ptr M03_L191
M03_L83:
       mov       rcx,[r10+10]
       test      rcx,rcx
       jne       short M03_L84
       call      qword ptr [7FFC62A7FDE0]; System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M03_L84:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        near ptr M03_L192
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Threading.AsyncLocalValueMap+TwoElementAsyncLocalValueMap
       cmp       [rcx],r11
       jne       near ptr M03_L193
       mov       r8,[rbp-270]
       cmp       r8,[rcx+8]
       jne       near ptr M03_L110
       mov       rcx,[rcx+10]
       mov       [rbp-168],rcx
M03_L85:
       mov       r8,[rbp-168]
M03_L86:
       xor       ecx,ecx
       mov       [rbp-168],rcx
       mov       r10,r8
       test      r10,r10
       je        short M03_L87
       mov       rcx,offset MT_LinqToDB.Internal.Cache.CacheEntryStack<System.ValueTuple<System.Type, System.Int32>, LinqToDB.Mapping.EntityDescriptor>
       cmp       [r10],rcx
       jne       near ptr M03_L194
M03_L87:
       test      r10,r10
       je        near ptr M03_L195
M03_L88:
       mov       rdx,[r10+8]
       mov       rcx,[rbp-238]
       cmp       [rcx],ecx
       call      qword ptr [7FFC63284228]; LinqToDB.Internal.Cache.CacheEntry`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].PropagateOptions(LinqToDB.Internal.Cache.CacheEntry`2<System.ValueTuple`2<System.__Canon,Int32>,System.__Canon>)
M03_L89:
       mov       rcx,[r15+20]
       mov       rcx,[rcx+18]
       mov       rax,[r15+40]
       mov       rdx,[rbp-108]
       sub       rdx,rax
       cmp       rcx,rdx
       jl        near ptr M03_L196
M03_L90:
       mov       edx,[rbp-114]
       test      edx,edx
       je        near ptr M03_L198
M03_L91:
       mov       rsi,[rbp-100]
       xor       ecx,ecx
       mov       [rbp-100],rcx
       lea       rdx,[rsi+0A8]
       cmp       [rdx],dl
       lea       rcx,[rdi+50]
       cmp       [rcx],cl
       mov       r8d,28
       call      System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       esi,[rsi+98]
       cmp       [rdi+48],esi
       jne       near ptr M03_L199
M03_L92:
       mov       rcx,offset MT_System.Func<System.Linq.IQueryable<DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TestDbEntity>, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFC6279D1A0
       mov       [rsi+18],rcx
       mov       rcx,7FFC635F3138
       mov       [rsi+20],rcx
       mov       rcx,rsi
       call      qword ptr [7FFC6288AAD0]; System.MulticastDelegate.GetMethodImpl()
       mov       rsi,rax
       mov       rcx,offset MT_System.Linq.Expressions.Expression[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rdx,[rdi+8]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,offset MT_LinqToDB.Internal.Async.IQueryProviderAsync
       mov       r8,7FFC636A9B10
       call      System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       r15,rax
       mov       r8,r14
       mov       rdx,rsi
       xor       ecx,ecx
       call      qword ptr [7FFC6302C7B0]; System.Linq.Expressions.Expression.Call(System.Linq.Expressions.Expression, System.Reflection.MethodInfo, System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      r15
       cmp       [rax],al
       mov       [rbp-48],rax
       xor       ecx,ecx
       mov       [rbp-40],ecx
       test      byte ptr [rbp-40],4
       jne       near ptr M03_L200
       mov       rcx,[rbp-48]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L200
M03_L93:
       mov       rdx,[rbp-48]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L203
M03_L94:
       mov       rdx,[rbp-48]
       movzx     edx,byte ptr [rdx+38]
       mov       rax,[rbx+90]
       mov       [rax+4C],dl
       jmp       near ptr M03_L204
M03_L95:
       mov       rcx,r14
       call      qword ptr [7FFC6285E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M03_L48
M03_L96:
       mov       eax,26
       jmp       near ptr M03_L51
M03_L97:
       mov       rcx,r13
       test      rcx,rcx
       je        short M03_L98
       mov       rdx,offset MT_System.Linq.Expressions.PropertyExpression
       cmp       [rcx],rdx
       jne       near ptr M03_L142
M03_L98:
       mov       rax,offset MT_System.Linq.Expressions.PropertyExpression
       cmp       [rcx],rax
       jne       near ptr M03_L143
       mov       rdx,[rcx+10]
M03_L99:
       mov       rcx,rdx
       test      rcx,rcx
       je        short M03_L100
       mov       rax,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rcx],rax
       jne       near ptr M03_L144
M03_L100:
       test      rcx,rcx
       je        near ptr M03_L52
       mov       rax,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rcx],rax
       jne       near ptr M03_L145
       cmp       qword ptr [rcx+18],0
       jne       near ptr M03_L52
       jmp       near ptr M03_L146
M03_L101:
       mov       rcx,[rbp-0C8]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        near ptr M03_L162
       call      qword ptr [7FFC6285C9A8]; System.Object.GetType()
       mov       r13,rax
       jmp       near ptr M03_L62
M03_L102:
       cmp       [r13],r12
       jne       near ptr M03_L63
       cmp       r13,r15
       jne       short M03_L103
       mov       r12d,1
       jmp       near ptr M03_L64
M03_L103:
       mov       [rbp-0D0],r15
       mov       [rbp-0E8],r13
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0E0],xmm0
       lea       rcx,[rbp-0D0]
       mov       [rbp-0E0],rcx
       mov       rcx,[rbp-0D0]
       test      rcx,rcx
       je        near ptr M03_L163
       mov       rcx,[rcx+18]
M03_L104:
       mov       [rbp-0D8],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0F8],xmm0
       lea       rcx,[rbp-0E8]
       mov       [rbp-0F8],rcx
       mov       rcx,[rbp-0E8]
       test      rcx,rcx
       je        near ptr M03_L164
       mov       rcx,[rcx+18]
M03_L105:
       mov       [rbp-0F0],rcx
       vmovups   xmm0,[rbp-0E0]
       vmovups   [rbp-198],xmm0
       vmovups   xmm0,[rbp-0F8]
       vmovups   [rbp-1A8],xmm0
       lea       rcx,[rbp-198]
       lea       rdx,[rbp-1A8]
       call      00007FFC63501170
       cmp       eax,1
       sete      r12b
       movzx     r12d,r12b
       jmp       near ptr M03_L64
M03_L106:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       jne       near ptr M03_L167
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       jne       near ptr M03_L167
       mov       r12,offset MT_System.RuntimeType
       cmp       [r15],r12
       jne       near ptr M03_L166
       mov       rcx,r15
       mov       rdx,r13
       call      qword ptr [7FFC6279A610]; System.RuntimeType.IsAssignableFrom(System.Type)
M03_L107:
       test      eax,eax
       jne       near ptr M03_L65
       jmp       near ptr M03_L167
M03_L108:
       mov       rcx,[rbp-260]
       call      qword ptr [7FFC6285E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M03_L74
M03_L109:
       mov       r11,[rcx]
       mov       r11,[r11+40]
       call      qword ptr [r11+10]
       mov       r11d,eax
       jmp       near ptr M03_L77
M03_L110:
       cmp       r8,[rcx+18]
       jne       short M03_L111
       mov       r8,[rcx+20]
       mov       [rbp-168],r8
       jmp       near ptr M03_L85
M03_L111:
       xor       r8d,r8d
       mov       [rbp-168],r8
       jmp       near ptr M03_L85
M03_L112:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC632850F8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L113:
       mov       rcx,rsi
       mov       r11,7FFC63E72B08
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M03_L01
M03_L114:
       mov       rcx,1BA086845E0
       mov       rax,[7FFC6279A1E0]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M03_L04
       mov       rcx,1BA086845E0
       mov       rax,[7FFC6279A1E8]
       call      qword ptr [rax+18]
       mov       rcx,1BA0867E418
       cmp       rax,rcx
       jne       near ptr M03_L04
       mov       rcx,1BA086845E0
       mov       rax,[7FFC6279A1E8]
       call      qword ptr [rax+28]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M03_L201
       mov       rcx,[rax+10]
       jmp       near ptr M03_L05
M03_L115:
       lea       rcx,[rbp-50]
       call      qword ptr [7FFC63287918]
       jmp       near ptr M03_L26
M03_L116:
       mov       ecx,0B80
       mov       rdx,7FFC62B71930
       call      qword ptr [7FFC62A77798]
       mov       rcx,rax
       call      qword ptr [7FFC62D77228]
       int       3
M03_L117:
       mov       rdx,1BA08684C40
       mov       [rbp-88],rdx
       mov       [rbp-80],r13
       xor       edx,edx
       mov       [rbp-78],rdx
       lea       rdx,[rbp-88]
       mov       r11,7FFC63E72B18
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M03_L16
M03_L118:
       mov       r8,[rbp-218]
       jmp       near ptr M03_L44
M03_L119:
       mov       rdx,[rax+10]
       mov       ecx,r13d
       imul      rcx,[rax+28]
       shr       rcx,20
       inc       rcx
       mov       r11d,[rdx+8]
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M03_L201
       mov       ecx,ecx
       mov       r10,[rdx+rcx*8+10]
       test      r10,r10
       je        near ptr M03_L45
M03_L120:
       cmp       r13d,[r10+18]
       jne       short M03_L121
       mov       rdx,1BA08684C40
       mov       [rbp-68],rdx
       mov       [rbp-60],r15
       xor       edx,edx
       mov       [rbp-58],rdx
       mov       [rbp-210],r10
       vmovdqu   xmm0,xmmword ptr [r10+20]
       vmovdqu   xmmword ptr [rbp-188],xmm0
       mov       rdx,[r10+30]
       mov       [rbp-178],rdx
       lea       rdx,[rbp-188]
       lea       r8,[rbp-68]
       mov       rcx,[rbp-208]
       mov       r11,7FFC63E72B20
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rbp-210]
       jne       short M03_L122
M03_L121:
       mov       r10,[r10+10]
       test      r10,r10
       jne       short M03_L120
       jmp       near ptr M03_L45
M03_L122:
       mov       rdx,[r10+8]
       mov       [rbp-70],rdx
       jmp       near ptr M03_L21
M03_L123:
       cmp       dword ptr [r14+8],0
       jbe       near ptr M03_L201
       mov       r13,[r14+10]
       jmp       near ptr M03_L23
M03_L124:
       movzx     r14d,byte ptr [r13+10]
       jmp       near ptr M03_L25
M03_L125:
       mov       rcx,r15
       mov       rdx,1BA08675F30
       call      qword ptr [7FFC6279A608]; System.RuntimeType.IsSubclassOf(System.Type)
       jmp       near ptr M03_L24
M03_L126:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+70]
       call      qword ptr [rax+30]
       jmp       near ptr M03_L24
M03_L127:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        near ptr M03_L25
M03_L128:
       mov       r14d,1
       jmp       near ptr M03_L25
M03_L129:
       mov       rcx,rsi
       mov       r11,7FFC63E72B10
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M03_L27
M03_L130:
       mov       ecx,2C61
       mov       rdx,7FFC62FE4578
       call      qword ptr [7FFC62A77798]
       mov       rcx,rax
       call      qword ptr [7FFC638CFC60]
       int       3
M03_L131:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax+28]
       jmp       near ptr M03_L28
M03_L132:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M03_L133
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1BA08682968
       call      qword ptr [7FFC6394D188]
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FFC6394D1A0]
       mov       rdx,rax
       mov       rcx,r15
       mov       r8,1BA08674D10
       call      qword ptr [7FFC62BD6370]
       jmp       short M03_L134
M03_L133:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1BA086829C0
       call      qword ptr [7FFC6394D188]
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FFC6394D1A0]
       mov       rdx,rax
       mov       rcx,r15
       mov       r8,1BA08674D10
       call      qword ptr [7FFC62BD6370]
M03_L134:
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M03_L135:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M03_L48
M03_L136:
       mov       rdx,r14
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M03_L49
M03_L137:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       [rbp-220],rax
       mov       rcx,r14
       mov       rdx,[r14]
       mov       rdx,[rdx+50]
       call      qword ptr [rdx]
       test      eax,eax
       jne       short M03_L139
       mov       rcx,r15
       mov       rdx,r14
       mov       r8,[rbp-220]
       call      qword ptr [7FFC630273D8]; System.Dynamic.Utils.CacheDict`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon)
       mov       r15,[rbp-220]
       jmp       near ptr M03_L50
M03_L138:
       mov       ecx,2C61
       mov       rdx,7FFC62FE4578
       call      qword ptr [7FFC62A77798]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFC6394EC40]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L139:
       mov       r15,[rbp-220]
       jmp       near ptr M03_L50
M03_L140:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       ecx,2E81
       mov       rdx,7FFC62FE4578
       call      qword ptr [7FFC62A77798]
       mov       rcx,rax
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC6394C7F8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFC62BD5B78]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M03_L141:
       mov       rdx,r13
       mov       rcx,offset MT_System.Linq.Expressions.IndexExpression
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       cmp       qword ptr [rax+18],0
       je        near ptr M03_L52
       mov       rcx,[rax+18]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       near ptr M03_L52
       jmp       short M03_L146
M03_L142:
       mov       rdx,r13
       mov       rcx,offset MT_System.Linq.Expressions.MemberExpression
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M03_L98
M03_L143:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdx,rax
       jmp       near ptr M03_L99
M03_L144:
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M03_L100
M03_L145:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       near ptr M03_L52
M03_L146:
       mov       ecx,2E81
       mov       rdx,7FFC62FE4578
       call      qword ptr [7FFC62A77798]
       mov       rcx,rax
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC6394C810]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L147:
       cmp       dword ptr [r15+2C],0FFFFFFFF
       jne       short M03_L148
       mov       rcx,[r15+30]
       mov       rdx,[rcx+18]
       jmp       short M03_L149
M03_L148:
       mov       rdx,[r15+30]
       mov       rcx,[rdx+8]
       mov       edx,[r15+2C]
       cmp       edx,[rcx+8]
       jae       near ptr M03_L201
       mov       rdx,[rcx+rdx*8+10]
M03_L149:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L53
M03_L150:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M03_L54
M03_L151:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+58]
       call      qword ptr [rax+18]
       test      eax,eax
       je        near ptr M03_L55
M03_L152:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r15,rax
       jmp       near ptr M03_L55
M03_L153:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r13,rax
       jmp       near ptr M03_L56
M03_L154:
       mov       eax,1
       jmp       near ptr M03_L58
M03_L155:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       jmp       near ptr M03_L58
M03_L156:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       r13,rax
       jmp       near ptr M03_L59
M03_L157:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFC639441B0]
       mov       r8,rax
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFC6355F2B8]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M03_L158:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       jmp       near ptr M03_L60
M03_L159:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       short M03_L160
       mov       rcx,1BA08674D10
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC6394D170]
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,1BA086823A0
       call      qword ptr [7FFC6394D188]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFC6394D1A0]
       mov       rdx,rax
       mov       rcx,r14
       mov       r8,r12
       call      qword ptr [7FFC62BD6370]
       jmp       short M03_L161
M03_L160:
       mov       rcx,1BA08674D10
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC6394D170]
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1BA086823F0
       call      qword ptr [7FFC6394D188]
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFC6394D1A0]
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8,r14
       call      qword ptr [7FFC62BD6370]
       mov       r14,rdi
M03_L161:
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M03_L162:
       mov       r13,1BA086719B8
       jmp       near ptr M03_L62
M03_L163:
       xor       ecx,ecx
       jmp       near ptr M03_L104
M03_L164:
       xor       ecx,ecx
       jmp       near ptr M03_L105
M03_L165:
       mov       rcx,r15
       mov       rdx,r13
       mov       rax,[r15]
       mov       rax,[rax+0A0]
       call      qword ptr [rax+10]
       mov       r12d,eax
       jmp       near ptr M03_L64
M03_L166:
       mov       rcx,r15
       mov       rdx,r13
       mov       rax,[r15]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+20]
       jmp       near ptr M03_L107
M03_L167:
       lea       rdx,[rbp-0C8]
       mov       rcx,r15
       call      qword ptr [7FFC6394FD68]
       test      eax,eax
       jne       near ptr M03_L65
       mov       rcx,[rbp-0C8]
       mov       rax,[rbp-0C8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rdi,rax
       mov       ecx,2E81
       mov       rdx,7FFC62FE4578
       call      qword ptr [7FFC62A77798]
       mov       r9,rax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       r8,r14
       mov       rdx,r15
       call      qword ptr [7FFC6394FDB0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L168:
       xor       r15d,r15d
       jmp       near ptr M03_L66
M03_L169:
       mov       rcx,offset MT_System.Linq.Expressions.ConstantExpression
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       jmp       near ptr M03_L67
M03_L170:
       mov       rcx,rsi
       mov       r11,7FFC63E72B30
       call      qword ptr [r11]
       mov       r14,rax
       mov       rcx,rsi
       mov       r11,7FFC63E72B38
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M03_L68
M03_L171:
       mov       rcx,17989800190
       mov       rsi,[rcx]
       lea       rcx,[r15+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       near ptr M03_L69
M03_L172:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFC63035C30]; Precode of LinqToDB.Internal.Mapping.LockedMappingSchema.GenerateID()
       mov       r13d,eax
       mov       byte ptr [r14+50],1
       mov       [r14+54],r13d
       jmp       near ptr M03_L70
M03_L173:
       mov       rcx,r14
       mov       r11,7FFC63E72B48
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M03_L70
M03_L174:
       mov       rcx,offset MT_System.Func<LinqToDB.Internal.Cache.ICacheEntry<System.ValueTuple<System.Type, System.Int32>, LinqToDB.Mapping.EntityDescriptor>, System.ValueTuple<LinqToDB.Mapping.MappingSchema, System.Action<LinqToDB.Mapping.MappingSchema, LinqToDB.Mapping.IEntityChangeDescriptor>>, LinqToDB.Mapping.EntityDescriptor>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,179898002D0
       mov       rdx,[rdx]
       mov       rcx,r12
       mov       r8,offset LinqToDB.Mapping.MappingSchema+<>c.<GetEntityDescriptor>b__99_0(LinqToDB.Internal.Cache.ICacheEntry`2<System.ValueTuple`2<System.Type,Int32>,LinqToDB.Mapping.EntityDescriptor>, System.ValueTuple`2<LinqToDB.Mapping.MappingSchema,System.Action`2<LinqToDB.Mapping.MappingSchema,LinqToDB.Mapping.IEntityChangeDescriptor>>)
       call      qword ptr [7FFC62856BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,17989800370
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L71
M03_L175:
       mov       rcx,1BA08684630
       call      qword ptr [7FFC6394C918]
       int       3
M03_L176:
       lea       rdx,[rbp-110]
       mov       r11,7FFC63E72B70
       call      qword ptr [r11]
       jmp       near ptr M03_L72
M03_L177:
       xor       r8d,r8d
       jmp       near ptr M03_L75
M03_L178:
       mov       rcx,r8
       mov       r8,[r8]
       mov       r8,[r8+40]
       call      qword ptr [r8+18]
       mov       r8d,eax
       jmp       near ptr M03_L75
M03_L179:
       mov       [rbp-258],r8
M03_L180:
       mov       r8,[rbp-258]
       mov       r8,[r8+10]
       test      r8,r8
       mov       eax,[rbp-130]
       jne       near ptr M03_L76
       jmp       near ptr M03_L89
M03_L181:
       test      rdx,rdx
       jne       short M03_L180
       jmp       near ptr M03_L78
M03_L182:
       mov       [rbp-238],rax
       jmp       near ptr M03_L189
M03_L183:
       vmovdqu   xmm0,xmmword ptr [rbp-128]
       vmovdqu   xmmword ptr [rbp-148],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-148]
       vmovdqu   xmmword ptr [rbp-1B8],xmm0
       lea       rdx,[rbp-1B8]
       mov       rcx,r8
       mov       r11,7FFC63E72B80
       call      qword ptr [r11]
       mov       [rbp-12C],eax
       mov       r8,[rbp-240]
       mov       rdx,[r8+10]
       mov       ecx,eax
       imul      rcx,[r8+28]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       imul      r8,rcx
       shr       r8,20
       cmp       r8d,[rdx+8]
       jae       near ptr M03_L201
       mov       r8d,r8d
       mov       r10,[rdx+r8*8+10]
       test      r10,r10
       je        near ptr M03_L89
M03_L184:
       cmp       eax,[r10+18]
       jne       short M03_L185
       mov       [rbp-250],r10
       vmovdqu   xmm0,xmmword ptr [r10+20]
       vmovdqu   xmmword ptr [rbp-1B8],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-128]
       vmovdqu   xmmword ptr [rbp-1C8],xmm0
       lea       r8,[rbp-1C8]
       lea       rdx,[rbp-1B8]
       mov       rcx,[rbp-248]
       mov       r11,7FFC63E72B78
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rbp-250]
       jne       short M03_L186
M03_L185:
       mov       r10,[r10+10]
       test      r10,r10
       mov       eax,[rbp-12C]
       jne       short M03_L184
       jmp       near ptr M03_L89
M03_L186:
       mov       rax,[r10+8]
       jmp       near ptr M03_L79
M03_L187:
       vmovups   xmm0,[rbp-110]
       vmovups   [rbp-1D8],xmm0
       lea       rdx,[rbp-1D8]
       lea       rcx,[rbp-158]
       call      qword ptr [7FFC6328C1E0]
       test      eax,eax
       je        near ptr M03_L80
       mov       rax,[rbp-238]
M03_L188:
       mov       [rbp-238],rax
       mov       rcx,rax
       mov       edx,3
       call      qword ptr [7FFC6328C0A8]
M03_L189:
       mov       rax,[rbp-238]
       cmp       dword ptr [rax+4C],2
       je        short M03_L190
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFC632841C8]
       jmp       near ptr M03_L89
M03_L190:
       mov       [rbp-238],rax
       jmp       near ptr M03_L82
M03_L191:
       mov       ecx,4
       call      qword ptr [7FFC638CFF00]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r10,rax
       jmp       near ptr M03_L83
M03_L192:
       xor       r8d,r8d
       jmp       near ptr M03_L86
M03_L193:
       lea       r8,[rbp-168]
       mov       rdx,[rbp-270]
       mov       r11,7FFC63E72B88
       call      qword ptr [r11]
       jmp       near ptr M03_L85
M03_L194:
       mov       rdx,r8
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L195:
       mov       rcx,179898012D8
       mov       r8,[rcx]
       mov       r10,r8
       mov       [rbp-268],r10
       mov       rcx,179898012D0
       mov       rcx,[rcx]
       mov       rdx,r10
       call      qword ptr [7FFC63284540]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       r10,[rbp-268]
       jmp       near ptr M03_L88
M03_L196:
       mov       ecx,[rbp-110]
       mov       [r15+38],ecx
       mov       rcx,[rbp-108]
       mov       [r15+40],rcx
       mov       rcx,17973800C00
       mov       rax,[rcx]
       mov       [rbp-278],rax
       mov       rcx,offset MT_LinqToDB.Internal.Cache.MemoryCache<System.ValueTuple<System.Type, System.Int32>, LinqToDB.Mapping.EntityDescriptor>+<>c
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,17989803A08
       mov       rax,[rcx]
       test      rax,rax
       mov       [rbp-280],rax
       jne       near ptr M03_L197
       mov       rcx,offset MT_System.Action<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-288],rax
       mov       rcx,offset MT_LinqToDB.Internal.Cache.MemoryCache<System.ValueTuple<System.Type, System.Int32>, LinqToDB.Mapping.EntityDescriptor>+<>c
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,17989803A00
       mov       rdx,[rdx]
       mov       rcx,[rbp-288]
       mov       r8,7FFC63280300
       call      qword ptr [7FFC62856BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,offset MT_LinqToDB.Internal.Cache.MemoryCache<System.ValueTuple<System.Type, System.Int32>, LinqToDB.Mapping.EntityDescriptor>+<>c
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,17989803A08
       mov       rdx,[rbp-288]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-288]
       mov       [rbp-280],rax
M03_L197:
       mov       rcx,offset MT_System.Threading.Tasks.TaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,17989803A38
       mov       rdx,[rdx]
       mov       [rsp+28],rdx
       mov       rdx,[rbp-280]
       mov       r8,r15
       mov       rcx,[rbp-278]
       xor       r9d,r9d
       mov       dword ptr [rsp+20],8
       call      qword ptr [7FFC63284390]
       jmp       near ptr M03_L90
M03_L198:
       mov       rdx,1BA086845E0
       mov       [rbp-1B8],rdx
       mov       [rbp-1B0],r13d
       lea       rdx,[rbp-1B8]
       mov       rcx,r15
       mov       r11,7FFC63E72B58
       call      qword ptr [r11]
       mov       [rbp-230],rax
       mov       [rbp-1E8],r14
       mov       [rbp-1E0],rsi
       lea       r8,[rbp-1E8]
       mov       rdx,[rbp-230]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       [rbp-100],rax
       mov       rcx,[rbp-230]
       mov       rdx,[rbp-100]
       mov       r11,7FFC63E72B60
       call      qword ptr [r11]
       nop
       mov       rcx,[rbp-230]
       mov       r11,7FFC63E72B68
       call      qword ptr [r11]
       jmp       near ptr M03_L91
M03_L199:
       mov       rdx,[rdi+8]
       mov       r8d,esi
       mov       rcx,offset MT_LinqToDB.Internal.Linq.Table<DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TestDbEntity>
       call      qword ptr [7FFC63555C38]
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+48],esi
       jmp       near ptr M03_L92
M03_L200:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-40]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFC63EC7240]
       mov       rdx,rax
       lea       rcx,[rbp-48]
       call      qword ptr [7FFC63EC7258]
       jmp       short M03_L205
M03_L201:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L202:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L93
M03_L203:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFC6394F570]
       jmp       near ptr M03_L94
M03_L204:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L206
       mov       rdx,17973800C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L205:
       nop
       add       rsp,2A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L206:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFC63B05FB0]
       jmp       short M03_L205
       sub       rsp,48
       vzeroupper
       cmp       qword ptr [rbp-230],0
       je        short M03_L207
       mov       rcx,[rbp-230]
       mov       r11,7FFC63E72B68
       call      qword ptr [r11]
M03_L207:
       nop
       add       rsp,48
       ret
       sub       rsp,48
       vzeroupper
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFC635F6E50]
       lea       rax,[M03_L205]
       add       rsp,48
       ret
; Total bytes of code 7896
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFCC22C1D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.HashCode.Combine[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark.HasRecordsWithPredicateAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFC62A5FDE0]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFC635C6838]; DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<HasRecordsWithPredicateAsync>d__12.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFC64224300]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFC6390CAC8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFC63DD7408]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFC64224300]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62E56790]; System.Threading.Tasks.Task.GetAwaiter()
       mov       [rbp-8],rax
       lea       rcx,[rbp-8]
       call      qword ptr [7FFC62E567A8]; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 53
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFCC22A9030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.HashCode.Combine[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFCC22A9038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFCC22AAEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFCC22A8FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<HasRecordsWithPredicateAsync>d__12.MoveNext()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,188
       vzeroupper
       lea       rbp,[rsp+1C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0E0],ymm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L158
       mov       rsi,[rbx+1A8]
       test      rsi,rsi
       je        near ptr M03_L84
       mov       rdi,2ABC64045E0
       mov       r14,2ABC64045E0
M03_L00:
       mov       rax,offset MT_System.RuntimeType
       cmp       [r14],rax
       jne       near ptr M03_L87
       mov       rax,[r14+18]
       mov       rcx,rax
       call      00007FFC634D10E0
       movzx     ecx,al
       cmp       ecx,1D
       ja        short M03_L01
       mov       eax,1FEF7FFF
       bt        eax,ecx
       jae       near ptr M03_L86
M03_L01:
       cmp       ecx,10
       sete      r15b
       movzx     r15d,r15b
M03_L02:
       test      r15d,r15d
       jne       near ptr M03_L85
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r14],rcx
       jne       near ptr M03_L88
M03_L03:
       test      r14,r14
       je        near ptr M03_L89
       mov       rcx,r14
       call      00007FFCC2489400
       test      eax,eax
       jne       near ptr M03_L90
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TestDbEntity
       call      00007FFC634D10E0
       movzx     ecx,al
       mov       rax,2ABC64045E0
       cmp       ecx,0F
       je        near ptr M03_L127
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TestDbEntity
       call      00007FFC634D10E0
       movzx     ecx,al
       mov       rax,2ABC64045E0
       cmp       ecx,10
       sete      r14b
       movzx     r14d,r14b
       test      r14d,r14d
       jne       near ptr M03_L93
M03_L04:
       mov       rcx,rdi
       mov       r8d,r14d
       mov       rdx,2ABC640C628
       call      qword ptr [7FFC63006B08]; System.Linq.Expressions.ParameterExpression.Make(System.Type, System.String, Boolean)
       mov       rdi,rax
       mov       rcx,7FFC62B51458
       call      qword ptr [7FFC63004408]; System.RuntimeMethodInfoStub.FromPtr(IntPtr)
       mov       r14,rax
       test      r14,r14
       je        near ptr M03_L94
       mov       rcx,r14
       mov       r11,7FFC63E63568
       call      qword ptr [r11]
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFC6283FC48]; System.RuntimeType.GetMethodBase(System.RuntimeType, System.RuntimeMethodHandleInternal)
       mov       r15,rax
       test      r15,r15
       je        near ptr M03_L95
       mov       r14,[r15]
       mov       r13,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       r14,r13
       jne       near ptr M03_L97
       mov       rcx,[r15+8]
       cmp       byte ptr [rcx+9C],0
       jne       near ptr M03_L96
       mov       r13,[r15+38]
M03_L05:
       test      r13,r13
       je        short M03_L08
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M03_L99
       mov       rcx,[r13+18]
       test      cl,2
       jne       near ptr M03_L98
       test      dword ptr [rcx],80000000
       jne       near ptr M03_L23
       test      byte ptr [rcx],30
       setne     cl
       movzx     ecx,cl
M03_L06:
       movzx     r14d,cl
M03_L07:
       test      r14d,r14d
       jne       near ptr M03_L100
M03_L08:
       mov       r14,r15
       test      r14,r14
       je        short M03_L09
       mov       rdx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [r14],rdx
       jne       near ptr M03_L101
M03_L09:
       test      r14,r14
       je        near ptr M03_L102
       mov       rcx,[r14]
       mov       r15,rcx
       mov       r13,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       r15,r13
       jne       near ptr M03_L103
       mov       rcx,r14
       call      qword ptr [7FFC62979D90]; System.Reflection.RuntimeMethodInfo.get_ContainsGenericParameters()
M03_L10:
       test      eax,eax
       jne       near ptr M03_L104
       mov       rcx,r14
       mov       rax,[r15+40]
       call      qword ptr [rax+38]
       mov       r12,rax
       test      r12,r12
       je        near ptr M03_L117
       cmp       r15,r13
       jne       near ptr M03_L24
       mov       r13d,[r14+5C]
M03_L11:
       mov       edx,8
       mov       ecx,4
       test      r13b,10
       cmove     edx,ecx
       or        edx,30
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       r13,rax
       xor       r12d,r12d
       jmp       near ptr M03_L19
M03_L12:
       mov       [rbp-0E8],r8
       mov       rcx,r10
       mov       [rbp-108],r10
       mov       rdx,[r10]
       mov       rdx,[rdx+70]
       call      qword ptr [rdx+18]
       test      al,20
       jne       near ptr M03_L111
M03_L13:
       mov       rcx,r15
       mov       rax,[r15]
       mov       [rbp-0F0],rax
       mov       rdx,[rax+50]
       call      qword ptr [rdx+30]
       test      eax,eax
       je        near ptr M03_L18
       mov       rcx,r15
       mov       edx,1
       mov       rax,[rbp-0F0]
       mov       rax,[rax+58]
       call      qword ptr [rax+18]
       mov       [rbp-110],rax
       mov       rcx,[r14]
       mov       r8,rcx
       mov       r10,offset MT_System.Reflection.RuntimeMethodInfo
       mov       rcx,r10
       cmp       r8,rcx
       jne       near ptr M03_L112
       test      rax,rax
       je        short M03_L14
       cmp       [rax],rcx
       jne       short M03_L14
       mov       rcx,[r14+50]
       cmp       rcx,[rax+50]
       jne       short M03_L14
       mov       rcx,[r14+38]
       cmp       rcx,[rax+38]
       jne       short M03_L14
       mov       rcx,[r14+8]
       mov       rcx,[rcx+8]
       mov       rdx,[rax+8]
       cmp       rcx,[rdx+8]
       je        near ptr M03_L25
M03_L14:
       mov       rcx,[r14+8]
       cmp       byte ptr [rcx+9C],0
       jne       near ptr M03_L113
       mov       r10,[r14+38]
M03_L15:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r10],rcx
       je        short M03_L16
       mov       [rbp-0E8],r8
       mov       rcx,r10
       mov       [rbp-118],r10
       mov       rdx,[r10]
       mov       rdx,[rdx+70]
       call      qword ptr [rdx+18]
       test      al,20
       je        short M03_L18
       jmp       near ptr M03_L116
M03_L16:
       mov       rcx,[r10+18]
       test      cl,2
       jne       near ptr M03_L115
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
M03_L17:
       mov       [rbp-118],r10
       test      ecx,ecx
       mov       [rbp-0E8],r8
       jne       near ptr M03_L116
M03_L18:
       inc       r12d
M03_L19:
       mov       ecx,[r13+8]
       cmp       ecx,r12d
       jle       near ptr M03_L117
       cmp       r12d,ecx
       jae       near ptr M03_L157
       mov       r15,[r13+r12*8+10]
       mov       rcx,r15
       mov       rax,[r15]
       mov       [rbp-0F0],rax
       mov       rdx,[rax+50]
       call      qword ptr [rdx+28]
       test      eax,eax
       je        near ptr M03_L13
       mov       rcx,r15
       mov       edx,1
       mov       rax,[rbp-0F0]
       mov       rax,[rax+58]
       call      qword ptr [rax+8]
       mov       [rbp-100],rax
       mov       rcx,[r14]
       mov       r8,rcx
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       mov       r10,rcx
       cmp       r8,r10
       jne       near ptr M03_L107
       test      rax,rax
       je        short M03_L20
       cmp       [rax],r10
       jne       short M03_L20
       mov       rcx,[r14+50]
       cmp       rcx,[rax+50]
       jne       short M03_L20
       mov       rcx,[r14+38]
       cmp       rcx,[rax+38]
       jne       short M03_L20
       mov       rcx,[r14+8]
       mov       rcx,[rcx+8]
       mov       rdx,[rax+8]
       cmp       rcx,[rdx+8]
       je        near ptr M03_L25
M03_L20:
       mov       rcx,[r14+8]
       cmp       byte ptr [rcx+9C],0
       jne       near ptr M03_L108
       mov       r10,[r14+38]
M03_L21:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r10],rcx
       jne       near ptr M03_L12
       mov       rcx,[r10+18]
       test      cl,2
       jne       near ptr M03_L110
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
M03_L22:
       mov       [rbp-108],r10
       test      ecx,ecx
       mov       [rbp-0E8],r8
       je        near ptr M03_L13
       jmp       near ptr M03_L111
M03_L23:
       xor       ecx,ecx
       jmp       near ptr M03_L06
M03_L24:
       mov       rcx,r14
       mov       rax,[r15+50]
       call      qword ptr [rax+20]
       mov       r13d,eax
       jmp       near ptr M03_L11
M03_L25:
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FFC6300C678]; System.Linq.Expressions.Expression.Property(System.Linq.Expressions.Expression, System.Reflection.PropertyInfo)
       mov       r14,rax
       mov       r15,2ABC63F0020
M03_L26:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M03_L120
       mov       rcx,[r15+18]
       call      00007FFC634D10E0
       movzx     ecx,al
       cmp       ecx,1D
       ja        short M03_L27
       mov       eax,1FEF7FFF
       bt        eax,ecx
       jae       near ptr M03_L119
M03_L27:
       cmp       ecx,10
       sete      r13b
       movzx     r13d,r13b
M03_L28:
       test      r13d,r13d
       jne       near ptr M03_L118
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       jne       near ptr M03_L121
M03_L29:
       test      r15,r15
       je        near ptr M03_L122
       mov       rcx,r15
       call      00007FFCC2489400
       test      eax,eax
       jne       near ptr M03_L123
       mov       rcx,offset MT_System.String
       call      00007FFC634D10E0
       movzx     ecx,al
       mov       rax,2ABC63F0020
       cmp       ecx,10
       je        near ptr M03_L126
       mov       rcx,offset MT_System.String
       call      00007FFC634D10E0
       movzx     ecx,al
       mov       rax,2ABC63F0020
       cmp       ecx,0F
       je        near ptr M03_L127
       mov       rcx,offset MT_System.Linq.Expressions.ConstantExpression
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,2ABC6400428
       mov       [r15+8],rcx
       test      r14,r14
       je        near ptr M03_L128
       mov       rcx,offset MT_System.Linq.Expressions.PropertyExpression
       cmp       [r14],rcx
       jne       near ptr M03_L129
       mov       rdx,[r14+10]
M03_L30:
       mov       rcx,rdx
       test      rcx,rcx
       je        short M03_L31
       mov       rax,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rcx],rax
       jne       near ptr M03_L130
M03_L31:
       test      rcx,rcx
       je        short M03_L32
       mov       rax,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rcx],rax
       jne       near ptr M03_L131
       cmp       qword ptr [rcx+18],0
       je        near ptr M03_L132
M03_L32:
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       r8,r14
       mov       r9,r15
       mov       ecx,0D
       mov       rdx,2ABC6402B30
       call      qword ptr [7FFC6300CFD8]; System.Linq.Expressions.Expression.GetEqualityComparisonOperator(System.Linq.Expressions.ExpressionType, System.String, System.Linq.Expressions.Expression, System.Linq.Expressions.Expression, Boolean)
       mov       r14,rax
       mov       rcx,offset MT_System.Linq.Expressions.ParameterExpression[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-50],r14
       mov       rdx,26B31402688
       cmp       r15,[rdx]
       je        near ptr M03_L136
       mov       edx,1
       mov       rcx,offset MT_System.Linq.Expressions.ParameterExpression[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,[r15]
       cmp       dword ptr [rcx+4],18
       jne       near ptr M03_L135
       cmp       dword ptr [r15+8],0
       je        near ptr M03_L135
       cmp       dword ptr [rdi+8],0
       je        near ptr M03_L135
       movzx     r8d,word ptr [rcx]
       lea       rdx,[r15+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M03_L63
       cmp       r8,4000
       ja        near ptr M03_L134
       mov       rcx,rax
       call      00007FFCC24537A0
       cmp       dword ptr [7FFCC2793A90],0
       jne       near ptr M03_L133
M03_L33:
       mov       rcx,offset MT_System.Runtime.CompilerServices.TrueReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M03_L34:
       lea       rdx,[rbp-50]
       mov       r8,r14
       mov       rcx,2ABC640C650
       mov       r9,2ABC6402510
       call      qword ptr [7FFC630070D8]; System.Linq.Expressions.Expression.ValidateLambdaArgs(System.Type, System.Linq.Expressions.Expression ByRef, System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>, System.String)
       mov       [rsp+20],r14
       mov       rdx,[rbp-50]
       mov       rcx,offset MT_System.Linq.Expressions.Expression<System.Func<DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TestDbEntity, System.Boolean>>
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFC63007180]; System.Linq.Expressions.Expression`1[[System.__Canon, System.Private.CoreLib]].Create(System.Linq.Expressions.Expression, System.String, Boolean, System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.ParameterExpression>)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M03_L137
       mov       rcx,offset MT_LinqToDB.Internal.Linq.Table<DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TestDbEntity>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TempFileDataContext
       cmp       [rsi],rcx
       jne       near ptr M03_L138
       mov       r15,[rsi+28]
M03_L35:
       cmp       [r15],r15b
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TestDbEntity
       test      dword ptr [rcx],80000000
       jne       near ptr M03_L64
       test      byte ptr [rcx],30
       setne     cl
       movzx     ecx,cl
M03_L36:
       mov       rax,2ABC64045E0
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M03_L139
M03_L37:
       xor       ecx,ecx
M03_L38:
       mov       rdx,2ABC64045E0
       test      rcx,rcx
       cmove     rcx,rdx
       mov       r13,rcx
       mov       r12,[r15+10]
       xor       eax,eax
       cmp       dword ptr [r12+8],0
       jle       short M03_L40
M03_L39:
       mov       [rbp-0F8],rax
       mov       rcx,[r12+rax*8+10]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFC6325C2D0]; LinqToDB.Internal.Mapping.MappingSchemaInfo.GetScalarType(System.Type)
       mov       [rbp-58],ax
       cmp       byte ptr [rbp-58],0
       jne       near ptr M03_L140
       mov       rcx,[rbp-0F8]
       inc       ecx
       cmp       [r12+8],ecx
       mov       rax,rcx
       jg        short M03_L39
M03_L40:
       mov       rcx,[r15+28]
       mov       r15,[rcx+10]
       mov       r12,r13
       mov       rax,[rcx+8]
       mov       [rbp-120],rax
       cmp       [r15],r15b
       test      rax,rax
       je        near ptr M03_L141
       mov       rdx,[r15+8]
       mov       [rbp-128],rdx
       mov       rcx,[rdx+8]
       test      rcx,rcx
       jne       near ptr M03_L142
       mov       rcx,2ABC6404C40
       mov       [rbp-0A0],rcx
       xor       ecx,ecx
       mov       [rbp-0A8],rcx
       lea       rcx,[rbp-0A0]
       cmp       qword ptr [rbp-0A8],0
       jne       short M03_L41
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       lea       rcx,[rbp-0A8]
       cmp       qword ptr [rbp-0A8],0
       je        near ptr M03_L65
M03_L41:
       mov       r8,[rcx]
       mov       [rbp-130],r8
       mov       rcx,offset MT_System.Linq.Expressions.TypedParameterExpression
       cmp       [r8],rcx
       je        near ptr M03_L66
       mov       rcx,r8
       mov       r8,[r8]
       mov       r8,[r8+40]
       call      qword ptr [r8+18]
       mov       r8d,eax
M03_L42:
       xor       ecx,ecx
       mov       [rbp-0A8],rcx
       imul      eax,r8d,0A5555529
       mov       [rbp-94],eax
       mov       [rbp-0B0],r12
       mov       [rbp-0B8],rcx
       lea       rcx,[rbp-0B0]
       cmp       qword ptr [rbp-0B8],0
       jne       short M03_L43
       mov       rcx,[rbp-0B0]
       mov       [rbp-0B8],rcx
       lea       rcx,[rbp-0B8]
       cmp       qword ptr [rbp-0B8],0
       je        near ptr M03_L69
M03_L43:
       mov       r12,[rcx]
       mov       rcx,offset MT_System.Linq.Expressions.TypedParameterExpression
       cmp       [r12],rcx
       je        near ptr M03_L70
       mov       rcx,r12
       mov       rdx,[r12]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+18]
       mov       r12d,eax
M03_L44:
       xor       ecx,ecx
       mov       [rbp-0B8],rcx
       imul      r12d,0A5555529
       mov       [rbp-0C0],rcx
       mov       [rbp-0C8],rcx
       lea       rcx,[rbp-0C0]
       cmp       qword ptr [rbp-0C8],0
       jne       short M03_L45
       mov       rcx,[rbp-0C0]
       mov       [rbp-0C8],rcx
       lea       rcx,[rbp-0C8]
       cmp       qword ptr [rbp-0C8],0
       je        near ptr M03_L73
M03_L45:
       mov       rax,[rcx]
       mov       [rbp-138],rax
       mov       rcx,offset MT_System.Linq.Expressions.TypedParameterExpression
       cmp       [rax],rcx
       je        near ptr M03_L74
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
M03_L46:
       xor       edx,edx
       mov       [rbp-0C8],rdx
       mov       r8d,[rbp-94]
       add       r12d,r8d
       add       r12d,eax
M03_L47:
       mov       rax,[rbp-128]
       mov       r8,[rax+8]
       mov       [rbp-140],r8
       test      r8,r8
       jne       near ptr M03_L145
       mov       rcx,[rax+10]
       mov       edx,r12d
       imul      rdx,[rax+28]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M03_L157
       mov       edx,edx
       mov       r8,[rcx+rdx*8+10]
       test      r8,r8
       je        near ptr M03_L83
M03_L48:
       cmp       r12d,[r8+18]
       jne       near ptr M03_L82
       mov       [rbp-150],r8
       lea       rcx,[r8+20]
       mov       r10,[rcx]
       mov       r9,[rcx+8]
       mov       [rbp-160],r9
       mov       r11,[rcx+10]
       mov       [rbp-168],r11
       test      r10,r10
       je        near ptr M03_L81
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r10],rcx
       jne       near ptr M03_L77
       mov       rcx,2ABC6404C40
       cmp       r10,rcx
       sete      dl
       movzx     edx,dl
M03_L49:
       test      edx,edx
       je        near ptr M03_L143
       mov       r9,[rbp-160]
       test      r9,r9
       je        near ptr M03_L79
       test      r13,r13
       je        near ptr M03_L144
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r9],rcx
       jne       near ptr M03_L78
       cmp       r13,r9
       sete      r10b
       movzx     r10d,r10b
M03_L50:
       test      r10d,r10d
       je        near ptr M03_L144
M03_L51:
       cmp       qword ptr [rbp-168],0
       je        near ptr M03_L80
       xor       edx,edx
M03_L52:
       test      edx,edx
       mov       r8,[rbp-150]
       je        near ptr M03_L82
       mov       rax,[r8+8]
       mov       [rbp-78],rax
M03_L53:
       mov       rdx,[rbp-78]
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       r15,rdx
       test      r15,r15
       je        short M03_L54
       mov       rcx,offset MT_LinqToDB.Mapping.ScalarTypeAttribute[]
       cmp       [r15],rcx
       je        short M03_L54
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r15,rax
M03_L54:
       mov       rcx,26B31403528
       test      r15,r15
       cmove     r15,[rcx]
       cmp       dword ptr [r15+8],0
       jne       near ptr M03_L149
       xor       r12d,r12d
M03_L55:
       xor       r15d,r15d
       test      r12,r12
       jne       near ptr M03_L150
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M03_L151
       mov       rcx,r13
       call      qword ptr [7FFC6277A420]; System.RuntimeType.get_IsEnum()
M03_L56:
       test      eax,eax
       jne       near ptr M03_L153
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+78]
       call      qword ptr [rax]
       test      eax,eax
       jne       near ptr M03_L153
       cmp       byte ptr [7FFC6277B188],0
       jne       near ptr M03_L152
M03_L57:
       mov       eax,r15d
M03_L58:
       test      eax,eax
       jne       near ptr M03_L155
       mov       rcx,offset MT_System.Type[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rcx,2ABC64045E0
       mov       [rax+10],rcx
       mov       rcx,26B31403CB0
       mov       rcx,[rcx]
       mov       rdx,rax
       call      qword ptr [7FFC62979DE0]; System.Reflection.RuntimeMethodInfo.MakeGenericMethod(System.Type[])
       mov       r15,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+TempFileDataContext
       cmp       [rsi],rcx
       jne       near ptr M03_L154
       mov       r13,[rsi+28]
M03_L59:
       mov       rcx,rsi
       call      qword ptr [7FFC6283C9A8]; System.Object.GetType()
       mov       r12,rax
       mov       rcx,offset MT_LinqToDB.Internal.Expressions.SqlQueryRootExpression
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-158],rax
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-158]
       lea       rcx,[r13+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r13
       call      qword ptr [7FFC6347CF00]; System.Linq.Expressions.Expression.Call(System.Reflection.MethodInfo, System.Linq.Expressions.Expression)
M03_L60:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rax
       xor       r9d,r9d
       call      qword ptr [7FFC63524600]; LinqToDB.Internal.Linq.Table`1[[System.__Canon, System.Private.CoreLib]].InitTable(LinqToDB.IDataContext, System.Linq.Expressions.Expression, LinqToDB.Mapping.EntityDescriptor)
       xor       r9d,r9d
       mov       rdx,r14
       mov       r8,rdi
       mov       rcx,7FFC63674D48
       call      qword ptr [7FFC635C6A00]; LinqToDB.Async.AsyncExtensions.AnyAsync[[System.__Canon, System.Private.CoreLib]](System.Linq.IQueryable`1<System.__Canon>, System.Linq.Expressions.Expression`1<System.Func`2<System.__Canon,Boolean>>, System.Threading.CancellationToken)
       cmp       [rax],al
       mov       [rbp-48],rax
       xor       ecx,ecx
       mov       [rbp-40],ecx
       test      byte ptr [rbp-40],4
       jne       near ptr M03_L156
       mov       rcx,[rbp-48]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L156
M03_L61:
       mov       rdx,[rbp-48]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L159
M03_L62:
       mov       rdx,[rbp-48]
       movzx     edx,byte ptr [rdx+38]
       mov       rax,[rbx+90]
       mov       [rax+4C],dl
       jmp       near ptr M03_L160
M03_L63:
       mov       rcx,rax
       call      qword ptr [7FFC62835818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L33
M03_L64:
       xor       ecx,ecx
       jmp       near ptr M03_L36
M03_L65:
       xor       r8d,r8d
       jmp       near ptr M03_L42
M03_L66:
       mov       rcx,r8
       call      00007FFCC2453FE0
       test      eax,eax
       je        short M03_L68
       mov       r8d,eax
M03_L67:
       jmp       near ptr M03_L42
M03_L68:
       mov       rcx,[rbp-130]
       call      qword ptr [7FFC6283E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r8d,eax
       jmp       short M03_L67
M03_L69:
       xor       r12d,r12d
       jmp       near ptr M03_L44
M03_L70:
       mov       rcx,r12
       call      00007FFCC2453FE0
       test      eax,eax
       je        short M03_L72
       mov       r12d,eax
M03_L71:
       jmp       near ptr M03_L44
M03_L72:
       mov       rcx,r12
       call      qword ptr [7FFC6283E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r12d,eax
       jmp       short M03_L71
M03_L73:
       xor       eax,eax
       jmp       near ptr M03_L46
M03_L74:
       mov       rcx,rax
       call      00007FFCC2453FE0
       test      eax,eax
       je        short M03_L76
M03_L75:
       jmp       near ptr M03_L46
M03_L76:
       mov       rcx,[rbp-138]
       call      qword ptr [7FFC6283E970]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       short M03_L75
M03_L77:
       mov       rcx,r10
       mov       rdx,2ABC6404C40
       mov       r10,[r10]
       mov       r10,[r10+40]
       call      qword ptr [r10+10]
       mov       edx,eax
       jmp       near ptr M03_L49
M03_L78:
       mov       rcx,r9
       mov       rdx,r13
       mov       r10,[r9]
       mov       r10,[r10+40]
       call      qword ptr [r10+10]
       mov       r10d,eax
       jmp       near ptr M03_L50
M03_L79:
       test      r13,r13
       jne       near ptr M03_L144
       jmp       near ptr M03_L51
M03_L80:
       mov       edx,1
       jmp       near ptr M03_L52
M03_L81:
       mov       r8,[rbp-150]
M03_L82:
       mov       r8,[r8+10]
       test      r8,r8
       jne       near ptr M03_L48
M03_L83:
       xor       edx,edx
       mov       [rbp-78],rdx
       mov       rdx,2ABC6404C40
       mov       [rbp-70],rdx
       mov       [rbp-68],r13
       xor       edx,edx
       mov       [rbp-60],rdx
       vmovdqu   xmm0,xmmword ptr [rbp-70]
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       mov       rdx,[rbp-60]
       mov       [rbp-0D0],rdx
       lea       rdx,[rbp-70]
       mov       r8,[rbp-120]
       mov       rcx,[r8+8]
       call      qword ptr [r8+18]
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       dword ptr [rsp+30],1
       lea       r8,[rbp-78]
       mov       [rsp+38],r8
       mov       [rsp+20],rax
       lea       r8,[rbp-0E0]
       mov       r9d,r12d
       shl       r9,20
       or        r9,1
       mov       rdx,[rbp-128]
       mov       rcx,r15
       call      qword ptr [7FFC63255908]; System.Collections.Concurrent.ConcurrentDictionary`2[[LinqToDB.Internal.Mapping.MappingAttributesCache+CacheKey, linq2db],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<CacheKey,System.__Canon>, CacheKey, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M03_L53
M03_L84:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC63254C18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L85:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M03_L00
M03_L86:
       mov       r15d,1
       jmp       near ptr M03_L02
M03_L87:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       r15d,eax
       jmp       near ptr M03_L02
M03_L88:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M03_L03
M03_L89:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6390CDE0]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC6352EDD8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L90:
       mov       rcx,2ABC64045E0
       mov       rax,[7FFC6277A1E0]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       short M03_L91
       mov       rcx,2ABC63F1A88
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC63A36610]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2ABC64023A0
       call      qword ptr [7FFC63A36628]
       mov       rcx,rax
       mov       rdx,2ABC64045E0
       call      qword ptr [7FFC63A36640]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFC62BB6370]
       jmp       short M03_L92
M03_L91:
       mov       rcx,2ABC63F1A88
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC63A36610]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,2ABC64023F0
       call      qword ptr [7FFC63A36628]
       mov       rcx,rax
       mov       rdx,2ABC64045E0
       call      qword ptr [7FFC63A36640]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       call      qword ptr [7FFC62BB6370]
       mov       rsi,rbx
M03_L92:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L93:
       mov       rcx,2ABC64045E0
       mov       rax,[7FFC6277A1E8]
       call      qword ptr [rax+8]
       mov       rdi,rax
       jmp       near ptr M03_L04
M03_L94:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC63DDD368]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC62BB4480]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L95:
       xor       r13d,r13d
       jmp       near ptr M03_L05
M03_L96:
       xor       r13d,r13d
       jmp       near ptr M03_L05
M03_L97:
       mov       rcx,r15
       mov       rax,[r14+40]
       call      qword ptr [rax+38]
       mov       r13,rax
       jmp       near ptr M03_L05
M03_L98:
       xor       ecx,ecx
       jmp       near ptr M03_L06
M03_L99:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+60]
       call      qword ptr [rax+8]
       mov       r14d,eax
       jmp       near ptr M03_L07
M03_L100:
       call      qword ptr [7FFC63DDD380]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rdi
       call      qword ptr [7FFC6390DB90]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC62BB4480]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L101:
       mov       rdx,r15
       mov       rcx,offset MT_System.Reflection.MethodInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r14,rax
       jmp       near ptr M03_L09
M03_L102:
       mov       ecx,3167
       mov       rdx,7FFC62FB3350
       call      qword ptr [7FFC62A57798]
       mov       rcx,rax
       call      qword ptr [7FFC6390C828]
       int       3
M03_L103:
       mov       rcx,r14
       mov       rax,[r15+58]
       call      qword ptr [rax+28]
       jmp       near ptr M03_L10
M03_L104:
       mov       rcx,r14
       mov       rax,[r15+58]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M03_L105
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,2ABC6402968
       call      qword ptr [7FFC63A36628]
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FFC63A36640]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,2ABC6402A20
       call      qword ptr [7FFC62BB6370]
       jmp       short M03_L106
M03_L105:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,2ABC64029C0
       call      qword ptr [7FFC63A36628]
       mov       rcx,rax
       mov       rdx,r14
       call      qword ptr [7FFC63A36640]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,2ABC6402A20
       call      qword ptr [7FFC62BB6370]
M03_L106:
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L107:
       mov       rcx,r14
       mov       rdx,rax
       mov       [rbp-0E8],r8
       mov       r10,[r8+40]
       call      qword ptr [r10+10]
       test      eax,eax
       je        short M03_L109
       jmp       near ptr M03_L25
M03_L108:
       xor       r10d,r10d
       jmp       near ptr M03_L21
M03_L109:
       mov       rcx,r14
       mov       rax,[rbp-0E8]
       mov       rdx,[rax+40]
       call      qword ptr [rdx+38]
       mov       r10,rax
       mov       rax,[rbp-100]
       mov       r8,[rbp-0E8]
       jmp       near ptr M03_L21
M03_L110:
       xor       ecx,ecx
       jmp       near ptr M03_L22
M03_L111:
       mov       rcx,r14
       mov       r8,[rbp-0E8]
       mov       rdx,[r8+40]
       call      qword ptr [rdx+30]
       mov       [rbp-170],rax
       mov       rcx,[rbp-100]
       mov       rdx,[rcx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       mov       rcx,[rbp-170]
       call      qword ptr [7FFC6283C828]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M03_L13
       mov       rcx,r14
       mov       rax,[rbp-0E8]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,[rbp-108]
       mov       r8d,1C
       call      qword ptr [7FFC62778420]; System.Type.GetMethod(System.String, System.Reflection.BindingFlags)
       mov       rdx,[rbp-100]
       cmp       rax,rdx
       je        near ptr M03_L25
       test      rax,rax
       je        near ptr M03_L13
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M03_L25
       jmp       near ptr M03_L13
M03_L112:
       mov       rcx,r14
       mov       rdx,rax
       mov       [rbp-0E8],r8
       mov       r10,[r8+40]
       call      qword ptr [r10+10]
       test      eax,eax
       je        short M03_L114
       jmp       near ptr M03_L25
M03_L113:
       xor       r10d,r10d
       jmp       near ptr M03_L15
M03_L114:
       mov       rcx,r14
       mov       rax,[rbp-0E8]
       mov       rdx,[rax+40]
       call      qword ptr [rdx+38]
       mov       r10,rax
       mov       rax,[rbp-110]
       mov       r8,[rbp-0E8]
       jmp       near ptr M03_L15
M03_L115:
       xor       ecx,ecx
       jmp       near ptr M03_L17
M03_L116:
       mov       rcx,r14
       mov       r8,[rbp-0E8]
       mov       rdx,[r8+40]
       call      qword ptr [rdx+30]
       mov       [rbp-178],rax
       mov       rcx,[rbp-110]
       mov       rdx,[rcx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       mov       rcx,[rbp-178]
       call      qword ptr [7FFC6283C828]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        near ptr M03_L18
       mov       rcx,r14
       mov       rax,[rbp-0E8]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,[rbp-118]
       mov       r8d,1C
       call      qword ptr [7FFC62778420]; System.Type.GetMethod(System.String, System.Reflection.BindingFlags)
       mov       rdx,[rbp-110]
       cmp       rax,rdx
       je        near ptr M03_L25
       test      rax,rax
       je        near ptr M03_L18
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M03_L25
       jmp       near ptr M03_L18
M03_L117:
       mov       rcx,r14
       mov       rax,[r14]
       mov       r15,rax
       mov       rax,[r15+40]
       call      qword ptr [rax+38]
       mov       r15,rax
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r14,rax
       mov       ecx,3167
       mov       rdx,7FFC62FB3350
       call      qword ptr [7FFC62A57798]
       mov       r8,rax
       mov       rcx,r15
       mov       rdx,r14
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFC63DDD398]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L118:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r15,rax
       jmp       near ptr M03_L26
M03_L119:
       mov       r13d,1
       jmp       near ptr M03_L28
M03_L120:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       r13d,eax
       jmp       near ptr M03_L28
M03_L121:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       r15,rax
       jmp       near ptr M03_L29
M03_L122:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6390CDE0]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC6352EDD8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L123:
       mov       rcx,2ABC63F0020
       call      qword ptr [7FFC6277A380]; System.RuntimeType.get_IsGenericTypeDefinition()
       test      eax,eax
       jne       short M03_L124
       mov       rcx,2ABC63F1A88
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC63A36610]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2ABC64023A0
       call      qword ptr [7FFC63A36628]
       mov       rcx,rax
       mov       rdx,2ABC63F0020
       call      qword ptr [7FFC63A36640]
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8,rbx
       call      qword ptr [7FFC62BB6370]
       jmp       short M03_L125
M03_L124:
       mov       rcx,2ABC63F1A88
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC63A36610]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,2ABC64023F0
       call      qword ptr [7FFC63A36628]
       mov       rcx,rax
       mov       rdx,2ABC63F0020
       call      qword ptr [7FFC63A36640]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       call      qword ptr [7FFC62BB6370]
       mov       rsi,rbx
M03_L125:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L126:
       mov       ecx,2ECB
       mov       rdx,7FFC62FB3350
       call      qword ptr [7FFC62A57798]
       mov       rcx,rax
       call      qword ptr [7FFC63A36658]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L127:
       mov       ecx,2ECB
       mov       rdx,7FFC62FB3350
       call      qword ptr [7FFC62A57798]
       mov       rcx,rax
       call      qword ptr [7FFC63A36670]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L128:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2BF3
       mov       rdx,7FFC62FB3350
       call      qword ptr [7FFC62A57798]
       mov       rcx,rax
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC63A35950]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC62BB5B78]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L129:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdx,rax
       jmp       near ptr M03_L30
M03_L130:
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M03_L31
M03_L131:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       near ptr M03_L32
M03_L132:
       mov       ecx,2BF3
       mov       rdx,7FFC62FB3350
       call      qword ptr [7FFC62A57798]
       mov       rcx,rax
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFC63A35968]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M03_L133:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L33
M03_L134:
       mov       rcx,rax
       call      qword ptr [7FFC63905DD0]
       jmp       near ptr M03_L33
M03_L135:
       mov       dword ptr [rsp+20],1
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFC62E56310]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M03_L33
M03_L136:
       mov       rdx,26B31402688
       mov       r14,[rdx]
       jmp       near ptr M03_L34
M03_L137:
       mov       ecx,0D5
       mov       rdx,7FFC62C21720
       call      qword ptr [7FFC62A57798]
       mov       rcx,rax
       call      qword ptr [7FFC6390C828]
       int       3
M03_L138:
       mov       rcx,rsi
       mov       r11,7FFC63E63580
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M03_L35
M03_L139:
       mov       rcx,2ABC64045E0
       mov       rax,[7FFC6277A1E0]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M03_L37
       mov       rcx,2ABC64045E0
       mov       rax,[7FFC6277A1E8]
       call      qword ptr [rax+18]
       mov       rcx,2ABC63FE418
       cmp       rax,rcx
       jne       near ptr M03_L37
       mov       rcx,2ABC64045E0
       mov       rax,[7FFC6277A1E8]
       call      qword ptr [rax+28]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M03_L157
       mov       rcx,[rax+10]
       jmp       near ptr M03_L38
M03_L140:
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC63257438]
       jmp       near ptr M03_L58
M03_L141:
       mov       ecx,0B80
       mov       rdx,7FFC62B51930
       call      qword ptr [7FFC62A57798]
       mov       rcx,rax
       call      qword ptr [7FFC62D57228]
       int       3
M03_L142:
       mov       r11,2ABC6404C40
       mov       [rbp-90],r11
       mov       [rbp-88],r12
       xor       r11d,r11d
       mov       [rbp-80],r11
       lea       rdx,[rbp-90]
       mov       r11,7FFC63E63590
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M03_L47
M03_L143:
       mov       r8,[rbp-150]
       jmp       near ptr M03_L82
M03_L144:
       xor       edx,edx
       jmp       near ptr M03_L52
M03_L145:
       mov       rdx,[rax+10]
       mov       ecx,r12d
       imul      rcx,[rax+28]
       shr       rcx,20
       inc       rcx
       mov       r11d,[rdx+8]
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M03_L157
       mov       ecx,ecx
       mov       r10,[rdx+rcx*8+10]
       test      r10,r10
       je        near ptr M03_L83
M03_L146:
       cmp       r12d,[r10+18]
       jne       short M03_L147
       mov       rdx,2ABC6404C40
       mov       [rbp-70],rdx
       mov       [rbp-68],r13
       xor       edx,edx
       mov       [rbp-60],rdx
       mov       [rbp-148],r10
       vmovdqu   xmm0,xmmword ptr [r10+20]
       vmovdqu   xmmword ptr [rbp-0E0],xmm0
       mov       rdx,[r10+30]
       mov       [rbp-0D0],rdx
       lea       rdx,[rbp-0E0]
       lea       r8,[rbp-70]
       mov       rcx,[rbp-140]
       mov       r11,7FFC63E63598
       call      qword ptr [r11]
       test      eax,eax
       mov       r10,[rbp-148]
       jne       short M03_L148
M03_L147:
       mov       r10,[r10+10]
       test      r10,r10
       jne       short M03_L146
       jmp       near ptr M03_L83
M03_L148:
       mov       rdx,[r10+8]
       mov       [rbp-78],rdx
       jmp       near ptr M03_L53
M03_L149:
       cmp       dword ptr [r15+8],0
       jbe       near ptr M03_L157
       mov       r12,[r15+10]
       jmp       near ptr M03_L55
M03_L150:
       movzx     r15d,byte ptr [r12+10]
       jmp       near ptr M03_L57
M03_L151:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+70]
       call      qword ptr [rax+30]
       jmp       near ptr M03_L56
M03_L152:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        near ptr M03_L57
M03_L153:
       mov       r15d,1
       jmp       near ptr M03_L57
M03_L154:
       mov       rcx,rsi
       mov       r11,7FFC63E63588
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M03_L59
M03_L155:
       xor       eax,eax
       jmp       near ptr M03_L60
M03_L156:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-40]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFC64224360]
       mov       rdx,rax
       lea       rcx,[rbp-48]
       call      qword ptr [7FFC64224378]
       jmp       short M03_L161
M03_L157:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L158:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L61
M03_L159:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFC63A3D170]
       jmp       near ptr M03_L62
M03_L160:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L162
       mov       rdx,26B31400C08
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L161:
       nop
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L162:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFC63A3EB38]
       jmp       short M03_L161
       sub       rsp,48
       vzeroupper
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFC635C6970]
       lea       rax,[M03_L161]
       add       rsp,48
       ret
; Total bytes of code 6606
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFCC22C1D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.HashCode.Combine[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M06_L00
       ret
M06_L00:
       xor       edx,edx
       jmp       qword ptr [7FFC63A3D170]
; Total bytes of code 29
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark.DeleteCollectionAsync()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       call      qword ptr [7FFC635E6C28]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create()
       mov       [rbp-18],rax
       mov       rax,[rbp+10]
       mov       [rbp-28],rax
       mov       dword ptr [rbp-20],0FFFFFFFF
       lea       rdx,[rbp-28]
       lea       rcx,[rbp-18]
       call      qword ptr [7FFC635E6C10]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<DeleteCollectionAsync>d__7, DotNetTips.Spargine.Extensions.BenchmarkTests]](<DeleteCollectionAsync>d__7 ByRef)
       lea       rcx,[rbp-18]
       call      qword ptr [7FFC635E6C40]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.get_Task()
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62E76CA0]; System.Threading.Tasks.Task.GetAwaiter()
       mov       [rbp-8],rax
       lea       rcx,[rbp-8]
       call      qword ptr [7FFC62E76CB8]; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 53
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<DeleteCollectionAsync>d__7, DotNetTips.Spargine.Extensions.BenchmarkTests]](<DeleteCollectionAsync>d__7 ByRef)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+18]
       call      qword ptr [7FFC635E6C58]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<DeleteCollectionAsync>d__7, DotNetTips.Spargine.Extensions.BenchmarkTests]](<DeleteCollectionAsync>d__7 ByRef)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.get_Task()
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFC6378C0C0]
; Total bytes of code 15
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M06_L00
       ret
M06_L00:
       lea       rax,[System.HashCode.Combine[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon)]
       xor       edx,edx
       jmp       qword ptr [rax]
; Total bytes of code 31
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark.ExecuteInTransactionAsync()
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC6318E790]; DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark.get_Context()
       mov       [rbp-18],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<>c
       call      qword ptr [7FFC62845728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,234A5C01200
       mov       rax,[rax]
       mov       [rbp-10],rax
       mov       rax,[rbp-18]
       mov       [rbp-20],rax
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-10],0
       jne       short M00_L00
       mov       rcx,offset MT_System.Func<LinqToDB.DataContext, System.Threading.CancellationToken, System.Threading.Tasks.Task>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<>c
       call      qword ptr [7FFC62845728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,234A5C011F8
       mov       rax,[rax]
       mov       [rbp-38],rax
       mov       rdx,[rbp-38]
       mov       rcx,[rbp-30]
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<>c.<ExecuteInTransactionAsync>b__8_0(LinqToDB.DataContext, System.Threading.CancellationToken)
       call      qword ptr [7FFC62846BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<>c
       call      qword ptr [7FFC62845728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rbp-30]
       mov       rcx,234A5C01200
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-30]
       mov       [rbp-28],rax
M00_L00:
       xor       eax,eax
       mov       [rbp-8],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-28]
       mov       r8,[rbp-8]
       call      qword ptr [7FFC6318E7A8]; DotNetTips.Spargine.Extensions.DataContextExtensions.ExecuteInTransactionAsync(LinqToDB.DataContext, System.Func`3<LinqToDB.DataContext,System.Threading.CancellationToken,System.Threading.Tasks.Task>, System.Threading.CancellationToken)
       nop
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62E563D0]; System.Threading.Tasks.Task.GetAwaiter()
       mov       [rbp-8],rax
       lea       rcx,[rbp-8]
       call      qword ptr [7FFC62E563E8]; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark.get_Context()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rax,[rbp+10]
       mov       rax,[rax+1A8]
       mov       [rbp-8],rax
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       cmp       qword ptr [rbp-8],0
       jne       short M02_L00
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FFC6318E7C0]
       mov       rcx,[rbp-18]
       call      CORINFO_HELP_THROW
       int       3
M02_L00:
       mov       rax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 108
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+20]
       mov       rsi,[rcx-18]
       mov       rcx,rsi
       test      cl,1
       jne       short M03_L00
       mov       rcx,7FFC6332C17C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       mov       rcx,7FFC6332C178
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFC62845C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 80
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<>c.<ExecuteInTransactionAsync>b__8_0(LinqToDB.DataContext, System.Threading.CancellationToken)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       call      qword ptr [7FFC62BCE730]; System.Threading.Tasks.Task.get_CompletedTask()
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M05_L00
       mov       rcx,7FFC6332CF54
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L00:
       mov       rcx,7FFC6332CF50
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFC632E7330]
       int       3
; Total bytes of code 82
```
```assembly
; DotNetTips.Spargine.Extensions.DataContextExtensions.ExecuteInTransactionAsync(LinqToDB.DataContext, System.Func`3<LinqToDB.DataContext,System.Threading.CancellationToken,System.Threading.Tasks.Task>, System.Threading.CancellationToken)
       push      rbp
       sub       rsp,0A0
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       call      qword ptr [7FFC6318E850]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create()
       mov       [rbp-40],rax
       mov       rax,[rbp+10]
       mov       [rbp-78],rax
       mov       rax,[rbp+18]
       mov       [rbp-70],rax
       mov       rax,[rbp+20]
       mov       [rbp-38],rax
       mov       dword ptr [rbp-50],0FFFFFFFF
       lea       rdx,[rbp-78]
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC6318E838]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[DotNetTips.Spargine.Extensions.DataContextExtensions+<ExecuteInTransactionAsync>d__1, DotNetTips.Spargine.10.Extensions]](<ExecuteInTransactionAsync>d__1 ByRef)
       lea       rcx,[rbp-40]
       call      qword ptr [7FFC6318E868]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.get_Task()
       nop
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M08_L00
       ret
M08_L00:
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       xor       edx,edx
       jmp       qword ptr [rax]
; Total bytes of code 31
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark.InsertCollectionAsync()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       call      qword ptr [7FFC6349E340]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create()
       mov       [rbp-18],rax
       mov       rax,[rbp+10]
       mov       [rbp-28],rax
       mov       dword ptr [rbp-20],0FFFFFFFF
       lea       rdx,[rbp-28]
       lea       rcx,[rbp-18]
       call      qword ptr [7FFC6349E328]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<InsertCollectionAsync>d__13, DotNetTips.Spargine.Extensions.BenchmarkTests]](<InsertCollectionAsync>d__13 ByRef)
       lea       rcx,[rbp-18]
       call      qword ptr [7FFC6349E358]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.get_Task()
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62DCF000]; System.Threading.Tasks.Task.GetAwaiter()
       mov       [rbp-8],rax
       lea       rcx,[rbp-8]
       call      qword ptr [7FFC62DCF018]; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 53
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<InsertCollectionAsync>d__13, DotNetTips.Spargine.Extensions.BenchmarkTests]](<InsertCollectionAsync>d__13 ByRef)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+18]
       call      qword ptr [7FFC6349E370]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<InsertCollectionAsync>d__13, DotNetTips.Spargine.Extensions.BenchmarkTests]](<InsertCollectionAsync>d__13 ByRef)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.get_Task()
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFC636DD6C8]
; Total bytes of code 15
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       short M06_L00
       ret
M06_L00:
       lea       rax,[System.HashCode.Combine[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon)]
       xor       edx,edx
       jmp       qword ptr [rax]
; Total bytes of code 31
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-JZFTPE(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True, InvocationCount=1, UnrollFactor=1))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark.UpsertCollectionAsync()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       call      qword ptr [7FFC635C6868]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create()
       mov       [rbp-18],rax
       mov       rax,[rbp+10]
       mov       [rbp-28],rax
       mov       dword ptr [rbp-20],0FFFFFFFF
       lea       rdx,[rbp-28]
       lea       rcx,[rbp-18]
       call      qword ptr [7FFC635C6850]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<UpsertCollectionAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<UpsertCollectionAsync>d__24 ByRef)
       lea       rcx,[rbp-18]
       call      qword ptr [7FFC635C6880]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.get_Task()
       nop
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFC62E567F0]; System.Threading.Tasks.Task.GetAwaiter()
       mov       [rbp-8],rax
       lea       rcx,[rbp-8]
       call      qword ptr [7FFC62E56808]; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 53
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create()
       xor       eax,eax
       ret
; Total bytes of code 3
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<UpsertCollectionAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<UpsertCollectionAsync>d__24 ByRef)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+18]
       call      qword ptr [7FFC635C6898]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.DataContextExtensionsBenchmark+<UpsertCollectionAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<UpsertCollectionAsync>d__24 ByRef)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 35
```
```assembly
; System.Runtime.CompilerServices.AsyncTaskMethodBuilder.get_Task()
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L00
       ret
M04_L00:
       jmp       qword ptr [7FFC6376DB60]
; Total bytes of code 15
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M06_L00
       ret
M06_L00:
       xor       edx,edx
       jmp       qword ptr [7FFC6376D158]
; Total bytes of code 29
```

