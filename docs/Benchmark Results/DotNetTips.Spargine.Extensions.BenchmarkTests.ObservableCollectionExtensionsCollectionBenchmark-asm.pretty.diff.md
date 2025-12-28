## DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark-20251228-052353
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E200D20
+       mov       r11,7FFA2E2110E8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E200D18
+       mov       r11,7FFA2E2110E0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E200D10
+       mov       r11,7FFA2E2110D8
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E200CF8
+       mov       r11,7FFA2E2110C0
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D00
+       mov       r11,7FFA2E2110C8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D08
+       mov       r11,7FFA2E2110D0
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D08
+       mov       r11,7FFA2E2110D0
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E200D20
+       mov       r11,7FFA2E2210E8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E200D18
+       mov       r11,7FFA2E2210E0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E200D10
+       mov       r11,7FFA2E2210D8
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E200CF8
+       mov       r11,7FFA2E2210C0
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D00
+       mov       r11,7FFA2E2210C8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D08
+       mov       r11,7FFA2E2210D0
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D08
+       mov       r11,7FFA2E2210D0
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E200D20
+       mov       r11,7FFA2E2010E8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E200D18
+       mov       r11,7FFA2E2010E0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E200D10
+       mov       r11,7FFA2E2010D8
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E200CF8
+       mov       r11,7FFA2E2010C0
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D00
+       mov       r11,7FFA2E2010C8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D08
+       mov       r11,7FFA2E2010D0
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D08
+       mov       r11,7FFA2E2010D0
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E200D20
+       mov       r11,7FFA2E2010E8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E200D18
+       mov       r11,7FFA2E2010E0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E200D10
+       mov       r11,7FFA2E2010D8
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E200CF8
+       mov       r11,7FFA2E2010C0
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D00
+       mov       r11,7FFA2E2010C8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D08
+       mov       r11,7FFA2E2010D0
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D08
+       mov       r11,7FFA2E2010D0
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E200D20
+       mov       r11,7FFA2E2210E8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E200D18
+       mov       r11,7FFA2E2210E0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E200D10
+       mov       r11,7FFA2E2210D8
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E200CF8
+       mov       r11,7FFA2E2210C0
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D00
+       mov       r11,7FFA2E2210C8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D08
+       mov       r11,7FFA2E2210D0
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D08
+       mov       r11,7FFA2E2210D0
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E200D20
+       mov       r11,7FFA2E2213D8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E200D18
+       mov       r11,7FFA2E2213D0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E200D10
+       mov       r11,7FFA2E2213C8
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E200CF8
+       mov       r11,7FFA2E2213B0
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D00
+       mov       r11,7FFA2E2213B8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D08
+       mov       r11,7FFA2E2213C0
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D08
+       mov       r11,7FFA2E2213C0
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E200D20
+       mov       r11,7FFA2E221770
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E200D18
+       mov       r11,7FFA2E221768
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E200D10
+       mov       r11,7FFA2E221760
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E200CF8
+       mov       r11,7FFA2E221748
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D00
+       mov       r11,7FFA2E221750
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D08
+       mov       r11,7FFA2E221758
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E200D08
+       mov       r11,7FFA2E221758
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E2110E8
+       mov       r11,7FFA2E2210E8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E2110E0
+       mov       r11,7FFA2E2210E0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E2110D8
+       mov       r11,7FFA2E2210D8
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E2110C0
+       mov       r11,7FFA2E2210C0
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2110C8
+       mov       r11,7FFA2E2210C8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2110D0
+       mov       r11,7FFA2E2210D0
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2110D0
+       mov       r11,7FFA2E2210D0
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E2110E8
+       mov       r11,7FFA2E2010E8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E2110E0
+       mov       r11,7FFA2E2010E0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E2110D8
+       mov       r11,7FFA2E2010D8
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E2110C0
+       mov       r11,7FFA2E2010C0
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2110C8
+       mov       r11,7FFA2E2010C8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2110D0
+       mov       r11,7FFA2E2010D0
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2110D0
+       mov       r11,7FFA2E2010D0
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E2110E8
+       mov       r11,7FFA2E2010E8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E2110E0
+       mov       r11,7FFA2E2010E0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E2110D8
+       mov       r11,7FFA2E2010D8
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E2110C0
+       mov       r11,7FFA2E2010C0
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2110C8
+       mov       r11,7FFA2E2010C8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2110D0
+       mov       r11,7FFA2E2010D0
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2110D0
+       mov       r11,7FFA2E2010D0
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E2110E8
+       mov       r11,7FFA2E2210E8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E2110E0
+       mov       r11,7FFA2E2210E0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E2110D8
+       mov       r11,7FFA2E2210D8
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E2110C0
+       mov       r11,7FFA2E2210C0
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2110C8
+       mov       r11,7FFA2E2210C8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2110D0
+       mov       r11,7FFA2E2210D0
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2110D0
+       mov       r11,7FFA2E2210D0
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E2110E8
+       mov       r11,7FFA2E2213D8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E2110E0
+       mov       r11,7FFA2E2213D0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E2110D8
+       mov       r11,7FFA2E2213C8
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E2110C0
+       mov       r11,7FFA2E2213B0
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2110C8
+       mov       r11,7FFA2E2213B8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2110D0
+       mov       r11,7FFA2E2213C0
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2110D0
+       mov       r11,7FFA2E2213C0
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E2110E8
+       mov       r11,7FFA2E221770
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E2110E0
+       mov       r11,7FFA2E221768
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E2110D8
+       mov       r11,7FFA2E221760
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E2110C0
+       mov       r11,7FFA2E221748
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2110C8
+       mov       r11,7FFA2E221750
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2110D0
+       mov       r11,7FFA2E221758
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2110D0
+       mov       r11,7FFA2E221758
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E2210E8
+       mov       r11,7FFA2E2010E8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E2210E0
+       mov       r11,7FFA2E2010E0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E2210D8
+       mov       r11,7FFA2E2010D8
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E2210C0
+       mov       r11,7FFA2E2010C0
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2210C8
+       mov       r11,7FFA2E2010C8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2210D0
+       mov       r11,7FFA2E2010D0
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2210D0
+       mov       r11,7FFA2E2010D0
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E2210E8
+       mov       r11,7FFA2E2010E8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E2210E0
+       mov       r11,7FFA2E2010E0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E2210D8
+       mov       r11,7FFA2E2010D8
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E2210C0
+       mov       r11,7FFA2E2010C0
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2210C8
+       mov       r11,7FFA2E2010C8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2210D0
+       mov       r11,7FFA2E2010D0
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2210D0
+       mov       r11,7FFA2E2010D0
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff

```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E2210E8
+       mov       r11,7FFA2E2213D8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E2210E0
+       mov       r11,7FFA2E2213D0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E2210D8
+       mov       r11,7FFA2E2213C8
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E2210C0
+       mov       r11,7FFA2E2213B0
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2210C8
+       mov       r11,7FFA2E2213B8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2210D0
+       mov       r11,7FFA2E2213C0
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2210D0
+       mov       r11,7FFA2E2213C0
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E2210E8
+       mov       r11,7FFA2E221770
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E2210E0
+       mov       r11,7FFA2E221768
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E2210D8
+       mov       r11,7FFA2E221760
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E2210C0
+       mov       r11,7FFA2E221748
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2210C8
+       mov       r11,7FFA2E221750
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2210D0
+       mov       r11,7FFA2E221758
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2210D0
+       mov       r11,7FFA2E221758
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff

```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E2010E8
+       mov       r11,7FFA2E2210E8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E2010E0
+       mov       r11,7FFA2E2210E0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E2010D8
+       mov       r11,7FFA2E2210D8
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E2010C0
+       mov       r11,7FFA2E2210C0
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2010C8
+       mov       r11,7FFA2E2210C8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E2210D0
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E2210D0
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E2010E8
+       mov       r11,7FFA2E2213D8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E2010E0
+       mov       r11,7FFA2E2213D0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E2010D8
+       mov       r11,7FFA2E2213C8
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E2010C0
+       mov       r11,7FFA2E2213B0
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2010C8
+       mov       r11,7FFA2E2213B8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E2213C0
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E2213C0
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E2010E8
+       mov       r11,7FFA2E221770
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E2010E0
+       mov       r11,7FFA2E221768
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E2010D8
+       mov       r11,7FFA2E221760
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E2010C0
+       mov       r11,7FFA2E221748
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2010C8
+       mov       r11,7FFA2E221750
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E221758
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E221758
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E2010E8
+       mov       r11,7FFA2E2210E8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E2010E0
+       mov       r11,7FFA2E2210E0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E2010D8
+       mov       r11,7FFA2E2210D8
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E2010C0
+       mov       r11,7FFA2E2210C0
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2010C8
+       mov       r11,7FFA2E2210C8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E2210D0
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E2210D0
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E2010E8
+       mov       r11,7FFA2E2213D8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E2010E0
+       mov       r11,7FFA2E2213D0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E2010D8
+       mov       r11,7FFA2E2213C8
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E2010C0
+       mov       r11,7FFA2E2213B0
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2010C8
+       mov       r11,7FFA2E2213B8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E2213C0
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E2213C0
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E2010E8
+       mov       r11,7FFA2E221770
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E2010E0
+       mov       r11,7FFA2E221768
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E2010D8
+       mov       r11,7FFA2E221760
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E2010C0
+       mov       r11,7FFA2E221748
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2010C8
+       mov       r11,7FFA2E221750
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E221758
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E221758
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E2210E8
+       mov       r11,7FFA2E2213D8
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E2210E0
+       mov       r11,7FFA2E2213D0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E2210D8
+       mov       r11,7FFA2E2213C8
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E2210C0
+       mov       r11,7FFA2E2213B0
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2210C8
+       mov       r11,7FFA2E2213B8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2210D0
+       mov       r11,7FFA2E2213C0
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2210D0
+       mov       r11,7FFA2E2213C0
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E2210E8
+       mov       r11,7FFA2E221770
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E2210E0
+       mov       r11,7FFA2E221768
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E2210D8
+       mov       r11,7FFA2E221760
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E2210C0
+       mov       r11,7FFA2E221748
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2210C8
+       mov       r11,7FFA2E221750
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2210D0
+       mov       r11,7FFA2E221758
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2210D0
+       mov       r11,7FFA2E221758
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithCount method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rbp
        ret
 M00_L03:
-       mov       r11,7FFA2E2213D8
+       mov       r11,7FFA2E221770
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L04:
        mov       rcx,rax
-       mov       r11,7FFA2E2213D0
+       mov       r11,7FFA2E221768
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
 M00_L05:
        mov       rax,rcx
        test      rax,rax
        je        short M00_L06
        mov       rcx,rax
-       mov       r11,7FFA2E2213C8
+       mov       r11,7FFA2E221760
        call      qword ptr [r11]
        movsxd    rsi,eax
        jmp       short M00_L01
 M00_L06:
        xor       esi,esi
-       mov       r11,7FFA2E2213B0
+       mov       r11,7FFA2E221748
        call      qword ptr [r11]
        mov       [rbp-18],rax
 M00_L07:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2213B8
+       mov       r11,7FFA2E221750
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L09
        add       esi,1
        jo        short M00_L08
        jmp       short M00_L07
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L09:
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2213C0
+       mov       r11,7FFA2E221758
        call      qword ptr [r11]
        movsxd    rsi,esi
        jmp       near ptr M00_L01
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L02
        sub       rsp,28
        cmp       qword ptr [rbp-18],0
        je        short M00_L11
        mov       rcx,[rbp-18]
-       mov       r11,7FFA2E2213C0
+       mov       r11,7FFA2E221758
        call      qword ptr [r11]
 M00_L11:
        nop
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,2A537002AC0
+       mov       rcx,16323800AC8
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
        test      eax,eax
        je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
 M00_L06:
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
        jne       short M00_L09
        lea       r13,[rcx+8]
-       mov       rax,[r13]
-       mov       edx,[r13+10]
-       mov       r8,[r13]
-       cmp       edx,[r8+14]
+       mov       rdx,[r13]
+       mov       rax,rdx
+       mov       r8d,[r13+10]
+       cmp       r8d,[rdx+14]
        jne       short M00_L12
        mov       r8d,[r13+14]
        cmp       r8d,[rax+10]
        jb        near ptr M00_L04
        xor       eax,eax
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA2E2110C0
+       mov       r11,7FFA2E2210C0
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110C8
+       mov       r11,7FFA2E2210C8
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L05
 M00_L12:
-       call      qword ptr [7FFA2E54C0D8]
+       call      qword ptr [7FFA2E55C0D8]
        int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rdx,[r13+rsi*8]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
        jmp       short M00_L21
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2A537002AB8
+       mov       rdx,16323800AC0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2A537002AC0
+       call      qword ptr [7FFA2E2D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,16323800AC8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        xor       eax,eax
        jmp       near ptr M00_L17
 M00_L26:
-       call      qword ptr [7FFA2E5479A8]
+       call      qword ptr [7FFA2E5579A8]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2A537002C10
+       mov       rcx,16323800C18
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2110D8
+       mov       r11,7FFA2E2210D8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2110B8
+       mov       r11,7FFA2E2210B8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L30:
        mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110D0
+       mov       r11,7FFA2E2210D0
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
        je        short M00_L31
-       mov       r11,7FFA2E2110D0
+       mov       r11,7FFA2E2210D0
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 998
+; Total bytes of code 997
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EBF5278]
+       call      qword ptr [7FFA2EC05290]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA2E2C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA2E2D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,2A537002AC0
+       mov       rcx,23457000AC8
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
        test      eax,eax
        je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
 M00_L06:
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
        jne       short M00_L09
        lea       r13,[rcx+8]
-       mov       rax,[r13]
-       mov       edx,[r13+10]
-       mov       r8,[r13]
-       cmp       edx,[r8+14]
+       mov       rdx,[r13]
+       mov       rax,rdx
+       mov       r8d,[r13+10]
+       cmp       r8d,[rdx+14]
        jne       short M00_L12
        mov       r8d,[r13+14]
        cmp       r8d,[rax+10]
        jb        near ptr M00_L04
        xor       eax,eax
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA2E2110C0
+       mov       r11,7FFA2E2210C0
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110C8
+       mov       r11,7FFA2E2210C8
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L05
 M00_L12:
-       call      qword ptr [7FFA2E54C0D8]
+       call      qword ptr [7FFA2E55C0D8]
        int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rdx,[r13+rsi*8]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
        jmp       short M00_L21
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2A537002AB8
+       mov       rdx,23457000AC0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2A537002AC0
+       call      qword ptr [7FFA2E2D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,23457000AC8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        xor       eax,eax
        jmp       near ptr M00_L17
 M00_L26:
-       call      qword ptr [7FFA2E5479A8]
+       call      qword ptr [7FFA2E5579A8]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2A537002C10
+       mov       rcx,23457000C18
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2110D8
+       mov       r11,7FFA2E2210D8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2110B8
+       mov       r11,7FFA2E2210B8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L30:
        mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110D0
+       mov       r11,7FFA2E2210D0
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
        je        short M00_L31
-       mov       r11,7FFA2E2110D0
+       mov       r11,7FFA2E2210D0
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 998
+; Total bytes of code 997
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EBF5278]
+       call      qword ptr [7FFA2EC052A8]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA2E2C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA2E2D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,2A537002AC0
+       mov       rcx,212C6802AC0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
        test      eax,eax
        je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
 M00_L06:
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
        jne       short M00_L09
        lea       r13,[rcx+8]
-       mov       rax,[r13]
-       mov       edx,[r13+10]
-       mov       r8,[r13]
-       cmp       edx,[r8+14]
+       mov       rdx,[r13]
+       mov       rax,rdx
+       mov       r8d,[r13+10]
+       cmp       r8d,[rdx+14]
        jne       short M00_L12
        mov       r8d,[r13+14]
        cmp       r8d,[rax+10]
        jb        near ptr M00_L04
        mov       rdx,[r13+rsi*8]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
        jmp       short M00_L21
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2A537002AB8
+       mov       rdx,212C6802AB8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2A537002AC0
+       mov       rcx,212C6802AC0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        call      qword ptr [7FFA2E5479A8]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2A537002C10
+       mov       rcx,212C6802C10
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,[rbp-40]
        mov       r11,7FFA2E2110D0
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
        je        short M00_L31
        mov       r11,7FFA2E2110D0
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 998
+; Total bytes of code 997
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EBF5278]
+       call      qword ptr [7FFA2EBF5260]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,2A537002AC0
+       mov       rcx,2AA6DC00AE0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L25
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
        je        near ptr M00_L19
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rax
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
+       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,rax
        jne       near ptr M00_L29
        mov       rsi,[rsi+8]
-       cmp       [rsi],rax
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rsi],rcx
        jne       near ptr M00_L28
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L27
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r15
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       r13d,[rsi+14]
        lea       rcx,[r15+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [r15+10],rcx
        mov       [r15+18],r13d
        mov       [r15+1C],ecx
 M00_L01:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rax,[r13]
-       mov       edx,[r13+10]
-       mov       r8,[r13]
-       cmp       edx,[r8+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA2E54C0D8]
+       int       3
 M00_L09:
-       mov       r11,7FFA2E2110C0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA2E210CF8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110C8
+       mov       rcx,r15
+       mov       r11,7FFA2E210D00
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA2E54C0D8]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
+       cmp       rsi,r13
        jne       near ptr M00_L30
 M00_L16:
        test      r14d,r14d
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
+       test      r15d,r15d
+       jle       short M00_L16
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
+       jmp       short M00_L23
 M00_L21:
        inc       r14d
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
        jmp       short M00_L21
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2A537002AB8
+       mov       rdx,2AA6DC00AD8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2A537002AC0
+       mov       rcx,2AA6DC00AE0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        call      qword ptr [7FFA2E5479A8]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2A537002C10
+       call      qword ptr [7FFA2E2C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,2AA57C02000
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2110D8
+       mov       r11,7FFA2E210D10
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2110B8
+       mov       r11,7FFA2E210CF0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L30:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110D0
+       mov       rcx,r15
+       mov       r11,7FFA2E210D08
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
        je        short M00_L31
-       mov       r11,7FFA2E2110D0
+       mov       rcx,r15
+       mov       r11,7FFA2E210D08
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 998
+; Total bytes of code 1014
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EBF5278]
+       call      qword ptr [7FFA2EC057B8]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,2A537002AC0
+       mov       rcx,241DE002AC0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L25
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
        je        near ptr M00_L19
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rax
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
+       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,rax
        jne       near ptr M00_L29
        mov       rsi,[rsi+8]
-       cmp       [rsi],rax
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rsi],rcx
        jne       near ptr M00_L28
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L27
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r15
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       r13d,[rsi+14]
        lea       rcx,[r15+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [r15+10],rcx
        mov       [r15+18],r13d
        mov       [r15+1C],ecx
 M00_L01:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rax,[r13]
-       mov       edx,[r13+10]
-       mov       r8,[r13]
-       cmp       edx,[r8+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA2E53C0D8]
+       int       3
 M00_L09:
-       mov       r11,7FFA2E2110C0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA2E2010B8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110C8
+       mov       rcx,r15
+       mov       r11,7FFA2E2010C0
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA2E54C0D8]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
+       cmp       rsi,r13
        jne       near ptr M00_L30
 M00_L16:
        test      r14d,r14d
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
+       test      r15d,r15d
+       jle       short M00_L16
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
+       jmp       short M00_L23
 M00_L21:
        inc       r14d
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
        jmp       short M00_L21
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2A537002AB8
+       mov       rdx,241DE002AB8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2A537002AC0
+       call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,241DE002AC0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        xor       eax,eax
        jmp       near ptr M00_L17
 M00_L26:
-       call      qword ptr [7FFA2E5479A8]
+       call      qword ptr [7FFA2E5379A8]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2A537002C10
+       mov       rcx,241DE002C10
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2110D8
+       mov       r11,7FFA2E2010D0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2110B8
+       mov       r11,7FFA2E2010B0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L30:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110D0
+       mov       rcx,r15
+       mov       r11,7FFA2E2010C8
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
        je        short M00_L31
-       mov       r11,7FFA2E2110D0
+       mov       rcx,r15
+       mov       r11,7FFA2E2010C8
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 998
+; Total bytes of code 1013
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EBF5278]
+       call      qword ptr [7FFA2EBE4FF0]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA2E2C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA2E2B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,2A537002AC0
+       mov       rcx,285EAC02AC0
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
-       je        near ptr M00_L19
+       je        near ptr M00_L20
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rax
        je        near ptr M00_L18
        mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rdx
        jne       near ptr M00_L29
        mov       rsi,[rsi+8]
        cmp       [rsi],rax
        jne       near ptr M00_L28
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L27
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r15
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       r13d,[rsi+14]
        lea       rcx,[r15+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [r15+10],rcx
        mov       [r15+18],r13d
        mov       [r15+1C],ecx
 M00_L01:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rax,[r13]
-       mov       edx,[r13+10]
-       mov       r8,[r13]
-       cmp       edx,[r8+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA2E53C0D8]
+       int       3
 M00_L09:
-       mov       r11,7FFA2E2110C0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA2E2013A0
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110C8
+       mov       rcx,r15
+       mov       r11,7FFA2E2013A8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA2E54C0D8]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
+       cmp       rsi,r13
        jne       near ptr M00_L30
 M00_L16:
        test      r14d,r14d
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L18:
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L26
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA2E5379A8]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
 M00_L21:
-       inc       r14d
+       test      r15d,r15d
+       jle       short M00_L16
+       xor       esi,esi
+       jmp       short M00_L24
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       inc       r14d
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
+M00_L24:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L22
-       jmp       short M00_L21
-M00_L24:
+       je        short M00_L23
+       jmp       short M00_L22
+M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2A537002AB8
+       mov       rdx,285EAC02AB8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2A537002AC0
+       call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,285EAC02AC0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
+M00_L26:
        xor       eax,eax
        jmp       near ptr M00_L17
-M00_L26:
-       call      qword ptr [7FFA2E5479A8]
-       int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2A537002C10
+       mov       rcx,285EAC02C38
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2110D8
+       mov       r11,7FFA2E2013B8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2110B8
+       mov       r11,7FFA2E201398
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L30:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110D0
+       mov       rcx,r15
+       mov       r11,7FFA2E2013B0
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
        je        short M00_L31
-       mov       r11,7FFA2E2110D0
+       mov       rcx,r15
+       mov       r11,7FFA2E2013B0
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 998
+; Total bytes of code 999
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EBF5278]
+       call      qword ptr [7FFA2EBE5368]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA2E2C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA2E2B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,2A537002AC0
+       mov       rcx,271B7C00B88
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        xor       r14d,r14d
        mov       rcx,[rsi]
-       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
-       cmp       rcx,rax
-       je        near ptr M00_L19
-       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rax
+       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
+       cmp       rcx,r11
+       je        near ptr M00_L20
+       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
-       jne       near ptr M00_L29
-       mov       rsi,[rsi+8]
-       cmp       [rsi],rax
-       jne       near ptr M00_L28
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L27
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r15
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r13d,[rsi+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rsi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r13d
-       mov       [r15+1C],ecx
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
+       jne       near ptr M00_L27
+       mov       rcx,[rsi+8]
+       mov       r11,7FFA2E201758
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L01:
-       mov       [rbp-40],r15
+       mov       [rbp-40],rcx
        cmp       qword ptr [rbp-40],0
        je        near ptr M00_L06
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
        jne       near ptr M00_L06
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rdx
        jne       near ptr M00_L06
        xor       eax,eax
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA2E2110C0
+       mov       r11,7FFA2E201740
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110C8
+       mov       r11,7FFA2E201748
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L05
 M00_L12:
-       call      qword ptr [7FFA2E54C0D8]
+       call      qword ptr [7FFA2E2BFC48]
        int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
        cmp       rsi,r15
-       jne       near ptr M00_L30
+       jne       near ptr M00_L28
 M00_L16:
        test      r14d,r14d
        setg      al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L18:
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L26
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA2E2BF480]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
 M00_L21:
-       inc       r14d
+       test      r15d,r15d
+       jle       short M00_L16
+       xor       esi,esi
+       jmp       short M00_L24
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       inc       r14d
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
+M00_L24:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L22
-       jmp       short M00_L21
-M00_L24:
+       je        short M00_L23
+       jmp       short M00_L22
+M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2A537002AB8
+       mov       rdx,271B7C00B80
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2A537002AC0
+       call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,271B7C00B88
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
+M00_L26:
        xor       eax,eax
        jmp       near ptr M00_L17
-M00_L26:
-       call      qword ptr [7FFA2E5479A8]
-       int       3
 M00_L27:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2A537002C10
-       mov       r15,[rcx]
-       jmp       near ptr M00_L01
-M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2110D8
+       mov       r11,7FFA2E201738
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       rcx,rax
        jmp       near ptr M00_L01
-M00_L29:
-       mov       rcx,rsi
-       mov       r11,7FFA2E2110B8
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L01
-M00_L30:
+M00_L28:
        mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110D0
+       mov       r11,7FFA2E201750
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
+       je        short M00_L29
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
-       je        short M00_L31
-       mov       r11,7FFA2E2110D0
+       je        short M00_L29
+       mov       r11,7FFA2E201750
        call      qword ptr [r11]
-M00_L31:
+M00_L29:
        nop
        add       rsp,28
        ret
-; Total bytes of code 998
+; Total bytes of code 884
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EBF5278]
+       call      qword ptr [7FFA2EA27B88]
        int       3
 ; Total bytes of code 44
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M03_L00
-       ret
-M03_L00:
-       jmp       qword ptr [7FFA2E2C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,16323800AC8
+       mov       rcx,23457000AC8
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
        mov       rdx,[r13+rsi*8]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
        jmp       short M00_L21
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,16323800AC0
+       mov       rdx,23457000AC0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FFA2E2D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,16323800AC8
+       mov       rcx,23457000AC8
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        call      qword ptr [7FFA2E5579A8]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,16323800C18
+       mov       rcx,23457000C18
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EC05290]
+       call      qword ptr [7FFA2EC052A8]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,16323800AC8
+       mov       rcx,212C6802AC0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
        xor       eax,eax
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA2E2210C0
+       mov       r11,7FFA2E2110C0
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210C8
+       mov       r11,7FFA2E2110C8
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L05
 M00_L12:
-       call      qword ptr [7FFA2E55C0D8]
+       call      qword ptr [7FFA2E54C0D8]
        int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rdx,[r13+rsi*8]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
        jmp       short M00_L21
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,16323800AC0
+       mov       rdx,212C6802AB8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,16323800AC8
+       call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,212C6802AC0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        xor       eax,eax
        jmp       near ptr M00_L17
 M00_L26:
-       call      qword ptr [7FFA2E5579A8]
+       call      qword ptr [7FFA2E5479A8]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,16323800C18
+       mov       rcx,212C6802C10
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2210D8
+       mov       r11,7FFA2E2110D8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2210B8
+       mov       r11,7FFA2E2110B8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L30:
        mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210D0
+       mov       r11,7FFA2E2110D0
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
        je        short M00_L31
-       mov       r11,7FFA2E2210D0
+       mov       r11,7FFA2E2110D0
        call      qword ptr [r11]
 M00_L31:
        nop
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EC05290]
+       call      qword ptr [7FFA2EBF5260]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA2E2D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA2E2C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,16323800AC8
+       mov       rcx,2AA6DC00AE0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L25
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
        je        near ptr M00_L19
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rax
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
+       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,rax
        jne       near ptr M00_L29
        mov       rsi,[rsi+8]
-       cmp       [rsi],rax
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rsi],rcx
        jne       near ptr M00_L28
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L27
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r15
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       r13d,[rsi+14]
        lea       rcx,[r15+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [r15+10],rcx
        mov       [r15+18],r13d
        mov       [r15+1C],ecx
 M00_L01:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA2E54C0D8]
+       int       3
 M00_L09:
-       mov       r11,7FFA2E2210C0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA2E210CF8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210C8
+       mov       rcx,r15
+       mov       r11,7FFA2E210D00
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA2E55C0D8]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
+       cmp       rsi,r13
        jne       near ptr M00_L30
 M00_L16:
        test      r14d,r14d
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
+       test      r15d,r15d
+       jle       short M00_L16
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
+       jmp       short M00_L23
 M00_L21:
        inc       r14d
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
        jmp       short M00_L21
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,16323800AC0
+       mov       rdx,2AA6DC00AD8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,16323800AC8
+       call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,2AA6DC00AE0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        xor       eax,eax
        jmp       near ptr M00_L17
 M00_L26:
-       call      qword ptr [7FFA2E5579A8]
+       call      qword ptr [7FFA2E5479A8]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,16323800C18
+       call      qword ptr [7FFA2E2C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,2AA57C02000
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2210D8
+       mov       r11,7FFA2E210D10
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2210B8
+       mov       r11,7FFA2E210CF0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L30:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210D0
+       mov       rcx,r15
+       mov       r11,7FFA2E210D08
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
        je        short M00_L31
-       mov       r11,7FFA2E2210D0
+       mov       rcx,r15
+       mov       r11,7FFA2E210D08
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 1014
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EC05290]
+       call      qword ptr [7FFA2EC057B8]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA2E2D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA2E2C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,16323800AC8
+       mov       rcx,241DE002AC0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L25
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
        je        near ptr M00_L19
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rax
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
+       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,rax
        jne       near ptr M00_L29
        mov       rsi,[rsi+8]
-       cmp       [rsi],rax
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rsi],rcx
        jne       near ptr M00_L28
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L27
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r15
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       r13d,[rsi+14]
        lea       rcx,[r15+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [r15+10],rcx
        mov       [r15+18],r13d
        mov       [r15+1C],ecx
 M00_L01:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA2E53C0D8]
+       int       3
 M00_L09:
-       mov       r11,7FFA2E2210C0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA2E2010B8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210C8
+       mov       rcx,r15
+       mov       r11,7FFA2E2010C0
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA2E55C0D8]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
+       cmp       rsi,r13
        jne       near ptr M00_L30
 M00_L16:
        test      r14d,r14d
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
+       test      r15d,r15d
+       jle       short M00_L16
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
+       jmp       short M00_L23
 M00_L21:
        inc       r14d
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
        jmp       short M00_L21
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,16323800AC0
+       mov       rdx,241DE002AB8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,16323800AC8
+       call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,241DE002AC0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        xor       eax,eax
        jmp       near ptr M00_L17
 M00_L26:
-       call      qword ptr [7FFA2E5579A8]
+       call      qword ptr [7FFA2E5379A8]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,16323800C18
+       mov       rcx,241DE002C10
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2210D8
+       mov       r11,7FFA2E2010D0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2210B8
+       mov       r11,7FFA2E2010B0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L30:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210D0
+       mov       rcx,r15
+       mov       r11,7FFA2E2010C8
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
        je        short M00_L31
-       mov       r11,7FFA2E2210D0
+       mov       rcx,r15
+       mov       r11,7FFA2E2010C8
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 1013
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EC05290]
+       call      qword ptr [7FFA2EBE4FF0]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA2E2D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA2E2B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,16323800AC8
+       mov       rcx,285EAC02AC0
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
-       je        near ptr M00_L19
+       je        near ptr M00_L20
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rax
        je        near ptr M00_L18
        mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rdx
        jne       near ptr M00_L29
        mov       rsi,[rsi+8]
        cmp       [rsi],rax
        jne       near ptr M00_L28
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L27
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r15
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       r13d,[rsi+14]
        lea       rcx,[r15+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [r15+10],rcx
        mov       [r15+18],r13d
        mov       [r15+1C],ecx
 M00_L01:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA2E53C0D8]
+       int       3
 M00_L09:
-       mov       r11,7FFA2E2210C0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA2E2013A0
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210C8
+       mov       rcx,r15
+       mov       r11,7FFA2E2013A8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA2E55C0D8]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
+       cmp       rsi,r13
        jne       near ptr M00_L30
 M00_L16:
        test      r14d,r14d
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L18:
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L26
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA2E5379A8]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
 M00_L21:
-       inc       r14d
+       test      r15d,r15d
+       jle       short M00_L16
+       xor       esi,esi
+       jmp       short M00_L24
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       inc       r14d
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
+M00_L24:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L22
-       jmp       short M00_L21
-M00_L24:
+       je        short M00_L23
+       jmp       short M00_L22
+M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,16323800AC0
+       mov       rdx,285EAC02AB8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,16323800AC8
+       call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,285EAC02AC0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
+M00_L26:
        xor       eax,eax
        jmp       near ptr M00_L17
-M00_L26:
-       call      qword ptr [7FFA2E5579A8]
-       int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,16323800C18
+       mov       rcx,285EAC02C38
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2210D8
+       mov       r11,7FFA2E2013B8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2210B8
+       mov       r11,7FFA2E201398
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L30:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210D0
+       mov       rcx,r15
+       mov       r11,7FFA2E2013B0
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
        je        short M00_L31
-       mov       r11,7FFA2E2210D0
+       mov       rcx,r15
+       mov       r11,7FFA2E2013B0
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 999
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EC05290]
+       call      qword ptr [7FFA2EBE5368]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA2E2D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA2E2B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,16323800AC8
+       mov       rcx,271B7C00B88
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        xor       r14d,r14d
        mov       rcx,[rsi]
-       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
-       cmp       rcx,rax
-       je        near ptr M00_L19
-       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rax
+       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
+       cmp       rcx,r11
+       je        near ptr M00_L20
+       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
-       jne       near ptr M00_L29
-       mov       rsi,[rsi+8]
-       cmp       [rsi],rax
-       jne       near ptr M00_L28
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L27
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r15
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r13d,[rsi+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rsi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r13d
-       mov       [r15+1C],ecx
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
+       jne       near ptr M00_L27
+       mov       rcx,[rsi+8]
+       mov       r11,7FFA2E201758
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L01:
-       mov       [rbp-40],r15
+       mov       [rbp-40],rcx
        cmp       qword ptr [rbp-40],0
        je        near ptr M00_L06
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
        jne       near ptr M00_L06
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rdx
        jne       near ptr M00_L06
        test      eax,eax
        je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
 M00_L06:
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
        jne       short M00_L09
        lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
+       mov       rax,[r13]
+       mov       edx,[r13+10]
+       mov       r8,[r13]
+       cmp       edx,[r8+14]
        jne       short M00_L12
        mov       r8d,[r13+14]
        cmp       r8d,[rax+10]
        jb        near ptr M00_L04
        xor       eax,eax
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA2E2210C0
+       mov       r11,7FFA2E201740
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210C8
+       mov       r11,7FFA2E201748
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L05
 M00_L12:
-       call      qword ptr [7FFA2E55C0D8]
+       call      qword ptr [7FFA2E2BFC48]
        int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
        cmp       rsi,r15
-       jne       near ptr M00_L30
+       jne       near ptr M00_L28
 M00_L16:
        test      r14d,r14d
        setg      al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L18:
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L26
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA2E2BF480]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
 M00_L21:
-       inc       r14d
+       test      r15d,r15d
+       jle       short M00_L16
+       xor       esi,esi
+       jmp       short M00_L24
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       inc       r14d
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
+M00_L24:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L22
-       jmp       short M00_L21
-M00_L24:
+       je        short M00_L23
+       jmp       short M00_L22
+M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,16323800AC0
+       mov       rdx,271B7C00B80
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,16323800AC8
+       call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,271B7C00B88
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
+M00_L26:
        xor       eax,eax
        jmp       near ptr M00_L17
-M00_L26:
-       call      qword ptr [7FFA2E5579A8]
-       int       3
 M00_L27:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,16323800C18
-       mov       r15,[rcx]
-       jmp       near ptr M00_L01
-M00_L28:
-       mov       rcx,rsi
-       mov       r11,7FFA2E2210D8
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L01
-M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2210B8
+       mov       r11,7FFA2E201738
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       rcx,rax
        jmp       near ptr M00_L01
-M00_L30:
+M00_L28:
        mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210D0
+       mov       r11,7FFA2E201750
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
+       je        short M00_L29
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
-       je        short M00_L31
-       mov       r11,7FFA2E2210D0
+       je        short M00_L29
+       mov       r11,7FFA2E201750
        call      qword ptr [r11]
-M00_L31:
+M00_L29:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 884
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EC05290]
+       call      qword ptr [7FFA2EA27B88]
        int       3
 ; Total bytes of code 44
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M03_L00
-       ret
-M03_L00:
-       jmp       qword ptr [7FFA2E2D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,23457000AC8
+       mov       rcx,212C6802AC0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
        xor       eax,eax
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA2E2210C0
+       mov       r11,7FFA2E2110C0
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210C8
+       mov       r11,7FFA2E2110C8
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L05
 M00_L12:
-       call      qword ptr [7FFA2E55C0D8]
+       call      qword ptr [7FFA2E54C0D8]
        int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        mov       rdx,[r13+rsi*8]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
        jmp       short M00_L21
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,23457000AC0
+       mov       rdx,212C6802AB8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,23457000AC8
+       call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,212C6802AC0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        xor       eax,eax
        jmp       near ptr M00_L17
 M00_L26:
-       call      qword ptr [7FFA2E5579A8]
+       call      qword ptr [7FFA2E5479A8]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,23457000C18
+       mov       rcx,212C6802C10
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2210D8
+       mov       r11,7FFA2E2110D8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2210B8
+       mov       r11,7FFA2E2110B8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L30:
        mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210D0
+       mov       r11,7FFA2E2110D0
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
        je        short M00_L31
-       mov       r11,7FFA2E2210D0
+       mov       r11,7FFA2E2110D0
        call      qword ptr [r11]
 M00_L31:
        nop
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EC052A8]
+       call      qword ptr [7FFA2EBF5260]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA2E2D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA2E2C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,23457000AC8
+       mov       rcx,2AA6DC00AE0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L25
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
        je        near ptr M00_L19
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rax
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
+       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,rax
        jne       near ptr M00_L29
        mov       rsi,[rsi+8]
-       cmp       [rsi],rax
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rsi],rcx
        jne       near ptr M00_L28
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L27
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r15
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       r13d,[rsi+14]
        lea       rcx,[r15+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [r15+10],rcx
        mov       [r15+18],r13d
        mov       [r15+1C],ecx
 M00_L01:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA2E54C0D8]
+       int       3
 M00_L09:
-       mov       r11,7FFA2E2210C0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA2E210CF8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210C8
+       mov       rcx,r15
+       mov       r11,7FFA2E210D00
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA2E55C0D8]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
+       cmp       rsi,r13
        jne       near ptr M00_L30
 M00_L16:
        test      r14d,r14d
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
+       test      r15d,r15d
+       jle       short M00_L16
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
+       jmp       short M00_L23
 M00_L21:
        inc       r14d
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
        jmp       short M00_L21
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,23457000AC0
+       mov       rdx,2AA6DC00AD8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,23457000AC8
+       call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,2AA6DC00AE0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        xor       eax,eax
        jmp       near ptr M00_L17
 M00_L26:
-       call      qword ptr [7FFA2E5579A8]
+       call      qword ptr [7FFA2E5479A8]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,23457000C18
+       call      qword ptr [7FFA2E2C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,2AA57C02000
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2210D8
+       mov       r11,7FFA2E210D10
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2210B8
+       mov       r11,7FFA2E210CF0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L30:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210D0
+       mov       rcx,r15
+       mov       r11,7FFA2E210D08
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
        je        short M00_L31
-       mov       r11,7FFA2E2210D0
+       mov       rcx,r15
+       mov       r11,7FFA2E210D08
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 1014
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EC052A8]
+       call      qword ptr [7FFA2EC057B8]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA2E2D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA2E2C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,23457000AC8
+       mov       rcx,241DE002AC0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L25
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
        je        near ptr M00_L19
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rax
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
+       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,rax
        jne       near ptr M00_L29
        mov       rsi,[rsi+8]
-       cmp       [rsi],rax
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rsi],rcx
        jne       near ptr M00_L28
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L27
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r15
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       r13d,[rsi+14]
        lea       rcx,[r15+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [r15+10],rcx
        mov       [r15+18],r13d
        mov       [r15+1C],ecx
 M00_L01:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA2E53C0D8]
+       int       3
 M00_L09:
-       mov       r11,7FFA2E2210C0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA2E2010B8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210C8
+       mov       rcx,r15
+       mov       r11,7FFA2E2010C0
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA2E55C0D8]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
+       cmp       rsi,r13
        jne       near ptr M00_L30
 M00_L16:
        test      r14d,r14d
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
+       test      r15d,r15d
+       jle       short M00_L16
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
+       jmp       short M00_L23
 M00_L21:
        inc       r14d
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
        jmp       short M00_L21
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,23457000AC0
+       mov       rdx,241DE002AB8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,23457000AC8
+       call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,241DE002AC0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        xor       eax,eax
        jmp       near ptr M00_L17
 M00_L26:
-       call      qword ptr [7FFA2E5579A8]
+       call      qword ptr [7FFA2E5379A8]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,23457000C18
+       mov       rcx,241DE002C10
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2210D8
+       mov       r11,7FFA2E2010D0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2210B8
+       mov       r11,7FFA2E2010B0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L30:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210D0
+       mov       rcx,r15
+       mov       r11,7FFA2E2010C8
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
        je        short M00_L31
-       mov       r11,7FFA2E2210D0
+       mov       rcx,r15
+       mov       r11,7FFA2E2010C8
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 1013
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EC052A8]
+       call      qword ptr [7FFA2EBE4FF0]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA2E2D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA2E2B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,23457000AC8
+       mov       rcx,285EAC02AC0
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
-       je        near ptr M00_L19
+       je        near ptr M00_L20
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rax
        je        near ptr M00_L18
        mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rdx
        jne       near ptr M00_L29
        mov       rsi,[rsi+8]
        cmp       [rsi],rax
        jne       near ptr M00_L28
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L27
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r15
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       r13d,[rsi+14]
        lea       rcx,[r15+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [r15+10],rcx
        mov       [r15+18],r13d
        mov       [r15+1C],ecx
 M00_L01:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA2E53C0D8]
+       int       3
 M00_L09:
-       mov       r11,7FFA2E2210C0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA2E2013A0
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210C8
+       mov       rcx,r15
+       mov       r11,7FFA2E2013A8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA2E55C0D8]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
+       cmp       rsi,r13
        jne       near ptr M00_L30
 M00_L16:
        test      r14d,r14d
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L18:
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L26
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA2E5379A8]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
 M00_L21:
-       inc       r14d
+       test      r15d,r15d
+       jle       short M00_L16
+       xor       esi,esi
+       jmp       short M00_L24
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       inc       r14d
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
+M00_L24:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L22
-       jmp       short M00_L21
-M00_L24:
+       je        short M00_L23
+       jmp       short M00_L22
+M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,23457000AC0
+       mov       rdx,285EAC02AB8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,23457000AC8
+       call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,285EAC02AC0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
+M00_L26:
        xor       eax,eax
        jmp       near ptr M00_L17
-M00_L26:
-       call      qword ptr [7FFA2E5579A8]
-       int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,23457000C18
+       mov       rcx,285EAC02C38
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2210D8
+       mov       r11,7FFA2E2013B8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2210B8
+       mov       r11,7FFA2E201398
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L30:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210D0
+       mov       rcx,r15
+       mov       r11,7FFA2E2013B0
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
        je        short M00_L31
-       mov       r11,7FFA2E2210D0
+       mov       rcx,r15
+       mov       r11,7FFA2E2013B0
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 999
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EC052A8]
+       call      qword ptr [7FFA2EBE5368]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA2E2D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA2E2B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,23457000AC8
+       mov       rcx,271B7C00B88
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        xor       r14d,r14d
        mov       rcx,[rsi]
-       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
-       cmp       rcx,rax
-       je        near ptr M00_L19
-       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rax
+       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
+       cmp       rcx,r11
+       je        near ptr M00_L20
+       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
-       jne       near ptr M00_L29
-       mov       rsi,[rsi+8]
-       cmp       [rsi],rax
-       jne       near ptr M00_L28
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L27
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r15
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r13d,[rsi+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rsi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r13d
-       mov       [r15+1C],ecx
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
+       jne       near ptr M00_L27
+       mov       rcx,[rsi+8]
+       mov       r11,7FFA2E201758
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L01:
-       mov       [rbp-40],r15
+       mov       [rbp-40],rcx
        cmp       qword ptr [rbp-40],0
        je        near ptr M00_L06
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
        jne       near ptr M00_L06
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rdx
        jne       near ptr M00_L06
        test      eax,eax
        je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
 M00_L06:
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
        jne       short M00_L09
        lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
+       mov       rax,[r13]
+       mov       edx,[r13+10]
+       mov       r8,[r13]
+       cmp       edx,[r8+14]
        jne       short M00_L12
        mov       r8d,[r13+14]
        cmp       r8d,[rax+10]
        jb        near ptr M00_L04
        xor       eax,eax
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA2E2210C0
+       mov       r11,7FFA2E201740
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210C8
+       mov       r11,7FFA2E201748
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L05
 M00_L12:
-       call      qword ptr [7FFA2E55C0D8]
+       call      qword ptr [7FFA2E2BFC48]
        int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
        cmp       rsi,r15
-       jne       near ptr M00_L30
+       jne       near ptr M00_L28
 M00_L16:
        test      r14d,r14d
        setg      al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L18:
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L26
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA2E2BF480]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
 M00_L21:
-       inc       r14d
+       test      r15d,r15d
+       jle       short M00_L16
+       xor       esi,esi
+       jmp       short M00_L24
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       inc       r14d
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
+M00_L24:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L22
-       jmp       short M00_L21
-M00_L24:
+       je        short M00_L23
+       jmp       short M00_L22
+M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,23457000AC0
+       mov       rdx,271B7C00B80
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2D6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,23457000AC8
+       call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,271B7C00B88
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
+M00_L26:
        xor       eax,eax
        jmp       near ptr M00_L17
-M00_L26:
-       call      qword ptr [7FFA2E5579A8]
-       int       3
 M00_L27:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,23457000C18
-       mov       r15,[rcx]
-       jmp       near ptr M00_L01
-M00_L28:
-       mov       rcx,rsi
-       mov       r11,7FFA2E2210D8
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L01
-M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2210B8
+       mov       r11,7FFA2E201738
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       rcx,rax
        jmp       near ptr M00_L01
-M00_L30:
+M00_L28:
        mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2210D0
+       mov       r11,7FFA2E201750
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
+       je        short M00_L29
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
-       je        short M00_L31
-       mov       r11,7FFA2E2210D0
+       je        short M00_L29
+       mov       r11,7FFA2E201750
        call      qword ptr [r11]
-M00_L31:
+M00_L29:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 884
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EC052A8]
+       call      qword ptr [7FFA2EA27B88]
        int       3
 ; Total bytes of code 44
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M03_L00
-       ret
-M03_L00:
-       jmp       qword ptr [7FFA2E2D5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,212C6802AC0
+       mov       rcx,2AA6DC00AE0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L25
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
        je        near ptr M00_L19
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rax
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
+       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,rax
        jne       near ptr M00_L29
        mov       rsi,[rsi+8]
-       cmp       [rsi],rax
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rsi],rcx
        jne       near ptr M00_L28
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L27
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r15
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       r13d,[rsi+14]
        lea       rcx,[r15+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [r15+10],rcx
        mov       [r15+18],r13d
        mov       [r15+1C],ecx
 M00_L01:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA2E54C0D8]
+       int       3
 M00_L09:
-       mov       r11,7FFA2E2110C0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA2E210CF8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110C8
+       mov       rcx,r15
+       mov       r11,7FFA2E210D00
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA2E54C0D8]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
+       cmp       rsi,r13
        jne       near ptr M00_L30
 M00_L16:
        test      r14d,r14d
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
+       test      r15d,r15d
+       jle       short M00_L16
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
+       jmp       short M00_L23
 M00_L21:
        inc       r14d
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
        jmp       short M00_L21
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,212C6802AB8
+       mov       rdx,2AA6DC00AD8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,212C6802AC0
+       mov       rcx,2AA6DC00AE0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        call      qword ptr [7FFA2E5479A8]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,212C6802C10
+       call      qword ptr [7FFA2E2C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,2AA57C02000
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2110D8
+       mov       r11,7FFA2E210D10
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2110B8
+       mov       r11,7FFA2E210CF0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L30:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110D0
+       mov       rcx,r15
+       mov       r11,7FFA2E210D08
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
        je        short M00_L31
-       mov       r11,7FFA2E2110D0
+       mov       rcx,r15
+       mov       r11,7FFA2E210D08
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 1014
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EBF5260]
+       call      qword ptr [7FFA2EC057B8]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,212C6802AC0
+       mov       rcx,241DE002AC0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L25
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
        je        near ptr M00_L19
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rax
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
+       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,rax
        jne       near ptr M00_L29
        mov       rsi,[rsi+8]
-       cmp       [rsi],rax
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       [rsi],rcx
        jne       near ptr M00_L28
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L27
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r15
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       r13d,[rsi+14]
        lea       rcx,[r15+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [r15+10],rcx
        mov       [r15+18],r13d
        mov       [r15+1C],ecx
 M00_L01:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA2E53C0D8]
+       int       3
 M00_L09:
-       mov       r11,7FFA2E2110C0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA2E2010B8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110C8
+       mov       rcx,r15
+       mov       r11,7FFA2E2010C0
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA2E54C0D8]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
+       cmp       rsi,r13
        jne       near ptr M00_L30
 M00_L16:
        test      r14d,r14d
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
 M00_L20:
+       test      r15d,r15d
+       jle       short M00_L16
        xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
+       jmp       short M00_L23
 M00_L21:
        inc       r14d
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
        jmp       short M00_L21
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,212C6802AB8
+       mov       rdx,241DE002AB8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,212C6802AC0
+       call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,241DE002AC0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        xor       eax,eax
        jmp       near ptr M00_L17
 M00_L26:
-       call      qword ptr [7FFA2E5479A8]
+       call      qword ptr [7FFA2E5379A8]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,212C6802C10
+       mov       rcx,241DE002C10
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2110D8
+       mov       r11,7FFA2E2010D0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2110B8
+       mov       r11,7FFA2E2010B0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L30:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110D0
+       mov       rcx,r15
+       mov       r11,7FFA2E2010C8
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
        je        short M00_L31
-       mov       r11,7FFA2E2110D0
+       mov       rcx,r15
+       mov       r11,7FFA2E2010C8
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 1013
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EBF5260]
+       call      qword ptr [7FFA2EBE4FF0]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA2E2C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA2E2B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,212C6802AC0
+       mov       rcx,285EAC02AC0
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
-       je        near ptr M00_L19
+       je        near ptr M00_L20
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rax
        je        near ptr M00_L18
        mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rdx
        jne       near ptr M00_L29
        mov       rsi,[rsi+8]
        cmp       [rsi],rax
        jne       near ptr M00_L28
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L27
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r15
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       r13d,[rsi+14]
        lea       rcx,[r15+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [r15+10],rcx
        mov       [r15+18],r13d
        mov       [r15+1C],ecx
 M00_L01:
        mov       [rbp-40],r15
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L06
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       near ptr M00_L06
-       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rdx
-       jne       near ptr M00_L06
+       je        near ptr M00_L05
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       mov       r13,rcx
+       cmp       rsi,r13
+       jne       near ptr M00_L05
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       near ptr M00_L05
 M00_L02:
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       near ptr M00_L12
-       mov       r8d,[r13+14]
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       near ptr M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rdi+rdx*8+10]
-       lea       rcx,[r13+8]
+       mov       ecx,r8d
+       mov       rdx,[rdi+rcx*8+10]
+       lea       rcx,[r12+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L08
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        near ptr M00_L09
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
 M00_L03:
-       test      eax,eax
+       test      r8d,r8d
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       mov       rdx,[rax+8]
-       cmp       r8d,[rdx+8]
-       jae       near ptr M00_L13
-       mov       eax,r8d
-       mov       rdx,[rdx+rax*8+10]
-       lea       rcx,[r13+8]
-       call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r13+14]
-       mov       rcx,[rbp-40]
-       mov       rdx,[rcx+10]
-       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],r11
-       jne       near ptr M00_L10
-       mov       r12,[rdx+30]
-       test      r12,r12
-       je        near ptr M00_L11
-       cmp       dword ptr [r12+8],0
-       setg      al
-       movzx     eax,al
-M00_L05:
-       test      eax,eax
-       je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
-M00_L06:
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
-       jne       short M00_L09
-       lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
-       jne       short M00_L12
-       mov       r8d,[r13+14]
+M00_L05:
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
+       jne       near ptr M00_L10
+       lea       r12,[r15+8]
+       mov       rcx,[r12]
+       mov       rax,rcx
+       mov       edx,[r12+10]
+       cmp       edx,[rcx+14]
+       jne       short M00_L08
+       mov       r8d,[r12+14]
        cmp       r8d,[rax+10]
-       jb        near ptr M00_L04
+       jae       short M00_L07
+       mov       rcx,[rax+8]
+       cmp       r8d,[rcx+8]
+       jae       near ptr M00_L13
+       mov       edx,r8d
+       mov       rdx,[rcx+rdx*8+10]
+       lea       rcx,[r12+8]
+       call      CORINFO_HELP_ASSIGN_REF
+       inc       dword ptr [r12+14]
+       mov       rdx,[r15+10]
+       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rcx
+       jne       short M00_L11
+       mov       rax,[rdx+30]
+       test      rax,rax
+       je        short M00_L12
+       cmp       dword ptr [rax+8],0
+       setg      r8b
+       movzx     r8d,r8b
+M00_L06:
+       test      r8d,r8d
+       je        near ptr M00_L05
+       jmp       near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r13+8],rax
-       mov       dword ptr [r13+14],0FFFFFFFF
+       mov       [r12+8],rax
+       mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       xor       eax,eax
-       jmp       near ptr M00_L03
+       call      qword ptr [7FFA2E53C0D8]
+       int       3
 M00_L09:
-       mov       r11,7FFA2E2110C0
+       xor       r8d,r8d
+       jmp       near ptr M00_L03
+M00_L10:
+       mov       rcx,r15
+       mov       r11,7FFA2E2013A0
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110C8
+       mov       rcx,r15
+       mov       r11,7FFA2E2013A8
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L10:
+M00_L11:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       rcx,[rbp-40]
-       jmp       near ptr M00_L05
-M00_L11:
-       xor       eax,eax
-       jmp       near ptr M00_L05
+       mov       r8d,eax
+       jmp       short M00_L06
 M00_L12:
-       call      qword ptr [7FFA2E54C0D8]
-       int       3
+       xor       r8d,r8d
+       jmp       short M00_L06
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r15
+       cmp       rsi,r13
        jne       near ptr M00_L30
 M00_L16:
        test      r14d,r14d
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L18:
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L26
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA2E5379A8]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
 M00_L21:
-       inc       r14d
+       test      r15d,r15d
+       jle       short M00_L16
+       xor       esi,esi
+       jmp       short M00_L24
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       inc       r14d
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
+M00_L24:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L22
-       jmp       short M00_L21
-M00_L24:
+       je        short M00_L23
+       jmp       short M00_L22
+M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,212C6802AB8
+       mov       rdx,285EAC02AB8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,212C6802AC0
+       call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,285EAC02AC0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
+M00_L26:
        xor       eax,eax
        jmp       near ptr M00_L17
-M00_L26:
-       call      qword ptr [7FFA2E5479A8]
-       int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,212C6802C10
+       mov       rcx,285EAC02C38
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2110D8
+       mov       r11,7FFA2E2013B8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2110B8
+       mov       r11,7FFA2E201398
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L30:
-       mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110D0
+       mov       rcx,r15
+       mov       r11,7FFA2E2013B0
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
-       mov       rcx,[rbp-40]
-       mov       rsi,[rcx]
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r15
+       mov       r15,[rbp-40]
+       mov       rsi,[r15]
+       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r13
        je        short M00_L31
-       mov       r11,7FFA2E2110D0
+       mov       rcx,r15
+       mov       r11,7FFA2E2013B0
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 999
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EBF5260]
+       call      qword ptr [7FFA2EBE5368]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA2E2C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA2E2B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,212C6802AC0
+       mov       rcx,271B7C00B88
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        xor       r14d,r14d
        mov       rcx,[rsi]
-       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
-       cmp       rcx,rax
-       je        near ptr M00_L19
-       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rax
+       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
+       cmp       rcx,r11
+       je        near ptr M00_L20
+       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
-       jne       near ptr M00_L29
-       mov       rsi,[rsi+8]
-       cmp       [rsi],rax
-       jne       near ptr M00_L28
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L27
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r15
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r13d,[rsi+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rsi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r13d
-       mov       [r15+1C],ecx
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
+       jne       near ptr M00_L27
+       mov       rcx,[rsi+8]
+       mov       r11,7FFA2E201758
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L01:
-       mov       [rbp-40],r15
+       mov       [rbp-40],rcx
        cmp       qword ptr [rbp-40],0
        je        near ptr M00_L06
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
        jne       near ptr M00_L06
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        cmp       [rdi+18],rdx
        jne       near ptr M00_L06
        test      eax,eax
        je        short M00_L06
        add       r14d,1
        jo        near ptr M00_L14
 M00_L06:
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
        jne       short M00_L09
        lea       r13,[rcx+8]
-       mov       rdx,[r13]
-       mov       rax,rdx
-       mov       r8d,[r13+10]
-       cmp       r8d,[rdx+14]
+       mov       rax,[r13]
+       mov       edx,[r13+10]
+       mov       r8,[r13]
+       cmp       edx,[r8+14]
        jne       short M00_L12
        mov       r8d,[r13+14]
        cmp       r8d,[rax+10]
        jb        near ptr M00_L04
        xor       eax,eax
        jmp       near ptr M00_L03
 M00_L09:
-       mov       r11,7FFA2E2110C0
+       mov       r11,7FFA2E201740
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110C8
+       mov       r11,7FFA2E201748
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L10:
        xor       eax,eax
        jmp       near ptr M00_L05
 M00_L12:
-       call      qword ptr [7FFA2E54C0D8]
+       call      qword ptr [7FFA2E2BFC48]
        int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
        cmp       rsi,r15
-       jne       near ptr M00_L30
+       jne       near ptr M00_L28
 M00_L16:
        test      r14d,r14d
        setg      al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L18:
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L26
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA2E2BF480]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
-       xor       esi,esi
-       cmp       esi,r15d
-       jl        short M00_L23
-       jmp       short M00_L16
 M00_L21:
-       inc       r14d
+       test      r15d,r15d
+       jle       short M00_L16
+       xor       esi,esi
+       jmp       short M00_L24
 M00_L22:
-       inc       esi
-       cmp       esi,r15d
-       jge       short M00_L16
+       inc       r14d
 M00_L23:
-       mov       rdx,[r13+rsi*8]
+       add       rsi,8
+       dec       r15d
+       je        short M00_L16
+M00_L24:
+       mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L22
-       jmp       short M00_L21
-M00_L24:
+       je        short M00_L23
+       jmp       short M00_L22
+M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,212C6802AB8
+       mov       rdx,271B7C00B80
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,212C6802AC0
+       call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,271B7C00B88
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
+M00_L26:
        xor       eax,eax
        jmp       near ptr M00_L17
-M00_L26:
-       call      qword ptr [7FFA2E5479A8]
-       int       3
 M00_L27:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,212C6802C10
-       mov       r15,[rcx]
-       jmp       near ptr M00_L01
-M00_L28:
-       mov       rcx,rsi
-       mov       r11,7FFA2E2110D8
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L01
-M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2110B8
+       mov       r11,7FFA2E201738
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       rcx,rax
        jmp       near ptr M00_L01
-M00_L30:
+M00_L28:
        mov       rcx,[rbp-40]
-       mov       r11,7FFA2E2110D0
+       mov       r11,7FFA2E201750
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
+       je        short M00_L29
        mov       rcx,[rbp-40]
        mov       rsi,[rcx]
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r15
-       je        short M00_L31
-       mov       r11,7FFA2E2110D0
+       je        short M00_L29
+       mov       r11,7FFA2E201750
        call      qword ptr [r11]
-M00_L31:
+M00_L29:
        nop
        add       rsp,28
        ret
-; Total bytes of code 997
+; Total bytes of code 884
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EBF5260]
+       call      qword ptr [7FFA2EA27B88]
        int       3
 ; Total bytes of code 44
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M03_L00
-       ret
-M03_L00:
-       jmp       qword ptr [7FFA2E2C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,2AA6DC00AE0
+       mov       rcx,241DE002AC0
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L24
        xor       eax,eax
        mov       [r12+8],rax
        mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       call      qword ptr [7FFA2E54C0D8]
+       call      qword ptr [7FFA2E53C0D8]
        int       3
 M00_L09:
        xor       r8d,r8d
        jmp       near ptr M00_L03
 M00_L10:
        mov       rcx,r15
-       mov       r11,7FFA2E210CF8
+       mov       r11,7FFA2E2010B8
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,r15
-       mov       r11,7FFA2E210D00
+       mov       r11,7FFA2E2010C0
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L11:
        mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L22
        jmp       short M00_L21
 M00_L24:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2AA6DC00AD8
+       mov       rdx,241DE002AB8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2AA6DC00AE0
+       call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,241DE002AC0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        xor       eax,eax
        jmp       near ptr M00_L17
 M00_L26:
-       call      qword ptr [7FFA2E5479A8]
+       call      qword ptr [7FFA2E5379A8]
        int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA2E2C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2AA57C02000
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,241DE002C10
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E210D10
+       mov       r11,7FFA2E2010D0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E210CF0
+       mov       r11,7FFA2E2010B0
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L30:
        mov       rcx,r15
-       mov       r11,7FFA2E210D08
+       mov       r11,7FFA2E2010C8
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
        mov       r15,[rbp-40]
        mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        je        short M00_L31
        mov       rcx,r15
-       mov       r11,7FFA2E210D08
+       mov       r11,7FFA2E2010C8
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1014
+; Total bytes of code 1013
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EC057B8]
+       call      qword ptr [7FFA2EBE4FF0]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA2E2C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA2E2B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,2AA6DC00AE0
+       mov       rcx,285EAC02AC0
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
-       je        near ptr M00_L19
+       je        near ptr M00_L20
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rax
        je        near ptr M00_L18
-       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rax
+       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,rdx
        jne       near ptr M00_L29
        mov       rsi,[rsi+8]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rsi],rcx
+       cmp       [rsi],rax
        jne       near ptr M00_L28
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L27
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r15
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       r13d,[rsi+14]
        lea       rcx,[r15+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [r15+10],rcx
        mov       [r15+18],r13d
        mov       [r15+1C],ecx
        xor       eax,eax
        mov       [r12+8],rax
        mov       dword ptr [r12+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       call      qword ptr [7FFA2E54C0D8]
+       call      qword ptr [7FFA2E53C0D8]
        int       3
 M00_L09:
        xor       r8d,r8d
        jmp       near ptr M00_L03
 M00_L10:
        mov       rcx,r15
-       mov       r11,7FFA2E210CF8
+       mov       r11,7FFA2E2013A0
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,r15
-       mov       r11,7FFA2E210D00
+       mov       r11,7FFA2E2013A8
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L11:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L18:
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L26
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA2E5379A8]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
+M00_L21:
        test      r15d,r15d
        jle       short M00_L16
        xor       esi,esi
-       jmp       short M00_L23
-M00_L21:
-       inc       r14d
+       jmp       short M00_L24
 M00_L22:
+       inc       r14d
+M00_L23:
        add       rsi,8
        dec       r15d
        je        short M00_L16
-M00_L23:
+M00_L24:
        mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L22
-       jmp       short M00_L21
-M00_L24:
+       je        short M00_L23
+       jmp       short M00_L22
+M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2AA6DC00AD8
+       mov       rdx,285EAC02AB8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2AA6DC00AE0
+       call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,285EAC02AC0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
+M00_L26:
        xor       eax,eax
        jmp       near ptr M00_L17
-M00_L26:
-       call      qword ptr [7FFA2E5479A8]
-       int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA2E2C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2AA57C02000
+       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
+       mov       rcx,285EAC02C38
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E210D10
+       mov       r11,7FFA2E2013B8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E210CF0
+       mov       r11,7FFA2E201398
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L30:
        mov       rcx,r15
-       mov       r11,7FFA2E210D08
+       mov       r11,7FFA2E2013B0
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
        mov       r15,[rbp-40]
        mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        je        short M00_L31
        mov       rcx,r15
-       mov       r11,7FFA2E210D08
+       mov       r11,7FFA2E2013B0
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1014
+; Total bytes of code 999
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EC057B8]
+       call      qword ptr [7FFA2EBE5368]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
 M03_L00:
-       jmp       qword ptr [7FFA2E2C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
+       jmp       qword ptr [7FFA2E2B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
 ; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,2AA6DC00AE0
+       mov       rcx,271B7C00B88
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        xor       r14d,r14d
        mov       rcx,[rsi]
-       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
-       cmp       rcx,rax
-       je        near ptr M00_L19
-       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rax
+       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
+       cmp       rcx,r11
+       je        near ptr M00_L20
+       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
        je        near ptr M00_L18
-       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rax
-       jne       near ptr M00_L29
-       mov       rsi,[rsi+8]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rsi],rcx
-       jne       near ptr M00_L28
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L27
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r15
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r13d,[rsi+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rsi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r13d
-       mov       [r15+1C],ecx
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
+       jne       near ptr M00_L27
+       mov       rcx,[rsi+8]
+       mov       r11,7FFA2E201758
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L01:
-       mov       [rbp-40],r15
+       mov       [rbp-40],rcx
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L05
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r13,rcx
-       cmp       rsi,r13
-       jne       near ptr M00_L05
-       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rcx
-       jne       near ptr M00_L05
+       je        near ptr M00_L06
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r15
+       jne       near ptr M00_L06
+       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rdx
+       jne       near ptr M00_L06
 M00_L02:
-       lea       r12,[r15+8]
-       mov       rcx,[r12]
-       mov       rax,rcx
-       mov       edx,[r12+10]
-       cmp       edx,[rcx+14]
-       jne       near ptr M00_L08
-       mov       r8d,[r12+14]
+       lea       r13,[rcx+8]
+       mov       rdx,[r13]
+       mov       rax,rdx
+       mov       r8d,[r13+10]
+       cmp       r8d,[rdx+14]
+       jne       near ptr M00_L12
+       mov       r8d,[r13+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       ecx,r8d
-       mov       rdx,[rdi+rcx*8+10]
-       lea       rcx,[r12+8]
+       mov       edx,r8d
+       mov       rdx,[rdi+rdx*8+10]
+       lea       rcx,[r13+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r12+14]
-       mov       rdx,[r15+10]
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        near ptr M00_L09
-       cmp       dword ptr [rax+8],0
-       setg      r8b
-       movzx     r8d,r8b
+       inc       dword ptr [r13+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r12,[rdx+30]
+       test      r12,r12
+       je        near ptr M00_L08
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
 M00_L03:
-       test      r8d,r8d
+       test      eax,eax
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       add       r14d,1
-       jo        near ptr M00_L14
-M00_L05:
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r13
-       jne       near ptr M00_L10
-       lea       r12,[r15+8]
-       mov       rcx,[r12]
-       mov       rax,rcx
-       mov       edx,[r12+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L08
-       mov       r8d,[r12+14]
-       cmp       r8d,[rax+10]
-       jae       short M00_L07
-       mov       rcx,[rax+8]
-       cmp       r8d,[rcx+8]
+       mov       rdx,[rax+8]
+       cmp       r8d,[rdx+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rcx+rdx*8+10]
-       lea       rcx,[r12+8]
+       mov       eax,r8d
+       mov       rdx,[rdx+rax*8+10]
+       lea       rcx,[r13+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r12+14]
-       mov       rdx,[r15+10]
-       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rcx
-       jne       short M00_L11
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        short M00_L12
-       cmp       dword ptr [rax+8],0
-       setg      r8b
-       movzx     r8d,r8b
+       inc       dword ptr [r13+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],r11
+       jne       near ptr M00_L10
+       mov       r12,[rdx+30]
+       test      r12,r12
+       je        near ptr M00_L11
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
+M00_L05:
+       test      eax,eax
+       je        short M00_L06
+       add       r14d,1
+       jo        near ptr M00_L14
 M00_L06:
-       test      r8d,r8d
-       je        near ptr M00_L05
-       jmp       near ptr M00_L04
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r15
+       jne       short M00_L09
+       lea       r13,[rcx+8]
+       mov       rax,[r13]
+       mov       edx,[r13+10]
+       mov       r8,[r13]
+       cmp       edx,[r8+14]
+       jne       short M00_L12
+       mov       r8d,[r13+14]
+       cmp       r8d,[rax+10]
+       jb        near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r12+8],rax
-       mov       dword ptr [r12+14],0FFFFFFFF
+       mov       [r13+8],rax
+       mov       dword ptr [r13+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       call      qword ptr [7FFA2E54C0D8]
-       int       3
-M00_L09:
-       xor       r8d,r8d
+       xor       eax,eax
        jmp       near ptr M00_L03
-M00_L10:
-       mov       rcx,r15
-       mov       r11,7FFA2E210CF8
+M00_L09:
+       mov       r11,7FFA2E201740
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,r15
-       mov       r11,7FFA2E210D00
+       mov       rcx,[rbp-40]
+       mov       r11,7FFA2E201748
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L11:
+M00_L10:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       r8d,eax
-       jmp       short M00_L06
+       mov       rcx,[rbp-40]
+       jmp       near ptr M00_L05
+M00_L11:
+       xor       eax,eax
+       jmp       near ptr M00_L05
 M00_L12:
-       xor       r8d,r8d
-       jmp       short M00_L06
+       call      qword ptr [7FFA2E2BFC48]
+       int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r13
-       jne       near ptr M00_L30
+       cmp       rsi,r15
+       jne       near ptr M00_L28
 M00_L16:
        test      r14d,r14d
        setg      al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L18:
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L26
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA2E2BF480]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
+M00_L21:
        test      r15d,r15d
        jle       short M00_L16
        xor       esi,esi
-       jmp       short M00_L23
-M00_L21:
-       inc       r14d
+       jmp       short M00_L24
 M00_L22:
+       inc       r14d
+M00_L23:
        add       rsi,8
        dec       r15d
        je        short M00_L16
-M00_L23:
+M00_L24:
        mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L22
-       jmp       short M00_L21
-M00_L24:
+       je        short M00_L23
+       jmp       short M00_L22
+M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2AA6DC00AD8
+       mov       rdx,271B7C00B80
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       call      qword ptr [7FFA2E2C6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,2AA6DC00AE0
+       call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,271B7C00B88
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
+M00_L26:
        xor       eax,eax
        jmp       near ptr M00_L17
-M00_L26:
-       call      qword ptr [7FFA2E5479A8]
-       int       3
 M00_L27:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      qword ptr [7FFA2E2C5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,2AA57C02000
-       mov       r15,[rcx]
-       jmp       near ptr M00_L01
-M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E210D10
+       mov       r11,7FFA2E201738
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       rcx,rax
        jmp       near ptr M00_L01
-M00_L29:
-       mov       rcx,rsi
-       mov       r11,7FFA2E210CF0
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L01
-M00_L30:
-       mov       rcx,r15
-       mov       r11,7FFA2E210D08
+M00_L28:
+       mov       rcx,[rbp-40]
+       mov       r11,7FFA2E201750
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r13
-       je        short M00_L31
-       mov       rcx,r15
-       mov       r11,7FFA2E210D08
+       je        short M00_L29
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r15
+       je        short M00_L29
+       mov       r11,7FFA2E201750
        call      qword ptr [r11]
-M00_L31:
+M00_L29:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1014
+; Total bytes of code 884
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EC057B8]
+       call      qword ptr [7FFA2EA27B88]
        int       3
 ; Total bytes of code 44
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M03_L00
-       ret
-M03_L00:
-       jmp       qword ptr [7FFA2E2C5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,241DE002AC0
+       mov       rcx,285EAC02AC0
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        xor       r14d,r14d
        mov       rcx,[rsi]
        mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
        cmp       rcx,rax
-       je        near ptr M00_L19
+       je        near ptr M00_L20
        mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        cmp       rcx,rax
        je        near ptr M00_L18
-       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rax
+       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,rdx
        jne       near ptr M00_L29
        mov       rsi,[rsi+8]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rsi],rcx
+       cmp       [rsi],rax
        jne       near ptr M00_L28
        cmp       dword ptr [rsi+10],0
        je        near ptr M00_L27
        mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        mov       rcx,r15
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       r13d,[rsi+14]
        lea       rcx,[r15+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
        xor       ecx,ecx
        mov       [r15+10],rcx
        mov       [r15+18],r13d
        mov       [r15+1C],ecx
        xor       r8d,r8d
        jmp       near ptr M00_L03
 M00_L10:
        mov       rcx,r15
-       mov       r11,7FFA2E2010B8
+       mov       r11,7FFA2E2013A0
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
        mov       rcx,r15
-       mov       r11,7FFA2E2010C0
+       mov       r11,7FFA2E2013A8
        call      qword ptr [r11]
        mov       rdx,rax
 M00_L11:
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L18:
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L26
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA2E5379A8]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
+M00_L21:
        test      r15d,r15d
        jle       short M00_L16
        xor       esi,esi
-       jmp       short M00_L23
-M00_L21:
-       inc       r14d
+       jmp       short M00_L24
 M00_L22:
+       inc       r14d
+M00_L23:
        add       rsi,8
        dec       r15d
        je        short M00_L16
-M00_L23:
+M00_L24:
        mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L22
-       jmp       short M00_L21
-M00_L24:
+       je        short M00_L23
+       jmp       short M00_L22
+M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,241DE002AB8
+       mov       rdx,285EAC02AB8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,241DE002AC0
+       mov       rcx,285EAC02AC0
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
+M00_L26:
        xor       eax,eax
        jmp       near ptr M00_L17
-M00_L26:
-       call      qword ptr [7FFA2E5379A8]
-       int       3
 M00_L27:
        mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
        call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,241DE002C10
+       mov       rcx,285EAC02C38
        mov       r15,[rcx]
        jmp       near ptr M00_L01
 M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E2013B8
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L29:
        mov       rcx,rsi
-       mov       r11,7FFA2E2010B0
+       mov       r11,7FFA2E201398
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M00_L01
 M00_L30:
        mov       rcx,r15
-       mov       r11,7FFA2E2010C8
+       mov       r11,7FFA2E2013B0
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
        je        short M00_L31
        mov       r15,[rbp-40]
        mov       rsi,[r15]
        mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
        cmp       rsi,r13
        je        short M00_L31
        mov       rcx,r15
-       mov       r11,7FFA2E2010C8
+       mov       r11,7FFA2E2013B0
        call      qword ptr [r11]
 M00_L31:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1013
+; Total bytes of code 999
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EBE4FF0]
+       call      qword ptr [7FFA2EBE5368]
        int       3
 ; Total bytes of code 44
 ; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
        mov       rax,[rcx+20]
        mov       rax,[rax-18]
        mov       rdx,rax
        test      dl,1
        jne       short M03_L00
        ret
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,241DE002AC0
+       mov       rcx,271B7C00B88
        mov       rdi,[rcx]
        test      rdi,rdi
-       je        near ptr M00_L24
+       je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
-       je        near ptr M00_L25
+       je        near ptr M00_L26
        xor       r14d,r14d
        mov       rcx,[rsi]
-       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
-       cmp       rcx,rax
-       je        near ptr M00_L19
-       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rax
+       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
+       cmp       rcx,r11
+       je        near ptr M00_L20
+       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
        je        near ptr M00_L18
-       mov       rax,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rax
-       jne       near ptr M00_L29
-       mov       rsi,[rsi+8]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       [rsi],rcx
-       jne       near ptr M00_L28
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L27
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r15
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r13d,[rsi+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rsi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r13d
-       mov       [r15+1C],ecx
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
+       jne       near ptr M00_L27
+       mov       rcx,[rsi+8]
+       mov       r11,7FFA2E201758
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L01:
-       mov       [rbp-40],r15
+       mov       [rbp-40],rcx
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L05
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r13,rcx
-       cmp       rsi,r13
-       jne       near ptr M00_L05
-       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rcx
-       jne       near ptr M00_L05
+       je        near ptr M00_L06
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r15
+       jne       near ptr M00_L06
+       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rdx
+       jne       near ptr M00_L06
 M00_L02:
-       lea       r12,[r15+8]
-       mov       rcx,[r12]
-       mov       rax,rcx
-       mov       edx,[r12+10]
-       cmp       edx,[rcx+14]
-       jne       near ptr M00_L08
-       mov       r8d,[r12+14]
+       lea       r13,[rcx+8]
+       mov       rdx,[r13]
+       mov       rax,rdx
+       mov       r8d,[r13+10]
+       cmp       r8d,[rdx+14]
+       jne       near ptr M00_L12
+       mov       r8d,[r13+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       ecx,r8d
-       mov       rdx,[rdi+rcx*8+10]
-       lea       rcx,[r12+8]
+       mov       edx,r8d
+       mov       rdx,[rdi+rdx*8+10]
+       lea       rcx,[r13+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r12+14]
-       mov       rdx,[r15+10]
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        near ptr M00_L09
-       cmp       dword ptr [rax+8],0
-       setg      r8b
-       movzx     r8d,r8b
+       inc       dword ptr [r13+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r12,[rdx+30]
+       test      r12,r12
+       je        near ptr M00_L08
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
 M00_L03:
-       test      r8d,r8d
+       test      eax,eax
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       add       r14d,1
-       jo        near ptr M00_L14
-M00_L05:
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r13
-       jne       near ptr M00_L10
-       lea       r12,[r15+8]
-       mov       rcx,[r12]
-       mov       rax,rcx
-       mov       edx,[r12+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L08
-       mov       r8d,[r12+14]
-       cmp       r8d,[rax+10]
-       jae       short M00_L07
-       mov       rcx,[rax+8]
-       cmp       r8d,[rcx+8]
+       mov       rdx,[rax+8]
+       cmp       r8d,[rdx+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rcx+rdx*8+10]
-       lea       rcx,[r12+8]
+       mov       eax,r8d
+       mov       rdx,[rdx+rax*8+10]
+       lea       rcx,[r13+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r12+14]
-       mov       rdx,[r15+10]
-       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rcx
-       jne       short M00_L11
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        short M00_L12
-       cmp       dword ptr [rax+8],0
-       setg      r8b
-       movzx     r8d,r8b
+       inc       dword ptr [r13+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],r11
+       jne       near ptr M00_L10
+       mov       r12,[rdx+30]
+       test      r12,r12
+       je        near ptr M00_L11
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
+M00_L05:
+       test      eax,eax
+       je        short M00_L06
+       add       r14d,1
+       jo        near ptr M00_L14
 M00_L06:
-       test      r8d,r8d
-       je        near ptr M00_L05
-       jmp       near ptr M00_L04
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r15
+       jne       short M00_L09
+       lea       r13,[rcx+8]
+       mov       rax,[r13]
+       mov       edx,[r13+10]
+       mov       r8,[r13]
+       cmp       edx,[r8+14]
+       jne       short M00_L12
+       mov       r8d,[r13+14]
+       cmp       r8d,[rax+10]
+       jb        near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r12+8],rax
-       mov       dword ptr [r12+14],0FFFFFFFF
+       mov       [r13+8],rax
+       mov       dword ptr [r13+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       call      qword ptr [7FFA2E53C0D8]
-       int       3
-M00_L09:
-       xor       r8d,r8d
+       xor       eax,eax
        jmp       near ptr M00_L03
-M00_L10:
-       mov       rcx,r15
-       mov       r11,7FFA2E2010B8
+M00_L09:
+       mov       r11,7FFA2E201740
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,r15
-       mov       r11,7FFA2E2010C0
+       mov       rcx,[rbp-40]
+       mov       r11,7FFA2E201748
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L11:
+M00_L10:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       r8d,eax
-       jmp       short M00_L06
+       mov       rcx,[rbp-40]
+       jmp       near ptr M00_L05
+M00_L11:
+       xor       eax,eax
+       jmp       near ptr M00_L05
 M00_L12:
-       xor       r8d,r8d
-       jmp       short M00_L06
+       call      qword ptr [7FFA2E2BFC48]
+       int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r13
-       jne       near ptr M00_L30
+       cmp       rsi,r15
+       jne       near ptr M00_L28
 M00_L16:
        test      r14d,r14d
        setg      al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        pop       rbp
        ret
 M00_L18:
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
-       jb        near ptr M00_L26
+       jb        short M00_L19
        add       r13,10
-       jmp       short M00_L20
+       jmp       short M00_L21
 M00_L19:
+       call      qword ptr [7FFA2E2BF480]
+       int       3
+M00_L20:
        lea       r13,[rsi+10]
        mov       r15d,[rsi+8]
-M00_L20:
+M00_L21:
        test      r15d,r15d
        jle       short M00_L16
        xor       esi,esi
-       jmp       short M00_L23
-M00_L21:
-       inc       r14d
+       jmp       short M00_L24
 M00_L22:
+       inc       r14d
+M00_L23:
        add       rsi,8
        dec       r15d
        je        short M00_L16
-M00_L23:
+M00_L24:
        mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
-       je        short M00_L22
-       jmp       short M00_L21
-M00_L24:
+       je        short M00_L23
+       jmp       short M00_L22
+M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,241DE002AB8
+       mov       rdx,271B7C00B80
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,241DE002AC0
+       mov       rcx,271B7C00B88
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
-M00_L25:
+M00_L26:
        xor       eax,eax
        jmp       near ptr M00_L17
-M00_L26:
-       call      qword ptr [7FFA2E5379A8]
-       int       3
 M00_L27:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,241DE002C10
-       mov       r15,[rcx]
-       jmp       near ptr M00_L01
-M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E201738
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       rcx,rax
        jmp       near ptr M00_L01
-M00_L29:
-       mov       rcx,rsi
-       mov       r11,7FFA2E2010B0
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L01
-M00_L30:
-       mov       rcx,r15
-       mov       r11,7FFA2E2010C8
+M00_L28:
+       mov       rcx,[rbp-40]
+       mov       r11,7FFA2E201750
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r13
-       je        short M00_L31
-       mov       rcx,r15
-       mov       r11,7FFA2E2010C8
+       je        short M00_L29
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r15
+       je        short M00_L29
+       mov       r11,7FFA2E201750
        call      qword ptr [r11]
-M00_L31:
+M00_L29:
        nop
        add       rsp,28
        ret
-; Total bytes of code 1013
+; Total bytes of code 884
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EBE4FF0]
+       call      qword ptr [7FFA2EA27B88]
        int       3
 ; Total bytes of code 44
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M03_L00
-       ret
-M03_L00:
-       jmp       qword ptr [7FFA2E2B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for HasItemsWithPredicate method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rbp
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,28
        lea       rbp,[rsp+60]
        mov       rbx,rcx
        mov       rsi,[rbx+270]
-       mov       rcx,285EAC02AC0
+       mov       rcx,271B7C00B88
        mov       rdi,[rcx]
        test      rdi,rdi
        je        near ptr M00_L25
 M00_L00:
        test      rsi,rsi
        je        near ptr M00_L26
        xor       r14d,r14d
        mov       rcx,[rsi]
-       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
-       cmp       rcx,rax
+       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
+       cmp       rcx,r11
        je        near ptr M00_L20
-       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rax
+       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
        je        near ptr M00_L18
-       mov       rdx,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       cmp       rcx,rdx
-       jne       near ptr M00_L29
-       mov       rsi,[rsi+8]
-       cmp       [rsi],rax
-       jne       near ptr M00_L28
-       cmp       dword ptr [rsi+10],0
-       je        near ptr M00_L27
-       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       rcx,r15
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       r13d,[rsi+14]
-       lea       rcx,[r15+8]
-       mov       rdx,rsi
-       call      CORINFO_HELP_ASSIGN_REF
-       xor       ecx,ecx
-       mov       [r15+10],rcx
-       mov       [r15+18],r13d
-       mov       [r15+1C],ecx
+       mov       r11,offset MT_System.Collections.ObjectModel.ObservableCollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
+       cmp       rcx,r11
+       jne       near ptr M00_L27
+       mov       rcx,[rsi+8]
+       mov       r11,7FFA2E201758
+       call      qword ptr [r11]
+       mov       rcx,rax
 M00_L01:
-       mov       [rbp-40],r15
+       mov       [rbp-40],rcx
        cmp       qword ptr [rbp-40],0
-       je        near ptr M00_L05
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
-       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       mov       r13,rcx
-       cmp       rsi,r13
-       jne       near ptr M00_L05
-       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rcx
-       jne       near ptr M00_L05
+       je        near ptr M00_L06
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r15
+       jne       near ptr M00_L06
+       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],rdx
+       jne       near ptr M00_L06
 M00_L02:
-       lea       r12,[r15+8]
-       mov       rcx,[r12]
-       mov       rax,rcx
-       mov       edx,[r12+10]
-       cmp       edx,[rcx+14]
-       jne       near ptr M00_L08
-       mov       r8d,[r12+14]
+       lea       r13,[rcx+8]
+       mov       rdx,[r13]
+       mov       rax,rdx
+       mov       r8d,[r13+10]
+       cmp       r8d,[rdx+14]
+       jne       near ptr M00_L12
+       mov       r8d,[r13+14]
        cmp       r8d,[rax+10]
        jae       near ptr M00_L07
        mov       rdi,[rax+8]
        cmp       r8d,[rdi+8]
        jae       near ptr M00_L13
-       mov       ecx,r8d
-       mov       rdx,[rdi+rcx*8+10]
-       lea       rcx,[r12+8]
+       mov       edx,r8d
+       mov       rdx,[rdi+rdx*8+10]
+       lea       rcx,[r13+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r12+14]
-       mov       rdx,[r15+10]
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        near ptr M00_L09
-       cmp       dword ptr [rax+8],0
-       setg      r8b
-       movzx     r8d,r8b
+       inc       dword ptr [r13+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r12,[rdx+30]
+       test      r12,r12
+       je        near ptr M00_L08
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
 M00_L03:
-       test      r8d,r8d
+       test      eax,eax
        je        short M00_L02
        add       r14d,1
        jo        near ptr M00_L14
        jmp       short M00_L02
 M00_L04:
-       add       r14d,1
-       jo        near ptr M00_L14
-M00_L05:
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r13
-       jne       near ptr M00_L10
-       lea       r12,[r15+8]
-       mov       rcx,[r12]
-       mov       rax,rcx
-       mov       edx,[r12+10]
-       cmp       edx,[rcx+14]
-       jne       short M00_L08
-       mov       r8d,[r12+14]
-       cmp       r8d,[rax+10]
-       jae       short M00_L07
-       mov       rcx,[rax+8]
-       cmp       r8d,[rcx+8]
+       mov       rdx,[rax+8]
+       cmp       r8d,[rdx+8]
        jae       near ptr M00_L13
-       mov       edx,r8d
-       mov       rdx,[rcx+rdx*8+10]
-       lea       rcx,[r12+8]
+       mov       eax,r8d
+       mov       rdx,[rdx+rax*8+10]
+       lea       rcx,[r13+8]
        call      CORINFO_HELP_ASSIGN_REF
-       inc       dword ptr [r12+14]
-       mov       rdx,[r15+10]
-       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
-       cmp       [rdi+18],rcx
-       jne       short M00_L11
-       mov       rax,[rdx+30]
-       test      rax,rax
-       je        short M00_L12
-       cmp       dword ptr [rax+8],0
-       setg      r8b
-       movzx     r8d,r8b
+       inc       dword ptr [r13+14]
+       mov       rcx,[rbp-40]
+       mov       rdx,[rcx+10]
+       mov       r11,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
+       cmp       [rdi+18],r11
+       jne       near ptr M00_L10
+       mov       r12,[rdx+30]
+       test      r12,r12
+       je        near ptr M00_L11
+       cmp       dword ptr [r12+8],0
+       setg      al
+       movzx     eax,al
+M00_L05:
+       test      eax,eax
+       je        short M00_L06
+       add       r14d,1
+       jo        near ptr M00_L14
 M00_L06:
-       test      r8d,r8d
-       je        near ptr M00_L05
-       jmp       near ptr M00_L04
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r15
+       jne       short M00_L09
+       lea       r13,[rcx+8]
+       mov       rax,[r13]
+       mov       edx,[r13+10]
+       mov       r8,[r13]
+       cmp       edx,[r8+14]
+       jne       short M00_L12
+       mov       r8d,[r13+14]
+       cmp       r8d,[rax+10]
+       jb        near ptr M00_L04
 M00_L07:
        xor       eax,eax
-       mov       [r12+8],rax
-       mov       dword ptr [r12+14],0FFFFFFFF
+       mov       [r13+8],rax
+       mov       dword ptr [r13+14],0FFFFFFFF
        jmp       short M00_L15
 M00_L08:
-       call      qword ptr [7FFA2E53C0D8]
-       int       3
-M00_L09:
-       xor       r8d,r8d
+       xor       eax,eax
        jmp       near ptr M00_L03
-M00_L10:
-       mov       rcx,r15
-       mov       r11,7FFA2E2013A0
+M00_L09:
+       mov       r11,7FFA2E201740
        call      qword ptr [r11]
        test      eax,eax
        je        short M00_L15
-       mov       rcx,r15
-       mov       r11,7FFA2E2013A8
+       mov       rcx,[rbp-40]
+       mov       r11,7FFA2E201748
        call      qword ptr [r11]
        mov       rdx,rax
-M00_L11:
+M00_L10:
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
-       mov       r8d,eax
-       jmp       short M00_L06
+       mov       rcx,[rbp-40]
+       jmp       near ptr M00_L05
+M00_L11:
+       xor       eax,eax
+       jmp       near ptr M00_L05
 M00_L12:
-       xor       r8d,r8d
-       jmp       short M00_L06
+       call      qword ptr [7FFA2E2BFC48]
+       int       3
 M00_L13:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
        call      CORINFO_HELP_OVERFLOW
        int       3
 M00_L15:
-       cmp       rsi,r13
-       jne       near ptr M00_L30
+       cmp       rsi,r15
+       jne       near ptr M00_L28
 M00_L16:
        test      r14d,r14d
        setg      al
        mov       r15d,[rsi+10]
        mov       r13,[rsi+8]
        cmp       [r13+8],r15d
        jb        short M00_L19
        add       r13,10
        jmp       short M00_L21
 M00_L19:
-       call      qword ptr [7FFA2E5379A8]
+       call      qword ptr [7FFA2E2BF480]
        int       3
 M00_L20:
        lea       r13,[rsi+10]
        mov       rdx,[rsi+r13]
        mov       rcx,[rdi+8]
        call      qword ptr [rdi+18]
        test      eax,eax
        je        short M00_L23
        jmp       short M00_L22
 M00_L25:
        mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,285EAC02AB8
+       mov       rdx,271B7C00B80
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        call      qword ptr [7FFA2E2B6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,285EAC02AC0
+       mov       rcx,271B7C00B88
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        jmp       near ptr M00_L00
        xor       eax,eax
        jmp       near ptr M00_L17
 M00_L27:
-       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
-       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rcx,285EAC02C38
-       mov       r15,[rcx]
-       jmp       near ptr M00_L01
-M00_L28:
        mov       rcx,rsi
-       mov       r11,7FFA2E2013B8
+       mov       r11,7FFA2E201738
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       rcx,rax
        jmp       near ptr M00_L01
-M00_L29:
-       mov       rcx,rsi
-       mov       r11,7FFA2E201398
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M00_L01
-M00_L30:
-       mov       rcx,r15
-       mov       r11,7FFA2E2013B0
+M00_L28:
+       mov       rcx,[rbp-40]
+       mov       r11,7FFA2E201750
        call      qword ptr [r11]
        jmp       near ptr M00_L16
        sub       rsp,28
        cmp       qword ptr [rbp-40],0
-       je        short M00_L31
-       mov       r15,[rbp-40]
-       mov       rsi,[r15]
-       mov       r13,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
-       cmp       rsi,r13
-       je        short M00_L31
-       mov       rcx,r15
-       mov       r11,7FFA2E2013B0
+       je        short M00_L29
+       mov       rcx,[rbp-40]
+       mov       rsi,[rcx]
+       mov       r15,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Enumerator
+       cmp       rsi,r15
+       je        short M00_L29
+       mov       r11,7FFA2E201750
        call      qword ptr [r11]
-M00_L31:
+M00_L29:
        nop
        add       rsp,28
        ret
-; Total bytes of code 999
+; Total bytes of code 884
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
        mov       rax,[rdx+30]
        test      rax,rax
        je        short M01_L01
        cmp       dword ptr [rax+8],0
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M01_L00
 ; Total bytes of code 24
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M02_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M02_L00:
-       call      qword ptr [7FFA2EBE5368]
+       call      qword ptr [7FFA2EA27B88]
        int       3
 ; Total bytes of code 44
-; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
-       mov       rax,[rcx+20]
-       mov       rax,[rax-18]
-       mov       rdx,rax
-       test      dl,1
-       jne       short M03_L00
-       ret
-M03_L00:
-       jmp       qword ptr [7FFA2E2B5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
-; Total bytes of code 23
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E211088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E231088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E201088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E211088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E221088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E231290
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E2010D0
+       mov       r11,7FFA2E201710
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E211088
+       mov       r11,7FFA2E231088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E211088
+       mov       r11,7FFA2E201088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff

```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E211088
+       mov       r11,7FFA2E221088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E211088
+       mov       r11,7FFA2E231290
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E211088
+       mov       r11,7FFA2E201710
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E231088
+       mov       r11,7FFA2E201088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E231088
+       mov       r11,7FFA2E211088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E231088
+       mov       r11,7FFA2E221088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E231088
+       mov       r11,7FFA2E231290
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E231088
+       mov       r11,7FFA2E201710
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E201088
+       mov       r11,7FFA2E211088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E201088
+       mov       r11,7FFA2E221088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E201088
+       mov       r11,7FFA2E231290
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E201088
+       mov       r11,7FFA2E201710
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E211088
+       mov       r11,7FFA2E221088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E211088
+       mov       r11,7FFA2E231290
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E211088
+       mov       r11,7FFA2E201710
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E221088
+       mov       r11,7FFA2E231290
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E221088
+       mov       r11,7FFA2E201710
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E231290
+       mov       r11,7FFA2E201710
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E211088
+       mov       r11,7FFA2E231088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E211088
+       mov       r11,7FFA2E231088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E211088
+       mov       r11,7FFA2E231088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E211088
+       mov       r11,7FFA2E231088
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E211088
+       mov       r11,7FFA2E210CC0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E211088
+       mov       r11,7FFA2E2312E0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E211088
+       mov       r11,7FFA2E221710
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff

```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff

```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff

```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E231088
+       mov       r11,7FFA2E210CC0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E231088
+       mov       r11,7FFA2E2312E0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E231088
+       mov       r11,7FFA2E221710
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff

```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff

```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E231088
+       mov       r11,7FFA2E210CC0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E231088
+       mov       r11,7FFA2E2312E0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E231088
+       mov       r11,7FFA2E221710
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff

```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E231088
+       mov       r11,7FFA2E210CC0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E231088
+       mov       r11,7FFA2E2312E0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E231088
+       mov       r11,7FFA2E221710
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E231088
+       mov       r11,7FFA2E210CC0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E231088
+       mov       r11,7FFA2E2312E0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E231088
+       mov       r11,7FFA2E221710
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E210CC0
+       mov       r11,7FFA2E2312E0
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E210CC0
+       mov       r11,7FFA2E221710
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
**Diff for HasItems method between:**
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
.NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M00_L02:
-       mov       r11,7FFA2E2312E0
+       mov       r11,7FFA2E221710
        call      qword ptr [r11]
        mov       esi,eax
        jmp       short M00_L00
```
