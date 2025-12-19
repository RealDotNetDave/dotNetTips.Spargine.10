## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.AppInfo()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,179234020A8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L01
       mov       rsi,[rcx+18]
M00_L00:
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FFC6CCB4A38]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L00
; Total bytes of code 87
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M01_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M01_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M01_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFCB80AD220]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M01_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M01_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M01_L03:
       cmp       ecx,8
       ja        short M01_L04
       mov       ecx,ecx
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M01_L00]
       add       rdx,r8
       jmp       rdx
M01_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCB80A3CF0]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFCB80AD210]
       jmp       short M01_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCB80AD218]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M01_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFCB808A810]
       mov       rcx,rax
       call      qword ptr [7FFCB8091F40]
       mov       rcx,rax
       call      qword ptr [7FFCB80B3100]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFCB80AD228]
       jmp       near ptr M01_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M01_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFCB80AD228]
       jmp       near ptr M01_L01
M01_L05:
       mov       rcx,rbx
       call      qword ptr [7FFCB80AD238]
       jmp       near ptr M01_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFCB80AD220]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M01_L01
; Total bytes of code 269
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.CurrentCulture()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       short M00_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M00_L02
M00_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L01
       mov       rax,29F37400110
       mov       rax,[rax]
       test      rax,rax
       jne       short M00_L01
       mov       rax,29F374000F0
       mov       rax,[rax]
       test      rax,rax
       je        short M00_L03
M00_L01:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
M00_L02:
       mov       ecx,2
       call      qword ptr [7FFC6CF5F6F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFC6CAE5DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       short M00_L01
; Total bytes of code 154
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFCB80A0D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M01_L01
       cmp       [rax],ecx
       jle       short M01_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M01_L03
M01_L00:
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M01_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M01_L00
M01_L02:
       cmp       [rax+4],edx
       jle       short M01_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M01_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M01_L03
       jmp       short M01_L00
M01_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
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
       call      qword ptr [7FFCB80887D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFCB809FA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFCB80A0C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFCB809E468]
       int       3
; Total bytes of code 61
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.CurrentThreadId()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,151E94020B0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L01
       mov       rsi,[rcx+18]
M00_L00:
       mov       eax,[rsi+88]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FFC6CACFBE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L00
; Total bytes of code 64
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M01_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M01_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M01_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFCB80AD220]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M01_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M01_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M01_L03:
       cmp       ecx,8
       ja        short M01_L04
       mov       ecx,ecx
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M01_L00]
       add       rdx,r8
       jmp       rdx
M01_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCB80A3CF0]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFCB80AD210]
       jmp       short M01_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCB80AD218]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M01_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFCB808A810]
       mov       rcx,rax
       call      qword ptr [7FFCB8091F40]
       mov       rcx,rax
       call      qword ptr [7FFCB80B3100]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFCB80AD228]
       jmp       near ptr M01_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M01_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFCB80AD228]
       jmp       near ptr M01_L01
M01_L05:
       mov       rcx,rbx
       call      qword ptr [7FFCB80AD238]
       jmp       near ptr M01_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFCB80AD220]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M01_L01
; Total bytes of code 269
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.CurrentUICulture()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       short M00_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M00_L02
M00_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M00_L01
       mov       rax,1A4FC000108
       mov       rax,[rax]
       test      rax,rax
       jne       short M00_L01
       mov       rax,1A4FC0000F8
       mov       rax,[rax]
       test      rax,rax
       jne       short M00_L01
       call      qword ptr [7FFC6CAC40F0]; System.Globalization.CultureInfo.InitializeUserDefaultUICulture()
M00_L01:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
M00_L02:
       mov       ecx,2
       call      qword ptr [7FFC6D0160D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M00_L00
; Total bytes of code 152
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultUICulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFCB80887D0]
       mov       rbx,rax
       lea       rsi,[rbx+8]
       call      qword ptr [7FFCB809FA90]
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFCB80A0C28]
       mov       rax,[rbx+8]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFCB809E468]
       int       3
; Total bytes of code 63
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFCB80A0D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.ExecutingFolder()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,204C78020A0
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,7FFC6CF53168
       mov       r9,7FFC6C7AD0B0
       call      qword ptr [7FFC6C866EB0]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,204C78020A0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
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
       call      qword ptr [7FFCB8087FD0]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.GetCultureNames()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,19E39C020A8
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_<>f__AnonymousDelegate0<System.Globalization.CultureTypes, System.Collections.ObjectModel.ReadOnlyCollection<System.String>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,7FFC6CF230A8
       mov       r9,7FFC6C77D1A0
       call      qword ptr [7FFC6C836EB0]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,19E39C020A8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
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
       call      qword ptr [7FFCB8087FD0]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.GetEnvironmentVariables()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,27F0A0000E0
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func<System.Collections.Generic.IReadOnlyDictionary<System.String, System.String>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,7FFC6CF5AC58
       mov       r9,7FFC6C77D0B0
       call      qword ptr [7FFC6C836EB0]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,27F0A0000E0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
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
       call      qword ptr [7FFCB8087FD0]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.GetProcessorInformation()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,293A08000E8
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Core.ProcessorInformation>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,7FFC6CF7AD30
       mov       r9,7FFC6C79D1A0
       call      qword ptr [7FFC6C856EB0]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,293A08000E8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
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
       call      qword ptr [7FFCB8087FD0]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.InstalledUICulture()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rax,225F90000F0
       mov       rax,[rax]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       call      qword ptr [7FFC6CAD5DA0]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       short M00_L00
; Total bytes of code 76
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFCB80887D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFCB809FA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFCB80A0C28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFCB809E468]
       int       3
; Total bytes of code 61
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.IsRunning()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,223178020E8
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func<System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,7FFC6CF6AD78
       mov       r9,7FFC6C78D0B0
       call      qword ptr [7FFC6C846EB0]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,223178020E8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
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
       call      qword ptr [7FFCB8087FD0]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.IsRunningFromAspNet()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,1957F8000F8
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func<System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,7FFC6CF8AC40
       mov       r9,7FFC6C7AD0B0
       call      qword ptr [7FFC6C866EB0]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,1957F8000F8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
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
       call      qword ptr [7FFCB8087FD0]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.IsUserAdministrator()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,18DFF4020F8
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func<System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,7FFC6CF7AE08
       mov       r9,7FFC6C79D0B0
       call      qword ptr [7FFC6C856EB0]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,18DFF4020F8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
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
       call      qword ptr [7FFCB8087FD0]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.MaxDegreeOfParallelism()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,2ACD0C020D8
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,7FFC6CF23168
       mov       r9,7FFC6C77D0B0
       call      qword ptr [7FFC6C836EB0]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,2ACD0C020D8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
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
       call      qword ptr [7FFCB8087FD0]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.OSArchitecture()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       call      qword ptr [7FFC6CF270C0]; System.Runtime.InteropServices.RuntimeInformation.get_OSArchitecture()
       mov       [rsp+28],eax
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FFC6CF27138]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Runtime.InteropServices.Architecture, System.Private.CoreLib]](System.Runtime.InteropServices.Architecture ByRef)
       nop
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 42
```
```assembly
; System.Runtime.InteropServices.RuntimeInformation.get_OSArchitecture()
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+70]
       mov       eax,[7FFC6C77B170]
       dec       eax
       js        short M01_L01
M01_L00:
       add       rsp,68
       pop       rbx
       pop       rbp
       ret
M01_L01:
       mov       rcx,23A8632CE48
       xor       edx,edx
       mov       r8d,800
       call      qword ptr [7FFC6CE25FE0]; Interop+Kernel32.LoadLibraryEx(System.String, IntPtr, Int32)
       mov       rcx,rax
       lea       r8,[rbp-10]
       mov       rdx,23A863306A0
       call      qword ptr [7FFC6CF2F810]
       test      eax,eax
       je        short M01_L03
       mov       rbx,[rbp-10]
       call      00007FFC6C828C30
       mov       rcx,rax
       lea       r8,[rbp-20]
       lea       rdx,[rbp-18]
       mov       r10,rbx
       mov       r11,23A85E18960
       call      CORINFO_HELP_PINVOKE_CALLI
       test      eax,eax
       je        short M01_L02
       movzx     ecx,word ptr [rbp-20]
       call      qword ptr [7FFC6CF270D8]; System.Runtime.InteropServices.RuntimeInformation.MapMachineConstant(UInt16)
       jmp       short M01_L04
M01_L02:
       mov       eax,1
       jmp       short M01_L04
M01_L03:
       lea       rcx,[rbp-50]
       call      00007FFC6C828C18
       movzx     ecx,word ptr [rbp-50]
       call      qword ptr [7FFC6CF2F5D0]
M01_L04:
       lea       ecx,[rax+1]
       mov       [7FFC6C77B170],ecx
       jmp       near ptr M01_L00
; Total bytes of code 176
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Runtime.InteropServices.Architecture, System.Private.CoreLib]](System.Runtime.InteropServices.Architecture ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.OSDescription()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFC6CF8EC58]; System.Runtime.InteropServices.RuntimeInformation.get_OSDescription()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 56
```
```assembly
; System.Runtime.InteropServices.RuntimeInformation.get_OSDescription()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,0A0
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       mov       rax,0BF718267C67A
       mov       [rbp+8],rax
       mov       rax,1C6294020F0
       mov       rbx,[rax]
       test      rbx,rbx
       je        short M01_L02
M01_L00:
       mov       rax,rbx
       mov       r8,0BF718267C67A
       cmp       [rbp+8],r8
       je        short M01_L01
       call      CORINFO_HELP_FAIL_FAST
M01_L01:
       nop
       lea       rsp,[rbp+70]
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M01_L02:
       call      qword ptr [7FFC6CF8EC70]; System.Environment.get_OSVersion()
       mov       rbx,rax
       mov       rsi,[rbx+8]
       test      [rsp],esp
       sub       rsp,200
       lea       rax,[rsp+30]
       mov       rcx,[rbx+10]
       mov       rdx,206BE3A0008
       test      rcx,rcx
       cmove     rcx,rdx
       cmp       dword ptr [rcx+8],0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L11
       mov       [rbp+10],rax
       mov       dword ptr [rbp+18],100
       lea       rcx,[rbp+10]
       mov       [rsp+20],rcx
       lea       rcx,[rbp+48]
       mov       edx,4
       mov       r8d,5
       xor       r9d,r9d
       call      qword ptr [7FFC6CAEEEC8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32, System.IFormatProvider, System.Span`1<Char>)
       lea       rcx,[rbp+48]
       mov       rdx,206BE3B06A0
       call      qword ptr [7FFC6CAEE028]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp+58]
       cmp       ecx,[rbp+68]
       ja        near ptr M01_L16
       mov       rdx,[rbp+60]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+68]
       sub       eax,ecx
       je        short M01_L03
       mov       word ptr [rdx],20
       mov       ecx,[rbp+58]
       inc       ecx
       mov       [rbp+58],ecx
       jmp       short M01_L04
M01_L03:
       lea       rcx,[rbp+48]
       mov       rdx,206BE3A7A38
       call      qword ptr [7FFC6CF8C648]
M01_L04:
       mov       edx,[rsi+8]
       lea       rcx,[rbp+48]
       call      qword ptr [7FFC6CF8ECB8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.UInt32, System.Private.CoreLib]](UInt32)
       mov       ecx,[rbp+58]
       cmp       ecx,[rbp+68]
       ja        near ptr M01_L16
       mov       rdx,[rbp+60]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+68]
       sub       eax,ecx
       je        short M01_L05
       mov       word ptr [rdx],2E
       mov       ecx,[rbp+58]
       inc       ecx
       mov       [rbp+58],ecx
       jmp       short M01_L06
M01_L05:
       lea       rcx,[rbp+48]
       mov       rdx,206BE3A0658
       call      qword ptr [7FFC6CF8C648]
M01_L06:
       mov       edx,[rsi+0C]
       lea       rcx,[rbp+48]
       call      qword ptr [7FFC6CF8ECB8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.UInt32, System.Private.CoreLib]](UInt32)
       mov       ecx,[rbp+58]
       cmp       ecx,[rbp+68]
       ja        near ptr M01_L16
       mov       rdx,[rbp+60]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+68]
       sub       eax,ecx
       je        short M01_L07
       mov       word ptr [rdx],2E
       mov       ecx,[rbp+58]
       inc       ecx
       mov       [rbp+58],ecx
       jmp       short M01_L08
M01_L07:
       lea       rcx,[rbp+48]
       mov       rdx,206BE3A0658
       call      qword ptr [7FFC6CF8C648]
M01_L08:
       mov       edx,[rsi+10]
       lea       rcx,[rbp+48]
       call      qword ptr [7FFC6CF8ECB8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.UInt32, System.Private.CoreLib]](UInt32)
       mov       ecx,[rbp+58]
       cmp       ecx,[rbp+68]
       ja        near ptr M01_L16
       mov       rdx,[rbp+60]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+68]
       sub       eax,ecx
       je        short M01_L09
       mov       word ptr [rdx],20
       mov       ecx,[rbp+58]
       inc       ecx
       mov       [rbp+58],ecx
       jmp       short M01_L10
M01_L09:
       lea       rcx,[rbp+48]
       mov       rdx,206BE3A7A38
       call      qword ptr [7FFC6CF8C648]
M01_L10:
       mov       rdx,[rbx+10]
       mov       rcx,206BE3A0008
       test      rdx,rdx
       cmove     rdx,rcx
       lea       rcx,[rbp+48]
       call      qword ptr [7FFC6CAEE028]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp+48]
       call      qword ptr [7FFC6CAE4E40]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbx,rax
       jmp       near ptr M01_L20
M01_L11:
       mov       [rbp+10],rax
       mov       dword ptr [rbp+18],100
       lea       rcx,[rbp+10]
       mov       [rsp+20],rcx
       lea       rcx,[rbp+20]
       mov       edx,3
       mov       r8d,4
       xor       r9d,r9d
       call      qword ptr [7FFC6CAEEEC8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32, System.IFormatProvider, System.Span`1<Char>)
       lea       rcx,[rbp+20]
       mov       rdx,206BE3B06A0
       call      qword ptr [7FFC6CAEE028]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp+30]
       cmp       ecx,[rbp+40]
       ja        near ptr M01_L16
       mov       rdx,[rbp+38]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+40]
       sub       eax,ecx
       je        short M01_L12
       mov       word ptr [rdx],20
       mov       ecx,[rbp+30]
       inc       ecx
       mov       [rbp+30],ecx
       jmp       short M01_L13
M01_L12:
       lea       rcx,[rbp+20]
       mov       rdx,206BE3A7A38
       call      qword ptr [7FFC6CF8C648]
M01_L13:
       mov       edx,[rsi+8]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFC6CF8ECB8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.UInt32, System.Private.CoreLib]](UInt32)
       mov       ecx,[rbp+30]
       cmp       ecx,[rbp+40]
       ja        short M01_L16
       mov       rdx,[rbp+38]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+40]
       sub       eax,ecx
       je        short M01_L14
       mov       word ptr [rdx],2E
       mov       ecx,[rbp+30]
       inc       ecx
       mov       [rbp+30],ecx
       jmp       short M01_L15
M01_L14:
       lea       rcx,[rbp+20]
       mov       rdx,206BE3A0658
       call      qword ptr [7FFC6CF8C648]
M01_L15:
       mov       edx,[rsi+0C]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFC6CF8ECB8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.UInt32, System.Private.CoreLib]](UInt32)
       mov       ecx,[rbp+30]
       cmp       ecx,[rbp+40]
       jbe       short M01_L17
M01_L16:
       call      qword ptr [7FFC6CA07138]
       int       3
M01_L17:
       mov       rdx,[rbp+38]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp+40]
       sub       eax,ecx
       je        short M01_L18
       mov       word ptr [rdx],2E
       mov       ecx,[rbp+30]
       inc       ecx
       mov       [rbp+30],ecx
       jmp       short M01_L19
M01_L18:
       lea       rcx,[rbp+20]
       mov       rdx,206BE3A0658
       call      qword ptr [7FFC6CF8C648]
M01_L19:
       mov       edx,[rsi+10]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFC6CF8ECB8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.UInt32, System.Private.CoreLib]](UInt32)
       lea       rcx,[rbp+20]
       call      qword ptr [7FFC6CAE4E40]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbx,rax
M01_L20:
       mov       rcx,1C6294020F0
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
; Total bytes of code 904
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.ProcessArchitecture()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       mov       rcx,[rcx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FFC6CF670F0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Runtime.InteropServices.Architecture, System.Private.CoreLib]](System.Runtime.InteropServices.Architecture ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Runtime.InteropServices.Architecture, System.Private.CoreLib]](System.Runtime.InteropServices.Architecture ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.ProcessId()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[7FFC6C77B0BC]
       test      esi,esi
       je        short M00_L01
M00_L00:
       mov       rax,[rbx+18]
       mov       [rax+38],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FFC6CF5EC28]; System.Environment.GetProcessId()
       mov       esi,eax
       mov       [7FFC6C77B0BC],esi
       jmp       short M00_L00
; Total bytes of code 49
```
```assembly
; System.Environment.GetProcessId()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [rax]
       mov       ebx,eax
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       eax,ebx
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
; Total bytes of code 80
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.ProcessName()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       esi,[7FFC6C77B0BC]
       test      esi,esi
       jne       short M00_L00
       call      qword ptr [7FFC6CF4EA00]; System.Environment.GetProcessId()
       mov       esi,eax
       mov       [7FFC6C77B0BC],esi
M00_L00:
       mov       rcx,offset MT_System.Diagnostics.Process
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,[rdi]
       test      dword ptr [rcx],100000
       je        short M00_L01
       mov       rcx,rdi
       call      00007FFCCC448C20
M00_L01:
       xor       eax,eax
       mov       [rdi+28],rax
       mov       rax,1FEFF9E0658
       mov       [rdi+20],rax
       mov       byte ptr [rdi+0E6],0
       mov       [rdi+0D0],esi
       mov       byte ptr [rdi+0E4],1
       xor       eax,eax
       mov       [rdi+0DC],eax
       mov       [rdi+0E0],eax
       cmp       qword ptr [rdi+0A0],0
       jne       near ptr M00_L17
       mov       esi,[rdi+0D0]
       mov       rbp,[rdi+20]
       test      rbp,rbp
       je        near ptr M00_L19
       mov       r14d,[rbp+8]
       test      r14d,r14d
       je        near ptr M00_L19
       mov       eax,2
       xor       ecx,ecx
       cmp       word ptr [rbp+0C],5C
       cmovne    eax,ecx
       cmp       r14d,eax
       jb        near ptr M00_L18
       mov       ecx,eax
       lea       r15,[rbp+rcx*2+0C]
       sub       r14d,eax
       mov       rax,1FEFF9E0658
       cmp       r15,rax
       je        short M00_L10
       cmp       r14d,1
       jne       short M00_L02
       cmp       word ptr [r15],2E
       je        short M00_L10
M00_L02:
       call      qword ptr [7FFC6CFE7330]
       test      rax,rax
       jne       short M00_L07
       xor       edx,edx
       xor       r8d,r8d
M00_L03:
       cmp       r14d,r8d
       je        short M00_L08
M00_L04:
       mov       rcx,rbp
       mov       edx,1
       call      qword ptr [7FFC6CFE7300]
       xor       ecx,ecx
       cmp       [rax+8],ecx
       jle       short M00_L06
M00_L05:
       mov       rdx,[rax+rcx*8+10]
       cmp       [rdx+64],esi
       je        short M00_L12
       inc       ecx
       cmp       [rax+8],ecx
       jg        short M00_L05
M00_L06:
       xor       edx,edx
       jmp       near ptr M00_L16
M00_L07:
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       jmp       short M00_L03
M00_L08:
       test      r8d,r8d
       je        short M00_L10
       cmp       r8d,8
       jl        near ptr M00_L20
       cmp       r8d,10
       jl        near ptr M00_L22
       jmp       near ptr M00_L21
M00_L09:
       test      eax,eax
       je        short M00_L04
M00_L10:
       mov       ecx,esi
       call      qword ptr [7FFC6CF4EC58]; Interop+Kernel32.GetProcessName(UInt32)
       mov       rbp,rax
       test      rbp,rbp
       je        short M00_L06
       lea       rsi,[rbp+0C]
       mov       r14d,[rbp+8]
       mov       rcx,rsi
       mov       r8d,r14d
       mov       edx,5C
       call      qword ptr [7FFC6C9D43D8]; System.SpanHelpers.LastIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       inc       eax
       cmp       eax,r14d
       jbe       short M00_L13
M00_L11:
       call      qword ptr [7FFC6C9D7138]
       int       3
M00_L12:
       mov       rdx,[rdx+10]
       jmp       near ptr M00_L16
M00_L13:
       mov       r8d,eax
       lea       rsi,[rsi+r8*2]
       sub       r14d,eax
       mov       r15d,r14d
       cmp       r15d,4
       jl        short M00_L14
       mov       r8d,r15d
       lea       r8,[rsi+r8*2-8]
       mov       rcx,20002000200000
       or        rcx,[r8]
       mov       r8,6500780065002E
       cmp       rcx,r8
       sete      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        short M00_L14
       lea       r15d,[r14-4]
       cmp       r15d,r14d
       ja        short M00_L11
M00_L14:
       lea       rdx,[rbp+0C]
       mov       r8d,[rbp+8]
       cmp       r15d,r8d
       jne       short M00_L15
       mov       r8d,r8d
       add       r8,r8
       mov       rcx,rsi
       call      qword ptr [7FFC6C83FB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M00_L23
M00_L15:
       mov       [rsp+20],rsi
       mov       [rsp+28],r15d
       lea       rcx,[rsp+20]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdx,rax
M00_L16:
       lea       rcx,[rdi+0A0]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rdi+0A0],0
       je        near ptr M00_L24
M00_L17:
       mov       rcx,[rdi+0A0]
       mov       [rsp+30],rcx
       mov       rcx,[rbx+18]
       lea       r8,[rsp+30]
       mov       rdx,7FFC6CFCB920
       cmp       [rcx],ecx
       call      qword ptr [7FFC6CF4EDA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L18:
       mov       ecx,21
       call      qword ptr [7FFC6CAB7870]
       int       3
M00_L19:
       mov       ecx,0D2E
       mov       rdx,7FFC6CFC63D8
       call      qword ptr [7FFC6CAB7738]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFC6CFE7318]
       int       3
M00_L20:
       mov       rcx,r15
       call      qword ptr [7FFC6CFE65F8]
       jmp       near ptr M00_L09
M00_L21:
       mov       rcx,r15
       call      qword ptr [7FFC6CFE65B0]
       jmp       near ptr M00_L09
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFC6CFE65C8]
       jmp       near ptr M00_L09
M00_L23:
       mov       rdx,rbp
       jmp       near ptr M00_L16
M00_L24:
       mov       rcx,rdi
       mov       edx,8
       call      qword ptr [7FFC6CF4EA48]; System.Diagnostics.Process.EnsureState(State)
       mov       rcx,[rdi+28]
       mov       rdx,[rcx+10]
       lea       rcx,[rdi+0A0]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L17
; Total bytes of code 777
```
```assembly
; System.Environment.GetProcessId()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [rax]
       mov       ebx,eax
       lea       rcx,[rbp-90]
       call      qword ptr [7FFCB8088020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       eax,ebx
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
; Total bytes of code 80
```
```assembly
; Interop+Kernel32.GetProcessName(UInt32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+18],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+20],ymm4
       vmovdqu   ymmword ptr [rbp+40],ymm4
       vmovdqu   ymmword ptr [rbp+60],ymm4
       vmovdqu   ymmword ptr [rbp+80],ymm4
       vmovdqu   ymmword ptr [rbp+0A0],ymm4
       vmovdqa   xmmword ptr [rbp+0C0],xmm4
       mov       rax,92D49215479E
       mov       [rbp],rax
       mov       ebx,ecx
       lea       rcx,[rbp+68]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp+0A0],rax
       mov       rcx,rsp
       mov       [rbp+80],rcx
       mov       rcx,rbp
       mov       [rbp+90],rcx
       xor       ecx,ecx
       mov       [rbp+0C4],ecx
       mov       [rbp+28],rcx
       mov       byte ptr [rbp+60],0
       mov       rcx,1FEFF9F0730
       mov       rax,offset MT_Microsoft.Win32.SafeHandles.SafeProcessHandle
       mov       eax,[rax]
       and       eax,0C0000
       cmp       eax,40000
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L20
       call      qword ptr [7FFC6C837BE8]; System.RuntimeType.CreateInstanceOfT()
       mov       rsi,rax
M02_L00:
       xor       ecx,ecx
       mov       [rbp+0B8],rcx
       mov       [rbp+20],rsi
       mov       [rbp+10],rsi
       xor       ecx,ecx
       mov       rdx,7FFCFA4C5FF0
       call      rdx
       mov       r8d,ebx
       mov       ecx,1000
       xor       edx,edx
       mov       rax,7FFC6CFC9DD8
       mov       [rbp+78],rax
       lea       rax,[M02_L01]
       mov       [rbp+88],rax
       mov       rax,[rbp+0A0]
       lea       r10,[rbp+68]
       mov       [rax+8],r10
       mov       rax,[rbp+0A0]
       mov       byte ptr [rax+4],0
       mov       rax,7FFCFA4CB120
       call      rax
M02_L01:
       mov       rcx,[rbp+0A0]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFCCC79F778],0
       je        short M02_L02
       call      qword ptr [7FFCCC78D608]; CORINFO_HELP_STOP_FOR_GC
M02_L02:
       mov       rcx,[rbp+0A0]
       mov       rdx,[rbp+70]
       mov       [rcx+8],rdx
       mov       rbx,rax
       mov       rax,7FFCFA4C5F30
       call      rax
       mov       [rbp+0C0],eax
       mov       dword ptr [rbp+0C4],1
       mov       byte ptr [rbp+60],1
       mov       rsi,[rbp+20]
       mov       [rsi+8],rbx
       mov       [rbp+28],rsi
       call      M02_L52
       nop
       mov       ecx,[rbp+0C0]
       call      00007FFCCC486280
       mov       rbx,[rbp+28]
       mov       [rbp+40],rbx
       mov       rax,[rbp+28]
       mov       rax,[rax+8]
       test      rax,rax
       je        near ptr M02_L17
       cmp       rax,0FFFFFFFFFFFFFFFF
       je        near ptr M02_L17
       test      [rsp],esp
       sub       rsp,210
       lea       rax,[rsp+20]
       mov       [rbp+18],rax
       mov       dword ptr [rbp+64],105
       xor       eax,eax
       mov       [rbp+38],rax
M02_L03:
       mov       eax,[rbp+64]
       mov       [rbp+0D0],eax
       mov       rax,[rbp+18]
       mov       [rbp+0C8],rax
       mov       rbx,[rbp+18]
       xor       eax,eax
       mov       [rbp+0B4],eax
       mov       [rbp+8],rax
       mov       byte ptr [rbp+5C],0
       mov       rsi,[rbp+40]
       mov       [rbp+8],rsi
       mov       eax,[rsi+10]
       test      al,1
       jne       near ptr M02_L08
M02_L04:
       lea       rcx,[rsi+10]
       lea       edx,[rax+4]
       mov       [rbp+0AC],eax
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp+0AC]
       jne       near ptr M02_L07
       mov       byte ptr [rbp+5C],1
       mov       rcx,[rbp+8]
       mov       rdi,[rcx+8]
       xor       ecx,ecx
       mov       rax,7FFCFA4C5FF0
       call      rax
       lea       r9,[rbp+0D0]
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       mov       rax,7FFC6CFCA398
       mov       [rbp+78],rax
       lea       rax,[M02_L05]
       mov       [rbp+88],rax
       mov       rax,[rbp+0A0]
       lea       r10,[rbp+68]
       mov       [rax+8],r10
       mov       rax,[rbp+0A0]
       mov       byte ptr [rax+4],0
       mov       rax,7FFCFA4CCBB0
       call      rax
M02_L05:
       mov       rcx,[rbp+0A0]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFCCC79F778],0
       je        short M02_L06
       call      qword ptr [7FFCCC78D608]; CORINFO_HELP_STOP_FOR_GC
M02_L06:
       mov       rcx,[rbp+0A0]
       mov       rdx,[rbp+70]
       mov       [rcx+8],rdx
       mov       ebx,eax
       mov       rax,7FFCFA4C5F30
       call      rax
       mov       [rbp+0B0],eax
       test      ebx,ebx
       setne     cl
       movzx     ecx,cl
       mov       [rbp+0B4],ecx
       jmp       short M02_L09
M02_L07:
       mov       eax,[rsi+10]
       test      al,1
       mov       rsi,[rbp+40]
       je        near ptr M02_L04
M02_L08:
       mov       rcx,rsi
       call      qword ptr [7FFC6CFE6AD8]
       int       3
M02_L09:
       call      M02_L23
       nop
       mov       ecx,[rbp+0B0]
       call      00007FFCCC486280
       cmp       byte ptr [rbp+0B4],0
       je        short M02_L11
       mov       ecx,[rbp+0D0]
       cmp       ecx,[rbp+64]
       ja        short M02_L10
       mov       rax,[rbp+18]
       mov       [rbp+48],rax
       mov       [rbp+50],ecx
       lea       rcx,[rbp+48]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       [rbp+30],rax
       jmp       short M02_L12
M02_L10:
       call      qword ptr [7FFC6C9D7138]
       int       3
M02_L11:
       call      00007FFCCC486260
       cmp       eax,7A
       je        short M02_L13
       xor       ecx,ecx
       mov       [rbp+30],rcx
M02_L12:
       xor       ecx,ecx
       mov       [rbp+0C8],rcx
       jmp       short M02_L16
M02_L13:
       call      M02_L37
       nop
       mov       rbx,[rbp+38]
       mov       rcx,1BE6AC00C88
       mov       rcx,[rcx]
       mov       edx,[rbp+64]
       add       edx,edx
       call      qword ptr [7FFC6CBD10F0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+38],rax
       test      rax,rax
       jne       short M02_L14
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M02_L15
M02_L14:
       lea       rcx,[rax+10]
       mov       edx,[rax+8]
M02_L15:
       mov       [rbp+18],rcx
       mov       [rbp+64],edx
       test      rbx,rbx
       je        near ptr M02_L03
       mov       rcx,1BE6AC00C88
       mov       rcx,[rcx]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFC6CBD10F8]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       jmp       near ptr M02_L03
M02_L16:
       cmp       qword ptr [rbp+38],0
       je        short M02_L19
       jmp       short M02_L18
M02_L17:
       xor       eax,eax
       mov       [rbp+30],rax
       jmp       short M02_L19
M02_L18:
       mov       rcx,1BE6AC00C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFC6CBD10F8]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       nop
M02_L19:
       call      M02_L39
       jmp       short M02_L21
M02_L20:
       xor       edx,edx
       mov       [rbp+0B8],rdx
       lea       rdx,[rbp+0B8]
       call      qword ptr [7FFC6CFE6BE0]
       mov       rsi,[rbp+0B8]
       jmp       near ptr M02_L00
M02_L21:
       mov       rax,[rbp+30]
       mov       r8,92D49215479E
       cmp       [rbp],r8
       je        short M02_L22
       call      CORINFO_HELP_FAIL_FAST
M02_L22:
       nop
       lea       rsp,[rbp+0D8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L23:
       sub       rsp,28
       vzeroupper
       cmp       byte ptr [rbp+5C],0
       je        near ptr M02_L36
       mov       rbx,[rbp+8]
       mov       rcx,[rbp+8]
       cmp       [rcx],cl
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       je        short M02_L32
M02_L24:
       mov       ecx,esi
       and       ecx,0FFFFFFFD
       cmp       ecx,4
       jne       short M02_L29
       jmp       short M02_L26
M02_L25:
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       jne       short M02_L24
       jmp       short M02_L32
M02_L26:
       cmp       byte ptr [rbx+14],0
       je        short M02_L29
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeProcessHandle
       cmp       [rbx],rcx
       jne       short M02_L27
       mov       rcx,rbx
       call      qword ptr [7FFC6C95E610]; Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       jmp       short M02_L28
M02_L27:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
M02_L28:
       test      eax,eax
       sete      cl
       movzx     ecx,cl
       jmp       short M02_L30
M02_L29:
       xor       ecx,ecx
M02_L30:
       lea       edx,[rsi-4]
       mov       eax,esi
       and       eax,0FFFFFFFC
       cmp       eax,4
       jne       short M02_L31
       or        edx,1
M02_L31:
       lea       r8,[rbx+10]
       mov       eax,esi
       lock cmpxchg [r8],edx
       cmp       eax,esi
       jne       short M02_L25
       jmp       short M02_L33
M02_L32:
       mov       rcx,rbx
       call      qword ptr [7FFC6CFE6AD8]
       int       3
M02_L33:
       test      ecx,ecx
       je        short M02_L36
       call      00007FFCCC486260
       mov       esi,eax
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeProcessHandle
       cmp       [rbx],rcx
       jne       short M02_L34
       mov       rcx,[rbx+8]
       call      qword ptr [7FFC6CF4EBE0]; Interop+Kernel32.CloseHandle(IntPtr)
       jmp       short M02_L35
M02_L34:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M02_L35:
       mov       ecx,esi
       call      00007FFCCC486280
M02_L36:
       nop
       add       rsp,28
       ret
M02_L37:
       sub       rsp,28
       vzeroupper
       xor       ecx,ecx
       mov       [rbp+0C8],rcx
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp+38],0
       je        short M02_L38
       mov       rcx,1BE6AC00C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFC6CBD10F8]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L38:
       nop
       add       rsp,28
       ret
M02_L39:
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp+40],0
       je        near ptr M02_L51
       mov       rsi,[rbp+40]
       mov       eax,[rsi+10]
       test      al,2
       jne       near ptr M02_L50
M02_L40:
       mov       ecx,eax
       and       ecx,0FFFFFFFC
       jne       short M02_L42
       jmp       short M02_L48
M02_L41:
       mov       eax,[rsi+10]
       test      al,2
       jne       near ptr M02_L50
       jmp       short M02_L40
M02_L42:
       mov       edx,eax
       and       edx,0FFFFFFFD
       cmp       edx,4
       jne       short M02_L45
       cmp       byte ptr [rsi+14],0
       je        short M02_L45
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        short M02_L43
       cmp       rdx,0FFFFFFFFFFFFFFFF
       sete      dl
       movzx     edx,dl
       jmp       short M02_L44
M02_L43:
       mov       edx,1
M02_L44:
       test      edx,edx
       sete      dl
       movzx     edx,dl
       jmp       short M02_L46
M02_L45:
       xor       edx,edx
M02_L46:
       lea       r8d,[rax-4]
       cmp       ecx,4
       jne       short M02_L47
       or        r8d,1
M02_L47:
       lea       rcx,[rsi+10]
       or        r8d,2
       mov       [rbp+0A8],eax
       lock cmpxchg [rcx],r8d
       cmp       eax,[rbp+0A8]
       jne       short M02_L41
       jmp       short M02_L49
M02_L48:
       mov       rcx,rsi
       call      qword ptr [7FFC6CFE6AD8]
       int       3
M02_L49:
       test      edx,edx
       je        short M02_L50
       call      00007FFCCC486260
       mov       ebx,eax
       mov       rdi,[rsi+8]
       xor       ecx,ecx
       call      00007FFC6C829098
       mov       rcx,rdi
       call      00007FFC6C8290B0
       call      00007FFC6C8290C8
       mov       ecx,eax
       call      00007FFCCC486280
       mov       ecx,ebx
       call      00007FFCCC486280
M02_L50:
       mov       rcx,[rsi]
       test      dword ptr [rcx],100000
       je        short M02_L51
       mov       rcx,rsi
       call      00007FFCCC448C20
M02_L51:
       nop
       add       rsp,28
       ret
M02_L52:
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp+0C4],0
       je        near ptr M02_L64
       cmp       byte ptr [rbp+60],0
       jne       near ptr M02_L64
       mov       rbx,[rbp+10]
       mov       rsi,[rbx]
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeProcessHandle
       cmp       rsi,rcx
       jne       near ptr M02_L62
       mov       rdi,rbx
       mov       r14d,[rbx+10]
       test      r14b,2
       jne       near ptr M02_L61
M02_L53:
       mov       r15d,r14d
       and       r15d,0FFFFFFFC
       jne       short M02_L55
       jmp       short M02_L59
M02_L54:
       mov       r14d,[rbx+10]
       test      r14b,2
       jne       short M02_L61
       jmp       short M02_L53
M02_L55:
       mov       ecx,r14d
       and       ecx,0FFFFFFFD
       cmp       ecx,4
       jne       short M02_L56
       cmp       byte ptr [rbx+14],0
       je        short M02_L56
       mov       rcx,rbx
       call      qword ptr [7FFC6C95E610]; Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       sete      cl
       movzx     ecx,cl
       jmp       short M02_L57
M02_L56:
       xor       ecx,ecx
M02_L57:
       lea       eax,[r14-4]
       cmp       r15d,4
       jne       short M02_L58
       or        eax,1
M02_L58:
       lea       rdx,[rbx+10]
       mov       r8d,eax
       or        r8d,2
       mov       eax,r14d
       lock cmpxchg [rdx],r8d
       cmp       eax,r14d
       jne       short M02_L54
       jmp       short M02_L60
M02_L59:
       mov       rcx,rdi
       call      qword ptr [7FFC6CFE6AD8]
       int       3
M02_L60:
       test      ecx,ecx
       je        short M02_L61
       call      00007FFCCC486260
       mov       edi,eax
       mov       rcx,[rbx+8]
       call      qword ptr [7FFC6CF4EBE0]; Interop+Kernel32.CloseHandle(IntPtr)
       mov       ecx,edi
       call      00007FFCCC486280
M02_L61:
       test      dword ptr [rsi],100000
       je        short M02_L64
       jmp       short M02_L63
M02_L62:
       mov       rcx,rbx
       mov       edx,1
       mov       rax,[rsi+40]
       call      qword ptr [rax+30]
       jmp       short M02_L61
M02_L63:
       mov       rcx,rbx
       call      00007FFCCC448C20
M02_L64:
       nop
       add       rsp,28
       ret
; Total bytes of code 1886
```
```assembly
; System.SpanHelpers.LastIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       cmp       r8d,8
       jl        near ptr M03_L05
       cmp       r8d,10
       jl        near ptr M03_L19
       vmovd     xmm0,edx
       vpbroadcastw ymm0,xmm0
       add       r8d,0FFFFFFF0
       test      r8d,r8d
       jle       short M03_L01
M03_L00:
       mov       edx,r8d
       vmovups   ymm1,[rcx+rdx*2]
       vpcmpeqw  ymm2,ymm1,ymm0
       vptest    ymm2,ymm2
       jne       short M03_L03
       add       r8d,0FFFFFFF0
       test      r8d,r8d
       jg        short M03_L00
M03_L01:
       vmovups   ymm1,[rcx]
       vpcmpeqw  ymm2,ymm1,ymm0
       vptest    ymm2,ymm2
       jne       short M03_L04
       mov       eax,0FFFFFFFF
M03_L02:
       vzeroupper
       ret
M03_L03:
       vpcmpeqw  ymm1,ymm1,ymm0
       vpshufb   ymm0,ymm1,[7FFC6C916FA0]
       vpermq    ymm0,ymm0,0D8
       vpmovmskb ecx,xmm0
       xor       edx,edx
       lzcnt     edx,ecx
       neg       edx
       lea       eax,[rdx+r8+1F]
       jmp       short M03_L02
M03_L04:
       vpcmpeqw  ymm0,ymm1,ymm0
       vpshufb   ymm0,ymm0,[7FFC6C916FA0]
       vpermq    ymm0,ymm0,0D8
       vpmovmskb eax,xmm0
       xor       edx,edx
       lzcnt     edx,eax
       mov       eax,edx
       neg       eax
       add       eax,1F
       jmp       short M03_L02
M03_L05:
       movsxd    rax,r8d
       dec       rax
       cmp       r8d,8
       jl        near ptr M03_L07
M03_L06:
       add       r8d,0FFFFFFF8
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M03_L18
       movsx     r10,word ptr [rcx+rax*2-2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M03_L17
       movsx     r10,word ptr [rcx+rax*2-4]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M03_L16
       movsx     r10,word ptr [rcx+rax*2-6]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M03_L15
       movsx     r10,word ptr [rcx+rax*2-8]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M03_L14
       movsx     r10,word ptr [rcx+rax*2-0A]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M03_L13
       movsx     r10,word ptr [rcx+rax*2-0C]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M03_L12
       movsx     r10,word ptr [rcx+rax*2-0E]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M03_L11
       add       rax,0FFFFFFFFFFFFFFF8
       cmp       r8d,8
       jge       near ptr M03_L06
M03_L07:
       cmp       r8d,4
       jl        short M03_L09
       add       r8d,0FFFFFFFC
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M03_L18
       movsx     r10,word ptr [rcx+rax*2-2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M03_L17
       movsx     r10,word ptr [rcx+rax*2-4]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M03_L16
       movsx     r10,word ptr [rcx+rax*2-6]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M03_L15
       add       rax,0FFFFFFFFFFFFFFFC
       test      r8d,r8d
       jle       short M03_L10
M03_L08:
       dec       r8d
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M03_L18
       dec       rax
M03_L09:
       test      r8d,r8d
       jg        short M03_L08
M03_L10:
       mov       eax,0FFFFFFFF
       vzeroupper
       ret
M03_L11:
       add       eax,0FFFFFFF9
       jmp       near ptr M03_L02
M03_L12:
       add       eax,0FFFFFFFA
       jmp       near ptr M03_L02
M03_L13:
       add       eax,0FFFFFFFB
       jmp       near ptr M03_L02
M03_L14:
       add       eax,0FFFFFFFC
       jmp       near ptr M03_L02
M03_L15:
       add       eax,0FFFFFFFD
       jmp       near ptr M03_L02
M03_L16:
       add       eax,0FFFFFFFE
       jmp       near ptr M03_L02
M03_L17:
       dec       eax
       jmp       near ptr M03_L02
M03_L18:
       jmp       near ptr M03_L02
M03_L19:
       movsx     rdx,dx
       vzeroupper
       jmp       qword ptr [7FFC6C9D43F0]; System.SpanHelpers.<LastIndexOfValueType>g__SimdImpl|93_0[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
; Total bytes of code 540
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       cmp       rbx,8
       jb        near ptr M04_L14
       cmp       rsi,rdi
       je        near ptr M04_L04
       cmp       rbx,20
       jae       near ptr M04_L06
       mov       rcx,7FFC6D006AF8
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rbx,10
       jae       short M04_L01
       mov       rcx,7FFC6D006B10
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFC6D006B14
       call      CORINFO_HELP_COUNTPROFILE32
       add       rbx,0FFFFFFFFFFFFFFF8
       mov       rcx,[rsi]
       sub       rcx,[rdi]
       mov       rax,[rsi+rbx]
       sub       rax,[rdi+rbx]
       or        rcx,rax
       sete      bl
       movzx     ebx,bl
M04_L00:
       mov       rcx,7FFC6D006ADC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,ebx
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L01:
       xor       ebp,ebp
       add       rbx,0FFFFFFFFFFFFFFF0
       je        short M04_L03
       vmovups   xmm0,[rsi]
       vpcmpeqb  xmm0,xmm0,[rdi]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M04_L05
M04_L02:
       add       rbp,10
       cmp       rbx,rbp
       ja        near ptr M04_L18
       mov       rcx,7FFC6D006AFC
       call      CORINFO_HELP_COUNTPROFILE32
M04_L03:
       vmovups   xmm0,[rsi+rbx]
       vpcmpeqb  xmm0,xmm0,[rdi+rbx]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M04_L10
       mov       rcx,7FFC6D006B00
       call      CORINFO_HELP_COUNTPROFILE32
M04_L04:
       mov       rcx,7FFC6D006AE0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       eax,1
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L05:
       mov       rcx,7FFC6D006B0C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L09
M04_L06:
       xor       ebp,ebp
       add       rbx,0FFFFFFFFFFFFFFE0
       je        near ptr M04_L12
       vmovups   ymm0,[rsi]
       vpcmpeqb  ymm0,ymm0,[rdi]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M04_L08
M04_L07:
       add       rbp,20
       cmp       rbx,rbp
       jbe       short M04_L11
       mov       rcx,7FFC6D006AF0
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rsi+rbp]
       vpcmpeqb  ymm0,ymm0,[rdi+rbp]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       je        short M04_L07
M04_L08:
       mov       rcx,7FFC6D006AF4
       call      CORINFO_HELP_COUNTPROFILE32
M04_L09:
       mov       rcx,7FFC6D006B18
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L10:
       mov       rcx,7FFC6D006B04
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L09
M04_L11:
       mov       rcx,7FFC6D006AE4
       call      CORINFO_HELP_COUNTPROFILE32
M04_L12:
       vmovups   ymm0,[rsi+rbx]
       vpcmpeqb  ymm0,ymm0,[rdi+rbx]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M04_L13
       mov       rcx,7FFC6D006AE8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L04
M04_L13:
       mov       rcx,7FFC6D006AEC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L09
M04_L14:
       cmp       rbx,4
       jb        short M04_L15
       mov       rcx,7FFC6D006AD8
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbx-4]
       mov       eax,[rsi]
       sub       eax,[rdi]
       mov       edx,[rsi+rcx]
       sub       edx,[rdi+rcx]
       or        eax,edx
       sete      bl
       movzx     ebx,bl
       jmp       near ptr M04_L00
M04_L15:
       xor       ebp,ebp
       mov       r14,rbx
       and       r14,2
       je        short M04_L16
       mov       rcx,7FFC6D006AD0
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ebp,word ptr [rsi]
       movzx     ecx,word ptr [rdi]
       sub       ebp,ecx
M04_L16:
       test      bl,1
       je        short M04_L17
       mov       rcx,7FFC6D006AD4
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ecx,byte ptr [rsi+r14]
       movzx     eax,byte ptr [rdi+r14]
       sub       ecx,eax
       or        ebp,ecx
M04_L17:
       test      ebp,ebp
       sete      bl
       movzx     ebx,bl
       jmp       near ptr M04_L00
M04_L18:
       mov       rcx,7FFC6D006B08
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   xmm0,[rsi+rbp]
       vpcmpeqb  xmm0,xmm0,[rdi+rbp]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M04_L05
       jmp       near ptr M04_L02
; Total bytes of code 686
```
```assembly
; System.String.Ctor(System.ReadOnlySpan`1<Char>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx]
       mov       esi,[rcx+8]
       test      esi,esi
       je        short M05_L00
       mov       edx,esi
       mov       rcx,offset MT_System.String
       call      00007FFCCC488D20
       mov       rdi,rax
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFC6C835818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L00:
       mov       rax,1FEFF9E0008
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
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
; System.Diagnostics.Process.EnsureState(State)
M07_L00:
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       ebx,edx
       test      bl,20
       jne       short M07_L06
M07_L01:
       test      bl,1
       je        short M07_L02
       cmp       byte ptr [rsi+0E4],0
       je        short M07_L07
M07_L02:
       test      bl,2
       jne       near ptr M07_L09
M07_L03:
       test      bl,8
       jne       near ptr M07_L10
M07_L04:
       test      bl,10
       jne       near ptr M07_L12
M07_L05:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L06:
       mov       rcx,rsi
       call      qword ptr [7FFC6CFE7960]
       test      eax,eax
       jne       short M07_L01
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6CFE7228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CC85D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L07:
       cmp       byte ptr [rsi+0E5],0
       je        short M07_L08
       mov       rcx,[rsi+18]
       call      qword ptr [7FFC6CFE7240]
       mov       [rsi+0D0],eax
       mov       byte ptr [rsi+0E4],1
       jmp       short M07_L02
M07_L08:
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFC6CF4EA48]
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6CFE7258]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CC85D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L09:
       cmp       byte ptr [rsi+0E6],0
       je        near ptr M07_L03
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6CFE7270]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CAB7750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L10:
       cmp       qword ptr [rsi+28],0
       jne       near ptr M07_L04
       mov       ecx,ebx
       not       ecx
       and       ecx,5
       je        short M07_L11
       mov       rcx,rsi
       mov       edx,5
       call      qword ptr [7FFC6CF4EA48]
M07_L11:
       mov       ecx,[rsi+0D0]
       mov       rdx,[rsi+20]
       call      qword ptr [7FFC6CFE7288]
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rsi+28],0
       jne       near ptr M07_L04
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6CFE72A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CC85D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L12:
       mov       rcx,rsi
       call      qword ptr [7FFC6CFE72B8]
       test      eax,eax
       jne       short M07_L13
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6CFE72D0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CC85D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L13:
       cmp       byte ptr [rsi+0E5],0
       jne       near ptr M07_L05
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC6CFE72E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC6CC85D28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 507
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.ProcessPath()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,19491C000B8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L01
       mov       rsi,[rcx+18]
M00_L00:
       mov       rcx,[rsi+20]
       mov       [rsp+20],rcx
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FFC6CAEFBE8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M01_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M01_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M01_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFCB80AD220]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M01_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M01_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M01_L03:
       cmp       ecx,8
       ja        short M01_L04
       mov       ecx,ecx
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M01_L00]
       add       rdx,r8
       jmp       rdx
M01_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFCB80A3CF0]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFCB80AD210]
       jmp       short M01_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCB80AD218]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M01_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFCB808A810]
       mov       rcx,rax
       call      qword ptr [7FFCB8091F40]
       mov       rcx,rax
       call      qword ptr [7FFCB80B3100]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFCB80AD228]
       jmp       near ptr M01_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M01_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFCB80AD228]
       jmp       near ptr M01_L01
M01_L05:
       mov       rcx,rbx
       call      qword ptr [7FFCB80AD238]
       jmp       near ptr M01_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFCB80AD220]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M01_L01
; Total bytes of code 269
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.ReferencedAssemblies()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,154B3400110
       mov       rax,[rcx]
       test      rax,rax
       je        short M00_L01
M00_L00:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.Func<System.Collections.ObjectModel.ReadOnlyCollection<System.String>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,7FFC6CF6AD30
       mov       r9,7FFC6C78D0B0
       call      qword ptr [7FFC6C846EB0]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,154B3400110
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M00_L00
; Total bytes of code 142
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
       call      qword ptr [7FFCB8087FD0]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.StackTrace()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFC6CF47198]; System.Environment.get_StackTrace()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 56
```
```assembly
; System.Environment.get_StackTrace()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rcx,offset MT_System.Diagnostics.StackTrace
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFC6CF471C8]; System.Diagnostics.StackTrace..ctor(Boolean)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,100
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       mov       r8,rsi
       xor       edx,edx
       call      qword ptr [7FFC6CF4D680]; System.Diagnostics.StackTrace.ToString(TraceFormat, System.Text.StringBuilder)
       mov       rcx,rsi
       call      qword ptr [7FFC6CAB0A18]; System.Text.StringBuilder.ToString()
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 126
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.WorkingSet()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FFC6CF5ED00]; System.Environment.get_WorkingSet()
       mov       rcx,[rbx+18]
       mov       [rcx+18],rax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 28
```
```assembly
; System.Environment.get_WorkingSet()
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
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rax,rsp
       mov       [rbp-0A0],rax
       mov       rax,rbp
       mov       [rbp-90],rax
       vxorps    ymm1,ymm1,ymm1
       vmovdqu   ymmword ptr [rbp-80],ymm1
       vmovdqu   ymmword ptr [rbp-60],ymm1
       vmovdqu   xmmword ptr [rbp-48],xmm1
       mov       dword ptr [rbp-80],48
       mov       rax,7FFC6C957DC0
       mov       [rbp-0A8],rax
       lea       rax,[M01_L00]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFCFA4D4BC0
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFCCC79F778],0
       je        short M01_L01
       call      qword ptr [7FFCCC78D608]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rdx,[rbp-0B0]
       mov       [rbx+8],rdx
       mov       rcx,rax
       mov       r8d,[rbp-80]
       lea       rdx,[rbp-80]
       mov       rax,7FFC6C9598A8
       mov       [rbp-0A8],rax
       lea       rax,[M01_L02]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFCFA4ED060
       call      rax
M01_L02:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFCCC79F778],0
       je        short M01_L03
       call      qword ptr [7FFCCC78D608]; CORINFO_HELP_STOP_FOR_GC
M01_L03:
       mov       rcx,[rbp-0B0]
       mov       [rbx+8],rcx
       xor       ecx,ecx
       test      eax,eax
       mov       rax,rcx
       cmovne    rax,[rbp-70]
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
; Total bytes of code 310
```

