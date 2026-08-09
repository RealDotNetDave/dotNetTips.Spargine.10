## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataTableExtensionsBenchmark.HasRowsEmptyTable()
       mov       rax,[rcx+198]
       test      rax,rax
       je        short M00_L01
       mov       rax,[rax+28]
       test      rax,rax
       je        short M00_L01
       mov       rax,[rax+10]
       mov       eax,[rax+28]
       dec       eax
       test      eax,eax
       setg      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rcx+88]
       mov       [rcx+4C],al
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 53
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataTableExtensionsBenchmark.HasRowsNullTable()
       mov       rax,[rcx+88]
       mov       byte ptr [rax+4C],0
       ret
; Total bytes of code 12
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataTableExtensionsBenchmark.HasRowsWithRows()
       mov       rax,[rcx+1A0]
       test      rax,rax
       je        short M00_L01
       mov       rax,[rax+28]
       test      rax,rax
       je        short M00_L01
       mov       rax,[rax+10]
       mov       eax,[rax+28]
       dec       eax
       test      eax,eax
       setg      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rcx+88]
       mov       [rcx+4C],al
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 53
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataTableExtensionsBenchmark.IsDBNullDbNullValue()
       mov       rax,[rcx+88]
       mov       byte ptr [rax+4C],1
       ret
; Total bytes of code 12
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DataTableExtensionsBenchmark.IsDBNullNonDbNullValue()
       mov       rax,22DC3400238
       mov       rdx,26E58384EE8
       cmp       [rax],rdx
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+88]
       mov       [rcx+4C],al
       ret
; Total bytes of code 40
```

