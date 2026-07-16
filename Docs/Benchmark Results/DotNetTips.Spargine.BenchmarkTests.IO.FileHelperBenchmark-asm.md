## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.FileHelperBenchmark.CalculateTotalFileSize()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+1A0]
       test      rcx,rcx
       je        near ptr M00_L05
       lea       rsi,[rcx+10]
       mov       edi,[rcx+8]
M00_L00:
       test      edi,edi
       je        near ptr M00_L06
       xor       ebp,ebp
       xor       r14d,r14d
M00_L01:
       mov       r15,[rsi+r14*8]
       test      r15,r15
       je        short M00_L07
       mov       rcx,r15
       call      qword ptr [7FF9C1C60E18]; System.IO.FileInfo.get_Exists()
       test      eax,eax
       je        short M00_L07
       cmp       dword ptr [r15+28],0FFFFFFFF
       je        short M00_L08
M00_L02:
       cmp       dword ptr [r15+28],0
       jne       near ptr M00_L10
       test      byte ptr [r15+30],10
       jne       short M00_L09
       cmp       dword ptr [r15+28],0
       jne       near ptr M00_L10
       mov       ecx,[r15+4C]
       shl       rcx,20
       mov       eax,[r15+50]
       or        rcx,rax
M00_L03:
       add       rbp,rcx
       jo        near ptr M00_L11
       inc       r14d
       cmp       r14d,edi
       jl        short M00_L01
       mov       rax,rbp
M00_L04:
       mov       rcx,[rbx+88]
       mov       [rcx+18],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L05:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L00
M00_L06:
       xor       eax,eax
       jmp       short M00_L04
M00_L07:
       xor       ecx,ecx
       jmp       short M00_L03
M00_L08:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [r15+30],ymm0
       vmovdqu   xmmword ptr [r15+44],xmm0
       mov       rcx,r15
       call      qword ptr [7FF9C1F1DBA8]
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.IO.FileNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF9C1F1DBC0]
       mov       rcx,rax
       mov       rdx,[r15+8]
       call      qword ptr [7FF9C1DFE8E0]
       mov       rdx,rax
       mov       r8,[r15+8]
       mov       rcx,rbp
       call      qword ptr [7FF9C1F1DBD8]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       ecx,[r15+28]
       mov       rdx,[r15+8]
       xor       r8d,r8d
       call      qword ptr [7FF9C1F1D3F8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 309
```
```assembly
; System.IO.FileInfo.get_Exists()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,2C0
       vzeroupper
       lea       rbp,[rsp+2F0]
       xor       eax,eax
       mov       [rbp-2C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-2C0],ymm4
       mov       [rbp-2A0],rax
       mov       rax,0ADDF3EB91113
       mov       [rbp-38],rax
       mov       rbx,rcx
       cmp       dword ptr [rbx+28],0FFFFFFFF
       jne       near ptr M01_L15
       mov       rsi,[rbx+8]
       lea       rdi,[rbx+30]
       xor       r14d,r14d
       test      rsi,rsi
       je        short M01_L01
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        short M01_L01
       lea       r13d,[r15-1]
       mov       ecx,r13d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M01_L20
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M01_L00:
       test      ecx,ecx
       jne       near ptr M01_L21
M01_L01:
       mov       r15,rsi
M01_L02:
       xor       ecx,ecx
       mov       [rbp-298],rcx
       mov       [rbp-294],ecx
       call      00007FF9C1858C78
       lea       rdx,[rbp-294]
       mov       ecx,1
       call      00007FF9C1858C90
       mov       esi,eax
       call      00007FF9C1858CA8
       mov       ecx,eax
       call      00007FFA214E1F40
       test      esi,esi
       setne     cl
       movzx     ecx,cl
       mov       [rbp-298],cl
       movzx     ecx,byte ptr [rbp-298]
       mov       [rbp-2B4],cl
       mov       ecx,[rbp-294]
       mov       [rbp-2B8],ecx
       test      r15,r15
       je        short M01_L03
       cmp       dword ptr [r15+8],104
       jge       near ptr M01_L06
       mov       rcx,r15
       call      qword ptr [7FF9C1AFFF78]; System.IO.PathInternal.EndsWithPeriodOrSpace(System.String)
       test      eax,eax
       jne       short M01_L06
M01_L03:
       mov       rsi,r15
M01_L04:
       mov       [rbp-2A0],rdi
       mov       r13,rdi
       test      rsi,rsi
       je        short M01_L07
       add       rsi,0C
M01_L05:
       mov       [rbp-2A8],rsi
       xor       ecx,ecx
       call      00007FF9C1858C78
       mov       rcx,rsi
       mov       r8,r13
       xor       edx,edx
       call      00007FF9C1858CC0
       mov       esi,eax
       call      00007FF9C1858CA8
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2A8],rax
       mov       [rbp-2A0],rax
       call      00007FFA214E1F40
       test      esi,esi
       jne       near ptr M01_L11
       call      00007FFA214E1F20
       mov       r14d,eax
       mov       ecx,r14d
       call      qword ptr [7FF9C1E87048]; System.IO.FileSystem.IsPathUnreachableError(Int32)
       test      eax,eax
       jne       near ptr M01_L11
       jmp       short M01_L08
M01_L06:
       mov       rcx,r15
       call      qword ptr [7FF9C1E870C0]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L07:
       xor       esi,esi
       jmp       short M01_L05
M01_L08:
       lea       rcx,[rbp-288]
       mov       edx,250
       call      qword ptr [7FF9C18657E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       lea       rdx,[rbp-288]
       mov       rcx,r15
       call      qword ptr [7FF9C1F1E7D8]
       mov       [rbp-2D0],rax
       mov       rcx,[rbp-2D0]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C19D7810]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       je        short M01_L09
       call      00007FFA214E1F20
       mov       r14d,eax
       jmp       short M01_L10
M01_L09:
       xor       r14d,r14d
       lea       rdx,[rbp-288]
       mov       rcx,rdi
       call      qword ptr [7FF9C1F1E7F0]
       nop
M01_L10:
       mov       rcx,[rbp-2D0]
       mov       edx,1
       call      qword ptr [7FF9C186DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2D0]
       call      qword ptr [7FF9C1A35578]; System.GC.SuppressFinalize(System.Object)
       nop
M01_L11:
       cmp       byte ptr [rbp-2B4],0
       je        short M01_L12
       xor       ecx,ecx
       mov       [rbp-2B0],ecx
       call      00007FF9C1858C78
       lea       rdx,[rbp-2B0]
       mov       ecx,[rbp-2B8]
       call      00007FF9C1858C90
       call      00007FF9C1858CA8
       mov       ecx,eax
       call      00007FFA214E1F40
M01_L12:
       test      r14d,r14d
       jne       short M01_L16
M01_L13:
       mov       eax,r14d
M01_L14:
       mov       [rbx+28],eax
M01_L15:
       cmp       dword ptr [rbx+28],0
       jne       short M01_L18
       cmp       dword ptr [rbx+30],0FFFFFFFF
       je        short M01_L18
       test      byte ptr [rbx+30],10
       sete      al
       movzx     eax,al
       jmp       short M01_L19
M01_L16:
       lea       eax,[r14-2]
       cmp       eax,1
       ja        short M01_L22
M01_L17:
       mov       dword ptr [rdi],0FFFFFFFF
       xor       eax,eax
       jmp       short M01_L14
M01_L18:
       xor       eax,eax
M01_L19:
       mov       [rbp-28C],eax
       jmp       short M01_L23
M01_L20:
       mov       ecx,1
       jmp       near ptr M01_L00
M01_L21:
       lea       rcx,[rsi+0C]
       mov       [rbp-2C8],rcx
       mov       [rbp-2C0],r15d
       lea       rcx,[rbp-2C8]
       call      qword ptr [7FF9C1E87078]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r15d
       je        near ptr M01_L01
       mov       r8d,r13d
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF9C1AF7438]; System.String.Substring(Int32, Int32)
       mov       r15,rax
       jmp       near ptr M01_L02
M01_L22:
       cmp       r14d,15
       jne       near ptr M01_L13
       jmp       short M01_L17
M01_L23:
       mov       eax,[rbp-28C]
       mov       r8,0ADDF3EB91113
       cmp       [rbp-38],r8
       je        short M01_L24
       call      CORINFO_HELP_FAIL_FAST
M01_L24:
       nop
       add       rsp,2C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-2D0],0
       je        short M01_L25
       mov       rcx,[rbp-2D0]
       mov       edx,1
       call      qword ptr [7FF9C186DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2D0]
       call      qword ptr [7FF9C1A35578]; System.GC.SuppressFinalize(System.Object)
M01_L25:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       byte ptr [rbp-2B4],0
       je        short M01_L26
       xor       ecx,ecx
       mov       [rbp-2B0],ecx
       call      00007FF9C1858C78
       lea       rdx,[rbp-2B0]
       mov       ecx,[rbp-2B8]
       call      00007FF9C1858C90
       call      00007FF9C1858CA8
       mov       ecx,eax
       call      00007FFA214E1F40
M01_L26:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       xor       eax,eax
       mov       [rbp-28C],eax
       lea       rax,[M01_L23]
       add       rsp,28
       ret
; Total bytes of code 917
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.FileHelperBenchmark.CheckPermission()
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
       mov       rbx,rcx
       mov       rcx,[rbx+1A0]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L76
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        near ptr M00_L45
       mov       rcx,offset MT_System.Security.AccessControl.FileSecurity
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+8]
       test      rsi,rsi
       je        near ptr M00_L46
       lea       r14,[rsi+0C]
       mov       rcx,r14
       mov       r15d,[rsi+8]
       mov       r8d,r15d
       test      r8d,r8d
       je        near ptr M00_L48
       xor       edx,edx
M00_L00:
       cmp       word ptr [rcx+rdx*2],20
       je        near ptr M00_L47
       mov       rcx,r14
       mov       r8d,r15d
       xor       edx,edx
       call      qword ptr [7FF9C1ADF0A8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M00_L49
       cmp       r15d,4
       jl        short M00_L01
       cmp       word ptr [r14],5C
       je        near ptr M00_L50
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FF9C1ADF0F0]; System.IO.PathHelper.Normalize(System.String)
       mov       rsi,rax
M00_L02:
       test      rsi,rsi
       je        short M00_L03
       cmp       dword ptr [rsi+8],104
       jge       near ptr M00_L06
       cmp       dword ptr [rsi+8],0
       je        short M00_L03
       mov       ecx,[rsi+8]
       dec       ecx
       cmp       ecx,[rsi+8]
       jae       near ptr M00_L76
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M00_L06
       cmp       ecx,2E
       je        near ptr M00_L06
M00_L03:
       mov       rcx,2482E802228
       mov       r14,[rcx]
       test      r14,r14
       jne       short M00_L04
       mov       rcx,offset MT_System.Security.AccessControl.NativeObjectSecurity+ExceptionFromErrorCode
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF9C178D930
       mov       [r14+18],rcx
       mov       rcx,7FF9C1E6B348
       mov       [r14+20],rcx
       mov       rcx,2482E802228
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L04:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       byte ptr [r15+8],0
       mov       r13,r14
       test      rsi,rsi
       je        near ptr M00_L52
       lea       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,rsi
       mov       ecx,1
       xor       r8d,r8d
       mov       r9d,0E
       call      qword ptr [7FF9C1E6F438]; System.Security.AccessControl.Win32.GetSecurityInfo(System.Security.AccessControl.ResourceType, System.String, System.Runtime.InteropServices.SafeHandle, System.Security.AccessControl.AccessControlSections, System.Security.AccessControl.RawSecurityDescriptor ByRef)
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M00_L07
       mov       [rsp+20],r15
       mov       edx,r12d
       mov       r8,rsi
       xor       r9d,r9d
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      rax,rax
       jne       short M00_L05
       cmp       r12d,5
       jne       near ptr M00_L38
       mov       rcx,offset MT_System.UnauthorizedAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,288C3681918
       call      qword ptr [7FF9C1EFC858]
       mov       rcx,80131500E0434352
       mov       [rbx+68],rcx
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+6C],80070005
       mov       rax,rbx
M00_L05:
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       rcx,rsi
       call      qword ptr [7FF9C1EFC840]
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L07:
       mov       rcx,offset MT_System.Security.AccessControl.CommonSecurityDescriptor
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r12,[rbp-40]
       test      r12,r12
       je        near ptr M00_L59
       mov       esi,[r12+28]
       mov       r14,[r12+8]
       mov       rax,[r12+10]
       mov       [rbp-58],rax
       cmp       qword ptr [r12+18],0
       jne       near ptr M00_L60
       xor       edx,edx
M00_L08:
       mov       [rbp-44],esi
       mov       [rbp-60],r14
       mov       rax,[rbp-58]
       mov       [rbp-68],rax
       mov       [rbp-70],rdx
       cmp       qword ptr [r12+20],0
       je        near ptr M00_L71
       mov       rcx,offset MT_System.Security.AccessControl.DiscretionaryAcl
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,[r12+20]
       mov       rsi,r14
       test      rdx,rdx
       je        near ptr M00_L61
       mov       word ptr [rsi+12],0
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+8]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+10]
       dec       edx
       mov       esi,edx
       test      esi,esi
       jl        near ptr M00_L15
M00_L09:
       mov       rdx,[r14+8]
       mov       rdx,[rdx+8]
       cmp       esi,[rdx+10]
       jae       near ptr M00_L69
       mov       rdx,[rdx+8]
       cmp       esi,[rdx+8]
       jae       near ptr M00_L76
       mov       r12,[rdx+rsi*8+10]
       mov       rdx,r12
       test      rdx,rdx
       je        short M00_L10
       mov       rcx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [rdx],rcx
       jne       near ptr M00_L62
M00_L10:
       test      rdx,rdx
       je        short M00_L11
       cmp       dword ptr [rdx+0C],0
       je        near ptr M00_L63
M00_L11:
       cmp       byte ptr [r14+12],0
       jne       near ptr M00_L65
       movzx     ecx,byte ptr [r12+0B]
       test      cl,8
       jne       near ptr M00_L63
       test      cl,0F
       jne       near ptr M00_L64
M00_L12:
       mov       rax,rdx
       test      rax,rax
       je        short M00_L13
       mov       rcx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [rax],rcx
       jne       near ptr M00_L67
M00_L13:
       and       byte ptr [r12+0B],3F
       test      rax,rax
       je        short M00_L14
       cmp       dword ptr [rax+20],0
       jne       near ptr M00_L68
M00_L14:
       dec       esi
       jns       near ptr M00_L09
M00_L15:
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FF9C1E6FAE0]; System.Security.AccessControl.CommonAcl.CanonicalCheck(Boolean)
       test      eax,eax
       je        near ptr M00_L70
       mov       rcx,r14
       mov       edx,1
       mov       r8d,1
       call      qword ptr [7FF9C1E6FAF8]; System.Security.AccessControl.CommonAcl.Canonicalize(Boolean, Boolean)
       mov       byte ptr [r14+11],1
M00_L16:
       mov       esi,[rbp-44]
       mov       r12,[rbp-60]
       mov       rax,[rbp-68]
       mov       r8,[rbp-70]
M00_L17:
       mov       [rsp+20],r12
       mov       [rsp+28],rax
       mov       [rsp+30],r8
       mov       [rsp+38],r14
       xor       r8d,r8d
       xor       edx,edx
       mov       rcx,r15
       mov       r9d,esi
       call      qword ptr [7FF9C1E6FC00]; System.Security.AccessControl.CommonSecurityDescriptor.CreateFromParts(Boolean, Boolean, System.Security.AccessControl.ControlFlags, System.Security.Principal.SecurityIdentifier, System.Security.Principal.SecurityIdentifier, System.Security.AccessControl.SystemAcl, System.Security.AccessControl.DiscretionaryAcl)
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       rcx,4000000080000000
       mov       [rdi+30],rcx
       mov       rcx,1000000020000000
       mov       [rdi+38],rcx
       mov       rcx,offset MT_System.Threading.ReaderWriterLockSlim
       call      CORINFO_HELP_NEWSFAST
       mov       byte ptr [rax+4C],1
       mov       qword ptr [rax+40],0FFFFFFFFFFFFFFFF
       mov       byte ptr [rax+4D],1
       mov       rcx,7FF9C178B188
       mov       edx,1
       lock xadd [rcx],rdx
       inc       rdx
       mov       [rax+28],rdx
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+1C],1
       lea       rcx,[rdi+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,288C3680FF0
       mov       [rsp+20],rcx
       mov       rcx,rdi
       mov       edx,1
       mov       r8d,1
       mov       r9d,1
       call      qword ptr [7FF9C1E6FC48]; System.Security.AccessControl.CommonObjectSecurity.GetRules(Boolean, Boolean, Boolean, System.Type)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L75
       xor       edi,edi
       xor       r14d,r14d
       mov       r15,[rsi+8]
       test      r15,r15
       je        near ptr M00_L44
M00_L18:
       mov       rcx,offset MT_System.Collections.ArrayList
       cmp       [r15],rcx
       jne       near ptr M00_L72
       mov       rcx,offset MT_System.Collections.ArrayList+ArrayListEnumeratorSimple
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FF9C1E6FF78]; System.Collections.ArrayList+ArrayListEnumeratorSimple..ctor(System.Collections.ArrayList)
M00_L19:
       mov       [rbp-80],rsi
       cmp       qword ptr [rbp-80],0
       je        near ptr M00_L25
       mov       rcx,offset MT_System.Collections.ArrayList+ArrayListEnumeratorSimple
       mov       rdx,[rbp-80]
       cmp       [rdx],rcx
       jne       near ptr M00_L25
       jmp       short M00_L22
M00_L20:
       mov       rcx,offset MT_System.Security.AccessControl.FileSystemAccessRule
       cmp       [rsi],rcx
       jne       near ptr M00_L28
M00_L21:
       mov       ecx,[rsi+10]
       mov       eax,ecx
       not       eax
       and       eax,20089
       mov       rdx,[rbp-80]
       jne       short M00_L22
       cmp       dword ptr [rsi+20],0
       jne       near ptr M00_L29
       mov       edi,1
M00_L22:
       mov       rcx,rdx
       call      qword ptr [7FF9C1EDFD50]; System.Collections.ArrayList+ArrayListEnumeratorSimple.MoveNext()
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,[rbp-80]
       call      qword ptr [7FF9C1EDFD58]; System.Collections.ArrayList+ArrayListEnumeratorSimple.get_Current()
       mov       rsi,rax
       test      rsi,rsi
       je        short M00_L21
       jmp       short M00_L20
M00_L23:
       mov       rcx,offset MT_System.Security.AccessControl.FileSystemAccessRule
       cmp       [rsi],rcx
       jne       near ptr M00_L32
M00_L24:
       mov       ecx,[rsi+10]
       mov       eax,ecx
       not       eax
       and       eax,20089
       jne       short M00_L25
       cmp       dword ptr [rsi+20],0
       jne       near ptr M00_L33
       mov       edi,1
M00_L25:
       mov       rcx,offset MT_System.Collections.ArrayList+ArrayListEnumeratorSimple
       mov       rdx,[rbp-80]
       cmp       [rdx],rcx
       jne       short M00_L30
       mov       rcx,rdx
       call      qword ptr [7FF9C1EDFD50]; System.Collections.ArrayList+ArrayListEnumeratorSimple.MoveNext()
M00_L26:
       test      eax,eax
       je        near ptr M00_L34
       mov       rcx,offset MT_System.Collections.ArrayList+ArrayListEnumeratorSimple
       mov       rax,[rbp-80]
       cmp       [rax],rcx
       jne       short M00_L31
       mov       rcx,rax
       call      qword ptr [7FF9C1EDFD58]; System.Collections.ArrayList+ArrayListEnumeratorSimple.get_Current()
M00_L27:
       mov       rsi,rax
       test      rsi,rsi
       je        short M00_L24
       jmp       short M00_L23
M00_L28:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L29:
       cmp       dword ptr [rsi+20],1
       sete      r15b
       movzx     r15d,r15b
       test      r15d,r15d
       je        near ptr M00_L22
       mov       r14d,1
       jmp       near ptr M00_L22
M00_L30:
       mov       rcx,rdx
       mov       r11,7FF9C17909D8
       call      qword ptr [r11]
       jmp       short M00_L26
M00_L31:
       mov       rcx,rax
       mov       r11,7FF9C17909E0
       call      qword ptr [r11]
       jmp       short M00_L27
M00_L32:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L33:
       cmp       dword ptr [rsi+20],1
       sete      r15b
       movzx     r15d,r15b
       test      r15d,r15d
       je        near ptr M00_L25
       mov       r14d,1
       jmp       near ptr M00_L25
M00_L34:
       mov       rcx,[rbp-80]
       mov       rax,rcx
       test      rax,rax
       je        short M00_L35
       mov       rdx,offset MT_System.Collections.ArrayList+ArrayListEnumeratorSimple
       cmp       [rax],rdx
       jne       near ptr M00_L73
       xor       eax,eax
M00_L35:
       test      rax,rax
       je        short M00_L36
       mov       rcx,rax
       mov       r11,7FF9C17909E8
       call      qword ptr [r11]
M00_L36:
       test      edi,edi
       je        near ptr M00_L74
       test      r14d,r14d
       sete      cl
       movzx     ecx,cl
M00_L37:
       mov       [rbp-50],cl
       mov       rcx,[rbx+88]
       lea       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1EF4030]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
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
M00_L38:
       cmp       r12d,51B
       je        near ptr M00_L42
       cmp       r12d,51C
       je        near ptr M00_L41
       cmp       r12d,57
       je        short M00_L40
       cmp       r12d,7B
       je        short M00_L39
       cmp       r12d,2
       jne       near ptr M00_L55
       jmp       near ptr M00_L54
M00_L39:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,288C3681190
       call      qword ptr [7FF9C1EFC5B8]
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1EFC6A8]
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+6C],80131501
       mov       rcx,288C3670200
       mov       [rbx+70],rcx
       mov       dword ptr [rbx+6C],80070057
       mov       rax,rbx
       jmp       near ptr M00_L05
M00_L40:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,288C3681140
       call      qword ptr [7FF9C1EFC5B8]
       mov       rsi,rax
       mov       dword ptr [rbx+8],57
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9C1EFC0F0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9C1BC61A8]
       mov       rax,rdi
       jmp       near ptr M00_L05
M00_L41:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,288C3681090
       call      qword ptr [7FF9C1EFC5B8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1BC61A8]
       mov       rax,rbx
       jmp       near ptr M00_L05
M00_L42:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,288C3681040
       call      qword ptr [7FF9C1EFC5B8]
       mov       rdx,rax
       test      rdx,rdx
       je        near ptr M00_L53
M00_L43:
       mov       rcx,80131500E0434352
       mov       [rbx+68],rcx
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+6C],80131509
       mov       rax,rbx
       jmp       near ptr M00_L05
M00_L44:
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,2482E801AF0
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L18
M00_L45:
       call      qword ptr [7FF9C1DCF0D8]
       mov       ecx,0A39
       mov       rdx,7FF9C1ED3790
       call      qword ptr [7FF9C184F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9C1B14C98
       call      qword ptr [7FF9C184F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C184D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9C1ED3790
       call      qword ptr [7FF9C184F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C184D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9C1EFCA38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9C1EFCA50]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L46:
       mov       ecx,1AC3E
       mov       rdx,7FF9C1784000
       call      qword ptr [7FF9C184F210]
       mov       rcx,rax
       call      qword ptr [7FF9C1EF6A18]
       int       3
M00_L47:
       inc       edx
       cmp       edx,r8d
       jl        near ptr M00_L00
M00_L48:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1EF72A0]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FF9C1784000
       call      qword ptr [7FF9C184F210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9C1BC6250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L49:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1EF72B8]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FF9C1784000
       call      qword ptr [7FF9C184F210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9C1BC6250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L50:
       cmp       word ptr [r14+2],5C
       je        short M00_L51
       cmp       word ptr [r14+2],3F
       jne       near ptr M00_L01
M00_L51:
       cmp       word ptr [r14+4],3F
       jne       near ptr M00_L01
       cmp       word ptr [r14+6],5C
       jne       near ptr M00_L01
       jmp       near ptr M00_L02
M00_L52:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0D89
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1BC5A58]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L53:
       mov       rcx,288C36818C8
       call      qword ptr [7FF9C1EFC858]
       mov       rdx,rax
       jmp       near ptr M00_L43
M00_L54:
       mov       rcx,offset MT_System.IO.FileNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9C1EFC870]
       mov       rax,rbx
       jmp       near ptr M00_L05
M00_L55:
       cmp       r12d,3
       jne       short M00_L56
       mov       rcx,offset MT_System.IO.FileNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF9C1EFC870]
       mov       rax,rbx
       jmp       near ptr M00_L05
M00_L56:
       cmp       r12d,546
       jne       short M00_L57
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,288C36810E0
       call      qword ptr [7FF9C1EFC5B8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C184F228]
       mov       rax,rbx
       jmp       near ptr M00_L05
M00_L57:
       cmp       r12d,0E9
       jne       short M00_L58
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,288C36811D0
       call      qword ptr [7FF9C1EFC5B8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1BC61A8]
       mov       rax,rbx
       jmp       near ptr M00_L05
M00_L58:
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,288C3681140
       call      qword ptr [7FF9C1EFC5B8]
       mov       rbx,rax
       mov       [rsi+8],r12d
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9C1EFC0F0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9C1BC61A8]
       mov       rax,rdi
       jmp       near ptr M00_L05
M00_L59:
       mov       ecx,0EAB
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       rcx,rax
       call      qword ptr [7FF9C1EF6A18]
       int       3
M00_L60:
       mov       rcx,offset MT_System.Security.AccessControl.SystemAcl
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-78],rdx
       mov       dword ptr [rsp+20],1
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9,[r12+18]
       mov       rcx,rdx
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF9C1E6FA80]; System.Security.AccessControl.CommonAcl..ctor(Boolean, Boolean, System.Security.AccessControl.RawAcl, Boolean, Boolean)
       mov       rdx,[rbp-78]
       jmp       near ptr M00_L08
M00_L61:
       mov       ecx,0CBD
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       rcx,rax
       call      qword ptr [7FF9C1EF6A18]
       int       3
M00_L62:
       mov       rdx,r12
       mov       rcx,offset MT_System.Security.AccessControl.KnownAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L63:
       mov       rcx,[r14+8]
       mov       rcx,[rcx+8]
       mov       edx,esi
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1933610]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       jmp       near ptr M00_L14
M00_L64:
       and       ecx,0F0
       mov       [r12+0B],cl
       jmp       near ptr M00_L12
M00_L65:
       movzx     ecx,byte ptr [r12+0B]
       test      cl,8
       je        short M00_L66
       test      cl,2
       jne       short M00_L66
       test      cl,1
       je        short M00_L63
M00_L66:
       test      cl,4
       je        near ptr M00_L12
       test      cl,2
       jne       near ptr M00_L12
       test      cl,1
       jne       near ptr M00_L12
       and       ecx,0FB
       mov       [r12+0B],cl
       jmp       near ptr M00_L12
M00_L67:
       mov       rcx,offset MT_System.Security.AccessControl.QualifiedAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       jmp       near ptr M00_L13
M00_L68:
       cmp       dword ptr [rax+20],1
       jne       near ptr M00_L63
       jmp       near ptr M00_L14
M00_L69:
       call      qword ptr [7FF9C1EF49A8]
       int       3
M00_L70:
       mov       byte ptr [r14+11],0
       jmp       near ptr M00_L16
M00_L71:
       mov       r12,r14
       mov       r8,rdx
       xor       r14d,r14d
       jmp       near ptr M00_L17
M00_L72:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rsi,rax
       jmp       near ptr M00_L19
M00_L73:
       mov       rdx,rcx
       mov       rcx,offset MT_System.IDisposable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       near ptr M00_L35
M00_L74:
       xor       ecx,ecx
       jmp       near ptr M00_L37
M00_L75:
       xor       ecx,ecx
       jmp       near ptr M00_L37
M00_L76:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,48
       mov       rcx,[rbp-80]
       mov       rax,rcx
       test      rax,rax
       je        short M00_L78
       mov       rdx,offset MT_System.Collections.ArrayList+ArrayListEnumeratorSimple
       cmp       [rax],rdx
       je        short M00_L77
       mov       rdx,rcx
       mov       rcx,offset MT_System.IDisposable
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       jmp       short M00_L78
M00_L77:
       xor       eax,eax
M00_L78:
       test      rax,rax
       je        short M00_L79
       mov       rcx,rax
       mov       r11,7FF9C17909E8
       call      qword ptr [r11]
M00_L79:
       nop
       add       rsp,48
       ret
; Total bytes of code 3394
```
```assembly
; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       cmp       r8d,8
       jl        short M01_L03
       cmp       r8d,10
       jl        near ptr M01_L09
       vmovd     xmm0,edx
       vpbroadcastw ymm0,xmm0
       lea       edx,[r8-10]
       mov       eax,edx
       lea       rax,[rcx+rax*2]
       vpcmpeqw  ymm1,ymm0,[rcx]
       vptest    ymm1,ymm1
       jne       near ptr M01_L11
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M01_L00:
       add       rcx,20
       cmp       rcx,rax
       ja        short M01_L01
       vpcmpeqw  ymm1,ymm0,[rcx]
       vptest    ymm1,ymm1
       jne       near ptr M01_L11
       jmp       short M01_L00
M01_L01:
       mov       r8d,r8d
       test      r8b,0F
       je        short M01_L02
       vpcmpeqw  ymm0,ymm0,[rax]
       vptest    ymm0,ymm0
       jne       near ptr M01_L11
M01_L02:
       xor       eax,eax
       vzeroupper
       ret
M01_L03:
       xor       eax,eax
       cmp       r8d,8
       jl        near ptr M01_L05
M01_L04:
       add       r8d,0FFFFFFF8
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+4]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+6]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+8]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+0A]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+0C]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+0E]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       add       rax,8
       cmp       r8d,8
       jge       near ptr M01_L04
M01_L05:
       cmp       r8d,4
       jl        short M01_L07
       add       r8d,0FFFFFFFC
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+4]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+6]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M01_L11
       add       rax,4
       jmp       short M01_L07
M01_L06:
       dec       r8d
       movsx     r10,word ptr [rcx+rax]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M01_L11
       add       rax,2
       jmp       short M01_L08
M01_L07:
       add       rax,rax
M01_L08:
       test      r8d,r8d
       jg        short M01_L06
       jmp       near ptr M01_L02
M01_L09:
       vmovd     xmm0,edx
       vpbroadcastw xmm0,xmm0
       lea       edx,[r8-8]
       mov       eax,edx
       lea       rax,[rcx+rax*2]
M01_L10:
       vpcmpeqw  xmm1,xmm0,[rcx]
       vptest    xmm1,xmm1
       jne       short M01_L11
       add       rcx,10
       cmp       rcx,rax
       jbe       short M01_L10
       mov       r8d,r8d
       test      r8b,7
       je        near ptr M01_L02
       vpcmpeqw  xmm0,xmm0,[rax]
       vptest    xmm0,xmm0
       je        near ptr M01_L02
M01_L11:
       mov       eax,1
       vzeroupper
       ret
; Total bytes of code 500
```
```assembly
; System.IO.PathHelper.Normalize(System.String)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqa   xmmword ptr [rbp+70],xmm4
       mov       [rbp+80],rax
       mov       rax,0BFBE0695C37
       mov       [rbp],rax
       mov       rbx,rcx
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp+28],rcx
       mov       rcx,rbp
       mov       [rbp+38],rcx
       test      [rsp],esp
       sub       rsp,210
       lea       rcx,[rsp+20]
       mov       [rbp+78],rcx
       mov       dword ptr [rbp+80],104
       xor       ecx,ecx
       mov       [rbp+70],ecx
       test      rbx,rbx
       jne       near ptr M02_L06
       xor       ecx,ecx
       xor       eax,eax
M02_L00:
       mov       [rbp+58],rcx
       mov       [rbp+60],eax
       mov       [rbp+0D0],rbx
M02_L01:
       mov       rdi,[rbp+58]
       mov       [rbp+8],rdi
       mov       r14d,[rbp+80]
       mov       r15,[rbp+78]
       mov       [rbp+50],r15
       mov       [rbp+48],rdi
       xor       ecx,ecx
       mov       rax,7FFA5D535FF0
       vzeroupper
       call      rax
       mov       rdi,[rbp+8]
       mov       rcx,rdi
       mov       edx,r14d
       mov       r8,r15
       xor       r9d,r9d
       mov       rax,7FF9C19BEF28
       mov       [rbp+20],rax
       lea       rax,[M02_L02]
       mov       [rbp+30],rax
       lea       rax,[rbp+10]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA5D545130
       vzeroupper
       call      rax
M02_L02:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA217A4A90],0
       je        short M02_L03
       call      qword ptr [7FFA21792648]; CORINFO_HELP_STOP_FOR_GC
M02_L03:
       mov       rcx,[rbp+18]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       rax,7FFA5D535F30
       vzeroupper
       call      rax
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp+48],rax
       mov       [rbp+50],rax
       call      00007FFA214E1F40
       mov       edx,ebx
       movsxd    rcx,dword ptr [rbp+80]
       cmp       rdx,rcx
       jg        near ptr M02_L16
       test      ebx,ebx
       je        near ptr M02_L17
       mov       [rbp+70],ebx
       mov       r8d,[rbp+70]
       cmp       r8d,[rbp+80]
       ja        near ptr M02_L18
       mov       rcx,[rbp+78]
       mov       edx,7E
       call      qword ptr [7FF9C1A1F810]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jge       near ptr M02_L29
       mov       ecx,[rbp+70]
       cmp       ecx,[rbp+80]
       ja        near ptr M02_L18
       mov       rax,[rbp+78]
       mov       rbx,[rbp+0D0]
       test      rbx,rbx
       jne       near ptr M02_L07
       xor       edx,edx
       xor       r8d,r8d
M02_L04:
       cmp       ecx,r8d
       jne       near ptr M02_L14
       test      r8d,r8d
       je        near ptr M02_L11
       mov       rcx,rax
       mov       r10,rdx
       mov       r8d,r8d
       add       r8,r8
       cmp       r8,8
       jb        near ptr M02_L19
       cmp       rcx,r10
       je        near ptr M02_L09
       cmp       r8,20
       jb        near ptr M02_L24
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M02_L08
       vmovups   ymm0,[rcx]
       vpcmpeqb  ymm0,ymm0,[r10]
       vpmovmskb edx,ymm0
       cmp       edx,0FFFFFFFF
       jne       near ptr M02_L28
M02_L05:
       add       rax,20
       cmp       r8,rax
       jbe       short M02_L08
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[r10+rax]
       vpmovmskb edx,ymm0
       cmp       edx,0FFFFFFFF
       jne       near ptr M02_L28
       jmp       short M02_L05
M02_L06:
       lea       rcx,[rbx+0C]
       mov       [rbp+0D0],rbx
       mov       eax,[rbx+8]
       mov       rbx,[rbp+0D0]
       jmp       near ptr M02_L00
M02_L07:
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       jmp       near ptr M02_L04
M02_L08:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[r10+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       near ptr M02_L28
M02_L09:
       mov       ecx,1
M02_L10:
       test      ecx,ecx
       je        short M02_L14
M02_L11:
       mov       rdx,[rbp+68]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+68],ymm0
       test      rdx,rdx
       jne       short M02_L15
M02_L12:
       mov       rax,rbx
       mov       r8,0BFBE0695C37
       cmp       [rbp],r8
       je        short M02_L13
       call      CORINFO_HELP_FAIL_FAST
M02_L13:
       nop
       vzeroupper
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L14:
       lea       rcx,[rbp+68]
       call      qword ptr [7FF9C1BC5410]; System.Text.ValueStringBuilder.ToString()
       mov       rbx,rax
       jmp       short M02_L11
M02_L15:
       mov       rcx,2482E800C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9C1B0FAD0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       jmp       short M02_L12
M02_L16:
       test      ebx,ebx
       jl        near ptr M02_L30
       mov       edx,ebx
       cmp       edx,[rbp+80]
       jbe       near ptr M02_L01
       mov       rbx,[rbp+0D0]
       sub       edx,[rbp+70]
       lea       rcx,[rbp+68]
       call      qword ptr [7FF9C1DCF7B0]; System.Text.ValueStringBuilder.Grow(Int32)
       mov       [rbp+0D0],rbx
       jmp       near ptr M02_L01
M02_L17:
       call      00007FFA214E1F20
       mov       ebx,eax
       mov       ecx,0A1
       test      ebx,ebx
       cmove     ebx,ecx
       lea       rcx,[rbp+58]
       call      qword ptr [7FF9C1A1F750]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rdx,rax
       mov       ecx,ebx
       xor       r8d,r8d
       call      qword ptr [7FF9C1EF70D8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M02_L18:
       call      qword ptr [7FF9C1A1F210]
       int       3
M02_L19:
       cmp       r8,4
       jae       short M02_L22
       xor       ecx,ecx
       mov       r10,r8
       and       r10,2
       je        short M02_L20
       movzx     ecx,word ptr [rax]
       movzx     r9d,word ptr [rdx]
       sub       ecx,r9d
M02_L20:
       test      r8b,1
       je        short M02_L21
       movzx     r8d,byte ptr [rax+r10]
       movzx     eax,byte ptr [rdx+r10]
       sub       r8d,eax
       or        ecx,r8d
M02_L21:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       jmp       short M02_L23
M02_L22:
       lea       rcx,[r8-4]
       mov       r8d,[rax]
       sub       r8d,[rdx]
       mov       eax,[rax+rcx]
       sub       eax,[rdx+rcx]
       or        eax,r8d
       sete      cl
       movzx     ecx,cl
M02_L23:
       jmp       near ptr M02_L10
M02_L24:
       cmp       r8,10
       jb        short M02_L27
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L26
M02_L25:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[r10+rax]
       vpmovmskb edx,xmm0
       cmp       edx,0FFFF
       jne       short M02_L28
       add       rax,10
       cmp       r8,rax
       ja        short M02_L25
M02_L26:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[r10+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M02_L28
       jmp       near ptr M02_L09
M02_L27:
       lea       rcx,[r8-8]
       mov       r8,[rax]
       sub       r8,[rdx]
       mov       rax,[rax+rcx]
       sub       rax,[rdx+rcx]
       or        rax,r8
       sete      cl
       movzx     ecx,cl
       jmp       short M02_L23
M02_L28:
       xor       ecx,ecx
       jmp       near ptr M02_L10
M02_L29:
       lea       rcx,[rbp+68]
       mov       rdx,[rbp+0D0]
       call      qword ptr [7FF9C1EF7660]
       mov       rbx,rax
       jmp       near ptr M02_L11
M02_L30:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1081
```
```assembly
; System.Security.AccessControl.Win32.GetSecurityInfo(System.Security.AccessControl.ResourceType, System.String, System.Runtime.InteropServices.SafeHandle, System.Security.AccessControl.AccessControlSections, System.Security.AccessControl.RawSecurityDescriptor ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0E8
       vzeroupper
       lea       rbp,[rsp+120]
       xor       eax,eax
       mov       [rbp-78],rax
       mov       [rbp+10],ecx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       ebx,r9d
       mov       rsi,[rbp+30]
       lea       rcx,[rbp-0C0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-88],rax
       mov       rcx,rsp
       mov       [rbp-0A8],rcx
       mov       rcx,rbp
       mov       [rbp-98],rcx
       xor       ecx,ecx
       mov       [rsi],rcx
       mov       [rbp-6C],ecx
       mov       [rbp-0C8],rcx
       mov       ecx,1
       test      bl,4
       cmove     ecx,[rbp-6C]
       mov       [rbp-6C],ecx
       mov       ecx,[rbp-6C]
       or        ecx,2
       test      bl,8
       cmove     ecx,[rbp-6C]
       mov       [rbp-6C],ecx
       mov       ecx,[rbp-6C]
       or        ecx,4
       test      bl,2
       cmove     ecx,[rbp-6C]
       mov       [rbp-6C],ecx
       test      bl,1
       jne       near ptr M03_L25
M03_L00:
       cmp       qword ptr [rbp-0C8],0
       jne       near ptr M03_L04
M03_L01:
       cmp       qword ptr [rbp+18],0
       je        near ptr M03_L05
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
       mov       rdx,[rbp+18]
       add       rdx,0C
       mov       rbx,rdx
       mov       [rbp-78],rbx
       call      00007FF9C1838D98
       lea       r9,[rbp-50]
       mov       [rsp+20],r9
       lea       r9,[rbp-58]
       mov       [rsp+28],r9
       lea       r9,[rbp-60]
       mov       [rsp+30],r9
       lea       r9,[rbp-68]
       mov       [rsp+38],r9
       lea       r9,[rbp-48]
       mov       rcx,rbx
       mov       edx,[rbp+10]
       mov       r8d,[rbp-6C]
       call      00007FF9C1838DB0
       mov       ebx,eax
       call      00007FF9C1838DC8
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-78],rax
       call      00007FFA214E1F40
       mov       [rbp-3C],ebx
M03_L02:
       cmp       dword ptr [rbp-3C],0
       jne       short M03_L03
       mov       rcx,[rbp-68]
       test      rcx,rcx
       je        near ptr M03_L08
M03_L03:
       cmp       dword ptr [rbp-3C],514
       je        near ptr M03_L09
       cmp       dword ptr [rbp-3C],522
       je        near ptr M03_L09
       cmp       dword ptr [rbp-3C],5
       je        near ptr M03_L10
       cmp       dword ptr [rbp-3C],543
       je        near ptr M03_L10
       cmp       dword ptr [rbp-3C],0
       je        near ptr M03_L11
       jmp       near ptr M03_L26
M03_L04:
       mov       rcx,[rbp-0C8]
       mov       edx,1
       call      qword ptr [7FF9C1EFC8B8]
       jmp       near ptr M03_L01
M03_L05:
       cmp       qword ptr [rbp+20],0
       je        near ptr M03_L07
       mov       rcx,[rbp+20]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L06
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1EFC8D0]
       mov       rsi,rax
       mov       ecx,0D93
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9C1BC6250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L06:
       lea       r9,[rbp-50]
       mov       [rsp+20],r9
       lea       r9,[rbp-58]
       mov       [rsp+28],r9
       lea       r9,[rbp-60]
       mov       [rsp+30],r9
       lea       r9,[rbp-68]
       mov       [rsp+38],r9
       lea       r9,[rbp-48]
       mov       rcx,[rbp+20]
       mov       edx,[rbp+10]
       mov       r8d,[rbp-6C]
       call      qword ptr [7FF9C1EFC8E8]
       mov       [rbp-3C],eax
       jmp       near ptr M03_L02
M03_L07:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1EFC900]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1EFC918]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1BC61A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L09:
       mov       rcx,offset MT_System.Security.AccessControl.PrivilegeNotHeldException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0F1B
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1EFC930]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L10:
       mov       rcx,offset MT_System.UnauthorizedAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1EFC948]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       cmp       qword ptr [rbp-0C8],0
       jne       near ptr M03_L27
M03_L12:
       mov       rcx,[rbp-68]
       mov       rax,7FF9C1ED8A88
       mov       [rbp-0B0],rax
       lea       rax,[M03_L13]
       mov       [rbp-0A0],rax
       mov       rax,[rbp-88]
       lea       rdx,[rbp-0C0]
       mov       [rax+8],rdx
       mov       rax,[rbp-88]
       mov       byte ptr [rax+4],0
       mov       rax,7FFA5CFDBE40
       call      rax
M03_L13:
       mov       rcx,[rbp-88]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFA217A4A90],0
       je        short M03_L14
       call      qword ptr [7FFA21792648]; CORINFO_HELP_STOP_FOR_GC
M03_L14:
       mov       rdx,[rbp-88]
       mov       rcx,[rbp-0B8]
       mov       [rdx+8],rcx
       mov       ebx,eax
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       [rbp-0D0],rsi
       mov       rdx,[rbp-68]
       test      rdx,rdx
       je        near ptr M03_L28
       test      ebx,ebx
       jl        near ptr M03_L29
       lea       rcx,[rsi+10]
       mov       r8d,ebx
       call      qword ptr [7FF9C1845818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbp-68]
       test      rcx,0FFFFFFFFFFFF0000
       je        short M03_L17
       mov       rax,7FF9C19BDA58
       mov       [rbp-0B0],rax
       lea       rax,[M03_L15]
       mov       [rbp-0A0],rax
       mov       rax,[rbp-88]
       lea       rdx,[rbp-0C0]
       mov       [rax+8],rdx
       mov       rax,[rbp-88]
       mov       byte ptr [rax+4],0
       mov       rax,7FFA5D537EA0
       call      rax
M03_L15:
       mov       rcx,[rbp-88]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFA217A4A90],0
       je        short M03_L16
       call      qword ptr [7FFA21792648]; CORINFO_HELP_STOP_FOR_GC
M03_L16:
       mov       rcx,[rbp-88]
       mov       rax,[rbp-0B8]
       mov       [rcx+8],rax
M03_L17:
       mov       rcx,offset MT_System.Security.AccessControl.RawSecurityDescriptor
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,[rbp-0D0]
       mov       ecx,[rsi+8]
       cmp       ecx,14
       jl        near ptr M03_L30
       cmp       byte ptr [rsi+10],1
       jne       near ptr M03_L31
       movzx     edi,byte ptr [rsi+11]
       movzx     r14d,byte ptr [rsi+12]
       movzx     r15d,byte ptr [rsi+13]
       shl       r15d,8
       add       r14d,r15d
       test      r14d,8000
       je        near ptr M03_L32
       movzx     r15d,byte ptr [rsi+14]
       movzx     r13d,byte ptr [rsi+15]
       shl       r13d,8
       add       r15d,r13d
       movzx     r13d,byte ptr [rsi+16]
       shl       r13d,10
       add       r15d,r13d
       movzx     r13d,byte ptr [rsi+17]
       shl       r13d,18
       add       r15d,r13d
       je        near ptr M03_L33
       mov       rcx,offset MT_System.Security.Principal.SecurityIdentifier
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,rsi
       mov       r8d,r15d
       call      qword ptr [7FF9C1E6F6C0]; System.Security.Principal.SecurityIdentifier.CreateFromBinaryForm(Byte[], Int32)
M03_L18:
       movzx     r15d,byte ptr [rsi+18]
       movzx     r12d,byte ptr [rsi+19]
       shl       r12d,8
       add       r15d,r12d
       movzx     r12d,byte ptr [rsi+1A]
       shl       r12d,10
       add       r15d,r12d
       movzx     r12d,byte ptr [rsi+1B]
       shl       r12d,18
       add       r15d,r12d
       je        near ptr M03_L34
       mov       rcx,offset MT_System.Security.Principal.SecurityIdentifier
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       rdx,rsi
       mov       r8d,r15d
       call      qword ptr [7FF9C1E6F6C0]; System.Security.Principal.SecurityIdentifier.CreateFromBinaryForm(Byte[], Int32)
M03_L19:
       movzx     r15d,byte ptr [rsi+1C]
       movzx     eax,byte ptr [rsi+1D]
       shl       eax,8
       add       r15d,eax
       movzx     eax,byte ptr [rsi+1E]
       shl       eax,10
       add       r15d,eax
       movzx     eax,byte ptr [rsi+1F]
       shl       eax,18
       add       r15d,eax
       test      r14b,10
       jne       near ptr M03_L35
M03_L20:
       xor       r15d,r15d
M03_L21:
       movzx     eax,byte ptr [rsi+20]
       movzx     edx,byte ptr [rsi+21]
       shl       edx,8
       add       eax,edx
       movzx     edx,byte ptr [rsi+22]
       shl       edx,10
       add       eax,edx
       movzx     edx,byte ptr [rsi+23]
       shl       edx,18
       add       eax,edx
       mov       [rbp-7C],eax
       test      r14b,4
       je        near ptr M03_L36
       test      eax,eax
       je        near ptr M03_L36
       mov       rcx,offset MT_System.Security.AccessControl.RawAcl
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8d,[rbp-7C]
       call      qword ptr [7FF9C1E6F750]; System.Security.AccessControl.RawAcl.SetBinaryForm(Byte[], Int32)
       mov       rsi,[rbp-0D8]
M03_L22:
       mov       ecx,r14d
       or        ecx,8000
       mov       [rbx+28],ecx
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+2C],0
       test      r14d,4000
       jne       near ptr M03_L37
M03_L23:
       mov       rcx,[rbp+30]
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
M03_L24:
       add       rsp,0E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L25:
       mov       ecx,[rbp-6C]
       or        ecx,8
       mov       [rbp-6C],ecx
       mov       rcx,offset MT_System.Security.AccessControl.Privilege
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,288C3681228
       call      qword ptr [7FF9C1EFCC48]
       mov       [rbp-0C8],rbx
       jmp       near ptr M03_L00
M03_L26:
       call      M03_L41
       jmp       near ptr M03_L38
M03_L27:
       mov       rcx,[rbp-0C8]
       call      qword ptr [7FF9C1EFC960]
       jmp       near ptr M03_L12
M03_L28:
       mov       ecx,119F
       mov       rdx,7FF9C1784000
       call      qword ptr [7FF9C184F210]
       mov       rcx,rax
       call      qword ptr [7FF9C1EF6A18]
       int       3
M03_L29:
       mov       ecx,0B3
       mov       rdx,7FF9C1784000
       call      qword ptr [7FF9C184F210]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF9C1EF69E8]
       int       3
M03_L30:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0BEF
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       rsi,rax
       call      qword ptr [7FF9C1EF7EA0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9C1ADDA10]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L31:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0BEF
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       rsi,rax
       call      qword ptr [7FF9C1EFC408]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9C1ADDA10]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L32:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1EFC420]
       mov       rsi,rax
       mov       ecx,0BEF
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9C1BC6250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L33:
       xor       r13d,r13d
       jmp       near ptr M03_L18
M03_L34:
       xor       r12d,r12d
       jmp       near ptr M03_L19
M03_L35:
       test      r15d,r15d
       je        near ptr M03_L20
       mov       rcx,offset MT_System.Security.AccessControl.RawAcl
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0E0],rax
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8d,r15d
       call      qword ptr [7FF9C1E6F750]; System.Security.AccessControl.RawAcl.SetBinaryForm(Byte[], Int32)
       mov       r15,[rbp-0E0]
       jmp       near ptr M03_L21
M03_L36:
       xor       esi,esi
       jmp       near ptr M03_L22
M03_L37:
       mov       [rbx+2C],dil
       jmp       near ptr M03_L23
M03_L38:
       cmp       dword ptr [rbp-3C],8
       jne       short M03_L39
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1EF7DF8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L39:
       mov       eax,[rbp-3C]
       jmp       near ptr M03_L24
       sub       rsp,48
       vzeroupper
       lea       rax,[M03_L01]
       add       rsp,48
       ret
       sub       rsp,48
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M03_L40
       mov       rcx,[rbp-0C8]
       call      qword ptr [7FF9C1EFC960]
M03_L40:
       call      CORINFO_HELP_RETHROW
       int       3
M03_L41:
       sub       rsp,48
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M03_L42
       mov       rcx,[rbp-0C8]
       call      qword ptr [7FF9C1EFC960]
M03_L42:
       nop
       add       rsp,48
       ret
; Total bytes of code 2180
```
```assembly
; System.Security.AccessControl.CommonAcl.CanonicalCheck(Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      dl,dl
       je        near ptr M04_L07
       xor       esi,esi
       xor       edi,edi
       mov       rdx,[rbx+8]
       mov       rdx,[rdx+8]
       cmp       dword ptr [rdx+10],0
       jle       short M04_L03
M04_L00:
       mov       rdx,[rbx+8]
       mov       rdx,[rdx+8]
       cmp       edi,[rdx+10]
       jae       near ptr M04_L15
       mov       rdx,[rdx+8]
       cmp       edi,[rdx+8]
       jae       near ptr M04_L17
       mov       rdx,[rdx+rdi*8+10]
       test      byte ptr [rdx+0B],10
       je        short M04_L05
       mov       ebp,2
M04_L01:
       cmp       ebp,esi
       jg        short M04_L04
       cmp       ebp,esi
       jl        near ptr M04_L16
M04_L02:
       inc       edi
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       cmp       edi,[rcx+10]
       jl        short M04_L00
M04_L03:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L04:
       mov       esi,ebp
       jmp       short M04_L02
M04_L05:
       mov       rcx,offset MT_System.Security.AccessControl.QualifiedAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF9C1E6FAC8]; System.Security.AccessControl.GenericAce.op_Equality(System.Security.AccessControl.GenericAce, System.Security.AccessControl.GenericAce)
       test      eax,eax
       jne       near ptr M04_L16
       cmp       dword ptr [r14+20],0
       jne       short M04_L06
       mov       ebp,1
       jmp       short M04_L01
M04_L06:
       cmp       dword ptr [r14+20],1
       jne       near ptr M04_L16
       xor       ebp,ebp
       jmp       short M04_L01
M04_L07:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M04_L14
M04_L08:
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       cmp       edi,[rcx+10]
       jae       near ptr M04_L15
       mov       rcx,[rcx+8]
       cmp       edi,[rcx+8]
       jae       near ptr M04_L17
       mov       rbp,[rcx+rdi*8+10]
       mov       rcx,rbp
       xor       edx,edx
       call      qword ptr [7FF9C1E6FAC8]; System.Security.AccessControl.GenericAce.op_Equality(System.Security.AccessControl.GenericAce, System.Security.AccessControl.GenericAce)
       test      eax,eax
       jne       short M04_L13
       test      byte ptr [rbp+0B],10
       je        short M04_L09
       mov       r14d,1
       jmp       short M04_L11
M04_L09:
       mov       rdx,rbp
       mov       rcx,offset MT_System.Security.AccessControl.QualifiedAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF9C1E6FAC8]; System.Security.AccessControl.GenericAce.op_Equality(System.Security.AccessControl.GenericAce, System.Security.AccessControl.GenericAce)
       test      eax,eax
       jne       short M04_L16
       cmp       dword ptr [r14+20],2
       je        short M04_L10
       cmp       dword ptr [r14+20],3
       jne       short M04_L16
M04_L10:
       xor       r14d,r14d
M04_L11:
       cmp       r14d,esi
       jle       short M04_L12
       mov       esi,r14d
       jmp       short M04_L13
M04_L12:
       cmp       r14d,esi
       jl        short M04_L16
M04_L13:
       inc       edi
M04_L14:
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       cmp       edi,[rcx+10]
       jl        near ptr M04_L08
       jmp       near ptr M04_L03
M04_L15:
       call      qword ptr [7FF9C1EF49A8]
       int       3
M04_L16:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 389
```
```assembly
; System.Security.AccessControl.CommonAcl.Canonicalize(Boolean, Boolean)
M05_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       xor       ecx,ecx
       mov       rax,[rbx+8]
       mov       rax,[rax+8]
       mov       edx,[rax+10]
       test      edx,edx
       jle       short M05_L02
M05_L01:
       mov       r8,rax
       cmp       ecx,edx
       jae       near ptr M05_L10
       mov       r8,[r8+8]
       cmp       ecx,[r8+8]
       jae       near ptr M05_L105
       mov       r10d,ecx
       mov       r8,[r8+r10*8+10]
       mov       [r8+8],cx
       inc       ecx
       movzx     ecx,cx
       cmp       ecx,edx
       jl        short M05_L01
M05_L02:
       xor       ebp,ebp
       lea       r14d,[rdx-1]
       test      r14d,r14d
       jle       near ptr M05_L16
       mov       r15d,r14d
       test      edx,edx
       je        near ptr M05_L10
       mov       rcx,[rax+8]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M05_L105
       mov       r13,[rcx+10]
M05_L03:
       cmp       ebp,r14d
       jl        near ptr M05_L25
       mov       r14,[rbx+8]
       cmp       [r14],r14b
       test      r13,r13
       je        near ptr M05_L84
       mov       rcx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [r13],rcx
       jne       near ptr M05_L85
       mov       rcx,[r13+10]
       mov       rcx,[rcx+10]
       mov       eax,[rcx+8]
       add       eax,8
       cmp       qword ptr [r13+18],0
       je        near ptr M05_L11
       mov       rcx,[r13+18]
       mov       edx,[rcx+8]
M05_L04:
       add       eax,edx
M05_L05:
       test      al,3
       jne       near ptr M05_L86
       mov       rcx,r14
       call      qword ptr [7FF9C1EDA198]; System.Security.AccessControl.RawAcl.get_BinaryLength()
       mov       r12d,eax
       mov       rcx,[r14+8]
       mov       rax,rcx
       mov       eax,[rax+10]
       cmp       ebp,eax
       jge       near ptr M05_L87
       cmp       ebp,eax
       jae       near ptr M05_L10
       mov       rcx,[rcx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M05_L105
       mov       eax,ebp
       mov       rcx,[rcx+rax*8+10]
       mov       rax,offset MT_System.Security.AccessControl.CommonAce
       cmp       [rcx],rax
       jne       near ptr M05_L88
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       add       eax,8
       cmp       qword ptr [rcx+18],0
       je        short M05_L12
       mov       rcx,[rcx+18]
       mov       edx,[rcx+8]
M05_L06:
       add       eax,edx
M05_L07:
       mov       rcx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [r13],rcx
       jne       near ptr M05_L89
       mov       rcx,[r13+10]
       mov       rcx,[rcx+10]
       mov       edx,[rcx+8]
       add       edx,8
       cmp       qword ptr [r13+18],0
       je        short M05_L13
       mov       rcx,[r13+18]
       mov       r8d,[rcx+8]
M05_L08:
       add       edx,r8d
M05_L09:
       sub       r12d,eax
       add       edx,r12d
       cmp       edx,0FFFF
       jg        near ptr M05_L90
       mov       r14,[r14+8]
       cmp       ebp,[r14+10]
       jb        short M05_L14
M05_L10:
       call      qword ptr [7FF9C1EF49A8]
       int       3
M05_L11:
       xor       edx,edx
       jmp       near ptr M05_L04
M05_L12:
       xor       edx,edx
       jmp       short M05_L06
M05_L13:
       xor       r8d,r8d
       jmp       short M05_L08
M05_L14:
       mov       rcx,[r14+8]
       movsxd    rdx,ebp
       mov       r8,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [r14+14]
       test      ebp,ebp
       jg        near ptr M05_L91
M05_L15:
       cmp       r15d,ebp
       jle       short M05_L16
       lea       edx,[rbp+1]
       movzx     r9d,sil
       mov       rcx,rbx
       mov       r8d,r15d
       call      qword ptr [7FF9C1E6FB10]; System.Security.AccessControl.CommonAcl.QuickSort(Int32, Int32, Boolean)
M05_L16:
       test      dil,dil
       je        near ptr M05_L23
       xor       esi,esi
       jmp       near ptr M05_L21
M05_L17:
       mov       rdx,rdi
       cmp       esi,ebp
       jae       short M05_L10
       mov       rdx,[rdx+8]
       cmp       esi,[rdx+8]
       jae       near ptr M05_L105
       mov       rdx,[rdx+rsi*8+10]
       mov       r14,rdx
       test      r14,r14
       je        short M05_L18
       mov       rcx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [r14],rcx
       jne       near ptr M05_L92
M05_L18:
       test      r14,r14
       je        short M05_L20
       lea       edx,[rsi+1]
       cmp       edx,ebp
       jae       near ptr M05_L10
       mov       rcx,[rdi+8]
       cmp       edx,[rcx+8]
       jae       near ptr M05_L105
       mov       rdx,[rcx+rdx*8+10]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M05_L19
       mov       rcx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [rdi],rcx
       jne       near ptr M05_L93
M05_L19:
       test      rdi,rdi
       je        short M05_L20
       movzx     ecx,byte ptr [r14+0A]
       cmp       cl,[rdi+0A]
       jne       short M05_L20
       test      byte ptr [r14+0B],10
       je        near ptr M05_L94
M05_L20:
       inc       esi
M05_L21:
       cmp       byte ptr [rbx+10],0
       jne       near ptr M05_L104
M05_L22:
       mov       rdx,[rbx+8]
       mov       rdi,[rdx+8]
       mov       ebp,[rdi+10]
       lea       edx,[rbp-1]
       cmp       esi,edx
       jl        near ptr M05_L17
M05_L23:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M05_L24:
       dec       r14d
M05_L25:
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       cmp       r14d,[rcx+10]
       jae       near ptr M05_L10
       mov       rcx,[rcx+8]
       cmp       r14d,[rcx+8]
       jae       near ptr M05_L105
       mov       eax,r14d
       mov       r12,[rcx+rax*8+10]
       test      sil,sil
       je        near ptr M05_L39
       movzx     ecx,byte ptr [r12+0A]
       test      byte ptr [r12+0B],10
       je        near ptr M05_L40
       movzx     eax,word ptr [r12+8]
       add       eax,1FFFE
M05_L26:
       movzx     ecx,byte ptr [r13+0A]
       test      byte ptr [r13+0B],10
       je        near ptr M05_L49
       movzx     edx,word ptr [r13+8]
       add       edx,1FFFE
M05_L27:
       cmp       eax,edx
       jl        short M05_L31
       jg        short M05_L30
       mov       rax,r12
       test      rax,rax
       je        short M05_L28
       mov       rdx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [rax],rdx
       jne       near ptr M05_L58
M05_L28:
       mov       r12,rax
       test      r12,r12
       je        short M05_L30
       mov       rax,r13
       test      rax,rax
       je        short M05_L29
       mov       rdx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [rax],rdx
       jne       near ptr M05_L59
M05_L29:
       test      rax,rax
       je        short M05_L30
       mov       rcx,[r12+10]
       mov       rdx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1ED78A8]; System.Security.Principal.SecurityIdentifier.CompareTo(System.Security.Principal.SecurityIdentifier)
       test      eax,eax
       jl        short M05_L31
M05_L30:
       cmp       ebp,r14d
       jl        near ptr M05_L24
M05_L31:
       cmp       ebp,r14d
       jne       near ptr M05_L60
M05_L32:
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       cmp       ebp,[rcx+10]
       jae       near ptr M05_L10
       mov       rcx,[rcx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M05_L105
       mov       eax,ebp
       mov       r12,[rcx+rax*8+10]
       test      sil,sil
       je        near ptr M05_L62
       movzx     ecx,byte ptr [r12+0A]
       test      byte ptr [r12+0B],10
       je        near ptr M05_L63
       movzx     eax,word ptr [r12+8]
       add       eax,1FFFE
M05_L33:
       movzx     ecx,byte ptr [r13+0A]
       test      byte ptr [r13+0B],10
       je        near ptr M05_L72
       movzx     edx,word ptr [r13+8]
       add       edx,1FFFE
M05_L34:
       cmp       eax,edx
       jl        short M05_L37
       jg        short M05_L38
       mov       rax,r12
       test      rax,rax
       je        short M05_L35
       mov       rdx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [rax],rdx
       jne       near ptr M05_L81
M05_L35:
       mov       r12,rax
       test      r12,r12
       je        short M05_L37
       mov       rax,r13
       test      rax,rax
       je        short M05_L36
       mov       rdx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [rax],rdx
       jne       near ptr M05_L82
M05_L36:
       test      rax,rax
       je        short M05_L37
       mov       rcx,[r12+10]
       mov       rdx,[rax+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1ED78A8]; System.Security.Principal.SecurityIdentifier.CompareTo(System.Security.Principal.SecurityIdentifier)
       test      eax,eax
       jl        short M05_L37
       test      eax,eax
       jg        short M05_L38
M05_L37:
       cmp       ebp,r14d
       jl        near ptr M05_L61
M05_L38:
       cmp       ebp,r14d
       je        near ptr M05_L03
       jmp       near ptr M05_L83
M05_L39:
       mov       rcx,r12
       call      qword ptr [7FF9C1EF7FC0]
       mov       [rsp+34],eax
       mov       rcx,r13
       call      qword ptr [7FF9C1EF7FC0]
       mov       edx,eax
       mov       eax,[rsp+34]
       jmp       near ptr M05_L27
M05_L40:
       cmp       ecx,1
       je        short M05_L41
       cmp       ecx,0A
       jne       short M05_L42
M05_L41:
       xor       eax,eax
       jmp       near ptr M05_L26
M05_L42:
       cmp       ecx,6
       je        short M05_L43
       cmp       ecx,0C
       jne       short M05_L44
M05_L43:
       mov       eax,1
       jmp       near ptr M05_L26
M05_L44:
       test      ecx,ecx
       je        short M05_L45
       cmp       ecx,9
       jne       short M05_L46
M05_L45:
       mov       eax,2
       jmp       near ptr M05_L26
M05_L46:
       cmp       ecx,5
       je        short M05_L47
       cmp       ecx,0B
       jne       short M05_L48
M05_L47:
       mov       eax,3
       jmp       near ptr M05_L26
M05_L48:
       movzx     eax,word ptr [r12+8]
       add       eax,0FFFF
       jmp       near ptr M05_L26
M05_L49:
       cmp       ecx,1
       je        short M05_L50
       cmp       ecx,0A
       jne       short M05_L51
M05_L50:
       xor       edx,edx
       jmp       near ptr M05_L27
M05_L51:
       cmp       ecx,6
       je        short M05_L52
       cmp       ecx,0C
       jne       short M05_L53
M05_L52:
       mov       edx,1
       jmp       near ptr M05_L27
M05_L53:
       test      ecx,ecx
       je        short M05_L54
       cmp       ecx,9
       jne       short M05_L55
M05_L54:
       mov       edx,2
       jmp       near ptr M05_L27
M05_L55:
       cmp       ecx,5
       je        short M05_L56
       cmp       ecx,0B
       jne       short M05_L57
M05_L56:
       mov       edx,3
       jmp       near ptr M05_L27
M05_L57:
       movzx     edx,word ptr [r13+8]
       add       edx,0FFFF
       jmp       near ptr M05_L27
M05_L58:
       mov       rdx,r12
       mov       rcx,offset MT_System.Security.AccessControl.KnownAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       mov       rax,r12
       jmp       near ptr M05_L28
M05_L59:
       mov       rdx,r13
       mov       rcx,offset MT_System.Security.AccessControl.KnownAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       jmp       near ptr M05_L29
M05_L60:
       mov       rcx,[rbx+8]
       mov       r8,[rbx+8]
       mov       r8,[r8+8]
       cmp       r14d,[r8+10]
       jae       near ptr M05_L10
       mov       r8,[r8+8]
       cmp       r14d,[r8+8]
       jae       near ptr M05_L105
       mov       edx,r14d
       mov       r8,[r8+rdx*8+10]
       mov       edx,ebp
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1EDA1A8]; System.Security.AccessControl.RawAcl.set_Item(Int32, System.Security.AccessControl.GenericAce)
M05_L61:
       inc       ebp
       jmp       near ptr M05_L32
M05_L62:
       mov       rcx,r12
       call      qword ptr [7FF9C1EF7FC0]
       mov       [rsp+30],eax
       mov       rcx,r13
       call      qword ptr [7FF9C1EF7FC0]
       mov       edx,eax
       mov       eax,[rsp+30]
       jmp       near ptr M05_L34
M05_L63:
       cmp       ecx,1
       je        short M05_L64
       cmp       ecx,0A
       jne       short M05_L65
M05_L64:
       xor       eax,eax
       jmp       near ptr M05_L33
M05_L65:
       cmp       ecx,6
       je        short M05_L66
       cmp       ecx,0C
       jne       short M05_L67
M05_L66:
       mov       eax,1
       jmp       near ptr M05_L33
M05_L67:
       test      ecx,ecx
       je        short M05_L68
       cmp       ecx,9
       jne       short M05_L69
M05_L68:
       mov       eax,2
       jmp       near ptr M05_L33
M05_L69:
       cmp       ecx,5
       je        short M05_L70
       cmp       ecx,0B
       jne       short M05_L71
M05_L70:
       mov       eax,3
       jmp       near ptr M05_L33
M05_L71:
       movzx     eax,word ptr [r12+8]
       add       eax,0FFFF
       jmp       near ptr M05_L33
M05_L72:
       cmp       ecx,1
       je        short M05_L73
       cmp       ecx,0A
       jne       short M05_L74
M05_L73:
       xor       edx,edx
       jmp       near ptr M05_L34
M05_L74:
       cmp       ecx,6
       je        short M05_L75
       cmp       ecx,0C
       jne       short M05_L76
M05_L75:
       mov       edx,1
       jmp       near ptr M05_L34
M05_L76:
       test      ecx,ecx
       je        short M05_L77
       cmp       ecx,9
       jne       short M05_L78
M05_L77:
       mov       edx,2
       jmp       near ptr M05_L34
M05_L78:
       cmp       ecx,5
       je        short M05_L79
       cmp       ecx,0B
       jne       short M05_L80
M05_L79:
       mov       edx,3
       jmp       near ptr M05_L34
M05_L80:
       movzx     edx,word ptr [r13+8]
       add       edx,0FFFF
       jmp       near ptr M05_L34
M05_L81:
       mov       rdx,r12
       mov       rcx,offset MT_System.Security.AccessControl.KnownAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       mov       rax,r12
       jmp       near ptr M05_L35
M05_L82:
       mov       rdx,r13
       mov       rcx,offset MT_System.Security.AccessControl.KnownAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       jmp       near ptr M05_L36
M05_L83:
       mov       rcx,[rbx+8]
       mov       r8,[rbx+8]
       mov       r8,[r8+8]
       cmp       ebp,[r8+10]
       jae       near ptr M05_L10
       mov       r8,[r8+8]
       cmp       ebp,[r8+8]
       jae       near ptr M05_L105
       mov       edx,ebp
       mov       r8,[r8+rdx*8+10]
       mov       edx,r14d
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1EDA1A8]; System.Security.AccessControl.RawAcl.set_Item(Int32, System.Security.AccessControl.GenericAce)
       dec       r14d
       jmp       near ptr M05_L03
M05_L84:
       mov       ecx,0C4F
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       rcx,rax
       call      qword ptr [7FF9C1EF6A18]
       int       3
M05_L85:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M05_L05
M05_L86:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1EFC078]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L87:
       xor       eax,eax
       mov       [rsp+2C],eax
       mov       eax,[rsp+2C]
       jmp       near ptr M05_L07
M05_L88:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M05_L07
M05_L89:
       mov       [rsp+2C],eax
       mov       rcx,r13
       mov       rdx,[r13]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+20]
       mov       edx,eax
       mov       eax,[rsp+2C]
       jmp       near ptr M05_L09
M05_L90:
       mov       rcx,offset MT_System.OverflowException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9C1EFC258]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9C1EFC270]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M05_L91:
       lea       r8d,[rbp-1]
       movzx     r9d,sil
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9C1E6FB10]; System.Security.AccessControl.CommonAcl.QuickSort(Int32, Int32, Boolean)
       jmp       near ptr M05_L15
M05_L92:
       mov       rcx,offset MT_System.Security.AccessControl.QualifiedAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       jmp       near ptr M05_L18
M05_L93:
       mov       rcx,offset MT_System.Security.AccessControl.QualifiedAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M05_L19
M05_L94:
       test      byte ptr [rdi+0B],10
       jne       near ptr M05_L20
       mov       ecx,[r14+20]
       cmp       ecx,[rdi+20]
       jne       near ptr M05_L20
       mov       rcx,[r14+10]
       mov       rdx,[rdi+10]
       call      qword ptr [7FF9C1EFC330]
       test      eax,eax
       je        near ptr M05_L20
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF9C1EFC348]
       test      eax,eax
       je        near ptr M05_L20
       movzx     edx,byte ptr [r14+0B]
       cmp       dl,[rdi+0B]
       jne       short M05_L98
       mov       rdx,r14
       mov       rcx,offset MT_System.Security.AccessControl.ObjectAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M05_L95
       mov       rdx,rdi
       mov       rcx,offset MT_System.Security.AccessControl.ObjectAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M05_L97
M05_L95:
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF9C1EFC2B8]
       test      eax,eax
       je        short M05_L98
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF9C1EFC2D0]
       test      eax,eax
       je        short M05_L98
       jmp       short M05_L97
M05_L96:
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       lea       edx,[rsi+1]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1933610]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       jmp       near ptr M05_L20
M05_L97:
       mov       edx,[rdi+0C]
       or        [r14+0C],edx
       jmp       short M05_L96
M05_L98:
       movzx     edx,byte ptr [r14+0B]
       and       edx,0F
       movzx     ecx,byte ptr [rdi+0B]
       and       ecx,0F
       cmp       edx,ecx
       jne       short M05_L101
       mov       edx,[r14+0C]
       cmp       edx,[rdi+0C]
       jne       short M05_L101
       mov       rdx,r14
       mov       rcx,offset MT_System.Security.AccessControl.ObjectAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M05_L99
       mov       rdx,rdi
       mov       rcx,offset MT_System.Security.AccessControl.ObjectAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M05_L100
M05_L99:
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF9C1EFC2B8]
       test      eax,eax
       je        short M05_L101
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF9C1EFC2E8]
       test      eax,eax
       je        short M05_L101
M05_L100:
       movzx     edx,byte ptr [rdi+0B]
       and       edx,0C0
       or        [r14+0B],dl
       jmp       near ptr M05_L96
M05_L101:
       movzx     edx,byte ptr [r14+0B]
       and       edx,0C0
       movzx     ecx,byte ptr [rdi+0B]
       and       ecx,0C0
       cmp       edx,ecx
       jne       near ptr M05_L20
       mov       edx,[r14+0C]
       cmp       edx,[rdi+0C]
       jne       near ptr M05_L20
       mov       rdx,r14
       mov       rcx,offset MT_System.Security.AccessControl.ObjectAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M05_L102
       mov       rdx,rdi
       mov       rcx,offset MT_System.Security.AccessControl.ObjectAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M05_L103
M05_L102:
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF9C1EFC2E8]
       test      eax,eax
       je        near ptr M05_L20
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF9C1EFC318]
       test      eax,eax
       je        near ptr M05_L20
       movzx     ecx,byte ptr [r14+0B]
       movzx     edx,byte ptr [rdi+0B]
       movzx     r8d,byte ptr [rbx+13]
       lea       r9,[rsp+20]
       call      qword ptr [7FF9C1EFC300]
       test      eax,eax
       je        near ptr M05_L20
       movzx     ecx,byte ptr [rsp+20]
       movzx     edx,byte ptr [r14+0B]
       and       edx,0C0
       or        ecx,edx
       mov       [r14+0B],cl
       jmp       near ptr M05_L96
M05_L103:
       movzx     ecx,byte ptr [r14+0B]
       movzx     edx,byte ptr [rdi+0B]
       movzx     r8d,byte ptr [rbx+13]
       lea       r9,[rsp+20]
       call      qword ptr [7FF9C1EFC300]
       test      eax,eax
       je        near ptr M05_L20
       movzx     ecx,byte ptr [rsp+20]
       movzx     edx,byte ptr [r14+0B]
       and       edx,0C0
       or        ecx,edx
       mov       [r14+0B],cl
       jmp       near ptr M05_L96
M05_L104:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Security.AccessControl.DiscretionaryAcl
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       setne     r8b
       movzx     r8d,r8b
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9C1E6FAF8]
       mov       byte ptr [rbx+10],0
       jmp       near ptr M05_L22
M05_L105:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2666
```
```assembly
; System.Security.AccessControl.CommonSecurityDescriptor.CreateFromParts(Boolean, Boolean, System.Security.AccessControl.ControlFlags, System.Security.Principal.SecurityIdentifier, System.Security.Principal.SecurityIdentifier, System.Security.AccessControl.SystemAcl, System.Security.AccessControl.DiscretionaryAcl)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,r9d
       mov       rbp,[rsp+80]
       mov       rsi,[rsp+88]
       test      rbp,rbp
       jne       near ptr M06_L06
M06_L00:
       test      rsi,rsi
       je        short M06_L01
       movzx     ecx,byte ptr [rsi+12]
       movzx     eax,dl
       cmp       ecx,eax
       jne       near ptr M06_L09
M06_L01:
       mov       [rbx+20],dl
       test      rbp,rbp
       jne       near ptr M06_L12
M06_L02:
       test      rsi,rsi
       je        short M06_L03
       movzx     ecx,byte ptr [rsi+13]
       movzx     eax,r8b
       cmp       ecx,eax
       jne       near ptr M06_L15
M06_L03:
       mov       [rbx+21],r8b
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M06_L18
M06_L04:
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       or        edi,4
       test      rbp,rbp
       jne       near ptr M06_L19
       and       edi,0FFFFFFEF
       xor       r14d,r14d
M06_L05:
       mov       rcx,offset MT_System.Security.AccessControl.RawSecurityDescriptor
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rsi,[rsi+8]
       mov       ecx,edi
       or        ecx,8000
       mov       [rbp+28],ecx
       lea       rcx,[rbp+8]
       mov       rdx,[rsp+70]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,[rsp+78]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+2C],0
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L06:
       movzx     ecx,byte ptr [rbp+12]
       movzx     eax,dl
       cmp       ecx,eax
       je        near ptr M06_L00
       test      dl,dl
       jne       short M06_L07
       mov       rcx,288C3681560
       call      qword ptr [7FF9C1EFC5B8]
       mov       rsi,rax
       jmp       short M06_L08
M06_L07:
       mov       rcx,288C3681490
       call      qword ptr [7FF9C1EFC5B8]
       mov       rsi,rax
M06_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0E75
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9C1BC6250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L09:
       test      dl,dl
       jne       short M06_L10
       mov       rcx,288C3681560
       call      qword ptr [7FF9C1EFC5B8]
       mov       rbx,rax
       jmp       short M06_L11
M06_L10:
       mov       rcx,288C3681490
       call      qword ptr [7FF9C1EFC5B8]
       mov       rbx,rax
M06_L11:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       ecx,0E89
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FF9C1BC6250]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M06_L12:
       movzx     ecx,byte ptr [rbp+13]
       movzx     eax,r8b
       cmp       ecx,eax
       je        near ptr M06_L02
       test      r8b,r8b
       jne       short M06_L13
       mov       rcx,288C36815C8
       call      qword ptr [7FF9C1EFC5B8]
       mov       rsi,rax
       jmp       short M06_L14
M06_L13:
       mov       rcx,288C36814F0
       call      qword ptr [7FF9C1EFC5B8]
       mov       rsi,rax
M06_L14:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0E75
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9C1BC6250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L15:
       test      r8b,r8b
       jne       short M06_L16
       mov       rcx,288C36815C8
       call      qword ptr [7FF9C1EFC5B8]
       mov       rbx,rax
       jmp       short M06_L17
M06_L16:
       mov       rcx,288C36814F0
       call      qword ptr [7FF9C1EFC5B8]
       mov       rbx,rax
M06_L17:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       ecx,0E89
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FF9C1BC6250]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M06_L18:
       movzx     ecx,byte ptr [rbx+21]
       movzx     edx,byte ptr [rbx+20]
       call      qword ptr [7FF9C1EFC5D0]
       mov       rsi,rax
       jmp       near ptr M06_L04
M06_L19:
       or        edi,10
       mov       r14,[rbp+8]
       jmp       near ptr M06_L05
; Total bytes of code 757
```
```assembly
; System.Security.AccessControl.CommonObjectSecurity.GetRules(Boolean, Boolean, Boolean, System.Type)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       lea       rbp,[rsp+100]
       xor       eax,eax
       mov       [rbp-78],rax
       mov       [rbp+10],rcx
       mov       ebx,edx
       mov       esi,r8d
       mov       edi,r9d
       mov       r14,[rbp+30]
       mov       rax,[rcx+8]
       cmp       [rax],al
       mov       edx,0FFFFFFFF
       mov       rcx,rax
       call      qword ptr [7FF9C1E6FC78]; System.Threading.ReaderWriterLockSlim.TryEnterReadLockCore(TimeoutTracker)
       nop
       mov       rcx,offset MT_System.Security.AccessControl.AuthorizationRuleCollection
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,288C3681710
       cmp       r14,rcx
       je        short M07_L00
       mov       rcx,288C3680FF0
       cmp       r14,rcx
       jne       near ptr M07_L46
M07_L00:
       xor       r13d,r13d
       test      bl,bl
       je        near ptr M07_L47
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rdx,[rax+8]
       test      byte ptr [rdx+28],4
       je        short M07_L01
       mov       r13,[rax+18]
M07_L01:
       mov       rcx,[rbp+10]
       test      r13,r13
       je        near ptr M07_L45
       xor       r12d,r12d
       mov       rax,288C3680FF0
       cmp       r14,rax
       jne       near ptr M07_L48
M07_L02:
       xor       eax,eax
       mov       [rbp-3C],eax
       xor       r8d,r8d
       mov       [rbp-68],r8
       jmp       near ptr M07_L30
M07_L03:
       xor       r9d,r9d
       jmp       near ptr M07_L33
M07_L04:
       xor       r9d,r9d
       mov       [rbp-70],r12
       jmp       near ptr M07_L35
M07_L05:
       xor       r8d,r8d
       jmp       near ptr M07_L36
M07_L06:
       movsxd    rdx,edx
       mov       edx,[rcx+rdx*4+10]
       jmp       near ptr M07_L39
M07_L07:
       test      r11b,4
       je        near ptr M07_L63
       mov       r11d,[rdx]
       mov       [rcx],r11d
       mov       edx,[rdi-4]
       mov       [rsi-4],edx
       jmp       short M07_L11
M07_L08:
       cmp       r12,40
       ja        near ptr M07_L40
M07_L09:
       vmovups   xmm0,[r9]
       vmovups   [r8],xmm0
       cmp       r12,20
       ja        near ptr M07_L62
M07_L10:
       vmovups   xmm0,[rdi-10]
       vmovups   [rsi-10],xmm0
M07_L11:
       mov       rcx,[r10+10]
       mov       rcx,[rcx+10]
       mov       r12d,[rcx+8]
       add       r12d,4
       cmp       qword ptr [r10+18],0
       jne       near ptr M07_L70
M07_L12:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF9C1E6F7B0]; System.Security.AccessControl.GenericAce.CreateFromBinaryForm(Byte[], Int32)
       test      rax,rax
       jne       near ptr M07_L43
M07_L13:
       xor       eax,eax
M07_L14:
       test      rax,rax
       je        near ptr M07_L71
       test      bl,bl
       je        near ptr M07_L74
       mov       ecx,[rax+20]
       test      ecx,ecx
       jne       near ptr M07_L73
M07_L15:
       movzx     esi,byte ptr [rbp+20]
       test      sil,sil
       je        short M07_L16
       movzx     edx,byte ptr [rax+0B]
       mov       r8d,edx
       and       r8d,10
       je        near ptr M07_L76
M07_L16:
       movzx     edi,byte ptr [rbp+28]
       test      dil,dil
       je        near ptr M07_L29
       movzx     edx,byte ptr [rax+0B]
       mov       r8d,edx
       and       r8d,10
       je        near ptr M07_L29
M07_L17:
       mov       r10,288C3680FF0
       cmp       r14,r10
       jne       near ptr M07_L75
       mov       r10,[rax+10]
M07_L18:
       test      bl,bl
       je        near ptr M07_L87
       test      ecx,ecx
       jne       near ptr M07_L78
       xor       r11d,r11d
M07_L19:
       mov       eax,[rax+0C]
       mov       [rbp-4C],eax
       test      r8d,r8d
       setne     r8b
       movzx     r8d,r8b
       mov       [rbp-50],r8d
       xor       ecx,ecx
       test      dl,2
       jne       near ptr M07_L79
M07_L20:
       test      dl,1
       jne       near ptr M07_L80
M07_L21:
       xor       r12d,r12d
       test      dl,8
       jne       near ptr M07_L81
M07_L22:
       test      dl,4
       jne       near ptr M07_L82
M07_L23:
       mov       rdx,offset MT_System.Security.AccessControl.FileSecurity
       mov       r9,[rbp+10]
       cmp       [r9],rdx
       jne       near ptr M07_L86
       mov       [rbp-54],ecx
       mov       [rbp-90],r10
       mov       [rbp-44],r11d
       mov       rcx,offset MT_System.Security.AccessControl.FileSystemAccessRule
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B0],rax
       mov       r8,[rbp-90]
       test      r8,r8
       je        near ptr M07_L94
       cmp       dword ptr [rbp-4C],0
       je        near ptr M07_L95
       cmp       dword ptr [rbp-54],3
       ja        near ptr M07_L96
       cmp       r12d,3
       ja        near ptr M07_L97
       mov       rcx,offset MT_System.Security.Principal.SecurityIdentifier
       cmp       [r8],rcx
       jne       near ptr M07_L83
M07_L24:
       mov       rax,[rbp-0B0]
       lea       rcx,[rax+8]
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0B0]
       mov       r9d,[rbp-4C]
       mov       [rax+10],r9d
       mov       r10d,[rbp-50]
       mov       [rax+1C],r10b
       mov       r11d,[rbp-54]
       mov       [rax+14],r11d
       test      r11d,r11d
       jne       near ptr M07_L85
       xor       r11d,r11d
       mov       [rax+18],r11d
M07_L25:
       mov       r12d,[rbp-44]
       test      r12d,r12d
       je        short M07_L26
       cmp       r12d,1
       jne       near ptr M07_L99
M07_L26:
       mov       [rax+20],r12d
       mov       r12,rax
M07_L27:
       mov       rcx,[r15+8]
       test      rcx,rcx
       je        near ptr M07_L44
M07_L28:
       mov       rdx,r12
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
M07_L29:
       mov       rcx,[rbp-68]
       inc       ecx
       mov       [rbp-68],rcx
       mov       rcx,[rbp+10]
       mov       r12,[rbp-70]
M07_L30:
       cmp       byte ptr [r13+10],0
       jne       near ptr M07_L88
M07_L31:
       mov       rdx,[r13+8]
       mov       rdx,[rdx+8]
       mov       r8,[rbp-68]
       cmp       r8d,[rdx+10]
       jge       near ptr M07_L45
       cmp       byte ptr [r13+10],0
       jne       near ptr M07_L52
M07_L32:
       mov       rdx,[r13+8]
       mov       rdx,[rdx+8]
       mov       r8,[rbp-68]
       cmp       r8d,[rdx+10]
       jae       near ptr M07_L93
       mov       rdx,[rdx+8]
       cmp       r8d,[rdx+8]
       jae       near ptr M07_L100
       mov       [rbp-68],r8
       mov       rdx,[rdx+r8*8+10]
       mov       [rbp-98],rdx
       mov       r10,offset MT_System.Security.AccessControl.CommonAce
       cmp       [rdx],r10
       jne       near ptr M07_L53
       mov       r10,[rdx+10]
       mov       r10,[r10+10]
       mov       r10d,[r10+8]
       add       r10d,8
       cmp       qword ptr [rdx+18],0
       je        near ptr M07_L03
       mov       r9,[rdx+18]
       mov       r9d,[r9+8]
M07_L33:
       add       r10d,r9d
M07_L34:
       movsxd    rdx,r10d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-0A0],rax
       mov       rcx,offset MT_System.Security.AccessControl.CommonAce
       mov       r10,[rbp-98]
       cmp       [r10],rcx
       jne       near ptr M07_L72
       mov       [rbp-0A8],r10
       mov       rcx,[r10+10]
       mov       rcx,[rcx+10]
       mov       edx,[rcx+8]
       add       edx,8
       mov       r8,[r10+18]
       test      r8,r8
       je        near ptr M07_L04
       mov       r9d,[r8+8]
       mov       [rbp-70],r12
M07_L35:
       add       edx,r9d
       mov       r9d,[rax+8]
       mov       r11d,r9d
       mov       r12d,[rcx+8]
       add       r12d,8
       test      r8,r8
       je        near ptr M07_L05
       mov       r8d,[r8+8]
M07_L36:
       add       r8d,r12d
       cmp       r8d,r11d
       jg        near ptr M07_L89
       cmp       edx,0FFFF
       jg        near ptr M07_L90
       movzx     r8d,byte ptr [r10+0A]
       cmp       r9d,7
       jle       near ptr M07_L54
       mov       [rax+10],r8b
       movzx     r11d,byte ptr [r10+0B]
       mov       [rax+11],r11b
       mov       [rax+12],dl
       sar       edx,8
       mov       [rax+13],dl
       movzx     edx,byte ptr [r10+0C]
       mov       [rax+14],dl
       mov       r12d,[r10+0C]
       mov       r9d,r12d
       sar       r9d,8
       movzx     r9d,r9b
       mov       [rax+15],r9b
       mov       r8d,r12d
       sar       r8d,10
       movzx     r8d,r8b
       mov       [rax+16],r8b
       sar       r12d,18
       movzx     r12d,r12b
       mov       [rax+17],r12b
M07_L37:
       cmp       [rcx],cl
       mov       rdx,[rax]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       jne       near ptr M07_L55
M07_L38:
       mov       rdx,[rcx]
       mov       edx,[rdx+4]
       add       edx,0FFFFFFE8
       shr       edx,3
       jne       near ptr M07_L06
       xor       edx,edx
M07_L39:
       mov       r8d,[rcx+8]
       test      r8d,r8d
       jl        near ptr M07_L101
       mov       r12d,r8d
       mov       r9,[rcx]
       cmp       r9,[rax]
       jne       near ptr M07_L61
       cmp       dword ptr [r9+4],18
       jne       near ptr M07_L60
       mov       r11d,r12d
       or        r11d,edx
       jl        near ptr M07_L59
       lea       r11d,[rdx+r12]
       cmp       r11d,r8d
       ja        near ptr M07_L58
       lea       r8d,[r12+8]
       cmp       r8d,[rax+8]
       ja        near ptr M07_L57
       movzx     r8d,word ptr [r9]
       mov       r11d,r12d
       imul      r11,r8
       mov       edx,edx
       imul      rdx,r8
       lea       rdx,[rcx+rdx+10]
       lea       rcx,[rax+r8*8+10]
       test      dword ptr [r9],1000000
       jne       near ptr M07_L56
       mov       [rbp+28],edi
       mov       rax,[rbp-0A0]
       mov       r8,rcx
       mov       r9,rdx
       mov       r12,r11
       mov       rdi,r8
       sub       rdi,r9
       cmp       rdi,r12
       jb        near ptr M07_L66
       mov       rdi,r9
       sub       rdi,r8
       cmp       rdi,r12
       jb        near ptr M07_L66
       mov       [rbp+20],esi
       lea       rdi,[r9+r12]
       lea       rsi,[r8+r12]
       cmp       r12,10
       ja        near ptr M07_L08
       test      r11b,18
       je        near ptr M07_L07
       mov       r11,[rdx]
       mov       [rcx],r11
       mov       rdx,[rdi-8]
       mov       [rsi-8],rdx
       jmp       near ptr M07_L11
M07_L40:
       cmp       r12,800
       ja        near ptr M07_L65
       cmp       r12,100
       jae       near ptr M07_L64
M07_L41:
       mov       rcx,r12
       shr       rcx,6
M07_L42:
       vmovdqu   ymm0,ymmword ptr [r9]
       vmovdqu   ymmword ptr [r8],ymm0
       vmovdqu   ymm0,ymmword ptr [r9+20]
       vmovdqu   ymmword ptr [r8+20],ymm0
       add       r8,40
       add       r9,40
       dec       rcx
       jne       short M07_L42
       and       r12,3F
       cmp       r12,10
       ja        near ptr M07_L09
       jmp       near ptr M07_L10
M07_L43:
       mov       rcx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [rax],rcx
       jne       near ptr M07_L13
       jmp       near ptr M07_L14
M07_L44:
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       [rbp-0B8],rcx
       mov       rdx,2482E801AF0
       mov       rdx,[rdx]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+8]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0B8]
       jmp       near ptr M07_L28
M07_L45:
       mov       [rbp-78],r15
       jmp       near ptr M07_L102
M07_L46:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1EFC1F8]
       mov       r14,rax
       mov       ecx,0D4F
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      qword ptr [7FF9C1BC6250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L47:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rdx,[rax+8]
       test      byte ptr [rdx+28],10
       je        near ptr M07_L01
       mov       r13,[rax+10]
       jmp       near ptr M07_L01
M07_L48:
       mov       rcx,offset MT_System.Security.Principal.IdentityReferenceCollection
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r13
       call      qword ptr [7FF9C1EDC3A8]; System.Security.AccessControl.CommonAcl.get_Count()
       mov       edx,eax
       mov       rcx,r12
       call      qword ptr [7FF9C1EFCC78]
       xor       eax,eax
       mov       [rbp-40],eax
       jmp       short M07_L51
M07_L49:
       mov       rcx,r13
       mov       [rbp-40],r8d
       mov       edx,r8d
       call      qword ptr [7FF9C1EDC388]; Precode of System.Security.AccessControl.CommonAcl.get_Item(Int32)
       mov       rdx,rax
       mov       rcx,offset MT_System.Security.AccessControl.CommonAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-80],rax
       mov       [rbp+28],edi
       movzx     r9d,dil
       movzx     edx,bl
       mov       [rbp+20],esi
       movzx     r8d,sil
       mov       rcx,rax
       call      qword ptr [7FF9C1E6FDB0]; System.Security.AccessControl.CommonObjectSecurity.AceNeedsTranslation(System.Security.AccessControl.CommonAce, Boolean, Boolean, Boolean)
       test      eax,eax
       je        short M07_L50
       mov       rdx,[rbp-80]
       mov       rdx,[rdx+10]
       mov       rcx,r12
       call      qword ptr [7FF9C1EDDDF8]
M07_L50:
       mov       r8d,[rbp-40]
       inc       r8d
       mov       [rbp-40],r8d
       movzx     esi,byte ptr [rbp+20]
       movzx     edi,byte ptr [rbp+28]
M07_L51:
       mov       rcx,r13
       call      qword ptr [7FF9C1EDC3A8]; System.Security.AccessControl.CommonAcl.get_Count()
       mov       r8d,[rbp-40]
       cmp       eax,r8d
       jg        short M07_L49
       mov       rcx,r12
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FF9C1EFC648]
       mov       [rbp-70],rax
       mov       rcx,[rbp+10]
       mov       r12,[rbp-70]
       jmp       near ptr M07_L02
M07_L52:
       mov       rdx,r13
       mov       rcx,offset MT_System.Security.AccessControl.DiscretionaryAcl
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       setne     r8b
       movzx     r8d,r8b
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF9C1E6FAF8]; System.Security.AccessControl.CommonAcl.Canonicalize(Boolean, Boolean)
       mov       byte ptr [r13+10],0
       mov       rcx,[rbp+10]
       jmp       near ptr M07_L32
M07_L53:
       mov       rcx,rdx
       mov       r10,[rdx]
       mov       r10,[r10+40]
       call      qword ptr [r10+20]
       mov       r10d,eax
       jmp       near ptr M07_L34
M07_L54:
       test      r9d,r9d
       je        near ptr M07_L100
       mov       [rax+10],r8b
       movzx     r11d,byte ptr [r10+0B]
       cmp       r9d,1
       jbe       near ptr M07_L100
       mov       [rax+11],r11b
       cmp       r9d,2
       jbe       near ptr M07_L100
       mov       [rax+12],dl
       cmp       r9d,3
       jbe       near ptr M07_L100
       sar       edx,8
       mov       [rax+13],dl
       movzx     edx,byte ptr [r10+0C]
       cmp       r9d,4
       jbe       near ptr M07_L100
       mov       [rax+14],dl
       mov       r12d,[r10+0C]
       mov       edx,r12d
       sar       edx,8
       movzx     edx,dl
       cmp       r9d,5
       jbe       near ptr M07_L100
       mov       [rax+15],dl
       mov       edx,r12d
       sar       edx,10
       movzx     r8d,dl
       cmp       r9d,6
       jbe       near ptr M07_L100
       mov       [rax+16],r8b
       mov       edx,r12d
       sar       edx,18
       movzx     r12d,dl
       cmp       r9d,7
       jbe       near ptr M07_L100
       mov       [rax+17],r12b
       mov       r10,[rbp-0A8]
       jmp       near ptr M07_L37
M07_L55:
       cmp       edx,1
       je        near ptr M07_L38
       jmp       near ptr M07_L91
M07_L56:
       mov       r8,r11
       call      qword ptr [7FF9C18457A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbp+20],esi
       mov       [rbp+28],edi
       mov       rax,[rbp-0A0]
       mov       r10,[rbp-0A8]
       jmp       near ptr M07_L11
M07_L57:
       jmp       near ptr M07_L69
M07_L58:
       jmp       near ptr M07_L69
M07_L59:
       jmp       near ptr M07_L69
M07_L60:
       jmp       near ptr M07_L69
M07_L61:
       jmp       near ptr M07_L69
M07_L62:
       vmovups   xmm0,[r9+10]
       vmovups   [r8+10],xmm0
       cmp       r12,30
       jbe       near ptr M07_L10
       vmovups   xmm0,[r9+20]
       vmovups   [r8+20],xmm0
       jmp       near ptr M07_L10
M07_L63:
       test      r11,r11
       je        near ptr M07_L11
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r11b,2
       je        near ptr M07_L11
       movsx     rcx,word ptr [rdi-2]
       mov       [rsi-2],cx
       jmp       near ptr M07_L11
M07_L64:
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       lea       r8,[rcx+r9]
       mov       r12,r11
       sub       r12,r9
       mov       r9,rdx
       jmp       near ptr M07_L41
M07_L65:
       jmp       short M07_L68
M07_L66:
       cmp       rcx,rdx
       jne       short M07_L67
       cmp       [rdx],dl
       mov       [rbp+20],esi
       jmp       near ptr M07_L11
M07_L67:
       mov       [rbp+20],esi
M07_L68:
       cmp       [rcx],cl
       cmp       [rdx],dl
       mov       r8,r11
       call      qword ptr [7FF9C18466E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-0A0]
       mov       r10,[rbp-0A8]
       jmp       near ptr M07_L11
M07_L69:
       mov       [rsp+20],r12d
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       r8,rax
       mov       r9d,8
       call      qword ptr [7FF9C1E66760]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       [rbp+20],esi
       mov       [rbp+28],edi
       mov       rax,[rbp-0A0]
       mov       r10,[rbp-0A8]
       jmp       near ptr M07_L11
M07_L70:
       mov       rcx,r10
       call      qword ptr [7FF9C1EFC9A8]
       cmp       eax,0FFB3
       jg        near ptr M07_L92
       lea       r8d,[r12+4]
       mov       r12,[rbp-0A8]
       mov       rcx,[r12+18]
       mov       rdx,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1851AB8]; Precode of System.Array.CopyTo(System.Array, Int32)
       mov       rax,[rbp-0A0]
       jmp       near ptr M07_L12
M07_L71:
       movzx     esi,byte ptr [rbp+20]
       movzx     edi,byte ptr [rbp+28]
       jmp       near ptr M07_L29
M07_L72:
       mov       rcx,r10
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r10]
       mov       r10,[r10+40]
       call      qword ptr [r10+28]
       mov       [rbp+20],esi
       mov       [rbp+28],edi
       mov       [rbp-70],r12
       mov       rax,[rbp-0A0]
       jmp       near ptr M07_L12
M07_L73:
       cmp       ecx,1
       je        near ptr M07_L15
       movzx     esi,byte ptr [rbp+20]
       movzx     edi,byte ptr [rbp+28]
       jmp       near ptr M07_L29
M07_L74:
       mov       ecx,[rax+20]
       cmp       ecx,2
       jne       near ptr M07_L84
       jmp       near ptr M07_L15
M07_L75:
       mov       r10d,[rbp-3C]
       lea       r9d,[r10+1]
       mov       [rbp-3C],r9d
       mov       r12,[rbp-70]
       mov       r11,[r12+8]
       cmp       r10d,[r11+10]
       jb        short M07_L77
       jmp       near ptr M07_L93
M07_L76:
       movzx     edi,byte ptr [rbp+28]
       jmp       near ptr M07_L17
M07_L77:
       mov       r11,[r11+8]
       cmp       r10d,[r11+8]
       jae       near ptr M07_L100
       mov       r10d,r10d
       mov       r10,[r11+r10*8+10]
       mov       [rbp-90],r10
       mov       r10,[rbp-90]
       jmp       near ptr M07_L18
M07_L78:
       mov       dword ptr [rbp-44],1
       mov       r11d,[rbp-44]
       jmp       near ptr M07_L19
M07_L79:
       mov       ecx,1
       jmp       near ptr M07_L20
M07_L80:
       or        ecx,2
       mov       [rbp-54],ecx
       mov       ecx,[rbp-54]
       jmp       near ptr M07_L21
M07_L81:
       mov       r12d,2
       jmp       near ptr M07_L22
M07_L82:
       or        r12d,1
       jmp       near ptr M07_L23
M07_L83:
       mov       rcx,r8
       mov       rdx,288C3680FF0
       mov       [rbp-90],r8
       mov       r11,[r8]
       mov       r11,[r11+40]
       call      qword ptr [r11+28]
       test      eax,eax
       mov       r8,[rbp-90]
       jne       near ptr M07_L24
       jmp       near ptr M07_L98
M07_L84:
       movzx     esi,byte ptr [rbp+20]
       movzx     edi,byte ptr [rbp+28]
       jmp       near ptr M07_L29
M07_L85:
       mov       [rax+18],r12d
       jmp       near ptr M07_L25
M07_L86:
       mov       eax,[rbp-4C]
       mov       r9,[rbp+10]
       mov       [rsp+20],ecx
       mov       [rsp+28],r12d
       mov       [rsp+30],r11d
       mov       rcx,r9
       mov       rdx,r10
       mov       r8d,eax
       mov       r9d,[rbp-50]
       mov       rax,[rbp+10]
       mov       r10,[rax]
       mov       r10,[r10+50]
       call      qword ptr [r10]
       mov       r12,rax
       jmp       near ptr M07_L27
M07_L87:
       mov       [rbp-90],r10
       mov       edx,[rax+0C]
       mov       [rbp-48],edx
       test      r8d,r8d
       setne     r8b
       movzx     r8d,r8b
       mov       [rbp-60],r8d
       mov       [rbp-88],rax
       mov       rcx,rax
       call      qword ptr [7FF9C1E6FDC8]; System.Security.AccessControl.GenericAce.get_InheritanceFlags()
       mov       [rbp-58],eax
       mov       rcx,[rbp-88]
       call      qword ptr [7FF9C1E6FDE0]; System.Security.AccessControl.GenericAce.get_PropagationFlags()
       mov       [rbp-5C],eax
       mov       rcx,[rbp-88]
       call      qword ptr [7FF9C1EFC678]
       mov       r9d,[rbp-58]
       mov       [rsp+20],r9d
       mov       r9d,[rbp-5C]
       mov       [rsp+28],r9d
       mov       [rsp+30],eax
       mov       r9d,[rbp-60]
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-90]
       mov       r8d,[rbp-48]
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+8]
       mov       [rbp-0C0],rax
       mov       rcx,r15
       call      qword ptr [7FF9C1E6FE70]; System.Collections.ReadOnlyCollectionBase.get_InnerList()
       mov       rcx,rax
       mov       rdx,[rbp-0C0]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M07_L29
M07_L88:
       mov       rdx,r13
       mov       rcx,offset MT_System.Security.AccessControl.DiscretionaryAcl
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       setne     r8b
       movzx     r8d,r8b
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF9C1E6FAF8]; System.Security.AccessControl.CommonAcl.Canonicalize(Boolean, Boolean)
       mov       byte ptr [r13+10],0
       mov       rcx,[rbp+10]
       jmp       near ptr M07_L31
M07_L89:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0BEF
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       rsi,rax
       call      qword ptr [7FF9C1EF7EA0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9C1ADDA10]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L90:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1EFC078]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L91:
       mov       ecx,9
       call      qword ptr [7FF9C1EFC1B0]
       int       3
M07_L92:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF9C1EFC078]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M07_L93:
       call      qword ptr [7FF9C1EF49A8]
       int       3
M07_L94:
       mov       ecx,0DF9
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       rcx,rax
       call      qword ptr [7FF9C1EF6A18]
       int       3
M07_L95:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1EFC1E0]
       mov       rsi,rax
       mov       ecx,0D39
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9C1BC6250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L96:
       mov       rcx,offset MT_System.Security.AccessControl.InheritanceFlags
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1EFC1C8]
       mov       rsi,rax
       mov       edi,[rbp-54]
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,0D03
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       r14,rax
       mov       ecx,0ED7
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9C1EFC0C0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FF9C1ADDA10]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M07_L97:
       mov       rcx,offset MT_System.Security.AccessControl.InheritanceFlags
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1EFC1C8]
       mov       rsi,rax
       mov       edi,[rbp-54]
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,0CE1
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       r14,rax
       mov       ecx,0EF9
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9C1EFC0C0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rdi
       call      qword ptr [7FF9C1ADDA10]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M07_L98:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1EFC1F8]
       mov       rsi,rax
       mov       ecx,0DF9
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9C1BC6250]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L99:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0C5B
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       rsi,rax
       call      qword ptr [7FF9C1EFC060]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9C1ADDA10]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M07_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
M07_L102:
       call      M07_L103
       nop
       mov       rax,[rbp-78]
       vzeroupper
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L103:
       sub       rsp,38
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+8]
       cmp       [rbx],bl
       lea       rcx,[rbx+50]
       mov       edx,1
       xchg      dl,[rcx]
       movzx     edx,dl
       test      edx,edx
       je        short M07_L104
       mov       edx,1
       call      qword ptr [7FF9C1EFC6C0]
M07_L104:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],0B
       jle       short M07_L105
       mov       rcx,[rcx+240]
       mov       rax,[rcx+58]
       test      rax,rax
       jne       short M07_L106
M07_L105:
       mov       ecx,0B
       call      qword ptr [7FF9C1EF6CE8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M07_L106:
       mov       rsi,[rax+10]
       test      rsi,rsi
       je        short M07_L109
       mov       rax,[rbx+28]
M07_L107:
       cmp       [rsi+10],rax
       je        short M07_L108
       mov       rsi,[rsi+8]
       test      rsi,rsi
       jne       short M07_L107
       jmp       short M07_L109
M07_L108:
       jmp       short M07_L110
M07_L109:
       xor       esi,esi
M07_L110:
       test      rsi,rsi
       je        short M07_L111
       mov       edi,[rsi+18]
       test      edi,edi
       jg        short M07_L112
M07_L111:
       cmp       [rbx],bl
       lea       rcx,[rbx+50]
       call      qword ptr [7FF9C1EFC6D8]
       mov       rcx,offset MT_System.Threading.SynchronizationLockException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1EFC798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1EFC7B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M07_L112:
       cmp       byte ptr [rbx+4C],0
       je        short M07_L114
       cmp       edi,1
       jle       short M07_L113
       dec       edi
       mov       [rsi+18],edi
       jmp       short M07_L115
M07_L113:
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       eax,[rbx+40]
       jne       short M07_L114
       mov       byte ptr [rbx+4E],0
M07_L114:
       dec       dword ptr [rbx+48]
       dec       dword ptr [rsi+18]
       test      byte ptr [rbx+4D],1
       je        short M07_L116
M07_L115:
       mov       byte ptr [rbx+50],0
       jmp       short M07_L117
M07_L116:
       mov       rcx,rbx
       call      qword ptr [7FF9C1EFC7C8]
M07_L117:
       nop
       vzeroupper
       add       rsp,38
       ret
; Total bytes of code 4154
```
```assembly
; System.Collections.ArrayList+ArrayListEnumeratorSimple..ctor(System.Collections.ArrayList)
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,rdx
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+18],0FFFFFFFF
       mov       ecx,[rsi+14]
       mov       [rbx+1C],ecx
       mov       rcx,offset MT_System.Collections.ArrayList
       cmp       [rsi],rcx
       sete      cl
       mov       [rbx+20],cl
       mov       rcx,2482E802238
       mov       rdx,[rcx]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 78
```
```assembly
; System.Collections.ArrayList+ArrayListEnumeratorSimple.MoveNext()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       mov       rsi,[rbx+8]
       cmp       ecx,[rsi+14]
       jne       short M09_L03
       cmp       byte ptr [rbx+20],0
       je        near ptr M09_L04
       mov       edi,[rbx+18]
       mov       ebp,[rsi+10]
       lea       ecx,[rbp-1]
       cmp       edi,ecx
       jge       short M09_L01
       mov       rcx,[rsi+8]
       lea       edx,[rdi+1]
       mov       [rbx+18],edx
       cmp       edx,[rcx+8]
       jae       near ptr M09_L06
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M09_L00:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M09_L01:
       mov       rcx,2482E802238
       mov       rdx,[rcx]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],ebp
M09_L02:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M09_L03:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1EFC168]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1BC61A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L04:
       mov       edi,[rbx+18]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       dec       eax
       cmp       edi,eax
       jge       short M09_L05
       mov       rcx,[rbx+8]
       mov       edx,[rbx+18]
       inc       edx
       mov       [rbx+18],edx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M09_L00
M09_L05:
       mov       rcx,[rbx+8]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbx+18],eax
       mov       rcx,2482E802238
       mov       rdx,[rcx]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M09_L02
M09_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 285
```
```assembly
; System.Collections.ArrayList+ArrayListEnumeratorSimple.get_Current()
       push      rbx
       sub       rsp,20
       mov       rax,[rcx+10]
       mov       rdx,2482E802238
       cmp       [rdx],rax
       je        short M10_L00
       add       rsp,20
       pop       rbx
       ret
M10_L00:
       cmp       dword ptr [rcx+18],0FFFFFFFF
       jne       short M10_L01
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1EFC210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1BC61A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M10_L01:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1EFC228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1BC61A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 126
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M11_L00
       cmp       [rdx],rcx
       jne       short M11_L01
M11_L00:
       mov       rax,rdx
       ret
M11_L01:
       jmp       qword ptr [7FF9C1A14D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M13_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M13_L00
       test      rbx,rbx
       je        near ptr M13_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M13_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M13_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA214E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9C1845818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9C1845818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M13_L00:
       test      rbx,rbx
       je        short M13_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M13_L02
M13_L01:
       mov       rax,288C3670008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M13_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M13_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M13_L04:
       call      qword ptr [7FF9C1EF6E38]
       int       3
; Total bytes of code 235
```
```assembly
; System.Security.AccessControl.CommonAcl..ctor(Boolean, Boolean, System.Security.AccessControl.RawAcl, Boolean, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rdi,r9
       mov       esi,[rsp+0A8]
       test      rdi,rdi
       je        near ptr M14_L45
       mov       [rbx+12],dl
       mov       [rbx+13],r8b
       cmp       byte ptr [rsp+0A0],0
       je        near ptr M14_L54
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+8]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+10]
       dec       edx
       mov       edi,edx
       test      edi,edi
       jl        near ptr M14_L06
M14_L00:
       mov       rdx,[rbx+8]
       mov       rdx,[rdx+8]
       cmp       edi,[rdx+10]
       jae       near ptr M14_L16
       mov       rdx,[rdx+8]
       cmp       edi,[rdx+8]
       jae       near ptr M14_L125
       mov       rbp,[rdx+rdi*8+10]
       mov       rdx,rbp
       test      rdx,rdx
       je        short M14_L01
       mov       rcx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [rdx],rcx
       jne       near ptr M14_L46
M14_L01:
       test      rdx,rdx
       je        short M14_L02
       cmp       dword ptr [rdx+0C],0
       je        near ptr M14_L52
M14_L02:
       cmp       byte ptr [rbx+12],0
       jne       near ptr M14_L48
       movzx     ecx,byte ptr [rbp+0B]
       test      cl,8
       jne       near ptr M14_L52
       test      cl,0F
       jne       near ptr M14_L47
M14_L03:
       mov       r14,rdx
       test      r14,r14
       je        short M14_L04
       mov       rcx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [r14],rcx
       jne       near ptr M14_L50
M14_L04:
       test      sil,sil
       je        near ptr M14_L53
       and       byte ptr [rbp+0B],3F
       test      r14,r14
       je        short M14_L05
       cmp       dword ptr [r14+20],0
       jne       near ptr M14_L51
M14_L05:
       dec       edi
       jns       near ptr M14_L00
M14_L06:
       movzx     edx,sil
       mov       rcx,rbx
       call      qword ptr [7FF9C1E6FAE0]; System.Security.AccessControl.CommonAcl.CanonicalCheck(Boolean)
       test      eax,eax
       je        near ptr M14_L124
       xor       ecx,ecx
       mov       rax,[rbx+8]
       mov       rax,[rax+8]
       mov       edx,[rax+10]
       test      edx,edx
       jle       short M14_L08
M14_L07:
       mov       r8,rax
       cmp       ecx,edx
       jae       near ptr M14_L16
       mov       r8,[r8+8]
       cmp       ecx,[r8+8]
       jae       near ptr M14_L125
       mov       r10d,ecx
       mov       r8,[r8+r10*8+10]
       mov       [r8+8],cx
       inc       ecx
       movzx     ecx,cx
       cmp       ecx,edx
       jl        short M14_L07
M14_L08:
       xor       edi,edi
       lea       ebp,[rdx-1]
       test      ebp,ebp
       jle       near ptr M14_L22
       mov       r14d,ebp
       test      edx,edx
       je        near ptr M14_L16
       mov       rcx,[rax+8]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M14_L125
       mov       r15,[rcx+10]
M14_L09:
       cmp       edi,ebp
       jl        near ptr M14_L31
       mov       rbp,[rbx+8]
       cmp       [rbp],bpl
       test      r15,r15
       je        near ptr M14_L103
       mov       rcx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [r15],rcx
       jne       near ptr M14_L104
       mov       rcx,[r15+10]
       mov       rcx,[rcx+10]
       mov       eax,[rcx+8]
       add       eax,8
       cmp       qword ptr [r15+18],0
       je        near ptr M14_L17
       mov       rcx,[r15+18]
       mov       edx,[rcx+8]
M14_L10:
       add       eax,edx
M14_L11:
       test      al,3
       jne       near ptr M14_L105
       mov       rcx,rbp
       call      qword ptr [7FF9C1EDA198]; System.Security.AccessControl.RawAcl.get_BinaryLength()
       mov       r13d,eax
       mov       rcx,[rbp+8]
       mov       rax,rcx
       mov       eax,[rax+10]
       cmp       edi,eax
       jge       near ptr M14_L106
       cmp       edi,eax
       jae       near ptr M14_L16
       mov       rcx,[rcx+8]
       cmp       edi,[rcx+8]
       jae       near ptr M14_L125
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       mov       rax,offset MT_System.Security.AccessControl.CommonAce
       cmp       [rcx],rax
       jne       near ptr M14_L107
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       r12d,[rax+8]
       add       r12d,8
       cmp       qword ptr [rcx+18],0
       je        short M14_L18
       mov       rcx,[rcx+18]
       mov       eax,[rcx+8]
M14_L12:
       add       r12d,eax
M14_L13:
       mov       rcx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [r15],rcx
       jne       near ptr M14_L108
       mov       rcx,[r15+10]
       mov       rcx,[rcx+10]
       mov       eax,[rcx+8]
       add       eax,8
       cmp       qword ptr [r15+18],0
       je        short M14_L19
       mov       rcx,[r15+18]
       mov       edx,[rcx+8]
M14_L14:
       add       eax,edx
M14_L15:
       sub       r13d,r12d
       add       eax,r13d
       cmp       eax,0FFFF
       jg        near ptr M14_L109
       mov       rbp,[rbp+8]
       cmp       edi,[rbp+10]
       jb        short M14_L20
M14_L16:
       call      qword ptr [7FF9C1EF49A8]
       int       3
M14_L17:
       xor       edx,edx
       jmp       near ptr M14_L10
M14_L18:
       xor       eax,eax
       jmp       short M14_L12
M14_L19:
       xor       edx,edx
       jmp       short M14_L14
M14_L20:
       mov       rcx,[rbp+8]
       movsxd    rdx,edi
       mov       r8,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       dword ptr [rbp+14]
       test      edi,edi
       jg        near ptr M14_L110
M14_L21:
       cmp       r14d,edi
       jle       short M14_L22
       lea       edx,[rdi+1]
       movzx     r9d,sil
       mov       rcx,rbx
       mov       r8d,r14d
       call      qword ptr [7FF9C1E6FB10]; System.Security.AccessControl.CommonAcl.QuickSort(Int32, Int32, Boolean)
M14_L22:
       xor       esi,esi
M14_L23:
       cmp       byte ptr [rbx+10],0
       jne       near ptr M14_L123
M14_L24:
       mov       rdx,[rbx+8]
       mov       rdi,[rdx+8]
       mov       ebp,[rdi+10]
       lea       edx,[rbp-1]
       cmp       esi,edx
       jge       near ptr M14_L28
       mov       rdx,rdi
       cmp       esi,ebp
       jae       short M14_L16
       mov       rdx,[rdx+8]
       cmp       esi,[rdx+8]
       jae       near ptr M14_L125
       mov       rdx,[rdx+rsi*8+10]
       mov       r14,rdx
       test      r14,r14
       je        short M14_L25
       mov       rcx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [r14],rcx
       jne       near ptr M14_L111
M14_L25:
       test      r14,r14
       je        short M14_L27
       lea       edx,[rsi+1]
       cmp       edx,ebp
       jae       near ptr M14_L16
       mov       rcx,[rdi+8]
       cmp       edx,[rcx+8]
       jae       near ptr M14_L125
       mov       rdx,[rcx+rdx*8+10]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M14_L26
       mov       rcx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [rdi],rcx
       jne       near ptr M14_L112
M14_L26:
       test      rdi,rdi
       je        short M14_L27
       movzx     ecx,byte ptr [r14+0A]
       cmp       cl,[rdi+0A]
       jne       short M14_L27
       test      byte ptr [r14+0B],10
       je        near ptr M14_L113
M14_L27:
       inc       esi
       jmp       near ptr M14_L23
M14_L28:
       mov       byte ptr [rbx+11],1
M14_L29:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M14_L30:
       dec       ebp
M14_L31:
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       cmp       ebp,[rcx+10]
       jae       near ptr M14_L16
       mov       rcx,[rcx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M14_L125
       mov       eax,ebp
       mov       r13,[rcx+rax*8+10]
       test      sil,sil
       je        near ptr M14_L58
       movzx     ecx,byte ptr [r13+0A]
       test      byte ptr [r13+0B],10
       je        near ptr M14_L59
       movzx     r12d,word ptr [r13+8]
       add       r12d,1FFFE
M14_L32:
       movzx     ecx,byte ptr [r15+0A]
       test      byte ptr [r15+0B],10
       je        near ptr M14_L68
       movzx     eax,word ptr [r15+8]
       add       eax,1FFFE
M14_L33:
       cmp       r12d,eax
       jl        short M14_L37
       jg        short M14_L36
       mov       r12,r13
       test      r12,r12
       je        short M14_L34
       mov       rdx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [r12],rdx
       jne       near ptr M14_L77
M14_L34:
       test      r12,r12
       je        short M14_L36
       mov       r13,r15
       test      r13,r13
       je        short M14_L35
       mov       rdx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [r13],rdx
       jne       near ptr M14_L78
M14_L35:
       test      r13,r13
       je        short M14_L36
       mov       rcx,[r12+10]
       mov       rdx,[r13+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1ED78A8]; System.Security.Principal.SecurityIdentifier.CompareTo(System.Security.Principal.SecurityIdentifier)
       test      eax,eax
       jl        short M14_L37
M14_L36:
       cmp       edi,ebp
       jl        near ptr M14_L30
M14_L37:
       cmp       edi,ebp
       jne       near ptr M14_L79
M14_L38:
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       cmp       edi,[rcx+10]
       jae       near ptr M14_L16
       mov       rcx,[rcx+8]
       cmp       edi,[rcx+8]
       jae       near ptr M14_L125
       mov       eax,edi
       mov       r13,[rcx+rax*8+10]
       test      sil,sil
       je        near ptr M14_L81
       movzx     ecx,byte ptr [r13+0A]
       test      byte ptr [r13+0B],10
       je        near ptr M14_L82
       movzx     r12d,word ptr [r13+8]
       add       r12d,1FFFE
M14_L39:
       movzx     ecx,byte ptr [r15+0A]
       test      byte ptr [r15+0B],10
       je        near ptr M14_L91
       movzx     eax,word ptr [r15+8]
       add       eax,1FFFE
M14_L40:
       cmp       r12d,eax
       jl        short M14_L43
       jg        short M14_L44
       mov       r12,r13
       test      r12,r12
       je        short M14_L41
       mov       rdx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [r12],rdx
       jne       near ptr M14_L100
M14_L41:
       test      r12,r12
       je        short M14_L43
       mov       r13,r15
       test      r13,r13
       je        short M14_L42
       mov       rdx,offset MT_System.Security.AccessControl.CommonAce
       cmp       [r13],rdx
       jne       near ptr M14_L101
M14_L42:
       test      r13,r13
       je        short M14_L43
       mov       rcx,[r12+10]
       mov       rdx,[r13+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1ED78A8]; System.Security.Principal.SecurityIdentifier.CompareTo(System.Security.Principal.SecurityIdentifier)
       test      eax,eax
       jl        short M14_L43
       test      eax,eax
       jg        short M14_L44
M14_L43:
       cmp       edi,ebp
       jl        near ptr M14_L80
M14_L44:
       cmp       edi,ebp
       je        near ptr M14_L09
       jmp       near ptr M14_L102
M14_L45:
       mov       ecx,0CBD
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       rcx,rax
       call      qword ptr [7FF9C1EF6A18]
       int       3
M14_L46:
       mov       rdx,rbp
       mov       rcx,offset MT_System.Security.AccessControl.KnownAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdx,rax
       jmp       near ptr M14_L01
M14_L47:
       and       ecx,0F0
       mov       [rbp+0B],cl
       jmp       near ptr M14_L03
M14_L48:
       movzx     ecx,byte ptr [rbp+0B]
       test      cl,8
       je        short M14_L49
       test      cl,2
       jne       short M14_L49
       test      cl,1
       je        short M14_L52
M14_L49:
       test      cl,4
       je        near ptr M14_L03
       test      cl,2
       jne       near ptr M14_L03
       test      cl,1
       jne       near ptr M14_L03
       and       ecx,0FB
       mov       [rbp+0B],cl
       jmp       near ptr M14_L03
M14_L50:
       mov       rcx,offset MT_System.Security.AccessControl.QualifiedAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       jmp       near ptr M14_L04
M14_L51:
       cmp       dword ptr [r14+20],1
       je        near ptr M14_L05
M14_L52:
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       mov       edx,edi
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1933610]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       jmp       near ptr M14_L05
M14_L53:
       test      byte ptr [rbp+0B],0C0
       je        short M14_L52
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF9C1E6FAC8]; System.Security.AccessControl.GenericAce.op_Equality(System.Security.AccessControl.GenericAce, System.Security.AccessControl.GenericAce)
       test      eax,eax
       jne       near ptr M14_L05
       cmp       dword ptr [r14+20],2
       jne       short M14_L52
       jmp       near ptr M14_L05
M14_L54:
       movzx     ebp,byte ptr [rdi+10]
       mov       r14,[rdi+8]
       mov       rcx,offset MT_System.Security.AccessControl.RawAcl
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r8d,[r14+10]
       mov       rcx,r15
       mov       edx,ebp
       call      qword ptr [7FF9C1EFCA68]
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebp,ebp
       jmp       short M14_L57
M14_L55:
       mov       rcx,[rdi+8]
       cmp       ebp,[rcx+10]
       jae       near ptr M14_L16
       mov       rcx,[rcx+8]
       cmp       ebp,[rcx+8]
       jae       near ptr M14_L125
       mov       rcx,[rcx+rbp*8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1E6FD50]; System.Security.AccessControl.GenericAce.Copy()
       mov       [rsp+30],rax
       movzx     r8d,sil
       lea       rdx,[rsp+30]
       mov       rcx,rbx
       call      qword ptr [7FF9C1E6FAB0]; System.Security.AccessControl.CommonAcl.InspectAce(System.Security.AccessControl.GenericAce ByRef, Boolean)
       test      eax,eax
       je        short M14_L56
       mov       rdx,[rbx+8]
       mov       rdx,[rdx+8]
       mov       edx,[rdx+10]
       mov       rcx,[rbx+8]
       mov       r8,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1EFC510]
M14_L56:
       inc       ebp
M14_L57:
       mov       rcx,[rdi+8]
       cmp       ebp,[rcx+10]
       jl        short M14_L55
       jmp       near ptr M14_L06
M14_L58:
       mov       rcx,r13
       call      qword ptr [7FF9C1EF7FC0]
       mov       r12d,eax
       mov       rcx,r15
       call      qword ptr [7FF9C1EF7FC0]
       jmp       near ptr M14_L33
M14_L59:
       cmp       ecx,1
       je        short M14_L60
       cmp       ecx,0A
       jne       short M14_L61
M14_L60:
       xor       r12d,r12d
       jmp       near ptr M14_L32
M14_L61:
       cmp       ecx,6
       je        short M14_L62
       cmp       ecx,0C
       jne       short M14_L63
M14_L62:
       mov       r12d,1
       jmp       near ptr M14_L32
M14_L63:
       test      ecx,ecx
       je        short M14_L64
       cmp       ecx,9
       jne       short M14_L65
M14_L64:
       mov       r12d,2
       jmp       near ptr M14_L32
M14_L65:
       cmp       ecx,5
       je        short M14_L66
       cmp       ecx,0B
       jne       short M14_L67
M14_L66:
       mov       r12d,3
       jmp       near ptr M14_L32
M14_L67:
       movzx     r12d,word ptr [r13+8]
       add       r12d,0FFFF
       jmp       near ptr M14_L32
M14_L68:
       cmp       ecx,1
       je        short M14_L69
       cmp       ecx,0A
       jne       short M14_L70
M14_L69:
       xor       eax,eax
       jmp       near ptr M14_L33
M14_L70:
       cmp       ecx,6
       je        short M14_L71
       cmp       ecx,0C
       jne       short M14_L72
M14_L71:
       mov       eax,1
       jmp       near ptr M14_L33
M14_L72:
       test      ecx,ecx
       je        short M14_L73
       cmp       ecx,9
       jne       short M14_L74
M14_L73:
       mov       eax,2
       jmp       near ptr M14_L33
M14_L74:
       cmp       ecx,5
       je        short M14_L75
       cmp       ecx,0B
       jne       short M14_L76
M14_L75:
       mov       eax,3
       jmp       near ptr M14_L33
M14_L76:
       movzx     eax,word ptr [r15+8]
       add       eax,0FFFF
       jmp       near ptr M14_L33
M14_L77:
       mov       rdx,r13
       mov       rcx,offset MT_System.Security.AccessControl.KnownAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       jmp       near ptr M14_L34
M14_L78:
       mov       rdx,r15
       mov       rcx,offset MT_System.Security.AccessControl.KnownAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       jmp       near ptr M14_L35
M14_L79:
       mov       rcx,[rbx+8]
       mov       r8,[rbx+8]
       mov       r8,[r8+8]
       cmp       ebp,[r8+10]
       jae       near ptr M14_L16
       mov       r8,[r8+8]
       cmp       ebp,[r8+8]
       jae       near ptr M14_L125
       mov       edx,ebp
       mov       r8,[r8+rdx*8+10]
       mov       edx,edi
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1EDA1A8]; System.Security.AccessControl.RawAcl.set_Item(Int32, System.Security.AccessControl.GenericAce)
M14_L80:
       inc       edi
       jmp       near ptr M14_L38
M14_L81:
       mov       rcx,r13
       call      qword ptr [7FF9C1EF7FC0]
       mov       r12d,eax
       mov       rcx,r15
       call      qword ptr [7FF9C1EF7FC0]
       jmp       near ptr M14_L40
M14_L82:
       cmp       ecx,1
       je        short M14_L83
       cmp       ecx,0A
       jne       short M14_L84
M14_L83:
       xor       r12d,r12d
       jmp       near ptr M14_L39
M14_L84:
       cmp       ecx,6
       je        short M14_L85
       cmp       ecx,0C
       jne       short M14_L86
M14_L85:
       mov       r12d,1
       jmp       near ptr M14_L39
M14_L86:
       test      ecx,ecx
       je        short M14_L87
       cmp       ecx,9
       jne       short M14_L88
M14_L87:
       mov       r12d,2
       jmp       near ptr M14_L39
M14_L88:
       cmp       ecx,5
       je        short M14_L89
       cmp       ecx,0B
       jne       short M14_L90
M14_L89:
       mov       r12d,3
       jmp       near ptr M14_L39
M14_L90:
       movzx     r12d,word ptr [r13+8]
       add       r12d,0FFFF
       jmp       near ptr M14_L39
M14_L91:
       cmp       ecx,1
       je        short M14_L92
       cmp       ecx,0A
       jne       short M14_L93
M14_L92:
       xor       eax,eax
       jmp       near ptr M14_L40
M14_L93:
       cmp       ecx,6
       je        short M14_L94
       cmp       ecx,0C
       jne       short M14_L95
M14_L94:
       mov       eax,1
       jmp       near ptr M14_L40
M14_L95:
       test      ecx,ecx
       je        short M14_L96
       cmp       ecx,9
       jne       short M14_L97
M14_L96:
       mov       eax,2
       jmp       near ptr M14_L40
M14_L97:
       cmp       ecx,5
       je        short M14_L98
       cmp       ecx,0B
       jne       short M14_L99
M14_L98:
       mov       eax,3
       jmp       near ptr M14_L40
M14_L99:
       movzx     eax,word ptr [r15+8]
       add       eax,0FFFF
       jmp       near ptr M14_L40
M14_L100:
       mov       rdx,r13
       mov       rcx,offset MT_System.Security.AccessControl.KnownAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       jmp       near ptr M14_L41
M14_L101:
       mov       rdx,r15
       mov       rcx,offset MT_System.Security.AccessControl.KnownAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       jmp       near ptr M14_L42
M14_L102:
       mov       rcx,[rbx+8]
       mov       r8,[rbx+8]
       mov       r8,[r8+8]
       cmp       edi,[r8+10]
       jae       near ptr M14_L16
       mov       r8,[r8+8]
       cmp       edi,[r8+8]
       jae       near ptr M14_L125
       mov       edx,edi
       mov       r8,[r8+rdx*8+10]
       mov       edx,ebp
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1EDA1A8]; System.Security.AccessControl.RawAcl.set_Item(Int32, System.Security.AccessControl.GenericAce)
       dec       ebp
       jmp       near ptr M14_L09
M14_L103:
       mov       ecx,0C4F
       mov       rdx,7FF9C1ED46B8
       call      qword ptr [7FF9C184F210]
       mov       rcx,rax
       call      qword ptr [7FF9C1EF6A18]
       int       3
M14_L104:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M14_L11
M14_L105:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1EFC078]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M14_L106:
       xor       r12d,r12d
       jmp       near ptr M14_L13
M14_L107:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r12d,eax
       jmp       near ptr M14_L13
M14_L108:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M14_L15
M14_L109:
       mov       rcx,offset MT_System.OverflowException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9C1EFC258]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C1EFC270]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M14_L110:
       lea       r8d,[rdi-1]
       movzx     r9d,sil
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9C1E6FB10]; System.Security.AccessControl.CommonAcl.QuickSort(Int32, Int32, Boolean)
       jmp       near ptr M14_L21
M14_L111:
       mov       rcx,offset MT_System.Security.AccessControl.QualifiedAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       jmp       near ptr M14_L25
M14_L112:
       mov       rcx,offset MT_System.Security.AccessControl.QualifiedAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M14_L26
M14_L113:
       test      byte ptr [rdi+0B],10
       jne       near ptr M14_L27
       mov       ecx,[r14+20]
       cmp       ecx,[rdi+20]
       jne       near ptr M14_L27
       mov       rcx,[r14+10]
       mov       rdx,[rdi+10]
       call      qword ptr [7FF9C1EFC330]
       test      eax,eax
       je        near ptr M14_L27
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF9C1EFC348]
       test      eax,eax
       je        near ptr M14_L27
       movzx     edx,byte ptr [r14+0B]
       cmp       dl,[rdi+0B]
       jne       short M14_L117
       mov       rdx,r14
       mov       rcx,offset MT_System.Security.AccessControl.ObjectAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M14_L114
       mov       rdx,rdi
       mov       rcx,offset MT_System.Security.AccessControl.ObjectAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M14_L116
M14_L114:
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF9C1EFC2B8]
       test      eax,eax
       je        short M14_L117
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF9C1EFC2D0]
       test      eax,eax
       je        short M14_L117
       jmp       short M14_L116
M14_L115:
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       lea       edx,[rsi+1]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C1933610]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       jmp       near ptr M14_L27
M14_L116:
       mov       edx,[rdi+0C]
       or        [r14+0C],edx
       jmp       short M14_L115
M14_L117:
       movzx     edx,byte ptr [r14+0B]
       and       edx,0F
       movzx     ecx,byte ptr [rdi+0B]
       and       ecx,0F
       cmp       edx,ecx
       jne       short M14_L120
       mov       edx,[r14+0C]
       cmp       edx,[rdi+0C]
       jne       short M14_L120
       mov       rdx,r14
       mov       rcx,offset MT_System.Security.AccessControl.ObjectAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M14_L118
       mov       rdx,rdi
       mov       rcx,offset MT_System.Security.AccessControl.ObjectAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M14_L119
M14_L118:
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF9C1EFC2B8]
       test      eax,eax
       je        short M14_L120
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF9C1EFC2E8]
       test      eax,eax
       je        short M14_L120
M14_L119:
       movzx     edx,byte ptr [rdi+0B]
       and       edx,0C0
       or        [r14+0B],dl
       jmp       near ptr M14_L115
M14_L120:
       movzx     edx,byte ptr [r14+0B]
       and       edx,0C0
       movzx     ecx,byte ptr [rdi+0B]
       and       ecx,0C0
       cmp       edx,ecx
       jne       near ptr M14_L27
       mov       edx,[r14+0C]
       cmp       edx,[rdi+0C]
       jne       near ptr M14_L27
       mov       rdx,r14
       mov       rcx,offset MT_System.Security.AccessControl.ObjectAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M14_L121
       mov       rdx,rdi
       mov       rcx,offset MT_System.Security.AccessControl.ObjectAce
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M14_L122
M14_L121:
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF9C1EFC2E8]
       test      eax,eax
       je        near ptr M14_L27
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF9C1EFC318]
       test      eax,eax
       je        near ptr M14_L27
       movzx     ecx,byte ptr [r14+0B]
       movzx     edx,byte ptr [rdi+0B]
       movzx     r8d,byte ptr [rbx+13]
       lea       r9,[rsp+28]
       call      qword ptr [7FF9C1EFC300]
       test      eax,eax
       je        near ptr M14_L27
       movzx     ecx,byte ptr [rsp+28]
       movzx     edx,byte ptr [r14+0B]
       and       edx,0C0
       or        ecx,edx
       mov       [r14+0B],cl
       jmp       near ptr M14_L115
M14_L122:
       movzx     ecx,byte ptr [r14+0B]
       movzx     edx,byte ptr [rdi+0B]
       movzx     r8d,byte ptr [rbx+13]
       lea       r9,[rsp+28]
       call      qword ptr [7FF9C1EFC300]
       test      eax,eax
       je        near ptr M14_L27
       movzx     ecx,byte ptr [rsp+28]
       movzx     edx,byte ptr [r14+0B]
       and       edx,0C0
       or        ecx,edx
       mov       [r14+0B],cl
       jmp       near ptr M14_L115
M14_L123:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Security.AccessControl.DiscretionaryAcl
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       setne     r8b
       movzx     r8d,r8b
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9C1E6FAF8]; System.Security.AccessControl.CommonAcl.Canonicalize(Boolean, Boolean)
       mov       byte ptr [rbx+10],0
       jmp       near ptr M14_L24
M14_L124:
       mov       byte ptr [rbx+11],0
       jmp       near ptr M14_L29
M14_L125:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3290
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M15_L01
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M15_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M15_L01
M15_L00:
       test      rax,rax
       je        short M15_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M15_L02
M15_L01:
       mov       rax,rdx
       ret
M15_L02:
       test      rax,rax
       je        short M15_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M15_L01
       test      rax,rax
       je        short M15_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M15_L01
       test      rax,rax
       je        short M15_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M15_L01
       jmp       short M15_L00
M15_L03:
       xor       edx,edx
       jmp       short M15_L01
; Total bytes of code 88
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M16_L03
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M16_L02
       mov       r10,[rax+38]
       cmp       r8,4
       jge       short M16_L05
M16_L00:
       cmp       [r10],rcx
       je        short M16_L03
M16_L01:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M16_L04
M16_L02:
       test      dword ptr [rax],500C0000
       jne       short M16_L06
       xor       edx,edx
M16_L03:
       mov       rax,rdx
       ret
M16_L04:
       cmp       [r10],rcx
       je        short M16_L03
       jmp       short M16_L01
M16_L05:
       cmp       [r10],rcx
       je        short M16_L03
       cmp       [r10+8],rcx
       je        short M16_L03
       cmp       [r10+10],rcx
       je        short M16_L03
       cmp       [r10+18],rcx
       je        short M16_L03
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M16_L05
       test      r8,r8
       je        short M16_L02
       jmp       short M16_L00
M16_L06:
       jmp       qword ptr [7FF9C1BCD908]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 116
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.FileHelperBenchmark.FileHasInvalidChars()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+1A0]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L19
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rax,[rsi+18]
       test      rax,rax
       je        near ptr M00_L07
M00_L00:
       test      rax,rax
       jne       near ptr M00_L05
       xor       ecx,ecx
       xor       edx,edx
M00_L01:
       mov       rax,1E48D402218
       mov       rax,[rax]
       mov       r8,rcx
       mov       r10d,edx
       add       rax,8
       mov       r9,r8
       cmp       r10d,8
       jl        near ptr M00_L08
       cmp       r10d,10
       jle       near ptr M00_L17
       vmovups   ymm0,[rax]
       cmp       r10d,20
       jg        near ptr M00_L12
M00_L02:
       add       r10d,0FFFFFFF0
       movsxd    rax,r10d
       lea       rax,[r8+rax*2]
       cmp       r9,rax
       mov       rcx,r9
       cmova     rcx,rax
       vbroadcastss ymm1,dword ptr [7FF9C1F853E0]
       vpminuw   ymm2,ymm1,[rcx]
       vpminuw   ymm1,ymm1,[rax]
       vpackuswb ymm1,ymm2,ymm1
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FF9C1F85400]
       vbroadcastsd ymm2,qword ptr [7FF9C1F85420]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       jne       near ptr M00_L15
M00_L03:
       mov       ecx,0FFFFFFFF
M00_L04:
       mov       eax,ecx
       not       eax
       shr       eax,1F
       mov       rcx,[rbx+88]
       mov       [rcx+4C],al
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L05:
       lea       rcx,[rax+0C]
       mov       edx,[rax+8]
       jmp       near ptr M00_L01
M00_L06:
       call      qword ptr [7FF9C1DCF0D8]
       mov       ecx,0A39
       mov       rdx,7FF9C1ED3A58
       call      qword ptr [7FF9C184F210]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9C1B14C98
       call      qword ptr [7FF9C184F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C184D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9C1ED3A58
       call      qword ptr [7FF9C184F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9C184D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9C1F1C588]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9C1F174E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,[rsi+10]
       call      qword ptr [7FF9C1F17450]
       mov       rdi,rax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       jmp       near ptr M00_L00
M00_L08:
       mov       ecx,edx
       lea       rcx,[r8+rcx*2]
       cmp       r9,rcx
       je        near ptr M00_L03
M00_L09:
       movzx     edx,word ptr [r9]
       cmp       [rax],al
       lea       r10,[rax+20]
       cmp       edx,100
       jge       short M00_L10
       cmp       [r10],r10b
       mov       r11d,edx
       sar       r11d,5
       mov       r10d,[r10+r11*4]
       bt        r10d,edx
       setb      dl
       movzx     edx,dl
       test      edx,edx
       jne       short M00_L11
M00_L10:
       add       r9,2
       cmp       r9,rcx
       jne       short M00_L09
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,r9
       sub       rcx,r8
       shr       rcx,1
       jmp       near ptr M00_L04
M00_L12:
       lea       eax,[r10-20]
       movsxd    rdx,eax
       lea       rcx,[r8+rdx*2]
M00_L13:
       vbroadcastss ymm1,dword ptr [7FF9C1F853E0]
       vpminuw   ymm2,ymm1,[r9]
       vpminuw   ymm1,ymm1,[r9+20]
       vpackuswb ymm1,ymm2,ymm1
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FF9C1F85400]
       vbroadcastsd ymm3,qword ptr [7FF9C1F85420]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vptest    ymm1,ymm1
       jne       short M00_L14
       add       r9,40
       cmp       r9,rcx
       jb        short M00_L13
       jmp       near ptr M00_L02
M00_L14:
       mov       rcx,r9
       sub       rcx,r8
       shr       rcx,1
       vpermq    ymm0,ymm1,0D8
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vpmovmskb r8d,ymm0
       mov       r9d,r8d
       not       r9d
       xor       eax,eax
       tzcnt     eax,r9d
       add       ecx,eax
       jmp       near ptr M00_L04
M00_L15:
       vpermq    ymm0,ymm0,0D8
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vpmovmskb r9d,ymm0
       mov       edx,r9d
       not       edx
       tzcnt     edx,edx
       cmp       edx,10
       jl        short M00_L16
       mov       rcx,rax
       add       edx,0FFFFFFF0
M00_L16:
       sub       rcx,r8
       shr       rcx,1
       add       ecx,edx
       jmp       near ptr M00_L04
M00_L17:
       vmovups   xmm0,[rax]
       add       edx,0FFFFFFF8
       movsxd    rax,edx
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       mov       rdx,rcx
       cmova     rdx,rax
       vmovups   xmm1,[rdx]
       vpminuw   xmm1,xmm1,[7FF9C1F85430]
       vmovups   xmm2,[rax]
       vpminuw   xmm2,xmm2,[7FF9C1F85430]
       vpackuswb xmm1,xmm1,xmm2
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FF9C1F85400]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9C1F85420]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M00_L03
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vpmovmskb r8d,xmm0
       not       r8d
       tzcnt     r8d,r8d
       cmp       r8d,8
       jl        short M00_L18
       mov       rdx,rax
       add       r8d,0FFFFFFF8
M00_L18:
       sub       rdx,rcx
       shr       rdx,1
       lea       ecx,[rdx+r8]
       jmp       near ptr M00_L04
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 878
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA214E50F0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9C1845818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9C1845818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,225222D0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L04:
       call      qword ptr [7FF9C1F163B8]
       int       3
; Total bytes of code 244
```

