## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DateTimeExtensionsBenchmark.ClampAboveMaximum()
       push      rsi
       push      rbx
       sub       rsp,28
       cmp       [rcx],cl
       lea       rax,[rcx+1A8]
       lea       rdx,[rcx+1A0]
       lea       r8,[rcx+198]
       mov       rdx,[rdx]
       mov       r10,rdx
       mov       r8,[r8]
       mov       r9,r8
       mov       r11,3FFFFFFFFFFFFFFF
       and       r10,r11
       and       r9,r11
       cmp       r10,r9
       jg        short M00_L01
       mov       rax,[rax]
       mov       r11,rax
       mov       rbx,3FFFFFFFFFFFFFFF
       and       r11,rbx
       cmp       r11,r10
       jl        short M00_L02
       cmp       r11,r9
       cmovle    r8,rax
M00_L00:
       mov       [rsp+20],r8
       mov       rcx,[rcx+88]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FF8F432E508]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTime, System.Private.CoreLib]](System.DateTime ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,13D
       mov       rdx,7FF8F40FA6B8
       call      qword ptr [7FF8F3F17798]
       mov       rsi,rax
       call      qword ptr [7FF8F43AD530]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8F3F1E670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L02:
       mov       r8,rdx
       jmp       short M00_L00
; Total bytes of code 203
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTime, System.Private.CoreLib]](System.DateTime ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DateTimeExtensionsBenchmark.ClampBelowMinimum()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rsi,[rbx+1B0]
       lea       rcx,[rbx+1A0]
       lea       rdi,[rbx+198]
       mov       rax,[rcx]
       mov       rcx,rax
       mov       rdx,[rdi]
       mov       r8,3FFFFFFFFFFFFFFF
       and       rcx,r8
       and       rdx,r8
       cmp       rcx,rdx
       jg        short M00_L01
       mov       rdx,[rsi]
       mov       r8,3FFFFFFFFFFFFFFF
       and       rdx,r8
       cmp       rdx,rcx
       jge       short M00_L02
M00_L00:
       mov       [rsp+28],rax
       mov       rcx,[rbx+88]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FF8F4316838]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTime, System.Private.CoreLib]](System.DateTime ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,13D
       mov       rdx,7FF8F40DE2B0
       call      qword ptr [7FF8F3F17798]
       mov       rsi,rax
       call      qword ptr [7FF8F431EA30]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8F3F1D9C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L02:
       mov       rcx,[rsi]
       mov       rdx,[rdi]
       call      qword ptr [7FF8F43167A8]; System.DateTime.op_GreaterThan(System.DateTime, System.DateTime)
       test      eax,eax
       jne       short M00_L03
       mov       rax,[rsi]
       jmp       short M00_L00
M00_L03:
       mov       rax,[rdi]
       jmp       near ptr M00_L00
; Total bytes of code 219
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTime, System.Private.CoreLib]](System.DateTime ByRef)
       ret
; Total bytes of code 1
```
```assembly
; System.DateTime.op_GreaterThan(System.DateTime, System.DateTime)
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       cmp       rax,rcx
       setg      al
       movzx     eax,al
       ret
; Total bytes of code 36
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DateTimeExtensionsBenchmark.ClampWithinRange()
       push      rsi
       push      rbx
       sub       rsp,28
       cmp       [rcx],cl
       lea       rax,[rcx+1B8]
       lea       rdx,[rcx+1A0]
       lea       r8,[rcx+198]
       mov       rdx,[rdx]
       mov       r10,rdx
       mov       r8,[r8]
       mov       r9,r8
       mov       r11,3FFFFFFFFFFFFFFF
       and       r10,r11
       and       r9,r11
       cmp       r10,r9
       jg        short M00_L01
       mov       rax,[rax]
       mov       r11,rax
       mov       rbx,3FFFFFFFFFFFFFFF
       and       r11,rbx
       cmp       r11,r10
       jl        short M00_L02
       cmp       r11,r9
       cmovle    r8,rax
M00_L00:
       mov       [rsp+20],r8
       mov       rcx,[rcx+88]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FF8F432E418]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTime, System.Private.CoreLib]](System.DateTime ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,13D
       mov       rdx,7FF8F40DE2B0
       call      qword ptr [7FF8F3F17798]
       mov       rsi,rax
       call      qword ptr [7FF8F43A5EA8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8F3F1D9C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L02:
       mov       r8,rdx
       jmp       short M00_L00
; Total bytes of code 203
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTime, System.Private.CoreLib]](System.DateTime ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DateTimeExtensionsBenchmark.EndOfDayDateTime()
       sub       rsp,28
       lea       rdx,[rcx+1D8]
       mov       rax,[rdx]
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       r8,28B8FFC778816079
       mulx      rdx,rdx,r8
       shr       rdx,25
       mov       r8,0C92A69C000
       imul      rdx,r8
       mov       r8,0C000000000000000
       and       rax,r8
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       r8,0C92A69C000
       add       rdx,r8
       mov       r8,2BCA2875F4373FFF
       cmp       rdx,r8
       ja        short M00_L00
       mov       r8,0C000000000000000
       and       rax,r8
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       dec       rdx
       mov       r8,2BCA2875F4373FFF
       cmp       rdx,r8
       ja        short M00_L00
       mov       r8,0C000000000000000
       and       rax,r8
       or        rax,rdx
       mov       [rsp+20],rax
       mov       rcx,[rcx+88]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FF8F433DB48]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTime, System.Private.CoreLib]](System.DateTime ByRef)
       nop
       add       rsp,28
       ret
M00_L00:
       xor       ecx,ecx
       call      qword ptr [7FF8F43D4DF8]
       int       3
; Total bytes of code 220
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTime, System.Private.CoreLib]](System.DateTime ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DateTimeExtensionsBenchmark.EndOfDayDateTimeOffset()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       lea       rdx,[rbx+1C0]
       mov       rsi,[rdx+8]
       movsxd    rdx,dword ptr [rdx]
       imul      rdi,rdx,23C34600
       add       rsi,rdi
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rsi
       mov       rcx,28B8FFC778816079
       mulx      rbp,rbp,rcx
       shr       rbp,25
       mov       r14,0C92A69C000
       imul      rbp,r14
       mov       r14,0C000000000000000
       and       rsi,r14
       or        rsi,rbp
       mov       rbp,3FFFFFFFFFFFFFFF
       and       rbp,rsi
       mov       r14,0C92A69C000
       add       rbp,r14
       mov       rcx,2BCA2875F4373FFF
       cmp       rbp,rcx
       ja        near ptr M00_L03
       mov       r14,0C000000000000000
       and       rsi,r14
       or        rsi,rbp
       mov       rbp,3FFFFFFFFFFFFFFF
       and       rbp,rsi
       dec       rbp
       mov       rcx,2BCA2875F4373FFF
       cmp       rbp,rcx
       ja        near ptr M00_L03
       mov       r14,0C000000000000000
       and       rsi,r14
       or        rsi,rbp
       mov       rcx,rsi
       shr       rcx,3E
       mov       eax,ecx
       shr       eax,1
       andn      ecx,eax,ecx
       cmp       ecx,2
       je        near ptr M00_L04
       cmp       ecx,1
       je        near ptr M00_L05
M00_L00:
       mov       rdx,1CA213D840BAF7D5
       mov       rax,rdx
       imul      rdi
       mov       rcx,rdx
       shr       rcx,3F
       sar       rdx,1A
       add       rcx,rdx
       imul      rax,rcx,23C34600
       cmp       rdi,rax
       jne       short M00_L02
       cmp       rcx,0FFFFFFFFFFFFFCB8
       jl        short M00_L01
       cmp       rcx,348
       jg        short M00_L01
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rsi
       sub       rax,rdi
       mov       rdx,2BCA2875F4373FFF
       cmp       rax,rdx
       ja        near ptr M00_L06
       mov       [rsp+20],ecx
       mov       [rsp+28],rax
       mov       rcx,[rbx+88]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FF8F4316850]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTimeOffset, System.Private.CoreLib]](System.DateTimeOffset ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L01:
       call      qword ptr [7FF8F431EAF0]
       int       3
M00_L02:
       call      qword ptr [7FF8F431EAD8]
       int       3
M00_L03:
       xor       ecx,ecx
       call      qword ptr [7FF8F431EA48]
       int       3
M00_L04:
       mov       rcx,rsi
       mov       edx,2
       call      qword ptr [7FF8F431EA78]
       cmp       rdi,rax
       je        near ptr M00_L00
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8F431EAA8]
       mov       rsi,rax
       mov       ecx,1149
       mov       rdx,7FF8F3C34000
       call      qword ptr [7FF8F3F17798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8F4076208]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       test      rdi,rdi
       je        near ptr M00_L00
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8F431EAC0]
       mov       rdi,rax
       mov       ecx,1149
       mov       rdx,7FF8F3C34000
       call      qword ptr [7FF8F3F17798]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF8F4076208]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       call      qword ptr [7FF8F431EB08]
       int       3
; Total bytes of code 587
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTimeOffset, System.Private.CoreLib]](System.DateTimeOffset ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DateTimeExtensionsBenchmark.StartOfDayDateTime()
       sub       rsp,28
       lea       rdx,[rcx+1D8]
       mov       rax,[rdx]
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       r8,28B8FFC778816079
       mulx      rdx,rdx,r8
       shr       rdx,25
       mov       r8,0C92A69C000
       imul      rdx,r8
       mov       r8,0C000000000000000
       and       rax,r8
       or        rax,rdx
       mov       [rsp+20],rax
       mov       rcx,[rcx+88]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FF8F4316808]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTime, System.Private.CoreLib]](System.DateTime ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTime, System.Private.CoreLib]](System.DateTime ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DateTimeExtensionsBenchmark.StartOfDayDateTimeOffset()
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rdx,[rcx+1C0]
       mov       rax,[rdx+8]
       movsxd    rdx,dword ptr [rdx]
       imul      r8,rdx,23C34600
       add       rax,r8
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rax,28B8FFC778816079
       mulx      rax,rax,rax
       shr       rax,23
       or        eax,3
       mov       edx,eax
       mov       r10d,edx
       imul      r10,396B06BD
       shr       r10,2F
       imul      r9d,r10d,23AB1
       sub       edx,r9d
       or        edx,3
       imul      rdx,166DB073
       shr       rdx,27
       imul      r10d,64
       lea       r10d,[rdx+r10+1]
       add       eax,4C8
       mov       edx,eax
       imul      rdx,396B06BD
       shr       rdx,2F
       imul      edx,23AB1
       sub       eax,edx
       or        eax,3
       imul      eax,2CDB61
       imul      rax,5B4FFFCB
       shr       rax,36
       movzx     eax,ax
       imul      edx,eax,85D
       add       edx,30519
       mov       r9d,edx
       sar       r9d,10
       movzx     r9d,r9w
       mov       r11d,0C
       xor       ebx,ebx
       cmp       eax,132
       cmovl     r11d,ebx
       sub       r9d,r11d
       movzx     eax,dx
       imul      r11,rax,3D38514F
       shr       r11,29
       inc       r11d
       mov       rdx,1CA213D840BAF7D5
       mov       rax,rdx
       imul      r8
       mov       rax,rdx
       shr       rax,3F
       sar       rdx,1A
       add       rax,rdx
       imul      rdx,rax,23C34600
       cmp       r8,rdx
       jne       near ptr M00_L04
       cmp       rax,0FFFFFFFFFFFFFCB8
       jl        near ptr M00_L05
       cmp       rax,348
       jg        near ptr M00_L05
       mov       edx,r10d
       sub       edx,1
       cmp       edx,270E
       jbe       short M00_L01
M00_L00:
       call      qword ptr [7FF8F43B5008]
       int       3
M00_L01:
       mov       edx,r9d
       sub       edx,1
       cmp       edx,0B
       ja        short M00_L00
       test      r11d,r11d
       jle       short M00_L00
       test      r10b,3
       je        near ptr M00_L06
M00_L02:
       mov       rdx,7FF951A001A8
M00_L03:
       mov       ebx,r9d
       mov       ebx,[rdx+rbx*4]
       lea       esi,[r9-1]
       cmp       esi,0D
       jae       near ptr M00_L09
       dec       r9d
       mov       edx,[rdx+r9*4]
       sub       ebx,edx
       cmp       ebx,r11d
       jb        short M00_L00
       dec       r10d
       mov       r9d,r10d
       imul      r9,51EB851F
       shr       r9,25
       imul      r10d,5B5
       shr       r10d,2
       sub       r10d,r9d
       shr       r9d,2
       add       r10d,r9d
       add       edx,r10d
       lea       edx,[rdx+r11-1]
       mov       r10,0C92A69C000
       imul      rdx,r10
       mov       r10,3FFFFFFFFFFFFFFF
       and       rdx,r10
       sub       rdx,r8
       mov       r8,2BCA2875F4373FFF
       cmp       rdx,r8
       ja        short M00_L08
       mov       [rsp+28],eax
       mov       [rsp+30],rdx
       mov       rcx,[rcx+88]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FF8F433E4F0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTimeOffset, System.Private.CoreLib]](System.DateTimeOffset ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L04:
       call      qword ptr [7FF8F43B5068]
       int       3
M00_L05:
       call      qword ptr [7FF8F43B5080]
       int       3
M00_L06:
       test      r10b,0F
       je        short M00_L07
       mov       edx,r10d
       imul      rdx,51EB851F
       shr       rdx,23
       imul      edx,19
       mov       ebx,r10d
       sub       ebx,edx
       je        near ptr M00_L02
M00_L07:
       mov       rdx,7FF951A0A648
       jmp       near ptr M00_L03
M00_L08:
       call      qword ptr [7FF8F43B5038]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 587
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTimeOffset, System.Private.CoreLib]](System.DateTimeOffset ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DateTimeExtensionsBenchmark.TryParseInvariantInvalidInput()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       mov       rbx,rcx
       mov       rsi,2845DC80AC4
       mov       rcx,243C8C00100
       mov       rdi,[rcx]
       mov       rdx,[rdi+20]
       test      rdx,rdx
       jne       near ptr M00_L06
       cmp       qword ptr [rdi+20],0
       jne       near ptr M00_L01
       mov       rbp,[rdi+30]
       cmp       qword ptr [rdi+28],0
       jne       short M00_L00
       mov       rcx,[rdi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF8F433DF50]; System.Globalization.CultureData.get_DefaultCalendar()
       lock or   dword ptr [rsp],0
       movzx     ecx,byte ptr [rdi+60]
       mov       [rax+10],cl
       lea       rcx,[rdi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       r14,[rdi+28]
       mov       r15,r14
       mov       rcx,offset MT_System.Globalization.DateTimeFormatInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       qword ptr [r13+178],0FFFFFFFFFFFFFFFF
       mov       dword ptr [r13+180],0FFFFFFFF
       lea       rcx,[r13+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+80]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8d,eax
       mov       rdx,rbp
       mov       rcx,r13
       call      qword ptr [7FF8F433E4F0]; System.Globalization.DateTimeFormatInfo.InitializeOverridableProperties(System.Globalization.CultureData, System.Globalization.CalendarId)
       movzx     ecx,byte ptr [rdi+60]
       mov       [r13+184],cl
       lea       rcx,[rdi+20]
       test      rcx,rcx
       je        near ptr M00_L07
       mov       rdx,r13
       xor       r8d,r8d
       call      00007FF953936040
M00_L01:
       mov       rdx,[rdi+20]
       test      rdx,rdx
       jne       short M00_L05
M00_L02:
       xor       edx,edx
M00_L03:
       test      rdx,rdx
       jne       short M00_L04
       call      qword ptr [7FF8F43B6130]
       mov       rdx,rax
M00_L04:
       jmp       short M00_L06
M00_L05:
       mov       rax,offset MT_System.Globalization.DateTimeFormatInfo
       cmp       [rdx],rax
       jne       short M00_L02
       jmp       short M00_L03
M00_L06:
       mov       [rsp+20],rsi
       mov       dword ptr [rsp+28],0A
       lea       rcx,[rsp+20]
       lea       r9,[rsp+38]
       xor       r8d,r8d
       call      qword ptr [7FF8F433E658]; System.DateTimeParse.TryParse(System.ReadOnlySpan`1<Char>, System.Globalization.DateTimeFormatInfo, System.Globalization.DateTimeStyles, System.DateTime ByRef)
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       mov       rcx,[rbx+88]
       cmp       [rcx],cl
       lea       rcx,[rsp+30]
       call      qword ptr [7FF8F433F030]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTime, System.Private.CoreLib]](System.DateTime ByRef)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L07:
       call      qword ptr [7FF8F43B5E48]
       int       3
; Total bytes of code 397
```
```assembly
; System.Globalization.CultureData.get_DefaultCalendar()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FF952669488]
       cmp       byte ptr [rax],0
       jne       short M01_L01
       mov       rcx,rbx
       mov       edx,1009
       call      qword ptr [7FF952680748]; Precode of System.Globalization.CultureData.GetLocaleInfoCore(LocaleNumberData)
       movzx     ecx,ax
       test      ecx,ecx
       jne       short M01_L00
       mov       rcx,rbx
       call      qword ptr [7FF9526806B0]
       cmp       dword ptr [rax+8],0
       jbe       short M01_L02
       movzx     ecx,word ptr [rax+10]
M01_L00:
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
M01_L01:
       call      qword ptr [7FF9526739C0]
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF952680DF8]
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M01_L02:
       call      qword ptr [7FF952668FD8]
       int       3
; Total bytes of code 113
```
```assembly
; System.Globalization.DateTimeFormatInfo.InitializeOverridableProperties(System.Globalization.CultureData, System.Globalization.CalendarId)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       cmp       dword ptr [rbx+178],0FFFFFFFF
       jne       short M02_L00
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF9526806A8]
       mov       [rbx+178],eax
M02_L00:
       cmp       dword ptr [rbx+17C],0FFFFFFFF
       jne       short M02_L02
       cmp       dword ptr [rsi+194],0FFFFFFFF
       jne       short M02_L01
       mov       rcx,rsi
       mov       edx,100D
       call      qword ptr [7FF952680750]; Precode of System.Globalization.CultureData.GetLocaleInfoCoreUserOverride(LocaleNumberData)
       mov       [rsi+194],eax
M02_L01:
       mov       ecx,[rsi+194]
       mov       [rbx+17C],ecx
M02_L02:
       cmp       qword ptr [rbx+20],0
       jne       short M02_L03
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF952680670]
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      qword ptr [7FF952668FE8]; CORINFO_HELP_ASSIGN_REF
M02_L03:
       cmp       qword ptr [rbx+28],0
       jne       short M02_L04
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF952680678]
       lea       rcx,[rbx+28]
       mov       rdx,rax
       call      qword ptr [7FF952668FE8]; CORINFO_HELP_ASSIGN_REF
M02_L04:
       cmp       qword ptr [rbx+48],0
       jne       short M02_L05
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF952680700]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FF952668FE8]; CORINFO_HELP_ASSIGN_REF
M02_L05:
       cmp       qword ptr [rbx+30],0
       jne       short M02_L06
       movzx     ebp,di
       mov       edx,ebp
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF952680708]
       lea       rcx,[rbx+30]
       mov       rdx,rax
       call      qword ptr [7FF952668FE8]; CORINFO_HELP_ASSIGN_REF
M02_L06:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF952680680]
       lea       rcx,[rbx+118]
       mov       rdx,rax
       call      qword ptr [7FF952668FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF952680688]
       lea       rcx,[rbx+110]
       mov       rdx,rax
       call      qword ptr [7FF952668FE8]; CORINFO_HELP_ASSIGN_REF
       cmp       [rsi],sil
       movzx     ebp,di
       mov       edx,ebp
       mov       rcx,rsi
       call      qword ptr [7FF9526806B8]; Precode of System.Globalization.CultureData.GetCalendar(System.Globalization.CalendarId)
       mov       rdx,[rax+20]
       lea       rcx,[rbx+108]
       call      qword ptr [7FF952668FE8]; CORINFO_HELP_ASSIGN_REF
       mov       edx,ebp
       mov       rcx,rsi
       call      qword ptr [7FF9526806B8]; Precode of System.Globalization.CultureData.GetCalendar(System.Globalization.CalendarId)
       mov       rdx,[rax+10]
       lea       rcx,[rbx+100]
       call      qword ptr [7FF952668FE8]; CORINFO_HELP_ASSIGN_REF
       mov       edx,ebp
       mov       rcx,rsi
       call      qword ptr [7FF9526806B8]; Precode of System.Globalization.CultureData.GetCalendar(System.Globalization.CalendarId)
       mov       rdx,[rax+18]
       lea       rcx,[rbx+0F8]
       call      qword ptr [7FF952668FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 378
```
```assembly
; System.DateTimeParse.TryParse(System.ReadOnlySpan`1<Char>, System.Globalization.DateTimeFormatInfo, System.Globalization.DateTimeStyles, System.DateTime ByRef)
       push      rbx
       sub       rsp,80
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       mov       rbx,r9
       vmovdqu   xmm0,xmmword ptr [rcx]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       mov       dword ptr [rsp+38],0FFFFFFFF
       mov       dword ptr [rsp+3C],0FFFFFFFF
       mov       dword ptr [rsp+40],0FFFFFFFF
       mov       r9,0BFF0000000000000
       mov       [rsp+30],r9
       mov       dword ptr [rsp+50],0FFFFFFFF
       lea       r9,[rsp+28]
       call      qword ptr [7FF8F433E670]; System.DateTimeParse.TryParse(System.ReadOnlySpan`1<Char>, System.Globalization.DateTimeFormatInfo, System.Globalization.DateTimeStyles, System.DateTimeResult ByRef)
       test      eax,eax
       jne       short M03_L00
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,80
       pop       rbx
       ret
M03_L00:
       mov       rax,[rsp+68]
       mov       [rbx],rax
       mov       eax,1
       add       rsp,80
       pop       rbx
       ret
; Total bytes of code 148
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTime, System.Private.CoreLib]](System.DateTime ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DateTimeExtensionsBenchmark.TryParseInvariantValidInput()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       mov       rbx,rcx
       mov       rsi,1B242220AC4
       mov       rcx,171AD400100
       mov       rdi,[rcx]
       mov       rdx,[rdi+20]
       test      rdx,rdx
       jne       near ptr M00_L06
       cmp       qword ptr [rdi+20],0
       jne       near ptr M00_L01
       mov       rbp,[rdi+30]
       cmp       qword ptr [rdi+28],0
       jne       short M00_L00
       mov       rcx,[rdi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF8F4346880]; System.Globalization.CultureData.get_DefaultCalendar()
       lock or   dword ptr [rsp],0
       movzx     ecx,byte ptr [rdi+60]
       mov       [rax+10],cl
       lea       rcx,[rdi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       r14,[rdi+28]
       mov       r15,r14
       mov       rcx,offset MT_System.Globalization.DateTimeFormatInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       qword ptr [r13+178],0FFFFFFFFFFFFFFFF
       mov       dword ptr [r13+180],0FFFFFFFF
       lea       rcx,[r13+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+80]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8d,eax
       mov       rdx,rbp
       mov       rcx,r13
       call      qword ptr [7FF8F4346E20]; System.Globalization.DateTimeFormatInfo.InitializeOverridableProperties(System.Globalization.CultureData, System.Globalization.CalendarId)
       movzx     ecx,byte ptr [rdi+60]
       mov       [r13+184],cl
       lea       rcx,[rdi+20]
       test      rcx,rcx
       je        near ptr M00_L07
       mov       rdx,r13
       xor       r8d,r8d
       call      00007FF953936040
M00_L01:
       mov       rdx,[rdi+20]
       test      rdx,rdx
       jne       short M00_L05
M00_L02:
       xor       edx,edx
M00_L03:
       test      rdx,rdx
       jne       short M00_L04
       call      qword ptr [7FF8F43B4210]
       mov       rdx,rax
M00_L04:
       jmp       short M00_L06
M00_L05:
       mov       rax,offset MT_System.Globalization.DateTimeFormatInfo
       cmp       [rdx],rax
       jne       short M00_L02
       jmp       short M00_L03
M00_L06:
       mov       [rsp+20],rsi
       mov       dword ptr [rsp+28],13
       lea       rcx,[rsp+20]
       lea       r9,[rsp+38]
       xor       r8d,r8d
       call      qword ptr [7FF8F4346F88]; System.DateTimeParse.TryParse(System.ReadOnlySpan`1<Char>, System.Globalization.DateTimeFormatInfo, System.Globalization.DateTimeStyles, System.DateTime ByRef)
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       mov       rcx,[rsp+38]
       mov       [rsp+30],rcx
       mov       rcx,[rbx+88]
       cmp       [rcx],cl
       lea       rcx,[rsp+30]
       call      qword ptr [7FF8F4347B70]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTime, System.Private.CoreLib]](System.DateTime ByRef)
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L07:
       call      qword ptr [7FF8F43B4BB8]
       int       3
; Total bytes of code 397
```
```assembly
; System.Globalization.CultureData.get_DefaultCalendar()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FF952669488]
       cmp       byte ptr [rax],0
       jne       short M01_L01
       mov       rcx,rbx
       mov       edx,1009
       call      qword ptr [7FF952680748]; Precode of System.Globalization.CultureData.GetLocaleInfoCore(LocaleNumberData)
       movzx     ecx,ax
       test      ecx,ecx
       jne       short M01_L00
       mov       rcx,rbx
       call      qword ptr [7FF9526806B0]
       cmp       dword ptr [rax+8],0
       jbe       short M01_L02
       movzx     ecx,word ptr [rax+10]
M01_L00:
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
M01_L01:
       call      qword ptr [7FF9526739C0]
       mov       rbx,rax
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF952680DF8]; Precode of System.Globalization.GregorianCalendar..ctor(System.Globalization.GregorianCalendarTypes)
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M01_L02:
       call      qword ptr [7FF952668FD8]
       int       3
; Total bytes of code 113
```
```assembly
; System.Globalization.DateTimeFormatInfo.InitializeOverridableProperties(System.Globalization.CultureData, System.Globalization.CalendarId)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       cmp       dword ptr [rbx+178],0FFFFFFFF
       jne       short M02_L00
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF9526806A8]
       mov       [rbx+178],eax
M02_L00:
       cmp       dword ptr [rbx+17C],0FFFFFFFF
       jne       short M02_L02
       cmp       dword ptr [rsi+194],0FFFFFFFF
       jne       short M02_L01
       mov       rcx,rsi
       mov       edx,100D
       call      qword ptr [7FF952680750]; Precode of System.Globalization.CultureData.GetLocaleInfoCoreUserOverride(LocaleNumberData)
       mov       [rsi+194],eax
M02_L01:
       mov       ecx,[rsi+194]
       mov       [rbx+17C],ecx
M02_L02:
       cmp       qword ptr [rbx+20],0
       jne       short M02_L03
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF952680670]
       lea       rcx,[rbx+20]
       mov       rdx,rax
       call      qword ptr [7FF952668FE8]; CORINFO_HELP_ASSIGN_REF
M02_L03:
       cmp       qword ptr [rbx+28],0
       jne       short M02_L04
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF952680678]
       lea       rcx,[rbx+28]
       mov       rdx,rax
       call      qword ptr [7FF952668FE8]; CORINFO_HELP_ASSIGN_REF
M02_L04:
       cmp       qword ptr [rbx+48],0
       jne       short M02_L05
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF952680700]
       lea       rcx,[rbx+48]
       mov       rdx,rax
       call      qword ptr [7FF952668FE8]; CORINFO_HELP_ASSIGN_REF
M02_L05:
       cmp       qword ptr [rbx+30],0
       jne       short M02_L06
       movzx     ebp,di
       mov       edx,ebp
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF952680708]
       lea       rcx,[rbx+30]
       mov       rdx,rax
       call      qword ptr [7FF952668FE8]; CORINFO_HELP_ASSIGN_REF
M02_L06:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF952680680]
       lea       rcx,[rbx+118]
       mov       rdx,rax
       call      qword ptr [7FF952668FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF952680688]
       lea       rcx,[rbx+110]
       mov       rdx,rax
       call      qword ptr [7FF952668FE8]; CORINFO_HELP_ASSIGN_REF
       cmp       [rsi],sil
       movzx     ebp,di
       mov       edx,ebp
       mov       rcx,rsi
       call      qword ptr [7FF9526806B8]; Precode of System.Globalization.CultureData.GetCalendar(System.Globalization.CalendarId)
       mov       rdx,[rax+20]
       lea       rcx,[rbx+108]
       call      qword ptr [7FF952668FE8]; CORINFO_HELP_ASSIGN_REF
       mov       edx,ebp
       mov       rcx,rsi
       call      qword ptr [7FF9526806B8]; Precode of System.Globalization.CultureData.GetCalendar(System.Globalization.CalendarId)
       mov       rdx,[rax+10]
       lea       rcx,[rbx+100]
       call      qword ptr [7FF952668FE8]; CORINFO_HELP_ASSIGN_REF
       mov       edx,ebp
       mov       rcx,rsi
       call      qword ptr [7FF9526806B8]; Precode of System.Globalization.CultureData.GetCalendar(System.Globalization.CalendarId)
       mov       rdx,[rax+18]
       lea       rcx,[rbx+0F8]
       call      qword ptr [7FF952668FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 378
```
```assembly
; System.DateTimeParse.TryParse(System.ReadOnlySpan`1<Char>, System.Globalization.DateTimeFormatInfo, System.Globalization.DateTimeStyles, System.DateTime ByRef)
       push      rbx
       sub       rsp,80
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       mov       rbx,r9
       vmovdqu   xmm0,xmmword ptr [rcx]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       mov       dword ptr [rsp+38],0FFFFFFFF
       mov       dword ptr [rsp+3C],0FFFFFFFF
       mov       dword ptr [rsp+40],0FFFFFFFF
       mov       r9,0BFF0000000000000
       mov       [rsp+30],r9
       mov       dword ptr [rsp+50],0FFFFFFFF
       lea       r9,[rsp+28]
       call      qword ptr [7FF8F4346FA0]; System.DateTimeParse.TryParse(System.ReadOnlySpan`1<Char>, System.Globalization.DateTimeFormatInfo, System.Globalization.DateTimeStyles, System.DateTimeResult ByRef)
       test      eax,eax
       je        short M03_L00
       mov       rax,[rsp+68]
       mov       [rbx],rax
       mov       eax,1
       add       rsp,80
       pop       rbx
       ret
M03_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,80
       pop       rbx
       ret
; Total bytes of code 148
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTime, System.Private.CoreLib]](System.DateTime ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DateTimeExtensionsBenchmark.RoundToNearestMultiple()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+1D0]
       mov       rdx,2E502487120
       call      qword ptr [7FF8F431DED8]; DotNetTips.Spargine.Extensions.DateTimeExtensions.RoundToNearestMultiple(System.DateTime ByRef, System.TimeSpan ByRef)
       mov       [rsp+28],rax
       mov       rcx,[rbx+88]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FF8F431DFF8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTime, System.Private.CoreLib]](System.DateTime ByRef)
       nop
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Extensions.DateTimeExtensions.RoundToNearestMultiple(System.DateTime ByRef, System.TimeSpan ByRef)
; 		if (multiple <= TimeSpan.Zero)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			ExceptionThrower.ThrowArgumentOutOfRangeException(nameof(multiple));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var ticks = value.Ticks;
; 		^^^^^^^^^^^^^^^^^^^^^^^^
; 		return new DateTime(roundedTicks, value.Kind);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rax,[rdx]
       mov       rdx,rax
       test      rdx,rdx
       jle       near ptr M01_L00
       mov       rbx,[rcx]
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rbx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rcx
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2sd xmm1,xmm1,rax
       vdivsd    xmm0,xmm0,xmm1
       vmovddup  xmm2,qword ptr [7FF8F3DA4590]
       vmovaps   xmm3,xmm0
       vandpd    xmm3,xmm3,xmm2
       vandnpd   xmm2,xmm2,[7FF8F3DA45A0]
       vorpd     xmm2,xmm2,xmm3
       vaddsd    xmm0,xmm2,xmm0
       vroundsd  xmm0,xmm0,xmm0,0B
       vmulsd    xmm0,xmm0,xmm1
       call      qword ptr [7FF8F3CF5950]; System.Math.ConvertToInt64Checked(Double)
       shr       rbx,3E
       mov       ecx,ebx
       shr       ecx,1
       andn      ecx,ecx,ebx
       mov       rdx,2BCA2875F4373FFF
       cmp       rax,rdx
       ja        short M01_L01
       cmp       ecx,2
       ja        short M01_L02
       shl       rcx,3E
       or        rax,rcx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,14D
       mov       rdx,7FF8F40DE2B0
       call      qword ptr [7FF8F3F17798]
       mov       rsi,rax
       call      qword ptr [7FF8F43A6088]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8F3F1D9C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L01:
       call      qword ptr [7FF8F43A5158]
       int       3
M01_L02:
       call      qword ptr [7FF8F43A5170]
       int       3
; Total bytes of code 240
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTime, System.Private.CoreLib]](System.DateTime ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DateTimeExtensionsBenchmark.ToDateOnly()
       sub       rsp,28
       mov       rdx,[rcx+1D8]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rax,28B8FFC778816079
       mulx      rax,rax,rax
       shr       rax,25
       mov       [rsp+20],eax
       mov       rcx,[rcx+88]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FF8F432DC80]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateOnly, System.Private.CoreLib]](System.DateOnly ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 73
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateOnly, System.Private.CoreLib]](System.DateOnly ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DateTimeExtensionsBenchmark.ToTimeOnly()
       sub       rsp,28
       mov       rax,[rcx+1D8]
       mov       r8,3FFFFFFFFFFFFFFF
       and       rax,r8
       mov       rdx,28B8FFC778816079
       mulx      rdx,rdx,rax
       shr       rdx,25
       mov       r8,0C92A69C000
       imul      rdx,r8
       sub       rax,rdx
       mov       [rsp+20],rax
       mov       rcx,[rcx+88]
       cmp       [rcx],cl
       lea       rcx,[rsp+20]
       call      qword ptr [7FF8F431E478]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.TimeOnly, System.Private.CoreLib]](System.TimeOnly ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 91
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.TimeOnly, System.Private.CoreLib]](System.TimeOnly ByRef)
       ret
; Total bytes of code 1
```

