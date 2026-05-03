## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.RetrieveAllExceptionMessages()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.ArithmeticException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,80131500E0434352
       mov       [rsi+68],rcx
       mov       rcx,2580B430A18
       mov       [rsi+10],rcx
       mov       dword ptr [rsi+6C],80070216
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,80131500E0434352
       mov       [rdi+68],rcx
       mov       rcx,2580B430A40
       mov       [rdi+10],rcx
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+6C],80004003
       mov       rcx,rdi
       call      qword ptr [7FF97695DD28]; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptionMessages(System.Exception)
       mov       [rsp+28],rax
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
; Total bytes of code 181
```
```assembly
; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptionMessages(System.Exception)
; 		exception = exception.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var exceptions = RetrieveAllExceptions(exception);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return new ReadOnlyCollection<string>([.. exceptions.Select(ex => ex.Message)]);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       test      rcx,rcx
       je        near ptr M01_L42
       call      qword ptr [7FF97695DD88]; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,21776400230
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2178C4001C8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L43
M01_L00:
       test      rbx,rbx
       je        near ptr M01_L44
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Exception>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L45
       mov       r14,rbx
       test      r14,r14
       je        near ptr M01_L49
       mov       rdx,rbx
       mov       rcx,offset MT_System.Exception[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M01_L46
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<System.Exception>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M01_L48
       mov       r13,offset MT_System.Linq.Enumerable+IListSelectIterator<System.Exception, System.String>
       mov       rcx,r13
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r13+10],eax
       lea       rcx,[r13+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       test      r13,r13
       je        near ptr M01_L50
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbx,rax
       test      rbx,rbx
       jne       near ptr M01_L51
       mov       rax,offset MT_System.Linq.Enumerable+IListSelectIterator<System.Exception, System.String>
       mov       rbx,rax
       cmp       [r13],rbx
       jne       near ptr M01_L55
       cmp       dword ptr [r13+14],0
       jne       short M01_L02
       mov       edi,[r13+10]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       edi,eax
       jne       short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[r13+18]
       mov       r13,[r13+20]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+10],eax
       lea       rcx,[rdi+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,rdi
M01_L03:
       mov       dword ptr [r13+14],1
M01_L04:
       mov       [rbp-38],r13
M01_L05:
       mov       r13,[rbp-38]
       cmp       [r13],rbx
       jne       near ptr M01_L34
       mov       ecx,[r13+14]
       cmp       ecx,1
       je        near ptr M01_L12
       cmp       ecx,2
       jne       near ptr M01_L38
M01_L06:
       mov       rcx,[r13+28]
       mov       r14,offset MT_System.Collections.Generic.List<System.Exception>+Enumerator
       cmp       [rcx],r14
       jne       near ptr M01_L27
       lea       rdi,[rcx+8]
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       eax,[rdi+10]
       cmp       eax,[rcx+14]
       jne       near ptr M01_L35
       mov       ecx,[rdi+14]
       cmp       ecx,[rdx+10]
       jae       near ptr M01_L17
       mov       rdx,[rdx+8]
       cmp       ecx,[rdx+8]
       jae       near ptr M01_L36
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
M01_L07:
       mov       rdi,[r13+20]
       mov       rcx,[r13+28]
       cmp       [rcx],r14
       jne       near ptr M01_L28
       mov       r14,[rcx+10]
       mov       rcx,offset DotNetTips.Spargine.Core.Logging.LoggingHelper+<>c.<RetrieveAllExceptionMessages>b__9_0(System.Exception)
       cmp       [rdi+18],rcx
       jne       near ptr M01_L33
       mov       rcx,offset MT_System.ArgumentNullException
       cmp       [r14],rcx
       jne       near ptr M01_L15
       cmp       qword ptr [r14+10],0
       jne       short M01_L08
       cmp       dword ptr [r14+6C],80070057
       jne       short M01_L08
       mov       rcx,2580B430B58
       call      qword ptr [7FF9769E6280]
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rdi,[r14+10]
       test      rdi,rdi
       je        near ptr M01_L29
M01_L09:
       mov       r15,rdi
       mov       rcx,[r14+70]
       test      rcx,rcx
       je        short M01_L10
       cmp       dword ptr [rcx+8],0
       jne       near ptr M01_L32
M01_L10:
       lea       rcx,[r13+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r13+8]
M01_L11:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M01_L16
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L12:
       mov       rdi,[r13+18]
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
       cmp       [rdi],rcx
       jne       near ptr M01_L26
       mov       rcx,[rdi+8]
       mov       r11,offset MT_System.Collections.Generic.List<System.Exception>
       cmp       [rcx],r11
       jne       near ptr M01_L22
       mov       r14d,[rcx+10]
M01_L13:
       test      r14d,r14d
       je        near ptr M01_L25
       mov       rdi,[rdi+8]
       mov       rcx,offset MT_System.Collections.Generic.List<System.Exception>
       cmp       [rdi],rcx
       jne       near ptr M01_L24
       cmp       dword ptr [rdi+10],0
       je        near ptr M01_L23
       mov       r14,offset MT_System.Collections.Generic.List<System.Exception>+Enumerator
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rdi+14]
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],r15d
       mov       [r14+1C],ecx
M01_L14:
       lea       rcx,[r13+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r13+14],2
       jmp       near ptr M01_L06
M01_L15:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M01_L10
M01_L16:
       mov       rcx,rsi
       call      qword ptr [7FF9764AE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L05
M01_L17:
       xor       eax,eax
       mov       [rdi+8],rax
       mov       dword ptr [rdi+14],0FFFFFFFF
M01_L18:
       cmp       qword ptr [r13+28],0
       je        short M01_L20
       mov       rcx,[r13+28]
       cmp       [rcx],r14
       jne       near ptr M01_L37
M01_L19:
       xor       ecx,ecx
       mov       [r13+28],rcx
M01_L20:
       xor       ecx,ecx
       mov       [r13+8],rcx
       mov       dword ptr [r13+14],0FFFFFFFF
       jmp       near ptr M01_L38
M01_L21:
       mov       rcx,r13
       mov       r11,7FF976280AC8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M01_L11
M01_L22:
       mov       r11,7FF976280B00
       call      qword ptr [r11]
       mov       r14d,eax
       jmp       near ptr M01_L13
M01_L23:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<System.Exception>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2178C400250
       mov       r14,[rcx]
       jmp       near ptr M01_L14
M01_L24:
       mov       rcx,rdi
       mov       r11,7FF976280B08
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M01_L14
M01_L25:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<System.Exception>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2178C400250
       mov       r14,[rcx]
       jmp       near ptr M01_L14
M01_L26:
       mov       rcx,rdi
       mov       r11,7FF976280AE8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M01_L14
M01_L27:
       mov       r11,7FF976280AF0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L18
       jmp       near ptr M01_L07
M01_L28:
       mov       r11,7FF976280AF8
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M01_L33
M01_L29:
       mov       rcx,2580B430B98
       call      qword ptr [7FF9769E6280]
       mov       rdi,rax
       mov       rcx,r14
       call      qword ptr [7FF97633C9C0]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M01_L30
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M01_L30
       mov       rax,rcx
       jmp       short M01_L31
M01_L30:
       mov       rcx,rax
       call      qword ptr [7FF976337C48]; System.RuntimeType.InitializeCache()
M01_L31:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9769E6298]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9769E62B0]
       mov       rdi,rax
       jmp       near ptr M01_L09
M01_L32:
       mov       rcx,2580B430B18
       call      qword ptr [7FF9769E6280]
       mov       rcx,rax
       mov       rdx,[r14+70]
       call      qword ptr [7FF9769E62B0]
       mov       r8,rax
       mov       rcx,rdi
       mov       rdx,2580B427A38
       call      qword ptr [7FF976337840]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       jmp       near ptr M01_L10
M01_L33:
       mov       rdx,r14
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r15,rax
       jmp       near ptr M01_L10
M01_L34:
       mov       rcx,r13
       mov       r11,7FF976280AC0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L21
       jmp       near ptr M01_L56
M01_L35:
       call      qword ptr [7FF97655C150]
       int       3
M01_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L37:
       mov       r11,7FF976280B10
       call      qword ptr [r11]
       jmp       near ptr M01_L19
M01_L38:
       cmp       qword ptr [r13+28],0
       je        short M01_L40
       mov       rcx,[r13+28]
       mov       r14,offset MT_System.Collections.Generic.List<System.Exception>+Enumerator
       cmp       [rcx],r14
       jne       near ptr M01_L57
M01_L39:
       xor       ecx,ecx
       mov       [r13+28],rcx
M01_L40:
       xor       ecx,ecx
       mov       [r13+8],rcx
       mov       dword ptr [r13+14],0FFFFFFFF
M01_L41:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L42:
       call      qword ptr [7FF9768CF0D8]
       mov       ecx,1D35
       mov       rdx,7FF976605548
       call      qword ptr [7FF9765577B0]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FF976605548
       call      qword ptr [7FF9765577B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF976337858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,111F
       mov       rdx,7FF976605548
       call      qword ptr [7FF9765577B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF976337858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9769E71F8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9769E6340]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L43:
       mov       rcx,offset MT_System.Func<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2178C4001B0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Logging.LoggingHelper+<>c.<RetrieveAllExceptionMessages>b__9_0(System.Exception)
       call      qword ptr [7FF976336BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2178C4001C8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
M01_L44:
       mov       ecx,11
       call      qword ptr [7FF976557E70]
       int       3
M01_L45:
       mov       rcx,r14
       mov       rdx,offset MT_System.Linq.Enumerable+Iterator<System.Exception>
       mov       r8,7FF976A36300
       call      qword ptr [7FF976335920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rcx,r14
       mov       rdx,rdi
       call      rax
       mov       r13,rax
       jmp       near ptr M01_L01
M01_L46:
       cmp       dword ptr [r15+8],0
       jne       short M01_L47
       mov       rcx,offset MT_System.Array+EmptyArray<System.String>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2178C400268
       mov       r13,[rcx]
       jmp       near ptr M01_L01
M01_L47:
       mov       rcx,offset MT_System.Linq.Enumerable+ArraySelectIterator<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rdi
       call      qword ptr [7FF9769E71B0]
       jmp       near ptr M01_L01
M01_L48:
       mov       rcx,offset MT_System.Linq.Enumerable+ListSelectIterator<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r15
       mov       r8,rdi
       call      qword ptr [7FF9769E71C8]
       jmp       near ptr M01_L01
M01_L49:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableSelectIterator<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8,rdi
       call      qword ptr [7FF9769E71E0]
       jmp       near ptr M01_L01
M01_L50:
       mov       ecx,17
       call      qword ptr [7FF97655C240]
       int       3
M01_L51:
       mov       rcx,rbx
       mov       r11,7FF976280AD8
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       jle       near ptr M01_L41
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       sub       ecx,[rsi+10]
       cmp       ecx,r13d
       jge       short M01_L54
       mov       ecx,r13d
       add       ecx,[rsi+10]
       jo        near ptr M01_L58
       mov       rdx,[rsi+8]
       cmp       dword ptr [rdx+8],0
       je        short M01_L52
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M01_L53
M01_L52:
       mov       edx,4
M01_L53:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rsi
       call      qword ptr [7FF9764AE3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L54:
       mov       rdx,[rsi+8]
       mov       r8d,[rsi+10]
       mov       rcx,rbx
       mov       r11,7FF976280AE0
       call      qword ptr [r11]
       add       [rsi+10],r13d
       inc       dword ptr [rsi+14]
       jmp       near ptr M01_L41
M01_L55:
       mov       rcx,r13
       mov       r11,7FF976280AB8
       call      qword ptr [r11]
       mov       r13,rax
       jmp       near ptr M01_L04
M01_L56:
       mov       rcx,r13
       mov       r11,7FF976280AD0
       call      qword ptr [r11]
       jmp       near ptr M01_L41
M01_L57:
       mov       r11,7FF976280B18
       call      qword ptr [r11]
       jmp       near ptr M01_L39
M01_L58:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M01_L62
       mov       rbx,offset MT_System.Linq.Enumerable+IListSelectIterator<System.Exception, System.String>
       mov       r13,[rbp-38]
       cmp       [r13],rbx
       jne       short M01_L61
       mov       rcx,[r13+28]
       test      rcx,rcx
       je        short M01_L60
       mov       r14,offset MT_System.Collections.Generic.List<System.Exception>+Enumerator
       cmp       [rcx],r14
       je        short M01_L59
       mov       r11,7FF976280B18
       call      qword ptr [r11]
M01_L59:
       xor       ecx,ecx
       mov       [r13+28],rcx
M01_L60:
       xor       ecx,ecx
       mov       [r13+8],rcx
       mov       dword ptr [r13+14],0FFFFFFFF
       jmp       short M01_L62
M01_L61:
       mov       rcx,r13
       mov       r11,7FF976280AD0
       call      qword ptr [r11]
M01_L62:
       nop
       add       rsp,28
       ret
; Total bytes of code 2305
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.RetrieveAllExceptions()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.ArithmeticException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,80131500E0434352
       mov       [rsi+68],rcx
       mov       rcx,19E173D0A18
       mov       [rsi+10],rcx
       mov       dword ptr [rsi+6C],80070216
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,80131500E0434352
       mov       [rdi+68],rcx
       mov       rcx,19E173D0A40
       mov       [rdi+10],rcx
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+6C],80004003
       mov       rcx,offset MT_System.Collections.Generic.List<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,15D984001D0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       ebp,[rsi+10]
       cmp       [rcx+8],ebp
       ja        short M00_L02
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF97648E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rdi,[rdi+20]
       test      rdi,rdi
       jne       short M00_L00
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],rdi
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
       ret
M00_L02:
       lea       edx,[rbp+1]
       mov       [rsi+10],edx
       mov       edx,ebp
       mov       r8,rdi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M00_L01
; Total bytes of code 298
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M01_L04
       mov       r15d,4
M01_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M01_L06
       cmp       [r14+8],r15d
       je        short M01_L03
       test      r15d,r15d
       jle       near ptr M01_L08
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+70]
       test      rax,rax
       je        short M01_L05
       mov       rcx,rax
M01_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jg        short M01_L07
M01_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M01_L00
M01_L05:
       mov       rdx,7FF97698AFA8
       call      qword ptr [7FF97631C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L01
M01_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF9768A6658]
       int       3
M01_L07:
       mov       rcx,r14
       mov       r8d,edi
       mov       rdx,r15
       call      qword ptr [7FF976317048]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M01_L02
M01_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+78]
       test      rdx,rdx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FF9769CC8F8
       call      qword ptr [7FF97631C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
; Total bytes of code 315
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       je        short M02_L01
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M02_L01
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF97631D908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M02_L00:
       call      qword ptr [7FF97693EE68]
       int       3
M02_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF9D5FB8D10
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
```

