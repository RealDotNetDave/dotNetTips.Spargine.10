## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ExecutionHelperBenchmark.ProgressiveRetrySuccess()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,25D1EC00D48
       mov       rcx,[rcx]
       mov       edx,3
       mov       r8d,1
       xor       r9d,r9d
       call      qword ptr [7FFB5E7CDB30]; DotNetTips.Spargine.Core.ExecutionHelper.ProgressiveRetry(System.Action, Byte, Int32, Microsoft.Extensions.Logging.ILogger)
       mov       [rsp+28],rax
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.ExecutionHelper.ProgressiveRetry(System.Action, Byte, Int32, Microsoft.Extensions.Logging.ILogger)
; 		operation = operation.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		retryCount = retryCount.ArgumentInRange(min: 1, max: byte.MaxValue);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		retryWaitMilliseconds = retryWaitMilliseconds.ArgumentInRange(min: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var attempts = 0;
; 		^^^^^^^^^^^^^^^^^
; 		var result = new SimpleResult<int>();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var shouldLog = logger != null && logger.IsEnabled(LogLevel.Error);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				attempts++;
; 				^^^^^^^^^^^
; 				operation();
; 				^^^^^^^^^^^^
; 				result.SetValue(attempts);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return result;
; 				^^^^^^^^^^^^^^
; 	}
; 	^
; 			catch (Exception ex) // Catching Exception since the type of Exception is unknown.
; 			^^^^^^^^^^^^^^^^^^^^
; 				result.AddException(ex);
; 				^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (shouldLog)
; 				^^^^^^^^^^^^^^
; 					logger!.LogExceptionMessage(string.Format(CultureInfo.InvariantCulture, _attemptFailedFormat, attempts), ex);
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (attempts == retryCount)
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 					result.SetValue(attempts);
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^
; 					return result;
; 					^^^^^^^^^^^^^^
; 				Thread.Sleep(CalculateDelay(retryWaitMilliseconds, attempts));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,148
       lea       rbp,[rsp+180]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       mov       r8d,edx
       cmp       qword ptr [rbp+10],0
       je        near ptr M01_L81
       mov       rcx,[rbp+10]
       mov       [rbp+10],rcx
       test      r8b,r8b
       jbe       near ptr M01_L82
       cmp       r8b,0FF
       ja        near ptr M01_L82
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       ebx,[rbp+20]
       cmp       dword ptr [rbp+20],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L84
M01_L00:
       mov       [rbp+20],ebx
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.SimpleResult<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<System.Exception>+WorkStealingQueue>
       call      CORINFO_HELP_NEWFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<System.Exception>+WorkStealingQueue>+LinkedSlot
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+18],rcx
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+8],rcx
       mov       byte ptr [r14+1D],0
       mov       rcx,25D34C001A8
       mov       r15,[rcx]
       mov       r13,[r15+18]
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFB5E7CDEF0]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-140],r13
       mov       [rbp-7C],ecx
       mov       r13,[r15+10]
       mov       r12d,[r13+10]
       mov       r9d,r12d
       mov       [rbp-4C],r9d
       test      r9d,r9d
       jg        short M01_L01
       mov       eax,[r15+20]
       jmp       short M01_L02
M01_L01:
       mov       rax,r13
       lea       edx,[r9-1]
       cmp       edx,r12d
       jae       near ptr M01_L35
       mov       rcx,[rax+8]
       cmp       edx,[rcx+8]
       jae       near ptr M01_L36
       mov       eax,[rcx+rdx*4+10]
       mov       [rbp-50],eax
       mov       eax,[rbp-50]
       mov       r9d,[rbp-4C]
M01_L02:
       mov       rdx,[r15+8]
       mov       ecx,[rdx+38]
       sub       ecx,[rdx+40]
       inc       ecx
       cmp       [r13],r13b
       test      ecx,ecx
       jl        near ptr M01_L24
       mov       rdx,[r13+8]
       cmp       [rdx+8],ecx
       jge       near ptr M01_L05
       mov       rdx,[r13+8]
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edx,4
M01_L03:
       mov       r8d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r8d
       cmp       edx,ecx
       cmovl     edx,ecx
       cmp       edx,r12d
       jl        near ptr M01_L25
       mov       rcx,[r13+8]
       cmp       [rcx+8],edx
       je        near ptr M01_L05
       test      edx,edx
       jle       near ptr M01_L34
       mov       [rbp-50],eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0C8],rax
       test      r12d,r12d
       jle       short M01_L04
       mov       rcx,[r13+8]
       mov       rdx,rcx
       mov       [rbp-0D0],rdx
       test      rdx,rdx
       je        near ptr M01_L31
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M01_L30
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L29
       cmp       r12d,[rdx+8]
       ja        near ptr M01_L28
       cmp       r12d,[rax+8]
       ja        near ptr M01_L27
       mov       r8d,r12d
       movzx     r10d,word ptr [rcx]
       imul      r8,r10
       add       rdx,10
       lea       r10,[rax+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M01_L26
       mov       rcx,r10
       call      qword ptr [7FFB5E1A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-0C8]
M01_L04:
       lea       rcx,[r13+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-50]
       mov       r9d,[rbp-4C]
M01_L05:
       mov       rcx,[r13+8]
       mov       ecx,[rcx+8]
       mov       r13,[r15+8]
       mov       [rbp-50],eax
       mov       r12d,eax
       cmp       qword ptr [r13+8],0
       jne       near ptr M01_L06
       xor       ecx,ecx
       call      qword ptr [7FFB5E1A5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-60],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0F0],rax
       movsxd    rdx,dword ptr [rbp-60]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0F8],rax
       mov       dword ptr [r13+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-60]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r13+30],rax
       lea       rcx,[r13+8]
       mov       rdx,[rbp-0F0]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,[rbp-0F8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9d,[rbp-4C]
M01_L06:
       mov       r8,[r13+10]
       mov       [rbp-0D8],r8
       mov       r10,[r13+18]
       mov       [rbp-0E0],r10
       test      r10,r10
       je        short M01_L08
       mov       rcx,r10
       mov       edx,r12d
       mov       r11,7FFB5E0F0B28
       call      qword ptr [r11]
       jmp       short M01_L09
M01_L07:
       mov       rdx,[r13+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       near ptr M01_L03
M01_L08:
       mov       r11d,r12d
       mov       eax,r11d
M01_L09:
       mov       [rbp-58],eax
       xor       r10d,r10d
       mov       [rbp-5C],r10d
       mov       rdx,[r13+8]
       mov       ecx,eax
       imul      rcx,[r13+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M01_L36
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-0E8],r9
       mov       r11d,[r9]
       dec       r11d
       mov       r8,[rbp-0E0]
       test      r8,r8
       je        near ptr M01_L12
       mov       rcx,[rbp-0D8]
       cmp       [rcx+8],r11d
       jbe       near ptr M01_L15
M01_L10:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-0A8],r11
       cmp       [rcx+r11+10],eax
       jne       short M01_L11
       mov       [rbp-0D8],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-50]
       mov       r11,7FFB5E0F0B20
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-0D8]
       mov       r8,[rbp-0E0]
       mov       r11,[rbp-0A8]
       jne       near ptr M01_L23
M01_L11:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-5C]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M01_L22
       cmp       [rcx+8],r11d
       mov       [rbp-5C],r10d
       mov       eax,[rbp-58]
       ja        short M01_L10
       jmp       short M01_L15
M01_L12:
       mov       rcx,[rbp-0D8]
       cmp       [rcx+8],r11d
       jbe       short M01_L15
M01_L13:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M01_L14
       mov       edx,[rbp-50]
       cmp       [rcx+r11+18],edx
       je        near ptr M01_L23
M01_L14:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-5C]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M01_L22
       cmp       [rcx+8],r11d
       mov       [rbp-5C],r10d
       mov       eax,[rbp-58]
       ja        short M01_L13
M01_L15:
       cmp       dword ptr [r13+40],0
       jg        short M01_L17
       mov       r12d,[r13+38]
       cmp       [rcx+8],r12d
       jne       short M01_L16
       mov       ecx,[r13+38]
       call      qword ptr [7FFB5E1AF570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FFB5E7CE508]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       r8,[r13+8]
       mov       ecx,[rbp-58]
       mov       edx,ecx
       imul      rdx,[r13+30]
       shr       rdx,20
       inc       rdx
       mov       r9d,[r8+8]
       mov       eax,r9d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r9d
       jae       near ptr M01_L36
       mov       edx,edx
       lea       r9,[r8+rdx*4+10]
       mov       r8,r9
       mov       [rbp-0E8],r8
       mov       eax,ecx
M01_L16:
       lea       r8d,[r12+1]
       mov       [r13+38],r8d
       mov       rcx,[r13+10]
       mov       r8,rcx
       mov       rcx,r8
       jmp       short M01_L18
M01_L17:
       mov       r8d,[r13+3C]
       mov       r12d,r8d
       cmp       r8d,[rcx+8]
       jae       near ptr M01_L36
       shl       r8,4
       mov       r8d,[rcx+r8+14]
       neg       r8d
       add       r8d,0FFFFFFFD
       mov       [r13+3C],r8d
       dec       dword ptr [r13+40]
M01_L18:
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L36
       mov       r8d,r12d
       shl       r8,4
       lea       r8,[rcx+r8+10]
       mov       [r8],eax
       mov       r9,[rbp-0E8]
       mov       ecx,[r9]
       dec       ecx
       mov       [r8+4],ecx
       mov       edx,[rbp-50]
       mov       [r8+8],edx
       mov       byte ptr [r8+0C],0
       inc       r12d
       mov       [r9],r12d
       inc       dword ptr [r13+44]
       mov       r13d,[rbp-4C]
       test      r13d,r13d
       jg        short M01_L19
       mov       [rbp-50],edx
       lea       r8d,[rdx+1]
       mov       [r15+20],r8d
       jmp       short M01_L21
M01_L19:
       mov       r12,[r15+10]
       lea       r9d,[r13-1]
       mov       r8d,[r12+10]
       cmp       r9d,r8d
       jae       near ptr M01_L35
       dec       r8d
       mov       [r12+10],r8d
       cmp       r9d,r8d
       jl        near ptr M01_L37
M01_L20:
       inc       dword ptr [r12+14]
       mov       [rbp-50],edx
M01_L21:
       inc       dword ptr [r15+24]
       jmp       near ptr M01_L38
M01_L22:
       call      qword ptr [7FFB5E1AF498]
       int       3
M01_L23:
       mov       ecx,r12d
       call      qword ptr [7FFB5E86C2E8]
       int       3
M01_L24:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB5E737408]
       int       3
M01_L25:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB5E737408]
       int       3
M01_L26:
       mov       rcx,r10
       call      qword ptr [7FFB5E1A57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-0C8]
       jmp       near ptr M01_L04
M01_L27:
       jmp       short M01_L32
M01_L28:
       jmp       short M01_L32
M01_L29:
       jmp       short M01_L32
M01_L30:
       jmp       short M01_L32
M01_L31:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       jmp       short M01_L33
M01_L32:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFB5E7CF738]; System.Array.GetLowerBound(Int32)
       mov       [rbp-54],eax
       mov       rax,[rbp-0C8]
M01_L33:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFB5E7CF738]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r12d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-0D0]
       mov       edx,[rbp-54]
       mov       r8,[rbp-0C8]
       call      qword ptr [7FFB5E7CF750]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-0C8]
       jmp       near ptr M01_L04
M01_L34:
       mov       rcx,29DB3B507D8
       mov       [r13+8],rcx
       jmp       near ptr M01_L05
M01_L35:
       call      qword ptr [7FFB5E7CEBE0]
       int       3
M01_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L37:
       mov       [rbp-50],edx
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[r12+8]
       mov       rcx,[r12+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFB5E6CE400]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-50]
       jmp       near ptr M01_L20
M01_L38:
       mov       rcx,[rbp-140]
       mov       edx,[rbp-7C]
       call      qword ptr [7FFB5E7CE040]; System.Threading.Lock.Exit(ThreadId)
       mov       r15d,[rbp-50]
       mov       ecx,r15d
       not       ecx
       mov       [r14+18],ecx
       mov       byte ptr [r14+1C],1
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,25D34C001C0
       mov       rdi,[rcx]
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Object[]
       mov       edx,0C
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       xor       r13d,r13d
M01_L39:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[r15+r13*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r13d,1
       jo        near ptr M01_L88
       cmp       r13d,0C
       jl        short M01_L39
       mov       edx,0C
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       edx,1F
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<System.Exception>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<System.Exception>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-100],rax
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rbp-100]
       lea       rcx,[r12+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+1C],1
       mov       dword ptr [r14+18],2
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<System.String>+WorkStealingQueue>
       call      CORINFO_HELP_NEWFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<System.String>+WorkStealingQueue>+LinkedSlot
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+18],rcx
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+8],rcx
       mov       byte ptr [r14+1D],0
       mov       rcx,25D34C001D8
       mov       r15,[rcx]
       mov       r13,[r15+18]
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFB5E7CDEF0]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-148],r13
       mov       [rbp-80],ecx
       mov       r13,[r15+10]
       mov       r12d,[r13+10]
       mov       r9d,r12d
       mov       [rbp-64],r9d
       test      r9d,r9d
       jg        short M01_L40
       mov       eax,[r15+20]
       jmp       short M01_L41
M01_L40:
       mov       rax,r13
       lea       edx,[r9-1]
       cmp       edx,r12d
       jae       near ptr M01_L68
       mov       rcx,[rax+8]
       cmp       edx,[rcx+8]
       jae       near ptr M01_L69
       mov       eax,[rcx+rdx*4+10]
       mov       [rbp-68],eax
       mov       eax,[rbp-68]
       mov       r9d,[rbp-64]
M01_L41:
       mov       rdx,[r15+8]
       mov       ecx,[rdx+38]
       sub       ecx,[rdx+40]
       inc       ecx
       cmp       [r13],r13b
       test      ecx,ecx
       jl        near ptr M01_L64
       mov       rdx,[r13+8]
       mov       r8,rdx
       cmp       [r8+8],ecx
       jge       near ptr M01_L44
       cmp       dword ptr [r8+8],0
       jne       near ptr M01_L46
       mov       edx,4
M01_L42:
       mov       r10d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r10d
       cmp       edx,ecx
       cmovl     edx,ecx
       cmp       edx,r12d
       jl        near ptr M01_L65
       mov       [rbp-150],r8
       cmp       [r8+8],edx
       je        short M01_L44
       test      edx,edx
       jle       near ptr M01_L66
       mov       [rbp-68],eax
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-108],rax
       test      r12d,r12d
       jle       short M01_L43
       mov       rcx,[rbp-150]
       mov       r8d,r12d
       mov       rdx,rax
       call      qword ptr [7FFB5E1AF5A0]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,[rbp-108]
M01_L43:
       lea       rcx,[r13+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-68]
       mov       r9d,[rbp-64]
M01_L44:
       mov       rcx,[r13+8]
       mov       ecx,[rcx+8]
       mov       r13,[r15+8]
       mov       [rbp-68],eax
       mov       r12d,eax
       cmp       qword ptr [r13+8],0
       jne       near ptr M01_L45
       xor       ecx,ecx
       call      qword ptr [7FFB5E1A5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-78],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-128],rax
       movsxd    rdx,dword ptr [rbp-78]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-130],rax
       mov       dword ptr [r13+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-78]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r13+30],rax
       lea       rcx,[r13+8]
       mov       rdx,[rbp-128]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,[rbp-130]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9d,[rbp-64]
M01_L45:
       mov       r8,[r13+10]
       mov       [rbp-110],r8
       mov       r10,[r13+18]
       mov       [rbp-118],r10
       test      r10,r10
       je        short M01_L47
       mov       rcx,r10
       mov       edx,r12d
       mov       r11,7FFB5E0F0B38
       call      qword ptr [r11]
       jmp       short M01_L48
M01_L46:
       mov       edx,[r8+8]
       add       edx,edx
       jmp       near ptr M01_L42
M01_L47:
       mov       r11d,r12d
       mov       eax,r11d
M01_L48:
       mov       [rbp-6C],eax
       xor       r10d,r10d
       mov       [rbp-70],r10d
       mov       rdx,[r13+8]
       mov       ecx,eax
       imul      rcx,[r13+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M01_L69
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-120],r9
       mov       r11d,[r9]
       dec       r11d
       cmp       qword ptr [rbp-118],0
       je        near ptr M01_L53
       mov       rcx,[rbp-110]
       mov       edx,[rcx+8]
       cmp       edx,r11d
       jbe       near ptr M01_L52
M01_L49:
       cmp       r11d,edx
       jae       near ptr M01_L69
       mov       ecx,r11d
       shl       rcx,4
       mov       [rbp-0B0],rcx
       mov       r8,[rbp-110]
       cmp       [r8+rcx+10],eax
       jne       short M01_L50
       mov       [rbp-74],r11d
       mov       [rbp-0B4],edx
       cmp       r11d,edx
       jae       near ptr M01_L69
       mov       [rbp-110],r8
       mov       edx,[r8+rcx+18]
       mov       rcx,[rbp-118]
       mov       r8d,[rbp-68]
       mov       r11,7FFB5E0F0B30
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       mov       r8,[rbp-110]
       mov       r11d,[rbp-74]
       jne       near ptr M01_L63
M01_L50:
       cmp       r11d,edx
       jae       near ptr M01_L69
       mov       r11d,[r8+rcx+14]
       mov       r10d,[rbp-70]
       inc       r10d
       mov       [rbp-70],r10d
       cmp       edx,r10d
       jb        near ptr M01_L62
       cmp       edx,r11d
       mov       [rbp-110],r8
       mov       eax,[rbp-6C]
       ja        near ptr M01_L49
       jmp       short M01_L52
M01_L51:
       mov       [rbp-110],r8
M01_L52:
       cmp       dword ptr [r13+40],0
       jle       near ptr M01_L56
       mov       r8d,[r13+3C]
       mov       r12d,r8d
       cmp       r8d,edx
       jae       near ptr M01_L69
       shl       r8,4
       mov       rcx,[rbp-110]
       mov       r8d,[rcx+r8+14]
       neg       r8d
       add       r8d,0FFFFFFFD
       mov       [r13+3C],r8d
       dec       dword ptr [r13+40]
       jmp       near ptr M01_L58
M01_L53:
       mov       r8,[rbp-110]
       mov       edx,[r8+8]
       cmp       edx,r11d
       jbe       short M01_L51
M01_L54:
       cmp       r11d,edx
       jae       near ptr M01_L69
       mov       ecx,r11d
       shl       rcx,4
       cmp       [r8+rcx+10],eax
       jne       short M01_L55
       cmp       r11d,edx
       jae       near ptr M01_L69
       mov       r10d,[rbp-68]
       cmp       [r8+rcx+18],r10d
       mov       [rbp-68],r10d
       je        near ptr M01_L63
M01_L55:
       cmp       r11d,edx
       jae       near ptr M01_L69
       mov       r11d,[r8+rcx+14]
       mov       r10d,[rbp-70]
       inc       r10d
       cmp       edx,r10d
       jb        near ptr M01_L62
       cmp       edx,r11d
       mov       [rbp-70],r10d
       mov       eax,[rbp-6C]
       ja        short M01_L54
       jmp       near ptr M01_L67
M01_L56:
       mov       r12d,[r13+38]
       cmp       edx,r12d
       jne       short M01_L57
       mov       ecx,[r13+38]
       call      qword ptr [7FFB5E1AF570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FFB5E7CE508]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       r8,[r13+8]
       mov       ecx,[rbp-6C]
       mov       edx,ecx
       imul      rdx,[r13+30]
       shr       rdx,20
       inc       rdx
       mov       r9d,[r8+8]
       mov       eax,r9d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r9d
       jae       near ptr M01_L69
       mov       edx,edx
       lea       r9,[r8+rdx*4+10]
       mov       r8,r9
       mov       [rbp-120],r8
       mov       eax,ecx
M01_L57:
       lea       r8d,[r12+1]
       mov       [r13+38],r8d
       mov       rcx,[r13+10]
       mov       r8,rcx
       mov       rcx,r8
M01_L58:
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L69
       mov       r8d,r12d
       shl       r8,4
       lea       r8,[rcx+r8+10]
       mov       [r8],eax
       mov       r9,[rbp-120]
       mov       ecx,[r9]
       dec       ecx
       mov       [r8+4],ecx
       mov       eax,[rbp-68]
       mov       [r8+8],eax
       mov       byte ptr [r8+0C],0
       inc       r12d
       mov       [r9],r12d
       inc       dword ptr [r13+44]
       mov       r13d,[rbp-64]
       test      r13d,r13d
       jg        short M01_L59
       mov       [rbp-68],eax
       lea       r8d,[rax+1]
       mov       [r15+20],r8d
       jmp       short M01_L61
M01_L59:
       mov       r12,[r15+10]
       lea       r9d,[r13-1]
       mov       r8d,[r12+10]
       cmp       r9d,r8d
       jae       short M01_L68
       dec       r8d
       mov       [r12+10],r8d
       cmp       r9d,r8d
       jl        short M01_L70
M01_L60:
       inc       dword ptr [r12+14]
       mov       [rbp-68],eax
M01_L61:
       inc       dword ptr [r15+24]
       jmp       near ptr M01_L71
M01_L62:
       call      qword ptr [7FFB5E1AF498]
       int       3
M01_L63:
       mov       ecx,r12d
       call      qword ptr [7FFB5E86C2E8]
       int       3
M01_L64:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB5E737408]
       int       3
M01_L65:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB5E737408]
       int       3
M01_L66:
       mov       rcx,29DB3B507D8
       mov       [r13+8],rcx
       jmp       near ptr M01_L44
M01_L67:
       mov       [rbp-110],r8
       jmp       near ptr M01_L52
M01_L68:
       call      qword ptr [7FFB5E7CEBE0]
       int       3
M01_L69:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L70:
       mov       [rbp-68],eax
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[r12+8]
       mov       rcx,[r12+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFB5E6CE400]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       eax,[rbp-68]
       jmp       near ptr M01_L60
M01_L71:
       cmp       qword ptr [rbp-148],0
       je        short M01_L72
       mov       rcx,[rbp-148]
       mov       edx,[rbp-80]
       cmp       [rcx],ecx
       call      qword ptr [7FFB5E7CE040]; System.Threading.Lock.Exit(ThreadId)
M01_L72:
       mov       eax,[rbp-68]
       mov       ecx,eax
       not       ecx
       mov       [r14+18],ecx
       mov       byte ptr [r14+1C],1
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,25D1EC00048
       mov       rdi,[rcx]
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Object[]
       mov       edx,0C
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       xor       r13d,r13d
M01_L73:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[r15+r13*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r13d,1
       jo        near ptr M01_L88
       cmp       r13d,0C
       jl        short M01_L73
       mov       edx,0C
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       edx,1F
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<System.String>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<System.String>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-138],rax
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rbp-138]
       lea       rcx,[r12+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+1C],1
       mov       dword ptr [r14+18],2
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       mov       [rbp-0C0],rbx
       cmp       qword ptr [rbp+28],0
       jne       near ptr M01_L87
       xor       ebx,ebx
M01_L74:
       movzx     ecx,bl
       mov       [rbp-40],ecx
M01_L75:
       nop
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M01_L78
       mov       [rbp-3C],ecx
       mov       rcx,[rbp+10]
       mov       rax,offset DotNetTips.Spargine.Core.BenchmarkTests.ExecutionHelperBenchmark+<>c.<.cctor>b__11_0()
       cmp       [rcx+18],rax
       jne       short M01_L79
       mov       rcx,29DB3B50A38
       call      00007FFBBDDC1BC0
       test      eax,eax
       je        short M01_L77
M01_L76:
       mov       ecx,[rbp-3C]
       mov       rax,[rbp-0C0]
       mov       [rax+20],ecx
       mov       byte ptr [rax+24],1
       jmp       short M01_L80
M01_L77:
       mov       rcx,29DB3B50A38
       call      qword ptr [7FFB5E3777F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       short M01_L76
M01_L78:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L79:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rax,[rbp+10]
       call      qword ptr [rax+18]
       jmp       short M01_L76
M01_L80:
       mov       rax,[rbp-0C0]
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L81:
       call      qword ptr [7FFB5E73F528]
       mov       ecx,1F89
       mov       rdx,7FFB5E474FD8
       call      qword ptr [7FFB5E1AF228]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FFB5E474FD8
       call      qword ptr [7FFB5E1AF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E1AD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,111F
       mov       rdx,7FFB5E474FD8
       call      qword ptr [7FFB5E1AF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E1AD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB5E86D158]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB5E73EFB8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L82:
       call      qword ptr [7FFB5E73FD80]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L83
       call      qword ptr [7FFB5E86D2D8]
       mov       rbx,rax
M01_L83:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,29DB3B50730
       call      qword ptr [7FFB5E43E6A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L84:
       movzx     ecx,byte ptr [rbp-48]
       test      cl,cl
       je        short M01_L85
       lea       rcx,[rbp-48]
       call      qword ptr [7FFB5E73FD68]
       mov       ebx,eax
       jmp       near ptr M01_L00
M01_L85:
       call      qword ptr [7FFB5E73FD80]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L86
       call      qword ptr [7FFB5E86D2D8]
       mov       rbx,rax
M01_L86:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,29DB3B50760
       call      qword ptr [7FFB5E43E6A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L87:
       mov       rcx,[rbp+28]
       mov       r11,7FFB5E0F0B18
       mov       edx,4
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L74
M01_L88:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,[rbp-0C0]
       mov       rdx,rbx
       call      qword ptr [7FFB5E7CDCC8]
       cmp       dword ptr [rbp-40],0
       je        near ptr M01_L91
       call      qword ptr [7FFB5E7C50C8]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       rsi,rax
       test      byte ptr [7FFB5E81A9A8],1
       jne       short M01_L89
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ExecutionHelper
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M01_L89:
       mov       rcx,25D34C001A0
       mov       rdx,[rcx]
       mov       rcx,rsi
       mov       r8d,[rbp-3C]
       call      qword ptr [7FFB5E7CDC68]
       mov       rsi,rax
       mov       rcx,[rbp+28]
       mov       r11,7FFB5E0F0B40
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L91
       mov       rcx,[rbp+28]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E952228
       call      qword ptr [7FFB5E1A5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,29DB3B50B00
       mov       [rbp-90],rcx
       mov       dword ptr [rbp-88],1F4
       mov       [rbp-0A0],rsi
       mov       rcx,29DB3B507A0
       mov       [rbp-98],rcx
       test      byte ptr [7FFB5E952068],1
       jne       short M01_L90
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogExceptionMessageStruct
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M01_L90:
       mov       r8,25D34C002A0
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rbp-90]
       lea       r9,[rbp-0A0]
       mov       rcx,[rbp+28]
       mov       [rsp+20],rbx
       mov       edx,4
       call      rdi
M01_L91:
       movzx     ecx,byte ptr [rbp+18]
       cmp       [rbp-3C],ecx
       je        short M01_L92
       mov       ecx,[rbp+20]
       imul      ecx,[rbp-3C]
       jo        short M01_L93
       call      qword ptr [7FFB5E1AF1B0]; System.Threading.Thread.Sleep(Int32)
       lea       rax,[M01_L75]
       add       rsp,38
       ret
M01_L92:
       mov       rcx,[rbp-0C0]
       mov       edx,[rbp-3C]
       call      qword ptr [7FFB5E7CDCB0]; DotNetTips.Spargine.Core.SimpleResult`1[[System.Int32, System.Private.CoreLib]].SetValue(Int32)
       lea       rax,[M01_L80]
       add       rsp,38
       ret
M01_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       cmp       qword ptr [rbp-140],0
       je        short M01_L94
       mov       rcx,[rbp-140]
       mov       edx,[rbp-7C]
       call      qword ptr [7FFB5E7CE040]; System.Threading.Lock.Exit(ThreadId)
M01_L94:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-148],0
       je        short M01_L95
       mov       rcx,[rbp-148]
       mov       edx,[rbp-80]
       cmp       [rcx],ecx
       call      qword ptr [7FFB5E7CE040]; System.Threading.Lock.Exit(ThreadId)
M01_L95:
       nop
       add       rsp,38
       ret
; Total bytes of code 4827
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ExecutionHelperBenchmark.ProgressiveRetryWithRetries()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,1F247400D50
       mov       rcx,[rcx]
       mov       edx,3
       mov       r8d,1
       xor       r9d,r9d
       call      qword ptr [7FFB5E77CDC8]; DotNetTips.Spargine.Core.ExecutionHelper.ProgressiveRetry(System.Action, Byte, Int32, Microsoft.Extensions.Logging.ILogger)
       mov       [rsp+28],rax
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Core.ExecutionHelper.ProgressiveRetry(System.Action, Byte, Int32, Microsoft.Extensions.Logging.ILogger)
; 		operation = operation.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		retryCount = retryCount.ArgumentInRange(min: 1, max: byte.MaxValue);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		retryWaitMilliseconds = retryWaitMilliseconds.ArgumentInRange(min: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var attempts = 0;
; 		^^^^^^^^^^^^^^^^^
; 		var result = new SimpleResult<int>();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var shouldLog = logger != null && logger.IsEnabled(LogLevel.Error);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				attempts++;
; 				^^^^^^^^^^^
; 				operation();
; 				^^^^^^^^^^^^
; 				result.SetValue(attempts);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return result;
; 				^^^^^^^^^^^^^^
; 	}
; 	^
; 			catch (Exception ex) // Catching Exception since the type of Exception is unknown.
; 			^^^^^^^^^^^^^^^^^^^^
; 				result.AddException(ex);
; 				^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (shouldLog)
; 				^^^^^^^^^^^^^^
; 					logger!.LogExceptionMessage(string.Format(CultureInfo.InvariantCulture, _attemptFailedFormat, attempts), ex);
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (attempts == retryCount)
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 					result.SetValue(attempts);
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^
; 					return result;
; 					^^^^^^^^^^^^^^
; 				Thread.Sleep(CalculateDelay(retryWaitMilliseconds, attempts));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,158
       lea       rbp,[rsp+190]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       mov       r8d,edx
       cmp       qword ptr [rbp+10],0
       je        near ptr M01_L81
       mov       rcx,[rbp+10]
       mov       [rbp+10],rcx
       test      r8b,r8b
       jbe       near ptr M01_L82
       cmp       r8b,0FF
       ja        near ptr M01_L82
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       ebx,[rbp+20]
       cmp       dword ptr [rbp+20],0
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L84
M01_L00:
       mov       [rbp+20],ebx
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.SimpleResult<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<System.Exception>+WorkStealingQueue>
       call      CORINFO_HELP_NEWFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<System.Exception>+WorkStealingQueue>+LinkedSlot
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+18],rcx
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+8],rcx
       mov       byte ptr [r14+1D],0
       mov       rcx,1F25D400168
       mov       r15,[rcx]
       mov       r13,[r15+18]
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFB5E77D188]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-148],r13
       mov       [rbp-7C],ecx
       mov       r13,[r15+10]
       mov       r12d,[r13+10]
       mov       r9d,r12d
       mov       [rbp-4C],r9d
       test      r9d,r9d
       jg        short M01_L01
       mov       eax,[r15+20]
       jmp       short M01_L02
M01_L01:
       mov       rax,r13
       lea       edx,[r9-1]
       cmp       edx,r12d
       jae       near ptr M01_L35
       mov       rcx,[rax+8]
       cmp       edx,[rcx+8]
       jae       near ptr M01_L36
       mov       eax,[rcx+rdx*4+10]
       mov       [rbp-50],eax
       mov       eax,[rbp-50]
       mov       r9d,[rbp-4C]
M01_L02:
       mov       rdx,[r15+8]
       mov       ecx,[rdx+38]
       sub       ecx,[rdx+40]
       inc       ecx
       cmp       [r13],r13b
       test      ecx,ecx
       jl        near ptr M01_L24
       mov       rdx,[r13+8]
       cmp       [rdx+8],ecx
       jge       near ptr M01_L05
       mov       rdx,[r13+8]
       cmp       dword ptr [rdx+8],0
       jne       near ptr M01_L07
       mov       edx,4
M01_L03:
       mov       r8d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r8d
       cmp       edx,ecx
       cmovl     edx,ecx
       cmp       edx,r12d
       jl        near ptr M01_L25
       mov       rcx,[r13+8]
       cmp       [rcx+8],edx
       je        near ptr M01_L05
       test      edx,edx
       jle       near ptr M01_L34
       mov       [rbp-50],eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0D0],rax
       test      r12d,r12d
       jle       short M01_L04
       mov       rcx,[r13+8]
       mov       rdx,rcx
       mov       [rbp-0D8],rdx
       test      rdx,rdx
       je        near ptr M01_L31
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M01_L30
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L29
       cmp       r12d,[rdx+8]
       ja        near ptr M01_L28
       cmp       r12d,[rax+8]
       ja        near ptr M01_L27
       mov       r8d,r12d
       movzx     r10d,word ptr [rcx]
       imul      r8,r10
       add       rdx,10
       lea       r10,[rax+10]
       test      dword ptr [rcx],1000000
       jne       near ptr M01_L26
       mov       rcx,r10
       call      qword ptr [7FFB5E175818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-0D0]
M01_L04:
       lea       rcx,[r13+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-50]
       mov       r9d,[rbp-4C]
M01_L05:
       mov       rcx,[r13+8]
       mov       ecx,[rcx+8]
       mov       r13,[r15+8]
       mov       [rbp-50],eax
       mov       r12d,eax
       cmp       qword ptr [r13+8],0
       jne       near ptr M01_L06
       xor       ecx,ecx
       call      qword ptr [7FFB5E175A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-60],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0F8],rax
       movsxd    rdx,dword ptr [rbp-60]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-100],rax
       mov       dword ptr [r13+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-60]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r13+30],rax
       lea       rcx,[r13+8]
       mov       rdx,[rbp-0F8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,[rbp-100]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9d,[rbp-4C]
M01_L06:
       mov       r8,[r13+10]
       mov       [rbp-0E0],r8
       mov       r10,[r13+18]
       mov       [rbp-0E8],r10
       test      r10,r10
       je        short M01_L08
       mov       rcx,r10
       mov       edx,r12d
       mov       r11,7FFB5E0C0B70
       call      qword ptr [r11]
       jmp       short M01_L09
M01_L07:
       mov       rdx,[r13+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       near ptr M01_L03
M01_L08:
       mov       r11d,r12d
       mov       eax,r11d
M01_L09:
       mov       [rbp-58],eax
       xor       r10d,r10d
       mov       [rbp-5C],r10d
       mov       rdx,[r13+8]
       mov       ecx,eax
       imul      rcx,[r13+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M01_L36
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-0F0],r9
       mov       r11d,[r9]
       dec       r11d
       mov       r8,[rbp-0E8]
       test      r8,r8
       je        near ptr M01_L12
       mov       rcx,[rbp-0E0]
       cmp       [rcx+8],r11d
       jbe       near ptr M01_L15
M01_L10:
       mov       r11d,r11d
       shl       r11,4
       mov       [rbp-0A8],r11
       cmp       [rcx+r11+10],eax
       jne       short M01_L11
       mov       [rbp-0E0],rcx
       mov       edx,[rcx+r11+18]
       mov       rcx,r8
       mov       r8d,[rbp-50]
       mov       r11,7FFB5E0C0B68
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-0E0]
       mov       r8,[rbp-0E8]
       mov       r11,[rbp-0A8]
       jne       near ptr M01_L23
M01_L11:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-5C]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M01_L22
       cmp       [rcx+8],r11d
       mov       [rbp-5C],r10d
       mov       eax,[rbp-58]
       ja        short M01_L10
       jmp       short M01_L15
M01_L12:
       mov       rcx,[rbp-0E0]
       cmp       [rcx+8],r11d
       jbe       short M01_L15
M01_L13:
       mov       r11d,r11d
       shl       r11,4
       cmp       [rcx+r11+10],eax
       jne       short M01_L14
       mov       edx,[rbp-50]
       cmp       [rcx+r11+18],edx
       je        near ptr M01_L23
M01_L14:
       mov       r11d,[rcx+r11+14]
       mov       r10d,[rbp-5C]
       inc       r10d
       cmp       [rcx+8],r10d
       jb        near ptr M01_L22
       cmp       [rcx+8],r11d
       mov       [rbp-5C],r10d
       mov       eax,[rbp-58]
       ja        short M01_L13
M01_L15:
       cmp       dword ptr [r13+40],0
       jg        short M01_L17
       mov       r12d,[r13+38]
       cmp       [rcx+8],r12d
       jne       short M01_L16
       mov       ecx,[r13+38]
       call      qword ptr [7FFB5E17F570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FFB5E77DC68]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       r8,[r13+8]
       mov       ecx,[rbp-58]
       mov       edx,ecx
       imul      rdx,[r13+30]
       shr       rdx,20
       inc       rdx
       mov       r9d,[r8+8]
       mov       eax,r9d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r9d
       jae       near ptr M01_L36
       mov       edx,edx
       lea       r9,[r8+rdx*4+10]
       mov       r8,r9
       mov       [rbp-0F0],r8
       mov       eax,ecx
M01_L16:
       lea       r8d,[r12+1]
       mov       [r13+38],r8d
       mov       rcx,[r13+10]
       mov       r8,rcx
       mov       rcx,r8
       jmp       short M01_L18
M01_L17:
       mov       r8d,[r13+3C]
       mov       r12d,r8d
       cmp       r8d,[rcx+8]
       jae       near ptr M01_L36
       shl       r8,4
       mov       r8d,[rcx+r8+14]
       neg       r8d
       add       r8d,0FFFFFFFD
       mov       [r13+3C],r8d
       dec       dword ptr [r13+40]
M01_L18:
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L36
       mov       r8d,r12d
       shl       r8,4
       lea       r8,[rcx+r8+10]
       mov       [r8],eax
       mov       r9,[rbp-0F0]
       mov       ecx,[r9]
       dec       ecx
       mov       [r8+4],ecx
       mov       edx,[rbp-50]
       mov       [r8+8],edx
       mov       byte ptr [r8+0C],0
       inc       r12d
       mov       [r9],r12d
       inc       dword ptr [r13+44]
       mov       r13d,[rbp-4C]
       test      r13d,r13d
       jg        short M01_L19
       mov       [rbp-50],edx
       lea       r8d,[rdx+1]
       mov       [r15+20],r8d
       jmp       short M01_L21
M01_L19:
       mov       r12,[r15+10]
       lea       r9d,[r13-1]
       mov       r8d,[r12+10]
       cmp       r9d,r8d
       jae       near ptr M01_L35
       dec       r8d
       mov       [r12+10],r8d
       cmp       r9d,r8d
       jl        near ptr M01_L37
M01_L20:
       inc       dword ptr [r12+14]
       mov       [rbp-50],edx
M01_L21:
       inc       dword ptr [r15+24]
       jmp       near ptr M01_L38
M01_L22:
       call      qword ptr [7FFB5E17F498]
       int       3
M01_L23:
       mov       ecx,r12d
       call      qword ptr [7FFB5E834CF0]
       int       3
M01_L24:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB5E706658]
       int       3
M01_L25:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB5E706658]
       int       3
M01_L26:
       mov       rcx,r10
       call      qword ptr [7FFB5E1757A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-0D0]
       jmp       near ptr M01_L04
M01_L27:
       jmp       short M01_L32
M01_L28:
       jmp       short M01_L32
M01_L29:
       jmp       short M01_L32
M01_L30:
       jmp       short M01_L32
M01_L31:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       jmp       short M01_L33
M01_L32:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFB5E77F870]; System.Array.GetLowerBound(Int32)
       mov       [rbp-54],eax
       mov       rax,[rbp-0D0]
M01_L33:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFB5E77F870]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r12d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-54]
       mov       r8,[rbp-0D0]
       call      qword ptr [7FFB5E77F888]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-0D0]
       jmp       near ptr M01_L04
M01_L34:
       mov       rcx,232DC5A07D8
       mov       [r13+8],rcx
       jmp       near ptr M01_L05
M01_L35:
       call      qword ptr [7FFB5E77FC78]
       int       3
M01_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L37:
       mov       [rbp-50],edx
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[r12+8]
       mov       rcx,[r12+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFB5E68D650]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-50]
       jmp       near ptr M01_L20
M01_L38:
       mov       rcx,[rbp-148]
       mov       edx,[rbp-7C]
       call      qword ptr [7FFB5E77D2D8]; System.Threading.Lock.Exit(ThreadId)
       mov       r15d,[rbp-50]
       mov       ecx,r15d
       not       ecx
       mov       [r14+18],ecx
       mov       byte ptr [r14+1C],1
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1F25D400180
       mov       rdi,[rcx]
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Object[]
       mov       edx,0C
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       xor       r13d,r13d
M01_L39:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[r15+r13*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r13d,1
       jo        near ptr M01_L88
       cmp       r13d,0C
       jl        short M01_L39
       mov       edx,0C
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       edx,1F
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<System.Exception>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<System.Exception>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-108],rax
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rbp-108]
       lea       rcx,[r12+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+1C],1
       mov       dword ptr [r14+18],2
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.DistinctConcurrentBag<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<System.String>+WorkStealingQueue>
       call      CORINFO_HELP_NEWFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<System.String>+WorkStealingQueue>+LinkedSlot
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+18],rcx
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+8],rcx
       mov       byte ptr [r14+1D],0
       mov       rcx,1F25D400198
       mov       r15,[rcx]
       mov       r13,[r15+18]
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FFB5E77D188]; System.Threading.Lock.EnterAndGetCurrentThreadId()
       mov       ecx,eax
       mov       [rbp-150],r13
       mov       [rbp-80],ecx
       mov       r13,[r15+10]
       mov       r12d,[r13+10]
       mov       r9d,r12d
       mov       [rbp-64],r9d
       test      r9d,r9d
       jg        short M01_L40
       mov       eax,[r15+20]
       jmp       short M01_L41
M01_L40:
       mov       rax,r13
       lea       edx,[r9-1]
       cmp       edx,r12d
       jae       near ptr M01_L68
       mov       rcx,[rax+8]
       cmp       edx,[rcx+8]
       jae       near ptr M01_L69
       mov       eax,[rcx+rdx*4+10]
       mov       [rbp-68],eax
       mov       eax,[rbp-68]
       mov       r9d,[rbp-64]
M01_L41:
       mov       rdx,[r15+8]
       mov       ecx,[rdx+38]
       sub       ecx,[rdx+40]
       inc       ecx
       cmp       [r13],r13b
       test      ecx,ecx
       jl        near ptr M01_L64
       mov       rdx,[r13+8]
       mov       r8,rdx
       cmp       [r8+8],ecx
       jge       near ptr M01_L44
       cmp       dword ptr [r8+8],0
       jne       near ptr M01_L46
       mov       edx,4
M01_L42:
       mov       r10d,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,r10d
       cmp       edx,ecx
       cmovl     edx,ecx
       cmp       edx,r12d
       jl        near ptr M01_L65
       mov       [rbp-158],r8
       cmp       [r8+8],edx
       je        short M01_L44
       test      edx,edx
       jle       near ptr M01_L66
       mov       [rbp-68],eax
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-110],rax
       test      r12d,r12d
       jle       short M01_L43
       mov       rcx,[rbp-158]
       mov       r8d,r12d
       mov       rdx,rax
       call      qword ptr [7FFB5E17F5A0]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,[rbp-110]
M01_L43:
       lea       rcx,[r13+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-68]
       mov       r9d,[rbp-64]
M01_L44:
       mov       rcx,[r13+8]
       mov       ecx,[rcx+8]
       mov       r13,[r15+8]
       mov       [rbp-68],eax
       mov       r12d,eax
       cmp       qword ptr [r13+8],0
       jne       near ptr M01_L45
       xor       ecx,ecx
       call      qword ptr [7FFB5E175A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       [rbp-78],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-130],rax
       movsxd    rdx,dword ptr [rbp-78]
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Int32, System.Boolean>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-138],rax
       mov       dword ptr [r13+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-78]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [r13+30],rax
       lea       rcx,[r13+8]
       mov       rdx,[rbp-130]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,[rbp-138]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9d,[rbp-64]
M01_L45:
       mov       r8,[r13+10]
       mov       [rbp-118],r8
       mov       r10,[r13+18]
       mov       [rbp-120],r10
       test      r10,r10
       je        short M01_L47
       mov       rcx,r10
       mov       edx,r12d
       mov       r11,7FFB5E0C0B80
       call      qword ptr [r11]
       jmp       short M01_L48
M01_L46:
       mov       edx,[r8+8]
       add       edx,edx
       jmp       near ptr M01_L42
M01_L47:
       mov       r11d,r12d
       mov       eax,r11d
M01_L48:
       mov       [rbp-6C],eax
       xor       r10d,r10d
       mov       [rbp-70],r10d
       mov       rdx,[r13+8]
       mov       ecx,eax
       imul      rcx,[r13+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       mov       r11d,r8d
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,r8d
       jae       near ptr M01_L69
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-128],r9
       mov       r11d,[r9]
       dec       r11d
       cmp       qword ptr [rbp-120],0
       je        near ptr M01_L53
       mov       rcx,[rbp-118]
       mov       edx,[rcx+8]
       cmp       edx,r11d
       jbe       near ptr M01_L52
M01_L49:
       cmp       r11d,edx
       jae       near ptr M01_L69
       mov       ecx,r11d
       shl       rcx,4
       mov       [rbp-0B0],rcx
       mov       r8,[rbp-118]
       cmp       [r8+rcx+10],eax
       jne       short M01_L50
       mov       [rbp-74],r11d
       mov       [rbp-0B4],edx
       cmp       r11d,edx
       jae       near ptr M01_L69
       mov       [rbp-118],r8
       mov       edx,[r8+rcx+18]
       mov       rcx,[rbp-120]
       mov       r8d,[rbp-68]
       mov       r11,7FFB5E0C0B78
       call      qword ptr [r11]
       test      eax,eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       mov       r8,[rbp-118]
       mov       r11d,[rbp-74]
       jne       near ptr M01_L63
M01_L50:
       cmp       r11d,edx
       jae       near ptr M01_L69
       mov       r11d,[r8+rcx+14]
       mov       r10d,[rbp-70]
       inc       r10d
       mov       [rbp-70],r10d
       cmp       edx,r10d
       jb        near ptr M01_L62
       cmp       edx,r11d
       mov       [rbp-118],r8
       mov       eax,[rbp-6C]
       ja        near ptr M01_L49
       jmp       short M01_L52
M01_L51:
       mov       [rbp-118],r8
M01_L52:
       cmp       dword ptr [r13+40],0
       jle       near ptr M01_L56
       mov       r8d,[r13+3C]
       mov       r12d,r8d
       cmp       r8d,edx
       jae       near ptr M01_L69
       shl       r8,4
       mov       rcx,[rbp-118]
       mov       r8d,[rcx+r8+14]
       neg       r8d
       add       r8d,0FFFFFFFD
       mov       [r13+3C],r8d
       dec       dword ptr [r13+40]
       jmp       near ptr M01_L58
M01_L53:
       mov       r8,[rbp-118]
       mov       edx,[r8+8]
       cmp       edx,r11d
       jbe       short M01_L51
M01_L54:
       cmp       r11d,edx
       jae       near ptr M01_L69
       mov       ecx,r11d
       shl       rcx,4
       cmp       [r8+rcx+10],eax
       jne       short M01_L55
       cmp       r11d,edx
       jae       near ptr M01_L69
       mov       r10d,[rbp-68]
       cmp       [r8+rcx+18],r10d
       mov       [rbp-68],r10d
       je        near ptr M01_L63
M01_L55:
       cmp       r11d,edx
       jae       near ptr M01_L69
       mov       r11d,[r8+rcx+14]
       mov       r10d,[rbp-70]
       inc       r10d
       cmp       edx,r10d
       jb        near ptr M01_L62
       cmp       edx,r11d
       mov       [rbp-70],r10d
       mov       eax,[rbp-6C]
       ja        short M01_L54
       jmp       near ptr M01_L67
M01_L56:
       mov       r12d,[r13+38]
       cmp       edx,r12d
       jne       short M01_L57
       mov       ecx,[r13+38]
       call      qword ptr [7FFB5E17F570]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FFB5E77DC68]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       r8,[r13+8]
       mov       ecx,[rbp-6C]
       mov       edx,ecx
       imul      rdx,[r13+30]
       shr       rdx,20
       inc       rdx
       mov       r9d,[r8+8]
       mov       eax,r9d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r9d
       jae       near ptr M01_L69
       mov       edx,edx
       lea       r9,[r8+rdx*4+10]
       mov       r8,r9
       mov       [rbp-128],r8
       mov       eax,ecx
M01_L57:
       lea       r8d,[r12+1]
       mov       [r13+38],r8d
       mov       rcx,[r13+10]
       mov       r8,rcx
       mov       rcx,r8
M01_L58:
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L69
       mov       r8d,r12d
       shl       r8,4
       lea       r8,[rcx+r8+10]
       mov       [r8],eax
       mov       r9,[rbp-128]
       mov       ecx,[r9]
       dec       ecx
       mov       [r8+4],ecx
       mov       eax,[rbp-68]
       mov       [r8+8],eax
       mov       byte ptr [r8+0C],0
       inc       r12d
       mov       [r9],r12d
       inc       dword ptr [r13+44]
       mov       r13d,[rbp-64]
       test      r13d,r13d
       jg        short M01_L59
       mov       [rbp-68],eax
       lea       r8d,[rax+1]
       mov       [r15+20],r8d
       jmp       short M01_L61
M01_L59:
       mov       r12,[r15+10]
       lea       r9d,[r13-1]
       mov       r8d,[r12+10]
       cmp       r9d,r8d
       jae       short M01_L68
       dec       r8d
       mov       [r12+10],r8d
       cmp       r9d,r8d
       jl        short M01_L70
M01_L60:
       inc       dword ptr [r12+14]
       mov       [rbp-68],eax
M01_L61:
       inc       dword ptr [r15+24]
       jmp       near ptr M01_L71
M01_L62:
       call      qword ptr [7FFB5E17F498]
       int       3
M01_L63:
       mov       ecx,r12d
       call      qword ptr [7FFB5E834CF0]
       int       3
M01_L64:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFB5E706658]
       int       3
M01_L65:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFB5E706658]
       int       3
M01_L66:
       mov       rcx,232DC5A07D8
       mov       [r13+8],rcx
       jmp       near ptr M01_L44
M01_L67:
       mov       [rbp-118],r8
       jmp       near ptr M01_L52
M01_L68:
       call      qword ptr [7FFB5E77FC78]
       int       3
M01_L69:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L70:
       mov       [rbp-68],eax
       sub       r8d,r9d
       mov       [rsp+20],r8d
       mov       r8,[r12+8]
       mov       rcx,[r12+8]
       lea       edx,[r9+1]
       call      qword ptr [7FFB5E68D650]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       eax,[rbp-68]
       jmp       near ptr M01_L60
M01_L71:
       cmp       qword ptr [rbp-150],0
       je        short M01_L72
       mov       rcx,[rbp-150]
       mov       edx,[rbp-80]
       cmp       [rcx],ecx
       call      qword ptr [7FFB5E77D2D8]; System.Threading.Lock.Exit(ThreadId)
M01_L72:
       mov       eax,[rbp-68]
       mov       ecx,eax
       not       ecx
       mov       [r14+18],ecx
       mov       byte ptr [r14+1C],1
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1F247400048
       mov       rdi,[rcx]
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Object[]
       mov       edx,0C
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       xor       r13d,r13d
M01_L73:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[r15+r13*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       add       r13d,1
       jo        near ptr M01_L88
       cmp       r13d,0C
       jl        short M01_L73
       mov       edx,0C
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       mov       edx,1F
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<System.String>+Node[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<System.String>+Tables
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-140],rax
       lea       rcx,[rax+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rbp-140]
       lea       rcx,[r12+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+1C],1
       mov       dword ptr [r14+18],2
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+20],ecx
       mov       [rbp-0C0],rbx
       cmp       qword ptr [rbp+28],0
       jne       near ptr M01_L87
       xor       ebx,ebx
M01_L74:
       movzx     ecx,bl
       mov       [rbp-40],ecx
M01_L75:
       nop
       mov       eax,[rbp-3C]
       add       eax,1
       jo        near ptr M01_L78
       mov       [rbp-3C],eax
       mov       rax,[rbp+10]
       mov       rdx,offset DotNetTips.Spargine.Core.BenchmarkTests.ExecutionHelperBenchmark+<>c__DisplayClass8_0.<CreateFailThenSucceedAction>b__0()
       cmp       [rax+18],rdx
       jne       near ptr M01_L79
       mov       rax,[rbp+10]
       mov       rax,[rax+8]
       mov       [rbp-0C8],rax
       lea       rdx,[rax+8]
       mov       ecx,1
       lock xadd [rdx],ecx
       lea       eax,[rcx+1]
       mov       rdx,[rbp-0C8]
       mov       ecx,[rdx+0C]
       inc       ecx
       cdq
       idiv      ecx
       test      edx,edx
       jne       short M01_L77
M01_L76:
       mov       ecx,[rbp-3C]
       mov       rax,[rbp-0C0]
       mov       [rax+20],ecx
       mov       byte ptr [rax+24],1
       jmp       short M01_L80
M01_L77:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0E1E
       mov       rdx,7FFB5E4434D8
       call      System.String.StrCns(UInt32, IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E4F6088]; System.InvalidOperationException..ctor(System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L78:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L79:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rax,[rbp+10]
       call      qword ptr [rax+18]
       jmp       short M01_L76
M01_L80:
       mov       rax,[rbp-0C0]
       add       rsp,158
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L81:
       call      qword ptr [7FFB5E70E760]
       mov       ecx,1F89
       mov       rdx,7FFB5E444FD8
       call      System.String.StrCns(UInt32, IntPtr)
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FFB5E444FD8
       call      System.String.StrCns(UInt32, IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E17D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,111F
       mov       rdx,7FFB5E444FD8
       call      System.String.StrCns(UInt32, IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB5E17D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB5E8343C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB5E8343D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L82:
       call      qword ptr [7FFB5E70EFB8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L83
       call      qword ptr [7FFB5E83C3C0]
       mov       rbx,rax
M01_L83:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,232DC5A0730
       call      qword ptr [7FFB5E40D8F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L84:
       movzx     ecx,byte ptr [rbp-48]
       test      cl,cl
       je        short M01_L85
       lea       rcx,[rbp-48]
       call      qword ptr [7FFB5E70EFA0]
       mov       ebx,eax
       jmp       near ptr M01_L00
M01_L85:
       call      qword ptr [7FFB5E70EFB8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L86
       call      qword ptr [7FFB5E83C3C0]
       mov       rbx,rax
M01_L86:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,232DC5A0760
       call      qword ptr [7FFB5E40D8F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L87:
       mov       rcx,[rbp+28]
       mov       r11,7FFB5E0C0B60
       mov       edx,4
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M01_L74
M01_L88:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,[rbp-0C0]
       mov       rdx,rbx
       call      qword ptr [7FFB5E77CF60]; DotNetTips.Spargine.Core.SimpleResult`1[[System.Int32, System.Private.CoreLib]].AddException(System.Exception)
       cmp       dword ptr [rbp-40],0
       je        near ptr M01_L91
       call      qword ptr [7FFB5E7742E8]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       rsi,rax
       test      byte ptr [7FFB5E7CDEB0],1
       jne       short M01_L89
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ExecutionHelper
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M01_L89:
       mov       rcx,1F25D400160
       mov       rdx,[rcx]
       mov       rcx,rsi
       mov       r8d,[rbp-3C]
       call      qword ptr [7FFB5E77CF00]
       mov       rsi,rax
       mov       rcx,[rbp+28]
       mov       r11,7FFB5E0C0B88
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L91
       mov       rcx,[rbp+28]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFB5E91EE98
       call      qword ptr [7FFB5E175920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,232DC5A0DC0
       mov       [rbp-90],rcx
       mov       dword ptr [rbp-88],1F4
       mov       [rbp-0A0],rsi
       mov       rcx,232DC5A07A0
       mov       [rbp-98],rcx
       test      byte ptr [7FFB5E91ECD8],1
       jne       short M01_L90
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogExceptionMessageStruct
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M01_L90:
       mov       r8,1F25D400300
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rbp-90]
       lea       r9,[rbp-0A0]
       mov       rcx,[rbp+28]
       mov       [rsp+20],rbx
       mov       edx,4
       call      rdi
M01_L91:
       movzx     ecx,byte ptr [rbp+18]
       cmp       [rbp-3C],ecx
       je        short M01_L92
       mov       ecx,[rbp+20]
       imul      ecx,[rbp-3C]
       jo        short M01_L93
       call      qword ptr [7FFB5E17F1B0]; System.Threading.Thread.Sleep(Int32)
       lea       rax,[M01_L75]
       add       rsp,38
       ret
M01_L92:
       mov       rcx,[rbp-0C0]
       mov       edx,[rbp-3C]
       call      qword ptr [7FFB5E77CF48]; DotNetTips.Spargine.Core.SimpleResult`1[[System.Int32, System.Private.CoreLib]].SetValue(Int32)
       lea       rax,[M01_L80]
       add       rsp,38
       ret
M01_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,38
       cmp       qword ptr [rbp-148],0
       je        short M01_L94
       mov       rcx,[rbp-148]
       mov       edx,[rbp-7C]
       call      qword ptr [7FFB5E77D2D8]; System.Threading.Lock.Exit(ThreadId)
M01_L94:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       qword ptr [rbp-150],0
       je        short M01_L95
       mov       rcx,[rbp-150]
       mov       edx,[rbp-80]
       cmp       [rcx],ecx
       call      qword ptr [7FFB5E77D2D8]; System.Threading.Lock.Exit(ThreadId)
M01_L95:
       nop
       add       rsp,38
       ret
; Total bytes of code 4904
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ExecutionHelperBenchmark.ProgressiveRetryAsyncSuccess()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-48],rcx
       mov       dword ptr [rbp-40],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFB5E34FEE8]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-50],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-58],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-60],rdx
       lea       rcx,[rbp-48]
       call      qword ptr [7FFB5E79D848]; DotNetTips.Spargine.Core.BenchmarkTests.ExecutionHelperBenchmark+<ProgressiveRetryAsyncSuccess>d__4.MoveNext()
       nop
       mov       rdx,[rbp-60]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-58]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-58],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-38]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-58]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-58]
       call      qword ptr [7FFB5E836AA8]
       jmp       short M00_L04
M00_L08:
       mov       ecx,3
       call      qword ptr [7FFB5E834D20]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-38]
       call      qword ptr [7FFB5E835A10]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-60]
       mov       rax,[rbp-50]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-50]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-58]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-58],0
       je        short M00_L13
       mov       rdx,[rbp-58]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-58]
       call      qword ptr [7FFB5E836AA8]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 374
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFB5E835818]
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBBDBF4030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBBDBF4038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFBBDBF5EB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFBBDBF3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ExecutionHelperBenchmark+<ProgressiveRetryAsyncSuccess>d__4.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       rdx,rcx
       mov       ecx,[rdx+8]
       mov       rsi,[rdx]
       test      ecx,ecx
       je        near ptr M03_L16
       cmp       ecx,1
       je        near ptr M03_L22
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       rcx,24626800D58
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       byte ptr [rbp-5C],3
       mov       dword ptr [rbp-64],1
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       [rbp-50],rcx
       mov       dword ptr [rbp-68],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M03_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M03_L13
M03_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M03_L01
       call      qword ptr [7FFB5E34FEE8]; System.Threading.Thread.InitializeCurrentThread()
       mov       rdi,rax
M03_L01:
       mov       [rbp-90],rdi
       mov       rcx,[rdi+8]
       mov       [rbp-98],rcx
       mov       rcx,[rdi+10]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-80]
       call      qword ptr [7FFB5E79DBC0]; DotNetTips.Spargine.Core.ExecutionHelper+<ProgressiveRetryAsync>d__2.MoveNext()
       nop
       mov       rdx,[rbp-0A0]
       cmp       rdx,[rdi+10]
       je        short M03_L02
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
       mov       rcx,[rdi+8]
       mov       rbx,rcx
       mov       rdx,[rbp-98]
       cmp       rdx,rbx
       je        short M03_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L03
       cmp       qword ptr [rbx+10],0
       jne       near ptr M03_L10
M03_L03:
       cmp       qword ptr [rbp-98],0
       jne       near ptr M03_L09
M03_L04:
       mov       rax,[rbp-58]
       test      rax,rax
       je        near ptr M03_L14
M03_L05:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L15
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L15
M03_L06:
       mov       rcx,[rbp-28]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L17
M03_L07:
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       mov       rsi,[rsi+60]
       mov       rax,[rbp-88]
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rsi+8],rdx
       mov       [rbp-38],rdx
       mov       word ptr [rbp-30],0
       mov       byte ptr [rbp-2E],0
       mov       rsi,[rbp-38]
       test      rsi,rsi
       jne       short M03_L11
M03_L08:
       mov       rsi,[rbp-38]
       test      rsi,rsi
       je        near ptr M03_L26
       mov       rdx,rsi
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      qword ptr [7FFB5E176850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M03_L23
       mov       rcx,offset MT_System.Runtime.CompilerServices.PoolingAsyncValueTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>+StateMachineBox<System.Threading.AsyncOverSyncWithIoCancellation+<InvokeAsync>d__7<System.ValueTuple<Microsoft.Win32.SafeHandles.SafeFileHandle, System.ReadOnlyMemory<System.Byte>, System.Int64, System.IO.Strategies.OSFileStreamStrategy>>>
       cmp       [rsi],rcx
       jne       near ptr M03_L25
       jmp       near ptr M03_L24
M03_L09:
       mov       rdx,[rbp-98]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L04
M03_L10:
       mov       rcx,rbx
       mov       rdx,[rbp-98]
       call      qword ptr [7FFB5E836AA8]
       jmp       near ptr M03_L04
M03_L11:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      qword ptr [7FFB5E176850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M03_L18
       mov       rcx,offset MT_System.Runtime.CompilerServices.PoolingAsyncValueTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>+StateMachineBox<System.Threading.AsyncOverSyncWithIoCancellation+<InvokeAsync>d__7<System.ValueTuple<Microsoft.Win32.SafeHandles.SafeFileHandle, System.ReadOnlyMemory<System.Byte>, System.Int64, System.IO.Strategies.OSFileStreamStrategy>>>
       cmp       [rsi],rcx
       jne       near ptr M03_L20
       jmp       near ptr M03_L19
M03_L12:
       test      eax,eax
       jne       near ptr M03_L08
       jmp       near ptr M03_L21
M03_L13:
       mov       ecx,3
       call      qword ptr [7FFB5E834D20]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L14:
       lea       rcx,[rbp-58]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<DotNetTips.Spargine.Core.SimpleResult<System.Int32>>
       call      qword ptr [7FFB5E835938]
       jmp       near ptr M03_L05
M03_L15:
       xor       ecx,ecx
       mov       rdx,[rbp+10]
       mov       [rdx+8],ecx
       lea       rcx,[rdx+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rcx,[rbp+10]
       mov       [rcx+20],edx
       lea       rdx,[rcx+10]
       call      qword ptr [7FFB5E836B08]
       mov       r8,rax
       lea       rdx,[rbp-28]
       mov       rcx,7FFB5E87BDA8
       call      qword ptr [7FFB5E836B20]
       jmp       near ptr M03_L27
M03_L16:
       mov       rdx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rdx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       ecx,ecx
       mov       [rdx+18],rcx
       mov       [rdx+20],rcx
       mov       dword ptr [rdx+8],0FFFFFFFF
       jmp       near ptr M03_L06
M03_L17:
       xor       edx,edx
       call      qword ptr [7FFB5E835818]
       jmp       near ptr M03_L07
M03_L18:
       test      dword ptr [rax+34],1600000
       jne       near ptr M03_L08
       jmp       short M03_L21
M03_L19:
       movsx     rdx,word ptr [rbp-30]
       lea       rcx,[rsi+18]
       call      qword ptr [7FFB5E8359C8]
       jmp       near ptr M03_L12
M03_L20:
       mov       rcx,rsi
       movsx     rdx,word ptr [rbp-30]
       mov       r11,7FFB5E0C0A88
       call      qword ptr [r11]
       jmp       near ptr M03_L12
M03_L21:
       mov       rdx,[rbp+10]
       mov       dword ptr [rdx+8],1
       lea       rdi,[rdx+28]
       lea       rsi,[rbp-38]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       add       rdx,10
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB5E836B08]
       mov       rdx,rax
       lea       rcx,[rbp-38]
       call      qword ptr [7FFB5E836C88]
       jmp       near ptr M03_L27
M03_L22:
       mov       rdx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rdx+28]
       vmovdqu   xmmword ptr [rbp-38],xmm0
       xor       ecx,ecx
       mov       [rdx+28],rcx
       mov       [rdx+30],rcx
       mov       dword ptr [rdx+8],0FFFFFFFF
       jmp       near ptr M03_L08
M03_L23:
       mov       ecx,[rax+34]
       and       ecx,11000000
       cmp       ecx,1000000
       je        short M03_L26
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFB5E835818]
       jmp       short M03_L26
M03_L24:
       mov       rcx,rsi
       movsx     rdx,word ptr [rbp-30]
       call      qword ptr [7FFB5E8056E0]
       jmp       short M03_L26
M03_L25:
       mov       rcx,rsi
       movsx     rdx,word ptr [rbp-30]
       mov       r11,7FFB5E0C0A90
       call      qword ptr [r11]
       nop
M03_L26:
       mov       rdx,[rbp+10]
       mov       dword ptr [rdx+8],0FFFFFFFE
       lea       rcx,[rdx+10]
       cmp       qword ptr [rcx],0
       jne       short M03_L28
       mov       rdx,24626800230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L27:
       nop
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L28:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFB5E8359F8]
       jmp       short M03_L27
       sub       rsp,28
       mov       rdx,[rbp-0A0]
       mov       rax,[rbp-90]
       cmp       rdx,[rax+10]
       je        short M03_L29
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-90]
M03_L29:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-98]
       cmp       rdx,rsi
       je        short M03_L32
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L30
       cmp       qword ptr [rsi+10],0
       jne       short M03_L31
M03_L30:
       cmp       qword ptr [rbp-98],0
       je        short M03_L32
       mov       rdx,[rbp-98]
       cmp       qword ptr [rdx+10],0
       je        short M03_L32
M03_L31:
       mov       rcx,rsi
       mov       rdx,[rbp-98]
       call      qword ptr [7FFB5E836AA8]
M03_L32:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFB5E79D9F8]
       lea       rax,[M03_L27]
       add       rsp,28
       ret
; Total bytes of code 1237
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBBDC0CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ExecutionHelperBenchmark.ProgressiveRetryAsyncWithRetries()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-48],rcx
       mov       dword ptr [rbp-40],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFB5E427D20]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-50],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-58],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-60],rdx
       lea       rcx,[rbp-48]
       call      qword ptr [7FFB5E7BD800]; DotNetTips.Spargine.Core.BenchmarkTests.ExecutionHelperBenchmark+<ProgressiveRetryAsyncWithRetries>d__5.MoveNext()
       nop
       mov       rdx,[rbp-60]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-58]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-58],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-38]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-58]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-58]
       call      qword ptr [7FFB5E8479D8]
       jmp       short M00_L04
M00_L08:
       mov       ecx,3
       call      qword ptr [7FFB5E846F70]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-38]
       call      qword ptr [7FFB5E84C708]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-60]
       mov       rax,[rbp-50]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-50]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-58]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-58],0
       je        short M00_L13
       mov       rdx,[rbp-58]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-58]
       call      qword ptr [7FFB5E8479D8]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 374
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFB5E7BF408]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBBDBF4030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFBBDBF4038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFBBDBF5EB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFBBDBF3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ExecutionHelperBenchmark+<ProgressiveRetryAsyncWithRetries>d__5.MoveNext()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-88],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       rdx,rcx
       mov       ecx,[rdx+8]
       mov       rsi,[rdx]
       test      ecx,ecx
       jne       near ptr M03_L03
       lea       rcx,[rdx+18]
       vmovdqu   xmm0,xmmword ptr [rcx]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       eax,eax
       mov       [rcx],rax
       mov       [rcx+8],rax
       mov       dword ptr [rdx+8],0FFFFFFFF
M03_L00:
       mov       rcx,[rbp-28]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L15
M03_L01:
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       mov       rsi,[rsi+60]
       mov       rax,[rbp-88]
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rsi+8],rdx
       mov       [rbp-38],rdx
       mov       word ptr [rbp-30],0
       mov       byte ptr [rbp-2E],0
       mov       rsi,[rbp-38]
       test      rsi,rsi
       jne       near ptr M03_L16
M03_L02:
       mov       rbx,[rbp-38]
       test      rbx,rbx
       je        near ptr M03_L25
       jmp       near ptr M03_L22
M03_L03:
       cmp       ecx,1
       je        near ptr M03_L21
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       rcx,28884000D60
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       byte ptr [rbp-5C],3
       mov       dword ptr [rbp-64],1
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       [rbp-50],rcx
       mov       dword ptr [rbp-68],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M03_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M03_L13
M03_L04:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M03_L05
       call      qword ptr [7FFB5E427D20]; System.Threading.Thread.InitializeCurrentThread()
       mov       rdi,rax
       mov       rdx,[rbp+10]
M03_L05:
       mov       [rbp-98],rdi
       mov       rcx,[rdi+8]
       mov       [rbp-0A0],rcx
       mov       rcx,[rdi+10]
       mov       [rbp-0A8],rcx
       lea       rcx,[rbp-80]
       call      qword ptr [7FFB5E7BDB78]; DotNetTips.Spargine.Core.ExecutionHelper+<ProgressiveRetryAsync>d__2.MoveNext()
       nop
       mov       rdx,[rbp-0A8]
       cmp       rdx,[rdi+10]
       je        short M03_L06
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L06:
       mov       rcx,[rdi+8]
       mov       rbx,rcx
       mov       rdx,[rbp-0A0]
       cmp       rdx,rbx
       je        short M03_L08
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L07
       cmp       qword ptr [rbx+10],0
       jne       near ptr M03_L12
M03_L07:
       cmp       qword ptr [rbp-0A0],0
       jne       short M03_L11
M03_L08:
       mov       rax,[rbp-58]
       test      rax,rax
       je        near ptr M03_L14
M03_L09:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       short M03_L10
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       jne       near ptr M03_L00
M03_L10:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-20]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFB5E7BF2A0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Core.BenchmarkTests.ExecutionHelperBenchmark+<ProgressiveRetryAsyncWithRetries>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<ProgressiveRetryAsyncWithRetries>d__5 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       r8,rax
       lea       rdx,[rbp-28]
       mov       rcx,7FFB5E82F3D0
       call      qword ptr [7FFB5E7BF2B8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<System.__Canon> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L31
M03_L11:
       mov       rdx,[rbp-0A0]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L08
M03_L12:
       mov       rcx,rbx
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FFB5E8479D8]
       jmp       near ptr M03_L08
M03_L13:
       mov       ecx,3
       call      qword ptr [7FFB5E846F70]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,[rbp+10]
       jmp       near ptr M03_L04
M03_L14:
       lea       rcx,[rbp-58]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<DotNetTips.Spargine.Core.SimpleResult<System.Int32>>
       call      qword ptr [7FFB5E84C6F0]
       jmp       near ptr M03_L09
M03_L15:
       xor       edx,edx
       call      qword ptr [7FFB5E7BF408]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L01
M03_L16:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L17
       test      dword ptr [rax+34],1600000
       jne       near ptr M03_L02
       jmp       short M03_L20
M03_L17:
       mov       rcx,offset MT_System.Runtime.CompilerServices.PoolingAsyncValueTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>+StateMachineBox<System.Threading.AsyncOverSyncWithIoCancellation+<InvokeAsync>d__7<System.ValueTuple<Microsoft.Win32.SafeHandles.SafeFileHandle, System.ReadOnlyMemory<System.Byte>, System.Int64, System.IO.Strategies.OSFileStreamStrategy>>>
       cmp       [rsi],rcx
       jne       short M03_L18
       movsx     rdx,word ptr [rbp-30]
       lea       rcx,[rsi+18]
       call      qword ptr [7FFB5E84CB58]
       jmp       short M03_L19
M03_L18:
       mov       rcx,rsi
       movsx     rdx,word ptr [rbp-30]
       mov       r11,7FFB5E0E0AE8
       call      qword ptr [r11]
M03_L19:
       test      eax,eax
       jne       near ptr M03_L02
M03_L20:
       mov       rdx,[rbp+10]
       mov       dword ptr [rdx+8],1
       lea       rdi,[rdx+28]
       lea       rsi,[rbp-38]
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       add       rdx,10
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB5E7BF2A0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Core.BenchmarkTests.ExecutionHelperBenchmark+<ProgressiveRetryAsyncWithRetries>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<ProgressiveRetryAsyncWithRetries>d__5 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-38]
       call      qword ptr [7FFB5E84CC30]
       jmp       near ptr M03_L31
M03_L21:
       vmovdqu   xmm0,xmmword ptr [rdx+28]
       vmovdqu   xmmword ptr [rbp-38],xmm0
       xor       ecx,ecx
       mov       [rdx+28],rcx
       mov       [rdx+30],rcx
       mov       dword ptr [rdx+8],0FFFFFFFF
       jmp       near ptr M03_L02
M03_L22:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L23
       mov       ecx,[rax+34]
       and       ecx,11000000
       cmp       ecx,1000000
       je        short M03_L25
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFB5E7BF408]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M03_L25
M03_L23:
       mov       rcx,offset MT_System.Runtime.CompilerServices.PoolingAsyncValueTaskMethodBuilder<System.Threading.Tasks.VoidTaskResult>+StateMachineBox<System.Threading.AsyncOverSyncWithIoCancellation+<InvokeAsync>d__7<System.ValueTuple<Microsoft.Win32.SafeHandles.SafeFileHandle, System.ReadOnlyMemory<System.Byte>, System.Int64, System.IO.Strategies.OSFileStreamStrategy>>>
       cmp       [rbx],rcx
       jne       short M03_L24
       mov       rcx,rbx
       movsx     rdx,word ptr [rbp-30]
       call      qword ptr [7FFB5E83A5B0]
       jmp       short M03_L25
M03_L24:
       mov       rcx,rbx
       movsx     rdx,word ptr [rbp-30]
       mov       r11,7FFB5E0E0AF0
       call      qword ptr [r11]
       nop
M03_L25:
       mov       rdx,[rbp+10]
       mov       dword ptr [rdx+8],0FFFFFFFE
       lea       rcx,[rdx+10]
       cmp       qword ptr [rcx],0
       je        near ptr M03_L30
       mov       rbx,[rcx]
       mov       rcx,2889A0001D8
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       je        short M03_L27
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFB5E7BFF00]
       mov       r8d,eax
       movzx     ecx,byte ptr [rsi+9D]
       test      ecx,ecx
       je        short M03_L27
       mov       edx,[rsi+98]
       mov       r9,[rsi+80]
       test      ecx,ecx
       je        short M03_L27
       test      edx,edx
       je        short M03_L26
       cmp       edx,4
       jl        short M03_L27
M03_L26:
       test      r9,r9
       je        near ptr M03_L32
       test      r9b,8
       jne       near ptr M03_L32
M03_L27:
       mov       eax,[rbx+34]
       mov       [rbp-8C],eax
       test      eax,5600000
       jne       near ptr M03_L34
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-8C]
       jne       short M03_L33
M03_L28:
       mov       byte ptr [rbx+38],0
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rsi,[rbx+28]
       test      rsi,rsi
       je        short M03_L29
       mov       rcx,rbx
       call      qword ptr [7FFB5E84C2B8]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       short M03_L35
M03_L29:
       mov       rcx,rbx
       call      qword ptr [7FFB5E7BFDE0]; System.Threading.Tasks.Task.FinishContinuations()
       jmp       short M03_L31
M03_L30:
       mov       rdx,28884000230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L31:
       nop
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L32:
       mov       rcx,rsi
       mov       edx,0F
       mov       r9d,1
       call      qword ptr [7FFB5E847E58]
       jmp       near ptr M03_L27
M03_L33:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FFB5E84C2A0]
       test      eax,eax
       jne       near ptr M03_L28
M03_L34:
       mov       ecx,18
       call      qword ptr [7FFB5E84CAE0]
       int       3
M03_L35:
       call      qword ptr [7FFB5E84CC78]
       jmp       short M03_L29
       sub       rsp,28
       mov       rdx,[rbp-0A8]
       mov       rax,[rbp-98]
       cmp       rdx,[rax+10]
       je        short M03_L36
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-98]
M03_L36:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-0A0]
       cmp       rdx,rsi
       je        short M03_L39
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M03_L37
       cmp       qword ptr [rsi+10],0
       jne       short M03_L38
M03_L37:
       cmp       qword ptr [rbp-0A0],0
       je        short M03_L39
       mov       rdx,[rbp-0A0]
       cmp       qword ptr [rdx+10],0
       je        short M03_L39
M03_L38:
       mov       rcx,rsi
       mov       rdx,[rbp-0A0]
       call      qword ptr [7FFB5E8479D8]
M03_L39:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFB5E7BD9B0]
       lea       rax,[M03_L31]
       add       rsp,28
       ret
; Total bytes of code 1456
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFBBDC0CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FFB5E7BF420]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M05_L03
M05_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L04
M05_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M05_L01
       mov       rcx,rbx
       call      qword ptr [7FFB5E84CBA0]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FFB5E84C738]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFB5E84CD68]
       jmp       short M05_L02
; Total bytes of code 124
```

