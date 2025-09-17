## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.AppInfo()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,21A0A400088
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
       call      qword ptr [7FFE77734048]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       call      qword ptr [7FFED6D14378]
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
       call      qword ptr [7FFED6D0ADE8]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFED6D14368]
       jmp       short M01_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFED6D14370]
       jmp       short M01_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFED6CF1810]
       mov       rcx,rax
       call      qword ptr [7FFED6CF8FA0]
       mov       rcx,rax
       call      qword ptr [7FFED6D1A270]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFED6D14380]
       jmp       near ptr M01_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M01_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFED6D14380]
       jmp       near ptr M01_L01
M01_L05:
       mov       rcx,rbx
       call      qword ptr [7FFED6D14390]
       jmp       near ptr M01_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFED6D14378]
       jmp       near ptr M01_L01
; Total bytes of code 269
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.CurrentCulture()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
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
       mov       rax,1A153400190
       mov       rax,[rax]
       test      rax,rax
       jne       short M00_L01
       mov       rax,1A153400170
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
       call      qword ptr [7FFE777C4330]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FFE772BD488]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       short M00_L01
; Total bytes of code 154
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
       call      qword ptr [7FFED6CEF7D8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFED6D06B30]
       mov       rdx,rax
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFED6D07CE8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFED6D05510]
       int       3
; Total bytes of code 61
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.CurrentThreadId()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,1943CC020B0
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
       call      qword ptr [7FFE7761F978]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       call      qword ptr [7FFED6D14378]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7FFED6D0ADE8]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFED6D14368]
       jmp       short M01_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFED6D14370]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M01_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFED6CF1810]
       mov       rcx,rax
       call      qword ptr [7FFED6CF8FA0]
       mov       rcx,rax
       call      qword ptr [7FFED6D1A270]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFED6D14380]
       jmp       near ptr M01_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M01_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFED6D14380]
       jmp       near ptr M01_L01
M01_L05:
       mov       rcx,rbx
       call      qword ptr [7FFED6D14390]
       jmp       near ptr M01_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFED6D14378]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M01_L01
; Total bytes of code 269
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       mov       rax,1F12F000188
       mov       rax,[rax]
       test      rax,rax
       jne       short M00_L01
       mov       rax,1F12F000178
       mov       rax,[rax]
       test      rax,rax
       jne       short M00_L01
       call      qword ptr [7FFE7762C8E8]; System.Globalization.CultureInfo.InitializeUserDefaultUICulture()
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
       call      qword ptr [7FFE777D4330]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M00_L00
; Total bytes of code 152
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultUICulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFED6CEF7D8]
       mov       rbx,rax
       lea       rsi,[rbx+8]
       call      qword ptr [7FFED6D06B38]
       mov       rdx,rax
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFED6D07CE8]
       mov       rax,[rbx+8]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFED6D05510]
       int       3
; Total bytes of code 63
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

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.ExecutingFolder()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,246800020A0
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
       mov       r8,7FFE779BA6E8
       mov       r9,7FFE771FD010
       call      qword ptr [7FFE772B7150]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,246800020A0
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
       call      qword ptr [7FFED6CEEFD8]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.GetCultureNames()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,212588020A8
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
       mov       r8,7FFE779BA6D0
       mov       r9,7FFE771ED1A0
       call      qword ptr [7FFE772A7150]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,212588020A8
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
       call      qword ptr [7FFED6CEEFD8]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.GetEnvironmentVariables()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,1E6834020B0
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
       mov       r8,7FFE779AA220
       mov       r9,7FFE771FD010
       call      qword ptr [7FFE772B7150]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,1E6834020B0
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
       call      qword ptr [7FFED6CEEFD8]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.GetProcessorInformation()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,29DBC8000C0
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
       mov       r8,7FFE7799A8F8
       mov       r9,7FFE771CD1A0
       call      qword ptr [7FFE77287150]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,29DBC8000C0
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
       call      qword ptr [7FFED6CEEFD8]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.InstalledUICulture()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rax,2142D800170
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
       call      qword ptr [7FFE772BD488]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       jmp       short M00_L00
; Total bytes of code 76
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
       je        short M01_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFED6D07CE8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFED6D05510]
       int       3
; Total bytes of code 61
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.IsRunning()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,20D4F4000C8
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
       mov       r8,7FFE7799A298
       mov       r9,7FFE771ED010
       call      qword ptr [7FFE772A7150]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,20D4F4000C8
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
       call      qword ptr [7FFED6CEEFD8]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.IsRunningFromAspNet()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,214FC4000D0
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
       mov       r8,7FFE779BA7D8
       mov       r9,7FFE771ED010
       call      qword ptr [7FFE772A7150]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,214FC4000D0
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
       call      qword ptr [7FFED6CEEFD8]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.IsUserAdministrator()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,27CE48020D0
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
       mov       r8,7FFE779AA1F0
       mov       r9,7FFE771FD010
       call      qword ptr [7FFE772B7150]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,27CE48020D0
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
       call      qword ptr [7FFED6CEEFD8]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.MaxDegreeOfParallelism()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,2C87E4020D8
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
       mov       r8,7FFE7799A6E8
       mov       r9,7FFE771CD010
       call      qword ptr [7FFE77287150]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,2C87E4020D8
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
       call      qword ptr [7FFED6CEEFD8]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.OSArchitecture()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       call      qword ptr [7FFE7797E2C8]; System.Runtime.InteropServices.RuntimeInformation.get_OSArchitecture()
       mov       [rsp+28],eax
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE7797E340]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Runtime.InteropServices.Architecture, System.Private.CoreLib]](System.Runtime.InteropServices.Architecture ByRef)
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
       mov       eax,[7FFE771CB178]
       dec       eax
       js        short M01_L01
M01_L00:
       add       rsp,68
       pop       rbx
       pop       rbp
       ret
M01_L01:
       mov       rcx,18998AFC8D0
       xor       edx,edx
       mov       r8d,800
       call      qword ptr [7FFE77875CE0]; Interop+Kernel32.LoadLibraryEx(System.String, IntPtr, Int32)
       mov       rcx,rax
       lea       r8,[rbp-10]
       mov       rdx,18998B00090
       call      qword ptr [7FFE77A47078]
       test      eax,eax
       je        short M01_L03
       mov       rbx,[rbp-10]
       call      00007FFE77278A08
       mov       rcx,rax
       lea       r8,[rbp-20]
       lea       rdx,[rbp-18]
       mov       r10,rbx
       mov       r11,189988EBCF0
       call      CORINFO_HELP_PINVOKE_CALLI
       test      eax,eax
       je        short M01_L02
       movzx     ecx,word ptr [rbp-20]
       call      qword ptr [7FFE7797E2E0]; System.Runtime.InteropServices.RuntimeInformation.MapMachineConstant(UInt16)
       jmp       short M01_L04
M01_L02:
       mov       eax,1
       jmp       short M01_L04
M01_L03:
       lea       rcx,[rbp-50]
       call      00007FFE772789D8
       movzx     ecx,word ptr [rbp-50]
       call      qword ptr [7FFE77A460A0]
M01_L04:
       lea       ecx,[rax+1]
       mov       [7FFE771CB178],ecx
       jmp       near ptr M01_L00
; Total bytes of code 176
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Runtime.InteropServices.Architecture, System.Private.CoreLib]](System.Runtime.InteropServices.Architecture ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.OSDescription()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE779BE718]; System.Runtime.InteropServices.RuntimeInformation.get_OSDescription()
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
       mov       rax,62AD67AAC7D4
       mov       [rbp+8],rax
       mov       rax,1433C0000D0
       mov       rbx,[rax]
       test      rbx,rbx
       je        short M01_L02
M01_L00:
       mov       rax,rbx
       mov       rcx,62AD67AAC7D4
       cmp       [rbp+8],rcx
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
       call      qword ptr [7FFE779BE730]; System.Environment.get_OSVersion()
       mov       rbx,rax
       mov       rsi,[rbx+8]
       test      [rsp],esp
       sub       rsp,200
       lea       rax,[rsp+30]
       mov       rcx,[rbx+10]
       mov       rdx,183BAF30008
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
       call      qword ptr [7FFE7761EA60]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32, System.IFormatProvider, System.Span`1<Char>)
       lea       rcx,[rbp+48]
       mov       rdx,183BAF40090
       call      qword ptr [7FFE7761E100]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
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
       mov       rdx,183BAF37A38
       call      qword ptr [7FFE779BC198]
M01_L04:
       mov       edx,[rsi+8]
       lea       rcx,[rbp+48]
       call      qword ptr [7FFE779BE778]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.UInt32, System.Private.CoreLib]](UInt32)
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
       mov       rdx,183BAF30C80
       call      qword ptr [7FFE779BC198]
M01_L06:
       mov       edx,[rsi+0C]
       lea       rcx,[rbp+48]
       call      qword ptr [7FFE779BE778]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.UInt32, System.Private.CoreLib]](UInt32)
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
       mov       rdx,183BAF30C80
       call      qword ptr [7FFE779BC198]
M01_L08:
       mov       edx,[rsi+10]
       lea       rcx,[rbp+48]
       call      qword ptr [7FFE779BE778]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.UInt32, System.Private.CoreLib]](UInt32)
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
       mov       rdx,183BAF37A38
       call      qword ptr [7FFE779BC198]
M01_L10:
       mov       rdx,[rbx+10]
       mov       rcx,183BAF30008
       test      rdx,rdx
       cmove     rdx,rcx
       lea       rcx,[rbp+48]
       call      qword ptr [7FFE7761E100]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rbp+48]
       call      qword ptr [7FFE772BC270]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       call      qword ptr [7FFE7761EA60]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32, System.IFormatProvider, System.Span`1<Char>)
       lea       rcx,[rbp+20]
       mov       rdx,183BAF40090
       call      qword ptr [7FFE7761E100]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
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
       mov       rdx,183BAF37A38
       call      qword ptr [7FFE779BC198]
M01_L13:
       mov       edx,[rsi+8]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFE779BE778]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.UInt32, System.Private.CoreLib]](UInt32)
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
       mov       rdx,183BAF30C80
       call      qword ptr [7FFE779BC198]
M01_L15:
       mov       edx,[rsi+0C]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFE779BE778]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.UInt32, System.Private.CoreLib]](UInt32)
       mov       ecx,[rbp+30]
       cmp       ecx,[rbp+40]
       jbe       short M01_L17
M01_L16:
       call      qword ptr [7FFE7752F168]
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
       mov       rdx,183BAF30C80
       call      qword ptr [7FFE779BC198]
M01_L19:
       mov       edx,[rsi+10]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFE779BE778]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.UInt32, System.Private.CoreLib]](UInt32)
       lea       rcx,[rbp+20]
       call      qword ptr [7FFE772BC270]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rbx,rax
M01_L20:
       mov       rcx,1433C0000D0
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L00
; Total bytes of code 904
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.ProcessArchitecture()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       mov       rcx,[rcx+18]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE779BE2C8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Runtime.InteropServices.Architecture, System.Private.CoreLib]](System.Runtime.InteropServices.Architecture ByRef)
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

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.ProcessId()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[7FFE771CB054]
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
       call      qword ptr [7FFE7797E2B0]; System.Environment.GetProcessId()
       mov       esi,eax
       mov       [7FFE771CB054],esi
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
       call      qword ptr [7FFED6CEF020]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [rax]
       mov       ebx,eax
       lea       rcx,[rbp-90]
       call      qword ptr [7FFED6CEF028]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
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
       mov       esi,[7FFE771EB054]
       test      esi,esi
       jne       short M00_L00
       call      qword ptr [7FFE779BE9A0]; System.Environment.GetProcessId()
       mov       esi,eax
       mov       [7FFE771EB054],esi
M00_L00:
       mov       rcx,offset MT_System.Diagnostics.Process
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,[rdi]
       test      dword ptr [rcx],100000
       je        short M00_L01
       mov       rcx,rdi
       call      00007FFED6EA5FF0
M00_L01:
       xor       eax,eax
       mov       [rdi+28],rax
       mov       rax,19E50140C80
       mov       [rdi+20],rax
       mov       byte ptr [rdi+0E6],0
       mov       [rdi+0D0],esi
       mov       byte ptr [rdi+0E4],1
       xor       eax,eax
       mov       [rdi+0DC],eax
       mov       [rdi+0E0],eax
       cmp       qword ptr [rdi+0A0],0
       jne       near ptr M00_L15
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
       mov       rax,19E50140C80
       cmp       r15,rax
       je        short M00_L08
       cmp       r14d,1
       jne       short M00_L02
       cmp       word ptr [r15],2E
       je        short M00_L08
M00_L02:
       call      qword ptr [7FFE77A67060]
       test      rax,rax
       jne       near ptr M00_L16
       xor       edx,edx
       xor       r8d,r8d
M00_L03:
       cmp       r14d,r8d
       je        near ptr M00_L17
M00_L04:
       mov       rcx,rbp
       mov       edx,1
       call      qword ptr [7FFE77A66E38]
       xor       ecx,ecx
       cmp       [rax+8],ecx
       jle       short M00_L06
M00_L05:
       mov       rdx,[rax+rcx*8+10]
       cmp       [rdx+64],esi
       je        short M00_L10
       inc       ecx
       cmp       [rax+8],ecx
       jg        short M00_L05
M00_L06:
       xor       edx,edx
       jmp       near ptr M00_L14
M00_L07:
       test      eax,eax
       je        short M00_L04
M00_L08:
       mov       ecx,esi
       call      qword ptr [7FFE779BEBF8]; Interop+Kernel32.GetProcessName(UInt32)
       mov       rbp,rax
       test      rbp,rbp
       je        short M00_L06
       lea       rsi,[rbp+0C]
       mov       r14d,[rbp+8]
       mov       rcx,rsi
       mov       r8d,r14d
       mov       edx,5C
       call      qword ptr [7FFE7751C510]; System.SpanHelpers.LastIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       inc       eax
       cmp       eax,r14d
       jbe       short M00_L11
M00_L09:
       call      qword ptr [7FFE7751F1F8]
       int       3
M00_L10:
       mov       rdx,[rdx+10]
       jmp       near ptr M00_L14
M00_L11:
       mov       r8d,eax
       lea       rsi,[rsi+r8*2]
       sub       r14d,eax
       mov       r15d,r14d
       cmp       r15d,4
       jl        short M00_L12
       mov       r8d,r15d
       lea       r8,[rsi+r8*2-8]
       mov       rcx,20002000200000
       or        rcx,[r8]
       mov       r8,6500780065002E
       cmp       rcx,r8
       sete      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        short M00_L12
       lea       r15d,[r14-4]
       cmp       r15d,r14d
       ja        short M00_L09
M00_L12:
       lea       rdx,[rbp+0C]
       mov       r8d,[rbp+8]
       cmp       r15d,r8d
       jne       short M00_L13
       mov       r8d,r8d
       add       r8,r8
       mov       rcx,rsi
       call      qword ptr [7FFE772AC300]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M00_L23
M00_L13:
       mov       [rsp+20],rsi
       mov       [rsp+28],r15d
       lea       rcx,[rsp+20]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdx,rax
M00_L14:
       lea       rcx,[rdi+0A0]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rdi+0A0],0
       je        near ptr M00_L24
M00_L15:
       mov       rcx,[rdi+0A0]
       mov       [rsp+30],rcx
       mov       rcx,[rbx+18]
       lea       r8,[rsp+30]
       mov       rdx,7FFE77A374E8
       cmp       [rcx],ecx
       call      qword ptr [7FFE779BED48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L16:
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       jmp       near ptr M00_L03
M00_L17:
       test      r8d,r8d
       je        near ptr M00_L08
       cmp       r8d,8
       jl        short M00_L20
       cmp       r8d,10
       jl        short M00_L22
       jmp       short M00_L21
M00_L18:
       mov       ecx,21
       call      qword ptr [7FFE772AF330]
       int       3
M00_L19:
       mov       ecx,0D2E
       mov       rdx,7FFE77A31FA0
       call      qword ptr [7FFE772AF1F8]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE77A67048]
       int       3
M00_L20:
       mov       rcx,r15
       call      qword ptr [7FFE77A672B8]
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,r15
       call      qword ptr [7FFE77A67258]
       jmp       near ptr M00_L07
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FFE7760DF80]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector[[System.Runtime.Intrinsics.Vector128`1[[System.UInt16, System.Private.CoreLib]], System.Private.CoreLib]](Char ByRef, Char ByRef, Int32)
       jmp       near ptr M00_L07
M00_L23:
       mov       rdx,rbp
       jmp       near ptr M00_L14
M00_L24:
       mov       rcx,rdi
       mov       edx,8
       call      qword ptr [7FFE779BE9E8]; System.Diagnostics.Process.EnsureState(State)
       mov       rcx,[rdi+28]
       mov       rdx,[rcx+10]
       lea       rcx,[rdi+0A0]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L15
; Total bytes of code 781
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
       call      qword ptr [7FFED6CEF020]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [rax]
       mov       ebx,eax
       lea       rcx,[rbp-90]
       call      qword ptr [7FFED6CEF028]; CORINFO_HELP_JIT_PINVOKE_END
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+20],ymm4
       vmovdqu   ymmword ptr [rbp+40],ymm4
       vmovdqu   ymmword ptr [rbp+60],ymm4
       vmovdqu   ymmword ptr [rbp+80],ymm4
       vmovdqu   ymmword ptr [rbp+0A0],ymm4
       vmovdqa   xmmword ptr [rbp+0C0],xmm4
       mov       rax,67E5A9D345C2
       mov       [rbp+8],rax
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
       mov       byte ptr [rbp+60],0
       mov       rcx,19E50150120
       mov       rax,offset MT_Microsoft.Win32.SafeHandles.SafeProcessHandle
       mov       eax,[rax]
       and       eax,0C0000
       cmp       eax,40000
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L20
       call      qword ptr [7FFE77515638]; System.RuntimeType.CreateInstanceOfT()
       mov       rsi,rax
M02_L00:
       xor       ecx,ecx
       mov       [rbp+0B8],rcx
       mov       [rbp+28],rsi
       mov       [rbp+18],rsi
       xor       ecx,ecx
       mov       rax,7FFFEE1A5FF0
       call      rax
       mov       r8d,ebx
       mov       ecx,1000
       xor       edx,edx
       mov       rax,7FFE77A359A0
       mov       [rbp+78],rax
       lea       rax,[M02_L01]
       mov       [rbp+88],rax
       mov       rax,[rbp+0A0]
       lea       r10,[rbp+68]
       mov       [rax+8],r10
       mov       rax,[rbp+0A0]
       mov       byte ptr [rax+4],0
       mov       rax,7FFFEE1AB120
       call      rax
M02_L01:
       mov       rcx,[rbp+0A0]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFED71EE808],0
       je        short M02_L02
       call      qword ptr [7FFED71DC608]; CORINFO_HELP_STOP_FOR_GC
M02_L02:
       mov       rcx,[rbp+0A0]
       mov       rdx,[rbp+70]
       mov       [rcx+8],rdx
       mov       rbx,rax
       mov       rax,7FFFEE1A5F30
       call      rax
       mov       dword ptr [rbp+0C4],1
       mov       byte ptr [rbp+60],1
       mov       rsi,[rbp+28]
       mov       [rsi+8],rbx
       mov       ecx,eax
       call      00007FFED6EDCF30
       mov       [rbp+40],rsi
       mov       rax,[rsi+8]
       test      rax,rax
       je        near ptr M02_L17
       cmp       rax,0FFFFFFFFFFFFFFFF
       je        near ptr M02_L17
       test      [rsp],esp
       sub       rsp,210
       lea       rax,[rsp+20]
       mov       [rbp+20],rax
       mov       dword ptr [rbp+64],105
       xor       eax,eax
       mov       [rbp+38],rax
M02_L03:
       mov       eax,[rbp+64]
       mov       [rbp+0D0],eax
       mov       rax,[rbp+20]
       mov       [rbp+0C8],rax
       mov       rbx,[rbp+20]
       xor       eax,eax
       mov       [rbp+0B4],eax
       mov       [rbp+10],rax
       mov       byte ptr [rbp+5C],0
       mov       rsi,[rbp+40]
       mov       [rbp+10],rsi
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
       mov       rcx,[rbp+10]
       mov       rdi,[rcx+8]
       xor       ecx,ecx
       mov       rax,7FFFEE1A5FF0
       call      rax
       lea       r9,[rbp+0D0]
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       mov       rax,7FFE77A35F60
       mov       [rbp+78],rax
       lea       rax,[M02_L05]
       mov       [rbp+88],rax
       mov       rax,[rbp+0A0]
       lea       r10,[rbp+68]
       mov       [rax+8],r10
       mov       rax,[rbp+0A0]
       mov       byte ptr [rax+4],0
       mov       rax,7FFFEE1ACBB0
       call      rax
M02_L05:
       mov       rcx,[rbp+0A0]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFED71EE808],0
       je        short M02_L06
       call      qword ptr [7FFED71DC608]; CORINFO_HELP_STOP_FOR_GC
M02_L06:
       mov       rcx,[rbp+0A0]
       mov       rdx,[rbp+70]
       mov       [rcx+8],rdx
       mov       ebx,eax
       mov       rax,7FFFEE1A5F30
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
       call      qword ptr [7FFE77A66430]
       int       3
M02_L09:
       call      M02_L23
       nop
       mov       ecx,[rbp+0B0]
       call      00007FFED6EDCF30
       cmp       byte ptr [rbp+0B4],0
       je        short M02_L11
       mov       ecx,[rbp+0D0]
       cmp       ecx,[rbp+64]
       ja        short M02_L10
       mov       rax,[rbp+20]
       mov       [rbp+48],rax
       mov       [rbp+50],ecx
       lea       rcx,[rbp+48]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       [rbp+30],rax
       jmp       short M02_L12
M02_L10:
       call      qword ptr [7FFE7751F1F8]
       int       3
M02_L11:
       call      00007FFED6EDCF10
       cmp       eax,7A
       je        short M02_L13
       xor       ecx,ecx
       mov       [rbp+30],rcx
M02_L12:
       xor       ecx,ecx
       mov       [rbp+0C8],rcx
       jmp       short M02_L16
M02_L13:
       call      M02_L38
       nop
       mov       rbx,[rbp+38]
       mov       rcx,15DBB000398
       mov       rcx,[rcx]
       mov       edx,[rbp+64]
       add       edx,edx
       call      qword ptr [7FFE775CAC48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       mov       [rbp+20],rcx
       mov       [rbp+64],edx
       test      rbx,rbx
       je        near ptr M02_L03
       mov       rcx,15DBB000398
       mov       rcx,[rcx]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE775CAC50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
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
       mov       rcx,15DBB000398
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFE775CAC50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       nop
M02_L19:
       call      M02_L40
       jmp       short M02_L21
M02_L20:
       xor       edx,edx
       mov       [rbp+0B8],rdx
       lea       rdx,[rbp+0B8]
       call      qword ptr [7FFE77A66538]
       mov       rsi,[rbp+0B8]
       jmp       near ptr M02_L00
M02_L21:
       mov       rax,[rbp+30]
       mov       rcx,67E5A9D345C2
       cmp       [rbp+8],rcx
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
       je        near ptr M02_L37
       mov       rbx,[rbp+10]
       mov       rcx,[rbp+10]
       cmp       [rcx],cl
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       je        near ptr M02_L33
M02_L24:
       mov       ecx,esi
       and       ecx,0FFFFFFFD
       cmp       ecx,4
       jne       short M02_L30
       jmp       short M02_L26
M02_L25:
       mov       esi,[rbx+10]
       test      esi,0FFFFFFFC
       jne       short M02_L24
       jmp       short M02_L33
M02_L26:
       cmp       byte ptr [rbx+14],0
       je        short M02_L30
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeProcessHandle
       cmp       [rbx],rcx
       jne       short M02_L28
       mov       rcx,[rbx+8]
       test      rcx,rcx
       je        short M02_L27
       cmp       rcx,0FFFFFFFFFFFFFFFF
       sete      dil
       movzx     edi,dil
       jmp       short M02_L29
M02_L27:
       mov       edi,1
       jmp       short M02_L29
M02_L28:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       edi,eax
M02_L29:
       test      edi,edi
       sete      cl
       movzx     ecx,cl
       jmp       short M02_L31
M02_L30:
       xor       ecx,ecx
M02_L31:
       lea       edx,[rsi-4]
       mov       eax,esi
       and       eax,0FFFFFFFC
       cmp       eax,4
       jne       short M02_L32
       or        edx,1
M02_L32:
       lea       r8,[rbx+10]
       mov       eax,esi
       lock cmpxchg [r8],edx
       cmp       eax,esi
       jne       short M02_L25
       jmp       short M02_L34
M02_L33:
       mov       rcx,rbx
       call      qword ptr [7FFE77A66430]
       int       3
M02_L34:
       test      ecx,ecx
       je        short M02_L37
       call      00007FFED6EDCF10
       mov       esi,eax
       mov       rcx,offset MT_Microsoft.Win32.SafeHandles.SafeProcessHandle
       cmp       [rbx],rcx
       jne       short M02_L35
       mov       rbx,[rbx+8]
       xor       ecx,ecx
       call      00007FFE77298E40
       mov       rcx,rbx
       call      00007FFE77298E58
       call      00007FFE77298E70
       mov       ecx,eax
       call      00007FFED6EDCF30
       jmp       short M02_L36
M02_L35:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
M02_L36:
       mov       ecx,esi
       call      00007FFED6EDCF30
M02_L37:
       nop
       add       rsp,28
       ret
M02_L38:
       sub       rsp,28
       vzeroupper
       xor       ecx,ecx
       mov       [rbp+0C8],rcx
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp+38],0
       je        short M02_L39
       mov       rcx,15DBB000398
       mov       rcx,[rcx]
       mov       rdx,[rbp+38]
       xor       r8d,r8d
       call      qword ptr [7FFE775CAC50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M02_L39:
       nop
       add       rsp,28
       ret
M02_L40:
       sub       rsp,28
       vzeroupper
       mov       rsi,[rbp+40]
       mov       eax,[rsi+10]
       test      al,2
       jne       near ptr M02_L51
M02_L41:
       mov       ecx,eax
       and       ecx,0FFFFFFFC
       jne       short M02_L43
       jmp       short M02_L49
M02_L42:
       mov       eax,[rsi+10]
       test      al,2
       jne       near ptr M02_L51
       jmp       short M02_L41
M02_L43:
       mov       edx,eax
       and       edx,0FFFFFFFD
       cmp       edx,4
       jne       short M02_L46
       cmp       byte ptr [rsi+14],0
       je        short M02_L46
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        short M02_L44
       cmp       rdx,0FFFFFFFFFFFFFFFF
       sete      dl
       movzx     edx,dl
       jmp       short M02_L45
M02_L44:
       mov       edx,1
M02_L45:
       test      edx,edx
       sete      dl
       movzx     edx,dl
       jmp       short M02_L47
M02_L46:
       xor       edx,edx
M02_L47:
       lea       r8d,[rax-4]
       cmp       ecx,4
       jne       short M02_L48
       or        r8d,1
M02_L48:
       lea       rcx,[rsi+10]
       or        r8d,2
       mov       [rbp+0A8],eax
       lock cmpxchg [rcx],r8d
       cmp       eax,[rbp+0A8]
       jne       short M02_L42
       jmp       short M02_L50
M02_L49:
       mov       rcx,rsi
       call      qword ptr [7FFE77A66430]
       int       3
M02_L50:
       test      edx,edx
       je        short M02_L51
       call      00007FFED6EDCF10
       mov       ebx,eax
       mov       rdi,[rsi+8]
       xor       ecx,ecx
       call      00007FFE77298E40
       mov       rcx,rdi
       call      00007FFE77298E58
       call      00007FFE77298E70
       mov       ecx,eax
       call      00007FFED6EDCF30
       mov       ecx,ebx
       call      00007FFED6EDCF30
M02_L51:
       mov       rcx,[rsi]
       test      dword ptr [rcx],100000
       je        short M02_L52
       mov       rcx,rsi
       call      00007FFED6EA5FF0
M02_L52:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       dword ptr [rbp+0C4],0
       je        short M02_L53
       cmp       byte ptr [rbp+60],0
       jne       short M02_L53
       mov       rcx,[rbp+18]
       mov       edx,1
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE77515548]; System.GC.SuppressFinalize(System.Object)
M02_L53:
       nop
       add       rsp,28
       ret
; Total bytes of code 1688
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
       vpshufb   ymm0,ymm1,[7FFE77385720]
       vpermq    ymm0,ymm0,0D8
       vpmovmskb ecx,xmm0
       xor       edx,edx
       lzcnt     edx,ecx
       neg       edx
       lea       eax,[rdx+r8+1F]
       jmp       short M03_L02
M03_L04:
       vpcmpeqw  ymm0,ymm1,ymm0
       vpshufb   ymm0,ymm0,[7FFE77385720]
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
       jmp       qword ptr [7FFE7751C528]; System.SpanHelpers.<LastIndexOfValueType>g__SimdImpl|93_0[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       jb        near ptr M04_L13
       cmp       rsi,rdi
       je        near ptr M04_L04
       cmp       rbx,20
       jae       near ptr M04_L06
       mov       rcx,7FFE77A3BCB8
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rbx,10
       jae       short M04_L01
       mov       rcx,7FFE77A3BCD0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFE77A3BCD4
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
       mov       rcx,7FFE77A3BC9C
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
       ja        near ptr M04_L17
       mov       rcx,7FFE77A3BCBC
       call      CORINFO_HELP_COUNTPROFILE32
M04_L03:
       vmovups   xmm0,[rsi+rbx]
       vpcmpeqb  xmm0,xmm0,[rdi+rbx]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M04_L18
       mov       rcx,7FFE77A3BCC0
       call      CORINFO_HELP_COUNTPROFILE32
M04_L04:
       mov       rcx,7FFE77A3BCA0
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
       mov       rcx,7FFE77A3BCCC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L09
M04_L06:
       xor       ebp,ebp
       add       rbx,0FFFFFFFFFFFFFFE0
       je        short M04_L11
       vmovups   ymm0,[rsi]
       vpcmpeqb  ymm0,ymm0,[rdi]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M04_L08
M04_L07:
       add       rbp,20
       cmp       rbx,rbp
       jbe       short M04_L10
       mov       rcx,7FFE77A3BCB0
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rsi+rbp]
       vpcmpeqb  ymm0,ymm0,[rdi+rbp]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       je        short M04_L07
M04_L08:
       mov       rcx,7FFE77A3BCB4
       call      CORINFO_HELP_COUNTPROFILE32
M04_L09:
       mov       rcx,7FFE77A3BCD8
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
       mov       rcx,7FFE77A3BCA4
       call      CORINFO_HELP_COUNTPROFILE32
M04_L11:
       vmovups   ymm0,[rsi+rbx]
       vpcmpeqb  ymm0,ymm0,[rdi+rbx]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       short M04_L12
       mov       rcx,7FFE77A3BCA8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L04
M04_L12:
       mov       rcx,7FFE77A3BCAC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M04_L09
M04_L13:
       cmp       rbx,4
       jb        short M04_L14
       mov       rcx,7FFE77A3BC98
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
M04_L14:
       xor       ebp,ebp
       mov       r14,rbx
       and       r14,2
       je        short M04_L15
       mov       rcx,7FFE77A3BC90
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ebp,word ptr [rsi]
       movzx     ecx,word ptr [rdi]
       sub       ebp,ecx
M04_L15:
       test      bl,1
       je        short M04_L16
       mov       rcx,7FFE77A3BC94
       call      CORINFO_HELP_COUNTPROFILE32
       movzx     ecx,byte ptr [rsi+r14]
       movzx     eax,byte ptr [rdi+r14]
       sub       ecx,eax
       or        ebp,ecx
M04_L16:
       test      ebp,ebp
       sete      bl
       movzx     ebx,bl
       jmp       near ptr M04_L00
M04_L17:
       mov       rcx,7FFE77A3BCC8
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   xmm0,[rsi+rbp]
       vpcmpeqb  xmm0,xmm0,[rdi+rbp]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M04_L05
       jmp       near ptr M04_L02
M04_L18:
       mov       rcx,7FFE77A3BCC4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M04_L09
; Total bytes of code 685
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
       call      00007FFED6EDF840
       mov       rdi,rax
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFE772A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L00:
       mov       rax,19E50140008
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
; System.Globalization.Ordinal.EqualsIgnoreCase_Vector[[System.Runtime.Intrinsics.Vector128`1[[System.UInt16, System.Private.CoreLib]], System.Private.CoreLib]](Char ByRef, Char ByRef, Int32)
       push      rsi
       push      rbx
       sub       rsp,178
       movaps    [rsp+160],xmm6
       movsxd    r9,r8d
       lea       rax,[r9-8]
       xor       r10d,r10d
       movddup   xmm0,qword ptr [System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       movddup   xmm1,qword ptr [System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       movddup   xmm2,qword ptr [System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
M07_L00:
       movups    xmm3,[rcx+r10*2]
       movups    xmm4,[rdx+r10*2]
       movaps    xmm5,xmm3
       por       xmm5,xmm4
       pand      xmm5,xmm2
       movaps    [rsp+150],xmm5
       xorps     xmm5,xmm5
       movaps    [rsp+140],xmm5
       mov       r8,[rsp+150]
       mov       [rsp+128],r8
       mov       r8,[rsp+140]
       mov       [rsp+120],r8
       xor       r8d,r8d
       movzx     r11d,word ptr [rsp+128]
       cmp       r11w,[rsp+120]
       jne       short M07_L02
M07_L01:
       inc       r8d
       cmp       r8d,4
       jge       near ptr M07_L10
       lea       r11,[rsp+128]
       movsxd    rbx,r8d
       movzx     r11d,word ptr [r11+rbx*2]
       lea       rbx,[rsp+120]
       movsxd    rsi,r8d
       cmp       r11w,[rbx+rsi*2]
       je        short M07_L01
M07_L02:
       pand      xmm2,xmm3
       movaps    [rsp+0B0],xmm2
       xorps     xmm0,xmm0
       movaps    [rsp+0A0],xmm0
       mov       r8,[rsp+0B0]
       mov       [rsp+88],r8
       mov       r8,[rsp+0A0]
       mov       [rsp+80],r8
       xor       r8d,r8d
       movzx     eax,word ptr [rsp+88]
       cmp       ax,[rsp+80]
       jne       short M07_L06
M07_L03:
       inc       r8d
       cmp       r8d,4
       jl        near ptr M07_L24
       xorps     xmm0,xmm0
       movaps    [rsp+90],xmm0
       mov       r8,[rsp+0B8]
       mov       [rsp+78],r8
       mov       r8,[rsp+98]
       mov       [rsp+70],r8
       movzx     r8d,word ptr [rsp+78]
       cmp       r8w,[rsp+70]
       je        near ptr M07_L25
M07_L04:
       xor       r8d,r8d
M07_L05:
       test      r8d,r8d
       jne       near ptr M07_L14
M07_L06:
       movddup   xmm2,qword ptr [System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       movaps    xmm0,xmm4
       pand      xmm0,xmm2
       movaps    [rsp+60],xmm0
       xorps     xmm0,xmm0
       movaps    [rsp+50],xmm0
       mov       r8,[rsp+60]
       mov       [rsp+38],r8
       mov       r8,[rsp+50]
       mov       [rsp+30],r8
       movzx     r8d,word ptr [rsp+38]
       cmp       r8w,[rsp+30]
       jne       near ptr M07_L09
       movzx     r8d,word ptr [rsp+3A]
       cmp       r8w,[rsp+32]
       jne       short M07_L09
       movzx     r8d,word ptr [rsp+3C]
       cmp       r8w,[rsp+34]
       jne       short M07_L09
       movzx     r8d,word ptr [rsp+3E]
       cmp       r8w,[rsp+36]
       jne       short M07_L09
       xorps     xmm0,xmm0
       movaps    [rsp+40],xmm0
       mov       r8,[rsp+68]
       mov       [rsp+28],r8
       mov       r8,[rsp+48]
       mov       [rsp+20],r8
       movzx     r8d,word ptr [rsp+28]
       cmp       r8w,[rsp+20]
       jne       short M07_L07
       movzx     r8d,word ptr [rsp+2A]
       cmp       r8w,[rsp+22]
       jne       short M07_L07
       movzx     r8d,word ptr [rsp+2C]
       cmp       r8w,[rsp+24]
       je        near ptr M07_L27
M07_L07:
       xor       r8d,r8d
M07_L08:
       test      r8d,r8d
       jne       near ptr M07_L14
M07_L09:
       lea       r8,[r10+r10]
       add       rcx,r8
       add       r8,rdx
       sub       r9d,r10d
       mov       edx,r9d
       call      qword ptr [7FFED6D07388]
       test      eax,eax
       sete      al
       movzx     eax,al
       movaps    xmm6,[rsp+160]
       add       rsp,178
       pop       rbx
       pop       rsi
       ret
M07_L10:
       xorps     xmm5,xmm5
       movaps    [rsp+130],xmm5
       mov       r8,[rsp+158]
       mov       [rsp+118],r8
       mov       r8,[rsp+138]
       mov       [rsp+110],r8
       xor       r8d,r8d
       movzx     r11d,word ptr [rsp+118]
       cmp       r11w,[rsp+110]
       jne       short M07_L12
M07_L11:
       inc       r8d
       cmp       r8d,4
       jge       near ptr M07_L15
       lea       r11,[rsp+118]
       movsxd    rbx,r8d
       movzx     r11d,word ptr [r11+rbx*2]
       lea       rsi,[rsp+110]
       cmp       r11w,[rsi+rbx*2]
       je        short M07_L11
M07_L12:
       xor       r8d,r8d
M07_L13:
       test      r8d,r8d
       je        near ptr M07_L02
       movaps    xmm5,xmm3
       pcmpeqw   xmm5,xmm4
       pcmpeqd   xmm6,xmm6
       pxor      xmm5,xmm6
       ptest     xmm5,xmm5
       je        short M07_L16
       por       xmm3,xmm0
       por       xmm4,xmm0
       movaps    xmm6,xmm3
       psubw     xmm6,xmm1
       pand      xmm5,xmm6
       paddw     xmm5,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       pcmpgtw   xmm5,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       ptest     xmm5,xmm5
       jne       short M07_L14
       pcmpeqw   xmm3,xmm4
       pmovmskb  r8d,xmm3
       cmp       r8d,0FFFF
       je        short M07_L16
M07_L14:
       xor       eax,eax
       movaps    xmm6,[rsp+160]
       add       rsp,178
       pop       rbx
       pop       rsi
       ret
M07_L15:
       mov       r8d,1
       jmp       short M07_L13
M07_L16:
       add       r10,8
       cmp       r10,rax
       jbe       near ptr M07_L00
       cmp       r10,r9
       je        near ptr M07_L22
       lea       r10,[r9-8]
       movups    xmm3,[rcx+r10*2]
       movups    xmm4,[rdx+r10*2]
       movaps    xmm5,xmm3
       por       xmm5,xmm4
       pand      xmm5,xmm2
       movaps    [rsp+100],xmm5
       xorps     xmm5,xmm5
       movaps    [rsp+0F0],xmm5
       mov       rax,[rsp+100]
       mov       [rsp+0D8],rax
       mov       rax,[rsp+0F0]
       mov       [rsp+0D0],rax
       xor       eax,eax
       movzx     r8d,word ptr [rsp+0D8]
       cmp       r8w,[rsp+0D0]
       jne       near ptr M07_L02
M07_L17:
       inc       eax
       cmp       eax,4
       jge       short M07_L18
       lea       r8,[rsp+0D8]
       movsxd    r11,eax
       movzx     r8d,word ptr [r8+r11*2]
       lea       rbx,[rsp+0D0]
       cmp       r8w,[rbx+r11*2]
       je        short M07_L17
       jmp       near ptr M07_L02
M07_L18:
       xorps     xmm5,xmm5
       movaps    [rsp+0E0],xmm5
       mov       rax,[rsp+108]
       mov       [rsp+0C8],rax
       mov       rax,[rsp+0E8]
       mov       [rsp+0C0],rax
       xor       eax,eax
       movzx     r8d,word ptr [rsp+0C8]
       cmp       r8w,[rsp+0C0]
       jne       short M07_L20
M07_L19:
       inc       eax
       cmp       eax,4
       jge       short M07_L23
       lea       r8,[rsp+0C8]
       movsxd    r11,eax
       movzx     r8d,word ptr [r8+r11*2]
       lea       rbx,[rsp+0C0]
       cmp       r8w,[rbx+r11*2]
       je        short M07_L19
M07_L20:
       xor       eax,eax
M07_L21:
       test      eax,eax
       je        near ptr M07_L02
       movaps    xmm2,xmm3
       pcmpeqw   xmm2,xmm4
       pcmpeqd   xmm5,xmm5
       pxor      xmm2,xmm5
       ptest     xmm2,xmm2
       jne       near ptr M07_L26
M07_L22:
       mov       eax,1
       movaps    xmm6,[rsp+160]
       add       rsp,178
       pop       rbx
       pop       rsi
       ret
M07_L23:
       mov       eax,1
       jmp       short M07_L21
M07_L24:
       lea       rax,[rsp+88]
       movsxd    r11,r8d
       movzx     eax,word ptr [rax+r11*2]
       lea       r11,[rsp+80]
       movsxd    rbx,r8d
       cmp       ax,[r11+rbx*2]
       je        near ptr M07_L03
       jmp       near ptr M07_L06
M07_L25:
       movzx     r8d,word ptr [rsp+7A]
       cmp       r8w,[rsp+72]
       jne       near ptr M07_L04
       movzx     r8d,word ptr [rsp+7C]
       cmp       r8w,[rsp+74]
       jne       near ptr M07_L04
       movzx     r8d,word ptr [rsp+7E]
       cmp       r8w,[rsp+76]
       jne       near ptr M07_L04
       mov       r8d,1
       jmp       near ptr M07_L05
M07_L26:
       por       xmm3,xmm0
       por       xmm4,xmm0
       movaps    xmm0,xmm3
       psubw     xmm0,xmm1
       pand      xmm0,xmm2
       paddw     xmm0,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       pcmpgtw   xmm0,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       ptest     xmm0,xmm0
       jne       near ptr M07_L14
       pcmpeqw   xmm3,xmm4
       pmovmskb  eax,xmm3
       cmp       eax,0FFFF
       jne       near ptr M07_L14
       jmp       near ptr M07_L22
M07_L27:
       movzx     r8d,word ptr [rsp+2E]
       cmp       r8w,[rsp+26]
       jne       near ptr M07_L07
       mov       r8d,1
       jmp       near ptr M07_L08
; Total bytes of code 1366
```
```assembly
; System.Diagnostics.Process.EnsureState(State)
M08_L00:
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       ebx,edx
       test      bl,20
       jne       short M08_L06
M08_L01:
       test      bl,1
       je        short M08_L02
       cmp       byte ptr [rsi+0E4],0
       je        short M08_L07
M08_L02:
       test      bl,2
       jne       near ptr M08_L09
M08_L03:
       test      bl,8
       jne       near ptr M08_L10
M08_L04:
       test      bl,10
       jne       near ptr M08_L12
M08_L05:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE77A672D0]
       test      eax,eax
       jne       short M08_L01
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77A66D30]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77715A58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L07:
       cmp       byte ptr [rsi+0E5],0
       je        short M08_L08
       mov       rcx,[rsi+18]
       call      qword ptr [7FFE77A66D48]
       mov       [rsi+0D0],eax
       mov       byte ptr [rsi+0E4],1
       jmp       short M08_L02
M08_L08:
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFE779BE9E8]
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77A66D60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77715A58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L09:
       cmp       byte ptr [rsi+0E6],0
       je        near ptr M08_L03
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77A66D78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE772AF210]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L10:
       cmp       qword ptr [rsi+28],0
       jne       near ptr M08_L04
       mov       ecx,ebx
       not       ecx
       and       ecx,5
       je        short M08_L11
       mov       rcx,rsi
       mov       edx,5
       call      qword ptr [7FFE779BE9E8]
M08_L11:
       mov       ecx,[rsi+0D0]
       mov       rdx,[rsi+20]
       call      qword ptr [7FFE77A66D90]
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rsi+28],0
       jne       near ptr M08_L04
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77A66DA8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77715A58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L12:
       mov       rcx,rsi
       call      qword ptr [7FFE77A66DC0]
       test      eax,eax
       jne       short M08_L13
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77A66DD8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77715A58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L13:
       cmp       byte ptr [rsi+0E5],0
       jne       near ptr M08_L05
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE77A66DF0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE77715A58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 507
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.ProcessPath()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,181500020B0
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
       call      qword ptr [7FFE775FF978]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       call      qword ptr [7FFED6D14378]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7FFED6D0ADE8]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFED6D14368]
       jmp       short M01_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFED6D14370]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M01_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFED6CF1810]
       mov       rcx,rax
       call      qword ptr [7FFED6CF8FA0]
       mov       rcx,rax
       call      qword ptr [7FFED6D1A270]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFED6D14380]
       jmp       near ptr M01_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M01_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFED6D14380]
       jmp       near ptr M01_L01
M01_L05:
       mov       rcx,rbx
       call      qword ptr [7FFED6D14390]
       jmp       near ptr M01_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFED6D14378]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M01_L01
; Total bytes of code 269
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.ReferencedAssemblies()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,29C6FC020B8
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
       mov       r8,7FFE779A9F50
       mov       r9,7FFE771FD010
       call      qword ptr [7FFE772B7150]; System.MulticastDelegate.CtorOpened(System.Object, IntPtr, IntPtr)
       mov       rcx,29C6FC020B8
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
       call      qword ptr [7FFED6CEEFD8]; CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rdi
       mov       [rbx+20],rsi
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 37
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.StackTrace()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFE779CE7C0]; System.Environment.get_StackTrace()
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
       call      qword ptr [7FFE779CE7F0]; System.Diagnostics.StackTrace..ctor(Boolean)
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
       call      qword ptr [7FFE77AB4BB8]; System.Diagnostics.StackTrace.ToString(TraceFormat, System.Text.StringBuilder)
       mov       rcx,rsi
       call      qword ptr [7FFE77627868]; System.Text.StringBuilder.ToString()
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 126
```

## .NET 10.0.0 (10.0.25.45207), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.AppBenchmark.WorkingSet()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FFE779AE688]; System.Environment.get_WorkingSet()
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
       mov       rax,7FFE774A6FC0
       mov       [rbp-0A8],rax
       lea       rax,[M01_L00]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFFEE1B4BC0
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFED71EE808],0
       je        short M01_L01
       call      qword ptr [7FFED71DC608]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rdx,[rbp-0B0]
       mov       [rbx+8],rdx
       mov       rcx,rax
       mov       r8d,[rbp-80]
       lea       rdx,[rbp-80]
       mov       rax,7FFE774A8AA8
       mov       [rbp-0A8],rax
       lea       rax,[M01_L02]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFFEE1CD060
       call      rax
M01_L02:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFED71EE808],0
       je        short M01_L03
       call      qword ptr [7FFED71DC608]; CORINFO_HELP_STOP_FOR_GC
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

