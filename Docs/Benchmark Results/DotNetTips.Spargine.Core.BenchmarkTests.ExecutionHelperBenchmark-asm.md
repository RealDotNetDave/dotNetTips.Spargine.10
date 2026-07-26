## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ExecutionHelperBenchmark.ProgressiveRetrySuccess()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,2161E400D48
       mov       rcx,[rcx]
       mov       edx,3
       mov       r8d,1
       xor       r9d,r9d
       call      qword ptr [7FF8AC00E2F8]; DotNetTips.Spargine.Core.ExecutionHelper.ProgressiveRetry(System.Action, Byte, Int32, Microsoft.Extensions.Logging.ILogger)
       mov       [rsp+28],rax
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 86
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
       mov       rcx,2161E4021C8
       mov       r15,[rcx]
       mov       r13,[r15+18]
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF8AC00E6B8]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      qword ptr [7FF8AB9E5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF8AB9E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FF8AB930A70
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
       mov       r11,7FF8AB930A68
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
       call      qword ptr [7FF8AB9EF558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FF8AC00ED90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FF8AB9EF480]
       int       3
M01_L23:
       mov       ecx,r12d
       call      qword ptr [7FF8AC085D70]
       int       3
M01_L24:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF8ABF66448]
       int       3
M01_L25:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF8ABF66448]
       int       3
M01_L26:
       mov       rcx,r10
       call      qword ptr [7FF8AB9E57A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF8AC0064D8]; System.Array.GetLowerBound(Int32)
       mov       [rbp-54],eax
       mov       rax,[rbp-0C8]
M01_L33:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF8AC0064D8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r12d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-0D0]
       mov       edx,[rbp-54]
       mov       r8,[rbp-0C8]
       call      qword ptr [7FF8AC0064F0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-0C8]
       jmp       near ptr M01_L04
M01_L34:
       mov       rcx,256B3330B70
       mov       [r13+8],rcx
       jmp       near ptr M01_L05
M01_L35:
       call      qword ptr [7FF8AC00F468]
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
       call      qword ptr [7FF8ABEFD410]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-50]
       jmp       near ptr M01_L20
M01_L38:
       mov       rcx,[rbp-140]
       mov       edx,[rbp-7C]
       call      qword ptr [7FF8AC00E7F0]; System.Threading.Lock.Exit(ThreadId)
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
       mov       rcx,2161E4021E0
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
       mov       rcx,2161E4021E8
       mov       r15,[rcx]
       mov       r13,[r15+18]
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF8AC00E6B8]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      qword ptr [7FF8AB9EF588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF8AB9E5A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FF8AB930A80
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
       mov       r11,7FF8AB930A78
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
       call      qword ptr [7FF8AB9EF558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FF8AC00ED90]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FF8AB9EF480]
       int       3
M01_L63:
       mov       ecx,r12d
       call      qword ptr [7FF8AC085D70]
       int       3
M01_L64:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF8ABF66448]
       int       3
M01_L65:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF8ABF66448]
       int       3
M01_L66:
       mov       rcx,256B3330B70
       mov       [r13+8],rcx
       jmp       near ptr M01_L44
M01_L67:
       mov       [rbp-110],r8
       jmp       near ptr M01_L52
M01_L68:
       call      qword ptr [7FF8AC00F468]
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
       call      qword ptr [7FF8ABEFD410]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       eax,[rbp-68]
       jmp       near ptr M01_L60
M01_L71:
       cmp       qword ptr [rbp-148],0
       je        short M01_L72
       mov       rcx,[rbp-148]
       mov       edx,[rbp-80]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC00E7F0]; System.Threading.Lock.Exit(ThreadId)
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
       mov       rcx,2161E400048
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
       mov       rcx,256B3330DD0
       call      00007FF90B61A6D0
       test      eax,eax
       je        short M01_L77
M01_L76:
       mov       ecx,[rbp-3C]
       mov       rax,[rbp-0C0]
       mov       [rax+20],ecx
       mov       byte ptr [rax+24],1
       jmp       short M01_L80
M01_L77:
       mov       rcx,256B3330DD0
       call      qword ptr [7FF8ABBB72A0]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       call      qword ptr [7FF8ABF6EE38]
       mov       ecx,2375
       mov       rdx,7FF8ABCB4F30
       call      qword ptr [7FF8AB9EF210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8ABCB4F30
       call      qword ptr [7FF8AB9EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8AB9ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABCB4F30
       call      qword ptr [7FF8AB9EF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8AB9ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8AC087000]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8AC086070]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L82:
       call      qword ptr [7FF8ABF6FC18]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L83
       call      qword ptr [7FF8AC087198]
       mov       rbx,rax
M01_L83:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,256B3330AC8
       call      qword ptr [7FF8ABC7D9C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L84:
       movzx     ecx,byte ptr [rbp-48]
       test      cl,cl
       je        short M01_L85
       lea       rcx,[rbp-48]
       call      qword ptr [7FF8ABF6FC00]
       mov       ebx,eax
       jmp       near ptr M01_L00
M01_L85:
       call      qword ptr [7FF8ABF6FC18]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L86
       call      qword ptr [7FF8AC087198]
       mov       rbx,rax
M01_L86:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,256B3330AF8
       call      qword ptr [7FF8ABC7D9C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L87:
       mov       rcx,[rbp+28]
       mov       r11,7FF8AB930A60
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
       call      qword ptr [7FF8AC00E490]
       cmp       dword ptr [rbp-40],0
       je        near ptr M01_L91
       call      qword ptr [7FF8AC005068]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       rsi,rax
       test      byte ptr [7FF8AC06AA58],1
       jne       short M01_L89
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ExecutionHelper
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M01_L89:
       mov       rcx,2161E4021C0
       mov       rdx,[rcx]
       mov       rcx,rsi
       mov       r8d,[rbp-3C]
       call      qword ptr [7FF8AC00E430]
       mov       rsi,rax
       mov       rcx,[rbp+28]
       mov       r11,7FF8AB930A88
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L91
       mov       rcx,[rbp+28]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF8AC166760
       call      qword ptr [7FF8AB9E5920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,256B3330E30
       mov       [rbp-90],rcx
       mov       dword ptr [rbp-88],1F4
       mov       [rbp-0A0],rsi
       mov       rcx,256B3330B38
       mov       [rbp-98],rcx
       test      byte ptr [7FF8AC1665A0],1
       jne       short M01_L90
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogExceptionMessageStruct
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M01_L90:
       mov       r8,2161E402240
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
       call      qword ptr [7FF8AB9EF198]; System.Threading.Thread.Sleep(Int32)
       lea       rax,[M01_L75]
       add       rsp,38
       ret
M01_L92:
       mov       rcx,[rbp-0C0]
       mov       edx,[rbp-3C]
       call      qword ptr [7FF8AC00E478]; DotNetTips.Spargine.Core.SimpleResult`1[[System.Int32, System.Private.CoreLib]].SetValue(Int32)
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
       call      qword ptr [7FF8AC00E7F0]; System.Threading.Lock.Exit(ThreadId)
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
       call      qword ptr [7FF8AC00E7F0]; System.Threading.Lock.Exit(ThreadId)
M01_L95:
       nop
       add       rsp,38
       ret
; Total bytes of code 4827
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ExecutionHelperBenchmark.ProgressiveRetryWithRetries()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,23F56400D50
       mov       rcx,[rcx]
       mov       edx,3
       mov       r8d,1
       xor       r9d,r9d
       call      qword ptr [7FF8AC03E310]; DotNetTips.Spargine.Core.ExecutionHelper.ProgressiveRetry(System.Action, Byte, Int32, Microsoft.Extensions.Logging.ILogger)
       mov       [rsp+28],rax
       mov       rbx,[rbx+88]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 86
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
       mov       rcx,23F6C4001D0
       mov       r15,[rcx]
       mov       r13,[r15+18]
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF8AC03E6D0]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      qword ptr [7FF8ABA15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF8ABA15A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FF8AB960A98
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
       mov       r11,7FF8AB960A90
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
       call      qword ptr [7FF8ABA1F558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FF8AC0B5128]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FF8ABA1F480]
       int       3
M01_L23:
       mov       ecx,r12d
       call      qword ptr [7FF8AC0B65B0]
       int       3
M01_L24:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF8ABF96448]
       int       3
M01_L25:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF8ABF96448]
       int       3
M01_L26:
       mov       rcx,r10
       call      qword ptr [7FF8ABA157A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF8AC0364F0]; System.Array.GetLowerBound(Int32)
       mov       [rbp-54],eax
       mov       rax,[rbp-0D0]
M01_L33:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF8AC0364F0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],r12d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-0D8]
       mov       edx,[rbp-54]
       mov       r8,[rbp-0D0]
       call      qword ptr [7FF8AC036508]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-0D0]
       jmp       near ptr M01_L04
M01_L34:
       mov       rcx,27FEB540B70
       mov       [r13+8],rcx
       jmp       near ptr M01_L05
M01_L35:
       call      qword ptr [7FF8AC03F930]
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
       call      qword ptr [7FF8ABF2D410]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rbp-50]
       jmp       near ptr M01_L20
M01_L38:
       mov       rcx,[rbp-148]
       mov       edx,[rbp-7C]
       call      qword ptr [7FF8AC03E808]; System.Threading.Lock.Exit(ThreadId)
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
       mov       rcx,23F6C4001E8
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
       mov       rcx,23F6C4001F0
       mov       r15,[rcx]
       mov       r13,[r15+18]
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF8AC03E6D0]; System.Threading.Lock.EnterAndGetCurrentThreadId()
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
       call      qword ptr [7FF8ABA1F588]; System.Array.Copy(System.Array, System.Array, Int32)
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
       call      qword ptr [7FF8ABA15A88]; System.Collections.HashHelpers.GetPrime(Int32)
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
       mov       r11,7FF8AB960AA8
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
       mov       r11,7FF8AB960AA0
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
       call      qword ptr [7FF8ABA1F558]; System.Collections.HashHelpers.ExpandPrime(Int32)
       mov       edx,eax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FF8AC0B5128]; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       call      qword ptr [7FF8ABA1F480]
       int       3
M01_L63:
       mov       ecx,r12d
       call      qword ptr [7FF8AC0B65B0]
       int       3
M01_L64:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF8ABF96448]
       int       3
M01_L65:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF8ABF96448]
       int       3
M01_L66:
       mov       rcx,27FEB540B70
       mov       [r13+8],rcx
       jmp       near ptr M01_L44
M01_L67:
       mov       [rbp-118],r8
       jmp       near ptr M01_L52
M01_L68:
       call      qword ptr [7FF8AC03F930]
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
       call      qword ptr [7FF8ABF2D410]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       eax,[rbp-68]
       jmp       near ptr M01_L60
M01_L71:
       cmp       qword ptr [rbp-150],0
       je        short M01_L72
       mov       rcx,[rbp-150]
       mov       edx,[rbp-80]
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC03E808]; System.Threading.Lock.Exit(ThreadId)
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
       mov       rcx,23F56400048
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
       mov       ecx,0E7A
       mov       rdx,7FF8ABCE2660
       call      System.String.StrCns(UInt32, IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABD96130]; System.InvalidOperationException..ctor(System.String)
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
       call      qword ptr [7FF8ABF9EE38]
       mov       ecx,2375
       mov       rdx,7FF8ABCE4538
       call      System.String.StrCns(UInt32, IntPtr)
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8ABCE4538
       call      System.String.StrCns(UInt32, IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA1D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8ABCE4538
       call      System.String.StrCns(UInt32, IntPtr)
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8ABA1D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8AC0B6160]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8AC0B6178]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L82:
       call      qword ptr [7FF8ABF9FC18]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L83
       call      qword ptr [7FF8AC0B6928]
       mov       rbx,rax
M01_L83:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,27FEB540AC8
       call      qword ptr [7FF8ABCAD9C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L84:
       movzx     ecx,byte ptr [rbp-48]
       test      cl,cl
       je        short M01_L85
       lea       rcx,[rbp-48]
       call      qword ptr [7FF8ABF9FC00]
       mov       ebx,eax
       jmp       near ptr M01_L00
M01_L85:
       call      qword ptr [7FF8ABF9FC18]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L86
       call      qword ptr [7FF8AC0B6928]
       mov       rbx,rax
M01_L86:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,27FEB540AF8
       call      qword ptr [7FF8ABCAD9C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L87:
       mov       rcx,[rbp+28]
       mov       r11,7FF8AB960A88
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
       call      qword ptr [7FF8AC03E4A8]; DotNetTips.Spargine.Core.SimpleResult`1[[System.Int32, System.Private.CoreLib]].AddException(System.Exception)
       cmp       dword ptr [rbp-40],0
       je        near ptr M01_L91
       call      qword ptr [7FF8AC035068]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       rsi,rax
       test      byte ptr [7FF8AC099578],1
       jne       short M01_L89
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ExecutionHelper
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M01_L89:
       mov       rcx,23F6C4001C8
       mov       rdx,[rcx]
       mov       rcx,rsi
       mov       r8d,[rbp-3C]
       call      qword ptr [7FF8AC03E448]
       mov       rsi,rax
       mov       rcx,[rbp+28]
       mov       r11,7FF8AB960AB0
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L91
       mov       rcx,[rbp+28]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF8AC1097A8
       call      qword ptr [7FF8ABA15920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,27FEB540F10
       mov       [rbp-90],rcx
       mov       dword ptr [rbp-88],1F4
       mov       [rbp-0A0],rsi
       mov       rcx,27FEB540B38
       mov       [rbp-98],rcx
       test      byte ptr [7FF8AC1095E8],1
       jne       short M01_L90
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogExceptionMessageStruct
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M01_L90:
       mov       r8,23F6C400258
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
       call      qword ptr [7FF8ABA1F198]; System.Threading.Thread.Sleep(Int32)
       lea       rax,[M01_L75]
       add       rsp,38
       ret
M01_L92:
       mov       rcx,[rbp-0C0]
       mov       edx,[rbp-3C]
       call      qword ptr [7FF8AC03E490]; DotNetTips.Spargine.Core.SimpleResult`1[[System.Int32, System.Private.CoreLib]].SetValue(Int32)
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
       call      qword ptr [7FF8AC03E808]; System.Threading.Lock.Exit(ThreadId)
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
       call      qword ptr [7FF8AC03E808]; System.Threading.Lock.Exit(ThreadId)
M01_L95:
       nop
       add       rsp,38
       ret
; Total bytes of code 4904
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ExecutionHelperBenchmark.ProgressiveRetryAsyncSuccess()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
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
       call      qword ptr [7FF8ABCAC4C8]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF8AC03E4A8]; DotNetTips.Spargine.Core.BenchmarkTests.ExecutionHelperBenchmark+<ProgressiveRetryAsyncSuccess>d__4.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FF8AC0B75E8]
       jmp       short M00_L04
M00_L08:
       mov       ecx,3
       call      qword ptr [7FF8AC0B5920]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF8AC0B6430]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FF8AC0B75E8]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
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
       jmp       qword ptr [7FF8AC0B62C8]
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
       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF90A67AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF90A678FE8]; CORINFO_HELP_ASSIGN_REF
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
       sub       rsp,98
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L13
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rax,27E29C00D58
       mov       rax,[rax]
       mov       [rbp-70],rax
       mov       byte ptr [rbp-4C],3
       mov       dword ptr [rbp-54],1
       xor       eax,eax
       mov       [rbp-68],rax
       mov       [rbp-40],rax
       mov       dword ptr [rbp-58],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],3
       jle       near ptr M03_L10
       mov       rax,[rax+240]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M03_L10
M03_L00:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L01
       call      qword ptr [7FF8ABCAC4C8]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M03_L01:
       mov       [rbp-80],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-88],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-90],rdx
       lea       rcx,[rbp-70]
       call      qword ptr [7FF8AC03E7A8]; DotNetTips.Spargine.Core.ExecutionHelper+<ProgressiveRetryAsync>d__2.MoveNext()
       nop
       mov       rdx,[rbp-90]
       cmp       rdx,[rsi+10]
       je        short M03_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L02:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-88]
       cmp       rdx,rdi
       je        short M03_L04
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L03
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L09
M03_L03:
       cmp       qword ptr [rbp-88],0
       jne       short M03_L08
M03_L04:
       mov       rax,[rbp-48]
       test      rax,rax
       je        near ptr M03_L11
M03_L05:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       near ptr M03_L12
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       je        near ptr M03_L12
M03_L06:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L14
M03_L07:
       mov       rdx,[rbp-28]
       mov       rdx,[rdx+38]
       mov       [rbp-78],rdx
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-78]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       jmp       near ptr M03_L15
M03_L08:
       mov       rdx,[rbp-88]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L04
M03_L09:
       mov       rcx,rdi
       mov       rdx,[rbp-88]
       call      qword ptr [7FF8AC0B75E8]
       jmp       near ptr M03_L04
M03_L10:
       mov       ecx,3
       call      qword ptr [7FF8AC0B5920]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L11:
       lea       rcx,[rbp-48]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<DotNetTips.Spargine.Core.SimpleResult<System.Int32>>
       call      qword ptr [7FF8AC0B63E8]
       jmp       near ptr M03_L05
M03_L12:
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
       call      qword ptr [7FF8AC0B7648]
       mov       r8,rax
       lea       rdx,[rbp-28]
       mov       rcx,7FF8AC19D058
       call      qword ptr [7FF8AC0B7660]
       jmp       short M03_L16
M03_L13:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+18]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rcx+18],rdx
       mov       [rcx+20],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
       jmp       near ptr M03_L06
M03_L14:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF8AC0B62C8]
       jmp       near ptr M03_L07
M03_L15:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       cmp       qword ptr [rcx],0
       jne       short M03_L17
       mov       rdx,27E29C00230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L16:
       nop
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L17:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FF8AC0B6418]
       jmp       short M03_L16
       sub       rsp,28
       mov       rdx,[rbp-90]
       mov       rax,[rbp-80]
       cmp       rdx,[rax+10]
       je        short M03_L18
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-80]
M03_L18:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-88]
       cmp       rdx,rbx
       je        short M03_L21
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L19
       cmp       qword ptr [rbx+10],0
       jne       short M03_L20
M03_L19:
       cmp       qword ptr [rbp-88],0
       je        short M03_L21
       mov       rdx,[rbp-88]
       cmp       qword ptr [rdx+10],0
       je        short M03_L21
M03_L20:
       mov       rcx,rbx
       mov       rdx,[rbp-88]
       call      qword ptr [7FF8AC0B75E8]
M03_L21:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF8AC03E5E0]
       lea       rax,[M03_L16]
       add       rsp,28
       ret
; Total bytes of code 835
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF90A691D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.ExecutionHelperBenchmark.ProgressiveRetryAsyncWithRetries()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FF8ABCBFC18]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF8AC04E4A8]; DotNetTips.Spargine.Core.BenchmarkTests.ExecutionHelperBenchmark+<ProgressiveRetryAsyncWithRetries>d__5.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FF8AC0DC5D0]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF8AC0D7BA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF8AC0DD1D0]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FF8AC0DC5D0]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
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
       jmp       qword ptr [7FF8AC0D4648]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FF90A679030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF90A679038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF90A67AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF90A678FE8]; CORINFO_HELP_ASSIGN_REF
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
       sub       rsp,0A8
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       jne       short M03_L02
       lea       rax,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       edx,edx
       mov       [rax],rdx
       mov       [rax+8],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
M03_L00:
       mov       rdx,[rbp-28]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L14
M03_L01:
       mov       rdx,[rbp-28]
       mov       rdx,[rdx+38]
       mov       [rbp-78],rdx
       mov       rbx,[rbx+88]
       mov       rdx,[rbp-78]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       jmp       near ptr M03_L15
M03_L02:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rax,191B5000D60
       mov       rax,[rax]
       mov       [rbp-70],rax
       mov       byte ptr [rbp-4C],3
       mov       dword ptr [rbp-54],1
       xor       eax,eax
       mov       [rbp-68],rax
       mov       [rbp-40],rax
       mov       dword ptr [rbp-58],0FFFFFFFF
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+238],4
       jle       near ptr M03_L12
       mov       rax,[rax+240]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M03_L12
M03_L03:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M03_L04
       call      qword ptr [7FF8ABCBFC18]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
       mov       rcx,[rbp+10]
M03_L04:
       mov       [rbp-88],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-90],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-98],rdx
       lea       rcx,[rbp-70]
       call      qword ptr [7FF8AC04E7A8]; DotNetTips.Spargine.Core.ExecutionHelper+<ProgressiveRetryAsync>d__2.MoveNext()
       nop
       mov       rdx,[rbp-98]
       cmp       rdx,[rsi+10]
       je        short M03_L05
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L05:
       mov       rcx,[rsi+8]
       mov       rdi,rcx
       mov       rdx,[rbp-90]
       cmp       rdx,rdi
       je        short M03_L07
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M03_L06
       cmp       qword ptr [rdi+10],0
       jne       near ptr M03_L11
M03_L06:
       cmp       qword ptr [rbp-90],0
       jne       short M03_L10
M03_L07:
       mov       rax,[rbp-48]
       test      rax,rax
       je        near ptr M03_L13
M03_L08:
       cmp       [rax],al
       mov       [rbp-28],rax
       xor       ecx,ecx
       mov       [rbp-20],ecx
       test      byte ptr [rbp-20],4
       jne       short M03_L09
       mov       rcx,[rbp-28]
       test      dword ptr [rcx+34],1600000
       jne       near ptr M03_L00
M03_L09:
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
       call      qword ptr [7FF8AC0D4228]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Core.BenchmarkTests.ExecutionHelperBenchmark+<ProgressiveRetryAsyncWithRetries>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<ProgressiveRetryAsyncWithRetries>d__5 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       r8,rax
       lea       rdx,[rbp-28]
       mov       rcx,7FF8AC0C92D8
       call      qword ptr [7FF8AC0D4240]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<System.__Canon> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L19
M03_L10:
       mov       rdx,[rbp-90]
       cmp       qword ptr [rdx+10],0
       je        near ptr M03_L07
M03_L11:
       mov       rcx,rdi
       mov       rdx,[rbp-90]
       call      qword ptr [7FF8AC0DC5D0]
       jmp       near ptr M03_L07
M03_L12:
       mov       ecx,4
       call      qword ptr [7FF8AC0D7BA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L03
M03_L13:
       lea       rcx,[rbp-48]
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<DotNetTips.Spargine.Core.SimpleResult<System.Int32>>
       call      qword ptr [7FF8AC0DD1B8]
       jmp       near ptr M03_L08
M03_L14:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF8AC0D4648]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L01
M03_L15:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L20
       mov       rcx,191CB000208
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M03_L21
M03_L16:
       mov       eax,[rbx+34]
       mov       [rbp-7C],eax
       test      eax,5600000
       jne       near ptr M03_L23
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-7C]
       jne       near ptr M03_L22
M03_L17:
       mov       byte ptr [rbx+38],0
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rsi,[rbx+28]
       test      rsi,rsi
       je        short M03_L18
       mov       rcx,rbx
       call      qword ptr [7FF8AC0DCC90]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L24
M03_L18:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L25
       mov       rdx,191B5000218
       mov       rdx,[rdx]
       call      00007FF90B64A300
       test      rax,rax
       je        short M03_L19
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF8AC0D4A20]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M03_L19:
       nop
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L20:
       mov       rdx,191B5000230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L19
M03_L21:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF8AC0D4B10]
       mov       edx,eax
       mov       rcx,191CB000208
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF8AC0DCC60]
       jmp       near ptr M03_L16
M03_L22:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF8AC0DCC78]
       test      eax,eax
       jne       near ptr M03_L17
M03_L23:
       mov       ecx,18
       call      qword ptr [7FF8AC0DD5A8]
       int       3
M03_L24:
       call      qword ptr [7FF8AC0DD668]
       jmp       near ptr M03_L18
M03_L25:
       call      qword ptr [7FF8AC0D7E40]
       int       3
       sub       rsp,28
       mov       rdx,[rbp-98]
       mov       rax,[rbp-88]
       cmp       rdx,[rax+10]
       je        short M03_L26
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-88]
M03_L26:
       mov       rbx,[rax+8]
       mov       rdx,[rbp-90]
       cmp       rdx,rbx
       je        short M03_L29
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M03_L27
       cmp       qword ptr [rbx+10],0
       jne       short M03_L28
M03_L27:
       cmp       qword ptr [rbp-90],0
       je        short M03_L29
       mov       rdx,[rbp-90]
       cmp       qword ptr [rdx+10],0
       je        short M03_L29
M03_L28:
       mov       rcx,rbx
       mov       rdx,[rbp-90]
       call      qword ptr [7FF8AC0DC5D0]
M03_L29:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF8AC04E5E0]
       lea       rax,[M03_L19]
       add       rsp,28
       ret
; Total bytes of code 1101
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF90A691D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF8AC0D4660]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF8AC0DD5F0]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF8AC0DD200]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF8AC2341F8]
       jmp       short M05_L02
; Total bytes of code 124
```

