## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.Net.Http.HttpClientHelperBenchmark.CreateOptimizedHttpClientDefaultOptions()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       xor       ecx,ecx
       call      qword ptr [7FFCDE67E598]; DotNetTips.Spargine.Net.Http.HttpClientHelper.CreateOptimizedHttpClient(DotNetTips.Spargine.Net.Http.HttpClientOptions)
       mov       rcx,rax
       mov       [rbp-20],rcx
       mov       rax,[rcx+40]
       mov       [rbp-18],rax
       mov       rax,[rbx+60]
       cmp       [rax],al
       lea       rcx,[rbp-18]
       call      qword ptr [7FFCDE704018]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.TimeSpan, System.Private.CoreLib]](System.TimeSpan ByRef)
       nop
       call      M00_L00
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L00:
       sub       rsp,28
       mov       rcx,[rbp-20]
       test      rcx,rcx
       je        near ptr M00_L07
       mov       rax,offset MT_System.Net.Http.HttpClient
       cmp       [rcx],rax
       jne       near ptr M00_L08
       cmp       byte ptr [rcx+13],0
       jne       near ptr M00_L05
       mov       byte ptr [rcx+13],1
       mov       rbx,[rcx+18]
       cmp       byte ptr [rbx+24],0
       je        short M00_L01
       mov       ecx,46
       call      qword ptr [7FFCDE70DED8]
       int       3
M00_L01:
       cmp       dword ptr [rbx+20],0
       jne       short M00_L04
       lea       r11,[rbx+20]
       mov       edx,1
       xor       eax,eax
       lock cmpxchg [r11],edx
       test      eax,eax
       jne       short M00_L04
       mov       r11,[rbx+8]
       test      r11,r11
       je        short M00_L02
       xor       eax,eax
       mov       [rbx+8],rax
       mov       rcx,r11
       mov       r11,7FFCDDF70A88
       call      qword ptr [r11]
M00_L02:
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M00_L03
       mov       rcx,rax
       call      qword ptr [7FFCDE70DEF0]
M00_L03:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCDE704090]; System.Threading.CancellationTokenSource.ExecuteCallbackHandlers(Boolean)
M00_L04:
       mov       rcx,[rbp-20]
       mov       rbx,[rcx+18]
       mov       rcx,rbx
       mov       edx,1
       mov       rsi,[rbx]
       mov       rax,[rsi+40]
       call      qword ptr [rax+28]
       test      dword ptr [rsi],100000
       je        short M00_L05
       mov       rcx,rbx
       call      00007FFD3DC617C0
M00_L05:
       mov       rcx,[rbp-20]
       cmp       byte ptr [rcx+10],0
       jne       short M00_L06
       mov       byte ptr [rcx+10],1
       cmp       byte ptr [rcx+11],0
       je        short M00_L06
       mov       rbx,[rcx+8]
       mov       rcx,rbx
       mov       edx,1
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,[rbx]
       test      dword ptr [rcx],100000
       je        short M00_L06
       mov       rcx,rbx
       call      00007FFD3DC617C0
M00_L06:
       mov       rcx,[rbp-20]
       mov       rax,[rcx]
       test      dword ptr [rax],100000
       je        short M00_L07
       call      00007FFD3DC617C0
M00_L07:
       nop
       add       rsp,28
       ret
M00_L08:
       mov       r11,7FFCDDF70A80
       call      qword ptr [r11]
       jmp       short M00_L07
; Total bytes of code 371
```
```assembly
; DotNetTips.Spargine.Net.Http.HttpClientHelper.CreateOptimizedHttpClient(DotNetTips.Spargine.Net.Http.HttpClientOptions)
; 		options ??= _defaultHttpClientOptions;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var handler = new SocketsHttpHandler()
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		{
; 		 
; 			MaxConnectionsPerServer = options.MaxConnectionsPerServer,
; 			                                                          
; 			KeepAlivePingPolicy = options.KeepAlivePingPolicy,
; 			                                                  
; 			KeepAlivePingTimeout = options.KeepAlivePingTimeout,
; 			                                                    
; 			PooledConnectionLifetime = options.PooledConnectionLifetime,
; 			                                                            
; 			PooledConnectionIdleTimeout = options.PooledConnectionIdleTimeout,
; 			                                                                  
; 			UseCookies = options.UseCookies,
; 			                                
; 			UseProxy = options.UseProxy,
; 			                            
; 			AllowAutoRedirect = options.AllowAutoRedirect,
; 			                                              
; 			MaxAutomaticRedirections = options.MaxAutomaticRedirections,
; 			                                                            
; 		};
; 		  
; 		var client = new HttpClient(handler, disposeHandler: true)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		{
; 		 
; 			Timeout = options.Timeout,
; 			                          
; 		};
; 		  
; 		_ = client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", options.UserAgent);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		client.DefaultRequestHeaders.AcceptEncoding.Add(_deflateEncoding);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return client;
; 		^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       mov       rbx,rcx
       mov       rcx,19B61C00198
       test      rbx,rbx
       cmove     rbx,[rcx]
       mov       rcx,offset MT_System.Net.Http.SocketsHttpHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Net.Http.HttpConnectionSettings
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFCDE67ED48]; System.Net.Http.HttpConnectionSettings..ctor()
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,19B61C00200
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       je        near ptr M01_L06
       mov       rcx,rsi
       call      qword ptr [7FFCDE1F6670]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M01_L00
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       near ptr M01_L24
M01_L00:
       mov       rcx,rax
       call      qword ptr [7FFCDE1F5B78]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rdi,[rax+18]
       test      rdi,rdi
       je        near ptr M01_L25
M01_L02:
       mov       rcx,rsi
       call      00007FFD3DC3FEC0
       mov       ecx,eax
       test      ecx,ecx
       je        near ptr M01_L26
M01_L03:
       call      qword ptr [7FFCDE2C76A8]; System.Number.Int32ToDecStr(Int32)
       mov       rbp,rax
       test      rdi,rdi
       je        short M01_L04
       cmp       dword ptr [rdi+8],0
       jne       near ptr M01_L27
M01_L04:
       mov       rdx,rbp
       mov       rcx,1DBE0BB3288
       call      qword ptr [7FFCDE02D9C8]; System.String.Concat(System.String, System.String)
       mov       r14,rax
M01_L05:
       mov       rcx,19B61C00200
       mov       rcx,[rcx]
       mov       r8,1DBE0BA0008
       mov       [rsp+20],r8
       mov       r8,r14
       mov       edx,1
       mov       r9,1DBE0BAD470
       call      qword ptr [7FFCDE70EBC8]
M01_L06:
       mov       edi,[rbx+18]
       test      edi,edi
       jle       near ptr M01_L80
       cmp       byte ptr [rsi+28],0
       jne       near ptr M01_L84
       cmp       qword ptr [rsi+10],0
       jne       near ptr M01_L81
       mov       rdx,[rsi+8]
       mov       [rdx+8C],edi
       mov       ecx,[rbx+10]
       mov       [rdx+98],ecx
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FFCDE67E7D8]; System.Net.Http.SocketsHttpHandler.set_KeepAlivePingTimeout(System.TimeSpan)
       mov       rdx,[rbx+30]
       mov       rcx,rsi
       call      qword ptr [7FFCDE67E808]; System.Net.Http.SocketsHttpHandler.set_PooledConnectionLifetime(System.TimeSpan)
       mov       rdx,[rbx+28]
       mov       rcx,rsi
       call      qword ptr [7FFCDE67E838]; System.Net.Http.SocketsHttpHandler.set_PooledConnectionIdleTimeout(System.TimeSpan)
       movzx     ecx,byte ptr [rbx+1D]
       cmp       byte ptr [rsi+28],0
       jne       near ptr M01_L84
       cmp       qword ptr [rsi+10],0
       jne       near ptr M01_L82
       mov       rax,[rsi+8]
       mov       [rax+0A4],cl
       movzx     ecx,byte ptr [rbx+1E]
       mov       [rax+0A5],cl
       movzx     ecx,byte ptr [rbx+1C]
       mov       [rax+0A9],cl
       mov       edi,[rbx+14]
       test      edi,edi
       jle       near ptr M01_L83
       mov       [rax+88],edi
       mov       rcx,offset MT_System.Net.Http.HttpClient
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFCDE67E910]; System.Net.Http.HttpClient..ctor(System.Net.Http.HttpMessageHandler, Boolean)
       mov       rdx,[rbx+38]
       mov       rcx,rdi
       call      qword ptr [7FFCDE67E940]; System.Net.Http.HttpClient.set_Timeout(System.TimeSpan)
       mov       rsi,[rdi+20]
       test      rsi,rsi
       je        near ptr M01_L30
M01_L07:
       mov       rbp,rsi
       mov       rbx,[rbx+8]
       cmp       [rbp],bpl
       mov       rcx,1DBE0BB079C
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+30],0A
       lea       rcx,[rsp+28]
       call      qword ptr [7FFCDE67F210]; System.Net.Http.Headers.KnownHeaders.GetCandidate[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L86
       mov       rdx,[r14+8]
       mov       rcx,1DBE0BB0790
       cmp       rdx,rcx
       jne       near ptr M01_L85
M01_L08:
       test      r14,r14
       je        near ptr M01_L88
       mov       [rsp+48],r14
M01_L09:
       mov       rcx,[rsp+48]
       test      rcx,rcx
       jne       near ptr M01_L31
M01_L10:
       mov       ecx,10
M01_L11:
       movzx     eax,byte ptr [rbp+14]
       test      eax,ecx
       jne       short M01_L12
       movzx     eax,byte ptr [rbp+15]
       test      eax,ecx
       je        near ptr M01_L15
       lea       rcx,[rsp+48]
       call      qword ptr [7FFCDE70EBE0]
       mov       [rsp+48],rax
M01_L12:
       mov       rcx,[rsp+48]
       mov       rdx,1DBE0BA0008
       test      rbx,rbx
       cmove     rbx,rdx
       mov       [rsp+40],rcx
       mov       rcx,[rbp+8]
       mov       r14,rcx
       test      r14,r14
       je        short M01_L13
       mov       rdx,offset MT_System.Net.Http.Headers.HeaderEntry[]
       cmp       [r14],rdx
       je        short M01_L13
       xor       r14d,r14d
M01_L13:
       test      r14,r14
       jne       near ptr M01_L90
       test      rcx,rcx
       jne       near ptr M01_L96
       inc       dword ptr [rsi+10]
       mov       rcx,offset MT_System.Net.Http.Headers.HeaderEntry[]
       mov       edx,4
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,10
       lea       rcx,[r14+8]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
M01_L14:
       mov       rsi,[r14]
       test      rsi,rsi
       jne       near ptr M01_L97
       mov       rcx,r14
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L15:
       mov       rbx,[rdi+20]
       test      rbx,rbx
       je        near ptr M01_L32
M01_L16:
       cmp       [rbx],bl
       mov       rcx,19B61C00768
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L99
M01_L17:
       cmp       qword ptr [rbx+18],0
       jne       short M01_L18
       mov       rcx,offset MT_System.Object[]
       mov       edx,0A
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L18:
       mov       rbp,[rbx+18]
       cmp       dword ptr [rbp+8],2
       jbe       near ptr M01_L109
       mov       rdx,[rbp+20]
       test      rdx,rdx
       jne       short M01_L20
       mov       rcx,offset System.Net.Http.Headers.HttpRequestHeaders+<>c.<get_AcceptEncoding>b__20_0(System.Net.Http.Headers.HttpRequestHeaders)
       cmp       [rsi+18],rcx
       jne       near ptr M01_L100
       mov       rcx,19B61C002F8
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.StringWithQualityHeaderValue>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L19:
       mov       rcx,rbp
       mov       r8,r14
       mov       edx,2
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rdx,r14
M01_L20:
       mov       rbx,rdx
       test      rbx,rbx
       je        short M01_L21
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.StringWithQualityHeaderValue>
       cmp       [rbx],rcx
       jne       near ptr M01_L101
M01_L21:
       mov       rdx,19B61C001A8
       mov       rsi,[rdx]
       cmp       [rbx],bl
       mov       rdx,[rbx+10]
       test      rdx,rdx
       jne       near ptr M01_L33
M01_L22:
       xor       edx,edx
M01_L23:
       test      rdx,rdx
       je        near ptr M01_L34
       mov       rdx,[rdx+10]
       mov       rcx,19B61C00620
       cmp       rdx,[rcx]
       jne       near ptr M01_L34
       mov       rdx,rsi
       mov       rcx,offset MT_System.String
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L24:
       mov       rax,rcx
       jmp       near ptr M01_L01
M01_L25:
       lea       rdx,[rax+18]
       mov       rcx,rax
       xor       r8d,r8d
       call      qword ptr [7FFCDE1FD0F8]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdi,rax
       jmp       near ptr M01_L02
M01_L26:
       mov       rcx,rsi
       call      qword ptr [7FFCDE1F7C90]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       ecx,eax
       jmp       near ptr M01_L03
M01_L27:
       test      rbp,rbp
       je        short M01_L29
       cmp       dword ptr [rbp+8],0
       je        short M01_L29
       mov       ecx,[rdi+8]
       mov       eax,[rbp+8]
       lea       rcx,[rcx+rax+1]
       cmp       rcx,7FFFFFFF
       jg        short M01_L28
       movsxd    rcx,ecx
       call      qword ptr [7FFCDE026670]; System.String.FastAllocateString(IntPtr)
       mov       r14,rax
       cmp       [r14],r14b
       lea       r15,[r14+0C]
       mov       rcx,r15
       mov       r8d,[rdi+8]
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFCDE025818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rdi+8]
       lea       rdx,[r15+rdx*2]
       mov       word ptr [rdx],23
       mov       edx,[rdi+8]
       inc       edx
       mov       rcx,r14
       mov       r8,rbp
       call      qword ptr [7FFCDE70EBB0]
       jmp       near ptr M01_L05
M01_L28:
       call      qword ptr [7FFCDE2CEBC8]
       int       3
M01_L29:
       mov       rcx,rdi
       mov       rdx,1DBE0BB3288
       call      qword ptr [7FFCDE02D9C8]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L30:
       mov       rcx,offset MT_System.Net.Http.Headers.HttpRequestHeaders
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       word ptr [rsi+14],413
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L07
M01_L31:
       mov       rax,offset MT_System.Net.Http.Headers.KnownHeader
       cmp       [rcx],rax
       jne       near ptr M01_L10
       movzx     ecx,byte ptr [rcx+38]
       jmp       near ptr M01_L11
M01_L32:
       mov       rcx,offset MT_System.Net.Http.Headers.HttpRequestHeaders
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       word ptr [rbx+14],413
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L16
M01_L33:
       mov       rcx,offset MT_System.Net.Http.Headers.KnownHeader
       cmp       [rdx],rcx
       jne       near ptr M01_L22
       jmp       near ptr M01_L23
M01_L34:
       mov       rbp,[rbx+8]
       mov       rbx,[rbx+10]
       xor       r14d,r14d
       mov       rdx,[rbp+8]
       mov       r15,rdx
       test      r15,r15
       je        short M01_L35
       mov       rcx,offset MT_System.Net.Http.Headers.HeaderEntry[]
       cmp       [r15],rcx
       je        short M01_L35
       xor       r15d,r15d
M01_L35:
       test      r15,r15
       jne       near ptr M01_L41
       test      rdx,rdx
       je        short M01_L37
       mov       rcx,rdx
       test      rcx,rcx
       je        short M01_L36
       mov       rax,offset MT_System.Collections.Generic.Dictionary<System.Net.Http.Headers.HeaderDescriptor, System.Object>
       cmp       [rcx],rax
       je        short M01_L36
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rcx,rax
M01_L36:
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE70DC68]
       mov       r14,rax
M01_L37:
       test      r14,r14
       je        near ptr M01_L48
       mov       r15,[r14]
       test      r15,r15
       jne       near ptr M01_L53
M01_L38:
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,r15
       call      00007FFD3DC49BA0
       cmp       rax,r15
       jne       near ptr M01_L103
       mov       r15,rbp
M01_L39:
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [7FFCDE67FFA8]; System.Net.Http.Headers.HttpHeaders.ParseRawHeaderValues(System.Net.Http.Headers.HeaderDescriptor, HeaderStoreItemInfo)
M01_L40:
       add       r15,10
       cmp       qword ptr [r15],0
       jne       near ptr M01_L54
       mov       rcx,r15
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L58
M01_L41:
       xor       r13d,r13d
       cmp       dword ptr [rbp+10],0
       jle       short M01_L37
M01_L42:
       cmp       [r15+8],r13d
       jle       near ptr M01_L37
       cmp       r13d,[r15+8]
       jae       near ptr M01_L109
       mov       rcx,r13
       shl       rcx,4
       mov       rdx,[r15+rcx+18]
       test      rbx,rbx
       je        short M01_L46
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       short M01_L46
       test      rdx,rdx
       jne       near ptr M01_L102
M01_L43:
       xor       edx,edx
M01_L44:
       mov       rcx,rbx
       mov       r8d,5
       call      qword ptr [7FFCDE1FD128]; System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       je        short M01_L47
M01_L45:
       mov       ecx,r13d
       cmp       ecx,[r15+8]
       jae       near ptr M01_L109
       shl       rcx,4
       lea       r14,[r15+rcx+10]
       jmp       near ptr M01_L37
M01_L46:
       cmp       rbx,rdx
       je        short M01_L45
M01_L47:
       inc       r13d
       cmp       r13d,[rbp+10]
       jge       near ptr M01_L37
       jmp       near ptr M01_L42
M01_L48:
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rax,[rbp+8]
       test      rax,rax
       je        short M01_L49
       mov       rcx,offset MT_System.Net.Http.Headers.HeaderEntry[]
       cmp       [rax],rcx
       je        short M01_L49
       xor       eax,eax
M01_L49:
       test      rax,rax
       je        short M01_L50
       mov       r14d,[rbp+10]
       cmp       [rax+8],r14d
       ja        short M01_L52
M01_L50:
       mov       rcx,rbp
       mov       rdx,rbx
       call      qword ptr [7FFCDE67FE10]; System.Net.Http.Headers.HttpHeaders.GetValueRefOrAddDefault(System.Net.Http.Headers.HeaderDescriptor)
       mov       rcx,rax
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L51:
       jmp       near ptr M01_L40
M01_L52:
       cmp       r14d,[rax+8]
       jae       near ptr M01_L109
       mov       ecx,r14d
       shl       rcx,4
       lea       r14,[rax+rcx+10]
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+10]
       jmp       short M01_L51
M01_L53:
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       cmp       [r15],rcx
       jne       near ptr M01_L38
       jmp       near ptr M01_L39
M01_L54:
       mov       rdx,[r15]
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbx,rax
       test      rbx,rbx
       jne       near ptr M01_L57
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Object[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r15]
       mov       r8,rdx
       test      r8,r8
       je        short M01_L55
       mov       rcx,offset MT_System.Object
       cmp       [r8],rcx
       je        short M01_L55
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M01_L55:
       inc       dword ptr [rbx+14]
       mov       rcx,[rbx+8]
       mov       edx,[rbx+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L104
       lea       eax,[rdx+1]
       mov       [rbx+10],eax
       movsxd    rdx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M01_L56:
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L57:
       inc       dword ptr [rbx+14]
       mov       rcx,[rbx+8]
       mov       edx,[rbx+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L105
       lea       r8d,[rdx+1]
       mov       [rbx+10],r8d
       movsxd    rdx,edx
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M01_L58:
       mov       rcx,[rdi+20]
       test      rcx,rcx
       je        short M01_L62
M01_L59:
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE67E9A0]; System.Net.Http.Headers.HttpRequestHeaders.get_AcceptEncoding()
       mov       rdx,19B61C001A0
       mov       rbx,[rdx]
       cmp       [rax],al
       mov       rdx,[rax+10]
       test      rdx,rdx
       jne       short M01_L63
M01_L60:
       xor       edx,edx
M01_L61:
       test      rdx,rdx
       je        short M01_L64
       mov       rdx,[rdx+10]
       mov       rcx,19B61C00620
       cmp       rdx,[rcx]
       jne       short M01_L64
       mov       rdx,rbx
       mov       rcx,offset MT_System.String
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L62:
       mov       rcx,offset MT_System.Net.Http.Headers.HttpRequestHeaders
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       word ptr [rbx+14],413
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       jmp       short M01_L59
M01_L63:
       mov       rcx,offset MT_System.Net.Http.Headers.KnownHeader
       cmp       [rdx],rcx
       jne       short M01_L60
       jmp       short M01_L61
M01_L64:
       mov       rsi,[rax+8]
       mov       rbp,[rax+10]
       cmp       [rsi],sil
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFCDE67FF30]; System.Net.Http.Headers.HttpHeaders.GetValueRefOrNullRef(System.Net.Http.Headers.HeaderDescriptor)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L69
       xor       ecx,ecx
       mov       [rsp+38],rcx
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rax,[rsi+8]
       test      rax,rax
       je        short M01_L65
       mov       rcx,offset MT_System.Net.Http.Headers.HeaderEntry[]
       cmp       [rax],rcx
       je        short M01_L65
       xor       eax,eax
M01_L65:
       test      rax,rax
       je        short M01_L66
       mov       r14d,[rsi+10]
       cmp       [rax+8],r14d
       ja        short M01_L68
M01_L66:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFCDE67FE10]; System.Net.Http.Headers.HttpHeaders.GetValueRefOrAddDefault(System.Net.Http.Headers.HeaderDescriptor)
       mov       rcx,rax
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L67:
       jmp       near ptr M01_L74
M01_L68:
       cmp       r14d,[rax+8]
       jae       near ptr M01_L109
       mov       ecx,r14d
       shl       rcx,4
       lea       r14,[rax+rcx+10]
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+10]
       jmp       short M01_L67
M01_L69:
       mov       r15,[r14]
       test      r15,r15
       je        short M01_L70
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       cmp       [r15],rcx
       jne       short M01_L70
       mov       rsi,r15
       jmp       short M01_L71
M01_L70:
       xor       esi,esi
M01_L71:
       test      rsi,rsi
       je        short M01_L72
       jmp       short M01_L73
M01_L72:
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,r15
       call      00007FFD3DC49BA0
       cmp       rax,r15
       jne       near ptr M01_L106
M01_L73:
       mov       [rsp+38],rsi
       mov       rcx,rbp
       mov       rdx,[rsp+38]
       call      qword ptr [7FFCDE67FFA8]; System.Net.Http.Headers.HttpHeaders.ParseRawHeaderValues(System.Net.Http.Headers.HeaderDescriptor, HeaderStoreItemInfo)
       mov       r15,[rsp+38]
M01_L74:
       xor       edx,edx
       mov       [rsp+38],rdx
       add       r15,10
       cmp       qword ptr [r15],0
       je        near ptr M01_L78
       mov       rdx,[r15]
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M01_L77
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Object[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r15]
       mov       r8,rdx
       test      r8,r8
       je        short M01_L75
       mov       rcx,offset MT_System.Object
       cmp       [r8],rcx
       je        short M01_L75
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M01_L75:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L107
       lea       eax,[rdx+1]
       mov       [rsi+10],eax
       movsxd    rdx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M01_L76:
       mov       rcx,r15
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L77:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L108
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       movsxd    rdx,edx
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M01_L79
M01_L78:
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L79:
       mov       rax,rdi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L80:
       mov       ecx,1F09
       mov       rdx,7FFCDE3721C0
       call      qword ptr [7FFCDE02F228]
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFCDE70D728]
       int       3
M01_L81:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCDE70DAB8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDE3E7B70]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L82:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCDE70DAB8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDE3E7B70]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L83:
       mov       ecx,1F09
       mov       rdx,7FFCDE3721C0
       call      qword ptr [7FFCDE02F228]
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFCDE70D728]
       int       3
M01_L84:
       mov       rcx,rsi
       call      qword ptr [7FFCDE70D3E0]
       int       3
M01_L85:
       test      rdx,rdx
       jne       short M01_L87
M01_L86:
       xor       r14d,r14d
       jmp       near ptr M01_L08
M01_L87:
       cmp       dword ptr [rdx+8],0A
       jne       short M01_L86
       mov       rcx,1DBE0BB079C
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFCDE70D1E8]
       test      eax,eax
       je        short M01_L86
       jmp       near ptr M01_L08
M01_L88:
       mov       rcx,1DBE0BB079C
       mov       r8,19B61C001C0
       mov       r8,[r8]
       add       r8,8
       mov       edx,0A
       call      qword ptr [7FFCDE67EAF0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       je        short M01_L89
       xor       ecx,ecx
       mov       [rsp+48],rcx
       jmp       near ptr M01_L15
M01_L89:
       mov       rcx,1DBE0BB0790
       mov       [rsp+48],rcx
       jmp       near ptr M01_L09
M01_L90:
       xor       esi,esi
       jmp       short M01_L92
M01_L91:
       mov       edx,esi
       shl       rdx,4
       mov       rdx,[r14+rdx+18]
       lea       rcx,[rsp+40]
       call      qword ptr [7FFCDE70EBF8]
       test      eax,eax
       jne       short M01_L93
       inc       esi
M01_L92:
       cmp       esi,[rbp+10]
       jge       short M01_L94
       cmp       [r14+8],esi
       jg        short M01_L91
       jmp       short M01_L94
M01_L93:
       mov       ecx,esi
       shl       rcx,4
       lea       r14,[r14+rcx+10]
       jmp       near ptr M01_L14
M01_L94:
       mov       esi,[rbp+10]
       inc       dword ptr [rbp+10]
       cmp       [r14+8],esi
       jbe       short M01_L95
       mov       ecx,esi
       shl       rcx,4
       lea       rcx,[r14+rcx+18]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,esi
       shl       rcx,4
       lea       r14,[r14+rcx+10]
       jmp       near ptr M01_L14
M01_L95:
       mov       rcx,rbp
       mov       rdx,[rsp+40]
       call      qword ptr [7FFCDE70DE18]
       mov       r14,rax
       jmp       near ptr M01_L14
M01_L96:
       mov       rcx,rsi
       mov       rdx,[rsp+40]
       call      qword ptr [7FFCDE70DE30]
       mov       r14,rax
       jmp       near ptr M01_L14
M01_L97:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       short M01_L98
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L98:
       cmp       [rbp],bpl
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,7FFCDE6F8C20
       call      qword ptr [7FFCDE67FDE0]; System.Net.Http.Headers.HttpHeaders.AddValueToStoreValue[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Object ByRef)
       jmp       near ptr M01_L15
M01_L99:
       mov       rcx,offset MT_System.Func<System.Net.Http.Headers.HttpRequestHeaders, System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.StringWithQualityHeaderValue>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,19B61C00750
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset System.Net.Http.Headers.HttpRequestHeaders+<>c.<get_AcceptEncoding>b__20_0(System.Net.Http.Headers.HttpRequestHeaders)
       call      qword ptr [7FFCDE026BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,19B61C00768
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L17
M01_L100:
       mov       rdx,rbx
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14,rax
       jmp       near ptr M01_L19
M01_L101:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L102:
       cmp       [rdx],rcx
       jne       near ptr M01_L43
       jmp       near ptr M01_L44
M01_L103:
       mov       rdx,rax
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M01_L39
M01_L104:
       mov       rcx,rbx
       mov       rdx,r8
       call      qword ptr [7FFCDE0271C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L56
M01_L105:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFCDE0271C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L58
M01_L106:
       mov       rdx,rax
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M01_L73
M01_L107:
       mov       rcx,rsi
       mov       rdx,r8
       call      qword ptr [7FFCDE0271C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L76
M01_L108:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCDE0271C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L79
M01_L109:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3641
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.TimeSpan, System.Private.CoreLib]](System.TimeSpan ByRef)
       ret
; Total bytes of code 1
```
```assembly
; System.Threading.CancellationTokenSource.ExecuteCallbackHandlers(Boolean)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-38],xmm4
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       lea       rax,[rcx+18]
       xor       edx,edx
       xchg      rdx,[rax]
       mov       [rbp-28],rdx
       test      rdx,rdx
       jne       short M03_L01
       add       rcx,20
       mov       eax,2
       xchg      eax,[rcx]
M03_L00:
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M03_L01:
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       rdx,[rbp-28]
       mov       [rdx+30],eax
       xor       ecx,ecx
       mov       [rbp-30],rcx
M03_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFCDE70EC28]
       nop
       mov       rcx,[rbp-28]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        short M03_L04
       cmp       qword ptr [rbx+18],0
       je        short M03_L03
       mov       rdx,[rbx+18]
       xor       eax,eax
       mov       [rdx+10],rax
M03_L03:
       mov       rdx,[rbx+18]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+40]
       mov       rsi,[rbp-28]
       mov       [rsi+28],rcx
       xor       ecx,ecx
       mov       [rbx+40],rcx
       mov       byte ptr [rsi+34],0
       jmp       short M03_L05
M03_L04:
       call      M03_L10
       jmp       near ptr M03_L09
M03_L05:
       cmp       qword ptr [rbx+38],0
       je        near ptr M03_L08
       mov       rdi,[rbx+38]
       mov       rcx,offset MT_System.Threading.CancellationTokenSource+<>c
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,19B61C00898
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M03_L07
       mov       rcx,offset MT_System.Threading.SendOrPostCallback
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.CancellationTokenSource+<>c
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,19B61C00888
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M03_L06
       call      qword ptr [7FFCDE5FEAC0]
       int       3
M03_L06:
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFCDE709F50
       mov       [r14+18],rcx
       mov       rcx,offset MT_System.Threading.CancellationTokenSource+<>c
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,19B61C00898
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
M03_L07:
       mov       rcx,rdi
       mov       r8,rbx
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+30],eax
       jmp       near ptr M03_L02
M03_L08:
       mov       rcx,rbx
       call      qword ptr [7FFCDE70DF98]
       jmp       near ptr M03_L02
M03_L09:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+20],2
       mov       rcx,[rbp-28]
       add       rcx,28
       xor       eax,eax
       xchg      rax,[rcx]
       cmp       qword ptr [rbp-30],0
       je        near ptr M03_L00
       mov       rcx,offset MT_System.AggregateException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,[rbp-30]
       call      qword ptr [7FFCDE70DFB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L10:
       sub       rsp,28
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+34],0
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,offset MT_System.Exception
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M03_L11
       xor       eax,eax
       jmp       short M03_L12
M03_L11:
       mov       [rbp-38],rax
       cmp       byte ptr [rbp+18],0
       sete      al
       movzx     eax,al
M03_L12:
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,[rbp-30]
       cmp       qword ptr [rbp-30],0
       jne       short M03_L13
       mov       rcx,offset MT_System.Collections.Generic.List<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDE3EC258]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       [rbp-30],rbx
       mov       rcx,rbx
M03_L13:
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [r8+8],edx
       jbe       short M03_L14
       lea       eax,[rdx+1]
       mov       [rcx+10],eax
       mov       rcx,r8
       mov       r8,[rbp-38]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M03_L15
M03_L14:
       mov       rdx,[rbp-38]
       call      qword ptr [7FFCDE0271C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L15:
       lea       rax,[M03_L02]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+20],2
       mov       rcx,[rbp-28]
       add       rcx,28
       xor       eax,eax
       xchg      rax,[rcx]
       add       rsp,28
       ret
; Total bytes of code 673
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.Net.Http.HttpClientHelperBenchmark.CreateOptimizedHttpClientCustomOptions()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+138]
       call      qword ptr [7FFCDE67D8F0]; DotNetTips.Spargine.Net.Http.HttpClientHelper.CreateOptimizedHttpClient(DotNetTips.Spargine.Net.Http.HttpClientOptions)
       mov       rcx,rax
       mov       [rbp-20],rcx
       mov       rax,[rcx+40]
       mov       [rbp-18],rax
       mov       rax,[rbx+60]
       cmp       [rax],al
       lea       rcx,[rbp-18]
       call      qword ptr [7FFCDE67F360]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.TimeSpan, System.Private.CoreLib]](System.TimeSpan ByRef)
       nop
       call      M00_L00
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L00:
       sub       rsp,28
       mov       rcx,[rbp-20]
       test      rcx,rcx
       je        near ptr M00_L07
       mov       rax,offset MT_System.Net.Http.HttpClient
       cmp       [rcx],rax
       jne       near ptr M00_L08
       cmp       byte ptr [rcx+13],0
       jne       near ptr M00_L05
       mov       byte ptr [rcx+13],1
       mov       rbx,[rcx+18]
       cmp       byte ptr [rbx+24],0
       je        short M00_L01
       mov       ecx,46
       call      qword ptr [7FFCDE706E68]
       int       3
M00_L01:
       cmp       dword ptr [rbx+20],0
       jne       short M00_L04
       lea       r11,[rbx+20]
       mov       edx,1
       xor       eax,eax
       lock cmpxchg [r11],edx
       test      eax,eax
       jne       short M00_L04
       mov       r11,[rbx+8]
       test      r11,r11
       je        short M00_L02
       xor       eax,eax
       mov       [rbx+8],rax
       mov       rcx,r11
       mov       r11,7FFCDDF80A08
       call      qword ptr [r11]
M00_L02:
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M00_L03
       mov       rcx,rax
       call      qword ptr [7FFCDE706E80]
M00_L03:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFCDE67F3D8]; System.Threading.CancellationTokenSource.ExecuteCallbackHandlers(Boolean)
M00_L04:
       mov       rcx,[rbp-20]
       mov       rbx,[rcx+18]
       mov       rcx,rbx
       mov       edx,1
       mov       rsi,[rbx]
       mov       rax,[rsi+40]
       call      qword ptr [rax+28]
       test      dword ptr [rsi],100000
       je        short M00_L05
       mov       rcx,rbx
       call      00007FFD3DC617C0
M00_L05:
       mov       rcx,[rbp-20]
       cmp       byte ptr [rcx+10],0
       jne       short M00_L06
       mov       byte ptr [rcx+10],1
       cmp       byte ptr [rcx+11],0
       je        short M00_L06
       mov       rbx,[rcx+8]
       mov       rcx,rbx
       mov       edx,1
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,[rbx]
       test      dword ptr [rcx],100000
       je        short M00_L06
       mov       rcx,rbx
       call      00007FFD3DC617C0
M00_L06:
       mov       rcx,[rbp-20]
       mov       rax,[rcx]
       test      dword ptr [rax],100000
       je        short M00_L07
       call      00007FFD3DC617C0
M00_L07:
       nop
       add       rsp,28
       ret
M00_L08:
       mov       r11,7FFCDDF80A00
       call      qword ptr [r11]
       jmp       short M00_L07
; Total bytes of code 376
```
```assembly
; DotNetTips.Spargine.Net.Http.HttpClientHelper.CreateOptimizedHttpClient(DotNetTips.Spargine.Net.Http.HttpClientOptions)
; 		options ??= _defaultHttpClientOptions;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var handler = new SocketsHttpHandler()
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		{
; 		 
; 			MaxConnectionsPerServer = options.MaxConnectionsPerServer,
; 			                                                          
; 			KeepAlivePingPolicy = options.KeepAlivePingPolicy,
; 			                                                  
; 			KeepAlivePingTimeout = options.KeepAlivePingTimeout,
; 			                                                    
; 			PooledConnectionLifetime = options.PooledConnectionLifetime,
; 			                                                            
; 			PooledConnectionIdleTimeout = options.PooledConnectionIdleTimeout,
; 			                                                                  
; 			UseCookies = options.UseCookies,
; 			                                
; 			UseProxy = options.UseProxy,
; 			                            
; 			AllowAutoRedirect = options.AllowAutoRedirect,
; 			                                              
; 			MaxAutomaticRedirections = options.MaxAutomaticRedirections,
; 			                                                            
; 		};
; 		  
; 		var client = new HttpClient(handler, disposeHandler: true)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		{
; 		 
; 			Timeout = options.Timeout,
; 			                          
; 		};
; 		  
; 		_ = client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", options.UserAgent);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		client.DefaultRequestHeaders.AcceptEncoding.Add(_deflateEncoding);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return client;
; 		^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       mov       rbx,rcx
       mov       rcx,28BBC000180
       test      rbx,rbx
       cmove     rbx,[rcx]
       mov       rcx,offset MT_System.Net.Http.SocketsHttpHandler
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Net.Http.HttpConnectionSettings
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFCDE67DD28]; System.Net.Http.HttpConnectionSettings..ctor()
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,28BBC000250
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       je        near ptr M01_L06
       mov       rcx,rsi
       call      qword ptr [7FFCDE2061D8]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M01_L00
       mov       rcx,[rax+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       near ptr M01_L24
M01_L00:
       mov       rcx,rax
       call      qword ptr [7FFCDE2056E0]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rdi,[rax+18]
       test      rdi,rdi
       je        near ptr M01_L25
M01_L02:
       mov       rcx,rsi
       call      00007FFD3DC3FEC0
       mov       ecx,eax
       test      ecx,ecx
       je        near ptr M01_L26
M01_L03:
       call      qword ptr [7FFCDE2C7210]; System.Number.Int32ToDecStr(Int32)
       mov       rbp,rax
       test      rdi,rdi
       je        short M01_L04
       cmp       dword ptr [rdi+8],0
       jne       near ptr M01_L27
M01_L04:
       mov       rdx,rbp
       mov       rcx,2CC3B0B3220
       call      qword ptr [7FFCDE03D9C8]; System.String.Concat(System.String, System.String)
       mov       r14,rax
M01_L05:
       mov       rcx,28BBC000250
       mov       rcx,[rcx]
       mov       r8,2CC3B0A0008
       mov       [rsp+20],r8
       mov       r8,r14
       mov       edx,1
       mov       r9,2CC3B0AD470
       call      qword ptr [7FFCDE707D50]
M01_L06:
       mov       edi,[rbx+18]
       test      edi,edi
       jle       near ptr M01_L77
       cmp       byte ptr [rsi+28],0
       jne       near ptr M01_L81
       cmp       qword ptr [rsi+10],0
       jne       near ptr M01_L78
       mov       rdx,[rsi+8]
       mov       [rdx+8C],edi
       mov       ecx,[rbx+10]
       mov       [rdx+98],ecx
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FFCDE67DB30]; System.Net.Http.SocketsHttpHandler.set_KeepAlivePingTimeout(System.TimeSpan)
       mov       rdx,[rbx+30]
       mov       rcx,rsi
       call      qword ptr [7FFCDE67DB60]; System.Net.Http.SocketsHttpHandler.set_PooledConnectionLifetime(System.TimeSpan)
       mov       rdx,[rbx+28]
       mov       rcx,rsi
       call      qword ptr [7FFCDE67DB90]; System.Net.Http.SocketsHttpHandler.set_PooledConnectionIdleTimeout(System.TimeSpan)
       movzx     ecx,byte ptr [rbx+1D]
       cmp       byte ptr [rsi+28],0
       jne       near ptr M01_L81
       cmp       qword ptr [rsi+10],0
       jne       near ptr M01_L79
       mov       rax,[rsi+8]
       mov       [rax+0A4],cl
       movzx     ecx,byte ptr [rbx+1E]
       mov       [rax+0A5],cl
       movzx     ecx,byte ptr [rbx+1C]
       mov       [rax+0A9],cl
       mov       edi,[rbx+14]
       test      edi,edi
       jle       near ptr M01_L80
       mov       [rax+88],edi
       mov       rcx,offset MT_System.Net.Http.HttpClient
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFCDE67DC68]; System.Net.Http.HttpClient..ctor(System.Net.Http.HttpMessageHandler, Boolean)
       mov       rdx,[rbx+38]
       mov       rcx,rdi
       call      qword ptr [7FFCDE67DC98]; System.Net.Http.HttpClient.set_Timeout(System.TimeSpan)
       mov       rsi,[rdi+20]
       test      rsi,rsi
       jne       short M01_L07
       mov       rcx,offset MT_System.Net.Http.Headers.HttpRequestHeaders
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       word ptr [rsi+14],413
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L07:
       mov       rbp,rsi
       mov       rbx,[rbx+8]
       cmp       [rbp],bpl
       mov       rcx,2CC3B0B079C
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+30],0A
       lea       rcx,[rsp+28]
       call      qword ptr [7FFCDE67E1F0]; System.Net.Http.Headers.KnownHeaders.GetCandidate[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L83
       mov       rdx,[r14+8]
       mov       rcx,2CC3B0B0790
       cmp       rdx,rcx
       jne       near ptr M01_L82
M01_L08:
       test      r14,r14
       je        near ptr M01_L85
       mov       [rsp+48],r14
M01_L09:
       mov       rcx,[rsp+48]
       test      rcx,rcx
       jne       near ptr M01_L30
M01_L10:
       mov       ecx,10
M01_L11:
       movzx     eax,byte ptr [rbp+14]
       test      eax,ecx
       jne       short M01_L12
       movzx     eax,byte ptr [rbp+15]
       test      eax,ecx
       je        near ptr M01_L15
       lea       rcx,[rsp+48]
       call      qword ptr [7FFCDE707D68]
       mov       [rsp+48],rax
M01_L12:
       mov       rcx,[rsp+48]
       mov       rdx,2CC3B0A0008
       test      rbx,rbx
       cmove     rbx,rdx
       mov       [rsp+40],rcx
       mov       rcx,[rbp+8]
       mov       r14,rcx
       test      r14,r14
       je        short M01_L13
       mov       rdx,offset MT_System.Net.Http.Headers.HeaderEntry[]
       cmp       [r14],rdx
       je        short M01_L13
       xor       r14d,r14d
M01_L13:
       test      r14,r14
       jne       near ptr M01_L87
       test      rcx,rcx
       jne       near ptr M01_L93
       inc       dword ptr [rsi+10]
       mov       rcx,offset MT_System.Net.Http.Headers.HeaderEntry[]
       mov       edx,4
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,10
       lea       rcx,[r14+8]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
M01_L14:
       mov       rsi,[r14]
       test      rsi,rsi
       jne       near ptr M01_L94
       mov       rcx,r14
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L15:
       mov       rbx,[rdi+20]
       test      rbx,rbx
       jne       short M01_L16
       mov       rcx,offset MT_System.Net.Http.Headers.HttpRequestHeaders
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       word ptr [rbx+14],413
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L16:
       cmp       [rbx],bl
       mov       rcx,28BBC000710
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L96
M01_L17:
       cmp       qword ptr [rbx+18],0
       jne       short M01_L18
       mov       rcx,offset MT_System.Object[]
       mov       edx,0A
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L18:
       mov       rbp,[rbx+18]
       cmp       dword ptr [rbp+8],2
       jbe       near ptr M01_L106
       mov       rdx,[rbp+20]
       test      rdx,rdx
       jne       short M01_L20
       mov       rcx,offset System.Net.Http.Headers.HttpRequestHeaders+<>c.<get_AcceptEncoding>b__20_0(System.Net.Http.Headers.HttpRequestHeaders)
       cmp       [rsi+18],rcx
       jne       near ptr M01_L97
       mov       rcx,28BBC0002A0
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.StringWithQualityHeaderValue>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L19:
       mov       rcx,rbp
       mov       r8,r14
       mov       edx,2
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rdx,r14
M01_L20:
       mov       rbx,rdx
       test      rbx,rbx
       je        short M01_L21
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.StringWithQualityHeaderValue>
       cmp       [rbx],rcx
       jne       near ptr M01_L98
M01_L21:
       mov       rdx,28BBC000190
       mov       rsi,[rdx]
       cmp       [rbx],bl
       mov       rdx,[rbx+10]
       test      rdx,rdx
       jne       near ptr M01_L31
M01_L22:
       xor       edx,edx
M01_L23:
       test      rdx,rdx
       je        near ptr M01_L32
       mov       rdx,[rdx+10]
       mov       rcx,28BBC0005C8
       cmp       rdx,[rcx]
       jne       near ptr M01_L32
       mov       rdx,rsi
       mov       rcx,offset MT_System.String
       call      qword ptr [7FFCDE036328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L24:
       mov       rax,rcx
       jmp       near ptr M01_L01
M01_L25:
       lea       rdx,[rax+18]
       mov       rcx,rax
       xor       r8d,r8d
       call      qword ptr [7FFCDE20CC60]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdi,rax
       jmp       near ptr M01_L02
M01_L26:
       mov       rcx,rsi
       call      qword ptr [7FFCDE2077F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       ecx,eax
       jmp       near ptr M01_L03
M01_L27:
       test      rbp,rbp
       je        short M01_L29
       cmp       dword ptr [rbp+8],0
       je        short M01_L29
       mov       ecx,[rdi+8]
       mov       eax,[rbp+8]
       lea       rcx,[rcx+rax+1]
       cmp       rcx,7FFFFFFF
       jg        short M01_L28
       movsxd    rcx,ecx
       call      qword ptr [7FFCDE036670]; System.String.FastAllocateString(IntPtr)
       mov       r14,rax
       cmp       [r14],r14b
       lea       r15,[r14+0C]
       mov       rcx,r15
       mov       r8d,[rdi+8]
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFCDE035818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rdi+8]
       lea       rdx,[r15+rdx*2]
       mov       word ptr [rdx],23
       mov       edx,[rdi+8]
       inc       edx
       mov       rcx,r14
       mov       r8,rbp
       call      qword ptr [7FFCDE707D38]
       jmp       near ptr M01_L05
M01_L28:
       call      qword ptr [7FFCDE706148]
       int       3
M01_L29:
       mov       rcx,rdi
       mov       rdx,2CC3B0B3220
       call      qword ptr [7FFCDE03D9C8]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L30:
       mov       rax,offset MT_System.Net.Http.Headers.KnownHeader
       cmp       [rcx],rax
       jne       near ptr M01_L10
       movzx     ecx,byte ptr [rcx+38]
       jmp       near ptr M01_L11
M01_L31:
       mov       rcx,offset MT_System.Net.Http.Headers.KnownHeader
       cmp       [rdx],rcx
       jne       near ptr M01_L22
       jmp       near ptr M01_L23
M01_L32:
       mov       rbp,[rbx+8]
       mov       rbx,[rbx+10]
       xor       r14d,r14d
       mov       rdx,[rbp+8]
       mov       r15,rdx
       test      r15,r15
       je        short M01_L33
       mov       rcx,offset MT_System.Net.Http.Headers.HeaderEntry[]
       cmp       [r15],rcx
       je        short M01_L33
       xor       r15d,r15d
M01_L33:
       test      r15,r15
       jne       near ptr M01_L39
       test      rdx,rdx
       je        short M01_L35
       mov       rcx,rdx
       test      rcx,rcx
       je        short M01_L34
       mov       rax,offset MT_System.Collections.Generic.Dictionary<System.Net.Http.Headers.HeaderDescriptor, System.Object>
       cmp       [rcx],rax
       je        short M01_L34
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rcx,rax
M01_L34:
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE706BF8]
       mov       r14,rax
M01_L35:
       test      r14,r14
       je        near ptr M01_L46
       mov       r15,[r14]
       test      r15,r15
       jne       near ptr M01_L51
M01_L36:
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,r15
       call      00007FFD3DC49BA0
       cmp       rax,r15
       jne       near ptr M01_L100
       mov       r15,rbp
M01_L37:
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [7FFCDE67F300]; System.Net.Http.Headers.HttpHeaders.ParseRawHeaderValues(System.Net.Http.Headers.HeaderDescriptor, HeaderStoreItemInfo)
M01_L38:
       add       r15,10
       cmp       qword ptr [r15],0
       jne       near ptr M01_L52
       mov       rcx,r15
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L56
M01_L39:
       xor       r13d,r13d
       cmp       dword ptr [rbp+10],0
       jle       short M01_L35
M01_L40:
       cmp       [r15+8],r13d
       jle       near ptr M01_L35
       cmp       r13d,[r15+8]
       jae       near ptr M01_L106
       mov       rcx,r13
       shl       rcx,4
       mov       rdx,[r15+rcx+18]
       test      rbx,rbx
       je        short M01_L44
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       short M01_L44
       test      rdx,rdx
       jne       near ptr M01_L99
M01_L41:
       xor       edx,edx
M01_L42:
       mov       rcx,rbx
       mov       r8d,5
       call      qword ptr [7FFCDE20CC90]; System.String.Equals(System.String, System.String, System.StringComparison)
       test      eax,eax
       je        short M01_L45
M01_L43:
       mov       ecx,r13d
       cmp       ecx,[r15+8]
       jae       near ptr M01_L106
       shl       rcx,4
       lea       r14,[r15+rcx+10]
       jmp       near ptr M01_L35
M01_L44:
       cmp       rbx,rdx
       je        short M01_L43
M01_L45:
       inc       r13d
       cmp       r13d,[rbp+10]
       jge       near ptr M01_L35
       jmp       near ptr M01_L40
M01_L46:
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rax,[rbp+8]
       test      rax,rax
       je        short M01_L47
       mov       rcx,offset MT_System.Net.Http.Headers.HeaderEntry[]
       cmp       [rax],rcx
       je        short M01_L47
       xor       eax,eax
M01_L47:
       test      rax,rax
       je        short M01_L48
       mov       r14d,[rbp+10]
       cmp       [rax+8],r14d
       ja        short M01_L50
M01_L48:
       mov       rcx,rbp
       mov       rdx,rbx
       call      qword ptr [7FFCDE67EDF0]; System.Net.Http.Headers.HttpHeaders.GetValueRefOrAddDefault(System.Net.Http.Headers.HeaderDescriptor)
       mov       rcx,rax
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L49:
       jmp       near ptr M01_L38
M01_L50:
       cmp       r14d,[rax+8]
       jae       near ptr M01_L106
       mov       ecx,r14d
       shl       rcx,4
       lea       r14,[rax+rcx+10]
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+10]
       jmp       short M01_L49
M01_L51:
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       cmp       [r15],rcx
       jne       near ptr M01_L36
       jmp       near ptr M01_L37
M01_L52:
       mov       rdx,[r15]
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbx,rax
       test      rbx,rbx
       jne       near ptr M01_L55
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Object[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r15]
       mov       r8,rdx
       test      r8,r8
       je        short M01_L53
       mov       rcx,offset MT_System.Object
       cmp       [r8],rcx
       je        short M01_L53
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M01_L53:
       inc       dword ptr [rbx+14]
       mov       rcx,[rbx+8]
       mov       edx,[rbx+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L101
       lea       eax,[rdx+1]
       mov       [rbx+10],eax
       movsxd    rdx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M01_L54:
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L55:
       inc       dword ptr [rbx+14]
       mov       rcx,[rbx+8]
       mov       edx,[rbx+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L102
       lea       r8d,[rdx+1]
       mov       [rbx+10],r8d
       movsxd    rdx,edx
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M01_L56:
       mov       rcx,[rdi+20]
       test      rcx,rcx
       jne       short M01_L57
       mov       rcx,offset MT_System.Net.Http.Headers.HttpRequestHeaders
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       word ptr [rbx+14],413
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
M01_L57:
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE67DCF8]; System.Net.Http.Headers.HttpRequestHeaders.get_AcceptEncoding()
       mov       rdx,28BBC000188
       mov       rbx,[rdx]
       cmp       [rax],al
       mov       rdx,[rax+10]
       test      rdx,rdx
       jne       short M01_L60
M01_L58:
       xor       edx,edx
M01_L59:
       test      rdx,rdx
       je        short M01_L61
       mov       rdx,[rdx+10]
       mov       rcx,28BBC0005C8
       cmp       rdx,[rcx]
       jne       short M01_L61
       mov       rdx,rbx
       mov       rcx,offset MT_System.String
       call      qword ptr [7FFCDE036328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L60:
       mov       rcx,offset MT_System.Net.Http.Headers.KnownHeader
       cmp       [rdx],rcx
       jne       short M01_L58
       jmp       short M01_L59
M01_L61:
       mov       rsi,[rax+8]
       mov       rbp,[rax+10]
       cmp       [rsi],sil
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFCDE67F288]; System.Net.Http.Headers.HttpHeaders.GetValueRefOrNullRef(System.Net.Http.Headers.HeaderDescriptor)
       mov       r14,rax
       test      r14,r14
       jne       near ptr M01_L66
       xor       ecx,ecx
       mov       [rsp+38],rcx
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rax,[rsi+8]
       test      rax,rax
       je        short M01_L62
       mov       rcx,offset MT_System.Net.Http.Headers.HeaderEntry[]
       cmp       [rax],rcx
       je        short M01_L62
       xor       eax,eax
M01_L62:
       test      rax,rax
       je        short M01_L63
       mov       r14d,[rsi+10]
       cmp       [rax+8],r14d
       ja        short M01_L65
M01_L63:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFCDE67EDF0]; System.Net.Http.Headers.HttpHeaders.GetValueRefOrAddDefault(System.Net.Http.Headers.HeaderDescriptor)
       mov       rcx,rax
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L64:
       jmp       near ptr M01_L71
M01_L65:
       cmp       r14d,[rax+8]
       jae       near ptr M01_L106
       mov       ecx,r14d
       shl       rcx,4
       lea       r14,[rax+rcx+10]
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+10]
       jmp       short M01_L64
M01_L66:
       mov       r15,[r14]
       test      r15,r15
       je        short M01_L67
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       cmp       [r15],rcx
       jne       short M01_L67
       mov       rsi,r15
       jmp       short M01_L68
M01_L67:
       xor       esi,esi
M01_L68:
       test      rsi,rsi
       je        short M01_L69
       jmp       short M01_L70
M01_L69:
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,r15
       call      00007FFD3DC49BA0
       cmp       rax,r15
       jne       near ptr M01_L103
M01_L70:
       mov       [rsp+38],rsi
       mov       rcx,rbp
       mov       rdx,[rsp+38]
       call      qword ptr [7FFCDE67F300]; System.Net.Http.Headers.HttpHeaders.ParseRawHeaderValues(System.Net.Http.Headers.HeaderDescriptor, HeaderStoreItemInfo)
       mov       r15,[rsp+38]
M01_L71:
       xor       edx,edx
       mov       [rsp+38],rdx
       add       r15,10
       cmp       qword ptr [r15],0
       je        near ptr M01_L75
       mov       rdx,[r15]
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M01_L74
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Object[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r15]
       mov       r8,rdx
       test      r8,r8
       je        short M01_L72
       mov       rcx,offset MT_System.Object
       cmp       [r8],rcx
       je        short M01_L72
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M01_L72:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L104
       lea       eax,[rdx+1]
       mov       [rsi+10],eax
       movsxd    rdx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M01_L73:
       mov       rcx,r15
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L74:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L105
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       movsxd    rdx,edx
       mov       r8,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M01_L76
M01_L75:
       mov       rcx,r15
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L76:
       mov       rax,rdi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L77:
       mov       ecx,1F09
       mov       rdx,7FFCDE3504A8
       call      qword ptr [7FFCDE03F228]
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFCDE7066A0]
       int       3
M01_L78:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCDE706A48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDE3D61A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L79:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFCDE706A48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDE3D61A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L80:
       mov       ecx,1F09
       mov       rdx,7FFCDE3504A8
       call      qword ptr [7FFCDE03F228]
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFCDE7066A0]
       int       3
M01_L81:
       mov       rcx,rsi
       call      qword ptr [7FFCDE706A00]
       int       3
M01_L82:
       test      rdx,rdx
       jne       short M01_L84
M01_L83:
       xor       r14d,r14d
       jmp       near ptr M01_L08
M01_L84:
       cmp       dword ptr [rdx+8],0A
       jne       short M01_L83
       mov       rcx,2CC3B0B079C
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFCDE705D58]
       test      eax,eax
       je        short M01_L83
       jmp       near ptr M01_L08
M01_L85:
       mov       rcx,2CC3B0B079C
       mov       r8,28BBC000748
       mov       r8,[r8]
       add       r8,8
       mov       edx,0A
       call      qword ptr [7FFCDE67EFE8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       je        short M01_L86
       xor       ecx,ecx
       mov       [rsp+48],rcx
       jmp       near ptr M01_L15
M01_L86:
       mov       rcx,2CC3B0B0790
       mov       [rsp+48],rcx
       jmp       near ptr M01_L09
M01_L87:
       xor       esi,esi
       jmp       short M01_L89
M01_L88:
       mov       edx,esi
       shl       rdx,4
       mov       rdx,[r14+rdx+18]
       lea       rcx,[rsp+40]
       call      qword ptr [7FFCDE707D80]
       test      eax,eax
       jne       short M01_L90
       inc       esi
M01_L89:
       cmp       esi,[rbp+10]
       jge       short M01_L91
       cmp       [r14+8],esi
       jg        short M01_L88
       jmp       short M01_L91
M01_L90:
       mov       ecx,esi
       shl       rcx,4
       lea       r14,[r14+rcx+10]
       jmp       near ptr M01_L14
M01_L91:
       mov       esi,[rbp+10]
       inc       dword ptr [rbp+10]
       cmp       [r14+8],esi
       jbe       short M01_L92
       mov       ecx,esi
       shl       rcx,4
       lea       rcx,[r14+rcx+18]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,esi
       shl       rcx,4
       lea       r14,[r14+rcx+10]
       jmp       near ptr M01_L14
M01_L92:
       mov       rcx,rbp
       mov       rdx,[rsp+40]
       call      qword ptr [7FFCDE706DA8]
       mov       r14,rax
       jmp       near ptr M01_L14
M01_L93:
       mov       rcx,rsi
       mov       rdx,[rsp+40]
       call      qword ptr [7FFCDE706DC0]
       mov       r14,rax
       jmp       near ptr M01_L14
M01_L94:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       short M01_L95
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L95:
       cmp       [rbp],bpl
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,7FFCDE6E4B68
       call      qword ptr [7FFCDE67EDC0]; System.Net.Http.Headers.HttpHeaders.AddValueToStoreValue[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Object ByRef)
       jmp       near ptr M01_L15
M01_L96:
       mov       rcx,offset MT_System.Func<System.Net.Http.Headers.HttpRequestHeaders, System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.StringWithQualityHeaderValue>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,28BBC0006F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset System.Net.Http.Headers.HttpRequestHeaders+<>c.<get_AcceptEncoding>b__20_0(System.Net.Http.Headers.HttpRequestHeaders)
       call      qword ptr [7FFCDE036BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28BBC000710
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L17
M01_L97:
       mov       rdx,rbx
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14,rax
       jmp       near ptr M01_L19
M01_L98:
       call      qword ptr [7FFCDE036328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L99:
       cmp       [rdx],rcx
       jne       near ptr M01_L41
       jmp       near ptr M01_L42
M01_L100:
       mov       rdx,rax
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       call      qword ptr [7FFCDE036328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M01_L37
M01_L101:
       mov       rcx,rbx
       mov       rdx,r8
       call      qword ptr [7FFCDE0371C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L54
M01_L102:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFCDE0371C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L56
M01_L103:
       mov       rdx,rax
       mov       rcx,offset MT_System.Net.Http.Headers.HttpHeaders+HeaderStoreItemInfo
       call      qword ptr [7FFCDE036328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M01_L70
M01_L104:
       mov       rcx,rsi
       mov       rdx,r8
       call      qword ptr [7FFCDE0371C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L73
M01_L105:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFCDE0371C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L76
M01_L106:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3626
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.TimeSpan, System.Private.CoreLib]](System.TimeSpan ByRef)
       ret
; Total bytes of code 1
```
```assembly
; System.Threading.CancellationTokenSource.ExecuteCallbackHandlers(Boolean)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-38],xmm4
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       lea       rax,[rcx+18]
       xor       edx,edx
       xchg      rdx,[rax]
       mov       [rbp-28],rdx
       test      rdx,rdx
       jne       short M03_L01
       add       rcx,20
       mov       eax,2
       xchg      eax,[rcx]
M03_L00:
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M03_L01:
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       rdx,[rbp-28]
       mov       [rdx+30],eax
       xor       ecx,ecx
       mov       [rbp-30],rcx
M03_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFCDE707DB0]
       nop
       mov       rcx,[rbp-28]
       mov       rbx,[rcx+10]
       test      rbx,rbx
       je        short M03_L04
       cmp       qword ptr [rbx+18],0
       je        short M03_L03
       mov       rdx,[rbx+18]
       xor       eax,eax
       mov       [rdx+10],rax
M03_L03:
       mov       rdx,[rbx+18]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+40]
       mov       rsi,[rbp-28]
       mov       [rsi+28],rcx
       xor       ecx,ecx
       mov       [rbx+40],rcx
       mov       byte ptr [rsi+34],0
       jmp       short M03_L05
M03_L04:
       call      M03_L10
       jmp       near ptr M03_L09
M03_L05:
       cmp       qword ptr [rbx+38],0
       je        near ptr M03_L08
       mov       rdi,[rbx+38]
       mov       rcx,offset MT_System.Threading.CancellationTokenSource+<>c
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,28BBC000800
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M03_L07
       mov       rcx,offset MT_System.Threading.SendOrPostCallback
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.CancellationTokenSource+<>c
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,28BBC0007F0
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M03_L06
       call      qword ptr [7FFCDE705F38]
       int       3
M03_L06:
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFCDE702EE0
       mov       [r14+18],rcx
       mov       rcx,offset MT_System.Threading.CancellationTokenSource+<>c
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,28BBC000800
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
M03_L07:
       mov       rcx,rdi
       mov       r8,rbx
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+30],eax
       jmp       near ptr M03_L02
M03_L08:
       mov       rcx,rbx
       call      qword ptr [7FFCDE706F28]
       jmp       near ptr M03_L02
M03_L09:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+20],2
       mov       rcx,[rbp-28]
       add       rcx,28
       xor       eax,eax
       xchg      rax,[rcx]
       cmp       qword ptr [rbp-30],0
       je        near ptr M03_L00
       mov       rcx,offset MT_System.AggregateException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,[rbp-30]
       call      qword ptr [7FFCDE706F40]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L10:
       sub       rsp,28
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+34],0
       add       rsp,28
       ret
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,offset MT_System.Exception
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M03_L11
       xor       eax,eax
       jmp       short M03_L12
M03_L11:
       mov       [rbp-38],rax
       cmp       byte ptr [rbp+18],0
       sete      al
       movzx     eax,al
M03_L12:
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,[rbp-30]
       cmp       qword ptr [rbp-30],0
       jne       short M03_L13
       mov       rcx,offset MT_System.Collections.Generic.List<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDE3D6880]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       [rbp-30],rbx
       mov       rcx,rbx
M03_L13:
       inc       dword ptr [rcx+14]
       mov       r8,[rcx+8]
       mov       edx,[rcx+10]
       cmp       [r8+8],edx
       jbe       short M03_L14
       lea       eax,[rdx+1]
       mov       [rcx+10],eax
       mov       rcx,r8
       mov       r8,[rbp-38]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M03_L15
M03_L14:
       mov       rdx,[rbp-38]
       call      qword ptr [7FFCDE0371C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L15:
       lea       rax,[M03_L02]
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+20],2
       mov       rcx,[rbp-28]
       add       rcx,28
       xor       eax,eax
       xchg      rax,[rcx]
       add       rsp,28
       ret
; Total bytes of code 673
```

