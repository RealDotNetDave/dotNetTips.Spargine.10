## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessagesSeparator()
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
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+138]
       test      rsi,rsi
       je        near ptr M00_L41
       mov       rcx,1F75B002130
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L42
M00_L00:
       mov       rcx,1F75B002158
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L43
M00_L01:
       mov       r15,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__7<System.Exception>
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+40],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r13+44],eax
       lea       rcx,[r13+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+38]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1F75B002138
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L44
M00_L02:
       mov       rdi,offset MT_System.Linq.Enumerable+IEnumerableSelectIterator<System.Exception, System.String>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1F75B002160
       mov       rsi,[rcx]
       mov       r13,rsi
       mov       rcx,[r13+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L46
       lea       rcx,[r13+20]
       mov       r8,[rbp-40]
       test      rcx,rcx
       je        near ptr M00_L45
       xor       edx,edx
       call      00007FF83BB54230
       cmp       rax,[rbp-40]
       jne       near ptr M00_L46
M00_L03:
       mov       r13,[rbp-40]
M00_L04:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-50],r13
       cmp       dword ptr [r14+14],0
       jne       short M00_L05
       mov       r12d,[r14+10]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r12d,eax
       jne       short M00_L05
       jmp       short M00_L06
M00_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rax,[r14+18]
       mov       [rbp-60],rax
       mov       r14,[r14+20]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r12+10],eax
       lea       rcx,[r12+18]
       mov       rdx,[rbp-60]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,r12
M00_L06:
       mov       dword ptr [r14+14],1
       mov       [rbp-58],r14
       mov       r12,[r14]
       cmp       r12,rdi
       jne       near ptr M00_L34
       mov       eax,[r14+14]
       cmp       eax,1
       jne       near ptr M00_L17
       mov       rax,[r14+18]
       mov       [rbp-70],rax
       cmp       [rax],r15
       jne       near ptr M00_L25
       cmp       dword ptr [rax+40],0FFFFFFFE
       jne       near ptr M00_L16
       mov       ecx,[rax+44]
       mov       [rbp-94],ecx
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       [rbp-94],eax
       jne       near ptr M00_L16
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+40],ecx
       mov       rdx,rax
       mov       [rbp-88],rdx
M00_L07:
       mov       rax,[rbp-70]
       mov       rdx,[rax+18]
       mov       r8,[rbp-88]
       lea       rcx,[r8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-70]
       mov       rdx,[rax+28]
       mov       r8,[rbp-88]
       lea       rcx,[r8+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-70]
       mov       rdx,[rax+38]
       mov       r8,[rbp-88]
       lea       rcx,[r8+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-88]
M00_L08:
       lea       rcx,[r14+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+14],2
M00_L09:
       mov       rax,[r14+28]
       mov       [rbp-78],rax
       cmp       [rax],r15
       jne       near ptr M00_L29
       mov       edx,[rax+40]
       test      edx,edx
       je        near ptr M00_L18
       cmp       edx,1
       jne       near ptr M00_L19
       mov       dword ptr [rax+40],0FFFFFFFF
       mov       r8,[rax+20]
       mov       rdx,[rax+10]
       mov       rcx,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__19_0(System.Exception)
       cmp       [r8+18],rcx
       jne       near ptr M00_L27
       mov       rdx,[rdx+20]
M00_L10:
       mov       rax,[rbp-78]
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L11:
       mov       rax,[rbp-78]
       cmp       qword ptr [rax+10],0
       je        near ptr M00_L19
       mov       r8,[rax+30]
       mov       rdx,[rax+10]
       mov       rcx,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<FromHierarchy>b__6_0(System.__Canon)
       cmp       [r8+18],rcx
       jne       near ptr M00_L28
M00_L12:
       mov       rax,[rbp-78]
       mov       rdx,[rax+10]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       mov       dword ptr [rax+40],1
M00_L13:
       mov       rax,[r14+20]
       mov       [rbp-68],rax
       mov       rcx,[r14+28]
       cmp       [rcx],r15
       jne       near ptr M00_L30
       mov       r15,[rcx+8]
       mov       rcx,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__19_1(System.Exception)
       cmp       [rax+18],rcx
       jne       near ptr M00_L33
       mov       rcx,offset MT_System.Security.SecurityException
       cmp       [r15],rcx
       jne       near ptr M00_L32
       mov       rdx,[r15+10]
       test      rdx,rdx
       je        near ptr M00_L31
M00_L14:
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r14+8]
M00_L15:
       cmp       [r13],r13b
       test      rdx,rdx
       je        near ptr M00_L20
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,r13
       call      qword ptr [7FF7DC2C79A8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       near ptr M00_L20
M00_L16:
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-80],rdx
       xor       eax,eax
       mov       [rdx+40],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       rdx,[rbp-80]
       mov       [rdx+44],eax
       mov       [rbp-88],rdx
       jmp       near ptr M00_L07
M00_L17:
       cmp       eax,2
       je        near ptr M00_L09
       jmp       near ptr M00_L20
M00_L18:
       mov       dword ptr [rax+40],0FFFFFFFF
       mov       rdx,[rax+10]
       test      rdx,rdx
       je        near ptr M00_L26
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,237F00A07C0
       mov       [rsp+20],rdx
       mov       rax,[rbp-78]
       mov       rdx,[rax+20]
       mov       rcx,7FF7DC6E7818
       xor       r8d,r8d
       mov       r9,237F0090008
       call      qword ptr [7FF7DC5BE190]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       r8,[rbp-78]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,237F00A07E8
       mov       [rsp+20],rdx
       mov       rax,[rbp-78]
       mov       rdx,[rax+30]
       mov       rcx,7FF7DC6EA358
       xor       r8d,r8d
       mov       r9,237F0090008
       call      qword ptr [7FF7DC5BE190]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       r8,[rbp-78]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L11
M00_L19:
       mov       rcx,r14
       call      qword ptr [7FF7DC6E8E50]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Dispose()
M00_L20:
       cmp       r12,rdi
       jne       short M00_L23
M00_L21:
       mov       rcx,[rbp-58]
       call      qword ptr [7FF7DC6E8E58]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M00_L35
M00_L22:
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC2DB5D0]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       jmp       near ptr M00_L38
M00_L23:
       cmp       r12,rdi
       jne       near ptr M00_L36
       mov       rcx,[rbp-58]
       call      qword ptr [7FF7DC6E8E58]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L24:
       test      eax,eax
       jne       near ptr M00_L37
       jmp       short M00_L22
M00_L25:
       mov       rcx,rax
       mov       r11,7FF7DBEB0B38
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L08
M00_L26:
       call      qword ptr [7FF7DC5BE238]
       mov       ecx,1D21
       mov       rdx,7FF7DC3040A0
       call      qword ptr [7FF7DBF6F210]
       mov       r14,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3040A0
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       ecx,110B
       mov       rdx,7FF7DC3040A0
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7DC6F7A98]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,rdi
       call      qword ptr [7FF7DC6F6D00]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L27:
       mov       rcx,[r8+8]
       call      qword ptr [r8+18]
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L28:
       mov       rcx,[r8+8]
       call      qword ptr [r8+18]
       test      eax,eax
       jne       near ptr M00_L12
       jmp       near ptr M00_L19
M00_L29:
       mov       rcx,rax
       mov       r11,7FF7DBEB0B40
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L19
       jmp       near ptr M00_L13
M00_L30:
       mov       r11,7FF7DBEB0B48
       call      qword ptr [r11]
       mov       r15,rax
       jmp       short M00_L33
M00_L31:
       mov       rcx,237F00A0828
       call      qword ptr [7FF7DC6F6C40]
       mov       [rbp-90],rax
       mov       rcx,r15
       call      qword ptr [7FF7DC2061C0]; System.Object.GetType()
       mov       rcx,rax
       call      qword ptr [7FF7DC205F98]; System.RuntimeType.get_Cache()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC6F6C58]
       mov       rdx,rax
       mov       rcx,[rbp-90]
       call      qword ptr [7FF7DC6F6C70]
       mov       rdx,rax
       jmp       near ptr M00_L14
M00_L32:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M00_L14
M00_L33:
       mov       rdx,r15
       mov       rax,[rbp-68]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       jmp       near ptr M00_L14
M00_L34:
       mov       rcx,r14
       mov       r11,7FF7DBEB0B10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L20
       mov       rcx,r14
       mov       r11,7FF7DBEB0B28
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L15
M00_L35:
       mov       rcx,[rbp-50]
       mov       edx,3A
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC2C79D8]; System.Text.StringBuilder.Append(Char)
       mov       r14,rax
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBEB0B20
       call      qword ptr [r11]
       mov       rcx,r14
       mov       rdx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC2C7A80]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M00_L21
M00_L36:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBEB0B18
       call      qword ptr [r11]
       jmp       near ptr M00_L24
M00_L37:
       mov       rcx,[rbp-50]
       mov       edx,3A
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC2C79D8]; System.Text.StringBuilder.Append(Char)
       mov       r14,rax
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBEB0B20
       call      qword ptr [r11]
       mov       rcx,r14
       mov       rdx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC2C7A80]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M00_L23
M00_L38:
       cmp       r12,rdi
       jne       short M00_L39
       mov       rcx,[rbp-58]
       call      qword ptr [7FF7DC6E8E50]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L40
M00_L39:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBEB0B30
       call      qword ptr [r11]
       nop
M00_L40:
       mov       rcx,[rbp-50]
       xor       edx,edx
       call      qword ptr [7FF7DC684CD8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rsi
       mov       rdx,[rbp-50]
       call      qword ptr [7FF7DC684CF0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       mov       [rbp-48],r14
       mov       rcx,[rbx+60]
       lea       r8,[rbp-48]
       mov       rdx,7FF7DC6EA590
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC68F000]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L41:
       call      qword ptr [7FF7DC5BE238]
       mov       ecx,1D57
       mov       rdx,7FF7DC3040A0
       call      qword ptr [7FF7DBF6F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3040A0
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FF7DC3040A0
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC6F7A98]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC6F6D00]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L42:
       mov       rcx,offset MT_System.Func<System.Exception, System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1F75B0020E0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__19_0(System.Exception)
       call      qword ptr [7FF7DBF66BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F75B002130
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       rcx,offset MT_System.Func<System.Exception, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1F75B002150
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<FromHierarchy>b__6_0(System.__Canon)
       call      qword ptr [7FF7DBF66BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F75B002158
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L44:
       mov       rcx,offset MT_System.Func<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1F75B0020E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__19_1(System.Exception)
       call      qword ptr [7FF7DBF66BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F75B002138
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L45:
       call      qword ptr [7FF7DC6F6088]
       int       3
M00_L46:
       mov       rcx,[r13+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC684C30]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L47
       add       r13,2C
       lock dec  dword ptr [r13]
       jmp       near ptr M00_L03
M00_L47:
       mov       rax,[r13+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r13,rax
       jmp       near ptr M00_L04
       sub       rsp,28
       mov       rcx,[rbp-58]
       mov       r12,[rcx]
       mov       rdi,offset MT_System.Linq.Enumerable+IEnumerableSelectIterator<System.Exception, System.String>
       cmp       r12,rdi
       jne       short M00_L48
       call      qword ptr [7FF7DC6E8E50]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L49
M00_L48:
       mov       r11,7FF7DBEB0B30
       call      qword ptr [r11]
M00_L49:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,[rbp-50]
       cmp       [rdx],dl
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7DC684CD8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,1F75B002160
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,[rbp-50]
       call      qword ptr [7FF7DC684CF0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       nop
       add       rsp,28
       ret
; Total bytes of code 2423
```
```assembly
; DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__19_0(System.Exception)
; 			var messages = exception.FromHierarchy(ex => ex.InnerException!).Select(ex => ex.Message);
; 			                                             ^^^^^^^^^^^^^^^^^^
       mov       rax,[rdx+20]
       ret
; Total bytes of code 5
```
```assembly
; DotNetTips.Spargine.Core.ExceptionExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<FromHierarchy>b__6_0(System.__Canon)
; 			return FromHierarchy(source, accumulatorFunction, s => s is not null);
; 			                                                       ^^^^^^^^^^^^^
       test      rdx,rdx
       setne     al
       movzx     eax,al
       ret
; Total bytes of code 10
```
```assembly
; DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__19_1(System.Exception)
; 			var messages = exception.FromHierarchy(ex => ex.InnerException!).Select(ex => ex.Message);
; 			                                                                              ^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rax,offset MT_System.Security.SecurityException
       cmp       [rbx],rax
       jne       short M03_L03
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M03_L00
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       mov       rcx,237F00A0828
       call      qword ptr [7FF7DC6F6C40]
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DC2061C0]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M03_L01
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M03_L01
       mov       rax,rcx
       jmp       short M03_L02
M03_L01:
       mov       rcx,rax
       call      qword ptr [7FF7DC2056C8]; System.RuntimeType.InitializeCache()
M03_L02:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC6F6C58]
       mov       rdx,rax
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF7DC6F6C70]
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+20]
; Total bytes of code 150
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      r8d,r8d
       je        short M04_L01
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        short M04_L03
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M04_L02
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L00:
       mov       [rbx+18],esi
M04_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M04_L00
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M04_L00
M04_L03:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF7DC2C7A38]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
; Total bytes of code 102
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
; 		var isValid = input is not null;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (isValid is false && defaultValue is not null)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			input = defaultValue;
; 			^^^^^^^^^^^^^^^^^^^^^
; 		else if (isValid is false)
; 		     ^^^^^^^^^^^^^^^^^^^^^
; 			ExceptionThrower.ThrowArgumentNullException(CreateParamExceptionMessage(errorMessage, paramName, Resources.ErrorObjectCannotBeNull));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return input!;
; 		^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,r9
       test      rdx,rdx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M05_L01
M05_L00:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L01:
       test      r8,r8
       je        short M05_L02
       mov       rdx,r8
       jmp       short M05_L00
M05_L02:
       call      qword ptr [7FF7DC5BE238]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,237F0090390
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M05_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M05_L04
M05_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M05_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7DC6F7A98]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC6F6D00]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 157
```
```assembly
; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Dispose()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       qword ptr [rbx+28],0
       jne       short M06_L01
M06_L00:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M06_L01:
       mov       rcx,[rbx+28]
       mov       r11,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__7<System.Exception>
       cmp       [rcx],r11
       jne       short M06_L03
       mov       dword ptr [rcx+40],0FFFFFFFE
M06_L02:
       xor       eax,eax
       mov       [rbx+28],rax
       jmp       short M06_L00
M06_L03:
       mov       r11,7FF7DBEB0C40
       call      qword ptr [r11]
       jmp       short M06_L02
; Total bytes of code 83
```
```assembly
; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,[rbx+14]
       cmp       esi,1
       jne       near ptr M07_L10
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       r11,[rdx+28]
       test      r11,r11
       je        near ptr M07_L08
M07_L00:
       mov       rsi,[rbx+18]
       mov       rdi,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__7<System.Exception>
       cmp       [rsi],rdi
       jne       near ptr M07_L15
       cmp       dword ptr [rsi+40],0FFFFFFFE
       jne       near ptr M07_L09
       mov       ebp,[rsi+44]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       ebp,eax
       jne       near ptr M07_L09
       xor       ecx,ecx
       mov       [rsi+40],ecx
       mov       rbp,rsi
M07_L01:
       mov       rdx,[rsi+18]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+28]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+38]
       lea       rcx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
M07_L02:
       lea       rcx,[rbx+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+14],2
M07_L03:
       mov       rcx,[rbx+28]
       mov       rdi,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__7<System.Exception>
       cmp       [rcx],rdi
       jne       near ptr M07_L16
       call      qword ptr [7FF7DC6E8288]; DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__7`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
M07_L04:
       test      eax,eax
       jne       short M07_L11
       cmp       qword ptr [rbx+28],0
       je        short M07_L06
       mov       rcx,[rbx+28]
       cmp       [rcx],rdi
       jne       near ptr M07_L23
       mov       dword ptr [rcx+40],0FFFFFFFE
M07_L05:
       xor       ecx,ecx
       mov       [rbx+28],rcx
M07_L06:
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       dword ptr [rbx+14],0FFFFFFFF
M07_L07:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L08:
       mov       rdx,7FF7DC7423D8
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       xor       eax,eax
       mov       [rbp+40],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+44],eax
       jmp       near ptr M07_L01
M07_L10:
       cmp       esi,2
       je        near ptr M07_L03
       jmp       short M07_L07
M07_L11:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M07_L14
M07_L12:
       mov       rsi,[rbx+20]
       mov       rcx,[rbx+28]
       cmp       [rcx],rdi
       jne       near ptr M07_L17
       mov       rdi,[rcx+8]
       mov       rcx,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__19_1(System.Exception)
       cmp       [rsi+18],rcx
       jne       near ptr M07_L22
       mov       rcx,offset MT_System.Security.SecurityException
       cmp       [rdi],rcx
       jne       near ptr M07_L21
       mov       rdx,[rdi+10]
       test      rdx,rdx
       je        short M07_L18
M07_L13:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L14:
       mov       rdx,7FF7DC742490
       call      qword ptr [7FF7DBF6F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M07_L12
M07_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M07_L02
M07_L16:
       mov       r11,7FF7DBEB0AF8
       call      qword ptr [r11]
       jmp       near ptr M07_L04
M07_L17:
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       short M07_L22
M07_L18:
       mov       rcx,237F00A0828
       call      qword ptr [7FF7DC6F6C40]
       mov       rsi,rax
       mov       rcx,rdi
       call      qword ptr [7FF7DC2061C0]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M07_L19
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M07_L19
       mov       rax,rcx
       jmp       short M07_L20
M07_L19:
       mov       rcx,rax
       call      qword ptr [7FF7DC2056C8]; System.RuntimeType.InitializeCache()
M07_L20:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC6F6C58]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF7DC6F6C70]
       mov       rdx,rax
       jmp       near ptr M07_L13
M07_L21:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M07_L13
M07_L22:
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rdx,rax
       jmp       near ptr M07_L13
M07_L23:
       mov       r11,7FF7DBEB0B00
       call      qword ptr [r11]
       jmp       near ptr M07_L05
; Total bytes of code 643
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M08_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF83BB9AFE0
       mov       rsi,rax
M08_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M08_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M08_L03
       cmp       [rdx+8],r8d
       jb        short M08_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M08_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M08_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L02:
       mov       rax,237F0090008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF7DBEA4000
       call      qword ptr [7FF7DBF6F210]
       mov       rbx,rax
       call      qword ptr [7FF7DC6F60A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC535FE0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M09_L00:
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
       mov       rax,237F0090008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M09_L03:
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
M09_L04:
       call      qword ptr [7FF7DC6F6B68]
       int       3
; Total bytes of code 244
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
       call      qword ptr [7FF7DBF65C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M10_L00
; Total bytes of code 41
```
```assembly
; System.RuntimeType.get_Cache()
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M11_L00
       mov       rax,[rax]
       test      rax,rax
       je        short M11_L00
       ret
M11_L00:
       jmp       qword ptr [7FF7DC2056C8]; System.RuntimeType.InitializeCache()
; Total bytes of code 24
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M12_L01
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M12_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M12_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FF7DC2C7C00]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M12_L00
; Total bytes of code 60
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rdx,rdx
       je        short M13_L01
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M13_L01
       mov       rcx,[rbx+8]
       mov       edx,[rbx+18]
       lea       esi,[rdx+r8]
       cmp       esi,[rcx+8]
       ja        short M13_L03
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jle       short M13_L02
       mov       r8d,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M13_L00:
       mov       [rbx+18],esi
M13_L01:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M13_L02:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       jne       short M13_L00
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M13_L00
M13_L03:
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF7DC2C7A38]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M13_L01
; Total bytes of code 121
```
```assembly
; System.Text.StringBuilder.set_Length(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M14_L01
       cmp       esi,[rbx+20]
       jg        short M14_L02
       test      esi,esi
       jne       near ptr M14_L03
       cmp       qword ptr [rbx+10],0
       jne       short M14_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M14_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M14_L01:
       mov       ecx,3AD
       mov       rdx,7FF7DBEA4000
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FF7DC6F5B18]
       int       3
M14_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7DBEA4000
       call      qword ptr [7FF7DBF6F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC6F6A18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC535FE0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M14_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,esi
       sub       r8d,ecx
       test      r8d,r8d
       jle       short M14_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF7DC6F6B98]
       jmp       near ptr M14_L00
M14_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF7DC6F6BB0]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M14_L09
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       add       ecx,[rbx+1C]
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M14_L07
       cmp       ecx,400
       jge       short M14_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M14_L06
M14_L05:
       xor       edx,edx
       call      qword ptr [7FF7DC5BE358]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M14_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FF7DBF6F588]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M14_L08
M14_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M14_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M14_L09:
       sub       esi,[rdi+1C]
       mov       [rbx+18],esi
       jmp       near ptr M14_L00
; Total bytes of code 399
```
```assembly
; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       near ptr M15_L10
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M15_L11
       cmp       dword ptr [rbx+20],0
       jl        short M15_L02
       cmp       qword ptr [rbx+10],0
       jne       near ptr M15_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M15_L00:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M15_L13
       lea       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M15_L12
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FF83BB54230
       test      rax,rax
       jne       near ptr M15_L13
M15_L01:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M15_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7DBEA4000
       call      qword ptr [7FF7DBF6F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC6F6A18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC535FE0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M15_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M15_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF7DC6F6B98]
       jmp       near ptr M15_L00
M15_L04:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF7DC6F6BB0]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M15_L09
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       add       ecx,[rbx+1C]
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M15_L07
       cmp       ecx,400
       jge       short M15_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M15_L06
M15_L05:
       xor       edx,edx
       call      qword ptr [7FF7DC5BE358]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M15_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FF7DBF6F588]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M15_L08
M15_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M15_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M15_L09:
       mov       ecx,[rdi+1C]
       neg       ecx
       mov       [rbx+18],ecx
       jmp       near ptr M15_L00
M15_L10:
       mov       rdx,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       jne       near ptr M15_L00
M15_L11:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M15_L12:
       call      qword ptr [7FF7DC6F6088]
       int       3
M15_L13:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M15_L14
       mov       rcx,[rsi+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC684D20]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       near ptr M15_L01
M15_L14:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M15_L11
; Total bytes of code 543
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
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M17_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M17_L00:
       call      qword ptr [7FF7DC6F64F0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+18]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF8375BCAD0]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M18_L00
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M18_L00:
       cmp       qword ptr [rdi+10],0
       jne       short M18_L01
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M18_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 91
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessages()
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
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       rbx,rcx
       mov       rsi,[rbx+138]
       test      rsi,rsi
       je        near ptr M00_L42
       mov       rcx,1E9D4802138
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L43
M00_L00:
       mov       rcx,1E9D4802160
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L44
M00_L01:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__7<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+40],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+44],eax
       lea       rcx,[r15+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+38]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1E9D4802140
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L45
M00_L02:
       mov       rdi,offset MT_System.Linq.Enumerable+IEnumerableSelectIterator<System.Exception, System.String>
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1E9D4802168
       mov       rsi,[rcx]
       mov       r15,rsi
       mov       rcx,[r15+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L47
       lea       rcx,[r15+20]
       mov       r8,[rbp-40]
       test      rcx,rcx
       je        near ptr M00_L46
       xor       edx,edx
       call      00007FF83BB54230
       cmp       rax,[rbp-40]
       jne       near ptr M00_L47
M00_L03:
       mov       r15,[rbp-40]
M00_L04:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-50],r15
       cmp       dword ptr [r14+14],0
       jne       short M00_L05
       mov       r13d,[r14+10]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r13d,eax
       jne       short M00_L05
       jmp       short M00_L06
M00_L05:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       r12,[r14+18]
       mov       r14,[r14+20]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r13+10],eax
       lea       rcx,[r13+18]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,r13
M00_L06:
       mov       dword ptr [r14+14],1
       mov       [rbp-58],r14
       mov       r13,[r14]
       cmp       r13,rdi
       jne       near ptr M00_L35
       mov       eax,[r14+14]
       cmp       eax,1
       je        near ptr M00_L14
       cmp       eax,2
       jne       short M00_L11
M00_L07:
       mov       r12,[r14+28]
       mov       rdx,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__7<System.Exception>
       cmp       [r12],rdx
       jne       near ptr M00_L30
       mov       edx,[r12+40]
       test      edx,edx
       je        near ptr M00_L17
       cmp       edx,1
       jne       short M00_L10
       mov       dword ptr [r12+40],0FFFFFFFF
       mov       rax,[r12+20]
       mov       rdx,[r12+10]
       mov       rcx,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__19_0(System.Exception)
       cmp       [rax+18],rcx
       jne       near ptr M00_L28
       mov       rdx,[rdx+20]
M00_L08:
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L09:
       cmp       qword ptr [r12+10],0
       jne       near ptr M00_L18
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FF7DC6C82E8]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Dispose()
M00_L11:
       cmp       r13,rdi
       jne       near ptr M00_L23
M00_L12:
       mov       rcx,[rbp-58]
       call      qword ptr [7FF7DC6C82F0]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M00_L36
M00_L13:
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC2CB7C0]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       jmp       near ptr M00_L39
M00_L14:
       mov       r12,[r14+18]
       mov       rax,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__7<System.Exception>
       cmp       [r12],rax
       jne       near ptr M00_L26
       cmp       dword ptr [r12+40],0FFFFFFFE
       jne       near ptr M00_L25
       mov       eax,[r12+44]
       mov       [rbp-74],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       [rbp-74],eax
       jne       near ptr M00_L25
       xor       ecx,ecx
       mov       [r12+40],ecx
       mov       rdx,r12
       mov       [rbp-70],rdx
M00_L15:
       mov       rdx,[r12+18]
       mov       rax,[rbp-70]
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r12+28]
       mov       rax,[rbp-70]
       lea       rcx,[rax+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r12+38]
       mov       r12,[rbp-70]
       lea       rcx,[r12+30]
       call      CORINFO_HELP_ASSIGN_REF
M00_L16:
       lea       rcx,[r14+28]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+14],2
       jmp       near ptr M00_L07
M00_L17:
       mov       dword ptr [r12+40],0FFFFFFFF
       mov       rdx,[r12+10]
       test      rdx,rdx
       je        near ptr M00_L27
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,22A69A007E8
       mov       [rsp+20],rdx
       mov       rdx,[r12+20]
       mov       rcx,7FF7DC6C6CB0
       xor       r8d,r8d
       mov       r9,22A699F0008
       call      qword ptr [7FF7DC5ADC98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       lea       rcx,[r12+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,22A69A00810
       mov       [rsp+20],rdx
       mov       rdx,[r12+30]
       mov       rcx,7FF7DC6C97F0
       xor       r8d,r8d
       mov       r9,22A699F0008
       call      qword ptr [7FF7DC5ADC98]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       lea       rcx,[r12+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L09
M00_L18:
       mov       rax,[r12+30]
       mov       rdx,[r12+10]
       mov       rcx,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<FromHierarchy>b__6_0(System.__Canon)
       cmp       [rax+18],rcx
       jne       near ptr M00_L29
M00_L19:
       mov       rdx,[r12+10]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r12+40],1
M00_L20:
       mov       r12,[r14+20]
       mov       rcx,[r14+28]
       mov       rax,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__7<System.Exception>
       cmp       [rcx],rax
       jne       near ptr M00_L31
       mov       rax,[rcx+8]
       mov       rcx,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__19_1(System.Exception)
       cmp       [r12+18],rcx
       jne       near ptr M00_L34
       mov       rcx,offset MT_System.Security.SecurityException
       cmp       [rax],rcx
       jne       near ptr M00_L33
       mov       [rbp-60],rax
       mov       rdx,[rax+10]
       test      rdx,rdx
       je        near ptr M00_L32
M00_L21:
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r14+8]
M00_L22:
       cmp       [r15],r15b
       test      rdx,rdx
       je        near ptr M00_L11
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,r15
       call      qword ptr [7FF7DC2B79A8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       near ptr M00_L11
M00_L23:
       cmp       r13,rdi
       jne       near ptr M00_L37
       mov       rcx,[rbp-58]
       call      qword ptr [7FF7DC6C82F0]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L24:
       test      eax,eax
       jne       near ptr M00_L38
       jmp       near ptr M00_L13
M00_L25:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__7<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-68],rdx
       xor       eax,eax
       mov       [rdx+40],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       rdx,[rbp-68]
       mov       [rdx+44],eax
       mov       [rbp-70],rdx
       jmp       near ptr M00_L15
M00_L26:
       mov       rcx,r12
       mov       r11,7FF7DBEA0B38
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L16
M00_L27:
       call      qword ptr [7FF7DC5ADD40]
       mov       ecx,1D21
       mov       rdx,7FF7DC2F40A0
       call      qword ptr [7FF7DBF5F210]
       mov       r12,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F40A0
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,110B
       mov       rdx,7FF7DC2F40A0
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF7DC6E7BB8]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rdi
       call      qword ptr [7FF7DC6E6E20]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L28:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       jmp       near ptr M00_L08
M00_L29:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M00_L19
       jmp       near ptr M00_L10
M00_L30:
       mov       rcx,r12
       mov       r11,7FF7DBEA0B40
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L10
       jmp       near ptr M00_L20
M00_L31:
       mov       r11,7FF7DBEA0B48
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdx
       jmp       short M00_L34
M00_L32:
       mov       rcx,22A69A00850
       call      qword ptr [7FF7DC6E6C40]
       mov       r12,rax
       mov       rcx,[rbp-60]
       call      qword ptr [7FF7DC1F61C0]; System.Object.GetType()
       mov       rcx,rax
       call      qword ptr [7FF7DC1F5F98]; System.RuntimeType.get_Cache()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC6E6C58]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF7DC6E6C70]
       mov       rdx,rax
       jmp       near ptr M00_L21
M00_L33:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M00_L21
M00_L34:
       mov       rdx,rax
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       rdx,rax
       jmp       near ptr M00_L21
M00_L35:
       mov       rcx,r14
       mov       r11,7FF7DBEA0B10
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L11
       mov       rcx,r14
       mov       r11,7FF7DBEA0B28
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L22
M00_L36:
       mov       rcx,[rbp-50]
       mov       edx,2C
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC2B79D8]; System.Text.StringBuilder.Append(Char)
       mov       r14,rax
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBEA0B20
       call      qword ptr [r11]
       mov       rcx,r14
       mov       rdx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC2B7A80]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M00_L12
M00_L37:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBEA0B18
       call      qword ptr [r11]
       jmp       near ptr M00_L24
M00_L38:
       mov       rcx,[rbp-50]
       mov       edx,2C
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC2B79D8]; System.Text.StringBuilder.Append(Char)
       mov       r14,rax
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBEA0B20
       call      qword ptr [r11]
       mov       rcx,r14
       mov       rdx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC2B7A80]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M00_L23
M00_L39:
       cmp       r13,rdi
       jne       short M00_L40
       mov       rcx,[rbp-58]
       call      qword ptr [7FF7DC6C82E8]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L41
M00_L40:
       mov       rcx,[rbp-58]
       mov       r11,7FF7DBEA0B30
       call      qword ptr [r11]
       nop
M00_L41:
       mov       rcx,[rbp-50]
       xor       edx,edx
       call      qword ptr [7FF7DC664570]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rsi
       mov       rdx,[rbp-50]
       call      qword ptr [7FF7DC664588]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       mov       [rbp-48],r14
       mov       rcx,[rbx+60]
       lea       r8,[rbp-48]
       mov       rdx,7FF7DC6C9A28
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC66ED00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L42:
       call      qword ptr [7FF7DC5ADD40]
       mov       ecx,1D57
       mov       rdx,7FF7DC2F40A0
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F40A0
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FF7DC2F40A0
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC6E7BB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC6E6E20]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L43:
       mov       rcx,offset MT_System.Func<System.Exception, System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1E9D48020E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__19_0(System.Exception)
       call      qword ptr [7FF7DBF56BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E9D4802138
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L44:
       mov       rcx,offset MT_System.Func<System.Exception, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1E9D4802158
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<FromHierarchy>b__6_0(System.__Canon)
       call      qword ptr [7FF7DBF56BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E9D4802160
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,offset MT_System.Func<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1E9D48020E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__19_1(System.Exception)
       call      qword ptr [7FF7DBF56BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E9D4802140
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L46:
       call      qword ptr [7FF7DC6E6010]
       int       3
M00_L47:
       mov       rcx,[r15+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC6644C8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L48
       add       r15,2C
       lock dec  dword ptr [r15]
       jmp       near ptr M00_L03
M00_L48:
       mov       rax,[r15+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M00_L04
       sub       rsp,28
       mov       rcx,[rbp-58]
       mov       r13,[rcx]
       mov       rdi,offset MT_System.Linq.Enumerable+IEnumerableSelectIterator<System.Exception, System.String>
       cmp       r13,rdi
       jne       short M00_L49
       call      qword ptr [7FF7DC6C82E8]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L50
M00_L49:
       mov       r11,7FF7DBEA0B30
       call      qword ptr [r11]
M00_L50:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,[rbp-50]
       cmp       [rdx],dl
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7DC664570]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,1E9D4802168
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,[rbp-50]
       call      qword ptr [7FF7DC664588]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       nop
       add       rsp,28
       ret
; Total bytes of code 2387
```
```assembly
; DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__19_0(System.Exception)
; 			var messages = exception.FromHierarchy(ex => ex.InnerException!).Select(ex => ex.Message);
; 			                                             ^^^^^^^^^^^^^^^^^^
       mov       rax,[rdx+20]
       ret
; Total bytes of code 5
```
```assembly
; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Dispose()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       qword ptr [rbx+28],0
       jne       short M02_L01
M02_L00:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       rcx,[rbx+28]
       mov       r11,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__7<System.Exception>
       cmp       [rcx],r11
       jne       short M02_L03
       mov       dword ptr [rcx+40],0FFFFFFFE
M02_L02:
       xor       eax,eax
       mov       [rbx+28],rax
       jmp       short M02_L00
M02_L03:
       mov       r11,7FF7DBEA0C40
       call      qword ptr [r11]
       jmp       short M02_L02
; Total bytes of code 83
```
```assembly
; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,[rbx+14]
       cmp       ecx,1
       je        short M03_L05
       cmp       ecx,2
       jne       short M03_L04
M03_L00:
       mov       rcx,[rbx+28]
       mov       rdi,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__7<System.Exception>
       cmp       [rcx],rdi
       jne       near ptr M03_L16
       call      qword ptr [7FF7DC6C7720]; DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__7`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
M03_L01:
       test      eax,eax
       jne       near ptr M03_L10
       cmp       qword ptr [rbx+28],0
       je        short M03_L03
       mov       rcx,[rbx+28]
       cmp       [rcx],rdi
       jne       near ptr M03_L23
       mov       dword ptr [rcx+40],0FFFFFFFE
M03_L02:
       xor       eax,eax
       mov       [rbx+28],rax
M03_L03:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
M03_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M03_L09
M03_L06:
       mov       rsi,[rbx+18]
       mov       rdi,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__7<System.Exception>
       cmp       [rsi],rdi
       jne       near ptr M03_L15
       cmp       dword ptr [rsi+40],0FFFFFFFE
       jne       near ptr M03_L14
       mov       ebp,[rsi+44]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       ebp,eax
       jne       near ptr M03_L14
       xor       ecx,ecx
       mov       [rsi+40],ecx
       mov       rbp,rsi
M03_L07:
       mov       rdx,[rsi+18]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+28]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+38]
       lea       rcx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
M03_L08:
       lea       rcx,[rbx+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+14],2
       jmp       near ptr M03_L00
M03_L09:
       mov       rdx,7FF7DC731DB8
       call      qword ptr [7FF7DBF5F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M03_L06
M03_L10:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M03_L13
M03_L11:
       mov       rsi,[rbx+20]
       mov       rcx,[rbx+28]
       cmp       [rcx],rdi
       jne       near ptr M03_L17
       mov       rdi,[rcx+8]
       mov       rcx,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__19_1(System.Exception)
       cmp       [rsi+18],rcx
       jne       near ptr M03_L22
       mov       rcx,offset MT_System.Security.SecurityException
       cmp       [rdi],rcx
       jne       near ptr M03_L21
       mov       rdx,[rdi+10]
       test      rdx,rdx
       je        short M03_L18
M03_L12:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L13:
       mov       rdx,7FF7DC731E70
       call      qword ptr [7FF7DBF5F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M03_L11
M03_L14:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       xor       eax,eax
       mov       [rbp+40],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+44],eax
       jmp       near ptr M03_L07
M03_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M03_L08
M03_L16:
       mov       r11,7FF7DBEA0AF8
       call      qword ptr [r11]
       jmp       near ptr M03_L01
M03_L17:
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       short M03_L22
M03_L18:
       mov       rcx,22A69A00850
       call      qword ptr [7FF7DC6E6C40]
       mov       rsi,rax
       mov       rcx,rdi
       call      qword ptr [7FF7DC1F61C0]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M03_L19
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M03_L19
       mov       rax,rcx
       jmp       short M03_L20
M03_L19:
       mov       rcx,rax
       call      qword ptr [7FF7DC1F56C8]; System.RuntimeType.InitializeCache()
M03_L20:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC6E6C58]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF7DC6E6C70]
       mov       rdx,rax
       jmp       near ptr M03_L12
M03_L21:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M03_L12
M03_L22:
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rdx,rax
       jmp       near ptr M03_L12
M03_L23:
       mov       r11,7FF7DBEA0B00
       call      qword ptr [r11]
       jmp       near ptr M03_L02
; Total bytes of code 638
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M04_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF83BB9AFE0
       mov       rsi,rax
M04_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rax,22A699F0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       call      qword ptr [7FF7DC6E6028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC525FE0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
; 		var isValid = input is not null;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (isValid is false && defaultValue is not null)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			input = defaultValue;
; 			^^^^^^^^^^^^^^^^^^^^^
; 		else if (isValid is false)
; 		     ^^^^^^^^^^^^^^^^^^^^^
; 			ExceptionThrower.ThrowArgumentNullException(CreateParamExceptionMessage(errorMessage, paramName, Resources.ErrorObjectCannotBeNull));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return input!;
; 		^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,r9
       test      rdx,rdx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M05_L01
M05_L00:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L01:
       test      r8,r8
       je        short M05_L02
       mov       rdx,r8
       jmp       short M05_L00
M05_L02:
       call      qword ptr [7FF7DC5ADD40]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,22A699F0390
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M05_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M05_L04
M05_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M05_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF7DC6E7BB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC6E6E20]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 157
```
```assembly
; DotNetTips.Spargine.Core.ExceptionExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<FromHierarchy>b__6_0(System.__Canon)
; 			return FromHierarchy(source, accumulatorFunction, s => s is not null);
; 			                                                       ^^^^^^^^^^^^^
       test      rdx,rdx
       setne     al
       movzx     eax,al
       ret
; Total bytes of code 10
```
```assembly
; DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__19_1(System.Exception)
; 			var messages = exception.FromHierarchy(ex => ex.InnerException!).Select(ex => ex.Message);
; 			                                                                              ^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rax,offset MT_System.Security.SecurityException
       cmp       [rbx],rax
       jne       short M07_L03
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M07_L00
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       mov       rcx,22A69A00850
       call      qword ptr [7FF7DC6E6C40]
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DC1F61C0]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M07_L01
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M07_L01
       mov       rax,rcx
       jmp       short M07_L02
M07_L01:
       mov       rcx,rax
       call      qword ptr [7FF7DC1F56C8]; System.RuntimeType.InitializeCache()
M07_L02:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC6E6C58]
       mov       rdx,rax
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF7DC6E6C70]
M07_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+20]
; Total bytes of code 150
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      r8d,r8d
       je        short M08_L01
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        short M08_L03
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M08_L02
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M08_L00:
       mov       [rbx+18],esi
M08_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L02:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M08_L00
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M08_L00
M08_L03:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF7DC2B7A38]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
; Total bytes of code 102
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M09_L00:
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
       mov       rax,22A699F0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M09_L03:
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
M09_L04:
       call      qword ptr [7FF7DC6E6B68]
       int       3
; Total bytes of code 244
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
       call      qword ptr [7FF7DBF55C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M10_L00
; Total bytes of code 41
```
```assembly
; System.RuntimeType.get_Cache()
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M11_L00
       mov       rax,[rax]
       test      rax,rax
       je        short M11_L00
       ret
M11_L00:
       jmp       qword ptr [7FF7DC1F56C8]; System.RuntimeType.InitializeCache()
; Total bytes of code 24
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M12_L01
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M12_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M12_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FF7DC2B7C00]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M12_L00
; Total bytes of code 60
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rdx,rdx
       je        short M13_L01
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M13_L01
       mov       rcx,[rbx+8]
       mov       edx,[rbx+18]
       lea       esi,[rdx+r8]
       cmp       esi,[rcx+8]
       ja        short M13_L03
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jle       short M13_L02
       mov       r8d,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M13_L00:
       mov       [rbx+18],esi
M13_L01:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M13_L02:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       jne       short M13_L00
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M13_L00
M13_L03:
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF7DC2B7A38]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M13_L01
; Total bytes of code 121
```
```assembly
; System.Text.StringBuilder.set_Length(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        short M14_L01
       cmp       esi,[rbx+20]
       jg        short M14_L02
       test      esi,esi
       jne       near ptr M14_L03
       cmp       qword ptr [rbx+10],0
       jne       short M14_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M14_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M14_L01:
       mov       ecx,3AD
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FF7DC6E5B18]
       int       3
M14_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC6E6A18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC525FE0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M14_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,esi
       sub       r8d,ecx
       test      r8d,r8d
       jle       short M14_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF7DC6E6B98]
       jmp       near ptr M14_L00
M14_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF7DC6E6BB0]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M14_L09
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       add       ecx,[rbx+1C]
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M14_L07
       cmp       ecx,400
       jge       short M14_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M14_L06
M14_L05:
       xor       edx,edx
       call      qword ptr [7FF7DC5ADE60]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M14_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FF7DBF5F588]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M14_L08
M14_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M14_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M14_L09:
       sub       esi,[rdi+1C]
       mov       [rbx+18],esi
       jmp       near ptr M14_L00
; Total bytes of code 399
```
```assembly
; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       near ptr M15_L10
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M15_L11
       cmp       dword ptr [rbx+20],0
       jl        short M15_L02
       cmp       qword ptr [rbx+10],0
       jne       near ptr M15_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M15_L00:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M15_L13
       lea       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M15_L12
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FF83BB54230
       test      rax,rax
       jne       near ptr M15_L13
M15_L01:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M15_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7DBE94000
       call      qword ptr [7FF7DBF5F210]
       mov       rsi,rax
       call      qword ptr [7FF7DC6E6A18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF7DC525FE0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M15_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M15_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF7DC6E6B98]
       jmp       near ptr M15_L00
M15_L04:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF7DC6E6BB0]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M15_L09
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       add       ecx,[rbx+1C]
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M15_L07
       cmp       ecx,400
       jge       short M15_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M15_L06
M15_L05:
       xor       edx,edx
       call      qword ptr [7FF7DC5ADE60]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M15_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FF7DBF5F588]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M15_L08
M15_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M15_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M15_L09:
       mov       ecx,[rdi+1C]
       neg       ecx
       mov       [rbx+18],ecx
       jmp       near ptr M15_L00
M15_L10:
       mov       rdx,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       jne       near ptr M15_L00
M15_L11:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M15_L12:
       call      qword ptr [7FF7DC6E6010]
       int       3
M15_L13:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M15_L14
       mov       rcx,[rsi+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC6645B8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       near ptr M15_L01
M15_L14:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M15_L11
; Total bytes of code 543
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
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M17_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M17_L00:
       call      qword ptr [7FF7DC6E64F0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+18]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF8375BCAD0]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M18_L00
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M18_L00:
       cmp       qword ptr [rdi+10],0
       jne       short M18_L01
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M18_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 91
```

