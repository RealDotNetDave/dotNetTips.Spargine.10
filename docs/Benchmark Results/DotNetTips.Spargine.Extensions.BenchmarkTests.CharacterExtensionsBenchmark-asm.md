## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CharacterExtensionsBenchmark.ToLowerToLower()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L06
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M00_L06
M00_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M00_L01
       mov       rax,29510C00110
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M00_L01
       mov       rax,29510C000F0
       mov       rsi,[rax]
       test      rsi,rsi
       je        short M00_L07
M00_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rsi],rcx
       jne       near ptr M00_L09
       cmp       qword ptr [rsi+10],0
       je        short M00_L08
M00_L02:
       mov       rdi,[rsi+10]
M00_L03:
       cmp       byte ptr [rdi+31],0
       je        near ptr M00_L10
M00_L04:
       cmp       byte ptr [rdi+31],2
       jne       near ptr M00_L11
       mov       esi,61
M00_L05:
       mov       rax,[rbx+60]
       mov       [rax+48],si
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L06:
       mov       ecx,2
       call      qword ptr [7FFF7892FFA8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L07:
       call      qword ptr [7FFF78525E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rsi,rax
       jmp       short M00_L01
M00_L08:
       mov       rcx,offset MT_System.Globalization.TextInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+30]
       mov       rcx,rdi
       call      qword ptr [7FFF78927228]; System.Globalization.TextInfo..ctor(System.Globalization.CultureData)
       movzx     ecx,byte ptr [rsi+60]
       mov       [rdi+30],cl
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L02
M00_L09:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L10:
       mov       rcx,rdi
       call      qword ptr [7FFF7892D7D0]; System.Globalization.TextInfo.PopulateIsAsciiCasingSameAsInvariant()
       jmp       near ptr M00_L04
M00_L11:
       mov       rcx,rdi
       mov       edx,41
       xor       r8d,r8d
       call      qword ptr [7FFF789B4810]
       mov       esi,eax
       jmp       near ptr M00_L05
; Total bytes of code 306
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFFC977CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFFC97647E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFFC977B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFFC977CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFFC977A3D0]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.TextInfo..ctor(System.Globalization.CultureData)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       lea       rcx,[rbx+10]
       call      qword ptr [7FFFC9763FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFFC977B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFFC9763FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+10]
       mov       rdx,[rcx+8]
       lea       rcx,[rbx+18]
       call      qword ptr [7FFFC9763FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFFC9764480]
       cmp       byte ptr [rax],0
       jne       short M03_L01
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       rcx,[rbx+18]
       call      qword ptr [7FFFC977B400]
       mov       [rbx+28],rax
       jmp       short M03_L00
; Total bytes of code 94
```
```assembly
; System.Globalization.TextInfo.PopulateIsAsciiCasingSameAsInvariant()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+18]
       call      qword ptr [7FFFC977B9D8]; Precode of System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       r9d,1
       cmp       [rcx],ecx
       call      qword ptr [7FFFC977B228]; Precode of System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       mov       ecx,2
       mov       edx,1
       test      eax,eax
       cmovne    ecx,edx
       mov       [rbx+31],cl
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 94
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CharacterExtensionsBenchmark.ToLowerToAsciiLower()
       mov       rax,[rcx+60]
       mov       word ptr [rax+48],61
       ret
; Total bytes of code 11
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CharacterExtensionsBenchmark.ToUpperToUpper()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L07
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L07
M00_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M00_L01
       mov       rax,234E1C00110
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M00_L01
       mov       rax,234E1C000F0
       mov       rsi,[rax]
       test      rsi,rsi
       je        short M00_L08
M00_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rsi],rcx
       jne       near ptr M00_L10
       cmp       qword ptr [rsi+10],0
       je        short M00_L09
M00_L02:
       mov       rdi,[rsi+10]
M00_L03:
       cmp       byte ptr [rdi+31],0
       je        near ptr M00_L11
M00_L04:
       cmp       byte ptr [rdi+31],2
       je        short M00_L05
       mov       rcx,rdi
       mov       edx,61
       mov       r8d,1
       call      qword ptr [7FFF789A4918]
       jmp       short M00_L06
M00_L05:
       mov       eax,41
M00_L06:
       mov       rcx,[rbx+60]
       mov       [rcx+48],ax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L07:
       mov       ecx,2
       call      qword ptr [7FFF7891FF90]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L08:
       call      qword ptr [7FFF78515E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rsi,rax
       jmp       short M00_L01
M00_L09:
       mov       rcx,offset MT_System.Globalization.TextInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+30]
       mov       rcx,rdi
       call      qword ptr [7FFF78917258]; System.Globalization.TextInfo..ctor(System.Globalization.CultureData)
       movzx     ecx,byte ptr [rsi+60]
       mov       [rdi+30],cl
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L10:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,rdi
       call      qword ptr [7FFF7891D728]; System.Globalization.TextInfo.PopulateIsAsciiCasingSameAsInvariant()
       jmp       near ptr M00_L04
; Total bytes of code 307
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFFC977CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFFC97647E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFFC977B9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFFC977CBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFFC977A3D0]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.TextInfo..ctor(System.Globalization.CultureData)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       lea       rcx,[rbx+10]
       call      qword ptr [7FFFC9763FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFFC977B510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FFFC9763FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+10]
       mov       rdx,[rcx+8]
       lea       rcx,[rbx+18]
       call      qword ptr [7FFFC9763FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFFC9764480]
       cmp       byte ptr [rax],0
       jne       short M03_L01
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       rcx,[rbx+18]
       call      qword ptr [7FFFC977B400]
       mov       [rbx+28],rax
       jmp       short M03_L00
; Total bytes of code 94
```
```assembly
; System.Globalization.TextInfo.PopulateIsAsciiCasingSameAsInvariant()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+18]
       call      qword ptr [7FFFC977B9D8]; Precode of System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       r9d,1
       cmp       [rcx],ecx
       call      qword ptr [7FFFC977B228]; Precode of System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       mov       ecx,2
       mov       edx,1
       test      eax,eax
       cmovne    ecx,edx
       mov       [rbx+31],cl
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 94
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CharacterExtensionsBenchmark.ToUpperToAsciiUpper()
       mov       rax,[rcx+60]
       mov       word ptr [rax+48],41
       ret
; Total bytes of code 11
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CharacterExtensionsBenchmark.IsAsciiControl()
       mov       rax,[rcx+60]
       mov       byte ptr [rax+4C],1
       ret
; Total bytes of code 9
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CharacterExtensionsBenchmark.IsAsciiPunctuation()
       mov       rax,[rcx+60]
       mov       byte ptr [rax+4C],1
       ret
; Total bytes of code 9
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CharacterExtensionsBenchmark.IsAsciiUpper()
       mov       rax,[rcx+60]
       mov       byte ptr [rax+4C],1
       ret
; Total bytes of code 9
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CharacterExtensionsBenchmark.IsAsciiWhitespace()
       mov       rax,[rcx+60]
       mov       byte ptr [rax+4C],1
       ret
; Total bytes of code 9
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CharacterExtensionsBenchmark.IsHexDigit()
       mov       rax,[rcx+60]
       mov       byte ptr [rax+4C],1
       ret
; Total bytes of code 9
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CharacterExtensionsBenchmark.IsNewLine()
       mov       rax,[rcx+60]
       mov       byte ptr [rax+4C],1
       ret
; Total bytes of code 9
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CharacterExtensionsBenchmark.IsUnicodeDigit()
       mov       rax,[rcx+60]
       mov       byte ptr [rax+4C],1
       ret
; Total bytes of code 9
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.CharacterExtensionsBenchmark.GetDigitValue()
       mov       rax,[rcx+60]
       mov       dword ptr [rax+38],0FFFFFFFF
       ret
; Total bytes of code 12
```

