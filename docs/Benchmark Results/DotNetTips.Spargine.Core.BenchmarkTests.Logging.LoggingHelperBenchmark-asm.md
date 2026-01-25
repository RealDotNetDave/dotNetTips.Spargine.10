## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.RetrieveAllExceptionMessages()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.ArithmeticException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,80131500E0434352
       mov       [rsi+68],rcx
       mov       rcx,290A6180970
       mov       [rsi+10],rcx
       mov       dword ptr [rsi+6C],80070216
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,80131500E0434352
       mov       [rdi+68],rcx
       mov       rcx,290A6180998
       mov       [rdi+10],rcx
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+6C],80004003
       mov       rcx,rdi
       call      qword ptr [7FF86ED5F978]; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
       mov       rsi,rax
       mov       rcx,25027000158
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L13
M00_L00:
       test      rsi,rsi
       je        near ptr M00_L19
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Exception>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M00_L14
       mov       rbp,rsi
       test      rbp,rbp
       je        near ptr M00_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.Exception[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L15
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<System.Exception>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L17
       mov       rcx,offset MT_System.Linq.Enumerable+IListSelectIterator<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       test      r15,r15
       je        near ptr M00_L19
       mov       rdx,r15
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L32
       mov       rcx,offset MT_System.Linq.Enumerable+IListSelectIterator<System.Exception, System.String>
       cmp       [rsi],rcx
       jne       near ptr M00_L31
       mov       rcx,[rsi+18]
       mov       r15,rcx
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
       cmp       [rcx],r11
       jne       near ptr M00_L21
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<System.Exception>
       cmp       [rcx],r11
       jne       near ptr M00_L20
       mov       edi,[rcx+10]
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      edi,edi
       jl        near ptr M00_L22
       test      edi,edi
       je        near ptr M00_L23
       mov       edx,edi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L03:
       inc       dword ptr [rbp+14]
       mov       rdx,[rbp+8]
       cmp       [rdx+8],edi
       jl        near ptr M00_L05
       cmp       edi,[rbp+10]
       jge       near ptr M00_L08
       mov       rdx,[rbp+8]
       mov       ecx,[rbp+10]
       sub       ecx,edi
       test      rdx,rdx
       je        near ptr M00_L27
       lea       rax,[rdx+10]
       xor       r8d,r8d
       mov       r10,[rdx]
       cmp       dword ptr [r10+4],18
       jne       near ptr M00_L28
M00_L04:
       mov       r9d,edi
       sub       r9d,r8d
       cmp       edi,r8d
       jl        near ptr M00_L29
       mov       r8d,r9d
       or        r8d,ecx
       jl        near ptr M00_L29
       lea       r8d,[r9+rcx]
       cmp       r8d,[rdx+8]
       ja        near ptr M00_L29
       movzx     edx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rdx
       add       r8,rax
       mov       ecx,ecx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       je        near ptr M00_L30
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FF86EDED038]
       jmp       short M00_L08
M00_L05:
       mov       rdx,[rbp+8]
       cmp       dword ptr [rdx+8],0
       jne       short M00_L09
       mov       edx,4
M00_L06:
       mov       ecx,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,ecx
       cmp       edx,edi
       cmovl     edx,edi
       cmp       edx,[rbp+10]
       jl        near ptr M00_L24
       mov       rcx,[rbp+8]
       cmp       [rcx+8],edx
       je        short M00_L08
       test      edx,edx
       jle       near ptr M00_L26
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       cmp       dword ptr [rbp+10],0
       jg        near ptr M00_L25
M00_L07:
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       [rbp+10],edi
       mov       edi,[rbp+10]
       mov       r14,[rbp+8]
       cmp       [r14+8],edi
       jae       short M00_L10
       call      qword ptr [7FF86E8A79A8]
       int       3
M00_L09:
       mov       rdx,[rbp+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M00_L06
M00_L10:
       add       r14,10
       mov       rsi,[rsi+20]
       xor       r13d,r13d
       test      edi,edi
       jle       short M00_L12
M00_L11:
       lea       rcx,[r14+r13*8]
       mov       [rsp+28],rcx
       mov       rcx,r15
       mov       edx,r13d
       mov       r11,7FF86E5D0B30
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rcx,[rsp+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       cmp       r13d,edi
       jl        short M00_L11
M00_L12:
       cmp       [rbp],bpl
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L13:
       mov       rcx,offset MT_System.Func<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,25027000140
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Logging.LoggingHelper+<>c.<RetrieveAllExceptionMessages>b__9_0(System.Exception)
       call      qword ptr [7FF86E686BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25027000158
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L14:
       mov       rcx,rbp
       mov       rdx,offset MT_System.Linq.Enumerable+Iterator<System.Exception>
       mov       r8,7FF86EE3EC00
       call      qword ptr [7FF86E685920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rcx,rbp
       mov       rdx,rdi
       call      rax
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L15:
       cmp       dword ptr [r14+8],0
       jne       short M00_L16
       mov       rcx,offset MT_System.Array+EmptyArray<System.String>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,250270001F8
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L16:
       mov       rcx,offset MT_System.Linq.Enumerable+ArraySelectIterator<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FF86EDECC48]
       jmp       near ptr M00_L01
M00_L17:
       mov       rcx,offset MT_System.Linq.Enumerable+ListSelectIterator<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FF86EDECC60]
       jmp       near ptr M00_L01
M00_L18:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableSelectIterator<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF86EDECC78]
       jmp       near ptr M00_L01
M00_L19:
       mov       ecx,11
       call      qword ptr [7FF86E8A7DF8]
       int       3
M00_L20:
       mov       r11,7FF86E5D0B28
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L02
M00_L21:
       mov       r11,7FF86E5D0B20
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L02
M00_L22:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF86EC859B0]
       int       3
M00_L23:
       mov       rcx,25011000230
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L24:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF86EC859B0]
       int       3
M00_L25:
       mov       rcx,[rbp+8]
       mov       r8d,[rbp+10]
       mov       rdx,r14
       call      qword ptr [7FF86E7F4FD8]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       near ptr M00_L07
M00_L26:
       mov       rcx,25011000230
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L27:
       mov       ecx,2
       call      qword ptr [7FF86E8AC1C8]
       int       3
M00_L28:
       mov       r9d,[r10+4]
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
       jmp       near ptr M00_L04
M00_L29:
       call      qword ptr [7FF86EDED020]
       int       3
M00_L30:
       mov       rcx,r8
       call      qword ptr [7FF86E6857E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M00_L08
M00_L31:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M00_L12
M00_L32:
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,r15
       call      qword ptr [7FF86EDE7D20]
       jmp       near ptr M00_L12
; Total bytes of code 1512
```
```assembly
; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
; 		exception = exception.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var collection = new List<Exception>();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		for (var currentException = exception; currentException is not null; currentException = currentException.InnerException)
; 		     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			collection.Add(currentException);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return collection.AsReadOnly();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L03
       mov       rcx,offset MT_System.Collections.Generic.List<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,25027000180
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L00:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edi,[rsi+10]
       cmp       [rcx+8],edi
       ja        short M01_L02
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF86E7FE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L01:
       mov       rbx,[rbx+20]
       test      rbx,rbx
       jne       short M01_L00
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       lea       edx,[rdi+1]
       mov       [rsi+10],edx
       mov       edx,edi
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M01_L01
M01_L03:
       call      qword ptr [7FF86EC8E298]
       mov       ecx,1D57
       mov       rdx,7FF86E9C4870
       call      qword ptr [7FF86E8A7738]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF86E9C4870
       call      qword ptr [7FF86E8A7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86E687858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FF86E9C4870
       call      qword ptr [7FF86E8A7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86E687858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF86EDECC90]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF86EDE7EE8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 304
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M02_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
M02_L00:
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       jne       short M02_L03
M02_L01:
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       ret
M02_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       jmp       short M02_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       r8,25011000038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M03_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M03_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M03_L03
       cmp       ebx,[r11]
       jne       short M03_L04
M03_L01:
       cmp       esi,1
       je        short M03_L02
       test      esi,esi
       jne       short M03_L05
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M03_L03:
       test      ebx,ebx
       je        short M03_L04
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M03_L00
M03_L04:
       mov       esi,2
       jmp       short M03_L01
M03_L05:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF86E68D908]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 166
```
```assembly
; DotNetTips.Spargine.Core.Logging.LoggingHelper+<>c.<RetrieveAllExceptionMessages>b__9_0(System.Exception)
; 		var messages = exceptions.Select(ex => ex.Message).ToList();
; 		                                       ^^^^^^^^^^
       mov       rcx,rdx
       mov       rax,offset MT_System.ArgumentNullException
       cmp       [rcx],rax
       jne       short M04_L00
       jmp       qword ptr [7FF86E6CD2A0]; System.ArgumentException.get_Message()
M04_L00:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       jmp       qword ptr [rax+20]
; Total bytes of code 35
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M05_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FF86EDE6EF8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,[rdi]
       mov       eax,ebx
       rol       eax,5
       add       eax,ecx
       mov       edx,esi
       ror       edx,5
       add       eax,edx
       mov       rdx,25011000A10
       mov       rdx,[rdx]
       mov       rdx,[rdx+8]
       movsxd    r8,eax
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       movzx     r10d,byte ptr [rdx+10]
       shrx      r8,r8,r10
       xor       r10d,r10d
M06_L00:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       eax,ebp
       jne       short M06_L01
       mov       rbp,rcx
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M06_L01
       mov       rbp,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M06_L02
       mov       rcx,7FF86EE219A8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L01:
       test      r11d,r11d
       je        short M06_L02
       inc       r10d
       add       r8d,r10d
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r8d,r9d
       cmp       r10d,8
       jl        near ptr M06_L00
M06_L02:
       mov       rcx,7FF86EE219AC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF86E7FFF48]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 274
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M07_L00
       ret
M07_L00:
       jmp       qword ptr [7FF86E685C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Array.Copy(System.Array, System.Array, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       jne       short M08_L01
       xor       ebp,ebp
       xor       r14d,r14d
M08_L00:
       test      rbx,rbx
       jne       near ptr M08_L09
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M08_L10
M08_L01:
       test      rbx,rbx
       jne       short M08_L04
       mov       rcx,7FF86EDF9B1C
       call      CORINFO_HELP_COUNTPROFILE32
M08_L02:
       mov       rcx,7FF86EDF9B24
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M08_L08
       xor       r14d,r14d
M08_L03:
       mov       rbp,rsi
       jmp       short M08_L00
M08_L04:
       mov       r15,[rsi]
       cmp       r15,[rbx]
       je        short M08_L05
       mov       rcx,7FF86EDF9B18
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L02
M08_L05:
       cmp       dword ptr [r15+4],18
       je        short M08_L06
       mov       rcx,7FF86EDF9B14
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L02
M08_L06:
       cmp       edi,[rsi+8]
       jbe       short M08_L07
       mov       rcx,7FF86EDF9B10
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L02
M08_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M08_L13
       mov       rcx,7FF86EDF9B0C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M08_L02
M08_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M08_L03
M08_L09:
       mov       rcx,7FF86EDF9B28
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M08_L12
       xor       r15d,r15d
M08_L10:
       mov       rcx,7FF86EDF9B2C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FF86EDE57D0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M08_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L12:
       movsxd    rcx,ecx
       mov       r15d,[rbx+rcx*4+10]
       jmp       short M08_L10
M08_L13:
       mov       edi,edi
       movzx     ebp,word ptr [r15]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [r15],1000000
       je        short M08_L15
       mov       rcx,7FF86EDF9B08
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M08_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF8CE25B8A0
       cmp       dword ptr [7FF8CE5BF778],0
       je        short M08_L11
       call      CORINFO_HELP_POLL_GC
       jmp       short M08_L11
M08_L14:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FF86EC8DC50]
M08_L15:
       mov       rcx,7FF86EDF9B20
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       jne       short M08_L16
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       near ptr M08_L11
M08_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF86E685818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L11
; Total bytes of code 488
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M09_L12
       lea       rdi,[rbx+rsi]
       cmp       rsi,10
       jbe       near ptr M09_L10
       cmp       rsi,40
       jbe       near ptr M09_L03
       cmp       rsi,400
       ja        near ptr M09_L08
       cmp       rsi,100
       jb        short M09_L00
       mov       rcx,7FF86EF7B2CC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       and       rcx,3F
       neg       rcx
       add       rcx,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbx],ymm0
       vmovdqu   ymmword ptr [rbx+20],ymm0
       add       rbx,rcx
       sub       rsi,rcx
M09_L00:
       mov       rbp,rsi
       shr       rbp,6
       jmp       short M09_L02
M09_L01:
       mov       rcx,7FF86EF7B2D8
       call      CORINFO_HELP_COUNTPROFILE32
M09_L02:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbx],ymm0
       vmovdqu   ymmword ptr [rbx+20],ymm0
       add       rbx,40
       dec       rbp
       jne       short M09_L01
       and       rsi,3F
       cmp       rsi,10
       jbe       short M09_L07
       mov       rcx,7FF86EF7B2D4
       call      CORINFO_HELP_COUNTPROFILE32
M09_L03:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx],xmm0
       cmp       rsi,20
       jbe       short M09_L04
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx+10],xmm0
       cmp       rsi,30
       ja        short M09_L09
       mov       rcx,7FF86EF7B2B4
       call      CORINFO_HELP_COUNTPROFILE32
M09_L04:
       mov       rcx,7FF86EF7B2B0
       call      CORINFO_HELP_COUNTPROFILE32
M09_L05:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rdi-10],xmm0
M09_L06:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M09_L07:
       mov       rcx,7FF86EF7B2D0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M09_L05
M09_L08:
       mov       rcx,7FF86EF7B2DC
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       [rbx],bl
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86EF4C018]
M09_L09:
       mov       rcx,7FF86EF7B2AC
       call      CORINFO_HELP_COUNTPROFILE32
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx+20],xmm0
       jmp       short M09_L04
M09_L10:
       test      sil,18
       je        short M09_L11
       mov       rcx,7FF86EF7B2B8
       call      CORINFO_HELP_COUNTPROFILE32
       xor       ecx,ecx
       mov       [rbx],rcx
       mov       [rdi-8],rcx
       jmp       short M09_L06
M09_L11:
       test      sil,4
       je        short M09_L13
       mov       rcx,7FF86EF7B2BC
       call      CORINFO_HELP_COUNTPROFILE32
       xor       ecx,ecx
       mov       [rbx],ecx
       mov       [rdi-4],ecx
       jmp       near ptr M09_L06
M09_L12:
       mov       rcx,7FF86EF7B2A8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L06
M09_L13:
       mov       byte ptr [rbx],0
       test      sil,2
       jne       short M09_L14
       mov       rcx,7FF86EF7B2C4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M09_L06
M09_L14:
       mov       rcx,7FF86EF7B2C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       word ptr [rdi-2],0
       jmp       near ptr M09_L06
; Total bytes of code 485
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,1CBCB9F08F8
       mov       [rsi+10],rcx
       mov       dword ptr [rsi+6C],80070216
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,80131500E0434352
       mov       [rdi+68],rcx
       mov       rcx,1CBCB9F0920
       mov       [rdi+10],rcx
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+6C],80004003
       mov       rcx,offset MT_System.Collections.Generic.List<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,18B36C02150
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
       call      qword ptr [7FF86E7FE370]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rax,[rdx+80]
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
       mov       rdx,7FF86EDCA988
       call      qword ptr [7FF86E68C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L01
M01_L06:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF86EC859B0]
       int       3
M01_L07:
       mov       rcx,r14
       mov       r8d,edi
       mov       rdx,r15
       call      qword ptr [7FF86E7F4FD8]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M01_L02
M01_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+88]
       test      rdx,rdx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FF86EE09318
       call      qword ptr [7FF86E68C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M01_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
; Total bytes of code 321
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
       jmp       qword ptr [7FF86E68D8F0]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M02_L00:
       call      qword ptr [7FF86EDE4C48]
       int       3
M02_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF8CE2A9DD0
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
```

