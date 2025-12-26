## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,1DED2000130
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L42
M00_L00:
       mov       rcx,1DED2000158
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L43
M00_L01:
       mov       r15,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__8<System.Exception>
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
       mov       rcx,1DED2000138
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
       mov       rcx,1DED2000160
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
       call      00007FFFDFA1FBA0
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
       je        near ptr M00_L14
       cmp       eax,2
       jne       near ptr M00_L19
M00_L07:
       mov       rax,[r14+28]
       mov       [rbp-78],rax
       cmp       [rax],r15
       jne       near ptr M00_L29
       mov       edx,[rax+40]
       test      edx,edx
       je        near ptr M00_L17
       cmp       edx,1
       jne       near ptr M00_L18
       mov       dword ptr [rax+40],0FFFFFFFF
       mov       r8,[rax+20]
       mov       rdx,[rax+10]
       mov       rcx,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__20_0(System.Exception)
       cmp       [r8+18],rcx
       jne       near ptr M00_L27
       mov       rdx,[rdx+20]
M00_L08:
       mov       rax,[rbp-78]
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L09:
       mov       rax,[rbp-78]
       cmp       qword ptr [rax+10],0
       je        near ptr M00_L18
       mov       r8,[rax+30]
       mov       rdx,[rax+10]
       mov       rcx,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c__7`1[[System.__Canon, System.Private.CoreLib]].<FromHierarchy>b__7_0(System.__Canon)
       cmp       [r8+18],rcx
       jne       near ptr M00_L28
M00_L10:
       mov       rax,[rbp-78]
       mov       rdx,[rax+10]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       mov       dword ptr [rax+40],1
M00_L11:
       mov       rax,[r14+20]
       mov       [rbp-68],rax
       mov       rcx,[r14+28]
       cmp       [rcx],r15
       jne       near ptr M00_L30
       mov       r15,[rcx+8]
       mov       rcx,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__20_1(System.Exception)
       cmp       [rax+18],rcx
       jne       near ptr M00_L33
       mov       rcx,offset MT_System.Security.SecurityException
       cmp       [r15],rcx
       jne       near ptr M00_L32
       mov       rdx,[r15+10]
       test      rdx,rdx
       je        near ptr M00_L31
M00_L12:
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r14+8]
M00_L13:
       cmp       [r13],r13b
       test      rdx,rdx
       je        near ptr M00_L19
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,r13
       call      qword ptr [7FFF7FFBF0F0]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       near ptr M00_L19
M00_L14:
       mov       rax,[r14+18]
       mov       [rbp-70],rax
       cmp       [rax],r15
       jne       near ptr M00_L25
       cmp       dword ptr [rax+40],0FFFFFFFE
       jne       near ptr M00_L24
       mov       ecx,[rax+44]
       mov       [rbp-94],ecx
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       [rbp-94],eax
       jne       near ptr M00_L24
       xor       ecx,ecx
       mov       rax,[rbp-70]
       mov       [rax+40],ecx
       mov       rdx,rax
       mov       [rbp-88],rdx
M00_L15:
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
M00_L16:
       lea       rcx,[r14+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+14],2
       jmp       near ptr M00_L07
M00_L17:
       mov       dword ptr [rax+40],0FFFFFFFF
       mov       rdx,[rax+10]
       test      rdx,rdx
       je        near ptr M00_L26
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,21F50EE07F0
       mov       [rsp+20],rdx
       mov       rax,[rbp-78]
       mov       rdx,[rax+20]
       mov       rcx,7FFF8061FDF0
       xor       r8d,r8d
       mov       r9,21F50ED0008
       call      qword ptr [7FFF804DE130]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       r8,[rbp-78]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,21F50EE0818
       mov       [rsp+20],rdx
       mov       rax,[rbp-78]
       mov       rdx,[rax+30]
       mov       rcx,7FFF806229D0
       xor       r8d,r8d
       mov       r9,21F50ED0008
       call      qword ptr [7FFF804DE130]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       r8,[rbp-78]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L09
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FFF806214C8]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Dispose()
M00_L19:
       cmp       r12,rdi
       jne       short M00_L22
M00_L20:
       mov       rcx,[rbp-58]
       call      qword ptr [7FFF806214D0]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M00_L35
M00_L21:
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFF80070A18]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       jmp       near ptr M00_L38
M00_L22:
       cmp       r12,rdi
       jne       near ptr M00_L36
       mov       rcx,[rbp-58]
       call      qword ptr [7FFF806214D0]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L23:
       test      eax,eax
       jne       near ptr M00_L37
       jmp       short M00_L21
M00_L24:
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
       jmp       near ptr M00_L15
M00_L25:
       mov       rcx,rax
       mov       r11,7FFF7FD60B78
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L16
M00_L26:
       call      qword ptr [7FFF804DE238]
       mov       ecx,1D15
       mov       rdx,7FFF80215D90
       call      qword ptr [7FFF80097738]
       mov       r14,rax
       mov       ecx,1B61
       mov       rdx,7FFF80215D90
       call      qword ptr [7FFF80097738]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       ecx,110B
       mov       rdx,7FFF80215D90
       call      qword ptr [7FFF80097738]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF80637FA8]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,rdi
       call      qword ptr [7FFF80637138]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L27:
       mov       rcx,[r8+8]
       call      qword ptr [r8+18]
       mov       rdx,rax
       jmp       near ptr M00_L08
M00_L28:
       mov       rcx,[r8+8]
       call      qword ptr [r8+18]
       test      eax,eax
       jne       near ptr M00_L10
       jmp       near ptr M00_L18
M00_L29:
       mov       rcx,rax
       mov       r11,7FFF7FD60B80
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L18
       jmp       near ptr M00_L11
M00_L30:
       mov       r11,7FFF7FD60B88
       call      qword ptr [r11]
       mov       r15,rax
       jmp       short M00_L33
M00_L31:
       mov       rcx,21F50EE0858
       call      qword ptr [7FFF80636FE8]
       mov       [rbp-90],rax
       mov       rcx,r15
       call      qword ptr [7FFF7FE1C9A8]; System.Object.GetType()
       mov       rcx,rax
       call      qword ptr [7FFF7FE1C588]; System.RuntimeType.get_Cache()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF80637000]
       mov       rdx,rax
       mov       rcx,[rbp-90]
       call      qword ptr [7FFF80637018]
       mov       rdx,rax
       jmp       near ptr M00_L12
M00_L32:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M00_L12
M00_L33:
       mov       rdx,r15
       mov       rax,[rbp-68]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       jmp       near ptr M00_L12
M00_L34:
       mov       rcx,r14
       mov       r11,7FFF7FD60B50
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L19
       mov       rcx,r14
       mov       r11,7FFF7FD60B68
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L13
M00_L35:
       mov       rcx,[rbp-50]
       mov       edx,3A
       cmp       [rcx],ecx
       call      qword ptr [7FFF7FFBF120]; System.Text.StringBuilder.Append(Char)
       mov       r14,rax
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD60B60
       call      qword ptr [r11]
       mov       rcx,r14
       mov       rdx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF7FFBF1C8]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M00_L20
M00_L36:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD60B58
       call      qword ptr [r11]
       jmp       near ptr M00_L23
M00_L37:
       mov       rcx,[rbp-50]
       mov       edx,3A
       cmp       [rcx],ecx
       call      qword ptr [7FFF7FFBF120]; System.Text.StringBuilder.Append(Char)
       mov       r14,rax
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD60B60
       call      qword ptr [r11]
       mov       rcx,r14
       mov       rdx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF7FFBF1C8]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M00_L22
M00_L38:
       cmp       r12,rdi
       jne       short M00_L39
       mov       rcx,[rbp-58]
       call      qword ptr [7FFF806214C8]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L40
M00_L39:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD60B70
       call      qword ptr [r11]
       nop
M00_L40:
       mov       rcx,[rbp-50]
       xor       edx,edx
       call      qword ptr [7FFF80584B88]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rsi
       mov       rdx,[rbp-50]
       call      qword ptr [7FFF80584BA0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       mov       [rbp-48],r14
       mov       rcx,[rbx+18]
       lea       r8,[rbp-48]
       mov       rdx,7FFF80622C08
       cmp       [rcx],ecx
       call      qword ptr [7FFF8058F3A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF804DE238]
       mov       ecx,1D4B
       mov       rdx,7FFF80215D90
       call      qword ptr [7FFF80097738]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFF80215D90
       call      qword ptr [7FFF80097738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFF80215D90
       call      qword ptr [7FFF80097738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF80637FA8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF80637138]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L42:
       mov       rcx,offset MT_System.Func<System.Exception, System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1DED20000E0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__20_0(System.Exception)
       call      qword ptr [7FFF7FE16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DED2000130
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       rcx,offset MT_System.Func<System.Exception, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1DED2000150
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c__7`1[[System.__Canon, System.Private.CoreLib]].<FromHierarchy>b__7_0(System.__Canon)
       call      qword ptr [7FFF7FE16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DED2000158
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L44:
       mov       rcx,offset MT_System.Func<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1DED20000E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__20_1(System.Exception)
       call      qword ptr [7FFF7FE16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DED2000138
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L45:
       call      qword ptr [7FFF806361D8]
       int       3
M00_L46:
       mov       rcx,[r13+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF80584AE0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFF806214C8]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L49
M00_L48:
       mov       r11,7FFF7FD60B70
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
       call      qword ptr [7FFF80584B88]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,1DED2000160
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,[rbp-50]
       call      qword ptr [7FFF80584BA0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       nop
       add       rsp,28
       ret
; Total bytes of code 2423
```
```assembly
; DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__20_0(System.Exception)
; 			var messages = exception.FromHierarchy(ex => ex.InnerException!).Select(ex => ex.Message);
; 			                                             ^^^^^^^^^^^^^^^^^^
       mov       rax,[rdx+20]
       ret
; Total bytes of code 5
```
```assembly
; DotNetTips.Spargine.Core.ExceptionExtensions+<>c__7`1[[System.__Canon, System.Private.CoreLib]].<FromHierarchy>b__7_0(System.__Canon)
; 			return FromHierarchy(source, accumulatorFunction, s => s is not null);
; 			                                                       ^^^^^^^^^^^^^
       test      rdx,rdx
       setne     al
       movzx     eax,al
       ret
; Total bytes of code 10
```
```assembly
; DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__20_1(System.Exception)
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
       mov       rcx,21F50EE0858
       call      qword ptr [7FFF80636FE8]
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7FE1C9A8]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M03_L01
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rcx,rax
       call      qword ptr [7FFF7FE17C48]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
M03_L02:
       cmp       [rcx],ecx
       call      qword ptr [7FFF80637000]
       mov       rdx,rax
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF80637018]
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+20]
; Total bytes of code 147
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
       call      qword ptr [7FFF7FE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFF7FFBF180]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFF804DE238]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,21F50ED0390
       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M05_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M05_L04
M05_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF7FE17858]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M05_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF80637FA8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF80637138]
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
       mov       r11,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__8<System.Exception>
       cmp       [rcx],r11
       jne       short M06_L03
       mov       dword ptr [rcx+40],0FFFFFFFE
M06_L02:
       xor       eax,eax
       mov       [rbx+28],rax
       jmp       short M06_L00
M06_L03:
       mov       r11,7FFF7FD60C88
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
       mov       ecx,[rbx+14]
       cmp       ecx,1
       je        short M07_L05
       cmp       ecx,2
       jne       short M07_L04
M07_L00:
       mov       rcx,[rbx+28]
       mov       rdi,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__8<System.Exception>
       cmp       [rcx],rdi
       jne       near ptr M07_L16
       call      qword ptr [7FFF80620870]; DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__8`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
M07_L01:
       test      eax,eax
       jne       near ptr M07_L10
       cmp       qword ptr [rbx+28],0
       je        short M07_L03
       mov       rcx,[rbx+28]
       cmp       [rcx],rdi
       jne       near ptr M07_L23
       mov       dword ptr [rcx+40],0FFFFFFFE
M07_L02:
       xor       eax,eax
       mov       [rbx+28],rax
M07_L03:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
M07_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M07_L09
M07_L06:
       mov       rsi,[rbx+18]
       mov       rdi,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__8<System.Exception>
       cmp       [rsi],rdi
       jne       near ptr M07_L15
       cmp       dword ptr [rsi+40],0FFFFFFFE
       jne       near ptr M07_L14
       mov       ebp,[rsi+44]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       ebp,eax
       jne       near ptr M07_L14
       xor       ecx,ecx
       mov       [rsi+40],ecx
       mov       rbp,rsi
M07_L07:
       mov       rdx,[rsi+18]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+28]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+38]
       lea       rcx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
M07_L08:
       lea       rcx,[rbx+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+14],2
       jmp       near ptr M07_L00
M07_L09:
       mov       rdx,7FFF80682738
       call      qword ptr [7FFF7FE1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M07_L06
M07_L10:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M07_L13
M07_L11:
       mov       rsi,[rbx+20]
       mov       rcx,[rbx+28]
       cmp       [rcx],rdi
       jne       near ptr M07_L17
       mov       rdi,[rcx+8]
       mov       rcx,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__20_1(System.Exception)
       cmp       [rsi+18],rcx
       jne       near ptr M07_L22
       mov       rcx,offset MT_System.Security.SecurityException
       cmp       [rdi],rcx
       jne       near ptr M07_L21
       mov       rdx,[rdi+10]
       test      rdx,rdx
       je        short M07_L18
M07_L12:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L13:
       mov       rdx,7FFF806827F0
       call      qword ptr [7FFF7FE1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M07_L11
M07_L14:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       xor       eax,eax
       mov       [rbp+40],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+44],eax
       jmp       near ptr M07_L07
M07_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M07_L08
M07_L16:
       mov       r11,7FFF7FD60B38
       call      qword ptr [r11]
       jmp       near ptr M07_L01
M07_L17:
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       short M07_L22
M07_L18:
       mov       rcx,21F50EE0858
       call      qword ptr [7FFF80636FE8]
       mov       rsi,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7FE1C9A8]; System.Object.GetType()
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
       call      qword ptr [7FFF7FE17C48]; System.RuntimeType.InitializeCache()
M07_L20:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF80637000]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF80637018]
       mov       rdx,rax
       jmp       near ptr M07_L12
M07_L21:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M07_L12
M07_L22:
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rdx,rax
       jmp       near ptr M07_L12
M07_L23:
       mov       r11,7FFF7FD60B40
       call      qword ptr [r11]
       jmp       near ptr M07_L02
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
       je        short M08_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFFDFA68D20
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
       call      qword ptr [7FFF7FE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21F50ED0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFF7FD54000
       call      qword ptr [7FFF80097738]
       mov       rbx,rax
       call      qword ptr [7FFF806361F0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF80455ED8]
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
       call      00007FFFDFA68D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFF7FE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFF7FE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,21F50ED0008
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
       call      qword ptr [7FFF80637030]
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
       call      qword ptr [7FFF7FE15C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       jmp       qword ptr [7FFF7FE17C48]; System.RuntimeType.InitializeCache()
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
       call      qword ptr [7FFF7FFBF348]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFF7FE15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF7FFBF180]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FFF7FD54000
       call      qword ptr [7FFF80097738]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFF80635C68]
       int       3
M14_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7FD54000
       call      qword ptr [7FFF80097738]
       mov       rsi,rax
       call      qword ptr [7FFF80636DD8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF80455ED8]
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
       call      qword ptr [7FFF80636F40]
       jmp       near ptr M14_L00
M14_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFF80636F58]
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
       call      qword ptr [7FFF804DE3E8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M14_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFF7FFB4FD8]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      00007FFFDFA1FBA0
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
       mov       rdx,7FFF7FD54000
       call      qword ptr [7FFF80097738]
       mov       rsi,rax
       call      qword ptr [7FFF80636DD8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF80455ED8]
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
       call      qword ptr [7FFF80636F40]
       jmp       near ptr M15_L00
M15_L04:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF80636F58]
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
       call      qword ptr [7FFF804DE3E8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M15_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFF7FFB4FD8]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFF806361D8]
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
       call      qword ptr [7FFF80584BD0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       call      qword ptr [7FFF80636880]
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
       call      qword ptr [7FFFDF89DAC8]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       je        near ptr M00_L41
       mov       rcx,2AE60802128
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L42
M00_L00:
       mov       rcx,2AE60802150
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L43
M00_L01:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__8<System.Exception>
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
       mov       rcx,2AE60802130
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
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2AE60802158
       mov       rsi,[rcx]
       mov       r15,rsi
       mov       rcx,[r15+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L46
       lea       rcx,[r15+20]
       mov       r8,[rbp-40]
       test      rcx,rcx
       je        near ptr M00_L45
       xor       edx,edx
       call      00007FFFDFA1FBA0
       cmp       rax,[rbp-40]
       jne       near ptr M00_L46
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
       jne       near ptr M00_L34
       mov       eax,[r14+14]
       cmp       eax,1
       je        near ptr M00_L16
       cmp       eax,2
       jne       near ptr M00_L13
M00_L07:
       mov       r12,[r14+28]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__8<System.Exception>
       cmp       [r12],rcx
       jne       near ptr M00_L29
       mov       eax,[r12+40]
       test      eax,eax
       jne       near ptr M00_L19
       mov       dword ptr [r12+40],0FFFFFFFF
       mov       rdx,[r12+10]
       test      rdx,rdx
       je        near ptr M00_L26
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2EEF58307F0
       mov       [rsp+20],rdx
       mov       rdx,[r12+20]
       mov       rcx,7FFF8062FB98
       xor       r8d,r8d
       mov       r9,2EEF5820008
       call      qword ptr [7FFF804EE070]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       lea       rcx,[r12+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2EEF5830818
       mov       [rsp+20],rdx
       mov       rdx,[r12+30]
       mov       rcx,7FFF80632860
       xor       r8d,r8d
       mov       r9,2EEF5820008
       call      qword ptr [7FFF804EE070]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       lea       rcx,[r12+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       cmp       qword ptr [r12+10],0
       je        near ptr M00_L21
       mov       rax,[r12+30]
       mov       rdx,[r12+10]
       mov       rcx,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c__7`1[[System.__Canon, System.Private.CoreLib]].<FromHierarchy>b__7_0(System.__Canon)
       cmp       [rax+18],rcx
       jne       near ptr M00_L28
M00_L09:
       mov       rdx,[r12+10]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r12+40],1
M00_L10:
       mov       r12,[r14+20]
       mov       rcx,[r14+28]
       mov       rax,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__8<System.Exception>
       cmp       [rcx],rax
       jne       near ptr M00_L30
       mov       rax,[rcx+8]
       mov       rcx,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__20_1(System.Exception)
       cmp       [r12+18],rcx
       jne       near ptr M00_L33
       mov       rcx,offset MT_System.Security.SecurityException
       cmp       [rax],rcx
       jne       near ptr M00_L32
       mov       [rbp-60],rax
       mov       rdx,[rax+10]
       test      rdx,rdx
       je        near ptr M00_L31
M00_L11:
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r14+8]
M00_L12:
       cmp       [r15],r15b
       test      rdx,rdx
       je        short M00_L13
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,r15
       call      qword ptr [7FFF801E70D8]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L13:
       cmp       r13,rdi
       jne       near ptr M00_L22
M00_L14:
       mov       rcx,[rbp-58]
       call      qword ptr [7FFF80631360]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M00_L35
M00_L15:
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFF80200A18]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       jmp       near ptr M00_L38
M00_L16:
       mov       r12,[r14+18]
       mov       rax,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__8<System.Exception>
       cmp       [r12],rax
       jne       near ptr M00_L25
       cmp       dword ptr [r12+40],0FFFFFFFE
       jne       near ptr M00_L24
       mov       eax,[r12+44]
       mov       [rbp-74],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       [rbp-74],eax
       jne       near ptr M00_L24
       xor       ecx,ecx
       mov       [r12+40],ecx
       mov       rdx,r12
       mov       [rbp-70],rdx
M00_L17:
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
M00_L18:
       lea       rcx,[r14+28]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+14],2
       jmp       near ptr M00_L07
M00_L19:
       cmp       eax,1
       jne       short M00_L21
       mov       dword ptr [r12+40],0FFFFFFFF
       mov       rax,[r12+20]
       mov       rdx,[r12+10]
       mov       rcx,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__20_0(System.Exception)
       cmp       [rax+18],rcx
       jne       near ptr M00_L27
       mov       rdx,[rdx+20]
M00_L20:
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L21:
       mov       rcx,r14
       call      qword ptr [7FFF80631358]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       near ptr M00_L13
M00_L22:
       cmp       r13,rdi
       jne       near ptr M00_L36
       mov       rcx,[rbp-58]
       call      qword ptr [7FFF80631360]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L23:
       test      eax,eax
       jne       near ptr M00_L37
       jmp       near ptr M00_L15
M00_L24:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__8<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-68],rdx
       xor       eax,eax
       mov       [rdx+40],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       rdx,[rbp-68]
       mov       [rdx+44],eax
       mov       [rbp-70],rdx
       jmp       near ptr M00_L17
M00_L25:
       mov       rcx,r12
       mov       r11,7FFF7FD70B88
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L18
M00_L26:
       call      qword ptr [7FFF804EE178]
       mov       ecx,1D15
       mov       rdx,7FFF80225770
       call      qword ptr [7FFF7FE2F210]
       mov       r12,rax
       mov       ecx,1B61
       mov       rdx,7FFF80225770
       call      qword ptr [7FFF7FE2F210]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF7FE2D9C8]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,110B
       mov       rdx,7FFF80225770
       call      qword ptr [7FFF7FE2F210]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFF7FE2D9C8]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF80647EB8]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rdi
       call      qword ptr [7FFF806470F0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L27:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       jmp       near ptr M00_L20
M00_L28:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M00_L09
       jmp       near ptr M00_L21
M00_L29:
       mov       rcx,r12
       mov       r11,7FFF7FD70B90
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L21
       jmp       near ptr M00_L10
M00_L30:
       mov       r11,7FFF7FD70B98
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdx
       jmp       short M00_L33
M00_L31:
       mov       rcx,2EEF5830858
       call      qword ptr [7FFF80647030]
       mov       r12,rax
       mov       rcx,[rbp-60]
       call      qword ptr [7FFF800F61C0]; System.Object.GetType()
       mov       rcx,rax
       call      qword ptr [7FFF800F5F98]; System.RuntimeType.get_Cache()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF80647048]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF80647060]
       mov       rdx,rax
       jmp       near ptr M00_L11
M00_L32:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M00_L11
M00_L33:
       mov       rdx,rax
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       mov       rdx,rax
       jmp       near ptr M00_L11
M00_L34:
       mov       rcx,r14
       mov       r11,7FFF7FD70B60
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L13
       mov       rcx,r14
       mov       r11,7FFF7FD70B78
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L12
M00_L35:
       mov       rcx,[rbp-50]
       mov       edx,2C
       cmp       [rcx],ecx
       call      qword ptr [7FFF801E7108]; System.Text.StringBuilder.Append(Char)
       mov       r14,rax
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD70B70
       call      qword ptr [r11]
       mov       rcx,r14
       mov       rdx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF801E71B0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M00_L14
M00_L36:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD70B68
       call      qword ptr [r11]
       jmp       near ptr M00_L23
M00_L37:
       mov       rcx,[rbp-50]
       mov       edx,2C
       cmp       [rcx],ecx
       call      qword ptr [7FFF801E7108]; System.Text.StringBuilder.Append(Char)
       mov       r14,rax
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD70B70
       call      qword ptr [r11]
       mov       rcx,r14
       mov       rdx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF801E71B0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M00_L22
M00_L38:
       cmp       r13,rdi
       jne       short M00_L39
       mov       rcx,[rbp-58]
       call      qword ptr [7FFF80631358]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L40
M00_L39:
       mov       rcx,[rbp-58]
       mov       r11,7FFF7FD70B80
       call      qword ptr [r11]
       nop
M00_L40:
       mov       rcx,[rbp-50]
       xor       edx,edx
       call      qword ptr [7FFF80594AC8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rsi
       mov       rdx,[rbp-50]
       call      qword ptr [7FFF80594AE0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       mov       [rbp-48],r14
       mov       rcx,[rbx+18]
       lea       r8,[rbp-48]
       mov       rdx,7FFF80632A98
       cmp       [rcx],ecx
       call      qword ptr [7FFF8059F2E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L41:
       call      qword ptr [7FFF804EE178]
       mov       ecx,1D4B
       mov       rdx,7FFF80225770
       call      qword ptr [7FFF7FE2F210]
       mov       rbx,rax
       mov       ecx,1B61
       mov       rdx,7FFF80225770
       call      qword ptr [7FFF7FE2F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7FE2D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFF80225770
       call      qword ptr [7FFF7FE2F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7FE2D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF80647EB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF806470F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L42:
       mov       rcx,offset MT_System.Func<System.Exception, System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2AE608020D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__20_0(System.Exception)
       call      qword ptr [7FFF7FE26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2AE60802128
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       rcx,offset MT_System.Func<System.Exception, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,2AE60802148
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c__7`1[[System.__Canon, System.Private.CoreLib]].<FromHierarchy>b__7_0(System.__Canon)
       call      qword ptr [7FFF7FE26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2AE60802150
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L44:
       mov       rcx,offset MT_System.Func<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2AE608020D8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__20_1(System.Exception)
       call      qword ptr [7FFF7FE26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2AE60802130
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L45:
       call      qword ptr [7FFF80646238]
       int       3
M00_L46:
       mov       rcx,[r15+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF80594A20]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L47
       add       r15,2C
       lock dec  dword ptr [r15]
       jmp       near ptr M00_L03
M00_L47:
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
       jne       short M00_L48
       call      qword ptr [7FFF80631358]; System.Linq.Enumerable+IEnumerableSelectIterator`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Dispose()
       jmp       short M00_L49
M00_L48:
       mov       r11,7FFF7FD70B80
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
       call      qword ptr [7FFF80594AC8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,2AE60802158
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,[rbp-50]
       call      qword ptr [7FFF80594AE0]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       nop
       add       rsp,28
       ret
; Total bytes of code 2387
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
       je        short M01_L01
M01_L00:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L01:
       test      r8,r8
       je        short M01_L02
       mov       rdx,r8
       jmp       short M01_L00
M01_L02:
       call      qword ptr [7FFF804EE178]
       mov       rsi,rax
       mov       rcx,[rsp+60]
       mov       rdx,2EEF5820390
       call      qword ptr [7FFF7FE2D9C8]; System.String.Concat(System.String, System.String)
       test      rbx,rbx
       jne       short M01_L03
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFF7FE2D9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L03:
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFF7FE2D9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF80647EB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF806470F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 157
```
```assembly
; DotNetTips.Spargine.Core.ExceptionExtensions+<>c__7`1[[System.__Canon, System.Private.CoreLib]].<FromHierarchy>b__7_0(System.__Canon)
; 			return FromHierarchy(source, accumulatorFunction, s => s is not null);
; 			                                                       ^^^^^^^^^^^^^
       test      rdx,rdx
       setne     al
       movzx     eax,al
       ret
; Total bytes of code 10
```
```assembly
; DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__20_1(System.Exception)
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
       mov       rcx,2EEF5830858
       call      qword ptr [7FFF80647030]
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FFF800F61C0]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M03_L01
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rcx,rax
       call      qword ptr [7FFF800F56C8]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
M03_L02:
       cmp       [rcx],ecx
       call      qword ptr [7FFF80647048]
       mov       rdx,rax
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF80647060]
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+20]
; Total bytes of code 147
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
       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFF801E7168]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
; Total bytes of code 102
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
       je        short M05_L05
       cmp       ecx,2
       jne       short M05_L04
M05_L00:
       mov       rcx,[rbx+28]
       mov       rdi,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__8<System.Exception>
       cmp       [rcx],rdi
       jne       near ptr M05_L16
       call      qword ptr [7FFF80630700]; DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__8`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
M05_L01:
       test      eax,eax
       jne       near ptr M05_L10
       cmp       qword ptr [rbx+28],0
       je        short M05_L03
       mov       rcx,[rbx+28]
       cmp       [rcx],rdi
       jne       near ptr M05_L23
       mov       dword ptr [rcx+40],0FFFFFFFE
M05_L02:
       xor       eax,eax
       mov       [rbx+28],rax
M05_L03:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
M05_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M05_L09
M05_L06:
       mov       rsi,[rbx+18]
       mov       rdi,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__8<System.Exception>
       cmp       [rsi],rdi
       jne       near ptr M05_L15
       cmp       dword ptr [rsi+40],0FFFFFFFE
       jne       near ptr M05_L14
       mov       ebp,[rsi+44]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       ebp,eax
       jne       near ptr M05_L14
       xor       ecx,ecx
       mov       [rsi+40],ecx
       mov       rbp,rsi
M05_L07:
       mov       rdx,[rsi+18]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+28]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+38]
       lea       rcx,[rbp+30]
       call      CORINFO_HELP_ASSIGN_REF
M05_L08:
       lea       rcx,[rbx+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+14],2
       jmp       near ptr M05_L00
M05_L09:
       mov       rdx,7FFF806929E8
       call      qword ptr [7FFF7FE2F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M05_L06
M05_L10:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M05_L13
M05_L11:
       mov       rsi,[rbx+20]
       mov       rcx,[rbx+28]
       cmp       [rcx],rdi
       jne       near ptr M05_L17
       mov       rdi,[rcx+8]
       mov       rcx,offset DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__20_1(System.Exception)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L22
       mov       rcx,offset MT_System.Security.SecurityException
       cmp       [rdi],rcx
       jne       near ptr M05_L21
       mov       rdx,[rdi+10]
       test      rdx,rdx
       je        short M05_L18
M05_L12:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L13:
       mov       rdx,7FFF80692AA0
       call      qword ptr [7FFF7FE2F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M05_L11
M05_L14:
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       xor       eax,eax
       mov       [rbp+40],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+44],eax
       jmp       near ptr M05_L07
M05_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M05_L08
M05_L16:
       mov       r11,7FFF7FD70B48
       call      qword ptr [r11]
       jmp       near ptr M05_L01
M05_L17:
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       short M05_L22
M05_L18:
       mov       rcx,2EEF5830858
       call      qword ptr [7FFF80647030]
       mov       rsi,rax
       mov       rcx,rdi
       call      qword ptr [7FFF800F61C0]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M05_L19
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M05_L19
       mov       rax,rcx
       jmp       short M05_L20
M05_L19:
       mov       rcx,rax
       call      qword ptr [7FFF800F56C8]; System.RuntimeType.InitializeCache()
M05_L20:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF80647048]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF80647060]
       mov       rdx,rax
       jmp       near ptr M05_L12
M05_L21:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M05_L12
M05_L22:
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rdx,rax
       jmp       near ptr M05_L12
M05_L23:
       mov       r11,7FFF7FD70B50
       call      qword ptr [r11]
       jmp       near ptr M05_L02
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
       je        short M06_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFFDFA68D20
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
       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2EEF5820008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFF7FD64000
       call      qword ptr [7FFF7FE2F210]
       mov       rbx,rax
       call      qword ptr [7FFF80646250]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF80465F08]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; DotNetTips.Spargine.Core.ExceptionExtensions+<>c.<GetAllMessages>b__20_0(System.Exception)
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
       jne       short M08_L01
M08_L00:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       add       rsp,20
       pop       rbx
       ret
M08_L01:
       mov       rcx,[rbx+28]
       mov       r11,offset MT_DotNetTips.Spargine.Core.ExceptionExtensions+<FromHierarchy>d__8<System.Exception>
       cmp       [rcx],r11
       jne       short M08_L03
       mov       dword ptr [rcx+40],0FFFFFFFE
M08_L02:
       xor       eax,eax
       mov       [rbx+28],rax
       jmp       short M08_L00
M08_L03:
       mov       r11,7FFF7FD70C98
       call      qword ptr [r11]
       jmp       short M08_L02
; Total bytes of code 83
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
       call      00007FFFDFA68D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2EEF5820008
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
       call      qword ptr [7FFF80646F58]
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
       call      qword ptr [7FFF7FE25C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
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
       jmp       qword ptr [7FFF800F56C8]; System.RuntimeType.InitializeCache()
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
       call      qword ptr [7FFF801E7330]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFF7FE25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF801E7168]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FFF7FD64000
       call      qword ptr [7FFF7FE2F210]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFF80645CC8]
       int       3
M14_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7FD64000
       call      qword ptr [7FFF7FE2F210]
       mov       rsi,rax
       call      qword ptr [7FFF80646E08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF80465F08]
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
       call      qword ptr [7FFF80646F88]
       jmp       near ptr M14_L00
M14_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFF80646FA0]
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
       call      qword ptr [7FFF804EE328]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M14_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFF7FE2F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      00007FFFDFA1FBA0
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
       mov       rdx,7FFF7FD64000
       call      qword ptr [7FFF7FE2F210]
       mov       rsi,rax
       call      qword ptr [7FFF80646E08]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF80465F08]
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
       call      qword ptr [7FFF80646F88]
       jmp       near ptr M15_L00
M15_L04:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF80646FA0]
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
       call      qword ptr [7FFF804EE328]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M15_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFF7FE2F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FFF80646238]
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
       call      qword ptr [7FFF80594B10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       call      qword ptr [7FFF806468E0]
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
       call      qword ptr [7FFFDF89DAC8]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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

