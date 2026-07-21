## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogApplicationInformation()
       mov       rcx,[rcx+198]
       jmp       qword ptr [7FF8A823E0A0]; DotNetTips.Spargine.Core.Logging.LoggingHelper.LogApplicationInformation(Microsoft.Extensions.Logging.ILogger)
; Total bytes of code 13
```
```assembly
; DotNetTips.Spargine.Core.Logging.LoggingHelper.LogApplicationInformation(Microsoft.Extensions.Logging.ILogger)
; 		logger = logger.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (!logger.IsEnabled(LogLevel.Information))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var appInfo = App.AppInfo;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogInformationMessage($"{nameof(AppInfo)}:{nameof(appInfo.Company)} - {appInfo.Company}");
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogInformationMessage($"{nameof(AppInfo)}:{nameof(appInfo.Configuration)} - {appInfo.Configuration}");
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogInformationMessage($"{nameof(AppInfo)}:{nameof(appInfo.Copyright)} - {appInfo.Copyright}");
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogInformationMessage($"{nameof(AppInfo)}:{nameof(appInfo.Description)} - {appInfo.Description}");
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogInformationMessage($"{nameof(AppInfo)}:{nameof(appInfo.FileVersion)} - {appInfo.FileVersion}");
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogInformationMessage($"{nameof(AppInfo)}:{nameof(appInfo.Product)} - {appInfo.Product}");
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogInformationMessage($"{nameof(AppInfo)}:{nameof(appInfo.Title)} - {appInfo.Title}");
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogInformationMessage($"{nameof(AppInfo)}:{nameof(appInfo.Version)} - {appInfo.Version}");
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1A0
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+1A0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1C0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L06
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark>
       cmp       [rbx],rcx
       jne       near ptr M01_L12
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M01_L11
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        near ptr M01_L07
       xor       ecx,ecx
       mov       [rsp+58],rcx
       xor       edi,edi
       mov       ebp,[rsi+8]
       cmp       ebp,edi
       jg        near ptr M01_L08
M01_L01:
       cmp       qword ptr [rsp+58],0
       jne       near ptr M01_L10
M01_L02:
       cmp       ebp,edi
       setg      sil
       movzx     esi,sil
M01_L03:
       xor       ecx,ecx
       mov       [rsp+58],rcx
M01_L04:
       test      esi,esi
       jne       near ptr M01_L13
M01_L05:
       add       rsp,1A0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       call      qword ptr [7FF8A81BE5F8]
       mov       ecx,2157
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E47798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7EF4D10
       call      qword ptr [7FF8A7E47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A82D6658]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A82D5758]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L07:
       xor       esi,esi
       jmp       near ptr M01_L03
M01_L08:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,2
       call      qword ptr [7FF8A82D5680]
       test      eax,eax
       je        short M01_L09
       mov       rdx,[r14]
       lea       r8,[rsp+58]
       mov       ecx,2
       call      qword ptr [7FF8A82D5698]
       test      eax,eax
       jne       near ptr M01_L01
M01_L09:
       inc       edi
       cmp       ebp,edi
       jg        short M01_L08
       jmp       near ptr M01_L01
M01_L10:
       mov       rcx,[rsp+58]
       cmp       dword ptr [rcx+10],0
       jle       near ptr M01_L02
       mov       rcx,[rsp+58]
       call      qword ptr [7FF8A82D56B0]
       int       3
M01_L11:
       mov       r11,7FF8A7B70A20
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M01_L04
M01_L12:
       mov       rcx,rbx
       mov       r11,7FF8A7B70A18
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M01_L04
M01_L13:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.App
       call      qword ptr [7FF8A7C25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,16AEFC00258
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7E4FFC0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       mov       rsi,rax
       lea       rcx,[rsp+178]
       mov       edx,4
       mov       r8d,3
       call      qword ptr [7FF8A7E44E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rsp+178]
       mov       rdx,1AB6EC70DD8
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+188]
       cmp       ecx,[rsp+198]
       ja        near ptr M01_L51
       mov       rdx,[rsp+190]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+198]
       sub       eax,ecx
       je        short M01_L14
       mov       word ptr [rdx],3A
       mov       ecx,[rsp+188]
       inc       ecx
       mov       [rsp+188],ecx
       jmp       short M01_L15
M01_L14:
       lea       rcx,[rsp+178]
       mov       rdx,1AB6EC60640
       call      qword ptr [7FF8A8237BA0]
M01_L15:
       lea       rcx,[rsp+178]
       mov       rdx,1AB6EC70E00
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+188]
       cmp       ecx,[rsp+198]
       ja        near ptr M01_L51
       mov       rdx,[rsp+190]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+198]
       sub       eax,ecx
       cmp       eax,3
       jb        short M01_L16
       mov       dword ptr [rdx],2D0020
       mov       word ptr [rdx+4],20
       mov       ecx,[rsp+188]
       add       ecx,3
       mov       [rsp+188],ecx
       jmp       short M01_L17
M01_L16:
       lea       rcx,[rsp+178]
       mov       rdx,1AB6EC70E28
       call      qword ptr [7FF8A8237BA0]
M01_L17:
       mov       rdx,[rsi+8]
       lea       rcx,[rsp+178]
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rsp+178]
       call      qword ptr [7FF8A7E44EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdi,rax
       mov       rcx,rbx
       mov       r11,7FF8A7B70A28
       mov       edx,2
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L18
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF8A831B740
       call      qword ptr [7FF8A7C25920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rbp,rax
       mov       rcx,1AB6EC70FA8
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       [rsp+38],rdi
       mov       rcx,1AB6EC70E48
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct
       call      qword ptr [7FF8A7C25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,16AEFC00280
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,2
       xor       eax,eax
       mov       [rsp+20],rax
       call      rbp
M01_L18:
       lea       rcx,[rsp+150]
       mov       edx,4
       mov       r8d,3
       call      qword ptr [7FF8A7E44E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rsp+150]
       mov       rdx,1AB6EC70DD8
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+160]
       cmp       ecx,[rsp+170]
       ja        near ptr M01_L51
       mov       rdx,[rsp+168]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+170]
       sub       eax,ecx
       je        short M01_L19
       mov       word ptr [rdx],3A
       mov       ecx,[rsp+160]
       inc       ecx
       mov       [rsp+160],ecx
       jmp       short M01_L20
M01_L19:
       lea       rcx,[rsp+150]
       mov       rdx,1AB6EC60640
       call      qword ptr [7FF8A8237BA0]
M01_L20:
       lea       rcx,[rsp+150]
       mov       rdx,1AB6EC70E90
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+160]
       cmp       ecx,[rsp+170]
       ja        near ptr M01_L51
       mov       rdx,[rsp+168]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+170]
       sub       eax,ecx
       cmp       eax,3
       jb        short M01_L21
       mov       dword ptr [rdx],2D0020
       mov       word ptr [rdx+4],20
       mov       ecx,[rsp+160]
       add       ecx,3
       mov       [rsp+160],ecx
       jmp       short M01_L22
M01_L21:
       lea       rcx,[rsp+150]
       mov       rdx,1AB6EC70E28
       call      qword ptr [7FF8A8237BA0]
M01_L22:
       mov       rdx,[rsi+10]
       lea       rcx,[rsp+150]
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rsp+150]
       call      qword ptr [7FF8A7E44EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdi,rax
       mov       rcx,rbx
       mov       r11,7FF8A7B70A30
       mov       edx,2
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L23
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF8A831B740
       call      qword ptr [7FF8A7C25920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rbp,rax
       mov       rcx,1AB6EC70FA8
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       [rsp+38],rdi
       mov       rcx,1AB6EC70E48
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct
       call      qword ptr [7FF8A7C25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,16AEFC00280
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,2
       xor       eax,eax
       mov       [rsp+20],rax
       call      rbp
M01_L23:
       lea       rcx,[rsp+128]
       mov       edx,4
       mov       r8d,3
       call      qword ptr [7FF8A7E44E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rsp+128]
       mov       rdx,1AB6EC70DD8
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+138]
       cmp       ecx,[rsp+148]
       ja        near ptr M01_L51
       mov       rdx,[rsp+140]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+148]
       sub       eax,ecx
       je        short M01_L24
       mov       word ptr [rdx],3A
       mov       ecx,[rsp+138]
       inc       ecx
       mov       [rsp+138],ecx
       jmp       short M01_L25
M01_L24:
       lea       rcx,[rsp+128]
       mov       rdx,1AB6EC60640
       call      qword ptr [7FF8A8237BA0]
M01_L25:
       lea       rcx,[rsp+128]
       mov       rdx,1AB6EC70EC0
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+138]
       cmp       ecx,[rsp+148]
       ja        near ptr M01_L51
       mov       rdx,[rsp+140]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+148]
       sub       eax,ecx
       cmp       eax,3
       jb        short M01_L26
       mov       dword ptr [rdx],2D0020
       mov       word ptr [rdx+4],20
       mov       ecx,[rsp+138]
       add       ecx,3
       mov       [rsp+138],ecx
       jmp       short M01_L27
M01_L26:
       lea       rcx,[rsp+128]
       mov       rdx,1AB6EC70E28
       call      qword ptr [7FF8A8237BA0]
M01_L27:
       mov       rdx,[rsi+18]
       lea       rcx,[rsp+128]
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rsp+128]
       call      qword ptr [7FF8A7E44EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdi,rax
       mov       rcx,rbx
       mov       r11,7FF8A7B70A38
       mov       edx,2
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L28
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF8A831B740
       call      qword ptr [7FF8A7C25920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rbp,rax
       mov       rcx,1AB6EC70FA8
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       [rsp+38],rdi
       mov       rcx,1AB6EC70E48
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct
       call      qword ptr [7FF8A7C25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,16AEFC00280
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,2
       xor       eax,eax
       mov       [rsp+20],rax
       call      rbp
M01_L28:
       lea       rcx,[rsp+100]
       mov       edx,4
       mov       r8d,3
       call      qword ptr [7FF8A7E44E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rsp+100]
       mov       rdx,1AB6EC70DD8
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+110]
       cmp       ecx,[rsp+120]
       ja        near ptr M01_L51
       mov       rdx,[rsp+118]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+120]
       sub       eax,ecx
       je        short M01_L29
       mov       word ptr [rdx],3A
       mov       ecx,[rsp+110]
       inc       ecx
       mov       [rsp+110],ecx
       jmp       short M01_L30
M01_L29:
       lea       rcx,[rsp+100]
       mov       rdx,1AB6EC60640
       call      qword ptr [7FF8A8237BA0]
M01_L30:
       lea       rcx,[rsp+100]
       mov       rdx,1AB6EC70EE8
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+110]
       cmp       ecx,[rsp+120]
       ja        near ptr M01_L51
       mov       rdx,[rsp+118]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+120]
       sub       eax,ecx
       cmp       eax,3
       jb        short M01_L31
       mov       dword ptr [rdx],2D0020
       mov       word ptr [rdx+4],20
       mov       ecx,[rsp+110]
       add       ecx,3
       mov       [rsp+110],ecx
       jmp       short M01_L32
M01_L31:
       lea       rcx,[rsp+100]
       mov       rdx,1AB6EC70E28
       call      qword ptr [7FF8A8237BA0]
M01_L32:
       mov       rdx,[rsi+28]
       lea       rcx,[rsp+100]
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rsp+100]
       call      qword ptr [7FF8A7E44EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdi,rax
       mov       rcx,rbx
       mov       r11,7FF8A7B70A40
       mov       edx,2
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L33
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF8A831B740
       call      qword ptr [7FF8A7C25920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rbp,rax
       mov       rcx,1AB6EC70FA8
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       [rsp+38],rdi
       mov       rcx,1AB6EC70E48
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct
       call      qword ptr [7FF8A7C25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,16AEFC00280
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,2
       xor       eax,eax
       mov       [rsp+20],rax
       call      rbp
M01_L33:
       lea       rcx,[rsp+0D8]
       mov       edx,4
       mov       r8d,3
       call      qword ptr [7FF8A7E44E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rsp+0D8]
       mov       rdx,1AB6EC70DD8
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+0E8]
       cmp       ecx,[rsp+0F8]
       ja        near ptr M01_L51
       mov       rdx,[rsp+0F0]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+0F8]
       sub       eax,ecx
       je        short M01_L34
       mov       word ptr [rdx],3A
       mov       ecx,[rsp+0E8]
       inc       ecx
       mov       [rsp+0E8],ecx
       jmp       short M01_L35
M01_L34:
       lea       rcx,[rsp+0D8]
       mov       rdx,1AB6EC60640
       call      qword ptr [7FF8A8237BA0]
M01_L35:
       lea       rcx,[rsp+0D8]
       mov       rdx,1AB6EC70F18
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+0E8]
       cmp       ecx,[rsp+0F8]
       ja        near ptr M01_L51
       mov       rdx,[rsp+0F0]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+0F8]
       sub       eax,ecx
       cmp       eax,3
       jb        short M01_L36
       mov       dword ptr [rdx],2D0020
       mov       word ptr [rdx+4],20
       mov       ecx,[rsp+0E8]
       add       ecx,3
       mov       [rsp+0E8],ecx
       jmp       short M01_L37
M01_L36:
       lea       rcx,[rsp+0D8]
       mov       rdx,1AB6EC70E28
       call      qword ptr [7FF8A8237BA0]
M01_L37:
       mov       rdx,[rsi+30]
       lea       rcx,[rsp+0D8]
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rsp+0D8]
       call      qword ptr [7FF8A7E44EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdi,rax
       mov       rcx,rbx
       mov       r11,7FF8A7B70A48
       mov       edx,2
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L38
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF8A831B740
       call      qword ptr [7FF8A7C25920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rbp,rax
       mov       rcx,1AB6EC70FA8
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       [rsp+38],rdi
       mov       rcx,1AB6EC70E48
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct
       call      qword ptr [7FF8A7C25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,16AEFC00280
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,2
       xor       eax,eax
       mov       [rsp+20],rax
       call      rbp
M01_L38:
       lea       rcx,[rsp+0B0]
       mov       edx,4
       mov       r8d,3
       call      qword ptr [7FF8A7E44E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rsp+0B0]
       mov       rdx,1AB6EC70DD8
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+0C0]
       cmp       ecx,[rsp+0D0]
       ja        near ptr M01_L51
       mov       rdx,[rsp+0C8]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+0D0]
       sub       eax,ecx
       je        short M01_L39
       mov       word ptr [rdx],3A
       mov       ecx,[rsp+0C0]
       inc       ecx
       mov       [rsp+0C0],ecx
       jmp       short M01_L40
M01_L39:
       lea       rcx,[rsp+0B0]
       mov       rdx,1AB6EC60640
       call      qword ptr [7FF8A8237BA0]
M01_L40:
       lea       rcx,[rsp+0B0]
       mov       rdx,1AB6EC70F48
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+0C0]
       cmp       ecx,[rsp+0D0]
       ja        near ptr M01_L51
       mov       rdx,[rsp+0C8]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+0D0]
       sub       eax,ecx
       cmp       eax,3
       jb        short M01_L41
       mov       dword ptr [rdx],2D0020
       mov       word ptr [rdx+4],20
       mov       ecx,[rsp+0C0]
       add       ecx,3
       mov       [rsp+0C0],ecx
       jmp       short M01_L42
M01_L41:
       lea       rcx,[rsp+0B0]
       mov       rdx,1AB6EC70E28
       call      qword ptr [7FF8A8237BA0]
M01_L42:
       mov       rdx,[rsi+38]
       lea       rcx,[rsp+0B0]
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rsp+0B0]
       call      qword ptr [7FF8A7E44EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdi,rax
       mov       rcx,rbx
       mov       r11,7FF8A7B70A50
       mov       edx,2
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L43
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF8A831B740
       call      qword ptr [7FF8A7C25920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rbp,rax
       mov       rcx,1AB6EC70FA8
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       [rsp+38],rdi
       mov       rcx,1AB6EC70E48
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct
       call      qword ptr [7FF8A7C25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,16AEFC00280
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,2
       xor       eax,eax
       mov       [rsp+20],rax
       call      rbp
M01_L43:
       lea       rcx,[rsp+88]
       mov       edx,4
       mov       r8d,3
       call      qword ptr [7FF8A7E44E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rsp+88]
       mov       rdx,1AB6EC70DD8
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+98]
       cmp       ecx,[rsp+0A8]
       ja        near ptr M01_L51
       mov       rdx,[rsp+0A0]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+0A8]
       sub       eax,ecx
       je        short M01_L44
       mov       word ptr [rdx],3A
       mov       ecx,[rsp+98]
       inc       ecx
       mov       [rsp+98],ecx
       jmp       short M01_L45
M01_L44:
       lea       rcx,[rsp+88]
       mov       rdx,1AB6EC60640
       call      qword ptr [7FF8A8237BA0]
M01_L45:
       lea       rcx,[rsp+88]
       mov       rdx,1AB6EC70F70
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+98]
       cmp       ecx,[rsp+0A8]
       ja        near ptr M01_L51
       mov       rdx,[rsp+0A0]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+0A8]
       sub       eax,ecx
       cmp       eax,3
       jb        short M01_L46
       mov       dword ptr [rdx],2D0020
       mov       word ptr [rdx+4],20
       mov       ecx,[rsp+98]
       add       ecx,3
       mov       [rsp+98],ecx
       jmp       short M01_L47
M01_L46:
       lea       rcx,[rsp+88]
       mov       rdx,1AB6EC70E28
       call      qword ptr [7FF8A8237BA0]
M01_L47:
       mov       rdx,[rsi+40]
       lea       rcx,[rsp+88]
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rsp+88]
       call      qword ptr [7FF8A7E44EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdi,rax
       mov       rcx,rbx
       mov       r11,7FF8A7B70A58
       mov       edx,2
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L48
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF8A831B740
       call      qword ptr [7FF8A7C25920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rbp,rax
       mov       rcx,1AB6EC70FA8
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       [rsp+38],rdi
       mov       rcx,1AB6EC70E48
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct
       call      qword ptr [7FF8A7C25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,16AEFC00280
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,2
       xor       eax,eax
       mov       [rsp+20],rax
       call      rbp
M01_L48:
       lea       rcx,[rsp+60]
       mov       edx,4
       mov       r8d,3
       call      qword ptr [7FF8A7E44E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rsp+60]
       mov       rdx,1AB6EC70DD8
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+70]
       cmp       ecx,[rsp+80]
       ja        short M01_L51
       mov       rdx,[rsp+78]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+80]
       sub       eax,ecx
       je        short M01_L49
       mov       word ptr [rdx],3A
       mov       ecx,[rsp+70]
       inc       ecx
       mov       [rsp+70],ecx
       jmp       short M01_L50
M01_L49:
       lea       rcx,[rsp+60]
       mov       rdx,1AB6EC60640
       call      qword ptr [7FF8A8237BA0]
M01_L50:
       lea       rcx,[rsp+60]
       mov       rdx,1AB6EC6B840
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rsp+70]
       cmp       ecx,[rsp+80]
       jbe       short M01_L52
M01_L51:
       call      qword ptr [7FF8A7D97198]
       int       3
M01_L52:
       mov       rdx,[rsp+78]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+80]
       sub       eax,ecx
       cmp       eax,3
       jb        short M01_L53
       mov       dword ptr [rdx],2D0020
       mov       word ptr [rdx+4],20
       mov       ecx,[rsp+70]
       add       ecx,3
       mov       [rsp+70],ecx
       jmp       short M01_L54
M01_L53:
       lea       rcx,[rsp+60]
       mov       rdx,1AB6EC70E28
       call      qword ptr [7FF8A8237BA0]
M01_L54:
       mov       rdx,[rsi+48]
       lea       rcx,[rsp+60]
       call      qword ptr [7FF8A7E4E388]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rsp+60]
       call      qword ptr [7FF8A7E44EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rsi,rax
       mov       rcx,rbx
       mov       r11,7FF8A7B70A60
       mov       edx,2
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L05
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF8A831B740
       call      qword ptr [7FF8A7C25920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rdi,rax
       mov       rcx,1AB6EC70FA8
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       [rsp+38],rsi
       mov       rcx,1AB6EC70E48
       mov       [rsp+40],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct
       call      qword ptr [7FF8A7C25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,16AEFC00280
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       rcx,rbx
       mov       edx,2
       xor       eax,eax
       mov       [rsp+20],rax
       call      rdi
       jmp       near ptr M01_L05
; Total bytes of code 4258
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogComputerInformation()
       mov       rcx,[rcx+198]
       jmp       qword ptr [7FF8A822EB68]; DotNetTips.Spargine.Core.Logging.LoggingHelper.LogComputerInformation(Microsoft.Extensions.Logging.ILogger)
; Total bytes of code 13
```
```assembly
; DotNetTips.Spargine.Core.Logging.LoggingHelper.LogComputerInformation(Microsoft.Extensions.Logging.ILogger)
; 		logger = logger.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (!logger.IsEnabled(LogLevel.Information))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var computerInfo = new ComputerInfo();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.ComputerCulture), computerInfo.ComputerCulture);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.ComputerUICulture), computerInfo.ComputerUICulture);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.CurrentManagedThreadId), computerInfo.CurrentManagedThreadId.ToString(CultureInfo.CurrentCulture));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.CurrentStackTrace), computerInfo.CurrentStackTrace);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.CurrentSystemTickCount), computerInfo.CurrentSystemTickCount.ToString(CultureInfo.CurrentCulture));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.CurrentWorkingDirectory), computerInfo.CurrentWorkingDirectory);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.DiskUsage), computerInfo.DiskUsage);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.FrameworkDescription), computerInfo.FrameworkDescription);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.FrameworkVersion), computerInfo.FrameworkVersion.ToString());
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.GetCpuUsagePrivilegedTime), computerInfo.GetCpuUsagePrivilegedTime.ToString());
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.HasShutdownStarted), computerInfo.HasShutdownStarted.ToString(CultureInfo.CurrentCulture));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.IPAddress), computerInfo.IPAddress);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.Is64BitOperatingSystem), computerInfo.Is64BitOperatingSystem.ToString(CultureInfo.CurrentCulture));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.Is64BitProcess), computerInfo.Is64BitProcess.ToString(CultureInfo.CurrentCulture));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.IsNetworkAvailable), computerInfo.IsNetworkAvailable.ToString(CultureInfo.CurrentCulture));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.IsUserInteractive), computerInfo.IsUserInteractive.ToString(CultureInfo.CurrentCulture));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.LogicalDrives), computerInfo.LogicalDrives);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.MachineName), computerInfo.MachineName);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.OSArchitecture), computerInfo.OSArchitecture);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.OSDescription), computerInfo.OSDescription);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.OSMemoryPageSize), computerInfo.OSMemoryPageSize.ToString(CultureInfo.CurrentCulture));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.PhysicalMemoryInUse), computerInfo.PhysicalMemoryInUse.ToString(CultureInfo.CurrentCulture));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.ProcessArchitecture), computerInfo.ProcessArchitecture.ToString());
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.ProcessorCount), computerInfo.ProcessorCount.ToString(CultureInfo.CurrentCulture));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.SystemDirectory), computerInfo.SystemDirectory);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.SystemPageSize), computerInfo.SystemPageSize.ToString(CultureInfo.CurrentCulture));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.TickCount), computerInfo.TickCount.ToString(CultureInfo.CurrentCulture));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.TickCount64), computerInfo.TickCount64.ToString(CultureInfo.CurrentCulture));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.Uptime), computerInfo.Uptime.ToString());
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.UserDomainName), computerInfo.UserDomainName);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		logger.LogComputerInfoItem(nameof(computerInfo.UserName), computerInfo.UserName);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        short M01_L05
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark>
       cmp       [rbx],rcx
       jne       near ptr M01_L11
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M01_L10
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        near ptr M01_L06
       xor       ecx,ecx
       mov       [rsp+28],rcx
       xor       edi,edi
       mov       ebp,[rsi+8]
       cmp       ebp,edi
       jg        near ptr M01_L07
M01_L00:
       cmp       qword ptr [rsp+28],0
       jne       near ptr M01_L09
M01_L01:
       cmp       ebp,edi
       setg      sil
       movzx     esi,sil
M01_L02:
       xor       ecx,ecx
       mov       [rsp+28],rcx
M01_L03:
       test      esi,esi
       jne       near ptr M01_L12
M01_L04:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L05:
       call      qword ptr [7FF8A818F018]
       mov       ecx,2157
       mov       rdx,7FF8A7EC4D10
       call      qword ptr [7FF8A7E17798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7EC4D10
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7BF7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7EC4D10
       call      qword ptr [7FF8A7E17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7BF7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A82B77B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A82B60E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L06:
       xor       esi,esi
       jmp       near ptr M01_L02
M01_L07:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,2
       call      qword ptr [7FF8A82B5F98]
       test      eax,eax
       je        short M01_L08
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,2
       call      qword ptr [7FF8A82B5FB0]
       test      eax,eax
       jne       near ptr M01_L00
M01_L08:
       inc       edi
       cmp       ebp,edi
       jg        short M01_L07
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,[rsp+28]
       cmp       dword ptr [rcx+10],0
       jle       near ptr M01_L01
       mov       rcx,[rsp+28]
       call      qword ptr [7FF8A82B5FC8]
       int       3
M01_L10:
       mov       r11,7FF8A7B40A20
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M01_L03
M01_L11:
       mov       rcx,rbx
       mov       r11,7FF8A7B40A18
       mov       edx,2
       call      qword ptr [r11]
       mov       esi,eax
       jmp       near ptr M01_L03
M01_L12:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ComputerInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF8A822EBB0]
       mov       r8,[rsi+8]
       mov       rcx,rbx
       mov       rdx,17A3E780DD8
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       r8,[rsi+10]
       mov       rcx,rbx
       mov       rdx,17A3E780E40
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       edi,eax
       call      qword ptr [7FF8A7E15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r9,rax
       mov       ecx,edi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF8A82B77C8]
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,17A3E780E78
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       r8,[rsi+18]
       mov       rcx,rbx
       mov       rdx,17A3E780EC0
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       edi,[rsi+88]
       call      qword ptr [7FF8A7E15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r9,rax
       mov       ecx,edi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF8A82B77C8]
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,17A3E780EF8
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       r8,[rsi+20]
       mov       rcx,rbx
       mov       rdx,17A3E780F40
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       rcx,rsi
       call      qword ptr [7FF8A822EC70]
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,17A3E780F88
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       r8,[rsi+28]
       mov       rcx,rbx
       mov       rdx,17A3E780FB0
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       rdi,[rsi+30]
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FF8A7E1E580]; System.Version.get_DefaultFormatFieldCount()
       mov       edx,eax
       mov       rcx,rdi
       call      qword ptr [7FF8A7F742D0]; System.Version.ToString(Int32)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,17A3E780FF0
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       rcx,[rsi+0A8]
       call      qword ptr [7FF8A82B77E0]
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,17A3E781028
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       movzx     edi,byte ptr [rsi+0A0]
       call      qword ptr [7FF8A7E15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r8,17A3E7701E0
       mov       rcx,17A3E7701C0
       test      edi,edi
       cmove     r8,rcx
       mov       rcx,rbx
       mov       rdx,17A3E781070
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       r8,[rsi+38]
       mov       rcx,rbx
       mov       rdx,17A3E7810B0
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       movzx     edi,byte ptr [rsi+0A1]
       call      qword ptr [7FF8A7E15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r8,17A3E7701E0
       mov       rcx,17A3E7701C0
       test      edi,edi
       cmove     r8,rcx
       mov       rcx,rbx
       mov       rdx,17A3E7810D8
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       movzx     edi,byte ptr [rsi+0A2]
       call      qword ptr [7FF8A7E15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r8,17A3E7701E0
       mov       rcx,17A3E7701C0
       test      edi,edi
       cmove     r8,rcx
       mov       rcx,rbx
       mov       rdx,17A3E781120
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       rcx,rsi
       call      qword ptr [7FF8A822ED60]
       mov       edi,eax
       call      qword ptr [7FF8A7E15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r8,17A3E7701E0
       mov       rcx,17A3E7701C0
       test      edi,edi
       cmove     r8,rcx
       mov       rcx,rbx
       mov       rdx,17A3E781158
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       movzx     edi,byte ptr [rsi+0A3]
       call      qword ptr [7FF8A7E15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r8,17A3E7701E0
       mov       rcx,17A3E7701C0
       test      edi,edi
       cmove     r8,rcx
       mov       rcx,rbx
       mov       rdx,17A3E781198
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       r8,[rsi+40]
       mov       rcx,rbx
       mov       rdx,17A3E7811D0
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       r8,[rsi+48]
       mov       rcx,rbx
       mov       rdx,17A3E781200
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       r8,[rsi+50]
       mov       rcx,rbx
       mov       rdx,17A3E781230
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       r8,[rsi+58]
       mov       rcx,rbx
       mov       rdx,17A3E781268
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       edi,[rsi+8C]
       call      qword ptr [7FF8A7E15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r9,rax
       mov       ecx,edi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF8A82B77C8]
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,17A3E781298
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       rdi,[rsi+78]
       call      qword ptr [7FF8A7E15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF8A82B77F8]
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,17A3E7812D0
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       edi,[rsi+90]
       mov       rcx,offset MT_System.Runtime.InteropServices.Architecture
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rcx,rax
       call      qword ptr [7FF8A7B36098]; System.Enum.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,17A3E781310
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       edi,[rsi+94]
       call      qword ptr [7FF8A7E15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r9,rax
       mov       ecx,edi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF8A82B77C8]
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,17A3E781350
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       r8,[rsi+60]
       mov       rcx,rbx
       mov       rdx,17A3E781388
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       edi,[rsi+98]
       call      qword ptr [7FF8A7E15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r9,rax
       mov       ecx,edi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF8A82B77C8]
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,17A3E7813C0
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       edi,[rsi+9C]
       call      qword ptr [7FF8A7E15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r9,rax
       mov       ecx,edi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF8A82B77C8]
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,17A3E7813F8
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       rdi,[rsi+80]
       call      qword ptr [7FF8A7E15DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF8A82B77F8]
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,17A3E781420
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       call      00007FF8A7BE8C30
       mov       rcx,rax
       call      qword ptr [7FF8A8116B08]; System.TimeSpan.FromMilliseconds(Int64)
       mov       rcx,rax
       call      qword ptr [7FF8A82B77E0]
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,17A3E781450
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       r8,[rsi+68]
       mov       rcx,rbx
       mov       rdx,17A3E781478
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       mov       r8,[rsi+70]
       mov       rcx,rbx
       mov       rdx,17A3E7814B0
       mov       r9,17A3E780E10
       call      qword ptr [7FF8A822EBE0]
       jmp       near ptr M01_L04
; Total bytes of code 2005
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,2C353250DB0
       mov       [rsi+10],rcx
       mov       dword ptr [rsi+6C],80070216
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,80131500E0434352
       mov       [rdi+68],rcx
       mov       rcx,2C353250DD8
       mov       [rdi+10],rcx
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+6C],80004003
       mov       rcx,rdi
       call      qword ptr [7FF8A826EBB0]; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
       mov       rsi,rax
       mov       rcx,282D44001F8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L16
M00_L00:
       test      rsi,rsi
       je        near ptr M00_L22
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Exception>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M00_L17
       mov       rbp,rsi
       test      rbp,rbp
       je        near ptr M00_L21
       mov       rdx,rsi
       mov       rcx,offset MT_System.Exception[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<System.Exception>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M00_L20
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
       je        near ptr M00_L22
       mov       rdx,r15
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L30
       mov       rcx,offset MT_System.Linq.Enumerable+IListSelectIterator<System.Exception, System.String>
       cmp       [rsi],rcx
       jne       near ptr M00_L29
       mov       rcx,[rsi+18]
       mov       r15,rcx
       mov       r11,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>
       cmp       [rcx],r11
       jne       near ptr M00_L24
       mov       rcx,[rcx+8]
       mov       r11,offset MT_System.Collections.Generic.List<System.Exception>
       cmp       [rcx],r11
       jne       near ptr M00_L23
       mov       edi,[rcx+10]
M00_L02:
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      edi,edi
       jl        near ptr M00_L25
       test      edi,edi
       je        near ptr M00_L26
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
       jl        near ptr M00_L07
       cmp       edi,[rbp+10]
       jge       near ptr M00_L05
       mov       rdx,[rbp+8]
       mov       ecx,[rbp+10]
       sub       ecx,edi
       test      rdx,rdx
       je        near ptr M00_L27
       lea       rax,[rdx+10]
       xor       r8d,r8d
       mov       r10,[rdx]
       mov       r9d,[r10+4]
       cmp       r9d,18
       je        short M00_L04
       add       r9d,0FFFFFFE8
       shr       r9d,3
       movsxd    r8,r9d
       mov       r8d,[rax+r8*4]
       shl       r9d,3
       movsxd    r9,r9d
       add       rax,r9
M00_L04:
       mov       r9d,edi
       sub       r9d,r8d
       cmp       edi,r8d
       jl        near ptr M00_L28
       mov       r8d,r9d
       or        r8d,ecx
       jl        near ptr M00_L28
       lea       r8d,[r9+rcx]
       cmp       r8d,[rdx+8]
       ja        near ptr M00_L28
       movzx     edx,word ptr [r10]
       mov       r8d,r9d
       imul      r8,rdx
       add       r8,rax
       mov       ecx,ecx
       imul      rdx,rcx
       test      dword ptr [r10],1000000
       je        short M00_L06
       shr       rdx,3
       mov       rcx,r8
       call      qword ptr [7FF8A82FC828]
M00_L05:
       mov       [rbp+10],edi
       mov       edi,[rbp+10]
       mov       r14,[rbp+8]
       cmp       [r14+8],edi
       jae       near ptr M00_L13
       call      qword ptr [7FF8A7E57A08]
       int       3
M00_L06:
       mov       rcx,r8
       call      qword ptr [7FF8A7C357E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L05
M00_L07:
       mov       rcx,[rbp+8]
       cmp       dword ptr [rcx+8],0
       jne       short M00_L09
       mov       r14d,4
M00_L08:
       mov       ecx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,ecx
       cmp       r14d,edi
       cmovl     r14d,edi
       cmp       r14d,[rbp+10]
       jge       short M00_L10
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF8A81C6520]
       int       3
M00_L09:
       mov       rcx,[rbp+8]
       mov       r14d,[rcx+8]
       add       r14d,r14d
       jmp       short M00_L08
M00_L10:
       mov       rcx,[rbp+8]
       cmp       [rcx+8],r14d
       je        short M00_L05
       test      r14d,r14d
       jg        short M00_L11
       mov       rcx,282BE400230
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L05
M00_L11:
       mov       edx,r14d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       cmp       dword ptr [rbp+10],0
       jle       short M00_L12
       mov       rcx,[rbp+8]
       mov       r8d,[rbp+10]
       mov       rdx,r14
       call      qword ptr [7FF8A7C37048]; System.Array.Copy(System.Array, System.Array, Int32)
M00_L12:
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L05
M00_L13:
       add       r14,10
       mov       rsi,[rsi+20]
       xor       r13d,r13d
       test      edi,edi
       jle       short M00_L15
M00_L14:
       lea       rcx,[r14+r13*8]
       mov       [rsp+28],rcx
       mov       rcx,r15
       mov       edx,r13d
       mov       r11,7FF8A7B80A50
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rcx,[rsp+28]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r13d
       cmp       r13d,edi
       jl        short M00_L14
M00_L15:
       cmp       [rbp],bpl
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],rsi
       mov       rbx,[rbx+88]
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
M00_L16:
       mov       rcx,offset MT_System.Func<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,282D44001F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Logging.LoggingHelper+<>c.<RetrieveAllExceptionMessages>b__9_0(System.Exception)
       call      qword ptr [7FF8A7C36BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,282D44001F8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L17:
       mov       rcx,rbp
       mov       rdx,offset MT_System.Linq.Enumerable+Iterator<System.Exception>
       mov       r8,7FF8A834F378
       call      qword ptr [7FF8A7C35920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rcx,rbp
       mov       rdx,rdi
       call      rax
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L18:
       cmp       dword ptr [r14+8],0
       jne       short M00_L19
       mov       rcx,offset MT_System.Array+EmptyArray<System.String>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,282D4400280
       mov       r15,[rcx]
       jmp       near ptr M00_L01
M00_L19:
       mov       rcx,offset MT_System.Linq.Enumerable+ArraySelectIterator<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FF8A82FC438]
       jmp       near ptr M00_L01
M00_L20:
       mov       rcx,offset MT_System.Linq.Enumerable+ListSelectIterator<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FF8A82FC450]
       jmp       near ptr M00_L01
M00_L21:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableSelectIterator<System.Exception, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF8A82FC468]
       jmp       near ptr M00_L01
M00_L22:
       mov       ecx,11
       call      qword ptr [7FF8A7E57E58]
       int       3
M00_L23:
       mov       r11,7FF8A7B80A48
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L02
M00_L24:
       mov       r11,7FF8A7B80A40
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L02
M00_L25:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF8A81C6520]
       int       3
M00_L26:
       mov       rcx,282BE400230
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,2
       call      qword ptr [7FF8A7E5C228]
       int       3
M00_L28:
       call      qword ptr [7FF8A82FC810]
       int       3
M00_L29:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rbp,rax
       jmp       near ptr M00_L15
M00_L30:
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,r15
       call      qword ptr [7FF8A82F73D8]
       jmp       near ptr M00_L15
; Total bytes of code 1501
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
       mov       rcx,282D4400220
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
       call      qword ptr [7FF8A7DAE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FF8A81CEF70]
       mov       ecx,2121
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E57798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C37858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF8A7F04D10
       call      qword ptr [7FF8A7E57798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A7C37858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF8A82FC480]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A82F7630]
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
       mov       r8,282BE400038
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
       jmp       qword ptr [7FF8A7C3D920]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 166
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        near ptr M04_L04
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       near ptr M04_L07
       cmp       rdx,40
       jbe       short M04_L02
       cmp       rdx,400
       ja        near ptr M04_L05
       cmp       rdx,100
       jb        short M04_L00
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       xorps     xmm0,xmm0
       movups    [rcx],xmm0
       movups    [rcx+10],xmm0
       movups    [rcx+20],xmm0
       movups    [rcx+30],xmm0
       add       rcx,rax
       sub       rdx,rax
M04_L00:
       mov       rax,rdx
       shr       rax,6
M04_L01:
       xorps     xmm0,xmm0
       movups    [rcx],xmm0
       movups    [rcx+10],xmm0
       movups    [rcx+20],xmm0
       movups    [rcx+30],xmm0
       add       rcx,40
       dec       rax
       jne       short M04_L01
       and       rdx,3F
       cmp       rdx,10
       jbe       short M04_L03
M04_L02:
       xorps     xmm0,xmm0
       movups    [rcx],xmm0
       cmp       rdx,20
       jbe       short M04_L03
       xorps     xmm0,xmm0
       movups    [rcx+10],xmm0
       cmp       rdx,30
       ja        short M04_L06
M04_L03:
       xorps     xmm0,xmm0
       movups    [rbx-10],xmm0
M04_L04:
       pop       rbx
       ret
M04_L05:
       cmp       [rcx],cl
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       pop       rbx
       jmp       qword ptr [rax]
M04_L06:
       xorps     xmm0,xmm0
       movups    [rcx+20],xmm0
       jmp       short M04_L03
M04_L07:
       test      dl,18
       je        short M04_L08
       xor       edx,edx
       mov       [rcx],rdx
       mov       [rbx-8],rdx
       jmp       short M04_L04
M04_L08:
       test      dl,4
       je        short M04_L09
       xor       edx,edx
       mov       [rcx],edx
       mov       [rbx-4],edx
       jmp       short M04_L04
M04_L09:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M04_L04
       mov       word ptr [rbx-2],0
       jmp       short M04_L04
; Total bytes of code 236
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
       jne       short M05_L01
       xor       ebp,ebp
       xor       r14d,r14d
M05_L00:
       test      rbx,rbx
       jne       near ptr M05_L09
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M05_L10
M05_L01:
       test      rbx,rbx
       jne       short M05_L04
       mov       rcx,7FF8A830A9B4
       call      CORINFO_HELP_COUNTPROFILE32
M05_L02:
       mov       rcx,7FF8A830A9BC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M05_L08
       xor       r14d,r14d
M05_L03:
       mov       rbp,rsi
       jmp       short M05_L00
M05_L04:
       mov       r15,[rsi]
       cmp       r15,[rbx]
       je        short M05_L05
       mov       rcx,7FF8A830A9B0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M05_L02
M05_L05:
       cmp       dword ptr [r15+4],18
       je        short M05_L06
       mov       rcx,7FF8A830A9AC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M05_L02
M05_L06:
       cmp       edi,[rsi+8]
       jbe       short M05_L07
       mov       rcx,7FF8A830A9A8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M05_L02
M05_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M05_L13
       mov       rcx,7FF8A830A9A4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M05_L02
M05_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M05_L03
M05_L09:
       mov       rcx,7FF8A830A9C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M05_L12
       xor       r15d,r15d
M05_L10:
       mov       rcx,7FF8A830A9C4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FF8A8266628]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M05_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L12:
       movsxd    rcx,ecx
       mov       r15d,[rbx+rcx*4+10]
       jmp       short M05_L10
M05_L13:
       mov       edi,edi
       movzx     ebp,word ptr [r15]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [r15],1000000
       je        short M05_L15
       mov       rcx,7FF8A830A9A0
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M05_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF90782A2B0
       cmp       dword ptr [7FF907B64A90],0
       je        short M05_L11
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L11
M05_L14:
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
       jmp       qword ptr [7FF8A81CE910]
M05_L15:
       mov       rcx,7FF8A830A9B8
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       jne       short M05_L16
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       near ptr M05_L11
M05_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF8A7C35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M05_L11
; Total bytes of code 488
```
```assembly
; DotNetTips.Spargine.Core.Logging.LoggingHelper+<>c.<RetrieveAllExceptionMessages>b__9_0(System.Exception)
; 		var messages = exceptions.Select(static ex => ex.Message).ToList();
; 		                                              ^^^^^^^^^^
       mov       rcx,rdx
       mov       rax,offset MT_System.ArgumentNullException
       cmp       [rcx],rax
       je        short M06_L00
       mov       rax,[rcx]
       mov       rax,[rax+40]
       jmp       qword ptr [rax+20]
M06_L00:
       jmp       qword ptr [7FF8A7C7D2A0]; System.ArgumentException.get_Message()
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
       je        short M07_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FF8A82F5BF0]
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
       mov       rdx,282BE400A10
       mov       rdx,[rdx]
       mov       rdx,[rdx+8]
       movsxd    r8,eax
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       movzx     r10d,byte ptr [rdx+10]
       shrx      r8,r8,r10
       xor       r10d,r10d
M08_L00:
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
       jne       short M08_L01
       mov       rbp,rcx
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M08_L01
       mov       rbp,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M08_L02
       mov       rcx,7FF8A831D310
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
M08_L01:
       test      r11d,r11d
       je        short M08_L02
       inc       r10d
       add       r8d,r10d
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r8d,r9d
       cmp       r10d,8
       jl        near ptr M08_L00
M08_L02:
       mov       rcx,7FF8A831D314
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
       jmp       qword ptr [7FF8A7DAFFA8]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 274
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M09_L00
       ret
M09_L00:
       jmp       qword ptr [7FF8A7C35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,26791400DB0
       mov       [rsi+10],rcx
       mov       dword ptr [rsi+6C],80070216
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,80131500E0434352
       mov       [rdi+68],rcx
       mov       rcx,26791400DD8
       mov       [rdi+10],rcx
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+6C],80004003
       mov       rcx,offset MT_System.Collections.Generic.List<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,22712400210
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
       call      qword ptr [7FF8A7D8E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rbx,[rbx+88]
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
; Total bytes of code 301
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M01_L01
       mov       r14d,4
M01_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M01_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF8A81A6520]
       int       3
M01_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M01_L00
M01_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M01_L08
       test      r14d,r14d
       jg        short M01_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M01_L04
M01_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L08
M01_L04:
       mov       rdx,7FF8A8304380
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L03
M01_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+58]
       test      rax,rax
       je        short M01_L09
       mov       rcx,rax
M01_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M01_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FF8A7C17048]; System.Array.Copy(System.Array, System.Array, Int32)
M01_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       mov       rdx,7FF8A82C2330
       call      qword ptr [7FF8A7C1C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L06
; Total bytes of code 303
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
       jmp       qword ptr [7FF8A7C1D908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M02_L00:
       call      qword ptr [7FF8A824FC48]
       int       3
M02_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF9078A3EE0
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
```

